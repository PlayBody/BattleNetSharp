using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000662 RID: 1634
	public sealed class FindChannelRequest : IMessage<FindChannelRequest>, IMessage, IEquatable<FindChannelRequest>, IDeepCloneable<FindChannelRequest>, IBufferMessage
	{
		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x060097B8 RID: 38840 RVA: 0x0024C074 File Offset: 0x0024A274
		[DebuggerNonUserCode]
		public static MessageParser<FindChannelRequest> Parser
		{
			get
			{
				return FindChannelRequest._parser;
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x0024C08C File Offset: 0x0024A28C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x060097BA RID: 38842 RVA: 0x0024C0B0 File Offset: 0x0024A2B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindChannelRequest.Descriptor;
			}
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x0024C0C7 File Offset: 0x0024A2C7
		[DebuggerNonUserCode]
		public FindChannelRequest()
		{
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x0024C0D4 File Offset: 0x0024A2D4
		[DebuggerNonUserCode]
		public FindChannelRequest(FindChannelRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x0024C134 File Offset: 0x0024A334
		[DebuggerNonUserCode]
		public FindChannelRequest Clone()
		{
			return new FindChannelRequest(this);
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x060097BE RID: 38846 RVA: 0x0024C14C File Offset: 0x0024A34C
		// (set) Token: 0x060097BF RID: 38847 RVA: 0x0024C164 File Offset: 0x0024A364
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

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x060097C0 RID: 38848 RVA: 0x0024C170 File Offset: 0x0024A370
		// (set) Token: 0x060097C1 RID: 38849 RVA: 0x0024C188 File Offset: 0x0024A388
		[DebuggerNonUserCode]
		public FindChannelOptions Options
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

		// Token: 0x060097C2 RID: 38850 RVA: 0x0024C194 File Offset: 0x0024A394
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindChannelRequest);
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x0024C1B4 File Offset: 0x0024A3B4
		[DebuggerNonUserCode]
		public bool Equals(FindChannelRequest other)
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

		// Token: 0x060097C4 RID: 38852 RVA: 0x0024C22C File Offset: 0x0024A42C
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

		// Token: 0x060097C5 RID: 38853 RVA: 0x0024C298 File Offset: 0x0024A498
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x0024C2B0 File Offset: 0x0024A4B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x0024C2BC File Offset: 0x0024A4BC
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

		// Token: 0x060097C8 RID: 38856 RVA: 0x0024C330 File Offset: 0x0024A530
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

		// Token: 0x060097C9 RID: 38857 RVA: 0x0024C3A4 File Offset: 0x0024A5A4
		[DebuggerNonUserCode]
		public void MergeFrom(FindChannelRequest other)
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
						this.Options = new FindChannelOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x0024C451 File Offset: 0x0024A651
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x0024C45C File Offset: 0x0024A65C
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
							this.Options = new FindChannelOptions();
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

		// Token: 0x04004469 RID: 17513
		private static readonly MessageParser<FindChannelRequest> _parser = new MessageParser<FindChannelRequest>(() => new FindChannelRequest());

		// Token: 0x0400446A RID: 17514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400446B RID: 17515
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400446C RID: 17516
		private GameAccountHandle agentId_;

		// Token: 0x0400446D RID: 17517
		public const int OptionsFieldNumber = 2;

		// Token: 0x0400446E RID: 17518
		private FindChannelOptions options_;
	}
}
