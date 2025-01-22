using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C5 RID: 1477
	public sealed class QueryRequest : IMessage<QueryRequest>, IMessage, IEquatable<QueryRequest>, IDeepCloneable<QueryRequest>, IBufferMessage
	{
		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x0021EE2C File Offset: 0x0021D02C
		[DebuggerNonUserCode]
		public static MessageParser<QueryRequest> Parser
		{
			get
			{
				return QueryRequest._parser;
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06008BDA RID: 35802 RVA: 0x0021EE44 File Offset: 0x0021D044
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06008BDB RID: 35803 RVA: 0x0021EE68 File Offset: 0x0021D068
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRequest.Descriptor;
			}
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x0021EE7F File Offset: 0x0021D07F
		[DebuggerNonUserCode]
		public QueryRequest()
		{
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x0021EE94 File Offset: 0x0021D094
		[DebuggerNonUserCode]
		public QueryRequest(QueryRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.queryBehavior_ = other.queryBehavior_;
			this.keys_ = other.keys_.Clone();
			this.sinceUs_ = other.sinceUs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x0021EEFC File Offset: 0x0021D0FC
		[DebuggerNonUserCode]
		public QueryRequest Clone()
		{
			return new QueryRequest(this);
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x06008BDF RID: 35807 RVA: 0x0021EF14 File Offset: 0x0021D114
		// (set) Token: 0x06008BE0 RID: 35808 RVA: 0x0021EF45 File Offset: 0x0021D145
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
					accountIdDefaultValue = QueryRequest.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x06008BE1 RID: 35809 RVA: 0x0021EF60 File Offset: 0x0021D160
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008BE2 RID: 35810 RVA: 0x0021EF7D File Offset: 0x0021D17D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06008BE3 RID: 35811 RVA: 0x0021EF90 File Offset: 0x0021D190
		// (set) Token: 0x06008BE4 RID: 35812 RVA: 0x0021EFC1 File Offset: 0x0021D1C1
		[DebuggerNonUserCode]
		public PresenceQueryBehavior QueryBehavior
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				PresenceQueryBehavior queryBehaviorDefaultValue;
				if (flag)
				{
					queryBehaviorDefaultValue = this.queryBehavior_;
				}
				else
				{
					queryBehaviorDefaultValue = QueryRequest.QueryBehaviorDefaultValue;
				}
				return queryBehaviorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.queryBehavior_ = value;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x0021EFDC File Offset: 0x0021D1DC
		[DebuggerNonUserCode]
		public bool HasQueryBehavior
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x0021EFF9 File Offset: 0x0021D1F9
		[DebuggerNonUserCode]
		public void ClearQueryBehavior()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06008BE7 RID: 35815 RVA: 0x0021F00C File Offset: 0x0021D20C
		[DebuggerNonUserCode]
		public RepeatedField<PresenceFieldKey> Keys
		{
			get
			{
				return this.keys_;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x0021F024 File Offset: 0x0021D224
		// (set) Token: 0x06008BE9 RID: 35817 RVA: 0x0021F055 File Offset: 0x0021D255
		[DebuggerNonUserCode]
		public ulong SinceUs
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong sinceUsDefaultValue;
				if (flag)
				{
					sinceUsDefaultValue = this.sinceUs_;
				}
				else
				{
					sinceUsDefaultValue = QueryRequest.SinceUsDefaultValue;
				}
				return sinceUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.sinceUs_ = value;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x0021F070 File Offset: 0x0021D270
		[DebuggerNonUserCode]
		public bool HasSinceUs
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x0021F08D File Offset: 0x0021D28D
		[DebuggerNonUserCode]
		public void ClearSinceUs()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x0021F0A0 File Offset: 0x0021D2A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRequest);
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x0021F0C0 File Offset: 0x0021D2C0
		[DebuggerNonUserCode]
		public bool Equals(QueryRequest other)
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
						bool flag5 = this.QueryBehavior != other.QueryBehavior;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.keys_.Equals(other.keys_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SinceUs != other.SinceUs;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x0021F170 File Offset: 0x0021D370
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasQueryBehavior = this.HasQueryBehavior;
			if (hasQueryBehavior)
			{
				num ^= this.QueryBehavior.GetHashCode();
			}
			num ^= this.keys_.GetHashCode();
			bool hasSinceUs = this.HasSinceUs;
			if (hasSinceUs)
			{
				num ^= this.SinceUs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x0021F210 File Offset: 0x0021D410
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x0021F228 File Offset: 0x0021D428
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x0021F234 File Offset: 0x0021D434
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool hasQueryBehavior = this.HasQueryBehavior;
			if (hasQueryBehavior)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.QueryBehavior);
			}
			this.keys_.WriteTo(ref output, QueryRequest._repeated_keys_codec);
			bool hasSinceUs = this.HasSinceUs;
			if (hasSinceUs)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.SinceUs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x0021F2D8 File Offset: 0x0021D4D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool hasQueryBehavior = this.HasQueryBehavior;
			if (hasQueryBehavior)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.QueryBehavior);
			}
			num += this.keys_.CalculateSize(QueryRequest._repeated_keys_codec);
			bool hasSinceUs = this.HasSinceUs;
			if (hasSinceUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SinceUs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x0021F378 File Offset: 0x0021D578
		[DebuggerNonUserCode]
		public void MergeFrom(QueryRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasQueryBehavior = other.HasQueryBehavior;
				if (hasQueryBehavior)
				{
					this.QueryBehavior = other.QueryBehavior;
				}
				this.keys_.Add(other.keys_);
				bool hasSinceUs = other.HasSinceUs;
				if (hasSinceUs)
				{
					this.SinceUs = other.SinceUs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x0021F405 File Offset: 0x0021D605
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x0021F410 File Offset: 0x0021D610
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
							goto IL_0028;
						}
						this.QueryBehavior = (PresenceQueryBehavior)input.ReadEnum();
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
						goto IL_0028;
					}
					this.SinceUs = input.ReadUInt64();
				}
				else
				{
					this.keys_.AddEntriesFrom(ref input, QueryRequest._repeated_keys_codec);
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F42 RID: 16194
		private static readonly MessageParser<QueryRequest> _parser = new MessageParser<QueryRequest>(() => new QueryRequest());

		// Token: 0x04003F43 RID: 16195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F44 RID: 16196
		private int _hasBits0;

		// Token: 0x04003F45 RID: 16197
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003F46 RID: 16198
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003F47 RID: 16199
		private ulong accountId_;

		// Token: 0x04003F48 RID: 16200
		public const int QueryBehaviorFieldNumber = 2;

		// Token: 0x04003F49 RID: 16201
		private static readonly PresenceQueryBehavior QueryBehaviorDefaultValue = PresenceQueryBehavior.BattleNetAccountOnly;

		// Token: 0x04003F4A RID: 16202
		private PresenceQueryBehavior queryBehavior_;

		// Token: 0x04003F4B RID: 16203
		public const int KeysFieldNumber = 3;

		// Token: 0x04003F4C RID: 16204
		private static readonly FieldCodec<PresenceFieldKey> _repeated_keys_codec = FieldCodec.ForMessage<PresenceFieldKey>(26U, PresenceFieldKey.Parser);

		// Token: 0x04003F4D RID: 16205
		private readonly RepeatedField<PresenceFieldKey> keys_ = new RepeatedField<PresenceFieldKey>();

		// Token: 0x04003F4E RID: 16206
		public const int SinceUsFieldNumber = 4;

		// Token: 0x04003F4F RID: 16207
		private static readonly ulong SinceUsDefaultValue = 0UL;

		// Token: 0x04003F50 RID: 16208
		private ulong sinceUs_;
	}
}
