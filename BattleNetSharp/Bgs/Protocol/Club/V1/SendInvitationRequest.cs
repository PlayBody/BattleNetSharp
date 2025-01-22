using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B2 RID: 1202
	public sealed class SendInvitationRequest : IMessage<SendInvitationRequest>, IMessage, IEquatable<SendInvitationRequest>, IDeepCloneable<SendInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x060074E8 RID: 29928 RVA: 0x001C8628 File Offset: 0x001C6828
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationRequest> Parser
		{
			get
			{
				return SendInvitationRequest._parser;
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x001C8640 File Offset: 0x001C6840
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x001C8664 File Offset: 0x001C6864
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x001C867B File Offset: 0x001C687B
		[DebuggerNonUserCode]
		public SendInvitationRequest()
		{
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x001C8688 File Offset: 0x001C6888
		[DebuggerNonUserCode]
		public SendInvitationRequest(SendInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x001C8700 File Offset: 0x001C6900
		[DebuggerNonUserCode]
		public SendInvitationRequest Clone()
		{
			return new SendInvitationRequest(this);
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x060074EE RID: 29934 RVA: 0x001C8718 File Offset: 0x001C6918
		// (set) Token: 0x060074EF RID: 29935 RVA: 0x001C8730 File Offset: 0x001C6930
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

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x060074F0 RID: 29936 RVA: 0x001C873C File Offset: 0x001C693C
		// (set) Token: 0x060074F1 RID: 29937 RVA: 0x001C876D File Offset: 0x001C696D
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
					clubIdDefaultValue = SendInvitationRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x060074F2 RID: 29938 RVA: 0x001C8788 File Offset: 0x001C6988
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x001C87A5 File Offset: 0x001C69A5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x001C87B8 File Offset: 0x001C69B8
		// (set) Token: 0x060074F5 RID: 29941 RVA: 0x001C87D0 File Offset: 0x001C69D0
		[DebuggerNonUserCode]
		public SendInvitationOptions Options
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

		// Token: 0x060074F6 RID: 29942 RVA: 0x001C87DC File Offset: 0x001C69DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationRequest);
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x001C87FC File Offset: 0x001C69FC
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationRequest other)
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

		// Token: 0x060074F8 RID: 29944 RVA: 0x001C8890 File Offset: 0x001C6A90
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

		// Token: 0x060074F9 RID: 29945 RVA: 0x001C891C File Offset: 0x001C6B1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x001C8934 File Offset: 0x001C6B34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x001C8940 File Offset: 0x001C6B40
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

		// Token: 0x060074FC RID: 29948 RVA: 0x001C89D8 File Offset: 0x001C6BD8
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

		// Token: 0x060074FD RID: 29949 RVA: 0x001C8A68 File Offset: 0x001C6C68
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationRequest other)
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
						this.Options = new SendInvitationOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x001C8B30 File Offset: 0x001C6D30
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x001C8B3C File Offset: 0x001C6D3C
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
								this.Options = new SendInvitationOptions();
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

		// Token: 0x04003556 RID: 13654
		private static readonly MessageParser<SendInvitationRequest> _parser = new MessageParser<SendInvitationRequest>(() => new SendInvitationRequest());

		// Token: 0x04003557 RID: 13655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003558 RID: 13656
		private int _hasBits0;

		// Token: 0x04003559 RID: 13657
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400355A RID: 13658
		private MemberId agentId_;

		// Token: 0x0400355B RID: 13659
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400355C RID: 13660
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400355D RID: 13661
		private ulong clubId_;

		// Token: 0x0400355E RID: 13662
		public const int OptionsFieldNumber = 3;

		// Token: 0x0400355F RID: 13663
		private SendInvitationOptions options_;
	}
}
