using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D3 RID: 1235
	public sealed class DestroyStreamRequest : IMessage<DestroyStreamRequest>, IMessage, IEquatable<DestroyStreamRequest>, IDeepCloneable<DestroyStreamRequest>, IBufferMessage
	{
		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x001D321C File Offset: 0x001D141C
		[DebuggerNonUserCode]
		public static MessageParser<DestroyStreamRequest> Parser
		{
			get
			{
				return DestroyStreamRequest._parser;
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x001D3234 File Offset: 0x001D1434
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[56];
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x0600780B RID: 30731 RVA: 0x001D3258 File Offset: 0x001D1458
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyStreamRequest.Descriptor;
			}
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x001D326F File Offset: 0x001D146F
		[DebuggerNonUserCode]
		public DestroyStreamRequest()
		{
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x001D327C File Offset: 0x001D147C
		[DebuggerNonUserCode]
		public DestroyStreamRequest(DestroyStreamRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x001D32E4 File Offset: 0x001D14E4
		[DebuggerNonUserCode]
		public DestroyStreamRequest Clone()
		{
			return new DestroyStreamRequest(this);
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x001D32FC File Offset: 0x001D14FC
		// (set) Token: 0x06007810 RID: 30736 RVA: 0x001D3314 File Offset: 0x001D1514
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

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06007811 RID: 30737 RVA: 0x001D3320 File Offset: 0x001D1520
		// (set) Token: 0x06007812 RID: 30738 RVA: 0x001D3351 File Offset: 0x001D1551
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
					clubIdDefaultValue = DestroyStreamRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x001D336C File Offset: 0x001D156C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x001D3389 File Offset: 0x001D1589
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x001D339C File Offset: 0x001D159C
		// (set) Token: 0x06007816 RID: 30742 RVA: 0x001D33CD File Offset: 0x001D15CD
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
					streamIdDefaultValue = DestroyStreamRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x001D33E8 File Offset: 0x001D15E8
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x001D3405 File Offset: 0x001D1605
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x001D3418 File Offset: 0x001D1618
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyStreamRequest);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x001D3438 File Offset: 0x001D1638
		[DebuggerNonUserCode]
		public bool Equals(DestroyStreamRequest other)
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

		// Token: 0x0600781B RID: 30747 RVA: 0x001D34C8 File Offset: 0x001D16C8
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

		// Token: 0x0600781C RID: 30748 RVA: 0x001D3554 File Offset: 0x001D1754
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x001D356C File Offset: 0x001D176C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x001D3578 File Offset: 0x001D1778
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x001D360C File Offset: 0x001D180C
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

		// Token: 0x06007820 RID: 30752 RVA: 0x001D369C File Offset: 0x001D189C
		[DebuggerNonUserCode]
		public void MergeFrom(DestroyStreamRequest other)
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

		// Token: 0x06007821 RID: 30753 RVA: 0x001D373F File Offset: 0x001D193F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x001D374C File Offset: 0x001D194C
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
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

		// Token: 0x04003685 RID: 13957
		private static readonly MessageParser<DestroyStreamRequest> _parser = new MessageParser<DestroyStreamRequest>(() => new DestroyStreamRequest());

		// Token: 0x04003686 RID: 13958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003687 RID: 13959
		private int _hasBits0;

		// Token: 0x04003688 RID: 13960
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003689 RID: 13961
		private MemberId agentId_;

		// Token: 0x0400368A RID: 13962
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400368B RID: 13963
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400368C RID: 13964
		private ulong clubId_;

		// Token: 0x0400368D RID: 13965
		public const int StreamIdFieldNumber = 3;

		// Token: 0x0400368E RID: 13966
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400368F RID: 13967
		private ulong streamId_;
	}
}
