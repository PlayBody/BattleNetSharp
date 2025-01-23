using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045A RID: 1114
	public sealed class ClubTicket : IMessage<ClubTicket>, IMessage, IEquatable<ClubTicket>, IDeepCloneable<ClubTicket>, IBufferMessage
	{
		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x001A7EB4 File Offset: 0x001A60B4
		[DebuggerNonUserCode]
		public static MessageParser<ClubTicket> Parser
		{
			get
			{
				return ClubTicket._parser;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x001A7ECC File Offset: 0x001A60CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x001A7EF0 File Offset: 0x001A60F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubTicket.Descriptor;
			}
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x001A7F07 File Offset: 0x001A6107
		[DebuggerNonUserCode]
		public ClubTicket()
		{
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x001A7F1C File Offset: 0x001A611C
		[DebuggerNonUserCode]
		public ClubTicket(ClubTicket other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.creator_ = ((other.creator_ != null) ? other.creator_.Clone() : null);
			this.club_ = ((other.club_ != null) ? other.club_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.currentRedeemCount_ = other.currentRedeemCount_;
			this.allowedRedeemCount_ = other.allowedRedeemCount_;
			this.creationTime_ = other.creationTime_;
			this.expirationTime_ = other.expirationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x001A7FF0 File Offset: 0x001A61F0
		[DebuggerNonUserCode]
		public ClubTicket Clone()
		{
			return new ClubTicket(this);
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x001A8008 File Offset: 0x001A6208
		// (set) Token: 0x06006D00 RID: 27904 RVA: 0x001A8029 File Offset: 0x001A6229
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? ClubTicket.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x001A8040 File Offset: 0x001A6240
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x001A805B File Offset: 0x001A625B
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x001A8068 File Offset: 0x001A6268
		// (set) Token: 0x06006D04 RID: 27908 RVA: 0x001A8080 File Offset: 0x001A6280
		[DebuggerNonUserCode]
		public MemberDescription Creator
		{
			get
			{
				return this.creator_;
			}
			set
			{
				this.creator_ = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x001A808C File Offset: 0x001A628C
		// (set) Token: 0x06006D06 RID: 27910 RVA: 0x001A80A4 File Offset: 0x001A62A4
		[DebuggerNonUserCode]
		public ClubDescription Club
		{
			get
			{
				return this.club_;
			}
			set
			{
				this.club_ = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06006D07 RID: 27911 RVA: 0x001A80B0 File Offset: 0x001A62B0
		// (set) Token: 0x06006D08 RID: 27912 RVA: 0x001A80C8 File Offset: 0x001A62C8
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

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x001A80D4 File Offset: 0x001A62D4
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x001A80EC File Offset: 0x001A62EC
		// (set) Token: 0x06006D0B RID: 27915 RVA: 0x001A811D File Offset: 0x001A631D
		[DebuggerNonUserCode]
		public uint CurrentRedeemCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint currentRedeemCountDefaultValue;
				if (flag)
				{
					currentRedeemCountDefaultValue = this.currentRedeemCount_;
				}
				else
				{
					currentRedeemCountDefaultValue = ClubTicket.CurrentRedeemCountDefaultValue;
				}
				return currentRedeemCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.currentRedeemCount_ = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06006D0C RID: 27916 RVA: 0x001A8138 File Offset: 0x001A6338
		[DebuggerNonUserCode]
		public bool HasCurrentRedeemCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x001A8155 File Offset: 0x001A6355
		[DebuggerNonUserCode]
		public void ClearCurrentRedeemCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06006D0E RID: 27918 RVA: 0x001A8168 File Offset: 0x001A6368
		// (set) Token: 0x06006D0F RID: 27919 RVA: 0x001A8199 File Offset: 0x001A6399
		[DebuggerNonUserCode]
		public uint AllowedRedeemCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint allowedRedeemCountDefaultValue;
				if (flag)
				{
					allowedRedeemCountDefaultValue = this.allowedRedeemCount_;
				}
				else
				{
					allowedRedeemCountDefaultValue = ClubTicket.AllowedRedeemCountDefaultValue;
				}
				return allowedRedeemCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.allowedRedeemCount_ = value;
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06006D10 RID: 27920 RVA: 0x001A81B4 File Offset: 0x001A63B4
		[DebuggerNonUserCode]
		public bool HasAllowedRedeemCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x001A81D1 File Offset: 0x001A63D1
		[DebuggerNonUserCode]
		public void ClearAllowedRedeemCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06006D12 RID: 27922 RVA: 0x001A81E4 File Offset: 0x001A63E4
		// (set) Token: 0x06006D13 RID: 27923 RVA: 0x001A8215 File Offset: 0x001A6415
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ClubTicket.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x001A8230 File Offset: 0x001A6430
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x001A824D File Offset: 0x001A644D
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06006D16 RID: 27926 RVA: 0x001A8260 File Offset: 0x001A6460
		// (set) Token: 0x06006D17 RID: 27927 RVA: 0x001A8291 File Offset: 0x001A6491
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = ClubTicket.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x06006D18 RID: 27928 RVA: 0x001A82AC File Offset: 0x001A64AC
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x001A82C9 File Offset: 0x001A64C9
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x001A82DC File Offset: 0x001A64DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubTicket);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x001A82FC File Offset: 0x001A64FC
		[DebuggerNonUserCode]
		public bool Equals(ClubTicket other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Creator, other.Creator);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Club, other.Club);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Slot, other.Slot);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.attribute_.Equals(other.attribute_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CurrentRedeemCount != other.CurrentRedeemCount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.AllowedRedeemCount != other.AllowedRedeemCount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CreationTime != other.CreationTime;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ExpirationTime != other.ExpirationTime;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x001A844C File Offset: 0x001A664C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				num ^= this.Creator.GetHashCode();
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num ^= this.Club.GetHashCode();
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCurrentRedeemCount = this.HasCurrentRedeemCount;
			if (hasCurrentRedeemCount)
			{
				num ^= this.CurrentRedeemCount.GetHashCode();
			}
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				num ^= this.AllowedRedeemCount.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x001A8574 File Offset: 0x001A6774
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x001A858C File Offset: 0x001A678C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x001A8598 File Offset: 0x001A6798
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Creator);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Club);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Slot);
			}
			this.attribute_.WriteTo(ref output, ClubTicket._repeated_attribute_codec);
			bool hasCurrentRedeemCount = this.HasCurrentRedeemCount;
			if (hasCurrentRedeemCount)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurrentRedeemCount);
			}
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AllowedRedeemCount);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x001A86F8 File Offset: 0x001A68F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Creator);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Club);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.attribute_.CalculateSize(ClubTicket._repeated_attribute_codec);
			bool hasCurrentRedeemCount = this.HasCurrentRedeemCount;
			if (hasCurrentRedeemCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentRedeemCount);
			}
			bool hasAllowedRedeemCount = this.HasAllowedRedeemCount;
			if (hasAllowedRedeemCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AllowedRedeemCount);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x001A8834 File Offset: 0x001A6A34
		[DebuggerNonUserCode]
		public void MergeFrom(ClubTicket other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.creator_ != null;
				if (flag2)
				{
					bool flag3 = this.creator_ == null;
					if (flag3)
					{
						this.Creator = new MemberDescription();
					}
					this.Creator.MergeFrom(other.Creator);
				}
				bool flag4 = other.club_ != null;
				if (flag4)
				{
					bool flag5 = this.club_ == null;
					if (flag5)
					{
						this.Club = new ClubDescription();
					}
					this.Club.MergeFrom(other.Club);
				}
				bool flag6 = other.slot_ != null;
				if (flag6)
				{
					bool flag7 = this.slot_ == null;
					if (flag7)
					{
						this.Slot = new ClubSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this.attribute_.Add(other.attribute_);
				bool hasCurrentRedeemCount = other.HasCurrentRedeemCount;
				if (hasCurrentRedeemCount)
				{
					this.CurrentRedeemCount = other.CurrentRedeemCount;
				}
				bool hasAllowedRedeemCount = other.HasAllowedRedeemCount;
				if (hasAllowedRedeemCount)
				{
					this.AllowedRedeemCount = other.AllowedRedeemCount;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x001A89BA File Offset: 0x001A6BBA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x001A89C8 File Offset: 0x001A6BC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_006E;
							}
							bool flag = this.creator_ == null;
							if (flag)
							{
								this.Creator = new MemberDescription();
							}
							input.ReadMessage(this.Creator);
						}
						else
						{
							this.Id = input.ReadString();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_006E;
						}
						bool flag2 = this.slot_ == null;
						if (flag2)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
					else
					{
						bool flag3 = this.club_ == null;
						if (flag3)
						{
							this.Club = new ClubDescription();
						}
						input.ReadMessage(this.Club);
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006E;
						}
						this.CurrentRedeemCount = input.ReadUInt32();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, ClubTicket._repeated_attribute_codec);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							goto IL_006E;
						}
						this.ExpirationTime = input.ReadUInt64();
					}
					else
					{
						this.CreationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.AllowedRedeemCount = input.ReadUInt32();
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003218 RID: 12824
		private static readonly MessageParser<ClubTicket> _parser = new MessageParser<ClubTicket>(() => new ClubTicket());

		// Token: 0x04003219 RID: 12825
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400321A RID: 12826
		private int _hasBits0;

		// Token: 0x0400321B RID: 12827
		public const int IdFieldNumber = 1;

		// Token: 0x0400321C RID: 12828
		private static readonly string IdDefaultValue = "";

		// Token: 0x0400321D RID: 12829
		private string id_;

		// Token: 0x0400321E RID: 12830
		public const int CreatorFieldNumber = 2;

		// Token: 0x0400321F RID: 12831
		private MemberDescription creator_;

		// Token: 0x04003220 RID: 12832
		public const int ClubFieldNumber = 3;

		// Token: 0x04003221 RID: 12833
		private ClubDescription club_;

		// Token: 0x04003222 RID: 12834
		public const int SlotFieldNumber = 4;

		// Token: 0x04003223 RID: 12835
		private ClubSlot slot_;

		// Token: 0x04003224 RID: 12836
		public const int AttributeFieldNumber = 5;

		// Token: 0x04003225 RID: 12837
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003226 RID: 12838
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003227 RID: 12839
		public const int CurrentRedeemCountFieldNumber = 6;

		// Token: 0x04003228 RID: 12840
		private static readonly uint CurrentRedeemCountDefaultValue = 0U;

		// Token: 0x04003229 RID: 12841
		private uint currentRedeemCount_;

		// Token: 0x0400322A RID: 12842
		public const int AllowedRedeemCountFieldNumber = 7;

		// Token: 0x0400322B RID: 12843
		private static readonly uint AllowedRedeemCountDefaultValue = 0U;

		// Token: 0x0400322C RID: 12844
		private uint allowedRedeemCount_;

		// Token: 0x0400322D RID: 12845
		public const int CreationTimeFieldNumber = 8;

		// Token: 0x0400322E RID: 12846
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x0400322F RID: 12847
		private ulong creationTime_;

		// Token: 0x04003230 RID: 12848
		public const int ExpirationTimeFieldNumber = 9;

		// Token: 0x04003231 RID: 12849
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x04003232 RID: 12850
		private ulong expirationTime_;
	}
}
