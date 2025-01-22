using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CF RID: 975
	public sealed class FacebookBnetFriendListNotification : IMessage<FacebookBnetFriendListNotification>, IMessage, IEquatable<FacebookBnetFriendListNotification>, IDeepCloneable<FacebookBnetFriendListNotification>, IBufferMessage
	{
		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06006175 RID: 24949 RVA: 0x00178FD0 File Offset: 0x001771D0
		[DebuggerNonUserCode]
		public static MessageParser<FacebookBnetFriendListNotification> Parser
		{
			get
			{
				return FacebookBnetFriendListNotification._parser;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x00178FE8 File Offset: 0x001771E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x0017900C File Offset: 0x0017720C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FacebookBnetFriendListNotification.Descriptor;
			}
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x00179023 File Offset: 0x00177223
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotification()
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00179038 File Offset: 0x00177238
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotification(FacebookBnetFriendListNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.friendList_ = other.friendList_.Clone();
			this.listEnd_ = other.listEnd_;
			this.token_ = other.token_;
			this.fbId_ = other.fbId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x001790C8 File Offset: 0x001772C8
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotification Clone()
		{
			return new FacebookBnetFriendListNotification(this);
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600617B RID: 24955 RVA: 0x001790E0 File Offset: 0x001772E0
		// (set) Token: 0x0600617C RID: 24956 RVA: 0x00179111 File Offset: 0x00177311
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = FacebookBnetFriendListNotification.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600617D RID: 24957 RVA: 0x0017912C File Offset: 0x0017732C
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00179149 File Offset: 0x00177349
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x0600617F RID: 24959 RVA: 0x0017915C File Offset: 0x0017735C
		// (set) Token: 0x06006180 RID: 24960 RVA: 0x00179174 File Offset: 0x00177374
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x00179180 File Offset: 0x00177380
		[DebuggerNonUserCode]
		public RepeatedField<FacebookBnetFriend> FriendList
		{
			get
			{
				return this.friendList_;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x00179198 File Offset: 0x00177398
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x001791C9 File Offset: 0x001773C9
		[DebuggerNonUserCode]
		public bool ListEnd
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool listEndDefaultValue;
				if (flag)
				{
					listEndDefaultValue = this.listEnd_;
				}
				else
				{
					listEndDefaultValue = FacebookBnetFriendListNotification.ListEndDefaultValue;
				}
				return listEndDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.listEnd_ = value;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x001791E4 File Offset: 0x001773E4
		[DebuggerNonUserCode]
		public bool HasListEnd
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x00179201 File Offset: 0x00177401
		[DebuggerNonUserCode]
		public void ClearListEnd()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x00179214 File Offset: 0x00177414
		// (set) Token: 0x06006187 RID: 24967 RVA: 0x00179245 File Offset: 0x00177445
		[DebuggerNonUserCode]
		public uint Token
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = FacebookBnetFriendListNotification.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.token_ = value;
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x00179260 File Offset: 0x00177460
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0017927D File Offset: 0x0017747D
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x00179290 File Offset: 0x00177490
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x001792B1 File Offset: 0x001774B1
		[DebuggerNonUserCode]
		public string FbId
		{
			get
			{
				return this.fbId_ ?? FacebookBnetFriendListNotification.FbIdDefaultValue;
			}
			set
			{
				this.fbId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x001792C8 File Offset: 0x001774C8
		[DebuggerNonUserCode]
		public bool HasFbId
		{
			get
			{
				return this.fbId_ != null;
			}
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x001792E3 File Offset: 0x001774E3
		[DebuggerNonUserCode]
		public void ClearFbId()
		{
			this.fbId_ = null;
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x001792F0 File Offset: 0x001774F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FacebookBnetFriendListNotification);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00179310 File Offset: 0x00177510
		[DebuggerNonUserCode]
		public bool Equals(FacebookBnetFriendListNotification other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Identity, other.Identity);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.friendList_.Equals(other.friendList_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ListEnd != other.ListEnd;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Token != other.Token;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.FbId != other.FbId;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x00179400 File Offset: 0x00177600
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			num ^= this.friendList_.GetHashCode();
			bool hasListEnd = this.HasListEnd;
			if (hasListEnd)
			{
				num ^= this.ListEnd.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num ^= this.FbId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x001794D0 File Offset: 0x001776D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x001794E8 File Offset: 0x001776E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x001794F4 File Offset: 0x001776F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Identity);
			}
			this.friendList_.WriteTo(ref output, FacebookBnetFriendListNotification._repeated_friendList_codec);
			bool hasListEnd = this.HasListEnd;
			if (hasListEnd)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ListEnd);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Token);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.FbId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x001795E0 File Offset: 0x001777E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			num += this.friendList_.CalculateSize(FacebookBnetFriendListNotification._repeated_friendList_codec);
			bool hasListEnd = this.HasListEnd;
			if (hasListEnd)
			{
				num += 2;
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Token);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FbId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x001796B0 File Offset: 0x001778B0
		[DebuggerNonUserCode]
		public void MergeFrom(FacebookBnetFriendListNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				this.friendList_.Add(other.friendList_);
				bool hasListEnd = other.HasListEnd;
				if (hasListEnd)
				{
					this.ListEnd = other.ListEnd;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasFbId = other.HasFbId;
				if (hasFbId)
				{
					this.FbId = other.FbId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0017979B File Offset: 0x0017799B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x001797A8 File Offset: 0x001779A8
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
								goto IL_003F;
							}
							this.friendList_.AddEntriesFrom(ref input, FacebookBnetFriendListNotification._repeated_friendList_codec);
						}
						else
						{
							bool flag = this.identity_ == null;
							if (flag)
							{
								this.Identity = new Identity();
							}
							input.ReadMessage(this.Identity);
						}
					}
					else
					{
						this.ErrorCode = input.ReadUInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_003F;
						}
						this.FbId = input.ReadString();
					}
					else
					{
						this.Token = input.ReadUInt32();
					}
				}
				else
				{
					this.ListEnd = input.ReadBool();
				}
				continue;
				IL_003F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C6B RID: 11371
		private static readonly MessageParser<FacebookBnetFriendListNotification> _parser = new MessageParser<FacebookBnetFriendListNotification>(() => new FacebookBnetFriendListNotification());

		// Token: 0x04002C6C RID: 11372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C6D RID: 11373
		private int _hasBits0;

		// Token: 0x04002C6E RID: 11374
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002C6F RID: 11375
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04002C70 RID: 11376
		private uint errorCode_;

		// Token: 0x04002C71 RID: 11377
		public const int IdentityFieldNumber = 2;

		// Token: 0x04002C72 RID: 11378
		private Identity identity_;

		// Token: 0x04002C73 RID: 11379
		public const int FriendListFieldNumber = 3;

		// Token: 0x04002C74 RID: 11380
		private static readonly FieldCodec<FacebookBnetFriend> _repeated_friendList_codec = FieldCodec.ForMessage<FacebookBnetFriend>(26U, FacebookBnetFriend.Parser);

		// Token: 0x04002C75 RID: 11381
		private readonly RepeatedField<FacebookBnetFriend> friendList_ = new RepeatedField<FacebookBnetFriend>();

		// Token: 0x04002C76 RID: 11382
		public const int ListEndFieldNumber = 4;

		// Token: 0x04002C77 RID: 11383
		private static readonly bool ListEndDefaultValue = false;

		// Token: 0x04002C78 RID: 11384
		private bool listEnd_;

		// Token: 0x04002C79 RID: 11385
		public const int TokenFieldNumber = 5;

		// Token: 0x04002C7A RID: 11386
		private static readonly uint TokenDefaultValue = 0U;

		// Token: 0x04002C7B RID: 11387
		private uint token_;

		// Token: 0x04002C7C RID: 11388
		public const int FbIdFieldNumber = 6;

		// Token: 0x04002C7D RID: 11389
		private static readonly string FbIdDefaultValue = "";

		// Token: 0x04002C7E RID: 11390
		private string fbId_;
	}
}
