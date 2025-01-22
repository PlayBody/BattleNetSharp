using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A4 RID: 1188
	public sealed class UpdateClubStateRequest : IMessage<UpdateClubStateRequest>, IMessage, IEquatable<UpdateClubStateRequest>, IDeepCloneable<UpdateClubStateRequest>, IBufferMessage
	{
		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x001C36D4 File Offset: 0x001C18D4
		[DebuggerNonUserCode]
		public static MessageParser<UpdateClubStateRequest> Parser
		{
			get
			{
				return UpdateClubStateRequest._parser;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06007392 RID: 29586 RVA: 0x001C36EC File Offset: 0x001C18EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x001C3710 File Offset: 0x001C1910
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateClubStateRequest.Descriptor;
			}
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x001C3727 File Offset: 0x001C1927
		[DebuggerNonUserCode]
		public UpdateClubStateRequest()
		{
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x001C3734 File Offset: 0x001C1934
		[DebuggerNonUserCode]
		public UpdateClubStateRequest(UpdateClubStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x001C37AC File Offset: 0x001C19AC
		[DebuggerNonUserCode]
		public UpdateClubStateRequest Clone()
		{
			return new UpdateClubStateRequest(this);
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x001C37C4 File Offset: 0x001C19C4
		// (set) Token: 0x06007398 RID: 29592 RVA: 0x001C37DC File Offset: 0x001C19DC
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

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x06007399 RID: 29593 RVA: 0x001C37E8 File Offset: 0x001C19E8
		// (set) Token: 0x0600739A RID: 29594 RVA: 0x001C3819 File Offset: 0x001C1A19
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
					clubIdDefaultValue = UpdateClubStateRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x001C3834 File Offset: 0x001C1A34
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x001C3851 File Offset: 0x001C1A51
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600739D RID: 29597 RVA: 0x001C3864 File Offset: 0x001C1A64
		// (set) Token: 0x0600739E RID: 29598 RVA: 0x001C387C File Offset: 0x001C1A7C
		[DebuggerNonUserCode]
		public ClubStateOptions Options
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

		// Token: 0x0600739F RID: 29599 RVA: 0x001C3888 File Offset: 0x001C1A88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateClubStateRequest);
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x001C38A8 File Offset: 0x001C1AA8
		[DebuggerNonUserCode]
		public bool Equals(UpdateClubStateRequest other)
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

		// Token: 0x060073A1 RID: 29601 RVA: 0x001C393C File Offset: 0x001C1B3C
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

		// Token: 0x060073A2 RID: 29602 RVA: 0x001C39C8 File Offset: 0x001C1BC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x001C39E0 File Offset: 0x001C1BE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x001C39EC File Offset: 0x001C1BEC
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

		// Token: 0x060073A5 RID: 29605 RVA: 0x001C3A84 File Offset: 0x001C1C84
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

		// Token: 0x060073A6 RID: 29606 RVA: 0x001C3B14 File Offset: 0x001C1D14
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateClubStateRequest other)
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
						this.Options = new ClubStateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x001C3BDC File Offset: 0x001C1DDC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x001C3BE8 File Offset: 0x001C1DE8
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
								this.Options = new ClubStateOptions();
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

		// Token: 0x040034D0 RID: 13520
		private static readonly MessageParser<UpdateClubStateRequest> _parser = new MessageParser<UpdateClubStateRequest>(() => new UpdateClubStateRequest());

		// Token: 0x040034D1 RID: 13521
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034D2 RID: 13522
		private int _hasBits0;

		// Token: 0x040034D3 RID: 13523
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034D4 RID: 13524
		private MemberId agentId_;

		// Token: 0x040034D5 RID: 13525
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034D6 RID: 13526
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034D7 RID: 13527
		private ulong clubId_;

		// Token: 0x040034D8 RID: 13528
		public const int OptionsFieldNumber = 3;

		// Token: 0x040034D9 RID: 13529
		private ClubStateOptions options_;
	}
}
