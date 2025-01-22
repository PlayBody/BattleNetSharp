using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E0 RID: 1248
	public sealed class SetMessagePinnedRequest : IMessage<SetMessagePinnedRequest>, IMessage, IEquatable<SetMessagePinnedRequest>, IDeepCloneable<SetMessagePinnedRequest>, IBufferMessage
	{
		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x001D7C18 File Offset: 0x001D5E18
		[DebuggerNonUserCode]
		public static MessageParser<SetMessagePinnedRequest> Parser
		{
			get
			{
				return SetMessagePinnedRequest._parser;
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x06007953 RID: 31059 RVA: 0x001D7C30 File Offset: 0x001D5E30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[69];
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x001D7C54 File Offset: 0x001D5E54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMessagePinnedRequest.Descriptor;
			}
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x001D7C6B File Offset: 0x001D5E6B
		[DebuggerNonUserCode]
		public SetMessagePinnedRequest()
		{
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x001D7C78 File Offset: 0x001D5E78
		[DebuggerNonUserCode]
		public SetMessagePinnedRequest(SetMessagePinnedRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x001D7CE0 File Offset: 0x001D5EE0
		[DebuggerNonUserCode]
		public SetMessagePinnedRequest Clone()
		{
			return new SetMessagePinnedRequest(this);
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x06007958 RID: 31064 RVA: 0x001D7CF8 File Offset: 0x001D5EF8
		// (set) Token: 0x06007959 RID: 31065 RVA: 0x001D7D10 File Offset: 0x001D5F10
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

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x001D7D1C File Offset: 0x001D5F1C
		// (set) Token: 0x0600795B RID: 31067 RVA: 0x001D7D4D File Offset: 0x001D5F4D
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
					clubIdDefaultValue = SetMessagePinnedRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600795C RID: 31068 RVA: 0x001D7D68 File Offset: 0x001D5F68
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x001D7D85 File Offset: 0x001D5F85
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600795E RID: 31070 RVA: 0x001D7D98 File Offset: 0x001D5F98
		// (set) Token: 0x0600795F RID: 31071 RVA: 0x001D7DC9 File Offset: 0x001D5FC9
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
					streamIdDefaultValue = SetMessagePinnedRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x001D7DE4 File Offset: 0x001D5FE4
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x001D7E01 File Offset: 0x001D6001
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x001D7E14 File Offset: 0x001D6014
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMessagePinnedRequest);
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x001D7E34 File Offset: 0x001D6034
		[DebuggerNonUserCode]
		public bool Equals(SetMessagePinnedRequest other)
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

		// Token: 0x06007964 RID: 31076 RVA: 0x001D7EC4 File Offset: 0x001D60C4
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

		// Token: 0x06007965 RID: 31077 RVA: 0x001D7F50 File Offset: 0x001D6150
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x001D7F68 File Offset: 0x001D6168
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x001D7F74 File Offset: 0x001D6174
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

		// Token: 0x06007968 RID: 31080 RVA: 0x001D8008 File Offset: 0x001D6208
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

		// Token: 0x06007969 RID: 31081 RVA: 0x001D8098 File Offset: 0x001D6298
		[DebuggerNonUserCode]
		public void MergeFrom(SetMessagePinnedRequest other)
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

		// Token: 0x0600796A RID: 31082 RVA: 0x001D813B File Offset: 0x001D633B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x001D8148 File Offset: 0x001D6348
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

		// Token: 0x04003706 RID: 14086
		private static readonly MessageParser<SetMessagePinnedRequest> _parser = new MessageParser<SetMessagePinnedRequest>(() => new SetMessagePinnedRequest());

		// Token: 0x04003707 RID: 14087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003708 RID: 14088
		private int _hasBits0;

		// Token: 0x04003709 RID: 14089
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400370A RID: 14090
		private MemberId agentId_;

		// Token: 0x0400370B RID: 14091
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400370C RID: 14092
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400370D RID: 14093
		private ulong clubId_;

		// Token: 0x0400370E RID: 14094
		public const int StreamIdFieldNumber = 3;

		// Token: 0x0400370F RID: 14095
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003710 RID: 14096
		private ulong streamId_;
	}
}
