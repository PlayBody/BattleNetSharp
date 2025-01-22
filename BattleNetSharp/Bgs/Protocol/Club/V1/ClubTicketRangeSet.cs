using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000498 RID: 1176
	public sealed class ClubTicketRangeSet : IMessage<ClubTicketRangeSet>, IMessage, IEquatable<ClubTicketRangeSet>, IDeepCloneable<ClubTicketRangeSet>, IBufferMessage
	{
		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x001BE8FC File Offset: 0x001BCAFC
		[DebuggerNonUserCode]
		public static MessageParser<ClubTicketRangeSet> Parser
		{
			get
			{
				return ClubTicketRangeSet._parser;
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x060072A1 RID: 29345 RVA: 0x001BE914 File Offset: 0x001BCB14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x060072A2 RID: 29346 RVA: 0x001BE938 File Offset: 0x001BCB38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubTicketRangeSet.Descriptor;
			}
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x001BE94F File Offset: 0x001BCB4F
		[DebuggerNonUserCode]
		public ClubTicketRangeSet()
		{
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x001BE959 File Offset: 0x001BCB59
		[DebuggerNonUserCode]
		public ClubTicketRangeSet(ClubTicketRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x001BE990 File Offset: 0x001BCB90
		[DebuggerNonUserCode]
		public ClubTicketRangeSet Clone()
		{
			return new ClubTicketRangeSet(this);
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x001BE9A8 File Offset: 0x001BCBA8
		// (set) Token: 0x060072A7 RID: 29351 RVA: 0x001BE9C0 File Offset: 0x001BCBC0
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

		// Token: 0x060072A8 RID: 29352 RVA: 0x001BE9CC File Offset: 0x001BCBCC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubTicketRangeSet);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x001BE9EC File Offset: 0x001BCBEC
		[DebuggerNonUserCode]
		public bool Equals(ClubTicketRangeSet other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x001BEA48 File Offset: 0x001BCC48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.count_ != null;
			if (flag)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x001BEA98 File Offset: 0x001BCC98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x001BEAB0 File Offset: 0x001BCCB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x001BEABC File Offset: 0x001BCCBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.count_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Count);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x001BEB0C File Offset: 0x001BCD0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.count_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Count);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x001BEB60 File Offset: 0x001BCD60
		[DebuggerNonUserCode]
		public void MergeFrom(ClubTicketRangeSet other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x001BEBCC File Offset: 0x001BCDCC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x001BEBD8 File Offset: 0x001BCDD8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.count_ == null;
					if (flag)
					{
						this.Count = new UnsignedIntRange();
					}
					input.ReadMessage(this.Count);
				}
			}
		}

		// Token: 0x04003481 RID: 13441
		private static readonly MessageParser<ClubTicketRangeSet> _parser = new MessageParser<ClubTicketRangeSet>(() => new ClubTicketRangeSet());

		// Token: 0x04003482 RID: 13442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003483 RID: 13443
		public const int CountFieldNumber = 1;

		// Token: 0x04003484 RID: 13444
		private UnsignedIntRange count_;
	}
}
