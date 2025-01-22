using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000146 RID: 326
	public sealed class PingResult : IMessage<PingResult>, IMessage, IEquatable<PingResult>, IDeepCloneable<PingResult>, IBufferMessage
	{
		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00083C80 File Offset: 0x00081E80
		[DebuggerNonUserCode]
		public static MessageParser<PingResult> Parser
		{
			get
			{
				return PingResult._parser;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00083C98 File Offset: 0x00081E98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00083CBC File Offset: 0x00081EBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PingResult.Descriptor;
			}
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00083CD3 File Offset: 0x00081ED3
		[DebuggerNonUserCode]
		public PingResult()
		{
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00083CDD File Offset: 0x00081EDD
		[DebuggerNonUserCode]
		public PingResult(PingResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serverPool_ = other.serverPool_;
			this.latency_ = other.latency_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00083D1C File Offset: 0x00081F1C
		[DebuggerNonUserCode]
		public PingResult Clone()
		{
			return new PingResult(this);
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x00083D34 File Offset: 0x00081F34
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x00083D55 File Offset: 0x00081F55
		[DebuggerNonUserCode]
		public string ServerPool
		{
			get
			{
				return this.serverPool_ ?? PingResult.ServerPoolDefaultValue;
			}
			set
			{
				this.serverPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x00083D6C File Offset: 0x00081F6C
		[DebuggerNonUserCode]
		public bool HasServerPool
		{
			get
			{
				return this.serverPool_ != null;
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00083D87 File Offset: 0x00081F87
		[DebuggerNonUserCode]
		public void ClearServerPool()
		{
			this.serverPool_ = null;
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00083D94 File Offset: 0x00081F94
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00083DC5 File Offset: 0x00081FC5
		[DebuggerNonUserCode]
		public uint Latency
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint latencyDefaultValue;
				if (flag)
				{
					latencyDefaultValue = this.latency_;
				}
				else
				{
					latencyDefaultValue = PingResult.LatencyDefaultValue;
				}
				return latencyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.latency_ = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00083DE0 File Offset: 0x00081FE0
		[DebuggerNonUserCode]
		public bool HasLatency
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00083DFD File Offset: 0x00081FFD
		[DebuggerNonUserCode]
		public void ClearLatency()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00083E10 File Offset: 0x00082010
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PingResult);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00083E30 File Offset: 0x00082030
		[DebuggerNonUserCode]
		public bool Equals(PingResult other)
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
					bool flag4 = this.ServerPool != other.ServerPool;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Latency != other.Latency;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00083EA4 File Offset: 0x000820A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num ^= this.ServerPool.GetHashCode();
			}
			bool hasLatency = this.HasLatency;
			if (hasLatency)
			{
				num ^= this.Latency.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00083F10 File Offset: 0x00082110
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00083F28 File Offset: 0x00082128
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00083F34 File Offset: 0x00082134
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ServerPool);
			}
			bool hasLatency = this.HasLatency;
			if (hasLatency)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Latency);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00083FA4 File Offset: 0x000821A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerPool);
			}
			bool hasLatency = this.HasLatency;
			if (hasLatency)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Latency);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00084010 File Offset: 0x00082210
		[DebuggerNonUserCode]
		public void MergeFrom(PingResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasServerPool = other.HasServerPool;
				if (hasServerPool)
				{
					this.ServerPool = other.ServerPool;
				}
				bool hasLatency = other.HasLatency;
				if (hasLatency)
				{
					this.Latency = other.Latency;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00084072 File Offset: 0x00082272
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00084080 File Offset: 0x00082280
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
						this.Latency = input.ReadUInt32();
					}
				}
				else
				{
					this.ServerPool = input.ReadString();
				}
			}
		}

		// Token: 0x04000EEE RID: 3822
		private static readonly MessageParser<PingResult> _parser = new MessageParser<PingResult>(() => new PingResult());

		// Token: 0x04000EEF RID: 3823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EF0 RID: 3824
		private int _hasBits0;

		// Token: 0x04000EF1 RID: 3825
		public const int ServerPoolFieldNumber = 1;

		// Token: 0x04000EF2 RID: 3826
		private static readonly string ServerPoolDefaultValue = "";

		// Token: 0x04000EF3 RID: 3827
		private string serverPool_;

		// Token: 0x04000EF4 RID: 3828
		public const int LatencyFieldNumber = 2;

		// Token: 0x04000EF5 RID: 3829
		private static readonly uint LatencyDefaultValue = 0U;

		// Token: 0x04000EF6 RID: 3830
		private uint latency_;
	}
}
