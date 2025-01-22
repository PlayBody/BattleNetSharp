using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000118 RID: 280
	public sealed class FontColorOverride : IMessage<FontColorOverride>, IMessage, IEquatable<FontColorOverride>, IDeepCloneable<FontColorOverride>, IBufferMessage
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0006125C File Offset: 0x0005F45C
		[DebuggerNonUserCode]
		public static MessageParser<FontColorOverride> Parser
		{
			get
			{
				return FontColorOverride._parser;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00061274 File Offset: 0x0005F474
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00061298 File Offset: 0x0005F498
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FontColorOverride.Descriptor;
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000612AF File Offset: 0x0005F4AF
		[DebuggerNonUserCode]
		public FontColorOverride()
		{
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000612B9 File Offset: 0x0005F4B9
		[DebuggerNonUserCode]
		public FontColorOverride(FontColorOverride other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.fontColorHash_ = other.fontColorHash_;
			this.uiColor_ = other.uiColor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000612F8 File Offset: 0x0005F4F8
		[DebuggerNonUserCode]
		public FontColorOverride Clone()
		{
			return new FontColorOverride(this);
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00061310 File Offset: 0x0005F510
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00061341 File Offset: 0x0005F541
		[DebuggerNonUserCode]
		public uint FontColorHash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint fontColorHashDefaultValue;
				if (flag)
				{
					fontColorHashDefaultValue = this.fontColorHash_;
				}
				else
				{
					fontColorHashDefaultValue = FontColorOverride.FontColorHashDefaultValue;
				}
				return fontColorHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fontColorHash_ = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0006135C File Offset: 0x0005F55C
		[DebuggerNonUserCode]
		public bool HasFontColorHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00061379 File Offset: 0x0005F579
		[DebuggerNonUserCode]
		public void ClearFontColorHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0006138C File Offset: 0x0005F58C
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x000613BD File Offset: 0x0005F5BD
		[DebuggerNonUserCode]
		public int UiColor
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int uiColorDefaultValue;
				if (flag)
				{
					uiColorDefaultValue = this.uiColor_;
				}
				else
				{
					uiColorDefaultValue = FontColorOverride.UiColorDefaultValue;
				}
				return uiColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.uiColor_ = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x000613D8 File Offset: 0x0005F5D8
		[DebuggerNonUserCode]
		public bool HasUiColor
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000613F5 File Offset: 0x0005F5F5
		[DebuggerNonUserCode]
		public void ClearUiColor()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00061408 File Offset: 0x0005F608
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FontColorOverride);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00061428 File Offset: 0x0005F628
		[DebuggerNonUserCode]
		public bool Equals(FontColorOverride other)
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
					bool flag4 = this.FontColorHash != other.FontColorHash;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UiColor != other.UiColor;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0006149C File Offset: 0x0005F69C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFontColorHash = this.HasFontColorHash;
			if (hasFontColorHash)
			{
				num ^= this.FontColorHash.GetHashCode();
			}
			bool hasUiColor = this.HasUiColor;
			if (hasUiColor)
			{
				num ^= this.UiColor.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0006150C File Offset: 0x0005F70C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00061524 File Offset: 0x0005F724
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00061530 File Offset: 0x0005F730
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFontColorHash = this.HasFontColorHash;
			if (hasFontColorHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FontColorHash);
			}
			bool hasUiColor = this.HasUiColor;
			if (hasUiColor)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.UiColor);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000615A0 File Offset: 0x0005F7A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFontColorHash = this.HasFontColorHash;
			if (hasFontColorHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FontColorHash);
			}
			bool hasUiColor = this.HasUiColor;
			if (hasUiColor)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00061600 File Offset: 0x0005F800
		[DebuggerNonUserCode]
		public void MergeFrom(FontColorOverride other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFontColorHash = other.HasFontColorHash;
				if (hasFontColorHash)
				{
					this.FontColorHash = other.FontColorHash;
				}
				bool hasUiColor = other.HasUiColor;
				if (hasUiColor)
				{
					this.UiColor = other.UiColor;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00061662 File Offset: 0x0005F862
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00061670 File Offset: 0x0005F870
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UiColor = input.ReadSFixed32();
					}
				}
				else
				{
					this.FontColorHash = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000AC2 RID: 2754
		private static readonly MessageParser<FontColorOverride> _parser = new MessageParser<FontColorOverride>(() => new FontColorOverride());

		// Token: 0x04000AC3 RID: 2755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AC4 RID: 2756
		private int _hasBits0;

		// Token: 0x04000AC5 RID: 2757
		public const int FontColorHashFieldNumber = 1;

		// Token: 0x04000AC6 RID: 2758
		private static readonly uint FontColorHashDefaultValue = 0U;

		// Token: 0x04000AC7 RID: 2759
		private uint fontColorHash_;

		// Token: 0x04000AC8 RID: 2760
		public const int UiColorFieldNumber = 2;

		// Token: 0x04000AC9 RID: 2761
		private static readonly int UiColorDefaultValue = 0;

		// Token: 0x04000ACA RID: 2762
		private int uiColor_;
	}
}
