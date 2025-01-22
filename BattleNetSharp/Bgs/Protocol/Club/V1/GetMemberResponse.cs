using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AB RID: 1195
	public sealed class GetMemberResponse : IMessage<GetMemberResponse>, IMessage, IEquatable<GetMemberResponse>, IDeepCloneable<GetMemberResponse>, IBufferMessage
	{
		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x001C5F58 File Offset: 0x001C4158
		[DebuggerNonUserCode]
		public static MessageParser<GetMemberResponse> Parser
		{
			get
			{
				return GetMemberResponse._parser;
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600743F RID: 29759 RVA: 0x001C5F70 File Offset: 0x001C4170
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06007440 RID: 29760 RVA: 0x001C5F94 File Offset: 0x001C4194
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMemberResponse.Descriptor;
			}
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x001C5FAB File Offset: 0x001C41AB
		[DebuggerNonUserCode]
		public GetMemberResponse()
		{
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x001C5FB5 File Offset: 0x001C41B5
		[DebuggerNonUserCode]
		public GetMemberResponse(GetMemberResponse other)
			: this()
		{
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x001C5FEC File Offset: 0x001C41EC
		[DebuggerNonUserCode]
		public GetMemberResponse Clone()
		{
			return new GetMemberResponse(this);
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06007444 RID: 29764 RVA: 0x001C6004 File Offset: 0x001C4204
		// (set) Token: 0x06007445 RID: 29765 RVA: 0x001C601C File Offset: 0x001C421C
		[DebuggerNonUserCode]
		public Member Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x001C6028 File Offset: 0x001C4228
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMemberResponse);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x001C6048 File Offset: 0x001C4248
		[DebuggerNonUserCode]
		public bool Equals(GetMemberResponse other)
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
					bool flag4 = !object.Equals(this.Member, other.Member);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x001C60A4 File Offset: 0x001C42A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.member_ != null;
			if (flag)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x001C60F4 File Offset: 0x001C42F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x001C610C File Offset: 0x001C430C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x001C6118 File Offset: 0x001C4318
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.member_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Member);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x001C6168 File Offset: 0x001C4368
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.member_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x001C61BC File Offset: 0x001C43BC
		[DebuggerNonUserCode]
		public void MergeFrom(GetMemberResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.member_ != null;
				if (flag2)
				{
					bool flag3 = this.member_ == null;
					if (flag3)
					{
						this.Member = new Member();
					}
					this.Member.MergeFrom(other.Member);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x001C6228 File Offset: 0x001C4428
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x001C6234 File Offset: 0x001C4434
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
					bool flag = this.member_ == null;
					if (flag)
					{
						this.Member = new Member();
					}
					input.ReadMessage(this.Member);
				}
			}
		}

		// Token: 0x04003514 RID: 13588
		private static readonly MessageParser<GetMemberResponse> _parser = new MessageParser<GetMemberResponse>(() => new GetMemberResponse());

		// Token: 0x04003515 RID: 13589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003516 RID: 13590
		public const int MemberFieldNumber = 1;

		// Token: 0x04003517 RID: 13591
		private Member member_;
	}
}
