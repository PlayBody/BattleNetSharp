using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002BC RID: 700
	public sealed class ClanNewsList : IMessage<ClanNewsList>, IMessage, IEquatable<ClanNewsList>, IDeepCloneable<ClanNewsList>, IBufferMessage
	{
		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x0011E180 File Offset: 0x0011C380
		[DebuggerNonUserCode]
		public static MessageParser<ClanNewsList> Parser
		{
			get
			{
				return ClanNewsList._parser;
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x0011E198 File Offset: 0x0011C398
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x0011E1BC File Offset: 0x0011C3BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanNewsList.Descriptor;
			}
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x0011E1D3 File Offset: 0x0011C3D3
		[DebuggerNonUserCode]
		public ClanNewsList()
		{
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x0011E1E8 File Offset: 0x0011C3E8
		[DebuggerNonUserCode]
		public ClanNewsList(ClanNewsList other)
			: this()
		{
			this.news_ = other.news_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0011E214 File Offset: 0x0011C414
		[DebuggerNonUserCode]
		public ClanNewsList Clone()
		{
			return new ClanNewsList(this);
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004AAB RID: 19115 RVA: 0x0011E22C File Offset: 0x0011C42C
		[DebuggerNonUserCode]
		public RepeatedField<ClanNewsItem> News
		{
			get
			{
				return this.news_;
			}
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x0011E244 File Offset: 0x0011C444
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanNewsList);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0011E264 File Offset: 0x0011C464
		[DebuggerNonUserCode]
		public bool Equals(ClanNewsList other)
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
					bool flag4 = !this.news_.Equals(other.news_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0011E2C0 File Offset: 0x0011C4C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.news_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0011E300 File Offset: 0x0011C500
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x0011E318 File Offset: 0x0011C518
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x0011E324 File Offset: 0x0011C524
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.news_.WriteTo(ref output, ClanNewsList._repeated_news_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x0011E360 File Offset: 0x0011C560
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.news_.CalculateSize(ClanNewsList._repeated_news_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x0011E3A8 File Offset: 0x0011C5A8
		[DebuggerNonUserCode]
		public void MergeFrom(ClanNewsList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.news_.Add(other.news_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0011E3EA File Offset: 0x0011C5EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x0011E3F8 File Offset: 0x0011C5F8
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
					this.news_.AddEntriesFrom(ref input, ClanNewsList._repeated_news_codec);
				}
			}
		}

		// Token: 0x0400215D RID: 8541
		private static readonly MessageParser<ClanNewsList> _parser = new MessageParser<ClanNewsList>(() => new ClanNewsList());

		// Token: 0x0400215E RID: 8542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400215F RID: 8543
		public const int NewsFieldNumber = 1;

		// Token: 0x04002160 RID: 8544
		private static readonly FieldCodec<ClanNewsItem> _repeated_news_codec = FieldCodec.ForMessage<ClanNewsItem>(10U, ClanNewsItem.Parser);

		// Token: 0x04002161 RID: 8545
		private readonly RepeatedField<ClanNewsItem> news_ = new RepeatedField<ClanNewsItem>();
	}
}
