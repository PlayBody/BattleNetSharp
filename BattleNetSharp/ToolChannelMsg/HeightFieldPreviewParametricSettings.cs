using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DC RID: 220
	public sealed class HeightFieldPreviewParametricSettings : IMessage<HeightFieldPreviewParametricSettings>, IMessage, IEquatable<HeightFieldPreviewParametricSettings>, IDeepCloneable<HeightFieldPreviewParametricSettings>, IBufferMessage
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
		[DebuggerNonUserCode]
		public static MessageParser<HeightFieldPreviewParametricSettings> Parser
		{
			get
			{
				return HeightFieldPreviewParametricSettings._parser;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[197];
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0004E3E8 File Offset: 0x0004C5E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeightFieldPreviewParametricSettings.Descriptor;
			}
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0004E3FF File Offset: 0x0004C5FF
		[DebuggerNonUserCode]
		public HeightFieldPreviewParametricSettings()
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0004E40C File Offset: 0x0004C60C
		[DebuggerNonUserCode]
		public HeightFieldPreviewParametricSettings(HeightFieldPreviewParametricSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.preview_ = other.preview_;
			this.parametricSettings_ = ((other.parametricSettings_ != null) ? other.parametricSettings_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0004E468 File Offset: 0x0004C668
		[DebuggerNonUserCode]
		public HeightFieldPreviewParametricSettings Clone()
		{
			return new HeightFieldPreviewParametricSettings(this);
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0004E480 File Offset: 0x0004C680
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0004E4B1 File Offset: 0x0004C6B1
		[DebuggerNonUserCode]
		public bool Preview
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool previewDefaultValue;
				if (flag)
				{
					previewDefaultValue = this.preview_;
				}
				else
				{
					previewDefaultValue = HeightFieldPreviewParametricSettings.PreviewDefaultValue;
				}
				return previewDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.preview_ = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0004E4CC File Offset: 0x0004C6CC
		[DebuggerNonUserCode]
		public bool HasPreview
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0004E4E9 File Offset: 0x0004C6E9
		[DebuggerNonUserCode]
		public void ClearPreview()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0004E4FC File Offset: 0x0004C6FC
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0004E514 File Offset: 0x0004C714
		[DebuggerNonUserCode]
		public ParametricSettings ParametricSettings
		{
			get
			{
				return this.parametricSettings_;
			}
			set
			{
				this.parametricSettings_ = value;
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0004E520 File Offset: 0x0004C720
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeightFieldPreviewParametricSettings);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0004E540 File Offset: 0x0004C740
		[DebuggerNonUserCode]
		public bool Equals(HeightFieldPreviewParametricSettings other)
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
					bool flag4 = this.Preview != other.Preview;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ParametricSettings, other.ParametricSettings);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0004E5B4 File Offset: 0x0004C7B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPreview = this.HasPreview;
			if (hasPreview)
			{
				num ^= this.Preview.GetHashCode();
			}
			bool flag = this.parametricSettings_ != null;
			if (flag)
			{
				num ^= this.ParametricSettings.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0004E620 File Offset: 0x0004C820
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0004E638 File Offset: 0x0004C838
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0004E644 File Offset: 0x0004C844
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPreview = this.HasPreview;
			if (hasPreview)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Preview);
			}
			bool flag = this.parametricSettings_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ParametricSettings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0004E6B4 File Offset: 0x0004C8B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPreview = this.HasPreview;
			if (hasPreview)
			{
				num += 2;
			}
			bool flag = this.parametricSettings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParametricSettings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0004E718 File Offset: 0x0004C918
		[DebuggerNonUserCode]
		public void MergeFrom(HeightFieldPreviewParametricSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPreview = other.HasPreview;
				if (hasPreview)
				{
					this.Preview = other.Preview;
				}
				bool flag2 = other.parametricSettings_ != null;
				if (flag2)
				{
					bool flag3 = this.parametricSettings_ == null;
					if (flag3)
					{
						this.ParametricSettings = new ParametricSettings();
					}
					this.ParametricSettings.MergeFrom(other.ParametricSettings);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0004E79D File Offset: 0x0004C99D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0004E7A8 File Offset: 0x0004C9A8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.parametricSettings_ == null;
						if (flag)
						{
							this.ParametricSettings = new ParametricSettings();
						}
						input.ReadMessage(this.ParametricSettings);
					}
				}
				else
				{
					this.Preview = input.ReadBool();
				}
			}
		}

		// Token: 0x040008BE RID: 2238
		private static readonly MessageParser<HeightFieldPreviewParametricSettings> _parser = new MessageParser<HeightFieldPreviewParametricSettings>(() => new HeightFieldPreviewParametricSettings());

		// Token: 0x040008BF RID: 2239
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008C0 RID: 2240
		private int _hasBits0;

		// Token: 0x040008C1 RID: 2241
		public const int PreviewFieldNumber = 1;

		// Token: 0x040008C2 RID: 2242
		private static readonly bool PreviewDefaultValue = false;

		// Token: 0x040008C3 RID: 2243
		private bool preview_;

		// Token: 0x040008C4 RID: 2244
		public const int ParametricSettingsFieldNumber = 2;

		// Token: 0x040008C5 RID: 2245
		private ParametricSettings parametricSettings_;
	}
}
