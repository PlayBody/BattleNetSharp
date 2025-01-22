using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000502 RID: 1282
	public sealed class StreamStateOptions : IMessage<StreamStateOptions>, IMessage, IEquatable<StreamStateOptions>, IDeepCloneable<StreamStateOptions>, IBufferMessage
	{
		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x001E86C0 File Offset: 0x001E68C0
		[DebuggerNonUserCode]
		public static MessageParser<StreamStateOptions> Parser
		{
			get
			{
				return StreamStateOptions._parser;
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x001E86D8 File Offset: 0x001E68D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x06007D6B RID: 32107 RVA: 0x001E86FC File Offset: 0x001E68FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamStateOptions.Descriptor;
			}
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x001E8713 File Offset: 0x001E6913
		[DebuggerNonUserCode]
		public StreamStateOptions()
		{
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x001E8728 File Offset: 0x001E6928
		[DebuggerNonUserCode]
		public StreamStateOptions(StreamStateOptions other)
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

		// Token: 0x06007D6E RID: 32110 RVA: 0x001E87AC File Offset: 0x001E69AC
		[DebuggerNonUserCode]
		public StreamStateOptions Clone()
		{
			return new StreamStateOptions(this);
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x001E87C4 File Offset: 0x001E69C4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x06007D70 RID: 32112 RVA: 0x001E87DC File Offset: 0x001E69DC
		// (set) Token: 0x06007D71 RID: 32113 RVA: 0x001E87FD File Offset: 0x001E69FD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? StreamStateOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x001E8814 File Offset: 0x001E6A14
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x001E882F File Offset: 0x001E6A2F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x06007D74 RID: 32116 RVA: 0x001E883C File Offset: 0x001E6A3C
		// (set) Token: 0x06007D75 RID: 32117 RVA: 0x001E885D File Offset: 0x001E6A5D
		[DebuggerNonUserCode]
		public string Subject
		{
			get
			{
				return this.subject_ ?? StreamStateOptions.SubjectDefaultValue;
			}
			set
			{
				this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x06007D76 RID: 32118 RVA: 0x001E8874 File Offset: 0x001E6A74
		[DebuggerNonUserCode]
		public bool HasSubject
		{
			get
			{
				return this.subject_ != null;
			}
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x001E888F File Offset: 0x001E6A8F
		[DebuggerNonUserCode]
		public void ClearSubject()
		{
			this.subject_ = null;
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x06007D78 RID: 32120 RVA: 0x001E889C File Offset: 0x001E6A9C
		// (set) Token: 0x06007D79 RID: 32121 RVA: 0x001E88B4 File Offset: 0x001E6AB4
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

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x001E88C0 File Offset: 0x001E6AC0
		// (set) Token: 0x06007D7B RID: 32123 RVA: 0x001E88F1 File Offset: 0x001E6AF1
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
					voiceLevelDefaultValue = StreamStateOptions.VoiceLevelDefaultValue;
				}
				return voiceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.voiceLevel_ = value;
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x001E890C File Offset: 0x001E6B0C
		[DebuggerNonUserCode]
		public bool HasVoiceLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x001E8929 File Offset: 0x001E6B29
		[DebuggerNonUserCode]
		public void ClearVoiceLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x001E893C File Offset: 0x001E6B3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamStateOptions);
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x001E895C File Offset: 0x001E6B5C
		[DebuggerNonUserCode]
		public bool Equals(StreamStateOptions other)
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

		// Token: 0x06007D80 RID: 32128 RVA: 0x001E8A30 File Offset: 0x001E6C30
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

		// Token: 0x06007D81 RID: 32129 RVA: 0x001E8AE4 File Offset: 0x001E6CE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x001E8AFC File Offset: 0x001E6CFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x001E8B08 File Offset: 0x001E6D08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, StreamStateOptions._repeated_attribute_codec);
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

		// Token: 0x06007D84 RID: 32132 RVA: 0x001E8BD4 File Offset: 0x001E6DD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(StreamStateOptions._repeated_attribute_codec);
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

		// Token: 0x06007D85 RID: 32133 RVA: 0x001E8C94 File Offset: 0x001E6E94
		[DebuggerNonUserCode]
		public void MergeFrom(StreamStateOptions other)
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

		// Token: 0x06007D86 RID: 32134 RVA: 0x001E8D64 File Offset: 0x001E6F64
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x001E8D70 File Offset: 0x001E6F70
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
						this.attribute_.AddEntriesFrom(ref input, StreamStateOptions._repeated_attribute_codec);
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

		// Token: 0x04003907 RID: 14599
		private static readonly MessageParser<StreamStateOptions> _parser = new MessageParser<StreamStateOptions>(() => new StreamStateOptions());

		// Token: 0x04003908 RID: 14600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003909 RID: 14601
		private int _hasBits0;

		// Token: 0x0400390A RID: 14602
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400390B RID: 14603
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400390C RID: 14604
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400390D RID: 14605
		public const int NameFieldNumber = 2;

		// Token: 0x0400390E RID: 14606
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400390F RID: 14607
		private string name_;

		// Token: 0x04003910 RID: 14608
		public const int SubjectFieldNumber = 3;

		// Token: 0x04003911 RID: 14609
		private static readonly string SubjectDefaultValue = "";

		// Token: 0x04003912 RID: 14610
		private string subject_;

		// Token: 0x04003913 RID: 14611
		public const int AccessFieldNumber = 4;

		// Token: 0x04003914 RID: 14612
		private StreamAccess access_;

		// Token: 0x04003915 RID: 14613
		public const int VoiceLevelFieldNumber = 5;

		// Token: 0x04003916 RID: 14614
		private static readonly StreamVoiceLevel VoiceLevelDefaultValue = StreamVoiceLevel.VoiceLevelDisabled;

		// Token: 0x04003917 RID: 14615
		private StreamVoiceLevel voiceLevel_;
	}
}
