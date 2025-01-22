using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C0 RID: 1728
	public sealed class ListChannelCountResponse : IMessage<ListChannelCountResponse>, IMessage, IEquatable<ListChannelCountResponse>, IDeepCloneable<ListChannelCountResponse>, IBufferMessage
	{
		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x0026D75C File Offset: 0x0026B95C
		[DebuggerNonUserCode]
		public static MessageParser<ListChannelCountResponse> Parser
		{
			get
			{
				return ListChannelCountResponse._parser;
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x06009FBC RID: 40892 RVA: 0x0026D774 File Offset: 0x0026B974
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x0026D798 File Offset: 0x0026B998
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelCountResponse.Descriptor;
			}
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x0026D7AF File Offset: 0x0026B9AF
		[DebuggerNonUserCode]
		public ListChannelCountResponse()
		{
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x0026D7C4 File Offset: 0x0026B9C4
		[DebuggerNonUserCode]
		public ListChannelCountResponse(ListChannelCountResponse other)
			: this()
		{
			this.channel_ = other.channel_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x0026D7F0 File Offset: 0x0026B9F0
		[DebuggerNonUserCode]
		public ListChannelCountResponse Clone()
		{
			return new ListChannelCountResponse(this);
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x0026D808 File Offset: 0x0026BA08
		[DebuggerNonUserCode]
		public RepeatedField<ChannelCount> Channel
		{
			get
			{
				return this.channel_;
			}
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x0026D820 File Offset: 0x0026BA20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelCountResponse);
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x0026D840 File Offset: 0x0026BA40
		[DebuggerNonUserCode]
		public bool Equals(ListChannelCountResponse other)
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

		// Token: 0x06009FC4 RID: 40900 RVA: 0x0026D89C File Offset: 0x0026BA9C
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

		// Token: 0x06009FC5 RID: 40901 RVA: 0x0026D8DC File Offset: 0x0026BADC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x0026D8F4 File Offset: 0x0026BAF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x0026D900 File Offset: 0x0026BB00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.channel_.WriteTo(ref output, ListChannelCountResponse._repeated_channel_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x0026D93C File Offset: 0x0026BB3C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.channel_.CalculateSize(ListChannelCountResponse._repeated_channel_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x0026D984 File Offset: 0x0026BB84
		[DebuggerNonUserCode]
		public void MergeFrom(ListChannelCountResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.channel_.Add(other.channel_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x0026D9C6 File Offset: 0x0026BBC6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x0026D9D4 File Offset: 0x0026BBD4
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
					this.channel_.AddEntriesFrom(ref input, ListChannelCountResponse._repeated_channel_codec);
				}
			}
		}

		// Token: 0x040047FA RID: 18426
		private static readonly MessageParser<ListChannelCountResponse> _parser = new MessageParser<ListChannelCountResponse>(() => new ListChannelCountResponse());

		// Token: 0x040047FB RID: 18427
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047FC RID: 18428
		public const int ChannelFieldNumber = 1;

		// Token: 0x040047FD RID: 18429
		private static readonly FieldCodec<ChannelCount> _repeated_channel_codec = FieldCodec.ForMessage<ChannelCount>(10U, ChannelCount.Parser);

		// Token: 0x040047FE RID: 18430
		private readonly RepeatedField<ChannelCount> channel_ = new RepeatedField<ChannelCount>();
	}
}
