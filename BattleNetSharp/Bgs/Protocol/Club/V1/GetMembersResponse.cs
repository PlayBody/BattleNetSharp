using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AD RID: 1197
	public sealed class GetMembersResponse : IMessage<GetMembersResponse>, IMessage, IEquatable<GetMembersResponse>, IDeepCloneable<GetMembersResponse>, IBufferMessage
	{
		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x001C68B8 File Offset: 0x001C4AB8
		[DebuggerNonUserCode]
		public static MessageParser<GetMembersResponse> Parser
		{
			get
			{
				return GetMembersResponse._parser;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x001C68D0 File Offset: 0x001C4AD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600746E RID: 29806 RVA: 0x001C68F4 File Offset: 0x001C4AF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMembersResponse.Descriptor;
			}
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x001C690B File Offset: 0x001C4B0B
		[DebuggerNonUserCode]
		public GetMembersResponse()
		{
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x001C6920 File Offset: 0x001C4B20
		[DebuggerNonUserCode]
		public GetMembersResponse(GetMembersResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.member_ = other.member_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x001C6970 File Offset: 0x001C4B70
		[DebuggerNonUserCode]
		public GetMembersResponse Clone()
		{
			return new GetMembersResponse(this);
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x001C6988 File Offset: 0x001C4B88
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06007473 RID: 29811 RVA: 0x001C69A0 File Offset: 0x001C4BA0
		// (set) Token: 0x06007474 RID: 29812 RVA: 0x001C69D1 File Offset: 0x001C4BD1
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
					continuationDefaultValue = GetMembersResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06007475 RID: 29813 RVA: 0x001C69EC File Offset: 0x001C4BEC
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x001C6A09 File Offset: 0x001C4C09
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x001C6A1C File Offset: 0x001C4C1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMembersResponse);
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x001C6A3C File Offset: 0x001C4C3C
		[DebuggerNonUserCode]
		public bool Equals(GetMembersResponse other)
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
					bool flag4 = !this.member_.Equals(other.member_);
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

		// Token: 0x06007479 RID: 29817 RVA: 0x001C6AB0 File Offset: 0x001C4CB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.member_.GetHashCode();
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

		// Token: 0x0600747A RID: 29818 RVA: 0x001C6B10 File Offset: 0x001C4D10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x001C6B28 File Offset: 0x001C4D28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x001C6B34 File Offset: 0x001C4D34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.member_.WriteTo(ref output, GetMembersResponse._repeated_member_codec);
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

		// Token: 0x0600747D RID: 29821 RVA: 0x001C6B94 File Offset: 0x001C4D94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.member_.CalculateSize(GetMembersResponse._repeated_member_codec);
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

		// Token: 0x0600747E RID: 29822 RVA: 0x001C6BF8 File Offset: 0x001C4DF8
		[DebuggerNonUserCode]
		public void MergeFrom(GetMembersResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.member_.Add(other.member_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x001C6C53 File Offset: 0x001C4E53
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x001C6C60 File Offset: 0x001C4E60
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
					this.member_.AddEntriesFrom(ref input, GetMembersResponse._repeated_member_codec);
				}
			}
		}

		// Token: 0x04003523 RID: 13603
		private static readonly MessageParser<GetMembersResponse> _parser = new MessageParser<GetMembersResponse>(() => new GetMembersResponse());

		// Token: 0x04003524 RID: 13604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003525 RID: 13605
		private int _hasBits0;

		// Token: 0x04003526 RID: 13606
		public const int MemberFieldNumber = 1;

		// Token: 0x04003527 RID: 13607
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(10U, Bgs.Protocol.Club.V1.Member.Parser);

		// Token: 0x04003528 RID: 13608
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();

		// Token: 0x04003529 RID: 13609
		public const int ContinuationFieldNumber = 2;

		// Token: 0x0400352A RID: 13610
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400352B RID: 13611
		private ulong continuation_;
	}
}
