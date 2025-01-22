using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000391 RID: 913
	public sealed class Header : IMessage<Header>, IMessage, IEquatable<Header>, IDeepCloneable<Header>, IBufferMessage
	{
		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x00166150 File Offset: 0x00164350
		[DebuggerNonUserCode]
		public static MessageParser<Header> Parser
		{
			get
			{
				return Header._parser;
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06005C9E RID: 23710 RVA: 0x00166168 File Offset: 0x00164368
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06005C9F RID: 23711 RVA: 0x0016618C File Offset: 0x0016438C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Header.Descriptor;
			}
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x001661A3 File Offset: 0x001643A3
		[DebuggerNonUserCode]
		public Header()
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x001661DC File Offset: 0x001643DC
		[DebuggerNonUserCode]
		public Header(Header other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serviceId_ = other.serviceId_;
			this.methodId_ = other.methodId_;
			this.token_ = other.token_;
			this.objectId_ = other.objectId_;
			this.size_ = other.size_;
			this.status_ = other.status_;
			this.error_ = other.error_.Clone();
			this.timeout_ = other.timeout_;
			this.isResponse_ = other.isResponse_;
			this.forwardTargets_ = other.forwardTargets_.Clone();
			this.serviceHash_ = other.serviceHash_;
			this.requestId_ = other.requestId_;
			this.clientId_ = other.clientId_;
			this.fanoutTarget_ = other.fanoutTarget_.Clone();
			this.clientIdFanoutTarget_ = other.clientIdFanoutTarget_.Clone();
			this.clientRecord_ = other.clientRecord_;
			this.originalSender_ = other.originalSender_;
			this.senderToken_ = other.senderToken_;
			this.routerLabel_ = other.routerLabel_;
			this.errorReason_ = other.errorReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00166314 File Offset: 0x00164514
		[DebuggerNonUserCode]
		public Header Clone()
		{
			return new Header(this);
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x0016632C File Offset: 0x0016452C
		// (set) Token: 0x06005CA4 RID: 23716 RVA: 0x0016635D File Offset: 0x0016455D
		[DebuggerNonUserCode]
		public uint ServiceId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint serviceIdDefaultValue;
				if (flag)
				{
					serviceIdDefaultValue = this.serviceId_;
				}
				else
				{
					serviceIdDefaultValue = Header.ServiceIdDefaultValue;
				}
				return serviceIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.serviceId_ = value;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06005CA5 RID: 23717 RVA: 0x00166378 File Offset: 0x00164578
		[DebuggerNonUserCode]
		public bool HasServiceId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x00166395 File Offset: 0x00164595
		[DebuggerNonUserCode]
		public void ClearServiceId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x001663A8 File Offset: 0x001645A8
		// (set) Token: 0x06005CA8 RID: 23720 RVA: 0x001663D9 File Offset: 0x001645D9
		[DebuggerNonUserCode]
		public uint MethodId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint methodIdDefaultValue;
				if (flag)
				{
					methodIdDefaultValue = this.methodId_;
				}
				else
				{
					methodIdDefaultValue = Header.MethodIdDefaultValue;
				}
				return methodIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.methodId_ = value;
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06005CA9 RID: 23721 RVA: 0x001663F4 File Offset: 0x001645F4
		[DebuggerNonUserCode]
		public bool HasMethodId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00166411 File Offset: 0x00164611
		[DebuggerNonUserCode]
		public void ClearMethodId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06005CAB RID: 23723 RVA: 0x00166424 File Offset: 0x00164624
		// (set) Token: 0x06005CAC RID: 23724 RVA: 0x00166455 File Offset: 0x00164655
		[DebuggerNonUserCode]
		public uint Token
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = Header.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.token_ = value;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x00166470 File Offset: 0x00164670
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x0016648D File Offset: 0x0016468D
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x001664A0 File Offset: 0x001646A0
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x001664D1 File Offset: 0x001646D1
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = Header.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.objectId_ = value;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x001664EC File Offset: 0x001646EC
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00166509 File Offset: 0x00164709
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x0016651C File Offset: 0x0016471C
		// (set) Token: 0x06005CB4 RID: 23732 RVA: 0x0016654E File Offset: 0x0016474E
		[DebuggerNonUserCode]
		public uint Size
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint sizeDefaultValue;
				if (flag)
				{
					sizeDefaultValue = this.size_;
				}
				else
				{
					sizeDefaultValue = Header.SizeDefaultValue;
				}
				return sizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.size_ = value;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x00166568 File Offset: 0x00164768
		[DebuggerNonUserCode]
		public bool HasSize
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x00166586 File Offset: 0x00164786
		[DebuggerNonUserCode]
		public void ClearSize()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x00166598 File Offset: 0x00164798
		// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x001665CA File Offset: 0x001647CA
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = Header.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.status_ = value;
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x001665E4 File Offset: 0x001647E4
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x00166602 File Offset: 0x00164802
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06005CBB RID: 23739 RVA: 0x00166614 File Offset: 0x00164814
		[DebuggerNonUserCode]
		public RepeatedField<ErrorInfo> Error
		{
			get
			{
				return this.error_;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06005CBC RID: 23740 RVA: 0x0016662C File Offset: 0x0016482C
		// (set) Token: 0x06005CBD RID: 23741 RVA: 0x0016665E File Offset: 0x0016485E
		[DebuggerNonUserCode]
		public ulong Timeout
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong timeoutDefaultValue;
				if (flag)
				{
					timeoutDefaultValue = this.timeout_;
				}
				else
				{
					timeoutDefaultValue = Header.TimeoutDefaultValue;
				}
				return timeoutDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.timeout_ = value;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x00166678 File Offset: 0x00164878
		[DebuggerNonUserCode]
		public bool HasTimeout
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00166696 File Offset: 0x00164896
		[DebuggerNonUserCode]
		public void ClearTimeout()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x001666A8 File Offset: 0x001648A8
		// (set) Token: 0x06005CC1 RID: 23745 RVA: 0x001666DD File Offset: 0x001648DD
		[DebuggerNonUserCode]
		public bool IsResponse
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool isResponseDefaultValue;
				if (flag)
				{
					isResponseDefaultValue = this.isResponse_;
				}
				else
				{
					isResponseDefaultValue = Header.IsResponseDefaultValue;
				}
				return isResponseDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.isResponse_ = value;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x001666FC File Offset: 0x001648FC
		[DebuggerNonUserCode]
		public bool HasIsResponse
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x0016671D File Offset: 0x0016491D
		[DebuggerNonUserCode]
		public void ClearIsResponse()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06005CC4 RID: 23748 RVA: 0x00166734 File Offset: 0x00164934
		[DebuggerNonUserCode]
		public RepeatedField<ProcessId> ForwardTargets
		{
			get
			{
				return this.forwardTargets_;
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x0016674C File Offset: 0x0016494C
		// (set) Token: 0x06005CC6 RID: 23750 RVA: 0x00166781 File Offset: 0x00164981
		[DebuggerNonUserCode]
		public uint ServiceHash
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint serviceHashDefaultValue;
				if (flag)
				{
					serviceHashDefaultValue = this.serviceHash_;
				}
				else
				{
					serviceHashDefaultValue = Header.ServiceHashDefaultValue;
				}
				return serviceHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.serviceHash_ = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x001667A0 File Offset: 0x001649A0
		[DebuggerNonUserCode]
		public bool HasServiceHash
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x001667C1 File Offset: 0x001649C1
		[DebuggerNonUserCode]
		public void ClearServiceHash()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x001667D8 File Offset: 0x001649D8
		// (set) Token: 0x06005CCA RID: 23754 RVA: 0x001667F9 File Offset: 0x001649F9
		[DebuggerNonUserCode]
		public string RequestId
		{
			get
			{
				return this.requestId_ ?? Header.RequestIdDefaultValue;
			}
			set
			{
				this.requestId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x00166810 File Offset: 0x00164A10
		[DebuggerNonUserCode]
		public bool HasRequestId
		{
			get
			{
				return this.requestId_ != null;
			}
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x0016682B File Offset: 0x00164A2B
		[DebuggerNonUserCode]
		public void ClearRequestId()
		{
			this.requestId_ = null;
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06005CCD RID: 23757 RVA: 0x00166838 File Offset: 0x00164A38
		// (set) Token: 0x06005CCE RID: 23758 RVA: 0x00166859 File Offset: 0x00164A59
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? Header.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x00166870 File Offset: 0x00164A70
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x0016688B File Offset: 0x00164A8B
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06005CD1 RID: 23761 RVA: 0x00166898 File Offset: 0x00164A98
		[DebuggerNonUserCode]
		public RepeatedField<FanoutTarget> FanoutTarget
		{
			get
			{
				return this.fanoutTarget_;
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06005CD2 RID: 23762 RVA: 0x001668B0 File Offset: 0x00164AB0
		[DebuggerNonUserCode]
		public RepeatedField<string> ClientIdFanoutTarget
		{
			get
			{
				return this.clientIdFanoutTarget_;
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x001668C8 File Offset: 0x00164AC8
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x001668E9 File Offset: 0x00164AE9
		[DebuggerNonUserCode]
		public ByteString ClientRecord
		{
			get
			{
				return this.clientRecord_ ?? Header.ClientRecordDefaultValue;
			}
			set
			{
				this.clientRecord_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x00166900 File Offset: 0x00164B00
		[DebuggerNonUserCode]
		public bool HasClientRecord
		{
			get
			{
				return this.clientRecord_ != null;
			}
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x0016691E File Offset: 0x00164B1E
		[DebuggerNonUserCode]
		public void ClearClientRecord()
		{
			this.clientRecord_ = null;
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x00166928 File Offset: 0x00164B28
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x00166949 File Offset: 0x00164B49
		[DebuggerNonUserCode]
		public ByteString OriginalSender
		{
			get
			{
				return this.originalSender_ ?? Header.OriginalSenderDefaultValue;
			}
			set
			{
				this.originalSender_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06005CD9 RID: 23769 RVA: 0x00166960 File Offset: 0x00164B60
		[DebuggerNonUserCode]
		public bool HasOriginalSender
		{
			get
			{
				return this.originalSender_ != null;
			}
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x0016697E File Offset: 0x00164B7E
		[DebuggerNonUserCode]
		public void ClearOriginalSender()
		{
			this.originalSender_ = null;
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x00166988 File Offset: 0x00164B88
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x001669BD File Offset: 0x00164BBD
		[DebuggerNonUserCode]
		public uint SenderToken
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint senderTokenDefaultValue;
				if (flag)
				{
					senderTokenDefaultValue = this.senderToken_;
				}
				else
				{
					senderTokenDefaultValue = Header.SenderTokenDefaultValue;
				}
				return senderTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.senderToken_ = value;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x001669DC File Offset: 0x00164BDC
		[DebuggerNonUserCode]
		public bool HasSenderToken
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x001669FD File Offset: 0x00164BFD
		[DebuggerNonUserCode]
		public void ClearSenderToken()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06005CDF RID: 23775 RVA: 0x00166A14 File Offset: 0x00164C14
		// (set) Token: 0x06005CE0 RID: 23776 RVA: 0x00166A49 File Offset: 0x00164C49
		[DebuggerNonUserCode]
		public uint RouterLabel
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint routerLabelDefaultValue;
				if (flag)
				{
					routerLabelDefaultValue = this.routerLabel_;
				}
				else
				{
					routerLabelDefaultValue = Header.RouterLabelDefaultValue;
				}
				return routerLabelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.routerLabel_ = value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x00166A68 File Offset: 0x00164C68
		[DebuggerNonUserCode]
		public bool HasRouterLabel
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x00166A89 File Offset: 0x00164C89
		[DebuggerNonUserCode]
		public void ClearRouterLabel()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x00166AA0 File Offset: 0x00164CA0
		// (set) Token: 0x06005CE4 RID: 23780 RVA: 0x00166AC1 File Offset: 0x00164CC1
		[DebuggerNonUserCode]
		public string ErrorReason
		{
			get
			{
				return this.errorReason_ ?? Header.ErrorReasonDefaultValue;
			}
			set
			{
				this.errorReason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x00166AD8 File Offset: 0x00164CD8
		[DebuggerNonUserCode]
		public bool HasErrorReason
		{
			get
			{
				return this.errorReason_ != null;
			}
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x00166AF3 File Offset: 0x00164CF3
		[DebuggerNonUserCode]
		public void ClearErrorReason()
		{
			this.errorReason_ = null;
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x00166B00 File Offset: 0x00164D00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Header);
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x00166B20 File Offset: 0x00164D20
		[DebuggerNonUserCode]
		public bool Equals(Header other)
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
					bool flag4 = this.ServiceId != other.ServiceId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MethodId != other.MethodId;
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
								bool flag7 = this.ObjectId != other.ObjectId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Size != other.Size;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Status != other.Status;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.error_.Equals(other.error_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Timeout != other.Timeout;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.IsResponse != other.IsResponse;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.forwardTargets_.Equals(other.forwardTargets_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ServiceHash != other.ServiceHash;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.RequestId != other.RequestId;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.ClientId != other.ClientId;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.fanoutTarget_.Equals(other.fanoutTarget_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !this.clientIdFanoutTarget_.Equals(other.clientIdFanoutTarget_);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.ClientRecord != other.ClientRecord;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.OriginalSender != other.OriginalSender;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.SenderToken != other.SenderToken;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.RouterLabel != other.RouterLabel;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.ErrorReason != other.ErrorReason;
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

		// Token: 0x06005CE9 RID: 23785 RVA: 0x00166DBC File Offset: 0x00164FBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				num ^= this.ServiceId.GetHashCode();
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				num ^= this.MethodId.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				num ^= this.Size.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.error_.GetHashCode();
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num ^= this.Timeout.GetHashCode();
			}
			bool hasIsResponse = this.HasIsResponse;
			if (hasIsResponse)
			{
				num ^= this.IsResponse.GetHashCode();
			}
			num ^= this.forwardTargets_.GetHashCode();
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				num ^= this.ServiceHash.GetHashCode();
			}
			bool hasRequestId = this.HasRequestId;
			if (hasRequestId)
			{
				num ^= this.RequestId.GetHashCode();
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			num ^= this.fanoutTarget_.GetHashCode();
			num ^= this.clientIdFanoutTarget_.GetHashCode();
			bool hasClientRecord = this.HasClientRecord;
			if (hasClientRecord)
			{
				num ^= this.ClientRecord.GetHashCode();
			}
			bool hasOriginalSender = this.HasOriginalSender;
			if (hasOriginalSender)
			{
				num ^= this.OriginalSender.GetHashCode();
			}
			bool hasSenderToken = this.HasSenderToken;
			if (hasSenderToken)
			{
				num ^= this.SenderToken.GetHashCode();
			}
			bool hasRouterLabel = this.HasRouterLabel;
			if (hasRouterLabel)
			{
				num ^= this.RouterLabel.GetHashCode();
			}
			bool hasErrorReason = this.HasErrorReason;
			if (hasErrorReason)
			{
				num ^= this.ErrorReason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x00166FEC File Offset: 0x001651EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x00167004 File Offset: 0x00165204
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00167010 File Offset: 0x00165210
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ServiceId);
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MethodId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Token);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ObjectId);
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Size);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Status);
			}
			this.error_.WriteTo(ref output, Header._repeated_error_codec);
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.Timeout);
			}
			bool hasIsResponse = this.HasIsResponse;
			if (hasIsResponse)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsResponse);
			}
			this.forwardTargets_.WriteTo(ref output, Header._repeated_forwardTargets_codec);
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				output.WriteRawTag(93);
				output.WriteFixed32(this.ServiceHash);
			}
			bool hasRequestId = this.HasRequestId;
			if (hasRequestId)
			{
				output.WriteRawTag(98);
				output.WriteString(this.RequestId);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(106);
				output.WriteString(this.ClientId);
			}
			this.fanoutTarget_.WriteTo(ref output, Header._repeated_fanoutTarget_codec);
			this.clientIdFanoutTarget_.WriteTo(ref output, Header._repeated_clientIdFanoutTarget_codec);
			bool hasClientRecord = this.HasClientRecord;
			if (hasClientRecord)
			{
				output.WriteRawTag(130, 1);
				output.WriteBytes(this.ClientRecord);
			}
			bool hasOriginalSender = this.HasOriginalSender;
			if (hasOriginalSender)
			{
				output.WriteRawTag(138, 1);
				output.WriteBytes(this.OriginalSender);
			}
			bool hasSenderToken = this.HasSenderToken;
			if (hasSenderToken)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.SenderToken);
			}
			bool hasRouterLabel = this.HasRouterLabel;
			if (hasRouterLabel)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt32(this.RouterLabel);
			}
			bool hasErrorReason = this.HasErrorReason;
			if (hasErrorReason)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.ErrorReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x001672D0 File Offset: 0x001654D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceId);
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MethodId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Token);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Size);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			num += this.error_.CalculateSize(Header._repeated_error_codec);
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Timeout);
			}
			bool hasIsResponse = this.HasIsResponse;
			if (hasIsResponse)
			{
				num += 2;
			}
			num += this.forwardTargets_.CalculateSize(Header._repeated_forwardTargets_codec);
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				num += 5;
			}
			bool hasRequestId = this.HasRequestId;
			if (hasRequestId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequestId);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			num += this.fanoutTarget_.CalculateSize(Header._repeated_fanoutTarget_codec);
			num += this.clientIdFanoutTarget_.CalculateSize(Header._repeated_clientIdFanoutTarget_codec);
			bool hasClientRecord = this.HasClientRecord;
			if (hasClientRecord)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.ClientRecord);
			}
			bool hasOriginalSender = this.HasOriginalSender;
			if (hasOriginalSender)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.OriginalSender);
			}
			bool hasSenderToken = this.HasSenderToken;
			if (hasSenderToken)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SenderToken);
			}
			bool hasRouterLabel = this.HasRouterLabel;
			if (hasRouterLabel)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.RouterLabel);
			}
			bool hasErrorReason = this.HasErrorReason;
			if (hasErrorReason)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ErrorReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00167514 File Offset: 0x00165714
		[DebuggerNonUserCode]
		public void MergeFrom(Header other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasServiceId = other.HasServiceId;
				if (hasServiceId)
				{
					this.ServiceId = other.ServiceId;
				}
				bool hasMethodId = other.HasMethodId;
				if (hasMethodId)
				{
					this.MethodId = other.MethodId;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				bool hasSize = other.HasSize;
				if (hasSize)
				{
					this.Size = other.Size;
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this.error_.Add(other.error_);
				bool hasTimeout = other.HasTimeout;
				if (hasTimeout)
				{
					this.Timeout = other.Timeout;
				}
				bool hasIsResponse = other.HasIsResponse;
				if (hasIsResponse)
				{
					this.IsResponse = other.IsResponse;
				}
				this.forwardTargets_.Add(other.forwardTargets_);
				bool hasServiceHash = other.HasServiceHash;
				if (hasServiceHash)
				{
					this.ServiceHash = other.ServiceHash;
				}
				bool hasRequestId = other.HasRequestId;
				if (hasRequestId)
				{
					this.RequestId = other.RequestId;
				}
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				this.fanoutTarget_.Add(other.fanoutTarget_);
				this.clientIdFanoutTarget_.Add(other.clientIdFanoutTarget_);
				bool hasClientRecord = other.HasClientRecord;
				if (hasClientRecord)
				{
					this.ClientRecord = other.ClientRecord;
				}
				bool hasOriginalSender = other.HasOriginalSender;
				if (hasOriginalSender)
				{
					this.OriginalSender = other.OriginalSender;
				}
				bool hasSenderToken = other.HasSenderToken;
				if (hasSenderToken)
				{
					this.SenderToken = other.SenderToken;
				}
				bool hasRouterLabel = other.HasRouterLabel;
				if (hasRouterLabel)
				{
					this.RouterLabel = other.RouterLabel;
				}
				bool hasErrorReason = other.HasErrorReason;
				if (hasErrorReason)
				{
					this.ErrorReason = other.ErrorReason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x00167739 File Offset: 0x00165939
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00167744 File Offset: 0x00165944
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
						if (num3 <= 16U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0113;
								}
								this.MethodId = input.ReadUInt32();
							}
							else
							{
								this.ServiceId = input.ReadUInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								if (num3 != 40U)
								{
									goto IL_0113;
								}
								this.Size = input.ReadUInt32();
							}
							else
							{
								this.ObjectId = input.ReadUInt64();
							}
						}
						else
						{
							this.Token = input.ReadUInt32();
						}
					}
					else if (num3 <= 58U)
					{
						if (num3 != 48U)
						{
							if (num3 != 58U)
							{
								goto IL_0113;
							}
							this.error_.AddEntriesFrom(ref input, Header._repeated_error_codec);
						}
						else
						{
							this.Status = input.ReadUInt32();
						}
					}
					else if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							if (num3 != 82U)
							{
								goto IL_0113;
							}
							this.forwardTargets_.AddEntriesFrom(ref input, Header._repeated_forwardTargets_codec);
						}
						else
						{
							this.IsResponse = input.ReadBool();
						}
					}
					else
					{
						this.Timeout = input.ReadUInt64();
					}
				}
				else if (num3 <= 122U)
				{
					if (num3 <= 98U)
					{
						if (num3 != 93U)
						{
							if (num3 != 98U)
							{
								goto IL_0113;
							}
							this.RequestId = input.ReadString();
						}
						else
						{
							this.ServiceHash = input.ReadFixed32();
						}
					}
					else if (num3 != 106U)
					{
						if (num3 != 114U)
						{
							if (num3 != 122U)
							{
								goto IL_0113;
							}
							this.clientIdFanoutTarget_.AddEntriesFrom(ref input, Header._repeated_clientIdFanoutTarget_codec);
						}
						else
						{
							this.fanoutTarget_.AddEntriesFrom(ref input, Header._repeated_fanoutTarget_codec);
						}
					}
					else
					{
						this.ClientId = input.ReadString();
					}
				}
				else if (num3 <= 138U)
				{
					if (num3 != 130U)
					{
						if (num3 != 138U)
						{
							goto IL_0113;
						}
						this.OriginalSender = input.ReadBytes();
					}
					else
					{
						this.ClientRecord = input.ReadBytes();
					}
				}
				else if (num3 != 144U)
				{
					if (num3 != 152U)
					{
						if (num3 != 162U)
						{
							goto IL_0113;
						}
						this.ErrorReason = input.ReadString();
					}
					else
					{
						this.RouterLabel = input.ReadUInt32();
					}
				}
				else
				{
					this.SenderToken = input.ReadUInt32();
				}
				continue;
				IL_0113:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A44 RID: 10820
		private static readonly MessageParser<Header> _parser = new MessageParser<Header>(() => new Header());

		// Token: 0x04002A45 RID: 10821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A46 RID: 10822
		private int _hasBits0;

		// Token: 0x04002A47 RID: 10823
		public const int ServiceIdFieldNumber = 1;

		// Token: 0x04002A48 RID: 10824
		private static readonly uint ServiceIdDefaultValue = 0U;

		// Token: 0x04002A49 RID: 10825
		private uint serviceId_;

		// Token: 0x04002A4A RID: 10826
		public const int MethodIdFieldNumber = 2;

		// Token: 0x04002A4B RID: 10827
		private static readonly uint MethodIdDefaultValue = 0U;

		// Token: 0x04002A4C RID: 10828
		private uint methodId_;

		// Token: 0x04002A4D RID: 10829
		public const int TokenFieldNumber = 3;

		// Token: 0x04002A4E RID: 10830
		private static readonly uint TokenDefaultValue = 0U;

		// Token: 0x04002A4F RID: 10831
		private uint token_;

		// Token: 0x04002A50 RID: 10832
		public const int ObjectIdFieldNumber = 4;

		// Token: 0x04002A51 RID: 10833
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04002A52 RID: 10834
		private ulong objectId_;

		// Token: 0x04002A53 RID: 10835
		public const int SizeFieldNumber = 5;

		// Token: 0x04002A54 RID: 10836
		private static readonly uint SizeDefaultValue = 0U;

		// Token: 0x04002A55 RID: 10837
		private uint size_;

		// Token: 0x04002A56 RID: 10838
		public const int StatusFieldNumber = 6;

		// Token: 0x04002A57 RID: 10839
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04002A58 RID: 10840
		private uint status_;

		// Token: 0x04002A59 RID: 10841
		public const int ErrorFieldNumber = 7;

		// Token: 0x04002A5A RID: 10842
		private static readonly FieldCodec<ErrorInfo> _repeated_error_codec = FieldCodec.ForMessage<ErrorInfo>(58U, ErrorInfo.Parser);

		// Token: 0x04002A5B RID: 10843
		private readonly RepeatedField<ErrorInfo> error_ = new RepeatedField<ErrorInfo>();

		// Token: 0x04002A5C RID: 10844
		public const int TimeoutFieldNumber = 8;

		// Token: 0x04002A5D RID: 10845
		private static readonly ulong TimeoutDefaultValue = 0UL;

		// Token: 0x04002A5E RID: 10846
		private ulong timeout_;

		// Token: 0x04002A5F RID: 10847
		public const int IsResponseFieldNumber = 9;

		// Token: 0x04002A60 RID: 10848
		private static readonly bool IsResponseDefaultValue = false;

		// Token: 0x04002A61 RID: 10849
		private bool isResponse_;

		// Token: 0x04002A62 RID: 10850
		public const int ForwardTargetsFieldNumber = 10;

		// Token: 0x04002A63 RID: 10851
		private static readonly FieldCodec<ProcessId> _repeated_forwardTargets_codec = FieldCodec.ForMessage<ProcessId>(82U, ProcessId.Parser);

		// Token: 0x04002A64 RID: 10852
		private readonly RepeatedField<ProcessId> forwardTargets_ = new RepeatedField<ProcessId>();

		// Token: 0x04002A65 RID: 10853
		public const int ServiceHashFieldNumber = 11;

		// Token: 0x04002A66 RID: 10854
		private static readonly uint ServiceHashDefaultValue = 0U;

		// Token: 0x04002A67 RID: 10855
		private uint serviceHash_;

		// Token: 0x04002A68 RID: 10856
		public const int RequestIdFieldNumber = 12;

		// Token: 0x04002A69 RID: 10857
		private static readonly string RequestIdDefaultValue = "";

		// Token: 0x04002A6A RID: 10858
		private string requestId_;

		// Token: 0x04002A6B RID: 10859
		public const int ClientIdFieldNumber = 13;

		// Token: 0x04002A6C RID: 10860
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x04002A6D RID: 10861
		private string clientId_;

		// Token: 0x04002A6E RID: 10862
		public const int FanoutTargetFieldNumber = 14;

		// Token: 0x04002A6F RID: 10863
		private static readonly FieldCodec<FanoutTarget> _repeated_fanoutTarget_codec = FieldCodec.ForMessage<FanoutTarget>(114U, Bgs.Protocol.FanoutTarget.Parser);

		// Token: 0x04002A70 RID: 10864
		private readonly RepeatedField<FanoutTarget> fanoutTarget_ = new RepeatedField<FanoutTarget>();

		// Token: 0x04002A71 RID: 10865
		public const int ClientIdFanoutTargetFieldNumber = 15;

		// Token: 0x04002A72 RID: 10866
		private static readonly FieldCodec<string> _repeated_clientIdFanoutTarget_codec = FieldCodec.ForString(122U);

		// Token: 0x04002A73 RID: 10867
		private readonly RepeatedField<string> clientIdFanoutTarget_ = new RepeatedField<string>();

		// Token: 0x04002A74 RID: 10868
		public const int ClientRecordFieldNumber = 16;

		// Token: 0x04002A75 RID: 10869
		private static readonly ByteString ClientRecordDefaultValue = ByteString.Empty;

		// Token: 0x04002A76 RID: 10870
		private ByteString clientRecord_;

		// Token: 0x04002A77 RID: 10871
		public const int OriginalSenderFieldNumber = 17;

		// Token: 0x04002A78 RID: 10872
		private static readonly ByteString OriginalSenderDefaultValue = ByteString.Empty;

		// Token: 0x04002A79 RID: 10873
		private ByteString originalSender_;

		// Token: 0x04002A7A RID: 10874
		public const int SenderTokenFieldNumber = 18;

		// Token: 0x04002A7B RID: 10875
		private static readonly uint SenderTokenDefaultValue = 0U;

		// Token: 0x04002A7C RID: 10876
		private uint senderToken_;

		// Token: 0x04002A7D RID: 10877
		public const int RouterLabelFieldNumber = 19;

		// Token: 0x04002A7E RID: 10878
		private static readonly uint RouterLabelDefaultValue = 0U;

		// Token: 0x04002A7F RID: 10879
		private uint routerLabel_;

		// Token: 0x04002A80 RID: 10880
		public const int ErrorReasonFieldNumber = 20;

		// Token: 0x04002A81 RID: 10881
		private static readonly string ErrorReasonDefaultValue = "";

		// Token: 0x04002A82 RID: 10882
		private string errorReason_;
	}
}
