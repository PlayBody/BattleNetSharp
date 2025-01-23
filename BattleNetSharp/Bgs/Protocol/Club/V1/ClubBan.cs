using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043A RID: 1082
	public sealed class ClubBan : IMessage<ClubBan>, IMessage, IEquatable<ClubBan>, IDeepCloneable<ClubBan>, IBufferMessage
	{
		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006A2C RID: 27180 RVA: 0x0019AE80 File Offset: 0x00199080
		[DebuggerNonUserCode]
		public static MessageParser<ClubBan> Parser
		{
			get
			{
				return ClubBan._parser;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x0019AE98 File Offset: 0x00199098
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubBanReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x0019AEBC File Offset: 0x001990BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubBan.Descriptor;
			}
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x0019AED3 File Offset: 0x001990D3
		[DebuggerNonUserCode]
		public ClubBan()
		{
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x0019AEE8 File Offset: 0x001990E8
		[DebuggerNonUserCode]
		public ClubBan(ClubBan other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this.creator_ = ((other.creator_ != null) ? other.creator_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.reason_ = other.reason_;
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x0019AF88 File Offset: 0x00199188
		[DebuggerNonUserCode]
		public ClubBan Clone()
		{
			return new ClubBan(this);
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06006A32 RID: 27186 RVA: 0x0019AFA0 File Offset: 0x001991A0
		// (set) Token: 0x06006A33 RID: 27187 RVA: 0x0019AFB8 File Offset: 0x001991B8
		[DebuggerNonUserCode]
		public MemberId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06006A34 RID: 27188 RVA: 0x0019AFC4 File Offset: 0x001991C4
		// (set) Token: 0x06006A35 RID: 27189 RVA: 0x0019AFE5 File Offset: 0x001991E5
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? ClubBan.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06006A36 RID: 27190 RVA: 0x0019AFFC File Offset: 0x001991FC
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0019B017 File Offset: 0x00199217
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x0019B024 File Offset: 0x00199224
		// (set) Token: 0x06006A39 RID: 27193 RVA: 0x0019B03C File Offset: 0x0019923C
		[DebuggerNonUserCode]
		public MemberDescription Creator
		{
			get
			{
				return this.creator_;
			}
			set
			{
				this.creator_ = value;
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06006A3A RID: 27194 RVA: 0x0019B048 File Offset: 0x00199248
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x0019B060 File Offset: 0x00199260
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x0019B081 File Offset: 0x00199281
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				return this.reason_ ?? ClubBan.ReasonDefaultValue;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x0019B098 File Offset: 0x00199298
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return this.reason_ != null;
			}
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0019B0B3 File Offset: 0x001992B3
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this.reason_ = null;
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06006A3F RID: 27199 RVA: 0x0019B0C0 File Offset: 0x001992C0
		// (set) Token: 0x06006A40 RID: 27200 RVA: 0x0019B0F1 File Offset: 0x001992F1
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ClubBan.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x0019B10C File Offset: 0x0019930C
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x0019B129 File Offset: 0x00199329
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x0019B13C File Offset: 0x0019933C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubBan);
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x0019B15C File Offset: 0x0019935C
		[DebuggerNonUserCode]
		public bool Equals(ClubBan other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BattleTag != other.BattleTag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Creator, other.Creator);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Reason != other.Reason;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CreationTime != other.CreationTime;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x0019B250 File Offset: 0x00199450
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag2 = this.creator_ != null;
			if (flag2)
			{
				num ^= this.Creator.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0019B31C File Offset: 0x0019951C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x0019B334 File Offset: 0x00199534
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0019B340 File Offset: 0x00199540
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BattleTag);
			}
			bool flag2 = this.creator_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Creator);
			}
			this.attribute_.WriteTo(ref output, ClubBan._repeated_attribute_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Reason);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0019B430 File Offset: 0x00199630
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag2 = this.creator_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Creator);
			}
			num += this.attribute_.CalculateSize(ClubBan._repeated_attribute_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0019B510 File Offset: 0x00199710
		[DebuggerNonUserCode]
		public void MergeFrom(ClubBan other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new MemberId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool flag4 = other.creator_ != null;
				if (flag4)
				{
					bool flag5 = this.creator_ == null;
					if (flag5)
					{
						this.Creator = new MemberDescription();
					}
					this.Creator.MergeFrom(other.Creator);
				}
				this.attribute_.Add(other.attribute_);
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x0019B620 File Offset: 0x00199820
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x0019B62C File Offset: 0x0019982C
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0043;
							}
							bool flag = this.creator_ == null;
							if (flag)
							{
								this.Creator = new MemberDescription();
							}
							input.ReadMessage(this.Creator);
						}
						else
						{
							this.BattleTag = input.ReadString();
						}
					}
					else
					{
						bool flag2 = this.id_ == null;
						if (flag2)
						{
							this.Id = new MemberId();
						}
						input.ReadMessage(this.Id);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0043;
						}
						this.CreationTime = input.ReadUInt64();
					}
					else
					{
						this.Reason = input.ReadString();
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ClubBan._repeated_attribute_codec);
				}
				continue;
				IL_0043:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003058 RID: 12376
		private static readonly MessageParser<ClubBan> _parser = new MessageParser<ClubBan>(() => new ClubBan());

		// Token: 0x04003059 RID: 12377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400305A RID: 12378
		private int _hasBits0;

		// Token: 0x0400305B RID: 12379
		public const int IdFieldNumber = 1;

		// Token: 0x0400305C RID: 12380
		private MemberId id_;

		// Token: 0x0400305D RID: 12381
		public const int BattleTagFieldNumber = 2;

		// Token: 0x0400305E RID: 12382
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x0400305F RID: 12383
		private string battleTag_;

		// Token: 0x04003060 RID: 12384
		public const int CreatorFieldNumber = 3;

		// Token: 0x04003061 RID: 12385
		private MemberDescription creator_;

		// Token: 0x04003062 RID: 12386
		public const int AttributeFieldNumber = 4;

		// Token: 0x04003063 RID: 12387
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003064 RID: 12388
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003065 RID: 12389
		public const int ReasonFieldNumber = 5;

		// Token: 0x04003066 RID: 12390
		private static readonly string ReasonDefaultValue = "";

		// Token: 0x04003067 RID: 12391
		private string reason_;

		// Token: 0x04003068 RID: 12392
		public const int CreationTimeFieldNumber = 6;

		// Token: 0x04003069 RID: 12393
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x0400306A RID: 12394
		private ulong creationTime_;
	}
}
