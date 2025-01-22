using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000302 RID: 770
	public sealed class ClientError : IMessage<ClientError>, IMessage, IEquatable<ClientError>, IDeepCloneable<ClientError>, IBufferMessage
	{
		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x001398C0 File Offset: 0x00137AC0
		[DebuggerNonUserCode]
		public static MessageParser<ClientError> Parser
		{
			get
			{
				return ClientError._parser;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x001398D8 File Offset: 0x00137AD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientErrorReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x001398FC File Offset: 0x00137AFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientError.Descriptor;
			}
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00139913 File Offset: 0x00137B13
		[DebuggerNonUserCode]
		public ClientError()
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x0013991D File Offset: 0x00137B1D
		[DebuggerNonUserCode]
		public ClientError(ClientError other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this.errorContext_ = other.errorContext_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x0013995C File Offset: 0x00137B5C
		[DebuggerNonUserCode]
		public ClientError Clone()
		{
			return new ClientError(this);
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x00139974 File Offset: 0x00137B74
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x001399A5 File Offset: 0x00137BA5
		[DebuggerNonUserCode]
		public int ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = ClientError.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x001399C0 File Offset: 0x00137BC0
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x001399DD File Offset: 0x00137BDD
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x001399F0 File Offset: 0x00137BF0
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x00139A11 File Offset: 0x00137C11
		[DebuggerNonUserCode]
		public string ErrorContext
		{
			get
			{
				return this.errorContext_ ?? ClientError.ErrorContextDefaultValue;
			}
			set
			{
				this.errorContext_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x00139A28 File Offset: 0x00137C28
		[DebuggerNonUserCode]
		public bool HasErrorContext
		{
			get
			{
				return this.errorContext_ != null;
			}
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00139A43 File Offset: 0x00137C43
		[DebuggerNonUserCode]
		public void ClearErrorContext()
		{
			this.errorContext_ = null;
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00139A50 File Offset: 0x00137C50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientError);
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00139A70 File Offset: 0x00137C70
		[DebuggerNonUserCode]
		public bool Equals(ClientError other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ErrorContext != other.ErrorContext;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00139AE4 File Offset: 0x00137CE4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool hasErrorContext = this.HasErrorContext;
			if (hasErrorContext)
			{
				num ^= this.ErrorContext.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00139B50 File Offset: 0x00137D50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00139B68 File Offset: 0x00137D68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00139B74 File Offset: 0x00137D74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ErrorCode);
			}
			bool hasErrorContext = this.HasErrorContext;
			if (hasErrorContext)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ErrorContext);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x00139BE4 File Offset: 0x00137DE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ErrorCode);
			}
			bool hasErrorContext = this.HasErrorContext;
			if (hasErrorContext)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorContext);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00139C50 File Offset: 0x00137E50
		[DebuggerNonUserCode]
		public void MergeFrom(ClientError other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool hasErrorContext = other.HasErrorContext;
				if (hasErrorContext)
				{
					this.ErrorContext = other.ErrorContext;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00139CB2 File Offset: 0x00137EB2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00139CC0 File Offset: 0x00137EC0
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
						this.ErrorContext = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = input.ReadInt32();
				}
			}
		}

		// Token: 0x040024CD RID: 9421
		private static readonly MessageParser<ClientError> _parser = new MessageParser<ClientError>(() => new ClientError());

		// Token: 0x040024CE RID: 9422
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024CF RID: 9423
		private int _hasBits0;

		// Token: 0x040024D0 RID: 9424
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040024D1 RID: 9425
		private static readonly int ErrorCodeDefaultValue = 0;

		// Token: 0x040024D2 RID: 9426
		private int errorCode_;

		// Token: 0x040024D3 RID: 9427
		public const int ErrorContextFieldNumber = 2;

		// Token: 0x040024D4 RID: 9428
		private static readonly string ErrorContextDefaultValue = "";

		// Token: 0x040024D5 RID: 9429
		private string errorContext_;
	}
}
