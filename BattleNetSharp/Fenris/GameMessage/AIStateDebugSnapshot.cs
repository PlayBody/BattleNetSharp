using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D8 RID: 472
	public sealed class AIStateDebugSnapshot : IMessage<AIStateDebugSnapshot>, IMessage, IEquatable<AIStateDebugSnapshot>, IDeepCloneable<AIStateDebugSnapshot>, IBufferMessage
	{
		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x000C94A4 File Offset: 0x000C76A4
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugSnapshot> Parser
		{
			get
			{
				return AIStateDebugSnapshot._parser;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x000C94BC File Offset: 0x000C76BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x000C94E0 File Offset: 0x000C76E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugSnapshot.Descriptor;
			}
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000C94F8 File Offset: 0x000C76F8
		[DebuggerNonUserCode]
		public AIStateDebugSnapshot()
		{
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000C9550 File Offset: 0x000C7750
		[DebuggerNonUserCode]
		public AIStateDebugSnapshot(AIStateDebugSnapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ann_ = other.ann_;
			this.commandFrame_ = other.commandFrame_;
			this.worldPlace_ = ((other.worldPlace_ != null) ? other.worldPlace_.Clone() : null);
			this.yaw_ = other.yaw_;
			this.currentPower_ = ((other.currentPower_ != null) ? other.currentPower_.Clone() : null);
			this.primaryAistateName_ = other.primaryAistateName_;
			this.ticksInPrimaryAistate_ = other.ticksInPrimaryAistate_;
			this.queuedAistateSwitchName_ = other.queuedAistateSwitchName_;
			this.entries_ = other.entries_.Clone();
			this.mergedAistateNames_ = other.mergedAistateNames_.Clone();
			this.hostileTargets_ = other.hostileTargets_.Clone();
			this.friendlyTargets_ = other.friendlyTargets_.Clone();
			this.aipropTargets_ = other.aipropTargets_.Clone();
			this.currentAibehaviorName_ = other.currentAibehaviorName_;
			this.variableSnapshot_ = ((other.variableSnapshot_ != null) ? other.variableSnapshot_.Clone() : null);
			this.queuedAistateSwitchTicksRemaining_ = other.queuedAistateSwitchTicksRemaining_;
			this.queuedAistateSwitchEntryIndex_ = other.queuedAistateSwitchEntryIndex_;
			this.cachedTargets_ = other.cachedTargets_.Clone();
			this.forcedCooldownKey_ = other.forcedCooldownKey_;
			this.forcedCooldown_ = other.forcedCooldown_;
			this.chosenWeight_ = other.chosenWeight_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000C96CC File Offset: 0x000C78CC
		[DebuggerNonUserCode]
		public AIStateDebugSnapshot Clone()
		{
			return new AIStateDebugSnapshot(this);
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x000C96E4 File Offset: 0x000C78E4
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x000C9715 File Offset: 0x000C7915
		[DebuggerNonUserCode]
		public uint Ann
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint annDefaultValue;
				if (flag)
				{
					annDefaultValue = this.ann_;
				}
				else
				{
					annDefaultValue = AIStateDebugSnapshot.AnnDefaultValue;
				}
				return annDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ann_ = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000C9730 File Offset: 0x000C7930
		[DebuggerNonUserCode]
		public bool HasAnn
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x000C974D File Offset: 0x000C794D
		[DebuggerNonUserCode]
		public void ClearAnn()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x000C9760 File Offset: 0x000C7960
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x000C9791 File Offset: 0x000C7991
		[DebuggerNonUserCode]
		public uint CommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint commandFrameDefaultValue;
				if (flag)
				{
					commandFrameDefaultValue = this.commandFrame_;
				}
				else
				{
					commandFrameDefaultValue = AIStateDebugSnapshot.CommandFrameDefaultValue;
				}
				return commandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.commandFrame_ = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x000C97AC File Offset: 0x000C79AC
		[DebuggerNonUserCode]
		public bool HasCommandFrame
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000C97C9 File Offset: 0x000C79C9
		[DebuggerNonUserCode]
		public void ClearCommandFrame()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x000C97DC File Offset: 0x000C79DC
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x000C97F4 File Offset: 0x000C79F4
		[DebuggerNonUserCode]
		public DebugWorldPlace WorldPlace
		{
			get
			{
				return this.worldPlace_;
			}
			set
			{
				this.worldPlace_ = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x000C9800 File Offset: 0x000C7A00
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x000C9831 File Offset: 0x000C7A31
		[DebuggerNonUserCode]
		public float Yaw
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float yawDefaultValue;
				if (flag)
				{
					yawDefaultValue = this.yaw_;
				}
				else
				{
					yawDefaultValue = AIStateDebugSnapshot.YawDefaultValue;
				}
				return yawDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.yaw_ = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x000C984C File Offset: 0x000C7A4C
		[DebuggerNonUserCode]
		public bool HasYaw
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x000C9869 File Offset: 0x000C7A69
		[DebuggerNonUserCode]
		public void ClearYaw()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x000C987C File Offset: 0x000C7A7C
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x000C9894 File Offset: 0x000C7A94
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotCurrentPower CurrentPower
		{
			get
			{
				return this.currentPower_;
			}
			set
			{
				this.currentPower_ = value;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x000C98A0 File Offset: 0x000C7AA0
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x000C98C1 File Offset: 0x000C7AC1
		[DebuggerNonUserCode]
		public string PrimaryAistateName
		{
			get
			{
				return this.primaryAistateName_ ?? AIStateDebugSnapshot.PrimaryAistateNameDefaultValue;
			}
			set
			{
				this.primaryAistateName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x000C98D8 File Offset: 0x000C7AD8
		[DebuggerNonUserCode]
		public bool HasPrimaryAistateName
		{
			get
			{
				return this.primaryAistateName_ != null;
			}
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000C98F3 File Offset: 0x000C7AF3
		[DebuggerNonUserCode]
		public void ClearPrimaryAistateName()
		{
			this.primaryAistateName_ = null;
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x000C9900 File Offset: 0x000C7B00
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x000C9931 File Offset: 0x000C7B31
		[DebuggerNonUserCode]
		public uint TicksInPrimaryAistate
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint ticksInPrimaryAistateDefaultValue;
				if (flag)
				{
					ticksInPrimaryAistateDefaultValue = this.ticksInPrimaryAistate_;
				}
				else
				{
					ticksInPrimaryAistateDefaultValue = AIStateDebugSnapshot.TicksInPrimaryAistateDefaultValue;
				}
				return ticksInPrimaryAistateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.ticksInPrimaryAistate_ = value;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x000C994C File Offset: 0x000C7B4C
		[DebuggerNonUserCode]
		public bool HasTicksInPrimaryAistate
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000C9969 File Offset: 0x000C7B69
		[DebuggerNonUserCode]
		public void ClearTicksInPrimaryAistate()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x000C997C File Offset: 0x000C7B7C
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x000C999D File Offset: 0x000C7B9D
		[DebuggerNonUserCode]
		public string QueuedAistateSwitchName
		{
			get
			{
				return this.queuedAistateSwitchName_ ?? AIStateDebugSnapshot.QueuedAistateSwitchNameDefaultValue;
			}
			set
			{
				this.queuedAistateSwitchName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x000C99B4 File Offset: 0x000C7BB4
		[DebuggerNonUserCode]
		public bool HasQueuedAistateSwitchName
		{
			get
			{
				return this.queuedAistateSwitchName_ != null;
			}
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000C99CF File Offset: 0x000C7BCF
		[DebuggerNonUserCode]
		public void ClearQueuedAistateSwitchName()
		{
			this.queuedAistateSwitchName_ = null;
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x000C99DC File Offset: 0x000C7BDC
		[DebuggerNonUserCode]
		public RepeatedField<AIStateDebugSnapshotEntry> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x000C99F4 File Offset: 0x000C7BF4
		[DebuggerNonUserCode]
		public RepeatedField<string> MergedAistateNames
		{
			get
			{
				return this.mergedAistateNames_;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x000C9A0C File Offset: 0x000C7C0C
		[DebuggerNonUserCode]
		public RepeatedField<DebugTarget> HostileTargets
		{
			get
			{
				return this.hostileTargets_;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x000C9A24 File Offset: 0x000C7C24
		[DebuggerNonUserCode]
		public RepeatedField<DebugTarget> FriendlyTargets
		{
			get
			{
				return this.friendlyTargets_;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x000C9A3C File Offset: 0x000C7C3C
		[DebuggerNonUserCode]
		public RepeatedField<DebugTarget> AipropTargets
		{
			get
			{
				return this.aipropTargets_;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x000C9A54 File Offset: 0x000C7C54
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x000C9A75 File Offset: 0x000C7C75
		[DebuggerNonUserCode]
		public string CurrentAibehaviorName
		{
			get
			{
				return this.currentAibehaviorName_ ?? AIStateDebugSnapshot.CurrentAibehaviorNameDefaultValue;
			}
			set
			{
				this.currentAibehaviorName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x000C9A8C File Offset: 0x000C7C8C
		[DebuggerNonUserCode]
		public bool HasCurrentAibehaviorName
		{
			get
			{
				return this.currentAibehaviorName_ != null;
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000C9AA7 File Offset: 0x000C7CA7
		[DebuggerNonUserCode]
		public void ClearCurrentAibehaviorName()
		{
			this.currentAibehaviorName_ = null;
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x000C9AB4 File Offset: 0x000C7CB4
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x000C9ACC File Offset: 0x000C7CCC
		[DebuggerNonUserCode]
		public AIVariableDebugSnapshot VariableSnapshot
		{
			get
			{
				return this.variableSnapshot_;
			}
			set
			{
				this.variableSnapshot_ = value;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x000C9AD8 File Offset: 0x000C7CD8
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x000C9B0A File Offset: 0x000C7D0A
		[DebuggerNonUserCode]
		public uint QueuedAistateSwitchTicksRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint queuedAistateSwitchTicksRemainingDefaultValue;
				if (flag)
				{
					queuedAistateSwitchTicksRemainingDefaultValue = this.queuedAistateSwitchTicksRemaining_;
				}
				else
				{
					queuedAistateSwitchTicksRemainingDefaultValue = AIStateDebugSnapshot.QueuedAistateSwitchTicksRemainingDefaultValue;
				}
				return queuedAistateSwitchTicksRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.queuedAistateSwitchTicksRemaining_ = value;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x000C9B24 File Offset: 0x000C7D24
		[DebuggerNonUserCode]
		public bool HasQueuedAistateSwitchTicksRemaining
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000C9B42 File Offset: 0x000C7D42
		[DebuggerNonUserCode]
		public void ClearQueuedAistateSwitchTicksRemaining()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x000C9B54 File Offset: 0x000C7D54
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x000C9B86 File Offset: 0x000C7D86
		[DebuggerNonUserCode]
		public uint QueuedAistateSwitchEntryIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint queuedAistateSwitchEntryIndexDefaultValue;
				if (flag)
				{
					queuedAistateSwitchEntryIndexDefaultValue = this.queuedAistateSwitchEntryIndex_;
				}
				else
				{
					queuedAistateSwitchEntryIndexDefaultValue = AIStateDebugSnapshot.QueuedAistateSwitchEntryIndexDefaultValue;
				}
				return queuedAistateSwitchEntryIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.queuedAistateSwitchEntryIndex_ = value;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x000C9BA0 File Offset: 0x000C7DA0
		[DebuggerNonUserCode]
		public bool HasQueuedAistateSwitchEntryIndex
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000C9BBE File Offset: 0x000C7DBE
		[DebuggerNonUserCode]
		public void ClearQueuedAistateSwitchEntryIndex()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x000C9BD0 File Offset: 0x000C7DD0
		[DebuggerNonUserCode]
		public RepeatedField<DebugTarget> CachedTargets
		{
			get
			{
				return this.cachedTargets_;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x000C9BE8 File Offset: 0x000C7DE8
		// (set) Token: 0x06003313 RID: 13075 RVA: 0x000C9C1A File Offset: 0x000C7E1A
		[DebuggerNonUserCode]
		public ulong ForcedCooldownKey
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong forcedCooldownKeyDefaultValue;
				if (flag)
				{
					forcedCooldownKeyDefaultValue = this.forcedCooldownKey_;
				}
				else
				{
					forcedCooldownKeyDefaultValue = AIStateDebugSnapshot.ForcedCooldownKeyDefaultValue;
				}
				return forcedCooldownKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.forcedCooldownKey_ = value;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x000C9C34 File Offset: 0x000C7E34
		[DebuggerNonUserCode]
		public bool HasForcedCooldownKey
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000C9C52 File Offset: 0x000C7E52
		[DebuggerNonUserCode]
		public void ClearForcedCooldownKey()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06003316 RID: 13078 RVA: 0x000C9C64 File Offset: 0x000C7E64
		// (set) Token: 0x06003317 RID: 13079 RVA: 0x000C9C99 File Offset: 0x000C7E99
		[DebuggerNonUserCode]
		public float ForcedCooldown
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				float forcedCooldownDefaultValue;
				if (flag)
				{
					forcedCooldownDefaultValue = this.forcedCooldown_;
				}
				else
				{
					forcedCooldownDefaultValue = AIStateDebugSnapshot.ForcedCooldownDefaultValue;
				}
				return forcedCooldownDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.forcedCooldown_ = value;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x000C9CB8 File Offset: 0x000C7EB8
		[DebuggerNonUserCode]
		public bool HasForcedCooldown
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000C9CD9 File Offset: 0x000C7ED9
		[DebuggerNonUserCode]
		public void ClearForcedCooldown()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x000C9CF0 File Offset: 0x000C7EF0
		// (set) Token: 0x0600331B RID: 13083 RVA: 0x000C9D25 File Offset: 0x000C7F25
		[DebuggerNonUserCode]
		public uint ChosenWeight
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint chosenWeightDefaultValue;
				if (flag)
				{
					chosenWeightDefaultValue = this.chosenWeight_;
				}
				else
				{
					chosenWeightDefaultValue = AIStateDebugSnapshot.ChosenWeightDefaultValue;
				}
				return chosenWeightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.chosenWeight_ = value;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x000C9D44 File Offset: 0x000C7F44
		[DebuggerNonUserCode]
		public bool HasChosenWeight
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000C9D65 File Offset: 0x000C7F65
		[DebuggerNonUserCode]
		public void ClearChosenWeight()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000C9D7C File Offset: 0x000C7F7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugSnapshot);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000C9D9C File Offset: 0x000C7F9C
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugSnapshot other)
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
					bool flag4 = this.Ann != other.Ann;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CommandFrame != other.CommandFrame;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.WorldPlace, other.WorldPlace);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Yaw, other.Yaw);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.CurrentPower, other.CurrentPower);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PrimaryAistateName != other.PrimaryAistateName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TicksInPrimaryAistate != other.TicksInPrimaryAistate;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.QueuedAistateSwitchName != other.QueuedAistateSwitchName;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.entries_.Equals(other.entries_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.mergedAistateNames_.Equals(other.mergedAistateNames_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !this.hostileTargets_.Equals(other.hostileTargets_);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !this.friendlyTargets_.Equals(other.friendlyTargets_);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.aipropTargets_.Equals(other.aipropTargets_);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.CurrentAibehaviorName != other.CurrentAibehaviorName;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.VariableSnapshot, other.VariableSnapshot);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.QueuedAistateSwitchTicksRemaining != other.QueuedAistateSwitchTicksRemaining;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.QueuedAistateSwitchEntryIndex != other.QueuedAistateSwitchEntryIndex;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !this.cachedTargets_.Equals(other.cachedTargets_);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.ForcedCooldownKey != other.ForcedCooldownKey;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ForcedCooldown, other.ForcedCooldown);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.ChosenWeight != other.ChosenWeight;
																									flag2 = !flag24 && object.Equals(this._unknownFields, other._unknownFields);
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
			}
			return flag2;
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x000CA074 File Offset: 0x000C8274
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num ^= this.Ann.GetHashCode();
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num ^= this.CommandFrame.GetHashCode();
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num ^= this.WorldPlace.GetHashCode();
			}
			bool hasYaw = this.HasYaw;
			if (hasYaw)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Yaw);
			}
			bool flag2 = this.currentPower_ != null;
			if (flag2)
			{
				num ^= this.CurrentPower.GetHashCode();
			}
			bool hasPrimaryAistateName = this.HasPrimaryAistateName;
			if (hasPrimaryAistateName)
			{
				num ^= this.PrimaryAistateName.GetHashCode();
			}
			bool hasTicksInPrimaryAistate = this.HasTicksInPrimaryAistate;
			if (hasTicksInPrimaryAistate)
			{
				num ^= this.TicksInPrimaryAistate.GetHashCode();
			}
			bool hasQueuedAistateSwitchName = this.HasQueuedAistateSwitchName;
			if (hasQueuedAistateSwitchName)
			{
				num ^= this.QueuedAistateSwitchName.GetHashCode();
			}
			num ^= this.entries_.GetHashCode();
			num ^= this.mergedAistateNames_.GetHashCode();
			num ^= this.hostileTargets_.GetHashCode();
			num ^= this.friendlyTargets_.GetHashCode();
			num ^= this.aipropTargets_.GetHashCode();
			bool hasCurrentAibehaviorName = this.HasCurrentAibehaviorName;
			if (hasCurrentAibehaviorName)
			{
				num ^= this.CurrentAibehaviorName.GetHashCode();
			}
			bool flag3 = this.variableSnapshot_ != null;
			if (flag3)
			{
				num ^= this.VariableSnapshot.GetHashCode();
			}
			bool hasQueuedAistateSwitchTicksRemaining = this.HasQueuedAistateSwitchTicksRemaining;
			if (hasQueuedAistateSwitchTicksRemaining)
			{
				num ^= this.QueuedAistateSwitchTicksRemaining.GetHashCode();
			}
			bool hasQueuedAistateSwitchEntryIndex = this.HasQueuedAistateSwitchEntryIndex;
			if (hasQueuedAistateSwitchEntryIndex)
			{
				num ^= this.QueuedAistateSwitchEntryIndex.GetHashCode();
			}
			num ^= this.cachedTargets_.GetHashCode();
			bool hasForcedCooldownKey = this.HasForcedCooldownKey;
			if (hasForcedCooldownKey)
			{
				num ^= this.ForcedCooldownKey.GetHashCode();
			}
			bool hasForcedCooldown = this.HasForcedCooldown;
			if (hasForcedCooldown)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ForcedCooldown);
			}
			bool hasChosenWeight = this.HasChosenWeight;
			if (hasChosenWeight)
			{
				num ^= this.ChosenWeight.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x000CA2AC File Offset: 0x000C84AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x000CA2C4 File Offset: 0x000C84C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x000CA2D0 File Offset: 0x000C84D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Ann);
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CommandFrame);
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.WorldPlace);
			}
			bool hasYaw = this.HasYaw;
			if (hasYaw)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Yaw);
			}
			bool flag2 = this.currentPower_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CurrentPower);
			}
			bool hasPrimaryAistateName = this.HasPrimaryAistateName;
			if (hasPrimaryAistateName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PrimaryAistateName);
			}
			bool hasTicksInPrimaryAistate = this.HasTicksInPrimaryAistate;
			if (hasTicksInPrimaryAistate)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TicksInPrimaryAistate);
			}
			bool hasQueuedAistateSwitchName = this.HasQueuedAistateSwitchName;
			if (hasQueuedAistateSwitchName)
			{
				output.WriteRawTag(66);
				output.WriteString(this.QueuedAistateSwitchName);
			}
			this.entries_.WriteTo(ref output, AIStateDebugSnapshot._repeated_entries_codec);
			this.mergedAistateNames_.WriteTo(ref output, AIStateDebugSnapshot._repeated_mergedAistateNames_codec);
			this.hostileTargets_.WriteTo(ref output, AIStateDebugSnapshot._repeated_hostileTargets_codec);
			this.friendlyTargets_.WriteTo(ref output, AIStateDebugSnapshot._repeated_friendlyTargets_codec);
			this.aipropTargets_.WriteTo(ref output, AIStateDebugSnapshot._repeated_aipropTargets_codec);
			bool hasCurrentAibehaviorName = this.HasCurrentAibehaviorName;
			if (hasCurrentAibehaviorName)
			{
				output.WriteRawTag(114);
				output.WriteString(this.CurrentAibehaviorName);
			}
			bool flag3 = this.variableSnapshot_ != null;
			if (flag3)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.VariableSnapshot);
			}
			bool hasQueuedAistateSwitchTicksRemaining = this.HasQueuedAistateSwitchTicksRemaining;
			if (hasQueuedAistateSwitchTicksRemaining)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.QueuedAistateSwitchTicksRemaining);
			}
			bool hasQueuedAistateSwitchEntryIndex = this.HasQueuedAistateSwitchEntryIndex;
			if (hasQueuedAistateSwitchEntryIndex)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.QueuedAistateSwitchEntryIndex);
			}
			this.cachedTargets_.WriteTo(ref output, AIStateDebugSnapshot._repeated_cachedTargets_codec);
			bool hasForcedCooldownKey = this.HasForcedCooldownKey;
			if (hasForcedCooldownKey)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.ForcedCooldownKey);
			}
			bool hasForcedCooldown = this.HasForcedCooldown;
			if (hasForcedCooldown)
			{
				output.WriteRawTag(165, 1);
				output.WriteFloat(this.ForcedCooldown);
			}
			bool hasChosenWeight = this.HasChosenWeight;
			if (hasChosenWeight)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt32(this.ChosenWeight);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x000CA59C File Offset: 0x000C879C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num += 5;
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CommandFrame);
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldPlace);
			}
			bool hasYaw = this.HasYaw;
			if (hasYaw)
			{
				num += 5;
			}
			bool flag2 = this.currentPower_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentPower);
			}
			bool hasPrimaryAistateName = this.HasPrimaryAistateName;
			if (hasPrimaryAistateName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PrimaryAistateName);
			}
			bool hasTicksInPrimaryAistate = this.HasTicksInPrimaryAistate;
			if (hasTicksInPrimaryAistate)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TicksInPrimaryAistate);
			}
			bool hasQueuedAistateSwitchName = this.HasQueuedAistateSwitchName;
			if (hasQueuedAistateSwitchName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.QueuedAistateSwitchName);
			}
			num += this.entries_.CalculateSize(AIStateDebugSnapshot._repeated_entries_codec);
			num += this.mergedAistateNames_.CalculateSize(AIStateDebugSnapshot._repeated_mergedAistateNames_codec);
			num += this.hostileTargets_.CalculateSize(AIStateDebugSnapshot._repeated_hostileTargets_codec);
			num += this.friendlyTargets_.CalculateSize(AIStateDebugSnapshot._repeated_friendlyTargets_codec);
			num += this.aipropTargets_.CalculateSize(AIStateDebugSnapshot._repeated_aipropTargets_codec);
			bool hasCurrentAibehaviorName = this.HasCurrentAibehaviorName;
			if (hasCurrentAibehaviorName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CurrentAibehaviorName);
			}
			bool flag3 = this.variableSnapshot_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VariableSnapshot);
			}
			bool hasQueuedAistateSwitchTicksRemaining = this.HasQueuedAistateSwitchTicksRemaining;
			if (hasQueuedAistateSwitchTicksRemaining)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.QueuedAistateSwitchTicksRemaining);
			}
			bool hasQueuedAistateSwitchEntryIndex = this.HasQueuedAistateSwitchEntryIndex;
			if (hasQueuedAistateSwitchEntryIndex)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.QueuedAistateSwitchEntryIndex);
			}
			num += this.cachedTargets_.CalculateSize(AIStateDebugSnapshot._repeated_cachedTargets_codec);
			bool hasForcedCooldownKey = this.HasForcedCooldownKey;
			if (hasForcedCooldownKey)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.ForcedCooldownKey);
			}
			bool hasForcedCooldown = this.HasForcedCooldown;
			if (hasForcedCooldown)
			{
				num += 6;
			}
			bool hasChosenWeight = this.HasChosenWeight;
			if (hasChosenWeight)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ChosenWeight);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x000CA7E8 File Offset: 0x000C89E8
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAnn = other.HasAnn;
				if (hasAnn)
				{
					this.Ann = other.Ann;
				}
				bool hasCommandFrame = other.HasCommandFrame;
				if (hasCommandFrame)
				{
					this.CommandFrame = other.CommandFrame;
				}
				bool flag2 = other.worldPlace_ != null;
				if (flag2)
				{
					bool flag3 = this.worldPlace_ == null;
					if (flag3)
					{
						this.WorldPlace = new DebugWorldPlace();
					}
					this.WorldPlace.MergeFrom(other.WorldPlace);
				}
				bool hasYaw = other.HasYaw;
				if (hasYaw)
				{
					this.Yaw = other.Yaw;
				}
				bool flag4 = other.currentPower_ != null;
				if (flag4)
				{
					bool flag5 = this.currentPower_ == null;
					if (flag5)
					{
						this.CurrentPower = new AIStateDebugSnapshotCurrentPower();
					}
					this.CurrentPower.MergeFrom(other.CurrentPower);
				}
				bool hasPrimaryAistateName = other.HasPrimaryAistateName;
				if (hasPrimaryAistateName)
				{
					this.PrimaryAistateName = other.PrimaryAistateName;
				}
				bool hasTicksInPrimaryAistate = other.HasTicksInPrimaryAistate;
				if (hasTicksInPrimaryAistate)
				{
					this.TicksInPrimaryAistate = other.TicksInPrimaryAistate;
				}
				bool hasQueuedAistateSwitchName = other.HasQueuedAistateSwitchName;
				if (hasQueuedAistateSwitchName)
				{
					this.QueuedAistateSwitchName = other.QueuedAistateSwitchName;
				}
				this.entries_.Add(other.entries_);
				this.mergedAistateNames_.Add(other.mergedAistateNames_);
				this.hostileTargets_.Add(other.hostileTargets_);
				this.friendlyTargets_.Add(other.friendlyTargets_);
				this.aipropTargets_.Add(other.aipropTargets_);
				bool hasCurrentAibehaviorName = other.HasCurrentAibehaviorName;
				if (hasCurrentAibehaviorName)
				{
					this.CurrentAibehaviorName = other.CurrentAibehaviorName;
				}
				bool flag6 = other.variableSnapshot_ != null;
				if (flag6)
				{
					bool flag7 = this.variableSnapshot_ == null;
					if (flag7)
					{
						this.VariableSnapshot = new AIVariableDebugSnapshot();
					}
					this.VariableSnapshot.MergeFrom(other.VariableSnapshot);
				}
				bool hasQueuedAistateSwitchTicksRemaining = other.HasQueuedAistateSwitchTicksRemaining;
				if (hasQueuedAistateSwitchTicksRemaining)
				{
					this.QueuedAistateSwitchTicksRemaining = other.QueuedAistateSwitchTicksRemaining;
				}
				bool hasQueuedAistateSwitchEntryIndex = other.HasQueuedAistateSwitchEntryIndex;
				if (hasQueuedAistateSwitchEntryIndex)
				{
					this.QueuedAistateSwitchEntryIndex = other.QueuedAistateSwitchEntryIndex;
				}
				this.cachedTargets_.Add(other.cachedTargets_);
				bool hasForcedCooldownKey = other.HasForcedCooldownKey;
				if (hasForcedCooldownKey)
				{
					this.ForcedCooldownKey = other.ForcedCooldownKey;
				}
				bool hasForcedCooldown = other.HasForcedCooldown;
				if (hasForcedCooldown)
				{
					this.ForcedCooldown = other.ForcedCooldown;
				}
				bool hasChosenWeight = other.HasChosenWeight;
				if (hasChosenWeight)
				{
					this.ChosenWeight = other.ChosenWeight;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x000CAA85 File Offset: 0x000C8C85
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x000CAA90 File Offset: 0x000C8C90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 82U)
				{
					if (num3 <= 42U)
					{
						if (num3 <= 16U)
						{
							if (num3 != 13U)
							{
								if (num3 != 16U)
								{
									goto IL_0121;
								}
								this.CommandFrame = input.ReadUInt32();
							}
							else
							{
								this.Ann = input.ReadFixed32();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 37U)
							{
								if (num3 != 42U)
								{
									goto IL_0121;
								}
								bool flag = this.currentPower_ == null;
								if (flag)
								{
									this.CurrentPower = new AIStateDebugSnapshotCurrentPower();
								}
								input.ReadMessage(this.CurrentPower);
							}
							else
							{
								this.Yaw = input.ReadFloat();
							}
						}
						else
						{
							bool flag2 = this.worldPlace_ == null;
							if (flag2)
							{
								this.WorldPlace = new DebugWorldPlace();
							}
							input.ReadMessage(this.WorldPlace);
						}
					}
					else if (num3 <= 56U)
					{
						if (num3 != 50U)
						{
							if (num3 != 56U)
							{
								goto IL_0121;
							}
							this.TicksInPrimaryAistate = input.ReadUInt32();
						}
						else
						{
							this.PrimaryAistateName = input.ReadString();
						}
					}
					else if (num3 != 66U)
					{
						if (num3 != 74U)
						{
							if (num3 != 82U)
							{
								goto IL_0121;
							}
							this.mergedAistateNames_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_mergedAistateNames_codec);
						}
						else
						{
							this.entries_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_entries_codec);
						}
					}
					else
					{
						this.QueuedAistateSwitchName = input.ReadString();
					}
				}
				else if (num3 <= 122U)
				{
					if (num3 <= 98U)
					{
						if (num3 != 90U)
						{
							if (num3 != 98U)
							{
								goto IL_0121;
							}
							this.friendlyTargets_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_friendlyTargets_codec);
						}
						else
						{
							this.hostileTargets_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_hostileTargets_codec);
						}
					}
					else if (num3 != 106U)
					{
						if (num3 != 114U)
						{
							if (num3 != 122U)
							{
								goto IL_0121;
							}
							bool flag3 = this.variableSnapshot_ == null;
							if (flag3)
							{
								this.VariableSnapshot = new AIVariableDebugSnapshot();
							}
							input.ReadMessage(this.VariableSnapshot);
						}
						else
						{
							this.CurrentAibehaviorName = input.ReadString();
						}
					}
					else
					{
						this.aipropTargets_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_aipropTargets_codec);
					}
				}
				else if (num3 <= 146U)
				{
					if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							if (num3 != 146U)
							{
								goto IL_0121;
							}
							this.cachedTargets_.AddEntriesFrom(ref input, AIStateDebugSnapshot._repeated_cachedTargets_codec);
						}
						else
						{
							this.QueuedAistateSwitchEntryIndex = input.ReadUInt32();
						}
					}
					else
					{
						this.QueuedAistateSwitchTicksRemaining = input.ReadUInt32();
					}
				}
				else if (num3 != 152U)
				{
					if (num3 != 165U)
					{
						if (num3 != 168U)
						{
							goto IL_0121;
						}
						this.ChosenWeight = input.ReadUInt32();
					}
					else
					{
						this.ForcedCooldown = input.ReadFloat();
					}
				}
				else
				{
					this.ForcedCooldownKey = input.ReadUInt64();
				}
				continue;
				IL_0121:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001769 RID: 5993
		private static readonly MessageParser<AIStateDebugSnapshot> _parser = new MessageParser<AIStateDebugSnapshot>(() => new AIStateDebugSnapshot());

		// Token: 0x0400176A RID: 5994
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400176B RID: 5995
		private int _hasBits0;

		// Token: 0x0400176C RID: 5996
		public const int AnnFieldNumber = 1;

		// Token: 0x0400176D RID: 5997
		private static readonly uint AnnDefaultValue = 0U;

		// Token: 0x0400176E RID: 5998
		private uint ann_;

		// Token: 0x0400176F RID: 5999
		public const int CommandFrameFieldNumber = 2;

		// Token: 0x04001770 RID: 6000
		private static readonly uint CommandFrameDefaultValue = 0U;

		// Token: 0x04001771 RID: 6001
		private uint commandFrame_;

		// Token: 0x04001772 RID: 6002
		public const int WorldPlaceFieldNumber = 3;

		// Token: 0x04001773 RID: 6003
		private DebugWorldPlace worldPlace_;

		// Token: 0x04001774 RID: 6004
		public const int YawFieldNumber = 4;

		// Token: 0x04001775 RID: 6005
		private static readonly float YawDefaultValue = 0f;

		// Token: 0x04001776 RID: 6006
		private float yaw_;

		// Token: 0x04001777 RID: 6007
		public const int CurrentPowerFieldNumber = 5;

		// Token: 0x04001778 RID: 6008
		private AIStateDebugSnapshotCurrentPower currentPower_;

		// Token: 0x04001779 RID: 6009
		public const int PrimaryAistateNameFieldNumber = 6;

		// Token: 0x0400177A RID: 6010
		private static readonly string PrimaryAistateNameDefaultValue = "";

		// Token: 0x0400177B RID: 6011
		private string primaryAistateName_;

		// Token: 0x0400177C RID: 6012
		public const int TicksInPrimaryAistateFieldNumber = 7;

		// Token: 0x0400177D RID: 6013
		private static readonly uint TicksInPrimaryAistateDefaultValue = 0U;

		// Token: 0x0400177E RID: 6014
		private uint ticksInPrimaryAistate_;

		// Token: 0x0400177F RID: 6015
		public const int QueuedAistateSwitchNameFieldNumber = 8;

		// Token: 0x04001780 RID: 6016
		private static readonly string QueuedAistateSwitchNameDefaultValue = "";

		// Token: 0x04001781 RID: 6017
		private string queuedAistateSwitchName_;

		// Token: 0x04001782 RID: 6018
		public const int EntriesFieldNumber = 9;

		// Token: 0x04001783 RID: 6019
		private static readonly FieldCodec<AIStateDebugSnapshotEntry> _repeated_entries_codec = FieldCodec.ForMessage<AIStateDebugSnapshotEntry>(74U, AIStateDebugSnapshotEntry.Parser);

		// Token: 0x04001784 RID: 6020
		private readonly RepeatedField<AIStateDebugSnapshotEntry> entries_ = new RepeatedField<AIStateDebugSnapshotEntry>();

		// Token: 0x04001785 RID: 6021
		public const int MergedAistateNamesFieldNumber = 10;

		// Token: 0x04001786 RID: 6022
		private static readonly FieldCodec<string> _repeated_mergedAistateNames_codec = FieldCodec.ForString(82U);

		// Token: 0x04001787 RID: 6023
		private readonly RepeatedField<string> mergedAistateNames_ = new RepeatedField<string>();

		// Token: 0x04001788 RID: 6024
		public const int HostileTargetsFieldNumber = 11;

		// Token: 0x04001789 RID: 6025
		private static readonly FieldCodec<DebugTarget> _repeated_hostileTargets_codec = FieldCodec.ForMessage<DebugTarget>(90U, DebugTarget.Parser);

		// Token: 0x0400178A RID: 6026
		private readonly RepeatedField<DebugTarget> hostileTargets_ = new RepeatedField<DebugTarget>();

		// Token: 0x0400178B RID: 6027
		public const int FriendlyTargetsFieldNumber = 12;

		// Token: 0x0400178C RID: 6028
		private static readonly FieldCodec<DebugTarget> _repeated_friendlyTargets_codec = FieldCodec.ForMessage<DebugTarget>(98U, DebugTarget.Parser);

		// Token: 0x0400178D RID: 6029
		private readonly RepeatedField<DebugTarget> friendlyTargets_ = new RepeatedField<DebugTarget>();

		// Token: 0x0400178E RID: 6030
		public const int AipropTargetsFieldNumber = 13;

		// Token: 0x0400178F RID: 6031
		private static readonly FieldCodec<DebugTarget> _repeated_aipropTargets_codec = FieldCodec.ForMessage<DebugTarget>(106U, DebugTarget.Parser);

		// Token: 0x04001790 RID: 6032
		private readonly RepeatedField<DebugTarget> aipropTargets_ = new RepeatedField<DebugTarget>();

		// Token: 0x04001791 RID: 6033
		public const int CurrentAibehaviorNameFieldNumber = 14;

		// Token: 0x04001792 RID: 6034
		private static readonly string CurrentAibehaviorNameDefaultValue = "";

		// Token: 0x04001793 RID: 6035
		private string currentAibehaviorName_;

		// Token: 0x04001794 RID: 6036
		public const int VariableSnapshotFieldNumber = 15;

		// Token: 0x04001795 RID: 6037
		private AIVariableDebugSnapshot variableSnapshot_;

		// Token: 0x04001796 RID: 6038
		public const int QueuedAistateSwitchTicksRemainingFieldNumber = 16;

		// Token: 0x04001797 RID: 6039
		private static readonly uint QueuedAistateSwitchTicksRemainingDefaultValue = 0U;

		// Token: 0x04001798 RID: 6040
		private uint queuedAistateSwitchTicksRemaining_;

		// Token: 0x04001799 RID: 6041
		public const int QueuedAistateSwitchEntryIndexFieldNumber = 17;

		// Token: 0x0400179A RID: 6042
		private static readonly uint QueuedAistateSwitchEntryIndexDefaultValue = 0U;

		// Token: 0x0400179B RID: 6043
		private uint queuedAistateSwitchEntryIndex_;

		// Token: 0x0400179C RID: 6044
		public const int CachedTargetsFieldNumber = 18;

		// Token: 0x0400179D RID: 6045
		private static readonly FieldCodec<DebugTarget> _repeated_cachedTargets_codec = FieldCodec.ForMessage<DebugTarget>(146U, DebugTarget.Parser);

		// Token: 0x0400179E RID: 6046
		private readonly RepeatedField<DebugTarget> cachedTargets_ = new RepeatedField<DebugTarget>();

		// Token: 0x0400179F RID: 6047
		public const int ForcedCooldownKeyFieldNumber = 19;

		// Token: 0x040017A0 RID: 6048
		private static readonly ulong ForcedCooldownKeyDefaultValue = 0UL;

		// Token: 0x040017A1 RID: 6049
		private ulong forcedCooldownKey_;

		// Token: 0x040017A2 RID: 6050
		public const int ForcedCooldownFieldNumber = 20;

		// Token: 0x040017A3 RID: 6051
		private static readonly float ForcedCooldownDefaultValue = 0f;

		// Token: 0x040017A4 RID: 6052
		private float forcedCooldown_;

		// Token: 0x040017A5 RID: 6053
		public const int ChosenWeightFieldNumber = 21;

		// Token: 0x040017A6 RID: 6054
		private static readonly uint ChosenWeightDefaultValue = 0U;

		// Token: 0x040017A7 RID: 6055
		private uint chosenWeight_;
	}
}
