using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064B RID: 1611
	public sealed class GetRanksByEntityIdsRequest : IMessage<GetRanksByEntityIdsRequest>, IMessage, IEquatable<GetRanksByEntityIdsRequest>, IDeepCloneable<GetRanksByEntityIdsRequest>, IBufferMessage
	{
		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x060095D4 RID: 38356 RVA: 0x00243794 File Offset: 0x00241994
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByEntityIdsRequest> Parser
		{
			get
			{
				return GetRanksByEntityIdsRequest._parser;
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x060095D5 RID: 38357 RVA: 0x002437AC File Offset: 0x002419AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x060095D6 RID: 38358 RVA: 0x002437D0 File Offset: 0x002419D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByEntityIdsRequest.Descriptor;
			}
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x002437E7 File Offset: 0x002419E7
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsRequest()
		{
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x002437FC File Offset: 0x002419FC
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsRequest(GetRanksByEntityIdsRequest other)
			: this()
		{
			this.leaderboardId_ = other.leaderboardId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x00243834 File Offset: 0x00241A34
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsRequest Clone()
		{
			return new GetRanksByEntityIdsRequest(this);
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x060095DA RID: 38362 RVA: 0x0024384C File Offset: 0x00241A4C
		// (set) Token: 0x060095DB RID: 38363 RVA: 0x0024386D File Offset: 0x00241A6D
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksByEntityIdsRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x060095DC RID: 38364 RVA: 0x00243884 File Offset: 0x00241A84
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x0024389F File Offset: 0x00241A9F
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x060095DE RID: 38366 RVA: 0x002438AC File Offset: 0x00241AAC
		[DebuggerNonUserCode]
		public RepeatedField<string> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x002438C4 File Offset: 0x00241AC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByEntityIdsRequest);
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x002438E4 File Offset: 0x00241AE4
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByEntityIdsRequest other)
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
						bool flag5 = !this.entityIds_.Equals(other.entityIds_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x00243958 File Offset: 0x00241B58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x002439B0 File Offset: 0x00241BB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x002439C8 File Offset: 0x00241BC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x002439D4 File Offset: 0x00241BD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			this.entityIds_.WriteTo(ref output, GetRanksByEntityIdsRequest._repeated_entityIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x00243A34 File Offset: 0x00241C34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			num += this.entityIds_.CalculateSize(GetRanksByEntityIdsRequest._repeated_entityIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00243A98 File Offset: 0x00241C98
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByEntityIdsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				this.entityIds_.Add(other.entityIds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00243AF3 File Offset: 0x00241CF3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x00243B00 File Offset: 0x00241D00
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, GetRanksByEntityIdsRequest._repeated_entityIds_codec);
					}
				}
				else
				{
					this.LeaderboardId = input.ReadString();
				}
			}
		}

		// Token: 0x04004372 RID: 17266
		private static readonly MessageParser<GetRanksByEntityIdsRequest> _parser = new MessageParser<GetRanksByEntityIdsRequest>(() => new GetRanksByEntityIdsRequest());

		// Token: 0x04004373 RID: 17267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004374 RID: 17268
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x04004375 RID: 17269
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x04004376 RID: 17270
		private string leaderboardId_;

		// Token: 0x04004377 RID: 17271
		public const int EntityIdsFieldNumber = 2;

		// Token: 0x04004378 RID: 17272
		private static readonly FieldCodec<string> _repeated_entityIds_codec = FieldCodec.ForString(18U);

		// Token: 0x04004379 RID: 17273
		private readonly RepeatedField<string> entityIds_ = new RepeatedField<string>();
	}
}
