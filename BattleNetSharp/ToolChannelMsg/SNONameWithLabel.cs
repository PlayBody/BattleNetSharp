using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000051 RID: 81
	public sealed class SNONameWithLabel : IMessage<SNONameWithLabel>, IMessage, IEquatable<SNONameWithLabel>, IDeepCloneable<SNONameWithLabel>, IBufferMessage
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[DebuggerNonUserCode]
		public static MessageParser<SNONameWithLabel> Parser
		{
			get
			{
				return SNONameWithLabel._parser;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[58];
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001DDB4 File Offset: 0x0001BFB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SNONameWithLabel.Descriptor;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001DDCB File Offset: 0x0001BFCB
		[DebuggerNonUserCode]
		public SNONameWithLabel()
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[DebuggerNonUserCode]
		public SNONameWithLabel(SNONameWithLabel other)
			: this()
		{
			this.snoName_ = ((other.snoName_ != null) ? other.snoName_.Clone() : null);
			this.label_ = other.label_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001DE28 File Offset: 0x0001C028
		[DebuggerNonUserCode]
		public SNONameWithLabel Clone()
		{
			return new SNONameWithLabel(this);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001DE40 File Offset: 0x0001C040
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0001DE58 File Offset: 0x0001C058
		[DebuggerNonUserCode]
		public SNOName SnoName
		{
			get
			{
				return this.snoName_;
			}
			set
			{
				this.snoName_ = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001DE64 File Offset: 0x0001C064
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0001DE85 File Offset: 0x0001C085
		[DebuggerNonUserCode]
		public string Label
		{
			get
			{
				return this.label_ ?? SNONameWithLabel.LabelDefaultValue;
			}
			set
			{
				this.label_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001DE9C File Offset: 0x0001C09C
		[DebuggerNonUserCode]
		public bool HasLabel
		{
			get
			{
				return this.label_ != null;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001DEB7 File Offset: 0x0001C0B7
		[DebuggerNonUserCode]
		public void ClearLabel()
		{
			this.label_ = null;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SNONameWithLabel);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		[DebuggerNonUserCode]
		public bool Equals(SNONameWithLabel other)
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
					bool flag4 = !object.Equals(this.SnoName, other.SnoName);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Label != other.Label;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001DF58 File Offset: 0x0001C158
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.snoName_ != null;
			if (flag)
			{
				num ^= this.SnoName.GetHashCode();
			}
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				num ^= this.Label.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.snoName_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SnoName);
			}
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Label);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001E058 File Offset: 0x0001C258
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.snoName_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SnoName);
			}
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Label);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
		[DebuggerNonUserCode]
		public void MergeFrom(SNONameWithLabel other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.snoName_ != null;
				if (flag2)
				{
					bool flag3 = this.snoName_ == null;
					if (flag3)
					{
						this.SnoName = new SNOName();
					}
					this.SnoName.MergeFrom(other.SnoName);
				}
				bool hasLabel = other.HasLabel;
				if (hasLabel)
				{
					this.Label = other.Label;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001E14D File Offset: 0x0001C34D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001E158 File Offset: 0x0001C358
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
						this.Label = input.ReadString();
					}
				}
				else
				{
					bool flag = this.snoName_ == null;
					if (flag)
					{
						this.SnoName = new SNOName();
					}
					input.ReadMessage(this.SnoName);
				}
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly MessageParser<SNONameWithLabel> _parser = new MessageParser<SNONameWithLabel>(() => new SNONameWithLabel());

		// Token: 0x040002DB RID: 731
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002DC RID: 732
		public const int SnoNameFieldNumber = 1;

		// Token: 0x040002DD RID: 733
		private SNOName snoName_;

		// Token: 0x040002DE RID: 734
		public const int LabelFieldNumber = 2;

		// Token: 0x040002DF RID: 735
		private static readonly string LabelDefaultValue = "";

		// Token: 0x040002E0 RID: 736
		private string label_;
	}
}
