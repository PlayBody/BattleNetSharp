using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C3 RID: 451
	public sealed class PolygonRegionPoint : IMessage<PolygonRegionPoint>, IMessage, IEquatable<PolygonRegionPoint>, IDeepCloneable<PolygonRegionPoint>, IBufferMessage
	{
		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x000BC818 File Offset: 0x000BAA18
		[DebuggerNonUserCode]
		public static MessageParser<PolygonRegionPoint> Parser
		{
			get
			{
				return PolygonRegionPoint._parser;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002FB6 RID: 12214 RVA: 0x000BC830 File Offset: 0x000BAA30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x000BC854 File Offset: 0x000BAA54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolygonRegionPoint.Descriptor;
			}
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000BC86B File Offset: 0x000BAA6B
		[DebuggerNonUserCode]
		public PolygonRegionPoint()
		{
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000BC875 File Offset: 0x000BAA75
		[DebuggerNonUserCode]
		public PolygonRegionPoint(PolygonRegionPoint other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000BC8B4 File Offset: 0x000BAAB4
		[DebuggerNonUserCode]
		public PolygonRegionPoint Clone()
		{
			return new PolygonRegionPoint(this);
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000BC8CC File Offset: 0x000BAACC
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x000BC8FD File Offset: 0x000BAAFD
		[DebuggerNonUserCode]
		public float PosX
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float posXDefaultValue;
				if (flag)
				{
					posXDefaultValue = this.posX_;
				}
				else
				{
					posXDefaultValue = PolygonRegionPoint.PosXDefaultValue;
				}
				return posXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.posX_ = value;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000BC918 File Offset: 0x000BAB18
		[DebuggerNonUserCode]
		public bool HasPosX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000BC935 File Offset: 0x000BAB35
		[DebuggerNonUserCode]
		public void ClearPosX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000BC948 File Offset: 0x000BAB48
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x000BC979 File Offset: 0x000BAB79
		[DebuggerNonUserCode]
		public float PosY
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float posYDefaultValue;
				if (flag)
				{
					posYDefaultValue = this.posY_;
				}
				else
				{
					posYDefaultValue = PolygonRegionPoint.PosYDefaultValue;
				}
				return posYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.posY_ = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000BC994 File Offset: 0x000BAB94
		[DebuggerNonUserCode]
		public bool HasPosY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x000BC9B1 File Offset: 0x000BABB1
		[DebuggerNonUserCode]
		public void ClearPosY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x000BC9C4 File Offset: 0x000BABC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolygonRegionPoint);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000BC9E4 File Offset: 0x000BABE4
		[DebuggerNonUserCode]
		public bool Equals(PolygonRegionPoint other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x000BCA68 File Offset: 0x000BAC68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000BCAD8 File Offset: 0x000BACD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000BCAF0 File Offset: 0x000BACF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x000BCAFC File Offset: 0x000BACFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x000BCB6C File Offset: 0x000BAD6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num += 5;
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
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

		// Token: 0x06002FCA RID: 12234 RVA: 0x000BCBC0 File Offset: 0x000BADC0
		[DebuggerNonUserCode]
		public void MergeFrom(PolygonRegionPoint other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPosX = other.HasPosX;
				if (hasPosX)
				{
					this.PosX = other.PosX;
				}
				bool hasPosY = other.HasPosY;
				if (hasPosY)
				{
					this.PosY = other.PosY;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000BCC22 File Offset: 0x000BAE22
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000BCC30 File Offset: 0x000BAE30
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
						this.PosY = input.ReadFloat();
					}
				}
				else
				{
					this.PosX = input.ReadFloat();
				}
			}
		}

		// Token: 0x040015A3 RID: 5539
		private static readonly MessageParser<PolygonRegionPoint> _parser = new MessageParser<PolygonRegionPoint>(() => new PolygonRegionPoint());

		// Token: 0x040015A4 RID: 5540
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015A5 RID: 5541
		private int _hasBits0;

		// Token: 0x040015A6 RID: 5542
		public const int PosXFieldNumber = 1;

		// Token: 0x040015A7 RID: 5543
		private static readonly float PosXDefaultValue = 0f;

		// Token: 0x040015A8 RID: 5544
		private float posX_;

		// Token: 0x040015A9 RID: 5545
		public const int PosYFieldNumber = 2;

		// Token: 0x040015AA RID: 5546
		private static readonly float PosYDefaultValue = 0f;

		// Token: 0x040015AB RID: 5547
		private float posY_;
	}
}
