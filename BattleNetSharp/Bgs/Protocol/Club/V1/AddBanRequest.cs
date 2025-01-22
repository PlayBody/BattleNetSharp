using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C9 RID: 1225
	public sealed class AddBanRequest : IMessage<AddBanRequest>, IMessage, IEquatable<AddBanRequest>, IDeepCloneable<AddBanRequest>, IBufferMessage
	{
		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x001CFCD8 File Offset: 0x001CDED8
		[DebuggerNonUserCode]
		public static MessageParser<AddBanRequest> Parser
		{
			get
			{
				return AddBanRequest._parser;
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06007719 RID: 30489 RVA: 0x001CFCF0 File Offset: 0x001CDEF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[46];
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600771A RID: 30490 RVA: 0x001CFD14 File Offset: 0x001CDF14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBanRequest.Descriptor;
			}
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x001CFD2B File Offset: 0x001CDF2B
		[DebuggerNonUserCode]
		public AddBanRequest()
		{
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x001CFD38 File Offset: 0x001CDF38
		[DebuggerNonUserCode]
		public AddBanRequest(AddBanRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x001CFDB0 File Offset: 0x001CDFB0
		[DebuggerNonUserCode]
		public AddBanRequest Clone()
		{
			return new AddBanRequest(this);
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x001CFDC8 File Offset: 0x001CDFC8
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x001CFDE0 File Offset: 0x001CDFE0
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

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x001CFDEC File Offset: 0x001CDFEC
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x001CFE1D File Offset: 0x001CE01D
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
					clubIdDefaultValue = AddBanRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x001CFE38 File Offset: 0x001CE038
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x001CFE55 File Offset: 0x001CE055
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x001CFE68 File Offset: 0x001CE068
		// (set) Token: 0x06007725 RID: 30501 RVA: 0x001CFE80 File Offset: 0x001CE080
		[DebuggerNonUserCode]
		public AddBanOptions Options
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

		// Token: 0x06007726 RID: 30502 RVA: 0x001CFE8C File Offset: 0x001CE08C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBanRequest);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x001CFEAC File Offset: 0x001CE0AC
		[DebuggerNonUserCode]
		public bool Equals(AddBanRequest other)
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

		// Token: 0x06007728 RID: 30504 RVA: 0x001CFF40 File Offset: 0x001CE140
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

		// Token: 0x06007729 RID: 30505 RVA: 0x001CFFCC File Offset: 0x001CE1CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x001CFFE4 File Offset: 0x001CE1E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x001CFFF0 File Offset: 0x001CE1F0
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

		// Token: 0x0600772C RID: 30508 RVA: 0x001D0088 File Offset: 0x001CE288
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

		// Token: 0x0600772D RID: 30509 RVA: 0x001D0118 File Offset: 0x001CE318
		[DebuggerNonUserCode]
		public void MergeFrom(AddBanRequest other)
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
						this.Options = new AddBanOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x001D01E0 File Offset: 0x001CE3E0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x001D01EC File Offset: 0x001CE3EC
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
								this.Options = new AddBanOptions();
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

		// Token: 0x04003626 RID: 13862
		private static readonly MessageParser<AddBanRequest> _parser = new MessageParser<AddBanRequest>(() => new AddBanRequest());

		// Token: 0x04003627 RID: 13863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003628 RID: 13864
		private int _hasBits0;

		// Token: 0x04003629 RID: 13865
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400362A RID: 13866
		private MemberId agentId_;

		// Token: 0x0400362B RID: 13867
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400362C RID: 13868
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400362D RID: 13869
		private ulong clubId_;

		// Token: 0x0400362E RID: 13870
		public const int OptionsFieldNumber = 3;

		// Token: 0x0400362F RID: 13871
		private AddBanOptions options_;
	}
}
