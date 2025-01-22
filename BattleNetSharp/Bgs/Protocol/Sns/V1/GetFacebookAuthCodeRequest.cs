using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C4 RID: 964
	public sealed class GetFacebookAuthCodeRequest : IMessage<GetFacebookAuthCodeRequest>, IMessage, IEquatable<GetFacebookAuthCodeRequest>, IDeepCloneable<GetFacebookAuthCodeRequest>, IBufferMessage
	{
		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x0017653C File Offset: 0x0017473C
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookAuthCodeRequest> Parser
		{
			get
			{
				return GetFacebookAuthCodeRequest._parser;
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x00176554 File Offset: 0x00174754
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x00176578 File Offset: 0x00174778
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookAuthCodeRequest.Descriptor;
			}
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x0017658F File Offset: 0x0017478F
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeRequest()
		{
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00176599 File Offset: 0x00174799
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeRequest(GetFacebookAuthCodeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x001765B4 File Offset: 0x001747B4
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeRequest Clone()
		{
			return new GetFacebookAuthCodeRequest(this);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x001765CC File Offset: 0x001747CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookAuthCodeRequest);
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x001765EC File Offset: 0x001747EC
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookAuthCodeRequest other)
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

		// Token: 0x06006082 RID: 24706 RVA: 0x0017662C File Offset: 0x0017482C
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

		// Token: 0x06006083 RID: 24707 RVA: 0x00176660 File Offset: 0x00174860
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00176678 File Offset: 0x00174878
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00176684 File Offset: 0x00174884
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x001766B0 File Offset: 0x001748B0
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

		// Token: 0x06006087 RID: 24711 RVA: 0x001766E4 File Offset: 0x001748E4
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookAuthCodeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00176714 File Offset: 0x00174914
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00176720 File Offset: 0x00174920
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C22 RID: 11298
		private static readonly MessageParser<GetFacebookAuthCodeRequest> _parser = new MessageParser<GetFacebookAuthCodeRequest>(() => new GetFacebookAuthCodeRequest());

		// Token: 0x04002C23 RID: 11299
		private UnknownFieldSet _unknownFields;
	}
}
