using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002A RID: 42
	public sealed class Quaternion : IMessage<Quaternion>, IMessage, IEquatable<Quaternion>, IDeepCloneable<Quaternion>, IBufferMessage
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000F664 File Offset: 0x0000D864
		[DebuggerNonUserCode]
		public static MessageParser<Quaternion> Parser
		{
			get
			{
				return Quaternion._parser;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000F67C File Offset: 0x0000D87C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Quaternion.Descriptor;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000F6B7 File Offset: 0x0000D8B7
		[DebuggerNonUserCode]
		public Quaternion()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000F6C4 File Offset: 0x0000D8C4
		[DebuggerNonUserCode]
		public Quaternion(Quaternion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.w_ = other.w_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F728 File Offset: 0x0000D928
		[DebuggerNonUserCode]
		public Quaternion Clone()
		{
			return new Quaternion(this);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000F740 File Offset: 0x0000D940
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000F771 File Offset: 0x0000D971
		[DebuggerNonUserCode]
		public float X
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float xdefaultValue;
				if (flag)
				{
					xdefaultValue = this.x_;
				}
				else
				{
					xdefaultValue = Quaternion.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.x_ = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000F78C File Offset: 0x0000D98C
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000F7A9 File Offset: 0x0000D9A9
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000F7ED File Offset: 0x0000D9ED
		[DebuggerNonUserCode]
		public float Y
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float ydefaultValue;
				if (flag)
				{
					ydefaultValue = this.y_;
				}
				else
				{
					ydefaultValue = Quaternion.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.y_ = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000F808 File Offset: 0x0000DA08
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000F825 File Offset: 0x0000DA25
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000F838 File Offset: 0x0000DA38
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000F869 File Offset: 0x0000DA69
		[DebuggerNonUserCode]
		public float Z
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float zdefaultValue;
				if (flag)
				{
					zdefaultValue = this.z_;
				}
				else
				{
					zdefaultValue = Quaternion.ZDefaultValue;
				}
				return zdefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.z_ = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000F884 File Offset: 0x0000DA84
		[DebuggerNonUserCode]
		public bool HasZ
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000F8A1 File Offset: 0x0000DAA1
		[DebuggerNonUserCode]
		public void ClearZ()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000F8E5 File Offset: 0x0000DAE5
		[DebuggerNonUserCode]
		public float W
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float wdefaultValue;
				if (flag)
				{
					wdefaultValue = this.w_;
				}
				else
				{
					wdefaultValue = Quaternion.WDefaultValue;
				}
				return wdefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.w_ = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000F900 File Offset: 0x0000DB00
		[DebuggerNonUserCode]
		public bool HasW
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F91D File Offset: 0x0000DB1D
		[DebuggerNonUserCode]
		public void ClearW()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000F930 File Offset: 0x0000DB30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Quaternion);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000F950 File Offset: 0x0000DB50
		[DebuggerNonUserCode]
		public bool Equals(Quaternion other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.W, other.W);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasX = this.HasX;
			if (hasX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			bool hasZ = this.HasZ;
			if (hasZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			bool hasW = this.HasW;
			if (hasW)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.W);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000FACC File Offset: 0x0000DCCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasX = this.HasX;
			if (hasX)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.X);
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Y);
			}
			bool hasZ = this.HasZ;
			if (hasZ)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Z);
			}
			bool hasW = this.HasW;
			if (hasW)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.W);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasX = this.HasX;
			if (hasX)
			{
				num += 5;
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				num += 5;
			}
			bool hasZ = this.HasZ;
			if (hasZ)
			{
				num += 5;
			}
			bool hasW = this.HasW;
			if (hasW)
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

		// Token: 0x060002A5 RID: 677 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		[DebuggerNonUserCode]
		public void MergeFrom(Quaternion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasX = other.HasX;
				if (hasX)
				{
					this.X = other.X;
				}
				bool hasY = other.HasY;
				if (hasY)
				{
					this.Y = other.Y;
				}
				bool hasZ = other.HasZ;
				if (hasZ)
				{
					this.Z = other.Z;
				}
				bool hasW = other.HasW;
				if (hasW)
				{
					this.W = other.W;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
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
						this.Y = input.ReadFloat();
					}
					else
					{
						this.X = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.W = input.ReadFloat();
				}
				else
				{
					this.Z = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400010C RID: 268
		private static readonly MessageParser<Quaternion> _parser = new MessageParser<Quaternion>(() => new Quaternion());

		// Token: 0x0400010D RID: 269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400010E RID: 270
		private int _hasBits0;

		// Token: 0x0400010F RID: 271
		public const int XFieldNumber = 1;

		// Token: 0x04000110 RID: 272
		private static readonly float XDefaultValue = 0f;

		// Token: 0x04000111 RID: 273
		private float x_;

		// Token: 0x04000112 RID: 274
		public const int YFieldNumber = 2;

		// Token: 0x04000113 RID: 275
		private static readonly float YDefaultValue = 0f;

		// Token: 0x04000114 RID: 276
		private float y_;

		// Token: 0x04000115 RID: 277
		public const int ZFieldNumber = 3;

		// Token: 0x04000116 RID: 278
		private static readonly float ZDefaultValue = 0f;

		// Token: 0x04000117 RID: 279
		private float z_;

		// Token: 0x04000118 RID: 280
		public const int WFieldNumber = 4;

		// Token: 0x04000119 RID: 281
		private static readonly float WDefaultValue = 0f;

		// Token: 0x0400011A RID: 282
		private float w_;
	}
}
