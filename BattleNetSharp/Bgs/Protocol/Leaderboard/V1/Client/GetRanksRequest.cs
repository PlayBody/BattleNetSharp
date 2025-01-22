using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000643 RID: 1603
	public sealed class GetRanksRequest : IMessage<GetRanksRequest>, IMessage, IEquatable<GetRanksRequest>, IDeepCloneable<GetRanksRequest>, IBufferMessage
	{
		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600950F RID: 38159 RVA: 0x00241114 File Offset: 0x0023F314
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksRequest> Parser
		{
			get
			{
				return GetRanksRequest._parser;
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x06009510 RID: 38160 RVA: 0x0024112C File Offset: 0x0023F32C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x00241150 File Offset: 0x0023F350
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksRequest.Descriptor;
			}
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00241167 File Offset: 0x0023F367
		[DebuggerNonUserCode]
		public GetRanksRequest()
		{
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x00241174 File Offset: 0x0023F374
		[DebuggerNonUserCode]
		public GetRanksRequest(GetRanksRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.leaderboardId_ = other.leaderboardId_;
			this.continuation_ = other.continuation_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x002411CC File Offset: 0x0023F3CC
		[DebuggerNonUserCode]
		public GetRanksRequest Clone()
		{
			return new GetRanksRequest(this);
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x06009515 RID: 38165 RVA: 0x002411E4 File Offset: 0x0023F3E4
		// (set) Token: 0x06009516 RID: 38166 RVA: 0x00241205 File Offset: 0x0023F405
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x06009517 RID: 38167 RVA: 0x0024121C File Offset: 0x0023F41C
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00241237 File Offset: 0x0023F437
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x06009519 RID: 38169 RVA: 0x00241244 File Offset: 0x0023F444
		// (set) Token: 0x0600951A RID: 38170 RVA: 0x00241275 File Offset: 0x0023F475
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetRanksRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x00241290 File Offset: 0x0023F490
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x002412AD File Offset: 0x0023F4AD
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600951D RID: 38173 RVA: 0x002412C0 File Offset: 0x0023F4C0
		// (set) Token: 0x0600951E RID: 38174 RVA: 0x002412F1 File Offset: 0x0023F4F1
		[DebuggerNonUserCode]
		public uint Count
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint countDefaultValue;
				if (flag)
				{
					countDefaultValue = this.count_;
				}
				else
				{
					countDefaultValue = GetRanksRequest.CountDefaultValue;
				}
				return countDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.count_ = value;
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600951F RID: 38175 RVA: 0x0024130C File Offset: 0x0023F50C
		[DebuggerNonUserCode]
		public bool HasCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x00241329 File Offset: 0x0023F529
		[DebuggerNonUserCode]
		public void ClearCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x0024133C File Offset: 0x0023F53C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksRequest);
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x0024135C File Offset: 0x0023F55C
		[DebuggerNonUserCode]
		public bool Equals(GetRanksRequest other)
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
						bool flag5 = this.Continuation != other.Continuation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Count != other.Count;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x002413E8 File Offset: 0x0023F5E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x00241470 File Offset: 0x0023F670
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x00241488 File Offset: 0x0023F688
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00241494 File Offset: 0x0023F694
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Count);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x00241524 File Offset: 0x0023F724
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x002415B0 File Offset: 0x0023F7B0
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				bool hasCount = other.HasCount;
				if (hasCount)
				{
					this.Count = other.Count;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x0024162B File Offset: 0x0023F82B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x00241638 File Offset: 0x0023F838
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
							this.Count = input.ReadUInt32();
						}
					}
					else
					{
						this.Continuation = input.ReadUInt64();
					}
				}
				else
				{
					this.LeaderboardId = input.ReadString();
				}
			}
		}

		// Token: 0x04004324 RID: 17188
		private static readonly MessageParser<GetRanksRequest> _parser = new MessageParser<GetRanksRequest>(() => new GetRanksRequest());

		// Token: 0x04004325 RID: 17189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004326 RID: 17190
		private int _hasBits0;

		// Token: 0x04004327 RID: 17191
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x04004328 RID: 17192
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x04004329 RID: 17193
		private string leaderboardId_;

		// Token: 0x0400432A RID: 17194
		public const int ContinuationFieldNumber = 2;

		// Token: 0x0400432B RID: 17195
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400432C RID: 17196
		private ulong continuation_;

		// Token: 0x0400432D RID: 17197
		public const int CountFieldNumber = 3;

		// Token: 0x0400432E RID: 17198
		private static readonly uint CountDefaultValue = 10U;

		// Token: 0x0400432F RID: 17199
		private uint count_;
	}
}
