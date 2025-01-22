using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B7 RID: 1207
	public sealed class GetInvitationResponse : IMessage<GetInvitationResponse>, IMessage, IEquatable<GetInvitationResponse>, IDeepCloneable<GetInvitationResponse>, IBufferMessage
	{
		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x001CA3D0 File Offset: 0x001C85D0
		[DebuggerNonUserCode]
		public static MessageParser<GetInvitationResponse> Parser
		{
			get
			{
				return GetInvitationResponse._parser;
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x001CA3E8 File Offset: 0x001C85E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x001CA40C File Offset: 0x001C860C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInvitationResponse.Descriptor;
			}
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x001CA423 File Offset: 0x001C8623
		[DebuggerNonUserCode]
		public GetInvitationResponse()
		{
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x001CA42D File Offset: 0x001C862D
		[DebuggerNonUserCode]
		public GetInvitationResponse(GetInvitationResponse other)
			: this()
		{
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x001CA464 File Offset: 0x001C8664
		[DebuggerNonUserCode]
		public GetInvitationResponse Clone()
		{
			return new GetInvitationResponse(this);
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06007573 RID: 30067 RVA: 0x001CA47C File Offset: 0x001C867C
		// (set) Token: 0x06007574 RID: 30068 RVA: 0x001CA494 File Offset: 0x001C8694
		[DebuggerNonUserCode]
		public ClubInvitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x001CA4A0 File Offset: 0x001C86A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInvitationResponse);
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x001CA4C0 File Offset: 0x001C86C0
		[DebuggerNonUserCode]
		public bool Equals(GetInvitationResponse other)
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
					bool flag4 = !object.Equals(this.Invitation, other.Invitation);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x001CA51C File Offset: 0x001C871C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x001CA56C File Offset: 0x001C876C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x001CA584 File Offset: 0x001C8784
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x001CA590 File Offset: 0x001C8790
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.invitation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Invitation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x001CA5E0 File Offset: 0x001C87E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x001CA634 File Offset: 0x001C8834
		[DebuggerNonUserCode]
		public void MergeFrom(GetInvitationResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.invitation_ != null;
				if (flag2)
				{
					bool flag3 = this.invitation_ == null;
					if (flag3)
					{
						this.Invitation = new ClubInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x001CA6A0 File Offset: 0x001C88A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x001CA6AC File Offset: 0x001C88AC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.invitation_ == null;
					if (flag)
					{
						this.Invitation = new ClubInvitation();
					}
					input.ReadMessage(this.Invitation);
				}
			}
		}

		// Token: 0x0400358C RID: 13708
		private static readonly MessageParser<GetInvitationResponse> _parser = new MessageParser<GetInvitationResponse>(() => new GetInvitationResponse());

		// Token: 0x0400358D RID: 13709
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400358E RID: 13710
		public const int InvitationFieldNumber = 1;

		// Token: 0x0400358F RID: 13711
		private ClubInvitation invitation_;
	}
}
