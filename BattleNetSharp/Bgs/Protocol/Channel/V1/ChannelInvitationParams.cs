using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C8 RID: 1736
	public sealed class ChannelInvitationParams : IMessage<ChannelInvitationParams>, IMessage, IEquatable<ChannelInvitationParams>, IDeepCloneable<ChannelInvitationParams>, IBufferMessage
	{
		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600A03D RID: 41021 RVA: 0x0026FA5C File Offset: 0x0026DC5C
		[DebuggerNonUserCode]
		public static MessageParser<ChannelInvitationParams> Parser
		{
			get
			{
				return ChannelInvitationParams._parser;
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x0026FA74 File Offset: 0x0026DC74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x0026FA98 File Offset: 0x0026DC98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelInvitationParams.Descriptor;
			}
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x0026FAAF File Offset: 0x0026DCAF
		[DebuggerNonUserCode]
		public ChannelInvitationParams()
		{
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x0026FABC File Offset: 0x0026DCBC
		[DebuggerNonUserCode]
		public ChannelInvitationParams(ChannelInvitationParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.reserved_ = other.reserved_;
			this.rejoin_ = other.rejoin_;
			this.serviceType_ = other.serviceType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x0026FB30 File Offset: 0x0026DD30
		[DebuggerNonUserCode]
		public ChannelInvitationParams Clone()
		{
			return new ChannelInvitationParams(this);
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600A043 RID: 41027 RVA: 0x0026FB48 File Offset: 0x0026DD48
		// (set) Token: 0x0600A044 RID: 41028 RVA: 0x0026FB60 File Offset: 0x0026DD60
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600A045 RID: 41029 RVA: 0x0026FB6C File Offset: 0x0026DD6C
		// (set) Token: 0x0600A046 RID: 41030 RVA: 0x0026FB9D File Offset: 0x0026DD9D
		[DebuggerNonUserCode]
		public bool Reserved
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool reservedDefaultValue;
				if (flag)
				{
					reservedDefaultValue = this.reserved_;
				}
				else
				{
					reservedDefaultValue = ChannelInvitationParams.ReservedDefaultValue;
				}
				return reservedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reserved_ = value;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600A047 RID: 41031 RVA: 0x0026FBB8 File Offset: 0x0026DDB8
		[DebuggerNonUserCode]
		public bool HasReserved
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x0026FBD5 File Offset: 0x0026DDD5
		[DebuggerNonUserCode]
		public void ClearReserved()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600A049 RID: 41033 RVA: 0x0026FBE8 File Offset: 0x0026DDE8
		// (set) Token: 0x0600A04A RID: 41034 RVA: 0x0026FC19 File Offset: 0x0026DE19
		[DebuggerNonUserCode]
		public bool Rejoin
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool rejoinDefaultValue;
				if (flag)
				{
					rejoinDefaultValue = this.rejoin_;
				}
				else
				{
					rejoinDefaultValue = ChannelInvitationParams.RejoinDefaultValue;
				}
				return rejoinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.rejoin_ = value;
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600A04B RID: 41035 RVA: 0x0026FC34 File Offset: 0x0026DE34
		[DebuggerNonUserCode]
		public bool HasRejoin
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x0026FC51 File Offset: 0x0026DE51
		[DebuggerNonUserCode]
		public void ClearRejoin()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600A04D RID: 41037 RVA: 0x0026FC64 File Offset: 0x0026DE64
		// (set) Token: 0x0600A04E RID: 41038 RVA: 0x0026FC95 File Offset: 0x0026DE95
		[Obsolete]
		[DebuggerNonUserCode]
		public uint ServiceType
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint serviceTypeDefaultValue;
				if (flag)
				{
					serviceTypeDefaultValue = this.serviceType_;
				}
				else
				{
					serviceTypeDefaultValue = ChannelInvitationParams.ServiceTypeDefaultValue;
				}
				return serviceTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.serviceType_ = value;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600A04F RID: 41039 RVA: 0x0026FCB0 File Offset: 0x0026DEB0
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasServiceType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x0026FCCD File Offset: 0x0026DECD
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearServiceType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x0026FCE0 File Offset: 0x0026DEE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelInvitationParams);
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x0026FD00 File Offset: 0x0026DF00
		[DebuggerNonUserCode]
		public bool Equals(ChannelInvitationParams other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reserved != other.Reserved;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Rejoin != other.Rejoin;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ServiceType != other.ServiceType;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A053 RID: 41043 RVA: 0x0026FDB0 File Offset: 0x0026DFB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				num ^= this.Reserved.GetHashCode();
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				num ^= this.Rejoin.GetHashCode();
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				num ^= this.ServiceType.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A054 RID: 41044 RVA: 0x0026FE58 File Offset: 0x0026E058
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x0026FE70 File Offset: 0x0026E070
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x0026FE7C File Offset: 0x0026E07C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Reserved);
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rejoin);
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ServiceType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x0026FF34 File Offset: 0x0026E134
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasReserved = this.HasReserved;
			if (hasReserved)
			{
				num += 2;
			}
			bool hasRejoin = this.HasRejoin;
			if (hasRejoin)
			{
				num += 2;
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x0026FFC8 File Offset: 0x0026E1C8
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelInvitationParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasReserved = other.HasReserved;
				if (hasReserved)
				{
					this.Reserved = other.Reserved;
				}
				bool hasRejoin = other.HasRejoin;
				if (hasRejoin)
				{
					this.Rejoin = other.Rejoin;
				}
				bool hasServiceType = other.HasServiceType;
				if (hasServiceType)
				{
					this.ServiceType = other.ServiceType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x00270086 File Offset: 0x0026E286
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x00270094 File Offset: 0x0026E294
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.Reserved = input.ReadBool();
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.ServiceType = input.ReadUInt32();
				}
				else
				{
					this.Rejoin = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400483E RID: 18494
		private static readonly MessageParser<ChannelInvitationParams> _parser = new MessageParser<ChannelInvitationParams>(() => new ChannelInvitationParams());

		// Token: 0x0400483F RID: 18495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004840 RID: 18496
		private int _hasBits0;

		// Token: 0x04004841 RID: 18497
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x04004842 RID: 18498
		private EntityId channelId_;

		// Token: 0x04004843 RID: 18499
		public const int ReservedFieldNumber = 2;

		// Token: 0x04004844 RID: 18500
		private static readonly bool ReservedDefaultValue = false;

		// Token: 0x04004845 RID: 18501
		private bool reserved_;

		// Token: 0x04004846 RID: 18502
		public const int RejoinFieldNumber = 3;

		// Token: 0x04004847 RID: 18503
		private static readonly bool RejoinDefaultValue = false;

		// Token: 0x04004848 RID: 18504
		private bool rejoin_;

		// Token: 0x04004849 RID: 18505
		public const int ServiceTypeFieldNumber = 4;

		// Token: 0x0400484A RID: 18506
		private static readonly uint ServiceTypeDefaultValue = 0U;

		// Token: 0x0400484B RID: 18507
		private uint serviceType_;

		// Token: 0x020011CE RID: 4558
		[DebuggerNonUserCode]
		public static class Extensions
		{
			// Token: 0x040098FE RID: 39166
			public static readonly Extension<InvitationParams, ChannelInvitationParams> ChannelParams = new Extension<InvitationParams, ChannelInvitationParams>(105, FieldCodec.ForMessage<ChannelInvitationParams>(842U, ChannelInvitationParams.Parser));
		}
	}
}
