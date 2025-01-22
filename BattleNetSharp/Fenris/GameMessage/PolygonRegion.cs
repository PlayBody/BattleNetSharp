using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C4 RID: 452
	public sealed class PolygonRegion : IMessage<PolygonRegion>, IMessage, IEquatable<PolygonRegion>, IDeepCloneable<PolygonRegion>, IBufferMessage
	{
		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000BCCC8 File Offset: 0x000BAEC8
		[DebuggerNonUserCode]
		public static MessageParser<PolygonRegion> Parser
		{
			get
			{
				return PolygonRegion._parser;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000BCD04 File Offset: 0x000BAF04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolygonRegion.Descriptor;
			}
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000BCD1B File Offset: 0x000BAF1B
		[DebuggerNonUserCode]
		public PolygonRegion()
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000BCD30 File Offset: 0x000BAF30
		[DebuggerNonUserCode]
		public PolygonRegion(PolygonRegion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.centerPosX_ = other.centerPosX_;
			this.centerPosY_ = other.centerPosY_;
			this.points_ = other.points_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000BCD8C File Offset: 0x000BAF8C
		[DebuggerNonUserCode]
		public PolygonRegion Clone()
		{
			return new PolygonRegion(this);
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x000BCDA4 File Offset: 0x000BAFA4
		// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x000BCDD5 File Offset: 0x000BAFD5
		[DebuggerNonUserCode]
		public float CenterPosX
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float centerPosXDefaultValue;
				if (flag)
				{
					centerPosXDefaultValue = this.centerPosX_;
				}
				else
				{
					centerPosXDefaultValue = PolygonRegion.CenterPosXDefaultValue;
				}
				return centerPosXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.centerPosX_ = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x000BCDF0 File Offset: 0x000BAFF0
		[DebuggerNonUserCode]
		public bool HasCenterPosX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x000BCE0D File Offset: 0x000BB00D
		[DebuggerNonUserCode]
		public void ClearCenterPosX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x000BCE20 File Offset: 0x000BB020
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x000BCE51 File Offset: 0x000BB051
		[DebuggerNonUserCode]
		public float CenterPosY
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float centerPosYDefaultValue;
				if (flag)
				{
					centerPosYDefaultValue = this.centerPosY_;
				}
				else
				{
					centerPosYDefaultValue = PolygonRegion.CenterPosYDefaultValue;
				}
				return centerPosYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.centerPosY_ = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000BCE6C File Offset: 0x000BB06C
		[DebuggerNonUserCode]
		public bool HasCenterPosY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000BCE89 File Offset: 0x000BB089
		[DebuggerNonUserCode]
		public void ClearCenterPosY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000BCE9C File Offset: 0x000BB09C
		[DebuggerNonUserCode]
		public RepeatedField<PolygonRegionPoint> Points
		{
			get
			{
				return this.points_;
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000BCEB4 File Offset: 0x000BB0B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolygonRegion);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000BCED4 File Offset: 0x000BB0D4
		[DebuggerNonUserCode]
		public bool Equals(PolygonRegion other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CenterPosX, other.CenterPosX);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CenterPosY, other.CenterPosY);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.points_.Equals(other.points_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000BCF78 File Offset: 0x000BB178
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCenterPosX = this.HasCenterPosX;
			if (hasCenterPosX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CenterPosX);
			}
			bool hasCenterPosY = this.HasCenterPosY;
			if (hasCenterPosY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CenterPosY);
			}
			num ^= this.points_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000BCFF4 File Offset: 0x000BB1F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x000BD00C File Offset: 0x000BB20C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x000BD018 File Offset: 0x000BB218
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCenterPosX = this.HasCenterPosX;
			if (hasCenterPosX)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.CenterPosX);
			}
			bool hasCenterPosY = this.HasCenterPosY;
			if (hasCenterPosY)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.CenterPosY);
			}
			this.points_.WriteTo(ref output, PolygonRegion._repeated_points_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000BD098 File Offset: 0x000BB298
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCenterPosX = this.HasCenterPosX;
			if (hasCenterPosX)
			{
				num += 5;
			}
			bool hasCenterPosY = this.HasCenterPosY;
			if (hasCenterPosY)
			{
				num += 5;
			}
			num += this.points_.CalculateSize(PolygonRegion._repeated_points_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000BD100 File Offset: 0x000BB300
		[DebuggerNonUserCode]
		public void MergeFrom(PolygonRegion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCenterPosX = other.HasCenterPosX;
				if (hasCenterPosX)
				{
					this.CenterPosX = other.CenterPosX;
				}
				bool hasCenterPosY = other.HasCenterPosY;
				if (hasCenterPosY)
				{
					this.CenterPosY = other.CenterPosY;
				}
				this.points_.Add(other.points_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x000BD174 File Offset: 0x000BB374
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x000BD180 File Offset: 0x000BB380
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.points_.AddEntriesFrom(ref input, PolygonRegion._repeated_points_codec);
						}
					}
					else
					{
						this.CenterPosY = input.ReadFloat();
					}
				}
				else
				{
					this.CenterPosX = input.ReadFloat();
				}
			}
		}

		// Token: 0x040015AC RID: 5548
		private static readonly MessageParser<PolygonRegion> _parser = new MessageParser<PolygonRegion>(() => new PolygonRegion());

		// Token: 0x040015AD RID: 5549
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015AE RID: 5550
		private int _hasBits0;

		// Token: 0x040015AF RID: 5551
		public const int CenterPosXFieldNumber = 1;

		// Token: 0x040015B0 RID: 5552
		private static readonly float CenterPosXDefaultValue = 0f;

		// Token: 0x040015B1 RID: 5553
		private float centerPosX_;

		// Token: 0x040015B2 RID: 5554
		public const int CenterPosYFieldNumber = 2;

		// Token: 0x040015B3 RID: 5555
		private static readonly float CenterPosYDefaultValue = 0f;

		// Token: 0x040015B4 RID: 5556
		private float centerPosY_;

		// Token: 0x040015B5 RID: 5557
		public const int PointsFieldNumber = 3;

		// Token: 0x040015B6 RID: 5558
		private static readonly FieldCodec<PolygonRegionPoint> _repeated_points_codec = FieldCodec.ForMessage<PolygonRegionPoint>(26U, PolygonRegionPoint.Parser);

		// Token: 0x040015B7 RID: 5559
		private readonly RepeatedField<PolygonRegionPoint> points_ = new RepeatedField<PolygonRegionPoint>();
	}
}
