using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F7 RID: 1015
	public sealed class JoinGameResponse : IMessage<JoinGameResponse>, IMessage, IEquatable<JoinGameResponse>, IDeepCloneable<JoinGameResponse>, IBufferMessage
	{
		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x060064B7 RID: 25783 RVA: 0x00185564 File Offset: 0x00183764
		[DebuggerNonUserCode]
		public static MessageParser<JoinGameResponse> Parser
		{
			get
			{
				return JoinGameResponse._parser;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x0018557C File Offset: 0x0018377C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x060064B9 RID: 25785 RVA: 0x001855A0 File Offset: 0x001837A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinGameResponse.Descriptor;
			}
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x001855B7 File Offset: 0x001837B7
		[DebuggerNonUserCode]
		public JoinGameResponse()
		{
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x001855C1 File Offset: 0x001837C1
		[DebuggerNonUserCode]
		public JoinGameResponse(JoinGameResponse other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x001855F8 File Offset: 0x001837F8
		[DebuggerNonUserCode]
		public JoinGameResponse Clone()
		{
			return new JoinGameResponse(this);
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x00185610 File Offset: 0x00183810
		// (set) Token: 0x060064BE RID: 25790 RVA: 0x00185628 File Offset: 0x00183828
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

		// Token: 0x060064BF RID: 25791 RVA: 0x00185634 File Offset: 0x00183834
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinGameResponse);
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00185654 File Offset: 0x00183854
		[DebuggerNonUserCode]
		public bool Equals(JoinGameResponse other)
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

		// Token: 0x060064C1 RID: 25793 RVA: 0x001856B0 File Offset: 0x001838B0
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

		// Token: 0x060064C2 RID: 25794 RVA: 0x00185700 File Offset: 0x00183900
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00185718 File Offset: 0x00183918
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00185724 File Offset: 0x00183924
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

		// Token: 0x060064C5 RID: 25797 RVA: 0x00185774 File Offset: 0x00183974
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

		// Token: 0x060064C6 RID: 25798 RVA: 0x001857C8 File Offset: 0x001839C8
		[DebuggerNonUserCode]
		public void MergeFrom(JoinGameResponse other)
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

		// Token: 0x060064C7 RID: 25799 RVA: 0x00185834 File Offset: 0x00183A34
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00185840 File Offset: 0x00183A40
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

		// Token: 0x04002DD5 RID: 11733
		private static readonly MessageParser<JoinGameResponse> _parser = new MessageParser<JoinGameResponse>(() => new JoinGameResponse());

		// Token: 0x04002DD6 RID: 11734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD7 RID: 11735
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002DD8 RID: 11736
		private RequestId requestId_;
	}
}
