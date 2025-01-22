using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x02000107 RID: 263
	public sealed class Trader : IMessage<Trader>, IMessage, IEquatable<Trader>, IDeepCloneable<Trader>, IBufferMessage
	{
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00058D70 File Offset: 0x00056F70
		[DebuggerNonUserCode]
		public static MessageParser<Trader> Parser
		{
			get
			{
				return Trader._parser;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00058D88 File Offset: 0x00056F88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00058DAC File Offset: 0x00056FAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Trader.Descriptor;
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00058DC3 File Offset: 0x00056FC3
		[DebuggerNonUserCode]
		public Trader()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00058DD4 File Offset: 0x00056FD4
		[DebuggerNonUserCode]
		public Trader(Trader other)
			: this()
		{
			this.heroId_ = other.heroId_;
			Trader.TraderOneofCase traderCase = other.TraderCase;
			Trader.TraderOneofCase traderOneofCase = traderCase;
			if (traderOneofCase != Trader.TraderOneofCase.GameAccountId)
			{
				if (traderOneofCase == Trader.TraderOneofCase.ClanId)
				{
					this.ClanId = other.ClanId;
				}
			}
			else
			{
				this.GameAccountId = other.GameAccountId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00058E3C File Offset: 0x0005703C
		[DebuggerNonUserCode]
		public Trader Clone()
		{
			return new Trader(this);
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00058E54 File Offset: 0x00057054
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00058E75 File Offset: 0x00057075
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? Trader.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00058E8C File Offset: 0x0005708C
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00058EA7 File Offset: 0x000570A7
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00058EB4 File Offset: 0x000570B4
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00058EDC File Offset: 0x000570DC
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				return this.HasGameAccountId ? ((uint)this.trader_) : 0U;
			}
			set
			{
				this.trader_ = value;
				this.traderCase_ = Trader.TraderOneofCase.GameAccountId;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00058EF4 File Offset: 0x000570F4
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return this.traderCase_ == Trader.TraderOneofCase.GameAccountId;
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00058F10 File Offset: 0x00057110
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				this.ClearTrader();
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00058F34 File Offset: 0x00057134
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00058F60 File Offset: 0x00057160
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.HasClanId ? ((string)this.trader_) : "";
			}
			set
			{
				this.trader_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.traderCase_ = Trader.TraderOneofCase.ClanId;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00058F7C File Offset: 0x0005717C
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.traderCase_ == Trader.TraderOneofCase.ClanId;
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00058F98 File Offset: 0x00057198
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				this.ClearTrader();
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x00058FBC File Offset: 0x000571BC
		[DebuggerNonUserCode]
		public Trader.TraderOneofCase TraderCase
		{
			get
			{
				return this.traderCase_;
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00058FD4 File Offset: 0x000571D4
		[DebuggerNonUserCode]
		public void ClearTrader()
		{
			this.traderCase_ = Trader.TraderOneofCase.None;
			this.trader_ = null;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00058FE8 File Offset: 0x000571E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Trader);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00059008 File Offset: 0x00057208
		[DebuggerNonUserCode]
		public bool Equals(Trader other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ClanId != other.ClanId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TraderCase != other.TraderCase;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000590B4 File Offset: 0x000572B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			num ^= (int)this.traderCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00059140 File Offset: 0x00057340
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00059158 File Offset: 0x00057358
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00059164 File Offset: 0x00057364
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClanId);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HeroId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000591F4 File Offset: 0x000573F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00059280 File Offset: 0x00057480
		[DebuggerNonUserCode]
		public void MergeFrom(Trader other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				Trader.TraderOneofCase traderCase = other.TraderCase;
				Trader.TraderOneofCase traderOneofCase = traderCase;
				if (traderOneofCase != Trader.TraderOneofCase.GameAccountId)
				{
					if (traderOneofCase == Trader.TraderOneofCase.ClanId)
					{
						this.ClanId = other.ClanId;
					}
				}
				else
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000592FC File Offset: 0x000574FC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00059308 File Offset: 0x00057508
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HeroId = input.ReadString();
						}
					}
					else
					{
						this.ClanId = input.ReadString();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040009E9 RID: 2537
		private static readonly MessageParser<Trader> _parser = new MessageParser<Trader>(() => new Trader());

		// Token: 0x040009EA RID: 2538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009EB RID: 2539
		public const int HeroIdFieldNumber = 3;

		// Token: 0x040009EC RID: 2540
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x040009ED RID: 2541
		private string heroId_;

		// Token: 0x040009EE RID: 2542
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040009EF RID: 2543
		public const int ClanIdFieldNumber = 2;

		// Token: 0x040009F0 RID: 2544
		private object trader_;

		// Token: 0x040009F1 RID: 2545
		private Trader.TraderOneofCase traderCase_ = Trader.TraderOneofCase.None;

		// Token: 0x02000C24 RID: 3108
		public enum TraderOneofCase
		{
			// Token: 0x04009378 RID: 37752
			None,
			// Token: 0x04009379 RID: 37753
			GameAccountId,
			// Token: 0x0400937A RID: 37754
			ClanId
		}
	}
}
