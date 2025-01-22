using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000029 RID: 41
	public sealed class Rect2D : IMessage<Rect2D>, IMessage, IEquatable<Rect2D>, IDeepCloneable<Rect2D>, IBufferMessage
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000EF18 File Offset: 0x0000D118
		[DebuggerNonUserCode]
		public static MessageParser<Rect2D> Parser
		{
			get
			{
				return Rect2D._parser;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000EF30 File Offset: 0x0000D130
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000EF54 File Offset: 0x0000D154
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Rect2D.Descriptor;
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000EF6B File Offset: 0x0000D16B
		[DebuggerNonUserCode]
		public Rect2D()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000EF78 File Offset: 0x0000D178
		[DebuggerNonUserCode]
		public Rect2D(Rect2D other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.l_ = other.l_;
			this.t_ = other.t_;
			this.r_ = other.r_;
			this.b_ = other.b_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		[DebuggerNonUserCode]
		public Rect2D Clone()
		{
			return new Rect2D(this);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000F025 File Offset: 0x0000D225
		[DebuggerNonUserCode]
		public float L
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float ldefaultValue;
				if (flag)
				{
					ldefaultValue = this.l_;
				}
				else
				{
					ldefaultValue = Rect2D.LDefaultValue;
				}
				return ldefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.l_ = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000F040 File Offset: 0x0000D240
		[DebuggerNonUserCode]
		public bool HasL
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000F05D File Offset: 0x0000D25D
		[DebuggerNonUserCode]
		public void ClearL()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000F070 File Offset: 0x0000D270
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000F0A1 File Offset: 0x0000D2A1
		[DebuggerNonUserCode]
		public float T
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float tdefaultValue;
				if (flag)
				{
					tdefaultValue = this.t_;
				}
				else
				{
					tdefaultValue = Rect2D.TDefaultValue;
				}
				return tdefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.t_ = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		[DebuggerNonUserCode]
		public bool HasT
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000F0D9 File Offset: 0x0000D2D9
		[DebuggerNonUserCode]
		public void ClearT()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000F11D File Offset: 0x0000D31D
		[DebuggerNonUserCode]
		public float R
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float rdefaultValue;
				if (flag)
				{
					rdefaultValue = this.r_;
				}
				else
				{
					rdefaultValue = Rect2D.RDefaultValue;
				}
				return rdefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.r_ = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000F138 File Offset: 0x0000D338
		[DebuggerNonUserCode]
		public bool HasR
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000F155 File Offset: 0x0000D355
		[DebuggerNonUserCode]
		public void ClearR()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000F168 File Offset: 0x0000D368
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000F199 File Offset: 0x0000D399
		[DebuggerNonUserCode]
		public float B
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float bdefaultValue;
				if (flag)
				{
					bdefaultValue = this.b_;
				}
				else
				{
					bdefaultValue = Rect2D.BDefaultValue;
				}
				return bdefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.b_ = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		[DebuggerNonUserCode]
		public bool HasB
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000F1D1 File Offset: 0x0000D3D1
		[DebuggerNonUserCode]
		public void ClearB()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Rect2D);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000F204 File Offset: 0x0000D404
		[DebuggerNonUserCode]
		public bool Equals(Rect2D other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.L, other.L);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.T, other.T);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.R, other.R);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.B, other.B);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000F2D4 File Offset: 0x0000D4D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasL = this.HasL;
			if (hasL)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.L);
			}
			bool hasT = this.HasT;
			if (hasT)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.T);
			}
			bool hasR = this.HasR;
			if (hasR)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.R);
			}
			bool hasB = this.HasB;
			if (hasB)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.B);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000F380 File Offset: 0x0000D580
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000F398 File Offset: 0x0000D598
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasL = this.HasL;
			if (hasL)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.L);
			}
			bool hasT = this.HasT;
			if (hasT)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.T);
			}
			bool hasR = this.HasR;
			if (hasR)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.R);
			}
			bool hasB = this.HasB;
			if (hasB)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.B);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000F458 File Offset: 0x0000D658
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasL = this.HasL;
			if (hasL)
			{
				num += 5;
			}
			bool hasT = this.HasT;
			if (hasT)
			{
				num += 5;
			}
			bool hasR = this.HasR;
			if (hasR)
			{
				num += 5;
			}
			bool hasB = this.HasB;
			if (hasB)
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

		// Token: 0x06000284 RID: 644 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		[DebuggerNonUserCode]
		public void MergeFrom(Rect2D other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasL = other.HasL;
				if (hasL)
				{
					this.L = other.L;
				}
				bool hasT = other.HasT;
				if (hasT)
				{
					this.T = other.T;
				}
				bool hasR = other.HasR;
				if (hasR)
				{
					this.R = other.R;
				}
				bool hasB = other.HasB;
				if (hasB)
				{
					this.B = other.B;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000F566 File Offset: 0x0000D766
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000F574 File Offset: 0x0000D774
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
							goto IL_0029;
						}
						this.T = input.ReadFloat();
					}
					else
					{
						this.L = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.B = input.ReadFloat();
				}
				else
				{
					this.R = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly MessageParser<Rect2D> _parser = new MessageParser<Rect2D>(() => new Rect2D());

		// Token: 0x040000FE RID: 254
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000FF RID: 255
		private int _hasBits0;

		// Token: 0x04000100 RID: 256
		public const int LFieldNumber = 1;

		// Token: 0x04000101 RID: 257
		private static readonly float LDefaultValue = 0f;

		// Token: 0x04000102 RID: 258
		private float l_;

		// Token: 0x04000103 RID: 259
		public const int TFieldNumber = 2;

		// Token: 0x04000104 RID: 260
		private static readonly float TDefaultValue = 0f;

		// Token: 0x04000105 RID: 261
		private float t_;

		// Token: 0x04000106 RID: 262
		public const int RFieldNumber = 3;

		// Token: 0x04000107 RID: 263
		private static readonly float RDefaultValue = 0f;

		// Token: 0x04000108 RID: 264
		private float r_;

		// Token: 0x04000109 RID: 265
		public const int BFieldNumber = 4;

		// Token: 0x0400010A RID: 266
		private static readonly float BDefaultValue = 0f;

		// Token: 0x0400010B RID: 267
		private float b_;
	}
}
