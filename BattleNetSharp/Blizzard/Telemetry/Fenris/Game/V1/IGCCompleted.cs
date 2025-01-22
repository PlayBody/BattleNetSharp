using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F0 RID: 752
	public sealed class IGCCompleted : IMessage<IGCCompleted>, IMessage, IEquatable<IGCCompleted>, IDeepCloneable<IGCCompleted>, IBufferMessage
	{
		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x001309EC File Offset: 0x0012EBEC
		[DebuggerNonUserCode]
		public static MessageParser<IGCCompleted> Parser
		{
			get
			{
				return IGCCompleted._parser;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06004F56 RID: 20310 RVA: 0x00130A04 File Offset: 0x0012EC04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IGCCompletedReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06004F57 RID: 20311 RVA: 0x00130A28 File Offset: 0x0012EC28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IGCCompleted.Descriptor;
			}
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00130A3F File Offset: 0x0012EC3F
		[DebuggerNonUserCode]
		public IGCCompleted()
		{
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00130A4C File Offset: 0x0012EC4C
		[DebuggerNonUserCode]
		public IGCCompleted(IGCCompleted other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hero_ = ((other.hero_ != null) ? other.hero_.Clone() : null);
			this.snoConversation_ = other.snoConversation_;
			this.damageTaken_ = other.damageTaken_;
			this.lowAvgFps_ = other.lowAvgFps_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00130AC0 File Offset: 0x0012ECC0
		[DebuggerNonUserCode]
		public IGCCompleted Clone()
		{
			return new IGCCompleted(this);
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x00130AD8 File Offset: 0x0012ECD8
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x00130AF0 File Offset: 0x0012ECF0
		[DebuggerNonUserCode]
		public HeroInfo Hero
		{
			get
			{
				return this.hero_;
			}
			set
			{
				this.hero_ = value;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x00130AFC File Offset: 0x0012ECFC
		// (set) Token: 0x06004F5E RID: 20318 RVA: 0x00130B2D File Offset: 0x0012ED2D
		[DebuggerNonUserCode]
		public int SnoConversation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoConversationDefaultValue;
				if (flag)
				{
					snoConversationDefaultValue = this.snoConversation_;
				}
				else
				{
					snoConversationDefaultValue = IGCCompleted.SnoConversationDefaultValue;
				}
				return snoConversationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoConversation_ = value;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x00130B48 File Offset: 0x0012ED48
		[DebuggerNonUserCode]
		public bool HasSnoConversation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x00130B65 File Offset: 0x0012ED65
		[DebuggerNonUserCode]
		public void ClearSnoConversation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x00130B78 File Offset: 0x0012ED78
		// (set) Token: 0x06004F62 RID: 20322 RVA: 0x00130BA9 File Offset: 0x0012EDA9
		[DebuggerNonUserCode]
		public bool DamageTaken
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool damageTakenDefaultValue;
				if (flag)
				{
					damageTakenDefaultValue = this.damageTaken_;
				}
				else
				{
					damageTakenDefaultValue = IGCCompleted.DamageTakenDefaultValue;
				}
				return damageTakenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.damageTaken_ = value;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x00130BC4 File Offset: 0x0012EDC4
		[DebuggerNonUserCode]
		public bool HasDamageTaken
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x00130BE1 File Offset: 0x0012EDE1
		[DebuggerNonUserCode]
		public void ClearDamageTaken()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x00130BF4 File Offset: 0x0012EDF4
		// (set) Token: 0x06004F66 RID: 20326 RVA: 0x00130C25 File Offset: 0x0012EE25
		[DebuggerNonUserCode]
		public float LowAvgFps
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float lowAvgFpsDefaultValue;
				if (flag)
				{
					lowAvgFpsDefaultValue = this.lowAvgFps_;
				}
				else
				{
					lowAvgFpsDefaultValue = IGCCompleted.LowAvgFpsDefaultValue;
				}
				return lowAvgFpsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lowAvgFps_ = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x00130C40 File Offset: 0x0012EE40
		[DebuggerNonUserCode]
		public bool HasLowAvgFps
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00130C5D File Offset: 0x0012EE5D
		[DebuggerNonUserCode]
		public void ClearLowAvgFps()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00130C70 File Offset: 0x0012EE70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IGCCompleted);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00130C90 File Offset: 0x0012EE90
		[DebuggerNonUserCode]
		public bool Equals(IGCCompleted other)
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
					bool flag4 = !object.Equals(this.Hero, other.Hero);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoConversation != other.SnoConversation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DamageTaken != other.DamageTaken;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LowAvgFps, other.LowAvgFps);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00130D48 File Offset: 0x0012EF48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num ^= this.Hero.GetHashCode();
			}
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				num ^= this.SnoConversation.GetHashCode();
			}
			bool hasDamageTaken = this.HasDamageTaken;
			if (hasDamageTaken)
			{
				num ^= this.DamageTaken.GetHashCode();
			}
			bool hasLowAvgFps = this.HasLowAvgFps;
			if (hasLowAvgFps)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LowAvgFps);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00130DF4 File Offset: 0x0012EFF4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00130E0C File Offset: 0x0012F00C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00130E18 File Offset: 0x0012F018
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.hero_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Hero);
			}
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.SnoConversation);
			}
			bool hasDamageTaken = this.HasDamageTaken;
			if (hasDamageTaken)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DamageTaken);
			}
			bool hasLowAvgFps = this.HasLowAvgFps;
			if (hasLowAvgFps)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.LowAvgFps);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00130ED0 File Offset: 0x0012F0D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Hero);
			}
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoConversation);
			}
			bool hasDamageTaken = this.HasDamageTaken;
			if (hasDamageTaken)
			{
				num += 2;
			}
			bool hasLowAvgFps = this.HasLowAvgFps;
			if (hasLowAvgFps)
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

		// Token: 0x06004F70 RID: 20336 RVA: 0x00130F64 File Offset: 0x0012F164
		[DebuggerNonUserCode]
		public void MergeFrom(IGCCompleted other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.hero_ != null;
				if (flag2)
				{
					bool flag3 = this.hero_ == null;
					if (flag3)
					{
						this.Hero = new HeroInfo();
					}
					this.Hero.MergeFrom(other.Hero);
				}
				bool hasSnoConversation = other.HasSnoConversation;
				if (hasSnoConversation)
				{
					this.SnoConversation = other.SnoConversation;
				}
				bool hasDamageTaken = other.HasDamageTaken;
				if (hasDamageTaken)
				{
					this.DamageTaken = other.DamageTaken;
				}
				bool hasLowAvgFps = other.HasLowAvgFps;
				if (hasLowAvgFps)
				{
					this.LowAvgFps = other.LowAvgFps;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x00131022 File Offset: 0x0012F222
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x00131030 File Offset: 0x0012F230
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
							goto IL_002C;
						}
						this.SnoConversation = input.ReadSInt32();
					}
					else
					{
						bool flag = this.hero_ == null;
						if (flag)
						{
							this.Hero = new HeroInfo();
						}
						input.ReadMessage(this.Hero);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 37U)
					{
						goto IL_002C;
					}
					this.LowAvgFps = input.ReadFloat();
				}
				else
				{
					this.DamageTaken = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400239C RID: 9116
		private static readonly MessageParser<IGCCompleted> _parser = new MessageParser<IGCCompleted>(() => new IGCCompleted());

		// Token: 0x0400239D RID: 9117
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400239E RID: 9118
		private int _hasBits0;

		// Token: 0x0400239F RID: 9119
		public const int HeroFieldNumber = 1;

		// Token: 0x040023A0 RID: 9120
		private HeroInfo hero_;

		// Token: 0x040023A1 RID: 9121
		public const int SnoConversationFieldNumber = 2;

		// Token: 0x040023A2 RID: 9122
		private static readonly int SnoConversationDefaultValue = 0;

		// Token: 0x040023A3 RID: 9123
		private int snoConversation_;

		// Token: 0x040023A4 RID: 9124
		public const int DamageTakenFieldNumber = 3;

		// Token: 0x040023A5 RID: 9125
		private static readonly bool DamageTakenDefaultValue = false;

		// Token: 0x040023A6 RID: 9126
		private bool damageTaken_;

		// Token: 0x040023A7 RID: 9127
		public const int LowAvgFpsFieldNumber = 4;

		// Token: 0x040023A8 RID: 9128
		private static readonly float LowAvgFpsDefaultValue = 0f;

		// Token: 0x040023A9 RID: 9129
		private float lowAvgFps_;
	}
}
