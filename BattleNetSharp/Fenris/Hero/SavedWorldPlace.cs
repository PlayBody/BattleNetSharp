using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017E RID: 382
	public sealed class SavedWorldPlace : IMessage<SavedWorldPlace>, IMessage, IEquatable<SavedWorldPlace>, IDeepCloneable<SavedWorldPlace>, IBufferMessage
	{
		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0009CB8C File Offset: 0x0009AD8C
		[DebuggerNonUserCode]
		public static MessageParser<SavedWorldPlace> Parser
		{
			get
			{
				return SavedWorldPlace._parser;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0009CBA4 File Offset: 0x0009ADA4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedWorldPlace.Descriptor;
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0009CBDF File Offset: 0x0009ADDF
		[DebuggerNonUserCode]
		public SavedWorldPlace()
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0009CBEC File Offset: 0x0009ADEC
		[DebuggerNonUserCode]
		public SavedWorldPlace(SavedWorldPlace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.entranceGuid_ = other.entranceGuid_;
			this.drlgSeed_ = other.drlgSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0009CC60 File Offset: 0x0009AE60
		[DebuggerNonUserCode]
		public SavedWorldPlace Clone()
		{
			return new SavedWorldPlace(this);
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x0009CC78 File Offset: 0x0009AE78
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x0009CCA9 File Offset: 0x0009AEA9
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
					snoWorldDefaultValue = SavedWorldPlace.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x0009CCC4 File Offset: 0x0009AEC4
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0009CCE1 File Offset: 0x0009AEE1
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x0009CCF4 File Offset: 0x0009AEF4
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x0009CD0C File Offset: 0x0009AF0C
		[DebuggerNonUserCode]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x0009CD18 File Offset: 0x0009AF18
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x0009CD49 File Offset: 0x0009AF49
		[DebuggerNonUserCode]
		public uint EntranceGuid
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint entranceGuidDefaultValue;
				if (flag)
				{
					entranceGuidDefaultValue = this.entranceGuid_;
				}
				else
				{
					entranceGuidDefaultValue = SavedWorldPlace.EntranceGuidDefaultValue;
				}
				return entranceGuidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.entranceGuid_ = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x0009CD64 File Offset: 0x0009AF64
		[DebuggerNonUserCode]
		public bool HasEntranceGuid
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0009CD81 File Offset: 0x0009AF81
		[DebuggerNonUserCode]
		public void ClearEntranceGuid()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x0009CD94 File Offset: 0x0009AF94
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x0009CDC5 File Offset: 0x0009AFC5
		[DebuggerNonUserCode]
		public int DrlgSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int drlgSeedDefaultValue;
				if (flag)
				{
					drlgSeedDefaultValue = this.drlgSeed_;
				}
				else
				{
					drlgSeedDefaultValue = SavedWorldPlace.DrlgSeedDefaultValue;
				}
				return drlgSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.drlgSeed_ = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
		[DebuggerNonUserCode]
		public bool HasDrlgSeed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0009CDFD File Offset: 0x0009AFFD
		[DebuggerNonUserCode]
		public void ClearDrlgSeed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0009CE10 File Offset: 0x0009B010
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedWorldPlace);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0009CE30 File Offset: 0x0009B030
		[DebuggerNonUserCode]
		public bool Equals(SavedWorldPlace other)
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
						bool flag5 = !object.Equals(this.Pos, other.Pos);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EntranceGuid != other.EntranceGuid;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DrlgSeed != other.DrlgSeed;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0009CEE0 File Offset: 0x0009B0E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num ^= this.Pos.GetHashCode();
			}
			bool hasEntranceGuid = this.HasEntranceGuid;
			if (hasEntranceGuid)
			{
				num ^= this.EntranceGuid.GetHashCode();
			}
			bool hasDrlgSeed = this.HasDrlgSeed;
			if (hasDrlgSeed)
			{
				num ^= this.DrlgSeed.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0009CF88 File Offset: 0x0009B188
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0009CFA0 File Offset: 0x0009B1A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0009CFAC File Offset: 0x0009B1AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			bool hasEntranceGuid = this.HasEntranceGuid;
			if (hasEntranceGuid)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EntranceGuid);
			}
			bool hasDrlgSeed = this.HasDrlgSeed;
			if (hasDrlgSeed)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.DrlgSeed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0009D064 File Offset: 0x0009B264
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			bool hasEntranceGuid = this.HasEntranceGuid;
			if (hasEntranceGuid)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntranceGuid);
			}
			bool hasDrlgSeed = this.HasDrlgSeed;
			if (hasDrlgSeed)
			{
				num += 5;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0009D0F8 File Offset: 0x0009B2F8
		[DebuggerNonUserCode]
		public void MergeFrom(SavedWorldPlace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool flag2 = other.pos_ != null;
				if (flag2)
				{
					bool flag3 = this.pos_ == null;
					if (flag3)
					{
						this.Pos = new Vector();
					}
					this.Pos.MergeFrom(other.Pos);
				}
				bool hasEntranceGuid = other.HasEntranceGuid;
				if (hasEntranceGuid)
				{
					this.EntranceGuid = other.EntranceGuid;
				}
				bool hasDrlgSeed = other.HasDrlgSeed;
				if (hasDrlgSeed)
				{
					this.DrlgSeed = other.DrlgSeed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0009D1B6 File Offset: 0x0009B3B6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 13U)
					{
						if (num3 != 18U)
						{
							goto IL_002C;
						}
						bool flag = this.pos_ == null;
						if (flag)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
					}
					else
					{
						this.SnoWorld = input.ReadSFixed32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 37U)
					{
						goto IL_002C;
					}
					this.DrlgSeed = input.ReadSFixed32();
				}
				else
				{
					this.EntranceGuid = input.ReadUInt32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040011D5 RID: 4565
		private static readonly MessageParser<SavedWorldPlace> _parser = new MessageParser<SavedWorldPlace>(() => new SavedWorldPlace());

		// Token: 0x040011D6 RID: 4566
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011D7 RID: 4567
		private int _hasBits0;

		// Token: 0x040011D8 RID: 4568
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x040011D9 RID: 4569
		private static readonly int SnoWorldDefaultValue = -1;

		// Token: 0x040011DA RID: 4570
		private int snoWorld_;

		// Token: 0x040011DB RID: 4571
		public const int PosFieldNumber = 2;

		// Token: 0x040011DC RID: 4572
		private Vector pos_;

		// Token: 0x040011DD RID: 4573
		public const int EntranceGuidFieldNumber = 3;

		// Token: 0x040011DE RID: 4574
		private static readonly uint EntranceGuidDefaultValue = 0U;

		// Token: 0x040011DF RID: 4575
		private uint entranceGuid_;

		// Token: 0x040011E0 RID: 4576
		public const int DrlgSeedFieldNumber = 4;

		// Token: 0x040011E1 RID: 4577
		private static readonly int DrlgSeedDefaultValue = 0;

		// Token: 0x040011E2 RID: 4578
		private int drlgSeed_;
	}
}
