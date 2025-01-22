using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BF RID: 1215
	public sealed class GetSuggestionsRequest : IMessage<GetSuggestionsRequest>, IMessage, IEquatable<GetSuggestionsRequest>, IDeepCloneable<GetSuggestionsRequest>, IBufferMessage
	{
		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x001CCC9C File Offset: 0x001CAE9C
		[DebuggerNonUserCode]
		public static MessageParser<GetSuggestionsRequest> Parser
		{
			get
			{
				return GetSuggestionsRequest._parser;
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x001CCCB4 File Offset: 0x001CAEB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[36];
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x001CCCD8 File Offset: 0x001CAED8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSuggestionsRequest.Descriptor;
			}
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x001CCCEF File Offset: 0x001CAEEF
		[DebuggerNonUserCode]
		public GetSuggestionsRequest()
		{
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x001CCCFC File Offset: 0x001CAEFC
		[DebuggerNonUserCode]
		public GetSuggestionsRequest(GetSuggestionsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x001CCD64 File Offset: 0x001CAF64
		[DebuggerNonUserCode]
		public GetSuggestionsRequest Clone()
		{
			return new GetSuggestionsRequest(this);
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x001CCD7C File Offset: 0x001CAF7C
		// (set) Token: 0x06007635 RID: 30261 RVA: 0x001CCD94 File Offset: 0x001CAF94
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x001CCDA0 File Offset: 0x001CAFA0
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x001CCDD1 File Offset: 0x001CAFD1
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = GetSuggestionsRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x001CCDEC File Offset: 0x001CAFEC
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x001CCE09 File Offset: 0x001CB009
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x001CCE1C File Offset: 0x001CB01C
		// (set) Token: 0x0600763B RID: 30267 RVA: 0x001CCE4D File Offset: 0x001CB04D
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetSuggestionsRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x001CCE68 File Offset: 0x001CB068
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x001CCE85 File Offset: 0x001CB085
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x001CCE98 File Offset: 0x001CB098
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSuggestionsRequest);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x001CCEB8 File Offset: 0x001CB0B8
		[DebuggerNonUserCode]
		public bool Equals(GetSuggestionsRequest other)
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
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x001CCF48 File Offset: 0x001CB148
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x001CCFD4 File Offset: 0x001CB1D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x001CCFEC File Offset: 0x001CB1EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x001CCFF8 File Offset: 0x001CB1F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x001CD08C File Offset: 0x001CB28C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x001CD11C File Offset: 0x001CB31C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSuggestionsRequest other)
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x001CD1BF File Offset: 0x001CB3BF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x001CD1CC File Offset: 0x001CB3CC
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Continuation = input.ReadUInt64();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040035D3 RID: 13779
		private static readonly MessageParser<GetSuggestionsRequest> _parser = new MessageParser<GetSuggestionsRequest>(() => new GetSuggestionsRequest());

		// Token: 0x040035D4 RID: 13780
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D5 RID: 13781
		private int _hasBits0;

		// Token: 0x040035D6 RID: 13782
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035D7 RID: 13783
		private MemberId agentId_;

		// Token: 0x040035D8 RID: 13784
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035D9 RID: 13785
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035DA RID: 13786
		private ulong clubId_;

		// Token: 0x040035DB RID: 13787
		public const int ContinuationFieldNumber = 3;

		// Token: 0x040035DC RID: 13788
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040035DD RID: 13789
		private ulong continuation_;
	}
}
