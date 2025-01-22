using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x0200061E RID: 1566
	public sealed class ExternalChallengeNotification : IMessage<ExternalChallengeNotification>, IMessage, IEquatable<ExternalChallengeNotification>, IDeepCloneable<ExternalChallengeNotification>, IBufferMessage
	{
		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x00237ADC File Offset: 0x00235CDC
		[DebuggerNonUserCode]
		public static MessageParser<ExternalChallengeNotification> Parser
		{
			get
			{
				return ExternalChallengeNotification._parser;
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x06009270 RID: 37488 RVA: 0x00237AF4 File Offset: 0x00235CF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x00237B18 File Offset: 0x00235D18
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExternalChallengeNotification.Descriptor;
			}
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x00237B2F File Offset: 0x00235D2F
		[DebuggerNonUserCode]
		public ExternalChallengeNotification()
		{
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x00237B39 File Offset: 0x00235D39
		[DebuggerNonUserCode]
		public ExternalChallengeNotification(ExternalChallengeNotification other)
			: this()
		{
			this.requestToken_ = other.requestToken_;
			this.payloadType_ = other.payloadType_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x00237B78 File Offset: 0x00235D78
		[DebuggerNonUserCode]
		public ExternalChallengeNotification Clone()
		{
			return new ExternalChallengeNotification(this);
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x06009275 RID: 37493 RVA: 0x00237B90 File Offset: 0x00235D90
		// (set) Token: 0x06009276 RID: 37494 RVA: 0x00237BB1 File Offset: 0x00235DB1
		[DebuggerNonUserCode]
		public string RequestToken
		{
			get
			{
				return this.requestToken_ ?? ExternalChallengeNotification.RequestTokenDefaultValue;
			}
			set
			{
				this.requestToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x00237BC8 File Offset: 0x00235DC8
		[DebuggerNonUserCode]
		public bool HasRequestToken
		{
			get
			{
				return this.requestToken_ != null;
			}
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00237BE3 File Offset: 0x00235DE3
		[DebuggerNonUserCode]
		public void ClearRequestToken()
		{
			this.requestToken_ = null;
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x00237BF0 File Offset: 0x00235DF0
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x00237C11 File Offset: 0x00235E11
		[DebuggerNonUserCode]
		public string PayloadType
		{
			get
			{
				return this.payloadType_ ?? ExternalChallengeNotification.PayloadTypeDefaultValue;
			}
			set
			{
				this.payloadType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x00237C28 File Offset: 0x00235E28
		[DebuggerNonUserCode]
		public bool HasPayloadType
		{
			get
			{
				return this.payloadType_ != null;
			}
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x00237C43 File Offset: 0x00235E43
		[DebuggerNonUserCode]
		public void ClearPayloadType()
		{
			this.payloadType_ = null;
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600927D RID: 37501 RVA: 0x00237C50 File Offset: 0x00235E50
		// (set) Token: 0x0600927E RID: 37502 RVA: 0x00237C71 File Offset: 0x00235E71
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? ExternalChallengeNotification.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x00237C88 File Offset: 0x00235E88
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x00237CA6 File Offset: 0x00235EA6
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x00237CB0 File Offset: 0x00235EB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExternalChallengeNotification);
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00237CD0 File Offset: 0x00235ED0
		[DebuggerNonUserCode]
		public bool Equals(ExternalChallengeNotification other)
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
					bool flag4 = this.RequestToken != other.RequestToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PayloadType != other.PayloadType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Payload != other.Payload;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00237D5C File Offset: 0x00235F5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num ^= this.RequestToken.GetHashCode();
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				num ^= this.PayloadType.GetHashCode();
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00237DDC File Offset: 0x00235FDC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x00237DF4 File Offset: 0x00235FF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00237E00 File Offset: 0x00236000
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.RequestToken);
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PayloadType);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00237E90 File Offset: 0x00236090
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequestToken);
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PayloadType);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00237F1C File Offset: 0x0023611C
		[DebuggerNonUserCode]
		public void MergeFrom(ExternalChallengeNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequestToken = other.HasRequestToken;
				if (hasRequestToken)
				{
					this.RequestToken = other.RequestToken;
				}
				bool hasPayloadType = other.HasPayloadType;
				if (hasPayloadType)
				{
					this.PayloadType = other.PayloadType;
				}
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00237F97 File Offset: 0x00236197
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x00237FA4 File Offset: 0x002361A4
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Payload = input.ReadBytes();
						}
					}
					else
					{
						this.PayloadType = input.ReadString();
					}
				}
				else
				{
					this.RequestToken = input.ReadString();
				}
			}
		}

		// Token: 0x04004220 RID: 16928
		private static readonly MessageParser<ExternalChallengeNotification> _parser = new MessageParser<ExternalChallengeNotification>(() => new ExternalChallengeNotification());

		// Token: 0x04004221 RID: 16929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004222 RID: 16930
		public const int RequestTokenFieldNumber = 1;

		// Token: 0x04004223 RID: 16931
		private static readonly string RequestTokenDefaultValue = "";

		// Token: 0x04004224 RID: 16932
		private string requestToken_;

		// Token: 0x04004225 RID: 16933
		public const int PayloadTypeFieldNumber = 2;

		// Token: 0x04004226 RID: 16934
		private static readonly string PayloadTypeDefaultValue = "";

		// Token: 0x04004227 RID: 16935
		private string payloadType_;

		// Token: 0x04004228 RID: 16936
		public const int PayloadFieldNumber = 3;

		// Token: 0x04004229 RID: 16937
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x0400422A RID: 16938
		private ByteString payload_;
	}
}
