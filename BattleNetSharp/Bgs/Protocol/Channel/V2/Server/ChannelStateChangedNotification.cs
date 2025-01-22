using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A3 RID: 1699
	public sealed class ChannelStateChangedNotification : IMessage<ChannelStateChangedNotification>, IMessage, IEquatable<ChannelStateChangedNotification>, IDeepCloneable<ChannelStateChangedNotification>, IBufferMessage
	{
		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009D95 RID: 40341 RVA: 0x00264E30 File Offset: 0x00263030
		[DebuggerNonUserCode]
		public static MessageParser<ChannelStateChangedNotification> Parser
		{
			get
			{
				return ChannelStateChangedNotification._parser;
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009D96 RID: 40342 RVA: 0x00264E48 File Offset: 0x00263048
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009D97 RID: 40343 RVA: 0x00264E6C File Offset: 0x0026306C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelStateChangedNotification.Descriptor;
			}
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x00264E83 File Offset: 0x00263083
		[DebuggerNonUserCode]
		public ChannelStateChangedNotification()
		{
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x00264E90 File Offset: 0x00263090
		[DebuggerNonUserCode]
		public ChannelStateChangedNotification(ChannelStateChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x00264F0C File Offset: 0x0026310C
		[DebuggerNonUserCode]
		public ChannelStateChangedNotification Clone()
		{
			return new ChannelStateChangedNotification(this);
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x00264F24 File Offset: 0x00263124
		// (set) Token: 0x06009D9C RID: 40348 RVA: 0x00264F3C File Offset: 0x0026313C
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

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x00264F48 File Offset: 0x00263148
		// (set) Token: 0x06009D9E RID: 40350 RVA: 0x00264F60 File Offset: 0x00263160
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

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x00264F6C File Offset: 0x0026316C
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x00264F84 File Offset: 0x00263184
		[DebuggerNonUserCode]
		public ChannelStateAssignment Assignment
		{
			get
			{
				return this.assignment_;
			}
			set
			{
				this.assignment_ = value;
			}
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x00264F90 File Offset: 0x00263190
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelStateChangedNotification);
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x00264FB0 File Offset: 0x002631B0
		[DebuggerNonUserCode]
		public bool Equals(ChannelStateChangedNotification other)
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
							bool flag6 = !object.Equals(this.Assignment, other.Assignment);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x00265048 File Offset: 0x00263248
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
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x002650D0 File Offset: 0x002632D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x002650E8 File Offset: 0x002632E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x002650F4 File Offset: 0x002632F4
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
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x00265190 File Offset: 0x00263390
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
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x00265224 File Offset: 0x00263424
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelStateChangedNotification other)
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
				bool flag6 = other.assignment_ != null;
				if (flag6)
				{
					bool flag7 = this.assignment_ == null;
					if (flag7)
					{
						this.Assignment = new ChannelStateAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x00265311 File Offset: 0x00263511
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0026531C File Offset: 0x0026351C
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
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.assignment_ == null;
							if (flag)
							{
								this.Assignment = new ChannelStateAssignment();
							}
							input.ReadMessage(this.Assignment);
						}
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400471C RID: 18204
		private static readonly MessageParser<ChannelStateChangedNotification> _parser = new MessageParser<ChannelStateChangedNotification>(() => new ChannelStateChangedNotification());

		// Token: 0x0400471D RID: 18205
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400471E RID: 18206
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400471F RID: 18207
		private GameAccountHandle agentId_;

		// Token: 0x04004720 RID: 18208
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004721 RID: 18209
		private ChannelId channelId_;

		// Token: 0x04004722 RID: 18210
		public const int AssignmentFieldNumber = 4;

		// Token: 0x04004723 RID: 18211
		private ChannelStateAssignment assignment_;
	}
}
