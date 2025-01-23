using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F6 RID: 1526
	public sealed class ProcessServerTaskRequest : IMessage<ProcessServerTaskRequest>, IMessage, IEquatable<ProcessServerTaskRequest>, IDeepCloneable<ProcessServerTaskRequest>, IBufferMessage
	{
		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x0022B9BC File Offset: 0x00229BBC
		[DebuggerNonUserCode]
		public static MessageParser<ProcessServerTaskRequest> Parser
		{
			get
			{
				return ProcessServerTaskRequest._parser;
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x06008F21 RID: 36641 RVA: 0x0022B9D4 File Offset: 0x00229BD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x0022B9F8 File Offset: 0x00229BF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessServerTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x0022BA0F File Offset: 0x00229C0F
		[DebuggerNonUserCode]
		public ProcessServerTaskRequest()
		{
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x0022BA2F File Offset: 0x00229C2F
		[DebuggerNonUserCode]
		public ProcessServerTaskRequest(ProcessServerTaskRequest other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.payload_ = other.payload_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x0022BA6C File Offset: 0x00229C6C
		[DebuggerNonUserCode]
		public ProcessServerTaskRequest Clone()
		{
			return new ProcessServerTaskRequest(this);
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x0022BA84 File Offset: 0x00229C84
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06008F27 RID: 36647 RVA: 0x0022BA9C File Offset: 0x00229C9C
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Payload
		{
			get
			{
				return this.payload_;
			}
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0022BAB4 File Offset: 0x00229CB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessServerTaskRequest);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0022BAD4 File Offset: 0x00229CD4
		[DebuggerNonUserCode]
		public bool Equals(ProcessServerTaskRequest other)
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

		// Token: 0x06008F2A RID: 36650 RVA: 0x0022BB4C File Offset: 0x00229D4C
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

		// Token: 0x06008F2B RID: 36651 RVA: 0x0022BB9C File Offset: 0x00229D9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0022BBB4 File Offset: 0x00229DB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x0022BBC0 File Offset: 0x00229DC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ProcessServerTaskRequest._repeated_attribute_codec);
			this.payload_.WriteTo(ref output, ProcessServerTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0022BC10 File Offset: 0x00229E10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ProcessServerTaskRequest._repeated_attribute_codec);
			num += this.payload_.CalculateSize(ProcessServerTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x0022BC68 File Offset: 0x00229E68
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessServerTaskRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this.payload_.Add(other.payload_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x0022BCBC File Offset: 0x00229EBC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0022BCC8 File Offset: 0x00229EC8
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
						this.payload_.AddEntriesFrom(ref input, ProcessServerTaskRequest._repeated_payload_codec);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ProcessServerTaskRequest._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x040040A6 RID: 16550
		private static readonly MessageParser<ProcessServerTaskRequest> _parser = new MessageParser<ProcessServerTaskRequest>(() => new ProcessServerTaskRequest());

		// Token: 0x040040A7 RID: 16551
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040A8 RID: 16552
		public const int AttributeFieldNumber = 1;

		// Token: 0x040040A9 RID: 16553
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040040AA RID: 16554
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x040040AB RID: 16555
		public const int PayloadFieldNumber = 2;

		// Token: 0x040040AC RID: 16556
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_payload_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040040AD RID: 16557
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> payload_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
