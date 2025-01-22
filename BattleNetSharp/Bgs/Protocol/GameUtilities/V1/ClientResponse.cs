using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E1 RID: 1505
	public sealed class ClientResponse : IMessage<ClientResponse>, IMessage, IEquatable<ClientResponse>, IDeepCloneable<ClientResponse>, IBufferMessage
	{
		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x06008D99 RID: 36249 RVA: 0x00226280 File Offset: 0x00224480
		[DebuggerNonUserCode]
		public static MessageParser<ClientResponse> Parser
		{
			get
			{
				return ClientResponse._parser;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x00226298 File Offset: 0x00224498
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x002262BC File Offset: 0x002244BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientResponse.Descriptor;
			}
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x002262D3 File Offset: 0x002244D3
		[DebuggerNonUserCode]
		public ClientResponse()
		{
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x002262E8 File Offset: 0x002244E8
		[DebuggerNonUserCode]
		public ClientResponse(ClientResponse other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00226314 File Offset: 0x00224514
		[DebuggerNonUserCode]
		public ClientResponse Clone()
		{
			return new ClientResponse(this);
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x06008D9F RID: 36255 RVA: 0x0022632C File Offset: 0x0022452C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x00226344 File Offset: 0x00224544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientResponse);
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x00226364 File Offset: 0x00224564
		[DebuggerNonUserCode]
		public bool Equals(ClientResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x002263C0 File Offset: 0x002245C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x00226400 File Offset: 0x00224600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x00226418 File Offset: 0x00224618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x00226424 File Offset: 0x00224624
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ClientResponse._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x00226460 File Offset: 0x00224660
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ClientResponse._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x002264A8 File Offset: 0x002246A8
		[DebuggerNonUserCode]
		public void MergeFrom(ClientResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x002264EA File Offset: 0x002246EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x002264F8 File Offset: 0x002246F8
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
					this.attribute_.AddEntriesFrom(ref input, ClientResponse._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x04004007 RID: 16391
		private static readonly MessageParser<ClientResponse> _parser = new MessageParser<ClientResponse>(() => new ClientResponse());

		// Token: 0x04004008 RID: 16392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004009 RID: 16393
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400400A RID: 16394
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x0400400B RID: 16395
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
