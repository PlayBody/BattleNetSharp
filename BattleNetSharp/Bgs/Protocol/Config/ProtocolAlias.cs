using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Config
{
	// Token: 0x020003D7 RID: 983
	public sealed class ProtocolAlias : IMessage<ProtocolAlias>, IMessage, IEquatable<ProtocolAlias>, IDeepCloneable<ProtocolAlias>, IBufferMessage
	{
		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x0017CBE4 File Offset: 0x0017ADE4
		[DebuggerNonUserCode]
		public static MessageParser<ProtocolAlias> Parser
		{
			get
			{
				return ProtocolAlias._parser;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x0017CBFC File Offset: 0x0017ADFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x0017CC20 File Offset: 0x0017AE20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtocolAlias.Descriptor;
			}
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x0017CC37 File Offset: 0x0017AE37
		[DebuggerNonUserCode]
		public ProtocolAlias()
		{
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x0017CC41 File Offset: 0x0017AE41
		[DebuggerNonUserCode]
		public ProtocolAlias(ProtocolAlias other)
			: this()
		{
			this.serverServiceName_ = other.serverServiceName_;
			this.clientServiceName_ = other.clientServiceName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x0017CC74 File Offset: 0x0017AE74
		[DebuggerNonUserCode]
		public ProtocolAlias Clone()
		{
			return new ProtocolAlias(this);
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x0017CC8C File Offset: 0x0017AE8C
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x0017CCAD File Offset: 0x0017AEAD
		[DebuggerNonUserCode]
		public string ServerServiceName
		{
			get
			{
				return this.serverServiceName_ ?? ProtocolAlias.ServerServiceNameDefaultValue;
			}
			set
			{
				this.serverServiceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x0017CCC4 File Offset: 0x0017AEC4
		[DebuggerNonUserCode]
		public bool HasServerServiceName
		{
			get
			{
				return this.serverServiceName_ != null;
			}
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x0017CCDF File Offset: 0x0017AEDF
		[DebuggerNonUserCode]
		public void ClearServerServiceName()
		{
			this.serverServiceName_ = null;
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x0017CCEC File Offset: 0x0017AEEC
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x0017CD0D File Offset: 0x0017AF0D
		[DebuggerNonUserCode]
		public string ClientServiceName
		{
			get
			{
				return this.clientServiceName_ ?? ProtocolAlias.ClientServiceNameDefaultValue;
			}
			set
			{
				this.clientServiceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x0017CD24 File Offset: 0x0017AF24
		[DebuggerNonUserCode]
		public bool HasClientServiceName
		{
			get
			{
				return this.clientServiceName_ != null;
			}
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x0017CD3F File Offset: 0x0017AF3F
		[DebuggerNonUserCode]
		public void ClearClientServiceName()
		{
			this.clientServiceName_ = null;
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x0017CD4C File Offset: 0x0017AF4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProtocolAlias);
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x0017CD6C File Offset: 0x0017AF6C
		[DebuggerNonUserCode]
		public bool Equals(ProtocolAlias other)
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
					bool flag4 = this.ServerServiceName != other.ServerServiceName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClientServiceName != other.ClientServiceName;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x0017CDE0 File Offset: 0x0017AFE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasServerServiceName = this.HasServerServiceName;
			if (hasServerServiceName)
			{
				num ^= this.ServerServiceName.GetHashCode();
			}
			bool hasClientServiceName = this.HasClientServiceName;
			if (hasClientServiceName)
			{
				num ^= this.ClientServiceName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x0017CE44 File Offset: 0x0017B044
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x0017CE5C File Offset: 0x0017B05C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x0017CE68 File Offset: 0x0017B068
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServerServiceName = this.HasServerServiceName;
			if (hasServerServiceName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ServerServiceName);
			}
			bool hasClientServiceName = this.HasClientServiceName;
			if (hasClientServiceName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClientServiceName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x0017CED8 File Offset: 0x0017B0D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServerServiceName = this.HasServerServiceName;
			if (hasServerServiceName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerServiceName);
			}
			bool hasClientServiceName = this.HasClientServiceName;
			if (hasClientServiceName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientServiceName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x0017CF44 File Offset: 0x0017B144
		[DebuggerNonUserCode]
		public void MergeFrom(ProtocolAlias other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasServerServiceName = other.HasServerServiceName;
				if (hasServerServiceName)
				{
					this.ServerServiceName = other.ServerServiceName;
				}
				bool hasClientServiceName = other.HasClientServiceName;
				if (hasClientServiceName)
				{
					this.ClientServiceName = other.ClientServiceName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x0017CFA6 File Offset: 0x0017B1A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x0017CFB4 File Offset: 0x0017B1B4
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
						this.ClientServiceName = input.ReadString();
					}
				}
				else
				{
					this.ServerServiceName = input.ReadString();
				}
			}
		}

		// Token: 0x04002CF3 RID: 11507
		private static readonly MessageParser<ProtocolAlias> _parser = new MessageParser<ProtocolAlias>(() => new ProtocolAlias());

		// Token: 0x04002CF4 RID: 11508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF5 RID: 11509
		public const int ServerServiceNameFieldNumber = 1;

		// Token: 0x04002CF6 RID: 11510
		private static readonly string ServerServiceNameDefaultValue = "";

		// Token: 0x04002CF7 RID: 11511
		private string serverServiceName_;

		// Token: 0x04002CF8 RID: 11512
		public const int ClientServiceNameFieldNumber = 2;

		// Token: 0x04002CF9 RID: 11513
		private static readonly string ClientServiceNameDefaultValue = "";

		// Token: 0x04002CFA RID: 11514
		private string clientServiceName_;
	}
}
