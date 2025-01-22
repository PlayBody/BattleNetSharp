using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000227 RID: 551
	public sealed class ListHeroesResponse : IMessage<ListHeroesResponse>, IMessage, IEquatable<ListHeroesResponse>, IDeepCloneable<ListHeroesResponse>, IBufferMessage
	{
		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x000EE1A0 File Offset: 0x000EC3A0
		[DebuggerNonUserCode]
		public static MessageParser<ListHeroesResponse> Parser
		{
			get
			{
				return ListHeroesResponse._parser;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x000EE1B8 File Offset: 0x000EC3B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x000EE1DC File Offset: 0x000EC3DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListHeroesResponse.Descriptor;
			}
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x000EE1F3 File Offset: 0x000EC3F3
		[DebuggerNonUserCode]
		public ListHeroesResponse()
		{
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x000EE208 File Offset: 0x000EC408
		[DebuggerNonUserCode]
		public ListHeroesResponse(ListHeroesResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroes_ = other.heroes_.Clone();
			this.deletedHero_ = ((other.deletedHero_ != null) ? other.deletedHero_.Clone() : null);
			this.campaignSkipAllowed_ = other.campaignSkipAllowed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x000EE274 File Offset: 0x000EC474
		[DebuggerNonUserCode]
		public ListHeroesResponse Clone()
		{
			return new ListHeroesResponse(this);
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x000EE28C File Offset: 0x000EC48C
		[DebuggerNonUserCode]
		public RepeatedField<Digest> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x000EE2A4 File Offset: 0x000EC4A4
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x000EE2BC File Offset: 0x000EC4BC
		[DebuggerNonUserCode]
		public Digest DeletedHero
		{
			get
			{
				return this.deletedHero_;
			}
			set
			{
				this.deletedHero_ = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x000EE2C8 File Offset: 0x000EC4C8
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x000EE2F9 File Offset: 0x000EC4F9
		[DebuggerNonUserCode]
		public bool CampaignSkipAllowed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool campaignSkipAllowedDefaultValue;
				if (flag)
				{
					campaignSkipAllowedDefaultValue = this.campaignSkipAllowed_;
				}
				else
				{
					campaignSkipAllowedDefaultValue = ListHeroesResponse.CampaignSkipAllowedDefaultValue;
				}
				return campaignSkipAllowedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.campaignSkipAllowed_ = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x000EE314 File Offset: 0x000EC514
		[DebuggerNonUserCode]
		public bool HasCampaignSkipAllowed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000EE331 File Offset: 0x000EC531
		[DebuggerNonUserCode]
		public void ClearCampaignSkipAllowed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000EE344 File Offset: 0x000EC544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListHeroesResponse);
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000EE364 File Offset: 0x000EC564
		[DebuggerNonUserCode]
		public bool Equals(ListHeroesResponse other)
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
					bool flag4 = !this.heroes_.Equals(other.heroes_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.DeletedHero, other.DeletedHero);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CampaignSkipAllowed != other.CampaignSkipAllowed;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x000EE3F8 File Offset: 0x000EC5F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heroes_.GetHashCode();
			bool flag = this.deletedHero_ != null;
			if (flag)
			{
				num ^= this.DeletedHero.GetHashCode();
			}
			bool hasCampaignSkipAllowed = this.HasCampaignSkipAllowed;
			if (hasCampaignSkipAllowed)
			{
				num ^= this.CampaignSkipAllowed.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x000EE474 File Offset: 0x000EC674
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x000EE48C File Offset: 0x000EC68C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x000EE498 File Offset: 0x000EC698
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroes_.WriteTo(ref output, ListHeroesResponse._repeated_heroes_codec);
			bool flag = this.deletedHero_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DeletedHero);
			}
			bool hasCampaignSkipAllowed = this.HasCampaignSkipAllowed;
			if (hasCampaignSkipAllowed)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CampaignSkipAllowed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x000EE51C File Offset: 0x000EC71C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroes_.CalculateSize(ListHeroesResponse._repeated_heroes_codec);
			bool flag = this.deletedHero_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DeletedHero);
			}
			bool hasCampaignSkipAllowed = this.HasCampaignSkipAllowed;
			if (hasCampaignSkipAllowed)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x000EE594 File Offset: 0x000EC794
		[DebuggerNonUserCode]
		public void MergeFrom(ListHeroesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroes_.Add(other.heroes_);
				bool flag2 = other.deletedHero_ != null;
				if (flag2)
				{
					bool flag3 = this.deletedHero_ == null;
					if (flag3)
					{
						this.DeletedHero = new Digest();
					}
					this.DeletedHero.MergeFrom(other.DeletedHero);
				}
				bool hasCampaignSkipAllowed = other.HasCampaignSkipAllowed;
				if (hasCampaignSkipAllowed)
				{
					this.CampaignSkipAllowed = other.CampaignSkipAllowed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000EE62B File Offset: 0x000EC82B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x000EE638 File Offset: 0x000EC838
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CampaignSkipAllowed = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.deletedHero_ == null;
						if (flag)
						{
							this.DeletedHero = new Digest();
						}
						input.ReadMessage(this.DeletedHero);
					}
				}
				else
				{
					this.heroes_.AddEntriesFrom(ref input, ListHeroesResponse._repeated_heroes_codec);
				}
			}
		}

		// Token: 0x04001BBF RID: 7103
		private static readonly MessageParser<ListHeroesResponse> _parser = new MessageParser<ListHeroesResponse>(() => new ListHeroesResponse());

		// Token: 0x04001BC0 RID: 7104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BC1 RID: 7105
		private int _hasBits0;

		// Token: 0x04001BC2 RID: 7106
		public const int HeroesFieldNumber = 1;

		// Token: 0x04001BC3 RID: 7107
		private static readonly FieldCodec<Digest> _repeated_heroes_codec = FieldCodec.ForMessage<Digest>(10U, Digest.Parser);

		// Token: 0x04001BC4 RID: 7108
		private readonly RepeatedField<Digest> heroes_ = new RepeatedField<Digest>();

		// Token: 0x04001BC5 RID: 7109
		public const int DeletedHeroFieldNumber = 2;

		// Token: 0x04001BC6 RID: 7110
		private Digest deletedHero_;

		// Token: 0x04001BC7 RID: 7111
		public const int CampaignSkipAllowedFieldNumber = 3;

		// Token: 0x04001BC8 RID: 7112
		private static readonly bool CampaignSkipAllowedDefaultValue = false;

		// Token: 0x04001BC9 RID: 7113
		private bool campaignSkipAllowed_;
	}
}
