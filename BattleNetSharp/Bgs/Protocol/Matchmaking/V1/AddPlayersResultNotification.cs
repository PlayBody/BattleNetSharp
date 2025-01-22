using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003EF RID: 1007
	public sealed class AddPlayersResultNotification : IMessage<AddPlayersResultNotification>, IMessage, IEquatable<AddPlayersResultNotification>, IDeepCloneable<AddPlayersResultNotification>, IBufferMessage
	{
		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006422 RID: 25634 RVA: 0x00183164 File Offset: 0x00181364
		[DebuggerNonUserCode]
		public static MessageParser<AddPlayersResultNotification> Parser
		{
			get
			{
				return AddPlayersResultNotification._parser;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006423 RID: 25635 RVA: 0x0018317C File Offset: 0x0018137C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06006424 RID: 25636 RVA: 0x001831A0 File Offset: 0x001813A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPlayersResultNotification.Descriptor;
			}
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x001831B7 File Offset: 0x001813B7
		[DebuggerNonUserCode]
		public AddPlayersResultNotification()
		{
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x001831D8 File Offset: 0x001813D8
		[DebuggerNonUserCode]
		public AddPlayersResultNotification(AddPlayersResultNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.gameAccount_ = other.gameAccount_.Clone();
			this.errorId_ = other.errorId_;
			this.connectInfo_ = other.connectInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x00183254 File Offset: 0x00181454
		[DebuggerNonUserCode]
		public AddPlayersResultNotification Clone()
		{
			return new AddPlayersResultNotification(this);
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x0018326C File Offset: 0x0018146C
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x00183284 File Offset: 0x00181484
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

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x00183290 File Offset: 0x00181490
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x001832A8 File Offset: 0x001814A8
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x001832D9 File Offset: 0x001814D9
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
					errorIdDefaultValue = AddPlayersResultNotification.ErrorIdDefaultValue;
				}
				return errorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorId_ = value;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x001832F4 File Offset: 0x001814F4
		[DebuggerNonUserCode]
		public bool HasErrorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x00183311 File Offset: 0x00181511
		[DebuggerNonUserCode]
		public void ClearErrorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x00183324 File Offset: 0x00181524
		[DebuggerNonUserCode]
		public RepeatedField<ConnectInfo> ConnectInfo
		{
			get
			{
				return this.connectInfo_;
			}
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x0018333C File Offset: 0x0018153C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPlayersResultNotification);
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x0018335C File Offset: 0x0018155C
		[DebuggerNonUserCode]
		public bool Equals(AddPlayersResultNotification other)
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
						bool flag5 = !this.gameAccount_.Equals(other.gameAccount_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ErrorId != other.ErrorId;
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

		// Token: 0x06006432 RID: 25650 RVA: 0x00183414 File Offset: 0x00181614
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			num ^= this.gameAccount_.GetHashCode();
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			num ^= this.connectInfo_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0018349C File Offset: 0x0018169C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x001834B4 File Offset: 0x001816B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x001834C0 File Offset: 0x001816C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			this.gameAccount_.WriteTo(ref output, AddPlayersResultNotification._repeated_gameAccount_codec);
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.ErrorId);
			}
			this.connectInfo_.WriteTo(ref output, AddPlayersResultNotification._repeated_connectInfo_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x00183558 File Offset: 0x00181758
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			num += this.gameAccount_.CalculateSize(AddPlayersResultNotification._repeated_gameAccount_codec);
			bool hasErrorId = this.HasErrorId;
			if (hasErrorId)
			{
				num += 5;
			}
			num += this.connectInfo_.CalculateSize(AddPlayersResultNotification._repeated_connectInfo_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x001835E4 File Offset: 0x001817E4
		[DebuggerNonUserCode]
		public void MergeFrom(AddPlayersResultNotification other)
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
				this.gameAccount_.Add(other.gameAccount_);
				bool hasErrorId = other.HasErrorId;
				if (hasErrorId)
				{
					this.ErrorId = other.ErrorId;
				}
				this.connectInfo_.Add(other.connectInfo_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00183690 File Offset: 0x00181890
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x0018369C File Offset: 0x0018189C
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002C;
						}
						this.gameAccount_.AddEntriesFrom(ref input, AddPlayersResultNotification._repeated_gameAccount_codec);
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
				else if (num3 != 29U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					this.connectInfo_.AddEntriesFrom(ref input, AddPlayersResultNotification._repeated_connectInfo_codec);
				}
				else
				{
					this.ErrorId = input.ReadFixed32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002DA2 RID: 11682
		private static readonly MessageParser<AddPlayersResultNotification> _parser = new MessageParser<AddPlayersResultNotification>(() => new AddPlayersResultNotification());

		// Token: 0x04002DA3 RID: 11683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DA4 RID: 11684
		private int _hasBits0;

		// Token: 0x04002DA5 RID: 11685
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002DA6 RID: 11686
		private GameHandle gameHandle_;

		// Token: 0x04002DA7 RID: 11687
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04002DA8 RID: 11688
		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(18U, GameAccountHandle.Parser);

		// Token: 0x04002DA9 RID: 11689
		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x04002DAA RID: 11690
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04002DAB RID: 11691
		private static readonly uint ErrorIdDefaultValue = 0U;

		// Token: 0x04002DAC RID: 11692
		private uint errorId_;

		// Token: 0x04002DAD RID: 11693
		public const int ConnectInfoFieldNumber = 4;

		// Token: 0x04002DAE RID: 11694
		private static readonly FieldCodec<ConnectInfo> _repeated_connectInfo_codec = FieldCodec.ForMessage<ConnectInfo>(34U, Bgs.Protocol.Matchmaking.V1.ConnectInfo.Parser);

		// Token: 0x04002DAF RID: 11695
		private readonly RepeatedField<ConnectInfo> connectInfo_ = new RepeatedField<ConnectInfo>();
	}
}
