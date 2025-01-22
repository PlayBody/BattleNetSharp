using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041B RID: 1051
	public sealed class ReceivedInvitation : IExtendableMessage<ReceivedInvitation>, IMessage<ReceivedInvitation>, IMessage, IEquatable<ReceivedInvitation>, IDeepCloneable<ReceivedInvitation>, IBufferMessage
	{
		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x00190FC4 File Offset: 0x0018F1C4
		private ExtensionSet<ReceivedInvitation> _Extensions
		{
			get
			{
				return this._extensions;
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x00190FDC File Offset: 0x0018F1DC
		[DebuggerNonUserCode]
		public static MessageParser<ReceivedInvitation> Parser
		{
			get
			{
				return ReceivedInvitation._parser;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x00190FF4 File Offset: 0x0018F1F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00191018 File Offset: 0x0018F218
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedInvitation.Descriptor;
			}
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x0019102F File Offset: 0x0018F22F
		[DebuggerNonUserCode]
		public ReceivedInvitation()
		{
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x0019103C File Offset: 0x0018F23C
		[DebuggerNonUserCode]
		public ReceivedInvitation(ReceivedInvitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.inviterIdentity_ = ((other.inviterIdentity_ != null) ? other.inviterIdentity_.Clone() : null);
			this.inviteeIdentity_ = ((other.inviteeIdentity_ != null) ? other.inviteeIdentity_.Clone() : null);
			this.inviterName_ = other.inviterName_;
			this.inviteeName_ = other.inviteeName_;
			this.creationTime_ = other.creationTime_;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			this._extensions = ExtensionSet.Clone<ReceivedInvitation>(other._extensions);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x001910F4 File Offset: 0x0018F2F4
		[DebuggerNonUserCode]
		public ReceivedInvitation Clone()
		{
			return new ReceivedInvitation(this);
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x0019110C File Offset: 0x0018F30C
		// (set) Token: 0x06006791 RID: 26513 RVA: 0x0019113D File Offset: 0x0018F33D
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
					idDefaultValue = ReceivedInvitation.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x00191158 File Offset: 0x0018F358
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00191175 File Offset: 0x0018F375
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006794 RID: 26516 RVA: 0x00191188 File Offset: 0x0018F388
		// (set) Token: 0x06006795 RID: 26517 RVA: 0x001911A0 File Offset: 0x0018F3A0
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

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x001911AC File Offset: 0x0018F3AC
		// (set) Token: 0x06006797 RID: 26519 RVA: 0x001911C4 File Offset: 0x0018F3C4
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

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x001911D0 File Offset: 0x0018F3D0
		// (set) Token: 0x06006799 RID: 26521 RVA: 0x001911F1 File Offset: 0x0018F3F1
		[DebuggerNonUserCode]
		public string InviterName
		{
			get
			{
				return this.inviterName_ ?? ReceivedInvitation.InviterNameDefaultValue;
			}
			set
			{
				this.inviterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00191208 File Offset: 0x0018F408
		[DebuggerNonUserCode]
		public bool HasInviterName
		{
			get
			{
				return this.inviterName_ != null;
			}
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x00191223 File Offset: 0x0018F423
		[DebuggerNonUserCode]
		public void ClearInviterName()
		{
			this.inviterName_ = null;
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600679C RID: 26524 RVA: 0x00191230 File Offset: 0x0018F430
		// (set) Token: 0x0600679D RID: 26525 RVA: 0x00191251 File Offset: 0x0018F451
		[DebuggerNonUserCode]
		public string InviteeName
		{
			get
			{
				return this.inviteeName_ ?? ReceivedInvitation.InviteeNameDefaultValue;
			}
			set
			{
				this.inviteeName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600679E RID: 26526 RVA: 0x00191268 File Offset: 0x0018F468
		[DebuggerNonUserCode]
		public bool HasInviteeName
		{
			get
			{
				return this.inviteeName_ != null;
			}
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x00191283 File Offset: 0x0018F483
		[DebuggerNonUserCode]
		public void ClearInviteeName()
		{
			this.inviteeName_ = null;
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x00191290 File Offset: 0x0018F490
		// (set) Token: 0x060067A1 RID: 26529 RVA: 0x001912C1 File Offset: 0x0018F4C1
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
					creationTimeDefaultValue = ReceivedInvitation.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x001912DC File Offset: 0x0018F4DC
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x001912F9 File Offset: 0x0018F4F9
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x0019130C File Offset: 0x0018F50C
		// (set) Token: 0x060067A5 RID: 26533 RVA: 0x0019133D File Offset: 0x0018F53D
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ReceivedInvitation.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.program_ = value;
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x00191358 File Offset: 0x0018F558
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x00191375 File Offset: 0x0018F575
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x00191388 File Offset: 0x0018F588
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedInvitation);
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x001913A8 File Offset: 0x0018F5A8
		[DebuggerNonUserCode]
		public bool Equals(ReceivedInvitation other)
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
										bool flag9 = this.CreationTime != other.CreationTime;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Program != other.Program;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this._extensions, other._extensions);
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060067AA RID: 26538 RVA: 0x001914D8 File Offset: 0x0018F6D8
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
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
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

		// Token: 0x060067AB RID: 26539 RVA: 0x001915F0 File Offset: 0x0018F7F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x00191608 File Offset: 0x0018F808
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x00191614 File Offset: 0x0018F814
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
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(77);
				output.WriteFixed32(this.Program);
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

		// Token: 0x060067AE RID: 26542 RVA: 0x00191758 File Offset: 0x0018F958
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
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
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

		// Token: 0x060067AF RID: 26543 RVA: 0x00191868 File Offset: 0x0018FA68
		[DebuggerNonUserCode]
		public void MergeFrom(ReceivedInvitation other)
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
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				ExtensionSet.MergeFrom<ReceivedInvitation>(ref this._extensions, other._extensions);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x001919AE File Offset: 0x0018FBAE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x001919BC File Offset: 0x0018FBBC
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
					if (num3 != 9U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							bool flag = this.inviteeIdentity_ == null;
							if (flag)
							{
								this.InviteeIdentity = new Identity();
							}
							input.ReadMessage(this.InviteeIdentity);
						}
						else
						{
							bool flag2 = this.inviterIdentity_ == null;
							if (flag2)
							{
								this.InviterIdentity = new Identity();
							}
							input.ReadMessage(this.InviterIdentity);
						}
					}
					else
					{
						this.Id = input.ReadFixed64();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0055;
						}
						this.InviteeName = input.ReadString();
					}
					else
					{
						this.InviterName = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 77U)
					{
						goto IL_0055;
					}
					this.Program = input.ReadFixed32();
				}
				else
				{
					this.CreationTime = input.ReadUInt64();
				}
				continue;
				IL_0055:
				bool flag3 = !ExtensionSet.TryMergeFieldFrom<ReceivedInvitation>(ref this._extensions, ref input);
				if (flag3)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00191B0C File Offset: 0x0018FD0C
		public TValue GetExtension<TValue>(Extension<ReceivedInvitation, TValue> extension)
		{
			return ExtensionSet.Get<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x00191B2C File Offset: 0x0018FD2C
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ReceivedInvitation, TValue> extension)
		{
			return ExtensionSet.Get<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x00191B4C File Offset: 0x0018FD4C
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ReceivedInvitation, TValue> extension)
		{
			return ExtensionSet.GetOrInitialize<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x00191B6A File Offset: 0x0018FD6A
		public void SetExtension<TValue>(Extension<ReceivedInvitation, TValue> extension, TValue value)
		{
			ExtensionSet.Set<ReceivedInvitation, TValue>(ref this._extensions, extension, value);
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x00191B7C File Offset: 0x0018FD7C
		public bool HasExtension<TValue>(Extension<ReceivedInvitation, TValue> extension)
		{
			return ExtensionSet.Has<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x00191B9A File Offset: 0x0018FD9A
		public void ClearExtension<TValue>(Extension<ReceivedInvitation, TValue> extension)
		{
			ExtensionSet.Clear<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x00191BAA File Offset: 0x0018FDAA
		public void ClearExtension<TValue>(RepeatedExtension<ReceivedInvitation, TValue> extension)
		{
			ExtensionSet.Clear<ReceivedInvitation, TValue>(ref this._extensions, extension);
		}

		// Token: 0x04002F1A RID: 12058
		private static readonly MessageParser<ReceivedInvitation> _parser = new MessageParser<ReceivedInvitation>(() => new ReceivedInvitation());

		// Token: 0x04002F1B RID: 12059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F1C RID: 12060
		private ExtensionSet<ReceivedInvitation> _extensions;

		// Token: 0x04002F1D RID: 12061
		private int _hasBits0;

		// Token: 0x04002F1E RID: 12062
		public const int IdFieldNumber = 1;

		// Token: 0x04002F1F RID: 12063
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04002F20 RID: 12064
		private ulong id_;

		// Token: 0x04002F21 RID: 12065
		public const int InviterIdentityFieldNumber = 2;

		// Token: 0x04002F22 RID: 12066
		private Identity inviterIdentity_;

		// Token: 0x04002F23 RID: 12067
		public const int InviteeIdentityFieldNumber = 3;

		// Token: 0x04002F24 RID: 12068
		private Identity inviteeIdentity_;

		// Token: 0x04002F25 RID: 12069
		public const int InviterNameFieldNumber = 4;

		// Token: 0x04002F26 RID: 12070
		private static readonly string InviterNameDefaultValue = "";

		// Token: 0x04002F27 RID: 12071
		private string inviterName_;

		// Token: 0x04002F28 RID: 12072
		public const int InviteeNameFieldNumber = 5;

		// Token: 0x04002F29 RID: 12073
		private static readonly string InviteeNameDefaultValue = "";

		// Token: 0x04002F2A RID: 12074
		private string inviteeName_;

		// Token: 0x04002F2B RID: 12075
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x04002F2C RID: 12076
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04002F2D RID: 12077
		private ulong creationTime_;

		// Token: 0x04002F2E RID: 12078
		public const int ProgramFieldNumber = 9;

		// Token: 0x04002F2F RID: 12079
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002F30 RID: 12080
		private uint program_;
	}
}
