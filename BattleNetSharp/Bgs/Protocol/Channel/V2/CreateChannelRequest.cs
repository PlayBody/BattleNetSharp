using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200065C RID: 1628
	public sealed class CreateChannelRequest : IMessage<CreateChannelRequest>, IMessage, IEquatable<CreateChannelRequest>, IDeepCloneable<CreateChannelRequest>, IBufferMessage
	{
		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x00249FE4 File Offset: 0x002481E4
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelRequest> Parser
		{
			get
			{
				return CreateChannelRequest._parser;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x06009728 RID: 38696 RVA: 0x00249FFC File Offset: 0x002481FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0024A020 File Offset: 0x00248220
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelRequest.Descriptor;
			}
		}

		// Token: 0x0600972A RID: 38698 RVA: 0x0024A037 File Offset: 0x00248237
		[DebuggerNonUserCode]
		public CreateChannelRequest()
		{
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x0024A044 File Offset: 0x00248244
		[DebuggerNonUserCode]
		public CreateChannelRequest(CreateChannelRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x0024A0A4 File Offset: 0x002482A4
		[DebuggerNonUserCode]
		public CreateChannelRequest Clone()
		{
			return new CreateChannelRequest(this);
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0024A0BC File Offset: 0x002482BC
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x0024A0D4 File Offset: 0x002482D4
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

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0024A0E0 File Offset: 0x002482E0
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x0024A0F8 File Offset: 0x002482F8
		[DebuggerNonUserCode]
		public CreateChannelOptions Options
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

		// Token: 0x06009731 RID: 38705 RVA: 0x0024A104 File Offset: 0x00248304
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelRequest);
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x0024A124 File Offset: 0x00248324
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelRequest other)
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

		// Token: 0x06009733 RID: 38707 RVA: 0x0024A19C File Offset: 0x0024839C
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

		// Token: 0x06009734 RID: 38708 RVA: 0x0024A208 File Offset: 0x00248408
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x0024A220 File Offset: 0x00248420
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x0024A22C File Offset: 0x0024842C
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

		// Token: 0x06009737 RID: 38711 RVA: 0x0024A2A0 File Offset: 0x002484A0
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

		// Token: 0x06009738 RID: 38712 RVA: 0x0024A314 File Offset: 0x00248514
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelRequest other)
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
						this.Options = new CreateChannelOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x0024A3C1 File Offset: 0x002485C1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0024A3CC File Offset: 0x002485CC
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
							this.Options = new CreateChannelOptions();
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

		// Token: 0x04004433 RID: 17459
		private static readonly MessageParser<CreateChannelRequest> _parser = new MessageParser<CreateChannelRequest>(() => new CreateChannelRequest());

		// Token: 0x04004434 RID: 17460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004435 RID: 17461
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004436 RID: 17462
		private GameAccountHandle agentId_;

		// Token: 0x04004437 RID: 17463
		public const int OptionsFieldNumber = 2;

		// Token: 0x04004438 RID: 17464
		private CreateChannelOptions options_;
	}
}
