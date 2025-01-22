using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E7 RID: 487
	public sealed class DebugCombatLogStackEvent : IMessage<DebugCombatLogStackEvent>, IMessage, IEquatable<DebugCombatLogStackEvent>, IDeepCloneable<DebugCombatLogStackEvent>, IBufferMessage
	{
		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x000D1848 File Offset: 0x000CFA48
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogStackEvent> Parser
		{
			get
			{
				return DebugCombatLogStackEvent._parser;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x000D1860 File Offset: 0x000CFA60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[44];
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x000D1884 File Offset: 0x000CFA84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogStackEvent.Descriptor;
			}
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000D189B File Offset: 0x000CFA9B
		[DebuggerNonUserCode]
		public DebugCombatLogStackEvent()
		{
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000D18B0 File Offset: 0x000CFAB0
		[DebuggerNonUserCode]
		public DebugCombatLogStackEvent(DebugCombatLogStackEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.powerStartPower_ = other.powerStartPower_;
			this.stackData_ = other.stackData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000D1900 File Offset: 0x000CFB00
		[DebuggerNonUserCode]
		public DebugCombatLogStackEvent Clone()
		{
			return new DebugCombatLogStackEvent(this);
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x000D1918 File Offset: 0x000CFB18
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x000D1949 File Offset: 0x000CFB49
		[DebuggerNonUserCode]
		public bool PowerStartPower
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool powerStartPowerDefaultValue;
				if (flag)
				{
					powerStartPowerDefaultValue = this.powerStartPower_;
				}
				else
				{
					powerStartPowerDefaultValue = DebugCombatLogStackEvent.PowerStartPowerDefaultValue;
				}
				return powerStartPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.powerStartPower_ = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x000D1964 File Offset: 0x000CFB64
		[DebuggerNonUserCode]
		public bool HasPowerStartPower
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000D1981 File Offset: 0x000CFB81
		[DebuggerNonUserCode]
		public void ClearPowerStartPower()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x000D1994 File Offset: 0x000CFB94
		[DebuggerNonUserCode]
		public RepeatedField<DebugCombatLogStackData> StackData
		{
			get
			{
				return this.stackData_;
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000D19AC File Offset: 0x000CFBAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogStackEvent);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000D19CC File Offset: 0x000CFBCC
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogStackEvent other)
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
					bool flag4 = this.PowerStartPower != other.PowerStartPower;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.stackData_.Equals(other.stackData_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x000D1A40 File Offset: 0x000CFC40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPowerStartPower = this.HasPowerStartPower;
			if (hasPowerStartPower)
			{
				num ^= this.PowerStartPower.GetHashCode();
			}
			num ^= this.stackData_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000D1AA0 File Offset: 0x000CFCA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x000D1AB8 File Offset: 0x000CFCB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x000D1AC4 File Offset: 0x000CFCC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPowerStartPower = this.HasPowerStartPower;
			if (hasPowerStartPower)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.PowerStartPower);
			}
			this.stackData_.WriteTo(ref output, DebugCombatLogStackEvent._repeated_stackData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x000D1B24 File Offset: 0x000CFD24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPowerStartPower = this.HasPowerStartPower;
			if (hasPowerStartPower)
			{
				num += 2;
			}
			num += this.stackData_.CalculateSize(DebugCombatLogStackEvent._repeated_stackData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x000D1B7C File Offset: 0x000CFD7C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogStackEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPowerStartPower = other.HasPowerStartPower;
				if (hasPowerStartPower)
				{
					this.PowerStartPower = other.PowerStartPower;
				}
				this.stackData_.Add(other.stackData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x000D1BD7 File Offset: 0x000CFDD7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x000D1BE4 File Offset: 0x000CFDE4
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.stackData_.AddEntriesFrom(ref input, DebugCombatLogStackEvent._repeated_stackData_codec);
					}
				}
				else
				{
					this.PowerStartPower = input.ReadBool();
				}
			}
		}

		// Token: 0x04001887 RID: 6279
		private static readonly MessageParser<DebugCombatLogStackEvent> _parser = new MessageParser<DebugCombatLogStackEvent>(() => new DebugCombatLogStackEvent());

		// Token: 0x04001888 RID: 6280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001889 RID: 6281
		private int _hasBits0;

		// Token: 0x0400188A RID: 6282
		public const int PowerStartPowerFieldNumber = 1;

		// Token: 0x0400188B RID: 6283
		private static readonly bool PowerStartPowerDefaultValue = false;

		// Token: 0x0400188C RID: 6284
		private bool powerStartPower_;

		// Token: 0x0400188D RID: 6285
		public const int StackDataFieldNumber = 2;

		// Token: 0x0400188E RID: 6286
		private static readonly FieldCodec<DebugCombatLogStackData> _repeated_stackData_codec = FieldCodec.ForMessage<DebugCombatLogStackData>(18U, DebugCombatLogStackData.Parser);

		// Token: 0x0400188F RID: 6287
		private readonly RepeatedField<DebugCombatLogStackData> stackData_ = new RepeatedField<DebugCombatLogStackData>();
	}
}
