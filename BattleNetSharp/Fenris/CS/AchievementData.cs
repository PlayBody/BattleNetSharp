using System;
using System.Diagnostics;
using Fenris.Achievements;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x0200020C RID: 524
	public sealed class AchievementData : IMessage<AchievementData>, IMessage, IEquatable<AchievementData>, IDeepCloneable<AchievementData>, IBufferMessage
	{
		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x000E2BD8 File Offset: 0x000E0DD8
		[DebuggerNonUserCode]
		public static MessageParser<AchievementData> Parser
		{
			get
			{
				return AchievementData._parser;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x000E2BF0 File Offset: 0x000E0DF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x000E2C14 File Offset: 0x000E0E14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementData.Descriptor;
			}
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x000E2C2B File Offset: 0x000E0E2B
		[DebuggerNonUserCode]
		public AchievementData()
		{
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x000E2C40 File Offset: 0x000E0E40
		[DebuggerNonUserCode]
		public AchievementData(AchievementData other)
			: this()
		{
			this.partitionSnapshots_ = other.partitionSnapshots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x000E2C6C File Offset: 0x000E0E6C
		[DebuggerNonUserCode]
		public AchievementData Clone()
		{
			return new AchievementData(this);
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x000E2C84 File Offset: 0x000E0E84
		[DebuggerNonUserCode]
		public RepeatedField<PartitionSnapshot> PartitionSnapshots
		{
			get
			{
				return this.partitionSnapshots_;
			}
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x000E2C9C File Offset: 0x000E0E9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementData);
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x000E2CBC File Offset: 0x000E0EBC
		[DebuggerNonUserCode]
		public bool Equals(AchievementData other)
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
					bool flag4 = !this.partitionSnapshots_.Equals(other.partitionSnapshots_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x000E2D18 File Offset: 0x000E0F18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.partitionSnapshots_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000E2D58 File Offset: 0x000E0F58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x000E2D70 File Offset: 0x000E0F70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x000E2D7C File Offset: 0x000E0F7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partitionSnapshots_.WriteTo(ref output, AchievementData._repeated_partitionSnapshots_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x000E2DB8 File Offset: 0x000E0FB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.partitionSnapshots_.CalculateSize(AchievementData._repeated_partitionSnapshots_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x000E2E00 File Offset: 0x000E1000
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.partitionSnapshots_.Add(other.partitionSnapshots_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x000E2E42 File Offset: 0x000E1042
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x000E2E50 File Offset: 0x000E1050
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
					this.partitionSnapshots_.AddEntriesFrom(ref input, AchievementData._repeated_partitionSnapshots_codec);
				}
			}
		}

		// Token: 0x04001ABF RID: 6847
		private static readonly MessageParser<AchievementData> _parser = new MessageParser<AchievementData>(() => new AchievementData());

		// Token: 0x04001AC0 RID: 6848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AC1 RID: 6849
		public const int PartitionSnapshotsFieldNumber = 1;

		// Token: 0x04001AC2 RID: 6850
		private static readonly FieldCodec<PartitionSnapshot> _repeated_partitionSnapshots_codec = FieldCodec.ForMessage<PartitionSnapshot>(10U, PartitionSnapshot.Parser);

		// Token: 0x04001AC3 RID: 6851
		private readonly RepeatedField<PartitionSnapshot> partitionSnapshots_ = new RepeatedField<PartitionSnapshot>();
	}
}
