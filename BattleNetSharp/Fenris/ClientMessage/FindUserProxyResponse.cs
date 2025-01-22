using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000221 RID: 545
	public sealed class FindUserProxyResponse : IMessage<FindUserProxyResponse>, IMessage, IEquatable<FindUserProxyResponse>, IDeepCloneable<FindUserProxyResponse>, IBufferMessage
	{
		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x000EBB64 File Offset: 0x000E9D64
		[DebuggerNonUserCode]
		public static MessageParser<FindUserProxyResponse> Parser
		{
			get
			{
				return FindUserProxyResponse._parser;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06003B3F RID: 15167 RVA: 0x000EBB7C File Offset: 0x000E9D7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x000EBBA0 File Offset: 0x000E9DA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindUserProxyResponse.Descriptor;
			}
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000EBBB7 File Offset: 0x000E9DB7
		[DebuggerNonUserCode]
		public FindUserProxyResponse()
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000EBBC4 File Offset: 0x000E9DC4
		[DebuggerNonUserCode]
		public FindUserProxyResponse(FindUserProxyResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.connectInfo_ = ((other.connectInfo_ != null) ? other.connectInfo_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this.token_ = other.token_;
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000EBC64 File Offset: 0x000E9E64
		[DebuggerNonUserCode]
		public FindUserProxyResponse Clone()
		{
			return new FindUserProxyResponse(this);
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x000EBC7C File Offset: 0x000E9E7C
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x000EBC94 File Offset: 0x000E9E94
		[DebuggerNonUserCode]
		public ConnectionInfo ConnectInfo
		{
			get
			{
				return this.connectInfo_;
			}
			set
			{
				this.connectInfo_ = value;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x000EBCA0 File Offset: 0x000E9EA0
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x000EBCD1 File Offset: 0x000E9ED1
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = FindUserProxyResponse.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x000EBCEC File Offset: 0x000E9EEC
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x000EBD09 File Offset: 0x000E9F09
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x000EBD1C File Offset: 0x000E9F1C
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x000EBD4D File Offset: 0x000E9F4D
		[DebuggerNonUserCode]
		public ulong Token
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = FindUserProxyResponse.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.token_ = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x000EBD68 File Offset: 0x000E9F68
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x000EBD85 File Offset: 0x000E9F85
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x000EBD98 File Offset: 0x000E9F98
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x000EBDB0 File Offset: 0x000E9FB0
		[DebuggerNonUserCode]
		public QueueEntryKey EntryKey
		{
			get
			{
				return this.entryKey_;
			}
			set
			{
				this.entryKey_ = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x000EBDBC File Offset: 0x000E9FBC
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x000EBDD4 File Offset: 0x000E9FD4
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

		// Token: 0x06003B52 RID: 15186 RVA: 0x000EBDE0 File Offset: 0x000E9FE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindUserProxyResponse);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x000EBE00 File Offset: 0x000EA000
		[DebuggerNonUserCode]
		public bool Equals(FindUserProxyResponse other)
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
					bool flag4 = !object.Equals(this.ConnectInfo, other.ConnectInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ErrorCode != other.ErrorCode;
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
								bool flag7 = !object.Equals(this.EntryKey, other.EntryKey);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Trace, other.Trace);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000EBED4 File Offset: 0x000EA0D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.connectInfo_ != null;
			if (flag)
			{
				num ^= this.ConnectInfo.GetHashCode();
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				num ^= this.EntryKey.GetHashCode();
			}
			bool flag3 = this.trace_ != null;
			if (flag3)
			{
				num ^= this.Trace.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000EBF98 File Offset: 0x000EA198
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x000EBFB0 File Offset: 0x000EA1B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000EBFBC File Offset: 0x000EA1BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.connectInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ConnectInfo);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ErrorCode);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Token);
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.EntryKey);
			}
			bool flag3 = this.trace_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Trace);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000EC0A0 File Offset: 0x000EA2A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.connectInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectInfo);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntryKey);
			}
			bool flag3 = this.trace_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trace);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x000EC170 File Offset: 0x000EA370
		[DebuggerNonUserCode]
		public void MergeFrom(FindUserProxyResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.connectInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.connectInfo_ == null;
					if (flag3)
					{
						this.ConnectInfo = new ConnectionInfo();
					}
					this.ConnectInfo.MergeFrom(other.ConnectInfo);
				}
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool flag4 = other.entryKey_ != null;
				if (flag4)
				{
					bool flag5 = this.entryKey_ == null;
					if (flag5)
					{
						this.EntryKey = new QueueEntryKey();
					}
					this.EntryKey.MergeFrom(other.EntryKey);
				}
				bool flag6 = other.trace_ != null;
				if (flag6)
				{
					bool flag7 = this.trace_ == null;
					if (flag7)
					{
						this.Trace = new Trace();
					}
					this.Trace.MergeFrom(other.Trace);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000EC293 File Offset: 0x000EA493
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000EC2A0 File Offset: 0x000EA4A0
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
							goto IL_0036;
						}
						this.ErrorCode = input.ReadUInt32();
					}
					else
					{
						bool flag = this.connectInfo_ == null;
						if (flag)
						{
							this.ConnectInfo = new ConnectionInfo();
						}
						input.ReadMessage(this.ConnectInfo);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0036;
						}
						bool flag2 = this.trace_ == null;
						if (flag2)
						{
							this.Trace = new Trace();
						}
						input.ReadMessage(this.Trace);
					}
					else
					{
						bool flag3 = this.entryKey_ == null;
						if (flag3)
						{
							this.EntryKey = new QueueEntryKey();
						}
						input.ReadMessage(this.EntryKey);
					}
				}
				else
				{
					this.Token = input.ReadUInt64();
				}
				continue;
				IL_0036:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B76 RID: 7030
		private static readonly MessageParser<FindUserProxyResponse> _parser = new MessageParser<FindUserProxyResponse>(() => new FindUserProxyResponse());

		// Token: 0x04001B77 RID: 7031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B78 RID: 7032
		private int _hasBits0;

		// Token: 0x04001B79 RID: 7033
		public const int ConnectInfoFieldNumber = 1;

		// Token: 0x04001B7A RID: 7034
		private ConnectionInfo connectInfo_;

		// Token: 0x04001B7B RID: 7035
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04001B7C RID: 7036
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04001B7D RID: 7037
		private uint errorCode_;

		// Token: 0x04001B7E RID: 7038
		public const int TokenFieldNumber = 3;

		// Token: 0x04001B7F RID: 7039
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x04001B80 RID: 7040
		private ulong token_;

		// Token: 0x04001B81 RID: 7041
		public const int EntryKeyFieldNumber = 4;

		// Token: 0x04001B82 RID: 7042
		private QueueEntryKey entryKey_;

		// Token: 0x04001B83 RID: 7043
		public const int TraceFieldNumber = 5;

		// Token: 0x04001B84 RID: 7044
		private Trace trace_;
	}
}
