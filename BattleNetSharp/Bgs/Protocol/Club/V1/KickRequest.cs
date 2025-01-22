using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A9 RID: 1193
	public sealed class KickRequest : IMessage<KickRequest>, IMessage, IEquatable<KickRequest>, IDeepCloneable<KickRequest>, IBufferMessage
	{
		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x001C5368 File Offset: 0x001C3568
		[DebuggerNonUserCode]
		public static MessageParser<KickRequest> Parser
		{
			get
			{
				return KickRequest._parser;
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600740D RID: 29709 RVA: 0x001C5380 File Offset: 0x001C3580
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x001C53A4 File Offset: 0x001C35A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickRequest.Descriptor;
			}
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x001C53BB File Offset: 0x001C35BB
		[DebuggerNonUserCode]
		public KickRequest()
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x001C53C8 File Offset: 0x001C35C8
		[DebuggerNonUserCode]
		public KickRequest(KickRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x001C5440 File Offset: 0x001C3640
		[DebuggerNonUserCode]
		public KickRequest Clone()
		{
			return new KickRequest(this);
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x001C5458 File Offset: 0x001C3658
		// (set) Token: 0x06007413 RID: 29715 RVA: 0x001C5470 File Offset: 0x001C3670
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

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x001C547C File Offset: 0x001C367C
		// (set) Token: 0x06007415 RID: 29717 RVA: 0x001C54AD File Offset: 0x001C36AD
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
					clubIdDefaultValue = KickRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x001C54C8 File Offset: 0x001C36C8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x001C54E5 File Offset: 0x001C36E5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x001C54F8 File Offset: 0x001C36F8
		// (set) Token: 0x06007419 RID: 29721 RVA: 0x001C5510 File Offset: 0x001C3710
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

		// Token: 0x0600741A RID: 29722 RVA: 0x001C551C File Offset: 0x001C371C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickRequest);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x001C553C File Offset: 0x001C373C
		[DebuggerNonUserCode]
		public bool Equals(KickRequest other)
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

		// Token: 0x0600741C RID: 29724 RVA: 0x001C55D0 File Offset: 0x001C37D0
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

		// Token: 0x0600741D RID: 29725 RVA: 0x001C565C File Offset: 0x001C385C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x001C5674 File Offset: 0x001C3874
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x001C5680 File Offset: 0x001C3880
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

		// Token: 0x06007420 RID: 29728 RVA: 0x001C5718 File Offset: 0x001C3918
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

		// Token: 0x06007421 RID: 29729 RVA: 0x001C57A8 File Offset: 0x001C39A8
		[DebuggerNonUserCode]
		public void MergeFrom(KickRequest other)
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

		// Token: 0x06007422 RID: 29730 RVA: 0x001C5870 File Offset: 0x001C3A70
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x001C587C File Offset: 0x001C3A7C
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

		// Token: 0x04003500 RID: 13568
		private static readonly MessageParser<KickRequest> _parser = new MessageParser<KickRequest>(() => new KickRequest());

		// Token: 0x04003501 RID: 13569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003502 RID: 13570
		private int _hasBits0;

		// Token: 0x04003503 RID: 13571
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003504 RID: 13572
		private MemberId agentId_;

		// Token: 0x04003505 RID: 13573
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003506 RID: 13574
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003507 RID: 13575
		private ulong clubId_;

		// Token: 0x04003508 RID: 13576
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04003509 RID: 13577
		private MemberId targetId_;
	}
}
