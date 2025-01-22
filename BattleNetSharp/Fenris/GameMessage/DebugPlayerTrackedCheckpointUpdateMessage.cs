using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001EF RID: 495
	public sealed class DebugPlayerTrackedCheckpointUpdateMessage : IMessage<DebugPlayerTrackedCheckpointUpdateMessage>, IMessage, IEquatable<DebugPlayerTrackedCheckpointUpdateMessage>, IDeepCloneable<DebugPlayerTrackedCheckpointUpdateMessage>, IBufferMessage
	{
		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x000D5764 File Offset: 0x000D3964
		[DebuggerNonUserCode]
		public static MessageParser<DebugPlayerTrackedCheckpointUpdateMessage> Parser
		{
			get
			{
				return DebugPlayerTrackedCheckpointUpdateMessage._parser;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000D577C File Offset: 0x000D397C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[52];
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x000D57A0 File Offset: 0x000D39A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugPlayerTrackedCheckpointUpdateMessage.Descriptor;
			}
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x000D57B7 File Offset: 0x000D39B7
		[DebuggerNonUserCode]
		public DebugPlayerTrackedCheckpointUpdateMessage()
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x000D57CC File Offset: 0x000D39CC
		[DebuggerNonUserCode]
		public DebugPlayerTrackedCheckpointUpdateMessage(DebugPlayerTrackedCheckpointUpdateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.checkpointAnn_ = other.checkpointAnn_;
			this.checkpointHasPositionOverride_ = other.checkpointHasPositionOverride_;
			this.trackedCheckpointCount_ = other.trackedCheckpointCount_;
			this.playerMostRecentCheckpointIndices_ = other.playerMostRecentCheckpointIndices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x000D5858 File Offset: 0x000D3A58
		[DebuggerNonUserCode]
		public DebugPlayerTrackedCheckpointUpdateMessage Clone()
		{
			return new DebugPlayerTrackedCheckpointUpdateMessage(this);
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x000D5870 File Offset: 0x000D3A70
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x000D58A1 File Offset: 0x000D3AA1
		[DebuggerNonUserCode]
		public float PosX
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float posXDefaultValue;
				if (flag)
				{
					posXDefaultValue = this.posX_;
				}
				else
				{
					posXDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.PosXDefaultValue;
				}
				return posXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.posX_ = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x000D58BC File Offset: 0x000D3ABC
		[DebuggerNonUserCode]
		public bool HasPosX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x000D58D9 File Offset: 0x000D3AD9
		[DebuggerNonUserCode]
		public void ClearPosX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x000D58EC File Offset: 0x000D3AEC
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x000D591D File Offset: 0x000D3B1D
		[DebuggerNonUserCode]
		public float PosY
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float posYDefaultValue;
				if (flag)
				{
					posYDefaultValue = this.posY_;
				}
				else
				{
					posYDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.PosYDefaultValue;
				}
				return posYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.posY_ = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x000D5938 File Offset: 0x000D3B38
		[DebuggerNonUserCode]
		public bool HasPosY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x000D5955 File Offset: 0x000D3B55
		[DebuggerNonUserCode]
		public void ClearPosY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x000D5968 File Offset: 0x000D3B68
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x000D5999 File Offset: 0x000D3B99
		[DebuggerNonUserCode]
		public float PosZ
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float posZDefaultValue;
				if (flag)
				{
					posZDefaultValue = this.posZ_;
				}
				else
				{
					posZDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.PosZDefaultValue;
				}
				return posZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.posZ_ = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x000D59B4 File Offset: 0x000D3BB4
		[DebuggerNonUserCode]
		public bool HasPosZ
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x000D59D1 File Offset: 0x000D3BD1
		[DebuggerNonUserCode]
		public void ClearPosZ()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x000D59E4 File Offset: 0x000D3BE4
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x000D5A15 File Offset: 0x000D3C15
		[DebuggerNonUserCode]
		public uint CheckpointAnn
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint checkpointAnnDefaultValue;
				if (flag)
				{
					checkpointAnnDefaultValue = this.checkpointAnn_;
				}
				else
				{
					checkpointAnnDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.CheckpointAnnDefaultValue;
				}
				return checkpointAnnDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.checkpointAnn_ = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x000D5A30 File Offset: 0x000D3C30
		[DebuggerNonUserCode]
		public bool HasCheckpointAnn
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x000D5A4D File Offset: 0x000D3C4D
		[DebuggerNonUserCode]
		public void ClearCheckpointAnn()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x000D5A60 File Offset: 0x000D3C60
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x000D5A92 File Offset: 0x000D3C92
		[DebuggerNonUserCode]
		public bool CheckpointHasPositionOverride
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool checkpointHasPositionOverrideDefaultValue;
				if (flag)
				{
					checkpointHasPositionOverrideDefaultValue = this.checkpointHasPositionOverride_;
				}
				else
				{
					checkpointHasPositionOverrideDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.CheckpointHasPositionOverrideDefaultValue;
				}
				return checkpointHasPositionOverrideDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.checkpointHasPositionOverride_ = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x000D5AAC File Offset: 0x000D3CAC
		[DebuggerNonUserCode]
		public bool HasCheckpointHasPositionOverride
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x000D5ACA File Offset: 0x000D3CCA
		[DebuggerNonUserCode]
		public void ClearCheckpointHasPositionOverride()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x000D5ADC File Offset: 0x000D3CDC
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x000D5B0E File Offset: 0x000D3D0E
		[DebuggerNonUserCode]
		public int TrackedCheckpointCount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int trackedCheckpointCountDefaultValue;
				if (flag)
				{
					trackedCheckpointCountDefaultValue = this.trackedCheckpointCount_;
				}
				else
				{
					trackedCheckpointCountDefaultValue = DebugPlayerTrackedCheckpointUpdateMessage.TrackedCheckpointCountDefaultValue;
				}
				return trackedCheckpointCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.trackedCheckpointCount_ = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x000D5B28 File Offset: 0x000D3D28
		[DebuggerNonUserCode]
		public bool HasTrackedCheckpointCount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x000D5B46 File Offset: 0x000D3D46
		[DebuggerNonUserCode]
		public void ClearTrackedCheckpointCount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x000D5B58 File Offset: 0x000D3D58
		[DebuggerNonUserCode]
		public RepeatedField<int> PlayerMostRecentCheckpointIndices
		{
			get
			{
				return this.playerMostRecentCheckpointIndices_;
			}
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x000D5B70 File Offset: 0x000D3D70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugPlayerTrackedCheckpointUpdateMessage);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x000D5B90 File Offset: 0x000D3D90
		[DebuggerNonUserCode]
		public bool Equals(DebugPlayerTrackedCheckpointUpdateMessage other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CheckpointAnn != other.CheckpointAnn;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CheckpointHasPositionOverride != other.CheckpointHasPositionOverride;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.TrackedCheckpointCount != other.TrackedCheckpointCount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.playerMostRecentCheckpointIndices_.Equals(other.playerMostRecentCheckpointIndices_);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600361A RID: 13850 RVA: 0x000D5CB4 File Offset: 0x000D3EB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool hasCheckpointAnn = this.HasCheckpointAnn;
			if (hasCheckpointAnn)
			{
				num ^= this.CheckpointAnn.GetHashCode();
			}
			bool hasCheckpointHasPositionOverride = this.HasCheckpointHasPositionOverride;
			if (hasCheckpointHasPositionOverride)
			{
				num ^= this.CheckpointHasPositionOverride.GetHashCode();
			}
			bool hasTrackedCheckpointCount = this.HasTrackedCheckpointCount;
			if (hasTrackedCheckpointCount)
			{
				num ^= this.TrackedCheckpointCount.GetHashCode();
			}
			num ^= this.playerMostRecentCheckpointIndices_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x000D5DAC File Offset: 0x000D3FAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x000D5DC4 File Offset: 0x000D3FC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x000D5DD0 File Offset: 0x000D3FD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosZ);
			}
			bool hasCheckpointAnn = this.HasCheckpointAnn;
			if (hasCheckpointAnn)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.CheckpointAnn);
			}
			bool hasCheckpointHasPositionOverride = this.HasCheckpointHasPositionOverride;
			if (hasCheckpointHasPositionOverride)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CheckpointHasPositionOverride);
			}
			bool hasTrackedCheckpointCount = this.HasTrackedCheckpointCount;
			if (hasTrackedCheckpointCount)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TrackedCheckpointCount);
			}
			this.playerMostRecentCheckpointIndices_.WriteTo(ref output, DebugPlayerTrackedCheckpointUpdateMessage._repeated_playerMostRecentCheckpointIndices_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x000D5EE0 File Offset: 0x000D40E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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
			bool hasCheckpointAnn = this.HasCheckpointAnn;
			if (hasCheckpointAnn)
			{
				num += 5;
			}
			bool hasCheckpointHasPositionOverride = this.HasCheckpointHasPositionOverride;
			if (hasCheckpointHasPositionOverride)
			{
				num += 2;
			}
			bool hasTrackedCheckpointCount = this.HasTrackedCheckpointCount;
			if (hasTrackedCheckpointCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrackedCheckpointCount);
			}
			num += this.playerMostRecentCheckpointIndices_.CalculateSize(DebugPlayerTrackedCheckpointUpdateMessage._repeated_playerMostRecentCheckpointIndices_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x000D5F9C File Offset: 0x000D419C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugPlayerTrackedCheckpointUpdateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasCheckpointAnn = other.HasCheckpointAnn;
				if (hasCheckpointAnn)
				{
					this.CheckpointAnn = other.CheckpointAnn;
				}
				bool hasCheckpointHasPositionOverride = other.HasCheckpointHasPositionOverride;
				if (hasCheckpointHasPositionOverride)
				{
					this.CheckpointHasPositionOverride = other.CheckpointHasPositionOverride;
				}
				bool hasTrackedCheckpointCount = other.HasTrackedCheckpointCount;
				if (hasTrackedCheckpointCount)
				{
					this.TrackedCheckpointCount = other.TrackedCheckpointCount;
				}
				this.playerMostRecentCheckpointIndices_.Add(other.playerMostRecentCheckpointIndices_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x000D607D File Offset: 0x000D427D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x000D6088 File Offset: 0x000D4288
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
						if (num3 != 13U)
						{
							if (num3 != 21U)
							{
								goto IL_0052;
							}
							this.PosY = input.ReadFloat();
						}
						else
						{
							this.PosX = input.ReadFloat();
						}
					}
					else if (num3 != 29U)
					{
						if (num3 != 37U)
						{
							goto IL_0052;
						}
						this.CheckpointAnn = input.ReadFixed32();
					}
					else
					{
						this.PosZ = input.ReadFloat();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0052;
						}
						this.TrackedCheckpointCount = input.ReadInt32();
					}
					else
					{
						this.CheckpointHasPositionOverride = input.ReadBool();
					}
				}
				else
				{
					if (num3 != 56U && num3 != 58U)
					{
						goto IL_0052;
					}
					this.playerMostRecentCheckpointIndices_.AddEntriesFrom(ref input, DebugPlayerTrackedCheckpointUpdateMessage._repeated_playerMostRecentCheckpointIndices_codec);
				}
				continue;
				IL_0052:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001909 RID: 6409
		private static readonly MessageParser<DebugPlayerTrackedCheckpointUpdateMessage> _parser = new MessageParser<DebugPlayerTrackedCheckpointUpdateMessage>(() => new DebugPlayerTrackedCheckpointUpdateMessage());

		// Token: 0x0400190A RID: 6410
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400190B RID: 6411
		private int _hasBits0;

		// Token: 0x0400190C RID: 6412
		public const int PosXFieldNumber = 1;

		// Token: 0x0400190D RID: 6413
		private static readonly float PosXDefaultValue = 0f;

		// Token: 0x0400190E RID: 6414
		private float posX_;

		// Token: 0x0400190F RID: 6415
		public const int PosYFieldNumber = 2;

		// Token: 0x04001910 RID: 6416
		private static readonly float PosYDefaultValue = 0f;

		// Token: 0x04001911 RID: 6417
		private float posY_;

		// Token: 0x04001912 RID: 6418
		public const int PosZFieldNumber = 3;

		// Token: 0x04001913 RID: 6419
		private static readonly float PosZDefaultValue = 0f;

		// Token: 0x04001914 RID: 6420
		private float posZ_;

		// Token: 0x04001915 RID: 6421
		public const int CheckpointAnnFieldNumber = 4;

		// Token: 0x04001916 RID: 6422
		private static readonly uint CheckpointAnnDefaultValue = 0U;

		// Token: 0x04001917 RID: 6423
		private uint checkpointAnn_;

		// Token: 0x04001918 RID: 6424
		public const int CheckpointHasPositionOverrideFieldNumber = 5;

		// Token: 0x04001919 RID: 6425
		private static readonly bool CheckpointHasPositionOverrideDefaultValue = false;

		// Token: 0x0400191A RID: 6426
		private bool checkpointHasPositionOverride_;

		// Token: 0x0400191B RID: 6427
		public const int TrackedCheckpointCountFieldNumber = 6;

		// Token: 0x0400191C RID: 6428
		private static readonly int TrackedCheckpointCountDefaultValue = 0;

		// Token: 0x0400191D RID: 6429
		private int trackedCheckpointCount_;

		// Token: 0x0400191E RID: 6430
		public const int PlayerMostRecentCheckpointIndicesFieldNumber = 7;

		// Token: 0x0400191F RID: 6431
		private static readonly FieldCodec<int> _repeated_playerMostRecentCheckpointIndices_codec = FieldCodec.ForInt32(56U);

		// Token: 0x04001920 RID: 6432
		private readonly RepeatedField<int> playerMostRecentCheckpointIndices_ = new RepeatedField<int>();
	}
}
