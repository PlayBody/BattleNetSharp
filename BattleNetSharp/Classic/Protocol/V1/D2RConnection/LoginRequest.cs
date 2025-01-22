using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x0200076C RID: 1900
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>, IBufferMessage
	{
		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x002A764C File Offset: 0x002A584C
		[DebuggerNonUserCode]
		public static MessageParser<LoginRequest> Parser
		{
			get
			{
				return LoginRequest._parser;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600AE5E RID: 44638 RVA: 0x002A7664 File Offset: 0x002A5864
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x002A7688 File Offset: 0x002A5888
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginRequest.Descriptor;
			}
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x002A769F File Offset: 0x002A589F
		[DebuggerNonUserCode]
		public LoginRequest()
		{
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x002A76AC File Offset: 0x002A58AC
		[DebuggerNonUserCode]
		public LoginRequest(LoginRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.version_ = other.version_;
			this.platform_ = other.platform_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x002A7704 File Offset: 0x002A5904
		[DebuggerNonUserCode]
		public LoginRequest Clone()
		{
			return new LoginRequest(this);
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600AE63 RID: 44643 RVA: 0x002A771C File Offset: 0x002A591C
		// (set) Token: 0x0600AE64 RID: 44644 RVA: 0x002A774D File Offset: 0x002A594D
		[DebuggerNonUserCode]
		public int Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = LoginRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600AE65 RID: 44645 RVA: 0x002A7768 File Offset: 0x002A5968
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AE66 RID: 44646 RVA: 0x002A7785 File Offset: 0x002A5985
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600AE67 RID: 44647 RVA: 0x002A7798 File Offset: 0x002A5998
		// (set) Token: 0x0600AE68 RID: 44648 RVA: 0x002A77B9 File Offset: 0x002A59B9
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? LoginRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x002A77D0 File Offset: 0x002A59D0
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x002A77EB File Offset: 0x002A59EB
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x002A77F8 File Offset: 0x002A59F8
		// (set) Token: 0x0600AE6C RID: 44652 RVA: 0x002A7829 File Offset: 0x002A5A29
		[DebuggerNonUserCode]
		public int Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = LoginRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.platform_ = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600AE6D RID: 44653 RVA: 0x002A7844 File Offset: 0x002A5A44
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x002A7861 File Offset: 0x002A5A61
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x002A7874 File Offset: 0x002A5A74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginRequest);
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x002A7894 File Offset: 0x002A5A94
		[DebuggerNonUserCode]
		public bool Equals(LoginRequest other)
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
					bool flag4 = this.Program != other.Program;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Version != other.Version;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Platform != other.Platform;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x002A7920 File Offset: 0x002A5B20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE72 RID: 44658 RVA: 0x002A79A8 File Offset: 0x002A5BA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x002A79C0 File Offset: 0x002A5BC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x002A79CC File Offset: 0x002A5BCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Program);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Version);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Platform);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x002A7A5C File Offset: 0x002A5C5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Program);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x002A7AE8 File Offset: 0x002A5CE8
		[DebuggerNonUserCode]
		public void MergeFrom(LoginRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x002A7B63 File Offset: 0x002A5D63
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x002A7B70 File Offset: 0x002A5D70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Platform = input.ReadInt32();
						}
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.Program = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E92 RID: 20114
		private static readonly MessageParser<LoginRequest> _parser = new MessageParser<LoginRequest>(() => new LoginRequest());

		// Token: 0x04004E93 RID: 20115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E94 RID: 20116
		private int _hasBits0;

		// Token: 0x04004E95 RID: 20117
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004E96 RID: 20118
		private static readonly int ProgramDefaultValue = 0;

		// Token: 0x04004E97 RID: 20119
		private int program_;

		// Token: 0x04004E98 RID: 20120
		public const int VersionFieldNumber = 3;

		// Token: 0x04004E99 RID: 20121
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004E9A RID: 20122
		private string version_;

		// Token: 0x04004E9B RID: 20123
		public const int PlatformFieldNumber = 4;

		// Token: 0x04004E9C RID: 20124
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04004E9D RID: 20125
		private int platform_;
	}
}
