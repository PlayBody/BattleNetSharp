using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000153 RID: 339
	public sealed class PlayerNotification : IMessage<PlayerNotification>, IMessage, IEquatable<PlayerNotification>, IDeepCloneable<PlayerNotification>, IBufferMessage
	{
		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000882D8 File Offset: 0x000864D8
		[DebuggerNonUserCode]
		public static MessageParser<PlayerNotification> Parser
		{
			get
			{
				return PlayerNotification._parser;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000882F0 File Offset: 0x000864F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00088314 File Offset: 0x00086514
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNotification.Descriptor;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0008832B File Offset: 0x0008652B
		[DebuggerNonUserCode]
		public PlayerNotification()
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0008833C File Offset: 0x0008653C
		[DebuggerNonUserCode]
		public PlayerNotification(PlayerNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = other.type_;
			switch (other.DataCase)
			{
			case PlayerNotification.DataOneofCase.ComplaintType:
				this.ComplaintType = other.ComplaintType;
				break;
			case PlayerNotification.DataOneofCase.NewClanRank:
				this.NewClanRank = other.NewClanRank;
				break;
			case PlayerNotification.DataOneofCase.ClanName:
				this.ClanName = other.ClanName;
				break;
			case PlayerNotification.DataOneofCase.FallenHeroReplaced:
				this.FallenHeroReplaced = other.FallenHeroReplaced;
				break;
			case PlayerNotification.DataOneofCase.ClanUgcReset:
				this.ClanUgcReset = other.ClanUgcReset.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00088400 File Offset: 0x00086600
		[DebuggerNonUserCode]
		public PlayerNotification Clone()
		{
			return new PlayerNotification(this);
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00088418 File Offset: 0x00086618
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x00088439 File Offset: 0x00086639
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? PlayerNotification.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00088450 File Offset: 0x00086650
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0008846B File Offset: 0x0008666B
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x00088478 File Offset: 0x00086678
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x000884A9 File Offset: 0x000866A9
		[DebuggerNonUserCode]
		public PlayerNotification.Types.Type Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PlayerNotification.Types.Type typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = PlayerNotification.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000884C4 File Offset: 0x000866C4
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000884E1 File Offset: 0x000866E1
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000884F4 File Offset: 0x000866F4
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x00088520 File Offset: 0x00086720
		[DebuggerNonUserCode]
		public string ComplaintType
		{
			get
			{
				return this.HasComplaintType ? ((string)this.data_) : "";
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.dataCase_ = PlayerNotification.DataOneofCase.ComplaintType;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0008853C File Offset: 0x0008673C
		[DebuggerNonUserCode]
		public bool HasComplaintType
		{
			get
			{
				return this.dataCase_ == PlayerNotification.DataOneofCase.ComplaintType;
			}
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00088558 File Offset: 0x00086758
		[DebuggerNonUserCode]
		public void ClearComplaintType()
		{
			bool hasComplaintType = this.HasComplaintType;
			if (hasComplaintType)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0008857C File Offset: 0x0008677C
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x000885A4 File Offset: 0x000867A4
		[DebuggerNonUserCode]
		public uint NewClanRank
		{
			get
			{
				return this.HasNewClanRank ? ((uint)this.data_) : 0U;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = PlayerNotification.DataOneofCase.NewClanRank;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000885BC File Offset: 0x000867BC
		[DebuggerNonUserCode]
		public bool HasNewClanRank
		{
			get
			{
				return this.dataCase_ == PlayerNotification.DataOneofCase.NewClanRank;
			}
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x000885D8 File Offset: 0x000867D8
		[DebuggerNonUserCode]
		public void ClearNewClanRank()
		{
			bool hasNewClanRank = this.HasNewClanRank;
			if (hasNewClanRank)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000885FC File Offset: 0x000867FC
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x00088628 File Offset: 0x00086828
		[DebuggerNonUserCode]
		public string ClanName
		{
			get
			{
				return this.HasClanName ? ((string)this.data_) : "";
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.dataCase_ = PlayerNotification.DataOneofCase.ClanName;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x00088644 File Offset: 0x00086844
		[DebuggerNonUserCode]
		public bool HasClanName
		{
			get
			{
				return this.dataCase_ == PlayerNotification.DataOneofCase.ClanName;
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00088660 File Offset: 0x00086860
		[DebuggerNonUserCode]
		public void ClearClanName()
		{
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x00088684 File Offset: 0x00086884
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x000886AC File Offset: 0x000868AC
		[DebuggerNonUserCode]
		public bool FallenHeroReplaced
		{
			get
			{
				return this.HasFallenHeroReplaced && (bool)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = PlayerNotification.DataOneofCase.FallenHeroReplaced;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000886C4 File Offset: 0x000868C4
		[DebuggerNonUserCode]
		public bool HasFallenHeroReplaced
		{
			get
			{
				return this.dataCase_ == PlayerNotification.DataOneofCase.FallenHeroReplaced;
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x000886E0 File Offset: 0x000868E0
		[DebuggerNonUserCode]
		public void ClearFallenHeroReplaced()
		{
			bool hasFallenHeroReplaced = this.HasFallenHeroReplaced;
			if (hasFallenHeroReplaced)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x00088704 File Offset: 0x00086904
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0008872D File Offset: 0x0008692D
		[DebuggerNonUserCode]
		public ClanUGCReset ClanUgcReset
		{
			get
			{
				return (this.dataCase_ == PlayerNotification.DataOneofCase.ClanUgcReset) ? ((ClanUGCReset)this.data_) : null;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PlayerNotification.DataOneofCase.None : PlayerNotification.DataOneofCase.ClanUgcReset);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x00088744 File Offset: 0x00086944
		[DebuggerNonUserCode]
		public PlayerNotification.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0008875C File Offset: 0x0008695C
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.dataCase_ = PlayerNotification.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00088770 File Offset: 0x00086970
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNotification);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00088790 File Offset: 0x00086990
		[DebuggerNonUserCode]
		public bool Equals(PlayerNotification other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Type != other.Type;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ComplaintType != other.ComplaintType;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.NewClanRank != other.NewClanRank;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ClanName != other.ClanName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.FallenHeroReplaced != other.FallenHeroReplaced;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.ClanUgcReset, other.ClanUgcReset);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.DataCase != other.DataCase;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600233A RID: 9018 RVA: 0x000888B8 File Offset: 0x00086AB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasComplaintType = this.HasComplaintType;
			if (hasComplaintType)
			{
				num ^= this.ComplaintType.GetHashCode();
			}
			bool hasNewClanRank = this.HasNewClanRank;
			if (hasNewClanRank)
			{
				num ^= this.NewClanRank.GetHashCode();
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num ^= this.ClanName.GetHashCode();
			}
			bool hasFallenHeroReplaced = this.HasFallenHeroReplaced;
			if (hasFallenHeroReplaced)
			{
				num ^= this.FallenHeroReplaced.GetHashCode();
			}
			bool flag = this.dataCase_ == PlayerNotification.DataOneofCase.ClanUgcReset;
			if (flag)
			{
				num ^= this.ClanUgcReset.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000889C0 File Offset: 0x00086BC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x000889D8 File Offset: 0x00086BD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000889E4 File Offset: 0x00086BE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			bool hasComplaintType = this.HasComplaintType;
			if (hasComplaintType)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ComplaintType);
			}
			bool hasNewClanRank = this.HasNewClanRank;
			if (hasNewClanRank)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.NewClanRank);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ClanName);
			}
			bool hasFallenHeroReplaced = this.HasFallenHeroReplaced;
			if (hasFallenHeroReplaced)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FallenHeroReplaced);
			}
			bool flag = this.dataCase_ == PlayerNotification.DataOneofCase.ClanUgcReset;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ClanUgcReset);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00088B08 File Offset: 0x00086D08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			bool hasComplaintType = this.HasComplaintType;
			if (hasComplaintType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ComplaintType);
			}
			bool hasNewClanRank = this.HasNewClanRank;
			if (hasNewClanRank)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NewClanRank);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanName);
			}
			bool hasFallenHeroReplaced = this.HasFallenHeroReplaced;
			if (hasFallenHeroReplaced)
			{
				num += 2;
			}
			bool flag = this.dataCase_ == PlayerNotification.DataOneofCase.ClanUgcReset;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClanUgcReset);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00088C04 File Offset: 0x00086E04
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				switch (other.DataCase)
				{
				case PlayerNotification.DataOneofCase.ComplaintType:
					this.ComplaintType = other.ComplaintType;
					break;
				case PlayerNotification.DataOneofCase.NewClanRank:
					this.NewClanRank = other.NewClanRank;
					break;
				case PlayerNotification.DataOneofCase.ClanName:
					this.ClanName = other.ClanName;
					break;
				case PlayerNotification.DataOneofCase.FallenHeroReplaced:
					this.FallenHeroReplaced = other.FallenHeroReplaced;
					break;
				case PlayerNotification.DataOneofCase.ClanUgcReset:
				{
					bool flag2 = this.ClanUgcReset == null;
					if (flag2)
					{
						this.ClanUgcReset = new ClanUGCReset();
					}
					this.ClanUgcReset.MergeFrom(other.ClanUgcReset);
					break;
				}
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00088CFF File Offset: 0x00086EFF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00088D0C File Offset: 0x00086F0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 34U)
							{
								goto IL_0046;
							}
							this.ComplaintType = input.ReadString();
						}
						else
						{
							this.Type = (PlayerNotification.Types.Type)input.ReadEnum();
						}
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_0046;
						}
						this.ClanName = input.ReadString();
					}
					else
					{
						this.NewClanRank = input.ReadUInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						goto IL_0046;
					}
					ClanUGCReset clanUGCReset = new ClanUGCReset();
					bool flag = this.dataCase_ == PlayerNotification.DataOneofCase.ClanUgcReset;
					if (flag)
					{
						clanUGCReset.MergeFrom(this.ClanUgcReset);
					}
					input.ReadMessage(clanUGCReset);
					this.ClanUgcReset = clanUGCReset;
				}
				else
				{
					this.FallenHeroReplaced = input.ReadBool();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F6B RID: 3947
		private static readonly MessageParser<PlayerNotification> _parser = new MessageParser<PlayerNotification>(() => new PlayerNotification());

		// Token: 0x04000F6C RID: 3948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F6D RID: 3949
		private int _hasBits0;

		// Token: 0x04000F6E RID: 3950
		public const int IdFieldNumber = 1;

		// Token: 0x04000F6F RID: 3951
		private static readonly string IdDefaultValue = "";

		// Token: 0x04000F70 RID: 3952
		private string id_;

		// Token: 0x04000F71 RID: 3953
		public const int TypeFieldNumber = 2;

		// Token: 0x04000F72 RID: 3954
		private static readonly PlayerNotification.Types.Type TypeDefaultValue = PlayerNotification.Types.Type.Invalid;

		// Token: 0x04000F73 RID: 3955
		private PlayerNotification.Types.Type type_;

		// Token: 0x04000F74 RID: 3956
		public const int ComplaintTypeFieldNumber = 4;

		// Token: 0x04000F75 RID: 3957
		public const int NewClanRankFieldNumber = 5;

		// Token: 0x04000F76 RID: 3958
		public const int ClanNameFieldNumber = 6;

		// Token: 0x04000F77 RID: 3959
		public const int FallenHeroReplacedFieldNumber = 7;

		// Token: 0x04000F78 RID: 3960
		public const int ClanUgcResetFieldNumber = 8;

		// Token: 0x04000F79 RID: 3961
		private object data_;

		// Token: 0x04000F7A RID: 3962
		private PlayerNotification.DataOneofCase dataCase_ = PlayerNotification.DataOneofCase.None;

		// Token: 0x02000C72 RID: 3186
		public enum DataOneofCase
		{
			// Token: 0x040093D2 RID: 37842
			None,
			// Token: 0x040093D3 RID: 37843
			ComplaintType = 4,
			// Token: 0x040093D4 RID: 37844
			NewClanRank,
			// Token: 0x040093D5 RID: 37845
			ClanName,
			// Token: 0x040093D6 RID: 37846
			FallenHeroReplaced,
			// Token: 0x040093D7 RID: 37847
			ClanUgcReset
		}

		// Token: 0x02000C73 RID: 3187
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001480 RID: 5248
			public enum Type
			{
				// Token: 0x0400A40B RID: 41995
				[OriginalName("INVALID")]
				Invalid,
				// Token: 0x0400A40C RID: 41996
				[OriginalName("COMPLAINT_NEAR_PENALTY_WARNING")]
				ComplaintNearPenaltyWarning,
				// Token: 0x0400A40D RID: 41997
				[OriginalName("COMPLAINT_ACTION_TAKEN")]
				ComplaintActionTaken,
				// Token: 0x0400A40E RID: 41998
				[OriginalName("CLAN_PROMOTION")]
				ClanPromotion,
				// Token: 0x0400A40F RID: 41999
				[OriginalName("CLAN_DEMOTION")]
				ClanDemotion,
				// Token: 0x0400A410 RID: 42000
				[OriginalName("CLAN_KICK")]
				ClanKick,
				// Token: 0x0400A411 RID: 42001
				[OriginalName("CLAN_BAN")]
				ClanBan,
				// Token: 0x0400A412 RID: 42002
				[OriginalName("CLAN_DISBAND")]
				ClanDisband,
				// Token: 0x0400A413 RID: 42003
				[OriginalName("FALLEN_HERO_CREATED")]
				FallenHeroCreated,
				// Token: 0x0400A414 RID: 42004
				[OriginalName("HARDCORE_HERO_DELETED")]
				HardcoreHeroDeleted,
				// Token: 0x0400A415 RID: 42005
				[OriginalName("CLAN_UGC_RESET")]
				ClanUgcReset,
				// Token: 0x0400A416 RID: 42006
				[OriginalName("HERO_FORCE_RENAMED")]
				HeroForceRenamed
			}
		}
	}
}
