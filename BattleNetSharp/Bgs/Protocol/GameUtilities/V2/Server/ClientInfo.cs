using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005FA RID: 1530
	public sealed class ClientInfo : IMessage<ClientInfo>, IMessage, IEquatable<ClientInfo>, IDeepCloneable<ClientInfo>, IBufferMessage
	{
		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06008F4D RID: 36685 RVA: 0x0022C50C File Offset: 0x0022A70C
		[DebuggerNonUserCode]
		public static MessageParser<ClientInfo> Parser
		{
			get
			{
				return ClientInfo._parser;
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x0022C524 File Offset: 0x0022A724
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06008F4F RID: 36687 RVA: 0x0022C548 File Offset: 0x0022A748
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientInfo.Descriptor;
			}
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x0022C55F File Offset: 0x0022A75F
		[DebuggerNonUserCode]
		public ClientInfo()
		{
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x0022C56C File Offset: 0x0022A76C
		[DebuggerNonUserCode]
		public ClientInfo(ClientInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientAddress_ = other.clientAddress_;
			this.privilegedNetwork_ = other.privilegedNetwork_;
			this.user_ = ((other.user_ != null) ? other.user_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x0022C5D4 File Offset: 0x0022A7D4
		[DebuggerNonUserCode]
		public ClientInfo Clone()
		{
			return new ClientInfo(this);
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06008F53 RID: 36691 RVA: 0x0022C5EC File Offset: 0x0022A7EC
		// (set) Token: 0x06008F54 RID: 36692 RVA: 0x0022C60D File Offset: 0x0022A80D
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

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06008F55 RID: 36693 RVA: 0x0022C624 File Offset: 0x0022A824
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0022C63F File Offset: 0x0022A83F
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x06008F57 RID: 36695 RVA: 0x0022C64C File Offset: 0x0022A84C
		// (set) Token: 0x06008F58 RID: 36696 RVA: 0x0022C67D File Offset: 0x0022A87D
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

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0022C698 File Offset: 0x0022A898
		[DebuggerNonUserCode]
		public bool HasPrivilegedNetwork
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x0022C6B5 File Offset: 0x0022A8B5
		[DebuggerNonUserCode]
		public void ClearPrivilegedNetwork()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06008F5B RID: 36699 RVA: 0x0022C6C8 File Offset: 0x0022A8C8
		// (set) Token: 0x06008F5C RID: 36700 RVA: 0x0022C6E0 File Offset: 0x0022A8E0
		[DebuggerNonUserCode]
		public Identity User
		{
			get
			{
				return this.user_;
			}
			set
			{
				this.user_ = value;
			}
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x0022C6EC File Offset: 0x0022A8EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientInfo);
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x0022C70C File Offset: 0x0022A90C
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.User, other.User);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x0022C79C File Offset: 0x0022A99C
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
			bool flag = this.user_ != null;
			if (flag)
			{
				num ^= this.User.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0022C824 File Offset: 0x0022AA24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x0022C83C File Offset: 0x0022AA3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0022C848 File Offset: 0x0022AA48
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
			bool flag = this.user_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.User);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0022C8DC File Offset: 0x0022AADC
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
			bool flag = this.user_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.User);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0022C960 File Offset: 0x0022AB60
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
				bool flag2 = other.user_ != null;
				if (flag2)
				{
					bool flag3 = this.user_ == null;
					if (flag3)
					{
						this.User = new Identity();
					}
					this.User.MergeFrom(other.User);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x0022CA03 File Offset: 0x0022AC03
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x0022CA10 File Offset: 0x0022AC10
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.user_ == null;
							if (flag)
							{
								this.User = new Identity();
							}
							input.ReadMessage(this.User);
						}
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

		// Token: 0x040040BE RID: 16574
		private static readonly MessageParser<ClientInfo> _parser = new MessageParser<ClientInfo>(() => new ClientInfo());

		// Token: 0x040040BF RID: 16575
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040C0 RID: 16576
		private int _hasBits0;

		// Token: 0x040040C1 RID: 16577
		public const int ClientAddressFieldNumber = 1;

		// Token: 0x040040C2 RID: 16578
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x040040C3 RID: 16579
		private string clientAddress_;

		// Token: 0x040040C4 RID: 16580
		public const int PrivilegedNetworkFieldNumber = 2;

		// Token: 0x040040C5 RID: 16581
		private static readonly bool PrivilegedNetworkDefaultValue = false;

		// Token: 0x040040C6 RID: 16582
		private bool privilegedNetwork_;

		// Token: 0x040040C7 RID: 16583
		public const int UserFieldNumber = 3;

		// Token: 0x040040C8 RID: 16584
		private Identity user_;
	}
}
