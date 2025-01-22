using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002E2 RID: 738
	public sealed class LogMessageOptions : IMessage<LogMessageOptions>, IMessage, IEquatable<LogMessageOptions>, IDeepCloneable<LogMessageOptions>, IBufferMessage
	{
		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06004DDD RID: 19933 RVA: 0x00129F4C File Offset: 0x0012814C
		[DebuggerNonUserCode]
		public static MessageParser<LogMessageOptions> Parser
		{
			get
			{
				return LogMessageOptions._parser;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x00129F64 File Offset: 0x00128164
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x00129F88 File Offset: 0x00128188
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogMessageOptions.Descriptor;
			}
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x00129F9F File Offset: 0x0012819F
		[DebuggerNonUserCode]
		public LogMessageOptions()
		{
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00129FA9 File Offset: 0x001281A9
		[DebuggerNonUserCode]
		public LogMessageOptions(LogMessageOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.grok_ = other.grok_;
			this.isJson_ = other.isJson_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00129FE8 File Offset: 0x001281E8
		[DebuggerNonUserCode]
		public LogMessageOptions Clone()
		{
			return new LogMessageOptions(this);
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x0012A000 File Offset: 0x00128200
		// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x0012A021 File Offset: 0x00128221
		[DebuggerNonUserCode]
		public string Grok
		{
			get
			{
				return this.grok_ ?? LogMessageOptions.GrokDefaultValue;
			}
			set
			{
				this.grok_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x0012A038 File Offset: 0x00128238
		[DebuggerNonUserCode]
		public bool HasGrok
		{
			get
			{
				return this.grok_ != null;
			}
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x0012A053 File Offset: 0x00128253
		[DebuggerNonUserCode]
		public void ClearGrok()
		{
			this.grok_ = null;
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x0012A060 File Offset: 0x00128260
		// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x0012A091 File Offset: 0x00128291
		[DebuggerNonUserCode]
		public bool IsJson
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isJsonDefaultValue;
				if (flag)
				{
					isJsonDefaultValue = this.isJson_;
				}
				else
				{
					isJsonDefaultValue = LogMessageOptions.IsJsonDefaultValue;
				}
				return isJsonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isJson_ = value;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x0012A0AC File Offset: 0x001282AC
		[DebuggerNonUserCode]
		public bool HasIsJson
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x0012A0C9 File Offset: 0x001282C9
		[DebuggerNonUserCode]
		public void ClearIsJson()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x0012A0DC File Offset: 0x001282DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogMessageOptions);
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x0012A0FC File Offset: 0x001282FC
		[DebuggerNonUserCode]
		public bool Equals(LogMessageOptions other)
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
					bool flag4 = this.Grok != other.Grok;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsJson != other.IsJson;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x0012A170 File Offset: 0x00128370
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGrok = this.HasGrok;
			if (hasGrok)
			{
				num ^= this.Grok.GetHashCode();
			}
			bool hasIsJson = this.HasIsJson;
			if (hasIsJson)
			{
				num ^= this.IsJson.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x0012A1DC File Offset: 0x001283DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x0012A1F4 File Offset: 0x001283F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x0012A200 File Offset: 0x00128400
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGrok = this.HasGrok;
			if (hasGrok)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Grok);
			}
			bool hasIsJson = this.HasIsJson;
			if (hasIsJson)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsJson);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x0012A270 File Offset: 0x00128470
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGrok = this.HasGrok;
			if (hasGrok)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Grok);
			}
			bool hasIsJson = this.HasIsJson;
			if (hasIsJson)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x0012A2D0 File Offset: 0x001284D0
		[DebuggerNonUserCode]
		public void MergeFrom(LogMessageOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGrok = other.HasGrok;
				if (hasGrok)
				{
					this.Grok = other.Grok;
				}
				bool hasIsJson = other.HasIsJson;
				if (hasIsJson)
				{
					this.IsJson = other.IsJson;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x0012A332 File Offset: 0x00128532
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x0012A340 File Offset: 0x00128540
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsJson = input.ReadBool();
					}
				}
				else
				{
					this.Grok = input.ReadString();
				}
			}
		}

		// Token: 0x040022BC RID: 8892
		private static readonly MessageParser<LogMessageOptions> _parser = new MessageParser<LogMessageOptions>(() => new LogMessageOptions());

		// Token: 0x040022BD RID: 8893
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022BE RID: 8894
		private int _hasBits0;

		// Token: 0x040022BF RID: 8895
		public const int GrokFieldNumber = 1;

		// Token: 0x040022C0 RID: 8896
		private static readonly string GrokDefaultValue = "";

		// Token: 0x040022C1 RID: 8897
		private string grok_;

		// Token: 0x040022C2 RID: 8898
		public const int IsJsonFieldNumber = 2;

		// Token: 0x040022C3 RID: 8899
		private static readonly bool IsJsonDefaultValue = false;

		// Token: 0x040022C4 RID: 8900
		private bool isJson_;
	}
}
