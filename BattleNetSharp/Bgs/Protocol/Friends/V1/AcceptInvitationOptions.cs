using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000420 RID: 1056
	public sealed class AcceptInvitationOptions : IMessage<AcceptInvitationOptions>, IMessage, IEquatable<AcceptInvitationOptions>, IDeepCloneable<AcceptInvitationOptions>, IBufferMessage
	{
		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x00193BC8 File Offset: 0x00191DC8
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationOptions> Parser
		{
			get
			{
				return AcceptInvitationOptions._parser;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x00193BE0 File Offset: 0x00191DE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x00193C04 File Offset: 0x00191E04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationOptions.Descriptor;
			}
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00193C1B File Offset: 0x00191E1B
		[DebuggerNonUserCode]
		public AcceptInvitationOptions()
		{
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00193C25 File Offset: 0x00191E25
		[DebuggerNonUserCode]
		public AcceptInvitationOptions(AcceptInvitationOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.role_ = other.role_;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00193C64 File Offset: 0x00191E64
		[DebuggerNonUserCode]
		public AcceptInvitationOptions Clone()
		{
			return new AcceptInvitationOptions(this);
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x00193C7C File Offset: 0x00191E7C
		// (set) Token: 0x06006842 RID: 26690 RVA: 0x00193CAD File Offset: 0x00191EAD
		[DebuggerNonUserCode]
		public uint Role
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint roleDefaultValue;
				if (flag)
				{
					roleDefaultValue = this.role_;
				}
				else
				{
					roleDefaultValue = AcceptInvitationOptions.RoleDefaultValue;
				}
				return roleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.role_ = value;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06006843 RID: 26691 RVA: 0x00193CC8 File Offset: 0x00191EC8
		[DebuggerNonUserCode]
		public bool HasRole
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00193CE5 File Offset: 0x00191EE5
		[DebuggerNonUserCode]
		public void ClearRole()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006845 RID: 26693 RVA: 0x00193CF8 File Offset: 0x00191EF8
		// (set) Token: 0x06006846 RID: 26694 RVA: 0x00193D29 File Offset: 0x00191F29
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
					programDefaultValue = AcceptInvitationOptions.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.program_ = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06006847 RID: 26695 RVA: 0x00193D44 File Offset: 0x00191F44
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00193D61 File Offset: 0x00191F61
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00193D74 File Offset: 0x00191F74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationOptions);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00193D94 File Offset: 0x00191F94
		[DebuggerNonUserCode]
		public bool Equals(AcceptInvitationOptions other)
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
					bool flag4 = this.Role != other.Role;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00193E08 File Offset: 0x00192008
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num ^= this.Role.GetHashCode();
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

		// Token: 0x0600684C RID: 26700 RVA: 0x00193E74 File Offset: 0x00192074
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00193E8C File Offset: 0x0019208C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00193E98 File Offset: 0x00192098
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Role);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x00193F08 File Offset: 0x00192108
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
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

		// Token: 0x06006850 RID: 26704 RVA: 0x00193F68 File Offset: 0x00192168
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptInvitationOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRole = other.HasRole;
				if (hasRole)
				{
					this.Role = other.Role;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00193FCA File Offset: 0x001921CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00193FD8 File Offset: 0x001921D8
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
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.Role = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002F7E RID: 12158
		private static readonly MessageParser<AcceptInvitationOptions> _parser = new MessageParser<AcceptInvitationOptions>(() => new AcceptInvitationOptions());

		// Token: 0x04002F7F RID: 12159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F80 RID: 12160
		private int _hasBits0;

		// Token: 0x04002F81 RID: 12161
		public const int RoleFieldNumber = 1;

		// Token: 0x04002F82 RID: 12162
		private static readonly uint RoleDefaultValue = 0U;

		// Token: 0x04002F83 RID: 12163
		private uint role_;

		// Token: 0x04002F84 RID: 12164
		public const int ProgramFieldNumber = 2;

		// Token: 0x04002F85 RID: 12165
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002F86 RID: 12166
		private uint program_;
	}
}
