using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000431 RID: 1073
	public sealed class BindResponse : IMessage<BindResponse>, IMessage, IEquatable<BindResponse>, IDeepCloneable<BindResponse>, IBufferMessage
	{
		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x001988F8 File Offset: 0x00196AF8
		[DebuggerNonUserCode]
		public static MessageParser<BindResponse> Parser
		{
			get
			{
				return BindResponse._parser;
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06006980 RID: 27008 RVA: 0x00198910 File Offset: 0x00196B10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x00198934 File Offset: 0x00196B34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BindResponse.Descriptor;
			}
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0019894B File Offset: 0x00196B4B
		[DebuggerNonUserCode]
		public BindResponse()
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00198960 File Offset: 0x00196B60
		[DebuggerNonUserCode]
		public BindResponse(BindResponse other)
			: this()
		{
			this.importedServiceId_ = other.importedServiceId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0019898C File Offset: 0x00196B8C
		[DebuggerNonUserCode]
		public BindResponse Clone()
		{
			return new BindResponse(this);
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x001989A4 File Offset: 0x00196BA4
		[Obsolete]
		[DebuggerNonUserCode]
		public RepeatedField<uint> ImportedServiceId
		{
			get
			{
				return this.importedServiceId_;
			}
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x001989BC File Offset: 0x00196BBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BindResponse);
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x001989DC File Offset: 0x00196BDC
		[DebuggerNonUserCode]
		public bool Equals(BindResponse other)
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
					bool flag4 = !this.importedServiceId_.Equals(other.importedServiceId_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x00198A38 File Offset: 0x00196C38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.importedServiceId_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00198A78 File Offset: 0x00196C78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00198A90 File Offset: 0x00196C90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x00198A9C File Offset: 0x00196C9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.importedServiceId_.WriteTo(ref output, BindResponse._repeated_importedServiceId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00198AD8 File Offset: 0x00196CD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.importedServiceId_.CalculateSize(BindResponse._repeated_importedServiceId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00198B20 File Offset: 0x00196D20
		[DebuggerNonUserCode]
		public void MergeFrom(BindResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.importedServiceId_.Add(other.importedServiceId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00198B62 File Offset: 0x00196D62
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00198B70 File Offset: 0x00196D70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.importedServiceId_.AddEntriesFrom(ref input, BindResponse._repeated_importedServiceId_codec);
				}
			}
		}

		// Token: 0x0400300A RID: 12298
		private static readonly MessageParser<BindResponse> _parser = new MessageParser<BindResponse>(() => new BindResponse());

		// Token: 0x0400300B RID: 12299
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400300C RID: 12300
		public const int ImportedServiceIdFieldNumber = 1;

		// Token: 0x0400300D RID: 12301
		private static readonly FieldCodec<uint> _repeated_importedServiceId_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400300E RID: 12302
		private readonly RepeatedField<uint> importedServiceId_ = new RepeatedField<uint>();
	}
}
