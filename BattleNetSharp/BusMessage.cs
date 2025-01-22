using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

// Token: 0x0200000E RID: 14
public sealed class BusMessage : IMessage<BusMessage>, IMessage, IEquatable<BusMessage>, IDeepCloneable<BusMessage>, IBufferMessage
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00003228 File Offset: 0x00001428
	[DebuggerNonUserCode]
	public static MessageParser<BusMessage> Parser
	{
		get
		{
			return BusMessage._parser;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000045 RID: 69 RVA: 0x00003240 File Offset: 0x00001440
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		get
		{
			return BusMessageReflection.Descriptor.MessageTypes[0];
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000046 RID: 70 RVA: 0x00003264 File Offset: 0x00001464
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor
	{
		get
		{
			return BusMessage.Descriptor;
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000327B File Offset: 0x0000147B
	[DebuggerNonUserCode]
	public BusMessage()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003290 File Offset: 0x00001490
	[DebuggerNonUserCode]
	public BusMessage(BusMessage other)
		: this()
	{
		this._hasBits0 = other._hasBits0;
		this.uniqueid_ = other.uniqueid_;
		this.sourceSystem_ = other.sourceSystem_;
		this.sourceModule_ = other.sourceModule_;
		this.domain_ = other.domain_;
		this.joined_ = other.joined_;
		this.targetSystem_ = other.targetSystem_;
		this.targetModule_ = other.targetModule_;
		this.sourceSession_ = other.sourceSession_;
		this.sourceUsername_ = other.sourceUsername_;
		this.referenceUniqueid_ = other.referenceUniqueid_;
		this.sourcePid_ = other.sourcePid_;
		this.targetSession_ = other.targetSession_;
		this.targetUsername_ = other.targetUsername_;
		this.busPeer_ = other.busPeer_.Clone();
		this.generic_ = ((other.generic_ != null) ? other.generic_.Clone() : null);
		this.status_ = ((other.status_ != null) ? other.status_.Clone() : null);
		this.encryptedBusMessage_ = ((other.encryptedBusMessage_ != null) ? other.encryptedBusMessage_.Clone() : null);
		this.encryptionsetup_ = ((other.encryptionsetup_ != null) ? other.encryptionsetup_.Clone() : null);
		this.protocolVersion_ = other.protocolVersion_;
		this.sourceIsElevated_ = other.sourceIsElevated_;
		this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000033F8 File Offset: 0x000015F8
	[DebuggerNonUserCode]
	public BusMessage Clone()
	{
		return new BusMessage(this);
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00003410 File Offset: 0x00001610
	// (set) Token: 0x0600004B RID: 75 RVA: 0x00003431 File Offset: 0x00001631
	[DebuggerNonUserCode]
	public string Uniqueid
	{
		get
		{
			return this.uniqueid_ ?? BusMessage.UniqueidDefaultValue;
		}
		set
		{
			this.uniqueid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600004C RID: 76 RVA: 0x00003448 File Offset: 0x00001648
	[DebuggerNonUserCode]
	public bool HasUniqueid
	{
		get
		{
			return this.uniqueid_ != null;
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003463 File Offset: 0x00001663
	[DebuggerNonUserCode]
	public void ClearUniqueid()
	{
		this.uniqueid_ = null;
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00003470 File Offset: 0x00001670
	// (set) Token: 0x0600004F RID: 79 RVA: 0x00003491 File Offset: 0x00001691
	[DebuggerNonUserCode]
	public string SourceSystem
	{
		get
		{
			return this.sourceSystem_ ?? BusMessage.SourceSystemDefaultValue;
		}
		set
		{
			this.sourceSystem_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000050 RID: 80 RVA: 0x000034A8 File Offset: 0x000016A8
	[DebuggerNonUserCode]
	public bool HasSourceSystem
	{
		get
		{
			return this.sourceSystem_ != null;
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000034C3 File Offset: 0x000016C3
	[DebuggerNonUserCode]
	public void ClearSourceSystem()
	{
		this.sourceSystem_ = null;
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000052 RID: 82 RVA: 0x000034D0 File Offset: 0x000016D0
	// (set) Token: 0x06000053 RID: 83 RVA: 0x000034F1 File Offset: 0x000016F1
	[DebuggerNonUserCode]
	public string SourceModule
	{
		get
		{
			return this.sourceModule_ ?? BusMessage.SourceModuleDefaultValue;
		}
		set
		{
			this.sourceModule_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000054 RID: 84 RVA: 0x00003508 File Offset: 0x00001708
	[DebuggerNonUserCode]
	public bool HasSourceModule
	{
		get
		{
			return this.sourceModule_ != null;
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003523 File Offset: 0x00001723
	[DebuggerNonUserCode]
	public void ClearSourceModule()
	{
		this.sourceModule_ = null;
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00003530 File Offset: 0x00001730
	// (set) Token: 0x06000057 RID: 87 RVA: 0x00003551 File Offset: 0x00001751
	[DebuggerNonUserCode]
	public string Domain
	{
		get
		{
			return this.domain_ ?? BusMessage.DomainDefaultValue;
		}
		set
		{
			this.domain_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000058 RID: 88 RVA: 0x00003568 File Offset: 0x00001768
	[DebuggerNonUserCode]
	public bool HasDomain
	{
		get
		{
			return this.domain_ != null;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00003583 File Offset: 0x00001783
	[DebuggerNonUserCode]
	public void ClearDomain()
	{
		this.domain_ = null;
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00003590 File Offset: 0x00001790
	// (set) Token: 0x0600005B RID: 91 RVA: 0x000035C1 File Offset: 0x000017C1
	[DebuggerNonUserCode]
	public bool Joined
	{
		get
		{
			bool flag = (this._hasBits0 & 1) != 0;
			bool joinedDefaultValue;
			if (flag)
			{
				joinedDefaultValue = this.joined_;
			}
			else
			{
				joinedDefaultValue = BusMessage.JoinedDefaultValue;
			}
			return joinedDefaultValue;
		}
		set
		{
			this._hasBits0 |= 1;
			this.joined_ = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600005C RID: 92 RVA: 0x000035DC File Offset: 0x000017DC
	[DebuggerNonUserCode]
	public bool HasJoined
	{
		get
		{
			return (this._hasBits0 & 1) != 0;
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000035F9 File Offset: 0x000017F9
	[DebuggerNonUserCode]
	public void ClearJoined()
	{
		this._hasBits0 &= -2;
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600005E RID: 94 RVA: 0x0000360C File Offset: 0x0000180C
	// (set) Token: 0x0600005F RID: 95 RVA: 0x0000362D File Offset: 0x0000182D
	[DebuggerNonUserCode]
	public string TargetSystem
	{
		get
		{
			return this.targetSystem_ ?? BusMessage.TargetSystemDefaultValue;
		}
		set
		{
			this.targetSystem_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00003644 File Offset: 0x00001844
	[DebuggerNonUserCode]
	public bool HasTargetSystem
	{
		get
		{
			return this.targetSystem_ != null;
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000365F File Offset: 0x0000185F
	[DebuggerNonUserCode]
	public void ClearTargetSystem()
	{
		this.targetSystem_ = null;
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000062 RID: 98 RVA: 0x0000366C File Offset: 0x0000186C
	// (set) Token: 0x06000063 RID: 99 RVA: 0x0000368D File Offset: 0x0000188D
	[DebuggerNonUserCode]
	public string TargetModule
	{
		get
		{
			return this.targetModule_ ?? BusMessage.TargetModuleDefaultValue;
		}
		set
		{
			this.targetModule_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000064 RID: 100 RVA: 0x000036A4 File Offset: 0x000018A4
	[DebuggerNonUserCode]
	public bool HasTargetModule
	{
		get
		{
			return this.targetModule_ != null;
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000036BF File Offset: 0x000018BF
	[DebuggerNonUserCode]
	public void ClearTargetModule()
	{
		this.targetModule_ = null;
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000066 RID: 102 RVA: 0x000036CC File Offset: 0x000018CC
	// (set) Token: 0x06000067 RID: 103 RVA: 0x000036ED File Offset: 0x000018ED
	[DebuggerNonUserCode]
	public string SourceSession
	{
		get
		{
			return this.sourceSession_ ?? BusMessage.SourceSessionDefaultValue;
		}
		set
		{
			this.sourceSession_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000068 RID: 104 RVA: 0x00003704 File Offset: 0x00001904
	[DebuggerNonUserCode]
	public bool HasSourceSession
	{
		get
		{
			return this.sourceSession_ != null;
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000371F File Offset: 0x0000191F
	[DebuggerNonUserCode]
	public void ClearSourceSession()
	{
		this.sourceSession_ = null;
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600006A RID: 106 RVA: 0x0000372C File Offset: 0x0000192C
	// (set) Token: 0x0600006B RID: 107 RVA: 0x0000374D File Offset: 0x0000194D
	[DebuggerNonUserCode]
	public string SourceUsername
	{
		get
		{
			return this.sourceUsername_ ?? BusMessage.SourceUsernameDefaultValue;
		}
		set
		{
			this.sourceUsername_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00003764 File Offset: 0x00001964
	[DebuggerNonUserCode]
	public bool HasSourceUsername
	{
		get
		{
			return this.sourceUsername_ != null;
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000377F File Offset: 0x0000197F
	[DebuggerNonUserCode]
	public void ClearSourceUsername()
	{
		this.sourceUsername_ = null;
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600006E RID: 110 RVA: 0x0000378C File Offset: 0x0000198C
	// (set) Token: 0x0600006F RID: 111 RVA: 0x000037AD File Offset: 0x000019AD
	[DebuggerNonUserCode]
	public string ReferenceUniqueid
	{
		get
		{
			return this.referenceUniqueid_ ?? BusMessage.ReferenceUniqueidDefaultValue;
		}
		set
		{
			this.referenceUniqueid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000070 RID: 112 RVA: 0x000037C4 File Offset: 0x000019C4
	[DebuggerNonUserCode]
	public bool HasReferenceUniqueid
	{
		get
		{
			return this.referenceUniqueid_ != null;
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000037DF File Offset: 0x000019DF
	[DebuggerNonUserCode]
	public void ClearReferenceUniqueid()
	{
		this.referenceUniqueid_ = null;
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000072 RID: 114 RVA: 0x000037EC File Offset: 0x000019EC
	// (set) Token: 0x06000073 RID: 115 RVA: 0x0000381D File Offset: 0x00001A1D
	[DebuggerNonUserCode]
	public uint SourcePid
	{
		get
		{
			bool flag = (this._hasBits0 & 2) != 0;
			uint sourcePidDefaultValue;
			if (flag)
			{
				sourcePidDefaultValue = this.sourcePid_;
			}
			else
			{
				sourcePidDefaultValue = BusMessage.SourcePidDefaultValue;
			}
			return sourcePidDefaultValue;
		}
		set
		{
			this._hasBits0 |= 2;
			this.sourcePid_ = value;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00003838 File Offset: 0x00001A38
	[DebuggerNonUserCode]
	public bool HasSourcePid
	{
		get
		{
			return (this._hasBits0 & 2) != 0;
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003855 File Offset: 0x00001A55
	[DebuggerNonUserCode]
	public void ClearSourcePid()
	{
		this._hasBits0 &= -3;
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00003868 File Offset: 0x00001A68
	// (set) Token: 0x06000077 RID: 119 RVA: 0x00003889 File Offset: 0x00001A89
	[DebuggerNonUserCode]
	public string TargetSession
	{
		get
		{
			return this.targetSession_ ?? BusMessage.TargetSessionDefaultValue;
		}
		set
		{
			this.targetSession_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000078 RID: 120 RVA: 0x000038A0 File Offset: 0x00001AA0
	[DebuggerNonUserCode]
	public bool HasTargetSession
	{
		get
		{
			return this.targetSession_ != null;
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000038BB File Offset: 0x00001ABB
	[DebuggerNonUserCode]
	public void ClearTargetSession()
	{
		this.targetSession_ = null;
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600007A RID: 122 RVA: 0x000038C8 File Offset: 0x00001AC8
	// (set) Token: 0x0600007B RID: 123 RVA: 0x000038E9 File Offset: 0x00001AE9
	[DebuggerNonUserCode]
	public string TargetUsername
	{
		get
		{
			return this.targetUsername_ ?? BusMessage.TargetUsernameDefaultValue;
		}
		set
		{
			this.targetUsername_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600007C RID: 124 RVA: 0x00003900 File Offset: 0x00001B00
	[DebuggerNonUserCode]
	public bool HasTargetUsername
	{
		get
		{
			return this.targetUsername_ != null;
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000391B File Offset: 0x00001B1B
	[DebuggerNonUserCode]
	public void ClearTargetUsername()
	{
		this.targetUsername_ = null;
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600007E RID: 126 RVA: 0x00003928 File Offset: 0x00001B28
	[DebuggerNonUserCode]
	public RepeatedField<BusMessage.Types.Peer> BusPeer
	{
		get
		{
			return this.busPeer_;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600007F RID: 127 RVA: 0x00003940 File Offset: 0x00001B40
	// (set) Token: 0x06000080 RID: 128 RVA: 0x00003958 File Offset: 0x00001B58
	[DebuggerNonUserCode]
	public BusMessage.Types.Generic Generic
	{
		get
		{
			return this.generic_;
		}
		set
		{
			this.generic_ = value;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000081 RID: 129 RVA: 0x00003964 File Offset: 0x00001B64
	// (set) Token: 0x06000082 RID: 130 RVA: 0x0000397C File Offset: 0x00001B7C
	[DebuggerNonUserCode]
	public BusMessage.Types.Status Status
	{
		get
		{
			return this.status_;
		}
		set
		{
			this.status_ = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000083 RID: 131 RVA: 0x00003988 File Offset: 0x00001B88
	// (set) Token: 0x06000084 RID: 132 RVA: 0x000039A0 File Offset: 0x00001BA0
	[DebuggerNonUserCode]
	public BusMessage.Types.EncryptedBusMessage EncryptedBusMessage
	{
		get
		{
			return this.encryptedBusMessage_;
		}
		set
		{
			this.encryptedBusMessage_ = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000085 RID: 133 RVA: 0x000039AC File Offset: 0x00001BAC
	// (set) Token: 0x06000086 RID: 134 RVA: 0x000039C4 File Offset: 0x00001BC4
	[DebuggerNonUserCode]
	public BusMessage.Types.EncryptionSetup Encryptionsetup
	{
		get
		{
			return this.encryptionsetup_;
		}
		set
		{
			this.encryptionsetup_ = value;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000087 RID: 135 RVA: 0x000039D0 File Offset: 0x00001BD0
	// (set) Token: 0x06000088 RID: 136 RVA: 0x00003A01 File Offset: 0x00001C01
	[DebuggerNonUserCode]
	public uint ProtocolVersion
	{
		get
		{
			bool flag = (this._hasBits0 & 4) != 0;
			uint protocolVersionDefaultValue;
			if (flag)
			{
				protocolVersionDefaultValue = this.protocolVersion_;
			}
			else
			{
				protocolVersionDefaultValue = BusMessage.ProtocolVersionDefaultValue;
			}
			return protocolVersionDefaultValue;
		}
		set
		{
			this._hasBits0 |= 4;
			this.protocolVersion_ = value;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000089 RID: 137 RVA: 0x00003A1C File Offset: 0x00001C1C
	[DebuggerNonUserCode]
	public bool HasProtocolVersion
	{
		get
		{
			return (this._hasBits0 & 4) != 0;
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00003A39 File Offset: 0x00001C39
	[DebuggerNonUserCode]
	public void ClearProtocolVersion()
	{
		this._hasBits0 &= -5;
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600008B RID: 139 RVA: 0x00003A4C File Offset: 0x00001C4C
	// (set) Token: 0x0600008C RID: 140 RVA: 0x00003A7D File Offset: 0x00001C7D
	[DebuggerNonUserCode]
	public bool SourceIsElevated
	{
		get
		{
			bool flag = (this._hasBits0 & 8) != 0;
			bool sourceIsElevatedDefaultValue;
			if (flag)
			{
				sourceIsElevatedDefaultValue = this.sourceIsElevated_;
			}
			else
			{
				sourceIsElevatedDefaultValue = BusMessage.SourceIsElevatedDefaultValue;
			}
			return sourceIsElevatedDefaultValue;
		}
		set
		{
			this._hasBits0 |= 8;
			this.sourceIsElevated_ = value;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600008D RID: 141 RVA: 0x00003A98 File Offset: 0x00001C98
	[DebuggerNonUserCode]
	public bool HasSourceIsElevated
	{
		get
		{
			return (this._hasBits0 & 8) != 0;
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00003AB5 File Offset: 0x00001CB5
	[DebuggerNonUserCode]
	public void ClearSourceIsElevated()
	{
		this._hasBits0 &= -9;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return this.Equals(other as BusMessage);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00003AE8 File Offset: 0x00001CE8
	[DebuggerNonUserCode]
	public bool Equals(BusMessage other)
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
				bool flag4 = this.Uniqueid != other.Uniqueid;
				if (flag4)
				{
					flag2 = false;
				}
				else
				{
					bool flag5 = this.SourceSystem != other.SourceSystem;
					if (flag5)
					{
						flag2 = false;
					}
					else
					{
						bool flag6 = this.SourceModule != other.SourceModule;
						if (flag6)
						{
							flag2 = false;
						}
						else
						{
							bool flag7 = this.Domain != other.Domain;
							if (flag7)
							{
								flag2 = false;
							}
							else
							{
								bool flag8 = this.Joined != other.Joined;
								if (flag8)
								{
									flag2 = false;
								}
								else
								{
									bool flag9 = this.TargetSystem != other.TargetSystem;
									if (flag9)
									{
										flag2 = false;
									}
									else
									{
										bool flag10 = this.TargetModule != other.TargetModule;
										if (flag10)
										{
											flag2 = false;
										}
										else
										{
											bool flag11 = this.SourceSession != other.SourceSession;
											if (flag11)
											{
												flag2 = false;
											}
											else
											{
												bool flag12 = this.SourceUsername != other.SourceUsername;
												if (flag12)
												{
													flag2 = false;
												}
												else
												{
													bool flag13 = this.ReferenceUniqueid != other.ReferenceUniqueid;
													if (flag13)
													{
														flag2 = false;
													}
													else
													{
														bool flag14 = this.SourcePid != other.SourcePid;
														if (flag14)
														{
															flag2 = false;
														}
														else
														{
															bool flag15 = this.TargetSession != other.TargetSession;
															if (flag15)
															{
																flag2 = false;
															}
															else
															{
																bool flag16 = this.TargetUsername != other.TargetUsername;
																if (flag16)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag17 = !this.busPeer_.Equals(other.busPeer_);
																	if (flag17)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag18 = !object.Equals(this.Generic, other.Generic);
																		if (flag18)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag19 = !object.Equals(this.Status, other.Status);
																			if (flag19)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag20 = !object.Equals(this.EncryptedBusMessage, other.EncryptedBusMessage);
																				if (flag20)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag21 = !object.Equals(this.Encryptionsetup, other.Encryptionsetup);
																					if (flag21)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag22 = this.ProtocolVersion != other.ProtocolVersion;
																						if (flag22)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag23 = this.SourceIsElevated != other.SourceIsElevated;
																							flag2 = !flag23 && object.Equals(this._unknownFields, other._unknownFields);
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
						}
					}
				}
			}
		}
		return flag2;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00003D84 File Offset: 0x00001F84
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		bool hasUniqueid = this.HasUniqueid;
		if (hasUniqueid)
		{
			num ^= this.Uniqueid.GetHashCode();
		}
		bool hasSourceSystem = this.HasSourceSystem;
		if (hasSourceSystem)
		{
			num ^= this.SourceSystem.GetHashCode();
		}
		bool hasSourceModule = this.HasSourceModule;
		if (hasSourceModule)
		{
			num ^= this.SourceModule.GetHashCode();
		}
		bool hasDomain = this.HasDomain;
		if (hasDomain)
		{
			num ^= this.Domain.GetHashCode();
		}
		bool hasJoined = this.HasJoined;
		if (hasJoined)
		{
			num ^= this.Joined.GetHashCode();
		}
		bool hasTargetSystem = this.HasTargetSystem;
		if (hasTargetSystem)
		{
			num ^= this.TargetSystem.GetHashCode();
		}
		bool hasTargetModule = this.HasTargetModule;
		if (hasTargetModule)
		{
			num ^= this.TargetModule.GetHashCode();
		}
		bool hasSourceSession = this.HasSourceSession;
		if (hasSourceSession)
		{
			num ^= this.SourceSession.GetHashCode();
		}
		bool hasSourceUsername = this.HasSourceUsername;
		if (hasSourceUsername)
		{
			num ^= this.SourceUsername.GetHashCode();
		}
		bool hasReferenceUniqueid = this.HasReferenceUniqueid;
		if (hasReferenceUniqueid)
		{
			num ^= this.ReferenceUniqueid.GetHashCode();
		}
		bool hasSourcePid = this.HasSourcePid;
		if (hasSourcePid)
		{
			num ^= this.SourcePid.GetHashCode();
		}
		bool hasTargetSession = this.HasTargetSession;
		if (hasTargetSession)
		{
			num ^= this.TargetSession.GetHashCode();
		}
		bool hasTargetUsername = this.HasTargetUsername;
		if (hasTargetUsername)
		{
			num ^= this.TargetUsername.GetHashCode();
		}
		num ^= this.busPeer_.GetHashCode();
		bool flag = this.generic_ != null;
		if (flag)
		{
			num ^= this.Generic.GetHashCode();
		}
		bool flag2 = this.status_ != null;
		if (flag2)
		{
			num ^= this.Status.GetHashCode();
		}
		bool flag3 = this.encryptedBusMessage_ != null;
		if (flag3)
		{
			num ^= this.EncryptedBusMessage.GetHashCode();
		}
		bool flag4 = this.encryptionsetup_ != null;
		if (flag4)
		{
			num ^= this.Encryptionsetup.GetHashCode();
		}
		bool hasProtocolVersion = this.HasProtocolVersion;
		if (hasProtocolVersion)
		{
			num ^= this.ProtocolVersion.GetHashCode();
		}
		bool hasSourceIsElevated = this.HasSourceIsElevated;
		if (hasSourceIsElevated)
		{
			num ^= this.SourceIsElevated.GetHashCode();
		}
		bool flag5 = this._unknownFields != null;
		if (flag5)
		{
			num ^= this._unknownFields.GetHashCode();
		}
		return num;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00003FCC File Offset: 0x000021CC
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00003FE4 File Offset: 0x000021E4
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00003FF0 File Offset: 0x000021F0
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		bool hasUniqueid = this.HasUniqueid;
		if (hasUniqueid)
		{
			output.WriteRawTag(10);
			output.WriteString(this.Uniqueid);
		}
		bool hasSourceSystem = this.HasSourceSystem;
		if (hasSourceSystem)
		{
			output.WriteRawTag(18);
			output.WriteString(this.SourceSystem);
		}
		bool hasSourceModule = this.HasSourceModule;
		if (hasSourceModule)
		{
			output.WriteRawTag(26);
			output.WriteString(this.SourceModule);
		}
		bool hasDomain = this.HasDomain;
		if (hasDomain)
		{
			output.WriteRawTag(34);
			output.WriteString(this.Domain);
		}
		bool hasJoined = this.HasJoined;
		if (hasJoined)
		{
			output.WriteRawTag(40);
			output.WriteBool(this.Joined);
		}
		bool hasTargetSystem = this.HasTargetSystem;
		if (hasTargetSystem)
		{
			output.WriteRawTag(50);
			output.WriteString(this.TargetSystem);
		}
		bool hasTargetModule = this.HasTargetModule;
		if (hasTargetModule)
		{
			output.WriteRawTag(58);
			output.WriteString(this.TargetModule);
		}
		bool hasSourceSession = this.HasSourceSession;
		if (hasSourceSession)
		{
			output.WriteRawTag(66);
			output.WriteString(this.SourceSession);
		}
		bool hasSourceUsername = this.HasSourceUsername;
		if (hasSourceUsername)
		{
			output.WriteRawTag(74);
			output.WriteString(this.SourceUsername);
		}
		bool hasReferenceUniqueid = this.HasReferenceUniqueid;
		if (hasReferenceUniqueid)
		{
			output.WriteRawTag(82);
			output.WriteString(this.ReferenceUniqueid);
		}
		bool hasSourcePid = this.HasSourcePid;
		if (hasSourcePid)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(this.SourcePid);
		}
		bool hasTargetSession = this.HasTargetSession;
		if (hasTargetSession)
		{
			output.WriteRawTag(106);
			output.WriteString(this.TargetSession);
		}
		bool hasTargetUsername = this.HasTargetUsername;
		if (hasTargetUsername)
		{
			output.WriteRawTag(114);
			output.WriteString(this.TargetUsername);
		}
		this.busPeer_.WriteTo(ref output, BusMessage._repeated_busPeer_codec);
		bool flag = this.generic_ != null;
		if (flag)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(this.Generic);
		}
		bool flag2 = this.status_ != null;
		if (flag2)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(this.Status);
		}
		bool flag3 = this.encryptedBusMessage_ != null;
		if (flag3)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(this.EncryptedBusMessage);
		}
		bool flag4 = this.encryptionsetup_ != null;
		if (flag4)
		{
			output.WriteRawTag(194, 12);
			output.WriteMessage(this.Encryptionsetup);
		}
		bool hasProtocolVersion = this.HasProtocolVersion;
		if (hasProtocolVersion)
		{
			output.WriteRawTag(224, 18);
			output.WriteUInt32(this.ProtocolVersion);
		}
		bool hasSourceIsElevated = this.HasSourceIsElevated;
		if (hasSourceIsElevated)
		{
			output.WriteRawTag(232, 18);
			output.WriteBool(this.SourceIsElevated);
		}
		bool flag5 = this._unknownFields != null;
		if (flag5)
		{
			this._unknownFields.WriteTo(ref output);
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000042FC File Offset: 0x000024FC
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		bool hasUniqueid = this.HasUniqueid;
		if (hasUniqueid)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.Uniqueid);
		}
		bool hasSourceSystem = this.HasSourceSystem;
		if (hasSourceSystem)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.SourceSystem);
		}
		bool hasSourceModule = this.HasSourceModule;
		if (hasSourceModule)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.SourceModule);
		}
		bool hasDomain = this.HasDomain;
		if (hasDomain)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.Domain);
		}
		bool hasJoined = this.HasJoined;
		if (hasJoined)
		{
			num += 2;
		}
		bool hasTargetSystem = this.HasTargetSystem;
		if (hasTargetSystem)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.TargetSystem);
		}
		bool hasTargetModule = this.HasTargetModule;
		if (hasTargetModule)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.TargetModule);
		}
		bool hasSourceSession = this.HasSourceSession;
		if (hasSourceSession)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.SourceSession);
		}
		bool hasSourceUsername = this.HasSourceUsername;
		if (hasSourceUsername)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.SourceUsername);
		}
		bool hasReferenceUniqueid = this.HasReferenceUniqueid;
		if (hasReferenceUniqueid)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.ReferenceUniqueid);
		}
		bool hasSourcePid = this.HasSourcePid;
		if (hasSourcePid)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourcePid);
		}
		bool hasTargetSession = this.HasTargetSession;
		if (hasTargetSession)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.TargetSession);
		}
		bool hasTargetUsername = this.HasTargetUsername;
		if (hasTargetUsername)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(this.TargetUsername);
		}
		num += this.busPeer_.CalculateSize(BusMessage._repeated_busPeer_codec);
		bool flag = this.generic_ != null;
		if (flag)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(this.Generic);
		}
		bool flag2 = this.status_ != null;
		if (flag2)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(this.Status);
		}
		bool flag3 = this.encryptedBusMessage_ != null;
		if (flag3)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(this.EncryptedBusMessage);
		}
		bool flag4 = this.encryptionsetup_ != null;
		if (flag4)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(this.Encryptionsetup);
		}
		bool hasProtocolVersion = this.HasProtocolVersion;
		if (hasProtocolVersion)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(this.ProtocolVersion);
		}
		bool hasSourceIsElevated = this.HasSourceIsElevated;
		if (hasSourceIsElevated)
		{
			num += 3;
		}
		bool flag5 = this._unknownFields != null;
		if (flag5)
		{
			num += this._unknownFields.CalculateSize();
		}
		return num;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00004570 File Offset: 0x00002770
	[DebuggerNonUserCode]
	public void MergeFrom(BusMessage other)
	{
		bool flag = other == null;
		if (!flag)
		{
			bool hasUniqueid = other.HasUniqueid;
			if (hasUniqueid)
			{
				this.Uniqueid = other.Uniqueid;
			}
			bool hasSourceSystem = other.HasSourceSystem;
			if (hasSourceSystem)
			{
				this.SourceSystem = other.SourceSystem;
			}
			bool hasSourceModule = other.HasSourceModule;
			if (hasSourceModule)
			{
				this.SourceModule = other.SourceModule;
			}
			bool hasDomain = other.HasDomain;
			if (hasDomain)
			{
				this.Domain = other.Domain;
			}
			bool hasJoined = other.HasJoined;
			if (hasJoined)
			{
				this.Joined = other.Joined;
			}
			bool hasTargetSystem = other.HasTargetSystem;
			if (hasTargetSystem)
			{
				this.TargetSystem = other.TargetSystem;
			}
			bool hasTargetModule = other.HasTargetModule;
			if (hasTargetModule)
			{
				this.TargetModule = other.TargetModule;
			}
			bool hasSourceSession = other.HasSourceSession;
			if (hasSourceSession)
			{
				this.SourceSession = other.SourceSession;
			}
			bool hasSourceUsername = other.HasSourceUsername;
			if (hasSourceUsername)
			{
				this.SourceUsername = other.SourceUsername;
			}
			bool hasReferenceUniqueid = other.HasReferenceUniqueid;
			if (hasReferenceUniqueid)
			{
				this.ReferenceUniqueid = other.ReferenceUniqueid;
			}
			bool hasSourcePid = other.HasSourcePid;
			if (hasSourcePid)
			{
				this.SourcePid = other.SourcePid;
			}
			bool hasTargetSession = other.HasTargetSession;
			if (hasTargetSession)
			{
				this.TargetSession = other.TargetSession;
			}
			bool hasTargetUsername = other.HasTargetUsername;
			if (hasTargetUsername)
			{
				this.TargetUsername = other.TargetUsername;
			}
			this.busPeer_.Add(other.busPeer_);
			bool flag2 = other.generic_ != null;
			if (flag2)
			{
				bool flag3 = this.generic_ == null;
				if (flag3)
				{
					this.Generic = new BusMessage.Types.Generic();
				}
				this.Generic.MergeFrom(other.Generic);
			}
			bool flag4 = other.status_ != null;
			if (flag4)
			{
				bool flag5 = this.status_ == null;
				if (flag5)
				{
					this.Status = new BusMessage.Types.Status();
				}
				this.Status.MergeFrom(other.Status);
			}
			bool flag6 = other.encryptedBusMessage_ != null;
			if (flag6)
			{
				bool flag7 = this.encryptedBusMessage_ == null;
				if (flag7)
				{
					this.EncryptedBusMessage = new BusMessage.Types.EncryptedBusMessage();
				}
				this.EncryptedBusMessage.MergeFrom(other.EncryptedBusMessage);
			}
			bool flag8 = other.encryptionsetup_ != null;
			if (flag8)
			{
				bool flag9 = this.encryptionsetup_ == null;
				if (flag9)
				{
					this.Encryptionsetup = new BusMessage.Types.EncryptionSetup();
				}
				this.Encryptionsetup.MergeFrom(other.Encryptionsetup);
			}
			bool hasProtocolVersion = other.HasProtocolVersion;
			if (hasProtocolVersion)
			{
				this.ProtocolVersion = other.ProtocolVersion;
			}
			bool hasSourceIsElevated = other.HasSourceIsElevated;
			if (hasSourceIsElevated)
			{
				this.SourceIsElevated = other.SourceIsElevated;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004844 File Offset: 0x00002A44
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00004850 File Offset: 0x00002A50
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) > 0U)
		{
			uint num2 = num;
			uint num3 = num2;
			if (num3 <= 82U)
			{
				if (num3 <= 40U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_011A;
							}
							this.SourceSystem = input.ReadString();
						}
						else
						{
							this.Uniqueid = input.ReadString();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_011A;
							}
							this.Joined = input.ReadBool();
						}
						else
						{
							this.Domain = input.ReadString();
						}
					}
					else
					{
						this.SourceModule = input.ReadString();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_011A;
						}
						this.TargetModule = input.ReadString();
					}
					else
					{
						this.TargetSystem = input.ReadString();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						if (num3 != 82U)
						{
							goto IL_011A;
						}
						this.ReferenceUniqueid = input.ReadString();
					}
					else
					{
						this.SourceUsername = input.ReadString();
					}
				}
				else
				{
					this.SourceSession = input.ReadString();
				}
			}
			else if (num3 <= 162U)
			{
				if (num3 <= 106U)
				{
					if (num3 != 88U)
					{
						if (num3 != 106U)
						{
							goto IL_011A;
						}
						this.TargetSession = input.ReadString();
					}
					else
					{
						this.SourcePid = input.ReadUInt32();
					}
				}
				else if (num3 != 114U)
				{
					if (num3 != 122U)
					{
						if (num3 != 162U)
						{
							goto IL_011A;
						}
						bool flag = this.generic_ == null;
						if (flag)
						{
							this.Generic = new BusMessage.Types.Generic();
						}
						input.ReadMessage(this.Generic);
					}
					else
					{
						this.busPeer_.AddEntriesFrom(ref input, BusMessage._repeated_busPeer_codec);
					}
				}
				else
				{
					this.TargetUsername = input.ReadString();
				}
			}
			else if (num3 <= 178U)
			{
				if (num3 != 170U)
				{
					if (num3 != 178U)
					{
						goto IL_011A;
					}
					bool flag2 = this.encryptedBusMessage_ == null;
					if (flag2)
					{
						this.EncryptedBusMessage = new BusMessage.Types.EncryptedBusMessage();
					}
					input.ReadMessage(this.EncryptedBusMessage);
				}
				else
				{
					bool flag3 = this.status_ == null;
					if (flag3)
					{
						this.Status = new BusMessage.Types.Status();
					}
					input.ReadMessage(this.Status);
				}
			}
			else if (num3 != 1602U)
			{
				if (num3 != 2400U)
				{
					if (num3 != 2408U)
					{
						goto IL_011A;
					}
					this.SourceIsElevated = input.ReadBool();
				}
				else
				{
					this.ProtocolVersion = input.ReadUInt32();
				}
			}
			else
			{
				bool flag4 = this.encryptionsetup_ == null;
				if (flag4)
				{
					this.Encryptionsetup = new BusMessage.Types.EncryptionSetup();
				}
				input.ReadMessage(this.Encryptionsetup);
			}
			continue;
			IL_011A:
			this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
		}
	}

	// Token: 0x0400001B RID: 27
	private static readonly MessageParser<BusMessage> _parser = new MessageParser<BusMessage>(() => new BusMessage());

	// Token: 0x0400001C RID: 28
	private UnknownFieldSet _unknownFields;

	// Token: 0x0400001D RID: 29
	private int _hasBits0;

	// Token: 0x0400001E RID: 30
	public const int UniqueidFieldNumber = 1;

	// Token: 0x0400001F RID: 31
	private static readonly string UniqueidDefaultValue = "";

	// Token: 0x04000020 RID: 32
	private string uniqueid_;

	// Token: 0x04000021 RID: 33
	public const int SourceSystemFieldNumber = 2;

	// Token: 0x04000022 RID: 34
	private static readonly string SourceSystemDefaultValue = "";

	// Token: 0x04000023 RID: 35
	private string sourceSystem_;

	// Token: 0x04000024 RID: 36
	public const int SourceModuleFieldNumber = 3;

	// Token: 0x04000025 RID: 37
	private static readonly string SourceModuleDefaultValue = "";

	// Token: 0x04000026 RID: 38
	private string sourceModule_;

	// Token: 0x04000027 RID: 39
	public const int DomainFieldNumber = 4;

	// Token: 0x04000028 RID: 40
	private static readonly string DomainDefaultValue = "";

	// Token: 0x04000029 RID: 41
	private string domain_;

	// Token: 0x0400002A RID: 42
	public const int JoinedFieldNumber = 5;

	// Token: 0x0400002B RID: 43
	private static readonly bool JoinedDefaultValue = false;

	// Token: 0x0400002C RID: 44
	private bool joined_;

	// Token: 0x0400002D RID: 45
	public const int TargetSystemFieldNumber = 6;

	// Token: 0x0400002E RID: 46
	private static readonly string TargetSystemDefaultValue = "";

	// Token: 0x0400002F RID: 47
	private string targetSystem_;

	// Token: 0x04000030 RID: 48
	public const int TargetModuleFieldNumber = 7;

	// Token: 0x04000031 RID: 49
	private static readonly string TargetModuleDefaultValue = "";

	// Token: 0x04000032 RID: 50
	private string targetModule_;

	// Token: 0x04000033 RID: 51
	public const int SourceSessionFieldNumber = 8;

	// Token: 0x04000034 RID: 52
	private static readonly string SourceSessionDefaultValue = "";

	// Token: 0x04000035 RID: 53
	private string sourceSession_;

	// Token: 0x04000036 RID: 54
	public const int SourceUsernameFieldNumber = 9;

	// Token: 0x04000037 RID: 55
	private static readonly string SourceUsernameDefaultValue = "";

	// Token: 0x04000038 RID: 56
	private string sourceUsername_;

	// Token: 0x04000039 RID: 57
	public const int ReferenceUniqueidFieldNumber = 10;

	// Token: 0x0400003A RID: 58
	private static readonly string ReferenceUniqueidDefaultValue = "";

	// Token: 0x0400003B RID: 59
	private string referenceUniqueid_;

	// Token: 0x0400003C RID: 60
	public const int SourcePidFieldNumber = 11;

	// Token: 0x0400003D RID: 61
	private static readonly uint SourcePidDefaultValue = 0U;

	// Token: 0x0400003E RID: 62
	private uint sourcePid_;

	// Token: 0x0400003F RID: 63
	public const int TargetSessionFieldNumber = 13;

	// Token: 0x04000040 RID: 64
	private static readonly string TargetSessionDefaultValue = "";

	// Token: 0x04000041 RID: 65
	private string targetSession_;

	// Token: 0x04000042 RID: 66
	public const int TargetUsernameFieldNumber = 14;

	// Token: 0x04000043 RID: 67
	private static readonly string TargetUsernameDefaultValue = "";

	// Token: 0x04000044 RID: 68
	private string targetUsername_;

	// Token: 0x04000045 RID: 69
	public const int BusPeerFieldNumber = 15;

	// Token: 0x04000046 RID: 70
	private static readonly FieldCodec<BusMessage.Types.Peer> _repeated_busPeer_codec = FieldCodec.ForMessage<BusMessage.Types.Peer>(122U, BusMessage.Types.Peer.Parser);

	// Token: 0x04000047 RID: 71
	private readonly RepeatedField<BusMessage.Types.Peer> busPeer_ = new RepeatedField<BusMessage.Types.Peer>();

	// Token: 0x04000048 RID: 72
	public const int GenericFieldNumber = 20;

	// Token: 0x04000049 RID: 73
	private BusMessage.Types.Generic generic_;

	// Token: 0x0400004A RID: 74
	public const int StatusFieldNumber = 21;

	// Token: 0x0400004B RID: 75
	private BusMessage.Types.Status status_;

	// Token: 0x0400004C RID: 76
	public const int EncryptedBusMessageFieldNumber = 22;

	// Token: 0x0400004D RID: 77
	private BusMessage.Types.EncryptedBusMessage encryptedBusMessage_;

	// Token: 0x0400004E RID: 78
	public const int EncryptionsetupFieldNumber = 200;

	// Token: 0x0400004F RID: 79
	private BusMessage.Types.EncryptionSetup encryptionsetup_;

	// Token: 0x04000050 RID: 80
	public const int ProtocolVersionFieldNumber = 300;

	// Token: 0x04000051 RID: 81
	private static readonly uint ProtocolVersionDefaultValue = 0U;

	// Token: 0x04000052 RID: 82
	private uint protocolVersion_;

	// Token: 0x04000053 RID: 83
	public const int SourceIsElevatedFieldNumber = 301;

	// Token: 0x04000054 RID: 84
	private static readonly bool SourceIsElevatedDefaultValue = false;

	// Token: 0x04000055 RID: 85
	private bool sourceIsElevated_;

	// Token: 0x02000B28 RID: 2856
	[DebuggerNonUserCode]
	public static class Types
	{
		// Token: 0x0200145A RID: 5210
		public sealed class Generic : IMessage<BusMessage.Types.Generic>, IMessage, IEquatable<BusMessage.Types.Generic>, IDeepCloneable<BusMessage.Types.Generic>, IBufferMessage
		{
			// Token: 0x170039AA RID: 14762
			// (get) Token: 0x0600E32D RID: 58157 RVA: 0x004CCB14 File Offset: 0x004CAD14
			[DebuggerNonUserCode]
			public static MessageParser<BusMessage.Types.Generic> Parser
			{
				get
				{
					return BusMessage.Types.Generic._parser;
				}
			}

			// Token: 0x170039AB RID: 14763
			// (get) Token: 0x0600E32E RID: 58158 RVA: 0x004CCB2C File Offset: 0x004CAD2C
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				get
				{
					return BusMessage.Descriptor.NestedTypes[0];
				}
			}

			// Token: 0x170039AC RID: 14764
			// (get) Token: 0x0600E32F RID: 58159 RVA: 0x004CCB50 File Offset: 0x004CAD50
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor
			{
				get
				{
					return BusMessage.Types.Generic.Descriptor;
				}
			}

			// Token: 0x0600E330 RID: 58160 RVA: 0x004CCB67 File Offset: 0x004CAD67
			[DebuggerNonUserCode]
			public Generic()
			{
			}

			// Token: 0x0600E331 RID: 58161 RVA: 0x004CCB71 File Offset: 0x004CAD71
			[DebuggerNonUserCode]
			public Generic(BusMessage.Types.Generic other)
				: this()
			{
				this._hasBits0 = other._hasBits0;
				this.type_ = other.type_;
				this.data_ = other.data_;
				this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			// Token: 0x0600E332 RID: 58162 RVA: 0x004CCBB0 File Offset: 0x004CADB0
			[DebuggerNonUserCode]
			public BusMessage.Types.Generic Clone()
			{
				return new BusMessage.Types.Generic(this);
			}

			// Token: 0x170039AD RID: 14765
			// (get) Token: 0x0600E333 RID: 58163 RVA: 0x004CCBC8 File Offset: 0x004CADC8
			// (set) Token: 0x0600E334 RID: 58164 RVA: 0x004CCBF9 File Offset: 0x004CADF9
			[DebuggerNonUserCode]
			public uint Type
			{
				get
				{
					bool flag = (this._hasBits0 & 1) != 0;
					uint typeDefaultValue;
					if (flag)
					{
						typeDefaultValue = this.type_;
					}
					else
					{
						typeDefaultValue = BusMessage.Types.Generic.TypeDefaultValue;
					}
					return typeDefaultValue;
				}
				set
				{
					this._hasBits0 |= 1;
					this.type_ = value;
				}
			}

			// Token: 0x170039AE RID: 14766
			// (get) Token: 0x0600E335 RID: 58165 RVA: 0x004CCC14 File Offset: 0x004CAE14
			[DebuggerNonUserCode]
			public bool HasType
			{
				get
				{
					return (this._hasBits0 & 1) != 0;
				}
			}

			// Token: 0x0600E336 RID: 58166 RVA: 0x004CCC31 File Offset: 0x004CAE31
			[DebuggerNonUserCode]
			public void ClearType()
			{
				this._hasBits0 &= -2;
			}

			// Token: 0x170039AF RID: 14767
			// (get) Token: 0x0600E337 RID: 58167 RVA: 0x004CCC44 File Offset: 0x004CAE44
			// (set) Token: 0x0600E338 RID: 58168 RVA: 0x004CCC65 File Offset: 0x004CAE65
			[DebuggerNonUserCode]
			public ByteString Data
			{
				get
				{
					return this.data_ ?? BusMessage.Types.Generic.DataDefaultValue;
				}
				set
				{
					this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
				}
			}

			// Token: 0x170039B0 RID: 14768
			// (get) Token: 0x0600E339 RID: 58169 RVA: 0x004CCC7C File Offset: 0x004CAE7C
			[DebuggerNonUserCode]
			public bool HasData
			{
				get
				{
					return this.data_ != null;
				}
			}

			// Token: 0x0600E33A RID: 58170 RVA: 0x004CCC9A File Offset: 0x004CAE9A
			[DebuggerNonUserCode]
			public void ClearData()
			{
				this.data_ = null;
			}

			// Token: 0x0600E33B RID: 58171 RVA: 0x004CCCA4 File Offset: 0x004CAEA4
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return this.Equals(other as BusMessage.Types.Generic);
			}

			// Token: 0x0600E33C RID: 58172 RVA: 0x004CCCC4 File Offset: 0x004CAEC4
			[DebuggerNonUserCode]
			public bool Equals(BusMessage.Types.Generic other)
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
						bool flag4 = this.Type != other.Type;
						if (flag4)
						{
							flag2 = false;
						}
						else
						{
							bool flag5 = this.Data != other.Data;
							flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
				return flag2;
			}

			// Token: 0x0600E33D RID: 58173 RVA: 0x004CCD38 File Offset: 0x004CAF38
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				bool hasType = this.HasType;
				if (hasType)
				{
					num ^= this.Type.GetHashCode();
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					num ^= this.Data.GetHashCode();
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num ^= this._unknownFields.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600E33E RID: 58174 RVA: 0x004CCDA4 File Offset: 0x004CAFA4
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return JsonFormatter.ToDiagnosticString(this);
			}

			// Token: 0x0600E33F RID: 58175 RVA: 0x004CCDBC File Offset: 0x004CAFBC
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			// Token: 0x0600E340 RID: 58176 RVA: 0x004CCDC8 File Offset: 0x004CAFC8
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				bool hasType = this.HasType;
				if (hasType)
				{
					output.WriteRawTag(8);
					output.WriteUInt32(this.Type);
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					output.WriteRawTag(18);
					output.WriteBytes(this.Data);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					this._unknownFields.WriteTo(ref output);
				}
			}

			// Token: 0x0600E341 RID: 58177 RVA: 0x004CCE38 File Offset: 0x004CB038
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				bool hasType = this.HasType;
				if (hasType)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num += this._unknownFields.CalculateSize();
				}
				return num;
			}

			// Token: 0x0600E342 RID: 58178 RVA: 0x004CCEA4 File Offset: 0x004CB0A4
			[DebuggerNonUserCode]
			public void MergeFrom(BusMessage.Types.Generic other)
			{
				bool flag = other == null;
				if (!flag)
				{
					bool hasType = other.HasType;
					if (hasType)
					{
						this.Type = other.Type;
					}
					bool hasData = other.HasData;
					if (hasData)
					{
						this.Data = other.Data;
					}
					this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
				}
			}

			// Token: 0x0600E343 RID: 58179 RVA: 0x004CCF06 File Offset: 0x004CB106
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				input.ReadRawMessage(this);
			}

			// Token: 0x0600E344 RID: 58180 RVA: 0x004CCF14 File Offset: 0x004CB114
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
						if (num3 != 18U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Data = input.ReadBytes();
						}
					}
					else
					{
						this.Type = input.ReadUInt32();
					}
				}
			}

			// Token: 0x0400A239 RID: 41529
			private static readonly MessageParser<BusMessage.Types.Generic> _parser = new MessageParser<BusMessage.Types.Generic>(() => new BusMessage.Types.Generic());

			// Token: 0x0400A23A RID: 41530
			private UnknownFieldSet _unknownFields;

			// Token: 0x0400A23B RID: 41531
			private int _hasBits0;

			// Token: 0x0400A23C RID: 41532
			public const int TypeFieldNumber = 1;

			// Token: 0x0400A23D RID: 41533
			private static readonly uint TypeDefaultValue = 0U;

			// Token: 0x0400A23E RID: 41534
			private uint type_;

			// Token: 0x0400A23F RID: 41535
			public const int DataFieldNumber = 2;

			// Token: 0x0400A240 RID: 41536
			private static readonly ByteString DataDefaultValue = ByteString.Empty;

			// Token: 0x0400A241 RID: 41537
			private ByteString data_;
		}

		// Token: 0x0200145B RID: 5211
		public sealed class EncryptedBusMessage : IMessage<BusMessage.Types.EncryptedBusMessage>, IMessage, IEquatable<BusMessage.Types.EncryptedBusMessage>, IDeepCloneable<BusMessage.Types.EncryptedBusMessage>, IBufferMessage
		{
			// Token: 0x170039B1 RID: 14769
			// (get) Token: 0x0600E346 RID: 58182 RVA: 0x004CCFA8 File Offset: 0x004CB1A8
			[DebuggerNonUserCode]
			public static MessageParser<BusMessage.Types.EncryptedBusMessage> Parser
			{
				get
				{
					return BusMessage.Types.EncryptedBusMessage._parser;
				}
			}

			// Token: 0x170039B2 RID: 14770
			// (get) Token: 0x0600E347 RID: 58183 RVA: 0x004CCFC0 File Offset: 0x004CB1C0
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				get
				{
					return BusMessage.Descriptor.NestedTypes[1];
				}
			}

			// Token: 0x170039B3 RID: 14771
			// (get) Token: 0x0600E348 RID: 58184 RVA: 0x004CCFE4 File Offset: 0x004CB1E4
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor
			{
				get
				{
					return BusMessage.Types.EncryptedBusMessage.Descriptor;
				}
			}

			// Token: 0x0600E349 RID: 58185 RVA: 0x004CCFFB File Offset: 0x004CB1FB
			[DebuggerNonUserCode]
			public EncryptedBusMessage()
			{
			}

			// Token: 0x0600E34A RID: 58186 RVA: 0x004CD008 File Offset: 0x004CB208
			[DebuggerNonUserCode]
			public EncryptedBusMessage(BusMessage.Types.EncryptedBusMessage other)
				: this()
			{
				this._hasBits0 = other._hasBits0;
				this.type_ = other.type_;
				this.data_ = other.data_;
				this.iv_ = other.iv_;
				this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			// Token: 0x0600E34B RID: 58187 RVA: 0x004CD060 File Offset: 0x004CB260
			[DebuggerNonUserCode]
			public BusMessage.Types.EncryptedBusMessage Clone()
			{
				return new BusMessage.Types.EncryptedBusMessage(this);
			}

			// Token: 0x170039B4 RID: 14772
			// (get) Token: 0x0600E34C RID: 58188 RVA: 0x004CD078 File Offset: 0x004CB278
			// (set) Token: 0x0600E34D RID: 58189 RVA: 0x004CD0A9 File Offset: 0x004CB2A9
			[DebuggerNonUserCode]
			public BusMessage.Types.EncryptedBusMessage.Types.EncryptionType Type
			{
				get
				{
					bool flag = (this._hasBits0 & 1) != 0;
					BusMessage.Types.EncryptedBusMessage.Types.EncryptionType typeDefaultValue;
					if (flag)
					{
						typeDefaultValue = this.type_;
					}
					else
					{
						typeDefaultValue = BusMessage.Types.EncryptedBusMessage.TypeDefaultValue;
					}
					return typeDefaultValue;
				}
				set
				{
					this._hasBits0 |= 1;
					this.type_ = value;
				}
			}

			// Token: 0x170039B5 RID: 14773
			// (get) Token: 0x0600E34E RID: 58190 RVA: 0x004CD0C4 File Offset: 0x004CB2C4
			[DebuggerNonUserCode]
			public bool HasType
			{
				get
				{
					return (this._hasBits0 & 1) != 0;
				}
			}

			// Token: 0x0600E34F RID: 58191 RVA: 0x004CD0E1 File Offset: 0x004CB2E1
			[DebuggerNonUserCode]
			public void ClearType()
			{
				this._hasBits0 &= -2;
			}

			// Token: 0x170039B6 RID: 14774
			// (get) Token: 0x0600E350 RID: 58192 RVA: 0x004CD0F4 File Offset: 0x004CB2F4
			// (set) Token: 0x0600E351 RID: 58193 RVA: 0x004CD115 File Offset: 0x004CB315
			[DebuggerNonUserCode]
			public ByteString Data
			{
				get
				{
					return this.data_ ?? BusMessage.Types.EncryptedBusMessage.DataDefaultValue;
				}
				set
				{
					this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
				}
			}

			// Token: 0x170039B7 RID: 14775
			// (get) Token: 0x0600E352 RID: 58194 RVA: 0x004CD12C File Offset: 0x004CB32C
			[DebuggerNonUserCode]
			public bool HasData
			{
				get
				{
					return this.data_ != null;
				}
			}

			// Token: 0x0600E353 RID: 58195 RVA: 0x004CD14A File Offset: 0x004CB34A
			[DebuggerNonUserCode]
			public void ClearData()
			{
				this.data_ = null;
			}

			// Token: 0x170039B8 RID: 14776
			// (get) Token: 0x0600E354 RID: 58196 RVA: 0x004CD154 File Offset: 0x004CB354
			// (set) Token: 0x0600E355 RID: 58197 RVA: 0x004CD175 File Offset: 0x004CB375
			[DebuggerNonUserCode]
			public ByteString Iv
			{
				get
				{
					return this.iv_ ?? BusMessage.Types.EncryptedBusMessage.IvDefaultValue;
				}
				set
				{
					this.iv_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
				}
			}

			// Token: 0x170039B9 RID: 14777
			// (get) Token: 0x0600E356 RID: 58198 RVA: 0x004CD18C File Offset: 0x004CB38C
			[DebuggerNonUserCode]
			public bool HasIv
			{
				get
				{
					return this.iv_ != null;
				}
			}

			// Token: 0x0600E357 RID: 58199 RVA: 0x004CD1AA File Offset: 0x004CB3AA
			[DebuggerNonUserCode]
			public void ClearIv()
			{
				this.iv_ = null;
			}

			// Token: 0x0600E358 RID: 58200 RVA: 0x004CD1B4 File Offset: 0x004CB3B4
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return this.Equals(other as BusMessage.Types.EncryptedBusMessage);
			}

			// Token: 0x0600E359 RID: 58201 RVA: 0x004CD1D4 File Offset: 0x004CB3D4
			[DebuggerNonUserCode]
			public bool Equals(BusMessage.Types.EncryptedBusMessage other)
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
						bool flag4 = this.Type != other.Type;
						if (flag4)
						{
							flag2 = false;
						}
						else
						{
							bool flag5 = this.Data != other.Data;
							if (flag5)
							{
								flag2 = false;
							}
							else
							{
								bool flag6 = this.Iv != other.Iv;
								flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
				return flag2;
			}

			// Token: 0x0600E35A RID: 58202 RVA: 0x004CD260 File Offset: 0x004CB460
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				bool hasType = this.HasType;
				if (hasType)
				{
					num ^= this.Type.GetHashCode();
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					num ^= this.Data.GetHashCode();
				}
				bool hasIv = this.HasIv;
				if (hasIv)
				{
					num ^= this.Iv.GetHashCode();
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num ^= this._unknownFields.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600E35B RID: 58203 RVA: 0x004CD2EC File Offset: 0x004CB4EC
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return JsonFormatter.ToDiagnosticString(this);
			}

			// Token: 0x0600E35C RID: 58204 RVA: 0x004CD304 File Offset: 0x004CB504
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			// Token: 0x0600E35D RID: 58205 RVA: 0x004CD310 File Offset: 0x004CB510
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				bool hasType = this.HasType;
				if (hasType)
				{
					output.WriteRawTag(8);
					output.WriteEnum((int)this.Type);
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					output.WriteRawTag(18);
					output.WriteBytes(this.Data);
				}
				bool hasIv = this.HasIv;
				if (hasIv)
				{
					output.WriteRawTag(26);
					output.WriteBytes(this.Iv);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					this._unknownFields.WriteTo(ref output);
				}
			}

			// Token: 0x0600E35E RID: 58206 RVA: 0x004CD3A0 File Offset: 0x004CB5A0
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				bool hasType = this.HasType;
				if (hasType)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
				}
				bool hasData = this.HasData;
				if (hasData)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
				}
				bool hasIv = this.HasIv;
				if (hasIv)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Iv);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num += this._unknownFields.CalculateSize();
				}
				return num;
			}

			// Token: 0x0600E35F RID: 58207 RVA: 0x004CD42C File Offset: 0x004CB62C
			[DebuggerNonUserCode]
			public void MergeFrom(BusMessage.Types.EncryptedBusMessage other)
			{
				bool flag = other == null;
				if (!flag)
				{
					bool hasType = other.HasType;
					if (hasType)
					{
						this.Type = other.Type;
					}
					bool hasData = other.HasData;
					if (hasData)
					{
						this.Data = other.Data;
					}
					bool hasIv = other.HasIv;
					if (hasIv)
					{
						this.Iv = other.Iv;
					}
					this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
				}
			}

			// Token: 0x0600E360 RID: 58208 RVA: 0x004CD4A7 File Offset: 0x004CB6A7
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				input.ReadRawMessage(this);
			}

			// Token: 0x0600E361 RID: 58209 RVA: 0x004CD4B4 File Offset: 0x004CB6B4
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
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
							else
							{
								this.Iv = input.ReadBytes();
							}
						}
						else
						{
							this.Data = input.ReadBytes();
						}
					}
					else
					{
						this.Type = (BusMessage.Types.EncryptedBusMessage.Types.EncryptionType)input.ReadEnum();
					}
				}
			}

			// Token: 0x0400A242 RID: 41538
			private static readonly MessageParser<BusMessage.Types.EncryptedBusMessage> _parser = new MessageParser<BusMessage.Types.EncryptedBusMessage>(() => new BusMessage.Types.EncryptedBusMessage());

			// Token: 0x0400A243 RID: 41539
			private UnknownFieldSet _unknownFields;

			// Token: 0x0400A244 RID: 41540
			private int _hasBits0;

			// Token: 0x0400A245 RID: 41541
			public const int TypeFieldNumber = 1;

			// Token: 0x0400A246 RID: 41542
			private static readonly BusMessage.Types.EncryptedBusMessage.Types.EncryptionType TypeDefaultValue = BusMessage.Types.EncryptedBusMessage.Types.EncryptionType.None;

			// Token: 0x0400A247 RID: 41543
			private BusMessage.Types.EncryptedBusMessage.Types.EncryptionType type_;

			// Token: 0x0400A248 RID: 41544
			public const int DataFieldNumber = 2;

			// Token: 0x0400A249 RID: 41545
			private static readonly ByteString DataDefaultValue = ByteString.Empty;

			// Token: 0x0400A24A RID: 41546
			private ByteString data_;

			// Token: 0x0400A24B RID: 41547
			public const int IvFieldNumber = 3;

			// Token: 0x0400A24C RID: 41548
			private static readonly ByteString IvDefaultValue = ByteString.Empty;

			// Token: 0x0400A24D RID: 41549
			private ByteString iv_;

			// Token: 0x020014B5 RID: 5301
			[DebuggerNonUserCode]
			public static class Types
			{
				// Token: 0x020014E0 RID: 5344
				public enum EncryptionType
				{
					// Token: 0x0400A5D6 RID: 42454
					[OriginalName("NONE")]
					None = 1,
					// Token: 0x0400A5D7 RID: 42455
					[OriginalName("RSA")]
					Rsa,
					// Token: 0x0400A5D8 RID: 42456
					[OriginalName("AES")]
					Aes
				}
			}
		}

		// Token: 0x0200145C RID: 5212
		public sealed class Status : IMessage<BusMessage.Types.Status>, IMessage, IEquatable<BusMessage.Types.Status>, IDeepCloneable<BusMessage.Types.Status>, IBufferMessage
		{
			// Token: 0x170039BA RID: 14778
			// (get) Token: 0x0600E363 RID: 58211 RVA: 0x004CD568 File Offset: 0x004CB768
			[DebuggerNonUserCode]
			public static MessageParser<BusMessage.Types.Status> Parser
			{
				get
				{
					return BusMessage.Types.Status._parser;
				}
			}

			// Token: 0x170039BB RID: 14779
			// (get) Token: 0x0600E364 RID: 58212 RVA: 0x004CD580 File Offset: 0x004CB780
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				get
				{
					return BusMessage.Descriptor.NestedTypes[2];
				}
			}

			// Token: 0x170039BC RID: 14780
			// (get) Token: 0x0600E365 RID: 58213 RVA: 0x004CD5A4 File Offset: 0x004CB7A4
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor
			{
				get
				{
					return BusMessage.Types.Status.Descriptor;
				}
			}

			// Token: 0x0600E366 RID: 58214 RVA: 0x004CD5BB File Offset: 0x004CB7BB
			[DebuggerNonUserCode]
			public Status()
			{
			}

			// Token: 0x0600E367 RID: 58215 RVA: 0x004CD5C5 File Offset: 0x004CB7C5
			[DebuggerNonUserCode]
			public Status(BusMessage.Types.Status other)
				: this()
			{
				this._hasBits0 = other._hasBits0;
				this.code_ = other.code_;
				this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			// Token: 0x0600E368 RID: 58216 RVA: 0x004CD5F8 File Offset: 0x004CB7F8
			[DebuggerNonUserCode]
			public BusMessage.Types.Status Clone()
			{
				return new BusMessage.Types.Status(this);
			}

			// Token: 0x170039BD RID: 14781
			// (get) Token: 0x0600E369 RID: 58217 RVA: 0x004CD610 File Offset: 0x004CB810
			// (set) Token: 0x0600E36A RID: 58218 RVA: 0x004CD641 File Offset: 0x004CB841
			[DebuggerNonUserCode]
			public BusMessage.Types.Status.Types.Code Code
			{
				get
				{
					bool flag = (this._hasBits0 & 1) != 0;
					BusMessage.Types.Status.Types.Code codeDefaultValue;
					if (flag)
					{
						codeDefaultValue = this.code_;
					}
					else
					{
						codeDefaultValue = BusMessage.Types.Status.CodeDefaultValue;
					}
					return codeDefaultValue;
				}
				set
				{
					this._hasBits0 |= 1;
					this.code_ = value;
				}
			}

			// Token: 0x170039BE RID: 14782
			// (get) Token: 0x0600E36B RID: 58219 RVA: 0x004CD65C File Offset: 0x004CB85C
			[DebuggerNonUserCode]
			public bool HasCode
			{
				get
				{
					return (this._hasBits0 & 1) != 0;
				}
			}

			// Token: 0x0600E36C RID: 58220 RVA: 0x004CD679 File Offset: 0x004CB879
			[DebuggerNonUserCode]
			public void ClearCode()
			{
				this._hasBits0 &= -2;
			}

			// Token: 0x0600E36D RID: 58221 RVA: 0x004CD68C File Offset: 0x004CB88C
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return this.Equals(other as BusMessage.Types.Status);
			}

			// Token: 0x0600E36E RID: 58222 RVA: 0x004CD6AC File Offset: 0x004CB8AC
			[DebuggerNonUserCode]
			public bool Equals(BusMessage.Types.Status other)
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
						bool flag4 = this.Code != other.Code;
						flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
				return flag2;
			}

			// Token: 0x0600E36F RID: 58223 RVA: 0x004CD704 File Offset: 0x004CB904
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				bool hasCode = this.HasCode;
				if (hasCode)
				{
					num ^= this.Code.GetHashCode();
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num ^= this._unknownFields.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600E370 RID: 58224 RVA: 0x004CD75C File Offset: 0x004CB95C
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return JsonFormatter.ToDiagnosticString(this);
			}

			// Token: 0x0600E371 RID: 58225 RVA: 0x004CD774 File Offset: 0x004CB974
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			// Token: 0x0600E372 RID: 58226 RVA: 0x004CD780 File Offset: 0x004CB980
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				bool hasCode = this.HasCode;
				if (hasCode)
				{
					output.WriteRawTag(8);
					output.WriteEnum((int)this.Code);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					this._unknownFields.WriteTo(ref output);
				}
			}

			// Token: 0x0600E373 RID: 58227 RVA: 0x004CD7CC File Offset: 0x004CB9CC
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				bool hasCode = this.HasCode;
				if (hasCode)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num += this._unknownFields.CalculateSize();
				}
				return num;
			}

			// Token: 0x0600E374 RID: 58228 RVA: 0x004CD81C File Offset: 0x004CBA1C
			[DebuggerNonUserCode]
			public void MergeFrom(BusMessage.Types.Status other)
			{
				bool flag = other == null;
				if (!flag)
				{
					bool hasCode = other.HasCode;
					if (hasCode)
					{
						this.Code = other.Code;
					}
					this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
				}
			}

			// Token: 0x0600E375 RID: 58229 RVA: 0x004CD865 File Offset: 0x004CBA65
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				input.ReadRawMessage(this);
			}

			// Token: 0x0600E376 RID: 58230 RVA: 0x004CD870 File Offset: 0x004CBA70
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (BusMessage.Types.Status.Types.Code)input.ReadEnum();
					}
				}
			}

			// Token: 0x0400A24E RID: 41550
			private static readonly MessageParser<BusMessage.Types.Status> _parser = new MessageParser<BusMessage.Types.Status>(() => new BusMessage.Types.Status());

			// Token: 0x0400A24F RID: 41551
			private UnknownFieldSet _unknownFields;

			// Token: 0x0400A250 RID: 41552
			private int _hasBits0;

			// Token: 0x0400A251 RID: 41553
			public const int CodeFieldNumber = 1;

			// Token: 0x0400A252 RID: 41554
			private static readonly BusMessage.Types.Status.Types.Code CodeDefaultValue = BusMessage.Types.Status.Types.Code.Received;

			// Token: 0x0400A253 RID: 41555
			private BusMessage.Types.Status.Types.Code code_;

			// Token: 0x020014B7 RID: 5303
			[DebuggerNonUserCode]
			public static class Types
			{
				// Token: 0x020014E1 RID: 5345
				public enum Code
				{
					// Token: 0x0400A5DA RID: 42458
					[OriginalName("Received")]
					Received = 1,
					// Token: 0x0400A5DB RID: 42459
					[OriginalName("Completed")]
					Completed,
					// Token: 0x0400A5DC RID: 42460
					[OriginalName("AddressCollision")]
					AddressCollision
				}
			}
		}

		// Token: 0x0200145D RID: 5213
		public sealed class Peer : IMessage<BusMessage.Types.Peer>, IMessage, IEquatable<BusMessage.Types.Peer>, IDeepCloneable<BusMessage.Types.Peer>, IBufferMessage
		{
			// Token: 0x170039BF RID: 14783
			// (get) Token: 0x0600E378 RID: 58232 RVA: 0x004CD8E4 File Offset: 0x004CBAE4
			[DebuggerNonUserCode]
			public static MessageParser<BusMessage.Types.Peer> Parser
			{
				get
				{
					return BusMessage.Types.Peer._parser;
				}
			}

			// Token: 0x170039C0 RID: 14784
			// (get) Token: 0x0600E379 RID: 58233 RVA: 0x004CD8FC File Offset: 0x004CBAFC
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				get
				{
					return BusMessage.Descriptor.NestedTypes[3];
				}
			}

			// Token: 0x170039C1 RID: 14785
			// (get) Token: 0x0600E37A RID: 58234 RVA: 0x004CD920 File Offset: 0x004CBB20
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor
			{
				get
				{
					return BusMessage.Types.Peer.Descriptor;
				}
			}

			// Token: 0x0600E37B RID: 58235 RVA: 0x004CD937 File Offset: 0x004CBB37
			[DebuggerNonUserCode]
			public Peer()
			{
			}

			// Token: 0x0600E37C RID: 58236 RVA: 0x004CD944 File Offset: 0x004CBB44
			[DebuggerNonUserCode]
			public Peer(BusMessage.Types.Peer other)
				: this()
			{
				this._hasBits0 = other._hasBits0;
				this.system_ = other.system_;
				this.module_ = other.module_;
				this.session_ = other.session_;
				this.username_ = other.username_;
				this.pid_ = other.pid_;
				this.isElevated_ = other.isElevated_;
				this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			// Token: 0x0600E37D RID: 58237 RVA: 0x004CD9C0 File Offset: 0x004CBBC0
			[DebuggerNonUserCode]
			public BusMessage.Types.Peer Clone()
			{
				return new BusMessage.Types.Peer(this);
			}

			// Token: 0x170039C2 RID: 14786
			// (get) Token: 0x0600E37E RID: 58238 RVA: 0x004CD9D8 File Offset: 0x004CBBD8
			// (set) Token: 0x0600E37F RID: 58239 RVA: 0x004CD9F9 File Offset: 0x004CBBF9
			[DebuggerNonUserCode]
			public string System
			{
				get
				{
					return this.system_ ?? BusMessage.Types.Peer.SystemDefaultValue;
				}
				set
				{
					this.system_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				}
			}

			// Token: 0x170039C3 RID: 14787
			// (get) Token: 0x0600E380 RID: 58240 RVA: 0x004CDA10 File Offset: 0x004CBC10
			[DebuggerNonUserCode]
			public bool HasSystem
			{
				get
				{
					return this.system_ != null;
				}
			}

			// Token: 0x0600E381 RID: 58241 RVA: 0x004CDA2B File Offset: 0x004CBC2B
			[DebuggerNonUserCode]
			public void ClearSystem()
			{
				this.system_ = null;
			}

			// Token: 0x170039C4 RID: 14788
			// (get) Token: 0x0600E382 RID: 58242 RVA: 0x004CDA38 File Offset: 0x004CBC38
			// (set) Token: 0x0600E383 RID: 58243 RVA: 0x004CDA59 File Offset: 0x004CBC59
			[DebuggerNonUserCode]
			public string Module
			{
				get
				{
					return this.module_ ?? BusMessage.Types.Peer.ModuleDefaultValue;
				}
				set
				{
					this.module_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				}
			}

			// Token: 0x170039C5 RID: 14789
			// (get) Token: 0x0600E384 RID: 58244 RVA: 0x004CDA70 File Offset: 0x004CBC70
			[DebuggerNonUserCode]
			public bool HasModule
			{
				get
				{
					return this.module_ != null;
				}
			}

			// Token: 0x0600E385 RID: 58245 RVA: 0x004CDA8B File Offset: 0x004CBC8B
			[DebuggerNonUserCode]
			public void ClearModule()
			{
				this.module_ = null;
			}

			// Token: 0x170039C6 RID: 14790
			// (get) Token: 0x0600E386 RID: 58246 RVA: 0x004CDA98 File Offset: 0x004CBC98
			// (set) Token: 0x0600E387 RID: 58247 RVA: 0x004CDAB9 File Offset: 0x004CBCB9
			[DebuggerNonUserCode]
			public string Session
			{
				get
				{
					return this.session_ ?? BusMessage.Types.Peer.SessionDefaultValue;
				}
				set
				{
					this.session_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				}
			}

			// Token: 0x170039C7 RID: 14791
			// (get) Token: 0x0600E388 RID: 58248 RVA: 0x004CDAD0 File Offset: 0x004CBCD0
			[DebuggerNonUserCode]
			public bool HasSession
			{
				get
				{
					return this.session_ != null;
				}
			}

			// Token: 0x0600E389 RID: 58249 RVA: 0x004CDAEB File Offset: 0x004CBCEB
			[DebuggerNonUserCode]
			public void ClearSession()
			{
				this.session_ = null;
			}

			// Token: 0x170039C8 RID: 14792
			// (get) Token: 0x0600E38A RID: 58250 RVA: 0x004CDAF8 File Offset: 0x004CBCF8
			// (set) Token: 0x0600E38B RID: 58251 RVA: 0x004CDB19 File Offset: 0x004CBD19
			[DebuggerNonUserCode]
			public string Username
			{
				get
				{
					return this.username_ ?? BusMessage.Types.Peer.UsernameDefaultValue;
				}
				set
				{
					this.username_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				}
			}

			// Token: 0x170039C9 RID: 14793
			// (get) Token: 0x0600E38C RID: 58252 RVA: 0x004CDB30 File Offset: 0x004CBD30
			[DebuggerNonUserCode]
			public bool HasUsername
			{
				get
				{
					return this.username_ != null;
				}
			}

			// Token: 0x0600E38D RID: 58253 RVA: 0x004CDB4B File Offset: 0x004CBD4B
			[DebuggerNonUserCode]
			public void ClearUsername()
			{
				this.username_ = null;
			}

			// Token: 0x170039CA RID: 14794
			// (get) Token: 0x0600E38E RID: 58254 RVA: 0x004CDB58 File Offset: 0x004CBD58
			// (set) Token: 0x0600E38F RID: 58255 RVA: 0x004CDB89 File Offset: 0x004CBD89
			[DebuggerNonUserCode]
			public uint Pid
			{
				get
				{
					bool flag = (this._hasBits0 & 1) != 0;
					uint pidDefaultValue;
					if (flag)
					{
						pidDefaultValue = this.pid_;
					}
					else
					{
						pidDefaultValue = BusMessage.Types.Peer.PidDefaultValue;
					}
					return pidDefaultValue;
				}
				set
				{
					this._hasBits0 |= 1;
					this.pid_ = value;
				}
			}

			// Token: 0x170039CB RID: 14795
			// (get) Token: 0x0600E390 RID: 58256 RVA: 0x004CDBA4 File Offset: 0x004CBDA4
			[DebuggerNonUserCode]
			public bool HasPid
			{
				get
				{
					return (this._hasBits0 & 1) != 0;
				}
			}

			// Token: 0x0600E391 RID: 58257 RVA: 0x004CDBC1 File Offset: 0x004CBDC1
			[DebuggerNonUserCode]
			public void ClearPid()
			{
				this._hasBits0 &= -2;
			}

			// Token: 0x170039CC RID: 14796
			// (get) Token: 0x0600E392 RID: 58258 RVA: 0x004CDBD4 File Offset: 0x004CBDD4
			// (set) Token: 0x0600E393 RID: 58259 RVA: 0x004CDC05 File Offset: 0x004CBE05
			[DebuggerNonUserCode]
			public bool IsElevated
			{
				get
				{
					bool flag = (this._hasBits0 & 2) != 0;
					bool isElevatedDefaultValue;
					if (flag)
					{
						isElevatedDefaultValue = this.isElevated_;
					}
					else
					{
						isElevatedDefaultValue = BusMessage.Types.Peer.IsElevatedDefaultValue;
					}
					return isElevatedDefaultValue;
				}
				set
				{
					this._hasBits0 |= 2;
					this.isElevated_ = value;
				}
			}

			// Token: 0x170039CD RID: 14797
			// (get) Token: 0x0600E394 RID: 58260 RVA: 0x004CDC20 File Offset: 0x004CBE20
			[DebuggerNonUserCode]
			public bool HasIsElevated
			{
				get
				{
					return (this._hasBits0 & 2) != 0;
				}
			}

			// Token: 0x0600E395 RID: 58261 RVA: 0x004CDC3D File Offset: 0x004CBE3D
			[DebuggerNonUserCode]
			public void ClearIsElevated()
			{
				this._hasBits0 &= -3;
			}

			// Token: 0x0600E396 RID: 58262 RVA: 0x004CDC50 File Offset: 0x004CBE50
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return this.Equals(other as BusMessage.Types.Peer);
			}

			// Token: 0x0600E397 RID: 58263 RVA: 0x004CDC70 File Offset: 0x004CBE70
			[DebuggerNonUserCode]
			public bool Equals(BusMessage.Types.Peer other)
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
						bool flag4 = this.System != other.System;
						if (flag4)
						{
							flag2 = false;
						}
						else
						{
							bool flag5 = this.Module != other.Module;
							if (flag5)
							{
								flag2 = false;
							}
							else
							{
								bool flag6 = this.Session != other.Session;
								if (flag6)
								{
									flag2 = false;
								}
								else
								{
									bool flag7 = this.Username != other.Username;
									if (flag7)
									{
										flag2 = false;
									}
									else
									{
										bool flag8 = this.Pid != other.Pid;
										if (flag8)
										{
											flag2 = false;
										}
										else
										{
											bool flag9 = this.IsElevated != other.IsElevated;
											flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
				return flag2;
			}

			// Token: 0x0600E398 RID: 58264 RVA: 0x004CDD5C File Offset: 0x004CBF5C
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				bool hasSystem = this.HasSystem;
				if (hasSystem)
				{
					num ^= this.System.GetHashCode();
				}
				bool hasModule = this.HasModule;
				if (hasModule)
				{
					num ^= this.Module.GetHashCode();
				}
				bool hasSession = this.HasSession;
				if (hasSession)
				{
					num ^= this.Session.GetHashCode();
				}
				bool hasUsername = this.HasUsername;
				if (hasUsername)
				{
					num ^= this.Username.GetHashCode();
				}
				bool hasPid = this.HasPid;
				if (hasPid)
				{
					num ^= this.Pid.GetHashCode();
				}
				bool hasIsElevated = this.HasIsElevated;
				if (hasIsElevated)
				{
					num ^= this.IsElevated.GetHashCode();
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num ^= this._unknownFields.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600E399 RID: 58265 RVA: 0x004CDE30 File Offset: 0x004CC030
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return JsonFormatter.ToDiagnosticString(this);
			}

			// Token: 0x0600E39A RID: 58266 RVA: 0x004CDE48 File Offset: 0x004CC048
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			// Token: 0x0600E39B RID: 58267 RVA: 0x004CDE54 File Offset: 0x004CC054
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				bool hasSystem = this.HasSystem;
				if (hasSystem)
				{
					output.WriteRawTag(10);
					output.WriteString(this.System);
				}
				bool hasModule = this.HasModule;
				if (hasModule)
				{
					output.WriteRawTag(18);
					output.WriteString(this.Module);
				}
				bool hasSession = this.HasSession;
				if (hasSession)
				{
					output.WriteRawTag(26);
					output.WriteString(this.Session);
				}
				bool hasUsername = this.HasUsername;
				if (hasUsername)
				{
					output.WriteRawTag(34);
					output.WriteString(this.Username);
				}
				bool hasPid = this.HasPid;
				if (hasPid)
				{
					output.WriteRawTag(40);
					output.WriteUInt32(this.Pid);
				}
				bool hasIsElevated = this.HasIsElevated;
				if (hasIsElevated)
				{
					output.WriteRawTag(48);
					output.WriteBool(this.IsElevated);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					this._unknownFields.WriteTo(ref output);
				}
			}

			// Token: 0x0600E39C RID: 58268 RVA: 0x004CDF50 File Offset: 0x004CC150
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				bool hasSystem = this.HasSystem;
				if (hasSystem)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(this.System);
				}
				bool hasModule = this.HasModule;
				if (hasModule)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(this.Module);
				}
				bool hasSession = this.HasSession;
				if (hasSession)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(this.Session);
				}
				bool hasUsername = this.HasUsername;
				if (hasUsername)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(this.Username);
				}
				bool hasPid = this.HasPid;
				if (hasPid)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pid);
				}
				bool hasIsElevated = this.HasIsElevated;
				if (hasIsElevated)
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

			// Token: 0x0600E39D RID: 58269 RVA: 0x004CE028 File Offset: 0x004CC228
			[DebuggerNonUserCode]
			public void MergeFrom(BusMessage.Types.Peer other)
			{
				bool flag = other == null;
				if (!flag)
				{
					bool hasSystem = other.HasSystem;
					if (hasSystem)
					{
						this.System = other.System;
					}
					bool hasModule = other.HasModule;
					if (hasModule)
					{
						this.Module = other.Module;
					}
					bool hasSession = other.HasSession;
					if (hasSession)
					{
						this.Session = other.Session;
					}
					bool hasUsername = other.HasUsername;
					if (hasUsername)
					{
						this.Username = other.Username;
					}
					bool hasPid = other.HasPid;
					if (hasPid)
					{
						this.Pid = other.Pid;
					}
					bool hasIsElevated = other.HasIsElevated;
					if (hasIsElevated)
					{
						this.IsElevated = other.IsElevated;
					}
					this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
				}
			}

			// Token: 0x0600E39E RID: 58270 RVA: 0x004CE0F7 File Offset: 0x004CC2F7
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				input.ReadRawMessage(this);
			}

			// Token: 0x0600E39F RID: 58271 RVA: 0x004CE104 File Offset: 0x004CC304
			[DebuggerNonUserCode]
			void IBufferMessage.InternalMergeFrom(ref ParseContext input)
			{
				uint num;
				while ((num = input.ReadTag()) > 0U)
				{
					uint num2 = num;
					uint num3 = num2;
					if (num3 <= 26U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_003A;
								}
								this.Session = input.ReadString();
							}
							else
							{
								this.Module = input.ReadString();
							}
						}
						else
						{
							this.System = input.ReadString();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_003A;
							}
							this.IsElevated = input.ReadBool();
						}
						else
						{
							this.Pid = input.ReadUInt32();
						}
					}
					else
					{
						this.Username = input.ReadString();
					}
					continue;
					IL_003A:
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
			}

			// Token: 0x0400A254 RID: 41556
			private static readonly MessageParser<BusMessage.Types.Peer> _parser = new MessageParser<BusMessage.Types.Peer>(() => new BusMessage.Types.Peer());

			// Token: 0x0400A255 RID: 41557
			private UnknownFieldSet _unknownFields;

			// Token: 0x0400A256 RID: 41558
			private int _hasBits0;

			// Token: 0x0400A257 RID: 41559
			public const int SystemFieldNumber = 1;

			// Token: 0x0400A258 RID: 41560
			private static readonly string SystemDefaultValue = "";

			// Token: 0x0400A259 RID: 41561
			private string system_;

			// Token: 0x0400A25A RID: 41562
			public const int ModuleFieldNumber = 2;

			// Token: 0x0400A25B RID: 41563
			private static readonly string ModuleDefaultValue = "";

			// Token: 0x0400A25C RID: 41564
			private string module_;

			// Token: 0x0400A25D RID: 41565
			public const int SessionFieldNumber = 3;

			// Token: 0x0400A25E RID: 41566
			private static readonly string SessionDefaultValue = "";

			// Token: 0x0400A25F RID: 41567
			private string session_;

			// Token: 0x0400A260 RID: 41568
			public const int UsernameFieldNumber = 4;

			// Token: 0x0400A261 RID: 41569
			private static readonly string UsernameDefaultValue = "";

			// Token: 0x0400A262 RID: 41570
			private string username_;

			// Token: 0x0400A263 RID: 41571
			public const int PidFieldNumber = 5;

			// Token: 0x0400A264 RID: 41572
			private static readonly uint PidDefaultValue = 0U;

			// Token: 0x0400A265 RID: 41573
			private uint pid_;

			// Token: 0x0400A266 RID: 41574
			public const int IsElevatedFieldNumber = 6;

			// Token: 0x0400A267 RID: 41575
			private static readonly bool IsElevatedDefaultValue = false;

			// Token: 0x0400A268 RID: 41576
			private bool isElevated_;
		}

		// Token: 0x0200145E RID: 5214
		public sealed class EncryptionSetup : IMessage<BusMessage.Types.EncryptionSetup>, IMessage, IEquatable<BusMessage.Types.EncryptionSetup>, IDeepCloneable<BusMessage.Types.EncryptionSetup>, IBufferMessage
		{
			// Token: 0x170039CE RID: 14798
			// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x004CE230 File Offset: 0x004CC430
			[DebuggerNonUserCode]
			public static MessageParser<BusMessage.Types.EncryptionSetup> Parser
			{
				get
				{
					return BusMessage.Types.EncryptionSetup._parser;
				}
			}

			// Token: 0x170039CF RID: 14799
			// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x004CE248 File Offset: 0x004CC448
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				get
				{
					return BusMessage.Descriptor.NestedTypes[4];
				}
			}

			// Token: 0x170039D0 RID: 14800
			// (get) Token: 0x0600E3A3 RID: 58275 RVA: 0x004CE26C File Offset: 0x004CC46C
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor
			{
				get
				{
					return BusMessage.Types.EncryptionSetup.Descriptor;
				}
			}

			// Token: 0x0600E3A4 RID: 58276 RVA: 0x004CE283 File Offset: 0x004CC483
			[DebuggerNonUserCode]
			public EncryptionSetup()
			{
			}

			// Token: 0x0600E3A5 RID: 58277 RVA: 0x004CE28D File Offset: 0x004CC48D
			[DebuggerNonUserCode]
			public EncryptionSetup(BusMessage.Types.EncryptionSetup other)
				: this()
			{
				this.aESKey_ = other.aESKey_;
				this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			// Token: 0x0600E3A6 RID: 58278 RVA: 0x004CE2B4 File Offset: 0x004CC4B4
			[DebuggerNonUserCode]
			public BusMessage.Types.EncryptionSetup Clone()
			{
				return new BusMessage.Types.EncryptionSetup(this);
			}

			// Token: 0x170039D1 RID: 14801
			// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x004CE2CC File Offset: 0x004CC4CC
			// (set) Token: 0x0600E3A8 RID: 58280 RVA: 0x004CE2ED File Offset: 0x004CC4ED
			[DebuggerNonUserCode]
			public ByteString AESKey
			{
				get
				{
					return this.aESKey_ ?? BusMessage.Types.EncryptionSetup.AESKeyDefaultValue;
				}
				set
				{
					this.aESKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
				}
			}

			// Token: 0x170039D2 RID: 14802
			// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x004CE304 File Offset: 0x004CC504
			[DebuggerNonUserCode]
			public bool HasAESKey
			{
				get
				{
					return this.aESKey_ != null;
				}
			}

			// Token: 0x0600E3AA RID: 58282 RVA: 0x004CE322 File Offset: 0x004CC522
			[DebuggerNonUserCode]
			public void ClearAESKey()
			{
				this.aESKey_ = null;
			}

			// Token: 0x0600E3AB RID: 58283 RVA: 0x004CE32C File Offset: 0x004CC52C
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return this.Equals(other as BusMessage.Types.EncryptionSetup);
			}

			// Token: 0x0600E3AC RID: 58284 RVA: 0x004CE34C File Offset: 0x004CC54C
			[DebuggerNonUserCode]
			public bool Equals(BusMessage.Types.EncryptionSetup other)
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
						bool flag4 = this.AESKey != other.AESKey;
						flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
				return flag2;
			}

			// Token: 0x0600E3AD RID: 58285 RVA: 0x004CE3A4 File Offset: 0x004CC5A4
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				bool hasAESKey = this.HasAESKey;
				if (hasAESKey)
				{
					num ^= this.AESKey.GetHashCode();
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num ^= this._unknownFields.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600E3AE RID: 58286 RVA: 0x004CE3F0 File Offset: 0x004CC5F0
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return JsonFormatter.ToDiagnosticString(this);
			}

			// Token: 0x0600E3AF RID: 58287 RVA: 0x004CE408 File Offset: 0x004CC608
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			// Token: 0x0600E3B0 RID: 58288 RVA: 0x004CE414 File Offset: 0x004CC614
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				bool hasAESKey = this.HasAESKey;
				if (hasAESKey)
				{
					output.WriteRawTag(10);
					output.WriteBytes(this.AESKey);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					this._unknownFields.WriteTo(ref output);
				}
			}

			// Token: 0x0600E3B1 RID: 58289 RVA: 0x004CE460 File Offset: 0x004CC660
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				bool hasAESKey = this.HasAESKey;
				if (hasAESKey)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(this.AESKey);
				}
				bool flag = this._unknownFields != null;
				if (flag)
				{
					num += this._unknownFields.CalculateSize();
				}
				return num;
			}

			// Token: 0x0600E3B2 RID: 58290 RVA: 0x004CE4B0 File Offset: 0x004CC6B0
			[DebuggerNonUserCode]
			public void MergeFrom(BusMessage.Types.EncryptionSetup other)
			{
				bool flag = other == null;
				if (!flag)
				{
					bool hasAESKey = other.HasAESKey;
					if (hasAESKey)
					{
						this.AESKey = other.AESKey;
					}
					this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
				}
			}

			// Token: 0x0600E3B3 RID: 58291 RVA: 0x004CE4F9 File Offset: 0x004CC6F9
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				input.ReadRawMessage(this);
			}

			// Token: 0x0600E3B4 RID: 58292 RVA: 0x004CE504 File Offset: 0x004CC704
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AESKey = input.ReadBytes();
					}
				}
			}

			// Token: 0x0400A269 RID: 41577
			private static readonly MessageParser<BusMessage.Types.EncryptionSetup> _parser = new MessageParser<BusMessage.Types.EncryptionSetup>(() => new BusMessage.Types.EncryptionSetup());

			// Token: 0x0400A26A RID: 41578
			private UnknownFieldSet _unknownFields;

			// Token: 0x0400A26B RID: 41579
			public const int AESKeyFieldNumber = 1;

			// Token: 0x0400A26C RID: 41580
			private static readonly ByteString AESKeyDefaultValue = ByteString.Empty;

			// Token: 0x0400A26D RID: 41581
			private ByteString aESKey_;
		}
	}
}
