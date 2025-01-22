using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071A RID: 1818
	public sealed class GetGameAccountStateRequest : IMessage<GetGameAccountStateRequest>, IMessage, IEquatable<GetGameAccountStateRequest>, IDeepCloneable<GetGameAccountStateRequest>, IBufferMessage
	{
		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600A696 RID: 42646 RVA: 0x00288A28 File Offset: 0x00286C28
		[DebuggerNonUserCode]
		public static MessageParser<GetGameAccountStateRequest> Parser
		{
			get
			{
				return GetGameAccountStateRequest._parser;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600A697 RID: 42647 RVA: 0x00288A40 File Offset: 0x00286C40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x00288A64 File Offset: 0x00286C64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameAccountStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x00288A7B File Offset: 0x00286C7B
		[DebuggerNonUserCode]
		public GetGameAccountStateRequest()
		{
		}

		// Token: 0x0600A69A RID: 42650 RVA: 0x00288A88 File Offset: 0x00286C88
		[DebuggerNonUserCode]
		public GetGameAccountStateRequest(GetGameAccountStateRequest other)
			: this()
		{
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.tags_ = ((other.tags_ != null) ? other.tags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x00288B20 File Offset: 0x00286D20
		[DebuggerNonUserCode]
		public GetGameAccountStateRequest Clone()
		{
			return new GetGameAccountStateRequest(this);
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x00288B38 File Offset: 0x00286D38
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x00288B50 File Offset: 0x00286D50
		[Obsolete]
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x00288B5C File Offset: 0x00286D5C
		// (set) Token: 0x0600A69F RID: 42655 RVA: 0x00288B74 File Offset: 0x00286D74
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x00288B80 File Offset: 0x00286D80
		// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x00288B98 File Offset: 0x00286D98
		[DebuggerNonUserCode]
		public GameAccountFieldOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600A6A2 RID: 42658 RVA: 0x00288BA4 File Offset: 0x00286DA4
		// (set) Token: 0x0600A6A3 RID: 42659 RVA: 0x00288BBC File Offset: 0x00286DBC
		[DebuggerNonUserCode]
		public GameAccountFieldTags Tags
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

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x00288BC8 File Offset: 0x00286DC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameAccountStateRequest);
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x00288BE8 File Offset: 0x00286DE8
		[DebuggerNonUserCode]
		public bool Equals(GetGameAccountStateRequest other)
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
					bool flag4 = !object.Equals(this.AccountId, other.AccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccountId, other.GameAccountId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Options, other.Options);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Tags, other.Tags);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x00288CA4 File Offset: 0x00286EA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag4 = this.tags_ != null;
			if (flag4)
			{
				num ^= this.Tags.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x00288D48 File Offset: 0x00286F48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x00288D60 File Offset: 0x00286F60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x00288D6C File Offset: 0x00286F6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Options);
			}
			bool flag4 = this.tags_ != null;
			if (flag4)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Tags);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x00288E2C File Offset: 0x0028702C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag4 = this.tags_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x00288EE0 File Offset: 0x002870E0
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameAccountStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountId_ != null;
				if (flag2)
				{
					bool flag3 = this.accountId_ == null;
					if (flag3)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool flag4 = other.gameAccountId_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccountId_ == null;
					if (flag5)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool flag6 = other.options_ != null;
				if (flag6)
				{
					bool flag7 = this.options_ == null;
					if (flag7)
					{
						this.Options = new GameAccountFieldOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool flag8 = other.tags_ != null;
				if (flag8)
				{
					bool flag9 = this.tags_ == null;
					if (flag9)
					{
						this.Tags = new GameAccountFieldTags();
					}
					this.Tags.MergeFrom(other.Tags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x0028900D File Offset: 0x0028720D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x00289018 File Offset: 0x00287218
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
						bool flag = this.gameAccountId_ == null;
						if (flag)
						{
							this.GameAccountId = new EntityId();
						}
						input.ReadMessage(this.GameAccountId);
					}
					else
					{
						bool flag2 = this.accountId_ == null;
						if (flag2)
						{
							this.AccountId = new EntityId();
						}
						input.ReadMessage(this.AccountId);
					}
				}
				else if (num3 != 82U)
				{
					if (num3 != 90U)
					{
						goto IL_002F;
					}
					bool flag3 = this.tags_ == null;
					if (flag3)
					{
						this.Tags = new GameAccountFieldTags();
					}
					input.ReadMessage(this.Tags);
				}
				else
				{
					bool flag4 = this.options_ == null;
					if (flag4)
					{
						this.Options = new GameAccountFieldOptions();
					}
					input.ReadMessage(this.Options);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AD0 RID: 19152
		private static readonly MessageParser<GetGameAccountStateRequest> _parser = new MessageParser<GetGameAccountStateRequest>(() => new GetGameAccountStateRequest());

		// Token: 0x04004AD1 RID: 19153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD2 RID: 19154
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04004AD3 RID: 19155
		private EntityId accountId_;

		// Token: 0x04004AD4 RID: 19156
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04004AD5 RID: 19157
		private EntityId gameAccountId_;

		// Token: 0x04004AD6 RID: 19158
		public const int OptionsFieldNumber = 10;

		// Token: 0x04004AD7 RID: 19159
		private GameAccountFieldOptions options_;

		// Token: 0x04004AD8 RID: 19160
		public const int TagsFieldNumber = 11;

		// Token: 0x04004AD9 RID: 19161
		private GameAccountFieldTags tags_;
	}
}
