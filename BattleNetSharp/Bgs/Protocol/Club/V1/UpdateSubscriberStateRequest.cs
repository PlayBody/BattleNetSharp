using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AF RID: 1199
	public sealed class UpdateSubscriberStateRequest : IMessage<UpdateSubscriberStateRequest>, IMessage, IEquatable<UpdateSubscriberStateRequest>, IDeepCloneable<UpdateSubscriberStateRequest>, IBufferMessage
	{
		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600749D RID: 29853 RVA: 0x001C7440 File Offset: 0x001C5640
		[DebuggerNonUserCode]
		public static MessageParser<UpdateSubscriberStateRequest> Parser
		{
			get
			{
				return UpdateSubscriberStateRequest._parser;
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x001C7458 File Offset: 0x001C5658
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x001C747C File Offset: 0x001C567C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSubscriberStateRequest.Descriptor;
			}
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x001C7493 File Offset: 0x001C5693
		[DebuggerNonUserCode]
		public UpdateSubscriberStateRequest()
		{
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x001C74A0 File Offset: 0x001C56A0
		[DebuggerNonUserCode]
		public UpdateSubscriberStateRequest(UpdateSubscriberStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x001C7518 File Offset: 0x001C5718
		[DebuggerNonUserCode]
		public UpdateSubscriberStateRequest Clone()
		{
			return new UpdateSubscriberStateRequest(this);
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x001C7530 File Offset: 0x001C5730
		// (set) Token: 0x060074A4 RID: 29860 RVA: 0x001C7548 File Offset: 0x001C5748
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

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x060074A5 RID: 29861 RVA: 0x001C7554 File Offset: 0x001C5754
		// (set) Token: 0x060074A6 RID: 29862 RVA: 0x001C7585 File Offset: 0x001C5785
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
					clubIdDefaultValue = UpdateSubscriberStateRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x060074A7 RID: 29863 RVA: 0x001C75A0 File Offset: 0x001C57A0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x001C75BD File Offset: 0x001C57BD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x060074A9 RID: 29865 RVA: 0x001C75D0 File Offset: 0x001C57D0
		// (set) Token: 0x060074AA RID: 29866 RVA: 0x001C75E8 File Offset: 0x001C57E8
		[DebuggerNonUserCode]
		public SubscriberStateOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x001C75F4 File Offset: 0x001C57F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSubscriberStateRequest);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x001C7614 File Offset: 0x001C5814
		[DebuggerNonUserCode]
		public bool Equals(UpdateSubscriberStateRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x001C76A8 File Offset: 0x001C58A8
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x001C7734 File Offset: 0x001C5934
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x001C774C File Offset: 0x001C594C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x001C7758 File Offset: 0x001C5958
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x001C77F0 File Offset: 0x001C59F0
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x001C7880 File Offset: 0x001C5A80
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateSubscriberStateRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SubscriberStateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x001C7948 File Offset: 0x001C5B48
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x001C7954 File Offset: 0x001C5B54
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
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new SubscriberStateOptions();
							}
							input.ReadMessage(this.Options);
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

		// Token: 0x04003538 RID: 13624
		private static readonly MessageParser<UpdateSubscriberStateRequest> _parser = new MessageParser<UpdateSubscriberStateRequest>(() => new UpdateSubscriberStateRequest());

		// Token: 0x04003539 RID: 13625
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400353A RID: 13626
		private int _hasBits0;

		// Token: 0x0400353B RID: 13627
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400353C RID: 13628
		private MemberId agentId_;

		// Token: 0x0400353D RID: 13629
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400353E RID: 13630
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400353F RID: 13631
		private ulong clubId_;

		// Token: 0x04003540 RID: 13632
		public const int OptionsFieldNumber = 3;

		// Token: 0x04003541 RID: 13633
		private SubscriberStateOptions options_;
	}
}
