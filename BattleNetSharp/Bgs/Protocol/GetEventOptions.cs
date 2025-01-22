using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200035D RID: 861
	public sealed class GetEventOptions : IMessage<GetEventOptions>, IMessage, IEquatable<GetEventOptions>, IDeepCloneable<GetEventOptions>, IBufferMessage
	{
		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x060058F7 RID: 22775 RVA: 0x00157FB0 File Offset: 0x001561B0
		[DebuggerNonUserCode]
		public static MessageParser<GetEventOptions> Parser
		{
			get
			{
				return GetEventOptions._parser;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x00157FC8 File Offset: 0x001561C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EventViewTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x00157FEC File Offset: 0x001561EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetEventOptions.Descriptor;
			}
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00158003 File Offset: 0x00156203
		[DebuggerNonUserCode]
		public GetEventOptions()
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00158010 File Offset: 0x00156210
		[DebuggerNonUserCode]
		public GetEventOptions(GetEventOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.fetchFrom_ = other.fetchFrom_;
			this.fetchUntil_ = other.fetchUntil_;
			this.maxEvents_ = other.maxEvents_;
			this.order_ = other.order_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00158074 File Offset: 0x00156274
		[DebuggerNonUserCode]
		public GetEventOptions Clone()
		{
			return new GetEventOptions(this);
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x0015808C File Offset: 0x0015628C
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x001580BD File Offset: 0x001562BD
		[DebuggerNonUserCode]
		public ulong FetchFrom
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong fetchFromDefaultValue;
				if (flag)
				{
					fetchFromDefaultValue = this.fetchFrom_;
				}
				else
				{
					fetchFromDefaultValue = GetEventOptions.FetchFromDefaultValue;
				}
				return fetchFromDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fetchFrom_ = value;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x001580D8 File Offset: 0x001562D8
		[DebuggerNonUserCode]
		public bool HasFetchFrom
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x001580F5 File Offset: 0x001562F5
		[DebuggerNonUserCode]
		public void ClearFetchFrom()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06005901 RID: 22785 RVA: 0x00158108 File Offset: 0x00156308
		// (set) Token: 0x06005902 RID: 22786 RVA: 0x00158139 File Offset: 0x00156339
		[DebuggerNonUserCode]
		public ulong FetchUntil
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong fetchUntilDefaultValue;
				if (flag)
				{
					fetchUntilDefaultValue = this.fetchUntil_;
				}
				else
				{
					fetchUntilDefaultValue = GetEventOptions.FetchUntilDefaultValue;
				}
				return fetchUntilDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fetchUntil_ = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06005903 RID: 22787 RVA: 0x00158154 File Offset: 0x00156354
		[DebuggerNonUserCode]
		public bool HasFetchUntil
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00158171 File Offset: 0x00156371
		[DebuggerNonUserCode]
		public void ClearFetchUntil()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x00158184 File Offset: 0x00156384
		// (set) Token: 0x06005906 RID: 22790 RVA: 0x001581B5 File Offset: 0x001563B5
		[DebuggerNonUserCode]
		public uint MaxEvents
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maxEventsDefaultValue;
				if (flag)
				{
					maxEventsDefaultValue = this.maxEvents_;
				}
				else
				{
					maxEventsDefaultValue = GetEventOptions.MaxEventsDefaultValue;
				}
				return maxEventsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxEvents_ = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06005907 RID: 22791 RVA: 0x001581D0 File Offset: 0x001563D0
		[DebuggerNonUserCode]
		public bool HasMaxEvents
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x001581ED File Offset: 0x001563ED
		[DebuggerNonUserCode]
		public void ClearMaxEvents()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06005909 RID: 22793 RVA: 0x00158200 File Offset: 0x00156400
		// (set) Token: 0x0600590A RID: 22794 RVA: 0x00158231 File Offset: 0x00156431
		[DebuggerNonUserCode]
		public EventOrder Order
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				EventOrder orderDefaultValue;
				if (flag)
				{
					orderDefaultValue = this.order_;
				}
				else
				{
					orderDefaultValue = GetEventOptions.OrderDefaultValue;
				}
				return orderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.order_ = value;
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x0600590B RID: 22795 RVA: 0x0015824C File Offset: 0x0015644C
		[DebuggerNonUserCode]
		public bool HasOrder
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00158269 File Offset: 0x00156469
		[DebuggerNonUserCode]
		public void ClearOrder()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x0015827C File Offset: 0x0015647C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetEventOptions);
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x0015829C File Offset: 0x0015649C
		[DebuggerNonUserCode]
		public bool Equals(GetEventOptions other)
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
					bool flag4 = this.FetchFrom != other.FetchFrom;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FetchUntil != other.FetchUntil;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaxEvents != other.MaxEvents;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Order != other.Order;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00158348 File Offset: 0x00156548
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFetchFrom = this.HasFetchFrom;
			if (hasFetchFrom)
			{
				num ^= this.FetchFrom.GetHashCode();
			}
			bool hasFetchUntil = this.HasFetchUntil;
			if (hasFetchUntil)
			{
				num ^= this.FetchUntil.GetHashCode();
			}
			bool hasMaxEvents = this.HasMaxEvents;
			if (hasMaxEvents)
			{
				num ^= this.MaxEvents.GetHashCode();
			}
			bool hasOrder = this.HasOrder;
			if (hasOrder)
			{
				num ^= this.Order.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x001583F8 File Offset: 0x001565F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00158410 File Offset: 0x00156610
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x0015841C File Offset: 0x0015661C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFetchFrom = this.HasFetchFrom;
			if (hasFetchFrom)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.FetchFrom);
			}
			bool hasFetchUntil = this.HasFetchUntil;
			if (hasFetchUntil)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.FetchUntil);
			}
			bool hasMaxEvents = this.HasMaxEvents;
			if (hasMaxEvents)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxEvents);
			}
			bool hasOrder = this.HasOrder;
			if (hasOrder)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Order);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x001584D0 File Offset: 0x001566D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFetchFrom = this.HasFetchFrom;
			if (hasFetchFrom)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.FetchFrom);
			}
			bool hasFetchUntil = this.HasFetchUntil;
			if (hasFetchUntil)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.FetchUntil);
			}
			bool hasMaxEvents = this.HasMaxEvents;
			if (hasMaxEvents)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxEvents);
			}
			bool hasOrder = this.HasOrder;
			if (hasOrder)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Order);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00158578 File Offset: 0x00156778
		[DebuggerNonUserCode]
		public void MergeFrom(GetEventOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFetchFrom = other.HasFetchFrom;
				if (hasFetchFrom)
				{
					this.FetchFrom = other.FetchFrom;
				}
				bool hasFetchUntil = other.HasFetchUntil;
				if (hasFetchUntil)
				{
					this.FetchUntil = other.FetchUntil;
				}
				bool hasMaxEvents = other.HasMaxEvents;
				if (hasMaxEvents)
				{
					this.MaxEvents = other.MaxEvents;
				}
				bool hasOrder = other.HasOrder;
				if (hasOrder)
				{
					this.Order = other.Order;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x0015860E File Offset: 0x0015680E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x0015861C File Offset: 0x0015681C
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
						this.FetchUntil = input.ReadUInt64();
					}
					else
					{
						this.FetchFrom = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.Order = (EventOrder)input.ReadEnum();
				}
				else
				{
					this.MaxEvents = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002892 RID: 10386
		private static readonly MessageParser<GetEventOptions> _parser = new MessageParser<GetEventOptions>(() => new GetEventOptions());

		// Token: 0x04002893 RID: 10387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002894 RID: 10388
		private int _hasBits0;

		// Token: 0x04002895 RID: 10389
		public const int FetchFromFieldNumber = 1;

		// Token: 0x04002896 RID: 10390
		private static readonly ulong FetchFromDefaultValue = 0UL;

		// Token: 0x04002897 RID: 10391
		private ulong fetchFrom_;

		// Token: 0x04002898 RID: 10392
		public const int FetchUntilFieldNumber = 2;

		// Token: 0x04002899 RID: 10393
		private static readonly ulong FetchUntilDefaultValue = 0UL;

		// Token: 0x0400289A RID: 10394
		private ulong fetchUntil_;

		// Token: 0x0400289B RID: 10395
		public const int MaxEventsFieldNumber = 3;

		// Token: 0x0400289C RID: 10396
		private static readonly uint MaxEventsDefaultValue = 0U;

		// Token: 0x0400289D RID: 10397
		private uint maxEvents_;

		// Token: 0x0400289E RID: 10398
		public const int OrderFieldNumber = 4;

		// Token: 0x0400289F RID: 10399
		private static readonly EventOrder OrderDefaultValue = EventOrder.EventDescending;

		// Token: 0x040028A0 RID: 10400
		private EventOrder order_;
	}
}
