using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000579 RID: 1401
	public sealed class CustomReport : IMessage<CustomReport>, IMessage, IEquatable<CustomReport>, IDeepCloneable<CustomReport>, IBufferMessage
	{
		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x0020BC0C File Offset: 0x00209E0C
		[DebuggerNonUserCode]
		public static MessageParser<CustomReport> Parser
		{
			get
			{
				return CustomReport._parser;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x060086AC RID: 34476 RVA: 0x0020BC24 File Offset: 0x00209E24
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x0020BC48 File Offset: 0x00209E48
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CustomReport.Descriptor;
			}
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x0020BC5F File Offset: 0x00209E5F
		[DebuggerNonUserCode]
		public CustomReport()
		{
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x0020BC74 File Offset: 0x00209E74
		[DebuggerNonUserCode]
		public CustomReport(CustomReport other)
			: this()
		{
			this.type_ = other.type_;
			this.programId_ = other.programId_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x0020BCC4 File Offset: 0x00209EC4
		[DebuggerNonUserCode]
		public CustomReport Clone()
		{
			return new CustomReport(this);
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x060086B1 RID: 34481 RVA: 0x0020BCDC File Offset: 0x00209EDC
		// (set) Token: 0x060086B2 RID: 34482 RVA: 0x0020BCFD File Offset: 0x00209EFD
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? CustomReport.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x0020BD14 File Offset: 0x00209F14
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x0020BD2F File Offset: 0x00209F2F
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x0020BD3C File Offset: 0x00209F3C
		// (set) Token: 0x060086B6 RID: 34486 RVA: 0x0020BD5D File Offset: 0x00209F5D
		[Obsolete]
		[DebuggerNonUserCode]
		public string ProgramId
		{
			get
			{
				return this.programId_ ?? CustomReport.ProgramIdDefaultValue;
			}
			set
			{
				this.programId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x0020BD74 File Offset: 0x00209F74
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasProgramId
		{
			get
			{
				return this.programId_ != null;
			}
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x0020BD8F File Offset: 0x00209F8F
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearProgramId()
		{
			this.programId_ = null;
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x0020BD9C File Offset: 0x00209F9C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x0020BDB4 File Offset: 0x00209FB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CustomReport);
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x0020BDD4 File Offset: 0x00209FD4
		[DebuggerNonUserCode]
		public bool Equals(CustomReport other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ProgramId != other.ProgramId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x0020BE64 File Offset: 0x0020A064
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasProgramId = this.HasProgramId;
			if (hasProgramId)
			{
				num ^= this.ProgramId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x0020BED8 File Offset: 0x0020A0D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x0020BEF0 File Offset: 0x0020A0F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x0020BEFC File Offset: 0x0020A0FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			bool hasProgramId = this.HasProgramId;
			if (hasProgramId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ProgramId);
			}
			this.attribute_.WriteTo(ref output, CustomReport._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x0020BF7C File Offset: 0x0020A17C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasProgramId = this.HasProgramId;
			if (hasProgramId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProgramId);
			}
			num += this.attribute_.CalculateSize(CustomReport._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x0020BFFC File Offset: 0x0020A1FC
		[DebuggerNonUserCode]
		public void MergeFrom(CustomReport other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasProgramId = other.HasProgramId;
				if (hasProgramId)
				{
					this.ProgramId = other.ProgramId;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x0020C070 File Offset: 0x0020A270
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x0020C07C File Offset: 0x0020A27C
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
							this.attribute_.AddEntriesFrom(ref input, CustomReport._repeated_attribute_codec);
						}
					}
					else
					{
						this.ProgramId = input.ReadString();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x04003D09 RID: 15625
		private static readonly MessageParser<CustomReport> _parser = new MessageParser<CustomReport>(() => new CustomReport());

		// Token: 0x04003D0A RID: 15626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D0B RID: 15627
		public const int TypeFieldNumber = 1;

		// Token: 0x04003D0C RID: 15628
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04003D0D RID: 15629
		private string type_;

		// Token: 0x04003D0E RID: 15630
		public const int ProgramIdFieldNumber = 2;

		// Token: 0x04003D0F RID: 15631
		private static readonly string ProgramIdDefaultValue = "";

		// Token: 0x04003D10 RID: 15632
		private string programId_;

		// Token: 0x04003D11 RID: 15633
		public const int AttributeFieldNumber = 3;

		// Token: 0x04003D12 RID: 15634
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04003D13 RID: 15635
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
