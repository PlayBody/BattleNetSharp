using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000028 RID: 40
	public sealed class Vector3 : IMessage<Vector3>, IMessage, IEquatable<Vector3>, IDeepCloneable<Vector3>, IBufferMessage
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000E920 File Offset: 0x0000CB20
		[DebuggerNonUserCode]
		public static MessageParser<Vector3> Parser
		{
			get
			{
				return Vector3._parser;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000E938 File Offset: 0x0000CB38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000E95C File Offset: 0x0000CB5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vector3.Descriptor;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000E973 File Offset: 0x0000CB73
		[DebuggerNonUserCode]
		public Vector3()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000E980 File Offset: 0x0000CB80
		[DebuggerNonUserCode]
		public Vector3(Vector3 other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		[DebuggerNonUserCode]
		public Vector3 Clone()
		{
			return new Vector3(this);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000EA21 File Offset: 0x0000CC21
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
					xdefaultValue = Vector3.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.x_ = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000EA59 File Offset: 0x0000CC59
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000EA9D File Offset: 0x0000CC9D
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
					ydefaultValue = Vector3.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.y_ = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000EB19 File Offset: 0x0000CD19
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
					zdefaultValue = Vector3.ZDefaultValue;
				}
				return zdefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.z_ = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000EB34 File Offset: 0x0000CD34
		[DebuggerNonUserCode]
		public bool HasZ
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000EB51 File Offset: 0x0000CD51
		[DebuggerNonUserCode]
		public void ClearZ()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000EB64 File Offset: 0x0000CD64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vector3);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000EB84 File Offset: 0x0000CD84
		[DebuggerNonUserCode]
		public bool Equals(Vector3 other)
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

		// Token: 0x0600025E RID: 606 RVA: 0x0000EC2C File Offset: 0x0000CE2C
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

		// Token: 0x0600025F RID: 607 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
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

		// Token: 0x06000262 RID: 610 RVA: 0x0000ED70 File Offset: 0x0000CF70
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

		// Token: 0x06000263 RID: 611 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[DebuggerNonUserCode]
		public void MergeFrom(Vector3 other)
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

		// Token: 0x06000264 RID: 612 RVA: 0x0000EE53 File Offset: 0x0000D053
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000EE60 File Offset: 0x0000D060
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

		// Token: 0x040000F1 RID: 241
		private static readonly MessageParser<Vector3> _parser = new MessageParser<Vector3>(() => new Vector3());

		// Token: 0x040000F2 RID: 242
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000F3 RID: 243
		private int _hasBits0;

		// Token: 0x040000F4 RID: 244
		public const int XFieldNumber = 1;

		// Token: 0x040000F5 RID: 245
		private static readonly float XDefaultValue = 0f;

		// Token: 0x040000F6 RID: 246
		private float x_;

		// Token: 0x040000F7 RID: 247
		public const int YFieldNumber = 2;

		// Token: 0x040000F8 RID: 248
		private static readonly float YDefaultValue = 0f;

		// Token: 0x040000F9 RID: 249
		private float y_;

		// Token: 0x040000FA RID: 250
		public const int ZFieldNumber = 3;

		// Token: 0x040000FB RID: 251
		private static readonly float ZDefaultValue = 0f;

		// Token: 0x040000FC RID: 252
		private float z_;
	}
}
