using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000027 RID: 39
	public sealed class Vector2 : IMessage<Vector2>, IMessage, IEquatable<Vector2>, IDeepCloneable<Vector2>, IBufferMessage
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000E470 File Offset: 0x0000C670
		[DebuggerNonUserCode]
		public static MessageParser<Vector2> Parser
		{
			get
			{
				return Vector2._parser;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000E488 File Offset: 0x0000C688
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vector2.Descriptor;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000E4C3 File Offset: 0x0000C6C3
		[DebuggerNonUserCode]
		public Vector2()
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000E4CD File Offset: 0x0000C6CD
		[DebuggerNonUserCode]
		public Vector2(Vector2 other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000E50C File Offset: 0x0000C70C
		[DebuggerNonUserCode]
		public Vector2 Clone()
		{
			return new Vector2(this);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000E524 File Offset: 0x0000C724
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000E555 File Offset: 0x0000C755
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
					xdefaultValue = Vector2.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.x_ = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000E570 File Offset: 0x0000C770
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000E58D File Offset: 0x0000C78D
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000E5D1 File Offset: 0x0000C7D1
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
					ydefaultValue = Vector2.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.y_ = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000E609 File Offset: 0x0000C809
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000E61C File Offset: 0x0000C81C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vector2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000E63C File Offset: 0x0000C83C
		[DebuggerNonUserCode]
		public bool Equals(Vector2 other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000E730 File Offset: 0x0000C930
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000E748 File Offset: 0x0000C948
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000E754 File Offset: 0x0000C954
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000E818 File Offset: 0x0000CA18
		[DebuggerNonUserCode]
		public void MergeFrom(Vector2 other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000E87A File Offset: 0x0000CA7A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000E888 File Offset: 0x0000CA88
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x040000E8 RID: 232
		private static readonly MessageParser<Vector2> _parser = new MessageParser<Vector2>(() => new Vector2());

		// Token: 0x040000E9 RID: 233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000EA RID: 234
		private int _hasBits0;

		// Token: 0x040000EB RID: 235
		public const int XFieldNumber = 1;

		// Token: 0x040000EC RID: 236
		private static readonly float XDefaultValue = 0f;

		// Token: 0x040000ED RID: 237
		private float x_;

		// Token: 0x040000EE RID: 238
		public const int YFieldNumber = 2;

		// Token: 0x040000EF RID: 239
		private static readonly float YDefaultValue = 0f;

		// Token: 0x040000F0 RID: 240
		private float y_;
	}
}
