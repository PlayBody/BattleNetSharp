using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F8 RID: 504
	public sealed class DebugLootOutputMessage : IMessage<DebugLootOutputMessage>, IMessage, IEquatable<DebugLootOutputMessage>, IDeepCloneable<DebugLootOutputMessage>, IBufferMessage
	{
		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x000DA29C File Offset: 0x000D849C
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootOutputMessage> Parser
		{
			get
			{
				return DebugLootOutputMessage._parser;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x000DA2B4 File Offset: 0x000D84B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[61];
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x000DA2D8 File Offset: 0x000D84D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootOutputMessage.Descriptor;
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x000DA2EF File Offset: 0x000D84EF
		[DebuggerNonUserCode]
		public DebugLootOutputMessage()
		{
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000DA31C File Offset: 0x000D851C
		[DebuggerNonUserCode]
		public DebugLootOutputMessage(DebugLootOutputMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.outputId_ = other.outputId_;
			this.itemSno_ = other.itemSno_;
			this.quality_ = other.quality_;
			this.levelReq_ = other.levelReq_;
			this.levelReqHistory_ = other.levelReqHistory_.Clone();
			this.qualityModifier_ = other.qualityModifier_;
			this.sacredRoll_ = ((other.sacredRoll_ != null) ? other.sacredRoll_.Clone() : null);
			this.ancestralRoll_ = ((other.ancestralRoll_ != null) ? other.ancestralRoll_.Clone() : null);
			this.value_ = other.value_;
			this.valueHistory_ = other.valueHistory_.Clone();
			this.currencyType_ = other.currencyType_;
			this.sockets_ = other.sockets_;
			this.socketsHistory_ = other.socketsHistory_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x000DA41C File Offset: 0x000D861C
		[DebuggerNonUserCode]
		public DebugLootOutputMessage Clone()
		{
			return new DebugLootOutputMessage(this);
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x000DA434 File Offset: 0x000D8634
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x000DA465 File Offset: 0x000D8665
		[DebuggerNonUserCode]
		public uint OutputId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint outputIdDefaultValue;
				if (flag)
				{
					outputIdDefaultValue = this.outputId_;
				}
				else
				{
					outputIdDefaultValue = DebugLootOutputMessage.OutputIdDefaultValue;
				}
				return outputIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.outputId_ = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x000DA480 File Offset: 0x000D8680
		[DebuggerNonUserCode]
		public bool HasOutputId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x000DA49D File Offset: 0x000D869D
		[DebuggerNonUserCode]
		public void ClearOutputId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x000DA4B0 File Offset: 0x000D86B0
		// (set) Token: 0x06003742 RID: 14146 RVA: 0x000DA4E1 File Offset: 0x000D86E1
		[DebuggerNonUserCode]
		public int ItemSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int itemSnoDefaultValue;
				if (flag)
				{
					itemSnoDefaultValue = this.itemSno_;
				}
				else
				{
					itemSnoDefaultValue = DebugLootOutputMessage.ItemSnoDefaultValue;
				}
				return itemSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemSno_ = value;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x000DA4FC File Offset: 0x000D86FC
		[DebuggerNonUserCode]
		public bool HasItemSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x000DA519 File Offset: 0x000D8719
		[DebuggerNonUserCode]
		public void ClearItemSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x000DA52C File Offset: 0x000D872C
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x000DA55D File Offset: 0x000D875D
		[DebuggerNonUserCode]
		public int Quality
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int qualityDefaultValue;
				if (flag)
				{
					qualityDefaultValue = this.quality_;
				}
				else
				{
					qualityDefaultValue = DebugLootOutputMessage.QualityDefaultValue;
				}
				return qualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.quality_ = value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x000DA578 File Offset: 0x000D8778
		[DebuggerNonUserCode]
		public bool HasQuality
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x000DA595 File Offset: 0x000D8795
		[DebuggerNonUserCode]
		public void ClearQuality()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x000DA5A8 File Offset: 0x000D87A8
		// (set) Token: 0x0600374A RID: 14154 RVA: 0x000DA5D9 File Offset: 0x000D87D9
		[DebuggerNonUserCode]
		public int LevelReq
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int levelReqDefaultValue;
				if (flag)
				{
					levelReqDefaultValue = this.levelReq_;
				}
				else
				{
					levelReqDefaultValue = DebugLootOutputMessage.LevelReqDefaultValue;
				}
				return levelReqDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.levelReq_ = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x000DA5F4 File Offset: 0x000D87F4
		[DebuggerNonUserCode]
		public bool HasLevelReq
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x000DA611 File Offset: 0x000D8811
		[DebuggerNonUserCode]
		public void ClearLevelReq()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x000DA624 File Offset: 0x000D8824
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> LevelReqHistory
		{
			get
			{
				return this.levelReqHistory_;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x000DA63C File Offset: 0x000D883C
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x000DA66E File Offset: 0x000D886E
		[DebuggerNonUserCode]
		public int QualityModifier
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int qualityModifierDefaultValue;
				if (flag)
				{
					qualityModifierDefaultValue = this.qualityModifier_;
				}
				else
				{
					qualityModifierDefaultValue = DebugLootOutputMessage.QualityModifierDefaultValue;
				}
				return qualityModifierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.qualityModifier_ = value;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x000DA688 File Offset: 0x000D8888
		[DebuggerNonUserCode]
		public bool HasQualityModifier
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x000DA6A6 File Offset: 0x000D88A6
		[DebuggerNonUserCode]
		public void ClearQualityModifier()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x000DA6B8 File Offset: 0x000D88B8
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x000DA6D0 File Offset: 0x000D88D0
		[DebuggerNonUserCode]
		public DebugLootRandomRollInfo SacredRoll
		{
			get
			{
				return this.sacredRoll_;
			}
			set
			{
				this.sacredRoll_ = value;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x000DA6DC File Offset: 0x000D88DC
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x000DA6F4 File Offset: 0x000D88F4
		[DebuggerNonUserCode]
		public DebugLootRandomRollInfo AncestralRoll
		{
			get
			{
				return this.ancestralRoll_;
			}
			set
			{
				this.ancestralRoll_ = value;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x000DA700 File Offset: 0x000D8900
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x000DA732 File Offset: 0x000D8932
		[DebuggerNonUserCode]
		public int Value
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = DebugLootOutputMessage.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.value_ = value;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x000DA74C File Offset: 0x000D894C
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x000DA76A File Offset: 0x000D896A
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x000DA77C File Offset: 0x000D897C
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> ValueHistory
		{
			get
			{
				return this.valueHistory_;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x000DA794 File Offset: 0x000D8994
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x000DA7C6 File Offset: 0x000D89C6
		[DebuggerNonUserCode]
		public int CurrencyType
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int currencyTypeDefaultValue;
				if (flag)
				{
					currencyTypeDefaultValue = this.currencyType_;
				}
				else
				{
					currencyTypeDefaultValue = DebugLootOutputMessage.CurrencyTypeDefaultValue;
				}
				return currencyTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.currencyType_ = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x000DA7E0 File Offset: 0x000D89E0
		[DebuggerNonUserCode]
		public bool HasCurrencyType
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x000DA7FE File Offset: 0x000D89FE
		[DebuggerNonUserCode]
		public void ClearCurrencyType()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x000DA810 File Offset: 0x000D8A10
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x000DA845 File Offset: 0x000D8A45
		[DebuggerNonUserCode]
		public int Sockets
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int socketsDefaultValue;
				if (flag)
				{
					socketsDefaultValue = this.sockets_;
				}
				else
				{
					socketsDefaultValue = DebugLootOutputMessage.SocketsDefaultValue;
				}
				return socketsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.sockets_ = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x000DA864 File Offset: 0x000D8A64
		[DebuggerNonUserCode]
		public bool HasSockets
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x000DA885 File Offset: 0x000D8A85
		[DebuggerNonUserCode]
		public void ClearSockets()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x000DA89C File Offset: 0x000D8A9C
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> SocketsHistory
		{
			get
			{
				return this.socketsHistory_;
			}
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x000DA8B4 File Offset: 0x000D8AB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootOutputMessage);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000DA8D4 File Offset: 0x000D8AD4
		[DebuggerNonUserCode]
		public bool Equals(DebugLootOutputMessage other)
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
					bool flag4 = this.OutputId != other.OutputId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemSno != other.ItemSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Quality != other.Quality;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.LevelReq != other.LevelReq;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.levelReqHistory_.Equals(other.levelReqHistory_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.QualityModifier != other.QualityModifier;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.SacredRoll, other.SacredRoll);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.AncestralRoll, other.AncestralRoll);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Value != other.Value;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.valueHistory_.Equals(other.valueHistory_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CurrencyType != other.CurrencyType;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Sockets != other.Sockets;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.socketsHistory_.Equals(other.socketsHistory_);
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
																}
															}
														}
													}
												}
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

		// Token: 0x06003766 RID: 14182 RVA: 0x000DAAA0 File Offset: 0x000D8CA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num ^= this.OutputId.GetHashCode();
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num ^= this.ItemSno.GetHashCode();
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				num ^= this.Quality.GetHashCode();
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				num ^= this.LevelReq.GetHashCode();
			}
			num ^= this.levelReqHistory_.GetHashCode();
			bool hasQualityModifier = this.HasQualityModifier;
			if (hasQualityModifier)
			{
				num ^= this.QualityModifier.GetHashCode();
			}
			bool flag = this.sacredRoll_ != null;
			if (flag)
			{
				num ^= this.SacredRoll.GetHashCode();
			}
			bool flag2 = this.ancestralRoll_ != null;
			if (flag2)
			{
				num ^= this.AncestralRoll.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			num ^= this.valueHistory_.GetHashCode();
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num ^= this.CurrencyType.GetHashCode();
			}
			bool hasSockets = this.HasSockets;
			if (hasSockets)
			{
				num ^= this.Sockets.GetHashCode();
			}
			num ^= this.socketsHistory_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x000DAC28 File Offset: 0x000D8E28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x000DAC40 File Offset: 0x000D8E40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x000DAC4C File Offset: 0x000D8E4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OutputId);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.ItemSno);
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Quality);
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LevelReq);
			}
			this.levelReqHistory_.WriteTo(ref output, DebugLootOutputMessage._repeated_levelReqHistory_codec);
			bool hasQualityModifier = this.HasQualityModifier;
			if (hasQualityModifier)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QualityModifier);
			}
			bool flag = this.sacredRoll_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SacredRoll);
			}
			bool flag2 = this.ancestralRoll_ != null;
			if (flag2)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AncestralRoll);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Value);
			}
			this.valueHistory_.WriteTo(ref output, DebugLootOutputMessage._repeated_valueHistory_codec);
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurrencyType);
			}
			bool hasSockets = this.HasSockets;
			if (hasSockets)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Sockets);
			}
			this.socketsHistory_.WriteTo(ref output, DebugLootOutputMessage._repeated_socketsHistory_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x000DAE14 File Offset: 0x000D9014
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OutputId);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num += 5;
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelReq);
			}
			num += this.levelReqHistory_.CalculateSize(DebugLootOutputMessage._repeated_levelReqHistory_codec);
			bool hasQualityModifier = this.HasQualityModifier;
			if (hasQualityModifier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QualityModifier);
			}
			bool flag = this.sacredRoll_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SacredRoll);
			}
			bool flag2 = this.ancestralRoll_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AncestralRoll);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			num += this.valueHistory_.CalculateSize(DebugLootOutputMessage._repeated_valueHistory_codec);
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrencyType);
			}
			bool hasSockets = this.HasSockets;
			if (hasSockets)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sockets);
			}
			num += this.socketsHistory_.CalculateSize(DebugLootOutputMessage._repeated_socketsHistory_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x000DAFA4 File Offset: 0x000D91A4
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootOutputMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOutputId = other.HasOutputId;
				if (hasOutputId)
				{
					this.OutputId = other.OutputId;
				}
				bool hasItemSno = other.HasItemSno;
				if (hasItemSno)
				{
					this.ItemSno = other.ItemSno;
				}
				bool hasQuality = other.HasQuality;
				if (hasQuality)
				{
					this.Quality = other.Quality;
				}
				bool hasLevelReq = other.HasLevelReq;
				if (hasLevelReq)
				{
					this.LevelReq = other.LevelReq;
				}
				this.levelReqHistory_.Add(other.levelReqHistory_);
				bool hasQualityModifier = other.HasQualityModifier;
				if (hasQualityModifier)
				{
					this.QualityModifier = other.QualityModifier;
				}
				bool flag2 = other.sacredRoll_ != null;
				if (flag2)
				{
					bool flag3 = this.sacredRoll_ == null;
					if (flag3)
					{
						this.SacredRoll = new DebugLootRandomRollInfo();
					}
					this.SacredRoll.MergeFrom(other.SacredRoll);
				}
				bool flag4 = other.ancestralRoll_ != null;
				if (flag4)
				{
					bool flag5 = this.ancestralRoll_ == null;
					if (flag5)
					{
						this.AncestralRoll = new DebugLootRandomRollInfo();
					}
					this.AncestralRoll.MergeFrom(other.AncestralRoll);
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this.valueHistory_.Add(other.valueHistory_);
				bool hasCurrencyType = other.HasCurrencyType;
				if (hasCurrencyType)
				{
					this.CurrencyType = other.CurrencyType;
				}
				bool hasSockets = other.HasSockets;
				if (hasSockets)
				{
					this.Sockets = other.Sockets;
				}
				this.socketsHistory_.Add(other.socketsHistory_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x000DB15F File Offset: 0x000D935F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x000DB16C File Offset: 0x000D936C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 21U)
							{
								if (num3 != 24U)
								{
									goto IL_00A0;
								}
								this.Quality = input.ReadInt32();
							}
							else
							{
								this.ItemSno = input.ReadSFixed32();
							}
						}
						else
						{
							this.OutputId = input.ReadUInt32();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_00A0;
							}
							this.QualityModifier = input.ReadInt32();
						}
						else
						{
							this.levelReqHistory_.AddEntriesFrom(ref input, DebugLootOutputMessage._repeated_levelReqHistory_codec);
						}
					}
					else
					{
						this.LevelReq = input.ReadInt32();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 58U)
					{
						if (num3 != 66U)
						{
							if (num3 != 72U)
							{
								goto IL_00A0;
							}
							this.Value = input.ReadInt32();
						}
						else
						{
							bool flag = this.ancestralRoll_ == null;
							if (flag)
							{
								this.AncestralRoll = new DebugLootRandomRollInfo();
							}
							input.ReadMessage(this.AncestralRoll);
						}
					}
					else
					{
						bool flag2 = this.sacredRoll_ == null;
						if (flag2)
						{
							this.SacredRoll = new DebugLootRandomRollInfo();
						}
						input.ReadMessage(this.SacredRoll);
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 82U)
					{
						if (num3 != 88U)
						{
							goto IL_00A0;
						}
						this.CurrencyType = input.ReadInt32();
					}
					else
					{
						this.valueHistory_.AddEntriesFrom(ref input, DebugLootOutputMessage._repeated_valueHistory_codec);
					}
				}
				else if (num3 != 96U)
				{
					if (num3 != 106U)
					{
						goto IL_00A0;
					}
					this.socketsHistory_.AddEntriesFrom(ref input, DebugLootOutputMessage._repeated_socketsHistory_codec);
				}
				else
				{
					this.Sockets = input.ReadInt32();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019AF RID: 6575
		private static readonly MessageParser<DebugLootOutputMessage> _parser = new MessageParser<DebugLootOutputMessage>(() => new DebugLootOutputMessage());

		// Token: 0x040019B0 RID: 6576
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019B1 RID: 6577
		private int _hasBits0;

		// Token: 0x040019B2 RID: 6578
		public const int OutputIdFieldNumber = 1;

		// Token: 0x040019B3 RID: 6579
		private static readonly uint OutputIdDefaultValue = 0U;

		// Token: 0x040019B4 RID: 6580
		private uint outputId_;

		// Token: 0x040019B5 RID: 6581
		public const int ItemSnoFieldNumber = 2;

		// Token: 0x040019B6 RID: 6582
		private static readonly int ItemSnoDefaultValue = 0;

		// Token: 0x040019B7 RID: 6583
		private int itemSno_;

		// Token: 0x040019B8 RID: 6584
		public const int QualityFieldNumber = 3;

		// Token: 0x040019B9 RID: 6585
		private static readonly int QualityDefaultValue = 0;

		// Token: 0x040019BA RID: 6586
		private int quality_;

		// Token: 0x040019BB RID: 6587
		public const int LevelReqFieldNumber = 4;

		// Token: 0x040019BC RID: 6588
		private static readonly int LevelReqDefaultValue = 0;

		// Token: 0x040019BD RID: 6589
		private int levelReq_;

		// Token: 0x040019BE RID: 6590
		public const int LevelReqHistoryFieldNumber = 5;

		// Token: 0x040019BF RID: 6591
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_levelReqHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(42U, DebugLootValueRecord.Parser);

		// Token: 0x040019C0 RID: 6592
		private readonly RepeatedField<DebugLootValueRecord> levelReqHistory_ = new RepeatedField<DebugLootValueRecord>();

		// Token: 0x040019C1 RID: 6593
		public const int QualityModifierFieldNumber = 6;

		// Token: 0x040019C2 RID: 6594
		private static readonly int QualityModifierDefaultValue = 0;

		// Token: 0x040019C3 RID: 6595
		private int qualityModifier_;

		// Token: 0x040019C4 RID: 6596
		public const int SacredRollFieldNumber = 7;

		// Token: 0x040019C5 RID: 6597
		private DebugLootRandomRollInfo sacredRoll_;

		// Token: 0x040019C6 RID: 6598
		public const int AncestralRollFieldNumber = 8;

		// Token: 0x040019C7 RID: 6599
		private DebugLootRandomRollInfo ancestralRoll_;

		// Token: 0x040019C8 RID: 6600
		public const int ValueFieldNumber = 9;

		// Token: 0x040019C9 RID: 6601
		private static readonly int ValueDefaultValue = 0;

		// Token: 0x040019CA RID: 6602
		private int value_;

		// Token: 0x040019CB RID: 6603
		public const int ValueHistoryFieldNumber = 10;

		// Token: 0x040019CC RID: 6604
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_valueHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(82U, DebugLootValueRecord.Parser);

		// Token: 0x040019CD RID: 6605
		private readonly RepeatedField<DebugLootValueRecord> valueHistory_ = new RepeatedField<DebugLootValueRecord>();

		// Token: 0x040019CE RID: 6606
		public const int CurrencyTypeFieldNumber = 11;

		// Token: 0x040019CF RID: 6607
		private static readonly int CurrencyTypeDefaultValue = 0;

		// Token: 0x040019D0 RID: 6608
		private int currencyType_;

		// Token: 0x040019D1 RID: 6609
		public const int SocketsFieldNumber = 12;

		// Token: 0x040019D2 RID: 6610
		private static readonly int SocketsDefaultValue = 0;

		// Token: 0x040019D3 RID: 6611
		private int sockets_;

		// Token: 0x040019D4 RID: 6612
		public const int SocketsHistoryFieldNumber = 13;

		// Token: 0x040019D5 RID: 6613
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_socketsHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(106U, DebugLootValueRecord.Parser);

		// Token: 0x040019D6 RID: 6614
		private readonly RepeatedField<DebugLootValueRecord> socketsHistory_ = new RepeatedField<DebugLootValueRecord>();
	}
}
