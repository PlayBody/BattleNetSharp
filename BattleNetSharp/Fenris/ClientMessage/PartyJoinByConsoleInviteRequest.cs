using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024E RID: 590
	public sealed class PartyJoinByConsoleInviteRequest : IMessage<PartyJoinByConsoleInviteRequest>, IMessage, IEquatable<PartyJoinByConsoleInviteRequest>, IDeepCloneable<PartyJoinByConsoleInviteRequest>, IBufferMessage
	{
		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x000F8574 File Offset: 0x000F6774
		[DebuggerNonUserCode]
		public static MessageParser<PartyJoinByConsoleInviteRequest> Parser
		{
			get
			{
				return PartyJoinByConsoleInviteRequest._parser;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x000F858C File Offset: 0x000F678C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[62];
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x000F85B0 File Offset: 0x000F67B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyJoinByConsoleInviteRequest.Descriptor;
			}
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x000F85C7 File Offset: 0x000F67C7
		[DebuggerNonUserCode]
		public PartyJoinByConsoleInviteRequest()
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000F85D4 File Offset: 0x000F67D4
		[DebuggerNonUserCode]
		public PartyJoinByConsoleInviteRequest(PartyJoinByConsoleInviteRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.inviterPlatformAccountId_ = other.inviterPlatformAccountId_;
			this.isCrossplayEnabled_ = other.isCrossplayEnabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x000F862C File Offset: 0x000F682C
		[DebuggerNonUserCode]
		public PartyJoinByConsoleInviteRequest Clone()
		{
			return new PartyJoinByConsoleInviteRequest(this);
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x000F8644 File Offset: 0x000F6844
		// (set) Token: 0x06003F6E RID: 16238 RVA: 0x000F8665 File Offset: 0x000F6865
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyJoinByConsoleInviteRequest.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x000F867C File Offset: 0x000F687C
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x000F8697 File Offset: 0x000F6897
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x000F86A4 File Offset: 0x000F68A4
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x000F86D5 File Offset: 0x000F68D5
		[DebuggerNonUserCode]
		public ulong InviterPlatformAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviterPlatformAccountIdDefaultValue;
				if (flag)
				{
					inviterPlatformAccountIdDefaultValue = this.inviterPlatformAccountId_;
				}
				else
				{
					inviterPlatformAccountIdDefaultValue = PartyJoinByConsoleInviteRequest.InviterPlatformAccountIdDefaultValue;
				}
				return inviterPlatformAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviterPlatformAccountId_ = value;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x000F86F0 File Offset: 0x000F68F0
		[DebuggerNonUserCode]
		public bool HasInviterPlatformAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x000F870D File Offset: 0x000F690D
		[DebuggerNonUserCode]
		public void ClearInviterPlatformAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x000F8720 File Offset: 0x000F6920
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x000F8751 File Offset: 0x000F6951
		[DebuggerNonUserCode]
		public bool IsCrossplayEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isCrossplayEnabledDefaultValue;
				if (flag)
				{
					isCrossplayEnabledDefaultValue = this.isCrossplayEnabled_;
				}
				else
				{
					isCrossplayEnabledDefaultValue = PartyJoinByConsoleInviteRequest.IsCrossplayEnabledDefaultValue;
				}
				return isCrossplayEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isCrossplayEnabled_ = value;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x000F876C File Offset: 0x000F696C
		[DebuggerNonUserCode]
		public bool HasIsCrossplayEnabled
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x000F8789 File Offset: 0x000F6989
		[DebuggerNonUserCode]
		public void ClearIsCrossplayEnabled()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x000F879C File Offset: 0x000F699C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyJoinByConsoleInviteRequest);
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x000F87BC File Offset: 0x000F69BC
		[DebuggerNonUserCode]
		public bool Equals(PartyJoinByConsoleInviteRequest other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviterPlatformAccountId != other.InviterPlatformAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsCrossplayEnabled != other.IsCrossplayEnabled;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x000F8848 File Offset: 0x000F6A48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasInviterPlatformAccountId = this.HasInviterPlatformAccountId;
			if (hasInviterPlatformAccountId)
			{
				num ^= this.InviterPlatformAccountId.GetHashCode();
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				num ^= this.IsCrossplayEnabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000F88D0 File Offset: 0x000F6AD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x000F88E8 File Offset: 0x000F6AE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x000F88F4 File Offset: 0x000F6AF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasInviterPlatformAccountId = this.HasInviterPlatformAccountId;
			if (hasInviterPlatformAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviterPlatformAccountId);
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsCrossplayEnabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x000F8984 File Offset: 0x000F6B84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasInviterPlatformAccountId = this.HasInviterPlatformAccountId;
			if (hasInviterPlatformAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviterPlatformAccountId);
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x000F8A04 File Offset: 0x000F6C04
		[DebuggerNonUserCode]
		public void MergeFrom(PartyJoinByConsoleInviteRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasInviterPlatformAccountId = other.HasInviterPlatformAccountId;
				if (hasInviterPlatformAccountId)
				{
					this.InviterPlatformAccountId = other.InviterPlatformAccountId;
				}
				bool hasIsCrossplayEnabled = other.HasIsCrossplayEnabled;
				if (hasIsCrossplayEnabled)
				{
					this.IsCrossplayEnabled = other.IsCrossplayEnabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x000F8A7F File Offset: 0x000F6C7F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x000F8A8C File Offset: 0x000F6C8C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsCrossplayEnabled = input.ReadBool();
						}
					}
					else
					{
						this.InviterPlatformAccountId = input.ReadUInt64();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001CDF RID: 7391
		private static readonly MessageParser<PartyJoinByConsoleInviteRequest> _parser = new MessageParser<PartyJoinByConsoleInviteRequest>(() => new PartyJoinByConsoleInviteRequest());

		// Token: 0x04001CE0 RID: 7392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CE1 RID: 7393
		private int _hasBits0;

		// Token: 0x04001CE2 RID: 7394
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001CE3 RID: 7395
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001CE4 RID: 7396
		private string partyId_;

		// Token: 0x04001CE5 RID: 7397
		public const int InviterPlatformAccountIdFieldNumber = 2;

		// Token: 0x04001CE6 RID: 7398
		private static readonly ulong InviterPlatformAccountIdDefaultValue = 0UL;

		// Token: 0x04001CE7 RID: 7399
		private ulong inviterPlatformAccountId_;

		// Token: 0x04001CE8 RID: 7400
		public const int IsCrossplayEnabledFieldNumber = 3;

		// Token: 0x04001CE9 RID: 7401
		private static readonly bool IsCrossplayEnabledDefaultValue = false;

		// Token: 0x04001CEA RID: 7402
		private bool isCrossplayEnabled_;
	}
}
