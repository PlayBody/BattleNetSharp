using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038C RID: 908
	public sealed class ProcessId : IMessage<ProcessId>, IMessage, IEquatable<ProcessId>, IDeepCloneable<ProcessId>, IBufferMessage
	{
		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x001648BC File Offset: 0x00162ABC
		[DebuggerNonUserCode]
		public static MessageParser<ProcessId> Parser
		{
			get
			{
				return ProcessId._parser;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001648D4 File Offset: 0x00162AD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x001648F8 File Offset: 0x00162AF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessId.Descriptor;
			}
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x0016490F File Offset: 0x00162B0F
		[DebuggerNonUserCode]
		public ProcessId()
		{
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00164919 File Offset: 0x00162B19
		[DebuggerNonUserCode]
		public ProcessId(ProcessId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.label_ = other.label_;
			this.epoch_ = other.epoch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00164958 File Offset: 0x00162B58
		[DebuggerNonUserCode]
		public ProcessId Clone()
		{
			return new ProcessId(this);
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x00164970 File Offset: 0x00162B70
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x001649A1 File Offset: 0x00162BA1
		[DebuggerNonUserCode]
		public uint Label
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint labelDefaultValue;
				if (flag)
				{
					labelDefaultValue = this.label_;
				}
				else
				{
					labelDefaultValue = ProcessId.LabelDefaultValue;
				}
				return labelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.label_ = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x001649BC File Offset: 0x00162BBC
		[DebuggerNonUserCode]
		public bool HasLabel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x001649D9 File Offset: 0x00162BD9
		[DebuggerNonUserCode]
		public void ClearLabel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x001649EC File Offset: 0x00162BEC
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x00164A1D File Offset: 0x00162C1D
		[DebuggerNonUserCode]
		public uint Epoch
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint epochDefaultValue;
				if (flag)
				{
					epochDefaultValue = this.epoch_;
				}
				else
				{
					epochDefaultValue = ProcessId.EpochDefaultValue;
				}
				return epochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.epoch_ = value;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x00164A38 File Offset: 0x00162C38
		[DebuggerNonUserCode]
		public bool HasEpoch
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00164A55 File Offset: 0x00162C55
		[DebuggerNonUserCode]
		public void ClearEpoch()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00164A68 File Offset: 0x00162C68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessId);
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00164A88 File Offset: 0x00162C88
		[DebuggerNonUserCode]
		public bool Equals(ProcessId other)
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
					bool flag4 = this.Label != other.Label;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Epoch != other.Epoch;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00164AFC File Offset: 0x00162CFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				num ^= this.Label.GetHashCode();
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num ^= this.Epoch.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00164B68 File Offset: 0x00162D68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00164B80 File Offset: 0x00162D80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00164B8C File Offset: 0x00162D8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Label);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Epoch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00164BFC File Offset: 0x00162DFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLabel = this.HasLabel;
			if (hasLabel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Label);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Epoch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00164C68 File Offset: 0x00162E68
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLabel = other.HasLabel;
				if (hasLabel)
				{
					this.Label = other.Label;
				}
				bool hasEpoch = other.HasEpoch;
				if (hasEpoch)
				{
					this.Epoch = other.Epoch;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00164CCA File Offset: 0x00162ECA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00164CD8 File Offset: 0x00162ED8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Epoch = input.ReadUInt32();
					}
				}
				else
				{
					this.Label = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002A17 RID: 10775
		private static readonly MessageParser<ProcessId> _parser = new MessageParser<ProcessId>(() => new ProcessId());

		// Token: 0x04002A18 RID: 10776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A19 RID: 10777
		private int _hasBits0;

		// Token: 0x04002A1A RID: 10778
		public const int LabelFieldNumber = 1;

		// Token: 0x04002A1B RID: 10779
		private static readonly uint LabelDefaultValue = 0U;

		// Token: 0x04002A1C RID: 10780
		private uint label_;

		// Token: 0x04002A1D RID: 10781
		public const int EpochFieldNumber = 2;

		// Token: 0x04002A1E RID: 10782
		private static readonly uint EpochDefaultValue = 0U;

		// Token: 0x04002A1F RID: 10783
		private uint epoch_;
	}
}
