using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022C RID: 556
	public sealed class AddLocalPlayerToUserProxyRequest : IMessage<AddLocalPlayerToUserProxyRequest>, IMessage, IEquatable<AddLocalPlayerToUserProxyRequest>, IDeepCloneable<AddLocalPlayerToUserProxyRequest>, IBufferMessage
	{
		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x000EF5CC File Offset: 0x000ED7CC
		[DebuggerNonUserCode]
		public static MessageParser<AddLocalPlayerToUserProxyRequest> Parser
		{
			get
			{
				return AddLocalPlayerToUserProxyRequest._parser;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x000EF5E4 File Offset: 0x000ED7E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x000EF608 File Offset: 0x000ED808
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddLocalPlayerToUserProxyRequest.Descriptor;
			}
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000EF61F File Offset: 0x000ED81F
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyRequest()
		{
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x000EF634 File Offset: 0x000ED834
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyRequest(AddLocalPlayerToUserProxyRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sponsorGameAccountId_ = other.sponsorGameAccountId_;
			this.platformAccount_ = ((other.platformAccount_ != null) ? other.platformAccount_.Clone() : null);
			this.authCode_ = other.authCode_;
			this.sessionKey_ = other.sessionKey_;
			this.contentLicenseNames_ = other.contentLicenseNames_.Clone();
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this.connectedRegionId_ = other.connectedRegionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x000EF6E0 File Offset: 0x000ED8E0
		[DebuggerNonUserCode]
		public AddLocalPlayerToUserProxyRequest Clone()
		{
			return new AddLocalPlayerToUserProxyRequest(this);
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x000EF6F8 File Offset: 0x000ED8F8
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x000EF729 File Offset: 0x000ED929
		[DebuggerNonUserCode]
		public uint SponsorGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint sponsorGameAccountIdDefaultValue;
				if (flag)
				{
					sponsorGameAccountIdDefaultValue = this.sponsorGameAccountId_;
				}
				else
				{
					sponsorGameAccountIdDefaultValue = AddLocalPlayerToUserProxyRequest.SponsorGameAccountIdDefaultValue;
				}
				return sponsorGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sponsorGameAccountId_ = value;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x000EF744 File Offset: 0x000ED944
		[DebuggerNonUserCode]
		public bool HasSponsorGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x000EF761 File Offset: 0x000ED961
		[DebuggerNonUserCode]
		public void ClearSponsorGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x000EF774 File Offset: 0x000ED974
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x000EF78C File Offset: 0x000ED98C
		[DebuggerNonUserCode]
		public PlatformAccount PlatformAccount
		{
			get
			{
				return this.platformAccount_;
			}
			set
			{
				this.platformAccount_ = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x000EF798 File Offset: 0x000ED998
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x000EF7B9 File Offset: 0x000ED9B9
		[DebuggerNonUserCode]
		public string AuthCode
		{
			get
			{
				return this.authCode_ ?? AddLocalPlayerToUserProxyRequest.AuthCodeDefaultValue;
			}
			set
			{
				this.authCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x000EF7D0 File Offset: 0x000ED9D0
		[DebuggerNonUserCode]
		public bool HasAuthCode
		{
			get
			{
				return this.authCode_ != null;
			}
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x000EF7EB File Offset: 0x000ED9EB
		[DebuggerNonUserCode]
		public void ClearAuthCode()
		{
			this.authCode_ = null;
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x000EF7F8 File Offset: 0x000ED9F8
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x000EF819 File Offset: 0x000EDA19
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AddLocalPlayerToUserProxyRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x000EF830 File Offset: 0x000EDA30
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x000EF84E File Offset: 0x000EDA4E
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x000EF858 File Offset: 0x000EDA58
		[DebuggerNonUserCode]
		public RepeatedField<string> ContentLicenseNames
		{
			get
			{
				return this.contentLicenseNames_;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x000EF870 File Offset: 0x000EDA70
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x000EF888 File Offset: 0x000EDA88
		[DebuggerNonUserCode]
		public Online.Trace Trace
		{
			get
			{
				return this.trace_;
			}
			set
			{
				this.trace_ = value;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x000EF894 File Offset: 0x000EDA94
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x000EF8C5 File Offset: 0x000EDAC5
		[DebuggerNonUserCode]
		public uint ConnectedRegionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint connectedRegionIdDefaultValue;
				if (flag)
				{
					connectedRegionIdDefaultValue = this.connectedRegionId_;
				}
				else
				{
					connectedRegionIdDefaultValue = AddLocalPlayerToUserProxyRequest.ConnectedRegionIdDefaultValue;
				}
				return connectedRegionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.connectedRegionId_ = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x000EF8E0 File Offset: 0x000EDAE0
		[DebuggerNonUserCode]
		public bool HasConnectedRegionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x000EF8FD File Offset: 0x000EDAFD
		[DebuggerNonUserCode]
		public void ClearConnectedRegionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x000EF910 File Offset: 0x000EDB10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddLocalPlayerToUserProxyRequest);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x000EF930 File Offset: 0x000EDB30
		[DebuggerNonUserCode]
		public bool Equals(AddLocalPlayerToUserProxyRequest other)
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
					bool flag4 = this.SponsorGameAccountId != other.SponsorGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.PlatformAccount, other.PlatformAccount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AuthCode != other.AuthCode;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SessionKey != other.SessionKey;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.contentLicenseNames_.Equals(other.contentLicenseNames_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Trace, other.Trace);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ConnectedRegionId != other.ConnectedRegionId;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06003C76 RID: 15478 RVA: 0x000EFA40 File Offset: 0x000EDC40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSponsorGameAccountId = this.HasSponsorGameAccountId;
			if (hasSponsorGameAccountId)
			{
				num ^= this.SponsorGameAccountId.GetHashCode();
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num ^= this.PlatformAccount.GetHashCode();
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				num ^= this.AuthCode.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			num ^= this.contentLicenseNames_.GetHashCode();
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				num ^= this.Trace.GetHashCode();
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				num ^= this.ConnectedRegionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x000EFB28 File Offset: 0x000EDD28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x000EFB40 File Offset: 0x000EDD40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000EFB4C File Offset: 0x000EDD4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSponsorGameAccountId = this.HasSponsorGameAccountId;
			if (hasSponsorGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SponsorGameAccountId);
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PlatformAccount);
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				output.WriteRawTag(26);
				output.WriteString(this.AuthCode);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.SessionKey);
			}
			this.contentLicenseNames_.WriteTo(ref output, AddLocalPlayerToUserProxyRequest._repeated_contentLicenseNames_codec);
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Trace);
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ConnectedRegionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x000EFC60 File Offset: 0x000EDE60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSponsorGameAccountId = this.HasSponsorGameAccountId;
			if (hasSponsorGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SponsorGameAccountId);
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlatformAccount);
			}
			bool hasAuthCode = this.HasAuthCode;
			if (hasAuthCode)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AuthCode);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			num += this.contentLicenseNames_.CalculateSize(AddLocalPlayerToUserProxyRequest._repeated_contentLicenseNames_codec);
			bool flag2 = this.trace_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trace);
			}
			bool hasConnectedRegionId = this.HasConnectedRegionId;
			if (hasConnectedRegionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConnectedRegionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x000EFD60 File Offset: 0x000EDF60
		[DebuggerNonUserCode]
		public void MergeFrom(AddLocalPlayerToUserProxyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSponsorGameAccountId = other.HasSponsorGameAccountId;
				if (hasSponsorGameAccountId)
				{
					this.SponsorGameAccountId = other.SponsorGameAccountId;
				}
				bool flag2 = other.platformAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.platformAccount_ == null;
					if (flag3)
					{
						this.PlatformAccount = new PlatformAccount();
					}
					this.PlatformAccount.MergeFrom(other.PlatformAccount);
				}
				bool hasAuthCode = other.HasAuthCode;
				if (hasAuthCode)
				{
					this.AuthCode = other.AuthCode;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this.contentLicenseNames_.Add(other.contentLicenseNames_);
				bool flag4 = other.trace_ != null;
				if (flag4)
				{
					bool flag5 = this.trace_ == null;
					if (flag5)
					{
						this.Trace = new Online.Trace();
					}
					this.Trace.MergeFrom(other.Trace);
				}
				bool hasConnectedRegionId = other.HasConnectedRegionId;
				if (hasConnectedRegionId)
				{
					this.ConnectedRegionId = other.ConnectedRegionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x000EFE8B File Offset: 0x000EE08B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x000EFE98 File Offset: 0x000EE098
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0054;
							}
							this.AuthCode = input.ReadString();
						}
						else
						{
							bool flag = this.platformAccount_ == null;
							if (flag)
							{
								this.PlatformAccount = new PlatformAccount();
							}
							input.ReadMessage(this.PlatformAccount);
						}
					}
					else
					{
						this.SponsorGameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0054;
						}
						this.contentLicenseNames_.AddEntriesFrom(ref input, AddLocalPlayerToUserProxyRequest._repeated_contentLicenseNames_codec);
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 56U)
					{
						goto IL_0054;
					}
					this.ConnectedRegionId = input.ReadUInt32();
				}
				else
				{
					bool flag2 = this.trace_ == null;
					if (flag2)
					{
						this.Trace = new Online.Trace();
					}
					input.ReadMessage(this.Trace);
				}
				continue;
				IL_0054:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BE2 RID: 7138
		private static readonly MessageParser<AddLocalPlayerToUserProxyRequest> _parser = new MessageParser<AddLocalPlayerToUserProxyRequest>(() => new AddLocalPlayerToUserProxyRequest());

		// Token: 0x04001BE3 RID: 7139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BE4 RID: 7140
		private int _hasBits0;

		// Token: 0x04001BE5 RID: 7141
		public const int SponsorGameAccountIdFieldNumber = 1;

		// Token: 0x04001BE6 RID: 7142
		private static readonly uint SponsorGameAccountIdDefaultValue = 0U;

		// Token: 0x04001BE7 RID: 7143
		private uint sponsorGameAccountId_;

		// Token: 0x04001BE8 RID: 7144
		public const int PlatformAccountFieldNumber = 2;

		// Token: 0x04001BE9 RID: 7145
		private PlatformAccount platformAccount_;

		// Token: 0x04001BEA RID: 7146
		public const int AuthCodeFieldNumber = 3;

		// Token: 0x04001BEB RID: 7147
		private static readonly string AuthCodeDefaultValue = "";

		// Token: 0x04001BEC RID: 7148
		private string authCode_;

		// Token: 0x04001BED RID: 7149
		public const int SessionKeyFieldNumber = 4;

		// Token: 0x04001BEE RID: 7150
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001BEF RID: 7151
		private ByteString sessionKey_;

		// Token: 0x04001BF0 RID: 7152
		public const int ContentLicenseNamesFieldNumber = 5;

		// Token: 0x04001BF1 RID: 7153
		private static readonly FieldCodec<string> _repeated_contentLicenseNames_codec = FieldCodec.ForString(42U);

		// Token: 0x04001BF2 RID: 7154
		private readonly RepeatedField<string> contentLicenseNames_ = new RepeatedField<string>();

		// Token: 0x04001BF3 RID: 7155
		public const int TraceFieldNumber = 6;

		// Token: 0x04001BF4 RID: 7156
		private Online.Trace trace_;

		// Token: 0x04001BF5 RID: 7157
		public const int ConnectedRegionIdFieldNumber = 7;

		// Token: 0x04001BF6 RID: 7158
		private static readonly uint ConnectedRegionIdDefaultValue = 0U;

		// Token: 0x04001BF7 RID: 7159
		private uint connectedRegionId_;
	}
}
