using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A7 RID: 1191
	public sealed class JoinRequest : IMessage<JoinRequest>, IMessage, IEquatable<JoinRequest>, IDeepCloneable<JoinRequest>, IBufferMessage
	{
		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x060073DC RID: 29660 RVA: 0x001C48BC File Offset: 0x001C2ABC
		[DebuggerNonUserCode]
		public static MessageParser<JoinRequest> Parser
		{
			get
			{
				return JoinRequest._parser;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x001C48D4 File Offset: 0x001C2AD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x001C48F8 File Offset: 0x001C2AF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinRequest.Descriptor;
			}
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x001C490F File Offset: 0x001C2B0F
		[DebuggerNonUserCode]
		public JoinRequest()
		{
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x001C491C File Offset: 0x001C2B1C
		[DebuggerNonUserCode]
		public JoinRequest(JoinRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x001C4994 File Offset: 0x001C2B94
		[DebuggerNonUserCode]
		public JoinRequest Clone()
		{
			return new JoinRequest(this);
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x001C49AC File Offset: 0x001C2BAC
		// (set) Token: 0x060073E3 RID: 29667 RVA: 0x001C49C4 File Offset: 0x001C2BC4
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

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x001C49D0 File Offset: 0x001C2BD0
		// (set) Token: 0x060073E5 RID: 29669 RVA: 0x001C4A01 File Offset: 0x001C2C01
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
					clubIdDefaultValue = JoinRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x001C4A1C File Offset: 0x001C2C1C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x001C4A39 File Offset: 0x001C2C39
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x001C4A4C File Offset: 0x001C2C4C
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x001C4A64 File Offset: 0x001C2C64
		[DebuggerNonUserCode]
		public CreateMemberOptions Options
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

		// Token: 0x060073EA RID: 29674 RVA: 0x001C4A70 File Offset: 0x001C2C70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinRequest);
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x001C4A90 File Offset: 0x001C2C90
		[DebuggerNonUserCode]
		public bool Equals(JoinRequest other)
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

		// Token: 0x060073EC RID: 29676 RVA: 0x001C4B24 File Offset: 0x001C2D24
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

		// Token: 0x060073ED RID: 29677 RVA: 0x001C4BB0 File Offset: 0x001C2DB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x001C4BC8 File Offset: 0x001C2DC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x001C4BD4 File Offset: 0x001C2DD4
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

		// Token: 0x060073F0 RID: 29680 RVA: 0x001C4C6C File Offset: 0x001C2E6C
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

		// Token: 0x060073F1 RID: 29681 RVA: 0x001C4CFC File Offset: 0x001C2EFC
		[DebuggerNonUserCode]
		public void MergeFrom(JoinRequest other)
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
						this.Options = new CreateMemberOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x001C4DC4 File Offset: 0x001C2FC4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x001C4DD0 File Offset: 0x001C2FD0
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
								this.Options = new CreateMemberOptions();
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

		// Token: 0x040034EE RID: 13550
		private static readonly MessageParser<JoinRequest> _parser = new MessageParser<JoinRequest>(() => new JoinRequest());

		// Token: 0x040034EF RID: 13551
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034F0 RID: 13552
		private int _hasBits0;

		// Token: 0x040034F1 RID: 13553
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034F2 RID: 13554
		private MemberId agentId_;

		// Token: 0x040034F3 RID: 13555
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034F4 RID: 13556
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034F5 RID: 13557
		private ulong clubId_;

		// Token: 0x040034F6 RID: 13558
		public const int OptionsFieldNumber = 3;

		// Token: 0x040034F7 RID: 13559
		private CreateMemberOptions options_;
	}
}
