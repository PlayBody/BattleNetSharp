using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000304 RID: 772
	public sealed class ClientPerf : IMessage<ClientPerf>, IMessage, IEquatable<ClientPerf>, IDeepCloneable<ClientPerf>, IBufferMessage
	{
		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x00139FFC File Offset: 0x001381FC
		[DebuggerNonUserCode]
		public static MessageParser<ClientPerf> Parser
		{
			get
			{
				return ClientPerf._parser;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x0013A014 File Offset: 0x00138214
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientPerfReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x0013A038 File Offset: 0x00138238
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientPerf.Descriptor;
			}
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0013A04F File Offset: 0x0013824F
		[DebuggerNonUserCode]
		public ClientPerf()
		{
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0013A05C File Offset: 0x0013825C
		[DebuggerNonUserCode]
		public ClientPerf(ClientPerf other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this._hasBits1 = other._hasBits1;
			this.worldSno_ = other.worldSno_;
			this.worldName_ = other.worldName_;
			this.sceneSno_ = other.sceneSno_;
			this.sceneName_ = other.sceneName_;
			this.gridX_ = other.gridX_;
			this.gridY_ = other.gridY_;
			this.averageDelta_ = other.averageDelta_;
			this.maxDelta_ = other.maxDelta_;
			this.averageMonster_ = other.averageMonster_;
			this.maxMonster_ = other.maxMonster_;
			this.averagePet_ = other.averagePet_;
			this.maxPet_ = other.maxPet_;
			this.averagePlayer_ = other.averagePlayer_;
			this.maxPlayer_ = other.maxPlayer_;
			this.averageActor_ = other.averageActor_;
			this.maxActor_ = other.maxActor_;
			this.averageParticle_ = other.averageParticle_;
			this.maxParticle_ = other.maxParticle_;
			this.averageParticleSystem_ = other.averageParticleSystem_;
			this.maxParticleSystem_ = other.maxParticleSystem_;
			this.averageVisibleMonster_ = other.averageVisibleMonster_;
			this.maxVisibleMonster_ = other.maxVisibleMonster_;
			this.averageVisiblePet_ = other.averageVisiblePet_;
			this.maxVisiblePet_ = other.maxVisiblePet_;
			this.averageVisiblePlayer_ = other.averageVisiblePlayer_;
			this.maxVisiblePlayer_ = other.maxVisiblePlayer_;
			this.averageVisibleActor_ = other.averageVisibleActor_;
			this.maxVisibleActor_ = other.maxVisibleActor_;
			this.averageVisibleParticle_ = other.averageVisibleParticle_;
			this.maxVisibleParticle_ = other.maxVisibleParticle_;
			this.averageVisibleParticleSystem_ = other.averageVisibleParticleSystem_;
			this.maxVisibleParticleSystem_ = other.maxVisibleParticleSystem_;
			this.maxCpuCacheRequiredSize_ = other.maxCpuCacheRequiredSize_;
			this.maxGpuCacheRequiredSize_ = other.maxGpuCacheRequiredSize_;
			this.maxMainHeapUsedSize_ = other.maxMainHeapUsedSize_;
			this.maxSmallHeapUsedSize_ = other.maxSmallHeapUsedSize_;
			this.averageResolutionScale_ = other.averageResolutionScale_;
			this.minimumResolutionScale_ = other.minimumResolutionScale_;
			this.hwClass_ = other.hwClass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x0013A270 File Offset: 0x00138470
		[DebuggerNonUserCode]
		public ClientPerf Clone()
		{
			return new ClientPerf(this);
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x0013A288 File Offset: 0x00138488
		// (set) Token: 0x0600517D RID: 20861 RVA: 0x0013A2B9 File Offset: 0x001384B9
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
					worldSnoDefaultValue = ClientPerf.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x0013A2D4 File Offset: 0x001384D4
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0013A2F1 File Offset: 0x001384F1
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x0013A304 File Offset: 0x00138504
		// (set) Token: 0x06005181 RID: 20865 RVA: 0x0013A325 File Offset: 0x00138525
		[DebuggerNonUserCode]
		public string WorldName
		{
			get
			{
				return this.worldName_ ?? ClientPerf.WorldNameDefaultValue;
			}
			set
			{
				this.worldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x0013A33C File Offset: 0x0013853C
		[DebuggerNonUserCode]
		public bool HasWorldName
		{
			get
			{
				return this.worldName_ != null;
			}
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0013A357 File Offset: 0x00138557
		[DebuggerNonUserCode]
		public void ClearWorldName()
		{
			this.worldName_ = null;
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x0013A364 File Offset: 0x00138564
		// (set) Token: 0x06005185 RID: 20869 RVA: 0x0013A395 File Offset: 0x00138595
		[DebuggerNonUserCode]
		public int SceneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int sceneSnoDefaultValue;
				if (flag)
				{
					sceneSnoDefaultValue = this.sceneSno_;
				}
				else
				{
					sceneSnoDefaultValue = ClientPerf.SceneSnoDefaultValue;
				}
				return sceneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.sceneSno_ = value;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x0013A3B0 File Offset: 0x001385B0
		[DebuggerNonUserCode]
		public bool HasSceneSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0013A3CD File Offset: 0x001385CD
		[DebuggerNonUserCode]
		public void ClearSceneSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x0013A3E0 File Offset: 0x001385E0
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x0013A401 File Offset: 0x00138601
		[DebuggerNonUserCode]
		public string SceneName
		{
			get
			{
				return this.sceneName_ ?? ClientPerf.SceneNameDefaultValue;
			}
			set
			{
				this.sceneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x0013A418 File Offset: 0x00138618
		[DebuggerNonUserCode]
		public bool HasSceneName
		{
			get
			{
				return this.sceneName_ != null;
			}
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0013A433 File Offset: 0x00138633
		[DebuggerNonUserCode]
		public void ClearSceneName()
		{
			this.sceneName_ = null;
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x0013A440 File Offset: 0x00138640
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x0013A471 File Offset: 0x00138671
		[DebuggerNonUserCode]
		public int GridX
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int gridXDefaultValue;
				if (flag)
				{
					gridXDefaultValue = this.gridX_;
				}
				else
				{
					gridXDefaultValue = ClientPerf.GridXDefaultValue;
				}
				return gridXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gridX_ = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x0013A48C File Offset: 0x0013868C
		[DebuggerNonUserCode]
		public bool HasGridX
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x0013A4A9 File Offset: 0x001386A9
		[DebuggerNonUserCode]
		public void ClearGridX()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x0013A4BC File Offset: 0x001386BC
		// (set) Token: 0x06005191 RID: 20881 RVA: 0x0013A4ED File Offset: 0x001386ED
		[DebuggerNonUserCode]
		public int GridY
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int gridYDefaultValue;
				if (flag)
				{
					gridYDefaultValue = this.gridY_;
				}
				else
				{
					gridYDefaultValue = ClientPerf.GridYDefaultValue;
				}
				return gridYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gridY_ = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x0013A508 File Offset: 0x00138708
		[DebuggerNonUserCode]
		public bool HasGridY
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x0013A525 File Offset: 0x00138725
		[DebuggerNonUserCode]
		public void ClearGridY()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x0013A538 File Offset: 0x00138738
		// (set) Token: 0x06005195 RID: 20885 RVA: 0x0013A56A File Offset: 0x0013876A
		[DebuggerNonUserCode]
		public float AverageDelta
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float averageDeltaDefaultValue;
				if (flag)
				{
					averageDeltaDefaultValue = this.averageDelta_;
				}
				else
				{
					averageDeltaDefaultValue = ClientPerf.AverageDeltaDefaultValue;
				}
				return averageDeltaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.averageDelta_ = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x0013A584 File Offset: 0x00138784
		[DebuggerNonUserCode]
		public bool HasAverageDelta
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0013A5A2 File Offset: 0x001387A2
		[DebuggerNonUserCode]
		public void ClearAverageDelta()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x0013A5B4 File Offset: 0x001387B4
		// (set) Token: 0x06005199 RID: 20889 RVA: 0x0013A5E6 File Offset: 0x001387E6
		[DebuggerNonUserCode]
		public float MaxDelta
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				float maxDeltaDefaultValue;
				if (flag)
				{
					maxDeltaDefaultValue = this.maxDelta_;
				}
				else
				{
					maxDeltaDefaultValue = ClientPerf.MaxDeltaDefaultValue;
				}
				return maxDeltaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.maxDelta_ = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x0013A600 File Offset: 0x00138800
		[DebuggerNonUserCode]
		public bool HasMaxDelta
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0013A61E File Offset: 0x0013881E
		[DebuggerNonUserCode]
		public void ClearMaxDelta()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x0013A630 File Offset: 0x00138830
		// (set) Token: 0x0600519D RID: 20893 RVA: 0x0013A662 File Offset: 0x00138862
		[DebuggerNonUserCode]
		public float AverageMonster
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				float averageMonsterDefaultValue;
				if (flag)
				{
					averageMonsterDefaultValue = this.averageMonster_;
				}
				else
				{
					averageMonsterDefaultValue = ClientPerf.AverageMonsterDefaultValue;
				}
				return averageMonsterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.averageMonster_ = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x0013A67C File Offset: 0x0013887C
		[DebuggerNonUserCode]
		public bool HasAverageMonster
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0013A69A File Offset: 0x0013889A
		[DebuggerNonUserCode]
		public void ClearAverageMonster()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x0013A6AC File Offset: 0x001388AC
		// (set) Token: 0x060051A1 RID: 20897 RVA: 0x0013A6E1 File Offset: 0x001388E1
		[DebuggerNonUserCode]
		public float MaxMonster
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				float maxMonsterDefaultValue;
				if (flag)
				{
					maxMonsterDefaultValue = this.maxMonster_;
				}
				else
				{
					maxMonsterDefaultValue = ClientPerf.MaxMonsterDefaultValue;
				}
				return maxMonsterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.maxMonster_ = value;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x0013A700 File Offset: 0x00138900
		[DebuggerNonUserCode]
		public bool HasMaxMonster
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0013A721 File Offset: 0x00138921
		[DebuggerNonUserCode]
		public void ClearMaxMonster()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x0013A738 File Offset: 0x00138938
		// (set) Token: 0x060051A5 RID: 20901 RVA: 0x0013A76D File Offset: 0x0013896D
		[DebuggerNonUserCode]
		public float AveragePet
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				float averagePetDefaultValue;
				if (flag)
				{
					averagePetDefaultValue = this.averagePet_;
				}
				else
				{
					averagePetDefaultValue = ClientPerf.AveragePetDefaultValue;
				}
				return averagePetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.averagePet_ = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x0013A78C File Offset: 0x0013898C
		[DebuggerNonUserCode]
		public bool HasAveragePet
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0013A7AD File Offset: 0x001389AD
		[DebuggerNonUserCode]
		public void ClearAveragePet()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x0013A7C4 File Offset: 0x001389C4
		// (set) Token: 0x060051A9 RID: 20905 RVA: 0x0013A7F9 File Offset: 0x001389F9
		[DebuggerNonUserCode]
		public float MaxPet
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				float maxPetDefaultValue;
				if (flag)
				{
					maxPetDefaultValue = this.maxPet_;
				}
				else
				{
					maxPetDefaultValue = ClientPerf.MaxPetDefaultValue;
				}
				return maxPetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.maxPet_ = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x0013A818 File Offset: 0x00138A18
		[DebuggerNonUserCode]
		public bool HasMaxPet
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x0013A839 File Offset: 0x00138A39
		[DebuggerNonUserCode]
		public void ClearMaxPet()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x0013A850 File Offset: 0x00138A50
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x0013A885 File Offset: 0x00138A85
		[DebuggerNonUserCode]
		public float AveragePlayer
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				float averagePlayerDefaultValue;
				if (flag)
				{
					averagePlayerDefaultValue = this.averagePlayer_;
				}
				else
				{
					averagePlayerDefaultValue = ClientPerf.AveragePlayerDefaultValue;
				}
				return averagePlayerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.averagePlayer_ = value;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x0013A8A4 File Offset: 0x00138AA4
		[DebuggerNonUserCode]
		public bool HasAveragePlayer
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x0013A8C5 File Offset: 0x00138AC5
		[DebuggerNonUserCode]
		public void ClearAveragePlayer()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0013A8DC File Offset: 0x00138ADC
		// (set) Token: 0x060051B1 RID: 20913 RVA: 0x0013A911 File Offset: 0x00138B11
		[DebuggerNonUserCode]
		public float MaxPlayer
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				float maxPlayerDefaultValue;
				if (flag)
				{
					maxPlayerDefaultValue = this.maxPlayer_;
				}
				else
				{
					maxPlayerDefaultValue = ClientPerf.MaxPlayerDefaultValue;
				}
				return maxPlayerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.maxPlayer_ = value;
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x0013A930 File Offset: 0x00138B30
		[DebuggerNonUserCode]
		public bool HasMaxPlayer
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x0013A951 File Offset: 0x00138B51
		[DebuggerNonUserCode]
		public void ClearMaxPlayer()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x0013A968 File Offset: 0x00138B68
		// (set) Token: 0x060051B5 RID: 20917 RVA: 0x0013A99D File Offset: 0x00138B9D
		[DebuggerNonUserCode]
		public float AverageActor
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				float averageActorDefaultValue;
				if (flag)
				{
					averageActorDefaultValue = this.averageActor_;
				}
				else
				{
					averageActorDefaultValue = ClientPerf.AverageActorDefaultValue;
				}
				return averageActorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.averageActor_ = value;
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x0013A9BC File Offset: 0x00138BBC
		[DebuggerNonUserCode]
		public bool HasAverageActor
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x0013A9DD File Offset: 0x00138BDD
		[DebuggerNonUserCode]
		public void ClearAverageActor()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x0013A9F4 File Offset: 0x00138BF4
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x0013AA29 File Offset: 0x00138C29
		[DebuggerNonUserCode]
		public float MaxActor
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				float maxActorDefaultValue;
				if (flag)
				{
					maxActorDefaultValue = this.maxActor_;
				}
				else
				{
					maxActorDefaultValue = ClientPerf.MaxActorDefaultValue;
				}
				return maxActorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.maxActor_ = value;
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x0013AA48 File Offset: 0x00138C48
		[DebuggerNonUserCode]
		public bool HasMaxActor
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x0013AA69 File Offset: 0x00138C69
		[DebuggerNonUserCode]
		public void ClearMaxActor()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x0013AA80 File Offset: 0x00138C80
		// (set) Token: 0x060051BD RID: 20925 RVA: 0x0013AAB5 File Offset: 0x00138CB5
		[DebuggerNonUserCode]
		public float AverageParticle
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				float averageParticleDefaultValue;
				if (flag)
				{
					averageParticleDefaultValue = this.averageParticle_;
				}
				else
				{
					averageParticleDefaultValue = ClientPerf.AverageParticleDefaultValue;
				}
				return averageParticleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.averageParticle_ = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x0013AAD4 File Offset: 0x00138CD4
		[DebuggerNonUserCode]
		public bool HasAverageParticle
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x0013AAF5 File Offset: 0x00138CF5
		[DebuggerNonUserCode]
		public void ClearAverageParticle()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x0013AB0C File Offset: 0x00138D0C
		// (set) Token: 0x060051C1 RID: 20929 RVA: 0x0013AB41 File Offset: 0x00138D41
		[DebuggerNonUserCode]
		public float MaxParticle
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				float maxParticleDefaultValue;
				if (flag)
				{
					maxParticleDefaultValue = this.maxParticle_;
				}
				else
				{
					maxParticleDefaultValue = ClientPerf.MaxParticleDefaultValue;
				}
				return maxParticleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.maxParticle_ = value;
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x0013AB60 File Offset: 0x00138D60
		[DebuggerNonUserCode]
		public bool HasMaxParticle
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x0013AB81 File Offset: 0x00138D81
		[DebuggerNonUserCode]
		public void ClearMaxParticle()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x0013AB98 File Offset: 0x00138D98
		// (set) Token: 0x060051C5 RID: 20933 RVA: 0x0013ABCD File Offset: 0x00138DCD
		[DebuggerNonUserCode]
		public float AverageParticleSystem
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				float averageParticleSystemDefaultValue;
				if (flag)
				{
					averageParticleSystemDefaultValue = this.averageParticleSystem_;
				}
				else
				{
					averageParticleSystemDefaultValue = ClientPerf.AverageParticleSystemDefaultValue;
				}
				return averageParticleSystemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.averageParticleSystem_ = value;
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x0013ABEC File Offset: 0x00138DEC
		[DebuggerNonUserCode]
		public bool HasAverageParticleSystem
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x0013AC0D File Offset: 0x00138E0D
		[DebuggerNonUserCode]
		public void ClearAverageParticleSystem()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0013AC24 File Offset: 0x00138E24
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0013AC59 File Offset: 0x00138E59
		[DebuggerNonUserCode]
		public float MaxParticleSystem
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				float maxParticleSystemDefaultValue;
				if (flag)
				{
					maxParticleSystemDefaultValue = this.maxParticleSystem_;
				}
				else
				{
					maxParticleSystemDefaultValue = ClientPerf.MaxParticleSystemDefaultValue;
				}
				return maxParticleSystemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.maxParticleSystem_ = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x0013AC78 File Offset: 0x00138E78
		[DebuggerNonUserCode]
		public bool HasMaxParticleSystem
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x0013AC99 File Offset: 0x00138E99
		[DebuggerNonUserCode]
		public void ClearMaxParticleSystem()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x0013ACB0 File Offset: 0x00138EB0
		// (set) Token: 0x060051CD RID: 20941 RVA: 0x0013ACE5 File Offset: 0x00138EE5
		[DebuggerNonUserCode]
		public float AverageVisibleMonster
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				float averageVisibleMonsterDefaultValue;
				if (flag)
				{
					averageVisibleMonsterDefaultValue = this.averageVisibleMonster_;
				}
				else
				{
					averageVisibleMonsterDefaultValue = ClientPerf.AverageVisibleMonsterDefaultValue;
				}
				return averageVisibleMonsterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.averageVisibleMonster_ = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x0013AD04 File Offset: 0x00138F04
		[DebuggerNonUserCode]
		public bool HasAverageVisibleMonster
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0013AD25 File Offset: 0x00138F25
		[DebuggerNonUserCode]
		public void ClearAverageVisibleMonster()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x0013AD3C File Offset: 0x00138F3C
		// (set) Token: 0x060051D1 RID: 20945 RVA: 0x0013AD71 File Offset: 0x00138F71
		[DebuggerNonUserCode]
		public float MaxVisibleMonster
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				float maxVisibleMonsterDefaultValue;
				if (flag)
				{
					maxVisibleMonsterDefaultValue = this.maxVisibleMonster_;
				}
				else
				{
					maxVisibleMonsterDefaultValue = ClientPerf.MaxVisibleMonsterDefaultValue;
				}
				return maxVisibleMonsterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.maxVisibleMonster_ = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x0013AD90 File Offset: 0x00138F90
		[DebuggerNonUserCode]
		public bool HasMaxVisibleMonster
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0013ADB1 File Offset: 0x00138FB1
		[DebuggerNonUserCode]
		public void ClearMaxVisibleMonster()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x0013ADC8 File Offset: 0x00138FC8
		// (set) Token: 0x060051D5 RID: 20949 RVA: 0x0013ADFD File Offset: 0x00138FFD
		[DebuggerNonUserCode]
		public float AverageVisiblePet
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				float averageVisiblePetDefaultValue;
				if (flag)
				{
					averageVisiblePetDefaultValue = this.averageVisiblePet_;
				}
				else
				{
					averageVisiblePetDefaultValue = ClientPerf.AverageVisiblePetDefaultValue;
				}
				return averageVisiblePetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.averageVisiblePet_ = value;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x0013AE1C File Offset: 0x0013901C
		[DebuggerNonUserCode]
		public bool HasAverageVisiblePet
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0013AE3D File Offset: 0x0013903D
		[DebuggerNonUserCode]
		public void ClearAverageVisiblePet()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x0013AE54 File Offset: 0x00139054
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x0013AE89 File Offset: 0x00139089
		[DebuggerNonUserCode]
		public float MaxVisiblePet
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				float maxVisiblePetDefaultValue;
				if (flag)
				{
					maxVisiblePetDefaultValue = this.maxVisiblePet_;
				}
				else
				{
					maxVisiblePetDefaultValue = ClientPerf.MaxVisiblePetDefaultValue;
				}
				return maxVisiblePetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.maxVisiblePet_ = value;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x0013AEA8 File Offset: 0x001390A8
		[DebuggerNonUserCode]
		public bool HasMaxVisiblePet
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x0013AEC9 File Offset: 0x001390C9
		[DebuggerNonUserCode]
		public void ClearMaxVisiblePet()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x0013AEE0 File Offset: 0x001390E0
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x0013AF15 File Offset: 0x00139115
		[DebuggerNonUserCode]
		public float AverageVisiblePlayer
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				float averageVisiblePlayerDefaultValue;
				if (flag)
				{
					averageVisiblePlayerDefaultValue = this.averageVisiblePlayer_;
				}
				else
				{
					averageVisiblePlayerDefaultValue = ClientPerf.AverageVisiblePlayerDefaultValue;
				}
				return averageVisiblePlayerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.averageVisiblePlayer_ = value;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x0013AF34 File Offset: 0x00139134
		[DebuggerNonUserCode]
		public bool HasAverageVisiblePlayer
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x0013AF55 File Offset: 0x00139155
		[DebuggerNonUserCode]
		public void ClearAverageVisiblePlayer()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x0013AF6C File Offset: 0x0013916C
		// (set) Token: 0x060051E1 RID: 20961 RVA: 0x0013AFA1 File Offset: 0x001391A1
		[DebuggerNonUserCode]
		public float MaxVisiblePlayer
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				float maxVisiblePlayerDefaultValue;
				if (flag)
				{
					maxVisiblePlayerDefaultValue = this.maxVisiblePlayer_;
				}
				else
				{
					maxVisiblePlayerDefaultValue = ClientPerf.MaxVisiblePlayerDefaultValue;
				}
				return maxVisiblePlayerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.maxVisiblePlayer_ = value;
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x0013AFC0 File Offset: 0x001391C0
		[DebuggerNonUserCode]
		public bool HasMaxVisiblePlayer
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x0013AFE1 File Offset: 0x001391E1
		[DebuggerNonUserCode]
		public void ClearMaxVisiblePlayer()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x0013AFF8 File Offset: 0x001391F8
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0013B02D File Offset: 0x0013922D
		[DebuggerNonUserCode]
		public float AverageVisibleActor
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				float averageVisibleActorDefaultValue;
				if (flag)
				{
					averageVisibleActorDefaultValue = this.averageVisibleActor_;
				}
				else
				{
					averageVisibleActorDefaultValue = ClientPerf.AverageVisibleActorDefaultValue;
				}
				return averageVisibleActorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.averageVisibleActor_ = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x0013B04C File Offset: 0x0013924C
		[DebuggerNonUserCode]
		public bool HasAverageVisibleActor
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x0013B06D File Offset: 0x0013926D
		[DebuggerNonUserCode]
		public void ClearAverageVisibleActor()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x0013B084 File Offset: 0x00139284
		// (set) Token: 0x060051E9 RID: 20969 RVA: 0x0013B0B9 File Offset: 0x001392B9
		[DebuggerNonUserCode]
		public float MaxVisibleActor
		{
			get
			{
				bool flag = (this._hasBits0 & 33554432) != 0;
				float maxVisibleActorDefaultValue;
				if (flag)
				{
					maxVisibleActorDefaultValue = this.maxVisibleActor_;
				}
				else
				{
					maxVisibleActorDefaultValue = ClientPerf.MaxVisibleActorDefaultValue;
				}
				return maxVisibleActorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 33554432;
				this.maxVisibleActor_ = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x0013B0D8 File Offset: 0x001392D8
		[DebuggerNonUserCode]
		public bool HasMaxVisibleActor
		{
			get
			{
				return (this._hasBits0 & 33554432) != 0;
			}
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x0013B0F9 File Offset: 0x001392F9
		[DebuggerNonUserCode]
		public void ClearMaxVisibleActor()
		{
			this._hasBits0 &= -33554433;
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x0013B110 File Offset: 0x00139310
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x0013B145 File Offset: 0x00139345
		[DebuggerNonUserCode]
		public float AverageVisibleParticle
		{
			get
			{
				bool flag = (this._hasBits0 & 67108864) != 0;
				float averageVisibleParticleDefaultValue;
				if (flag)
				{
					averageVisibleParticleDefaultValue = this.averageVisibleParticle_;
				}
				else
				{
					averageVisibleParticleDefaultValue = ClientPerf.AverageVisibleParticleDefaultValue;
				}
				return averageVisibleParticleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 67108864;
				this.averageVisibleParticle_ = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x0013B164 File Offset: 0x00139364
		[DebuggerNonUserCode]
		public bool HasAverageVisibleParticle
		{
			get
			{
				return (this._hasBits0 & 67108864) != 0;
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x0013B185 File Offset: 0x00139385
		[DebuggerNonUserCode]
		public void ClearAverageVisibleParticle()
		{
			this._hasBits0 &= -67108865;
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x0013B19C File Offset: 0x0013939C
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x0013B1D1 File Offset: 0x001393D1
		[DebuggerNonUserCode]
		public float MaxVisibleParticle
		{
			get
			{
				bool flag = (this._hasBits0 & 134217728) != 0;
				float maxVisibleParticleDefaultValue;
				if (flag)
				{
					maxVisibleParticleDefaultValue = this.maxVisibleParticle_;
				}
				else
				{
					maxVisibleParticleDefaultValue = ClientPerf.MaxVisibleParticleDefaultValue;
				}
				return maxVisibleParticleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 134217728;
				this.maxVisibleParticle_ = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x0013B1F0 File Offset: 0x001393F0
		[DebuggerNonUserCode]
		public bool HasMaxVisibleParticle
		{
			get
			{
				return (this._hasBits0 & 134217728) != 0;
			}
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x0013B211 File Offset: 0x00139411
		[DebuggerNonUserCode]
		public void ClearMaxVisibleParticle()
		{
			this._hasBits0 &= -134217729;
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x0013B228 File Offset: 0x00139428
		// (set) Token: 0x060051F5 RID: 20981 RVA: 0x0013B25D File Offset: 0x0013945D
		[DebuggerNonUserCode]
		public float AverageVisibleParticleSystem
		{
			get
			{
				bool flag = (this._hasBits0 & 268435456) != 0;
				float averageVisibleParticleSystemDefaultValue;
				if (flag)
				{
					averageVisibleParticleSystemDefaultValue = this.averageVisibleParticleSystem_;
				}
				else
				{
					averageVisibleParticleSystemDefaultValue = ClientPerf.AverageVisibleParticleSystemDefaultValue;
				}
				return averageVisibleParticleSystemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 268435456;
				this.averageVisibleParticleSystem_ = value;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x0013B27C File Offset: 0x0013947C
		[DebuggerNonUserCode]
		public bool HasAverageVisibleParticleSystem
		{
			get
			{
				return (this._hasBits0 & 268435456) != 0;
			}
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x0013B29D File Offset: 0x0013949D
		[DebuggerNonUserCode]
		public void ClearAverageVisibleParticleSystem()
		{
			this._hasBits0 &= -268435457;
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x0013B2B4 File Offset: 0x001394B4
		// (set) Token: 0x060051F9 RID: 20985 RVA: 0x0013B2E9 File Offset: 0x001394E9
		[DebuggerNonUserCode]
		public float MaxVisibleParticleSystem
		{
			get
			{
				bool flag = (this._hasBits0 & 536870912) != 0;
				float maxVisibleParticleSystemDefaultValue;
				if (flag)
				{
					maxVisibleParticleSystemDefaultValue = this.maxVisibleParticleSystem_;
				}
				else
				{
					maxVisibleParticleSystemDefaultValue = ClientPerf.MaxVisibleParticleSystemDefaultValue;
				}
				return maxVisibleParticleSystemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 536870912;
				this.maxVisibleParticleSystem_ = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x0013B308 File Offset: 0x00139508
		[DebuggerNonUserCode]
		public bool HasMaxVisibleParticleSystem
		{
			get
			{
				return (this._hasBits0 & 536870912) != 0;
			}
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x0013B329 File Offset: 0x00139529
		[DebuggerNonUserCode]
		public void ClearMaxVisibleParticleSystem()
		{
			this._hasBits0 &= -536870913;
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x0013B340 File Offset: 0x00139540
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x0013B375 File Offset: 0x00139575
		[DebuggerNonUserCode]
		public long MaxCpuCacheRequiredSize
		{
			get
			{
				bool flag = (this._hasBits0 & 1073741824) != 0;
				long maxCpuCacheRequiredSizeDefaultValue;
				if (flag)
				{
					maxCpuCacheRequiredSizeDefaultValue = this.maxCpuCacheRequiredSize_;
				}
				else
				{
					maxCpuCacheRequiredSizeDefaultValue = ClientPerf.MaxCpuCacheRequiredSizeDefaultValue;
				}
				return maxCpuCacheRequiredSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1073741824;
				this.maxCpuCacheRequiredSize_ = value;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x0013B394 File Offset: 0x00139594
		[DebuggerNonUserCode]
		public bool HasMaxCpuCacheRequiredSize
		{
			get
			{
				return (this._hasBits0 & 1073741824) != 0;
			}
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x0013B3B5 File Offset: 0x001395B5
		[DebuggerNonUserCode]
		public void ClearMaxCpuCacheRequiredSize()
		{
			this._hasBits0 &= -1073741825;
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x0013B3CC File Offset: 0x001395CC
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x0013B401 File Offset: 0x00139601
		[DebuggerNonUserCode]
		public long MaxGpuCacheRequiredSize
		{
			get
			{
				bool flag = (this._hasBits0 & int.MinValue) != 0;
				long maxGpuCacheRequiredSizeDefaultValue;
				if (flag)
				{
					maxGpuCacheRequiredSizeDefaultValue = this.maxGpuCacheRequiredSize_;
				}
				else
				{
					maxGpuCacheRequiredSizeDefaultValue = ClientPerf.MaxGpuCacheRequiredSizeDefaultValue;
				}
				return maxGpuCacheRequiredSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= int.MinValue;
				this.maxGpuCacheRequiredSize_ = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x0013B420 File Offset: 0x00139620
		[DebuggerNonUserCode]
		public bool HasMaxGpuCacheRequiredSize
		{
			get
			{
				return (this._hasBits0 & int.MinValue) != 0;
			}
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x0013B441 File Offset: 0x00139641
		[DebuggerNonUserCode]
		public void ClearMaxGpuCacheRequiredSize()
		{
			this._hasBits0 &= int.MaxValue;
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x0013B458 File Offset: 0x00139658
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x0013B489 File Offset: 0x00139689
		[DebuggerNonUserCode]
		public long MaxMainHeapUsedSize
		{
			get
			{
				bool flag = (this._hasBits1 & 1) != 0;
				long maxMainHeapUsedSizeDefaultValue;
				if (flag)
				{
					maxMainHeapUsedSizeDefaultValue = this.maxMainHeapUsedSize_;
				}
				else
				{
					maxMainHeapUsedSizeDefaultValue = ClientPerf.MaxMainHeapUsedSizeDefaultValue;
				}
				return maxMainHeapUsedSizeDefaultValue;
			}
			set
			{
				this._hasBits1 |= 1;
				this.maxMainHeapUsedSize_ = value;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x0013B4A4 File Offset: 0x001396A4
		[DebuggerNonUserCode]
		public bool HasMaxMainHeapUsedSize
		{
			get
			{
				return (this._hasBits1 & 1) != 0;
			}
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x0013B4C1 File Offset: 0x001396C1
		[DebuggerNonUserCode]
		public void ClearMaxMainHeapUsedSize()
		{
			this._hasBits1 &= -2;
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x0013B4D4 File Offset: 0x001396D4
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x0013B505 File Offset: 0x00139705
		[DebuggerNonUserCode]
		public long MaxSmallHeapUsedSize
		{
			get
			{
				bool flag = (this._hasBits1 & 2) != 0;
				long maxSmallHeapUsedSizeDefaultValue;
				if (flag)
				{
					maxSmallHeapUsedSizeDefaultValue = this.maxSmallHeapUsedSize_;
				}
				else
				{
					maxSmallHeapUsedSizeDefaultValue = ClientPerf.MaxSmallHeapUsedSizeDefaultValue;
				}
				return maxSmallHeapUsedSizeDefaultValue;
			}
			set
			{
				this._hasBits1 |= 2;
				this.maxSmallHeapUsedSize_ = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x0013B520 File Offset: 0x00139720
		[DebuggerNonUserCode]
		public bool HasMaxSmallHeapUsedSize
		{
			get
			{
				return (this._hasBits1 & 2) != 0;
			}
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x0013B53D File Offset: 0x0013973D
		[DebuggerNonUserCode]
		public void ClearMaxSmallHeapUsedSize()
		{
			this._hasBits1 &= -3;
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x0013B550 File Offset: 0x00139750
		// (set) Token: 0x0600520D RID: 21005 RVA: 0x0013B581 File Offset: 0x00139781
		[DebuggerNonUserCode]
		public float AverageResolutionScale
		{
			get
			{
				bool flag = (this._hasBits1 & 4) != 0;
				float averageResolutionScaleDefaultValue;
				if (flag)
				{
					averageResolutionScaleDefaultValue = this.averageResolutionScale_;
				}
				else
				{
					averageResolutionScaleDefaultValue = ClientPerf.AverageResolutionScaleDefaultValue;
				}
				return averageResolutionScaleDefaultValue;
			}
			set
			{
				this._hasBits1 |= 4;
				this.averageResolutionScale_ = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x0013B59C File Offset: 0x0013979C
		[DebuggerNonUserCode]
		public bool HasAverageResolutionScale
		{
			get
			{
				return (this._hasBits1 & 4) != 0;
			}
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x0013B5B9 File Offset: 0x001397B9
		[DebuggerNonUserCode]
		public void ClearAverageResolutionScale()
		{
			this._hasBits1 &= -5;
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x0013B5CC File Offset: 0x001397CC
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x0013B5FD File Offset: 0x001397FD
		[DebuggerNonUserCode]
		public float MinimumResolutionScale
		{
			get
			{
				bool flag = (this._hasBits1 & 8) != 0;
				float minimumResolutionScaleDefaultValue;
				if (flag)
				{
					minimumResolutionScaleDefaultValue = this.minimumResolutionScale_;
				}
				else
				{
					minimumResolutionScaleDefaultValue = ClientPerf.MinimumResolutionScaleDefaultValue;
				}
				return minimumResolutionScaleDefaultValue;
			}
			set
			{
				this._hasBits1 |= 8;
				this.minimumResolutionScale_ = value;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x0013B618 File Offset: 0x00139818
		[DebuggerNonUserCode]
		public bool HasMinimumResolutionScale
		{
			get
			{
				return (this._hasBits1 & 8) != 0;
			}
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x0013B635 File Offset: 0x00139835
		[DebuggerNonUserCode]
		public void ClearMinimumResolutionScale()
		{
			this._hasBits1 &= -9;
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x0013B648 File Offset: 0x00139848
		// (set) Token: 0x06005215 RID: 21013 RVA: 0x0013B669 File Offset: 0x00139869
		[DebuggerNonUserCode]
		public string HwClass
		{
			get
			{
				return this.hwClass_ ?? ClientPerf.HwClassDefaultValue;
			}
			set
			{
				this.hwClass_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x0013B680 File Offset: 0x00139880
		[DebuggerNonUserCode]
		public bool HasHwClass
		{
			get
			{
				return this.hwClass_ != null;
			}
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x0013B69B File Offset: 0x0013989B
		[DebuggerNonUserCode]
		public void ClearHwClass()
		{
			this.hwClass_ = null;
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x0013B6A8 File Offset: 0x001398A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientPerf);
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x0013B6C8 File Offset: 0x001398C8
		[DebuggerNonUserCode]
		public bool Equals(ClientPerf other)
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
							bool flag6 = this.SceneSno != other.SceneSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SceneName != other.SceneName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GridX != other.GridX;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.GridY != other.GridY;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageDelta, other.AverageDelta);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxDelta, other.MaxDelta);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageMonster, other.AverageMonster);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxMonster, other.MaxMonster);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AveragePet, other.AveragePet);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxPet, other.MaxPet);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AveragePlayer, other.AveragePlayer);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxPlayer, other.MaxPlayer);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageActor, other.AverageActor);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxActor, other.MaxActor);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageParticle, other.AverageParticle);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxParticle, other.MaxParticle);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageParticleSystem, other.AverageParticleSystem);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxParticleSystem, other.MaxParticleSystem);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisibleMonster, other.AverageVisibleMonster);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisibleMonster, other.MaxVisibleMonster);
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisiblePet, other.AverageVisiblePet);
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisiblePet, other.MaxVisiblePet);
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisiblePlayer, other.AverageVisiblePlayer);
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisiblePlayer, other.MaxVisiblePlayer);
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisibleActor, other.AverageVisibleActor);
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisibleActor, other.MaxVisibleActor);
																																if (flag31)
																																{
																																	flag2 = false;
																																}
																																else
																																{
																																	bool flag32 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisibleParticle, other.AverageVisibleParticle);
																																	if (flag32)
																																	{
																																		flag2 = false;
																																	}
																																	else
																																	{
																																		bool flag33 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisibleParticle, other.MaxVisibleParticle);
																																		if (flag33)
																																		{
																																			flag2 = false;
																																		}
																																		else
																																		{
																																			bool flag34 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageVisibleParticleSystem, other.AverageVisibleParticleSystem);
																																			if (flag34)
																																			{
																																				flag2 = false;
																																			}
																																			else
																																			{
																																				bool flag35 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxVisibleParticleSystem, other.MaxVisibleParticleSystem);
																																				if (flag35)
																																				{
																																					flag2 = false;
																																				}
																																				else
																																				{
																																					bool flag36 = this.MaxCpuCacheRequiredSize != other.MaxCpuCacheRequiredSize;
																																					if (flag36)
																																					{
																																						flag2 = false;
																																					}
																																					else
																																					{
																																						bool flag37 = this.MaxGpuCacheRequiredSize != other.MaxGpuCacheRequiredSize;
																																						if (flag37)
																																						{
																																							flag2 = false;
																																						}
																																						else
																																						{
																																							bool flag38 = this.MaxMainHeapUsedSize != other.MaxMainHeapUsedSize;
																																							if (flag38)
																																							{
																																								flag2 = false;
																																							}
																																							else
																																							{
																																								bool flag39 = this.MaxSmallHeapUsedSize != other.MaxSmallHeapUsedSize;
																																								if (flag39)
																																								{
																																									flag2 = false;
																																								}
																																								else
																																								{
																																									bool flag40 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AverageResolutionScale, other.AverageResolutionScale);
																																									if (flag40)
																																									{
																																										flag2 = false;
																																									}
																																									else
																																									{
																																										bool flag41 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MinimumResolutionScale, other.MinimumResolutionScale);
																																										if (flag41)
																																										{
																																											flag2 = false;
																																										}
																																										else
																																										{
																																											bool flag42 = this.HwClass != other.HwClass;
																																											flag2 = !flag42 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600521A RID: 21018 RVA: 0x0013BC70 File Offset: 0x00139E70
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
			bool hasGridX = this.HasGridX;
			if (hasGridX)
			{
				num ^= this.GridX.GetHashCode();
			}
			bool hasGridY = this.HasGridY;
			if (hasGridY)
			{
				num ^= this.GridY.GetHashCode();
			}
			bool hasAverageDelta = this.HasAverageDelta;
			if (hasAverageDelta)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageDelta);
			}
			bool hasMaxDelta = this.HasMaxDelta;
			if (hasMaxDelta)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxDelta);
			}
			bool hasAverageMonster = this.HasAverageMonster;
			if (hasAverageMonster)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageMonster);
			}
			bool hasMaxMonster = this.HasMaxMonster;
			if (hasMaxMonster)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxMonster);
			}
			bool hasAveragePet = this.HasAveragePet;
			if (hasAveragePet)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AveragePet);
			}
			bool hasMaxPet = this.HasMaxPet;
			if (hasMaxPet)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxPet);
			}
			bool hasAveragePlayer = this.HasAveragePlayer;
			if (hasAveragePlayer)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AveragePlayer);
			}
			bool hasMaxPlayer = this.HasMaxPlayer;
			if (hasMaxPlayer)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxPlayer);
			}
			bool hasAverageActor = this.HasAverageActor;
			if (hasAverageActor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageActor);
			}
			bool hasMaxActor = this.HasMaxActor;
			if (hasMaxActor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxActor);
			}
			bool hasAverageParticle = this.HasAverageParticle;
			if (hasAverageParticle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageParticle);
			}
			bool hasMaxParticle = this.HasMaxParticle;
			if (hasMaxParticle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxParticle);
			}
			bool hasAverageParticleSystem = this.HasAverageParticleSystem;
			if (hasAverageParticleSystem)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageParticleSystem);
			}
			bool hasMaxParticleSystem = this.HasMaxParticleSystem;
			if (hasMaxParticleSystem)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxParticleSystem);
			}
			bool hasAverageVisibleMonster = this.HasAverageVisibleMonster;
			if (hasAverageVisibleMonster)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisibleMonster);
			}
			bool hasMaxVisibleMonster = this.HasMaxVisibleMonster;
			if (hasMaxVisibleMonster)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisibleMonster);
			}
			bool hasAverageVisiblePet = this.HasAverageVisiblePet;
			if (hasAverageVisiblePet)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisiblePet);
			}
			bool hasMaxVisiblePet = this.HasMaxVisiblePet;
			if (hasMaxVisiblePet)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisiblePet);
			}
			bool hasAverageVisiblePlayer = this.HasAverageVisiblePlayer;
			if (hasAverageVisiblePlayer)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisiblePlayer);
			}
			bool hasMaxVisiblePlayer = this.HasMaxVisiblePlayer;
			if (hasMaxVisiblePlayer)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisiblePlayer);
			}
			bool hasAverageVisibleActor = this.HasAverageVisibleActor;
			if (hasAverageVisibleActor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisibleActor);
			}
			bool hasMaxVisibleActor = this.HasMaxVisibleActor;
			if (hasMaxVisibleActor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisibleActor);
			}
			bool hasAverageVisibleParticle = this.HasAverageVisibleParticle;
			if (hasAverageVisibleParticle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisibleParticle);
			}
			bool hasMaxVisibleParticle = this.HasMaxVisibleParticle;
			if (hasMaxVisibleParticle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisibleParticle);
			}
			bool hasAverageVisibleParticleSystem = this.HasAverageVisibleParticleSystem;
			if (hasAverageVisibleParticleSystem)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageVisibleParticleSystem);
			}
			bool hasMaxVisibleParticleSystem = this.HasMaxVisibleParticleSystem;
			if (hasMaxVisibleParticleSystem)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxVisibleParticleSystem);
			}
			bool hasMaxCpuCacheRequiredSize = this.HasMaxCpuCacheRequiredSize;
			if (hasMaxCpuCacheRequiredSize)
			{
				num ^= this.MaxCpuCacheRequiredSize.GetHashCode();
			}
			bool hasMaxGpuCacheRequiredSize = this.HasMaxGpuCacheRequiredSize;
			if (hasMaxGpuCacheRequiredSize)
			{
				num ^= this.MaxGpuCacheRequiredSize.GetHashCode();
			}
			bool hasMaxMainHeapUsedSize = this.HasMaxMainHeapUsedSize;
			if (hasMaxMainHeapUsedSize)
			{
				num ^= this.MaxMainHeapUsedSize.GetHashCode();
			}
			bool hasMaxSmallHeapUsedSize = this.HasMaxSmallHeapUsedSize;
			if (hasMaxSmallHeapUsedSize)
			{
				num ^= this.MaxSmallHeapUsedSize.GetHashCode();
			}
			bool hasAverageResolutionScale = this.HasAverageResolutionScale;
			if (hasAverageResolutionScale)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AverageResolutionScale);
			}
			bool hasMinimumResolutionScale = this.HasMinimumResolutionScale;
			if (hasMinimumResolutionScale)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MinimumResolutionScale);
			}
			bool hasHwClass = this.HasHwClass;
			if (hasHwClass)
			{
				num ^= this.HwClass.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x0013C140 File Offset: 0x0013A340
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x0013C158 File Offset: 0x0013A358
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x0013C164 File Offset: 0x0013A364
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
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.SceneSno);
			}
			bool hasSceneName = this.HasSceneName;
			if (hasSceneName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.SceneName);
			}
			bool hasGridX = this.HasGridX;
			if (hasGridX)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GridX);
			}
			bool hasGridY = this.HasGridY;
			if (hasGridY)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GridY);
			}
			bool hasAverageDelta = this.HasAverageDelta;
			if (hasAverageDelta)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.AverageDelta);
			}
			bool hasMaxDelta = this.HasMaxDelta;
			if (hasMaxDelta)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.MaxDelta);
			}
			bool hasAverageMonster = this.HasAverageMonster;
			if (hasAverageMonster)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.AverageMonster);
			}
			bool hasMaxMonster = this.HasMaxMonster;
			if (hasMaxMonster)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.MaxMonster);
			}
			bool hasAveragePet = this.HasAveragePet;
			if (hasAveragePet)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.AveragePet);
			}
			bool hasMaxPet = this.HasMaxPet;
			if (hasMaxPet)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.MaxPet);
			}
			bool hasAveragePlayer = this.HasAveragePlayer;
			if (hasAveragePlayer)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.AveragePlayer);
			}
			bool hasMaxPlayer = this.HasMaxPlayer;
			if (hasMaxPlayer)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.MaxPlayer);
			}
			bool hasAverageActor = this.HasAverageActor;
			if (hasAverageActor)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.AverageActor);
			}
			bool hasMaxActor = this.HasMaxActor;
			if (hasMaxActor)
			{
				output.WriteRawTag(133, 1);
				output.WriteFloat(this.MaxActor);
			}
			bool hasAverageParticle = this.HasAverageParticle;
			if (hasAverageParticle)
			{
				output.WriteRawTag(141, 1);
				output.WriteFloat(this.AverageParticle);
			}
			bool hasMaxParticle = this.HasMaxParticle;
			if (hasMaxParticle)
			{
				output.WriteRawTag(149, 1);
				output.WriteFloat(this.MaxParticle);
			}
			bool hasAverageParticleSystem = this.HasAverageParticleSystem;
			if (hasAverageParticleSystem)
			{
				output.WriteRawTag(157, 1);
				output.WriteFloat(this.AverageParticleSystem);
			}
			bool hasMaxParticleSystem = this.HasMaxParticleSystem;
			if (hasMaxParticleSystem)
			{
				output.WriteRawTag(165, 1);
				output.WriteFloat(this.MaxParticleSystem);
			}
			bool hasAverageVisibleMonster = this.HasAverageVisibleMonster;
			if (hasAverageVisibleMonster)
			{
				output.WriteRawTag(173, 1);
				output.WriteFloat(this.AverageVisibleMonster);
			}
			bool hasMaxVisibleMonster = this.HasMaxVisibleMonster;
			if (hasMaxVisibleMonster)
			{
				output.WriteRawTag(181, 1);
				output.WriteFloat(this.MaxVisibleMonster);
			}
			bool hasAverageVisiblePet = this.HasAverageVisiblePet;
			if (hasAverageVisiblePet)
			{
				output.WriteRawTag(189, 1);
				output.WriteFloat(this.AverageVisiblePet);
			}
			bool hasMaxVisiblePet = this.HasMaxVisiblePet;
			if (hasMaxVisiblePet)
			{
				output.WriteRawTag(197, 1);
				output.WriteFloat(this.MaxVisiblePet);
			}
			bool hasAverageVisiblePlayer = this.HasAverageVisiblePlayer;
			if (hasAverageVisiblePlayer)
			{
				output.WriteRawTag(205, 1);
				output.WriteFloat(this.AverageVisiblePlayer);
			}
			bool hasMaxVisiblePlayer = this.HasMaxVisiblePlayer;
			if (hasMaxVisiblePlayer)
			{
				output.WriteRawTag(213, 1);
				output.WriteFloat(this.MaxVisiblePlayer);
			}
			bool hasAverageVisibleActor = this.HasAverageVisibleActor;
			if (hasAverageVisibleActor)
			{
				output.WriteRawTag(221, 1);
				output.WriteFloat(this.AverageVisibleActor);
			}
			bool hasMaxVisibleActor = this.HasMaxVisibleActor;
			if (hasMaxVisibleActor)
			{
				output.WriteRawTag(229, 1);
				output.WriteFloat(this.MaxVisibleActor);
			}
			bool hasAverageVisibleParticle = this.HasAverageVisibleParticle;
			if (hasAverageVisibleParticle)
			{
				output.WriteRawTag(237, 1);
				output.WriteFloat(this.AverageVisibleParticle);
			}
			bool hasMaxVisibleParticle = this.HasMaxVisibleParticle;
			if (hasMaxVisibleParticle)
			{
				output.WriteRawTag(245, 1);
				output.WriteFloat(this.MaxVisibleParticle);
			}
			bool hasAverageVisibleParticleSystem = this.HasAverageVisibleParticleSystem;
			if (hasAverageVisibleParticleSystem)
			{
				output.WriteRawTag(253, 1);
				output.WriteFloat(this.AverageVisibleParticleSystem);
			}
			bool hasMaxVisibleParticleSystem = this.HasMaxVisibleParticleSystem;
			if (hasMaxVisibleParticleSystem)
			{
				output.WriteRawTag(133, 2);
				output.WriteFloat(this.MaxVisibleParticleSystem);
			}
			bool hasMaxCpuCacheRequiredSize = this.HasMaxCpuCacheRequiredSize;
			if (hasMaxCpuCacheRequiredSize)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt64(this.MaxCpuCacheRequiredSize);
			}
			bool hasMaxGpuCacheRequiredSize = this.HasMaxGpuCacheRequiredSize;
			if (hasMaxGpuCacheRequiredSize)
			{
				output.WriteRawTag(144, 2);
				output.WriteInt64(this.MaxGpuCacheRequiredSize);
			}
			bool hasMaxMainHeapUsedSize = this.HasMaxMainHeapUsedSize;
			if (hasMaxMainHeapUsedSize)
			{
				output.WriteRawTag(152, 2);
				output.WriteInt64(this.MaxMainHeapUsedSize);
			}
			bool hasMaxSmallHeapUsedSize = this.HasMaxSmallHeapUsedSize;
			if (hasMaxSmallHeapUsedSize)
			{
				output.WriteRawTag(160, 2);
				output.WriteInt64(this.MaxSmallHeapUsedSize);
			}
			bool hasAverageResolutionScale = this.HasAverageResolutionScale;
			if (hasAverageResolutionScale)
			{
				output.WriteRawTag(173, 2);
				output.WriteFloat(this.AverageResolutionScale);
			}
			bool hasMinimumResolutionScale = this.HasMinimumResolutionScale;
			if (hasMinimumResolutionScale)
			{
				output.WriteRawTag(181, 2);
				output.WriteFloat(this.MinimumResolutionScale);
			}
			bool hasHwClass = this.HasHwClass;
			if (hasHwClass)
			{
				output.WriteRawTag(186, 2);
				output.WriteString(this.HwClass);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x0013C764 File Offset: 0x0013A964
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
			bool hasGridX = this.HasGridX;
			if (hasGridX)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridX);
			}
			bool hasGridY = this.HasGridY;
			if (hasGridY)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridY);
			}
			bool hasAverageDelta = this.HasAverageDelta;
			if (hasAverageDelta)
			{
				num += 5;
			}
			bool hasMaxDelta = this.HasMaxDelta;
			if (hasMaxDelta)
			{
				num += 5;
			}
			bool hasAverageMonster = this.HasAverageMonster;
			if (hasAverageMonster)
			{
				num += 5;
			}
			bool hasMaxMonster = this.HasMaxMonster;
			if (hasMaxMonster)
			{
				num += 5;
			}
			bool hasAveragePet = this.HasAveragePet;
			if (hasAveragePet)
			{
				num += 5;
			}
			bool hasMaxPet = this.HasMaxPet;
			if (hasMaxPet)
			{
				num += 5;
			}
			bool hasAveragePlayer = this.HasAveragePlayer;
			if (hasAveragePlayer)
			{
				num += 5;
			}
			bool hasMaxPlayer = this.HasMaxPlayer;
			if (hasMaxPlayer)
			{
				num += 5;
			}
			bool hasAverageActor = this.HasAverageActor;
			if (hasAverageActor)
			{
				num += 5;
			}
			bool hasMaxActor = this.HasMaxActor;
			if (hasMaxActor)
			{
				num += 6;
			}
			bool hasAverageParticle = this.HasAverageParticle;
			if (hasAverageParticle)
			{
				num += 6;
			}
			bool hasMaxParticle = this.HasMaxParticle;
			if (hasMaxParticle)
			{
				num += 6;
			}
			bool hasAverageParticleSystem = this.HasAverageParticleSystem;
			if (hasAverageParticleSystem)
			{
				num += 6;
			}
			bool hasMaxParticleSystem = this.HasMaxParticleSystem;
			if (hasMaxParticleSystem)
			{
				num += 6;
			}
			bool hasAverageVisibleMonster = this.HasAverageVisibleMonster;
			if (hasAverageVisibleMonster)
			{
				num += 6;
			}
			bool hasMaxVisibleMonster = this.HasMaxVisibleMonster;
			if (hasMaxVisibleMonster)
			{
				num += 6;
			}
			bool hasAverageVisiblePet = this.HasAverageVisiblePet;
			if (hasAverageVisiblePet)
			{
				num += 6;
			}
			bool hasMaxVisiblePet = this.HasMaxVisiblePet;
			if (hasMaxVisiblePet)
			{
				num += 6;
			}
			bool hasAverageVisiblePlayer = this.HasAverageVisiblePlayer;
			if (hasAverageVisiblePlayer)
			{
				num += 6;
			}
			bool hasMaxVisiblePlayer = this.HasMaxVisiblePlayer;
			if (hasMaxVisiblePlayer)
			{
				num += 6;
			}
			bool hasAverageVisibleActor = this.HasAverageVisibleActor;
			if (hasAverageVisibleActor)
			{
				num += 6;
			}
			bool hasMaxVisibleActor = this.HasMaxVisibleActor;
			if (hasMaxVisibleActor)
			{
				num += 6;
			}
			bool hasAverageVisibleParticle = this.HasAverageVisibleParticle;
			if (hasAverageVisibleParticle)
			{
				num += 6;
			}
			bool hasMaxVisibleParticle = this.HasMaxVisibleParticle;
			if (hasMaxVisibleParticle)
			{
				num += 6;
			}
			bool hasAverageVisibleParticleSystem = this.HasAverageVisibleParticleSystem;
			if (hasAverageVisibleParticleSystem)
			{
				num += 6;
			}
			bool hasMaxVisibleParticleSystem = this.HasMaxVisibleParticleSystem;
			if (hasMaxVisibleParticleSystem)
			{
				num += 6;
			}
			bool hasMaxCpuCacheRequiredSize = this.HasMaxCpuCacheRequiredSize;
			if (hasMaxCpuCacheRequiredSize)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.MaxCpuCacheRequiredSize);
			}
			bool hasMaxGpuCacheRequiredSize = this.HasMaxGpuCacheRequiredSize;
			if (hasMaxGpuCacheRequiredSize)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.MaxGpuCacheRequiredSize);
			}
			bool hasMaxMainHeapUsedSize = this.HasMaxMainHeapUsedSize;
			if (hasMaxMainHeapUsedSize)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.MaxMainHeapUsedSize);
			}
			bool hasMaxSmallHeapUsedSize = this.HasMaxSmallHeapUsedSize;
			if (hasMaxSmallHeapUsedSize)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.MaxSmallHeapUsedSize);
			}
			bool hasAverageResolutionScale = this.HasAverageResolutionScale;
			if (hasAverageResolutionScale)
			{
				num += 6;
			}
			bool hasMinimumResolutionScale = this.HasMinimumResolutionScale;
			if (hasMinimumResolutionScale)
			{
				num += 6;
			}
			bool hasHwClass = this.HasHwClass;
			if (hasHwClass)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.HwClass);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x0013CAD8 File Offset: 0x0013ACD8
		[DebuggerNonUserCode]
		public void MergeFrom(ClientPerf other)
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
				bool hasGridX = other.HasGridX;
				if (hasGridX)
				{
					this.GridX = other.GridX;
				}
				bool hasGridY = other.HasGridY;
				if (hasGridY)
				{
					this.GridY = other.GridY;
				}
				bool hasAverageDelta = other.HasAverageDelta;
				if (hasAverageDelta)
				{
					this.AverageDelta = other.AverageDelta;
				}
				bool hasMaxDelta = other.HasMaxDelta;
				if (hasMaxDelta)
				{
					this.MaxDelta = other.MaxDelta;
				}
				bool hasAverageMonster = other.HasAverageMonster;
				if (hasAverageMonster)
				{
					this.AverageMonster = other.AverageMonster;
				}
				bool hasMaxMonster = other.HasMaxMonster;
				if (hasMaxMonster)
				{
					this.MaxMonster = other.MaxMonster;
				}
				bool hasAveragePet = other.HasAveragePet;
				if (hasAveragePet)
				{
					this.AveragePet = other.AveragePet;
				}
				bool hasMaxPet = other.HasMaxPet;
				if (hasMaxPet)
				{
					this.MaxPet = other.MaxPet;
				}
				bool hasAveragePlayer = other.HasAveragePlayer;
				if (hasAveragePlayer)
				{
					this.AveragePlayer = other.AveragePlayer;
				}
				bool hasMaxPlayer = other.HasMaxPlayer;
				if (hasMaxPlayer)
				{
					this.MaxPlayer = other.MaxPlayer;
				}
				bool hasAverageActor = other.HasAverageActor;
				if (hasAverageActor)
				{
					this.AverageActor = other.AverageActor;
				}
				bool hasMaxActor = other.HasMaxActor;
				if (hasMaxActor)
				{
					this.MaxActor = other.MaxActor;
				}
				bool hasAverageParticle = other.HasAverageParticle;
				if (hasAverageParticle)
				{
					this.AverageParticle = other.AverageParticle;
				}
				bool hasMaxParticle = other.HasMaxParticle;
				if (hasMaxParticle)
				{
					this.MaxParticle = other.MaxParticle;
				}
				bool hasAverageParticleSystem = other.HasAverageParticleSystem;
				if (hasAverageParticleSystem)
				{
					this.AverageParticleSystem = other.AverageParticleSystem;
				}
				bool hasMaxParticleSystem = other.HasMaxParticleSystem;
				if (hasMaxParticleSystem)
				{
					this.MaxParticleSystem = other.MaxParticleSystem;
				}
				bool hasAverageVisibleMonster = other.HasAverageVisibleMonster;
				if (hasAverageVisibleMonster)
				{
					this.AverageVisibleMonster = other.AverageVisibleMonster;
				}
				bool hasMaxVisibleMonster = other.HasMaxVisibleMonster;
				if (hasMaxVisibleMonster)
				{
					this.MaxVisibleMonster = other.MaxVisibleMonster;
				}
				bool hasAverageVisiblePet = other.HasAverageVisiblePet;
				if (hasAverageVisiblePet)
				{
					this.AverageVisiblePet = other.AverageVisiblePet;
				}
				bool hasMaxVisiblePet = other.HasMaxVisiblePet;
				if (hasMaxVisiblePet)
				{
					this.MaxVisiblePet = other.MaxVisiblePet;
				}
				bool hasAverageVisiblePlayer = other.HasAverageVisiblePlayer;
				if (hasAverageVisiblePlayer)
				{
					this.AverageVisiblePlayer = other.AverageVisiblePlayer;
				}
				bool hasMaxVisiblePlayer = other.HasMaxVisiblePlayer;
				if (hasMaxVisiblePlayer)
				{
					this.MaxVisiblePlayer = other.MaxVisiblePlayer;
				}
				bool hasAverageVisibleActor = other.HasAverageVisibleActor;
				if (hasAverageVisibleActor)
				{
					this.AverageVisibleActor = other.AverageVisibleActor;
				}
				bool hasMaxVisibleActor = other.HasMaxVisibleActor;
				if (hasMaxVisibleActor)
				{
					this.MaxVisibleActor = other.MaxVisibleActor;
				}
				bool hasAverageVisibleParticle = other.HasAverageVisibleParticle;
				if (hasAverageVisibleParticle)
				{
					this.AverageVisibleParticle = other.AverageVisibleParticle;
				}
				bool hasMaxVisibleParticle = other.HasMaxVisibleParticle;
				if (hasMaxVisibleParticle)
				{
					this.MaxVisibleParticle = other.MaxVisibleParticle;
				}
				bool hasAverageVisibleParticleSystem = other.HasAverageVisibleParticleSystem;
				if (hasAverageVisibleParticleSystem)
				{
					this.AverageVisibleParticleSystem = other.AverageVisibleParticleSystem;
				}
				bool hasMaxVisibleParticleSystem = other.HasMaxVisibleParticleSystem;
				if (hasMaxVisibleParticleSystem)
				{
					this.MaxVisibleParticleSystem = other.MaxVisibleParticleSystem;
				}
				bool hasMaxCpuCacheRequiredSize = other.HasMaxCpuCacheRequiredSize;
				if (hasMaxCpuCacheRequiredSize)
				{
					this.MaxCpuCacheRequiredSize = other.MaxCpuCacheRequiredSize;
				}
				bool hasMaxGpuCacheRequiredSize = other.HasMaxGpuCacheRequiredSize;
				if (hasMaxGpuCacheRequiredSize)
				{
					this.MaxGpuCacheRequiredSize = other.MaxGpuCacheRequiredSize;
				}
				bool hasMaxMainHeapUsedSize = other.HasMaxMainHeapUsedSize;
				if (hasMaxMainHeapUsedSize)
				{
					this.MaxMainHeapUsedSize = other.MaxMainHeapUsedSize;
				}
				bool hasMaxSmallHeapUsedSize = other.HasMaxSmallHeapUsedSize;
				if (hasMaxSmallHeapUsedSize)
				{
					this.MaxSmallHeapUsedSize = other.MaxSmallHeapUsedSize;
				}
				bool hasAverageResolutionScale = other.HasAverageResolutionScale;
				if (hasAverageResolutionScale)
				{
					this.AverageResolutionScale = other.AverageResolutionScale;
				}
				bool hasMinimumResolutionScale = other.HasMinimumResolutionScale;
				if (hasMinimumResolutionScale)
				{
					this.MinimumResolutionScale = other.MinimumResolutionScale;
				}
				bool hasHwClass = other.HasHwClass;
				if (hasHwClass)
				{
					this.HwClass = other.HwClass;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x0013CF22 File Offset: 0x0013B122
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0013CF30 File Offset: 0x0013B130
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 157U)
				{
					if (num3 <= 77U)
					{
						if (num3 <= 34U)
						{
							if (num3 <= 18U)
							{
								if (num3 != 8U)
								{
									if (num3 != 18U)
									{
										goto IL_0268;
									}
									this.WorldName = input.ReadString();
								}
								else
								{
									this.WorldSno = input.ReadSInt32();
								}
							}
							else if (num3 != 24U)
							{
								if (num3 != 34U)
								{
									goto IL_0268;
								}
								this.SceneName = input.ReadString();
							}
							else
							{
								this.SceneSno = input.ReadSInt32();
							}
						}
						else if (num3 <= 48U)
						{
							if (num3 != 40U)
							{
								if (num3 != 48U)
								{
									goto IL_0268;
								}
								this.GridY = input.ReadInt32();
							}
							else
							{
								this.GridX = input.ReadInt32();
							}
						}
						else if (num3 != 61U)
						{
							if (num3 != 69U)
							{
								if (num3 != 77U)
								{
									goto IL_0268;
								}
								this.AverageMonster = input.ReadFloat();
							}
							else
							{
								this.MaxDelta = input.ReadFloat();
							}
						}
						else
						{
							this.AverageDelta = input.ReadFloat();
						}
					}
					else if (num3 <= 117U)
					{
						if (num3 <= 93U)
						{
							if (num3 != 85U)
							{
								if (num3 != 93U)
								{
									goto IL_0268;
								}
								this.AveragePet = input.ReadFloat();
							}
							else
							{
								this.MaxMonster = input.ReadFloat();
							}
						}
						else if (num3 != 101U)
						{
							if (num3 != 109U)
							{
								if (num3 != 117U)
								{
									goto IL_0268;
								}
								this.MaxPlayer = input.ReadFloat();
							}
							else
							{
								this.AveragePlayer = input.ReadFloat();
							}
						}
						else
						{
							this.MaxPet = input.ReadFloat();
						}
					}
					else if (num3 <= 133U)
					{
						if (num3 != 125U)
						{
							if (num3 != 133U)
							{
								goto IL_0268;
							}
							this.MaxActor = input.ReadFloat();
						}
						else
						{
							this.AverageActor = input.ReadFloat();
						}
					}
					else if (num3 != 141U)
					{
						if (num3 != 149U)
						{
							if (num3 != 157U)
							{
								goto IL_0268;
							}
							this.AverageParticleSystem = input.ReadFloat();
						}
						else
						{
							this.MaxParticle = input.ReadFloat();
						}
					}
					else
					{
						this.AverageParticle = input.ReadFloat();
					}
				}
				else if (num3 <= 237U)
				{
					if (num3 <= 197U)
					{
						if (num3 <= 173U)
						{
							if (num3 != 165U)
							{
								if (num3 != 173U)
								{
									goto IL_0268;
								}
								this.AverageVisibleMonster = input.ReadFloat();
							}
							else
							{
								this.MaxParticleSystem = input.ReadFloat();
							}
						}
						else if (num3 != 181U)
						{
							if (num3 != 189U)
							{
								if (num3 != 197U)
								{
									goto IL_0268;
								}
								this.MaxVisiblePet = input.ReadFloat();
							}
							else
							{
								this.AverageVisiblePet = input.ReadFloat();
							}
						}
						else
						{
							this.MaxVisibleMonster = input.ReadFloat();
						}
					}
					else if (num3 <= 213U)
					{
						if (num3 != 205U)
						{
							if (num3 != 213U)
							{
								goto IL_0268;
							}
							this.MaxVisiblePlayer = input.ReadFloat();
						}
						else
						{
							this.AverageVisiblePlayer = input.ReadFloat();
						}
					}
					else if (num3 != 221U)
					{
						if (num3 != 229U)
						{
							if (num3 != 237U)
							{
								goto IL_0268;
							}
							this.AverageVisibleParticle = input.ReadFloat();
						}
						else
						{
							this.MaxVisibleActor = input.ReadFloat();
						}
					}
					else
					{
						this.AverageVisibleActor = input.ReadFloat();
					}
				}
				else if (num3 <= 272U)
				{
					if (num3 <= 253U)
					{
						if (num3 != 245U)
						{
							if (num3 != 253U)
							{
								goto IL_0268;
							}
							this.AverageVisibleParticleSystem = input.ReadFloat();
						}
						else
						{
							this.MaxVisibleParticle = input.ReadFloat();
						}
					}
					else if (num3 != 261U)
					{
						if (num3 != 264U)
						{
							if (num3 != 272U)
							{
								goto IL_0268;
							}
							this.MaxGpuCacheRequiredSize = input.ReadInt64();
						}
						else
						{
							this.MaxCpuCacheRequiredSize = input.ReadInt64();
						}
					}
					else
					{
						this.MaxVisibleParticleSystem = input.ReadFloat();
					}
				}
				else if (num3 <= 288U)
				{
					if (num3 != 280U)
					{
						if (num3 != 288U)
						{
							goto IL_0268;
						}
						this.MaxSmallHeapUsedSize = input.ReadInt64();
					}
					else
					{
						this.MaxMainHeapUsedSize = input.ReadInt64();
					}
				}
				else if (num3 != 301U)
				{
					if (num3 != 309U)
					{
						if (num3 != 314U)
						{
							goto IL_0268;
						}
						this.HwClass = input.ReadString();
					}
					else
					{
						this.MinimumResolutionScale = input.ReadFloat();
					}
				}
				else
				{
					this.AverageResolutionScale = input.ReadFloat();
				}
				continue;
				IL_0268:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024D7 RID: 9431
		private static readonly MessageParser<ClientPerf> _parser = new MessageParser<ClientPerf>(() => new ClientPerf());

		// Token: 0x040024D8 RID: 9432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024D9 RID: 9433
		private int _hasBits0;

		// Token: 0x040024DA RID: 9434
		private int _hasBits1;

		// Token: 0x040024DB RID: 9435
		public const int WorldSnoFieldNumber = 1;

		// Token: 0x040024DC RID: 9436
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x040024DD RID: 9437
		private int worldSno_;

		// Token: 0x040024DE RID: 9438
		public const int WorldNameFieldNumber = 2;

		// Token: 0x040024DF RID: 9439
		private static readonly string WorldNameDefaultValue = "";

		// Token: 0x040024E0 RID: 9440
		private string worldName_;

		// Token: 0x040024E1 RID: 9441
		public const int SceneSnoFieldNumber = 3;

		// Token: 0x040024E2 RID: 9442
		private static readonly int SceneSnoDefaultValue = 0;

		// Token: 0x040024E3 RID: 9443
		private int sceneSno_;

		// Token: 0x040024E4 RID: 9444
		public const int SceneNameFieldNumber = 4;

		// Token: 0x040024E5 RID: 9445
		private static readonly string SceneNameDefaultValue = "";

		// Token: 0x040024E6 RID: 9446
		private string sceneName_;

		// Token: 0x040024E7 RID: 9447
		public const int GridXFieldNumber = 5;

		// Token: 0x040024E8 RID: 9448
		private static readonly int GridXDefaultValue = 0;

		// Token: 0x040024E9 RID: 9449
		private int gridX_;

		// Token: 0x040024EA RID: 9450
		public const int GridYFieldNumber = 6;

		// Token: 0x040024EB RID: 9451
		private static readonly int GridYDefaultValue = 0;

		// Token: 0x040024EC RID: 9452
		private int gridY_;

		// Token: 0x040024ED RID: 9453
		public const int AverageDeltaFieldNumber = 7;

		// Token: 0x040024EE RID: 9454
		private static readonly float AverageDeltaDefaultValue = 0f;

		// Token: 0x040024EF RID: 9455
		private float averageDelta_;

		// Token: 0x040024F0 RID: 9456
		public const int MaxDeltaFieldNumber = 8;

		// Token: 0x040024F1 RID: 9457
		private static readonly float MaxDeltaDefaultValue = 0f;

		// Token: 0x040024F2 RID: 9458
		private float maxDelta_;

		// Token: 0x040024F3 RID: 9459
		public const int AverageMonsterFieldNumber = 9;

		// Token: 0x040024F4 RID: 9460
		private static readonly float AverageMonsterDefaultValue = 0f;

		// Token: 0x040024F5 RID: 9461
		private float averageMonster_;

		// Token: 0x040024F6 RID: 9462
		public const int MaxMonsterFieldNumber = 10;

		// Token: 0x040024F7 RID: 9463
		private static readonly float MaxMonsterDefaultValue = 0f;

		// Token: 0x040024F8 RID: 9464
		private float maxMonster_;

		// Token: 0x040024F9 RID: 9465
		public const int AveragePetFieldNumber = 11;

		// Token: 0x040024FA RID: 9466
		private static readonly float AveragePetDefaultValue = 0f;

		// Token: 0x040024FB RID: 9467
		private float averagePet_;

		// Token: 0x040024FC RID: 9468
		public const int MaxPetFieldNumber = 12;

		// Token: 0x040024FD RID: 9469
		private static readonly float MaxPetDefaultValue = 0f;

		// Token: 0x040024FE RID: 9470
		private float maxPet_;

		// Token: 0x040024FF RID: 9471
		public const int AveragePlayerFieldNumber = 13;

		// Token: 0x04002500 RID: 9472
		private static readonly float AveragePlayerDefaultValue = 0f;

		// Token: 0x04002501 RID: 9473
		private float averagePlayer_;

		// Token: 0x04002502 RID: 9474
		public const int MaxPlayerFieldNumber = 14;

		// Token: 0x04002503 RID: 9475
		private static readonly float MaxPlayerDefaultValue = 0f;

		// Token: 0x04002504 RID: 9476
		private float maxPlayer_;

		// Token: 0x04002505 RID: 9477
		public const int AverageActorFieldNumber = 15;

		// Token: 0x04002506 RID: 9478
		private static readonly float AverageActorDefaultValue = 0f;

		// Token: 0x04002507 RID: 9479
		private float averageActor_;

		// Token: 0x04002508 RID: 9480
		public const int MaxActorFieldNumber = 16;

		// Token: 0x04002509 RID: 9481
		private static readonly float MaxActorDefaultValue = 0f;

		// Token: 0x0400250A RID: 9482
		private float maxActor_;

		// Token: 0x0400250B RID: 9483
		public const int AverageParticleFieldNumber = 17;

		// Token: 0x0400250C RID: 9484
		private static readonly float AverageParticleDefaultValue = 0f;

		// Token: 0x0400250D RID: 9485
		private float averageParticle_;

		// Token: 0x0400250E RID: 9486
		public const int MaxParticleFieldNumber = 18;

		// Token: 0x0400250F RID: 9487
		private static readonly float MaxParticleDefaultValue = 0f;

		// Token: 0x04002510 RID: 9488
		private float maxParticle_;

		// Token: 0x04002511 RID: 9489
		public const int AverageParticleSystemFieldNumber = 19;

		// Token: 0x04002512 RID: 9490
		private static readonly float AverageParticleSystemDefaultValue = 0f;

		// Token: 0x04002513 RID: 9491
		private float averageParticleSystem_;

		// Token: 0x04002514 RID: 9492
		public const int MaxParticleSystemFieldNumber = 20;

		// Token: 0x04002515 RID: 9493
		private static readonly float MaxParticleSystemDefaultValue = 0f;

		// Token: 0x04002516 RID: 9494
		private float maxParticleSystem_;

		// Token: 0x04002517 RID: 9495
		public const int AverageVisibleMonsterFieldNumber = 21;

		// Token: 0x04002518 RID: 9496
		private static readonly float AverageVisibleMonsterDefaultValue = 0f;

		// Token: 0x04002519 RID: 9497
		private float averageVisibleMonster_;

		// Token: 0x0400251A RID: 9498
		public const int MaxVisibleMonsterFieldNumber = 22;

		// Token: 0x0400251B RID: 9499
		private static readonly float MaxVisibleMonsterDefaultValue = 0f;

		// Token: 0x0400251C RID: 9500
		private float maxVisibleMonster_;

		// Token: 0x0400251D RID: 9501
		public const int AverageVisiblePetFieldNumber = 23;

		// Token: 0x0400251E RID: 9502
		private static readonly float AverageVisiblePetDefaultValue = 0f;

		// Token: 0x0400251F RID: 9503
		private float averageVisiblePet_;

		// Token: 0x04002520 RID: 9504
		public const int MaxVisiblePetFieldNumber = 24;

		// Token: 0x04002521 RID: 9505
		private static readonly float MaxVisiblePetDefaultValue = 0f;

		// Token: 0x04002522 RID: 9506
		private float maxVisiblePet_;

		// Token: 0x04002523 RID: 9507
		public const int AverageVisiblePlayerFieldNumber = 25;

		// Token: 0x04002524 RID: 9508
		private static readonly float AverageVisiblePlayerDefaultValue = 0f;

		// Token: 0x04002525 RID: 9509
		private float averageVisiblePlayer_;

		// Token: 0x04002526 RID: 9510
		public const int MaxVisiblePlayerFieldNumber = 26;

		// Token: 0x04002527 RID: 9511
		private static readonly float MaxVisiblePlayerDefaultValue = 0f;

		// Token: 0x04002528 RID: 9512
		private float maxVisiblePlayer_;

		// Token: 0x04002529 RID: 9513
		public const int AverageVisibleActorFieldNumber = 27;

		// Token: 0x0400252A RID: 9514
		private static readonly float AverageVisibleActorDefaultValue = 0f;

		// Token: 0x0400252B RID: 9515
		private float averageVisibleActor_;

		// Token: 0x0400252C RID: 9516
		public const int MaxVisibleActorFieldNumber = 28;

		// Token: 0x0400252D RID: 9517
		private static readonly float MaxVisibleActorDefaultValue = 0f;

		// Token: 0x0400252E RID: 9518
		private float maxVisibleActor_;

		// Token: 0x0400252F RID: 9519
		public const int AverageVisibleParticleFieldNumber = 29;

		// Token: 0x04002530 RID: 9520
		private static readonly float AverageVisibleParticleDefaultValue = 0f;

		// Token: 0x04002531 RID: 9521
		private float averageVisibleParticle_;

		// Token: 0x04002532 RID: 9522
		public const int MaxVisibleParticleFieldNumber = 30;

		// Token: 0x04002533 RID: 9523
		private static readonly float MaxVisibleParticleDefaultValue = 0f;

		// Token: 0x04002534 RID: 9524
		private float maxVisibleParticle_;

		// Token: 0x04002535 RID: 9525
		public const int AverageVisibleParticleSystemFieldNumber = 31;

		// Token: 0x04002536 RID: 9526
		private static readonly float AverageVisibleParticleSystemDefaultValue = 0f;

		// Token: 0x04002537 RID: 9527
		private float averageVisibleParticleSystem_;

		// Token: 0x04002538 RID: 9528
		public const int MaxVisibleParticleSystemFieldNumber = 32;

		// Token: 0x04002539 RID: 9529
		private static readonly float MaxVisibleParticleSystemDefaultValue = 0f;

		// Token: 0x0400253A RID: 9530
		private float maxVisibleParticleSystem_;

		// Token: 0x0400253B RID: 9531
		public const int MaxCpuCacheRequiredSizeFieldNumber = 33;

		// Token: 0x0400253C RID: 9532
		private static readonly long MaxCpuCacheRequiredSizeDefaultValue = 0L;

		// Token: 0x0400253D RID: 9533
		private long maxCpuCacheRequiredSize_;

		// Token: 0x0400253E RID: 9534
		public const int MaxGpuCacheRequiredSizeFieldNumber = 34;

		// Token: 0x0400253F RID: 9535
		private static readonly long MaxGpuCacheRequiredSizeDefaultValue = 0L;

		// Token: 0x04002540 RID: 9536
		private long maxGpuCacheRequiredSize_;

		// Token: 0x04002541 RID: 9537
		public const int MaxMainHeapUsedSizeFieldNumber = 35;

		// Token: 0x04002542 RID: 9538
		private static readonly long MaxMainHeapUsedSizeDefaultValue = 0L;

		// Token: 0x04002543 RID: 9539
		private long maxMainHeapUsedSize_;

		// Token: 0x04002544 RID: 9540
		public const int MaxSmallHeapUsedSizeFieldNumber = 36;

		// Token: 0x04002545 RID: 9541
		private static readonly long MaxSmallHeapUsedSizeDefaultValue = 0L;

		// Token: 0x04002546 RID: 9542
		private long maxSmallHeapUsedSize_;

		// Token: 0x04002547 RID: 9543
		public const int AverageResolutionScaleFieldNumber = 37;

		// Token: 0x04002548 RID: 9544
		private static readonly float AverageResolutionScaleDefaultValue = 0f;

		// Token: 0x04002549 RID: 9545
		private float averageResolutionScale_;

		// Token: 0x0400254A RID: 9546
		public const int MinimumResolutionScaleFieldNumber = 38;

		// Token: 0x0400254B RID: 9547
		private static readonly float MinimumResolutionScaleDefaultValue = 0f;

		// Token: 0x0400254C RID: 9548
		private float minimumResolutionScale_;

		// Token: 0x0400254D RID: 9549
		public const int HwClassFieldNumber = 39;

		// Token: 0x0400254E RID: 9550
		private static readonly string HwClassDefaultValue = "";

		// Token: 0x0400254F RID: 9551
		private string hwClass_;
	}
}
