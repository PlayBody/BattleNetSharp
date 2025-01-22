using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000251 RID: 593
	public sealed class PartyInviteRequestReceived : IMessage<PartyInviteRequestReceived>, IMessage, IEquatable<PartyInviteRequestReceived>, IDeepCloneable<PartyInviteRequestReceived>, IBufferMessage
	{
		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x000F9974 File Offset: 0x000F7B74
		[DebuggerNonUserCode]
		public static MessageParser<PartyInviteRequestReceived> Parser
		{
			get
			{
				return PartyInviteRequestReceived._parser;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x000F998C File Offset: 0x000F7B8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[65];
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x000F99B0 File Offset: 0x000F7BB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInviteRequestReceived.Descriptor;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000F99C7 File Offset: 0x000F7BC7
		[DebuggerNonUserCode]
		public PartyInviteRequestReceived()
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		[DebuggerNonUserCode]
		public PartyInviteRequestReceived(PartyInviteRequestReceived other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesterGameAccountId_ = other.requesterGameAccountId_;
			this.requesterBnetAccountId_ = other.requesterBnetAccountId_;
			this.requesterPlatformAccount_ = ((other.requesterPlatformAccount_ != null) ? other.requesterPlatformAccount_.Clone() : null);
			this.requesterName_ = other.requesterName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000F9A48 File Offset: 0x000F7C48
		[DebuggerNonUserCode]
		public PartyInviteRequestReceived Clone()
		{
			return new PartyInviteRequestReceived(this);
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x000F9A60 File Offset: 0x000F7C60
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x000F9A91 File Offset: 0x000F7C91
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
					requesterGameAccountIdDefaultValue = PartyInviteRequestReceived.RequesterGameAccountIdDefaultValue;
				}
				return requesterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesterGameAccountId_ = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000F9AAC File Offset: 0x000F7CAC
		[DebuggerNonUserCode]
		public bool HasRequesterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x000F9AC9 File Offset: 0x000F7CC9
		[DebuggerNonUserCode]
		public void ClearRequesterGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x000F9ADC File Offset: 0x000F7CDC
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x000F9B0D File Offset: 0x000F7D0D
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
					requesterBnetAccountIdDefaultValue = PartyInviteRequestReceived.RequesterBnetAccountIdDefaultValue;
				}
				return requesterBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.requesterBnetAccountId_ = value;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x000F9B28 File Offset: 0x000F7D28
		[DebuggerNonUserCode]
		public bool HasRequesterBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x000F9B45 File Offset: 0x000F7D45
		[DebuggerNonUserCode]
		public void ClearRequesterBnetAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x000F9B58 File Offset: 0x000F7D58
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x000F9B70 File Offset: 0x000F7D70
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

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x000F9B7C File Offset: 0x000F7D7C
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x000F9B9D File Offset: 0x000F7D9D
		[DebuggerNonUserCode]
		public string RequesterName
		{
			get
			{
				return this.requesterName_ ?? PartyInviteRequestReceived.RequesterNameDefaultValue;
			}
			set
			{
				this.requesterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x000F9BB4 File Offset: 0x000F7DB4
		[DebuggerNonUserCode]
		public bool HasRequesterName
		{
			get
			{
				return this.requesterName_ != null;
			}
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x000F9BCF File Offset: 0x000F7DCF
		[DebuggerNonUserCode]
		public void ClearRequesterName()
		{
			this.requesterName_ = null;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x000F9BDC File Offset: 0x000F7DDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInviteRequestReceived);
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x000F9BFC File Offset: 0x000F7DFC
		[DebuggerNonUserCode]
		public bool Equals(PartyInviteRequestReceived other)
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
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RequesterName != other.RequesterName;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x000F9CAC File Offset: 0x000F7EAC
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
			bool hasRequesterName = this.HasRequesterName;
			if (hasRequesterName)
			{
				num ^= this.RequesterName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x000F9D50 File Offset: 0x000F7F50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x000F9D68 File Offset: 0x000F7F68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x000F9D74 File Offset: 0x000F7F74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RequesterGameAccountId);
			}
			bool hasRequesterName = this.HasRequesterName;
			if (hasRequesterName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.RequesterName);
			}
			bool hasRequesterBnetAccountId = this.HasRequesterBnetAccountId;
			if (hasRequesterBnetAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RequesterBnetAccountId);
			}
			bool flag = this.requesterPlatformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RequesterPlatformAccount);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x000F9E2C File Offset: 0x000F802C
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
			bool hasRequesterName = this.HasRequesterName;
			if (hasRequesterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequesterName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x000F9ED8 File Offset: 0x000F80D8
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInviteRequestReceived other)
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
				bool hasRequesterName = other.HasRequesterName;
				if (hasRequesterName)
				{
					this.RequesterName = other.RequesterName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x000F9F96 File Offset: 0x000F8196
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x000F9FA4 File Offset: 0x000F81A4
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							goto IL_002C;
						}
						this.RequesterName = input.ReadString();
					}
					else
					{
						this.RequesterGameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						goto IL_002C;
					}
					bool flag = this.requesterPlatformAccount_ == null;
					if (flag)
					{
						this.RequesterPlatformAccount = new PlatformAccount();
					}
					input.ReadMessage(this.RequesterPlatformAccount);
				}
				else
				{
					this.RequesterBnetAccountId = input.ReadUInt32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D08 RID: 7432
		private static readonly MessageParser<PartyInviteRequestReceived> _parser = new MessageParser<PartyInviteRequestReceived>(() => new PartyInviteRequestReceived());

		// Token: 0x04001D09 RID: 7433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D0A RID: 7434
		private int _hasBits0;

		// Token: 0x04001D0B RID: 7435
		public const int RequesterGameAccountIdFieldNumber = 2;

		// Token: 0x04001D0C RID: 7436
		private static readonly uint RequesterGameAccountIdDefaultValue = 0U;

		// Token: 0x04001D0D RID: 7437
		private uint requesterGameAccountId_;

		// Token: 0x04001D0E RID: 7438
		public const int RequesterBnetAccountIdFieldNumber = 4;

		// Token: 0x04001D0F RID: 7439
		private static readonly uint RequesterBnetAccountIdDefaultValue = 0U;

		// Token: 0x04001D10 RID: 7440
		private uint requesterBnetAccountId_;

		// Token: 0x04001D11 RID: 7441
		public const int RequesterPlatformAccountFieldNumber = 5;

		// Token: 0x04001D12 RID: 7442
		private PlatformAccount requesterPlatformAccount_;

		// Token: 0x04001D13 RID: 7443
		public const int RequesterNameFieldNumber = 3;

		// Token: 0x04001D14 RID: 7444
		private static readonly string RequesterNameDefaultValue = "";

		// Token: 0x04001D15 RID: 7445
		private string requesterName_;
	}
}
