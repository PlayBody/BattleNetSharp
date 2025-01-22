using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FA RID: 1018
	public sealed class QueueEntryNotification : IMessage<QueueEntryNotification>, IMessage, IEquatable<QueueEntryNotification>, IDeepCloneable<QueueEntryNotification>, IBufferMessage
	{
		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x00186434 File Offset: 0x00184634
		[DebuggerNonUserCode]
		public static MessageParser<QueueEntryNotification> Parser
		{
			get
			{
				return QueueEntryNotification._parser;
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06006500 RID: 25856 RVA: 0x0018644C File Offset: 0x0018464C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x00186470 File Offset: 0x00184670
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueEntryNotification.Descriptor;
			}
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x00186487 File Offset: 0x00184687
		[DebuggerNonUserCode]
		public QueueEntryNotification()
		{
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x0018649C File Offset: 0x0018469C
		[DebuggerNonUserCode]
		public QueueEntryNotification(QueueEntryNotification other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.waitTimes_ = ((other.waitTimes_ != null) ? other.waitTimes_.Clone() : null);
			this.member_ = other.member_.Clone();
			this.requestInitiator_ = ((other.requestInitiator_ != null) ? other.requestInitiator_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00186528 File Offset: 0x00184728
		[DebuggerNonUserCode]
		public QueueEntryNotification Clone()
		{
			return new QueueEntryNotification(this);
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x00186540 File Offset: 0x00184740
		// (set) Token: 0x06006506 RID: 25862 RVA: 0x00186558 File Offset: 0x00184758
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

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x00186564 File Offset: 0x00184764
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x0018657C File Offset: 0x0018477C
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x00186588 File Offset: 0x00184788
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x001865A0 File Offset: 0x001847A0
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x001865B8 File Offset: 0x001847B8
		[DebuggerNonUserCode]
		public GameAccountHandle RequestInitiator
		{
			get
			{
				return this.requestInitiator_;
			}
			set
			{
				this.requestInitiator_ = value;
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x001865C4 File Offset: 0x001847C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueEntryNotification);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x001865E4 File Offset: 0x001847E4
		[DebuggerNonUserCode]
		public bool Equals(QueueEntryNotification other)
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
							bool flag6 = !this.member_.Equals(other.member_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.RequestInitiator, other.RequestInitiator);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x001866A0 File Offset: 0x001848A0
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
			num ^= this.member_.GetHashCode();
			bool flag3 = this.requestInitiator_ != null;
			if (flag3)
			{
				num ^= this.RequestInitiator.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00186738 File Offset: 0x00184938
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00186750 File Offset: 0x00184950
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x0018675C File Offset: 0x0018495C
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
			this.member_.WriteTo(ref output, QueueEntryNotification._repeated_member_codec);
			bool flag3 = this.requestInitiator_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RequestInitiator);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x00186808 File Offset: 0x00184A08
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
			num += this.member_.CalculateSize(QueueEntryNotification._repeated_member_codec);
			bool flag3 = this.requestInitiator_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestInitiator);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x001868B0 File Offset: 0x00184AB0
		[DebuggerNonUserCode]
		public void MergeFrom(QueueEntryNotification other)
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
				this.member_.Add(other.member_);
				bool flag6 = other.requestInitiator_ != null;
				if (flag6)
				{
					bool flag7 = this.requestInitiator_ == null;
					if (flag7)
					{
						this.RequestInitiator = new GameAccountHandle();
					}
					this.RequestInitiator.MergeFrom(other.RequestInitiator);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x001869AF File Offset: 0x00184BAF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x001869BC File Offset: 0x00184BBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.waitTimes_ == null;
						if (flag)
						{
							this.WaitTimes = new QueueWaitTimes();
						}
						input.ReadMessage(this.WaitTimes);
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
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.requestInitiator_ == null;
					if (flag3)
					{
						this.RequestInitiator = new GameAccountHandle();
					}
					input.ReadMessage(this.RequestInitiator);
				}
				else
				{
					this.member_.AddEntriesFrom(ref input, QueueEntryNotification._repeated_member_codec);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002DEF RID: 11759
		private static readonly MessageParser<QueueEntryNotification> _parser = new MessageParser<QueueEntryNotification>(() => new QueueEntryNotification());

		// Token: 0x04002DF0 RID: 11760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DF1 RID: 11761
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002DF2 RID: 11762
		private RequestId requestId_;

		// Token: 0x04002DF3 RID: 11763
		public const int WaitTimesFieldNumber = 2;

		// Token: 0x04002DF4 RID: 11764
		private QueueWaitTimes waitTimes_;

		// Token: 0x04002DF5 RID: 11765
		public const int MemberFieldNumber = 3;

		// Token: 0x04002DF6 RID: 11766
		private static readonly FieldCodec<GameAccountHandle> _repeated_member_codec = FieldCodec.ForMessage<GameAccountHandle>(26U, GameAccountHandle.Parser);

		// Token: 0x04002DF7 RID: 11767
		private readonly RepeatedField<GameAccountHandle> member_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x04002DF8 RID: 11768
		public const int RequestInitiatorFieldNumber = 4;

		// Token: 0x04002DF9 RID: 11769
		private GameAccountHandle requestInitiator_;
	}
}
