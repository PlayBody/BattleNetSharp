using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036D RID: 877
	public sealed class BGSMessageOptions : IMessage<BGSMessageOptions>, IMessage, IEquatable<BGSMessageOptions>, IDeepCloneable<BGSMessageOptions>, IBufferMessage
	{
		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x0015CD88 File Offset: 0x0015AF88
		[DebuggerNonUserCode]
		public static MessageParser<BGSMessageOptions> Parser
		{
			get
			{
				return BGSMessageOptions._parser;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x0015CDA0 File Offset: 0x0015AFA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MessageOptionsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06005A24 RID: 23076 RVA: 0x0015CDC4 File Offset: 0x0015AFC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BGSMessageOptions.Descriptor;
			}
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x0015CDDB File Offset: 0x0015AFDB
		[DebuggerNonUserCode]
		public BGSMessageOptions()
		{
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0015CDE5 File Offset: 0x0015AFE5
		[DebuggerNonUserCode]
		public BGSMessageOptions(BGSMessageOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.customSelectShard_ = other.customSelectShard_;
			this.customValidator_ = other.customValidator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x0015CE24 File Offset: 0x0015B024
		[DebuggerNonUserCode]
		public BGSMessageOptions Clone()
		{
			return new BGSMessageOptions(this);
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06005A28 RID: 23080 RVA: 0x0015CE3C File Offset: 0x0015B03C
		// (set) Token: 0x06005A29 RID: 23081 RVA: 0x0015CE6D File Offset: 0x0015B06D
		[DebuggerNonUserCode]
		public bool CustomSelectShard
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool customSelectShardDefaultValue;
				if (flag)
				{
					customSelectShardDefaultValue = this.customSelectShard_;
				}
				else
				{
					customSelectShardDefaultValue = BGSMessageOptions.CustomSelectShardDefaultValue;
				}
				return customSelectShardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.customSelectShard_ = value;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x0015CE88 File Offset: 0x0015B088
		[DebuggerNonUserCode]
		public bool HasCustomSelectShard
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0015CEA5 File Offset: 0x0015B0A5
		[DebuggerNonUserCode]
		public void ClearCustomSelectShard()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x0015CEB8 File Offset: 0x0015B0B8
		// (set) Token: 0x06005A2D RID: 23085 RVA: 0x0015CEE9 File Offset: 0x0015B0E9
		[DebuggerNonUserCode]
		public bool CustomValidator
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool customValidatorDefaultValue;
				if (flag)
				{
					customValidatorDefaultValue = this.customValidator_;
				}
				else
				{
					customValidatorDefaultValue = BGSMessageOptions.CustomValidatorDefaultValue;
				}
				return customValidatorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.customValidator_ = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x0015CF04 File Offset: 0x0015B104
		[DebuggerNonUserCode]
		public bool HasCustomValidator
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x0015CF21 File Offset: 0x0015B121
		[DebuggerNonUserCode]
		public void ClearCustomValidator()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x0015CF34 File Offset: 0x0015B134
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BGSMessageOptions);
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x0015CF54 File Offset: 0x0015B154
		[DebuggerNonUserCode]
		public bool Equals(BGSMessageOptions other)
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
					bool flag4 = this.CustomSelectShard != other.CustomSelectShard;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CustomValidator != other.CustomValidator;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x0015CFC8 File Offset: 0x0015B1C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				num ^= this.CustomSelectShard.GetHashCode();
			}
			bool hasCustomValidator = this.HasCustomValidator;
			if (hasCustomValidator)
			{
				num ^= this.CustomValidator.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x0015D034 File Offset: 0x0015B234
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x0015D04C File Offset: 0x0015B24C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x0015D058 File Offset: 0x0015B258
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CustomSelectShard);
			}
			bool hasCustomValidator = this.HasCustomValidator;
			if (hasCustomValidator)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CustomValidator);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x0015D0C8 File Offset: 0x0015B2C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				num += 2;
			}
			bool hasCustomValidator = this.HasCustomValidator;
			if (hasCustomValidator)
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

		// Token: 0x06005A37 RID: 23095 RVA: 0x0015D11C File Offset: 0x0015B31C
		[DebuggerNonUserCode]
		public void MergeFrom(BGSMessageOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCustomSelectShard = other.HasCustomSelectShard;
				if (hasCustomSelectShard)
				{
					this.CustomSelectShard = other.CustomSelectShard;
				}
				bool hasCustomValidator = other.HasCustomValidator;
				if (hasCustomValidator)
				{
					this.CustomValidator = other.CustomValidator;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x0015D17E File Offset: 0x0015B37E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x0015D18C File Offset: 0x0015B38C
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
						this.CustomValidator = input.ReadBool();
					}
				}
				else
				{
					this.CustomSelectShard = input.ReadBool();
				}
			}
		}

		// Token: 0x0400290B RID: 10507
		private static readonly MessageParser<BGSMessageOptions> _parser = new MessageParser<BGSMessageOptions>(() => new BGSMessageOptions());

		// Token: 0x0400290C RID: 10508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400290D RID: 10509
		private int _hasBits0;

		// Token: 0x0400290E RID: 10510
		public const int CustomSelectShardFieldNumber = 1;

		// Token: 0x0400290F RID: 10511
		private static readonly bool CustomSelectShardDefaultValue = false;

		// Token: 0x04002910 RID: 10512
		private bool customSelectShard_;

		// Token: 0x04002911 RID: 10513
		public const int CustomValidatorFieldNumber = 2;

		// Token: 0x04002912 RID: 10514
		private static readonly bool CustomValidatorDefaultValue = false;

		// Token: 0x04002913 RID: 10515
		private bool customValidator_;
	}
}
