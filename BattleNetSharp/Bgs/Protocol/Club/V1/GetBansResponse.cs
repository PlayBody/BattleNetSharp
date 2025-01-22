using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CE RID: 1230
	public sealed class GetBansResponse : IMessage<GetBansResponse>, IMessage, IEquatable<GetBansResponse>, IDeepCloneable<GetBansResponse>, IBufferMessage
	{
		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x001D1820 File Offset: 0x001CFA20
		[DebuggerNonUserCode]
		public static MessageParser<GetBansResponse> Parser
		{
			get
			{
				return GetBansResponse._parser;
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x001D1838 File Offset: 0x001CFA38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[51];
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x001D185C File Offset: 0x001CFA5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBansResponse.Descriptor;
			}
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x001D1873 File Offset: 0x001CFA73
		[DebuggerNonUserCode]
		public GetBansResponse()
		{
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x001D1888 File Offset: 0x001CFA88
		[DebuggerNonUserCode]
		public GetBansResponse(GetBansResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ban_ = other.ban_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x001D18D8 File Offset: 0x001CFAD8
		[DebuggerNonUserCode]
		public GetBansResponse Clone()
		{
			return new GetBansResponse(this);
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x001D18F0 File Offset: 0x001CFAF0
		[DebuggerNonUserCode]
		public RepeatedField<ClubBan> Ban
		{
			get
			{
				return this.ban_;
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x001D1908 File Offset: 0x001CFB08
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x001D1939 File Offset: 0x001CFB39
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
					continuationDefaultValue = GetBansResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x001D1954 File Offset: 0x001CFB54
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x001D1971 File Offset: 0x001CFB71
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x001D1984 File Offset: 0x001CFB84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBansResponse);
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x001D19A4 File Offset: 0x001CFBA4
		[DebuggerNonUserCode]
		public bool Equals(GetBansResponse other)
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
					bool flag4 = !this.ban_.Equals(other.ban_);
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

		// Token: 0x0600779E RID: 30622 RVA: 0x001D1A18 File Offset: 0x001CFC18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ban_.GetHashCode();
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

		// Token: 0x0600779F RID: 30623 RVA: 0x001D1A78 File Offset: 0x001CFC78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x001D1A90 File Offset: 0x001CFC90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x001D1A9C File Offset: 0x001CFC9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ban_.WriteTo(ref output, GetBansResponse._repeated_ban_codec);
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

		// Token: 0x060077A2 RID: 30626 RVA: 0x001D1AFC File Offset: 0x001CFCFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ban_.CalculateSize(GetBansResponse._repeated_ban_codec);
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

		// Token: 0x060077A3 RID: 30627 RVA: 0x001D1B60 File Offset: 0x001CFD60
		[DebuggerNonUserCode]
		public void MergeFrom(GetBansResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ban_.Add(other.ban_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x001D1BBB File Offset: 0x001CFDBB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x001D1BC8 File Offset: 0x001CFDC8
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
					this.ban_.AddEntriesFrom(ref input, GetBansResponse._repeated_ban_codec);
				}
			}
		}

		// Token: 0x04003653 RID: 13907
		private static readonly MessageParser<GetBansResponse> _parser = new MessageParser<GetBansResponse>(() => new GetBansResponse());

		// Token: 0x04003654 RID: 13908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003655 RID: 13909
		private int _hasBits0;

		// Token: 0x04003656 RID: 13910
		public const int BanFieldNumber = 1;

		// Token: 0x04003657 RID: 13911
		private static readonly FieldCodec<ClubBan> _repeated_ban_codec = FieldCodec.ForMessage<ClubBan>(10U, ClubBan.Parser);

		// Token: 0x04003658 RID: 13912
		private readonly RepeatedField<ClubBan> ban_ = new RepeatedField<ClubBan>();

		// Token: 0x04003659 RID: 13913
		public const int ContinuationFieldNumber = 2;

		// Token: 0x0400365A RID: 13914
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400365B RID: 13915
		private ulong continuation_;
	}
}
