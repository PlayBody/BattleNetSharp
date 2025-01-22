using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D6 RID: 1238
	public sealed class GetStreamsRequest : IMessage<GetStreamsRequest>, IMessage, IEquatable<GetStreamsRequest>, IDeepCloneable<GetStreamsRequest>, IBufferMessage
	{
		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x001D4174 File Offset: 0x001D2374
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamsRequest> Parser
		{
			get
			{
				return GetStreamsRequest._parser;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06007853 RID: 30803 RVA: 0x001D418C File Offset: 0x001D238C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[59];
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x001D41B0 File Offset: 0x001D23B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamsRequest.Descriptor;
			}
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x001D41C7 File Offset: 0x001D23C7
		[DebuggerNonUserCode]
		public GetStreamsRequest()
		{
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x001D41D4 File Offset: 0x001D23D4
		[DebuggerNonUserCode]
		public GetStreamsRequest(GetStreamsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x001D423C File Offset: 0x001D243C
		[DebuggerNonUserCode]
		public GetStreamsRequest Clone()
		{
			return new GetStreamsRequest(this);
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007858 RID: 30808 RVA: 0x001D4254 File Offset: 0x001D2454
		// (set) Token: 0x06007859 RID: 30809 RVA: 0x001D426C File Offset: 0x001D246C
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

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x001D4278 File Offset: 0x001D2478
		// (set) Token: 0x0600785B RID: 30811 RVA: 0x001D42A9 File Offset: 0x001D24A9
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
					clubIdDefaultValue = GetStreamsRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x001D42C4 File Offset: 0x001D24C4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x001D42E1 File Offset: 0x001D24E1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x001D42F4 File Offset: 0x001D24F4
		// (set) Token: 0x0600785F RID: 30815 RVA: 0x001D4325 File Offset: 0x001D2525
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
					continuationDefaultValue = GetStreamsRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06007860 RID: 30816 RVA: 0x001D4340 File Offset: 0x001D2540
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x001D435D File Offset: 0x001D255D
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x001D4370 File Offset: 0x001D2570
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamsRequest);
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x001D4390 File Offset: 0x001D2590
		[DebuggerNonUserCode]
		public bool Equals(GetStreamsRequest other)
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
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x001D4420 File Offset: 0x001D2620
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x001D44AC File Offset: 0x001D26AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x001D44C4 File Offset: 0x001D26C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x001D44D0 File Offset: 0x001D26D0
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x001D4564 File Offset: 0x001D2764
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x001D45F4 File Offset: 0x001D27F4
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamsRequest other)
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
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x001D4697 File Offset: 0x001D2897
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x001D46A4 File Offset: 0x001D28A4
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
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400369F RID: 13983
		private static readonly MessageParser<GetStreamsRequest> _parser = new MessageParser<GetStreamsRequest>(() => new GetStreamsRequest());

		// Token: 0x040036A0 RID: 13984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A1 RID: 13985
		private int _hasBits0;

		// Token: 0x040036A2 RID: 13986
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036A3 RID: 13987
		private MemberId agentId_;

		// Token: 0x040036A4 RID: 13988
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036A5 RID: 13989
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036A6 RID: 13990
		private ulong clubId_;

		// Token: 0x040036A7 RID: 13991
		public const int ContinuationFieldNumber = 3;

		// Token: 0x040036A8 RID: 13992
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040036A9 RID: 13993
		private ulong continuation_;
	}
}
