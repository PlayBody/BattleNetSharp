using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000765 RID: 1893
	public sealed class SeasonInfo : IMessage<SeasonInfo>, IMessage, IEquatable<SeasonInfo>, IDeepCloneable<SeasonInfo>, IBufferMessage
	{
		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x002A6038 File Offset: 0x002A4238
		[DebuggerNonUserCode]
		public static MessageParser<SeasonInfo> Parser
		{
			get
			{
				return SeasonInfo._parser;
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x002A6050 File Offset: 0x002A4250
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x002A6074 File Offset: 0x002A4274
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeasonInfo.Descriptor;
			}
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x002A608B File Offset: 0x002A428B
		[DebuggerNonUserCode]
		public SeasonInfo()
		{
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x002A60A0 File Offset: 0x002A42A0
		[DebuggerNonUserCode]
		public SeasonInfo(SeasonInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.seasons_ = other.seasons_.Clone();
			this.activeSeason_ = other.activeSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x002A60F0 File Offset: 0x002A42F0
		[DebuggerNonUserCode]
		public SeasonInfo Clone()
		{
			return new SeasonInfo(this);
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x002A6108 File Offset: 0x002A4308
		[DebuggerNonUserCode]
		public RepeatedField<Season> Seasons
		{
			get
			{
				return this.seasons_;
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x002A6120 File Offset: 0x002A4320
		// (set) Token: 0x0600AE15 RID: 44565 RVA: 0x002A6151 File Offset: 0x002A4351
		[DebuggerNonUserCode]
		public int ActiveSeason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int activeSeasonDefaultValue;
				if (flag)
				{
					activeSeasonDefaultValue = this.activeSeason_;
				}
				else
				{
					activeSeasonDefaultValue = SeasonInfo.ActiveSeasonDefaultValue;
				}
				return activeSeasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.activeSeason_ = value;
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600AE16 RID: 44566 RVA: 0x002A616C File Offset: 0x002A436C
		[DebuggerNonUserCode]
		public bool HasActiveSeason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x002A6189 File Offset: 0x002A4389
		[DebuggerNonUserCode]
		public void ClearActiveSeason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x002A619C File Offset: 0x002A439C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeasonInfo);
		}

		// Token: 0x0600AE19 RID: 44569 RVA: 0x002A61BC File Offset: 0x002A43BC
		[DebuggerNonUserCode]
		public bool Equals(SeasonInfo other)
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
					bool flag4 = !this.seasons_.Equals(other.seasons_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ActiveSeason != other.ActiveSeason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AE1A RID: 44570 RVA: 0x002A6230 File Offset: 0x002A4430
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.seasons_.GetHashCode();
			bool hasActiveSeason = this.HasActiveSeason;
			if (hasActiveSeason)
			{
				num ^= this.ActiveSeason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x002A6290 File Offset: 0x002A4490
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE1C RID: 44572 RVA: 0x002A62A8 File Offset: 0x002A44A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x002A62B4 File Offset: 0x002A44B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.seasons_.WriteTo(ref output, SeasonInfo._repeated_seasons_codec);
			bool hasActiveSeason = this.HasActiveSeason;
			if (hasActiveSeason)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActiveSeason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE1E RID: 44574 RVA: 0x002A6314 File Offset: 0x002A4514
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.seasons_.CalculateSize(SeasonInfo._repeated_seasons_codec);
			bool hasActiveSeason = this.HasActiveSeason;
			if (hasActiveSeason)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveSeason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE1F RID: 44575 RVA: 0x002A6378 File Offset: 0x002A4578
		[DebuggerNonUserCode]
		public void MergeFrom(SeasonInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.seasons_.Add(other.seasons_);
				bool hasActiveSeason = other.HasActiveSeason;
				if (hasActiveSeason)
				{
					this.ActiveSeason = other.ActiveSeason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x002A63D3 File Offset: 0x002A45D3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x002A63E0 File Offset: 0x002A45E0
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActiveSeason = input.ReadInt32();
					}
				}
				else
				{
					this.seasons_.AddEntriesFrom(ref input, SeasonInfo._repeated_seasons_codec);
				}
			}
		}

		// Token: 0x04004E6E RID: 20078
		private static readonly MessageParser<SeasonInfo> _parser = new MessageParser<SeasonInfo>(() => new SeasonInfo());

		// Token: 0x04004E6F RID: 20079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E70 RID: 20080
		private int _hasBits0;

		// Token: 0x04004E71 RID: 20081
		public const int SeasonsFieldNumber = 1;

		// Token: 0x04004E72 RID: 20082
		private static readonly FieldCodec<Season> _repeated_seasons_codec = FieldCodec.ForMessage<Season>(10U, Season.Parser);

		// Token: 0x04004E73 RID: 20083
		private readonly RepeatedField<Season> seasons_ = new RepeatedField<Season>();

		// Token: 0x04004E74 RID: 20084
		public const int ActiveSeasonFieldNumber = 2;

		// Token: 0x04004E75 RID: 20085
		private static readonly int ActiveSeasonDefaultValue = 0;

		// Token: 0x04004E76 RID: 20086
		private int activeSeason_;
	}
}
