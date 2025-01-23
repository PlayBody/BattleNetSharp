using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Router
{
	// Token: 0x02000123 RID: 291
	public sealed class Connect : IMessage<Connect>, IMessage, IEquatable<Connect>, IDeepCloneable<Connect>, IBufferMessage
	{
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0006E984 File Offset: 0x0006CB84
		[DebuggerNonUserCode]
		public static MessageParser<Connect> Parser
		{
			get
			{
				return Connect._parser;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0006E99C File Offset: 0x0006CB9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RouterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0006E9C0 File Offset: 0x0006CBC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Connect.Descriptor;
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0006E9D7 File Offset: 0x0006CBD7
		[DebuggerNonUserCode]
		public Connect()
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0006E9EC File Offset: 0x0006CBEC
		[DebuggerNonUserCode]
		public Connect(Connect other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.token_ = other.token_;
			this.contentLicenseNames_ = other.contentLicenseNames_.Clone();
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0006EA64 File Offset: 0x0006CC64
		[DebuggerNonUserCode]
		public Connect Clone()
		{
			return new Connect(this);
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0006EA7C File Offset: 0x0006CC7C
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0006EAAD File Offset: 0x0006CCAD
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
					gameAccountIdDefaultValue = Connect.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0006EAC8 File Offset: 0x0006CCC8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0006EAE5 File Offset: 0x0006CCE5
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0006EAF8 File Offset: 0x0006CCF8
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0006EB29 File Offset: 0x0006CD29
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
					tokenDefaultValue = Connect.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.token_ = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0006EB44 File Offset: 0x0006CD44
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0006EB61 File Offset: 0x0006CD61
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0006EB74 File Offset: 0x0006CD74
		[DebuggerNonUserCode]
		public RepeatedField<string> ContentLicenseNames
		{
			get
			{
				return this.contentLicenseNames_;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0006EB8C File Offset: 0x0006CD8C
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0006EBA4 File Offset: 0x0006CDA4
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

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Connect);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0006EBD0 File Offset: 0x0006CDD0
		[DebuggerNonUserCode]
		public bool Equals(Connect other)
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
						bool flag5 = this.Token != other.Token;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.contentLicenseNames_.Equals(other.contentLicenseNames_);
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

		// Token: 0x06001CFA RID: 7418 RVA: 0x0006EC84 File Offset: 0x0006CE84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			num ^= this.contentLicenseNames_.GetHashCode();
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

		// Token: 0x06001CFB RID: 7419 RVA: 0x0006ED1C File Offset: 0x0006CF1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0006ED34 File Offset: 0x0006CF34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0006ED40 File Offset: 0x0006CF40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Token);
			}
			this.contentLicenseNames_.WriteTo(ref output, Connect._repeated_contentLicenseNames_codec);
			bool flag = this.trace_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Trace);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0006EDE4 File Offset: 0x0006CFE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			num += this.contentLicenseNames_.CalculateSize(Connect._repeated_contentLicenseNames_codec);
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

		// Token: 0x06001CFF RID: 7423 RVA: 0x0006EE84 File Offset: 0x0006D084
		[DebuggerNonUserCode]
		public void MergeFrom(Connect other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				this.contentLicenseNames_.Add(other.contentLicenseNames_);
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

		// Token: 0x06001D00 RID: 7424 RVA: 0x0006EF39 File Offset: 0x0006D139
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0006EF44 File Offset: 0x0006D144
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_002B;
						}
						this.Token = input.ReadUInt64();
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002B;
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
					this.contentLicenseNames_.AddEntriesFrom(ref input, Connect._repeated_contentLicenseNames_codec);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C4E RID: 3150
		private static readonly MessageParser<Connect> _parser = new MessageParser<Connect>(() => new Connect());

		// Token: 0x04000C4F RID: 3151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C50 RID: 3152
		private int _hasBits0;

		// Token: 0x04000C51 RID: 3153
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04000C52 RID: 3154
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04000C53 RID: 3155
		private uint gameAccountId_;

		// Token: 0x04000C54 RID: 3156
		public const int TokenFieldNumber = 2;

		// Token: 0x04000C55 RID: 3157
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x04000C56 RID: 3158
		private ulong token_;

		// Token: 0x04000C57 RID: 3159
		public const int ContentLicenseNamesFieldNumber = 3;

		// Token: 0x04000C58 RID: 3160
		private static readonly FieldCodec<string> _repeated_contentLicenseNames_codec = FieldCodec.ForString(26U);

		// Token: 0x04000C59 RID: 3161
		private readonly RepeatedField<string> contentLicenseNames_ = new RepeatedField<string>();

		// Token: 0x04000C5A RID: 3162
		public const int TraceFieldNumber = 4;

		// Token: 0x04000C5B RID: 3163
		private Fenris.Online.Trace trace_;
	}
}
