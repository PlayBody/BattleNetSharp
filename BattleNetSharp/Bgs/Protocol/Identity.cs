using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000358 RID: 856
	public sealed class Identity : IMessage<Identity>, IMessage, IEquatable<Identity>, IDeepCloneable<Identity>, IBufferMessage
	{
		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060058C5 RID: 22725 RVA: 0x001574AC File Offset: 0x001556AC
		[DebuggerNonUserCode]
		public static MessageParser<Identity> Parser
		{
			get
			{
				return Identity._parser;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x001574C4 File Offset: 0x001556C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x060058C7 RID: 22727 RVA: 0x001574E8 File Offset: 0x001556E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Identity.Descriptor;
			}
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x001574FF File Offset: 0x001556FF
		[DebuggerNonUserCode]
		public Identity()
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x0015750C File Offset: 0x0015570C
		[DebuggerNonUserCode]
		public Identity(Identity other)
			: this()
		{
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x0015756C File Offset: 0x0015576C
		[DebuggerNonUserCode]
		public Identity Clone()
		{
			return new Identity(this);
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x00157584 File Offset: 0x00155784
		// (set) Token: 0x060058CC RID: 22732 RVA: 0x0015759C File Offset: 0x0015579C
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

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x001575A8 File Offset: 0x001557A8
		// (set) Token: 0x060058CE RID: 22734 RVA: 0x001575C0 File Offset: 0x001557C0
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

		// Token: 0x060058CF RID: 22735 RVA: 0x001575CC File Offset: 0x001557CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Identity);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x001575EC File Offset: 0x001557EC
		[DebuggerNonUserCode]
		public bool Equals(Identity other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00157664 File Offset: 0x00155864
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x001576D0 File Offset: 0x001558D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x001576E8 File Offset: 0x001558E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x001576F4 File Offset: 0x001558F4
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00157768 File Offset: 0x00155968
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x001577DC File Offset: 0x001559DC
		[DebuggerNonUserCode]
		public void MergeFrom(Identity other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00157889 File Offset: 0x00155A89
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00157894 File Offset: 0x00155A94
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
						bool flag = this.gameAccountId_ == null;
						if (flag)
						{
							this.GameAccountId = new EntityId();
						}
						input.ReadMessage(this.GameAccountId);
					}
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
		}

		// Token: 0x0400287E RID: 10366
		private static readonly MessageParser<Identity> _parser = new MessageParser<Identity>(() => new Identity());

		// Token: 0x0400287F RID: 10367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002880 RID: 10368
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002881 RID: 10369
		private EntityId accountId_;

		// Token: 0x04002882 RID: 10370
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04002883 RID: 10371
		private EntityId gameAccountId_;
	}
}
