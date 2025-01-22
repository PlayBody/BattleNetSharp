using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AE RID: 174
	public sealed class UIControlVisibility : IMessage<UIControlVisibility>, IMessage, IEquatable<UIControlVisibility>, IDeepCloneable<UIControlVisibility>, IBufferMessage
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0003BB34 File Offset: 0x00039D34
		[DebuggerNonUserCode]
		public static MessageParser<UIControlVisibility> Parser
		{
			get
			{
				return UIControlVisibility._parser;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0003BB4C File Offset: 0x00039D4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[151];
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0003BB74 File Offset: 0x00039D74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIControlVisibility.Descriptor;
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0003BB8B File Offset: 0x00039D8B
		[DebuggerNonUserCode]
		public UIControlVisibility()
		{
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0003BB98 File Offset: 0x00039D98
		[DebuggerNonUserCode]
		public UIControlVisibility(UIControlVisibility other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.path_ = other.path_;
			this.uiSno_ = other.uiSno_;
			this.isVisible_ = other.isVisible_;
			this.shouldOverride_ = other.shouldOverride_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0003BBFC File Offset: 0x00039DFC
		[DebuggerNonUserCode]
		public UIControlVisibility Clone()
		{
			return new UIControlVisibility(this);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0003BC14 File Offset: 0x00039E14
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0003BC35 File Offset: 0x00039E35
		[DebuggerNonUserCode]
		public string Path
		{
			get
			{
				return this.path_ ?? UIControlVisibility.PathDefaultValue;
			}
			set
			{
				this.path_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0003BC4C File Offset: 0x00039E4C
		[DebuggerNonUserCode]
		public bool HasPath
		{
			get
			{
				return this.path_ != null;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0003BC67 File Offset: 0x00039E67
		[DebuggerNonUserCode]
		public void ClearPath()
		{
			this.path_ = null;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0003BC74 File Offset: 0x00039E74
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0003BCA5 File Offset: 0x00039EA5
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
					uiSnoDefaultValue = UIControlVisibility.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0003BCC0 File Offset: 0x00039EC0
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0003BCDD File Offset: 0x00039EDD
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0003BCF0 File Offset: 0x00039EF0
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x0003BD21 File Offset: 0x00039F21
		[DebuggerNonUserCode]
		public bool IsVisible
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isVisibleDefaultValue;
				if (flag)
				{
					isVisibleDefaultValue = this.isVisible_;
				}
				else
				{
					isVisibleDefaultValue = UIControlVisibility.IsVisibleDefaultValue;
				}
				return isVisibleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isVisible_ = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0003BD3C File Offset: 0x00039F3C
		[DebuggerNonUserCode]
		public bool HasIsVisible
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0003BD59 File Offset: 0x00039F59
		[DebuggerNonUserCode]
		public void ClearIsVisible()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0003BD6C File Offset: 0x00039F6C
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x0003BD9D File Offset: 0x00039F9D
		[DebuggerNonUserCode]
		public bool ShouldOverride
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool shouldOverrideDefaultValue;
				if (flag)
				{
					shouldOverrideDefaultValue = this.shouldOverride_;
				}
				else
				{
					shouldOverrideDefaultValue = UIControlVisibility.ShouldOverrideDefaultValue;
				}
				return shouldOverrideDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.shouldOverride_ = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		[DebuggerNonUserCode]
		public bool HasShouldOverride
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0003BDD5 File Offset: 0x00039FD5
		[DebuggerNonUserCode]
		public void ClearShouldOverride()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0003BDE8 File Offset: 0x00039FE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIControlVisibility);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0003BE08 File Offset: 0x0003A008
		[DebuggerNonUserCode]
		public bool Equals(UIControlVisibility other)
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
					bool flag4 = this.Path != other.Path;
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
							bool flag6 = this.IsVisible != other.IsVisible;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ShouldOverride != other.ShouldOverride;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				num ^= this.Path.GetHashCode();
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool hasIsVisible = this.HasIsVisible;
			if (hasIsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			bool hasShouldOverride = this.HasShouldOverride;
			if (hasShouldOverride)
			{
				num ^= this.ShouldOverride.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0003BF5C File Offset: 0x0003A15C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0003BF74 File Offset: 0x0003A174
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0003BF80 File Offset: 0x0003A180
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Path);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UiSno);
			}
			bool hasIsVisible = this.HasIsVisible;
			if (hasIsVisible)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsVisible);
			}
			bool hasShouldOverride = this.HasShouldOverride;
			if (hasShouldOverride)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ShouldOverride);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0003C034 File Offset: 0x0003A234
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Path);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool hasIsVisible = this.HasIsVisible;
			if (hasIsVisible)
			{
				num += 2;
			}
			bool hasShouldOverride = this.HasShouldOverride;
			if (hasShouldOverride)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		[DebuggerNonUserCode]
		public void MergeFrom(UIControlVisibility other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPath = other.HasPath;
				if (hasPath)
				{
					this.Path = other.Path;
				}
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				bool hasIsVisible = other.HasIsVisible;
				if (hasIsVisible)
				{
					this.IsVisible = other.IsVisible;
				}
				bool hasShouldOverride = other.HasShouldOverride;
				if (hasShouldOverride)
				{
					this.ShouldOverride = other.ShouldOverride;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0003C15A File Offset: 0x0003A35A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0003C168 File Offset: 0x0003A368
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0029;
						}
						this.UiSno = input.ReadInt32();
					}
					else
					{
						this.Path = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.ShouldOverride = input.ReadBool();
				}
				else
				{
					this.IsVisible = input.ReadBool();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000678 RID: 1656
		private static readonly MessageParser<UIControlVisibility> _parser = new MessageParser<UIControlVisibility>(() => new UIControlVisibility());

		// Token: 0x04000679 RID: 1657
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400067A RID: 1658
		private int _hasBits0;

		// Token: 0x0400067B RID: 1659
		public const int PathFieldNumber = 1;

		// Token: 0x0400067C RID: 1660
		private static readonly string PathDefaultValue = "";

		// Token: 0x0400067D RID: 1661
		private string path_;

		// Token: 0x0400067E RID: 1662
		public const int UiSnoFieldNumber = 2;

		// Token: 0x0400067F RID: 1663
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x04000680 RID: 1664
		private int uiSno_;

		// Token: 0x04000681 RID: 1665
		public const int IsVisibleFieldNumber = 3;

		// Token: 0x04000682 RID: 1666
		private static readonly bool IsVisibleDefaultValue = false;

		// Token: 0x04000683 RID: 1667
		private bool isVisible_;

		// Token: 0x04000684 RID: 1668
		public const int ShouldOverrideFieldNumber = 4;

		// Token: 0x04000685 RID: 1669
		private static readonly bool ShouldOverrideDefaultValue = false;

		// Token: 0x04000686 RID: 1670
		private bool shouldOverride_;
	}
}
