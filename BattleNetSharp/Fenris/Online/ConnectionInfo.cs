using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000143 RID: 323
	public sealed class ConnectionInfo : IMessage<ConnectionInfo>, IMessage, IEquatable<ConnectionInfo>, IDeepCloneable<ConnectionInfo>, IBufferMessage
	{
		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000821D0 File Offset: 0x000803D0
		[DebuggerNonUserCode]
		public static MessageParser<ConnectionInfo> Parser
		{
			get
			{
				return ConnectionInfo._parser;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x000821E8 File Offset: 0x000803E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0008220C File Offset: 0x0008040C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectionInfo.Descriptor;
			}
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00082223 File Offset: 0x00080423
		[DebuggerNonUserCode]
		public ConnectionInfo()
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00082238 File Offset: 0x00080438
		[DebuggerNonUserCode]
		public ConnectionInfo(ConnectionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.gameId_ = other.gameId_;
			this.gameParams_ = ((other.gameParams_ != null) ? other.gameParams_.Clone() : null);
			this.address_ = other.address_;
			this.port_ = other.port_;
			this.serviceMessageQueue_ = other.serviceMessageQueue_;
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000822E4 File Offset: 0x000804E4
		[DebuggerNonUserCode]
		public ConnectionInfo Clone()
		{
			return new ConnectionInfo(this);
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000822FC File Offset: 0x000804FC
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x00082314 File Offset: 0x00080514
		[DebuggerNonUserCode]
		public GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x00082320 File Offset: 0x00080520
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x00082351 File Offset: 0x00080551
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
					gameIdDefaultValue = ConnectionInfo.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0008236C File Offset: 0x0008056C
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00082389 File Offset: 0x00080589
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x0008239C File Offset: 0x0008059C
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x000823B4 File Offset: 0x000805B4
		[DebuggerNonUserCode]
		public GameCreateParams GameParams
		{
			get
			{
				return this.gameParams_;
			}
			set
			{
				this.gameParams_ = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000823C0 File Offset: 0x000805C0
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x000823E1 File Offset: 0x000805E1
		[DebuggerNonUserCode]
		public string Address
		{
			get
			{
				return this.address_ ?? ConnectionInfo.AddressDefaultValue;
			}
			set
			{
				this.address_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000823F8 File Offset: 0x000805F8
		[DebuggerNonUserCode]
		public bool HasAddress
		{
			get
			{
				return this.address_ != null;
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00082413 File Offset: 0x00080613
		[DebuggerNonUserCode]
		public void ClearAddress()
		{
			this.address_ = null;
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x00082420 File Offset: 0x00080620
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00082451 File Offset: 0x00080651
		[DebuggerNonUserCode]
		public uint Port
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint portDefaultValue;
				if (flag)
				{
					portDefaultValue = this.port_;
				}
				else
				{
					portDefaultValue = ConnectionInfo.PortDefaultValue;
				}
				return portDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.port_ = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x0008246C File Offset: 0x0008066C
		[DebuggerNonUserCode]
		public bool HasPort
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00082489 File Offset: 0x00080689
		[DebuggerNonUserCode]
		public void ClearPort()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x0008249C File Offset: 0x0008069C
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x000824BD File Offset: 0x000806BD
		[DebuggerNonUserCode]
		public string ServiceMessageQueue
		{
			get
			{
				return this.serviceMessageQueue_ ?? ConnectionInfo.ServiceMessageQueueDefaultValue;
			}
			set
			{
				this.serviceMessageQueue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000824D4 File Offset: 0x000806D4
		[DebuggerNonUserCode]
		public bool HasServiceMessageQueue
		{
			get
			{
				return this.serviceMessageQueue_ != null;
			}
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000824EF File Offset: 0x000806EF
		[DebuggerNonUserCode]
		public void ClearServiceMessageQueue()
		{
			this.serviceMessageQueue_ = null;
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000824FC File Offset: 0x000806FC
		[DebuggerNonUserCode]
		public RepeatedField<ConnectionInfo.Types.Player> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00082514 File Offset: 0x00080714
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectionInfo);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00082534 File Offset: 0x00080734
		[DebuggerNonUserCode]
		public bool Equals(ConnectionInfo other)
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
					bool flag4 = !object.Equals(this.GameHandle, other.GameHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameId != other.GameId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.GameParams, other.GameParams);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Address != other.Address;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Port != other.Port;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ServiceMessageQueue != other.ServiceMessageQueue;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.player_.Equals(other.player_);
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

		// Token: 0x0600216A RID: 8554 RVA: 0x00082644 File Offset: 0x00080844
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool flag2 = this.gameParams_ != null;
			if (flag2)
			{
				num ^= this.GameParams.GetHashCode();
			}
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num ^= this.Address.GetHashCode();
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num ^= this.Port.GetHashCode();
			}
			bool hasServiceMessageQueue = this.HasServiceMessageQueue;
			if (hasServiceMessageQueue)
			{
				num ^= this.ServiceMessageQueue.GetHashCode();
			}
			num ^= this.player_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0008272C File Offset: 0x0008092C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00082744 File Offset: 0x00080944
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00082750 File Offset: 0x00080950
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.GameId);
			}
			bool flag2 = this.gameParams_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GameParams);
			}
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Port);
			}
			bool hasServiceMessageQueue = this.HasServiceMessageQueue;
			if (hasServiceMessageQueue)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ServiceMessageQueue);
			}
			this.player_.WriteTo(ref output, ConnectionInfo._repeated_player_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00082864 File Offset: 0x00080A64
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 5;
			}
			bool flag2 = this.gameParams_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameParams);
			}
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			bool hasServiceMessageQueue = this.HasServiceMessageQueue;
			if (hasServiceMessageQueue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServiceMessageQueue);
			}
			num += this.player_.CalculateSize(ConnectionInfo._repeated_player_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00082958 File Offset: 0x00080B58
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.gameHandle_ == null;
					if (flag3)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				bool flag4 = other.gameParams_ != null;
				if (flag4)
				{
					bool flag5 = this.gameParams_ == null;
					if (flag5)
					{
						this.GameParams = new GameCreateParams();
					}
					this.GameParams.MergeFrom(other.GameParams);
				}
				bool hasAddress = other.HasAddress;
				if (hasAddress)
				{
					this.Address = other.Address;
				}
				bool hasPort = other.HasPort;
				if (hasPort)
				{
					this.Port = other.Port;
				}
				bool hasServiceMessageQueue = other.HasServiceMessageQueue;
				if (hasServiceMessageQueue)
				{
					this.ServiceMessageQueue = other.ServiceMessageQueue;
				}
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00082A83 File Offset: 0x00080C83
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00082A90 File Offset: 0x00080C90
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
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							bool flag = this.gameParams_ == null;
							if (flag)
							{
								this.GameParams = new GameCreateParams();
							}
							input.ReadMessage(this.GameParams);
						}
						else
						{
							this.GameId = input.ReadFixed32();
						}
					}
					else
					{
						bool flag2 = this.gameHandle_ == null;
						if (flag2)
						{
							this.GameHandle = new GameHandle();
						}
						input.ReadMessage(this.GameHandle);
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0055;
						}
						this.Port = input.ReadUInt32();
					}
					else
					{
						this.Address = input.ReadString();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						goto IL_0055;
					}
					this.player_.AddEntriesFrom(ref input, ConnectionInfo._repeated_player_codec);
				}
				else
				{
					this.ServiceMessageQueue = input.ReadString();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000EB7 RID: 3767
		private static readonly MessageParser<ConnectionInfo> _parser = new MessageParser<ConnectionInfo>(() => new ConnectionInfo());

		// Token: 0x04000EB8 RID: 3768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EB9 RID: 3769
		private int _hasBits0;

		// Token: 0x04000EBA RID: 3770
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04000EBB RID: 3771
		private GameHandle gameHandle_;

		// Token: 0x04000EBC RID: 3772
		public const int GameIdFieldNumber = 2;

		// Token: 0x04000EBD RID: 3773
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04000EBE RID: 3774
		private uint gameId_;

		// Token: 0x04000EBF RID: 3775
		public const int GameParamsFieldNumber = 3;

		// Token: 0x04000EC0 RID: 3776
		private GameCreateParams gameParams_;

		// Token: 0x04000EC1 RID: 3777
		public const int AddressFieldNumber = 4;

		// Token: 0x04000EC2 RID: 3778
		private static readonly string AddressDefaultValue = "";

		// Token: 0x04000EC3 RID: 3779
		private string address_;

		// Token: 0x04000EC4 RID: 3780
		public const int PortFieldNumber = 5;

		// Token: 0x04000EC5 RID: 3781
		private static readonly uint PortDefaultValue = 0U;

		// Token: 0x04000EC6 RID: 3782
		private uint port_;

		// Token: 0x04000EC7 RID: 3783
		public const int ServiceMessageQueueFieldNumber = 8;

		// Token: 0x04000EC8 RID: 3784
		private static readonly string ServiceMessageQueueDefaultValue = "";

		// Token: 0x04000EC9 RID: 3785
		private string serviceMessageQueue_;

		// Token: 0x04000ECA RID: 3786
		public const int PlayerFieldNumber = 9;

		// Token: 0x04000ECB RID: 3787
		private static readonly FieldCodec<ConnectionInfo.Types.Player> _repeated_player_codec = FieldCodec.ForMessage<ConnectionInfo.Types.Player>(74U, ConnectionInfo.Types.Player.Parser);

		// Token: 0x04000ECC RID: 3788
		private readonly RepeatedField<ConnectionInfo.Types.Player> player_ = new RepeatedField<ConnectionInfo.Types.Player>();

		// Token: 0x02000C5F RID: 3167
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200147F RID: 5247
			public sealed class Player : IMessage<ConnectionInfo.Types.Player>, IMessage, IEquatable<ConnectionInfo.Types.Player>, IDeepCloneable<ConnectionInfo.Types.Player>, IBufferMessage
			{
				// Token: 0x17003AB6 RID: 15030
				// (get) Token: 0x0600E680 RID: 59008 RVA: 0x004D835C File Offset: 0x004D655C
				[DebuggerNonUserCode]
				public static MessageParser<ConnectionInfo.Types.Player> Parser
				{
					get
					{
						return ConnectionInfo.Types.Player._parser;
					}
				}

				// Token: 0x17003AB7 RID: 15031
				// (get) Token: 0x0600E681 RID: 59009 RVA: 0x004D8374 File Offset: 0x004D6574
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return ConnectionInfo.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AB8 RID: 15032
				// (get) Token: 0x0600E682 RID: 59010 RVA: 0x004D8398 File Offset: 0x004D6598
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return ConnectionInfo.Types.Player.Descriptor;
					}
				}

				// Token: 0x0600E683 RID: 59011 RVA: 0x004D83AF File Offset: 0x004D65AF
				[DebuggerNonUserCode]
				public Player()
				{
				}

				// Token: 0x0600E684 RID: 59012 RVA: 0x004D83BC File Offset: 0x004D65BC
				[DebuggerNonUserCode]
				public Player(ConnectionInfo.Types.Player other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.bnetAccountId_ = other.bnetAccountId_;
					this.gameAccountId_ = other.gameAccountId_;
					this.authToken_ = other.authToken_;
					this.encryptionInfo_ = ((other.encryptionInfo_ != null) ? other.encryptionInfo_.Clone() : null);
					this.teamId_ = other.teamId_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E685 RID: 59013 RVA: 0x004D843C File Offset: 0x004D663C
				[DebuggerNonUserCode]
				public ConnectionInfo.Types.Player Clone()
				{
					return new ConnectionInfo.Types.Player(this);
				}

				// Token: 0x17003AB9 RID: 15033
				// (get) Token: 0x0600E686 RID: 59014 RVA: 0x004D8454 File Offset: 0x004D6654
				// (set) Token: 0x0600E687 RID: 59015 RVA: 0x004D8485 File Offset: 0x004D6685
				[DebuggerNonUserCode]
				public uint BnetAccountId
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint bnetAccountIdDefaultValue;
						if (flag)
						{
							bnetAccountIdDefaultValue = this.bnetAccountId_;
						}
						else
						{
							bnetAccountIdDefaultValue = ConnectionInfo.Types.Player.BnetAccountIdDefaultValue;
						}
						return bnetAccountIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.bnetAccountId_ = value;
					}
				}

				// Token: 0x17003ABA RID: 15034
				// (get) Token: 0x0600E688 RID: 59016 RVA: 0x004D84A0 File Offset: 0x004D66A0
				[DebuggerNonUserCode]
				public bool HasBnetAccountId
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E689 RID: 59017 RVA: 0x004D84BD File Offset: 0x004D66BD
				[DebuggerNonUserCode]
				public void ClearBnetAccountId()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003ABB RID: 15035
				// (get) Token: 0x0600E68A RID: 59018 RVA: 0x004D84D0 File Offset: 0x004D66D0
				// (set) Token: 0x0600E68B RID: 59019 RVA: 0x004D8501 File Offset: 0x004D6701
				[DebuggerNonUserCode]
				public uint GameAccountId
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint gameAccountIdDefaultValue;
						if (flag)
						{
							gameAccountIdDefaultValue = this.gameAccountId_;
						}
						else
						{
							gameAccountIdDefaultValue = ConnectionInfo.Types.Player.GameAccountIdDefaultValue;
						}
						return gameAccountIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.gameAccountId_ = value;
					}
				}

				// Token: 0x17003ABC RID: 15036
				// (get) Token: 0x0600E68C RID: 59020 RVA: 0x004D851C File Offset: 0x004D671C
				[DebuggerNonUserCode]
				public bool HasGameAccountId
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E68D RID: 59021 RVA: 0x004D8539 File Offset: 0x004D6739
				[DebuggerNonUserCode]
				public void ClearGameAccountId()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003ABD RID: 15037
				// (get) Token: 0x0600E68E RID: 59022 RVA: 0x004D854C File Offset: 0x004D674C
				// (set) Token: 0x0600E68F RID: 59023 RVA: 0x004D857D File Offset: 0x004D677D
				[DebuggerNonUserCode]
				public ulong AuthToken
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						ulong authTokenDefaultValue;
						if (flag)
						{
							authTokenDefaultValue = this.authToken_;
						}
						else
						{
							authTokenDefaultValue = ConnectionInfo.Types.Player.AuthTokenDefaultValue;
						}
						return authTokenDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.authToken_ = value;
					}
				}

				// Token: 0x17003ABE RID: 15038
				// (get) Token: 0x0600E690 RID: 59024 RVA: 0x004D8598 File Offset: 0x004D6798
				[DebuggerNonUserCode]
				public bool HasAuthToken
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E691 RID: 59025 RVA: 0x004D85B5 File Offset: 0x004D67B5
				[DebuggerNonUserCode]
				public void ClearAuthToken()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003ABF RID: 15039
				// (get) Token: 0x0600E692 RID: 59026 RVA: 0x004D85C8 File Offset: 0x004D67C8
				// (set) Token: 0x0600E693 RID: 59027 RVA: 0x004D85E0 File Offset: 0x004D67E0
				[DebuggerNonUserCode]
				public ConnectionEncryptionInfo EncryptionInfo
				{
					get
					{
						return this.encryptionInfo_;
					}
					set
					{
						this.encryptionInfo_ = value;
					}
				}

				// Token: 0x17003AC0 RID: 15040
				// (get) Token: 0x0600E694 RID: 59028 RVA: 0x004D85EC File Offset: 0x004D67EC
				// (set) Token: 0x0600E695 RID: 59029 RVA: 0x004D861D File Offset: 0x004D681D
				[DebuggerNonUserCode]
				public uint TeamId
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						uint teamIdDefaultValue;
						if (flag)
						{
							teamIdDefaultValue = this.teamId_;
						}
						else
						{
							teamIdDefaultValue = ConnectionInfo.Types.Player.TeamIdDefaultValue;
						}
						return teamIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.teamId_ = value;
					}
				}

				// Token: 0x17003AC1 RID: 15041
				// (get) Token: 0x0600E696 RID: 59030 RVA: 0x004D8638 File Offset: 0x004D6838
				[DebuggerNonUserCode]
				public bool HasTeamId
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E697 RID: 59031 RVA: 0x004D8655 File Offset: 0x004D6855
				[DebuggerNonUserCode]
				public void ClearTeamId()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x0600E698 RID: 59032 RVA: 0x004D8668 File Offset: 0x004D6868
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as ConnectionInfo.Types.Player);
				}

				// Token: 0x0600E699 RID: 59033 RVA: 0x004D8688 File Offset: 0x004D6888
				[DebuggerNonUserCode]
				public bool Equals(ConnectionInfo.Types.Player other)
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
							bool flag4 = this.BnetAccountId != other.BnetAccountId;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.GameAccountId != other.GameAccountId;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.AuthToken != other.AuthToken;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = !object.Equals(this.EncryptionInfo, other.EncryptionInfo);
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.TeamId != other.TeamId;
											flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E69A RID: 59034 RVA: 0x004D8758 File Offset: 0x004D6958
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						num ^= this.BnetAccountId.GetHashCode();
					}
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						num ^= this.GameAccountId.GetHashCode();
					}
					bool hasAuthToken = this.HasAuthToken;
					if (hasAuthToken)
					{
						num ^= this.AuthToken.GetHashCode();
					}
					bool flag = this.encryptionInfo_ != null;
					if (flag)
					{
						num ^= this.EncryptionInfo.GetHashCode();
					}
					bool hasTeamId = this.HasTeamId;
					if (hasTeamId)
					{
						num ^= this.TeamId.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E69B RID: 59035 RVA: 0x004D881C File Offset: 0x004D6A1C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E69C RID: 59036 RVA: 0x004D8834 File Offset: 0x004D6A34
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E69D RID: 59037 RVA: 0x004D8840 File Offset: 0x004D6A40
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.BnetAccountId);
					}
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.GameAccountId);
					}
					bool hasAuthToken = this.HasAuthToken;
					if (hasAuthToken)
					{
						output.WriteRawTag(25);
						output.WriteFixed64(this.AuthToken);
					}
					bool flag = this.encryptionInfo_ != null;
					if (flag)
					{
						output.WriteRawTag(34);
						output.WriteMessage(this.EncryptionInfo);
					}
					bool hasTeamId = this.HasTeamId;
					if (hasTeamId)
					{
						output.WriteRawTag(40);
						output.WriteUInt32(this.TeamId);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E69E RID: 59038 RVA: 0x004D891C File Offset: 0x004D6B1C
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
					}
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
					}
					bool hasAuthToken = this.HasAuthToken;
					if (hasAuthToken)
					{
						num += 9;
					}
					bool flag = this.encryptionInfo_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.EncryptionInfo);
					}
					bool hasTeamId = this.HasTeamId;
					if (hasTeamId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.TeamId);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E69F RID: 59039 RVA: 0x004D89DC File Offset: 0x004D6BDC
				[DebuggerNonUserCode]
				public void MergeFrom(ConnectionInfo.Types.Player other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasBnetAccountId = other.HasBnetAccountId;
						if (hasBnetAccountId)
						{
							this.BnetAccountId = other.BnetAccountId;
						}
						bool hasGameAccountId = other.HasGameAccountId;
						if (hasGameAccountId)
						{
							this.GameAccountId = other.GameAccountId;
						}
						bool hasAuthToken = other.HasAuthToken;
						if (hasAuthToken)
						{
							this.AuthToken = other.AuthToken;
						}
						bool flag2 = other.encryptionInfo_ != null;
						if (flag2)
						{
							bool flag3 = this.encryptionInfo_ == null;
							if (flag3)
							{
								this.EncryptionInfo = new ConnectionEncryptionInfo();
							}
							this.EncryptionInfo.MergeFrom(other.EncryptionInfo);
						}
						bool hasTeamId = other.HasTeamId;
						if (hasTeamId)
						{
							this.TeamId = other.TeamId;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E6A0 RID: 59040 RVA: 0x004D8AB5 File Offset: 0x004D6CB5
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E6A1 RID: 59041 RVA: 0x004D8AC0 File Offset: 0x004D6CC0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 16U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0032;
								}
								this.GameAccountId = input.ReadUInt32();
							}
							else
							{
								this.BnetAccountId = input.ReadUInt32();
							}
						}
						else if (num3 != 25U)
						{
							if (num3 != 34U)
							{
								if (num3 != 40U)
								{
									goto IL_0032;
								}
								this.TeamId = input.ReadUInt32();
							}
							else
							{
								bool flag = this.encryptionInfo_ == null;
								if (flag)
								{
									this.EncryptionInfo = new ConnectionEncryptionInfo();
								}
								input.ReadMessage(this.EncryptionInfo);
							}
						}
						else
						{
							this.AuthToken = input.ReadFixed64();
						}
						continue;
						IL_0032:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A3F9 RID: 41977
				private static readonly MessageParser<ConnectionInfo.Types.Player> _parser = new MessageParser<ConnectionInfo.Types.Player>(() => new ConnectionInfo.Types.Player());

				// Token: 0x0400A3FA RID: 41978
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3FB RID: 41979
				private int _hasBits0;

				// Token: 0x0400A3FC RID: 41980
				public const int BnetAccountIdFieldNumber = 1;

				// Token: 0x0400A3FD RID: 41981
				private static readonly uint BnetAccountIdDefaultValue = 0U;

				// Token: 0x0400A3FE RID: 41982
				private uint bnetAccountId_;

				// Token: 0x0400A3FF RID: 41983
				public const int GameAccountIdFieldNumber = 2;

				// Token: 0x0400A400 RID: 41984
				private static readonly uint GameAccountIdDefaultValue = 0U;

				// Token: 0x0400A401 RID: 41985
				private uint gameAccountId_;

				// Token: 0x0400A402 RID: 41986
				public const int AuthTokenFieldNumber = 3;

				// Token: 0x0400A403 RID: 41987
				private static readonly ulong AuthTokenDefaultValue = 0UL;

				// Token: 0x0400A404 RID: 41988
				private ulong authToken_;

				// Token: 0x0400A405 RID: 41989
				public const int EncryptionInfoFieldNumber = 4;

				// Token: 0x0400A406 RID: 41990
				private ConnectionEncryptionInfo encryptionInfo_;

				// Token: 0x0400A407 RID: 41991
				public const int TeamIdFieldNumber = 5;

				// Token: 0x0400A408 RID: 41992
				private static readonly uint TeamIdDefaultValue = 0U;

				// Token: 0x0400A409 RID: 41993
				private uint teamId_;
			}
		}
	}
}
