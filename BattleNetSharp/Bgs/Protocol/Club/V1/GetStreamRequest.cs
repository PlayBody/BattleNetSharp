using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D4 RID: 1236
	public sealed class GetStreamRequest : IMessage<GetStreamRequest>, IMessage, IEquatable<GetStreamRequest>, IDeepCloneable<GetStreamRequest>, IBufferMessage
	{
		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007824 RID: 30756 RVA: 0x001D3814 File Offset: 0x001D1A14
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamRequest> Parser
		{
			get
			{
				return GetStreamRequest._parser;
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06007825 RID: 30757 RVA: 0x001D382C File Offset: 0x001D1A2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[57];
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x001D3850 File Offset: 0x001D1A50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamRequest.Descriptor;
			}
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x001D3867 File Offset: 0x001D1A67
		[DebuggerNonUserCode]
		public GetStreamRequest()
		{
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x001D3874 File Offset: 0x001D1A74
		[DebuggerNonUserCode]
		public GetStreamRequest(GetStreamRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x001D38DC File Offset: 0x001D1ADC
		[DebuggerNonUserCode]
		public GetStreamRequest Clone()
		{
			return new GetStreamRequest(this);
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x001D38F4 File Offset: 0x001D1AF4
		// (set) Token: 0x0600782B RID: 30763 RVA: 0x001D390C File Offset: 0x001D1B0C
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

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x001D3918 File Offset: 0x001D1B18
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x001D3949 File Offset: 0x001D1B49
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
					clubIdDefaultValue = GetStreamRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x001D3964 File Offset: 0x001D1B64
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x001D3981 File Offset: 0x001D1B81
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x001D3994 File Offset: 0x001D1B94
		// (set) Token: 0x06007831 RID: 30769 RVA: 0x001D39C5 File Offset: 0x001D1BC5
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = GetStreamRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x001D39E0 File Offset: 0x001D1BE0
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x001D39FD File Offset: 0x001D1BFD
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x001D3A10 File Offset: 0x001D1C10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamRequest);
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x001D3A30 File Offset: 0x001D1C30
		[DebuggerNonUserCode]
		public bool Equals(GetStreamRequest other)
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
							bool flag6 = this.StreamId != other.StreamId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x001D3AC0 File Offset: 0x001D1CC0
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x001D3B4C File Offset: 0x001D1D4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x001D3B64 File Offset: 0x001D1D64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x001D3B70 File Offset: 0x001D1D70
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.StreamId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x001D3C04 File Offset: 0x001D1E04
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x001D3C94 File Offset: 0x001D1E94
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamRequest other)
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
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x001D3D37 File Offset: 0x001D1F37
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x001D3D44 File Offset: 0x001D1F44
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StreamId = input.ReadUInt64();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
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
		}

		// Token: 0x04003690 RID: 13968
		private static readonly MessageParser<GetStreamRequest> _parser = new MessageParser<GetStreamRequest>(() => new GetStreamRequest());

		// Token: 0x04003691 RID: 13969
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003692 RID: 13970
		private int _hasBits0;

		// Token: 0x04003693 RID: 13971
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003694 RID: 13972
		private MemberId agentId_;

		// Token: 0x04003695 RID: 13973
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003696 RID: 13974
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003697 RID: 13975
		private ulong clubId_;

		// Token: 0x04003698 RID: 13976
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003699 RID: 13977
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400369A RID: 13978
		private ulong streamId_;
	}
}
