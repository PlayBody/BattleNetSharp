using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000434 RID: 1076
	public sealed class DisconnectRequest : IMessage<DisconnectRequest>, IMessage, IEquatable<DisconnectRequest>, IDeepCloneable<DisconnectRequest>, IBufferMessage
	{
		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x060069CD RID: 27085 RVA: 0x001998B0 File Offset: 0x00197AB0
		[DebuggerNonUserCode]
		public static MessageParser<DisconnectRequest> Parser
		{
			get
			{
				return DisconnectRequest._parser;
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x001998C8 File Offset: 0x00197AC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x060069CF RID: 27087 RVA: 0x001998EC File Offset: 0x00197AEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisconnectRequest.Descriptor;
			}
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x00199903 File Offset: 0x00197B03
		[DebuggerNonUserCode]
		public DisconnectRequest()
		{
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x0019990D File Offset: 0x00197B0D
		[DebuggerNonUserCode]
		public DisconnectRequest(DisconnectRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x00199940 File Offset: 0x00197B40
		[DebuggerNonUserCode]
		public DisconnectRequest Clone()
		{
			return new DisconnectRequest(this);
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x00199958 File Offset: 0x00197B58
		// (set) Token: 0x060069D4 RID: 27092 RVA: 0x00199989 File Offset: 0x00197B89
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = DisconnectRequest.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x060069D5 RID: 27093 RVA: 0x001999A4 File Offset: 0x00197BA4
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x001999C1 File Offset: 0x00197BC1
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x001999D4 File Offset: 0x00197BD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisconnectRequest);
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x001999F4 File Offset: 0x00197BF4
		[DebuggerNonUserCode]
		public bool Equals(DisconnectRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x00199A4C File Offset: 0x00197C4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x00199A9C File Offset: 0x00197C9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x00199AB4 File Offset: 0x00197CB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x00199AC0 File Offset: 0x00197CC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00199B0C File Offset: 0x00197D0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00199B5C File Offset: 0x00197D5C
		[DebuggerNonUserCode]
		public void MergeFrom(DisconnectRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00199BA5 File Offset: 0x00197DA5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00199BB0 File Offset: 0x00197DB0
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
					this.ErrorCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003029 RID: 12329
		private static readonly MessageParser<DisconnectRequest> _parser = new MessageParser<DisconnectRequest>(() => new DisconnectRequest());

		// Token: 0x0400302A RID: 12330
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400302B RID: 12331
		private int _hasBits0;

		// Token: 0x0400302C RID: 12332
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400302D RID: 12333
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x0400302E RID: 12334
		private uint errorCode_;
	}
}
