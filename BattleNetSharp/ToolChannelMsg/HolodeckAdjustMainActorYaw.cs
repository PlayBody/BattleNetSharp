using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000024 RID: 36
	public sealed class HolodeckAdjustMainActorYaw : IMessage<HolodeckAdjustMainActorYaw>, IMessage, IEquatable<HolodeckAdjustMainActorYaw>, IDeepCloneable<HolodeckAdjustMainActorYaw>, IBufferMessage
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		[DebuggerNonUserCode]
		public static MessageParser<HolodeckAdjustMainActorYaw> Parser
		{
			get
			{
				return HolodeckAdjustMainActorYaw._parser;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HolodeckAdjustMainActorYaw.Descriptor;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000D807 File Offset: 0x0000BA07
		[DebuggerNonUserCode]
		public HolodeckAdjustMainActorYaw()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000D811 File Offset: 0x0000BA11
		[DebuggerNonUserCode]
		public HolodeckAdjustMainActorYaw(HolodeckAdjustMainActorYaw other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.holodeckId_ = other.holodeckId_;
			this.angle_ = other.angle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000D850 File Offset: 0x0000BA50
		[DebuggerNonUserCode]
		public HolodeckAdjustMainActorYaw Clone()
		{
			return new HolodeckAdjustMainActorYaw(this);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000D868 File Offset: 0x0000BA68
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000D899 File Offset: 0x0000BA99
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
					holodeckIdDefaultValue = HolodeckAdjustMainActorYaw.HolodeckIdDefaultValue;
				}
				return holodeckIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.holodeckId_ = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		[DebuggerNonUserCode]
		public bool HasHolodeckId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000D8D1 File Offset: 0x0000BAD1
		[DebuggerNonUserCode]
		public void ClearHolodeckId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000D915 File Offset: 0x0000BB15
		[DebuggerNonUserCode]
		public float Angle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float angleDefaultValue;
				if (flag)
				{
					angleDefaultValue = this.angle_;
				}
				else
				{
					angleDefaultValue = HolodeckAdjustMainActorYaw.AngleDefaultValue;
				}
				return angleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.angle_ = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000D930 File Offset: 0x0000BB30
		[DebuggerNonUserCode]
		public bool HasAngle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000D94D File Offset: 0x0000BB4D
		[DebuggerNonUserCode]
		public void ClearAngle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000D960 File Offset: 0x0000BB60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HolodeckAdjustMainActorYaw);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000D980 File Offset: 0x0000BB80
		[DebuggerNonUserCode]
		public bool Equals(HolodeckAdjustMainActorYaw other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Angle, other.Angle);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000D9FC File Offset: 0x0000BBFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num ^= this.HolodeckId.GetHashCode();
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Angle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000DA84 File Offset: 0x0000BC84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000DA90 File Offset: 0x0000BC90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HolodeckId);
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Angle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HolodeckId);
			}
			bool hasAngle = this.HasAngle;
			if (hasAngle)
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

		// Token: 0x060001FF RID: 511 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[DebuggerNonUserCode]
		public void MergeFrom(HolodeckAdjustMainActorYaw other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHolodeckId = other.HasHolodeckId;
				if (hasHolodeckId)
				{
					this.HolodeckId = other.HolodeckId;
				}
				bool hasAngle = other.HasAngle;
				if (hasAngle)
				{
					this.Angle = other.Angle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000DBC2 File Offset: 0x0000BDC2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Angle = input.ReadFloat();
					}
				}
				else
				{
					this.HolodeckId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly MessageParser<HolodeckAdjustMainActorYaw> _parser = new MessageParser<HolodeckAdjustMainActorYaw>(() => new HolodeckAdjustMainActorYaw());

		// Token: 0x040000D1 RID: 209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000D2 RID: 210
		private int _hasBits0;

		// Token: 0x040000D3 RID: 211
		public const int HolodeckIdFieldNumber = 1;

		// Token: 0x040000D4 RID: 212
		private static readonly int HolodeckIdDefaultValue = 0;

		// Token: 0x040000D5 RID: 213
		private int holodeckId_;

		// Token: 0x040000D6 RID: 214
		public const int AngleFieldNumber = 2;

		// Token: 0x040000D7 RID: 215
		private static readonly float AngleDefaultValue = 0f;

		// Token: 0x040000D8 RID: 216
		private float angle_;
	}
}
