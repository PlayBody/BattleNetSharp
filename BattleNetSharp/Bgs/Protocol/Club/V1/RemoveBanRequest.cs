using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CA RID: 1226
	public sealed class RemoveBanRequest : IMessage<RemoveBanRequest>, IMessage, IEquatable<RemoveBanRequest>, IDeepCloneable<RemoveBanRequest>, IBufferMessage
	{
		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06007731 RID: 30513 RVA: 0x001D02D0 File Offset: 0x001CE4D0
		[DebuggerNonUserCode]
		public static MessageParser<RemoveBanRequest> Parser
		{
			get
			{
				return RemoveBanRequest._parser;
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x001D02E8 File Offset: 0x001CE4E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[47];
			}
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06007733 RID: 30515 RVA: 0x001D030C File Offset: 0x001CE50C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBanRequest.Descriptor;
			}
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x001D0323 File Offset: 0x001CE523
		[DebuggerNonUserCode]
		public RemoveBanRequest()
		{
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x001D0330 File Offset: 0x001CE530
		[DebuggerNonUserCode]
		public RemoveBanRequest(RemoveBanRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x001D03A8 File Offset: 0x001CE5A8
		[DebuggerNonUserCode]
		public RemoveBanRequest Clone()
		{
			return new RemoveBanRequest(this);
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06007737 RID: 30519 RVA: 0x001D03C0 File Offset: 0x001CE5C0
		// (set) Token: 0x06007738 RID: 30520 RVA: 0x001D03D8 File Offset: 0x001CE5D8
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

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x001D03E4 File Offset: 0x001CE5E4
		// (set) Token: 0x0600773A RID: 30522 RVA: 0x001D0415 File Offset: 0x001CE615
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
					clubIdDefaultValue = RemoveBanRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x0600773B RID: 30523 RVA: 0x001D0430 File Offset: 0x001CE630
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x001D044D File Offset: 0x001CE64D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x0600773D RID: 30525 RVA: 0x001D0460 File Offset: 0x001CE660
		// (set) Token: 0x0600773E RID: 30526 RVA: 0x001D0478 File Offset: 0x001CE678
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

		// Token: 0x0600773F RID: 30527 RVA: 0x001D0484 File Offset: 0x001CE684
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBanRequest);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x001D04A4 File Offset: 0x001CE6A4
		[DebuggerNonUserCode]
		public bool Equals(RemoveBanRequest other)
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
							bool flag6 = !object.Equals(this.TargetId, other.TargetId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x001D0538 File Offset: 0x001CE738
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

		// Token: 0x06007742 RID: 30530 RVA: 0x001D05C4 File Offset: 0x001CE7C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x001D05DC File Offset: 0x001CE7DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x001D05E8 File Offset: 0x001CE7E8
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x001D0680 File Offset: 0x001CE880
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

		// Token: 0x06007746 RID: 30534 RVA: 0x001D0710 File Offset: 0x001CE910
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveBanRequest other)
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

		// Token: 0x06007747 RID: 30535 RVA: 0x001D07D8 File Offset: 0x001CE9D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x001D07E4 File Offset: 0x001CE9E4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.targetId_ == null;
							if (flag)
							{
								this.TargetId = new MemberId();
							}
							input.ReadMessage(this.TargetId);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003630 RID: 13872
		private static readonly MessageParser<RemoveBanRequest> _parser = new MessageParser<RemoveBanRequest>(() => new RemoveBanRequest());

		// Token: 0x04003631 RID: 13873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003632 RID: 13874
		private int _hasBits0;

		// Token: 0x04003633 RID: 13875
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003634 RID: 13876
		private MemberId agentId_;

		// Token: 0x04003635 RID: 13877
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003636 RID: 13878
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003637 RID: 13879
		private ulong clubId_;

		// Token: 0x04003638 RID: 13880
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04003639 RID: 13881
		private MemberId targetId_;
	}
}
