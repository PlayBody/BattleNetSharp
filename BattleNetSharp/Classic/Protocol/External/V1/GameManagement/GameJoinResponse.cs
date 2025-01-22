using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000792 RID: 1938
	public sealed class GameJoinResponse : IMessage<GameJoinResponse>, IMessage, IEquatable<GameJoinResponse>, IDeepCloneable<GameJoinResponse>, IBufferMessage
	{
		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600B1D3 RID: 45523 RVA: 0x002B4828 File Offset: 0x002B2A28
		[DebuggerNonUserCode]
		public static MessageParser<GameJoinResponse> Parser
		{
			get
			{
				return GameJoinResponse._parser;
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x002B4840 File Offset: 0x002B2A40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x002B4864 File Offset: 0x002B2A64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameJoinResponse.Descriptor;
			}
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x002B487B File Offset: 0x002B2A7B
		[DebuggerNonUserCode]
		public GameJoinResponse()
		{
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x002B4888 File Offset: 0x002B2A88
		[DebuggerNonUserCode]
		public GameJoinResponse(GameJoinResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ipAddress_ = other.ipAddress_;
			this.port_ = other.port_;
			this.hash_ = other.hash_;
			this.id_ = other.id_;
			this.serverGitVersion_ = other.serverGitVersion_;
			this.oneOrZero_ = other.oneOrZero_;
			this.fiftytwo0004_ = other.fiftytwo0004_;
			this.one2_ = other.one2_;
			this.maxLevel_ = other.maxLevel_;
			this.region_ = other.region_;
			this.zero_ = other.zero_;
			this.maxPlayers_ = other.maxPlayers_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x002B494C File Offset: 0x002B2B4C
		[DebuggerNonUserCode]
		public GameJoinResponse Clone()
		{
			return new GameJoinResponse(this);
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x002B4964 File Offset: 0x002B2B64
		// (set) Token: 0x0600B1DA RID: 45530 RVA: 0x002B4985 File Offset: 0x002B2B85
		[DebuggerNonUserCode]
		public string IpAddress
		{
			get
			{
				return this.ipAddress_ ?? GameJoinResponse.IpAddressDefaultValue;
			}
			set
			{
				this.ipAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600B1DB RID: 45531 RVA: 0x002B499C File Offset: 0x002B2B9C
		[DebuggerNonUserCode]
		public bool HasIpAddress
		{
			get
			{
				return this.ipAddress_ != null;
			}
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x002B49B7 File Offset: 0x002B2BB7
		[DebuggerNonUserCode]
		public void ClearIpAddress()
		{
			this.ipAddress_ = null;
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600B1DD RID: 45533 RVA: 0x002B49C4 File Offset: 0x002B2BC4
		// (set) Token: 0x0600B1DE RID: 45534 RVA: 0x002B49F5 File Offset: 0x002B2BF5
		[DebuggerNonUserCode]
		public uint Port
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint portDefaultValue;
				if (flag)
				{
					portDefaultValue = this.port_;
				}
				else
				{
					portDefaultValue = GameJoinResponse.PortDefaultValue;
				}
				return portDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.port_ = value;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600B1DF RID: 45535 RVA: 0x002B4A10 File Offset: 0x002B2C10
		[DebuggerNonUserCode]
		public bool HasPort
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x002B4A2D File Offset: 0x002B2C2D
		[DebuggerNonUserCode]
		public void ClearPort()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600B1E1 RID: 45537 RVA: 0x002B4A40 File Offset: 0x002B2C40
		// (set) Token: 0x0600B1E2 RID: 45538 RVA: 0x002B4A61 File Offset: 0x002B2C61
		[DebuggerNonUserCode]
		public ByteString Hash
		{
			get
			{
				return this.hash_ ?? GameJoinResponse.HashDefaultValue;
			}
			set
			{
				this.hash_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600B1E3 RID: 45539 RVA: 0x002B4A78 File Offset: 0x002B2C78
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return this.hash_ != null;
			}
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x002B4A96 File Offset: 0x002B2C96
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this.hash_ = null;
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600B1E5 RID: 45541 RVA: 0x002B4AA0 File Offset: 0x002B2CA0
		// (set) Token: 0x0600B1E6 RID: 45542 RVA: 0x002B4AD1 File Offset: 0x002B2CD1
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = GameJoinResponse.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600B1E7 RID: 45543 RVA: 0x002B4AEC File Offset: 0x002B2CEC
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x002B4B09 File Offset: 0x002B2D09
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x002B4B1C File Offset: 0x002B2D1C
		// (set) Token: 0x0600B1EA RID: 45546 RVA: 0x002B4B3D File Offset: 0x002B2D3D
		[DebuggerNonUserCode]
		public string ServerGitVersion
		{
			get
			{
				return this.serverGitVersion_ ?? GameJoinResponse.ServerGitVersionDefaultValue;
			}
			set
			{
				this.serverGitVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600B1EB RID: 45547 RVA: 0x002B4B54 File Offset: 0x002B2D54
		[DebuggerNonUserCode]
		public bool HasServerGitVersion
		{
			get
			{
				return this.serverGitVersion_ != null;
			}
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x002B4B6F File Offset: 0x002B2D6F
		[DebuggerNonUserCode]
		public void ClearServerGitVersion()
		{
			this.serverGitVersion_ = null;
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x002B4B7C File Offset: 0x002B2D7C
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x002B4BAD File Offset: 0x002B2DAD
		[DebuggerNonUserCode]
		public uint OneOrZero
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint oneOrZeroDefaultValue;
				if (flag)
				{
					oneOrZeroDefaultValue = this.oneOrZero_;
				}
				else
				{
					oneOrZeroDefaultValue = GameJoinResponse.OneOrZeroDefaultValue;
				}
				return oneOrZeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.oneOrZero_ = value;
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x002B4BC8 File Offset: 0x002B2DC8
		[DebuggerNonUserCode]
		public bool HasOneOrZero
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x002B4BE5 File Offset: 0x002B2DE5
		[DebuggerNonUserCode]
		public void ClearOneOrZero()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x002B4BF8 File Offset: 0x002B2DF8
		// (set) Token: 0x0600B1F2 RID: 45554 RVA: 0x002B4C29 File Offset: 0x002B2E29
		[DebuggerNonUserCode]
		public uint Fiftytwo0004
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint fiftytwo0004DefaultValue;
				if (flag)
				{
					fiftytwo0004DefaultValue = this.fiftytwo0004_;
				}
				else
				{
					fiftytwo0004DefaultValue = GameJoinResponse.Fiftytwo0004DefaultValue;
				}
				return fiftytwo0004DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.fiftytwo0004_ = value;
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600B1F3 RID: 45555 RVA: 0x002B4C44 File Offset: 0x002B2E44
		[DebuggerNonUserCode]
		public bool HasFiftytwo0004
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x002B4C61 File Offset: 0x002B2E61
		[DebuggerNonUserCode]
		public void ClearFiftytwo0004()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600B1F5 RID: 45557 RVA: 0x002B4C74 File Offset: 0x002B2E74
		// (set) Token: 0x0600B1F6 RID: 45558 RVA: 0x002B4CA6 File Offset: 0x002B2EA6
		[DebuggerNonUserCode]
		public uint One2
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint one2DefaultValue;
				if (flag)
				{
					one2DefaultValue = this.one2_;
				}
				else
				{
					one2DefaultValue = GameJoinResponse.One2DefaultValue;
				}
				return one2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.one2_ = value;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600B1F7 RID: 45559 RVA: 0x002B4CC0 File Offset: 0x002B2EC0
		[DebuggerNonUserCode]
		public bool HasOne2
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x002B4CDE File Offset: 0x002B2EDE
		[DebuggerNonUserCode]
		public void ClearOne2()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600B1F9 RID: 45561 RVA: 0x002B4CF0 File Offset: 0x002B2EF0
		// (set) Token: 0x0600B1FA RID: 45562 RVA: 0x002B4D22 File Offset: 0x002B2F22
		[DebuggerNonUserCode]
		public uint MaxLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint maxLevelDefaultValue;
				if (flag)
				{
					maxLevelDefaultValue = this.maxLevel_;
				}
				else
				{
					maxLevelDefaultValue = GameJoinResponse.MaxLevelDefaultValue;
				}
				return maxLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.maxLevel_ = value;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x002B4D3C File Offset: 0x002B2F3C
		[DebuggerNonUserCode]
		public bool HasMaxLevel
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x002B4D5A File Offset: 0x002B2F5A
		[DebuggerNonUserCode]
		public void ClearMaxLevel()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600B1FD RID: 45565 RVA: 0x002B4D6C File Offset: 0x002B2F6C
		// (set) Token: 0x0600B1FE RID: 45566 RVA: 0x002B4D8D File Offset: 0x002B2F8D
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return this.region_ ?? GameJoinResponse.RegionDefaultValue;
			}
			set
			{
				this.region_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x002B4DA4 File Offset: 0x002B2FA4
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return this.region_ != null;
			}
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x002B4DBF File Offset: 0x002B2FBF
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this.region_ = null;
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600B201 RID: 45569 RVA: 0x002B4DCC File Offset: 0x002B2FCC
		// (set) Token: 0x0600B202 RID: 45570 RVA: 0x002B4DFE File Offset: 0x002B2FFE
		[DebuggerNonUserCode]
		public uint Zero
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint zeroDefaultValue;
				if (flag)
				{
					zeroDefaultValue = this.zero_;
				}
				else
				{
					zeroDefaultValue = GameJoinResponse.ZeroDefaultValue;
				}
				return zeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.zero_ = value;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600B203 RID: 45571 RVA: 0x002B4E18 File Offset: 0x002B3018
		[DebuggerNonUserCode]
		public bool HasZero
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x002B4E36 File Offset: 0x002B3036
		[DebuggerNonUserCode]
		public void ClearZero()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x002B4E48 File Offset: 0x002B3048
		// (set) Token: 0x0600B206 RID: 45574 RVA: 0x002B4E7D File Offset: 0x002B307D
		[DebuggerNonUserCode]
		public uint MaxPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint maxPlayersDefaultValue;
				if (flag)
				{
					maxPlayersDefaultValue = this.maxPlayers_;
				}
				else
				{
					maxPlayersDefaultValue = GameJoinResponse.MaxPlayersDefaultValue;
				}
				return maxPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.maxPlayers_ = value;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600B207 RID: 45575 RVA: 0x002B4E9C File Offset: 0x002B309C
		[DebuggerNonUserCode]
		public bool HasMaxPlayers
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x002B4EBD File Offset: 0x002B30BD
		[DebuggerNonUserCode]
		public void ClearMaxPlayers()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x002B4ED4 File Offset: 0x002B30D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameJoinResponse);
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x002B4EF4 File Offset: 0x002B30F4
		[DebuggerNonUserCode]
		public bool Equals(GameJoinResponse other)
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
					bool flag4 = this.IpAddress != other.IpAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Port != other.Port;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Hash != other.Hash;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Id != other.Id;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ServerGitVersion != other.ServerGitVersion;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.OneOrZero != other.OneOrZero;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Fiftytwo0004 != other.Fiftytwo0004;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.One2 != other.One2;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MaxLevel != other.MaxLevel;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Region != other.Region;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Zero != other.Zero;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.MaxPlayers != other.MaxPlayers;
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600B20B RID: 45579 RVA: 0x002B5094 File Offset: 0x002B3294
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num ^= this.IpAddress.GetHashCode();
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num ^= this.Port.GetHashCode();
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasServerGitVersion = this.HasServerGitVersion;
			if (hasServerGitVersion)
			{
				num ^= this.ServerGitVersion.GetHashCode();
			}
			bool hasOneOrZero = this.HasOneOrZero;
			if (hasOneOrZero)
			{
				num ^= this.OneOrZero.GetHashCode();
			}
			bool hasFiftytwo = this.HasFiftytwo0004;
			if (hasFiftytwo)
			{
				num ^= this.Fiftytwo0004.GetHashCode();
			}
			bool hasOne = this.HasOne2;
			if (hasOne)
			{
				num ^= this.One2.GetHashCode();
			}
			bool hasMaxLevel = this.HasMaxLevel;
			if (hasMaxLevel)
			{
				num ^= this.MaxLevel.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				num ^= this.Zero.GetHashCode();
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num ^= this.MaxPlayers.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x002B5218 File Offset: 0x002B3418
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x002B5230 File Offset: 0x002B3430
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x002B523C File Offset: 0x002B343C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.IpAddress);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Port);
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Hash);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			bool hasServerGitVersion = this.HasServerGitVersion;
			if (hasServerGitVersion)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ServerGitVersion);
			}
			bool hasOneOrZero = this.HasOneOrZero;
			if (hasOneOrZero)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.OneOrZero);
			}
			bool hasFiftytwo = this.HasFiftytwo0004;
			if (hasFiftytwo)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Fiftytwo0004);
			}
			bool hasOne = this.HasOne2;
			if (hasOne)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.One2);
			}
			bool hasMaxLevel = this.HasMaxLevel;
			if (hasMaxLevel)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MaxLevel);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Region);
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Zero);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MaxPlayers);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x002B5410 File Offset: 0x002B3610
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IpAddress);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Hash);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasServerGitVersion = this.HasServerGitVersion;
			if (hasServerGitVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerGitVersion);
			}
			bool hasOneOrZero = this.HasOneOrZero;
			if (hasOneOrZero)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OneOrZero);
			}
			bool hasFiftytwo = this.HasFiftytwo0004;
			if (hasFiftytwo)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Fiftytwo0004);
			}
			bool hasOne = this.HasOne2;
			if (hasOne)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.One2);
			}
			bool hasMaxLevel = this.HasMaxLevel;
			if (hasMaxLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxLevel);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Region);
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Zero);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPlayers);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x002B55A8 File Offset: 0x002B37A8
		[DebuggerNonUserCode]
		public void MergeFrom(GameJoinResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIpAddress = other.HasIpAddress;
				if (hasIpAddress)
				{
					this.IpAddress = other.IpAddress;
				}
				bool hasPort = other.HasPort;
				if (hasPort)
				{
					this.Port = other.Port;
				}
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasServerGitVersion = other.HasServerGitVersion;
				if (hasServerGitVersion)
				{
					this.ServerGitVersion = other.ServerGitVersion;
				}
				bool hasOneOrZero = other.HasOneOrZero;
				if (hasOneOrZero)
				{
					this.OneOrZero = other.OneOrZero;
				}
				bool hasFiftytwo = other.HasFiftytwo0004;
				if (hasFiftytwo)
				{
					this.Fiftytwo0004 = other.Fiftytwo0004;
				}
				bool hasOne = other.HasOne2;
				if (hasOne)
				{
					this.One2 = other.One2;
				}
				bool hasMaxLevel = other.HasMaxLevel;
				if (hasMaxLevel)
				{
					this.MaxLevel = other.MaxLevel;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasZero = other.HasZero;
				if (hasZero)
				{
					this.Zero = other.Zero;
				}
				bool hasMaxPlayers = other.HasMaxPlayers;
				if (hasMaxPlayers)
				{
					this.MaxPlayers = other.MaxPlayers;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x002B5719 File Offset: 0x002B3919
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x002B5724 File Offset: 0x002B3924
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									goto IL_0092;
								}
								this.Hash = input.ReadBytes();
							}
							else
							{
								this.Port = input.ReadUInt32();
							}
						}
						else
						{
							this.IpAddress = input.ReadString();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_0092;
							}
							this.OneOrZero = input.ReadUInt32();
						}
						else
						{
							this.ServerGitVersion = input.ReadString();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_0092;
							}
							this.MaxLevel = input.ReadUInt32();
						}
						else
						{
							this.One2 = input.ReadUInt32();
						}
					}
					else
					{
						this.Fiftytwo0004 = input.ReadUInt32();
					}
				}
				else if (num3 != 82U)
				{
					if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							goto IL_0092;
						}
						this.MaxPlayers = input.ReadUInt32();
					}
					else
					{
						this.Zero = input.ReadUInt32();
					}
				}
				else
				{
					this.Region = input.ReadString();
				}
				continue;
				IL_0092:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400503C RID: 20540
		private static readonly MessageParser<GameJoinResponse> _parser = new MessageParser<GameJoinResponse>(() => new GameJoinResponse());

		// Token: 0x0400503D RID: 20541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400503E RID: 20542
		private int _hasBits0;

		// Token: 0x0400503F RID: 20543
		public const int IpAddressFieldNumber = 1;

		// Token: 0x04005040 RID: 20544
		private static readonly string IpAddressDefaultValue = "";

		// Token: 0x04005041 RID: 20545
		private string ipAddress_;

		// Token: 0x04005042 RID: 20546
		public const int PortFieldNumber = 2;

		// Token: 0x04005043 RID: 20547
		private static readonly uint PortDefaultValue = 0U;

		// Token: 0x04005044 RID: 20548
		private uint port_;

		// Token: 0x04005045 RID: 20549
		public const int HashFieldNumber = 3;

		// Token: 0x04005046 RID: 20550
		private static readonly ByteString HashDefaultValue = ByteString.Empty;

		// Token: 0x04005047 RID: 20551
		private ByteString hash_;

		// Token: 0x04005048 RID: 20552
		public const int IdFieldNumber = 4;

		// Token: 0x04005049 RID: 20553
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x0400504A RID: 20554
		private uint id_;

		// Token: 0x0400504B RID: 20555
		public const int ServerGitVersionFieldNumber = 5;

		// Token: 0x0400504C RID: 20556
		private static readonly string ServerGitVersionDefaultValue = "";

		// Token: 0x0400504D RID: 20557
		private string serverGitVersion_;

		// Token: 0x0400504E RID: 20558
		public const int OneOrZeroFieldNumber = 6;

		// Token: 0x0400504F RID: 20559
		private static readonly uint OneOrZeroDefaultValue = 0U;

		// Token: 0x04005050 RID: 20560
		private uint oneOrZero_;

		// Token: 0x04005051 RID: 20561
		public const int Fiftytwo0004FieldNumber = 7;

		// Token: 0x04005052 RID: 20562
		private static readonly uint Fiftytwo0004DefaultValue = 0U;

		// Token: 0x04005053 RID: 20563
		private uint fiftytwo0004_;

		// Token: 0x04005054 RID: 20564
		public const int One2FieldNumber = 8;

		// Token: 0x04005055 RID: 20565
		private static readonly uint One2DefaultValue = 0U;

		// Token: 0x04005056 RID: 20566
		private uint one2_;

		// Token: 0x04005057 RID: 20567
		public const int MaxLevelFieldNumber = 9;

		// Token: 0x04005058 RID: 20568
		private static readonly uint MaxLevelDefaultValue = 0U;

		// Token: 0x04005059 RID: 20569
		private uint maxLevel_;

		// Token: 0x0400505A RID: 20570
		public const int RegionFieldNumber = 10;

		// Token: 0x0400505B RID: 20571
		private static readonly string RegionDefaultValue = "";

		// Token: 0x0400505C RID: 20572
		private string region_;

		// Token: 0x0400505D RID: 20573
		public const int ZeroFieldNumber = 11;

		// Token: 0x0400505E RID: 20574
		private static readonly uint ZeroDefaultValue = 0U;

		// Token: 0x0400505F RID: 20575
		private uint zero_;

		// Token: 0x04005060 RID: 20576
		public const int MaxPlayersFieldNumber = 12;

		// Token: 0x04005061 RID: 20577
		private static readonly uint MaxPlayersDefaultValue = 0U;

		// Token: 0x04005062 RID: 20578
		private uint maxPlayers_;
	}
}
