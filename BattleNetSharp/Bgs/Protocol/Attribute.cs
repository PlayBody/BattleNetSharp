using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034C RID: 844
	public sealed class Attribute : IMessage<Attribute>, IMessage, IEquatable<Attribute>, IDeepCloneable<Attribute>, IBufferMessage
	{
		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x00153E78 File Offset: 0x00152078
		[DebuggerNonUserCode]
		public static MessageParser<Attribute> Parser
		{
			get
			{
				return Attribute._parser;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x060057CC RID: 22476 RVA: 0x00153E90 File Offset: 0x00152090
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x00153EB4 File Offset: 0x001520B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Attribute.Descriptor;
			}
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00153ECB File Offset: 0x001520CB
		[DebuggerNonUserCode]
		public Attribute()
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00153ED8 File Offset: 0x001520D8
		[DebuggerNonUserCode]
		public Attribute(Attribute other)
			: this()
		{
			this.name_ = other.name_;
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00153F28 File Offset: 0x00152128
		[DebuggerNonUserCode]
		public Attribute Clone()
		{
			return new Attribute(this);
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x00153F40 File Offset: 0x00152140
		// (set) Token: 0x060057D2 RID: 22482 RVA: 0x00153F61 File Offset: 0x00152161
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Attribute.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x060057D3 RID: 22483 RVA: 0x00153F78 File Offset: 0x00152178
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00153F93 File Offset: 0x00152193
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x00153FA0 File Offset: 0x001521A0
		// (set) Token: 0x060057D6 RID: 22486 RVA: 0x00153FB8 File Offset: 0x001521B8
		[DebuggerNonUserCode]
		public Variant Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x00153FC4 File Offset: 0x001521C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Attribute);
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00153FE4 File Offset: 0x001521E4
		[DebuggerNonUserCode]
		public bool Equals(Attribute other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Value, other.Value);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00154058 File Offset: 0x00152258
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x001540C0 File Offset: 0x001522C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x001540D8 File Offset: 0x001522D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x001540E4 File Offset: 0x001522E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Value);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x00154158 File Offset: 0x00152358
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x001541C8 File Offset: 0x001523C8
		[DebuggerNonUserCode]
		public void MergeFrom(Attribute other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool flag2 = other.value_ != null;
				if (flag2)
				{
					bool flag3 = this.value_ == null;
					if (flag3)
					{
						this.Value = new Variant();
					}
					this.Value.MergeFrom(other.Value);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x0015424D File Offset: 0x0015244D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00154258 File Offset: 0x00152458
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.value_ == null;
						if (flag)
						{
							this.Value = new Variant();
						}
						input.ReadMessage(this.Value);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400281A RID: 10266
		private static readonly MessageParser<Attribute> _parser = new MessageParser<Attribute>(() => new Attribute());

		// Token: 0x0400281B RID: 10267
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400281C RID: 10268
		public const int NameFieldNumber = 1;

		// Token: 0x0400281D RID: 10269
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400281E RID: 10270
		private string name_;

		// Token: 0x0400281F RID: 10271
		public const int ValueFieldNumber = 2;

		// Token: 0x04002820 RID: 10272
		private Variant value_;
	}
}
