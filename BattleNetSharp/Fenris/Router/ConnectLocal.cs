using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Router
{
	// Token: 0x02000124 RID: 292
	public sealed class ConnectLocal : IMessage<ConnectLocal>, IMessage, IEquatable<ConnectLocal>, IDeepCloneable<ConnectLocal>, IBufferMessage
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0006F03C File Offset: 0x0006D23C
		[DebuggerNonUserCode]
		public static MessageParser<ConnectLocal> Parser
		{
			get
			{
				return ConnectLocal._parser;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0006F054 File Offset: 0x0006D254
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RouterReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0006F078 File Offset: 0x0006D278
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectLocal.Descriptor;
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0006F08F File Offset: 0x0006D28F
		[DebuggerNonUserCode]
		public ConnectLocal()
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0006F09C File Offset: 0x0006D29C
		[DebuggerNonUserCode]
		public ConnectLocal(ConnectLocal other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.isReconnect_ = other.isReconnect_;
			this.username_ = other.username_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0006F0F4 File Offset: 0x0006D2F4
		[DebuggerNonUserCode]
		public ConnectLocal Clone()
		{
			return new ConnectLocal(this);
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0006F10C File Offset: 0x0006D30C
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0006F13D File Offset: 0x0006D33D
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ConnectLocal.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0006F158 File Offset: 0x0006D358
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0006F175 File Offset: 0x0006D375
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0006F188 File Offset: 0x0006D388
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0006F1B9 File Offset: 0x0006D3B9
		[DebuggerNonUserCode]
		public bool IsReconnect
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isReconnectDefaultValue;
				if (flag)
				{
					isReconnectDefaultValue = this.isReconnect_;
				}
				else
				{
					isReconnectDefaultValue = ConnectLocal.IsReconnectDefaultValue;
				}
				return isReconnectDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isReconnect_ = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		[DebuggerNonUserCode]
		public bool HasIsReconnect
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0006F1F1 File Offset: 0x0006D3F1
		[DebuggerNonUserCode]
		public void ClearIsReconnect()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0006F204 File Offset: 0x0006D404
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0006F225 File Offset: 0x0006D425
		[DebuggerNonUserCode]
		public string Username
		{
			get
			{
				return this.username_ ?? ConnectLocal.UsernameDefaultValue;
			}
			set
			{
				this.username_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0006F23C File Offset: 0x0006D43C
		[DebuggerNonUserCode]
		public bool HasUsername
		{
			get
			{
				return this.username_ != null;
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0006F257 File Offset: 0x0006D457
		[DebuggerNonUserCode]
		public void ClearUsername()
		{
			this.username_ = null;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0006F264 File Offset: 0x0006D464
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectLocal);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0006F284 File Offset: 0x0006D484
		[DebuggerNonUserCode]
		public bool Equals(ConnectLocal other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsReconnect != other.IsReconnect;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Username != other.Username;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0006F310 File Offset: 0x0006D510
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasIsReconnect = this.HasIsReconnect;
			if (hasIsReconnect)
			{
				num ^= this.IsReconnect.GetHashCode();
			}
			bool hasUsername = this.HasUsername;
			if (hasUsername)
			{
				num ^= this.Username.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0006F398 File Offset: 0x0006D598
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0006F3B0 File Offset: 0x0006D5B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0006F3BC File Offset: 0x0006D5BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasIsReconnect = this.HasIsReconnect;
			if (hasIsReconnect)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReconnect);
			}
			bool hasUsername = this.HasUsername;
			if (hasUsername)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Username);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0006F44C File Offset: 0x0006D64C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasIsReconnect = this.HasIsReconnect;
			if (hasIsReconnect)
			{
				num += 2;
			}
			bool hasUsername = this.HasUsername;
			if (hasUsername)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Username);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0006F4CC File Offset: 0x0006D6CC
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectLocal other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasIsReconnect = other.HasIsReconnect;
				if (hasIsReconnect)
				{
					this.IsReconnect = other.IsReconnect;
				}
				bool hasUsername = other.HasUsername;
				if (hasUsername)
				{
					this.Username = other.Username;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0006F547 File Offset: 0x0006D747
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0006F554 File Offset: 0x0006D754
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Username = input.ReadString();
						}
					}
					else
					{
						this.IsReconnect = input.ReadBool();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C5C RID: 3164
		private static readonly MessageParser<ConnectLocal> _parser = new MessageParser<ConnectLocal>(() => new ConnectLocal());

		// Token: 0x04000C5D RID: 3165
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C5E RID: 3166
		private int _hasBits0;

		// Token: 0x04000C5F RID: 3167
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04000C60 RID: 3168
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04000C61 RID: 3169
		private uint gameAccountId_;

		// Token: 0x04000C62 RID: 3170
		public const int IsReconnectFieldNumber = 2;

		// Token: 0x04000C63 RID: 3171
		private static readonly bool IsReconnectDefaultValue = false;

		// Token: 0x04000C64 RID: 3172
		private bool isReconnect_;

		// Token: 0x04000C65 RID: 3173
		public const int UsernameFieldNumber = 3;

		// Token: 0x04000C66 RID: 3174
		private static readonly string UsernameDefaultValue = "";

		// Token: 0x04000C67 RID: 3175
		private string username_;
	}
}
