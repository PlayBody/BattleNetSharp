using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200078D RID: 1933
	public sealed class GameServerPing : IMessage<GameServerPing>, IMessage, IEquatable<GameServerPing>, IDeepCloneable<GameServerPing>, IBufferMessage
	{
		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600B107 RID: 45319 RVA: 0x002B1738 File Offset: 0x002AF938
		[DebuggerNonUserCode]
		public static MessageParser<GameServerPing> Parser
		{
			get
			{
				return GameServerPing._parser;
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x002B1750 File Offset: 0x002AF950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x002B1774 File Offset: 0x002AF974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameServerPing.Descriptor;
			}
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x002B178B File Offset: 0x002AF98B
		[DebuggerNonUserCode]
		public GameServerPing()
		{
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x002B1795 File Offset: 0x002AF995
		[DebuggerNonUserCode]
		public GameServerPing(GameServerPing other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.region_ = other.region_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x002B17D4 File Offset: 0x002AF9D4
		[DebuggerNonUserCode]
		public GameServerPing Clone()
		{
			return new GameServerPing(this);
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600B10D RID: 45325 RVA: 0x002B17EC File Offset: 0x002AF9EC
		// (set) Token: 0x0600B10E RID: 45326 RVA: 0x002B180D File Offset: 0x002AFA0D
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return this.region_ ?? GameServerPing.RegionDefaultValue;
			}
			set
			{
				this.region_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600B10F RID: 45327 RVA: 0x002B1824 File Offset: 0x002AFA24
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return this.region_ != null;
			}
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x002B183F File Offset: 0x002AFA3F
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this.region_ = null;
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600B111 RID: 45329 RVA: 0x002B184C File Offset: 0x002AFA4C
		// (set) Token: 0x0600B112 RID: 45330 RVA: 0x002B187D File Offset: 0x002AFA7D
		[DebuggerNonUserCode]
		public uint Value
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = GameServerPing.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.value_ = value;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x002B1898 File Offset: 0x002AFA98
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x002B18B5 File Offset: 0x002AFAB5
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x002B18C8 File Offset: 0x002AFAC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameServerPing);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x002B18E8 File Offset: 0x002AFAE8
		[DebuggerNonUserCode]
		public bool Equals(GameServerPing other)
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
					bool flag4 = this.Region != other.Region;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Value != other.Value;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x002B195C File Offset: 0x002AFB5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x002B19C8 File Offset: 0x002AFBC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x002B19E0 File Offset: 0x002AFBE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x002B19EC File Offset: 0x002AFBEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Region);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x002B1A5C File Offset: 0x002AFC5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Region);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x002B1AC8 File Offset: 0x002AFCC8
		[DebuggerNonUserCode]
		public void MergeFrom(GameServerPing other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x002B1B2A File Offset: 0x002AFD2A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x002B1B38 File Offset: 0x002AFD38
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadUInt32();
					}
				}
				else
				{
					this.Region = input.ReadString();
				}
			}
		}

		// Token: 0x04004FCD RID: 20429
		private static readonly MessageParser<GameServerPing> _parser = new MessageParser<GameServerPing>(() => new GameServerPing());

		// Token: 0x04004FCE RID: 20430
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FCF RID: 20431
		private int _hasBits0;

		// Token: 0x04004FD0 RID: 20432
		public const int RegionFieldNumber = 1;

		// Token: 0x04004FD1 RID: 20433
		private static readonly string RegionDefaultValue = "";

		// Token: 0x04004FD2 RID: 20434
		private string region_;

		// Token: 0x04004FD3 RID: 20435
		public const int ValueFieldNumber = 2;

		// Token: 0x04004FD4 RID: 20436
		private static readonly uint ValueDefaultValue = 0U;

		// Token: 0x04004FD5 RID: 20437
		private uint value_;
	}
}
