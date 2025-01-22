using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000272 RID: 626
	public sealed class GetClanNewsResponse : IMessage<GetClanNewsResponse>, IMessage, IEquatable<GetClanNewsResponse>, IDeepCloneable<GetClanNewsResponse>, IBufferMessage
	{
		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x00103E70 File Offset: 0x00102070
		[DebuggerNonUserCode]
		public static MessageParser<GetClanNewsResponse> Parser
		{
			get
			{
				return GetClanNewsResponse._parser;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x00103E88 File Offset: 0x00102088
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[98];
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x00103EAC File Offset: 0x001020AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClanNewsResponse.Descriptor;
			}
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00103EC3 File Offset: 0x001020C3
		[DebuggerNonUserCode]
		public GetClanNewsResponse()
		{
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00103ECD File Offset: 0x001020CD
		[DebuggerNonUserCode]
		public GetClanNewsResponse(GetClanNewsResponse other)
			: this()
		{
			this.news_ = ((other.news_ != null) ? other.news_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00103F04 File Offset: 0x00102104
		[DebuggerNonUserCode]
		public GetClanNewsResponse Clone()
		{
			return new GetClanNewsResponse(this);
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x00103F1C File Offset: 0x0010211C
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x00103F34 File Offset: 0x00102134
		[DebuggerNonUserCode]
		public ClanNewsList News
		{
			get
			{
				return this.news_;
			}
			set
			{
				this.news_ = value;
			}
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00103F40 File Offset: 0x00102140
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClanNewsResponse);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00103F60 File Offset: 0x00102160
		[DebuggerNonUserCode]
		public bool Equals(GetClanNewsResponse other)
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
					bool flag4 = !object.Equals(this.News, other.News);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00103FBC File Offset: 0x001021BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.news_ != null;
			if (flag)
			{
				num ^= this.News.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x0010400C File Offset: 0x0010220C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00104024 File Offset: 0x00102224
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x00104030 File Offset: 0x00102230
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.news_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.News);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00104080 File Offset: 0x00102280
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.news_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.News);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x001040D4 File Offset: 0x001022D4
		[DebuggerNonUserCode]
		public void MergeFrom(GetClanNewsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.news_ != null;
				if (flag2)
				{
					bool flag3 = this.news_ == null;
					if (flag3)
					{
						this.News = new ClanNewsList();
					}
					this.News.MergeFrom(other.News);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00104140 File Offset: 0x00102340
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x0010414C File Offset: 0x0010234C
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
					bool flag = this.news_ == null;
					if (flag)
					{
						this.News = new ClanNewsList();
					}
					input.ReadMessage(this.News);
				}
			}
		}

		// Token: 0x04001E41 RID: 7745
		private static readonly MessageParser<GetClanNewsResponse> _parser = new MessageParser<GetClanNewsResponse>(() => new GetClanNewsResponse());

		// Token: 0x04001E42 RID: 7746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E43 RID: 7747
		public const int NewsFieldNumber = 1;

		// Token: 0x04001E44 RID: 7748
		private ClanNewsList news_;
	}
}
