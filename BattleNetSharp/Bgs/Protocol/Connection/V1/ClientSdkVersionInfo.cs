using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042B RID: 1067
	public sealed class ClientSdkVersionInfo : IMessage<ClientSdkVersionInfo>, IMessage, IEquatable<ClientSdkVersionInfo>, IDeepCloneable<ClientSdkVersionInfo>, IBufferMessage
	{
		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x0019615C File Offset: 0x0019435C
		[DebuggerNonUserCode]
		public static MessageParser<ClientSdkVersionInfo> Parser
		{
			get
			{
				return ClientSdkVersionInfo._parser;
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x00196174 File Offset: 0x00194374
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x00196198 File Offset: 0x00194398
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientSdkVersionInfo.Descriptor;
			}
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x001961AF File Offset: 0x001943AF
		[DebuggerNonUserCode]
		public ClientSdkVersionInfo()
		{
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x001961BC File Offset: 0x001943BC
		[DebuggerNonUserCode]
		public ClientSdkVersionInfo(ClientSdkVersionInfo other)
			: this()
		{
			this.sdkName_ = other.sdkName_;
			this.sdkVersion_ = ((other.sdkVersion_ != null) ? other.sdkVersion_.Clone() : null);
			this.protocolVersion_ = ((other.protocolVersion_ != null) ? other.protocolVersion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00196228 File Offset: 0x00194428
		[DebuggerNonUserCode]
		public ClientSdkVersionInfo Clone()
		{
			return new ClientSdkVersionInfo(this);
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x00196240 File Offset: 0x00194440
		// (set) Token: 0x060068E7 RID: 26855 RVA: 0x00196261 File Offset: 0x00194461
		[DebuggerNonUserCode]
		public string SdkName
		{
			get
			{
				return this.sdkName_ ?? ClientSdkVersionInfo.SdkNameDefaultValue;
			}
			set
			{
				this.sdkName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x060068E8 RID: 26856 RVA: 0x00196278 File Offset: 0x00194478
		[DebuggerNonUserCode]
		public bool HasSdkName
		{
			get
			{
				return this.sdkName_ != null;
			}
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00196293 File Offset: 0x00194493
		[DebuggerNonUserCode]
		public void ClearSdkName()
		{
			this.sdkName_ = null;
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x001962A0 File Offset: 0x001944A0
		// (set) Token: 0x060068EB RID: 26859 RVA: 0x001962B8 File Offset: 0x001944B8
		[DebuggerNonUserCode]
		public SemanticVersion SdkVersion
		{
			get
			{
				return this.sdkVersion_;
			}
			set
			{
				this.sdkVersion_ = value;
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x060068EC RID: 26860 RVA: 0x001962C4 File Offset: 0x001944C4
		// (set) Token: 0x060068ED RID: 26861 RVA: 0x001962DC File Offset: 0x001944DC
		[DebuggerNonUserCode]
		public SemanticVersion ProtocolVersion
		{
			get
			{
				return this.protocolVersion_;
			}
			set
			{
				this.protocolVersion_ = value;
			}
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x001962E8 File Offset: 0x001944E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientSdkVersionInfo);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00196308 File Offset: 0x00194508
		[DebuggerNonUserCode]
		public bool Equals(ClientSdkVersionInfo other)
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
					bool flag4 = this.SdkName != other.SdkName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SdkVersion, other.SdkVersion);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ProtocolVersion, other.ProtocolVersion);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x0019639C File Offset: 0x0019459C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSdkName = this.HasSdkName;
			if (hasSdkName)
			{
				num ^= this.SdkName.GetHashCode();
			}
			bool flag = this.sdkVersion_ != null;
			if (flag)
			{
				num ^= this.SdkVersion.GetHashCode();
			}
			bool flag2 = this.protocolVersion_ != null;
			if (flag2)
			{
				num ^= this.ProtocolVersion.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00196420 File Offset: 0x00194620
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00196438 File Offset: 0x00194638
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00196444 File Offset: 0x00194644
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSdkName = this.HasSdkName;
			if (hasSdkName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SdkName);
			}
			bool flag = this.sdkVersion_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SdkVersion);
			}
			bool flag2 = this.protocolVersion_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ProtocolVersion);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x001964DC File Offset: 0x001946DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSdkName = this.HasSdkName;
			if (hasSdkName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SdkName);
			}
			bool flag = this.sdkVersion_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SdkVersion);
			}
			bool flag2 = this.protocolVersion_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ProtocolVersion);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x0019656C File Offset: 0x0019476C
		[DebuggerNonUserCode]
		public void MergeFrom(ClientSdkVersionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSdkName = other.HasSdkName;
				if (hasSdkName)
				{
					this.SdkName = other.SdkName;
				}
				bool flag2 = other.sdkVersion_ != null;
				if (flag2)
				{
					bool flag3 = this.sdkVersion_ == null;
					if (flag3)
					{
						this.SdkVersion = new SemanticVersion();
					}
					this.SdkVersion.MergeFrom(other.SdkVersion);
				}
				bool flag4 = other.protocolVersion_ != null;
				if (flag4)
				{
					bool flag5 = this.protocolVersion_ == null;
					if (flag5)
					{
						this.ProtocolVersion = new SemanticVersion();
					}
					this.ProtocolVersion.MergeFrom(other.ProtocolVersion);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x00196634 File Offset: 0x00194834
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x00196640 File Offset: 0x00194840
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
							bool flag = this.protocolVersion_ == null;
							if (flag)
							{
								this.ProtocolVersion = new SemanticVersion();
							}
							input.ReadMessage(this.ProtocolVersion);
						}
					}
					else
					{
						bool flag2 = this.sdkVersion_ == null;
						if (flag2)
						{
							this.SdkVersion = new SemanticVersion();
						}
						input.ReadMessage(this.SdkVersion);
					}
				}
				else
				{
					this.SdkName = input.ReadString();
				}
			}
		}

		// Token: 0x04002FC0 RID: 12224
		private static readonly MessageParser<ClientSdkVersionInfo> _parser = new MessageParser<ClientSdkVersionInfo>(() => new ClientSdkVersionInfo());

		// Token: 0x04002FC1 RID: 12225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC2 RID: 12226
		public const int SdkNameFieldNumber = 1;

		// Token: 0x04002FC3 RID: 12227
		private static readonly string SdkNameDefaultValue = "";

		// Token: 0x04002FC4 RID: 12228
		private string sdkName_;

		// Token: 0x04002FC5 RID: 12229
		public const int SdkVersionFieldNumber = 2;

		// Token: 0x04002FC6 RID: 12230
		private SemanticVersion sdkVersion_;

		// Token: 0x04002FC7 RID: 12231
		public const int ProtocolVersionFieldNumber = 3;

		// Token: 0x04002FC8 RID: 12232
		private SemanticVersion protocolVersion_;
	}
}
