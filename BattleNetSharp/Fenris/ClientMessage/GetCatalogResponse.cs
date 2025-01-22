using System;
using System.Diagnostics;
using Fenris.Store;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000290 RID: 656
	public sealed class GetCatalogResponse : IMessage<GetCatalogResponse>, IMessage, IEquatable<GetCatalogResponse>, IDeepCloneable<GetCatalogResponse>, IBufferMessage
	{
		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x0010BAD4 File Offset: 0x00109CD4
		[DebuggerNonUserCode]
		public static MessageParser<GetCatalogResponse> Parser
		{
			get
			{
				return GetCatalogResponse._parser;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x0010BAEC File Offset: 0x00109CEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[128];
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x0010BB14 File Offset: 0x00109D14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCatalogResponse.Descriptor;
			}
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0010BB2B File Offset: 0x00109D2B
		[DebuggerNonUserCode]
		public GetCatalogResponse()
		{
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0010BB35 File Offset: 0x00109D35
		[DebuggerNonUserCode]
		public GetCatalogResponse(GetCatalogResponse other)
			: this()
		{
			this.catalog_ = ((other.catalog_ != null) ? other.catalog_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x0010BB6C File Offset: 0x00109D6C
		[DebuggerNonUserCode]
		public GetCatalogResponse Clone()
		{
			return new GetCatalogResponse(this);
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x0010BB84 File Offset: 0x00109D84
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x0010BB9C File Offset: 0x00109D9C
		[DebuggerNonUserCode]
		public Catalog Catalog
		{
			get
			{
				return this.catalog_;
			}
			set
			{
				this.catalog_ = value;
			}
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x0010BBA8 File Offset: 0x00109DA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCatalogResponse);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x0010BBC8 File Offset: 0x00109DC8
		[DebuggerNonUserCode]
		public bool Equals(GetCatalogResponse other)
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
					bool flag4 = !object.Equals(this.Catalog, other.Catalog);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0010BC24 File Offset: 0x00109E24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.catalog_ != null;
			if (flag)
			{
				num ^= this.Catalog.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x0010BC74 File Offset: 0x00109E74
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x0010BC8C File Offset: 0x00109E8C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x0010BC98 File Offset: 0x00109E98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.catalog_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Catalog);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x0010BCE8 File Offset: 0x00109EE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.catalog_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Catalog);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x0010BD3C File Offset: 0x00109F3C
		[DebuggerNonUserCode]
		public void MergeFrom(GetCatalogResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.catalog_ != null;
				if (flag2)
				{
					bool flag3 = this.catalog_ == null;
					if (flag3)
					{
						this.Catalog = new Catalog();
					}
					this.Catalog.MergeFrom(other.Catalog);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x0010BDA8 File Offset: 0x00109FA8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0010BDB4 File Offset: 0x00109FB4
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
					bool flag = this.catalog_ == null;
					if (flag)
					{
						this.Catalog = new Catalog();
					}
					input.ReadMessage(this.Catalog);
				}
			}
		}

		// Token: 0x04001F21 RID: 7969
		private static readonly MessageParser<GetCatalogResponse> _parser = new MessageParser<GetCatalogResponse>(() => new GetCatalogResponse());

		// Token: 0x04001F22 RID: 7970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F23 RID: 7971
		public const int CatalogFieldNumber = 1;

		// Token: 0x04001F24 RID: 7972
		private Catalog catalog_;
	}
}
