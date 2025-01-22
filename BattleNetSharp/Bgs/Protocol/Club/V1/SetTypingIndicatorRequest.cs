using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E1 RID: 1249
	public sealed class SetTypingIndicatorRequest : IMessage<SetTypingIndicatorRequest>, IMessage, IEquatable<SetTypingIndicatorRequest>, IDeepCloneable<SetTypingIndicatorRequest>, IBufferMessage
	{
		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x001D8210 File Offset: 0x001D6410
		[DebuggerNonUserCode]
		public static MessageParser<SetTypingIndicatorRequest> Parser
		{
			get
			{
				return SetTypingIndicatorRequest._parser;
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600796E RID: 31086 RVA: 0x001D8228 File Offset: 0x001D6428
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[70];
			}
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x001D824C File Offset: 0x001D644C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetTypingIndicatorRequest.Descriptor;
			}
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x001D8263 File Offset: 0x001D6463
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest()
		{
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x001D8270 File Offset: 0x001D6470
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest(SetTypingIndicatorRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.indicator_ = other.indicator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x001D82E4 File Offset: 0x001D64E4
		[DebuggerNonUserCode]
		public SetTypingIndicatorRequest Clone()
		{
			return new SetTypingIndicatorRequest(this);
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06007973 RID: 31091 RVA: 0x001D82FC File Offset: 0x001D64FC
		// (set) Token: 0x06007974 RID: 31092 RVA: 0x001D8314 File Offset: 0x001D6514
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

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x001D8320 File Offset: 0x001D6520
		// (set) Token: 0x06007976 RID: 31094 RVA: 0x001D8351 File Offset: 0x001D6551
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
					clubIdDefaultValue = SetTypingIndicatorRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06007977 RID: 31095 RVA: 0x001D836C File Offset: 0x001D656C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x001D8389 File Offset: 0x001D6589
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x001D839C File Offset: 0x001D659C
		// (set) Token: 0x0600797A RID: 31098 RVA: 0x001D83CD File Offset: 0x001D65CD
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
					streamIdDefaultValue = SetTypingIndicatorRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600797B RID: 31099 RVA: 0x001D83E8 File Offset: 0x001D65E8
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x001D8405 File Offset: 0x001D6605
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x001D8418 File Offset: 0x001D6618
		// (set) Token: 0x0600797E RID: 31102 RVA: 0x001D8449 File Offset: 0x001D6649
		[DebuggerNonUserCode]
		public TypingIndicator Indicator
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				TypingIndicator indicatorDefaultValue;
				if (flag)
				{
					indicatorDefaultValue = this.indicator_;
				}
				else
				{
					indicatorDefaultValue = SetTypingIndicatorRequest.IndicatorDefaultValue;
				}
				return indicatorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.indicator_ = value;
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x001D8464 File Offset: 0x001D6664
		[DebuggerNonUserCode]
		public bool HasIndicator
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x001D8481 File Offset: 0x001D6681
		[DebuggerNonUserCode]
		public void ClearIndicator()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x001D8494 File Offset: 0x001D6694
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetTypingIndicatorRequest);
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x001D84B4 File Offset: 0x001D66B4
		[DebuggerNonUserCode]
		public bool Equals(SetTypingIndicatorRequest other)
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
								bool flag7 = this.Indicator != other.Indicator;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x001D8564 File Offset: 0x001D6764
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
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				num ^= this.Indicator.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x001D8614 File Offset: 0x001D6814
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x001D862C File Offset: 0x001D682C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x001D8638 File Offset: 0x001D6838
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
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Indicator);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x001D86F0 File Offset: 0x001D68F0
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
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Indicator);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x001D879C File Offset: 0x001D699C
		[DebuggerNonUserCode]
		public void MergeFrom(SetTypingIndicatorRequest other)
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
				bool hasIndicator = other.HasIndicator;
				if (hasIndicator)
				{
					this.Indicator = other.Indicator;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x001D885A File Offset: 0x001D6A5A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x001D8868 File Offset: 0x001D6A68
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
					this.Indicator = (TypingIndicator)input.ReadEnum();
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

		// Token: 0x04003711 RID: 14097
		private static readonly MessageParser<SetTypingIndicatorRequest> _parser = new MessageParser<SetTypingIndicatorRequest>(() => new SetTypingIndicatorRequest());

		// Token: 0x04003712 RID: 14098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003713 RID: 14099
		private int _hasBits0;

		// Token: 0x04003714 RID: 14100
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003715 RID: 14101
		private MemberId agentId_;

		// Token: 0x04003716 RID: 14102
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003717 RID: 14103
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003718 RID: 14104
		private ulong clubId_;

		// Token: 0x04003719 RID: 14105
		public const int StreamIdFieldNumber = 3;

		// Token: 0x0400371A RID: 14106
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400371B RID: 14107
		private ulong streamId_;

		// Token: 0x0400371C RID: 14108
		public const int IndicatorFieldNumber = 4;

		// Token: 0x0400371D RID: 14109
		private static readonly TypingIndicator IndicatorDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x0400371E RID: 14110
		private TypingIndicator indicator_;
	}
}
