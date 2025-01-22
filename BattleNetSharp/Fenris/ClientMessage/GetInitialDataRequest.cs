using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021D RID: 541
	public sealed class GetInitialDataRequest : IMessage<GetInitialDataRequest>, IMessage, IEquatable<GetInitialDataRequest>, IDeepCloneable<GetInitialDataRequest>, IBufferMessage
	{
		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x000E8D64 File Offset: 0x000E6F64
		[DebuggerNonUserCode]
		public static MessageParser<GetInitialDataRequest> Parser
		{
			get
			{
				return GetInitialDataRequest._parser;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x000E8D7C File Offset: 0x000E6F7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x000E8DA0 File Offset: 0x000E6FA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInitialDataRequest.Descriptor;
			}
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000E8DB7 File Offset: 0x000E6FB7
		[DebuggerNonUserCode]
		public GetInitialDataRequest()
		{
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x000E8DC4 File Offset: 0x000E6FC4
		[DebuggerNonUserCode]
		public GetInitialDataRequest(GetInitialDataRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionKey_ = other.sessionKey_;
			this.gameServerPool_ = other.gameServerPool_;
			this.battletag_ = other.battletag_;
			this.multiplayerAllowed_ = other.multiplayerAllowed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x000E8E28 File Offset: 0x000E7028
		[DebuggerNonUserCode]
		public GetInitialDataRequest Clone()
		{
			return new GetInitialDataRequest(this);
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x000E8E40 File Offset: 0x000E7040
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x000E8E61 File Offset: 0x000E7061
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? GetInitialDataRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x000E8E78 File Offset: 0x000E7078
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x000E8E96 File Offset: 0x000E7096
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x000E8EA0 File Offset: 0x000E70A0
		// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x000E8EC1 File Offset: 0x000E70C1
		[DebuggerNonUserCode]
		public string GameServerPool
		{
			get
			{
				return this.gameServerPool_ ?? GetInitialDataRequest.GameServerPoolDefaultValue;
			}
			set
			{
				this.gameServerPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x000E8ED8 File Offset: 0x000E70D8
		[DebuggerNonUserCode]
		public bool HasGameServerPool
		{
			get
			{
				return this.gameServerPool_ != null;
			}
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x000E8EF3 File Offset: 0x000E70F3
		[DebuggerNonUserCode]
		public void ClearGameServerPool()
		{
			this.gameServerPool_ = null;
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x000E8F00 File Offset: 0x000E7100
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x000E8F21 File Offset: 0x000E7121
		[DebuggerNonUserCode]
		public string Battletag
		{
			get
			{
				return this.battletag_ ?? GetInitialDataRequest.BattletagDefaultValue;
			}
			set
			{
				this.battletag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x000E8F38 File Offset: 0x000E7138
		[DebuggerNonUserCode]
		public bool HasBattletag
		{
			get
			{
				return this.battletag_ != null;
			}
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x000E8F53 File Offset: 0x000E7153
		[DebuggerNonUserCode]
		public void ClearBattletag()
		{
			this.battletag_ = null;
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x000E8F60 File Offset: 0x000E7160
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x000E8F91 File Offset: 0x000E7191
		[DebuggerNonUserCode]
		public bool MultiplayerAllowed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool multiplayerAllowedDefaultValue;
				if (flag)
				{
					multiplayerAllowedDefaultValue = this.multiplayerAllowed_;
				}
				else
				{
					multiplayerAllowedDefaultValue = GetInitialDataRequest.MultiplayerAllowedDefaultValue;
				}
				return multiplayerAllowedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.multiplayerAllowed_ = value;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x000E8FAC File Offset: 0x000E71AC
		[DebuggerNonUserCode]
		public bool HasMultiplayerAllowed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x000E8FC9 File Offset: 0x000E71C9
		[DebuggerNonUserCode]
		public void ClearMultiplayerAllowed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x000E8FDC File Offset: 0x000E71DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInitialDataRequest);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x000E8FFC File Offset: 0x000E71FC
		[DebuggerNonUserCode]
		public bool Equals(GetInitialDataRequest other)
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
					bool flag4 = this.SessionKey != other.SessionKey;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameServerPool != other.GameServerPool;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Battletag != other.Battletag;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MultiplayerAllowed != other.MultiplayerAllowed;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000E90A8 File Offset: 0x000E72A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool hasGameServerPool = this.HasGameServerPool;
			if (hasGameServerPool)
			{
				num ^= this.GameServerPool.GetHashCode();
			}
			bool hasBattletag = this.HasBattletag;
			if (hasBattletag)
			{
				num ^= this.Battletag.GetHashCode();
			}
			bool hasMultiplayerAllowed = this.HasMultiplayerAllowed;
			if (hasMultiplayerAllowed)
			{
				num ^= this.MultiplayerAllowed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000E9144 File Offset: 0x000E7344
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x000E915C File Offset: 0x000E735C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x000E9168 File Offset: 0x000E7368
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SessionKey);
			}
			bool hasGameServerPool = this.HasGameServerPool;
			if (hasGameServerPool)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameServerPool);
			}
			bool hasBattletag = this.HasBattletag;
			if (hasBattletag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Battletag);
			}
			bool hasMultiplayerAllowed = this.HasMultiplayerAllowed;
			if (hasMultiplayerAllowed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.MultiplayerAllowed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x000E921C File Offset: 0x000E741C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool hasGameServerPool = this.HasGameServerPool;
			if (hasGameServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameServerPool);
			}
			bool hasBattletag = this.HasBattletag;
			if (hasBattletag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Battletag);
			}
			bool hasMultiplayerAllowed = this.HasMultiplayerAllowed;
			if (hasMultiplayerAllowed)
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

		// Token: 0x06003AB5 RID: 15029 RVA: 0x000E92B8 File Offset: 0x000E74B8
		[DebuggerNonUserCode]
		public void MergeFrom(GetInitialDataRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool hasGameServerPool = other.HasGameServerPool;
				if (hasGameServerPool)
				{
					this.GameServerPool = other.GameServerPool;
				}
				bool hasBattletag = other.HasBattletag;
				if (hasBattletag)
				{
					this.Battletag = other.Battletag;
				}
				bool hasMultiplayerAllowed = other.HasMultiplayerAllowed;
				if (hasMultiplayerAllowed)
				{
					this.MultiplayerAllowed = other.MultiplayerAllowed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x000E934E File Offset: 0x000E754E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x000E935C File Offset: 0x000E755C
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
							goto IL_0029;
						}
						this.GameServerPool = input.ReadString();
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.MultiplayerAllowed = input.ReadBool();
				}
				else
				{
					this.Battletag = input.ReadString();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B11 RID: 6929
		private static readonly MessageParser<GetInitialDataRequest> _parser = new MessageParser<GetInitialDataRequest>(() => new GetInitialDataRequest());

		// Token: 0x04001B12 RID: 6930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B13 RID: 6931
		private int _hasBits0;

		// Token: 0x04001B14 RID: 6932
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04001B15 RID: 6933
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001B16 RID: 6934
		private ByteString sessionKey_;

		// Token: 0x04001B17 RID: 6935
		public const int GameServerPoolFieldNumber = 2;

		// Token: 0x04001B18 RID: 6936
		private static readonly string GameServerPoolDefaultValue = "";

		// Token: 0x04001B19 RID: 6937
		private string gameServerPool_;

		// Token: 0x04001B1A RID: 6938
		public const int BattletagFieldNumber = 3;

		// Token: 0x04001B1B RID: 6939
		private static readonly string BattletagDefaultValue = "";

		// Token: 0x04001B1C RID: 6940
		private string battletag_;

		// Token: 0x04001B1D RID: 6941
		public const int MultiplayerAllowedFieldNumber = 4;

		// Token: 0x04001B1E RID: 6942
		private static readonly bool MultiplayerAllowedDefaultValue = false;

		// Token: 0x04001B1F RID: 6943
		private bool multiplayerAllowed_;
	}
}
