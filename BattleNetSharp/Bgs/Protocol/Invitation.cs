using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000380 RID: 896
	public sealed class Invitation : IExtendableMessage<Invitation>, IMessage<Invitation>, IMessage, IEquatable<Invitation>, IDeepCloneable<Invitation>, IBufferMessage
	{
		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x001607EC File Offset: 0x0015E9EC
		private ExtensionSet<Invitation> _Extensions
		{
			get
			{
				return this._extensions;
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x00160804 File Offset: 0x0015EA04
		[DebuggerNonUserCode]
		public static MessageParser<Invitation> Parser
		{
			get
			{
				return Invitation._parser;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x0016081C File Offset: 0x0015EA1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x00160840 File Offset: 0x0015EA40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Invitation.Descriptor;
			}
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x00160857 File Offset: 0x0015EA57
		[DebuggerNonUserCode]
		public Invitation()
		{
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00160864 File Offset: 0x0015EA64
		[DebuggerNonUserCode]
		public Invitation(Invitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.inviterIdentity_ = ((other.inviterIdentity_ != null) ? other.inviterIdentity_.Clone() : null);
			this.inviteeIdentity_ = ((other.inviteeIdentity_ != null) ? other.inviteeIdentity_.Clone() : null);
			this.inviterName_ = other.inviterName_;
			this.inviteeName_ = other.inviteeName_;
			this.invitationMessage_ = other.invitationMessage_;
			this.creationTime_ = other.creationTime_;
			this.expirationTime_ = other.expirationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			this._extensions = ExtensionSet.Clone<Invitation>(other._extensions);
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00160928 File Offset: 0x0015EB28
		[DebuggerNonUserCode]
		public Invitation Clone()
		{
			return new Invitation(this);
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x00160940 File Offset: 0x0015EB40
		// (set) Token: 0x06005B23 RID: 23331 RVA: 0x00160971 File Offset: 0x0015EB71
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Invitation.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x0016098C File Offset: 0x0015EB8C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x001609A9 File Offset: 0x0015EBA9
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x001609BC File Offset: 0x0015EBBC
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x001609D4 File Offset: 0x0015EBD4
		[DebuggerNonUserCode]
		public Identity InviterIdentity
		{
			get
			{
				return this.inviterIdentity_;
			}
			set
			{
				this.inviterIdentity_ = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x001609E0 File Offset: 0x0015EBE0
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x001609F8 File Offset: 0x0015EBF8
		[DebuggerNonUserCode]
		public Identity InviteeIdentity
		{
			get
			{
				return this.inviteeIdentity_;
			}
			set
			{
				this.inviteeIdentity_ = value;
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x00160A04 File Offset: 0x0015EC04
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x00160A25 File Offset: 0x0015EC25
		[DebuggerNonUserCode]
		public string InviterName
		{
			get
			{
				return this.inviterName_ ?? Invitation.InviterNameDefaultValue;
			}
			set
			{
				this.inviterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x00160A3C File Offset: 0x0015EC3C
		[DebuggerNonUserCode]
		public bool HasInviterName
		{
			get
			{
				return this.inviterName_ != null;
			}
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x00160A57 File Offset: 0x0015EC57
		[DebuggerNonUserCode]
		public void ClearInviterName()
		{
			this.inviterName_ = null;
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x00160A64 File Offset: 0x0015EC64
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x00160A85 File Offset: 0x0015EC85
		[DebuggerNonUserCode]
		public string InviteeName
		{
			get
			{
				return this.inviteeName_ ?? Invitation.InviteeNameDefaultValue;
			}
			set
			{
				this.inviteeName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x00160A9C File Offset: 0x0015EC9C
		[DebuggerNonUserCode]
		public bool HasInviteeName
		{
			get
			{
				return this.inviteeName_ != null;
			}
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00160AB7 File Offset: 0x0015ECB7
		[DebuggerNonUserCode]
		public void ClearInviteeName()
		{
			this.inviteeName_ = null;
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x00160AC4 File Offset: 0x0015ECC4
		// (set) Token: 0x06005B33 RID: 23347 RVA: 0x00160AE5 File Offset: 0x0015ECE5
		[DebuggerNonUserCode]
		public string InvitationMessage
		{
			get
			{
				return this.invitationMessage_ ?? Invitation.InvitationMessageDefaultValue;
			}
			set
			{
				this.invitationMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06005B34 RID: 23348 RVA: 0x00160AFC File Offset: 0x0015ECFC
		[DebuggerNonUserCode]
		public bool HasInvitationMessage
		{
			get
			{
				return this.invitationMessage_ != null;
			}
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x00160B17 File Offset: 0x0015ED17
		[DebuggerNonUserCode]
		public void ClearInvitationMessage()
		{
			this.invitationMessage_ = null;
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x00160B24 File Offset: 0x0015ED24
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x00160B55 File Offset: 0x0015ED55
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Invitation.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x00160B70 File Offset: 0x0015ED70
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00160B8D File Offset: 0x0015ED8D
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06005B3A RID: 23354 RVA: 0x00160BA0 File Offset: 0x0015EDA0
		// (set) Token: 0x06005B3B RID: 23355 RVA: 0x00160BD1 File Offset: 0x0015EDD1
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = Invitation.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x00160BEC File Offset: 0x0015EDEC
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00160C09 File Offset: 0x0015EE09
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00160C1C File Offset: 0x0015EE1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Invitation);
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x00160C3C File Offset: 0x0015EE3C
		[DebuggerNonUserCode]
		public bool Equals(Invitation other)
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
						bool flag5 = !object.Equals(this.InviterIdentity, other.InviterIdentity);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.InviteeIdentity, other.InviteeIdentity);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InviterName != other.InviterName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.InviteeName != other.InviteeName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.InvitationMessage != other.InvitationMessage;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CreationTime != other.CreationTime;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ExpirationTime != other.ExpirationTime;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this._extensions, other._extensions);
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

		// Token: 0x06005B40 RID: 23360 RVA: 0x00160D8C File Offset: 0x0015EF8C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.inviterIdentity_ != null;
			if (flag)
			{
				num ^= this.InviterIdentity.GetHashCode();
			}
			bool flag2 = this.inviteeIdentity_ != null;
			if (flag2)
			{
				num ^= this.InviteeIdentity.GetHashCode();
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num ^= this.InviterName.GetHashCode();
			}
			bool hasInviteeName = this.HasInviteeName;
			if (hasInviteeName)
			{
				num ^= this.InviteeName.GetHashCode();
			}
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				num ^= this.InvitationMessage.GetHashCode();
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
			bool flag3 = this._extensions != null;
			if (flag3)
			{
				num ^= this._extensions.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x00160EBC File Offset: 0x0015F0BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00160ED4 File Offset: 0x0015F0D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x00160EE0 File Offset: 0x0015F0E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Id);
			}
			bool flag = this.inviterIdentity_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.InviterIdentity);
			}
			bool flag2 = this.inviteeIdentity_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.InviteeIdentity);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.InviterName);
			}
			bool hasInviteeName = this.HasInviteeName;
			if (hasInviteeName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.InviteeName);
			}
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				output.WriteRawTag(50);
				output.WriteString(this.InvitationMessage);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag3 = this._extensions != null;
			if (flag3)
			{
				this._extensions.WriteTo(ref output);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00161048 File Offset: 0x0015F248
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 9;
			}
			bool flag = this.inviterIdentity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InviterIdentity);
			}
			bool flag2 = this.inviteeIdentity_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InviteeIdentity);
			}
			bool hasInviterName = this.HasInviterName;
			if (hasInviterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterName);
			}
			bool hasInviteeName = this.HasInviteeName;
			if (hasInviteeName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviteeName);
			}
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InvitationMessage);
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
			bool flag3 = this._extensions != null;
			if (flag3)
			{
				num += this._extensions.CalculateSize();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00161184 File Offset: 0x0015F384
		[DebuggerNonUserCode]
		public void MergeFrom(Invitation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.inviterIdentity_ != null;
				if (flag2)
				{
					bool flag3 = this.inviterIdentity_ == null;
					if (flag3)
					{
						this.InviterIdentity = new Identity();
					}
					this.InviterIdentity.MergeFrom(other.InviterIdentity);
				}
				bool flag4 = other.inviteeIdentity_ != null;
				if (flag4)
				{
					bool flag5 = this.inviteeIdentity_ == null;
					if (flag5)
					{
						this.InviteeIdentity = new Identity();
					}
					this.InviteeIdentity.MergeFrom(other.InviteeIdentity);
				}
				bool hasInviterName = other.HasInviterName;
				if (hasInviterName)
				{
					this.InviterName = other.InviterName;
				}
				bool hasInviteeName = other.HasInviteeName;
				if (hasInviteeName)
				{
					this.InviteeName = other.InviteeName;
				}
				bool hasInvitationMessage = other.HasInvitationMessage;
				if (hasInvitationMessage)
				{
					this.InvitationMessage = other.InvitationMessage;
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
				ExtensionSet.MergeFrom<Invitation>(ref this._extensions, other._extensions);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x001612E5 File Offset: 0x0015F4E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x001612F0 File Offset: 0x0015F4F0
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
						if (num3 != 9U)
						{
							if (num3 != 18U)
							{
								goto IL_0067;
							}
							bool flag = this.inviterIdentity_ == null;
							if (flag)
							{
								this.InviterIdentity = new Identity();
							}
							input.ReadMessage(this.InviterIdentity);
						}
						else
						{
							this.Id = input.ReadFixed64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0067;
						}
						this.InviterName = input.ReadString();
					}
					else
					{
						bool flag2 = this.inviteeIdentity_ == null;
						if (flag2)
						{
							this.InviteeIdentity = new Identity();
						}
						input.ReadMessage(this.InviteeIdentity);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0067;
						}
						this.InvitationMessage = input.ReadString();
					}
					else
					{
						this.InviteeName = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0067;
					}
					this.ExpirationTime = input.ReadUInt64();
				}
				else
				{
					this.CreationTime = input.ReadUInt64();
				}
				continue;
				IL_0067:
				bool flag3 = !ExtensionSet.TryMergeFieldFrom<Invitation>(ref this._extensions, ref input);
				if (flag3)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
			}
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00161464 File Offset: 0x0015F664
		public TValue GetExtension<TValue>(Extension<Invitation, TValue> extension)
		{
			return ExtensionSet.Get<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00161484 File Offset: 0x0015F684
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<Invitation, TValue> extension)
		{
			return ExtensionSet.Get<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x001614A4 File Offset: 0x0015F6A4
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<Invitation, TValue> extension)
		{
			return ExtensionSet.GetOrInitialize<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x001614C2 File Offset: 0x0015F6C2
		public void SetExtension<TValue>(Extension<Invitation, TValue> extension, TValue value)
		{
			ExtensionSet.Set<Invitation, TValue>(ref this._extensions, extension, value);
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x001614D4 File Offset: 0x0015F6D4
		public bool HasExtension<TValue>(Extension<Invitation, TValue> extension)
		{
			return ExtensionSet.Has<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x001614F2 File Offset: 0x0015F6F2
		public void ClearExtension<TValue>(Extension<Invitation, TValue> extension)
		{
			ExtensionSet.Clear<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00161502 File Offset: 0x0015F702
		public void ClearExtension<TValue>(RepeatedExtension<Invitation, TValue> extension)
		{
			ExtensionSet.Clear<Invitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x04002996 RID: 10646
		private static readonly MessageParser<Invitation> _parser = new MessageParser<Invitation>(() => new Invitation());

		// Token: 0x04002997 RID: 10647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002998 RID: 10648
		private ExtensionSet<Invitation> _extensions;

		// Token: 0x04002999 RID: 10649
		private int _hasBits0;

		// Token: 0x0400299A RID: 10650
		public const int IdFieldNumber = 1;

		// Token: 0x0400299B RID: 10651
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x0400299C RID: 10652
		private ulong id_;

		// Token: 0x0400299D RID: 10653
		public const int InviterIdentityFieldNumber = 2;

		// Token: 0x0400299E RID: 10654
		private Identity inviterIdentity_;

		// Token: 0x0400299F RID: 10655
		public const int InviteeIdentityFieldNumber = 3;

		// Token: 0x040029A0 RID: 10656
		private Identity inviteeIdentity_;

		// Token: 0x040029A1 RID: 10657
		public const int InviterNameFieldNumber = 4;

		// Token: 0x040029A2 RID: 10658
		private static readonly string InviterNameDefaultValue = "";

		// Token: 0x040029A3 RID: 10659
		private string inviterName_;

		// Token: 0x040029A4 RID: 10660
		public const int InviteeNameFieldNumber = 5;

		// Token: 0x040029A5 RID: 10661
		private static readonly string InviteeNameDefaultValue = "";

		// Token: 0x040029A6 RID: 10662
		private string inviteeName_;

		// Token: 0x040029A7 RID: 10663
		public const int InvitationMessageFieldNumber = 6;

		// Token: 0x040029A8 RID: 10664
		private static readonly string InvitationMessageDefaultValue = "";

		// Token: 0x040029A9 RID: 10665
		private string invitationMessage_;

		// Token: 0x040029AA RID: 10666
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x040029AB RID: 10667
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040029AC RID: 10668
		private ulong creationTime_;

		// Token: 0x040029AD RID: 10669
		public const int ExpirationTimeFieldNumber = 8;

		// Token: 0x040029AE RID: 10670
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x040029AF RID: 10671
		private ulong expirationTime_;
	}
}
