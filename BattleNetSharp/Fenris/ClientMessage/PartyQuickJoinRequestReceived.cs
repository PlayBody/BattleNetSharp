using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000252 RID: 594
	public sealed class PartyQuickJoinRequestReceived : IMessage<PartyQuickJoinRequestReceived>, IMessage, IEquatable<PartyQuickJoinRequestReceived>, IDeepCloneable<PartyQuickJoinRequestReceived>, IBufferMessage
	{
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x000FA094 File Offset: 0x000F8294
		[DebuggerNonUserCode]
		public static MessageParser<PartyQuickJoinRequestReceived> Parser
		{
			get
			{
				return PartyQuickJoinRequestReceived._parser;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x000FA0AC File Offset: 0x000F82AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[66];
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x000FA0D0 File Offset: 0x000F82D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyQuickJoinRequestReceived.Descriptor;
			}
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x000FA0E7 File Offset: 0x000F82E7
		[DebuggerNonUserCode]
		public PartyQuickJoinRequestReceived()
		{
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x000FA0F4 File Offset: 0x000F82F4
		[DebuggerNonUserCode]
		public PartyQuickJoinRequestReceived(PartyQuickJoinRequestReceived other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesterGameAccountId_ = other.requesterGameAccountId_;
			this.requesterBnetAccountId_ = other.requesterBnetAccountId_;
			this.requesterPlatformAccount_ = ((other.requesterPlatformAccount_ != null) ? other.requesterPlatformAccount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x000FA15C File Offset: 0x000F835C
		[DebuggerNonUserCode]
		public PartyQuickJoinRequestReceived Clone()
		{
			return new PartyQuickJoinRequestReceived(this);
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x000FA174 File Offset: 0x000F8374
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x000FA1A5 File Offset: 0x000F83A5
		[DebuggerNonUserCode]
		public uint RequesterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint requesterGameAccountIdDefaultValue;
				if (flag)
				{
					requesterGameAccountIdDefaultValue = this.requesterGameAccountId_;
				}
				else
				{
					requesterGameAccountIdDefaultValue = PartyQuickJoinRequestReceived.RequesterGameAccountIdDefaultValue;
				}
				return requesterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesterGameAccountId_ = value;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x000FA1C0 File Offset: 0x000F83C0
		[DebuggerNonUserCode]
		public bool HasRequesterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x000FA1DD File Offset: 0x000F83DD
		[DebuggerNonUserCode]
		public void ClearRequesterGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x000FA1F0 File Offset: 0x000F83F0
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x000FA221 File Offset: 0x000F8421
		[DebuggerNonUserCode]
		public uint RequesterBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint requesterBnetAccountIdDefaultValue;
				if (flag)
				{
					requesterBnetAccountIdDefaultValue = this.requesterBnetAccountId_;
				}
				else
				{
					requesterBnetAccountIdDefaultValue = PartyQuickJoinRequestReceived.RequesterBnetAccountIdDefaultValue;
				}
				return requesterBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.requesterBnetAccountId_ = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x000FA23C File Offset: 0x000F843C
		[DebuggerNonUserCode]
		public bool HasRequesterBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x000FA259 File Offset: 0x000F8459
		[DebuggerNonUserCode]
		public void ClearRequesterBnetAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000FA26C File Offset: 0x000F846C
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x000FA284 File Offset: 0x000F8484
		[DebuggerNonUserCode]
		public PlatformAccount RequesterPlatformAccount
		{
			get
			{
				return this.requesterPlatformAccount_;
			}
			set
			{
				this.requesterPlatformAccount_ = value;
			}
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x000FA290 File Offset: 0x000F8490
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyQuickJoinRequestReceived);
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x000FA2B0 File Offset: 0x000F84B0
		[DebuggerNonUserCode]
		public bool Equals(PartyQuickJoinRequestReceived other)
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
					bool flag4 = this.RequesterGameAccountId != other.RequesterGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RequesterBnetAccountId != other.RequesterBnetAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.RequesterPlatformAccount, other.RequesterPlatformAccount);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000FA340 File Offset: 0x000F8540
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num ^= this.RequesterGameAccountId.GetHashCode();
			}
			bool hasRequesterBnetAccountId = this.HasRequesterBnetAccountId;
			if (hasRequesterBnetAccountId)
			{
				num ^= this.RequesterBnetAccountId.GetHashCode();
			}
			bool flag = this.requesterPlatformAccount_ != null;
			if (flag)
			{
				num ^= this.RequesterPlatformAccount.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x000FA3CC File Offset: 0x000F85CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x000FA3E4 File Offset: 0x000F85E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x000FA3F0 File Offset: 0x000F85F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RequesterGameAccountId);
			}
			bool hasRequesterBnetAccountId = this.HasRequesterBnetAccountId;
			if (hasRequesterBnetAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RequesterBnetAccountId);
			}
			bool flag = this.requesterPlatformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RequesterPlatformAccount);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x000FA484 File Offset: 0x000F8684
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesterGameAccountId);
			}
			bool hasRequesterBnetAccountId = this.HasRequesterBnetAccountId;
			if (hasRequesterBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesterBnetAccountId);
			}
			bool flag = this.requesterPlatformAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequesterPlatformAccount);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x000FA514 File Offset: 0x000F8714
		[DebuggerNonUserCode]
		public void MergeFrom(PartyQuickJoinRequestReceived other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequesterGameAccountId = other.HasRequesterGameAccountId;
				if (hasRequesterGameAccountId)
				{
					this.RequesterGameAccountId = other.RequesterGameAccountId;
				}
				bool hasRequesterBnetAccountId = other.HasRequesterBnetAccountId;
				if (hasRequesterBnetAccountId)
				{
					this.RequesterBnetAccountId = other.RequesterBnetAccountId;
				}
				bool flag2 = other.requesterPlatformAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.requesterPlatformAccount_ == null;
					if (flag3)
					{
						this.RequesterPlatformAccount = new PlatformAccount();
					}
					this.RequesterPlatformAccount.MergeFrom(other.RequesterPlatformAccount);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x000FA5B7 File Offset: 0x000F87B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x000FA5C4 File Offset: 0x000F87C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.requesterPlatformAccount_ == null;
							if (flag)
							{
								this.RequesterPlatformAccount = new PlatformAccount();
							}
							input.ReadMessage(this.RequesterPlatformAccount);
						}
					}
					else
					{
						this.RequesterBnetAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.RequesterGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D16 RID: 7446
		private static readonly MessageParser<PartyQuickJoinRequestReceived> _parser = new MessageParser<PartyQuickJoinRequestReceived>(() => new PartyQuickJoinRequestReceived());

		// Token: 0x04001D17 RID: 7447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D18 RID: 7448
		private int _hasBits0;

		// Token: 0x04001D19 RID: 7449
		public const int RequesterGameAccountIdFieldNumber = 2;

		// Token: 0x04001D1A RID: 7450
		private static readonly uint RequesterGameAccountIdDefaultValue = 0U;

		// Token: 0x04001D1B RID: 7451
		private uint requesterGameAccountId_;

		// Token: 0x04001D1C RID: 7452
		public const int RequesterBnetAccountIdFieldNumber = 3;

		// Token: 0x04001D1D RID: 7453
		private static readonly uint RequesterBnetAccountIdDefaultValue = 0U;

		// Token: 0x04001D1E RID: 7454
		private uint requesterBnetAccountId_;

		// Token: 0x04001D1F RID: 7455
		public const int RequesterPlatformAccountFieldNumber = 4;

		// Token: 0x04001D20 RID: 7456
		private PlatformAccount requesterPlatformAccount_;
	}
}
