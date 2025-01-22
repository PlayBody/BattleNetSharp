using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E0 RID: 480
	public sealed class DebugCombatStatDetail : IMessage<DebugCombatStatDetail>, IMessage, IEquatable<DebugCombatStatDetail>, IDeepCloneable<DebugCombatStatDetail>, IBufferMessage
	{
		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x000CDE10 File Offset: 0x000CC010
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatStatDetail> Parser
		{
			get
			{
				return DebugCombatStatDetail._parser;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x000CDE28 File Offset: 0x000CC028
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[37];
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x000CDE4C File Offset: 0x000CC04C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatStatDetail.Descriptor;
			}
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x000CDE63 File Offset: 0x000CC063
		[DebuggerNonUserCode]
		public DebugCombatStatDetail()
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000CDE70 File Offset: 0x000CC070
		[DebuggerNonUserCode]
		public DebugCombatStatDetail(DebugCombatStatDetail other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.value_ = other.value_;
			this.forceEffect_ = other.forceEffect_;
			this.newRepresentation_ = other.newRepresentation_;
			this.operation_ = other.operation_;
			this.reason_ = ((other.reason_ != null) ? other.reason_.Clone() : null);
			this.tooltip_ = other.tooltip_;
			this.valueResult_ = other.valueResult_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000CDF08 File Offset: 0x000CC108
		[DebuggerNonUserCode]
		public DebugCombatStatDetail Clone()
		{
			return new DebugCombatStatDetail(this);
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x000CDF20 File Offset: 0x000CC120
		// (set) Token: 0x06003408 RID: 13320 RVA: 0x000CDF51 File Offset: 0x000CC151
		[DebuggerNonUserCode]
		public float Value
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = DebugCombatStatDetail.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.value_ = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x000CDF6C File Offset: 0x000CC16C
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000CDF89 File Offset: 0x000CC189
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x000CDF9C File Offset: 0x000CC19C
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x000CDFCD File Offset: 0x000CC1CD
		[DebuggerNonUserCode]
		public bool ForceEffect
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool forceEffectDefaultValue;
				if (flag)
				{
					forceEffectDefaultValue = this.forceEffect_;
				}
				else
				{
					forceEffectDefaultValue = DebugCombatStatDetail.ForceEffectDefaultValue;
				}
				return forceEffectDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.forceEffect_ = value;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x000CDFE8 File Offset: 0x000CC1E8
		[DebuggerNonUserCode]
		public bool HasForceEffect
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x000CE005 File Offset: 0x000CC205
		[DebuggerNonUserCode]
		public void ClearForceEffect()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x000CE018 File Offset: 0x000CC218
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x000CE049 File Offset: 0x000CC249
		[DebuggerNonUserCode]
		public int NewRepresentation
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int newRepresentationDefaultValue;
				if (flag)
				{
					newRepresentationDefaultValue = this.newRepresentation_;
				}
				else
				{
					newRepresentationDefaultValue = DebugCombatStatDetail.NewRepresentationDefaultValue;
				}
				return newRepresentationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.newRepresentation_ = value;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x000CE064 File Offset: 0x000CC264
		[DebuggerNonUserCode]
		public bool HasNewRepresentation
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000CE081 File Offset: 0x000CC281
		[DebuggerNonUserCode]
		public void ClearNewRepresentation()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x000CE094 File Offset: 0x000CC294
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x000CE0C5 File Offset: 0x000CC2C5
		[DebuggerNonUserCode]
		public int Operation
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int operationDefaultValue;
				if (flag)
				{
					operationDefaultValue = this.operation_;
				}
				else
				{
					operationDefaultValue = DebugCombatStatDetail.OperationDefaultValue;
				}
				return operationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.operation_ = value;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x000CE0E0 File Offset: 0x000CC2E0
		[DebuggerNonUserCode]
		public bool HasOperation
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x000CE0FD File Offset: 0x000CC2FD
		[DebuggerNonUserCode]
		public void ClearOperation()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x000CE110 File Offset: 0x000CC310
		// (set) Token: 0x06003418 RID: 13336 RVA: 0x000CE128 File Offset: 0x000CC328
		[DebuggerNonUserCode]
		public DebugCombatStatChangeReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x000CE134 File Offset: 0x000CC334
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x000CE155 File Offset: 0x000CC355
		[DebuggerNonUserCode]
		public string Tooltip
		{
			get
			{
				return this.tooltip_ ?? DebugCombatStatDetail.TooltipDefaultValue;
			}
			set
			{
				this.tooltip_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x000CE16C File Offset: 0x000CC36C
		[DebuggerNonUserCode]
		public bool HasTooltip
		{
			get
			{
				return this.tooltip_ != null;
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000CE187 File Offset: 0x000CC387
		[DebuggerNonUserCode]
		public void ClearTooltip()
		{
			this.tooltip_ = null;
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x000CE194 File Offset: 0x000CC394
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x000CE1C6 File Offset: 0x000CC3C6
		[DebuggerNonUserCode]
		public float ValueResult
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float valueResultDefaultValue;
				if (flag)
				{
					valueResultDefaultValue = this.valueResult_;
				}
				else
				{
					valueResultDefaultValue = DebugCombatStatDetail.ValueResultDefaultValue;
				}
				return valueResultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.valueResult_ = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x000CE1E0 File Offset: 0x000CC3E0
		[DebuggerNonUserCode]
		public bool HasValueResult
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000CE1FE File Offset: 0x000CC3FE
		[DebuggerNonUserCode]
		public void ClearValueResult()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000CE210 File Offset: 0x000CC410
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatStatDetail);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000CE230 File Offset: 0x000CC430
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatStatDetail other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Value, other.Value);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ForceEffect != other.ForceEffect;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NewRepresentation != other.NewRepresentation;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Operation != other.Operation;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Reason, other.Reason);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Tooltip != other.Tooltip;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ValueResult, other.ValueResult);
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

		// Token: 0x06003423 RID: 13347 RVA: 0x000CE34C File Offset: 0x000CC54C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Value);
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				num ^= this.ForceEffect.GetHashCode();
			}
			bool hasNewRepresentation = this.HasNewRepresentation;
			if (hasNewRepresentation)
			{
				num ^= this.NewRepresentation.GetHashCode();
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num ^= this.Operation.GetHashCode();
			}
			bool flag = this.reason_ != null;
			if (flag)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasTooltip = this.HasTooltip;
			if (hasTooltip)
			{
				num ^= this.Tooltip.GetHashCode();
			}
			bool hasValueResult = this.HasValueResult;
			if (hasValueResult)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ValueResult);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000CE44C File Offset: 0x000CC64C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000CE464 File Offset: 0x000CC664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000CE470 File Offset: 0x000CC670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Value);
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ForceEffect);
			}
			bool hasNewRepresentation = this.HasNewRepresentation;
			if (hasNewRepresentation)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NewRepresentation);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Operation);
			}
			bool flag = this.reason_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reason);
			}
			bool hasTooltip = this.HasTooltip;
			if (hasTooltip)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Tooltip);
			}
			bool hasValueResult = this.HasValueResult;
			if (hasValueResult)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.ValueResult);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000CE594 File Offset: 0x000CC794
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 5;
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				num += 2;
			}
			bool hasNewRepresentation = this.HasNewRepresentation;
			if (hasNewRepresentation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewRepresentation);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operation);
			}
			bool flag = this.reason_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reason);
			}
			bool hasTooltip = this.HasTooltip;
			if (hasTooltip)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Tooltip);
			}
			bool hasValueResult = this.HasValueResult;
			if (hasValueResult)
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

		// Token: 0x06003428 RID: 13352 RVA: 0x000CE678 File Offset: 0x000CC878
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatStatDetail other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				bool hasForceEffect = other.HasForceEffect;
				if (hasForceEffect)
				{
					this.ForceEffect = other.ForceEffect;
				}
				bool hasNewRepresentation = other.HasNewRepresentation;
				if (hasNewRepresentation)
				{
					this.NewRepresentation = other.NewRepresentation;
				}
				bool hasOperation = other.HasOperation;
				if (hasOperation)
				{
					this.Operation = other.Operation;
				}
				bool flag2 = other.reason_ != null;
				if (flag2)
				{
					bool flag3 = this.reason_ == null;
					if (flag3)
					{
						this.Reason = new DebugCombatStatChangeReason();
					}
					this.Reason.MergeFrom(other.Reason);
				}
				bool hasTooltip = other.HasTooltip;
				if (hasTooltip)
				{
					this.Tooltip = other.Tooltip;
				}
				bool hasValueResult = other.HasValueResult;
				if (hasValueResult)
				{
					this.ValueResult = other.ValueResult;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000CE787 File Offset: 0x000CC987
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000CE794 File Offset: 0x000CC994
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
					if (num3 != 13U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_004C;
							}
							this.NewRepresentation = input.ReadInt32();
						}
						else
						{
							this.ForceEffect = input.ReadBool();
						}
					}
					else
					{
						this.Value = input.ReadFloat();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_004C;
						}
						bool flag = this.reason_ == null;
						if (flag)
						{
							this.Reason = new DebugCombatStatChangeReason();
						}
						input.ReadMessage(this.Reason);
					}
					else
					{
						this.Operation = input.ReadInt32();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 61U)
					{
						goto IL_004C;
					}
					this.ValueResult = input.ReadFloat();
				}
				else
				{
					this.Tooltip = input.ReadString();
				}
				continue;
				IL_004C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001808 RID: 6152
		private static readonly MessageParser<DebugCombatStatDetail> _parser = new MessageParser<DebugCombatStatDetail>(() => new DebugCombatStatDetail());

		// Token: 0x04001809 RID: 6153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400180A RID: 6154
		private int _hasBits0;

		// Token: 0x0400180B RID: 6155
		public const int ValueFieldNumber = 1;

		// Token: 0x0400180C RID: 6156
		private static readonly float ValueDefaultValue = 0f;

		// Token: 0x0400180D RID: 6157
		private float value_;

		// Token: 0x0400180E RID: 6158
		public const int ForceEffectFieldNumber = 2;

		// Token: 0x0400180F RID: 6159
		private static readonly bool ForceEffectDefaultValue = false;

		// Token: 0x04001810 RID: 6160
		private bool forceEffect_;

		// Token: 0x04001811 RID: 6161
		public const int NewRepresentationFieldNumber = 3;

		// Token: 0x04001812 RID: 6162
		private static readonly int NewRepresentationDefaultValue = 0;

		// Token: 0x04001813 RID: 6163
		private int newRepresentation_;

		// Token: 0x04001814 RID: 6164
		public const int OperationFieldNumber = 4;

		// Token: 0x04001815 RID: 6165
		private static readonly int OperationDefaultValue = 0;

		// Token: 0x04001816 RID: 6166
		private int operation_;

		// Token: 0x04001817 RID: 6167
		public const int ReasonFieldNumber = 5;

		// Token: 0x04001818 RID: 6168
		private DebugCombatStatChangeReason reason_;

		// Token: 0x04001819 RID: 6169
		public const int TooltipFieldNumber = 6;

		// Token: 0x0400181A RID: 6170
		private static readonly string TooltipDefaultValue = "";

		// Token: 0x0400181B RID: 6171
		private string tooltip_;

		// Token: 0x0400181C RID: 6172
		public const int ValueResultFieldNumber = 7;

		// Token: 0x0400181D RID: 6173
		private static readonly float ValueResultDefaultValue = 0f;

		// Token: 0x0400181E RID: 6174
		private float valueResult_;
	}
}
