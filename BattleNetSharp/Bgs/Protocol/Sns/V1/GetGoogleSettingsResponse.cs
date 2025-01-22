using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CC RID: 972
	public sealed class GetGoogleSettingsResponse : IMessage<GetGoogleSettingsResponse>, IMessage, IEquatable<GetGoogleSettingsResponse>, IDeepCloneable<GetGoogleSettingsResponse>, IBufferMessage
	{
		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x0017849C File Offset: 0x0017669C
		[DebuggerNonUserCode]
		public static MessageParser<GetGoogleSettingsResponse> Parser
		{
			get
			{
				return GetGoogleSettingsResponse._parser;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x001784B4 File Offset: 0x001766B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06006134 RID: 24884 RVA: 0x001784D8 File Offset: 0x001766D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGoogleSettingsResponse.Descriptor;
			}
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x001784EF File Offset: 0x001766EF
		[DebuggerNonUserCode]
		public GetGoogleSettingsResponse()
		{
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x001784F9 File Offset: 0x001766F9
		[DebuggerNonUserCode]
		public GetGoogleSettingsResponse(GetGoogleSettingsResponse other)
			: this()
		{
			this.clientId_ = other.clientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00178520 File Offset: 0x00176720
		[DebuggerNonUserCode]
		public GetGoogleSettingsResponse Clone()
		{
			return new GetGoogleSettingsResponse(this);
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06006138 RID: 24888 RVA: 0x00178538 File Offset: 0x00176738
		// (set) Token: 0x06006139 RID: 24889 RVA: 0x00178559 File Offset: 0x00176759
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? GetGoogleSettingsResponse.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x00178570 File Offset: 0x00176770
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x0017858B File Offset: 0x0017678B
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00178598 File Offset: 0x00176798
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGoogleSettingsResponse);
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x001785B8 File Offset: 0x001767B8
		[DebuggerNonUserCode]
		public bool Equals(GetGoogleSettingsResponse other)
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
					bool flag4 = this.ClientId != other.ClientId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00178610 File Offset: 0x00176810
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x0017865C File Offset: 0x0017685C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x00178674 File Offset: 0x00176874
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x00178680 File Offset: 0x00176880
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x001786CC File Offset: 0x001768CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0017871C File Offset: 0x0017691C
		[DebuggerNonUserCode]
		public void MergeFrom(GetGoogleSettingsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x00178765 File Offset: 0x00176965
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00178770 File Offset: 0x00176970
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
					this.ClientId = input.ReadString();
				}
			}
		}

		// Token: 0x04002C58 RID: 11352
		private static readonly MessageParser<GetGoogleSettingsResponse> _parser = new MessageParser<GetGoogleSettingsResponse>(() => new GetGoogleSettingsResponse());

		// Token: 0x04002C59 RID: 11353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C5A RID: 11354
		public const int ClientIdFieldNumber = 1;

		// Token: 0x04002C5B RID: 11355
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x04002C5C RID: 11356
		private string clientId_;
	}
}
