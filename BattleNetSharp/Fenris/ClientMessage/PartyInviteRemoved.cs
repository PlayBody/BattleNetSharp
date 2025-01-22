using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000253 RID: 595
	public sealed class PartyInviteRemoved : IMessage<PartyInviteRemoved>, IMessage, IEquatable<PartyInviteRemoved>, IDeepCloneable<PartyInviteRemoved>, IBufferMessage
	{
		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x000FA68C File Offset: 0x000F888C
		[DebuggerNonUserCode]
		public static MessageParser<PartyInviteRemoved> Parser
		{
			get
			{
				return PartyInviteRemoved._parser;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x000FA6A4 File Offset: 0x000F88A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[67];
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x000FA6C8 File Offset: 0x000F88C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInviteRemoved.Descriptor;
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000FA6DF File Offset: 0x000F88DF
		[DebuggerNonUserCode]
		public PartyInviteRemoved()
		{
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000FA6EC File Offset: 0x000F88EC
		[DebuggerNonUserCode]
		public PartyInviteRemoved(PartyInviteRemoved other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitePartyId_ = other.invitePartyId_;
			this.inviteId_ = other.inviteId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x000FA744 File Offset: 0x000F8944
		[DebuggerNonUserCode]
		public PartyInviteRemoved Clone()
		{
			return new PartyInviteRemoved(this);
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x000FA75C File Offset: 0x000F895C
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x000FA77D File Offset: 0x000F897D
		[DebuggerNonUserCode]
		public string InvitePartyId
		{
			get
			{
				return this.invitePartyId_ ?? PartyInviteRemoved.InvitePartyIdDefaultValue;
			}
			set
			{
				this.invitePartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x000FA794 File Offset: 0x000F8994
		[DebuggerNonUserCode]
		public bool HasInvitePartyId
		{
			get
			{
				return this.invitePartyId_ != null;
			}
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x000FA7AF File Offset: 0x000F89AF
		[DebuggerNonUserCode]
		public void ClearInvitePartyId()
		{
			this.invitePartyId_ = null;
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x000FA7BC File Offset: 0x000F89BC
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x000FA7ED File Offset: 0x000F89ED
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = PartyInviteRemoved.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x000FA808 File Offset: 0x000F8A08
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x000FA825 File Offset: 0x000F8A25
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600400C RID: 16396 RVA: 0x000FA838 File Offset: 0x000F8A38
		// (set) Token: 0x0600400D RID: 16397 RVA: 0x000FA869 File Offset: 0x000F8A69
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = PartyInviteRemoved.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600400E RID: 16398 RVA: 0x000FA884 File Offset: 0x000F8A84
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x000FA8A1 File Offset: 0x000F8AA1
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x000FA8B4 File Offset: 0x000F8AB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInviteRemoved);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000FA8D4 File Offset: 0x000F8AD4
		[DebuggerNonUserCode]
		public bool Equals(PartyInviteRemoved other)
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
					bool flag4 = this.InvitePartyId != other.InvitePartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviteId != other.InviteId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x000FA960 File Offset: 0x000F8B60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				num ^= this.InvitePartyId.GetHashCode();
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x000FA9E8 File Offset: 0x000F8BE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x000FAA00 File Offset: 0x000F8C00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x000FAA0C File Offset: 0x000F8C0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InvitePartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviteId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x000FAA9C File Offset: 0x000F8C9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InvitePartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x000FAB28 File Offset: 0x000F8D28
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInviteRemoved other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitePartyId = other.HasInvitePartyId;
				if (hasInvitePartyId)
				{
					this.InvitePartyId = other.InvitePartyId;
				}
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x000FABA3 File Offset: 0x000F8DA3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x000FABB0 File Offset: 0x000F8DB0
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.InviteId = input.ReadUInt64();
					}
				}
				else
				{
					this.InvitePartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001D21 RID: 7457
		private static readonly MessageParser<PartyInviteRemoved> _parser = new MessageParser<PartyInviteRemoved>(() => new PartyInviteRemoved());

		// Token: 0x04001D22 RID: 7458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D23 RID: 7459
		private int _hasBits0;

		// Token: 0x04001D24 RID: 7460
		public const int InvitePartyIdFieldNumber = 1;

		// Token: 0x04001D25 RID: 7461
		private static readonly string InvitePartyIdDefaultValue = "";

		// Token: 0x04001D26 RID: 7462
		private string invitePartyId_;

		// Token: 0x04001D27 RID: 7463
		public const int InviteIdFieldNumber = 2;

		// Token: 0x04001D28 RID: 7464
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001D29 RID: 7465
		private ulong inviteId_;

		// Token: 0x04001D2A RID: 7466
		public const int ReasonFieldNumber = 3;

		// Token: 0x04001D2B RID: 7467
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04001D2C RID: 7468
		private uint reason_;
	}
}
