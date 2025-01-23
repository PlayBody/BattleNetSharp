using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Trace = Fenris.Online.Trace;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022D RID: 557
	public sealed class AddLocalPlayerToUserProxyResponse : IMessage<AddLocalPlayerToUserProxyResponse>, IMessage, IEquatable<AddLocalPlayerToUserProxyResponse>, IDeepCloneable<AddLocalPlayerToUserProxyResponse>, IBufferMessage
	{
		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x000F002C File Offset: 0x000EE22C
		[DebuggerNonUserCode]
		public static MessageParser<AddLocalPlayerToUserProxyResponse> Parser
		{
			get
			{
				return AddLocalPlayerToUserProxyResponse._parser;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x000F0044 File Offset: 0x000EE244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x000F0068 File Offset: 0x000EE268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddLocalPlayerToUserProxyResponse.Descriptor;
			}
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x000F007F File Offset: 0x000EE27F
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyResponse()
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000F008C File Offset: 0x000EE28C
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyResponse(AddLocalPlayerToUserProxyResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.token_ = other.token_;
			this.gameAccountId_ = other.gameAccountId_;
			this.errorCode_ = other.errorCode_;
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000F0100 File Offset: 0x000EE300
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyResponse Clone()
		{
			return new AddLocalPlayerToUserProxyResponse(this);
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x000F0118 File Offset: 0x000EE318
		// (set) Token: 0x06003C86 RID: 15494 RVA: 0x000F0149 File Offset: 0x000EE349
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
					tokenDefaultValue = AddLocalPlayerToUserProxyResponse.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.token_ = value;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x000F0164 File Offset: 0x000EE364
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x000F0181 File Offset: 0x000EE381
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x000F0194 File Offset: 0x000EE394
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x000F01C5 File Offset: 0x000EE3C5
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
					gameAccountIdDefaultValue = AddLocalPlayerToUserProxyResponse.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x000F01E0 File Offset: 0x000EE3E0
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x000F01FD File Offset: 0x000EE3FD
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x000F0210 File Offset: 0x000EE410
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x000F0241 File Offset: 0x000EE441
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = AddLocalPlayerToUserProxyResponse.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.errorCode_ = value;
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000F025C File Offset: 0x000EE45C
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x000F0279 File Offset: 0x000EE479
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x000F028C File Offset: 0x000EE48C
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x000F02A4 File Offset: 0x000EE4A4
		[DebuggerNonUserCode]
		public Fenris.Online.Trace Trace
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

		// Token: 0x06003C93 RID: 15507 RVA: 0x000F02B0 File Offset: 0x000EE4B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddLocalPlayerToUserProxyResponse);
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x000F02D0 File Offset: 0x000EE4D0
		[DebuggerNonUserCode]
		public bool Equals(AddLocalPlayerToUserProxyResponse other)
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
					bool flag4 = this.Token != other.Token;
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
							bool flag6 = this.ErrorCode != other.ErrorCode;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Trace, other.Trace);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x000F0380 File Offset: 0x000EE580
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this.trace_ != null;
			if (flag)
			{
				num ^= this.Trace.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x000F0428 File Offset: 0x000EE628
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000F0440 File Offset: 0x000EE640
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x000F044C File Offset: 0x000EE64C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Token);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this.trace_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Trace);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x000F0504 File Offset: 0x000EE704
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this.trace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trace);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x000F05B0 File Offset: 0x000EE7B0
		[DebuggerNonUserCode]
		public void MergeFrom(AddLocalPlayerToUserProxyResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool flag2 = other.trace_ != null;
				if (flag2)
				{
					bool flag3 = this.trace_ == null;
					if (flag3)
					{
						this.Trace = new Fenris.Online.Trace();
					}
					this.Trace.MergeFrom(other.Trace);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x000F066E File Offset: 0x000EE86E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x000F067C File Offset: 0x000EE87C
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							goto IL_002C;
						}
						this.GameAccountId = input.ReadUInt32();
					}
					else
					{
						this.Token = input.ReadUInt64();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						goto IL_002C;
					}
					bool flag = this.trace_ == null;
					if (flag)
					{
						this.Trace = new Fenris.Online.Trace();
					}
					input.ReadMessage(this.Trace);
				}
				else
				{
					this.ErrorCode = input.ReadUInt32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BF8 RID: 7160
		private static readonly MessageParser<AddLocalPlayerToUserProxyResponse> _parser = new MessageParser<AddLocalPlayerToUserProxyResponse>(() => new AddLocalPlayerToUserProxyResponse());

		// Token: 0x04001BF9 RID: 7161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BFA RID: 7162
		private int _hasBits0;

		// Token: 0x04001BFB RID: 7163
		public const int TokenFieldNumber = 2;

		// Token: 0x04001BFC RID: 7164
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x04001BFD RID: 7165
		private ulong token_;

		// Token: 0x04001BFE RID: 7166
		public const int GameAccountIdFieldNumber = 3;

		// Token: 0x04001BFF RID: 7167
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001C00 RID: 7168
		private uint gameAccountId_;

		// Token: 0x04001C01 RID: 7169
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04001C02 RID: 7170
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04001C03 RID: 7171
		private uint errorCode_;

		// Token: 0x04001C04 RID: 7172
		public const int TraceFieldNumber = 5;

		// Token: 0x04001C05 RID: 7173
		private Fenris.Online.Trace trace_;
	}
}
