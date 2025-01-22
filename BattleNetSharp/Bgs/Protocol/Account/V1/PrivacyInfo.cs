using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073F RID: 1855
	public sealed class PrivacyInfo : IMessage<PrivacyInfo>, IMessage, IEquatable<PrivacyInfo>, IDeepCloneable<PrivacyInfo>, IBufferMessage
	{
		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600AA3B RID: 43579 RVA: 0x00297918 File Offset: 0x00295B18
		[DebuggerNonUserCode]
		public static MessageParser<PrivacyInfo> Parser
		{
			get
			{
				return PrivacyInfo._parser;
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600AA3C RID: 43580 RVA: 0x00297930 File Offset: 0x00295B30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600AA3D RID: 43581 RVA: 0x00297954 File Offset: 0x00295B54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivacyInfo.Descriptor;
			}
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x0029796B File Offset: 0x00295B6B
		[DebuggerNonUserCode]
		public PrivacyInfo()
		{
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x00297978 File Offset: 0x00295B78
		[DebuggerNonUserCode]
		public PrivacyInfo(PrivacyInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isUsingRid_ = other.isUsingRid_;
			this.isVisibleForViewFriends_ = other.isVisibleForViewFriends_;
			this.isHiddenFromFriendFinder_ = other.isHiddenFromFriendFinder_;
			this.gameInfoPrivacy_ = other.gameInfoPrivacy_;
			this.onlyAllowFriendWhispers_ = other.onlyAllowFriendWhispers_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x002979E8 File Offset: 0x00295BE8
		[DebuggerNonUserCode]
		public PrivacyInfo Clone()
		{
			return new PrivacyInfo(this);
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600AA41 RID: 43585 RVA: 0x00297A00 File Offset: 0x00295C00
		// (set) Token: 0x0600AA42 RID: 43586 RVA: 0x00297A31 File Offset: 0x00295C31
		[DebuggerNonUserCode]
		public bool IsUsingRid
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isUsingRidDefaultValue;
				if (flag)
				{
					isUsingRidDefaultValue = this.isUsingRid_;
				}
				else
				{
					isUsingRidDefaultValue = PrivacyInfo.IsUsingRidDefaultValue;
				}
				return isUsingRidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isUsingRid_ = value;
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600AA43 RID: 43587 RVA: 0x00297A4C File Offset: 0x00295C4C
		[DebuggerNonUserCode]
		public bool HasIsUsingRid
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x00297A69 File Offset: 0x00295C69
		[DebuggerNonUserCode]
		public void ClearIsUsingRid()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600AA45 RID: 43589 RVA: 0x00297A7C File Offset: 0x00295C7C
		// (set) Token: 0x0600AA46 RID: 43590 RVA: 0x00297AAD File Offset: 0x00295CAD
		[DebuggerNonUserCode]
		public bool IsVisibleForViewFriends
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isVisibleForViewFriendsDefaultValue;
				if (flag)
				{
					isVisibleForViewFriendsDefaultValue = this.isVisibleForViewFriends_;
				}
				else
				{
					isVisibleForViewFriendsDefaultValue = PrivacyInfo.IsVisibleForViewFriendsDefaultValue;
				}
				return isVisibleForViewFriendsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isVisibleForViewFriends_ = value;
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600AA47 RID: 43591 RVA: 0x00297AC8 File Offset: 0x00295CC8
		[DebuggerNonUserCode]
		public bool HasIsVisibleForViewFriends
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x00297AE5 File Offset: 0x00295CE5
		[DebuggerNonUserCode]
		public void ClearIsVisibleForViewFriends()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600AA49 RID: 43593 RVA: 0x00297AF8 File Offset: 0x00295CF8
		// (set) Token: 0x0600AA4A RID: 43594 RVA: 0x00297B29 File Offset: 0x00295D29
		[DebuggerNonUserCode]
		public bool IsHiddenFromFriendFinder
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isHiddenFromFriendFinderDefaultValue;
				if (flag)
				{
					isHiddenFromFriendFinderDefaultValue = this.isHiddenFromFriendFinder_;
				}
				else
				{
					isHiddenFromFriendFinderDefaultValue = PrivacyInfo.IsHiddenFromFriendFinderDefaultValue;
				}
				return isHiddenFromFriendFinderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isHiddenFromFriendFinder_ = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600AA4B RID: 43595 RVA: 0x00297B44 File Offset: 0x00295D44
		[DebuggerNonUserCode]
		public bool HasIsHiddenFromFriendFinder
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x00297B61 File Offset: 0x00295D61
		[DebuggerNonUserCode]
		public void ClearIsHiddenFromFriendFinder()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600AA4D RID: 43597 RVA: 0x00297B74 File Offset: 0x00295D74
		// (set) Token: 0x0600AA4E RID: 43598 RVA: 0x00297BA5 File Offset: 0x00295DA5
		[DebuggerNonUserCode]
		public PrivacyInfo.Types.GameInfoPrivacy GameInfoPrivacy
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				PrivacyInfo.Types.GameInfoPrivacy gameInfoPrivacyDefaultValue;
				if (flag)
				{
					gameInfoPrivacyDefaultValue = this.gameInfoPrivacy_;
				}
				else
				{
					gameInfoPrivacyDefaultValue = PrivacyInfo.GameInfoPrivacyDefaultValue;
				}
				return gameInfoPrivacyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameInfoPrivacy_ = value;
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600AA4F RID: 43599 RVA: 0x00297BC0 File Offset: 0x00295DC0
		[DebuggerNonUserCode]
		public bool HasGameInfoPrivacy
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x00297BDD File Offset: 0x00295DDD
		[DebuggerNonUserCode]
		public void ClearGameInfoPrivacy()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600AA51 RID: 43601 RVA: 0x00297BF0 File Offset: 0x00295DF0
		// (set) Token: 0x0600AA52 RID: 43602 RVA: 0x00297C22 File Offset: 0x00295E22
		[DebuggerNonUserCode]
		public bool OnlyAllowFriendWhispers
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool onlyAllowFriendWhispersDefaultValue;
				if (flag)
				{
					onlyAllowFriendWhispersDefaultValue = this.onlyAllowFriendWhispers_;
				}
				else
				{
					onlyAllowFriendWhispersDefaultValue = PrivacyInfo.OnlyAllowFriendWhispersDefaultValue;
				}
				return onlyAllowFriendWhispersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.onlyAllowFriendWhispers_ = value;
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600AA53 RID: 43603 RVA: 0x00297C3C File Offset: 0x00295E3C
		[DebuggerNonUserCode]
		public bool HasOnlyAllowFriendWhispers
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x00297C5A File Offset: 0x00295E5A
		[DebuggerNonUserCode]
		public void ClearOnlyAllowFriendWhispers()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x00297C6C File Offset: 0x00295E6C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivacyInfo);
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x00297C8C File Offset: 0x00295E8C
		[DebuggerNonUserCode]
		public bool Equals(PrivacyInfo other)
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
					bool flag4 = this.IsUsingRid != other.IsUsingRid;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsVisibleForViewFriends != other.IsVisibleForViewFriends;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsHiddenFromFriendFinder != other.IsHiddenFromFriendFinder;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GameInfoPrivacy != other.GameInfoPrivacy;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.OnlyAllowFriendWhispers != other.OnlyAllowFriendWhispers;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x00297D58 File Offset: 0x00295F58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				num ^= this.IsUsingRid.GetHashCode();
			}
			bool hasIsVisibleForViewFriends = this.HasIsVisibleForViewFriends;
			if (hasIsVisibleForViewFriends)
			{
				num ^= this.IsVisibleForViewFriends.GetHashCode();
			}
			bool hasIsHiddenFromFriendFinder = this.HasIsHiddenFromFriendFinder;
			if (hasIsHiddenFromFriendFinder)
			{
				num ^= this.IsHiddenFromFriendFinder.GetHashCode();
			}
			bool hasGameInfoPrivacy = this.HasGameInfoPrivacy;
			if (hasGameInfoPrivacy)
			{
				num ^= this.GameInfoPrivacy.GetHashCode();
			}
			bool hasOnlyAllowFriendWhispers = this.HasOnlyAllowFriendWhispers;
			if (hasOnlyAllowFriendWhispers)
			{
				num ^= this.OnlyAllowFriendWhispers.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x00297E24 File Offset: 0x00296024
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x00297E3C File Offset: 0x0029603C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x00297E48 File Offset: 0x00296048
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUsingRid);
			}
			bool hasIsVisibleForViewFriends = this.HasIsVisibleForViewFriends;
			if (hasIsVisibleForViewFriends)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsVisibleForViewFriends);
			}
			bool hasIsHiddenFromFriendFinder = this.HasIsHiddenFromFriendFinder;
			if (hasIsHiddenFromFriendFinder)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsHiddenFromFriendFinder);
			}
			bool hasGameInfoPrivacy = this.HasGameInfoPrivacy;
			if (hasGameInfoPrivacy)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.GameInfoPrivacy);
			}
			bool hasOnlyAllowFriendWhispers = this.HasOnlyAllowFriendWhispers;
			if (hasOnlyAllowFriendWhispers)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.OnlyAllowFriendWhispers);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x00297F20 File Offset: 0x00296120
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				num += 2;
			}
			bool hasIsVisibleForViewFriends = this.HasIsVisibleForViewFriends;
			if (hasIsVisibleForViewFriends)
			{
				num += 2;
			}
			bool hasIsHiddenFromFriendFinder = this.HasIsHiddenFromFriendFinder;
			if (hasIsHiddenFromFriendFinder)
			{
				num += 2;
			}
			bool hasGameInfoPrivacy = this.HasGameInfoPrivacy;
			if (hasGameInfoPrivacy)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GameInfoPrivacy);
			}
			bool hasOnlyAllowFriendWhispers = this.HasOnlyAllowFriendWhispers;
			if (hasOnlyAllowFriendWhispers)
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

		// Token: 0x0600AA5C RID: 43612 RVA: 0x00297FB8 File Offset: 0x002961B8
		[DebuggerNonUserCode]
		public void MergeFrom(PrivacyInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsUsingRid = other.HasIsUsingRid;
				if (hasIsUsingRid)
				{
					this.IsUsingRid = other.IsUsingRid;
				}
				bool hasIsVisibleForViewFriends = other.HasIsVisibleForViewFriends;
				if (hasIsVisibleForViewFriends)
				{
					this.IsVisibleForViewFriends = other.IsVisibleForViewFriends;
				}
				bool hasIsHiddenFromFriendFinder = other.HasIsHiddenFromFriendFinder;
				if (hasIsHiddenFromFriendFinder)
				{
					this.IsHiddenFromFriendFinder = other.IsHiddenFromFriendFinder;
				}
				bool hasGameInfoPrivacy = other.HasGameInfoPrivacy;
				if (hasGameInfoPrivacy)
				{
					this.GameInfoPrivacy = other.GameInfoPrivacy;
				}
				bool hasOnlyAllowFriendWhispers = other.HasOnlyAllowFriendWhispers;
				if (hasOnlyAllowFriendWhispers)
				{
					this.OnlyAllowFriendWhispers = other.OnlyAllowFriendWhispers;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x0029806C File Offset: 0x0029626C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x00298078 File Offset: 0x00296278
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_0033;
						}
						this.IsVisibleForViewFriends = input.ReadBool();
					}
					else
					{
						this.IsUsingRid = input.ReadBool();
					}
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_0033;
						}
						this.OnlyAllowFriendWhispers = input.ReadBool();
					}
					else
					{
						this.GameInfoPrivacy = (PrivacyInfo.Types.GameInfoPrivacy)input.ReadEnum();
					}
				}
				else
				{
					this.IsHiddenFromFriendFinder = input.ReadBool();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CA2 RID: 19618
		private static readonly MessageParser<PrivacyInfo> _parser = new MessageParser<PrivacyInfo>(() => new PrivacyInfo());

		// Token: 0x04004CA3 RID: 19619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CA4 RID: 19620
		private int _hasBits0;

		// Token: 0x04004CA5 RID: 19621
		public const int IsUsingRidFieldNumber = 3;

		// Token: 0x04004CA6 RID: 19622
		private static readonly bool IsUsingRidDefaultValue = false;

		// Token: 0x04004CA7 RID: 19623
		private bool isUsingRid_;

		// Token: 0x04004CA8 RID: 19624
		public const int IsVisibleForViewFriendsFieldNumber = 4;

		// Token: 0x04004CA9 RID: 19625
		private static readonly bool IsVisibleForViewFriendsDefaultValue = false;

		// Token: 0x04004CAA RID: 19626
		private bool isVisibleForViewFriends_;

		// Token: 0x04004CAB RID: 19627
		public const int IsHiddenFromFriendFinderFieldNumber = 5;

		// Token: 0x04004CAC RID: 19628
		private static readonly bool IsHiddenFromFriendFinderDefaultValue = false;

		// Token: 0x04004CAD RID: 19629
		private bool isHiddenFromFriendFinder_;

		// Token: 0x04004CAE RID: 19630
		public const int GameInfoPrivacyFieldNumber = 6;

		// Token: 0x04004CAF RID: 19631
		private static readonly PrivacyInfo.Types.GameInfoPrivacy GameInfoPrivacyDefaultValue = PrivacyInfo.Types.GameInfoPrivacy.PrivacyFriends;

		// Token: 0x04004CB0 RID: 19632
		private PrivacyInfo.Types.GameInfoPrivacy gameInfoPrivacy_;

		// Token: 0x04004CB1 RID: 19633
		public const int OnlyAllowFriendWhispersFieldNumber = 7;

		// Token: 0x04004CB2 RID: 19634
		private static readonly bool OnlyAllowFriendWhispersDefaultValue = false;

		// Token: 0x04004CB3 RID: 19635
		private bool onlyAllowFriendWhispers_;

		// Token: 0x02001252 RID: 4690
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200149A RID: 5274
			public enum GameInfoPrivacy
			{
				// Token: 0x0400A507 RID: 42247
				[OriginalName("PRIVACY_ME")]
				PrivacyMe,
				// Token: 0x0400A508 RID: 42248
				[OriginalName("PRIVACY_FRIENDS")]
				PrivacyFriends,
				// Token: 0x0400A509 RID: 42249
				[OriginalName("PRIVACY_EVERYONE")]
				PrivacyEveryone
			}
		}
	}
}
