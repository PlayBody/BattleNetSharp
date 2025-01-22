using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000695 RID: 1685
	public sealed class ChannelSlot : IMessage<ChannelSlot>, IMessage, IEquatable<ChannelSlot>, IDeepCloneable<ChannelSlot>, IBufferMessage
	{
		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x002601A0 File Offset: 0x0025E3A0
		[DebuggerNonUserCode]
		public static MessageParser<ChannelSlot> Parser
		{
			get
			{
				return ChannelSlot._parser;
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009C66 RID: 40038 RVA: 0x002601B8 File Offset: 0x0025E3B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009C67 RID: 40039 RVA: 0x002601DC File Offset: 0x0025E3DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelSlot.Descriptor;
			}
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x002601F3 File Offset: 0x0025E3F3
		[DebuggerNonUserCode]
		public ChannelSlot()
		{
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x002601FD File Offset: 0x0025E3FD
		[DebuggerNonUserCode]
		public ChannelSlot(ChannelSlot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reserved_ = other.reserved_;
			this.rejoin_ = other.rejoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x0026023C File Offset: 0x0025E43C
		[DebuggerNonUserCode]
		public ChannelSlot Clone()
		{
			return new ChannelSlot(this);
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x00260254 File Offset: 0x0025E454
		// (set) Token: 0x06009C6C RID: 40044 RVA: 0x00260285 File Offset: 0x0025E485
		[DebuggerNonUserCode]
		public bool Reserved
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool reservedDefaultValue;
				if (flag)
				{
					reservedDefaultValue = this.reserved_;
				}
				else
				{
					reservedDefaultValue = ChannelSlot.ReservedDefaultValue;
				}
				return reservedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reserved_ = value;
			}
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009C6D RID: 40045 RVA: 0x002602A0 File Offset: 0x0025E4A0
		[DebuggerNonUserCode]
		public bool HasReserved
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x002602BD File Offset: 0x0025E4BD
		[DebuggerNonUserCode]
		public void ClearReserved()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009C6F RID: 40047 RVA: 0x002602D0 File Offset: 0x0025E4D0
		// (set) Token: 0x06009C70 RID: 40048 RVA: 0x00260301 File Offset: 0x0025E501
		[DebuggerNonUserCode]
		public bool Rejoin
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool rejoinDefaultValue;
				if (flag)
				{
					rejoinDefaultValue = this.rejoin_;
				}
				else
				{
					rejoinDefaultValue = ChannelSlot.RejoinDefaultValue;
				}
				return rejoinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.rejoin_ = value;
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009C71 RID: 40049 RVA: 0x0026031C File Offset: 0x0025E51C
		[DebuggerNonUserCode]
		public bool HasRejoin
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x00260339 File Offset: 0x0025E539
		[DebuggerNonUserCode]
		public void ClearRejoin()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009C73 RID: 40051 RVA: 0x0026034C File Offset: 0x0025E54C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelSlot);
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x0026036C File Offset: 0x0025E56C
		[DebuggerNonUserCode]
		public bool Equals(ChannelSlot other)
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
					bool flag4 = this.Reserved != other.Reserved;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Rejoin != other.Rejoin;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x002603E0 File Offset: 0x0025E5E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				num ^= this.Reserved.GetHashCode();
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				num ^= this.Rejoin.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x0026044C File Offset: 0x0025E64C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x00260464 File Offset: 0x0025E664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x00260470 File Offset: 0x0025E670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Reserved);
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Rejoin);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x002604E0 File Offset: 0x0025E6E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				num += 2;
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x00260534 File Offset: 0x0025E734
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelSlot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReserved = other.HasReserved;
				if (hasReserved)
				{
					this.Reserved = other.Reserved;
				}
				bool hasRejoin = other.HasRejoin;
				if (hasRejoin)
				{
					this.Rejoin = other.Rejoin;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x00260596 File Offset: 0x0025E796
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x002605A4 File Offset: 0x0025E7A4
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
						this.Rejoin = input.ReadBool();
					}
				}
				else
				{
					this.Reserved = input.ReadBool();
				}
			}
		}

		// Token: 0x0400469D RID: 18077
		private static readonly MessageParser<ChannelSlot> _parser = new MessageParser<ChannelSlot>(() => new ChannelSlot());

		// Token: 0x0400469E RID: 18078
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400469F RID: 18079
		private int _hasBits0;

		// Token: 0x040046A0 RID: 18080
		public const int ReservedFieldNumber = 1;

		// Token: 0x040046A1 RID: 18081
		private static readonly bool ReservedDefaultValue = false;

		// Token: 0x040046A2 RID: 18082
		private bool reserved_;

		// Token: 0x040046A3 RID: 18083
		public const int RejoinFieldNumber = 2;

		// Token: 0x040046A4 RID: 18084
		private static readonly bool RejoinDefaultValue = false;

		// Token: 0x040046A5 RID: 18085
		private bool rejoin_;
	}
}
