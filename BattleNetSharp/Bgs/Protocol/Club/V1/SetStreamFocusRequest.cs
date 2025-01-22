using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D9 RID: 1241
	public sealed class SetStreamFocusRequest : IMessage<SetStreamFocusRequest>, IMessage, IEquatable<SetStreamFocusRequest>, IDeepCloneable<SetStreamFocusRequest>, IBufferMessage
	{
		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x001D53B8 File Offset: 0x001D35B8
		[DebuggerNonUserCode]
		public static MessageParser<SetStreamFocusRequest> Parser
		{
			get
			{
				return SetStreamFocusRequest._parser;
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x001D53D0 File Offset: 0x001D35D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[62];
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x001D53F4 File Offset: 0x001D35F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetStreamFocusRequest.Descriptor;
			}
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x001D540B File Offset: 0x001D360B
		[DebuggerNonUserCode]
		public SetStreamFocusRequest()
		{
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x001D5418 File Offset: 0x001D3618
		[DebuggerNonUserCode]
		public SetStreamFocusRequest(SetStreamFocusRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.focus_ = other.focus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x001D548C File Offset: 0x001D368C
		[DebuggerNonUserCode]
		public SetStreamFocusRequest Clone()
		{
			return new SetStreamFocusRequest(this);
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x001D54A4 File Offset: 0x001D36A4
		// (set) Token: 0x060078A8 RID: 30888 RVA: 0x001D54BC File Offset: 0x001D36BC
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

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x060078A9 RID: 30889 RVA: 0x001D54C8 File Offset: 0x001D36C8
		// (set) Token: 0x060078AA RID: 30890 RVA: 0x001D54F9 File Offset: 0x001D36F9
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
					clubIdDefaultValue = SetStreamFocusRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x001D5514 File Offset: 0x001D3714
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x001D5531 File Offset: 0x001D3731
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x001D5544 File Offset: 0x001D3744
		// (set) Token: 0x060078AE RID: 30894 RVA: 0x001D5575 File Offset: 0x001D3775
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
					streamIdDefaultValue = SetStreamFocusRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x001D5590 File Offset: 0x001D3790
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x001D55AD File Offset: 0x001D37AD
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x001D55C0 File Offset: 0x001D37C0
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x001D55F1 File Offset: 0x001D37F1
		[DebuggerNonUserCode]
		public bool Focus
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool focusDefaultValue;
				if (flag)
				{
					focusDefaultValue = this.focus_;
				}
				else
				{
					focusDefaultValue = SetStreamFocusRequest.FocusDefaultValue;
				}
				return focusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.focus_ = value;
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x001D560C File Offset: 0x001D380C
		[DebuggerNonUserCode]
		public bool HasFocus
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x001D5629 File Offset: 0x001D3829
		[DebuggerNonUserCode]
		public void ClearFocus()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x001D563C File Offset: 0x001D383C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetStreamFocusRequest);
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x001D565C File Offset: 0x001D385C
		[DebuggerNonUserCode]
		public bool Equals(SetStreamFocusRequest other)
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
								bool flag7 = this.Focus != other.Focus;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x001D570C File Offset: 0x001D390C
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
			bool hasFocus = this.HasFocus;
			if (hasFocus)
			{
				num ^= this.Focus.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x001D57B4 File Offset: 0x001D39B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x001D57CC File Offset: 0x001D39CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x001D57D8 File Offset: 0x001D39D8
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
			bool hasFocus = this.HasFocus;
			if (hasFocus)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Focus);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x001D5890 File Offset: 0x001D3A90
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
			bool hasFocus = this.HasFocus;
			if (hasFocus)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x001D5930 File Offset: 0x001D3B30
		[DebuggerNonUserCode]
		public void MergeFrom(SetStreamFocusRequest other)
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
				bool hasFocus = other.HasFocus;
				if (hasFocus)
				{
					this.Focus = other.Focus;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x001D59EE File Offset: 0x001D3BEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x001D59FC File Offset: 0x001D3BFC
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
					this.Focus = input.ReadBool();
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

		// Token: 0x040036C3 RID: 14019
		private static readonly MessageParser<SetStreamFocusRequest> _parser = new MessageParser<SetStreamFocusRequest>(() => new SetStreamFocusRequest());

		// Token: 0x040036C4 RID: 14020
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C5 RID: 14021
		private int _hasBits0;

		// Token: 0x040036C6 RID: 14022
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040036C7 RID: 14023
		private MemberId agentId_;

		// Token: 0x040036C8 RID: 14024
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040036C9 RID: 14025
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040036CA RID: 14026
		private ulong clubId_;

		// Token: 0x040036CB RID: 14027
		public const int StreamIdFieldNumber = 3;

		// Token: 0x040036CC RID: 14028
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040036CD RID: 14029
		private ulong streamId_;

		// Token: 0x040036CE RID: 14030
		public const int FocusFieldNumber = 4;

		// Token: 0x040036CF RID: 14031
		private static readonly bool FocusDefaultValue = false;

		// Token: 0x040036D0 RID: 14032
		private bool focus_;
	}
}
