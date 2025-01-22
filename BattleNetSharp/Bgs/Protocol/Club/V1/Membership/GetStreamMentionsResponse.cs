using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000520 RID: 1312
	public sealed class GetStreamMentionsResponse : IMessage<GetStreamMentionsResponse>, IMessage, IEquatable<GetStreamMentionsResponse>, IDeepCloneable<GetStreamMentionsResponse>, IBufferMessage
	{
		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x06007F88 RID: 32648 RVA: 0x001F0A0C File Offset: 0x001EEC0C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamMentionsResponse> Parser
		{
			get
			{
				return GetStreamMentionsResponse._parser;
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x06007F89 RID: 32649 RVA: 0x001F0A24 File Offset: 0x001EEC24
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x06007F8A RID: 32650 RVA: 0x001F0A48 File Offset: 0x001EEC48
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamMentionsResponse.Descriptor;
			}
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x001F0A5F File Offset: 0x001EEC5F
		[DebuggerNonUserCode]
		public GetStreamMentionsResponse()
		{
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x001F0A74 File Offset: 0x001EEC74
		[DebuggerNonUserCode]
		public GetStreamMentionsResponse(GetStreamMentionsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mention_ = other.mention_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x001F0AC4 File Offset: 0x001EECC4
		[DebuggerNonUserCode]
		public GetStreamMentionsResponse Clone()
		{
			return new GetStreamMentionsResponse(this);
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06007F8E RID: 32654 RVA: 0x001F0ADC File Offset: 0x001EECDC
		[DebuggerNonUserCode]
		public RepeatedField<StreamMention> Mention
		{
			get
			{
				return this.mention_;
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x001F0AF4 File Offset: 0x001EECF4
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x001F0B25 File Offset: 0x001EED25
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
					continuationDefaultValue = GetStreamMentionsResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x001F0B40 File Offset: 0x001EED40
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x001F0B5D File Offset: 0x001EED5D
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x001F0B70 File Offset: 0x001EED70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamMentionsResponse);
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x001F0B90 File Offset: 0x001EED90
		[DebuggerNonUserCode]
		public bool Equals(GetStreamMentionsResponse other)
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
					bool flag4 = !this.mention_.Equals(other.mention_);
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

		// Token: 0x06007F95 RID: 32661 RVA: 0x001F0C04 File Offset: 0x001EEE04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mention_.GetHashCode();
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

		// Token: 0x06007F96 RID: 32662 RVA: 0x001F0C64 File Offset: 0x001EEE64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x001F0C7C File Offset: 0x001EEE7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x001F0C88 File Offset: 0x001EEE88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mention_.WriteTo(ref output, GetStreamMentionsResponse._repeated_mention_codec);
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

		// Token: 0x06007F99 RID: 32665 RVA: 0x001F0CE8 File Offset: 0x001EEEE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mention_.CalculateSize(GetStreamMentionsResponse._repeated_mention_codec);
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

		// Token: 0x06007F9A RID: 32666 RVA: 0x001F0D4C File Offset: 0x001EEF4C
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamMentionsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.mention_.Add(other.mention_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x001F0DA7 File Offset: 0x001EEFA7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x001F0DB4 File Offset: 0x001EEFB4
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
					this.mention_.AddEntriesFrom(ref input, GetStreamMentionsResponse._repeated_mention_codec);
				}
			}
		}

		// Token: 0x040039E4 RID: 14820
		private static readonly MessageParser<GetStreamMentionsResponse> _parser = new MessageParser<GetStreamMentionsResponse>(() => new GetStreamMentionsResponse());

		// Token: 0x040039E5 RID: 14821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E6 RID: 14822
		private int _hasBits0;

		// Token: 0x040039E7 RID: 14823
		public const int MentionFieldNumber = 1;

		// Token: 0x040039E8 RID: 14824
		private static readonly FieldCodec<StreamMention> _repeated_mention_codec = FieldCodec.ForMessage<StreamMention>(10U, StreamMention.Parser);

		// Token: 0x040039E9 RID: 14825
		private readonly RepeatedField<StreamMention> mention_ = new RepeatedField<StreamMention>();

		// Token: 0x040039EA RID: 14826
		public const int ContinuationFieldNumber = 2;

		// Token: 0x040039EB RID: 14827
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040039EC RID: 14828
		private ulong continuation_;
	}
}
