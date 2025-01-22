using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000669 RID: 1641
	public sealed class SetTypingIndicatorRequest : IMessage<SetTypingIndicatorRequest>, IMessage, IEquatable<SetTypingIndicatorRequest>, IDeepCloneable<SetTypingIndicatorRequest>, IBufferMessage
	{
		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009850 RID: 38992 RVA: 0x0024E330 File Offset: 0x0024C530
		[DebuggerNonUserCode]
		public static MessageParser<SetTypingIndicatorRequest> Parser
		{
			get
			{
				return SetTypingIndicatorRequest._parser;
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x0024E348 File Offset: 0x0024C548
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x0024E36C File Offset: 0x0024C56C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetTypingIndicatorRequest.Descriptor;
			}
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x0024E383 File Offset: 0x0024C583
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest()
		{
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x0024E390 File Offset: 0x0024C590
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest(SetTypingIndicatorRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.action_ = other.action_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x0024E408 File Offset: 0x0024C608
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest Clone()
		{
			return new SetTypingIndicatorRequest(this);
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009856 RID: 38998 RVA: 0x0024E420 File Offset: 0x0024C620
		// (set) Token: 0x06009857 RID: 38999 RVA: 0x0024E438 File Offset: 0x0024C638
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

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x0024E444 File Offset: 0x0024C644
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x0024E45C File Offset: 0x0024C65C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x0024E468 File Offset: 0x0024C668
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x0024E499 File Offset: 0x0024C699
		[DebuggerNonUserCode]
		public TypingIndicator Action
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				TypingIndicator actionDefaultValue;
				if (flag)
				{
					actionDefaultValue = this.action_;
				}
				else
				{
					actionDefaultValue = SetTypingIndicatorRequest.ActionDefaultValue;
				}
				return actionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.action_ = value;
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x0024E4B4 File Offset: 0x0024C6B4
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x0024E4D1 File Offset: 0x0024C6D1
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x0024E4E4 File Offset: 0x0024C6E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetTypingIndicatorRequest);
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x0024E504 File Offset: 0x0024C704
		[DebuggerNonUserCode]
		public bool Equals(SetTypingIndicatorRequest other)
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Action != other.Action;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x0024E598 File Offset: 0x0024C798
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num ^= this.Action.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x0024E628 File Offset: 0x0024C828
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0024E640 File Offset: 0x0024C840
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x0024E64C File Offset: 0x0024C84C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Action);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x0024E6E4 File Offset: 0x0024C8E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Action);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x0024E774 File Offset: 0x0024C974
		[DebuggerNonUserCode]
		public void MergeFrom(SetTypingIndicatorRequest other)
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
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x0024E83C File Offset: 0x0024CA3C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x0024E848 File Offset: 0x0024CA48
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
							this.Action = (TypingIndicator)input.ReadEnum();
						}
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
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

		// Token: 0x0400449A RID: 17562
		private static readonly MessageParser<SetTypingIndicatorRequest> _parser = new MessageParser<SetTypingIndicatorRequest>(() => new SetTypingIndicatorRequest());

		// Token: 0x0400449B RID: 17563
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400449C RID: 17564
		private int _hasBits0;

		// Token: 0x0400449D RID: 17565
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400449E RID: 17566
		private GameAccountHandle agentId_;

		// Token: 0x0400449F RID: 17567
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044A0 RID: 17568
		private ChannelId channelId_;

		// Token: 0x040044A1 RID: 17569
		public const int ActionFieldNumber = 3;

		// Token: 0x040044A2 RID: 17570
		private static readonly TypingIndicator ActionDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x040044A3 RID: 17571
		private TypingIndicator action_;
	}
}
