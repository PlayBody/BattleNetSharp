using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002F RID: 47
	public sealed class PartialFieldsXMLUpdateCommand : IMessage<PartialFieldsXMLUpdateCommand>, IMessage, IEquatable<PartialFieldsXMLUpdateCommand>, IDeepCloneable<PartialFieldsXMLUpdateCommand>, IBufferMessage
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		[DebuggerNonUserCode]
		public static MessageParser<PartialFieldsXMLUpdateCommand> Parser
		{
			get
			{
				return PartialFieldsXMLUpdateCommand._parser;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00010EDC File Offset: 0x0000F0DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartialFieldsXMLUpdateCommand.Descriptor;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00010EF3 File Offset: 0x0000F0F3
		[DebuggerNonUserCode]
		public PartialFieldsXMLUpdateCommand()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00010F14 File Offset: 0x0000F114
		[DebuggerNonUserCode]
		public PartialFieldsXMLUpdateCommand(PartialFieldsXMLUpdateCommand other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.fields_ = other.fields_.Clone();
			this.platformNeedingBinaryUpdates_ = other.platformNeedingBinaryUpdates_.Clone();
			this.firstUpdate_ = other.firstUpdate_;
			this.xmlCrc_ = other.xmlCrc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010F98 File Offset: 0x0000F198
		[DebuggerNonUserCode]
		public PartialFieldsXMLUpdateCommand Clone()
		{
			return new PartialFieldsXMLUpdateCommand(this);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00010FE1 File Offset: 0x0000F1E1
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = PartialFieldsXMLUpdateCommand.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00010FFC File Offset: 0x0000F1FC
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00011019 File Offset: 0x0000F219
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001102C File Offset: 0x0000F22C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0001105D File Offset: 0x0000F25D
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = PartialFieldsXMLUpdateCommand.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00011078 File Offset: 0x0000F278
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00011095 File Offset: 0x0000F295
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000110A8 File Offset: 0x0000F2A8
		[DebuggerNonUserCode]
		public RepeatedField<PartialFieldXMLValue> Fields
		{
			get
			{
				return this.fields_;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000110C0 File Offset: 0x0000F2C0
		[DebuggerNonUserCode]
		public RepeatedField<uint> PlatformNeedingBinaryUpdates
		{
			get
			{
				return this.platformNeedingBinaryUpdates_;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000110D8 File Offset: 0x0000F2D8
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00011109 File Offset: 0x0000F309
		[DebuggerNonUserCode]
		public bool FirstUpdate
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool firstUpdateDefaultValue;
				if (flag)
				{
					firstUpdateDefaultValue = this.firstUpdate_;
				}
				else
				{
					firstUpdateDefaultValue = PartialFieldsXMLUpdateCommand.FirstUpdateDefaultValue;
				}
				return firstUpdateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.firstUpdate_ = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00011124 File Offset: 0x0000F324
		[DebuggerNonUserCode]
		public bool HasFirstUpdate
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011141 File Offset: 0x0000F341
		[DebuggerNonUserCode]
		public void ClearFirstUpdate()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00011154 File Offset: 0x0000F354
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00011185 File Offset: 0x0000F385
		[DebuggerNonUserCode]
		public uint XmlCrc
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint xmlCrcDefaultValue;
				if (flag)
				{
					xmlCrcDefaultValue = this.xmlCrc_;
				}
				else
				{
					xmlCrcDefaultValue = PartialFieldsXMLUpdateCommand.XmlCrcDefaultValue;
				}
				return xmlCrcDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.xmlCrc_ = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000111A0 File Offset: 0x0000F3A0
		[DebuggerNonUserCode]
		public bool HasXmlCrc
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000111BD File Offset: 0x0000F3BD
		[DebuggerNonUserCode]
		public void ClearXmlCrc()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000111D0 File Offset: 0x0000F3D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartialFieldsXMLUpdateCommand);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[DebuggerNonUserCode]
		public bool Equals(PartialFieldsXMLUpdateCommand other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.fields_.Equals(other.fields_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.platformNeedingBinaryUpdates_.Equals(other.platformNeedingBinaryUpdates_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FirstUpdate != other.FirstUpdate;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.XmlCrc != other.XmlCrc;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			num ^= this.fields_.GetHashCode();
			num ^= this.platformNeedingBinaryUpdates_.GetHashCode();
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				num ^= this.FirstUpdate.GetHashCode();
			}
			bool hasXmlCrc = this.HasXmlCrc;
			if (hasXmlCrc)
			{
				num ^= this.XmlCrc.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000113A4 File Offset: 0x0000F5A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000113BC File Offset: 0x0000F5BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000113C8 File Offset: 0x0000F5C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			this.fields_.WriteTo(ref output, PartialFieldsXMLUpdateCommand._repeated_fields_codec);
			this.platformNeedingBinaryUpdates_.WriteTo(ref output, PartialFieldsXMLUpdateCommand._repeated_platformNeedingBinaryUpdates_codec);
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FirstUpdate);
			}
			bool hasXmlCrc = this.HasXmlCrc;
			if (hasXmlCrc)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.XmlCrc);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000114A0 File Offset: 0x0000F6A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			num += this.fields_.CalculateSize(PartialFieldsXMLUpdateCommand._repeated_fields_codec);
			num += this.platformNeedingBinaryUpdates_.CalculateSize(PartialFieldsXMLUpdateCommand._repeated_platformNeedingBinaryUpdates_codec);
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				num += 2;
			}
			bool hasXmlCrc = this.HasXmlCrc;
			if (hasXmlCrc)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.XmlCrc);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00011564 File Offset: 0x0000F764
		[DebuggerNonUserCode]
		public void MergeFrom(PartialFieldsXMLUpdateCommand other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this.fields_.Add(other.fields_);
				this.platformNeedingBinaryUpdates_.Add(other.platformNeedingBinaryUpdates_);
				bool hasFirstUpdate = other.HasFirstUpdate;
				if (hasFirstUpdate)
				{
					this.FirstUpdate = other.FirstUpdate;
				}
				bool hasXmlCrc = other.HasXmlCrc;
				if (hasXmlCrc)
				{
					this.XmlCrc = other.XmlCrc;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011621 File Offset: 0x0000F821
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001162C File Offset: 0x0000F82C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_0045;
							}
							this.fields_.AddEntriesFrom(ref input, PartialFieldsXMLUpdateCommand._repeated_fields_codec);
						}
						else
						{
							this.SnoHandle = input.ReadInt32();
						}
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else if (num3 <= 34U)
				{
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0045;
					}
					this.platformNeedingBinaryUpdates_.AddEntriesFrom(ref input, PartialFieldsXMLUpdateCommand._repeated_platformNeedingBinaryUpdates_codec);
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						goto IL_0045;
					}
					this.XmlCrc = input.ReadUInt32();
				}
				else
				{
					this.FirstUpdate = input.ReadBool();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly MessageParser<PartialFieldsXMLUpdateCommand> _parser = new MessageParser<PartialFieldsXMLUpdateCommand>(() => new PartialFieldsXMLUpdateCommand());

		// Token: 0x0400013B RID: 315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400013C RID: 316
		private int _hasBits0;

		// Token: 0x0400013D RID: 317
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x0400013E RID: 318
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x0400013F RID: 319
		private int snoGroup_;

		// Token: 0x04000140 RID: 320
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x04000141 RID: 321
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000142 RID: 322
		private int snoHandle_;

		// Token: 0x04000143 RID: 323
		public const int FieldsFieldNumber = 3;

		// Token: 0x04000144 RID: 324
		private static readonly FieldCodec<PartialFieldXMLValue> _repeated_fields_codec = FieldCodec.ForMessage<PartialFieldXMLValue>(26U, PartialFieldXMLValue.Parser);

		// Token: 0x04000145 RID: 325
		private readonly RepeatedField<PartialFieldXMLValue> fields_ = new RepeatedField<PartialFieldXMLValue>();

		// Token: 0x04000146 RID: 326
		public const int PlatformNeedingBinaryUpdatesFieldNumber = 4;

		// Token: 0x04000147 RID: 327
		private static readonly FieldCodec<uint> _repeated_platformNeedingBinaryUpdates_codec = FieldCodec.ForUInt32(32U);

		// Token: 0x04000148 RID: 328
		private readonly RepeatedField<uint> platformNeedingBinaryUpdates_ = new RepeatedField<uint>();

		// Token: 0x04000149 RID: 329
		public const int FirstUpdateFieldNumber = 5;

		// Token: 0x0400014A RID: 330
		private static readonly bool FirstUpdateDefaultValue = false;

		// Token: 0x0400014B RID: 331
		private bool firstUpdate_;

		// Token: 0x0400014C RID: 332
		public const int XmlCrcFieldNumber = 6;

		// Token: 0x0400014D RID: 333
		private static readonly uint XmlCrcDefaultValue = 0U;

		// Token: 0x0400014E RID: 334
		private uint xmlCrc_;
	}
}
