using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000261 RID: 609
	public sealed class PartyStayInPartyUpdate : IMessage<PartyStayInPartyUpdate>, IMessage, IEquatable<PartyStayInPartyUpdate>, IDeepCloneable<PartyStayInPartyUpdate>, IBufferMessage
	{
		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x000FF16C File Offset: 0x000FD36C
		[DebuggerNonUserCode]
		public static MessageParser<PartyStayInPartyUpdate> Parser
		{
			get
			{
				return PartyStayInPartyUpdate._parser;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x000FF184 File Offset: 0x000FD384
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[81];
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x000FF1A8 File Offset: 0x000FD3A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyStayInPartyUpdate.Descriptor;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x000FF1BF File Offset: 0x000FD3BF
		[DebuggerNonUserCode]
		public PartyStayInPartyUpdate()
		{
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x000FF1C9 File Offset: 0x000FD3C9
		[DebuggerNonUserCode]
		public PartyStayInPartyUpdate(PartyStayInPartyUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.membersStayingCount_ = other.membersStayingCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000FF208 File Offset: 0x000FD408
		[DebuggerNonUserCode]
		public PartyStayInPartyUpdate Clone()
		{
			return new PartyStayInPartyUpdate(this);
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x000FF220 File Offset: 0x000FD420
		// (set) Token: 0x06004177 RID: 16759 RVA: 0x000FF241 File Offset: 0x000FD441
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyStayInPartyUpdate.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x000FF258 File Offset: 0x000FD458
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000FF273 File Offset: 0x000FD473
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600417A RID: 16762 RVA: 0x000FF280 File Offset: 0x000FD480
		// (set) Token: 0x0600417B RID: 16763 RVA: 0x000FF2B1 File Offset: 0x000FD4B1
		[DebuggerNonUserCode]
		public uint MembersStayingCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint membersStayingCountDefaultValue;
				if (flag)
				{
					membersStayingCountDefaultValue = this.membersStayingCount_;
				}
				else
				{
					membersStayingCountDefaultValue = PartyStayInPartyUpdate.MembersStayingCountDefaultValue;
				}
				return membersStayingCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.membersStayingCount_ = value;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x000FF2CC File Offset: 0x000FD4CC
		[DebuggerNonUserCode]
		public bool HasMembersStayingCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x000FF2E9 File Offset: 0x000FD4E9
		[DebuggerNonUserCode]
		public void ClearMembersStayingCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000FF2FC File Offset: 0x000FD4FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyStayInPartyUpdate);
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x000FF31C File Offset: 0x000FD51C
		[DebuggerNonUserCode]
		public bool Equals(PartyStayInPartyUpdate other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MembersStayingCount != other.MembersStayingCount;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x000FF390 File Offset: 0x000FD590
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasMembersStayingCount = this.HasMembersStayingCount;
			if (hasMembersStayingCount)
			{
				num ^= this.MembersStayingCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x000FF3FC File Offset: 0x000FD5FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x000FF414 File Offset: 0x000FD614
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000FF420 File Offset: 0x000FD620
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasMembersStayingCount = this.HasMembersStayingCount;
			if (hasMembersStayingCount)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MembersStayingCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000FF490 File Offset: 0x000FD690
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasMembersStayingCount = this.HasMembersStayingCount;
			if (hasMembersStayingCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MembersStayingCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000FF4FC File Offset: 0x000FD6FC
		[DebuggerNonUserCode]
		public void MergeFrom(PartyStayInPartyUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasMembersStayingCount = other.HasMembersStayingCount;
				if (hasMembersStayingCount)
				{
					this.MembersStayingCount = other.MembersStayingCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000FF55E File Offset: 0x000FD75E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x000FF56C File Offset: 0x000FD76C
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
						this.MembersStayingCount = input.ReadUInt32();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DB2 RID: 7602
		private static readonly MessageParser<PartyStayInPartyUpdate> _parser = new MessageParser<PartyStayInPartyUpdate>(() => new PartyStayInPartyUpdate());

		// Token: 0x04001DB3 RID: 7603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DB4 RID: 7604
		private int _hasBits0;

		// Token: 0x04001DB5 RID: 7605
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001DB6 RID: 7606
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001DB7 RID: 7607
		private string partyId_;

		// Token: 0x04001DB8 RID: 7608
		public const int MembersStayingCountFieldNumber = 2;

		// Token: 0x04001DB9 RID: 7609
		private static readonly uint MembersStayingCountDefaultValue = 0U;

		// Token: 0x04001DBA RID: 7610
		private uint membersStayingCount_;
	}
}
