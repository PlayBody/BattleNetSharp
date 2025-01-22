using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038B RID: 907
	public sealed class Address : IMessage<Address>, IMessage, IEquatable<Address>, IDeepCloneable<Address>, IBufferMessage
	{
		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00164428 File Offset: 0x00162628
		[DebuggerNonUserCode]
		public static MessageParser<Address> Parser
		{
			get
			{
				return Address._parser;
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x00164440 File Offset: 0x00162640
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x00164464 File Offset: 0x00162664
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Address.Descriptor;
			}
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x0016447B File Offset: 0x0016267B
		[DebuggerNonUserCode]
		public Address()
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00164485 File Offset: 0x00162685
		[DebuggerNonUserCode]
		public Address(Address other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.address_ = other.address_;
			this.port_ = other.port_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x001644C4 File Offset: 0x001626C4
		[DebuggerNonUserCode]
		public Address Clone()
		{
			return new Address(this);
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06005C0D RID: 23565 RVA: 0x001644DC File Offset: 0x001626DC
		// (set) Token: 0x06005C0E RID: 23566 RVA: 0x001644FD File Offset: 0x001626FD
		[DebuggerNonUserCode]
		public string Address_
		{
			get
			{
				return this.address_ ?? Address.Address_DefaultValue;
			}
			set
			{
				this.address_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06005C0F RID: 23567 RVA: 0x00164514 File Offset: 0x00162714
		[DebuggerNonUserCode]
		public bool HasAddress_
		{
			get
			{
				return this.address_ != null;
			}
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x0016452F File Offset: 0x0016272F
		[DebuggerNonUserCode]
		public void ClearAddress_()
		{
			this.address_ = null;
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06005C11 RID: 23569 RVA: 0x0016453C File Offset: 0x0016273C
		// (set) Token: 0x06005C12 RID: 23570 RVA: 0x0016456D File Offset: 0x0016276D
		[DebuggerNonUserCode]
		public uint Port
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint portDefaultValue;
				if (flag)
				{
					portDefaultValue = this.port_;
				}
				else
				{
					portDefaultValue = Address.PortDefaultValue;
				}
				return portDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.port_ = value;
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06005C13 RID: 23571 RVA: 0x00164588 File Offset: 0x00162788
		[DebuggerNonUserCode]
		public bool HasPort
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x001645A5 File Offset: 0x001627A5
		[DebuggerNonUserCode]
		public void ClearPort()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x001645B8 File Offset: 0x001627B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Address);
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x001645D8 File Offset: 0x001627D8
		[DebuggerNonUserCode]
		public bool Equals(Address other)
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
					bool flag4 = this.Address_ != other.Address_;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Port != other.Port;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x0016464C File Offset: 0x0016284C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAddress_ = this.HasAddress_;
			if (hasAddress_)
			{
				num ^= this.Address_.GetHashCode();
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num ^= this.Port.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x001646B8 File Offset: 0x001628B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x001646D0 File Offset: 0x001628D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x001646DC File Offset: 0x001628DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAddress_ = this.HasAddress_;
			if (hasAddress_)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Address_);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Port);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x0016474C File Offset: 0x0016294C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAddress_ = this.HasAddress_;
			if (hasAddress_)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Address_);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x001647B8 File Offset: 0x001629B8
		[DebuggerNonUserCode]
		public void MergeFrom(Address other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAddress_ = other.HasAddress_;
				if (hasAddress_)
				{
					this.Address_ = other.Address_;
				}
				bool hasPort = other.HasPort;
				if (hasPort)
				{
					this.Port = other.Port;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x0016481A File Offset: 0x00162A1A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x00164828 File Offset: 0x00162A28
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
						this.Port = input.ReadUInt32();
					}
				}
				else
				{
					this.Address_ = input.ReadString();
				}
			}
		}

		// Token: 0x04002A0E RID: 10766
		private static readonly MessageParser<Address> _parser = new MessageParser<Address>(() => new Address());

		// Token: 0x04002A0F RID: 10767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A10 RID: 10768
		private int _hasBits0;

		// Token: 0x04002A11 RID: 10769
		public const int Address_FieldNumber = 1;

		// Token: 0x04002A12 RID: 10770
		private static readonly string Address_DefaultValue = "";

		// Token: 0x04002A13 RID: 10771
		private string address_;

		// Token: 0x04002A14 RID: 10772
		public const int PortFieldNumber = 2;

		// Token: 0x04002A15 RID: 10773
		private static readonly uint PortDefaultValue = 0U;

		// Token: 0x04002A16 RID: 10774
		private uint port_;
	}
}
