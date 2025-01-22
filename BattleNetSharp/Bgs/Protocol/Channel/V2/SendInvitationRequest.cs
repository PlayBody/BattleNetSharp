using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000670 RID: 1648
	public sealed class SendInvitationRequest : IMessage<SendInvitationRequest>, IMessage, IEquatable<SendInvitationRequest>, IDeepCloneable<SendInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x00250B5C File Offset: 0x0024ED5C
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationRequest> Parser
		{
			get
			{
				return SendInvitationRequest._parser;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x00250B74 File Offset: 0x0024ED74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x060098F3 RID: 39155 RVA: 0x00250B98 File Offset: 0x0024ED98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00250BAF File Offset: 0x0024EDAF
		[DebuggerNonUserCode]
		public SendInvitationRequest()
		{
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x00250BBC File Offset: 0x0024EDBC
		[DebuggerNonUserCode]
		public SendInvitationRequest(SendInvitationRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x00250C1C File Offset: 0x0024EE1C
		[DebuggerNonUserCode]
		public SendInvitationRequest Clone()
		{
			return new SendInvitationRequest(this);
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x060098F7 RID: 39159 RVA: 0x00250C34 File Offset: 0x0024EE34
		// (set) Token: 0x060098F8 RID: 39160 RVA: 0x00250C4C File Offset: 0x0024EE4C
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x060098F9 RID: 39161 RVA: 0x00250C58 File Offset: 0x0024EE58
		// (set) Token: 0x060098FA RID: 39162 RVA: 0x00250C70 File Offset: 0x0024EE70
		[DebuggerNonUserCode]
		public SendInvitationOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x060098FB RID: 39163 RVA: 0x00250C7C File Offset: 0x0024EE7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationRequest);
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x00250C9C File Offset: 0x0024EE9C
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x00250D14 File Offset: 0x0024EF14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x00250D80 File Offset: 0x0024EF80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x00250D98 File Offset: 0x0024EF98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00250DA4 File Offset: 0x0024EFA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x00250E18 File Offset: 0x0024F018
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x00250E8C File Offset: 0x0024F08C
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SendInvitationOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x00250F39 File Offset: 0x0024F139
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x00250F44 File Offset: 0x0024F144
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new SendInvitationOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044D2 RID: 17618
		private static readonly MessageParser<SendInvitationRequest> _parser = new MessageParser<SendInvitationRequest>(() => new SendInvitationRequest());

		// Token: 0x040044D3 RID: 17619
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044D4 RID: 17620
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044D5 RID: 17621
		private GameAccountHandle agentId_;

		// Token: 0x040044D6 RID: 17622
		public const int OptionsFieldNumber = 2;

		// Token: 0x040044D7 RID: 17623
		private SendInvitationOptions options_;
	}
}
