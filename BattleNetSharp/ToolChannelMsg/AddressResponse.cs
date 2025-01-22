using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002C RID: 44
	public sealed class AddressResponse : IMessage<AddressResponse>, IMessage, IEquatable<AddressResponse>, IDeepCloneable<AddressResponse>, IBufferMessage
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000100AC File Offset: 0x0000E2AC
		[DebuggerNonUserCode]
		public static MessageParser<AddressResponse> Parser
		{
			get
			{
				return AddressResponse._parser;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000100C4 File Offset: 0x0000E2C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002BD RID: 701 RVA: 0x000100E8 File Offset: 0x0000E2E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddressResponse.Descriptor;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000100FF File Offset: 0x0000E2FF
		[DebuggerNonUserCode]
		public AddressResponse()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00010109 File Offset: 0x0000E309
		[DebuggerNonUserCode]
		public AddressResponse(AddressResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.address_ = other.address_;
			this.port_ = other.port_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00010148 File Offset: 0x0000E348
		[DebuggerNonUserCode]
		public AddressResponse Clone()
		{
			return new AddressResponse(this);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00010160 File Offset: 0x0000E360
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00010191 File Offset: 0x0000E391
		[DebuggerNonUserCode]
		public uint Address
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint addressDefaultValue;
				if (flag)
				{
					addressDefaultValue = this.address_;
				}
				else
				{
					addressDefaultValue = AddressResponse.AddressDefaultValue;
				}
				return addressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.address_ = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000101AC File Offset: 0x0000E3AC
		[DebuggerNonUserCode]
		public bool HasAddress
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000101C9 File Offset: 0x0000E3C9
		[DebuggerNonUserCode]
		public void ClearAddress()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000101DC File Offset: 0x0000E3DC
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0001020D File Offset: 0x0000E40D
		[DebuggerNonUserCode]
		public int Port
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int portDefaultValue;
				if (flag)
				{
					portDefaultValue = this.port_;
				}
				else
				{
					portDefaultValue = AddressResponse.PortDefaultValue;
				}
				return portDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.port_ = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00010228 File Offset: 0x0000E428
		[DebuggerNonUserCode]
		public bool HasPort
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00010245 File Offset: 0x0000E445
		[DebuggerNonUserCode]
		public void ClearPort()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00010258 File Offset: 0x0000E458
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddressResponse);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00010278 File Offset: 0x0000E478
		[DebuggerNonUserCode]
		public bool Equals(AddressResponse other)
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
					bool flag4 = this.Address != other.Address;
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

		// Token: 0x060002CB RID: 715 RVA: 0x000102EC File Offset: 0x0000E4EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num ^= this.Address.GetHashCode();
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

		// Token: 0x060002CC RID: 716 RVA: 0x0001035C File Offset: 0x0000E55C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00010374 File Offset: 0x0000E574
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00010380 File Offset: 0x0000E580
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Port);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000103F0 File Offset: 0x0000E5F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Port);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001045C File Offset: 0x0000E65C
		[DebuggerNonUserCode]
		public void MergeFrom(AddressResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAddress = other.HasAddress;
				if (hasAddress)
				{
					this.Address = other.Address;
				}
				bool hasPort = other.HasPort;
				if (hasPort)
				{
					this.Port = other.Port;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000104BE File Offset: 0x0000E6BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000104CC File Offset: 0x0000E6CC
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Port = input.ReadInt32();
					}
				}
				else
				{
					this.Address = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000120 RID: 288
		private static readonly MessageParser<AddressResponse> _parser = new MessageParser<AddressResponse>(() => new AddressResponse());

		// Token: 0x04000121 RID: 289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000122 RID: 290
		private int _hasBits0;

		// Token: 0x04000123 RID: 291
		public const int AddressFieldNumber = 1;

		// Token: 0x04000124 RID: 292
		private static readonly uint AddressDefaultValue = 0U;

		// Token: 0x04000125 RID: 293
		private uint address_;

		// Token: 0x04000126 RID: 294
		public const int PortFieldNumber = 2;

		// Token: 0x04000127 RID: 295
		private static readonly int PortDefaultValue = 0;

		// Token: 0x04000128 RID: 296
		private int port_;
	}
}
