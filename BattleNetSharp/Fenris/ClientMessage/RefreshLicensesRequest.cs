using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000296 RID: 662
	public sealed class RefreshLicensesRequest : IMessage<RefreshLicensesRequest>, IMessage, IEquatable<RefreshLicensesRequest>, IDeepCloneable<RefreshLicensesRequest>, IBufferMessage
	{
		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x0010CEEC File Offset: 0x0010B0EC
		[DebuggerNonUserCode]
		public static MessageParser<RefreshLicensesRequest> Parser
		{
			get
			{
				return RefreshLicensesRequest._parser;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x0010CF04 File Offset: 0x0010B104
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[134];
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x0010CF2C File Offset: 0x0010B12C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshLicensesRequest.Descriptor;
			}
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x0010CF43 File Offset: 0x0010B143
		[DebuggerNonUserCode]
		public RefreshLicensesRequest()
		{
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x0010CF4D File Offset: 0x0010B14D
		[DebuggerNonUserCode]
		public RefreshLicensesRequest(RefreshLicensesRequest other)
			: this()
		{
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x0010CF74 File Offset: 0x0010B174
		[DebuggerNonUserCode]
		public RefreshLicensesRequest Clone()
		{
			return new RefreshLicensesRequest(this);
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x0010CF8C File Offset: 0x0010B18C
		// (set) Token: 0x06004635 RID: 17973 RVA: 0x0010CFAD File Offset: 0x0010B1AD
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? RefreshLicensesRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004636 RID: 17974 RVA: 0x0010CFC4 File Offset: 0x0010B1C4
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0010CFE2 File Offset: 0x0010B1E2
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x0010CFEC File Offset: 0x0010B1EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshLicensesRequest);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x0010D00C File Offset: 0x0010B20C
		[DebuggerNonUserCode]
		public bool Equals(RefreshLicensesRequest other)
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

		// Token: 0x0600463A RID: 17978 RVA: 0x0010D064 File Offset: 0x0010B264
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

		// Token: 0x0600463B RID: 17979 RVA: 0x0010D0B0 File Offset: 0x0010B2B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x0010D0C8 File Offset: 0x0010B2C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x0010D0D4 File Offset: 0x0010B2D4
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

		// Token: 0x0600463E RID: 17982 RVA: 0x0010D120 File Offset: 0x0010B320
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

		// Token: 0x0600463F RID: 17983 RVA: 0x0010D170 File Offset: 0x0010B370
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshLicensesRequest other)
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

		// Token: 0x06004640 RID: 17984 RVA: 0x0010D1B9 File Offset: 0x0010B3B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x0010D1C4 File Offset: 0x0010B3C4
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

		// Token: 0x04001F3F RID: 7999
		private static readonly MessageParser<RefreshLicensesRequest> _parser = new MessageParser<RefreshLicensesRequest>(() => new RefreshLicensesRequest());

		// Token: 0x04001F40 RID: 8000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F41 RID: 8001
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04001F42 RID: 8002
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F43 RID: 8003
		private ByteString sessionKey_;
	}
}
