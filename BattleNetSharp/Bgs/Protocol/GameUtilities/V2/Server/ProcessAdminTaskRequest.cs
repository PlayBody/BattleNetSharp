using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F2 RID: 1522
	public sealed class ProcessAdminTaskRequest : IMessage<ProcessAdminTaskRequest>, IMessage, IEquatable<ProcessAdminTaskRequest>, IDeepCloneable<ProcessAdminTaskRequest>, IBufferMessage
	{
		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x06008ED4 RID: 36564 RVA: 0x0022AB08 File Offset: 0x00228D08
		[DebuggerNonUserCode]
		public static MessageParser<ProcessAdminTaskRequest> Parser
		{
			get
			{
				return ProcessAdminTaskRequest._parser;
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x06008ED5 RID: 36565 RVA: 0x0022AB20 File Offset: 0x00228D20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x0022AB44 File Offset: 0x00228D44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessAdminTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008ED7 RID: 36567 RVA: 0x0022AB5B File Offset: 0x00228D5B
		[DebuggerNonUserCode]
		public ProcessAdminTaskRequest()
		{
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0022AB7B File Offset: 0x00228D7B
		[DebuggerNonUserCode]
		public ProcessAdminTaskRequest(ProcessAdminTaskRequest other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.payload_ = other.payload_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0022ABB8 File Offset: 0x00228DB8
		[DebuggerNonUserCode]
		public ProcessAdminTaskRequest Clone()
		{
			return new ProcessAdminTaskRequest(this);
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x0022ABD0 File Offset: 0x00228DD0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x0022ABE8 File Offset: 0x00228DE8
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Payload
		{
			get
			{
				return this.payload_;
			}
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x0022AC00 File Offset: 0x00228E00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessAdminTaskRequest);
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x0022AC20 File Offset: 0x00228E20
		[DebuggerNonUserCode]
		public bool Equals(ProcessAdminTaskRequest other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.payload_.Equals(other.payload_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x0022AC98 File Offset: 0x00228E98
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			num ^= this.payload_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x0022ACE8 File Offset: 0x00228EE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x0022AD00 File Offset: 0x00228F00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x0022AD0C File Offset: 0x00228F0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ProcessAdminTaskRequest._repeated_attribute_codec);
			this.payload_.WriteTo(ref output, ProcessAdminTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x0022AD5C File Offset: 0x00228F5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ProcessAdminTaskRequest._repeated_attribute_codec);
			num += this.payload_.CalculateSize(ProcessAdminTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x0022ADB4 File Offset: 0x00228FB4
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessAdminTaskRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this.payload_.Add(other.payload_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x0022AE08 File Offset: 0x00229008
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x0022AE14 File Offset: 0x00229014
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
						this.payload_.AddEntriesFrom(ref input, ProcessAdminTaskRequest._repeated_payload_codec);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ProcessAdminTaskRequest._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x0400408A RID: 16522
		private static readonly MessageParser<ProcessAdminTaskRequest> _parser = new MessageParser<ProcessAdminTaskRequest>(() => new ProcessAdminTaskRequest());

		// Token: 0x0400408B RID: 16523
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400408C RID: 16524
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400408D RID: 16525
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400408E RID: 16526
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400408F RID: 16527
		public const int PayloadFieldNumber = 2;

		// Token: 0x04004090 RID: 16528
		private static readonly FieldCodec<Attribute> _repeated_payload_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004091 RID: 16529
		private readonly RepeatedField<Attribute> payload_ = new RepeatedField<Attribute>();
	}
}
