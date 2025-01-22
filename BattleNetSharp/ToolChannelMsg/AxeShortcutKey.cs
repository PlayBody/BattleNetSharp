using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008F RID: 143
	public sealed class AxeShortcutKey : IMessage<AxeShortcutKey>, IMessage, IEquatable<AxeShortcutKey>, IDeepCloneable<AxeShortcutKey>, IBufferMessage
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000314C4 File Offset: 0x0002F6C4
		[DebuggerNonUserCode]
		public static MessageParser<AxeShortcutKey> Parser
		{
			get
			{
				return AxeShortcutKey._parser;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000314DC File Offset: 0x0002F6DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[120];
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00031500 File Offset: 0x0002F700
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxeShortcutKey.Descriptor;
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00031517 File Offset: 0x0002F717
		[DebuggerNonUserCode]
		public AxeShortcutKey()
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00031524 File Offset: 0x0002F724
		[DebuggerNonUserCode]
		public AxeShortcutKey(AxeShortcutKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = other.key_;
			this.modifiers_ = other.modifiers_;
			this.keyAlt_ = other.keyAlt_;
			this.modifiersAlt_ = other.modifiersAlt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00031588 File Offset: 0x0002F788
		[DebuggerNonUserCode]
		public AxeShortcutKey Clone()
		{
			return new AxeShortcutKey(this);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x000315A0 File Offset: 0x0002F7A0
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x000315D1 File Offset: 0x0002F7D1
		[DebuggerNonUserCode]
		public int Key
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int keyDefaultValue;
				if (flag)
				{
					keyDefaultValue = this.key_;
				}
				else
				{
					keyDefaultValue = AxeShortcutKey.KeyDefaultValue;
				}
				return keyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.key_ = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000315EC File Offset: 0x0002F7EC
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00031609 File Offset: 0x0002F809
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0003161C File Offset: 0x0002F81C
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0003164D File Offset: 0x0002F84D
		[DebuggerNonUserCode]
		public uint Modifiers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint modifiersDefaultValue;
				if (flag)
				{
					modifiersDefaultValue = this.modifiers_;
				}
				else
				{
					modifiersDefaultValue = AxeShortcutKey.ModifiersDefaultValue;
				}
				return modifiersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.modifiers_ = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00031668 File Offset: 0x0002F868
		[DebuggerNonUserCode]
		public bool HasModifiers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00031685 File Offset: 0x0002F885
		[DebuggerNonUserCode]
		public void ClearModifiers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00031698 File Offset: 0x0002F898
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000316C9 File Offset: 0x0002F8C9
		[DebuggerNonUserCode]
		public int KeyAlt
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int keyAltDefaultValue;
				if (flag)
				{
					keyAltDefaultValue = this.keyAlt_;
				}
				else
				{
					keyAltDefaultValue = AxeShortcutKey.KeyAltDefaultValue;
				}
				return keyAltDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.keyAlt_ = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000316E4 File Offset: 0x0002F8E4
		[DebuggerNonUserCode]
		public bool HasKeyAlt
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00031701 File Offset: 0x0002F901
		[DebuggerNonUserCode]
		public void ClearKeyAlt()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00031714 File Offset: 0x0002F914
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00031745 File Offset: 0x0002F945
		[DebuggerNonUserCode]
		public uint ModifiersAlt
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint modifiersAltDefaultValue;
				if (flag)
				{
					modifiersAltDefaultValue = this.modifiersAlt_;
				}
				else
				{
					modifiersAltDefaultValue = AxeShortcutKey.ModifiersAltDefaultValue;
				}
				return modifiersAltDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.modifiersAlt_ = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00031760 File Offset: 0x0002F960
		[DebuggerNonUserCode]
		public bool HasModifiersAlt
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0003177D File Offset: 0x0002F97D
		[DebuggerNonUserCode]
		public void ClearModifiersAlt()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00031790 File Offset: 0x0002F990
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxeShortcutKey);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000317B0 File Offset: 0x0002F9B0
		[DebuggerNonUserCode]
		public bool Equals(AxeShortcutKey other)
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
					bool flag4 = this.Key != other.Key;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Modifiers != other.Modifiers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.KeyAlt != other.KeyAlt;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ModifiersAlt != other.ModifiersAlt;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0003185C File Offset: 0x0002FA5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				num ^= this.Modifiers.GetHashCode();
			}
			bool hasKeyAlt = this.HasKeyAlt;
			if (hasKeyAlt)
			{
				num ^= this.KeyAlt.GetHashCode();
			}
			bool hasModifiersAlt = this.HasModifiersAlt;
			if (hasModifiersAlt)
			{
				num ^= this.ModifiersAlt.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00031904 File Offset: 0x0002FB04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0003191C File Offset: 0x0002FB1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00031928 File Offset: 0x0002FB28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Modifiers);
			}
			bool hasKeyAlt = this.HasKeyAlt;
			if (hasKeyAlt)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.KeyAlt);
			}
			bool hasModifiersAlt = this.HasModifiersAlt;
			if (hasModifiersAlt)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ModifiersAlt);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000319DC File Offset: 0x0002FBDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Modifiers);
			}
			bool hasKeyAlt = this.HasKeyAlt;
			if (hasKeyAlt)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeyAlt);
			}
			bool hasModifiersAlt = this.HasModifiersAlt;
			if (hasModifiersAlt)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ModifiersAlt);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00031A84 File Offset: 0x0002FC84
		[DebuggerNonUserCode]
		public void MergeFrom(AxeShortcutKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasModifiers = other.HasModifiers;
				if (hasModifiers)
				{
					this.Modifiers = other.Modifiers;
				}
				bool hasKeyAlt = other.HasKeyAlt;
				if (hasKeyAlt)
				{
					this.KeyAlt = other.KeyAlt;
				}
				bool hasModifiersAlt = other.HasModifiersAlt;
				if (hasModifiersAlt)
				{
					this.ModifiersAlt = other.ModifiersAlt;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00031B1A File Offset: 0x0002FD1A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00031B28 File Offset: 0x0002FD28
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
						this.Modifiers = input.ReadUInt32();
					}
					else
					{
						this.Key = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ModifiersAlt = input.ReadUInt32();
				}
				else
				{
					this.KeyAlt = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000537 RID: 1335
		private static readonly MessageParser<AxeShortcutKey> _parser = new MessageParser<AxeShortcutKey>(() => new AxeShortcutKey());

		// Token: 0x04000538 RID: 1336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000539 RID: 1337
		private int _hasBits0;

		// Token: 0x0400053A RID: 1338
		public const int KeyFieldNumber = 1;

		// Token: 0x0400053B RID: 1339
		private static readonly int KeyDefaultValue = 0;

		// Token: 0x0400053C RID: 1340
		private int key_;

		// Token: 0x0400053D RID: 1341
		public const int ModifiersFieldNumber = 2;

		// Token: 0x0400053E RID: 1342
		private static readonly uint ModifiersDefaultValue = 0U;

		// Token: 0x0400053F RID: 1343
		private uint modifiers_;

		// Token: 0x04000540 RID: 1344
		public const int KeyAltFieldNumber = 3;

		// Token: 0x04000541 RID: 1345
		private static readonly int KeyAltDefaultValue = 0;

		// Token: 0x04000542 RID: 1346
		private int keyAlt_;

		// Token: 0x04000543 RID: 1347
		public const int ModifiersAltFieldNumber = 4;

		// Token: 0x04000544 RID: 1348
		private static readonly uint ModifiersAltDefaultValue = 0U;

		// Token: 0x04000545 RID: 1349
		private uint modifiersAlt_;
	}
}
