using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000496 RID: 1174
	public sealed class ClubInvitationRangeSet : IMessage<ClubInvitationRangeSet>, IMessage, IEquatable<ClubInvitationRangeSet>, IDeepCloneable<ClubInvitationRangeSet>, IBufferMessage
	{
		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x001BE22C File Offset: 0x001BC42C
		[DebuggerNonUserCode]
		public static MessageParser<ClubInvitationRangeSet> Parser
		{
			get
			{
				return ClubInvitationRangeSet._parser;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x0600727B RID: 29307 RVA: 0x001BE244 File Offset: 0x001BC444
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600727C RID: 29308 RVA: 0x001BE268 File Offset: 0x001BC468
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubInvitationRangeSet.Descriptor;
			}
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x001BE27F File Offset: 0x001BC47F
		[DebuggerNonUserCode]
		public ClubInvitationRangeSet()
		{
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x001BE289 File Offset: 0x001BC489
		[DebuggerNonUserCode]
		public ClubInvitationRangeSet(ClubInvitationRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x001BE2C0 File Offset: 0x001BC4C0
		[DebuggerNonUserCode]
		public ClubInvitationRangeSet Clone()
		{
			return new ClubInvitationRangeSet(this);
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x06007280 RID: 29312 RVA: 0x001BE2D8 File Offset: 0x001BC4D8
		// (set) Token: 0x06007281 RID: 29313 RVA: 0x001BE2F0 File Offset: 0x001BC4F0
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

		// Token: 0x06007282 RID: 29314 RVA: 0x001BE2FC File Offset: 0x001BC4FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubInvitationRangeSet);
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x001BE31C File Offset: 0x001BC51C
		[DebuggerNonUserCode]
		public bool Equals(ClubInvitationRangeSet other)
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

		// Token: 0x06007284 RID: 29316 RVA: 0x001BE378 File Offset: 0x001BC578
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

		// Token: 0x06007285 RID: 29317 RVA: 0x001BE3C8 File Offset: 0x001BC5C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x001BE3E0 File Offset: 0x001BC5E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x001BE3EC File Offset: 0x001BC5EC
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

		// Token: 0x06007288 RID: 29320 RVA: 0x001BE43C File Offset: 0x001BC63C
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

		// Token: 0x06007289 RID: 29321 RVA: 0x001BE490 File Offset: 0x001BC690
		[DebuggerNonUserCode]
		public void MergeFrom(ClubInvitationRangeSet other)
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

		// Token: 0x0600728A RID: 29322 RVA: 0x001BE4FC File Offset: 0x001BC6FC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x001BE508 File Offset: 0x001BC708
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

		// Token: 0x04003479 RID: 13433
		private static readonly MessageParser<ClubInvitationRangeSet> _parser = new MessageParser<ClubInvitationRangeSet>(() => new ClubInvitationRangeSet());

		// Token: 0x0400347A RID: 13434
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400347B RID: 13435
		public const int CountFieldNumber = 1;

		// Token: 0x0400347C RID: 13436
		private UnsignedIntRange count_;
	}
}
