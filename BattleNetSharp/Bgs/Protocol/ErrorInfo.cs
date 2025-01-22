using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038F RID: 911
	public sealed class ErrorInfo : IMessage<ErrorInfo>, IMessage, IEquatable<ErrorInfo>, IDeepCloneable<ErrorInfo>, IBufferMessage
	{
		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x00165458 File Offset: 0x00163658
		[DebuggerNonUserCode]
		public static MessageParser<ErrorInfo> Parser
		{
			get
			{
				return ErrorInfo._parser;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x00165470 File Offset: 0x00163670
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06005C63 RID: 23651 RVA: 0x00165494 File Offset: 0x00163694
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ErrorInfo.Descriptor;
			}
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x001654AB File Offset: 0x001636AB
		[DebuggerNonUserCode]
		public ErrorInfo()
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x001654B8 File Offset: 0x001636B8
		[DebuggerNonUserCode]
		public ErrorInfo(ErrorInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectAddress_ = ((other.objectAddress_ != null) ? other.objectAddress_.Clone() : null);
			this.status_ = other.status_;
			this.serviceHash_ = other.serviceHash_;
			this.methodId_ = other.methodId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x0016552C File Offset: 0x0016372C
		[DebuggerNonUserCode]
		public ErrorInfo Clone()
		{
			return new ErrorInfo(this);
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x00165544 File Offset: 0x00163744
		// (set) Token: 0x06005C68 RID: 23656 RVA: 0x0016555C File Offset: 0x0016375C
		[DebuggerNonUserCode]
		public ObjectAddress ObjectAddress
		{
			get
			{
				return this.objectAddress_;
			}
			set
			{
				this.objectAddress_ = value;
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06005C69 RID: 23657 RVA: 0x00165568 File Offset: 0x00163768
		// (set) Token: 0x06005C6A RID: 23658 RVA: 0x00165599 File Offset: 0x00163799
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = ErrorInfo.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001655B4 File Offset: 0x001637B4
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x001655D1 File Offset: 0x001637D1
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06005C6D RID: 23661 RVA: 0x001655E4 File Offset: 0x001637E4
		// (set) Token: 0x06005C6E RID: 23662 RVA: 0x00165615 File Offset: 0x00163815
		[DebuggerNonUserCode]
		public uint ServiceHash
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint serviceHashDefaultValue;
				if (flag)
				{
					serviceHashDefaultValue = this.serviceHash_;
				}
				else
				{
					serviceHashDefaultValue = ErrorInfo.ServiceHashDefaultValue;
				}
				return serviceHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.serviceHash_ = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x00165630 File Offset: 0x00163830
		[DebuggerNonUserCode]
		public bool HasServiceHash
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x0016564D File Offset: 0x0016384D
		[DebuggerNonUserCode]
		public void ClearServiceHash()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06005C71 RID: 23665 RVA: 0x00165660 File Offset: 0x00163860
		// (set) Token: 0x06005C72 RID: 23666 RVA: 0x00165691 File Offset: 0x00163891
		[DebuggerNonUserCode]
		public uint MethodId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint methodIdDefaultValue;
				if (flag)
				{
					methodIdDefaultValue = this.methodId_;
				}
				else
				{
					methodIdDefaultValue = ErrorInfo.MethodIdDefaultValue;
				}
				return methodIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.methodId_ = value;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001656AC File Offset: 0x001638AC
		[DebuggerNonUserCode]
		public bool HasMethodId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x001656C9 File Offset: 0x001638C9
		[DebuggerNonUserCode]
		public void ClearMethodId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x001656DC File Offset: 0x001638DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ErrorInfo);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x001656FC File Offset: 0x001638FC
		[DebuggerNonUserCode]
		public bool Equals(ErrorInfo other)
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
					bool flag4 = !object.Equals(this.ObjectAddress, other.ObjectAddress);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Status != other.Status;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ServiceHash != other.ServiceHash;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MethodId != other.MethodId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x001657AC File Offset: 0x001639AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.objectAddress_ != null;
			if (flag)
			{
				num ^= this.ObjectAddress.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x00165854 File Offset: 0x00163A54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x0016586C File Offset: 0x00163A6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x00165878 File Offset: 0x00163A78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.objectAddress_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ObjectAddress);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Status);
			}
			bool hasServiceHash = this.HasServiceHash;
			if (hasServiceHash)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ServiceHash);
			}
			bool hasMethodId = this.HasMethodId;
			if (hasMethodId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MethodId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00165930 File Offset: 0x00163B30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.objectAddress_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ObjectAddress);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x001659DC File Offset: 0x00163BDC
		[DebuggerNonUserCode]
		public void MergeFrom(ErrorInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.objectAddress_ != null;
				if (flag2)
				{
					bool flag3 = this.objectAddress_ == null;
					if (flag3)
					{
						this.ObjectAddress = new ObjectAddress();
					}
					this.ObjectAddress.MergeFrom(other.ObjectAddress);
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
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

		// Token: 0x06005C7D RID: 23677 RVA: 0x00165A9A File Offset: 0x00163C9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00165AA8 File Offset: 0x00163CA8
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
							goto IL_002C;
						}
						this.Status = input.ReadUInt32();
					}
					else
					{
						bool flag = this.objectAddress_ == null;
						if (flag)
						{
							this.ObjectAddress = new ObjectAddress();
						}
						input.ReadMessage(this.ObjectAddress);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.MethodId = input.ReadUInt32();
				}
				else
				{
					this.ServiceHash = input.ReadUInt32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A2A RID: 10794
		private static readonly MessageParser<ErrorInfo> _parser = new MessageParser<ErrorInfo>(() => new ErrorInfo());

		// Token: 0x04002A2B RID: 10795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A2C RID: 10796
		private int _hasBits0;

		// Token: 0x04002A2D RID: 10797
		public const int ObjectAddressFieldNumber = 1;

		// Token: 0x04002A2E RID: 10798
		private ObjectAddress objectAddress_;

		// Token: 0x04002A2F RID: 10799
		public const int StatusFieldNumber = 2;

		// Token: 0x04002A30 RID: 10800
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04002A31 RID: 10801
		private uint status_;

		// Token: 0x04002A32 RID: 10802
		public const int ServiceHashFieldNumber = 3;

		// Token: 0x04002A33 RID: 10803
		private static readonly uint ServiceHashDefaultValue = 0U;

		// Token: 0x04002A34 RID: 10804
		private uint serviceHash_;

		// Token: 0x04002A35 RID: 10805
		public const int MethodIdFieldNumber = 4;

		// Token: 0x04002A36 RID: 10806
		private static readonly uint MethodIdDefaultValue = 0U;

		// Token: 0x04002A37 RID: 10807
		private uint methodId_;
	}
}
