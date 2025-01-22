using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BC RID: 1212
	public sealed class DeclineSuggestionRequest : IMessage<DeclineSuggestionRequest>, IMessage, IEquatable<DeclineSuggestionRequest>, IDeepCloneable<DeclineSuggestionRequest>, IBufferMessage
	{
		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x060075E5 RID: 30181 RVA: 0x001CBD5C File Offset: 0x001C9F5C
		[DebuggerNonUserCode]
		public static MessageParser<DeclineSuggestionRequest> Parser
		{
			get
			{
				return DeclineSuggestionRequest._parser;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x060075E6 RID: 30182 RVA: 0x001CBD74 File Offset: 0x001C9F74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x060075E7 RID: 30183 RVA: 0x001CBD98 File Offset: 0x001C9F98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclineSuggestionRequest.Descriptor;
			}
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x001CBDAF File Offset: 0x001C9FAF
		[DebuggerNonUserCode]
		public DeclineSuggestionRequest()
		{
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x001CBDBC File Offset: 0x001C9FBC
		[DebuggerNonUserCode]
		public DeclineSuggestionRequest(DeclineSuggestionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.suggestionId_ = other.suggestionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x001CBE24 File Offset: 0x001CA024
		[DebuggerNonUserCode]
		public DeclineSuggestionRequest Clone()
		{
			return new DeclineSuggestionRequest(this);
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x001CBE3C File Offset: 0x001CA03C
		// (set) Token: 0x060075EC RID: 30188 RVA: 0x001CBE54 File Offset: 0x001CA054
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

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x060075ED RID: 30189 RVA: 0x001CBE60 File Offset: 0x001CA060
		// (set) Token: 0x060075EE RID: 30190 RVA: 0x001CBE91 File Offset: 0x001CA091
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
					clubIdDefaultValue = DeclineSuggestionRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x001CBEAC File Offset: 0x001CA0AC
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x001CBEC9 File Offset: 0x001CA0C9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x001CBEDC File Offset: 0x001CA0DC
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x001CBF0D File Offset: 0x001CA10D
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
					suggestionIdDefaultValue = DeclineSuggestionRequest.SuggestionIdDefaultValue;
				}
				return suggestionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.suggestionId_ = value;
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x001CBF28 File Offset: 0x001CA128
		[DebuggerNonUserCode]
		public bool HasSuggestionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x001CBF45 File Offset: 0x001CA145
		[DebuggerNonUserCode]
		public void ClearSuggestionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x001CBF58 File Offset: 0x001CA158
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclineSuggestionRequest);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x001CBF78 File Offset: 0x001CA178
		[DebuggerNonUserCode]
		public bool Equals(DeclineSuggestionRequest other)
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

		// Token: 0x060075F7 RID: 30199 RVA: 0x001CC008 File Offset: 0x001CA208
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

		// Token: 0x060075F8 RID: 30200 RVA: 0x001CC094 File Offset: 0x001CA294
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x001CC0AC File Offset: 0x001CA2AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x001CC0B8 File Offset: 0x001CA2B8
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

		// Token: 0x060075FB RID: 30203 RVA: 0x001CC14C File Offset: 0x001CA34C
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

		// Token: 0x060075FC RID: 30204 RVA: 0x001CC1D0 File Offset: 0x001CA3D0
		[DebuggerNonUserCode]
		public void MergeFrom(DeclineSuggestionRequest other)
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

		// Token: 0x060075FD RID: 30205 RVA: 0x001CC273 File Offset: 0x001CA473
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x001CC280 File Offset: 0x001CA480
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

		// Token: 0x040035B9 RID: 13753
		private static readonly MessageParser<DeclineSuggestionRequest> _parser = new MessageParser<DeclineSuggestionRequest>(() => new DeclineSuggestionRequest());

		// Token: 0x040035BA RID: 13754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035BB RID: 13755
		private int _hasBits0;

		// Token: 0x040035BC RID: 13756
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035BD RID: 13757
		private MemberId agentId_;

		// Token: 0x040035BE RID: 13758
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035BF RID: 13759
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035C0 RID: 13760
		private ulong clubId_;

		// Token: 0x040035C1 RID: 13761
		public const int SuggestionIdFieldNumber = 3;

		// Token: 0x040035C2 RID: 13762
		private static readonly ulong SuggestionIdDefaultValue = 0UL;

		// Token: 0x040035C3 RID: 13763
		private ulong suggestionId_;
	}
}
