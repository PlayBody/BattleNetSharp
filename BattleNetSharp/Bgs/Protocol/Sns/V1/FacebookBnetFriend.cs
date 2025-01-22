using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003D0 RID: 976
	public sealed class FacebookBnetFriend : IMessage<FacebookBnetFriend>, IMessage, IEquatable<FacebookBnetFriend>, IDeepCloneable<FacebookBnetFriend>, IBufferMessage
	{
		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06006199 RID: 24985 RVA: 0x001798F4 File Offset: 0x00177AF4
		[DebuggerNonUserCode]
		public static MessageParser<FacebookBnetFriend> Parser
		{
			get
			{
				return FacebookBnetFriend._parser;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x0017990C File Offset: 0x00177B0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x0600619B RID: 24987 RVA: 0x00179930 File Offset: 0x00177B30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FacebookBnetFriend.Descriptor;
			}
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00179947 File Offset: 0x00177B47
		[DebuggerNonUserCode]
		public FacebookBnetFriend()
		{
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00179954 File Offset: 0x00177B54
		[DebuggerNonUserCode]
		public FacebookBnetFriend(FacebookBnetFriend other)
			: this()
		{
			this.bnetId_ = ((other.bnetId_ != null) ? other.bnetId_.Clone() : null);
			this.fbId_ = other.fbId_;
			this.lastName_ = other.lastName_;
			this.firstName_ = other.firstName_;
			this.profilePicture_ = other.profilePicture_;
			this.displayName_ = other.displayName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x001799D4 File Offset: 0x00177BD4
		[DebuggerNonUserCode]
		public FacebookBnetFriend Clone()
		{
			return new FacebookBnetFriend(this);
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600619F RID: 24991 RVA: 0x001799EC File Offset: 0x00177BEC
		// (set) Token: 0x060061A0 RID: 24992 RVA: 0x00179A04 File Offset: 0x00177C04
		[DebuggerNonUserCode]
		public AccountId BnetId
		{
			get
			{
				return this.bnetId_;
			}
			set
			{
				this.bnetId_ = value;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x00179A10 File Offset: 0x00177C10
		// (set) Token: 0x060061A2 RID: 24994 RVA: 0x00179A31 File Offset: 0x00177C31
		[DebuggerNonUserCode]
		public string FbId
		{
			get
			{
				return this.fbId_ ?? FacebookBnetFriend.FbIdDefaultValue;
			}
			set
			{
				this.fbId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x060061A3 RID: 24995 RVA: 0x00179A48 File Offset: 0x00177C48
		[DebuggerNonUserCode]
		public bool HasFbId
		{
			get
			{
				return this.fbId_ != null;
			}
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x00179A63 File Offset: 0x00177C63
		[DebuggerNonUserCode]
		public void ClearFbId()
		{
			this.fbId_ = null;
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x060061A5 RID: 24997 RVA: 0x00179A70 File Offset: 0x00177C70
		// (set) Token: 0x060061A6 RID: 24998 RVA: 0x00179A91 File Offset: 0x00177C91
		[DebuggerNonUserCode]
		public string LastName
		{
			get
			{
				return this.lastName_ ?? FacebookBnetFriend.LastNameDefaultValue;
			}
			set
			{
				this.lastName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x00179AA8 File Offset: 0x00177CA8
		[DebuggerNonUserCode]
		public bool HasLastName
		{
			get
			{
				return this.lastName_ != null;
			}
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00179AC3 File Offset: 0x00177CC3
		[DebuggerNonUserCode]
		public void ClearLastName()
		{
			this.lastName_ = null;
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x060061A9 RID: 25001 RVA: 0x00179AD0 File Offset: 0x00177CD0
		// (set) Token: 0x060061AA RID: 25002 RVA: 0x00179AF1 File Offset: 0x00177CF1
		[DebuggerNonUserCode]
		public string FirstName
		{
			get
			{
				return this.firstName_ ?? FacebookBnetFriend.FirstNameDefaultValue;
			}
			set
			{
				this.firstName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x060061AB RID: 25003 RVA: 0x00179B08 File Offset: 0x00177D08
		[DebuggerNonUserCode]
		public bool HasFirstName
		{
			get
			{
				return this.firstName_ != null;
			}
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00179B23 File Offset: 0x00177D23
		[DebuggerNonUserCode]
		public void ClearFirstName()
		{
			this.firstName_ = null;
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x060061AD RID: 25005 RVA: 0x00179B30 File Offset: 0x00177D30
		// (set) Token: 0x060061AE RID: 25006 RVA: 0x00179B51 File Offset: 0x00177D51
		[DebuggerNonUserCode]
		public string ProfilePicture
		{
			get
			{
				return this.profilePicture_ ?? FacebookBnetFriend.ProfilePictureDefaultValue;
			}
			set
			{
				this.profilePicture_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x00179B68 File Offset: 0x00177D68
		[DebuggerNonUserCode]
		public bool HasProfilePicture
		{
			get
			{
				return this.profilePicture_ != null;
			}
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00179B83 File Offset: 0x00177D83
		[DebuggerNonUserCode]
		public void ClearProfilePicture()
		{
			this.profilePicture_ = null;
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x00179B90 File Offset: 0x00177D90
		// (set) Token: 0x060061B2 RID: 25010 RVA: 0x00179BB1 File Offset: 0x00177DB1
		[DebuggerNonUserCode]
		public string DisplayName
		{
			get
			{
				return this.displayName_ ?? FacebookBnetFriend.DisplayNameDefaultValue;
			}
			set
			{
				this.displayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x060061B3 RID: 25011 RVA: 0x00179BC8 File Offset: 0x00177DC8
		[DebuggerNonUserCode]
		public bool HasDisplayName
		{
			get
			{
				return this.displayName_ != null;
			}
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00179BE3 File Offset: 0x00177DE3
		[DebuggerNonUserCode]
		public void ClearDisplayName()
		{
			this.displayName_ = null;
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x00179BF0 File Offset: 0x00177DF0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FacebookBnetFriend);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x00179C10 File Offset: 0x00177E10
		[DebuggerNonUserCode]
		public bool Equals(FacebookBnetFriend other)
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
					bool flag4 = !object.Equals(this.BnetId, other.BnetId);
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
							bool flag6 = this.LastName != other.LastName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FirstName != other.FirstName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ProfilePicture != other.ProfilePicture;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.DisplayName != other.DisplayName;
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

		// Token: 0x060061B7 RID: 25015 RVA: 0x00179CFC File Offset: 0x00177EFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.bnetId_ != null;
			if (flag)
			{
				num ^= this.BnetId.GetHashCode();
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num ^= this.FbId.GetHashCode();
			}
			bool hasLastName = this.HasLastName;
			if (hasLastName)
			{
				num ^= this.LastName.GetHashCode();
			}
			bool hasFirstName = this.HasFirstName;
			if (hasFirstName)
			{
				num ^= this.FirstName.GetHashCode();
			}
			bool hasProfilePicture = this.HasProfilePicture;
			if (hasProfilePicture)
			{
				num ^= this.ProfilePicture.GetHashCode();
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num ^= this.DisplayName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x00179DCC File Offset: 0x00177FCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00179DE4 File Offset: 0x00177FE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00179DF0 File Offset: 0x00177FF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.bnetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BnetId);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.FbId);
			}
			bool hasLastName = this.HasLastName;
			if (hasLastName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.LastName);
			}
			bool hasFirstName = this.HasFirstName;
			if (hasFirstName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.FirstName);
			}
			bool hasProfilePicture = this.HasProfilePicture;
			if (hasProfilePicture)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ProfilePicture);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.DisplayName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00179EF0 File Offset: 0x001780F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.bnetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BnetId);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FbId);
			}
			bool hasLastName = this.HasLastName;
			if (hasLastName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LastName);
			}
			bool hasFirstName = this.HasFirstName;
			if (hasFirstName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FirstName);
			}
			bool hasProfilePicture = this.HasProfilePicture;
			if (hasProfilePicture)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProfilePicture);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00179FD8 File Offset: 0x001781D8
		[DebuggerNonUserCode]
		public void MergeFrom(FacebookBnetFriend other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.bnetId_ != null;
				if (flag2)
				{
					bool flag3 = this.bnetId_ == null;
					if (flag3)
					{
						this.BnetId = new AccountId();
					}
					this.BnetId.MergeFrom(other.BnetId);
				}
				bool hasFbId = other.HasFbId;
				if (hasFbId)
				{
					this.FbId = other.FbId;
				}
				bool hasLastName = other.HasLastName;
				if (hasLastName)
				{
					this.LastName = other.LastName;
				}
				bool hasFirstName = other.HasFirstName;
				if (hasFirstName)
				{
					this.FirstName = other.FirstName;
				}
				bool hasProfilePicture = other.HasProfilePicture;
				if (hasProfilePicture)
				{
					this.ProfilePicture = other.ProfilePicture;
				}
				bool hasDisplayName = other.HasDisplayName;
				if (hasDisplayName)
				{
					this.DisplayName = other.DisplayName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x0017A0CC File Offset: 0x001782CC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x0017A0D8 File Offset: 0x001782D8
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_003D;
							}
							this.LastName = input.ReadString();
						}
						else
						{
							this.FbId = input.ReadString();
						}
					}
					else
					{
						bool flag = this.bnetId_ == null;
						if (flag)
						{
							this.BnetId = new AccountId();
						}
						input.ReadMessage(this.BnetId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_003D;
						}
						this.DisplayName = input.ReadString();
					}
					else
					{
						this.ProfilePicture = input.ReadString();
					}
				}
				else
				{
					this.FirstName = input.ReadString();
				}
				continue;
				IL_003D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C7F RID: 11391
		private static readonly MessageParser<FacebookBnetFriend> _parser = new MessageParser<FacebookBnetFriend>(() => new FacebookBnetFriend());

		// Token: 0x04002C80 RID: 11392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C81 RID: 11393
		public const int BnetIdFieldNumber = 1;

		// Token: 0x04002C82 RID: 11394
		private AccountId bnetId_;

		// Token: 0x04002C83 RID: 11395
		public const int FbIdFieldNumber = 2;

		// Token: 0x04002C84 RID: 11396
		private static readonly string FbIdDefaultValue = "";

		// Token: 0x04002C85 RID: 11397
		private string fbId_;

		// Token: 0x04002C86 RID: 11398
		public const int LastNameFieldNumber = 3;

		// Token: 0x04002C87 RID: 11399
		private static readonly string LastNameDefaultValue = "";

		// Token: 0x04002C88 RID: 11400
		private string lastName_;

		// Token: 0x04002C89 RID: 11401
		public const int FirstNameFieldNumber = 4;

		// Token: 0x04002C8A RID: 11402
		private static readonly string FirstNameDefaultValue = "";

		// Token: 0x04002C8B RID: 11403
		private string firstName_;

		// Token: 0x04002C8C RID: 11404
		public const int ProfilePictureFieldNumber = 5;

		// Token: 0x04002C8D RID: 11405
		private static readonly string ProfilePictureDefaultValue = "";

		// Token: 0x04002C8E RID: 11406
		private string profilePicture_;

		// Token: 0x04002C8F RID: 11407
		public const int DisplayNameFieldNumber = 6;

		// Token: 0x04002C90 RID: 11408
		private static readonly string DisplayNameDefaultValue = "";

		// Token: 0x04002C91 RID: 11409
		private string displayName_;
	}
}
