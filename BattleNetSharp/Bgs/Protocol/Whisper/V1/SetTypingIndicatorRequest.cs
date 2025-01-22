using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A8 RID: 936
	public sealed class SetTypingIndicatorRequest : IMessage<SetTypingIndicatorRequest>, IMessage, IEquatable<SetTypingIndicatorRequest>, IDeepCloneable<SetTypingIndicatorRequest>, IBufferMessage
	{
		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x0016D8E8 File Offset: 0x0016BAE8
		[DebuggerNonUserCode]
		public static MessageParser<SetTypingIndicatorRequest> Parser
		{
			get
			{
				return SetTypingIndicatorRequest._parser;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06005E6C RID: 24172 RVA: 0x0016D900 File Offset: 0x0016BB00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x0016D924 File Offset: 0x0016BB24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetTypingIndicatorRequest.Descriptor;
			}
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x0016D93B File Offset: 0x0016BB3B
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest()
		{
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x0016D948 File Offset: 0x0016BB48
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest(SetTypingIndicatorRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.action_ = other.action_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x0016D9C0 File Offset: 0x0016BBC0
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest Clone()
		{
			return new SetTypingIndicatorRequest(this);
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x0016D9D8 File Offset: 0x0016BBD8
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x0016D9F0 File Offset: 0x0016BBF0
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

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x0016D9FC File Offset: 0x0016BBFC
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x0016DA14 File Offset: 0x0016BC14
		[DebuggerNonUserCode]
		public AccountId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x0016DA20 File Offset: 0x0016BC20
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x0016DA51 File Offset: 0x0016BC51
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

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06005E77 RID: 24183 RVA: 0x0016DA6C File Offset: 0x0016BC6C
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x0016DA89 File Offset: 0x0016BC89
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x0016DA9C File Offset: 0x0016BC9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetTypingIndicatorRequest);
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x0016DABC File Offset: 0x0016BCBC
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
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
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

		// Token: 0x06005E7B RID: 24187 RVA: 0x0016DB50 File Offset: 0x0016BD50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
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

		// Token: 0x06005E7C RID: 24188 RVA: 0x0016DBE0 File Offset: 0x0016BDE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x0016DBF8 File Offset: 0x0016BDF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x0016DC04 File Offset: 0x0016BE04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
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

		// Token: 0x06005E7F RID: 24191 RVA: 0x0016DC9C File Offset: 0x0016BE9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
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

		// Token: 0x06005E80 RID: 24192 RVA: 0x0016DD2C File Offset: 0x0016BF2C
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new AccountId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x0016DDF4 File Offset: 0x0016BFF4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x0016DE00 File Offset: 0x0016C000
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
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new AccountId();
						}
						input.ReadMessage(this.TargetId);
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

		// Token: 0x04002B2B RID: 11051
		private static readonly MessageParser<SetTypingIndicatorRequest> _parser = new MessageParser<SetTypingIndicatorRequest>(() => new SetTypingIndicatorRequest());

		// Token: 0x04002B2C RID: 11052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B2D RID: 11053
		private int _hasBits0;

		// Token: 0x04002B2E RID: 11054
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B2F RID: 11055
		private AccountId agentId_;

		// Token: 0x04002B30 RID: 11056
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002B31 RID: 11057
		private AccountId targetId_;

		// Token: 0x04002B32 RID: 11058
		public const int ActionFieldNumber = 3;

		// Token: 0x04002B33 RID: 11059
		private static readonly TypingIndicator ActionDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x04002B34 RID: 11060
		private TypingIndicator action_;
	}
}
