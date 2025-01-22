using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000500 RID: 1280
	public sealed class StreamEventTime : IMessage<StreamEventTime>, IMessage, IEquatable<StreamEventTime>, IDeepCloneable<StreamEventTime>, IBufferMessage
	{
		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x001E7C1C File Offset: 0x001E5E1C
		[DebuggerNonUserCode]
		public static MessageParser<StreamEventTime> Parser
		{
			get
			{
				return StreamEventTime._parser;
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06007D36 RID: 32054 RVA: 0x001E7C34 File Offset: 0x001E5E34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x06007D37 RID: 32055 RVA: 0x001E7C58 File Offset: 0x001E5E58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamEventTime.Descriptor;
			}
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x001E7C6F File Offset: 0x001E5E6F
		[DebuggerNonUserCode]
		public StreamEventTime()
		{
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x001E7C79 File Offset: 0x001E5E79
		[DebuggerNonUserCode]
		public StreamEventTime(StreamEventTime other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.streamId_ = other.streamId_;
			this.eventTime_ = other.eventTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x001E7CB8 File Offset: 0x001E5EB8
		[DebuggerNonUserCode]
		public StreamEventTime Clone()
		{
			return new StreamEventTime(this);
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x06007D3B RID: 32059 RVA: 0x001E7CD0 File Offset: 0x001E5ED0
		// (set) Token: 0x06007D3C RID: 32060 RVA: 0x001E7D01 File Offset: 0x001E5F01
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
					streamIdDefaultValue = StreamEventTime.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x06007D3D RID: 32061 RVA: 0x001E7D1C File Offset: 0x001E5F1C
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x001E7D39 File Offset: 0x001E5F39
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x06007D3F RID: 32063 RVA: 0x001E7D4C File Offset: 0x001E5F4C
		// (set) Token: 0x06007D40 RID: 32064 RVA: 0x001E7D7D File Offset: 0x001E5F7D
		[DebuggerNonUserCode]
		public ulong EventTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong eventTimeDefaultValue;
				if (flag)
				{
					eventTimeDefaultValue = this.eventTime_;
				}
				else
				{
					eventTimeDefaultValue = StreamEventTime.EventTimeDefaultValue;
				}
				return eventTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.eventTime_ = value;
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x06007D41 RID: 32065 RVA: 0x001E7D98 File Offset: 0x001E5F98
		[DebuggerNonUserCode]
		public bool HasEventTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x001E7DB5 File Offset: 0x001E5FB5
		[DebuggerNonUserCode]
		public void ClearEventTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x001E7DC8 File Offset: 0x001E5FC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamEventTime);
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x001E7DE8 File Offset: 0x001E5FE8
		[DebuggerNonUserCode]
		public bool Equals(StreamEventTime other)
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
						bool flag5 = this.EventTime != other.EventTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x001E7E5C File Offset: 0x001E605C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				num ^= this.EventTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x001E7EC8 File Offset: 0x001E60C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x001E7EE0 File Offset: 0x001E60E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x001E7EEC File Offset: 0x001E60EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StreamId);
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.EventTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x001E7F5C File Offset: 0x001E615C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EventTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D4A RID: 32074 RVA: 0x001E7FC8 File Offset: 0x001E61C8
		[DebuggerNonUserCode]
		public void MergeFrom(StreamEventTime other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool hasEventTime = other.HasEventTime;
				if (hasEventTime)
				{
					this.EventTime = other.EventTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x001E802A File Offset: 0x001E622A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x001E8038 File Offset: 0x001E6238
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
						this.EventTime = input.ReadUInt64();
					}
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040038F3 RID: 14579
		private static readonly MessageParser<StreamEventTime> _parser = new MessageParser<StreamEventTime>(() => new StreamEventTime());

		// Token: 0x040038F4 RID: 14580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F5 RID: 14581
		private int _hasBits0;

		// Token: 0x040038F6 RID: 14582
		public const int StreamIdFieldNumber = 1;

		// Token: 0x040038F7 RID: 14583
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040038F8 RID: 14584
		private ulong streamId_;

		// Token: 0x040038F9 RID: 14585
		public const int EventTimeFieldNumber = 2;

		// Token: 0x040038FA RID: 14586
		private static readonly ulong EventTimeDefaultValue = 0UL;

		// Token: 0x040038FB RID: 14587
		private ulong eventTime_;
	}
}
