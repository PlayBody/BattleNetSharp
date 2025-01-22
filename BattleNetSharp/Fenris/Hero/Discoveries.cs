using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018B RID: 395
	public sealed class Discoveries : IMessage<Discoveries>, IMessage, IEquatable<Discoveries>, IDeepCloneable<Discoveries>, IBufferMessage
	{
		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000A2244 File Offset: 0x000A0444
		[DebuggerNonUserCode]
		public static MessageParser<Discoveries> Parser
		{
			get
			{
				return Discoveries._parser;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000A225C File Offset: 0x000A045C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x000A2280 File Offset: 0x000A0480
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Discoveries.Descriptor;
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000A2297 File Offset: 0x000A0497
		[DebuggerNonUserCode]
		public Discoveries()
		{
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000A22C4 File Offset: 0x000A04C4
		[DebuggerNonUserCode]
		public Discoveries(Discoveries other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.unlockedTownPortal_ = other.unlockedTownPortal_;
			this.learnedLore_ = ((other.learnedLore_ != null) ? other.learnedLore_.Clone() : null);
			this.savedConversations_ = ((other.savedConversations_ != null) ? other.savedConversations_.Clone() : null);
			this.activatedWaypoint_ = other.activatedWaypoint_.Clone();
			this.snoUnlockedFow_ = other.snoUnlockedFow_.Clone();
			this.gbidDiscoveredCache_ = other.gbidDiscoveredCache_.Clone();
			this.campsDiscovered_ = ((other.campsDiscovered_ != null) ? other.campsDiscovered_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000A238C File Offset: 0x000A058C
		[DebuggerNonUserCode]
		public Discoveries Clone()
		{
			return new Discoveries(this);
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x000A23A4 File Offset: 0x000A05A4
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x000A23D5 File Offset: 0x000A05D5
		[DebuggerNonUserCode]
		public bool UnlockedTownPortal
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool unlockedTownPortalDefaultValue;
				if (flag)
				{
					unlockedTownPortalDefaultValue = this.unlockedTownPortal_;
				}
				else
				{
					unlockedTownPortalDefaultValue = Discoveries.UnlockedTownPortalDefaultValue;
				}
				return unlockedTownPortalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unlockedTownPortal_ = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000A23F0 File Offset: 0x000A05F0
		[DebuggerNonUserCode]
		public bool HasUnlockedTownPortal
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000A240D File Offset: 0x000A060D
		[DebuggerNonUserCode]
		public void ClearUnlockedTownPortal()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x000A2420 File Offset: 0x000A0620
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x000A2438 File Offset: 0x000A0638
		[DebuggerNonUserCode]
		public LearnedLore LearnedLore
		{
			get
			{
				return this.learnedLore_;
			}
			set
			{
				this.learnedLore_ = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000A2444 File Offset: 0x000A0644
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x000A245C File Offset: 0x000A065C
		[DebuggerNonUserCode]
		public SavedConversations SavedConversations
		{
			get
			{
				return this.savedConversations_;
			}
			set
			{
				this.savedConversations_ = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x000A2468 File Offset: 0x000A0668
		[DebuggerNonUserCode]
		public RepeatedField<int> ActivatedWaypoint
		{
			get
			{
				return this.activatedWaypoint_;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000A2480 File Offset: 0x000A0680
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoUnlockedFow
		{
			get
			{
				return this.snoUnlockedFow_;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x000A2498 File Offset: 0x000A0698
		[DebuggerNonUserCode]
		public RepeatedField<int> GbidDiscoveredCache
		{
			get
			{
				return this.gbidDiscoveredCache_;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000A24B0 File Offset: 0x000A06B0
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x000A24C8 File Offset: 0x000A06C8
		[DebuggerNonUserCode]
		public AssetListDataStore CampsDiscovered
		{
			get
			{
				return this.campsDiscovered_;
			}
			set
			{
				this.campsDiscovered_ = value;
			}
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000A24D4 File Offset: 0x000A06D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Discoveries);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000A24F4 File Offset: 0x000A06F4
		[DebuggerNonUserCode]
		public bool Equals(Discoveries other)
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
					bool flag4 = this.UnlockedTownPortal != other.UnlockedTownPortal;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.LearnedLore, other.LearnedLore);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SavedConversations, other.SavedConversations);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.activatedWaypoint_.Equals(other.activatedWaypoint_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.snoUnlockedFow_.Equals(other.snoUnlockedFow_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.gbidDiscoveredCache_.Equals(other.gbidDiscoveredCache_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.CampsDiscovered, other.CampsDiscovered);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000A2610 File Offset: 0x000A0810
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUnlockedTownPortal = this.HasUnlockedTownPortal;
			if (hasUnlockedTownPortal)
			{
				num ^= this.UnlockedTownPortal.GetHashCode();
			}
			bool flag = this.learnedLore_ != null;
			if (flag)
			{
				num ^= this.LearnedLore.GetHashCode();
			}
			bool flag2 = this.savedConversations_ != null;
			if (flag2)
			{
				num ^= this.SavedConversations.GetHashCode();
			}
			num ^= this.activatedWaypoint_.GetHashCode();
			num ^= this.snoUnlockedFow_.GetHashCode();
			num ^= this.gbidDiscoveredCache_.GetHashCode();
			bool flag3 = this.campsDiscovered_ != null;
			if (flag3)
			{
				num ^= this.CampsDiscovered.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000A26E0 File Offset: 0x000A08E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000A26F8 File Offset: 0x000A08F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000A2704 File Offset: 0x000A0904
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUnlockedTownPortal = this.HasUnlockedTownPortal;
			if (hasUnlockedTownPortal)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.UnlockedTownPortal);
			}
			bool flag = this.learnedLore_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LearnedLore);
			}
			bool flag2 = this.savedConversations_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SavedConversations);
			}
			this.activatedWaypoint_.WriteTo(ref output, Discoveries._repeated_activatedWaypoint_codec);
			this.snoUnlockedFow_.WriteTo(ref output, Discoveries._repeated_snoUnlockedFow_codec);
			this.gbidDiscoveredCache_.WriteTo(ref output, Discoveries._repeated_gbidDiscoveredCache_codec);
			bool flag3 = this.campsDiscovered_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CampsDiscovered);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000A27F8 File Offset: 0x000A09F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUnlockedTownPortal = this.HasUnlockedTownPortal;
			if (hasUnlockedTownPortal)
			{
				num += 2;
			}
			bool flag = this.learnedLore_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LearnedLore);
			}
			bool flag2 = this.savedConversations_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedConversations);
			}
			num += this.activatedWaypoint_.CalculateSize(Discoveries._repeated_activatedWaypoint_codec);
			num += this.snoUnlockedFow_.CalculateSize(Discoveries._repeated_snoUnlockedFow_codec);
			num += this.gbidDiscoveredCache_.CalculateSize(Discoveries._repeated_gbidDiscoveredCache_codec);
			bool flag3 = this.campsDiscovered_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CampsDiscovered);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000A28D8 File Offset: 0x000A0AD8
		[DebuggerNonUserCode]
		public void MergeFrom(Discoveries other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUnlockedTownPortal = other.HasUnlockedTownPortal;
				if (hasUnlockedTownPortal)
				{
					this.UnlockedTownPortal = other.UnlockedTownPortal;
				}
				bool flag2 = other.learnedLore_ != null;
				if (flag2)
				{
					bool flag3 = this.learnedLore_ == null;
					if (flag3)
					{
						this.LearnedLore = new LearnedLore();
					}
					this.LearnedLore.MergeFrom(other.LearnedLore);
				}
				bool flag4 = other.savedConversations_ != null;
				if (flag4)
				{
					bool flag5 = this.savedConversations_ == null;
					if (flag5)
					{
						this.SavedConversations = new SavedConversations();
					}
					this.SavedConversations.MergeFrom(other.SavedConversations);
				}
				this.activatedWaypoint_.Add(other.activatedWaypoint_);
				this.snoUnlockedFow_.Add(other.snoUnlockedFow_);
				this.gbidDiscoveredCache_.Add(other.gbidDiscoveredCache_);
				bool flag6 = other.campsDiscovered_ != null;
				if (flag6)
				{
					bool flag7 = this.campsDiscovered_ == null;
					if (flag7)
					{
						this.CampsDiscovered = new AssetListDataStore();
					}
					this.CampsDiscovered.MergeFrom(other.CampsDiscovered);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000A2A16 File Offset: 0x000A0C16
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000A2A24 File Offset: 0x000A0C24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 45U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_007A;
							}
							bool flag = this.learnedLore_ == null;
							if (flag)
							{
								this.LearnedLore = new LearnedLore();
							}
							input.ReadMessage(this.LearnedLore);
						}
						else
						{
							this.UnlockedTownPortal = input.ReadBool();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 42U && num3 != 45U)
						{
							goto IL_007A;
						}
						this.activatedWaypoint_.AddEntriesFrom(ref input, Discoveries._repeated_activatedWaypoint_codec);
					}
					else
					{
						bool flag2 = this.savedConversations_ == null;
						if (flag2)
						{
							this.SavedConversations = new SavedConversations();
						}
						input.ReadMessage(this.SavedConversations);
					}
				}
				else if (num3 <= 53U)
				{
					if (num3 != 50U && num3 != 53U)
					{
						goto IL_007A;
					}
					this.snoUnlockedFow_.AddEntriesFrom(ref input, Discoveries._repeated_snoUnlockedFow_codec);
				}
				else if (num3 != 58U && num3 != 61U)
				{
					if (num3 != 66U)
					{
						goto IL_007A;
					}
					bool flag3 = this.campsDiscovered_ == null;
					if (flag3)
					{
						this.CampsDiscovered = new AssetListDataStore();
					}
					input.ReadMessage(this.CampsDiscovered);
				}
				else
				{
					this.gbidDiscoveredCache_.AddEntriesFrom(ref input, Discoveries._repeated_gbidDiscoveredCache_codec);
				}
				continue;
				IL_007A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400128B RID: 4747
		private static readonly MessageParser<Discoveries> _parser = new MessageParser<Discoveries>(() => new Discoveries());

		// Token: 0x0400128C RID: 4748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400128D RID: 4749
		private int _hasBits0;

		// Token: 0x0400128E RID: 4750
		public const int UnlockedTownPortalFieldNumber = 1;

		// Token: 0x0400128F RID: 4751
		private static readonly bool UnlockedTownPortalDefaultValue = false;

		// Token: 0x04001290 RID: 4752
		private bool unlockedTownPortal_;

		// Token: 0x04001291 RID: 4753
		public const int LearnedLoreFieldNumber = 2;

		// Token: 0x04001292 RID: 4754
		private LearnedLore learnedLore_;

		// Token: 0x04001293 RID: 4755
		public const int SavedConversationsFieldNumber = 3;

		// Token: 0x04001294 RID: 4756
		private SavedConversations savedConversations_;

		// Token: 0x04001295 RID: 4757
		public const int ActivatedWaypointFieldNumber = 5;

		// Token: 0x04001296 RID: 4758
		private static readonly FieldCodec<int> _repeated_activatedWaypoint_codec = FieldCodec.ForSFixed32(45U);

		// Token: 0x04001297 RID: 4759
		private readonly RepeatedField<int> activatedWaypoint_ = new RepeatedField<int>();

		// Token: 0x04001298 RID: 4760
		public const int SnoUnlockedFowFieldNumber = 6;

		// Token: 0x04001299 RID: 4761
		private static readonly FieldCodec<int> _repeated_snoUnlockedFow_codec = FieldCodec.ForSFixed32(53U);

		// Token: 0x0400129A RID: 4762
		private readonly RepeatedField<int> snoUnlockedFow_ = new RepeatedField<int>();

		// Token: 0x0400129B RID: 4763
		public const int GbidDiscoveredCacheFieldNumber = 7;

		// Token: 0x0400129C RID: 4764
		private static readonly FieldCodec<int> _repeated_gbidDiscoveredCache_codec = FieldCodec.ForSFixed32(61U);

		// Token: 0x0400129D RID: 4765
		private readonly RepeatedField<int> gbidDiscoveredCache_ = new RepeatedField<int>();

		// Token: 0x0400129E RID: 4766
		public const int CampsDiscoveredFieldNumber = 8;

		// Token: 0x0400129F RID: 4767
		private AssetListDataStore campsDiscovered_;
	}
}
