using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047E RID: 1150
	public sealed class UnsubscribeNotification : IMessage<UnsubscribeNotification>, IMessage, IEquatable<UnsubscribeNotification>, IDeepCloneable<UnsubscribeNotification>, IBufferMessage
	{
		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007016 RID: 28694 RVA: 0x001B4620 File Offset: 0x001B2820
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeNotification> Parser
		{
			get
			{
				return UnsubscribeNotification._parser;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x001B4638 File Offset: 0x001B2838
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x001B465C File Offset: 0x001B285C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeNotification.Descriptor;
			}
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x001B4673 File Offset: 0x001B2873
		[DebuggerNonUserCode]
		public UnsubscribeNotification()
		{
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x001B4680 File Offset: 0x001B2880
		[DebuggerNonUserCode]
		public UnsubscribeNotification(UnsubscribeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x001B46DC File Offset: 0x001B28DC
		[DebuggerNonUserCode]
		public UnsubscribeNotification Clone()
		{
			return new UnsubscribeNotification(this);
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x001B46F4 File Offset: 0x001B28F4
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x001B470C File Offset: 0x001B290C
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

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x001B4718 File Offset: 0x001B2918
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x001B4749 File Offset: 0x001B2949
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
					clubIdDefaultValue = UnsubscribeNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x001B4764 File Offset: 0x001B2964
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x001B4781 File Offset: 0x001B2981
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x001B4794 File Offset: 0x001B2994
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeNotification);
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x001B47B4 File Offset: 0x001B29B4
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeNotification other)
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

		// Token: 0x06007024 RID: 28708 RVA: 0x001B4828 File Offset: 0x001B2A28
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

		// Token: 0x06007025 RID: 28709 RVA: 0x001B4894 File Offset: 0x001B2A94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x001B48AC File Offset: 0x001B2AAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x001B48B8 File Offset: 0x001B2AB8
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x001B492C File Offset: 0x001B2B2C
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

		// Token: 0x06007029 RID: 28713 RVA: 0x001B499C File Offset: 0x001B2B9C
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeNotification other)
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

		// Token: 0x0600702A RID: 28714 RVA: 0x001B4A21 File Offset: 0x001B2C21
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600702B RID: 28715 RVA: 0x001B4A2C File Offset: 0x001B2C2C
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

		// Token: 0x0400336A RID: 13162
		private static readonly MessageParser<UnsubscribeNotification> _parser = new MessageParser<UnsubscribeNotification>(() => new UnsubscribeNotification());

		// Token: 0x0400336B RID: 13163
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400336C RID: 13164
		private int _hasBits0;

		// Token: 0x0400336D RID: 13165
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400336E RID: 13166
		private MemberId agentId_;

		// Token: 0x0400336F RID: 13167
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003370 RID: 13168
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003371 RID: 13169
		private ulong clubId_;
	}
}
