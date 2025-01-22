using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000617 RID: 1559
	public sealed class GenerateWebCredentialsResponse : IMessage<GenerateWebCredentialsResponse>, IMessage, IEquatable<GenerateWebCredentialsResponse>, IDeepCloneable<GenerateWebCredentialsResponse>, IBufferMessage
	{
		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600920D RID: 37389 RVA: 0x00235F24 File Offset: 0x00234124
		[DebuggerNonUserCode]
		public static MessageParser<GenerateWebCredentialsResponse> Parser
		{
			get
			{
				return GenerateWebCredentialsResponse._parser;
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600920E RID: 37390 RVA: 0x00235F3C File Offset: 0x0023413C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x00235F60 File Offset: 0x00234160
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateWebCredentialsResponse.Descriptor;
			}
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00235F77 File Offset: 0x00234177
		[DebuggerNonUserCode]
		public GenerateWebCredentialsResponse()
		{
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00235F81 File Offset: 0x00234181
		[DebuggerNonUserCode]
		public GenerateWebCredentialsResponse(GenerateWebCredentialsResponse other)
			: this()
		{
			this.webCredentials_ = other.webCredentials_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x00235FA8 File Offset: 0x002341A8
		[DebuggerNonUserCode]
		public GenerateWebCredentialsResponse Clone()
		{
			return new GenerateWebCredentialsResponse(this);
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x06009213 RID: 37395 RVA: 0x00235FC0 File Offset: 0x002341C0
		// (set) Token: 0x06009214 RID: 37396 RVA: 0x00235FE1 File Offset: 0x002341E1
		[DebuggerNonUserCode]
		public ByteString WebCredentials
		{
			get
			{
				return this.webCredentials_ ?? GenerateWebCredentialsResponse.WebCredentialsDefaultValue;
			}
			set
			{
				this.webCredentials_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x06009215 RID: 37397 RVA: 0x00235FF8 File Offset: 0x002341F8
		[DebuggerNonUserCode]
		public bool HasWebCredentials
		{
			get
			{
				return this.webCredentials_ != null;
			}
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00236016 File Offset: 0x00234216
		[DebuggerNonUserCode]
		public void ClearWebCredentials()
		{
			this.webCredentials_ = null;
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00236020 File Offset: 0x00234220
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateWebCredentialsResponse);
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00236040 File Offset: 0x00234240
		[DebuggerNonUserCode]
		public bool Equals(GenerateWebCredentialsResponse other)
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

		// Token: 0x06009219 RID: 37401 RVA: 0x00236098 File Offset: 0x00234298
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

		// Token: 0x0600921A RID: 37402 RVA: 0x002360E4 File Offset: 0x002342E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x002360FC File Offset: 0x002342FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x00236108 File Offset: 0x00234308
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

		// Token: 0x0600921D RID: 37405 RVA: 0x00236154 File Offset: 0x00234354
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

		// Token: 0x0600921E RID: 37406 RVA: 0x002361A4 File Offset: 0x002343A4
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateWebCredentialsResponse other)
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

		// Token: 0x0600921F RID: 37407 RVA: 0x002361ED File Offset: 0x002343ED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x002361F8 File Offset: 0x002343F8
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

		// Token: 0x040041DE RID: 16862
		private static readonly MessageParser<GenerateWebCredentialsResponse> _parser = new MessageParser<GenerateWebCredentialsResponse>(() => new GenerateWebCredentialsResponse());

		// Token: 0x040041DF RID: 16863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E0 RID: 16864
		public const int WebCredentialsFieldNumber = 1;

		// Token: 0x040041E1 RID: 16865
		private static readonly ByteString WebCredentialsDefaultValue = ByteString.Empty;

		// Token: 0x040041E2 RID: 16866
		private ByteString webCredentials_;
	}
}
