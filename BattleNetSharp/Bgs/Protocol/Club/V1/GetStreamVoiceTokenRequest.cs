using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004EB RID: 1259
	public sealed class GetStreamVoiceTokenRequest : IMessage<GetStreamVoiceTokenRequest>, IMessage, IEquatable<GetStreamVoiceTokenRequest>, IDeepCloneable<GetStreamVoiceTokenRequest>, IBufferMessage
	{
		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x001DBA5C File Offset: 0x001D9C5C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamVoiceTokenRequest> Parser
		{
			get
			{
				return GetStreamVoiceTokenRequest._parser;
			}
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x001DBA74 File Offset: 0x001D9C74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[80];
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x001DBA98 File Offset: 0x001D9C98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamVoiceTokenRequest.Descriptor;
			}
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x001DBAAF File Offset: 0x001D9CAF
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenRequest()
		{
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x001DBABC File Offset: 0x001D9CBC
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenRequest(GetStreamVoiceTokenRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x001DBB30 File Offset: 0x001D9D30
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenRequest Clone()
		{
			return new GetStreamVoiceTokenRequest(this);
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x001DBB48 File Offset: 0x001D9D48
		// (set) Token: 0x06007A72 RID: 31346 RVA: 0x001DBB60 File Offset: 0x001D9D60
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

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x06007A73 RID: 31347 RVA: 0x001DBB6C File Offset: 0x001D9D6C
		// (set) Token: 0x06007A74 RID: 31348 RVA: 0x001DBB9D File Offset: 0x001D9D9D
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
					clubIdDefaultValue = GetStreamVoiceTokenRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x001DBBB8 File Offset: 0x001D9DB8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x001DBBD5 File Offset: 0x001D9DD5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x001DBBE8 File Offset: 0x001D9DE8
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x001DBC19 File Offset: 0x001D9E19
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
					streamIdDefaultValue = GetStreamVoiceTokenRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x001DBC34 File Offset: 0x001D9E34
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x001DBC51 File Offset: 0x001D9E51
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x001DBC64 File Offset: 0x001D9E64
		// (set) Token: 0x06007A7C RID: 31356 RVA: 0x001DBC95 File Offset: 0x001D9E95
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = GetStreamVoiceTokenRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.version_ = value;
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x06007A7D RID: 31357 RVA: 0x001DBCB0 File Offset: 0x001D9EB0
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x001DBCCD File Offset: 0x001D9ECD
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x001DBCE0 File Offset: 0x001D9EE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamVoiceTokenRequest);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x001DBD00 File Offset: 0x001D9F00
		[DebuggerNonUserCode]
		public bool Equals(GetStreamVoiceTokenRequest other)
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
								bool flag7 = this.Version != other.Version;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x001DBDB0 File Offset: 0x001D9FB0
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
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x001DBE58 File Offset: 0x001DA058
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x001DBE70 File Offset: 0x001DA070
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x001DBE7C File Offset: 0x001DA07C
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
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x001DBF34 File Offset: 0x001DA134
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
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x001DBFE0 File Offset: 0x001DA1E0
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamVoiceTokenRequest other)
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
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x001DC09E File Offset: 0x001DA29E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x001DC0AC File Offset: 0x001DA2AC
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
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.Version = input.ReadUInt32();
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

		// Token: 0x04003777 RID: 14199
		private static readonly MessageParser<GetStreamVoiceTokenRequest> _parser = new MessageParser<GetStreamVoiceTokenRequest>(() => new GetStreamVoiceTokenRequest());

		// Token: 0x04003778 RID: 14200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003779 RID: 14201
		private int _hasBits0;

		// Token: 0x0400377A RID: 14202
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400377B RID: 14203
		private MemberId agentId_;

		// Token: 0x0400377C RID: 14204
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400377D RID: 14205
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400377E RID: 14206
		private ulong clubId_;

		// Token: 0x0400377F RID: 14207
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003780 RID: 14208
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003781 RID: 14209
		private ulong streamId_;

		// Token: 0x04003782 RID: 14210
		public const int VersionFieldNumber = 4;

		// Token: 0x04003783 RID: 14211
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04003784 RID: 14212
		private uint version_;
	}
}
