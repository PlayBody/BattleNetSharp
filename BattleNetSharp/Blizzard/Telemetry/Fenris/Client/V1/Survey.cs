using System;
using System.Diagnostics;
using Blizzard.Telemetry.Fenris.Game.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031D RID: 797
	public sealed class Survey : IMessage<Survey>, IMessage, IEquatable<Survey>, IDeepCloneable<Survey>, IBufferMessage
	{
		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x00142000 File Offset: 0x00140200
		[DebuggerNonUserCode]
		public static MessageParser<Survey> Parser
		{
			get
			{
				return Survey._parser;
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x00142018 File Offset: 0x00140218
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SurveyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x0014203C File Offset: 0x0014023C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Survey.Descriptor;
			}
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00142053 File Offset: 0x00140253
		[DebuggerNonUserCode]
		public Survey()
		{
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00142068 File Offset: 0x00140268
		[DebuggerNonUserCode]
		public Survey(Survey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroInfo_ = ((other.heroInfo_ != null) ? other.heroInfo_.Clone() : null);
			this.gameHandle_ = other.gameHandle_;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.questionValueList_ = other.questionValueList_.Clone();
			this.surveyText_ = other.surveyText_;
			this.gbidSurveyType_ = other.gbidSurveyType_;
			this.snoQuestionsStringlist_ = other.snoQuestionsStringlist_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00142110 File Offset: 0x00140310
		[DebuggerNonUserCode]
		public Survey Clone()
		{
			return new Survey(this);
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x00142128 File Offset: 0x00140328
		// (set) Token: 0x06005371 RID: 21361 RVA: 0x00142140 File Offset: 0x00140340
		[DebuggerNonUserCode]
		public HeroInfo HeroInfo
		{
			get
			{
				return this.heroInfo_;
			}
			set
			{
				this.heroInfo_ = value;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x0014214C File Offset: 0x0014034C
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x0014216D File Offset: 0x0014036D
		[DebuggerNonUserCode]
		public string GameHandle
		{
			get
			{
				return this.gameHandle_ ?? Survey.GameHandleDefaultValue;
			}
			set
			{
				this.gameHandle_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x00142184 File Offset: 0x00140384
		[DebuggerNonUserCode]
		public bool HasGameHandle
		{
			get
			{
				return this.gameHandle_ != null;
			}
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x0014219F File Offset: 0x0014039F
		[DebuggerNonUserCode]
		public void ClearGameHandle()
		{
			this.gameHandle_ = null;
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x001421AC File Offset: 0x001403AC
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x001421DD File Offset: 0x001403DD
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = Survey.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x001421F8 File Offset: 0x001403F8
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00142215 File Offset: 0x00140415
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x00142228 File Offset: 0x00140428
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x00142259 File Offset: 0x00140459
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = Survey.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x00142274 File Offset: 0x00140474
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00142291 File Offset: 0x00140491
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x001422A4 File Offset: 0x001404A4
		[DebuggerNonUserCode]
		public RepeatedField<int> QuestionValueList
		{
			get
			{
				return this.questionValueList_;
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x001422BC File Offset: 0x001404BC
		// (set) Token: 0x06005380 RID: 21376 RVA: 0x001422DD File Offset: 0x001404DD
		[DebuggerNonUserCode]
		public string SurveyText
		{
			get
			{
				return this.surveyText_ ?? Survey.SurveyTextDefaultValue;
			}
			set
			{
				this.surveyText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x001422F4 File Offset: 0x001404F4
		[DebuggerNonUserCode]
		public bool HasSurveyText
		{
			get
			{
				return this.surveyText_ != null;
			}
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x0014230F File Offset: 0x0014050F
		[DebuggerNonUserCode]
		public void ClearSurveyText()
		{
			this.surveyText_ = null;
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x0014231C File Offset: 0x0014051C
		// (set) Token: 0x06005384 RID: 21380 RVA: 0x0014234D File Offset: 0x0014054D
		[DebuggerNonUserCode]
		public int GbidSurveyType
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int gbidSurveyTypeDefaultValue;
				if (flag)
				{
					gbidSurveyTypeDefaultValue = this.gbidSurveyType_;
				}
				else
				{
					gbidSurveyTypeDefaultValue = Survey.GbidSurveyTypeDefaultValue;
				}
				return gbidSurveyTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gbidSurveyType_ = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x00142368 File Offset: 0x00140568
		[DebuggerNonUserCode]
		public bool HasGbidSurveyType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00142385 File Offset: 0x00140585
		[DebuggerNonUserCode]
		public void ClearGbidSurveyType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x00142398 File Offset: 0x00140598
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x001423C9 File Offset: 0x001405C9
		[DebuggerNonUserCode]
		public int SnoQuestionsStringlist
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int snoQuestionsStringlistDefaultValue;
				if (flag)
				{
					snoQuestionsStringlistDefaultValue = this.snoQuestionsStringlist_;
				}
				else
				{
					snoQuestionsStringlistDefaultValue = Survey.SnoQuestionsStringlistDefaultValue;
				}
				return snoQuestionsStringlistDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.snoQuestionsStringlist_ = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x001423E4 File Offset: 0x001405E4
		[DebuggerNonUserCode]
		public bool HasSnoQuestionsStringlist
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00142401 File Offset: 0x00140601
		[DebuggerNonUserCode]
		public void ClearSnoQuestionsStringlist()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00142414 File Offset: 0x00140614
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Survey);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00142434 File Offset: 0x00140634
		[DebuggerNonUserCode]
		public bool Equals(Survey other)
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
					bool flag4 = !object.Equals(this.HeroInfo, other.HeroInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameHandle != other.GameHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoGroup != other.SnoGroup;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoHandle != other.SnoHandle;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.questionValueList_.Equals(other.questionValueList_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SurveyText != other.SurveyText;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.GbidSurveyType != other.GbidSurveyType;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SnoQuestionsStringlist != other.SnoQuestionsStringlist;
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

		// Token: 0x0600538D RID: 21389 RVA: 0x00142560 File Offset: 0x00140760
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.heroInfo_ != null;
			if (flag)
			{
				num ^= this.HeroInfo.GetHashCode();
			}
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			num ^= this.questionValueList_.GetHashCode();
			bool hasSurveyText = this.HasSurveyText;
			if (hasSurveyText)
			{
				num ^= this.SurveyText.GetHashCode();
			}
			bool hasGbidSurveyType = this.HasGbidSurveyType;
			if (hasGbidSurveyType)
			{
				num ^= this.GbidSurveyType.GetHashCode();
			}
			bool hasSnoQuestionsStringlist = this.HasSnoQuestionsStringlist;
			if (hasSnoQuestionsStringlist)
			{
				num ^= this.SnoQuestionsStringlist.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00142668 File Offset: 0x00140868
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00142680 File Offset: 0x00140880
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0014268C File Offset: 0x0014088C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.heroInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HeroInfo);
			}
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameHandle);
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.SnoHandle);
			}
			this.questionValueList_.WriteTo(ref output, Survey._repeated_questionValueList_codec);
			bool hasSurveyText = this.HasSurveyText;
			if (hasSurveyText)
			{
				output.WriteRawTag(50);
				output.WriteString(this.SurveyText);
			}
			bool hasGbidSurveyType = this.HasGbidSurveyType;
			if (hasGbidSurveyType)
			{
				output.WriteRawTag(56);
				output.WriteSInt32(this.GbidSurveyType);
			}
			bool hasSnoQuestionsStringlist = this.HasSnoQuestionsStringlist;
			if (hasSnoQuestionsStringlist)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.SnoQuestionsStringlist);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x001427C4 File Offset: 0x001409C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.heroInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroInfo);
			}
			bool hasGameHandle = this.HasGameHandle;
			if (hasGameHandle)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameHandle);
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoHandle);
			}
			num += this.questionValueList_.CalculateSize(Survey._repeated_questionValueList_codec);
			bool hasSurveyText = this.HasSurveyText;
			if (hasSurveyText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SurveyText);
			}
			bool hasGbidSurveyType = this.HasGbidSurveyType;
			if (hasGbidSurveyType)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.GbidSurveyType);
			}
			bool hasSnoQuestionsStringlist = this.HasSnoQuestionsStringlist;
			if (hasSnoQuestionsStringlist)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoQuestionsStringlist);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x001428DC File Offset: 0x00140ADC
		[DebuggerNonUserCode]
		public void MergeFrom(Survey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.heroInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.heroInfo_ == null;
					if (flag3)
					{
						this.HeroInfo = new HeroInfo();
					}
					this.HeroInfo.MergeFrom(other.HeroInfo);
				}
				bool hasGameHandle = other.HasGameHandle;
				if (hasGameHandle)
				{
					this.GameHandle = other.GameHandle;
				}
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this.questionValueList_.Add(other.questionValueList_);
				bool hasSurveyText = other.HasSurveyText;
				if (hasSurveyText)
				{
					this.SurveyText = other.SurveyText;
				}
				bool hasGbidSurveyType = other.HasGbidSurveyType;
				if (hasGbidSurveyType)
				{
					this.GbidSurveyType = other.GbidSurveyType;
				}
				bool hasSnoQuestionsStringlist = other.HasSnoQuestionsStringlist;
				if (hasSnoQuestionsStringlist)
				{
					this.SnoQuestionsStringlist = other.SnoQuestionsStringlist;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x001429FD File Offset: 0x00140BFD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00142A08 File Offset: 0x00140C08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0071;
							}
							this.GameHandle = input.ReadString();
						}
						else
						{
							bool flag = this.heroInfo_ == null;
							if (flag)
							{
								this.HeroInfo = new HeroInfo();
							}
							input.ReadMessage(this.HeroInfo);
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_0071;
						}
						this.SnoHandle = input.ReadSInt32();
					}
					else
					{
						this.SnoGroup = input.ReadSInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 40U && num3 != 42U)
					{
						goto IL_0071;
					}
					this.questionValueList_.AddEntriesFrom(ref input, Survey._repeated_questionValueList_codec);
				}
				else if (num3 != 50U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							goto IL_0071;
						}
						this.SnoQuestionsStringlist = input.ReadSInt32();
					}
					else
					{
						this.GbidSurveyType = input.ReadSInt32();
					}
				}
				else
				{
					this.SurveyText = input.ReadString();
				}
				continue;
				IL_0071:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025CC RID: 9676
		private static readonly MessageParser<Survey> _parser = new MessageParser<Survey>(() => new Survey());

		// Token: 0x040025CD RID: 9677
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025CE RID: 9678
		private int _hasBits0;

		// Token: 0x040025CF RID: 9679
		public const int HeroInfoFieldNumber = 1;

		// Token: 0x040025D0 RID: 9680
		private HeroInfo heroInfo_;

		// Token: 0x040025D1 RID: 9681
		public const int GameHandleFieldNumber = 2;

		// Token: 0x040025D2 RID: 9682
		private static readonly string GameHandleDefaultValue = "";

		// Token: 0x040025D3 RID: 9683
		private string gameHandle_;

		// Token: 0x040025D4 RID: 9684
		public const int SnoGroupFieldNumber = 3;

		// Token: 0x040025D5 RID: 9685
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040025D6 RID: 9686
		private int snoGroup_;

		// Token: 0x040025D7 RID: 9687
		public const int SnoHandleFieldNumber = 4;

		// Token: 0x040025D8 RID: 9688
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040025D9 RID: 9689
		private int snoHandle_;

		// Token: 0x040025DA RID: 9690
		public const int QuestionValueListFieldNumber = 5;

		// Token: 0x040025DB RID: 9691
		private static readonly FieldCodec<int> _repeated_questionValueList_codec = FieldCodec.ForInt32(40U);

		// Token: 0x040025DC RID: 9692
		private readonly RepeatedField<int> questionValueList_ = new RepeatedField<int>();

		// Token: 0x040025DD RID: 9693
		public const int SurveyTextFieldNumber = 6;

		// Token: 0x040025DE RID: 9694
		private static readonly string SurveyTextDefaultValue = "";

		// Token: 0x040025DF RID: 9695
		private string surveyText_;

		// Token: 0x040025E0 RID: 9696
		public const int GbidSurveyTypeFieldNumber = 7;

		// Token: 0x040025E1 RID: 9697
		private static readonly int GbidSurveyTypeDefaultValue = 0;

		// Token: 0x040025E2 RID: 9698
		private int gbidSurveyType_;

		// Token: 0x040025E3 RID: 9699
		public const int SnoQuestionsStringlistFieldNumber = 8;

		// Token: 0x040025E4 RID: 9700
		private static readonly int SnoQuestionsStringlistDefaultValue = 0;

		// Token: 0x040025E5 RID: 9701
		private int snoQuestionsStringlist_;
	}
}
