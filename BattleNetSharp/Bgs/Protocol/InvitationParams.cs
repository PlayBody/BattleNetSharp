using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000382 RID: 898
	public sealed class InvitationParams : IExtendableMessage<InvitationParams>, IMessage<InvitationParams>, IMessage, IEquatable<InvitationParams>, IDeepCloneable<InvitationParams>, IBufferMessage
	{
		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x00161984 File Offset: 0x0015FB84
		private ExtensionSet<InvitationParams> _Extensions
		{
			get
			{
				return this._extensions;
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06005B67 RID: 23399 RVA: 0x0016199C File Offset: 0x0015FB9C
		[DebuggerNonUserCode]
		public static MessageParser<InvitationParams> Parser
		{
			get
			{
				return InvitationParams._parser;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001619B4 File Offset: 0x0015FBB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06005B69 RID: 23401 RVA: 0x001619D8 File Offset: 0x0015FBD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationParams.Descriptor;
			}
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x001619EF File Offset: 0x0015FBEF
		[DebuggerNonUserCode]
		public InvitationParams()
		{
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x001619FC File Offset: 0x0015FBFC
		[DebuggerNonUserCode]
		public InvitationParams(InvitationParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitationMessage_ = other.invitationMessage_;
			this.expirationTime_ = other.expirationTime_;
			this.friendParams_ = ((other.friendParams_ != null) ? other.friendParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			this._extensions = ExtensionSet.Clone<InvitationParams>(other._extensions);
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00161A74 File Offset: 0x0015FC74
		[DebuggerNonUserCode]
		public InvitationParams Clone()
		{
			return new InvitationParams(this);
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06005B6D RID: 23405 RVA: 0x00161A8C File Offset: 0x0015FC8C
		// (set) Token: 0x06005B6E RID: 23406 RVA: 0x00161AAD File Offset: 0x0015FCAD
		[Obsolete]
		[DebuggerNonUserCode]
		public string InvitationMessage
		{
			get
			{
				return this.invitationMessage_ ?? InvitationParams.InvitationMessageDefaultValue;
			}
			set
			{
				this.invitationMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06005B6F RID: 23407 RVA: 0x00161AC4 File Offset: 0x0015FCC4
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasInvitationMessage
		{
			get
			{
				return this.invitationMessage_ != null;
			}
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00161ADF File Offset: 0x0015FCDF
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearInvitationMessage()
		{
			this.invitationMessage_ = null;
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06005B71 RID: 23409 RVA: 0x00161AEC File Offset: 0x0015FCEC
		// (set) Token: 0x06005B72 RID: 23410 RVA: 0x00161B1D File Offset: 0x0015FD1D
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = InvitationParams.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x00161B38 File Offset: 0x0015FD38
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x00161B55 File Offset: 0x0015FD55
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x00161B68 File Offset: 0x0015FD68
		// (set) Token: 0x06005B76 RID: 23414 RVA: 0x00161B80 File Offset: 0x0015FD80
		[DebuggerNonUserCode]
		public test FriendParams
		{
			get
			{
				return this.friendParams_;
			}
			set
			{
				this.friendParams_ = value;
			}
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00161B8C File Offset: 0x0015FD8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationParams);
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00161BAC File Offset: 0x0015FDAC
		[DebuggerNonUserCode]
		public bool Equals(InvitationParams other)
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
					bool flag4 = this.InvitationMessage != other.InvitationMessage;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ExpirationTime != other.ExpirationTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.FriendParams, other.FriendParams);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this._extensions, other._extensions);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00161C60 File Offset: 0x0015FE60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				num ^= this.InvitationMessage.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool flag = this.friendParams_ != null;
			if (flag)
			{
				num ^= this.FriendParams.GetHashCode();
			}
			bool flag2 = this._extensions != null;
			if (flag2)
			{
				num ^= this._extensions.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00161D08 File Offset: 0x0015FF08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00161D20 File Offset: 0x0015FF20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00161D2C File Offset: 0x0015FF2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InvitationMessage);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag = this.friendParams_ != null;
			if (flag)
			{
				output.WriteRawTag(186, 6);
				output.WriteMessage(this.FriendParams);
			}
			bool flag2 = this._extensions != null;
			if (flag2)
			{
				this._extensions.WriteTo(ref output);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00161DE4 File Offset: 0x0015FFE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitationMessage = this.HasInvitationMessage;
			if (hasInvitationMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InvitationMessage);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool flag = this.friendParams_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FriendParams);
			}
			bool flag2 = this._extensions != null;
			if (flag2)
			{
				num += this._extensions.CalculateSize();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00161E90 File Offset: 0x00160090
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitationMessage = other.HasInvitationMessage;
				if (hasInvitationMessage)
				{
					this.InvitationMessage = other.InvitationMessage;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				bool flag2 = other.friendParams_ != null;
				if (flag2)
				{
					bool flag3 = this.friendParams_ == null;
					if (flag3)
					{
						this.FriendParams = new test();
					}
					this.FriendParams.MergeFrom(other.FriendParams);
				}
				ExtensionSet.MergeFrom<InvitationParams>(ref this._extensions, other._extensions);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00161F45 File Offset: 0x00160145
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00161F50 File Offset: 0x00160150
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
						if (num3 != 826U)
						{
							bool flag = !ExtensionSet.TryMergeFieldFrom<InvitationParams>(ref this._extensions, ref input);
							if (flag)
							{
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
						}
						else
						{
							bool flag2 = this.friendParams_ == null;
							if (flag2)
							{
								this.FriendParams = new test();
							}
							input.ReadMessage(this.FriendParams);
						}
					}
					else
					{
						this.ExpirationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.InvitationMessage = input.ReadString();
				}
			}
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x0016200C File Offset: 0x0016020C
		public TValue GetExtension<TValue>(Extension<InvitationParams, TValue> extension)
		{
			return ExtensionSet.Get<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x0016202C File Offset: 0x0016022C
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<InvitationParams, TValue> extension)
		{
			return ExtensionSet.Get<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x0016204C File Offset: 0x0016024C
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<InvitationParams, TValue> extension)
		{
			return ExtensionSet.GetOrInitialize<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x0016206A File Offset: 0x0016026A
		public void SetExtension<TValue>(Extension<InvitationParams, TValue> extension, TValue value)
		{
			ExtensionSet.Set<InvitationParams, TValue>(ref this._extensions, extension, value);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x0016207C File Offset: 0x0016027C
		public bool HasExtension<TValue>(Extension<InvitationParams, TValue> extension)
		{
			return ExtensionSet.Has<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x0016209A File Offset: 0x0016029A
		public void ClearExtension<TValue>(Extension<InvitationParams, TValue> extension)
		{
			ExtensionSet.Clear<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x001620AA File Offset: 0x001602AA
		public void ClearExtension<TValue>(RepeatedExtension<InvitationParams, TValue> extension)
		{
			ExtensionSet.Clear<InvitationParams, TValue>(ref this._extensions, extension);
		}

		// Token: 0x040029B8 RID: 10680
		private static readonly MessageParser<InvitationParams> _parser = new MessageParser<InvitationParams>(() => new InvitationParams());

		// Token: 0x040029B9 RID: 10681
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029BA RID: 10682
		private ExtensionSet<InvitationParams> _extensions;

		// Token: 0x040029BB RID: 10683
		private int _hasBits0;

		// Token: 0x040029BC RID: 10684
		public const int InvitationMessageFieldNumber = 1;

		// Token: 0x040029BD RID: 10685
		private static readonly string InvitationMessageDefaultValue = "";

		// Token: 0x040029BE RID: 10686
		private string invitationMessage_;

		// Token: 0x040029BF RID: 10687
		public const int ExpirationTimeFieldNumber = 2;

		// Token: 0x040029C0 RID: 10688
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x040029C1 RID: 10689
		private ulong expirationTime_;

		// Token: 0x040029C2 RID: 10690
		public const int FriendParamsFieldNumber = 103;

		// Token: 0x040029C3 RID: 10691
		private test friendParams_;
	}
}
