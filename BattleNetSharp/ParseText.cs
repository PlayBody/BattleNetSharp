using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using Microsoft.CSharp.RuntimeBinder;

namespace BattleNetSharp
{
	// Token: 0x02000AD2 RID: 2770
	internal class ParseText
	{
        // Token: 0x0600BC6E RID: 48238 RVA: 0x0047BCFC File Offset: 0x00479EFC
        public static void Parse(string pcap)
        {
            string[] lines = File.ReadAllLines(pcap);
            string direction = "c2s";
            string timestamp = "";
            List<byte> dataBuffer = new List<byte>();

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                string targetServer = "las1b-d2r-rclient.diablo2.blizzard.com";

                // Determine the direction based on ports or IP addresses
                if (currentLine.Contains("Dst Port: bnetgame (1119)") || currentLine.Contains("Dst Port: 1119")) direction = "c2bg";
                else if (currentLine.Contains("Dst Port: 57025") || currentLine.Contains("Src: " + targetServer)) direction = "rs2c";
                else if (currentLine.Contains("Src Port: 57025") || currentLine.Contains("Dst: " + targetServer)) direction = "c2rs";
                else if (currentLine.Contains("Src Port: 1119")) direction = "bg2c";

                // Extract timestamp
                if (currentLine.Contains("No.     Time           Source                Destination           Protocol Length Info"))
                {
                    timestamp = lines[i + 1];
                }

                if (!direction.Contains("c2s"))
                {
                    if (!currentLine.Contains("Decrypted TLS")) continue;

                    // Collect and parse payload data
                    dataBuffer.Clear();
                    for (int j = 1; j < lines.Length - i; j++)
                    {
                        string payloadLine = lines[i + j];
                        if (string.IsNullOrEmpty(payloadLine) || payloadLine.Contains("Decrypted") || payloadLine.Contains("Uncompressed")) break;

                        if (payloadLine.Contains("Reassembled"))
                        {
                            for (int k = 1; k < lines.Length - i - j; k++)
                            {
                                payloadLine = lines[i + j + k];
                                if (string.IsNullOrEmpty(payloadLine) || payloadLine.Contains("Decrypted") || payloadLine.Contains("Uncompressed")) break;

                                byte[] payloadBytes = Convert.FromHexString(payloadLine.Substring(6, 48).Replace(" ", ""));
                                dataBuffer.AddRange(payloadBytes);
                            }
                            break;
                        }

                        byte[] lineBytes = Convert.FromHexString(payloadLine.Substring(6, 48).Replace(" ", ""));
                        dataBuffer.AddRange(lineBytes);

                        if (dataBuffer.Count > 1 && dataBuffer[1] == 27)
                        {
                            dataBuffer.InsertRange(0, new byte[] { 130, 33 });
                        }
                    }

                    // Process GameServer and GameClient packets
                    if (direction.Contains("gs"))
                    {
                        while (dataBuffer.Count > 0)
                        {
                            Type packetType = direction == "gs2c" ? typeof(GameServerPacket) : typeof(GameClientPacket);
                            string typeName = packetType.AssemblyQualifiedName.Replace(packetType.Name, ((GameServerPacket)dataBuffer[0]).ToString());
                            Type resolvedType = Type.GetType(typeName);

                            if (resolvedType == null)
                            {
                                Console.WriteLine($"No packet info for: {dataBuffer[0]:X}");
                                break;
                            }

                            Console.Write($"{direction} : {timestamp.Split(' ')[1]} : {resolvedType.Name} : ");
                            object packetInstance = Activator.CreateInstance(resolvedType);
                            resolvedType.GetProperty("Bytes")?.SetValue(packetInstance, dataBuffer);

                            int packetLength = (int)resolvedType.GetProperty("Length")?.GetValue(packetInstance);
                            if (packetLength == 0)
                            {
                                Console.WriteLine("Packet parsing failed.");
                                break;
                            }

                            Console.WriteLine(BitConverter.ToString(dataBuffer.ToArray()));
                            dataBuffer = dataBuffer.Skip(packetLength).ToList();
                        }
                    }
                    else if (dataBuffer.Count > 0 && dataBuffer[0] == 130)
                    {
                        byte[] websocketData = dataBuffer.ToArray();
                        while (websocketData.Length > 4)
                        {
                            bool masked = (websocketData[1] & 128) != 0;
                            int payloadLength = websocketData[1] & 127;
                            int headerLength = 2;

                            if (payloadLength == 126)
                            {
                                payloadLength = BitConverter.ToUInt16(websocketData.Skip(2).Take(2).Reverse().ToArray());
                                headerLength = 4;
                            }

                            byte[] maskKey = masked ? websocketData.Skip(headerLength).Take(4).ToArray() : new byte[4];
                            headerLength += masked ? 4 : 0;

                            byte[] payload = websocketData.Skip(headerLength).Take(payloadLength).ToArray();
                            for (int j = 0; j < payload.Length; j++)
                            {
                                payload[j] ^= maskKey[j % 4];
                            }

                            Console.WriteLine($"{direction} : {timestamp}");
                            websocketData = websocketData.Skip(headerLength + payloadLength).ToArray();
                        }
                    }
                }
            }
        }
    }
}
