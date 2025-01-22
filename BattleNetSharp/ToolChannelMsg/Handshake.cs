using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000011 RID: 17
	public sealed class Handshake : IMessage<Handshake>, IMessage, IEquatable<Handshake>, IDeepCloneable<Handshake>, IBufferMessage
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004D5C File Offset: 0x00002F5C
		[DebuggerNonUserCode]
		public static MessageParser<Handshake> Parser
		{
			get
			{
				return Handshake._parser;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004D74 File Offset: 0x00002F74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InternalReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004D98 File Offset: 0x00002F98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Handshake.Descriptor;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004DAF File Offset: 0x00002FAF
		[DebuggerNonUserCode]
		public Handshake()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004DB9 File Offset: 0x00002FB9
		[DebuggerNonUserCode]
		public Handshake(Handshake other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platform_ = other.platform_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004DF8 File Offset: 0x00002FF8
		[DebuggerNonUserCode]
		public Handshake Clone()
		{
			return new Handshake(this);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004E10 File Offset: 0x00003010
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00004E41 File Offset: 0x00003041
		[DebuggerNonUserCode]
		public Platform Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				Platform platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = Handshake.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004E5C File Offset: 0x0000305C
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004E79 File Offset: 0x00003079
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00004EBD File Offset: 0x000030BD
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Handshake.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004ED8 File Offset: 0x000030D8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004EF5 File Offset: 0x000030F5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004F08 File Offset: 0x00003108
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Handshake);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004F28 File Offset: 0x00003128
		[DebuggerNonUserCode]
		public bool Equals(Handshake other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.Platform != other.Platform;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004F9C File Offset: 0x0000319C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005010 File Offset: 0x00003210
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005028 File Offset: 0x00003228
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005034 File Offset: 0x00003234
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Platform);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000050A4 File Offset: 0x000032A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005110 File Offset: 0x00003310
		[DebuggerNonUserCode]
		public void MergeFrom(Handshake other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005172 File Offset: 0x00003372
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005180 File Offset: 0x00003380
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Platform = (Platform)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly MessageParser<Handshake> _parser = new MessageParser<Handshake>(() => new Handshake());

		// Token: 0x04000063 RID: 99
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000064 RID: 100
		private int _hasBits0;

		// Token: 0x04000065 RID: 101
		public const int PlatformFieldNumber = 1;

		// Token: 0x04000066 RID: 102
		private static readonly Platform PlatformDefaultValue = Platform.PcClient;

		// Token: 0x04000067 RID: 103
		private Platform platform_;

		// Token: 0x04000068 RID: 104
		public const int IdFieldNumber = 2;

		// Token: 0x04000069 RID: 105
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x0400006A RID: 106
		private uint id_;
	}
}
