using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034B RID: 843
	public sealed class Variant : IMessage<Variant>, IMessage, IEquatable<Variant>, IDeepCloneable<Variant>, IBufferMessage
	{
		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x00153144 File Offset: 0x00151344
		[DebuggerNonUserCode]
		public static MessageParser<Variant> Parser
		{
			get
			{
				return Variant._parser;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x0015315C File Offset: 0x0015135C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x00153180 File Offset: 0x00151380
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Variant.Descriptor;
			}
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00153197 File Offset: 0x00151397
		[DebuggerNonUserCode]
		public Variant()
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x001531A4 File Offset: 0x001513A4
		[DebuggerNonUserCode]
		public Variant(Variant other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.boolValue_ = other.boolValue_;
			this.intValue_ = other.intValue_;
			this.floatValue_ = other.floatValue_;
			this.stringValue_ = other.stringValue_;
			this.blobValue_ = other.blobValue_;
			this.messageValue_ = other.messageValue_;
			this.fourccValue_ = other.fourccValue_;
			this.uintValue_ = other.uintValue_;
			this.entityIdValue_ = ((other.entityIdValue_ != null) ? other.entityIdValue_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00153254 File Offset: 0x00151454
		[DebuggerNonUserCode]
		public Variant Clone()
		{
			return new Variant(this);
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x0015326C File Offset: 0x0015146C
		// (set) Token: 0x0600579F RID: 22431 RVA: 0x0015329D File Offset: 0x0015149D
		[DebuggerNonUserCode]
		public bool BoolValue
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool boolValueDefaultValue;
				if (flag)
				{
					boolValueDefaultValue = this.boolValue_;
				}
				else
				{
					boolValueDefaultValue = Variant.BoolValueDefaultValue;
				}
				return boolValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.boolValue_ = value;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x001532B8 File Offset: 0x001514B8
		[DebuggerNonUserCode]
		public bool HasBoolValue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x001532D5 File Offset: 0x001514D5
		[DebuggerNonUserCode]
		public void ClearBoolValue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x001532E8 File Offset: 0x001514E8
		// (set) Token: 0x060057A3 RID: 22435 RVA: 0x00153319 File Offset: 0x00151519
		[DebuggerNonUserCode]
		public long IntValue
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long intValueDefaultValue;
				if (flag)
				{
					intValueDefaultValue = this.intValue_;
				}
				else
				{
					intValueDefaultValue = Variant.IntValueDefaultValue;
				}
				return intValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.intValue_ = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x00153334 File Offset: 0x00151534
		[DebuggerNonUserCode]
		public bool HasIntValue
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x00153351 File Offset: 0x00151551
		[DebuggerNonUserCode]
		public void ClearIntValue()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x00153364 File Offset: 0x00151564
		// (set) Token: 0x060057A7 RID: 22439 RVA: 0x00153395 File Offset: 0x00151595
		[DebuggerNonUserCode]
		public double FloatValue
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				double floatValueDefaultValue;
				if (flag)
				{
					floatValueDefaultValue = this.floatValue_;
				}
				else
				{
					floatValueDefaultValue = Variant.FloatValueDefaultValue;
				}
				return floatValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.floatValue_ = value;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x001533B0 File Offset: 0x001515B0
		[DebuggerNonUserCode]
		public bool HasFloatValue
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x001533CD File Offset: 0x001515CD
		[DebuggerNonUserCode]
		public void ClearFloatValue()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x001533E0 File Offset: 0x001515E0
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x00153401 File Offset: 0x00151601
		[DebuggerNonUserCode]
		public string StringValue
		{
			get
			{
				return this.stringValue_ ?? Variant.StringValueDefaultValue;
			}
			set
			{
				this.stringValue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x00153418 File Offset: 0x00151618
		[DebuggerNonUserCode]
		public bool HasStringValue
		{
			get
			{
				return this.stringValue_ != null;
			}
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00153433 File Offset: 0x00151633
		[DebuggerNonUserCode]
		public void ClearStringValue()
		{
			this.stringValue_ = null;
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x00153440 File Offset: 0x00151640
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x00153461 File Offset: 0x00151661
		[DebuggerNonUserCode]
		public ByteString BlobValue
		{
			get
			{
				return this.blobValue_ ?? Variant.BlobValueDefaultValue;
			}
			set
			{
				this.blobValue_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x00153478 File Offset: 0x00151678
		[DebuggerNonUserCode]
		public bool HasBlobValue
		{
			get
			{
				return this.blobValue_ != null;
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00153496 File Offset: 0x00151696
		[DebuggerNonUserCode]
		public void ClearBlobValue()
		{
			this.blobValue_ = null;
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x001534A0 File Offset: 0x001516A0
		// (set) Token: 0x060057B3 RID: 22451 RVA: 0x001534C1 File Offset: 0x001516C1
		[DebuggerNonUserCode]
		public ByteString MessageValue
		{
			get
			{
				return this.messageValue_ ?? Variant.MessageValueDefaultValue;
			}
			set
			{
				this.messageValue_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x001534D8 File Offset: 0x001516D8
		[DebuggerNonUserCode]
		public bool HasMessageValue
		{
			get
			{
				return this.messageValue_ != null;
			}
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x001534F6 File Offset: 0x001516F6
		[DebuggerNonUserCode]
		public void ClearMessageValue()
		{
			this.messageValue_ = null;
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x00153500 File Offset: 0x00151700
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x00153521 File Offset: 0x00151721
		[DebuggerNonUserCode]
		public string FourccValue
		{
			get
			{
				return this.fourccValue_ ?? Variant.FourccValueDefaultValue;
			}
			set
			{
				this.fourccValue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x00153538 File Offset: 0x00151738
		[DebuggerNonUserCode]
		public bool HasFourccValue
		{
			get
			{
				return this.fourccValue_ != null;
			}
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00153553 File Offset: 0x00151753
		[DebuggerNonUserCode]
		public void ClearFourccValue()
		{
			this.fourccValue_ = null;
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x00153560 File Offset: 0x00151760
		// (set) Token: 0x060057BB RID: 22459 RVA: 0x00153591 File Offset: 0x00151791
		[DebuggerNonUserCode]
		public ulong UintValue
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong uintValueDefaultValue;
				if (flag)
				{
					uintValueDefaultValue = this.uintValue_;
				}
				else
				{
					uintValueDefaultValue = Variant.UintValueDefaultValue;
				}
				return uintValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.uintValue_ = value;
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x001535AC File Offset: 0x001517AC
		[DebuggerNonUserCode]
		public bool HasUintValue
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x001535C9 File Offset: 0x001517C9
		[DebuggerNonUserCode]
		public void ClearUintValue()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x001535DC File Offset: 0x001517DC
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x001535F4 File Offset: 0x001517F4
		[DebuggerNonUserCode]
		public EntityId EntityIdValue
		{
			get
			{
				return this.entityIdValue_;
			}
			set
			{
				this.entityIdValue_ = value;
			}
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00153600 File Offset: 0x00151800
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Variant);
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00153620 File Offset: 0x00151820
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
										bool flag9 = this.MessageValue != other.MessageValue;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.FourccValue != other.FourccValue;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.UintValue != other.UintValue;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.EntityIdValue, other.EntityIdValue);
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
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

		// Token: 0x060057C2 RID: 22466 RVA: 0x00153770 File Offset: 0x00151970
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
			bool hasMessageValue = this.HasMessageValue;
			if (hasMessageValue)
			{
				num ^= this.MessageValue.GetHashCode();
			}
			bool hasFourccValue = this.HasFourccValue;
			if (hasFourccValue)
			{
				num ^= this.FourccValue.GetHashCode();
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num ^= this.UintValue.GetHashCode();
			}
			bool flag = this.entityIdValue_ != null;
			if (flag)
			{
				num ^= this.EntityIdValue.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x001538A0 File Offset: 0x00151AA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x001538B8 File Offset: 0x00151AB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x001538C4 File Offset: 0x00151AC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBoolValue = this.HasBoolValue;
			if (hasBoolValue)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.BoolValue);
			}
			bool hasIntValue = this.HasIntValue;
			if (hasIntValue)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.IntValue);
			}
			bool hasFloatValue = this.HasFloatValue;
			if (hasFloatValue)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.FloatValue);
			}
			bool hasStringValue = this.HasStringValue;
			if (hasStringValue)
			{
				output.WriteRawTag(42);
				output.WriteString(this.StringValue);
			}
			bool hasBlobValue = this.HasBlobValue;
			if (hasBlobValue)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.BlobValue);
			}
			bool hasMessageValue = this.HasMessageValue;
			if (hasMessageValue)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.MessageValue);
			}
			bool hasFourccValue = this.HasFourccValue;
			if (hasFourccValue)
			{
				output.WriteRawTag(66);
				output.WriteString(this.FourccValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.UintValue);
			}
			bool flag = this.entityIdValue_ != null;
			if (flag)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EntityIdValue);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00153A30 File Offset: 0x00151C30
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
			bool hasMessageValue = this.HasMessageValue;
			if (hasMessageValue)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MessageValue);
			}
			bool hasFourccValue = this.HasFourccValue;
			if (hasFourccValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FourccValue);
			}
			bool hasUintValue = this.HasUintValue;
			if (hasUintValue)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UintValue);
			}
			bool flag = this.entityIdValue_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityIdValue);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00153B5C File Offset: 0x00151D5C
		[DebuggerNonUserCode]
		public void MergeFrom(Variant other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBoolValue = other.HasBoolValue;
				if (hasBoolValue)
				{
					this.BoolValue = other.BoolValue;
				}
				bool hasIntValue = other.HasIntValue;
				if (hasIntValue)
				{
					this.IntValue = other.IntValue;
				}
				bool hasFloatValue = other.HasFloatValue;
				if (hasFloatValue)
				{
					this.FloatValue = other.FloatValue;
				}
				bool hasStringValue = other.HasStringValue;
				if (hasStringValue)
				{
					this.StringValue = other.StringValue;
				}
				bool hasBlobValue = other.HasBlobValue;
				if (hasBlobValue)
				{
					this.BlobValue = other.BlobValue;
				}
				bool hasMessageValue = other.HasMessageValue;
				if (hasMessageValue)
				{
					this.MessageValue = other.MessageValue;
				}
				bool hasFourccValue = other.HasFourccValue;
				if (hasFourccValue)
				{
					this.FourccValue = other.FourccValue;
				}
				bool hasUintValue = other.HasUintValue;
				if (hasUintValue)
				{
					this.UintValue = other.UintValue;
				}
				bool flag2 = other.entityIdValue_ != null;
				if (flag2)
				{
					bool flag3 = this.entityIdValue_ == null;
					if (flag3)
					{
						this.EntityIdValue = new EntityId();
					}
					this.EntityIdValue.MergeFrom(other.EntityIdValue);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00153CA1 File Offset: 0x00151EA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00153CAC File Offset: 0x00151EAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_006E;
							}
							this.IntValue = input.ReadInt64();
						}
						else
						{
							this.BoolValue = input.ReadBool();
						}
					}
					else if (num3 != 33U)
					{
						if (num3 != 42U)
						{
							goto IL_006E;
						}
						this.StringValue = input.ReadString();
					}
					else
					{
						this.FloatValue = input.ReadDouble();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_006E;
						}
						this.MessageValue = input.ReadBytes();
					}
					else
					{
						this.BlobValue = input.ReadBytes();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 72U)
					{
						if (num3 != 82U)
						{
							goto IL_006E;
						}
						bool flag = this.entityIdValue_ == null;
						if (flag)
						{
							this.EntityIdValue = new EntityId();
						}
						input.ReadMessage(this.EntityIdValue);
					}
					else
					{
						this.UintValue = input.ReadUInt64();
					}
				}
				else
				{
					this.FourccValue = input.ReadString();
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027FD RID: 10237
		private static readonly MessageParser<Variant> _parser = new MessageParser<Variant>(() => new Variant());

		// Token: 0x040027FE RID: 10238
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027FF RID: 10239
		private int _hasBits0;

		// Token: 0x04002800 RID: 10240
		public const int BoolValueFieldNumber = 2;

		// Token: 0x04002801 RID: 10241
		private static readonly bool BoolValueDefaultValue = false;

		// Token: 0x04002802 RID: 10242
		private bool boolValue_;

		// Token: 0x04002803 RID: 10243
		public const int IntValueFieldNumber = 3;

		// Token: 0x04002804 RID: 10244
		private static readonly long IntValueDefaultValue = 0L;

		// Token: 0x04002805 RID: 10245
		private long intValue_;

		// Token: 0x04002806 RID: 10246
		public const int FloatValueFieldNumber = 4;

		// Token: 0x04002807 RID: 10247
		private static readonly double FloatValueDefaultValue = 0.0;

		// Token: 0x04002808 RID: 10248
		private double floatValue_;

		// Token: 0x04002809 RID: 10249
		public const int StringValueFieldNumber = 5;

		// Token: 0x0400280A RID: 10250
		private static readonly string StringValueDefaultValue = "";

		// Token: 0x0400280B RID: 10251
		private string stringValue_;

		// Token: 0x0400280C RID: 10252
		public const int BlobValueFieldNumber = 6;

		// Token: 0x0400280D RID: 10253
		private static readonly ByteString BlobValueDefaultValue = ByteString.Empty;

		// Token: 0x0400280E RID: 10254
		private ByteString blobValue_;

		// Token: 0x0400280F RID: 10255
		public const int MessageValueFieldNumber = 7;

		// Token: 0x04002810 RID: 10256
		private static readonly ByteString MessageValueDefaultValue = ByteString.Empty;

		// Token: 0x04002811 RID: 10257
		private ByteString messageValue_;

		// Token: 0x04002812 RID: 10258
		public const int FourccValueFieldNumber = 8;

		// Token: 0x04002813 RID: 10259
		private static readonly string FourccValueDefaultValue = "";

		// Token: 0x04002814 RID: 10260
		private string fourccValue_;

		// Token: 0x04002815 RID: 10261
		public const int UintValueFieldNumber = 9;

		// Token: 0x04002816 RID: 10262
		private static readonly ulong UintValueDefaultValue = 0UL;

		// Token: 0x04002817 RID: 10263
		private ulong uintValue_;

		// Token: 0x04002818 RID: 10264
		public const int EntityIdValueFieldNumber = 10;

		// Token: 0x04002819 RID: 10265
		private EntityId entityIdValue_;
	}
}
