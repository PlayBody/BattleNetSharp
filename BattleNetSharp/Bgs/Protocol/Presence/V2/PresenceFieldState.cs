using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BD RID: 1469
	public sealed class PresenceFieldState : IMessage<PresenceFieldState>, IMessage, IEquatable<PresenceFieldState>, IDeepCloneable<PresenceFieldState>, IBufferMessage
	{
		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x0021CD44 File Offset: 0x0021AF44
		[DebuggerNonUserCode]
		public static MessageParser<PresenceFieldState> Parser
		{
			get
			{
				return PresenceFieldState._parser;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x0021CD5C File Offset: 0x0021AF5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06008B3E RID: 35646 RVA: 0x0021CD80 File Offset: 0x0021AF80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceFieldState.Descriptor;
			}
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x0021CD97 File Offset: 0x0021AF97
		[DebuggerNonUserCode]
		public PresenceFieldState()
		{
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x0021CDAC File Offset: 0x0021AFAC
		[DebuggerNonUserCode]
		public PresenceFieldState(PresenceFieldState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.fields_ = other.fields_.Clone();
			this.oldestTimeUs_ = other.oldestTimeUs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x0021CE24 File Offset: 0x0021B024
		[DebuggerNonUserCode]
		public PresenceFieldState Clone()
		{
			return new PresenceFieldState(this);
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x0021CE3C File Offset: 0x0021B03C
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x0021CE6D File Offset: 0x0021B06D
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = PresenceFieldState.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x0021CE88 File Offset: 0x0021B088
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x0021CEA5 File Offset: 0x0021B0A5
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x0021CEB8 File Offset: 0x0021B0B8
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x0021CED0 File Offset: 0x0021B0D0
		[DebuggerNonUserCode]
		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x0021CEDC File Offset: 0x0021B0DC
		[DebuggerNonUserCode]
		public RepeatedField<PresenceField> Fields
		{
			get
			{
				return this.fields_;
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x06008B49 RID: 35657 RVA: 0x0021CEF4 File Offset: 0x0021B0F4
		// (set) Token: 0x06008B4A RID: 35658 RVA: 0x0021CF25 File Offset: 0x0021B125
		[DebuggerNonUserCode]
		public ulong OldestTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong oldestTimeUsDefaultValue;
				if (flag)
				{
					oldestTimeUsDefaultValue = this.oldestTimeUs_;
				}
				else
				{
					oldestTimeUsDefaultValue = PresenceFieldState.OldestTimeUsDefaultValue;
				}
				return oldestTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.oldestTimeUs_ = value;
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06008B4B RID: 35659 RVA: 0x0021CF40 File Offset: 0x0021B140
		[DebuggerNonUserCode]
		public bool HasOldestTimeUs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x0021CF5D File Offset: 0x0021B15D
		[DebuggerNonUserCode]
		public void ClearOldestTimeUs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x0021CF70 File Offset: 0x0021B170
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceFieldState);
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x0021CF90 File Offset: 0x0021B190
		[DebuggerNonUserCode]
		public bool Equals(PresenceFieldState other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccount, other.GameAccount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.fields_.Equals(other.fields_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.OldestTimeUs != other.OldestTimeUs;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x0021D044 File Offset: 0x0021B244
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			num ^= this.fields_.GetHashCode();
			bool hasOldestTimeUs = this.HasOldestTimeUs;
			if (hasOldestTimeUs)
			{
				num ^= this.OldestTimeUs.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x0021D0DC File Offset: 0x0021B2DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x0021D0F4 File Offset: 0x0021B2F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x0021D100 File Offset: 0x0021B300
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			this.fields_.WriteTo(ref output, PresenceFieldState._repeated_fields_codec);
			bool hasOldestTimeUs = this.HasOldestTimeUs;
			if (hasOldestTimeUs)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.OldestTimeUs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x0021D1A4 File Offset: 0x0021B3A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			num += this.fields_.CalculateSize(PresenceFieldState._repeated_fields_codec);
			bool hasOldestTimeUs = this.HasOldestTimeUs;
			if (hasOldestTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OldestTimeUs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x0021D244 File Offset: 0x0021B444
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceFieldState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool flag2 = other.gameAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccount_ == null;
					if (flag3)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				this.fields_.Add(other.fields_);
				bool hasOldestTimeUs = other.HasOldestTimeUs;
				if (hasOldestTimeUs)
				{
					this.OldestTimeUs = other.OldestTimeUs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x0021D2F9 File Offset: 0x0021B4F9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x0021D304 File Offset: 0x0021B504
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
							goto IL_002B;
						}
						bool flag = this.gameAccount_ == null;
						if (flag)
						{
							this.GameAccount = new GameAccountHandle();
						}
						input.ReadMessage(this.GameAccount);
					}
					else
					{
						this.AccountId = input.ReadUInt64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.OldestTimeUs = input.ReadUInt64();
				}
				else
				{
					this.fields_.AddEntriesFrom(ref input, PresenceFieldState._repeated_fields_codec);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F0A RID: 16138
		private static readonly MessageParser<PresenceFieldState> _parser = new MessageParser<PresenceFieldState>(() => new PresenceFieldState());

		// Token: 0x04003F0B RID: 16139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F0C RID: 16140
		private int _hasBits0;

		// Token: 0x04003F0D RID: 16141
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003F0E RID: 16142
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003F0F RID: 16143
		private ulong accountId_;

		// Token: 0x04003F10 RID: 16144
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04003F11 RID: 16145
		private GameAccountHandle gameAccount_;

		// Token: 0x04003F12 RID: 16146
		public const int FieldsFieldNumber = 3;

		// Token: 0x04003F13 RID: 16147
		private static readonly FieldCodec<PresenceField> _repeated_fields_codec = FieldCodec.ForMessage<PresenceField>(26U, PresenceField.Parser);

		// Token: 0x04003F14 RID: 16148
		private readonly RepeatedField<PresenceField> fields_ = new RepeatedField<PresenceField>();

		// Token: 0x04003F15 RID: 16149
		public const int OldestTimeUsFieldNumber = 4;

		// Token: 0x04003F16 RID: 16150
		private static readonly ulong OldestTimeUsDefaultValue = 0UL;

		// Token: 0x04003F17 RID: 16151
		private ulong oldestTimeUs_;
	}
}
