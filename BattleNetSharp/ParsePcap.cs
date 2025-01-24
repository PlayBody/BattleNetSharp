using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PacketDotNet;
using PacketDotNet.Connections;
using SharpPcap;
using SharpPcap.LibPcap;
using Utilities;

namespace BattleNetSharp
{
	// Token: 0x02000AD1 RID: 2769
	internal class ParsePcap
	{
		// Token: 0x0600BC6B RID: 48235 RVA: 0x0047B488 File Offset: 0x00479688
		public static void Parse2(string pcap)
		{
			ICaptureDevice captureDevice = new CaptureFileReaderDevice(pcap);
			TcpStream tcpStream = new TcpStream();
            PacketCapture packetCapture = default;
            while (captureDevice.GetNextPacket(out packetCapture) == GetPacketStatus.PacketRead)
			{
				RawCapture packet = packetCapture.GetPacket();
				Packet packet2 = Packet.ParsePacket(packet.LinkLayerType, packet.Data);
				TcpPacket tcpPacket = packet2.Extract<TcpPacket>();
				tcpStream.AppendPacket(tcpPacket);
			}
			for (;;)
			{
				long position = tcpStream.Position;
				bool flag = tcpStream.AdvanceToNextPacket();
			}
		}

        // Token: 0x0600BC6C RID: 48236 RVA: 0x0047B504 File Offset: 0x00479704
        public static void Parse(string pcap)
        {
            ICaptureDevice captureDevice = new CaptureFileReaderDevice(pcap);
            captureDevice.Open(new DeviceConfiguration());
            List<byte> sessionData = new List<byte>();

            while (true)
            {
                PacketCapture packetCapture = default;
                if (captureDevice.GetNextPacket(out packetCapture) == GetPacketStatus.NoRemainingPackets)
                    break;

                Packet payloadPacket = packetCapture.GetPacket().GetPacket().PayloadPacket?.PayloadPacket;
                if (payloadPacket is TcpPacket tcp && (tcp.SourcePort == 1119 || tcp.DestinationPort == 1119))
                {
                    if (TLS.TlsDecryptSessions.Count > 0 && tcp.Acknowledgment && !tcp.Push)
                    {
                        sessionData = tcp.PayloadDataSegment.ToList();
                    }

                    if (tcp.PayloadDataSegment.Length > 0)
                    {
                        TlsPacket tlsPacket = new TlsPacket(tcp.PayloadDataSegment);

                        foreach (TlsRecordLayer recordLayer in tlsPacket.RecordLayers)
                        {
                            if (recordLayer is TlsHandshakeRecord handshakeRecord)
                            {
                                foreach (HandshakeProtocol handshakeProtocol in handshakeRecord.HandshakeProtocols)
                                {
                                    if (handshakeProtocol is ClientHelloProtocol clientHelloProtocol)
                                    {
                                        string clientRandomString = BitConverter.ToString(clientHelloProtocol.Random.RandomBytes).Replace("-", "");
                                        string keyLogEntry = File.ReadAllLines("C:\\Users\\andy\\Downloads\\win-frida-scripts-master\\keylog.log")
                                                                 .FirstOrDefault(k => k.Contains(clientRandomString, StringComparison.InvariantCultureIgnoreCase));

                                        if (!string.IsNullOrWhiteSpace(keyLogEntry))
                                        {
                                            TLS.TlsDecryptSessions.Add(new TLS.TlsDecryptSession
                                            {
                                                SrcPort = (int)tcp.SourcePort,
                                                DestPort = (int)tcp.DestinationPort,
                                                ClientRandom = clientHelloProtocol.Random.RandomBytes,
                                                Premaster = Helpers.StringToByteArray(keyLogEntry.Split(' ', StringSplitOptions.None).Last())
                                            });
                                        }
                                    }
                                    else if (handshakeProtocol is ServerHelloProtocol serverHelloProtocol)
                                    {
                                        TLS.TlsDecryptSession session = TLS.TlsDecryptSessions.FirstOrDefault(
                                            t => t.SrcPort == (int)tcp.DestinationPort && t.DestPort == (int)tcp.SourcePort);

                                        if (session != null)
                                        {
                                            session.ServerRandom = serverHelloProtocol.Random.RandomBytes;
                                            session.Update();
                                        }
                                    }
                                }
                            }
                            else if (recordLayer.ContentType == ContentType.ApplicationData)
                            {
                                TLS.TlsDecryptSession session = TLS.TlsDecryptSessions.FirstOrDefault(
                                    t => (t.SrcPort == (int)tcp.SourcePort && t.DestPort == (int)tcp.DestinationPort) ||
                                         (t.SrcPort == (int)tcp.DestinationPort && t.DestPort == (int)tcp.SourcePort));

                                if (session != null)
                                {
                                    Console.WriteLine(session.SrcPort == (int)tcp.SourcePort ? "c2s" : "s2c");
                                    session.DecryptBlock((int)tcp.SourcePort, recordLayer.Data);
                                }
                            }
                        }
                    }
                }
            }

            while (true)
            {
                PacketCapture packetCapture = default;
                if (captureDevice.GetNextPacket(out packetCapture) == GetPacketStatus.NoRemainingPackets)
                    break;

                Packet payloadPacket = packetCapture.GetPacket().GetPacket().PayloadPacket?.PayloadPacket;
                if (payloadPacket is TcpPacket tcpPacket)
                {
                    List<byte> payloadData = tcpPacket.PayloadDataSegment.ToList();
                    if (payloadData.Count > 0 && payloadData[0] == 130)
                    {
                        Console.WriteLine(((IPv4Packet)tcpPacket.ParentPacket).SourceAddress.ToString() == "127.0.0.1" ? "c2s" : "s2c");
                        bool isMasked = (payloadData[1] & 128) == 128;
                        int payloadLength = payloadData[1] & 127;
                        int offset = 2;

                        if (payloadLength == 126)
                        {
                            payloadLength = BitConverter.ToUInt16(payloadData.Skip(2).Take(2).Reverse().ToArray());
                            offset = 4;
                        }

                        byte[] mask = isMasked ? payloadData.Skip(offset).Take(4).ToArray() : new byte[4];
                        offset += isMasked ? 4 : 0;

                        byte[] message = payloadData.Skip(offset).Take(payloadLength).ToArray();
                        for (int i = 0; i < payloadLength; i++)
                        {
                            message[i] ^= mask[i % 4];
                        }
                    }
                }
            }
        }
    }
}
