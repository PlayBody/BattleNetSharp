using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047D RID: 1149
	public sealed class SubscribeNotification : IMessage<SubscribeNotification>, IMessage, IEquatable<SubscribeNotification>, IDeepCloneable<SubscribeNotification>, IBufferMessage
	{
		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x001B3C64 File Offset: 0x001B1E64
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeNotification> Parser
		{
			get
			{
				return SubscribeNotification._parser;
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x001B3C7C File Offset: 0x001B1E7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x001B3CA0 File Offset: 0x001B1EA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeNotification.Descriptor;
			}
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x001B3CB7 File Offset: 0x001B1EB7
		[DebuggerNonUserCode]
		public SubscribeNotification()
		{
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x001B3CC4 File Offset: 0x001B1EC4
		[DebuggerNonUserCode]
		public SubscribeNotification(SubscribeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.club_ = ((other.club_ != null) ? other.club_.Clone() : null);
			this.view_ = ((other.view_ != null) ? other.view_.Clone() : null);
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x001B3D90 File Offset: 0x001B1F90
		[DebuggerNonUserCode]
		public SubscribeNotification Clone()
		{
			return new SubscribeNotification(this);
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x001B3DA8 File Offset: 0x001B1FA8
		// (set) Token: 0x06006FFE RID: 28670 RVA: 0x001B3DC0 File Offset: 0x001B1FC0
		[DebuggerNonUserCode]
		public MemberId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x001B3DCC File Offset: 0x001B1FCC
		// (set) Token: 0x06007000 RID: 28672 RVA: 0x001B3DFD File Offset: 0x001B1FFD
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = SubscribeNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x001B3E18 File Offset: 0x001B2018
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x001B3E35 File Offset: 0x001B2035
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x001B3E48 File Offset: 0x001B2048
		// (set) Token: 0x06007004 RID: 28676 RVA: 0x001B3E60 File Offset: 0x001B2060
		[DebuggerNonUserCode]
		public Club Club
		{
			get
			{
				return this.club_;
			}
			set
			{
				this.club_ = value;
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x06007005 RID: 28677 RVA: 0x001B3E6C File Offset: 0x001B206C
		// (set) Token: 0x06007006 RID: 28678 RVA: 0x001B3E84 File Offset: 0x001B2084
		[DebuggerNonUserCode]
		public ClubView View
		{
			get
			{
				return this.view_;
			}
			set
			{
				this.view_ = value;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x06007007 RID: 28679 RVA: 0x001B3E90 File Offset: 0x001B2090
		// (set) Token: 0x06007008 RID: 28680 RVA: 0x001B3EA8 File Offset: 0x001B20A8
		[DebuggerNonUserCode]
		public ClubSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x06007009 RID: 28681 RVA: 0x001B3EB4 File Offset: 0x001B20B4
		// (set) Token: 0x0600700A RID: 28682 RVA: 0x001B3ECC File Offset: 0x001B20CC
		[DebuggerNonUserCode]
		public Member Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x001B3ED8 File Offset: 0x001B20D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeNotification);
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x001B3EF8 File Offset: 0x001B20F8
		[DebuggerNonUserCode]
		public bool Equals(SubscribeNotification other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Club, other.Club);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.View, other.View);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Settings, other.Settings);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Member, other.Member);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x001B3FF0 File Offset: 0x001B21F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num ^= this.Club.GetHashCode();
			}
			bool flag3 = this.view_ != null;
			if (flag3)
			{
				num ^= this.View.GetHashCode();
			}
			bool flag4 = this.settings_ != null;
			if (flag4)
			{
				num ^= this.Settings.GetHashCode();
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x001B40D0 File Offset: 0x001B22D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x001B40E8 File Offset: 0x001B22E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x001B40F4 File Offset: 0x001B22F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClubId);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Club);
			}
			bool flag3 = this.view_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.View);
			}
			bool flag4 = this.settings_ != null;
			if (flag4)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Settings);
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Member);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x001B4200 File Offset: 0x001B2400
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Club);
			}
			bool flag3 = this.view_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.View);
			}
			bool flag4 = this.settings_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x001B42F4 File Offset: 0x001B24F4
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool flag4 = other.club_ != null;
				if (flag4)
				{
					bool flag5 = this.club_ == null;
					if (flag5)
					{
						this.Club = new Club();
					}
					this.Club.MergeFrom(other.Club);
				}
				bool flag6 = other.view_ != null;
				if (flag6)
				{
					bool flag7 = this.view_ == null;
					if (flag7)
					{
						this.View = new ClubView();
					}
					this.View.MergeFrom(other.View);
				}
				bool flag8 = other.settings_ != null;
				if (flag8)
				{
					bool flag9 = this.settings_ == null;
					if (flag9)
					{
						this.Settings = new ClubSettings();
					}
					this.Settings.MergeFrom(other.Settings);
				}
				bool flag10 = other.member_ != null;
				if (flag10)
				{
					bool flag11 = this.member_ == null;
					if (flag11)
					{
						this.Member = new Member();
					}
					this.Member.MergeFrom(other.Member);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x001B447C File Offset: 0x001B267C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x001B4488 File Offset: 0x001B2688
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 != 10U)
					{
						if (num3 != 24U)
						{
							if (num3 != 34U)
							{
								goto IL_0043;
							}
							bool flag = this.club_ == null;
							if (flag)
							{
								this.Club = new Club();
							}
							input.ReadMessage(this.Club);
						}
						else
						{
							this.ClubId = input.ReadUInt64();
						}
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new MemberId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 42U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_0043;
						}
						bool flag3 = this.member_ == null;
						if (flag3)
						{
							this.Member = new Member();
						}
						input.ReadMessage(this.Member);
					}
					else
					{
						bool flag4 = this.settings_ == null;
						if (flag4)
						{
							this.Settings = new ClubSettings();
						}
						input.ReadMessage(this.Settings);
					}
				}
				else
				{
					bool flag5 = this.view_ == null;
					if (flag5)
					{
						this.View = new ClubView();
					}
					input.ReadMessage(this.View);
				}
				continue;
				IL_0043:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400335A RID: 13146
		private static readonly MessageParser<SubscribeNotification> _parser = new MessageParser<SubscribeNotification>(() => new SubscribeNotification());

		// Token: 0x0400335B RID: 13147
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400335C RID: 13148
		private int _hasBits0;

		// Token: 0x0400335D RID: 13149
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400335E RID: 13150
		private MemberId agentId_;

		// Token: 0x0400335F RID: 13151
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003360 RID: 13152
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003361 RID: 13153
		private ulong clubId_;

		// Token: 0x04003362 RID: 13154
		public const int ClubFieldNumber = 4;

		// Token: 0x04003363 RID: 13155
		private Club club_;

		// Token: 0x04003364 RID: 13156
		public const int ViewFieldNumber = 5;

		// Token: 0x04003365 RID: 13157
		private ClubView view_;

		// Token: 0x04003366 RID: 13158
		public const int SettingsFieldNumber = 10;

		// Token: 0x04003367 RID: 13159
		private ClubSettings settings_;

		// Token: 0x04003368 RID: 13160
		public const int MemberFieldNumber = 11;

		// Token: 0x04003369 RID: 13161
		private Member member_;
	}
}
