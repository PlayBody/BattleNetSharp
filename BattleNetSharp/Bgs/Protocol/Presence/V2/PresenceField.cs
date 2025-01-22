using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BC RID: 1468
	public sealed class PresenceField : IMessage<PresenceField>, IMessage, IEquatable<PresenceField>, IDeepCloneable<PresenceField>, IBufferMessage
	{
		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06008B1F RID: 35615 RVA: 0x0021C614 File Offset: 0x0021A814
		[DebuggerNonUserCode]
		public static MessageParser<PresenceField> Parser
		{
			get
			{
				return PresenceField._parser;
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06008B20 RID: 35616 RVA: 0x0021C62C File Offset: 0x0021A82C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x0021C650 File Offset: 0x0021A850
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceField.Descriptor;
			}
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x0021C667 File Offset: 0x0021A867
		[DebuggerNonUserCode]
		public PresenceField()
		{
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x0021C674 File Offset: 0x0021A874
		[DebuggerNonUserCode]
		public PresenceField(PresenceField other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = ((other.key_ != null) ? other.key_.Clone() : null);
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this.deleted_ = other.deleted_;
			this.updatedTimeUs_ = other.updatedTimeUs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x0021C6F8 File Offset: 0x0021A8F8
		[DebuggerNonUserCode]
		public PresenceField Clone()
		{
			return new PresenceField(this);
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x0021C710 File Offset: 0x0021A910
		// (set) Token: 0x06008B26 RID: 35622 RVA: 0x0021C728 File Offset: 0x0021A928
		[DebuggerNonUserCode]
		public PresenceFieldKey Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x06008B27 RID: 35623 RVA: 0x0021C734 File Offset: 0x0021A934
		// (set) Token: 0x06008B28 RID: 35624 RVA: 0x0021C74C File Offset: 0x0021A94C
		[DebuggerNonUserCode]
		public Variant Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x06008B29 RID: 35625 RVA: 0x0021C758 File Offset: 0x0021A958
		// (set) Token: 0x06008B2A RID: 35626 RVA: 0x0021C789 File Offset: 0x0021A989
		[DebuggerNonUserCode]
		public bool Deleted
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool deletedDefaultValue;
				if (flag)
				{
					deletedDefaultValue = this.deleted_;
				}
				else
				{
					deletedDefaultValue = PresenceField.DeletedDefaultValue;
				}
				return deletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.deleted_ = value;
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06008B2B RID: 35627 RVA: 0x0021C7A4 File Offset: 0x0021A9A4
		[DebuggerNonUserCode]
		public bool HasDeleted
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0021C7C1 File Offset: 0x0021A9C1
		[DebuggerNonUserCode]
		public void ClearDeleted()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06008B2D RID: 35629 RVA: 0x0021C7D4 File Offset: 0x0021A9D4
		// (set) Token: 0x06008B2E RID: 35630 RVA: 0x0021C805 File Offset: 0x0021AA05
		[DebuggerNonUserCode]
		public ulong UpdatedTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong updatedTimeUsDefaultValue;
				if (flag)
				{
					updatedTimeUsDefaultValue = this.updatedTimeUs_;
				}
				else
				{
					updatedTimeUsDefaultValue = PresenceField.UpdatedTimeUsDefaultValue;
				}
				return updatedTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.updatedTimeUs_ = value;
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x0021C820 File Offset: 0x0021AA20
		[DebuggerNonUserCode]
		public bool HasUpdatedTimeUs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x0021C83D File Offset: 0x0021AA3D
		[DebuggerNonUserCode]
		public void ClearUpdatedTimeUs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x0021C850 File Offset: 0x0021AA50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceField);
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x0021C870 File Offset: 0x0021AA70
		[DebuggerNonUserCode]
		public bool Equals(PresenceField other)
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
					bool flag4 = !object.Equals(this.Key, other.Key);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Value, other.Value);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Deleted != other.Deleted;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.UpdatedTimeUs != other.UpdatedTimeUs;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x0021C924 File Offset: 0x0021AB24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.key_ != null;
			if (flag)
			{
				num ^= this.Key.GetHashCode();
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				num ^= this.Value.GetHashCode();
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
			{
				num ^= this.Deleted.GetHashCode();
			}
			bool hasUpdatedTimeUs = this.HasUpdatedTimeUs;
			if (hasUpdatedTimeUs)
			{
				num ^= this.UpdatedTimeUs.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x0021C9CC File Offset: 0x0021ABCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x0021C9E4 File Offset: 0x0021ABE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x0021C9F0 File Offset: 0x0021ABF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.key_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Key);
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Value);
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Deleted);
			}
			bool hasUpdatedTimeUs = this.HasUpdatedTimeUs;
			if (hasUpdatedTimeUs)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UpdatedTimeUs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x0021CAAC File Offset: 0x0021ACAC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.key_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Key);
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
			{
				num += 2;
			}
			bool hasUpdatedTimeUs = this.HasUpdatedTimeUs;
			if (hasUpdatedTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UpdatedTimeUs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0021CB50 File Offset: 0x0021AD50
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceField other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.key_ != null;
				if (flag2)
				{
					bool flag3 = this.key_ == null;
					if (flag3)
					{
						this.Key = new PresenceFieldKey();
					}
					this.Key.MergeFrom(other.Key);
				}
				bool flag4 = other.value_ != null;
				if (flag4)
				{
					bool flag5 = this.value_ == null;
					if (flag5)
					{
						this.Value = new Variant();
					}
					this.Value.MergeFrom(other.Value);
				}
				bool hasDeleted = other.HasDeleted;
				if (hasDeleted)
				{
					this.Deleted = other.Deleted;
				}
				bool hasUpdatedTimeUs = other.HasUpdatedTimeUs;
				if (hasUpdatedTimeUs)
				{
					this.UpdatedTimeUs = other.UpdatedTimeUs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x0021CC33 File Offset: 0x0021AE33
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x0021CC40 File Offset: 0x0021AE40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002C;
						}
						bool flag = this.value_ == null;
						if (flag)
						{
							this.Value = new Variant();
						}
						input.ReadMessage(this.Value);
					}
					else
					{
						bool flag2 = this.key_ == null;
						if (flag2)
						{
							this.Key = new PresenceFieldKey();
						}
						input.ReadMessage(this.Key);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.UpdatedTimeUs = input.ReadUInt64();
				}
				else
				{
					this.Deleted = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003EFD RID: 16125
		private static readonly MessageParser<PresenceField> _parser = new MessageParser<PresenceField>(() => new PresenceField());

		// Token: 0x04003EFE RID: 16126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EFF RID: 16127
		private int _hasBits0;

		// Token: 0x04003F00 RID: 16128
		public const int KeyFieldNumber = 1;

		// Token: 0x04003F01 RID: 16129
		private PresenceFieldKey key_;

		// Token: 0x04003F02 RID: 16130
		public const int ValueFieldNumber = 2;

		// Token: 0x04003F03 RID: 16131
		private Variant value_;

		// Token: 0x04003F04 RID: 16132
		public const int DeletedFieldNumber = 3;

		// Token: 0x04003F05 RID: 16133
		private static readonly bool DeletedDefaultValue = false;

		// Token: 0x04003F06 RID: 16134
		private bool deleted_;

		// Token: 0x04003F07 RID: 16135
		public const int UpdatedTimeUsFieldNumber = 4;

		// Token: 0x04003F08 RID: 16136
		private static readonly ulong UpdatedTimeUsDefaultValue = 0UL;

		// Token: 0x04003F09 RID: 16137
		private ulong updatedTimeUs_;
	}
}
