using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000717 RID: 1815
	public sealed class GetAccountStateResponse : IMessage<GetAccountStateResponse>, IMessage, IEquatable<GetAccountStateResponse>, IDeepCloneable<GetAccountStateResponse>, IBufferMessage
	{
		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A659 RID: 42585 RVA: 0x00287EC8 File Offset: 0x002860C8
		[DebuggerNonUserCode]
		public static MessageParser<GetAccountStateResponse> Parser
		{
			get
			{
				return GetAccountStateResponse._parser;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A65A RID: 42586 RVA: 0x00287EE0 File Offset: 0x002860E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x00287F04 File Offset: 0x00286104
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountStateResponse.Descriptor;
			}
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x00287F1B File Offset: 0x0028611B
		[DebuggerNonUserCode]
		public GetAccountStateResponse()
		{
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x00287F28 File Offset: 0x00286128
		[DebuggerNonUserCode]
		public GetAccountStateResponse(GetAccountStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this.tags_ = ((other.tags_ != null) ? other.tags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x00287F88 File Offset: 0x00286188
		[DebuggerNonUserCode]
		public GetAccountStateResponse Clone()
		{
			return new GetAccountStateResponse(this);
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x00287FA0 File Offset: 0x002861A0
		// (set) Token: 0x0600A660 RID: 42592 RVA: 0x00287FB8 File Offset: 0x002861B8
		[DebuggerNonUserCode]
		public AccountState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x00287FC4 File Offset: 0x002861C4
		// (set) Token: 0x0600A662 RID: 42594 RVA: 0x00287FDC File Offset: 0x002861DC
		[DebuggerNonUserCode]
		public AccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x00287FE8 File Offset: 0x002861E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountStateResponse);
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x00288008 File Offset: 0x00286208
		[DebuggerNonUserCode]
		public bool Equals(GetAccountStateResponse other)
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
					bool flag4 = !object.Equals(this.State, other.State);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Tags, other.Tags);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x00288080 File Offset: 0x00286280
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				num ^= this.Tags.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x002880EC File Offset: 0x002862EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x00288104 File Offset: 0x00286304
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x00288110 File Offset: 0x00286310
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Tags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x00288184 File Offset: 0x00286384
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x002881F8 File Offset: 0x002863F8
		[DebuggerNonUserCode]
		public void MergeFrom(GetAccountStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new AccountState();
					}
					this.State.MergeFrom(other.State);
				}
				bool flag4 = other.tags_ != null;
				if (flag4)
				{
					bool flag5 = this.tags_ == null;
					if (flag5)
					{
						this.Tags = new AccountFieldTags();
					}
					this.Tags.MergeFrom(other.Tags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x002882A5 File Offset: 0x002864A5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x002882B0 File Offset: 0x002864B0
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
						bool flag = this.tags_ == null;
						if (flag)
						{
							this.Tags = new AccountFieldTags();
						}
						input.ReadMessage(this.Tags);
					}
				}
				else
				{
					bool flag2 = this.state_ == null;
					if (flag2)
					{
						this.State = new AccountState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x04004AC1 RID: 19137
		private static readonly MessageParser<GetAccountStateResponse> _parser = new MessageParser<GetAccountStateResponse>(() => new GetAccountStateResponse());

		// Token: 0x04004AC2 RID: 19138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC3 RID: 19139
		public const int StateFieldNumber = 1;

		// Token: 0x04004AC4 RID: 19140
		private AccountState state_;

		// Token: 0x04004AC5 RID: 19141
		public const int TagsFieldNumber = 2;

		// Token: 0x04004AC6 RID: 19142
		private AccountFieldTags tags_;
	}
}
