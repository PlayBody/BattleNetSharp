using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057C RID: 1404
	public sealed class RealLifeThreatReport : IMessage<RealLifeThreatReport>, IMessage, IEquatable<RealLifeThreatReport>, IDeepCloneable<RealLifeThreatReport>, IBufferMessage
	{
		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x060086F3 RID: 34547 RVA: 0x0020CA94 File Offset: 0x0020AC94
		[DebuggerNonUserCode]
		public static MessageParser<RealLifeThreatReport> Parser
		{
			get
			{
				return RealLifeThreatReport._parser;
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x0020CAAC File Offset: 0x0020ACAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x060086F5 RID: 34549 RVA: 0x0020CAD0 File Offset: 0x0020ACD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealLifeThreatReport.Descriptor;
			}
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x0020CAE7 File Offset: 0x0020ACE7
		[DebuggerNonUserCode]
		public RealLifeThreatReport()
		{
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x0020CAF4 File Offset: 0x0020ACF4
		[DebuggerNonUserCode]
		public RealLifeThreatReport(RealLifeThreatReport other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.text_ = other.text_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x0020CB44 File Offset: 0x0020AD44
		[DebuggerNonUserCode]
		public RealLifeThreatReport Clone()
		{
			return new RealLifeThreatReport(this);
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x060086F9 RID: 34553 RVA: 0x0020CB5C File Offset: 0x0020AD5C
		// (set) Token: 0x060086FA RID: 34554 RVA: 0x0020CB74 File Offset: 0x0020AD74
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

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x060086FB RID: 34555 RVA: 0x0020CB80 File Offset: 0x0020AD80
		// (set) Token: 0x060086FC RID: 34556 RVA: 0x0020CBA1 File Offset: 0x0020ADA1
		[DebuggerNonUserCode]
		public string Text
		{
			get
			{
				return this.text_ ?? RealLifeThreatReport.TextDefaultValue;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x0020CBB8 File Offset: 0x0020ADB8
		[DebuggerNonUserCode]
		public bool HasText
		{
			get
			{
				return this.text_ != null;
			}
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x0020CBD3 File Offset: 0x0020ADD3
		[DebuggerNonUserCode]
		public void ClearText()
		{
			this.text_ = null;
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x0020CBE0 File Offset: 0x0020ADE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealLifeThreatReport);
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x0020CC00 File Offset: 0x0020AE00
		[DebuggerNonUserCode]
		public bool Equals(RealLifeThreatReport other)
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

		// Token: 0x06008701 RID: 34561 RVA: 0x0020CC74 File Offset: 0x0020AE74
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

		// Token: 0x06008702 RID: 34562 RVA: 0x0020CCDC File Offset: 0x0020AEDC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x0020CCF4 File Offset: 0x0020AEF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x0020CD00 File Offset: 0x0020AF00
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

		// Token: 0x06008705 RID: 34565 RVA: 0x0020CD74 File Offset: 0x0020AF74
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

		// Token: 0x06008706 RID: 34566 RVA: 0x0020CDE4 File Offset: 0x0020AFE4
		[DebuggerNonUserCode]
		public void MergeFrom(RealLifeThreatReport other)
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

		// Token: 0x06008707 RID: 34567 RVA: 0x0020CE69 File Offset: 0x0020B069
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x0020CE74 File Offset: 0x0020B074
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

		// Token: 0x04003D23 RID: 15651
		private static readonly MessageParser<RealLifeThreatReport> _parser = new MessageParser<RealLifeThreatReport>(() => new RealLifeThreatReport());

		// Token: 0x04003D24 RID: 15652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D25 RID: 15653
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D26 RID: 15654
		private GameAccountHandle target_;

		// Token: 0x04003D27 RID: 15655
		public const int TextFieldNumber = 2;

		// Token: 0x04003D28 RID: 15656
		private static readonly string TextDefaultValue = "";

		// Token: 0x04003D29 RID: 15657
		private string text_;
	}
}
