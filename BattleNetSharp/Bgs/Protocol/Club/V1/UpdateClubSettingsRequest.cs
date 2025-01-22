using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A5 RID: 1189
	public sealed class UpdateClubSettingsRequest : IMessage<UpdateClubSettingsRequest>, IMessage, IEquatable<UpdateClubSettingsRequest>, IDeepCloneable<UpdateClubSettingsRequest>, IBufferMessage
	{
		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x060073AA RID: 29610 RVA: 0x001C3CCC File Offset: 0x001C1ECC
		[DebuggerNonUserCode]
		public static MessageParser<UpdateClubSettingsRequest> Parser
		{
			get
			{
				return UpdateClubSettingsRequest._parser;
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x060073AB RID: 29611 RVA: 0x001C3CE4 File Offset: 0x001C1EE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x060073AC RID: 29612 RVA: 0x001C3D08 File Offset: 0x001C1F08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateClubSettingsRequest.Descriptor;
			}
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x001C3D1F File Offset: 0x001C1F1F
		[DebuggerNonUserCode]
		public UpdateClubSettingsRequest()
		{
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x001C3D2C File Offset: 0x001C1F2C
		[DebuggerNonUserCode]
		public UpdateClubSettingsRequest(UpdateClubSettingsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x001C3DA4 File Offset: 0x001C1FA4
		[DebuggerNonUserCode]
		public UpdateClubSettingsRequest Clone()
		{
			return new UpdateClubSettingsRequest(this);
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x060073B0 RID: 29616 RVA: 0x001C3DBC File Offset: 0x001C1FBC
		// (set) Token: 0x060073B1 RID: 29617 RVA: 0x001C3DD4 File Offset: 0x001C1FD4
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

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x060073B2 RID: 29618 RVA: 0x001C3DE0 File Offset: 0x001C1FE0
		// (set) Token: 0x060073B3 RID: 29619 RVA: 0x001C3E11 File Offset: 0x001C2011
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
					clubIdDefaultValue = UpdateClubSettingsRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x060073B4 RID: 29620 RVA: 0x001C3E2C File Offset: 0x001C202C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x001C3E49 File Offset: 0x001C2049
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x060073B6 RID: 29622 RVA: 0x001C3E5C File Offset: 0x001C205C
		// (set) Token: 0x060073B7 RID: 29623 RVA: 0x001C3E74 File Offset: 0x001C2074
		[DebuggerNonUserCode]
		public ClubSettingsOptions Options
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

		// Token: 0x060073B8 RID: 29624 RVA: 0x001C3E80 File Offset: 0x001C2080
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateClubSettingsRequest);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x001C3EA0 File Offset: 0x001C20A0
		[DebuggerNonUserCode]
		public bool Equals(UpdateClubSettingsRequest other)
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

		// Token: 0x060073BA RID: 29626 RVA: 0x001C3F34 File Offset: 0x001C2134
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

		// Token: 0x060073BB RID: 29627 RVA: 0x001C3FC0 File Offset: 0x001C21C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x001C3FD8 File Offset: 0x001C21D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x001C3FE4 File Offset: 0x001C21E4
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

		// Token: 0x060073BE RID: 29630 RVA: 0x001C407C File Offset: 0x001C227C
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

		// Token: 0x060073BF RID: 29631 RVA: 0x001C410C File Offset: 0x001C230C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateClubSettingsRequest other)
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
						this.Options = new ClubSettingsOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x001C41D4 File Offset: 0x001C23D4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x001C41E0 File Offset: 0x001C23E0
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
								this.Options = new ClubSettingsOptions();
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

		// Token: 0x040034DA RID: 13530
		private static readonly MessageParser<UpdateClubSettingsRequest> _parser = new MessageParser<UpdateClubSettingsRequest>(() => new UpdateClubSettingsRequest());

		// Token: 0x040034DB RID: 13531
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034DC RID: 13532
		private int _hasBits0;

		// Token: 0x040034DD RID: 13533
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034DE RID: 13534
		private MemberId agentId_;

		// Token: 0x040034DF RID: 13535
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034E0 RID: 13536
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034E1 RID: 13537
		private ulong clubId_;

		// Token: 0x040034E2 RID: 13538
		public const int OptionsFieldNumber = 3;

		// Token: 0x040034E3 RID: 13539
		private ClubSettingsOptions options_;
	}
}
