using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BA RID: 1210
	public sealed class SendSuggestionRequest : IMessage<SendSuggestionRequest>, IMessage, IEquatable<SendSuggestionRequest>, IDeepCloneable<SendSuggestionRequest>, IBufferMessage
	{
		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x060075B1 RID: 30129 RVA: 0x001CB178 File Offset: 0x001C9378
		[DebuggerNonUserCode]
		public static MessageParser<SendSuggestionRequest> Parser
		{
			get
			{
				return SendSuggestionRequest._parser;
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x060075B2 RID: 30130 RVA: 0x001CB190 File Offset: 0x001C9390
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x001CB1B4 File Offset: 0x001C93B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendSuggestionRequest.Descriptor;
			}
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x001CB1CB File Offset: 0x001C93CB
		[DebuggerNonUserCode]
		public SendSuggestionRequest()
		{
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x001CB1D8 File Offset: 0x001C93D8
		[DebuggerNonUserCode]
		public SendSuggestionRequest(SendSuggestionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x001CB250 File Offset: 0x001C9450
		[DebuggerNonUserCode]
		public SendSuggestionRequest Clone()
		{
			return new SendSuggestionRequest(this);
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x001CB268 File Offset: 0x001C9468
		// (set) Token: 0x060075B8 RID: 30136 RVA: 0x001CB280 File Offset: 0x001C9480
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

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x001CB28C File Offset: 0x001C948C
		// (set) Token: 0x060075BA RID: 30138 RVA: 0x001CB2BD File Offset: 0x001C94BD
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
					clubIdDefaultValue = SendSuggestionRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x001CB2D8 File Offset: 0x001C94D8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x001CB2F5 File Offset: 0x001C94F5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x001CB308 File Offset: 0x001C9508
		// (set) Token: 0x060075BE RID: 30142 RVA: 0x001CB320 File Offset: 0x001C9520
		[DebuggerNonUserCode]
		public SendSuggestionOptions Options
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

		// Token: 0x060075BF RID: 30143 RVA: 0x001CB32C File Offset: 0x001C952C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendSuggestionRequest);
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x001CB34C File Offset: 0x001C954C
		[DebuggerNonUserCode]
		public bool Equals(SendSuggestionRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x001CB3E0 File Offset: 0x001C95E0
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

		// Token: 0x060075C2 RID: 30146 RVA: 0x001CB46C File Offset: 0x001C966C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x001CB484 File Offset: 0x001C9684
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x001CB490 File Offset: 0x001C9690
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x001CB528 File Offset: 0x001C9728
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

		// Token: 0x060075C6 RID: 30150 RVA: 0x001CB5B8 File Offset: 0x001C97B8
		[DebuggerNonUserCode]
		public void MergeFrom(SendSuggestionRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SendSuggestionOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x001CB680 File Offset: 0x001C9880
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x001CB68C File Offset: 0x001C988C
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new SendSuggestionOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040035A4 RID: 13732
		private static readonly MessageParser<SendSuggestionRequest> _parser = new MessageParser<SendSuggestionRequest>(() => new SendSuggestionRequest());

		// Token: 0x040035A5 RID: 13733
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A6 RID: 13734
		private int _hasBits0;

		// Token: 0x040035A7 RID: 13735
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035A8 RID: 13736
		private MemberId agentId_;

		// Token: 0x040035A9 RID: 13737
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035AA RID: 13738
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035AB RID: 13739
		private ulong clubId_;

		// Token: 0x040035AC RID: 13740
		public const int OptionsFieldNumber = 3;

		// Token: 0x040035AD RID: 13741
		private SendSuggestionOptions options_;
	}
}
