using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200015F RID: 351
	public sealed class DungeonKeyParams : IMessage<DungeonKeyParams>, IMessage, IEquatable<DungeonKeyParams>, IDeepCloneable<DungeonKeyParams>, IBufferMessage
	{
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0008C6A0 File Offset: 0x0008A8A0
		[DebuggerNonUserCode]
		public static MessageParser<DungeonKeyParams> Parser
		{
			get
			{
				return DungeonKeyParams._parser;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0008C6B8 File Offset: 0x0008A8B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0008C6DC File Offset: 0x0008A8DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DungeonKeyParams.Descriptor;
			}
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0008C6F3 File Offset: 0x0008A8F3
		[DebuggerNonUserCode]
		public DungeonKeyParams()
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0008C708 File Offset: 0x0008A908
		[DebuggerNonUserCode]
		public DungeonKeyParams(DungeonKeyParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.keyedDungeonTier_ = other.keyedDungeonTier_;
			this.snoDungeonAffixes_ = other.snoDungeonAffixes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0008C764 File Offset: 0x0008A964
		[DebuggerNonUserCode]
		public DungeonKeyParams Clone()
		{
			return new DungeonKeyParams(this);
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0008C77C File Offset: 0x0008A97C
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x0008C7AD File Offset: 0x0008A9AD
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = DungeonKeyParams.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0008C7C8 File Offset: 0x0008A9C8
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0008C7E5 File Offset: 0x0008A9E5
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0008C7F8 File Offset: 0x0008A9F8
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x0008C829 File Offset: 0x0008AA29
		[DebuggerNonUserCode]
		public int KeyedDungeonTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int keyedDungeonTierDefaultValue;
				if (flag)
				{
					keyedDungeonTierDefaultValue = this.keyedDungeonTier_;
				}
				else
				{
					keyedDungeonTierDefaultValue = DungeonKeyParams.KeyedDungeonTierDefaultValue;
				}
				return keyedDungeonTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.keyedDungeonTier_ = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0008C844 File Offset: 0x0008AA44
		[DebuggerNonUserCode]
		public bool HasKeyedDungeonTier
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0008C861 File Offset: 0x0008AA61
		[DebuggerNonUserCode]
		public void ClearKeyedDungeonTier()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x0008C874 File Offset: 0x0008AA74
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoDungeonAffixes
		{
			get
			{
				return this.snoDungeonAffixes_;
			}
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0008C88C File Offset: 0x0008AA8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DungeonKeyParams);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0008C8AC File Offset: 0x0008AAAC
		[DebuggerNonUserCode]
		public bool Equals(DungeonKeyParams other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.KeyedDungeonTier != other.KeyedDungeonTier;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.snoDungeonAffixes_.Equals(other.snoDungeonAffixes_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0008C93C File Offset: 0x0008AB3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				num ^= this.KeyedDungeonTier.GetHashCode();
			}
			num ^= this.snoDungeonAffixes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0008C9DC File Offset: 0x0008ABDC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.KeyedDungeonTier);
			}
			this.snoDungeonAffixes_.WriteTo(ref output, DungeonKeyParams._repeated_snoDungeonAffixes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0008CA5C File Offset: 0x0008AC5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.KeyedDungeonTier);
			}
			num += this.snoDungeonAffixes_.CalculateSize(DungeonKeyParams._repeated_snoDungeonAffixes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0008CAD0 File Offset: 0x0008ACD0
		[DebuggerNonUserCode]
		public void MergeFrom(DungeonKeyParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasKeyedDungeonTier = other.HasKeyedDungeonTier;
				if (hasKeyedDungeonTier)
				{
					this.KeyedDungeonTier = other.KeyedDungeonTier;
				}
				this.snoDungeonAffixes_.Add(other.snoDungeonAffixes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0008CB44 File Offset: 0x0008AD44
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0008CB50 File Offset: 0x0008AD50
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
						if (num3 != 24U)
						{
							goto IL_0029;
						}
						this.KeyedDungeonTier = input.ReadSInt32();
					}
					else
					{
						this.SnoWorld = input.ReadSFixed32();
					}
				}
				else
				{
					if (num3 != 34U && num3 != 37U)
					{
						goto IL_0029;
					}
					this.snoDungeonAffixes_.AddEntriesFrom(ref input, DungeonKeyParams._repeated_snoDungeonAffixes_codec);
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FDB RID: 4059
		private static readonly MessageParser<DungeonKeyParams> _parser = new MessageParser<DungeonKeyParams>(() => new DungeonKeyParams());

		// Token: 0x04000FDC RID: 4060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FDD RID: 4061
		private int _hasBits0;

		// Token: 0x04000FDE RID: 4062
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04000FDF RID: 4063
		private static readonly int SnoWorldDefaultValue = -1;

		// Token: 0x04000FE0 RID: 4064
		private int snoWorld_;

		// Token: 0x04000FE1 RID: 4065
		public const int KeyedDungeonTierFieldNumber = 3;

		// Token: 0x04000FE2 RID: 4066
		private static readonly int KeyedDungeonTierDefaultValue = -1;

		// Token: 0x04000FE3 RID: 4067
		private int keyedDungeonTier_;

		// Token: 0x04000FE4 RID: 4068
		public const int SnoDungeonAffixesFieldNumber = 4;

		// Token: 0x04000FE5 RID: 4069
		private static readonly FieldCodec<int> _repeated_snoDungeonAffixes_codec = FieldCodec.ForSFixed32(37U);

		// Token: 0x04000FE6 RID: 4070
		private readonly RepeatedField<int> snoDungeonAffixes_ = new RepeatedField<int>();
	}
}
