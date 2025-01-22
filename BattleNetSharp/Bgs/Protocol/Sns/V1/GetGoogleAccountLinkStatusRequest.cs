using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CD RID: 973
	public sealed class GetGoogleAccountLinkStatusRequest : IMessage<GetGoogleAccountLinkStatusRequest>, IMessage, IEquatable<GetGoogleAccountLinkStatusRequest>, IDeepCloneable<GetGoogleAccountLinkStatusRequest>, IBufferMessage
	{
		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06006147 RID: 24903 RVA: 0x001787E8 File Offset: 0x001769E8
		[DebuggerNonUserCode]
		public static MessageParser<GetGoogleAccountLinkStatusRequest> Parser
		{
			get
			{
				return GetGoogleAccountLinkStatusRequest._parser;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06006148 RID: 24904 RVA: 0x00178800 File Offset: 0x00176A00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06006149 RID: 24905 RVA: 0x00178824 File Offset: 0x00176A24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGoogleAccountLinkStatusRequest.Descriptor;
			}
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x0017883B File Offset: 0x00176A3B
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusRequest()
		{
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x00178845 File Offset: 0x00176A45
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusRequest(GetGoogleAccountLinkStatusRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00178860 File Offset: 0x00176A60
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusRequest Clone()
		{
			return new GetGoogleAccountLinkStatusRequest(this);
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00178878 File Offset: 0x00176A78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGoogleAccountLinkStatusRequest);
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00178898 File Offset: 0x00176A98
		[DebuggerNonUserCode]
		public bool Equals(GetGoogleAccountLinkStatusRequest other)
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

		// Token: 0x0600614F RID: 24911 RVA: 0x001788D8 File Offset: 0x00176AD8
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

		// Token: 0x06006150 RID: 24912 RVA: 0x0017890C File Offset: 0x00176B0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00178924 File Offset: 0x00176B24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x00178930 File Offset: 0x00176B30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x0017895C File Offset: 0x00176B5C
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

		// Token: 0x06006154 RID: 24916 RVA: 0x00178990 File Offset: 0x00176B90
		[DebuggerNonUserCode]
		public void MergeFrom(GetGoogleAccountLinkStatusRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x001789C0 File Offset: 0x00176BC0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x001789CC File Offset: 0x00176BCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C5D RID: 11357
		private static readonly MessageParser<GetGoogleAccountLinkStatusRequest> _parser = new MessageParser<GetGoogleAccountLinkStatusRequest>(() => new GetGoogleAccountLinkStatusRequest());

		// Token: 0x04002C5E RID: 11358
		private UnknownFieldSet _unknownFields;
	}
}
