using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051F RID: 1311
	public sealed class GetStreamMentionsRequest : IMessage<GetStreamMentionsRequest>, IMessage, IEquatable<GetStreamMentionsRequest>, IDeepCloneable<GetStreamMentionsRequest>, IBufferMessage
	{
		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x001F0428 File Offset: 0x001EE628
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamMentionsRequest> Parser
		{
			get
			{
				return GetStreamMentionsRequest._parser;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06007F70 RID: 32624 RVA: 0x001F0440 File Offset: 0x001EE640
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x001F0464 File Offset: 0x001EE664
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamMentionsRequest.Descriptor;
			}
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x001F047B File Offset: 0x001EE67B
		[DebuggerNonUserCode]
		public GetStreamMentionsRequest()
		{
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x001F0488 File Offset: 0x001EE688
		[DebuggerNonUserCode]
		public GetStreamMentionsRequest(GetStreamMentionsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.fetchMessages_ = other.fetchMessages_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x001F0500 File Offset: 0x001EE700
		[DebuggerNonUserCode]
		public GetStreamMentionsRequest Clone()
		{
			return new GetStreamMentionsRequest(this);
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x06007F75 RID: 32629 RVA: 0x001F0518 File Offset: 0x001EE718
		// (set) Token: 0x06007F76 RID: 32630 RVA: 0x001F0530 File Offset: 0x001EE730
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

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x001F053C File Offset: 0x001EE73C
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x001F0554 File Offset: 0x001EE754
		[DebuggerNonUserCode]
		public GetEventOptions Options
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

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06007F79 RID: 32633 RVA: 0x001F0560 File Offset: 0x001EE760
		// (set) Token: 0x06007F7A RID: 32634 RVA: 0x001F0591 File Offset: 0x001EE791
		[DebuggerNonUserCode]
		public bool FetchMessages
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool fetchMessagesDefaultValue;
				if (flag)
				{
					fetchMessagesDefaultValue = this.fetchMessages_;
				}
				else
				{
					fetchMessagesDefaultValue = GetStreamMentionsRequest.FetchMessagesDefaultValue;
				}
				return fetchMessagesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fetchMessages_ = value;
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x06007F7B RID: 32635 RVA: 0x001F05AC File Offset: 0x001EE7AC
		[DebuggerNonUserCode]
		public bool HasFetchMessages
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x001F05C9 File Offset: 0x001EE7C9
		[DebuggerNonUserCode]
		public void ClearFetchMessages()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x001F05DC File Offset: 0x001EE7DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamMentionsRequest);
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x001F05FC File Offset: 0x001EE7FC
		[DebuggerNonUserCode]
		public bool Equals(GetStreamMentionsRequest other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FetchMessages != other.FetchMessages;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x001F0690 File Offset: 0x001EE890
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
			bool hasFetchMessages = this.HasFetchMessages;
			if (hasFetchMessages)
			{
				num ^= this.FetchMessages.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x001F0718 File Offset: 0x001EE918
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x001F0730 File Offset: 0x001EE930
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x001F073C File Offset: 0x001EE93C
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
			bool hasFetchMessages = this.HasFetchMessages;
			if (hasFetchMessages)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FetchMessages);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x001F07D4 File Offset: 0x001EE9D4
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
			bool hasFetchMessages = this.HasFetchMessages;
			if (hasFetchMessages)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x001F0858 File Offset: 0x001EEA58
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamMentionsRequest other)
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
						this.Options = new GetEventOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool hasFetchMessages = other.HasFetchMessages;
				if (hasFetchMessages)
				{
					this.FetchMessages = other.FetchMessages;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x001F0920 File Offset: 0x001EEB20
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x001F092C File Offset: 0x001EEB2C
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
							this.FetchMessages = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new GetEventOptions();
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

		// Token: 0x040039DA RID: 14810
		private static readonly MessageParser<GetStreamMentionsRequest> _parser = new MessageParser<GetStreamMentionsRequest>(() => new GetStreamMentionsRequest());

		// Token: 0x040039DB RID: 14811
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DC RID: 14812
		private int _hasBits0;

		// Token: 0x040039DD RID: 14813
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039DE RID: 14814
		private AccountId agentId_;

		// Token: 0x040039DF RID: 14815
		public const int OptionsFieldNumber = 2;

		// Token: 0x040039E0 RID: 14816
		private GetEventOptions options_;

		// Token: 0x040039E1 RID: 14817
		public const int FetchMessagesFieldNumber = 3;

		// Token: 0x040039E2 RID: 14818
		private static readonly bool FetchMessagesDefaultValue = false;

		// Token: 0x040039E3 RID: 14819
		private bool fetchMessages_;
	}
}
