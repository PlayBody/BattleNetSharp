using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000070 RID: 112
	public sealed class PlayMarkerSetRequest : IMessage<PlayMarkerSetRequest>, IMessage, IEquatable<PlayMarkerSetRequest>, IDeepCloneable<PlayMarkerSetRequest>, IBufferMessage
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000268C0 File Offset: 0x00024AC0
		[DebuggerNonUserCode]
		public static MessageParser<PlayMarkerSetRequest> Parser
		{
			get
			{
				return PlayMarkerSetRequest._parser;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000268D8 File Offset: 0x00024AD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[89];
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x000268FC File Offset: 0x00024AFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayMarkerSetRequest.Descriptor;
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00026913 File Offset: 0x00024B13
		[DebuggerNonUserCode]
		public PlayMarkerSetRequest()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002691D File Offset: 0x00024B1D
		[DebuggerNonUserCode]
		public PlayMarkerSetRequest(PlayMarkerSetRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoMarkerset_ = other.snoMarkerset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00026950 File Offset: 0x00024B50
		[DebuggerNonUserCode]
		public PlayMarkerSetRequest Clone()
		{
			return new PlayMarkerSetRequest(this);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00026968 File Offset: 0x00024B68
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00026999 File Offset: 0x00024B99
		[DebuggerNonUserCode]
		public int SnoMarkerset
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoMarkersetDefaultValue;
				if (flag)
				{
					snoMarkersetDefaultValue = this.snoMarkerset_;
				}
				else
				{
					snoMarkersetDefaultValue = PlayMarkerSetRequest.SnoMarkersetDefaultValue;
				}
				return snoMarkersetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoMarkerset_ = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000269B4 File Offset: 0x00024BB4
		[DebuggerNonUserCode]
		public bool HasSnoMarkerset
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000269D1 File Offset: 0x00024BD1
		[DebuggerNonUserCode]
		public void ClearSnoMarkerset()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000269E4 File Offset: 0x00024BE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayMarkerSetRequest);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00026A04 File Offset: 0x00024C04
		[DebuggerNonUserCode]
		public bool Equals(PlayMarkerSetRequest other)
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
					bool flag4 = this.SnoMarkerset != other.SnoMarkerset;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00026A5C File Offset: 0x00024C5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num ^= this.SnoMarkerset.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00026AAC File Offset: 0x00024CAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00026AC4 File Offset: 0x00024CC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00026AD0 File Offset: 0x00024CD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoMarkerset);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00026B1C File Offset: 0x00024D1C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoMarkerset);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00026B6C File Offset: 0x00024D6C
		[DebuggerNonUserCode]
		public void MergeFrom(PlayMarkerSetRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoMarkerset = other.HasSnoMarkerset;
				if (hasSnoMarkerset)
				{
					this.SnoMarkerset = other.SnoMarkerset;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00026BB5 File Offset: 0x00024DB5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00026BC0 File Offset: 0x00024DC0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoMarkerset = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003DE RID: 990
		private static readonly MessageParser<PlayMarkerSetRequest> _parser = new MessageParser<PlayMarkerSetRequest>(() => new PlayMarkerSetRequest());

		// Token: 0x040003DF RID: 991
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003E0 RID: 992
		private int _hasBits0;

		// Token: 0x040003E1 RID: 993
		public const int SnoMarkersetFieldNumber = 1;

		// Token: 0x040003E2 RID: 994
		private static readonly int SnoMarkersetDefaultValue = 0;

		// Token: 0x040003E3 RID: 995
		private int snoMarkerset_;
	}
}
