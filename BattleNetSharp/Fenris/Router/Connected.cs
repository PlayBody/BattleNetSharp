using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Router
{
	// Token: 0x02000125 RID: 293
	public sealed class Connected : IMessage<Connected>, IMessage, IEquatable<Connected>, IDeepCloneable<Connected>, IBufferMessage
	{
		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0006F604 File Offset: 0x0006D804
		[DebuggerNonUserCode]
		public static MessageParser<Connected> Parser
		{
			get
			{
				return Connected._parser;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0006F61C File Offset: 0x0006D81C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RouterReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0006F640 File Offset: 0x0006D840
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Connected.Descriptor;
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0006F657 File Offset: 0x0006D857
		[DebuggerNonUserCode]
		public Connected()
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0006F664 File Offset: 0x0006D864
		[DebuggerNonUserCode]
		public Connected(Connected other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0006F6BC File Offset: 0x0006D8BC
		[DebuggerNonUserCode]
		public Connected Clone()
		{
			return new Connected(this);
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0006F6D4 File Offset: 0x0006D8D4
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0006F705 File Offset: 0x0006D905
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = Connected.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0006F720 File Offset: 0x0006D920
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0006F73D File Offset: 0x0006D93D
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0006F750 File Offset: 0x0006D950
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0006F781 File Offset: 0x0006D981
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
					gameAccountIdDefaultValue = Connected.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0006F79C File Offset: 0x0006D99C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0006F7B9 File Offset: 0x0006D9B9
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0006F7CC File Offset: 0x0006D9CC
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0006F7ED File Offset: 0x0006D9ED
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? Connected.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0006F804 File Offset: 0x0006DA04
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x0006F81F File Offset: 0x0006DA1F
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0006F82C File Offset: 0x0006DA2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Connected);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0006F84C File Offset: 0x0006DA4C
		[DebuggerNonUserCode]
		public bool Equals(Connected other)
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
					bool flag4 = this.BnetAccountId != other.BnetAccountId;
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
							bool flag6 = this.SessionId != other.SessionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num ^= this.BnetAccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0006F960 File Offset: 0x0006DB60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0006F978 File Offset: 0x0006DB78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0006F984 File Offset: 0x0006DB84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SessionId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0006FA14 File Offset: 0x0006DC14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0006FAA0 File Offset: 0x0006DCA0
		[DebuggerNonUserCode]
		public void MergeFrom(Connected other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBnetAccountId = other.HasBnetAccountId;
				if (hasBnetAccountId)
				{
					this.BnetAccountId = other.BnetAccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0006FB1B File Offset: 0x0006DD1B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0006FB28 File Offset: 0x0006DD28
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
							this.SessionId = input.ReadString();
						}
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.BnetAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C68 RID: 3176
		private static readonly MessageParser<Connected> _parser = new MessageParser<Connected>(() => new Connected());

		// Token: 0x04000C69 RID: 3177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C6A RID: 3178
		private int _hasBits0;

		// Token: 0x04000C6B RID: 3179
		public const int BnetAccountIdFieldNumber = 1;

		// Token: 0x04000C6C RID: 3180
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04000C6D RID: 3181
		private uint bnetAccountId_;

		// Token: 0x04000C6E RID: 3182
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04000C6F RID: 3183
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04000C70 RID: 3184
		private uint gameAccountId_;

		// Token: 0x04000C71 RID: 3185
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04000C72 RID: 3186
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04000C73 RID: 3187
		private string sessionId_;
	}
}
