using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024A RID: 586
	public sealed class DeclinePartyInviteRequest : IMessage<DeclinePartyInviteRequest>, IMessage, IEquatable<DeclinePartyInviteRequest>, IDeepCloneable<DeclinePartyInviteRequest>, IBufferMessage
	{
		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000F73F0 File Offset: 0x000F55F0
		[DebuggerNonUserCode]
		public static MessageParser<DeclinePartyInviteRequest> Parser
		{
			get
			{
				return DeclinePartyInviteRequest._parser;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x000F7408 File Offset: 0x000F5608
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[58];
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x000F742C File Offset: 0x000F562C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclinePartyInviteRequest.Descriptor;
			}
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x000F7443 File Offset: 0x000F5643
		[DebuggerNonUserCode]
		public DeclinePartyInviteRequest()
		{
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x000F744D File Offset: 0x000F564D
		[DebuggerNonUserCode]
		public DeclinePartyInviteRequest(DeclinePartyInviteRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesterGameAccountId_ = other.requesterGameAccountId_;
			this.declineReason_ = other.declineReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x000F748C File Offset: 0x000F568C
		[DebuggerNonUserCode]
		public DeclinePartyInviteRequest Clone()
		{
			return new DeclinePartyInviteRequest(this);
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x000F74A4 File Offset: 0x000F56A4
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x000F74D5 File Offset: 0x000F56D5
		[DebuggerNonUserCode]
		public uint RequesterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint requesterGameAccountIdDefaultValue;
				if (flag)
				{
					requesterGameAccountIdDefaultValue = this.requesterGameAccountId_;
				}
				else
				{
					requesterGameAccountIdDefaultValue = DeclinePartyInviteRequest.RequesterGameAccountIdDefaultValue;
				}
				return requesterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesterGameAccountId_ = value;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x000F74F0 File Offset: 0x000F56F0
		[DebuggerNonUserCode]
		public bool HasRequesterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x000F750D File Offset: 0x000F570D
		[DebuggerNonUserCode]
		public void ClearRequesterGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x000F7520 File Offset: 0x000F5720
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x000F7551 File Offset: 0x000F5751
		[DebuggerNonUserCode]
		public uint DeclineReason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint declineReasonDefaultValue;
				if (flag)
				{
					declineReasonDefaultValue = this.declineReason_;
				}
				else
				{
					declineReasonDefaultValue = DeclinePartyInviteRequest.DeclineReasonDefaultValue;
				}
				return declineReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.declineReason_ = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x000F756C File Offset: 0x000F576C
		[DebuggerNonUserCode]
		public bool HasDeclineReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x000F7589 File Offset: 0x000F5789
		[DebuggerNonUserCode]
		public void ClearDeclineReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x000F759C File Offset: 0x000F579C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclinePartyInviteRequest);
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x000F75BC File Offset: 0x000F57BC
		[DebuggerNonUserCode]
		public bool Equals(DeclinePartyInviteRequest other)
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
					bool flag4 = this.RequesterGameAccountId != other.RequesterGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DeclineReason != other.DeclineReason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x000F7630 File Offset: 0x000F5830
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num ^= this.RequesterGameAccountId.GetHashCode();
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

		// Token: 0x06003F18 RID: 16152 RVA: 0x000F769C File Offset: 0x000F589C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x000F76B4 File Offset: 0x000F58B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x000F76C0 File Offset: 0x000F58C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RequesterGameAccountId);
			}
			bool hasDeclineReason = this.HasDeclineReason;
			if (hasDeclineReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DeclineReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000F7730 File Offset: 0x000F5930
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesterGameAccountId);
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

		// Token: 0x06003F1C RID: 16156 RVA: 0x000F779C File Offset: 0x000F599C
		[DebuggerNonUserCode]
		public void MergeFrom(DeclinePartyInviteRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequesterGameAccountId = other.HasRequesterGameAccountId;
				if (hasRequesterGameAccountId)
				{
					this.RequesterGameAccountId = other.RequesterGameAccountId;
				}
				bool hasDeclineReason = other.HasDeclineReason;
				if (hasDeclineReason)
				{
					this.DeclineReason = other.DeclineReason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000F77FE File Offset: 0x000F59FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000F780C File Offset: 0x000F5A0C
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
						this.DeclineReason = input.ReadUInt32();
					}
				}
				else
				{
					this.RequesterGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CBE RID: 7358
		private static readonly MessageParser<DeclinePartyInviteRequest> _parser = new MessageParser<DeclinePartyInviteRequest>(() => new DeclinePartyInviteRequest());

		// Token: 0x04001CBF RID: 7359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CC0 RID: 7360
		private int _hasBits0;

		// Token: 0x04001CC1 RID: 7361
		public const int RequesterGameAccountIdFieldNumber = 1;

		// Token: 0x04001CC2 RID: 7362
		private static readonly uint RequesterGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CC3 RID: 7363
		private uint requesterGameAccountId_;

		// Token: 0x04001CC4 RID: 7364
		public const int DeclineReasonFieldNumber = 2;

		// Token: 0x04001CC5 RID: 7365
		private static readonly uint DeclineReasonDefaultValue = 0U;

		// Token: 0x04001CC6 RID: 7366
		private uint declineReason_;
	}
}
