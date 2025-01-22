using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000541 RID: 1345
	public sealed class SessionCreatedNotification : IMessage<SessionCreatedNotification>, IMessage, IEquatable<SessionCreatedNotification>, IDeepCloneable<SessionCreatedNotification>, IBufferMessage
	{
		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x06008210 RID: 33296 RVA: 0x001F9980 File Offset: 0x001F7B80
		[DebuggerNonUserCode]
		public static MessageParser<SessionCreatedNotification> Parser
		{
			get
			{
				return SessionCreatedNotification._parser;
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x06008211 RID: 33297 RVA: 0x001F9998 File Offset: 0x001F7B98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x06008212 RID: 33298 RVA: 0x001F99BC File Offset: 0x001F7BBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionCreatedNotification.Descriptor;
			}
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x001F99D3 File Offset: 0x001F7BD3
		[DebuggerNonUserCode]
		public SessionCreatedNotification()
		{
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x001F99E0 File Offset: 0x001F7BE0
		[DebuggerNonUserCode]
		public SessionCreatedNotification(SessionCreatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.reason_ = other.reason_;
			this.sessionId_ = other.sessionId_;
			this.sessionKey_ = other.sessionKey_;
			this.clientId_ = other.clientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x001F9A60 File Offset: 0x001F7C60
		[DebuggerNonUserCode]
		public SessionCreatedNotification Clone()
		{
			return new SessionCreatedNotification(this);
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x001F9A78 File Offset: 0x001F7C78
		// (set) Token: 0x06008217 RID: 33303 RVA: 0x001F9A90 File Offset: 0x001F7C90
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x06008218 RID: 33304 RVA: 0x001F9A9C File Offset: 0x001F7C9C
		// (set) Token: 0x06008219 RID: 33305 RVA: 0x001F9ACD File Offset: 0x001F7CCD
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = SessionCreatedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600821A RID: 33306 RVA: 0x001F9AE8 File Offset: 0x001F7CE8
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x001F9B05 File Offset: 0x001F7D05
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600821C RID: 33308 RVA: 0x001F9B18 File Offset: 0x001F7D18
		// (set) Token: 0x0600821D RID: 33309 RVA: 0x001F9B39 File Offset: 0x001F7D39
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionCreatedNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600821E RID: 33310 RVA: 0x001F9B50 File Offset: 0x001F7D50
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x001F9B6B File Offset: 0x001F7D6B
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x001F9B78 File Offset: 0x001F7D78
		// (set) Token: 0x06008221 RID: 33313 RVA: 0x001F9B99 File Offset: 0x001F7D99
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? SessionCreatedNotification.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06008222 RID: 33314 RVA: 0x001F9BB0 File Offset: 0x001F7DB0
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x001F9BCE File Offset: 0x001F7DCE
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x001F9BD8 File Offset: 0x001F7DD8
		// (set) Token: 0x06008225 RID: 33317 RVA: 0x001F9BF9 File Offset: 0x001F7DF9
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? SessionCreatedNotification.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x06008226 RID: 33318 RVA: 0x001F9C10 File Offset: 0x001F7E10
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x001F9C2B File Offset: 0x001F7E2B
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x001F9C38 File Offset: 0x001F7E38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionCreatedNotification);
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x001F9C58 File Offset: 0x001F7E58
		[DebuggerNonUserCode]
		public bool Equals(SessionCreatedNotification other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reason != other.Reason;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionId != other.SessionId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SessionKey != other.SessionKey;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ClientId != other.ClientId;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x001F9D28 File Offset: 0x001F7F28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x001F9DE4 File Offset: 0x001F7FE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x001F9DFC File Offset: 0x001F7FFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x001F9E08 File Offset: 0x001F8008
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Reason);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SessionId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.SessionKey);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x001F9EE4 File Offset: 0x001F80E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x001F9FB0 File Offset: 0x001F81B0
		[DebuggerNonUserCode]
		public void MergeFrom(SessionCreatedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x001FA089 File Offset: 0x001F8289
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x001FA094 File Offset: 0x001F8294
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.Reason = input.ReadUInt32();
					}
					else
					{
						bool flag = this.identity_ == null;
						if (flag)
						{
							this.Identity = new Identity();
						}
						input.ReadMessage(this.Identity);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						this.ClientId = input.ReadString();
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else
				{
					this.SessionId = input.ReadString();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AD7 RID: 15063
		private static readonly MessageParser<SessionCreatedNotification> _parser = new MessageParser<SessionCreatedNotification>(() => new SessionCreatedNotification());

		// Token: 0x04003AD8 RID: 15064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AD9 RID: 15065
		private int _hasBits0;

		// Token: 0x04003ADA RID: 15066
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003ADB RID: 15067
		private Identity identity_;

		// Token: 0x04003ADC RID: 15068
		public const int ReasonFieldNumber = 2;

		// Token: 0x04003ADD RID: 15069
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04003ADE RID: 15070
		private uint reason_;

		// Token: 0x04003ADF RID: 15071
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04003AE0 RID: 15072
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003AE1 RID: 15073
		private string sessionId_;

		// Token: 0x04003AE2 RID: 15074
		public const int SessionKeyFieldNumber = 4;

		// Token: 0x04003AE3 RID: 15075
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04003AE4 RID: 15076
		private ByteString sessionKey_;

		// Token: 0x04003AE5 RID: 15077
		public const int ClientIdFieldNumber = 5;

		// Token: 0x04003AE6 RID: 15078
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x04003AE7 RID: 15079
		private string clientId_;
	}
}
