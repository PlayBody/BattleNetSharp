using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000681 RID: 1665
	public sealed class SuggestionAddedNotification : IMessage<SuggestionAddedNotification>, IMessage, IEquatable<SuggestionAddedNotification>, IDeepCloneable<SuggestionAddedNotification>, IBufferMessage
	{
		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00257D18 File Offset: 0x00255F18
		[DebuggerNonUserCode]
		public static MessageParser<SuggestionAddedNotification> Parser
		{
			get
			{
				return SuggestionAddedNotification._parser;
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06009AA3 RID: 39587 RVA: 0x00257D30 File Offset: 0x00255F30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[37];
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x00257D54 File Offset: 0x00255F54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuggestionAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x00257D6B File Offset: 0x00255F6B
		[DebuggerNonUserCode]
		public SuggestionAddedNotification()
		{
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x00257D78 File Offset: 0x00255F78
		[DebuggerNonUserCode]
		public SuggestionAddedNotification(SuggestionAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.suggestion_ = ((other.suggestion_ != null) ? other.suggestion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x00257DF4 File Offset: 0x00255FF4
		[DebuggerNonUserCode]
		public SuggestionAddedNotification Clone()
		{
			return new SuggestionAddedNotification(this);
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00257E0C File Offset: 0x0025600C
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x00257E24 File Offset: 0x00256024
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

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x00257E30 File Offset: 0x00256030
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x00257E48 File Offset: 0x00256048
		[DebuggerNonUserCode]
		public GameAccountHandle SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x00257E54 File Offset: 0x00256054
		// (set) Token: 0x06009AAD RID: 39597 RVA: 0x00257E6C File Offset: 0x0025606C
		[DebuggerNonUserCode]
		public Suggestion Suggestion
		{
			get
			{
				return this.suggestion_;
			}
			set
			{
				this.suggestion_ = value;
			}
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00257E78 File Offset: 0x00256078
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuggestionAddedNotification);
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x00257E98 File Offset: 0x00256098
		[DebuggerNonUserCode]
		public bool Equals(SuggestionAddedNotification other)
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
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Suggestion, other.Suggestion);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x00257F30 File Offset: 0x00256130
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag3 = this.suggestion_ != null;
			if (flag3)
			{
				num ^= this.Suggestion.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x00257FB8 File Offset: 0x002561B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00257FD0 File Offset: 0x002561D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00257FDC File Offset: 0x002561DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag3 = this.suggestion_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Suggestion);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x00258078 File Offset: 0x00256278
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag3 = this.suggestion_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestion);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x0025810C File Offset: 0x0025630C
		[DebuggerNonUserCode]
		public void MergeFrom(SuggestionAddedNotification other)
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
				bool flag4 = other.subscriberId_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriberId_ == null;
					if (flag5)
					{
						this.SubscriberId = new GameAccountHandle();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				bool flag6 = other.suggestion_ != null;
				if (flag6)
				{
					bool flag7 = this.suggestion_ == null;
					if (flag7)
					{
						this.Suggestion = new Suggestion();
					}
					this.Suggestion.MergeFrom(other.Suggestion);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x002581F9 File Offset: 0x002563F9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x00258204 File Offset: 0x00256404
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
							bool flag = this.suggestion_ == null;
							if (flag)
							{
								this.Suggestion = new Suggestion();
							}
							input.ReadMessage(this.Suggestion);
						}
					}
					else
					{
						bool flag2 = this.subscriberId_ == null;
						if (flag2)
						{
							this.SubscriberId = new GameAccountHandle();
						}
						input.ReadMessage(this.SubscriberId);
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

		// Token: 0x04004585 RID: 17797
		private static readonly MessageParser<SuggestionAddedNotification> _parser = new MessageParser<SuggestionAddedNotification>(() => new SuggestionAddedNotification());

		// Token: 0x04004586 RID: 17798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004587 RID: 17799
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004588 RID: 17800
		private GameAccountHandle agentId_;

		// Token: 0x04004589 RID: 17801
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400458A RID: 17802
		private GameAccountHandle subscriberId_;

		// Token: 0x0400458B RID: 17803
		public const int SuggestionFieldNumber = 3;

		// Token: 0x0400458C RID: 17804
		private Suggestion suggestion_;
	}
}
