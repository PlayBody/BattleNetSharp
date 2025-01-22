using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BB RID: 1467
	public sealed class PresenceFieldKey : IMessage<PresenceFieldKey>, IMessage, IEquatable<PresenceFieldKey>, IDeepCloneable<PresenceFieldKey>, IBufferMessage
	{
		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x0021BEDC File Offset: 0x0021A0DC
		[DebuggerNonUserCode]
		public static MessageParser<PresenceFieldKey> Parser
		{
			get
			{
				return PresenceFieldKey._parser;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008AFF RID: 35583 RVA: 0x0021BEF4 File Offset: 0x0021A0F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x0021BF18 File Offset: 0x0021A118
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceFieldKey.Descriptor;
			}
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x0021BF2F File Offset: 0x0021A12F
		[DebuggerNonUserCode]
		public PresenceFieldKey()
		{
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x0021BF3C File Offset: 0x0021A13C
		[DebuggerNonUserCode]
		public PresenceFieldKey(PresenceFieldKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this.group_ = other.group_;
			this.field_ = other.field_;
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x0021BFA0 File Offset: 0x0021A1A0
		[DebuggerNonUserCode]
		public PresenceFieldKey Clone()
		{
			return new PresenceFieldKey(this);
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x0021BFB8 File Offset: 0x0021A1B8
		// (set) Token: 0x06008B05 RID: 35589 RVA: 0x0021BFE9 File Offset: 0x0021A1E9
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = PresenceFieldKey.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008B06 RID: 35590 RVA: 0x0021C004 File Offset: 0x0021A204
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x0021C021 File Offset: 0x0021A221
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x0021C034 File Offset: 0x0021A234
		// (set) Token: 0x06008B09 RID: 35593 RVA: 0x0021C065 File Offset: 0x0021A265
		[DebuggerNonUserCode]
		public uint Group
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint groupDefaultValue;
				if (flag)
				{
					groupDefaultValue = this.group_;
				}
				else
				{
					groupDefaultValue = PresenceFieldKey.GroupDefaultValue;
				}
				return groupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.group_ = value;
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06008B0A RID: 35594 RVA: 0x0021C080 File Offset: 0x0021A280
		[DebuggerNonUserCode]
		public bool HasGroup
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x0021C09D File Offset: 0x0021A29D
		[DebuggerNonUserCode]
		public void ClearGroup()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x0021C0B0 File Offset: 0x0021A2B0
		// (set) Token: 0x06008B0D RID: 35597 RVA: 0x0021C0E1 File Offset: 0x0021A2E1
		[DebuggerNonUserCode]
		public uint Field
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint fieldDefaultValue;
				if (flag)
				{
					fieldDefaultValue = this.field_;
				}
				else
				{
					fieldDefaultValue = PresenceFieldKey.FieldDefaultValue;
				}
				return fieldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.field_ = value;
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06008B0E RID: 35598 RVA: 0x0021C0FC File Offset: 0x0021A2FC
		[DebuggerNonUserCode]
		public bool HasField
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x0021C119 File Offset: 0x0021A319
		[DebuggerNonUserCode]
		public void ClearField()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x0021C12C File Offset: 0x0021A32C
		// (set) Token: 0x06008B11 RID: 35601 RVA: 0x0021C15D File Offset: 0x0021A35D
		[DebuggerNonUserCode]
		public ulong UniqueId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong uniqueIdDefaultValue;
				if (flag)
				{
					uniqueIdDefaultValue = this.uniqueId_;
				}
				else
				{
					uniqueIdDefaultValue = PresenceFieldKey.UniqueIdDefaultValue;
				}
				return uniqueIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06008B12 RID: 35602 RVA: 0x0021C178 File Offset: 0x0021A378
		[DebuggerNonUserCode]
		public bool HasUniqueId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0021C195 File Offset: 0x0021A395
		[DebuggerNonUserCode]
		public void ClearUniqueId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x0021C1A8 File Offset: 0x0021A3A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceFieldKey);
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x0021C1C8 File Offset: 0x0021A3C8
		[DebuggerNonUserCode]
		public bool Equals(PresenceFieldKey other)
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
					bool flag4 = this.TitleId != other.TitleId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Group != other.Group;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Field != other.Field;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.UniqueId != other.UniqueId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x0021C274 File Offset: 0x0021A474
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				num ^= this.Group.GetHashCode();
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				num ^= this.Field.GetHashCode();
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0021C31C File Offset: 0x0021A51C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x0021C334 File Offset: 0x0021A534
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x0021C340 File Offset: 0x0021A540
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Group);
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Field);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UniqueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x0021C3F4 File Offset: 0x0021A5F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Group);
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Field);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0021C49C File Offset: 0x0021A69C
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceFieldKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				bool hasGroup = other.HasGroup;
				if (hasGroup)
				{
					this.Group = other.Group;
				}
				bool hasField = other.HasField;
				if (hasField)
				{
					this.Field = other.Field;
				}
				bool hasUniqueId = other.HasUniqueId;
				if (hasUniqueId)
				{
					this.UniqueId = other.UniqueId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0021C532 File Offset: 0x0021A732
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x0021C540 File Offset: 0x0021A740
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
							goto IL_0028;
						}
						this.Group = input.ReadUInt32();
					}
					else
					{
						this.TitleId = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.UniqueId = input.ReadUInt64();
				}
				else
				{
					this.Field = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003EEE RID: 16110
		private static readonly MessageParser<PresenceFieldKey> _parser = new MessageParser<PresenceFieldKey>(() => new PresenceFieldKey());

		// Token: 0x04003EEF RID: 16111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF0 RID: 16112
		private int _hasBits0;

		// Token: 0x04003EF1 RID: 16113
		public const int TitleIdFieldNumber = 1;

		// Token: 0x04003EF2 RID: 16114
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x04003EF3 RID: 16115
		private uint titleId_;

		// Token: 0x04003EF4 RID: 16116
		public const int GroupFieldNumber = 2;

		// Token: 0x04003EF5 RID: 16117
		private static readonly uint GroupDefaultValue = 0U;

		// Token: 0x04003EF6 RID: 16118
		private uint group_;

		// Token: 0x04003EF7 RID: 16119
		public const int FieldFieldNumber = 3;

		// Token: 0x04003EF8 RID: 16120
		private static readonly uint FieldDefaultValue = 0U;

		// Token: 0x04003EF9 RID: 16121
		private uint field_;

		// Token: 0x04003EFA RID: 16122
		public const int UniqueIdFieldNumber = 4;

		// Token: 0x04003EFB RID: 16123
		private static readonly ulong UniqueIdDefaultValue = 0UL;

		// Token: 0x04003EFC RID: 16124
		private ulong uniqueId_;
	}
}
