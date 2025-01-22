using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BD RID: 1213
	public sealed class GetSuggestionRequest : IMessage<GetSuggestionRequest>, IMessage, IEquatable<GetSuggestionRequest>, IDeepCloneable<GetSuggestionRequest>, IBufferMessage
	{
		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x001CC348 File Offset: 0x001CA548
		[DebuggerNonUserCode]
		public static MessageParser<GetSuggestionRequest> Parser
		{
			get
			{
				return GetSuggestionRequest._parser;
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06007601 RID: 30209 RVA: 0x001CC360 File Offset: 0x001CA560
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x001CC384 File Offset: 0x001CA584
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSuggestionRequest.Descriptor;
			}
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x001CC39B File Offset: 0x001CA59B
		[DebuggerNonUserCode]
		public GetSuggestionRequest()
		{
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x001CC3A8 File Offset: 0x001CA5A8
		[DebuggerNonUserCode]
		public GetSuggestionRequest(GetSuggestionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.suggestionId_ = other.suggestionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x001CC410 File Offset: 0x001CA610
		[DebuggerNonUserCode]
		public GetSuggestionRequest Clone()
		{
			return new GetSuggestionRequest(this);
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x001CC428 File Offset: 0x001CA628
		// (set) Token: 0x06007607 RID: 30215 RVA: 0x001CC440 File Offset: 0x001CA640
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

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06007608 RID: 30216 RVA: 0x001CC44C File Offset: 0x001CA64C
		// (set) Token: 0x06007609 RID: 30217 RVA: 0x001CC47D File Offset: 0x001CA67D
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
					clubIdDefaultValue = GetSuggestionRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600760A RID: 30218 RVA: 0x001CC498 File Offset: 0x001CA698
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x001CC4B5 File Offset: 0x001CA6B5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x001CC4C8 File Offset: 0x001CA6C8
		// (set) Token: 0x0600760D RID: 30221 RVA: 0x001CC4F9 File Offset: 0x001CA6F9
		[DebuggerNonUserCode]
		public ulong SuggestionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong suggestionIdDefaultValue;
				if (flag)
				{
					suggestionIdDefaultValue = this.suggestionId_;
				}
				else
				{
					suggestionIdDefaultValue = GetSuggestionRequest.SuggestionIdDefaultValue;
				}
				return suggestionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.suggestionId_ = value;
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x0600760E RID: 30222 RVA: 0x001CC514 File Offset: 0x001CA714
		[DebuggerNonUserCode]
		public bool HasSuggestionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x001CC531 File Offset: 0x001CA731
		[DebuggerNonUserCode]
		public void ClearSuggestionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x001CC544 File Offset: 0x001CA744
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSuggestionRequest);
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x001CC564 File Offset: 0x001CA764
		[DebuggerNonUserCode]
		public bool Equals(GetSuggestionRequest other)
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
							bool flag6 = this.SuggestionId != other.SuggestionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x001CC5F4 File Offset: 0x001CA7F4
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num ^= this.SuggestionId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x001CC680 File Offset: 0x001CA880
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x001CC698 File Offset: 0x001CA898
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x001CC6A4 File Offset: 0x001CA8A4
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.SuggestionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x001CC738 File Offset: 0x001CA938
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num += 9;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x001CC7BC File Offset: 0x001CA9BC
		[DebuggerNonUserCode]
		public void MergeFrom(GetSuggestionRequest other)
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
				bool hasSuggestionId = other.HasSuggestionId;
				if (hasSuggestionId)
				{
					this.SuggestionId = other.SuggestionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x001CC85F File Offset: 0x001CAA5F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x001CC86C File Offset: 0x001CAA6C
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
						if (num3 != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SuggestionId = input.ReadFixed64();
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

		// Token: 0x040035C4 RID: 13764
		private static readonly MessageParser<GetSuggestionRequest> _parser = new MessageParser<GetSuggestionRequest>(() => new GetSuggestionRequest());

		// Token: 0x040035C5 RID: 13765
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C6 RID: 13766
		private int _hasBits0;

		// Token: 0x040035C7 RID: 13767
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035C8 RID: 13768
		private MemberId agentId_;

		// Token: 0x040035C9 RID: 13769
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035CA RID: 13770
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035CB RID: 13771
		private ulong clubId_;

		// Token: 0x040035CC RID: 13772
		public const int SuggestionIdFieldNumber = 3;

		// Token: 0x040035CD RID: 13773
		private static readonly ulong SuggestionIdDefaultValue = 0UL;

		// Token: 0x040035CE RID: 13774
		private ulong suggestionId_;
	}
}
