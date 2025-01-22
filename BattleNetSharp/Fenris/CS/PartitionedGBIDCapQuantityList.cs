using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000208 RID: 520
	public sealed class PartitionedGBIDCapQuantityList : IMessage<PartitionedGBIDCapQuantityList>, IMessage, IEquatable<PartitionedGBIDCapQuantityList>, IDeepCloneable<PartitionedGBIDCapQuantityList>, IBufferMessage
	{
		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x000E1784 File Offset: 0x000DF984
		[DebuggerNonUserCode]
		public static MessageParser<PartitionedGBIDCapQuantityList> Parser
		{
			get
			{
				return PartitionedGBIDCapQuantityList._parser;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x000E179C File Offset: 0x000DF99C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x000E17C0 File Offset: 0x000DF9C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartitionedGBIDCapQuantityList.Descriptor;
			}
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x000E17D7 File Offset: 0x000DF9D7
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantityList()
		{
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x000E17EC File Offset: 0x000DF9EC
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantityList(PartitionedGBIDCapQuantityList other)
			: this()
		{
			this.partitionedGbids_ = other.partitionedGbids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x000E1818 File Offset: 0x000DFA18
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantityList Clone()
		{
			return new PartitionedGBIDCapQuantityList(this);
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x000E1830 File Offset: 0x000DFA30
		[DebuggerNonUserCode]
		public RepeatedField<PartitionedGBIDCapQuantity> PartitionedGbids
		{
			get
			{
				return this.partitionedGbids_;
			}
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x000E1848 File Offset: 0x000DFA48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartitionedGBIDCapQuantityList);
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x000E1868 File Offset: 0x000DFA68
		[DebuggerNonUserCode]
		public bool Equals(PartitionedGBIDCapQuantityList other)
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
					bool flag4 = !this.partitionedGbids_.Equals(other.partitionedGbids_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x000E18C4 File Offset: 0x000DFAC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.partitionedGbids_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x000E1904 File Offset: 0x000DFB04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x000E191C File Offset: 0x000DFB1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x000E1928 File Offset: 0x000DFB28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partitionedGbids_.WriteTo(ref output, PartitionedGBIDCapQuantityList._repeated_partitionedGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x000E1964 File Offset: 0x000DFB64
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.partitionedGbids_.CalculateSize(PartitionedGBIDCapQuantityList._repeated_partitionedGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x000E19AC File Offset: 0x000DFBAC
		[DebuggerNonUserCode]
		public void MergeFrom(PartitionedGBIDCapQuantityList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.partitionedGbids_.Add(other.partitionedGbids_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x000E19EE File Offset: 0x000DFBEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x000E19FC File Offset: 0x000DFBFC
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
					this.partitionedGbids_.AddEntriesFrom(ref input, PartitionedGBIDCapQuantityList._repeated_partitionedGbids_codec);
				}
			}
		}

		// Token: 0x04001A99 RID: 6809
		private static readonly MessageParser<PartitionedGBIDCapQuantityList> _parser = new MessageParser<PartitionedGBIDCapQuantityList>(() => new PartitionedGBIDCapQuantityList());

		// Token: 0x04001A9A RID: 6810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A9B RID: 6811
		public const int PartitionedGbidsFieldNumber = 1;

		// Token: 0x04001A9C RID: 6812
		private static readonly FieldCodec<PartitionedGBIDCapQuantity> _repeated_partitionedGbids_codec = FieldCodec.ForMessage<PartitionedGBIDCapQuantity>(10U, PartitionedGBIDCapQuantity.Parser);

		// Token: 0x04001A9D RID: 6813
		private readonly RepeatedField<PartitionedGBIDCapQuantity> partitionedGbids_ = new RepeatedField<PartitionedGBIDCapQuantity>();
	}
}
