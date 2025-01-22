using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000568 RID: 1384
	public sealed class CreateOptions : IMessage<CreateOptions>, IMessage, IEquatable<CreateOptions>, IDeepCloneable<CreateOptions>, IBufferMessage
	{
		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x002057D8 File Offset: 0x002039D8
		[DebuggerNonUserCode]
		public static MessageParser<CreateOptions> Parser
		{
			get
			{
				return CreateOptions._parser;
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600850C RID: 34060 RVA: 0x002057F0 File Offset: 0x002039F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x00205814 File Offset: 0x00203A14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateOptions.Descriptor;
			}
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x0020582B File Offset: 0x00203A2B
		[DebuggerNonUserCode]
		public CreateOptions()
		{
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x00205835 File Offset: 0x00203A35
		[DebuggerNonUserCode]
		public CreateOptions(CreateOptions other)
			: this()
		{
			this.macAddress_ = other.macAddress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x0020585C File Offset: 0x00203A5C
		[DebuggerNonUserCode]
		public CreateOptions Clone()
		{
			return new CreateOptions(this);
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x06008511 RID: 34065 RVA: 0x00205874 File Offset: 0x00203A74
		// (set) Token: 0x06008512 RID: 34066 RVA: 0x00205895 File Offset: 0x00203A95
		[DebuggerNonUserCode]
		public string MacAddress
		{
			get
			{
				return this.macAddress_ ?? CreateOptions.MacAddressDefaultValue;
			}
			set
			{
				this.macAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x002058AC File Offset: 0x00203AAC
		[DebuggerNonUserCode]
		public bool HasMacAddress
		{
			get
			{
				return this.macAddress_ != null;
			}
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x002058C7 File Offset: 0x00203AC7
		[DebuggerNonUserCode]
		public void ClearMacAddress()
		{
			this.macAddress_ = null;
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x002058D4 File Offset: 0x00203AD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateOptions);
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x002058F4 File Offset: 0x00203AF4
		[DebuggerNonUserCode]
		public bool Equals(CreateOptions other)
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
					bool flag4 = this.MacAddress != other.MacAddress;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x0020594C File Offset: 0x00203B4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num ^= this.MacAddress.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00205998 File Offset: 0x00203B98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x002059B0 File Offset: 0x00203BB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x002059BC File Offset: 0x00203BBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MacAddress);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00205A08 File Offset: 0x00203C08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MacAddress);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00205A58 File Offset: 0x00203C58
		[DebuggerNonUserCode]
		public void MergeFrom(CreateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMacAddress = other.HasMacAddress;
				if (hasMacAddress)
				{
					this.MacAddress = other.MacAddress;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x00205AA1 File Offset: 0x00203CA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00205AAC File Offset: 0x00203CAC
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
					this.MacAddress = input.ReadString();
				}
			}
		}

		// Token: 0x04003C5E RID: 15454
		private static readonly MessageParser<CreateOptions> _parser = new MessageParser<CreateOptions>(() => new CreateOptions());

		// Token: 0x04003C5F RID: 15455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C60 RID: 15456
		public const int MacAddressFieldNumber = 1;

		// Token: 0x04003C61 RID: 15457
		private static readonly string MacAddressDefaultValue = "";

		// Token: 0x04003C62 RID: 15458
		private string macAddress_;
	}
}
