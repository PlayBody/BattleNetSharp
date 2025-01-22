using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073C RID: 1852
	public sealed class SubscriberReference : IMessage<SubscriberReference>, IMessage, IEquatable<SubscriberReference>, IDeepCloneable<SubscriberReference>, IBufferMessage
	{
		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600A9AD RID: 43437 RVA: 0x002950D4 File Offset: 0x002932D4
		[DebuggerNonUserCode]
		public static MessageParser<SubscriberReference> Parser
		{
			get
			{
				return SubscriberReference._parser;
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600A9AE RID: 43438 RVA: 0x002950EC File Offset: 0x002932EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600A9AF RID: 43439 RVA: 0x00295110 File Offset: 0x00293310
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberReference.Descriptor;
			}
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x00295127 File Offset: 0x00293327
		[DebuggerNonUserCode]
		public SubscriberReference()
		{
		}

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x00295134 File Offset: 0x00293334
		[DebuggerNonUserCode]
		public SubscriberReference(SubscriberReference other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectId_ = other.objectId_;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.accountOptions_ = ((other.accountOptions_ != null) ? other.accountOptions_.Clone() : null);
			this.accountTags_ = ((other.accountTags_ != null) ? other.accountTags_.Clone() : null);
			this.gameAccountOptions_ = ((other.gameAccountOptions_ != null) ? other.gameAccountOptions_.Clone() : null);
			this.gameAccountTags_ = ((other.gameAccountTags_ != null) ? other.gameAccountTags_.Clone() : null);
			this.subscriberId_ = other.subscriberId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9B2 RID: 43442 RVA: 0x0029520C File Offset: 0x0029340C
		[DebuggerNonUserCode]
		public SubscriberReference Clone()
		{
			return new SubscriberReference(this);
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x00295224 File Offset: 0x00293424
		// (set) Token: 0x0600A9B4 RID: 43444 RVA: 0x00295255 File Offset: 0x00293455
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = SubscriberReference.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600A9B5 RID: 43445 RVA: 0x00295270 File Offset: 0x00293470
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x0029528D File Offset: 0x0029348D
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600A9B7 RID: 43447 RVA: 0x002952A0 File Offset: 0x002934A0
		// (set) Token: 0x0600A9B8 RID: 43448 RVA: 0x002952B8 File Offset: 0x002934B8
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x002952C4 File Offset: 0x002934C4
		// (set) Token: 0x0600A9BA RID: 43450 RVA: 0x002952DC File Offset: 0x002934DC
		[DebuggerNonUserCode]
		public AccountFieldOptions AccountOptions
		{
			get
			{
				return this.accountOptions_;
			}
			set
			{
				this.accountOptions_ = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x002952E8 File Offset: 0x002934E8
		// (set) Token: 0x0600A9BC RID: 43452 RVA: 0x00295300 File Offset: 0x00293500
		[DebuggerNonUserCode]
		public AccountFieldTags AccountTags
		{
			get
			{
				return this.accountTags_;
			}
			set
			{
				this.accountTags_ = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600A9BD RID: 43453 RVA: 0x0029530C File Offset: 0x0029350C
		// (set) Token: 0x0600A9BE RID: 43454 RVA: 0x00295324 File Offset: 0x00293524
		[DebuggerNonUserCode]
		public GameAccountFieldOptions GameAccountOptions
		{
			get
			{
				return this.gameAccountOptions_;
			}
			set
			{
				this.gameAccountOptions_ = value;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x00295330 File Offset: 0x00293530
		// (set) Token: 0x0600A9C0 RID: 43456 RVA: 0x00295348 File Offset: 0x00293548
		[DebuggerNonUserCode]
		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x00295354 File Offset: 0x00293554
		// (set) Token: 0x0600A9C2 RID: 43458 RVA: 0x00295385 File Offset: 0x00293585
		[DebuggerNonUserCode]
		public ulong SubscriberId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong subscriberIdDefaultValue;
				if (flag)
				{
					subscriberIdDefaultValue = this.subscriberId_;
				}
				else
				{
					subscriberIdDefaultValue = SubscriberReference.SubscriberIdDefaultValue;
				}
				return subscriberIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x002953A0 File Offset: 0x002935A0
		[DebuggerNonUserCode]
		public bool HasSubscriberId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A9C4 RID: 43460 RVA: 0x002953BD File Offset: 0x002935BD
		[DebuggerNonUserCode]
		public void ClearSubscriberId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x002953D0 File Offset: 0x002935D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberReference);
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x002953F0 File Offset: 0x002935F0
		[DebuggerNonUserCode]
		public bool Equals(SubscriberReference other)
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
					bool flag4 = this.ObjectId != other.ObjectId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.EntityId, other.EntityId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountOptions, other.AccountOptions);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AccountTags, other.AccountTags);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.GameAccountOptions, other.GameAccountOptions);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.GameAccountTags, other.GameAccountTags);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SubscriberId != other.SubscriberId;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x00295508 File Offset: 0x00293708
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool flag2 = this.accountOptions_ != null;
			if (flag2)
			{
				num ^= this.AccountOptions.GetHashCode();
			}
			bool flag3 = this.accountTags_ != null;
			if (flag3)
			{
				num ^= this.AccountTags.GetHashCode();
			}
			bool flag4 = this.gameAccountOptions_ != null;
			if (flag4)
			{
				num ^= this.GameAccountOptions.GetHashCode();
			}
			bool flag5 = this.gameAccountTags_ != null;
			if (flag5)
			{
				num ^= this.GameAccountTags.GetHashCode();
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x00295608 File Offset: 0x00293808
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x00295620 File Offset: 0x00293820
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x0029562C File Offset: 0x0029382C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityId);
			}
			bool flag2 = this.accountOptions_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountOptions);
			}
			bool flag3 = this.accountTags_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AccountTags);
			}
			bool flag4 = this.gameAccountOptions_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GameAccountOptions);
			}
			bool flag5 = this.gameAccountTags_ != null;
			if (flag5)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GameAccountTags);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x0029575C File Offset: 0x0029395C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool flag2 = this.accountOptions_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountOptions);
			}
			bool flag3 = this.accountTags_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
			}
			bool flag4 = this.gameAccountOptions_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountOptions);
			}
			bool flag5 = this.gameAccountTags_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x00295870 File Offset: 0x00293A70
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriberReference other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool flag4 = other.accountOptions_ != null;
				if (flag4)
				{
					bool flag5 = this.accountOptions_ == null;
					if (flag5)
					{
						this.AccountOptions = new AccountFieldOptions();
					}
					this.AccountOptions.MergeFrom(other.AccountOptions);
				}
				bool flag6 = other.accountTags_ != null;
				if (flag6)
				{
					bool flag7 = this.accountTags_ == null;
					if (flag7)
					{
						this.AccountTags = new AccountFieldTags();
					}
					this.AccountTags.MergeFrom(other.AccountTags);
				}
				bool flag8 = other.gameAccountOptions_ != null;
				if (flag8)
				{
					bool flag9 = this.gameAccountOptions_ == null;
					if (flag9)
					{
						this.GameAccountOptions = new GameAccountFieldOptions();
					}
					this.GameAccountOptions.MergeFrom(other.GameAccountOptions);
				}
				bool flag10 = other.gameAccountTags_ != null;
				if (flag10)
				{
					bool flag11 = this.gameAccountTags_ == null;
					if (flag11)
					{
						this.GameAccountTags = new GameAccountFieldTags();
					}
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
				}
				bool hasSubscriberId = other.HasSubscriberId;
				if (hasSubscriberId)
				{
					this.SubscriberId = other.SubscriberId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x00295A13 File Offset: 0x00293C13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x00295A20 File Offset: 0x00293C20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0054;
							}
							bool flag = this.accountOptions_ == null;
							if (flag)
							{
								this.AccountOptions = new AccountFieldOptions();
							}
							input.ReadMessage(this.AccountOptions);
						}
						else
						{
							bool flag2 = this.entityId_ == null;
							if (flag2)
							{
								this.EntityId = new EntityId();
							}
							input.ReadMessage(this.EntityId);
						}
					}
					else
					{
						this.ObjectId = input.ReadUInt64();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0054;
						}
						bool flag3 = this.gameAccountOptions_ == null;
						if (flag3)
						{
							this.GameAccountOptions = new GameAccountFieldOptions();
						}
						input.ReadMessage(this.GameAccountOptions);
					}
					else
					{
						bool flag4 = this.accountTags_ == null;
						if (flag4)
						{
							this.AccountTags = new AccountFieldTags();
						}
						input.ReadMessage(this.AccountTags);
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 56U)
					{
						goto IL_0054;
					}
					this.SubscriberId = input.ReadUInt64();
				}
				else
				{
					bool flag5 = this.gameAccountTags_ == null;
					if (flag5)
					{
						this.GameAccountTags = new GameAccountFieldTags();
					}
					input.ReadMessage(this.GameAccountTags);
				}
				continue;
				IL_0054:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C4C RID: 19532
		private static readonly MessageParser<SubscriberReference> _parser = new MessageParser<SubscriberReference>(() => new SubscriberReference());

		// Token: 0x04004C4D RID: 19533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C4E RID: 19534
		private int _hasBits0;

		// Token: 0x04004C4F RID: 19535
		public const int ObjectIdFieldNumber = 1;

		// Token: 0x04004C50 RID: 19536
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004C51 RID: 19537
		private ulong objectId_;

		// Token: 0x04004C52 RID: 19538
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04004C53 RID: 19539
		private EntityId entityId_;

		// Token: 0x04004C54 RID: 19540
		public const int AccountOptionsFieldNumber = 3;

		// Token: 0x04004C55 RID: 19541
		private AccountFieldOptions accountOptions_;

		// Token: 0x04004C56 RID: 19542
		public const int AccountTagsFieldNumber = 4;

		// Token: 0x04004C57 RID: 19543
		private AccountFieldTags accountTags_;

		// Token: 0x04004C58 RID: 19544
		public const int GameAccountOptionsFieldNumber = 5;

		// Token: 0x04004C59 RID: 19545
		private GameAccountFieldOptions gameAccountOptions_;

		// Token: 0x04004C5A RID: 19546
		public const int GameAccountTagsFieldNumber = 6;

		// Token: 0x04004C5B RID: 19547
		private GameAccountFieldTags gameAccountTags_;

		// Token: 0x04004C5C RID: 19548
		public const int SubscriberIdFieldNumber = 7;

		// Token: 0x04004C5D RID: 19549
		private static readonly ulong SubscriberIdDefaultValue = 0UL;

		// Token: 0x04004C5E RID: 19550
		private ulong subscriberId_;
	}
}
