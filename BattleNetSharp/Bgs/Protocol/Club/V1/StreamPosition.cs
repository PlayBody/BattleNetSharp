using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F3 RID: 1267
	public sealed class StreamPosition : IMessage<StreamPosition>, IMessage, IEquatable<StreamPosition>, IDeepCloneable<StreamPosition>, IBufferMessage
	{
		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x06007BCF RID: 31695 RVA: 0x001E2818 File Offset: 0x001E0A18
		[DebuggerNonUserCode]
		public static MessageParser<StreamPosition> Parser
		{
			get
			{
				return StreamPosition._parser;
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x001E2830 File Offset: 0x001E0A30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x001E2854 File Offset: 0x001E0A54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamPosition.Descriptor;
			}
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x001E286B File Offset: 0x001E0A6B
		[DebuggerNonUserCode]
		public StreamPosition()
		{
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x001E2880 File Offset: 0x001E0A80
		[DebuggerNonUserCode]
		public StreamPosition(StreamPosition other)
			: this()
		{
			this.streamId_ = other.streamId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x001E28AC File Offset: 0x001E0AAC
		[DebuggerNonUserCode]
		public StreamPosition Clone()
		{
			return new StreamPosition(this);
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x06007BD5 RID: 31701 RVA: 0x001E28C4 File Offset: 0x001E0AC4
		[DebuggerNonUserCode]
		public RepeatedField<ulong> StreamId
		{
			get
			{
				return this.streamId_;
			}
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x001E28DC File Offset: 0x001E0ADC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamPosition);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x001E28FC File Offset: 0x001E0AFC
		[DebuggerNonUserCode]
		public bool Equals(StreamPosition other)
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
					bool flag4 = !this.streamId_.Equals(other.streamId_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x001E2958 File Offset: 0x001E0B58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.streamId_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x001E2998 File Offset: 0x001E0B98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x001E29B0 File Offset: 0x001E0BB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x001E29BC File Offset: 0x001E0BBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.streamId_.WriteTo(ref output, StreamPosition._repeated_streamId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x001E29F8 File Offset: 0x001E0BF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.streamId_.CalculateSize(StreamPosition._repeated_streamId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x001E2A40 File Offset: 0x001E0C40
		[DebuggerNonUserCode]
		public void MergeFrom(StreamPosition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.streamId_.Add(other.streamId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x001E2A82 File Offset: 0x001E0C82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x001E2A90 File Offset: 0x001E0C90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.streamId_.AddEntriesFrom(ref input, StreamPosition._repeated_streamId_codec);
				}
			}
		}

		// Token: 0x0400384E RID: 14414
		private static readonly MessageParser<StreamPosition> _parser = new MessageParser<StreamPosition>(() => new StreamPosition());

		// Token: 0x0400384F RID: 14415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003850 RID: 14416
		public const int StreamIdFieldNumber = 1;

		// Token: 0x04003851 RID: 14417
		private static readonly FieldCodec<ulong> _repeated_streamId_codec = FieldCodec.ForUInt64(10U);

		// Token: 0x04003852 RID: 14418
		private readonly RepeatedField<ulong> streamId_ = new RepeatedField<ulong>();
	}
}
