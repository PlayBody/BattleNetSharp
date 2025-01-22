using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000026 RID: 38
	public sealed class ToggleFullscreen : IMessage<ToggleFullscreen>, IMessage, IEquatable<ToggleFullscreen>, IDeepCloneable<ToggleFullscreen>, IBufferMessage
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000E108 File Offset: 0x0000C308
		[DebuggerNonUserCode]
		public static MessageParser<ToggleFullscreen> Parser
		{
			get
			{
				return ToggleFullscreen._parser;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000E120 File Offset: 0x0000C320
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000E144 File Offset: 0x0000C344
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToggleFullscreen.Descriptor;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000E15B File Offset: 0x0000C35B
		[DebuggerNonUserCode]
		public ToggleFullscreen()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000E165 File Offset: 0x0000C365
		[DebuggerNonUserCode]
		public ToggleFullscreen(ToggleFullscreen other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.fullscreen_ = other.fullscreen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000E198 File Offset: 0x0000C398
		[DebuggerNonUserCode]
		public ToggleFullscreen Clone()
		{
			return new ToggleFullscreen(this);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000E1E1 File Offset: 0x0000C3E1
		[DebuggerNonUserCode]
		public bool Fullscreen
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool fullscreenDefaultValue;
				if (flag)
				{
					fullscreenDefaultValue = this.fullscreen_;
				}
				else
				{
					fullscreenDefaultValue = ToggleFullscreen.FullscreenDefaultValue;
				}
				return fullscreenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fullscreen_ = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		[DebuggerNonUserCode]
		public bool HasFullscreen
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000E219 File Offset: 0x0000C419
		[DebuggerNonUserCode]
		public void ClearFullscreen()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000E22C File Offset: 0x0000C42C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToggleFullscreen);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000E24C File Offset: 0x0000C44C
		[DebuggerNonUserCode]
		public bool Equals(ToggleFullscreen other)
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
					bool flag4 = this.Fullscreen != other.Fullscreen;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFullscreen = this.HasFullscreen;
			if (hasFullscreen)
			{
				num ^= this.Fullscreen.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000E30C File Offset: 0x0000C50C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000E318 File Offset: 0x0000C518
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFullscreen = this.HasFullscreen;
			if (hasFullscreen)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Fullscreen);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000E364 File Offset: 0x0000C564
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFullscreen = this.HasFullscreen;
			if (hasFullscreen)
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

		// Token: 0x0600022D RID: 557 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		[DebuggerNonUserCode]
		public void MergeFrom(ToggleFullscreen other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFullscreen = other.HasFullscreen;
				if (hasFullscreen)
				{
					this.Fullscreen = other.Fullscreen;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000E3F1 File Offset: 0x0000C5F1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000E3FC File Offset: 0x0000C5FC
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
					this.Fullscreen = input.ReadBool();
				}
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly MessageParser<ToggleFullscreen> _parser = new MessageParser<ToggleFullscreen>(() => new ToggleFullscreen());

		// Token: 0x040000E3 RID: 227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000E4 RID: 228
		private int _hasBits0;

		// Token: 0x040000E5 RID: 229
		public const int FullscreenFieldNumber = 1;

		// Token: 0x040000E6 RID: 230
		private static readonly bool FullscreenDefaultValue = false;

		// Token: 0x040000E7 RID: 231
		private bool fullscreen_;
	}
}
