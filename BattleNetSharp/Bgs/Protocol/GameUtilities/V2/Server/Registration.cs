using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005FB RID: 1531
	public sealed class Registration : IMessage<Registration>, IMessage, IEquatable<Registration>, IDeepCloneable<Registration>, IBufferMessage
	{
		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06008F68 RID: 36712 RVA: 0x0022CADC File Offset: 0x0022ACDC
		[DebuggerNonUserCode]
		public static MessageParser<Registration> Parser
		{
			get
			{
				return Registration._parser;
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x0022CAF4 File Offset: 0x0022ACF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x06008F6A RID: 36714 RVA: 0x0022CB18 File Offset: 0x0022AD18
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Registration.Descriptor;
			}
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x0022CB2F File Offset: 0x0022AD2F
		[DebuggerNonUserCode]
		public Registration()
		{
		}

		// Token: 0x06008F6C RID: 36716 RVA: 0x0022CB44 File Offset: 0x0022AD44
		[DebuggerNonUserCode]
		public Registration(Registration other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.registrationId_ = other.registrationId_;
			this.attribute_ = other.attribute_.Clone();
			this.creationTimeS_ = other.creationTimeS_;
			this.modifiedTimeS_ = other.modifiedTimeS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x0022CBAC File Offset: 0x0022ADAC
		[DebuggerNonUserCode]
		public Registration Clone()
		{
			return new Registration(this);
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x06008F6E RID: 36718 RVA: 0x0022CBC4 File Offset: 0x0022ADC4
		// (set) Token: 0x06008F6F RID: 36719 RVA: 0x0022CBE5 File Offset: 0x0022ADE5
		[DebuggerNonUserCode]
		public string RegistrationId
		{
			get
			{
				return this.registrationId_ ?? Registration.RegistrationIdDefaultValue;
			}
			set
			{
				this.registrationId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0022CBFC File Offset: 0x0022ADFC
		[DebuggerNonUserCode]
		public bool HasRegistrationId
		{
			get
			{
				return this.registrationId_ != null;
			}
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x0022CC17 File Offset: 0x0022AE17
		[DebuggerNonUserCode]
		public void ClearRegistrationId()
		{
			this.registrationId_ = null;
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06008F72 RID: 36722 RVA: 0x0022CC24 File Offset: 0x0022AE24
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x06008F73 RID: 36723 RVA: 0x0022CC3C File Offset: 0x0022AE3C
		// (set) Token: 0x06008F74 RID: 36724 RVA: 0x0022CC6D File Offset: 0x0022AE6D
		[DebuggerNonUserCode]
		public ulong CreationTimeS
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeSDefaultValue;
				if (flag)
				{
					creationTimeSDefaultValue = this.creationTimeS_;
				}
				else
				{
					creationTimeSDefaultValue = Registration.CreationTimeSDefaultValue;
				}
				return creationTimeSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTimeS_ = value;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x06008F75 RID: 36725 RVA: 0x0022CC88 File Offset: 0x0022AE88
		[DebuggerNonUserCode]
		public bool HasCreationTimeS
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0022CCA5 File Offset: 0x0022AEA5
		[DebuggerNonUserCode]
		public void ClearCreationTimeS()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x06008F77 RID: 36727 RVA: 0x0022CCB8 File Offset: 0x0022AEB8
		// (set) Token: 0x06008F78 RID: 36728 RVA: 0x0022CCE9 File Offset: 0x0022AEE9
		[DebuggerNonUserCode]
		public ulong ModifiedTimeS
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong modifiedTimeSDefaultValue;
				if (flag)
				{
					modifiedTimeSDefaultValue = this.modifiedTimeS_;
				}
				else
				{
					modifiedTimeSDefaultValue = Registration.ModifiedTimeSDefaultValue;
				}
				return modifiedTimeSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.modifiedTimeS_ = value;
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x06008F79 RID: 36729 RVA: 0x0022CD04 File Offset: 0x0022AF04
		[DebuggerNonUserCode]
		public bool HasModifiedTimeS
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x0022CD21 File Offset: 0x0022AF21
		[DebuggerNonUserCode]
		public void ClearModifiedTimeS()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x0022CD34 File Offset: 0x0022AF34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Registration);
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x0022CD54 File Offset: 0x0022AF54
		[DebuggerNonUserCode]
		public bool Equals(Registration other)
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
					bool flag4 = this.RegistrationId != other.RegistrationId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreationTimeS != other.CreationTimeS;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ModifiedTimeS != other.ModifiedTimeS;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x0022CE04 File Offset: 0x0022B004
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRegistrationId = this.HasRegistrationId;
			if (hasRegistrationId)
			{
				num ^= this.RegistrationId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTimeS = this.HasCreationTimeS;
			if (hasCreationTimeS)
			{
				num ^= this.CreationTimeS.GetHashCode();
			}
			bool hasModifiedTimeS = this.HasModifiedTimeS;
			if (hasModifiedTimeS)
			{
				num ^= this.ModifiedTimeS.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x0022CE98 File Offset: 0x0022B098
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x0022CEB0 File Offset: 0x0022B0B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x0022CEBC File Offset: 0x0022B0BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRegistrationId = this.HasRegistrationId;
			if (hasRegistrationId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.RegistrationId);
			}
			this.attribute_.WriteTo(ref output, Registration._repeated_attribute_codec);
			bool hasCreationTimeS = this.HasCreationTimeS;
			if (hasCreationTimeS)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CreationTimeS);
			}
			bool hasModifiedTimeS = this.HasModifiedTimeS;
			if (hasModifiedTimeS)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ModifiedTimeS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x0022CF60 File Offset: 0x0022B160
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRegistrationId = this.HasRegistrationId;
			if (hasRegistrationId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RegistrationId);
			}
			num += this.attribute_.CalculateSize(Registration._repeated_attribute_codec);
			bool hasCreationTimeS = this.HasCreationTimeS;
			if (hasCreationTimeS)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeS);
			}
			bool hasModifiedTimeS = this.HasModifiedTimeS;
			if (hasModifiedTimeS)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ModifiedTimeS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x0022D000 File Offset: 0x0022B200
		[DebuggerNonUserCode]
		public void MergeFrom(Registration other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRegistrationId = other.HasRegistrationId;
				if (hasRegistrationId)
				{
					this.RegistrationId = other.RegistrationId;
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTimeS = other.HasCreationTimeS;
				if (hasCreationTimeS)
				{
					this.CreationTimeS = other.CreationTimeS;
				}
				bool hasModifiedTimeS = other.HasModifiedTimeS;
				if (hasModifiedTimeS)
				{
					this.ModifiedTimeS = other.ModifiedTimeS;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x0022D08D File Offset: 0x0022B28D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x0022D098 File Offset: 0x0022B298
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
							goto IL_002C;
						}
						this.attribute_.AddEntriesFrom(ref input, Registration._repeated_attribute_codec);
					}
					else
					{
						this.RegistrationId = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.ModifiedTimeS = input.ReadUInt64();
				}
				else
				{
					this.CreationTimeS = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040040C9 RID: 16585
		private static readonly MessageParser<Registration> _parser = new MessageParser<Registration>(() => new Registration());

		// Token: 0x040040CA RID: 16586
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040CB RID: 16587
		private int _hasBits0;

		// Token: 0x040040CC RID: 16588
		public const int RegistrationIdFieldNumber = 1;

		// Token: 0x040040CD RID: 16589
		private static readonly string RegistrationIdDefaultValue = "";

		// Token: 0x040040CE RID: 16590
		private string registrationId_;

		// Token: 0x040040CF RID: 16591
		public const int AttributeFieldNumber = 2;

		// Token: 0x040040D0 RID: 16592
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040040D1 RID: 16593
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x040040D2 RID: 16594
		public const int CreationTimeSFieldNumber = 3;

		// Token: 0x040040D3 RID: 16595
		private static readonly ulong CreationTimeSDefaultValue = 0UL;

		// Token: 0x040040D4 RID: 16596
		private ulong creationTimeS_;

		// Token: 0x040040D5 RID: 16597
		public const int ModifiedTimeSFieldNumber = 4;

		// Token: 0x040040D6 RID: 16598
		private static readonly ulong ModifiedTimeSDefaultValue = 0UL;

		// Token: 0x040040D7 RID: 16599
		private ulong modifiedTimeS_;
	}
}
