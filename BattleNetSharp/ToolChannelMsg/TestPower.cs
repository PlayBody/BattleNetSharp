using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008D RID: 141
	public sealed class TestPower : IMessage<TestPower>, IMessage, IEquatable<TestPower>, IDeepCloneable<TestPower>, IBufferMessage
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00030E54 File Offset: 0x0002F054
		[DebuggerNonUserCode]
		public static MessageParser<TestPower> Parser
		{
			get
			{
				return TestPower._parser;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00030E6C File Offset: 0x0002F06C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[118];
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00030E90 File Offset: 0x0002F090
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestPower.Descriptor;
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00030EA7 File Offset: 0x0002F0A7
		[DebuggerNonUserCode]
		public TestPower()
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00030EB1 File Offset: 0x0002F0B1
		[DebuggerNonUserCode]
		public TestPower(TestPower other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoPower_ = other.snoPower_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		[DebuggerNonUserCode]
		public TestPower Clone()
		{
			return new TestPower(this);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00030EFC File Offset: 0x0002F0FC
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00030F2D File Offset: 0x0002F12D
		[DebuggerNonUserCode]
		public int SnoPower
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoPowerDefaultValue;
				if (flag)
				{
					snoPowerDefaultValue = this.snoPower_;
				}
				else
				{
					snoPowerDefaultValue = TestPower.SnoPowerDefaultValue;
				}
				return snoPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoPower_ = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00030F48 File Offset: 0x0002F148
		[DebuggerNonUserCode]
		public bool HasSnoPower
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00030F65 File Offset: 0x0002F165
		[DebuggerNonUserCode]
		public void ClearSnoPower()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00030F78 File Offset: 0x0002F178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestPower);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00030F98 File Offset: 0x0002F198
		[DebuggerNonUserCode]
		public bool Equals(TestPower other)
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
					bool flag4 = this.SnoPower != other.SnoPower;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				num ^= this.SnoPower.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00031040 File Offset: 0x0002F240
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00031058 File Offset: 0x0002F258
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00031064 File Offset: 0x0002F264
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoPower);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000310B0 File Offset: 0x0002F2B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoPower);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00031100 File Offset: 0x0002F300
		[DebuggerNonUserCode]
		public void MergeFrom(TestPower other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoPower = other.HasSnoPower;
				if (hasSnoPower)
				{
					this.SnoPower = other.SnoPower;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00031149 File Offset: 0x0002F349
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00031154 File Offset: 0x0002F354
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoPower = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400052C RID: 1324
		private static readonly MessageParser<TestPower> _parser = new MessageParser<TestPower>(() => new TestPower());

		// Token: 0x0400052D RID: 1325
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400052E RID: 1326
		private int _hasBits0;

		// Token: 0x0400052F RID: 1327
		public const int SnoPowerFieldNumber = 1;

		// Token: 0x04000530 RID: 1328
		private static readonly int SnoPowerDefaultValue = 0;

		// Token: 0x04000531 RID: 1329
		private int snoPower_;
	}
}
