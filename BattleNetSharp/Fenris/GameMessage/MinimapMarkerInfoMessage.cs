using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C5 RID: 453
	public sealed class MinimapMarkerInfoMessage : IMessage<MinimapMarkerInfoMessage>, IMessage, IEquatable<MinimapMarkerInfoMessage>, IDeepCloneable<MinimapMarkerInfoMessage>, IBufferMessage
	{
		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000BD250 File Offset: 0x000BB450
		[DebuggerNonUserCode]
		public static MessageParser<MinimapMarkerInfoMessage> Parser
		{
			get
			{
				return MinimapMarkerInfoMessage._parser;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x000BD268 File Offset: 0x000BB468
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000BD28C File Offset: 0x000BB48C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MinimapMarkerInfoMessage.Descriptor;
			}
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000BD2A3 File Offset: 0x000BB4A3
		[DebuggerNonUserCode]
		public MinimapMarkerInfoMessage()
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000BD2B0 File Offset: 0x000BB4B0
		[DebuggerNonUserCode]
		public MinimapMarkerInfoMessage(MinimapMarkerInfoMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.idPing_ = other.idPing_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.idSworld_ = other.idSworld_;
			this.snoWorld_ = other.snoWorld_;
			this.snoLevelArea_ = other.snoLevelArea_;
			this.imageHandle_ = other.imageHandle_;
			this.snoStringList_ = other.snoStringList_;
			this.stringLabelHandle_ = other.stringLabelHandle_;
			this.active_ = other.active_;
			this.respectsFogOfWar_ = other.respectsFogOfWar_;
			this.respectsExploredArea_ = other.respectsExploredArea_;
			this.isPing_ = other.isPing_;
			this.usesAreaRadius_ = other.usesAreaRadius_;
			this.fromBakedData_ = other.fromBakedData_;
			this.isDebugPing_ = other.isDebugPing_;
			this.maxDisplayRangeSq_ = other.maxDisplayRangeSq_;
			this.discoverRangeSq_ = other.discoverRangeSq_;
			this.questAreaRadius_ = other.questAreaRadius_;
			this.snoQuestSource_ = other.snoQuestSource_;
			this.questPhaseUid_ = other.questPhaseUid_;
			this.questCallbackUid_ = other.questCallbackUid_;
			this.serverMarkerType_ = other.serverMarkerType_;
			this.snoDestWorld_ = other.snoDestWorld_;
			this.polygonRegion_ = ((other.polygonRegion_ != null) ? other.polygonRegion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x000BD438 File Offset: 0x000BB638
		[DebuggerNonUserCode]
		public MinimapMarkerInfoMessage Clone()
		{
			return new MinimapMarkerInfoMessage(this);
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000BD450 File Offset: 0x000BB650
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x000BD481 File Offset: 0x000BB681
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = MinimapMarkerInfoMessage.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000BD49C File Offset: 0x000BB69C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x000BD4B9 File Offset: 0x000BB6B9
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000BD4CC File Offset: 0x000BB6CC
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x000BD4FD File Offset: 0x000BB6FD
		[DebuggerNonUserCode]
		public uint IdPing
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idPingDefaultValue;
				if (flag)
				{
					idPingDefaultValue = this.idPing_;
				}
				else
				{
					idPingDefaultValue = MinimapMarkerInfoMessage.IdPingDefaultValue;
				}
				return idPingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.idPing_ = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000BD518 File Offset: 0x000BB718
		[DebuggerNonUserCode]
		public bool HasIdPing
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x000BD535 File Offset: 0x000BB735
		[DebuggerNonUserCode]
		public void ClearIdPing()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000BD548 File Offset: 0x000BB748
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x000BD579 File Offset: 0x000BB779
		[DebuggerNonUserCode]
		public float PosX
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float posXDefaultValue;
				if (flag)
				{
					posXDefaultValue = this.posX_;
				}
				else
				{
					posXDefaultValue = MinimapMarkerInfoMessage.PosXDefaultValue;
				}
				return posXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.posX_ = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000BD594 File Offset: 0x000BB794
		[DebuggerNonUserCode]
		public bool HasPosX
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x000BD5B1 File Offset: 0x000BB7B1
		[DebuggerNonUserCode]
		public void ClearPosX()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000BD5C4 File Offset: 0x000BB7C4
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x000BD5F5 File Offset: 0x000BB7F5
		[DebuggerNonUserCode]
		public float PosY
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float posYDefaultValue;
				if (flag)
				{
					posYDefaultValue = this.posY_;
				}
				else
				{
					posYDefaultValue = MinimapMarkerInfoMessage.PosYDefaultValue;
				}
				return posYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.posY_ = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000BD610 File Offset: 0x000BB810
		[DebuggerNonUserCode]
		public bool HasPosY
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000BD62D File Offset: 0x000BB82D
		[DebuggerNonUserCode]
		public void ClearPosY()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002FFE RID: 12286 RVA: 0x000BD640 File Offset: 0x000BB840
		// (set) Token: 0x06002FFF RID: 12287 RVA: 0x000BD672 File Offset: 0x000BB872
		[DebuggerNonUserCode]
		public float PosZ
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float posZDefaultValue;
				if (flag)
				{
					posZDefaultValue = this.posZ_;
				}
				else
				{
					posZDefaultValue = MinimapMarkerInfoMessage.PosZDefaultValue;
				}
				return posZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.posZ_ = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000BD68C File Offset: 0x000BB88C
		[DebuggerNonUserCode]
		public bool HasPosZ
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000BD6AA File Offset: 0x000BB8AA
		[DebuggerNonUserCode]
		public void ClearPosZ()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000BD6BC File Offset: 0x000BB8BC
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x000BD6F1 File Offset: 0x000BB8F1
		[DebuggerNonUserCode]
		public uint IdSworld
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				uint idSworldDefaultValue;
				if (flag)
				{
					idSworldDefaultValue = this.idSworld_;
				}
				else
				{
					idSworldDefaultValue = MinimapMarkerInfoMessage.IdSworldDefaultValue;
				}
				return idSworldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.idSworld_ = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000BD710 File Offset: 0x000BB910
		[DebuggerNonUserCode]
		public bool HasIdSworld
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x000BD731 File Offset: 0x000BB931
		[DebuggerNonUserCode]
		public void ClearIdSworld()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x000BD748 File Offset: 0x000BB948
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x000BD77A File Offset: 0x000BB97A
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = MinimapMarkerInfoMessage.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x000BD794 File Offset: 0x000BB994
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000BD7B2 File Offset: 0x000BB9B2
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x000BD7F9 File Offset: 0x000BB9F9
		[DebuggerNonUserCode]
		public int SnoLevelArea
		{
			get
			{
				bool flag = (this._hasBits0 & 33554432) != 0;
				int snoLevelAreaDefaultValue;
				if (flag)
				{
					snoLevelAreaDefaultValue = this.snoLevelArea_;
				}
				else
				{
					snoLevelAreaDefaultValue = MinimapMarkerInfoMessage.SnoLevelAreaDefaultValue;
				}
				return snoLevelAreaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 33554432;
				this.snoLevelArea_ = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x000BD818 File Offset: 0x000BBA18
		[DebuggerNonUserCode]
		public bool HasSnoLevelArea
		{
			get
			{
				return (this._hasBits0 & 33554432) != 0;
			}
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000BD839 File Offset: 0x000BBA39
		[DebuggerNonUserCode]
		public void ClearSnoLevelArea()
		{
			this._hasBits0 &= -33554433;
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x000BD850 File Offset: 0x000BBA50
		// (set) Token: 0x0600300F RID: 12303 RVA: 0x000BD882 File Offset: 0x000BBA82
		[DebuggerNonUserCode]
		public uint ImageHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint imageHandleDefaultValue;
				if (flag)
				{
					imageHandleDefaultValue = this.imageHandle_;
				}
				else
				{
					imageHandleDefaultValue = MinimapMarkerInfoMessage.ImageHandleDefaultValue;
				}
				return imageHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.imageHandle_ = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x000BD89C File Offset: 0x000BBA9C
		[DebuggerNonUserCode]
		public bool HasImageHandle
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000BD8BA File Offset: 0x000BBABA
		[DebuggerNonUserCode]
		public void ClearImageHandle()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000BD8CC File Offset: 0x000BBACC
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000BD901 File Offset: 0x000BBB01
		[DebuggerNonUserCode]
		public int SnoStringList
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int snoStringListDefaultValue;
				if (flag)
				{
					snoStringListDefaultValue = this.snoStringList_;
				}
				else
				{
					snoStringListDefaultValue = MinimapMarkerInfoMessage.SnoStringListDefaultValue;
				}
				return snoStringListDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.snoStringList_ = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000BD920 File Offset: 0x000BBB20
		[DebuggerNonUserCode]
		public bool HasSnoStringList
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000BD941 File Offset: 0x000BBB41
		[DebuggerNonUserCode]
		public void ClearSnoStringList()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x000BD958 File Offset: 0x000BBB58
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x000BD98D File Offset: 0x000BBB8D
		[DebuggerNonUserCode]
		public uint StringLabelHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint stringLabelHandleDefaultValue;
				if (flag)
				{
					stringLabelHandleDefaultValue = this.stringLabelHandle_;
				}
				else
				{
					stringLabelHandleDefaultValue = MinimapMarkerInfoMessage.StringLabelHandleDefaultValue;
				}
				return stringLabelHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.stringLabelHandle_ = value;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000BD9AC File Offset: 0x000BBBAC
		[DebuggerNonUserCode]
		public bool HasStringLabelHandle
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x000BD9CD File Offset: 0x000BBBCD
		[DebuggerNonUserCode]
		public void ClearStringLabelHandle()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000BD9E4 File Offset: 0x000BBBE4
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x000BDA19 File Offset: 0x000BBC19
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = MinimapMarkerInfoMessage.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.active_ = value;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000BDA38 File Offset: 0x000BBC38
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x000BDA59 File Offset: 0x000BBC59
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000BDA70 File Offset: 0x000BBC70
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x000BDAA5 File Offset: 0x000BBCA5
		[DebuggerNonUserCode]
		public bool RespectsFogOfWar
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool respectsFogOfWarDefaultValue;
				if (flag)
				{
					respectsFogOfWarDefaultValue = this.respectsFogOfWar_;
				}
				else
				{
					respectsFogOfWarDefaultValue = MinimapMarkerInfoMessage.RespectsFogOfWarDefaultValue;
				}
				return respectsFogOfWarDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.respectsFogOfWar_ = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000BDAC4 File Offset: 0x000BBCC4
		[DebuggerNonUserCode]
		public bool HasRespectsFogOfWar
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x000BDAE5 File Offset: 0x000BBCE5
		[DebuggerNonUserCode]
		public void ClearRespectsFogOfWar()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000BDAFC File Offset: 0x000BBCFC
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x000BDB31 File Offset: 0x000BBD31
		[DebuggerNonUserCode]
		public bool RespectsExploredArea
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				bool respectsExploredAreaDefaultValue;
				if (flag)
				{
					respectsExploredAreaDefaultValue = this.respectsExploredArea_;
				}
				else
				{
					respectsExploredAreaDefaultValue = MinimapMarkerInfoMessage.RespectsExploredAreaDefaultValue;
				}
				return respectsExploredAreaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.respectsExploredArea_ = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000BDB50 File Offset: 0x000BBD50
		[DebuggerNonUserCode]
		public bool HasRespectsExploredArea
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000BDB71 File Offset: 0x000BBD71
		[DebuggerNonUserCode]
		public void ClearRespectsExploredArea()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000BDB88 File Offset: 0x000BBD88
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000BDBBD File Offset: 0x000BBDBD
		[DebuggerNonUserCode]
		public bool IsPing
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool isPingDefaultValue;
				if (flag)
				{
					isPingDefaultValue = this.isPing_;
				}
				else
				{
					isPingDefaultValue = MinimapMarkerInfoMessage.IsPingDefaultValue;
				}
				return isPingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.isPing_ = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x000BDBDC File Offset: 0x000BBDDC
		[DebuggerNonUserCode]
		public bool HasIsPing
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000BDBFD File Offset: 0x000BBDFD
		[DebuggerNonUserCode]
		public void ClearIsPing()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x000BDC14 File Offset: 0x000BBE14
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x000BDC49 File Offset: 0x000BBE49
		[DebuggerNonUserCode]
		public bool UsesAreaRadius
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				bool usesAreaRadiusDefaultValue;
				if (flag)
				{
					usesAreaRadiusDefaultValue = this.usesAreaRadius_;
				}
				else
				{
					usesAreaRadiusDefaultValue = MinimapMarkerInfoMessage.UsesAreaRadiusDefaultValue;
				}
				return usesAreaRadiusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.usesAreaRadius_ = value;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x000BDC68 File Offset: 0x000BBE68
		[DebuggerNonUserCode]
		public bool HasUsesAreaRadius
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x000BDC89 File Offset: 0x000BBE89
		[DebuggerNonUserCode]
		public void ClearUsesAreaRadius()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x000BDCA0 File Offset: 0x000BBEA0
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x000BDCD5 File Offset: 0x000BBED5
		[DebuggerNonUserCode]
		public bool FromBakedData
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				bool fromBakedDataDefaultValue;
				if (flag)
				{
					fromBakedDataDefaultValue = this.fromBakedData_;
				}
				else
				{
					fromBakedDataDefaultValue = MinimapMarkerInfoMessage.FromBakedDataDefaultValue;
				}
				return fromBakedDataDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.fromBakedData_ = value;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x000BDCF4 File Offset: 0x000BBEF4
		[DebuggerNonUserCode]
		public bool HasFromBakedData
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000BDD15 File Offset: 0x000BBF15
		[DebuggerNonUserCode]
		public void ClearFromBakedData()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x000BDD2C File Offset: 0x000BBF2C
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x000BDD61 File Offset: 0x000BBF61
		[DebuggerNonUserCode]
		public bool IsDebugPing
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				bool isDebugPingDefaultValue;
				if (flag)
				{
					isDebugPingDefaultValue = this.isDebugPing_;
				}
				else
				{
					isDebugPingDefaultValue = MinimapMarkerInfoMessage.IsDebugPingDefaultValue;
				}
				return isDebugPingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.isDebugPing_ = value;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x000BDD80 File Offset: 0x000BBF80
		[DebuggerNonUserCode]
		public bool HasIsDebugPing
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000BDDA1 File Offset: 0x000BBFA1
		[DebuggerNonUserCode]
		public void ClearIsDebugPing()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x000BDDB8 File Offset: 0x000BBFB8
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x000BDDED File Offset: 0x000BBFED
		[DebuggerNonUserCode]
		public float MaxDisplayRangeSq
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				float maxDisplayRangeSqDefaultValue;
				if (flag)
				{
					maxDisplayRangeSqDefaultValue = this.maxDisplayRangeSq_;
				}
				else
				{
					maxDisplayRangeSqDefaultValue = MinimapMarkerInfoMessage.MaxDisplayRangeSqDefaultValue;
				}
				return maxDisplayRangeSqDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.maxDisplayRangeSq_ = value;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000BDE0C File Offset: 0x000BC00C
		[DebuggerNonUserCode]
		public bool HasMaxDisplayRangeSq
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000BDE2D File Offset: 0x000BC02D
		[DebuggerNonUserCode]
		public void ClearMaxDisplayRangeSq()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x000BDE44 File Offset: 0x000BC044
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x000BDE79 File Offset: 0x000BC079
		[DebuggerNonUserCode]
		public float DiscoverRangeSq
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				float discoverRangeSqDefaultValue;
				if (flag)
				{
					discoverRangeSqDefaultValue = this.discoverRangeSq_;
				}
				else
				{
					discoverRangeSqDefaultValue = MinimapMarkerInfoMessage.DiscoverRangeSqDefaultValue;
				}
				return discoverRangeSqDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.discoverRangeSq_ = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x000BDE98 File Offset: 0x000BC098
		[DebuggerNonUserCode]
		public bool HasDiscoverRangeSq
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000BDEB9 File Offset: 0x000BC0B9
		[DebuggerNonUserCode]
		public void ClearDiscoverRangeSq()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x000BDED0 File Offset: 0x000BC0D0
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x000BDF05 File Offset: 0x000BC105
		[DebuggerNonUserCode]
		public float QuestAreaRadius
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				float questAreaRadiusDefaultValue;
				if (flag)
				{
					questAreaRadiusDefaultValue = this.questAreaRadius_;
				}
				else
				{
					questAreaRadiusDefaultValue = MinimapMarkerInfoMessage.QuestAreaRadiusDefaultValue;
				}
				return questAreaRadiusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.questAreaRadius_ = value;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x000BDF24 File Offset: 0x000BC124
		[DebuggerNonUserCode]
		public bool HasQuestAreaRadius
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000BDF45 File Offset: 0x000BC145
		[DebuggerNonUserCode]
		public void ClearQuestAreaRadius()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x000BDF5C File Offset: 0x000BC15C
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x000BDF91 File Offset: 0x000BC191
		[DebuggerNonUserCode]
		public int SnoQuestSource
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				int snoQuestSourceDefaultValue;
				if (flag)
				{
					snoQuestSourceDefaultValue = this.snoQuestSource_;
				}
				else
				{
					snoQuestSourceDefaultValue = MinimapMarkerInfoMessage.SnoQuestSourceDefaultValue;
				}
				return snoQuestSourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.snoQuestSource_ = value;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x000BDFB0 File Offset: 0x000BC1B0
		[DebuggerNonUserCode]
		public bool HasSnoQuestSource
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000BDFD1 File Offset: 0x000BC1D1
		[DebuggerNonUserCode]
		public void ClearSnoQuestSource()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x000BDFE8 File Offset: 0x000BC1E8
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x000BE01D File Offset: 0x000BC21D
		[DebuggerNonUserCode]
		public uint QuestPhaseUid
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				uint questPhaseUidDefaultValue;
				if (flag)
				{
					questPhaseUidDefaultValue = this.questPhaseUid_;
				}
				else
				{
					questPhaseUidDefaultValue = MinimapMarkerInfoMessage.QuestPhaseUidDefaultValue;
				}
				return questPhaseUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.questPhaseUid_ = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x000BE03C File Offset: 0x000BC23C
		[DebuggerNonUserCode]
		public bool HasQuestPhaseUid
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000BE05D File Offset: 0x000BC25D
		[DebuggerNonUserCode]
		public void ClearQuestPhaseUid()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x000BE074 File Offset: 0x000BC274
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x000BE0A9 File Offset: 0x000BC2A9
		[DebuggerNonUserCode]
		public uint QuestCallbackUid
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				uint questCallbackUidDefaultValue;
				if (flag)
				{
					questCallbackUidDefaultValue = this.questCallbackUid_;
				}
				else
				{
					questCallbackUidDefaultValue = MinimapMarkerInfoMessage.QuestCallbackUidDefaultValue;
				}
				return questCallbackUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.questCallbackUid_ = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
		[DebuggerNonUserCode]
		public bool HasQuestCallbackUid
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000BE0E9 File Offset: 0x000BC2E9
		[DebuggerNonUserCode]
		public void ClearQuestCallbackUid()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x000BE100 File Offset: 0x000BC300
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x000BE135 File Offset: 0x000BC335
		[DebuggerNonUserCode]
		public int ServerMarkerType
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				int serverMarkerTypeDefaultValue;
				if (flag)
				{
					serverMarkerTypeDefaultValue = this.serverMarkerType_;
				}
				else
				{
					serverMarkerTypeDefaultValue = MinimapMarkerInfoMessage.ServerMarkerTypeDefaultValue;
				}
				return serverMarkerTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.serverMarkerType_ = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x000BE154 File Offset: 0x000BC354
		[DebuggerNonUserCode]
		public bool HasServerMarkerType
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000BE175 File Offset: 0x000BC375
		[DebuggerNonUserCode]
		public void ClearServerMarkerType()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x000BE18C File Offset: 0x000BC38C
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x000BE1C1 File Offset: 0x000BC3C1
		[DebuggerNonUserCode]
		public int SnoDestWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				int snoDestWorldDefaultValue;
				if (flag)
				{
					snoDestWorldDefaultValue = this.snoDestWorld_;
				}
				else
				{
					snoDestWorldDefaultValue = MinimapMarkerInfoMessage.SnoDestWorldDefaultValue;
				}
				return snoDestWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.snoDestWorld_ = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x000BE1E0 File Offset: 0x000BC3E0
		[DebuggerNonUserCode]
		public bool HasSnoDestWorld
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000BE201 File Offset: 0x000BC401
		[DebuggerNonUserCode]
		public void ClearSnoDestWorld()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x000BE218 File Offset: 0x000BC418
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x000BE230 File Offset: 0x000BC430
		[DebuggerNonUserCode]
		public PolygonRegion PolygonRegion
		{
			get
			{
				return this.polygonRegion_;
			}
			set
			{
				this.polygonRegion_ = value;
			}
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000BE23C File Offset: 0x000BC43C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MinimapMarkerInfoMessage);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000BE25C File Offset: 0x000BC45C
		[DebuggerNonUserCode]
		public bool Equals(MinimapMarkerInfoMessage other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IdPing != other.IdPing;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.IdSworld != other.IdSworld;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SnoWorld != other.SnoWorld;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SnoLevelArea != other.SnoLevelArea;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ImageHandle != other.ImageHandle;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SnoStringList != other.SnoStringList;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.StringLabelHandle != other.StringLabelHandle;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Active != other.Active;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.RespectsFogOfWar != other.RespectsFogOfWar;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.RespectsExploredArea != other.RespectsExploredArea;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.IsPing != other.IsPing;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.UsesAreaRadius != other.UsesAreaRadius;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.FromBakedData != other.FromBakedData;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.IsDebugPing != other.IsDebugPing;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxDisplayRangeSq, other.MaxDisplayRangeSq);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DiscoverRangeSq, other.DiscoverRangeSq);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.QuestAreaRadius, other.QuestAreaRadius);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.SnoQuestSource != other.SnoQuestSource;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.QuestPhaseUid != other.QuestPhaseUid;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.QuestCallbackUid != other.QuestCallbackUid;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.ServerMarkerType != other.ServerMarkerType;
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = this.SnoDestWorld != other.SnoDestWorld;
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = !object.Equals(this.PolygonRegion, other.PolygonRegion);
																															flag2 = !flag30 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600305A RID: 12378 RVA: 0x000BE5F0 File Offset: 0x000BC7F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasIdPing = this.HasIdPing;
			if (hasIdPing)
			{
				num ^= this.IdPing.GetHashCode();
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosZ);
			}
			bool hasIdSworld = this.HasIdSworld;
			if (hasIdSworld)
			{
				num ^= this.IdSworld.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				num ^= this.SnoLevelArea.GetHashCode();
			}
			bool hasImageHandle = this.HasImageHandle;
			if (hasImageHandle)
			{
				num ^= this.ImageHandle.GetHashCode();
			}
			bool hasSnoStringList = this.HasSnoStringList;
			if (hasSnoStringList)
			{
				num ^= this.SnoStringList.GetHashCode();
			}
			bool hasStringLabelHandle = this.HasStringLabelHandle;
			if (hasStringLabelHandle)
			{
				num ^= this.StringLabelHandle.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool hasRespectsFogOfWar = this.HasRespectsFogOfWar;
			if (hasRespectsFogOfWar)
			{
				num ^= this.RespectsFogOfWar.GetHashCode();
			}
			bool hasRespectsExploredArea = this.HasRespectsExploredArea;
			if (hasRespectsExploredArea)
			{
				num ^= this.RespectsExploredArea.GetHashCode();
			}
			bool hasIsPing = this.HasIsPing;
			if (hasIsPing)
			{
				num ^= this.IsPing.GetHashCode();
			}
			bool hasUsesAreaRadius = this.HasUsesAreaRadius;
			if (hasUsesAreaRadius)
			{
				num ^= this.UsesAreaRadius.GetHashCode();
			}
			bool hasFromBakedData = this.HasFromBakedData;
			if (hasFromBakedData)
			{
				num ^= this.FromBakedData.GetHashCode();
			}
			bool hasIsDebugPing = this.HasIsDebugPing;
			if (hasIsDebugPing)
			{
				num ^= this.IsDebugPing.GetHashCode();
			}
			bool hasMaxDisplayRangeSq = this.HasMaxDisplayRangeSq;
			if (hasMaxDisplayRangeSq)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxDisplayRangeSq);
			}
			bool hasDiscoverRangeSq = this.HasDiscoverRangeSq;
			if (hasDiscoverRangeSq)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DiscoverRangeSq);
			}
			bool hasQuestAreaRadius = this.HasQuestAreaRadius;
			if (hasQuestAreaRadius)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.QuestAreaRadius);
			}
			bool hasSnoQuestSource = this.HasSnoQuestSource;
			if (hasSnoQuestSource)
			{
				num ^= this.SnoQuestSource.GetHashCode();
			}
			bool hasQuestPhaseUid = this.HasQuestPhaseUid;
			if (hasQuestPhaseUid)
			{
				num ^= this.QuestPhaseUid.GetHashCode();
			}
			bool hasQuestCallbackUid = this.HasQuestCallbackUid;
			if (hasQuestCallbackUid)
			{
				num ^= this.QuestCallbackUid.GetHashCode();
			}
			bool hasServerMarkerType = this.HasServerMarkerType;
			if (hasServerMarkerType)
			{
				num ^= this.ServerMarkerType.GetHashCode();
			}
			bool hasSnoDestWorld = this.HasSnoDestWorld;
			if (hasSnoDestWorld)
			{
				num ^= this.SnoDestWorld.GetHashCode();
			}
			bool flag = this.polygonRegion_ != null;
			if (flag)
			{
				num ^= this.PolygonRegion.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000BE94C File Offset: 0x000BCB4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x000BE964 File Offset: 0x000BCB64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000BE970 File Offset: 0x000BCB70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasIdPing = this.HasIdPing;
			if (hasIdPing)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.IdPing);
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.PosZ);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool hasImageHandle = this.HasImageHandle;
			if (hasImageHandle)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ImageHandle);
			}
			bool hasSnoStringList = this.HasSnoStringList;
			if (hasSnoStringList)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.SnoStringList);
			}
			bool hasStringLabelHandle = this.HasStringLabelHandle;
			if (hasStringLabelHandle)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.StringLabelHandle);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Active);
			}
			bool hasRespectsFogOfWar = this.HasRespectsFogOfWar;
			if (hasRespectsFogOfWar)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.RespectsFogOfWar);
			}
			bool hasRespectsExploredArea = this.HasRespectsExploredArea;
			if (hasRespectsExploredArea)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.RespectsExploredArea);
			}
			bool hasIsPing = this.HasIsPing;
			if (hasIsPing)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsPing);
			}
			bool hasUsesAreaRadius = this.HasUsesAreaRadius;
			if (hasUsesAreaRadius)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.UsesAreaRadius);
			}
			bool hasFromBakedData = this.HasFromBakedData;
			if (hasFromBakedData)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.FromBakedData);
			}
			bool hasIsDebugPing = this.HasIsDebugPing;
			if (hasIsDebugPing)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.IsDebugPing);
			}
			bool hasMaxDisplayRangeSq = this.HasMaxDisplayRangeSq;
			if (hasMaxDisplayRangeSq)
			{
				output.WriteRawTag(149, 1);
				output.WriteFloat(this.MaxDisplayRangeSq);
			}
			bool hasDiscoverRangeSq = this.HasDiscoverRangeSq;
			if (hasDiscoverRangeSq)
			{
				output.WriteRawTag(157, 1);
				output.WriteFloat(this.DiscoverRangeSq);
			}
			bool hasQuestAreaRadius = this.HasQuestAreaRadius;
			if (hasQuestAreaRadius)
			{
				output.WriteRawTag(165, 1);
				output.WriteFloat(this.QuestAreaRadius);
			}
			bool hasSnoQuestSource = this.HasSnoQuestSource;
			if (hasSnoQuestSource)
			{
				output.WriteRawTag(181, 1);
				output.WriteSFixed32(this.SnoQuestSource);
			}
			bool hasQuestPhaseUid = this.HasQuestPhaseUid;
			if (hasQuestPhaseUid)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.QuestPhaseUid);
			}
			bool hasQuestCallbackUid = this.HasQuestCallbackUid;
			if (hasQuestCallbackUid)
			{
				output.WriteRawTag(192, 1);
				output.WriteUInt32(this.QuestCallbackUid);
			}
			bool hasServerMarkerType = this.HasServerMarkerType;
			if (hasServerMarkerType)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.ServerMarkerType);
			}
			bool hasSnoDestWorld = this.HasSnoDestWorld;
			if (hasSnoDestWorld)
			{
				output.WriteRawTag(213, 1);
				output.WriteSFixed32(this.SnoDestWorld);
			}
			bool flag = this.polygonRegion_ != null;
			if (flag)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.PolygonRegion);
			}
			bool hasIdSworld = this.HasIdSworld;
			if (hasIdSworld)
			{
				output.WriteRawTag(229, 1);
				output.WriteFixed32(this.IdSworld);
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				output.WriteRawTag(237, 1);
				output.WriteSFixed32(this.SnoLevelArea);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000BED98 File Offset: 0x000BCF98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasIdPing = this.HasIdPing;
			if (hasIdPing)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IdPing);
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num += 5;
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				num += 5;
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				num += 5;
			}
			bool hasIdSworld = this.HasIdSworld;
			if (hasIdSworld)
			{
				num += 6;
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				num += 6;
			}
			bool hasImageHandle = this.HasImageHandle;
			if (hasImageHandle)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ImageHandle);
			}
			bool hasSnoStringList = this.HasSnoStringList;
			if (hasSnoStringList)
			{
				num += 5;
			}
			bool hasStringLabelHandle = this.HasStringLabelHandle;
			if (hasStringLabelHandle)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StringLabelHandle);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num += 2;
			}
			bool hasRespectsFogOfWar = this.HasRespectsFogOfWar;
			if (hasRespectsFogOfWar)
			{
				num += 2;
			}
			bool hasRespectsExploredArea = this.HasRespectsExploredArea;
			if (hasRespectsExploredArea)
			{
				num += 2;
			}
			bool hasIsPing = this.HasIsPing;
			if (hasIsPing)
			{
				num += 2;
			}
			bool hasUsesAreaRadius = this.HasUsesAreaRadius;
			if (hasUsesAreaRadius)
			{
				num += 2;
			}
			bool hasFromBakedData = this.HasFromBakedData;
			if (hasFromBakedData)
			{
				num += 3;
			}
			bool hasIsDebugPing = this.HasIsDebugPing;
			if (hasIsDebugPing)
			{
				num += 3;
			}
			bool hasMaxDisplayRangeSq = this.HasMaxDisplayRangeSq;
			if (hasMaxDisplayRangeSq)
			{
				num += 6;
			}
			bool hasDiscoverRangeSq = this.HasDiscoverRangeSq;
			if (hasDiscoverRangeSq)
			{
				num += 6;
			}
			bool hasQuestAreaRadius = this.HasQuestAreaRadius;
			if (hasQuestAreaRadius)
			{
				num += 6;
			}
			bool hasSnoQuestSource = this.HasSnoQuestSource;
			if (hasSnoQuestSource)
			{
				num += 6;
			}
			bool hasQuestPhaseUid = this.HasQuestPhaseUid;
			if (hasQuestPhaseUid)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.QuestPhaseUid);
			}
			bool hasQuestCallbackUid = this.HasQuestCallbackUid;
			if (hasQuestCallbackUid)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.QuestCallbackUid);
			}
			bool hasServerMarkerType = this.HasServerMarkerType;
			if (hasServerMarkerType)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ServerMarkerType);
			}
			bool hasSnoDestWorld = this.HasSnoDestWorld;
			if (hasSnoDestWorld)
			{
				num += 6;
			}
			bool flag = this.polygonRegion_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PolygonRegion);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000BF014 File Offset: 0x000BD214
		[DebuggerNonUserCode]
		public void MergeFrom(MinimapMarkerInfoMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasIdPing = other.HasIdPing;
				if (hasIdPing)
				{
					this.IdPing = other.IdPing;
				}
				bool hasPosX = other.HasPosX;
				if (hasPosX)
				{
					this.PosX = other.PosX;
				}
				bool hasPosY = other.HasPosY;
				if (hasPosY)
				{
					this.PosY = other.PosY;
				}
				bool hasPosZ = other.HasPosZ;
				if (hasPosZ)
				{
					this.PosZ = other.PosZ;
				}
				bool hasIdSworld = other.HasIdSworld;
				if (hasIdSworld)
				{
					this.IdSworld = other.IdSworld;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasSnoLevelArea = other.HasSnoLevelArea;
				if (hasSnoLevelArea)
				{
					this.SnoLevelArea = other.SnoLevelArea;
				}
				bool hasImageHandle = other.HasImageHandle;
				if (hasImageHandle)
				{
					this.ImageHandle = other.ImageHandle;
				}
				bool hasSnoStringList = other.HasSnoStringList;
				if (hasSnoStringList)
				{
					this.SnoStringList = other.SnoStringList;
				}
				bool hasStringLabelHandle = other.HasStringLabelHandle;
				if (hasStringLabelHandle)
				{
					this.StringLabelHandle = other.StringLabelHandle;
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				bool hasRespectsFogOfWar = other.HasRespectsFogOfWar;
				if (hasRespectsFogOfWar)
				{
					this.RespectsFogOfWar = other.RespectsFogOfWar;
				}
				bool hasRespectsExploredArea = other.HasRespectsExploredArea;
				if (hasRespectsExploredArea)
				{
					this.RespectsExploredArea = other.RespectsExploredArea;
				}
				bool hasIsPing = other.HasIsPing;
				if (hasIsPing)
				{
					this.IsPing = other.IsPing;
				}
				bool hasUsesAreaRadius = other.HasUsesAreaRadius;
				if (hasUsesAreaRadius)
				{
					this.UsesAreaRadius = other.UsesAreaRadius;
				}
				bool hasFromBakedData = other.HasFromBakedData;
				if (hasFromBakedData)
				{
					this.FromBakedData = other.FromBakedData;
				}
				bool hasIsDebugPing = other.HasIsDebugPing;
				if (hasIsDebugPing)
				{
					this.IsDebugPing = other.IsDebugPing;
				}
				bool hasMaxDisplayRangeSq = other.HasMaxDisplayRangeSq;
				if (hasMaxDisplayRangeSq)
				{
					this.MaxDisplayRangeSq = other.MaxDisplayRangeSq;
				}
				bool hasDiscoverRangeSq = other.HasDiscoverRangeSq;
				if (hasDiscoverRangeSq)
				{
					this.DiscoverRangeSq = other.DiscoverRangeSq;
				}
				bool hasQuestAreaRadius = other.HasQuestAreaRadius;
				if (hasQuestAreaRadius)
				{
					this.QuestAreaRadius = other.QuestAreaRadius;
				}
				bool hasSnoQuestSource = other.HasSnoQuestSource;
				if (hasSnoQuestSource)
				{
					this.SnoQuestSource = other.SnoQuestSource;
				}
				bool hasQuestPhaseUid = other.HasQuestPhaseUid;
				if (hasQuestPhaseUid)
				{
					this.QuestPhaseUid = other.QuestPhaseUid;
				}
				bool hasQuestCallbackUid = other.HasQuestCallbackUid;
				if (hasQuestCallbackUid)
				{
					this.QuestCallbackUid = other.QuestCallbackUid;
				}
				bool hasServerMarkerType = other.HasServerMarkerType;
				if (hasServerMarkerType)
				{
					this.ServerMarkerType = other.ServerMarkerType;
				}
				bool hasSnoDestWorld = other.HasSnoDestWorld;
				if (hasSnoDestWorld)
				{
					this.SnoDestWorld = other.SnoDestWorld;
				}
				bool flag2 = other.polygonRegion_ != null;
				if (flag2)
				{
					bool flag3 = this.polygonRegion_ == null;
					if (flag3)
					{
						this.PolygonRegion = new PolygonRegion();
					}
					this.PolygonRegion.MergeFrom(other.PolygonRegion);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000BF33F File Offset: 0x000BD53F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000BF34C File Offset: 0x000BD54C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 112U)
				{
					if (num3 <= 61U)
					{
						if (num3 <= 37U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 37U)
									{
										goto IL_0198;
									}
									this.PosX = input.ReadFloat();
								}
								else
								{
									this.IdPing = input.ReadUInt32();
								}
							}
							else
							{
								this.GameAccountId = input.ReadUInt32();
							}
						}
						else if (num3 != 45U)
						{
							if (num3 != 53U)
							{
								if (num3 != 61U)
								{
									goto IL_0198;
								}
								this.SnoWorld = input.ReadSFixed32();
							}
							else
							{
								this.PosZ = input.ReadFloat();
							}
						}
						else
						{
							this.PosY = input.ReadFloat();
						}
					}
					else if (num3 <= 80U)
					{
						if (num3 != 64U)
						{
							if (num3 != 77U)
							{
								if (num3 != 80U)
								{
									goto IL_0198;
								}
								this.StringLabelHandle = input.ReadUInt32();
							}
							else
							{
								this.SnoStringList = input.ReadSFixed32();
							}
						}
						else
						{
							this.ImageHandle = input.ReadUInt32();
						}
					}
					else if (num3 <= 96U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_0198;
							}
							this.RespectsFogOfWar = input.ReadBool();
						}
						else
						{
							this.Active = input.ReadBool();
						}
					}
					else if (num3 != 104U)
					{
						if (num3 != 112U)
						{
							goto IL_0198;
						}
						this.IsPing = input.ReadBool();
					}
					else
					{
						this.RespectsExploredArea = input.ReadBool();
					}
				}
				else if (num3 <= 181U)
				{
					if (num3 <= 136U)
					{
						if (num3 != 120U)
						{
							if (num3 != 128U)
							{
								if (num3 != 136U)
								{
									goto IL_0198;
								}
								this.IsDebugPing = input.ReadBool();
							}
							else
							{
								this.FromBakedData = input.ReadBool();
							}
						}
						else
						{
							this.UsesAreaRadius = input.ReadBool();
						}
					}
					else if (num3 <= 157U)
					{
						if (num3 != 149U)
						{
							if (num3 != 157U)
							{
								goto IL_0198;
							}
							this.DiscoverRangeSq = input.ReadFloat();
						}
						else
						{
							this.MaxDisplayRangeSq = input.ReadFloat();
						}
					}
					else if (num3 != 165U)
					{
						if (num3 != 181U)
						{
							goto IL_0198;
						}
						this.SnoQuestSource = input.ReadSFixed32();
					}
					else
					{
						this.QuestAreaRadius = input.ReadFloat();
					}
				}
				else if (num3 <= 200U)
				{
					if (num3 != 184U)
					{
						if (num3 != 192U)
						{
							if (num3 != 200U)
							{
								goto IL_0198;
							}
							this.ServerMarkerType = input.ReadInt32();
						}
						else
						{
							this.QuestCallbackUid = input.ReadUInt32();
						}
					}
					else
					{
						this.QuestPhaseUid = input.ReadUInt32();
					}
				}
				else if (num3 <= 218U)
				{
					if (num3 != 213U)
					{
						if (num3 != 218U)
						{
							goto IL_0198;
						}
						bool flag = this.polygonRegion_ == null;
						if (flag)
						{
							this.PolygonRegion = new PolygonRegion();
						}
						input.ReadMessage(this.PolygonRegion);
					}
					else
					{
						this.SnoDestWorld = input.ReadSFixed32();
					}
				}
				else if (num3 != 229U)
				{
					if (num3 != 237U)
					{
						goto IL_0198;
					}
					this.SnoLevelArea = input.ReadSFixed32();
				}
				else
				{
					this.IdSworld = input.ReadFixed32();
				}
				continue;
				IL_0198:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040015B8 RID: 5560
		private static readonly MessageParser<MinimapMarkerInfoMessage> _parser = new MessageParser<MinimapMarkerInfoMessage>(() => new MinimapMarkerInfoMessage());

		// Token: 0x040015B9 RID: 5561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015BA RID: 5562
		private int _hasBits0;

		// Token: 0x040015BB RID: 5563
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040015BC RID: 5564
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040015BD RID: 5565
		private uint gameAccountId_;

		// Token: 0x040015BE RID: 5566
		public const int IdPingFieldNumber = 2;

		// Token: 0x040015BF RID: 5567
		private static readonly uint IdPingDefaultValue = 0U;

		// Token: 0x040015C0 RID: 5568
		private uint idPing_;

		// Token: 0x040015C1 RID: 5569
		public const int PosXFieldNumber = 4;

		// Token: 0x040015C2 RID: 5570
		private static readonly float PosXDefaultValue = 0f;

		// Token: 0x040015C3 RID: 5571
		private float posX_;

		// Token: 0x040015C4 RID: 5572
		public const int PosYFieldNumber = 5;

		// Token: 0x040015C5 RID: 5573
		private static readonly float PosYDefaultValue = 0f;

		// Token: 0x040015C6 RID: 5574
		private float posY_;

		// Token: 0x040015C7 RID: 5575
		public const int PosZFieldNumber = 6;

		// Token: 0x040015C8 RID: 5576
		private static readonly float PosZDefaultValue = 0f;

		// Token: 0x040015C9 RID: 5577
		private float posZ_;

		// Token: 0x040015CA RID: 5578
		public const int IdSworldFieldNumber = 28;

		// Token: 0x040015CB RID: 5579
		private static readonly uint IdSworldDefaultValue = 0U;

		// Token: 0x040015CC RID: 5580
		private uint idSworld_;

		// Token: 0x040015CD RID: 5581
		public const int SnoWorldFieldNumber = 7;

		// Token: 0x040015CE RID: 5582
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x040015CF RID: 5583
		private int snoWorld_;

		// Token: 0x040015D0 RID: 5584
		public const int SnoLevelAreaFieldNumber = 29;

		// Token: 0x040015D1 RID: 5585
		private static readonly int SnoLevelAreaDefaultValue = 0;

		// Token: 0x040015D2 RID: 5586
		private int snoLevelArea_;

		// Token: 0x040015D3 RID: 5587
		public const int ImageHandleFieldNumber = 8;

		// Token: 0x040015D4 RID: 5588
		private static readonly uint ImageHandleDefaultValue = 0U;

		// Token: 0x040015D5 RID: 5589
		private uint imageHandle_;

		// Token: 0x040015D6 RID: 5590
		public const int SnoStringListFieldNumber = 9;

		// Token: 0x040015D7 RID: 5591
		private static readonly int SnoStringListDefaultValue = 0;

		// Token: 0x040015D8 RID: 5592
		private int snoStringList_;

		// Token: 0x040015D9 RID: 5593
		public const int StringLabelHandleFieldNumber = 10;

		// Token: 0x040015DA RID: 5594
		private static readonly uint StringLabelHandleDefaultValue = 0U;

		// Token: 0x040015DB RID: 5595
		private uint stringLabelHandle_;

		// Token: 0x040015DC RID: 5596
		public const int ActiveFieldNumber = 11;

		// Token: 0x040015DD RID: 5597
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x040015DE RID: 5598
		private bool active_;

		// Token: 0x040015DF RID: 5599
		public const int RespectsFogOfWarFieldNumber = 12;

		// Token: 0x040015E0 RID: 5600
		private static readonly bool RespectsFogOfWarDefaultValue = false;

		// Token: 0x040015E1 RID: 5601
		private bool respectsFogOfWar_;

		// Token: 0x040015E2 RID: 5602
		public const int RespectsExploredAreaFieldNumber = 13;

		// Token: 0x040015E3 RID: 5603
		private static readonly bool RespectsExploredAreaDefaultValue = false;

		// Token: 0x040015E4 RID: 5604
		private bool respectsExploredArea_;

		// Token: 0x040015E5 RID: 5605
		public const int IsPingFieldNumber = 14;

		// Token: 0x040015E6 RID: 5606
		private static readonly bool IsPingDefaultValue = false;

		// Token: 0x040015E7 RID: 5607
		private bool isPing_;

		// Token: 0x040015E8 RID: 5608
		public const int UsesAreaRadiusFieldNumber = 15;

		// Token: 0x040015E9 RID: 5609
		private static readonly bool UsesAreaRadiusDefaultValue = false;

		// Token: 0x040015EA RID: 5610
		private bool usesAreaRadius_;

		// Token: 0x040015EB RID: 5611
		public const int FromBakedDataFieldNumber = 16;

		// Token: 0x040015EC RID: 5612
		private static readonly bool FromBakedDataDefaultValue = false;

		// Token: 0x040015ED RID: 5613
		private bool fromBakedData_;

		// Token: 0x040015EE RID: 5614
		public const int IsDebugPingFieldNumber = 17;

		// Token: 0x040015EF RID: 5615
		private static readonly bool IsDebugPingDefaultValue = false;

		// Token: 0x040015F0 RID: 5616
		private bool isDebugPing_;

		// Token: 0x040015F1 RID: 5617
		public const int MaxDisplayRangeSqFieldNumber = 18;

		// Token: 0x040015F2 RID: 5618
		private static readonly float MaxDisplayRangeSqDefaultValue = 0f;

		// Token: 0x040015F3 RID: 5619
		private float maxDisplayRangeSq_;

		// Token: 0x040015F4 RID: 5620
		public const int DiscoverRangeSqFieldNumber = 19;

		// Token: 0x040015F5 RID: 5621
		private static readonly float DiscoverRangeSqDefaultValue = 0f;

		// Token: 0x040015F6 RID: 5622
		private float discoverRangeSq_;

		// Token: 0x040015F7 RID: 5623
		public const int QuestAreaRadiusFieldNumber = 20;

		// Token: 0x040015F8 RID: 5624
		private static readonly float QuestAreaRadiusDefaultValue = 0f;

		// Token: 0x040015F9 RID: 5625
		private float questAreaRadius_;

		// Token: 0x040015FA RID: 5626
		public const int SnoQuestSourceFieldNumber = 22;

		// Token: 0x040015FB RID: 5627
		private static readonly int SnoQuestSourceDefaultValue = 0;

		// Token: 0x040015FC RID: 5628
		private int snoQuestSource_;

		// Token: 0x040015FD RID: 5629
		public const int QuestPhaseUidFieldNumber = 23;

		// Token: 0x040015FE RID: 5630
		private static readonly uint QuestPhaseUidDefaultValue = 0U;

		// Token: 0x040015FF RID: 5631
		private uint questPhaseUid_;

		// Token: 0x04001600 RID: 5632
		public const int QuestCallbackUidFieldNumber = 24;

		// Token: 0x04001601 RID: 5633
		private static readonly uint QuestCallbackUidDefaultValue = 0U;

		// Token: 0x04001602 RID: 5634
		private uint questCallbackUid_;

		// Token: 0x04001603 RID: 5635
		public const int ServerMarkerTypeFieldNumber = 25;

		// Token: 0x04001604 RID: 5636
		private static readonly int ServerMarkerTypeDefaultValue = 0;

		// Token: 0x04001605 RID: 5637
		private int serverMarkerType_;

		// Token: 0x04001606 RID: 5638
		public const int SnoDestWorldFieldNumber = 26;

		// Token: 0x04001607 RID: 5639
		private static readonly int SnoDestWorldDefaultValue = 0;

		// Token: 0x04001608 RID: 5640
		private int snoDestWorld_;

		// Token: 0x04001609 RID: 5641
		public const int PolygonRegionFieldNumber = 27;

		// Token: 0x0400160A RID: 5642
		private PolygonRegion polygonRegion_;
	}
}
