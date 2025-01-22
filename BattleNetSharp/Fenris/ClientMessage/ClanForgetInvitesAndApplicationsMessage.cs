using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000274 RID: 628
	public sealed class ClanForgetInvitesAndApplicationsMessage : IMessage<ClanForgetInvitesAndApplicationsMessage>, IMessage, IEquatable<ClanForgetInvitesAndApplicationsMessage>, IDeepCloneable<ClanForgetInvitesAndApplicationsMessage>, IBufferMessage
	{
		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x001047A0 File Offset: 0x001029A0
		[DebuggerNonUserCode]
		public static MessageParser<ClanForgetInvitesAndApplicationsMessage> Parser
		{
			get
			{
				return ClanForgetInvitesAndApplicationsMessage._parser;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x001047B8 File Offset: 0x001029B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[100];
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x001047DC File Offset: 0x001029DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanForgetInvitesAndApplicationsMessage.Descriptor;
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x001047F3 File Offset: 0x001029F3
		[DebuggerNonUserCode]
		public ClanForgetInvitesAndApplicationsMessage()
		{
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x001047FD File Offset: 0x001029FD
		[DebuggerNonUserCode]
		public ClanForgetInvitesAndApplicationsMessage(ClanForgetInvitesAndApplicationsMessage other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00104824 File Offset: 0x00102A24
		[DebuggerNonUserCode]
		public ClanForgetInvitesAndApplicationsMessage Clone()
		{
			return new ClanForgetInvitesAndApplicationsMessage(this);
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x0010483C File Offset: 0x00102A3C
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x0010485D File Offset: 0x00102A5D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanForgetInvitesAndApplicationsMessage.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x00104874 File Offset: 0x00102A74
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0010488F File Offset: 0x00102A8F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x0010489C File Offset: 0x00102A9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanForgetInvitesAndApplicationsMessage);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x001048BC File Offset: 0x00102ABC
		[DebuggerNonUserCode]
		public bool Equals(ClanForgetInvitesAndApplicationsMessage other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00104914 File Offset: 0x00102B14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00104960 File Offset: 0x00102B60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00104978 File Offset: 0x00102B78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00104984 File Offset: 0x00102B84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x001049D0 File Offset: 0x00102BD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00104A20 File Offset: 0x00102C20
		[DebuggerNonUserCode]
		public void MergeFrom(ClanForgetInvitesAndApplicationsMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00104A69 File Offset: 0x00102C69
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00104A74 File Offset: 0x00102C74
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E51 RID: 7761
		private static readonly MessageParser<ClanForgetInvitesAndApplicationsMessage> _parser = new MessageParser<ClanForgetInvitesAndApplicationsMessage>(() => new ClanForgetInvitesAndApplicationsMessage());

		// Token: 0x04001E52 RID: 7762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E53 RID: 7763
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E54 RID: 7764
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E55 RID: 7765
		private string clanId_;
	}
}
