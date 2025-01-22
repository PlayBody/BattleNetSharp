using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
// [Ares] removed just for a while
// using Google.Protobuf;
using Microsoft.CSharp.RuntimeBinder;
using Utilities;

namespace D2Packets
{
	// Token: 0x02000996 RID: 2454
	public class Packet
	{
		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600BA79 RID: 47737 RVA: 0x0046A0CD File Offset: 0x004682CD
		// (set) Token: 0x0600BA7A RID: 47738 RVA: 0x0046A0D5 File Offset: 0x004682D5
		public GameVersion PacketVersion { get; set; } = Packet.VersionForNewPackets;

		// Token: 0x0600BA7B RID: 47739 RVA: 0x0046A0DE File Offset: 0x004682DE
		public Packet()
		{
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x0046A0F3 File Offset: 0x004682F3
		public Packet(BitReader reader)
		{
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600BA7D RID: 47741 RVA: 0x0046A108 File Offset: 0x00468308
		// (set) Token: 0x0600BA7E RID: 47742 RVA: 0x0046A125 File Offset: 0x00468325
		public IEnumerable<byte> Bytes
		{
			get
			{
				return this.ToArray().ToList<byte>();
			}
			set
			{
				this.FromBytes(value.ToArray<byte>());
			}
		}

		// Token: 0x17003912 RID: 14610
		// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x0046A135 File Offset: 0x00468335
		public BitReader BitReader
		{
			set
			{
				this.FromBitReader(value);
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x0046A140 File Offset: 0x00468340
		public long NumBytesRead
		{
			get
			{
				FieldInfo field = base.GetType().GetField("Length", BindingFlags.Instance | BindingFlags.Public);
				bool flag = field != null;
				long num;
				if (flag)
				{
					object value = field.GetValue(this);
					bool flag2 = value is byte;
					if (flag2)
					{
						num = (long)((ulong)((byte)field.GetValue(this)));
					}
					else
					{
						num = (long)((ulong)((ushort)field.GetValue(this)));
					}
				}
				else
				{
					BinaryReader binaryReader = this.reader;
					num = ((binaryReader != null && binaryReader.BaseStream.Position > 0L) ? this.reader.BaseStream.Position : ((long)this.ToArray().Length));
				}
				return num;
			}
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x0046A1E4 File Offset: 0x004683E4
		public string ReadString()
		{
			bool flag = this.reader.BaseStream.Position == this.reader.BaseStream.Length;
			string text;
			if (flag)
			{
				text = "";
			}
			else
			{
				List<byte> list = new List<byte>();
				byte b;
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				IEnumerable<byte> enumerable = list.Take(list.Count<byte>() - 1);
				text = Encoding.ASCII.GetString(enumerable.ToArray<byte>());
			}
			return text;
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x0046A26C File Offset: 0x0046846C
		public Guid ReadGuid()
		{
			byte b = this.reader.ReadByte();
			byte b2 = this.reader.ReadByte();
			return new Guid(BitConverter.GetBytes(this.ReadPackedUInt64(b)).Concat(BitConverter.GetBytes(this.ReadPackedUInt64(b2))).ToArray<byte>());
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x0046A2C0 File Offset: 0x004684C0
		public ulong ReadPackedUInt64(byte mask)
		{
			bool flag = mask == 0;
			ulong num;
			if (flag)
			{
				num = 0UL;
			}
			else
			{
				ulong num2 = 0UL;
				for (int i = 0; i < 8; i++)
				{
					bool flag2 = ((int)mask & (1 << i)) != 0;
					if (flag2)
					{
						num2 += (ulong)this.reader.ReadByte() << i * 8;
					}
				}
				num = num2;
			}
			return num;
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x0046A320 File Offset: 0x00468520
		private uint PackUInt64(ulong value, out byte mask, out byte[] result)
		{
			uint num = 0U;
			mask = 0;
			result = new byte[8];
			byte b = 0;
			while (value > 0UL)
			{
				bool flag = (value & 255UL) > 0UL;
				if (flag)
				{
					mask |= (byte)(1 << (int)b);
					result[(int)num++] = (byte)(value & 255UL);
				}
				value >>= 8;
				b += 1;
			}
			return num;
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x0046A38C File Offset: 0x0046858C
		public void WritePackedGuid(Guid guid)
		{
			byte b;
			byte[] array;
			uint num = this.PackUInt64(BitConverter.ToUInt64(guid.ToByteArray().Take(8).ToArray<byte>()), out b, out array);
			byte b2;
			byte[] array2;
			uint num2 = this.PackUInt64(BitConverter.ToUInt64(guid.ToByteArray().Skip(8).ToArray<byte>()), out b2, out array2);
			this.writer.Write(b);
			this.writer.Write(b2);
			this.writer.Write(array, 0, (int)num);
			this.writer.Write(array2, 0, (int)num2);
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x0046A424 File Offset: 0x00468624
		public void WritePackedUInt64(ulong guid)
		{
			byte b;
			byte[] array;
			uint num = this.PackUInt64(guid, out b, out array);
			this.writer.Write(b);
			this.writer.Write(array, 0, (int)num);
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x0046A45A File Offset: 0x0046865A
		public virtual void FromBitReader(BitReader bitReader)
		{
			this.Bytes = bitReader.ReadBytes((uint)this.ToArray().Length);
		}

        // Token: 0x0600BA88 RID: 47752 RVA: 0x0046A474 File Offset: 0x00468674
        // [Ares] from GPT
        public virtual void FromBytes(byte[] Bytes)
        {
            this.memoryStream = new MemoryStream(Bytes);
            this.reader = new BinaryReader(this.memoryStream);
            var fields = from f in GetType().GetFields() orderby f.MetadataToken select f;
            int listCount = -1;

            foreach (var field in fields)
            {
                if (this.reader.BaseStream.Position >= this.reader.BaseStream.Length)
                    break;

                var minVersionAttr = field.GetCustomAttributes(typeof(MinVersion), true).FirstOrDefault() as MinVersion;
                if (minVersionAttr != null && minVersionAttr.Version > this.PacketVersion)
                    continue;

                var maxVersionAttr = field.GetCustomAttributes(typeof(MaxVersion), true).FirstOrDefault() as MaxVersion;
                if (maxVersionAttr != null && maxVersionAttr.Version < this.PacketVersion)
                    continue;

                Type fieldType = field.FieldType;
                bool isEnum = fieldType.IsEnum;
                if (isEnum)
                    fieldType = Enum.GetUnderlyingType(fieldType);

                if (fieldType == typeof(byte))
                {
                    field.SetValue(this, this.reader.ReadByte());
                }
                else if (fieldType == typeof(ushort))
                {
                    field.SetValue(this, this.reader.ReadUInt16());
                }
                else if (fieldType == typeof(uint))
                {
                    field.SetValue(this, this.reader.ReadUInt32());
                }
                else if (fieldType == typeof(ulong))
                {
                    field.SetValue(this, this.reader.ReadUInt64());
                }
                else if (fieldType == typeof(float))
                {
                    field.SetValue(this, BitConverter.ToSingle(this.reader.ReadBytes(4)));
                }
                else if (fieldType == typeof(Guid))
                {
                    field.SetValue(this, this.ReadGuid());
                }
                else if (fieldType == typeof(string))
                {
                    int stringLength = -1;
                    if (field.Name.Contains("_"))
                        stringLength = int.Parse(field.Name.Split('_').Last());

                    field.SetValue(this, this.reader.ReadString(stringLength));
                }
                else if (fieldType == typeof(DateTime))
                {
                    field.SetValue(this, DateTime.FromBinary((long)this.reader.ReadUInt64()));
                }
                else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    Type itemType = fieldType.GetGenericArguments()[0];
                    var listInstance = Activator.CreateInstance(fieldType);

                    if (field.Name.Contains("_"))
                    {
                        listCount = int.Parse(field.Name.Split('_').Last());
                    }
                    else if (fields.Any(f => f.Name == "Num" + field.Name))
                    {
                        listCount = Convert.ToInt32(fields.First(f => f.Name == "Num" + field.Name).GetValue(this));
                    }

                    for (int i = 0; i < listCount; i++)
                    {
                        object itemValue = itemType == typeof(string) ? this.reader.ReadString() : Activator.CreateInstance(itemType);
                        if (itemType.IsSubclassOf(typeof(Packet)))
                        {
                            ((Packet)itemValue).FromBytes(this.reader.ReadBytes((int)(this.reader.BaseStream.Length - this.reader.BaseStream.Position)));
                        }

                        fieldType.GetMethod("Add").Invoke(listInstance, new object[] { itemValue });
                    }

                    field.SetValue(this, listInstance);
                }
                else if (fieldType.IsSubclassOf(typeof(Packet)))
                {
                    var nestedPacket = Activator.CreateInstance(fieldType) as Packet;
                    nestedPacket.FromBytes(this.reader.ReadBytes((int)(this.reader.BaseStream.Length - this.reader.BaseStream.Position)));
                    field.SetValue(this, nestedPacket);
                }
            }
        }

        // Token: 0x0600BA89 RID: 47753 RVA: 0x0046B8B0 File Offset: 0x00469AB0
        // [Ares] from GPT
        public virtual byte[] ToArray()
        {
            this.memoryStream = new MemoryStream();
            this.writer = new BinaryWriter(this.memoryStream);

            IOrderedEnumerable<FieldInfo> orderedFields = from f in base.GetType().GetFields()
                                                          orderby f.MetadataToken
                                                          select f;

            long lengthPosition = 0;
            int lengthFieldSize = 2; // Default for ushort length field
            foreach (var fieldInfo in orderedFields)
            {
                // Check version constraints
                var minVersion = fieldInfo.GetCustomAttributes(typeof(MinVersion), true).FirstOrDefault() as MinVersion;
                if (minVersion != null && minVersion.Version > this.PacketVersion)
                    continue;

                var maxVersion = fieldInfo.GetCustomAttributes(typeof(MaxVersion), true).FirstOrDefault() as MaxVersion;
                if (maxVersion != null && maxVersion.Version < this.PacketVersion)
                    continue;

                // Handle the Length field
                if (fieldInfo.Name == "Length")
                {
                    lengthPosition = this.writer.BaseStream.Position;
                    if (fieldInfo.FieldType == typeof(byte))
                        lengthFieldSize = 1;
                }

                // Get field value and handle enums
                object fieldValue = fieldInfo.GetValue(this);
                if (fieldInfo.FieldType.IsEnum)
                {
                    if (fieldInfo.Name == "PacketId")
                    {
                        if (this.PacketVersion == GameVersion.D2R && fieldInfo.FieldType == typeof(GameClientPacket))
                            fieldValue = Enum.Parse(typeof(GameClientPacketD2R), base.GetType().Name.Replace("C2S", "").Replace("S2C", ""));
                        else
                            fieldValue = Enum.Parse(fieldInfo.FieldType, base.GetType().Name.Replace("C2S", "").Replace("S2C", ""));
                    }
                    fieldValue = Convert.ChangeType(fieldValue, Enum.GetUnderlyingType(fieldInfo.FieldType));
                }

                // Write field value based on its type
                switch (fieldValue)
                {
                    case byte b:
                        this.writer.Write(b);
                        break;
                    case bool b:
                        this.writer.Write(Convert.ToByte(b));
                        break;
                    case ushort us:
                        this.writer.Write(us);
                        break;
                    case uint ui:
                        this.writer.Write(ui);
                        break;
                    case short s:
                        this.writer.Write(s);
                        break;
                    case int i:
                        this.writer.Write(i);
                        break;
                    case long l:
                        this.writer.Write(l);
                        break;
                    case float f:
                        this.writer.Write(BitConverter.GetBytes(f));
                        break;
                    case ulong ul:
                        this.writer.Write(ul);
                        break;
                    case Guid g:
                        this.WritePackedGuid(g);
                        break;
                    case byte[] byteArray:
                        this.writer.Write(byteArray);
                        break;
                    case string str:
                        this.writer.Write(Encoding.UTF8.GetBytes(str + "\0"));
                        break;
                    case DateTime dt:
                        this.writer.Write(dt.ToBinary());
                        break;
                    default:
                        if (fieldInfo.FieldType.IsSubclassOf(typeof(Packet)))
                        {
                            this.writer.Write(((Packet)fieldValue).ToArray());
                        }
                        else
                        {
                            throw new Exception("Need to parse this type: " + fieldInfo.FieldType);
                        }
                        break;
                }
            }

            // Convert memory stream to byte array
            byte[] result = this.memoryStream.ToArray();

            // If the Length field exists, adjust it
            if (orderedFields.Any(f => f.Name == "Length"))
            {
                Array.Copy(BitConverter.GetBytes((ushort)result.Length), 0L, result, lengthPosition, lengthFieldSize);
            }

            return result;
        }


        // Token: 0x0600BA8A RID: 47754 RVA: 0x0046C100 File Offset: 0x0046A300
        // [Ares] copied from GPT
        public override string ToString()
        {
            string text = "";
            var orderedEnumerable = from f in base.GetType().GetFields()
                                    orderby f.MetadataToken
                                    select f;

            foreach (FieldInfo fieldInfo in orderedEnumerable)
            {
                object value = fieldInfo.GetValue(this);
                Type type = value?.GetType();
                text += $"\t{fieldInfo.Name} ({type?.ToString()}) = {value?.ToString()}\n";

                if (fieldInfo.FieldType.ToString().Contains("List"))
                {
                    var obj = value as IEnumerable;

                    if (obj == null)
                    {
                        text += "\t\tnull\n";
                    }
                    else
                    {
                        foreach (var item in obj)
                        {
                            string itemString = item?.ToString() ?? "null";
                            text += $"\t\t{itemString}\n";
                        }
                    }
                }
            }
            return text;
        }

        // Token: 0x040088FC RID: 35068
        protected MemoryStream memoryStream;

		// Token: 0x040088FD RID: 35069
		protected BinaryWriter writer;

		// Token: 0x040088FE RID: 35070
		protected BinaryReader reader;

		// Token: 0x040088FF RID: 35071
		public static GameVersion VersionForNewPackets = GameVersion.D2R;
	}
}
