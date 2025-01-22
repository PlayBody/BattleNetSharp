using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008A RID: 138
	public sealed class AxeDebugRenderStateChanged : IMessage<AxeDebugRenderStateChanged>, IMessage, IEquatable<AxeDebugRenderStateChanged>, IDeepCloneable<AxeDebugRenderStateChanged>, IBufferMessage
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000300A8 File Offset: 0x0002E2A8
		[DebuggerNonUserCode]
		public static MessageParser<AxeDebugRenderStateChanged> Parser
		{
			get
			{
				return AxeDebugRenderStateChanged._parser;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000300C0 File Offset: 0x0002E2C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[115];
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000300E4 File Offset: 0x0002E2E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxeDebugRenderStateChanged.Descriptor;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000300FB File Offset: 0x0002E2FB
		[DebuggerNonUserCode]
		public AxeDebugRenderStateChanged()
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00030108 File Offset: 0x0002E308
		[DebuggerNonUserCode]
		public AxeDebugRenderStateChanged(AxeDebugRenderStateChanged other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.debugRenderMode_ = other.debugRenderMode_;
			this.drawFlags_ = other.drawFlags_;
			this.hideRenderLayer_ = other.hideRenderLayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00030160 File Offset: 0x0002E360
		[DebuggerNonUserCode]
		public AxeDebugRenderStateChanged Clone()
		{
			return new AxeDebugRenderStateChanged(this);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00030178 File Offset: 0x0002E378
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x000301A9 File Offset: 0x0002E3A9
		[DebuggerNonUserCode]
		public int DebugRenderMode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int debugRenderModeDefaultValue;
				if (flag)
				{
					debugRenderModeDefaultValue = this.debugRenderMode_;
				}
				else
				{
					debugRenderModeDefaultValue = AxeDebugRenderStateChanged.DebugRenderModeDefaultValue;
				}
				return debugRenderModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.debugRenderMode_ = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000301C4 File Offset: 0x0002E3C4
		[DebuggerNonUserCode]
		public bool HasDebugRenderMode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000301E1 File Offset: 0x0002E3E1
		[DebuggerNonUserCode]
		public void ClearDebugRenderMode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000301F4 File Offset: 0x0002E3F4
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00030215 File Offset: 0x0002E415
		[DebuggerNonUserCode]
		public ByteString DrawFlags
		{
			get
			{
				return this.drawFlags_ ?? AxeDebugRenderStateChanged.DrawFlagsDefaultValue;
			}
			set
			{
				this.drawFlags_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0003022C File Offset: 0x0002E42C
		[DebuggerNonUserCode]
		public bool HasDrawFlags
		{
			get
			{
				return this.drawFlags_ != null;
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0003024A File Offset: 0x0002E44A
		[DebuggerNonUserCode]
		public void ClearDrawFlags()
		{
			this.drawFlags_ = null;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00030254 File Offset: 0x0002E454
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00030275 File Offset: 0x0002E475
		[DebuggerNonUserCode]
		public ByteString HideRenderLayer
		{
			get
			{
				return this.hideRenderLayer_ ?? AxeDebugRenderStateChanged.HideRenderLayerDefaultValue;
			}
			set
			{
				this.hideRenderLayer_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0003028C File Offset: 0x0002E48C
		[DebuggerNonUserCode]
		public bool HasHideRenderLayer
		{
			get
			{
				return this.hideRenderLayer_ != null;
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000302AA File Offset: 0x0002E4AA
		[DebuggerNonUserCode]
		public void ClearHideRenderLayer()
		{
			this.hideRenderLayer_ = null;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000302B4 File Offset: 0x0002E4B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxeDebugRenderStateChanged);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000302D4 File Offset: 0x0002E4D4
		[DebuggerNonUserCode]
		public bool Equals(AxeDebugRenderStateChanged other)
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
					bool flag4 = this.DebugRenderMode != other.DebugRenderMode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DrawFlags != other.DrawFlags;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HideRenderLayer != other.HideRenderLayer;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00030360 File Offset: 0x0002E560
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDebugRenderMode = this.HasDebugRenderMode;
			if (hasDebugRenderMode)
			{
				num ^= this.DebugRenderMode.GetHashCode();
			}
			bool hasDrawFlags = this.HasDrawFlags;
			if (hasDrawFlags)
			{
				num ^= this.DrawFlags.GetHashCode();
			}
			bool hasHideRenderLayer = this.HasHideRenderLayer;
			if (hasHideRenderLayer)
			{
				num ^= this.HideRenderLayer.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000303E4 File Offset: 0x0002E5E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000303FC File Offset: 0x0002E5FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00030408 File Offset: 0x0002E608
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDebugRenderMode = this.HasDebugRenderMode;
			if (hasDebugRenderMode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DebugRenderMode);
			}
			bool hasDrawFlags = this.HasDrawFlags;
			if (hasDrawFlags)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.DrawFlags);
			}
			bool hasHideRenderLayer = this.HasHideRenderLayer;
			if (hasHideRenderLayer)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.HideRenderLayer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00030498 File Offset: 0x0002E698
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDebugRenderMode = this.HasDebugRenderMode;
			if (hasDebugRenderMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DebugRenderMode);
			}
			bool hasDrawFlags = this.HasDrawFlags;
			if (hasDrawFlags)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.DrawFlags);
			}
			bool hasHideRenderLayer = this.HasHideRenderLayer;
			if (hasHideRenderLayer)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.HideRenderLayer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00030524 File Offset: 0x0002E724
		[DebuggerNonUserCode]
		public void MergeFrom(AxeDebugRenderStateChanged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDebugRenderMode = other.HasDebugRenderMode;
				if (hasDebugRenderMode)
				{
					this.DebugRenderMode = other.DebugRenderMode;
				}
				bool hasDrawFlags = other.HasDrawFlags;
				if (hasDrawFlags)
				{
					this.DrawFlags = other.DrawFlags;
				}
				bool hasHideRenderLayer = other.HasHideRenderLayer;
				if (hasHideRenderLayer)
				{
					this.HideRenderLayer = other.HideRenderLayer;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003059F File Offset: 0x0002E79F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000305AC File Offset: 0x0002E7AC
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HideRenderLayer = input.ReadBytes();
						}
					}
					else
					{
						this.DrawFlags = input.ReadBytes();
					}
				}
				else
				{
					this.DebugRenderMode = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000512 RID: 1298
		private static readonly MessageParser<AxeDebugRenderStateChanged> _parser = new MessageParser<AxeDebugRenderStateChanged>(() => new AxeDebugRenderStateChanged());

		// Token: 0x04000513 RID: 1299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000514 RID: 1300
		private int _hasBits0;

		// Token: 0x04000515 RID: 1301
		public const int DebugRenderModeFieldNumber = 1;

		// Token: 0x04000516 RID: 1302
		private static readonly int DebugRenderModeDefaultValue = 0;

		// Token: 0x04000517 RID: 1303
		private int debugRenderMode_;

		// Token: 0x04000518 RID: 1304
		public const int DrawFlagsFieldNumber = 2;

		// Token: 0x04000519 RID: 1305
		private static readonly ByteString DrawFlagsDefaultValue = ByteString.Empty;

		// Token: 0x0400051A RID: 1306
		private ByteString drawFlags_;

		// Token: 0x0400051B RID: 1307
		public const int HideRenderLayerFieldNumber = 3;

		// Token: 0x0400051C RID: 1308
		private static readonly ByteString HideRenderLayerDefaultValue = ByteString.Empty;

		// Token: 0x0400051D RID: 1309
		private ByteString hideRenderLayer_;
	}
}
