using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F4 RID: 244
	public sealed class EffectGroupPlayerStop : IMessage<EffectGroupPlayerStop>, IMessage, IEquatable<EffectGroupPlayerStop>, IDeepCloneable<EffectGroupPlayerStop>, IBufferMessage
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00055024 File Offset: 0x00053224
		[DebuggerNonUserCode]
		public static MessageParser<EffectGroupPlayerStop> Parser
		{
			get
			{
				return EffectGroupPlayerStop._parser;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0005503C File Offset: 0x0005323C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[221];
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x00055064 File Offset: 0x00053264
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectGroupPlayerStop.Descriptor;
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0005507B File Offset: 0x0005327B
		[DebuggerNonUserCode]
		public EffectGroupPlayerStop()
		{
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00055085 File Offset: 0x00053285
		[DebuggerNonUserCode]
		public EffectGroupPlayerStop(EffectGroupPlayerStop other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reachedTheEnd_ = other.reachedTheEnd_;
			this.ticksPerSec_ = other.ticksPerSec_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000550C4 File Offset: 0x000532C4
		[DebuggerNonUserCode]
		public EffectGroupPlayerStop Clone()
		{
			return new EffectGroupPlayerStop(this);
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000550DC File Offset: 0x000532DC
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0005510D File Offset: 0x0005330D
		[DebuggerNonUserCode]
		public bool ReachedTheEnd
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool reachedTheEndDefaultValue;
				if (flag)
				{
					reachedTheEndDefaultValue = this.reachedTheEnd_;
				}
				else
				{
					reachedTheEndDefaultValue = EffectGroupPlayerStop.ReachedTheEndDefaultValue;
				}
				return reachedTheEndDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reachedTheEnd_ = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00055128 File Offset: 0x00053328
		[DebuggerNonUserCode]
		public bool HasReachedTheEnd
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00055145 File Offset: 0x00053345
		[DebuggerNonUserCode]
		public void ClearReachedTheEnd()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00055158 File Offset: 0x00053358
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x00055189 File Offset: 0x00053389
		[DebuggerNonUserCode]
		public int TicksPerSec
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int ticksPerSecDefaultValue;
				if (flag)
				{
					ticksPerSecDefaultValue = this.ticksPerSec_;
				}
				else
				{
					ticksPerSecDefaultValue = EffectGroupPlayerStop.TicksPerSecDefaultValue;
				}
				return ticksPerSecDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.ticksPerSec_ = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x000551A4 File Offset: 0x000533A4
		[DebuggerNonUserCode]
		public bool HasTicksPerSec
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000551C1 File Offset: 0x000533C1
		[DebuggerNonUserCode]
		public void ClearTicksPerSec()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000551D4 File Offset: 0x000533D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectGroupPlayerStop);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x000551F4 File Offset: 0x000533F4
		[DebuggerNonUserCode]
		public bool Equals(EffectGroupPlayerStop other)
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
					bool flag4 = this.ReachedTheEnd != other.ReachedTheEnd;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TicksPerSec != other.TicksPerSec;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00055268 File Offset: 0x00053468
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReachedTheEnd = this.HasReachedTheEnd;
			if (hasReachedTheEnd)
			{
				num ^= this.ReachedTheEnd.GetHashCode();
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				num ^= this.TicksPerSec.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000552D8 File Offset: 0x000534D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000552F0 File Offset: 0x000534F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000552FC File Offset: 0x000534FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReachedTheEnd = this.HasReachedTheEnd;
			if (hasReachedTheEnd)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ReachedTheEnd);
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TicksPerSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0005536C File Offset: 0x0005356C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReachedTheEnd = this.HasReachedTheEnd;
			if (hasReachedTheEnd)
			{
				num += 2;
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TicksPerSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x000553CC File Offset: 0x000535CC
		[DebuggerNonUserCode]
		public void MergeFrom(EffectGroupPlayerStop other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReachedTheEnd = other.HasReachedTheEnd;
				if (hasReachedTheEnd)
				{
					this.ReachedTheEnd = other.ReachedTheEnd;
				}
				bool hasTicksPerSec = other.HasTicksPerSec;
				if (hasTicksPerSec)
				{
					this.TicksPerSec = other.TicksPerSec;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0005542E File Offset: 0x0005362E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0005543C File Offset: 0x0005363C
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
						this.TicksPerSec = input.ReadInt32();
					}
				}
				else
				{
					this.ReachedTheEnd = input.ReadBool();
				}
			}
		}

		// Token: 0x0400098A RID: 2442
		private static readonly MessageParser<EffectGroupPlayerStop> _parser = new MessageParser<EffectGroupPlayerStop>(() => new EffectGroupPlayerStop());

		// Token: 0x0400098B RID: 2443
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400098C RID: 2444
		private int _hasBits0;

		// Token: 0x0400098D RID: 2445
		public const int ReachedTheEndFieldNumber = 1;

		// Token: 0x0400098E RID: 2446
		private static readonly bool ReachedTheEndDefaultValue = false;

		// Token: 0x0400098F RID: 2447
		private bool reachedTheEnd_;

		// Token: 0x04000990 RID: 2448
		public const int TicksPerSecFieldNumber = 2;

		// Token: 0x04000991 RID: 2449
		private static readonly int TicksPerSecDefaultValue = 0;

		// Token: 0x04000992 RID: 2450
		private int ticksPerSec_;
	}
}
