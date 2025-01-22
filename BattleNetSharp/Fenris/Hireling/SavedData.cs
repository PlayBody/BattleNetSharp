using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hireling
{
	// Token: 0x02000177 RID: 375
	public sealed class SavedData : IMessage<SavedData>, IMessage, IEquatable<SavedData>, IDeepCloneable<SavedData>, IBufferMessage
	{
		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x00097204 File Offset: 0x00095404
		[DebuggerNonUserCode]
		public static MessageParser<SavedData> Parser
		{
			get
			{
				return SavedData._parser;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x0009721C File Offset: 0x0009541C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HirelingReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00097240 File Offset: 0x00095440
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedData.Descriptor;
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00097257 File Offset: 0x00095457
		[DebuggerNonUserCode]
		public SavedData()
		{
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0009726C File Offset: 0x0009546C
		[DebuggerNonUserCode]
		public SavedData(SavedData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hirelings_ = other.hirelings_.Clone();
			this.activeHireling_ = other.activeHireling_;
			this.availableHirelingsBitfield_ = other.availableHirelingsBitfield_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000972C8 File Offset: 0x000954C8
		[DebuggerNonUserCode]
		public SavedData Clone()
		{
			return new SavedData(this);
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000972E0 File Offset: 0x000954E0
		[DebuggerNonUserCode]
		public RepeatedField<Info> Hirelings
		{
			get
			{
				return this.hirelings_;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000972F8 File Offset: 0x000954F8
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x00097329 File Offset: 0x00095529
		[DebuggerNonUserCode]
		public int ActiveHireling
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int activeHirelingDefaultValue;
				if (flag)
				{
					activeHirelingDefaultValue = this.activeHireling_;
				}
				else
				{
					activeHirelingDefaultValue = SavedData.ActiveHirelingDefaultValue;
				}
				return activeHirelingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.activeHireling_ = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00097344 File Offset: 0x00095544
		[DebuggerNonUserCode]
		public bool HasActiveHireling
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00097361 File Offset: 0x00095561
		[DebuggerNonUserCode]
		public void ClearActiveHireling()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x00097374 File Offset: 0x00095574
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x000973A5 File Offset: 0x000955A5
		[DebuggerNonUserCode]
		public uint AvailableHirelingsBitfield
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint availableHirelingsBitfieldDefaultValue;
				if (flag)
				{
					availableHirelingsBitfieldDefaultValue = this.availableHirelingsBitfield_;
				}
				else
				{
					availableHirelingsBitfieldDefaultValue = SavedData.AvailableHirelingsBitfieldDefaultValue;
				}
				return availableHirelingsBitfieldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.availableHirelingsBitfield_ = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000973C0 File Offset: 0x000955C0
		[DebuggerNonUserCode]
		public bool HasAvailableHirelingsBitfield
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000973DD File Offset: 0x000955DD
		[DebuggerNonUserCode]
		public void ClearAvailableHirelingsBitfield()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000973F0 File Offset: 0x000955F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedData);
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00097410 File Offset: 0x00095610
		[DebuggerNonUserCode]
		public bool Equals(SavedData other)
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
					bool flag4 = !this.hirelings_.Equals(other.hirelings_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ActiveHireling != other.ActiveHireling;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AvailableHirelingsBitfield != other.AvailableHirelingsBitfield;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000974A0 File Offset: 0x000956A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hirelings_.GetHashCode();
			bool hasActiveHireling = this.HasActiveHireling;
			if (hasActiveHireling)
			{
				num ^= this.ActiveHireling.GetHashCode();
			}
			bool hasAvailableHirelingsBitfield = this.HasAvailableHirelingsBitfield;
			if (hasAvailableHirelingsBitfield)
			{
				num ^= this.AvailableHirelingsBitfield.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0009751C File Offset: 0x0009571C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00097534 File Offset: 0x00095734
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00097540 File Offset: 0x00095740
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hirelings_.WriteTo(ref output, SavedData._repeated_hirelings_codec);
			bool hasActiveHireling = this.HasActiveHireling;
			if (hasActiveHireling)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.ActiveHireling);
			}
			bool hasAvailableHirelingsBitfield = this.HasAvailableHirelingsBitfield;
			if (hasAvailableHirelingsBitfield)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AvailableHirelingsBitfield);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000975C0 File Offset: 0x000957C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hirelings_.CalculateSize(SavedData._repeated_hirelings_codec);
			bool hasActiveHireling = this.HasActiveHireling;
			if (hasActiveHireling)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ActiveHireling);
			}
			bool hasAvailableHirelingsBitfield = this.HasAvailableHirelingsBitfield;
			if (hasAvailableHirelingsBitfield)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvailableHirelingsBitfield);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00097640 File Offset: 0x00095840
		[DebuggerNonUserCode]
		public void MergeFrom(SavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.hirelings_.Add(other.hirelings_);
				bool hasActiveHireling = other.HasActiveHireling;
				if (hasActiveHireling)
				{
					this.ActiveHireling = other.ActiveHireling;
				}
				bool hasAvailableHirelingsBitfield = other.HasAvailableHirelingsBitfield;
				if (hasAvailableHirelingsBitfield)
				{
					this.AvailableHirelingsBitfield = other.AvailableHirelingsBitfield;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000976B4 File Offset: 0x000958B4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000976C0 File Offset: 0x000958C0
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AvailableHirelingsBitfield = input.ReadUInt32();
						}
					}
					else
					{
						this.ActiveHireling = input.ReadSInt32();
					}
				}
				else
				{
					this.hirelings_.AddEntriesFrom(ref input, SavedData._repeated_hirelings_codec);
				}
			}
		}

		// Token: 0x04001138 RID: 4408
		private static readonly MessageParser<SavedData> _parser = new MessageParser<SavedData>(() => new SavedData());

		// Token: 0x04001139 RID: 4409
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400113A RID: 4410
		private int _hasBits0;

		// Token: 0x0400113B RID: 4411
		public const int HirelingsFieldNumber = 1;

		// Token: 0x0400113C RID: 4412
		private static readonly FieldCodec<Info> _repeated_hirelings_codec = FieldCodec.ForMessage<Info>(10U, Info.Parser);

		// Token: 0x0400113D RID: 4413
		private readonly RepeatedField<Info> hirelings_ = new RepeatedField<Info>();

		// Token: 0x0400113E RID: 4414
		public const int ActiveHirelingFieldNumber = 2;

		// Token: 0x0400113F RID: 4415
		private static readonly int ActiveHirelingDefaultValue = -1;

		// Token: 0x04001140 RID: 4416
		private int activeHireling_;

		// Token: 0x04001141 RID: 4417
		public const int AvailableHirelingsBitfieldFieldNumber = 3;

		// Token: 0x04001142 RID: 4418
		private static readonly uint AvailableHirelingsBitfieldDefaultValue = 0U;

		// Token: 0x04001143 RID: 4419
		private uint availableHirelingsBitfield_;
	}
}
