using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C3 RID: 1731
	public sealed class SuggestionAddedNotification : IMessage<SuggestionAddedNotification>, IMessage, IEquatable<SuggestionAddedNotification>, IDeepCloneable<SuggestionAddedNotification>, IBufferMessage
	{
		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x06009FFB RID: 40955 RVA: 0x0026E4F8 File Offset: 0x0026C6F8
		[DebuggerNonUserCode]
		public static MessageParser<SuggestionAddedNotification> Parser
		{
			get
			{
				return SuggestionAddedNotification._parser;
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x06009FFC RID: 40956 RVA: 0x0026E510 File Offset: 0x0026C710
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x0026E534 File Offset: 0x0026C734
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuggestionAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x0026E54B File Offset: 0x0026C74B
		[DebuggerNonUserCode]
		public SuggestionAddedNotification()
		{
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x0026E558 File Offset: 0x0026C758
		[DebuggerNonUserCode]
		public SuggestionAddedNotification(SuggestionAddedNotification other)
			: this()
		{
			this.suggestion_ = ((other.suggestion_ != null) ? other.suggestion_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x0026E5B8 File Offset: 0x0026C7B8
		[DebuggerNonUserCode]
		public SuggestionAddedNotification Clone()
		{
			return new SuggestionAddedNotification(this);
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x0026E5D0 File Offset: 0x0026C7D0
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x0026E5E8 File Offset: 0x0026C7E8
		[DebuggerNonUserCode]
		public InvitationSuggestion Suggestion
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

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x0026E5F4 File Offset: 0x0026C7F4
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x0026E60C File Offset: 0x0026C80C
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x0026E618 File Offset: 0x0026C818
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuggestionAddedNotification);
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x0026E638 File Offset: 0x0026C838
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
					bool flag4 = !object.Equals(this.Suggestion, other.Suggestion);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Subscriber, other.Subscriber);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x0026E6B0 File Offset: 0x0026C8B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				num ^= this.Suggestion.GetHashCode();
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x0026E71C File Offset: 0x0026C91C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x0026E734 File Offset: 0x0026C934
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x0026E740 File Offset: 0x0026C940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Suggestion);
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Subscriber);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x0026E7B4 File Offset: 0x0026C9B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestion);
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x0026E828 File Offset: 0x0026CA28
		[DebuggerNonUserCode]
		public void MergeFrom(SuggestionAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.suggestion_ != null;
				if (flag2)
				{
					bool flag3 = this.suggestion_ == null;
					if (flag3)
					{
						this.Suggestion = new InvitationSuggestion();
					}
					this.Suggestion.MergeFrom(other.Suggestion);
				}
				bool flag4 = other.subscriber_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriber_ == null;
					if (flag5)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x0026E8D5 File Offset: 0x0026CAD5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x0026E8E0 File Offset: 0x0026CAE0
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
						bool flag = this.subscriber_ == null;
						if (flag)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
					}
				}
				else
				{
					bool flag2 = this.suggestion_ == null;
					if (flag2)
					{
						this.Suggestion = new InvitationSuggestion();
					}
					input.ReadMessage(this.Suggestion);
				}
			}
		}

		// Token: 0x0400480F RID: 18447
		private static readonly MessageParser<SuggestionAddedNotification> _parser = new MessageParser<SuggestionAddedNotification>(() => new SuggestionAddedNotification());

		// Token: 0x04004810 RID: 18448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004811 RID: 18449
		public const int SuggestionFieldNumber = 1;

		// Token: 0x04004812 RID: 18450
		private InvitationSuggestion suggestion_;

		// Token: 0x04004813 RID: 18451
		public const int SubscriberFieldNumber = 2;

		// Token: 0x04004814 RID: 18452
		private Identity subscriber_;
	}
}
