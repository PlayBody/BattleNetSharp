using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Config
{
	// Token: 0x020003D5 RID: 981
	public sealed class RPCMethodConfig : IMessage<RPCMethodConfig>, IMessage, IEquatable<RPCMethodConfig>, IDeepCloneable<RPCMethodConfig>, IBufferMessage
	{
		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x0017AE4C File Offset: 0x0017904C
		[DebuggerNonUserCode]
		public static MessageParser<RPCMethodConfig> Parser
		{
			get
			{
				return RPCMethodConfig._parser;
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x060061E4 RID: 25060 RVA: 0x0017AE64 File Offset: 0x00179064
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x0017AE88 File Offset: 0x00179088
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RPCMethodConfig.Descriptor;
			}
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x0017AE9F File Offset: 0x0017909F
		[DebuggerNonUserCode]
		public RPCMethodConfig()
		{
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x0017AEAC File Offset: 0x001790AC
		[DebuggerNonUserCode]
		public RPCMethodConfig(RPCMethodConfig other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serviceName_ = other.serviceName_;
			this.methodName_ = other.methodName_;
			this.fixedCallCost_ = other.fixedCallCost_;
			this.fixedPacketSize_ = other.fixedPacketSize_;
			this.variableMultiplier_ = other.variableMultiplier_;
			this.multiplier_ = other.multiplier_;
			this.rateLimitCount_ = other.rateLimitCount_;
			this.rateLimitSeconds_ = other.rateLimitSeconds_;
			this.maxPacketSize_ = other.maxPacketSize_;
			this.maxEncodedSize_ = other.maxEncodedSize_;
			this.timeout_ = other.timeout_;
			this.capBalance_ = other.capBalance_;
			this.incomePerSecond_ = other.incomePerSecond_;
			this.serviceHash_ = other.serviceHash_;
			this.methodId_ = other.methodId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0017AF94 File Offset: 0x00179194
		[DebuggerNonUserCode]
		public RPCMethodConfig Clone()
		{
			return new RPCMethodConfig(this);
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x0017AFAC File Offset: 0x001791AC
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x0017AFCD File Offset: 0x001791CD
		[Obsolete]
		[DebuggerNonUserCode]
		public string ServiceName
		{
			get
			{
				return this.serviceName_ ?? RPCMethodConfig.ServiceNameDefaultValue;
			}
			set
			{
				this.serviceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x0017AFE4 File Offset: 0x001791E4
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasServiceName
		{
			get
			{
				return this.serviceName_ != null;
			}
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x0017AFFF File Offset: 0x001791FF
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearServiceName()
		{
			this.serviceName_ = null;
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x0017B00C File Offset: 0x0017920C
		// (set) Token: 0x060061EE RID: 25070 RVA: 0x0017B02D File Offset: 0x0017922D
		[Obsolete]
		[DebuggerNonUserCode]
		public string MethodName
		{
			get
			{
				return this.methodName_ ?? RPCMethodConfig.MethodNameDefaultValue;
			}
			set
			{
				this.methodName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x060061EF RID: 25071 RVA: 0x0017B044 File Offset: 0x00179244
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasMethodName
		{
			get
			{
				return this.methodName_ != null;
			}
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x0017B05F File Offset: 0x0017925F
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearMethodName()
		{
			this.methodName_ = null;
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x060061F1 RID: 25073 RVA: 0x0017B06C File Offset: 0x0017926C
		// (set) Token: 0x060061F2 RID: 25074 RVA: 0x0017B09D File Offset: 0x0017929D
		[DebuggerNonUserCode]
		public uint FixedCallCost
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint fixedCallCostDefaultValue;
				if (flag)
				{
					fixedCallCostDefaultValue = this.fixedCallCost_;
				}
				else
				{
					fixedCallCostDefaultValue = RPCMethodConfig.FixedCallCostDefaultValue;
				}
				return fixedCallCostDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fixedCallCost_ = value;
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x060061F3 RID: 25075 RVA: 0x0017B0B8 File Offset: 0x001792B8
		[DebuggerNonUserCode]
		public bool HasFixedCallCost
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x0017B0D5 File Offset: 0x001792D5
		[DebuggerNonUserCode]
		public void ClearFixedCallCost()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x060061F5 RID: 25077 RVA: 0x0017B0E8 File Offset: 0x001792E8
		// (set) Token: 0x060061F6 RID: 25078 RVA: 0x0017B119 File Offset: 0x00179319
		[DebuggerNonUserCode]
		public uint FixedPacketSize
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint fixedPacketSizeDefaultValue;
				if (flag)
				{
					fixedPacketSizeDefaultValue = this.fixedPacketSize_;
				}
				else
				{
					fixedPacketSizeDefaultValue = RPCMethodConfig.FixedPacketSizeDefaultValue;
				}
				return fixedPacketSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fixedPacketSize_ = value;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x0017B134 File Offset: 0x00179334
		[DebuggerNonUserCode]
		public bool HasFixedPacketSize
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x0017B151 File Offset: 0x00179351
		[DebuggerNonUserCode]
		public void ClearFixedPacketSize()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x0017B164 File Offset: 0x00179364
		// (set) Token: 0x060061FA RID: 25082 RVA: 0x0017B195 File Offset: 0x00179395
		[DebuggerNonUserCode]
		public float VariableMultiplier
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float variableMultiplierDefaultValue;
				if (flag)
				{
					variableMultiplierDefaultValue = this.variableMultiplier_;
				}
				else
				{
					variableMultiplierDefaultValue = RPCMethodConfig.VariableMultiplierDefaultValue;
				}
				return variableMultiplierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.variableMultiplier_ = value;
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x060061FB RID: 25083 RVA: 0x0017B1B0 File Offset: 0x001793B0
		[DebuggerNonUserCode]
		public bool HasVariableMultiplier
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x0017B1CD File Offset: 0x001793CD
		[DebuggerNonUserCode]
		public void ClearVariableMultiplier()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x0017B1E0 File Offset: 0x001793E0
		// (set) Token: 0x060061FE RID: 25086 RVA: 0x0017B211 File Offset: 0x00179411
		[DebuggerNonUserCode]
		public float Multiplier
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float multiplierDefaultValue;
				if (flag)
				{
					multiplierDefaultValue = this.multiplier_;
				}
				else
				{
					multiplierDefaultValue = RPCMethodConfig.MultiplierDefaultValue;
				}
				return multiplierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.multiplier_ = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x0017B22C File Offset: 0x0017942C
		[DebuggerNonUserCode]
		public bool HasMultiplier
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x0017B249 File Offset: 0x00179449
		[DebuggerNonUserCode]
		public void ClearMultiplier()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006201 RID: 25089 RVA: 0x0017B25C File Offset: 0x0017945C
		// (set) Token: 0x06006202 RID: 25090 RVA: 0x0017B28E File Offset: 0x0017948E
		[DebuggerNonUserCode]
		public uint RateLimitCount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint rateLimitCountDefaultValue;
				if (flag)
				{
					rateLimitCountDefaultValue = this.rateLimitCount_;
				}
				else
				{
					rateLimitCountDefaultValue = RPCMethodConfig.RateLimitCountDefaultValue;
				}
				return rateLimitCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.rateLimitCount_ = value;
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006203 RID: 25091 RVA: 0x0017B2A8 File Offset: 0x001794A8
		[DebuggerNonUserCode]
		public bool HasRateLimitCount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x0017B2C6 File Offset: 0x001794C6
		[DebuggerNonUserCode]
		public void ClearRateLimitCount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x0017B2D8 File Offset: 0x001794D8
		// (set) Token: 0x06006206 RID: 25094 RVA: 0x0017B30A File Offset: 0x0017950A
		[DebuggerNonUserCode]
		public uint RateLimitSeconds
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint rateLimitSecondsDefaultValue;
				if (flag)
				{
					rateLimitSecondsDefaultValue = this.rateLimitSeconds_;
				}
				else
				{
					rateLimitSecondsDefaultValue = RPCMethodConfig.RateLimitSecondsDefaultValue;
				}
				return rateLimitSecondsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.rateLimitSeconds_ = value;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x0017B324 File Offset: 0x00179524
		[DebuggerNonUserCode]
		public bool HasRateLimitSeconds
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x0017B342 File Offset: 0x00179542
		[DebuggerNonUserCode]
		public void ClearRateLimitSeconds()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006209 RID: 25097 RVA: 0x0017B354 File Offset: 0x00179554
		// (set) Token: 0x0600620A RID: 25098 RVA: 0x0017B386 File Offset: 0x00179586
		[DebuggerNonUserCode]
		public uint MaxPacketSize
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint maxPacketSizeDefaultValue;
				if (flag)
				{
					maxPacketSizeDefaultValue = this.maxPacketSize_;
				}
				else
				{
					maxPacketSizeDefaultValue = RPCMethodConfig.MaxPacketSizeDefaultValue;
				}
				return maxPacketSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.maxPacketSize_ = value;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x0017B3A0 File Offset: 0x001795A0
		[DebuggerNonUserCode]
		public bool HasMaxPacketSize
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x0017B3BE File Offset: 0x001795BE
		[DebuggerNonUserCode]
		public void ClearMaxPacketSize()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x0017B3D0 File Offset: 0x001795D0
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x0017B405 File Offset: 0x00179605
		[DebuggerNonUserCode]
		public uint MaxEncodedSize
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint maxEncodedSizeDefaultValue;
				if (flag)
				{
					maxEncodedSizeDefaultValue = this.maxEncodedSize_;
				}
				else
				{
					maxEncodedSizeDefaultValue = RPCMethodConfig.MaxEncodedSizeDefaultValue;
				}
				return maxEncodedSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.maxEncodedSize_ = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x0017B424 File Offset: 0x00179624
		[DebuggerNonUserCode]
		public bool HasMaxEncodedSize
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x0017B445 File Offset: 0x00179645
		[DebuggerNonUserCode]
		public void ClearMaxEncodedSize()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x0017B45C File Offset: 0x0017965C
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x0017B491 File Offset: 0x00179691
		[DebuggerNonUserCode]
		public float Timeout
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				float timeoutDefaultValue;
				if (flag)
				{
					timeoutDefaultValue = this.timeout_;
				}
				else
				{
					timeoutDefaultValue = RPCMethodConfig.TimeoutDefaultValue;
				}
				return timeoutDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.timeout_ = value;
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x0017B4B0 File Offset: 0x001796B0
		[DebuggerNonUserCode]
		public bool HasTimeout
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0017B4D1 File Offset: 0x001796D1
		[DebuggerNonUserCode]
		public void ClearTimeout()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x0017B4E8 File Offset: 0x001796E8
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x0017B51D File Offset: 0x0017971D
		[DebuggerNonUserCode]
		public uint CapBalance
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint capBalanceDefaultValue;
				if (flag)
				{
					capBalanceDefaultValue = this.capBalance_;
				}
				else
				{
					capBalanceDefaultValue = RPCMethodConfig.CapBalanceDefaultValue;
				}
				return capBalanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.capBalance_ = value;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x0017B53C File Offset: 0x0017973C
		[DebuggerNonUserCode]
		public bool HasCapBalance
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x0017B55D File Offset: 0x0017975D
		[DebuggerNonUserCode]
		public void ClearCapBalance()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x0017B574 File Offset: 0x00179774
		// (set) Token: 0x0600621A RID: 25114 RVA: 0x0017B5A9 File Offset: 0x001797A9
		[DebuggerNonUserCode]
		public float IncomePerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				float incomePerSecondDefaultValue;
				if (flag)
				{
					incomePerSecondDefaultValue = this.incomePerSecond_;
				}
				else
				{
					incomePerSecondDefaultValue = RPCMethodConfig.IncomePerSecondDefaultValue;
				}
				return incomePerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.incomePerSecond_ = value;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600621B RID: 25115 RVA: 0x0017B5C8 File Offset: 0x001797C8
		[DebuggerNonUserCode]
		public bool HasIncomePerSecond
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x0017B5E9 File Offset: 0x001797E9
		[DebuggerNonUserCode]
		public void ClearIncomePerSecond()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600621D RID: 25117 RVA: 0x0017B600 File Offset: 0x00179800
		// (set) Token: 0x0600621E RID: 25118 RVA: 0x0017B635 File Offset: 0x00179835
		[DebuggerNonUserCode]
		public uint ServiceHash
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint serviceHashDefaultValue;
				if (flag)
				{
					serviceHashDefaultValue = this.serviceHash_;
				}
				else
				{
					serviceHashDefaultValue = RPCMethodConfig.ServiceHashDefaultValue;
				}
				return serviceHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.serviceHash_ = value;
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600621F RID: 25119 RVA: 0x0017B654 File Offset: 0x00179854
		[DebuggerNonUserCode]
		public bool HasServiceHash
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x0017B675 File Offset: 0x00179875
		[DebuggerNonUserCode]
		public void ClearServiceHash()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06006221 RID: 25121 RVA: 0x0017B68C File Offset: 0x0017988C
		// (set) Token: 0x06006222 RID: 25122 RVA: 0x0017B6C1 File Offset: 0x001798C1
		[DebuggerNonUserCode]
		public uint MethodId
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				uint methodIdDefaultValue;
				if (flag)
				{
					methodIdDefaultValue = this.methodId_;
				}
				else
				{
					methodIdDefaultValue = RPCMethodConfig.MethodIdDefaultValue;
				}
				return methodIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.methodId_ = value;
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x0017B6E0 File Offset: 0x001798E0
		[DebuggerNonUserCode]
		public bool HasMethodId
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x0017B701 File Offset: 0x00179901
		[DebuggerNonUserCode]
		public void ClearMethodId()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x0017B718 File Offset: 0x00179918
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RPCMethodConfig);
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x0017B738 File Offset: 0x00179938
		[DebuggerNonUserCode]
		public bool Equals(RPCMethodConfig other)
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
					bool flag4 = this.ServiceName != other.ServiceName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MethodName != other.MethodName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FixedCallCost != other.FixedCallCost;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FixedPacketSize != other.FixedPacketSize;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VariableMultiplier, other.VariableMultiplier);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Multiplier, other.Multiplier);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.RateLimitCount != other.RateLimitCount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.RateLimitSeconds != other.RateLimitSeconds;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MaxPacketSize != other.MaxPacketSize;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MaxEncodedSize != other.MaxEncodedSize;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Timeout, other.Timeout);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.CapBalance != other.CapBalance;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.IncomePerSecond, other.IncomePerSecond);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.ServiceHash != other.ServiceHash;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.MethodId != other.MethodId;
																			flag2 = !flag18 && object.Equals(this._unknownFields, other._unknownFields);
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
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x0017B950 File Offset: 0x00179B50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasServiceName = this.HasServiceName;
			if (hasServiceName)
			{
				num ^= this.ServiceName.GetHashCode();
			}
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				num ^= this.MethodName.GetHashCode();
			}
			bool hasFixedCallCost = this.HasFixedCallCost;
			if (hasFixedCallCost)
			{
				num ^= this.FixedCallCost.GetHashCode();
			}
			bool hasFixedPacketSize = this.HasFixedPacketSize;
			if (hasFixedPacketSize)
			{
				num ^= this.FixedPacketSize.GetHashCode();
			}
			bool hasVariableMultiplier = this.HasVariableMultiplier;
			if (hasVariableMultiplier)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VariableMultiplier);
			}
			bool hasMultiplier = this.HasMultiplier;
			if (hasMultiplier)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Multiplier);
			}
			bool hasRateLimitCount = this.HasRateLimitCount;
			if (hasRateLimitCount)
			{
				num ^= this.RateLimitCount.GetHashCode();
			}
			bool hasRateLimitSeconds = this.HasRateLimitSeconds;
			if (hasRateLimitSeconds)
			{
				num ^= this.RateLimitSeconds.GetHashCode();
			}
			bool hasMaxPacketSize = this.HasMaxPacketSize;
			if (hasMaxPacketSize)
			{
				num ^= this.MaxPacketSize.GetHashCode();
			}
			bool hasMaxEncodedSize = this.HasMaxEncodedSize;
			if (hasMaxEncodedSize)
			{
				num ^= this.MaxEncodedSize.GetHashCode();
			}
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Timeout);
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				num ^= this.CapBalance.GetHashCode();
			}
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.IncomePerSecond);
			}
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				num ^= this.ServiceHash.GetHashCode();
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				num ^= this.MethodId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x0017BB40 File Offset: 0x00179D40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x0017BB58 File Offset: 0x00179D58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x0017BB64 File Offset: 0x00179D64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServiceName = this.HasServiceName;
			if (hasServiceName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ServiceName);
			}
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MethodName);
			}
			bool hasFixedCallCost = this.HasFixedCallCost;
			if (hasFixedCallCost)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FixedCallCost);
			}
			bool hasFixedPacketSize = this.HasFixedPacketSize;
			if (hasFixedPacketSize)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.FixedPacketSize);
			}
			bool hasVariableMultiplier = this.HasVariableMultiplier;
			if (hasVariableMultiplier)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.VariableMultiplier);
			}
			bool hasMultiplier = this.HasMultiplier;
			if (hasMultiplier)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Multiplier);
			}
			bool hasRateLimitCount = this.HasRateLimitCount;
			if (hasRateLimitCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RateLimitCount);
			}
			bool hasRateLimitSeconds = this.HasRateLimitSeconds;
			if (hasRateLimitSeconds)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.RateLimitSeconds);
			}
			bool hasMaxPacketSize = this.HasMaxPacketSize;
			if (hasMaxPacketSize)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MaxPacketSize);
			}
			bool hasMaxEncodedSize = this.HasMaxEncodedSize;
			if (hasMaxEncodedSize)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MaxEncodedSize);
			}
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.Timeout);
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CapBalance);
			}
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.IncomePerSecond);
			}
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ServiceHash);
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MethodId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x0017BDA4 File Offset: 0x00179FA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServiceName = this.HasServiceName;
			if (hasServiceName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServiceName);
			}
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MethodName);
			}
			bool hasFixedCallCost = this.HasFixedCallCost;
			if (hasFixedCallCost)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FixedCallCost);
			}
			bool hasFixedPacketSize = this.HasFixedPacketSize;
			if (hasFixedPacketSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FixedPacketSize);
			}
			bool hasVariableMultiplier = this.HasVariableMultiplier;
			if (hasVariableMultiplier)
			{
				num += 5;
			}
			bool hasMultiplier = this.HasMultiplier;
			if (hasMultiplier)
			{
				num += 5;
			}
			bool hasRateLimitCount = this.HasRateLimitCount;
			if (hasRateLimitCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RateLimitCount);
			}
			bool hasRateLimitSeconds = this.HasRateLimitSeconds;
			if (hasRateLimitSeconds)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RateLimitSeconds);
			}
			bool hasMaxPacketSize = this.HasMaxPacketSize;
			if (hasMaxPacketSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPacketSize);
			}
			bool hasMaxEncodedSize = this.HasMaxEncodedSize;
			if (hasMaxEncodedSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxEncodedSize);
			}
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num += 5;
			}
			bool hasCapBalance = this.HasCapBalance;
			if (hasCapBalance)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapBalance);
			}
			bool hasIncomePerSecond = this.HasIncomePerSecond;
			if (hasIncomePerSecond)
			{
				num += 5;
			}
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceHash);
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MethodId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x0017BF68 File Offset: 0x0017A168
		[DebuggerNonUserCode]
		public void MergeFrom(RPCMethodConfig other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasServiceName = other.HasServiceName;
				if (hasServiceName)
				{
					this.ServiceName = other.ServiceName;
				}
				bool hasMethodName = other.HasMethodName;
				if (hasMethodName)
				{
					this.MethodName = other.MethodName;
				}
				bool hasFixedCallCost = other.HasFixedCallCost;
				if (hasFixedCallCost)
				{
					this.FixedCallCost = other.FixedCallCost;
				}
				bool hasFixedPacketSize = other.HasFixedPacketSize;
				if (hasFixedPacketSize)
				{
					this.FixedPacketSize = other.FixedPacketSize;
				}
				bool hasVariableMultiplier = other.HasVariableMultiplier;
				if (hasVariableMultiplier)
				{
					this.VariableMultiplier = other.VariableMultiplier;
				}
				bool hasMultiplier = other.HasMultiplier;
				if (hasMultiplier)
				{
					this.Multiplier = other.Multiplier;
				}
				bool hasRateLimitCount = other.HasRateLimitCount;
				if (hasRateLimitCount)
				{
					this.RateLimitCount = other.RateLimitCount;
				}
				bool hasRateLimitSeconds = other.HasRateLimitSeconds;
				if (hasRateLimitSeconds)
				{
					this.RateLimitSeconds = other.RateLimitSeconds;
				}
				bool hasMaxPacketSize = other.HasMaxPacketSize;
				if (hasMaxPacketSize)
				{
					this.MaxPacketSize = other.MaxPacketSize;
				}
				bool hasMaxEncodedSize = other.HasMaxEncodedSize;
				if (hasMaxEncodedSize)
				{
					this.MaxEncodedSize = other.MaxEncodedSize;
				}
				bool hasTimeout = other.HasTimeout;
				if (hasTimeout)
				{
					this.Timeout = other.Timeout;
				}
				bool hasCapBalance = other.HasCapBalance;
				if (hasCapBalance)
				{
					this.CapBalance = other.CapBalance;
				}
				bool hasIncomePerSecond = other.HasIncomePerSecond;
				if (hasIncomePerSecond)
				{
					this.IncomePerSecond = other.IncomePerSecond;
				}
				bool hasServiceHash = other.HasServiceHash;
				if (hasServiceHash)
				{
					this.ServiceHash = other.ServiceHash;
				}
				bool hasMethodId = other.HasMethodId;
				if (hasMethodId)
				{
					this.MethodId = other.MethodId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x0017C12A File Offset: 0x0017A32A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x0017C138 File Offset: 0x0017A338
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 24U)
								{
									goto IL_00C2;
								}
								this.FixedCallCost = input.ReadUInt32();
							}
							else
							{
								this.MethodName = input.ReadString();
							}
						}
						else
						{
							this.ServiceName = input.ReadString();
						}
					}
					else if (num3 <= 45U)
					{
						if (num3 != 32U)
						{
							if (num3 != 45U)
							{
								goto IL_00C2;
							}
							this.VariableMultiplier = input.ReadFloat();
						}
						else
						{
							this.FixedPacketSize = input.ReadUInt32();
						}
					}
					else if (num3 != 53U)
					{
						if (num3 != 56U)
						{
							goto IL_00C2;
						}
						this.RateLimitCount = input.ReadUInt32();
					}
					else
					{
						this.Multiplier = input.ReadFloat();
					}
				}
				else if (num3 <= 93U)
				{
					if (num3 <= 72U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_00C2;
							}
							this.MaxPacketSize = input.ReadUInt32();
						}
						else
						{
							this.RateLimitSeconds = input.ReadUInt32();
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 93U)
						{
							goto IL_00C2;
						}
						this.Timeout = input.ReadFloat();
					}
					else
					{
						this.MaxEncodedSize = input.ReadUInt32();
					}
				}
				else if (num3 <= 109U)
				{
					if (num3 != 96U)
					{
						if (num3 != 109U)
						{
							goto IL_00C2;
						}
						this.IncomePerSecond = input.ReadFloat();
					}
					else
					{
						this.CapBalance = input.ReadUInt32();
					}
				}
				else if (num3 != 112U)
				{
					if (num3 != 120U)
					{
						goto IL_00C2;
					}
					this.MethodId = input.ReadUInt32();
				}
				else
				{
					this.ServiceHash = input.ReadUInt32();
				}
				continue;
				IL_00C2:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CB1 RID: 11441
		private static readonly MessageParser<RPCMethodConfig> _parser = new MessageParser<RPCMethodConfig>(() => new RPCMethodConfig());

		// Token: 0x04002CB2 RID: 11442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CB3 RID: 11443
		private int _hasBits0;

		// Token: 0x04002CB4 RID: 11444
		public const int ServiceNameFieldNumber = 1;

		// Token: 0x04002CB5 RID: 11445
		private static readonly string ServiceNameDefaultValue = "";

		// Token: 0x04002CB6 RID: 11446
		private string serviceName_;

		// Token: 0x04002CB7 RID: 11447
		public const int MethodNameFieldNumber = 2;

		// Token: 0x04002CB8 RID: 11448
		private static readonly string MethodNameDefaultValue = "";

		// Token: 0x04002CB9 RID: 11449
		private string methodName_;

		// Token: 0x04002CBA RID: 11450
		public const int FixedCallCostFieldNumber = 3;

		// Token: 0x04002CBB RID: 11451
		private static readonly uint FixedCallCostDefaultValue = 1U;

		// Token: 0x04002CBC RID: 11452
		private uint fixedCallCost_;

		// Token: 0x04002CBD RID: 11453
		public const int FixedPacketSizeFieldNumber = 4;

		// Token: 0x04002CBE RID: 11454
		private static readonly uint FixedPacketSizeDefaultValue = 0U;

		// Token: 0x04002CBF RID: 11455
		private uint fixedPacketSize_;

		// Token: 0x04002CC0 RID: 11456
		public const int VariableMultiplierFieldNumber = 5;

		// Token: 0x04002CC1 RID: 11457
		private static readonly float VariableMultiplierDefaultValue = 0f;

		// Token: 0x04002CC2 RID: 11458
		private float variableMultiplier_;

		// Token: 0x04002CC3 RID: 11459
		public const int MultiplierFieldNumber = 6;

		// Token: 0x04002CC4 RID: 11460
		private static readonly float MultiplierDefaultValue = 1f;

		// Token: 0x04002CC5 RID: 11461
		private float multiplier_;

		// Token: 0x04002CC6 RID: 11462
		public const int RateLimitCountFieldNumber = 7;

		// Token: 0x04002CC7 RID: 11463
		private static readonly uint RateLimitCountDefaultValue = 0U;

		// Token: 0x04002CC8 RID: 11464
		private uint rateLimitCount_;

		// Token: 0x04002CC9 RID: 11465
		public const int RateLimitSecondsFieldNumber = 8;

		// Token: 0x04002CCA RID: 11466
		private static readonly uint RateLimitSecondsDefaultValue = 0U;

		// Token: 0x04002CCB RID: 11467
		private uint rateLimitSeconds_;

		// Token: 0x04002CCC RID: 11468
		public const int MaxPacketSizeFieldNumber = 9;

		// Token: 0x04002CCD RID: 11469
		private static readonly uint MaxPacketSizeDefaultValue = 0U;

		// Token: 0x04002CCE RID: 11470
		private uint maxPacketSize_;

		// Token: 0x04002CCF RID: 11471
		public const int MaxEncodedSizeFieldNumber = 10;

		// Token: 0x04002CD0 RID: 11472
		private static readonly uint MaxEncodedSizeDefaultValue = 0U;

		// Token: 0x04002CD1 RID: 11473
		private uint maxEncodedSize_;

		// Token: 0x04002CD2 RID: 11474
		public const int TimeoutFieldNumber = 11;

		// Token: 0x04002CD3 RID: 11475
		private static readonly float TimeoutDefaultValue = 0f;

		// Token: 0x04002CD4 RID: 11476
		private float timeout_;

		// Token: 0x04002CD5 RID: 11477
		public const int CapBalanceFieldNumber = 12;

		// Token: 0x04002CD6 RID: 11478
		private static readonly uint CapBalanceDefaultValue = 0U;

		// Token: 0x04002CD7 RID: 11479
		private uint capBalance_;

		// Token: 0x04002CD8 RID: 11480
		public const int IncomePerSecondFieldNumber = 13;

		// Token: 0x04002CD9 RID: 11481
		private static readonly float IncomePerSecondDefaultValue = 0f;

		// Token: 0x04002CDA RID: 11482
		private float incomePerSecond_;

		// Token: 0x04002CDB RID: 11483
		public const int ServiceHashFieldNumber = 14;

		// Token: 0x04002CDC RID: 11484
		private static readonly uint ServiceHashDefaultValue = 0U;

		// Token: 0x04002CDD RID: 11485
		private uint serviceHash_;

		// Token: 0x04002CDE RID: 11486
		public const int MethodIdFieldNumber = 15;

		// Token: 0x04002CDF RID: 11487
		private static readonly uint MethodIdDefaultValue = 0U;

		// Token: 0x04002CE0 RID: 11488
		private uint methodId_;
	}
}
