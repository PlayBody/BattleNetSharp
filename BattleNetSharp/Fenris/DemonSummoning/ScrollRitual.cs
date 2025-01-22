using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.DemonSummoning
{
	// Token: 0x020001FC RID: 508
	public sealed class ScrollRitual : IMessage<ScrollRitual>, IMessage, IEquatable<ScrollRitual>, IDeepCloneable<ScrollRitual>, IBufferMessage
	{
		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000DC4B0 File Offset: 0x000DA6B0
		[DebuggerNonUserCode]
		public static MessageParser<ScrollRitual> Parser
		{
			get
			{
				return ScrollRitual._parser;
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x000DC4C8 File Offset: 0x000DA6C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DemonSummoningReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000DC4EC File Offset: 0x000DA6EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScrollRitual.Descriptor;
			}
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x000DC503 File Offset: 0x000DA703
		[DebuggerNonUserCode]
		public ScrollRitual()
		{
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x000DC524 File Offset: 0x000DA724
		[DebuggerNonUserCode]
		public ScrollRitual(ScrollRitual other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoStartQuest_ = other.snoStartQuest_;
			this.snoActivityQuests_ = other.snoActivityQuests_.Clone();
			this.snoCompletionQuests_ = other.snoCompletionQuests_.Clone();
			this.snoRitualItem_ = other.snoRitualItem_;
			this.gbidRitualInfo_ = other.gbidRitualInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x000DC59C File Offset: 0x000DA79C
		[DebuggerNonUserCode]
		public ScrollRitual Clone()
		{
			return new ScrollRitual(this);
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000DC5B4 File Offset: 0x000DA7B4
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x000DC5E5 File Offset: 0x000DA7E5
		[DebuggerNonUserCode]
		public int SnoStartQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoStartQuestDefaultValue;
				if (flag)
				{
					snoStartQuestDefaultValue = this.snoStartQuest_;
				}
				else
				{
					snoStartQuestDefaultValue = ScrollRitual.SnoStartQuestDefaultValue;
				}
				return snoStartQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoStartQuest_ = value;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000DC600 File Offset: 0x000DA800
		[DebuggerNonUserCode]
		public bool HasSnoStartQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x000DC61D File Offset: 0x000DA81D
		[DebuggerNonUserCode]
		public void ClearSnoStartQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x000DC630 File Offset: 0x000DA830
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoActivityQuests
		{
			get
			{
				return this.snoActivityQuests_;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x000DC648 File Offset: 0x000DA848
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoCompletionQuests
		{
			get
			{
				return this.snoCompletionQuests_;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x000DC660 File Offset: 0x000DA860
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x000DC691 File Offset: 0x000DA891
		[DebuggerNonUserCode]
		public int SnoRitualItem
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoRitualItemDefaultValue;
				if (flag)
				{
					snoRitualItemDefaultValue = this.snoRitualItem_;
				}
				else
				{
					snoRitualItemDefaultValue = ScrollRitual.SnoRitualItemDefaultValue;
				}
				return snoRitualItemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoRitualItem_ = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x000DC6AC File Offset: 0x000DA8AC
		[DebuggerNonUserCode]
		public bool HasSnoRitualItem
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x000DC6C9 File Offset: 0x000DA8C9
		[DebuggerNonUserCode]
		public void ClearSnoRitualItem()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x000DC6DC File Offset: 0x000DA8DC
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x000DC70D File Offset: 0x000DA90D
		[DebuggerNonUserCode]
		public int GbidRitualInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int gbidRitualInfoDefaultValue;
				if (flag)
				{
					gbidRitualInfoDefaultValue = this.gbidRitualInfo_;
				}
				else
				{
					gbidRitualInfoDefaultValue = ScrollRitual.GbidRitualInfoDefaultValue;
				}
				return gbidRitualInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gbidRitualInfo_ = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x000DC728 File Offset: 0x000DA928
		[DebuggerNonUserCode]
		public bool HasGbidRitualInfo
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x000DC745 File Offset: 0x000DA945
		[DebuggerNonUserCode]
		public void ClearGbidRitualInfo()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x000DC758 File Offset: 0x000DA958
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScrollRitual);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x000DC778 File Offset: 0x000DA978
		[DebuggerNonUserCode]
		public bool Equals(ScrollRitual other)
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
					bool flag4 = this.SnoStartQuest != other.SnoStartQuest;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.snoActivityQuests_.Equals(other.snoActivityQuests_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.snoCompletionQuests_.Equals(other.snoCompletionQuests_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoRitualItem != other.SnoRitualItem;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GbidRitualInfo != other.GbidRitualInfo;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x000DC84C File Offset: 0x000DAA4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoStartQuest = this.HasSnoStartQuest;
			if (hasSnoStartQuest)
			{
				num ^= this.SnoStartQuest.GetHashCode();
			}
			num ^= this.snoActivityQuests_.GetHashCode();
			num ^= this.snoCompletionQuests_.GetHashCode();
			bool hasSnoRitualItem = this.HasSnoRitualItem;
			if (hasSnoRitualItem)
			{
				num ^= this.SnoRitualItem.GetHashCode();
			}
			bool hasGbidRitualInfo = this.HasGbidRitualInfo;
			if (hasGbidRitualInfo)
			{
				num ^= this.GbidRitualInfo.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x000DC8F4 File Offset: 0x000DAAF4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x000DC90C File Offset: 0x000DAB0C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x000DC918 File Offset: 0x000DAB18
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoStartQuest = this.HasSnoStartQuest;
			if (hasSnoStartQuest)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoStartQuest);
			}
			this.snoActivityQuests_.WriteTo(ref output, ScrollRitual._repeated_snoActivityQuests_codec);
			this.snoCompletionQuests_.WriteTo(ref output, ScrollRitual._repeated_snoCompletionQuests_codec);
			bool hasSnoRitualItem = this.HasSnoRitualItem;
			if (hasSnoRitualItem)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SnoRitualItem);
			}
			bool hasGbidRitualInfo = this.HasGbidRitualInfo;
			if (hasGbidRitualInfo)
			{
				output.WriteRawTag(45);
				output.WriteSFixed32(this.GbidRitualInfo);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x000DC9CC File Offset: 0x000DABCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoStartQuest = this.HasSnoStartQuest;
			if (hasSnoStartQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoStartQuest);
			}
			num += this.snoActivityQuests_.CalculateSize(ScrollRitual._repeated_snoActivityQuests_codec);
			num += this.snoCompletionQuests_.CalculateSize(ScrollRitual._repeated_snoCompletionQuests_codec);
			bool hasSnoRitualItem = this.HasSnoRitualItem;
			if (hasSnoRitualItem)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoRitualItem);
			}
			bool hasGbidRitualInfo = this.HasGbidRitualInfo;
			if (hasGbidRitualInfo)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x000DCA70 File Offset: 0x000DAC70
		[DebuggerNonUserCode]
		public void MergeFrom(ScrollRitual other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoStartQuest = other.HasSnoStartQuest;
				if (hasSnoStartQuest)
				{
					this.SnoStartQuest = other.SnoStartQuest;
				}
				this.snoActivityQuests_.Add(other.snoActivityQuests_);
				this.snoCompletionQuests_.Add(other.snoCompletionQuests_);
				bool hasSnoRitualItem = other.HasSnoRitualItem;
				if (hasSnoRitualItem)
				{
					this.SnoRitualItem = other.SnoRitualItem;
				}
				bool hasGbidRitualInfo = other.HasGbidRitualInfo;
				if (hasGbidRitualInfo)
				{
					this.GbidRitualInfo = other.GbidRitualInfo;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x000DCB12 File Offset: 0x000DAD12
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x000DCB20 File Offset: 0x000DAD20
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
					if (num3 != 8U)
					{
						if (num3 != 16U && num3 != 18U)
						{
							goto IL_0045;
						}
						this.snoActivityQuests_.AddEntriesFrom(ref input, ScrollRitual._repeated_snoActivityQuests_codec);
					}
					else
					{
						this.SnoStartQuest = input.ReadInt32();
					}
				}
				else if (num3 <= 26U)
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_0045;
					}
					this.snoCompletionQuests_.AddEntriesFrom(ref input, ScrollRitual._repeated_snoCompletionQuests_codec);
				}
				else if (num3 != 32U)
				{
					if (num3 != 45U)
					{
						goto IL_0045;
					}
					this.GbidRitualInfo = input.ReadSFixed32();
				}
				else
				{
					this.SnoRitualItem = input.ReadInt32();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019F7 RID: 6647
		private static readonly MessageParser<ScrollRitual> _parser = new MessageParser<ScrollRitual>(() => new ScrollRitual());

		// Token: 0x040019F8 RID: 6648
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019F9 RID: 6649
		private int _hasBits0;

		// Token: 0x040019FA RID: 6650
		public const int SnoStartQuestFieldNumber = 1;

		// Token: 0x040019FB RID: 6651
		private static readonly int SnoStartQuestDefaultValue = 0;

		// Token: 0x040019FC RID: 6652
		private int snoStartQuest_;

		// Token: 0x040019FD RID: 6653
		public const int SnoActivityQuestsFieldNumber = 2;

		// Token: 0x040019FE RID: 6654
		private static readonly FieldCodec<int> _repeated_snoActivityQuests_codec = FieldCodec.ForInt32(16U);

		// Token: 0x040019FF RID: 6655
		private readonly RepeatedField<int> snoActivityQuests_ = new RepeatedField<int>();

		// Token: 0x04001A00 RID: 6656
		public const int SnoCompletionQuestsFieldNumber = 3;

		// Token: 0x04001A01 RID: 6657
		private static readonly FieldCodec<int> _repeated_snoCompletionQuests_codec = FieldCodec.ForInt32(24U);

		// Token: 0x04001A02 RID: 6658
		private readonly RepeatedField<int> snoCompletionQuests_ = new RepeatedField<int>();

		// Token: 0x04001A03 RID: 6659
		public const int SnoRitualItemFieldNumber = 4;

		// Token: 0x04001A04 RID: 6660
		private static readonly int SnoRitualItemDefaultValue = 0;

		// Token: 0x04001A05 RID: 6661
		private int snoRitualItem_;

		// Token: 0x04001A06 RID: 6662
		public const int GbidRitualInfoFieldNumber = 5;

		// Token: 0x04001A07 RID: 6663
		private static readonly int GbidRitualInfoDefaultValue = 0;

		// Token: 0x04001A08 RID: 6664
		private int gbidRitualInfo_;
	}
}
