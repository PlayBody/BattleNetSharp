using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000134 RID: 308
	public sealed class KillerInfo : IMessage<KillerInfo>, IMessage, IEquatable<KillerInfo>, IDeepCloneable<KillerInfo>, IBufferMessage
	{
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x000769A4 File Offset: 0x00074BA4
		[DebuggerNonUserCode]
		public static MessageParser<KillerInfo> Parser
		{
			get
			{
				return KillerInfo._parser;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000769BC File Offset: 0x00074BBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x000769E0 File Offset: 0x00074BE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KillerInfo.Descriptor;
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000769F7 File Offset: 0x00074BF7
		[DebuggerNonUserCode]
		public KillerInfo()
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00076A0C File Offset: 0x00074C0C
		[DebuggerNonUserCode]
		public KillerInfo(KillerInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoKiller_ = other.snoKiller_;
			this.rarity_ = other.rarity_;
			this.rareNameGbids_ = other.rareNameGbids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00076A68 File Offset: 0x00074C68
		[DebuggerNonUserCode]
		public KillerInfo Clone()
		{
			return new KillerInfo(this);
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00076A80 File Offset: 0x00074C80
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x00076AB1 File Offset: 0x00074CB1
		[DebuggerNonUserCode]
		public int SnoKiller
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoKillerDefaultValue;
				if (flag)
				{
					snoKillerDefaultValue = this.snoKiller_;
				}
				else
				{
					snoKillerDefaultValue = KillerInfo.SnoKillerDefaultValue;
				}
				return snoKillerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoKiller_ = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00076ACC File Offset: 0x00074CCC
		[DebuggerNonUserCode]
		public bool HasSnoKiller
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00076AE9 File Offset: 0x00074CE9
		[DebuggerNonUserCode]
		public void ClearSnoKiller()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00076AFC File Offset: 0x00074CFC
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00076B2D File Offset: 0x00074D2D
		[DebuggerNonUserCode]
		public uint Rarity
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint rarityDefaultValue;
				if (flag)
				{
					rarityDefaultValue = this.rarity_;
				}
				else
				{
					rarityDefaultValue = KillerInfo.RarityDefaultValue;
				}
				return rarityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.rarity_ = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00076B48 File Offset: 0x00074D48
		[DebuggerNonUserCode]
		public bool HasRarity
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00076B65 File Offset: 0x00074D65
		[DebuggerNonUserCode]
		public void ClearRarity()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00076B78 File Offset: 0x00074D78
		[DebuggerNonUserCode]
		public RepeatedField<int> RareNameGbids
		{
			get
			{
				return this.rareNameGbids_;
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00076B90 File Offset: 0x00074D90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KillerInfo);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00076BB0 File Offset: 0x00074DB0
		[DebuggerNonUserCode]
		public bool Equals(KillerInfo other)
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
					bool flag4 = this.SnoKiller != other.SnoKiller;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Rarity != other.Rarity;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.rareNameGbids_.Equals(other.rareNameGbids_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00076C40 File Offset: 0x00074E40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoKiller = this.HasSnoKiller;
			if (hasSnoKiller)
			{
				num ^= this.SnoKiller.GetHashCode();
			}
			bool hasRarity = this.HasRarity;
			if (hasRarity)
			{
				num ^= this.Rarity.GetHashCode();
			}
			num ^= this.rareNameGbids_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00076CBC File Offset: 0x00074EBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00076CD4 File Offset: 0x00074ED4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00076CE0 File Offset: 0x00074EE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoKiller = this.HasSnoKiller;
			if (hasSnoKiller)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoKiller);
			}
			bool hasRarity = this.HasRarity;
			if (hasRarity)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Rarity);
			}
			this.rareNameGbids_.WriteTo(ref output, KillerInfo._repeated_rareNameGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00076D60 File Offset: 0x00074F60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoKiller = this.HasSnoKiller;
			if (hasSnoKiller)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoKiller);
			}
			bool hasRarity = this.HasRarity;
			if (hasRarity)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rarity);
			}
			num += this.rareNameGbids_.CalculateSize(KillerInfo._repeated_rareNameGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00076DE0 File Offset: 0x00074FE0
		[DebuggerNonUserCode]
		public void MergeFrom(KillerInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoKiller = other.HasSnoKiller;
				if (hasSnoKiller)
				{
					this.SnoKiller = other.SnoKiller;
				}
				bool hasRarity = other.HasRarity;
				if (hasRarity)
				{
					this.Rarity = other.Rarity;
				}
				this.rareNameGbids_.Add(other.rareNameGbids_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00076E54 File Offset: 0x00075054
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00076E60 File Offset: 0x00075060
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
							goto IL_0028;
						}
						this.Rarity = input.ReadUInt32();
					}
					else
					{
						this.SnoKiller = input.ReadInt32();
					}
				}
				else
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_0028;
					}
					this.rareNameGbids_.AddEntriesFrom(ref input, KillerInfo._repeated_rareNameGbids_codec);
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D4D RID: 3405
		private static readonly MessageParser<KillerInfo> _parser = new MessageParser<KillerInfo>(() => new KillerInfo());

		// Token: 0x04000D4E RID: 3406
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D4F RID: 3407
		private int _hasBits0;

		// Token: 0x04000D50 RID: 3408
		public const int SnoKillerFieldNumber = 1;

		// Token: 0x04000D51 RID: 3409
		private static readonly int SnoKillerDefaultValue = -1;

		// Token: 0x04000D52 RID: 3410
		private int snoKiller_;

		// Token: 0x04000D53 RID: 3411
		public const int RarityFieldNumber = 2;

		// Token: 0x04000D54 RID: 3412
		private static readonly uint RarityDefaultValue = 0U;

		// Token: 0x04000D55 RID: 3413
		private uint rarity_;

		// Token: 0x04000D56 RID: 3414
		public const int RareNameGbidsFieldNumber = 3;

		// Token: 0x04000D57 RID: 3415
		private static readonly FieldCodec<int> _repeated_rareNameGbids_codec = FieldCodec.ForInt32(24U);

		// Token: 0x04000D58 RID: 3416
		private readonly RepeatedField<int> rareNameGbids_ = new RepeatedField<int>();
	}
}
