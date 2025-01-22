using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C1 RID: 449
	public sealed class PlayerCommand : IMessage<PlayerCommand>, IMessage, IEquatable<PlayerCommand>, IDeepCloneable<PlayerCommand>, IBufferMessage
	{
		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x000B9178 File Offset: 0x000B7378
		[DebuggerNonUserCode]
		public static MessageParser<PlayerCommand> Parser
		{
			get
			{
				return PlayerCommand._parser;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000B9190 File Offset: 0x000B7390
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x000B91B4 File Offset: 0x000B73B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCommand.Descriptor;
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000B91CB File Offset: 0x000B73CB
		[DebuggerNonUserCode]
		public PlayerCommand()
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x000B91D8 File Offset: 0x000B73D8
		[DebuggerNonUserCode]
		public PlayerCommand(PlayerCommand other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mCommandFrame_ = other.mCommandFrame_;
			this.mYaw_ = other.mYaw_;
			this.mThrottleX_ = other.mThrottleX_;
			this.mThrottleY_ = other.mThrottleY_;
			this.mInputFlags_ = other.mInputFlags_;
			this.mTeleportIndex_ = other.mTeleportIndex_;
			this.mDestinationX_ = other.mDestinationX_;
			this.mDestinationY_ = other.mDestinationY_;
			this.mDestinationZ_ = other.mDestinationZ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x000B9278 File Offset: 0x000B7478
		[DebuggerNonUserCode]
		public PlayerCommand Clone()
		{
			return new PlayerCommand(this);
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x000B9290 File Offset: 0x000B7490
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x000B92C1 File Offset: 0x000B74C1
		[DebuggerNonUserCode]
		public uint MCommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint mcommandFrameDefaultValue;
				if (flag)
				{
					mcommandFrameDefaultValue = this.mCommandFrame_;
				}
				else
				{
					mcommandFrameDefaultValue = PlayerCommand.MCommandFrameDefaultValue;
				}
				return mcommandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.mCommandFrame_ = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x000B92DC File Offset: 0x000B74DC
		[DebuggerNonUserCode]
		public bool HasMCommandFrame
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000B92F9 File Offset: 0x000B74F9
		[DebuggerNonUserCode]
		public void ClearMCommandFrame()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x000B930C File Offset: 0x000B750C
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x000B933D File Offset: 0x000B753D
		[DebuggerNonUserCode]
		public uint MYaw
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint myawDefaultValue;
				if (flag)
				{
					myawDefaultValue = this.mYaw_;
				}
				else
				{
					myawDefaultValue = PlayerCommand.MYawDefaultValue;
				}
				return myawDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.mYaw_ = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x000B9358 File Offset: 0x000B7558
		[DebuggerNonUserCode]
		public bool HasMYaw
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000B9375 File Offset: 0x000B7575
		[DebuggerNonUserCode]
		public void ClearMYaw()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000B9388 File Offset: 0x000B7588
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x000B93B9 File Offset: 0x000B75B9
		[DebuggerNonUserCode]
		public int MThrottleX
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int mthrottleXDefaultValue;
				if (flag)
				{
					mthrottleXDefaultValue = this.mThrottleX_;
				}
				else
				{
					mthrottleXDefaultValue = PlayerCommand.MThrottleXDefaultValue;
				}
				return mthrottleXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.mThrottleX_ = value;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000B93D4 File Offset: 0x000B75D4
		[DebuggerNonUserCode]
		public bool HasMThrottleX
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000B93F1 File Offset: 0x000B75F1
		[DebuggerNonUserCode]
		public void ClearMThrottleX()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000B9404 File Offset: 0x000B7604
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x000B9435 File Offset: 0x000B7635
		[DebuggerNonUserCode]
		public int MThrottleY
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int mthrottleYDefaultValue;
				if (flag)
				{
					mthrottleYDefaultValue = this.mThrottleY_;
				}
				else
				{
					mthrottleYDefaultValue = PlayerCommand.MThrottleYDefaultValue;
				}
				return mthrottleYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.mThrottleY_ = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000B9450 File Offset: 0x000B7650
		[DebuggerNonUserCode]
		public bool HasMThrottleY
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000B946D File Offset: 0x000B766D
		[DebuggerNonUserCode]
		public void ClearMThrottleY()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000B9480 File Offset: 0x000B7680
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x000B94B2 File Offset: 0x000B76B2
		[DebuggerNonUserCode]
		public uint MInputFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint minputFlagsDefaultValue;
				if (flag)
				{
					minputFlagsDefaultValue = this.mInputFlags_;
				}
				else
				{
					minputFlagsDefaultValue = PlayerCommand.MInputFlagsDefaultValue;
				}
				return minputFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.mInputFlags_ = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000B94CC File Offset: 0x000B76CC
		[DebuggerNonUserCode]
		public bool HasMInputFlags
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000B94EA File Offset: 0x000B76EA
		[DebuggerNonUserCode]
		public void ClearMInputFlags()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000B94FC File Offset: 0x000B76FC
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000B952E File Offset: 0x000B772E
		[DebuggerNonUserCode]
		public uint MTeleportIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint mteleportIndexDefaultValue;
				if (flag)
				{
					mteleportIndexDefaultValue = this.mTeleportIndex_;
				}
				else
				{
					mteleportIndexDefaultValue = PlayerCommand.MTeleportIndexDefaultValue;
				}
				return mteleportIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.mTeleportIndex_ = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000B9548 File Offset: 0x000B7748
		[DebuggerNonUserCode]
		public bool HasMTeleportIndex
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x000B9566 File Offset: 0x000B7766
		[DebuggerNonUserCode]
		public void ClearMTeleportIndex()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000B9578 File Offset: 0x000B7778
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x000B95AA File Offset: 0x000B77AA
		[DebuggerNonUserCode]
		public int MDestinationX
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int mdestinationXDefaultValue;
				if (flag)
				{
					mdestinationXDefaultValue = this.mDestinationX_;
				}
				else
				{
					mdestinationXDefaultValue = PlayerCommand.MDestinationXDefaultValue;
				}
				return mdestinationXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.mDestinationX_ = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000B95C4 File Offset: 0x000B77C4
		[DebuggerNonUserCode]
		public bool HasMDestinationX
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000B95E2 File Offset: 0x000B77E2
		[DebuggerNonUserCode]
		public void ClearMDestinationX()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000B95F4 File Offset: 0x000B77F4
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x000B9629 File Offset: 0x000B7829
		[DebuggerNonUserCode]
		public int MDestinationY
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int mdestinationYDefaultValue;
				if (flag)
				{
					mdestinationYDefaultValue = this.mDestinationY_;
				}
				else
				{
					mdestinationYDefaultValue = PlayerCommand.MDestinationYDefaultValue;
				}
				return mdestinationYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.mDestinationY_ = value;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000B9648 File Offset: 0x000B7848
		[DebuggerNonUserCode]
		public bool HasMDestinationY
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x000B9669 File Offset: 0x000B7869
		[DebuggerNonUserCode]
		public void ClearMDestinationY()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000B9680 File Offset: 0x000B7880
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x000B96B5 File Offset: 0x000B78B5
		[DebuggerNonUserCode]
		public int MDestinationZ
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int mdestinationZDefaultValue;
				if (flag)
				{
					mdestinationZDefaultValue = this.mDestinationZ_;
				}
				else
				{
					mdestinationZDefaultValue = PlayerCommand.MDestinationZDefaultValue;
				}
				return mdestinationZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.mDestinationZ_ = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000B96D4 File Offset: 0x000B78D4
		[DebuggerNonUserCode]
		public bool HasMDestinationZ
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000B96F5 File Offset: 0x000B78F5
		[DebuggerNonUserCode]
		public void ClearMDestinationZ()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000B970C File Offset: 0x000B790C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCommand);
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000B972C File Offset: 0x000B792C
		[DebuggerNonUserCode]
		public bool Equals(PlayerCommand other)
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
					bool flag4 = this.MCommandFrame != other.MCommandFrame;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MYaw != other.MYaw;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MThrottleX != other.MThrottleX;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MThrottleY != other.MThrottleY;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MInputFlags != other.MInputFlags;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.MTeleportIndex != other.MTeleportIndex;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MDestinationX != other.MDestinationX;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MDestinationY != other.MDestinationY;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MDestinationZ != other.MDestinationZ;
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

		// Token: 0x06002F27 RID: 12071 RVA: 0x000B9870 File Offset: 0x000B7A70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				num ^= this.MCommandFrame.GetHashCode();
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				num ^= this.MYaw.GetHashCode();
			}
			bool hasMThrottleX = this.HasMThrottleX;
			if (hasMThrottleX)
			{
				num ^= this.MThrottleX.GetHashCode();
			}
			bool hasMThrottleY = this.HasMThrottleY;
			if (hasMThrottleY)
			{
				num ^= this.MThrottleY.GetHashCode();
			}
			bool hasMInputFlags = this.HasMInputFlags;
			if (hasMInputFlags)
			{
				num ^= this.MInputFlags.GetHashCode();
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				num ^= this.MTeleportIndex.GetHashCode();
			}
			bool hasMDestinationX = this.HasMDestinationX;
			if (hasMDestinationX)
			{
				num ^= this.MDestinationX.GetHashCode();
			}
			bool hasMDestinationY = this.HasMDestinationY;
			if (hasMDestinationY)
			{
				num ^= this.MDestinationY.GetHashCode();
			}
			bool hasMDestinationZ = this.HasMDestinationZ;
			if (hasMDestinationZ)
			{
				num ^= this.MDestinationZ.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x000B99AC File Offset: 0x000B7BAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000B99C4 File Offset: 0x000B7BC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000B99D0 File Offset: 0x000B7BD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MCommandFrame);
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MYaw);
			}
			bool hasMThrottleX = this.HasMThrottleX;
			if (hasMThrottleX)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.MThrottleX);
			}
			bool hasMThrottleY = this.HasMThrottleY;
			if (hasMThrottleY)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.MThrottleY);
			}
			bool hasMInputFlags = this.HasMInputFlags;
			if (hasMInputFlags)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MInputFlags);
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MTeleportIndex);
			}
			bool hasMDestinationX = this.HasMDestinationX;
			if (hasMDestinationX)
			{
				output.WriteRawTag(56);
				output.WriteSInt32(this.MDestinationX);
			}
			bool hasMDestinationY = this.HasMDestinationY;
			if (hasMDestinationY)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.MDestinationY);
			}
			bool hasMDestinationZ = this.HasMDestinationZ;
			if (hasMDestinationZ)
			{
				output.WriteRawTag(72);
				output.WriteSInt32(this.MDestinationZ);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000B9B38 File Offset: 0x000B7D38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCommandFrame);
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MYaw);
			}
			bool hasMThrottleX = this.HasMThrottleX;
			if (hasMThrottleX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MThrottleX);
			}
			bool hasMThrottleY = this.HasMThrottleY;
			if (hasMThrottleY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MThrottleY);
			}
			bool hasMInputFlags = this.HasMInputFlags;
			if (hasMInputFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MInputFlags);
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MTeleportIndex);
			}
			bool hasMDestinationX = this.HasMDestinationX;
			if (hasMDestinationX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MDestinationX);
			}
			bool hasMDestinationY = this.HasMDestinationY;
			if (hasMDestinationY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MDestinationY);
			}
			bool hasMDestinationZ = this.HasMDestinationZ;
			if (hasMDestinationZ)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MDestinationZ);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000B9C78 File Offset: 0x000B7E78
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerCommand other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMCommandFrame = other.HasMCommandFrame;
				if (hasMCommandFrame)
				{
					this.MCommandFrame = other.MCommandFrame;
				}
				bool hasMYaw = other.HasMYaw;
				if (hasMYaw)
				{
					this.MYaw = other.MYaw;
				}
				bool hasMThrottleX = other.HasMThrottleX;
				if (hasMThrottleX)
				{
					this.MThrottleX = other.MThrottleX;
				}
				bool hasMThrottleY = other.HasMThrottleY;
				if (hasMThrottleY)
				{
					this.MThrottleY = other.MThrottleY;
				}
				bool hasMInputFlags = other.HasMInputFlags;
				if (hasMInputFlags)
				{
					this.MInputFlags = other.MInputFlags;
				}
				bool hasMTeleportIndex = other.HasMTeleportIndex;
				if (hasMTeleportIndex)
				{
					this.MTeleportIndex = other.MTeleportIndex;
				}
				bool hasMDestinationX = other.HasMDestinationX;
				if (hasMDestinationX)
				{
					this.MDestinationX = other.MDestinationX;
				}
				bool hasMDestinationY = other.HasMDestinationY;
				if (hasMDestinationY)
				{
					this.MDestinationY = other.MDestinationY;
				}
				bool hasMDestinationZ = other.HasMDestinationZ;
				if (hasMDestinationZ)
				{
					this.MDestinationZ = other.MDestinationZ;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000B9D98 File Offset: 0x000B7F98
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000B9DA4 File Offset: 0x000B7FA4
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
								goto IL_006A;
							}
							this.MYaw = input.ReadUInt32();
						}
						else
						{
							this.MCommandFrame = input.ReadUInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_006A;
						}
						this.MThrottleY = input.ReadSInt32();
					}
					else
					{
						this.MThrottleX = input.ReadSInt32();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_006A;
						}
						this.MTeleportIndex = input.ReadUInt32();
					}
					else
					{
						this.MInputFlags = input.ReadUInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							goto IL_006A;
						}
						this.MDestinationZ = input.ReadSInt32();
					}
					else
					{
						this.MDestinationY = input.ReadSInt32();
					}
				}
				else
				{
					this.MDestinationX = input.ReadSInt32();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400152B RID: 5419
		private static readonly MessageParser<PlayerCommand> _parser = new MessageParser<PlayerCommand>(() => new PlayerCommand());

		// Token: 0x0400152C RID: 5420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400152D RID: 5421
		private int _hasBits0;

		// Token: 0x0400152E RID: 5422
		public const int MCommandFrameFieldNumber = 1;

		// Token: 0x0400152F RID: 5423
		private static readonly uint MCommandFrameDefaultValue = 0U;

		// Token: 0x04001530 RID: 5424
		private uint mCommandFrame_;

		// Token: 0x04001531 RID: 5425
		public const int MYawFieldNumber = 2;

		// Token: 0x04001532 RID: 5426
		private static readonly uint MYawDefaultValue = 0U;

		// Token: 0x04001533 RID: 5427
		private uint mYaw_;

		// Token: 0x04001534 RID: 5428
		public const int MThrottleXFieldNumber = 3;

		// Token: 0x04001535 RID: 5429
		private static readonly int MThrottleXDefaultValue = 0;

		// Token: 0x04001536 RID: 5430
		private int mThrottleX_;

		// Token: 0x04001537 RID: 5431
		public const int MThrottleYFieldNumber = 4;

		// Token: 0x04001538 RID: 5432
		private static readonly int MThrottleYDefaultValue = 0;

		// Token: 0x04001539 RID: 5433
		private int mThrottleY_;

		// Token: 0x0400153A RID: 5434
		public const int MInputFlagsFieldNumber = 5;

		// Token: 0x0400153B RID: 5435
		private static readonly uint MInputFlagsDefaultValue = 0U;

		// Token: 0x0400153C RID: 5436
		private uint mInputFlags_;

		// Token: 0x0400153D RID: 5437
		public const int MTeleportIndexFieldNumber = 6;

		// Token: 0x0400153E RID: 5438
		private static readonly uint MTeleportIndexDefaultValue = 0U;

		// Token: 0x0400153F RID: 5439
		private uint mTeleportIndex_;

		// Token: 0x04001540 RID: 5440
		public const int MDestinationXFieldNumber = 7;

		// Token: 0x04001541 RID: 5441
		private static readonly int MDestinationXDefaultValue = 0;

		// Token: 0x04001542 RID: 5442
		private int mDestinationX_;

		// Token: 0x04001543 RID: 5443
		public const int MDestinationYFieldNumber = 8;

		// Token: 0x04001544 RID: 5444
		private static readonly int MDestinationYDefaultValue = 0;

		// Token: 0x04001545 RID: 5445
		private int mDestinationY_;

		// Token: 0x04001546 RID: 5446
		public const int MDestinationZFieldNumber = 9;

		// Token: 0x04001547 RID: 5447
		private static readonly int MDestinationZDefaultValue = 0;

		// Token: 0x04001548 RID: 5448
		private int mDestinationZ_;
	}
}
