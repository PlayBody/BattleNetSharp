using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A2 RID: 418
	public sealed class SavedItemLink : IMessage<SavedItemLink>, IMessage, IEquatable<SavedItemLink>, IDeepCloneable<SavedItemLink>, IBufferMessage
	{
		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x000AD8F0 File Offset: 0x000ABAF0
		[DebuggerNonUserCode]
		public static MessageParser<SavedItemLink> Parser
		{
			get
			{
				return SavedItemLink._parser;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000AD908 File Offset: 0x000ABB08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x000AD92C File Offset: 0x000ABB2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedItemLink.Descriptor;
			}
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000AD943 File Offset: 0x000ABB43
		[DebuggerNonUserCode]
		public SavedItemLink()
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000AD94D File Offset: 0x000ABB4D
		[DebuggerNonUserCode]
		public SavedItemLink(SavedItemLink other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000AD98C File Offset: 0x000ABB8C
		[DebuggerNonUserCode]
		public SavedItemLink Clone()
		{
			return new SavedItemLink(this);
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x000AD9A4 File Offset: 0x000ABBA4
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x000AD9D5 File Offset: 0x000ABBD5
		[DebuggerNonUserCode]
		public int X
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int xdefaultValue;
				if (flag)
				{
					xdefaultValue = this.x_;
				}
				else
				{
					xdefaultValue = SavedItemLink.XDefaultValue;
				}
				return xdefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.x_ = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000AD9F0 File Offset: 0x000ABBF0
		[DebuggerNonUserCode]
		public bool HasX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000ADA0D File Offset: 0x000ABC0D
		[DebuggerNonUserCode]
		public void ClearX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x000ADA20 File Offset: 0x000ABC20
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x000ADA51 File Offset: 0x000ABC51
		[DebuggerNonUserCode]
		public int Y
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int ydefaultValue;
				if (flag)
				{
					ydefaultValue = this.y_;
				}
				else
				{
					ydefaultValue = SavedItemLink.YDefaultValue;
				}
				return ydefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.y_ = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000ADA6C File Offset: 0x000ABC6C
		[DebuggerNonUserCode]
		public bool HasY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000ADA89 File Offset: 0x000ABC89
		[DebuggerNonUserCode]
		public void ClearY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000ADA9C File Offset: 0x000ABC9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedItemLink);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000ADABC File Offset: 0x000ABCBC
		[DebuggerNonUserCode]
		public bool Equals(SavedItemLink other)
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
					bool flag4 = this.X != other.X;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Y != other.Y;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000ADB30 File Offset: 0x000ABD30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasX = this.HasX;
			if (hasX)
			{
				num ^= this.X.GetHashCode();
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				num ^= this.Y.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000ADB9C File Offset: 0x000ABD9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000ADBB4 File Offset: 0x000ABDB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000ADBC0 File Offset: 0x000ABDC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasX = this.HasX;
			if (hasX)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.X);
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.Y);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000ADC30 File Offset: 0x000ABE30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasX = this.HasX;
			if (hasX)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.X);
			}
			bool hasY = this.HasY;
			if (hasY)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Y);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000ADC9C File Offset: 0x000ABE9C
		[DebuggerNonUserCode]
		public void MergeFrom(SavedItemLink other)
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

		// Token: 0x06002C34 RID: 11316 RVA: 0x000ADCFE File Offset: 0x000ABEFE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000ADD0C File Offset: 0x000ABF0C
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Y = input.ReadSInt32();
					}
				}
				else
				{
					this.X = input.ReadSInt32();
				}
			}
		}

		// Token: 0x040013F8 RID: 5112
		private static readonly MessageParser<SavedItemLink> _parser = new MessageParser<SavedItemLink>(() => new SavedItemLink());

		// Token: 0x040013F9 RID: 5113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013FA RID: 5114
		private int _hasBits0;

		// Token: 0x040013FB RID: 5115
		public const int XFieldNumber = 1;

		// Token: 0x040013FC RID: 5116
		private static readonly int XDefaultValue = -1;

		// Token: 0x040013FD RID: 5117
		private int x_;

		// Token: 0x040013FE RID: 5118
		public const int YFieldNumber = 2;

		// Token: 0x040013FF RID: 5119
		private static readonly int YDefaultValue = -1;

		// Token: 0x04001400 RID: 5120
		private int y_;
	}
}
