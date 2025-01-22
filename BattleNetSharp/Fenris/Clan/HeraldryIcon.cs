using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B6 RID: 694
	public sealed class HeraldryIcon : IMessage<HeraldryIcon>, IMessage, IEquatable<HeraldryIcon>, IDeepCloneable<HeraldryIcon>, IBufferMessage
	{
		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x060049CA RID: 18890 RVA: 0x0011AC94 File Offset: 0x00118E94
		[DebuggerNonUserCode]
		public static MessageParser<HeraldryIcon> Parser
		{
			get
			{
				return HeraldryIcon._parser;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x0011ACAC File Offset: 0x00118EAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060049CC RID: 18892 RVA: 0x0011ACD0 File Offset: 0x00118ED0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeraldryIcon.Descriptor;
			}
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x0011ACE7 File Offset: 0x00118EE7
		[DebuggerNonUserCode]
		public HeraldryIcon()
		{
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x0011ACF4 File Offset: 0x00118EF4
		[DebuggerNonUserCode]
		public HeraldryIcon(HeraldryIcon other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.index_ = other.index_;
			this.name_ = other.name_;
			this.size_ = other.size_;
			this.angle_ = other.angle_;
			this.flipped_ = other.flipped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x0011AD64 File Offset: 0x00118F64
		[DebuggerNonUserCode]
		public HeraldryIcon Clone()
		{
			return new HeraldryIcon(this);
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x0011AD7C File Offset: 0x00118F7C
		// (set) Token: 0x060049D1 RID: 18897 RVA: 0x0011ADAE File Offset: 0x00118FAE
		[DebuggerNonUserCode]
		public uint Index
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint indexDefaultValue;
				if (flag)
				{
					indexDefaultValue = this.index_;
				}
				else
				{
					indexDefaultValue = HeraldryIcon.IndexDefaultValue;
				}
				return indexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.index_ = value;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x0011ADC8 File Offset: 0x00118FC8
		[DebuggerNonUserCode]
		public bool HasIndex
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x0011ADE6 File Offset: 0x00118FE6
		[DebuggerNonUserCode]
		public void ClearIndex()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x0011ADF8 File Offset: 0x00118FF8
		// (set) Token: 0x060049D5 RID: 18901 RVA: 0x0011AE29 File Offset: 0x00119029
		[DebuggerNonUserCode]
		public uint Name
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint nameDefaultValue;
				if (flag)
				{
					nameDefaultValue = this.name_;
				}
				else
				{
					nameDefaultValue = HeraldryIcon.NameDefaultValue;
				}
				return nameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.name_ = value;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x0011AE44 File Offset: 0x00119044
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x0011AE61 File Offset: 0x00119061
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x0011AE74 File Offset: 0x00119074
		// (set) Token: 0x060049D9 RID: 18905 RVA: 0x0011AEA5 File Offset: 0x001190A5
		[DebuggerNonUserCode]
		public float Size
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float sizeDefaultValue;
				if (flag)
				{
					sizeDefaultValue = this.size_;
				}
				else
				{
					sizeDefaultValue = HeraldryIcon.SizeDefaultValue;
				}
				return sizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.size_ = value;
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x060049DA RID: 18906 RVA: 0x0011AEC0 File Offset: 0x001190C0
		[DebuggerNonUserCode]
		public bool HasSize
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x0011AEDD File Offset: 0x001190DD
		[DebuggerNonUserCode]
		public void ClearSize()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x0011AEF0 File Offset: 0x001190F0
		// (set) Token: 0x060049DD RID: 18909 RVA: 0x0011AF21 File Offset: 0x00119121
		[DebuggerNonUserCode]
		public float Angle
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float angleDefaultValue;
				if (flag)
				{
					angleDefaultValue = this.angle_;
				}
				else
				{
					angleDefaultValue = HeraldryIcon.AngleDefaultValue;
				}
				return angleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.angle_ = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x0011AF3C File Offset: 0x0011913C
		[DebuggerNonUserCode]
		public bool HasAngle
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x0011AF59 File Offset: 0x00119159
		[DebuggerNonUserCode]
		public void ClearAngle()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x060049E0 RID: 18912 RVA: 0x0011AF6C File Offset: 0x0011916C
		// (set) Token: 0x060049E1 RID: 18913 RVA: 0x0011AF9D File Offset: 0x0011919D
		[DebuggerNonUserCode]
		public bool Flipped
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool flippedDefaultValue;
				if (flag)
				{
					flippedDefaultValue = this.flipped_;
				}
				else
				{
					flippedDefaultValue = HeraldryIcon.FlippedDefaultValue;
				}
				return flippedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.flipped_ = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x0011AFB8 File Offset: 0x001191B8
		[DebuggerNonUserCode]
		public bool HasFlipped
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x0011AFD5 File Offset: 0x001191D5
		[DebuggerNonUserCode]
		public void ClearFlipped()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x0011AFE8 File Offset: 0x001191E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeraldryIcon);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x0011B008 File Offset: 0x00119208
		[DebuggerNonUserCode]
		public bool Equals(HeraldryIcon other)
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
					bool flag4 = this.Index != other.Index;
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
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Size, other.Size);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Angle, other.Angle);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Flipped != other.Flipped;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x0011B0E4 File Offset: 0x001192E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num ^= this.Index.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Size);
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Angle);
			}
			bool hasFlipped = this.HasFlipped;
			if (hasFlipped)
			{
				num ^= this.Flipped.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x0011B1AC File Offset: 0x001193AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x0011B1C4 File Offset: 0x001193C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x0011B1D0 File Offset: 0x001193D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Name);
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Size);
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Angle);
			}
			bool hasFlipped = this.HasFlipped;
			if (hasFlipped)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Flipped);
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Index);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x0011B2A8 File Offset: 0x001194A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Name);
			}
			bool hasSize = this.HasSize;
			if (hasSize)
			{
				num += 5;
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
			{
				num += 5;
			}
			bool hasFlipped = this.HasFlipped;
			if (hasFlipped)
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

		// Token: 0x060049EB RID: 18923 RVA: 0x0011B34C File Offset: 0x0011954C
		[DebuggerNonUserCode]
		public void MergeFrom(HeraldryIcon other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIndex = other.HasIndex;
				if (hasIndex)
				{
					this.Index = other.Index;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasSize = other.HasSize;
				if (hasSize)
				{
					this.Size = other.Size;
				}
				bool hasAngle = other.HasAngle;
				if (hasAngle)
				{
					this.Angle = other.Angle;
				}
				bool hasFlipped = other.HasFlipped;
				if (hasFlipped)
				{
					this.Flipped = other.Flipped;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x0011B400 File Offset: 0x00119600
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x0011B40C File Offset: 0x0011960C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0032;
						}
						this.Size = input.ReadFloat();
					}
					else
					{
						this.Name = input.ReadUInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.Index = input.ReadUInt32();
					}
					else
					{
						this.Flipped = input.ReadBool();
					}
				}
				else
				{
					this.Angle = input.ReadFloat();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020F3 RID: 8435
		private static readonly MessageParser<HeraldryIcon> _parser = new MessageParser<HeraldryIcon>(() => new HeraldryIcon());

		// Token: 0x040020F4 RID: 8436
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F5 RID: 8437
		private int _hasBits0;

		// Token: 0x040020F6 RID: 8438
		public const int IndexFieldNumber = 5;

		// Token: 0x040020F7 RID: 8439
		private static readonly uint IndexDefaultValue = 0U;

		// Token: 0x040020F8 RID: 8440
		private uint index_;

		// Token: 0x040020F9 RID: 8441
		public const int NameFieldNumber = 1;

		// Token: 0x040020FA RID: 8442
		private static readonly uint NameDefaultValue = 0U;

		// Token: 0x040020FB RID: 8443
		private uint name_;

		// Token: 0x040020FC RID: 8444
		public const int SizeFieldNumber = 2;

		// Token: 0x040020FD RID: 8445
		private static readonly float SizeDefaultValue = 0f;

		// Token: 0x040020FE RID: 8446
		private float size_;

		// Token: 0x040020FF RID: 8447
		public const int AngleFieldNumber = 3;

		// Token: 0x04002100 RID: 8448
		private static readonly float AngleDefaultValue = 0f;

		// Token: 0x04002101 RID: 8449
		private float angle_;

		// Token: 0x04002102 RID: 8450
		public const int FlippedFieldNumber = 4;

		// Token: 0x04002103 RID: 8451
		private static readonly bool FlippedDefaultValue = false;

		// Token: 0x04002104 RID: 8452
		private bool flipped_;
	}
}
