using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DA RID: 1242
	public sealed class CreateMessageRequest : IMessage<CreateMessageRequest>, IMessage, IEquatable<CreateMessageRequest>, IDeepCloneable<CreateMessageRequest>, IBufferMessage
	{
		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x060078C0 RID: 30912 RVA: 0x001D5AEC File Offset: 0x001D3CEC
		[DebuggerNonUserCode]
		public static MessageParser<CreateMessageRequest> Parser
		{
			get
			{
				return CreateMessageRequest._parser;
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x001D5B04 File Offset: 0x001D3D04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[63];
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x060078C2 RID: 30914 RVA: 0x001D5B28 File Offset: 0x001D3D28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateMessageRequest.Descriptor;
			}
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x001D5B3F File Offset: 0x001D3D3F
		[DebuggerNonUserCode]
		public CreateMessageRequest()
		{
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x001D5B4C File Offset: 0x001D3D4C
		[DebuggerNonUserCode]
		public CreateMessageRequest(CreateMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x001D5BD0 File Offset: 0x001D3DD0
		[DebuggerNonUserCode]
		public CreateMessageRequest Clone()
		{
			return new CreateMessageRequest(this);
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x001D5BE8 File Offset: 0x001D3DE8
		// (set) Token: 0x060078C7 RID: 30919 RVA: 0x001D5C00 File Offset: 0x001D3E00
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

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x001D5C0C File Offset: 0x001D3E0C
		// (set) Token: 0x060078C9 RID: 30921 RVA: 0x001D5C3D File Offset: 0x001D3E3D
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
					clubIdDefaultValue = CreateMessageRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x001D5C58 File Offset: 0x001D3E58
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x001D5C75 File Offset: 0x001D3E75
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x001D5C88 File Offset: 0x001D3E88
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x001D5CB9 File Offset: 0x001D3EB9
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
					streamIdDefaultValue = CreateMessageRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x001D5CD4 File Offset: 0x001D3ED4
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x001D5CF1 File Offset: 0x001D3EF1
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x060078D0 RID: 30928 RVA: 0x001D5D04 File Offset: 0x001D3F04
		// (set) Token: 0x060078D1 RID: 30929 RVA: 0x001D5D1C File Offset: 0x001D3F1C
		[DebuggerNonUserCode]
		public CreateMessageOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x001D5D28 File Offset: 0x001D3F28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateMessageRequest);
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x001D5D48 File Offset: 0x001D3F48
		[DebuggerNonUserCode]
		public bool Equals(CreateMessageRequest other)
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
								bool flag7 = !object.Equals(this.Options, other.Options);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x001D5DFC File Offset: 0x001D3FFC
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x001D5EA4 File Offset: 0x001D40A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x001D5EBC File Offset: 0x001D40BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x001D5EC8 File Offset: 0x001D40C8
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x001D5F84 File Offset: 0x001D4184
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x001D6034 File Offset: 0x001D4234
		[DebuggerNonUserCode]
		public void MergeFrom(CreateMessageRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new CreateMessageOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x001D6117 File Offset: 0x001D4317
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x001D6124 File Offset: 0x001D4324
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
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new CreateMessageOptions();
					}
					input.ReadMessage(this.Options);
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

		// Token: 0x040036D1 RID: 14033
		private static readonly MessageParser<CreateMessageRequest> _parser = new MessageParser<CreateMessageRequest>(() => new CreateMessageRequest());

		// Token: 0x040036D2 RID: 14034
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D3 RID: 14035
		private int _hasBits0;

		// Token: 0x040036D4 RID: 14036
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036D5 RID: 14037
		private MemberId agentId_;

		// Token: 0x040036D6 RID: 14038
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036D7 RID: 14039
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036D8 RID: 14040
		private ulong clubId_;

		// Token: 0x040036D9 RID: 14041
		public const int StreamIdFieldNumber = 3;

		// Token: 0x040036DA RID: 14042
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040036DB RID: 14043
		private ulong streamId_;

		// Token: 0x040036DC RID: 14044
		public const int OptionsFieldNumber = 4;

		// Token: 0x040036DD RID: 14045
		private CreateMessageOptions options_;
	}
}
