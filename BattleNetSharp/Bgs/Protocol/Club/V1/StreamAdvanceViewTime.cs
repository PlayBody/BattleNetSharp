using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FF RID: 1279
	public sealed class StreamAdvanceViewTime : IMessage<StreamAdvanceViewTime>, IMessage, IEquatable<StreamAdvanceViewTime>, IDeepCloneable<StreamAdvanceViewTime>, IBufferMessage
	{
		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x06007D1C RID: 32028 RVA: 0x001E7770 File Offset: 0x001E5970
		[DebuggerNonUserCode]
		public static MessageParser<StreamAdvanceViewTime> Parser
		{
			get
			{
				return StreamAdvanceViewTime._parser;
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06007D1D RID: 32029 RVA: 0x001E7788 File Offset: 0x001E5988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x06007D1E RID: 32030 RVA: 0x001E77AC File Offset: 0x001E59AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamAdvanceViewTime.Descriptor;
			}
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x001E77C3 File Offset: 0x001E59C3
		[DebuggerNonUserCode]
		public StreamAdvanceViewTime()
		{
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x001E77CD File Offset: 0x001E59CD
		[DebuggerNonUserCode]
		public StreamAdvanceViewTime(StreamAdvanceViewTime other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.streamId_ = other.streamId_;
			this.viewTime_ = other.viewTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x001E780C File Offset: 0x001E5A0C
		[DebuggerNonUserCode]
		public StreamAdvanceViewTime Clone()
		{
			return new StreamAdvanceViewTime(this);
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x001E7824 File Offset: 0x001E5A24
		// (set) Token: 0x06007D23 RID: 32035 RVA: 0x001E7855 File Offset: 0x001E5A55
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = StreamAdvanceViewTime.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x001E7870 File Offset: 0x001E5A70
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x001E788D File Offset: 0x001E5A8D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x001E78A0 File Offset: 0x001E5AA0
		// (set) Token: 0x06007D27 RID: 32039 RVA: 0x001E78D1 File Offset: 0x001E5AD1
		[DebuggerNonUserCode]
		public ulong ViewTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong viewTimeDefaultValue;
				if (flag)
				{
					viewTimeDefaultValue = this.viewTime_;
				}
				else
				{
					viewTimeDefaultValue = StreamAdvanceViewTime.ViewTimeDefaultValue;
				}
				return viewTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.viewTime_ = value;
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x001E78EC File Offset: 0x001E5AEC
		[DebuggerNonUserCode]
		public bool HasViewTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x001E7909 File Offset: 0x001E5B09
		[DebuggerNonUserCode]
		public void ClearViewTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x001E791C File Offset: 0x001E5B1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamAdvanceViewTime);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x001E793C File Offset: 0x001E5B3C
		[DebuggerNonUserCode]
		public bool Equals(StreamAdvanceViewTime other)
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
					bool flag4 = this.StreamId != other.StreamId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ViewTime != other.ViewTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x001E79B0 File Offset: 0x001E5BB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num ^= this.ViewTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D2D RID: 32045 RVA: 0x001E7A1C File Offset: 0x001E5C1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x001E7A34 File Offset: 0x001E5C34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x001E7A40 File Offset: 0x001E5C40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StreamId);
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ViewTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x001E7AB0 File Offset: 0x001E5CB0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ViewTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x001E7B1C File Offset: 0x001E5D1C
		[DebuggerNonUserCode]
		public void MergeFrom(StreamAdvanceViewTime other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool hasViewTime = other.HasViewTime;
				if (hasViewTime)
				{
					this.ViewTime = other.ViewTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x001E7B7E File Offset: 0x001E5D7E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x001E7B8C File Offset: 0x001E5D8C
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
						this.ViewTime = input.ReadUInt64();
					}
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040038EA RID: 14570
		private static readonly MessageParser<StreamAdvanceViewTime> _parser = new MessageParser<StreamAdvanceViewTime>(() => new StreamAdvanceViewTime());

		// Token: 0x040038EB RID: 14571
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038EC RID: 14572
		private int _hasBits0;

		// Token: 0x040038ED RID: 14573
		public const int StreamIdFieldNumber = 1;

		// Token: 0x040038EE RID: 14574
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040038EF RID: 14575
		private ulong streamId_;

		// Token: 0x040038F0 RID: 14576
		public const int ViewTimeFieldNumber = 2;

		// Token: 0x040038F1 RID: 14577
		private static readonly ulong ViewTimeDefaultValue = 0UL;

		// Token: 0x040038F2 RID: 14578
		private ulong viewTime_;
	}
}
