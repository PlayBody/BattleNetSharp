using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x0200058A RID: 1418
	public sealed class ClubOptions : IMessage<ClubOptions>, IMessage, IEquatable<ClubOptions>, IDeepCloneable<ClubOptions>, IBufferMessage
	{
		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x0020FDA4 File Offset: 0x0020DFA4
		[DebuggerNonUserCode]
		public static MessageParser<ClubOptions> Parser
		{
			get
			{
				return ClubOptions._parser;
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x060087C5 RID: 34757 RVA: 0x0020FDBC File Offset: 0x0020DFBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x060087C6 RID: 34758 RVA: 0x0020FDE0 File Offset: 0x0020DFE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubOptions.Descriptor;
			}
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x0020FDF7 File Offset: 0x0020DFF7
		[DebuggerNonUserCode]
		public ClubOptions()
		{
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x0020FE04 File Offset: 0x0020E004
		[DebuggerNonUserCode]
		public ClubOptions(ClubOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.type_ = other.type_;
			this.source_ = other.source_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x0020FE84 File Offset: 0x0020E084
		[DebuggerNonUserCode]
		public ClubOptions Clone()
		{
			return new ClubOptions(this);
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x060087CA RID: 34762 RVA: 0x0020FE9C File Offset: 0x0020E09C
		// (set) Token: 0x060087CB RID: 34763 RVA: 0x0020FECD File Offset: 0x0020E0CD
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
					clubIdDefaultValue = ClubOptions.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x0020FEE8 File Offset: 0x0020E0E8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060087CD RID: 34765 RVA: 0x0020FF05 File Offset: 0x0020E105
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x0020FF18 File Offset: 0x0020E118
		// (set) Token: 0x060087CF RID: 34767 RVA: 0x0020FF49 File Offset: 0x0020E149
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
					streamIdDefaultValue = ClubOptions.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x060087D0 RID: 34768 RVA: 0x0020FF64 File Offset: 0x0020E164
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x0020FF81 File Offset: 0x0020E181
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x060087D2 RID: 34770 RVA: 0x0020FF94 File Offset: 0x0020E194
		// (set) Token: 0x060087D3 RID: 34771 RVA: 0x0020FFC5 File Offset: 0x0020E1C5
		[DebuggerNonUserCode]
		public IssueType Type
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				IssueType typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = ClubOptions.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.type_ = value;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x060087D4 RID: 34772 RVA: 0x0020FFE0 File Offset: 0x0020E1E0
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x0020FFFD File Offset: 0x0020E1FD
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x060087D6 RID: 34774 RVA: 0x00210010 File Offset: 0x0020E210
		// (set) Token: 0x060087D7 RID: 34775 RVA: 0x00210041 File Offset: 0x0020E241
		[DebuggerNonUserCode]
		public ClubSource Source
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ClubSource sourceDefaultValue;
				if (flag)
				{
					sourceDefaultValue = this.source_;
				}
				else
				{
					sourceDefaultValue = ClubOptions.SourceDefaultValue;
				}
				return sourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.source_ = value;
			}
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x060087D8 RID: 34776 RVA: 0x0021005C File Offset: 0x0020E25C
		[DebuggerNonUserCode]
		public bool HasSource
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00210079 File Offset: 0x0020E279
		[DebuggerNonUserCode]
		public void ClearSource()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x060087DA RID: 34778 RVA: 0x0021008C File Offset: 0x0020E28C
		// (set) Token: 0x060087DB RID: 34779 RVA: 0x002100A4 File Offset: 0x0020E2A4
		[DebuggerNonUserCode]
		public ReportItem Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x002100B0 File Offset: 0x0020E2B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubOptions);
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x002100D0 File Offset: 0x0020E2D0
		[DebuggerNonUserCode]
		public bool Equals(ClubOptions other)
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
					bool flag4 = this.ClubId != other.ClubId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StreamId != other.StreamId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Type != other.Type;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Source != other.Source;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Item, other.Item);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x002101A0 File Offset: 0x0020E3A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num ^= this.Source.GetHashCode();
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				num ^= this.Item.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x00210274 File Offset: 0x0020E474
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x0021028C File Offset: 0x0020E48C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x00210298 File Offset: 0x0020E498
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StreamId);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Type);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Source);
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Item);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00210374 File Offset: 0x0020E574
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x00210440 File Offset: 0x0020E640
		[DebuggerNonUserCode]
		public void MergeFrom(ClubOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasSource = other.HasSource;
				if (hasSource)
				{
					this.Source = other.Source;
				}
				bool flag2 = other.item_ != null;
				if (flag2)
				{
					bool flag3 = this.item_ == null;
					if (flag3)
					{
						this.Item = new ReportItem();
					}
					this.Item.MergeFrom(other.Item);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x00210519 File Offset: 0x0020E719
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x00210524 File Offset: 0x0020E724
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.StreamId = input.ReadUInt64();
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						bool flag = this.item_ == null;
						if (flag)
						{
							this.Item = new ReportItem();
						}
						input.ReadMessage(this.Item);
					}
					else
					{
						this.Source = (ClubSource)input.ReadEnum();
					}
				}
				else
				{
					this.Type = (IssueType)input.ReadEnum();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D87 RID: 15751
		private static readonly MessageParser<ClubOptions> _parser = new MessageParser<ClubOptions>(() => new ClubOptions());

		// Token: 0x04003D88 RID: 15752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D89 RID: 15753
		private int _hasBits0;

		// Token: 0x04003D8A RID: 15754
		public const int ClubIdFieldNumber = 1;

		// Token: 0x04003D8B RID: 15755
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003D8C RID: 15756
		private ulong clubId_;

		// Token: 0x04003D8D RID: 15757
		public const int StreamIdFieldNumber = 2;

		// Token: 0x04003D8E RID: 15758
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003D8F RID: 15759
		private ulong streamId_;

		// Token: 0x04003D90 RID: 15760
		public const int TypeFieldNumber = 3;

		// Token: 0x04003D91 RID: 15761
		private static readonly IssueType TypeDefaultValue = IssueType.Spam;

		// Token: 0x04003D92 RID: 15762
		private IssueType type_;

		// Token: 0x04003D93 RID: 15763
		public const int SourceFieldNumber = 4;

		// Token: 0x04003D94 RID: 15764
		private static readonly ClubSource SourceDefaultValue = ClubSource.None;

		// Token: 0x04003D95 RID: 15765
		private ClubSource source_;

		// Token: 0x04003D96 RID: 15766
		public const int ItemFieldNumber = 5;

		// Token: 0x04003D97 RID: 15767
		private ReportItem item_;
	}
}
