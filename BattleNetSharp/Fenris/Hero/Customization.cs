using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000188 RID: 392
	public sealed class Customization : IMessage<Customization>, IMessage, IEquatable<Customization>, IDeepCloneable<Customization>, IBufferMessage
	{
		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000A0904 File Offset: 0x0009EB04
		[DebuggerNonUserCode]
		public static MessageParser<Customization> Parser
		{
			get
			{
				return Customization._parser;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x000A091C File Offset: 0x0009EB1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000A0940 File Offset: 0x0009EB40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Customization.Descriptor;
			}
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000A0957 File Offset: 0x0009EB57
		[DebuggerNonUserCode]
		public Customization()
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000A0978 File Offset: 0x0009EB78
		[DebuggerNonUserCode]
		public Customization(Customization other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoPotionButton_ = other.snoPotionButton_;
			this.socialWheelConfiguration_ = ((other.socialWheelConfiguration_ != null) ? other.socialWheelConfiguration_.Clone() : null);
			this.transmogSlot_ = other.transmogSlot_.Clone();
			this.savedTransmog_ = other.savedTransmog_.Clone();
			this.playerTitle_ = ((other.playerTitle_ != null) ? other.playerTitle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000A0A10 File Offset: 0x0009EC10
		[DebuggerNonUserCode]
		public Customization Clone()
		{
			return new Customization(this);
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000A0A28 File Offset: 0x0009EC28
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x000A0A59 File Offset: 0x0009EC59
		[DebuggerNonUserCode]
		public int SnoPotionButton
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoPotionButtonDefaultValue;
				if (flag)
				{
					snoPotionButtonDefaultValue = this.snoPotionButton_;
				}
				else
				{
					snoPotionButtonDefaultValue = Customization.SnoPotionButtonDefaultValue;
				}
				return snoPotionButtonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoPotionButton_ = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x000A0A74 File Offset: 0x0009EC74
		[DebuggerNonUserCode]
		public bool HasSnoPotionButton
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000A0A91 File Offset: 0x0009EC91
		[DebuggerNonUserCode]
		public void ClearSnoPotionButton()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x000A0AA4 File Offset: 0x0009ECA4
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x000A0ABC File Offset: 0x0009ECBC
		[DebuggerNonUserCode]
		public SocialWheelConfiguration SocialWheelConfiguration
		{
			get
			{
				return this.socialWheelConfiguration_;
			}
			set
			{
				this.socialWheelConfiguration_ = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x000A0AC8 File Offset: 0x0009ECC8
		[DebuggerNonUserCode]
		public RepeatedField<TransmogSlot> TransmogSlot
		{
			get
			{
				return this.transmogSlot_;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000A0AE0 File Offset: 0x0009ECE0
		[DebuggerNonUserCode]
		public RepeatedField<SavedTransmogs> SavedTransmog
		{
			get
			{
				return this.savedTransmog_;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x000A0AF8 File Offset: 0x0009ECF8
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x000A0B10 File Offset: 0x0009ED10
		[DebuggerNonUserCode]
		public PlayerTitle PlayerTitle
		{
			get
			{
				return this.playerTitle_;
			}
			set
			{
				this.playerTitle_ = value;
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000A0B1C File Offset: 0x0009ED1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Customization);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000A0B3C File Offset: 0x0009ED3C
		[DebuggerNonUserCode]
		public bool Equals(Customization other)
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
					bool flag4 = this.SnoPotionButton != other.SnoPotionButton;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SocialWheelConfiguration, other.SocialWheelConfiguration);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.transmogSlot_.Equals(other.transmogSlot_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.savedTransmog_.Equals(other.savedTransmog_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.PlayerTitle, other.PlayerTitle);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000A0C14 File Offset: 0x0009EE14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoPotionButton = this.HasSnoPotionButton;
			if (hasSnoPotionButton)
			{
				num ^= this.SnoPotionButton.GetHashCode();
			}
			bool flag = this.socialWheelConfiguration_ != null;
			if (flag)
			{
				num ^= this.SocialWheelConfiguration.GetHashCode();
			}
			num ^= this.transmogSlot_.GetHashCode();
			num ^= this.savedTransmog_.GetHashCode();
			bool flag2 = this.playerTitle_ != null;
			if (flag2)
			{
				num ^= this.PlayerTitle.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000A0CBC File Offset: 0x0009EEBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000A0CD4 File Offset: 0x0009EED4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000A0CE0 File Offset: 0x0009EEE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoPotionButton = this.HasSnoPotionButton;
			if (hasSnoPotionButton)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoPotionButton);
			}
			bool flag = this.socialWheelConfiguration_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SocialWheelConfiguration);
			}
			this.transmogSlot_.WriteTo(ref output, Customization._repeated_transmogSlot_codec);
			this.savedTransmog_.WriteTo(ref output, Customization._repeated_savedTransmog_codec);
			bool flag2 = this.playerTitle_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlayerTitle);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000A0D9C File Offset: 0x0009EF9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoPotionButton = this.HasSnoPotionButton;
			if (hasSnoPotionButton)
			{
				num += 5;
			}
			bool flag = this.socialWheelConfiguration_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SocialWheelConfiguration);
			}
			num += this.transmogSlot_.CalculateSize(Customization._repeated_transmogSlot_codec);
			num += this.savedTransmog_.CalculateSize(Customization._repeated_savedTransmog_codec);
			bool flag2 = this.playerTitle_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerTitle);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000A0E48 File Offset: 0x0009F048
		[DebuggerNonUserCode]
		public void MergeFrom(Customization other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoPotionButton = other.HasSnoPotionButton;
				if (hasSnoPotionButton)
				{
					this.SnoPotionButton = other.SnoPotionButton;
				}
				bool flag2 = other.socialWheelConfiguration_ != null;
				if (flag2)
				{
					bool flag3 = this.socialWheelConfiguration_ == null;
					if (flag3)
					{
						this.SocialWheelConfiguration = new SocialWheelConfiguration();
					}
					this.SocialWheelConfiguration.MergeFrom(other.SocialWheelConfiguration);
				}
				this.transmogSlot_.Add(other.transmogSlot_);
				this.savedTransmog_.Add(other.savedTransmog_);
				bool flag4 = other.playerTitle_ != null;
				if (flag4)
				{
					bool flag5 = this.playerTitle_ == null;
					if (flag5)
					{
						this.PlayerTitle = new PlayerTitle();
					}
					this.PlayerTitle.MergeFrom(other.PlayerTitle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000A0F34 File Offset: 0x0009F134
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000A0F40 File Offset: 0x0009F140
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 13U)
					{
						if (num3 != 18U)
						{
							goto IL_0036;
						}
						bool flag = this.socialWheelConfiguration_ == null;
						if (flag)
						{
							this.SocialWheelConfiguration = new SocialWheelConfiguration();
						}
						input.ReadMessage(this.SocialWheelConfiguration);
					}
					else
					{
						this.SnoPotionButton = input.ReadSFixed32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0036;
						}
						bool flag2 = this.playerTitle_ == null;
						if (flag2)
						{
							this.PlayerTitle = new PlayerTitle();
						}
						input.ReadMessage(this.PlayerTitle);
					}
					else
					{
						this.savedTransmog_.AddEntriesFrom(ref input, Customization._repeated_savedTransmog_codec);
					}
				}
				else
				{
					this.transmogSlot_.AddEntriesFrom(ref input, Customization._repeated_transmogSlot_codec);
				}
				continue;
				IL_0036:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001250 RID: 4688
		private static readonly MessageParser<Customization> _parser = new MessageParser<Customization>(() => new Customization());

		// Token: 0x04001251 RID: 4689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001252 RID: 4690
		private int _hasBits0;

		// Token: 0x04001253 RID: 4691
		public const int SnoPotionButtonFieldNumber = 1;

		// Token: 0x04001254 RID: 4692
		private static readonly int SnoPotionButtonDefaultValue = -1;

		// Token: 0x04001255 RID: 4693
		private int snoPotionButton_;

		// Token: 0x04001256 RID: 4694
		public const int SocialWheelConfigurationFieldNumber = 2;

		// Token: 0x04001257 RID: 4695
		private SocialWheelConfiguration socialWheelConfiguration_;

		// Token: 0x04001258 RID: 4696
		public const int TransmogSlotFieldNumber = 3;

		// Token: 0x04001259 RID: 4697
		private static readonly FieldCodec<TransmogSlot> _repeated_transmogSlot_codec = FieldCodec.ForMessage<TransmogSlot>(26U, Fenris.Hero.TransmogSlot.Parser);

		// Token: 0x0400125A RID: 4698
		private readonly RepeatedField<TransmogSlot> transmogSlot_ = new RepeatedField<TransmogSlot>();

		// Token: 0x0400125B RID: 4699
		public const int SavedTransmogFieldNumber = 4;

		// Token: 0x0400125C RID: 4700
		private static readonly FieldCodec<SavedTransmogs> _repeated_savedTransmog_codec = FieldCodec.ForMessage<SavedTransmogs>(34U, SavedTransmogs.Parser);

		// Token: 0x0400125D RID: 4701
		private readonly RepeatedField<SavedTransmogs> savedTransmog_ = new RepeatedField<SavedTransmogs>();

		// Token: 0x0400125E RID: 4702
		public const int PlayerTitleFieldNumber = 5;

		// Token: 0x0400125F RID: 4703
		private PlayerTitle playerTitle_;
	}
}
