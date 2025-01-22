using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048E RID: 1166
	public sealed class StreamMessageUpdatedNotification : IMessage<StreamMessageUpdatedNotification>, IMessage, IEquatable<StreamMessageUpdatedNotification>, IDeepCloneable<StreamMessageUpdatedNotification>, IBufferMessage
	{
		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x001BA700 File Offset: 0x001B8900
		[DebuggerNonUserCode]
		public static MessageParser<StreamMessageUpdatedNotification> Parser
		{
			get
			{
				return StreamMessageUpdatedNotification._parser;
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x060071B6 RID: 29110 RVA: 0x001BA718 File Offset: 0x001B8918
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x001BA73C File Offset: 0x001B893C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMessageUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x001BA753 File Offset: 0x001B8953
		[DebuggerNonUserCode]
		public StreamMessageUpdatedNotification()
		{
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x001BA760 File Offset: 0x001B8960
		[DebuggerNonUserCode]
		public StreamMessageUpdatedNotification(StreamMessageUpdatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x001BA7E4 File Offset: 0x001B89E4
		[DebuggerNonUserCode]
		public StreamMessageUpdatedNotification Clone()
		{
			return new StreamMessageUpdatedNotification(this);
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x001BA7FC File Offset: 0x001B89FC
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x001BA814 File Offset: 0x001B8A14
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

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x001BA820 File Offset: 0x001B8A20
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x001BA851 File Offset: 0x001B8A51
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
					clubIdDefaultValue = StreamMessageUpdatedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x001BA86C File Offset: 0x001B8A6C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x001BA889 File Offset: 0x001B8A89
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x001BA89C File Offset: 0x001B8A9C
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x001BA8CD File Offset: 0x001B8ACD
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
					streamIdDefaultValue = StreamMessageUpdatedNotification.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x001BA905 File Offset: 0x001B8B05
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x001BA918 File Offset: 0x001B8B18
		// (set) Token: 0x060071C6 RID: 29126 RVA: 0x001BA930 File Offset: 0x001B8B30
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

		// Token: 0x060071C7 RID: 29127 RVA: 0x001BA93C File Offset: 0x001B8B3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMessageUpdatedNotification);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x001BA95C File Offset: 0x001B8B5C
		[DebuggerNonUserCode]
		public bool Equals(StreamMessageUpdatedNotification other)
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

		// Token: 0x060071C9 RID: 29129 RVA: 0x001BAA10 File Offset: 0x001B8C10
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

		// Token: 0x060071CA RID: 29130 RVA: 0x001BAAB8 File Offset: 0x001B8CB8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x001BAAD0 File Offset: 0x001B8CD0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x001BAADC File Offset: 0x001B8CDC
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

		// Token: 0x060071CD RID: 29133 RVA: 0x001BAB98 File Offset: 0x001B8D98
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

		// Token: 0x060071CE RID: 29134 RVA: 0x001BAC48 File Offset: 0x001B8E48
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMessageUpdatedNotification other)
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

		// Token: 0x060071CF RID: 29135 RVA: 0x001BAD2B File Offset: 0x001B8F2B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x001BAD38 File Offset: 0x001B8F38
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

		// Token: 0x0400341C RID: 13340
		private static readonly MessageParser<StreamMessageUpdatedNotification> _parser = new MessageParser<StreamMessageUpdatedNotification>(() => new StreamMessageUpdatedNotification());

		// Token: 0x0400341D RID: 13341
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400341E RID: 13342
		private int _hasBits0;

		// Token: 0x0400341F RID: 13343
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003420 RID: 13344
		private MemberId agentId_;

		// Token: 0x04003421 RID: 13345
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003422 RID: 13346
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003423 RID: 13347
		private ulong clubId_;

		// Token: 0x04003424 RID: 13348
		public const int StreamIdFieldNumber = 4;

		// Token: 0x04003425 RID: 13349
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003426 RID: 13350
		private ulong streamId_;

		// Token: 0x04003427 RID: 13351
		public const int MessageFieldNumber = 5;

		// Token: 0x04003428 RID: 13352
		private StreamMessage message_;
	}
}
