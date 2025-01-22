using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000280 RID: 640
	public sealed class ClanLeftNotification : IMessage<ClanLeftNotification>, IMessage, IEquatable<ClanLeftNotification>, IDeepCloneable<ClanLeftNotification>, IBufferMessage
	{
		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x00107770 File Offset: 0x00105970
		[DebuggerNonUserCode]
		public static MessageParser<ClanLeftNotification> Parser
		{
			get
			{
				return ClanLeftNotification._parser;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x00107788 File Offset: 0x00105988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[112];
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x001077AC File Offset: 0x001059AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanLeftNotification.Descriptor;
			}
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x001077C3 File Offset: 0x001059C3
		[DebuggerNonUserCode]
		public ClanLeftNotification()
		{
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x001077CD File Offset: 0x001059CD
		[DebuggerNonUserCode]
		public ClanLeftNotification(ClanLeftNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.removalReason_ = other.removalReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x0010780C File Offset: 0x00105A0C
		[DebuggerNonUserCode]
		public ClanLeftNotification Clone()
		{
			return new ClanLeftNotification(this);
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x00107824 File Offset: 0x00105A24
		// (set) Token: 0x0600444D RID: 17485 RVA: 0x00107845 File Offset: 0x00105A45
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanLeftNotification.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x0010785C File Offset: 0x00105A5C
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00107877 File Offset: 0x00105A77
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x00107884 File Offset: 0x00105A84
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x001078B5 File Offset: 0x00105AB5
		[DebuggerNonUserCode]
		public uint RemovalReason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint removalReasonDefaultValue;
				if (flag)
				{
					removalReasonDefaultValue = this.removalReason_;
				}
				else
				{
					removalReasonDefaultValue = ClanLeftNotification.RemovalReasonDefaultValue;
				}
				return removalReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.removalReason_ = value;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x001078D0 File Offset: 0x00105AD0
		[DebuggerNonUserCode]
		public bool HasRemovalReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x001078ED File Offset: 0x00105AED
		[DebuggerNonUserCode]
		public void ClearRemovalReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00107900 File Offset: 0x00105B00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanLeftNotification);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00107920 File Offset: 0x00105B20
		[DebuggerNonUserCode]
		public bool Equals(ClanLeftNotification other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RemovalReason != other.RemovalReason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00107994 File Offset: 0x00105B94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num ^= this.RemovalReason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00107A00 File Offset: 0x00105C00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00107A18 File Offset: 0x00105C18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00107A24 File Offset: 0x00105C24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RemovalReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00107A94 File Offset: 0x00105C94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemovalReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00107B00 File Offset: 0x00105D00
		[DebuggerNonUserCode]
		public void MergeFrom(ClanLeftNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasRemovalReason = other.HasRemovalReason;
				if (hasRemovalReason)
				{
					this.RemovalReason = other.RemovalReason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00107B62 File Offset: 0x00105D62
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00107B70 File Offset: 0x00105D70
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RemovalReason = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001EA6 RID: 7846
		private static readonly MessageParser<ClanLeftNotification> _parser = new MessageParser<ClanLeftNotification>(() => new ClanLeftNotification());

		// Token: 0x04001EA7 RID: 7847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EA8 RID: 7848
		private int _hasBits0;

		// Token: 0x04001EA9 RID: 7849
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001EAA RID: 7850
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001EAB RID: 7851
		private string clanId_;

		// Token: 0x04001EAC RID: 7852
		public const int RemovalReasonFieldNumber = 2;

		// Token: 0x04001EAD RID: 7853
		private static readonly uint RemovalReasonDefaultValue = 0U;

		// Token: 0x04001EAE RID: 7854
		private uint removalReason_;
	}
}
