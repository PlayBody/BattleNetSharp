using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FE RID: 766
	public sealed class Bug : IMessage<Bug>, IMessage, IEquatable<Bug>, IDeepCloneable<Bug>, IBufferMessage
	{
		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x00134B28 File Offset: 0x00132D28
		[DebuggerNonUserCode]
		public static MessageParser<Bug> Parser
		{
			get
			{
				return Bug._parser;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x00134B40 File Offset: 0x00132D40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BugReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x00134B64 File Offset: 0x00132D64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Bug.Descriptor;
			}
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00134B7B File Offset: 0x00132D7B
		[DebuggerNonUserCode]
		public Bug()
		{
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00134B90 File Offset: 0x00132D90
		[DebuggerNonUserCode]
		public Bug(Bug other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.worldSno_ = other.worldSno_;
			this.worldName_ = other.worldName_;
			this.subzoneSno_ = other.subzoneSno_;
			this.subzoneName_ = other.subzoneName_;
			this.placeX_ = other.placeX_;
			this.placeY_ = other.placeY_;
			this.placeZ_ = other.placeZ_;
			this.sceneSno_ = other.sceneSno_;
			this.sceneName_ = other.sceneName_;
			this.scenePositionX_ = other.scenePositionX_;
			this.scenePositionY_ = other.scenePositionY_;
			this.scenePositionZ_ = other.scenePositionZ_;
			this.instanceQuestSno_ = other.instanceQuestSno_;
			this.instanceQuestName_ = other.instanceQuestName_;
			this.instanceQuestPhase_ = other.instanceQuestPhase_;
			this.dungeonStates_ = other.dungeonStates_;
			this.worldSeed_ = other.worldSeed_;
			this.description_ = other.description_;
			this.metadata_ = other.metadata_;
			this.locale_ = other.locale_;
			this.localeInfo_ = ((other.localeInfo_ != null) ? other.localeInfo_.Clone() : null);
			this.branch_ = other.branch_;
			this.buildNumber_ = other.buildNumber_;
			this.buildVersionCodeData_ = other.buildVersionCodeData_;
			this.thumbnailJpgData_ = other.thumbnailJpgData_;
			this.summary_ = other.summary_;
			this.timestamp_ = other.timestamp_;
			this.trackedQuestSno_ = other.trackedQuestSno_;
			this.trackedQuestName_ = other.trackedQuestName_;
			this.trackedQuestPhase_ = other.trackedQuestPhase_;
			this.orientationX_ = other.orientationX_;
			this.orientationY_ = other.orientationY_;
			this.orientationZ_ = other.orientationZ_;
			this.orientationW_ = other.orientationW_;
			this.latencyMs_ = other.latencyMs_;
			this.playerHeroTxt_ = other.playerHeroTxt_;
			this.localPrefsTxt_ = other.localPrefsTxt_;
			this.lastScrollUsed_ = other.lastScrollUsed_;
			this.lastCutscenePlayedSno_ = other.lastCutscenePlayedSno_;
			this.lastCutscenePlayedName_ = other.lastCutscenePlayedName_;
			this.lastCompletedQuestPhaseInfo_ = other.lastCompletedQuestPhaseInfo_;
			this.instanceType_ = other.instanceType_;
			this.nightmareDungeonInfo_ = other.nightmareDungeonInfo_;
			this.lastCompletedEventSno_ = other.lastCompletedEventSno_;
			this.lastCompletedEventName_ = other.lastCompletedEventName_;
			this.lastCompletedEventNumParticipants_ = other.lastCompletedEventNumParticipants_;
			this.numLocalPartyPlayers_ = other.numLocalPartyPlayers_;
			this.numOnlinePartyPlayers_ = other.numOnlinePartyPlayers_;
			this.clientSurroundingsInfoTxt_ = other.clientSurroundingsInfoTxt_;
			this.lastUsedWaypointInfo_ = other.lastUsedWaypointInfo_;
			this.concerningContentGroups_ = other.concerningContentGroups_;
			this.category_ = other.category_;
			this.tests_ = other.tests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00134E54 File Offset: 0x00133054
		[DebuggerNonUserCode]
		public Bug Clone()
		{
			return new Bug(this);
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600505C RID: 20572 RVA: 0x00134E6C File Offset: 0x0013306C
		// (set) Token: 0x0600505D RID: 20573 RVA: 0x00134E9D File Offset: 0x0013309D
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = Bug.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldSno_ = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x00134EB8 File Offset: 0x001330B8
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00134ED5 File Offset: 0x001330D5
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x00134EE8 File Offset: 0x001330E8
		// (set) Token: 0x06005061 RID: 20577 RVA: 0x00134F09 File Offset: 0x00133109
		[DebuggerNonUserCode]
		public string WorldName
		{
			get
			{
				return this.worldName_ ?? Bug.WorldNameDefaultValue;
			}
			set
			{
				this.worldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x00134F20 File Offset: 0x00133120
		[DebuggerNonUserCode]
		public bool HasWorldName
		{
			get
			{
				return this.worldName_ != null;
			}
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00134F3B File Offset: 0x0013313B
		[DebuggerNonUserCode]
		public void ClearWorldName()
		{
			this.worldName_ = null;
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x00134F48 File Offset: 0x00133148
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x00134F79 File Offset: 0x00133179
		[DebuggerNonUserCode]
		public int SubzoneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int subzoneSnoDefaultValue;
				if (flag)
				{
					subzoneSnoDefaultValue = this.subzoneSno_;
				}
				else
				{
					subzoneSnoDefaultValue = Bug.SubzoneSnoDefaultValue;
				}
				return subzoneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subzoneSno_ = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x00134F94 File Offset: 0x00133194
		[DebuggerNonUserCode]
		public bool HasSubzoneSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00134FB1 File Offset: 0x001331B1
		[DebuggerNonUserCode]
		public void ClearSubzoneSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x00134FC4 File Offset: 0x001331C4
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x00134FE5 File Offset: 0x001331E5
		[DebuggerNonUserCode]
		public string SubzoneName
		{
			get
			{
				return this.subzoneName_ ?? Bug.SubzoneNameDefaultValue;
			}
			set
			{
				this.subzoneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x00134FFC File Offset: 0x001331FC
		[DebuggerNonUserCode]
		public bool HasSubzoneName
		{
			get
			{
				return this.subzoneName_ != null;
			}
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00135017 File Offset: 0x00133217
		[DebuggerNonUserCode]
		public void ClearSubzoneName()
		{
			this.subzoneName_ = null;
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x00135024 File Offset: 0x00133224
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x00135055 File Offset: 0x00133255
		[DebuggerNonUserCode]
		public float PlaceX
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float placeXDefaultValue;
				if (flag)
				{
					placeXDefaultValue = this.placeX_;
				}
				else
				{
					placeXDefaultValue = Bug.PlaceXDefaultValue;
				}
				return placeXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.placeX_ = value;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x00135070 File Offset: 0x00133270
		[DebuggerNonUserCode]
		public bool HasPlaceX
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x0013508D File Offset: 0x0013328D
		[DebuggerNonUserCode]
		public void ClearPlaceX()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x001350A0 File Offset: 0x001332A0
		// (set) Token: 0x06005071 RID: 20593 RVA: 0x001350D1 File Offset: 0x001332D1
		[DebuggerNonUserCode]
		public float PlaceY
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float placeYDefaultValue;
				if (flag)
				{
					placeYDefaultValue = this.placeY_;
				}
				else
				{
					placeYDefaultValue = Bug.PlaceYDefaultValue;
				}
				return placeYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.placeY_ = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x001350EC File Offset: 0x001332EC
		[DebuggerNonUserCode]
		public bool HasPlaceY
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00135109 File Offset: 0x00133309
		[DebuggerNonUserCode]
		public void ClearPlaceY()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x0013511C File Offset: 0x0013331C
		// (set) Token: 0x06005075 RID: 20597 RVA: 0x0013514E File Offset: 0x0013334E
		[DebuggerNonUserCode]
		public float PlaceZ
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float placeZDefaultValue;
				if (flag)
				{
					placeZDefaultValue = this.placeZ_;
				}
				else
				{
					placeZDefaultValue = Bug.PlaceZDefaultValue;
				}
				return placeZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.placeZ_ = value;
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x00135168 File Offset: 0x00133368
		[DebuggerNonUserCode]
		public bool HasPlaceZ
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00135186 File Offset: 0x00133386
		[DebuggerNonUserCode]
		public void ClearPlaceZ()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x00135198 File Offset: 0x00133398
		// (set) Token: 0x06005079 RID: 20601 RVA: 0x001351CA File Offset: 0x001333CA
		[DebuggerNonUserCode]
		public int SceneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int sceneSnoDefaultValue;
				if (flag)
				{
					sceneSnoDefaultValue = this.sceneSno_;
				}
				else
				{
					sceneSnoDefaultValue = Bug.SceneSnoDefaultValue;
				}
				return sceneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.sceneSno_ = value;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x001351E4 File Offset: 0x001333E4
		[DebuggerNonUserCode]
		public bool HasSceneSno
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00135202 File Offset: 0x00133402
		[DebuggerNonUserCode]
		public void ClearSceneSno()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x00135214 File Offset: 0x00133414
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x00135235 File Offset: 0x00133435
		[DebuggerNonUserCode]
		public string SceneName
		{
			get
			{
				return this.sceneName_ ?? Bug.SceneNameDefaultValue;
			}
			set
			{
				this.sceneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x0013524C File Offset: 0x0013344C
		[DebuggerNonUserCode]
		public bool HasSceneName
		{
			get
			{
				return this.sceneName_ != null;
			}
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00135267 File Offset: 0x00133467
		[DebuggerNonUserCode]
		public void ClearSceneName()
		{
			this.sceneName_ = null;
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x00135274 File Offset: 0x00133474
		// (set) Token: 0x06005081 RID: 20609 RVA: 0x001352A6 File Offset: 0x001334A6
		[DebuggerNonUserCode]
		public float ScenePositionX
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				float scenePositionXDefaultValue;
				if (flag)
				{
					scenePositionXDefaultValue = this.scenePositionX_;
				}
				else
				{
					scenePositionXDefaultValue = Bug.ScenePositionXDefaultValue;
				}
				return scenePositionXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.scenePositionX_ = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x001352C0 File Offset: 0x001334C0
		[DebuggerNonUserCode]
		public bool HasScenePositionX
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x001352DE File Offset: 0x001334DE
		[DebuggerNonUserCode]
		public void ClearScenePositionX()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x001352F0 File Offset: 0x001334F0
		// (set) Token: 0x06005085 RID: 20613 RVA: 0x00135325 File Offset: 0x00133525
		[DebuggerNonUserCode]
		public float ScenePositionY
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				float scenePositionYDefaultValue;
				if (flag)
				{
					scenePositionYDefaultValue = this.scenePositionY_;
				}
				else
				{
					scenePositionYDefaultValue = Bug.ScenePositionYDefaultValue;
				}
				return scenePositionYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.scenePositionY_ = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x00135344 File Offset: 0x00133544
		[DebuggerNonUserCode]
		public bool HasScenePositionY
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00135365 File Offset: 0x00133565
		[DebuggerNonUserCode]
		public void ClearScenePositionY()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06005088 RID: 20616 RVA: 0x0013537C File Offset: 0x0013357C
		// (set) Token: 0x06005089 RID: 20617 RVA: 0x001353B1 File Offset: 0x001335B1
		[DebuggerNonUserCode]
		public float ScenePositionZ
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				float scenePositionZDefaultValue;
				if (flag)
				{
					scenePositionZDefaultValue = this.scenePositionZ_;
				}
				else
				{
					scenePositionZDefaultValue = Bug.ScenePositionZDefaultValue;
				}
				return scenePositionZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.scenePositionZ_ = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x0600508A RID: 20618 RVA: 0x001353D0 File Offset: 0x001335D0
		[DebuggerNonUserCode]
		public bool HasScenePositionZ
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x001353F1 File Offset: 0x001335F1
		[DebuggerNonUserCode]
		public void ClearScenePositionZ()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x00135408 File Offset: 0x00133608
		// (set) Token: 0x0600508D RID: 20621 RVA: 0x0013543D File Offset: 0x0013363D
		[DebuggerNonUserCode]
		public int InstanceQuestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int instanceQuestSnoDefaultValue;
				if (flag)
				{
					instanceQuestSnoDefaultValue = this.instanceQuestSno_;
				}
				else
				{
					instanceQuestSnoDefaultValue = Bug.InstanceQuestSnoDefaultValue;
				}
				return instanceQuestSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.instanceQuestSno_ = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600508E RID: 20622 RVA: 0x0013545C File Offset: 0x0013365C
		[DebuggerNonUserCode]
		public bool HasInstanceQuestSno
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x0013547D File Offset: 0x0013367D
		[DebuggerNonUserCode]
		public void ClearInstanceQuestSno()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x00135494 File Offset: 0x00133694
		// (set) Token: 0x06005091 RID: 20625 RVA: 0x001354B5 File Offset: 0x001336B5
		[DebuggerNonUserCode]
		public string InstanceQuestName
		{
			get
			{
				return this.instanceQuestName_ ?? Bug.InstanceQuestNameDefaultValue;
			}
			set
			{
				this.instanceQuestName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x001354CC File Offset: 0x001336CC
		[DebuggerNonUserCode]
		public bool HasInstanceQuestName
		{
			get
			{
				return this.instanceQuestName_ != null;
			}
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x001354E7 File Offset: 0x001336E7
		[DebuggerNonUserCode]
		public void ClearInstanceQuestName()
		{
			this.instanceQuestName_ = null;
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x001354F4 File Offset: 0x001336F4
		// (set) Token: 0x06005095 RID: 20629 RVA: 0x00135529 File Offset: 0x00133729
		[DebuggerNonUserCode]
		public int InstanceQuestPhase
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				int instanceQuestPhaseDefaultValue;
				if (flag)
				{
					instanceQuestPhaseDefaultValue = this.instanceQuestPhase_;
				}
				else
				{
					instanceQuestPhaseDefaultValue = Bug.InstanceQuestPhaseDefaultValue;
				}
				return instanceQuestPhaseDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.instanceQuestPhase_ = value;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06005096 RID: 20630 RVA: 0x00135548 File Offset: 0x00133748
		[DebuggerNonUserCode]
		public bool HasInstanceQuestPhase
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00135569 File Offset: 0x00133769
		[DebuggerNonUserCode]
		public void ClearInstanceQuestPhase()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x00135580 File Offset: 0x00133780
		// (set) Token: 0x06005099 RID: 20633 RVA: 0x001355A1 File Offset: 0x001337A1
		[DebuggerNonUserCode]
		public string DungeonStates
		{
			get
			{
				return this.dungeonStates_ ?? Bug.DungeonStatesDefaultValue;
			}
			set
			{
				this.dungeonStates_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x001355B8 File Offset: 0x001337B8
		[DebuggerNonUserCode]
		public bool HasDungeonStates
		{
			get
			{
				return this.dungeonStates_ != null;
			}
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x001355D3 File Offset: 0x001337D3
		[DebuggerNonUserCode]
		public void ClearDungeonStates()
		{
			this.dungeonStates_ = null;
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x001355E0 File Offset: 0x001337E0
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x00135615 File Offset: 0x00133815
		[DebuggerNonUserCode]
		public int WorldSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int worldSeedDefaultValue;
				if (flag)
				{
					worldSeedDefaultValue = this.worldSeed_;
				}
				else
				{
					worldSeedDefaultValue = Bug.WorldSeedDefaultValue;
				}
				return worldSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.worldSeed_ = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x00135634 File Offset: 0x00133834
		[DebuggerNonUserCode]
		public bool HasWorldSeed
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x00135655 File Offset: 0x00133855
		[DebuggerNonUserCode]
		public void ClearWorldSeed()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x0013566C File Offset: 0x0013386C
		// (set) Token: 0x060050A1 RID: 20641 RVA: 0x0013568D File Offset: 0x0013388D
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? Bug.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x001356A4 File Offset: 0x001338A4
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x001356BF File Offset: 0x001338BF
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x001356CC File Offset: 0x001338CC
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x001356ED File Offset: 0x001338ED
		[DebuggerNonUserCode]
		public string Metadata
		{
			get
			{
				return this.metadata_ ?? Bug.MetadataDefaultValue;
			}
			set
			{
				this.metadata_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x00135704 File Offset: 0x00133904
		[DebuggerNonUserCode]
		public bool HasMetadata
		{
			get
			{
				return this.metadata_ != null;
			}
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x0013571F File Offset: 0x0013391F
		[DebuggerNonUserCode]
		public void ClearMetadata()
		{
			this.metadata_ = null;
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x0013572C File Offset: 0x0013392C
		// (set) Token: 0x060050A9 RID: 20649 RVA: 0x00135761 File Offset: 0x00133961
		[Obsolete]
		[DebuggerNonUserCode]
		public int Locale
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int localeDefaultValue;
				if (flag)
				{
					localeDefaultValue = this.locale_;
				}
				else
				{
					localeDefaultValue = Bug.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.locale_ = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060050AA RID: 20650 RVA: 0x00135780 File Offset: 0x00133980
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x001357A1 File Offset: 0x001339A1
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x001357B8 File Offset: 0x001339B8
		// (set) Token: 0x060050AD RID: 20653 RVA: 0x001357D0 File Offset: 0x001339D0
		[DebuggerNonUserCode]
		public LocaleInfo LocaleInfo
		{
			get
			{
				return this.localeInfo_;
			}
			set
			{
				this.localeInfo_ = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x001357DC File Offset: 0x001339DC
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x001357FD File Offset: 0x001339FD
		[DebuggerNonUserCode]
		public string Branch
		{
			get
			{
				return this.branch_ ?? Bug.BranchDefaultValue;
			}
			set
			{
				this.branch_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x00135814 File Offset: 0x00133A14
		[DebuggerNonUserCode]
		public bool HasBranch
		{
			get
			{
				return this.branch_ != null;
			}
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x0013582F File Offset: 0x00133A2F
		[DebuggerNonUserCode]
		public void ClearBranch()
		{
			this.branch_ = null;
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x0013583C File Offset: 0x00133A3C
		// (set) Token: 0x060050B3 RID: 20659 RVA: 0x00135871 File Offset: 0x00133A71
		[DebuggerNonUserCode]
		public int BuildNumber
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				int buildNumberDefaultValue;
				if (flag)
				{
					buildNumberDefaultValue = this.buildNumber_;
				}
				else
				{
					buildNumberDefaultValue = Bug.BuildNumberDefaultValue;
				}
				return buildNumberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.buildNumber_ = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x00135890 File Offset: 0x00133A90
		[DebuggerNonUserCode]
		public bool HasBuildNumber
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x001358B1 File Offset: 0x00133AB1
		[DebuggerNonUserCode]
		public void ClearBuildNumber()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x001358C8 File Offset: 0x00133AC8
		// (set) Token: 0x060050B7 RID: 20663 RVA: 0x001358E9 File Offset: 0x00133AE9
		[DebuggerNonUserCode]
		public string BuildVersionCodeData
		{
			get
			{
				return this.buildVersionCodeData_ ?? Bug.BuildVersionCodeDataDefaultValue;
			}
			set
			{
				this.buildVersionCodeData_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x00135900 File Offset: 0x00133B00
		[DebuggerNonUserCode]
		public bool HasBuildVersionCodeData
		{
			get
			{
				return this.buildVersionCodeData_ != null;
			}
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0013591B File Offset: 0x00133B1B
		[DebuggerNonUserCode]
		public void ClearBuildVersionCodeData()
		{
			this.buildVersionCodeData_ = null;
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060050BA RID: 20666 RVA: 0x00135928 File Offset: 0x00133B28
		// (set) Token: 0x060050BB RID: 20667 RVA: 0x00135949 File Offset: 0x00133B49
		[DebuggerNonUserCode]
		public ByteString ThumbnailJpgData
		{
			get
			{
				return this.thumbnailJpgData_ ?? Bug.ThumbnailJpgDataDefaultValue;
			}
			set
			{
				this.thumbnailJpgData_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x00135960 File Offset: 0x00133B60
		[DebuggerNonUserCode]
		public bool HasThumbnailJpgData
		{
			get
			{
				return this.thumbnailJpgData_ != null;
			}
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x0013597E File Offset: 0x00133B7E
		[DebuggerNonUserCode]
		public void ClearThumbnailJpgData()
		{
			this.thumbnailJpgData_ = null;
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060050BE RID: 20670 RVA: 0x00135988 File Offset: 0x00133B88
		// (set) Token: 0x060050BF RID: 20671 RVA: 0x001359A9 File Offset: 0x00133BA9
		[DebuggerNonUserCode]
		public string Summary
		{
			get
			{
				return this.summary_ ?? Bug.SummaryDefaultValue;
			}
			set
			{
				this.summary_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x001359C0 File Offset: 0x00133BC0
		[DebuggerNonUserCode]
		public bool HasSummary
		{
			get
			{
				return this.summary_ != null;
			}
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x001359DB File Offset: 0x00133BDB
		[DebuggerNonUserCode]
		public void ClearSummary()
		{
			this.summary_ = null;
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x001359E8 File Offset: 0x00133BE8
		// (set) Token: 0x060050C3 RID: 20675 RVA: 0x00135A1D File Offset: 0x00133C1D
		[DebuggerNonUserCode]
		public ulong Timestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				ulong timestampDefaultValue;
				if (flag)
				{
					timestampDefaultValue = this.timestamp_;
				}
				else
				{
					timestampDefaultValue = Bug.TimestampDefaultValue;
				}
				return timestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.timestamp_ = value;
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x00135A3C File Offset: 0x00133C3C
		[DebuggerNonUserCode]
		public bool HasTimestamp
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00135A5D File Offset: 0x00133C5D
		[DebuggerNonUserCode]
		public void ClearTimestamp()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x00135A74 File Offset: 0x00133C74
		// (set) Token: 0x060050C7 RID: 20679 RVA: 0x00135AA9 File Offset: 0x00133CA9
		[DebuggerNonUserCode]
		public int TrackedQuestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				int trackedQuestSnoDefaultValue;
				if (flag)
				{
					trackedQuestSnoDefaultValue = this.trackedQuestSno_;
				}
				else
				{
					trackedQuestSnoDefaultValue = Bug.TrackedQuestSnoDefaultValue;
				}
				return trackedQuestSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.trackedQuestSno_ = value;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x00135AC8 File Offset: 0x00133CC8
		[DebuggerNonUserCode]
		public bool HasTrackedQuestSno
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00135AE9 File Offset: 0x00133CE9
		[DebuggerNonUserCode]
		public void ClearTrackedQuestSno()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x00135B00 File Offset: 0x00133D00
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x00135B21 File Offset: 0x00133D21
		[DebuggerNonUserCode]
		public string TrackedQuestName
		{
			get
			{
				return this.trackedQuestName_ ?? Bug.TrackedQuestNameDefaultValue;
			}
			set
			{
				this.trackedQuestName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x00135B38 File Offset: 0x00133D38
		[DebuggerNonUserCode]
		public bool HasTrackedQuestName
		{
			get
			{
				return this.trackedQuestName_ != null;
			}
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00135B53 File Offset: 0x00133D53
		[DebuggerNonUserCode]
		public void ClearTrackedQuestName()
		{
			this.trackedQuestName_ = null;
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x00135B60 File Offset: 0x00133D60
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00135B95 File Offset: 0x00133D95
		[DebuggerNonUserCode]
		public int TrackedQuestPhase
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				int trackedQuestPhaseDefaultValue;
				if (flag)
				{
					trackedQuestPhaseDefaultValue = this.trackedQuestPhase_;
				}
				else
				{
					trackedQuestPhaseDefaultValue = Bug.TrackedQuestPhaseDefaultValue;
				}
				return trackedQuestPhaseDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.trackedQuestPhase_ = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x00135BB4 File Offset: 0x00133DB4
		[DebuggerNonUserCode]
		public bool HasTrackedQuestPhase
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00135BD5 File Offset: 0x00133DD5
		[DebuggerNonUserCode]
		public void ClearTrackedQuestPhase()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x00135BEC File Offset: 0x00133DEC
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x00135C21 File Offset: 0x00133E21
		[DebuggerNonUserCode]
		public float OrientationX
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				float orientationXDefaultValue;
				if (flag)
				{
					orientationXDefaultValue = this.orientationX_;
				}
				else
				{
					orientationXDefaultValue = Bug.OrientationXDefaultValue;
				}
				return orientationXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.orientationX_ = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x00135C40 File Offset: 0x00133E40
		[DebuggerNonUserCode]
		public bool HasOrientationX
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00135C61 File Offset: 0x00133E61
		[DebuggerNonUserCode]
		public void ClearOrientationX()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x00135C78 File Offset: 0x00133E78
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x00135CAD File Offset: 0x00133EAD
		[DebuggerNonUserCode]
		public float OrientationY
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				float orientationYDefaultValue;
				if (flag)
				{
					orientationYDefaultValue = this.orientationY_;
				}
				else
				{
					orientationYDefaultValue = Bug.OrientationYDefaultValue;
				}
				return orientationYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.orientationY_ = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x00135CCC File Offset: 0x00133ECC
		[DebuggerNonUserCode]
		public bool HasOrientationY
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00135CED File Offset: 0x00133EED
		[DebuggerNonUserCode]
		public void ClearOrientationY()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x00135D04 File Offset: 0x00133F04
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x00135D39 File Offset: 0x00133F39
		[DebuggerNonUserCode]
		public float OrientationZ
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				float orientationZDefaultValue;
				if (flag)
				{
					orientationZDefaultValue = this.orientationZ_;
				}
				else
				{
					orientationZDefaultValue = Bug.OrientationZDefaultValue;
				}
				return orientationZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.orientationZ_ = value;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x00135D58 File Offset: 0x00133F58
		[DebuggerNonUserCode]
		public bool HasOrientationZ
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00135D79 File Offset: 0x00133F79
		[DebuggerNonUserCode]
		public void ClearOrientationZ()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x00135D90 File Offset: 0x00133F90
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x00135DC5 File Offset: 0x00133FC5
		[DebuggerNonUserCode]
		public float OrientationW
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				float orientationWDefaultValue;
				if (flag)
				{
					orientationWDefaultValue = this.orientationW_;
				}
				else
				{
					orientationWDefaultValue = Bug.OrientationWDefaultValue;
				}
				return orientationWDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.orientationW_ = value;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x00135DE4 File Offset: 0x00133FE4
		[DebuggerNonUserCode]
		public bool HasOrientationW
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00135E05 File Offset: 0x00134005
		[DebuggerNonUserCode]
		public void ClearOrientationW()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060050E2 RID: 20706 RVA: 0x00135E1C File Offset: 0x0013401C
		// (set) Token: 0x060050E3 RID: 20707 RVA: 0x00135E51 File Offset: 0x00134051
		[DebuggerNonUserCode]
		public int LatencyMs
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				int latencyMsDefaultValue;
				if (flag)
				{
					latencyMsDefaultValue = this.latencyMs_;
				}
				else
				{
					latencyMsDefaultValue = Bug.LatencyMsDefaultValue;
				}
				return latencyMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.latencyMs_ = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x00135E70 File Offset: 0x00134070
		[DebuggerNonUserCode]
		public bool HasLatencyMs
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00135E91 File Offset: 0x00134091
		[DebuggerNonUserCode]
		public void ClearLatencyMs()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x00135EA8 File Offset: 0x001340A8
		// (set) Token: 0x060050E7 RID: 20711 RVA: 0x00135EC9 File Offset: 0x001340C9
		[Obsolete]
		[DebuggerNonUserCode]
		public ByteString PlayerHeroTxt
		{
			get
			{
				return this.playerHeroTxt_ ?? Bug.PlayerHeroTxtDefaultValue;
			}
			set
			{
				this.playerHeroTxt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x00135EE0 File Offset: 0x001340E0
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasPlayerHeroTxt
		{
			get
			{
				return this.playerHeroTxt_ != null;
			}
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00135EFE File Offset: 0x001340FE
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearPlayerHeroTxt()
		{
			this.playerHeroTxt_ = null;
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x00135F08 File Offset: 0x00134108
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x00135F29 File Offset: 0x00134129
		[DebuggerNonUserCode]
		public ByteString LocalPrefsTxt
		{
			get
			{
				return this.localPrefsTxt_ ?? Bug.LocalPrefsTxtDefaultValue;
			}
			set
			{
				this.localPrefsTxt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x00135F40 File Offset: 0x00134140
		[DebuggerNonUserCode]
		public bool HasLocalPrefsTxt
		{
			get
			{
				return this.localPrefsTxt_ != null;
			}
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00135F5E File Offset: 0x0013415E
		[DebuggerNonUserCode]
		public void ClearLocalPrefsTxt()
		{
			this.localPrefsTxt_ = null;
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x00135F68 File Offset: 0x00134168
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x00135F89 File Offset: 0x00134189
		[DebuggerNonUserCode]
		public string LastScrollUsed
		{
			get
			{
				return this.lastScrollUsed_ ?? Bug.LastScrollUsedDefaultValue;
			}
			set
			{
				this.lastScrollUsed_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x00135FA0 File Offset: 0x001341A0
		[DebuggerNonUserCode]
		public bool HasLastScrollUsed
		{
			get
			{
				return this.lastScrollUsed_ != null;
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00135FBB File Offset: 0x001341BB
		[DebuggerNonUserCode]
		public void ClearLastScrollUsed()
		{
			this.lastScrollUsed_ = null;
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x00135FC8 File Offset: 0x001341C8
		// (set) Token: 0x060050F3 RID: 20723 RVA: 0x00135FFD File Offset: 0x001341FD
		[DebuggerNonUserCode]
		public int LastCutscenePlayedSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				int lastCutscenePlayedSnoDefaultValue;
				if (flag)
				{
					lastCutscenePlayedSnoDefaultValue = this.lastCutscenePlayedSno_;
				}
				else
				{
					lastCutscenePlayedSnoDefaultValue = Bug.LastCutscenePlayedSnoDefaultValue;
				}
				return lastCutscenePlayedSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.lastCutscenePlayedSno_ = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x060050F4 RID: 20724 RVA: 0x0013601C File Offset: 0x0013421C
		[DebuggerNonUserCode]
		public bool HasLastCutscenePlayedSno
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x0013603D File Offset: 0x0013423D
		[DebuggerNonUserCode]
		public void ClearLastCutscenePlayedSno()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x00136054 File Offset: 0x00134254
		// (set) Token: 0x060050F7 RID: 20727 RVA: 0x00136075 File Offset: 0x00134275
		[DebuggerNonUserCode]
		public string LastCutscenePlayedName
		{
			get
			{
				return this.lastCutscenePlayedName_ ?? Bug.LastCutscenePlayedNameDefaultValue;
			}
			set
			{
				this.lastCutscenePlayedName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x0013608C File Offset: 0x0013428C
		[DebuggerNonUserCode]
		public bool HasLastCutscenePlayedName
		{
			get
			{
				return this.lastCutscenePlayedName_ != null;
			}
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x001360A7 File Offset: 0x001342A7
		[DebuggerNonUserCode]
		public void ClearLastCutscenePlayedName()
		{
			this.lastCutscenePlayedName_ = null;
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x001360B4 File Offset: 0x001342B4
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x001360D5 File Offset: 0x001342D5
		[DebuggerNonUserCode]
		public string LastCompletedQuestPhaseInfo
		{
			get
			{
				return this.lastCompletedQuestPhaseInfo_ ?? Bug.LastCompletedQuestPhaseInfoDefaultValue;
			}
			set
			{
				this.lastCompletedQuestPhaseInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x001360EC File Offset: 0x001342EC
		[DebuggerNonUserCode]
		public bool HasLastCompletedQuestPhaseInfo
		{
			get
			{
				return this.lastCompletedQuestPhaseInfo_ != null;
			}
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00136107 File Offset: 0x00134307
		[DebuggerNonUserCode]
		public void ClearLastCompletedQuestPhaseInfo()
		{
			this.lastCompletedQuestPhaseInfo_ = null;
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x00136114 File Offset: 0x00134314
		// (set) Token: 0x060050FF RID: 20735 RVA: 0x00136135 File Offset: 0x00134335
		[DebuggerNonUserCode]
		public string InstanceType
		{
			get
			{
				return this.instanceType_ ?? Bug.InstanceTypeDefaultValue;
			}
			set
			{
				this.instanceType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x0013614C File Offset: 0x0013434C
		[DebuggerNonUserCode]
		public bool HasInstanceType
		{
			get
			{
				return this.instanceType_ != null;
			}
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00136167 File Offset: 0x00134367
		[DebuggerNonUserCode]
		public void ClearInstanceType()
		{
			this.instanceType_ = null;
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x00136174 File Offset: 0x00134374
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x00136195 File Offset: 0x00134395
		[DebuggerNonUserCode]
		public string NightmareDungeonInfo
		{
			get
			{
				return this.nightmareDungeonInfo_ ?? Bug.NightmareDungeonInfoDefaultValue;
			}
			set
			{
				this.nightmareDungeonInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x001361AC File Offset: 0x001343AC
		[DebuggerNonUserCode]
		public bool HasNightmareDungeonInfo
		{
			get
			{
				return this.nightmareDungeonInfo_ != null;
			}
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x001361C7 File Offset: 0x001343C7
		[DebuggerNonUserCode]
		public void ClearNightmareDungeonInfo()
		{
			this.nightmareDungeonInfo_ = null;
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x001361D4 File Offset: 0x001343D4
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x00136209 File Offset: 0x00134409
		[DebuggerNonUserCode]
		public int LastCompletedEventSno
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				int lastCompletedEventSnoDefaultValue;
				if (flag)
				{
					lastCompletedEventSnoDefaultValue = this.lastCompletedEventSno_;
				}
				else
				{
					lastCompletedEventSnoDefaultValue = Bug.LastCompletedEventSnoDefaultValue;
				}
				return lastCompletedEventSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.lastCompletedEventSno_ = value;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00136228 File Offset: 0x00134428
		[DebuggerNonUserCode]
		public bool HasLastCompletedEventSno
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00136249 File Offset: 0x00134449
		[DebuggerNonUserCode]
		public void ClearLastCompletedEventSno()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00136260 File Offset: 0x00134460
		// (set) Token: 0x0600510B RID: 20747 RVA: 0x00136281 File Offset: 0x00134481
		[DebuggerNonUserCode]
		public string LastCompletedEventName
		{
			get
			{
				return this.lastCompletedEventName_ ?? Bug.LastCompletedEventNameDefaultValue;
			}
			set
			{
				this.lastCompletedEventName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00136298 File Offset: 0x00134498
		[DebuggerNonUserCode]
		public bool HasLastCompletedEventName
		{
			get
			{
				return this.lastCompletedEventName_ != null;
			}
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x001362B3 File Offset: 0x001344B3
		[DebuggerNonUserCode]
		public void ClearLastCompletedEventName()
		{
			this.lastCompletedEventName_ = null;
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x001362C0 File Offset: 0x001344C0
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x001362F5 File Offset: 0x001344F5
		[DebuggerNonUserCode]
		public int LastCompletedEventNumParticipants
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				int lastCompletedEventNumParticipantsDefaultValue;
				if (flag)
				{
					lastCompletedEventNumParticipantsDefaultValue = this.lastCompletedEventNumParticipants_;
				}
				else
				{
					lastCompletedEventNumParticipantsDefaultValue = Bug.LastCompletedEventNumParticipantsDefaultValue;
				}
				return lastCompletedEventNumParticipantsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.lastCompletedEventNumParticipants_ = value;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00136314 File Offset: 0x00134514
		[DebuggerNonUserCode]
		public bool HasLastCompletedEventNumParticipants
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00136335 File Offset: 0x00134535
		[DebuggerNonUserCode]
		public void ClearLastCompletedEventNumParticipants()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x0013634C File Offset: 0x0013454C
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x00136381 File Offset: 0x00134581
		[DebuggerNonUserCode]
		public int NumLocalPartyPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 33554432) != 0;
				int numLocalPartyPlayersDefaultValue;
				if (flag)
				{
					numLocalPartyPlayersDefaultValue = this.numLocalPartyPlayers_;
				}
				else
				{
					numLocalPartyPlayersDefaultValue = Bug.NumLocalPartyPlayersDefaultValue;
				}
				return numLocalPartyPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 33554432;
				this.numLocalPartyPlayers_ = value;
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x001363A0 File Offset: 0x001345A0
		[DebuggerNonUserCode]
		public bool HasNumLocalPartyPlayers
		{
			get
			{
				return (this._hasBits0 & 33554432) != 0;
			}
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x001363C1 File Offset: 0x001345C1
		[DebuggerNonUserCode]
		public void ClearNumLocalPartyPlayers()
		{
			this._hasBits0 &= -33554433;
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x001363D8 File Offset: 0x001345D8
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x0013640D File Offset: 0x0013460D
		[DebuggerNonUserCode]
		public int NumOnlinePartyPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 67108864) != 0;
				int numOnlinePartyPlayersDefaultValue;
				if (flag)
				{
					numOnlinePartyPlayersDefaultValue = this.numOnlinePartyPlayers_;
				}
				else
				{
					numOnlinePartyPlayersDefaultValue = Bug.NumOnlinePartyPlayersDefaultValue;
				}
				return numOnlinePartyPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 67108864;
				this.numOnlinePartyPlayers_ = value;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x0013642C File Offset: 0x0013462C
		[DebuggerNonUserCode]
		public bool HasNumOnlinePartyPlayers
		{
			get
			{
				return (this._hasBits0 & 67108864) != 0;
			}
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x0013644D File Offset: 0x0013464D
		[DebuggerNonUserCode]
		public void ClearNumOnlinePartyPlayers()
		{
			this._hasBits0 &= -67108865;
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x00136464 File Offset: 0x00134664
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x00136485 File Offset: 0x00134685
		[DebuggerNonUserCode]
		public ByteString ClientSurroundingsInfoTxt
		{
			get
			{
				return this.clientSurroundingsInfoTxt_ ?? Bug.ClientSurroundingsInfoTxtDefaultValue;
			}
			set
			{
				this.clientSurroundingsInfoTxt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x0013649C File Offset: 0x0013469C
		[DebuggerNonUserCode]
		public bool HasClientSurroundingsInfoTxt
		{
			get
			{
				return this.clientSurroundingsInfoTxt_ != null;
			}
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x001364BA File Offset: 0x001346BA
		[DebuggerNonUserCode]
		public void ClearClientSurroundingsInfoTxt()
		{
			this.clientSurroundingsInfoTxt_ = null;
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x001364C4 File Offset: 0x001346C4
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x001364E5 File Offset: 0x001346E5
		[DebuggerNonUserCode]
		public string LastUsedWaypointInfo
		{
			get
			{
				return this.lastUsedWaypointInfo_ ?? Bug.LastUsedWaypointInfoDefaultValue;
			}
			set
			{
				this.lastUsedWaypointInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x001364FC File Offset: 0x001346FC
		[DebuggerNonUserCode]
		public bool HasLastUsedWaypointInfo
		{
			get
			{
				return this.lastUsedWaypointInfo_ != null;
			}
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00136517 File Offset: 0x00134717
		[DebuggerNonUserCode]
		public void ClearLastUsedWaypointInfo()
		{
			this.lastUsedWaypointInfo_ = null;
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x00136524 File Offset: 0x00134724
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x00136545 File Offset: 0x00134745
		[DebuggerNonUserCode]
		public string ConcerningContentGroups
		{
			get
			{
				return this.concerningContentGroups_ ?? Bug.ConcerningContentGroupsDefaultValue;
			}
			set
			{
				this.concerningContentGroups_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x0013655C File Offset: 0x0013475C
		[DebuggerNonUserCode]
		public bool HasConcerningContentGroups
		{
			get
			{
				return this.concerningContentGroups_ != null;
			}
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00136577 File Offset: 0x00134777
		[DebuggerNonUserCode]
		public void ClearConcerningContentGroups()
		{
			this.concerningContentGroups_ = null;
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00136584 File Offset: 0x00134784
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x001365A5 File Offset: 0x001347A5
		[DebuggerNonUserCode]
		public string Category
		{
			get
			{
				return this.category_ ?? Bug.CategoryDefaultValue;
			}
			set
			{
				this.category_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x001365BC File Offset: 0x001347BC
		[DebuggerNonUserCode]
		public bool HasCategory
		{
			get
			{
				return this.category_ != null;
			}
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x001365D7 File Offset: 0x001347D7
		[DebuggerNonUserCode]
		public void ClearCategory()
		{
			this.category_ = null;
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x001365E4 File Offset: 0x001347E4
		[DebuggerNonUserCode]
		public RepeatedField<ABTestingInfo> Tests
		{
			get
			{
				return this.tests_;
			}
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x001365FC File Offset: 0x001347FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Bug);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x0013661C File Offset: 0x0013481C
		[DebuggerNonUserCode]
		public bool Equals(Bug other)
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
					bool flag4 = this.WorldSno != other.WorldSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.WorldName != other.WorldName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SubzoneSno != other.SubzoneSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SubzoneName != other.SubzoneName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PlaceX, other.PlaceX);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PlaceY, other.PlaceY);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PlaceZ, other.PlaceZ);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SceneSno != other.SceneSno;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SceneName != other.SceneName;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScenePositionX, other.ScenePositionX);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScenePositionY, other.ScenePositionY);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScenePositionZ, other.ScenePositionZ);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.InstanceQuestSno != other.InstanceQuestSno;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.InstanceQuestName != other.InstanceQuestName;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.InstanceQuestPhase != other.InstanceQuestPhase;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.DungeonStates != other.DungeonStates;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.WorldSeed != other.WorldSeed;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.Description != other.Description;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.Metadata != other.Metadata;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.Locale != other.Locale;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !object.Equals(this.LocaleInfo, other.LocaleInfo);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.Branch != other.Branch;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.BuildNumber != other.BuildNumber;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.BuildVersionCodeData != other.BuildVersionCodeData;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.ThumbnailJpgData != other.ThumbnailJpgData;
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = this.Summary != other.Summary;
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = this.Timestamp != other.Timestamp;
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = this.TrackedQuestSno != other.TrackedQuestSno;
																																if (flag31)
																																{
																																	flag2 = false;
																																}
																																else
																																{
																																	bool flag32 = this.TrackedQuestName != other.TrackedQuestName;
																																	if (flag32)
																																	{
																																		flag2 = false;
																																	}
																																	else
																																	{
																																		bool flag33 = this.TrackedQuestPhase != other.TrackedQuestPhase;
																																		if (flag33)
																																		{
																																			flag2 = false;
																																		}
																																		else
																																		{
																																			bool flag34 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OrientationX, other.OrientationX);
																																			if (flag34)
																																			{
																																				flag2 = false;
																																			}
																																			else
																																			{
																																				bool flag35 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OrientationY, other.OrientationY);
																																				if (flag35)
																																				{
																																					flag2 = false;
																																				}
																																				else
																																				{
																																					bool flag36 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OrientationZ, other.OrientationZ);
																																					if (flag36)
																																					{
																																						flag2 = false;
																																					}
																																					else
																																					{
																																						bool flag37 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OrientationW, other.OrientationW);
																																						if (flag37)
																																						{
																																							flag2 = false;
																																						}
																																						else
																																						{
																																							bool flag38 = this.LatencyMs != other.LatencyMs;
																																							if (flag38)
																																							{
																																								flag2 = false;
																																							}
																																							else
																																							{
																																								bool flag39 = this.PlayerHeroTxt != other.PlayerHeroTxt;
																																								if (flag39)
																																								{
																																									flag2 = false;
																																								}
																																								else
																																								{
																																									bool flag40 = this.LocalPrefsTxt != other.LocalPrefsTxt;
																																									if (flag40)
																																									{
																																										flag2 = false;
																																									}
																																									else
																																									{
																																										bool flag41 = this.LastScrollUsed != other.LastScrollUsed;
																																										if (flag41)
																																										{
																																											flag2 = false;
																																										}
																																										else
																																										{
																																											bool flag42 = this.LastCutscenePlayedSno != other.LastCutscenePlayedSno;
																																											if (flag42)
																																											{
																																												flag2 = false;
																																											}
																																											else
																																											{
																																												bool flag43 = this.LastCutscenePlayedName != other.LastCutscenePlayedName;
																																												if (flag43)
																																												{
																																													flag2 = false;
																																												}
																																												else
																																												{
																																													bool flag44 = this.LastCompletedQuestPhaseInfo != other.LastCompletedQuestPhaseInfo;
																																													if (flag44)
																																													{
																																														flag2 = false;
																																													}
																																													else
																																													{
																																														bool flag45 = this.InstanceType != other.InstanceType;
																																														if (flag45)
																																														{
																																															flag2 = false;
																																														}
																																														else
																																														{
																																															bool flag46 = this.NightmareDungeonInfo != other.NightmareDungeonInfo;
																																															if (flag46)
																																															{
																																																flag2 = false;
																																															}
																																															else
																																															{
																																																bool flag47 = this.LastCompletedEventSno != other.LastCompletedEventSno;
																																																if (flag47)
																																																{
																																																	flag2 = false;
																																																}
																																																else
																																																{
																																																	bool flag48 = this.LastCompletedEventName != other.LastCompletedEventName;
																																																	if (flag48)
																																																	{
																																																		flag2 = false;
																																																	}
																																																	else
																																																	{
																																																		bool flag49 = this.LastCompletedEventNumParticipants != other.LastCompletedEventNumParticipants;
																																																		if (flag49)
																																																		{
																																																			flag2 = false;
																																																		}
																																																		else
																																																		{
																																																			bool flag50 = this.NumLocalPartyPlayers != other.NumLocalPartyPlayers;
																																																			if (flag50)
																																																			{
																																																				flag2 = false;
																																																			}
																																																			else
																																																			{
																																																				bool flag51 = this.NumOnlinePartyPlayers != other.NumOnlinePartyPlayers;
																																																				if (flag51)
																																																				{
																																																					flag2 = false;
																																																				}
																																																				else
																																																				{
																																																					bool flag52 = this.ClientSurroundingsInfoTxt != other.ClientSurroundingsInfoTxt;
																																																					if (flag52)
																																																					{
																																																						flag2 = false;
																																																					}
																																																					else
																																																					{
																																																						bool flag53 = this.LastUsedWaypointInfo != other.LastUsedWaypointInfo;
																																																						if (flag53)
																																																						{
																																																							flag2 = false;
																																																						}
																																																						else
																																																						{
																																																							bool flag54 = this.ConcerningContentGroups != other.ConcerningContentGroups;
																																																							if (flag54)
																																																							{
																																																								flag2 = false;
																																																							}
																																																							else
																																																							{
																																																								bool flag55 = this.Category != other.Category;
																																																								if (flag55)
																																																								{
																																																									flag2 = false;
																																																								}
																																																								else
																																																								{
																																																									bool flag56 = !this.tests_.Equals(other.tests_);
																																																									flag2 = !flag56 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600512D RID: 20781 RVA: 0x00136CE0 File Offset: 0x00134EE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool hasWorldName = this.HasWorldName;
			if (hasWorldName)
			{
				num ^= this.WorldName.GetHashCode();
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num ^= this.SubzoneSno.GetHashCode();
			}
			bool hasSubzoneName = this.HasSubzoneName;
			if (hasSubzoneName)
			{
				num ^= this.SubzoneName.GetHashCode();
			}
			bool hasPlaceX = this.HasPlaceX;
			if (hasPlaceX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PlaceX);
			}
			bool hasPlaceY = this.HasPlaceY;
			if (hasPlaceY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PlaceY);
			}
			bool hasPlaceZ = this.HasPlaceZ;
			if (hasPlaceZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PlaceZ);
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				num ^= this.SceneSno.GetHashCode();
			}
			bool hasSceneName = this.HasSceneName;
			if (hasSceneName)
			{
				num ^= this.SceneName.GetHashCode();
			}
			bool hasScenePositionX = this.HasScenePositionX;
			if (hasScenePositionX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScenePositionX);
			}
			bool hasScenePositionY = this.HasScenePositionY;
			if (hasScenePositionY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScenePositionY);
			}
			bool hasScenePositionZ = this.HasScenePositionZ;
			if (hasScenePositionZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScenePositionZ);
			}
			bool hasInstanceQuestSno = this.HasInstanceQuestSno;
			if (hasInstanceQuestSno)
			{
				num ^= this.InstanceQuestSno.GetHashCode();
			}
			bool hasInstanceQuestName = this.HasInstanceQuestName;
			if (hasInstanceQuestName)
			{
				num ^= this.InstanceQuestName.GetHashCode();
			}
			bool hasInstanceQuestPhase = this.HasInstanceQuestPhase;
			if (hasInstanceQuestPhase)
			{
				num ^= this.InstanceQuestPhase.GetHashCode();
			}
			bool hasDungeonStates = this.HasDungeonStates;
			if (hasDungeonStates)
			{
				num ^= this.DungeonStates.GetHashCode();
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num ^= this.WorldSeed.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool hasMetadata = this.HasMetadata;
			if (hasMetadata)
			{
				num ^= this.Metadata.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				num ^= this.LocaleInfo.GetHashCode();
			}
			bool hasBranch = this.HasBranch;
			if (hasBranch)
			{
				num ^= this.Branch.GetHashCode();
			}
			bool hasBuildNumber = this.HasBuildNumber;
			if (hasBuildNumber)
			{
				num ^= this.BuildNumber.GetHashCode();
			}
			bool hasBuildVersionCodeData = this.HasBuildVersionCodeData;
			if (hasBuildVersionCodeData)
			{
				num ^= this.BuildVersionCodeData.GetHashCode();
			}
			bool hasThumbnailJpgData = this.HasThumbnailJpgData;
			if (hasThumbnailJpgData)
			{
				num ^= this.ThumbnailJpgData.GetHashCode();
			}
			bool hasSummary = this.HasSummary;
			if (hasSummary)
			{
				num ^= this.Summary.GetHashCode();
			}
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				num ^= this.Timestamp.GetHashCode();
			}
			bool hasTrackedQuestSno = this.HasTrackedQuestSno;
			if (hasTrackedQuestSno)
			{
				num ^= this.TrackedQuestSno.GetHashCode();
			}
			bool hasTrackedQuestName = this.HasTrackedQuestName;
			if (hasTrackedQuestName)
			{
				num ^= this.TrackedQuestName.GetHashCode();
			}
			bool hasTrackedQuestPhase = this.HasTrackedQuestPhase;
			if (hasTrackedQuestPhase)
			{
				num ^= this.TrackedQuestPhase.GetHashCode();
			}
			bool hasOrientationX = this.HasOrientationX;
			if (hasOrientationX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OrientationX);
			}
			bool hasOrientationY = this.HasOrientationY;
			if (hasOrientationY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OrientationY);
			}
			bool hasOrientationZ = this.HasOrientationZ;
			if (hasOrientationZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OrientationZ);
			}
			bool hasOrientationW = this.HasOrientationW;
			if (hasOrientationW)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OrientationW);
			}
			bool hasLatencyMs = this.HasLatencyMs;
			if (hasLatencyMs)
			{
				num ^= this.LatencyMs.GetHashCode();
			}
			bool hasPlayerHeroTxt = this.HasPlayerHeroTxt;
			if (hasPlayerHeroTxt)
			{
				num ^= this.PlayerHeroTxt.GetHashCode();
			}
			bool hasLocalPrefsTxt = this.HasLocalPrefsTxt;
			if (hasLocalPrefsTxt)
			{
				num ^= this.LocalPrefsTxt.GetHashCode();
			}
			bool hasLastScrollUsed = this.HasLastScrollUsed;
			if (hasLastScrollUsed)
			{
				num ^= this.LastScrollUsed.GetHashCode();
			}
			bool hasLastCutscenePlayedSno = this.HasLastCutscenePlayedSno;
			if (hasLastCutscenePlayedSno)
			{
				num ^= this.LastCutscenePlayedSno.GetHashCode();
			}
			bool hasLastCutscenePlayedName = this.HasLastCutscenePlayedName;
			if (hasLastCutscenePlayedName)
			{
				num ^= this.LastCutscenePlayedName.GetHashCode();
			}
			bool hasLastCompletedQuestPhaseInfo = this.HasLastCompletedQuestPhaseInfo;
			if (hasLastCompletedQuestPhaseInfo)
			{
				num ^= this.LastCompletedQuestPhaseInfo.GetHashCode();
			}
			bool hasInstanceType = this.HasInstanceType;
			if (hasInstanceType)
			{
				num ^= this.InstanceType.GetHashCode();
			}
			bool hasNightmareDungeonInfo = this.HasNightmareDungeonInfo;
			if (hasNightmareDungeonInfo)
			{
				num ^= this.NightmareDungeonInfo.GetHashCode();
			}
			bool hasLastCompletedEventSno = this.HasLastCompletedEventSno;
			if (hasLastCompletedEventSno)
			{
				num ^= this.LastCompletedEventSno.GetHashCode();
			}
			bool hasLastCompletedEventName = this.HasLastCompletedEventName;
			if (hasLastCompletedEventName)
			{
				num ^= this.LastCompletedEventName.GetHashCode();
			}
			bool hasLastCompletedEventNumParticipants = this.HasLastCompletedEventNumParticipants;
			if (hasLastCompletedEventNumParticipants)
			{
				num ^= this.LastCompletedEventNumParticipants.GetHashCode();
			}
			bool hasNumLocalPartyPlayers = this.HasNumLocalPartyPlayers;
			if (hasNumLocalPartyPlayers)
			{
				num ^= this.NumLocalPartyPlayers.GetHashCode();
			}
			bool hasNumOnlinePartyPlayers = this.HasNumOnlinePartyPlayers;
			if (hasNumOnlinePartyPlayers)
			{
				num ^= this.NumOnlinePartyPlayers.GetHashCode();
			}
			bool hasClientSurroundingsInfoTxt = this.HasClientSurroundingsInfoTxt;
			if (hasClientSurroundingsInfoTxt)
			{
				num ^= this.ClientSurroundingsInfoTxt.GetHashCode();
			}
			bool hasLastUsedWaypointInfo = this.HasLastUsedWaypointInfo;
			if (hasLastUsedWaypointInfo)
			{
				num ^= this.LastUsedWaypointInfo.GetHashCode();
			}
			bool hasConcerningContentGroups = this.HasConcerningContentGroups;
			if (hasConcerningContentGroups)
			{
				num ^= this.ConcerningContentGroups.GetHashCode();
			}
			bool hasCategory = this.HasCategory;
			if (hasCategory)
			{
				num ^= this.Category.GetHashCode();
			}
			num ^= this.tests_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x001372D4 File Offset: 0x001354D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x001372EC File Offset: 0x001354EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x001372F8 File Offset: 0x001354F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.WorldSno);
			}
			bool hasWorldName = this.HasWorldName;
			if (hasWorldName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.WorldName);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.SubzoneSno);
			}
			bool hasSubzoneName = this.HasSubzoneName;
			if (hasSubzoneName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.SubzoneName);
			}
			bool hasPlaceX = this.HasPlaceX;
			if (hasPlaceX)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.PlaceX);
			}
			bool hasPlaceY = this.HasPlaceY;
			if (hasPlaceY)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.PlaceY);
			}
			bool hasPlaceZ = this.HasPlaceZ;
			if (hasPlaceZ)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.PlaceZ);
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.SceneSno);
			}
			bool hasSceneName = this.HasSceneName;
			if (hasSceneName)
			{
				output.WriteRawTag(74);
				output.WriteString(this.SceneName);
			}
			bool hasScenePositionX = this.HasScenePositionX;
			if (hasScenePositionX)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.ScenePositionX);
			}
			bool hasScenePositionY = this.HasScenePositionY;
			if (hasScenePositionY)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.ScenePositionY);
			}
			bool hasScenePositionZ = this.HasScenePositionZ;
			if (hasScenePositionZ)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.ScenePositionZ);
			}
			bool hasInstanceQuestSno = this.HasInstanceQuestSno;
			if (hasInstanceQuestSno)
			{
				output.WriteRawTag(104);
				output.WriteSInt32(this.InstanceQuestSno);
			}
			bool hasInstanceQuestName = this.HasInstanceQuestName;
			if (hasInstanceQuestName)
			{
				output.WriteRawTag(114);
				output.WriteString(this.InstanceQuestName);
			}
			bool hasInstanceQuestPhase = this.HasInstanceQuestPhase;
			if (hasInstanceQuestPhase)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstanceQuestPhase);
			}
			bool hasDungeonStates = this.HasDungeonStates;
			if (hasDungeonStates)
			{
				output.WriteRawTag(130, 1);
				output.WriteString(this.DungeonStates);
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.WorldSeed);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(146, 1);
				output.WriteString(this.Description);
			}
			bool hasMetadata = this.HasMetadata;
			if (hasMetadata)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.Metadata);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.Locale);
			}
			bool hasBranch = this.HasBranch;
			if (hasBranch)
			{
				output.WriteRawTag(170, 1);
				output.WriteString(this.Branch);
			}
			bool hasBuildNumber = this.HasBuildNumber;
			if (hasBuildNumber)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.BuildNumber);
			}
			bool hasBuildVersionCodeData = this.HasBuildVersionCodeData;
			if (hasBuildVersionCodeData)
			{
				output.WriteRawTag(186, 1);
				output.WriteString(this.BuildVersionCodeData);
			}
			bool hasThumbnailJpgData = this.HasThumbnailJpgData;
			if (hasThumbnailJpgData)
			{
				output.WriteRawTag(194, 1);
				output.WriteBytes(this.ThumbnailJpgData);
			}
			bool hasSummary = this.HasSummary;
			if (hasSummary)
			{
				output.WriteRawTag(202, 1);
				output.WriteString(this.Summary);
			}
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				output.WriteRawTag(208, 1);
				output.WriteUInt64(this.Timestamp);
			}
			bool hasTrackedQuestSno = this.HasTrackedQuestSno;
			if (hasTrackedQuestSno)
			{
				output.WriteRawTag(216, 1);
				output.WriteSInt32(this.TrackedQuestSno);
			}
			bool hasTrackedQuestName = this.HasTrackedQuestName;
			if (hasTrackedQuestName)
			{
				output.WriteRawTag(226, 1);
				output.WriteString(this.TrackedQuestName);
			}
			bool hasTrackedQuestPhase = this.HasTrackedQuestPhase;
			if (hasTrackedQuestPhase)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.TrackedQuestPhase);
			}
			bool hasOrientationX = this.HasOrientationX;
			if (hasOrientationX)
			{
				output.WriteRawTag(245, 1);
				output.WriteFloat(this.OrientationX);
			}
			bool hasOrientationY = this.HasOrientationY;
			if (hasOrientationY)
			{
				output.WriteRawTag(253, 1);
				output.WriteFloat(this.OrientationY);
			}
			bool hasOrientationZ = this.HasOrientationZ;
			if (hasOrientationZ)
			{
				output.WriteRawTag(133, 2);
				output.WriteFloat(this.OrientationZ);
			}
			bool hasOrientationW = this.HasOrientationW;
			if (hasOrientationW)
			{
				output.WriteRawTag(141, 2);
				output.WriteFloat(this.OrientationW);
			}
			bool hasLatencyMs = this.HasLatencyMs;
			if (hasLatencyMs)
			{
				output.WriteRawTag(144, 2);
				output.WriteInt32(this.LatencyMs);
			}
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.LocaleInfo);
			}
			bool hasPlayerHeroTxt = this.HasPlayerHeroTxt;
			if (hasPlayerHeroTxt)
			{
				output.WriteRawTag(162, 2);
				output.WriteBytes(this.PlayerHeroTxt);
			}
			bool hasLocalPrefsTxt = this.HasLocalPrefsTxt;
			if (hasLocalPrefsTxt)
			{
				output.WriteRawTag(170, 2);
				output.WriteBytes(this.LocalPrefsTxt);
			}
			bool hasLastScrollUsed = this.HasLastScrollUsed;
			if (hasLastScrollUsed)
			{
				output.WriteRawTag(178, 2);
				output.WriteString(this.LastScrollUsed);
			}
			bool hasLastCutscenePlayedSno = this.HasLastCutscenePlayedSno;
			if (hasLastCutscenePlayedSno)
			{
				output.WriteRawTag(184, 2);
				output.WriteSInt32(this.LastCutscenePlayedSno);
			}
			bool hasLastCutscenePlayedName = this.HasLastCutscenePlayedName;
			if (hasLastCutscenePlayedName)
			{
				output.WriteRawTag(194, 2);
				output.WriteString(this.LastCutscenePlayedName);
			}
			bool hasLastCompletedQuestPhaseInfo = this.HasLastCompletedQuestPhaseInfo;
			if (hasLastCompletedQuestPhaseInfo)
			{
				output.WriteRawTag(202, 2);
				output.WriteString(this.LastCompletedQuestPhaseInfo);
			}
			bool hasInstanceType = this.HasInstanceType;
			if (hasInstanceType)
			{
				output.WriteRawTag(210, 2);
				output.WriteString(this.InstanceType);
			}
			bool hasNightmareDungeonInfo = this.HasNightmareDungeonInfo;
			if (hasNightmareDungeonInfo)
			{
				output.WriteRawTag(218, 2);
				output.WriteString(this.NightmareDungeonInfo);
			}
			bool hasLastCompletedEventSno = this.HasLastCompletedEventSno;
			if (hasLastCompletedEventSno)
			{
				output.WriteRawTag(224, 2);
				output.WriteSInt32(this.LastCompletedEventSno);
			}
			bool hasLastCompletedEventName = this.HasLastCompletedEventName;
			if (hasLastCompletedEventName)
			{
				output.WriteRawTag(234, 2);
				output.WriteString(this.LastCompletedEventName);
			}
			bool hasLastCompletedEventNumParticipants = this.HasLastCompletedEventNumParticipants;
			if (hasLastCompletedEventNumParticipants)
			{
				output.WriteRawTag(240, 2);
				output.WriteSInt32(this.LastCompletedEventNumParticipants);
			}
			bool hasNumLocalPartyPlayers = this.HasNumLocalPartyPlayers;
			if (hasNumLocalPartyPlayers)
			{
				output.WriteRawTag(248, 2);
				output.WriteSInt32(this.NumLocalPartyPlayers);
			}
			bool hasNumOnlinePartyPlayers = this.HasNumOnlinePartyPlayers;
			if (hasNumOnlinePartyPlayers)
			{
				output.WriteRawTag(128, 3);
				output.WriteSInt32(this.NumOnlinePartyPlayers);
			}
			bool hasClientSurroundingsInfoTxt = this.HasClientSurroundingsInfoTxt;
			if (hasClientSurroundingsInfoTxt)
			{
				output.WriteRawTag(138, 3);
				output.WriteBytes(this.ClientSurroundingsInfoTxt);
			}
			bool hasLastUsedWaypointInfo = this.HasLastUsedWaypointInfo;
			if (hasLastUsedWaypointInfo)
			{
				output.WriteRawTag(146, 3);
				output.WriteString(this.LastUsedWaypointInfo);
			}
			bool hasConcerningContentGroups = this.HasConcerningContentGroups;
			if (hasConcerningContentGroups)
			{
				output.WriteRawTag(154, 3);
				output.WriteString(this.ConcerningContentGroups);
			}
			bool hasCategory = this.HasCategory;
			if (hasCategory)
			{
				output.WriteRawTag(162, 3);
				output.WriteString(this.Category);
			}
			this.tests_.WriteTo(ref output, Bug._repeated_tests_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x00137B14 File Offset: 0x00135D14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldSno);
			}
			bool hasWorldName = this.HasWorldName;
			if (hasWorldName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.WorldName);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SubzoneSno);
			}
			bool hasSubzoneName = this.HasSubzoneName;
			if (hasSubzoneName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SubzoneName);
			}
			bool hasPlaceX = this.HasPlaceX;
			if (hasPlaceX)
			{
				num += 5;
			}
			bool hasPlaceY = this.HasPlaceY;
			if (hasPlaceY)
			{
				num += 5;
			}
			bool hasPlaceZ = this.HasPlaceZ;
			if (hasPlaceZ)
			{
				num += 5;
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SceneSno);
			}
			bool hasSceneName = this.HasSceneName;
			if (hasSceneName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneName);
			}
			bool hasScenePositionX = this.HasScenePositionX;
			if (hasScenePositionX)
			{
				num += 5;
			}
			bool hasScenePositionY = this.HasScenePositionY;
			if (hasScenePositionY)
			{
				num += 5;
			}
			bool hasScenePositionZ = this.HasScenePositionZ;
			if (hasScenePositionZ)
			{
				num += 5;
			}
			bool hasInstanceQuestSno = this.HasInstanceQuestSno;
			if (hasInstanceQuestSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.InstanceQuestSno);
			}
			bool hasInstanceQuestName = this.HasInstanceQuestName;
			if (hasInstanceQuestName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InstanceQuestName);
			}
			bool hasInstanceQuestPhase = this.HasInstanceQuestPhase;
			if (hasInstanceQuestPhase)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceQuestPhase);
			}
			bool hasDungeonStates = this.HasDungeonStates;
			if (hasDungeonStates)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.DungeonStates);
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.WorldSeed);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool hasMetadata = this.HasMetadata;
			if (hasMetadata)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Metadata);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Locale);
			}
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LocaleInfo);
			}
			bool hasBranch = this.HasBranch;
			if (hasBranch)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Branch);
			}
			bool hasBuildNumber = this.HasBuildNumber;
			if (hasBuildNumber)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BuildNumber);
			}
			bool hasBuildVersionCodeData = this.HasBuildVersionCodeData;
			if (hasBuildVersionCodeData)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.BuildVersionCodeData);
			}
			bool hasThumbnailJpgData = this.HasThumbnailJpgData;
			if (hasThumbnailJpgData)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.ThumbnailJpgData);
			}
			bool hasSummary = this.HasSummary;
			if (hasSummary)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Summary);
			}
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.Timestamp);
			}
			bool hasTrackedQuestSno = this.HasTrackedQuestSno;
			if (hasTrackedQuestSno)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.TrackedQuestSno);
			}
			bool hasTrackedQuestName = this.HasTrackedQuestName;
			if (hasTrackedQuestName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.TrackedQuestName);
			}
			bool hasTrackedQuestPhase = this.HasTrackedQuestPhase;
			if (hasTrackedQuestPhase)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TrackedQuestPhase);
			}
			bool hasOrientationX = this.HasOrientationX;
			if (hasOrientationX)
			{
				num += 6;
			}
			bool hasOrientationY = this.HasOrientationY;
			if (hasOrientationY)
			{
				num += 6;
			}
			bool hasOrientationZ = this.HasOrientationZ;
			if (hasOrientationZ)
			{
				num += 6;
			}
			bool hasOrientationW = this.HasOrientationW;
			if (hasOrientationW)
			{
				num += 6;
			}
			bool hasLatencyMs = this.HasLatencyMs;
			if (hasLatencyMs)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LatencyMs);
			}
			bool hasPlayerHeroTxt = this.HasPlayerHeroTxt;
			if (hasPlayerHeroTxt)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.PlayerHeroTxt);
			}
			bool hasLocalPrefsTxt = this.HasLocalPrefsTxt;
			if (hasLocalPrefsTxt)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.LocalPrefsTxt);
			}
			bool hasLastScrollUsed = this.HasLastScrollUsed;
			if (hasLastScrollUsed)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LastScrollUsed);
			}
			bool hasLastCutscenePlayedSno = this.HasLastCutscenePlayedSno;
			if (hasLastCutscenePlayedSno)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.LastCutscenePlayedSno);
			}
			bool hasLastCutscenePlayedName = this.HasLastCutscenePlayedName;
			if (hasLastCutscenePlayedName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LastCutscenePlayedName);
			}
			bool hasLastCompletedQuestPhaseInfo = this.HasLastCompletedQuestPhaseInfo;
			if (hasLastCompletedQuestPhaseInfo)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LastCompletedQuestPhaseInfo);
			}
			bool hasInstanceType = this.HasInstanceType;
			if (hasInstanceType)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.InstanceType);
			}
			bool hasNightmareDungeonInfo = this.HasNightmareDungeonInfo;
			if (hasNightmareDungeonInfo)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.NightmareDungeonInfo);
			}
			bool hasLastCompletedEventSno = this.HasLastCompletedEventSno;
			if (hasLastCompletedEventSno)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.LastCompletedEventSno);
			}
			bool hasLastCompletedEventName = this.HasLastCompletedEventName;
			if (hasLastCompletedEventName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LastCompletedEventName);
			}
			bool hasLastCompletedEventNumParticipants = this.HasLastCompletedEventNumParticipants;
			if (hasLastCompletedEventNumParticipants)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.LastCompletedEventNumParticipants);
			}
			bool hasNumLocalPartyPlayers = this.HasNumLocalPartyPlayers;
			if (hasNumLocalPartyPlayers)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.NumLocalPartyPlayers);
			}
			bool hasNumOnlinePartyPlayers = this.HasNumOnlinePartyPlayers;
			if (hasNumOnlinePartyPlayers)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.NumOnlinePartyPlayers);
			}
			bool hasClientSurroundingsInfoTxt = this.HasClientSurroundingsInfoTxt;
			if (hasClientSurroundingsInfoTxt)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.ClientSurroundingsInfoTxt);
			}
			bool hasLastUsedWaypointInfo = this.HasLastUsedWaypointInfo;
			if (hasLastUsedWaypointInfo)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LastUsedWaypointInfo);
			}
			bool hasConcerningContentGroups = this.HasConcerningContentGroups;
			if (hasConcerningContentGroups)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ConcerningContentGroups);
			}
			bool hasCategory = this.HasCategory;
			if (hasCategory)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Category);
			}
			num += this.tests_.CalculateSize(Bug._repeated_tests_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x001380FC File Offset: 0x001362FC
		[DebuggerNonUserCode]
		public void MergeFrom(Bug other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				bool hasWorldName = other.HasWorldName;
				if (hasWorldName)
				{
					this.WorldName = other.WorldName;
				}
				bool hasSubzoneSno = other.HasSubzoneSno;
				if (hasSubzoneSno)
				{
					this.SubzoneSno = other.SubzoneSno;
				}
				bool hasSubzoneName = other.HasSubzoneName;
				if (hasSubzoneName)
				{
					this.SubzoneName = other.SubzoneName;
				}
				bool hasPlaceX = other.HasPlaceX;
				if (hasPlaceX)
				{
					this.PlaceX = other.PlaceX;
				}
				bool hasPlaceY = other.HasPlaceY;
				if (hasPlaceY)
				{
					this.PlaceY = other.PlaceY;
				}
				bool hasPlaceZ = other.HasPlaceZ;
				if (hasPlaceZ)
				{
					this.PlaceZ = other.PlaceZ;
				}
				bool hasSceneSno = other.HasSceneSno;
				if (hasSceneSno)
				{
					this.SceneSno = other.SceneSno;
				}
				bool hasSceneName = other.HasSceneName;
				if (hasSceneName)
				{
					this.SceneName = other.SceneName;
				}
				bool hasScenePositionX = other.HasScenePositionX;
				if (hasScenePositionX)
				{
					this.ScenePositionX = other.ScenePositionX;
				}
				bool hasScenePositionY = other.HasScenePositionY;
				if (hasScenePositionY)
				{
					this.ScenePositionY = other.ScenePositionY;
				}
				bool hasScenePositionZ = other.HasScenePositionZ;
				if (hasScenePositionZ)
				{
					this.ScenePositionZ = other.ScenePositionZ;
				}
				bool hasInstanceQuestSno = other.HasInstanceQuestSno;
				if (hasInstanceQuestSno)
				{
					this.InstanceQuestSno = other.InstanceQuestSno;
				}
				bool hasInstanceQuestName = other.HasInstanceQuestName;
				if (hasInstanceQuestName)
				{
					this.InstanceQuestName = other.InstanceQuestName;
				}
				bool hasInstanceQuestPhase = other.HasInstanceQuestPhase;
				if (hasInstanceQuestPhase)
				{
					this.InstanceQuestPhase = other.InstanceQuestPhase;
				}
				bool hasDungeonStates = other.HasDungeonStates;
				if (hasDungeonStates)
				{
					this.DungeonStates = other.DungeonStates;
				}
				bool hasWorldSeed = other.HasWorldSeed;
				if (hasWorldSeed)
				{
					this.WorldSeed = other.WorldSeed;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool hasMetadata = other.HasMetadata;
				if (hasMetadata)
				{
					this.Metadata = other.Metadata;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				bool flag2 = other.localeInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.localeInfo_ == null;
					if (flag3)
					{
						this.LocaleInfo = new LocaleInfo();
					}
					this.LocaleInfo.MergeFrom(other.LocaleInfo);
				}
				bool hasBranch = other.HasBranch;
				if (hasBranch)
				{
					this.Branch = other.Branch;
				}
				bool hasBuildNumber = other.HasBuildNumber;
				if (hasBuildNumber)
				{
					this.BuildNumber = other.BuildNumber;
				}
				bool hasBuildVersionCodeData = other.HasBuildVersionCodeData;
				if (hasBuildVersionCodeData)
				{
					this.BuildVersionCodeData = other.BuildVersionCodeData;
				}
				bool hasThumbnailJpgData = other.HasThumbnailJpgData;
				if (hasThumbnailJpgData)
				{
					this.ThumbnailJpgData = other.ThumbnailJpgData;
				}
				bool hasSummary = other.HasSummary;
				if (hasSummary)
				{
					this.Summary = other.Summary;
				}
				bool hasTimestamp = other.HasTimestamp;
				if (hasTimestamp)
				{
					this.Timestamp = other.Timestamp;
				}
				bool hasTrackedQuestSno = other.HasTrackedQuestSno;
				if (hasTrackedQuestSno)
				{
					this.TrackedQuestSno = other.TrackedQuestSno;
				}
				bool hasTrackedQuestName = other.HasTrackedQuestName;
				if (hasTrackedQuestName)
				{
					this.TrackedQuestName = other.TrackedQuestName;
				}
				bool hasTrackedQuestPhase = other.HasTrackedQuestPhase;
				if (hasTrackedQuestPhase)
				{
					this.TrackedQuestPhase = other.TrackedQuestPhase;
				}
				bool hasOrientationX = other.HasOrientationX;
				if (hasOrientationX)
				{
					this.OrientationX = other.OrientationX;
				}
				bool hasOrientationY = other.HasOrientationY;
				if (hasOrientationY)
				{
					this.OrientationY = other.OrientationY;
				}
				bool hasOrientationZ = other.HasOrientationZ;
				if (hasOrientationZ)
				{
					this.OrientationZ = other.OrientationZ;
				}
				bool hasOrientationW = other.HasOrientationW;
				if (hasOrientationW)
				{
					this.OrientationW = other.OrientationW;
				}
				bool hasLatencyMs = other.HasLatencyMs;
				if (hasLatencyMs)
				{
					this.LatencyMs = other.LatencyMs;
				}
				bool hasPlayerHeroTxt = other.HasPlayerHeroTxt;
				if (hasPlayerHeroTxt)
				{
					this.PlayerHeroTxt = other.PlayerHeroTxt;
				}
				bool hasLocalPrefsTxt = other.HasLocalPrefsTxt;
				if (hasLocalPrefsTxt)
				{
					this.LocalPrefsTxt = other.LocalPrefsTxt;
				}
				bool hasLastScrollUsed = other.HasLastScrollUsed;
				if (hasLastScrollUsed)
				{
					this.LastScrollUsed = other.LastScrollUsed;
				}
				bool hasLastCutscenePlayedSno = other.HasLastCutscenePlayedSno;
				if (hasLastCutscenePlayedSno)
				{
					this.LastCutscenePlayedSno = other.LastCutscenePlayedSno;
				}
				bool hasLastCutscenePlayedName = other.HasLastCutscenePlayedName;
				if (hasLastCutscenePlayedName)
				{
					this.LastCutscenePlayedName = other.LastCutscenePlayedName;
				}
				bool hasLastCompletedQuestPhaseInfo = other.HasLastCompletedQuestPhaseInfo;
				if (hasLastCompletedQuestPhaseInfo)
				{
					this.LastCompletedQuestPhaseInfo = other.LastCompletedQuestPhaseInfo;
				}
				bool hasInstanceType = other.HasInstanceType;
				if (hasInstanceType)
				{
					this.InstanceType = other.InstanceType;
				}
				bool hasNightmareDungeonInfo = other.HasNightmareDungeonInfo;
				if (hasNightmareDungeonInfo)
				{
					this.NightmareDungeonInfo = other.NightmareDungeonInfo;
				}
				bool hasLastCompletedEventSno = other.HasLastCompletedEventSno;
				if (hasLastCompletedEventSno)
				{
					this.LastCompletedEventSno = other.LastCompletedEventSno;
				}
				bool hasLastCompletedEventName = other.HasLastCompletedEventName;
				if (hasLastCompletedEventName)
				{
					this.LastCompletedEventName = other.LastCompletedEventName;
				}
				bool hasLastCompletedEventNumParticipants = other.HasLastCompletedEventNumParticipants;
				if (hasLastCompletedEventNumParticipants)
				{
					this.LastCompletedEventNumParticipants = other.LastCompletedEventNumParticipants;
				}
				bool hasNumLocalPartyPlayers = other.HasNumLocalPartyPlayers;
				if (hasNumLocalPartyPlayers)
				{
					this.NumLocalPartyPlayers = other.NumLocalPartyPlayers;
				}
				bool hasNumOnlinePartyPlayers = other.HasNumOnlinePartyPlayers;
				if (hasNumOnlinePartyPlayers)
				{
					this.NumOnlinePartyPlayers = other.NumOnlinePartyPlayers;
				}
				bool hasClientSurroundingsInfoTxt = other.HasClientSurroundingsInfoTxt;
				if (hasClientSurroundingsInfoTxt)
				{
					this.ClientSurroundingsInfoTxt = other.ClientSurroundingsInfoTxt;
				}
				bool hasLastUsedWaypointInfo = other.HasLastUsedWaypointInfo;
				if (hasLastUsedWaypointInfo)
				{
					this.LastUsedWaypointInfo = other.LastUsedWaypointInfo;
				}
				bool hasConcerningContentGroups = other.HasConcerningContentGroups;
				if (hasConcerningContentGroups)
				{
					this.ConcerningContentGroups = other.ConcerningContentGroups;
				}
				bool hasCategory = other.HasCategory;
				if (hasCategory)
				{
					this.Category = other.Category;
				}
				this.tests_.Add(other.tests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x001386DC File Offset: 0x001368DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x001386E8 File Offset: 0x001368E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 208U)
				{
					if (num3 <= 104U)
					{
						if (num3 <= 53U)
						{
							if (num3 <= 24U)
							{
								if (num3 != 8U)
								{
									if (num3 != 18U)
									{
										if (num3 != 24U)
										{
											goto IL_035B;
										}
										this.SubzoneSno = input.ReadSInt32();
									}
									else
									{
										this.WorldName = input.ReadString();
									}
								}
								else
								{
									this.WorldSno = input.ReadSInt32();
								}
							}
							else if (num3 != 34U)
							{
								if (num3 != 45U)
								{
									if (num3 != 53U)
									{
										goto IL_035B;
									}
									this.PlaceY = input.ReadFloat();
								}
								else
								{
									this.PlaceX = input.ReadFloat();
								}
							}
							else
							{
								this.SubzoneName = input.ReadString();
							}
						}
						else if (num3 <= 74U)
						{
							if (num3 != 61U)
							{
								if (num3 != 64U)
								{
									if (num3 != 74U)
									{
										goto IL_035B;
									}
									this.SceneName = input.ReadString();
								}
								else
								{
									this.SceneSno = input.ReadSInt32();
								}
							}
							else
							{
								this.PlaceZ = input.ReadFloat();
							}
						}
						else if (num3 <= 93U)
						{
							if (num3 != 85U)
							{
								if (num3 != 93U)
								{
									goto IL_035B;
								}
								this.ScenePositionY = input.ReadFloat();
							}
							else
							{
								this.ScenePositionX = input.ReadFloat();
							}
						}
						else if (num3 != 101U)
						{
							if (num3 != 104U)
							{
								goto IL_035B;
							}
							this.InstanceQuestSno = input.ReadSInt32();
						}
						else
						{
							this.ScenePositionZ = input.ReadFloat();
						}
					}
					else if (num3 <= 154U)
					{
						if (num3 <= 130U)
						{
							if (num3 != 114U)
							{
								if (num3 != 120U)
								{
									if (num3 != 130U)
									{
										goto IL_035B;
									}
									this.DungeonStates = input.ReadString();
								}
								else
								{
									this.InstanceQuestPhase = input.ReadInt32();
								}
							}
							else
							{
								this.InstanceQuestName = input.ReadString();
							}
						}
						else if (num3 != 136U)
						{
							if (num3 != 146U)
							{
								if (num3 != 154U)
								{
									goto IL_035B;
								}
								this.Metadata = input.ReadString();
							}
							else
							{
								this.Description = input.ReadString();
							}
						}
						else
						{
							this.WorldSeed = input.ReadInt32();
						}
					}
					else if (num3 <= 176U)
					{
						if (num3 != 160U)
						{
							if (num3 != 170U)
							{
								if (num3 != 176U)
								{
									goto IL_035B;
								}
								this.BuildNumber = input.ReadInt32();
							}
							else
							{
								this.Branch = input.ReadString();
							}
						}
						else
						{
							this.Locale = input.ReadInt32();
						}
					}
					else if (num3 <= 194U)
					{
						if (num3 != 186U)
						{
							if (num3 != 194U)
							{
								goto IL_035B;
							}
							this.ThumbnailJpgData = input.ReadBytes();
						}
						else
						{
							this.BuildVersionCodeData = input.ReadString();
						}
					}
					else if (num3 != 202U)
					{
						if (num3 != 208U)
						{
							goto IL_035B;
						}
						this.Timestamp = input.ReadUInt64();
					}
					else
					{
						this.Summary = input.ReadString();
					}
				}
				else if (num3 <= 312U)
				{
					if (num3 <= 261U)
					{
						if (num3 <= 232U)
						{
							if (num3 != 216U)
							{
								if (num3 != 226U)
								{
									if (num3 != 232U)
									{
										goto IL_035B;
									}
									this.TrackedQuestPhase = input.ReadInt32();
								}
								else
								{
									this.TrackedQuestName = input.ReadString();
								}
							}
							else
							{
								this.TrackedQuestSno = input.ReadSInt32();
							}
						}
						else if (num3 != 245U)
						{
							if (num3 != 253U)
							{
								if (num3 != 261U)
								{
									goto IL_035B;
								}
								this.OrientationZ = input.ReadFloat();
							}
							else
							{
								this.OrientationY = input.ReadFloat();
							}
						}
						else
						{
							this.OrientationX = input.ReadFloat();
						}
					}
					else if (num3 <= 282U)
					{
						if (num3 != 269U)
						{
							if (num3 != 272U)
							{
								if (num3 != 282U)
								{
									goto IL_035B;
								}
								bool flag = this.localeInfo_ == null;
								if (flag)
								{
									this.LocaleInfo = new LocaleInfo();
								}
								input.ReadMessage(this.LocaleInfo);
							}
							else
							{
								this.LatencyMs = input.ReadInt32();
							}
						}
						else
						{
							this.OrientationW = input.ReadFloat();
						}
					}
					else if (num3 <= 298U)
					{
						if (num3 != 290U)
						{
							if (num3 != 298U)
							{
								goto IL_035B;
							}
							this.LocalPrefsTxt = input.ReadBytes();
						}
						else
						{
							this.PlayerHeroTxt = input.ReadBytes();
						}
					}
					else if (num3 != 306U)
					{
						if (num3 != 312U)
						{
							goto IL_035B;
						}
						this.LastCutscenePlayedSno = input.ReadSInt32();
					}
					else
					{
						this.LastScrollUsed = input.ReadString();
					}
				}
				else if (num3 <= 368U)
				{
					if (num3 <= 338U)
					{
						if (num3 != 322U)
						{
							if (num3 != 330U)
							{
								if (num3 != 338U)
								{
									goto IL_035B;
								}
								this.InstanceType = input.ReadString();
							}
							else
							{
								this.LastCompletedQuestPhaseInfo = input.ReadString();
							}
						}
						else
						{
							this.LastCutscenePlayedName = input.ReadString();
						}
					}
					else if (num3 <= 352U)
					{
						if (num3 != 346U)
						{
							if (num3 != 352U)
							{
								goto IL_035B;
							}
							this.LastCompletedEventSno = input.ReadSInt32();
						}
						else
						{
							this.NightmareDungeonInfo = input.ReadString();
						}
					}
					else if (num3 != 362U)
					{
						if (num3 != 368U)
						{
							goto IL_035B;
						}
						this.LastCompletedEventNumParticipants = input.ReadSInt32();
					}
					else
					{
						this.LastCompletedEventName = input.ReadString();
					}
				}
				else if (num3 <= 394U)
				{
					if (num3 != 376U)
					{
						if (num3 != 384U)
						{
							if (num3 != 394U)
							{
								goto IL_035B;
							}
							this.ClientSurroundingsInfoTxt = input.ReadBytes();
						}
						else
						{
							this.NumOnlinePartyPlayers = input.ReadSInt32();
						}
					}
					else
					{
						this.NumLocalPartyPlayers = input.ReadSInt32();
					}
				}
				else if (num3 <= 410U)
				{
					if (num3 != 402U)
					{
						if (num3 != 410U)
						{
							goto IL_035B;
						}
						this.ConcerningContentGroups = input.ReadString();
					}
					else
					{
						this.LastUsedWaypointInfo = input.ReadString();
					}
				}
				else if (num3 != 418U)
				{
					if (num3 != 426U)
					{
						goto IL_035B;
					}
					this.tests_.AddEntriesFrom(ref input, Bug._repeated_tests_codec);
				}
				else
				{
					this.Category = input.ReadString();
				}
				continue;
				IL_035B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400241B RID: 9243
		private static readonly MessageParser<Bug> _parser = new MessageParser<Bug>(() => new Bug());

		// Token: 0x0400241C RID: 9244
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400241D RID: 9245
		private int _hasBits0;

		// Token: 0x0400241E RID: 9246
		public const int WorldSnoFieldNumber = 1;

		// Token: 0x0400241F RID: 9247
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x04002420 RID: 9248
		private int worldSno_;

		// Token: 0x04002421 RID: 9249
		public const int WorldNameFieldNumber = 2;

		// Token: 0x04002422 RID: 9250
		private static readonly string WorldNameDefaultValue = "";

		// Token: 0x04002423 RID: 9251
		private string worldName_;

		// Token: 0x04002424 RID: 9252
		public const int SubzoneSnoFieldNumber = 3;

		// Token: 0x04002425 RID: 9253
		private static readonly int SubzoneSnoDefaultValue = 0;

		// Token: 0x04002426 RID: 9254
		private int subzoneSno_;

		// Token: 0x04002427 RID: 9255
		public const int SubzoneNameFieldNumber = 4;

		// Token: 0x04002428 RID: 9256
		private static readonly string SubzoneNameDefaultValue = "";

		// Token: 0x04002429 RID: 9257
		private string subzoneName_;

		// Token: 0x0400242A RID: 9258
		public const int PlaceXFieldNumber = 5;

		// Token: 0x0400242B RID: 9259
		private static readonly float PlaceXDefaultValue = 0f;

		// Token: 0x0400242C RID: 9260
		private float placeX_;

		// Token: 0x0400242D RID: 9261
		public const int PlaceYFieldNumber = 6;

		// Token: 0x0400242E RID: 9262
		private static readonly float PlaceYDefaultValue = 0f;

		// Token: 0x0400242F RID: 9263
		private float placeY_;

		// Token: 0x04002430 RID: 9264
		public const int PlaceZFieldNumber = 7;

		// Token: 0x04002431 RID: 9265
		private static readonly float PlaceZDefaultValue = 0f;

		// Token: 0x04002432 RID: 9266
		private float placeZ_;

		// Token: 0x04002433 RID: 9267
		public const int SceneSnoFieldNumber = 8;

		// Token: 0x04002434 RID: 9268
		private static readonly int SceneSnoDefaultValue = 0;

		// Token: 0x04002435 RID: 9269
		private int sceneSno_;

		// Token: 0x04002436 RID: 9270
		public const int SceneNameFieldNumber = 9;

		// Token: 0x04002437 RID: 9271
		private static readonly string SceneNameDefaultValue = "";

		// Token: 0x04002438 RID: 9272
		private string sceneName_;

		// Token: 0x04002439 RID: 9273
		public const int ScenePositionXFieldNumber = 10;

		// Token: 0x0400243A RID: 9274
		private static readonly float ScenePositionXDefaultValue = 0f;

		// Token: 0x0400243B RID: 9275
		private float scenePositionX_;

		// Token: 0x0400243C RID: 9276
		public const int ScenePositionYFieldNumber = 11;

		// Token: 0x0400243D RID: 9277
		private static readonly float ScenePositionYDefaultValue = 0f;

		// Token: 0x0400243E RID: 9278
		private float scenePositionY_;

		// Token: 0x0400243F RID: 9279
		public const int ScenePositionZFieldNumber = 12;

		// Token: 0x04002440 RID: 9280
		private static readonly float ScenePositionZDefaultValue = 0f;

		// Token: 0x04002441 RID: 9281
		private float scenePositionZ_;

		// Token: 0x04002442 RID: 9282
		public const int InstanceQuestSnoFieldNumber = 13;

		// Token: 0x04002443 RID: 9283
		private static readonly int InstanceQuestSnoDefaultValue = 0;

		// Token: 0x04002444 RID: 9284
		private int instanceQuestSno_;

		// Token: 0x04002445 RID: 9285
		public const int InstanceQuestNameFieldNumber = 14;

		// Token: 0x04002446 RID: 9286
		private static readonly string InstanceQuestNameDefaultValue = "";

		// Token: 0x04002447 RID: 9287
		private string instanceQuestName_;

		// Token: 0x04002448 RID: 9288
		public const int InstanceQuestPhaseFieldNumber = 15;

		// Token: 0x04002449 RID: 9289
		private static readonly int InstanceQuestPhaseDefaultValue = 0;

		// Token: 0x0400244A RID: 9290
		private int instanceQuestPhase_;

		// Token: 0x0400244B RID: 9291
		public const int DungeonStatesFieldNumber = 16;

		// Token: 0x0400244C RID: 9292
		private static readonly string DungeonStatesDefaultValue = "";

		// Token: 0x0400244D RID: 9293
		private string dungeonStates_;

		// Token: 0x0400244E RID: 9294
		public const int WorldSeedFieldNumber = 17;

		// Token: 0x0400244F RID: 9295
		private static readonly int WorldSeedDefaultValue = 0;

		// Token: 0x04002450 RID: 9296
		private int worldSeed_;

		// Token: 0x04002451 RID: 9297
		public const int DescriptionFieldNumber = 18;

		// Token: 0x04002452 RID: 9298
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04002453 RID: 9299
		private string description_;

		// Token: 0x04002454 RID: 9300
		public const int MetadataFieldNumber = 19;

		// Token: 0x04002455 RID: 9301
		private static readonly string MetadataDefaultValue = "";

		// Token: 0x04002456 RID: 9302
		private string metadata_;

		// Token: 0x04002457 RID: 9303
		public const int LocaleFieldNumber = 20;

		// Token: 0x04002458 RID: 9304
		private static readonly int LocaleDefaultValue = 0;

		// Token: 0x04002459 RID: 9305
		private int locale_;

		// Token: 0x0400245A RID: 9306
		public const int LocaleInfoFieldNumber = 35;

		// Token: 0x0400245B RID: 9307
		private LocaleInfo localeInfo_;

		// Token: 0x0400245C RID: 9308
		public const int BranchFieldNumber = 21;

		// Token: 0x0400245D RID: 9309
		private static readonly string BranchDefaultValue = "";

		// Token: 0x0400245E RID: 9310
		private string branch_;

		// Token: 0x0400245F RID: 9311
		public const int BuildNumberFieldNumber = 22;

		// Token: 0x04002460 RID: 9312
		private static readonly int BuildNumberDefaultValue = 0;

		// Token: 0x04002461 RID: 9313
		private int buildNumber_;

		// Token: 0x04002462 RID: 9314
		public const int BuildVersionCodeDataFieldNumber = 23;

		// Token: 0x04002463 RID: 9315
		private static readonly string BuildVersionCodeDataDefaultValue = "";

		// Token: 0x04002464 RID: 9316
		private string buildVersionCodeData_;

		// Token: 0x04002465 RID: 9317
		public const int ThumbnailJpgDataFieldNumber = 24;

		// Token: 0x04002466 RID: 9318
		private static readonly ByteString ThumbnailJpgDataDefaultValue = ByteString.Empty;

		// Token: 0x04002467 RID: 9319
		private ByteString thumbnailJpgData_;

		// Token: 0x04002468 RID: 9320
		public const int SummaryFieldNumber = 25;

		// Token: 0x04002469 RID: 9321
		private static readonly string SummaryDefaultValue = "";

		// Token: 0x0400246A RID: 9322
		private string summary_;

		// Token: 0x0400246B RID: 9323
		public const int TimestampFieldNumber = 26;

		// Token: 0x0400246C RID: 9324
		private static readonly ulong TimestampDefaultValue = 0UL;

		// Token: 0x0400246D RID: 9325
		private ulong timestamp_;

		// Token: 0x0400246E RID: 9326
		public const int TrackedQuestSnoFieldNumber = 27;

		// Token: 0x0400246F RID: 9327
		private static readonly int TrackedQuestSnoDefaultValue = 0;

		// Token: 0x04002470 RID: 9328
		private int trackedQuestSno_;

		// Token: 0x04002471 RID: 9329
		public const int TrackedQuestNameFieldNumber = 28;

		// Token: 0x04002472 RID: 9330
		private static readonly string TrackedQuestNameDefaultValue = "";

		// Token: 0x04002473 RID: 9331
		private string trackedQuestName_;

		// Token: 0x04002474 RID: 9332
		public const int TrackedQuestPhaseFieldNumber = 29;

		// Token: 0x04002475 RID: 9333
		private static readonly int TrackedQuestPhaseDefaultValue = 0;

		// Token: 0x04002476 RID: 9334
		private int trackedQuestPhase_;

		// Token: 0x04002477 RID: 9335
		public const int OrientationXFieldNumber = 30;

		// Token: 0x04002478 RID: 9336
		private static readonly float OrientationXDefaultValue = 0f;

		// Token: 0x04002479 RID: 9337
		private float orientationX_;

		// Token: 0x0400247A RID: 9338
		public const int OrientationYFieldNumber = 31;

		// Token: 0x0400247B RID: 9339
		private static readonly float OrientationYDefaultValue = 0f;

		// Token: 0x0400247C RID: 9340
		private float orientationY_;

		// Token: 0x0400247D RID: 9341
		public const int OrientationZFieldNumber = 32;

		// Token: 0x0400247E RID: 9342
		private static readonly float OrientationZDefaultValue = 0f;

		// Token: 0x0400247F RID: 9343
		private float orientationZ_;

		// Token: 0x04002480 RID: 9344
		public const int OrientationWFieldNumber = 33;

		// Token: 0x04002481 RID: 9345
		private static readonly float OrientationWDefaultValue = 0f;

		// Token: 0x04002482 RID: 9346
		private float orientationW_;

		// Token: 0x04002483 RID: 9347
		public const int LatencyMsFieldNumber = 34;

		// Token: 0x04002484 RID: 9348
		private static readonly int LatencyMsDefaultValue = 0;

		// Token: 0x04002485 RID: 9349
		private int latencyMs_;

		// Token: 0x04002486 RID: 9350
		public const int PlayerHeroTxtFieldNumber = 36;

		// Token: 0x04002487 RID: 9351
		private static readonly ByteString PlayerHeroTxtDefaultValue = ByteString.Empty;

		// Token: 0x04002488 RID: 9352
		private ByteString playerHeroTxt_;

		// Token: 0x04002489 RID: 9353
		public const int LocalPrefsTxtFieldNumber = 37;

		// Token: 0x0400248A RID: 9354
		private static readonly ByteString LocalPrefsTxtDefaultValue = ByteString.Empty;

		// Token: 0x0400248B RID: 9355
		private ByteString localPrefsTxt_;

		// Token: 0x0400248C RID: 9356
		public const int LastScrollUsedFieldNumber = 38;

		// Token: 0x0400248D RID: 9357
		private static readonly string LastScrollUsedDefaultValue = "";

		// Token: 0x0400248E RID: 9358
		private string lastScrollUsed_;

		// Token: 0x0400248F RID: 9359
		public const int LastCutscenePlayedSnoFieldNumber = 39;

		// Token: 0x04002490 RID: 9360
		private static readonly int LastCutscenePlayedSnoDefaultValue = 0;

		// Token: 0x04002491 RID: 9361
		private int lastCutscenePlayedSno_;

		// Token: 0x04002492 RID: 9362
		public const int LastCutscenePlayedNameFieldNumber = 40;

		// Token: 0x04002493 RID: 9363
		private static readonly string LastCutscenePlayedNameDefaultValue = "";

		// Token: 0x04002494 RID: 9364
		private string lastCutscenePlayedName_;

		// Token: 0x04002495 RID: 9365
		public const int LastCompletedQuestPhaseInfoFieldNumber = 41;

		// Token: 0x04002496 RID: 9366
		private static readonly string LastCompletedQuestPhaseInfoDefaultValue = "";

		// Token: 0x04002497 RID: 9367
		private string lastCompletedQuestPhaseInfo_;

		// Token: 0x04002498 RID: 9368
		public const int InstanceTypeFieldNumber = 42;

		// Token: 0x04002499 RID: 9369
		private static readonly string InstanceTypeDefaultValue = "";

		// Token: 0x0400249A RID: 9370
		private string instanceType_;

		// Token: 0x0400249B RID: 9371
		public const int NightmareDungeonInfoFieldNumber = 43;

		// Token: 0x0400249C RID: 9372
		private static readonly string NightmareDungeonInfoDefaultValue = "";

		// Token: 0x0400249D RID: 9373
		private string nightmareDungeonInfo_;

		// Token: 0x0400249E RID: 9374
		public const int LastCompletedEventSnoFieldNumber = 44;

		// Token: 0x0400249F RID: 9375
		private static readonly int LastCompletedEventSnoDefaultValue = 0;

		// Token: 0x040024A0 RID: 9376
		private int lastCompletedEventSno_;

		// Token: 0x040024A1 RID: 9377
		public const int LastCompletedEventNameFieldNumber = 45;

		// Token: 0x040024A2 RID: 9378
		private static readonly string LastCompletedEventNameDefaultValue = "";

		// Token: 0x040024A3 RID: 9379
		private string lastCompletedEventName_;

		// Token: 0x040024A4 RID: 9380
		public const int LastCompletedEventNumParticipantsFieldNumber = 46;

		// Token: 0x040024A5 RID: 9381
		private static readonly int LastCompletedEventNumParticipantsDefaultValue = 0;

		// Token: 0x040024A6 RID: 9382
		private int lastCompletedEventNumParticipants_;

		// Token: 0x040024A7 RID: 9383
		public const int NumLocalPartyPlayersFieldNumber = 47;

		// Token: 0x040024A8 RID: 9384
		private static readonly int NumLocalPartyPlayersDefaultValue = 0;

		// Token: 0x040024A9 RID: 9385
		private int numLocalPartyPlayers_;

		// Token: 0x040024AA RID: 9386
		public const int NumOnlinePartyPlayersFieldNumber = 48;

		// Token: 0x040024AB RID: 9387
		private static readonly int NumOnlinePartyPlayersDefaultValue = 0;

		// Token: 0x040024AC RID: 9388
		private int numOnlinePartyPlayers_;

		// Token: 0x040024AD RID: 9389
		public const int ClientSurroundingsInfoTxtFieldNumber = 49;

		// Token: 0x040024AE RID: 9390
		private static readonly ByteString ClientSurroundingsInfoTxtDefaultValue = ByteString.Empty;

		// Token: 0x040024AF RID: 9391
		private ByteString clientSurroundingsInfoTxt_;

		// Token: 0x040024B0 RID: 9392
		public const int LastUsedWaypointInfoFieldNumber = 50;

		// Token: 0x040024B1 RID: 9393
		private static readonly string LastUsedWaypointInfoDefaultValue = "";

		// Token: 0x040024B2 RID: 9394
		private string lastUsedWaypointInfo_;

		// Token: 0x040024B3 RID: 9395
		public const int ConcerningContentGroupsFieldNumber = 51;

		// Token: 0x040024B4 RID: 9396
		private static readonly string ConcerningContentGroupsDefaultValue = "";

		// Token: 0x040024B5 RID: 9397
		private string concerningContentGroups_;

		// Token: 0x040024B6 RID: 9398
		public const int CategoryFieldNumber = 52;

		// Token: 0x040024B7 RID: 9399
		private static readonly string CategoryDefaultValue = "";

		// Token: 0x040024B8 RID: 9400
		private string category_;

		// Token: 0x040024B9 RID: 9401
		public const int TestsFieldNumber = 53;

		// Token: 0x040024BA RID: 9402
		private static readonly FieldCodec<ABTestingInfo> _repeated_tests_codec = FieldCodec.ForMessage<ABTestingInfo>(426U, ABTestingInfo.Parser);

		// Token: 0x040024BB RID: 9403
		private readonly RepeatedField<ABTestingInfo> tests_ = new RepeatedField<ABTestingInfo>();
	}
}
