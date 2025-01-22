using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B2 RID: 178
	public sealed class UIEditorAdjustCanvas : IMessage<UIEditorAdjustCanvas>, IMessage, IEquatable<UIEditorAdjustCanvas>, IDeepCloneable<UIEditorAdjustCanvas>, IBufferMessage
	{
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0003D1A0 File Offset: 0x0003B3A0
		[DebuggerNonUserCode]
		public static MessageParser<UIEditorAdjustCanvas> Parser
		{
			get
			{
				return UIEditorAdjustCanvas._parser;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[155];
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIEditorAdjustCanvas.Descriptor;
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0003D1F7 File Offset: 0x0003B3F7
		[DebuggerNonUserCode]
		public UIEditorAdjustCanvas()
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0003D204 File Offset: 0x0003B404
		[DebuggerNonUserCode]
		public UIEditorAdjustCanvas(UIEditorAdjustCanvas other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.uiSno_ = other.uiSno_;
			this.zoomAmount_ = other.zoomAmount_;
			this.translate_ = ((other.translate_ != null) ? other.translate_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0003D26C File Offset: 0x0003B46C
		[DebuggerNonUserCode]
		public UIEditorAdjustCanvas Clone()
		{
			return new UIEditorAdjustCanvas(this);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0003D284 File Offset: 0x0003B484
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0003D2B5 File Offset: 0x0003B4B5
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
					uiSnoDefaultValue = UIEditorAdjustCanvas.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0003D2D0 File Offset: 0x0003B4D0
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0003D2ED File Offset: 0x0003B4ED
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0003D300 File Offset: 0x0003B500
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0003D331 File Offset: 0x0003B531
		[DebuggerNonUserCode]
		public float ZoomAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float zoomAmountDefaultValue;
				if (flag)
				{
					zoomAmountDefaultValue = this.zoomAmount_;
				}
				else
				{
					zoomAmountDefaultValue = UIEditorAdjustCanvas.ZoomAmountDefaultValue;
				}
				return zoomAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.zoomAmount_ = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0003D34C File Offset: 0x0003B54C
		[DebuggerNonUserCode]
		public bool HasZoomAmount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0003D369 File Offset: 0x0003B569
		[DebuggerNonUserCode]
		public void ClearZoomAmount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0003D37C File Offset: 0x0003B57C
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0003D394 File Offset: 0x0003B594
		[DebuggerNonUserCode]
		public Vector2 Translate
		{
			get
			{
				return this.translate_;
			}
			set
			{
				this.translate_ = value;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0003D3A0 File Offset: 0x0003B5A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIEditorAdjustCanvas);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		[DebuggerNonUserCode]
		public bool Equals(UIEditorAdjustCanvas other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ZoomAmount, other.ZoomAmount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Translate, other.Translate);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0003D458 File Offset: 0x0003B658
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool hasZoomAmount = this.HasZoomAmount;
			if (hasZoomAmount)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ZoomAmount);
			}
			bool flag = this.translate_ != null;
			if (flag)
			{
				num ^= this.Translate.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0003D508 File Offset: 0x0003B708
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UiSno);
			}
			bool hasZoomAmount = this.HasZoomAmount;
			if (hasZoomAmount)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.ZoomAmount);
			}
			bool flag = this.translate_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Translate);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0003D59C File Offset: 0x0003B79C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool hasZoomAmount = this.HasZoomAmount;
			if (hasZoomAmount)
			{
				num += 5;
			}
			bool flag = this.translate_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Translate);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0003D620 File Offset: 0x0003B820
		[DebuggerNonUserCode]
		public void MergeFrom(UIEditorAdjustCanvas other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				bool hasZoomAmount = other.HasZoomAmount;
				if (hasZoomAmount)
				{
					this.ZoomAmount = other.ZoomAmount;
				}
				bool flag2 = other.translate_ != null;
				if (flag2)
				{
					bool flag3 = this.translate_ == null;
					if (flag3)
					{
						this.Translate = new Vector2();
					}
					this.Translate.MergeFrom(other.Translate);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0003D6C3 File Offset: 0x0003B8C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0003D6D0 File Offset: 0x0003B8D0
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
					if (num3 != 21U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.translate_ == null;
							if (flag)
							{
								this.Translate = new Vector2();
							}
							input.ReadMessage(this.Translate);
						}
					}
					else
					{
						this.ZoomAmount = input.ReadFloat();
					}
				}
				else
				{
					this.UiSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x040006A5 RID: 1701
		private static readonly MessageParser<UIEditorAdjustCanvas> _parser = new MessageParser<UIEditorAdjustCanvas>(() => new UIEditorAdjustCanvas());

		// Token: 0x040006A6 RID: 1702
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006A7 RID: 1703
		private int _hasBits0;

		// Token: 0x040006A8 RID: 1704
		public const int UiSnoFieldNumber = 1;

		// Token: 0x040006A9 RID: 1705
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x040006AA RID: 1706
		private int uiSno_;

		// Token: 0x040006AB RID: 1707
		public const int ZoomAmountFieldNumber = 2;

		// Token: 0x040006AC RID: 1708
		private static readonly float ZoomAmountDefaultValue = 0f;

		// Token: 0x040006AD RID: 1709
		private float zoomAmount_;

		// Token: 0x040006AE RID: 1710
		public const int TranslateFieldNumber = 3;

		// Token: 0x040006AF RID: 1711
		private Vector2 translate_;
	}
}
