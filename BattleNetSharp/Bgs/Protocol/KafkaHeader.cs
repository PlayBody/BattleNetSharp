using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000392 RID: 914
	public sealed class KafkaHeader : IMessage<KafkaHeader>, IMessage, IEquatable<KafkaHeader>, IDeepCloneable<KafkaHeader>, IBufferMessage
	{
		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x00167AE4 File Offset: 0x00165CE4
		[DebuggerNonUserCode]
		public static MessageParser<KafkaHeader> Parser
		{
			get
			{
				return KafkaHeader._parser;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x00167AFC File Offset: 0x00165CFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x00167B20 File Offset: 0x00165D20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KafkaHeader.Descriptor;
			}
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x00167B37 File Offset: 0x00165D37
		[DebuggerNonUserCode]
		public KafkaHeader()
		{
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00167B44 File Offset: 0x00165D44
		[DebuggerNonUserCode]
		public KafkaHeader(KafkaHeader other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serviceHash_ = other.serviceHash_;
			this.methodId_ = other.methodId_;
			this.token_ = other.token_;
			this.objectId_ = other.objectId_;
			this.size_ = other.size_;
			this.status_ = other.status_;
			this.timeout_ = other.timeout_;
			this.forwardTarget_ = ((other.forwardTarget_ != null) ? other.forwardTarget_.Clone() : null);
			this.returnTopic_ = other.returnTopic_;
			this.clientId_ = other.clientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00167C00 File Offset: 0x00165E00
		[DebuggerNonUserCode]
		public KafkaHeader Clone()
		{
			return new KafkaHeader(this);
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00167C18 File Offset: 0x00165E18
		// (set) Token: 0x06005CF9 RID: 23801 RVA: 0x00167C49 File Offset: 0x00165E49
		[DebuggerNonUserCode]
		public uint ServiceHash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint serviceHashDefaultValue;
				if (flag)
				{
					serviceHashDefaultValue = this.serviceHash_;
				}
				else
				{
					serviceHashDefaultValue = KafkaHeader.ServiceHashDefaultValue;
				}
				return serviceHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.serviceHash_ = value;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x00167C64 File Offset: 0x00165E64
		[DebuggerNonUserCode]
		public bool HasServiceHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00167C81 File Offset: 0x00165E81
		[DebuggerNonUserCode]
		public void ClearServiceHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x00167C94 File Offset: 0x00165E94
		// (set) Token: 0x06005CFD RID: 23805 RVA: 0x00167CC5 File Offset: 0x00165EC5
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
					methodIdDefaultValue = KafkaHeader.MethodIdDefaultValue;
				}
				return methodIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.methodId_ = value;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06005CFE RID: 23806 RVA: 0x00167CE0 File Offset: 0x00165EE0
		[DebuggerNonUserCode]
		public bool HasMethodId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x00167CFD File Offset: 0x00165EFD
		[DebuggerNonUserCode]
		public void ClearMethodId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x00167D10 File Offset: 0x00165F10
		// (set) Token: 0x06005D01 RID: 23809 RVA: 0x00167D41 File Offset: 0x00165F41
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
					tokenDefaultValue = KafkaHeader.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.token_ = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06005D02 RID: 23810 RVA: 0x00167D5C File Offset: 0x00165F5C
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x00167D79 File Offset: 0x00165F79
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06005D04 RID: 23812 RVA: 0x00167D8C File Offset: 0x00165F8C
		// (set) Token: 0x06005D05 RID: 23813 RVA: 0x00167DBD File Offset: 0x00165FBD
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
					objectIdDefaultValue = KafkaHeader.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.objectId_ = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06005D06 RID: 23814 RVA: 0x00167DD8 File Offset: 0x00165FD8
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x00167DF5 File Offset: 0x00165FF5
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06005D08 RID: 23816 RVA: 0x00167E08 File Offset: 0x00166008
		// (set) Token: 0x06005D09 RID: 23817 RVA: 0x00167E3A File Offset: 0x0016603A
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
					sizeDefaultValue = KafkaHeader.SizeDefaultValue;
				}
				return sizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.size_ = value;
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06005D0A RID: 23818 RVA: 0x00167E54 File Offset: 0x00166054
		[DebuggerNonUserCode]
		public bool HasSize
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x00167E72 File Offset: 0x00166072
		[DebuggerNonUserCode]
		public void ClearSize()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x00167E84 File Offset: 0x00166084
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x00167EB6 File Offset: 0x001660B6
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
					statusDefaultValue = KafkaHeader.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.status_ = value;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x00167ED0 File Offset: 0x001660D0
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x00167EEE File Offset: 0x001660EE
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x00167F00 File Offset: 0x00166100
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x00167F32 File Offset: 0x00166132
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
					timeoutDefaultValue = KafkaHeader.TimeoutDefaultValue;
				}
				return timeoutDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.timeout_ = value;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x00167F4C File Offset: 0x0016614C
		[DebuggerNonUserCode]
		public bool HasTimeout
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x00167F6A File Offset: 0x0016616A
		[DebuggerNonUserCode]
		public void ClearTimeout()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x00167F7C File Offset: 0x0016617C
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x00167F94 File Offset: 0x00166194
		[DebuggerNonUserCode]
		public ProcessId ForwardTarget
		{
			get
			{
				return this.forwardTarget_;
			}
			set
			{
				this.forwardTarget_ = value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x00167FA0 File Offset: 0x001661A0
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x00167FC1 File Offset: 0x001661C1
		[DebuggerNonUserCode]
		public string ReturnTopic
		{
			get
			{
				return this.returnTopic_ ?? KafkaHeader.ReturnTopicDefaultValue;
			}
			set
			{
				this.returnTopic_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06005D18 RID: 23832 RVA: 0x00167FD8 File Offset: 0x001661D8
		[DebuggerNonUserCode]
		public bool HasReturnTopic
		{
			get
			{
				return this.returnTopic_ != null;
			}
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x00167FF3 File Offset: 0x001661F3
		[DebuggerNonUserCode]
		public void ClearReturnTopic()
		{
			this.returnTopic_ = null;
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x00168000 File Offset: 0x00166200
		// (set) Token: 0x06005D1B RID: 23835 RVA: 0x00168021 File Offset: 0x00166221
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? KafkaHeader.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x00168038 File Offset: 0x00166238
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00168053 File Offset: 0x00166253
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x00168060 File Offset: 0x00166260
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KafkaHeader);
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x00168080 File Offset: 0x00166280
		[DebuggerNonUserCode]
		public bool Equals(KafkaHeader other)
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
					bool flag4 = this.ServiceHash != other.ServiceHash;
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
											bool flag10 = this.Timeout != other.Timeout;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ForwardTarget, other.ForwardTarget);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ReturnTopic != other.ReturnTopic;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.ClientId != other.ClientId;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06005D20 RID: 23840 RVA: 0x001681E4 File Offset: 0x001663E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num ^= this.Timeout.GetHashCode();
			}
			bool flag = this.forwardTarget_ != null;
			if (flag)
			{
				num ^= this.ForwardTarget.GetHashCode();
			}
			bool hasReturnTopic = this.HasReturnTopic;
			if (hasReturnTopic)
			{
				num ^= this.ReturnTopic.GetHashCode();
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x00168334 File Offset: 0x00166534
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x0016834C File Offset: 0x0016654C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00168358 File Offset: 0x00166558
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.ServiceHash);
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
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.Timeout);
			}
			bool flag = this.forwardTarget_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ForwardTarget);
			}
			bool hasReturnTopic = this.HasReturnTopic;
			if (hasReturnTopic)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ReturnTopic);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x001684E8 File Offset: 0x001666E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				num += 5;
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
			bool hasTimeout = this.HasTimeout;
			if (hasTimeout)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Timeout);
			}
			bool flag = this.forwardTarget_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ForwardTarget);
			}
			bool hasReturnTopic = this.HasReturnTopic;
			if (hasReturnTopic)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReturnTopic);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x0016863C File Offset: 0x0016683C
		[DebuggerNonUserCode]
		public void MergeFrom(KafkaHeader other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasTimeout = other.HasTimeout;
				if (hasTimeout)
				{
					this.Timeout = other.Timeout;
				}
				bool flag2 = other.forwardTarget_ != null;
				if (flag2)
				{
					bool flag3 = this.forwardTarget_ == null;
					if (flag3)
					{
						this.ForwardTarget = new ProcessId();
					}
					this.ForwardTarget.MergeFrom(other.ForwardTarget);
				}
				bool hasReturnTopic = other.HasReturnTopic;
				if (hasReturnTopic)
				{
					this.ReturnTopic = other.ReturnTopic;
				}
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x0016879C File Offset: 0x0016699C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x001687A8 File Offset: 0x001669A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 13U)
						{
							if (num3 != 16U)
							{
								goto IL_007B;
							}
							this.MethodId = input.ReadUInt32();
						}
						else
						{
							this.ServiceHash = input.ReadFixed32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_007B;
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
				else if (num3 <= 56U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_007B;
						}
						this.Timeout = input.ReadUInt64();
					}
					else
					{
						this.Status = input.ReadUInt32();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						if (num3 != 90U)
						{
							goto IL_007B;
						}
						this.ClientId = input.ReadString();
					}
					else
					{
						this.ReturnTopic = input.ReadString();
					}
				}
				else
				{
					bool flag = this.forwardTarget_ == null;
					if (flag)
					{
						this.ForwardTarget = new ProcessId();
					}
					input.ReadMessage(this.ForwardTarget);
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A83 RID: 10883
		private static readonly MessageParser<KafkaHeader> _parser = new MessageParser<KafkaHeader>(() => new KafkaHeader());

		// Token: 0x04002A84 RID: 10884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A85 RID: 10885
		private int _hasBits0;

		// Token: 0x04002A86 RID: 10886
		public const int ServiceHashFieldNumber = 1;

		// Token: 0x04002A87 RID: 10887
		private static readonly uint ServiceHashDefaultValue = 0U;

		// Token: 0x04002A88 RID: 10888
		private uint serviceHash_;

		// Token: 0x04002A89 RID: 10889
		public const int MethodIdFieldNumber = 2;

		// Token: 0x04002A8A RID: 10890
		private static readonly uint MethodIdDefaultValue = 0U;

		// Token: 0x04002A8B RID: 10891
		private uint methodId_;

		// Token: 0x04002A8C RID: 10892
		public const int TokenFieldNumber = 3;

		// Token: 0x04002A8D RID: 10893
		private static readonly uint TokenDefaultValue = 0U;

		// Token: 0x04002A8E RID: 10894
		private uint token_;

		// Token: 0x04002A8F RID: 10895
		public const int ObjectIdFieldNumber = 4;

		// Token: 0x04002A90 RID: 10896
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04002A91 RID: 10897
		private ulong objectId_;

		// Token: 0x04002A92 RID: 10898
		public const int SizeFieldNumber = 5;

		// Token: 0x04002A93 RID: 10899
		private static readonly uint SizeDefaultValue = 0U;

		// Token: 0x04002A94 RID: 10900
		private uint size_;

		// Token: 0x04002A95 RID: 10901
		public const int StatusFieldNumber = 6;

		// Token: 0x04002A96 RID: 10902
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04002A97 RID: 10903
		private uint status_;

		// Token: 0x04002A98 RID: 10904
		public const int TimeoutFieldNumber = 7;

		// Token: 0x04002A99 RID: 10905
		private static readonly ulong TimeoutDefaultValue = 0UL;

		// Token: 0x04002A9A RID: 10906
		private ulong timeout_;

		// Token: 0x04002A9B RID: 10907
		public const int ForwardTargetFieldNumber = 8;

		// Token: 0x04002A9C RID: 10908
		private ProcessId forwardTarget_;

		// Token: 0x04002A9D RID: 10909
		public const int ReturnTopicFieldNumber = 9;

		// Token: 0x04002A9E RID: 10910
		private static readonly string ReturnTopicDefaultValue = "";

		// Token: 0x04002A9F RID: 10911
		private string returnTopic_;

		// Token: 0x04002AA0 RID: 10912
		public const int ClientIdFieldNumber = 11;

		// Token: 0x04002AA1 RID: 10913
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x04002AA2 RID: 10914
		private string clientId_;
	}
}
