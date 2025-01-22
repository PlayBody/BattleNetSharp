using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x02000129 RID: 297
	public sealed class QuestCallbackUpdateMessage : IMessage<QuestCallbackUpdateMessage>, IMessage, IEquatable<QuestCallbackUpdateMessage>, IDeepCloneable<QuestCallbackUpdateMessage>, IBufferMessage
	{
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00071634 File Offset: 0x0006F834
		[DebuggerNonUserCode]
		public static MessageParser<QuestCallbackUpdateMessage> Parser
		{
			get
			{
				return QuestCallbackUpdateMessage._parser;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0007164C File Offset: 0x0006F84C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00071670 File Offset: 0x0006F870
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestCallbackUpdateMessage.Descriptor;
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00071687 File Offset: 0x0006F887
		[DebuggerNonUserCode]
		public QuestCallbackUpdateMessage()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00071694 File Offset: 0x0006F894
		[DebuggerNonUserCode]
		public QuestCallbackUpdateMessage(QuestCallbackUpdateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.questId_ = other.questId_;
			this.callbackId_ = other.callbackId_;
			this.current_ = other.current_;
			this.completed_ = other.completed_;
			this.failure_ = other.failure_;
			this.isQuestGizmoCompletion_ = other.isQuestGizmoCompletion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00071710 File Offset: 0x0006F910
		[DebuggerNonUserCode]
		public QuestCallbackUpdateMessage Clone()
		{
			return new QuestCallbackUpdateMessage(this);
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00071728 File Offset: 0x0006F928
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00071759 File Offset: 0x0006F959
		[DebuggerNonUserCode]
		public int QuestId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int questIdDefaultValue;
				if (flag)
				{
					questIdDefaultValue = this.questId_;
				}
				else
				{
					questIdDefaultValue = QuestCallbackUpdateMessage.QuestIdDefaultValue;
				}
				return questIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.questId_ = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00071774 File Offset: 0x0006F974
		[DebuggerNonUserCode]
		public bool HasQuestId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00071791 File Offset: 0x0006F991
		[DebuggerNonUserCode]
		public void ClearQuestId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000717A4 File Offset: 0x0006F9A4
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x000717D5 File Offset: 0x0006F9D5
		[DebuggerNonUserCode]
		public int CallbackId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int callbackIdDefaultValue;
				if (flag)
				{
					callbackIdDefaultValue = this.callbackId_;
				}
				else
				{
					callbackIdDefaultValue = QuestCallbackUpdateMessage.CallbackIdDefaultValue;
				}
				return callbackIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.callbackId_ = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000717F0 File Offset: 0x0006F9F0
		[DebuggerNonUserCode]
		public bool HasCallbackId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0007180D File Offset: 0x0006FA0D
		[DebuggerNonUserCode]
		public void ClearCallbackId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00071820 File Offset: 0x0006FA20
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00071851 File Offset: 0x0006FA51
		[DebuggerNonUserCode]
		public int Current
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int currentDefaultValue;
				if (flag)
				{
					currentDefaultValue = this.current_;
				}
				else
				{
					currentDefaultValue = QuestCallbackUpdateMessage.CurrentDefaultValue;
				}
				return currentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.current_ = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0007186C File Offset: 0x0006FA6C
		[DebuggerNonUserCode]
		public bool HasCurrent
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00071889 File Offset: 0x0006FA89
		[DebuggerNonUserCode]
		public void ClearCurrent()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0007189C File Offset: 0x0006FA9C
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x000718CD File Offset: 0x0006FACD
		[DebuggerNonUserCode]
		public bool Completed
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool completedDefaultValue;
				if (flag)
				{
					completedDefaultValue = this.completed_;
				}
				else
				{
					completedDefaultValue = QuestCallbackUpdateMessage.CompletedDefaultValue;
				}
				return completedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.completed_ = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000718E8 File Offset: 0x0006FAE8
		[DebuggerNonUserCode]
		public bool HasCompleted
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00071905 File Offset: 0x0006FB05
		[DebuggerNonUserCode]
		public void ClearCompleted()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00071918 File Offset: 0x0006FB18
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0007194A File Offset: 0x0006FB4A
		[DebuggerNonUserCode]
		public bool Failure
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool failureDefaultValue;
				if (flag)
				{
					failureDefaultValue = this.failure_;
				}
				else
				{
					failureDefaultValue = QuestCallbackUpdateMessage.FailureDefaultValue;
				}
				return failureDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.failure_ = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00071964 File Offset: 0x0006FB64
		[DebuggerNonUserCode]
		public bool HasFailure
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00071982 File Offset: 0x0006FB82
		[DebuggerNonUserCode]
		public void ClearFailure()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00071994 File Offset: 0x0006FB94
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x000719C6 File Offset: 0x0006FBC6
		[DebuggerNonUserCode]
		public bool IsQuestGizmoCompletion
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool isQuestGizmoCompletionDefaultValue;
				if (flag)
				{
					isQuestGizmoCompletionDefaultValue = this.isQuestGizmoCompletion_;
				}
				else
				{
					isQuestGizmoCompletionDefaultValue = QuestCallbackUpdateMessage.IsQuestGizmoCompletionDefaultValue;
				}
				return isQuestGizmoCompletionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.isQuestGizmoCompletion_ = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000719E0 File Offset: 0x0006FBE0
		[DebuggerNonUserCode]
		public bool HasIsQuestGizmoCompletion
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000719FE File Offset: 0x0006FBFE
		[DebuggerNonUserCode]
		public void ClearIsQuestGizmoCompletion()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00071A10 File Offset: 0x0006FC10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestCallbackUpdateMessage);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00071A30 File Offset: 0x0006FC30
		[DebuggerNonUserCode]
		public bool Equals(QuestCallbackUpdateMessage other)
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
					bool flag4 = this.QuestId != other.QuestId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CallbackId != other.CallbackId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Current != other.Current;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Completed != other.Completed;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Failure != other.Failure;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.IsQuestGizmoCompletion != other.IsQuestGizmoCompletion;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00071B1C File Offset: 0x0006FD1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num ^= this.QuestId.GetHashCode();
			}
			bool hasCallbackId = this.HasCallbackId;
			if (hasCallbackId)
			{
				num ^= this.CallbackId.GetHashCode();
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				int num2 = num;
				int num3 = this.Current;
				num = num2 ^ num3.GetHashCode();
			}
			bool hasCompleted = this.HasCompleted;
			if (hasCompleted)
			{
				num ^= this.Completed.GetHashCode();
			}
			bool hasFailure = this.HasFailure;
			if (hasFailure)
			{
				num ^= this.Failure.GetHashCode();
			}
			bool hasIsQuestGizmoCompletion = this.HasIsQuestGizmoCompletion;
			if (hasIsQuestGizmoCompletion)
			{
				num ^= this.IsQuestGizmoCompletion.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00071C00 File Offset: 0x0006FE00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00071C18 File Offset: 0x0006FE18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00071C24 File Offset: 0x0006FE24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			bool hasCallbackId = this.HasCallbackId;
			if (hasCallbackId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CallbackId);
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Current);
			}
			bool hasCompleted = this.HasCompleted;
			if (hasCompleted)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Completed);
			}
			bool hasFailure = this.HasFailure;
			if (hasFailure)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Failure);
			}
			bool hasIsQuestGizmoCompletion = this.HasIsQuestGizmoCompletion;
			if (hasIsQuestGizmoCompletion)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsQuestGizmoCompletion);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00071D20 File Offset: 0x0006FF20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			bool hasCallbackId = this.HasCallbackId;
			if (hasCallbackId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CallbackId);
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			bool hasCompleted = this.HasCompleted;
			if (hasCompleted)
			{
				num += 2;
			}
			bool hasFailure = this.HasFailure;
			if (hasFailure)
			{
				num += 2;
			}
			bool hasIsQuestGizmoCompletion = this.HasIsQuestGizmoCompletion;
			if (hasIsQuestGizmoCompletion)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		[DebuggerNonUserCode]
		public void MergeFrom(QuestCallbackUpdateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasQuestId = other.HasQuestId;
				if (hasQuestId)
				{
					this.QuestId = other.QuestId;
				}
				bool hasCallbackId = other.HasCallbackId;
				if (hasCallbackId)
				{
					this.CallbackId = other.CallbackId;
				}
				bool hasCurrent = other.HasCurrent;
				if (hasCurrent)
				{
					this.Current = other.Current;
				}
				bool hasCompleted = other.HasCompleted;
				if (hasCompleted)
				{
					this.Completed = other.Completed;
				}
				bool hasFailure = other.HasFailure;
				if (hasFailure)
				{
					this.Failure = other.Failure;
				}
				bool hasIsQuestGizmoCompletion = other.HasIsQuestGizmoCompletion;
				if (hasIsQuestGizmoCompletion)
				{
					this.IsQuestGizmoCompletion = other.IsQuestGizmoCompletion;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00071EAF File Offset: 0x000700AF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00071EBC File Offset: 0x000700BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.Current = input.ReadInt32();
						}
						else
						{
							this.CallbackId = input.ReadInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.IsQuestGizmoCompletion = input.ReadBool();
					}
					else
					{
						this.Failure = input.ReadBool();
					}
				}
				else
				{
					this.Completed = input.ReadBool();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly MessageParser<QuestCallbackUpdateMessage> _parser = new MessageParser<QuestCallbackUpdateMessage>(() => new QuestCallbackUpdateMessage());

		// Token: 0x04000CA1 RID: 3233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CA2 RID: 3234
		private int _hasBits0;

		// Token: 0x04000CA3 RID: 3235
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000CA4 RID: 3236
		private static readonly int QuestIdDefaultValue = 0;

		// Token: 0x04000CA5 RID: 3237
		private int questId_;

		// Token: 0x04000CA6 RID: 3238
		public const int CallbackIdFieldNumber = 2;

		// Token: 0x04000CA7 RID: 3239
		private static readonly int CallbackIdDefaultValue = 0;

		// Token: 0x04000CA8 RID: 3240
		private int callbackId_;

		// Token: 0x04000CA9 RID: 3241
		public const int CurrentFieldNumber = 3;

		// Token: 0x04000CAA RID: 3242
		private static readonly int CurrentDefaultValue = 0;

		// Token: 0x04000CAB RID: 3243
		private int current_;

		// Token: 0x04000CAC RID: 3244
		public const int CompletedFieldNumber = 4;

		// Token: 0x04000CAD RID: 3245
		private static readonly bool CompletedDefaultValue = false;

		// Token: 0x04000CAE RID: 3246
		private bool completed_;

		// Token: 0x04000CAF RID: 3247
		public const int FailureFieldNumber = 5;

		// Token: 0x04000CB0 RID: 3248
		private static readonly bool FailureDefaultValue = false;

		// Token: 0x04000CB1 RID: 3249
		private bool failure_;

		// Token: 0x04000CB2 RID: 3250
		public const int IsQuestGizmoCompletionFieldNumber = 6;

		// Token: 0x04000CB3 RID: 3251
		private static readonly bool IsQuestGizmoCompletionDefaultValue = false;

		// Token: 0x04000CB4 RID: 3252
		private bool isQuestGizmoCompletion_;
	}
}
