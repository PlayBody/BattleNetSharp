using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000089 RID: 137
	public sealed class AxePrefsXmlUpdate : IMessage<AxePrefsXmlUpdate>, IMessage, IEquatable<AxePrefsXmlUpdate>, IDeepCloneable<AxePrefsXmlUpdate>, IBufferMessage
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0002FD5C File Offset: 0x0002DF5C
		[DebuggerNonUserCode]
		public static MessageParser<AxePrefsXmlUpdate> Parser
		{
			get
			{
				return AxePrefsXmlUpdate._parser;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0002FD74 File Offset: 0x0002DF74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[114];
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0002FD98 File Offset: 0x0002DF98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxePrefsXmlUpdate.Descriptor;
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0002FDAF File Offset: 0x0002DFAF
		[DebuggerNonUserCode]
		public AxePrefsXmlUpdate()
		{
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0002FDB9 File Offset: 0x0002DFB9
		[DebuggerNonUserCode]
		public AxePrefsXmlUpdate(AxePrefsXmlUpdate other)
			: this()
		{
			this.axePrefsXml_ = other.axePrefsXml_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
		[DebuggerNonUserCode]
		public AxePrefsXmlUpdate Clone()
		{
			return new AxePrefsXmlUpdate(this);
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0002FE19 File Offset: 0x0002E019
		[DebuggerNonUserCode]
		public string AxePrefsXml
		{
			get
			{
				return this.axePrefsXml_ ?? AxePrefsXmlUpdate.AxePrefsXmlDefaultValue;
			}
			set
			{
				this.axePrefsXml_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0002FE30 File Offset: 0x0002E030
		[DebuggerNonUserCode]
		public bool HasAxePrefsXml
		{
			get
			{
				return this.axePrefsXml_ != null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0002FE4B File Offset: 0x0002E04B
		[DebuggerNonUserCode]
		public void ClearAxePrefsXml()
		{
			this.axePrefsXml_ = null;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0002FE58 File Offset: 0x0002E058
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxePrefsXmlUpdate);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0002FE78 File Offset: 0x0002E078
		[DebuggerNonUserCode]
		public bool Equals(AxePrefsXmlUpdate other)
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
					bool flag4 = this.AxePrefsXml != other.AxePrefsXml;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0002FED0 File Offset: 0x0002E0D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAxePrefsXml = this.HasAxePrefsXml;
			if (hasAxePrefsXml)
			{
				num ^= this.AxePrefsXml.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002FF1C File Offset: 0x0002E11C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0002FF34 File Offset: 0x0002E134
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0002FF40 File Offset: 0x0002E140
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAxePrefsXml = this.HasAxePrefsXml;
			if (hasAxePrefsXml)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AxePrefsXml);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0002FF8C File Offset: 0x0002E18C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAxePrefsXml = this.HasAxePrefsXml;
			if (hasAxePrefsXml)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AxePrefsXml);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0002FFDC File Offset: 0x0002E1DC
		[DebuggerNonUserCode]
		public void MergeFrom(AxePrefsXmlUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAxePrefsXml = other.HasAxePrefsXml;
				if (hasAxePrefsXml)
				{
					this.AxePrefsXml = other.AxePrefsXml;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00030025 File Offset: 0x0002E225
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00030030 File Offset: 0x0002E230
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
					this.AxePrefsXml = input.ReadString();
				}
			}
		}

		// Token: 0x0400050D RID: 1293
		private static readonly MessageParser<AxePrefsXmlUpdate> _parser = new MessageParser<AxePrefsXmlUpdate>(() => new AxePrefsXmlUpdate());

		// Token: 0x0400050E RID: 1294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400050F RID: 1295
		public const int AxePrefsXmlFieldNumber = 1;

		// Token: 0x04000510 RID: 1296
		private static readonly string AxePrefsXmlDefaultValue = "";

		// Token: 0x04000511 RID: 1297
		private string axePrefsXml_;
	}
}
