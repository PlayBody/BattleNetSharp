using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D5 RID: 213
	public sealed class ParametricCavitySettings : IMessage<ParametricCavitySettings>, IMessage, IEquatable<ParametricCavitySettings>, IDeepCloneable<ParametricCavitySettings>, IBufferMessage
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0004AB9C File Offset: 0x00048D9C
		[DebuggerNonUserCode]
		public static MessageParser<ParametricCavitySettings> Parser
		{
			get
			{
				return ParametricCavitySettings._parser;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0004ABB4 File Offset: 0x00048DB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[190];
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0004ABDC File Offset: 0x00048DDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricCavitySettings.Descriptor;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0004ABF3 File Offset: 0x00048DF3
		[DebuggerNonUserCode]
		public ParametricCavitySettings()
		{
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0004AC00 File Offset: 0x00048E00
		[DebuggerNonUserCode]
		public ParametricCavitySettings(ParametricCavitySettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mode_ = other.mode_;
			this.tolerance_ = other.tolerance_;
			this.smoothness_ = other.smoothness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0004AC58 File Offset: 0x00048E58
		[DebuggerNonUserCode]
		public ParametricCavitySettings Clone()
		{
			return new ParametricCavitySettings(this);
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0004AC70 File Offset: 0x00048E70
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0004ACA1 File Offset: 0x00048EA1
		[DebuggerNonUserCode]
		public int Mode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int modeDefaultValue;
				if (flag)
				{
					modeDefaultValue = this.mode_;
				}
				else
				{
					modeDefaultValue = ParametricCavitySettings.ModeDefaultValue;
				}
				return modeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.mode_ = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0004ACBC File Offset: 0x00048EBC
		[DebuggerNonUserCode]
		public bool HasMode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0004ACD9 File Offset: 0x00048ED9
		[DebuggerNonUserCode]
		public void ClearMode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0004ACEC File Offset: 0x00048EEC
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0004AD1D File Offset: 0x00048F1D
		[DebuggerNonUserCode]
		public float Tolerance
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float toleranceDefaultValue;
				if (flag)
				{
					toleranceDefaultValue = this.tolerance_;
				}
				else
				{
					toleranceDefaultValue = ParametricCavitySettings.ToleranceDefaultValue;
				}
				return toleranceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.tolerance_ = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0004AD38 File Offset: 0x00048F38
		[DebuggerNonUserCode]
		public bool HasTolerance
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0004AD55 File Offset: 0x00048F55
		[DebuggerNonUserCode]
		public void ClearTolerance()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0004AD68 File Offset: 0x00048F68
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0004AD99 File Offset: 0x00048F99
		[DebuggerNonUserCode]
		public float Smoothness
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float smoothnessDefaultValue;
				if (flag)
				{
					smoothnessDefaultValue = this.smoothness_;
				}
				else
				{
					smoothnessDefaultValue = ParametricCavitySettings.SmoothnessDefaultValue;
				}
				return smoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.smoothness_ = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0004ADB4 File Offset: 0x00048FB4
		[DebuggerNonUserCode]
		public bool HasSmoothness
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0004ADD1 File Offset: 0x00048FD1
		[DebuggerNonUserCode]
		public void ClearSmoothness()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricCavitySettings);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0004AE04 File Offset: 0x00049004
		[DebuggerNonUserCode]
		public bool Equals(ParametricCavitySettings other)
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
					bool flag4 = this.Mode != other.Mode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Tolerance, other.Tolerance);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smoothness, other.Smoothness);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0004AEA4 File Offset: 0x000490A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMode = this.HasMode;
			if (hasMode)
			{
				num ^= this.Mode.GetHashCode();
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Tolerance);
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Smoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0004AF34 File Offset: 0x00049134
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0004AF4C File Offset: 0x0004914C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0004AF58 File Offset: 0x00049158
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMode = this.HasMode;
			if (hasMode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Mode);
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Tolerance);
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Smoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0004AFE8 File Offset: 0x000491E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMode = this.HasMode;
			if (hasMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Mode);
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				num += 5;
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
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

		// Token: 0x0600148C RID: 5260 RVA: 0x0004B05C File Offset: 0x0004925C
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricCavitySettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMode = other.HasMode;
				if (hasMode)
				{
					this.Mode = other.Mode;
				}
				bool hasTolerance = other.HasTolerance;
				if (hasTolerance)
				{
					this.Tolerance = other.Tolerance;
				}
				bool hasSmoothness = other.HasSmoothness;
				if (hasSmoothness)
				{
					this.Smoothness = other.Smoothness;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0004B0D7 File Offset: 0x000492D7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0004B0E4 File Offset: 0x000492E4
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
					if (num3 != 21U)
					{
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Smoothness = input.ReadFloat();
						}
					}
					else
					{
						this.Tolerance = input.ReadFloat();
					}
				}
				else
				{
					this.Mode = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400084F RID: 2127
		private static readonly MessageParser<ParametricCavitySettings> _parser = new MessageParser<ParametricCavitySettings>(() => new ParametricCavitySettings());

		// Token: 0x04000850 RID: 2128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000851 RID: 2129
		private int _hasBits0;

		// Token: 0x04000852 RID: 2130
		public const int ModeFieldNumber = 1;

		// Token: 0x04000853 RID: 2131
		private static readonly int ModeDefaultValue = 0;

		// Token: 0x04000854 RID: 2132
		private int mode_;

		// Token: 0x04000855 RID: 2133
		public const int ToleranceFieldNumber = 2;

		// Token: 0x04000856 RID: 2134
		private static readonly float ToleranceDefaultValue = 0f;

		// Token: 0x04000857 RID: 2135
		private float tolerance_;

		// Token: 0x04000858 RID: 2136
		public const int SmoothnessFieldNumber = 3;

		// Token: 0x04000859 RID: 2137
		private static readonly float SmoothnessDefaultValue = 0f;

		// Token: 0x0400085A RID: 2138
		private float smoothness_;
	}
}
