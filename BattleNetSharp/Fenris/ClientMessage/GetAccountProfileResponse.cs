using System;
using System.Diagnostics;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000235 RID: 565
	public sealed class GetAccountProfileResponse : IMessage<GetAccountProfileResponse>, IMessage, IEquatable<GetAccountProfileResponse>, IDeepCloneable<GetAccountProfileResponse>, IBufferMessage
	{
		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x000F1FEC File Offset: 0x000F01EC
		[DebuggerNonUserCode]
		public static MessageParser<GetAccountProfileResponse> Parser
		{
			get
			{
				return GetAccountProfileResponse._parser;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x000F2004 File Offset: 0x000F0204
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[37];
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x000F2028 File Offset: 0x000F0228
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountProfileResponse.Descriptor;
			}
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x000F203F File Offset: 0x000F023F
		[DebuggerNonUserCode]
		public GetAccountProfileResponse()
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x000F2049 File Offset: 0x000F0249
		[DebuggerNonUserCode]
		public GetAccountProfileResponse(GetAccountProfileResponse other)
			: this()
		{
			this.accountProfile_ = ((other.accountProfile_ != null) ? other.accountProfile_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x000F2080 File Offset: 0x000F0280
		[DebuggerNonUserCode]
		public GetAccountProfileResponse Clone()
		{
			return new GetAccountProfileResponse(this);
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x000F2098 File Offset: 0x000F0298
		// (set) Token: 0x06003D35 RID: 15669 RVA: 0x000F20B0 File Offset: 0x000F02B0
		[DebuggerNonUserCode]
		public AccountProfile AccountProfile
		{
			get
			{
				return this.accountProfile_;
			}
			set
			{
				this.accountProfile_ = value;
			}
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x000F20BC File Offset: 0x000F02BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountProfileResponse);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x000F20DC File Offset: 0x000F02DC
		[DebuggerNonUserCode]
		public bool Equals(GetAccountProfileResponse other)
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
					bool flag4 = !object.Equals(this.AccountProfile, other.AccountProfile);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000F2138 File Offset: 0x000F0338
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountProfile_ != null;
			if (flag)
			{
				num ^= this.AccountProfile.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000F2188 File Offset: 0x000F0388
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x000F21A0 File Offset: 0x000F03A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000F21AC File Offset: 0x000F03AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountProfile_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountProfile);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x000F21FC File Offset: 0x000F03FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountProfile_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountProfile);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x000F2250 File Offset: 0x000F0450
		[DebuggerNonUserCode]
		public void MergeFrom(GetAccountProfileResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountProfile_ != null;
				if (flag2)
				{
					bool flag3 = this.accountProfile_ == null;
					if (flag3)
					{
						this.AccountProfile = new AccountProfile();
					}
					this.AccountProfile.MergeFrom(other.AccountProfile);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x000F22BC File Offset: 0x000F04BC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x000F22C8 File Offset: 0x000F04C8
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
					bool flag = this.accountProfile_ == null;
					if (flag)
					{
						this.AccountProfile = new AccountProfile();
					}
					input.ReadMessage(this.AccountProfile);
				}
			}
		}

		// Token: 0x04001C2C RID: 7212
		private static readonly MessageParser<GetAccountProfileResponse> _parser = new MessageParser<GetAccountProfileResponse>(() => new GetAccountProfileResponse());

		// Token: 0x04001C2D RID: 7213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C2E RID: 7214
		public const int AccountProfileFieldNumber = 1;

		// Token: 0x04001C2F RID: 7215
		private AccountProfile accountProfile_;
	}
}
