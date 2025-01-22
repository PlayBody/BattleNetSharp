using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D4 RID: 468
	public sealed class AIStateDebugSnapshotEntry : IMessage<AIStateDebugSnapshotEntry>, IMessage, IEquatable<AIStateDebugSnapshotEntry>, IDeepCloneable<AIStateDebugSnapshotEntry>, IBufferMessage
	{
		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000C6970 File Offset: 0x000C4B70
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugSnapshotEntry> Parser
		{
			get
			{
				return AIStateDebugSnapshotEntry._parser;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x000C6988 File Offset: 0x000C4B88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000C69AC File Offset: 0x000C4BAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugSnapshotEntry.Descriptor;
			}
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000C69C3 File Offset: 0x000C4BC3
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntry()
		{
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000C69E4 File Offset: 0x000C4BE4
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntry(AIStateDebugSnapshotEntry other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.powerSno_ = other.powerSno_;
			this.powerTargetName_ = other.powerTargetName_;
			this.aistateSwitchName_ = other.aistateSwitchName_;
			this.aistateSwitchNameHash_ = other.aistateSwitchNameHash_;
			this.startConditions_ = other.startConditions_.Clone();
			this.interruptConditions_ = other.interruptConditions_.Clone();
			this.cooldownTicksRemaining_ = other.cooldownTicksRemaining_;
			this.isCurrentPrimary_ = other.isCurrentPrimary_;
			this.evaluated_ = other.evaluated_;
			this.failed_ = other.failed_;
			this.selected_ = other.selected_;
			this.powerFailureReasonsString_ = other.powerFailureReasonsString_;
			this.cooldownKey_ = other.cooldownKey_;
			this.enabled_ = other.enabled_;
			this.evaluationOrder_ = other.evaluationOrder_;
			this.weight_ = other.weight_;
			this.targetAnn_ = other.targetAnn_;
			this.targetWorldPlace_ = ((other.targetWorldPlace_ != null) ? other.targetWorldPlace_.Clone() : null);
			this.variantMismatch_ = other.variantMismatch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000C6B20 File Offset: 0x000C4D20
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntry Clone()
		{
			return new AIStateDebugSnapshotEntry(this);
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x000C6B38 File Offset: 0x000C4D38
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x000C6B59 File Offset: 0x000C4D59
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? AIStateDebugSnapshotEntry.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x000C6B70 File Offset: 0x000C4D70
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000C6B8B File Offset: 0x000C4D8B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x000C6B98 File Offset: 0x000C4D98
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x000C6BC9 File Offset: 0x000C4DC9
		[DebuggerNonUserCode]
		public int PowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int powerSnoDefaultValue;
				if (flag)
				{
					powerSnoDefaultValue = this.powerSno_;
				}
				else
				{
					powerSnoDefaultValue = AIStateDebugSnapshotEntry.PowerSnoDefaultValue;
				}
				return powerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.powerSno_ = value;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x000C6BE4 File Offset: 0x000C4DE4
		[DebuggerNonUserCode]
		public bool HasPowerSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000C6C01 File Offset: 0x000C4E01
		[DebuggerNonUserCode]
		public void ClearPowerSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000C6C14 File Offset: 0x000C4E14
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x000C6C35 File Offset: 0x000C4E35
		[DebuggerNonUserCode]
		public string PowerTargetName
		{
			get
			{
				return this.powerTargetName_ ?? AIStateDebugSnapshotEntry.PowerTargetNameDefaultValue;
			}
			set
			{
				this.powerTargetName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000C6C4C File Offset: 0x000C4E4C
		[DebuggerNonUserCode]
		public bool HasPowerTargetName
		{
			get
			{
				return this.powerTargetName_ != null;
			}
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000C6C67 File Offset: 0x000C4E67
		[DebuggerNonUserCode]
		public void ClearPowerTargetName()
		{
			this.powerTargetName_ = null;
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000C6C74 File Offset: 0x000C4E74
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x000C6C95 File Offset: 0x000C4E95
		[DebuggerNonUserCode]
		public string AistateSwitchName
		{
			get
			{
				return this.aistateSwitchName_ ?? AIStateDebugSnapshotEntry.AistateSwitchNameDefaultValue;
			}
			set
			{
				this.aistateSwitchName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000C6CAC File Offset: 0x000C4EAC
		[DebuggerNonUserCode]
		public bool HasAistateSwitchName
		{
			get
			{
				return this.aistateSwitchName_ != null;
			}
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000C6CC7 File Offset: 0x000C4EC7
		[DebuggerNonUserCode]
		public void ClearAistateSwitchName()
		{
			this.aistateSwitchName_ = null;
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x000C6CD4 File Offset: 0x000C4ED4
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x000C6D05 File Offset: 0x000C4F05
		[DebuggerNonUserCode]
		public uint AistateSwitchNameHash
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint aistateSwitchNameHashDefaultValue;
				if (flag)
				{
					aistateSwitchNameHashDefaultValue = this.aistateSwitchNameHash_;
				}
				else
				{
					aistateSwitchNameHashDefaultValue = AIStateDebugSnapshotEntry.AistateSwitchNameHashDefaultValue;
				}
				return aistateSwitchNameHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.aistateSwitchNameHash_ = value;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000C6D20 File Offset: 0x000C4F20
		[DebuggerNonUserCode]
		public bool HasAistateSwitchNameHash
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000C6D3D File Offset: 0x000C4F3D
		[DebuggerNonUserCode]
		public void ClearAistateSwitchNameHash()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x000C6D50 File Offset: 0x000C4F50
		[DebuggerNonUserCode]
		public RepeatedField<AIStateDebugSnapshotEntryCondition> StartConditions
		{
			get
			{
				return this.startConditions_;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x000C6D68 File Offset: 0x000C4F68
		[DebuggerNonUserCode]
		public RepeatedField<AIStateDebugSnapshotEntryCondition> InterruptConditions
		{
			get
			{
				return this.interruptConditions_;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000C6D80 File Offset: 0x000C4F80
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x000C6DB1 File Offset: 0x000C4FB1
		[DebuggerNonUserCode]
		public uint CooldownTicksRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint cooldownTicksRemainingDefaultValue;
				if (flag)
				{
					cooldownTicksRemainingDefaultValue = this.cooldownTicksRemaining_;
				}
				else
				{
					cooldownTicksRemainingDefaultValue = AIStateDebugSnapshotEntry.CooldownTicksRemainingDefaultValue;
				}
				return cooldownTicksRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.cooldownTicksRemaining_ = value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x000C6DCC File Offset: 0x000C4FCC
		[DebuggerNonUserCode]
		public bool HasCooldownTicksRemaining
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000C6DE9 File Offset: 0x000C4FE9
		[DebuggerNonUserCode]
		public void ClearCooldownTicksRemaining()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000C6DFC File Offset: 0x000C4FFC
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x000C6E2D File Offset: 0x000C502D
		[DebuggerNonUserCode]
		public bool IsCurrentPrimary
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isCurrentPrimaryDefaultValue;
				if (flag)
				{
					isCurrentPrimaryDefaultValue = this.isCurrentPrimary_;
				}
				else
				{
					isCurrentPrimaryDefaultValue = AIStateDebugSnapshotEntry.IsCurrentPrimaryDefaultValue;
				}
				return isCurrentPrimaryDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isCurrentPrimary_ = value;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000C6E48 File Offset: 0x000C5048
		[DebuggerNonUserCode]
		public bool HasIsCurrentPrimary
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000C6E65 File Offset: 0x000C5065
		[DebuggerNonUserCode]
		public void ClearIsCurrentPrimary()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000C6E78 File Offset: 0x000C5078
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x000C6EAA File Offset: 0x000C50AA
		[DebuggerNonUserCode]
		public bool Evaluated
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool evaluatedDefaultValue;
				if (flag)
				{
					evaluatedDefaultValue = this.evaluated_;
				}
				else
				{
					evaluatedDefaultValue = AIStateDebugSnapshotEntry.EvaluatedDefaultValue;
				}
				return evaluatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.evaluated_ = value;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000C6EC4 File Offset: 0x000C50C4
		[DebuggerNonUserCode]
		public bool HasEvaluated
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000C6EE2 File Offset: 0x000C50E2
		[DebuggerNonUserCode]
		public void ClearEvaluated()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000C6EF4 File Offset: 0x000C50F4
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x000C6F26 File Offset: 0x000C5126
		[DebuggerNonUserCode]
		public bool Failed
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool failedDefaultValue;
				if (flag)
				{
					failedDefaultValue = this.failed_;
				}
				else
				{
					failedDefaultValue = AIStateDebugSnapshotEntry.FailedDefaultValue;
				}
				return failedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.failed_ = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000C6F40 File Offset: 0x000C5140
		[DebuggerNonUserCode]
		public bool HasFailed
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000C6F5E File Offset: 0x000C515E
		[DebuggerNonUserCode]
		public void ClearFailed()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x000C6F70 File Offset: 0x000C5170
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x000C6FA2 File Offset: 0x000C51A2
		[DebuggerNonUserCode]
		public bool Selected
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool selectedDefaultValue;
				if (flag)
				{
					selectedDefaultValue = this.selected_;
				}
				else
				{
					selectedDefaultValue = AIStateDebugSnapshotEntry.SelectedDefaultValue;
				}
				return selectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.selected_ = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x000C6FBC File Offset: 0x000C51BC
		[DebuggerNonUserCode]
		public bool HasSelected
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000C6FDA File Offset: 0x000C51DA
		[DebuggerNonUserCode]
		public void ClearSelected()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x000C6FEC File Offset: 0x000C51EC
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x000C700D File Offset: 0x000C520D
		[DebuggerNonUserCode]
		public string PowerFailureReasonsString
		{
			get
			{
				return this.powerFailureReasonsString_ ?? AIStateDebugSnapshotEntry.PowerFailureReasonsStringDefaultValue;
			}
			set
			{
				this.powerFailureReasonsString_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x000C7024 File Offset: 0x000C5224
		[DebuggerNonUserCode]
		public bool HasPowerFailureReasonsString
		{
			get
			{
				return this.powerFailureReasonsString_ != null;
			}
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000C703F File Offset: 0x000C523F
		[DebuggerNonUserCode]
		public void ClearPowerFailureReasonsString()
		{
			this.powerFailureReasonsString_ = null;
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x000C704C File Offset: 0x000C524C
		// (set) Token: 0x06003269 RID: 12905 RVA: 0x000C7081 File Offset: 0x000C5281
		[DebuggerNonUserCode]
		public ulong CooldownKey
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				ulong cooldownKeyDefaultValue;
				if (flag)
				{
					cooldownKeyDefaultValue = this.cooldownKey_;
				}
				else
				{
					cooldownKeyDefaultValue = AIStateDebugSnapshotEntry.CooldownKeyDefaultValue;
				}
				return cooldownKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.cooldownKey_ = value;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x000C70A0 File Offset: 0x000C52A0
		[DebuggerNonUserCode]
		public bool HasCooldownKey
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000C70C1 File Offset: 0x000C52C1
		[DebuggerNonUserCode]
		public void ClearCooldownKey()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x000C70D8 File Offset: 0x000C52D8
		// (set) Token: 0x0600326D RID: 12909 RVA: 0x000C710D File Offset: 0x000C530D
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = AIStateDebugSnapshotEntry.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.enabled_ = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x000C712C File Offset: 0x000C532C
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x000C714D File Offset: 0x000C534D
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x000C7164 File Offset: 0x000C5364
		// (set) Token: 0x06003271 RID: 12913 RVA: 0x000C7199 File Offset: 0x000C5399
		[DebuggerNonUserCode]
		public uint EvaluationOrder
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint evaluationOrderDefaultValue;
				if (flag)
				{
					evaluationOrderDefaultValue = this.evaluationOrder_;
				}
				else
				{
					evaluationOrderDefaultValue = AIStateDebugSnapshotEntry.EvaluationOrderDefaultValue;
				}
				return evaluationOrderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.evaluationOrder_ = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x000C71B8 File Offset: 0x000C53B8
		[DebuggerNonUserCode]
		public bool HasEvaluationOrder
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000C71D9 File Offset: 0x000C53D9
		[DebuggerNonUserCode]
		public void ClearEvaluationOrder()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x000C71F0 File Offset: 0x000C53F0
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x000C7225 File Offset: 0x000C5425
		[DebuggerNonUserCode]
		public uint Weight
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint weightDefaultValue;
				if (flag)
				{
					weightDefaultValue = this.weight_;
				}
				else
				{
					weightDefaultValue = AIStateDebugSnapshotEntry.WeightDefaultValue;
				}
				return weightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.weight_ = value;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x000C7244 File Offset: 0x000C5444
		[DebuggerNonUserCode]
		public bool HasWeight
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000C7265 File Offset: 0x000C5465
		[DebuggerNonUserCode]
		public void ClearWeight()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000C727C File Offset: 0x000C547C
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x000C72B1 File Offset: 0x000C54B1
		[DebuggerNonUserCode]
		public uint TargetAnn
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint targetAnnDefaultValue;
				if (flag)
				{
					targetAnnDefaultValue = this.targetAnn_;
				}
				else
				{
					targetAnnDefaultValue = AIStateDebugSnapshotEntry.TargetAnnDefaultValue;
				}
				return targetAnnDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.targetAnn_ = value;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000C72D0 File Offset: 0x000C54D0
		[DebuggerNonUserCode]
		public bool HasTargetAnn
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000C72F1 File Offset: 0x000C54F1
		[DebuggerNonUserCode]
		public void ClearTargetAnn()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x000C7308 File Offset: 0x000C5508
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x000C7320 File Offset: 0x000C5520
		[DebuggerNonUserCode]
		public DebugWorldPlace TargetWorldPlace
		{
			get
			{
				return this.targetWorldPlace_;
			}
			set
			{
				this.targetWorldPlace_ = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x000C732C File Offset: 0x000C552C
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x000C7361 File Offset: 0x000C5561
		[DebuggerNonUserCode]
		public bool VariantMismatch
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool variantMismatchDefaultValue;
				if (flag)
				{
					variantMismatchDefaultValue = this.variantMismatch_;
				}
				else
				{
					variantMismatchDefaultValue = AIStateDebugSnapshotEntry.VariantMismatchDefaultValue;
				}
				return variantMismatchDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.variantMismatch_ = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x000C7380 File Offset: 0x000C5580
		[DebuggerNonUserCode]
		public bool HasVariantMismatch
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000C73A1 File Offset: 0x000C55A1
		[DebuggerNonUserCode]
		public void ClearVariantMismatch()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000C73B8 File Offset: 0x000C55B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugSnapshotEntry);
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000C73D8 File Offset: 0x000C55D8
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugSnapshotEntry other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PowerSno != other.PowerSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PowerTargetName != other.PowerTargetName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AistateSwitchName != other.AistateSwitchName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AistateSwitchNameHash != other.AistateSwitchNameHash;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.startConditions_.Equals(other.startConditions_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.interruptConditions_.Equals(other.interruptConditions_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CooldownTicksRemaining != other.CooldownTicksRemaining;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.IsCurrentPrimary != other.IsCurrentPrimary;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Evaluated != other.Evaluated;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Failed != other.Failed;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Selected != other.Selected;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.PowerFailureReasonsString != other.PowerFailureReasonsString;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.CooldownKey != other.CooldownKey;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.Enabled != other.Enabled;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.EvaluationOrder != other.EvaluationOrder;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.Weight != other.Weight;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.TargetAnn != other.TargetAnn;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !object.Equals(this.TargetWorldPlace, other.TargetWorldPlace);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.VariantMismatch != other.VariantMismatch;
																								flag2 = !flag23 && object.Equals(this._unknownFields, other._unknownFields);
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
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

		// Token: 0x06003284 RID: 12932 RVA: 0x000C7670 File Offset: 0x000C5870
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num ^= this.PowerSno.GetHashCode();
			}
			bool hasPowerTargetName = this.HasPowerTargetName;
			if (hasPowerTargetName)
			{
				num ^= this.PowerTargetName.GetHashCode();
			}
			bool hasAistateSwitchName = this.HasAistateSwitchName;
			if (hasAistateSwitchName)
			{
				num ^= this.AistateSwitchName.GetHashCode();
			}
			bool hasAistateSwitchNameHash = this.HasAistateSwitchNameHash;
			if (hasAistateSwitchNameHash)
			{
				num ^= this.AistateSwitchNameHash.GetHashCode();
			}
			num ^= this.startConditions_.GetHashCode();
			num ^= this.interruptConditions_.GetHashCode();
			bool hasCooldownTicksRemaining = this.HasCooldownTicksRemaining;
			if (hasCooldownTicksRemaining)
			{
				num ^= this.CooldownTicksRemaining.GetHashCode();
			}
			bool hasIsCurrentPrimary = this.HasIsCurrentPrimary;
			if (hasIsCurrentPrimary)
			{
				num ^= this.IsCurrentPrimary.GetHashCode();
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				num ^= this.Evaluated.GetHashCode();
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				num ^= this.Failed.GetHashCode();
			}
			bool hasSelected = this.HasSelected;
			if (hasSelected)
			{
				num ^= this.Selected.GetHashCode();
			}
			bool hasPowerFailureReasonsString = this.HasPowerFailureReasonsString;
			if (hasPowerFailureReasonsString)
			{
				num ^= this.PowerFailureReasonsString.GetHashCode();
			}
			bool hasCooldownKey = this.HasCooldownKey;
			if (hasCooldownKey)
			{
				num ^= this.CooldownKey.GetHashCode();
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool hasEvaluationOrder = this.HasEvaluationOrder;
			if (hasEvaluationOrder)
			{
				num ^= this.EvaluationOrder.GetHashCode();
			}
			bool hasWeight = this.HasWeight;
			if (hasWeight)
			{
				num ^= this.Weight.GetHashCode();
			}
			bool hasTargetAnn = this.HasTargetAnn;
			if (hasTargetAnn)
			{
				num ^= this.TargetAnn.GetHashCode();
			}
			bool flag = this.targetWorldPlace_ != null;
			if (flag)
			{
				num ^= this.TargetWorldPlace.GetHashCode();
			}
			bool hasVariantMismatch = this.HasVariantMismatch;
			if (hasVariantMismatch)
			{
				num ^= this.VariantMismatch.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000C78C8 File Offset: 0x000C5AC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x000C78E0 File Offset: 0x000C5AE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000C78EC File Offset: 0x000C5AEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.PowerSno);
			}
			bool hasPowerTargetName = this.HasPowerTargetName;
			if (hasPowerTargetName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PowerTargetName);
			}
			bool hasAistateSwitchName = this.HasAistateSwitchName;
			if (hasAistateSwitchName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.AistateSwitchName);
			}
			bool hasAistateSwitchNameHash = this.HasAistateSwitchNameHash;
			if (hasAistateSwitchNameHash)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AistateSwitchNameHash);
			}
			this.startConditions_.WriteTo(ref output, AIStateDebugSnapshotEntry._repeated_startConditions_codec);
			this.interruptConditions_.WriteTo(ref output, AIStateDebugSnapshotEntry._repeated_interruptConditions_codec);
			bool hasCooldownTicksRemaining = this.HasCooldownTicksRemaining;
			if (hasCooldownTicksRemaining)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CooldownTicksRemaining);
			}
			bool hasIsCurrentPrimary = this.HasIsCurrentPrimary;
			if (hasIsCurrentPrimary)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsCurrentPrimary);
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Evaluated);
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Failed);
			}
			bool hasSelected = this.HasSelected;
			if (hasSelected)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Selected);
			}
			bool hasPowerFailureReasonsString = this.HasPowerFailureReasonsString;
			if (hasPowerFailureReasonsString)
			{
				output.WriteRawTag(106);
				output.WriteString(this.PowerFailureReasonsString);
			}
			bool hasCooldownKey = this.HasCooldownKey;
			if (hasCooldownKey)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.CooldownKey);
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Enabled);
			}
			bool hasEvaluationOrder = this.HasEvaluationOrder;
			if (hasEvaluationOrder)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.EvaluationOrder);
			}
			bool hasWeight = this.HasWeight;
			if (hasWeight)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.Weight);
			}
			bool hasTargetAnn = this.HasTargetAnn;
			if (hasTargetAnn)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.TargetAnn);
			}
			bool flag = this.targetWorldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.TargetWorldPlace);
			}
			bool hasVariantMismatch = this.HasVariantMismatch;
			if (hasVariantMismatch)
			{
				output.WriteRawTag(160, 1);
				output.WriteBool(this.VariantMismatch);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000C7BD4 File Offset: 0x000C5DD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num += 5;
			}
			bool hasPowerTargetName = this.HasPowerTargetName;
			if (hasPowerTargetName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PowerTargetName);
			}
			bool hasAistateSwitchName = this.HasAistateSwitchName;
			if (hasAistateSwitchName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AistateSwitchName);
			}
			bool hasAistateSwitchNameHash = this.HasAistateSwitchNameHash;
			if (hasAistateSwitchNameHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AistateSwitchNameHash);
			}
			num += this.startConditions_.CalculateSize(AIStateDebugSnapshotEntry._repeated_startConditions_codec);
			num += this.interruptConditions_.CalculateSize(AIStateDebugSnapshotEntry._repeated_interruptConditions_codec);
			bool hasCooldownTicksRemaining = this.HasCooldownTicksRemaining;
			if (hasCooldownTicksRemaining)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CooldownTicksRemaining);
			}
			bool hasIsCurrentPrimary = this.HasIsCurrentPrimary;
			if (hasIsCurrentPrimary)
			{
				num += 2;
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				num += 2;
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				num += 2;
			}
			bool hasSelected = this.HasSelected;
			if (hasSelected)
			{
				num += 2;
			}
			bool hasPowerFailureReasonsString = this.HasPowerFailureReasonsString;
			if (hasPowerFailureReasonsString)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PowerFailureReasonsString);
			}
			bool hasCooldownKey = this.HasCooldownKey;
			if (hasCooldownKey)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CooldownKey);
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num += 2;
			}
			bool hasEvaluationOrder = this.HasEvaluationOrder;
			if (hasEvaluationOrder)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.EvaluationOrder);
			}
			bool hasWeight = this.HasWeight;
			if (hasWeight)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.Weight);
			}
			bool hasTargetAnn = this.HasTargetAnn;
			if (hasTargetAnn)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.TargetAnn);
			}
			bool flag = this.targetWorldPlace_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TargetWorldPlace);
			}
			bool hasVariantMismatch = this.HasVariantMismatch;
			if (hasVariantMismatch)
			{
				num += 3;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000C7DF8 File Offset: 0x000C5FF8
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugSnapshotEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasPowerSno = other.HasPowerSno;
				if (hasPowerSno)
				{
					this.PowerSno = other.PowerSno;
				}
				bool hasPowerTargetName = other.HasPowerTargetName;
				if (hasPowerTargetName)
				{
					this.PowerTargetName = other.PowerTargetName;
				}
				bool hasAistateSwitchName = other.HasAistateSwitchName;
				if (hasAistateSwitchName)
				{
					this.AistateSwitchName = other.AistateSwitchName;
				}
				bool hasAistateSwitchNameHash = other.HasAistateSwitchNameHash;
				if (hasAistateSwitchNameHash)
				{
					this.AistateSwitchNameHash = other.AistateSwitchNameHash;
				}
				this.startConditions_.Add(other.startConditions_);
				this.interruptConditions_.Add(other.interruptConditions_);
				bool hasCooldownTicksRemaining = other.HasCooldownTicksRemaining;
				if (hasCooldownTicksRemaining)
				{
					this.CooldownTicksRemaining = other.CooldownTicksRemaining;
				}
				bool hasIsCurrentPrimary = other.HasIsCurrentPrimary;
				if (hasIsCurrentPrimary)
				{
					this.IsCurrentPrimary = other.IsCurrentPrimary;
				}
				bool hasEvaluated = other.HasEvaluated;
				if (hasEvaluated)
				{
					this.Evaluated = other.Evaluated;
				}
				bool hasFailed = other.HasFailed;
				if (hasFailed)
				{
					this.Failed = other.Failed;
				}
				bool hasSelected = other.HasSelected;
				if (hasSelected)
				{
					this.Selected = other.Selected;
				}
				bool hasPowerFailureReasonsString = other.HasPowerFailureReasonsString;
				if (hasPowerFailureReasonsString)
				{
					this.PowerFailureReasonsString = other.PowerFailureReasonsString;
				}
				bool hasCooldownKey = other.HasCooldownKey;
				if (hasCooldownKey)
				{
					this.CooldownKey = other.CooldownKey;
				}
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				bool hasEvaluationOrder = other.HasEvaluationOrder;
				if (hasEvaluationOrder)
				{
					this.EvaluationOrder = other.EvaluationOrder;
				}
				bool hasWeight = other.HasWeight;
				if (hasWeight)
				{
					this.Weight = other.Weight;
				}
				bool hasTargetAnn = other.HasTargetAnn;
				if (hasTargetAnn)
				{
					this.TargetAnn = other.TargetAnn;
				}
				bool flag2 = other.targetWorldPlace_ != null;
				if (flag2)
				{
					bool flag3 = this.targetWorldPlace_ == null;
					if (flag3)
					{
						this.TargetWorldPlace = new DebugWorldPlace();
					}
					this.TargetWorldPlace.MergeFrom(other.TargetWorldPlace);
				}
				bool hasVariantMismatch = other.HasVariantMismatch;
				if (hasVariantMismatch)
				{
					this.VariantMismatch = other.VariantMismatch;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000C8054 File Offset: 0x000C6254
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000C8060 File Offset: 0x000C6260
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 80U)
				{
					if (num3 <= 40U)
					{
						if (num3 <= 21U)
						{
							if (num3 != 10U)
							{
								if (num3 != 21U)
								{
									goto IL_0114;
								}
								this.PowerSno = input.ReadSFixed32();
							}
							else
							{
								this.Name = input.ReadString();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								if (num3 != 40U)
								{
									goto IL_0114;
								}
								this.AistateSwitchNameHash = input.ReadUInt32();
							}
							else
							{
								this.AistateSwitchName = input.ReadString();
							}
						}
						else
						{
							this.PowerTargetName = input.ReadString();
						}
					}
					else if (num3 <= 58U)
					{
						if (num3 != 50U)
						{
							if (num3 != 58U)
							{
								goto IL_0114;
							}
							this.interruptConditions_.AddEntriesFrom(ref input, AIStateDebugSnapshotEntry._repeated_interruptConditions_codec);
						}
						else
						{
							this.startConditions_.AddEntriesFrom(ref input, AIStateDebugSnapshotEntry._repeated_startConditions_codec);
						}
					}
					else if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							if (num3 != 80U)
							{
								goto IL_0114;
							}
							this.Evaluated = input.ReadBool();
						}
						else
						{
							this.IsCurrentPrimary = input.ReadBool();
						}
					}
					else
					{
						this.CooldownTicksRemaining = input.ReadUInt32();
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 <= 96U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_0114;
							}
							this.Selected = input.ReadBool();
						}
						else
						{
							this.Failed = input.ReadBool();
						}
					}
					else if (num3 != 106U)
					{
						if (num3 != 112U)
						{
							if (num3 != 120U)
							{
								goto IL_0114;
							}
							this.Enabled = input.ReadBool();
						}
						else
						{
							this.CooldownKey = input.ReadUInt64();
						}
					}
					else
					{
						this.PowerFailureReasonsString = input.ReadString();
					}
				}
				else if (num3 <= 136U)
				{
					if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							goto IL_0114;
						}
						this.Weight = input.ReadUInt32();
					}
					else
					{
						this.EvaluationOrder = input.ReadUInt32();
					}
				}
				else if (num3 != 144U)
				{
					if (num3 != 154U)
					{
						if (num3 != 160U)
						{
							goto IL_0114;
						}
						this.VariantMismatch = input.ReadBool();
					}
					else
					{
						bool flag = this.targetWorldPlace_ == null;
						if (flag)
						{
							this.TargetWorldPlace = new DebugWorldPlace();
						}
						input.ReadMessage(this.TargetWorldPlace);
					}
				}
				else
				{
					this.TargetAnn = input.ReadUInt32();
				}
				continue;
				IL_0114:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001709 RID: 5897
		private static readonly MessageParser<AIStateDebugSnapshotEntry> _parser = new MessageParser<AIStateDebugSnapshotEntry>(() => new AIStateDebugSnapshotEntry());

		// Token: 0x0400170A RID: 5898
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400170B RID: 5899
		private int _hasBits0;

		// Token: 0x0400170C RID: 5900
		public const int NameFieldNumber = 1;

		// Token: 0x0400170D RID: 5901
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400170E RID: 5902
		private string name_;

		// Token: 0x0400170F RID: 5903
		public const int PowerSnoFieldNumber = 2;

		// Token: 0x04001710 RID: 5904
		private static readonly int PowerSnoDefaultValue = 0;

		// Token: 0x04001711 RID: 5905
		private int powerSno_;

		// Token: 0x04001712 RID: 5906
		public const int PowerTargetNameFieldNumber = 3;

		// Token: 0x04001713 RID: 5907
		private static readonly string PowerTargetNameDefaultValue = "";

		// Token: 0x04001714 RID: 5908
		private string powerTargetName_;

		// Token: 0x04001715 RID: 5909
		public const int AistateSwitchNameFieldNumber = 4;

		// Token: 0x04001716 RID: 5910
		private static readonly string AistateSwitchNameDefaultValue = "";

		// Token: 0x04001717 RID: 5911
		private string aistateSwitchName_;

		// Token: 0x04001718 RID: 5912
		public const int AistateSwitchNameHashFieldNumber = 5;

		// Token: 0x04001719 RID: 5913
		private static readonly uint AistateSwitchNameHashDefaultValue = 0U;

		// Token: 0x0400171A RID: 5914
		private uint aistateSwitchNameHash_;

		// Token: 0x0400171B RID: 5915
		public const int StartConditionsFieldNumber = 6;

		// Token: 0x0400171C RID: 5916
		private static readonly FieldCodec<AIStateDebugSnapshotEntryCondition> _repeated_startConditions_codec = FieldCodec.ForMessage<AIStateDebugSnapshotEntryCondition>(50U, AIStateDebugSnapshotEntryCondition.Parser);

		// Token: 0x0400171D RID: 5917
		private readonly RepeatedField<AIStateDebugSnapshotEntryCondition> startConditions_ = new RepeatedField<AIStateDebugSnapshotEntryCondition>();

		// Token: 0x0400171E RID: 5918
		public const int InterruptConditionsFieldNumber = 7;

		// Token: 0x0400171F RID: 5919
		private static readonly FieldCodec<AIStateDebugSnapshotEntryCondition> _repeated_interruptConditions_codec = FieldCodec.ForMessage<AIStateDebugSnapshotEntryCondition>(58U, AIStateDebugSnapshotEntryCondition.Parser);

		// Token: 0x04001720 RID: 5920
		private readonly RepeatedField<AIStateDebugSnapshotEntryCondition> interruptConditions_ = new RepeatedField<AIStateDebugSnapshotEntryCondition>();

		// Token: 0x04001721 RID: 5921
		public const int CooldownTicksRemainingFieldNumber = 8;

		// Token: 0x04001722 RID: 5922
		private static readonly uint CooldownTicksRemainingDefaultValue = 0U;

		// Token: 0x04001723 RID: 5923
		private uint cooldownTicksRemaining_;

		// Token: 0x04001724 RID: 5924
		public const int IsCurrentPrimaryFieldNumber = 9;

		// Token: 0x04001725 RID: 5925
		private static readonly bool IsCurrentPrimaryDefaultValue = false;

		// Token: 0x04001726 RID: 5926
		private bool isCurrentPrimary_;

		// Token: 0x04001727 RID: 5927
		public const int EvaluatedFieldNumber = 10;

		// Token: 0x04001728 RID: 5928
		private static readonly bool EvaluatedDefaultValue = false;

		// Token: 0x04001729 RID: 5929
		private bool evaluated_;

		// Token: 0x0400172A RID: 5930
		public const int FailedFieldNumber = 11;

		// Token: 0x0400172B RID: 5931
		private static readonly bool FailedDefaultValue = false;

		// Token: 0x0400172C RID: 5932
		private bool failed_;

		// Token: 0x0400172D RID: 5933
		public const int SelectedFieldNumber = 12;

		// Token: 0x0400172E RID: 5934
		private static readonly bool SelectedDefaultValue = false;

		// Token: 0x0400172F RID: 5935
		private bool selected_;

		// Token: 0x04001730 RID: 5936
		public const int PowerFailureReasonsStringFieldNumber = 13;

		// Token: 0x04001731 RID: 5937
		private static readonly string PowerFailureReasonsStringDefaultValue = "";

		// Token: 0x04001732 RID: 5938
		private string powerFailureReasonsString_;

		// Token: 0x04001733 RID: 5939
		public const int CooldownKeyFieldNumber = 14;

		// Token: 0x04001734 RID: 5940
		private static readonly ulong CooldownKeyDefaultValue = 0UL;

		// Token: 0x04001735 RID: 5941
		private ulong cooldownKey_;

		// Token: 0x04001736 RID: 5942
		public const int EnabledFieldNumber = 15;

		// Token: 0x04001737 RID: 5943
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x04001738 RID: 5944
		private bool enabled_;

		// Token: 0x04001739 RID: 5945
		public const int EvaluationOrderFieldNumber = 16;

		// Token: 0x0400173A RID: 5946
		private static readonly uint EvaluationOrderDefaultValue = 0U;

		// Token: 0x0400173B RID: 5947
		private uint evaluationOrder_;

		// Token: 0x0400173C RID: 5948
		public const int WeightFieldNumber = 17;

		// Token: 0x0400173D RID: 5949
		private static readonly uint WeightDefaultValue = 0U;

		// Token: 0x0400173E RID: 5950
		private uint weight_;

		// Token: 0x0400173F RID: 5951
		public const int TargetAnnFieldNumber = 18;

		// Token: 0x04001740 RID: 5952
		private static readonly uint TargetAnnDefaultValue = 0U;

		// Token: 0x04001741 RID: 5953
		private uint targetAnn_;

		// Token: 0x04001742 RID: 5954
		public const int TargetWorldPlaceFieldNumber = 19;

		// Token: 0x04001743 RID: 5955
		private DebugWorldPlace targetWorldPlace_;

		// Token: 0x04001744 RID: 5956
		public const int VariantMismatchFieldNumber = 20;

		// Token: 0x04001745 RID: 5957
		private static readonly bool VariantMismatchDefaultValue = false;

		// Token: 0x04001746 RID: 5958
		private bool variantMismatch_;
	}
}
