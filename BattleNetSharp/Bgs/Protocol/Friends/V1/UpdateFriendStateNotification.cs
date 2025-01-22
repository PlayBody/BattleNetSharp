using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000412 RID: 1042
	public sealed class UpdateFriendStateNotification : IMessage<UpdateFriendStateNotification>, IMessage, IEquatable<UpdateFriendStateNotification>, IDeepCloneable<UpdateFriendStateNotification>, IBufferMessage
	{
		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x0018D998 File Offset: 0x0018BB98
		[DebuggerNonUserCode]
		public static MessageParser<UpdateFriendStateNotification> Parser
		{
			get
			{
				return UpdateFriendStateNotification._parser;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x0018D9B0 File Offset: 0x0018BBB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x0018D9D4 File Offset: 0x0018BBD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFriendStateNotification.Descriptor;
			}
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x0018D9EB File Offset: 0x0018BBEB
		[DebuggerNonUserCode]
		public UpdateFriendStateNotification()
		{
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x0018D9F8 File Offset: 0x0018BBF8
		[DebuggerNonUserCode]
		public UpdateFriendStateNotification(UpdateFriendStateNotification other)
			: this()
		{
			this.changedFriend_ = ((other.changedFriend_ != null) ? other.changedFriend_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x0018DA58 File Offset: 0x0018BC58
		[DebuggerNonUserCode]
		public UpdateFriendStateNotification Clone()
		{
			return new UpdateFriendStateNotification(this);
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x0018DA70 File Offset: 0x0018BC70
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x0018DA88 File Offset: 0x0018BC88
		[DebuggerNonUserCode]
		public Friend ChangedFriend
		{
			get
			{
				return this.changedFriend_;
			}
			set
			{
				this.changedFriend_ = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x0018DA94 File Offset: 0x0018BC94
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x0018DAAC File Offset: 0x0018BCAC
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

		// Token: 0x060066E6 RID: 26342 RVA: 0x0018DAB8 File Offset: 0x0018BCB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFriendStateNotification);
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x0018DAD8 File Offset: 0x0018BCD8
		[DebuggerNonUserCode]
		public bool Equals(UpdateFriendStateNotification other)
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
					bool flag4 = !object.Equals(this.ChangedFriend, other.ChangedFriend);
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

		// Token: 0x060066E8 RID: 26344 RVA: 0x0018DB50 File Offset: 0x0018BD50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.changedFriend_ != null;
			if (flag)
			{
				num ^= this.ChangedFriend.GetHashCode();
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

		// Token: 0x060066E9 RID: 26345 RVA: 0x0018DBBC File Offset: 0x0018BDBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x0018DBD4 File Offset: 0x0018BDD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x0018DBE0 File Offset: 0x0018BDE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.changedFriend_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChangedFriend);
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

		// Token: 0x060066EC RID: 26348 RVA: 0x0018DC54 File Offset: 0x0018BE54
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.changedFriend_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangedFriend);
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

		// Token: 0x060066ED RID: 26349 RVA: 0x0018DCC8 File Offset: 0x0018BEC8
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateFriendStateNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.changedFriend_ != null;
				if (flag2)
				{
					bool flag3 = this.changedFriend_ == null;
					if (flag3)
					{
						this.ChangedFriend = new Friend();
					}
					this.ChangedFriend.MergeFrom(other.ChangedFriend);
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

		// Token: 0x060066EE RID: 26350 RVA: 0x0018DD75 File Offset: 0x0018BF75
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x0018DD80 File Offset: 0x0018BF80
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
					bool flag2 = this.changedFriend_ == null;
					if (flag2)
					{
						this.ChangedFriend = new Friend();
					}
					input.ReadMessage(this.ChangedFriend);
				}
			}
		}

		// Token: 0x04002EA6 RID: 11942
		private static readonly MessageParser<UpdateFriendStateNotification> _parser = new MessageParser<UpdateFriendStateNotification>(() => new UpdateFriendStateNotification());

		// Token: 0x04002EA7 RID: 11943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EA8 RID: 11944
		public const int ChangedFriendFieldNumber = 1;

		// Token: 0x04002EA9 RID: 11945
		private Friend changedFriend_;

		// Token: 0x04002EAA RID: 11946
		public const int AccountIdFieldNumber = 5;

		// Token: 0x04002EAB RID: 11947
		private EntityId accountId_;
	}
}
