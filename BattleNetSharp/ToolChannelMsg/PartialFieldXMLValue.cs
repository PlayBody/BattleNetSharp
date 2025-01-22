using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002E RID: 46
	public sealed class PartialFieldXMLValue : IMessage<PartialFieldXMLValue>, IMessage, IEquatable<PartialFieldXMLValue>, IDeepCloneable<PartialFieldXMLValue>, IBufferMessage
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00010798 File Offset: 0x0000E998
		[DebuggerNonUserCode]
		public static MessageParser<PartialFieldXMLValue> Parser
		{
			get
			{
				return PartialFieldXMLValue._parser;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000107B0 File Offset: 0x0000E9B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000107D4 File Offset: 0x0000E9D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartialFieldXMLValue.Descriptor;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000107EB File Offset: 0x0000E9EB
		[DebuggerNonUserCode]
		public PartialFieldXMLValue()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000107F8 File Offset: 0x0000E9F8
		[DebuggerNonUserCode]
		public PartialFieldXMLValue(PartialFieldXMLValue other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.fieldPath_ = other.fieldPath_;
			this.xmlValue_ = other.xmlValue_;
			this.actionType_ = other.actionType_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001085C File Offset: 0x0000EA5C
		[DebuggerNonUserCode]
		public PartialFieldXMLValue Clone()
		{
			return new PartialFieldXMLValue(this);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00010874 File Offset: 0x0000EA74
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00010895 File Offset: 0x0000EA95
		[DebuggerNonUserCode]
		public string FieldPath
		{
			get
			{
				return this.fieldPath_ ?? PartialFieldXMLValue.FieldPathDefaultValue;
			}
			set
			{
				this.fieldPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000108AC File Offset: 0x0000EAAC
		[DebuggerNonUserCode]
		public bool HasFieldPath
		{
			get
			{
				return this.fieldPath_ != null;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000108C7 File Offset: 0x0000EAC7
		[DebuggerNonUserCode]
		public void ClearFieldPath()
		{
			this.fieldPath_ = null;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002EF RID: 751 RVA: 0x000108D4 File Offset: 0x0000EAD4
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000108F5 File Offset: 0x0000EAF5
		[DebuggerNonUserCode]
		public string XmlValue
		{
			get
			{
				return this.xmlValue_ ?? PartialFieldXMLValue.XmlValueDefaultValue;
			}
			set
			{
				this.xmlValue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001090C File Offset: 0x0000EB0C
		[DebuggerNonUserCode]
		public bool HasXmlValue
		{
			get
			{
				return this.xmlValue_ != null;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00010927 File Offset: 0x0000EB27
		[DebuggerNonUserCode]
		public void ClearXmlValue()
		{
			this.xmlValue_ = null;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00010934 File Offset: 0x0000EB34
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00010965 File Offset: 0x0000EB65
		[DebuggerNonUserCode]
		public ActionType ActionType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ActionType actionTypeDefaultValue;
				if (flag)
				{
					actionTypeDefaultValue = this.actionType_;
				}
				else
				{
					actionTypeDefaultValue = PartialFieldXMLValue.ActionTypeDefaultValue;
				}
				return actionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.actionType_ = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00010980 File Offset: 0x0000EB80
		[DebuggerNonUserCode]
		public bool HasActionType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001099D File Offset: 0x0000EB9D
		[DebuggerNonUserCode]
		public void ClearActionType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x000109B0 File Offset: 0x0000EBB0
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000109E1 File Offset: 0x0000EBE1
		[DebuggerNonUserCode]
		public int Index
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int indexDefaultValue;
				if (flag)
				{
					indexDefaultValue = this.index_;
				}
				else
				{
					indexDefaultValue = PartialFieldXMLValue.IndexDefaultValue;
				}
				return indexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.index_ = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x000109FC File Offset: 0x0000EBFC
		[DebuggerNonUserCode]
		public bool HasIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010A19 File Offset: 0x0000EC19
		[DebuggerNonUserCode]
		public void ClearIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00010A2C File Offset: 0x0000EC2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartialFieldXMLValue);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00010A4C File Offset: 0x0000EC4C
		[DebuggerNonUserCode]
		public bool Equals(PartialFieldXMLValue other)
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
					bool flag4 = this.FieldPath != other.FieldPath;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.XmlValue != other.XmlValue;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ActionType != other.ActionType;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Index != other.Index;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00010AF8 File Offset: 0x0000ECF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				num ^= this.FieldPath.GetHashCode();
			}
			bool hasXmlValue = this.HasXmlValue;
			if (hasXmlValue)
			{
				num ^= this.XmlValue.GetHashCode();
			}
			bool hasActionType = this.HasActionType;
			if (hasActionType)
			{
				num ^= this.ActionType.GetHashCode();
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num ^= this.Index.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010BB8 File Offset: 0x0000EDB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FieldPath);
			}
			bool hasXmlValue = this.HasXmlValue;
			if (hasXmlValue)
			{
				output.WriteRawTag(18);
				output.WriteString(this.XmlValue);
			}
			bool hasActionType = this.HasActionType;
			if (hasActionType)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ActionType);
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010C78 File Offset: 0x0000EE78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FieldPath);
			}
			bool hasXmlValue = this.HasXmlValue;
			if (hasXmlValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XmlValue);
			}
			bool hasActionType = this.HasActionType;
			if (hasActionType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActionType);
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00010D20 File Offset: 0x0000EF20
		[DebuggerNonUserCode]
		public void MergeFrom(PartialFieldXMLValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFieldPath = other.HasFieldPath;
				if (hasFieldPath)
				{
					this.FieldPath = other.FieldPath;
				}
				bool hasXmlValue = other.HasXmlValue;
				if (hasXmlValue)
				{
					this.XmlValue = other.XmlValue;
				}
				bool hasActionType = other.HasActionType;
				if (hasActionType)
				{
					this.ActionType = other.ActionType;
				}
				bool hasIndex = other.HasIndex;
				if (hasIndex)
				{
					this.Index = other.Index;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010DB6 File Offset: 0x0000EFB6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0029;
						}
						this.XmlValue = input.ReadString();
					}
					else
					{
						this.FieldPath = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.Index = input.ReadInt32();
				}
				else
				{
					this.ActionType = (ActionType)input.ReadEnum();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400012B RID: 299
		private static readonly MessageParser<PartialFieldXMLValue> _parser = new MessageParser<PartialFieldXMLValue>(() => new PartialFieldXMLValue());

		// Token: 0x0400012C RID: 300
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400012D RID: 301
		private int _hasBits0;

		// Token: 0x0400012E RID: 302
		public const int FieldPathFieldNumber = 1;

		// Token: 0x0400012F RID: 303
		private static readonly string FieldPathDefaultValue = "";

		// Token: 0x04000130 RID: 304
		private string fieldPath_;

		// Token: 0x04000131 RID: 305
		public const int XmlValueFieldNumber = 2;

		// Token: 0x04000132 RID: 306
		private static readonly string XmlValueDefaultValue = "";

		// Token: 0x04000133 RID: 307
		private string xmlValue_;

		// Token: 0x04000134 RID: 308
		public const int ActionTypeFieldNumber = 3;

		// Token: 0x04000135 RID: 309
		private static readonly ActionType ActionTypeDefaultValue = ActionType.Modify;

		// Token: 0x04000136 RID: 310
		private ActionType actionType_;

		// Token: 0x04000137 RID: 311
		public const int IndexFieldNumber = 4;

		// Token: 0x04000138 RID: 312
		private static readonly int IndexDefaultValue = 0;

		// Token: 0x04000139 RID: 313
		private int index_;
	}
}
