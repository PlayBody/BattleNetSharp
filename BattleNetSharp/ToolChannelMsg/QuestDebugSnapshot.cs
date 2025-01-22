using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C0 RID: 192
	public sealed class QuestDebugSnapshot : IMessage<QuestDebugSnapshot>, IMessage, IEquatable<QuestDebugSnapshot>, IDeepCloneable<QuestDebugSnapshot>, IBufferMessage
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0004262C File Offset: 0x0004082C
		[DebuggerNonUserCode]
		public static MessageParser<QuestDebugSnapshot> Parser
		{
			get
			{
				return QuestDebugSnapshot._parser;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00042644 File Offset: 0x00040844
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[169];
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0004266C File Offset: 0x0004086C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestDebugSnapshot.Descriptor;
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00042683 File Offset: 0x00040883
		[DebuggerNonUserCode]
		public QuestDebugSnapshot()
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00042698 File Offset: 0x00040898
		[DebuggerNonUserCode]
		public QuestDebugSnapshot(QuestDebugSnapshot other)
			: this()
		{
			this.updatedQuests_ = other.updatedQuests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000426C4 File Offset: 0x000408C4
		[DebuggerNonUserCode]
		public QuestDebugSnapshot Clone()
		{
			return new QuestDebugSnapshot(this);
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000426DC File Offset: 0x000408DC
		[DebuggerNonUserCode]
		public RepeatedField<QuestDebugSnapshot.Types.QuestDebugInfo> UpdatedQuests
		{
			get
			{
				return this.updatedQuests_;
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000426F4 File Offset: 0x000408F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestDebugSnapshot);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00042714 File Offset: 0x00040914
		[DebuggerNonUserCode]
		public bool Equals(QuestDebugSnapshot other)
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
					bool flag4 = !this.updatedQuests_.Equals(other.updatedQuests_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00042770 File Offset: 0x00040970
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updatedQuests_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000427B0 File Offset: 0x000409B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000427C8 File Offset: 0x000409C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000427D4 File Offset: 0x000409D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updatedQuests_.WriteTo(ref output, QuestDebugSnapshot._repeated_updatedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00042810 File Offset: 0x00040A10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updatedQuests_.CalculateSize(QuestDebugSnapshot._repeated_updatedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00042858 File Offset: 0x00040A58
		[DebuggerNonUserCode]
		public void MergeFrom(QuestDebugSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.updatedQuests_.Add(other.updatedQuests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0004289A File Offset: 0x00040A9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000428A8 File Offset: 0x00040AA8
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
					this.updatedQuests_.AddEntriesFrom(ref input, QuestDebugSnapshot._repeated_updatedQuests_codec);
				}
			}
		}

		// Token: 0x04000745 RID: 1861
		private static readonly MessageParser<QuestDebugSnapshot> _parser = new MessageParser<QuestDebugSnapshot>(() => new QuestDebugSnapshot());

		// Token: 0x04000746 RID: 1862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000747 RID: 1863
		public const int UpdatedQuestsFieldNumber = 1;

		// Token: 0x04000748 RID: 1864
		private static readonly FieldCodec<QuestDebugSnapshot.Types.QuestDebugInfo> _repeated_updatedQuests_codec = FieldCodec.ForMessage<QuestDebugSnapshot.Types.QuestDebugInfo>(10U, QuestDebugSnapshot.Types.QuestDebugInfo.Parser);

		// Token: 0x04000749 RID: 1865
		private readonly RepeatedField<QuestDebugSnapshot.Types.QuestDebugInfo> updatedQuests_ = new RepeatedField<QuestDebugSnapshot.Types.QuestDebugInfo>();

		// Token: 0x02000BDA RID: 3034
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001468 RID: 5224
			public sealed class CallbackDebugInfo : IMessage<QuestDebugSnapshot.Types.CallbackDebugInfo>, IMessage, IEquatable<QuestDebugSnapshot.Types.CallbackDebugInfo>, IDeepCloneable<QuestDebugSnapshot.Types.CallbackDebugInfo>, IBufferMessage
			{
				// Token: 0x17003A02 RID: 14850
				// (get) Token: 0x0600E45A RID: 58458 RVA: 0x004D066C File Offset: 0x004CE86C
				[DebuggerNonUserCode]
				public static MessageParser<QuestDebugSnapshot.Types.CallbackDebugInfo> Parser
				{
					get
					{
						return QuestDebugSnapshot.Types.CallbackDebugInfo._parser;
					}
				}

				// Token: 0x17003A03 RID: 14851
				// (get) Token: 0x0600E45B RID: 58459 RVA: 0x004D0684 File Offset: 0x004CE884
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A04 RID: 14852
				// (get) Token: 0x0600E45C RID: 58460 RVA: 0x004D06A8 File Offset: 0x004CE8A8
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Types.CallbackDebugInfo.Descriptor;
					}
				}

				// Token: 0x0600E45D RID: 58461 RVA: 0x004D06BF File Offset: 0x004CE8BF
				[DebuggerNonUserCode]
				public CallbackDebugInfo()
				{
				}

				// Token: 0x0600E45E RID: 58462 RVA: 0x004D06CC File Offset: 0x004CE8CC
				[DebuggerNonUserCode]
				public CallbackDebugInfo(QuestDebugSnapshot.Types.CallbackDebugInfo other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.callbackUid_ = other.callbackUid_;
					this.callbackComplete_ = other.callbackComplete_;
					this.callbackCountCurrent_ = other.callbackCountCurrent_;
					this.callbackCountRequired_ = other.callbackCountRequired_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E45F RID: 58463 RVA: 0x004D0730 File Offset: 0x004CE930
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.CallbackDebugInfo Clone()
				{
					return new QuestDebugSnapshot.Types.CallbackDebugInfo(this);
				}

				// Token: 0x17003A05 RID: 14853
				// (get) Token: 0x0600E460 RID: 58464 RVA: 0x004D0748 File Offset: 0x004CE948
				// (set) Token: 0x0600E461 RID: 58465 RVA: 0x004D0779 File Offset: 0x004CE979
				[DebuggerNonUserCode]
				public uint CallbackUid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint callbackUidDefaultValue;
						if (flag)
						{
							callbackUidDefaultValue = this.callbackUid_;
						}
						else
						{
							callbackUidDefaultValue = QuestDebugSnapshot.Types.CallbackDebugInfo.CallbackUidDefaultValue;
						}
						return callbackUidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.callbackUid_ = value;
					}
				}

				// Token: 0x17003A06 RID: 14854
				// (get) Token: 0x0600E462 RID: 58466 RVA: 0x004D0794 File Offset: 0x004CE994
				[DebuggerNonUserCode]
				public bool HasCallbackUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E463 RID: 58467 RVA: 0x004D07B1 File Offset: 0x004CE9B1
				[DebuggerNonUserCode]
				public void ClearCallbackUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A07 RID: 14855
				// (get) Token: 0x0600E464 RID: 58468 RVA: 0x004D07C4 File Offset: 0x004CE9C4
				// (set) Token: 0x0600E465 RID: 58469 RVA: 0x004D07F5 File Offset: 0x004CE9F5
				[DebuggerNonUserCode]
				public bool CallbackComplete
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						bool callbackCompleteDefaultValue;
						if (flag)
						{
							callbackCompleteDefaultValue = this.callbackComplete_;
						}
						else
						{
							callbackCompleteDefaultValue = QuestDebugSnapshot.Types.CallbackDebugInfo.CallbackCompleteDefaultValue;
						}
						return callbackCompleteDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.callbackComplete_ = value;
					}
				}

				// Token: 0x17003A08 RID: 14856
				// (get) Token: 0x0600E466 RID: 58470 RVA: 0x004D0810 File Offset: 0x004CEA10
				[DebuggerNonUserCode]
				public bool HasCallbackComplete
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E467 RID: 58471 RVA: 0x004D082D File Offset: 0x004CEA2D
				[DebuggerNonUserCode]
				public void ClearCallbackComplete()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A09 RID: 14857
				// (get) Token: 0x0600E468 RID: 58472 RVA: 0x004D0840 File Offset: 0x004CEA40
				// (set) Token: 0x0600E469 RID: 58473 RVA: 0x004D0871 File Offset: 0x004CEA71
				[DebuggerNonUserCode]
				public uint CallbackCountCurrent
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						uint callbackCountCurrentDefaultValue;
						if (flag)
						{
							callbackCountCurrentDefaultValue = this.callbackCountCurrent_;
						}
						else
						{
							callbackCountCurrentDefaultValue = QuestDebugSnapshot.Types.CallbackDebugInfo.CallbackCountCurrentDefaultValue;
						}
						return callbackCountCurrentDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.callbackCountCurrent_ = value;
					}
				}

				// Token: 0x17003A0A RID: 14858
				// (get) Token: 0x0600E46A RID: 58474 RVA: 0x004D088C File Offset: 0x004CEA8C
				[DebuggerNonUserCode]
				public bool HasCallbackCountCurrent
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E46B RID: 58475 RVA: 0x004D08A9 File Offset: 0x004CEAA9
				[DebuggerNonUserCode]
				public void ClearCallbackCountCurrent()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003A0B RID: 14859
				// (get) Token: 0x0600E46C RID: 58476 RVA: 0x004D08BC File Offset: 0x004CEABC
				// (set) Token: 0x0600E46D RID: 58477 RVA: 0x004D08ED File Offset: 0x004CEAED
				[DebuggerNonUserCode]
				public uint CallbackCountRequired
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						uint callbackCountRequiredDefaultValue;
						if (flag)
						{
							callbackCountRequiredDefaultValue = this.callbackCountRequired_;
						}
						else
						{
							callbackCountRequiredDefaultValue = QuestDebugSnapshot.Types.CallbackDebugInfo.CallbackCountRequiredDefaultValue;
						}
						return callbackCountRequiredDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.callbackCountRequired_ = value;
					}
				}

				// Token: 0x17003A0C RID: 14860
				// (get) Token: 0x0600E46E RID: 58478 RVA: 0x004D0908 File Offset: 0x004CEB08
				[DebuggerNonUserCode]
				public bool HasCallbackCountRequired
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E46F RID: 58479 RVA: 0x004D0925 File Offset: 0x004CEB25
				[DebuggerNonUserCode]
				public void ClearCallbackCountRequired()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x0600E470 RID: 58480 RVA: 0x004D0938 File Offset: 0x004CEB38
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestDebugSnapshot.Types.CallbackDebugInfo);
				}

				// Token: 0x0600E471 RID: 58481 RVA: 0x004D0958 File Offset: 0x004CEB58
				[DebuggerNonUserCode]
				public bool Equals(QuestDebugSnapshot.Types.CallbackDebugInfo other)
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
							bool flag4 = this.CallbackUid != other.CallbackUid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.CallbackComplete != other.CallbackComplete;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.CallbackCountCurrent != other.CallbackCountCurrent;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.CallbackCountRequired != other.CallbackCountRequired;
										flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E472 RID: 58482 RVA: 0x004D0A04 File Offset: 0x004CEC04
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						num ^= this.CallbackUid.GetHashCode();
					}
					bool hasCallbackComplete = this.HasCallbackComplete;
					if (hasCallbackComplete)
					{
						num ^= this.CallbackComplete.GetHashCode();
					}
					bool hasCallbackCountCurrent = this.HasCallbackCountCurrent;
					if (hasCallbackCountCurrent)
					{
						num ^= this.CallbackCountCurrent.GetHashCode();
					}
					bool hasCallbackCountRequired = this.HasCallbackCountRequired;
					if (hasCallbackCountRequired)
					{
						num ^= this.CallbackCountRequired.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E473 RID: 58483 RVA: 0x004D0AAC File Offset: 0x004CECAC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E474 RID: 58484 RVA: 0x004D0AC4 File Offset: 0x004CECC4
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E475 RID: 58485 RVA: 0x004D0AD0 File Offset: 0x004CECD0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.CallbackUid);
					}
					bool hasCallbackComplete = this.HasCallbackComplete;
					if (hasCallbackComplete)
					{
						output.WriteRawTag(16);
						output.WriteBool(this.CallbackComplete);
					}
					bool hasCallbackCountCurrent = this.HasCallbackCountCurrent;
					if (hasCallbackCountCurrent)
					{
						output.WriteRawTag(24);
						output.WriteUInt32(this.CallbackCountCurrent);
					}
					bool hasCallbackCountRequired = this.HasCallbackCountRequired;
					if (hasCallbackCountRequired)
					{
						output.WriteRawTag(32);
						output.WriteUInt32(this.CallbackCountRequired);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E476 RID: 58486 RVA: 0x004D0B84 File Offset: 0x004CED84
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackUid);
					}
					bool hasCallbackComplete = this.HasCallbackComplete;
					if (hasCallbackComplete)
					{
						num += 2;
					}
					bool hasCallbackCountCurrent = this.HasCallbackCountCurrent;
					if (hasCallbackCountCurrent)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackCountCurrent);
					}
					bool hasCallbackCountRequired = this.HasCallbackCountRequired;
					if (hasCallbackCountRequired)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackCountRequired);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E477 RID: 58487 RVA: 0x004D0C20 File Offset: 0x004CEE20
				[DebuggerNonUserCode]
				public void MergeFrom(QuestDebugSnapshot.Types.CallbackDebugInfo other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasCallbackUid = other.HasCallbackUid;
						if (hasCallbackUid)
						{
							this.CallbackUid = other.CallbackUid;
						}
						bool hasCallbackComplete = other.HasCallbackComplete;
						if (hasCallbackComplete)
						{
							this.CallbackComplete = other.CallbackComplete;
						}
						bool hasCallbackCountCurrent = other.HasCallbackCountCurrent;
						if (hasCallbackCountCurrent)
						{
							this.CallbackCountCurrent = other.CallbackCountCurrent;
						}
						bool hasCallbackCountRequired = other.HasCallbackCountRequired;
						if (hasCallbackCountRequired)
						{
							this.CallbackCountRequired = other.CallbackCountRequired;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E478 RID: 58488 RVA: 0x004D0CB6 File Offset: 0x004CEEB6
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E479 RID: 58489 RVA: 0x004D0CC4 File Offset: 0x004CEEC4
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
								this.CallbackComplete = input.ReadBool();
							}
							else
							{
								this.CallbackUid = input.ReadUInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								goto IL_0028;
							}
							this.CallbackCountRequired = input.ReadUInt32();
						}
						else
						{
							this.CallbackCountCurrent = input.ReadUInt32();
						}
						continue;
						IL_0028:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A2B9 RID: 41657
				private static readonly MessageParser<QuestDebugSnapshot.Types.CallbackDebugInfo> _parser = new MessageParser<QuestDebugSnapshot.Types.CallbackDebugInfo>(() => new QuestDebugSnapshot.Types.CallbackDebugInfo());

				// Token: 0x0400A2BA RID: 41658
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2BB RID: 41659
				private int _hasBits0;

				// Token: 0x0400A2BC RID: 41660
				public const int CallbackUidFieldNumber = 1;

				// Token: 0x0400A2BD RID: 41661
				private static readonly uint CallbackUidDefaultValue = 0U;

				// Token: 0x0400A2BE RID: 41662
				private uint callbackUid_;

				// Token: 0x0400A2BF RID: 41663
				public const int CallbackCompleteFieldNumber = 2;

				// Token: 0x0400A2C0 RID: 41664
				private static readonly bool CallbackCompleteDefaultValue = false;

				// Token: 0x0400A2C1 RID: 41665
				private bool callbackComplete_;

				// Token: 0x0400A2C2 RID: 41666
				public const int CallbackCountCurrentFieldNumber = 3;

				// Token: 0x0400A2C3 RID: 41667
				private static readonly uint CallbackCountCurrentDefaultValue = 0U;

				// Token: 0x0400A2C4 RID: 41668
				private uint callbackCountCurrent_;

				// Token: 0x0400A2C5 RID: 41669
				public const int CallbackCountRequiredFieldNumber = 4;

				// Token: 0x0400A2C6 RID: 41670
				private static readonly uint CallbackCountRequiredDefaultValue = 0U;

				// Token: 0x0400A2C7 RID: 41671
				private uint callbackCountRequired_;
			}

			// Token: 0x02001469 RID: 5225
			public sealed class CallbackSetDebugInfo : IMessage<QuestDebugSnapshot.Types.CallbackSetDebugInfo>, IMessage, IEquatable<QuestDebugSnapshot.Types.CallbackSetDebugInfo>, IDeepCloneable<QuestDebugSnapshot.Types.CallbackSetDebugInfo>, IBufferMessage
			{
				// Token: 0x17003A0D RID: 14861
				// (get) Token: 0x0600E47B RID: 58491 RVA: 0x004D0D94 File Offset: 0x004CEF94
				[DebuggerNonUserCode]
				public static MessageParser<QuestDebugSnapshot.Types.CallbackSetDebugInfo> Parser
				{
					get
					{
						return QuestDebugSnapshot.Types.CallbackSetDebugInfo._parser;
					}
				}

				// Token: 0x17003A0E RID: 14862
				// (get) Token: 0x0600E47C RID: 58492 RVA: 0x004D0DAC File Offset: 0x004CEFAC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x17003A0F RID: 14863
				// (get) Token: 0x0600E47D RID: 58493 RVA: 0x004D0DD0 File Offset: 0x004CEFD0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Types.CallbackSetDebugInfo.Descriptor;
					}
				}

				// Token: 0x0600E47E RID: 58494 RVA: 0x004D0DE7 File Offset: 0x004CEFE7
				[DebuggerNonUserCode]
				public CallbackSetDebugInfo()
				{
				}

				// Token: 0x0600E47F RID: 58495 RVA: 0x004D0DFC File Offset: 0x004CEFFC
				[DebuggerNonUserCode]
				public CallbackSetDebugInfo(QuestDebugSnapshot.Types.CallbackSetDebugInfo other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.callbackSetUid_ = other.callbackSetUid_;
					this.callbackSetComplete_ = other.callbackSetComplete_;
					this.callbackInfo_ = other.callbackInfo_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E480 RID: 58496 RVA: 0x004D0E58 File Offset: 0x004CF058
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.CallbackSetDebugInfo Clone()
				{
					return new QuestDebugSnapshot.Types.CallbackSetDebugInfo(this);
				}

				// Token: 0x17003A10 RID: 14864
				// (get) Token: 0x0600E481 RID: 58497 RVA: 0x004D0E70 File Offset: 0x004CF070
				// (set) Token: 0x0600E482 RID: 58498 RVA: 0x004D0EA1 File Offset: 0x004CF0A1
				[DebuggerNonUserCode]
				public uint CallbackSetUid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint callbackSetUidDefaultValue;
						if (flag)
						{
							callbackSetUidDefaultValue = this.callbackSetUid_;
						}
						else
						{
							callbackSetUidDefaultValue = QuestDebugSnapshot.Types.CallbackSetDebugInfo.CallbackSetUidDefaultValue;
						}
						return callbackSetUidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.callbackSetUid_ = value;
					}
				}

				// Token: 0x17003A11 RID: 14865
				// (get) Token: 0x0600E483 RID: 58499 RVA: 0x004D0EBC File Offset: 0x004CF0BC
				[DebuggerNonUserCode]
				public bool HasCallbackSetUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E484 RID: 58500 RVA: 0x004D0ED9 File Offset: 0x004CF0D9
				[DebuggerNonUserCode]
				public void ClearCallbackSetUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A12 RID: 14866
				// (get) Token: 0x0600E485 RID: 58501 RVA: 0x004D0EEC File Offset: 0x004CF0EC
				// (set) Token: 0x0600E486 RID: 58502 RVA: 0x004D0F1D File Offset: 0x004CF11D
				[DebuggerNonUserCode]
				public bool CallbackSetComplete
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						bool callbackSetCompleteDefaultValue;
						if (flag)
						{
							callbackSetCompleteDefaultValue = this.callbackSetComplete_;
						}
						else
						{
							callbackSetCompleteDefaultValue = QuestDebugSnapshot.Types.CallbackSetDebugInfo.CallbackSetCompleteDefaultValue;
						}
						return callbackSetCompleteDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.callbackSetComplete_ = value;
					}
				}

				// Token: 0x17003A13 RID: 14867
				// (get) Token: 0x0600E487 RID: 58503 RVA: 0x004D0F38 File Offset: 0x004CF138
				[DebuggerNonUserCode]
				public bool HasCallbackSetComplete
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E488 RID: 58504 RVA: 0x004D0F55 File Offset: 0x004CF155
				[DebuggerNonUserCode]
				public void ClearCallbackSetComplete()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A14 RID: 14868
				// (get) Token: 0x0600E489 RID: 58505 RVA: 0x004D0F68 File Offset: 0x004CF168
				[DebuggerNonUserCode]
				public RepeatedField<QuestDebugSnapshot.Types.CallbackDebugInfo> CallbackInfo
				{
					get
					{
						return this.callbackInfo_;
					}
				}

				// Token: 0x0600E48A RID: 58506 RVA: 0x004D0F80 File Offset: 0x004CF180
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestDebugSnapshot.Types.CallbackSetDebugInfo);
				}

				// Token: 0x0600E48B RID: 58507 RVA: 0x004D0FA0 File Offset: 0x004CF1A0
				[DebuggerNonUserCode]
				public bool Equals(QuestDebugSnapshot.Types.CallbackSetDebugInfo other)
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
							bool flag4 = this.CallbackSetUid != other.CallbackSetUid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.CallbackSetComplete != other.CallbackSetComplete;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.callbackInfo_.Equals(other.callbackInfo_);
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E48C RID: 58508 RVA: 0x004D1030 File Offset: 0x004CF230
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasCallbackSetUid = this.HasCallbackSetUid;
					if (hasCallbackSetUid)
					{
						num ^= this.CallbackSetUid.GetHashCode();
					}
					bool hasCallbackSetComplete = this.HasCallbackSetComplete;
					if (hasCallbackSetComplete)
					{
						num ^= this.CallbackSetComplete.GetHashCode();
					}
					num ^= this.callbackInfo_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E48D RID: 58509 RVA: 0x004D10AC File Offset: 0x004CF2AC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E48E RID: 58510 RVA: 0x004D10C4 File Offset: 0x004CF2C4
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E48F RID: 58511 RVA: 0x004D10D0 File Offset: 0x004CF2D0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasCallbackSetUid = this.HasCallbackSetUid;
					if (hasCallbackSetUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.CallbackSetUid);
					}
					bool hasCallbackSetComplete = this.HasCallbackSetComplete;
					if (hasCallbackSetComplete)
					{
						output.WriteRawTag(16);
						output.WriteBool(this.CallbackSetComplete);
					}
					this.callbackInfo_.WriteTo(ref output, QuestDebugSnapshot.Types.CallbackSetDebugInfo._repeated_callbackInfo_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E490 RID: 58512 RVA: 0x004D1150 File Offset: 0x004CF350
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasCallbackSetUid = this.HasCallbackSetUid;
					if (hasCallbackSetUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackSetUid);
					}
					bool hasCallbackSetComplete = this.HasCallbackSetComplete;
					if (hasCallbackSetComplete)
					{
						num += 2;
					}
					num += this.callbackInfo_.CalculateSize(QuestDebugSnapshot.Types.CallbackSetDebugInfo._repeated_callbackInfo_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E491 RID: 58513 RVA: 0x004D11C4 File Offset: 0x004CF3C4
				[DebuggerNonUserCode]
				public void MergeFrom(QuestDebugSnapshot.Types.CallbackSetDebugInfo other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasCallbackSetUid = other.HasCallbackSetUid;
						if (hasCallbackSetUid)
						{
							this.CallbackSetUid = other.CallbackSetUid;
						}
						bool hasCallbackSetComplete = other.HasCallbackSetComplete;
						if (hasCallbackSetComplete)
						{
							this.CallbackSetComplete = other.CallbackSetComplete;
						}
						this.callbackInfo_.Add(other.callbackInfo_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E492 RID: 58514 RVA: 0x004D1238 File Offset: 0x004CF438
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E493 RID: 58515 RVA: 0x004D1244 File Offset: 0x004CF444
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
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
								}
								else
								{
									this.callbackInfo_.AddEntriesFrom(ref input, QuestDebugSnapshot.Types.CallbackSetDebugInfo._repeated_callbackInfo_codec);
								}
							}
							else
							{
								this.CallbackSetComplete = input.ReadBool();
							}
						}
						else
						{
							this.CallbackSetUid = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A2C8 RID: 41672
				private static readonly MessageParser<QuestDebugSnapshot.Types.CallbackSetDebugInfo> _parser = new MessageParser<QuestDebugSnapshot.Types.CallbackSetDebugInfo>(() => new QuestDebugSnapshot.Types.CallbackSetDebugInfo());

				// Token: 0x0400A2C9 RID: 41673
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2CA RID: 41674
				private int _hasBits0;

				// Token: 0x0400A2CB RID: 41675
				public const int CallbackSetUidFieldNumber = 1;

				// Token: 0x0400A2CC RID: 41676
				private static readonly uint CallbackSetUidDefaultValue = 0U;

				// Token: 0x0400A2CD RID: 41677
				private uint callbackSetUid_;

				// Token: 0x0400A2CE RID: 41678
				public const int CallbackSetCompleteFieldNumber = 2;

				// Token: 0x0400A2CF RID: 41679
				private static readonly bool CallbackSetCompleteDefaultValue = false;

				// Token: 0x0400A2D0 RID: 41680
				private bool callbackSetComplete_;

				// Token: 0x0400A2D1 RID: 41681
				public const int CallbackInfoFieldNumber = 3;

				// Token: 0x0400A2D2 RID: 41682
				private static readonly FieldCodec<QuestDebugSnapshot.Types.CallbackDebugInfo> _repeated_callbackInfo_codec = FieldCodec.ForMessage<QuestDebugSnapshot.Types.CallbackDebugInfo>(26U, QuestDebugSnapshot.Types.CallbackDebugInfo.Parser);

				// Token: 0x0400A2D3 RID: 41683
				private readonly RepeatedField<QuestDebugSnapshot.Types.CallbackDebugInfo> callbackInfo_ = new RepeatedField<QuestDebugSnapshot.Types.CallbackDebugInfo>();
			}

			// Token: 0x0200146A RID: 5226
			public sealed class PhaseDebugInfo : IMessage<QuestDebugSnapshot.Types.PhaseDebugInfo>, IMessage, IEquatable<QuestDebugSnapshot.Types.PhaseDebugInfo>, IDeepCloneable<QuestDebugSnapshot.Types.PhaseDebugInfo>, IBufferMessage
			{
				// Token: 0x17003A15 RID: 14869
				// (get) Token: 0x0600E495 RID: 58517 RVA: 0x004D1300 File Offset: 0x004CF500
				[DebuggerNonUserCode]
				public static MessageParser<QuestDebugSnapshot.Types.PhaseDebugInfo> Parser
				{
					get
					{
						return QuestDebugSnapshot.Types.PhaseDebugInfo._parser;
					}
				}

				// Token: 0x17003A16 RID: 14870
				// (get) Token: 0x0600E496 RID: 58518 RVA: 0x004D1318 File Offset: 0x004CF518
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Descriptor.NestedTypes[2];
					}
				}

				// Token: 0x17003A17 RID: 14871
				// (get) Token: 0x0600E497 RID: 58519 RVA: 0x004D133C File Offset: 0x004CF53C
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Types.PhaseDebugInfo.Descriptor;
					}
				}

				// Token: 0x0600E498 RID: 58520 RVA: 0x004D1353 File Offset: 0x004CF553
				[DebuggerNonUserCode]
				public PhaseDebugInfo()
				{
				}

				// Token: 0x0600E499 RID: 58521 RVA: 0x004D1368 File Offset: 0x004CF568
				[DebuggerNonUserCode]
				public PhaseDebugInfo(QuestDebugSnapshot.Types.PhaseDebugInfo other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.phaseUid_ = other.phaseUid_;
					this.phaseComplete_ = other.phaseComplete_;
					this.callbackSetInfo_ = other.callbackSetInfo_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E49A RID: 58522 RVA: 0x004D13C4 File Offset: 0x004CF5C4
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.PhaseDebugInfo Clone()
				{
					return new QuestDebugSnapshot.Types.PhaseDebugInfo(this);
				}

				// Token: 0x17003A18 RID: 14872
				// (get) Token: 0x0600E49B RID: 58523 RVA: 0x004D13DC File Offset: 0x004CF5DC
				// (set) Token: 0x0600E49C RID: 58524 RVA: 0x004D140D File Offset: 0x004CF60D
				[DebuggerNonUserCode]
				public uint PhaseUid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint phaseUidDefaultValue;
						if (flag)
						{
							phaseUidDefaultValue = this.phaseUid_;
						}
						else
						{
							phaseUidDefaultValue = QuestDebugSnapshot.Types.PhaseDebugInfo.PhaseUidDefaultValue;
						}
						return phaseUidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.phaseUid_ = value;
					}
				}

				// Token: 0x17003A19 RID: 14873
				// (get) Token: 0x0600E49D RID: 58525 RVA: 0x004D1428 File Offset: 0x004CF628
				[DebuggerNonUserCode]
				public bool HasPhaseUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E49E RID: 58526 RVA: 0x004D1445 File Offset: 0x004CF645
				[DebuggerNonUserCode]
				public void ClearPhaseUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A1A RID: 14874
				// (get) Token: 0x0600E49F RID: 58527 RVA: 0x004D1458 File Offset: 0x004CF658
				// (set) Token: 0x0600E4A0 RID: 58528 RVA: 0x004D1489 File Offset: 0x004CF689
				[DebuggerNonUserCode]
				public bool PhaseComplete
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						bool phaseCompleteDefaultValue;
						if (flag)
						{
							phaseCompleteDefaultValue = this.phaseComplete_;
						}
						else
						{
							phaseCompleteDefaultValue = QuestDebugSnapshot.Types.PhaseDebugInfo.PhaseCompleteDefaultValue;
						}
						return phaseCompleteDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.phaseComplete_ = value;
					}
				}

				// Token: 0x17003A1B RID: 14875
				// (get) Token: 0x0600E4A1 RID: 58529 RVA: 0x004D14A4 File Offset: 0x004CF6A4
				[DebuggerNonUserCode]
				public bool HasPhaseComplete
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E4A2 RID: 58530 RVA: 0x004D14C1 File Offset: 0x004CF6C1
				[DebuggerNonUserCode]
				public void ClearPhaseComplete()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A1C RID: 14876
				// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x004D14D4 File Offset: 0x004CF6D4
				[DebuggerNonUserCode]
				public RepeatedField<QuestDebugSnapshot.Types.CallbackSetDebugInfo> CallbackSetInfo
				{
					get
					{
						return this.callbackSetInfo_;
					}
				}

				// Token: 0x0600E4A4 RID: 58532 RVA: 0x004D14EC File Offset: 0x004CF6EC
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestDebugSnapshot.Types.PhaseDebugInfo);
				}

				// Token: 0x0600E4A5 RID: 58533 RVA: 0x004D150C File Offset: 0x004CF70C
				[DebuggerNonUserCode]
				public bool Equals(QuestDebugSnapshot.Types.PhaseDebugInfo other)
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
							bool flag4 = this.PhaseUid != other.PhaseUid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.PhaseComplete != other.PhaseComplete;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.callbackSetInfo_.Equals(other.callbackSetInfo_);
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E4A6 RID: 58534 RVA: 0x004D159C File Offset: 0x004CF79C
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasPhaseUid = this.HasPhaseUid;
					if (hasPhaseUid)
					{
						num ^= this.PhaseUid.GetHashCode();
					}
					bool hasPhaseComplete = this.HasPhaseComplete;
					if (hasPhaseComplete)
					{
						num ^= this.PhaseComplete.GetHashCode();
					}
					num ^= this.callbackSetInfo_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E4A7 RID: 58535 RVA: 0x004D1618 File Offset: 0x004CF818
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E4A8 RID: 58536 RVA: 0x004D1630 File Offset: 0x004CF830
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E4A9 RID: 58537 RVA: 0x004D163C File Offset: 0x004CF83C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasPhaseUid = this.HasPhaseUid;
					if (hasPhaseUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.PhaseUid);
					}
					bool hasPhaseComplete = this.HasPhaseComplete;
					if (hasPhaseComplete)
					{
						output.WriteRawTag(16);
						output.WriteBool(this.PhaseComplete);
					}
					this.callbackSetInfo_.WriteTo(ref output, QuestDebugSnapshot.Types.PhaseDebugInfo._repeated_callbackSetInfo_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E4AA RID: 58538 RVA: 0x004D16BC File Offset: 0x004CF8BC
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasPhaseUid = this.HasPhaseUid;
					if (hasPhaseUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.PhaseUid);
					}
					bool hasPhaseComplete = this.HasPhaseComplete;
					if (hasPhaseComplete)
					{
						num += 2;
					}
					num += this.callbackSetInfo_.CalculateSize(QuestDebugSnapshot.Types.PhaseDebugInfo._repeated_callbackSetInfo_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E4AB RID: 58539 RVA: 0x004D1730 File Offset: 0x004CF930
				[DebuggerNonUserCode]
				public void MergeFrom(QuestDebugSnapshot.Types.PhaseDebugInfo other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasPhaseUid = other.HasPhaseUid;
						if (hasPhaseUid)
						{
							this.PhaseUid = other.PhaseUid;
						}
						bool hasPhaseComplete = other.HasPhaseComplete;
						if (hasPhaseComplete)
						{
							this.PhaseComplete = other.PhaseComplete;
						}
						this.callbackSetInfo_.Add(other.callbackSetInfo_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E4AC RID: 58540 RVA: 0x004D17A4 File Offset: 0x004CF9A4
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E4AD RID: 58541 RVA: 0x004D17B0 File Offset: 0x004CF9B0
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
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
								}
								else
								{
									this.callbackSetInfo_.AddEntriesFrom(ref input, QuestDebugSnapshot.Types.PhaseDebugInfo._repeated_callbackSetInfo_codec);
								}
							}
							else
							{
								this.PhaseComplete = input.ReadBool();
							}
						}
						else
						{
							this.PhaseUid = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A2D4 RID: 41684
				private static readonly MessageParser<QuestDebugSnapshot.Types.PhaseDebugInfo> _parser = new MessageParser<QuestDebugSnapshot.Types.PhaseDebugInfo>(() => new QuestDebugSnapshot.Types.PhaseDebugInfo());

				// Token: 0x0400A2D5 RID: 41685
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2D6 RID: 41686
				private int _hasBits0;

				// Token: 0x0400A2D7 RID: 41687
				public const int PhaseUidFieldNumber = 1;

				// Token: 0x0400A2D8 RID: 41688
				private static readonly uint PhaseUidDefaultValue = 0U;

				// Token: 0x0400A2D9 RID: 41689
				private uint phaseUid_;

				// Token: 0x0400A2DA RID: 41690
				public const int PhaseCompleteFieldNumber = 2;

				// Token: 0x0400A2DB RID: 41691
				private static readonly bool PhaseCompleteDefaultValue = false;

				// Token: 0x0400A2DC RID: 41692
				private bool phaseComplete_;

				// Token: 0x0400A2DD RID: 41693
				public const int CallbackSetInfoFieldNumber = 3;

				// Token: 0x0400A2DE RID: 41694
				private static readonly FieldCodec<QuestDebugSnapshot.Types.CallbackSetDebugInfo> _repeated_callbackSetInfo_codec = FieldCodec.ForMessage<QuestDebugSnapshot.Types.CallbackSetDebugInfo>(26U, QuestDebugSnapshot.Types.CallbackSetDebugInfo.Parser);

				// Token: 0x0400A2DF RID: 41695
				private readonly RepeatedField<QuestDebugSnapshot.Types.CallbackSetDebugInfo> callbackSetInfo_ = new RepeatedField<QuestDebugSnapshot.Types.CallbackSetDebugInfo>();
			}

			// Token: 0x0200146B RID: 5227
			public sealed class QuestDebugInfo : IMessage<QuestDebugSnapshot.Types.QuestDebugInfo>, IMessage, IEquatable<QuestDebugSnapshot.Types.QuestDebugInfo>, IDeepCloneable<QuestDebugSnapshot.Types.QuestDebugInfo>, IBufferMessage
			{
				// Token: 0x17003A1D RID: 14877
				// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x004D186C File Offset: 0x004CFA6C
				[DebuggerNonUserCode]
				public static MessageParser<QuestDebugSnapshot.Types.QuestDebugInfo> Parser
				{
					get
					{
						return QuestDebugSnapshot.Types.QuestDebugInfo._parser;
					}
				}

				// Token: 0x17003A1E RID: 14878
				// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x004D1884 File Offset: 0x004CFA84
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Descriptor.NestedTypes[3];
					}
				}

				// Token: 0x17003A1F RID: 14879
				// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x004D18A8 File Offset: 0x004CFAA8
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestDebugSnapshot.Types.QuestDebugInfo.Descriptor;
					}
				}

				// Token: 0x0600E4B2 RID: 58546 RVA: 0x004D18BF File Offset: 0x004CFABF
				[DebuggerNonUserCode]
				public QuestDebugInfo()
				{
				}

				// Token: 0x0600E4B3 RID: 58547 RVA: 0x004D18CC File Offset: 0x004CFACC
				[DebuggerNonUserCode]
				public QuestDebugInfo(QuestDebugSnapshot.Types.QuestDebugInfo other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.questSno_ = other.questSno_;
					this.questState_ = other.questState_;
					this.currentPhaseInfo_ = ((other.currentPhaseInfo_ != null) ? other.currentPhaseInfo_.Clone() : null);
					this.backgroundPhaseInfo_ = ((other.backgroundPhaseInfo_ != null) ? other.backgroundPhaseInfo_.Clone() : null);
					this.unassignedPhaseInfo_ = ((other.unassignedPhaseInfo_ != null) ? other.unassignedPhaseInfo_.Clone() : null);
					this.unassignedPhaseStart_ = other.unassignedPhaseStart_;
					this.unassignedCallbackSetStart_ = other.unassignedCallbackSetStart_;
					this.bonusPhaseInfo_ = ((other.bonusPhaseInfo_ != null) ? other.bonusPhaseInfo_.Clone() : null);
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E4B4 RID: 58548 RVA: 0x004D19A0 File Offset: 0x004CFBA0
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.QuestDebugInfo Clone()
				{
					return new QuestDebugSnapshot.Types.QuestDebugInfo(this);
				}

				// Token: 0x17003A20 RID: 14880
				// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x004D19B8 File Offset: 0x004CFBB8
				// (set) Token: 0x0600E4B6 RID: 58550 RVA: 0x004D19E9 File Offset: 0x004CFBE9
				[DebuggerNonUserCode]
				public int QuestSno
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int questSnoDefaultValue;
						if (flag)
						{
							questSnoDefaultValue = this.questSno_;
						}
						else
						{
							questSnoDefaultValue = QuestDebugSnapshot.Types.QuestDebugInfo.QuestSnoDefaultValue;
						}
						return questSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.questSno_ = value;
					}
				}

				// Token: 0x17003A21 RID: 14881
				// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x004D1A04 File Offset: 0x004CFC04
				[DebuggerNonUserCode]
				public bool HasQuestSno
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E4B8 RID: 58552 RVA: 0x004D1A21 File Offset: 0x004CFC21
				[DebuggerNonUserCode]
				public void ClearQuestSno()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A22 RID: 14882
				// (get) Token: 0x0600E4B9 RID: 58553 RVA: 0x004D1A34 File Offset: 0x004CFC34
				// (set) Token: 0x0600E4BA RID: 58554 RVA: 0x004D1A65 File Offset: 0x004CFC65
				[DebuggerNonUserCode]
				public int QuestState
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int questStateDefaultValue;
						if (flag)
						{
							questStateDefaultValue = this.questState_;
						}
						else
						{
							questStateDefaultValue = QuestDebugSnapshot.Types.QuestDebugInfo.QuestStateDefaultValue;
						}
						return questStateDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.questState_ = value;
					}
				}

				// Token: 0x17003A23 RID: 14883
				// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x004D1A80 File Offset: 0x004CFC80
				[DebuggerNonUserCode]
				public bool HasQuestState
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E4BC RID: 58556 RVA: 0x004D1A9D File Offset: 0x004CFC9D
				[DebuggerNonUserCode]
				public void ClearQuestState()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A24 RID: 14884
				// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x004D1AB0 File Offset: 0x004CFCB0
				// (set) Token: 0x0600E4BE RID: 58558 RVA: 0x004D1AC8 File Offset: 0x004CFCC8
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.PhaseDebugInfo CurrentPhaseInfo
				{
					get
					{
						return this.currentPhaseInfo_;
					}
					set
					{
						this.currentPhaseInfo_ = value;
					}
				}

				// Token: 0x17003A25 RID: 14885
				// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x004D1AD4 File Offset: 0x004CFCD4
				// (set) Token: 0x0600E4C0 RID: 58560 RVA: 0x004D1AEC File Offset: 0x004CFCEC
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.PhaseDebugInfo BackgroundPhaseInfo
				{
					get
					{
						return this.backgroundPhaseInfo_;
					}
					set
					{
						this.backgroundPhaseInfo_ = value;
					}
				}

				// Token: 0x17003A26 RID: 14886
				// (get) Token: 0x0600E4C1 RID: 58561 RVA: 0x004D1AF8 File Offset: 0x004CFCF8
				// (set) Token: 0x0600E4C2 RID: 58562 RVA: 0x004D1B10 File Offset: 0x004CFD10
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.PhaseDebugInfo UnassignedPhaseInfo
				{
					get
					{
						return this.unassignedPhaseInfo_;
					}
					set
					{
						this.unassignedPhaseInfo_ = value;
					}
				}

				// Token: 0x17003A27 RID: 14887
				// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x004D1B1C File Offset: 0x004CFD1C
				// (set) Token: 0x0600E4C4 RID: 58564 RVA: 0x004D1B4D File Offset: 0x004CFD4D
				[DebuggerNonUserCode]
				public uint UnassignedPhaseStart
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						uint unassignedPhaseStartDefaultValue;
						if (flag)
						{
							unassignedPhaseStartDefaultValue = this.unassignedPhaseStart_;
						}
						else
						{
							unassignedPhaseStartDefaultValue = QuestDebugSnapshot.Types.QuestDebugInfo.UnassignedPhaseStartDefaultValue;
						}
						return unassignedPhaseStartDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.unassignedPhaseStart_ = value;
					}
				}

				// Token: 0x17003A28 RID: 14888
				// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x004D1B68 File Offset: 0x004CFD68
				[DebuggerNonUserCode]
				public bool HasUnassignedPhaseStart
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E4C6 RID: 58566 RVA: 0x004D1B85 File Offset: 0x004CFD85
				[DebuggerNonUserCode]
				public void ClearUnassignedPhaseStart()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003A29 RID: 14889
				// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x004D1B98 File Offset: 0x004CFD98
				// (set) Token: 0x0600E4C8 RID: 58568 RVA: 0x004D1BC9 File Offset: 0x004CFDC9
				[DebuggerNonUserCode]
				public uint UnassignedCallbackSetStart
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						uint unassignedCallbackSetStartDefaultValue;
						if (flag)
						{
							unassignedCallbackSetStartDefaultValue = this.unassignedCallbackSetStart_;
						}
						else
						{
							unassignedCallbackSetStartDefaultValue = QuestDebugSnapshot.Types.QuestDebugInfo.UnassignedCallbackSetStartDefaultValue;
						}
						return unassignedCallbackSetStartDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.unassignedCallbackSetStart_ = value;
					}
				}

				// Token: 0x17003A2A RID: 14890
				// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x004D1BE4 File Offset: 0x004CFDE4
				[DebuggerNonUserCode]
				public bool HasUnassignedCallbackSetStart
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E4CA RID: 58570 RVA: 0x004D1C01 File Offset: 0x004CFE01
				[DebuggerNonUserCode]
				public void ClearUnassignedCallbackSetStart()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x17003A2B RID: 14891
				// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x004D1C14 File Offset: 0x004CFE14
				// (set) Token: 0x0600E4CC RID: 58572 RVA: 0x004D1C2C File Offset: 0x004CFE2C
				[DebuggerNonUserCode]
				public QuestDebugSnapshot.Types.PhaseDebugInfo BonusPhaseInfo
				{
					get
					{
						return this.bonusPhaseInfo_;
					}
					set
					{
						this.bonusPhaseInfo_ = value;
					}
				}

				// Token: 0x0600E4CD RID: 58573 RVA: 0x004D1C38 File Offset: 0x004CFE38
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestDebugSnapshot.Types.QuestDebugInfo);
				}

				// Token: 0x0600E4CE RID: 58574 RVA: 0x004D1C58 File Offset: 0x004CFE58
				[DebuggerNonUserCode]
				public bool Equals(QuestDebugSnapshot.Types.QuestDebugInfo other)
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
							bool flag4 = this.QuestSno != other.QuestSno;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.QuestState != other.QuestState;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !object.Equals(this.CurrentPhaseInfo, other.CurrentPhaseInfo);
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = !object.Equals(this.BackgroundPhaseInfo, other.BackgroundPhaseInfo);
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = !object.Equals(this.UnassignedPhaseInfo, other.UnassignedPhaseInfo);
											if (flag8)
											{
												flag2 = false;
											}
											else
											{
												bool flag9 = this.UnassignedPhaseStart != other.UnassignedPhaseStart;
												if (flag9)
												{
													flag2 = false;
												}
												else
												{
													bool flag10 = this.UnassignedCallbackSetStart != other.UnassignedCallbackSetStart;
													if (flag10)
													{
														flag2 = false;
													}
													else
													{
														bool flag11 = !object.Equals(this.BonusPhaseInfo, other.BonusPhaseInfo);
														flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
													}
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

				// Token: 0x0600E4CF RID: 58575 RVA: 0x004D1D8C File Offset: 0x004CFF8C
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasQuestSno = this.HasQuestSno;
					if (hasQuestSno)
					{
						num ^= this.QuestSno.GetHashCode();
					}
					bool hasQuestState = this.HasQuestState;
					if (hasQuestState)
					{
						num ^= this.QuestState.GetHashCode();
					}
					bool flag = this.currentPhaseInfo_ != null;
					if (flag)
					{
						num ^= this.CurrentPhaseInfo.GetHashCode();
					}
					bool flag2 = this.backgroundPhaseInfo_ != null;
					if (flag2)
					{
						num ^= this.BackgroundPhaseInfo.GetHashCode();
					}
					bool flag3 = this.unassignedPhaseInfo_ != null;
					if (flag3)
					{
						num ^= this.UnassignedPhaseInfo.GetHashCode();
					}
					bool hasUnassignedPhaseStart = this.HasUnassignedPhaseStart;
					if (hasUnassignedPhaseStart)
					{
						num ^= this.UnassignedPhaseStart.GetHashCode();
					}
					bool hasUnassignedCallbackSetStart = this.HasUnassignedCallbackSetStart;
					if (hasUnassignedCallbackSetStart)
					{
						num ^= this.UnassignedCallbackSetStart.GetHashCode();
					}
					bool flag4 = this.bonusPhaseInfo_ != null;
					if (flag4)
					{
						num ^= this.BonusPhaseInfo.GetHashCode();
					}
					bool flag5 = this._unknownFields != null;
					if (flag5)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E4D0 RID: 58576 RVA: 0x004D1EA8 File Offset: 0x004D00A8
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E4D1 RID: 58577 RVA: 0x004D1EC0 File Offset: 0x004D00C0
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E4D2 RID: 58578 RVA: 0x004D1ECC File Offset: 0x004D00CC
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasQuestSno = this.HasQuestSno;
					if (hasQuestSno)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.QuestSno);
					}
					bool hasQuestState = this.HasQuestState;
					if (hasQuestState)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.QuestState);
					}
					bool flag = this.currentPhaseInfo_ != null;
					if (flag)
					{
						output.WriteRawTag(26);
						output.WriteMessage(this.CurrentPhaseInfo);
					}
					bool flag2 = this.backgroundPhaseInfo_ != null;
					if (flag2)
					{
						output.WriteRawTag(34);
						output.WriteMessage(this.BackgroundPhaseInfo);
					}
					bool flag3 = this.unassignedPhaseInfo_ != null;
					if (flag3)
					{
						output.WriteRawTag(42);
						output.WriteMessage(this.UnassignedPhaseInfo);
					}
					bool hasUnassignedPhaseStart = this.HasUnassignedPhaseStart;
					if (hasUnassignedPhaseStart)
					{
						output.WriteRawTag(48);
						output.WriteUInt32(this.UnassignedPhaseStart);
					}
					bool hasUnassignedCallbackSetStart = this.HasUnassignedCallbackSetStart;
					if (hasUnassignedCallbackSetStart)
					{
						output.WriteRawTag(56);
						output.WriteUInt32(this.UnassignedCallbackSetStart);
					}
					bool flag4 = this.bonusPhaseInfo_ != null;
					if (flag4)
					{
						output.WriteRawTag(66);
						output.WriteMessage(this.BonusPhaseInfo);
					}
					bool flag5 = this._unknownFields != null;
					if (flag5)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E4D3 RID: 58579 RVA: 0x004D201C File Offset: 0x004D021C
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasQuestSno = this.HasQuestSno;
					if (hasQuestSno)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestSno);
					}
					bool hasQuestState = this.HasQuestState;
					if (hasQuestState)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestState);
					}
					bool flag = this.currentPhaseInfo_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentPhaseInfo);
					}
					bool flag2 = this.backgroundPhaseInfo_ != null;
					if (flag2)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.BackgroundPhaseInfo);
					}
					bool flag3 = this.unassignedPhaseInfo_ != null;
					if (flag3)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.UnassignedPhaseInfo);
					}
					bool hasUnassignedPhaseStart = this.HasUnassignedPhaseStart;
					if (hasUnassignedPhaseStart)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnassignedPhaseStart);
					}
					bool hasUnassignedCallbackSetStart = this.HasUnassignedCallbackSetStart;
					if (hasUnassignedCallbackSetStart)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnassignedCallbackSetStart);
					}
					bool flag4 = this.bonusPhaseInfo_ != null;
					if (flag4)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.BonusPhaseInfo);
					}
					bool flag5 = this._unknownFields != null;
					if (flag5)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E4D4 RID: 58580 RVA: 0x004D2148 File Offset: 0x004D0348
				[DebuggerNonUserCode]
				public void MergeFrom(QuestDebugSnapshot.Types.QuestDebugInfo other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasQuestSno = other.HasQuestSno;
						if (hasQuestSno)
						{
							this.QuestSno = other.QuestSno;
						}
						bool hasQuestState = other.HasQuestState;
						if (hasQuestState)
						{
							this.QuestState = other.QuestState;
						}
						bool flag2 = other.currentPhaseInfo_ != null;
						if (flag2)
						{
							bool flag3 = this.currentPhaseInfo_ == null;
							if (flag3)
							{
								this.CurrentPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
							}
							this.CurrentPhaseInfo.MergeFrom(other.CurrentPhaseInfo);
						}
						bool flag4 = other.backgroundPhaseInfo_ != null;
						if (flag4)
						{
							bool flag5 = this.backgroundPhaseInfo_ == null;
							if (flag5)
							{
								this.BackgroundPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
							}
							this.BackgroundPhaseInfo.MergeFrom(other.BackgroundPhaseInfo);
						}
						bool flag6 = other.unassignedPhaseInfo_ != null;
						if (flag6)
						{
							bool flag7 = this.unassignedPhaseInfo_ == null;
							if (flag7)
							{
								this.UnassignedPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
							}
							this.UnassignedPhaseInfo.MergeFrom(other.UnassignedPhaseInfo);
						}
						bool hasUnassignedPhaseStart = other.HasUnassignedPhaseStart;
						if (hasUnassignedPhaseStart)
						{
							this.UnassignedPhaseStart = other.UnassignedPhaseStart;
						}
						bool hasUnassignedCallbackSetStart = other.HasUnassignedCallbackSetStart;
						if (hasUnassignedCallbackSetStart)
						{
							this.UnassignedCallbackSetStart = other.UnassignedCallbackSetStart;
						}
						bool flag8 = other.bonusPhaseInfo_ != null;
						if (flag8)
						{
							bool flag9 = this.bonusPhaseInfo_ == null;
							if (flag9)
							{
								this.BonusPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
							}
							this.BonusPhaseInfo.MergeFrom(other.BonusPhaseInfo);
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E4D5 RID: 58581 RVA: 0x004D22E1 File Offset: 0x004D04E1
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E4D6 RID: 58582 RVA: 0x004D22EC File Offset: 0x004D04EC
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 34U)
						{
							if (num3 <= 16U)
							{
								if (num3 != 8U)
								{
									if (num3 != 16U)
									{
										goto IL_0060;
									}
									this.QuestState = input.ReadInt32();
								}
								else
								{
									this.QuestSno = input.ReadInt32();
								}
							}
							else if (num3 != 26U)
							{
								if (num3 != 34U)
								{
									goto IL_0060;
								}
								bool flag = this.backgroundPhaseInfo_ == null;
								if (flag)
								{
									this.BackgroundPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
								}
								input.ReadMessage(this.BackgroundPhaseInfo);
							}
							else
							{
								bool flag2 = this.currentPhaseInfo_ == null;
								if (flag2)
								{
									this.CurrentPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
								}
								input.ReadMessage(this.CurrentPhaseInfo);
							}
						}
						else if (num3 <= 48U)
						{
							if (num3 != 42U)
							{
								if (num3 != 48U)
								{
									goto IL_0060;
								}
								this.UnassignedPhaseStart = input.ReadUInt32();
							}
							else
							{
								bool flag3 = this.unassignedPhaseInfo_ == null;
								if (flag3)
								{
									this.UnassignedPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
								}
								input.ReadMessage(this.UnassignedPhaseInfo);
							}
						}
						else if (num3 != 56U)
						{
							if (num3 != 66U)
							{
								goto IL_0060;
							}
							bool flag4 = this.bonusPhaseInfo_ == null;
							if (flag4)
							{
								this.BonusPhaseInfo = new QuestDebugSnapshot.Types.PhaseDebugInfo();
							}
							input.ReadMessage(this.BonusPhaseInfo);
						}
						else
						{
							this.UnassignedCallbackSetStart = input.ReadUInt32();
						}
						continue;
						IL_0060:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A2E0 RID: 41696
				private static readonly MessageParser<QuestDebugSnapshot.Types.QuestDebugInfo> _parser = new MessageParser<QuestDebugSnapshot.Types.QuestDebugInfo>(() => new QuestDebugSnapshot.Types.QuestDebugInfo());

				// Token: 0x0400A2E1 RID: 41697
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2E2 RID: 41698
				private int _hasBits0;

				// Token: 0x0400A2E3 RID: 41699
				public const int QuestSnoFieldNumber = 1;

				// Token: 0x0400A2E4 RID: 41700
				private static readonly int QuestSnoDefaultValue = 0;

				// Token: 0x0400A2E5 RID: 41701
				private int questSno_;

				// Token: 0x0400A2E6 RID: 41702
				public const int QuestStateFieldNumber = 2;

				// Token: 0x0400A2E7 RID: 41703
				private static readonly int QuestStateDefaultValue = 0;

				// Token: 0x0400A2E8 RID: 41704
				private int questState_;

				// Token: 0x0400A2E9 RID: 41705
				public const int CurrentPhaseInfoFieldNumber = 3;

				// Token: 0x0400A2EA RID: 41706
				private QuestDebugSnapshot.Types.PhaseDebugInfo currentPhaseInfo_;

				// Token: 0x0400A2EB RID: 41707
				public const int BackgroundPhaseInfoFieldNumber = 4;

				// Token: 0x0400A2EC RID: 41708
				private QuestDebugSnapshot.Types.PhaseDebugInfo backgroundPhaseInfo_;

				// Token: 0x0400A2ED RID: 41709
				public const int UnassignedPhaseInfoFieldNumber = 5;

				// Token: 0x0400A2EE RID: 41710
				private QuestDebugSnapshot.Types.PhaseDebugInfo unassignedPhaseInfo_;

				// Token: 0x0400A2EF RID: 41711
				public const int UnassignedPhaseStartFieldNumber = 6;

				// Token: 0x0400A2F0 RID: 41712
				private static readonly uint UnassignedPhaseStartDefaultValue = 0U;

				// Token: 0x0400A2F1 RID: 41713
				private uint unassignedPhaseStart_;

				// Token: 0x0400A2F2 RID: 41714
				public const int UnassignedCallbackSetStartFieldNumber = 7;

				// Token: 0x0400A2F3 RID: 41715
				private static readonly uint UnassignedCallbackSetStartDefaultValue = 0U;

				// Token: 0x0400A2F4 RID: 41716
				private uint unassignedCallbackSetStart_;

				// Token: 0x0400A2F5 RID: 41717
				public const int BonusPhaseInfoFieldNumber = 8;

				// Token: 0x0400A2F6 RID: 41718
				private QuestDebugSnapshot.Types.PhaseDebugInfo bonusPhaseInfo_;
			}
		}
	}
}
