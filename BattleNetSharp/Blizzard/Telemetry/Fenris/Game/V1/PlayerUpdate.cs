using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F8 RID: 760
	public sealed class PlayerUpdate : IMessage<PlayerUpdate>, IMessage, IEquatable<PlayerUpdate>, IDeepCloneable<PlayerUpdate>, IBufferMessage
	{
		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x001332D8 File Offset: 0x001314D8
		[DebuggerNonUserCode]
		public static MessageParser<PlayerUpdate> Parser
		{
			get
			{
				return PlayerUpdate._parser;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x001332F0 File Offset: 0x001314F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerUpdateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x00133314 File Offset: 0x00131514
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerUpdate.Descriptor;
			}
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x0013332B File Offset: 0x0013152B
		[DebuggerNonUserCode]
		public PlayerUpdate()
		{
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00133340 File Offset: 0x00131540
		[DebuggerNonUserCode]
		public PlayerUpdate(PlayerUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.playerList_ = other.playerList_.Clone();
			this.gameHandle_ = other.gameHandle_;
			this.usingController_ = other.usingController_;
			this.avgLatency_ = other.avgLatency_;
			this.lagCompensationTicks_ = other.lagCompensationTicks_;
			this.mounted_ = other.mounted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x001333C0 File Offset: 0x001315C0
		[DebuggerNonUserCode]
		public PlayerUpdate Clone()
		{
			return new PlayerUpdate(this);
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x001333D8 File Offset: 0x001315D8
		[DebuggerNonUserCode]
		public RepeatedField<HeroInfo> PlayerList
		{
			get
			{
				return this.playerList_;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x001333F0 File Offset: 0x001315F0
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x00133411 File Offset: 0x00131611
		[DebuggerNonUserCode]
		public string GameHandle
		{
			get
			{
				return this.gameHandle_ ?? PlayerUpdate.GameHandleDefaultValue;
			}
			set
			{
				this.gameHandle_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x00133428 File Offset: 0x00131628
		[DebuggerNonUserCode]
		public bool HasGameHandle
		{
			get
			{
				return this.gameHandle_ != null;
			}
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00133443 File Offset: 0x00131643
		[DebuggerNonUserCode]
		public void ClearGameHandle()
		{
			this.gameHandle_ = null;
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x00133450 File Offset: 0x00131650
		// (set) Token: 0x06005000 RID: 20480 RVA: 0x00133481 File Offset: 0x00131681
		[DebuggerNonUserCode]
		public bool UsingController
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool usingControllerDefaultValue;
				if (flag)
				{
					usingControllerDefaultValue = this.usingController_;
				}
				else
				{
					usingControllerDefaultValue = PlayerUpdate.UsingControllerDefaultValue;
				}
				return usingControllerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.usingController_ = value;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x0013349C File Offset: 0x0013169C
		[DebuggerNonUserCode]
		public bool HasUsingController
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x001334B9 File Offset: 0x001316B9
		[DebuggerNonUserCode]
		public void ClearUsingController()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06005003 RID: 20483 RVA: 0x001334CC File Offset: 0x001316CC
		// (set) Token: 0x06005004 RID: 20484 RVA: 0x001334FD File Offset: 0x001316FD
		[DebuggerNonUserCode]
		public uint AvgLatency
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint avgLatencyDefaultValue;
				if (flag)
				{
					avgLatencyDefaultValue = this.avgLatency_;
				}
				else
				{
					avgLatencyDefaultValue = PlayerUpdate.AvgLatencyDefaultValue;
				}
				return avgLatencyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.avgLatency_ = value;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06005005 RID: 20485 RVA: 0x00133518 File Offset: 0x00131718
		[DebuggerNonUserCode]
		public bool HasAvgLatency
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00133535 File Offset: 0x00131735
		[DebuggerNonUserCode]
		public void ClearAvgLatency()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06005007 RID: 20487 RVA: 0x00133548 File Offset: 0x00131748
		// (set) Token: 0x06005008 RID: 20488 RVA: 0x00133579 File Offset: 0x00131779
		[DebuggerNonUserCode]
		public float LagCompensationTicks
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float lagCompensationTicksDefaultValue;
				if (flag)
				{
					lagCompensationTicksDefaultValue = this.lagCompensationTicks_;
				}
				else
				{
					lagCompensationTicksDefaultValue = PlayerUpdate.LagCompensationTicksDefaultValue;
				}
				return lagCompensationTicksDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lagCompensationTicks_ = value;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06005009 RID: 20489 RVA: 0x00133594 File Offset: 0x00131794
		[DebuggerNonUserCode]
		public bool HasLagCompensationTicks
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x001335B1 File Offset: 0x001317B1
		[DebuggerNonUserCode]
		public void ClearLagCompensationTicks()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600500B RID: 20491 RVA: 0x001335C4 File Offset: 0x001317C4
		// (set) Token: 0x0600500C RID: 20492 RVA: 0x001335F5 File Offset: 0x001317F5
		[DebuggerNonUserCode]
		public bool Mounted
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool mountedDefaultValue;
				if (flag)
				{
					mountedDefaultValue = this.mounted_;
				}
				else
				{
					mountedDefaultValue = PlayerUpdate.MountedDefaultValue;
				}
				return mountedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.mounted_ = value;
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600500D RID: 20493 RVA: 0x00133610 File Offset: 0x00131810
		[DebuggerNonUserCode]
		public bool HasMounted
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x0013362D File Offset: 0x0013182D
		[DebuggerNonUserCode]
		public void ClearMounted()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00133640 File Offset: 0x00131840
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerUpdate);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00133660 File Offset: 0x00131860
		[DebuggerNonUserCode]
		public bool Equals(PlayerUpdate other)
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
					bool flag4 = !this.playerList_.Equals(other.playerList_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameHandle != other.GameHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.UsingController != other.UsingController;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AvgLatency != other.AvgLatency;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LagCompensationTicks, other.LagCompensationTicks);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Mounted != other.Mounted;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00133754 File Offset: 0x00131954
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerList_.GetHashCode();
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasUsingController = this.HasUsingController;
			if (hasUsingController)
			{
				num ^= this.UsingController.GetHashCode();
			}
			bool hasAvgLatency = this.HasAvgLatency;
			if (hasAvgLatency)
			{
				num ^= this.AvgLatency.GetHashCode();
			}
			bool hasLagCompensationTicks = this.HasLagCompensationTicks;
			if (hasLagCompensationTicks)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LagCompensationTicks);
			}
			bool hasMounted = this.HasMounted;
			if (hasMounted)
			{
				num ^= this.Mounted.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00133828 File Offset: 0x00131A28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00133840 File Offset: 0x00131A40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x0013384C File Offset: 0x00131A4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerList_.WriteTo(ref output, PlayerUpdate._repeated_playerList_codec);
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameHandle);
			}
			bool hasUsingController = this.HasUsingController;
			if (hasUsingController)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UsingController);
			}
			bool hasAvgLatency = this.HasAvgLatency;
			if (hasAvgLatency)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AvgLatency);
			}
			bool hasLagCompensationTicks = this.HasLagCompensationTicks;
			if (hasLagCompensationTicks)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.LagCompensationTicks);
			}
			bool hasMounted = this.HasMounted;
			if (hasMounted)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Mounted);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00133938 File Offset: 0x00131B38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerList_.CalculateSize(PlayerUpdate._repeated_playerList_codec);
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameHandle);
			}
			bool hasUsingController = this.HasUsingController;
			if (hasUsingController)
			{
				num += 2;
			}
			bool hasAvgLatency = this.HasAvgLatency;
			if (hasAvgLatency)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvgLatency);
			}
			bool hasLagCompensationTicks = this.HasLagCompensationTicks;
			if (hasLagCompensationTicks)
			{
				num += 5;
			}
			bool hasMounted = this.HasMounted;
			if (hasMounted)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x001339F0 File Offset: 0x00131BF0
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.playerList_.Add(other.playerList_);
				bool hasGameHandle = other.HasGameHandle;
				if (hasGameHandle)
				{
					this.GameHandle = other.GameHandle;
				}
				bool hasUsingController = other.HasUsingController;
				if (hasUsingController)
				{
					this.UsingController = other.UsingController;
				}
				bool hasAvgLatency = other.HasAvgLatency;
				if (hasAvgLatency)
				{
					this.AvgLatency = other.AvgLatency;
				}
				bool hasLagCompensationTicks = other.HasLagCompensationTicks;
				if (hasLagCompensationTicks)
				{
					this.LagCompensationTicks = other.LagCompensationTicks;
				}
				bool hasMounted = other.HasMounted;
				if (hasMounted)
				{
					this.Mounted = other.Mounted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00133AB6 File Offset: 0x00131CB6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x00133AC4 File Offset: 0x00131CC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.UsingController = input.ReadBool();
						}
						else
						{
							this.GameHandle = input.ReadString();
						}
					}
					else
					{
						this.playerList_.AddEntriesFrom(ref input, PlayerUpdate._repeated_playerList_codec);
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 45U)
					{
						if (num3 != 48U)
						{
							goto IL_003A;
						}
						this.Mounted = input.ReadBool();
					}
					else
					{
						this.LagCompensationTicks = input.ReadFloat();
					}
				}
				else
				{
					this.AvgLatency = input.ReadUInt32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023EE RID: 9198
		private static readonly MessageParser<PlayerUpdate> _parser = new MessageParser<PlayerUpdate>(() => new PlayerUpdate());

		// Token: 0x040023EF RID: 9199
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F0 RID: 9200
		private int _hasBits0;

		// Token: 0x040023F1 RID: 9201
		public const int PlayerListFieldNumber = 1;

		// Token: 0x040023F2 RID: 9202
		private static readonly FieldCodec<HeroInfo> _repeated_playerList_codec = FieldCodec.ForMessage<HeroInfo>(10U, HeroInfo.Parser);

		// Token: 0x040023F3 RID: 9203
		private readonly RepeatedField<HeroInfo> playerList_ = new RepeatedField<HeroInfo>();

		// Token: 0x040023F4 RID: 9204
		public const int GameHandleFieldNumber = 2;

		// Token: 0x040023F5 RID: 9205
		private static readonly string GameHandleDefaultValue = "";

		// Token: 0x040023F6 RID: 9206
		private string gameHandle_;

		// Token: 0x040023F7 RID: 9207
		public const int UsingControllerFieldNumber = 3;

		// Token: 0x040023F8 RID: 9208
		private static readonly bool UsingControllerDefaultValue = false;

		// Token: 0x040023F9 RID: 9209
		private bool usingController_;

		// Token: 0x040023FA RID: 9210
		public const int AvgLatencyFieldNumber = 4;

		// Token: 0x040023FB RID: 9211
		private static readonly uint AvgLatencyDefaultValue = 0U;

		// Token: 0x040023FC RID: 9212
		private uint avgLatency_;

		// Token: 0x040023FD RID: 9213
		public const int LagCompensationTicksFieldNumber = 5;

		// Token: 0x040023FE RID: 9214
		private static readonly float LagCompensationTicksDefaultValue = 0f;

		// Token: 0x040023FF RID: 9215
		private float lagCompensationTicks_;

		// Token: 0x04002400 RID: 9216
		public const int MountedFieldNumber = 6;

		// Token: 0x04002401 RID: 9217
		private static readonly bool MountedDefaultValue = false;

		// Token: 0x04002402 RID: 9218
		private bool mounted_;
	}
}
