using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000503 RID: 1283
	public sealed class StreamStateAssignment : IMessage<StreamStateAssignment>, IMessage, IEquatable<StreamStateAssignment>, IDeepCloneable<StreamStateAssignment>, IBufferMessage
	{
		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x06007D89 RID: 32137 RVA: 0x001E8EA0 File Offset: 0x001E70A0
		[DebuggerNonUserCode]
		public static MessageParser<StreamStateAssignment> Parser
		{
			get
			{
				return StreamStateAssignment._parser;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x06007D8A RID: 32138 RVA: 0x001E8EB8 File Offset: 0x001E70B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x001E8EDC File Offset: 0x001E70DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamStateAssignment.Descriptor;
			}
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x001E8EF3 File Offset: 0x001E70F3
		[DebuggerNonUserCode]
		public StreamStateAssignment()
		{
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x001E8F08 File Offset: 0x001E7108
		[DebuggerNonUserCode]
		public StreamStateAssignment(StreamStateAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.streamId_ = other.streamId_;
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.subject_ = other.subject_;
			this.access_ = ((other.access_ != null) ? other.access_.Clone() : null);
			this.streamSubscriptionRemoved_ = other.streamSubscriptionRemoved_;
			this.voiceLevel_ = other.voiceLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x001E8FA4 File Offset: 0x001E71A4
		[DebuggerNonUserCode]
		public StreamStateAssignment Clone()
		{
			return new StreamStateAssignment(this);
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x06007D8F RID: 32143 RVA: 0x001E8FBC File Offset: 0x001E71BC
		// (set) Token: 0x06007D90 RID: 32144 RVA: 0x001E8FED File Offset: 0x001E71ED
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = StreamStateAssignment.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x001E9008 File Offset: 0x001E7208
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x001E9025 File Offset: 0x001E7225
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x001E9038 File Offset: 0x001E7238
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x06007D94 RID: 32148 RVA: 0x001E9050 File Offset: 0x001E7250
		// (set) Token: 0x06007D95 RID: 32149 RVA: 0x001E9071 File Offset: 0x001E7271
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? StreamStateAssignment.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x06007D96 RID: 32150 RVA: 0x001E9088 File Offset: 0x001E7288
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007D97 RID: 32151 RVA: 0x001E90A3 File Offset: 0x001E72A3
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x06007D98 RID: 32152 RVA: 0x001E90B0 File Offset: 0x001E72B0
		// (set) Token: 0x06007D99 RID: 32153 RVA: 0x001E90D1 File Offset: 0x001E72D1
		[DebuggerNonUserCode]
		public string Subject
		{
			get
			{
				return this.subject_ ?? StreamStateAssignment.SubjectDefaultValue;
			}
			set
			{
				this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x06007D9A RID: 32154 RVA: 0x001E90E8 File Offset: 0x001E72E8
		[DebuggerNonUserCode]
		public bool HasSubject
		{
			get
			{
				return this.subject_ != null;
			}
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x001E9103 File Offset: 0x001E7303
		[DebuggerNonUserCode]
		public void ClearSubject()
		{
			this.subject_ = null;
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x06007D9C RID: 32156 RVA: 0x001E9110 File Offset: 0x001E7310
		// (set) Token: 0x06007D9D RID: 32157 RVA: 0x001E9128 File Offset: 0x001E7328
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

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x06007D9E RID: 32158 RVA: 0x001E9134 File Offset: 0x001E7334
		// (set) Token: 0x06007D9F RID: 32159 RVA: 0x001E9165 File Offset: 0x001E7365
		[DebuggerNonUserCode]
		public bool StreamSubscriptionRemoved
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool streamSubscriptionRemovedDefaultValue;
				if (flag)
				{
					streamSubscriptionRemovedDefaultValue = this.streamSubscriptionRemoved_;
				}
				else
				{
					streamSubscriptionRemovedDefaultValue = StreamStateAssignment.StreamSubscriptionRemovedDefaultValue;
				}
				return streamSubscriptionRemovedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamSubscriptionRemoved_ = value;
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x001E9180 File Offset: 0x001E7380
		[DebuggerNonUserCode]
		public bool HasStreamSubscriptionRemoved
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x001E919D File Offset: 0x001E739D
		[DebuggerNonUserCode]
		public void ClearStreamSubscriptionRemoved()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x001E91B0 File Offset: 0x001E73B0
		// (set) Token: 0x06007DA3 RID: 32163 RVA: 0x001E91E1 File Offset: 0x001E73E1
		[DebuggerNonUserCode]
		public StreamVoiceLevel VoiceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				StreamVoiceLevel voiceLevelDefaultValue;
				if (flag)
				{
					voiceLevelDefaultValue = this.voiceLevel_;
				}
				else
				{
					voiceLevelDefaultValue = StreamStateAssignment.VoiceLevelDefaultValue;
				}
				return voiceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.voiceLevel_ = value;
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x06007DA4 RID: 32164 RVA: 0x001E91FC File Offset: 0x001E73FC
		[DebuggerNonUserCode]
		public bool HasVoiceLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x001E9219 File Offset: 0x001E7419
		[DebuggerNonUserCode]
		public void ClearVoiceLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x001E922C File Offset: 0x001E742C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamStateAssignment);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x001E924C File Offset: 0x001E744C
		[DebuggerNonUserCode]
		public bool Equals(StreamStateAssignment other)
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
					bool flag4 = this.StreamId != other.StreamId;
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
							bool flag6 = this.Name != other.Name;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Subject != other.Subject;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Access, other.Access);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.StreamSubscriptionRemoved != other.StreamSubscriptionRemoved;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.VoiceLevel != other.VoiceLevel;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06007DA8 RID: 32168 RVA: 0x001E935C File Offset: 0x001E755C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
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
			bool hasStreamSubscriptionRemoved = this.HasStreamSubscriptionRemoved;
			if (hasStreamSubscriptionRemoved)
			{
				num ^= this.StreamSubscriptionRemoved.GetHashCode();
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

		// Token: 0x06007DA9 RID: 32169 RVA: 0x001E944C File Offset: 0x001E764C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x001E9464 File Offset: 0x001E7664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x001E9470 File Offset: 0x001E7670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StreamId);
			}
			this.attribute_.WriteTo(ref output, StreamStateAssignment._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Subject);
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Access);
			}
			bool hasStreamSubscriptionRemoved = this.HasStreamSubscriptionRemoved;
			if (hasStreamSubscriptionRemoved)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.StreamSubscriptionRemoved);
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.VoiceLevel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x001E9580 File Offset: 0x001E7780
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			num += this.attribute_.CalculateSize(StreamStateAssignment._repeated_attribute_codec);
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
			bool hasStreamSubscriptionRemoved = this.HasStreamSubscriptionRemoved;
			if (hasStreamSubscriptionRemoved)
			{
				num += 2;
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

		// Token: 0x06007DAD RID: 32173 RVA: 0x001E9670 File Offset: 0x001E7870
		[DebuggerNonUserCode]
		public void MergeFrom(StreamStateAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
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
				bool hasStreamSubscriptionRemoved = other.HasStreamSubscriptionRemoved;
				if (hasStreamSubscriptionRemoved)
				{
					this.StreamSubscriptionRemoved = other.StreamSubscriptionRemoved;
				}
				bool hasVoiceLevel = other.HasVoiceLevel;
				if (hasVoiceLevel)
				{
					this.VoiceLevel = other.VoiceLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x001E9776 File Offset: 0x001E7976
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x001E9784 File Offset: 0x001E7984
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_004B;
							}
							this.Name = input.ReadString();
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, StreamStateAssignment._repeated_attribute_codec);
						}
					}
					else
					{
						this.StreamId = input.ReadUInt64();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_004B;
						}
						bool flag = this.access_ == null;
						if (flag)
						{
							this.Access = new StreamAccess();
						}
						input.ReadMessage(this.Access);
					}
					else
					{
						this.Subject = input.ReadString();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_004B;
					}
					this.VoiceLevel = (StreamVoiceLevel)input.ReadEnum();
				}
				else
				{
					this.StreamSubscriptionRemoved = input.ReadBool();
				}
				continue;
				IL_004B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003918 RID: 14616
		private static readonly MessageParser<StreamStateAssignment> _parser = new MessageParser<StreamStateAssignment>(() => new StreamStateAssignment());

		// Token: 0x04003919 RID: 14617
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400391A RID: 14618
		private int _hasBits0;

		// Token: 0x0400391B RID: 14619
		public const int StreamIdFieldNumber = 1;

		// Token: 0x0400391C RID: 14620
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400391D RID: 14621
		private ulong streamId_;

		// Token: 0x0400391E RID: 14622
		public const int AttributeFieldNumber = 2;

		// Token: 0x0400391F RID: 14623
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003920 RID: 14624
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003921 RID: 14625
		public const int NameFieldNumber = 3;

		// Token: 0x04003922 RID: 14626
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003923 RID: 14627
		private string name_;

		// Token: 0x04003924 RID: 14628
		public const int SubjectFieldNumber = 4;

		// Token: 0x04003925 RID: 14629
		private static readonly string SubjectDefaultValue = "";

		// Token: 0x04003926 RID: 14630
		private string subject_;

		// Token: 0x04003927 RID: 14631
		public const int AccessFieldNumber = 5;

		// Token: 0x04003928 RID: 14632
		private StreamAccess access_;

		// Token: 0x04003929 RID: 14633
		public const int StreamSubscriptionRemovedFieldNumber = 6;

		// Token: 0x0400392A RID: 14634
		private static readonly bool StreamSubscriptionRemovedDefaultValue = false;

		// Token: 0x0400392B RID: 14635
		private bool streamSubscriptionRemoved_;

		// Token: 0x0400392C RID: 14636
		public const int VoiceLevelFieldNumber = 7;

		// Token: 0x0400392D RID: 14637
		private static readonly StreamVoiceLevel VoiceLevelDefaultValue = StreamVoiceLevel.VoiceLevelDisabled;

		// Token: 0x0400392E RID: 14638
		private StreamVoiceLevel voiceLevel_;
	}
}
