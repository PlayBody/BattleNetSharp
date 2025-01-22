using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Party
{
	// Token: 0x0200013C RID: 316
	public sealed class PartyInvite : IMessage<PartyInvite>, IMessage, IEquatable<PartyInvite>, IDeepCloneable<PartyInvite>, IBufferMessage
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0007EAC4 File Offset: 0x0007CCC4
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvite> Parser
		{
			get
			{
				return PartyInvite._parser;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x0007EADC File Offset: 0x0007CCDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PartyReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0007EB00 File Offset: 0x0007CD00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInvite.Descriptor;
			}
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0007EB17 File Offset: 0x0007CD17
		[DebuggerNonUserCode]
		public PartyInvite()
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0007EB24 File Offset: 0x0007CD24
		[DebuggerNonUserCode]
		public PartyInvite(PartyInvite other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviteId_ = other.inviteId_;
			this.inviterPartyId_ = other.inviterPartyId_;
			this.inviteeGameAccountId_ = other.inviteeGameAccountId_;
			this.inviterName_ = other.inviterName_;
			this.inviterGameAccountId_ = other.inviterGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0007EB94 File Offset: 0x0007CD94
		[DebuggerNonUserCode]
		public PartyInvite Clone()
		{
			return new PartyInvite(this);
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0007EBAC File Offset: 0x0007CDAC
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0007EBDD File Offset: 0x0007CDDD
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
					inviteIdDefaultValue = PartyInvite.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0007EC15 File Offset: 0x0007CE15
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0007EC28 File Offset: 0x0007CE28
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0007EC49 File Offset: 0x0007CE49
		[DebuggerNonUserCode]
		public string InviterPartyId
		{
			get
			{
				return this.inviterPartyId_ ?? PartyInvite.InviterPartyIdDefaultValue;
			}
			set
			{
				this.inviterPartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0007EC60 File Offset: 0x0007CE60
		[DebuggerNonUserCode]
		public bool HasInviterPartyId
		{
			get
			{
				return this.inviterPartyId_ != null;
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0007EC7B File Offset: 0x0007CE7B
		[DebuggerNonUserCode]
		public void ClearInviterPartyId()
		{
			this.inviterPartyId_ = null;
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0007EC88 File Offset: 0x0007CE88
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0007ECB9 File Offset: 0x0007CEB9
		[DebuggerNonUserCode]
		public uint InviteeGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint inviteeGameAccountIdDefaultValue;
				if (flag)
				{
					inviteeGameAccountIdDefaultValue = this.inviteeGameAccountId_;
				}
				else
				{
					inviteeGameAccountIdDefaultValue = PartyInvite.InviteeGameAccountIdDefaultValue;
				}
				return inviteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.inviteeGameAccountId_ = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0007ECD4 File Offset: 0x0007CED4
		[DebuggerNonUserCode]
		public bool HasInviteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0007ECF1 File Offset: 0x0007CEF1
		[DebuggerNonUserCode]
		public void ClearInviteeGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0007ED04 File Offset: 0x0007CF04
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0007ED25 File Offset: 0x0007CF25
		[DebuggerNonUserCode]
		public string InviterName
		{
			get
			{
				return this.inviterName_ ?? PartyInvite.InviterNameDefaultValue;
			}
			set
			{
				this.inviterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0007ED3C File Offset: 0x0007CF3C
		[DebuggerNonUserCode]
		public bool HasInviterName
		{
			get
			{
				return this.inviterName_ != null;
			}
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0007ED57 File Offset: 0x0007CF57
		[DebuggerNonUserCode]
		public void ClearInviterName()
		{
			this.inviterName_ = null;
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0007ED64 File Offset: 0x0007CF64
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0007ED95 File Offset: 0x0007CF95
		[DebuggerNonUserCode]
		public uint InviterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint inviterGameAccountIdDefaultValue;
				if (flag)
				{
					inviterGameAccountIdDefaultValue = this.inviterGameAccountId_;
				}
				else
				{
					inviterGameAccountIdDefaultValue = PartyInvite.InviterGameAccountIdDefaultValue;
				}
				return inviterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.inviterGameAccountId_ = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0007EDB0 File Offset: 0x0007CFB0
		[DebuggerNonUserCode]
		public bool HasInviterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0007EDCD File Offset: 0x0007CFCD
		[DebuggerNonUserCode]
		public void ClearInviterGameAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInvite);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0007EE00 File Offset: 0x0007D000
		[DebuggerNonUserCode]
		public bool Equals(PartyInvite other)
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
					bool flag4 = this.InviteId != other.InviteId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviterPartyId != other.InviterPartyId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InviteeGameAccountId != other.InviteeGameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InviterName != other.InviterName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.InviterGameAccountId != other.InviterGameAccountId;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0007EECC File Offset: 0x0007D0CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num ^= this.InviterPartyId.GetHashCode();
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num ^= this.InviteeGameAccountId.GetHashCode();
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num ^= this.InviterName.GetHashCode();
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num ^= this.InviterGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0007EF8C File Offset: 0x0007D18C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0007EFB0 File Offset: 0x0007D1B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.InviteId);
			}
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.InviterPartyId);
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.InviteeGameAccountId);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.InviterName);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.InviterGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0007F088 File Offset: 0x0007D288
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterPartyId);
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviteeGameAccountId);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterName);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviterGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0007F150 File Offset: 0x0007D350
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInvite other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool hasInviterPartyId = other.HasInviterPartyId;
				if (hasInviterPartyId)
				{
					this.InviterPartyId = other.InviterPartyId;
				}
				bool hasInviteeGameAccountId = other.HasInviteeGameAccountId;
				if (hasInviteeGameAccountId)
				{
					this.InviteeGameAccountId = other.InviteeGameAccountId;
				}
				bool hasInviterName = other.HasInviterName;
				if (hasInviterName)
				{
					this.InviterName = other.InviterName;
				}
				bool hasInviterGameAccountId = other.HasInviterGameAccountId;
				if (hasInviterGameAccountId)
				{
					this.InviterGameAccountId = other.InviterGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0007F204 File Offset: 0x0007D404
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0007F210 File Offset: 0x0007D410
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0032;
						}
						this.InviterPartyId = input.ReadString();
					}
					else
					{
						this.InviteId = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.InviterGameAccountId = input.ReadUInt32();
					}
					else
					{
						this.InviterName = input.ReadString();
					}
				}
				else
				{
					this.InviteeGameAccountId = input.ReadUInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E57 RID: 3671
		private static readonly MessageParser<PartyInvite> _parser = new MessageParser<PartyInvite>(() => new PartyInvite());

		// Token: 0x04000E58 RID: 3672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E59 RID: 3673
		private int _hasBits0;

		// Token: 0x04000E5A RID: 3674
		public const int InviteIdFieldNumber = 1;

		// Token: 0x04000E5B RID: 3675
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04000E5C RID: 3676
		private ulong inviteId_;

		// Token: 0x04000E5D RID: 3677
		public const int InviterPartyIdFieldNumber = 2;

		// Token: 0x04000E5E RID: 3678
		private static readonly string InviterPartyIdDefaultValue = "";

		// Token: 0x04000E5F RID: 3679
		private string inviterPartyId_;

		// Token: 0x04000E60 RID: 3680
		public const int InviteeGameAccountIdFieldNumber = 3;

		// Token: 0x04000E61 RID: 3681
		private static readonly uint InviteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04000E62 RID: 3682
		private uint inviteeGameAccountId_;

		// Token: 0x04000E63 RID: 3683
		public const int InviterNameFieldNumber = 4;

		// Token: 0x04000E64 RID: 3684
		private static readonly string InviterNameDefaultValue = "";

		// Token: 0x04000E65 RID: 3685
		private string inviterName_;

		// Token: 0x04000E66 RID: 3686
		public const int InviterGameAccountIdFieldNumber = 5;

		// Token: 0x04000E67 RID: 3687
		private static readonly uint InviterGameAccountIdDefaultValue = 0U;

		// Token: 0x04000E68 RID: 3688
		private uint inviterGameAccountId_;
	}
}
