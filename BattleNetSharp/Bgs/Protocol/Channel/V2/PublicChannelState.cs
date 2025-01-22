using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000691 RID: 1681
	public sealed class PublicChannelState : IMessage<PublicChannelState>, IMessage, IEquatable<PublicChannelState>, IDeepCloneable<PublicChannelState>, IBufferMessage
	{
		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x0025DFAC File Offset: 0x0025C1AC
		[DebuggerNonUserCode]
		public static MessageParser<PublicChannelState> Parser
		{
			get
			{
				return PublicChannelState._parser;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x0025DFC4 File Offset: 0x0025C1C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x06009BED RID: 39917 RVA: 0x0025DFE8 File Offset: 0x0025C1E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicChannelState.Descriptor;
			}
		}

		// Token: 0x06009BEE RID: 39918 RVA: 0x0025DFFF File Offset: 0x0025C1FF
		[DebuggerNonUserCode]
		public PublicChannelState()
		{
		}

		// Token: 0x06009BEF RID: 39919 RVA: 0x0025E020 File Offset: 0x0025C220
		[DebuggerNonUserCode]
		public PublicChannelState(PublicChannelState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = other.identity_;
			this.locale_ = other.locale_;
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this.reservation_ = other.reservation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x0025E08C File Offset: 0x0025C28C
		[DebuggerNonUserCode]
		public PublicChannelState Clone()
		{
			return new PublicChannelState(this);
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x0025E0A4 File Offset: 0x0025C2A4
		// (set) Token: 0x06009BF2 RID: 39922 RVA: 0x0025E0C5 File Offset: 0x0025C2C5
		[DebuggerNonUserCode]
		public string Identity
		{
			get
			{
				return this.identity_ ?? PublicChannelState.IdentityDefaultValue;
			}
			set
			{
				this.identity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x06009BF3 RID: 39923 RVA: 0x0025E0DC File Offset: 0x0025C2DC
		[DebuggerNonUserCode]
		public bool HasIdentity
		{
			get
			{
				return this.identity_ != null;
			}
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x0025E0F7 File Offset: 0x0025C2F7
		[DebuggerNonUserCode]
		public void ClearIdentity()
		{
			this.identity_ = null;
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x06009BF5 RID: 39925 RVA: 0x0025E104 File Offset: 0x0025C304
		// (set) Token: 0x06009BF6 RID: 39926 RVA: 0x0025E135 File Offset: 0x0025C335
		[DebuggerNonUserCode]
		public uint Locale
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint localeDefaultValue;
				if (flag)
				{
					localeDefaultValue = this.locale_;
				}
				else
				{
					localeDefaultValue = PublicChannelState.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.locale_ = value;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x0025E150 File Offset: 0x0025C350
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009BF8 RID: 39928 RVA: 0x0025E16D File Offset: 0x0025C36D
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x0025E180 File Offset: 0x0025C380
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x0025E198 File Offset: 0x0025C398
		[DebuggerNonUserCode]
		public RepeatedField<AccountId> Reservation
		{
			get
			{
				return this.reservation_;
			}
		}

		// Token: 0x06009BFB RID: 39931 RVA: 0x0025E1B0 File Offset: 0x0025C3B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicChannelState);
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x0025E1D0 File Offset: 0x0025C3D0
		[DebuggerNonUserCode]
		public bool Equals(PublicChannelState other)
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
					bool flag4 = this.Identity != other.Identity;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Locale != other.Locale;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.searchAttribute_.Equals(other.searchAttribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.reservation_.Equals(other.reservation_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009BFD RID: 39933 RVA: 0x0025E284 File Offset: 0x0025C484
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			num ^= this.searchAttribute_.GetHashCode();
			num ^= this.reservation_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BFE RID: 39934 RVA: 0x0025E30C File Offset: 0x0025C50C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BFF RID: 39935 RVA: 0x0025E324 File Offset: 0x0025C524
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C00 RID: 39936 RVA: 0x0025E330 File Offset: 0x0025C530
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Identity);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Locale);
			}
			this.searchAttribute_.WriteTo(ref output, PublicChannelState._repeated_searchAttribute_codec);
			this.reservation_.WriteTo(ref output, PublicChannelState._repeated_reservation_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x0025E3C4 File Offset: 0x0025C5C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Identity);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 5;
			}
			num += this.searchAttribute_.CalculateSize(PublicChannelState._repeated_searchAttribute_codec);
			num += this.reservation_.CalculateSize(PublicChannelState._repeated_reservation_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x0025E44C File Offset: 0x0025C64C
		[DebuggerNonUserCode]
		public void MergeFrom(PublicChannelState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIdentity = other.HasIdentity;
				if (hasIdentity)
				{
					this.Identity = other.Identity;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				this.searchAttribute_.Add(other.searchAttribute_);
				this.reservation_.Add(other.reservation_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x0025E4D2 File Offset: 0x0025C6D2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x0025E4E0 File Offset: 0x0025C6E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_002C;
						}
						this.Locale = input.ReadFixed32();
					}
					else
					{
						this.Identity = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 50U)
					{
						goto IL_002C;
					}
					this.reservation_.AddEntriesFrom(ref input, PublicChannelState._repeated_reservation_codec);
				}
				else
				{
					this.searchAttribute_.AddEntriesFrom(ref input, PublicChannelState._repeated_searchAttribute_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004655 RID: 18005
		private static readonly MessageParser<PublicChannelState> _parser = new MessageParser<PublicChannelState>(() => new PublicChannelState());

		// Token: 0x04004656 RID: 18006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004657 RID: 18007
		private int _hasBits0;

		// Token: 0x04004658 RID: 18008
		public const int IdentityFieldNumber = 1;

		// Token: 0x04004659 RID: 18009
		private static readonly string IdentityDefaultValue = "";

		// Token: 0x0400465A RID: 18010
		private string identity_;

		// Token: 0x0400465B RID: 18011
		public const int LocaleFieldNumber = 2;

		// Token: 0x0400465C RID: 18012
		private static readonly uint LocaleDefaultValue = 0U;

		// Token: 0x0400465D RID: 18013
		private uint locale_;

		// Token: 0x0400465E RID: 18014
		public const int SearchAttributeFieldNumber = 3;

		// Token: 0x0400465F RID: 18015
		private static readonly FieldCodec<Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Attribute>(26U, Attribute.Parser);

		// Token: 0x04004660 RID: 18016
		private readonly RepeatedField<Attribute> searchAttribute_ = new RepeatedField<Attribute>();

		// Token: 0x04004661 RID: 18017
		public const int ReservationFieldNumber = 6;

		// Token: 0x04004662 RID: 18018
		private static readonly FieldCodec<AccountId> _repeated_reservation_codec = FieldCodec.ForMessage<AccountId>(50U, AccountId.Parser);

		// Token: 0x04004663 RID: 18019
		private readonly RepeatedField<AccountId> reservation_ = new RepeatedField<AccountId>();
	}
}
