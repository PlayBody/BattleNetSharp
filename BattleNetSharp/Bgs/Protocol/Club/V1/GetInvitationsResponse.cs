using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B9 RID: 1209
	public sealed class GetInvitationsResponse : IMessage<GetInvitationsResponse>, IMessage, IEquatable<GetInvitationsResponse>, IDeepCloneable<GetInvitationsResponse>, IBufferMessage
	{
		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x0600759B RID: 30107 RVA: 0x001CAD30 File Offset: 0x001C8F30
		[DebuggerNonUserCode]
		public static MessageParser<GetInvitationsResponse> Parser
		{
			get
			{
				return GetInvitationsResponse._parser;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x0600759C RID: 30108 RVA: 0x001CAD48 File Offset: 0x001C8F48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x001CAD6C File Offset: 0x001C8F6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInvitationsResponse.Descriptor;
			}
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x001CAD83 File Offset: 0x001C8F83
		[DebuggerNonUserCode]
		public GetInvitationsResponse()
		{
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x001CAD98 File Offset: 0x001C8F98
		[DebuggerNonUserCode]
		public GetInvitationsResponse(GetInvitationsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitation_ = other.invitation_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x001CADE8 File Offset: 0x001C8FE8
		[DebuggerNonUserCode]
		public GetInvitationsResponse Clone()
		{
			return new GetInvitationsResponse(this);
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x060075A1 RID: 30113 RVA: 0x001CAE00 File Offset: 0x001C9000
		[DebuggerNonUserCode]
		public RepeatedField<ClubInvitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x001CAE18 File Offset: 0x001C9018
		// (set) Token: 0x060075A3 RID: 30115 RVA: 0x001CAE49 File Offset: 0x001C9049
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetInvitationsResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x060075A4 RID: 30116 RVA: 0x001CAE64 File Offset: 0x001C9064
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x001CAE81 File Offset: 0x001C9081
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x001CAE94 File Offset: 0x001C9094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInvitationsResponse);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x001CAEB4 File Offset: 0x001C90B4
		[DebuggerNonUserCode]
		public bool Equals(GetInvitationsResponse other)
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
					bool flag4 = !this.invitation_.Equals(other.invitation_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Continuation != other.Continuation;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x001CAF28 File Offset: 0x001C9128
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.invitation_.GetHashCode();
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x001CAF88 File Offset: 0x001C9188
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x001CAFA0 File Offset: 0x001C91A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x001CAFAC File Offset: 0x001C91AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.invitation_.WriteTo(ref output, GetInvitationsResponse._repeated_invitation_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x001CB00C File Offset: 0x001C920C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.invitation_.CalculateSize(GetInvitationsResponse._repeated_invitation_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x001CB070 File Offset: 0x001C9270
		[DebuggerNonUserCode]
		public void MergeFrom(GetInvitationsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.invitation_.Add(other.invitation_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x001CB0CB File Offset: 0x001C92CB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x001CB0D8 File Offset: 0x001C92D8
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
						this.Continuation = input.ReadUInt64();
					}
				}
				else
				{
					this.invitation_.AddEntriesFrom(ref input, GetInvitationsResponse._repeated_invitation_codec);
				}
			}
		}

		// Token: 0x0400359B RID: 13723
		private static readonly MessageParser<GetInvitationsResponse> _parser = new MessageParser<GetInvitationsResponse>(() => new GetInvitationsResponse());

		// Token: 0x0400359C RID: 13724
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400359D RID: 13725
		private int _hasBits0;

		// Token: 0x0400359E RID: 13726
		public const int InvitationFieldNumber = 1;

		// Token: 0x0400359F RID: 13727
		private static readonly FieldCodec<ClubInvitation> _repeated_invitation_codec = FieldCodec.ForMessage<ClubInvitation>(10U, ClubInvitation.Parser);

		// Token: 0x040035A0 RID: 13728
		private readonly RepeatedField<ClubInvitation> invitation_ = new RepeatedField<ClubInvitation>();

		// Token: 0x040035A1 RID: 13729
		public const int ContinuationFieldNumber = 2;

		// Token: 0x040035A2 RID: 13730
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040035A3 RID: 13731
		private ulong continuation_;
	}
}
