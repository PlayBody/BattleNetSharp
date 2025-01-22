using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048D RID: 1165
	public sealed class StreamMessageAddedNotification : IMessage<StreamMessageAddedNotification>, IMessage, IEquatable<StreamMessageAddedNotification>, IDeepCloneable<StreamMessageAddedNotification>, IBufferMessage
	{
		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06007198 RID: 29080 RVA: 0x001B9FC4 File Offset: 0x001B81C4
		[DebuggerNonUserCode]
		public static MessageParser<StreamMessageAddedNotification> Parser
		{
			get
			{
				return StreamMessageAddedNotification._parser;
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x001B9FDC File Offset: 0x001B81DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x001BA000 File Offset: 0x001B8200
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMessageAddedNotification.Descriptor;
			}
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x001BA017 File Offset: 0x001B8217
		[DebuggerNonUserCode]
		public StreamMessageAddedNotification()
		{
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x001BA024 File Offset: 0x001B8224
		[DebuggerNonUserCode]
		public StreamMessageAddedNotification(StreamMessageAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x001BA0A8 File Offset: 0x001B82A8
		[DebuggerNonUserCode]
		public StreamMessageAddedNotification Clone()
		{
			return new StreamMessageAddedNotification(this);
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600719E RID: 29086 RVA: 0x001BA0C0 File Offset: 0x001B82C0
		// (set) Token: 0x0600719F RID: 29087 RVA: 0x001BA0D8 File Offset: 0x001B82D8
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

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x001BA0E4 File Offset: 0x001B82E4
		// (set) Token: 0x060071A1 RID: 29089 RVA: 0x001BA115 File Offset: 0x001B8315
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
					clubIdDefaultValue = StreamMessageAddedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x001BA130 File Offset: 0x001B8330
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060071A3 RID: 29091 RVA: 0x001BA14D File Offset: 0x001B834D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x001BA160 File Offset: 0x001B8360
		// (set) Token: 0x060071A5 RID: 29093 RVA: 0x001BA191 File Offset: 0x001B8391
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
					streamIdDefaultValue = StreamMessageAddedNotification.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x001BA1AC File Offset: 0x001B83AC
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x001BA1C9 File Offset: 0x001B83C9
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x001BA1DC File Offset: 0x001B83DC
		// (set) Token: 0x060071A9 RID: 29097 RVA: 0x001BA1F4 File Offset: 0x001B83F4
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

		// Token: 0x060071AA RID: 29098 RVA: 0x001BA200 File Offset: 0x001B8400
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMessageAddedNotification);
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x001BA220 File Offset: 0x001B8420
		[DebuggerNonUserCode]
		public bool Equals(StreamMessageAddedNotification other)
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
								bool flag7 = !object.Equals(this.Message, other.Message);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x001BA2D4 File Offset: 0x001B84D4
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
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x001BA37C File Offset: 0x001B857C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x001BA394 File Offset: 0x001B8594
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x001BA3A0 File Offset: 0x001B85A0
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.StreamId);
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Message);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x001BA45C File Offset: 0x001B865C
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
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x001BA50C File Offset: 0x001B870C
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMessageAddedNotification other)
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
				bool flag4 = other.message_ != null;
				if (flag4)
				{
					bool flag5 = this.message_ == null;
					if (flag5)
					{
						this.Message = new StreamMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x001BA5EF File Offset: 0x001B87EF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x001BA5FC File Offset: 0x001B87FC
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
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						goto IL_002C;
					}
					bool flag2 = this.message_ == null;
					if (flag2)
					{
						this.Message = new StreamMessage();
					}
					input.ReadMessage(this.Message);
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400340F RID: 13327
		private static readonly MessageParser<StreamMessageAddedNotification> _parser = new MessageParser<StreamMessageAddedNotification>(() => new StreamMessageAddedNotification());

		// Token: 0x04003410 RID: 13328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003411 RID: 13329
		private int _hasBits0;

		// Token: 0x04003412 RID: 13330
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003413 RID: 13331
		private MemberId agentId_;

		// Token: 0x04003414 RID: 13332
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003415 RID: 13333
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003416 RID: 13334
		private ulong clubId_;

		// Token: 0x04003417 RID: 13335
		public const int StreamIdFieldNumber = 4;

		// Token: 0x04003418 RID: 13336
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003419 RID: 13337
		private ulong streamId_;

		// Token: 0x0400341A RID: 13338
		public const int MessageFieldNumber = 5;

		// Token: 0x0400341B RID: 13339
		private StreamMessage message_;
	}
}
