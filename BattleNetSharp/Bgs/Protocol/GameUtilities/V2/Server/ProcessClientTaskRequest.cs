using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F4 RID: 1524
	public sealed class ProcessClientTaskRequest : IMessage<ProcessClientTaskRequest>, IMessage, IEquatable<ProcessClientTaskRequest>, IDeepCloneable<ProcessClientTaskRequest>, IBufferMessage
	{
		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0022B1C0 File Offset: 0x002293C0
		[DebuggerNonUserCode]
		public static MessageParser<ProcessClientTaskRequest> Parser
		{
			get
			{
				return ProcessClientTaskRequest._parser;
			}
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x06008EFA RID: 36602 RVA: 0x0022B1D8 File Offset: 0x002293D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x06008EFB RID: 36603 RVA: 0x0022B1FC File Offset: 0x002293FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessClientTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x0022B213 File Offset: 0x00229413
		[DebuggerNonUserCode]
		public ProcessClientTaskRequest()
		{
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x0022B234 File Offset: 0x00229434
		[DebuggerNonUserCode]
		public ProcessClientTaskRequest(ProcessClientTaskRequest other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.payload_ = other.payload_.Clone();
			this.clientInfo_ = ((other.clientInfo_ != null) ? other.clientInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x0022B298 File Offset: 0x00229498
		[DebuggerNonUserCode]
		public ProcessClientTaskRequest Clone()
		{
			return new ProcessClientTaskRequest(this);
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x06008EFF RID: 36607 RVA: 0x0022B2B0 File Offset: 0x002294B0
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x06008F00 RID: 36608 RVA: 0x0022B2C8 File Offset: 0x002294C8
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Payload
		{
			get
			{
				return this.payload_;
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x06008F01 RID: 36609 RVA: 0x0022B2E0 File Offset: 0x002294E0
		// (set) Token: 0x06008F02 RID: 36610 RVA: 0x0022B2F8 File Offset: 0x002294F8
		[DebuggerNonUserCode]
		public ClientInfo ClientInfo
		{
			get
			{
				return this.clientInfo_;
			}
			set
			{
				this.clientInfo_ = value;
			}
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x0022B304 File Offset: 0x00229504
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessClientTaskRequest);
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x0022B324 File Offset: 0x00229524
		[DebuggerNonUserCode]
		public bool Equals(ProcessClientTaskRequest other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ClientInfo, other.ClientInfo);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x0022B3BC File Offset: 0x002295BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			num ^= this.payload_.GetHashCode();
			bool flag = this.clientInfo_ != null;
			if (flag)
			{
				num ^= this.ClientInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x0022B428 File Offset: 0x00229628
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x0022B440 File Offset: 0x00229640
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x0022B44C File Offset: 0x0022964C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ProcessClientTaskRequest._repeated_attribute_codec);
			this.payload_.WriteTo(ref output, ProcessClientTaskRequest._repeated_payload_codec);
			bool flag = this.clientInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ClientInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x0022B4C0 File Offset: 0x002296C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ProcessClientTaskRequest._repeated_attribute_codec);
			num += this.payload_.CalculateSize(ProcessClientTaskRequest._repeated_payload_codec);
			bool flag = this.clientInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x0022B538 File Offset: 0x00229738
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessClientTaskRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this.payload_.Add(other.payload_);
				bool flag2 = other.clientInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.clientInfo_ == null;
					if (flag3)
					{
						this.ClientInfo = new ClientInfo();
					}
					this.ClientInfo.MergeFrom(other.ClientInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x0022B5C8 File Offset: 0x002297C8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x0022B5D4 File Offset: 0x002297D4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.clientInfo_ == null;
							if (flag)
							{
								this.ClientInfo = new ClientInfo();
							}
							input.ReadMessage(this.ClientInfo);
						}
					}
					else
					{
						this.payload_.AddEntriesFrom(ref input, ProcessClientTaskRequest._repeated_payload_codec);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ProcessClientTaskRequest._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x04004097 RID: 16535
		private static readonly MessageParser<ProcessClientTaskRequest> _parser = new MessageParser<ProcessClientTaskRequest>(() => new ProcessClientTaskRequest());

		// Token: 0x04004098 RID: 16536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004099 RID: 16537
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400409A RID: 16538
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400409B RID: 16539
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x0400409C RID: 16540
		public const int PayloadFieldNumber = 2;

		// Token: 0x0400409D RID: 16541
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_payload_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400409E RID: 16542
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> payload_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x0400409F RID: 16543
		public const int ClientInfoFieldNumber = 3;

		// Token: 0x040040A0 RID: 16544
		private ClientInfo clientInfo_;
	}
}
