using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000798 RID: 1944
	public sealed class GameMgmtRequest : IMessage<GameMgmtRequest>, IMessage, IEquatable<GameMgmtRequest>, IDeepCloneable<GameMgmtRequest>, IBufferMessage
	{
		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x002B7F74 File Offset: 0x002B6174
		[DebuggerNonUserCode]
		public static MessageParser<GameMgmtRequest> Parser
		{
			get
			{
				return GameMgmtRequest._parser;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x002B7F8C File Offset: 0x002B618C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600B2C1 RID: 45761 RVA: 0x002B7FB0 File Offset: 0x002B61B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMgmtRequest.Descriptor;
			}
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x002B7FC7 File Offset: 0x002B61C7
		[DebuggerNonUserCode]
		public GameMgmtRequest()
		{
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002B7FE8 File Offset: 0x002B61E8
		[DebuggerNonUserCode]
		public GameMgmtRequest(GameMgmtRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.charId_ = other.charId_;
			this.gameName_ = other.gameName_;
			this.gamePassword_ = other.gamePassword_;
			this.options_ = other.options_.Clone();
			this.neg1_ = other.neg1_;
			this.empty_ = other.empty_;
			this.pings_ = other.pings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x002B8078 File Offset: 0x002B6278
		[DebuggerNonUserCode]
		public GameMgmtRequest Clone()
		{
			return new GameMgmtRequest(this);
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x002B8090 File Offset: 0x002B6290
		// (set) Token: 0x0600B2C6 RID: 45766 RVA: 0x002B80C1 File Offset: 0x002B62C1
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
					charIdDefaultValue = GameMgmtRequest.CharIdDefaultValue;
				}
				return charIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.charId_ = value;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600B2C7 RID: 45767 RVA: 0x002B80DC File Offset: 0x002B62DC
		[DebuggerNonUserCode]
		public bool HasCharId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x002B80F9 File Offset: 0x002B62F9
		[DebuggerNonUserCode]
		public void ClearCharId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600B2C9 RID: 45769 RVA: 0x002B810C File Offset: 0x002B630C
		// (set) Token: 0x0600B2CA RID: 45770 RVA: 0x002B812D File Offset: 0x002B632D
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameMgmtRequest.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600B2CB RID: 45771 RVA: 0x002B8144 File Offset: 0x002B6344
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x002B815F File Offset: 0x002B635F
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600B2CD RID: 45773 RVA: 0x002B816C File Offset: 0x002B636C
		// (set) Token: 0x0600B2CE RID: 45774 RVA: 0x002B818D File Offset: 0x002B638D
		[DebuggerNonUserCode]
		public string GamePassword
		{
			get
			{
				return this.gamePassword_ ?? GameMgmtRequest.GamePasswordDefaultValue;
			}
			set
			{
				this.gamePassword_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600B2CF RID: 45775 RVA: 0x002B81A4 File Offset: 0x002B63A4
		[DebuggerNonUserCode]
		public bool HasGamePassword
		{
			get
			{
				return this.gamePassword_ != null;
			}
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x002B81BF File Offset: 0x002B63BF
		[DebuggerNonUserCode]
		public void ClearGamePassword()
		{
			this.gamePassword_ = null;
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x002B81CC File Offset: 0x002B63CC
		[DebuggerNonUserCode]
		public RepeatedField<GameOption> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x002B81E4 File Offset: 0x002B63E4
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x002B8215 File Offset: 0x002B6415
		[DebuggerNonUserCode]
		public uint Neg1
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint neg1DefaultValue;
				if (flag)
				{
					neg1DefaultValue = this.neg1_;
				}
				else
				{
					neg1DefaultValue = GameMgmtRequest.Neg1DefaultValue;
				}
				return neg1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.neg1_ = value;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x002B8230 File Offset: 0x002B6430
		[DebuggerNonUserCode]
		public bool HasNeg1
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x002B824D File Offset: 0x002B644D
		[DebuggerNonUserCode]
		public void ClearNeg1()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x002B8260 File Offset: 0x002B6460
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x002B8281 File Offset: 0x002B6481
		[DebuggerNonUserCode]
		public string Empty
		{
			get
			{
				return this.empty_ ?? GameMgmtRequest.EmptyDefaultValue;
			}
			set
			{
				this.empty_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x002B8298 File Offset: 0x002B6498
		[DebuggerNonUserCode]
		public bool HasEmpty
		{
			get
			{
				return this.empty_ != null;
			}
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x002B82B3 File Offset: 0x002B64B3
		[DebuggerNonUserCode]
		public void ClearEmpty()
		{
			this.empty_ = null;
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x002B82C0 File Offset: 0x002B64C0
		[DebuggerNonUserCode]
		public RepeatedField<GameServerPing> Pings
		{
			get
			{
				return this.pings_;
			}
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x002B82D8 File Offset: 0x002B64D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMgmtRequest);
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x002B82F8 File Offset: 0x002B64F8
		[DebuggerNonUserCode]
		public bool Equals(GameMgmtRequest other)
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
								bool flag7 = !this.options_.Equals(other.options_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Neg1 != other.Neg1;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Empty != other.Empty;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.pings_.Equals(other.pings_);
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

		// Token: 0x0600B2DD RID: 45789 RVA: 0x002B8408 File Offset: 0x002B6608
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
			num ^= this.options_.GetHashCode();
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				num ^= this.Neg1.GetHashCode();
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num ^= this.Empty.GetHashCode();
			}
			num ^= this.pings_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x002B84E0 File Offset: 0x002B66E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x002B84F8 File Offset: 0x002B66F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x002B8504 File Offset: 0x002B6704
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
			this.options_.WriteTo(ref output, GameMgmtRequest._repeated_options_codec);
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Neg1);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Empty);
			}
			this.pings_.WriteTo(ref output, GameMgmtRequest._repeated_pings_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x002B8600 File Offset: 0x002B6800
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
			num += this.options_.CalculateSize(GameMgmtRequest._repeated_options_codec);
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Neg1);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Empty);
			}
			num += this.pings_.CalculateSize(GameMgmtRequest._repeated_pings_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x002B86EC File Offset: 0x002B68EC
		[DebuggerNonUserCode]
		public void MergeFrom(GameMgmtRequest other)
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
				this.options_.Add(other.options_);
				bool hasNeg = other.HasNeg1;
				if (hasNeg)
				{
					this.Neg1 = other.Neg1;
				}
				bool hasEmpty = other.HasEmpty;
				if (hasEmpty)
				{
					this.Empty = other.Empty;
				}
				this.pings_.Add(other.pings_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x002B87C4 File Offset: 0x002B69C4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x002B87D0 File Offset: 0x002B69D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0045;
							}
							this.GamePassword = input.ReadString();
						}
						else
						{
							this.GameName = input.ReadString();
						}
					}
					else
					{
						this.CharId = input.ReadUInt32();
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0045;
						}
						this.Neg1 = input.ReadUInt32();
					}
					else
					{
						this.options_.AddEntriesFrom(ref input, GameMgmtRequest._repeated_options_codec);
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 58U)
					{
						goto IL_0045;
					}
					this.pings_.AddEntriesFrom(ref input, GameMgmtRequest._repeated_pings_codec);
				}
				else
				{
					this.Empty = input.ReadString();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050B5 RID: 20661
		private static readonly MessageParser<GameMgmtRequest> _parser = new MessageParser<GameMgmtRequest>(() => new GameMgmtRequest());

		// Token: 0x040050B6 RID: 20662
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050B7 RID: 20663
		private int _hasBits0;

		// Token: 0x040050B8 RID: 20664
		public const int CharIdFieldNumber = 1;

		// Token: 0x040050B9 RID: 20665
		private static readonly uint CharIdDefaultValue = 0U;

		// Token: 0x040050BA RID: 20666
		private uint charId_;

		// Token: 0x040050BB RID: 20667
		public const int GameNameFieldNumber = 2;

		// Token: 0x040050BC RID: 20668
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x040050BD RID: 20669
		private string gameName_;

		// Token: 0x040050BE RID: 20670
		public const int GamePasswordFieldNumber = 3;

		// Token: 0x040050BF RID: 20671
		private static readonly string GamePasswordDefaultValue = "";

		// Token: 0x040050C0 RID: 20672
		private string gamePassword_;

		// Token: 0x040050C1 RID: 20673
		public const int OptionsFieldNumber = 4;

		// Token: 0x040050C2 RID: 20674
		private static readonly FieldCodec<GameOption> _repeated_options_codec = FieldCodec.ForMessage<GameOption>(34U, GameOption.Parser);

		// Token: 0x040050C3 RID: 20675
		private readonly RepeatedField<GameOption> options_ = new RepeatedField<GameOption>();

		// Token: 0x040050C4 RID: 20676
		public const int Neg1FieldNumber = 5;

		// Token: 0x040050C5 RID: 20677
		private static readonly uint Neg1DefaultValue = 0U;

		// Token: 0x040050C6 RID: 20678
		private uint neg1_;

		// Token: 0x040050C7 RID: 20679
		public const int EmptyFieldNumber = 6;

		// Token: 0x040050C8 RID: 20680
		private static readonly string EmptyDefaultValue = "";

		// Token: 0x040050C9 RID: 20681
		private string empty_;

		// Token: 0x040050CA RID: 20682
		public const int PingsFieldNumber = 7;

		// Token: 0x040050CB RID: 20683
		private static readonly FieldCodec<GameServerPing> _repeated_pings_codec = FieldCodec.ForMessage<GameServerPing>(58U, GameServerPing.Parser);

		// Token: 0x040050CC RID: 20684
		private readonly RepeatedField<GameServerPing> pings_ = new RepeatedField<GameServerPing>();
	}
}
