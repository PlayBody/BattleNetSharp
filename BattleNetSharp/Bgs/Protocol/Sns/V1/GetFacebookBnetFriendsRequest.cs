using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C6 RID: 966
	public sealed class GetFacebookBnetFriendsRequest : IMessage<GetFacebookBnetFriendsRequest>, IMessage, IEquatable<GetFacebookBnetFriendsRequest>, IDeepCloneable<GetFacebookBnetFriendsRequest>, IBufferMessage
	{
		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x00176CF8 File Offset: 0x00174EF8
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookBnetFriendsRequest> Parser
		{
			get
			{
				return GetFacebookBnetFriendsRequest._parser;
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x00176D10 File Offset: 0x00174F10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x00176D34 File Offset: 0x00174F34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookBnetFriendsRequest.Descriptor;
			}
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00176D4B File Offset: 0x00174F4B
		[DebuggerNonUserCode]
		public GetFacebookBnetFriendsRequest()
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00176D55 File Offset: 0x00174F55
		[DebuggerNonUserCode]
		public GetFacebookBnetFriendsRequest(GetFacebookBnetFriendsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.profilePictureType_ = other.profilePictureType_;
			this.token_ = other.token_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00176D94 File Offset: 0x00174F94
		[DebuggerNonUserCode]
		public GetFacebookBnetFriendsRequest Clone()
		{
			return new GetFacebookBnetFriendsRequest(this);
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x060060AE RID: 24750 RVA: 0x00176DAC File Offset: 0x00174FAC
		// (set) Token: 0x060060AF RID: 24751 RVA: 0x00176DDD File Offset: 0x00174FDD
		[DebuggerNonUserCode]
		public GetFacebookBnetFriendsRequest.Types.ProfilePictureType ProfilePictureType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				GetFacebookBnetFriendsRequest.Types.ProfilePictureType profilePictureTypeDefaultValue;
				if (flag)
				{
					profilePictureTypeDefaultValue = this.profilePictureType_;
				}
				else
				{
					profilePictureTypeDefaultValue = GetFacebookBnetFriendsRequest.ProfilePictureTypeDefaultValue;
				}
				return profilePictureTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.profilePictureType_ = value;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x060060B0 RID: 24752 RVA: 0x00176DF8 File Offset: 0x00174FF8
		[DebuggerNonUserCode]
		public bool HasProfilePictureType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00176E15 File Offset: 0x00175015
		[DebuggerNonUserCode]
		public void ClearProfilePictureType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x00176E28 File Offset: 0x00175028
		// (set) Token: 0x060060B3 RID: 24755 RVA: 0x00176E59 File Offset: 0x00175059
		[DebuggerNonUserCode]
		public uint Token
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = GetFacebookBnetFriendsRequest.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.token_ = value;
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x00176E74 File Offset: 0x00175074
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00176E91 File Offset: 0x00175091
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00176EA4 File Offset: 0x001750A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookBnetFriendsRequest);
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x00176EC4 File Offset: 0x001750C4
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookBnetFriendsRequest other)
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
					bool flag4 = this.ProfilePictureType != other.ProfilePictureType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Token != other.Token;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00176F38 File Offset: 0x00175138
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProfilePictureType = this.HasProfilePictureType;
			if (hasProfilePictureType)
			{
				num ^= this.ProfilePictureType.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00176FAC File Offset: 0x001751AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00176FC4 File Offset: 0x001751C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x00176FD0 File Offset: 0x001751D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProfilePictureType = this.HasProfilePictureType;
			if (hasProfilePictureType)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ProfilePictureType);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00177040 File Offset: 0x00175240
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProfilePictureType = this.HasProfilePictureType;
			if (hasProfilePictureType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ProfilePictureType);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x001770AC File Offset: 0x001752AC
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookBnetFriendsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProfilePictureType = other.HasProfilePictureType;
				if (hasProfilePictureType)
				{
					this.ProfilePictureType = other.ProfilePictureType;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x0017710E File Offset: 0x0017530E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x0017711C File Offset: 0x0017531C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					if (num3 != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Token = input.ReadUInt32();
					}
				}
				else
				{
					this.ProfilePictureType = (GetFacebookBnetFriendsRequest.Types.ProfilePictureType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C2F RID: 11311
		private static readonly MessageParser<GetFacebookBnetFriendsRequest> _parser = new MessageParser<GetFacebookBnetFriendsRequest>(() => new GetFacebookBnetFriendsRequest());

		// Token: 0x04002C30 RID: 11312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C31 RID: 11313
		private int _hasBits0;

		// Token: 0x04002C32 RID: 11314
		public const int ProfilePictureTypeFieldNumber = 2;

		// Token: 0x04002C33 RID: 11315
		private static readonly GetFacebookBnetFriendsRequest.Types.ProfilePictureType ProfilePictureTypeDefaultValue = GetFacebookBnetFriendsRequest.Types.ProfilePictureType.Small;

		// Token: 0x04002C34 RID: 11316
		private GetFacebookBnetFriendsRequest.Types.ProfilePictureType profilePictureType_;

		// Token: 0x04002C35 RID: 11317
		public const int TokenFieldNumber = 3;

		// Token: 0x04002C36 RID: 11318
		private static readonly uint TokenDefaultValue = 0U;

		// Token: 0x04002C37 RID: 11319
		private uint token_;

		// Token: 0x02000E96 RID: 3734
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001495 RID: 5269
			public enum ProfilePictureType
			{
				// Token: 0x0400A4F0 RID: 42224
				[OriginalName("SMALL")]
				Small,
				// Token: 0x0400A4F1 RID: 42225
				[OriginalName("NORMAL")]
				Normal,
				// Token: 0x0400A4F2 RID: 42226
				[OriginalName("LARGE")]
				Large,
				// Token: 0x0400A4F3 RID: 42227
				[OriginalName("SQUARE")]
				Square
			}
		}
	}
}
