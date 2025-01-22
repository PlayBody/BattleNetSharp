using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000489 RID: 1161
	public sealed class SuggestionRemovedNotification : IMessage<SuggestionRemovedNotification>, IMessage, IEquatable<SuggestionRemovedNotification>, IDeepCloneable<SuggestionRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x06007128 RID: 28968 RVA: 0x001B855C File Offset: 0x001B675C
		[DebuggerNonUserCode]
		public static MessageParser<SuggestionRemovedNotification> Parser
		{
			get
			{
				return SuggestionRemovedNotification._parser;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x001B8574 File Offset: 0x001B6774
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x001B8598 File Offset: 0x001B6798
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuggestionRemovedNotification.Descriptor;
			}
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x001B85AF File Offset: 0x001B67AF
		[DebuggerNonUserCode]
		public SuggestionRemovedNotification()
		{
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x001B85BC File Offset: 0x001B67BC
		[DebuggerNonUserCode]
		public SuggestionRemovedNotification(SuggestionRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.suggestionId_ = other.suggestionId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x001B8630 File Offset: 0x001B6830
		[DebuggerNonUserCode]
		public SuggestionRemovedNotification Clone()
		{
			return new SuggestionRemovedNotification(this);
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x001B8648 File Offset: 0x001B6848
		// (set) Token: 0x0600712F RID: 28975 RVA: 0x001B8660 File Offset: 0x001B6860
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

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x001B866C File Offset: 0x001B686C
		// (set) Token: 0x06007131 RID: 28977 RVA: 0x001B869D File Offset: 0x001B689D
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
					clubIdDefaultValue = SuggestionRemovedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x001B86B8 File Offset: 0x001B68B8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x001B86D5 File Offset: 0x001B68D5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x001B86E8 File Offset: 0x001B68E8
		// (set) Token: 0x06007135 RID: 28981 RVA: 0x001B8719 File Offset: 0x001B6919
		[DebuggerNonUserCode]
		public ulong SuggestionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong suggestionIdDefaultValue;
				if (flag)
				{
					suggestionIdDefaultValue = this.suggestionId_;
				}
				else
				{
					suggestionIdDefaultValue = SuggestionRemovedNotification.SuggestionIdDefaultValue;
				}
				return suggestionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.suggestionId_ = value;
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x001B8734 File Offset: 0x001B6934
		[DebuggerNonUserCode]
		public bool HasSuggestionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x001B8751 File Offset: 0x001B6951
		[DebuggerNonUserCode]
		public void ClearSuggestionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x06007138 RID: 28984 RVA: 0x001B8764 File Offset: 0x001B6964
		// (set) Token: 0x06007139 RID: 28985 RVA: 0x001B8795 File Offset: 0x001B6995
		[DebuggerNonUserCode]
		public SuggestionRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				SuggestionRemovedReason reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = SuggestionRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.reason_ = value;
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x001B87B0 File Offset: 0x001B69B0
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x001B87CD File Offset: 0x001B69CD
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x001B87E0 File Offset: 0x001B69E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuggestionRemovedNotification);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x001B8800 File Offset: 0x001B6A00
		[DebuggerNonUserCode]
		public bool Equals(SuggestionRemovedNotification other)
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
							bool flag6 = this.SuggestionId != other.SuggestionId;
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

		// Token: 0x0600713E RID: 28990 RVA: 0x001B88B0 File Offset: 0x001B6AB0
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num ^= this.SuggestionId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x001B8960 File Offset: 0x001B6B60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x001B8978 File Offset: 0x001B6B78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x001B8984 File Offset: 0x001B6B84
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				output.WriteRawTag(33);
				output.WriteFixed64(this.SuggestionId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x001B8A3C File Offset: 0x001B6C3C
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num += 9;
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x001B8ADC File Offset: 0x001B6CDC
		[DebuggerNonUserCode]
		public void MergeFrom(SuggestionRemovedNotification other)
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
				bool hasSuggestionId = other.HasSuggestionId;
				if (hasSuggestionId)
				{
					this.SuggestionId = other.SuggestionId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x001B8B9A File Offset: 0x001B6D9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x001B8BA8 File Offset: 0x001B6DA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 24U)
						{
							goto IL_002C;
						}
						this.ClubId = input.ReadUInt64();
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new MemberId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 33U)
				{
					if (num3 != 40U)
					{
						goto IL_002C;
					}
					this.Reason = (SuggestionRemovedReason)input.ReadEnum();
				}
				else
				{
					this.SuggestionId = input.ReadFixed64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040033DF RID: 13279
		private static readonly MessageParser<SuggestionRemovedNotification> _parser = new MessageParser<SuggestionRemovedNotification>(() => new SuggestionRemovedNotification());

		// Token: 0x040033E0 RID: 13280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033E1 RID: 13281
		private int _hasBits0;

		// Token: 0x040033E2 RID: 13282
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033E3 RID: 13283
		private MemberId agentId_;

		// Token: 0x040033E4 RID: 13284
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033E5 RID: 13285
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033E6 RID: 13286
		private ulong clubId_;

		// Token: 0x040033E7 RID: 13287
		public const int SuggestionIdFieldNumber = 4;

		// Token: 0x040033E8 RID: 13288
		private static readonly ulong SuggestionIdDefaultValue = 0UL;

		// Token: 0x040033E9 RID: 13289
		private ulong suggestionId_;

		// Token: 0x040033EA RID: 13290
		public const int ReasonFieldNumber = 5;

		// Token: 0x040033EB RID: 13291
		private static readonly SuggestionRemovedReason ReasonDefaultValue = SuggestionRemovedReason.Approved;

		// Token: 0x040033EC RID: 13292
		private SuggestionRemovedReason reason_;
	}
}
