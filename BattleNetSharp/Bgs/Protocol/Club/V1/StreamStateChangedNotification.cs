using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048C RID: 1164
	public sealed class StreamStateChangedNotification : IMessage<StreamStateChangedNotification>, IMessage, IEquatable<StreamStateChangedNotification>, IDeepCloneable<StreamStateChangedNotification>, IBufferMessage
	{
		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600717B RID: 29051 RVA: 0x001B9888 File Offset: 0x001B7A88
		[DebuggerNonUserCode]
		public static MessageParser<StreamStateChangedNotification> Parser
		{
			get
			{
				return StreamStateChangedNotification._parser;
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x001B98A0 File Offset: 0x001B7AA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x001B98C4 File Offset: 0x001B7AC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamStateChangedNotification.Descriptor;
			}
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x001B98DB File Offset: 0x001B7ADB
		[DebuggerNonUserCode]
		public StreamStateChangedNotification()
		{
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x001B98E8 File Offset: 0x001B7AE8
		[DebuggerNonUserCode]
		public StreamStateChangedNotification(StreamStateChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x001B996C File Offset: 0x001B7B6C
		[DebuggerNonUserCode]
		public StreamStateChangedNotification Clone()
		{
			return new StreamStateChangedNotification(this);
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x001B9984 File Offset: 0x001B7B84
		// (set) Token: 0x06007182 RID: 29058 RVA: 0x001B999C File Offset: 0x001B7B9C
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

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06007183 RID: 29059 RVA: 0x001B99A8 File Offset: 0x001B7BA8
		// (set) Token: 0x06007184 RID: 29060 RVA: 0x001B99D9 File Offset: 0x001B7BD9
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
					clubIdDefaultValue = StreamStateChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x001B99F4 File Offset: 0x001B7BF4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x001B9A11 File Offset: 0x001B7C11
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x06007187 RID: 29063 RVA: 0x001B9A24 File Offset: 0x001B7C24
		// (set) Token: 0x06007188 RID: 29064 RVA: 0x001B9A55 File Offset: 0x001B7C55
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
					streamIdDefaultValue = StreamStateChangedNotification.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x001B9A70 File Offset: 0x001B7C70
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x001B9A8D File Offset: 0x001B7C8D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x001B9AA0 File Offset: 0x001B7CA0
		// (set) Token: 0x0600718C RID: 29068 RVA: 0x001B9AB8 File Offset: 0x001B7CB8
		[DebuggerNonUserCode]
		public StreamStateAssignment Assignment
		{
			get
			{
				return this.assignment_;
			}
			set
			{
				this.assignment_ = value;
			}
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x001B9AC4 File Offset: 0x001B7CC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamStateChangedNotification);
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x001B9AE4 File Offset: 0x001B7CE4
		[DebuggerNonUserCode]
		public bool Equals(StreamStateChangedNotification other)
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
								bool flag7 = !object.Equals(this.Assignment, other.Assignment);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x001B9B98 File Offset: 0x001B7D98
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x001B9C40 File Offset: 0x001B7E40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x001B9C58 File Offset: 0x001B7E58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x001B9C64 File Offset: 0x001B7E64
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Assignment);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x001B9D20 File Offset: 0x001B7F20
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x001B9DD0 File Offset: 0x001B7FD0
		[DebuggerNonUserCode]
		public void MergeFrom(StreamStateChangedNotification other)
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
				bool flag4 = other.assignment_ != null;
				if (flag4)
				{
					bool flag5 = this.assignment_ == null;
					if (flag5)
					{
						this.Assignment = new StreamStateAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x001B9EB3 File Offset: 0x001B80B3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x001B9EC0 File Offset: 0x001B80C0
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
					bool flag2 = this.assignment_ == null;
					if (flag2)
					{
						this.Assignment = new StreamStateAssignment();
					}
					input.ReadMessage(this.Assignment);
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

		// Token: 0x04003402 RID: 13314
		private static readonly MessageParser<StreamStateChangedNotification> _parser = new MessageParser<StreamStateChangedNotification>(() => new StreamStateChangedNotification());

		// Token: 0x04003403 RID: 13315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003404 RID: 13316
		private int _hasBits0;

		// Token: 0x04003405 RID: 13317
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003406 RID: 13318
		private MemberId agentId_;

		// Token: 0x04003407 RID: 13319
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003408 RID: 13320
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003409 RID: 13321
		private ulong clubId_;

		// Token: 0x0400340A RID: 13322
		public const int StreamIdFieldNumber = 4;

		// Token: 0x0400340B RID: 13323
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400340C RID: 13324
		private ulong streamId_;

		// Token: 0x0400340D RID: 13325
		public const int AssignmentFieldNumber = 5;

		// Token: 0x0400340E RID: 13326
		private StreamStateAssignment assignment_;
	}
}
