using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000364 RID: 868
	public sealed class RepeatedFieldRestriction : IMessage<RepeatedFieldRestriction>, IMessage, IEquatable<RepeatedFieldRestriction>, IDeepCloneable<RepeatedFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x0015A644 File Offset: 0x00158844
		[DebuggerNonUserCode]
		public static MessageParser<RepeatedFieldRestriction> Parser
		{
			get
			{
				return RepeatedFieldRestriction._parser;
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600597D RID: 22909 RVA: 0x0015A65C File Offset: 0x0015885C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x0015A680 File Offset: 0x00158880
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RepeatedFieldRestriction.Descriptor;
			}
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x0015A697 File Offset: 0x00158897
		[DebuggerNonUserCode]
		public RepeatedFieldRestriction()
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x0015A6A8 File Offset: 0x001588A8
		[DebuggerNonUserCode]
		public RepeatedFieldRestriction(RepeatedFieldRestriction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.size_ = ((other.size_ != null) ? other.size_.Clone() : null);
			this.unique_ = other.unique_;
			switch (other.TypeCase)
			{
			case RepeatedFieldRestriction.TypeOneofCase.Signed:
				this.Signed = other.Signed.Clone();
				break;
			case RepeatedFieldRestriction.TypeOneofCase.Unsigned:
				this.Unsigned = other.Unsigned.Clone();
				break;
			case RepeatedFieldRestriction.TypeOneofCase.Float:
				this.Float = other.Float.Clone();
				break;
			case RepeatedFieldRestriction.TypeOneofCase.String:
				this.String = other.String.Clone();
				break;
			case RepeatedFieldRestriction.TypeOneofCase.EntityId:
				this.EntityId = other.EntityId.Clone();
				break;
			case RepeatedFieldRestriction.TypeOneofCase.Bytes:
				this.Bytes = other.Bytes.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x0015A7A8 File Offset: 0x001589A8
		[DebuggerNonUserCode]
		public RepeatedFieldRestriction Clone()
		{
			return new RepeatedFieldRestriction(this);
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x0015A7C0 File Offset: 0x001589C0
		// (set) Token: 0x06005983 RID: 22915 RVA: 0x0015A7D8 File Offset: 0x001589D8
		[DebuggerNonUserCode]
		public UnsignedIntRange Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x0015A7E4 File Offset: 0x001589E4
		// (set) Token: 0x06005985 RID: 22917 RVA: 0x0015A815 File Offset: 0x00158A15
		[DebuggerNonUserCode]
		public bool Unique
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool uniqueDefaultValue;
				if (flag)
				{
					uniqueDefaultValue = this.unique_;
				}
				else
				{
					uniqueDefaultValue = RepeatedFieldRestriction.UniqueDefaultValue;
				}
				return uniqueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unique_ = value;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06005986 RID: 22918 RVA: 0x0015A830 File Offset: 0x00158A30
		[DebuggerNonUserCode]
		public bool HasUnique
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x0015A84D File Offset: 0x00158A4D
		[DebuggerNonUserCode]
		public void ClearUnique()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x0015A860 File Offset: 0x00158A60
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x0015A889 File Offset: 0x00158A89
		[DebuggerNonUserCode]
		public SignedFieldRestriction Signed
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Signed) ? ((SignedFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.Signed);
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x0015A8A0 File Offset: 0x00158AA0
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x0015A8C9 File Offset: 0x00158AC9
		[DebuggerNonUserCode]
		public UnsignedFieldRestriction Unsigned
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Unsigned) ? ((UnsignedFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.Unsigned);
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x0600598C RID: 22924 RVA: 0x0015A8E0 File Offset: 0x00158AE0
		// (set) Token: 0x0600598D RID: 22925 RVA: 0x0015A909 File Offset: 0x00158B09
		[DebuggerNonUserCode]
		public FloatFieldRestriction Float
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Float) ? ((FloatFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.Float);
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x0015A920 File Offset: 0x00158B20
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x0015A949 File Offset: 0x00158B49
		[DebuggerNonUserCode]
		public StringFieldRestriction String
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.String) ? ((StringFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.String);
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x0015A960 File Offset: 0x00158B60
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x0015A989 File Offset: 0x00158B89
		[DebuggerNonUserCode]
		public EntityIdRestriction EntityId
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.EntityId) ? ((EntityIdRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.EntityId);
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x0015A9A0 File Offset: 0x00158BA0
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x0015A9C9 File Offset: 0x00158BC9
		[DebuggerNonUserCode]
		public StringFieldRestriction Bytes
		{
			get
			{
				return (this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Bytes) ? ((StringFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RepeatedFieldRestriction.TypeOneofCase.None : RepeatedFieldRestriction.TypeOneofCase.Bytes);
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x0015A9E0 File Offset: 0x00158BE0
		[DebuggerNonUserCode]
		public RepeatedFieldRestriction.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x0015A9F8 File Offset: 0x00158BF8
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = RepeatedFieldRestriction.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x0015AA0C File Offset: 0x00158C0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RepeatedFieldRestriction);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x0015AA2C File Offset: 0x00158C2C
		[DebuggerNonUserCode]
		public bool Equals(RepeatedFieldRestriction other)
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
					bool flag4 = !object.Equals(this.Size, other.Size);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Unique != other.Unique;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Signed, other.Signed);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Unsigned, other.Unsigned);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Float, other.Float);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.String, other.String);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.EntityId, other.EntityId);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Bytes, other.Bytes);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.TypeCase != other.TypeCase;
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

		// Token: 0x06005998 RID: 22936 RVA: 0x0015AB84 File Offset: 0x00158D84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.size_ != null;
			if (flag)
			{
				num ^= this.Size.GetHashCode();
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				num ^= this.Unique.GetHashCode();
			}
			bool flag2 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Signed;
			if (flag2)
			{
				num ^= this.Signed.GetHashCode();
			}
			bool flag3 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Unsigned;
			if (flag3)
			{
				num ^= this.Unsigned.GetHashCode();
			}
			bool flag4 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Float;
			if (flag4)
			{
				num ^= this.Float.GetHashCode();
			}
			bool flag5 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.String;
			if (flag5)
			{
				num ^= this.String.GetHashCode();
			}
			bool flag6 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.EntityId;
			if (flag6)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool flag7 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Bytes;
			if (flag7)
			{
				num ^= this.Bytes.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x0015ACA8 File Offset: 0x00158EA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x0015ACC0 File Offset: 0x00158EC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x0015ACCC File Offset: 0x00158ECC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.size_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Size);
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unique);
			}
			bool flag2 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Signed;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Signed);
			}
			bool flag3 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Unsigned;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Unsigned);
			}
			bool flag4 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Float;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Float);
			}
			bool flag5 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.String;
			if (flag5)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.String);
			}
			bool flag6 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.EntityId;
			if (flag6)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EntityId);
			}
			bool flag7 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Bytes;
			if (flag7)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Bytes);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x0015AE28 File Offset: 0x00159028
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.size_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Size);
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				num += 2;
			}
			bool flag2 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Signed;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Signed);
			}
			bool flag3 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Unsigned;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Unsigned);
			}
			bool flag4 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Float;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Float);
			}
			bool flag5 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.String;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.String);
			}
			bool flag6 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.EntityId;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool flag7 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Bytes;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Bytes);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x0015AF54 File Offset: 0x00159154
		[DebuggerNonUserCode]
		public void MergeFrom(RepeatedFieldRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.size_ != null;
				if (flag2)
				{
					bool flag3 = this.size_ == null;
					if (flag3)
					{
						this.Size = new UnsignedIntRange();
					}
					this.Size.MergeFrom(other.Size);
				}
				bool hasUnique = other.HasUnique;
				if (hasUnique)
				{
					this.Unique = other.Unique;
				}
				switch (other.TypeCase)
				{
				case RepeatedFieldRestriction.TypeOneofCase.Signed:
				{
					bool flag4 = this.Signed == null;
					if (flag4)
					{
						this.Signed = new SignedFieldRestriction();
					}
					this.Signed.MergeFrom(other.Signed);
					break;
				}
				case RepeatedFieldRestriction.TypeOneofCase.Unsigned:
				{
					bool flag5 = this.Unsigned == null;
					if (flag5)
					{
						this.Unsigned = new UnsignedFieldRestriction();
					}
					this.Unsigned.MergeFrom(other.Unsigned);
					break;
				}
				case RepeatedFieldRestriction.TypeOneofCase.Float:
				{
					bool flag6 = this.Float == null;
					if (flag6)
					{
						this.Float = new FloatFieldRestriction();
					}
					this.Float.MergeFrom(other.Float);
					break;
				}
				case RepeatedFieldRestriction.TypeOneofCase.String:
				{
					bool flag7 = this.String == null;
					if (flag7)
					{
						this.String = new StringFieldRestriction();
					}
					this.String.MergeFrom(other.String);
					break;
				}
				case RepeatedFieldRestriction.TypeOneofCase.EntityId:
				{
					bool flag8 = this.EntityId == null;
					if (flag8)
					{
						this.EntityId = new EntityIdRestriction();
					}
					this.EntityId.MergeFrom(other.EntityId);
					break;
				}
				case RepeatedFieldRestriction.TypeOneofCase.Bytes:
				{
					bool flag9 = this.Bytes == null;
					if (flag9)
					{
						this.Bytes = new StringFieldRestriction();
					}
					this.Bytes.MergeFrom(other.Bytes);
					break;
				}
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x0015B13D File Offset: 0x0015933D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x0015B148 File Offset: 0x00159348
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_0067;
							}
							this.Unique = input.ReadBool();
						}
						else
						{
							bool flag = this.size_ == null;
							if (flag)
							{
								this.Size = new UnsignedIntRange();
							}
							input.ReadMessage(this.Size);
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0067;
						}
						UnsignedFieldRestriction unsignedFieldRestriction = new UnsignedFieldRestriction();
						bool flag2 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Unsigned;
						if (flag2)
						{
							unsignedFieldRestriction.MergeFrom(this.Unsigned);
						}
						input.ReadMessage(unsignedFieldRestriction);
						this.Unsigned = unsignedFieldRestriction;
					}
					else
					{
						SignedFieldRestriction signedFieldRestriction = new SignedFieldRestriction();
						bool flag3 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Signed;
						if (flag3)
						{
							signedFieldRestriction.MergeFrom(this.Signed);
						}
						input.ReadMessage(signedFieldRestriction);
						this.Signed = signedFieldRestriction;
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0067;
						}
						StringFieldRestriction stringFieldRestriction = new StringFieldRestriction();
						bool flag4 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.String;
						if (flag4)
						{
							stringFieldRestriction.MergeFrom(this.String);
						}
						input.ReadMessage(stringFieldRestriction);
						this.String = stringFieldRestriction;
					}
					else
					{
						FloatFieldRestriction floatFieldRestriction = new FloatFieldRestriction();
						bool flag5 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Float;
						if (flag5)
						{
							floatFieldRestriction.MergeFrom(this.Float);
						}
						input.ReadMessage(floatFieldRestriction);
						this.Float = floatFieldRestriction;
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_0067;
					}
					StringFieldRestriction stringFieldRestriction2 = new StringFieldRestriction();
					bool flag6 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.Bytes;
					if (flag6)
					{
						stringFieldRestriction2.MergeFrom(this.Bytes);
					}
					input.ReadMessage(stringFieldRestriction2);
					this.Bytes = stringFieldRestriction2;
				}
				else
				{
					EntityIdRestriction entityIdRestriction = new EntityIdRestriction();
					bool flag7 = this.typeCase_ == RepeatedFieldRestriction.TypeOneofCase.EntityId;
					if (flag7)
					{
						entityIdRestriction.MergeFrom(this.EntityId);
					}
					input.ReadMessage(entityIdRestriction);
					this.EntityId = entityIdRestriction;
				}
				continue;
				IL_0067:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028CE RID: 10446
		private static readonly MessageParser<RepeatedFieldRestriction> _parser = new MessageParser<RepeatedFieldRestriction>(() => new RepeatedFieldRestriction());

		// Token: 0x040028CF RID: 10447
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D0 RID: 10448
		private int _hasBits0;

		// Token: 0x040028D1 RID: 10449
		public const int SizeFieldNumber = 1;

		// Token: 0x040028D2 RID: 10450
		private UnsignedIntRange size_;

		// Token: 0x040028D3 RID: 10451
		public const int UniqueFieldNumber = 2;

		// Token: 0x040028D4 RID: 10452
		private static readonly bool UniqueDefaultValue = false;

		// Token: 0x040028D5 RID: 10453
		private bool unique_;

		// Token: 0x040028D6 RID: 10454
		public const int SignedFieldNumber = 3;

		// Token: 0x040028D7 RID: 10455
		public const int UnsignedFieldNumber = 4;

		// Token: 0x040028D8 RID: 10456
		public const int FloatFieldNumber = 5;

		// Token: 0x040028D9 RID: 10457
		public const int StringFieldNumber = 6;

		// Token: 0x040028DA RID: 10458
		public const int EntityIdFieldNumber = 7;

		// Token: 0x040028DB RID: 10459
		public const int BytesFieldNumber = 8;

		// Token: 0x040028DC RID: 10460
		private object type_;

		// Token: 0x040028DD RID: 10461
		private RepeatedFieldRestriction.TypeOneofCase typeCase_ = RepeatedFieldRestriction.TypeOneofCase.None;

		// Token: 0x02000E42 RID: 3650
		public enum TypeOneofCase
		{
			// Token: 0x040095B0 RID: 38320
			None,
			// Token: 0x040095B1 RID: 38321
			Signed = 3,
			// Token: 0x040095B2 RID: 38322
			Unsigned,
			// Token: 0x040095B3 RID: 38323
			Float,
			// Token: 0x040095B4 RID: 38324
			String,
			// Token: 0x040095B5 RID: 38325
			EntityId,
			// Token: 0x040095B6 RID: 38326
			Bytes
		}
	}
}
