using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048F RID: 1167
	public sealed class StreamTypingIndicatorNotification : IMessage<StreamTypingIndicatorNotification>, IMessage, IEquatable<StreamTypingIndicatorNotification>, IDeepCloneable<StreamTypingIndicatorNotification>, IBufferMessage
	{
		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x001BAE3C File Offset: 0x001B903C
		[DebuggerNonUserCode]
		public static MessageParser<StreamTypingIndicatorNotification> Parser
		{
			get
			{
				return StreamTypingIndicatorNotification._parser;
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x001BAE54 File Offset: 0x001B9054
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x001BAE78 File Offset: 0x001B9078
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamTypingIndicatorNotification.Descriptor;
			}
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x001BAE8F File Offset: 0x001B908F
		[DebuggerNonUserCode]
		public StreamTypingIndicatorNotification()
		{
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x001BAEA4 File Offset: 0x001B90A4
		[DebuggerNonUserCode]
		public StreamTypingIndicatorNotification(StreamTypingIndicatorNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.indicator_ = other.indicator_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x001BAF1C File Offset: 0x001B911C
		[DebuggerNonUserCode]
		public StreamTypingIndicatorNotification Clone()
		{
			return new StreamTypingIndicatorNotification(this);
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x001BAF34 File Offset: 0x001B9134
		// (set) Token: 0x060071D9 RID: 29145 RVA: 0x001BAF4C File Offset: 0x001B914C
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

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x001BAF58 File Offset: 0x001B9158
		// (set) Token: 0x060071DB RID: 29147 RVA: 0x001BAF89 File Offset: 0x001B9189
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
					clubIdDefaultValue = StreamTypingIndicatorNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x001BAFA4 File Offset: 0x001B91A4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x001BAFC1 File Offset: 0x001B91C1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x001BAFD4 File Offset: 0x001B91D4
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x001BB005 File Offset: 0x001B9205
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
					streamIdDefaultValue = StreamTypingIndicatorNotification.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x001BB020 File Offset: 0x001B9220
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x001BB03D File Offset: 0x001B923D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x060071E2 RID: 29154 RVA: 0x001BB050 File Offset: 0x001B9250
		[DebuggerNonUserCode]
		public RepeatedField<StreamTypingIndicator> Indicator
		{
			get
			{
				return this.indicator_;
			}
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x001BB068 File Offset: 0x001B9268
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamTypingIndicatorNotification);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x001BB088 File Offset: 0x001B9288
		[DebuggerNonUserCode]
		public bool Equals(StreamTypingIndicatorNotification other)
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
								bool flag7 = !this.indicator_.Equals(other.indicator_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x001BB13C File Offset: 0x001B933C
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
			num ^= this.indicator_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x001BB1D4 File Offset: 0x001B93D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x001BB1EC File Offset: 0x001B93EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x001BB1F8 File Offset: 0x001B93F8
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
			this.indicator_.WriteTo(ref output, StreamTypingIndicatorNotification._repeated_indicator_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x001BB2A0 File Offset: 0x001B94A0
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
			num += this.indicator_.CalculateSize(StreamTypingIndicatorNotification._repeated_indicator_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x001BB340 File Offset: 0x001B9540
		[DebuggerNonUserCode]
		public void MergeFrom(StreamTypingIndicatorNotification other)
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
				this.indicator_.Add(other.indicator_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x001BB3F5 File Offset: 0x001B95F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x001BB400 File Offset: 0x001B9600
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
					this.indicator_.AddEntriesFrom(ref input, StreamTypingIndicatorNotification._repeated_indicator_codec);
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

		// Token: 0x04003429 RID: 13353
		private static readonly MessageParser<StreamTypingIndicatorNotification> _parser = new MessageParser<StreamTypingIndicatorNotification>(() => new StreamTypingIndicatorNotification());

		// Token: 0x0400342A RID: 13354
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400342B RID: 13355
		private int _hasBits0;

		// Token: 0x0400342C RID: 13356
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400342D RID: 13357
		private MemberId agentId_;

		// Token: 0x0400342E RID: 13358
		public const int ClubIdFieldNumber = 3;

		// Token: 0x0400342F RID: 13359
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003430 RID: 13360
		private ulong clubId_;

		// Token: 0x04003431 RID: 13361
		public const int StreamIdFieldNumber = 4;

		// Token: 0x04003432 RID: 13362
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003433 RID: 13363
		private ulong streamId_;

		// Token: 0x04003434 RID: 13364
		public const int IndicatorFieldNumber = 5;

		// Token: 0x04003435 RID: 13365
		private static readonly FieldCodec<StreamTypingIndicator> _repeated_indicator_codec = FieldCodec.ForMessage<StreamTypingIndicator>(42U, StreamTypingIndicator.Parser);

		// Token: 0x04003436 RID: 13366
		private readonly RepeatedField<StreamTypingIndicator> indicator_ = new RepeatedField<StreamTypingIndicator>();
	}
}
