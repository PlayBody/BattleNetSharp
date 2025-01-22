using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023E RID: 574
	public sealed class AddLocalPlayerToGameRequest : IMessage<AddLocalPlayerToGameRequest>, IMessage, IEquatable<AddLocalPlayerToGameRequest>, IDeepCloneable<AddLocalPlayerToGameRequest>, IBufferMessage
	{
		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000F45FC File Offset: 0x000F27FC
		[DebuggerNonUserCode]
		public static MessageParser<AddLocalPlayerToGameRequest> Parser
		{
			get
			{
				return AddLocalPlayerToGameRequest._parser;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x000F4614 File Offset: 0x000F2814
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[46];
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x000F4638 File Offset: 0x000F2838
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddLocalPlayerToGameRequest.Descriptor;
			}
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x000F464F File Offset: 0x000F284F
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameRequest()
		{
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x000F4659 File Offset: 0x000F2859
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameRequest(AddLocalPlayerToGameRequest other)
			: this()
		{
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x000F4680 File Offset: 0x000F2880
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameRequest Clone()
		{
			return new AddLocalPlayerToGameRequest(this);
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x000F4698 File Offset: 0x000F2898
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x000F46B9 File Offset: 0x000F28B9
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AddLocalPlayerToGameRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x000F46D0 File Offset: 0x000F28D0
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x000F46EE File Offset: 0x000F28EE
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000F46F8 File Offset: 0x000F28F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddLocalPlayerToGameRequest);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000F4718 File Offset: 0x000F2918
		[DebuggerNonUserCode]
		public bool Equals(AddLocalPlayerToGameRequest other)
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
					bool flag4 = this.SessionKey != other.SessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x000F4770 File Offset: 0x000F2970
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x000F47BC File Offset: 0x000F29BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x000F47D4 File Offset: 0x000F29D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x000F47E0 File Offset: 0x000F29E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x000F482C File Offset: 0x000F2A2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x000F487C File Offset: 0x000F2A7C
		[DebuggerNonUserCode]
		public void MergeFrom(AddLocalPlayerToGameRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x000F48C5 File Offset: 0x000F2AC5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x000F48D0 File Offset: 0x000F2AD0
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
					this.SessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001C6E RID: 7278
		private static readonly MessageParser<AddLocalPlayerToGameRequest> _parser = new MessageParser<AddLocalPlayerToGameRequest>(() => new AddLocalPlayerToGameRequest());

		// Token: 0x04001C6F RID: 7279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C70 RID: 7280
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04001C71 RID: 7281
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001C72 RID: 7282
		private ByteString sessionKey_;
	}
}
