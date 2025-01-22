using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DE RID: 1246
	public sealed class EditMessageRequest : IMessage<EditMessageRequest>, IMessage, IEquatable<EditMessageRequest>, IDeepCloneable<EditMessageRequest>, IBufferMessage
	{
		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x001D7034 File Offset: 0x001D5234
		[DebuggerNonUserCode]
		public static MessageParser<EditMessageRequest> Parser
		{
			get
			{
				return EditMessageRequest._parser;
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x001D704C File Offset: 0x001D524C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[67];
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x001D7070 File Offset: 0x001D5270
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EditMessageRequest.Descriptor;
			}
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x001D7087 File Offset: 0x001D5287
		[DebuggerNonUserCode]
		public EditMessageRequest()
		{
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x001D7094 File Offset: 0x001D5294
		[DebuggerNonUserCode]
		public EditMessageRequest(EditMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.messageId_ = ((other.messageId_ != null) ? other.messageId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x001D7134 File Offset: 0x001D5334
		[DebuggerNonUserCode]
		public EditMessageRequest Clone()
		{
			return new EditMessageRequest(this);
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x001D714C File Offset: 0x001D534C
		// (set) Token: 0x06007927 RID: 31015 RVA: 0x001D7164 File Offset: 0x001D5364
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

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x06007928 RID: 31016 RVA: 0x001D7170 File Offset: 0x001D5370
		// (set) Token: 0x06007929 RID: 31017 RVA: 0x001D71A1 File Offset: 0x001D53A1
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
					clubIdDefaultValue = EditMessageRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x001D71BC File Offset: 0x001D53BC
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x001D71D9 File Offset: 0x001D53D9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x001D71EC File Offset: 0x001D53EC
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x001D721D File Offset: 0x001D541D
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
					streamIdDefaultValue = EditMessageRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x001D7238 File Offset: 0x001D5438
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x001D7255 File Offset: 0x001D5455
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x001D7268 File Offset: 0x001D5468
		// (set) Token: 0x06007931 RID: 31025 RVA: 0x001D7280 File Offset: 0x001D5480
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

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x001D728C File Offset: 0x001D548C
		// (set) Token: 0x06007933 RID: 31027 RVA: 0x001D72A4 File Offset: 0x001D54A4
		[DebuggerNonUserCode]
		public CreateMessageOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x001D72B0 File Offset: 0x001D54B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EditMessageRequest);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x001D72D0 File Offset: 0x001D54D0
		[DebuggerNonUserCode]
		public bool Equals(EditMessageRequest other)
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
							bool flag6 = this.StreamId != other.StreamId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.MessageId, other.MessageId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Options, other.Options);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x001D73A4 File Offset: 0x001D55A4
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num ^= this.MessageId.GetHashCode();
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x001D7468 File Offset: 0x001D5668
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x001D7480 File Offset: 0x001D5680
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x001D748C File Offset: 0x001D568C
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
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.StreamId);
			}
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MessageId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x001D7570 File Offset: 0x001D5770
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x001D7640 File Offset: 0x001D5840
		[DebuggerNonUserCode]
		public void MergeFrom(EditMessageRequest other)
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
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool flag4 = other.messageId_ != null;
				if (flag4)
				{
					bool flag5 = this.messageId_ == null;
					if (flag5)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				bool flag6 = other.options_ != null;
				if (flag6)
				{
					bool flag7 = this.options_ == null;
					if (flag7)
					{
						this.Options = new CreateMessageOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x001D7763 File Offset: 0x001D5963
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x001D7770 File Offset: 0x001D5970
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0036;
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0036;
						}
						bool flag2 = this.options_ == null;
						if (flag2)
						{
							this.Options = new CreateMessageOptions();
						}
						input.ReadMessage(this.Options);
					}
					else
					{
						bool flag3 = this.messageId_ == null;
						if (flag3)
						{
							this.MessageId = new MessageId();
						}
						input.ReadMessage(this.MessageId);
					}
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
				continue;
				IL_0036:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036F3 RID: 14067
		private static readonly MessageParser<EditMessageRequest> _parser = new MessageParser<EditMessageRequest>(() => new EditMessageRequest());

		// Token: 0x040036F4 RID: 14068
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F5 RID: 14069
		private int _hasBits0;

		// Token: 0x040036F6 RID: 14070
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036F7 RID: 14071
		private MemberId agentId_;

		// Token: 0x040036F8 RID: 14072
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036F9 RID: 14073
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036FA RID: 14074
		private ulong clubId_;

		// Token: 0x040036FB RID: 14075
		public const int StreamIdFieldNumber = 3;

		// Token: 0x040036FC RID: 14076
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040036FD RID: 14077
		private ulong streamId_;

		// Token: 0x040036FE RID: 14078
		public const int MessageIdFieldNumber = 4;

		// Token: 0x040036FF RID: 14079
		private MessageId messageId_;

		// Token: 0x04003700 RID: 14080
		public const int OptionsFieldNumber = 5;

		// Token: 0x04003701 RID: 14081
		private CreateMessageOptions options_;
	}
}
