using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x0200015B RID: 347
	public sealed class Consumable : IMessage<Consumable>, IMessage, IEquatable<Consumable>, IDeepCloneable<Consumable>, IBufferMessage
	{
		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0008AFC0 File Offset: 0x000891C0
		[DebuggerNonUserCode]
		public static MessageParser<Consumable> Parser
		{
			get
			{
				return Consumable._parser;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x0008AFD8 File Offset: 0x000891D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0008AFFC File Offset: 0x000891FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Consumable.Descriptor;
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0008B013 File Offset: 0x00089213
		[DebuggerNonUserCode]
		public Consumable()
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0008B01D File Offset: 0x0008921D
		[DebuggerNonUserCode]
		public Consumable(Consumable other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.productSno_ = other.productSno_;
			this.bnetConsumableIdV2_ = other.bnetConsumableIdV2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0008B05C File Offset: 0x0008925C
		[DebuggerNonUserCode]
		public Consumable Clone()
		{
			return new Consumable(this);
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0008B074 File Offset: 0x00089274
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0008B0A5 File Offset: 0x000892A5
		[DebuggerNonUserCode]
		public int ProductSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int productSnoDefaultValue;
				if (flag)
				{
					productSnoDefaultValue = this.productSno_;
				}
				else
				{
					productSnoDefaultValue = Consumable.ProductSnoDefaultValue;
				}
				return productSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.productSno_ = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0008B0C0 File Offset: 0x000892C0
		[DebuggerNonUserCode]
		public bool HasProductSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0008B0DD File Offset: 0x000892DD
		[DebuggerNonUserCode]
		public void ClearProductSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0008B0F0 File Offset: 0x000892F0
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0008B111 File Offset: 0x00089311
		[DebuggerNonUserCode]
		public string BnetConsumableIdV2
		{
			get
			{
				return this.bnetConsumableIdV2_ ?? Consumable.BnetConsumableIdV2DefaultValue;
			}
			set
			{
				this.bnetConsumableIdV2_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x0008B128 File Offset: 0x00089328
		[DebuggerNonUserCode]
		public bool HasBnetConsumableIdV2
		{
			get
			{
				return this.bnetConsumableIdV2_ != null;
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0008B143 File Offset: 0x00089343
		[DebuggerNonUserCode]
		public void ClearBnetConsumableIdV2()
		{
			this.bnetConsumableIdV2_ = null;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0008B150 File Offset: 0x00089350
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Consumable);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0008B170 File Offset: 0x00089370
		[DebuggerNonUserCode]
		public bool Equals(Consumable other)
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
					bool flag4 = this.ProductSno != other.ProductSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BnetConsumableIdV2 != other.BnetConsumableIdV2;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0008B1E4 File Offset: 0x000893E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				num ^= this.ProductSno.GetHashCode();
			}
			bool hasBnetConsumableIdV = this.HasBnetConsumableIdV2;
			if (hasBnetConsumableIdV)
			{
				num ^= this.BnetConsumableIdV2.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0008B250 File Offset: 0x00089450
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0008B268 File Offset: 0x00089468
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0008B274 File Offset: 0x00089474
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ProductSno);
			}
			bool hasBnetConsumableIdV = this.HasBnetConsumableIdV2;
			if (hasBnetConsumableIdV)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BnetConsumableIdV2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0008B2E4 File Offset: 0x000894E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProductSno);
			}
			bool hasBnetConsumableIdV = this.HasBnetConsumableIdV2;
			if (hasBnetConsumableIdV)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BnetConsumableIdV2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x0008B350 File Offset: 0x00089550
		[DebuggerNonUserCode]
		public void MergeFrom(Consumable other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProductSno = other.HasProductSno;
				if (hasProductSno)
				{
					this.ProductSno = other.ProductSno;
				}
				bool hasBnetConsumableIdV = other.HasBnetConsumableIdV2;
				if (hasBnetConsumableIdV)
				{
					this.BnetConsumableIdV2 = other.BnetConsumableIdV2;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0008B3B2 File Offset: 0x000895B2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0008B3C0 File Offset: 0x000895C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BnetConsumableIdV2 = input.ReadString();
					}
				}
				else
				{
					this.ProductSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000FBB RID: 4027
		private static readonly MessageParser<Consumable> _parser = new MessageParser<Consumable>(() => new Consumable());

		// Token: 0x04000FBC RID: 4028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FBD RID: 4029
		private int _hasBits0;

		// Token: 0x04000FBE RID: 4030
		public const int ProductSnoFieldNumber = 1;

		// Token: 0x04000FBF RID: 4031
		private static readonly int ProductSnoDefaultValue = -1;

		// Token: 0x04000FC0 RID: 4032
		private int productSno_;

		// Token: 0x04000FC1 RID: 4033
		public const int BnetConsumableIdV2FieldNumber = 2;

		// Token: 0x04000FC2 RID: 4034
		private static readonly string BnetConsumableIdV2DefaultValue = "";

		// Token: 0x04000FC3 RID: 4035
		private string bnetConsumableIdV2_;
	}
}
