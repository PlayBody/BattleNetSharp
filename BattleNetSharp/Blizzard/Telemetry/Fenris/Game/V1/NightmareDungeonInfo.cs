using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F4 RID: 756
	public sealed class NightmareDungeonInfo : IMessage<NightmareDungeonInfo>, IMessage, IEquatable<NightmareDungeonInfo>, IDeepCloneable<NightmareDungeonInfo>, IBufferMessage
	{
		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x001325B8 File Offset: 0x001307B8
		[DebuggerNonUserCode]
		public static MessageParser<NightmareDungeonInfo> Parser
		{
			get
			{
				return NightmareDungeonInfo._parser;
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x001325D0 File Offset: 0x001307D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NightmareDungeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x001325F4 File Offset: 0x001307F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NightmareDungeonInfo.Descriptor;
			}
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x0013260B File Offset: 0x0013080B
		[DebuggerNonUserCode]
		public NightmareDungeonInfo()
		{
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00132620 File Offset: 0x00130820
		[DebuggerNonUserCode]
		public NightmareDungeonInfo(NightmareDungeonInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sigilTier_ = other.sigilTier_;
			this.afflictions_ = other.afflictions_.Clone();
			this.worldSno_ = other.worldSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x0013267C File Offset: 0x0013087C
		[DebuggerNonUserCode]
		public NightmareDungeonInfo Clone()
		{
			return new NightmareDungeonInfo(this);
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x00132694 File Offset: 0x00130894
		// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x001326C5 File Offset: 0x001308C5
		[DebuggerNonUserCode]
		public int SigilTier
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int sigilTierDefaultValue;
				if (flag)
				{
					sigilTierDefaultValue = this.sigilTier_;
				}
				else
				{
					sigilTierDefaultValue = NightmareDungeonInfo.SigilTierDefaultValue;
				}
				return sigilTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sigilTier_ = value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x001326E0 File Offset: 0x001308E0
		[DebuggerNonUserCode]
		public bool HasSigilTier
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x001326FD File Offset: 0x001308FD
		[DebuggerNonUserCode]
		public void ClearSigilTier()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x00132710 File Offset: 0x00130910
		[DebuggerNonUserCode]
		public RepeatedField<int> Afflictions
		{
			get
			{
				return this.afflictions_;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x00132728 File Offset: 0x00130928
		// (set) Token: 0x06004FC7 RID: 20423 RVA: 0x00132759 File Offset: 0x00130959
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = NightmareDungeonInfo.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x00132774 File Offset: 0x00130974
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00132791 File Offset: 0x00130991
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x001327A4 File Offset: 0x001309A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NightmareDungeonInfo);
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x001327C4 File Offset: 0x001309C4
		[DebuggerNonUserCode]
		public bool Equals(NightmareDungeonInfo other)
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
					bool flag4 = this.SigilTier != other.SigilTier;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.afflictions_.Equals(other.afflictions_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.WorldSno != other.WorldSno;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00132854 File Offset: 0x00130A54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSigilTier = this.HasSigilTier;
			if (hasSigilTier)
			{
				num ^= this.SigilTier.GetHashCode();
			}
			num ^= this.afflictions_.GetHashCode();
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x001328D0 File Offset: 0x00130AD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x001328E8 File Offset: 0x00130AE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x001328F4 File Offset: 0x00130AF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSigilTier = this.HasSigilTier;
			if (hasSigilTier)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SigilTier);
			}
			this.afflictions_.WriteTo(ref output, NightmareDungeonInfo._repeated_afflictions_codec);
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.WorldSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00132974 File Offset: 0x00130B74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSigilTier = this.HasSigilTier;
			if (hasSigilTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SigilTier);
			}
			num += this.afflictions_.CalculateSize(NightmareDungeonInfo._repeated_afflictions_codec);
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x001329F4 File Offset: 0x00130BF4
		[DebuggerNonUserCode]
		public void MergeFrom(NightmareDungeonInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSigilTier = other.HasSigilTier;
				if (hasSigilTier)
				{
					this.SigilTier = other.SigilTier;
				}
				this.afflictions_.Add(other.afflictions_);
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00132A68 File Offset: 0x00130C68
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00132A74 File Offset: 0x00130C74
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
						goto IL_004C;
					}
					else
					{
						this.SigilTier = input.ReadInt32();
					}
				}
				else
				{
					if (num3 == 18U)
					{
						goto IL_004C;
					}
					if (num3 != 24U)
					{
						goto IL_0028;
					}
					this.WorldSno = input.ReadSInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_004C:
				this.afflictions_.AddEntriesFrom(ref input, NightmareDungeonInfo._repeated_afflictions_codec);
			}
		}

		// Token: 0x040023D5 RID: 9173
		private static readonly MessageParser<NightmareDungeonInfo> _parser = new MessageParser<NightmareDungeonInfo>(() => new NightmareDungeonInfo());

		// Token: 0x040023D6 RID: 9174
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D7 RID: 9175
		private int _hasBits0;

		// Token: 0x040023D8 RID: 9176
		public const int SigilTierFieldNumber = 1;

		// Token: 0x040023D9 RID: 9177
		private static readonly int SigilTierDefaultValue = 0;

		// Token: 0x040023DA RID: 9178
		private int sigilTier_;

		// Token: 0x040023DB RID: 9179
		public const int AfflictionsFieldNumber = 2;

		// Token: 0x040023DC RID: 9180
		private static readonly FieldCodec<int> _repeated_afflictions_codec = FieldCodec.ForSInt32(16U);

		// Token: 0x040023DD RID: 9181
		private readonly RepeatedField<int> afflictions_ = new RepeatedField<int>();

		// Token: 0x040023DE RID: 9182
		public const int WorldSnoFieldNumber = 3;

		// Token: 0x040023DF RID: 9183
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x040023E0 RID: 9184
		private int worldSno_;
	}
}
