using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FD RID: 1021
	public sealed class QueueUpdateNotification : IMessage<QueueUpdateNotification>, IMessage, IEquatable<QueueUpdateNotification>, IDeepCloneable<QueueUpdateNotification>, IBufferMessage
	{
		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x00187508 File Offset: 0x00185708
		[DebuggerNonUserCode]
		public static MessageParser<QueueUpdateNotification> Parser
		{
			get
			{
				return QueueUpdateNotification._parser;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x00187520 File Offset: 0x00185720
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x00187544 File Offset: 0x00185744
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueUpdateNotification.Descriptor;
			}
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x0018755B File Offset: 0x0018575B
		[DebuggerNonUserCode]
		public QueueUpdateNotification()
		{
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00187568 File Offset: 0x00185768
		[DebuggerNonUserCode]
		public QueueUpdateNotification(QueueUpdateNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.waitTimes_ = ((other.waitTimes_ != null) ? other.waitTimes_.Clone() : null);
			this.isMatchmaking_ = other.isMatchmaking_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x001875E0 File Offset: 0x001857E0
		[DebuggerNonUserCode]
		public QueueUpdateNotification Clone()
		{
			return new QueueUpdateNotification(this);
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x001875F8 File Offset: 0x001857F8
		// (set) Token: 0x06006549 RID: 25929 RVA: 0x00187610 File Offset: 0x00185810
		[DebuggerNonUserCode]
		public RequestId RequestId
		{
			get
			{
				return this.requestId_;
			}
			set
			{
				this.requestId_ = value;
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x0018761C File Offset: 0x0018581C
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x00187634 File Offset: 0x00185834
		[DebuggerNonUserCode]
		public QueueWaitTimes WaitTimes
		{
			get
			{
				return this.waitTimes_;
			}
			set
			{
				this.waitTimes_ = value;
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x00187640 File Offset: 0x00185840
		// (set) Token: 0x0600654D RID: 25933 RVA: 0x00187671 File Offset: 0x00185871
		[DebuggerNonUserCode]
		public bool IsMatchmaking
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isMatchmakingDefaultValue;
				if (flag)
				{
					isMatchmakingDefaultValue = this.isMatchmaking_;
				}
				else
				{
					isMatchmakingDefaultValue = QueueUpdateNotification.IsMatchmakingDefaultValue;
				}
				return isMatchmakingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isMatchmaking_ = value;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600654E RID: 25934 RVA: 0x0018768C File Offset: 0x0018588C
		[DebuggerNonUserCode]
		public bool HasIsMatchmaking
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x001876A9 File Offset: 0x001858A9
		[DebuggerNonUserCode]
		public void ClearIsMatchmaking()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x001876BC File Offset: 0x001858BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueUpdateNotification);
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x001876DC File Offset: 0x001858DC
		[DebuggerNonUserCode]
		public bool Equals(QueueUpdateNotification other)
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
					bool flag4 = !object.Equals(this.RequestId, other.RequestId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.WaitTimes, other.WaitTimes);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsMatchmaking != other.IsMatchmaking;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00187770 File Offset: 0x00185970
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num ^= this.RequestId.GetHashCode();
			}
			bool flag2 = this.waitTimes_ != null;
			if (flag2)
			{
				num ^= this.WaitTimes.GetHashCode();
			}
			bool hasIsMatchmaking = this.HasIsMatchmaking;
			if (hasIsMatchmaking)
			{
				num ^= this.IsMatchmaking.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x001877F8 File Offset: 0x001859F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00187810 File Offset: 0x00185A10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x0018781C File Offset: 0x00185A1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			bool flag2 = this.waitTimes_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WaitTimes);
			}
			bool hasIsMatchmaking = this.HasIsMatchmaking;
			if (hasIsMatchmaking)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsMatchmaking);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x001878B4 File Offset: 0x00185AB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			bool flag2 = this.waitTimes_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WaitTimes);
			}
			bool hasIsMatchmaking = this.HasIsMatchmaking;
			if (hasIsMatchmaking)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00187938 File Offset: 0x00185B38
		[DebuggerNonUserCode]
		public void MergeFrom(QueueUpdateNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.requestId_ != null;
				if (flag2)
				{
					bool flag3 = this.requestId_ == null;
					if (flag3)
					{
						this.RequestId = new RequestId();
					}
					this.RequestId.MergeFrom(other.RequestId);
				}
				bool flag4 = other.waitTimes_ != null;
				if (flag4)
				{
					bool flag5 = this.waitTimes_ == null;
					if (flag5)
					{
						this.WaitTimes = new QueueWaitTimes();
					}
					this.WaitTimes.MergeFrom(other.WaitTimes);
				}
				bool hasIsMatchmaking = other.HasIsMatchmaking;
				if (hasIsMatchmaking)
				{
					this.IsMatchmaking = other.IsMatchmaking;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x00187A00 File Offset: 0x00185C00
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00187A0C File Offset: 0x00185C0C
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
							this.IsMatchmaking = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.waitTimes_ == null;
						if (flag)
						{
							this.WaitTimes = new QueueWaitTimes();
						}
						input.ReadMessage(this.WaitTimes);
					}
				}
				else
				{
					bool flag2 = this.requestId_ == null;
					if (flag2)
					{
						this.RequestId = new RequestId();
					}
					input.ReadMessage(this.RequestId);
				}
			}
		}

		// Token: 0x04002E09 RID: 11785
		private static readonly MessageParser<QueueUpdateNotification> _parser = new MessageParser<QueueUpdateNotification>(() => new QueueUpdateNotification());

		// Token: 0x04002E0A RID: 11786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E0B RID: 11787
		private int _hasBits0;

		// Token: 0x04002E0C RID: 11788
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002E0D RID: 11789
		private RequestId requestId_;

		// Token: 0x04002E0E RID: 11790
		public const int WaitTimesFieldNumber = 2;

		// Token: 0x04002E0F RID: 11791
		private QueueWaitTimes waitTimes_;

		// Token: 0x04002E10 RID: 11792
		public const int IsMatchmakingFieldNumber = 3;

		// Token: 0x04002E11 RID: 11793
		private static readonly bool IsMatchmakingDefaultValue = false;

		// Token: 0x04002E12 RID: 11794
		private bool isMatchmaking_;
	}
}
