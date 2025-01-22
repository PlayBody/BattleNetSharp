using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000072 RID: 114
	public sealed class OpenScriptRequest : IMessage<OpenScriptRequest>, IMessage, IEquatable<OpenScriptRequest>, IDeepCloneable<OpenScriptRequest>, IBufferMessage
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00026FA8 File Offset: 0x000251A8
		[DebuggerNonUserCode]
		public static MessageParser<OpenScriptRequest> Parser
		{
			get
			{
				return OpenScriptRequest._parser;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00026FC0 File Offset: 0x000251C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[91];
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00026FE4 File Offset: 0x000251E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenScriptRequest.Descriptor;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00026FFB File Offset: 0x000251FB
		[DebuggerNonUserCode]
		public OpenScriptRequest()
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00027008 File Offset: 0x00025208
		[DebuggerNonUserCode]
		public OpenScriptRequest(OpenScriptRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.lineNumber_ = other.lineNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00027060 File Offset: 0x00025260
		[DebuggerNonUserCode]
		public OpenScriptRequest Clone()
		{
			return new OpenScriptRequest(this);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00027078 File Offset: 0x00025278
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000270A9 File Offset: 0x000252A9
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = OpenScriptRequest.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000270C4 File Offset: 0x000252C4
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000270E1 File Offset: 0x000252E1
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000270F4 File Offset: 0x000252F4
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00027125 File Offset: 0x00025325
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = OpenScriptRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00027140 File Offset: 0x00025340
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002715D File Offset: 0x0002535D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00027170 File Offset: 0x00025370
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x000271A1 File Offset: 0x000253A1
		[DebuggerNonUserCode]
		public int LineNumber
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int lineNumberDefaultValue;
				if (flag)
				{
					lineNumberDefaultValue = this.lineNumber_;
				}
				else
				{
					lineNumberDefaultValue = OpenScriptRequest.LineNumberDefaultValue;
				}
				return lineNumberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lineNumber_ = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000271BC File Offset: 0x000253BC
		[DebuggerNonUserCode]
		public bool HasLineNumber
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000271D9 File Offset: 0x000253D9
		[DebuggerNonUserCode]
		public void ClearLineNumber()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000271EC File Offset: 0x000253EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenScriptRequest);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002720C File Offset: 0x0002540C
		[DebuggerNonUserCode]
		public bool Equals(OpenScriptRequest other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LineNumber != other.LineNumber;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00027298 File Offset: 0x00025498
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasLineNumber = this.HasLineNumber;
			if (hasLineNumber)
			{
				num ^= this.LineNumber.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00027324 File Offset: 0x00025524
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002733C File Offset: 0x0002553C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00027348 File Offset: 0x00025548
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasLineNumber = this.HasLineNumber;
			if (hasLineNumber)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LineNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000273D8 File Offset: 0x000255D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasLineNumber = this.HasLineNumber;
			if (hasLineNumber)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LineNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00027464 File Offset: 0x00025664
		[DebuggerNonUserCode]
		public void MergeFrom(OpenScriptRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasLineNumber = other.HasLineNumber;
				if (hasLineNumber)
				{
					this.LineNumber = other.LineNumber;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000274DF File Offset: 0x000256DF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000274EC File Offset: 0x000256EC
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LineNumber = input.ReadInt32();
						}
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else
				{
					this.SnoGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003EA RID: 1002
		private static readonly MessageParser<OpenScriptRequest> _parser = new MessageParser<OpenScriptRequest>(() => new OpenScriptRequest());

		// Token: 0x040003EB RID: 1003
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003EC RID: 1004
		private int _hasBits0;

		// Token: 0x040003ED RID: 1005
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040003EE RID: 1006
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040003EF RID: 1007
		private int snoGroup_;

		// Token: 0x040003F0 RID: 1008
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040003F1 RID: 1009
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040003F2 RID: 1010
		private int snoHandle_;

		// Token: 0x040003F3 RID: 1011
		public const int LineNumberFieldNumber = 3;

		// Token: 0x040003F4 RID: 1012
		private static readonly int LineNumberDefaultValue = 0;

		// Token: 0x040003F5 RID: 1013
		private int lineNumber_;
	}
}
