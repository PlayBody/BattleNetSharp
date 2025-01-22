using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x0200011F RID: 287
	public sealed class Attribute : IMessage<Attribute>, IMessage, IEquatable<Attribute>, IDeepCloneable<Attribute>, IBufferMessage
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0006CC34 File Offset: 0x0006AE34
		[DebuggerNonUserCode]
		public static MessageParser<Attribute> Parser
		{
			get
			{
				return Attribute._parser;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0006CC4C File Offset: 0x0006AE4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0006CC70 File Offset: 0x0006AE70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Attribute.Descriptor;
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0006CC87 File Offset: 0x0006AE87
		[DebuggerNonUserCode]
		public Attribute()
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0006CC98 File Offset: 0x0006AE98
		[DebuggerNonUserCode]
		public Attribute(Attribute other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			switch (other.TypeCase)
			{
			case Attribute.TypeOneofCase.BoolValue:
				this.BoolValue = other.BoolValue;
				break;
			case Attribute.TypeOneofCase.UintValue:
				this.UintValue = other.UintValue;
				break;
			case Attribute.TypeOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case Attribute.TypeOneofCase.DoubleValue:
				this.DoubleValue = other.DoubleValue;
				break;
			case Attribute.TypeOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case Attribute.TypeOneofCase.BlobValue:
				this.BlobValue = other.BlobValue;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0006CD5C File Offset: 0x0006AF5C
		[DebuggerNonUserCode]
		public Attribute Clone()
		{
			return new Attribute(this);
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0006CD74 File Offset: 0x0006AF74
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0006CDA5 File Offset: 0x0006AFA5
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Attribute.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0006CDC0 File Offset: 0x0006AFC0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0006CDDD File Offset: 0x0006AFDD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0006CE18 File Offset: 0x0006B018
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
				this.typeCase_ = Attribute.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0006CE30 File Offset: 0x0006B030
		[DebuggerNonUserCode]
		public bool HasBoolValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.BoolValue;
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0006CE4C File Offset: 0x0006B04C
		[DebuggerNonUserCode]
		public void ClearBoolValue()
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0006CE70 File Offset: 0x0006B070
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0006CE99 File Offset: 0x0006B099
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
				this.typeCase_ = Attribute.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0006CEB0 File Offset: 0x0006B0B0
		[DebuggerNonUserCode]
		public bool HasUintValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.UintValue;
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0006CECC File Offset: 0x0006B0CC
		[DebuggerNonUserCode]
		public void ClearUintValue()
		{
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0006CF19 File Offset: 0x0006B119
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
				this.typeCase_ = Attribute.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0006CF30 File Offset: 0x0006B130
		[DebuggerNonUserCode]
		public bool HasIntValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.IntValue;
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0006CF4C File Offset: 0x0006B14C
		[DebuggerNonUserCode]
		public void ClearIntValue()
		{
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0006CF70 File Offset: 0x0006B170
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0006CFA0 File Offset: 0x0006B1A0
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
				this.typeCase_ = Attribute.TypeOneofCase.DoubleValue;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0006CFB8 File Offset: 0x0006B1B8
		[DebuggerNonUserCode]
		public bool HasDoubleValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.DoubleValue;
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0006CFD4 File Offset: 0x0006B1D4
		[DebuggerNonUserCode]
		public void ClearDoubleValue()
		{
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0006CFF8 File Offset: 0x0006B1F8
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0006D024 File Offset: 0x0006B224
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
				this.typeCase_ = Attribute.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0006D040 File Offset: 0x0006B240
		[DebuggerNonUserCode]
		public bool HasStringValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.StringValue;
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0006D05C File Offset: 0x0006B25C
		[DebuggerNonUserCode]
		public void ClearStringValue()
		{
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0006D080 File Offset: 0x0006B280
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0006D0AC File Offset: 0x0006B2AC
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
				this.typeCase_ = Attribute.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0006D0C8 File Offset: 0x0006B2C8
		[DebuggerNonUserCode]
		public bool HasBlobValue
		{
			get
			{
				return this.typeCase_ == Attribute.TypeOneofCase.BlobValue;
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0006D0E4 File Offset: 0x0006B2E4
		[DebuggerNonUserCode]
		public void ClearBlobValue()
		{
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				this.ClearType();
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0006D108 File Offset: 0x0006B308
		[DebuggerNonUserCode]
		public Attribute.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0006D120 File Offset: 0x0006B320
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = Attribute.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0006D134 File Offset: 0x0006B334
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Attribute);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0006D154 File Offset: 0x0006B354
		[DebuggerNonUserCode]
		public bool Equals(Attribute other)
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
						bool flag5 = this.BoolValue != other.BoolValue;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.UintValue != other.UintValue;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IntValue != other.IntValue;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DoubleValue, other.DoubleValue);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.StringValue != other.StringValue;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.BlobValue != other.BlobValue;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.TypeCase != other.TypeCase;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
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

		// Token: 0x06001C97 RID: 7319 RVA: 0x0006D284 File Offset: 0x0006B484
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
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

		// Token: 0x06001C98 RID: 7320 RVA: 0x0006D38C File Offset: 0x0006B58C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0006D3A4 File Offset: 0x0006B5A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0006D3B0 File Offset: 0x0006B5B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.BoolValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.UintValue);
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.IntValue);
			}
			bool hasDoubleValue = this.HasDoubleValue;
			if (hasDoubleValue)
			{
				output.WriteRawTag(41);
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

		// Token: 0x06001C9B RID: 7323 RVA: 0x0006D4D0 File Offset: 0x0006B6D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
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

		// Token: 0x06001C9C RID: 7324 RVA: 0x0006D5BC File Offset: 0x0006B7BC
		[DebuggerNonUserCode]
		public void MergeFrom(Attribute other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				switch (other.TypeCase)
				{
				case Attribute.TypeOneofCase.BoolValue:
					this.BoolValue = other.BoolValue;
					break;
				case Attribute.TypeOneofCase.UintValue:
					this.UintValue = other.UintValue;
					break;
				case Attribute.TypeOneofCase.IntValue:
					this.IntValue = other.IntValue;
					break;
				case Attribute.TypeOneofCase.DoubleValue:
					this.DoubleValue = other.DoubleValue;
					break;
				case Attribute.TypeOneofCase.StringValue:
					this.StringValue = other.StringValue;
					break;
				case Attribute.TypeOneofCase.BlobValue:
					this.BlobValue = other.BlobValue;
					break;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0006D68D File Offset: 0x0006B88D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0006D698 File Offset: 0x0006B898
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
								goto IL_0045;
							}
							this.UintValue = input.ReadUInt64();
						}
						else
						{
							this.BoolValue = input.ReadBool();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 <= 41U)
				{
					if (num3 != 32U)
					{
						if (num3 != 41U)
						{
							goto IL_0045;
						}
						this.DoubleValue = input.ReadDouble();
					}
					else
					{
						this.IntValue = input.ReadInt64();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 58U)
					{
						goto IL_0045;
					}
					this.BlobValue = input.ReadBytes();
				}
				else
				{
					this.StringValue = input.ReadString();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly MessageParser<Attribute> _parser = new MessageParser<Attribute>(() => new Attribute());

		// Token: 0x04000C19 RID: 3097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C1A RID: 3098
		private int _hasBits0;

		// Token: 0x04000C1B RID: 3099
		public const int IdFieldNumber = 1;

		// Token: 0x04000C1C RID: 3100
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000C1D RID: 3101
		private uint id_;

		// Token: 0x04000C1E RID: 3102
		public const int BoolValueFieldNumber = 2;

		// Token: 0x04000C1F RID: 3103
		public const int UintValueFieldNumber = 3;

		// Token: 0x04000C20 RID: 3104
		public const int IntValueFieldNumber = 4;

		// Token: 0x04000C21 RID: 3105
		public const int DoubleValueFieldNumber = 5;

		// Token: 0x04000C22 RID: 3106
		public const int StringValueFieldNumber = 6;

		// Token: 0x04000C23 RID: 3107
		public const int BlobValueFieldNumber = 7;

		// Token: 0x04000C24 RID: 3108
		private object type_;

		// Token: 0x04000C25 RID: 3109
		private Attribute.TypeOneofCase typeCase_ = Attribute.TypeOneofCase.None;

		// Token: 0x02000C3B RID: 3131
		public enum TypeOneofCase
		{
			// Token: 0x04009390 RID: 37776
			None,
			// Token: 0x04009391 RID: 37777
			BoolValue = 2,
			// Token: 0x04009392 RID: 37778
			UintValue,
			// Token: 0x04009393 RID: 37779
			IntValue,
			// Token: 0x04009394 RID: 37780
			DoubleValue,
			// Token: 0x04009395 RID: 37781
			StringValue,
			// Token: 0x04009396 RID: 37782
			BlobValue
		}
	}
}
