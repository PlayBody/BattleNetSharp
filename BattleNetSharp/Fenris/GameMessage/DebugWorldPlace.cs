using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CB RID: 459
	public sealed class DebugWorldPlace : IMessage<DebugWorldPlace>, IMessage, IEquatable<DebugWorldPlace>, IDeepCloneable<DebugWorldPlace>, IBufferMessage
	{
		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x000C194C File Offset: 0x000BFB4C
		[DebuggerNonUserCode]
		public static MessageParser<DebugWorldPlace> Parser
		{
			get
			{
				return DebugWorldPlace._parser;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000C1964 File Offset: 0x000BFB64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x000C1988 File Offset: 0x000BFB88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugWorldPlace.Descriptor;
			}
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000C199F File Offset: 0x000BFB9F
		[DebuggerNonUserCode]
		public DebugWorldPlace()
		{
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000C19AC File Offset: 0x000BFBAC
		[DebuggerNonUserCode]
		public DebugWorldPlace(DebugWorldPlace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.worldSno_ = other.worldSno_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000C1A10 File Offset: 0x000BFC10
		[DebuggerNonUserCode]
		public DebugWorldPlace Clone()
		{
			return new DebugWorldPlace(this);
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x000C1A28 File Offset: 0x000BFC28
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x000C1A59 File Offset: 0x000BFC59
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = DebugWorldPlace.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x000C1A74 File Offset: 0x000BFC74
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x000C1A91 File Offset: 0x000BFC91
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000C1AA4 File Offset: 0x000BFCA4
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x000C1AD5 File Offset: 0x000BFCD5
		[DebuggerNonUserCode]
		public float PosX
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float posXDefaultValue;
				if (flag)
				{
					posXDefaultValue = this.posX_;
				}
				else
				{
					posXDefaultValue = DebugWorldPlace.PosXDefaultValue;
				}
				return posXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.posX_ = value;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000C1AF0 File Offset: 0x000BFCF0
		[DebuggerNonUserCode]
		public bool HasPosX
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000C1B0D File Offset: 0x000BFD0D
		[DebuggerNonUserCode]
		public void ClearPosX()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000C1B20 File Offset: 0x000BFD20
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x000C1B51 File Offset: 0x000BFD51
		[DebuggerNonUserCode]
		public float PosY
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float posYDefaultValue;
				if (flag)
				{
					posYDefaultValue = this.posY_;
				}
				else
				{
					posYDefaultValue = DebugWorldPlace.PosYDefaultValue;
				}
				return posYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.posY_ = value;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x000C1B6C File Offset: 0x000BFD6C
		[DebuggerNonUserCode]
		public bool HasPosY
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000C1B89 File Offset: 0x000BFD89
		[DebuggerNonUserCode]
		public void ClearPosY()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000C1B9C File Offset: 0x000BFD9C
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x000C1BCD File Offset: 0x000BFDCD
		[DebuggerNonUserCode]
		public float PosZ
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float posZDefaultValue;
				if (flag)
				{
					posZDefaultValue = this.posZ_;
				}
				else
				{
					posZDefaultValue = DebugWorldPlace.PosZDefaultValue;
				}
				return posZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.posZ_ = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x000C1BE8 File Offset: 0x000BFDE8
		[DebuggerNonUserCode]
		public bool HasPosZ
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000C1C05 File Offset: 0x000BFE05
		[DebuggerNonUserCode]
		public void ClearPosZ()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000C1C18 File Offset: 0x000BFE18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugWorldPlace);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000C1C38 File Offset: 0x000BFE38
		[DebuggerNonUserCode]
		public bool Equals(DebugWorldPlace other)
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
					bool flag4 = this.WorldSno != other.WorldSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000C1D00 File Offset: 0x000BFF00
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
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
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosZ);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000C1DAC File Offset: 0x000BFFAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000C1DC4 File Offset: 0x000BFFC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000C1DD0 File Offset: 0x000BFFD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.WorldSno);
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.PosZ);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000C1E84 File Offset: 0x000C0084
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 5;
			}
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
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
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

		// Token: 0x06003104 RID: 12548 RVA: 0x000C1EFC File Offset: 0x000C00FC
		[DebuggerNonUserCode]
		public void MergeFrom(DebugWorldPlace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
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
				bool hasPosZ = other.HasPosZ;
				if (hasPosZ)
				{
					this.PosZ = other.PosZ;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x000C1F92 File Offset: 0x000C0192
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x000C1FA0 File Offset: 0x000C01A0
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
						this.PosX = input.ReadFloat();
					}
					else
					{
						this.WorldSno = input.ReadSFixed32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.PosZ = input.ReadFloat();
				}
				else
				{
					this.PosY = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400165D RID: 5725
		private static readonly MessageParser<DebugWorldPlace> _parser = new MessageParser<DebugWorldPlace>(() => new DebugWorldPlace());

		// Token: 0x0400165E RID: 5726
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400165F RID: 5727
		private int _hasBits0;

		// Token: 0x04001660 RID: 5728
		public const int WorldSnoFieldNumber = 1;

		// Token: 0x04001661 RID: 5729
		private static readonly int WorldSnoDefaultValue = -1;

		// Token: 0x04001662 RID: 5730
		private int worldSno_;

		// Token: 0x04001663 RID: 5731
		public const int PosXFieldNumber = 2;

		// Token: 0x04001664 RID: 5732
		private static readonly float PosXDefaultValue = 0f;

		// Token: 0x04001665 RID: 5733
		private float posX_;

		// Token: 0x04001666 RID: 5734
		public const int PosYFieldNumber = 3;

		// Token: 0x04001667 RID: 5735
		private static readonly float PosYDefaultValue = 0f;

		// Token: 0x04001668 RID: 5736
		private float posY_;

		// Token: 0x04001669 RID: 5737
		public const int PosZFieldNumber = 4;

		// Token: 0x0400166A RID: 5738
		private static readonly float PosZDefaultValue = 0f;

		// Token: 0x0400166B RID: 5739
		private float posZ_;
	}
}
