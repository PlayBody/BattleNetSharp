using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000257 RID: 599
	public sealed class PartyCampaignStateChanged : IMessage<PartyCampaignStateChanged>, IMessage, IEquatable<PartyCampaignStateChanged>, IDeepCloneable<PartyCampaignStateChanged>, IBufferMessage
	{
		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x000FC2D4 File Offset: 0x000FA4D4
		[DebuggerNonUserCode]
		public static MessageParser<PartyCampaignStateChanged> Parser
		{
			get
			{
				return PartyCampaignStateChanged._parser;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x000FC2EC File Offset: 0x000FA4EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[71];
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x000FC310 File Offset: 0x000FA510
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyCampaignStateChanged.Descriptor;
			}
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000FC327 File Offset: 0x000FA527
		[DebuggerNonUserCode]
		public PartyCampaignStateChanged()
		{
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000FC334 File Offset: 0x000FA534
		[DebuggerNonUserCode]
		public PartyCampaignStateChanged(PartyCampaignStateChanged other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.campaignState_ = ((other.campaignState_ != null) ? other.campaignState_.Clone() : null);
			this.resetGameQuestStates_ = other.resetGameQuestStates_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x000FC39C File Offset: 0x000FA59C
		[DebuggerNonUserCode]
		public PartyCampaignStateChanged Clone()
		{
			return new PartyCampaignStateChanged(this);
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x000FC3B4 File Offset: 0x000FA5B4
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x000FC3D5 File Offset: 0x000FA5D5
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyCampaignStateChanged.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x000FC3EC File Offset: 0x000FA5EC
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x000FC407 File Offset: 0x000FA607
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x000FC414 File Offset: 0x000FA614
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x000FC42C File Offset: 0x000FA62C
		[DebuggerNonUserCode]
		public CampaignState CampaignState
		{
			get
			{
				return this.campaignState_;
			}
			set
			{
				this.campaignState_ = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x000FC438 File Offset: 0x000FA638
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x000FC469 File Offset: 0x000FA669
		[DebuggerNonUserCode]
		public bool ResetGameQuestStates
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool resetGameQuestStatesDefaultValue;
				if (flag)
				{
					resetGameQuestStatesDefaultValue = this.resetGameQuestStates_;
				}
				else
				{
					resetGameQuestStatesDefaultValue = PartyCampaignStateChanged.ResetGameQuestStatesDefaultValue;
				}
				return resetGameQuestStatesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.resetGameQuestStates_ = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x000FC484 File Offset: 0x000FA684
		[DebuggerNonUserCode]
		public bool HasResetGameQuestStates
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x000FC4A1 File Offset: 0x000FA6A1
		[DebuggerNonUserCode]
		public void ClearResetGameQuestStates()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x000FC4B4 File Offset: 0x000FA6B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyCampaignStateChanged);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x000FC4D4 File Offset: 0x000FA6D4
		[DebuggerNonUserCode]
		public bool Equals(PartyCampaignStateChanged other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CampaignState, other.CampaignState);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ResetGameQuestStates != other.ResetGameQuestStates;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000FC564 File Offset: 0x000FA764
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				num ^= this.CampaignState.GetHashCode();
			}
			bool hasResetGameQuestStates = this.HasResetGameQuestStates;
			if (hasResetGameQuestStates)
			{
				num ^= this.ResetGameQuestStates.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000FC5EC File Offset: 0x000FA7EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x000FC604 File Offset: 0x000FA804
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000FC610 File Offset: 0x000FA810
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CampaignState);
			}
			bool hasResetGameQuestStates = this.HasResetGameQuestStates;
			if (hasResetGameQuestStates)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ResetGameQuestStates);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x000FC6A4 File Offset: 0x000FA8A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CampaignState);
			}
			bool hasResetGameQuestStates = this.HasResetGameQuestStates;
			if (hasResetGameQuestStates)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x000FC728 File Offset: 0x000FA928
		[DebuggerNonUserCode]
		public void MergeFrom(PartyCampaignStateChanged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool flag2 = other.campaignState_ != null;
				if (flag2)
				{
					bool flag3 = this.campaignState_ == null;
					if (flag3)
					{
						this.CampaignState = new CampaignState();
					}
					this.CampaignState.MergeFrom(other.CampaignState);
				}
				bool hasResetGameQuestStates = other.HasResetGameQuestStates;
				if (hasResetGameQuestStates)
				{
					this.ResetGameQuestStates = other.ResetGameQuestStates;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x000FC7CB File Offset: 0x000FA9CB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x000FC7D8 File Offset: 0x000FA9D8
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResetGameQuestStates = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.campaignState_ == null;
						if (flag)
						{
							this.CampaignState = new CampaignState();
						}
						input.ReadMessage(this.CampaignState);
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001D5B RID: 7515
		private static readonly MessageParser<PartyCampaignStateChanged> _parser = new MessageParser<PartyCampaignStateChanged>(() => new PartyCampaignStateChanged());

		// Token: 0x04001D5C RID: 7516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D5D RID: 7517
		private int _hasBits0;

		// Token: 0x04001D5E RID: 7518
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001D5F RID: 7519
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001D60 RID: 7520
		private string partyId_;

		// Token: 0x04001D61 RID: 7521
		public const int CampaignStateFieldNumber = 2;

		// Token: 0x04001D62 RID: 7522
		private CampaignState campaignState_;

		// Token: 0x04001D63 RID: 7523
		public const int ResetGameQuestStatesFieldNumber = 3;

		// Token: 0x04001D64 RID: 7524
		private static readonly bool ResetGameQuestStatesDefaultValue = false;

		// Token: 0x04001D65 RID: 7525
		private bool resetGameQuestStates_;
	}
}
