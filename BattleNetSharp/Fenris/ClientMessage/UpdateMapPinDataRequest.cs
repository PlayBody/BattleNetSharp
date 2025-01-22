using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000263 RID: 611
	public sealed class UpdateMapPinDataRequest : IMessage<UpdateMapPinDataRequest>, IMessage, IEquatable<UpdateMapPinDataRequest>, IDeepCloneable<UpdateMapPinDataRequest>, IBufferMessage
	{
		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x000FFA88 File Offset: 0x000FDC88
		[DebuggerNonUserCode]
		public static MessageParser<UpdateMapPinDataRequest> Parser
		{
			get
			{
				return UpdateMapPinDataRequest._parser;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x000FFAA0 File Offset: 0x000FDCA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[83];
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060041A4 RID: 16804 RVA: 0x000FFAC4 File Offset: 0x000FDCC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMapPinDataRequest.Descriptor;
			}
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x000FFADB File Offset: 0x000FDCDB
		[DebuggerNonUserCode]
		public UpdateMapPinDataRequest()
		{
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x000FFAE8 File Offset: 0x000FDCE8
		[DebuggerNonUserCode]
		public UpdateMapPinDataRequest(UpdateMapPinDataRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.xPosition_ = other.xPosition_;
			this.yPosition_ = other.yPosition_;
			this.worldSno_ = other.worldSno_;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x000FFB4C File Offset: 0x000FDD4C
		[DebuggerNonUserCode]
		public UpdateMapPinDataRequest Clone()
		{
			return new UpdateMapPinDataRequest(this);
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x000FFB64 File Offset: 0x000FDD64
		// (set) Token: 0x060041A9 RID: 16809 RVA: 0x000FFB95 File Offset: 0x000FDD95
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
					xpositionDefaultValue = UpdateMapPinDataRequest.XPositionDefaultValue;
				}
				return xpositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.xPosition_ = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x000FFBB0 File Offset: 0x000FDDB0
		[DebuggerNonUserCode]
		public bool HasXPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x000FFBCD File Offset: 0x000FDDCD
		[DebuggerNonUserCode]
		public void ClearXPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x000FFBE0 File Offset: 0x000FDDE0
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x000FFC11 File Offset: 0x000FDE11
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
					ypositionDefaultValue = UpdateMapPinDataRequest.YPositionDefaultValue;
				}
				return ypositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.yPosition_ = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x000FFC2C File Offset: 0x000FDE2C
		[DebuggerNonUserCode]
		public bool HasYPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x000FFC49 File Offset: 0x000FDE49
		[DebuggerNonUserCode]
		public void ClearYPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x000FFC5C File Offset: 0x000FDE5C
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x000FFC8D File Offset: 0x000FDE8D
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
					worldSnoDefaultValue = UpdateMapPinDataRequest.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x000FFCA8 File Offset: 0x000FDEA8
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x000FFCC5 File Offset: 0x000FDEC5
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x000FFCD8 File Offset: 0x000FDED8
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x000FFD09 File Offset: 0x000FDF09
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = UpdateMapPinDataRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x000FFD24 File Offset: 0x000FDF24
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000FFD41 File Offset: 0x000FDF41
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000FFD54 File Offset: 0x000FDF54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMapPinDataRequest);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000FFD74 File Offset: 0x000FDF74
		[DebuggerNonUserCode]
		public bool Equals(UpdateMapPinDataRequest other)
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
								bool flag7 = this.GameAccountId != other.GameAccountId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000FFE20 File Offset: 0x000FE020
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
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000FFEC8 File Offset: 0x000FE0C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000FFEE0 File Offset: 0x000FE0E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000FFEEC File Offset: 0x000FE0EC
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
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x000FFFA0 File Offset: 0x000FE1A0
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
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0010003C File Offset: 0x000FE23C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateMapPinDataRequest other)
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
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x001000D2 File Offset: 0x000FE2D2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x001000E0 File Offset: 0x000FE2E0
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
					this.GameAccountId = input.ReadUInt32();
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

		// Token: 0x04001DC4 RID: 7620
		private static readonly MessageParser<UpdateMapPinDataRequest> _parser = new MessageParser<UpdateMapPinDataRequest>(() => new UpdateMapPinDataRequest());

		// Token: 0x04001DC5 RID: 7621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DC6 RID: 7622
		private int _hasBits0;

		// Token: 0x04001DC7 RID: 7623
		public const int XPositionFieldNumber = 1;

		// Token: 0x04001DC8 RID: 7624
		private static readonly int XPositionDefaultValue = 0;

		// Token: 0x04001DC9 RID: 7625
		private int xPosition_;

		// Token: 0x04001DCA RID: 7626
		public const int YPositionFieldNumber = 2;

		// Token: 0x04001DCB RID: 7627
		private static readonly int YPositionDefaultValue = 0;

		// Token: 0x04001DCC RID: 7628
		private int yPosition_;

		// Token: 0x04001DCD RID: 7629
		public const int WorldSnoFieldNumber = 3;

		// Token: 0x04001DCE RID: 7630
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x04001DCF RID: 7631
		private int worldSno_;

		// Token: 0x04001DD0 RID: 7632
		public const int GameAccountIdFieldNumber = 4;

		// Token: 0x04001DD1 RID: 7633
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001DD2 RID: 7634
		private uint gameAccountId_;
	}
}
