using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E9 RID: 489
	public sealed class DebugCombatLogFortifiedEvent : IMessage<DebugCombatLogFortifiedEvent>, IMessage, IEquatable<DebugCombatLogFortifiedEvent>, IDeepCloneable<DebugCombatLogFortifiedEvent>, IBufferMessage
	{
		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x000D2118 File Offset: 0x000D0318
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogFortifiedEvent> Parser
		{
			get
			{
				return DebugCombatLogFortifiedEvent._parser;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x000D2130 File Offset: 0x000D0330
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[46];
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x000D2154 File Offset: 0x000D0354
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogFortifiedEvent.Descriptor;
			}
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x000D216B File Offset: 0x000D036B
		[DebuggerNonUserCode]
		public DebugCombatLogFortifiedEvent()
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000D2175 File Offset: 0x000D0375
		[DebuggerNonUserCode]
		public DebugCombatLogFortifiedEvent(DebugCombatLogFortifiedEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.fortifiedHealthApplied_ = other.fortifiedHealthApplied_;
			this.fortifiedHealthPostApply_ = other.fortifiedHealthPostApply_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x000D21B4 File Offset: 0x000D03B4
		[DebuggerNonUserCode]
		public DebugCombatLogFortifiedEvent Clone()
		{
			return new DebugCombatLogFortifiedEvent(this);
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000D21CC File Offset: 0x000D03CC
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x000D21FD File Offset: 0x000D03FD
		[DebuggerNonUserCode]
		public float FortifiedHealthApplied
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float fortifiedHealthAppliedDefaultValue;
				if (flag)
				{
					fortifiedHealthAppliedDefaultValue = this.fortifiedHealthApplied_;
				}
				else
				{
					fortifiedHealthAppliedDefaultValue = DebugCombatLogFortifiedEvent.FortifiedHealthAppliedDefaultValue;
				}
				return fortifiedHealthAppliedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fortifiedHealthApplied_ = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000D2218 File Offset: 0x000D0418
		[DebuggerNonUserCode]
		public bool HasFortifiedHealthApplied
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x000D2235 File Offset: 0x000D0435
		[DebuggerNonUserCode]
		public void ClearFortifiedHealthApplied()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x000D2248 File Offset: 0x000D0448
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x000D2279 File Offset: 0x000D0479
		[DebuggerNonUserCode]
		public float FortifiedHealthPostApply
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float fortifiedHealthPostApplyDefaultValue;
				if (flag)
				{
					fortifiedHealthPostApplyDefaultValue = this.fortifiedHealthPostApply_;
				}
				else
				{
					fortifiedHealthPostApplyDefaultValue = DebugCombatLogFortifiedEvent.FortifiedHealthPostApplyDefaultValue;
				}
				return fortifiedHealthPostApplyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fortifiedHealthPostApply_ = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x000D2294 File Offset: 0x000D0494
		[DebuggerNonUserCode]
		public bool HasFortifiedHealthPostApply
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000D22B1 File Offset: 0x000D04B1
		[DebuggerNonUserCode]
		public void ClearFortifiedHealthPostApply()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000D22C4 File Offset: 0x000D04C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogFortifiedEvent);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000D22E4 File Offset: 0x000D04E4
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogFortifiedEvent other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FortifiedHealthApplied, other.FortifiedHealthApplied);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FortifiedHealthPostApply, other.FortifiedHealthPostApply);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000D2368 File Offset: 0x000D0568
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFortifiedHealthApplied = this.HasFortifiedHealthApplied;
			if (hasFortifiedHealthApplied)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FortifiedHealthApplied);
			}
			bool hasFortifiedHealthPostApply = this.HasFortifiedHealthPostApply;
			if (hasFortifiedHealthPostApply)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FortifiedHealthPostApply);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000D23D8 File Offset: 0x000D05D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000D23F0 File Offset: 0x000D05F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x000D23FC File Offset: 0x000D05FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFortifiedHealthApplied = this.HasFortifiedHealthApplied;
			if (hasFortifiedHealthApplied)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.FortifiedHealthApplied);
			}
			bool hasFortifiedHealthPostApply = this.HasFortifiedHealthPostApply;
			if (hasFortifiedHealthPostApply)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.FortifiedHealthPostApply);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000D246C File Offset: 0x000D066C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFortifiedHealthApplied = this.HasFortifiedHealthApplied;
			if (hasFortifiedHealthApplied)
			{
				num += 5;
			}
			bool hasFortifiedHealthPostApply = this.HasFortifiedHealthPostApply;
			if (hasFortifiedHealthPostApply)
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

		// Token: 0x0600353C RID: 13628 RVA: 0x000D24C0 File Offset: 0x000D06C0
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogFortifiedEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFortifiedHealthApplied = other.HasFortifiedHealthApplied;
				if (hasFortifiedHealthApplied)
				{
					this.FortifiedHealthApplied = other.FortifiedHealthApplied;
				}
				bool hasFortifiedHealthPostApply = other.HasFortifiedHealthPostApply;
				if (hasFortifiedHealthPostApply)
				{
					this.FortifiedHealthPostApply = other.FortifiedHealthPostApply;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000D2522 File Offset: 0x000D0722
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000D2530 File Offset: 0x000D0730
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FortifiedHealthPostApply = input.ReadFloat();
					}
				}
				else
				{
					this.FortifiedHealthApplied = input.ReadFloat();
				}
			}
		}

		// Token: 0x04001899 RID: 6297
		private static readonly MessageParser<DebugCombatLogFortifiedEvent> _parser = new MessageParser<DebugCombatLogFortifiedEvent>(() => new DebugCombatLogFortifiedEvent());

		// Token: 0x0400189A RID: 6298
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400189B RID: 6299
		private int _hasBits0;

		// Token: 0x0400189C RID: 6300
		public const int FortifiedHealthAppliedFieldNumber = 1;

		// Token: 0x0400189D RID: 6301
		private static readonly float FortifiedHealthAppliedDefaultValue = 0f;

		// Token: 0x0400189E RID: 6302
		private float fortifiedHealthApplied_;

		// Token: 0x0400189F RID: 6303
		public const int FortifiedHealthPostApplyFieldNumber = 2;

		// Token: 0x040018A0 RID: 6304
		private static readonly float FortifiedHealthPostApplyDefaultValue = 0f;

		// Token: 0x040018A1 RID: 6305
		private float fortifiedHealthPostApply_;
	}
}
