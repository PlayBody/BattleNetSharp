using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000206 RID: 518
	public sealed class PartitionedGBIDList : IMessage<PartitionedGBIDList>, IMessage, IEquatable<PartitionedGBIDList>, IDeepCloneable<PartitionedGBIDList>, IBufferMessage
	{
		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
		[DebuggerNonUserCode]
		public static MessageParser<PartitionedGBIDList> Parser
		{
			get
			{
				return PartitionedGBIDList._parser;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x000E0EB8 File Offset: 0x000DF0B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x000E0EDC File Offset: 0x000DF0DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartitionedGBIDList.Descriptor;
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x000E0EF3 File Offset: 0x000DF0F3
		[DebuggerNonUserCode]
		public PartitionedGBIDList()
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x000E0F08 File Offset: 0x000DF108
		[DebuggerNonUserCode]
		public PartitionedGBIDList(PartitionedGBIDList other)
			: this()
		{
			this.partitionedGbids_ = other.partitionedGbids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x000E0F34 File Offset: 0x000DF134
		[DebuggerNonUserCode]
		public PartitionedGBIDList Clone()
		{
			return new PartitionedGBIDList(this);
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x000E0F4C File Offset: 0x000DF14C
		[DebuggerNonUserCode]
		public RepeatedField<PartitionedGBID> PartitionedGbids
		{
			get
			{
				return this.partitionedGbids_;
			}
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x000E0F64 File Offset: 0x000DF164
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartitionedGBIDList);
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x000E0F84 File Offset: 0x000DF184
		[DebuggerNonUserCode]
		public bool Equals(PartitionedGBIDList other)
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

		// Token: 0x060038D8 RID: 14552 RVA: 0x000E0FE0 File Offset: 0x000DF1E0
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

		// Token: 0x060038D9 RID: 14553 RVA: 0x000E1020 File Offset: 0x000DF220
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x000E1038 File Offset: 0x000DF238
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x000E1044 File Offset: 0x000DF244
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partitionedGbids_.WriteTo(ref output, PartitionedGBIDList._repeated_partitionedGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x000E1080 File Offset: 0x000DF280
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.partitionedGbids_.CalculateSize(PartitionedGBIDList._repeated_partitionedGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000E10C8 File Offset: 0x000DF2C8
		[DebuggerNonUserCode]
		public void MergeFrom(PartitionedGBIDList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.partitionedGbids_.Add(other.partitionedGbids_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x000E110A File Offset: 0x000DF30A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x000E1118 File Offset: 0x000DF318
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
					this.partitionedGbids_.AddEntriesFrom(ref input, PartitionedGBIDList._repeated_partitionedGbids_codec);
				}
			}
		}

		// Token: 0x04001A88 RID: 6792
		private static readonly MessageParser<PartitionedGBIDList> _parser = new MessageParser<PartitionedGBIDList>(() => new PartitionedGBIDList());

		// Token: 0x04001A89 RID: 6793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A8A RID: 6794
		public const int PartitionedGbidsFieldNumber = 1;

		// Token: 0x04001A8B RID: 6795
		private static readonly FieldCodec<PartitionedGBID> _repeated_partitionedGbids_codec = FieldCodec.ForMessage<PartitionedGBID>(10U, PartitionedGBID.Parser);

		// Token: 0x04001A8C RID: 6796
		private readonly RepeatedField<PartitionedGBID> partitionedGbids_ = new RepeatedField<PartitionedGBID>();
	}
}
