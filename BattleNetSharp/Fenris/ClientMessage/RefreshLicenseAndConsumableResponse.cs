using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000299 RID: 665
	public sealed class RefreshLicenseAndConsumableResponse : IMessage<RefreshLicenseAndConsumableResponse>, IMessage, IEquatable<RefreshLicenseAndConsumableResponse>, IDeepCloneable<RefreshLicenseAndConsumableResponse>, IBufferMessage
	{
		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x0010DA40 File Offset: 0x0010BC40
		[DebuggerNonUserCode]
		public static MessageParser<RefreshLicenseAndConsumableResponse> Parser
		{
			get
			{
				return RefreshLicenseAndConsumableResponse._parser;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x0010DA58 File Offset: 0x0010BC58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[137];
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x0010DA80 File Offset: 0x0010BC80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshLicenseAndConsumableResponse.Descriptor;
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x0010DA97 File Offset: 0x0010BC97
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableResponse()
		{
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0010DAA1 File Offset: 0x0010BCA1
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableResponse(RefreshLicenseAndConsumableResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x0010DABC File Offset: 0x0010BCBC
		[DebuggerNonUserCode]
		public RefreshLicenseAndConsumableResponse Clone()
		{
			return new RefreshLicenseAndConsumableResponse(this);
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x0010DAD4 File Offset: 0x0010BCD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshLicenseAndConsumableResponse);
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x0010DAF4 File Offset: 0x0010BCF4
		[DebuggerNonUserCode]
		public bool Equals(RefreshLicenseAndConsumableResponse other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x0010DB34 File Offset: 0x0010BD34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x0010DB68 File Offset: 0x0010BD68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x0010DB80 File Offset: 0x0010BD80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x0010DB8C File Offset: 0x0010BD8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x0010DBB8 File Offset: 0x0010BDB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x0010DBEC File Offset: 0x0010BDEC
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshLicenseAndConsumableResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x0010DC1C File Offset: 0x0010BE1C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x0010DC28 File Offset: 0x0010BE28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F51 RID: 8017
		private static readonly MessageParser<RefreshLicenseAndConsumableResponse> _parser = new MessageParser<RefreshLicenseAndConsumableResponse>(() => new RefreshLicenseAndConsumableResponse());

		// Token: 0x04001F52 RID: 8018
		private UnknownFieldSet _unknownFields;
	}
}
