using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C7 RID: 1735
	public sealed class ChannelInvitation : IMessage<ChannelInvitation>, IMessage, IEquatable<ChannelInvitation>, IDeepCloneable<ChannelInvitation>, IBufferMessage
	{
		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x0026F338 File Offset: 0x0026D538
		[DebuggerNonUserCode]
		public static MessageParser<ChannelInvitation> Parser
		{
			get
			{
				return ChannelInvitation._parser;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x0026F350 File Offset: 0x0026D550
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x0026F374 File Offset: 0x0026D574
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelInvitation.Descriptor;
			}
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x0026F38B File Offset: 0x0026D58B
		[DebuggerNonUserCode]
		public ChannelInvitation()
		{
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x0026F398 File Offset: 0x0026D598
		[DebuggerNonUserCode]
		public ChannelInvitation(ChannelInvitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.channelDescription_ = ((other.channelDescription_ != null) ? other.channelDescription_.Clone() : null);
			this.reserved_ = other.reserved_;
			this.rejoin_ = other.rejoin_;
			this.serviceType_ = other.serviceType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x0026F40C File Offset: 0x0026D60C
		[DebuggerNonUserCode]
		public ChannelInvitation Clone()
		{
			return new ChannelInvitation(this);
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A024 RID: 40996 RVA: 0x0026F424 File Offset: 0x0026D624
		// (set) Token: 0x0600A025 RID: 40997 RVA: 0x0026F43C File Offset: 0x0026D63C
		[DebuggerNonUserCode]
		public ChannelDescription ChannelDescription
		{
			get
			{
				return this.channelDescription_;
			}
			set
			{
				this.channelDescription_ = value;
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x0026F448 File Offset: 0x0026D648
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x0026F479 File Offset: 0x0026D679
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
					reservedDefaultValue = ChannelInvitation.ReservedDefaultValue;
				}
				return reservedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reserved_ = value;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A028 RID: 41000 RVA: 0x0026F494 File Offset: 0x0026D694
		[DebuggerNonUserCode]
		public bool HasReserved
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x0026F4B1 File Offset: 0x0026D6B1
		[DebuggerNonUserCode]
		public void ClearReserved()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A02A RID: 41002 RVA: 0x0026F4C4 File Offset: 0x0026D6C4
		// (set) Token: 0x0600A02B RID: 41003 RVA: 0x0026F4F5 File Offset: 0x0026D6F5
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
					rejoinDefaultValue = ChannelInvitation.RejoinDefaultValue;
				}
				return rejoinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.rejoin_ = value;
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A02C RID: 41004 RVA: 0x0026F510 File Offset: 0x0026D710
		[DebuggerNonUserCode]
		public bool HasRejoin
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x0026F52D File Offset: 0x0026D72D
		[DebuggerNonUserCode]
		public void ClearRejoin()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A02E RID: 41006 RVA: 0x0026F540 File Offset: 0x0026D740
		// (set) Token: 0x0600A02F RID: 41007 RVA: 0x0026F571 File Offset: 0x0026D771
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
					serviceTypeDefaultValue = ChannelInvitation.ServiceTypeDefaultValue;
				}
				return serviceTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.serviceType_ = value;
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600A030 RID: 41008 RVA: 0x0026F58C File Offset: 0x0026D78C
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasServiceType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x0026F5A9 File Offset: 0x0026D7A9
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearServiceType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x0026F5BC File Offset: 0x0026D7BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelInvitation);
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x0026F5DC File Offset: 0x0026D7DC
		[DebuggerNonUserCode]
		public bool Equals(ChannelInvitation other)
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
					bool flag4 = !object.Equals(this.ChannelDescription, other.ChannelDescription);
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

		// Token: 0x0600A034 RID: 41012 RVA: 0x0026F68C File Offset: 0x0026D88C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelDescription_ != null;
			if (flag)
			{
				num ^= this.ChannelDescription.GetHashCode();
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

		// Token: 0x0600A035 RID: 41013 RVA: 0x0026F734 File Offset: 0x0026D934
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x0026F74C File Offset: 0x0026D94C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x0026F758 File Offset: 0x0026D958
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelDescription_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelDescription);
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

		// Token: 0x0600A038 RID: 41016 RVA: 0x0026F810 File Offset: 0x0026DA10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelDescription_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelDescription);
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

		// Token: 0x0600A039 RID: 41017 RVA: 0x0026F8A4 File Offset: 0x0026DAA4
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelInvitation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelDescription_ != null;
				if (flag2)
				{
					bool flag3 = this.channelDescription_ == null;
					if (flag3)
					{
						this.ChannelDescription = new ChannelDescription();
					}
					this.ChannelDescription.MergeFrom(other.ChannelDescription);
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

		// Token: 0x0600A03A RID: 41018 RVA: 0x0026F962 File Offset: 0x0026DB62
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x0026F970 File Offset: 0x0026DB70
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
						bool flag = this.channelDescription_ == null;
						if (flag)
						{
							this.ChannelDescription = new ChannelDescription();
						}
						input.ReadMessage(this.ChannelDescription);
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

		// Token: 0x04004830 RID: 18480
		private static readonly MessageParser<ChannelInvitation> _parser = new MessageParser<ChannelInvitation>(() => new ChannelInvitation());

		// Token: 0x04004831 RID: 18481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004832 RID: 18482
		private int _hasBits0;

		// Token: 0x04004833 RID: 18483
		public const int ChannelDescriptionFieldNumber = 1;

		// Token: 0x04004834 RID: 18484
		private ChannelDescription channelDescription_;

		// Token: 0x04004835 RID: 18485
		public const int ReservedFieldNumber = 2;

		// Token: 0x04004836 RID: 18486
		private static readonly bool ReservedDefaultValue = false;

		// Token: 0x04004837 RID: 18487
		private bool reserved_;

		// Token: 0x04004838 RID: 18488
		public const int RejoinFieldNumber = 3;

		// Token: 0x04004839 RID: 18489
		private static readonly bool RejoinDefaultValue = false;

		// Token: 0x0400483A RID: 18490
		private bool rejoin_;

		// Token: 0x0400483B RID: 18491
		public const int ServiceTypeFieldNumber = 4;

		// Token: 0x0400483C RID: 18492
		private static readonly uint ServiceTypeDefaultValue = 0U;

		// Token: 0x0400483D RID: 18493
		private uint serviceType_;

		// Token: 0x020011CC RID: 4556
		[DebuggerNonUserCode]
		public static class Extensions
		{
			// Token: 0x040098FC RID: 39164
			public static readonly Extension<Invitation, ChannelInvitation> ChannelInvitation = new Extension<Invitation, ChannelInvitation>(105, FieldCodec.ForMessage<ChannelInvitation>(842U, Bgs.Protocol.Channel.V1.ChannelInvitation.Parser));
		}
	}
}
