using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049C RID: 1180
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x060072E1 RID: 29409 RVA: 0x001C10FC File Offset: 0x001BF2FC
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x001C1114 File Offset: 0x001BF314
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x001C1138 File Offset: 0x001BF338
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x001C114F File Offset: 0x001BF34F
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x001C115C File Offset: 0x001BF35C
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x001C11B8 File Offset: 0x001BF3B8
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x060072E7 RID: 29415 RVA: 0x001C11D0 File Offset: 0x001BF3D0
		// (set) Token: 0x060072E8 RID: 29416 RVA: 0x001C11E8 File Offset: 0x001BF3E8
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

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x001C11F4 File Offset: 0x001BF3F4
		// (set) Token: 0x060072EA RID: 29418 RVA: 0x001C1225 File Offset: 0x001BF425
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
					clubIdDefaultValue = UnsubscribeRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x060072EB RID: 29419 RVA: 0x001C1240 File Offset: 0x001BF440
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x001C125D File Offset: 0x001BF45D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x001C1270 File Offset: 0x001BF470
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x001C1290 File Offset: 0x001BF490
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x001C1304 File Offset: 0x001BF504
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x001C1370 File Offset: 0x001BF570
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x001C1388 File Offset: 0x001BF588
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x001C1394 File Offset: 0x001BF594
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x001C1408 File Offset: 0x001BF608
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x001C1478 File Offset: 0x001BF678
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x001C14FD File Offset: 0x001BF6FD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x001C1508 File Offset: 0x001BF708
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04003494 RID: 13460
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04003495 RID: 13461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003496 RID: 13462
		private int _hasBits0;

		// Token: 0x04003497 RID: 13463
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003498 RID: 13464
		private MemberId agentId_;

		// Token: 0x04003499 RID: 13465
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400349A RID: 13466
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400349B RID: 13467
		private ulong clubId_;
	}
}
