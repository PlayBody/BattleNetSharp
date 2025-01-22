using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x0200052B RID: 1323
	public sealed class CreateChannelSttTokenRequest : IMessage<CreateChannelSttTokenRequest>, IMessage, IEquatable<CreateChannelSttTokenRequest>, IDeepCloneable<CreateChannelSttTokenRequest>, IBufferMessage
	{
		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x001F320C File Offset: 0x001F140C
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelSttTokenRequest> Parser
		{
			get
			{
				return CreateChannelSttTokenRequest._parser;
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x06008036 RID: 32822 RVA: 0x001F3224 File Offset: 0x001F1424
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x001F3248 File Offset: 0x001F1448
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelSttTokenRequest.Descriptor;
			}
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x001F325F File Offset: 0x001F145F
		[DebuggerNonUserCode]
		public CreateChannelSttTokenRequest()
		{
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x001F326C File Offset: 0x001F146C
		[DebuggerNonUserCode]
		public CreateChannelSttTokenRequest(CreateChannelSttTokenRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = ((other.agentAccountId_ != null) ? other.agentAccountId_.Clone() : null);
			this.channelUri_ = other.channelUri_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x001F32D4 File Offset: 0x001F14D4
		[DebuggerNonUserCode]
		public CreateChannelSttTokenRequest Clone()
		{
			return new CreateChannelSttTokenRequest(this);
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x001F32EC File Offset: 0x001F14EC
		// (set) Token: 0x0600803C RID: 32828 RVA: 0x001F3304 File Offset: 0x001F1504
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

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x001F3310 File Offset: 0x001F1510
		// (set) Token: 0x0600803E RID: 32830 RVA: 0x001F3331 File Offset: 0x001F1531
		[DebuggerNonUserCode]
		public string ChannelUri
		{
			get
			{
				return this.channelUri_ ?? CreateChannelSttTokenRequest.ChannelUriDefaultValue;
			}
			set
			{
				this.channelUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600803F RID: 32831 RVA: 0x001F3348 File Offset: 0x001F1548
		[DebuggerNonUserCode]
		public bool HasChannelUri
		{
			get
			{
				return this.channelUri_ != null;
			}
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x001F3363 File Offset: 0x001F1563
		[DebuggerNonUserCode]
		public void ClearChannelUri()
		{
			this.channelUri_ = null;
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06008041 RID: 32833 RVA: 0x001F3370 File Offset: 0x001F1570
		// (set) Token: 0x06008042 RID: 32834 RVA: 0x001F33A1 File Offset: 0x001F15A1
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
					versionDefaultValue = CreateChannelSttTokenRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x06008043 RID: 32835 RVA: 0x001F33BC File Offset: 0x001F15BC
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x001F33D9 File Offset: 0x001F15D9
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x001F33EC File Offset: 0x001F15EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelSttTokenRequest);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x001F340C File Offset: 0x001F160C
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelSttTokenRequest other)
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
						bool flag5 = this.ChannelUri != other.ChannelUri;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Version != other.Version;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x001F349C File Offset: 0x001F169C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				num ^= this.AgentAccountId.GetHashCode();
			}
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				num ^= this.ChannelUri.GetHashCode();
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

		// Token: 0x06008048 RID: 32840 RVA: 0x001F3524 File Offset: 0x001F1724
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x001F353C File Offset: 0x001F173C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x001F3548 File Offset: 0x001F1748
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentAccountId);
			}
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ChannelUri);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x001F35DC File Offset: 0x001F17DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentAccountId);
			}
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelUri);
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

		// Token: 0x0600804C RID: 32844 RVA: 0x001F366C File Offset: 0x001F186C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelSttTokenRequest other)
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
				bool hasChannelUri = other.HasChannelUri;
				if (hasChannelUri)
				{
					this.ChannelUri = other.ChannelUri;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x001F370F File Offset: 0x001F190F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x001F371C File Offset: 0x001F191C
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
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
						this.ChannelUri = input.ReadString();
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

		// Token: 0x04003A33 RID: 14899
		private static readonly MessageParser<CreateChannelSttTokenRequest> _parser = new MessageParser<CreateChannelSttTokenRequest>(() => new CreateChannelSttTokenRequest());

		// Token: 0x04003A34 RID: 14900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A35 RID: 14901
		private int _hasBits0;

		// Token: 0x04003A36 RID: 14902
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x04003A37 RID: 14903
		private AccountId agentAccountId_;

		// Token: 0x04003A38 RID: 14904
		public const int ChannelUriFieldNumber = 2;

		// Token: 0x04003A39 RID: 14905
		private static readonly string ChannelUriDefaultValue = "";

		// Token: 0x04003A3A RID: 14906
		private string channelUri_;

		// Token: 0x04003A3B RID: 14907
		public const int VersionFieldNumber = 3;

		// Token: 0x04003A3C RID: 14908
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04003A3D RID: 14909
		private uint version_;
	}
}
