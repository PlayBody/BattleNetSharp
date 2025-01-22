using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000493 RID: 1171
	public sealed class ClubTypeRangeSet : IMessage<ClubTypeRangeSet>, IMessage, IEquatable<ClubTypeRangeSet>, IDeepCloneable<ClubTypeRangeSet>, IBufferMessage
	{
		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06007223 RID: 29219 RVA: 0x001BC4E4 File Offset: 0x001BA6E4
		[DebuggerNonUserCode]
		public static MessageParser<ClubTypeRangeSet> Parser
		{
			get
			{
				return ClubTypeRangeSet._parser;
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06007224 RID: 29220 RVA: 0x001BC4FC File Offset: 0x001BA6FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06007225 RID: 29221 RVA: 0x001BC520 File Offset: 0x001BA720
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubTypeRangeSet.Descriptor;
			}
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x001BC537 File Offset: 0x001BA737
		[DebuggerNonUserCode]
		public ClubTypeRangeSet()
		{
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x001BC544 File Offset: 0x001BA744
		[DebuggerNonUserCode]
		public ClubTypeRangeSet(ClubTypeRangeSet other)
			: this()
		{
			this.nameRange_ = ((other.nameRange_ != null) ? other.nameRange_.Clone() : null);
			this.descriptionRange_ = ((other.descriptionRange_ != null) ? other.descriptionRange_.Clone() : null);
			this.broadcastRange_ = ((other.broadcastRange_ != null) ? other.broadcastRange_.Clone() : null);
			this.shortNameRange_ = ((other.shortNameRange_ != null) ? other.shortNameRange_.Clone() : null);
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this.stream_ = ((other.stream_ != null) ? other.stream_.Clone() : null);
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this.suggestion_ = ((other.suggestion_ != null) ? other.suggestion_.Clone() : null);
			this.ticket_ = ((other.ticket_ != null) ? other.ticket_.Clone() : null);
			this.ban_ = ((other.ban_ != null) ? other.ban_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x001BC684 File Offset: 0x001BA884
		[DebuggerNonUserCode]
		public ClubTypeRangeSet Clone()
		{
			return new ClubTypeRangeSet(this);
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x001BC69C File Offset: 0x001BA89C
		// (set) Token: 0x0600722A RID: 29226 RVA: 0x001BC6B4 File Offset: 0x001BA8B4
		[DebuggerNonUserCode]
		public UnsignedIntRange NameRange
		{
			get
			{
				return this.nameRange_;
			}
			set
			{
				this.nameRange_ = value;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x001BC6C0 File Offset: 0x001BA8C0
		// (set) Token: 0x0600722C RID: 29228 RVA: 0x001BC6D8 File Offset: 0x001BA8D8
		[DebuggerNonUserCode]
		public UnsignedIntRange DescriptionRange
		{
			get
			{
				return this.descriptionRange_;
			}
			set
			{
				this.descriptionRange_ = value;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x001BC6E4 File Offset: 0x001BA8E4
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x001BC6FC File Offset: 0x001BA8FC
		[DebuggerNonUserCode]
		public UnsignedIntRange BroadcastRange
		{
			get
			{
				return this.broadcastRange_;
			}
			set
			{
				this.broadcastRange_ = value;
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x001BC708 File Offset: 0x001BA908
		// (set) Token: 0x06007230 RID: 29232 RVA: 0x001BC720 File Offset: 0x001BA920
		[DebuggerNonUserCode]
		public UnsignedIntRange ShortNameRange
		{
			get
			{
				return this.shortNameRange_;
			}
			set
			{
				this.shortNameRange_ = value;
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x001BC72C File Offset: 0x001BA92C
		// (set) Token: 0x06007232 RID: 29234 RVA: 0x001BC744 File Offset: 0x001BA944
		[DebuggerNonUserCode]
		public ClubMemberRangeSet Member
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

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06007233 RID: 29235 RVA: 0x001BC750 File Offset: 0x001BA950
		// (set) Token: 0x06007234 RID: 29236 RVA: 0x001BC768 File Offset: 0x001BA968
		[DebuggerNonUserCode]
		public ClubStreamRangeSet Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x001BC774 File Offset: 0x001BA974
		// (set) Token: 0x06007236 RID: 29238 RVA: 0x001BC78C File Offset: 0x001BA98C
		[DebuggerNonUserCode]
		public ClubInvitationRangeSet Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x001BC798 File Offset: 0x001BA998
		// (set) Token: 0x06007238 RID: 29240 RVA: 0x001BC7B0 File Offset: 0x001BA9B0
		[DebuggerNonUserCode]
		public ClubSuggestionRangeSet Suggestion
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

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x001BC7BC File Offset: 0x001BA9BC
		// (set) Token: 0x0600723A RID: 29242 RVA: 0x001BC7D4 File Offset: 0x001BA9D4
		[DebuggerNonUserCode]
		public ClubTicketRangeSet Ticket
		{
			get
			{
				return this.ticket_;
			}
			set
			{
				this.ticket_ = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x001BC7E0 File Offset: 0x001BA9E0
		// (set) Token: 0x0600723C RID: 29244 RVA: 0x001BC7F8 File Offset: 0x001BA9F8
		[DebuggerNonUserCode]
		public ClubBanRangeSet Ban
		{
			get
			{
				return this.ban_;
			}
			set
			{
				this.ban_ = value;
			}
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x001BC804 File Offset: 0x001BAA04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubTypeRangeSet);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x001BC824 File Offset: 0x001BAA24
		[DebuggerNonUserCode]
		public bool Equals(ClubTypeRangeSet other)
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
					bool flag4 = !object.Equals(this.NameRange, other.NameRange);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.DescriptionRange, other.DescriptionRange);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.BroadcastRange, other.BroadcastRange);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ShortNameRange, other.ShortNameRange);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Member, other.Member);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Stream, other.Stream);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Invitation, other.Invitation);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Suggestion, other.Suggestion);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Ticket, other.Ticket);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.Ban, other.Ban);
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600723F RID: 29247 RVA: 0x001BC9A4 File Offset: 0x001BABA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.nameRange_ != null;
			if (flag)
			{
				num ^= this.NameRange.GetHashCode();
			}
			bool flag2 = this.descriptionRange_ != null;
			if (flag2)
			{
				num ^= this.DescriptionRange.GetHashCode();
			}
			bool flag3 = this.broadcastRange_ != null;
			if (flag3)
			{
				num ^= this.BroadcastRange.GetHashCode();
			}
			bool flag4 = this.shortNameRange_ != null;
			if (flag4)
			{
				num ^= this.ShortNameRange.GetHashCode();
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag6 = this.stream_ != null;
			if (flag6)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool flag7 = this.invitation_ != null;
			if (flag7)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag8 = this.suggestion_ != null;
			if (flag8)
			{
				num ^= this.Suggestion.GetHashCode();
			}
			bool flag9 = this.ticket_ != null;
			if (flag9)
			{
				num ^= this.Ticket.GetHashCode();
			}
			bool flag10 = this.ban_ != null;
			if (flag10)
			{
				num ^= this.Ban.GetHashCode();
			}
			bool flag11 = this._unknownFields != null;
			if (flag11)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x001BCAF8 File Offset: 0x001BACF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x001BCB10 File Offset: 0x001BAD10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x001BCB1C File Offset: 0x001BAD1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.nameRange_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NameRange);
			}
			bool flag2 = this.descriptionRange_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DescriptionRange);
			}
			bool flag3 = this.broadcastRange_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BroadcastRange);
			}
			bool flag4 = this.shortNameRange_ != null;
			if (flag4)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ShortNameRange);
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.Member);
			}
			bool flag6 = this.stream_ != null;
			if (flag6)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.Stream);
			}
			bool flag7 = this.invitation_ != null;
			if (flag7)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.Invitation);
			}
			bool flag8 = this.suggestion_ != null;
			if (flag8)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.Suggestion);
			}
			bool flag9 = this.ticket_ != null;
			if (flag9)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.Ticket);
			}
			bool flag10 = this.ban_ != null;
			if (flag10)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.Ban);
			}
			bool flag11 = this._unknownFields != null;
			if (flag11)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x001BCCE0 File Offset: 0x001BAEE0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.nameRange_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NameRange);
			}
			bool flag2 = this.descriptionRange_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DescriptionRange);
			}
			bool flag3 = this.broadcastRange_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BroadcastRange);
			}
			bool flag4 = this.shortNameRange_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShortNameRange);
			}
			bool flag5 = this.member_ != null;
			if (flag5)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag6 = this.stream_ != null;
			if (flag6)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Stream);
			}
			bool flag7 = this.invitation_ != null;
			if (flag7)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag8 = this.suggestion_ != null;
			if (flag8)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Suggestion);
			}
			bool flag9 = this.ticket_ != null;
			if (flag9)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Ticket);
			}
			bool flag10 = this.ban_ != null;
			if (flag10)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Ban);
			}
			bool flag11 = this._unknownFields != null;
			if (flag11)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x001BCE5C File Offset: 0x001BB05C
		[DebuggerNonUserCode]
		public void MergeFrom(ClubTypeRangeSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.nameRange_ != null;
				if (flag2)
				{
					bool flag3 = this.nameRange_ == null;
					if (flag3)
					{
						this.NameRange = new UnsignedIntRange();
					}
					this.NameRange.MergeFrom(other.NameRange);
				}
				bool flag4 = other.descriptionRange_ != null;
				if (flag4)
				{
					bool flag5 = this.descriptionRange_ == null;
					if (flag5)
					{
						this.DescriptionRange = new UnsignedIntRange();
					}
					this.DescriptionRange.MergeFrom(other.DescriptionRange);
				}
				bool flag6 = other.broadcastRange_ != null;
				if (flag6)
				{
					bool flag7 = this.broadcastRange_ == null;
					if (flag7)
					{
						this.BroadcastRange = new UnsignedIntRange();
					}
					this.BroadcastRange.MergeFrom(other.BroadcastRange);
				}
				bool flag8 = other.shortNameRange_ != null;
				if (flag8)
				{
					bool flag9 = this.shortNameRange_ == null;
					if (flag9)
					{
						this.ShortNameRange = new UnsignedIntRange();
					}
					this.ShortNameRange.MergeFrom(other.ShortNameRange);
				}
				bool flag10 = other.member_ != null;
				if (flag10)
				{
					bool flag11 = this.member_ == null;
					if (flag11)
					{
						this.Member = new ClubMemberRangeSet();
					}
					this.Member.MergeFrom(other.Member);
				}
				bool flag12 = other.stream_ != null;
				if (flag12)
				{
					bool flag13 = this.stream_ == null;
					if (flag13)
					{
						this.Stream = new ClubStreamRangeSet();
					}
					this.Stream.MergeFrom(other.Stream);
				}
				bool flag14 = other.invitation_ != null;
				if (flag14)
				{
					bool flag15 = this.invitation_ == null;
					if (flag15)
					{
						this.Invitation = new ClubInvitationRangeSet();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				bool flag16 = other.suggestion_ != null;
				if (flag16)
				{
					bool flag17 = this.suggestion_ == null;
					if (flag17)
					{
						this.Suggestion = new ClubSuggestionRangeSet();
					}
					this.Suggestion.MergeFrom(other.Suggestion);
				}
				bool flag18 = other.ticket_ != null;
				if (flag18)
				{
					bool flag19 = this.ticket_ == null;
					if (flag19)
					{
						this.Ticket = new ClubTicketRangeSet();
					}
					this.Ticket.MergeFrom(other.Ticket);
				}
				bool flag20 = other.ban_ != null;
				if (flag20)
				{
					bool flag21 = this.ban_ == null;
					if (flag21)
					{
						this.Ban = new ClubBanRangeSet();
					}
					this.Ban.MergeFrom(other.Ban);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x001BD109 File Offset: 0x001BB309
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x001BD114 File Offset: 0x001BB314
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 202U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0096;
							}
							bool flag = this.descriptionRange_ == null;
							if (flag)
							{
								this.DescriptionRange = new UnsignedIntRange();
							}
							input.ReadMessage(this.DescriptionRange);
						}
						else
						{
							bool flag2 = this.nameRange_ == null;
							if (flag2)
							{
								this.NameRange = new UnsignedIntRange();
							}
							input.ReadMessage(this.NameRange);
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 58U)
						{
							if (num3 != 202U)
							{
								goto IL_0096;
							}
							bool flag3 = this.member_ == null;
							if (flag3)
							{
								this.Member = new ClubMemberRangeSet();
							}
							input.ReadMessage(this.Member);
						}
						else
						{
							bool flag4 = this.shortNameRange_ == null;
							if (flag4)
							{
								this.ShortNameRange = new UnsignedIntRange();
							}
							input.ReadMessage(this.ShortNameRange);
						}
					}
					else
					{
						bool flag5 = this.broadcastRange_ == null;
						if (flag5)
						{
							this.BroadcastRange = new UnsignedIntRange();
						}
						input.ReadMessage(this.BroadcastRange);
					}
				}
				else if (num3 <= 218U)
				{
					if (num3 != 210U)
					{
						if (num3 != 218U)
						{
							goto IL_0096;
						}
						bool flag6 = this.invitation_ == null;
						if (flag6)
						{
							this.Invitation = new ClubInvitationRangeSet();
						}
						input.ReadMessage(this.Invitation);
					}
					else
					{
						bool flag7 = this.stream_ == null;
						if (flag7)
						{
							this.Stream = new ClubStreamRangeSet();
						}
						input.ReadMessage(this.Stream);
					}
				}
				else if (num3 != 226U)
				{
					if (num3 != 234U)
					{
						if (num3 != 242U)
						{
							goto IL_0096;
						}
						bool flag8 = this.ban_ == null;
						if (flag8)
						{
							this.Ban = new ClubBanRangeSet();
						}
						input.ReadMessage(this.Ban);
					}
					else
					{
						bool flag9 = this.ticket_ == null;
						if (flag9)
						{
							this.Ticket = new ClubTicketRangeSet();
						}
						input.ReadMessage(this.Ticket);
					}
				}
				else
				{
					bool flag10 = this.suggestion_ == null;
					if (flag10)
					{
						this.Suggestion = new ClubSuggestionRangeSet();
					}
					input.ReadMessage(this.Suggestion);
				}
				continue;
				IL_0096:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400344F RID: 13391
		private static readonly MessageParser<ClubTypeRangeSet> _parser = new MessageParser<ClubTypeRangeSet>(() => new ClubTypeRangeSet());

		// Token: 0x04003450 RID: 13392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003451 RID: 13393
		public const int NameRangeFieldNumber = 2;

		// Token: 0x04003452 RID: 13394
		private UnsignedIntRange nameRange_;

		// Token: 0x04003453 RID: 13395
		public const int DescriptionRangeFieldNumber = 3;

		// Token: 0x04003454 RID: 13396
		private UnsignedIntRange descriptionRange_;

		// Token: 0x04003455 RID: 13397
		public const int BroadcastRangeFieldNumber = 4;

		// Token: 0x04003456 RID: 13398
		private UnsignedIntRange broadcastRange_;

		// Token: 0x04003457 RID: 13399
		public const int ShortNameRangeFieldNumber = 7;

		// Token: 0x04003458 RID: 13400
		private UnsignedIntRange shortNameRange_;

		// Token: 0x04003459 RID: 13401
		public const int MemberFieldNumber = 25;

		// Token: 0x0400345A RID: 13402
		private ClubMemberRangeSet member_;

		// Token: 0x0400345B RID: 13403
		public const int StreamFieldNumber = 26;

		// Token: 0x0400345C RID: 13404
		private ClubStreamRangeSet stream_;

		// Token: 0x0400345D RID: 13405
		public const int InvitationFieldNumber = 27;

		// Token: 0x0400345E RID: 13406
		private ClubInvitationRangeSet invitation_;

		// Token: 0x0400345F RID: 13407
		public const int SuggestionFieldNumber = 28;

		// Token: 0x04003460 RID: 13408
		private ClubSuggestionRangeSet suggestion_;

		// Token: 0x04003461 RID: 13409
		public const int TicketFieldNumber = 29;

		// Token: 0x04003462 RID: 13410
		private ClubTicketRangeSet ticket_;

		// Token: 0x04003463 RID: 13411
		public const int BanFieldNumber = 30;

		// Token: 0x04003464 RID: 13412
		private ClubBanRangeSet ban_;
	}
}
