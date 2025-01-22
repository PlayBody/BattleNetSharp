using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x02000127 RID: 295
	public sealed class SavedReputation : IMessage<SavedReputation>, IMessage, IEquatable<SavedReputation>, IDeepCloneable<SavedReputation>, IBufferMessage
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00070404 File Offset: 0x0006E604
		[DebuggerNonUserCode]
		public static MessageParser<SavedReputation> Parser
		{
			get
			{
				return SavedReputation._parser;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0007041C File Offset: 0x0006E61C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00070440 File Offset: 0x0006E640
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedReputation.Descriptor;
			}
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00070457 File Offset: 0x0006E657
		[DebuggerNonUserCode]
		public SavedReputation()
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0007046C File Offset: 0x0006E66C
		[DebuggerNonUserCode]
		public SavedReputation(SavedReputation other)
			: this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00070498 File Offset: 0x0006E698
		[DebuggerNonUserCode]
		public SavedReputation Clone()
		{
			return new SavedReputation(this);
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x000704B0 File Offset: 0x0006E6B0
		[DebuggerNonUserCode]
		public RepeatedField<SavedReputation.Types.SavedReputationValue> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000704C8 File Offset: 0x0006E6C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedReputation);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000704E8 File Offset: 0x0006E6E8
		[DebuggerNonUserCode]
		public bool Equals(SavedReputation other)
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
					bool flag4 = !this.values_.Equals(other.values_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00070544 File Offset: 0x0006E744
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.values_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00070584 File Offset: 0x0006E784
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0007059C File Offset: 0x0006E79C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000705A8 File Offset: 0x0006E7A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, SavedReputation._repeated_values_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000705E4 File Offset: 0x0006E7E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(SavedReputation._repeated_values_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0007062C File Offset: 0x0006E82C
		[DebuggerNonUserCode]
		public void MergeFrom(SavedReputation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.values_.Add(other.values_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0007066E File Offset: 0x0006E86E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0007067C File Offset: 0x0006E87C
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
					this.values_.AddEntriesFrom(ref input, SavedReputation._repeated_values_codec);
				}
			}
		}

		// Token: 0x04000C75 RID: 3189
		private static readonly MessageParser<SavedReputation> _parser = new MessageParser<SavedReputation>(() => new SavedReputation());

		// Token: 0x04000C76 RID: 3190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C77 RID: 3191
		public const int ValuesFieldNumber = 1;

		// Token: 0x04000C78 RID: 3192
		private static readonly FieldCodec<SavedReputation.Types.SavedReputationValue> _repeated_values_codec = FieldCodec.ForMessage<SavedReputation.Types.SavedReputationValue>(10U, SavedReputation.Types.SavedReputationValue.Parser);

		// Token: 0x04000C79 RID: 3193
		private readonly RepeatedField<SavedReputation.Types.SavedReputationValue> values_ = new RepeatedField<SavedReputation.Types.SavedReputationValue>();

		// Token: 0x02000C42 RID: 3138
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001475 RID: 5237
			public sealed class SavedReputationValue : IMessage<SavedReputation.Types.SavedReputationValue>, IMessage, IEquatable<SavedReputation.Types.SavedReputationValue>, IDeepCloneable<SavedReputation.Types.SavedReputationValue>, IBufferMessage
			{
				// Token: 0x17003A71 RID: 14961
				// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x004D54E4 File Offset: 0x004D36E4
				[DebuggerNonUserCode]
				public static MessageParser<SavedReputation.Types.SavedReputationValue> Parser
				{
					get
					{
						return SavedReputation.Types.SavedReputationValue._parser;
					}
				}

				// Token: 0x17003A72 RID: 14962
				// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x004D54FC File Offset: 0x004D36FC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return SavedReputation.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A73 RID: 14963
				// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x004D5520 File Offset: 0x004D3720
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return SavedReputation.Types.SavedReputationValue.Descriptor;
					}
				}

				// Token: 0x0600E5A3 RID: 58787 RVA: 0x004D5537 File Offset: 0x004D3737
				[DebuggerNonUserCode]
				public SavedReputationValue()
				{
				}

				// Token: 0x0600E5A4 RID: 58788 RVA: 0x004D5541 File Offset: 0x004D3741
				[DebuggerNonUserCode]
				public SavedReputationValue(SavedReputation.Types.SavedReputationValue other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.snoReputation_ = other.snoReputation_;
					this.value_ = other.value_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E5A5 RID: 58789 RVA: 0x004D5580 File Offset: 0x004D3780
				[DebuggerNonUserCode]
				public SavedReputation.Types.SavedReputationValue Clone()
				{
					return new SavedReputation.Types.SavedReputationValue(this);
				}

				// Token: 0x17003A74 RID: 14964
				// (get) Token: 0x0600E5A6 RID: 58790 RVA: 0x004D5598 File Offset: 0x004D3798
				// (set) Token: 0x0600E5A7 RID: 58791 RVA: 0x004D55C9 File Offset: 0x004D37C9
				[DebuggerNonUserCode]
				public int SnoReputation
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int snoReputationDefaultValue;
						if (flag)
						{
							snoReputationDefaultValue = this.snoReputation_;
						}
						else
						{
							snoReputationDefaultValue = SavedReputation.Types.SavedReputationValue.SnoReputationDefaultValue;
						}
						return snoReputationDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.snoReputation_ = value;
					}
				}

				// Token: 0x17003A75 RID: 14965
				// (get) Token: 0x0600E5A8 RID: 58792 RVA: 0x004D55E4 File Offset: 0x004D37E4
				[DebuggerNonUserCode]
				public bool HasSnoReputation
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E5A9 RID: 58793 RVA: 0x004D5601 File Offset: 0x004D3801
				[DebuggerNonUserCode]
				public void ClearSnoReputation()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A76 RID: 14966
				// (get) Token: 0x0600E5AA RID: 58794 RVA: 0x004D5614 File Offset: 0x004D3814
				// (set) Token: 0x0600E5AB RID: 58795 RVA: 0x004D5645 File Offset: 0x004D3845
				[DebuggerNonUserCode]
				public uint Value
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint valueDefaultValue;
						if (flag)
						{
							valueDefaultValue = this.value_;
						}
						else
						{
							valueDefaultValue = SavedReputation.Types.SavedReputationValue.ValueDefaultValue;
						}
						return valueDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.value_ = value;
					}
				}

				// Token: 0x17003A77 RID: 14967
				// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x004D5660 File Offset: 0x004D3860
				[DebuggerNonUserCode]
				public bool HasValue
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E5AD RID: 58797 RVA: 0x004D567D File Offset: 0x004D387D
				[DebuggerNonUserCode]
				public void ClearValue()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x0600E5AE RID: 58798 RVA: 0x004D5690 File Offset: 0x004D3890
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as SavedReputation.Types.SavedReputationValue);
				}

				// Token: 0x0600E5AF RID: 58799 RVA: 0x004D56B0 File Offset: 0x004D38B0
				[DebuggerNonUserCode]
				public bool Equals(SavedReputation.Types.SavedReputationValue other)
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
							bool flag4 = this.SnoReputation != other.SnoReputation;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Value != other.Value;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E5B0 RID: 58800 RVA: 0x004D5724 File Offset: 0x004D3924
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasSnoReputation = this.HasSnoReputation;
					if (hasSnoReputation)
					{
						num ^= this.SnoReputation.GetHashCode();
					}
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						num ^= this.Value.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E5B1 RID: 58801 RVA: 0x004D5794 File Offset: 0x004D3994
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E5B2 RID: 58802 RVA: 0x004D57AC File Offset: 0x004D39AC
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E5B3 RID: 58803 RVA: 0x004D57B8 File Offset: 0x004D39B8
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasSnoReputation = this.HasSnoReputation;
					if (hasSnoReputation)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.SnoReputation);
					}
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.Value);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E5B4 RID: 58804 RVA: 0x004D5828 File Offset: 0x004D3A28
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasSnoReputation = this.HasSnoReputation;
					if (hasSnoReputation)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoReputation);
					}
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E5B5 RID: 58805 RVA: 0x004D5894 File Offset: 0x004D3A94
				[DebuggerNonUserCode]
				public void MergeFrom(SavedReputation.Types.SavedReputationValue other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasSnoReputation = other.HasSnoReputation;
						if (hasSnoReputation)
						{
							this.SnoReputation = other.SnoReputation;
						}
						bool hasValue = other.HasValue;
						if (hasValue)
						{
							this.Value = other.Value;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E5B6 RID: 58806 RVA: 0x004D58F6 File Offset: 0x004D3AF6
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E5B7 RID: 58807 RVA: 0x004D5904 File Offset: 0x004D3B04
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
								this.Value = input.ReadUInt32();
							}
						}
						else
						{
							this.SnoReputation = input.ReadInt32();
						}
					}
				}

				// Token: 0x0400A38D RID: 41869
				private static readonly MessageParser<SavedReputation.Types.SavedReputationValue> _parser = new MessageParser<SavedReputation.Types.SavedReputationValue>(() => new SavedReputation.Types.SavedReputationValue());

				// Token: 0x0400A38E RID: 41870
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A38F RID: 41871
				private int _hasBits0;

				// Token: 0x0400A390 RID: 41872
				public const int SnoReputationFieldNumber = 1;

				// Token: 0x0400A391 RID: 41873
				private static readonly int SnoReputationDefaultValue = 0;

				// Token: 0x0400A392 RID: 41874
				private int snoReputation_;

				// Token: 0x0400A393 RID: 41875
				public const int ValueFieldNumber = 2;

				// Token: 0x0400A394 RID: 41876
				private static readonly uint ValueDefaultValue = 0U;

				// Token: 0x0400A395 RID: 41877
				private uint value_;
			}
		}
	}
}
