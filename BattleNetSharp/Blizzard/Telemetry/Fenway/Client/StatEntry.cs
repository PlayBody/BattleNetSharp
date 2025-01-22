using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000331 RID: 817
	public sealed class StatEntry : IMessage<StatEntry>, IMessage, IEquatable<StatEntry>, IDeepCloneable<StatEntry>, IBufferMessage
	{
		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x001495A8 File Offset: 0x001477A8
		[DebuggerNonUserCode]
		public static MessageParser<StatEntry> Parser
		{
			get
			{
				return StatEntry._parser;
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x0600553A RID: 21818 RVA: 0x001495C0 File Offset: 0x001477C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonStatEntryReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x001495E4 File Offset: 0x001477E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StatEntry.Descriptor;
			}
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x001495FB File Offset: 0x001477FB
		[DebuggerNonUserCode]
		public StatEntry()
		{
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00149608 File Offset: 0x00147808
		[DebuggerNonUserCode]
		public StatEntry(StatEntry other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00149660 File Offset: 0x00147860
		[DebuggerNonUserCode]
		public StatEntry Clone()
		{
			return new StatEntry(this);
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x0600553F RID: 21823 RVA: 0x00149678 File Offset: 0x00147878
		// (set) Token: 0x06005540 RID: 21824 RVA: 0x001496A9 File Offset: 0x001478A9
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = StatEntry.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06005541 RID: 21825 RVA: 0x001496C4 File Offset: 0x001478C4
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x001496E1 File Offset: 0x001478E1
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x001496F4 File Offset: 0x001478F4
		// (set) Token: 0x06005544 RID: 21828 RVA: 0x00149715 File Offset: 0x00147915
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? StatEntry.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x0014972C File Offset: 0x0014792C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00149747 File Offset: 0x00147947
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x00149754 File Offset: 0x00147954
		// (set) Token: 0x06005548 RID: 21832 RVA: 0x00149785 File Offset: 0x00147985
		[DebuggerNonUserCode]
		public long Value
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = StatEntry.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.value_ = value;
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x001497A0 File Offset: 0x001479A0
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x001497BD File Offset: 0x001479BD
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x001497D0 File Offset: 0x001479D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StatEntry);
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x001497F0 File Offset: 0x001479F0
		[DebuggerNonUserCode]
		public bool Equals(StatEntry other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Value != other.Value;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x0014987C File Offset: 0x00147A7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
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

		// Token: 0x0600554E RID: 21838 RVA: 0x00149904 File Offset: 0x00147B04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x0014991C File Offset: 0x00147B1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00149928 File Offset: 0x00147B28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x001499B8 File Offset: 0x00147BB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00149A44 File Offset: 0x00147C44
		[DebuggerNonUserCode]
		public void MergeFrom(StatEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00149ABF File Offset: 0x00147CBF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00149ACC File Offset: 0x00147CCC
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Value = input.ReadInt64();
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026BC RID: 9916
		private static readonly MessageParser<StatEntry> _parser = new MessageParser<StatEntry>(() => new StatEntry());

		// Token: 0x040026BD RID: 9917
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026BE RID: 9918
		private int _hasBits0;

		// Token: 0x040026BF RID: 9919
		public const int IdFieldNumber = 1;

		// Token: 0x040026C0 RID: 9920
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x040026C1 RID: 9921
		private uint id_;

		// Token: 0x040026C2 RID: 9922
		public const int NameFieldNumber = 2;

		// Token: 0x040026C3 RID: 9923
		private static readonly string NameDefaultValue = "";

		// Token: 0x040026C4 RID: 9924
		private string name_;

		// Token: 0x040026C5 RID: 9925
		public const int ValueFieldNumber = 3;

		// Token: 0x040026C6 RID: 9926
		private static readonly long ValueDefaultValue = 0L;

		// Token: 0x040026C7 RID: 9927
		private long value_;
	}
}
