using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D3 RID: 1747
	public sealed class ListChannelsResponse : IMessage<ListChannelsResponse>, IMessage, IEquatable<ListChannelsResponse>, IDeepCloneable<ListChannelsResponse>, IBufferMessage
	{
		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A143 RID: 41283 RVA: 0x00273AC4 File Offset: 0x00271CC4
		[DebuggerNonUserCode]
		public static MessageParser<ListChannelsResponse> Parser
		{
			get
			{
				return ListChannelsResponse._parser;
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A144 RID: 41284 RVA: 0x00273ADC File Offset: 0x00271CDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x00273B00 File Offset: 0x00271D00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelsResponse.Descriptor;
			}
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x00273B17 File Offset: 0x00271D17
		[DebuggerNonUserCode]
		public ListChannelsResponse()
		{
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x00273B2C File Offset: 0x00271D2C
		[DebuggerNonUserCode]
		public ListChannelsResponse(ListChannelsResponse other)
			: this()
		{
			this.channel_ = other.channel_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x00273B58 File Offset: 0x00271D58
		[DebuggerNonUserCode]
		public ListChannelsResponse Clone()
		{
			return new ListChannelsResponse(this);
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x00273B70 File Offset: 0x00271D70
		[DebuggerNonUserCode]
		public RepeatedField<ChannelDescription> Channel
		{
			get
			{
				return this.channel_;
			}
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x00273B88 File Offset: 0x00271D88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelsResponse);
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x00273BA8 File Offset: 0x00271DA8
		[DebuggerNonUserCode]
		public bool Equals(ListChannelsResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x00273C04 File Offset: 0x00271E04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.channel_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x00273C44 File Offset: 0x00271E44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x00273C5C File Offset: 0x00271E5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x00273C68 File Offset: 0x00271E68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.channel_.WriteTo(ref output, ListChannelsResponse._repeated_channel_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x00273CA4 File Offset: 0x00271EA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.channel_.CalculateSize(ListChannelsResponse._repeated_channel_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x00273CEC File Offset: 0x00271EEC
		[DebuggerNonUserCode]
		public void MergeFrom(ListChannelsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.channel_.Add(other.channel_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x00273D2E File Offset: 0x00271F2E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x00273D3C File Offset: 0x00271F3C
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
					this.channel_.AddEntriesFrom(ref input, ListChannelsResponse._repeated_channel_codec);
				}
			}
		}

		// Token: 0x040048A6 RID: 18598
		private static readonly MessageParser<ListChannelsResponse> _parser = new MessageParser<ListChannelsResponse>(() => new ListChannelsResponse());

		// Token: 0x040048A7 RID: 18599
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A8 RID: 18600
		public const int ChannelFieldNumber = 1;

		// Token: 0x040048A9 RID: 18601
		private static readonly FieldCodec<ChannelDescription> _repeated_channel_codec = FieldCodec.ForMessage<ChannelDescription>(10U, ChannelDescription.Parser);

		// Token: 0x040048AA RID: 18602
		private readonly RepeatedField<ChannelDescription> channel_ = new RepeatedField<ChannelDescription>();
	}
}
