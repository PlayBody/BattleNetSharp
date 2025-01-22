using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000243 RID: 579
	public sealed class RespondToPartyInviteRequest : IMessage<RespondToPartyInviteRequest>, IMessage, IEquatable<RespondToPartyInviteRequest>, IDeepCloneable<RespondToPartyInviteRequest>, IBufferMessage
	{
		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x000F5974 File Offset: 0x000F3B74
		[DebuggerNonUserCode]
		public static MessageParser<RespondToPartyInviteRequest> Parser
		{
			get
			{
				return RespondToPartyInviteRequest._parser;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000F598C File Offset: 0x000F3B8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[51];
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x000F59B0 File Offset: 0x000F3BB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RespondToPartyInviteRequest.Descriptor;
			}
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x000F59C7 File Offset: 0x000F3BC7
		[DebuggerNonUserCode]
		public RespondToPartyInviteRequest()
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x000F59D4 File Offset: 0x000F3BD4
		[DebuggerNonUserCode]
		public RespondToPartyInviteRequest(RespondToPartyInviteRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviterPartyId_ = other.inviterPartyId_;
			this.inviteId_ = other.inviteId_;
			this.accepted_ = other.accepted_;
			this.declineReason_ = other.declineReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x000F5A38 File Offset: 0x000F3C38
		[DebuggerNonUserCode]
		public RespondToPartyInviteRequest Clone()
		{
			return new RespondToPartyInviteRequest(this);
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x000F5A50 File Offset: 0x000F3C50
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x000F5A71 File Offset: 0x000F3C71
		[DebuggerNonUserCode]
		public string InviterPartyId
		{
			get
			{
				return this.inviterPartyId_ ?? RespondToPartyInviteRequest.InviterPartyIdDefaultValue;
			}
			set
			{
				this.inviterPartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x000F5A88 File Offset: 0x000F3C88
		[DebuggerNonUserCode]
		public bool HasInviterPartyId
		{
			get
			{
				return this.inviterPartyId_ != null;
			}
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x000F5AA3 File Offset: 0x000F3CA3
		[DebuggerNonUserCode]
		public void ClearInviterPartyId()
		{
			this.inviterPartyId_ = null;
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x000F5AB0 File Offset: 0x000F3CB0
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x000F5AE1 File Offset: 0x000F3CE1
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
					inviteIdDefaultValue = RespondToPartyInviteRequest.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x000F5AFC File Offset: 0x000F3CFC
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x000F5B19 File Offset: 0x000F3D19
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x000F5B2C File Offset: 0x000F3D2C
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x000F5B5D File Offset: 0x000F3D5D
		[DebuggerNonUserCode]
		public bool Accepted
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool acceptedDefaultValue;
				if (flag)
				{
					acceptedDefaultValue = this.accepted_;
				}
				else
				{
					acceptedDefaultValue = RespondToPartyInviteRequest.AcceptedDefaultValue;
				}
				return acceptedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.accepted_ = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x000F5B78 File Offset: 0x000F3D78
		[DebuggerNonUserCode]
		public bool HasAccepted
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x000F5B95 File Offset: 0x000F3D95
		[DebuggerNonUserCode]
		public void ClearAccepted()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x000F5BA8 File Offset: 0x000F3DA8
		// (set) Token: 0x06003E7F RID: 15999 RVA: 0x000F5BD9 File Offset: 0x000F3DD9
		[DebuggerNonUserCode]
		public uint DeclineReason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint declineReasonDefaultValue;
				if (flag)
				{
					declineReasonDefaultValue = this.declineReason_;
				}
				else
				{
					declineReasonDefaultValue = RespondToPartyInviteRequest.DeclineReasonDefaultValue;
				}
				return declineReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.declineReason_ = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x000F5BF4 File Offset: 0x000F3DF4
		[DebuggerNonUserCode]
		public bool HasDeclineReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x000F5C11 File Offset: 0x000F3E11
		[DebuggerNonUserCode]
		public void ClearDeclineReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000F5C24 File Offset: 0x000F3E24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RespondToPartyInviteRequest);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000F5C44 File Offset: 0x000F3E44
		[DebuggerNonUserCode]
		public bool Equals(RespondToPartyInviteRequest other)
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
					bool flag4 = this.InviterPartyId != other.InviterPartyId;
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
							bool flag6 = this.Accepted != other.Accepted;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DeclineReason != other.DeclineReason;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000F5CF0 File Offset: 0x000F3EF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num ^= this.InviterPartyId.GetHashCode();
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool hasAccepted = this.HasAccepted;
			if (hasAccepted)
			{
				num ^= this.Accepted.GetHashCode();
			}
			bool hasDeclineReason = this.HasDeclineReason;
			if (hasDeclineReason)
			{
				num ^= this.DeclineReason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000F5D98 File Offset: 0x000F3F98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000F5DB0 File Offset: 0x000F3FB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x000F5DBC File Offset: 0x000F3FBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InviterPartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviteId);
			}
			bool hasAccepted = this.HasAccepted;
			if (hasAccepted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Accepted);
			}
			bool hasDeclineReason = this.HasDeclineReason;
			if (hasDeclineReason)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DeclineReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x000F5E70 File Offset: 0x000F4070
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterPartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool hasAccepted = this.HasAccepted;
			if (hasAccepted)
			{
				num += 2;
			}
			bool hasDeclineReason = this.HasDeclineReason;
			if (hasDeclineReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DeclineReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x000F5F0C File Offset: 0x000F410C
		[DebuggerNonUserCode]
		public void MergeFrom(RespondToPartyInviteRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviterPartyId = other.HasInviterPartyId;
				if (hasInviterPartyId)
				{
					this.InviterPartyId = other.InviterPartyId;
				}
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool hasAccepted = other.HasAccepted;
				if (hasAccepted)
				{
					this.Accepted = other.Accepted;
				}
				bool hasDeclineReason = other.HasDeclineReason;
				if (hasDeclineReason)
				{
					this.DeclineReason = other.DeclineReason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x000F5FA2 File Offset: 0x000F41A2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x000F5FB0 File Offset: 0x000F41B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0029;
						}
						this.InviteId = input.ReadUInt64();
					}
					else
					{
						this.InviterPartyId = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.DeclineReason = input.ReadUInt32();
				}
				else
				{
					this.Accepted = input.ReadBool();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C90 RID: 7312
		private static readonly MessageParser<RespondToPartyInviteRequest> _parser = new MessageParser<RespondToPartyInviteRequest>(() => new RespondToPartyInviteRequest());

		// Token: 0x04001C91 RID: 7313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C92 RID: 7314
		private int _hasBits0;

		// Token: 0x04001C93 RID: 7315
		public const int InviterPartyIdFieldNumber = 1;

		// Token: 0x04001C94 RID: 7316
		private static readonly string InviterPartyIdDefaultValue = "";

		// Token: 0x04001C95 RID: 7317
		private string inviterPartyId_;

		// Token: 0x04001C96 RID: 7318
		public const int InviteIdFieldNumber = 2;

		// Token: 0x04001C97 RID: 7319
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001C98 RID: 7320
		private ulong inviteId_;

		// Token: 0x04001C99 RID: 7321
		public const int AcceptedFieldNumber = 3;

		// Token: 0x04001C9A RID: 7322
		private static readonly bool AcceptedDefaultValue = false;

		// Token: 0x04001C9B RID: 7323
		private bool accepted_;

		// Token: 0x04001C9C RID: 7324
		public const int DeclineReasonFieldNumber = 4;

		// Token: 0x04001C9D RID: 7325
		private static readonly uint DeclineReasonDefaultValue = 0U;

		// Token: 0x04001C9E RID: 7326
		private uint declineReason_;
	}
}
