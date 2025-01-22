using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B1 RID: 689
	public sealed class Clan : IMessage<Clan>, IMessage, IEquatable<Clan>, IDeepCloneable<Clan>, IBufferMessage
	{
		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x00118058 File Offset: 0x00116258
		[DebuggerNonUserCode]
		public static MessageParser<Clan> Parser
		{
			get
			{
				return Clan._parser;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x00118070 File Offset: 0x00116270
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00118094 File Offset: 0x00116294
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Clan.Descriptor;
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x001180AB File Offset: 0x001162AB
		[DebuggerNonUserCode]
		public Clan()
		{
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x001180E4 File Offset: 0x001162E4
		[DebuggerNonUserCode]
		public Clan(Clan other)
			: this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.member_ = other.member_.Clone();
			this.invite_ = other.invite_.Clone();
			this.pendingApplication_ = other.pendingApplication_.Clone();
			this.ban_ = other.ban_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x0011816C File Offset: 0x0011636C
		[DebuggerNonUserCode]
		public Clan Clone()
		{
			return new Clan(this);
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x00118184 File Offset: 0x00116384
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x0011819C File Offset: 0x0011639C
		[DebuggerNonUserCode]
		public ClanInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x001181A8 File Offset: 0x001163A8
		[DebuggerNonUserCode]
		public RepeatedField<ClanMember> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004927 RID: 18727 RVA: 0x001181C0 File Offset: 0x001163C0
		[DebuggerNonUserCode]
		public RepeatedField<ClanInvite> Invite
		{
			get
			{
				return this.invite_;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x001181D8 File Offset: 0x001163D8
		[DebuggerNonUserCode]
		public RepeatedField<ClanApplication> PendingApplication
		{
			get
			{
				return this.pendingApplication_;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004929 RID: 18729 RVA: 0x001181F0 File Offset: 0x001163F0
		[DebuggerNonUserCode]
		public RepeatedField<ClanBannedMember> Ban
		{
			get
			{
				return this.ban_;
			}
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00118208 File Offset: 0x00116408
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Clan);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00118228 File Offset: 0x00116428
		[DebuggerNonUserCode]
		public bool Equals(Clan other)
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
					bool flag4 = !object.Equals(this.Info, other.Info);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.member_.Equals(other.member_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.invite_.Equals(other.invite_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.pendingApplication_.Equals(other.pendingApplication_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.ban_.Equals(other.ban_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00118304 File Offset: 0x00116504
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.info_ != null;
			if (flag)
			{
				num ^= this.Info.GetHashCode();
			}
			num ^= this.member_.GetHashCode();
			num ^= this.invite_.GetHashCode();
			num ^= this.pendingApplication_.GetHashCode();
			num ^= this.ban_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x0011838C File Offset: 0x0011658C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x001183A4 File Offset: 0x001165A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x001183B0 File Offset: 0x001165B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.info_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			this.member_.WriteTo(ref output, Clan._repeated_member_codec);
			this.invite_.WriteTo(ref output, Clan._repeated_invite_codec);
			this.pendingApplication_.WriteTo(ref output, Clan._repeated_pendingApplication_codec);
			this.ban_.WriteTo(ref output, Clan._repeated_ban_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00118448 File Offset: 0x00116648
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.info_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			num += this.member_.CalculateSize(Clan._repeated_member_codec);
			num += this.invite_.CalculateSize(Clan._repeated_invite_codec);
			num += this.pendingApplication_.CalculateSize(Clan._repeated_pendingApplication_codec);
			num += this.ban_.CalculateSize(Clan._repeated_ban_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x001184E8 File Offset: 0x001166E8
		[DebuggerNonUserCode]
		public void MergeFrom(Clan other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.info_ != null;
				if (flag2)
				{
					bool flag3 = this.info_ == null;
					if (flag3)
					{
						this.Info = new ClanInfo();
					}
					this.Info.MergeFrom(other.Info);
				}
				this.member_.Add(other.member_);
				this.invite_.Add(other.invite_);
				this.pendingApplication_.Add(other.pendingApplication_);
				this.ban_.Add(other.ban_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0011859F File Offset: 0x0011679F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x001185AC File Offset: 0x001167AC
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
							goto IL_0036;
						}
						this.member_.AddEntriesFrom(ref input, Clan._repeated_member_codec);
					}
					else
					{
						bool flag = this.info_ == null;
						if (flag)
						{
							this.Info = new ClanInfo();
						}
						input.ReadMessage(this.Info);
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
						this.ban_.AddEntriesFrom(ref input, Clan._repeated_ban_codec);
					}
					else
					{
						this.pendingApplication_.AddEntriesFrom(ref input, Clan._repeated_pendingApplication_codec);
					}
				}
				else
				{
					this.invite_.AddEntriesFrom(ref input, Clan._repeated_invite_codec);
				}
				continue;
				IL_0036:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002094 RID: 8340
		private static readonly MessageParser<Clan> _parser = new MessageParser<Clan>(() => new Clan());

		// Token: 0x04002095 RID: 8341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002096 RID: 8342
		public const int InfoFieldNumber = 1;

		// Token: 0x04002097 RID: 8343
		private ClanInfo info_;

		// Token: 0x04002098 RID: 8344
		public const int MemberFieldNumber = 2;

		// Token: 0x04002099 RID: 8345
		private static readonly FieldCodec<ClanMember> _repeated_member_codec = FieldCodec.ForMessage<ClanMember>(18U, ClanMember.Parser);

		// Token: 0x0400209A RID: 8346
		private readonly RepeatedField<ClanMember> member_ = new RepeatedField<ClanMember>();

		// Token: 0x0400209B RID: 8347
		public const int InviteFieldNumber = 3;

		// Token: 0x0400209C RID: 8348
		private static readonly FieldCodec<ClanInvite> _repeated_invite_codec = FieldCodec.ForMessage<ClanInvite>(26U, ClanInvite.Parser);

		// Token: 0x0400209D RID: 8349
		private readonly RepeatedField<ClanInvite> invite_ = new RepeatedField<ClanInvite>();

		// Token: 0x0400209E RID: 8350
		public const int PendingApplicationFieldNumber = 4;

		// Token: 0x0400209F RID: 8351
		private static readonly FieldCodec<ClanApplication> _repeated_pendingApplication_codec = FieldCodec.ForMessage<ClanApplication>(34U, ClanApplication.Parser);

		// Token: 0x040020A0 RID: 8352
		private readonly RepeatedField<ClanApplication> pendingApplication_ = new RepeatedField<ClanApplication>();

		// Token: 0x040020A1 RID: 8353
		public const int BanFieldNumber = 5;

		// Token: 0x040020A2 RID: 8354
		private static readonly FieldCodec<ClanBannedMember> _repeated_ban_codec = FieldCodec.ForMessage<ClanBannedMember>(42U, ClanBannedMember.Parser);

		// Token: 0x040020A3 RID: 8355
		private readonly RepeatedField<ClanBannedMember> ban_ = new RepeatedField<ClanBannedMember>();
	}
}
