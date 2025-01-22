using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D5 RID: 469
	public sealed class AIStateDebugSnapshotCurrentPower : IMessage<AIStateDebugSnapshotCurrentPower>, IMessage, IEquatable<AIStateDebugSnapshotCurrentPower>, IDeepCloneable<AIStateDebugSnapshotCurrentPower>, IBufferMessage
	{
		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000C83FC File Offset: 0x000C65FC
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugSnapshotCurrentPower> Parser
		{
			get
			{
				return AIStateDebugSnapshotCurrentPower._parser;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000C8414 File Offset: 0x000C6614
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000C8438 File Offset: 0x000C6638
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugSnapshotCurrentPower.Descriptor;
			}
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000C844F File Offset: 0x000C664F
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotCurrentPower()
		{
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000C845C File Offset: 0x000C665C
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotCurrentPower(AIStateDebugSnapshotCurrentPower other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.powerSno_ = other.powerSno_;
			this.originalPowerSno_ = other.originalPowerSno_;
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.ticksExecuting_ = other.ticksExecuting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000C84D0 File Offset: 0x000C66D0
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotCurrentPower Clone()
		{
			return new AIStateDebugSnapshotCurrentPower(this);
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x000C84E8 File Offset: 0x000C66E8
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x000C8519 File Offset: 0x000C6719
		[DebuggerNonUserCode]
		public int PowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int powerSnoDefaultValue;
				if (flag)
				{
					powerSnoDefaultValue = this.powerSno_;
				}
				else
				{
					powerSnoDefaultValue = AIStateDebugSnapshotCurrentPower.PowerSnoDefaultValue;
				}
				return powerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.powerSno_ = value;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x000C8534 File Offset: 0x000C6734
		[DebuggerNonUserCode]
		public bool HasPowerSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000C8551 File Offset: 0x000C6751
		[DebuggerNonUserCode]
		public void ClearPowerSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000C8564 File Offset: 0x000C6764
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x000C8595 File Offset: 0x000C6795
		[DebuggerNonUserCode]
		public int OriginalPowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int originalPowerSnoDefaultValue;
				if (flag)
				{
					originalPowerSnoDefaultValue = this.originalPowerSno_;
				}
				else
				{
					originalPowerSnoDefaultValue = AIStateDebugSnapshotCurrentPower.OriginalPowerSnoDefaultValue;
				}
				return originalPowerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.originalPowerSno_ = value;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x000C85B0 File Offset: 0x000C67B0
		[DebuggerNonUserCode]
		public bool HasOriginalPowerSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000C85CD File Offset: 0x000C67CD
		[DebuggerNonUserCode]
		public void ClearOriginalPowerSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x000C85E0 File Offset: 0x000C67E0
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x000C85F8 File Offset: 0x000C67F8
		[DebuggerNonUserCode]
		public DebugTarget Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000C8604 File Offset: 0x000C6804
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x000C8635 File Offset: 0x000C6835
		[DebuggerNonUserCode]
		public uint TicksExecuting
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint ticksExecutingDefaultValue;
				if (flag)
				{
					ticksExecutingDefaultValue = this.ticksExecuting_;
				}
				else
				{
					ticksExecutingDefaultValue = AIStateDebugSnapshotCurrentPower.TicksExecutingDefaultValue;
				}
				return ticksExecutingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.ticksExecuting_ = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x000C8650 File Offset: 0x000C6850
		[DebuggerNonUserCode]
		public bool HasTicksExecuting
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000C866D File Offset: 0x000C686D
		[DebuggerNonUserCode]
		public void ClearTicksExecuting()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000C8680 File Offset: 0x000C6880
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugSnapshotCurrentPower);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000C86A0 File Offset: 0x000C68A0
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugSnapshotCurrentPower other)
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
					bool flag4 = this.PowerSno != other.PowerSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.OriginalPowerSno != other.OriginalPowerSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Target, other.Target);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TicksExecuting != other.TicksExecuting;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000C8750 File Offset: 0x000C6950
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num ^= this.PowerSno.GetHashCode();
			}
			bool hasOriginalPowerSno = this.HasOriginalPowerSno;
			if (hasOriginalPowerSno)
			{
				num ^= this.OriginalPowerSno.GetHashCode();
			}
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasTicksExecuting = this.HasTicksExecuting;
			if (hasTicksExecuting)
			{
				num ^= this.TicksExecuting.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000C87F8 File Offset: 0x000C69F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000C8810 File Offset: 0x000C6A10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000C881C File Offset: 0x000C6A1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.PowerSno);
			}
			bool hasOriginalPowerSno = this.HasOriginalPowerSno;
			if (hasOriginalPowerSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.OriginalPowerSno);
			}
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Target);
			}
			bool hasTicksExecuting = this.HasTicksExecuting;
			if (hasTicksExecuting)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TicksExecuting);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000C88D4 File Offset: 0x000C6AD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num += 5;
			}
			bool hasOriginalPowerSno = this.HasOriginalPowerSno;
			if (hasOriginalPowerSno)
			{
				num += 5;
			}
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasTicksExecuting = this.HasTicksExecuting;
			if (hasTicksExecuting)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TicksExecuting);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000C8968 File Offset: 0x000C6B68
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugSnapshotCurrentPower other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPowerSno = other.HasPowerSno;
				if (hasPowerSno)
				{
					this.PowerSno = other.PowerSno;
				}
				bool hasOriginalPowerSno = other.HasOriginalPowerSno;
				if (hasOriginalPowerSno)
				{
					this.OriginalPowerSno = other.OriginalPowerSno;
				}
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new DebugTarget();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool hasTicksExecuting = other.HasTicksExecuting;
				if (hasTicksExecuting)
				{
					this.TicksExecuting = other.TicksExecuting;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000C8A26 File Offset: 0x000C6C26
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000C8A34 File Offset: 0x000C6C34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							goto IL_002C;
						}
						this.OriginalPowerSno = input.ReadSFixed32();
					}
					else
					{
						this.PowerSno = input.ReadSFixed32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.TicksExecuting = input.ReadUInt32();
				}
				else
				{
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new DebugTarget();
					}
					input.ReadMessage(this.Target);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001747 RID: 5959
		private static readonly MessageParser<AIStateDebugSnapshotCurrentPower> _parser = new MessageParser<AIStateDebugSnapshotCurrentPower>(() => new AIStateDebugSnapshotCurrentPower());

		// Token: 0x04001748 RID: 5960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001749 RID: 5961
		private int _hasBits0;

		// Token: 0x0400174A RID: 5962
		public const int PowerSnoFieldNumber = 1;

		// Token: 0x0400174B RID: 5963
		private static readonly int PowerSnoDefaultValue = -1;

		// Token: 0x0400174C RID: 5964
		private int powerSno_;

		// Token: 0x0400174D RID: 5965
		public const int OriginalPowerSnoFieldNumber = 2;

		// Token: 0x0400174E RID: 5966
		private static readonly int OriginalPowerSnoDefaultValue = 0;

		// Token: 0x0400174F RID: 5967
		private int originalPowerSno_;

		// Token: 0x04001750 RID: 5968
		public const int TargetFieldNumber = 3;

		// Token: 0x04001751 RID: 5969
		private DebugTarget target_;

		// Token: 0x04001752 RID: 5970
		public const int TicksExecutingFieldNumber = 4;

		// Token: 0x04001753 RID: 5971
		private static readonly uint TicksExecutingDefaultValue = 0U;

		// Token: 0x04001754 RID: 5972
		private uint ticksExecuting_;
	}
}
