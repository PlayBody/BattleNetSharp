using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x0200020B RID: 523
	public sealed class ClanData : IMessage<ClanData>, IMessage, IEquatable<ClanData>, IDeepCloneable<ClanData>, IBufferMessage
	{
		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x000E21B0 File Offset: 0x000E03B0
		[DebuggerNonUserCode]
		public static MessageParser<ClanData> Parser
		{
			get
			{
				return ClanData._parser;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x000E21C8 File Offset: 0x000E03C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x000E21EC File Offset: 0x000E03EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanData.Descriptor;
			}
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x000E2203 File Offset: 0x000E0403
		[DebuggerNonUserCode]
		public ClanData()
		{
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x000E2224 File Offset: 0x000E0424
		[DebuggerNonUserCode]
		public ClanData(ClanData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.memberInfo_ = ((other.memberInfo_ != null) ? other.memberInfo_.Clone() : null);
			this.invites_ = other.invites_.Clone();
			this.applications_ = other.applications_.Clone();
			this.newsList_ = ((other.newsList_ != null) ? other.newsList_.Clone() : null);
			this.removalReason_ = other.removalReason_;
			this.removalTime_ = other.removalTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x000E22E4 File Offset: 0x000E04E4
		[DebuggerNonUserCode]
		public ClanData Clone()
		{
			return new ClanData(this);
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x000E22FC File Offset: 0x000E04FC
		// (set) Token: 0x0600393D RID: 14653 RVA: 0x000E2314 File Offset: 0x000E0514
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

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600393E RID: 14654 RVA: 0x000E2320 File Offset: 0x000E0520
		// (set) Token: 0x0600393F RID: 14655 RVA: 0x000E2338 File Offset: 0x000E0538
		[DebuggerNonUserCode]
		public ClanMember MemberInfo
		{
			get
			{
				return this.memberInfo_;
			}
			set
			{
				this.memberInfo_ = value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06003940 RID: 14656 RVA: 0x000E2344 File Offset: 0x000E0544
		[DebuggerNonUserCode]
		public RepeatedField<ClanInvite> Invites
		{
			get
			{
				return this.invites_;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x000E235C File Offset: 0x000E055C
		[DebuggerNonUserCode]
		public RepeatedField<ClanApplication> Applications
		{
			get
			{
				return this.applications_;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003942 RID: 14658 RVA: 0x000E2374 File Offset: 0x000E0574
		// (set) Token: 0x06003943 RID: 14659 RVA: 0x000E238C File Offset: 0x000E058C
		[DebuggerNonUserCode]
		public ClanNewsList NewsList
		{
			get
			{
				return this.newsList_;
			}
			set
			{
				this.newsList_ = value;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x000E2398 File Offset: 0x000E0598
		// (set) Token: 0x06003945 RID: 14661 RVA: 0x000E23C9 File Offset: 0x000E05C9
		[DebuggerNonUserCode]
		public uint RemovalReason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint removalReasonDefaultValue;
				if (flag)
				{
					removalReasonDefaultValue = this.removalReason_;
				}
				else
				{
					removalReasonDefaultValue = ClanData.RemovalReasonDefaultValue;
				}
				return removalReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.removalReason_ = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x000E23E4 File Offset: 0x000E05E4
		[DebuggerNonUserCode]
		public bool HasRemovalReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x000E2401 File Offset: 0x000E0601
		[DebuggerNonUserCode]
		public void ClearRemovalReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x000E2414 File Offset: 0x000E0614
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x000E2445 File Offset: 0x000E0645
		[DebuggerNonUserCode]
		public ulong RemovalTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong removalTimeDefaultValue;
				if (flag)
				{
					removalTimeDefaultValue = this.removalTime_;
				}
				else
				{
					removalTimeDefaultValue = ClanData.RemovalTimeDefaultValue;
				}
				return removalTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.removalTime_ = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x000E2460 File Offset: 0x000E0660
		[DebuggerNonUserCode]
		public bool HasRemovalTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x000E247D File Offset: 0x000E067D
		[DebuggerNonUserCode]
		public void ClearRemovalTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x000E2490 File Offset: 0x000E0690
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanData);
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x000E24B0 File Offset: 0x000E06B0
		[DebuggerNonUserCode]
		public bool Equals(ClanData other)
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
						bool flag5 = !object.Equals(this.MemberInfo, other.MemberInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.invites_.Equals(other.invites_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.applications_.Equals(other.applications_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.NewsList, other.NewsList);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.RemovalReason != other.RemovalReason;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.RemovalTime != other.RemovalTime;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600394E RID: 14670 RVA: 0x000E25C8 File Offset: 0x000E07C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.info_ != null;
			if (flag)
			{
				num ^= this.Info.GetHashCode();
			}
			bool flag2 = this.memberInfo_ != null;
			if (flag2)
			{
				num ^= this.MemberInfo.GetHashCode();
			}
			num ^= this.invites_.GetHashCode();
			num ^= this.applications_.GetHashCode();
			bool flag3 = this.newsList_ != null;
			if (flag3)
			{
				num ^= this.NewsList.GetHashCode();
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num ^= this.RemovalReason.GetHashCode();
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				num ^= this.RemovalTime.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x000E26A8 File Offset: 0x000E08A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x000E26C0 File Offset: 0x000E08C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000E26CC File Offset: 0x000E08CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.info_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			bool flag2 = this.memberInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MemberInfo);
			}
			this.invites_.WriteTo(ref output, ClanData._repeated_invites_codec);
			this.applications_.WriteTo(ref output, ClanData._repeated_applications_codec);
			bool flag3 = this.newsList_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NewsList);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RemovalReason);
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.RemovalTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x000E27D4 File Offset: 0x000E09D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.info_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			bool flag2 = this.memberInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberInfo);
			}
			num += this.invites_.CalculateSize(ClanData._repeated_invites_codec);
			num += this.applications_.CalculateSize(ClanData._repeated_applications_codec);
			bool flag3 = this.newsList_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewsList);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemovalReason);
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RemovalTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x000E28CC File Offset: 0x000E0ACC
		[DebuggerNonUserCode]
		public void MergeFrom(ClanData other)
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
				bool flag4 = other.memberInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.memberInfo_ == null;
					if (flag5)
					{
						this.MemberInfo = new ClanMember();
					}
					this.MemberInfo.MergeFrom(other.MemberInfo);
				}
				this.invites_.Add(other.invites_);
				this.applications_.Add(other.applications_);
				bool flag6 = other.newsList_ != null;
				if (flag6)
				{
					bool flag7 = this.newsList_ == null;
					if (flag7)
					{
						this.NewsList = new ClanNewsList();
					}
					this.NewsList.MergeFrom(other.NewsList);
				}
				bool hasRemovalReason = other.HasRemovalReason;
				if (hasRemovalReason)
				{
					this.RemovalReason = other.RemovalReason;
				}
				bool hasRemovalTime = other.HasRemovalTime;
				if (hasRemovalTime)
				{
					this.RemovalTime = other.RemovalTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x000E2A13 File Offset: 0x000E0C13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x000E2A20 File Offset: 0x000E0C20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							this.invites_.AddEntriesFrom(ref input, ClanData._repeated_invites_codec);
						}
						else
						{
							bool flag = this.memberInfo_ == null;
							if (flag)
							{
								this.MemberInfo = new ClanMember();
							}
							input.ReadMessage(this.MemberInfo);
						}
					}
					else
					{
						bool flag2 = this.info_ == null;
						if (flag2)
						{
							this.Info = new ClanInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0055;
						}
						bool flag3 = this.newsList_ == null;
						if (flag3)
						{
							this.NewsList = new ClanNewsList();
						}
						input.ReadMessage(this.NewsList);
					}
					else
					{
						this.applications_.AddEntriesFrom(ref input, ClanData._repeated_applications_codec);
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0055;
					}
					this.RemovalTime = input.ReadUInt64();
				}
				else
				{
					this.RemovalReason = input.ReadUInt32();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AAA RID: 6826
		private static readonly MessageParser<ClanData> _parser = new MessageParser<ClanData>(() => new ClanData());

		// Token: 0x04001AAB RID: 6827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AAC RID: 6828
		private int _hasBits0;

		// Token: 0x04001AAD RID: 6829
		public const int InfoFieldNumber = 1;

		// Token: 0x04001AAE RID: 6830
		private ClanInfo info_;

		// Token: 0x04001AAF RID: 6831
		public const int MemberInfoFieldNumber = 2;

		// Token: 0x04001AB0 RID: 6832
		private ClanMember memberInfo_;

		// Token: 0x04001AB1 RID: 6833
		public const int InvitesFieldNumber = 3;

		// Token: 0x04001AB2 RID: 6834
		private static readonly FieldCodec<ClanInvite> _repeated_invites_codec = FieldCodec.ForMessage<ClanInvite>(26U, ClanInvite.Parser);

		// Token: 0x04001AB3 RID: 6835
		private readonly RepeatedField<ClanInvite> invites_ = new RepeatedField<ClanInvite>();

		// Token: 0x04001AB4 RID: 6836
		public const int ApplicationsFieldNumber = 4;

		// Token: 0x04001AB5 RID: 6837
		private static readonly FieldCodec<ClanApplication> _repeated_applications_codec = FieldCodec.ForMessage<ClanApplication>(34U, ClanApplication.Parser);

		// Token: 0x04001AB6 RID: 6838
		private readonly RepeatedField<ClanApplication> applications_ = new RepeatedField<ClanApplication>();

		// Token: 0x04001AB7 RID: 6839
		public const int NewsListFieldNumber = 5;

		// Token: 0x04001AB8 RID: 6840
		private ClanNewsList newsList_;

		// Token: 0x04001AB9 RID: 6841
		public const int RemovalReasonFieldNumber = 6;

		// Token: 0x04001ABA RID: 6842
		private static readonly uint RemovalReasonDefaultValue = 0U;

		// Token: 0x04001ABB RID: 6843
		private uint removalReason_;

		// Token: 0x04001ABC RID: 6844
		public const int RemovalTimeFieldNumber = 7;

		// Token: 0x04001ABD RID: 6845
		private static readonly ulong RemovalTimeDefaultValue = 0UL;

		// Token: 0x04001ABE RID: 6846
		private ulong removalTime_;
	}
}
