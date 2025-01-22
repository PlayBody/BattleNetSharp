using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000696 RID: 1686
	public sealed class SendInvitationOptions : IMessage<SendInvitationOptions>, IMessage, IEquatable<SendInvitationOptions>, IDeepCloneable<SendInvitationOptions>, IBufferMessage
	{
		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009C7E RID: 40062 RVA: 0x00260634 File Offset: 0x0025E834
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationOptions> Parser
		{
			get
			{
				return SendInvitationOptions._parser;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x0026064C File Offset: 0x0025E84C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x06009C80 RID: 40064 RVA: 0x00260670 File Offset: 0x0025E870
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationOptions.Descriptor;
			}
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x00260687 File Offset: 0x0025E887
		[DebuggerNonUserCode]
		public SendInvitationOptions()
		{
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x00260694 File Offset: 0x0025E894
		[DebuggerNonUserCode]
		public SendInvitationOptions(SendInvitationOptions other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x00260710 File Offset: 0x0025E910
		[DebuggerNonUserCode]
		public SendInvitationOptions Clone()
		{
			return new SendInvitationOptions(this);
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x00260728 File Offset: 0x0025E928
		// (set) Token: 0x06009C85 RID: 40069 RVA: 0x00260740 File Offset: 0x0025E940
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

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x0026074C File Offset: 0x0025E94C
		// (set) Token: 0x06009C87 RID: 40071 RVA: 0x00260764 File Offset: 0x0025E964
		[DebuggerNonUserCode]
		public GameAccountHandle TargetId
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

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06009C88 RID: 40072 RVA: 0x00260770 File Offset: 0x0025E970
		// (set) Token: 0x06009C89 RID: 40073 RVA: 0x00260788 File Offset: 0x0025E988
		[DebuggerNonUserCode]
		public ChannelSlot Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x00260794 File Offset: 0x0025E994
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationOptions);
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x002607B4 File Offset: 0x0025E9B4
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationOptions other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
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
							bool flag6 = !object.Equals(this.Slot, other.Slot);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x0026084C File Offset: 0x0025EA4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num ^= this.Slot.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x002608D4 File Offset: 0x0025EAD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x002608EC File Offset: 0x0025EAEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x002608F8 File Offset: 0x0025EAF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Slot);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x00260994 File Offset: 0x0025EB94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x00260A28 File Offset: 0x0025EC28
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new GameAccountHandle();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag6 = other.slot_ != null;
				if (flag6)
				{
					bool flag7 = this.slot_ == null;
					if (flag7)
					{
						this.Slot = new ChannelSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x00260B15 File Offset: 0x0025ED15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x00260B20 File Offset: 0x0025ED20
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.slot_ == null;
							if (flag)
							{
								this.Slot = new ChannelSlot();
							}
							input.ReadMessage(this.Slot);
						}
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new GameAccountHandle();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x040046A6 RID: 18086
		private static readonly MessageParser<SendInvitationOptions> _parser = new MessageParser<SendInvitationOptions>(() => new SendInvitationOptions());

		// Token: 0x040046A7 RID: 18087
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046A8 RID: 18088
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x040046A9 RID: 18089
		private ChannelId channelId_;

		// Token: 0x040046AA RID: 18090
		public const int TargetIdFieldNumber = 2;

		// Token: 0x040046AB RID: 18091
		private GameAccountHandle targetId_;

		// Token: 0x040046AC RID: 18092
		public const int SlotFieldNumber = 3;

		// Token: 0x040046AD RID: 18093
		private ChannelSlot slot_;
	}
}
