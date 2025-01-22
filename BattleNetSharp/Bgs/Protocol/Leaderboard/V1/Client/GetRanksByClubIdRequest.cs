using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064D RID: 1613
	public sealed class GetRanksByClubIdRequest : IMessage<GetRanksByClubIdRequest>, IMessage, IEquatable<GetRanksByClubIdRequest>, IDeepCloneable<GetRanksByClubIdRequest>, IBufferMessage
	{
		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x00243E9C File Offset: 0x0024209C
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByClubIdRequest> Parser
		{
			get
			{
				return GetRanksByClubIdRequest._parser;
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x00243EB4 File Offset: 0x002420B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x060095FE RID: 38398 RVA: 0x00243ED8 File Offset: 0x002420D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByClubIdRequest.Descriptor;
			}
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x00243EEF File Offset: 0x002420EF
		[DebuggerNonUserCode]
		public GetRanksByClubIdRequest()
		{
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00243EFC File Offset: 0x002420FC
		[DebuggerNonUserCode]
		public GetRanksByClubIdRequest(GetRanksByClubIdRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.leaderboardId_ = other.leaderboardId_;
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x00243F54 File Offset: 0x00242154
		[DebuggerNonUserCode]
		public GetRanksByClubIdRequest Clone()
		{
			return new GetRanksByClubIdRequest(this);
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x00243F6C File Offset: 0x0024216C
		// (set) Token: 0x06009603 RID: 38403 RVA: 0x00243F8D File Offset: 0x0024218D
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksByClubIdRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x00243FA4 File Offset: 0x002421A4
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x00243FBF File Offset: 0x002421BF
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06009606 RID: 38406 RVA: 0x00243FCC File Offset: 0x002421CC
		// (set) Token: 0x06009607 RID: 38407 RVA: 0x00243FFD File Offset: 0x002421FD
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
					clubIdDefaultValue = GetRanksByClubIdRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x00244018 File Offset: 0x00242218
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x00244035 File Offset: 0x00242235
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600960A RID: 38410 RVA: 0x00244048 File Offset: 0x00242248
		// (set) Token: 0x0600960B RID: 38411 RVA: 0x00244079 File Offset: 0x00242279
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetRanksByClubIdRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600960C RID: 38412 RVA: 0x00244094 File Offset: 0x00242294
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x002440B1 File Offset: 0x002422B1
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x002440C4 File Offset: 0x002422C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByClubIdRequest);
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x002440E4 File Offset: 0x002422E4
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByClubIdRequest other)
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
					bool flag4 = this.LeaderboardId != other.LeaderboardId;
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
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x00244170 File Offset: 0x00242370
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x002441F8 File Offset: 0x002423F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x00244210 File Offset: 0x00242410
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009613 RID: 38419 RVA: 0x0024421C File Offset: 0x0024241C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x002442AC File Offset: 0x002424AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x00244338 File Offset: 0x00242538
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByClubIdRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x002443B3 File Offset: 0x002425B3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x002443C0 File Offset: 0x002425C0
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
							this.Continuation = input.ReadUInt64();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					this.LeaderboardId = input.ReadString();
				}
			}
		}

		// Token: 0x0400437F RID: 17279
		private static readonly MessageParser<GetRanksByClubIdRequest> _parser = new MessageParser<GetRanksByClubIdRequest>(() => new GetRanksByClubIdRequest());

		// Token: 0x04004380 RID: 17280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004381 RID: 17281
		private int _hasBits0;

		// Token: 0x04004382 RID: 17282
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x04004383 RID: 17283
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x04004384 RID: 17284
		private string leaderboardId_;

		// Token: 0x04004385 RID: 17285
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04004386 RID: 17286
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04004387 RID: 17287
		private ulong clubId_;

		// Token: 0x04004388 RID: 17288
		public const int ContinuationFieldNumber = 3;

		// Token: 0x04004389 RID: 17289
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400438A RID: 17290
		private ulong continuation_;
	}
}
