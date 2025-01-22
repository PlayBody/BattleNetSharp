using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000193 RID: 403
	public sealed class ZoneProgress : IMessage<ZoneProgress>, IMessage, IEquatable<ZoneProgress>, IDeepCloneable<ZoneProgress>, IBufferMessage
	{
		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000A701C File Offset: 0x000A521C
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgress> Parser
		{
			get
			{
				return ZoneProgress._parser;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000A7034 File Offset: 0x000A5234
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000A7058 File Offset: 0x000A5258
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgress.Descriptor;
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000A706F File Offset: 0x000A526F
		[DebuggerNonUserCode]
		public ZoneProgress()
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000A7079 File Offset: 0x000A5279
		[DebuggerNonUserCode]
		public ZoneProgress(ZoneProgress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.rewardClaimedFlags_ = other.rewardClaimedFlags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000A70AC File Offset: 0x000A52AC
		[DebuggerNonUserCode]
		public ZoneProgress Clone()
		{
			return new ZoneProgress(this);
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000A70C4 File Offset: 0x000A52C4
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x000A70F5 File Offset: 0x000A52F5
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
					rewardClaimedFlagsDefaultValue = ZoneProgress.RewardClaimedFlagsDefaultValue;
				}
				return rewardClaimedFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.rewardClaimedFlags_ = value;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000A7110 File Offset: 0x000A5310
		[DebuggerNonUserCode]
		public bool HasRewardClaimedFlags
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000A712D File Offset: 0x000A532D
		[DebuggerNonUserCode]
		public void ClearRewardClaimedFlags()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000A7140 File Offset: 0x000A5340
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgress);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000A7160 File Offset: 0x000A5360
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgress other)
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

		// Token: 0x06002A91 RID: 10897 RVA: 0x000A71B8 File Offset: 0x000A53B8
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

		// Token: 0x06002A92 RID: 10898 RVA: 0x000A7208 File Offset: 0x000A5408
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000A7220 File Offset: 0x000A5420
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000A722C File Offset: 0x000A542C
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

		// Token: 0x06002A95 RID: 10901 RVA: 0x000A7278 File Offset: 0x000A5478
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

		// Token: 0x06002A96 RID: 10902 RVA: 0x000A72C8 File Offset: 0x000A54C8
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgress other)
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

		// Token: 0x06002A97 RID: 10903 RVA: 0x000A7311 File Offset: 0x000A5511
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000A731C File Offset: 0x000A551C
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

		// Token: 0x04001326 RID: 4902
		private static readonly MessageParser<ZoneProgress> _parser = new MessageParser<ZoneProgress>(() => new ZoneProgress());

		// Token: 0x04001327 RID: 4903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001328 RID: 4904
		private int _hasBits0;

		// Token: 0x04001329 RID: 4905
		public const int RewardClaimedFlagsFieldNumber = 1;

		// Token: 0x0400132A RID: 4906
		private static readonly uint RewardClaimedFlagsDefaultValue = 0U;

		// Token: 0x0400132B RID: 4907
		private uint rewardClaimedFlags_;
	}
}
