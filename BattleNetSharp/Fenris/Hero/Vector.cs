using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017D RID: 381
	public sealed class Vector : IMessage<Vector>, IMessage, IEquatable<Vector>, IDeepCloneable<Vector>, IBufferMessage
	{
		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0009C594 File Offset: 0x0009A794
		[DebuggerNonUserCode]
		public static MessageParser<Vector> Parser
		{
			get
			{
				return Vector._parser;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x0009C5AC File Offset: 0x0009A7AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0009C5D0 File Offset: 0x0009A7D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vector.Descriptor;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0009C5E7 File Offset: 0x0009A7E7
		[DebuggerNonUserCode]
		public Vector()
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0009C5F4 File Offset: 0x0009A7F4
		[DebuggerNonUserCode]
		public Vector(Vector other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0009C64C File Offset: 0x0009A84C
		[DebuggerNonUserCode]
		public Vector Clone()
		{
			return new Vector(this);
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x0009C664 File Offset: 0x0009A864
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x0009C695 File Offset: 0x0009A895
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
					xdefaultValue = Vector.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.x_ = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0009C6B0 File Offset: 0x0009A8B0
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0009C6CD File Offset: 0x0009A8CD
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x0009C6E0 File Offset: 0x0009A8E0
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x0009C711 File Offset: 0x0009A911
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
					ydefaultValue = Vector.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.y_ = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x0009C72C File Offset: 0x0009A92C
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0009C749 File Offset: 0x0009A949
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0009C75C File Offset: 0x0009A95C
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x0009C78D File Offset: 0x0009A98D
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
					zdefaultValue = Vector.ZDefaultValue;
				}
				return zdefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.z_ = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0009C7A8 File Offset: 0x0009A9A8
		[DebuggerNonUserCode]
		public bool HasZ
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x0009C7C5 File Offset: 0x0009A9C5
		[DebuggerNonUserCode]
		public void ClearZ()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x0009C7D8 File Offset: 0x0009A9D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vector);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x0009C7F8 File Offset: 0x0009A9F8
		[DebuggerNonUserCode]
		public bool Equals(Vector other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0009C8A0 File Offset: 0x0009AAA0
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x0009C930 File Offset: 0x0009AB30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x0009C948 File Offset: 0x0009AB48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0009C954 File Offset: 0x0009AB54
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x0009C9E4 File Offset: 0x0009ABE4
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x0009CA4C File Offset: 0x0009AC4C
		[DebuggerNonUserCode]
		public void MergeFrom(Vector other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0009CAC7 File Offset: 0x0009ACC7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0009CAD4 File Offset: 0x0009ACD4
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
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Z = input.ReadFloat();
						}
					}
					else
					{
						this.Y = input.ReadFloat();
					}
				}
				else
				{
					this.X = input.ReadFloat();
				}
			}
		}

		// Token: 0x040011C9 RID: 4553
		private static readonly MessageParser<Vector> _parser = new MessageParser<Vector>(() => new Vector());

		// Token: 0x040011CA RID: 4554
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011CB RID: 4555
		private int _hasBits0;

		// Token: 0x040011CC RID: 4556
		public const int XFieldNumber = 1;

		// Token: 0x040011CD RID: 4557
		private static readonly float XDefaultValue = 0f;

		// Token: 0x040011CE RID: 4558
		private float x_;

		// Token: 0x040011CF RID: 4559
		public const int YFieldNumber = 2;

		// Token: 0x040011D0 RID: 4560
		private static readonly float YDefaultValue = 0f;

		// Token: 0x040011D1 RID: 4561
		private float y_;

		// Token: 0x040011D2 RID: 4562
		public const int ZFieldNumber = 3;

		// Token: 0x040011D3 RID: 4563
		private static readonly float ZDefaultValue = 0f;

		// Token: 0x040011D4 RID: 4564
		private float z_;
	}
}
