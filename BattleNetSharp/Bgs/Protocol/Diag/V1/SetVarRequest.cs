using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000424 RID: 1060
	public sealed class SetVarRequest : IMessage<SetVarRequest>, IMessage, IEquatable<SetVarRequest>, IDeepCloneable<SetVarRequest>, IBufferMessage
	{
		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006880 RID: 26752 RVA: 0x001948FC File Offset: 0x00192AFC
		[DebuggerNonUserCode]
		public static MessageParser<SetVarRequest> Parser
		{
			get
			{
				return SetVarRequest._parser;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x00194914 File Offset: 0x00192B14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x00194938 File Offset: 0x00192B38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetVarRequest.Descriptor;
			}
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x0019494F File Offset: 0x00192B4F
		[DebuggerNonUserCode]
		public SetVarRequest()
		{
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00194959 File Offset: 0x00192B59
		[DebuggerNonUserCode]
		public SetVarRequest(SetVarRequest other)
			: this()
		{
			this.name_ = other.name_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x0019498C File Offset: 0x00192B8C
		[DebuggerNonUserCode]
		public SetVarRequest Clone()
		{
			return new SetVarRequest(this);
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006886 RID: 26758 RVA: 0x001949A4 File Offset: 0x00192BA4
		// (set) Token: 0x06006887 RID: 26759 RVA: 0x001949C5 File Offset: 0x00192BC5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? SetVarRequest.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006888 RID: 26760 RVA: 0x001949DC File Offset: 0x00192BDC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001949F7 File Offset: 0x00192BF7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600688A RID: 26762 RVA: 0x00194A04 File Offset: 0x00192C04
		// (set) Token: 0x0600688B RID: 26763 RVA: 0x00194A25 File Offset: 0x00192C25
		[DebuggerNonUserCode]
		public string Value
		{
			get
			{
				return this.value_ ?? SetVarRequest.ValueDefaultValue;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600688C RID: 26764 RVA: 0x00194A3C File Offset: 0x00192C3C
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return this.value_ != null;
			}
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00194A57 File Offset: 0x00192C57
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this.value_ = null;
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x00194A64 File Offset: 0x00192C64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetVarRequest);
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x00194A84 File Offset: 0x00192C84
		[DebuggerNonUserCode]
		public bool Equals(SetVarRequest other)
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
						bool flag5 = this.Value != other.Value;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x00194AF8 File Offset: 0x00192CF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x00194B5C File Offset: 0x00192D5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x00194B74 File Offset: 0x00192D74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x00194B80 File Offset: 0x00192D80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x00194BF0 File Offset: 0x00192DF0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x00194C5C File Offset: 0x00192E5C
		[DebuggerNonUserCode]
		public void MergeFrom(SetVarRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x00194CBE File Offset: 0x00192EBE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x00194CCC File Offset: 0x00192ECC
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
						this.Value = input.ReadString();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04002F92 RID: 12178
		private static readonly MessageParser<SetVarRequest> _parser = new MessageParser<SetVarRequest>(() => new SetVarRequest());

		// Token: 0x04002F93 RID: 12179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F94 RID: 12180
		public const int NameFieldNumber = 1;

		// Token: 0x04002F95 RID: 12181
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002F96 RID: 12182
		private string name_;

		// Token: 0x04002F97 RID: 12183
		public const int ValueFieldNumber = 2;

		// Token: 0x04002F98 RID: 12184
		private static readonly string ValueDefaultValue = "";

		// Token: 0x04002F99 RID: 12185
		private string value_;
	}
}
