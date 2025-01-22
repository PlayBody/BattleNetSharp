using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DC RID: 1244
	public sealed class DestroyMessageRequest : IMessage<DestroyMessageRequest>, IMessage, IEquatable<DestroyMessageRequest>, IDeepCloneable<DestroyMessageRequest>, IBufferMessage
	{
		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x001D6590 File Offset: 0x001D4790
		[DebuggerNonUserCode]
		public static MessageParser<DestroyMessageRequest> Parser
		{
			get
			{
				return DestroyMessageRequest._parser;
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x001D65A8 File Offset: 0x001D47A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[65];
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x001D65CC File Offset: 0x001D47CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyMessageRequest.Descriptor;
			}
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x001D65E3 File Offset: 0x001D47E3
		[DebuggerNonUserCode]
		public DestroyMessageRequest()
		{
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x001D65F0 File Offset: 0x001D47F0
		[DebuggerNonUserCode]
		public DestroyMessageRequest(DestroyMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.messageId_ = ((other.messageId_ != null) ? other.messageId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x001D6674 File Offset: 0x001D4874
		[DebuggerNonUserCode]
		public DestroyMessageRequest Clone()
		{
			return new DestroyMessageRequest(this);
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x001D668C File Offset: 0x001D488C
		// (set) Token: 0x060078F7 RID: 30967 RVA: 0x001D66A4 File Offset: 0x001D48A4
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

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x060078F8 RID: 30968 RVA: 0x001D66B0 File Offset: 0x001D48B0
		// (set) Token: 0x060078F9 RID: 30969 RVA: 0x001D66E1 File Offset: 0x001D48E1
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
					clubIdDefaultValue = DestroyMessageRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x001D66FC File Offset: 0x001D48FC
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x001D6719 File Offset: 0x001D4919
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x060078FC RID: 30972 RVA: 0x001D672C File Offset: 0x001D492C
		// (set) Token: 0x060078FD RID: 30973 RVA: 0x001D675D File Offset: 0x001D495D
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
					streamIdDefaultValue = DestroyMessageRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x001D6778 File Offset: 0x001D4978
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x001D6795 File Offset: 0x001D4995
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x06007900 RID: 30976 RVA: 0x001D67A8 File Offset: 0x001D49A8
		// (set) Token: 0x06007901 RID: 30977 RVA: 0x001D67C0 File Offset: 0x001D49C0
		[DebuggerNonUserCode]
		public MessageId MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x001D67CC File Offset: 0x001D49CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyMessageRequest);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x001D67EC File Offset: 0x001D49EC
		[DebuggerNonUserCode]
		public bool Equals(DestroyMessageRequest other)
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
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.MessageId, other.MessageId);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x001D68A0 File Offset: 0x001D4AA0
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num ^= this.MessageId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x001D6948 File Offset: 0x001D4B48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x001D6960 File Offset: 0x001D4B60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x001D696C File Offset: 0x001D4B6C
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MessageId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x001D6A28 File Offset: 0x001D4C28
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x001D6AD8 File Offset: 0x001D4CD8
		[DebuggerNonUserCode]
		public void MergeFrom(DestroyMessageRequest other)
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
				bool flag4 = other.messageId_ != null;
				if (flag4)
				{
					bool flag5 = this.messageId_ == null;
					if (flag5)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x001D6BBB File Offset: 0x001D4DBB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x001D6BC8 File Offset: 0x001D4DC8
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag2 = this.messageId_ == null;
					if (flag2)
					{
						this.MessageId = new MessageId();
					}
					input.ReadMessage(this.MessageId);
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036E2 RID: 14050
		private static readonly MessageParser<DestroyMessageRequest> _parser = new MessageParser<DestroyMessageRequest>(() => new DestroyMessageRequest());

		// Token: 0x040036E3 RID: 14051
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E4 RID: 14052
		private int _hasBits0;

		// Token: 0x040036E5 RID: 14053
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036E6 RID: 14054
		private MemberId agentId_;

		// Token: 0x040036E7 RID: 14055
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036E8 RID: 14056
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036E9 RID: 14057
		private ulong clubId_;

		// Token: 0x040036EA RID: 14058
		public const int StreamIdFieldNumber = 3;

		// Token: 0x040036EB RID: 14059
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040036EC RID: 14060
		private ulong streamId_;

		// Token: 0x040036ED RID: 14061
		public const int MessageIdFieldNumber = 4;

		// Token: 0x040036EE RID: 14062
		private MessageId messageId_;
	}
}
