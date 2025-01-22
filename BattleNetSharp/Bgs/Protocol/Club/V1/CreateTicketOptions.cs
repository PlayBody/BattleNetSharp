using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000459 RID: 1113
	public sealed class CreateTicketOptions : IMessage<CreateTicketOptions>, IMessage, IEquatable<CreateTicketOptions>, IDeepCloneable<CreateTicketOptions>, IBufferMessage
	{
		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x001A76AC File Offset: 0x001A58AC
		[DebuggerNonUserCode]
		public static MessageParser<CreateTicketOptions> Parser
		{
			get
			{
				return CreateTicketOptions._parser;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x001A76C4 File Offset: 0x001A58C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x001A76E8 File Offset: 0x001A58E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateTicketOptions.Descriptor;
			}
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x001A76FF File Offset: 0x001A58FF
		[DebuggerNonUserCode]
		public CreateTicketOptions()
		{
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x001A7714 File Offset: 0x001A5914
		[DebuggerNonUserCode]
		public CreateTicketOptions(CreateTicketOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.allowedRedeemCount_ = other.allowedRedeemCount_;
			this.expirationTime_ = other.expirationTime_;
			this.joinClubSource_ = other.joinClubSource_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x001A7798 File Offset: 0x001A5998
		[DebuggerNonUserCode]
		public CreateTicketOptions Clone()
		{
			return new CreateTicketOptions(this);
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06006CDF RID: 27871 RVA: 0x001A77B0 File Offset: 0x001A59B0
		// (set) Token: 0x06006CE0 RID: 27872 RVA: 0x001A77C8 File Offset: 0x001A59C8
		[DebuggerNonUserCode]
		public ClubSlot Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x001A77D4 File Offset: 0x001A59D4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x001A77EC File Offset: 0x001A59EC
		// (set) Token: 0x06006CE3 RID: 27875 RVA: 0x001A781D File Offset: 0x001A5A1D
		[DebuggerNonUserCode]
		public uint AllowedRedeemCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint allowedRedeemCountDefaultValue;
				if (flag)
				{
					allowedRedeemCountDefaultValue = this.allowedRedeemCount_;
				}
				else
				{
					allowedRedeemCountDefaultValue = CreateTicketOptions.AllowedRedeemCountDefaultValue;
				}
				return allowedRedeemCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.allowedRedeemCount_ = value;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06006CE4 RID: 27876 RVA: 0x001A7838 File Offset: 0x001A5A38
		[DebuggerNonUserCode]
		public bool HasAllowedRedeemCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x001A7855 File Offset: 0x001A5A55
		[DebuggerNonUserCode]
		public void ClearAllowedRedeemCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x001A7868 File Offset: 0x001A5A68
		// (set) Token: 0x06006CE7 RID: 27879 RVA: 0x001A7899 File Offset: 0x001A5A99
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = CreateTicketOptions.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x001A78B4 File Offset: 0x001A5AB4
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x001A78D1 File Offset: 0x001A5AD1
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x001A78E4 File Offset: 0x001A5AE4
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x001A7915 File Offset: 0x001A5B15
		[DebuggerNonUserCode]
		public uint JoinClubSource
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint joinClubSourceDefaultValue;
				if (flag)
				{
					joinClubSourceDefaultValue = this.joinClubSource_;
				}
				else
				{
					joinClubSourceDefaultValue = CreateTicketOptions.JoinClubSourceDefaultValue;
				}
				return joinClubSourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.joinClubSource_ = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x001A7930 File Offset: 0x001A5B30
		[DebuggerNonUserCode]
		public bool HasJoinClubSource
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x001A794D File Offset: 0x001A5B4D
		[DebuggerNonUserCode]
		public void ClearJoinClubSource()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x001A7960 File Offset: 0x001A5B60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateTicketOptions);
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x001A7980 File Offset: 0x001A5B80
		[DebuggerNonUserCode]
		public bool Equals(CreateTicketOptions other)
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
					bool flag4 = !object.Equals(this.Slot, other.Slot);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AllowedRedeemCount != other.AllowedRedeemCount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ExpirationTime != other.ExpirationTime;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.JoinClubSource != other.JoinClubSource;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x001A7A54 File Offset: 0x001A5C54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.slot_ != null;
			if (flag)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				num ^= this.AllowedRedeemCount.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num ^= this.JoinClubSource.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x001A7B0C File Offset: 0x001A5D0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x001A7B24 File Offset: 0x001A5D24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x001A7B30 File Offset: 0x001A5D30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.slot_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Slot);
			}
			this.attribute_.WriteTo(ref output, CreateTicketOptions._repeated_attribute_codec);
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AllowedRedeemCount);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.JoinClubSource);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x001A7BFC File Offset: 0x001A5DFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.slot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.attribute_.CalculateSize(CreateTicketOptions._repeated_attribute_codec);
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AllowedRedeemCount);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JoinClubSource);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x001A7CBC File Offset: 0x001A5EBC
		[DebuggerNonUserCode]
		public void MergeFrom(CreateTicketOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.slot_ != null;
				if (flag2)
				{
					bool flag3 = this.slot_ == null;
					if (flag3)
					{
						this.Slot = new ClubSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this.attribute_.Add(other.attribute_);
				bool hasAllowedRedeemCount = other.HasAllowedRedeemCount;
				if (hasAllowedRedeemCount)
				{
					this.AllowedRedeemCount = other.AllowedRedeemCount;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				bool hasJoinClubSource = other.HasJoinClubSource;
				if (hasJoinClubSource)
				{
					this.JoinClubSource = other.JoinClubSource;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x001A7D8C File Offset: 0x001A5F8C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x001A7D98 File Offset: 0x001A5F98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.attribute_.AddEntriesFrom(ref input, CreateTicketOptions._repeated_attribute_codec);
					}
					else
					{
						bool flag = this.slot_ == null;
						if (flag)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.JoinClubSource = input.ReadUInt32();
					}
					else
					{
						this.ExpirationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.AllowedRedeemCount = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003207 RID: 12807
		private static readonly MessageParser<CreateTicketOptions> _parser = new MessageParser<CreateTicketOptions>(() => new CreateTicketOptions());

		// Token: 0x04003208 RID: 12808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003209 RID: 12809
		private int _hasBits0;

		// Token: 0x0400320A RID: 12810
		public const int SlotFieldNumber = 1;

		// Token: 0x0400320B RID: 12811
		private ClubSlot slot_;

		// Token: 0x0400320C RID: 12812
		public const int AttributeFieldNumber = 2;

		// Token: 0x0400320D RID: 12813
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400320E RID: 12814
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400320F RID: 12815
		public const int AllowedRedeemCountFieldNumber = 3;

		// Token: 0x04003210 RID: 12816
		private static readonly uint AllowedRedeemCountDefaultValue = 0U;

		// Token: 0x04003211 RID: 12817
		private uint allowedRedeemCount_;

		// Token: 0x04003212 RID: 12818
		public const int ExpirationTimeFieldNumber = 4;

		// Token: 0x04003213 RID: 12819
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x04003214 RID: 12820
		private ulong expirationTime_;

		// Token: 0x04003215 RID: 12821
		public const int JoinClubSourceFieldNumber = 5;

		// Token: 0x04003216 RID: 12822
		private static readonly uint JoinClubSourceDefaultValue = 0U;

		// Token: 0x04003217 RID: 12823
		private uint joinClubSource_;
	}
}
