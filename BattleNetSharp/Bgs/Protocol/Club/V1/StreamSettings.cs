using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000445 RID: 1093
	public sealed class StreamSettings : IMessage<StreamSettings>, IMessage, IEquatable<StreamSettings>, IDeepCloneable<StreamSettings>, IBufferMessage
	{
		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06006BDC RID: 27612 RVA: 0x001A3248 File Offset: 0x001A1448
		[DebuggerNonUserCode]
		public static MessageParser<StreamSettings> Parser
		{
			get
			{
				return StreamSettings._parser;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x001A3260 File Offset: 0x001A1460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06006BDE RID: 27614 RVA: 0x001A3284 File Offset: 0x001A1484
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamSettings.Descriptor;
			}
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x001A329B File Offset: 0x001A149B
		[DebuggerNonUserCode]
		public StreamSettings()
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x001A32A5 File Offset: 0x001A14A5
		[DebuggerNonUserCode]
		public StreamSettings(StreamSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.streamId_ = other.streamId_;
			this.filter_ = other.filter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x001A32E4 File Offset: 0x001A14E4
		[DebuggerNonUserCode]
		public StreamSettings Clone()
		{
			return new StreamSettings(this);
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x001A32FC File Offset: 0x001A14FC
		// (set) Token: 0x06006BE3 RID: 27619 RVA: 0x001A332D File Offset: 0x001A152D
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = StreamSettings.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x001A3348 File Offset: 0x001A1548
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x001A3365 File Offset: 0x001A1565
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x001A3378 File Offset: 0x001A1578
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x001A33A9 File Offset: 0x001A15A9
		[DebuggerNonUserCode]
		public StreamNotificationFilter Filter
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				StreamNotificationFilter filterDefaultValue;
				if (flag)
				{
					filterDefaultValue = this.filter_;
				}
				else
				{
					filterDefaultValue = StreamSettings.FilterDefaultValue;
				}
				return filterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.filter_ = value;
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x001A33C4 File Offset: 0x001A15C4
		[DebuggerNonUserCode]
		public bool HasFilter
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x001A33E1 File Offset: 0x001A15E1
		[DebuggerNonUserCode]
		public void ClearFilter()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x001A33F4 File Offset: 0x001A15F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamSettings);
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x001A3414 File Offset: 0x001A1614
		[DebuggerNonUserCode]
		public bool Equals(StreamSettings other)
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
					bool flag4 = this.StreamId != other.StreamId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Filter != other.Filter;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x001A3488 File Offset: 0x001A1688
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool hasFilter = this.HasFilter;
			if (hasFilter)
			{
				num ^= this.Filter.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x001A34FC File Offset: 0x001A16FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x001A3514 File Offset: 0x001A1714
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x001A3520 File Offset: 0x001A1720
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StreamId);
			}
			bool hasFilter = this.HasFilter;
			if (hasFilter)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Filter);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x001A3590 File Offset: 0x001A1790
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool hasFilter = this.HasFilter;
			if (hasFilter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Filter);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x001A35FC File Offset: 0x001A17FC
		[DebuggerNonUserCode]
		public void MergeFrom(StreamSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool hasFilter = other.HasFilter;
				if (hasFilter)
				{
					this.Filter = other.Filter;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x001A365E File Offset: 0x001A185E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x001A366C File Offset: 0x001A186C
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
						this.Filter = (StreamNotificationFilter)input.ReadEnum();
					}
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003164 RID: 12644
		private static readonly MessageParser<StreamSettings> _parser = new MessageParser<StreamSettings>(() => new StreamSettings());

		// Token: 0x04003165 RID: 12645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003166 RID: 12646
		private int _hasBits0;

		// Token: 0x04003167 RID: 12647
		public const int StreamIdFieldNumber = 1;

		// Token: 0x04003168 RID: 12648
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003169 RID: 12649
		private ulong streamId_;

		// Token: 0x0400316A RID: 12650
		public const int FilterFieldNumber = 2;

		// Token: 0x0400316B RID: 12651
		private static readonly StreamNotificationFilter FilterDefaultValue = StreamNotificationFilter.None;

		// Token: 0x0400316C RID: 12652
		private StreamNotificationFilter filter_;
	}
}
