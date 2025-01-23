using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Trace = Fenris.Online.Trace;

namespace Fenris.ClientMessage
{
	// Token: 0x02000220 RID: 544
	public sealed class FindUserProxyRequest : IMessage<FindUserProxyRequest>, IMessage, IEquatable<FindUserProxyRequest>, IDeepCloneable<FindUserProxyRequest>, IBufferMessage
	{
		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x000EAEB0 File Offset: 0x000E90B0
		[DebuggerNonUserCode]
		public static MessageParser<FindUserProxyRequest> Parser
		{
			get
			{
				return FindUserProxyRequest._parser;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x000EAEC8 File Offset: 0x000E90C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x000EAEEC File Offset: 0x000E90EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindUserProxyRequest.Descriptor;
			}
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000EAF03 File Offset: 0x000E9103
		[DebuggerNonUserCode]
		public FindUserProxyRequest()
		{
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x000EAF18 File Offset: 0x000E9118
		[DebuggerNonUserCode]
		public FindUserProxyRequest(FindUserProxyRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platformAccount_ = ((other.platformAccount_ != null) ? other.platformAccount_.Clone() : null);
			this.authCode_ = other.authCode_;
			this.token_ = other.token_;
			this.sessionId_ = other.sessionId_;
			this.serverPool_ = other.serverPool_;
			this.sessionKey_ = other.sessionKey_;
			this.contentLicenseNames_ = other.contentLicenseNames_.Clone();
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this.connectedRegionId_ = other.connectedRegionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x000EAFDC File Offset: 0x000E91DC
		[DebuggerNonUserCode]
		public FindUserProxyRequest Clone()
		{
			return new FindUserProxyRequest(this);
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x000EAFF4 File Offset: 0x000E91F4
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x000EB00C File Offset: 0x000E920C
		[DebuggerNonUserCode]
		public PlatformAccount PlatformAccount
		{
			get
			{
				return this.platformAccount_;
			}
			set
			{
				this.platformAccount_ = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x000EB018 File Offset: 0x000E9218
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x000EB039 File Offset: 0x000E9239
		[DebuggerNonUserCode]
		public string AuthCode
		{
			get
			{
				return this.authCode_ ?? FindUserProxyRequest.AuthCodeDefaultValue;
			}
			set
			{
				this.authCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x000EB050 File Offset: 0x000E9250
		[DebuggerNonUserCode]
		public bool HasAuthCode
		{
			get
			{
				return this.authCode_ != null;
			}
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x000EB06B File Offset: 0x000E926B
		[DebuggerNonUserCode]
		public void ClearAuthCode()
		{
			this.authCode_ = null;
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x000EB078 File Offset: 0x000E9278
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x000EB0A9 File Offset: 0x000E92A9
		[DebuggerNonUserCode]
		public ulong Token
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = FindUserProxyRequest.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.token_ = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x000EB0C4 File Offset: 0x000E92C4
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000EB0E1 File Offset: 0x000E92E1
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x000EB0F4 File Offset: 0x000E92F4
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x000EB115 File Offset: 0x000E9315
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? FindUserProxyRequest.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x000EB12C File Offset: 0x000E932C
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x000EB147 File Offset: 0x000E9347
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x000EB154 File Offset: 0x000E9354
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x000EB175 File Offset: 0x000E9375
		[DebuggerNonUserCode]
		public string ServerPool
		{
			get
			{
				return this.serverPool_ ?? FindUserProxyRequest.ServerPoolDefaultValue;
			}
			set
			{
				this.serverPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x000EB18C File Offset: 0x000E938C
		[DebuggerNonUserCode]
		public bool HasServerPool
		{
			get
			{
				return this.serverPool_ != null;
			}
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x000EB1A7 File Offset: 0x000E93A7
		[DebuggerNonUserCode]
		public void ClearServerPool()
		{
			this.serverPool_ = null;
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x000EB1B4 File Offset: 0x000E93B4
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x000EB1D5 File Offset: 0x000E93D5
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? FindUserProxyRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x000EB1EC File Offset: 0x000E93EC
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x000EB20A File Offset: 0x000E940A
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x000EB214 File Offset: 0x000E9414
		[DebuggerNonUserCode]
		public RepeatedField<string> ContentLicenseNames
		{
			get
			{
				return this.contentLicenseNames_;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x000EB22C File Offset: 0x000E942C
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x000EB244 File Offset: 0x000E9444
		[DebuggerNonUserCode]
		public Trace Trace
		{
			get
			{
				return this.trace_;
			}
			set
			{
				this.trace_ = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000EB250 File Offset: 0x000E9450
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x000EB281 File Offset: 0x000E9481
		[DebuggerNonUserCode]
		public uint ConnectedRegionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint connectedRegionIdDefaultValue;
				if (flag)
				{
					connectedRegionIdDefaultValue = this.connectedRegionId_;
				}
				else
				{
					connectedRegionIdDefaultValue = FindUserProxyRequest.ConnectedRegionIdDefaultValue;
				}
				return connectedRegionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.connectedRegionId_ = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x000EB29C File Offset: 0x000E949C
		[DebuggerNonUserCode]
		public bool HasConnectedRegionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x000EB2B9 File Offset: 0x000E94B9
		[DebuggerNonUserCode]
		public void ClearConnectedRegionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x000EB2CC File Offset: 0x000E94CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindUserProxyRequest);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x000EB2EC File Offset: 0x000E94EC
		[DebuggerNonUserCode]
		public bool Equals(FindUserProxyRequest other)
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
					bool flag4 = !object.Equals(this.PlatformAccount, other.PlatformAccount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AuthCode != other.AuthCode;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Token != other.Token;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SessionId != other.SessionId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ServerPool != other.ServerPool;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SessionKey != other.SessionKey;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.contentLicenseNames_.Equals(other.contentLicenseNames_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Trace, other.Trace);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ConnectedRegionId != other.ConnectedRegionId;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
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

		// Token: 0x06003B35 RID: 15157 RVA: 0x000EB438 File Offset: 0x000E9638
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num ^= this.PlatformAccount.GetHashCode();
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				num ^= this.AuthCode.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num ^= this.ServerPool.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			num ^= this.contentLicenseNames_.GetHashCode();
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				num ^= this.Trace.GetHashCode();
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				num ^= this.ConnectedRegionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x000EB554 File Offset: 0x000E9754
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x000EB56C File Offset: 0x000E976C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x000EB578 File Offset: 0x000E9778
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PlatformAccount);
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				output.WriteRawTag(26);
				output.WriteString(this.AuthCode);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.Token);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(42);
				output.WriteString(this.SessionId);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ServerPool);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.SessionKey);
			}
			this.contentLicenseNames_.WriteTo(ref output, FindUserProxyRequest._repeated_contentLicenseNames_codec);
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Trace);
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ConnectedRegionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x000EB6D4 File Offset: 0x000E98D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlatformAccount);
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AuthCode);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerPool);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			num += this.contentLicenseNames_.CalculateSize(FindUserProxyRequest._repeated_contentLicenseNames_codec);
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trace);
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConnectedRegionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x000EB810 File Offset: 0x000E9A10
		[DebuggerNonUserCode]
		public void MergeFrom(FindUserProxyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.platformAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.platformAccount_ == null;
					if (flag3)
					{
						this.PlatformAccount = new PlatformAccount();
					}
					this.PlatformAccount.MergeFrom(other.PlatformAccount);
				}
				bool hasAuthCode = other.HasAuthCode;
				if (hasAuthCode)
				{
					this.AuthCode = other.AuthCode;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasServerPool = other.HasServerPool;
				if (hasServerPool)
				{
					this.ServerPool = other.ServerPool;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this.contentLicenseNames_.Add(other.contentLicenseNames_);
				bool flag4 = other.trace_ != null;
				if (flag4)
				{
					bool flag5 = this.trace_ == null;
					if (flag5)
					{
						this.Trace = new Trace();
					}
					this.Trace.MergeFrom(other.Trace);
				}
				bool hasConnectedRegionId = other.HasConnectedRegionId;
				if (hasConnectedRegionId)
				{
					this.ConnectedRegionId = other.ConnectedRegionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000EB971 File Offset: 0x000E9B71
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x000EB97C File Offset: 0x000E9B7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0071;
							}
							this.AuthCode = input.ReadString();
						}
						else
						{
							bool flag = this.platformAccount_ == null;
							if (flag)
							{
								this.PlatformAccount = new PlatformAccount();
							}
							input.ReadMessage(this.PlatformAccount);
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0071;
						}
						this.SessionId = input.ReadString();
					}
					else
					{
						this.Token = input.ReadUInt64();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_0071;
						}
						this.SessionKey = input.ReadBytes();
					}
					else
					{
						this.ServerPool = input.ReadString();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						if (num3 != 80U)
						{
							goto IL_0071;
						}
						this.ConnectedRegionId = input.ReadUInt32();
					}
					else
					{
						bool flag2 = this.trace_ == null;
						if (flag2)
						{
							this.Trace = new Trace();
						}
						input.ReadMessage(this.Trace);
					}
				}
				else
				{
					this.contentLicenseNames_.AddEntriesFrom(ref input, FindUserProxyRequest._repeated_contentLicenseNames_codec);
				}
				continue;
				IL_0071:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B5A RID: 7002
		private static readonly MessageParser<FindUserProxyRequest> _parser = new MessageParser<FindUserProxyRequest>(() => new FindUserProxyRequest());

		// Token: 0x04001B5B RID: 7003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B5C RID: 7004
		private int _hasBits0;

		// Token: 0x04001B5D RID: 7005
		public const int PlatformAccountFieldNumber = 2;

		// Token: 0x04001B5E RID: 7006
		private PlatformAccount platformAccount_;

		// Token: 0x04001B5F RID: 7007
		public const int AuthCodeFieldNumber = 3;

		// Token: 0x04001B60 RID: 7008
		private static readonly string AuthCodeDefaultValue = "";

		// Token: 0x04001B61 RID: 7009
		private string authCode_;

		// Token: 0x04001B62 RID: 7010
		public const int TokenFieldNumber = 4;

		// Token: 0x04001B63 RID: 7011
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x04001B64 RID: 7012
		private ulong token_;

		// Token: 0x04001B65 RID: 7013
		public const int SessionIdFieldNumber = 5;

		// Token: 0x04001B66 RID: 7014
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04001B67 RID: 7015
		private string sessionId_;

		// Token: 0x04001B68 RID: 7016
		public const int ServerPoolFieldNumber = 6;

		// Token: 0x04001B69 RID: 7017
		private static readonly string ServerPoolDefaultValue = "";

		// Token: 0x04001B6A RID: 7018
		private string serverPool_;

		// Token: 0x04001B6B RID: 7019
		public const int SessionKeyFieldNumber = 7;

		// Token: 0x04001B6C RID: 7020
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001B6D RID: 7021
		private ByteString sessionKey_;

		// Token: 0x04001B6E RID: 7022
		public const int ContentLicenseNamesFieldNumber = 8;

		// Token: 0x04001B6F RID: 7023
		private static readonly FieldCodec<string> _repeated_contentLicenseNames_codec = FieldCodec.ForString(66U);

		// Token: 0x04001B70 RID: 7024
		private readonly RepeatedField<string> contentLicenseNames_ = new RepeatedField<string>();

		// Token: 0x04001B71 RID: 7025
		public const int TraceFieldNumber = 9;

		// Token: 0x04001B72 RID: 7026
		private Trace trace_;

		// Token: 0x04001B73 RID: 7027
		public const int ConnectedRegionIdFieldNumber = 10;

		// Token: 0x04001B74 RID: 7028
		private static readonly uint ConnectedRegionIdDefaultValue = 0U;

		// Token: 0x04001B75 RID: 7029
		private uint connectedRegionId_;
	}
}
