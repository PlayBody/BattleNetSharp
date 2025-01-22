using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F5 RID: 1013
	public sealed class QueueMatchmakingResponse : IMessage<QueueMatchmakingResponse>, IMessage, IEquatable<QueueMatchmakingResponse>, IDeepCloneable<QueueMatchmakingResponse>, IBufferMessage
	{
		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06006490 RID: 25744 RVA: 0x00184DC8 File Offset: 0x00182FC8
		[DebuggerNonUserCode]
		public static MessageParser<QueueMatchmakingResponse> Parser
		{
			get
			{
				return QueueMatchmakingResponse._parser;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x00184DE0 File Offset: 0x00182FE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06006492 RID: 25746 RVA: 0x00184E04 File Offset: 0x00183004
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueMatchmakingResponse.Descriptor;
			}
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00184E1B File Offset: 0x0018301B
		[DebuggerNonUserCode]
		public QueueMatchmakingResponse()
		{
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00184E25 File Offset: 0x00183025
		[DebuggerNonUserCode]
		public QueueMatchmakingResponse(QueueMatchmakingResponse other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00184E5C File Offset: 0x0018305C
		[DebuggerNonUserCode]
		public QueueMatchmakingResponse Clone()
		{
			return new QueueMatchmakingResponse(this);
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006496 RID: 25750 RVA: 0x00184E74 File Offset: 0x00183074
		// (set) Token: 0x06006497 RID: 25751 RVA: 0x00184E8C File Offset: 0x0018308C
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

		// Token: 0x06006498 RID: 25752 RVA: 0x00184E98 File Offset: 0x00183098
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueMatchmakingResponse);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00184EB8 File Offset: 0x001830B8
		[DebuggerNonUserCode]
		public bool Equals(QueueMatchmakingResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00184F14 File Offset: 0x00183114
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num ^= this.RequestId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00184F64 File Offset: 0x00183164
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00184F7C File Offset: 0x0018317C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00184F88 File Offset: 0x00183188
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00184FD8 File Offset: 0x001831D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x0018502C File Offset: 0x0018322C
		[DebuggerNonUserCode]
		public void MergeFrom(QueueMatchmakingResponse other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00185098 File Offset: 0x00183298
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x001850A4 File Offset: 0x001832A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.requestId_ == null;
					if (flag)
					{
						this.RequestId = new RequestId();
					}
					input.ReadMessage(this.RequestId);
				}
			}
		}

		// Token: 0x04002DCA RID: 11722
		private static readonly MessageParser<QueueMatchmakingResponse> _parser = new MessageParser<QueueMatchmakingResponse>(() => new QueueMatchmakingResponse());

		// Token: 0x04002DCB RID: 11723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DCC RID: 11724
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002DCD RID: 11725
		private RequestId requestId_;
	}
}
