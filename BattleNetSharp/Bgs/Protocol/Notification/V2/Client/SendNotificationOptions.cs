using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005DD RID: 1501
	public sealed class SendNotificationOptions : IMessage<SendNotificationOptions>, IMessage, IEquatable<SendNotificationOptions>, IDeepCloneable<SendNotificationOptions>, IBufferMessage
	{
		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0022452C File Offset: 0x0022272C
		[DebuggerNonUserCode]
		public static MessageParser<SendNotificationOptions> Parser
		{
			get
			{
				return SendNotificationOptions._parser;
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06008D40 RID: 36160 RVA: 0x00224544 File Offset: 0x00222744
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x00224568 File Offset: 0x00222768
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendNotificationOptions.Descriptor;
			}
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x0022457F File Offset: 0x0022277F
		[DebuggerNonUserCode]
		public SendNotificationOptions()
		{
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x00224594 File Offset: 0x00222794
		[DebuggerNonUserCode]
		public SendNotificationOptions(SendNotificationOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.targetAccountId_ = other.targetAccountId_;
			this.filter_ = ((other.filter_ != null) ? other.filter_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x0022460C File Offset: 0x0022280C
		[DebuggerNonUserCode]
		public SendNotificationOptions Clone()
		{
			return new SendNotificationOptions(this);
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06008D45 RID: 36165 RVA: 0x00224624 File Offset: 0x00222824
		// (set) Token: 0x06008D46 RID: 36166 RVA: 0x00224645 File Offset: 0x00222845
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? SendNotificationOptions.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x0022465C File Offset: 0x0022285C
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00224677 File Offset: 0x00222877
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x00224684 File Offset: 0x00222884
		// (set) Token: 0x06008D4A RID: 36170 RVA: 0x002246B5 File Offset: 0x002228B5
		[DebuggerNonUserCode]
		public ulong TargetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong targetAccountIdDefaultValue;
				if (flag)
				{
					targetAccountIdDefaultValue = this.targetAccountId_;
				}
				else
				{
					targetAccountIdDefaultValue = SendNotificationOptions.TargetAccountIdDefaultValue;
				}
				return targetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetAccountId_ = value;
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x002246D0 File Offset: 0x002228D0
		[DebuggerNonUserCode]
		public bool HasTargetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x002246ED File Offset: 0x002228ED
		[DebuggerNonUserCode]
		public void ClearTargetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x06008D4D RID: 36173 RVA: 0x00224700 File Offset: 0x00222900
		// (set) Token: 0x06008D4E RID: 36174 RVA: 0x00224718 File Offset: 0x00222918
		[DebuggerNonUserCode]
		public Filter Filter
		{
			get
			{
				return this.filter_;
			}
			set
			{
				this.filter_ = value;
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06008D4F RID: 36175 RVA: 0x00224724 File Offset: 0x00222924
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x0022473C File Offset: 0x0022293C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendNotificationOptions);
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x0022475C File Offset: 0x0022295C
		[DebuggerNonUserCode]
		public bool Equals(SendNotificationOptions other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetAccountId != other.TargetAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Filter, other.Filter);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x00224810 File Offset: 0x00222A10
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasTargetAccountId = this.HasTargetAccountId;
			if (hasTargetAccountId)
			{
				num ^= this.TargetAccountId.GetHashCode();
			}
			bool flag = this.filter_ != null;
			if (flag)
			{
				num ^= this.Filter.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x002248A4 File Offset: 0x00222AA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x002248BC File Offset: 0x00222ABC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x002248C8 File Offset: 0x00222AC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			bool hasTargetAccountId = this.HasTargetAccountId;
			if (hasTargetAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.TargetAccountId);
			}
			bool flag = this.filter_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Filter);
			}
			this.attribute_.WriteTo(ref output, SendNotificationOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x00224970 File Offset: 0x00222B70
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasTargetAccountId = this.HasTargetAccountId;
			if (hasTargetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.TargetAccountId);
			}
			bool flag = this.filter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Filter);
			}
			num += this.attribute_.CalculateSize(SendNotificationOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x00224A10 File Offset: 0x00222C10
		[DebuggerNonUserCode]
		public void MergeFrom(SendNotificationOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasTargetAccountId = other.HasTargetAccountId;
				if (hasTargetAccountId)
				{
					this.TargetAccountId = other.TargetAccountId;
				}
				bool flag2 = other.filter_ != null;
				if (flag2)
				{
					bool flag3 = this.filter_ == null;
					if (flag3)
					{
						this.Filter = new Filter();
					}
					this.Filter.MergeFrom(other.Filter);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x00224AC5 File Offset: 0x00222CC5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00224AD0 File Offset: 0x00222CD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.TargetAccountId = input.ReadUInt64();
					}
					else
					{
						this.Type = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					this.attribute_.AddEntriesFrom(ref input, SendNotificationOptions._repeated_attribute_codec);
				}
				else
				{
					bool flag = this.filter_ == null;
					if (flag)
					{
						this.Filter = new Filter();
					}
					input.ReadMessage(this.Filter);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003FD7 RID: 16343
		private static readonly MessageParser<SendNotificationOptions> _parser = new MessageParser<SendNotificationOptions>(() => new SendNotificationOptions());

		// Token: 0x04003FD8 RID: 16344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FD9 RID: 16345
		private int _hasBits0;

		// Token: 0x04003FDA RID: 16346
		public const int TypeFieldNumber = 1;

		// Token: 0x04003FDB RID: 16347
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04003FDC RID: 16348
		private string type_;

		// Token: 0x04003FDD RID: 16349
		public const int TargetAccountIdFieldNumber = 2;

		// Token: 0x04003FDE RID: 16350
		private static readonly ulong TargetAccountIdDefaultValue = 0UL;

		// Token: 0x04003FDF RID: 16351
		private ulong targetAccountId_;

		// Token: 0x04003FE0 RID: 16352
		public const int FilterFieldNumber = 3;

		// Token: 0x04003FE1 RID: 16353
		private Filter filter_;

		// Token: 0x04003FE2 RID: 16354
		public const int AttributeFieldNumber = 4;

		// Token: 0x04003FE3 RID: 16355
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003FE4 RID: 16356
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
