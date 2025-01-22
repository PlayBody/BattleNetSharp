using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000250 RID: 592
	public sealed class PartyInviteReceived : IMessage<PartyInviteReceived>, IMessage, IEquatable<PartyInviteReceived>, IDeepCloneable<PartyInviteReceived>, IBufferMessage
	{
		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x000F8EB4 File Offset: 0x000F70B4
		[DebuggerNonUserCode]
		public static MessageParser<PartyInviteReceived> Parser
		{
			get
			{
				return PartyInviteReceived._parser;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06003F9A RID: 16282 RVA: 0x000F8ECC File Offset: 0x000F70CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[64];
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x000F8EF0 File Offset: 0x000F70F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInviteReceived.Descriptor;
			}
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000F8F07 File Offset: 0x000F7107
		[DebuggerNonUserCode]
		public PartyInviteReceived()
		{
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000F8F14 File Offset: 0x000F7114
		[DebuggerNonUserCode]
		public PartyInviteReceived(PartyInviteReceived other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitePartyId_ = other.invitePartyId_;
			this.inviteId_ = other.inviteId_;
			this.inviterGameAccountId_ = other.inviterGameAccountId_;
			this.inviterBnetAccountId_ = other.inviterBnetAccountId_;
			this.inviterPlatformAccount_ = ((other.inviterPlatformAccount_ != null) ? other.inviterPlatformAccount_.Clone() : null);
			this.inviterName_ = other.inviterName_;
			this.inviterHeroName_ = other.inviterHeroName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000F8FAC File Offset: 0x000F71AC
		[DebuggerNonUserCode]
		public PartyInviteReceived Clone()
		{
			return new PartyInviteReceived(this);
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x000F8FC4 File Offset: 0x000F71C4
		// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x000F8FE5 File Offset: 0x000F71E5
		[DebuggerNonUserCode]
		public string InvitePartyId
		{
			get
			{
				return this.invitePartyId_ ?? PartyInviteReceived.InvitePartyIdDefaultValue;
			}
			set
			{
				this.invitePartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x000F8FFC File Offset: 0x000F71FC
		[DebuggerNonUserCode]
		public bool HasInvitePartyId
		{
			get
			{
				return this.invitePartyId_ != null;
			}
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000F9017 File Offset: 0x000F7217
		[DebuggerNonUserCode]
		public void ClearInvitePartyId()
		{
			this.invitePartyId_ = null;
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x000F9024 File Offset: 0x000F7224
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x000F9055 File Offset: 0x000F7255
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = PartyInviteReceived.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x000F9070 File Offset: 0x000F7270
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000F908D File Offset: 0x000F728D
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x000F90A0 File Offset: 0x000F72A0
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x000F90D1 File Offset: 0x000F72D1
		[DebuggerNonUserCode]
		public uint InviterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint inviterGameAccountIdDefaultValue;
				if (flag)
				{
					inviterGameAccountIdDefaultValue = this.inviterGameAccountId_;
				}
				else
				{
					inviterGameAccountIdDefaultValue = PartyInviteReceived.InviterGameAccountIdDefaultValue;
				}
				return inviterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.inviterGameAccountId_ = value;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x000F90EC File Offset: 0x000F72EC
		[DebuggerNonUserCode]
		public bool HasInviterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000F9109 File Offset: 0x000F7309
		[DebuggerNonUserCode]
		public void ClearInviterGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x000F911C File Offset: 0x000F731C
		// (set) Token: 0x06003FAC RID: 16300 RVA: 0x000F914D File Offset: 0x000F734D
		[DebuggerNonUserCode]
		public uint InviterBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint inviterBnetAccountIdDefaultValue;
				if (flag)
				{
					inviterBnetAccountIdDefaultValue = this.inviterBnetAccountId_;
				}
				else
				{
					inviterBnetAccountIdDefaultValue = PartyInviteReceived.InviterBnetAccountIdDefaultValue;
				}
				return inviterBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.inviterBnetAccountId_ = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x000F9168 File Offset: 0x000F7368
		[DebuggerNonUserCode]
		public bool HasInviterBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x000F9185 File Offset: 0x000F7385
		[DebuggerNonUserCode]
		public void ClearInviterBnetAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x000F9198 File Offset: 0x000F7398
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x000F91B0 File Offset: 0x000F73B0
		[DebuggerNonUserCode]
		public PlatformAccount InviterPlatformAccount
		{
			get
			{
				return this.inviterPlatformAccount_;
			}
			set
			{
				this.inviterPlatformAccount_ = value;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x000F91BC File Offset: 0x000F73BC
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x000F91DD File Offset: 0x000F73DD
		[DebuggerNonUserCode]
		public string InviterName
		{
			get
			{
				return this.inviterName_ ?? PartyInviteReceived.InviterNameDefaultValue;
			}
			set
			{
				this.inviterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x000F91F4 File Offset: 0x000F73F4
		[DebuggerNonUserCode]
		public bool HasInviterName
		{
			get
			{
				return this.inviterName_ != null;
			}
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000F920F File Offset: 0x000F740F
		[DebuggerNonUserCode]
		public void ClearInviterName()
		{
			this.inviterName_ = null;
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x000F921C File Offset: 0x000F741C
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x000F923D File Offset: 0x000F743D
		[DebuggerNonUserCode]
		public string InviterHeroName
		{
			get
			{
				return this.inviterHeroName_ ?? PartyInviteReceived.InviterHeroNameDefaultValue;
			}
			set
			{
				this.inviterHeroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x000F9254 File Offset: 0x000F7454
		[DebuggerNonUserCode]
		public bool HasInviterHeroName
		{
			get
			{
				return this.inviterHeroName_ != null;
			}
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000F926F File Offset: 0x000F746F
		[DebuggerNonUserCode]
		public void ClearInviterHeroName()
		{
			this.inviterHeroName_ = null;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x000F927C File Offset: 0x000F747C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInviteReceived);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x000F929C File Offset: 0x000F749C
		[DebuggerNonUserCode]
		public bool Equals(PartyInviteReceived other)
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
					bool flag4 = this.InvitePartyId != other.InvitePartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviteId != other.InviteId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InviterGameAccountId != other.InviterGameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InviterBnetAccountId != other.InviterBnetAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.InviterPlatformAccount, other.InviterPlatformAccount);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.InviterName != other.InviterName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.InviterHeroName != other.InviterHeroName;
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

		// Token: 0x06003FBB RID: 16315 RVA: 0x000F93A8 File Offset: 0x000F75A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				num ^= this.InvitePartyId.GetHashCode();
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num ^= this.InviterGameAccountId.GetHashCode();
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				num ^= this.InviterBnetAccountId.GetHashCode();
			}
			bool flag = this.inviterPlatformAccount_ != null;
			if (flag)
			{
				num ^= this.InviterPlatformAccount.GetHashCode();
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num ^= this.InviterName.GetHashCode();
			}
			bool hasInviterHeroName = this.HasInviterHeroName;
			if (hasInviterHeroName)
			{
				num ^= this.InviterHeroName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x000F94A0 File Offset: 0x000F76A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000F94B8 File Offset: 0x000F76B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x000F94C4 File Offset: 0x000F76C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InvitePartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviteId);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.InviterGameAccountId);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.InviterName);
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.InviterBnetAccountId);
			}
			bool flag = this.inviterPlatformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.InviterPlatformAccount);
			}
			bool hasInviterHeroName = this.HasInviterHeroName;
			if (hasInviterHeroName)
			{
				output.WriteRawTag(66);
				output.WriteString(this.InviterHeroName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x000F95E8 File Offset: 0x000F77E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitePartyId = this.HasInvitePartyId;
			if (hasInvitePartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InvitePartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviterGameAccountId);
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviterBnetAccountId);
			}
			bool flag = this.inviterPlatformAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InviterPlatformAccount);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterName);
			}
			bool hasInviterHeroName = this.HasInviterHeroName;
			if (hasInviterHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterHeroName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000F96F0 File Offset: 0x000F78F0
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInviteReceived other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitePartyId = other.HasInvitePartyId;
				if (hasInvitePartyId)
				{
					this.InvitePartyId = other.InvitePartyId;
				}
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool hasInviterGameAccountId = other.HasInviterGameAccountId;
				if (hasInviterGameAccountId)
				{
					this.InviterGameAccountId = other.InviterGameAccountId;
				}
				bool hasInviterBnetAccountId = other.HasInviterBnetAccountId;
				if (hasInviterBnetAccountId)
				{
					this.InviterBnetAccountId = other.InviterBnetAccountId;
				}
				bool flag2 = other.inviterPlatformAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.inviterPlatformAccount_ == null;
					if (flag3)
					{
						this.InviterPlatformAccount = new PlatformAccount();
					}
					this.InviterPlatformAccount.MergeFrom(other.InviterPlatformAccount);
				}
				bool hasInviterName = other.HasInviterName;
				if (hasInviterName)
				{
					this.InviterName = other.InviterName;
				}
				bool hasInviterHeroName = other.HasInviterHeroName;
				if (hasInviterHeroName)
				{
					this.InviterHeroName = other.InviterHeroName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x000F97FF File Offset: 0x000F79FF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x000F980C File Offset: 0x000F7A0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 32U)
							{
								goto IL_0049;
							}
							this.InviterGameAccountId = input.ReadUInt32();
						}
						else
						{
							this.InviteId = input.ReadUInt64();
						}
					}
					else
					{
						this.InvitePartyId = input.ReadString();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0049;
						}
						this.InviterBnetAccountId = input.ReadUInt32();
					}
					else
					{
						this.InviterName = input.ReadString();
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_0049;
					}
					this.InviterHeroName = input.ReadString();
				}
				else
				{
					bool flag = this.inviterPlatformAccount_ == null;
					if (flag)
					{
						this.InviterPlatformAccount = new PlatformAccount();
					}
					input.ReadMessage(this.InviterPlatformAccount);
				}
				continue;
				IL_0049:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CF1 RID: 7409
		private static readonly MessageParser<PartyInviteReceived> _parser = new MessageParser<PartyInviteReceived>(() => new PartyInviteReceived());

		// Token: 0x04001CF2 RID: 7410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CF3 RID: 7411
		private int _hasBits0;

		// Token: 0x04001CF4 RID: 7412
		public const int InvitePartyIdFieldNumber = 1;

		// Token: 0x04001CF5 RID: 7413
		private static readonly string InvitePartyIdDefaultValue = "";

		// Token: 0x04001CF6 RID: 7414
		private string invitePartyId_;

		// Token: 0x04001CF7 RID: 7415
		public const int InviteIdFieldNumber = 2;

		// Token: 0x04001CF8 RID: 7416
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001CF9 RID: 7417
		private ulong inviteId_;

		// Token: 0x04001CFA RID: 7418
		public const int InviterGameAccountIdFieldNumber = 4;

		// Token: 0x04001CFB RID: 7419
		private static readonly uint InviterGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CFC RID: 7420
		private uint inviterGameAccountId_;

		// Token: 0x04001CFD RID: 7421
		public const int InviterBnetAccountIdFieldNumber = 6;

		// Token: 0x04001CFE RID: 7422
		private static readonly uint InviterBnetAccountIdDefaultValue = 0U;

		// Token: 0x04001CFF RID: 7423
		private uint inviterBnetAccountId_;

		// Token: 0x04001D00 RID: 7424
		public const int InviterPlatformAccountFieldNumber = 7;

		// Token: 0x04001D01 RID: 7425
		private PlatformAccount inviterPlatformAccount_;

		// Token: 0x04001D02 RID: 7426
		public const int InviterNameFieldNumber = 5;

		// Token: 0x04001D03 RID: 7427
		private static readonly string InviterNameDefaultValue = "";

		// Token: 0x04001D04 RID: 7428
		private string inviterName_;

		// Token: 0x04001D05 RID: 7429
		public const int InviterHeroNameFieldNumber = 8;

		// Token: 0x04001D06 RID: 7430
		private static readonly string InviterHeroNameDefaultValue = "";

		// Token: 0x04001D07 RID: 7431
		private string inviterHeroName_;
	}
}
