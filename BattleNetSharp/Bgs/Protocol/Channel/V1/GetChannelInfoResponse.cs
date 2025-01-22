using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D5 RID: 1749
	public sealed class GetChannelInfoResponse : IMessage<GetChannelInfoResponse>, IMessage, IEquatable<GetChannelInfoResponse>, IDeepCloneable<GetChannelInfoResponse>, IBufferMessage
	{
		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A16A RID: 41322 RVA: 0x0027426C File Offset: 0x0027246C
		[DebuggerNonUserCode]
		public static MessageParser<GetChannelInfoResponse> Parser
		{
			get
			{
				return GetChannelInfoResponse._parser;
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A16B RID: 41323 RVA: 0x00274284 File Offset: 0x00272484
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A16C RID: 41324 RVA: 0x002742A8 File Offset: 0x002724A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChannelInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x002742BF File Offset: 0x002724BF
		[DebuggerNonUserCode]
		public GetChannelInfoResponse()
		{
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x002742C9 File Offset: 0x002724C9
		[DebuggerNonUserCode]
		public GetChannelInfoResponse(GetChannelInfoResponse other)
			: this()
		{
			this.channelInfo_ = ((other.channelInfo_ != null) ? other.channelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x00274300 File Offset: 0x00272500
		[DebuggerNonUserCode]
		public GetChannelInfoResponse Clone()
		{
			return new GetChannelInfoResponse(this);
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x00274318 File Offset: 0x00272518
		// (set) Token: 0x0600A171 RID: 41329 RVA: 0x00274330 File Offset: 0x00272530
		[DebuggerNonUserCode]
		public ChannelInfo ChannelInfo
		{
			get
			{
				return this.channelInfo_;
			}
			set
			{
				this.channelInfo_ = value;
			}
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x0027433C File Offset: 0x0027253C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChannelInfoResponse);
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x0027435C File Offset: 0x0027255C
		[DebuggerNonUserCode]
		public bool Equals(GetChannelInfoResponse other)
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
					bool flag4 = !object.Equals(this.ChannelInfo, other.ChannelInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x002743B8 File Offset: 0x002725B8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelInfo_ != null;
			if (flag)
			{
				num ^= this.ChannelInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x00274408 File Offset: 0x00272608
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x00274420 File Offset: 0x00272620
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x0027442C File Offset: 0x0027262C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x0027447C File Offset: 0x0027267C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x002744D0 File Offset: 0x002726D0
		[DebuggerNonUserCode]
		public void MergeFrom(GetChannelInfoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.channelInfo_ == null;
					if (flag3)
					{
						this.ChannelInfo = new ChannelInfo();
					}
					this.ChannelInfo.MergeFrom(other.ChannelInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x0027453C File Offset: 0x0027273C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x00274548 File Offset: 0x00272748
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
					bool flag = this.channelInfo_ == null;
					if (flag)
					{
						this.ChannelInfo = new ChannelInfo();
					}
					input.ReadMessage(this.ChannelInfo);
				}
			}
		}

		// Token: 0x040048B1 RID: 18609
		private static readonly MessageParser<GetChannelInfoResponse> _parser = new MessageParser<GetChannelInfoResponse>(() => new GetChannelInfoResponse());

		// Token: 0x040048B2 RID: 18610
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048B3 RID: 18611
		public const int ChannelInfoFieldNumber = 1;

		// Token: 0x040048B4 RID: 18612
		private ChannelInfo channelInfo_;
	}
}
