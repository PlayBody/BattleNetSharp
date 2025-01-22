using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E2 RID: 1250
	public sealed class AdvanceStreamViewTimeRequest : IMessage<AdvanceStreamViewTimeRequest>, IMessage, IEquatable<AdvanceStreamViewTimeRequest>, IDeepCloneable<AdvanceStreamViewTimeRequest>, IBufferMessage
	{
		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x001D8958 File Offset: 0x001D6B58
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceStreamViewTimeRequest> Parser
		{
			get
			{
				return AdvanceStreamViewTimeRequest._parser;
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x001D8970 File Offset: 0x001D6B70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[71];
			}
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x001D8994 File Offset: 0x001D6B94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceStreamViewTimeRequest.Descriptor;
			}
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x001D89AB File Offset: 0x001D6BAB
		[DebuggerNonUserCode]
		public AdvanceStreamViewTimeRequest()
		{
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x001D89C0 File Offset: 0x001D6BC0
		[DebuggerNonUserCode]
		public AdvanceStreamViewTimeRequest(AdvanceStreamViewTimeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamIdDeprecated_ = other.streamIdDeprecated_;
			this.streamId_ = other.streamId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x001D8A38 File Offset: 0x001D6C38
		[DebuggerNonUserCode]
		public AdvanceStreamViewTimeRequest Clone()
		{
			return new AdvanceStreamViewTimeRequest(this);
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x06007992 RID: 31122 RVA: 0x001D8A50 File Offset: 0x001D6C50
		// (set) Token: 0x06007993 RID: 31123 RVA: 0x001D8A68 File Offset: 0x001D6C68
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

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x001D8A74 File Offset: 0x001D6C74
		// (set) Token: 0x06007995 RID: 31125 RVA: 0x001D8AA5 File Offset: 0x001D6CA5
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
					clubIdDefaultValue = AdvanceStreamViewTimeRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x001D8AC0 File Offset: 0x001D6CC0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x001D8ADD File Offset: 0x001D6CDD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x001D8AF0 File Offset: 0x001D6CF0
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x001D8B21 File Offset: 0x001D6D21
		[Obsolete]
		[DebuggerNonUserCode]
		public ulong StreamIdDeprecated
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong streamIdDeprecatedDefaultValue;
				if (flag)
				{
					streamIdDeprecatedDefaultValue = this.streamIdDeprecated_;
				}
				else
				{
					streamIdDeprecatedDefaultValue = AdvanceStreamViewTimeRequest.StreamIdDeprecatedDefaultValue;
				}
				return streamIdDeprecatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamIdDeprecated_ = value;
			}
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x001D8B3C File Offset: 0x001D6D3C
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasStreamIdDeprecated
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x001D8B59 File Offset: 0x001D6D59
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearStreamIdDeprecated()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x001D8B6C File Offset: 0x001D6D6C
		[DebuggerNonUserCode]
		public RepeatedField<ulong> StreamId
		{
			get
			{
				return this.streamId_;
			}
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x001D8B84 File Offset: 0x001D6D84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceStreamViewTimeRequest);
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x001D8BA4 File Offset: 0x001D6DA4
		[DebuggerNonUserCode]
		public bool Equals(AdvanceStreamViewTimeRequest other)
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
							bool flag6 = this.StreamIdDeprecated != other.StreamIdDeprecated;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.streamId_.Equals(other.streamId_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x001D8C58 File Offset: 0x001D6E58
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
			bool hasStreamIdDeprecated = this.HasStreamIdDeprecated;
			if (hasStreamIdDeprecated)
			{
				num ^= this.StreamIdDeprecated.GetHashCode();
			}
			num ^= this.streamId_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x001D8CF0 File Offset: 0x001D6EF0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x001D8D08 File Offset: 0x001D6F08
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x001D8D14 File Offset: 0x001D6F14
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
			bool hasStreamIdDeprecated = this.HasStreamIdDeprecated;
			if (hasStreamIdDeprecated)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.StreamIdDeprecated);
			}
			this.streamId_.WriteTo(ref output, AdvanceStreamViewTimeRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x001D8DBC File Offset: 0x001D6FBC
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
			bool hasStreamIdDeprecated = this.HasStreamIdDeprecated;
			if (hasStreamIdDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamIdDeprecated);
			}
			num += this.streamId_.CalculateSize(AdvanceStreamViewTimeRequest._repeated_streamId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x001D8E5C File Offset: 0x001D705C
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceStreamViewTimeRequest other)
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
				bool hasStreamIdDeprecated = other.HasStreamIdDeprecated;
				if (hasStreamIdDeprecated)
				{
					this.StreamIdDeprecated = other.StreamIdDeprecated;
				}
				this.streamId_.Add(other.streamId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x001D8F11 File Offset: 0x001D7111
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x001D8F1C File Offset: 0x001D711C
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
							goto IL_0033;
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
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0033;
					}
					this.streamId_.AddEntriesFrom(ref input, AdvanceStreamViewTimeRequest._repeated_streamId_codec);
				}
				else
				{
					this.StreamIdDeprecated = input.ReadUInt64();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400371F RID: 14111
		private static readonly MessageParser<AdvanceStreamViewTimeRequest> _parser = new MessageParser<AdvanceStreamViewTimeRequest>(() => new AdvanceStreamViewTimeRequest());

		// Token: 0x04003720 RID: 14112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003721 RID: 14113
		private int _hasBits0;

		// Token: 0x04003722 RID: 14114
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003723 RID: 14115
		private MemberId agentId_;

		// Token: 0x04003724 RID: 14116
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003725 RID: 14117
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003726 RID: 14118
		private ulong clubId_;

		// Token: 0x04003727 RID: 14119
		public const int StreamIdDeprecatedFieldNumber = 3;

		// Token: 0x04003728 RID: 14120
		private static readonly ulong StreamIdDeprecatedDefaultValue = 0UL;

		// Token: 0x04003729 RID: 14121
		private ulong streamIdDeprecated_;

		// Token: 0x0400372A RID: 14122
		public const int StreamIdFieldNumber = 4;

		// Token: 0x0400372B RID: 14123
		private static readonly FieldCodec<ulong> _repeated_streamId_codec = FieldCodec.ForUInt64(34U);

		// Token: 0x0400372C RID: 14124
		private readonly RepeatedField<ulong> streamId_ = new RepeatedField<ulong>();
	}
}
