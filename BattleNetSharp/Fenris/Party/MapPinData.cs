using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Party
{
	// Token: 0x0200013B RID: 315
	public sealed class MapPinData : IMessage<MapPinData>, IMessage, IEquatable<MapPinData>, IDeepCloneable<MapPinData>, IBufferMessage
	{
		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0007E39C File Offset: 0x0007C59C
		[DebuggerNonUserCode]
		public static MessageParser<MapPinData> Parser
		{
			get
			{
				return MapPinData._parser;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0007E3B4 File Offset: 0x0007C5B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PartyReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapPinData.Descriptor;
			}
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0007E3EF File Offset: 0x0007C5EF
		[DebuggerNonUserCode]
		public MapPinData()
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0007E3FC File Offset: 0x0007C5FC
		[DebuggerNonUserCode]
		public MapPinData(MapPinData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.xPosition_ = other.xPosition_;
			this.yPosition_ = other.yPosition_;
			this.worldSno_ = other.worldSno_;
			this.colorId_ = other.colorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0007E460 File Offset: 0x0007C660
		[DebuggerNonUserCode]
		public MapPinData Clone()
		{
			return new MapPinData(this);
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0007E478 File Offset: 0x0007C678
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x0007E4A9 File Offset: 0x0007C6A9
		[DebuggerNonUserCode]
		public int XPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int xpositionDefaultValue;
				if (flag)
				{
					xpositionDefaultValue = this.xPosition_;
				}
				else
				{
					xpositionDefaultValue = MapPinData.XPositionDefaultValue;
				}
				return xpositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.xPosition_ = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0007E4C4 File Offset: 0x0007C6C4
		[DebuggerNonUserCode]
		public bool HasXPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0007E4E1 File Offset: 0x0007C6E1
		[DebuggerNonUserCode]
		public void ClearXPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0007E4F4 File Offset: 0x0007C6F4
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x0007E525 File Offset: 0x0007C725
		[DebuggerNonUserCode]
		public int YPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int ypositionDefaultValue;
				if (flag)
				{
					ypositionDefaultValue = this.yPosition_;
				}
				else
				{
					ypositionDefaultValue = MapPinData.YPositionDefaultValue;
				}
				return ypositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.yPosition_ = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0007E540 File Offset: 0x0007C740
		[DebuggerNonUserCode]
		public bool HasYPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0007E55D File Offset: 0x0007C75D
		[DebuggerNonUserCode]
		public void ClearYPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0007E570 File Offset: 0x0007C770
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x0007E5A1 File Offset: 0x0007C7A1
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = MapPinData.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0007E5BC File Offset: 0x0007C7BC
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0007E5D9 File Offset: 0x0007C7D9
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0007E5EC File Offset: 0x0007C7EC
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0007E61D File Offset: 0x0007C81D
		[DebuggerNonUserCode]
		public int ColorId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int colorIdDefaultValue;
				if (flag)
				{
					colorIdDefaultValue = this.colorId_;
				}
				else
				{
					colorIdDefaultValue = MapPinData.ColorIdDefaultValue;
				}
				return colorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.colorId_ = value;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0007E638 File Offset: 0x0007C838
		[DebuggerNonUserCode]
		public bool HasColorId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0007E655 File Offset: 0x0007C855
		[DebuggerNonUserCode]
		public void ClearColorId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0007E668 File Offset: 0x0007C868
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapPinData);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0007E688 File Offset: 0x0007C888
		[DebuggerNonUserCode]
		public bool Equals(MapPinData other)
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
					bool flag4 = this.XPosition != other.XPosition;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.YPosition != other.YPosition;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.WorldSno != other.WorldSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ColorId != other.ColorId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0007E734 File Offset: 0x0007C934
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				num ^= this.XPosition.GetHashCode();
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				num ^= this.YPosition.GetHashCode();
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool hasColorId = this.HasColorId;
			if (hasColorId)
			{
				num ^= this.ColorId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x0007E7DC File Offset: 0x0007C9DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0007E800 File Offset: 0x0007CA00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.XPosition);
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.YPosition);
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.WorldSno);
			}
			bool hasColorId = this.HasColorId;
			if (hasColorId)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ColorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0007E8B4 File Offset: 0x0007CAB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.XPosition);
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.YPosition);
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 5;
			}
			bool hasColorId = this.HasColorId;
			if (hasColorId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ColorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0007E950 File Offset: 0x0007CB50
		[DebuggerNonUserCode]
		public void MergeFrom(MapPinData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasXPosition = other.HasXPosition;
				if (hasXPosition)
				{
					this.XPosition = other.XPosition;
				}
				bool hasYPosition = other.HasYPosition;
				if (hasYPosition)
				{
					this.YPosition = other.YPosition;
				}
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				bool hasColorId = other.HasColorId;
				if (hasColorId)
				{
					this.ColorId = other.ColorId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0007E9E6 File Offset: 0x0007CBE6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
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
							goto IL_0028;
						}
						this.YPosition = input.ReadInt32();
					}
					else
					{
						this.XPosition = input.ReadInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ColorId = input.ReadInt32();
				}
				else
				{
					this.WorldSno = input.ReadSFixed32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E48 RID: 3656
		private static readonly MessageParser<MapPinData> _parser = new MessageParser<MapPinData>(() => new MapPinData());

		// Token: 0x04000E49 RID: 3657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E4A RID: 3658
		private int _hasBits0;

		// Token: 0x04000E4B RID: 3659
		public const int XPositionFieldNumber = 1;

		// Token: 0x04000E4C RID: 3660
		private static readonly int XPositionDefaultValue = 0;

		// Token: 0x04000E4D RID: 3661
		private int xPosition_;

		// Token: 0x04000E4E RID: 3662
		public const int YPositionFieldNumber = 2;

		// Token: 0x04000E4F RID: 3663
		private static readonly int YPositionDefaultValue = 0;

		// Token: 0x04000E50 RID: 3664
		private int yPosition_;

		// Token: 0x04000E51 RID: 3665
		public const int WorldSnoFieldNumber = 3;

		// Token: 0x04000E52 RID: 3666
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x04000E53 RID: 3667
		private int worldSno_;

		// Token: 0x04000E54 RID: 3668
		public const int ColorIdFieldNumber = 4;

		// Token: 0x04000E55 RID: 3669
		private static readonly int ColorIdDefaultValue = 0;

		// Token: 0x04000E56 RID: 3670
		private int colorId_;
	}
}
