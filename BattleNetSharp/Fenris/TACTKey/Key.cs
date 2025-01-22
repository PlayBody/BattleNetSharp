using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.TACTKey
{
	// Token: 0x0200010E RID: 270
	public sealed class Key : IMessage<Key>, IMessage, IEquatable<Key>, IDeepCloneable<Key>, IBufferMessage
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0005BAE0 File Offset: 0x00059CE0
		[DebuggerNonUserCode]
		public static MessageParser<Key> Parser
		{
			get
			{
				return Key._parser;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0005BAF8 File Offset: 0x00059CF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TACTKeyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0005BB1C File Offset: 0x00059D1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Key.Descriptor;
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0005BB33 File Offset: 0x00059D33
		[DebuggerNonUserCode]
		public Key()
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0005BB40 File Offset: 0x00059D40
		[DebuggerNonUserCode]
		public Key(Key other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.value_ = other.value_;
			this.name_ = other.name_;
			this.releaseDate_ = other.releaseDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0005BBA4 File Offset: 0x00059DA4
		[DebuggerNonUserCode]
		public Key Clone()
		{
			return new Key(this);
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0005BBBC File Offset: 0x00059DBC
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0005BBED File Offset: 0x00059DED
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Key.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0005BC08 File Offset: 0x00059E08
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0005BC25 File Offset: 0x00059E25
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0005BC38 File Offset: 0x00059E38
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0005BC59 File Offset: 0x00059E59
		[DebuggerNonUserCode]
		public ByteString Value
		{
			get
			{
				return this.value_ ?? Key.ValueDefaultValue;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0005BC70 File Offset: 0x00059E70
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return this.value_ != null;
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0005BC8E File Offset: 0x00059E8E
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this.value_ = null;
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0005BC98 File Offset: 0x00059E98
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0005BCB9 File Offset: 0x00059EB9
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Key.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0005BCD0 File Offset: 0x00059ED0
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0005BCEB File Offset: 0x00059EEB
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0005BCF8 File Offset: 0x00059EF8
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0005BD19 File Offset: 0x00059F19
		[DebuggerNonUserCode]
		public string ReleaseDate
		{
			get
			{
				return this.releaseDate_ ?? Key.ReleaseDateDefaultValue;
			}
			set
			{
				this.releaseDate_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0005BD30 File Offset: 0x00059F30
		[DebuggerNonUserCode]
		public bool HasReleaseDate
		{
			get
			{
				return this.releaseDate_ != null;
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0005BD4B File Offset: 0x00059F4B
		[DebuggerNonUserCode]
		public void ClearReleaseDate()
		{
			this.releaseDate_ = null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0005BD58 File Offset: 0x00059F58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Key);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0005BD78 File Offset: 0x00059F78
		[DebuggerNonUserCode]
		public bool Equals(Key other)
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
						bool flag5 = this.Value != other.Value;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ReleaseDate != other.ReleaseDate;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0005BE24 File Offset: 0x0005A024
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasReleaseDate = this.HasReleaseDate;
			if (hasReleaseDate)
			{
				num ^= this.ReleaseDate.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0005BEDC File Offset: 0x0005A0DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0005BEE8 File Offset: 0x0005A0E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Value);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasReleaseDate = this.HasReleaseDate;
			if (hasReleaseDate)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ReleaseDate);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0005BF9C File Offset: 0x0005A19C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Value);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasReleaseDate = this.HasReleaseDate;
			if (hasReleaseDate)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReleaseDate);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0005C044 File Offset: 0x0005A244
		[DebuggerNonUserCode]
		public void MergeFrom(Key other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasReleaseDate = other.HasReleaseDate;
				if (hasReleaseDate)
				{
					this.ReleaseDate = other.ReleaseDate;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0005C0DA File Offset: 0x0005A2DA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0005C0E8 File Offset: 0x0005A2E8
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
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.Value = input.ReadBytes();
					}
					else
					{
						this.Id = input.ReadUInt64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.ReleaseDate = input.ReadString();
				}
				else
				{
					this.Name = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A43 RID: 2627
		private static readonly MessageParser<Key> _parser = new MessageParser<Key>(() => new Key());

		// Token: 0x04000A44 RID: 2628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A45 RID: 2629
		private int _hasBits0;

		// Token: 0x04000A46 RID: 2630
		public const int IdFieldNumber = 1;

		// Token: 0x04000A47 RID: 2631
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04000A48 RID: 2632
		private ulong id_;

		// Token: 0x04000A49 RID: 2633
		public const int ValueFieldNumber = 2;

		// Token: 0x04000A4A RID: 2634
		private static readonly ByteString ValueDefaultValue = ByteString.Empty;

		// Token: 0x04000A4B RID: 2635
		private ByteString value_;

		// Token: 0x04000A4C RID: 2636
		public const int NameFieldNumber = 3;

		// Token: 0x04000A4D RID: 2637
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000A4E RID: 2638
		private string name_;

		// Token: 0x04000A4F RID: 2639
		public const int ReleaseDateFieldNumber = 4;

		// Token: 0x04000A50 RID: 2640
		private static readonly string ReleaseDateDefaultValue = "";

		// Token: 0x04000A51 RID: 2641
		private string releaseDate_;
	}
}
