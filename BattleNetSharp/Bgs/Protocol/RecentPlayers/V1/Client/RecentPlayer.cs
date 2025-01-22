using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000640 RID: 1600
	public sealed class RecentPlayer : IMessage<RecentPlayer>, IMessage, IEquatable<RecentPlayer>, IDeepCloneable<RecentPlayer>, IBufferMessage
	{
		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x060094D5 RID: 38101 RVA: 0x0024002C File Offset: 0x0023E22C
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayer> Parser
		{
			get
			{
				return RecentPlayer._parser;
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x060094D6 RID: 38102 RVA: 0x00240044 File Offset: 0x0023E244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x060094D7 RID: 38103 RVA: 0x00240068 File Offset: 0x0023E268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayer.Descriptor;
			}
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x0024007F File Offset: 0x0023E27F
		[DebuggerNonUserCode]
		public RecentPlayer()
		{
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x00240094 File Offset: 0x0023E294
		[DebuggerNonUserCode]
		public RecentPlayer(RecentPlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.program_ = other.program_;
			this.attribute_ = other.attribute_.Clone();
			this.creationTimeUs_ = other.creationTimeUs_;
			this.modifiedTimeUs_ = other.modifiedTimeUs_;
			this.counter_ = other.counter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x00240114 File Offset: 0x0023E314
		[DebuggerNonUserCode]
		public RecentPlayer Clone()
		{
			return new RecentPlayer(this);
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x060094DB RID: 38107 RVA: 0x0024012C File Offset: 0x0023E32C
		// (set) Token: 0x060094DC RID: 38108 RVA: 0x0024015D File Offset: 0x0023E35D
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = RecentPlayer.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x060094DD RID: 38109 RVA: 0x00240178 File Offset: 0x0023E378
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x00240195 File Offset: 0x0023E395
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x060094DF RID: 38111 RVA: 0x002401A8 File Offset: 0x0023E3A8
		// (set) Token: 0x060094E0 RID: 38112 RVA: 0x002401D9 File Offset: 0x0023E3D9
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = RecentPlayer.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.program_ = value;
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x060094E1 RID: 38113 RVA: 0x002401F4 File Offset: 0x0023E3F4
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x00240211 File Offset: 0x0023E411
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x060094E3 RID: 38115 RVA: 0x00240224 File Offset: 0x0023E424
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x0024023C File Offset: 0x0023E43C
		// (set) Token: 0x060094E5 RID: 38117 RVA: 0x0024026D File Offset: 0x0023E46D
		[DebuggerNonUserCode]
		public ulong CreationTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong creationTimeUsDefaultValue;
				if (flag)
				{
					creationTimeUsDefaultValue = this.creationTimeUs_;
				}
				else
				{
					creationTimeUsDefaultValue = RecentPlayer.CreationTimeUsDefaultValue;
				}
				return creationTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.creationTimeUs_ = value;
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x060094E6 RID: 38118 RVA: 0x00240288 File Offset: 0x0023E488
		[DebuggerNonUserCode]
		public bool HasCreationTimeUs
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x002402A5 File Offset: 0x0023E4A5
		[DebuggerNonUserCode]
		public void ClearCreationTimeUs()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x002402B8 File Offset: 0x0023E4B8
		// (set) Token: 0x060094E9 RID: 38121 RVA: 0x002402E9 File Offset: 0x0023E4E9
		[DebuggerNonUserCode]
		public ulong ModifiedTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong modifiedTimeUsDefaultValue;
				if (flag)
				{
					modifiedTimeUsDefaultValue = this.modifiedTimeUs_;
				}
				else
				{
					modifiedTimeUsDefaultValue = RecentPlayer.ModifiedTimeUsDefaultValue;
				}
				return modifiedTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.modifiedTimeUs_ = value;
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x060094EA RID: 38122 RVA: 0x00240304 File Offset: 0x0023E504
		[DebuggerNonUserCode]
		public bool HasModifiedTimeUs
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x00240321 File Offset: 0x0023E521
		[DebuggerNonUserCode]
		public void ClearModifiedTimeUs()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x060094EC RID: 38124 RVA: 0x00240334 File Offset: 0x0023E534
		// (set) Token: 0x060094ED RID: 38125 RVA: 0x00240366 File Offset: 0x0023E566
		[DebuggerNonUserCode]
		public ulong Counter
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong counterDefaultValue;
				if (flag)
				{
					counterDefaultValue = this.counter_;
				}
				else
				{
					counterDefaultValue = RecentPlayer.CounterDefaultValue;
				}
				return counterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.counter_ = value;
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x060094EE RID: 38126 RVA: 0x00240380 File Offset: 0x0023E580
		[DebuggerNonUserCode]
		public bool HasCounter
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x0024039E File Offset: 0x0023E59E
		[DebuggerNonUserCode]
		public void ClearCounter()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x002403B0 File Offset: 0x0023E5B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayer);
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x002403D0 File Offset: 0x0023E5D0
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayer other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CreationTimeUs != other.CreationTimeUs;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ModifiedTimeUs != other.ModifiedTimeUs;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Counter != other.Counter;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x002404BC File Offset: 0x0023E6BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				num ^= this.CreationTimeUs.GetHashCode();
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				num ^= this.ModifiedTimeUs.GetHashCode();
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				num ^= this.Counter.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00240590 File Offset: 0x0023E790
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x002405A8 File Offset: 0x0023E7A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x002405B4 File Offset: 0x0023E7B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			this.attribute_.WriteTo(ref output, RecentPlayer._repeated_attribute_codec);
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTimeUs);
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.ModifiedTimeUs);
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.Counter);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x002406A0 File Offset: 0x0023E8A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			num += this.attribute_.CalculateSize(RecentPlayer._repeated_attribute_codec);
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeUs);
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ModifiedTimeUs);
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Counter);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x00240770 File Offset: 0x0023E970
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTimeUs = other.HasCreationTimeUs;
				if (hasCreationTimeUs)
				{
					this.CreationTimeUs = other.CreationTimeUs;
				}
				bool hasModifiedTimeUs = other.HasModifiedTimeUs;
				if (hasModifiedTimeUs)
				{
					this.ModifiedTimeUs = other.ModifiedTimeUs;
				}
				bool hasCounter = other.HasCounter;
				if (hasCounter)
				{
					this.Counter = other.Counter;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00240836 File Offset: 0x0023EA36
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x00240844 File Offset: 0x0023EA44
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							if (num3 != 34U)
							{
								goto IL_0039;
							}
							this.attribute_.AddEntriesFrom(ref input, RecentPlayer._repeated_attribute_codec);
						}
						else
						{
							this.Program = input.ReadFixed32();
						}
					}
					else
					{
						this.Id = input.ReadUInt64();
					}
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_0039;
						}
						this.Counter = input.ReadUInt64();
					}
					else
					{
						this.ModifiedTimeUs = input.ReadUInt64();
					}
				}
				else
				{
					this.CreationTimeUs = input.ReadUInt64();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004309 RID: 17161
		private static readonly MessageParser<RecentPlayer> _parser = new MessageParser<RecentPlayer>(() => new RecentPlayer());

		// Token: 0x0400430A RID: 17162
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400430B RID: 17163
		private int _hasBits0;

		// Token: 0x0400430C RID: 17164
		public const int IdFieldNumber = 1;

		// Token: 0x0400430D RID: 17165
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x0400430E RID: 17166
		private ulong id_;

		// Token: 0x0400430F RID: 17167
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004310 RID: 17168
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004311 RID: 17169
		private uint program_;

		// Token: 0x04004312 RID: 17170
		public const int AttributeFieldNumber = 4;

		// Token: 0x04004313 RID: 17171
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004314 RID: 17172
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04004315 RID: 17173
		public const int CreationTimeUsFieldNumber = 5;

		// Token: 0x04004316 RID: 17174
		private static readonly ulong CreationTimeUsDefaultValue = 0UL;

		// Token: 0x04004317 RID: 17175
		private ulong creationTimeUs_;

		// Token: 0x04004318 RID: 17176
		public const int ModifiedTimeUsFieldNumber = 6;

		// Token: 0x04004319 RID: 17177
		private static readonly ulong ModifiedTimeUsDefaultValue = 0UL;

		// Token: 0x0400431A RID: 17178
		private ulong modifiedTimeUs_;

		// Token: 0x0400431B RID: 17179
		public const int CounterFieldNumber = 7;

		// Token: 0x0400431C RID: 17180
		private static readonly ulong CounterDefaultValue = 0UL;

		// Token: 0x0400431D RID: 17181
		private ulong counter_;
	}
}
