using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000488 RID: 1160
	public sealed class SuggestionAddedNotification : IMessage<SuggestionAddedNotification>, IMessage, IEquatable<SuggestionAddedNotification>, IDeepCloneable<SuggestionAddedNotification>, IBufferMessage
	{
		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600710F RID: 28943 RVA: 0x001B7F64 File Offset: 0x001B6164
		[DebuggerNonUserCode]
		public static MessageParser<SuggestionAddedNotification> Parser
		{
			get
			{
				return SuggestionAddedNotification._parser;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x06007110 RID: 28944 RVA: 0x001B7F7C File Offset: 0x001B617C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x001B7FA0 File Offset: 0x001B61A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuggestionAddedNotification.Descriptor;
			}
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x001B7FB7 File Offset: 0x001B61B7
		[DebuggerNonUserCode]
		public SuggestionAddedNotification()
		{
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x001B7FC4 File Offset: 0x001B61C4
		[DebuggerNonUserCode]
		public SuggestionAddedNotification(SuggestionAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.suggestion_ = ((other.suggestion_ != null) ? other.suggestion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x001B803C File Offset: 0x001B623C
		[DebuggerNonUserCode]
		public SuggestionAddedNotification Clone()
		{
			return new SuggestionAddedNotification(this);
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x06007115 RID: 28949 RVA: 0x001B8054 File Offset: 0x001B6254
		// (set) Token: 0x06007116 RID: 28950 RVA: 0x001B806C File Offset: 0x001B626C
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

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x001B8078 File Offset: 0x001B6278
		// (set) Token: 0x06007118 RID: 28952 RVA: 0x001B80A9 File Offset: 0x001B62A9
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
					clubIdDefaultValue = SuggestionAddedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x001B80C4 File Offset: 0x001B62C4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x001B80E1 File Offset: 0x001B62E1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600711B RID: 28955 RVA: 0x001B80F4 File Offset: 0x001B62F4
		// (set) Token: 0x0600711C RID: 28956 RVA: 0x001B810C File Offset: 0x001B630C
		[DebuggerNonUserCode]
		public ClubSuggestion Suggestion
		{
			get
			{
				return this.suggestion_;
			}
			set
			{
				this.suggestion_ = value;
			}
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x001B8118 File Offset: 0x001B6318
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuggestionAddedNotification);
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x001B8138 File Offset: 0x001B6338
		[DebuggerNonUserCode]
		public bool Equals(SuggestionAddedNotification other)
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
							bool flag6 = !object.Equals(this.Suggestion, other.Suggestion);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x001B81CC File Offset: 0x001B63CC
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
			bool flag2 = this.suggestion_ != null;
			if (flag2)
			{
				num ^= this.Suggestion.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x001B8258 File Offset: 0x001B6458
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x001B8270 File Offset: 0x001B6470
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x001B827C File Offset: 0x001B647C
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
			bool flag2 = this.suggestion_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Suggestion);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x001B8314 File Offset: 0x001B6514
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
			bool flag2 = this.suggestion_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestion);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x001B83A4 File Offset: 0x001B65A4
		[DebuggerNonUserCode]
		public void MergeFrom(SuggestionAddedNotification other)
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
				bool flag4 = other.suggestion_ != null;
				if (flag4)
				{
					bool flag5 = this.suggestion_ == null;
					if (flag5)
					{
						this.Suggestion = new ClubSuggestion();
					}
					this.Suggestion.MergeFrom(other.Suggestion);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x001B846C File Offset: 0x001B666C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x001B8478 File Offset: 0x001B6678
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
					if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.suggestion_ == null;
							if (flag)
							{
								this.Suggestion = new ClubSuggestion();
							}
							input.ReadMessage(this.Suggestion);
						}
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
		}

		// Token: 0x040033D5 RID: 13269
		private static readonly MessageParser<SuggestionAddedNotification> _parser = new MessageParser<SuggestionAddedNotification>(() => new SuggestionAddedNotification());

		// Token: 0x040033D6 RID: 13270
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D7 RID: 13271
		private int _hasBits0;

		// Token: 0x040033D8 RID: 13272
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033D9 RID: 13273
		private MemberId agentId_;

		// Token: 0x040033DA RID: 13274
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033DB RID: 13275
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033DC RID: 13276
		private ulong clubId_;

		// Token: 0x040033DD RID: 13277
		public const int SuggestionFieldNumber = 4;

		// Token: 0x040033DE RID: 13278
		private ClubSuggestion suggestion_;
	}
}
