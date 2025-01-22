using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000255 RID: 597
	public sealed class PartyFindGameRequest : IMessage<PartyFindGameRequest>, IMessage, IEquatable<PartyFindGameRequest>, IDeepCloneable<PartyFindGameRequest>, IBufferMessage
	{
		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000FB238 File Offset: 0x000F9438
		[DebuggerNonUserCode]
		public static MessageParser<PartyFindGameRequest> Parser
		{
			get
			{
				return PartyFindGameRequest._parser;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x000FB250 File Offset: 0x000F9450
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[69];
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x000FB274 File Offset: 0x000F9474
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyFindGameRequest.Descriptor;
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x000FB28B File Offset: 0x000F948B
		[DebuggerNonUserCode]
		public PartyFindGameRequest()
		{
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x000FB298 File Offset: 0x000F9498
		[DebuggerNonUserCode]
		public PartyFindGameRequest(PartyFindGameRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this.snoWorld_ = other.snoWorld_;
			this.isHardcoreHero_ = other.isHardcoreHero_;
			this.isSeasonalHero_ = other.isSeasonalHero_;
			this.gameAccountId_ = other.gameAccountId_;
			this.partyId_ = other.partyId_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x000FB320 File Offset: 0x000F9520
		[DebuggerNonUserCode]
		public PartyFindGameRequest Clone()
		{
			return new PartyFindGameRequest(this);
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x000FB338 File Offset: 0x000F9538
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x000FB369 File Offset: 0x000F9569
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = PartyFindGameRequest.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x000FB384 File Offset: 0x000F9584
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x000FB3A1 File Offset: 0x000F95A1
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x000FB3B4 File Offset: 0x000F95B4
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x000FB3E5 File Offset: 0x000F95E5
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = PartyFindGameRequest.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x000FB400 File Offset: 0x000F9600
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000FB41D File Offset: 0x000F961D
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x000FB430 File Offset: 0x000F9630
		// (set) Token: 0x06004047 RID: 16455 RVA: 0x000FB461 File Offset: 0x000F9661
		[DebuggerNonUserCode]
		public bool IsHardcoreHero
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isHardcoreHeroDefaultValue;
				if (flag)
				{
					isHardcoreHeroDefaultValue = this.isHardcoreHero_;
				}
				else
				{
					isHardcoreHeroDefaultValue = PartyFindGameRequest.IsHardcoreHeroDefaultValue;
				}
				return isHardcoreHeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isHardcoreHero_ = value;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x000FB47C File Offset: 0x000F967C
		[DebuggerNonUserCode]
		public bool HasIsHardcoreHero
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x000FB499 File Offset: 0x000F9699
		[DebuggerNonUserCode]
		public void ClearIsHardcoreHero()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x000FB4AC File Offset: 0x000F96AC
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x000FB4DD File Offset: 0x000F96DD
		[DebuggerNonUserCode]
		public bool IsSeasonalHero
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isSeasonalHeroDefaultValue;
				if (flag)
				{
					isSeasonalHeroDefaultValue = this.isSeasonalHero_;
				}
				else
				{
					isSeasonalHeroDefaultValue = PartyFindGameRequest.IsSeasonalHeroDefaultValue;
				}
				return isSeasonalHeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isSeasonalHero_ = value;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x000FB4F8 File Offset: 0x000F96F8
		[DebuggerNonUserCode]
		public bool HasIsSeasonalHero
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x000FB515 File Offset: 0x000F9715
		[DebuggerNonUserCode]
		public void ClearIsSeasonalHero()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x000FB528 File Offset: 0x000F9728
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x000FB55A File Offset: 0x000F975A
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PartyFindGameRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x000FB574 File Offset: 0x000F9774
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x000FB592 File Offset: 0x000F9792
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x000FB5A4 File Offset: 0x000F97A4
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x000FB5C5 File Offset: 0x000F97C5
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyFindGameRequest.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x000FB5DC File Offset: 0x000F97DC
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000FB5F7 File Offset: 0x000F97F7
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x000FB604 File Offset: 0x000F9804
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x000FB625 File Offset: 0x000F9825
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? PartyFindGameRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x000FB63C File Offset: 0x000F983C
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000FB65A File Offset: 0x000F985A
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000FB664 File Offset: 0x000F9864
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyFindGameRequest);
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x000FB684 File Offset: 0x000F9884
		[DebuggerNonUserCode]
		public bool Equals(PartyFindGameRequest other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoWorld != other.SnoWorld;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsHardcoreHero != other.IsHardcoreHero;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsSeasonalHero != other.IsSeasonalHero;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GameAccountId != other.GameAccountId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PartyId != other.PartyId;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SessionKey != other.SessionKey;
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

		// Token: 0x0600405C RID: 16476 RVA: 0x000FB78C File Offset: 0x000F998C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasIsHardcoreHero = this.HasIsHardcoreHero;
			if (hasIsHardcoreHero)
			{
				num ^= this.IsHardcoreHero.GetHashCode();
			}
			bool hasIsSeasonalHero = this.HasIsSeasonalHero;
			if (hasIsSeasonalHero)
			{
				num ^= this.IsSeasonalHero.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x000FB888 File Offset: 0x000F9A88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x000FB8A0 File Offset: 0x000F9AA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x000FB8AC File Offset: 0x000F9AAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool hasIsHardcoreHero = this.HasIsHardcoreHero;
			if (hasIsHardcoreHero)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsHardcoreHero);
			}
			bool hasIsSeasonalHero = this.HasIsSeasonalHero;
			if (hasIsSeasonalHero)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSeasonalHero);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PartyId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x000FB9CC File Offset: 0x000F9BCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 5;
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool hasIsHardcoreHero = this.HasIsHardcoreHero;
			if (hasIsHardcoreHero)
			{
				num += 2;
			}
			bool hasIsSeasonalHero = this.HasIsSeasonalHero;
			if (hasIsSeasonalHero)
			{
				num += 2;
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
		[DebuggerNonUserCode]
		public void MergeFrom(PartyFindGameRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasIsHardcoreHero = other.HasIsHardcoreHero;
				if (hasIsHardcoreHero)
				{
					this.IsHardcoreHero = other.IsHardcoreHero;
				}
				bool hasIsSeasonalHero = other.HasIsSeasonalHero;
				if (hasIsSeasonalHero)
				{
					this.IsSeasonalHero = other.IsSeasonalHero;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x000FBB8A File Offset: 0x000F9D8A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x000FBB98 File Offset: 0x000F9D98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.IsHardcoreHero = input.ReadBool();
						}
						else
						{
							this.SnoWorld = input.ReadSFixed32();
						}
					}
					else
					{
						this.SnoSubzone = input.ReadSFixed32();
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0046;
						}
						this.GameAccountId = input.ReadUInt32();
					}
					else
					{
						this.IsSeasonalHero = input.ReadBool();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 58U)
					{
						goto IL_0046;
					}
					this.SessionKey = input.ReadBytes();
				}
				else
				{
					this.PartyId = input.ReadString();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D39 RID: 7481
		private static readonly MessageParser<PartyFindGameRequest> _parser = new MessageParser<PartyFindGameRequest>(() => new PartyFindGameRequest());

		// Token: 0x04001D3A RID: 7482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D3B RID: 7483
		private int _hasBits0;

		// Token: 0x04001D3C RID: 7484
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x04001D3D RID: 7485
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x04001D3E RID: 7486
		private int snoSubzone_;

		// Token: 0x04001D3F RID: 7487
		public const int SnoWorldFieldNumber = 2;

		// Token: 0x04001D40 RID: 7488
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04001D41 RID: 7489
		private int snoWorld_;

		// Token: 0x04001D42 RID: 7490
		public const int IsHardcoreHeroFieldNumber = 3;

		// Token: 0x04001D43 RID: 7491
		private static readonly bool IsHardcoreHeroDefaultValue = false;

		// Token: 0x04001D44 RID: 7492
		private bool isHardcoreHero_;

		// Token: 0x04001D45 RID: 7493
		public const int IsSeasonalHeroFieldNumber = 4;

		// Token: 0x04001D46 RID: 7494
		private static readonly bool IsSeasonalHeroDefaultValue = false;

		// Token: 0x04001D47 RID: 7495
		private bool isSeasonalHero_;

		// Token: 0x04001D48 RID: 7496
		public const int GameAccountIdFieldNumber = 5;

		// Token: 0x04001D49 RID: 7497
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001D4A RID: 7498
		private uint gameAccountId_;

		// Token: 0x04001D4B RID: 7499
		public const int PartyIdFieldNumber = 6;

		// Token: 0x04001D4C RID: 7500
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001D4D RID: 7501
		private string partyId_;

		// Token: 0x04001D4E RID: 7502
		public const int SessionKeyFieldNumber = 7;

		// Token: 0x04001D4F RID: 7503
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001D50 RID: 7504
		private ByteString sessionKey_;
	}
}
