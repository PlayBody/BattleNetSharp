using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AF RID: 175
	public sealed class UIControlSelectedAction : IMessage<UIControlSelectedAction>, IMessage, IEquatable<UIControlSelectedAction>, IDeepCloneable<UIControlSelectedAction>, IBufferMessage
	{
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0003C240 File Offset: 0x0003A440
		[DebuggerNonUserCode]
		public static MessageParser<UIControlSelectedAction> Parser
		{
			get
			{
				return UIControlSelectedAction._parser;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0003C258 File Offset: 0x0003A458
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[152];
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0003C280 File Offset: 0x0003A480
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIControlSelectedAction.Descriptor;
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0003C297 File Offset: 0x0003A497
		[DebuggerNonUserCode]
		public UIControlSelectedAction()
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
		[DebuggerNonUserCode]
		public UIControlSelectedAction(UIControlSelectedAction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.useHandle_ = other.useHandle_;
			this.uiSno_ = other.uiSno_;
			this.deltaX_ = other.deltaX_;
			this.deltaY_ = other.deltaY_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0003C308 File Offset: 0x0003A508
		[DebuggerNonUserCode]
		public UIControlSelectedAction Clone()
		{
			return new UIControlSelectedAction(this);
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0003C320 File Offset: 0x0003A520
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0003C351 File Offset: 0x0003A551
		[DebuggerNonUserCode]
		public int UseHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int useHandleDefaultValue;
				if (flag)
				{
					useHandleDefaultValue = this.useHandle_;
				}
				else
				{
					useHandleDefaultValue = UIControlSelectedAction.UseHandleDefaultValue;
				}
				return useHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.useHandle_ = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0003C36C File Offset: 0x0003A56C
		[DebuggerNonUserCode]
		public bool HasUseHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0003C389 File Offset: 0x0003A589
		[DebuggerNonUserCode]
		public void ClearUseHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0003C39C File Offset: 0x0003A59C
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0003C3CD File Offset: 0x0003A5CD
		[DebuggerNonUserCode]
		public int UiSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int uiSnoDefaultValue;
				if (flag)
				{
					uiSnoDefaultValue = this.uiSno_;
				}
				else
				{
					uiSnoDefaultValue = UIControlSelectedAction.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0003C3E8 File Offset: 0x0003A5E8
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0003C405 File Offset: 0x0003A605
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0003C418 File Offset: 0x0003A618
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x0003C449 File Offset: 0x0003A649
		[DebuggerNonUserCode]
		public int DeltaX
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int deltaXDefaultValue;
				if (flag)
				{
					deltaXDefaultValue = this.deltaX_;
				}
				else
				{
					deltaXDefaultValue = UIControlSelectedAction.DeltaXDefaultValue;
				}
				return deltaXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.deltaX_ = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0003C464 File Offset: 0x0003A664
		[DebuggerNonUserCode]
		public bool HasDeltaX
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0003C481 File Offset: 0x0003A681
		[DebuggerNonUserCode]
		public void ClearDeltaX()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0003C494 File Offset: 0x0003A694
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0003C4C5 File Offset: 0x0003A6C5
		[DebuggerNonUserCode]
		public int DeltaY
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int deltaYDefaultValue;
				if (flag)
				{
					deltaYDefaultValue = this.deltaY_;
				}
				else
				{
					deltaYDefaultValue = UIControlSelectedAction.DeltaYDefaultValue;
				}
				return deltaYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.deltaY_ = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
		[DebuggerNonUserCode]
		public bool HasDeltaY
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0003C4FD File Offset: 0x0003A6FD
		[DebuggerNonUserCode]
		public void ClearDeltaY()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0003C510 File Offset: 0x0003A710
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIControlSelectedAction);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0003C530 File Offset: 0x0003A730
		[DebuggerNonUserCode]
		public bool Equals(UIControlSelectedAction other)
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
					bool flag4 = this.UseHandle != other.UseHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UiSno != other.UiSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeltaX != other.DeltaX;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DeltaY != other.DeltaY;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0003C5DC File Offset: 0x0003A7DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUseHandle = this.HasUseHandle;
			if (hasUseHandle)
			{
				num ^= this.UseHandle.GetHashCode();
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool hasDeltaX = this.HasDeltaX;
			if (hasDeltaX)
			{
				num ^= this.DeltaX.GetHashCode();
			}
			bool hasDeltaY = this.HasDeltaY;
			if (hasDeltaY)
			{
				num ^= this.DeltaY.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0003C684 File Offset: 0x0003A884
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0003C69C File Offset: 0x0003A89C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUseHandle = this.HasUseHandle;
			if (hasUseHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UseHandle);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UiSno);
			}
			bool hasDeltaX = this.HasDeltaX;
			if (hasDeltaX)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DeltaX);
			}
			bool hasDeltaY = this.HasDeltaY;
			if (hasDeltaY)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DeltaY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0003C75C File Offset: 0x0003A95C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUseHandle = this.HasUseHandle;
			if (hasUseHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseHandle);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool hasDeltaX = this.HasDeltaX;
			if (hasDeltaX)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeltaX);
			}
			bool hasDeltaY = this.HasDeltaY;
			if (hasDeltaY)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeltaY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0003C804 File Offset: 0x0003AA04
		[DebuggerNonUserCode]
		public void MergeFrom(UIControlSelectedAction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUseHandle = other.HasUseHandle;
				if (hasUseHandle)
				{
					this.UseHandle = other.UseHandle;
				}
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				bool hasDeltaX = other.HasDeltaX;
				if (hasDeltaX)
				{
					this.DeltaX = other.DeltaX;
				}
				bool hasDeltaY = other.HasDeltaY;
				if (hasDeltaY)
				{
					this.DeltaY = other.DeltaY;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0003C89A File Offset: 0x0003AA9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0003C8A8 File Offset: 0x0003AAA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.UiSno = input.ReadInt32();
					}
					else
					{
						this.UseHandle = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.DeltaY = input.ReadInt32();
				}
				else
				{
					this.DeltaX = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000687 RID: 1671
		private static readonly MessageParser<UIControlSelectedAction> _parser = new MessageParser<UIControlSelectedAction>(() => new UIControlSelectedAction());

		// Token: 0x04000688 RID: 1672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000689 RID: 1673
		private int _hasBits0;

		// Token: 0x0400068A RID: 1674
		public const int UseHandleFieldNumber = 1;

		// Token: 0x0400068B RID: 1675
		private static readonly int UseHandleDefaultValue = 0;

		// Token: 0x0400068C RID: 1676
		private int useHandle_;

		// Token: 0x0400068D RID: 1677
		public const int UiSnoFieldNumber = 2;

		// Token: 0x0400068E RID: 1678
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x0400068F RID: 1679
		private int uiSno_;

		// Token: 0x04000690 RID: 1680
		public const int DeltaXFieldNumber = 3;

		// Token: 0x04000691 RID: 1681
		private static readonly int DeltaXDefaultValue = 0;

		// Token: 0x04000692 RID: 1682
		private int deltaX_;

		// Token: 0x04000693 RID: 1683
		public const int DeltaYFieldNumber = 4;

		// Token: 0x04000694 RID: 1684
		private static readonly int DeltaYDefaultValue = 0;

		// Token: 0x04000695 RID: 1685
		private int deltaY_;
	}
}
