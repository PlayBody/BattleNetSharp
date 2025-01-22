using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000618 RID: 1560
	public sealed class VerifyWebCredentialsRequest : IMessage<VerifyWebCredentialsRequest>, IMessage, IEquatable<VerifyWebCredentialsRequest>, IDeepCloneable<VerifyWebCredentialsRequest>, IBufferMessage
	{
		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x00236270 File Offset: 0x00234470
		[DebuggerNonUserCode]
		public static MessageParser<VerifyWebCredentialsRequest> Parser
		{
			get
			{
				return VerifyWebCredentialsRequest._parser;
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x00236288 File Offset: 0x00234488
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x002362AC File Offset: 0x002344AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VerifyWebCredentialsRequest.Descriptor;
			}
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x002362C3 File Offset: 0x002344C3
		[DebuggerNonUserCode]
		public VerifyWebCredentialsRequest()
		{
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x002362CD File Offset: 0x002344CD
		[DebuggerNonUserCode]
		public VerifyWebCredentialsRequest(VerifyWebCredentialsRequest other)
			: this()
		{
			this.webCredentials_ = other.webCredentials_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x002362F4 File Offset: 0x002344F4
		[DebuggerNonUserCode]
		public VerifyWebCredentialsRequest Clone()
		{
			return new VerifyWebCredentialsRequest(this);
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x0023630C File Offset: 0x0023450C
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x0023632D File Offset: 0x0023452D
		[DebuggerNonUserCode]
		public ByteString WebCredentials
		{
			get
			{
				return this.webCredentials_ ?? VerifyWebCredentialsRequest.WebCredentialsDefaultValue;
			}
			set
			{
				this.webCredentials_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x00236344 File Offset: 0x00234544
		[DebuggerNonUserCode]
		public bool HasWebCredentials
		{
			get
			{
				return this.webCredentials_ != null;
			}
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x00236362 File Offset: 0x00234562
		[DebuggerNonUserCode]
		public void ClearWebCredentials()
		{
			this.webCredentials_ = null;
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x0023636C File Offset: 0x0023456C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VerifyWebCredentialsRequest);
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x0023638C File Offset: 0x0023458C
		[DebuggerNonUserCode]
		public bool Equals(VerifyWebCredentialsRequest other)
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
					bool flag4 = this.WebCredentials != other.WebCredentials;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x002363E4 File Offset: 0x002345E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWebCredentials = this.HasWebCredentials;
			if (hasWebCredentials)
			{
				num ^= this.WebCredentials.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x00236430 File Offset: 0x00234630
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00236448 File Offset: 0x00234648
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x00236454 File Offset: 0x00234654
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWebCredentials = this.HasWebCredentials;
			if (hasWebCredentials)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.WebCredentials);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x002364A0 File Offset: 0x002346A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWebCredentials = this.HasWebCredentials;
			if (hasWebCredentials)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.WebCredentials);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x002364F0 File Offset: 0x002346F0
		[DebuggerNonUserCode]
		public void MergeFrom(VerifyWebCredentialsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWebCredentials = other.HasWebCredentials;
				if (hasWebCredentials)
				{
					this.WebCredentials = other.WebCredentials;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x00236539 File Offset: 0x00234739
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00236544 File Offset: 0x00234744
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
					this.WebCredentials = input.ReadBytes();
				}
			}
		}

		// Token: 0x040041E3 RID: 16867
		private static readonly MessageParser<VerifyWebCredentialsRequest> _parser = new MessageParser<VerifyWebCredentialsRequest>(() => new VerifyWebCredentialsRequest());

		// Token: 0x040041E4 RID: 16868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E5 RID: 16869
		public const int WebCredentialsFieldNumber = 1;

		// Token: 0x040041E6 RID: 16870
		private static readonly ByteString WebCredentialsDefaultValue = ByteString.Empty;

		// Token: 0x040041E7 RID: 16871
		private ByteString webCredentials_;
	}
}
