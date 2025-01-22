using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F6 RID: 758
	public sealed class ParagonBoardPreviewRotate : IMessage<ParagonBoardPreviewRotate>, IMessage, IEquatable<ParagonBoardPreviewRotate>, IDeepCloneable<ParagonBoardPreviewRotate>, IBufferMessage
	{
		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x00132BF8 File Offset: 0x00130DF8
		[DebuggerNonUserCode]
		public static MessageParser<ParagonBoardPreviewRotate> Parser
		{
			get
			{
				return ParagonBoardPreviewRotate._parser;
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x00132C10 File Offset: 0x00130E10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ParagonBoardPreviewRotateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x00132C34 File Offset: 0x00130E34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParagonBoardPreviewRotate.Descriptor;
			}
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x00132C4B File Offset: 0x00130E4B
		[DebuggerNonUserCode]
		public ParagonBoardPreviewRotate()
		{
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00132C58 File Offset: 0x00130E58
		[DebuggerNonUserCode]
		public ParagonBoardPreviewRotate(ParagonBoardPreviewRotate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hero_ = ((other.hero_ != null) ? other.hero_.Clone() : null);
			this.snoPreviewBoard_ = other.snoPreviewBoard_;
			this.numRotations_ = other.numRotations_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00132CC0 File Offset: 0x00130EC0
		[DebuggerNonUserCode]
		public ParagonBoardPreviewRotate Clone()
		{
			return new ParagonBoardPreviewRotate(this);
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x00132CD8 File Offset: 0x00130ED8
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x00132CF0 File Offset: 0x00130EF0
		[DebuggerNonUserCode]
		public HeroInfo Hero
		{
			get
			{
				return this.hero_;
			}
			set
			{
				this.hero_ = value;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x00132CFC File Offset: 0x00130EFC
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x00132D2D File Offset: 0x00130F2D
		[DebuggerNonUserCode]
		public int SnoPreviewBoard
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoPreviewBoardDefaultValue;
				if (flag)
				{
					snoPreviewBoardDefaultValue = this.snoPreviewBoard_;
				}
				else
				{
					snoPreviewBoardDefaultValue = ParagonBoardPreviewRotate.SnoPreviewBoardDefaultValue;
				}
				return snoPreviewBoardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoPreviewBoard_ = value;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x00132D48 File Offset: 0x00130F48
		[DebuggerNonUserCode]
		public bool HasSnoPreviewBoard
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00132D65 File Offset: 0x00130F65
		[DebuggerNonUserCode]
		public void ClearSnoPreviewBoard()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x00132D78 File Offset: 0x00130F78
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x00132DA9 File Offset: 0x00130FA9
		[DebuggerNonUserCode]
		public uint NumRotations
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint numRotationsDefaultValue;
				if (flag)
				{
					numRotationsDefaultValue = this.numRotations_;
				}
				else
				{
					numRotationsDefaultValue = ParagonBoardPreviewRotate.NumRotationsDefaultValue;
				}
				return numRotationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.numRotations_ = value;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x00132DC4 File Offset: 0x00130FC4
		[DebuggerNonUserCode]
		public bool HasNumRotations
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00132DE1 File Offset: 0x00130FE1
		[DebuggerNonUserCode]
		public void ClearNumRotations()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x00132DF4 File Offset: 0x00130FF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParagonBoardPreviewRotate);
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x00132E14 File Offset: 0x00131014
		[DebuggerNonUserCode]
		public bool Equals(ParagonBoardPreviewRotate other)
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
					bool flag4 = !object.Equals(this.Hero, other.Hero);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoPreviewBoard != other.SnoPreviewBoard;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NumRotations != other.NumRotations;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00132EA4 File Offset: 0x001310A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num ^= this.Hero.GetHashCode();
			}
			bool hasSnoPreviewBoard = this.HasSnoPreviewBoard;
			if (hasSnoPreviewBoard)
			{
				num ^= this.SnoPreviewBoard.GetHashCode();
			}
			bool hasNumRotations = this.HasNumRotations;
			if (hasNumRotations)
			{
				num ^= this.NumRotations.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00132F30 File Offset: 0x00131130
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00132F48 File Offset: 0x00131148
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00132F54 File Offset: 0x00131154
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.hero_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Hero);
			}
			bool hasSnoPreviewBoard = this.HasSnoPreviewBoard;
			if (hasSnoPreviewBoard)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.SnoPreviewBoard);
			}
			bool hasNumRotations = this.HasNumRotations;
			if (hasNumRotations)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NumRotations);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00132FE8 File Offset: 0x001311E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Hero);
			}
			bool hasSnoPreviewBoard = this.HasSnoPreviewBoard;
			if (hasSnoPreviewBoard)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoPreviewBoard);
			}
			bool hasNumRotations = this.HasNumRotations;
			if (hasNumRotations)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NumRotations);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x00133078 File Offset: 0x00131278
		[DebuggerNonUserCode]
		public void MergeFrom(ParagonBoardPreviewRotate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.hero_ != null;
				if (flag2)
				{
					bool flag3 = this.hero_ == null;
					if (flag3)
					{
						this.Hero = new HeroInfo();
					}
					this.Hero.MergeFrom(other.Hero);
				}
				bool hasSnoPreviewBoard = other.HasSnoPreviewBoard;
				if (hasSnoPreviewBoard)
				{
					this.SnoPreviewBoard = other.SnoPreviewBoard;
				}
				bool hasNumRotations = other.HasNumRotations;
				if (hasNumRotations)
				{
					this.NumRotations = other.NumRotations;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x0013311B File Offset: 0x0013131B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00133128 File Offset: 0x00131328
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NumRotations = input.ReadUInt32();
						}
					}
					else
					{
						this.SnoPreviewBoard = input.ReadSInt32();
					}
				}
				else
				{
					bool flag = this.hero_ == null;
					if (flag)
					{
						this.Hero = new HeroInfo();
					}
					input.ReadMessage(this.Hero);
				}
			}
		}

		// Token: 0x040023E2 RID: 9186
		private static readonly MessageParser<ParagonBoardPreviewRotate> _parser = new MessageParser<ParagonBoardPreviewRotate>(() => new ParagonBoardPreviewRotate());

		// Token: 0x040023E3 RID: 9187
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023E4 RID: 9188
		private int _hasBits0;

		// Token: 0x040023E5 RID: 9189
		public const int HeroFieldNumber = 1;

		// Token: 0x040023E6 RID: 9190
		private HeroInfo hero_;

		// Token: 0x040023E7 RID: 9191
		public const int SnoPreviewBoardFieldNumber = 2;

		// Token: 0x040023E8 RID: 9192
		private static readonly int SnoPreviewBoardDefaultValue = 0;

		// Token: 0x040023E9 RID: 9193
		private int snoPreviewBoard_;

		// Token: 0x040023EA RID: 9194
		public const int NumRotationsFieldNumber = 3;

		// Token: 0x040023EB RID: 9195
		private static readonly uint NumRotationsDefaultValue = 0U;

		// Token: 0x040023EC RID: 9196
		private uint numRotations_;
	}
}
