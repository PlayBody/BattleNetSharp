using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000241 RID: 577
	public sealed class InviteToPartyResponse : IMessage<InviteToPartyResponse>, IMessage, IEquatable<InviteToPartyResponse>, IDeepCloneable<InviteToPartyResponse>, IBufferMessage
	{
		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x000F516C File Offset: 0x000F336C
		[DebuggerNonUserCode]
		public static MessageParser<InviteToPartyResponse> Parser
		{
			get
			{
				return InviteToPartyResponse._parser;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x000F5184 File Offset: 0x000F3384
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[49];
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000F51A8 File Offset: 0x000F33A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteToPartyResponse.Descriptor;
			}
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x000F51BF File Offset: 0x000F33BF
		[DebuggerNonUserCode]
		public InviteToPartyResponse()
		{
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x000F51C9 File Offset: 0x000F33C9
		[DebuggerNonUserCode]
		public InviteToPartyResponse(InviteToPartyResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviteId_ = other.inviteId_;
			this.partyId_ = other.partyId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x000F5208 File Offset: 0x000F3408
		[DebuggerNonUserCode]
		public InviteToPartyResponse Clone()
		{
			return new InviteToPartyResponse(this);
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x000F5220 File Offset: 0x000F3420
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x000F5251 File Offset: 0x000F3451
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = InviteToPartyResponse.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x000F526C File Offset: 0x000F346C
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x000F5289 File Offset: 0x000F3489
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x000F529C File Offset: 0x000F349C
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x000F52BD File Offset: 0x000F34BD
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? InviteToPartyResponse.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x000F52D4 File Offset: 0x000F34D4
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x000F52EF File Offset: 0x000F34EF
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x000F52FC File Offset: 0x000F34FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteToPartyResponse);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x000F531C File Offset: 0x000F351C
		[DebuggerNonUserCode]
		public bool Equals(InviteToPartyResponse other)
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
					bool flag4 = this.InviteId != other.InviteId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PartyId != other.PartyId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x000F5390 File Offset: 0x000F3590
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x000F53FC File Offset: 0x000F35FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x000F5414 File Offset: 0x000F3614
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x000F5420 File Offset: 0x000F3620
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.InviteId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PartyId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x000F5490 File Offset: 0x000F3690
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x000F54FC File Offset: 0x000F36FC
		[DebuggerNonUserCode]
		public void MergeFrom(InviteToPartyResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x000F555E File Offset: 0x000F375E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x000F556C File Offset: 0x000F376C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PartyId = input.ReadString();
					}
				}
				else
				{
					this.InviteId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001C81 RID: 7297
		private static readonly MessageParser<InviteToPartyResponse> _parser = new MessageParser<InviteToPartyResponse>(() => new InviteToPartyResponse());

		// Token: 0x04001C82 RID: 7298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C83 RID: 7299
		private int _hasBits0;

		// Token: 0x04001C84 RID: 7300
		public const int InviteIdFieldNumber = 1;

		// Token: 0x04001C85 RID: 7301
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001C86 RID: 7302
		private ulong inviteId_;

		// Token: 0x04001C87 RID: 7303
		public const int PartyIdFieldNumber = 2;

		// Token: 0x04001C88 RID: 7304
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001C89 RID: 7305
		private string partyId_;
	}
}
