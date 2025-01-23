using System;
using System.Diagnostics;
using Bgs.Protocol.Channel.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005B1 RID: 1457
	public sealed class ChannelState : IMessage<ChannelState>, IMessage, IEquatable<ChannelState>, IDeepCloneable<ChannelState>, IBufferMessage
	{
		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06008A7E RID: 35454 RVA: 0x0021A0B4 File Offset: 0x002182B4
		[DebuggerNonUserCode]
		public static MessageParser<ChannelState> Parser
		{
			get
			{
				return ChannelState._parser;
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x0021A0CC File Offset: 0x002182CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06008A80 RID: 35456 RVA: 0x0021A0F0 File Offset: 0x002182F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelState.Descriptor;
			}
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x0021A107 File Offset: 0x00218307
		[DebuggerNonUserCode]
		public ChannelState()
		{
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x0021A11C File Offset: 0x0021831C
		[DebuggerNonUserCode]
		public ChannelState(ChannelState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.fieldOperation_ = other.fieldOperation_.Clone();
			this.healing_ = other.healing_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x0021A188 File Offset: 0x00218388
		[DebuggerNonUserCode]
		public ChannelState Clone()
		{
			return new ChannelState(this);
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06008A84 RID: 35460 RVA: 0x0021A1A0 File Offset: 0x002183A0
		// (set) Token: 0x06008A85 RID: 35461 RVA: 0x0021A1B8 File Offset: 0x002183B8
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06008A86 RID: 35462 RVA: 0x0021A1C4 File Offset: 0x002183C4
		[DebuggerNonUserCode]
		public RepeatedField<FieldOperation> FieldOperation
		{
			get
			{
				return this.fieldOperation_;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x0021A1DC File Offset: 0x002183DC
		// (set) Token: 0x06008A88 RID: 35464 RVA: 0x0021A20D File Offset: 0x0021840D
		[DebuggerNonUserCode]
		public bool Healing
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool healingDefaultValue;
				if (flag)
				{
					healingDefaultValue = this.healing_;
				}
				else
				{
					healingDefaultValue = ChannelState.HealingDefaultValue;
				}
				return healingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.healing_ = value;
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x0021A228 File Offset: 0x00218428
		[DebuggerNonUserCode]
		public bool HasHealing
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x0021A245 File Offset: 0x00218445
		[DebuggerNonUserCode]
		public void ClearHealing()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x0021A258 File Offset: 0x00218458
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelState);
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0021A278 File Offset: 0x00218478
		[DebuggerNonUserCode]
		public bool Equals(ChannelState other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.fieldOperation_.Equals(other.fieldOperation_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Healing != other.Healing;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0021A30C File Offset: 0x0021850C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.fieldOperation_.GetHashCode();
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				num ^= this.Healing.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0021A388 File Offset: 0x00218588
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x0021A3A0 File Offset: 0x002185A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0021A3AC File Offset: 0x002185AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			this.fieldOperation_.WriteTo(ref output, ChannelState._repeated_fieldOperation_codec);
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Healing);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0021A430 File Offset: 0x00218630
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			num += this.fieldOperation_.CalculateSize(ChannelState._repeated_fieldOperation_codec);
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0021A4A8 File Offset: 0x002186A8
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				this.fieldOperation_.Add(other.fieldOperation_);
				bool hasHealing = other.HasHealing;
				if (hasHealing)
				{
					this.Healing = other.Healing;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x0021A53F File Offset: 0x0021873F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x0021A54C File Offset: 0x0021874C
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Healing = input.ReadBool();
						}
					}
					else
					{
						this.fieldOperation_.AddEntriesFrom(ref input, ChannelState._repeated_fieldOperation_codec);
					}
				}
				else
				{
					bool flag = this.entityId_ == null;
					if (flag)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04003EAF RID: 16047
		private static readonly MessageParser<ChannelState> _parser = new MessageParser<ChannelState>(() => new ChannelState());

		// Token: 0x04003EB0 RID: 16048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EB1 RID: 16049
		private int _hasBits0;

		// Token: 0x04003EB2 RID: 16050
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003EB3 RID: 16051
		private EntityId entityId_;

		// Token: 0x04003EB4 RID: 16052
		public const int FieldOperationFieldNumber = 2;

		// Token: 0x04003EB5 RID: 16053
		private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18U, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

		// Token: 0x04003EB6 RID: 16054
		private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();

		// Token: 0x04003EB7 RID: 16055
		public const int HealingFieldNumber = 3;

		// Token: 0x04003EB8 RID: 16056
		private static readonly bool HealingDefaultValue = false;

		// Token: 0x04003EB9 RID: 16057
		private bool healing_;

		// Token: 0x0200108F RID: 4239
		[DebuggerNonUserCode]
		public static class Extensions
		{
			// Token: 0x040097DD RID: 38877
			public static readonly Extension<Bgs.Protocol.Channel.V1.ChannelState, ChannelState> Presence = new Extension<Bgs.Protocol.Channel.V1.ChannelState, ChannelState>(101, FieldCodec.ForMessage<ChannelState>(810U, ChannelState.Parser));
		}
	}
}
