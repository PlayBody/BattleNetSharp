using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000197 RID: 407
	public sealed class HeroStateWaypointsMessage : IMessage<HeroStateWaypointsMessage>, IMessage, IEquatable<HeroStateWaypointsMessage>, IDeepCloneable<HeroStateWaypointsMessage>, IBufferMessage
	{
		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
		[DebuggerNonUserCode]
		public static MessageParser<HeroStateWaypointsMessage> Parser
		{
			get
			{
				return HeroStateWaypointsMessage._parser;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000A9DDC File Offset: 0x000A7FDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroStateWaypointsMessage.Descriptor;
			}
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000A9DF3 File Offset: 0x000A7FF3
		[DebuggerNonUserCode]
		public HeroStateWaypointsMessage()
		{
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000A9E14 File Offset: 0x000A8014
		[DebuggerNonUserCode]
		public HeroStateWaypointsMessage(HeroStateWaypointsMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.waypointsActivated_ = other.waypointsActivated_.Clone();
			this.fogOfWarSnos_ = other.fogOfWarSnos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000A9E74 File Offset: 0x000A8074
		[DebuggerNonUserCode]
		public HeroStateWaypointsMessage Clone()
		{
			return new HeroStateWaypointsMessage(this);
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000A9E8C File Offset: 0x000A808C
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x000A9EBD File Offset: 0x000A80BD
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = HeroStateWaypointsMessage.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000A9ED8 File Offset: 0x000A80D8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000A9EF5 File Offset: 0x000A80F5
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000A9F08 File Offset: 0x000A8108
		[DebuggerNonUserCode]
		public RepeatedField<uint> WaypointsActivated
		{
			get
			{
				return this.waypointsActivated_;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000A9F20 File Offset: 0x000A8120
		[DebuggerNonUserCode]
		public RepeatedField<int> FogOfWarSnos
		{
			get
			{
				return this.fogOfWarSnos_;
			}
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000A9F38 File Offset: 0x000A8138
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroStateWaypointsMessage);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000A9F58 File Offset: 0x000A8158
		[DebuggerNonUserCode]
		public bool Equals(HeroStateWaypointsMessage other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.waypointsActivated_.Equals(other.waypointsActivated_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.fogOfWarSnos_.Equals(other.fogOfWarSnos_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000A9FEC File Offset: 0x000A81EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			num ^= this.waypointsActivated_.GetHashCode();
			num ^= this.fogOfWarSnos_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000AA058 File Offset: 0x000A8258
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000AA070 File Offset: 0x000A8270
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000AA07C File Offset: 0x000A827C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			this.waypointsActivated_.WriteTo(ref output, HeroStateWaypointsMessage._repeated_waypointsActivated_codec);
			this.fogOfWarSnos_.WriteTo(ref output, HeroStateWaypointsMessage._repeated_fogOfWarSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000AA0EC File Offset: 0x000A82EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			num += this.waypointsActivated_.CalculateSize(HeroStateWaypointsMessage._repeated_waypointsActivated_codec);
			num += this.fogOfWarSnos_.CalculateSize(HeroStateWaypointsMessage._repeated_fogOfWarSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000AA160 File Offset: 0x000A8360
		[DebuggerNonUserCode]
		public void MergeFrom(HeroStateWaypointsMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this.waypointsActivated_.Add(other.waypointsActivated_);
				this.fogOfWarSnos_.Add(other.fogOfWarSnos_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000AA1CD File Offset: 0x000A83CD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_002F;
						}
						goto IL_0053;
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					if (num3 == 18U)
					{
						goto IL_0053;
					}
					if (num3 != 26U && num3 != 29U)
					{
						goto IL_002F;
					}
					this.fogOfWarSnos_.AddEntriesFrom(ref input, HeroStateWaypointsMessage._repeated_fogOfWarSnos_codec);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0053:
				this.waypointsActivated_.AddEntriesFrom(ref input, HeroStateWaypointsMessage._repeated_waypointsActivated_codec);
			}
		}

		// Token: 0x0400138C RID: 5004
		private static readonly MessageParser<HeroStateWaypointsMessage> _parser = new MessageParser<HeroStateWaypointsMessage>(() => new HeroStateWaypointsMessage());

		// Token: 0x0400138D RID: 5005
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400138E RID: 5006
		private int _hasBits0;

		// Token: 0x0400138F RID: 5007
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001390 RID: 5008
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001391 RID: 5009
		private uint gameAccountId_;

		// Token: 0x04001392 RID: 5010
		public const int WaypointsActivatedFieldNumber = 2;

		// Token: 0x04001393 RID: 5011
		private static readonly FieldCodec<uint> _repeated_waypointsActivated_codec = FieldCodec.ForUInt32(16U);

		// Token: 0x04001394 RID: 5012
		private readonly RepeatedField<uint> waypointsActivated_ = new RepeatedField<uint>();

		// Token: 0x04001395 RID: 5013
		public const int FogOfWarSnosFieldNumber = 3;

		// Token: 0x04001396 RID: 5014
		private static readonly FieldCodec<int> _repeated_fogOfWarSnos_codec = FieldCodec.ForSFixed32(29U);

		// Token: 0x04001397 RID: 5015
		private readonly RepeatedField<int> fogOfWarSnos_ = new RepeatedField<int>();
	}
}
