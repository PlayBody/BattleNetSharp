using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003EE RID: 1006
	public sealed class CreateGameResultNotification : IMessage<CreateGameResultNotification>, IMessage, IEquatable<CreateGameResultNotification>, IDeepCloneable<CreateGameResultNotification>, IBufferMessage
	{
		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x00182B14 File Offset: 0x00180D14
		[DebuggerNonUserCode]
		public static MessageParser<CreateGameResultNotification> Parser
		{
			get
			{
				return CreateGameResultNotification._parser;
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x00182B2C File Offset: 0x00180D2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x00182B50 File Offset: 0x00180D50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateGameResultNotification.Descriptor;
			}
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x00182B67 File Offset: 0x00180D67
		[DebuggerNonUserCode]
		public CreateGameResultNotification()
		{
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00182B88 File Offset: 0x00180D88
		[DebuggerNonUserCode]
		public CreateGameResultNotification(CreateGameResultNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.errorId_ = other.errorId_;
			this.gameAccount_ = other.gameAccount_.Clone();
			this.connectInfo_ = other.connectInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00182C04 File Offset: 0x00180E04
		[DebuggerNonUserCode]
		public CreateGameResultNotification Clone()
		{
			return new CreateGameResultNotification(this);
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x00182C1C File Offset: 0x00180E1C
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x00182C34 File Offset: 0x00180E34
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

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x00182C40 File Offset: 0x00180E40
		// (set) Token: 0x06006412 RID: 25618 RVA: 0x00182C71 File Offset: 0x00180E71
		[DebuggerNonUserCode]
		public uint ErrorId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorIdDefaultValue;
				if (flag)
				{
					errorIdDefaultValue = this.errorId_;
				}
				else
				{
					errorIdDefaultValue = CreateGameResultNotification.ErrorIdDefaultValue;
				}
				return errorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorId_ = value;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x00182C8C File Offset: 0x00180E8C
		[DebuggerNonUserCode]
		public bool HasErrorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x00182CA9 File Offset: 0x00180EA9
		[DebuggerNonUserCode]
		public void ClearErrorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06006415 RID: 25621 RVA: 0x00182CBC File Offset: 0x00180EBC
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x00182CD4 File Offset: 0x00180ED4
		[DebuggerNonUserCode]
		public RepeatedField<ConnectInfo> ConnectInfo
		{
			get
			{
				return this.connectInfo_;
			}
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x00182CEC File Offset: 0x00180EEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateGameResultNotification);
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00182D0C File Offset: 0x00180F0C
		[DebuggerNonUserCode]
		public bool Equals(CreateGameResultNotification other)
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
						bool flag5 = this.ErrorId != other.ErrorId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.gameAccount_.Equals(other.gameAccount_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.connectInfo_.Equals(other.connectInfo_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00182DC4 File Offset: 0x00180FC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			num ^= this.gameAccount_.GetHashCode();
			num ^= this.connectInfo_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00182E4C File Offset: 0x0018104C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x00182E64 File Offset: 0x00181064
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00182E70 File Offset: 0x00181070
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.ErrorId);
			}
			this.gameAccount_.WriteTo(ref output, CreateGameResultNotification._repeated_gameAccount_codec);
			this.connectInfo_.WriteTo(ref output, CreateGameResultNotification._repeated_connectInfo_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00182F08 File Offset: 0x00181108
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				num += 5;
			}
			num += this.gameAccount_.CalculateSize(CreateGameResultNotification._repeated_gameAccount_codec);
			num += this.connectInfo_.CalculateSize(CreateGameResultNotification._repeated_connectInfo_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x00182F94 File Offset: 0x00181194
		[DebuggerNonUserCode]
		public void MergeFrom(CreateGameResultNotification other)
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
				bool hasErrorId = other.HasErrorId;
				if (hasErrorId)
				{
					this.ErrorId = other.ErrorId;
				}
				this.gameAccount_.Add(other.gameAccount_);
				this.connectInfo_.Add(other.connectInfo_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00183040 File Offset: 0x00181240
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x0018304C File Offset: 0x0018124C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_002C;
						}
						this.ErrorId = input.ReadFixed32();
					}
					else
					{
						bool flag = this.gameHandle_ == null;
						if (flag)
						{
							this.GameHandle = new GameHandle();
						}
						input.ReadMessage(this.GameHandle);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					this.connectInfo_.AddEntriesFrom(ref input, CreateGameResultNotification._repeated_connectInfo_codec);
				}
				else
				{
					this.gameAccount_.AddEntriesFrom(ref input, CreateGameResultNotification._repeated_gameAccount_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D94 RID: 11668
		private static readonly MessageParser<CreateGameResultNotification> _parser = new MessageParser<CreateGameResultNotification>(() => new CreateGameResultNotification());

		// Token: 0x04002D95 RID: 11669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D96 RID: 11670
		private int _hasBits0;

		// Token: 0x04002D97 RID: 11671
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002D98 RID: 11672
		private GameHandle gameHandle_;

		// Token: 0x04002D99 RID: 11673
		public const int ErrorIdFieldNumber = 2;

		// Token: 0x04002D9A RID: 11674
		private static readonly uint ErrorIdDefaultValue = 0U;

		// Token: 0x04002D9B RID: 11675
		private uint errorId_;

		// Token: 0x04002D9C RID: 11676
		public const int GameAccountFieldNumber = 3;

		// Token: 0x04002D9D RID: 11677
		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(26U, GameAccountHandle.Parser);

		// Token: 0x04002D9E RID: 11678
		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x04002D9F RID: 11679
		public const int ConnectInfoFieldNumber = 4;

		// Token: 0x04002DA0 RID: 11680
		private static readonly FieldCodec<ConnectInfo> _repeated_connectInfo_codec = FieldCodec.ForMessage<ConnectInfo>(34U, Bgs.Protocol.Matchmaking.V1.ConnectInfo.Parser);

		// Token: 0x04002DA1 RID: 11681
		private readonly RepeatedField<ConnectInfo> connectInfo_ = new RepeatedField<ConnectInfo>();
	}
}
