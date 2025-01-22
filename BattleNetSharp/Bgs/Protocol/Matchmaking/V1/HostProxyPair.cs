using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E2 RID: 994
	public sealed class HostProxyPair : IMessage<HostProxyPair>, IMessage, IEquatable<HostProxyPair>, IDeepCloneable<HostProxyPair>, IBufferMessage
	{
		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x060062FD RID: 25341 RVA: 0x0017F36C File Offset: 0x0017D56C
		[DebuggerNonUserCode]
		public static MessageParser<HostProxyPair> Parser
		{
			get
			{
				return HostProxyPair._parser;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x0017F384 File Offset: 0x0017D584
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x060062FF RID: 25343 RVA: 0x0017F3A8 File Offset: 0x0017D5A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HostProxyPair.Descriptor;
			}
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x0017F3BF File Offset: 0x0017D5BF
		[DebuggerNonUserCode]
		public HostProxyPair()
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x0017F3CC File Offset: 0x0017D5CC
		[DebuggerNonUserCode]
		public HostProxyPair(HostProxyPair other)
			: this()
		{
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.proxy_ = ((other.proxy_ != null) ? other.proxy_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x0017F42C File Offset: 0x0017D62C
		[DebuggerNonUserCode]
		public HostProxyPair Clone()
		{
			return new HostProxyPair(this);
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06006303 RID: 25347 RVA: 0x0017F444 File Offset: 0x0017D644
		// (set) Token: 0x06006304 RID: 25348 RVA: 0x0017F45C File Offset: 0x0017D65C
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x0017F468 File Offset: 0x0017D668
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x0017F480 File Offset: 0x0017D680
		[DebuggerNonUserCode]
		public ProcessId Proxy
		{
			get
			{
				return this.proxy_;
			}
			set
			{
				this.proxy_ = value;
			}
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x0017F48C File Offset: 0x0017D68C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HostProxyPair);
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x0017F4AC File Offset: 0x0017D6AC
		[DebuggerNonUserCode]
		public bool Equals(HostProxyPair other)
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
					bool flag4 = !object.Equals(this.Host, other.Host);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Proxy, other.Proxy);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x0017F524 File Offset: 0x0017D724
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag2 = this.proxy_ != null;
			if (flag2)
			{
				num ^= this.Proxy.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x0017F590 File Offset: 0x0017D790
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x0017F5A8 File Offset: 0x0017D7A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x0017F5B4 File Offset: 0x0017D7B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Host);
			}
			bool flag2 = this.proxy_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Proxy);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x0017F628 File Offset: 0x0017D828
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag2 = this.proxy_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Proxy);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x0017F69C File Offset: 0x0017D89C
		[DebuggerNonUserCode]
		public void MergeFrom(HostProxyPair other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				bool flag4 = other.proxy_ != null;
				if (flag4)
				{
					bool flag5 = this.proxy_ == null;
					if (flag5)
					{
						this.Proxy = new ProcessId();
					}
					this.Proxy.MergeFrom(other.Proxy);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x0017F749 File Offset: 0x0017D949
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x0017F754 File Offset: 0x0017D954
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
						bool flag = this.proxy_ == null;
						if (flag)
						{
							this.Proxy = new ProcessId();
						}
						input.ReadMessage(this.Proxy);
					}
				}
				else
				{
					bool flag2 = this.host_ == null;
					if (flag2)
					{
						this.Host = new ProcessId();
					}
					input.ReadMessage(this.Host);
				}
			}
		}

		// Token: 0x04002D34 RID: 11572
		private static readonly MessageParser<HostProxyPair> _parser = new MessageParser<HostProxyPair>(() => new HostProxyPair());

		// Token: 0x04002D35 RID: 11573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D36 RID: 11574
		public const int HostFieldNumber = 1;

		// Token: 0x04002D37 RID: 11575
		private ProcessId host_;

		// Token: 0x04002D38 RID: 11576
		public const int ProxyFieldNumber = 2;

		// Token: 0x04002D39 RID: 11577
		private ProcessId proxy_;
	}
}
