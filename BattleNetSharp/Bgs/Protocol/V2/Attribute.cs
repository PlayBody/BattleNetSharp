using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.V2
{
	// Token: 0x0200062C RID: 1580
	public sealed class Attribute : IMessage<Attribute>, IMessage, IEquatable<Attribute>, IDeepCloneable<Attribute>, IBufferMessage
	{
		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x06009395 RID: 37781 RVA: 0x0023BF38 File Offset: 0x0023A138
		[DebuggerNonUserCode]
		public static MessageParser<Attribute> Parser
		{
			get
			{
				return Attribute._parser;
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x06009396 RID: 37782 RVA: 0x0023BF50 File Offset: 0x0023A150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x06009397 RID: 37783 RVA: 0x0023BF74 File Offset: 0x0023A174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Attribute.Descriptor;
			}
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x0023BF8B File Offset: 0x0023A18B
		[DebuggerNonUserCode]
		public Attribute()
		{
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x0023BF98 File Offset: 0x0023A198
		[DebuggerNonUserCode]
		public Attribute(Attribute other)
			: this()
		{
			this.name_ = other.name_;
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x0023BFE8 File Offset: 0x0023A1E8
		[DebuggerNonUserCode]
		public Attribute Clone()
		{
			return new Attribute(this);
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x0023C000 File Offset: 0x0023A200
		// (set) Token: 0x0600939C RID: 37788 RVA: 0x0023C021 File Offset: 0x0023A221
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

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x0023C038 File Offset: 0x0023A238
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x0023C053 File Offset: 0x0023A253
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x0023C060 File Offset: 0x0023A260
		// (set) Token: 0x060093A0 RID: 37792 RVA: 0x0023C078 File Offset: 0x0023A278
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

		// Token: 0x060093A1 RID: 37793 RVA: 0x0023C084 File Offset: 0x0023A284
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Attribute);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x0023C0A4 File Offset: 0x0023A2A4
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

		// Token: 0x060093A3 RID: 37795 RVA: 0x0023C118 File Offset: 0x0023A318
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

		// Token: 0x060093A4 RID: 37796 RVA: 0x0023C180 File Offset: 0x0023A380
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x0023C198 File Offset: 0x0023A398
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x0023C1A4 File Offset: 0x0023A3A4
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

		// Token: 0x060093A7 RID: 37799 RVA: 0x0023C218 File Offset: 0x0023A418
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

		// Token: 0x060093A8 RID: 37800 RVA: 0x0023C288 File Offset: 0x0023A488
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

		// Token: 0x060093A9 RID: 37801 RVA: 0x0023C30D File Offset: 0x0023A50D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x0023C318 File Offset: 0x0023A518
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

		// Token: 0x0400429C RID: 17052
		private static readonly MessageParser<Attribute> _parser = new MessageParser<Attribute>(() => new Attribute());

		// Token: 0x0400429D RID: 17053
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400429E RID: 17054
		public const int NameFieldNumber = 1;

		// Token: 0x0400429F RID: 17055
		private static readonly string NameDefaultValue = "";

		// Token: 0x040042A0 RID: 17056
		private string name_;

		// Token: 0x040042A1 RID: 17057
		public const int ValueFieldNumber = 2;

		// Token: 0x040042A2 RID: 17058
		private Variant value_;
	}
}
