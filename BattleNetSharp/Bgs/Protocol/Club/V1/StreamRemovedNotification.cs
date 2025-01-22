using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048B RID: 1163
	public sealed class StreamRemovedNotification : IMessage<StreamRemovedNotification>, IMessage, IEquatable<StreamRemovedNotification>, IDeepCloneable<StreamRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x06007160 RID: 29024 RVA: 0x001B9290 File Offset: 0x001B7490
		[DebuggerNonUserCode]
		public static MessageParser<StreamRemovedNotification> Parser
		{
			get
			{
				return StreamRemovedNotification._parser;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x06007161 RID: 29025 RVA: 0x001B92A8 File Offset: 0x001B74A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x06007162 RID: 29026 RVA: 0x001B92CC File Offset: 0x001B74CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x001B92E3 File Offset: 0x001B74E3
		[DebuggerNonUserCode]
		public StreamRemovedNotification()
		{
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x001B92F0 File Offset: 0x001B74F0
		[DebuggerNonUserCode]
		public StreamRemovedNotification(StreamRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x001B9358 File Offset: 0x001B7558
		[DebuggerNonUserCode]
		public StreamRemovedNotification Clone()
		{
			return new StreamRemovedNotification(this);
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x001B9370 File Offset: 0x001B7570
		// (set) Token: 0x06007167 RID: 29031 RVA: 0x001B9388 File Offset: 0x001B7588
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

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x001B9394 File Offset: 0x001B7594
		// (set) Token: 0x06007169 RID: 29033 RVA: 0x001B93C5 File Offset: 0x001B75C5
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
					clubIdDefaultValue = StreamRemovedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x001B93E0 File Offset: 0x001B75E0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x001B93FD File Offset: 0x001B75FD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x001B9410 File Offset: 0x001B7610
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x001B9441 File Offset: 0x001B7641
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
					streamIdDefaultValue = StreamRemovedNotification.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x001B945C File Offset: 0x001B765C
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x001B9479 File Offset: 0x001B7679
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x001B948C File Offset: 0x001B768C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamRemovedNotification);
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x001B94AC File Offset: 0x001B76AC
		[DebuggerNonUserCode]
		public bool Equals(StreamRemovedNotification other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x001B953C File Offset: 0x001B773C
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x001B95C8 File Offset: 0x001B77C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x001B95E0 File Offset: 0x001B77E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x001B95EC File Offset: 0x001B77EC
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x001B9680 File Offset: 0x001B7880
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x001B9710 File Offset: 0x001B7910
		[DebuggerNonUserCode]
		public void MergeFrom(StreamRemovedNotification other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x001B97B3 File Offset: 0x001B79B3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x001B97C0 File Offset: 0x001B79C0
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
						if (num3 != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StreamId = input.ReadUInt64();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
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
		}

		// Token: 0x040033F7 RID: 13303
		private static readonly MessageParser<StreamRemovedNotification> _parser = new MessageParser<StreamRemovedNotification>(() => new StreamRemovedNotification());

		// Token: 0x040033F8 RID: 13304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F9 RID: 13305
		private int _hasBits0;

		// Token: 0x040033FA RID: 13306
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033FB RID: 13307
		private MemberId agentId_;

		// Token: 0x040033FC RID: 13308
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033FD RID: 13309
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033FE RID: 13310
		private ulong clubId_;

		// Token: 0x040033FF RID: 13311
		public const int StreamIdFieldNumber = 4;

		// Token: 0x04003400 RID: 13312
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003401 RID: 13313
		private ulong streamId_;
	}
}
