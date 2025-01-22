using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CF RID: 1231
	public sealed class SubscribeStreamRequest : IMessage<SubscribeStreamRequest>, IMessage, IEquatable<SubscribeStreamRequest>, IDeepCloneable<SubscribeStreamRequest>, IBufferMessage
	{
		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x060077A7 RID: 30631 RVA: 0x001D1C68 File Offset: 0x001CFE68
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeStreamRequest> Parser
		{
			get
			{
				return SubscribeStreamRequest._parser;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x001D1C80 File Offset: 0x001CFE80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[52];
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x060077A9 RID: 30633 RVA: 0x001D1CA4 File Offset: 0x001CFEA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeStreamRequest.Descriptor;
			}
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x001D1CBB File Offset: 0x001CFEBB
		[DebuggerNonUserCode]
		public SubscribeStreamRequest()
		{
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x001D1CD0 File Offset: 0x001CFED0
		[DebuggerNonUserCode]
		public SubscribeStreamRequest(SubscribeStreamRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x001D1D3C File Offset: 0x001CFF3C
		[DebuggerNonUserCode]
		public SubscribeStreamRequest Clone()
		{
			return new SubscribeStreamRequest(this);
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x060077AD RID: 30637 RVA: 0x001D1D54 File Offset: 0x001CFF54
		// (set) Token: 0x060077AE RID: 30638 RVA: 0x001D1D6C File Offset: 0x001CFF6C
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

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x060077AF RID: 30639 RVA: 0x001D1D78 File Offset: 0x001CFF78
		// (set) Token: 0x060077B0 RID: 30640 RVA: 0x001D1DA9 File Offset: 0x001CFFA9
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
					clubIdDefaultValue = SubscribeStreamRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x060077B1 RID: 30641 RVA: 0x001D1DC4 File Offset: 0x001CFFC4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x001D1DE1 File Offset: 0x001CFFE1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x060077B3 RID: 30643 RVA: 0x001D1DF4 File Offset: 0x001CFFF4
		[DebuggerNonUserCode]
		public RepeatedField<ulong> StreamId
		{
			get
			{
				return this.streamId_;
			}
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x001D1E0C File Offset: 0x001D000C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeStreamRequest);
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x001D1E2C File Offset: 0x001D002C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeStreamRequest other)
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
							bool flag6 = !this.streamId_.Equals(other.streamId_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x001D1EC0 File Offset: 0x001D00C0
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
			num ^= this.streamId_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x001D1F3C File Offset: 0x001D013C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x001D1F54 File Offset: 0x001D0154
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x001D1F60 File Offset: 0x001D0160
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
			this.streamId_.WriteTo(ref output, SubscribeStreamRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x001D1FE4 File Offset: 0x001D01E4
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
			num += this.streamId_.CalculateSize(SubscribeStreamRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x001D2068 File Offset: 0x001D0268
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeStreamRequest other)
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
				this.streamId_.Add(other.streamId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x001D20FF File Offset: 0x001D02FF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x001D210C File Offset: 0x001D030C
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
				else
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_002C;
					}
					this.streamId_.AddEntriesFrom(ref input, SubscribeStreamRequest._repeated_streamId_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400365C RID: 13916
		private static readonly MessageParser<SubscribeStreamRequest> _parser = new MessageParser<SubscribeStreamRequest>(() => new SubscribeStreamRequest());

		// Token: 0x0400365D RID: 13917
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400365E RID: 13918
		private int _hasBits0;

		// Token: 0x0400365F RID: 13919
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003660 RID: 13920
		private MemberId agentId_;

		// Token: 0x04003661 RID: 13921
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003662 RID: 13922
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003663 RID: 13923
		private ulong clubId_;

		// Token: 0x04003664 RID: 13924
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003665 RID: 13925
		private static readonly FieldCodec<ulong> _repeated_streamId_codec = FieldCodec.ForUInt64(24U);

		// Token: 0x04003666 RID: 13926
		private readonly RepeatedField<ulong> streamId_ = new RepeatedField<ulong>();
	}
}
