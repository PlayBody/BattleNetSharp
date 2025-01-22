using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E3 RID: 1507
	public sealed class ServerResponse : IMessage<ServerResponse>, IMessage, IEquatable<ServerResponse>, IDeepCloneable<ServerResponse>, IBufferMessage
	{
		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06008DC3 RID: 36291 RVA: 0x00226AEC File Offset: 0x00224CEC
		[DebuggerNonUserCode]
		public static MessageParser<ServerResponse> Parser
		{
			get
			{
				return ServerResponse._parser;
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x00226B04 File Offset: 0x00224D04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06008DC5 RID: 36293 RVA: 0x00226B28 File Offset: 0x00224D28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerResponse.Descriptor;
			}
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x00226B3F File Offset: 0x00224D3F
		[DebuggerNonUserCode]
		public ServerResponse()
		{
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x00226B54 File Offset: 0x00224D54
		[DebuggerNonUserCode]
		public ServerResponse(ServerResponse other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00226B80 File Offset: 0x00224D80
		[DebuggerNonUserCode]
		public ServerResponse Clone()
		{
			return new ServerResponse(this);
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x00226B98 File Offset: 0x00224D98
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x00226BB0 File Offset: 0x00224DB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerResponse);
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x00226BD0 File Offset: 0x00224DD0
		[DebuggerNonUserCode]
		public bool Equals(ServerResponse other)
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

		// Token: 0x06008DCC RID: 36300 RVA: 0x00226C2C File Offset: 0x00224E2C
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

		// Token: 0x06008DCD RID: 36301 RVA: 0x00226C6C File Offset: 0x00224E6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x00226C84 File Offset: 0x00224E84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DCF RID: 36303 RVA: 0x00226C90 File Offset: 0x00224E90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ServerResponse._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x00226CCC File Offset: 0x00224ECC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ServerResponse._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x00226D14 File Offset: 0x00224F14
		[DebuggerNonUserCode]
		public void MergeFrom(ServerResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x00226D56 File Offset: 0x00224F56
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x00226D64 File Offset: 0x00224F64
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
					this.attribute_.AddEntriesFrom(ref input, ServerResponse._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x04004017 RID: 16407
		private static readonly MessageParser<ServerResponse> _parser = new MessageParser<ServerResponse>(() => new ServerResponse());

		// Token: 0x04004018 RID: 16408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004019 RID: 16409
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400401A RID: 16410
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x0400401B RID: 16411
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
