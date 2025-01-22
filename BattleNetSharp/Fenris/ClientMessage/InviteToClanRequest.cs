using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000267 RID: 615
	public sealed class InviteToClanRequest : IMessage<InviteToClanRequest>, IMessage, IEquatable<InviteToClanRequest>, IDeepCloneable<InviteToClanRequest>, IBufferMessage
	{
		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00100EB8 File Offset: 0x000FF0B8
		[DebuggerNonUserCode]
		public static MessageParser<InviteToClanRequest> Parser
		{
			get
			{
				return InviteToClanRequest._parser;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x00100ED0 File Offset: 0x000FF0D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[87];
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x00100EF4 File Offset: 0x000FF0F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteToClanRequest.Descriptor;
			}
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x00100F0B File Offset: 0x000FF10B
		[DebuggerNonUserCode]
		public InviteToClanRequest()
		{
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00100F15 File Offset: 0x000FF115
		[DebuggerNonUserCode]
		public InviteToClanRequest(InviteToClanRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.inviteeGameAccountId_ = other.inviteeGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00100F54 File Offset: 0x000FF154
		[DebuggerNonUserCode]
		public InviteToClanRequest Clone()
		{
			return new InviteToClanRequest(this);
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00100F6C File Offset: 0x000FF16C
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x00100F8D File Offset: 0x000FF18D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? InviteToClanRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x00100FA4 File Offset: 0x000FF1A4
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x00100FBF File Offset: 0x000FF1BF
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x00100FCC File Offset: 0x000FF1CC
		// (set) Token: 0x06004216 RID: 16918 RVA: 0x00100FFD File Offset: 0x000FF1FD
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
					inviteeGameAccountIdDefaultValue = InviteToClanRequest.InviteeGameAccountIdDefaultValue;
				}
				return inviteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteeGameAccountId_ = value;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x00101018 File Offset: 0x000FF218
		[DebuggerNonUserCode]
		public bool HasInviteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x00101035 File Offset: 0x000FF235
		[DebuggerNonUserCode]
		public void ClearInviteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00101048 File Offset: 0x000FF248
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteToClanRequest);
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00101068 File Offset: 0x000FF268
		[DebuggerNonUserCode]
		public bool Equals(InviteToClanRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviteeGameAccountId != other.InviteeGameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x001010DC File Offset: 0x000FF2DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
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

		// Token: 0x0600421C RID: 16924 RVA: 0x00101148 File Offset: 0x000FF348
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00101160 File Offset: 0x000FF360
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0010116C File Offset: 0x000FF36C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.InviteeGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x001011DC File Offset: 0x000FF3DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
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

		// Token: 0x06004220 RID: 16928 RVA: 0x00101248 File Offset: 0x000FF448
		[DebuggerNonUserCode]
		public void MergeFrom(InviteToClanRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasInviteeGameAccountId = other.HasInviteeGameAccountId;
				if (hasInviteeGameAccountId)
				{
					this.InviteeGameAccountId = other.InviteeGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x001012AA File Offset: 0x000FF4AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x001012B8 File Offset: 0x000FF4B8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InviteeGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DEB RID: 7659
		private static readonly MessageParser<InviteToClanRequest> _parser = new MessageParser<InviteToClanRequest>(() => new InviteToClanRequest());

		// Token: 0x04001DEC RID: 7660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DED RID: 7661
		private int _hasBits0;

		// Token: 0x04001DEE RID: 7662
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001DEF RID: 7663
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001DF0 RID: 7664
		private string clanId_;

		// Token: 0x04001DF1 RID: 7665
		public const int InviteeGameAccountIdFieldNumber = 2;

		// Token: 0x04001DF2 RID: 7666
		private static readonly uint InviteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04001DF3 RID: 7667
		private uint inviteeGameAccountId_;
	}
}
