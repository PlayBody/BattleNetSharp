using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Config
{
	// Token: 0x020003D6 RID: 982
	public sealed class RPCMeterConfig : IMessage<RPCMeterConfig>, IMessage, IEquatable<RPCMeterConfig>, IDeepCloneable<RPCMeterConfig>, IBufferMessage
	{
		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x0017C3D4 File Offset: 0x0017A5D4
		[DebuggerNonUserCode]
		public static MessageParser<RPCMeterConfig> Parser
		{
			get
			{
				return RPCMeterConfig._parser;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06006231 RID: 25137 RVA: 0x0017C3EC File Offset: 0x0017A5EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x0017C410 File Offset: 0x0017A610
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RPCMeterConfig.Descriptor;
			}
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x0017C427 File Offset: 0x0017A627
		[DebuggerNonUserCode]
		public RPCMeterConfig()
		{
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x0017C43C File Offset: 0x0017A63C
		[DebuggerNonUserCode]
		public RPCMeterConfig(RPCMeterConfig other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.method_ = other.method_.Clone();
			this.incomePerSecond_ = other.incomePerSecond_;
			this.initialBalance_ = other.initialBalance_;
			this.capBalance_ = other.capBalance_;
			this.startupPeriod_ = other.startupPeriod_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x0017C4B0 File Offset: 0x0017A6B0
		[DebuggerNonUserCode]
		public RPCMeterConfig Clone()
		{
			return new RPCMeterConfig(this);
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x0017C4C8 File Offset: 0x0017A6C8
		[DebuggerNonUserCode]
		public RepeatedField<RPCMethodConfig> Method
		{
			get
			{
				return this.method_;
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x0017C4E0 File Offset: 0x0017A6E0
		// (set) Token: 0x06006238 RID: 25144 RVA: 0x0017C511 File Offset: 0x0017A711
		[DebuggerNonUserCode]
		public uint IncomePerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint incomePerSecondDefaultValue;
				if (flag)
				{
					incomePerSecondDefaultValue = this.incomePerSecond_;
				}
				else
				{
					incomePerSecondDefaultValue = RPCMeterConfig.IncomePerSecondDefaultValue;
				}
				return incomePerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.incomePerSecond_ = value;
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06006239 RID: 25145 RVA: 0x0017C52C File Offset: 0x0017A72C
		[DebuggerNonUserCode]
		public bool HasIncomePerSecond
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x0017C549 File Offset: 0x0017A749
		[DebuggerNonUserCode]
		public void ClearIncomePerSecond()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x0017C55C File Offset: 0x0017A75C
		// (set) Token: 0x0600623C RID: 25148 RVA: 0x0017C58D File Offset: 0x0017A78D
		[DebuggerNonUserCode]
		public uint InitialBalance
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint initialBalanceDefaultValue;
				if (flag)
				{
					initialBalanceDefaultValue = this.initialBalance_;
				}
				else
				{
					initialBalanceDefaultValue = RPCMeterConfig.InitialBalanceDefaultValue;
				}
				return initialBalanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.initialBalance_ = value;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x0017C5A8 File Offset: 0x0017A7A8
		[DebuggerNonUserCode]
		public bool HasInitialBalance
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x0017C5C5 File Offset: 0x0017A7C5
		[DebuggerNonUserCode]
		public void ClearInitialBalance()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x0017C5D8 File Offset: 0x0017A7D8
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x0017C609 File Offset: 0x0017A809
		[DebuggerNonUserCode]
		public uint CapBalance
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint capBalanceDefaultValue;
				if (flag)
				{
					capBalanceDefaultValue = this.capBalance_;
				}
				else
				{
					capBalanceDefaultValue = RPCMeterConfig.CapBalanceDefaultValue;
				}
				return capBalanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.capBalance_ = value;
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06006241 RID: 25153 RVA: 0x0017C624 File Offset: 0x0017A824
		[DebuggerNonUserCode]
		public bool HasCapBalance
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x0017C641 File Offset: 0x0017A841
		[DebuggerNonUserCode]
		public void ClearCapBalance()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x0017C654 File Offset: 0x0017A854
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x0017C685 File Offset: 0x0017A885
		[DebuggerNonUserCode]
		public float StartupPeriod
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float startupPeriodDefaultValue;
				if (flag)
				{
					startupPeriodDefaultValue = this.startupPeriod_;
				}
				else
				{
					startupPeriodDefaultValue = RPCMeterConfig.StartupPeriodDefaultValue;
				}
				return startupPeriodDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.startupPeriod_ = value;
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x0017C6A0 File Offset: 0x0017A8A0
		[DebuggerNonUserCode]
		public bool HasStartupPeriod
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x0017C6BD File Offset: 0x0017A8BD
		[DebuggerNonUserCode]
		public void ClearStartupPeriod()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x0017C6D0 File Offset: 0x0017A8D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RPCMeterConfig);
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x0017C6F0 File Offset: 0x0017A8F0
		[DebuggerNonUserCode]
		public bool Equals(RPCMeterConfig other)
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
					bool flag4 = !this.method_.Equals(other.method_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IncomePerSecond != other.IncomePerSecond;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InitialBalance != other.InitialBalance;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CapBalance != other.CapBalance;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartupPeriod, other.StartupPeriod);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x0017C7C8 File Offset: 0x0017A9C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.method_.GetHashCode();
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				num ^= this.IncomePerSecond.GetHashCode();
			}
			bool hasInitialBalance = this.HasInitialBalance;
			if (hasInitialBalance)
			{
				num ^= this.InitialBalance.GetHashCode();
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				num ^= this.CapBalance.GetHashCode();
			}
			bool hasStartupPeriod = this.HasStartupPeriod;
			if (hasStartupPeriod)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartupPeriod);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x0017C880 File Offset: 0x0017AA80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x0017C898 File Offset: 0x0017AA98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x0017C8A4 File Offset: 0x0017AAA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.method_.WriteTo(ref output, RPCMeterConfig._repeated_method_codec);
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.IncomePerSecond);
			}
			bool hasInitialBalance = this.HasInitialBalance;
			if (hasInitialBalance)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.InitialBalance);
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CapBalance);
			}
			bool hasStartupPeriod = this.HasStartupPeriod;
			if (hasStartupPeriod)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.StartupPeriod);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x0017C96C File Offset: 0x0017AB6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.method_.CalculateSize(RPCMeterConfig._repeated_method_codec);
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IncomePerSecond);
			}
			bool hasInitialBalance = this.HasInitialBalance;
			if (hasInitialBalance)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InitialBalance);
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapBalance);
			}
			bool hasStartupPeriod = this.HasStartupPeriod;
			if (hasStartupPeriod)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x0017CA1C File Offset: 0x0017AC1C
		[DebuggerNonUserCode]
		public void MergeFrom(RPCMeterConfig other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.method_.Add(other.method_);
				bool hasIncomePerSecond = other.HasIncomePerSecond;
				if (hasIncomePerSecond)
				{
					this.IncomePerSecond = other.IncomePerSecond;
				}
				bool hasInitialBalance = other.HasInitialBalance;
				if (hasInitialBalance)
				{
					this.InitialBalance = other.InitialBalance;
				}
				bool hasCapBalance = other.HasCapBalance;
				if (hasCapBalance)
				{
					this.CapBalance = other.CapBalance;
				}
				bool hasStartupPeriod = other.HasStartupPeriod;
				if (hasStartupPeriod)
				{
					this.StartupPeriod = other.StartupPeriod;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x0017CAC7 File Offset: 0x0017ACC7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0017CAD4 File Offset: 0x0017ACD4
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
						this.IncomePerSecond = input.ReadUInt32();
					}
					else
					{
						this.method_.AddEntriesFrom(ref input, RPCMeterConfig._repeated_method_codec);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 45U)
						{
							goto IL_0033;
						}
						this.StartupPeriod = input.ReadFloat();
					}
					else
					{
						this.CapBalance = input.ReadUInt32();
					}
				}
				else
				{
					this.InitialBalance = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CE1 RID: 11489
		private static readonly MessageParser<RPCMeterConfig> _parser = new MessageParser<RPCMeterConfig>(() => new RPCMeterConfig());

		// Token: 0x04002CE2 RID: 11490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE3 RID: 11491
		private int _hasBits0;

		// Token: 0x04002CE4 RID: 11492
		public const int MethodFieldNumber = 1;

		// Token: 0x04002CE5 RID: 11493
		private static readonly FieldCodec<RPCMethodConfig> _repeated_method_codec = FieldCodec.ForMessage<RPCMethodConfig>(10U, RPCMethodConfig.Parser);

		// Token: 0x04002CE6 RID: 11494
		private readonly RepeatedField<RPCMethodConfig> method_ = new RepeatedField<RPCMethodConfig>();

		// Token: 0x04002CE7 RID: 11495
		public const int IncomePerSecondFieldNumber = 2;

		// Token: 0x04002CE8 RID: 11496
		private static readonly uint IncomePerSecondDefaultValue = 1U;

		// Token: 0x04002CE9 RID: 11497
		private uint incomePerSecond_;

		// Token: 0x04002CEA RID: 11498
		public const int InitialBalanceFieldNumber = 3;

		// Token: 0x04002CEB RID: 11499
		private static readonly uint InitialBalanceDefaultValue = 0U;

		// Token: 0x04002CEC RID: 11500
		private uint initialBalance_;

		// Token: 0x04002CED RID: 11501
		public const int CapBalanceFieldNumber = 4;

		// Token: 0x04002CEE RID: 11502
		private static readonly uint CapBalanceDefaultValue = 0U;

		// Token: 0x04002CEF RID: 11503
		private uint capBalance_;

		// Token: 0x04002CF0 RID: 11504
		public const int StartupPeriodFieldNumber = 5;

		// Token: 0x04002CF1 RID: 11505
		private static readonly float StartupPeriodDefaultValue = 0f;

		// Token: 0x04002CF2 RID: 11506
		private float startupPeriod_;
	}
}
