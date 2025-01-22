using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000094 RID: 148
	public sealed class DominoContactPoint : IMessage<DominoContactPoint>, IMessage, IEquatable<DominoContactPoint>, IDeepCloneable<DominoContactPoint>, IBufferMessage
	{
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00032BC0 File Offset: 0x00030DC0
		[DebuggerNonUserCode]
		public static MessageParser<DominoContactPoint> Parser
		{
			get
			{
				return DominoContactPoint._parser;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00032BD8 File Offset: 0x00030DD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[125];
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00032BFC File Offset: 0x00030DFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DominoContactPoint.Descriptor;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00032C13 File Offset: 0x00030E13
		[DebuggerNonUserCode]
		public DominoContactPoint()
		{
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00032C20 File Offset: 0x00030E20
		[DebuggerNonUserCode]
		public DominoContactPoint(DominoContactPoint other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sno1_ = other.sno1_;
			this.sno2_ = other.sno2_;
			this.material1_ = other.material1_;
			this.material2_ = other.material2_;
			this.velocity_ = other.velocity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00032C90 File Offset: 0x00030E90
		[DebuggerNonUserCode]
		public DominoContactPoint Clone()
		{
			return new DominoContactPoint(this);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00032CA8 File Offset: 0x00030EA8
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00032CD9 File Offset: 0x00030ED9
		[DebuggerNonUserCode]
		public int Sno1
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int sno1DefaultValue;
				if (flag)
				{
					sno1DefaultValue = this.sno1_;
				}
				else
				{
					sno1DefaultValue = DominoContactPoint.Sno1DefaultValue;
				}
				return sno1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno1_ = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00032CF4 File Offset: 0x00030EF4
		[DebuggerNonUserCode]
		public bool HasSno1
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00032D11 File Offset: 0x00030F11
		[DebuggerNonUserCode]
		public void ClearSno1()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00032D24 File Offset: 0x00030F24
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00032D55 File Offset: 0x00030F55
		[DebuggerNonUserCode]
		public int Sno2
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int sno2DefaultValue;
				if (flag)
				{
					sno2DefaultValue = this.sno2_;
				}
				else
				{
					sno2DefaultValue = DominoContactPoint.Sno2DefaultValue;
				}
				return sno2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.sno2_ = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00032D70 File Offset: 0x00030F70
		[DebuggerNonUserCode]
		public bool HasSno2
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00032D8D File Offset: 0x00030F8D
		[DebuggerNonUserCode]
		public void ClearSno2()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00032DA0 File Offset: 0x00030FA0
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00032DD1 File Offset: 0x00030FD1
		[DebuggerNonUserCode]
		public int Material1
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int material1DefaultValue;
				if (flag)
				{
					material1DefaultValue = this.material1_;
				}
				else
				{
					material1DefaultValue = DominoContactPoint.Material1DefaultValue;
				}
				return material1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.material1_ = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00032DEC File Offset: 0x00030FEC
		[DebuggerNonUserCode]
		public bool HasMaterial1
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00032E09 File Offset: 0x00031009
		[DebuggerNonUserCode]
		public void ClearMaterial1()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00032E1C File Offset: 0x0003101C
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00032E4D File Offset: 0x0003104D
		[DebuggerNonUserCode]
		public int Material2
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int material2DefaultValue;
				if (flag)
				{
					material2DefaultValue = this.material2_;
				}
				else
				{
					material2DefaultValue = DominoContactPoint.Material2DefaultValue;
				}
				return material2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.material2_ = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00032E68 File Offset: 0x00031068
		[DebuggerNonUserCode]
		public bool HasMaterial2
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00032E85 File Offset: 0x00031085
		[DebuggerNonUserCode]
		public void ClearMaterial2()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00032E98 File Offset: 0x00031098
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00032ECA File Offset: 0x000310CA
		[DebuggerNonUserCode]
		public float Velocity
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float velocityDefaultValue;
				if (flag)
				{
					velocityDefaultValue = this.velocity_;
				}
				else
				{
					velocityDefaultValue = DominoContactPoint.VelocityDefaultValue;
				}
				return velocityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.velocity_ = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00032EE4 File Offset: 0x000310E4
		[DebuggerNonUserCode]
		public bool HasVelocity
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00032F02 File Offset: 0x00031102
		[DebuggerNonUserCode]
		public void ClearVelocity()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00032F14 File Offset: 0x00031114
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DominoContactPoint);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00032F34 File Offset: 0x00031134
		[DebuggerNonUserCode]
		public bool Equals(DominoContactPoint other)
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
					bool flag4 = this.Sno1 != other.Sno1;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Sno2 != other.Sno2;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Material1 != other.Material1;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Material2 != other.Material2;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Velocity, other.Velocity);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00033008 File Offset: 0x00031208
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSno = this.HasSno1;
			if (hasSno)
			{
				num ^= this.Sno1.GetHashCode();
			}
			bool hasSno2 = this.HasSno2;
			if (hasSno2)
			{
				num ^= this.Sno2.GetHashCode();
			}
			bool hasMaterial = this.HasMaterial1;
			if (hasMaterial)
			{
				num ^= this.Material1.GetHashCode();
			}
			bool hasMaterial2 = this.HasMaterial2;
			if (hasMaterial2)
			{
				num ^= this.Material2.GetHashCode();
			}
			bool hasVelocity = this.HasVelocity;
			if (hasVelocity)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Velocity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000330D0 File Offset: 0x000312D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000330E8 File Offset: 0x000312E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000330F4 File Offset: 0x000312F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSno = this.HasSno1;
			if (hasSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Sno1);
			}
			bool hasSno2 = this.HasSno2;
			if (hasSno2)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Sno2);
			}
			bool hasMaterial = this.HasMaterial1;
			if (hasMaterial)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Material1);
			}
			bool hasMaterial2 = this.HasMaterial2;
			if (hasMaterial2)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Material2);
			}
			bool hasVelocity = this.HasVelocity;
			if (hasVelocity)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Velocity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000331CC File Offset: 0x000313CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSno = this.HasSno1;
			if (hasSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sno1);
			}
			bool hasSno2 = this.HasSno2;
			if (hasSno2)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sno2);
			}
			bool hasMaterial = this.HasMaterial1;
			if (hasMaterial)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Material1);
			}
			bool hasMaterial2 = this.HasMaterial2;
			if (hasMaterial2)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Material2);
			}
			bool hasVelocity = this.HasVelocity;
			if (hasVelocity)
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

		// Token: 0x06000D91 RID: 3473 RVA: 0x00033288 File Offset: 0x00031488
		[DebuggerNonUserCode]
		public void MergeFrom(DominoContactPoint other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSno = other.HasSno1;
				if (hasSno)
				{
					this.Sno1 = other.Sno1;
				}
				bool hasSno2 = other.HasSno2;
				if (hasSno2)
				{
					this.Sno2 = other.Sno2;
				}
				bool hasMaterial = other.HasMaterial1;
				if (hasMaterial)
				{
					this.Material1 = other.Material1;
				}
				bool hasMaterial2 = other.HasMaterial2;
				if (hasMaterial2)
				{
					this.Material2 = other.Material2;
				}
				bool hasVelocity = other.HasVelocity;
				if (hasVelocity)
				{
					this.Velocity = other.Velocity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0003333C File Offset: 0x0003153C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00033348 File Offset: 0x00031548
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.Sno2 = input.ReadInt32();
					}
					else
					{
						this.Sno1 = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 45U)
						{
							goto IL_0032;
						}
						this.Velocity = input.ReadFloat();
					}
					else
					{
						this.Material2 = input.ReadInt32();
					}
				}
				else
				{
					this.Material1 = input.ReadInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000563 RID: 1379
		private static readonly MessageParser<DominoContactPoint> _parser = new MessageParser<DominoContactPoint>(() => new DominoContactPoint());

		// Token: 0x04000564 RID: 1380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000565 RID: 1381
		private int _hasBits0;

		// Token: 0x04000566 RID: 1382
		public const int Sno1FieldNumber = 1;

		// Token: 0x04000567 RID: 1383
		private static readonly int Sno1DefaultValue = 0;

		// Token: 0x04000568 RID: 1384
		private int sno1_;

		// Token: 0x04000569 RID: 1385
		public const int Sno2FieldNumber = 2;

		// Token: 0x0400056A RID: 1386
		private static readonly int Sno2DefaultValue = 0;

		// Token: 0x0400056B RID: 1387
		private int sno2_;

		// Token: 0x0400056C RID: 1388
		public const int Material1FieldNumber = 3;

		// Token: 0x0400056D RID: 1389
		private static readonly int Material1DefaultValue = 0;

		// Token: 0x0400056E RID: 1390
		private int material1_;

		// Token: 0x0400056F RID: 1391
		public const int Material2FieldNumber = 4;

		// Token: 0x04000570 RID: 1392
		private static readonly int Material2DefaultValue = 0;

		// Token: 0x04000571 RID: 1393
		private int material2_;

		// Token: 0x04000572 RID: 1394
		public const int VelocityFieldNumber = 5;

		// Token: 0x04000573 RID: 1395
		private static readonly float VelocityDefaultValue = 0f;

		// Token: 0x04000574 RID: 1396
		private float velocity_;
	}
}
