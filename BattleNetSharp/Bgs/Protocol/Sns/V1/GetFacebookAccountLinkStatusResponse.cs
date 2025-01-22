using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C9 RID: 969
	public sealed class GetFacebookAccountLinkStatusResponse : IMessage<GetFacebookAccountLinkStatusResponse>, IMessage, IEquatable<GetFacebookAccountLinkStatusResponse>, IDeepCloneable<GetFacebookAccountLinkStatusResponse>, IBufferMessage
	{
		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x00177968 File Offset: 0x00175B68
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookAccountLinkStatusResponse> Parser
		{
			get
			{
				return GetFacebookAccountLinkStatusResponse._parser;
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x00177980 File Offset: 0x00175B80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001779A4 File Offset: 0x00175BA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookAccountLinkStatusResponse.Descriptor;
			}
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x001779BB File Offset: 0x00175BBB
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusResponse()
		{
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x001779C8 File Offset: 0x00175BC8
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusResponse(GetFacebookAccountLinkStatusResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountLinked_ = other.accountLinked_;
			this.fbId_ = other.fbId_;
			this.displayName_ = other.displayName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00177A20 File Offset: 0x00175C20
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusResponse Clone()
		{
			return new GetFacebookAccountLinkStatusResponse(this);
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x00177A38 File Offset: 0x00175C38
		// (set) Token: 0x060060F6 RID: 24822 RVA: 0x00177A69 File Offset: 0x00175C69
		[DebuggerNonUserCode]
		public bool AccountLinked
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool accountLinkedDefaultValue;
				if (flag)
				{
					accountLinkedDefaultValue = this.accountLinked_;
				}
				else
				{
					accountLinkedDefaultValue = GetFacebookAccountLinkStatusResponse.AccountLinkedDefaultValue;
				}
				return accountLinkedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountLinked_ = value;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x060060F7 RID: 24823 RVA: 0x00177A84 File Offset: 0x00175C84
		[DebuggerNonUserCode]
		public bool HasAccountLinked
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00177AA1 File Offset: 0x00175CA1
		[DebuggerNonUserCode]
		public void ClearAccountLinked()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x00177AB4 File Offset: 0x00175CB4
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x00177AD5 File Offset: 0x00175CD5
		[DebuggerNonUserCode]
		public string FbId
		{
			get
			{
				return this.fbId_ ?? GetFacebookAccountLinkStatusResponse.FbIdDefaultValue;
			}
			set
			{
				this.fbId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x00177AEC File Offset: 0x00175CEC
		[DebuggerNonUserCode]
		public bool HasFbId
		{
			get
			{
				return this.fbId_ != null;
			}
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00177B07 File Offset: 0x00175D07
		[DebuggerNonUserCode]
		public void ClearFbId()
		{
			this.fbId_ = null;
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x00177B14 File Offset: 0x00175D14
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x00177B35 File Offset: 0x00175D35
		[DebuggerNonUserCode]
		public string DisplayName
		{
			get
			{
				return this.displayName_ ?? GetFacebookAccountLinkStatusResponse.DisplayNameDefaultValue;
			}
			set
			{
				this.displayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x00177B4C File Offset: 0x00175D4C
		[DebuggerNonUserCode]
		public bool HasDisplayName
		{
			get
			{
				return this.displayName_ != null;
			}
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x00177B67 File Offset: 0x00175D67
		[DebuggerNonUserCode]
		public void ClearDisplayName()
		{
			this.displayName_ = null;
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00177B74 File Offset: 0x00175D74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookAccountLinkStatusResponse);
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x00177B94 File Offset: 0x00175D94
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookAccountLinkStatusResponse other)
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
					bool flag4 = this.AccountLinked != other.AccountLinked;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FbId != other.FbId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DisplayName != other.DisplayName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x00177C20 File Offset: 0x00175E20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				num ^= this.AccountLinked.GetHashCode();
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num ^= this.FbId.GetHashCode();
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num ^= this.DisplayName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00177CA4 File Offset: 0x00175EA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x00177CBC File Offset: 0x00175EBC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x00177CC8 File Offset: 0x00175EC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AccountLinked);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.FbId);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00177D58 File Offset: 0x00175F58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				num += 2;
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FbId);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x00177DD8 File Offset: 0x00175FD8
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookAccountLinkStatusResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountLinked = other.HasAccountLinked;
				if (hasAccountLinked)
				{
					this.AccountLinked = other.AccountLinked;
				}
				bool hasFbId = other.HasFbId;
				if (hasFbId)
				{
					this.FbId = other.FbId;
				}
				bool hasDisplayName = other.HasDisplayName;
				if (hasDisplayName)
				{
					this.DisplayName = other.DisplayName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00177E53 File Offset: 0x00176053
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00177E60 File Offset: 0x00176060
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DisplayName = input.ReadString();
						}
					}
					else
					{
						this.FbId = input.ReadString();
					}
				}
				else
				{
					this.AccountLinked = input.ReadBool();
				}
			}
		}

		// Token: 0x04002C45 RID: 11333
		private static readonly MessageParser<GetFacebookAccountLinkStatusResponse> _parser = new MessageParser<GetFacebookAccountLinkStatusResponse>(() => new GetFacebookAccountLinkStatusResponse());

		// Token: 0x04002C46 RID: 11334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C47 RID: 11335
		private int _hasBits0;

		// Token: 0x04002C48 RID: 11336
		public const int AccountLinkedFieldNumber = 1;

		// Token: 0x04002C49 RID: 11337
		private static readonly bool AccountLinkedDefaultValue = false;

		// Token: 0x04002C4A RID: 11338
		private bool accountLinked_;

		// Token: 0x04002C4B RID: 11339
		public const int FbIdFieldNumber = 2;

		// Token: 0x04002C4C RID: 11340
		private static readonly string FbIdDefaultValue = "";

		// Token: 0x04002C4D RID: 11341
		private string fbId_;

		// Token: 0x04002C4E RID: 11342
		public const int DisplayNameFieldNumber = 3;

		// Token: 0x04002C4F RID: 11343
		private static readonly string DisplayNameDefaultValue = "";

		// Token: 0x04002C50 RID: 11344
		private string displayName_;
	}
}
