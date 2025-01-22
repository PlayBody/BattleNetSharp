using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x0200011E RID: 286
	public sealed class ClanDocument : IMessage<ClanDocument>, IMessage, IEquatable<ClanDocument>, IDeepCloneable<ClanDocument>, IBufferMessage
	{
		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0006B3A8 File Offset: 0x000695A8
		[DebuggerNonUserCode]
		public static MessageParser<ClanDocument> Parser
		{
			get
			{
				return ClanDocument._parser;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0006B3C0 File Offset: 0x000695C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0006B3E4 File Offset: 0x000695E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanDocument.Descriptor;
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0006B3FB File Offset: 0x000695FB
		[DebuggerNonUserCode]
		public ClanDocument()
		{
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0006B410 File Offset: 0x00069610
		[DebuggerNonUserCode]
		public ClanDocument(ClanDocument other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.name_ = other.name_;
			this.lastEditedNameBnetAccount_ = other.lastEditedNameBnetAccount_;
			this.lastEditedNameGameAccount_ = other.lastEditedNameGameAccount_;
			this.tag_ = other.tag_;
			this.lastEditedTagBnetAccount_ = other.lastEditedTagBnetAccount_;
			this.lastEditedTagGameAccount_ = other.lastEditedTagGameAccount_;
			this.description_ = other.description_;
			this.lastEditedDescriptionBnetAccount_ = other.lastEditedDescriptionBnetAccount_;
			this.lastEditedDescriptionGameAccount_ = other.lastEditedDescriptionGameAccount_;
			this.createdAt_ = other.createdAt_;
			this.leader_ = ((other.leader_ != null) ? other.leader_.Clone() : null);
			this.memberCount_ = other.memberCount_;
			this.label_ = other.label_.Clone();
			this.isSearchable_ = other.isSearchable_;
			this.heraldry_ = ((other.heraldry_ != null) ? other.heraldry_.Clone() : null);
			this.lastEditedHeraldryBnetAccount_ = other.lastEditedHeraldryBnetAccount_;
			this.lastEditedHeraldryGameAccount_ = other.lastEditedHeraldryGameAccount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0006B540 File Offset: 0x00069740
		[DebuggerNonUserCode]
		public ClanDocument Clone()
		{
			return new ClanDocument(this);
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0006B558 File Offset: 0x00069758
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0006B579 File Offset: 0x00069779
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanDocument.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0006B590 File Offset: 0x00069790
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0006B5AB File Offset: 0x000697AB
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0006B5B8 File Offset: 0x000697B8
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0006B5D9 File Offset: 0x000697D9
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClanDocument.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0006B5F0 File Offset: 0x000697F0
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0006B60B File Offset: 0x0006980B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0006B618 File Offset: 0x00069818
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0006B64D File Offset: 0x0006984D
		[DebuggerNonUserCode]
		public uint LastEditedNameBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint lastEditedNameBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedNameBnetAccountDefaultValue = this.lastEditedNameBnetAccount_;
				}
				else
				{
					lastEditedNameBnetAccountDefaultValue = ClanDocument.LastEditedNameBnetAccountDefaultValue;
				}
				return lastEditedNameBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.lastEditedNameBnetAccount_ = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0006B66C File Offset: 0x0006986C
		[DebuggerNonUserCode]
		public bool HasLastEditedNameBnetAccount
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0006B68D File Offset: 0x0006988D
		[DebuggerNonUserCode]
		public void ClearLastEditedNameBnetAccount()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0006B6A4 File Offset: 0x000698A4
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0006B6D9 File Offset: 0x000698D9
		[DebuggerNonUserCode]
		public uint LastEditedNameGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint lastEditedNameGameAccountDefaultValue;
				if (flag)
				{
					lastEditedNameGameAccountDefaultValue = this.lastEditedNameGameAccount_;
				}
				else
				{
					lastEditedNameGameAccountDefaultValue = ClanDocument.LastEditedNameGameAccountDefaultValue;
				}
				return lastEditedNameGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.lastEditedNameGameAccount_ = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0006B6F8 File Offset: 0x000698F8
		[DebuggerNonUserCode]
		public bool HasLastEditedNameGameAccount
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0006B719 File Offset: 0x00069919
		[DebuggerNonUserCode]
		public void ClearLastEditedNameGameAccount()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0006B730 File Offset: 0x00069930
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0006B751 File Offset: 0x00069951
		[DebuggerNonUserCode]
		public string Tag
		{
			get
			{
				return this.tag_ ?? ClanDocument.TagDefaultValue;
			}
			set
			{
				this.tag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0006B768 File Offset: 0x00069968
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return this.tag_ != null;
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0006B783 File Offset: 0x00069983
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this.tag_ = null;
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0006B790 File Offset: 0x00069990
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0006B7C5 File Offset: 0x000699C5
		[DebuggerNonUserCode]
		public uint LastEditedTagBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint lastEditedTagBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedTagBnetAccountDefaultValue = this.lastEditedTagBnetAccount_;
				}
				else
				{
					lastEditedTagBnetAccountDefaultValue = ClanDocument.LastEditedTagBnetAccountDefaultValue;
				}
				return lastEditedTagBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.lastEditedTagBnetAccount_ = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0006B7E4 File Offset: 0x000699E4
		[DebuggerNonUserCode]
		public bool HasLastEditedTagBnetAccount
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0006B805 File Offset: 0x00069A05
		[DebuggerNonUserCode]
		public void ClearLastEditedTagBnetAccount()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0006B81C File Offset: 0x00069A1C
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0006B851 File Offset: 0x00069A51
		[DebuggerNonUserCode]
		public uint LastEditedTagGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint lastEditedTagGameAccountDefaultValue;
				if (flag)
				{
					lastEditedTagGameAccountDefaultValue = this.lastEditedTagGameAccount_;
				}
				else
				{
					lastEditedTagGameAccountDefaultValue = ClanDocument.LastEditedTagGameAccountDefaultValue;
				}
				return lastEditedTagGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.lastEditedTagGameAccount_ = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0006B870 File Offset: 0x00069A70
		[DebuggerNonUserCode]
		public bool HasLastEditedTagGameAccount
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0006B891 File Offset: 0x00069A91
		[DebuggerNonUserCode]
		public void ClearLastEditedTagGameAccount()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0006B8A8 File Offset: 0x00069AA8
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x0006B8C9 File Offset: 0x00069AC9
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClanDocument.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0006B8E0 File Offset: 0x00069AE0
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0006B8FB File Offset: 0x00069AFB
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0006B908 File Offset: 0x00069B08
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0006B93A File Offset: 0x00069B3A
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint lastEditedDescriptionBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionBnetAccountDefaultValue = this.lastEditedDescriptionBnetAccount_;
				}
				else
				{
					lastEditedDescriptionBnetAccountDefaultValue = ClanDocument.LastEditedDescriptionBnetAccountDefaultValue;
				}
				return lastEditedDescriptionBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.lastEditedDescriptionBnetAccount_ = value;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0006B954 File Offset: 0x00069B54
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionBnetAccount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0006B972 File Offset: 0x00069B72
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionBnetAccount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0006B984 File Offset: 0x00069B84
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0006B9B6 File Offset: 0x00069BB6
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint lastEditedDescriptionGameAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionGameAccountDefaultValue = this.lastEditedDescriptionGameAccount_;
				}
				else
				{
					lastEditedDescriptionGameAccountDefaultValue = ClanDocument.LastEditedDescriptionGameAccountDefaultValue;
				}
				return lastEditedDescriptionGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.lastEditedDescriptionGameAccount_ = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0006B9D0 File Offset: 0x00069BD0
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionGameAccount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0006B9EE File Offset: 0x00069BEE
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionGameAccount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x0006BA00 File Offset: 0x00069C00
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0006BA31 File Offset: 0x00069C31
		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong createdAtDefaultValue;
				if (flag)
				{
					createdAtDefaultValue = this.createdAt_;
				}
				else
				{
					createdAtDefaultValue = ClanDocument.CreatedAtDefaultValue;
				}
				return createdAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.createdAt_ = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0006BA4C File Offset: 0x00069C4C
		[DebuggerNonUserCode]
		public bool HasCreatedAt
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0006BA69 File Offset: 0x00069C69
		[DebuggerNonUserCode]
		public void ClearCreatedAt()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0006BA7C File Offset: 0x00069C7C
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0006BA94 File Offset: 0x00069C94
		[DebuggerNonUserCode]
		public ClanProfile.Types.Member Leader
		{
			get
			{
				return this.leader_;
			}
			set
			{
				this.leader_ = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0006BAA0 File Offset: 0x00069CA0
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0006BAD1 File Offset: 0x00069CD1
		[DebuggerNonUserCode]
		public uint MemberCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint memberCountDefaultValue;
				if (flag)
				{
					memberCountDefaultValue = this.memberCount_;
				}
				else
				{
					memberCountDefaultValue = ClanDocument.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.memberCount_ = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0006BAEC File Offset: 0x00069CEC
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0006BB09 File Offset: 0x00069D09
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0006BB1C File Offset: 0x00069D1C
		[DebuggerNonUserCode]
		public RepeatedField<uint> Label
		{
			get
			{
				return this.label_;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0006BB34 File Offset: 0x00069D34
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0006BB65 File Offset: 0x00069D65
		[DebuggerNonUserCode]
		public bool IsSearchable
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isSearchableDefaultValue;
				if (flag)
				{
					isSearchableDefaultValue = this.isSearchable_;
				}
				else
				{
					isSearchableDefaultValue = ClanDocument.IsSearchableDefaultValue;
				}
				return isSearchableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isSearchable_ = value;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0006BB80 File Offset: 0x00069D80
		[DebuggerNonUserCode]
		public bool HasIsSearchable
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0006BB9D File Offset: 0x00069D9D
		[DebuggerNonUserCode]
		public void ClearIsSearchable()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0006BBC8 File Offset: 0x00069DC8
		[DebuggerNonUserCode]
		public ClanHeraldry Heraldry
		{
			get
			{
				return this.heraldry_;
			}
			set
			{
				this.heraldry_ = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0006BBD4 File Offset: 0x00069DD4
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0006BC05 File Offset: 0x00069E05
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint lastEditedHeraldryBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryBnetAccountDefaultValue = this.lastEditedHeraldryBnetAccount_;
				}
				else
				{
					lastEditedHeraldryBnetAccountDefaultValue = ClanDocument.LastEditedHeraldryBnetAccountDefaultValue;
				}
				return lastEditedHeraldryBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.lastEditedHeraldryBnetAccount_ = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0006BC20 File Offset: 0x00069E20
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryBnetAccount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0006BC3D File Offset: 0x00069E3D
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryBnetAccount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0006BC50 File Offset: 0x00069E50
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0006BC82 File Offset: 0x00069E82
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint lastEditedHeraldryGameAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryGameAccountDefaultValue = this.lastEditedHeraldryGameAccount_;
				}
				else
				{
					lastEditedHeraldryGameAccountDefaultValue = ClanDocument.LastEditedHeraldryGameAccountDefaultValue;
				}
				return lastEditedHeraldryGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lastEditedHeraldryGameAccount_ = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0006BC9C File Offset: 0x00069E9C
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryGameAccount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0006BCBA File Offset: 0x00069EBA
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryGameAccount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0006BCCC File Offset: 0x00069ECC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanDocument);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0006BCEC File Offset: 0x00069EEC
		[DebuggerNonUserCode]
		public bool Equals(ClanDocument other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastEditedNameBnetAccount != other.LastEditedNameBnetAccount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.LastEditedNameGameAccount != other.LastEditedNameGameAccount;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Tag != other.Tag;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.LastEditedTagBnetAccount != other.LastEditedTagBnetAccount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.LastEditedTagGameAccount != other.LastEditedTagGameAccount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Description != other.Description;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LastEditedDescriptionBnetAccount != other.LastEditedDescriptionBnetAccount;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.LastEditedDescriptionGameAccount != other.LastEditedDescriptionGameAccount;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CreatedAt != other.CreatedAt;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.Leader, other.Leader);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.MemberCount != other.MemberCount;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.label_.Equals(other.label_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.IsSearchable != other.IsSearchable;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !object.Equals(this.Heraldry, other.Heraldry);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.LastEditedHeraldryBnetAccount != other.LastEditedHeraldryBnetAccount;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.LastEditedHeraldryGameAccount != other.LastEditedHeraldryGameAccount;
																						flag2 = !flag21 && object.Equals(this._unknownFields, other._unknownFields);
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0006BF48 File Offset: 0x0006A148
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				num ^= this.LastEditedNameBnetAccount.GetHashCode();
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				num ^= this.LastEditedNameGameAccount.GetHashCode();
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num ^= this.Tag.GetHashCode();
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				num ^= this.LastEditedTagBnetAccount.GetHashCode();
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				num ^= this.LastEditedTagGameAccount.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				num ^= this.LastEditedDescriptionBnetAccount.GetHashCode();
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				num ^= this.LastEditedDescriptionGameAccount.GetHashCode();
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num ^= this.CreatedAt.GetHashCode();
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				num ^= this.Leader.GetHashCode();
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num ^= this.MemberCount.GetHashCode();
			}
			num ^= this.label_.GetHashCode();
			bool hasIsSearchable = this.HasIsSearchable;
			if (hasIsSearchable)
			{
				num ^= this.IsSearchable.GetHashCode();
			}
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				num ^= this.Heraldry.GetHashCode();
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				num ^= this.LastEditedHeraldryBnetAccount.GetHashCode();
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				num ^= this.LastEditedHeraldryGameAccount.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0006C174 File Offset: 0x0006A374
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0006C18C File Offset: 0x0006A38C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0006C198 File Offset: 0x0006A398
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Tag);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Description);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreatedAt);
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Leader);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MemberCount);
			}
			this.label_.WriteTo(ref output, ClanDocument._repeated_label_codec);
			bool hasIsSearchable = this.HasIsSearchable;
			if (hasIsSearchable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsSearchable);
			}
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Heraldry);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LastEditedHeraldryGameAccount);
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LastEditedDescriptionGameAccount);
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LastEditedNameBnetAccount);
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.LastEditedNameGameAccount);
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.LastEditedTagBnetAccount);
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.LastEditedTagGameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0006C444 File Offset: 0x0006A644
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedNameBnetAccount);
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedNameGameAccount);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Tag);
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedTagBnetAccount);
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedTagGameAccount);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionGameAccount);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Leader);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MemberCount);
			}
			num += this.label_.CalculateSize(ClanDocument._repeated_label_codec);
			bool hasIsSearchable = this.HasIsSearchable;
			if (hasIsSearchable)
			{
				num += 2;
			}
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heraldry);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryGameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0006C680 File Offset: 0x0006A880
		[DebuggerNonUserCode]
		public void MergeFrom(ClanDocument other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasLastEditedNameBnetAccount = other.HasLastEditedNameBnetAccount;
				if (hasLastEditedNameBnetAccount)
				{
					this.LastEditedNameBnetAccount = other.LastEditedNameBnetAccount;
				}
				bool hasLastEditedNameGameAccount = other.HasLastEditedNameGameAccount;
				if (hasLastEditedNameGameAccount)
				{
					this.LastEditedNameGameAccount = other.LastEditedNameGameAccount;
				}
				bool hasTag = other.HasTag;
				if (hasTag)
				{
					this.Tag = other.Tag;
				}
				bool hasLastEditedTagBnetAccount = other.HasLastEditedTagBnetAccount;
				if (hasLastEditedTagBnetAccount)
				{
					this.LastEditedTagBnetAccount = other.LastEditedTagBnetAccount;
				}
				bool hasLastEditedTagGameAccount = other.HasLastEditedTagGameAccount;
				if (hasLastEditedTagGameAccount)
				{
					this.LastEditedTagGameAccount = other.LastEditedTagGameAccount;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool hasLastEditedDescriptionBnetAccount = other.HasLastEditedDescriptionBnetAccount;
				if (hasLastEditedDescriptionBnetAccount)
				{
					this.LastEditedDescriptionBnetAccount = other.LastEditedDescriptionBnetAccount;
				}
				bool hasLastEditedDescriptionGameAccount = other.HasLastEditedDescriptionGameAccount;
				if (hasLastEditedDescriptionGameAccount)
				{
					this.LastEditedDescriptionGameAccount = other.LastEditedDescriptionGameAccount;
				}
				bool hasCreatedAt = other.HasCreatedAt;
				if (hasCreatedAt)
				{
					this.CreatedAt = other.CreatedAt;
				}
				bool flag2 = other.leader_ != null;
				if (flag2)
				{
					bool flag3 = this.leader_ == null;
					if (flag3)
					{
						this.Leader = new ClanProfile.Types.Member();
					}
					this.Leader.MergeFrom(other.Leader);
				}
				bool hasMemberCount = other.HasMemberCount;
				if (hasMemberCount)
				{
					this.MemberCount = other.MemberCount;
				}
				this.label_.Add(other.label_);
				bool hasIsSearchable = other.HasIsSearchable;
				if (hasIsSearchable)
				{
					this.IsSearchable = other.IsSearchable;
				}
				bool flag4 = other.heraldry_ != null;
				if (flag4)
				{
					bool flag5 = this.heraldry_ == null;
					if (flag5)
					{
						this.Heraldry = new ClanHeraldry();
					}
					this.Heraldry.MergeFrom(other.Heraldry);
				}
				bool hasLastEditedHeraldryBnetAccount = other.HasLastEditedHeraldryBnetAccount;
				if (hasLastEditedHeraldryBnetAccount)
				{
					this.LastEditedHeraldryBnetAccount = other.LastEditedHeraldryBnetAccount;
				}
				bool hasLastEditedHeraldryGameAccount = other.HasLastEditedHeraldryGameAccount;
				if (hasLastEditedHeraldryGameAccount)
				{
					this.LastEditedHeraldryGameAccount = other.LastEditedHeraldryGameAccount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0006C8D4 File Offset: 0x0006AAD4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0006C8E0 File Offset: 0x0006AAE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 66U)
				{
					if (num3 <= 34U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									goto IL_00FE;
								}
								this.Name = input.ReadString();
							}
							else
							{
								this.ClanId = input.ReadString();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								goto IL_00FE;
							}
							this.Description = input.ReadString();
						}
						else
						{
							this.Tag = input.ReadString();
						}
					}
					else if (num3 <= 50U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_00FE;
							}
							bool flag = this.leader_ == null;
							if (flag)
							{
								this.Leader = new ClanProfile.Types.Member();
							}
							input.ReadMessage(this.Leader);
						}
						else
						{
							this.CreatedAt = input.ReadUInt64();
						}
					}
					else if (num3 != 56U)
					{
						if (num3 != 64U && num3 != 66U)
						{
							goto IL_00FE;
						}
						this.label_.AddEntriesFrom(ref input, ClanDocument._repeated_label_codec);
					}
					else
					{
						this.MemberCount = input.ReadUInt32();
					}
				}
				else if (num3 <= 104U)
				{
					if (num3 <= 82U)
					{
						if (num3 != 72U)
						{
							if (num3 != 82U)
							{
								goto IL_00FE;
							}
							bool flag2 = this.heraldry_ == null;
							if (flag2)
							{
								this.Heraldry = new ClanHeraldry();
							}
							input.ReadMessage(this.Heraldry);
						}
						else
						{
							this.IsSearchable = input.ReadBool();
						}
					}
					else if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							if (num3 != 104U)
							{
								goto IL_00FE;
							}
							this.LastEditedDescriptionBnetAccount = input.ReadUInt32();
						}
						else
						{
							this.LastEditedHeraldryGameAccount = input.ReadUInt32();
						}
					}
					else
					{
						this.LastEditedHeraldryBnetAccount = input.ReadUInt32();
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 != 112U)
					{
						if (num3 != 120U)
						{
							goto IL_00FE;
						}
						this.LastEditedNameBnetAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedDescriptionGameAccount = input.ReadUInt32();
					}
				}
				else if (num3 != 128U)
				{
					if (num3 != 136U)
					{
						if (num3 != 144U)
						{
							goto IL_00FE;
						}
						this.LastEditedTagGameAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedTagBnetAccount = input.ReadUInt32();
					}
				}
				else
				{
					this.LastEditedNameGameAccount = input.ReadUInt32();
				}
				continue;
				IL_00FE:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BE1 RID: 3041
		private static readonly MessageParser<ClanDocument> _parser = new MessageParser<ClanDocument>(() => new ClanDocument());

		// Token: 0x04000BE2 RID: 3042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BE3 RID: 3043
		private int _hasBits0;

		// Token: 0x04000BE4 RID: 3044
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04000BE5 RID: 3045
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04000BE6 RID: 3046
		private string clanId_;

		// Token: 0x04000BE7 RID: 3047
		public const int NameFieldNumber = 2;

		// Token: 0x04000BE8 RID: 3048
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000BE9 RID: 3049
		private string name_;

		// Token: 0x04000BEA RID: 3050
		public const int LastEditedNameBnetAccountFieldNumber = 15;

		// Token: 0x04000BEB RID: 3051
		private static readonly uint LastEditedNameBnetAccountDefaultValue = 0U;

		// Token: 0x04000BEC RID: 3052
		private uint lastEditedNameBnetAccount_;

		// Token: 0x04000BED RID: 3053
		public const int LastEditedNameGameAccountFieldNumber = 16;

		// Token: 0x04000BEE RID: 3054
		private static readonly uint LastEditedNameGameAccountDefaultValue = 0U;

		// Token: 0x04000BEF RID: 3055
		private uint lastEditedNameGameAccount_;

		// Token: 0x04000BF0 RID: 3056
		public const int TagFieldNumber = 3;

		// Token: 0x04000BF1 RID: 3057
		private static readonly string TagDefaultValue = "";

		// Token: 0x04000BF2 RID: 3058
		private string tag_;

		// Token: 0x04000BF3 RID: 3059
		public const int LastEditedTagBnetAccountFieldNumber = 17;

		// Token: 0x04000BF4 RID: 3060
		private static readonly uint LastEditedTagBnetAccountDefaultValue = 0U;

		// Token: 0x04000BF5 RID: 3061
		private uint lastEditedTagBnetAccount_;

		// Token: 0x04000BF6 RID: 3062
		public const int LastEditedTagGameAccountFieldNumber = 18;

		// Token: 0x04000BF7 RID: 3063
		private static readonly uint LastEditedTagGameAccountDefaultValue = 0U;

		// Token: 0x04000BF8 RID: 3064
		private uint lastEditedTagGameAccount_;

		// Token: 0x04000BF9 RID: 3065
		public const int DescriptionFieldNumber = 4;

		// Token: 0x04000BFA RID: 3066
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04000BFB RID: 3067
		private string description_;

		// Token: 0x04000BFC RID: 3068
		public const int LastEditedDescriptionBnetAccountFieldNumber = 13;

		// Token: 0x04000BFD RID: 3069
		private static readonly uint LastEditedDescriptionBnetAccountDefaultValue = 0U;

		// Token: 0x04000BFE RID: 3070
		private uint lastEditedDescriptionBnetAccount_;

		// Token: 0x04000BFF RID: 3071
		public const int LastEditedDescriptionGameAccountFieldNumber = 14;

		// Token: 0x04000C00 RID: 3072
		private static readonly uint LastEditedDescriptionGameAccountDefaultValue = 0U;

		// Token: 0x04000C01 RID: 3073
		private uint lastEditedDescriptionGameAccount_;

		// Token: 0x04000C02 RID: 3074
		public const int CreatedAtFieldNumber = 5;

		// Token: 0x04000C03 RID: 3075
		private static readonly ulong CreatedAtDefaultValue = 0UL;

		// Token: 0x04000C04 RID: 3076
		private ulong createdAt_;

		// Token: 0x04000C05 RID: 3077
		public const int LeaderFieldNumber = 6;

		// Token: 0x04000C06 RID: 3078
		private ClanProfile.Types.Member leader_;

		// Token: 0x04000C07 RID: 3079
		public const int MemberCountFieldNumber = 7;

		// Token: 0x04000C08 RID: 3080
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x04000C09 RID: 3081
		private uint memberCount_;

		// Token: 0x04000C0A RID: 3082
		public const int LabelFieldNumber = 8;

		// Token: 0x04000C0B RID: 3083
		private static readonly FieldCodec<uint> _repeated_label_codec = FieldCodec.ForUInt32(64U);

		// Token: 0x04000C0C RID: 3084
		private readonly RepeatedField<uint> label_ = new RepeatedField<uint>();

		// Token: 0x04000C0D RID: 3085
		public const int IsSearchableFieldNumber = 9;

		// Token: 0x04000C0E RID: 3086
		private static readonly bool IsSearchableDefaultValue = false;

		// Token: 0x04000C0F RID: 3087
		private bool isSearchable_;

		// Token: 0x04000C10 RID: 3088
		public const int HeraldryFieldNumber = 10;

		// Token: 0x04000C11 RID: 3089
		private ClanHeraldry heraldry_;

		// Token: 0x04000C12 RID: 3090
		public const int LastEditedHeraldryBnetAccountFieldNumber = 11;

		// Token: 0x04000C13 RID: 3091
		private static readonly uint LastEditedHeraldryBnetAccountDefaultValue = 0U;

		// Token: 0x04000C14 RID: 3092
		private uint lastEditedHeraldryBnetAccount_;

		// Token: 0x04000C15 RID: 3093
		public const int LastEditedHeraldryGameAccountFieldNumber = 12;

		// Token: 0x04000C16 RID: 3094
		private static readonly uint LastEditedHeraldryGameAccountDefaultValue = 0U;

		// Token: 0x04000C17 RID: 3095
		private uint lastEditedHeraldryGameAccount_;
	}
}
