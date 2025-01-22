using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000519 RID: 1305
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06007EF7 RID: 32503 RVA: 0x001EEBEC File Offset: 0x001ECDEC
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x06007EF8 RID: 32504 RVA: 0x001EEC04 File Offset: 0x001ECE04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x001EEC28 File Offset: 0x001ECE28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x001EEC3F File Offset: 0x001ECE3F
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x001EEC4C File Offset: 0x001ECE4C
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x001EECAC File Offset: 0x001ECEAC
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x06007EFD RID: 32509 RVA: 0x001EECC4 File Offset: 0x001ECEC4
		// (set) Token: 0x06007EFE RID: 32510 RVA: 0x001EECDC File Offset: 0x001ECEDC
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x06007EFF RID: 32511 RVA: 0x001EECE8 File Offset: 0x001ECEE8
		// (set) Token: 0x06007F00 RID: 32512 RVA: 0x001EED00 File Offset: 0x001ECF00
		[DebuggerNonUserCode]
		public ClubMembershipSubscribeOptions Options
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

		// Token: 0x06007F01 RID: 32513 RVA: 0x001EED0C File Offset: 0x001ECF0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x001EED2C File Offset: 0x001ECF2C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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

		// Token: 0x06007F03 RID: 32515 RVA: 0x001EEDA4 File Offset: 0x001ECFA4
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

		// Token: 0x06007F04 RID: 32516 RVA: 0x001EEE10 File Offset: 0x001ED010
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x001EEE28 File Offset: 0x001ED028
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x001EEE34 File Offset: 0x001ED034
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

		// Token: 0x06007F07 RID: 32519 RVA: 0x001EEEA8 File Offset: 0x001ED0A8
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

		// Token: 0x06007F08 RID: 32520 RVA: 0x001EEF1C File Offset: 0x001ED11C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new ClubMembershipSubscribeOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x001EEFC9 File Offset: 0x001ED1C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x001EEFD4 File Offset: 0x001ED1D4
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
							this.Options = new ClubMembershipSubscribeOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039BC RID: 14780
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x040039BD RID: 14781
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039BE RID: 14782
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039BF RID: 14783
		private AccountId agentId_;

		// Token: 0x040039C0 RID: 14784
		public const int OptionsFieldNumber = 2;

		// Token: 0x040039C1 RID: 14785
		private ClubMembershipSubscribeOptions options_;
	}
}
