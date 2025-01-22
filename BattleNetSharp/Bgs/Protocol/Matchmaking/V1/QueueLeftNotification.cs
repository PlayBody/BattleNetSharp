using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FC RID: 1020
	public sealed class QueueLeftNotification : IMessage<QueueLeftNotification>, IMessage, IEquatable<QueueLeftNotification>, IDeepCloneable<QueueLeftNotification>, IBufferMessage
	{
		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600652C RID: 25900 RVA: 0x00186F98 File Offset: 0x00185198
		[DebuggerNonUserCode]
		public static MessageParser<QueueLeftNotification> Parser
		{
			get
			{
				return QueueLeftNotification._parser;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x00186FB0 File Offset: 0x001851B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x00186FD4 File Offset: 0x001851D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueLeftNotification.Descriptor;
			}
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00186FEB File Offset: 0x001851EB
		[DebuggerNonUserCode]
		public QueueLeftNotification()
		{
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00187000 File Offset: 0x00185200
		[DebuggerNonUserCode]
		public QueueLeftNotification(QueueLeftNotification other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.gameAccount_ = other.gameAccount_.Clone();
			this.cancelInitiator_ = ((other.cancelInitiator_ != null) ? other.cancelInitiator_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00187070 File Offset: 0x00185270
		[DebuggerNonUserCode]
		public QueueLeftNotification Clone()
		{
			return new QueueLeftNotification(this);
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006532 RID: 25906 RVA: 0x00187088 File Offset: 0x00185288
		// (set) Token: 0x06006533 RID: 25907 RVA: 0x001870A0 File Offset: 0x001852A0
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

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006534 RID: 25908 RVA: 0x001870AC File Offset: 0x001852AC
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06006535 RID: 25909 RVA: 0x001870C4 File Offset: 0x001852C4
		// (set) Token: 0x06006536 RID: 25910 RVA: 0x001870DC File Offset: 0x001852DC
		[DebuggerNonUserCode]
		public GameAccountHandle CancelInitiator
		{
			get
			{
				return this.cancelInitiator_;
			}
			set
			{
				this.cancelInitiator_ = value;
			}
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x001870E8 File Offset: 0x001852E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueLeftNotification);
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00187108 File Offset: 0x00185308
		[DebuggerNonUserCode]
		public bool Equals(QueueLeftNotification other)
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
						bool flag5 = !this.gameAccount_.Equals(other.gameAccount_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.CancelInitiator, other.CancelInitiator);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x001871A0 File Offset: 0x001853A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num ^= this.RequestId.GetHashCode();
			}
			num ^= this.gameAccount_.GetHashCode();
			bool flag2 = this.cancelInitiator_ != null;
			if (flag2)
			{
				num ^= this.CancelInitiator.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00187218 File Offset: 0x00185418
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x00187230 File Offset: 0x00185430
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0018723C File Offset: 0x0018543C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			this.gameAccount_.WriteTo(ref output, QueueLeftNotification._repeated_gameAccount_codec);
			bool flag2 = this.cancelInitiator_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CancelInitiator);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x001872C4 File Offset: 0x001854C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			num += this.gameAccount_.CalculateSize(QueueLeftNotification._repeated_gameAccount_codec);
			bool flag2 = this.cancelInitiator_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CancelInitiator);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x0018734C File Offset: 0x0018554C
		[DebuggerNonUserCode]
		public void MergeFrom(QueueLeftNotification other)
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
				this.gameAccount_.Add(other.gameAccount_);
				bool flag4 = other.cancelInitiator_ != null;
				if (flag4)
				{
					bool flag5 = this.cancelInitiator_ == null;
					if (flag5)
					{
						this.CancelInitiator = new GameAccountHandle();
					}
					this.CancelInitiator.MergeFrom(other.CancelInitiator);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x0018740B File Offset: 0x0018560B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x00187418 File Offset: 0x00185618
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
							bool flag = this.cancelInitiator_ == null;
							if (flag)
							{
								this.CancelInitiator = new GameAccountHandle();
							}
							input.ReadMessage(this.CancelInitiator);
						}
					}
					else
					{
						this.gameAccount_.AddEntriesFrom(ref input, QueueLeftNotification._repeated_gameAccount_codec);
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

		// Token: 0x04002E00 RID: 11776
		private static readonly MessageParser<QueueLeftNotification> _parser = new MessageParser<QueueLeftNotification>(() => new QueueLeftNotification());

		// Token: 0x04002E01 RID: 11777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E02 RID: 11778
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002E03 RID: 11779
		private RequestId requestId_;

		// Token: 0x04002E04 RID: 11780
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04002E05 RID: 11781
		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(18U, GameAccountHandle.Parser);

		// Token: 0x04002E06 RID: 11782
		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x04002E07 RID: 11783
		public const int CancelInitiatorFieldNumber = 3;

		// Token: 0x04002E08 RID: 11784
		private GameAccountHandle cancelInitiator_;
	}
}
