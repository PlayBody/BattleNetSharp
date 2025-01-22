using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D8 RID: 1240
	public sealed class UpdateStreamStateRequest : IMessage<UpdateStreamStateRequest>, IMessage, IEquatable<UpdateStreamStateRequest>, IDeepCloneable<UpdateStreamStateRequest>, IBufferMessage
	{
		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x001D4C7C File Offset: 0x001D2E7C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateStreamStateRequest> Parser
		{
			get
			{
				return UpdateStreamStateRequest._parser;
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06007885 RID: 30853 RVA: 0x001D4C94 File Offset: 0x001D2E94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[61];
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x001D4CB8 File Offset: 0x001D2EB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateStreamStateRequest.Descriptor;
			}
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x001D4CCF File Offset: 0x001D2ECF
		[DebuggerNonUserCode]
		public UpdateStreamStateRequest()
		{
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x001D4CDC File Offset: 0x001D2EDC
		[DebuggerNonUserCode]
		public UpdateStreamStateRequest(UpdateStreamStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x001D4D60 File Offset: 0x001D2F60
		[DebuggerNonUserCode]
		public UpdateStreamStateRequest Clone()
		{
			return new UpdateStreamStateRequest(this);
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x001D4D78 File Offset: 0x001D2F78
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x001D4D90 File Offset: 0x001D2F90
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

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x001D4D9C File Offset: 0x001D2F9C
		// (set) Token: 0x0600788D RID: 30861 RVA: 0x001D4DCD File Offset: 0x001D2FCD
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
					clubIdDefaultValue = UpdateStreamStateRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x001D4DE8 File Offset: 0x001D2FE8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x001D4E05 File Offset: 0x001D3005
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x001D4E18 File Offset: 0x001D3018
		// (set) Token: 0x06007891 RID: 30865 RVA: 0x001D4E49 File Offset: 0x001D3049
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
					streamIdDefaultValue = UpdateStreamStateRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06007892 RID: 30866 RVA: 0x001D4E64 File Offset: 0x001D3064
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x001D4E81 File Offset: 0x001D3081
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x001D4E94 File Offset: 0x001D3094
		// (set) Token: 0x06007895 RID: 30869 RVA: 0x001D4EAC File Offset: 0x001D30AC
		[DebuggerNonUserCode]
		public StreamStateOptions Options
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

		// Token: 0x06007896 RID: 30870 RVA: 0x001D4EB8 File Offset: 0x001D30B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateStreamStateRequest);
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x001D4ED8 File Offset: 0x001D30D8
		[DebuggerNonUserCode]
		public bool Equals(UpdateStreamStateRequest other)
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

		// Token: 0x06007898 RID: 30872 RVA: 0x001D4F8C File Offset: 0x001D318C
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

		// Token: 0x06007899 RID: 30873 RVA: 0x001D5034 File Offset: 0x001D3234
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x001D504C File Offset: 0x001D324C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x001D5058 File Offset: 0x001D3258
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
				output.WriteRawTag(42);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x001D5114 File Offset: 0x001D3314
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

		// Token: 0x0600789D RID: 30877 RVA: 0x001D51C4 File Offset: 0x001D33C4
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateStreamStateRequest other)
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
						this.Options = new StreamStateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x001D52A7 File Offset: 0x001D34A7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x001D52B4 File Offset: 0x001D34B4
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
					if (num3 != 42U)
					{
						goto IL_002C;
					}
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new StreamStateOptions();
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

		// Token: 0x040036B6 RID: 14006
		private static readonly MessageParser<UpdateStreamStateRequest> _parser = new MessageParser<UpdateStreamStateRequest>(() => new UpdateStreamStateRequest());

		// Token: 0x040036B7 RID: 14007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B8 RID: 14008
		private int _hasBits0;

		// Token: 0x040036B9 RID: 14009
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036BA RID: 14010
		private MemberId agentId_;

		// Token: 0x040036BB RID: 14011
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036BC RID: 14012
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036BD RID: 14013
		private ulong clubId_;

		// Token: 0x040036BE RID: 14014
		public const int StreamIdFieldNumber = 3;

		// Token: 0x040036BF RID: 14015
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040036C0 RID: 14016
		private ulong streamId_;

		// Token: 0x040036C1 RID: 14017
		public const int OptionsFieldNumber = 5;

		// Token: 0x040036C2 RID: 14018
		private StreamStateOptions options_;
	}
}
