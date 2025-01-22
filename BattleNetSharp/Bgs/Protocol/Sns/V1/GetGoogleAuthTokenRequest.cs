using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CA RID: 970
	public sealed class GetGoogleAuthTokenRequest : IMessage<GetGoogleAuthTokenRequest>, IMessage, IEquatable<GetGoogleAuthTokenRequest>, IDeepCloneable<GetGoogleAuthTokenRequest>, IBufferMessage
	{
		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x00177F14 File Offset: 0x00176114
		[DebuggerNonUserCode]
		public static MessageParser<GetGoogleAuthTokenRequest> Parser
		{
			get
			{
				return GetGoogleAuthTokenRequest._parser;
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600610D RID: 24845 RVA: 0x00177F2C File Offset: 0x0017612C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600610E RID: 24846 RVA: 0x00177F50 File Offset: 0x00176150
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGoogleAuthTokenRequest.Descriptor;
			}
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x00177F67 File Offset: 0x00176167
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenRequest()
		{
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00177F71 File Offset: 0x00176171
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenRequest(GetGoogleAuthTokenRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x00177F8C File Offset: 0x0017618C
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenRequest Clone()
		{
			return new GetGoogleAuthTokenRequest(this);
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00177FA4 File Offset: 0x001761A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGoogleAuthTokenRequest);
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x00177FC4 File Offset: 0x001761C4
		[DebuggerNonUserCode]
		public bool Equals(GetGoogleAuthTokenRequest other)
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

		// Token: 0x06006114 RID: 24852 RVA: 0x00178004 File Offset: 0x00176204
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

		// Token: 0x06006115 RID: 24853 RVA: 0x00178038 File Offset: 0x00176238
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00178050 File Offset: 0x00176250
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x0017805C File Offset: 0x0017625C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00178088 File Offset: 0x00176288
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

		// Token: 0x06006119 RID: 24857 RVA: 0x001780BC File Offset: 0x001762BC
		[DebuggerNonUserCode]
		public void MergeFrom(GetGoogleAuthTokenRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x001780EC File Offset: 0x001762EC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x001780F8 File Offset: 0x001762F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C51 RID: 11345
		private static readonly MessageParser<GetGoogleAuthTokenRequest> _parser = new MessageParser<GetGoogleAuthTokenRequest>(() => new GetGoogleAuthTokenRequest());

		// Token: 0x04002C52 RID: 11346
		private UnknownFieldSet _unknownFields;
	}
}
