using System;
using System.Diagnostics;
using System.Text;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006EB RID: 1771
	public sealed class ChannelState : IExtendableMessage<ChannelState>, IMessage<ChannelState>, IMessage, IEquatable<ChannelState>, IDeepCloneable<ChannelState>, IBufferMessage
	{
		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A33D RID: 41789 RVA: 0x0027CA8C File Offset: 0x0027AC8C
		private ExtensionSet<ChannelState> _Extensions
		{
			get
			{
				return this._extensions;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x0027CAA4 File Offset: 0x0027ACA4
		[DebuggerNonUserCode]
		public static MessageParser<ChannelState> Parser
		{
			get
			{
				return ChannelState._parser;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A33F RID: 41791 RVA: 0x0027CABC File Offset: 0x0027ACBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A340 RID: 41792 RVA: 0x0027CAE0 File Offset: 0x0027ACE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelState.Descriptor;
			}
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x0027CAF7 File Offset: 0x0027ACF7
		[DebuggerNonUserCode]
		public ChannelState()
		{
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x0027CB18 File Offset: 0x0027AD18
		[DebuggerNonUserCode]
		public ChannelState(ChannelState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.maxMembers_ = other.maxMembers_;
			this.minMembers_ = other.minMembers_;
			this.attribute_ = other.attribute_.Clone();
			this.invitation_ = other.invitation_.Clone();
			this.reason_ = other.reason_;
			this.privacyLevel_ = other.privacyLevel_;
			this.name_ = other.name_;
			this.channelType_ = other.channelType_;
			this.program_ = other.program_;
			this.subscribeToPresence_ = other.subscribeToPresence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			this._extensions = ExtensionSet.Clone<ChannelState>(other._extensions);
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x0027CBE0 File Offset: 0x0027ADE0
		[DebuggerNonUserCode]
		public ChannelState Clone()
		{
			return new ChannelState(this);
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x0027CBF8 File Offset: 0x0027ADF8
		// (set) Token: 0x0600A345 RID: 41797 RVA: 0x0027CC29 File Offset: 0x0027AE29
		[DebuggerNonUserCode]
		public uint MaxMembers
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint maxMembersDefaultValue;
				if (flag)
				{
					maxMembersDefaultValue = this.maxMembers_;
				}
				else
				{
					maxMembersDefaultValue = ChannelState.MaxMembersDefaultValue;
				}
				return maxMembersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxMembers_ = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x0027CC44 File Offset: 0x0027AE44
		[DebuggerNonUserCode]
		public bool HasMaxMembers
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x0027CC61 File Offset: 0x0027AE61
		[DebuggerNonUserCode]
		public void ClearMaxMembers()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A348 RID: 41800 RVA: 0x0027CC74 File Offset: 0x0027AE74
		// (set) Token: 0x0600A349 RID: 41801 RVA: 0x0027CCA5 File Offset: 0x0027AEA5
		[DebuggerNonUserCode]
		public uint MinMembers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint minMembersDefaultValue;
				if (flag)
				{
					minMembersDefaultValue = this.minMembers_;
				}
				else
				{
					minMembersDefaultValue = ChannelState.MinMembersDefaultValue;
				}
				return minMembersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.minMembers_ = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A34A RID: 41802 RVA: 0x0027CCC0 File Offset: 0x0027AEC0
		[DebuggerNonUserCode]
		public bool HasMinMembers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x0027CCDD File Offset: 0x0027AEDD
		[DebuggerNonUserCode]
		public void ClearMinMembers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A34C RID: 41804 RVA: 0x0027CCF0 File Offset: 0x0027AEF0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A34D RID: 41805 RVA: 0x0027CD08 File Offset: 0x0027AF08
		[DebuggerNonUserCode]
		public RepeatedField<Invitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A34E RID: 41806 RVA: 0x0027CD20 File Offset: 0x0027AF20
		// (set) Token: 0x0600A34F RID: 41807 RVA: 0x0027CD51 File Offset: 0x0027AF51
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = ChannelState.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.reason_ = value;
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A350 RID: 41808 RVA: 0x0027CD6C File Offset: 0x0027AF6C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0027CD89 File Offset: 0x0027AF89
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A352 RID: 41810 RVA: 0x0027CD9C File Offset: 0x0027AF9C
		// (set) Token: 0x0600A353 RID: 41811 RVA: 0x0027CDCD File Offset: 0x0027AFCD
		[DebuggerNonUserCode]
		public ChannelState.Types.PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ChannelState.Types.PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = ChannelState.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x0027CDE8 File Offset: 0x0027AFE8
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x0027CE05 File Offset: 0x0027B005
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A356 RID: 41814 RVA: 0x0027CE18 File Offset: 0x0027B018
		// (set) Token: 0x0600A357 RID: 41815 RVA: 0x0027CE39 File Offset: 0x0027B039
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ChannelState.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A358 RID: 41816 RVA: 0x0027CE50 File Offset: 0x0027B050
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x0027CE6B File Offset: 0x0027B06B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A35A RID: 41818 RVA: 0x0027CE78 File Offset: 0x0027B078
		// (set) Token: 0x0600A35B RID: 41819 RVA: 0x0027CE99 File Offset: 0x0027B099
		[DebuggerNonUserCode]
		public string ChannelType
		{
			get
			{
				return this.channelType_ ?? ChannelState.ChannelTypeDefaultValue;
			}
			set
			{
				this.channelType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A35C RID: 41820 RVA: 0x0027CEB0 File Offset: 0x0027B0B0
		[DebuggerNonUserCode]
		public bool HasChannelType
		{
			get
			{
				return this.channelType_ != null;
			}
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x0027CECB File Offset: 0x0027B0CB
		[DebuggerNonUserCode]
		public void ClearChannelType()
		{
			this.channelType_ = null;
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x0027CED8 File Offset: 0x0027B0D8
		// (set) Token: 0x0600A35F RID: 41823 RVA: 0x0027CF0A File Offset: 0x0027B10A
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ChannelState.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.program_ = value;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A360 RID: 41824 RVA: 0x0027CF24 File Offset: 0x0027B124
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x0027CF42 File Offset: 0x0027B142
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A362 RID: 41826 RVA: 0x0027CF54 File Offset: 0x0027B154
		// (set) Token: 0x0600A363 RID: 41827 RVA: 0x0027CF86 File Offset: 0x0027B186
		[DebuggerNonUserCode]
		public bool SubscribeToPresence
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool subscribeToPresenceDefaultValue;
				if (flag)
				{
					subscribeToPresenceDefaultValue = this.subscribeToPresence_;
				}
				else
				{
					subscribeToPresenceDefaultValue = ChannelState.SubscribeToPresenceDefaultValue;
				}
				return subscribeToPresenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.subscribeToPresence_ = value;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A364 RID: 41828 RVA: 0x0027CFA0 File Offset: 0x0027B1A0
		[DebuggerNonUserCode]
		public bool HasSubscribeToPresence
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x0027CFBE File Offset: 0x0027B1BE
		[DebuggerNonUserCode]
		public void ClearSubscribeToPresence()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x0027CFD0 File Offset: 0x0027B1D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelState);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x0027CFF0 File Offset: 0x0027B1F0
		[DebuggerNonUserCode]
		public bool Equals(ChannelState other)
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
					bool flag4 = this.MaxMembers != other.MaxMembers;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MinMembers != other.MinMembers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.invitation_.Equals(other.invitation_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Reason != other.Reason;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PrivacyLevel != other.PrivacyLevel;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Name != other.Name;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ChannelType != other.ChannelType;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Program != other.Program;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SubscribeToPresence != other.SubscribeToPresence;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this._extensions, other._extensions);
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x0027D17C File Offset: 0x0027B37C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMaxMembers = this.HasMaxMembers;
			if (hasMaxMembers)
			{
				num ^= this.MaxMembers.GetHashCode();
			}
			bool hasMinMembers = this.HasMinMembers;
			if (hasMinMembers)
			{
				num ^= this.MinMembers.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			num ^= this.invitation_.GetHashCode();
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasSubscribeToPresence = this.HasSubscribeToPresence;
			if (hasSubscribeToPresence)
			{
				num ^= this.SubscribeToPresence.GetHashCode();
			}
			bool flag = this._extensions != null;
			if (flag)
			{
				num ^= this._extensions.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x0027D2D4 File Offset: 0x0027B4D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x0027D2EC File Offset: 0x0027B4EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x0027D2F8 File Offset: 0x0027B4F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMaxMembers = this.HasMaxMembers;
			if (hasMaxMembers)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MaxMembers);
			}
			bool hasMinMembers = this.HasMinMembers;
			if (hasMinMembers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MinMembers);
			}
			this.attribute_.WriteTo(ref output, ChannelState._repeated_attribute_codec);
			this.invitation_.WriteTo(ref output, ChannelState._repeated_invitation_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Reason);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Name);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				output.WriteRawTag(82);
				output.WriteString(this.ChannelType);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(93);
				output.WriteFixed32(this.Program);
			}
			bool hasSubscribeToPresence = this.HasSubscribeToPresence;
			if (hasSubscribeToPresence)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.SubscribeToPresence);
			}
			bool flag = this._extensions != null;
			if (flag)
			{
				this._extensions.WriteTo(ref output);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x0027D480 File Offset: 0x0027B680
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMaxMembers = this.HasMaxMembers;
			if (hasMaxMembers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxMembers);
			}
			bool hasMinMembers = this.HasMinMembers;
			if (hasMinMembers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinMembers);
			}
			num += this.attribute_.CalculateSize(ChannelState._repeated_attribute_codec);
			num += this.invitation_.CalculateSize(ChannelState._repeated_invitation_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasSubscribeToPresence = this.HasSubscribeToPresence;
			if (hasSubscribeToPresence)
			{
				num += 2;
			}
			bool flag = this._extensions != null;
			if (flag)
			{
				num += this._extensions.CalculateSize();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0027D5D0 File Offset: 0x0027B7D0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMaxMembers = other.HasMaxMembers;
				if (hasMaxMembers)
				{
					this.MaxMembers = other.MaxMembers;
				}
				bool hasMinMembers = other.HasMinMembers;
				if (hasMinMembers)
				{
					this.MinMembers = other.MinMembers;
				}
				this.attribute_.Add(other.attribute_);
				this.invitation_.Add(other.invitation_);
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasChannelType = other.HasChannelType;
				if (hasChannelType)
				{
					this.ChannelType = other.ChannelType;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasSubscribeToPresence = other.HasSubscribeToPresence;
				if (hasSubscribeToPresence)
				{
					this.SubscribeToPresence = other.SubscribeToPresence;
				}
				ExtensionSet.MergeFrom<ChannelState>(ref this._extensions, other._extensions);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x0027D70B File Offset: 0x0027B90B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x0027D718 File Offset: 0x0027B918
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_007D;
							}
							this.MinMembers = input.ReadUInt32();
						}
						else
						{
							this.MaxMembers = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 48U)
							{
								goto IL_007D;
							}
							this.Reason = input.ReadUInt32();
						}
						else
						{
							this.invitation_.AddEntriesFrom(ref input, ChannelState._repeated_invitation_codec);
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, ChannelState._repeated_attribute_codec);
					}
				}
				else if (num3 <= 66U)
				{
					if (num3 != 56U)
					{
						if (num3 != 66U)
						{
							goto IL_007D;
						}
						this.Name = input.ReadString();
					}
					else
					{
						this.PrivacyLevel = (ChannelState.Types.PrivacyLevel)input.ReadEnum();
					}
				}
				else if (num3 != 82U)
				{
					if (num3 != 93U)
					{
						if (num3 != 104U)
						{
							goto IL_007D;
						}
						this.SubscribeToPresence = input.ReadBool();
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.ChannelType = input.ReadString();
				}
				continue;
				IL_007D:
				bool flag = !ExtensionSet.TryMergeFieldFrom<ChannelState>(ref this._extensions, ref input);
				if (flag)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
			}
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x0027D894 File Offset: 0x0027BA94
		public TValue GetExtension<TValue>(Extension<ChannelState, TValue> extension)
		{
			return ExtensionSet.Get<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x0027D8B4 File Offset: 0x0027BAB4
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ChannelState, TValue> extension)
		{
			return ExtensionSet.Get<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x0027D8D4 File Offset: 0x0027BAD4
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ChannelState, TValue> extension)
		{
			return ExtensionSet.GetOrInitialize<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x0027D8F2 File Offset: 0x0027BAF2
		public void SetExtension<TValue>(Extension<ChannelState, TValue> extension, TValue value)
		{
			ExtensionSet.Set<ChannelState, TValue>(ref this._extensions, extension, value);
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x0027D904 File Offset: 0x0027BB04
		public bool HasExtension<TValue>(Extension<ChannelState, TValue> extension)
		{
			return ExtensionSet.Has<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x0027D922 File Offset: 0x0027BB22
		public void ClearExtension<TValue>(Extension<ChannelState, TValue> extension)
		{
			ExtensionSet.Clear<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x0027D932 File Offset: 0x0027BB32
		public void ClearExtension<TValue>(RepeatedExtension<ChannelState, TValue> extension)
		{
			ExtensionSet.Clear<ChannelState, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0400499B RID: 18843
		private static readonly MessageParser<ChannelState> _parser = new MessageParser<ChannelState>(() => new ChannelState());

		// Token: 0x0400499C RID: 18844
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400499D RID: 18845
		private ExtensionSet<ChannelState> _extensions;

		// Token: 0x0400499E RID: 18846
		private int _hasBits0;

		// Token: 0x0400499F RID: 18847
		public const int MaxMembersFieldNumber = 1;

		// Token: 0x040049A0 RID: 18848
		private static readonly uint MaxMembersDefaultValue = 0U;

		// Token: 0x040049A1 RID: 18849
		private uint maxMembers_;

		// Token: 0x040049A2 RID: 18850
		public const int MinMembersFieldNumber = 2;

		// Token: 0x040049A3 RID: 18851
		private static readonly uint MinMembersDefaultValue = 0U;

		// Token: 0x040049A4 RID: 18852
		private uint minMembers_;

		// Token: 0x040049A5 RID: 18853
		public const int AttributeFieldNumber = 3;

		// Token: 0x040049A6 RID: 18854
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x040049A7 RID: 18855
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040049A8 RID: 18856
		public const int InvitationFieldNumber = 4;

		// Token: 0x040049A9 RID: 18857
		private static readonly FieldCodec<Invitation> _repeated_invitation_codec = FieldCodec.ForMessage<Invitation>(34U, Bgs.Protocol.Invitation.Parser);

		// Token: 0x040049AA RID: 18858
		private readonly RepeatedField<Invitation> invitation_ = new RepeatedField<Invitation>();

		// Token: 0x040049AB RID: 18859
		public const int ReasonFieldNumber = 6;

		// Token: 0x040049AC RID: 18860
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x040049AD RID: 18861
		private uint reason_;

		// Token: 0x040049AE RID: 18862
		public const int PrivacyLevelFieldNumber = 7;

		// Token: 0x040049AF RID: 18863
		private static readonly ChannelState.Types.PrivacyLevel PrivacyLevelDefaultValue = ChannelState.Types.PrivacyLevel.Open;

		// Token: 0x040049B0 RID: 18864
		private ChannelState.Types.PrivacyLevel privacyLevel_;

		// Token: 0x040049B1 RID: 18865
		public const int NameFieldNumber = 8;

		// Token: 0x040049B2 RID: 18866
		private static readonly string NameDefaultValue = "";

		// Token: 0x040049B3 RID: 18867
		private string name_;

		// Token: 0x040049B4 RID: 18868
		public const int ChannelTypeFieldNumber = 10;

		// Token: 0x040049B5 RID: 18869
		private static readonly string ChannelTypeDefaultValue = Encoding.UTF8.GetString(Convert.FromBase64String("ZGVmYXVsdA=="), 0, 7);

		// Token: 0x040049B6 RID: 18870
		private string channelType_;

		// Token: 0x040049B7 RID: 18871
		public const int ProgramFieldNumber = 11;

		// Token: 0x040049B8 RID: 18872
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x040049B9 RID: 18873
		private uint program_;

		// Token: 0x040049BA RID: 18874
		public const int SubscribeToPresenceFieldNumber = 13;

		// Token: 0x040049BB RID: 18875
		private static readonly bool SubscribeToPresenceDefaultValue = true;

		// Token: 0x040049BC RID: 18876
		private bool subscribeToPresence_;

		// Token: 0x020011F8 RID: 4600
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001499 RID: 5273
			public enum PrivacyLevel
			{
				// Token: 0x0400A502 RID: 42242
				[OriginalName("PRIVACY_LEVEL_OPEN")]
				Open = 1,
				// Token: 0x0400A503 RID: 42243
				[OriginalName("PRIVACY_LEVEL_OPEN_INVITATION_AND_FRIEND")]
				OpenInvitationAndFriend,
				// Token: 0x0400A504 RID: 42244
				[OriginalName("PRIVACY_LEVEL_OPEN_INVITATION")]
				OpenInvitation,
				// Token: 0x0400A505 RID: 42245
				[OriginalName("PRIVACY_LEVEL_CLOSED")]
				Closed
			}
		}
	}
}
