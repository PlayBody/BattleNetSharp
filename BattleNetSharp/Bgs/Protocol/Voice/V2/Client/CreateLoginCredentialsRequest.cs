using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x02000529 RID: 1321
	public sealed class CreateLoginCredentialsRequest : IMessage<CreateLoginCredentialsRequest>, IMessage, IEquatable<CreateLoginCredentialsRequest>, IDeepCloneable<CreateLoginCredentialsRequest>, IBufferMessage
	{
		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600800B RID: 32779 RVA: 0x001F29F0 File Offset: 0x001F0BF0
		[DebuggerNonUserCode]
		public static MessageParser<CreateLoginCredentialsRequest> Parser
		{
			get
			{
				return CreateLoginCredentialsRequest._parser;
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x001F2A08 File Offset: 0x001F0C08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600800D RID: 32781 RVA: 0x001F2A2C File Offset: 0x001F0C2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateLoginCredentialsRequest.Descriptor;
			}
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x001F2A43 File Offset: 0x001F0C43
		[DebuggerNonUserCode]
		public CreateLoginCredentialsRequest()
		{
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x001F2A50 File Offset: 0x001F0C50
		[DebuggerNonUserCode]
		public CreateLoginCredentialsRequest(CreateLoginCredentialsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = ((other.agentAccountId_ != null) ? other.agentAccountId_.Clone() : null);
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x001F2AAC File Offset: 0x001F0CAC
		[DebuggerNonUserCode]
		public CreateLoginCredentialsRequest Clone()
		{
			return new CreateLoginCredentialsRequest(this);
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x06008011 RID: 32785 RVA: 0x001F2AC4 File Offset: 0x001F0CC4
		// (set) Token: 0x06008012 RID: 32786 RVA: 0x001F2ADC File Offset: 0x001F0CDC
		[DebuggerNonUserCode]
		public AccountId AgentAccountId
		{
			get
			{
				return this.agentAccountId_;
			}
			set
			{
				this.agentAccountId_ = value;
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x001F2AE8 File Offset: 0x001F0CE8
		// (set) Token: 0x06008014 RID: 32788 RVA: 0x001F2B19 File Offset: 0x001F0D19
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = CreateLoginCredentialsRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x06008015 RID: 32789 RVA: 0x001F2B34 File Offset: 0x001F0D34
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x001F2B51 File Offset: 0x001F0D51
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x001F2B64 File Offset: 0x001F0D64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateLoginCredentialsRequest);
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x001F2B84 File Offset: 0x001F0D84
		[DebuggerNonUserCode]
		public bool Equals(CreateLoginCredentialsRequest other)
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
					bool flag4 = !object.Equals(this.AgentAccountId, other.AgentAccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Version != other.Version;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x001F2BF8 File Offset: 0x001F0DF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				num ^= this.AgentAccountId.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x001F2C64 File Offset: 0x001F0E64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x001F2C7C File Offset: 0x001F0E7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x001F2C88 File Offset: 0x001F0E88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentAccountId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x001F2CFC File Offset: 0x001F0EFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentAccountId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x001F2D6C File Offset: 0x001F0F6C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateLoginCredentialsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentAccountId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentAccountId_ == null;
					if (flag3)
					{
						this.AgentAccountId = new AccountId();
					}
					this.AgentAccountId.MergeFrom(other.AgentAccountId);
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x001F2DF1 File Offset: 0x001F0FF1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x001F2DFC File Offset: 0x001F0FFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.agentAccountId_ == null;
					if (flag)
					{
						this.AgentAccountId = new AccountId();
					}
					input.ReadMessage(this.AgentAccountId);
				}
			}
		}

		// Token: 0x04003A27 RID: 14887
		private static readonly MessageParser<CreateLoginCredentialsRequest> _parser = new MessageParser<CreateLoginCredentialsRequest>(() => new CreateLoginCredentialsRequest());

		// Token: 0x04003A28 RID: 14888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A29 RID: 14889
		private int _hasBits0;

		// Token: 0x04003A2A RID: 14890
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x04003A2B RID: 14891
		private AccountId agentAccountId_;

		// Token: 0x04003A2C RID: 14892
		public const int VersionFieldNumber = 2;

		// Token: 0x04003A2D RID: 14893
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04003A2E RID: 14894
		private uint version_;
	}
}
