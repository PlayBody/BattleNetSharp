using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F5 RID: 1269
	public sealed class CreateStreamOptions : IMessage<CreateStreamOptions>, IMessage, IEquatable<CreateStreamOptions>, IDeepCloneable<CreateStreamOptions>, IBufferMessage
	{
		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x001E2E10 File Offset: 0x001E1010
		[DebuggerNonUserCode]
		public static MessageParser<CreateStreamOptions> Parser
		{
			get
			{
				return CreateStreamOptions._parser;
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x001E2E28 File Offset: 0x001E1028
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x001E2E4C File Offset: 0x001E104C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateStreamOptions.Descriptor;
			}
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x001E2E63 File Offset: 0x001E1063
		[DebuggerNonUserCode]
		public CreateStreamOptions()
		{
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x001E2E78 File Offset: 0x001E1078
		[DebuggerNonUserCode]
		public CreateStreamOptions(CreateStreamOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.subject_ = other.subject_;
			this.access_ = ((other.access_ != null) ? other.access_.Clone() : null);
			this.voiceLevel_ = other.voiceLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x001E2EFC File Offset: 0x001E10FC
		[DebuggerNonUserCode]
		public CreateStreamOptions Clone()
		{
			return new CreateStreamOptions(this);
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x001E2F14 File Offset: 0x001E1114
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06007BFA RID: 31738 RVA: 0x001E2F2C File Offset: 0x001E112C
		// (set) Token: 0x06007BFB RID: 31739 RVA: 0x001E2F4D File Offset: 0x001E114D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CreateStreamOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x001E2F64 File Offset: 0x001E1164
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x001E2F7F File Offset: 0x001E117F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x001E2F8C File Offset: 0x001E118C
		// (set) Token: 0x06007BFF RID: 31743 RVA: 0x001E2FAD File Offset: 0x001E11AD
		[DebuggerNonUserCode]
		public string Subject
		{
			get
			{
				return this.subject_ ?? CreateStreamOptions.SubjectDefaultValue;
			}
			set
			{
				this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x06007C00 RID: 31744 RVA: 0x001E2FC4 File Offset: 0x001E11C4
		[DebuggerNonUserCode]
		public bool HasSubject
		{
			get
			{
				return this.subject_ != null;
			}
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x001E2FDF File Offset: 0x001E11DF
		[DebuggerNonUserCode]
		public void ClearSubject()
		{
			this.subject_ = null;
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x06007C02 RID: 31746 RVA: 0x001E2FEC File Offset: 0x001E11EC
		// (set) Token: 0x06007C03 RID: 31747 RVA: 0x001E3004 File Offset: 0x001E1204
		[DebuggerNonUserCode]
		public StreamAccess Access
		{
			get
			{
				return this.access_;
			}
			set
			{
				this.access_ = value;
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x001E3010 File Offset: 0x001E1210
		// (set) Token: 0x06007C05 RID: 31749 RVA: 0x001E3041 File Offset: 0x001E1241
		[DebuggerNonUserCode]
		public StreamVoiceLevel VoiceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				StreamVoiceLevel voiceLevelDefaultValue;
				if (flag)
				{
					voiceLevelDefaultValue = this.voiceLevel_;
				}
				else
				{
					voiceLevelDefaultValue = CreateStreamOptions.VoiceLevelDefaultValue;
				}
				return voiceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.voiceLevel_ = value;
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x06007C06 RID: 31750 RVA: 0x001E305C File Offset: 0x001E125C
		[DebuggerNonUserCode]
		public bool HasVoiceLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x001E3079 File Offset: 0x001E1279
		[DebuggerNonUserCode]
		public void ClearVoiceLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x001E308C File Offset: 0x001E128C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateStreamOptions);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x001E30AC File Offset: 0x001E12AC
		[DebuggerNonUserCode]
		public bool Equals(CreateStreamOptions other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Subject != other.Subject;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Access, other.Access);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.VoiceLevel != other.VoiceLevel;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x001E3180 File Offset: 0x001E1380
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				num ^= this.Subject.GetHashCode();
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				num ^= this.Access.GetHashCode();
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				num ^= this.VoiceLevel.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x001E3234 File Offset: 0x001E1434
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x001E324C File Offset: 0x001E144C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x001E3258 File Offset: 0x001E1458
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, CreateStreamOptions._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Subject);
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Access);
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.VoiceLevel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x001E3324 File Offset: 0x001E1524
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(CreateStreamOptions._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Subject);
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Access);
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VoiceLevel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x001E33E4 File Offset: 0x001E15E4
		[DebuggerNonUserCode]
		public void MergeFrom(CreateStreamOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasSubject = other.HasSubject;
				if (hasSubject)
				{
					this.Subject = other.Subject;
				}
				bool flag2 = other.access_ != null;
				if (flag2)
				{
					bool flag3 = this.access_ == null;
					if (flag3)
					{
						this.Access = new StreamAccess();
					}
					this.Access.MergeFrom(other.Access);
				}
				bool hasVoiceLevel = other.HasVoiceLevel;
				if (hasVoiceLevel)
				{
					this.VoiceLevel = other.VoiceLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x001E34B4 File Offset: 0x001E16B4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x001E34C0 File Offset: 0x001E16C0
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
							goto IL_0033;
						}
						this.Name = input.ReadString();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, CreateStreamOptions._repeated_attribute_codec);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.VoiceLevel = (StreamVoiceLevel)input.ReadEnum();
					}
					else
					{
						bool flag = this.access_ == null;
						if (flag)
						{
							this.Access = new StreamAccess();
						}
						input.ReadMessage(this.Access);
					}
				}
				else
				{
					this.Subject = input.ReadString();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003858 RID: 14424
		private static readonly MessageParser<CreateStreamOptions> _parser = new MessageParser<CreateStreamOptions>(() => new CreateStreamOptions());

		// Token: 0x04003859 RID: 14425
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400385A RID: 14426
		private int _hasBits0;

		// Token: 0x0400385B RID: 14427
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400385C RID: 14428
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400385D RID: 14429
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400385E RID: 14430
		public const int NameFieldNumber = 2;

		// Token: 0x0400385F RID: 14431
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003860 RID: 14432
		private string name_;

		// Token: 0x04003861 RID: 14433
		public const int SubjectFieldNumber = 3;

		// Token: 0x04003862 RID: 14434
		private static readonly string SubjectDefaultValue = "";

		// Token: 0x04003863 RID: 14435
		private string subject_;

		// Token: 0x04003864 RID: 14436
		public const int AccessFieldNumber = 4;

		// Token: 0x04003865 RID: 14437
		private StreamAccess access_;

		// Token: 0x04003866 RID: 14438
		public const int VoiceLevelFieldNumber = 5;

		// Token: 0x04003867 RID: 14439
		private static readonly StreamVoiceLevel VoiceLevelDefaultValue = StreamVoiceLevel.VoiceLevelDisabled;

		// Token: 0x04003868 RID: 14440
		private StreamVoiceLevel voiceLevel_;
	}
}
