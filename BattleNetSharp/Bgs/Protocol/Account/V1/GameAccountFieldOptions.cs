using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073A RID: 1850
	public sealed class GameAccountFieldOptions : IMessage<GameAccountFieldOptions>, IMessage, IEquatable<GameAccountFieldOptions>, IDeepCloneable<GameAccountFieldOptions>, IBufferMessage
	{
		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600A96E RID: 43374 RVA: 0x00294350 File Offset: 0x00292550
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountFieldOptions> Parser
		{
			get
			{
				return GameAccountFieldOptions._parser;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600A96F RID: 43375 RVA: 0x00294368 File Offset: 0x00292568
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600A970 RID: 43376 RVA: 0x0029438C File Offset: 0x0029258C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFieldOptions.Descriptor;
			}
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x002943A3 File Offset: 0x002925A3
		[DebuggerNonUserCode]
		public GameAccountFieldOptions()
		{
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x002943B0 File Offset: 0x002925B0
		[DebuggerNonUserCode]
		public GameAccountFieldOptions(GameAccountFieldOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.allFields_ = other.allFields_;
			this.fieldGameLevelInfo_ = other.fieldGameLevelInfo_;
			this.fieldGameTimeInfo_ = other.fieldGameTimeInfo_;
			this.fieldGameStatus_ = other.fieldGameStatus_;
			this.fieldRafInfo_ = other.fieldRafInfo_;
			this.phoneNumber_ = other.phoneNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x0029442C File Offset: 0x0029262C
		[DebuggerNonUserCode]
		public GameAccountFieldOptions Clone()
		{
			return new GameAccountFieldOptions(this);
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x00294444 File Offset: 0x00292644
		// (set) Token: 0x0600A975 RID: 43381 RVA: 0x00294475 File Offset: 0x00292675
		[DebuggerNonUserCode]
		public bool AllFields
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool allFieldsDefaultValue;
				if (flag)
				{
					allFieldsDefaultValue = this.allFields_;
				}
				else
				{
					allFieldsDefaultValue = GameAccountFieldOptions.AllFieldsDefaultValue;
				}
				return allFieldsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.allFields_ = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x00294490 File Offset: 0x00292690
		[DebuggerNonUserCode]
		public bool HasAllFields
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x002944AD File Offset: 0x002926AD
		[DebuggerNonUserCode]
		public void ClearAllFields()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600A978 RID: 43384 RVA: 0x002944C0 File Offset: 0x002926C0
		// (set) Token: 0x0600A979 RID: 43385 RVA: 0x002944F1 File Offset: 0x002926F1
		[DebuggerNonUserCode]
		public bool FieldGameLevelInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool fieldGameLevelInfoDefaultValue;
				if (flag)
				{
					fieldGameLevelInfoDefaultValue = this.fieldGameLevelInfo_;
				}
				else
				{
					fieldGameLevelInfoDefaultValue = GameAccountFieldOptions.FieldGameLevelInfoDefaultValue;
				}
				return fieldGameLevelInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fieldGameLevelInfo_ = value;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600A97A RID: 43386 RVA: 0x0029450C File Offset: 0x0029270C
		[DebuggerNonUserCode]
		public bool HasFieldGameLevelInfo
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x00294529 File Offset: 0x00292729
		[DebuggerNonUserCode]
		public void ClearFieldGameLevelInfo()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600A97C RID: 43388 RVA: 0x0029453C File Offset: 0x0029273C
		// (set) Token: 0x0600A97D RID: 43389 RVA: 0x0029456D File Offset: 0x0029276D
		[DebuggerNonUserCode]
		public bool FieldGameTimeInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool fieldGameTimeInfoDefaultValue;
				if (flag)
				{
					fieldGameTimeInfoDefaultValue = this.fieldGameTimeInfo_;
				}
				else
				{
					fieldGameTimeInfoDefaultValue = GameAccountFieldOptions.FieldGameTimeInfoDefaultValue;
				}
				return fieldGameTimeInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.fieldGameTimeInfo_ = value;
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600A97E RID: 43390 RVA: 0x00294588 File Offset: 0x00292788
		[DebuggerNonUserCode]
		public bool HasFieldGameTimeInfo
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x002945A5 File Offset: 0x002927A5
		[DebuggerNonUserCode]
		public void ClearFieldGameTimeInfo()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600A980 RID: 43392 RVA: 0x002945B8 File Offset: 0x002927B8
		// (set) Token: 0x0600A981 RID: 43393 RVA: 0x002945E9 File Offset: 0x002927E9
		[DebuggerNonUserCode]
		public bool FieldGameStatus
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool fieldGameStatusDefaultValue;
				if (flag)
				{
					fieldGameStatusDefaultValue = this.fieldGameStatus_;
				}
				else
				{
					fieldGameStatusDefaultValue = GameAccountFieldOptions.FieldGameStatusDefaultValue;
				}
				return fieldGameStatusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.fieldGameStatus_ = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600A982 RID: 43394 RVA: 0x00294604 File Offset: 0x00292804
		[DebuggerNonUserCode]
		public bool HasFieldGameStatus
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x00294621 File Offset: 0x00292821
		[DebuggerNonUserCode]
		public void ClearFieldGameStatus()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600A984 RID: 43396 RVA: 0x00294634 File Offset: 0x00292834
		// (set) Token: 0x0600A985 RID: 43397 RVA: 0x00294666 File Offset: 0x00292866
		[DebuggerNonUserCode]
		public bool FieldRafInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool fieldRafInfoDefaultValue;
				if (flag)
				{
					fieldRafInfoDefaultValue = this.fieldRafInfo_;
				}
				else
				{
					fieldRafInfoDefaultValue = GameAccountFieldOptions.FieldRafInfoDefaultValue;
				}
				return fieldRafInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.fieldRafInfo_ = value;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600A986 RID: 43398 RVA: 0x00294680 File Offset: 0x00292880
		[DebuggerNonUserCode]
		public bool HasFieldRafInfo
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x0029469E File Offset: 0x0029289E
		[DebuggerNonUserCode]
		public void ClearFieldRafInfo()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600A988 RID: 43400 RVA: 0x002946B0 File Offset: 0x002928B0
		// (set) Token: 0x0600A989 RID: 43401 RVA: 0x002946D1 File Offset: 0x002928D1
		[DebuggerNonUserCode]
		public string PhoneNumber
		{
			get
			{
				return this.phoneNumber_ ?? GameAccountFieldOptions.PhoneNumberDefaultValue;
			}
			set
			{
				this.phoneNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600A98A RID: 43402 RVA: 0x002946E8 File Offset: 0x002928E8
		[DebuggerNonUserCode]
		public bool HasPhoneNumber
		{
			get
			{
				return this.phoneNumber_ != null;
			}
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x00294703 File Offset: 0x00292903
		[DebuggerNonUserCode]
		public void ClearPhoneNumber()
		{
			this.phoneNumber_ = null;
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x00294710 File Offset: 0x00292910
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFieldOptions);
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x00294730 File Offset: 0x00292930
		[DebuggerNonUserCode]
		public bool Equals(GameAccountFieldOptions other)
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
					bool flag4 = this.AllFields != other.AllFields;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FieldGameLevelInfo != other.FieldGameLevelInfo;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FieldGameTimeInfo != other.FieldGameTimeInfo;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FieldGameStatus != other.FieldGameStatus;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FieldRafInfo != other.FieldRafInfo;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PhoneNumber != other.PhoneNumber;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x0029481C File Offset: 0x00292A1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				num ^= this.AllFields.GetHashCode();
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				num ^= this.FieldGameLevelInfo.GetHashCode();
			}
			bool hasFieldGameTimeInfo = this.HasFieldGameTimeInfo;
			if (hasFieldGameTimeInfo)
			{
				num ^= this.FieldGameTimeInfo.GetHashCode();
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				num ^= this.FieldGameStatus.GetHashCode();
			}
			bool hasFieldRafInfo = this.HasFieldRafInfo;
			if (hasFieldRafInfo)
			{
				num ^= this.FieldRafInfo.GetHashCode();
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num ^= this.PhoneNumber.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x002948FC File Offset: 0x00292AFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x00294914 File Offset: 0x00292B14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00294920 File Offset: 0x00292B20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AllFields);
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.FieldGameLevelInfo);
			}
			bool hasFieldGameTimeInfo = this.HasFieldGameTimeInfo;
			if (hasFieldGameTimeInfo)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FieldGameTimeInfo);
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.FieldGameStatus);
			}
			bool hasFieldRafInfo = this.HasFieldRafInfo;
			if (hasFieldRafInfo)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FieldRafInfo);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x00294A20 File Offset: 0x00292C20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				num += 2;
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				num += 2;
			}
			bool hasFieldGameTimeInfo = this.HasFieldGameTimeInfo;
			if (hasFieldGameTimeInfo)
			{
				num += 2;
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				num += 2;
			}
			bool hasFieldRafInfo = this.HasFieldRafInfo;
			if (hasFieldRafInfo)
			{
				num += 2;
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x00294AC8 File Offset: 0x00292CC8
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountFieldOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAllFields = other.HasAllFields;
				if (hasAllFields)
				{
					this.AllFields = other.AllFields;
				}
				bool hasFieldGameLevelInfo = other.HasFieldGameLevelInfo;
				if (hasFieldGameLevelInfo)
				{
					this.FieldGameLevelInfo = other.FieldGameLevelInfo;
				}
				bool hasFieldGameTimeInfo = other.HasFieldGameTimeInfo;
				if (hasFieldGameTimeInfo)
				{
					this.FieldGameTimeInfo = other.FieldGameTimeInfo;
				}
				bool hasFieldGameStatus = other.HasFieldGameStatus;
				if (hasFieldGameStatus)
				{
					this.FieldGameStatus = other.FieldGameStatus;
				}
				bool hasFieldRafInfo = other.HasFieldRafInfo;
				if (hasFieldRafInfo)
				{
					this.FieldRafInfo = other.FieldRafInfo;
				}
				bool hasPhoneNumber = other.HasPhoneNumber;
				if (hasPhoneNumber)
				{
					this.PhoneNumber = other.PhoneNumber;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x00294B97 File Offset: 0x00292D97
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x00294BA4 File Offset: 0x00292DA4
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_003C;
							}
							this.FieldGameTimeInfo = input.ReadBool();
						}
						else
						{
							this.FieldGameLevelInfo = input.ReadBool();
						}
					}
					else
					{
						this.AllFields = input.ReadBool();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 154U)
						{
							goto IL_003C;
						}
						this.PhoneNumber = input.ReadString();
					}
					else
					{
						this.FieldRafInfo = input.ReadBool();
					}
				}
				else
				{
					this.FieldGameStatus = input.ReadBool();
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C2F RID: 19503
		private static readonly MessageParser<GameAccountFieldOptions> _parser = new MessageParser<GameAccountFieldOptions>(() => new GameAccountFieldOptions());

		// Token: 0x04004C30 RID: 19504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C31 RID: 19505
		private int _hasBits0;

		// Token: 0x04004C32 RID: 19506
		public const int AllFieldsFieldNumber = 1;

		// Token: 0x04004C33 RID: 19507
		private static readonly bool AllFieldsDefaultValue = false;

		// Token: 0x04004C34 RID: 19508
		private bool allFields_;

		// Token: 0x04004C35 RID: 19509
		public const int FieldGameLevelInfoFieldNumber = 2;

		// Token: 0x04004C36 RID: 19510
		private static readonly bool FieldGameLevelInfoDefaultValue = false;

		// Token: 0x04004C37 RID: 19511
		private bool fieldGameLevelInfo_;

		// Token: 0x04004C38 RID: 19512
		public const int FieldGameTimeInfoFieldNumber = 3;

		// Token: 0x04004C39 RID: 19513
		private static readonly bool FieldGameTimeInfoDefaultValue = false;

		// Token: 0x04004C3A RID: 19514
		private bool fieldGameTimeInfo_;

		// Token: 0x04004C3B RID: 19515
		public const int FieldGameStatusFieldNumber = 4;

		// Token: 0x04004C3C RID: 19516
		private static readonly bool FieldGameStatusDefaultValue = false;

		// Token: 0x04004C3D RID: 19517
		private bool fieldGameStatus_;

		// Token: 0x04004C3E RID: 19518
		public const int FieldRafInfoFieldNumber = 5;

		// Token: 0x04004C3F RID: 19519
		private static readonly bool FieldRafInfoDefaultValue = false;

		// Token: 0x04004C40 RID: 19520
		private bool fieldRafInfo_;

		// Token: 0x04004C41 RID: 19521
		public const int PhoneNumberFieldNumber = 19;

		// Token: 0x04004C42 RID: 19522
		private static readonly string PhoneNumberDefaultValue = "";

		// Token: 0x04004C43 RID: 19523
		private string phoneNumber_;
	}
}
