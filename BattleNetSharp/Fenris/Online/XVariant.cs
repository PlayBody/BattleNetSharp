using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014A RID: 330
	public sealed class XVariant : IMessage<XVariant>, IMessage, IEquatable<XVariant>, IDeepCloneable<XVariant>, IBufferMessage
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000852B0 File Offset: 0x000834B0
		[DebuggerNonUserCode]
		public static MessageParser<XVariant> Parser
		{
			get
			{
				return XVariant._parser;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000852C8 File Offset: 0x000834C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000852EC File Offset: 0x000834EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XVariant.Descriptor;
			}
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00085303 File Offset: 0x00083503
		[DebuggerNonUserCode]
		public XVariant()
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00085314 File Offset: 0x00083514
		[DebuggerNonUserCode]
		public XVariant(XVariant other)
			: this()
		{
			switch (other.TypeCase)
			{
			case XVariant.TypeOneofCase.BoolValue:
				this.BoolValue = other.BoolValue;
				break;
			case XVariant.TypeOneofCase.UintValue:
				this.UintValue = other.UintValue;
				break;
			case XVariant.TypeOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case XVariant.TypeOneofCase.DoubleValue:
				this.DoubleValue = other.DoubleValue;
				break;
			case XVariant.TypeOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case XVariant.TypeOneofCase.BlobValue:
				this.BlobValue = other.BlobValue;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000853C4 File Offset: 0x000835C4
		[DebuggerNonUserCode]
		public XVariant Clone()
		{
			return new XVariant(this);
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x000853DC File Offset: 0x000835DC
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00085404 File Offset: 0x00083604
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
				this.typeCase_ = XVariant.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x0008541C File Offset: 0x0008361C
		[DebuggerNonUserCode]
		public bool HasBoolValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00085438 File Offset: 0x00083638
		[DebuggerNonUserCode]
		public void ClearBoolValue()
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0008545C File Offset: 0x0008365C
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00085485 File Offset: 0x00083685
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
				this.typeCase_ = XVariant.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0008549C File Offset: 0x0008369C
		[DebuggerNonUserCode]
		public bool HasUintValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000854B8 File Offset: 0x000836B8
		[DebuggerNonUserCode]
		public void ClearUintValue()
		{
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x000854DC File Offset: 0x000836DC
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00085505 File Offset: 0x00083705
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
				this.typeCase_ = XVariant.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0008551C File Offset: 0x0008371C
		[DebuggerNonUserCode]
		public bool HasIntValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00085538 File Offset: 0x00083738
		[DebuggerNonUserCode]
		public void ClearIntValue()
		{
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0008555C File Offset: 0x0008375C
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0008558C File Offset: 0x0008378C
		[DebuggerNonUserCode]
		public double DoubleValue
		{
			get
			{
				return this.HasDoubleValue ? ((double)this.type_) : 0.0;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = XVariant.TypeOneofCase.DoubleValue;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000855A4 File Offset: 0x000837A4
		[DebuggerNonUserCode]
		public bool HasDoubleValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.DoubleValue;
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000855C0 File Offset: 0x000837C0
		[DebuggerNonUserCode]
		public void ClearDoubleValue()
		{
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000855E4 File Offset: 0x000837E4
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00085610 File Offset: 0x00083810
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
				this.typeCase_ = XVariant.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0008562C File Offset: 0x0008382C
		[DebuggerNonUserCode]
		public bool HasStringValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00085648 File Offset: 0x00083848
		[DebuggerNonUserCode]
		public void ClearStringValue()
		{
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0008566C File Offset: 0x0008386C
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00085698 File Offset: 0x00083898
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
				this.typeCase_ = XVariant.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000856B4 File Offset: 0x000838B4
		[DebuggerNonUserCode]
		public bool HasBlobValue
		{
			get
			{
				return this.typeCase_ == XVariant.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000856D0 File Offset: 0x000838D0
		[DebuggerNonUserCode]
		public void ClearBlobValue()
		{
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000856F4 File Offset: 0x000838F4
		[DebuggerNonUserCode]
		public XVariant.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0008570C File Offset: 0x0008390C
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = XVariant.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00085720 File Offset: 0x00083920
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as XVariant);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00085740 File Offset: 0x00083940
		[DebuggerNonUserCode]
		public bool Equals(XVariant other)
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
						bool flag5 = this.UintValue != other.UintValue;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IntValue != other.IntValue;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DoubleValue, other.DoubleValue);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.StringValue != other.StringValue;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.BlobValue != other.BlobValue;
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

		// Token: 0x06002248 RID: 8776 RVA: 0x00085850 File Offset: 0x00083A50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				num ^= this.BoolValue.GetHashCode();
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num ^= this.UintValue.GetHashCode();
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				num ^= this.IntValue.GetHashCode();
			}
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DoubleValue);
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
			num ^= (int)this.typeCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00085938 File Offset: 0x00083B38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00085950 File Offset: 0x00083B50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0008595C File Offset: 0x00083B5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.BoolValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.UintValue);
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.IntValue);
			}
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.DoubleValue);
			}
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				output.WriteRawTag(50);
				output.WriteString(this.StringValue);
			}
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.BlobValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00085A58 File Offset: 0x00083C58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				num += 2;
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UintValue);
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IntValue);
			}
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00085B28 File Offset: 0x00083D28
		[DebuggerNonUserCode]
		public void MergeFrom(XVariant other)
		{
			bool flag = other == null;
			if (!flag)
			{
				switch (other.TypeCase)
				{
				case XVariant.TypeOneofCase.BoolValue:
					this.BoolValue = other.BoolValue;
					break;
				case XVariant.TypeOneofCase.UintValue:
					this.UintValue = other.UintValue;
					break;
				case XVariant.TypeOneofCase.IntValue:
					this.IntValue = other.IntValue;
					break;
				case XVariant.TypeOneofCase.DoubleValue:
					this.DoubleValue = other.DoubleValue;
					break;
				case XVariant.TypeOneofCase.StringValue:
					this.StringValue = other.StringValue;
					break;
				case XVariant.TypeOneofCase.BlobValue:
					this.BlobValue = other.BlobValue;
					break;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00085BE4 File Offset: 0x00083DE4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00085BF0 File Offset: 0x00083DF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.IntValue = input.ReadInt64();
						}
						else
						{
							this.UintValue = input.ReadUInt64();
						}
					}
					else
					{
						this.BoolValue = input.ReadBool();
					}
				}
				else if (num3 != 33U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_0039;
						}
						this.BlobValue = input.ReadBytes();
					}
					else
					{
						this.StringValue = input.ReadString();
					}
				}
				else
				{
					this.DoubleValue = input.ReadDouble();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F1B RID: 3867
		private static readonly MessageParser<XVariant> _parser = new MessageParser<XVariant>(() => new XVariant());

		// Token: 0x04000F1C RID: 3868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F1D RID: 3869
		public const int BoolValueFieldNumber = 1;

		// Token: 0x04000F1E RID: 3870
		public const int UintValueFieldNumber = 2;

		// Token: 0x04000F1F RID: 3871
		public const int IntValueFieldNumber = 3;

		// Token: 0x04000F20 RID: 3872
		public const int DoubleValueFieldNumber = 4;

		// Token: 0x04000F21 RID: 3873
		public const int StringValueFieldNumber = 6;

		// Token: 0x04000F22 RID: 3874
		public const int BlobValueFieldNumber = 7;

		// Token: 0x04000F23 RID: 3875
		private object type_;

		// Token: 0x04000F24 RID: 3876
		private XVariant.TypeOneofCase typeCase_ = XVariant.TypeOneofCase.None;

		// Token: 0x02000C67 RID: 3175
		public enum TypeOneofCase
		{
			// Token: 0x040093BE RID: 37822
			None,
			// Token: 0x040093BF RID: 37823
			BoolValue,
			// Token: 0x040093C0 RID: 37824
			UintValue,
			// Token: 0x040093C1 RID: 37825
			IntValue,
			// Token: 0x040093C2 RID: 37826
			DoubleValue,
			// Token: 0x040093C3 RID: 37827
			StringValue = 6,
			// Token: 0x040093C4 RID: 37828
			BlobValue
		}
	}
}
