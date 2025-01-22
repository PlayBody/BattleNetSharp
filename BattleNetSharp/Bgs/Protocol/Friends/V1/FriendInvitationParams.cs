using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041E RID: 1054
	public sealed class FriendInvitationParams : IMessage<FriendInvitationParams>, IMessage, IEquatable<FriendInvitationParams>, IDeepCloneable<FriendInvitationParams>, IBufferMessage
	{
		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x001928E8 File Offset: 0x00190AE8
		[DebuggerNonUserCode]
		public static MessageParser<FriendInvitationParams> Parser
		{
			get
			{
				return FriendInvitationParams._parser;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x00192900 File Offset: 0x00190B00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x00192924 File Offset: 0x00190B24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInvitationParams.Descriptor;
			}
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x0019293B File Offset: 0x00190B3B
		[DebuggerNonUserCode]
		public FriendInvitationParams()
		{
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x0019295C File Offset: 0x00190B5C
		[DebuggerNonUserCode]
		public FriendInvitationParams(FriendInvitationParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetEmail_ = other.targetEmail_;
			this.targetBattleTag_ = other.targetBattleTag_;
			this.role_ = other.role_.Clone();
			this.attribute_ = other.attribute_.Clone();
			this.targetName_ = other.targetName_;
			this.program_ = other.program_;
			this.targetPhoneNumber_ = other.targetPhoneNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x001929EC File Offset: 0x00190BEC
		[DebuggerNonUserCode]
		public FriendInvitationParams Clone()
		{
			return new FriendInvitationParams(this);
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x00192A04 File Offset: 0x00190C04
		// (set) Token: 0x060067FA RID: 26618 RVA: 0x00192A25 File Offset: 0x00190C25
		[DebuggerNonUserCode]
		public string TargetEmail
		{
			get
			{
				return this.targetEmail_ ?? FriendInvitationParams.TargetEmailDefaultValue;
			}
			set
			{
				this.targetEmail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x060067FB RID: 26619 RVA: 0x00192A3C File Offset: 0x00190C3C
		[DebuggerNonUserCode]
		public bool HasTargetEmail
		{
			get
			{
				return this.targetEmail_ != null;
			}
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00192A57 File Offset: 0x00190C57
		[DebuggerNonUserCode]
		public void ClearTargetEmail()
		{
			this.targetEmail_ = null;
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x060067FD RID: 26621 RVA: 0x00192A64 File Offset: 0x00190C64
		// (set) Token: 0x060067FE RID: 26622 RVA: 0x00192A85 File Offset: 0x00190C85
		[DebuggerNonUserCode]
		public string TargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ ?? FriendInvitationParams.TargetBattleTagDefaultValue;
			}
			set
			{
				this.targetBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x060067FF RID: 26623 RVA: 0x00192A9C File Offset: 0x00190C9C
		[DebuggerNonUserCode]
		public bool HasTargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ != null;
			}
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x00192AB7 File Offset: 0x00190CB7
		[DebuggerNonUserCode]
		public void ClearTargetBattleTag()
		{
			this.targetBattleTag_ = null;
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x00192AC4 File Offset: 0x00190CC4
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x00192ADC File Offset: 0x00190CDC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x00192AF4 File Offset: 0x00190CF4
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x00192B15 File Offset: 0x00190D15
		[DebuggerNonUserCode]
		public string TargetName
		{
			get
			{
				return this.targetName_ ?? FriendInvitationParams.TargetNameDefaultValue;
			}
			set
			{
				this.targetName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00192B2C File Offset: 0x00190D2C
		[DebuggerNonUserCode]
		public bool HasTargetName
		{
			get
			{
				return this.targetName_ != null;
			}
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x00192B47 File Offset: 0x00190D47
		[DebuggerNonUserCode]
		public void ClearTargetName()
		{
			this.targetName_ = null;
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x00192B54 File Offset: 0x00190D54
		// (set) Token: 0x06006808 RID: 26632 RVA: 0x00192B85 File Offset: 0x00190D85
		[Obsolete]
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = FriendInvitationParams.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x00192BA0 File Offset: 0x00190DA0
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00192BBD File Offset: 0x00190DBD
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x00192BD0 File Offset: 0x00190DD0
		// (set) Token: 0x0600680C RID: 26636 RVA: 0x00192BF1 File Offset: 0x00190DF1
		[DebuggerNonUserCode]
		public string TargetPhoneNumber
		{
			get
			{
				return this.targetPhoneNumber_ ?? FriendInvitationParams.TargetPhoneNumberDefaultValue;
			}
			set
			{
				this.targetPhoneNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x00192C08 File Offset: 0x00190E08
		[DebuggerNonUserCode]
		public bool HasTargetPhoneNumber
		{
			get
			{
				return this.targetPhoneNumber_ != null;
			}
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00192C23 File Offset: 0x00190E23
		[DebuggerNonUserCode]
		public void ClearTargetPhoneNumber()
		{
			this.targetPhoneNumber_ = null;
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x00192C30 File Offset: 0x00190E30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInvitationParams);
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x00192C50 File Offset: 0x00190E50
		[DebuggerNonUserCode]
		public bool Equals(FriendInvitationParams other)
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
					bool flag4 = this.TargetEmail != other.TargetEmail;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetBattleTag != other.TargetBattleTag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.role_.Equals(other.role_);
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
									bool flag8 = this.TargetName != other.TargetName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Program != other.Program;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TargetPhoneNumber != other.TargetPhoneNumber;
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

		// Token: 0x06006811 RID: 26641 RVA: 0x00192D60 File Offset: 0x00190F60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetEmail = this.HasTargetEmail;
			if (hasTargetEmail)
			{
				num ^= this.TargetEmail.GetHashCode();
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num ^= this.TargetBattleTag.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			num ^= this.attribute_.GetHashCode();
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				num ^= this.TargetName.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasTargetPhoneNumber = this.HasTargetPhoneNumber;
			if (hasTargetPhoneNumber)
			{
				num ^= this.TargetPhoneNumber.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00192E34 File Offset: 0x00191034
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x00192E4C File Offset: 0x0019104C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x00192E58 File Offset: 0x00191058
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetEmail = this.HasTargetEmail;
			if (hasTargetEmail)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TargetEmail);
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TargetBattleTag);
			}
			this.role_.WriteTo(ref output, FriendInvitationParams._repeated_role_codec);
			this.attribute_.WriteTo(ref output, FriendInvitationParams._repeated_attribute_codec);
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				output.WriteRawTag(74);
				output.WriteString(this.TargetName);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(85);
				output.WriteFixed32(this.Program);
			}
			bool hasTargetPhoneNumber = this.HasTargetPhoneNumber;
			if (hasTargetPhoneNumber)
			{
				output.WriteRawTag(90);
				output.WriteString(this.TargetPhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x00192F54 File Offset: 0x00191154
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetEmail = this.HasTargetEmail;
			if (hasTargetEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetEmail);
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetBattleTag);
			}
			num += this.role_.CalculateSize(FriendInvitationParams._repeated_role_codec);
			num += this.attribute_.CalculateSize(FriendInvitationParams._repeated_attribute_codec);
			bool hasTargetName = this.HasTargetName;
			if (hasTargetName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetName);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasTargetPhoneNumber = this.HasTargetPhoneNumber;
			if (hasTargetPhoneNumber)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetPhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00193034 File Offset: 0x00191234
		[DebuggerNonUserCode]
		public void MergeFrom(FriendInvitationParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetEmail = other.HasTargetEmail;
				if (hasTargetEmail)
				{
					this.TargetEmail = other.TargetEmail;
				}
				bool hasTargetBattleTag = other.HasTargetBattleTag;
				if (hasTargetBattleTag)
				{
					this.TargetBattleTag = other.TargetBattleTag;
				}
				this.role_.Add(other.role_);
				this.attribute_.Add(other.attribute_);
				bool hasTargetName = other.HasTargetName;
				if (hasTargetName)
				{
					this.TargetName = other.TargetName;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasTargetPhoneNumber = other.HasTargetPhoneNumber;
				if (hasTargetPhoneNumber)
				{
					this.TargetPhoneNumber = other.TargetPhoneNumber;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x0019310C File Offset: 0x0019130C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x00193118 File Offset: 0x00191318
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0055;
							}
							this.TargetBattleTag = input.ReadString();
						}
						else
						{
							this.TargetEmail = input.ReadString();
						}
					}
					else
					{
						if (num3 != 48U && num3 != 50U)
						{
							goto IL_0055;
						}
						this.role_.AddEntriesFrom(ref input, FriendInvitationParams._repeated_role_codec);
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 66U)
					{
						if (num3 != 74U)
						{
							goto IL_0055;
						}
						this.TargetName = input.ReadString();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, FriendInvitationParams._repeated_attribute_codec);
					}
				}
				else if (num3 != 85U)
				{
					if (num3 != 90U)
					{
						goto IL_0055;
					}
					this.TargetPhoneNumber = input.ReadString();
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F4E RID: 12110
		private static readonly MessageParser<FriendInvitationParams> _parser = new MessageParser<FriendInvitationParams>(() => new FriendInvitationParams());

		// Token: 0x04002F4F RID: 12111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F50 RID: 12112
		private int _hasBits0;

		// Token: 0x04002F51 RID: 12113
		public const int TargetEmailFieldNumber = 1;

		// Token: 0x04002F52 RID: 12114
		private static readonly string TargetEmailDefaultValue = "";

		// Token: 0x04002F53 RID: 12115
		private string targetEmail_;

		// Token: 0x04002F54 RID: 12116
		public const int TargetBattleTagFieldNumber = 2;

		// Token: 0x04002F55 RID: 12117
		private static readonly string TargetBattleTagDefaultValue = "";

		// Token: 0x04002F56 RID: 12118
		private string targetBattleTag_;

		// Token: 0x04002F57 RID: 12119
		public const int RoleFieldNumber = 6;

		// Token: 0x04002F58 RID: 12120
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04002F59 RID: 12121
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x04002F5A RID: 12122
		public const int AttributeFieldNumber = 8;

		// Token: 0x04002F5B RID: 12123
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(66U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002F5C RID: 12124
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04002F5D RID: 12125
		public const int TargetNameFieldNumber = 9;

		// Token: 0x04002F5E RID: 12126
		private static readonly string TargetNameDefaultValue = "";

		// Token: 0x04002F5F RID: 12127
		private string targetName_;

		// Token: 0x04002F60 RID: 12128
		public const int ProgramFieldNumber = 10;

		// Token: 0x04002F61 RID: 12129
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002F62 RID: 12130
		private uint program_;

		// Token: 0x04002F63 RID: 12131
		public const int TargetPhoneNumberFieldNumber = 11;

		// Token: 0x04002F64 RID: 12132
		private static readonly string TargetPhoneNumberDefaultValue = "";

		// Token: 0x04002F65 RID: 12133
		private string targetPhoneNumber_;
	}
}
