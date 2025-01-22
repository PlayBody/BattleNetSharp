using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000790 RID: 1936
	public sealed class GameJoinRequest : IMessage<GameJoinRequest>, IMessage, IEquatable<GameJoinRequest>, IDeepCloneable<GameJoinRequest>, IBufferMessage
	{
		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x002B3300 File Offset: 0x002B1500
		[DebuggerNonUserCode]
		public static MessageParser<GameJoinRequest> Parser
		{
			get
			{
				return GameJoinRequest._parser;
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600B17D RID: 45437 RVA: 0x002B3318 File Offset: 0x002B1518
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x002B333C File Offset: 0x002B153C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameJoinRequest.Descriptor;
			}
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x002B3353 File Offset: 0x002B1553
		[DebuggerNonUserCode]
		public GameJoinRequest()
		{
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x002B3360 File Offset: 0x002B1560
		[DebuggerNonUserCode]
		public GameJoinRequest(GameJoinRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.charId_ = other.charId_;
			this.gameName_ = other.gameName_;
			this.gamePassword_ = other.gamePassword_;
			this.region_ = other.region_;
			this.charLevel_ = other.charLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x002B33D0 File Offset: 0x002B15D0
		[DebuggerNonUserCode]
		public GameJoinRequest Clone()
		{
			return new GameJoinRequest(this);
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600B182 RID: 45442 RVA: 0x002B33E8 File Offset: 0x002B15E8
		// (set) Token: 0x0600B183 RID: 45443 RVA: 0x002B3419 File Offset: 0x002B1619
		[DebuggerNonUserCode]
		public uint CharId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint charIdDefaultValue;
				if (flag)
				{
					charIdDefaultValue = this.charId_;
				}
				else
				{
					charIdDefaultValue = GameJoinRequest.CharIdDefaultValue;
				}
				return charIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.charId_ = value;
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600B184 RID: 45444 RVA: 0x002B3434 File Offset: 0x002B1634
		[DebuggerNonUserCode]
		public bool HasCharId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x002B3451 File Offset: 0x002B1651
		[DebuggerNonUserCode]
		public void ClearCharId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600B186 RID: 45446 RVA: 0x002B3464 File Offset: 0x002B1664
		// (set) Token: 0x0600B187 RID: 45447 RVA: 0x002B3485 File Offset: 0x002B1685
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameJoinRequest.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x002B349C File Offset: 0x002B169C
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x002B34B7 File Offset: 0x002B16B7
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x002B34C4 File Offset: 0x002B16C4
		// (set) Token: 0x0600B18B RID: 45451 RVA: 0x002B34E5 File Offset: 0x002B16E5
		[DebuggerNonUserCode]
		public string GamePassword
		{
			get
			{
				return this.gamePassword_ ?? GameJoinRequest.GamePasswordDefaultValue;
			}
			set
			{
				this.gamePassword_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x002B34FC File Offset: 0x002B16FC
		[DebuggerNonUserCode]
		public bool HasGamePassword
		{
			get
			{
				return this.gamePassword_ != null;
			}
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x002B3517 File Offset: 0x002B1717
		[DebuggerNonUserCode]
		public void ClearGamePassword()
		{
			this.gamePassword_ = null;
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x002B3524 File Offset: 0x002B1724
		// (set) Token: 0x0600B18F RID: 45455 RVA: 0x002B3545 File Offset: 0x002B1745
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return this.region_ ?? GameJoinRequest.RegionDefaultValue;
			}
			set
			{
				this.region_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x002B355C File Offset: 0x002B175C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return this.region_ != null;
			}
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x002B3577 File Offset: 0x002B1777
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this.region_ = null;
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x002B3584 File Offset: 0x002B1784
		// (set) Token: 0x0600B193 RID: 45459 RVA: 0x002B35B5 File Offset: 0x002B17B5
		[DebuggerNonUserCode]
		public uint CharLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint charLevelDefaultValue;
				if (flag)
				{
					charLevelDefaultValue = this.charLevel_;
				}
				else
				{
					charLevelDefaultValue = GameJoinRequest.CharLevelDefaultValue;
				}
				return charLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.charLevel_ = value;
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x002B35D0 File Offset: 0x002B17D0
		[DebuggerNonUserCode]
		public bool HasCharLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x002B35ED File Offset: 0x002B17ED
		[DebuggerNonUserCode]
		public void ClearCharLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x002B3600 File Offset: 0x002B1800
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameJoinRequest);
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x002B3620 File Offset: 0x002B1820
		[DebuggerNonUserCode]
		public bool Equals(GameJoinRequest other)
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
					bool flag4 = this.CharId != other.CharId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameName != other.GameName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GamePassword != other.GamePassword;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Region != other.Region;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CharLevel != other.CharLevel;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B198 RID: 45464 RVA: 0x002B36EC File Offset: 0x002B18EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num ^= this.CharId.GetHashCode();
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num ^= this.GameName.GetHashCode();
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				num ^= this.GamePassword.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num ^= this.CharLevel.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x002B37A8 File Offset: 0x002B19A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x002B37C0 File Offset: 0x002B19C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x002B37CC File Offset: 0x002B19CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CharId);
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameName);
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				output.WriteRawTag(26);
				output.WriteString(this.GamePassword);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Region);
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.CharLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x002B38A4 File Offset: 0x002B1AA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharId);
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameName);
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GamePassword);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Region);
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x002B396C File Offset: 0x002B1B6C
		[DebuggerNonUserCode]
		public void MergeFrom(GameJoinRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCharId = other.HasCharId;
				if (hasCharId)
				{
					this.CharId = other.CharId;
				}
				bool hasGameName = other.HasGameName;
				if (hasGameName)
				{
					this.GameName = other.GameName;
				}
				bool hasGamePassword = other.HasGamePassword;
				if (hasGamePassword)
				{
					this.GamePassword = other.GamePassword;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasCharLevel = other.HasCharLevel;
				if (hasCharLevel)
				{
					this.CharLevel = other.CharLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x002B3A20 File Offset: 0x002B1C20
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x002B3A2C File Offset: 0x002B1C2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0032;
						}
						this.GameName = input.ReadString();
					}
					else
					{
						this.CharId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.CharLevel = input.ReadUInt32();
					}
					else
					{
						this.Region = input.ReadString();
					}
				}
				else
				{
					this.GamePassword = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400500C RID: 20492
		private static readonly MessageParser<GameJoinRequest> _parser = new MessageParser<GameJoinRequest>(() => new GameJoinRequest());

		// Token: 0x0400500D RID: 20493
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400500E RID: 20494
		private int _hasBits0;

		// Token: 0x0400500F RID: 20495
		public const int CharIdFieldNumber = 1;

		// Token: 0x04005010 RID: 20496
		private static readonly uint CharIdDefaultValue = 0U;

		// Token: 0x04005011 RID: 20497
		private uint charId_;

		// Token: 0x04005012 RID: 20498
		public const int GameNameFieldNumber = 2;

		// Token: 0x04005013 RID: 20499
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x04005014 RID: 20500
		private string gameName_;

		// Token: 0x04005015 RID: 20501
		public const int GamePasswordFieldNumber = 3;

		// Token: 0x04005016 RID: 20502
		private static readonly string GamePasswordDefaultValue = "";

		// Token: 0x04005017 RID: 20503
		private string gamePassword_;

		// Token: 0x04005018 RID: 20504
		public const int RegionFieldNumber = 4;

		// Token: 0x04005019 RID: 20505
		private static readonly string RegionDefaultValue = "";

		// Token: 0x0400501A RID: 20506
		private string region_;

		// Token: 0x0400501B RID: 20507
		public const int CharLevelFieldNumber = 5;

		// Token: 0x0400501C RID: 20508
		private static readonly uint CharLevelDefaultValue = 0U;

		// Token: 0x0400501D RID: 20509
		private uint charLevel_;
	}
}
