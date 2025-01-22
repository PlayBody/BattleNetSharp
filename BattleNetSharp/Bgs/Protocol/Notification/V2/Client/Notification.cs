using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005DE RID: 1502
	public sealed class Notification : IMessage<Notification>, IMessage, IEquatable<Notification>, IDeepCloneable<Notification>, IBufferMessage
	{
		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x00224BD0 File Offset: 0x00222DD0
		[DebuggerNonUserCode]
		public static MessageParser<Notification> Parser
		{
			get
			{
				return Notification._parser;
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x06008D5C RID: 36188 RVA: 0x00224BE8 File Offset: 0x00222DE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x00224C0C File Offset: 0x00222E0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Notification.Descriptor;
			}
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x00224C23 File Offset: 0x00222E23
		[DebuggerNonUserCode]
		public Notification()
		{
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x00224C38 File Offset: 0x00222E38
		[DebuggerNonUserCode]
		public Notification(Notification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.sender_ = ((other.sender_ != null) ? other.sender_.Clone() : null);
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.creationTimeMs_ = other.creationTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x00224CCC File Offset: 0x00222ECC
		[DebuggerNonUserCode]
		public Notification Clone()
		{
			return new Notification(this);
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x06008D61 RID: 36193 RVA: 0x00224CE4 File Offset: 0x00222EE4
		// (set) Token: 0x06008D62 RID: 36194 RVA: 0x00224D05 File Offset: 0x00222F05
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? Notification.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x06008D63 RID: 36195 RVA: 0x00224D1C File Offset: 0x00222F1C
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x00224D37 File Offset: 0x00222F37
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x00224D44 File Offset: 0x00222F44
		// (set) Token: 0x06008D66 RID: 36198 RVA: 0x00224D5C File Offset: 0x00222F5C
		[DebuggerNonUserCode]
		public UserDescription Sender
		{
			get
			{
				return this.sender_;
			}
			set
			{
				this.sender_ = value;
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x06008D67 RID: 36199 RVA: 0x00224D68 File Offset: 0x00222F68
		// (set) Token: 0x06008D68 RID: 36200 RVA: 0x00224D80 File Offset: 0x00222F80
		[DebuggerNonUserCode]
		public UserDescription Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x00224D8C File Offset: 0x00222F8C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x06008D6A RID: 36202 RVA: 0x00224DA4 File Offset: 0x00222FA4
		// (set) Token: 0x06008D6B RID: 36203 RVA: 0x00224DD5 File Offset: 0x00222FD5
		[DebuggerNonUserCode]
		public ulong CreationTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeMsDefaultValue;
				if (flag)
				{
					creationTimeMsDefaultValue = this.creationTimeMs_;
				}
				else
				{
					creationTimeMsDefaultValue = Notification.CreationTimeMsDefaultValue;
				}
				return creationTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTimeMs_ = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x00224DF0 File Offset: 0x00222FF0
		[DebuggerNonUserCode]
		public bool HasCreationTimeMs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x00224E0D File Offset: 0x0022300D
		[DebuggerNonUserCode]
		public void ClearCreationTimeMs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x00224E20 File Offset: 0x00223020
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Notification);
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x00224E40 File Offset: 0x00223040
		[DebuggerNonUserCode]
		public bool Equals(Notification other)
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
						bool flag5 = !object.Equals(this.Sender, other.Sender);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Target, other.Target);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CreationTimeMs != other.CreationTimeMs;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x00224F14 File Offset: 0x00223114
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag = this.sender_ != null;
			if (flag)
			{
				num ^= this.Sender.GetHashCode();
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				num ^= this.Target.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num ^= this.CreationTimeMs.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x00224FC4 File Offset: 0x002231C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x00224FDC File Offset: 0x002231DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x00224FE8 File Offset: 0x002231E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			bool flag = this.sender_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Sender);
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Target);
			}
			this.attribute_.WriteTo(ref output, Notification._repeated_attribute_codec);
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTimeMs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x002250B4 File Offset: 0x002232B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool flag = this.sender_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Sender);
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			num += this.attribute_.CalculateSize(Notification._repeated_attribute_codec);
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeMs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x00225178 File Offset: 0x00223378
		[DebuggerNonUserCode]
		public void MergeFrom(Notification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool flag2 = other.sender_ != null;
				if (flag2)
				{
					bool flag3 = this.sender_ == null;
					if (flag3)
					{
						this.Sender = new UserDescription();
					}
					this.Sender.MergeFrom(other.Sender);
				}
				bool flag4 = other.target_ != null;
				if (flag4)
				{
					bool flag5 = this.target_ == null;
					if (flag5)
					{
						this.Target = new UserDescription();
					}
					this.Target.MergeFrom(other.Target);
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTimeMs = other.HasCreationTimeMs;
				if (hasCreationTimeMs)
				{
					this.CreationTimeMs = other.CreationTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x0022526D File Offset: 0x0022346D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x00225278 File Offset: 0x00223478
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0039;
						}
						bool flag = this.sender_ == null;
						if (flag)
						{
							this.Sender = new UserDescription();
						}
						input.ReadMessage(this.Sender);
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
						if (num3 != 40U)
						{
							goto IL_0039;
						}
						this.CreationTimeMs = input.ReadUInt64();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, Notification._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag2 = this.target_ == null;
					if (flag2)
					{
						this.Target = new UserDescription();
					}
					input.ReadMessage(this.Target);
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003FE5 RID: 16357
		private static readonly MessageParser<Notification> _parser = new MessageParser<Notification>(() => new Notification());

		// Token: 0x04003FE6 RID: 16358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE7 RID: 16359
		private int _hasBits0;

		// Token: 0x04003FE8 RID: 16360
		public const int TypeFieldNumber = 1;

		// Token: 0x04003FE9 RID: 16361
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04003FEA RID: 16362
		private string type_;

		// Token: 0x04003FEB RID: 16363
		public const int SenderFieldNumber = 2;

		// Token: 0x04003FEC RID: 16364
		private UserDescription sender_;

		// Token: 0x04003FED RID: 16365
		public const int TargetFieldNumber = 3;

		// Token: 0x04003FEE RID: 16366
		private UserDescription target_;

		// Token: 0x04003FEF RID: 16367
		public const int AttributeFieldNumber = 4;

		// Token: 0x04003FF0 RID: 16368
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003FF1 RID: 16369
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003FF2 RID: 16370
		public const int CreationTimeMsFieldNumber = 5;

		// Token: 0x04003FF3 RID: 16371
		private static readonly ulong CreationTimeMsDefaultValue = 0UL;

		// Token: 0x04003FF4 RID: 16372
		private ulong creationTimeMs_;
	}
}
