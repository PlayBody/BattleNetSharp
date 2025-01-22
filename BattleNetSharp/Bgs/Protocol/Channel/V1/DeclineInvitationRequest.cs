using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BB RID: 1723
	public sealed class DeclineInvitationRequest : IMessage<DeclineInvitationRequest>, IMessage, IEquatable<DeclineInvitationRequest>, IDeepCloneable<DeclineInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06009F48 RID: 40776 RVA: 0x0026BEB8 File Offset: 0x0026A0B8
		[DebuggerNonUserCode]
		public static MessageParser<DeclineInvitationRequest> Parser
		{
			get
			{
				return DeclineInvitationRequest._parser;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x0026BED0 File Offset: 0x0026A0D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x06009F4A RID: 40778 RVA: 0x0026BEF4 File Offset: 0x0026A0F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclineInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x0026BF0B File Offset: 0x0026A10B
		[DebuggerNonUserCode]
		public DeclineInvitationRequest()
		{
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x0026BF15 File Offset: 0x0026A115
		[DebuggerNonUserCode]
		public DeclineInvitationRequest(DeclineInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x0026BF48 File Offset: 0x0026A148
		[DebuggerNonUserCode]
		public DeclineInvitationRequest Clone()
		{
			return new DeclineInvitationRequest(this);
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x06009F4E RID: 40782 RVA: 0x0026BF60 File Offset: 0x0026A160
		// (set) Token: 0x06009F4F RID: 40783 RVA: 0x0026BF91 File Offset: 0x0026A191
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = DeclineInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x06009F50 RID: 40784 RVA: 0x0026BFAC File Offset: 0x0026A1AC
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x0026BFC9 File Offset: 0x0026A1C9
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x0026BFDC File Offset: 0x0026A1DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclineInvitationRequest);
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x0026BFFC File Offset: 0x0026A1FC
		[DebuggerNonUserCode]
		public bool Equals(DeclineInvitationRequest other)
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
					bool flag4 = this.InvitationId != other.InvitationId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x0026C054 File Offset: 0x0026A254
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x0026C0A4 File Offset: 0x0026A2A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x0026C0BC File Offset: 0x0026A2BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x0026C0C8 File Offset: 0x0026A2C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x0026C114 File Offset: 0x0026A314
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x0026C158 File Offset: 0x0026A358
		[DebuggerNonUserCode]
		public void MergeFrom(DeclineInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x0026C1A1 File Offset: 0x0026A3A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x0026C1AC File Offset: 0x0026A3AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 25U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InvitationId = input.ReadFixed64();
				}
			}
		}

		// Token: 0x040047D2 RID: 18386
		private static readonly MessageParser<DeclineInvitationRequest> _parser = new MessageParser<DeclineInvitationRequest>(() => new DeclineInvitationRequest());

		// Token: 0x040047D3 RID: 18387
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047D4 RID: 18388
		private int _hasBits0;

		// Token: 0x040047D5 RID: 18389
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040047D6 RID: 18390
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040047D7 RID: 18391
		private ulong invitationId_;
	}
}
