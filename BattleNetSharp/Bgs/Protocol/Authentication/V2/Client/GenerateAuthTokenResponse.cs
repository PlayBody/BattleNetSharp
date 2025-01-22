using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000624 RID: 1572
	public sealed class GenerateAuthTokenResponse : IMessage<GenerateAuthTokenResponse>, IMessage, IEquatable<GenerateAuthTokenResponse>, IDeepCloneable<GenerateAuthTokenResponse>, IBufferMessage
	{
		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x00239448 File Offset: 0x00237648
		[DebuggerNonUserCode]
		public static MessageParser<GenerateAuthTokenResponse> Parser
		{
			get
			{
				return GenerateAuthTokenResponse._parser;
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x060092E2 RID: 37602 RVA: 0x00239460 File Offset: 0x00237660
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x00239484 File Offset: 0x00237684
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateAuthTokenResponse.Descriptor;
			}
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x0023949B File Offset: 0x0023769B
		[DebuggerNonUserCode]
		public GenerateAuthTokenResponse()
		{
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x002394A5 File Offset: 0x002376A5
		[DebuggerNonUserCode]
		public GenerateAuthTokenResponse(GenerateAuthTokenResponse other)
			: this()
		{
			this.authToken_ = other.authToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x002394CC File Offset: 0x002376CC
		[DebuggerNonUserCode]
		public GenerateAuthTokenResponse Clone()
		{
			return new GenerateAuthTokenResponse(this);
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x002394E4 File Offset: 0x002376E4
		// (set) Token: 0x060092E8 RID: 37608 RVA: 0x00239505 File Offset: 0x00237705
		[DebuggerNonUserCode]
		public ByteString AuthToken
		{
			get
			{
				return this.authToken_ ?? GenerateAuthTokenResponse.AuthTokenDefaultValue;
			}
			set
			{
				this.authToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x0023951C File Offset: 0x0023771C
		[DebuggerNonUserCode]
		public bool HasAuthToken
		{
			get
			{
				return this.authToken_ != null;
			}
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x0023953A File Offset: 0x0023773A
		[DebuggerNonUserCode]
		public void ClearAuthToken()
		{
			this.authToken_ = null;
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00239544 File Offset: 0x00237744
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateAuthTokenResponse);
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00239564 File Offset: 0x00237764
		[DebuggerNonUserCode]
		public bool Equals(GenerateAuthTokenResponse other)
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
					bool flag4 = this.AuthToken != other.AuthToken;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x002395BC File Offset: 0x002377BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				num ^= this.AuthToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00239608 File Offset: 0x00237808
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00239620 File Offset: 0x00237820
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0023962C File Offset: 0x0023782C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.AuthToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x00239678 File Offset: 0x00237878
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AuthToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x002396C8 File Offset: 0x002378C8
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateAuthTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAuthToken = other.HasAuthToken;
				if (hasAuthToken)
				{
					this.AuthToken = other.AuthToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00239711 File Offset: 0x00237911
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x0023971C File Offset: 0x0023791C
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
					this.AuthToken = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004252 RID: 16978
		private static readonly MessageParser<GenerateAuthTokenResponse> _parser = new MessageParser<GenerateAuthTokenResponse>(() => new GenerateAuthTokenResponse());

		// Token: 0x04004253 RID: 16979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004254 RID: 16980
		public const int AuthTokenFieldNumber = 1;

		// Token: 0x04004255 RID: 16981
		private static readonly ByteString AuthTokenDefaultValue = ByteString.Empty;

		// Token: 0x04004256 RID: 16982
		private ByteString authToken_;
	}
}
