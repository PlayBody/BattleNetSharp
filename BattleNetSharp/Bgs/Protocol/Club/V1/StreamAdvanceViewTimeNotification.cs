using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000491 RID: 1169
	public sealed class StreamAdvanceViewTimeNotification : IMessage<StreamAdvanceViewTimeNotification>, IMessage, IEquatable<StreamAdvanceViewTimeNotification>, IDeepCloneable<StreamAdvanceViewTimeNotification>, IBufferMessage
	{
		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x001BBC40 File Offset: 0x001B9E40
		[DebuggerNonUserCode]
		public static MessageParser<StreamAdvanceViewTimeNotification> Parser
		{
			get
			{
				return StreamAdvanceViewTimeNotification._parser;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x001BBC58 File Offset: 0x001B9E58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x001BBC7C File Offset: 0x001B9E7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamAdvanceViewTimeNotification.Descriptor;
			}
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x001BBC93 File Offset: 0x001B9E93
		[DebuggerNonUserCode]
		public StreamAdvanceViewTimeNotification()
		{
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x001BBCA8 File Offset: 0x001B9EA8
		[DebuggerNonUserCode]
		public StreamAdvanceViewTimeNotification(StreamAdvanceViewTimeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.view_ = other.view_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x001BBD14 File Offset: 0x001B9F14
		[DebuggerNonUserCode]
		public StreamAdvanceViewTimeNotification Clone()
		{
			return new StreamAdvanceViewTimeNotification(this);
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600720F RID: 29199 RVA: 0x001BBD2C File Offset: 0x001B9F2C
		// (set) Token: 0x06007210 RID: 29200 RVA: 0x001BBD44 File Offset: 0x001B9F44
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

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06007211 RID: 29201 RVA: 0x001BBD50 File Offset: 0x001B9F50
		// (set) Token: 0x06007212 RID: 29202 RVA: 0x001BBD81 File Offset: 0x001B9F81
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
					clubIdDefaultValue = StreamAdvanceViewTimeNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06007213 RID: 29203 RVA: 0x001BBD9C File Offset: 0x001B9F9C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x001BBDB9 File Offset: 0x001B9FB9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x001BBDCC File Offset: 0x001B9FCC
		[DebuggerNonUserCode]
		public RepeatedField<StreamAdvanceViewTime> View
		{
			get
			{
				return this.view_;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x001BBDE4 File Offset: 0x001B9FE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamAdvanceViewTimeNotification);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x001BBE04 File Offset: 0x001BA004
		[DebuggerNonUserCode]
		public bool Equals(StreamAdvanceViewTimeNotification other)
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
							bool flag6 = !this.view_.Equals(other.view_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x001BBE98 File Offset: 0x001BA098
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
			num ^= this.view_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x001BBF14 File Offset: 0x001BA114
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x001BBF2C File Offset: 0x001BA12C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x001BBF38 File Offset: 0x001BA138
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
			this.view_.WriteTo(ref output, StreamAdvanceViewTimeNotification._repeated_view_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x001BBFBC File Offset: 0x001BA1BC
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
			num += this.view_.CalculateSize(StreamAdvanceViewTimeNotification._repeated_view_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x001BC040 File Offset: 0x001BA240
		[DebuggerNonUserCode]
		public void MergeFrom(StreamAdvanceViewTimeNotification other)
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
				this.view_.Add(other.view_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x001BC0D7 File Offset: 0x001BA2D7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x001BC0E4 File Offset: 0x001BA2E4
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
							this.view_.AddEntriesFrom(ref input, StreamAdvanceViewTimeNotification._repeated_view_codec);
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

		// Token: 0x04003443 RID: 13379
		private static readonly MessageParser<StreamAdvanceViewTimeNotification> _parser = new MessageParser<StreamAdvanceViewTimeNotification>(() => new StreamAdvanceViewTimeNotification());

		// Token: 0x04003444 RID: 13380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003445 RID: 13381
		private int _hasBits0;

		// Token: 0x04003446 RID: 13382
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003447 RID: 13383
		private MemberId agentId_;

		// Token: 0x04003448 RID: 13384
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003449 RID: 13385
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400344A RID: 13386
		private ulong clubId_;

		// Token: 0x0400344B RID: 13387
		public const int ViewFieldNumber = 4;

		// Token: 0x0400344C RID: 13388
		private static readonly FieldCodec<StreamAdvanceViewTime> _repeated_view_codec = FieldCodec.ForMessage<StreamAdvanceViewTime>(34U, StreamAdvanceViewTime.Parser);

		// Token: 0x0400344D RID: 13389
		private readonly RepeatedField<StreamAdvanceViewTime> view_ = new RepeatedField<StreamAdvanceViewTime>();
	}
}
