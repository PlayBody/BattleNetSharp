using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000521 RID: 1313
	public sealed class RemoveStreamMentionsRequest : IMessage<RemoveStreamMentionsRequest>, IMessage, IEquatable<RemoveStreamMentionsRequest>, IDeepCloneable<RemoveStreamMentionsRequest>, IBufferMessage
	{
		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x001F0E54 File Offset: 0x001EF054
		[DebuggerNonUserCode]
		public static MessageParser<RemoveStreamMentionsRequest> Parser
		{
			get
			{
				return RemoveStreamMentionsRequest._parser;
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x06007F9F RID: 32671 RVA: 0x001F0E6C File Offset: 0x001EF06C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x001F0E90 File Offset: 0x001EF090
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveStreamMentionsRequest.Descriptor;
			}
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x001F0EA7 File Offset: 0x001EF0A7
		[DebuggerNonUserCode]
		public RemoveStreamMentionsRequest()
		{
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x001F0EBC File Offset: 0x001EF0BC
		[DebuggerNonUserCode]
		public RemoveStreamMentionsRequest(RemoveStreamMentionsRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.mentionId_ = other.mentionId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x001F0F10 File Offset: 0x001EF110
		[DebuggerNonUserCode]
		public RemoveStreamMentionsRequest Clone()
		{
			return new RemoveStreamMentionsRequest(this);
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06007FA4 RID: 32676 RVA: 0x001F0F28 File Offset: 0x001EF128
		// (set) Token: 0x06007FA5 RID: 32677 RVA: 0x001F0F40 File Offset: 0x001EF140
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x001F0F4C File Offset: 0x001EF14C
		[DebuggerNonUserCode]
		public RepeatedField<TimeSeriesId> MentionId
		{
			get
			{
				return this.mentionId_;
			}
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x001F0F64 File Offset: 0x001EF164
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveStreamMentionsRequest);
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x001F0F84 File Offset: 0x001EF184
		[DebuggerNonUserCode]
		public bool Equals(RemoveStreamMentionsRequest other)
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
						bool flag5 = !this.mentionId_.Equals(other.mentionId_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x001F0FFC File Offset: 0x001EF1FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			num ^= this.mentionId_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x001F1058 File Offset: 0x001EF258
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x001F1070 File Offset: 0x001EF270
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x001F107C File Offset: 0x001EF27C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			this.mentionId_.WriteTo(ref output, RemoveStreamMentionsRequest._repeated_mentionId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x001F10E0 File Offset: 0x001EF2E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			num += this.mentionId_.CalculateSize(RemoveStreamMentionsRequest._repeated_mentionId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x001F1144 File Offset: 0x001EF344
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveStreamMentionsRequest other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this.mentionId_.Add(other.mentionId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x001F11C2 File Offset: 0x001EF3C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x001F11D0 File Offset: 0x001EF3D0
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
						this.mentionId_.AddEntriesFrom(ref input, RemoveStreamMentionsRequest._repeated_mentionId_codec);
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039ED RID: 14829
		private static readonly MessageParser<RemoveStreamMentionsRequest> _parser = new MessageParser<RemoveStreamMentionsRequest>(() => new RemoveStreamMentionsRequest());

		// Token: 0x040039EE RID: 14830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039EF RID: 14831
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039F0 RID: 14832
		private AccountId agentId_;

		// Token: 0x040039F1 RID: 14833
		public const int MentionIdFieldNumber = 2;

		// Token: 0x040039F2 RID: 14834
		private static readonly FieldCodec<TimeSeriesId> _repeated_mentionId_codec = FieldCodec.ForMessage<TimeSeriesId>(18U, TimeSeriesId.Parser);

		// Token: 0x040039F3 RID: 14835
		private readonly RepeatedField<TimeSeriesId> mentionId_ = new RepeatedField<TimeSeriesId>();
	}
}
