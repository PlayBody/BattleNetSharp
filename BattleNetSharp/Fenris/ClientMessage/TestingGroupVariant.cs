using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021E RID: 542
	public sealed class TestingGroupVariant : IMessage<TestingGroupVariant>, IMessage, IEquatable<TestingGroupVariant>, IDeepCloneable<TestingGroupVariant>, IBufferMessage
	{
		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x000E943C File Offset: 0x000E763C
		[DebuggerNonUserCode]
		public static MessageParser<TestingGroupVariant> Parser
		{
			get
			{
				return TestingGroupVariant._parser;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x000E9454 File Offset: 0x000E7654
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x000E9478 File Offset: 0x000E7678
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestingGroupVariant.Descriptor;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000E948F File Offset: 0x000E768F
		[DebuggerNonUserCode]
		public TestingGroupVariant()
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000E9499 File Offset: 0x000E7699
		[DebuggerNonUserCode]
		public TestingGroupVariant(TestingGroupVariant other)
			: this()
		{
			this.experimentName_ = other.experimentName_;
			this.variation_ = other.variation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000E94CC File Offset: 0x000E76CC
		[DebuggerNonUserCode]
		public TestingGroupVariant Clone()
		{
			return new TestingGroupVariant(this);
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x000E94E4 File Offset: 0x000E76E4
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x000E9505 File Offset: 0x000E7705
		[DebuggerNonUserCode]
		public string ExperimentName
		{
			get
			{
				return this.experimentName_ ?? TestingGroupVariant.ExperimentNameDefaultValue;
			}
			set
			{
				this.experimentName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x000E951C File Offset: 0x000E771C
		[DebuggerNonUserCode]
		public bool HasExperimentName
		{
			get
			{
				return this.experimentName_ != null;
			}
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x000E9537 File Offset: 0x000E7737
		[DebuggerNonUserCode]
		public void ClearExperimentName()
		{
			this.experimentName_ = null;
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x000E9544 File Offset: 0x000E7744
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x000E9565 File Offset: 0x000E7765
		[DebuggerNonUserCode]
		public string Variation
		{
			get
			{
				return this.variation_ ?? TestingGroupVariant.VariationDefaultValue;
			}
			set
			{
				this.variation_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x000E957C File Offset: 0x000E777C
		[DebuggerNonUserCode]
		public bool HasVariation
		{
			get
			{
				return this.variation_ != null;
			}
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x000E9597 File Offset: 0x000E7797
		[DebuggerNonUserCode]
		public void ClearVariation()
		{
			this.variation_ = null;
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x000E95A4 File Offset: 0x000E77A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestingGroupVariant);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000E95C4 File Offset: 0x000E77C4
		[DebuggerNonUserCode]
		public bool Equals(TestingGroupVariant other)
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
						bool flag5 = this.Variation != other.Variation;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x000E9638 File Offset: 0x000E7838
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				num ^= this.ExperimentName.GetHashCode();
			}
			bool hasVariation = this.HasVariation;
			if (hasVariation)
			{
				num ^= this.Variation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x000E969C File Offset: 0x000E789C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x000E96B4 File Offset: 0x000E78B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x000E96C0 File Offset: 0x000E78C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ExperimentName);
			}
			bool hasVariation = this.HasVariation;
			if (hasVariation)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Variation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x000E9730 File Offset: 0x000E7930
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasExperimentName = this.HasExperimentName;
			if (hasExperimentName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExperimentName);
			}
			bool hasVariation = this.HasVariation;
			if (hasVariation)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Variation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x000E979C File Offset: 0x000E799C
		[DebuggerNonUserCode]
		public void MergeFrom(TestingGroupVariant other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasExperimentName = other.HasExperimentName;
				if (hasExperimentName)
				{
					this.ExperimentName = other.ExperimentName;
				}
				bool hasVariation = other.HasVariation;
				if (hasVariation)
				{
					this.Variation = other.Variation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x000E97FE File Offset: 0x000E79FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x000E980C File Offset: 0x000E7A0C
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
						this.Variation = input.ReadString();
					}
				}
				else
				{
					this.ExperimentName = input.ReadString();
				}
			}
		}

		// Token: 0x04001B20 RID: 6944
		private static readonly MessageParser<TestingGroupVariant> _parser = new MessageParser<TestingGroupVariant>(() => new TestingGroupVariant());

		// Token: 0x04001B21 RID: 6945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B22 RID: 6946
		public const int ExperimentNameFieldNumber = 1;

		// Token: 0x04001B23 RID: 6947
		private static readonly string ExperimentNameDefaultValue = "";

		// Token: 0x04001B24 RID: 6948
		private string experimentName_;

		// Token: 0x04001B25 RID: 6949
		public const int VariationFieldNumber = 2;

		// Token: 0x04001B26 RID: 6950
		private static readonly string VariationDefaultValue = "";

		// Token: 0x04001B27 RID: 6951
		private string variation_;
	}
}
