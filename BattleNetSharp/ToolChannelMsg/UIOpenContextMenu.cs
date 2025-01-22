using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B1 RID: 177
	public sealed class UIOpenContextMenu : IMessage<UIOpenContextMenu>, IMessage, IEquatable<UIOpenContextMenu>, IDeepCloneable<UIOpenContextMenu>, IBufferMessage
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0003CE28 File Offset: 0x0003B028
		[DebuggerNonUserCode]
		public static MessageParser<UIOpenContextMenu> Parser
		{
			get
			{
				return UIOpenContextMenu._parser;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0003CE40 File Offset: 0x0003B040
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[154];
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0003CE68 File Offset: 0x0003B068
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIOpenContextMenu.Descriptor;
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0003CE7F File Offset: 0x0003B07F
		[DebuggerNonUserCode]
		public UIOpenContextMenu()
		{
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0003CE89 File Offset: 0x0003B089
		[DebuggerNonUserCode]
		public UIOpenContextMenu(UIOpenContextMenu other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.uiSno_ = other.uiSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0003CEBC File Offset: 0x0003B0BC
		[DebuggerNonUserCode]
		public UIOpenContextMenu Clone()
		{
			return new UIOpenContextMenu(this);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x0003CF05 File Offset: 0x0003B105
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
					uiSnoDefaultValue = UIOpenContextMenu.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x0003CF20 File Offset: 0x0003B120
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0003CF3D File Offset: 0x0003B13D
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0003CF50 File Offset: 0x0003B150
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIOpenContextMenu);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0003CF70 File Offset: 0x0003B170
		[DebuggerNonUserCode]
		public bool Equals(UIOpenContextMenu other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0003D018 File Offset: 0x0003B218
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0003D030 File Offset: 0x0003B230
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0003D03C File Offset: 0x0003B23C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UiSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0003D088 File Offset: 0x0003B288
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0003D0D8 File Offset: 0x0003B2D8
		[DebuggerNonUserCode]
		public void MergeFrom(UIOpenContextMenu other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0003D121 File Offset: 0x0003B321
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0003D12C File Offset: 0x0003B32C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.UiSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400069F RID: 1695
		private static readonly MessageParser<UIOpenContextMenu> _parser = new MessageParser<UIOpenContextMenu>(() => new UIOpenContextMenu());

		// Token: 0x040006A0 RID: 1696
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006A1 RID: 1697
		private int _hasBits0;

		// Token: 0x040006A2 RID: 1698
		public const int UiSnoFieldNumber = 1;

		// Token: 0x040006A3 RID: 1699
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x040006A4 RID: 1700
		private int uiSno_;
	}
}
