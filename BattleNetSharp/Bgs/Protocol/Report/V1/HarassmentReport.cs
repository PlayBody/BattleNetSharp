using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057B RID: 1403
	public sealed class HarassmentReport : IMessage<HarassmentReport>, IMessage, IEquatable<HarassmentReport>, IDeepCloneable<HarassmentReport>, IBufferMessage
	{
		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x0020C608 File Offset: 0x0020A808
		[DebuggerNonUserCode]
		public static MessageParser<HarassmentReport> Parser
		{
			get
			{
				return HarassmentReport._parser;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x0020C620 File Offset: 0x0020A820
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x0020C644 File Offset: 0x0020A844
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarassmentReport.Descriptor;
			}
		}

		// Token: 0x060086DF RID: 34527 RVA: 0x0020C65B File Offset: 0x0020A85B
		[DebuggerNonUserCode]
		public HarassmentReport()
		{
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x0020C668 File Offset: 0x0020A868
		[DebuggerNonUserCode]
		public HarassmentReport(HarassmentReport other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.text_ = other.text_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x0020C6B8 File Offset: 0x0020A8B8
		[DebuggerNonUserCode]
		public HarassmentReport Clone()
		{
			return new HarassmentReport(this);
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x060086E2 RID: 34530 RVA: 0x0020C6D0 File Offset: 0x0020A8D0
		// (set) Token: 0x060086E3 RID: 34531 RVA: 0x0020C6E8 File Offset: 0x0020A8E8
		[DebuggerNonUserCode]
		public GameAccountHandle Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x060086E4 RID: 34532 RVA: 0x0020C6F4 File Offset: 0x0020A8F4
		// (set) Token: 0x060086E5 RID: 34533 RVA: 0x0020C715 File Offset: 0x0020A915
		[DebuggerNonUserCode]
		public string Text
		{
			get
			{
				return this.text_ ?? HarassmentReport.TextDefaultValue;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x060086E6 RID: 34534 RVA: 0x0020C72C File Offset: 0x0020A92C
		[DebuggerNonUserCode]
		public bool HasText
		{
			get
			{
				return this.text_ != null;
			}
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x0020C747 File Offset: 0x0020A947
		[DebuggerNonUserCode]
		public void ClearText()
		{
			this.text_ = null;
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x0020C754 File Offset: 0x0020A954
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarassmentReport);
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x0020C774 File Offset: 0x0020A974
		[DebuggerNonUserCode]
		public bool Equals(HarassmentReport other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Text != other.Text;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x0020C7E8 File Offset: 0x0020A9E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				num ^= this.Text.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x0020C850 File Offset: 0x0020AA50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x0020C868 File Offset: 0x0020AA68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x0020C874 File Offset: 0x0020AA74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Text);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x0020C8E8 File Offset: 0x0020AAE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x0020C958 File Offset: 0x0020AB58
		[DebuggerNonUserCode]
		public void MergeFrom(HarassmentReport other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new GameAccountHandle();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool hasText = other.HasText;
				if (hasText)
				{
					this.Text = other.Text;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x0020C9DD File Offset: 0x0020ABDD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x0020C9E8 File Offset: 0x0020ABE8
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
						this.Text = input.ReadString();
					}
				}
				else
				{
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new GameAccountHandle();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003D1C RID: 15644
		private static readonly MessageParser<HarassmentReport> _parser = new MessageParser<HarassmentReport>(() => new HarassmentReport());

		// Token: 0x04003D1D RID: 15645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D1E RID: 15646
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D1F RID: 15647
		private GameAccountHandle target_;

		// Token: 0x04003D20 RID: 15648
		public const int TextFieldNumber = 2;

		// Token: 0x04003D21 RID: 15649
		private static readonly string TextDefaultValue = "";

		// Token: 0x04003D22 RID: 15650
		private string text_;
	}
}
