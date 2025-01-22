using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A3 RID: 419
	public sealed class Timestamps : IMessage<Timestamps>, IMessage, IEquatable<Timestamps>, IDeepCloneable<Timestamps>, IBufferMessage
	{
		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000ADD9C File Offset: 0x000ABF9C
		[DebuggerNonUserCode]
		public static MessageParser<Timestamps> Parser
		{
			get
			{
				return Timestamps._parser;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000ADDB4 File Offset: 0x000ABFB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000ADDD8 File Offset: 0x000ABFD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Timestamps.Descriptor;
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000ADDEF File Offset: 0x000ABFEF
		[DebuggerNonUserCode]
		public Timestamps()
		{
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000ADDF9 File Offset: 0x000ABFF9
		[DebuggerNonUserCode]
		public Timestamps(Timestamps other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.createTime_ = other.createTime_;
			this.deleteTime_ = other.deleteTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000ADE38 File Offset: 0x000AC038
		[DebuggerNonUserCode]
		public Timestamps Clone()
		{
			return new Timestamps(this);
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000ADE50 File Offset: 0x000AC050
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x000ADE81 File Offset: 0x000AC081
		[DebuggerNonUserCode]
		public long CreateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long createTimeDefaultValue;
				if (flag)
				{
					createTimeDefaultValue = this.createTime_;
				}
				else
				{
					createTimeDefaultValue = Timestamps.CreateTimeDefaultValue;
				}
				return createTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.createTime_ = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000ADE9C File Offset: 0x000AC09C
		[DebuggerNonUserCode]
		public bool HasCreateTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000ADEB9 File Offset: 0x000AC0B9
		[DebuggerNonUserCode]
		public void ClearCreateTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000ADECC File Offset: 0x000AC0CC
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x000ADEFD File Offset: 0x000AC0FD
		[DebuggerNonUserCode]
		public long DeleteTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long deleteTimeDefaultValue;
				if (flag)
				{
					deleteTimeDefaultValue = this.deleteTime_;
				}
				else
				{
					deleteTimeDefaultValue = Timestamps.DeleteTimeDefaultValue;
				}
				return deleteTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.deleteTime_ = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000ADF18 File Offset: 0x000AC118
		[DebuggerNonUserCode]
		public bool HasDeleteTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000ADF35 File Offset: 0x000AC135
		[DebuggerNonUserCode]
		public void ClearDeleteTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000ADF48 File Offset: 0x000AC148
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Timestamps);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000ADF68 File Offset: 0x000AC168
		[DebuggerNonUserCode]
		public bool Equals(Timestamps other)
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
					bool flag4 = this.CreateTime != other.CreateTime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DeleteTime != other.DeleteTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000ADFDC File Offset: 0x000AC1DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				num ^= this.DeleteTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000AE048 File Offset: 0x000AC248
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000AE060 File Offset: 0x000AC260
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000AE06C File Offset: 0x000AC26C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				output.WriteRawTag(8);
				output.WriteSInt64(this.CreateTime);
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				output.WriteRawTag(16);
				output.WriteSInt64(this.DeleteTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000AE0DC File Offset: 0x000AC2DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.CreateTime);
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.DeleteTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000AE148 File Offset: 0x000AC348
		[DebuggerNonUserCode]
		public void MergeFrom(Timestamps other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCreateTime = other.HasCreateTime;
				if (hasCreateTime)
				{
					this.CreateTime = other.CreateTime;
				}
				bool hasDeleteTime = other.HasDeleteTime;
				if (hasDeleteTime)
				{
					this.DeleteTime = other.DeleteTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000AE1AA File Offset: 0x000AC3AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000AE1B8 File Offset: 0x000AC3B8
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
						this.DeleteTime = input.ReadSInt64();
					}
				}
				else
				{
					this.CreateTime = input.ReadSInt64();
				}
			}
		}

		// Token: 0x04001401 RID: 5121
		private static readonly MessageParser<Timestamps> _parser = new MessageParser<Timestamps>(() => new Timestamps());

		// Token: 0x04001402 RID: 5122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001403 RID: 5123
		private int _hasBits0;

		// Token: 0x04001404 RID: 5124
		public const int CreateTimeFieldNumber = 1;

		// Token: 0x04001405 RID: 5125
		private static readonly long CreateTimeDefaultValue = 0L;

		// Token: 0x04001406 RID: 5126
		private long createTime_;

		// Token: 0x04001407 RID: 5127
		public const int DeleteTimeFieldNumber = 2;

		// Token: 0x04001408 RID: 5128
		private static readonly long DeleteTimeDefaultValue = 0L;

		// Token: 0x04001409 RID: 5129
		private long deleteTime_;
	}
}
