using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000667 RID: 1639
	public sealed class SetPrivacyLevelRequest : IMessage<SetPrivacyLevelRequest>, IMessage, IEquatable<SetPrivacyLevelRequest>, IDeepCloneable<SetPrivacyLevelRequest>, IBufferMessage
	{
		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009820 RID: 38944 RVA: 0x0024D750 File Offset: 0x0024B950
		[DebuggerNonUserCode]
		public static MessageParser<SetPrivacyLevelRequest> Parser
		{
			get
			{
				return SetPrivacyLevelRequest._parser;
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x06009821 RID: 38945 RVA: 0x0024D768 File Offset: 0x0024B968
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x0024D78C File Offset: 0x0024B98C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPrivacyLevelRequest.Descriptor;
			}
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x0024D7A3 File Offset: 0x0024B9A3
		[DebuggerNonUserCode]
		public SetPrivacyLevelRequest()
		{
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x0024D7B0 File Offset: 0x0024B9B0
		[DebuggerNonUserCode]
		public SetPrivacyLevelRequest(SetPrivacyLevelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x0024D828 File Offset: 0x0024BA28
		[DebuggerNonUserCode]
		public SetPrivacyLevelRequest Clone()
		{
			return new SetPrivacyLevelRequest(this);
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x06009826 RID: 38950 RVA: 0x0024D840 File Offset: 0x0024BA40
		// (set) Token: 0x06009827 RID: 38951 RVA: 0x0024D858 File Offset: 0x0024BA58
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

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x0024D864 File Offset: 0x0024BA64
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x0024D87C File Offset: 0x0024BA7C
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

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x0024D888 File Offset: 0x0024BA88
		// (set) Token: 0x0600982B RID: 38955 RVA: 0x0024D8B9 File Offset: 0x0024BAB9
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = SetPrivacyLevelRequest.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x0024D8D4 File Offset: 0x0024BAD4
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0024D8F1 File Offset: 0x0024BAF1
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x0024D904 File Offset: 0x0024BB04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPrivacyLevelRequest);
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x0024D924 File Offset: 0x0024BB24
		[DebuggerNonUserCode]
		public bool Equals(SetPrivacyLevelRequest other)
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
							bool flag6 = this.PrivacyLevel != other.PrivacyLevel;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x0024D9B8 File Offset: 0x0024BBB8
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x0024DA48 File Offset: 0x0024BC48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x0024DA60 File Offset: 0x0024BC60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x0024DA6C File Offset: 0x0024BC6C
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x0024DB04 File Offset: 0x0024BD04
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x0024DB94 File Offset: 0x0024BD94
		[DebuggerNonUserCode]
		public void MergeFrom(SetPrivacyLevelRequest other)
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
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x0024DC5C File Offset: 0x0024BE5C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0024DC68 File Offset: 0x0024BE68
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
							this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
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

		// Token: 0x04004488 RID: 17544
		private static readonly MessageParser<SetPrivacyLevelRequest> _parser = new MessageParser<SetPrivacyLevelRequest>(() => new SetPrivacyLevelRequest());

		// Token: 0x04004489 RID: 17545
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400448A RID: 17546
		private int _hasBits0;

		// Token: 0x0400448B RID: 17547
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400448C RID: 17548
		private GameAccountHandle agentId_;

		// Token: 0x0400448D RID: 17549
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x0400448E RID: 17550
		private ChannelId channelId_;

		// Token: 0x0400448F RID: 17551
		public const int PrivacyLevelFieldNumber = 3;

		// Token: 0x04004490 RID: 17552
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x04004491 RID: 17553
		private PrivacyLevel privacyLevel_;
	}
}
