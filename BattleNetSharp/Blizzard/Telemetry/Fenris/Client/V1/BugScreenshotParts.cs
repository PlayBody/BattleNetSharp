using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000300 RID: 768
	public sealed class BugScreenshotParts : IMessage<BugScreenshotParts>, IMessage, IEquatable<BugScreenshotParts>, IDeepCloneable<BugScreenshotParts>, IBufferMessage
	{
		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x00139110 File Offset: 0x00137310
		[DebuggerNonUserCode]
		public static MessageParser<BugScreenshotParts> Parser
		{
			get
			{
				return BugScreenshotParts._parser;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x00139128 File Offset: 0x00137328
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BugScreenshotPartsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x0013914C File Offset: 0x0013734C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BugScreenshotParts.Descriptor;
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00139163 File Offset: 0x00137363
		[DebuggerNonUserCode]
		public BugScreenshotParts()
		{
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00139170 File Offset: 0x00137370
		[DebuggerNonUserCode]
		public BugScreenshotParts(BugScreenshotParts other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.timestamp_ = other.timestamp_;
			this.index_ = other.index_;
			this.count_ = other.count_;
			this.jpgDataPart_ = other.jpgDataPart_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x001391D4 File Offset: 0x001373D4
		[DebuggerNonUserCode]
		public BugScreenshotParts Clone()
		{
			return new BugScreenshotParts(this);
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x001391EC File Offset: 0x001373EC
		// (set) Token: 0x0600513F RID: 20799 RVA: 0x0013921D File Offset: 0x0013741D
		[DebuggerNonUserCode]
		public ulong Timestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong timestampDefaultValue;
				if (flag)
				{
					timestampDefaultValue = this.timestamp_;
				}
				else
				{
					timestampDefaultValue = BugScreenshotParts.TimestampDefaultValue;
				}
				return timestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timestamp_ = value;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00139238 File Offset: 0x00137438
		[DebuggerNonUserCode]
		public bool HasTimestamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00139255 File Offset: 0x00137455
		[DebuggerNonUserCode]
		public void ClearTimestamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x00139268 File Offset: 0x00137468
		// (set) Token: 0x06005143 RID: 20803 RVA: 0x00139299 File Offset: 0x00137499
		[DebuggerNonUserCode]
		public int Index
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int indexDefaultValue;
				if (flag)
				{
					indexDefaultValue = this.index_;
				}
				else
				{
					indexDefaultValue = BugScreenshotParts.IndexDefaultValue;
				}
				return indexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.index_ = value;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x001392B4 File Offset: 0x001374B4
		[DebuggerNonUserCode]
		public bool HasIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x001392D1 File Offset: 0x001374D1
		[DebuggerNonUserCode]
		public void ClearIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x001392E4 File Offset: 0x001374E4
		// (set) Token: 0x06005147 RID: 20807 RVA: 0x00139315 File Offset: 0x00137515
		[DebuggerNonUserCode]
		public int Count
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int countDefaultValue;
				if (flag)
				{
					countDefaultValue = this.count_;
				}
				else
				{
					countDefaultValue = BugScreenshotParts.CountDefaultValue;
				}
				return countDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.count_ = value;
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x00139330 File Offset: 0x00137530
		[DebuggerNonUserCode]
		public bool HasCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0013934D File Offset: 0x0013754D
		[DebuggerNonUserCode]
		public void ClearCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x00139360 File Offset: 0x00137560
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x00139381 File Offset: 0x00137581
		[DebuggerNonUserCode]
		public ByteString JpgDataPart
		{
			get
			{
				return this.jpgDataPart_ ?? BugScreenshotParts.JpgDataPartDefaultValue;
			}
			set
			{
				this.jpgDataPart_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x00139398 File Offset: 0x00137598
		[DebuggerNonUserCode]
		public bool HasJpgDataPart
		{
			get
			{
				return this.jpgDataPart_ != null;
			}
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x001393B6 File Offset: 0x001375B6
		[DebuggerNonUserCode]
		public void ClearJpgDataPart()
		{
			this.jpgDataPart_ = null;
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x001393C0 File Offset: 0x001375C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BugScreenshotParts);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x001393E0 File Offset: 0x001375E0
		[DebuggerNonUserCode]
		public bool Equals(BugScreenshotParts other)
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
					bool flag4 = this.Timestamp != other.Timestamp;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Index != other.Index;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Count != other.Count;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.JpgDataPart != other.JpgDataPart;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x0013948C File Offset: 0x0013768C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				num ^= this.Timestamp.GetHashCode();
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num ^= this.Index.GetHashCode();
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num ^= this.Count.GetHashCode();
			}
			bool hasJpgDataPart = this.HasJpgDataPart;
			if (hasJpgDataPart)
			{
				num ^= this.JpgDataPart.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00139534 File Offset: 0x00137734
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x0013954C File Offset: 0x0013774C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00139558 File Offset: 0x00137758
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Timestamp);
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			bool hasJpgDataPart = this.HasJpgDataPart;
			if (hasJpgDataPart)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.JpgDataPart);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0013960C File Offset: 0x0013780C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTimestamp = this.HasTimestamp;
			if (hasTimestamp)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Timestamp);
			}
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			bool hasJpgDataPart = this.HasJpgDataPart;
			if (hasJpgDataPart)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.JpgDataPart);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x001396B4 File Offset: 0x001378B4
		[DebuggerNonUserCode]
		public void MergeFrom(BugScreenshotParts other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTimestamp = other.HasTimestamp;
				if (hasTimestamp)
				{
					this.Timestamp = other.Timestamp;
				}
				bool hasIndex = other.HasIndex;
				if (hasIndex)
				{
					this.Index = other.Index;
				}
				bool hasCount = other.HasCount;
				if (hasCount)
				{
					this.Count = other.Count;
				}
				bool hasJpgDataPart = other.HasJpgDataPart;
				if (hasJpgDataPart)
				{
					this.JpgDataPart = other.JpgDataPart;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x0013974A File Offset: 0x0013794A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00139758 File Offset: 0x00137958
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
						this.Index = input.ReadInt32();
					}
					else
					{
						this.Timestamp = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.JpgDataPart = input.ReadBytes();
				}
				else
				{
					this.Count = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024BD RID: 9405
		private static readonly MessageParser<BugScreenshotParts> _parser = new MessageParser<BugScreenshotParts>(() => new BugScreenshotParts());

		// Token: 0x040024BE RID: 9406
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024BF RID: 9407
		private int _hasBits0;

		// Token: 0x040024C0 RID: 9408
		public const int TimestampFieldNumber = 1;

		// Token: 0x040024C1 RID: 9409
		private static readonly ulong TimestampDefaultValue = 0UL;

		// Token: 0x040024C2 RID: 9410
		private ulong timestamp_;

		// Token: 0x040024C3 RID: 9411
		public const int IndexFieldNumber = 2;

		// Token: 0x040024C4 RID: 9412
		private static readonly int IndexDefaultValue = 0;

		// Token: 0x040024C5 RID: 9413
		private int index_;

		// Token: 0x040024C6 RID: 9414
		public const int CountFieldNumber = 3;

		// Token: 0x040024C7 RID: 9415
		private static readonly int CountDefaultValue = 0;

		// Token: 0x040024C8 RID: 9416
		private int count_;

		// Token: 0x040024C9 RID: 9417
		public const int JpgDataPartFieldNumber = 4;

		// Token: 0x040024CA RID: 9418
		private static readonly ByteString JpgDataPartDefaultValue = ByteString.Empty;

		// Token: 0x040024CB RID: 9419
		private ByteString jpgDataPart_;
	}
}
