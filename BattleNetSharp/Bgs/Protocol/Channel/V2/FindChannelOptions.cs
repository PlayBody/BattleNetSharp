using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068E RID: 1678
	public sealed class FindChannelOptions : IMessage<FindChannelOptions>, IMessage, IEquatable<FindChannelOptions>, IDeepCloneable<FindChannelOptions>, IBufferMessage
	{
		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x0025CD88 File Offset: 0x0025AF88
		[DebuggerNonUserCode]
		public static MessageParser<FindChannelOptions> Parser
		{
			get
			{
				return FindChannelOptions._parser;
			}
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x0025CDA0 File Offset: 0x0025AFA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x0025CDC4 File Offset: 0x0025AFC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindChannelOptions.Descriptor;
			}
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x0025CDDB File Offset: 0x0025AFDB
		[DebuggerNonUserCode]
		public FindChannelOptions()
		{
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x0025CDFC File Offset: 0x0025AFFC
		[DebuggerNonUserCode]
		public FindChannelOptions(FindChannelOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.identity_ = other.identity_;
			this.locale_ = other.locale_;
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this.reservation_ = other.reservation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x0025CE84 File Offset: 0x0025B084
		[DebuggerNonUserCode]
		public FindChannelOptions Clone()
		{
			return new FindChannelOptions(this);
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x0025CE9C File Offset: 0x0025B09C
		// (set) Token: 0x06009BA3 RID: 39843 RVA: 0x0025CEB4 File Offset: 0x0025B0B4
		[DebuggerNonUserCode]
		public UniqueChannelType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x0025CEC0 File Offset: 0x0025B0C0
		// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x0025CEE1 File Offset: 0x0025B0E1
		[DebuggerNonUserCode]
		public string Identity
		{
			get
			{
				return this.identity_ ?? FindChannelOptions.IdentityDefaultValue;
			}
			set
			{
				this.identity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x0025CEF8 File Offset: 0x0025B0F8
		[DebuggerNonUserCode]
		public bool HasIdentity
		{
			get
			{
				return this.identity_ != null;
			}
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x0025CF13 File Offset: 0x0025B113
		[DebuggerNonUserCode]
		public void ClearIdentity()
		{
			this.identity_ = null;
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x0025CF20 File Offset: 0x0025B120
		// (set) Token: 0x06009BA9 RID: 39849 RVA: 0x0025CF51 File Offset: 0x0025B151
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
					localeDefaultValue = FindChannelOptions.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.locale_ = value;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x0025CF6C File Offset: 0x0025B16C
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x0025CF89 File Offset: 0x0025B189
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x0025CF9C File Offset: 0x0025B19C
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x0025CFB4 File Offset: 0x0025B1B4
		[DebuggerNonUserCode]
		public RepeatedField<AccountId> Reservation
		{
			get
			{
				return this.reservation_;
			}
		}

		// Token: 0x06009BAE RID: 39854 RVA: 0x0025CFCC File Offset: 0x0025B1CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindChannelOptions);
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x0025CFEC File Offset: 0x0025B1EC
		[DebuggerNonUserCode]
		public bool Equals(FindChannelOptions other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Identity != other.Identity;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Locale != other.Locale;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.searchAttribute_.Equals(other.searchAttribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.reservation_.Equals(other.reservation_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x0025D164 File Offset: 0x0025B364
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x0025D17C File Offset: 0x0025B37C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x0025D188 File Offset: 0x0025B388
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Identity);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Locale);
			}
			this.searchAttribute_.WriteTo(ref output, FindChannelOptions._repeated_searchAttribute_codec);
			this.reservation_.WriteTo(ref output, FindChannelOptions._repeated_reservation_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x0025D240 File Offset: 0x0025B440
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
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
			num += this.searchAttribute_.CalculateSize(FindChannelOptions._repeated_searchAttribute_codec);
			num += this.reservation_.CalculateSize(FindChannelOptions._repeated_reservation_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x0025D2E8 File Offset: 0x0025B4E8
		[DebuggerNonUserCode]
		public void MergeFrom(FindChannelOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueChannelType();
					}
					this.Type.MergeFrom(other.Type);
				}
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

		// Token: 0x06009BB6 RID: 39862 RVA: 0x0025D3AF File Offset: 0x0025B5AF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x0025D3BC File Offset: 0x0025B5BC
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Identity = input.ReadString();
					}
					else
					{
						bool flag = this.type_ == null;
						if (flag)
						{
							this.Type = new UniqueChannelType();
						}
						input.ReadMessage(this.Type);
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 34U)
					{
						if (num3 != 50U)
						{
							goto IL_0033;
						}
						this.reservation_.AddEntriesFrom(ref input, FindChannelOptions._repeated_reservation_codec);
					}
					else
					{
						this.searchAttribute_.AddEntriesFrom(ref input, FindChannelOptions._repeated_searchAttribute_codec);
					}
				}
				else
				{
					this.Locale = input.ReadFixed32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400462E RID: 17966
		private static readonly MessageParser<FindChannelOptions> _parser = new MessageParser<FindChannelOptions>(() => new FindChannelOptions());

		// Token: 0x0400462F RID: 17967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004630 RID: 17968
		private int _hasBits0;

		// Token: 0x04004631 RID: 17969
		public const int TypeFieldNumber = 1;

		// Token: 0x04004632 RID: 17970
		private UniqueChannelType type_;

		// Token: 0x04004633 RID: 17971
		public const int IdentityFieldNumber = 2;

		// Token: 0x04004634 RID: 17972
		private static readonly string IdentityDefaultValue = "";

		// Token: 0x04004635 RID: 17973
		private string identity_;

		// Token: 0x04004636 RID: 17974
		public const int LocaleFieldNumber = 3;

		// Token: 0x04004637 RID: 17975
		private static readonly uint LocaleDefaultValue = 0U;

		// Token: 0x04004638 RID: 17976
		private uint locale_;

		// Token: 0x04004639 RID: 17977
		public const int SearchAttributeFieldNumber = 4;

		// Token: 0x0400463A RID: 17978
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400463B RID: 17979
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> searchAttribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x0400463C RID: 17980
		public const int ReservationFieldNumber = 6;

		// Token: 0x0400463D RID: 17981
		private static readonly FieldCodec<AccountId> _repeated_reservation_codec = FieldCodec.ForMessage<AccountId>(50U, AccountId.Parser);

		// Token: 0x0400463E RID: 17982
		private readonly RepeatedField<AccountId> reservation_ = new RepeatedField<AccountId>();
	}
}
