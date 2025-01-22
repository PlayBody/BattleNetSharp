using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000411 RID: 1041
	public sealed class FriendNotification : IMessage<FriendNotification>, IMessage, IEquatable<FriendNotification>, IDeepCloneable<FriendNotification>, IBufferMessage
	{
		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x0018D4EC File Offset: 0x0018B6EC
		[DebuggerNonUserCode]
		public static MessageParser<FriendNotification> Parser
		{
			get
			{
				return FriendNotification._parser;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x0018D504 File Offset: 0x0018B704
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x0018D528 File Offset: 0x0018B728
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendNotification.Descriptor;
			}
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x0018D53F File Offset: 0x0018B73F
		[DebuggerNonUserCode]
		public FriendNotification()
		{
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x0018D54C File Offset: 0x0018B74C
		[DebuggerNonUserCode]
		public FriendNotification(FriendNotification other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x0018D5AC File Offset: 0x0018B7AC
		[DebuggerNonUserCode]
		public FriendNotification Clone()
		{
			return new FriendNotification(this);
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x0018D5C4 File Offset: 0x0018B7C4
		// (set) Token: 0x060066CE RID: 26318 RVA: 0x0018D5DC File Offset: 0x0018B7DC
		[DebuggerNonUserCode]
		public Friend Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x0018D5E8 File Offset: 0x0018B7E8
		// (set) Token: 0x060066D0 RID: 26320 RVA: 0x0018D600 File Offset: 0x0018B800
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

		// Token: 0x060066D1 RID: 26321 RVA: 0x0018D60C File Offset: 0x0018B80C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendNotification);
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x0018D62C File Offset: 0x0018B82C
		[DebuggerNonUserCode]
		public bool Equals(FriendNotification other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AccountId, other.AccountId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x0018D6A4 File Offset: 0x0018B8A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x0018D710 File Offset: 0x0018B910
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x0018D728 File Offset: 0x0018B928
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x0018D734 File Offset: 0x0018B934
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x0018D7A8 File Offset: 0x0018B9A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x0018D81C File Offset: 0x0018BA1C
		[DebuggerNonUserCode]
		public void MergeFrom(FriendNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new Friend();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool flag4 = other.accountId_ != null;
				if (flag4)
				{
					bool flag5 = this.accountId_ == null;
					if (flag5)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x0018D8C9 File Offset: 0x0018BAC9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x0018D8D4 File Offset: 0x0018BAD4
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
					if (num3 != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.accountId_ == null;
						if (flag)
						{
							this.AccountId = new EntityId();
						}
						input.ReadMessage(this.AccountId);
					}
				}
				else
				{
					bool flag2 = this.target_ == null;
					if (flag2)
					{
						this.Target = new Friend();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04002EA0 RID: 11936
		private static readonly MessageParser<FriendNotification> _parser = new MessageParser<FriendNotification>(() => new FriendNotification());

		// Token: 0x04002EA1 RID: 11937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EA2 RID: 11938
		public const int TargetFieldNumber = 1;

		// Token: 0x04002EA3 RID: 11939
		private Friend target_;

		// Token: 0x04002EA4 RID: 11940
		public const int AccountIdFieldNumber = 5;

		// Token: 0x04002EA5 RID: 11941
		private EntityId accountId_;
	}
}
