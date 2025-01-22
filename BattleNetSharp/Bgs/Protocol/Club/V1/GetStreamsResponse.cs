using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D7 RID: 1239
	public sealed class GetStreamsResponse : IMessage<GetStreamsResponse>, IMessage, IEquatable<GetStreamsResponse>, IDeepCloneable<GetStreamsResponse>, IBufferMessage
	{
		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600786D RID: 30829 RVA: 0x001D476C File Offset: 0x001D296C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamsResponse> Parser
		{
			get
			{
				return GetStreamsResponse._parser;
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x001D4784 File Offset: 0x001D2984
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[60];
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600786F RID: 30831 RVA: 0x001D47A8 File Offset: 0x001D29A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamsResponse.Descriptor;
			}
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x001D47BF File Offset: 0x001D29BF
		[DebuggerNonUserCode]
		public GetStreamsResponse()
		{
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x001D47E0 File Offset: 0x001D29E0
		[DebuggerNonUserCode]
		public GetStreamsResponse(GetStreamsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.stream_ = other.stream_.Clone();
			this.view_ = other.view_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x001D4840 File Offset: 0x001D2A40
		[DebuggerNonUserCode]
		public GetStreamsResponse Clone()
		{
			return new GetStreamsResponse(this);
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007873 RID: 30835 RVA: 0x001D4858 File Offset: 0x001D2A58
		[DebuggerNonUserCode]
		public RepeatedField<Stream> Stream
		{
			get
			{
				return this.stream_;
			}
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x001D4870 File Offset: 0x001D2A70
		[DebuggerNonUserCode]
		public RepeatedField<StreamView> View
		{
			get
			{
				return this.view_;
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007875 RID: 30837 RVA: 0x001D4888 File Offset: 0x001D2A88
		// (set) Token: 0x06007876 RID: 30838 RVA: 0x001D48B9 File Offset: 0x001D2AB9
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
					continuationDefaultValue = GetStreamsResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x001D48D4 File Offset: 0x001D2AD4
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x001D48F1 File Offset: 0x001D2AF1
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x001D4904 File Offset: 0x001D2B04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamsResponse);
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x001D4924 File Offset: 0x001D2B24
		[DebuggerNonUserCode]
		public bool Equals(GetStreamsResponse other)
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
					bool flag4 = !this.stream_.Equals(other.stream_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.view_.Equals(other.view_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x001D49B8 File Offset: 0x001D2BB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stream_.GetHashCode();
			num ^= this.view_.GetHashCode();
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

		// Token: 0x0600787C RID: 30844 RVA: 0x001D4A24 File Offset: 0x001D2C24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x001D4A3C File Offset: 0x001D2C3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x001D4A48 File Offset: 0x001D2C48
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stream_.WriteTo(ref output, GetStreamsResponse._repeated_stream_codec);
			this.view_.WriteTo(ref output, GetStreamsResponse._repeated_view_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x001D4AB8 File Offset: 0x001D2CB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stream_.CalculateSize(GetStreamsResponse._repeated_stream_codec);
			num += this.view_.CalculateSize(GetStreamsResponse._repeated_view_codec);
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

		// Token: 0x06007880 RID: 30848 RVA: 0x001D4B2C File Offset: 0x001D2D2C
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.stream_.Add(other.stream_);
				this.view_.Add(other.view_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x001D4B99 File Offset: 0x001D2D99
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x001D4BA4 File Offset: 0x001D2DA4
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
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
						this.view_.AddEntriesFrom(ref input, GetStreamsResponse._repeated_view_codec);
					}
				}
				else
				{
					this.stream_.AddEntriesFrom(ref input, GetStreamsResponse._repeated_stream_codec);
				}
			}
		}

		// Token: 0x040036AA RID: 13994
		private static readonly MessageParser<GetStreamsResponse> _parser = new MessageParser<GetStreamsResponse>(() => new GetStreamsResponse());

		// Token: 0x040036AB RID: 13995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036AC RID: 13996
		private int _hasBits0;

		// Token: 0x040036AD RID: 13997
		public const int StreamFieldNumber = 1;

		// Token: 0x040036AE RID: 13998
		private static readonly FieldCodec<Stream> _repeated_stream_codec = FieldCodec.ForMessage<Stream>(10U, Bgs.Protocol.Club.V1.Stream.Parser);

		// Token: 0x040036AF RID: 13999
		private readonly RepeatedField<Stream> stream_ = new RepeatedField<Stream>();

		// Token: 0x040036B0 RID: 14000
		public const int ViewFieldNumber = 2;

		// Token: 0x040036B1 RID: 14001
		private static readonly FieldCodec<StreamView> _repeated_view_codec = FieldCodec.ForMessage<StreamView>(18U, StreamView.Parser);

		// Token: 0x040036B2 RID: 14002
		private readonly RepeatedField<StreamView> view_ = new RepeatedField<StreamView>();

		// Token: 0x040036B3 RID: 14003
		public const int ContinuationFieldNumber = 3;

		// Token: 0x040036B4 RID: 14004
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040036B5 RID: 14005
		private ulong continuation_;
	}
}
