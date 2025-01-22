using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004ED RID: 1261
	public sealed class KickFromStreamVoiceRequest : IMessage<KickFromStreamVoiceRequest>, IMessage, IEquatable<KickFromStreamVoiceRequest>, IDeepCloneable<KickFromStreamVoiceRequest>, IBufferMessage
	{
		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x001DC628 File Offset: 0x001DA828
		[DebuggerNonUserCode]
		public static MessageParser<KickFromStreamVoiceRequest> Parser
		{
			get
			{
				return KickFromStreamVoiceRequest._parser;
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x06007AA2 RID: 31394 RVA: 0x001DC640 File Offset: 0x001DA840
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[82];
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x001DC664 File Offset: 0x001DA864
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickFromStreamVoiceRequest.Descriptor;
			}
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x001DC67B File Offset: 0x001DA87B
		[DebuggerNonUserCode]
		public KickFromStreamVoiceRequest()
		{
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x001DC688 File Offset: 0x001DA888
		[DebuggerNonUserCode]
		public KickFromStreamVoiceRequest(KickFromStreamVoiceRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x001DC70C File Offset: 0x001DA90C
		[DebuggerNonUserCode]
		public KickFromStreamVoiceRequest Clone()
		{
			return new KickFromStreamVoiceRequest(this);
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x001DC724 File Offset: 0x001DA924
		// (set) Token: 0x06007AA8 RID: 31400 RVA: 0x001DC73C File Offset: 0x001DA93C
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

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x06007AA9 RID: 31401 RVA: 0x001DC748 File Offset: 0x001DA948
		// (set) Token: 0x06007AAA RID: 31402 RVA: 0x001DC779 File Offset: 0x001DA979
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
					clubIdDefaultValue = KickFromStreamVoiceRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x001DC794 File Offset: 0x001DA994
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x001DC7B1 File Offset: 0x001DA9B1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x001DC7C4 File Offset: 0x001DA9C4
		// (set) Token: 0x06007AAE RID: 31406 RVA: 0x001DC7F5 File Offset: 0x001DA9F5
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
					streamIdDefaultValue = KickFromStreamVoiceRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x06007AAF RID: 31407 RVA: 0x001DC810 File Offset: 0x001DAA10
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x001DC82D File Offset: 0x001DAA2D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x06007AB1 RID: 31409 RVA: 0x001DC840 File Offset: 0x001DAA40
		// (set) Token: 0x06007AB2 RID: 31410 RVA: 0x001DC858 File Offset: 0x001DAA58
		[DebuggerNonUserCode]
		public MemberId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x001DC864 File Offset: 0x001DAA64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickFromStreamVoiceRequest);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x001DC884 File Offset: 0x001DAA84
		[DebuggerNonUserCode]
		public bool Equals(KickFromStreamVoiceRequest other)
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
								bool flag7 = !object.Equals(this.TargetId, other.TargetId);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x001DC938 File Offset: 0x001DAB38
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x001DC9E0 File Offset: 0x001DABE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x001DC9F8 File Offset: 0x001DABF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x001DCA04 File Offset: 0x001DAC04
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x001DCAC0 File Offset: 0x001DACC0
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x001DCB70 File Offset: 0x001DAD70
		[DebuggerNonUserCode]
		public void MergeFrom(KickFromStreamVoiceRequest other)
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
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new MemberId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x001DCC53 File Offset: 0x001DAE53
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x001DCC60 File Offset: 0x001DAE60
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag2 = this.targetId_ == null;
					if (flag2)
					{
						this.TargetId = new MemberId();
					}
					input.ReadMessage(this.TargetId);
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

		// Token: 0x0400378C RID: 14220
		private static readonly MessageParser<KickFromStreamVoiceRequest> _parser = new MessageParser<KickFromStreamVoiceRequest>(() => new KickFromStreamVoiceRequest());

		// Token: 0x0400378D RID: 14221
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400378E RID: 14222
		private int _hasBits0;

		// Token: 0x0400378F RID: 14223
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003790 RID: 14224
		private MemberId agentId_;

		// Token: 0x04003791 RID: 14225
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003792 RID: 14226
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003793 RID: 14227
		private ulong clubId_;

		// Token: 0x04003794 RID: 14228
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003795 RID: 14229
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003796 RID: 14230
		private ulong streamId_;

		// Token: 0x04003797 RID: 14231
		public const int TargetIdFieldNumber = 4;

		// Token: 0x04003798 RID: 14232
		private MemberId targetId_;
	}
}
