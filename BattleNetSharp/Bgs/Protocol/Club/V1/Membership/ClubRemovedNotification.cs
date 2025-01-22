using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000510 RID: 1296
	public sealed class ClubRemovedNotification : IMessage<ClubRemovedNotification>, IMessage, IEquatable<ClubRemovedNotification>, IDeepCloneable<ClubRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x001EBE70 File Offset: 0x001EA070
		[DebuggerNonUserCode]
		public static MessageParser<ClubRemovedNotification> Parser
		{
			get
			{
				return ClubRemovedNotification._parser;
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x06007E4D RID: 32333 RVA: 0x001EBE88 File Offset: 0x001EA088
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x001EBEAC File Offset: 0x001EA0AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x001EBEC3 File Offset: 0x001EA0C3
		[DebuggerNonUserCode]
		public ClubRemovedNotification()
		{
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x001EBED0 File Offset: 0x001EA0D0
		[DebuggerNonUserCode]
		public ClubRemovedNotification(ClubRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x001EBF54 File Offset: 0x001EA154
		[DebuggerNonUserCode]
		public ClubRemovedNotification Clone()
		{
			return new ClubRemovedNotification(this);
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x06007E52 RID: 32338 RVA: 0x001EBF6C File Offset: 0x001EA16C
		// (set) Token: 0x06007E53 RID: 32339 RVA: 0x001EBF84 File Offset: 0x001EA184
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

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x001EBF90 File Offset: 0x001EA190
		// (set) Token: 0x06007E55 RID: 32341 RVA: 0x001EBFA8 File Offset: 0x001EA1A8
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x06007E56 RID: 32342 RVA: 0x001EBFB4 File Offset: 0x001EA1B4
		// (set) Token: 0x06007E57 RID: 32343 RVA: 0x001EBFE5 File Offset: 0x001EA1E5
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
					clubIdDefaultValue = ClubRemovedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x06007E58 RID: 32344 RVA: 0x001EC000 File Offset: 0x001EA200
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x001EC01D File Offset: 0x001EA21D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x06007E5A RID: 32346 RVA: 0x001EC030 File Offset: 0x001EA230
		// (set) Token: 0x06007E5B RID: 32347 RVA: 0x001EC061 File Offset: 0x001EA261
		[DebuggerNonUserCode]
		public ClubRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ClubRemovedReason reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = ClubRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x001EC07C File Offset: 0x001EA27C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x001EC099 File Offset: 0x001EA299
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x001EC0AC File Offset: 0x001EA2AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubRemovedNotification);
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x001EC0CC File Offset: 0x001EA2CC
		[DebuggerNonUserCode]
		public bool Equals(ClubRemovedNotification other)
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
						bool flag5 = !object.Equals(this.MemberId, other.MemberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ClubId != other.ClubId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Reason != other.Reason;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x001EC180 File Offset: 0x001EA380
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x001EC22C File Offset: 0x001EA42C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x001EC244 File Offset: 0x001EA444
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x001EC250 File Offset: 0x001EA450
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MemberId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ClubId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x001EC30C File Offset: 0x001EA50C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x001EC3BC File Offset: 0x001EA5BC
		[DebuggerNonUserCode]
		public void MergeFrom(ClubRemovedNotification other)
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
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x001EC49F File Offset: 0x001EA69F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x001EC4AC File Offset: 0x001EA6AC
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
						if (num3 != 26U)
						{
							goto IL_002C;
						}
						bool flag = this.memberId_ == null;
						if (flag)
						{
							this.MemberId = new MemberId();
						}
						input.ReadMessage(this.MemberId);
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
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						goto IL_002C;
					}
					this.Reason = (ClubRemovedReason)input.ReadEnum();
				}
				else
				{
					this.ClubId = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003971 RID: 14705
		private static readonly MessageParser<ClubRemovedNotification> _parser = new MessageParser<ClubRemovedNotification>(() => new ClubRemovedNotification());

		// Token: 0x04003972 RID: 14706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003973 RID: 14707
		private int _hasBits0;

		// Token: 0x04003974 RID: 14708
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003975 RID: 14709
		private MemberId agentId_;

		// Token: 0x04003976 RID: 14710
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04003977 RID: 14711
		private MemberId memberId_;

		// Token: 0x04003978 RID: 14712
		public const int ClubIdFieldNumber = 4;

		// Token: 0x04003979 RID: 14713
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400397A RID: 14714
		private ulong clubId_;

		// Token: 0x0400397B RID: 14715
		public const int ReasonFieldNumber = 5;

		// Token: 0x0400397C RID: 14716
		private static readonly ClubRemovedReason ReasonDefaultValue = ClubRemovedReason.None;

		// Token: 0x0400397D RID: 14717
		private ClubRemovedReason reason_;
	}
}
