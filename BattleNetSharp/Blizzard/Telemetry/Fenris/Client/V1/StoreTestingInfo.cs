using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000318 RID: 792
	public sealed class StoreTestingInfo : IMessage<StoreTestingInfo>, IMessage, IEquatable<StoreTestingInfo>, IDeepCloneable<StoreTestingInfo>, IBufferMessage
	{
		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x00140EB0 File Offset: 0x0013F0B0
		[DebuggerNonUserCode]
		public static MessageParser<StoreTestingInfo> Parser
		{
			get
			{
				return StoreTestingInfo._parser;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x00140EC8 File Offset: 0x0013F0C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreSessionInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x00140EEC File Offset: 0x0013F0EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreTestingInfo.Descriptor;
			}
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x00140F03 File Offset: 0x0013F103
		[DebuggerNonUserCode]
		public StoreTestingInfo()
		{
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x00140F0D File Offset: 0x0013F10D
		[DebuggerNonUserCode]
		public StoreTestingInfo(StoreTestingInfo other)
			: this()
		{
			this.experimentName_ = other.experimentName_;
			this.variant_ = other.variant_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00140F40 File Offset: 0x0013F140
		[DebuggerNonUserCode]
		public StoreTestingInfo Clone()
		{
			return new StoreTestingInfo(this);
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x00140F58 File Offset: 0x0013F158
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x00140F79 File Offset: 0x0013F179
		[DebuggerNonUserCode]
		public string ExperimentName
		{
			get
			{
				return this.experimentName_ ?? StoreTestingInfo.ExperimentNameDefaultValue;
			}
			set
			{
				this.experimentName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x00140F90 File Offset: 0x0013F190
		[DebuggerNonUserCode]
		public bool HasExperimentName
		{
			get
			{
				return this.experimentName_ != null;
			}
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00140FAB File Offset: 0x0013F1AB
		[DebuggerNonUserCode]
		public void ClearExperimentName()
		{
			this.experimentName_ = null;
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x00140FB8 File Offset: 0x0013F1B8
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x00140FD9 File Offset: 0x0013F1D9
		[DebuggerNonUserCode]
		public string Variant
		{
			get
			{
				return this.variant_ ?? StoreTestingInfo.VariantDefaultValue;
			}
			set
			{
				this.variant_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x00140FF0 File Offset: 0x0013F1F0
		[DebuggerNonUserCode]
		public bool HasVariant
		{
			get
			{
				return this.variant_ != null;
			}
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x0014100B File Offset: 0x0013F20B
		[DebuggerNonUserCode]
		public void ClearVariant()
		{
			this.variant_ = null;
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00141018 File Offset: 0x0013F218
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreTestingInfo);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00141038 File Offset: 0x0013F238
		[DebuggerNonUserCode]
		public bool Equals(StoreTestingInfo other)
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
					bool flag4 = this.ExperimentName != other.ExperimentName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Variant != other.Variant;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x001410AC File Offset: 0x0013F2AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				num ^= this.ExperimentName.GetHashCode();
			}
			bool hasVariant = this.HasVariant;
			if (hasVariant)
			{
				num ^= this.Variant.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x00141110 File Offset: 0x0013F310
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x00141128 File Offset: 0x0013F328
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x00141134 File Offset: 0x0013F334
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ExperimentName);
			}
			bool hasVariant = this.HasVariant;
			if (hasVariant)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Variant);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x001411A4 File Offset: 0x0013F3A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExperimentName);
			}
			bool hasVariant = this.HasVariant;
			if (hasVariant)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Variant);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00141210 File Offset: 0x0013F410
		[DebuggerNonUserCode]
		public void MergeFrom(StoreTestingInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasExperimentName = other.HasExperimentName;
				if (hasExperimentName)
				{
					this.ExperimentName = other.ExperimentName;
				}
				bool hasVariant = other.HasVariant;
				if (hasVariant)
				{
					this.Variant = other.Variant;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00141272 File Offset: 0x0013F472
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00141280 File Offset: 0x0013F480
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
						this.Variant = input.ReadString();
					}
				}
				else
				{
					this.ExperimentName = input.ReadString();
				}
			}
		}

		// Token: 0x040025AC RID: 9644
		private static readonly MessageParser<StoreTestingInfo> _parser = new MessageParser<StoreTestingInfo>(() => new StoreTestingInfo());

		// Token: 0x040025AD RID: 9645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025AE RID: 9646
		public const int ExperimentNameFieldNumber = 1;

		// Token: 0x040025AF RID: 9647
		private static readonly string ExperimentNameDefaultValue = "";

		// Token: 0x040025B0 RID: 9648
		private string experimentName_;

		// Token: 0x040025B1 RID: 9649
		public const int VariantFieldNumber = 2;

		// Token: 0x040025B2 RID: 9650
		private static readonly string VariantDefaultValue = "";

		// Token: 0x040025B3 RID: 9651
		private string variant_;
	}
}
