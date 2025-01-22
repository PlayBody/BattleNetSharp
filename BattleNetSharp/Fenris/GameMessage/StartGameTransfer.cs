using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001BF RID: 447
	public sealed class StartGameTransfer : IMessage<StartGameTransfer>, IMessage, IEquatable<StartGameTransfer>, IDeepCloneable<StartGameTransfer>, IBufferMessage
	{
		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000B83C4 File Offset: 0x000B65C4
		[DebuggerNonUserCode]
		public static MessageParser<StartGameTransfer> Parser
		{
			get
			{
				return StartGameTransfer._parser;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x000B83DC File Offset: 0x000B65DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000B8400 File Offset: 0x000B6600
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartGameTransfer.Descriptor;
			}
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000B8417 File Offset: 0x000B6617
		[DebuggerNonUserCode]
		public StartGameTransfer()
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000B842C File Offset: 0x000B662C
		[DebuggerNonUserCode]
		public StartGameTransfer(StartGameTransfer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this.gameAddress_ = other.gameAddress_;
			this.gamePort_ = other.gamePort_;
			this.player_ = other.player_.Clone();
			this.gameSubzoneSno_ = other.gameSubzoneSno_;
			this.triggerFade_ = other.triggerFade_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000B84AC File Offset: 0x000B66AC
		[DebuggerNonUserCode]
		public StartGameTransfer Clone()
		{
			return new StartGameTransfer(this);
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x000B84C4 File Offset: 0x000B66C4
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x000B84F5 File Offset: 0x000B66F5
		[DebuggerNonUserCode]
		public uint GameId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameIdDefaultValue;
				if (flag)
				{
					gameIdDefaultValue = this.gameId_;
				}
				else
				{
					gameIdDefaultValue = StartGameTransfer.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x000B8510 File Offset: 0x000B6710
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000B852D File Offset: 0x000B672D
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000B8540 File Offset: 0x000B6740
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x000B8561 File Offset: 0x000B6761
		[DebuggerNonUserCode]
		public string GameAddress
		{
			get
			{
				return this.gameAddress_ ?? StartGameTransfer.GameAddressDefaultValue;
			}
			set
			{
				this.gameAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000B8578 File Offset: 0x000B6778
		[DebuggerNonUserCode]
		public bool HasGameAddress
		{
			get
			{
				return this.gameAddress_ != null;
			}
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x000B8593 File Offset: 0x000B6793
		[DebuggerNonUserCode]
		public void ClearGameAddress()
		{
			this.gameAddress_ = null;
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000B85A0 File Offset: 0x000B67A0
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x000B85D1 File Offset: 0x000B67D1
		[DebuggerNonUserCode]
		public uint GamePort
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gamePortDefaultValue;
				if (flag)
				{
					gamePortDefaultValue = this.gamePort_;
				}
				else
				{
					gamePortDefaultValue = StartGameTransfer.GamePortDefaultValue;
				}
				return gamePortDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gamePort_ = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000B85EC File Offset: 0x000B67EC
		[DebuggerNonUserCode]
		public bool HasGamePort
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000B8609 File Offset: 0x000B6809
		[DebuggerNonUserCode]
		public void ClearGamePort()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000B861C File Offset: 0x000B681C
		[DebuggerNonUserCode]
		public RepeatedField<ConnectionInfo.Types.Player> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x000B8634 File Offset: 0x000B6834
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x000B8665 File Offset: 0x000B6865
		[DebuggerNonUserCode]
		public int GameSubzoneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int gameSubzoneSnoDefaultValue;
				if (flag)
				{
					gameSubzoneSnoDefaultValue = this.gameSubzoneSno_;
				}
				else
				{
					gameSubzoneSnoDefaultValue = StartGameTransfer.GameSubzoneSnoDefaultValue;
				}
				return gameSubzoneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameSubzoneSno_ = value;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x000B8680 File Offset: 0x000B6880
		[DebuggerNonUserCode]
		public bool HasGameSubzoneSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000B869D File Offset: 0x000B689D
		[DebuggerNonUserCode]
		public void ClearGameSubzoneSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x000B86B0 File Offset: 0x000B68B0
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x000B86E1 File Offset: 0x000B68E1
		[DebuggerNonUserCode]
		public bool TriggerFade
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool triggerFadeDefaultValue;
				if (flag)
				{
					triggerFadeDefaultValue = this.triggerFade_;
				}
				else
				{
					triggerFadeDefaultValue = StartGameTransfer.TriggerFadeDefaultValue;
				}
				return triggerFadeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.triggerFade_ = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x000B86FC File Offset: 0x000B68FC
		[DebuggerNonUserCode]
		public bool HasTriggerFade
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000B8719 File Offset: 0x000B6919
		[DebuggerNonUserCode]
		public void ClearTriggerFade()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000B872C File Offset: 0x000B692C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartGameTransfer);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000B874C File Offset: 0x000B694C
		[DebuggerNonUserCode]
		public bool Equals(StartGameTransfer other)
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
					bool flag4 = this.GameId != other.GameId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAddress != other.GameAddress;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GamePort != other.GamePort;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.player_.Equals(other.player_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GameSubzoneSno != other.GameSubzoneSno;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.TriggerFade != other.TriggerFade;
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

		// Token: 0x06002EDB RID: 11995 RVA: 0x000B8838 File Offset: 0x000B6A38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool hasGameAddress = this.HasGameAddress;
			if (hasGameAddress)
			{
				num ^= this.GameAddress.GetHashCode();
			}
			bool hasGamePort = this.HasGamePort;
			if (hasGamePort)
			{
				num ^= this.GamePort.GetHashCode();
			}
			num ^= this.player_.GetHashCode();
			bool hasGameSubzoneSno = this.HasGameSubzoneSno;
			if (hasGameSubzoneSno)
			{
				num ^= this.GameSubzoneSno.GetHashCode();
			}
			bool hasTriggerFade = this.HasTriggerFade;
			if (hasTriggerFade)
			{
				num ^= this.TriggerFade.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000B8908 File Offset: 0x000B6B08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000B8920 File Offset: 0x000B6B20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000B892C File Offset: 0x000B6B2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.GameId);
			}
			bool hasGameAddress = this.HasGameAddress;
			if (hasGameAddress)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameAddress);
			}
			bool hasGamePort = this.HasGamePort;
			if (hasGamePort)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GamePort);
			}
			this.player_.WriteTo(ref output, StartGameTransfer._repeated_player_codec);
			bool hasGameSubzoneSno = this.HasGameSubzoneSno;
			if (hasGameSubzoneSno)
			{
				output.WriteRawTag(45);
				output.WriteSFixed32(this.GameSubzoneSno);
			}
			bool hasTriggerFade = this.HasTriggerFade;
			if (hasTriggerFade)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.TriggerFade);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000B8A18 File Offset: 0x000B6C18
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 5;
			}
			bool hasGameAddress = this.HasGameAddress;
			if (hasGameAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameAddress);
			}
			bool hasGamePort = this.HasGamePort;
			if (hasGamePort)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GamePort);
			}
			num += this.player_.CalculateSize(StartGameTransfer._repeated_player_codec);
			bool hasGameSubzoneSno = this.HasGameSubzoneSno;
			if (hasGameSubzoneSno)
			{
				num += 5;
			}
			bool hasTriggerFade = this.HasTriggerFade;
			if (hasTriggerFade)
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

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000B8AD0 File Offset: 0x000B6CD0
		[DebuggerNonUserCode]
		public void MergeFrom(StartGameTransfer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				bool hasGameAddress = other.HasGameAddress;
				if (hasGameAddress)
				{
					this.GameAddress = other.GameAddress;
				}
				bool hasGamePort = other.HasGamePort;
				if (hasGamePort)
				{
					this.GamePort = other.GamePort;
				}
				this.player_.Add(other.player_);
				bool hasGameSubzoneSno = other.HasGameSubzoneSno;
				if (hasGameSubzoneSno)
				{
					this.GameSubzoneSno = other.GameSubzoneSno;
				}
				bool hasTriggerFade = other.HasTriggerFade;
				if (hasTriggerFade)
				{
					this.TriggerFade = other.TriggerFade;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000B8B96 File Offset: 0x000B6D96
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000B8BA4 File Offset: 0x000B6DA4
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
					if (num3 != 13U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.GamePort = input.ReadUInt32();
						}
						else
						{
							this.GameAddress = input.ReadString();
						}
					}
					else
					{
						this.GameId = input.ReadFixed32();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 45U)
					{
						if (num3 != 48U)
						{
							goto IL_003A;
						}
						this.TriggerFade = input.ReadBool();
					}
					else
					{
						this.GameSubzoneSno = input.ReadSFixed32();
					}
				}
				else
				{
					this.player_.AddEntriesFrom(ref input, StartGameTransfer._repeated_player_codec);
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400150E RID: 5390
		private static readonly MessageParser<StartGameTransfer> _parser = new MessageParser<StartGameTransfer>(() => new StartGameTransfer());

		// Token: 0x0400150F RID: 5391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001510 RID: 5392
		private int _hasBits0;

		// Token: 0x04001511 RID: 5393
		public const int GameIdFieldNumber = 1;

		// Token: 0x04001512 RID: 5394
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04001513 RID: 5395
		private uint gameId_;

		// Token: 0x04001514 RID: 5396
		public const int GameAddressFieldNumber = 2;

		// Token: 0x04001515 RID: 5397
		private static readonly string GameAddressDefaultValue = "";

		// Token: 0x04001516 RID: 5398
		private string gameAddress_;

		// Token: 0x04001517 RID: 5399
		public const int GamePortFieldNumber = 3;

		// Token: 0x04001518 RID: 5400
		private static readonly uint GamePortDefaultValue = 0U;

		// Token: 0x04001519 RID: 5401
		private uint gamePort_;

		// Token: 0x0400151A RID: 5402
		public const int PlayerFieldNumber = 4;

		// Token: 0x0400151B RID: 5403
		private static readonly FieldCodec<ConnectionInfo.Types.Player> _repeated_player_codec = FieldCodec.ForMessage<ConnectionInfo.Types.Player>(34U, ConnectionInfo.Types.Player.Parser);

		// Token: 0x0400151C RID: 5404
		private readonly RepeatedField<ConnectionInfo.Types.Player> player_ = new RepeatedField<ConnectionInfo.Types.Player>();

		// Token: 0x0400151D RID: 5405
		public const int GameSubzoneSnoFieldNumber = 5;

		// Token: 0x0400151E RID: 5406
		private static readonly int GameSubzoneSnoDefaultValue = 0;

		// Token: 0x0400151F RID: 5407
		private int gameSubzoneSno_;

		// Token: 0x04001520 RID: 5408
		public const int TriggerFadeFieldNumber = 6;

		// Token: 0x04001521 RID: 5409
		private static readonly bool TriggerFadeDefaultValue = false;

		// Token: 0x04001522 RID: 5410
		private bool triggerFade_;
	}
}
