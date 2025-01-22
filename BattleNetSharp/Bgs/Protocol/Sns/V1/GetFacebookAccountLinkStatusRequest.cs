using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C8 RID: 968
	public sealed class GetFacebookAccountLinkStatusRequest : IMessage<GetFacebookAccountLinkStatusRequest>, IMessage, IEquatable<GetFacebookAccountLinkStatusRequest>, IDeepCloneable<GetFacebookAccountLinkStatusRequest>, IBufferMessage
	{
		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x060060DE RID: 24798 RVA: 0x0017772C File Offset: 0x0017592C
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookAccountLinkStatusRequest> Parser
		{
			get
			{
				return GetFacebookAccountLinkStatusRequest._parser;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x060060DF RID: 24799 RVA: 0x00177744 File Offset: 0x00175944
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x00177768 File Offset: 0x00175968
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookAccountLinkStatusRequest.Descriptor;
			}
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0017777F File Offset: 0x0017597F
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusRequest()
		{
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00177789 File Offset: 0x00175989
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusRequest(GetFacebookAccountLinkStatusRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x001777A4 File Offset: 0x001759A4
		[DebuggerNonUserCode]
		public GetFacebookAccountLinkStatusRequest Clone()
		{
			return new GetFacebookAccountLinkStatusRequest(this);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x001777BC File Offset: 0x001759BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookAccountLinkStatusRequest);
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x001777DC File Offset: 0x001759DC
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookAccountLinkStatusRequest other)
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

		// Token: 0x060060E6 RID: 24806 RVA: 0x0017781C File Offset: 0x00175A1C
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

		// Token: 0x060060E7 RID: 24807 RVA: 0x00177850 File Offset: 0x00175A50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00177868 File Offset: 0x00175A68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x00177874 File Offset: 0x00175A74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x001778A0 File Offset: 0x00175AA0
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

		// Token: 0x060060EB RID: 24811 RVA: 0x001778D4 File Offset: 0x00175AD4
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookAccountLinkStatusRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00177904 File Offset: 0x00175B04
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00177910 File Offset: 0x00175B10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C43 RID: 11331
		private static readonly MessageParser<GetFacebookAccountLinkStatusRequest> _parser = new MessageParser<GetFacebookAccountLinkStatusRequest>(() => new GetFacebookAccountLinkStatusRequest());

		// Token: 0x04002C44 RID: 11332
		private UnknownFieldSet _unknownFields;
	}
}
