using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060B RID: 1547
	public sealed class GenerateSSOTokenResponse : IMessage<GenerateSSOTokenResponse>, IMessage, IEquatable<GenerateSSOTokenResponse>, IDeepCloneable<GenerateSSOTokenResponse>, IBufferMessage
	{
		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x060090E4 RID: 37092 RVA: 0x002325CC File Offset: 0x002307CC
		[DebuggerNonUserCode]
		public static MessageParser<GenerateSSOTokenResponse> Parser
		{
			get
			{
				return GenerateSSOTokenResponse._parser;
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x060090E5 RID: 37093 RVA: 0x002325E4 File Offset: 0x002307E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x060090E6 RID: 37094 RVA: 0x00232608 File Offset: 0x00230808
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateSSOTokenResponse.Descriptor;
			}
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0023261F File Offset: 0x0023081F
		[DebuggerNonUserCode]
		public GenerateSSOTokenResponse()
		{
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x00232629 File Offset: 0x00230829
		[DebuggerNonUserCode]
		public GenerateSSOTokenResponse(GenerateSSOTokenResponse other)
			: this()
		{
			this.ssoId_ = other.ssoId_;
			this.ssoSecret_ = other.ssoSecret_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x0023265C File Offset: 0x0023085C
		[DebuggerNonUserCode]
		public GenerateSSOTokenResponse Clone()
		{
			return new GenerateSSOTokenResponse(this);
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x060090EA RID: 37098 RVA: 0x00232674 File Offset: 0x00230874
		// (set) Token: 0x060090EB RID: 37099 RVA: 0x00232695 File Offset: 0x00230895
		[DebuggerNonUserCode]
		public ByteString SsoId
		{
			get
			{
				return this.ssoId_ ?? GenerateSSOTokenResponse.SsoIdDefaultValue;
			}
			set
			{
				this.ssoId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x002326AC File Offset: 0x002308AC
		[DebuggerNonUserCode]
		public bool HasSsoId
		{
			get
			{
				return this.ssoId_ != null;
			}
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x002326CA File Offset: 0x002308CA
		[DebuggerNonUserCode]
		public void ClearSsoId()
		{
			this.ssoId_ = null;
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x002326D4 File Offset: 0x002308D4
		// (set) Token: 0x060090EF RID: 37103 RVA: 0x002326F5 File Offset: 0x002308F5
		[DebuggerNonUserCode]
		public ByteString SsoSecret
		{
			get
			{
				return this.ssoSecret_ ?? GenerateSSOTokenResponse.SsoSecretDefaultValue;
			}
			set
			{
				this.ssoSecret_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x0023270C File Offset: 0x0023090C
		[DebuggerNonUserCode]
		public bool HasSsoSecret
		{
			get
			{
				return this.ssoSecret_ != null;
			}
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x0023272A File Offset: 0x0023092A
		[DebuggerNonUserCode]
		public void ClearSsoSecret()
		{
			this.ssoSecret_ = null;
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x00232734 File Offset: 0x00230934
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateSSOTokenResponse);
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x00232754 File Offset: 0x00230954
		[DebuggerNonUserCode]
		public bool Equals(GenerateSSOTokenResponse other)
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
					bool flag4 = this.SsoId != other.SsoId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SsoSecret != other.SsoSecret;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x002327C8 File Offset: 0x002309C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSsoId = this.HasSsoId;
			if (hasSsoId)
			{
				num ^= this.SsoId.GetHashCode();
			}
			bool hasSsoSecret = this.HasSsoSecret;
			if (hasSsoSecret)
			{
				num ^= this.SsoSecret.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x0023282C File Offset: 0x00230A2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00232844 File Offset: 0x00230A44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00232850 File Offset: 0x00230A50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSsoId = this.HasSsoId;
			if (hasSsoId)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SsoId);
			}
			bool hasSsoSecret = this.HasSsoSecret;
			if (hasSsoSecret)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.SsoSecret);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x002328C0 File Offset: 0x00230AC0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSsoId = this.HasSsoId;
			if (hasSsoId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SsoId);
			}
			bool hasSsoSecret = this.HasSsoSecret;
			if (hasSsoSecret)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SsoSecret);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x0023292C File Offset: 0x00230B2C
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateSSOTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSsoId = other.HasSsoId;
				if (hasSsoId)
				{
					this.SsoId = other.SsoId;
				}
				bool hasSsoSecret = other.HasSsoSecret;
				if (hasSsoSecret)
				{
					this.SsoSecret = other.SsoSecret;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x0023298E File Offset: 0x00230B8E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0023299C File Offset: 0x00230B9C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SsoSecret = input.ReadBytes();
					}
				}
				else
				{
					this.SsoId = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004175 RID: 16757
		private static readonly MessageParser<GenerateSSOTokenResponse> _parser = new MessageParser<GenerateSSOTokenResponse>(() => new GenerateSSOTokenResponse());

		// Token: 0x04004176 RID: 16758
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004177 RID: 16759
		public const int SsoIdFieldNumber = 1;

		// Token: 0x04004178 RID: 16760
		private static readonly ByteString SsoIdDefaultValue = ByteString.Empty;

		// Token: 0x04004179 RID: 16761
		private ByteString ssoId_;

		// Token: 0x0400417A RID: 16762
		public const int SsoSecretFieldNumber = 2;

		// Token: 0x0400417B RID: 16763
		private static readonly ByteString SsoSecretDefaultValue = ByteString.Empty;

		// Token: 0x0400417C RID: 16764
		private ByteString ssoSecret_;
	}
}
