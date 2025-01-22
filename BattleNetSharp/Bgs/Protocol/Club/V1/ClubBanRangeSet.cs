using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000499 RID: 1177
	public sealed class ClubBanRangeSet : IMessage<ClubBanRangeSet>, IMessage, IEquatable<ClubBanRangeSet>, IDeepCloneable<ClubBanRangeSet>, IBufferMessage
	{
		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060072B3 RID: 29363 RVA: 0x001BEC64 File Offset: 0x001BCE64
		[DebuggerNonUserCode]
		public static MessageParser<ClubBanRangeSet> Parser
		{
			get
			{
				return ClubBanRangeSet._parser;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x060072B4 RID: 29364 RVA: 0x001BEC7C File Offset: 0x001BCE7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x060072B5 RID: 29365 RVA: 0x001BECA0 File Offset: 0x001BCEA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubBanRangeSet.Descriptor;
			}
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x001BECB7 File Offset: 0x001BCEB7
		[DebuggerNonUserCode]
		public ClubBanRangeSet()
		{
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x001BECC4 File Offset: 0x001BCEC4
		[DebuggerNonUserCode]
		public ClubBanRangeSet(ClubBanRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this.reasonRange_ = ((other.reasonRange_ != null) ? other.reasonRange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x001BED24 File Offset: 0x001BCF24
		[DebuggerNonUserCode]
		public ClubBanRangeSet Clone()
		{
			return new ClubBanRangeSet(this);
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x001BED3C File Offset: 0x001BCF3C
		// (set) Token: 0x060072BA RID: 29370 RVA: 0x001BED54 File Offset: 0x001BCF54
		[DebuggerNonUserCode]
		public UnsignedIntRange Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x060072BB RID: 29371 RVA: 0x001BED60 File Offset: 0x001BCF60
		// (set) Token: 0x060072BC RID: 29372 RVA: 0x001BED78 File Offset: 0x001BCF78
		[DebuggerNonUserCode]
		public UnsignedIntRange ReasonRange
		{
			get
			{
				return this.reasonRange_;
			}
			set
			{
				this.reasonRange_ = value;
			}
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x001BED84 File Offset: 0x001BCF84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubBanRangeSet);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x001BEDA4 File Offset: 0x001BCFA4
		[DebuggerNonUserCode]
		public bool Equals(ClubBanRangeSet other)
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
					bool flag4 = !object.Equals(this.Count, other.Count);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ReasonRange, other.ReasonRange);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x001BEE1C File Offset: 0x001BD01C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.count_ != null;
			if (flag)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag2 = this.reasonRange_ != null;
			if (flag2)
			{
				num ^= this.ReasonRange.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001BEE88 File Offset: 0x001BD088
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x001BEEA0 File Offset: 0x001BD0A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x001BEEAC File Offset: 0x001BD0AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.count_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Count);
			}
			bool flag2 = this.reasonRange_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ReasonRange);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x001BEF20 File Offset: 0x001BD120
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.count_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Count);
			}
			bool flag2 = this.reasonRange_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReasonRange);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x001BEF94 File Offset: 0x001BD194
		[DebuggerNonUserCode]
		public void MergeFrom(ClubBanRangeSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.count_ != null;
				if (flag2)
				{
					bool flag3 = this.count_ == null;
					if (flag3)
					{
						this.Count = new UnsignedIntRange();
					}
					this.Count.MergeFrom(other.Count);
				}
				bool flag4 = other.reasonRange_ != null;
				if (flag4)
				{
					bool flag5 = this.reasonRange_ == null;
					if (flag5)
					{
						this.ReasonRange = new UnsignedIntRange();
					}
					this.ReasonRange.MergeFrom(other.ReasonRange);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x001BF041 File Offset: 0x001BD241
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x001BF04C File Offset: 0x001BD24C
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.reasonRange_ == null;
						if (flag)
						{
							this.ReasonRange = new UnsignedIntRange();
						}
						input.ReadMessage(this.ReasonRange);
					}
				}
				else
				{
					bool flag2 = this.count_ == null;
					if (flag2)
					{
						this.Count = new UnsignedIntRange();
					}
					input.ReadMessage(this.Count);
				}
			}
		}

		// Token: 0x04003485 RID: 13445
		private static readonly MessageParser<ClubBanRangeSet> _parser = new MessageParser<ClubBanRangeSet>(() => new ClubBanRangeSet());

		// Token: 0x04003486 RID: 13446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003487 RID: 13447
		public const int CountFieldNumber = 1;

		// Token: 0x04003488 RID: 13448
		private UnsignedIntRange count_;

		// Token: 0x04003489 RID: 13449
		public const int ReasonRangeFieldNumber = 3;

		// Token: 0x0400348A RID: 13450
		private UnsignedIntRange reasonRange_;
	}
}
