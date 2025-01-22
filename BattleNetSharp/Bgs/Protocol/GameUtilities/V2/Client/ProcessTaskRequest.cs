using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x020005FF RID: 1535
	public sealed class ProcessTaskRequest : IMessage<ProcessTaskRequest>, IMessage, IEquatable<ProcessTaskRequest>, IDeepCloneable<ProcessTaskRequest>, IBufferMessage
	{
		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0022DCA8 File Offset: 0x0022BEA8
		[DebuggerNonUserCode]
		public static MessageParser<ProcessTaskRequest> Parser
		{
			get
			{
				return ProcessTaskRequest._parser;
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x06008FB9 RID: 36793 RVA: 0x0022DCC0 File Offset: 0x0022BEC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x0022DCE4 File Offset: 0x0022BEE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x0022DCFB File Offset: 0x0022BEFB
		[DebuggerNonUserCode]
		public ProcessTaskRequest()
		{
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x0022DD1B File Offset: 0x0022BF1B
		[DebuggerNonUserCode]
		public ProcessTaskRequest(ProcessTaskRequest other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.payload_ = other.payload_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0022DD58 File Offset: 0x0022BF58
		[DebuggerNonUserCode]
		public ProcessTaskRequest Clone()
		{
			return new ProcessTaskRequest(this);
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x0022DD70 File Offset: 0x0022BF70
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x06008FBF RID: 36799 RVA: 0x0022DD88 File Offset: 0x0022BF88
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Payload
		{
			get
			{
				return this.payload_;
			}
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x0022DDA0 File Offset: 0x0022BFA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessTaskRequest);
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x0022DDC0 File Offset: 0x0022BFC0
		[DebuggerNonUserCode]
		public bool Equals(ProcessTaskRequest other)
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

		// Token: 0x06008FC2 RID: 36802 RVA: 0x0022DE38 File Offset: 0x0022C038
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

		// Token: 0x06008FC3 RID: 36803 RVA: 0x0022DE88 File Offset: 0x0022C088
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0022DEA0 File Offset: 0x0022C0A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0022DEAC File Offset: 0x0022C0AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ProcessTaskRequest._repeated_attribute_codec);
			this.payload_.WriteTo(ref output, ProcessTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0022DEFC File Offset: 0x0022C0FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ProcessTaskRequest._repeated_attribute_codec);
			num += this.payload_.CalculateSize(ProcessTaskRequest._repeated_payload_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x0022DF54 File Offset: 0x0022C154
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessTaskRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this.payload_.Add(other.payload_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008FC8 RID: 36808 RVA: 0x0022DFA8 File Offset: 0x0022C1A8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FC9 RID: 36809 RVA: 0x0022DFB4 File Offset: 0x0022C1B4
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
						this.payload_.AddEntriesFrom(ref input, ProcessTaskRequest._repeated_payload_codec);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ProcessTaskRequest._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x040040EA RID: 16618
		private static readonly MessageParser<ProcessTaskRequest> _parser = new MessageParser<ProcessTaskRequest>(() => new ProcessTaskRequest());

		// Token: 0x040040EB RID: 16619
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040EC RID: 16620
		public const int AttributeFieldNumber = 1;

		// Token: 0x040040ED RID: 16621
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040040EE RID: 16622
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040040EF RID: 16623
		public const int PayloadFieldNumber = 2;

		// Token: 0x040040F0 RID: 16624
		private static readonly FieldCodec<Attribute> _repeated_payload_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040040F1 RID: 16625
		private readonly RepeatedField<Attribute> payload_ = new RepeatedField<Attribute>();
	}
}
