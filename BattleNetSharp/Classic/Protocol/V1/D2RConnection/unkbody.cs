using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x0200076E RID: 1902
	public sealed class unkbody : IMessage<unkbody>, IMessage, IEquatable<unkbody>, IDeepCloneable<unkbody>, IBufferMessage
	{
		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x002A81D8 File Offset: 0x002A63D8
		[DebuggerNonUserCode]
		public static MessageParser<unkbody> Parser
		{
			get
			{
				return unkbody._parser;
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x002A81F0 File Offset: 0x002A63F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x002A8214 File Offset: 0x002A6414
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return unkbody.Descriptor;
			}
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x002A822B File Offset: 0x002A642B
		[DebuggerNonUserCode]
		public unkbody()
		{
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x002A8235 File Offset: 0x002A6435
		[DebuggerNonUserCode]
		public unkbody(unkbody other)
			: this()
		{
			this.test_ = other.test_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x002A825C File Offset: 0x002A645C
		[DebuggerNonUserCode]
		public unkbody Clone()
		{
			return new unkbody(this);
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600AE9D RID: 44701 RVA: 0x002A8274 File Offset: 0x002A6474
		// (set) Token: 0x0600AE9E RID: 44702 RVA: 0x002A8295 File Offset: 0x002A6495
		[DebuggerNonUserCode]
		public string Test
		{
			get
			{
				return this.test_ ?? unkbody.TestDefaultValue;
			}
			set
			{
				this.test_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x002A82AC File Offset: 0x002A64AC
		[DebuggerNonUserCode]
		public bool HasTest
		{
			get
			{
				return this.test_ != null;
			}
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x002A82C7 File Offset: 0x002A64C7
		[DebuggerNonUserCode]
		public void ClearTest()
		{
			this.test_ = null;
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x002A82D4 File Offset: 0x002A64D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as unkbody);
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x002A82F4 File Offset: 0x002A64F4
		[DebuggerNonUserCode]
		public bool Equals(unkbody other)
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
					bool flag4 = this.Test != other.Test;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x002A834C File Offset: 0x002A654C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTest = this.HasTest;
			if (hasTest)
			{
				num ^= this.Test.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x002A8398 File Offset: 0x002A6598
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002A83B0 File Offset: 0x002A65B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x002A83BC File Offset: 0x002A65BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTest = this.HasTest;
			if (hasTest)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Test);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x002A8408 File Offset: 0x002A6608
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTest = this.HasTest;
			if (hasTest)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Test);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x002A8458 File Offset: 0x002A6658
		[DebuggerNonUserCode]
		public void MergeFrom(unkbody other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTest = other.HasTest;
				if (hasTest)
				{
					this.Test = other.Test;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x002A84A1 File Offset: 0x002A66A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x002A84AC File Offset: 0x002A66AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Test = input.ReadString();
				}
			}
		}

		// Token: 0x04004EAA RID: 20138
		private static readonly MessageParser<unkbody> _parser = new MessageParser<unkbody>(() => new unkbody());

		// Token: 0x04004EAB RID: 20139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EAC RID: 20140
		public const int TestFieldNumber = 2;

		// Token: 0x04004EAD RID: 20141
		private static readonly string TestDefaultValue = "";

		// Token: 0x04004EAE RID: 20142
		private string test_;
	}
}
