using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D2 RID: 466
	public sealed class AIDebugVariable : IMessage<AIDebugVariable>, IMessage, IEquatable<AIDebugVariable>, IDeepCloneable<AIDebugVariable>, IBufferMessage
	{
		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x000C58CC File Offset: 0x000C3ACC
		[DebuggerNonUserCode]
		public static MessageParser<AIDebugVariable> Parser
		{
			get
			{
				return AIDebugVariable._parser;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x000C58E4 File Offset: 0x000C3AE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x000C5908 File Offset: 0x000C3B08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIDebugVariable.Descriptor;
			}
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000C591F File Offset: 0x000C3B1F
		[DebuggerNonUserCode]
		public AIDebugVariable()
		{
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000C592C File Offset: 0x000C3B2C
		[DebuggerNonUserCode]
		public AIDebugVariable(AIDebugVariable other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.nameHash_ = other.nameHash_;
			this.value_ = other.value_;
			this.ticksUntilExpiration_ = other.ticksUntilExpiration_;
			this.sourceAibehaviorSno_ = other.sourceAibehaviorSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000C599C File Offset: 0x000C3B9C
		[DebuggerNonUserCode]
		public AIDebugVariable Clone()
		{
			return new AIDebugVariable(this);
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000C59B4 File Offset: 0x000C3BB4
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x000C59D5 File Offset: 0x000C3BD5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? AIDebugVariable.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x000C59EC File Offset: 0x000C3BEC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000C5A07 File Offset: 0x000C3C07
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x000C5A14 File Offset: 0x000C3C14
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x000C5A45 File Offset: 0x000C3C45
		[DebuggerNonUserCode]
		public uint NameHash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint nameHashDefaultValue;
				if (flag)
				{
					nameHashDefaultValue = this.nameHash_;
				}
				else
				{
					nameHashDefaultValue = AIDebugVariable.NameHashDefaultValue;
				}
				return nameHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.nameHash_ = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x000C5A60 File Offset: 0x000C3C60
		[DebuggerNonUserCode]
		public bool HasNameHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000C5A7D File Offset: 0x000C3C7D
		[DebuggerNonUserCode]
		public void ClearNameHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x000C5A90 File Offset: 0x000C3C90
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x000C5AC1 File Offset: 0x000C3CC1
		[DebuggerNonUserCode]
		public float Value
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = AIDebugVariable.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.value_ = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x000C5ADC File Offset: 0x000C3CDC
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000C5AF9 File Offset: 0x000C3CF9
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x000C5B0C File Offset: 0x000C3D0C
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x000C5B3D File Offset: 0x000C3D3D
		[DebuggerNonUserCode]
		public uint TicksUntilExpiration
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint ticksUntilExpirationDefaultValue;
				if (flag)
				{
					ticksUntilExpirationDefaultValue = this.ticksUntilExpiration_;
				}
				else
				{
					ticksUntilExpirationDefaultValue = AIDebugVariable.TicksUntilExpirationDefaultValue;
				}
				return ticksUntilExpirationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.ticksUntilExpiration_ = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x000C5B58 File Offset: 0x000C3D58
		[DebuggerNonUserCode]
		public bool HasTicksUntilExpiration
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000C5B75 File Offset: 0x000C3D75
		[DebuggerNonUserCode]
		public void ClearTicksUntilExpiration()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x000C5B88 File Offset: 0x000C3D88
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x000C5BB9 File Offset: 0x000C3DB9
		[DebuggerNonUserCode]
		public int SourceAibehaviorSno
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int sourceAibehaviorSnoDefaultValue;
				if (flag)
				{
					sourceAibehaviorSnoDefaultValue = this.sourceAibehaviorSno_;
				}
				else
				{
					sourceAibehaviorSnoDefaultValue = AIDebugVariable.SourceAibehaviorSnoDefaultValue;
				}
				return sourceAibehaviorSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.sourceAibehaviorSno_ = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x000C5BD4 File Offset: 0x000C3DD4
		[DebuggerNonUserCode]
		public bool HasSourceAibehaviorSno
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000C5BF1 File Offset: 0x000C3DF1
		[DebuggerNonUserCode]
		public void ClearSourceAibehaviorSno()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000C5C04 File Offset: 0x000C3E04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIDebugVariable);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000C5C24 File Offset: 0x000C3E24
		[DebuggerNonUserCode]
		public bool Equals(AIDebugVariable other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.NameHash != other.NameHash;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Value, other.Value);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TicksUntilExpiration != other.TicksUntilExpiration;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SourceAibehaviorSno != other.SourceAibehaviorSno;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000C5CF8 File Offset: 0x000C3EF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasNameHash = this.HasNameHash;
			if (hasNameHash)
			{
				num ^= this.NameHash.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Value);
			}
			bool hasTicksUntilExpiration = this.HasTicksUntilExpiration;
			if (hasTicksUntilExpiration)
			{
				num ^= this.TicksUntilExpiration.GetHashCode();
			}
			bool hasSourceAibehaviorSno = this.HasSourceAibehaviorSno;
			if (hasSourceAibehaviorSno)
			{
				num ^= this.SourceAibehaviorSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000C5DBC File Offset: 0x000C3FBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000C5DD4 File Offset: 0x000C3FD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000C5DE0 File Offset: 0x000C3FE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasNameHash = this.HasNameHash;
			if (hasNameHash)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NameHash);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Value);
			}
			bool hasTicksUntilExpiration = this.HasTicksUntilExpiration;
			if (hasTicksUntilExpiration)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TicksUntilExpiration);
			}
			bool hasSourceAibehaviorSno = this.HasSourceAibehaviorSno;
			if (hasSourceAibehaviorSno)
			{
				output.WriteRawTag(45);
				output.WriteSFixed32(this.SourceAibehaviorSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x000C5EB8 File Offset: 0x000C40B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasNameHash = this.HasNameHash;
			if (hasNameHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NameHash);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 5;
			}
			bool hasTicksUntilExpiration = this.HasTicksUntilExpiration;
			if (hasTicksUntilExpiration)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TicksUntilExpiration);
			}
			bool hasSourceAibehaviorSno = this.HasSourceAibehaviorSno;
			if (hasSourceAibehaviorSno)
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

		// Token: 0x0600320B RID: 12811 RVA: 0x000C5F68 File Offset: 0x000C4168
		[DebuggerNonUserCode]
		public void MergeFrom(AIDebugVariable other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasNameHash = other.HasNameHash;
				if (hasNameHash)
				{
					this.NameHash = other.NameHash;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				bool hasTicksUntilExpiration = other.HasTicksUntilExpiration;
				if (hasTicksUntilExpiration)
				{
					this.TicksUntilExpiration = other.TicksUntilExpiration;
				}
				bool hasSourceAibehaviorSno = other.HasSourceAibehaviorSno;
				if (hasSourceAibehaviorSno)
				{
					this.SourceAibehaviorSno = other.SourceAibehaviorSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x000C601C File Offset: 0x000C421C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000C6028 File Offset: 0x000C4228
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.NameHash = input.ReadUInt32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						if (num3 != 45U)
						{
							goto IL_0033;
						}
						this.SourceAibehaviorSno = input.ReadSFixed32();
					}
					else
					{
						this.TicksUntilExpiration = input.ReadUInt32();
					}
				}
				else
				{
					this.Value = input.ReadFloat();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040016E5 RID: 5861
		private static readonly MessageParser<AIDebugVariable> _parser = new MessageParser<AIDebugVariable>(() => new AIDebugVariable());

		// Token: 0x040016E6 RID: 5862
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016E7 RID: 5863
		private int _hasBits0;

		// Token: 0x040016E8 RID: 5864
		public const int NameFieldNumber = 1;

		// Token: 0x040016E9 RID: 5865
		private static readonly string NameDefaultValue = "";

		// Token: 0x040016EA RID: 5866
		private string name_;

		// Token: 0x040016EB RID: 5867
		public const int NameHashFieldNumber = 2;

		// Token: 0x040016EC RID: 5868
		private static readonly uint NameHashDefaultValue = 0U;

		// Token: 0x040016ED RID: 5869
		private uint nameHash_;

		// Token: 0x040016EE RID: 5870
		public const int ValueFieldNumber = 3;

		// Token: 0x040016EF RID: 5871
		private static readonly float ValueDefaultValue = 0f;

		// Token: 0x040016F0 RID: 5872
		private float value_;

		// Token: 0x040016F1 RID: 5873
		public const int TicksUntilExpirationFieldNumber = 4;

		// Token: 0x040016F2 RID: 5874
		private static readonly uint TicksUntilExpirationDefaultValue = 0U;

		// Token: 0x040016F3 RID: 5875
		private uint ticksUntilExpiration_;

		// Token: 0x040016F4 RID: 5876
		public const int SourceAibehaviorSnoFieldNumber = 5;

		// Token: 0x040016F5 RID: 5877
		private static readonly int SourceAibehaviorSnoDefaultValue = 0;

		// Token: 0x040016F6 RID: 5878
		private int sourceAibehaviorSno_;
	}
}
