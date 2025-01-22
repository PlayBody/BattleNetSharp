using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000430 RID: 1072
	public sealed class BindRequest : IMessage<BindRequest>, IMessage, IEquatable<BindRequest>, IDeepCloneable<BindRequest>, IBufferMessage
	{
		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x00198380 File Offset: 0x00196580
		[DebuggerNonUserCode]
		public static MessageParser<BindRequest> Parser
		{
			get
			{
				return BindRequest._parser;
			}
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x00198398 File Offset: 0x00196598
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x0600696C RID: 26988 RVA: 0x001983BC File Offset: 0x001965BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BindRequest.Descriptor;
			}
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x001983D3 File Offset: 0x001965D3
		[DebuggerNonUserCode]
		public BindRequest()
		{
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x0019840C File Offset: 0x0019660C
		[DebuggerNonUserCode]
		public BindRequest(BindRequest other)
			: this()
		{
			this.deprecatedImportedServiceHash_ = other.deprecatedImportedServiceHash_.Clone();
			this.deprecatedExportedService_ = other.deprecatedExportedService_.Clone();
			this.exportedService_ = other.exportedService_.Clone();
			this.importedService_ = other.importedService_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x00198478 File Offset: 0x00196678
		[DebuggerNonUserCode]
		public BindRequest Clone()
		{
			return new BindRequest(this);
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006970 RID: 26992 RVA: 0x00198490 File Offset: 0x00196690
		[Obsolete]
		[DebuggerNonUserCode]
		public RepeatedField<uint> DeprecatedImportedServiceHash
		{
			get
			{
				return this.deprecatedImportedServiceHash_;
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x001984A8 File Offset: 0x001966A8
		[Obsolete]
		[DebuggerNonUserCode]
		public RepeatedField<BoundService> DeprecatedExportedService
		{
			get
			{
				return this.deprecatedExportedService_;
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x001984C0 File Offset: 0x001966C0
		[DebuggerNonUserCode]
		public RepeatedField<BoundService> ExportedService
		{
			get
			{
				return this.exportedService_;
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x001984D8 File Offset: 0x001966D8
		[DebuggerNonUserCode]
		public RepeatedField<BoundService> ImportedService
		{
			get
			{
				return this.importedService_;
			}
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x001984F0 File Offset: 0x001966F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BindRequest);
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x00198510 File Offset: 0x00196710
		[DebuggerNonUserCode]
		public bool Equals(BindRequest other)
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
					bool flag4 = !this.deprecatedImportedServiceHash_.Equals(other.deprecatedImportedServiceHash_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.deprecatedExportedService_.Equals(other.deprecatedExportedService_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.exportedService_.Equals(other.exportedService_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.importedService_.Equals(other.importedService_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x001985CC File Offset: 0x001967CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.deprecatedImportedServiceHash_.GetHashCode();
			num ^= this.deprecatedExportedService_.GetHashCode();
			num ^= this.exportedService_.GetHashCode();
			num ^= this.importedService_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x00198638 File Offset: 0x00196838
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x00198650 File Offset: 0x00196850
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x0019865C File Offset: 0x0019685C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.deprecatedImportedServiceHash_.WriteTo(ref output, BindRequest._repeated_deprecatedImportedServiceHash_codec);
			this.deprecatedExportedService_.WriteTo(ref output, BindRequest._repeated_deprecatedExportedService_codec);
			this.exportedService_.WriteTo(ref output, BindRequest._repeated_exportedService_codec);
			this.importedService_.WriteTo(ref output, BindRequest._repeated_importedService_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x001986D0 File Offset: 0x001968D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.deprecatedImportedServiceHash_.CalculateSize(BindRequest._repeated_deprecatedImportedServiceHash_codec);
			num += this.deprecatedExportedService_.CalculateSize(BindRequest._repeated_deprecatedExportedService_codec);
			num += this.exportedService_.CalculateSize(BindRequest._repeated_exportedService_codec);
			num += this.importedService_.CalculateSize(BindRequest._repeated_importedService_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x00198750 File Offset: 0x00196950
		[DebuggerNonUserCode]
		public void MergeFrom(BindRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.deprecatedImportedServiceHash_.Add(other.deprecatedImportedServiceHash_);
				this.deprecatedExportedService_.Add(other.deprecatedExportedService_);
				this.exportedService_.Add(other.exportedService_);
				this.importedService_.Add(other.importedService_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x001987C8 File Offset: 0x001969C8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x001987D4 File Offset: 0x001969D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 13U)
				{
					if (num3 != 10U && num3 != 13U)
					{
						goto IL_0033;
					}
					this.deprecatedImportedServiceHash_.AddEntriesFrom(ref input, BindRequest._repeated_deprecatedImportedServiceHash_codec);
				}
				else if (num3 != 18U)
				{
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0033;
						}
						this.importedService_.AddEntriesFrom(ref input, BindRequest._repeated_importedService_codec);
					}
					else
					{
						this.exportedService_.AddEntriesFrom(ref input, BindRequest._repeated_exportedService_codec);
					}
				}
				else
				{
					this.deprecatedExportedService_.AddEntriesFrom(ref input, BindRequest._repeated_deprecatedExportedService_codec);
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FFC RID: 12284
		private static readonly MessageParser<BindRequest> _parser = new MessageParser<BindRequest>(() => new BindRequest());

		// Token: 0x04002FFD RID: 12285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FFE RID: 12286
		public const int DeprecatedImportedServiceHashFieldNumber = 1;

		// Token: 0x04002FFF RID: 12287
		private static readonly FieldCodec<uint> _repeated_deprecatedImportedServiceHash_codec = FieldCodec.ForFixed32(10U);

		// Token: 0x04003000 RID: 12288
		private readonly RepeatedField<uint> deprecatedImportedServiceHash_ = new RepeatedField<uint>();

		// Token: 0x04003001 RID: 12289
		public const int DeprecatedExportedServiceFieldNumber = 2;

		// Token: 0x04003002 RID: 12290
		private static readonly FieldCodec<BoundService> _repeated_deprecatedExportedService_codec = FieldCodec.ForMessage<BoundService>(18U, BoundService.Parser);

		// Token: 0x04003003 RID: 12291
		private readonly RepeatedField<BoundService> deprecatedExportedService_ = new RepeatedField<BoundService>();

		// Token: 0x04003004 RID: 12292
		public const int ExportedServiceFieldNumber = 3;

		// Token: 0x04003005 RID: 12293
		private static readonly FieldCodec<BoundService> _repeated_exportedService_codec = FieldCodec.ForMessage<BoundService>(26U, BoundService.Parser);

		// Token: 0x04003006 RID: 12294
		private readonly RepeatedField<BoundService> exportedService_ = new RepeatedField<BoundService>();

		// Token: 0x04003007 RID: 12295
		public const int ImportedServiceFieldNumber = 4;

		// Token: 0x04003008 RID: 12296
		private static readonly FieldCodec<BoundService> _repeated_importedService_codec = FieldCodec.ForMessage<BoundService>(34U, BoundService.Parser);

		// Token: 0x04003009 RID: 12297
		private readonly RepeatedField<BoundService> importedService_ = new RepeatedField<BoundService>();
	}
}
