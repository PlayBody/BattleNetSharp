using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000369 RID: 873
	public sealed class EntityIdRestriction : IMessage<EntityIdRestriction>, IMessage, IEquatable<EntityIdRestriction>, IDeepCloneable<EntityIdRestriction>, IBufferMessage
	{
		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x0015C484 File Offset: 0x0015A684
		[DebuggerNonUserCode]
		public static MessageParser<EntityIdRestriction> Parser
		{
			get
			{
				return EntityIdRestriction._parser;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x0015C49C File Offset: 0x0015A69C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x0015C4C0 File Offset: 0x0015A6C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIdRestriction.Descriptor;
			}
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x0015C4D7 File Offset: 0x0015A6D7
		[DebuggerNonUserCode]
		public EntityIdRestriction()
		{
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x0015C4E1 File Offset: 0x0015A6E1
		[DebuggerNonUserCode]
		public EntityIdRestriction(EntityIdRestriction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.needed_ = other.needed_;
			this.kind_ = other.kind_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0015C520 File Offset: 0x0015A720
		[DebuggerNonUserCode]
		public EntityIdRestriction Clone()
		{
			return new EntityIdRestriction(this);
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x0015C538 File Offset: 0x0015A738
		// (set) Token: 0x060059F8 RID: 23032 RVA: 0x0015C569 File Offset: 0x0015A769
		[DebuggerNonUserCode]
		public bool Needed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool neededDefaultValue;
				if (flag)
				{
					neededDefaultValue = this.needed_;
				}
				else
				{
					neededDefaultValue = EntityIdRestriction.NeededDefaultValue;
				}
				return neededDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.needed_ = value;
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x0015C584 File Offset: 0x0015A784
		[DebuggerNonUserCode]
		public bool HasNeeded
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x0015C5A1 File Offset: 0x0015A7A1
		[DebuggerNonUserCode]
		public void ClearNeeded()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x0015C5B4 File Offset: 0x0015A7B4
		// (set) Token: 0x060059FC RID: 23036 RVA: 0x0015C5E5 File Offset: 0x0015A7E5
		[DebuggerNonUserCode]
		public EntityIdRestriction.Types.Kind Kind
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				EntityIdRestriction.Types.Kind kindDefaultValue;
				if (flag)
				{
					kindDefaultValue = this.kind_;
				}
				else
				{
					kindDefaultValue = EntityIdRestriction.KindDefaultValue;
				}
				return kindDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.kind_ = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x0015C600 File Offset: 0x0015A800
		[DebuggerNonUserCode]
		public bool HasKind
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x0015C61D File Offset: 0x0015A81D
		[DebuggerNonUserCode]
		public void ClearKind()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0015C630 File Offset: 0x0015A830
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIdRestriction);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x0015C650 File Offset: 0x0015A850
		[DebuggerNonUserCode]
		public bool Equals(EntityIdRestriction other)
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
					bool flag4 = this.Needed != other.Needed;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Kind != other.Kind;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0015C6C4 File Offset: 0x0015A8C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				num ^= this.Needed.GetHashCode();
			}
			bool hasKind = this.HasKind;
			if (hasKind)
			{
				num ^= this.Kind.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x0015C738 File Offset: 0x0015A938
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x0015C750 File Offset: 0x0015A950
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x0015C75C File Offset: 0x0015A95C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Needed);
			}
			bool hasKind = this.HasKind;
			if (hasKind)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Kind);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x0015C7CC File Offset: 0x0015A9CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				num += 2;
			}
			bool hasKind = this.HasKind;
			if (hasKind)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Kind);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x0015C82C File Offset: 0x0015AA2C
		[DebuggerNonUserCode]
		public void MergeFrom(EntityIdRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNeeded = other.HasNeeded;
				if (hasNeeded)
				{
					this.Needed = other.Needed;
				}
				bool hasKind = other.HasKind;
				if (hasKind)
				{
					this.Kind = other.Kind;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0015C88E File Offset: 0x0015AA8E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x0015C89C File Offset: 0x0015AA9C
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
						this.Kind = (EntityIdRestriction.Types.Kind)input.ReadEnum();
					}
				}
				else
				{
					this.Needed = input.ReadBool();
				}
			}
		}

		// Token: 0x040028FA RID: 10490
		private static readonly MessageParser<EntityIdRestriction> _parser = new MessageParser<EntityIdRestriction>(() => new EntityIdRestriction());

		// Token: 0x040028FB RID: 10491
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028FC RID: 10492
		private int _hasBits0;

		// Token: 0x040028FD RID: 10493
		public const int NeededFieldNumber = 1;

		// Token: 0x040028FE RID: 10494
		private static readonly bool NeededDefaultValue = false;

		// Token: 0x040028FF RID: 10495
		private bool needed_;

		// Token: 0x04002900 RID: 10496
		public const int KindFieldNumber = 2;

		// Token: 0x04002901 RID: 10497
		private static readonly EntityIdRestriction.Types.Kind KindDefaultValue = EntityIdRestriction.Types.Kind.Any;

		// Token: 0x04002902 RID: 10498
		private EntityIdRestriction.Types.Kind kind_;

		// Token: 0x02000E48 RID: 3656
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001493 RID: 5267
			public enum Kind
			{
				// Token: 0x0400A4E4 RID: 42212
				[OriginalName("ANY")]
				Any,
				// Token: 0x0400A4E5 RID: 42213
				[OriginalName("ACCOUNT")]
				Account,
				// Token: 0x0400A4E6 RID: 42214
				[OriginalName("GAME_ACCOUNT")]
				GameAccount,
				// Token: 0x0400A4E7 RID: 42215
				[OriginalName("ACCOUNT_OR_GAME_ACCOUNT")]
				AccountOrGameAccount,
				// Token: 0x0400A4E8 RID: 42216
				[OriginalName("SERVICE")]
				Service,
				// Token: 0x0400A4E9 RID: 42217
				[OriginalName("CHANNEL")]
				Channel
			}
		}
	}
}
