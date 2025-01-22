using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BF RID: 1471
	public sealed class PresenceOnlineGameAccount : IMessage<PresenceOnlineGameAccount>, IMessage, IEquatable<PresenceOnlineGameAccount>, IDeepCloneable<PresenceOnlineGameAccount>, IBufferMessage
	{
		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06008B71 RID: 35697 RVA: 0x0021D9E4 File Offset: 0x0021BBE4
		[DebuggerNonUserCode]
		public static MessageParser<PresenceOnlineGameAccount> Parser
		{
			get
			{
				return PresenceOnlineGameAccount._parser;
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x0021D9FC File Offset: 0x0021BBFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06008B73 RID: 35699 RVA: 0x0021DA20 File Offset: 0x0021BC20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceOnlineGameAccount.Descriptor;
			}
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x0021DA37 File Offset: 0x0021BC37
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccount()
		{
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x0021DA44 File Offset: 0x0021BC44
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccount(PresenceOnlineGameAccount other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.onlineTimeUs_ = other.onlineTimeUs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x0021DAA0 File Offset: 0x0021BCA0
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccount Clone()
		{
			return new PresenceOnlineGameAccount(this);
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x0021DAB8 File Offset: 0x0021BCB8
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x0021DAD0 File Offset: 0x0021BCD0
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

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x0021DADC File Offset: 0x0021BCDC
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x0021DB0D File Offset: 0x0021BD0D
		[DebuggerNonUserCode]
		public ulong OnlineTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong onlineTimeUsDefaultValue;
				if (flag)
				{
					onlineTimeUsDefaultValue = this.onlineTimeUs_;
				}
				else
				{
					onlineTimeUsDefaultValue = PresenceOnlineGameAccount.OnlineTimeUsDefaultValue;
				}
				return onlineTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.onlineTimeUs_ = value;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06008B7B RID: 35707 RVA: 0x0021DB28 File Offset: 0x0021BD28
		[DebuggerNonUserCode]
		public bool HasOnlineTimeUs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x0021DB45 File Offset: 0x0021BD45
		[DebuggerNonUserCode]
		public void ClearOnlineTimeUs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x0021DB58 File Offset: 0x0021BD58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceOnlineGameAccount);
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x0021DB78 File Offset: 0x0021BD78
		[DebuggerNonUserCode]
		public bool Equals(PresenceOnlineGameAccount other)
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
					bool flag4 = !object.Equals(this.GameAccount, other.GameAccount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.OnlineTimeUs != other.OnlineTimeUs;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x0021DBEC File Offset: 0x0021BDEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool hasOnlineTimeUs = this.HasOnlineTimeUs;
			if (hasOnlineTimeUs)
			{
				num ^= this.OnlineTimeUs.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x0021DC58 File Offset: 0x0021BE58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x0021DC70 File Offset: 0x0021BE70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x0021DC7C File Offset: 0x0021BE7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool hasOnlineTimeUs = this.HasOnlineTimeUs;
			if (hasOnlineTimeUs)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.OnlineTimeUs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0021DCF0 File Offset: 0x0021BEF0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool hasOnlineTimeUs = this.HasOnlineTimeUs;
			if (hasOnlineTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OnlineTimeUs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x0021DD60 File Offset: 0x0021BF60
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceOnlineGameAccount other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasOnlineTimeUs = other.HasOnlineTimeUs;
				if (hasOnlineTimeUs)
				{
					this.OnlineTimeUs = other.OnlineTimeUs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x0021DDE5 File Offset: 0x0021BFE5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x0021DDF0 File Offset: 0x0021BFF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OnlineTimeUs = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.gameAccount_ == null;
					if (flag)
					{
						this.GameAccount = new GameAccountHandle();
					}
					input.ReadMessage(this.GameAccount);
				}
			}
		}

		// Token: 0x04003F22 RID: 16162
		private static readonly MessageParser<PresenceOnlineGameAccount> _parser = new MessageParser<PresenceOnlineGameAccount>(() => new PresenceOnlineGameAccount());

		// Token: 0x04003F23 RID: 16163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F24 RID: 16164
		private int _hasBits0;

		// Token: 0x04003F25 RID: 16165
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04003F26 RID: 16166
		private GameAccountHandle gameAccount_;

		// Token: 0x04003F27 RID: 16167
		public const int OnlineTimeUsFieldNumber = 2;

		// Token: 0x04003F28 RID: 16168
		private static readonly ulong OnlineTimeUsDefaultValue = 0UL;

		// Token: 0x04003F29 RID: 16169
		private ulong onlineTimeUs_;
	}
}
