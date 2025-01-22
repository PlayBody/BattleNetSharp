using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FD RID: 1277
	public sealed class StreamMention : IMessage<StreamMention>, IMessage, IEquatable<StreamMention>, IDeepCloneable<StreamMention>, IBufferMessage
	{
		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x001E63F0 File Offset: 0x001E45F0
		[DebuggerNonUserCode]
		public static MessageParser<StreamMention> Parser
		{
			get
			{
				return StreamMention._parser;
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x001E6408 File Offset: 0x001E4608
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x001E642C File Offset: 0x001E462C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMention.Descriptor;
			}
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x001E6443 File Offset: 0x001E4643
		[DebuggerNonUserCode]
		public StreamMention()
		{
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x001E6450 File Offset: 0x001E4650
		[DebuggerNonUserCode]
		public StreamMention(StreamMention other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.messageId_ = ((other.messageId_ != null) ? other.messageId_.Clone() : null);
			this.author_ = ((other.author_ != null) ? other.author_.Clone() : null);
			this.destroyed_ = other.destroyed_;
			this.mentionId_ = ((other.mentionId_ != null) ? other.mentionId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this.clubType_ = ((other.clubType_ != null) ? other.clubType_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x001E6550 File Offset: 0x001E4750
		[DebuggerNonUserCode]
		public StreamMention Clone()
		{
			return new StreamMention(this);
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x06007CDE RID: 31966 RVA: 0x001E6568 File Offset: 0x001E4768
		// (set) Token: 0x06007CDF RID: 31967 RVA: 0x001E6599 File Offset: 0x001E4799
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
					clubIdDefaultValue = StreamMention.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x001E65B4 File Offset: 0x001E47B4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x001E65D1 File Offset: 0x001E47D1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x06007CE2 RID: 31970 RVA: 0x001E65E4 File Offset: 0x001E47E4
		// (set) Token: 0x06007CE3 RID: 31971 RVA: 0x001E6615 File Offset: 0x001E4815
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = StreamMention.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x001E6630 File Offset: 0x001E4830
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x001E664D File Offset: 0x001E484D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x001E6660 File Offset: 0x001E4860
		// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x001E6678 File Offset: 0x001E4878
		[DebuggerNonUserCode]
		public MessageId MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x001E6684 File Offset: 0x001E4884
		// (set) Token: 0x06007CE9 RID: 31977 RVA: 0x001E669C File Offset: 0x001E489C
		[DebuggerNonUserCode]
		public MemberDescription Author
		{
			get
			{
				return this.author_;
			}
			set
			{
				this.author_ = value;
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06007CEA RID: 31978 RVA: 0x001E66A8 File Offset: 0x001E48A8
		// (set) Token: 0x06007CEB RID: 31979 RVA: 0x001E66D9 File Offset: 0x001E48D9
		[DebuggerNonUserCode]
		public bool Destroyed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool destroyedDefaultValue;
				if (flag)
				{
					destroyedDefaultValue = this.destroyed_;
				}
				else
				{
					destroyedDefaultValue = StreamMention.DestroyedDefaultValue;
				}
				return destroyedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.destroyed_ = value;
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x001E66F4 File Offset: 0x001E48F4
		[DebuggerNonUserCode]
		public bool HasDestroyed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x001E6711 File Offset: 0x001E4911
		[DebuggerNonUserCode]
		public void ClearDestroyed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06007CEE RID: 31982 RVA: 0x001E6724 File Offset: 0x001E4924
		// (set) Token: 0x06007CEF RID: 31983 RVA: 0x001E673C File Offset: 0x001E493C
		[DebuggerNonUserCode]
		public TimeSeriesId MentionId
		{
			get
			{
				return this.mentionId_;
			}
			set
			{
				this.mentionId_ = value;
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x001E6748 File Offset: 0x001E4948
		// (set) Token: 0x06007CF1 RID: 31985 RVA: 0x001E6760 File Offset: 0x001E4960
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

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x06007CF2 RID: 31986 RVA: 0x001E676C File Offset: 0x001E496C
		// (set) Token: 0x06007CF3 RID: 31987 RVA: 0x001E6784 File Offset: 0x001E4984
		[DebuggerNonUserCode]
		public StreamMessage Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x06007CF4 RID: 31988 RVA: 0x001E6790 File Offset: 0x001E4990
		// (set) Token: 0x06007CF5 RID: 31989 RVA: 0x001E67A8 File Offset: 0x001E49A8
		[DebuggerNonUserCode]
		public UniqueClubType ClubType
		{
			get
			{
				return this.clubType_;
			}
			set
			{
				this.clubType_ = value;
			}
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x001E67B4 File Offset: 0x001E49B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMention);
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x001E67D4 File Offset: 0x001E49D4
		[DebuggerNonUserCode]
		public bool Equals(StreamMention other)
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
					bool flag4 = this.ClubId != other.ClubId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StreamId != other.StreamId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.MessageId, other.MessageId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Author, other.Author);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Destroyed != other.Destroyed;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.MentionId, other.MentionId);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.MemberId, other.MemberId);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Message, other.Message);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.ClubType, other.ClubType);
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06007CF8 RID: 31992 RVA: 0x001E692C File Offset: 0x001E4B2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool flag = this.messageId_ != null;
			if (flag)
			{
				num ^= this.MessageId.GetHashCode();
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				num ^= this.Author.GetHashCode();
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				num ^= this.Destroyed.GetHashCode();
			}
			bool flag3 = this.mentionId_ != null;
			if (flag3)
			{
				num ^= this.MentionId.GetHashCode();
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag5 = this.message_ != null;
			if (flag5)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag6 = this.clubType_ != null;
			if (flag6)
			{
				num ^= this.ClubType.GetHashCode();
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x001E6A64 File Offset: 0x001E4C64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x001E6A7C File Offset: 0x001E4C7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x001E6A88 File Offset: 0x001E4C88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StreamId);
			}
			bool flag = this.messageId_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MessageId);
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Author);
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Destroyed);
			}
			bool flag3 = this.mentionId_ != null;
			if (flag3)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MentionId);
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MemberId);
			}
			bool flag5 = this.message_ != null;
			if (flag5)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Message);
			}
			bool flag6 = this.clubType_ != null;
			if (flag6)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ClubType);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x001E6C04 File Offset: 0x001E4E04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool flag = this.messageId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Author);
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				num += 2;
			}
			bool flag3 = this.mentionId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MentionId);
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag5 = this.message_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag6 = this.clubType_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClubType);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x001E6D48 File Offset: 0x001E4F48
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMention other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool flag2 = other.messageId_ != null;
				if (flag2)
				{
					bool flag3 = this.messageId_ == null;
					if (flag3)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				bool flag4 = other.author_ != null;
				if (flag4)
				{
					bool flag5 = this.author_ == null;
					if (flag5)
					{
						this.Author = new MemberDescription();
					}
					this.Author.MergeFrom(other.Author);
				}
				bool hasDestroyed = other.HasDestroyed;
				if (hasDestroyed)
				{
					this.Destroyed = other.Destroyed;
				}
				bool flag6 = other.mentionId_ != null;
				if (flag6)
				{
					bool flag7 = this.mentionId_ == null;
					if (flag7)
					{
						this.MentionId = new TimeSeriesId();
					}
					this.MentionId.MergeFrom(other.MentionId);
				}
				bool flag8 = other.memberId_ != null;
				if (flag8)
				{
					bool flag9 = this.memberId_ == null;
					if (flag9)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool flag10 = other.message_ != null;
				if (flag10)
				{
					bool flag11 = this.message_ == null;
					if (flag11)
					{
						this.Message = new StreamMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				bool flag12 = other.clubType_ != null;
				if (flag12)
				{
					bool flag13 = this.clubType_ == null;
					if (flag13)
					{
						this.ClubType = new UniqueClubType();
					}
					this.ClubType.MergeFrom(other.ClubType);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x001E6F46 File Offset: 0x001E5146
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x001E6F54 File Offset: 0x001E5154
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
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006D;
							}
							this.StreamId = input.ReadUInt64();
						}
						else
						{
							this.ClubId = input.ReadUInt64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_006D;
						}
						bool flag = this.author_ == null;
						if (flag)
						{
							this.Author = new MemberDescription();
						}
						input.ReadMessage(this.Author);
					}
					else
					{
						bool flag2 = this.messageId_ == null;
						if (flag2)
						{
							this.MessageId = new MessageId();
						}
						input.ReadMessage(this.MessageId);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_006D;
						}
						bool flag3 = this.mentionId_ == null;
						if (flag3)
						{
							this.MentionId = new TimeSeriesId();
						}
						input.ReadMessage(this.MentionId);
					}
					else
					{
						this.Destroyed = input.ReadBool();
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						if (num3 != 74U)
						{
							goto IL_006D;
						}
						bool flag4 = this.clubType_ == null;
						if (flag4)
						{
							this.ClubType = new UniqueClubType();
						}
						input.ReadMessage(this.ClubType);
					}
					else
					{
						bool flag5 = this.message_ == null;
						if (flag5)
						{
							this.Message = new StreamMessage();
						}
						input.ReadMessage(this.Message);
					}
				}
				else
				{
					bool flag6 = this.memberId_ == null;
					if (flag6)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
				continue;
				IL_006D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038C7 RID: 14535
		private static readonly MessageParser<StreamMention> _parser = new MessageParser<StreamMention>(() => new StreamMention());

		// Token: 0x040038C8 RID: 14536
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038C9 RID: 14537
		private int _hasBits0;

		// Token: 0x040038CA RID: 14538
		public const int ClubIdFieldNumber = 1;

		// Token: 0x040038CB RID: 14539
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040038CC RID: 14540
		private ulong clubId_;

		// Token: 0x040038CD RID: 14541
		public const int StreamIdFieldNumber = 2;

		// Token: 0x040038CE RID: 14542
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040038CF RID: 14543
		private ulong streamId_;

		// Token: 0x040038D0 RID: 14544
		public const int MessageIdFieldNumber = 3;

		// Token: 0x040038D1 RID: 14545
		private MessageId messageId_;

		// Token: 0x040038D2 RID: 14546
		public const int AuthorFieldNumber = 4;

		// Token: 0x040038D3 RID: 14547
		private MemberDescription author_;

		// Token: 0x040038D4 RID: 14548
		public const int DestroyedFieldNumber = 5;

		// Token: 0x040038D5 RID: 14549
		private static readonly bool DestroyedDefaultValue = false;

		// Token: 0x040038D6 RID: 14550
		private bool destroyed_;

		// Token: 0x040038D7 RID: 14551
		public const int MentionIdFieldNumber = 6;

		// Token: 0x040038D8 RID: 14552
		private TimeSeriesId mentionId_;

		// Token: 0x040038D9 RID: 14553
		public const int MemberIdFieldNumber = 7;

		// Token: 0x040038DA RID: 14554
		private MemberId memberId_;

		// Token: 0x040038DB RID: 14555
		public const int MessageFieldNumber = 8;

		// Token: 0x040038DC RID: 14556
		private StreamMessage message_;

		// Token: 0x040038DD RID: 14557
		public const int ClubTypeFieldNumber = 9;

		// Token: 0x040038DE RID: 14558
		private UniqueClubType clubType_;
	}
}
