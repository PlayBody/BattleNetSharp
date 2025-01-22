using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000023 RID: 35
	public sealed class FrameHolodeckWithOffsetVector : IMessage<FrameHolodeckWithOffsetVector>, IMessage, IEquatable<FrameHolodeckWithOffsetVector>, IDeepCloneable<FrameHolodeckWithOffsetVector>, IBufferMessage
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000D078 File Offset: 0x0000B278
		[DebuggerNonUserCode]
		public static MessageParser<FrameHolodeckWithOffsetVector> Parser
		{
			get
			{
				return FrameHolodeckWithOffsetVector._parser;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000D090 File Offset: 0x0000B290
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FrameHolodeckWithOffsetVector.Descriptor;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000D0CB File Offset: 0x0000B2CB
		[DebuggerNonUserCode]
		public FrameHolodeckWithOffsetVector()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		[DebuggerNonUserCode]
		public FrameHolodeckWithOffsetVector(FrameHolodeckWithOffsetVector other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.holodeckId_ = other.holodeckId_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000D13C File Offset: 0x0000B33C
		[DebuggerNonUserCode]
		public FrameHolodeckWithOffsetVector Clone()
		{
			return new FrameHolodeckWithOffsetVector(this);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000D154 File Offset: 0x0000B354
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000D185 File Offset: 0x0000B385
		[DebuggerNonUserCode]
		public int HolodeckId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int holodeckIdDefaultValue;
				if (flag)
				{
					holodeckIdDefaultValue = this.holodeckId_;
				}
				else
				{
					holodeckIdDefaultValue = FrameHolodeckWithOffsetVector.HolodeckIdDefaultValue;
				}
				return holodeckIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.holodeckId_ = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[DebuggerNonUserCode]
		public bool HasHolodeckId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000D1BD File Offset: 0x0000B3BD
		[DebuggerNonUserCode]
		public void ClearHolodeckId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000D201 File Offset: 0x0000B401
		[DebuggerNonUserCode]
		public float X
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float xdefaultValue;
				if (flag)
				{
					xdefaultValue = this.x_;
				}
				else
				{
					xdefaultValue = FrameHolodeckWithOffsetVector.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.x_ = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000D21C File Offset: 0x0000B41C
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000D239 File Offset: 0x0000B439
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000D24C File Offset: 0x0000B44C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000D27D File Offset: 0x0000B47D
		[DebuggerNonUserCode]
		public float Y
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float ydefaultValue;
				if (flag)
				{
					ydefaultValue = this.y_;
				}
				else
				{
					ydefaultValue = FrameHolodeckWithOffsetVector.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.y_ = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000D298 File Offset: 0x0000B498
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000D2B5 File Offset: 0x0000B4B5
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
		[DebuggerNonUserCode]
		public float Z
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float zdefaultValue;
				if (flag)
				{
					zdefaultValue = this.z_;
				}
				else
				{
					zdefaultValue = FrameHolodeckWithOffsetVector.ZDefaultValue;
				}
				return zdefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.z_ = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000D314 File Offset: 0x0000B514
		[DebuggerNonUserCode]
		public bool HasZ
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000D331 File Offset: 0x0000B531
		[DebuggerNonUserCode]
		public void ClearZ()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000D344 File Offset: 0x0000B544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FrameHolodeckWithOffsetVector);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000D364 File Offset: 0x0000B564
		[DebuggerNonUserCode]
		public bool Equals(FrameHolodeckWithOffsetVector other)
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
					bool flag4 = this.HolodeckId != other.HolodeckId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000D42C File Offset: 0x0000B62C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num ^= this.HolodeckId.GetHashCode();
			}
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HolodeckId);
			}
			bool hasX = this.HasX;
			if (hasX)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.X);
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Y);
			}
			bool hasZ = this.HasZ;
			if (hasZ)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Z);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HolodeckId);
			}
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000D634 File Offset: 0x0000B834
		[DebuggerNonUserCode]
		public void MergeFrom(FrameHolodeckWithOffsetVector other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHolodeckId = other.HasHolodeckId;
				if (hasHolodeckId)
				{
					this.HolodeckId = other.HolodeckId;
				}
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000D6CA File Offset: 0x0000B8CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0028;
						}
						this.X = input.ReadFloat();
					}
					else
					{
						this.HolodeckId = input.ReadInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0028;
					}
					this.Z = input.ReadFloat();
				}
				else
				{
					this.Y = input.ReadFloat();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000C1 RID: 193
		private static readonly MessageParser<FrameHolodeckWithOffsetVector> _parser = new MessageParser<FrameHolodeckWithOffsetVector>(() => new FrameHolodeckWithOffsetVector());

		// Token: 0x040000C2 RID: 194
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000C3 RID: 195
		private int _hasBits0;

		// Token: 0x040000C4 RID: 196
		public const int HolodeckIdFieldNumber = 1;

		// Token: 0x040000C5 RID: 197
		private static readonly int HolodeckIdDefaultValue = 0;

		// Token: 0x040000C6 RID: 198
		private int holodeckId_;

		// Token: 0x040000C7 RID: 199
		public const int XFieldNumber = 2;

		// Token: 0x040000C8 RID: 200
		private static readonly float XDefaultValue = 0f;

		// Token: 0x040000C9 RID: 201
		private float x_;

		// Token: 0x040000CA RID: 202
		public const int YFieldNumber = 3;

		// Token: 0x040000CB RID: 203
		private static readonly float YDefaultValue = 0f;

		// Token: 0x040000CC RID: 204
		private float y_;

		// Token: 0x040000CD RID: 205
		public const int ZFieldNumber = 4;

		// Token: 0x040000CE RID: 206
		private static readonly float ZDefaultValue = 0f;

		// Token: 0x040000CF RID: 207
		private float z_;
	}
}
