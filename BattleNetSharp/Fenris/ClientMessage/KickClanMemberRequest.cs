using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026D RID: 621
	public sealed class KickClanMemberRequest : IMessage<KickClanMemberRequest>, IMessage, IEquatable<KickClanMemberRequest>, IDeepCloneable<KickClanMemberRequest>, IBufferMessage
	{
		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x00102A1C File Offset: 0x00100C1C
		[DebuggerNonUserCode]
		public static MessageParser<KickClanMemberRequest> Parser
		{
			get
			{
				return KickClanMemberRequest._parser;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x00102A34 File Offset: 0x00100C34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[93];
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x00102A58 File Offset: 0x00100C58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickClanMemberRequest.Descriptor;
			}
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00102A6F File Offset: 0x00100C6F
		[DebuggerNonUserCode]
		public KickClanMemberRequest()
		{
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00102A7C File Offset: 0x00100C7C
		[DebuggerNonUserCode]
		public KickClanMemberRequest(KickClanMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this.ban_ = other.ban_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x00102AD4 File Offset: 0x00100CD4
		[DebuggerNonUserCode]
		public KickClanMemberRequest Clone()
		{
			return new KickClanMemberRequest(this);
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x00102AEC File Offset: 0x00100CEC
		// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00102B0D File Offset: 0x00100D0D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? KickClanMemberRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x00102B24 File Offset: 0x00100D24
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00102B3F File Offset: 0x00100D3F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x00102B4C File Offset: 0x00100D4C
		// (set) Token: 0x060042AC RID: 17068 RVA: 0x00102B7D File Offset: 0x00100D7D
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = KickClanMemberRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x00102B98 File Offset: 0x00100D98
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00102BB5 File Offset: 0x00100DB5
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x00102BC8 File Offset: 0x00100DC8
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x00102BF9 File Offset: 0x00100DF9
		[DebuggerNonUserCode]
		public bool Ban
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool banDefaultValue;
				if (flag)
				{
					banDefaultValue = this.ban_;
				}
				else
				{
					banDefaultValue = KickClanMemberRequest.BanDefaultValue;
				}
				return banDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.ban_ = value;
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x00102C14 File Offset: 0x00100E14
		[DebuggerNonUserCode]
		public bool HasBan
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00102C31 File Offset: 0x00100E31
		[DebuggerNonUserCode]
		public void ClearBan()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x00102C44 File Offset: 0x00100E44
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickClanMemberRequest);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x00102C64 File Offset: 0x00100E64
		[DebuggerNonUserCode]
		public bool Equals(KickClanMemberRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetGameAccountId != other.TargetGameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Ban != other.Ban;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00102CF0 File Offset: 0x00100EF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool hasBan = this.HasBan;
			if (hasBan)
			{
				num ^= this.Ban.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x00102D78 File Offset: 0x00100F78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x00102D90 File Offset: 0x00100F90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00102D9C File Offset: 0x00100F9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool hasBan = this.HasBan;
			if (hasBan)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Ban);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x00102E2C File Offset: 0x0010102C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool hasBan = this.HasBan;
			if (hasBan)
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

		// Token: 0x060042BA RID: 17082 RVA: 0x00102EAC File Offset: 0x001010AC
		[DebuggerNonUserCode]
		public void MergeFrom(KickClanMemberRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				bool hasBan = other.HasBan;
				if (hasBan)
				{
					this.Ban = other.Ban;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00102F27 File Offset: 0x00101127
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00102F34 File Offset: 0x00101134
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Ban = input.ReadBool();
						}
					}
					else
					{
						this.TargetGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E20 RID: 7712
		private static readonly MessageParser<KickClanMemberRequest> _parser = new MessageParser<KickClanMemberRequest>(() => new KickClanMemberRequest());

		// Token: 0x04001E21 RID: 7713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E22 RID: 7714
		private int _hasBits0;

		// Token: 0x04001E23 RID: 7715
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E24 RID: 7716
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E25 RID: 7717
		private string clanId_;

		// Token: 0x04001E26 RID: 7718
		public const int TargetGameAccountIdFieldNumber = 2;

		// Token: 0x04001E27 RID: 7719
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001E28 RID: 7720
		private uint targetGameAccountId_;

		// Token: 0x04001E29 RID: 7721
		public const int BanFieldNumber = 3;

		// Token: 0x04001E2A RID: 7722
		private static readonly bool BanDefaultValue = false;

		// Token: 0x04001E2B RID: 7723
		private bool ban_;
	}
}
