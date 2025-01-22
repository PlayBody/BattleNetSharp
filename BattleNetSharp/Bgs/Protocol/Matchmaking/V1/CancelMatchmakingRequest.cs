using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F8 RID: 1016
	public sealed class CancelMatchmakingRequest : IMessage<CancelMatchmakingRequest>, IMessage, IEquatable<CancelMatchmakingRequest>, IDeepCloneable<CancelMatchmakingRequest>, IBufferMessage
	{
		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x001858CC File Offset: 0x00183ACC
		[DebuggerNonUserCode]
		public static MessageParser<CancelMatchmakingRequest> Parser
		{
			get
			{
				return CancelMatchmakingRequest._parser;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x001858E4 File Offset: 0x00183AE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x00185908 File Offset: 0x00183B08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchmakingRequest.Descriptor;
			}
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x0018591F File Offset: 0x00183B1F
		[DebuggerNonUserCode]
		public CancelMatchmakingRequest()
		{
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x00185934 File Offset: 0x00183B34
		[DebuggerNonUserCode]
		public CancelMatchmakingRequest(CancelMatchmakingRequest other)
			: this()
		{
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.gameAccount_ = other.gameAccount_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x00185988 File Offset: 0x00183B88
		[DebuggerNonUserCode]
		public CancelMatchmakingRequest Clone()
		{
			return new CancelMatchmakingRequest(this);
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x001859A0 File Offset: 0x00183BA0
		// (set) Token: 0x060064D1 RID: 25809 RVA: 0x001859B8 File Offset: 0x00183BB8
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

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x060064D2 RID: 25810 RVA: 0x001859C4 File Offset: 0x00183BC4
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x001859DC File Offset: 0x00183BDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchmakingRequest);
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x001859FC File Offset: 0x00183BFC
		[DebuggerNonUserCode]
		public bool Equals(CancelMatchmakingRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00185A74 File Offset: 0x00183C74
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x00185AD0 File Offset: 0x00183CD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00185AE8 File Offset: 0x00183CE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00185AF4 File Offset: 0x00183CF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			this.gameAccount_.WriteTo(ref output, CancelMatchmakingRequest._repeated_gameAccount_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x00185B58 File Offset: 0x00183D58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			num += this.gameAccount_.CalculateSize(CancelMatchmakingRequest._repeated_gameAccount_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x00185BBC File Offset: 0x00183DBC
		[DebuggerNonUserCode]
		public void MergeFrom(CancelMatchmakingRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00185C3A File Offset: 0x00183E3A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00185C48 File Offset: 0x00183E48
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
						this.gameAccount_.AddEntriesFrom(ref input, CancelMatchmakingRequest._repeated_gameAccount_codec);
					}
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

		// Token: 0x04002DD9 RID: 11737
		private static readonly MessageParser<CancelMatchmakingRequest> _parser = new MessageParser<CancelMatchmakingRequest>(() => new CancelMatchmakingRequest());

		// Token: 0x04002DDA RID: 11738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DDB RID: 11739
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002DDC RID: 11740
		private RequestId requestId_;

		// Token: 0x04002DDD RID: 11741
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04002DDE RID: 11742
		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(18U, GameAccountHandle.Parser);

		// Token: 0x04002DDF RID: 11743
		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();
	}
}
