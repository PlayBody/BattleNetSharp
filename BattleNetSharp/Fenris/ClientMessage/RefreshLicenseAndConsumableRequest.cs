using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000298 RID: 664
	public sealed class RefreshLicenseAndConsumableRequest : IMessage<RefreshLicenseAndConsumableRequest>, IMessage, IEquatable<RefreshLicenseAndConsumableRequest>, IDeepCloneable<RefreshLicenseAndConsumableRequest>, IBufferMessage
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x0010D5A8 File Offset: 0x0010B7A8
		[DebuggerNonUserCode]
		public static MessageParser<RefreshLicenseAndConsumableRequest> Parser
		{
			get
			{
				return RefreshLicenseAndConsumableRequest._parser;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x0010D5C0 File Offset: 0x0010B7C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[136];
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x0010D5E8 File Offset: 0x0010B7E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshLicenseAndConsumableRequest.Descriptor;
			}
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0010D5FF File Offset: 0x0010B7FF
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableRequest()
		{
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x0010D609 File Offset: 0x0010B809
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableRequest(RefreshLicenseAndConsumableRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0010D648 File Offset: 0x0010B848
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableRequest Clone()
		{
			return new RefreshLicenseAndConsumableRequest(this);
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x0010D660 File Offset: 0x0010B860
		// (set) Token: 0x0600465D RID: 18013 RVA: 0x0010D691 File Offset: 0x0010B891
		[DebuggerNonUserCode]
		public uint AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = RefreshLicenseAndConsumableRequest.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x0010D6AC File Offset: 0x0010B8AC
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x0010D6C9 File Offset: 0x0010B8C9
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x0010D6DC File Offset: 0x0010B8DC
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x0010D6FD File Offset: 0x0010B8FD
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? RefreshLicenseAndConsumableRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x0010D714 File Offset: 0x0010B914
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x0010D732 File Offset: 0x0010B932
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x0010D73C File Offset: 0x0010B93C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshLicenseAndConsumableRequest);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x0010D75C File Offset: 0x0010B95C
		[DebuggerNonUserCode]
		public bool Equals(RefreshLicenseAndConsumableRequest other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionKey != other.SessionKey;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x0010D7D0 File Offset: 0x0010B9D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x0010D83C File Offset: 0x0010BA3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x0010D854 File Offset: 0x0010BA54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x0010D860 File Offset: 0x0010BA60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AccountId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x0010D8D0 File Offset: 0x0010BAD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x0010D93C File Offset: 0x0010BB3C
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshLicenseAndConsumableRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x0010D99E File Offset: 0x0010BB9E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0010D9AC File Offset: 0x0010BBAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else
				{
					this.AccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F48 RID: 8008
		private static readonly MessageParser<RefreshLicenseAndConsumableRequest> _parser = new MessageParser<RefreshLicenseAndConsumableRequest>(() => new RefreshLicenseAndConsumableRequest());

		// Token: 0x04001F49 RID: 8009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F4A RID: 8010
		private int _hasBits0;

		// Token: 0x04001F4B RID: 8011
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04001F4C RID: 8012
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x04001F4D RID: 8013
		private uint accountId_;

		// Token: 0x04001F4E RID: 8014
		public const int SessionKeyFieldNumber = 2;

		// Token: 0x04001F4F RID: 8015
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F50 RID: 8016
		private ByteString sessionKey_;
	}
}
