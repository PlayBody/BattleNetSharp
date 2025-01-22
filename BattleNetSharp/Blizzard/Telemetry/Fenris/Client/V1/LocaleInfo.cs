using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000308 RID: 776
	public sealed class LocaleInfo : IMessage<LocaleInfo>, IMessage, IEquatable<LocaleInfo>, IDeepCloneable<LocaleInfo>, IBufferMessage
	{
		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06005240 RID: 21056 RVA: 0x0013DDFC File Offset: 0x0013BFFC
		[DebuggerNonUserCode]
		public static MessageParser<LocaleInfo> Parser
		{
			get
			{
				return LocaleInfo._parser;
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x0013DE14 File Offset: 0x0013C014
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LocaleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x0013DE38 File Offset: 0x0013C038
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LocaleInfo.Descriptor;
			}
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0013DE4F File Offset: 0x0013C04F
		[DebuggerNonUserCode]
		public LocaleInfo()
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x0013DE5C File Offset: 0x0013C05C
		[DebuggerNonUserCode]
		public LocaleInfo(LocaleInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.baseLocale_ = other.baseLocale_;
			this.textLocale_ = other.textLocale_;
			this.speechLocale_ = other.speechLocale_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0013DEB4 File Offset: 0x0013C0B4
		[DebuggerNonUserCode]
		public LocaleInfo Clone()
		{
			return new LocaleInfo(this);
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x0013DECC File Offset: 0x0013C0CC
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x0013DEFD File Offset: 0x0013C0FD
		[DebuggerNonUserCode]
		public int BaseLocale
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int baseLocaleDefaultValue;
				if (flag)
				{
					baseLocaleDefaultValue = this.baseLocale_;
				}
				else
				{
					baseLocaleDefaultValue = LocaleInfo.BaseLocaleDefaultValue;
				}
				return baseLocaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.baseLocale_ = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x0013DF18 File Offset: 0x0013C118
		[DebuggerNonUserCode]
		public bool HasBaseLocale
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0013DF35 File Offset: 0x0013C135
		[DebuggerNonUserCode]
		public void ClearBaseLocale()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x0013DF48 File Offset: 0x0013C148
		// (set) Token: 0x0600524B RID: 21067 RVA: 0x0013DF79 File Offset: 0x0013C179
		[DebuggerNonUserCode]
		public int TextLocale
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int textLocaleDefaultValue;
				if (flag)
				{
					textLocaleDefaultValue = this.textLocale_;
				}
				else
				{
					textLocaleDefaultValue = LocaleInfo.TextLocaleDefaultValue;
				}
				return textLocaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.textLocale_ = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x0013DF94 File Offset: 0x0013C194
		[DebuggerNonUserCode]
		public bool HasTextLocale
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0013DFB1 File Offset: 0x0013C1B1
		[DebuggerNonUserCode]
		public void ClearTextLocale()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x0013DFC4 File Offset: 0x0013C1C4
		// (set) Token: 0x0600524F RID: 21071 RVA: 0x0013DFF5 File Offset: 0x0013C1F5
		[DebuggerNonUserCode]
		public int SpeechLocale
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int speechLocaleDefaultValue;
				if (flag)
				{
					speechLocaleDefaultValue = this.speechLocale_;
				}
				else
				{
					speechLocaleDefaultValue = LocaleInfo.SpeechLocaleDefaultValue;
				}
				return speechLocaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.speechLocale_ = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x0013E010 File Offset: 0x0013C210
		[DebuggerNonUserCode]
		public bool HasSpeechLocale
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0013E02D File Offset: 0x0013C22D
		[DebuggerNonUserCode]
		public void ClearSpeechLocale()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0013E040 File Offset: 0x0013C240
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LocaleInfo);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x0013E060 File Offset: 0x0013C260
		[DebuggerNonUserCode]
		public bool Equals(LocaleInfo other)
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
					bool flag4 = this.BaseLocale != other.BaseLocale;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TextLocale != other.TextLocale;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SpeechLocale != other.SpeechLocale;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x0013E0EC File Offset: 0x0013C2EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBaseLocale = this.HasBaseLocale;
			if (hasBaseLocale)
			{
				num ^= this.BaseLocale.GetHashCode();
			}
			bool hasTextLocale = this.HasTextLocale;
			if (hasTextLocale)
			{
				num ^= this.TextLocale.GetHashCode();
			}
			bool hasSpeechLocale = this.HasSpeechLocale;
			if (hasSpeechLocale)
			{
				num ^= this.SpeechLocale.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0013E178 File Offset: 0x0013C378
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0013E190 File Offset: 0x0013C390
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0013E19C File Offset: 0x0013C39C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBaseLocale = this.HasBaseLocale;
			if (hasBaseLocale)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BaseLocale);
			}
			bool hasTextLocale = this.HasTextLocale;
			if (hasTextLocale)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TextLocale);
			}
			bool hasSpeechLocale = this.HasSpeechLocale;
			if (hasSpeechLocale)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpeechLocale);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x0013E22C File Offset: 0x0013C42C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBaseLocale = this.HasBaseLocale;
			if (hasBaseLocale)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseLocale);
			}
			bool hasTextLocale = this.HasTextLocale;
			if (hasTextLocale)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TextLocale);
			}
			bool hasSpeechLocale = this.HasSpeechLocale;
			if (hasSpeechLocale)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpeechLocale);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0013E2B8 File Offset: 0x0013C4B8
		[DebuggerNonUserCode]
		public void MergeFrom(LocaleInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBaseLocale = other.HasBaseLocale;
				if (hasBaseLocale)
				{
					this.BaseLocale = other.BaseLocale;
				}
				bool hasTextLocale = other.HasTextLocale;
				if (hasTextLocale)
				{
					this.TextLocale = other.TextLocale;
				}
				bool hasSpeechLocale = other.HasSpeechLocale;
				if (hasSpeechLocale)
				{
					this.SpeechLocale = other.SpeechLocale;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0013E333 File Offset: 0x0013C533
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x0013E340 File Offset: 0x0013C540
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SpeechLocale = input.ReadInt32();
						}
					}
					else
					{
						this.TextLocale = input.ReadInt32();
					}
				}
				else
				{
					this.BaseLocale = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400255C RID: 9564
		private static readonly MessageParser<LocaleInfo> _parser = new MessageParser<LocaleInfo>(() => new LocaleInfo());

		// Token: 0x0400255D RID: 9565
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400255E RID: 9566
		private int _hasBits0;

		// Token: 0x0400255F RID: 9567
		public const int BaseLocaleFieldNumber = 1;

		// Token: 0x04002560 RID: 9568
		private static readonly int BaseLocaleDefaultValue = 0;

		// Token: 0x04002561 RID: 9569
		private int baseLocale_;

		// Token: 0x04002562 RID: 9570
		public const int TextLocaleFieldNumber = 2;

		// Token: 0x04002563 RID: 9571
		private static readonly int TextLocaleDefaultValue = 0;

		// Token: 0x04002564 RID: 9572
		private int textLocale_;

		// Token: 0x04002565 RID: 9573
		public const int SpeechLocaleFieldNumber = 3;

		// Token: 0x04002566 RID: 9574
		private static readonly int SpeechLocaleDefaultValue = 0;

		// Token: 0x04002567 RID: 9575
		private int speechLocale_;
	}
}
