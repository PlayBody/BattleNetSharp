using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BB RID: 1211
	public sealed class AcceptSuggestionRequest : IMessage<AcceptSuggestionRequest>, IMessage, IEquatable<AcceptSuggestionRequest>, IDeepCloneable<AcceptSuggestionRequest>, IBufferMessage
	{
		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x060075CA RID: 30154 RVA: 0x001CB770 File Offset: 0x001C9970
		[DebuggerNonUserCode]
		public static MessageParser<AcceptSuggestionRequest> Parser
		{
			get
			{
				return AcceptSuggestionRequest._parser;
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x060075CB RID: 30155 RVA: 0x001CB788 File Offset: 0x001C9988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x001CB7AC File Offset: 0x001C99AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptSuggestionRequest.Descriptor;
			}
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x001CB7C3 File Offset: 0x001C99C3
		[DebuggerNonUserCode]
		public AcceptSuggestionRequest()
		{
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x001CB7D0 File Offset: 0x001C99D0
		[DebuggerNonUserCode]
		public AcceptSuggestionRequest(AcceptSuggestionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.suggestionId_ = other.suggestionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x001CB838 File Offset: 0x001C9A38
		[DebuggerNonUserCode]
		public AcceptSuggestionRequest Clone()
		{
			return new AcceptSuggestionRequest(this);
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x060075D0 RID: 30160 RVA: 0x001CB850 File Offset: 0x001C9A50
		// (set) Token: 0x060075D1 RID: 30161 RVA: 0x001CB868 File Offset: 0x001C9A68
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

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x001CB874 File Offset: 0x001C9A74
		// (set) Token: 0x060075D3 RID: 30163 RVA: 0x001CB8A5 File Offset: 0x001C9AA5
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
					clubIdDefaultValue = AcceptSuggestionRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x060075D4 RID: 30164 RVA: 0x001CB8C0 File Offset: 0x001C9AC0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x001CB8DD File Offset: 0x001C9ADD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x001CB8F0 File Offset: 0x001C9AF0
		// (set) Token: 0x060075D7 RID: 30167 RVA: 0x001CB921 File Offset: 0x001C9B21
		[DebuggerNonUserCode]
		public ulong SuggestionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong suggestionIdDefaultValue;
				if (flag)
				{
					suggestionIdDefaultValue = this.suggestionId_;
				}
				else
				{
					suggestionIdDefaultValue = AcceptSuggestionRequest.SuggestionIdDefaultValue;
				}
				return suggestionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.suggestionId_ = value;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x001CB93C File Offset: 0x001C9B3C
		[DebuggerNonUserCode]
		public bool HasSuggestionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x001CB959 File Offset: 0x001C9B59
		[DebuggerNonUserCode]
		public void ClearSuggestionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x001CB96C File Offset: 0x001C9B6C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptSuggestionRequest);
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x001CB98C File Offset: 0x001C9B8C
		[DebuggerNonUserCode]
		public bool Equals(AcceptSuggestionRequest other)
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
							bool flag6 = this.SuggestionId != other.SuggestionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x001CBA1C File Offset: 0x001C9C1C
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num ^= this.SuggestionId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x001CBAA8 File Offset: 0x001C9CA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x001CBAC0 File Offset: 0x001C9CC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x001CBACC File Offset: 0x001C9CCC
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.SuggestionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x001CBB60 File Offset: 0x001C9D60
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
			bool hasSuggestionId = this.HasSuggestionId;
			if (hasSuggestionId)
			{
				num += 9;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x001CBBE4 File Offset: 0x001C9DE4
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptSuggestionRequest other)
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
				bool hasSuggestionId = other.HasSuggestionId;
				if (hasSuggestionId)
				{
					this.SuggestionId = other.SuggestionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x001CBC87 File Offset: 0x001C9E87
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x001CBC94 File Offset: 0x001C9E94
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
						if (num3 != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SuggestionId = input.ReadFixed64();
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

		// Token: 0x040035AE RID: 13742
		private static readonly MessageParser<AcceptSuggestionRequest> _parser = new MessageParser<AcceptSuggestionRequest>(() => new AcceptSuggestionRequest());

		// Token: 0x040035AF RID: 13743
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B0 RID: 13744
		private int _hasBits0;

		// Token: 0x040035B1 RID: 13745
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035B2 RID: 13746
		private MemberId agentId_;

		// Token: 0x040035B3 RID: 13747
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035B4 RID: 13748
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035B5 RID: 13749
		private ulong clubId_;

		// Token: 0x040035B6 RID: 13750
		public const int SuggestionIdFieldNumber = 3;

		// Token: 0x040035B7 RID: 13751
		private static readonly ulong SuggestionIdDefaultValue = 0UL;

		// Token: 0x040035B8 RID: 13752
		private ulong suggestionId_;
	}
}
