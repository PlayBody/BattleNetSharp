using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063D RID: 1597
	public sealed class RecentPlayerOptions : IMessage<RecentPlayerOptions>, IMessage, IEquatable<RecentPlayerOptions>, IDeepCloneable<RecentPlayerOptions>, IBufferMessage
	{
		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x06009495 RID: 38037 RVA: 0x0023F508 File Offset: 0x0023D708
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayerOptions> Parser
		{
			get
			{
				return RecentPlayerOptions._parser;
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x06009496 RID: 38038 RVA: 0x0023F520 File Offset: 0x0023D720
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x06009497 RID: 38039 RVA: 0x0023F544 File Offset: 0x0023D744
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayerOptions.Descriptor;
			}
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x0023F55B File Offset: 0x0023D75B
		[DebuggerNonUserCode]
		public RecentPlayerOptions()
		{
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x0023F570 File Offset: 0x0023D770
		[DebuggerNonUserCode]
		public RecentPlayerOptions(RecentPlayerOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x0023F5C0 File Offset: 0x0023D7C0
		[DebuggerNonUserCode]
		public RecentPlayerOptions Clone()
		{
			return new RecentPlayerOptions(this);
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600949B RID: 38043 RVA: 0x0023F5D8 File Offset: 0x0023D7D8
		// (set) Token: 0x0600949C RID: 38044 RVA: 0x0023F609 File Offset: 0x0023D809
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
					accountIdDefaultValue = RecentPlayerOptions.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x0023F624 File Offset: 0x0023D824
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x0023F641 File Offset: 0x0023D841
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x0023F654 File Offset: 0x0023D854
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x0023F66C File Offset: 0x0023D86C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayerOptions);
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x0023F68C File Offset: 0x0023D88C
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayerOptions other)
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
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x0023F700 File Offset: 0x0023D900
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x0023F760 File Offset: 0x0023D960
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x0023F778 File Offset: 0x0023D978
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x0023F784 File Offset: 0x0023D984
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			this.attribute_.WriteTo(ref output, RecentPlayerOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x0023F7E4 File Offset: 0x0023D9E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			num += this.attribute_.CalculateSize(RecentPlayerOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x0023F848 File Offset: 0x0023DA48
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayerOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x0023F8A3 File Offset: 0x0023DAA3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x0023F8B0 File Offset: 0x0023DAB0
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
					if (num3 != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, RecentPlayerOptions._repeated_attribute_codec);
					}
				}
				else
				{
					this.AccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040042F4 RID: 17140
		private static readonly MessageParser<RecentPlayerOptions> _parser = new MessageParser<RecentPlayerOptions>(() => new RecentPlayerOptions());

		// Token: 0x040042F5 RID: 17141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042F6 RID: 17142
		private int _hasBits0;

		// Token: 0x040042F7 RID: 17143
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040042F8 RID: 17144
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x040042F9 RID: 17145
		private ulong accountId_;

		// Token: 0x040042FA RID: 17146
		public const int AttributeFieldNumber = 5;

		// Token: 0x040042FB RID: 17147
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040042FC RID: 17148
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
