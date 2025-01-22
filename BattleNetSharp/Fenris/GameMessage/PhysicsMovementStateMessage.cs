using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C2 RID: 450
	public sealed class PhysicsMovementStateMessage : IMessage<PhysicsMovementStateMessage>, IMessage, IEquatable<PhysicsMovementStateMessage>, IDeepCloneable<PhysicsMovementStateMessage>, IBufferMessage
	{
		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000B9F38 File Offset: 0x000B8138
		[DebuggerNonUserCode]
		public static MessageParser<PhysicsMovementStateMessage> Parser
		{
			get
			{
				return PhysicsMovementStateMessage._parser;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000B9F50 File Offset: 0x000B8150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000B9F74 File Offset: 0x000B8174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhysicsMovementStateMessage.Descriptor;
			}
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000B9F8B File Offset: 0x000B818B
		[DebuggerNonUserCode]
		public PhysicsMovementStateMessage()
		{
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000B9F98 File Offset: 0x000B8198
		[DebuggerNonUserCode]
		public PhysicsMovementStateMessage(PhysicsMovementStateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mAnn_ = other.mAnn_;
			this.mIsDelta_ = other.mIsDelta_;
			this.mIsTargetState_ = other.mIsTargetState_;
			this.mFlags_ = other.mFlags_;
			this.mCommandFrame_ = other.mCommandFrame_;
			this.mTeleportIndex_ = other.mTeleportIndex_;
			this.mWorldLocationX_ = other.mWorldLocationX_;
			this.mWorldLocationY_ = other.mWorldLocationY_;
			this.mWorldLocationZ_ = other.mWorldLocationZ_;
			this.mVelocityX_ = other.mVelocityX_;
			this.mVelocityY_ = other.mVelocityY_;
			this.mVelocityZ_ = other.mVelocityZ_;
			this.mVelFromGravX_ = other.mVelFromGravX_;
			this.mVelFromGravY_ = other.mVelFromGravY_;
			this.mVelFromGravZ_ = other.mVelFromGravZ_;
			this.mAnimImpulseX_ = other.mAnimImpulseX_;
			this.mAnimImpulseY_ = other.mAnimImpulseY_;
			this.mAnimImpulseZ_ = other.mAnimImpulseZ_;
			this.mForcesX_ = other.mForcesX_;
			this.mForcesY_ = other.mForcesY_;
			this.mForcesZ_ = other.mForcesZ_;
			this.mYaw_ = other.mYaw_;
			this.mDesiredYaw_ = other.mDesiredYaw_;
			this.mYawSpeed_ = other.mYawSpeed_;
			this.mSpeed_ = other.mSpeed_;
			this.mAnimationScalingTimeScale_ = other.mAnimationScalingTimeScale_;
			this.mCurrentMotionIsAnimationDriven_ = other.mCurrentMotionIsAnimationDriven_;
			this.mSnoPowerAnimKeyOverride_ = other.mSnoPowerAnimKeyOverride_;
			this.mPrevCommandFrame_ = other.mPrevCommandFrame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000BA128 File Offset: 0x000B8328
		[DebuggerNonUserCode]
		public PhysicsMovementStateMessage Clone()
		{
			return new PhysicsMovementStateMessage(this);
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000BA140 File Offset: 0x000B8340
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x000BA171 File Offset: 0x000B8371
		[DebuggerNonUserCode]
		public uint MAnn
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint mannDefaultValue;
				if (flag)
				{
					mannDefaultValue = this.mAnn_;
				}
				else
				{
					mannDefaultValue = PhysicsMovementStateMessage.MAnnDefaultValue;
				}
				return mannDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.mAnn_ = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000BA18C File Offset: 0x000B838C
		[DebuggerNonUserCode]
		public bool HasMAnn
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000BA1A9 File Offset: 0x000B83A9
		[DebuggerNonUserCode]
		public void ClearMAnn()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000BA1BC File Offset: 0x000B83BC
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x000BA1ED File Offset: 0x000B83ED
		[DebuggerNonUserCode]
		public bool MIsDelta
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool misDeltaDefaultValue;
				if (flag)
				{
					misDeltaDefaultValue = this.mIsDelta_;
				}
				else
				{
					misDeltaDefaultValue = PhysicsMovementStateMessage.MIsDeltaDefaultValue;
				}
				return misDeltaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.mIsDelta_ = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000BA208 File Offset: 0x000B8408
		[DebuggerNonUserCode]
		public bool HasMIsDelta
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000BA225 File Offset: 0x000B8425
		[DebuggerNonUserCode]
		public void ClearMIsDelta()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000BA238 File Offset: 0x000B8438
		// (set) Token: 0x06002F3F RID: 12095 RVA: 0x000BA269 File Offset: 0x000B8469
		[DebuggerNonUserCode]
		public bool MIsTargetState
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool misTargetStateDefaultValue;
				if (flag)
				{
					misTargetStateDefaultValue = this.mIsTargetState_;
				}
				else
				{
					misTargetStateDefaultValue = PhysicsMovementStateMessage.MIsTargetStateDefaultValue;
				}
				return misTargetStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.mIsTargetState_ = value;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x000BA284 File Offset: 0x000B8484
		[DebuggerNonUserCode]
		public bool HasMIsTargetState
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000BA2A1 File Offset: 0x000B84A1
		[DebuggerNonUserCode]
		public void ClearMIsTargetState()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x000BA2B4 File Offset: 0x000B84B4
		// (set) Token: 0x06002F43 RID: 12099 RVA: 0x000BA2E5 File Offset: 0x000B84E5
		[DebuggerNonUserCode]
		public uint MFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint mflagsDefaultValue;
				if (flag)
				{
					mflagsDefaultValue = this.mFlags_;
				}
				else
				{
					mflagsDefaultValue = PhysicsMovementStateMessage.MFlagsDefaultValue;
				}
				return mflagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.mFlags_ = value;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x000BA300 File Offset: 0x000B8500
		[DebuggerNonUserCode]
		public bool HasMFlags
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000BA31D File Offset: 0x000B851D
		[DebuggerNonUserCode]
		public void ClearMFlags()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000BA330 File Offset: 0x000B8530
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x000BA362 File Offset: 0x000B8562
		[DebuggerNonUserCode]
		public uint MCommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint mcommandFrameDefaultValue;
				if (flag)
				{
					mcommandFrameDefaultValue = this.mCommandFrame_;
				}
				else
				{
					mcommandFrameDefaultValue = PhysicsMovementStateMessage.MCommandFrameDefaultValue;
				}
				return mcommandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.mCommandFrame_ = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x000BA37C File Offset: 0x000B857C
		[DebuggerNonUserCode]
		public bool HasMCommandFrame
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000BA39A File Offset: 0x000B859A
		[DebuggerNonUserCode]
		public void ClearMCommandFrame()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000BA3AC File Offset: 0x000B85AC
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x000BA3DE File Offset: 0x000B85DE
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
					mteleportIndexDefaultValue = PhysicsMovementStateMessage.MTeleportIndexDefaultValue;
				}
				return mteleportIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.mTeleportIndex_ = value;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000BA3F8 File Offset: 0x000B85F8
		[DebuggerNonUserCode]
		public bool HasMTeleportIndex
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000BA416 File Offset: 0x000B8616
		[DebuggerNonUserCode]
		public void ClearMTeleportIndex()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000BA428 File Offset: 0x000B8628
		// (set) Token: 0x06002F4F RID: 12111 RVA: 0x000BA45A File Offset: 0x000B865A
		[DebuggerNonUserCode]
		public int MWorldLocationX
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int mworldLocationXDefaultValue;
				if (flag)
				{
					mworldLocationXDefaultValue = this.mWorldLocationX_;
				}
				else
				{
					mworldLocationXDefaultValue = PhysicsMovementStateMessage.MWorldLocationXDefaultValue;
				}
				return mworldLocationXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.mWorldLocationX_ = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x000BA474 File Offset: 0x000B8674
		[DebuggerNonUserCode]
		public bool HasMWorldLocationX
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000BA492 File Offset: 0x000B8692
		[DebuggerNonUserCode]
		public void ClearMWorldLocationX()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x000BA4A4 File Offset: 0x000B86A4
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x000BA4D9 File Offset: 0x000B86D9
		[DebuggerNonUserCode]
		public int MWorldLocationY
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int mworldLocationYDefaultValue;
				if (flag)
				{
					mworldLocationYDefaultValue = this.mWorldLocationY_;
				}
				else
				{
					mworldLocationYDefaultValue = PhysicsMovementStateMessage.MWorldLocationYDefaultValue;
				}
				return mworldLocationYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.mWorldLocationY_ = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000BA4F8 File Offset: 0x000B86F8
		[DebuggerNonUserCode]
		public bool HasMWorldLocationY
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000BA519 File Offset: 0x000B8719
		[DebuggerNonUserCode]
		public void ClearMWorldLocationY()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000BA530 File Offset: 0x000B8730
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x000BA565 File Offset: 0x000B8765
		[DebuggerNonUserCode]
		public int MWorldLocationZ
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int mworldLocationZDefaultValue;
				if (flag)
				{
					mworldLocationZDefaultValue = this.mWorldLocationZ_;
				}
				else
				{
					mworldLocationZDefaultValue = PhysicsMovementStateMessage.MWorldLocationZDefaultValue;
				}
				return mworldLocationZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.mWorldLocationZ_ = value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000BA584 File Offset: 0x000B8784
		[DebuggerNonUserCode]
		public bool HasMWorldLocationZ
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000BA5A5 File Offset: 0x000B87A5
		[DebuggerNonUserCode]
		public void ClearMWorldLocationZ()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x000BA5BC File Offset: 0x000B87BC
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x000BA5F1 File Offset: 0x000B87F1
		[DebuggerNonUserCode]
		public int MVelocityX
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int mvelocityXDefaultValue;
				if (flag)
				{
					mvelocityXDefaultValue = this.mVelocityX_;
				}
				else
				{
					mvelocityXDefaultValue = PhysicsMovementStateMessage.MVelocityXDefaultValue;
				}
				return mvelocityXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.mVelocityX_ = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000BA610 File Offset: 0x000B8810
		[DebuggerNonUserCode]
		public bool HasMVelocityX
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000BA631 File Offset: 0x000B8831
		[DebuggerNonUserCode]
		public void ClearMVelocityX()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000BA648 File Offset: 0x000B8848
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x000BA67D File Offset: 0x000B887D
		[DebuggerNonUserCode]
		public int MVelocityY
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				int mvelocityYDefaultValue;
				if (flag)
				{
					mvelocityYDefaultValue = this.mVelocityY_;
				}
				else
				{
					mvelocityYDefaultValue = PhysicsMovementStateMessage.MVelocityYDefaultValue;
				}
				return mvelocityYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.mVelocityY_ = value;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000BA69C File Offset: 0x000B889C
		[DebuggerNonUserCode]
		public bool HasMVelocityY
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000BA6BD File Offset: 0x000B88BD
		[DebuggerNonUserCode]
		public void ClearMVelocityY()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000BA6D4 File Offset: 0x000B88D4
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x000BA709 File Offset: 0x000B8909
		[DebuggerNonUserCode]
		public int MVelocityZ
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int mvelocityZDefaultValue;
				if (flag)
				{
					mvelocityZDefaultValue = this.mVelocityZ_;
				}
				else
				{
					mvelocityZDefaultValue = PhysicsMovementStateMessage.MVelocityZDefaultValue;
				}
				return mvelocityZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.mVelocityZ_ = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x000BA728 File Offset: 0x000B8928
		[DebuggerNonUserCode]
		public bool HasMVelocityZ
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000BA749 File Offset: 0x000B8949
		[DebuggerNonUserCode]
		public void ClearMVelocityZ()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x000BA760 File Offset: 0x000B8960
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x000BA795 File Offset: 0x000B8995
		[DebuggerNonUserCode]
		public int MVelFromGravX
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int mvelFromGravXDefaultValue;
				if (flag)
				{
					mvelFromGravXDefaultValue = this.mVelFromGravX_;
				}
				else
				{
					mvelFromGravXDefaultValue = PhysicsMovementStateMessage.MVelFromGravXDefaultValue;
				}
				return mvelFromGravXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.mVelFromGravX_ = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x000BA7B4 File Offset: 0x000B89B4
		[DebuggerNonUserCode]
		public bool HasMVelFromGravX
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000BA7D5 File Offset: 0x000B89D5
		[DebuggerNonUserCode]
		public void ClearMVelFromGravX()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000BA7EC File Offset: 0x000B89EC
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x000BA821 File Offset: 0x000B8A21
		[DebuggerNonUserCode]
		public int MVelFromGravY
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				int mvelFromGravYDefaultValue;
				if (flag)
				{
					mvelFromGravYDefaultValue = this.mVelFromGravY_;
				}
				else
				{
					mvelFromGravYDefaultValue = PhysicsMovementStateMessage.MVelFromGravYDefaultValue;
				}
				return mvelFromGravYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.mVelFromGravY_ = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x000BA840 File Offset: 0x000B8A40
		[DebuggerNonUserCode]
		public bool HasMVelFromGravY
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000BA861 File Offset: 0x000B8A61
		[DebuggerNonUserCode]
		public void ClearMVelFromGravY()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x000BA878 File Offset: 0x000B8A78
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x000BA8AD File Offset: 0x000B8AAD
		[DebuggerNonUserCode]
		public int MVelFromGravZ
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				int mvelFromGravZDefaultValue;
				if (flag)
				{
					mvelFromGravZDefaultValue = this.mVelFromGravZ_;
				}
				else
				{
					mvelFromGravZDefaultValue = PhysicsMovementStateMessage.MVelFromGravZDefaultValue;
				}
				return mvelFromGravZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.mVelFromGravZ_ = value;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000BA8CC File Offset: 0x000B8ACC
		[DebuggerNonUserCode]
		public bool HasMVelFromGravZ
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000BA8ED File Offset: 0x000B8AED
		[DebuggerNonUserCode]
		public void ClearMVelFromGravZ()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000BA904 File Offset: 0x000B8B04
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x000BA939 File Offset: 0x000B8B39
		[DebuggerNonUserCode]
		public int MAnimImpulseX
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				int manimImpulseXDefaultValue;
				if (flag)
				{
					manimImpulseXDefaultValue = this.mAnimImpulseX_;
				}
				else
				{
					manimImpulseXDefaultValue = PhysicsMovementStateMessage.MAnimImpulseXDefaultValue;
				}
				return manimImpulseXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.mAnimImpulseX_ = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000BA958 File Offset: 0x000B8B58
		[DebuggerNonUserCode]
		public bool HasMAnimImpulseX
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000BA979 File Offset: 0x000B8B79
		[DebuggerNonUserCode]
		public void ClearMAnimImpulseX()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000BA990 File Offset: 0x000B8B90
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x000BA9C5 File Offset: 0x000B8BC5
		[DebuggerNonUserCode]
		public int MAnimImpulseY
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				int manimImpulseYDefaultValue;
				if (flag)
				{
					manimImpulseYDefaultValue = this.mAnimImpulseY_;
				}
				else
				{
					manimImpulseYDefaultValue = PhysicsMovementStateMessage.MAnimImpulseYDefaultValue;
				}
				return manimImpulseYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.mAnimImpulseY_ = value;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000BA9E4 File Offset: 0x000B8BE4
		[DebuggerNonUserCode]
		public bool HasMAnimImpulseY
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000BAA05 File Offset: 0x000B8C05
		[DebuggerNonUserCode]
		public void ClearMAnimImpulseY()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000BAA1C File Offset: 0x000B8C1C
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x000BAA51 File Offset: 0x000B8C51
		[DebuggerNonUserCode]
		public int MAnimImpulseZ
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				int manimImpulseZDefaultValue;
				if (flag)
				{
					manimImpulseZDefaultValue = this.mAnimImpulseZ_;
				}
				else
				{
					manimImpulseZDefaultValue = PhysicsMovementStateMessage.MAnimImpulseZDefaultValue;
				}
				return manimImpulseZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.mAnimImpulseZ_ = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000BAA70 File Offset: 0x000B8C70
		[DebuggerNonUserCode]
		public bool HasMAnimImpulseZ
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000BAA91 File Offset: 0x000B8C91
		[DebuggerNonUserCode]
		public void ClearMAnimImpulseZ()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000BAAA8 File Offset: 0x000B8CA8
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x000BAADD File Offset: 0x000B8CDD
		[DebuggerNonUserCode]
		public int MForcesX
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				int mforcesXDefaultValue;
				if (flag)
				{
					mforcesXDefaultValue = this.mForcesX_;
				}
				else
				{
					mforcesXDefaultValue = PhysicsMovementStateMessage.MForcesXDefaultValue;
				}
				return mforcesXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.mForcesX_ = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000BAAFC File Offset: 0x000B8CFC
		[DebuggerNonUserCode]
		public bool HasMForcesX
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000BAB1D File Offset: 0x000B8D1D
		[DebuggerNonUserCode]
		public void ClearMForcesX()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000BAB34 File Offset: 0x000B8D34
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x000BAB69 File Offset: 0x000B8D69
		[DebuggerNonUserCode]
		public int MForcesY
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				int mforcesYDefaultValue;
				if (flag)
				{
					mforcesYDefaultValue = this.mForcesY_;
				}
				else
				{
					mforcesYDefaultValue = PhysicsMovementStateMessage.MForcesYDefaultValue;
				}
				return mforcesYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.mForcesY_ = value;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000BAB88 File Offset: 0x000B8D88
		[DebuggerNonUserCode]
		public bool HasMForcesY
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x000BABA9 File Offset: 0x000B8DA9
		[DebuggerNonUserCode]
		public void ClearMForcesY()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000BABC0 File Offset: 0x000B8DC0
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x000BABF5 File Offset: 0x000B8DF5
		[DebuggerNonUserCode]
		public int MForcesZ
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				int mforcesZDefaultValue;
				if (flag)
				{
					mforcesZDefaultValue = this.mForcesZ_;
				}
				else
				{
					mforcesZDefaultValue = PhysicsMovementStateMessage.MForcesZDefaultValue;
				}
				return mforcesZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.mForcesZ_ = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000BAC14 File Offset: 0x000B8E14
		[DebuggerNonUserCode]
		public bool HasMForcesZ
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000BAC35 File Offset: 0x000B8E35
		[DebuggerNonUserCode]
		public void ClearMForcesZ()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x000BAC4C File Offset: 0x000B8E4C
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x000BAC81 File Offset: 0x000B8E81
		[DebuggerNonUserCode]
		public int MYaw
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				int myawDefaultValue;
				if (flag)
				{
					myawDefaultValue = this.mYaw_;
				}
				else
				{
					myawDefaultValue = PhysicsMovementStateMessage.MYawDefaultValue;
				}
				return myawDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.mYaw_ = value;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000BACA0 File Offset: 0x000B8EA0
		[DebuggerNonUserCode]
		public bool HasMYaw
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000BACC1 File Offset: 0x000B8EC1
		[DebuggerNonUserCode]
		public void ClearMYaw()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000BACD8 File Offset: 0x000B8ED8
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x000BAD0D File Offset: 0x000B8F0D
		[DebuggerNonUserCode]
		public int MDesiredYaw
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				int mdesiredYawDefaultValue;
				if (flag)
				{
					mdesiredYawDefaultValue = this.mDesiredYaw_;
				}
				else
				{
					mdesiredYawDefaultValue = PhysicsMovementStateMessage.MDesiredYawDefaultValue;
				}
				return mdesiredYawDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.mDesiredYaw_ = value;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000BAD2C File Offset: 0x000B8F2C
		[DebuggerNonUserCode]
		public bool HasMDesiredYaw
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000BAD4D File Offset: 0x000B8F4D
		[DebuggerNonUserCode]
		public void ClearMDesiredYaw()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000BAD64 File Offset: 0x000B8F64
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x000BAD99 File Offset: 0x000B8F99
		[DebuggerNonUserCode]
		public int MYawSpeed
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				int myawSpeedDefaultValue;
				if (flag)
				{
					myawSpeedDefaultValue = this.mYawSpeed_;
				}
				else
				{
					myawSpeedDefaultValue = PhysicsMovementStateMessage.MYawSpeedDefaultValue;
				}
				return myawSpeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.mYawSpeed_ = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000BADB8 File Offset: 0x000B8FB8
		[DebuggerNonUserCode]
		public bool HasMYawSpeed
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000BADD9 File Offset: 0x000B8FD9
		[DebuggerNonUserCode]
		public void ClearMYawSpeed()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000BADF0 File Offset: 0x000B8FF0
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x000BAE25 File Offset: 0x000B9025
		[DebuggerNonUserCode]
		public int MSpeed
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				int mspeedDefaultValue;
				if (flag)
				{
					mspeedDefaultValue = this.mSpeed_;
				}
				else
				{
					mspeedDefaultValue = PhysicsMovementStateMessage.MSpeedDefaultValue;
				}
				return mspeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.mSpeed_ = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000BAE44 File Offset: 0x000B9044
		[DebuggerNonUserCode]
		public bool HasMSpeed
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000BAE65 File Offset: 0x000B9065
		[DebuggerNonUserCode]
		public void ClearMSpeed()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000BAE7C File Offset: 0x000B907C
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x000BAEB1 File Offset: 0x000B90B1
		[DebuggerNonUserCode]
		public int MAnimationScalingTimeScale
		{
			get
			{
				bool flag = (this._hasBits0 & 33554432) != 0;
				int manimationScalingTimeScaleDefaultValue;
				if (flag)
				{
					manimationScalingTimeScaleDefaultValue = this.mAnimationScalingTimeScale_;
				}
				else
				{
					manimationScalingTimeScaleDefaultValue = PhysicsMovementStateMessage.MAnimationScalingTimeScaleDefaultValue;
				}
				return manimationScalingTimeScaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 33554432;
				this.mAnimationScalingTimeScale_ = value;
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000BAED0 File Offset: 0x000B90D0
		[DebuggerNonUserCode]
		public bool HasMAnimationScalingTimeScale
		{
			get
			{
				return (this._hasBits0 & 33554432) != 0;
			}
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x000BAEF1 File Offset: 0x000B90F1
		[DebuggerNonUserCode]
		public void ClearMAnimationScalingTimeScale()
		{
			this._hasBits0 &= -33554433;
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x000BAF08 File Offset: 0x000B9108
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x000BAF3D File Offset: 0x000B913D
		[DebuggerNonUserCode]
		public bool MCurrentMotionIsAnimationDriven
		{
			get
			{
				bool flag = (this._hasBits0 & 67108864) != 0;
				bool mcurrentMotionIsAnimationDrivenDefaultValue;
				if (flag)
				{
					mcurrentMotionIsAnimationDrivenDefaultValue = this.mCurrentMotionIsAnimationDriven_;
				}
				else
				{
					mcurrentMotionIsAnimationDrivenDefaultValue = PhysicsMovementStateMessage.MCurrentMotionIsAnimationDrivenDefaultValue;
				}
				return mcurrentMotionIsAnimationDrivenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 67108864;
				this.mCurrentMotionIsAnimationDriven_ = value;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x000BAF5C File Offset: 0x000B915C
		[DebuggerNonUserCode]
		public bool HasMCurrentMotionIsAnimationDriven
		{
			get
			{
				return (this._hasBits0 & 67108864) != 0;
			}
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000BAF7D File Offset: 0x000B917D
		[DebuggerNonUserCode]
		public void ClearMCurrentMotionIsAnimationDriven()
		{
			this._hasBits0 &= -67108865;
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000BAF94 File Offset: 0x000B9194
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x000BAFC9 File Offset: 0x000B91C9
		[DebuggerNonUserCode]
		public int MSnoPowerAnimKeyOverride
		{
			get
			{
				bool flag = (this._hasBits0 & 134217728) != 0;
				int msnoPowerAnimKeyOverrideDefaultValue;
				if (flag)
				{
					msnoPowerAnimKeyOverrideDefaultValue = this.mSnoPowerAnimKeyOverride_;
				}
				else
				{
					msnoPowerAnimKeyOverrideDefaultValue = PhysicsMovementStateMessage.MSnoPowerAnimKeyOverrideDefaultValue;
				}
				return msnoPowerAnimKeyOverrideDefaultValue;
			}
			set
			{
				this._hasBits0 |= 134217728;
				this.mSnoPowerAnimKeyOverride_ = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x000BAFE8 File Offset: 0x000B91E8
		[DebuggerNonUserCode]
		public bool HasMSnoPowerAnimKeyOverride
		{
			get
			{
				return (this._hasBits0 & 134217728) != 0;
			}
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000BB009 File Offset: 0x000B9209
		[DebuggerNonUserCode]
		public void ClearMSnoPowerAnimKeyOverride()
		{
			this._hasBits0 &= -134217729;
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x000BB020 File Offset: 0x000B9220
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x000BB055 File Offset: 0x000B9255
		[DebuggerNonUserCode]
		public uint MPrevCommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 268435456) != 0;
				uint mprevCommandFrameDefaultValue;
				if (flag)
				{
					mprevCommandFrameDefaultValue = this.mPrevCommandFrame_;
				}
				else
				{
					mprevCommandFrameDefaultValue = PhysicsMovementStateMessage.MPrevCommandFrameDefaultValue;
				}
				return mprevCommandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 268435456;
				this.mPrevCommandFrame_ = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x000BB074 File Offset: 0x000B9274
		[DebuggerNonUserCode]
		public bool HasMPrevCommandFrame
		{
			get
			{
				return (this._hasBits0 & 268435456) != 0;
			}
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000BB095 File Offset: 0x000B9295
		[DebuggerNonUserCode]
		public void ClearMPrevCommandFrame()
		{
			this._hasBits0 &= -268435457;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000BB0AC File Offset: 0x000B92AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhysicsMovementStateMessage);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000BB0CC File Offset: 0x000B92CC
		[DebuggerNonUserCode]
		public bool Equals(PhysicsMovementStateMessage other)
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
					bool flag4 = this.MAnn != other.MAnn;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MIsDelta != other.MIsDelta;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MIsTargetState != other.MIsTargetState;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MFlags != other.MFlags;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MCommandFrame != other.MCommandFrame;
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
											bool flag10 = this.MWorldLocationX != other.MWorldLocationX;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MWorldLocationY != other.MWorldLocationY;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MWorldLocationZ != other.MWorldLocationZ;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MVelocityX != other.MVelocityX;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.MVelocityY != other.MVelocityY;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.MVelocityZ != other.MVelocityZ;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.MVelFromGravX != other.MVelFromGravX;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.MVelFromGravY != other.MVelFromGravY;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.MVelFromGravZ != other.MVelFromGravZ;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.MAnimImpulseX != other.MAnimImpulseX;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.MAnimImpulseY != other.MAnimImpulseY;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.MAnimImpulseZ != other.MAnimImpulseZ;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.MForcesX != other.MForcesX;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.MForcesY != other.MForcesY;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.MForcesZ != other.MForcesZ;
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.MYaw != other.MYaw;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.MDesiredYaw != other.MDesiredYaw;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.MYawSpeed != other.MYawSpeed;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.MSpeed != other.MSpeed;
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = this.MAnimationScalingTimeScale != other.MAnimationScalingTimeScale;
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = this.MCurrentMotionIsAnimationDriven != other.MCurrentMotionIsAnimationDriven;
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = this.MSnoPowerAnimKeyOverride != other.MSnoPowerAnimKeyOverride;
																																if (flag31)
																																{
																																	flag2 = false;
																																}
																																else
																																{
																																	bool flag32 = this.MPrevCommandFrame != other.MPrevCommandFrame;
																																	flag2 = !flag32 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06002FAC RID: 12204 RVA: 0x000BB468 File Offset: 0x000B9668
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMAnn = this.HasMAnn;
			if (hasMAnn)
			{
				num ^= this.MAnn.GetHashCode();
			}
			bool hasMIsDelta = this.HasMIsDelta;
			if (hasMIsDelta)
			{
				num ^= this.MIsDelta.GetHashCode();
			}
			bool hasMIsTargetState = this.HasMIsTargetState;
			if (hasMIsTargetState)
			{
				num ^= this.MIsTargetState.GetHashCode();
			}
			bool hasMFlags = this.HasMFlags;
			if (hasMFlags)
			{
				num ^= this.MFlags.GetHashCode();
			}
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				num ^= this.MCommandFrame.GetHashCode();
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				num ^= this.MTeleportIndex.GetHashCode();
			}
			bool hasMWorldLocationX = this.HasMWorldLocationX;
			if (hasMWorldLocationX)
			{
				num ^= this.MWorldLocationX.GetHashCode();
			}
			bool hasMWorldLocationY = this.HasMWorldLocationY;
			if (hasMWorldLocationY)
			{
				num ^= this.MWorldLocationY.GetHashCode();
			}
			bool hasMWorldLocationZ = this.HasMWorldLocationZ;
			if (hasMWorldLocationZ)
			{
				num ^= this.MWorldLocationZ.GetHashCode();
			}
			bool hasMVelocityX = this.HasMVelocityX;
			if (hasMVelocityX)
			{
				num ^= this.MVelocityX.GetHashCode();
			}
			bool hasMVelocityY = this.HasMVelocityY;
			if (hasMVelocityY)
			{
				num ^= this.MVelocityY.GetHashCode();
			}
			bool hasMVelocityZ = this.HasMVelocityZ;
			if (hasMVelocityZ)
			{
				num ^= this.MVelocityZ.GetHashCode();
			}
			bool hasMVelFromGravX = this.HasMVelFromGravX;
			if (hasMVelFromGravX)
			{
				num ^= this.MVelFromGravX.GetHashCode();
			}
			bool hasMVelFromGravY = this.HasMVelFromGravY;
			if (hasMVelFromGravY)
			{
				num ^= this.MVelFromGravY.GetHashCode();
			}
			bool hasMVelFromGravZ = this.HasMVelFromGravZ;
			if (hasMVelFromGravZ)
			{
				num ^= this.MVelFromGravZ.GetHashCode();
			}
			bool hasMAnimImpulseX = this.HasMAnimImpulseX;
			if (hasMAnimImpulseX)
			{
				num ^= this.MAnimImpulseX.GetHashCode();
			}
			bool hasMAnimImpulseY = this.HasMAnimImpulseY;
			if (hasMAnimImpulseY)
			{
				num ^= this.MAnimImpulseY.GetHashCode();
			}
			bool hasMAnimImpulseZ = this.HasMAnimImpulseZ;
			if (hasMAnimImpulseZ)
			{
				num ^= this.MAnimImpulseZ.GetHashCode();
			}
			bool hasMForcesX = this.HasMForcesX;
			if (hasMForcesX)
			{
				num ^= this.MForcesX.GetHashCode();
			}
			bool hasMForcesY = this.HasMForcesY;
			if (hasMForcesY)
			{
				num ^= this.MForcesY.GetHashCode();
			}
			bool hasMForcesZ = this.HasMForcesZ;
			if (hasMForcesZ)
			{
				num ^= this.MForcesZ.GetHashCode();
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				num ^= this.MYaw.GetHashCode();
			}
			bool hasMDesiredYaw = this.HasMDesiredYaw;
			if (hasMDesiredYaw)
			{
				num ^= this.MDesiredYaw.GetHashCode();
			}
			bool hasMYawSpeed = this.HasMYawSpeed;
			if (hasMYawSpeed)
			{
				num ^= this.MYawSpeed.GetHashCode();
			}
			bool hasMSpeed = this.HasMSpeed;
			if (hasMSpeed)
			{
				num ^= this.MSpeed.GetHashCode();
			}
			bool hasMAnimationScalingTimeScale = this.HasMAnimationScalingTimeScale;
			if (hasMAnimationScalingTimeScale)
			{
				num ^= this.MAnimationScalingTimeScale.GetHashCode();
			}
			bool hasMCurrentMotionIsAnimationDriven = this.HasMCurrentMotionIsAnimationDriven;
			if (hasMCurrentMotionIsAnimationDriven)
			{
				num ^= this.MCurrentMotionIsAnimationDriven.GetHashCode();
			}
			bool hasMSnoPowerAnimKeyOverride = this.HasMSnoPowerAnimKeyOverride;
			if (hasMSnoPowerAnimKeyOverride)
			{
				num ^= this.MSnoPowerAnimKeyOverride.GetHashCode();
			}
			bool hasMPrevCommandFrame = this.HasMPrevCommandFrame;
			if (hasMPrevCommandFrame)
			{
				num ^= this.MPrevCommandFrame.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x000BB7FC File Offset: 0x000B99FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x000BB814 File Offset: 0x000B9A14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000BB820 File Offset: 0x000B9A20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMAnn = this.HasMAnn;
			if (hasMAnn)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.MAnn);
			}
			bool hasMIsDelta = this.HasMIsDelta;
			if (hasMIsDelta)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MIsDelta);
			}
			bool hasMIsTargetState = this.HasMIsTargetState;
			if (hasMIsTargetState)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.MIsTargetState);
			}
			bool hasMFlags = this.HasMFlags;
			if (hasMFlags)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MFlags);
			}
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MCommandFrame);
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MTeleportIndex);
			}
			bool hasMWorldLocationX = this.HasMWorldLocationX;
			if (hasMWorldLocationX)
			{
				output.WriteRawTag(56);
				output.WriteSInt32(this.MWorldLocationX);
			}
			bool hasMWorldLocationY = this.HasMWorldLocationY;
			if (hasMWorldLocationY)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.MWorldLocationY);
			}
			bool hasMWorldLocationZ = this.HasMWorldLocationZ;
			if (hasMWorldLocationZ)
			{
				output.WriteRawTag(72);
				output.WriteSInt32(this.MWorldLocationZ);
			}
			bool hasMVelocityX = this.HasMVelocityX;
			if (hasMVelocityX)
			{
				output.WriteRawTag(80);
				output.WriteSInt32(this.MVelocityX);
			}
			bool hasMVelocityY = this.HasMVelocityY;
			if (hasMVelocityY)
			{
				output.WriteRawTag(88);
				output.WriteSInt32(this.MVelocityY);
			}
			bool hasMVelocityZ = this.HasMVelocityZ;
			if (hasMVelocityZ)
			{
				output.WriteRawTag(96);
				output.WriteSInt32(this.MVelocityZ);
			}
			bool hasMVelFromGravX = this.HasMVelFromGravX;
			if (hasMVelFromGravX)
			{
				output.WriteRawTag(104);
				output.WriteSInt32(this.MVelFromGravX);
			}
			bool hasMVelFromGravY = this.HasMVelFromGravY;
			if (hasMVelFromGravY)
			{
				output.WriteRawTag(112);
				output.WriteSInt32(this.MVelFromGravY);
			}
			bool hasMVelFromGravZ = this.HasMVelFromGravZ;
			if (hasMVelFromGravZ)
			{
				output.WriteRawTag(120);
				output.WriteSInt32(this.MVelFromGravZ);
			}
			bool hasMAnimImpulseX = this.HasMAnimImpulseX;
			if (hasMAnimImpulseX)
			{
				output.WriteRawTag(128, 1);
				output.WriteSInt32(this.MAnimImpulseX);
			}
			bool hasMAnimImpulseY = this.HasMAnimImpulseY;
			if (hasMAnimImpulseY)
			{
				output.WriteRawTag(136, 1);
				output.WriteSInt32(this.MAnimImpulseY);
			}
			bool hasMAnimImpulseZ = this.HasMAnimImpulseZ;
			if (hasMAnimImpulseZ)
			{
				output.WriteRawTag(144, 1);
				output.WriteSInt32(this.MAnimImpulseZ);
			}
			bool hasMForcesX = this.HasMForcesX;
			if (hasMForcesX)
			{
				output.WriteRawTag(152, 1);
				output.WriteSInt32(this.MForcesX);
			}
			bool hasMForcesY = this.HasMForcesY;
			if (hasMForcesY)
			{
				output.WriteRawTag(160, 1);
				output.WriteSInt32(this.MForcesY);
			}
			bool hasMForcesZ = this.HasMForcesZ;
			if (hasMForcesZ)
			{
				output.WriteRawTag(168, 1);
				output.WriteSInt32(this.MForcesZ);
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				output.WriteRawTag(176, 1);
				output.WriteSInt32(this.MYaw);
			}
			bool hasMDesiredYaw = this.HasMDesiredYaw;
			if (hasMDesiredYaw)
			{
				output.WriteRawTag(184, 1);
				output.WriteSInt32(this.MDesiredYaw);
			}
			bool hasMYawSpeed = this.HasMYawSpeed;
			if (hasMYawSpeed)
			{
				output.WriteRawTag(192, 1);
				output.WriteSInt32(this.MYawSpeed);
			}
			bool hasMSpeed = this.HasMSpeed;
			if (hasMSpeed)
			{
				output.WriteRawTag(200, 1);
				output.WriteSInt32(this.MSpeed);
			}
			bool hasMAnimationScalingTimeScale = this.HasMAnimationScalingTimeScale;
			if (hasMAnimationScalingTimeScale)
			{
				output.WriteRawTag(208, 1);
				output.WriteSInt32(this.MAnimationScalingTimeScale);
			}
			bool hasMCurrentMotionIsAnimationDriven = this.HasMCurrentMotionIsAnimationDriven;
			if (hasMCurrentMotionIsAnimationDriven)
			{
				output.WriteRawTag(216, 1);
				output.WriteBool(this.MCurrentMotionIsAnimationDriven);
			}
			bool hasMSnoPowerAnimKeyOverride = this.HasMSnoPowerAnimKeyOverride;
			if (hasMSnoPowerAnimKeyOverride)
			{
				output.WriteRawTag(237, 1);
				output.WriteSFixed32(this.MSnoPowerAnimKeyOverride);
			}
			bool hasMPrevCommandFrame = this.HasMPrevCommandFrame;
			if (hasMPrevCommandFrame)
			{
				output.WriteRawTag(240, 1);
				output.WriteUInt32(this.MPrevCommandFrame);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x000BBC90 File Offset: 0x000B9E90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMAnn = this.HasMAnn;
			if (hasMAnn)
			{
				num += 5;
			}
			bool hasMIsDelta = this.HasMIsDelta;
			if (hasMIsDelta)
			{
				num += 2;
			}
			bool hasMIsTargetState = this.HasMIsTargetState;
			if (hasMIsTargetState)
			{
				num += 2;
			}
			bool hasMFlags = this.HasMFlags;
			if (hasMFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MFlags);
			}
			bool hasMCommandFrame = this.HasMCommandFrame;
			if (hasMCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCommandFrame);
			}
			bool hasMTeleportIndex = this.HasMTeleportIndex;
			if (hasMTeleportIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MTeleportIndex);
			}
			bool hasMWorldLocationX = this.HasMWorldLocationX;
			if (hasMWorldLocationX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MWorldLocationX);
			}
			bool hasMWorldLocationY = this.HasMWorldLocationY;
			if (hasMWorldLocationY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MWorldLocationY);
			}
			bool hasMWorldLocationZ = this.HasMWorldLocationZ;
			if (hasMWorldLocationZ)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MWorldLocationZ);
			}
			bool hasMVelocityX = this.HasMVelocityX;
			if (hasMVelocityX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelocityX);
			}
			bool hasMVelocityY = this.HasMVelocityY;
			if (hasMVelocityY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelocityY);
			}
			bool hasMVelocityZ = this.HasMVelocityZ;
			if (hasMVelocityZ)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelocityZ);
			}
			bool hasMVelFromGravX = this.HasMVelFromGravX;
			if (hasMVelFromGravX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelFromGravX);
			}
			bool hasMVelFromGravY = this.HasMVelFromGravY;
			if (hasMVelFromGravY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelFromGravY);
			}
			bool hasMVelFromGravZ = this.HasMVelFromGravZ;
			if (hasMVelFromGravZ)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MVelFromGravZ);
			}
			bool hasMAnimImpulseX = this.HasMAnimImpulseX;
			if (hasMAnimImpulseX)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MAnimImpulseX);
			}
			bool hasMAnimImpulseY = this.HasMAnimImpulseY;
			if (hasMAnimImpulseY)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MAnimImpulseY);
			}
			bool hasMAnimImpulseZ = this.HasMAnimImpulseZ;
			if (hasMAnimImpulseZ)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MAnimImpulseZ);
			}
			bool hasMForcesX = this.HasMForcesX;
			if (hasMForcesX)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MForcesX);
			}
			bool hasMForcesY = this.HasMForcesY;
			if (hasMForcesY)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MForcesY);
			}
			bool hasMForcesZ = this.HasMForcesZ;
			if (hasMForcesZ)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MForcesZ);
			}
			bool hasMYaw = this.HasMYaw;
			if (hasMYaw)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MYaw);
			}
			bool hasMDesiredYaw = this.HasMDesiredYaw;
			if (hasMDesiredYaw)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MDesiredYaw);
			}
			bool hasMYawSpeed = this.HasMYawSpeed;
			if (hasMYawSpeed)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MYawSpeed);
			}
			bool hasMSpeed = this.HasMSpeed;
			if (hasMSpeed)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MSpeed);
			}
			bool hasMAnimationScalingTimeScale = this.HasMAnimationScalingTimeScale;
			if (hasMAnimationScalingTimeScale)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.MAnimationScalingTimeScale);
			}
			bool hasMCurrentMotionIsAnimationDriven = this.HasMCurrentMotionIsAnimationDriven;
			if (hasMCurrentMotionIsAnimationDriven)
			{
				num += 3;
			}
			bool hasMSnoPowerAnimKeyOverride = this.HasMSnoPowerAnimKeyOverride;
			if (hasMSnoPowerAnimKeyOverride)
			{
				num += 6;
			}
			bool hasMPrevCommandFrame = this.HasMPrevCommandFrame;
			if (hasMPrevCommandFrame)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.MPrevCommandFrame);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000BBFEC File Offset: 0x000BA1EC
		[DebuggerNonUserCode]
		public void MergeFrom(PhysicsMovementStateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMAnn = other.HasMAnn;
				if (hasMAnn)
				{
					this.MAnn = other.MAnn;
				}
				bool hasMIsDelta = other.HasMIsDelta;
				if (hasMIsDelta)
				{
					this.MIsDelta = other.MIsDelta;
				}
				bool hasMIsTargetState = other.HasMIsTargetState;
				if (hasMIsTargetState)
				{
					this.MIsTargetState = other.MIsTargetState;
				}
				bool hasMFlags = other.HasMFlags;
				if (hasMFlags)
				{
					this.MFlags = other.MFlags;
				}
				bool hasMCommandFrame = other.HasMCommandFrame;
				if (hasMCommandFrame)
				{
					this.MCommandFrame = other.MCommandFrame;
				}
				bool hasMTeleportIndex = other.HasMTeleportIndex;
				if (hasMTeleportIndex)
				{
					this.MTeleportIndex = other.MTeleportIndex;
				}
				bool hasMWorldLocationX = other.HasMWorldLocationX;
				if (hasMWorldLocationX)
				{
					this.MWorldLocationX = other.MWorldLocationX;
				}
				bool hasMWorldLocationY = other.HasMWorldLocationY;
				if (hasMWorldLocationY)
				{
					this.MWorldLocationY = other.MWorldLocationY;
				}
				bool hasMWorldLocationZ = other.HasMWorldLocationZ;
				if (hasMWorldLocationZ)
				{
					this.MWorldLocationZ = other.MWorldLocationZ;
				}
				bool hasMVelocityX = other.HasMVelocityX;
				if (hasMVelocityX)
				{
					this.MVelocityX = other.MVelocityX;
				}
				bool hasMVelocityY = other.HasMVelocityY;
				if (hasMVelocityY)
				{
					this.MVelocityY = other.MVelocityY;
				}
				bool hasMVelocityZ = other.HasMVelocityZ;
				if (hasMVelocityZ)
				{
					this.MVelocityZ = other.MVelocityZ;
				}
				bool hasMVelFromGravX = other.HasMVelFromGravX;
				if (hasMVelFromGravX)
				{
					this.MVelFromGravX = other.MVelFromGravX;
				}
				bool hasMVelFromGravY = other.HasMVelFromGravY;
				if (hasMVelFromGravY)
				{
					this.MVelFromGravY = other.MVelFromGravY;
				}
				bool hasMVelFromGravZ = other.HasMVelFromGravZ;
				if (hasMVelFromGravZ)
				{
					this.MVelFromGravZ = other.MVelFromGravZ;
				}
				bool hasMAnimImpulseX = other.HasMAnimImpulseX;
				if (hasMAnimImpulseX)
				{
					this.MAnimImpulseX = other.MAnimImpulseX;
				}
				bool hasMAnimImpulseY = other.HasMAnimImpulseY;
				if (hasMAnimImpulseY)
				{
					this.MAnimImpulseY = other.MAnimImpulseY;
				}
				bool hasMAnimImpulseZ = other.HasMAnimImpulseZ;
				if (hasMAnimImpulseZ)
				{
					this.MAnimImpulseZ = other.MAnimImpulseZ;
				}
				bool hasMForcesX = other.HasMForcesX;
				if (hasMForcesX)
				{
					this.MForcesX = other.MForcesX;
				}
				bool hasMForcesY = other.HasMForcesY;
				if (hasMForcesY)
				{
					this.MForcesY = other.MForcesY;
				}
				bool hasMForcesZ = other.HasMForcesZ;
				if (hasMForcesZ)
				{
					this.MForcesZ = other.MForcesZ;
				}
				bool hasMYaw = other.HasMYaw;
				if (hasMYaw)
				{
					this.MYaw = other.MYaw;
				}
				bool hasMDesiredYaw = other.HasMDesiredYaw;
				if (hasMDesiredYaw)
				{
					this.MDesiredYaw = other.MDesiredYaw;
				}
				bool hasMYawSpeed = other.HasMYawSpeed;
				if (hasMYawSpeed)
				{
					this.MYawSpeed = other.MYawSpeed;
				}
				bool hasMSpeed = other.HasMSpeed;
				if (hasMSpeed)
				{
					this.MSpeed = other.MSpeed;
				}
				bool hasMAnimationScalingTimeScale = other.HasMAnimationScalingTimeScale;
				if (hasMAnimationScalingTimeScale)
				{
					this.MAnimationScalingTimeScale = other.MAnimationScalingTimeScale;
				}
				bool hasMCurrentMotionIsAnimationDriven = other.HasMCurrentMotionIsAnimationDriven;
				if (hasMCurrentMotionIsAnimationDriven)
				{
					this.MCurrentMotionIsAnimationDriven = other.MCurrentMotionIsAnimationDriven;
				}
				bool hasMSnoPowerAnimKeyOverride = other.HasMSnoPowerAnimKeyOverride;
				if (hasMSnoPowerAnimKeyOverride)
				{
					this.MSnoPowerAnimKeyOverride = other.MSnoPowerAnimKeyOverride;
				}
				bool hasMPrevCommandFrame = other.HasMPrevCommandFrame;
				if (hasMPrevCommandFrame)
				{
					this.MPrevCommandFrame = other.MPrevCommandFrame;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000BC328 File Offset: 0x000BA528
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x000BC334 File Offset: 0x000BA534
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
					if (num3 <= 56U)
					{
						if (num3 <= 24U)
						{
							if (num3 != 13U)
							{
								if (num3 != 16U)
								{
									if (num3 != 24U)
									{
										goto IL_01C3;
									}
									this.MIsTargetState = input.ReadBool();
								}
								else
								{
									this.MIsDelta = input.ReadBool();
								}
							}
							else
							{
								this.MAnn = input.ReadFixed32();
							}
						}
						else if (num3 <= 40U)
						{
							if (num3 != 32U)
							{
								if (num3 != 40U)
								{
									goto IL_01C3;
								}
								this.MCommandFrame = input.ReadUInt32();
							}
							else
							{
								this.MFlags = input.ReadUInt32();
							}
						}
						else if (num3 != 48U)
						{
							if (num3 != 56U)
							{
								goto IL_01C3;
							}
							this.MWorldLocationX = input.ReadSInt32();
						}
						else
						{
							this.MTeleportIndex = input.ReadUInt32();
						}
					}
					else if (num3 <= 80U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								if (num3 != 80U)
								{
									goto IL_01C3;
								}
								this.MVelocityX = input.ReadSInt32();
							}
							else
							{
								this.MWorldLocationZ = input.ReadSInt32();
							}
						}
						else
						{
							this.MWorldLocationY = input.ReadSInt32();
						}
					}
					else if (num3 <= 96U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_01C3;
							}
							this.MVelocityZ = input.ReadSInt32();
						}
						else
						{
							this.MVelocityY = input.ReadSInt32();
						}
					}
					else if (num3 != 104U)
					{
						if (num3 != 112U)
						{
							goto IL_01C3;
						}
						this.MVelFromGravY = input.ReadSInt32();
					}
					else
					{
						this.MVelFromGravX = input.ReadSInt32();
					}
				}
				else if (num3 <= 168U)
				{
					if (num3 <= 136U)
					{
						if (num3 != 120U)
						{
							if (num3 != 128U)
							{
								if (num3 != 136U)
								{
									goto IL_01C3;
								}
								this.MAnimImpulseY = input.ReadSInt32();
							}
							else
							{
								this.MAnimImpulseX = input.ReadSInt32();
							}
						}
						else
						{
							this.MVelFromGravZ = input.ReadSInt32();
						}
					}
					else if (num3 <= 152U)
					{
						if (num3 != 144U)
						{
							if (num3 != 152U)
							{
								goto IL_01C3;
							}
							this.MForcesX = input.ReadSInt32();
						}
						else
						{
							this.MAnimImpulseZ = input.ReadSInt32();
						}
					}
					else if (num3 != 160U)
					{
						if (num3 != 168U)
						{
							goto IL_01C3;
						}
						this.MForcesZ = input.ReadSInt32();
					}
					else
					{
						this.MForcesY = input.ReadSInt32();
					}
				}
				else if (num3 <= 200U)
				{
					if (num3 <= 184U)
					{
						if (num3 != 176U)
						{
							if (num3 != 184U)
							{
								goto IL_01C3;
							}
							this.MDesiredYaw = input.ReadSInt32();
						}
						else
						{
							this.MYaw = input.ReadSInt32();
						}
					}
					else if (num3 != 192U)
					{
						if (num3 != 200U)
						{
							goto IL_01C3;
						}
						this.MSpeed = input.ReadSInt32();
					}
					else
					{
						this.MYawSpeed = input.ReadSInt32();
					}
				}
				else if (num3 <= 216U)
				{
					if (num3 != 208U)
					{
						if (num3 != 216U)
						{
							goto IL_01C3;
						}
						this.MCurrentMotionIsAnimationDriven = input.ReadBool();
					}
					else
					{
						this.MAnimationScalingTimeScale = input.ReadSInt32();
					}
				}
				else if (num3 != 237U)
				{
					if (num3 != 240U)
					{
						goto IL_01C3;
					}
					this.MPrevCommandFrame = input.ReadUInt32();
				}
				else
				{
					this.MSnoPowerAnimKeyOverride = input.ReadSFixed32();
				}
				continue;
				IL_01C3:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001549 RID: 5449
		private static readonly MessageParser<PhysicsMovementStateMessage> _parser = new MessageParser<PhysicsMovementStateMessage>(() => new PhysicsMovementStateMessage());

		// Token: 0x0400154A RID: 5450
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400154B RID: 5451
		private int _hasBits0;

		// Token: 0x0400154C RID: 5452
		public const int MAnnFieldNumber = 1;

		// Token: 0x0400154D RID: 5453
		private static readonly uint MAnnDefaultValue = 0U;

		// Token: 0x0400154E RID: 5454
		private uint mAnn_;

		// Token: 0x0400154F RID: 5455
		public const int MIsDeltaFieldNumber = 2;

		// Token: 0x04001550 RID: 5456
		private static readonly bool MIsDeltaDefaultValue = false;

		// Token: 0x04001551 RID: 5457
		private bool mIsDelta_;

		// Token: 0x04001552 RID: 5458
		public const int MIsTargetStateFieldNumber = 3;

		// Token: 0x04001553 RID: 5459
		private static readonly bool MIsTargetStateDefaultValue = false;

		// Token: 0x04001554 RID: 5460
		private bool mIsTargetState_;

		// Token: 0x04001555 RID: 5461
		public const int MFlagsFieldNumber = 4;

		// Token: 0x04001556 RID: 5462
		private static readonly uint MFlagsDefaultValue = 0U;

		// Token: 0x04001557 RID: 5463
		private uint mFlags_;

		// Token: 0x04001558 RID: 5464
		public const int MCommandFrameFieldNumber = 5;

		// Token: 0x04001559 RID: 5465
		private static readonly uint MCommandFrameDefaultValue = 0U;

		// Token: 0x0400155A RID: 5466
		private uint mCommandFrame_;

		// Token: 0x0400155B RID: 5467
		public const int MTeleportIndexFieldNumber = 6;

		// Token: 0x0400155C RID: 5468
		private static readonly uint MTeleportIndexDefaultValue = 0U;

		// Token: 0x0400155D RID: 5469
		private uint mTeleportIndex_;

		// Token: 0x0400155E RID: 5470
		public const int MWorldLocationXFieldNumber = 7;

		// Token: 0x0400155F RID: 5471
		private static readonly int MWorldLocationXDefaultValue = 0;

		// Token: 0x04001560 RID: 5472
		private int mWorldLocationX_;

		// Token: 0x04001561 RID: 5473
		public const int MWorldLocationYFieldNumber = 8;

		// Token: 0x04001562 RID: 5474
		private static readonly int MWorldLocationYDefaultValue = 0;

		// Token: 0x04001563 RID: 5475
		private int mWorldLocationY_;

		// Token: 0x04001564 RID: 5476
		public const int MWorldLocationZFieldNumber = 9;

		// Token: 0x04001565 RID: 5477
		private static readonly int MWorldLocationZDefaultValue = 0;

		// Token: 0x04001566 RID: 5478
		private int mWorldLocationZ_;

		// Token: 0x04001567 RID: 5479
		public const int MVelocityXFieldNumber = 10;

		// Token: 0x04001568 RID: 5480
		private static readonly int MVelocityXDefaultValue = 0;

		// Token: 0x04001569 RID: 5481
		private int mVelocityX_;

		// Token: 0x0400156A RID: 5482
		public const int MVelocityYFieldNumber = 11;

		// Token: 0x0400156B RID: 5483
		private static readonly int MVelocityYDefaultValue = 0;

		// Token: 0x0400156C RID: 5484
		private int mVelocityY_;

		// Token: 0x0400156D RID: 5485
		public const int MVelocityZFieldNumber = 12;

		// Token: 0x0400156E RID: 5486
		private static readonly int MVelocityZDefaultValue = 0;

		// Token: 0x0400156F RID: 5487
		private int mVelocityZ_;

		// Token: 0x04001570 RID: 5488
		public const int MVelFromGravXFieldNumber = 13;

		// Token: 0x04001571 RID: 5489
		private static readonly int MVelFromGravXDefaultValue = 0;

		// Token: 0x04001572 RID: 5490
		private int mVelFromGravX_;

		// Token: 0x04001573 RID: 5491
		public const int MVelFromGravYFieldNumber = 14;

		// Token: 0x04001574 RID: 5492
		private static readonly int MVelFromGravYDefaultValue = 0;

		// Token: 0x04001575 RID: 5493
		private int mVelFromGravY_;

		// Token: 0x04001576 RID: 5494
		public const int MVelFromGravZFieldNumber = 15;

		// Token: 0x04001577 RID: 5495
		private static readonly int MVelFromGravZDefaultValue = 0;

		// Token: 0x04001578 RID: 5496
		private int mVelFromGravZ_;

		// Token: 0x04001579 RID: 5497
		public const int MAnimImpulseXFieldNumber = 16;

		// Token: 0x0400157A RID: 5498
		private static readonly int MAnimImpulseXDefaultValue = 0;

		// Token: 0x0400157B RID: 5499
		private int mAnimImpulseX_;

		// Token: 0x0400157C RID: 5500
		public const int MAnimImpulseYFieldNumber = 17;

		// Token: 0x0400157D RID: 5501
		private static readonly int MAnimImpulseYDefaultValue = 0;

		// Token: 0x0400157E RID: 5502
		private int mAnimImpulseY_;

		// Token: 0x0400157F RID: 5503
		public const int MAnimImpulseZFieldNumber = 18;

		// Token: 0x04001580 RID: 5504
		private static readonly int MAnimImpulseZDefaultValue = 0;

		// Token: 0x04001581 RID: 5505
		private int mAnimImpulseZ_;

		// Token: 0x04001582 RID: 5506
		public const int MForcesXFieldNumber = 19;

		// Token: 0x04001583 RID: 5507
		private static readonly int MForcesXDefaultValue = 0;

		// Token: 0x04001584 RID: 5508
		private int mForcesX_;

		// Token: 0x04001585 RID: 5509
		public const int MForcesYFieldNumber = 20;

		// Token: 0x04001586 RID: 5510
		private static readonly int MForcesYDefaultValue = 0;

		// Token: 0x04001587 RID: 5511
		private int mForcesY_;

		// Token: 0x04001588 RID: 5512
		public const int MForcesZFieldNumber = 21;

		// Token: 0x04001589 RID: 5513
		private static readonly int MForcesZDefaultValue = 0;

		// Token: 0x0400158A RID: 5514
		private int mForcesZ_;

		// Token: 0x0400158B RID: 5515
		public const int MYawFieldNumber = 22;

		// Token: 0x0400158C RID: 5516
		private static readonly int MYawDefaultValue = 0;

		// Token: 0x0400158D RID: 5517
		private int mYaw_;

		// Token: 0x0400158E RID: 5518
		public const int MDesiredYawFieldNumber = 23;

		// Token: 0x0400158F RID: 5519
		private static readonly int MDesiredYawDefaultValue = 0;

		// Token: 0x04001590 RID: 5520
		private int mDesiredYaw_;

		// Token: 0x04001591 RID: 5521
		public const int MYawSpeedFieldNumber = 24;

		// Token: 0x04001592 RID: 5522
		private static readonly int MYawSpeedDefaultValue = 0;

		// Token: 0x04001593 RID: 5523
		private int mYawSpeed_;

		// Token: 0x04001594 RID: 5524
		public const int MSpeedFieldNumber = 25;

		// Token: 0x04001595 RID: 5525
		private static readonly int MSpeedDefaultValue = 0;

		// Token: 0x04001596 RID: 5526
		private int mSpeed_;

		// Token: 0x04001597 RID: 5527
		public const int MAnimationScalingTimeScaleFieldNumber = 26;

		// Token: 0x04001598 RID: 5528
		private static readonly int MAnimationScalingTimeScaleDefaultValue = 0;

		// Token: 0x04001599 RID: 5529
		private int mAnimationScalingTimeScale_;

		// Token: 0x0400159A RID: 5530
		public const int MCurrentMotionIsAnimationDrivenFieldNumber = 27;

		// Token: 0x0400159B RID: 5531
		private static readonly bool MCurrentMotionIsAnimationDrivenDefaultValue = false;

		// Token: 0x0400159C RID: 5532
		private bool mCurrentMotionIsAnimationDriven_;

		// Token: 0x0400159D RID: 5533
		public const int MSnoPowerAnimKeyOverrideFieldNumber = 29;

		// Token: 0x0400159E RID: 5534
		private static readonly int MSnoPowerAnimKeyOverrideDefaultValue = 0;

		// Token: 0x0400159F RID: 5535
		private int mSnoPowerAnimKeyOverride_;

		// Token: 0x040015A0 RID: 5536
		public const int MPrevCommandFrameFieldNumber = 30;

		// Token: 0x040015A1 RID: 5537
		private static readonly uint MPrevCommandFrameDefaultValue = 0U;

		// Token: 0x040015A2 RID: 5538
		private uint mPrevCommandFrame_;
	}
}
