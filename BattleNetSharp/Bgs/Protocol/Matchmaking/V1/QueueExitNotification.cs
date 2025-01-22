using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FB RID: 1019
	public sealed class QueueExitNotification : IMessage<QueueExitNotification>, IMessage, IEquatable<QueueExitNotification>, IDeepCloneable<QueueExitNotification>, IBufferMessage
	{
		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x00186AEC File Offset: 0x00184CEC
		[DebuggerNonUserCode]
		public static MessageParser<QueueExitNotification> Parser
		{
			get
			{
				return QueueExitNotification._parser;
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x00186B04 File Offset: 0x00184D04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x00186B28 File Offset: 0x00184D28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueExitNotification.Descriptor;
			}
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x00186B3F File Offset: 0x00184D3F
		[DebuggerNonUserCode]
		public QueueExitNotification()
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00186B4C File Offset: 0x00184D4C
		[DebuggerNonUserCode]
		public QueueExitNotification(QueueExitNotification other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.cancelInitiator_ = ((other.cancelInitiator_ != null) ? other.cancelInitiator_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00186BAC File Offset: 0x00184DAC
		[DebuggerNonUserCode]
		public QueueExitNotification Clone()
		{
			return new QueueExitNotification(this);
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x00186BC4 File Offset: 0x00184DC4
		// (set) Token: 0x0600651E RID: 25886 RVA: 0x00186BDC File Offset: 0x00184DDC
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

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x00186BE8 File Offset: 0x00184DE8
		// (set) Token: 0x06006520 RID: 25888 RVA: 0x00186C00 File Offset: 0x00184E00
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

		// Token: 0x06006521 RID: 25889 RVA: 0x00186C0C File Offset: 0x00184E0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueExitNotification);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x00186C2C File Offset: 0x00184E2C
		[DebuggerNonUserCode]
		public bool Equals(QueueExitNotification other)
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
						bool flag5 = !object.Equals(this.CancelInitiator, other.CancelInitiator);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x00186CA4 File Offset: 0x00184EA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num ^= this.RequestId.GetHashCode();
			}
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

		// Token: 0x06006524 RID: 25892 RVA: 0x00186D10 File Offset: 0x00184F10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x00186D28 File Offset: 0x00184F28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x00186D34 File Offset: 0x00184F34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			bool flag2 = this.cancelInitiator_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CancelInitiator);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x00186DA8 File Offset: 0x00184FA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
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

		// Token: 0x06006528 RID: 25896 RVA: 0x00186E1C File Offset: 0x0018501C
		[DebuggerNonUserCode]
		public void MergeFrom(QueueExitNotification other)
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

		// Token: 0x06006529 RID: 25897 RVA: 0x00186EC9 File Offset: 0x001850C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x00186ED4 File Offset: 0x001850D4
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
					bool flag2 = this.requestId_ == null;
					if (flag2)
					{
						this.RequestId = new RequestId();
					}
					input.ReadMessage(this.RequestId);
				}
			}
		}

		// Token: 0x04002DFA RID: 11770
		private static readonly MessageParser<QueueExitNotification> _parser = new MessageParser<QueueExitNotification>(() => new QueueExitNotification());

		// Token: 0x04002DFB RID: 11771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFC RID: 11772
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002DFD RID: 11773
		private RequestId requestId_;

		// Token: 0x04002DFE RID: 11774
		public const int CancelInitiatorFieldNumber = 2;

		// Token: 0x04002DFF RID: 11775
		private GameAccountHandle cancelInitiator_;
	}
}
