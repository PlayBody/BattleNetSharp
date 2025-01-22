using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042C RID: 1068
	public sealed class ConnectRequest : IMessage<ConnectRequest>, IMessage, IEquatable<ConnectRequest>, IDeepCloneable<ConnectRequest>, IBufferMessage
	{
		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x00196724 File Offset: 0x00194924
		[DebuggerNonUserCode]
		public static MessageParser<ConnectRequest> Parser
		{
			get
			{
				return ConnectRequest._parser;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x060068FA RID: 26874 RVA: 0x0019673C File Offset: 0x0019493C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x00196760 File Offset: 0x00194960
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectRequest.Descriptor;
			}
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x00196777 File Offset: 0x00194977
		[DebuggerNonUserCode]
		public ConnectRequest()
		{
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00196784 File Offset: 0x00194984
		[DebuggerNonUserCode]
		public ConnectRequest(ConnectRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientId_ = ((other.clientId_ != null) ? other.clientId_.Clone() : null);
			this.bindRequest_ = ((other.bindRequest_ != null) ? other.bindRequest_.Clone() : null);
			this.useBindlessRpc_ = other.useBindlessRpc_;
			this.meteringLevel_ = other.meteringLevel_;
			this.clientSdkInfo_ = ((other.clientSdkInfo_ != null) ? other.clientSdkInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00196824 File Offset: 0x00194A24
		[DebuggerNonUserCode]
		public ConnectRequest Clone()
		{
			return new ConnectRequest(this);
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x0019683C File Offset: 0x00194A3C
		// (set) Token: 0x06006900 RID: 26880 RVA: 0x00196854 File Offset: 0x00194A54
		[DebuggerNonUserCode]
		public ProcessId ClientId
		{
			get
			{
				return this.clientId_;
			}
			set
			{
				this.clientId_ = value;
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006901 RID: 26881 RVA: 0x00196860 File Offset: 0x00194A60
		// (set) Token: 0x06006902 RID: 26882 RVA: 0x00196878 File Offset: 0x00194A78
		[DebuggerNonUserCode]
		public BindRequest BindRequest
		{
			get
			{
				return this.bindRequest_;
			}
			set
			{
				this.bindRequest_ = value;
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x00196884 File Offset: 0x00194A84
		// (set) Token: 0x06006904 RID: 26884 RVA: 0x001968B5 File Offset: 0x00194AB5
		[DebuggerNonUserCode]
		public bool UseBindlessRpc
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool useBindlessRpcDefaultValue;
				if (flag)
				{
					useBindlessRpcDefaultValue = this.useBindlessRpc_;
				}
				else
				{
					useBindlessRpcDefaultValue = ConnectRequest.UseBindlessRpcDefaultValue;
				}
				return useBindlessRpcDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.useBindlessRpc_ = value;
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006905 RID: 26885 RVA: 0x001968D0 File Offset: 0x00194AD0
		[DebuggerNonUserCode]
		public bool HasUseBindlessRpc
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x001968ED File Offset: 0x00194AED
		[DebuggerNonUserCode]
		public void ClearUseBindlessRpc()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x00196900 File Offset: 0x00194B00
		// (set) Token: 0x06006908 RID: 26888 RVA: 0x00196931 File Offset: 0x00194B31
		[DebuggerNonUserCode]
		public MeteringLevel MeteringLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				MeteringLevel meteringLevelDefaultValue;
				if (flag)
				{
					meteringLevelDefaultValue = this.meteringLevel_;
				}
				else
				{
					meteringLevelDefaultValue = ConnectRequest.MeteringLevelDefaultValue;
				}
				return meteringLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.meteringLevel_ = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06006909 RID: 26889 RVA: 0x0019694C File Offset: 0x00194B4C
		[DebuggerNonUserCode]
		public bool HasMeteringLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00196969 File Offset: 0x00194B69
		[DebuggerNonUserCode]
		public void ClearMeteringLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x0019697C File Offset: 0x00194B7C
		// (set) Token: 0x0600690C RID: 26892 RVA: 0x00196994 File Offset: 0x00194B94
		[DebuggerNonUserCode]
		public ClientSdkVersionInfo ClientSdkInfo
		{
			get
			{
				return this.clientSdkInfo_;
			}
			set
			{
				this.clientSdkInfo_ = value;
			}
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x001969A0 File Offset: 0x00194BA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectRequest);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x001969C0 File Offset: 0x00194BC0
		[DebuggerNonUserCode]
		public bool Equals(ConnectRequest other)
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
					bool flag4 = !object.Equals(this.ClientId, other.ClientId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.BindRequest, other.BindRequest);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.UseBindlessRpc != other.UseBindlessRpc;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MeteringLevel != other.MeteringLevel;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ClientSdkInfo, other.ClientSdkInfo);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00196A94 File Offset: 0x00194C94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.clientId_ != null;
			if (flag)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool flag2 = this.bindRequest_ != null;
			if (flag2)
			{
				num ^= this.BindRequest.GetHashCode();
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				num ^= this.UseBindlessRpc.GetHashCode();
			}
			bool hasMeteringLevel = this.HasMeteringLevel;
			if (hasMeteringLevel)
			{
				num ^= this.MeteringLevel.GetHashCode();
			}
			bool flag3 = this.clientSdkInfo_ != null;
			if (flag3)
			{
				num ^= this.ClientSdkInfo.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00196B60 File Offset: 0x00194D60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00196B78 File Offset: 0x00194D78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00196B84 File Offset: 0x00194D84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.clientId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ClientId);
			}
			bool flag2 = this.bindRequest_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BindRequest);
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UseBindlessRpc);
			}
			bool hasMeteringLevel = this.HasMeteringLevel;
			if (hasMeteringLevel)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.MeteringLevel);
			}
			bool flag3 = this.clientSdkInfo_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ClientSdkInfo);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00196C68 File Offset: 0x00194E68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.clientId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientId);
			}
			bool flag2 = this.bindRequest_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BindRequest);
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				num += 2;
			}
			bool hasMeteringLevel = this.HasMeteringLevel;
			if (hasMeteringLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MeteringLevel);
			}
			bool flag3 = this.clientSdkInfo_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientSdkInfo);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00196D2C File Offset: 0x00194F2C
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.clientId_ != null;
				if (flag2)
				{
					bool flag3 = this.clientId_ == null;
					if (flag3)
					{
						this.ClientId = new ProcessId();
					}
					this.ClientId.MergeFrom(other.ClientId);
				}
				bool flag4 = other.bindRequest_ != null;
				if (flag4)
				{
					bool flag5 = this.bindRequest_ == null;
					if (flag5)
					{
						this.BindRequest = new BindRequest();
					}
					this.BindRequest.MergeFrom(other.BindRequest);
				}
				bool hasUseBindlessRpc = other.HasUseBindlessRpc;
				if (hasUseBindlessRpc)
				{
					this.UseBindlessRpc = other.UseBindlessRpc;
				}
				bool hasMeteringLevel = other.HasMeteringLevel;
				if (hasMeteringLevel)
				{
					this.MeteringLevel = other.MeteringLevel;
				}
				bool flag6 = other.clientSdkInfo_ != null;
				if (flag6)
				{
					bool flag7 = this.clientSdkInfo_ == null;
					if (flag7)
					{
						this.ClientSdkInfo = new ClientSdkVersionInfo();
					}
					this.ClientSdkInfo.MergeFrom(other.ClientSdkInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00196E4F File Offset: 0x0019504F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00196E5C File Offset: 0x0019505C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						bool flag = this.bindRequest_ == null;
						if (flag)
						{
							this.BindRequest = new BindRequest();
						}
						input.ReadMessage(this.BindRequest);
					}
					else
					{
						bool flag2 = this.clientId_ == null;
						if (flag2)
						{
							this.ClientId = new ProcessId();
						}
						input.ReadMessage(this.ClientId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						bool flag3 = this.clientSdkInfo_ == null;
						if (flag3)
						{
							this.ClientSdkInfo = new ClientSdkVersionInfo();
						}
						input.ReadMessage(this.ClientSdkInfo);
					}
					else
					{
						this.MeteringLevel = (MeteringLevel)input.ReadEnum();
					}
				}
				else
				{
					this.UseBindlessRpc = input.ReadBool();
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FC9 RID: 12233
		private static readonly MessageParser<ConnectRequest> _parser = new MessageParser<ConnectRequest>(() => new ConnectRequest());

		// Token: 0x04002FCA RID: 12234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FCB RID: 12235
		private int _hasBits0;

		// Token: 0x04002FCC RID: 12236
		public const int ClientIdFieldNumber = 1;

		// Token: 0x04002FCD RID: 12237
		private ProcessId clientId_;

		// Token: 0x04002FCE RID: 12238
		public const int BindRequestFieldNumber = 2;

		// Token: 0x04002FCF RID: 12239
		private BindRequest bindRequest_;

		// Token: 0x04002FD0 RID: 12240
		public const int UseBindlessRpcFieldNumber = 3;

		// Token: 0x04002FD1 RID: 12241
		private static readonly bool UseBindlessRpcDefaultValue = true;

		// Token: 0x04002FD2 RID: 12242
		private bool useBindlessRpc_;

		// Token: 0x04002FD3 RID: 12243
		public const int MeteringLevelFieldNumber = 4;

		// Token: 0x04002FD4 RID: 12244
		private static readonly MeteringLevel MeteringLevelDefaultValue = MeteringLevel.Legacy;

		// Token: 0x04002FD5 RID: 12245
		private MeteringLevel meteringLevel_;

		// Token: 0x04002FD6 RID: 12246
		public const int ClientSdkInfoFieldNumber = 5;

		// Token: 0x04002FD7 RID: 12247
		private ClientSdkVersionInfo clientSdkInfo_;
	}
}
