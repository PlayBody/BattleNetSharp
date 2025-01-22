using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000031 RID: 49
	public sealed class PartialFieldsUpdateCommand : IMessage<PartialFieldsUpdateCommand>, IMessage, IEquatable<PartialFieldsUpdateCommand>, IDeepCloneable<PartialFieldsUpdateCommand>, IBufferMessage
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		[DebuggerNonUserCode]
		public static MessageParser<PartialFieldsUpdateCommand> Parser
		{
			get
			{
				return PartialFieldsUpdateCommand._parser;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00011BEC File Offset: 0x0000FDEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00011C10 File Offset: 0x0000FE10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartialFieldsUpdateCommand.Descriptor;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011C27 File Offset: 0x0000FE27
		[DebuggerNonUserCode]
		public PartialFieldsUpdateCommand()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011C3C File Offset: 0x0000FE3C
		[DebuggerNonUserCode]
		public PartialFieldsUpdateCommand(PartialFieldsUpdateCommand other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platformFilter_ = other.platformFilter_;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.fields_ = other.fields_.Clone();
			this.firstUpdate_ = other.firstUpdate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		[DebuggerNonUserCode]
		public PartialFieldsUpdateCommand Clone()
		{
			return new PartialFieldsUpdateCommand(this);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00011CC8 File Offset: 0x0000FEC8
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00011CF9 File Offset: 0x0000FEF9
		[DebuggerNonUserCode]
		public uint PlatformFilter
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint platformFilterDefaultValue;
				if (flag)
				{
					platformFilterDefaultValue = this.platformFilter_;
				}
				else
				{
					platformFilterDefaultValue = PartialFieldsUpdateCommand.PlatformFilterDefaultValue;
				}
				return platformFilterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platformFilter_ = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00011D14 File Offset: 0x0000FF14
		[DebuggerNonUserCode]
		public bool HasPlatformFilter
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011D31 File Offset: 0x0000FF31
		[DebuggerNonUserCode]
		public void ClearPlatformFilter()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00011D44 File Offset: 0x0000FF44
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00011D75 File Offset: 0x0000FF75
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = PartialFieldsUpdateCommand.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00011D90 File Offset: 0x0000FF90
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00011DAD File Offset: 0x0000FFAD
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00011DF1 File Offset: 0x0000FFF1
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = PartialFieldsUpdateCommand.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00011E0C File Offset: 0x0001000C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011E29 File Offset: 0x00010029
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00011E3C File Offset: 0x0001003C
		[DebuggerNonUserCode]
		public RepeatedField<PartialFieldValue> Fields
		{
			get
			{
				return this.fields_;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00011E54 File Offset: 0x00010054
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00011E85 File Offset: 0x00010085
		[DebuggerNonUserCode]
		public bool FirstUpdate
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool firstUpdateDefaultValue;
				if (flag)
				{
					firstUpdateDefaultValue = this.firstUpdate_;
				}
				else
				{
					firstUpdateDefaultValue = PartialFieldsUpdateCommand.FirstUpdateDefaultValue;
				}
				return firstUpdateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.firstUpdate_ = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00011EA0 File Offset: 0x000100A0
		[DebuggerNonUserCode]
		public bool HasFirstUpdate
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011EBD File Offset: 0x000100BD
		[DebuggerNonUserCode]
		public void ClearFirstUpdate()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00011ED0 File Offset: 0x000100D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartialFieldsUpdateCommand);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00011EF0 File Offset: 0x000100F0
		[DebuggerNonUserCode]
		public bool Equals(PartialFieldsUpdateCommand other)
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
					bool flag4 = this.PlatformFilter != other.PlatformFilter;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoGroup != other.SnoGroup;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoHandle != other.SnoHandle;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.fields_.Equals(other.fields_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FirstUpdate != other.FirstUpdate;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00011FC0 File Offset: 0x000101C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlatformFilter = this.HasPlatformFilter;
			if (hasPlatformFilter)
			{
				num ^= this.PlatformFilter.GetHashCode();
			}
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
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				num ^= this.FirstUpdate.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00012078 File Offset: 0x00010278
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00012090 File Offset: 0x00010290
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001209C File Offset: 0x0001029C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlatformFilter = this.HasPlatformFilter;
			if (hasPlatformFilter)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PlatformFilter);
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoHandle);
			}
			this.fields_.WriteTo(ref output, PartialFieldsUpdateCommand._repeated_fields_codec);
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FirstUpdate);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00012164 File Offset: 0x00010364
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlatformFilter = this.HasPlatformFilter;
			if (hasPlatformFilter)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlatformFilter);
			}
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
			num += this.fields_.CalculateSize(PartialFieldsUpdateCommand._repeated_fields_codec);
			bool hasFirstUpdate = this.HasFirstUpdate;
			if (hasFirstUpdate)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00012214 File Offset: 0x00010414
		[DebuggerNonUserCode]
		public void MergeFrom(PartialFieldsUpdateCommand other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlatformFilter = other.HasPlatformFilter;
				if (hasPlatformFilter)
				{
					this.PlatformFilter = other.PlatformFilter;
				}
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
				bool hasFirstUpdate = other.HasFirstUpdate;
				if (hasFirstUpdate)
				{
					this.FirstUpdate = other.FirstUpdate;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000122BF File Offset: 0x000104BF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000122CC File Offset: 0x000104CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.SnoGroup = input.ReadInt32();
					}
					else
					{
						this.PlatformFilter = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.FirstUpdate = input.ReadBool();
					}
					else
					{
						this.fields_.AddEntriesFrom(ref input, PartialFieldsUpdateCommand._repeated_fields_codec);
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000157 RID: 343
		private static readonly MessageParser<PartialFieldsUpdateCommand> _parser = new MessageParser<PartialFieldsUpdateCommand>(() => new PartialFieldsUpdateCommand());

		// Token: 0x04000158 RID: 344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000159 RID: 345
		private int _hasBits0;

		// Token: 0x0400015A RID: 346
		public const int PlatformFilterFieldNumber = 1;

		// Token: 0x0400015B RID: 347
		private static readonly uint PlatformFilterDefaultValue = 0U;

		// Token: 0x0400015C RID: 348
		private uint platformFilter_;

		// Token: 0x0400015D RID: 349
		public const int SnoGroupFieldNumber = 2;

		// Token: 0x0400015E RID: 350
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x0400015F RID: 351
		private int snoGroup_;

		// Token: 0x04000160 RID: 352
		public const int SnoHandleFieldNumber = 3;

		// Token: 0x04000161 RID: 353
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000162 RID: 354
		private int snoHandle_;

		// Token: 0x04000163 RID: 355
		public const int FieldsFieldNumber = 4;

		// Token: 0x04000164 RID: 356
		private static readonly FieldCodec<PartialFieldValue> _repeated_fields_codec = FieldCodec.ForMessage<PartialFieldValue>(34U, PartialFieldValue.Parser);

		// Token: 0x04000165 RID: 357
		private readonly RepeatedField<PartialFieldValue> fields_ = new RepeatedField<PartialFieldValue>();

		// Token: 0x04000166 RID: 358
		public const int FirstUpdateFieldNumber = 5;

		// Token: 0x04000167 RID: 359
		private static readonly bool FirstUpdateDefaultValue = false;

		// Token: 0x04000168 RID: 360
		private bool firstUpdate_;
	}
}
