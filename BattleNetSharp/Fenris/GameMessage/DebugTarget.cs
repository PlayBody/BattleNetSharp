using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CC RID: 460
	public sealed class DebugTarget : IMessage<DebugTarget>, IMessage, IEquatable<DebugTarget>, IDeepCloneable<DebugTarget>, IBufferMessage
	{
		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000C2080 File Offset: 0x000C0280
		[DebuggerNonUserCode]
		public static MessageParser<DebugTarget> Parser
		{
			get
			{
				return DebugTarget._parser;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000C2098 File Offset: 0x000C0298
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000C20BC File Offset: 0x000C02BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugTarget.Descriptor;
			}
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000C20D3 File Offset: 0x000C02D3
		[DebuggerNonUserCode]
		public DebugTarget()
		{
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000C20E0 File Offset: 0x000C02E0
		[DebuggerNonUserCode]
		public DebugTarget(DebugTarget other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.acdName_ = other.acdName_;
			this.worldPlace_ = ((other.worldPlace_ != null) ? other.worldPlace_.Clone() : null);
			this.pathable_ = other.pathable_;
			this.timeSincePathable_ = other.timeSincePathable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000C2154 File Offset: 0x000C0354
		[DebuggerNonUserCode]
		public DebugTarget Clone()
		{
			return new DebugTarget(this);
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x000C216C File Offset: 0x000C036C
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x000C218D File Offset: 0x000C038D
		[DebuggerNonUserCode]
		public string AcdName
		{
			get
			{
				return this.acdName_ ?? DebugTarget.AcdNameDefaultValue;
			}
			set
			{
				this.acdName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000C21A4 File Offset: 0x000C03A4
		[DebuggerNonUserCode]
		public bool HasAcdName
		{
			get
			{
				return this.acdName_ != null;
			}
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x000C21BF File Offset: 0x000C03BF
		[DebuggerNonUserCode]
		public void ClearAcdName()
		{
			this.acdName_ = null;
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x000C21CC File Offset: 0x000C03CC
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x000C21E4 File Offset: 0x000C03E4
		[DebuggerNonUserCode]
		public DebugWorldPlace WorldPlace
		{
			get
			{
				return this.worldPlace_;
			}
			set
			{
				this.worldPlace_ = value;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x000C21F0 File Offset: 0x000C03F0
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x000C2221 File Offset: 0x000C0421
		[DebuggerNonUserCode]
		public bool Pathable
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool pathableDefaultValue;
				if (flag)
				{
					pathableDefaultValue = this.pathable_;
				}
				else
				{
					pathableDefaultValue = DebugTarget.PathableDefaultValue;
				}
				return pathableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.pathable_ = value;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x000C223C File Offset: 0x000C043C
		[DebuggerNonUserCode]
		public bool HasPathable
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000C2259 File Offset: 0x000C0459
		[DebuggerNonUserCode]
		public void ClearPathable()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x000C226C File Offset: 0x000C046C
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x000C229D File Offset: 0x000C049D
		[DebuggerNonUserCode]
		public float TimeSincePathable
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float timeSincePathableDefaultValue;
				if (flag)
				{
					timeSincePathableDefaultValue = this.timeSincePathable_;
				}
				else
				{
					timeSincePathableDefaultValue = DebugTarget.TimeSincePathableDefaultValue;
				}
				return timeSincePathableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.timeSincePathable_ = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x000C22B8 File Offset: 0x000C04B8
		[DebuggerNonUserCode]
		public bool HasTimeSincePathable
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000C22D5 File Offset: 0x000C04D5
		[DebuggerNonUserCode]
		public void ClearTimeSincePathable()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000C22E8 File Offset: 0x000C04E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugTarget);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000C2308 File Offset: 0x000C0508
		[DebuggerNonUserCode]
		public bool Equals(DebugTarget other)
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
					bool flag4 = this.AcdName != other.AcdName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.WorldPlace, other.WorldPlace);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Pathable != other.Pathable;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeSincePathable, other.TimeSincePathable);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000C23C0 File Offset: 0x000C05C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num ^= this.AcdName.GetHashCode();
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num ^= this.WorldPlace.GetHashCode();
			}
			bool hasPathable = this.HasPathable;
			if (hasPathable)
			{
				num ^= this.Pathable.GetHashCode();
			}
			bool hasTimeSincePathable = this.HasTimeSincePathable;
			if (hasTimeSincePathable)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeSincePathable);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000C2464 File Offset: 0x000C0664
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000C247C File Offset: 0x000C067C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000C2488 File Offset: 0x000C0688
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AcdName);
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WorldPlace);
			}
			bool hasPathable = this.HasPathable;
			if (hasPathable)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Pathable);
			}
			bool hasTimeSincePathable = this.HasTimeSincePathable;
			if (hasTimeSincePathable)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TimeSincePathable);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000C2540 File Offset: 0x000C0740
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AcdName);
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldPlace);
			}
			bool hasPathable = this.HasPathable;
			if (hasPathable)
			{
				num += 2;
			}
			bool hasTimeSincePathable = this.HasTimeSincePathable;
			if (hasTimeSincePathable)
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

		// Token: 0x06003123 RID: 12579 RVA: 0x000C25D4 File Offset: 0x000C07D4
		[DebuggerNonUserCode]
		public void MergeFrom(DebugTarget other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAcdName = other.HasAcdName;
				if (hasAcdName)
				{
					this.AcdName = other.AcdName;
				}
				bool flag2 = other.worldPlace_ != null;
				if (flag2)
				{
					bool flag3 = this.worldPlace_ == null;
					if (flag3)
					{
						this.WorldPlace = new DebugWorldPlace();
					}
					this.WorldPlace.MergeFrom(other.WorldPlace);
				}
				bool hasPathable = other.HasPathable;
				if (hasPathable)
				{
					this.Pathable = other.Pathable;
				}
				bool hasTimeSincePathable = other.HasTimeSincePathable;
				if (hasTimeSincePathable)
				{
					this.TimeSincePathable = other.TimeSincePathable;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000C2692 File Offset: 0x000C0892
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000C26A0 File Offset: 0x000C08A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002C;
						}
						bool flag = this.worldPlace_ == null;
						if (flag)
						{
							this.WorldPlace = new DebugWorldPlace();
						}
						input.ReadMessage(this.WorldPlace);
					}
					else
					{
						this.AcdName = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 37U)
					{
						goto IL_002C;
					}
					this.TimeSincePathable = input.ReadFloat();
				}
				else
				{
					this.Pathable = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400166C RID: 5740
		private static readonly MessageParser<DebugTarget> _parser = new MessageParser<DebugTarget>(() => new DebugTarget());

		// Token: 0x0400166D RID: 5741
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400166E RID: 5742
		private int _hasBits0;

		// Token: 0x0400166F RID: 5743
		public const int AcdNameFieldNumber = 1;

		// Token: 0x04001670 RID: 5744
		private static readonly string AcdNameDefaultValue = "";

		// Token: 0x04001671 RID: 5745
		private string acdName_;

		// Token: 0x04001672 RID: 5746
		public const int WorldPlaceFieldNumber = 2;

		// Token: 0x04001673 RID: 5747
		private DebugWorldPlace worldPlace_;

		// Token: 0x04001674 RID: 5748
		public const int PathableFieldNumber = 3;

		// Token: 0x04001675 RID: 5749
		private static readonly bool PathableDefaultValue = false;

		// Token: 0x04001676 RID: 5750
		private bool pathable_;

		// Token: 0x04001677 RID: 5751
		public const int TimeSincePathableFieldNumber = 4;

		// Token: 0x04001678 RID: 5752
		private static readonly float TimeSincePathableDefaultValue = 0f;

		// Token: 0x04001679 RID: 5753
		private float timeSincePathable_;
	}
}
