using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003A RID: 58
	public sealed class SetGameModeRequest : IMessage<SetGameModeRequest>, IMessage, IEquatable<SetGameModeRequest>, IDeepCloneable<SetGameModeRequest>, IBufferMessage
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000159B8 File Offset: 0x00013BB8
		[DebuggerNonUserCode]
		public static MessageParser<SetGameModeRequest> Parser
		{
			get
			{
				return SetGameModeRequest._parser;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000159D0 File Offset: 0x00013BD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000159F4 File Offset: 0x00013BF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGameModeRequest.Descriptor;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00015A0B File Offset: 0x00013C0B
		[DebuggerNonUserCode]
		public SetGameModeRequest()
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00015A18 File Offset: 0x00013C18
		[DebuggerNonUserCode]
		public SetGameModeRequest(SetGameModeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requestedMode_ = other.requestedMode_;
			this.snoWorld_ = other.snoWorld_;
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.snoSubzone_ = other.snoSubzone_;
			this.startReason_ = other.startReason_;
			this.campaignSettings_ = ((other.campaignSettings_ != null) ? other.campaignSettings_.Clone() : null);
			this.snoStartingQuest_ = other.snoStartingQuest_;
			this.automated_ = other.automated_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00015ACC File Offset: 0x00013CCC
		[DebuggerNonUserCode]
		public SetGameModeRequest Clone()
		{
			return new SetGameModeRequest(this);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00015AE4 File Offset: 0x00013CE4
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00015B15 File Offset: 0x00013D15
		[DebuggerNonUserCode]
		public int RequestedMode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int requestedModeDefaultValue;
				if (flag)
				{
					requestedModeDefaultValue = this.requestedMode_;
				}
				else
				{
					requestedModeDefaultValue = SetGameModeRequest.RequestedModeDefaultValue;
				}
				return requestedModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requestedMode_ = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00015B30 File Offset: 0x00013D30
		[DebuggerNonUserCode]
		public bool HasRequestedMode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00015B4D File Offset: 0x00013D4D
		[DebuggerNonUserCode]
		public void ClearRequestedMode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00015B60 File Offset: 0x00013D60
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00015B91 File Offset: 0x00013D91
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = SetGameModeRequest.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00015BAC File Offset: 0x00013DAC
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00015BC9 File Offset: 0x00013DC9
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00015BDC File Offset: 0x00013DDC
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00015BF4 File Offset: 0x00013DF4
		[DebuggerNonUserCode]
		public GameModeSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00015C00 File Offset: 0x00013E00
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00015C31 File Offset: 0x00013E31
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = SetGameModeRequest.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00015C4C File Offset: 0x00013E4C
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00015C69 File Offset: 0x00013E69
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00015C7C File Offset: 0x00013E7C
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00015CAD File Offset: 0x00013EAD
		[DebuggerNonUserCode]
		public int StartReason
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int startReasonDefaultValue;
				if (flag)
				{
					startReasonDefaultValue = this.startReason_;
				}
				else
				{
					startReasonDefaultValue = SetGameModeRequest.StartReasonDefaultValue;
				}
				return startReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.startReason_ = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00015CC8 File Offset: 0x00013EC8
		[DebuggerNonUserCode]
		public bool HasStartReason
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00015CE5 File Offset: 0x00013EE5
		[DebuggerNonUserCode]
		public void ClearStartReason()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00015CF8 File Offset: 0x00013EF8
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00015D10 File Offset: 0x00013F10
		[DebuggerNonUserCode]
		public CampaignSettings CampaignSettings
		{
			get
			{
				return this.campaignSettings_;
			}
			set
			{
				this.campaignSettings_ = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00015D1C File Offset: 0x00013F1C
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00015D4E File Offset: 0x00013F4E
		[DebuggerNonUserCode]
		public int SnoStartingQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int snoStartingQuestDefaultValue;
				if (flag)
				{
					snoStartingQuestDefaultValue = this.snoStartingQuest_;
				}
				else
				{
					snoStartingQuestDefaultValue = SetGameModeRequest.SnoStartingQuestDefaultValue;
				}
				return snoStartingQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.snoStartingQuest_ = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00015D68 File Offset: 0x00013F68
		[DebuggerNonUserCode]
		public bool HasSnoStartingQuest
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00015D86 File Offset: 0x00013F86
		[DebuggerNonUserCode]
		public void ClearSnoStartingQuest()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00015D98 File Offset: 0x00013F98
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00015DCA File Offset: 0x00013FCA
		[DebuggerNonUserCode]
		public bool Automated
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool automatedDefaultValue;
				if (flag)
				{
					automatedDefaultValue = this.automated_;
				}
				else
				{
					automatedDefaultValue = SetGameModeRequest.AutomatedDefaultValue;
				}
				return automatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.automated_ = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00015DE4 File Offset: 0x00013FE4
		[DebuggerNonUserCode]
		public bool HasAutomated
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00015E02 File Offset: 0x00014002
		[DebuggerNonUserCode]
		public void ClearAutomated()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00015E14 File Offset: 0x00014014
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGameModeRequest);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00015E34 File Offset: 0x00014034
		[DebuggerNonUserCode]
		public bool Equals(SetGameModeRequest other)
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
					bool flag4 = this.RequestedMode != other.RequestedMode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoWorld != other.SnoWorld;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Settings, other.Settings);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoSubzone != other.SnoSubzone;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.StartReason != other.StartReason;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.CampaignSettings, other.CampaignSettings);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SnoStartingQuest != other.SnoStartingQuest;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Automated != other.Automated;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00015F60 File Offset: 0x00014160
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				num ^= this.RequestedMode.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool flag = this.settings_ != null;
			if (flag)
			{
				num ^= this.Settings.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasStartReason = this.HasStartReason;
			if (hasStartReason)
			{
				num ^= this.StartReason.GetHashCode();
			}
			bool flag2 = this.campaignSettings_ != null;
			if (flag2)
			{
				num ^= this.CampaignSettings.GetHashCode();
			}
			bool hasSnoStartingQuest = this.HasSnoStartingQuest;
			if (hasSnoStartingQuest)
			{
				num ^= this.SnoStartingQuest.GetHashCode();
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				num ^= this.Automated.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001607C File Offset: 0x0001427C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00016094 File Offset: 0x00014294
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000160A0 File Offset: 0x000142A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RequestedMode);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoWorld);
			}
			bool flag = this.settings_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Settings);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SnoSubzone);
			}
			bool hasStartReason = this.HasStartReason;
			if (hasStartReason)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.StartReason);
			}
			bool flag2 = this.campaignSettings_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CampaignSettings);
			}
			bool hasSnoStartingQuest = this.HasSnoStartingQuest;
			if (hasSnoStartingQuest)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SnoStartingQuest);
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Automated);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000161EC File Offset: 0x000143EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestedMode);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool flag = this.settings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool hasStartReason = this.HasStartReason;
			if (hasStartReason)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartReason);
			}
			bool flag2 = this.campaignSettings_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CampaignSettings);
			}
			bool hasSnoStartingQuest = this.HasSnoStartingQuest;
			if (hasSnoStartingQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoStartingQuest);
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00016308 File Offset: 0x00014508
		[DebuggerNonUserCode]
		public void MergeFrom(SetGameModeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequestedMode = other.HasRequestedMode;
				if (hasRequestedMode)
				{
					this.RequestedMode = other.RequestedMode;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool flag2 = other.settings_ != null;
				if (flag2)
				{
					bool flag3 = this.settings_ == null;
					if (flag3)
					{
						this.Settings = new GameModeSettings();
					}
					this.Settings.MergeFrom(other.Settings);
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasStartReason = other.HasStartReason;
				if (hasStartReason)
				{
					this.StartReason = other.StartReason;
				}
				bool flag4 = other.campaignSettings_ != null;
				if (flag4)
				{
					bool flag5 = this.campaignSettings_ == null;
					if (flag5)
					{
						this.CampaignSettings = new CampaignSettings();
					}
					this.CampaignSettings.MergeFrom(other.CampaignSettings);
				}
				bool hasSnoStartingQuest = other.HasSnoStartingQuest;
				if (hasSnoStartingQuest)
				{
					this.SnoStartingQuest = other.SnoStartingQuest;
				}
				bool hasAutomated = other.HasAutomated;
				if (hasAutomated)
				{
					this.Automated = other.Automated;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00016457 File Offset: 0x00014657
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00016464 File Offset: 0x00014664
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_0060;
							}
							this.SnoWorld = input.ReadInt32();
						}
						else
						{
							this.RequestedMode = input.ReadInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							goto IL_0060;
						}
						this.SnoSubzone = input.ReadInt32();
					}
					else
					{
						bool flag = this.settings_ == null;
						if (flag)
						{
							this.Settings = new GameModeSettings();
						}
						input.ReadMessage(this.Settings);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_0060;
						}
						bool flag2 = this.campaignSettings_ == null;
						if (flag2)
						{
							this.CampaignSettings = new CampaignSettings();
						}
						input.ReadMessage(this.CampaignSettings);
					}
					else
					{
						this.StartReason = input.ReadInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0060;
					}
					this.Automated = input.ReadBool();
				}
				else
				{
					this.SnoStartingQuest = input.ReadInt32();
				}
				continue;
				IL_0060:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040001D7 RID: 471
		private static readonly MessageParser<SetGameModeRequest> _parser = new MessageParser<SetGameModeRequest>(() => new SetGameModeRequest());

		// Token: 0x040001D8 RID: 472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001D9 RID: 473
		private int _hasBits0;

		// Token: 0x040001DA RID: 474
		public const int RequestedModeFieldNumber = 1;

		// Token: 0x040001DB RID: 475
		private static readonly int RequestedModeDefaultValue = 0;

		// Token: 0x040001DC RID: 476
		private int requestedMode_;

		// Token: 0x040001DD RID: 477
		public const int SnoWorldFieldNumber = 2;

		// Token: 0x040001DE RID: 478
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x040001DF RID: 479
		private int snoWorld_;

		// Token: 0x040001E0 RID: 480
		public const int SettingsFieldNumber = 3;

		// Token: 0x040001E1 RID: 481
		private GameModeSettings settings_;

		// Token: 0x040001E2 RID: 482
		public const int SnoSubzoneFieldNumber = 4;

		// Token: 0x040001E3 RID: 483
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x040001E4 RID: 484
		private int snoSubzone_;

		// Token: 0x040001E5 RID: 485
		public const int StartReasonFieldNumber = 5;

		// Token: 0x040001E6 RID: 486
		private static readonly int StartReasonDefaultValue = 0;

		// Token: 0x040001E7 RID: 487
		private int startReason_;

		// Token: 0x040001E8 RID: 488
		public const int CampaignSettingsFieldNumber = 6;

		// Token: 0x040001E9 RID: 489
		private CampaignSettings campaignSettings_;

		// Token: 0x040001EA RID: 490
		public const int SnoStartingQuestFieldNumber = 7;

		// Token: 0x040001EB RID: 491
		private static readonly int SnoStartingQuestDefaultValue = 0;

		// Token: 0x040001EC RID: 492
		private int snoStartingQuest_;

		// Token: 0x040001ED RID: 493
		public const int AutomatedFieldNumber = 8;

		// Token: 0x040001EE RID: 494
		private static readonly bool AutomatedDefaultValue = false;

		// Token: 0x040001EF RID: 495
		private bool automated_;
	}
}
