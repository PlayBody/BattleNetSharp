using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D0 RID: 1232
	public sealed class UnsubscribeStreamRequest : IMessage<UnsubscribeStreamRequest>, IMessage, IEquatable<UnsubscribeStreamRequest>, IDeepCloneable<UnsubscribeStreamRequest>, IBufferMessage
	{
		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x060077BF RID: 30655 RVA: 0x001D21F0 File Offset: 0x001D03F0
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeStreamRequest> Parser
		{
			get
			{
				return UnsubscribeStreamRequest._parser;
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x001D2208 File Offset: 0x001D0408
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[53];
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x060077C1 RID: 30657 RVA: 0x001D222C File Offset: 0x001D042C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeStreamRequest.Descriptor;
			}
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x001D2243 File Offset: 0x001D0443
		[DebuggerNonUserCode]
		public UnsubscribeStreamRequest()
		{
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x001D2258 File Offset: 0x001D0458
		[DebuggerNonUserCode]
		public UnsubscribeStreamRequest(UnsubscribeStreamRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x001D22C4 File Offset: 0x001D04C4
		[DebuggerNonUserCode]
		public UnsubscribeStreamRequest Clone()
		{
			return new UnsubscribeStreamRequest(this);
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x001D22DC File Offset: 0x001D04DC
		// (set) Token: 0x060077C6 RID: 30662 RVA: 0x001D22F4 File Offset: 0x001D04F4
		[DebuggerNonUserCode]
		public MemberId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x001D2300 File Offset: 0x001D0500
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x001D2331 File Offset: 0x001D0531
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = UnsubscribeStreamRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x001D234C File Offset: 0x001D054C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x001D2369 File Offset: 0x001D0569
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x001D237C File Offset: 0x001D057C
		[DebuggerNonUserCode]
		public RepeatedField<ulong> StreamId
		{
			get
			{
				return this.streamId_;
			}
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x001D2394 File Offset: 0x001D0594
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeStreamRequest);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x001D23B4 File Offset: 0x001D05B4
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeStreamRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.streamId_.Equals(other.streamId_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x001D2448 File Offset: 0x001D0648
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			num ^= this.streamId_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x001D24C4 File Offset: 0x001D06C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x001D24DC File Offset: 0x001D06DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x001D24E8 File Offset: 0x001D06E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			this.streamId_.WriteTo(ref output, UnsubscribeStreamRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x001D256C File Offset: 0x001D076C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			num += this.streamId_.CalculateSize(UnsubscribeStreamRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x001D25F0 File Offset: 0x001D07F0
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeStreamRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				this.streamId_.Add(other.streamId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x001D2687 File Offset: 0x001D0887
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x001D2694 File Offset: 0x001D0894
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.ClubId = input.ReadUInt64();
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new MemberId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_002C;
					}
					this.streamId_.AddEntriesFrom(ref input, UnsubscribeStreamRequest._repeated_streamId_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003667 RID: 13927
		private static readonly MessageParser<UnsubscribeStreamRequest> _parser = new MessageParser<UnsubscribeStreamRequest>(() => new UnsubscribeStreamRequest());

		// Token: 0x04003668 RID: 13928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003669 RID: 13929
		private int _hasBits0;

		// Token: 0x0400366A RID: 13930
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400366B RID: 13931
		private MemberId agentId_;

		// Token: 0x0400366C RID: 13932
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400366D RID: 13933
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400366E RID: 13934
		private ulong clubId_;

		// Token: 0x0400366F RID: 13935
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003670 RID: 13936
		private static readonly FieldCodec<ulong> _repeated_streamId_codec = FieldCodec.ForUInt64(24U);

		// Token: 0x04003671 RID: 13937
		private readonly RepeatedField<ulong> streamId_ = new RepeatedField<ulong>();
	}
}
