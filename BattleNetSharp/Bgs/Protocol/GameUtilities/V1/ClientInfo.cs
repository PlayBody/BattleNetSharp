using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005F0 RID: 1520
	public sealed class ClientInfo : IMessage<ClientInfo>, IMessage, IEquatable<ClientInfo>, IDeepCloneable<ClientInfo>, IBufferMessage
	{
		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x06008EB9 RID: 36537 RVA: 0x0022A3E4 File Offset: 0x002285E4
		[DebuggerNonUserCode]
		public static MessageParser<ClientInfo> Parser
		{
			get
			{
				return ClientInfo._parser;
			}
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x06008EBA RID: 36538 RVA: 0x0022A3FC File Offset: 0x002285FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x06008EBB RID: 36539 RVA: 0x0022A420 File Offset: 0x00228620
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientInfo.Descriptor;
			}
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x0022A437 File Offset: 0x00228637
		[DebuggerNonUserCode]
		public ClientInfo()
		{
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x0022A441 File Offset: 0x00228641
		[DebuggerNonUserCode]
		public ClientInfo(ClientInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientAddress_ = other.clientAddress_;
			this.privilegedNetwork_ = other.privilegedNetwork_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x0022A480 File Offset: 0x00228680
		[DebuggerNonUserCode]
		public ClientInfo Clone()
		{
			return new ClientInfo(this);
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x0022A498 File Offset: 0x00228698
		// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x0022A4B9 File Offset: 0x002286B9
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? ClientInfo.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x0022A4D0 File Offset: 0x002286D0
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x0022A4EB File Offset: 0x002286EB
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x06008EC3 RID: 36547 RVA: 0x0022A4F8 File Offset: 0x002286F8
		// (set) Token: 0x06008EC4 RID: 36548 RVA: 0x0022A529 File Offset: 0x00228729
		[DebuggerNonUserCode]
		public bool PrivilegedNetwork
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool privilegedNetworkDefaultValue;
				if (flag)
				{
					privilegedNetworkDefaultValue = this.privilegedNetwork_;
				}
				else
				{
					privilegedNetworkDefaultValue = ClientInfo.PrivilegedNetworkDefaultValue;
				}
				return privilegedNetworkDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privilegedNetwork_ = value;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x06008EC5 RID: 36549 RVA: 0x0022A544 File Offset: 0x00228744
		[DebuggerNonUserCode]
		public bool HasPrivilegedNetwork
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0022A561 File Offset: 0x00228761
		[DebuggerNonUserCode]
		public void ClearPrivilegedNetwork()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x0022A574 File Offset: 0x00228774
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientInfo);
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x0022A594 File Offset: 0x00228794
		[DebuggerNonUserCode]
		public bool Equals(ClientInfo other)
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
					bool flag4 = this.ClientAddress != other.ClientAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PrivilegedNetwork != other.PrivilegedNetwork;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0022A608 File Offset: 0x00228808
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
			{
				num ^= this.PrivilegedNetwork.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x0022A674 File Offset: 0x00228874
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0022A68C File Offset: 0x0022888C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0022A698 File Offset: 0x00228898
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientAddress);
			}
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.PrivilegedNetwork);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x0022A708 File Offset: 0x00228908
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
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

		// Token: 0x06008ECE RID: 36558 RVA: 0x0022A768 File Offset: 0x00228968
		[DebuggerNonUserCode]
		public void MergeFrom(ClientInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasPrivilegedNetwork = other.HasPrivilegedNetwork;
				if (hasPrivilegedNetwork)
				{
					this.PrivilegedNetwork = other.PrivilegedNetwork;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x0022A7CA File Offset: 0x002289CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x0022A7D8 File Offset: 0x002289D8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PrivilegedNetwork = input.ReadBool();
					}
				}
				else
				{
					this.ClientAddress = input.ReadString();
				}
			}
		}

		// Token: 0x04004080 RID: 16512
		private static readonly MessageParser<ClientInfo> _parser = new MessageParser<ClientInfo>(() => new ClientInfo());

		// Token: 0x04004081 RID: 16513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004082 RID: 16514
		private int _hasBits0;

		// Token: 0x04004083 RID: 16515
		public const int ClientAddressFieldNumber = 1;

		// Token: 0x04004084 RID: 16516
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04004085 RID: 16517
		private string clientAddress_;

		// Token: 0x04004086 RID: 16518
		public const int PrivilegedNetworkFieldNumber = 2;

		// Token: 0x04004087 RID: 16519
		private static readonly bool PrivilegedNetworkDefaultValue = false;

		// Token: 0x04004088 RID: 16520
		private bool privilegedNetwork_;
	}
}
