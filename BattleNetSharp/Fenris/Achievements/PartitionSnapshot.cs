using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C6 RID: 710
	public sealed class PartitionSnapshot : IMessage<PartitionSnapshot>, IMessage, IEquatable<PartitionSnapshot>, IDeepCloneable<PartitionSnapshot>, IBufferMessage
	{
		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x00120D20 File Offset: 0x0011EF20
		[DebuggerNonUserCode]
		public static MessageParser<PartitionSnapshot> Parser
		{
			get
			{
				return PartitionSnapshot._parser;
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x00120D38 File Offset: 0x0011EF38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00120D5C File Offset: 0x0011EF5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartitionSnapshot.Descriptor;
			}
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00120D73 File Offset: 0x0011EF73
		[DebuggerNonUserCode]
		public PartitionSnapshot()
		{
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00120D80 File Offset: 0x0011EF80
		[DebuggerNonUserCode]
		public PartitionSnapshot(PartitionSnapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partition_ = other.partition_;
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00120DDC File Offset: 0x0011EFDC
		[DebuggerNonUserCode]
		public PartitionSnapshot Clone()
		{
			return new PartitionSnapshot(this);
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06004B75 RID: 19317 RVA: 0x00120DF4 File Offset: 0x0011EFF4
		// (set) Token: 0x06004B76 RID: 19318 RVA: 0x00120E25 File Offset: 0x0011F025
		[DebuggerNonUserCode]
		public uint Partition
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint partitionDefaultValue;
				if (flag)
				{
					partitionDefaultValue = this.partition_;
				}
				else
				{
					partitionDefaultValue = PartitionSnapshot.PartitionDefaultValue;
				}
				return partitionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.partition_ = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06004B77 RID: 19319 RVA: 0x00120E40 File Offset: 0x0011F040
		[DebuggerNonUserCode]
		public bool HasPartition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x00120E5D File Offset: 0x0011F05D
		[DebuggerNonUserCode]
		public void ClearPartition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x00120E70 File Offset: 0x0011F070
		// (set) Token: 0x06004B7A RID: 19322 RVA: 0x00120E88 File Offset: 0x0011F088
		[DebuggerNonUserCode]
		public Snapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x00120E94 File Offset: 0x0011F094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartitionSnapshot);
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00120EB4 File Offset: 0x0011F0B4
		[DebuggerNonUserCode]
		public bool Equals(PartitionSnapshot other)
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
					bool flag4 = this.Partition != other.Partition;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Snapshot, other.Snapshot);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00120F28 File Offset: 0x0011F128
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartition = this.HasPartition;
			if (hasPartition)
			{
				num ^= this.Partition.GetHashCode();
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00120F94 File Offset: 0x0011F194
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x00120FAC File Offset: 0x0011F1AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x00120FB8 File Offset: 0x0011F1B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartition = this.HasPartition;
			if (hasPartition)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Partition);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x00121028 File Offset: 0x0011F228
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartition = this.HasPartition;
			if (hasPartition)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Partition);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x00121098 File Offset: 0x0011F298
		[DebuggerNonUserCode]
		public void MergeFrom(PartitionSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartition = other.HasPartition;
				if (hasPartition)
				{
					this.Partition = other.Partition;
				}
				bool flag2 = other.snapshot_ != null;
				if (flag2)
				{
					bool flag3 = this.snapshot_ == null;
					if (flag3)
					{
						this.Snapshot = new Snapshot();
					}
					this.Snapshot.MergeFrom(other.Snapshot);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x0012111D File Offset: 0x0011F31D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x00121128 File Offset: 0x0011F328
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.snapshot_ == null;
						if (flag)
						{
							this.Snapshot = new Snapshot();
						}
						input.ReadMessage(this.Snapshot);
					}
				}
				else
				{
					this.Partition = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021B0 RID: 8624
		private static readonly MessageParser<PartitionSnapshot> _parser = new MessageParser<PartitionSnapshot>(() => new PartitionSnapshot());

		// Token: 0x040021B1 RID: 8625
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B2 RID: 8626
		private int _hasBits0;

		// Token: 0x040021B3 RID: 8627
		public const int PartitionFieldNumber = 1;

		// Token: 0x040021B4 RID: 8628
		private static readonly uint PartitionDefaultValue = 0U;

		// Token: 0x040021B5 RID: 8629
		private uint partition_;

		// Token: 0x040021B6 RID: 8630
		public const int SnapshotFieldNumber = 2;

		// Token: 0x040021B7 RID: 8631
		private Snapshot snapshot_;
	}
}
