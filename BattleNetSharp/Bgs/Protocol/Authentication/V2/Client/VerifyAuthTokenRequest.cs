using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000622 RID: 1570
	public sealed class VerifyAuthTokenRequest : IMessage<VerifyAuthTokenRequest>, IMessage, IEquatable<VerifyAuthTokenRequest>, IDeepCloneable<VerifyAuthTokenRequest>, IBufferMessage
	{
		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x060092B7 RID: 37559 RVA: 0x00238D88 File Offset: 0x00236F88
		[DebuggerNonUserCode]
		public static MessageParser<VerifyAuthTokenRequest> Parser
		{
			get
			{
				return VerifyAuthTokenRequest._parser;
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x060092B8 RID: 37560 RVA: 0x00238DA0 File Offset: 0x00236FA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x060092B9 RID: 37561 RVA: 0x00238DC4 File Offset: 0x00236FC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VerifyAuthTokenRequest.Descriptor;
			}
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00238DDB File Offset: 0x00236FDB
		[DebuggerNonUserCode]
		public VerifyAuthTokenRequest()
		{
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x00238DE5 File Offset: 0x00236FE5
		[DebuggerNonUserCode]
		public VerifyAuthTokenRequest(VerifyAuthTokenRequest other)
			: this()
		{
			this.authToken_ = other.authToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x00238E0C File Offset: 0x0023700C
		[DebuggerNonUserCode]
		public VerifyAuthTokenRequest Clone()
		{
			return new VerifyAuthTokenRequest(this);
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x00238E24 File Offset: 0x00237024
		// (set) Token: 0x060092BE RID: 37566 RVA: 0x00238E45 File Offset: 0x00237045
		[DebuggerNonUserCode]
		public ByteString AuthToken
		{
			get
			{
				return this.authToken_ ?? VerifyAuthTokenRequest.AuthTokenDefaultValue;
			}
			set
			{
				this.authToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x060092BF RID: 37567 RVA: 0x00238E5C File Offset: 0x0023705C
		[DebuggerNonUserCode]
		public bool HasAuthToken
		{
			get
			{
				return this.authToken_ != null;
			}
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00238E7A File Offset: 0x0023707A
		[DebuggerNonUserCode]
		public void ClearAuthToken()
		{
			this.authToken_ = null;
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x00238E84 File Offset: 0x00237084
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VerifyAuthTokenRequest);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x00238EA4 File Offset: 0x002370A4
		[DebuggerNonUserCode]
		public bool Equals(VerifyAuthTokenRequest other)
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

		// Token: 0x060092C3 RID: 37571 RVA: 0x00238EFC File Offset: 0x002370FC
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

		// Token: 0x060092C4 RID: 37572 RVA: 0x00238F48 File Offset: 0x00237148
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x00238F60 File Offset: 0x00237160
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x00238F6C File Offset: 0x0023716C
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

		// Token: 0x060092C7 RID: 37575 RVA: 0x00238FB8 File Offset: 0x002371B8
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

		// Token: 0x060092C8 RID: 37576 RVA: 0x00239008 File Offset: 0x00237208
		[DebuggerNonUserCode]
		public void MergeFrom(VerifyAuthTokenRequest other)
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

		// Token: 0x060092C9 RID: 37577 RVA: 0x00239051 File Offset: 0x00237251
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x0023905C File Offset: 0x0023725C
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

		// Token: 0x04004247 RID: 16967
		private static readonly MessageParser<VerifyAuthTokenRequest> _parser = new MessageParser<VerifyAuthTokenRequest>(() => new VerifyAuthTokenRequest());

		// Token: 0x04004248 RID: 16968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004249 RID: 16969
		public const int AuthTokenFieldNumber = 1;

		// Token: 0x0400424A RID: 16970
		private static readonly ByteString AuthTokenDefaultValue = ByteString.Empty;

		// Token: 0x0400424B RID: 16971
		private ByteString authToken_;
	}
}
