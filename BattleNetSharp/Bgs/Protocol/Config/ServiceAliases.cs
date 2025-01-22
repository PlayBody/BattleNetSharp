using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Config
{
	// Token: 0x020003D8 RID: 984
	public sealed class ServiceAliases : IMessage<ServiceAliases>, IMessage, IEquatable<ServiceAliases>, IDeepCloneable<ServiceAliases>, IBufferMessage
	{
		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x0017D04C File Offset: 0x0017B24C
		[DebuggerNonUserCode]
		public static MessageParser<ServiceAliases> Parser
		{
			get
			{
				return ServiceAliases._parser;
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x0017D064 File Offset: 0x0017B264
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x0017D088 File Offset: 0x0017B288
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServiceAliases.Descriptor;
			}
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x0017D09F File Offset: 0x0017B29F
		[DebuggerNonUserCode]
		public ServiceAliases()
		{
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x0017D0B4 File Offset: 0x0017B2B4
		[DebuggerNonUserCode]
		public ServiceAliases(ServiceAliases other)
			: this()
		{
			this.protocolAlias_ = other.protocolAlias_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x0017D0E0 File Offset: 0x0017B2E0
		[DebuggerNonUserCode]
		public ServiceAliases Clone()
		{
			return new ServiceAliases(this);
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x0017D0F8 File Offset: 0x0017B2F8
		[DebuggerNonUserCode]
		public RepeatedField<ProtocolAlias> ProtocolAlias
		{
			get
			{
				return this.protocolAlias_;
			}
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x0017D110 File Offset: 0x0017B310
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServiceAliases);
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x0017D130 File Offset: 0x0017B330
		[DebuggerNonUserCode]
		public bool Equals(ServiceAliases other)
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
					bool flag4 = !this.protocolAlias_.Equals(other.protocolAlias_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x0017D18C File Offset: 0x0017B38C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.protocolAlias_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x0017D1CC File Offset: 0x0017B3CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x0017D1E4 File Offset: 0x0017B3E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x0017D1F0 File Offset: 0x0017B3F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.protocolAlias_.WriteTo(ref output, ServiceAliases._repeated_protocolAlias_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x0017D22C File Offset: 0x0017B42C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.protocolAlias_.CalculateSize(ServiceAliases._repeated_protocolAlias_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x0017D274 File Offset: 0x0017B474
		[DebuggerNonUserCode]
		public void MergeFrom(ServiceAliases other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.protocolAlias_.Add(other.protocolAlias_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x0017D2B6 File Offset: 0x0017B4B6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x0017D2C4 File Offset: 0x0017B4C4
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
					this.protocolAlias_.AddEntriesFrom(ref input, ServiceAliases._repeated_protocolAlias_codec);
				}
			}
		}

		// Token: 0x04002CFB RID: 11515
		private static readonly MessageParser<ServiceAliases> _parser = new MessageParser<ServiceAliases>(() => new ServiceAliases());

		// Token: 0x04002CFC RID: 11516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CFD RID: 11517
		public const int ProtocolAliasFieldNumber = 1;

		// Token: 0x04002CFE RID: 11518
		private static readonly FieldCodec<ProtocolAlias> _repeated_protocolAlias_codec = FieldCodec.ForMessage<ProtocolAlias>(10U, Bgs.Protocol.Config.ProtocolAlias.Parser);

		// Token: 0x04002CFF RID: 11519
		private readonly RepeatedField<ProtocolAlias> protocolAlias_ = new RepeatedField<ProtocolAlias>();
	}
}
