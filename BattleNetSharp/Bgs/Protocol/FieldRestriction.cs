using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000363 RID: 867
	public sealed class FieldRestriction : IMessage<FieldRestriction>, IMessage, IEquatable<FieldRestriction>, IDeepCloneable<FieldRestriction>, IBufferMessage
	{
		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x00159898 File Offset: 0x00157A98
		[DebuggerNonUserCode]
		public static MessageParser<FieldRestriction> Parser
		{
			get
			{
				return FieldRestriction._parser;
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x001598B0 File Offset: 0x00157AB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x001598D4 File Offset: 0x00157AD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldRestriction.Descriptor;
			}
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x001598EB File Offset: 0x00157AEB
		[DebuggerNonUserCode]
		public FieldRestriction()
		{
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x001598FC File Offset: 0x00157AFC
		[DebuggerNonUserCode]
		public FieldRestriction(FieldRestriction other)
			: this()
		{
			switch (other.TypeCase)
			{
			case FieldRestriction.TypeOneofCase.Signed:
				this.Signed = other.Signed.Clone();
				break;
			case FieldRestriction.TypeOneofCase.Unsigned:
				this.Unsigned = other.Unsigned.Clone();
				break;
			case FieldRestriction.TypeOneofCase.Float:
				this.Float = other.Float.Clone();
				break;
			case FieldRestriction.TypeOneofCase.String:
				this.String = other.String.Clone();
				break;
			case FieldRestriction.TypeOneofCase.Repeated:
				this.Repeated = other.Repeated.Clone();
				break;
			case FieldRestriction.TypeOneofCase.Message:
				this.Message = other.Message.Clone();
				break;
			case FieldRestriction.TypeOneofCase.EntityId:
				this.EntityId = other.EntityId.Clone();
				break;
			case FieldRestriction.TypeOneofCase.Bytes:
				this.Bytes = other.Bytes.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x001599FC File Offset: 0x00157BFC
		[DebuggerNonUserCode]
		public FieldRestriction Clone()
		{
			return new FieldRestriction(this);
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x00159A14 File Offset: 0x00157C14
		// (set) Token: 0x06005960 RID: 22880 RVA: 0x00159A3D File Offset: 0x00157C3D
		[DebuggerNonUserCode]
		public SignedFieldRestriction Signed
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Signed) ? ((SignedFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Signed);
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x00159A54 File Offset: 0x00157C54
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x00159A7D File Offset: 0x00157C7D
		[DebuggerNonUserCode]
		public UnsignedFieldRestriction Unsigned
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Unsigned) ? ((UnsignedFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Unsigned);
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x00159A94 File Offset: 0x00157C94
		// (set) Token: 0x06005964 RID: 22884 RVA: 0x00159ABD File Offset: 0x00157CBD
		[DebuggerNonUserCode]
		public FloatFieldRestriction Float
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Float) ? ((FloatFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Float);
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x00159AD4 File Offset: 0x00157CD4
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x00159AFD File Offset: 0x00157CFD
		[DebuggerNonUserCode]
		public StringFieldRestriction String
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.String) ? ((StringFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.String);
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x00159B14 File Offset: 0x00157D14
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x00159B3D File Offset: 0x00157D3D
		[DebuggerNonUserCode]
		public RepeatedFieldRestriction Repeated
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Repeated) ? ((RepeatedFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Repeated);
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x00159B54 File Offset: 0x00157D54
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x00159B7D File Offset: 0x00157D7D
		[DebuggerNonUserCode]
		public MessageFieldRestriction Message
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Message) ? ((MessageFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Message);
			}
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x00159B94 File Offset: 0x00157D94
		// (set) Token: 0x0600596C RID: 22892 RVA: 0x00159BBD File Offset: 0x00157DBD
		[DebuggerNonUserCode]
		public EntityIdRestriction EntityId
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.EntityId) ? ((EntityIdRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.EntityId);
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x0600596D RID: 22893 RVA: 0x00159BD4 File Offset: 0x00157DD4
		// (set) Token: 0x0600596E RID: 22894 RVA: 0x00159BFD File Offset: 0x00157DFD
		[DebuggerNonUserCode]
		public StringFieldRestriction Bytes
		{
			get
			{
				return (this.typeCase_ == FieldRestriction.TypeOneofCase.Bytes) ? ((StringFieldRestriction)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? FieldRestriction.TypeOneofCase.None : FieldRestriction.TypeOneofCase.Bytes);
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x00159C14 File Offset: 0x00157E14
		[DebuggerNonUserCode]
		public FieldRestriction.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00159C2C File Offset: 0x00157E2C
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = FieldRestriction.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00159C40 File Offset: 0x00157E40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldRestriction);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00159C60 File Offset: 0x00157E60
		[DebuggerNonUserCode]
		public bool Equals(FieldRestriction other)
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
					bool flag4 = !object.Equals(this.Signed, other.Signed);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Unsigned, other.Unsigned);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Float, other.Float);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.String, other.String);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Repeated, other.Repeated);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Message, other.Message);
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

		// Token: 0x06005973 RID: 22899 RVA: 0x00159DBC File Offset: 0x00157FBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.typeCase_ == FieldRestriction.TypeOneofCase.Signed;
			if (flag)
			{
				num ^= this.Signed.GetHashCode();
			}
			bool flag2 = this.typeCase_ == FieldRestriction.TypeOneofCase.Unsigned;
			if (flag2)
			{
				num ^= this.Unsigned.GetHashCode();
			}
			bool flag3 = this.typeCase_ == FieldRestriction.TypeOneofCase.Float;
			if (flag3)
			{
				num ^= this.Float.GetHashCode();
			}
			bool flag4 = this.typeCase_ == FieldRestriction.TypeOneofCase.String;
			if (flag4)
			{
				num ^= this.String.GetHashCode();
			}
			bool flag5 = this.typeCase_ == FieldRestriction.TypeOneofCase.Repeated;
			if (flag5)
			{
				num ^= this.Repeated.GetHashCode();
			}
			bool flag6 = this.typeCase_ == FieldRestriction.TypeOneofCase.Message;
			if (flag6)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag7 = this.typeCase_ == FieldRestriction.TypeOneofCase.EntityId;
			if (flag7)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool flag8 = this.typeCase_ == FieldRestriction.TypeOneofCase.Bytes;
			if (flag8)
			{
				num ^= this.Bytes.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00159EE0 File Offset: 0x001580E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00159EF8 File Offset: 0x001580F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00159F04 File Offset: 0x00158104
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.typeCase_ == FieldRestriction.TypeOneofCase.Signed;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Signed);
			}
			bool flag2 = this.typeCase_ == FieldRestriction.TypeOneofCase.Unsigned;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Unsigned);
			}
			bool flag3 = this.typeCase_ == FieldRestriction.TypeOneofCase.Float;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Float);
			}
			bool flag4 = this.typeCase_ == FieldRestriction.TypeOneofCase.String;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.String);
			}
			bool flag5 = this.typeCase_ == FieldRestriction.TypeOneofCase.Repeated;
			if (flag5)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Repeated);
			}
			bool flag6 = this.typeCase_ == FieldRestriction.TypeOneofCase.Message;
			if (flag6)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Message);
			}
			bool flag7 = this.typeCase_ == FieldRestriction.TypeOneofCase.EntityId;
			if (flag7)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EntityId);
			}
			bool flag8 = this.typeCase_ == FieldRestriction.TypeOneofCase.Bytes;
			if (flag8)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Bytes);
			}
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x0015A060 File Offset: 0x00158260
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.typeCase_ == FieldRestriction.TypeOneofCase.Signed;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Signed);
			}
			bool flag2 = this.typeCase_ == FieldRestriction.TypeOneofCase.Unsigned;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Unsigned);
			}
			bool flag3 = this.typeCase_ == FieldRestriction.TypeOneofCase.Float;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Float);
			}
			bool flag4 = this.typeCase_ == FieldRestriction.TypeOneofCase.String;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.String);
			}
			bool flag5 = this.typeCase_ == FieldRestriction.TypeOneofCase.Repeated;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Repeated);
			}
			bool flag6 = this.typeCase_ == FieldRestriction.TypeOneofCase.Message;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag7 = this.typeCase_ == FieldRestriction.TypeOneofCase.EntityId;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool flag8 = this.typeCase_ == FieldRestriction.TypeOneofCase.Bytes;
			if (flag8)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Bytes);
			}
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x0015A198 File Offset: 0x00158398
		[DebuggerNonUserCode]
		public void MergeFrom(FieldRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				switch (other.TypeCase)
				{
				case FieldRestriction.TypeOneofCase.Signed:
				{
					bool flag2 = this.Signed == null;
					if (flag2)
					{
						this.Signed = new SignedFieldRestriction();
					}
					this.Signed.MergeFrom(other.Signed);
					break;
				}
				case FieldRestriction.TypeOneofCase.Unsigned:
				{
					bool flag3 = this.Unsigned == null;
					if (flag3)
					{
						this.Unsigned = new UnsignedFieldRestriction();
					}
					this.Unsigned.MergeFrom(other.Unsigned);
					break;
				}
				case FieldRestriction.TypeOneofCase.Float:
				{
					bool flag4 = this.Float == null;
					if (flag4)
					{
						this.Float = new FloatFieldRestriction();
					}
					this.Float.MergeFrom(other.Float);
					break;
				}
				case FieldRestriction.TypeOneofCase.String:
				{
					bool flag5 = this.String == null;
					if (flag5)
					{
						this.String = new StringFieldRestriction();
					}
					this.String.MergeFrom(other.String);
					break;
				}
				case FieldRestriction.TypeOneofCase.Repeated:
				{
					bool flag6 = this.Repeated == null;
					if (flag6)
					{
						this.Repeated = new RepeatedFieldRestriction();
					}
					this.Repeated.MergeFrom(other.Repeated);
					break;
				}
				case FieldRestriction.TypeOneofCase.Message:
				{
					bool flag7 = this.Message == null;
					if (flag7)
					{
						this.Message = new MessageFieldRestriction();
					}
					this.Message.MergeFrom(other.Message);
					break;
				}
				case FieldRestriction.TypeOneofCase.EntityId:
				{
					bool flag8 = this.EntityId == null;
					if (flag8)
					{
						this.EntityId = new EntityIdRestriction();
					}
					this.EntityId.MergeFrom(other.EntityId);
					break;
				}
				case FieldRestriction.TypeOneofCase.Bytes:
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

		// Token: 0x06005979 RID: 22905 RVA: 0x0015A396 File Offset: 0x00158596
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x0015A3A4 File Offset: 0x001585A4
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
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0067;
							}
							UnsignedFieldRestriction unsignedFieldRestriction = new UnsignedFieldRestriction();
							bool flag = this.typeCase_ == FieldRestriction.TypeOneofCase.Unsigned;
							if (flag)
							{
								unsignedFieldRestriction.MergeFrom(this.Unsigned);
							}
							input.ReadMessage(unsignedFieldRestriction);
							this.Unsigned = unsignedFieldRestriction;
						}
						else
						{
							SignedFieldRestriction signedFieldRestriction = new SignedFieldRestriction();
							bool flag2 = this.typeCase_ == FieldRestriction.TypeOneofCase.Signed;
							if (flag2)
							{
								signedFieldRestriction.MergeFrom(this.Signed);
							}
							input.ReadMessage(signedFieldRestriction);
							this.Signed = signedFieldRestriction;
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0067;
						}
						StringFieldRestriction stringFieldRestriction = new StringFieldRestriction();
						bool flag3 = this.typeCase_ == FieldRestriction.TypeOneofCase.String;
						if (flag3)
						{
							stringFieldRestriction.MergeFrom(this.String);
						}
						input.ReadMessage(stringFieldRestriction);
						this.String = stringFieldRestriction;
					}
					else
					{
						FloatFieldRestriction floatFieldRestriction = new FloatFieldRestriction();
						bool flag4 = this.typeCase_ == FieldRestriction.TypeOneofCase.Float;
						if (flag4)
						{
							floatFieldRestriction.MergeFrom(this.Float);
						}
						input.ReadMessage(floatFieldRestriction);
						this.Float = floatFieldRestriction;
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
						MessageFieldRestriction messageFieldRestriction = new MessageFieldRestriction();
						bool flag5 = this.typeCase_ == FieldRestriction.TypeOneofCase.Message;
						if (flag5)
						{
							messageFieldRestriction.MergeFrom(this.Message);
						}
						input.ReadMessage(messageFieldRestriction);
						this.Message = messageFieldRestriction;
					}
					else
					{
						RepeatedFieldRestriction repeatedFieldRestriction = new RepeatedFieldRestriction();
						bool flag6 = this.typeCase_ == FieldRestriction.TypeOneofCase.Repeated;
						if (flag6)
						{
							repeatedFieldRestriction.MergeFrom(this.Repeated);
						}
						input.ReadMessage(repeatedFieldRestriction);
						this.Repeated = repeatedFieldRestriction;
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_0067;
					}
					StringFieldRestriction stringFieldRestriction2 = new StringFieldRestriction();
					bool flag7 = this.typeCase_ == FieldRestriction.TypeOneofCase.Bytes;
					if (flag7)
					{
						stringFieldRestriction2.MergeFrom(this.Bytes);
					}
					input.ReadMessage(stringFieldRestriction2);
					this.Bytes = stringFieldRestriction2;
				}
				else
				{
					EntityIdRestriction entityIdRestriction = new EntityIdRestriction();
					bool flag8 = this.typeCase_ == FieldRestriction.TypeOneofCase.EntityId;
					if (flag8)
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

		// Token: 0x040028C2 RID: 10434
		private static readonly MessageParser<FieldRestriction> _parser = new MessageParser<FieldRestriction>(() => new FieldRestriction());

		// Token: 0x040028C3 RID: 10435
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C4 RID: 10436
		public const int SignedFieldNumber = 1;

		// Token: 0x040028C5 RID: 10437
		public const int UnsignedFieldNumber = 2;

		// Token: 0x040028C6 RID: 10438
		public const int FloatFieldNumber = 3;

		// Token: 0x040028C7 RID: 10439
		public const int StringFieldNumber = 4;

		// Token: 0x040028C8 RID: 10440
		public const int RepeatedFieldNumber = 5;

		// Token: 0x040028C9 RID: 10441
		public const int MessageFieldNumber = 6;

		// Token: 0x040028CA RID: 10442
		public const int EntityIdFieldNumber = 7;

		// Token: 0x040028CB RID: 10443
		public const int BytesFieldNumber = 8;

		// Token: 0x040028CC RID: 10444
		private object type_;

		// Token: 0x040028CD RID: 10445
		private FieldRestriction.TypeOneofCase typeCase_ = FieldRestriction.TypeOneofCase.None;

		// Token: 0x02000E40 RID: 3648
		public enum TypeOneofCase
		{
			// Token: 0x040095A5 RID: 38309
			None,
			// Token: 0x040095A6 RID: 38310
			Signed,
			// Token: 0x040095A7 RID: 38311
			Unsigned,
			// Token: 0x040095A8 RID: 38312
			Float,
			// Token: 0x040095A9 RID: 38313
			String,
			// Token: 0x040095AA RID: 38314
			Repeated,
			// Token: 0x040095AB RID: 38315
			Message,
			// Token: 0x040095AC RID: 38316
			EntityId,
			// Token: 0x040095AD RID: 38317
			Bytes
		}
	}
}
