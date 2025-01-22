using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041D RID: 1053
	public sealed class SentInvitation : IMessage<SentInvitation>, IMessage, IEquatable<SentInvitation>, IDeepCloneable<SentInvitation>, IBufferMessage
	{
		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x00191FCC File Offset: 0x001901CC
		[DebuggerNonUserCode]
		public static MessageParser<SentInvitation> Parser
		{
			get
			{
				return SentInvitation._parser;
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x00191FE4 File Offset: 0x001901E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x060067CF RID: 26575 RVA: 0x00192008 File Offset: 0x00190208
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SentInvitation.Descriptor;
			}
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0019201F File Offset: 0x0019021F
		[DebuggerNonUserCode]
		public SentInvitation()
		{
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x00192034 File Offset: 0x00190234
		[DebuggerNonUserCode]
		public SentInvitation(SentInvitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.targetName_ = other.targetName_;
			this.role_ = other.role_;
			this.attribute_ = other.attribute_.Clone();
			this.creationTime_ = other.creationTime_;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x001920B4 File Offset: 0x001902B4
		[DebuggerNonUserCode]
		public SentInvitation Clone()
		{
			return new SentInvitation(this);
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x001920CC File Offset: 0x001902CC
		// (set) Token: 0x060067D4 RID: 26580 RVA: 0x001920FD File Offset: 0x001902FD
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
					idDefaultValue = SentInvitation.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x00192118 File Offset: 0x00190318
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00192135 File Offset: 0x00190335
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x060067D7 RID: 26583 RVA: 0x00192148 File Offset: 0x00190348
		// (set) Token: 0x060067D8 RID: 26584 RVA: 0x00192169 File Offset: 0x00190369
		[DebuggerNonUserCode]
		public string TargetName
		{
			get
			{
				return this.targetName_ ?? SentInvitation.TargetNameDefaultValue;
			}
			set
			{
				this.targetName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x00192180 File Offset: 0x00190380
		[DebuggerNonUserCode]
		public bool HasTargetName
		{
			get
			{
				return this.targetName_ != null;
			}
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x0019219B File Offset: 0x0019039B
		[DebuggerNonUserCode]
		public void ClearTargetName()
		{
			this.targetName_ = null;
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x001921A8 File Offset: 0x001903A8
		// (set) Token: 0x060067DC RID: 26588 RVA: 0x001921D9 File Offset: 0x001903D9
		[DebuggerNonUserCode]
		public uint Role
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint roleDefaultValue;
				if (flag)
				{
					roleDefaultValue = this.role_;
				}
				else
				{
					roleDefaultValue = SentInvitation.RoleDefaultValue;
				}
				return roleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.role_ = value;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x001921F4 File Offset: 0x001903F4
		[DebuggerNonUserCode]
		public bool HasRole
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00192211 File Offset: 0x00190411
		[DebuggerNonUserCode]
		public void ClearRole()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x00192224 File Offset: 0x00190424
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0019223C File Offset: 0x0019043C
		// (set) Token: 0x060067E1 RID: 26593 RVA: 0x0019226D File Offset: 0x0019046D
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = SentInvitation.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.creationTime_ = value;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x00192288 File Offset: 0x00190488
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x001922A5 File Offset: 0x001904A5
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x001922B8 File Offset: 0x001904B8
		// (set) Token: 0x060067E5 RID: 26597 RVA: 0x001922E9 File Offset: 0x001904E9
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = SentInvitation.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.program_ = value;
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x00192304 File Offset: 0x00190504
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00192321 File Offset: 0x00190521
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00192334 File Offset: 0x00190534
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SentInvitation);
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00192354 File Offset: 0x00190554
		[DebuggerNonUserCode]
		public bool Equals(SentInvitation other)
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
						bool flag5 = this.TargetName != other.TargetName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Role != other.Role;
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
									bool flag8 = this.CreationTime != other.CreationTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Program != other.Program;
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

		// Token: 0x060067EA RID: 26602 RVA: 0x00192440 File Offset: 0x00190640
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				num ^= this.TargetName.GetHashCode();
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num ^= this.Role.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00192510 File Offset: 0x00190710
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x00192528 File Offset: 0x00190728
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x00192534 File Offset: 0x00190734
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Id);
			}
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TargetName);
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Role);
			}
			this.attribute_.WriteTo(ref output, SentInvitation._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(53);
				output.WriteFixed32(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00192620 File Offset: 0x00190820
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 9;
			}
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetName);
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
			}
			num += this.attribute_.CalculateSize(SentInvitation._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x001926E4 File Offset: 0x001908E4
		[DebuggerNonUserCode]
		public void MergeFrom(SentInvitation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasTargetName = other.HasTargetName;
				if (hasTargetName)
				{
					this.TargetName = other.TargetName;
				}
				bool hasRole = other.HasRole;
				if (hasRole)
				{
					this.Role = other.Role;
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x001927AA File Offset: 0x001909AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x001927B8 File Offset: 0x001909B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 9U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.Role = input.ReadUInt32();
						}
						else
						{
							this.TargetName = input.ReadString();
						}
					}
					else
					{
						this.Id = input.ReadFixed64();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						if (num3 != 53U)
						{
							goto IL_003A;
						}
						this.Program = input.ReadFixed32();
					}
					else
					{
						this.CreationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, SentInvitation._repeated_attribute_codec);
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F39 RID: 12089
		private static readonly MessageParser<SentInvitation> _parser = new MessageParser<SentInvitation>(() => new SentInvitation());

		// Token: 0x04002F3A RID: 12090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F3B RID: 12091
		private int _hasBits0;

		// Token: 0x04002F3C RID: 12092
		public const int IdFieldNumber = 1;

		// Token: 0x04002F3D RID: 12093
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04002F3E RID: 12094
		private ulong id_;

		// Token: 0x04002F3F RID: 12095
		public const int TargetNameFieldNumber = 2;

		// Token: 0x04002F40 RID: 12096
		private static readonly string TargetNameDefaultValue = "";

		// Token: 0x04002F41 RID: 12097
		private string targetName_;

		// Token: 0x04002F42 RID: 12098
		public const int RoleFieldNumber = 3;

		// Token: 0x04002F43 RID: 12099
		private static readonly uint RoleDefaultValue = 0U;

		// Token: 0x04002F44 RID: 12100
		private uint role_;

		// Token: 0x04002F45 RID: 12101
		public const int AttributeFieldNumber = 4;

		// Token: 0x04002F46 RID: 12102
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002F47 RID: 12103
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04002F48 RID: 12104
		public const int CreationTimeFieldNumber = 5;

		// Token: 0x04002F49 RID: 12105
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04002F4A RID: 12106
		private ulong creationTime_;

		// Token: 0x04002F4B RID: 12107
		public const int ProgramFieldNumber = 6;

		// Token: 0x04002F4C RID: 12108
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002F4D RID: 12109
		private uint program_;
	}
}
