using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.V2
{
	// Token: 0x0200062B RID: 1579
	public sealed class Variant : IMessage<Variant>, IMessage, IEquatable<Variant>, IDeepCloneable<Variant>, IBufferMessage
	{
		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600936A RID: 37738 RVA: 0x0023B514 File Offset: 0x00239714
		[DebuggerNonUserCode]
		public static MessageParser<Variant> Parser
		{
			get
			{
				return Variant._parser;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x0023B52C File Offset: 0x0023972C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600936C RID: 37740 RVA: 0x0023B550 File Offset: 0x00239750
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Variant.Descriptor;
			}
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x0023B567 File Offset: 0x00239767
		[DebuggerNonUserCode]
		public Variant()
		{
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x0023B578 File Offset: 0x00239778
		[DebuggerNonUserCode]
		public Variant(Variant other)
			: this()
		{
			switch (other.TypeCase)
			{
			case Variant.TypeOneofCase.BoolValue:
				this.BoolValue = other.BoolValue;
				break;
			case Variant.TypeOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case Variant.TypeOneofCase.FloatValue:
				this.FloatValue = other.FloatValue;
				break;
			case Variant.TypeOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case Variant.TypeOneofCase.BlobValue:
				this.BlobValue = other.BlobValue;
				break;
			case Variant.TypeOneofCase.UintValue:
				this.UintValue = other.UintValue;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x0023B624 File Offset: 0x00239824
		[DebuggerNonUserCode]
		public Variant Clone()
		{
			return new Variant(this);
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x06009370 RID: 37744 RVA: 0x0023B63C File Offset: 0x0023983C
		// (set) Token: 0x06009371 RID: 37745 RVA: 0x0023B664 File Offset: 0x00239864
		[DebuggerNonUserCode]
		public bool BoolValue
		{
			get
			{
				return this.HasBoolValue && (bool)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = Variant.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x06009372 RID: 37746 RVA: 0x0023B67C File Offset: 0x0023987C
		[DebuggerNonUserCode]
		public bool HasBoolValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x0023B698 File Offset: 0x00239898
		[DebuggerNonUserCode]
		public void ClearBoolValue()
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x0023B6BC File Offset: 0x002398BC
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x0023B6E5 File Offset: 0x002398E5
		[DebuggerNonUserCode]
		public long IntValue
		{
			get
			{
				return this.HasIntValue ? ((long)this.type_) : 0L;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = Variant.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x06009376 RID: 37750 RVA: 0x0023B6FC File Offset: 0x002398FC
		[DebuggerNonUserCode]
		public bool HasIntValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x0023B718 File Offset: 0x00239918
		[DebuggerNonUserCode]
		public void ClearIntValue()
		{
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x0023B73C File Offset: 0x0023993C
		// (set) Token: 0x06009379 RID: 37753 RVA: 0x0023B76C File Offset: 0x0023996C
		[DebuggerNonUserCode]
		public double FloatValue
		{
			get
			{
				return this.HasFloatValue ? ((double)this.type_) : 0.0;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = Variant.TypeOneofCase.FloatValue;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x0023B784 File Offset: 0x00239984
		[DebuggerNonUserCode]
		public bool HasFloatValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.FloatValue;
			}
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x0023B7A0 File Offset: 0x002399A0
		[DebuggerNonUserCode]
		public void ClearFloatValue()
		{
			bool hasFloatValue = this.HasFloatValue;
			if (hasFloatValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x0023B7C4 File Offset: 0x002399C4
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x0023B7F0 File Offset: 0x002399F0
		[DebuggerNonUserCode]
		public string StringValue
		{
			get
			{
				return this.HasStringValue ? ((string)this.type_) : "";
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.typeCase_ = Variant.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x0023B80C File Offset: 0x00239A0C
		[DebuggerNonUserCode]
		public bool HasStringValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x0023B828 File Offset: 0x00239A28
		[DebuggerNonUserCode]
		public void ClearStringValue()
		{
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x0023B84C File Offset: 0x00239A4C
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x0023B878 File Offset: 0x00239A78
		[DebuggerNonUserCode]
		public ByteString BlobValue
		{
			get
			{
				return this.HasBlobValue ? ((ByteString)this.type_) : ByteString.Empty;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
				this.typeCase_ = Variant.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x0023B894 File Offset: 0x00239A94
		[DebuggerNonUserCode]
		public bool HasBlobValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x0023B8B0 File Offset: 0x00239AB0
		[DebuggerNonUserCode]
		public void ClearBlobValue()
		{
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x06009384 RID: 37764 RVA: 0x0023B8D4 File Offset: 0x00239AD4
		// (set) Token: 0x06009385 RID: 37765 RVA: 0x0023B8FD File Offset: 0x00239AFD
		[DebuggerNonUserCode]
		public ulong UintValue
		{
			get
			{
				return this.HasUintValue ? ((ulong)this.type_) : 0UL;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = Variant.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x06009386 RID: 37766 RVA: 0x0023B914 File Offset: 0x00239B14
		[DebuggerNonUserCode]
		public bool HasUintValue
		{
			get
			{
				return this.typeCase_ == Variant.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x0023B930 File Offset: 0x00239B30
		[DebuggerNonUserCode]
		public void ClearUintValue()
		{
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x06009388 RID: 37768 RVA: 0x0023B954 File Offset: 0x00239B54
		[DebuggerNonUserCode]
		public Variant.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x0023B96C File Offset: 0x00239B6C
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = Variant.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x0023B980 File Offset: 0x00239B80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Variant);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x0023B9A0 File Offset: 0x00239BA0
		[DebuggerNonUserCode]
		public bool Equals(Variant other)
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
					bool flag4 = this.BoolValue != other.BoolValue;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IntValue != other.IntValue;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.FloatValue, other.FloatValue);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.StringValue != other.StringValue;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BlobValue != other.BlobValue;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.UintValue != other.UintValue;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TypeCase != other.TypeCase;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x0023BAB0 File Offset: 0x00239CB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				num ^= this.BoolValue.GetHashCode();
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				num ^= this.IntValue.GetHashCode();
			}
			bool hasFloatValue = this.HasFloatValue;
			if (hasFloatValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.FloatValue);
			}
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				num ^= this.StringValue.GetHashCode();
			}
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				num ^= this.BlobValue.GetHashCode();
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num ^= this.UintValue.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x0023BB98 File Offset: 0x00239D98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x0023BBB0 File Offset: 0x00239DB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x0023BBBC File Offset: 0x00239DBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.BoolValue);
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.IntValue);
			}
			bool hasFloatValue = this.HasFloatValue;
			if (hasFloatValue)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.FloatValue);
			}
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				output.WriteRawTag(34);
				output.WriteString(this.StringValue);
			}
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.BlobValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UintValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x0023BCB8 File Offset: 0x00239EB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				num += 2;
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IntValue);
			}
			bool hasFloatValue = this.HasFloatValue;
			if (hasFloatValue)
			{
				num += 9;
			}
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
			}
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.BlobValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UintValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x0023BD88 File Offset: 0x00239F88
		[DebuggerNonUserCode]
		public void MergeFrom(Variant other)
		{
			bool flag = other == null;
			if (!flag)
			{
				switch (other.TypeCase)
				{
				case Variant.TypeOneofCase.BoolValue:
					this.BoolValue = other.BoolValue;
					break;
				case Variant.TypeOneofCase.IntValue:
					this.IntValue = other.IntValue;
					break;
				case Variant.TypeOneofCase.FloatValue:
					this.FloatValue = other.FloatValue;
					break;
				case Variant.TypeOneofCase.StringValue:
					this.StringValue = other.StringValue;
					break;
				case Variant.TypeOneofCase.BlobValue:
					this.BlobValue = other.BlobValue;
					break;
				case Variant.TypeOneofCase.UintValue:
					this.UintValue = other.UintValue;
					break;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x0023BE40 File Offset: 0x0023A040
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x0023BE4C File Offset: 0x0023A04C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 25U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 25U)
							{
								goto IL_0039;
							}
							this.FloatValue = input.ReadDouble();
						}
						else
						{
							this.IntValue = input.ReadInt64();
						}
					}
					else
					{
						this.BoolValue = input.ReadBool();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.UintValue = input.ReadUInt64();
					}
					else
					{
						this.BlobValue = input.ReadBytes();
					}
				}
				else
				{
					this.StringValue = input.ReadString();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004292 RID: 17042
		private static readonly MessageParser<Variant> _parser = new MessageParser<Variant>(() => new Variant());

		// Token: 0x04004293 RID: 17043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004294 RID: 17044
		public const int BoolValueFieldNumber = 1;

		// Token: 0x04004295 RID: 17045
		public const int IntValueFieldNumber = 2;

		// Token: 0x04004296 RID: 17046
		public const int FloatValueFieldNumber = 3;

		// Token: 0x04004297 RID: 17047
		public const int StringValueFieldNumber = 4;

		// Token: 0x04004298 RID: 17048
		public const int BlobValueFieldNumber = 5;

		// Token: 0x04004299 RID: 17049
		public const int UintValueFieldNumber = 6;

		// Token: 0x0400429A RID: 17050
		private object type_;

		// Token: 0x0400429B RID: 17051
		private Variant.TypeOneofCase typeCase_ = Variant.TypeOneofCase.None;

		// Token: 0x0200111F RID: 4383
		public enum TypeOneofCase
		{
			// Token: 0x0400985A RID: 39002
			None,
			// Token: 0x0400985B RID: 39003
			BoolValue,
			// Token: 0x0400985C RID: 39004
			IntValue,
			// Token: 0x0400985D RID: 39005
			FloatValue,
			// Token: 0x0400985E RID: 39006
			StringValue,
			// Token: 0x0400985F RID: 39007
			BlobValue,
			// Token: 0x04009860 RID: 39008
			UintValue
		}
	}
}
