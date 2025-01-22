using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000184 RID: 388
	public sealed class SpawnTrackingKeyValue : IMessage<SpawnTrackingKeyValue>, IMessage, IEquatable<SpawnTrackingKeyValue>, IDeepCloneable<SpawnTrackingKeyValue>, IBufferMessage
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0009EB74 File Offset: 0x0009CD74
		[DebuggerNonUserCode]
		public static MessageParser<SpawnTrackingKeyValue> Parser
		{
			get
			{
				return SpawnTrackingKeyValue._parser;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0009EB8C File Offset: 0x0009CD8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0009EBB0 File Offset: 0x0009CDB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpawnTrackingKeyValue.Descriptor;
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0009EBC7 File Offset: 0x0009CDC7
		[DebuggerNonUserCode]
		public SpawnTrackingKeyValue()
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0009EBD4 File Offset: 0x0009CDD4
		[DebuggerNonUserCode]
		public SpawnTrackingKeyValue(SpawnTrackingKeyValue other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.keyMarkerSno_ = other.keyMarkerSno_;
			this.keyIndex_ = other.keyIndex_;
			this.valueTransferredTimestamp_ = other.valueTransferredTimestamp_;
			this.valueBountySno_ = other.valueBountySno_;
			this.valueIsSoft_ = other.valueIsSoft_;
			this.valueGbidType_ = other.valueGbidType_;
			this.valueSnoPopulation_ = other.valueSnoPopulation_;
			this.valueSnoLevelarea_ = other.valueSnoLevelarea_;
			this.valueIsLocalEventSpawner_ = other.valueIsLocalEventSpawner_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0009EC74 File Offset: 0x0009CE74
		[DebuggerNonUserCode]
		public SpawnTrackingKeyValue Clone()
		{
			return new SpawnTrackingKeyValue(this);
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0009EC8C File Offset: 0x0009CE8C
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0009ECBD File Offset: 0x0009CEBD
		[DebuggerNonUserCode]
		public int KeyMarkerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int keyMarkerSnoDefaultValue;
				if (flag)
				{
					keyMarkerSnoDefaultValue = this.keyMarkerSno_;
				}
				else
				{
					keyMarkerSnoDefaultValue = SpawnTrackingKeyValue.KeyMarkerSnoDefaultValue;
				}
				return keyMarkerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.keyMarkerSno_ = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x0009ECD8 File Offset: 0x0009CED8
		[DebuggerNonUserCode]
		public bool HasKeyMarkerSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0009ECF5 File Offset: 0x0009CEF5
		[DebuggerNonUserCode]
		public void ClearKeyMarkerSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0009ED08 File Offset: 0x0009CF08
		// (set) Token: 0x060028AD RID: 10413 RVA: 0x0009ED39 File Offset: 0x0009CF39
		[DebuggerNonUserCode]
		public int KeyIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int keyIndexDefaultValue;
				if (flag)
				{
					keyIndexDefaultValue = this.keyIndex_;
				}
				else
				{
					keyIndexDefaultValue = SpawnTrackingKeyValue.KeyIndexDefaultValue;
				}
				return keyIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.keyIndex_ = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0009ED54 File Offset: 0x0009CF54
		[DebuggerNonUserCode]
		public bool HasKeyIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0009ED71 File Offset: 0x0009CF71
		[DebuggerNonUserCode]
		public void ClearKeyIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0009ED84 File Offset: 0x0009CF84
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0009EDB5 File Offset: 0x0009CFB5
		[DebuggerNonUserCode]
		public long ValueTransferredTimestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				long valueTransferredTimestampDefaultValue;
				if (flag)
				{
					valueTransferredTimestampDefaultValue = this.valueTransferredTimestamp_;
				}
				else
				{
					valueTransferredTimestampDefaultValue = SpawnTrackingKeyValue.ValueTransferredTimestampDefaultValue;
				}
				return valueTransferredTimestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.valueTransferredTimestamp_ = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x0009EDD0 File Offset: 0x0009CFD0
		[DebuggerNonUserCode]
		public bool HasValueTransferredTimestamp
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0009EDED File Offset: 0x0009CFED
		[DebuggerNonUserCode]
		public void ClearValueTransferredTimestamp()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x0009EE00 File Offset: 0x0009D000
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x0009EE31 File Offset: 0x0009D031
		[DebuggerNonUserCode]
		public int ValueBountySno
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int valueBountySnoDefaultValue;
				if (flag)
				{
					valueBountySnoDefaultValue = this.valueBountySno_;
				}
				else
				{
					valueBountySnoDefaultValue = SpawnTrackingKeyValue.ValueBountySnoDefaultValue;
				}
				return valueBountySnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.valueBountySno_ = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x0009EE4C File Offset: 0x0009D04C
		[DebuggerNonUserCode]
		public bool HasValueBountySno
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0009EE69 File Offset: 0x0009D069
		[DebuggerNonUserCode]
		public void ClearValueBountySno()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0009EE7C File Offset: 0x0009D07C
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x0009EEAE File Offset: 0x0009D0AE
		[DebuggerNonUserCode]
		public bool ValueIsSoft
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool valueIsSoftDefaultValue;
				if (flag)
				{
					valueIsSoftDefaultValue = this.valueIsSoft_;
				}
				else
				{
					valueIsSoftDefaultValue = SpawnTrackingKeyValue.ValueIsSoftDefaultValue;
				}
				return valueIsSoftDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.valueIsSoft_ = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x0009EEC8 File Offset: 0x0009D0C8
		[DebuggerNonUserCode]
		public bool HasValueIsSoft
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0009EEE6 File Offset: 0x0009D0E6
		[DebuggerNonUserCode]
		public void ClearValueIsSoft()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x0009EF2A File Offset: 0x0009D12A
		[DebuggerNonUserCode]
		public int ValueGbidType
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int valueGbidTypeDefaultValue;
				if (flag)
				{
					valueGbidTypeDefaultValue = this.valueGbidType_;
				}
				else
				{
					valueGbidTypeDefaultValue = SpawnTrackingKeyValue.ValueGbidTypeDefaultValue;
				}
				return valueGbidTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.valueGbidType_ = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x0009EF44 File Offset: 0x0009D144
		[DebuggerNonUserCode]
		public bool HasValueGbidType
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0009EF62 File Offset: 0x0009D162
		[DebuggerNonUserCode]
		public void ClearValueGbidType()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x0009EF74 File Offset: 0x0009D174
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x0009EFA6 File Offset: 0x0009D1A6
		[DebuggerNonUserCode]
		public int ValueSnoPopulation
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int valueSnoPopulationDefaultValue;
				if (flag)
				{
					valueSnoPopulationDefaultValue = this.valueSnoPopulation_;
				}
				else
				{
					valueSnoPopulationDefaultValue = SpawnTrackingKeyValue.ValueSnoPopulationDefaultValue;
				}
				return valueSnoPopulationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.valueSnoPopulation_ = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0009EFC0 File Offset: 0x0009D1C0
		[DebuggerNonUserCode]
		public bool HasValueSnoPopulation
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0009EFDE File Offset: 0x0009D1DE
		[DebuggerNonUserCode]
		public void ClearValueSnoPopulation()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x0009EFF0 File Offset: 0x0009D1F0
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0009F025 File Offset: 0x0009D225
		[DebuggerNonUserCode]
		public int ValueSnoLevelarea
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int valueSnoLevelareaDefaultValue;
				if (flag)
				{
					valueSnoLevelareaDefaultValue = this.valueSnoLevelarea_;
				}
				else
				{
					valueSnoLevelareaDefaultValue = SpawnTrackingKeyValue.ValueSnoLevelareaDefaultValue;
				}
				return valueSnoLevelareaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.valueSnoLevelarea_ = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x0009F044 File Offset: 0x0009D244
		[DebuggerNonUserCode]
		public bool HasValueSnoLevelarea
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0009F065 File Offset: 0x0009D265
		[DebuggerNonUserCode]
		public void ClearValueSnoLevelarea()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x0009F07C File Offset: 0x0009D27C
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x0009F0B1 File Offset: 0x0009D2B1
		[DebuggerNonUserCode]
		public bool ValueIsLocalEventSpawner
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool valueIsLocalEventSpawnerDefaultValue;
				if (flag)
				{
					valueIsLocalEventSpawnerDefaultValue = this.valueIsLocalEventSpawner_;
				}
				else
				{
					valueIsLocalEventSpawnerDefaultValue = SpawnTrackingKeyValue.ValueIsLocalEventSpawnerDefaultValue;
				}
				return valueIsLocalEventSpawnerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.valueIsLocalEventSpawner_ = value;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0009F0D0 File Offset: 0x0009D2D0
		[DebuggerNonUserCode]
		public bool HasValueIsLocalEventSpawner
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0009F0F1 File Offset: 0x0009D2F1
		[DebuggerNonUserCode]
		public void ClearValueIsLocalEventSpawner()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0009F108 File Offset: 0x0009D308
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpawnTrackingKeyValue);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0009F128 File Offset: 0x0009D328
		[DebuggerNonUserCode]
		public bool Equals(SpawnTrackingKeyValue other)
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
					bool flag4 = this.KeyMarkerSno != other.KeyMarkerSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.KeyIndex != other.KeyIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ValueTransferredTimestamp != other.ValueTransferredTimestamp;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ValueBountySno != other.ValueBountySno;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ValueIsSoft != other.ValueIsSoft;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ValueGbidType != other.ValueGbidType;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ValueSnoPopulation != other.ValueSnoPopulation;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ValueSnoLevelarea != other.ValueSnoLevelarea;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ValueIsLocalEventSpawner != other.ValueIsLocalEventSpawner;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060028CE RID: 10446 RVA: 0x0009F26C File Offset: 0x0009D46C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKeyMarkerSno = this.HasKeyMarkerSno;
			if (hasKeyMarkerSno)
			{
				num ^= this.KeyMarkerSno.GetHashCode();
			}
			bool hasKeyIndex = this.HasKeyIndex;
			if (hasKeyIndex)
			{
				num ^= this.KeyIndex.GetHashCode();
			}
			bool hasValueTransferredTimestamp = this.HasValueTransferredTimestamp;
			if (hasValueTransferredTimestamp)
			{
				num ^= this.ValueTransferredTimestamp.GetHashCode();
			}
			bool hasValueBountySno = this.HasValueBountySno;
			if (hasValueBountySno)
			{
				num ^= this.ValueBountySno.GetHashCode();
			}
			bool hasValueIsSoft = this.HasValueIsSoft;
			if (hasValueIsSoft)
			{
				num ^= this.ValueIsSoft.GetHashCode();
			}
			bool hasValueGbidType = this.HasValueGbidType;
			if (hasValueGbidType)
			{
				num ^= this.ValueGbidType.GetHashCode();
			}
			bool hasValueSnoPopulation = this.HasValueSnoPopulation;
			if (hasValueSnoPopulation)
			{
				num ^= this.ValueSnoPopulation.GetHashCode();
			}
			bool hasValueSnoLevelarea = this.HasValueSnoLevelarea;
			if (hasValueSnoLevelarea)
			{
				num ^= this.ValueSnoLevelarea.GetHashCode();
			}
			bool hasValueIsLocalEventSpawner = this.HasValueIsLocalEventSpawner;
			if (hasValueIsLocalEventSpawner)
			{
				num ^= this.ValueIsLocalEventSpawner.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0009F3A8 File Offset: 0x0009D5A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0009F3C0 File Offset: 0x0009D5C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0009F3CC File Offset: 0x0009D5CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKeyMarkerSno = this.HasKeyMarkerSno;
			if (hasKeyMarkerSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.KeyMarkerSno);
			}
			bool hasKeyIndex = this.HasKeyIndex;
			if (hasKeyIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.KeyIndex);
			}
			bool hasValueTransferredTimestamp = this.HasValueTransferredTimestamp;
			if (hasValueTransferredTimestamp)
			{
				output.WriteRawTag(24);
				output.WriteSInt64(this.ValueTransferredTimestamp);
			}
			bool hasValueBountySno = this.HasValueBountySno;
			if (hasValueBountySno)
			{
				output.WriteRawTag(45);
				output.WriteSFixed32(this.ValueBountySno);
			}
			bool hasValueIsSoft = this.HasValueIsSoft;
			if (hasValueIsSoft)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ValueIsSoft);
			}
			bool hasValueGbidType = this.HasValueGbidType;
			if (hasValueGbidType)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.ValueGbidType);
			}
			bool hasValueSnoPopulation = this.HasValueSnoPopulation;
			if (hasValueSnoPopulation)
			{
				output.WriteRawTag(69);
				output.WriteSFixed32(this.ValueSnoPopulation);
			}
			bool hasValueSnoLevelarea = this.HasValueSnoLevelarea;
			if (hasValueSnoLevelarea)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.ValueSnoLevelarea);
			}
			bool hasValueIsLocalEventSpawner = this.HasValueIsLocalEventSpawner;
			if (hasValueIsLocalEventSpawner)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.ValueIsLocalEventSpawner);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0009F534 File Offset: 0x0009D734
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKeyMarkerSno = this.HasKeyMarkerSno;
			if (hasKeyMarkerSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeyMarkerSno);
			}
			bool hasKeyIndex = this.HasKeyIndex;
			if (hasKeyIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeyIndex);
			}
			bool hasValueTransferredTimestamp = this.HasValueTransferredTimestamp;
			if (hasValueTransferredTimestamp)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.ValueTransferredTimestamp);
			}
			bool hasValueBountySno = this.HasValueBountySno;
			if (hasValueBountySno)
			{
				num += 5;
			}
			bool hasValueIsSoft = this.HasValueIsSoft;
			if (hasValueIsSoft)
			{
				num += 2;
			}
			bool hasValueGbidType = this.HasValueGbidType;
			if (hasValueGbidType)
			{
				num += 5;
			}
			bool hasValueSnoPopulation = this.HasValueSnoPopulation;
			if (hasValueSnoPopulation)
			{
				num += 5;
			}
			bool hasValueSnoLevelarea = this.HasValueSnoLevelarea;
			if (hasValueSnoLevelarea)
			{
				num += 5;
			}
			bool hasValueIsLocalEventSpawner = this.HasValueIsLocalEventSpawner;
			if (hasValueIsLocalEventSpawner)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0009F62C File Offset: 0x0009D82C
		[DebuggerNonUserCode]
		public void MergeFrom(SpawnTrackingKeyValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKeyMarkerSno = other.HasKeyMarkerSno;
				if (hasKeyMarkerSno)
				{
					this.KeyMarkerSno = other.KeyMarkerSno;
				}
				bool hasKeyIndex = other.HasKeyIndex;
				if (hasKeyIndex)
				{
					this.KeyIndex = other.KeyIndex;
				}
				bool hasValueTransferredTimestamp = other.HasValueTransferredTimestamp;
				if (hasValueTransferredTimestamp)
				{
					this.ValueTransferredTimestamp = other.ValueTransferredTimestamp;
				}
				bool hasValueBountySno = other.HasValueBountySno;
				if (hasValueBountySno)
				{
					this.ValueBountySno = other.ValueBountySno;
				}
				bool hasValueIsSoft = other.HasValueIsSoft;
				if (hasValueIsSoft)
				{
					this.ValueIsSoft = other.ValueIsSoft;
				}
				bool hasValueGbidType = other.HasValueGbidType;
				if (hasValueGbidType)
				{
					this.ValueGbidType = other.ValueGbidType;
				}
				bool hasValueSnoPopulation = other.HasValueSnoPopulation;
				if (hasValueSnoPopulation)
				{
					this.ValueSnoPopulation = other.ValueSnoPopulation;
				}
				bool hasValueSnoLevelarea = other.HasValueSnoLevelarea;
				if (hasValueSnoLevelarea)
				{
					this.ValueSnoLevelarea = other.ValueSnoLevelarea;
				}
				bool hasValueIsLocalEventSpawner = other.HasValueIsLocalEventSpawner;
				if (hasValueIsLocalEventSpawner)
				{
					this.ValueIsLocalEventSpawner = other.ValueIsLocalEventSpawner;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0009F74C File Offset: 0x0009D94C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0009F758 File Offset: 0x0009D958
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
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006A;
							}
							this.KeyIndex = input.ReadInt32();
						}
						else
						{
							this.KeyMarkerSno = input.ReadInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 45U)
						{
							goto IL_006A;
						}
						this.ValueBountySno = input.ReadSFixed32();
					}
					else
					{
						this.ValueTransferredTimestamp = input.ReadSInt64();
					}
				}
				else if (num3 <= 61U)
				{
					if (num3 != 48U)
					{
						if (num3 != 61U)
						{
							goto IL_006A;
						}
						this.ValueGbidType = input.ReadSFixed32();
					}
					else
					{
						this.ValueIsSoft = input.ReadBool();
					}
				}
				else if (num3 != 69U)
				{
					if (num3 != 77U)
					{
						if (num3 != 80U)
						{
							goto IL_006A;
						}
						this.ValueIsLocalEventSpawner = input.ReadBool();
					}
					else
					{
						this.ValueSnoLevelarea = input.ReadSFixed32();
					}
				}
				else
				{
					this.ValueSnoPopulation = input.ReadSFixed32();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001211 RID: 4625
		private static readonly MessageParser<SpawnTrackingKeyValue> _parser = new MessageParser<SpawnTrackingKeyValue>(() => new SpawnTrackingKeyValue());

		// Token: 0x04001212 RID: 4626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001213 RID: 4627
		private int _hasBits0;

		// Token: 0x04001214 RID: 4628
		public const int KeyMarkerSnoFieldNumber = 1;

		// Token: 0x04001215 RID: 4629
		private static readonly int KeyMarkerSnoDefaultValue = 0;

		// Token: 0x04001216 RID: 4630
		private int keyMarkerSno_;

		// Token: 0x04001217 RID: 4631
		public const int KeyIndexFieldNumber = 2;

		// Token: 0x04001218 RID: 4632
		private static readonly int KeyIndexDefaultValue = 0;

		// Token: 0x04001219 RID: 4633
		private int keyIndex_;

		// Token: 0x0400121A RID: 4634
		public const int ValueTransferredTimestampFieldNumber = 3;

		// Token: 0x0400121B RID: 4635
		private static readonly long ValueTransferredTimestampDefaultValue = 0L;

		// Token: 0x0400121C RID: 4636
		private long valueTransferredTimestamp_;

		// Token: 0x0400121D RID: 4637
		public const int ValueBountySnoFieldNumber = 5;

		// Token: 0x0400121E RID: 4638
		private static readonly int ValueBountySnoDefaultValue = -1;

		// Token: 0x0400121F RID: 4639
		private int valueBountySno_;

		// Token: 0x04001220 RID: 4640
		public const int ValueIsSoftFieldNumber = 6;

		// Token: 0x04001221 RID: 4641
		private static readonly bool ValueIsSoftDefaultValue = false;

		// Token: 0x04001222 RID: 4642
		private bool valueIsSoft_;

		// Token: 0x04001223 RID: 4643
		public const int ValueGbidTypeFieldNumber = 7;

		// Token: 0x04001224 RID: 4644
		private static readonly int ValueGbidTypeDefaultValue = 0;

		// Token: 0x04001225 RID: 4645
		private int valueGbidType_;

		// Token: 0x04001226 RID: 4646
		public const int ValueSnoPopulationFieldNumber = 8;

		// Token: 0x04001227 RID: 4647
		private static readonly int ValueSnoPopulationDefaultValue = 0;

		// Token: 0x04001228 RID: 4648
		private int valueSnoPopulation_;

		// Token: 0x04001229 RID: 4649
		public const int ValueSnoLevelareaFieldNumber = 9;

		// Token: 0x0400122A RID: 4650
		private static readonly int ValueSnoLevelareaDefaultValue = 0;

		// Token: 0x0400122B RID: 4651
		private int valueSnoLevelarea_;

		// Token: 0x0400122C RID: 4652
		public const int ValueIsLocalEventSpawnerFieldNumber = 10;

		// Token: 0x0400122D RID: 4653
		private static readonly bool ValueIsLocalEventSpawnerDefaultValue = false;

		// Token: 0x0400122E RID: 4654
		private bool valueIsLocalEventSpawner_;
	}
}
