using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000240 RID: 576
	public sealed class InviteToPartyRequest : IMessage<InviteToPartyRequest>, IMessage, IEquatable<InviteToPartyRequest>, IDeepCloneable<InviteToPartyRequest>, IBufferMessage
	{
		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x000F4DF8 File Offset: 0x000F2FF8
		[DebuggerNonUserCode]
		public static MessageParser<InviteToPartyRequest> Parser
		{
			get
			{
				return InviteToPartyRequest._parser;
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x000F4E10 File Offset: 0x000F3010
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[48];
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x000F4E34 File Offset: 0x000F3034
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteToPartyRequest.Descriptor;
			}
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x000F4E4B File Offset: 0x000F304B
		[DebuggerNonUserCode]
		public InviteToPartyRequest()
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x000F4E55 File Offset: 0x000F3055
		[DebuggerNonUserCode]
		public InviteToPartyRequest(InviteToPartyRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviteeGameAccountId_ = other.inviteeGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x000F4E88 File Offset: 0x000F3088
		[DebuggerNonUserCode]
		public InviteToPartyRequest Clone()
		{
			return new InviteToPartyRequest(this);
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x000F4EA0 File Offset: 0x000F30A0
		// (set) Token: 0x06003E30 RID: 15920 RVA: 0x000F4ED1 File Offset: 0x000F30D1
		[DebuggerNonUserCode]
		public uint InviteeGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint inviteeGameAccountIdDefaultValue;
				if (flag)
				{
					inviteeGameAccountIdDefaultValue = this.inviteeGameAccountId_;
				}
				else
				{
					inviteeGameAccountIdDefaultValue = InviteToPartyRequest.InviteeGameAccountIdDefaultValue;
				}
				return inviteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteeGameAccountId_ = value;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x000F4EEC File Offset: 0x000F30EC
		[DebuggerNonUserCode]
		public bool HasInviteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000F4F09 File Offset: 0x000F3109
		[DebuggerNonUserCode]
		public void ClearInviteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x000F4F1C File Offset: 0x000F311C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteToPartyRequest);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x000F4F3C File Offset: 0x000F313C
		[DebuggerNonUserCode]
		public bool Equals(InviteToPartyRequest other)
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
					bool flag4 = this.InviteeGameAccountId != other.InviteeGameAccountId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x000F4F94 File Offset: 0x000F3194
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num ^= this.InviteeGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x000F4FE4 File Offset: 0x000F31E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x000F4FFC File Offset: 0x000F31FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x000F5008 File Offset: 0x000F3208
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.InviteeGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x000F5054 File Offset: 0x000F3254
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviteeGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x000F50A4 File Offset: 0x000F32A4
		[DebuggerNonUserCode]
		public void MergeFrom(InviteToPartyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviteeGameAccountId = other.HasInviteeGameAccountId;
				if (hasInviteeGameAccountId)
				{
					this.InviteeGameAccountId = other.InviteeGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x000F50ED File Offset: 0x000F32ED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x000F50F8 File Offset: 0x000F32F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InviteeGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C7B RID: 7291
		private static readonly MessageParser<InviteToPartyRequest> _parser = new MessageParser<InviteToPartyRequest>(() => new InviteToPartyRequest());

		// Token: 0x04001C7C RID: 7292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C7D RID: 7293
		private int _hasBits0;

		// Token: 0x04001C7E RID: 7294
		public const int InviteeGameAccountIdFieldNumber = 1;

		// Token: 0x04001C7F RID: 7295
		private static readonly uint InviteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04001C80 RID: 7296
		private uint inviteeGameAccountId_;
	}
}
