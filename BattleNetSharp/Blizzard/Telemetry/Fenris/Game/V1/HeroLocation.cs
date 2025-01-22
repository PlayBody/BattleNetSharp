using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002EE RID: 750
	public sealed class HeroLocation : IMessage<HeroLocation>, IMessage, IEquatable<HeroLocation>, IDeepCloneable<HeroLocation>, IBufferMessage
	{
		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x0012FB5C File Offset: 0x0012DD5C
		[DebuggerNonUserCode]
		public static MessageParser<HeroLocation> Parser
		{
			get
			{
				return HeroLocation._parser;
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0012FB74 File Offset: 0x0012DD74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroLocationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x0012FB98 File Offset: 0x0012DD98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroLocation.Descriptor;
			}
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0012FBAF File Offset: 0x0012DDAF
		[DebuggerNonUserCode]
		public HeroLocation()
		{
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x0012FBBC File Offset: 0x0012DDBC
		[DebuggerNonUserCode]
		public HeroLocation(HeroLocation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.worldSno_ = other.worldSno_;
			this.worldX_ = other.worldX_;
			this.worldY_ = other.worldY_;
			this.worldZ_ = other.worldZ_;
			this.sceneSno_ = other.sceneSno_;
			this.sceneX_ = other.sceneX_;
			this.sceneY_ = other.sceneY_;
			this.sceneZ_ = other.sceneZ_;
			this.subzoneSno_ = other.subzoneSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x0012FC5C File Offset: 0x0012DE5C
		[DebuggerNonUserCode]
		public HeroLocation Clone()
		{
			return new HeroLocation(this);
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x0012FC74 File Offset: 0x0012DE74
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x0012FCA5 File Offset: 0x0012DEA5
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
					worldSnoDefaultValue = HeroLocation.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x0012FCC0 File Offset: 0x0012DEC0
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0012FCDD File Offset: 0x0012DEDD
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x0012FCF0 File Offset: 0x0012DEF0
		// (set) Token: 0x06004F29 RID: 20265 RVA: 0x0012FD21 File Offset: 0x0012DF21
		[DebuggerNonUserCode]
		public float WorldX
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float worldXDefaultValue;
				if (flag)
				{
					worldXDefaultValue = this.worldX_;
				}
				else
				{
					worldXDefaultValue = HeroLocation.WorldXDefaultValue;
				}
				return worldXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.worldX_ = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06004F2A RID: 20266 RVA: 0x0012FD3C File Offset: 0x0012DF3C
		[DebuggerNonUserCode]
		public bool HasWorldX
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x0012FD59 File Offset: 0x0012DF59
		[DebuggerNonUserCode]
		public void ClearWorldX()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06004F2C RID: 20268 RVA: 0x0012FD6C File Offset: 0x0012DF6C
		// (set) Token: 0x06004F2D RID: 20269 RVA: 0x0012FD9D File Offset: 0x0012DF9D
		[DebuggerNonUserCode]
		public float WorldY
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float worldYDefaultValue;
				if (flag)
				{
					worldYDefaultValue = this.worldY_;
				}
				else
				{
					worldYDefaultValue = HeroLocation.WorldYDefaultValue;
				}
				return worldYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.worldY_ = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06004F2E RID: 20270 RVA: 0x0012FDB8 File Offset: 0x0012DFB8
		[DebuggerNonUserCode]
		public bool HasWorldY
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x0012FDD5 File Offset: 0x0012DFD5
		[DebuggerNonUserCode]
		public void ClearWorldY()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x0012FDE8 File Offset: 0x0012DFE8
		// (set) Token: 0x06004F31 RID: 20273 RVA: 0x0012FE19 File Offset: 0x0012E019
		[DebuggerNonUserCode]
		public float WorldZ
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float worldZDefaultValue;
				if (flag)
				{
					worldZDefaultValue = this.worldZ_;
				}
				else
				{
					worldZDefaultValue = HeroLocation.WorldZDefaultValue;
				}
				return worldZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.worldZ_ = value;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x0012FE34 File Offset: 0x0012E034
		[DebuggerNonUserCode]
		public bool HasWorldZ
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x0012FE51 File Offset: 0x0012E051
		[DebuggerNonUserCode]
		public void ClearWorldZ()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x0012FE64 File Offset: 0x0012E064
		// (set) Token: 0x06004F35 RID: 20277 RVA: 0x0012FE96 File Offset: 0x0012E096
		[DebuggerNonUserCode]
		public int SceneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int sceneSnoDefaultValue;
				if (flag)
				{
					sceneSnoDefaultValue = this.sceneSno_;
				}
				else
				{
					sceneSnoDefaultValue = HeroLocation.SceneSnoDefaultValue;
				}
				return sceneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.sceneSno_ = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x0012FEB0 File Offset: 0x0012E0B0
		[DebuggerNonUserCode]
		public bool HasSceneSno
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x0012FECE File Offset: 0x0012E0CE
		[DebuggerNonUserCode]
		public void ClearSceneSno()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x0012FEE0 File Offset: 0x0012E0E0
		// (set) Token: 0x06004F39 RID: 20281 RVA: 0x0012FF12 File Offset: 0x0012E112
		[DebuggerNonUserCode]
		public float SceneX
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				float sceneXDefaultValue;
				if (flag)
				{
					sceneXDefaultValue = this.sceneX_;
				}
				else
				{
					sceneXDefaultValue = HeroLocation.SceneXDefaultValue;
				}
				return sceneXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.sceneX_ = value;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x0012FF2C File Offset: 0x0012E12C
		[DebuggerNonUserCode]
		public bool HasSceneX
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x0012FF4A File Offset: 0x0012E14A
		[DebuggerNonUserCode]
		public void ClearSceneX()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x0012FF5C File Offset: 0x0012E15C
		// (set) Token: 0x06004F3D RID: 20285 RVA: 0x0012FF8E File Offset: 0x0012E18E
		[DebuggerNonUserCode]
		public float SceneY
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				float sceneYDefaultValue;
				if (flag)
				{
					sceneYDefaultValue = this.sceneY_;
				}
				else
				{
					sceneYDefaultValue = HeroLocation.SceneYDefaultValue;
				}
				return sceneYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.sceneY_ = value;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x0012FFA8 File Offset: 0x0012E1A8
		[DebuggerNonUserCode]
		public bool HasSceneY
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x0012FFC6 File Offset: 0x0012E1C6
		[DebuggerNonUserCode]
		public void ClearSceneY()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x0012FFD8 File Offset: 0x0012E1D8
		// (set) Token: 0x06004F41 RID: 20289 RVA: 0x0013000D File Offset: 0x0012E20D
		[DebuggerNonUserCode]
		public float SceneZ
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				float sceneZDefaultValue;
				if (flag)
				{
					sceneZDefaultValue = this.sceneZ_;
				}
				else
				{
					sceneZDefaultValue = HeroLocation.SceneZDefaultValue;
				}
				return sceneZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.sceneZ_ = value;
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06004F42 RID: 20290 RVA: 0x0013002C File Offset: 0x0012E22C
		[DebuggerNonUserCode]
		public bool HasSceneZ
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0013004D File Offset: 0x0012E24D
		[DebuggerNonUserCode]
		public void ClearSceneZ()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x00130064 File Offset: 0x0012E264
		// (set) Token: 0x06004F45 RID: 20293 RVA: 0x00130099 File Offset: 0x0012E299
		[DebuggerNonUserCode]
		public int SubzoneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int subzoneSnoDefaultValue;
				if (flag)
				{
					subzoneSnoDefaultValue = this.subzoneSno_;
				}
				else
				{
					subzoneSnoDefaultValue = HeroLocation.SubzoneSnoDefaultValue;
				}
				return subzoneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.subzoneSno_ = value;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x001300B8 File Offset: 0x0012E2B8
		[DebuggerNonUserCode]
		public bool HasSubzoneSno
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x001300D9 File Offset: 0x0012E2D9
		[DebuggerNonUserCode]
		public void ClearSubzoneSno()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x001300F0 File Offset: 0x0012E2F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroLocation);
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00130110 File Offset: 0x0012E310
		[DebuggerNonUserCode]
		public bool Equals(HeroLocation other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WorldX, other.WorldX);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WorldY, other.WorldY);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WorldZ, other.WorldZ);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SceneSno != other.SceneSno;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SceneX, other.SceneX);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SceneY, other.SceneY);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SceneZ, other.SceneZ);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SubzoneSno != other.SubzoneSno;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06004F4A RID: 20298 RVA: 0x00130284 File Offset: 0x0012E484
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool hasWorldX = this.HasWorldX;
			if (hasWorldX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.WorldX);
			}
			bool hasWorldY = this.HasWorldY;
			if (hasWorldY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.WorldY);
			}
			bool hasWorldZ = this.HasWorldZ;
			if (hasWorldZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.WorldZ);
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				num ^= this.SceneSno.GetHashCode();
			}
			bool hasSceneX = this.HasSceneX;
			if (hasSceneX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SceneX);
			}
			bool hasSceneY = this.HasSceneY;
			if (hasSceneY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SceneY);
			}
			bool hasSceneZ = this.HasSceneZ;
			if (hasSceneZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SceneZ);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num ^= this.SubzoneSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x001303C8 File Offset: 0x0012E5C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x001303E0 File Offset: 0x0012E5E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x001303EC File Offset: 0x0012E5EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.WorldSno);
			}
			bool hasWorldX = this.HasWorldX;
			if (hasWorldX)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.WorldX);
			}
			bool hasWorldY = this.HasWorldY;
			if (hasWorldY)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.WorldY);
			}
			bool hasWorldZ = this.HasWorldZ;
			if (hasWorldZ)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.WorldZ);
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				output.WriteRawTag(40);
				output.WriteSInt32(this.SceneSno);
			}
			bool hasSceneX = this.HasSceneX;
			if (hasSceneX)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.SceneX);
			}
			bool hasSceneY = this.HasSceneY;
			if (hasSceneY)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.SceneY);
			}
			bool hasSceneZ = this.HasSceneZ;
			if (hasSceneZ)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.SceneZ);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				output.WriteRawTag(72);
				output.WriteSInt32(this.SubzoneSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x00130554 File Offset: 0x0012E754
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldSno);
			}
			bool hasWorldX = this.HasWorldX;
			if (hasWorldX)
			{
				num += 5;
			}
			bool hasWorldY = this.HasWorldY;
			if (hasWorldY)
			{
				num += 5;
			}
			bool hasWorldZ = this.HasWorldZ;
			if (hasWorldZ)
			{
				num += 5;
			}
			bool hasSceneSno = this.HasSceneSno;
			if (hasSceneSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SceneSno);
			}
			bool hasSceneX = this.HasSceneX;
			if (hasSceneX)
			{
				num += 5;
			}
			bool hasSceneY = this.HasSceneY;
			if (hasSceneY)
			{
				num += 5;
			}
			bool hasSceneZ = this.HasSceneZ;
			if (hasSceneZ)
			{
				num += 5;
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SubzoneSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x0013064C File Offset: 0x0012E84C
		[DebuggerNonUserCode]
		public void MergeFrom(HeroLocation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				bool hasWorldX = other.HasWorldX;
				if (hasWorldX)
				{
					this.WorldX = other.WorldX;
				}
				bool hasWorldY = other.HasWorldY;
				if (hasWorldY)
				{
					this.WorldY = other.WorldY;
				}
				bool hasWorldZ = other.HasWorldZ;
				if (hasWorldZ)
				{
					this.WorldZ = other.WorldZ;
				}
				bool hasSceneSno = other.HasSceneSno;
				if (hasSceneSno)
				{
					this.SceneSno = other.SceneSno;
				}
				bool hasSceneX = other.HasSceneX;
				if (hasSceneX)
				{
					this.SceneX = other.SceneX;
				}
				bool hasSceneY = other.HasSceneY;
				if (hasSceneY)
				{
					this.SceneY = other.SceneY;
				}
				bool hasSceneZ = other.HasSceneZ;
				if (hasSceneZ)
				{
					this.SceneZ = other.SceneZ;
				}
				bool hasSubzoneSno = other.HasSubzoneSno;
				if (hasSubzoneSno)
				{
					this.SubzoneSno = other.SubzoneSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x0013076C File Offset: 0x0012E96C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x00130778 File Offset: 0x0012E978
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 37U)
				{
					if (num3 <= 21U)
					{
						if (num3 != 8U)
						{
							if (num3 != 21U)
							{
								goto IL_006A;
							}
							this.WorldX = input.ReadFloat();
						}
						else
						{
							this.WorldSno = input.ReadSInt32();
						}
					}
					else if (num3 != 29U)
					{
						if (num3 != 37U)
						{
							goto IL_006A;
						}
						this.WorldZ = input.ReadFloat();
					}
					else
					{
						this.WorldY = input.ReadFloat();
					}
				}
				else if (num3 <= 53U)
				{
					if (num3 != 40U)
					{
						if (num3 != 53U)
						{
							goto IL_006A;
						}
						this.SceneX = input.ReadFloat();
					}
					else
					{
						this.SceneSno = input.ReadSInt32();
					}
				}
				else if (num3 != 61U)
				{
					if (num3 != 69U)
					{
						if (num3 != 72U)
						{
							goto IL_006A;
						}
						this.SubzoneSno = input.ReadSInt32();
					}
					else
					{
						this.SceneZ = input.ReadFloat();
					}
				}
				else
				{
					this.SceneY = input.ReadFloat();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400237D RID: 9085
		private static readonly MessageParser<HeroLocation> _parser = new MessageParser<HeroLocation>(() => new HeroLocation());

		// Token: 0x0400237E RID: 9086
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400237F RID: 9087
		private int _hasBits0;

		// Token: 0x04002380 RID: 9088
		public const int WorldSnoFieldNumber = 1;

		// Token: 0x04002381 RID: 9089
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x04002382 RID: 9090
		private int worldSno_;

		// Token: 0x04002383 RID: 9091
		public const int WorldXFieldNumber = 2;

		// Token: 0x04002384 RID: 9092
		private static readonly float WorldXDefaultValue = 0f;

		// Token: 0x04002385 RID: 9093
		private float worldX_;

		// Token: 0x04002386 RID: 9094
		public const int WorldYFieldNumber = 3;

		// Token: 0x04002387 RID: 9095
		private static readonly float WorldYDefaultValue = 0f;

		// Token: 0x04002388 RID: 9096
		private float worldY_;

		// Token: 0x04002389 RID: 9097
		public const int WorldZFieldNumber = 4;

		// Token: 0x0400238A RID: 9098
		private static readonly float WorldZDefaultValue = 0f;

		// Token: 0x0400238B RID: 9099
		private float worldZ_;

		// Token: 0x0400238C RID: 9100
		public const int SceneSnoFieldNumber = 5;

		// Token: 0x0400238D RID: 9101
		private static readonly int SceneSnoDefaultValue = 0;

		// Token: 0x0400238E RID: 9102
		private int sceneSno_;

		// Token: 0x0400238F RID: 9103
		public const int SceneXFieldNumber = 6;

		// Token: 0x04002390 RID: 9104
		private static readonly float SceneXDefaultValue = 0f;

		// Token: 0x04002391 RID: 9105
		private float sceneX_;

		// Token: 0x04002392 RID: 9106
		public const int SceneYFieldNumber = 7;

		// Token: 0x04002393 RID: 9107
		private static readonly float SceneYDefaultValue = 0f;

		// Token: 0x04002394 RID: 9108
		private float sceneY_;

		// Token: 0x04002395 RID: 9109
		public const int SceneZFieldNumber = 8;

		// Token: 0x04002396 RID: 9110
		private static readonly float SceneZDefaultValue = 0f;

		// Token: 0x04002397 RID: 9111
		private float sceneZ_;

		// Token: 0x04002398 RID: 9112
		public const int SubzoneSnoFieldNumber = 9;

		// Token: 0x04002399 RID: 9113
		private static readonly int SubzoneSnoDefaultValue = 0;

		// Token: 0x0400239A RID: 9114
		private int subzoneSno_;
	}
}
