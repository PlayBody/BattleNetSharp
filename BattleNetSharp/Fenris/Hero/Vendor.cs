using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000189 RID: 393
	public sealed class Vendor : IMessage<Vendor>, IMessage, IEquatable<Vendor>, IDeepCloneable<Vendor>, IBufferMessage
	{
		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000A1094 File Offset: 0x0009F294
		[DebuggerNonUserCode]
		public static MessageParser<Vendor> Parser
		{
			get
			{
				return Vendor._parser;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000A10AC File Offset: 0x0009F2AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000A10D0 File Offset: 0x0009F2D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vendor.Descriptor;
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000A10E7 File Offset: 0x0009F2E7
		[DebuggerNonUserCode]
		public Vendor()
		{
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000A1108 File Offset: 0x0009F308
		[DebuggerNonUserCode]
		public Vendor(Vendor other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.seedInterval_ = other.seedInterval_;
			this.seedLevel_ = other.seedLevel_;
			this.seed_ = other.seed_.Clone();
			this.soldItem_ = other.soldItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000A1174 File Offset: 0x0009F374
		[DebuggerNonUserCode]
		public Vendor Clone()
		{
			return new Vendor(this);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000A118C File Offset: 0x0009F38C
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x000A11BD File Offset: 0x0009F3BD
		[DebuggerNonUserCode]
		public int SeedInterval
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int seedIntervalDefaultValue;
				if (flag)
				{
					seedIntervalDefaultValue = this.seedInterval_;
				}
				else
				{
					seedIntervalDefaultValue = Vendor.SeedIntervalDefaultValue;
				}
				return seedIntervalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.seedInterval_ = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000A11D8 File Offset: 0x0009F3D8
		[DebuggerNonUserCode]
		public bool HasSeedInterval
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000A11F5 File Offset: 0x0009F3F5
		[DebuggerNonUserCode]
		public void ClearSeedInterval()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000A1208 File Offset: 0x0009F408
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x000A1239 File Offset: 0x0009F439
		[DebuggerNonUserCode]
		public int SeedLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int seedLevelDefaultValue;
				if (flag)
				{
					seedLevelDefaultValue = this.seedLevel_;
				}
				else
				{
					seedLevelDefaultValue = Vendor.SeedLevelDefaultValue;
				}
				return seedLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.seedLevel_ = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000A1254 File Offset: 0x0009F454
		[DebuggerNonUserCode]
		public bool HasSeedLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000A1271 File Offset: 0x0009F471
		[DebuggerNonUserCode]
		public void ClearSeedLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000A1284 File Offset: 0x0009F484
		[DebuggerNonUserCode]
		public RepeatedField<uint> Seed
		{
			get
			{
				return this.seed_;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000A129C File Offset: 0x0009F49C
		[DebuggerNonUserCode]
		public RepeatedField<ulong> SoldItem
		{
			get
			{
				return this.soldItem_;
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000A12B4 File Offset: 0x0009F4B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vendor);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000A12D4 File Offset: 0x0009F4D4
		[DebuggerNonUserCode]
		public bool Equals(Vendor other)
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
					bool flag4 = this.SeedInterval != other.SeedInterval;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SeedLevel != other.SeedLevel;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.seed_.Equals(other.seed_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.soldItem_.Equals(other.soldItem_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000A1388 File Offset: 0x0009F588
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSeedInterval = this.HasSeedInterval;
			if (hasSeedInterval)
			{
				num ^= this.SeedInterval.GetHashCode();
			}
			bool hasSeedLevel = this.HasSeedLevel;
			if (hasSeedLevel)
			{
				num ^= this.SeedLevel.GetHashCode();
			}
			num ^= this.seed_.GetHashCode();
			num ^= this.soldItem_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000A1410 File Offset: 0x0009F610
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000A1428 File Offset: 0x0009F628
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000A1434 File Offset: 0x0009F634
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSeedInterval = this.HasSeedInterval;
			if (hasSeedInterval)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeedInterval);
			}
			bool hasSeedLevel = this.HasSeedLevel;
			if (hasSeedLevel)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeedLevel);
			}
			this.seed_.WriteTo(ref output, Vendor._repeated_seed_codec);
			this.soldItem_.WriteTo(ref output, Vendor._repeated_soldItem_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000A14C8 File Offset: 0x0009F6C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSeedInterval = this.HasSeedInterval;
			if (hasSeedInterval)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeedInterval);
			}
			bool hasSeedLevel = this.HasSeedLevel;
			if (hasSeedLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeedLevel);
			}
			num += this.seed_.CalculateSize(Vendor._repeated_seed_codec);
			num += this.soldItem_.CalculateSize(Vendor._repeated_soldItem_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000A155C File Offset: 0x0009F75C
		[DebuggerNonUserCode]
		public void MergeFrom(Vendor other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSeedInterval = other.HasSeedInterval;
				if (hasSeedInterval)
				{
					this.SeedInterval = other.SeedInterval;
				}
				bool hasSeedLevel = other.HasSeedLevel;
				if (hasSeedLevel)
				{
					this.SeedLevel = other.SeedLevel;
				}
				this.seed_.Add(other.seed_);
				this.soldItem_.Add(other.soldItem_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000A15E2 File Offset: 0x0009F7E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000A15F0 File Offset: 0x0009F7F0
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							goto IL_006D;
						}
						else
						{
							this.SeedLevel = input.ReadInt32();
						}
					}
					else
					{
						this.SeedInterval = input.ReadInt32();
					}
				}
				else
				{
					if (num3 == 26U)
					{
						goto IL_006D;
					}
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0039;
					}
					this.soldItem_.AddEntriesFrom(ref input, Vendor._repeated_soldItem_codec);
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_006D:
				this.seed_.AddEntriesFrom(ref input, Vendor._repeated_seed_codec);
			}
		}

		// Token: 0x04001260 RID: 4704
		private static readonly MessageParser<Vendor> _parser = new MessageParser<Vendor>(() => new Vendor());

		// Token: 0x04001261 RID: 4705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001262 RID: 4706
		private int _hasBits0;

		// Token: 0x04001263 RID: 4707
		public const int SeedIntervalFieldNumber = 1;

		// Token: 0x04001264 RID: 4708
		private static readonly int SeedIntervalDefaultValue = 0;

		// Token: 0x04001265 RID: 4709
		private int seedInterval_;

		// Token: 0x04001266 RID: 4710
		public const int SeedLevelFieldNumber = 2;

		// Token: 0x04001267 RID: 4711
		private static readonly int SeedLevelDefaultValue = 0;

		// Token: 0x04001268 RID: 4712
		private int seedLevel_;

		// Token: 0x04001269 RID: 4713
		public const int SeedFieldNumber = 3;

		// Token: 0x0400126A RID: 4714
		private static readonly FieldCodec<uint> _repeated_seed_codec = FieldCodec.ForUInt32(24U);

		// Token: 0x0400126B RID: 4715
		private readonly RepeatedField<uint> seed_ = new RepeatedField<uint>();

		// Token: 0x0400126C RID: 4716
		public const int SoldItemFieldNumber = 4;

		// Token: 0x0400126D RID: 4717
		private static readonly FieldCodec<ulong> _repeated_soldItem_codec = FieldCodec.ForUInt64(32U);

		// Token: 0x0400126E RID: 4718
		private readonly RepeatedField<ulong> soldItem_ = new RepeatedField<ulong>();
	}
}
