using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003EB RID: 1003
	public sealed class ConnectInfo : IMessage<ConnectInfo>, IMessage, IEquatable<ConnectInfo>, IDeepCloneable<ConnectInfo>, IBufferMessage
	{
		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x001819D0 File Offset: 0x0017FBD0
		[DebuggerNonUserCode]
		public static MessageParser<ConnectInfo> Parser
		{
			get
			{
				return ConnectInfo._parser;
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x001819E8 File Offset: 0x0017FBE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x00181A0C File Offset: 0x0017FC0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectInfo.Descriptor;
			}
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x00181A23 File Offset: 0x0017FC23
		[DebuggerNonUserCode]
		public ConnectInfo()
		{
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00181A38 File Offset: 0x0017FC38
		[DebuggerNonUserCode]
		public ConnectInfo(ConnectInfo other)
			: this()
		{
			this.address_ = ((other.address_ != null) ? other.address_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00181A8C File Offset: 0x0017FC8C
		[DebuggerNonUserCode]
		public ConnectInfo Clone()
		{
			return new ConnectInfo(this);
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x00181AA4 File Offset: 0x0017FCA4
		// (set) Token: 0x060063C4 RID: 25540 RVA: 0x00181ABC File Offset: 0x0017FCBC
		[DebuggerNonUserCode]
		public Address Address
		{
			get
			{
				return this.address_;
			}
			set
			{
				this.address_ = value;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x00181AC8 File Offset: 0x0017FCC8
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00181AE0 File Offset: 0x0017FCE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectInfo);
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00181B00 File Offset: 0x0017FD00
		[DebuggerNonUserCode]
		public bool Equals(ConnectInfo other)
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
					bool flag4 = !object.Equals(this.Address, other.Address);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x00181B78 File Offset: 0x0017FD78
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.address_ != null;
			if (flag)
			{
				num ^= this.Address.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00181BD4 File Offset: 0x0017FDD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x00181BEC File Offset: 0x0017FDEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x00181BF8 File Offset: 0x0017FDF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.address_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Address);
			}
			this.attribute_.WriteTo(ref output, ConnectInfo._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00181C5C File Offset: 0x0017FE5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.address_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Address);
			}
			num += this.attribute_.CalculateSize(ConnectInfo._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x00181CC0 File Offset: 0x0017FEC0
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.address_ != null;
				if (flag2)
				{
					bool flag3 = this.address_ == null;
					if (flag3)
					{
						this.Address = new Address();
					}
					this.Address.MergeFrom(other.Address);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00181D3E File Offset: 0x0017FF3E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00181D4C File Offset: 0x0017FF4C
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, ConnectInfo._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.address_ == null;
					if (flag)
					{
						this.Address = new Address();
					}
					input.ReadMessage(this.Address);
				}
			}
		}

		// Token: 0x04002D75 RID: 11637
		private static readonly MessageParser<ConnectInfo> _parser = new MessageParser<ConnectInfo>(() => new ConnectInfo());

		// Token: 0x04002D76 RID: 11638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D77 RID: 11639
		public const int AddressFieldNumber = 1;

		// Token: 0x04002D78 RID: 11640
		private Address address_;

		// Token: 0x04002D79 RID: 11641
		public const int AttributeFieldNumber = 2;

		// Token: 0x04002D7A RID: 11642
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002D7B RID: 11643
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
