using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018E RID: 398
	public sealed class Rewards : IMessage<Rewards>, IMessage, IEquatable<Rewards>, IDeepCloneable<Rewards>, IBufferMessage
	{
		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000A3C6C File Offset: 0x000A1E6C
		[DebuggerNonUserCode]
		public static MessageParser<Rewards> Parser
		{
			get
			{
				return Rewards._parser;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000A3C84 File Offset: 0x000A1E84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x000A3CA8 File Offset: 0x000A1EA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Rewards.Descriptor;
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000A3CBF File Offset: 0x000A1EBF
		[DebuggerNonUserCode]
		public Rewards()
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		[DebuggerNonUserCode]
		public Rewards(Rewards other)
			: this()
		{
			this.zoneProgress_ = other.zoneProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000A3D00 File Offset: 0x000A1F00
		[DebuggerNonUserCode]
		public Rewards Clone()
		{
			return new Rewards(this);
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x000A3D18 File Offset: 0x000A1F18
		[DebuggerNonUserCode]
		public RepeatedField<Rewards.Types.ZoneProgress> ZoneProgress
		{
			get
			{
				return this.zoneProgress_;
			}
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000A3D30 File Offset: 0x000A1F30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Rewards);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000A3D50 File Offset: 0x000A1F50
		[DebuggerNonUserCode]
		public bool Equals(Rewards other)
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
					bool flag4 = !this.zoneProgress_.Equals(other.zoneProgress_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000A3DAC File Offset: 0x000A1FAC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.zoneProgress_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000A3DEC File Offset: 0x000A1FEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000A3E04 File Offset: 0x000A2004
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000A3E10 File Offset: 0x000A2010
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.zoneProgress_.WriteTo(ref output, Rewards._repeated_zoneProgress_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000A3E4C File Offset: 0x000A204C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.zoneProgress_.CalculateSize(Rewards._repeated_zoneProgress_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000A3E94 File Offset: 0x000A2094
		[DebuggerNonUserCode]
		public void MergeFrom(Rewards other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.zoneProgress_.Add(other.zoneProgress_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000A3ED6 File Offset: 0x000A20D6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000A3EE4 File Offset: 0x000A20E4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.zoneProgress_.AddEntriesFrom(ref input, Rewards._repeated_zoneProgress_codec);
				}
			}
		}

		// Token: 0x040012C7 RID: 4807
		private static readonly MessageParser<Rewards> _parser = new MessageParser<Rewards>(() => new Rewards());

		// Token: 0x040012C8 RID: 4808
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012C9 RID: 4809
		public const int ZoneProgressFieldNumber = 1;

		// Token: 0x040012CA RID: 4810
		private static readonly FieldCodec<Rewards.Types.ZoneProgress> _repeated_zoneProgress_codec = FieldCodec.ForMessage<Rewards.Types.ZoneProgress>(10U, Rewards.Types.ZoneProgress.Parser);

		// Token: 0x040012CB RID: 4811
		private readonly RepeatedField<Rewards.Types.ZoneProgress> zoneProgress_ = new RepeatedField<Rewards.Types.ZoneProgress>();

		// Token: 0x02000CA9 RID: 3241
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001481 RID: 5249
			public sealed class ZoneProgress : IMessage<Rewards.Types.ZoneProgress>, IMessage, IEquatable<Rewards.Types.ZoneProgress>, IDeepCloneable<Rewards.Types.ZoneProgress>, IBufferMessage
			{
				// Token: 0x17003AC2 RID: 15042
				// (get) Token: 0x0600E6A3 RID: 59043 RVA: 0x004D8BC8 File Offset: 0x004D6DC8
				[DebuggerNonUserCode]
				public static MessageParser<Rewards.Types.ZoneProgress> Parser
				{
					get
					{
						return Rewards.Types.ZoneProgress._parser;
					}
				}

				// Token: 0x17003AC3 RID: 15043
				// (get) Token: 0x0600E6A4 RID: 59044 RVA: 0x004D8BE0 File Offset: 0x004D6DE0
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return Rewards.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AC4 RID: 15044
				// (get) Token: 0x0600E6A5 RID: 59045 RVA: 0x004D8C04 File Offset: 0x004D6E04
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return Rewards.Types.ZoneProgress.Descriptor;
					}
				}

				// Token: 0x0600E6A6 RID: 59046 RVA: 0x004D8C1B File Offset: 0x004D6E1B
				[DebuggerNonUserCode]
				public ZoneProgress()
				{
				}

				// Token: 0x0600E6A7 RID: 59047 RVA: 0x004D8C25 File Offset: 0x004D6E25
				[DebuggerNonUserCode]
				public ZoneProgress(Rewards.Types.ZoneProgress other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.rewardClaimedFlags_ = other.rewardClaimedFlags_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E6A8 RID: 59048 RVA: 0x004D8C58 File Offset: 0x004D6E58
				[DebuggerNonUserCode]
				public Rewards.Types.ZoneProgress Clone()
				{
					return new Rewards.Types.ZoneProgress(this);
				}

				// Token: 0x17003AC5 RID: 15045
				// (get) Token: 0x0600E6A9 RID: 59049 RVA: 0x004D8C70 File Offset: 0x004D6E70
				// (set) Token: 0x0600E6AA RID: 59050 RVA: 0x004D8CA1 File Offset: 0x004D6EA1
				[DebuggerNonUserCode]
				public uint RewardClaimedFlags
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint rewardClaimedFlagsDefaultValue;
						if (flag)
						{
							rewardClaimedFlagsDefaultValue = this.rewardClaimedFlags_;
						}
						else
						{
							rewardClaimedFlagsDefaultValue = Rewards.Types.ZoneProgress.RewardClaimedFlagsDefaultValue;
						}
						return rewardClaimedFlagsDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.rewardClaimedFlags_ = value;
					}
				}

				// Token: 0x17003AC6 RID: 15046
				// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x004D8CBC File Offset: 0x004D6EBC
				[DebuggerNonUserCode]
				public bool HasRewardClaimedFlags
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E6AC RID: 59052 RVA: 0x004D8CD9 File Offset: 0x004D6ED9
				[DebuggerNonUserCode]
				public void ClearRewardClaimedFlags()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x0600E6AD RID: 59053 RVA: 0x004D8CEC File Offset: 0x004D6EEC
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as Rewards.Types.ZoneProgress);
				}

				// Token: 0x0600E6AE RID: 59054 RVA: 0x004D8D0C File Offset: 0x004D6F0C
				[DebuggerNonUserCode]
				public bool Equals(Rewards.Types.ZoneProgress other)
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
							bool flag4 = this.RewardClaimedFlags != other.RewardClaimedFlags;
							flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
					return flag2;
				}

				// Token: 0x0600E6AF RID: 59055 RVA: 0x004D8D64 File Offset: 0x004D6F64
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasRewardClaimedFlags = this.HasRewardClaimedFlags;
					if (hasRewardClaimedFlags)
					{
						num ^= this.RewardClaimedFlags.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E6B0 RID: 59056 RVA: 0x004D8DB4 File Offset: 0x004D6FB4
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E6B1 RID: 59057 RVA: 0x004D8DCC File Offset: 0x004D6FCC
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E6B2 RID: 59058 RVA: 0x004D8DD8 File Offset: 0x004D6FD8
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasRewardClaimedFlags = this.HasRewardClaimedFlags;
					if (hasRewardClaimedFlags)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.RewardClaimedFlags);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E6B3 RID: 59059 RVA: 0x004D8E24 File Offset: 0x004D7024
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasRewardClaimedFlags = this.HasRewardClaimedFlags;
					if (hasRewardClaimedFlags)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RewardClaimedFlags);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E6B4 RID: 59060 RVA: 0x004D8E74 File Offset: 0x004D7074
				[DebuggerNonUserCode]
				public void MergeFrom(Rewards.Types.ZoneProgress other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasRewardClaimedFlags = other.HasRewardClaimedFlags;
						if (hasRewardClaimedFlags)
						{
							this.RewardClaimedFlags = other.RewardClaimedFlags;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E6B5 RID: 59061 RVA: 0x004D8EBD File Offset: 0x004D70BD
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E6B6 RID: 59062 RVA: 0x004D8EC8 File Offset: 0x004D70C8
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
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RewardClaimedFlags = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A417 RID: 42007
				private static readonly MessageParser<Rewards.Types.ZoneProgress> _parser = new MessageParser<Rewards.Types.ZoneProgress>(() => new Rewards.Types.ZoneProgress());

				// Token: 0x0400A418 RID: 42008
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A419 RID: 42009
				private int _hasBits0;

				// Token: 0x0400A41A RID: 42010
				public const int RewardClaimedFlagsFieldNumber = 1;

				// Token: 0x0400A41B RID: 42011
				private static readonly uint RewardClaimedFlagsDefaultValue = 0U;

				// Token: 0x0400A41C RID: 42012
				private uint rewardClaimedFlags_;
			}
		}
	}
}
