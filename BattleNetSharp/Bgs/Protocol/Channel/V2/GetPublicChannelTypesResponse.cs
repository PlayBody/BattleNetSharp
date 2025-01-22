using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000661 RID: 1633
	public sealed class GetPublicChannelTypesResponse : IMessage<GetPublicChannelTypesResponse>, IMessage, IEquatable<GetPublicChannelTypesResponse>, IDeepCloneable<GetPublicChannelTypesResponse>, IBufferMessage
	{
		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x060097A2 RID: 38818 RVA: 0x0024BC2C File Offset: 0x00249E2C
		[DebuggerNonUserCode]
		public static MessageParser<GetPublicChannelTypesResponse> Parser
		{
			get
			{
				return GetPublicChannelTypesResponse._parser;
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x060097A3 RID: 38819 RVA: 0x0024BC44 File Offset: 0x00249E44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x060097A4 RID: 38820 RVA: 0x0024BC68 File Offset: 0x00249E68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPublicChannelTypesResponse.Descriptor;
			}
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x0024BC7F File Offset: 0x00249E7F
		[DebuggerNonUserCode]
		public GetPublicChannelTypesResponse()
		{
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0024BC94 File Offset: 0x00249E94
		[DebuggerNonUserCode]
		public GetPublicChannelTypesResponse(GetPublicChannelTypesResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.channel_ = other.channel_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x0024BCE4 File Offset: 0x00249EE4
		[DebuggerNonUserCode]
		public GetPublicChannelTypesResponse Clone()
		{
			return new GetPublicChannelTypesResponse(this);
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x0024BCFC File Offset: 0x00249EFC
		[DebuggerNonUserCode]
		public RepeatedField<PublicChannelType> Channel
		{
			get
			{
				return this.channel_;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x060097A9 RID: 38825 RVA: 0x0024BD14 File Offset: 0x00249F14
		// (set) Token: 0x060097AA RID: 38826 RVA: 0x0024BD45 File Offset: 0x00249F45
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
					continuationDefaultValue = GetPublicChannelTypesResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x0024BD60 File Offset: 0x00249F60
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x0024BD7D File Offset: 0x00249F7D
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x0024BD90 File Offset: 0x00249F90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPublicChannelTypesResponse);
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x0024BDB0 File Offset: 0x00249FB0
		[DebuggerNonUserCode]
		public bool Equals(GetPublicChannelTypesResponse other)
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
					bool flag4 = !this.channel_.Equals(other.channel_);
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

		// Token: 0x060097AF RID: 38831 RVA: 0x0024BE24 File Offset: 0x0024A024
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.channel_.GetHashCode();
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

		// Token: 0x060097B0 RID: 38832 RVA: 0x0024BE84 File Offset: 0x0024A084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0024BE9C File Offset: 0x0024A09C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0024BEA8 File Offset: 0x0024A0A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.channel_.WriteTo(ref output, GetPublicChannelTypesResponse._repeated_channel_codec);
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

		// Token: 0x060097B3 RID: 38835 RVA: 0x0024BF08 File Offset: 0x0024A108
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.channel_.CalculateSize(GetPublicChannelTypesResponse._repeated_channel_codec);
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

		// Token: 0x060097B4 RID: 38836 RVA: 0x0024BF6C File Offset: 0x0024A16C
		[DebuggerNonUserCode]
		public void MergeFrom(GetPublicChannelTypesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.channel_.Add(other.channel_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0024BFC7 File Offset: 0x0024A1C7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0024BFD4 File Offset: 0x0024A1D4
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
					this.channel_.AddEntriesFrom(ref input, GetPublicChannelTypesResponse._repeated_channel_codec);
				}
			}
		}

		// Token: 0x04004460 RID: 17504
		private static readonly MessageParser<GetPublicChannelTypesResponse> _parser = new MessageParser<GetPublicChannelTypesResponse>(() => new GetPublicChannelTypesResponse());

		// Token: 0x04004461 RID: 17505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004462 RID: 17506
		private int _hasBits0;

		// Token: 0x04004463 RID: 17507
		public const int ChannelFieldNumber = 1;

		// Token: 0x04004464 RID: 17508
		private static readonly FieldCodec<PublicChannelType> _repeated_channel_codec = FieldCodec.ForMessage<PublicChannelType>(10U, PublicChannelType.Parser);

		// Token: 0x04004465 RID: 17509
		private readonly RepeatedField<PublicChannelType> channel_ = new RepeatedField<PublicChannelType>();

		// Token: 0x04004466 RID: 17510
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04004467 RID: 17511
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04004468 RID: 17512
		private ulong continuation_;
	}
}
