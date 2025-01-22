using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E9 RID: 1257
	public sealed class GetClubActivityRequest : IMessage<GetClubActivityRequest>, IMessage, IEquatable<GetClubActivityRequest>, IDeepCloneable<GetClubActivityRequest>, IBufferMessage
	{
		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x06007A3D RID: 31293 RVA: 0x001DB0F0 File Offset: 0x001D92F0
		[DebuggerNonUserCode]
		public static MessageParser<GetClubActivityRequest> Parser
		{
			get
			{
				return GetClubActivityRequest._parser;
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x06007A3E RID: 31294 RVA: 0x001DB108 File Offset: 0x001D9308
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[78];
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x06007A3F RID: 31295 RVA: 0x001DB12C File Offset: 0x001D932C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClubActivityRequest.Descriptor;
			}
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x001DB143 File Offset: 0x001D9343
		[DebuggerNonUserCode]
		public GetClubActivityRequest()
		{
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x001DB150 File Offset: 0x001D9350
		[DebuggerNonUserCode]
		public GetClubActivityRequest(GetClubActivityRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x001DB1C8 File Offset: 0x001D93C8
		[DebuggerNonUserCode]
		public GetClubActivityRequest Clone()
		{
			return new GetClubActivityRequest(this);
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x06007A43 RID: 31299 RVA: 0x001DB1E0 File Offset: 0x001D93E0
		// (set) Token: 0x06007A44 RID: 31300 RVA: 0x001DB1F8 File Offset: 0x001D93F8
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

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x06007A45 RID: 31301 RVA: 0x001DB204 File Offset: 0x001D9404
		// (set) Token: 0x06007A46 RID: 31302 RVA: 0x001DB235 File Offset: 0x001D9435
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
					clubIdDefaultValue = GetClubActivityRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x06007A47 RID: 31303 RVA: 0x001DB250 File Offset: 0x001D9450
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x001DB26D File Offset: 0x001D946D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x06007A49 RID: 31305 RVA: 0x001DB280 File Offset: 0x001D9480
		// (set) Token: 0x06007A4A RID: 31306 RVA: 0x001DB298 File Offset: 0x001D9498
		[DebuggerNonUserCode]
		public GetEventOptions Options
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

		// Token: 0x06007A4B RID: 31307 RVA: 0x001DB2A4 File Offset: 0x001D94A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClubActivityRequest);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x001DB2C4 File Offset: 0x001D94C4
		[DebuggerNonUserCode]
		public bool Equals(GetClubActivityRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x001DB358 File Offset: 0x001D9558
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

		// Token: 0x06007A4E RID: 31310 RVA: 0x001DB3E4 File Offset: 0x001D95E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x001DB3FC File Offset: 0x001D95FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x001DB408 File Offset: 0x001D9608
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x001DB4A0 File Offset: 0x001D96A0
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

		// Token: 0x06007A52 RID: 31314 RVA: 0x001DB530 File Offset: 0x001D9730
		[DebuggerNonUserCode]
		public void MergeFrom(GetClubActivityRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new GetEventOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x001DB5F8 File Offset: 0x001D97F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x001DB604 File Offset: 0x001D9804
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new GetEventOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003767 RID: 14183
		private static readonly MessageParser<GetClubActivityRequest> _parser = new MessageParser<GetClubActivityRequest>(() => new GetClubActivityRequest());

		// Token: 0x04003768 RID: 14184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003769 RID: 14185
		private int _hasBits0;

		// Token: 0x0400376A RID: 14186
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400376B RID: 14187
		private MemberId agentId_;

		// Token: 0x0400376C RID: 14188
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400376D RID: 14189
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400376E RID: 14190
		private ulong clubId_;

		// Token: 0x0400376F RID: 14191
		public const int OptionsFieldNumber = 3;

		// Token: 0x04003770 RID: 14192
		private GetEventOptions options_;
	}
}
