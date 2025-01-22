using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B0 RID: 176
	public sealed class UIControlAxeAction : IMessage<UIControlAxeAction>, IMessage, IEquatable<UIControlAxeAction>, IDeepCloneable<UIControlAxeAction>, IBufferMessage
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0003C978 File Offset: 0x0003AB78
		[DebuggerNonUserCode]
		public static MessageParser<UIControlAxeAction> Parser
		{
			get
			{
				return UIControlAxeAction._parser;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0003C990 File Offset: 0x0003AB90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[153];
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0003C9B8 File Offset: 0x0003ABB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIControlAxeAction.Descriptor;
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0003C9CF File Offset: 0x0003ABCF
		[DebuggerNonUserCode]
		public UIControlAxeAction()
		{
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0003C9D9 File Offset: 0x0003ABD9
		[DebuggerNonUserCode]
		public UIControlAxeAction(UIControlAxeAction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.uiSno_ = other.uiSno_;
			this.action_ = other.action_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0003CA18 File Offset: 0x0003AC18
		[DebuggerNonUserCode]
		public UIControlAxeAction Clone()
		{
			return new UIControlAxeAction(this);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0003CA30 File Offset: 0x0003AC30
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x0003CA61 File Offset: 0x0003AC61
		[DebuggerNonUserCode]
		public int UiSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int uiSnoDefaultValue;
				if (flag)
				{
					uiSnoDefaultValue = this.uiSno_;
				}
				else
				{
					uiSnoDefaultValue = UIControlAxeAction.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0003CA7C File Offset: 0x0003AC7C
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0003CA99 File Offset: 0x0003AC99
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0003CAAC File Offset: 0x0003ACAC
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x0003CADD File Offset: 0x0003ACDD
		[DebuggerNonUserCode]
		public int Action
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int actionDefaultValue;
				if (flag)
				{
					actionDefaultValue = this.action_;
				}
				else
				{
					actionDefaultValue = UIControlAxeAction.ActionDefaultValue;
				}
				return actionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.action_ = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0003CAF8 File Offset: 0x0003ACF8
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0003CB15 File Offset: 0x0003AD15
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0003CB28 File Offset: 0x0003AD28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIControlAxeAction);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0003CB48 File Offset: 0x0003AD48
		[DebuggerNonUserCode]
		public bool Equals(UIControlAxeAction other)
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
					bool flag4 = this.UiSno != other.UiSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Action != other.Action;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0003CBBC File Offset: 0x0003ADBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num ^= this.Action.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0003CC28 File Offset: 0x0003AE28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0003CC40 File Offset: 0x0003AE40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0003CC4C File Offset: 0x0003AE4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UiSno);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Action);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0003CCBC File Offset: 0x0003AEBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Action);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0003CD28 File Offset: 0x0003AF28
		[DebuggerNonUserCode]
		public void MergeFrom(UIControlAxeAction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0003CD8A File Offset: 0x0003AF8A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0003CD98 File Offset: 0x0003AF98
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Action = input.ReadInt32();
					}
				}
				else
				{
					this.UiSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000696 RID: 1686
		private static readonly MessageParser<UIControlAxeAction> _parser = new MessageParser<UIControlAxeAction>(() => new UIControlAxeAction());

		// Token: 0x04000697 RID: 1687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000698 RID: 1688
		private int _hasBits0;

		// Token: 0x04000699 RID: 1689
		public const int UiSnoFieldNumber = 1;

		// Token: 0x0400069A RID: 1690
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x0400069B RID: 1691
		private int uiSno_;

		// Token: 0x0400069C RID: 1692
		public const int ActionFieldNumber = 2;

		// Token: 0x0400069D RID: 1693
		private static readonly int ActionDefaultValue = 0;

		// Token: 0x0400069E RID: 1694
		private int action_;
	}
}
