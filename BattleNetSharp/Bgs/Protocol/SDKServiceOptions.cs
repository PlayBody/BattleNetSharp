using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037C RID: 892
	public sealed class SDKServiceOptions : IMessage<SDKServiceOptions>, IMessage, IEquatable<SDKServiceOptions>, IDeepCloneable<SDKServiceOptions>, IBufferMessage
	{
		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x00160010 File Offset: 0x0015E210
		[DebuggerNonUserCode]
		public static MessageParser<SDKServiceOptions> Parser
		{
			get
			{
				return SDKServiceOptions._parser;
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06005AFD RID: 23293 RVA: 0x00160028 File Offset: 0x0015E228
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServiceOptionsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x0016004C File Offset: 0x0015E24C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SDKServiceOptions.Descriptor;
			}
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00160063 File Offset: 0x0015E263
		[DebuggerNonUserCode]
		public SDKServiceOptions()
		{
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00160070 File Offset: 0x0015E270
		[DebuggerNonUserCode]
		public SDKServiceOptions(SDKServiceOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inbound_ = other.inbound_;
			this.outbound_ = other.outbound_;
			this.useClientId_ = other.useClientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x001600C8 File Offset: 0x0015E2C8
		[DebuggerNonUserCode]
		public SDKServiceOptions Clone()
		{
			return new SDKServiceOptions(this);
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x001600E0 File Offset: 0x0015E2E0
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x00160111 File Offset: 0x0015E311
		[DebuggerNonUserCode]
		public bool Inbound
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool inboundDefaultValue;
				if (flag)
				{
					inboundDefaultValue = this.inbound_;
				}
				else
				{
					inboundDefaultValue = SDKServiceOptions.InboundDefaultValue;
				}
				return inboundDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inbound_ = value;
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x0016012C File Offset: 0x0015E32C
		[DebuggerNonUserCode]
		public bool HasInbound
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x00160149 File Offset: 0x0015E349
		[DebuggerNonUserCode]
		public void ClearInbound()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x0016015C File Offset: 0x0015E35C
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x0016018D File Offset: 0x0015E38D
		[DebuggerNonUserCode]
		public bool Outbound
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool outboundDefaultValue;
				if (flag)
				{
					outboundDefaultValue = this.outbound_;
				}
				else
				{
					outboundDefaultValue = SDKServiceOptions.OutboundDefaultValue;
				}
				return outboundDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.outbound_ = value;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001601A8 File Offset: 0x0015E3A8
		[DebuggerNonUserCode]
		public bool HasOutbound
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x001601C5 File Offset: 0x0015E3C5
		[DebuggerNonUserCode]
		public void ClearOutbound()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06005B0A RID: 23306 RVA: 0x001601D8 File Offset: 0x0015E3D8
		// (set) Token: 0x06005B0B RID: 23307 RVA: 0x00160209 File Offset: 0x0015E409
		[DebuggerNonUserCode]
		public bool UseClientId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool useClientIdDefaultValue;
				if (flag)
				{
					useClientIdDefaultValue = this.useClientId_;
				}
				else
				{
					useClientIdDefaultValue = SDKServiceOptions.UseClientIdDefaultValue;
				}
				return useClientIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.useClientId_ = value;
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x00160224 File Offset: 0x0015E424
		[DebuggerNonUserCode]
		public bool HasUseClientId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00160241 File Offset: 0x0015E441
		[DebuggerNonUserCode]
		public void ClearUseClientId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00160254 File Offset: 0x0015E454
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SDKServiceOptions);
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x00160274 File Offset: 0x0015E474
		[DebuggerNonUserCode]
		public bool Equals(SDKServiceOptions other)
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
					bool flag4 = this.Inbound != other.Inbound;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Outbound != other.Outbound;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.UseClientId != other.UseClientId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x00160300 File Offset: 0x0015E500
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInbound = this.HasInbound;
			if (hasInbound)
			{
				num ^= this.Inbound.GetHashCode();
			}
			bool hasOutbound = this.HasOutbound;
			if (hasOutbound)
			{
				num ^= this.Outbound.GetHashCode();
			}
			bool hasUseClientId = this.HasUseClientId;
			if (hasUseClientId)
			{
				num ^= this.UseClientId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x0016038C File Offset: 0x0015E58C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x001603A4 File Offset: 0x0015E5A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x001603B0 File Offset: 0x0015E5B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInbound = this.HasInbound;
			if (hasInbound)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Inbound);
			}
			bool hasOutbound = this.HasOutbound;
			if (hasOutbound)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Outbound);
			}
			bool hasUseClientId = this.HasUseClientId;
			if (hasUseClientId)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UseClientId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x00160440 File Offset: 0x0015E640
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInbound = this.HasInbound;
			if (hasInbound)
			{
				num += 2;
			}
			bool hasOutbound = this.HasOutbound;
			if (hasOutbound)
			{
				num += 2;
			}
			bool hasUseClientId = this.HasUseClientId;
			if (hasUseClientId)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x001604A8 File Offset: 0x0015E6A8
		[DebuggerNonUserCode]
		public void MergeFrom(SDKServiceOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInbound = other.HasInbound;
				if (hasInbound)
				{
					this.Inbound = other.Inbound;
				}
				bool hasOutbound = other.HasOutbound;
				if (hasOutbound)
				{
					this.Outbound = other.Outbound;
				}
				bool hasUseClientId = other.HasUseClientId;
				if (hasUseClientId)
				{
					this.UseClientId = other.UseClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x00160523 File Offset: 0x0015E723
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00160530 File Offset: 0x0015E730
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UseClientId = input.ReadBool();
						}
					}
					else
					{
						this.Outbound = input.ReadBool();
					}
				}
				else
				{
					this.Inbound = input.ReadBool();
				}
			}
		}

		// Token: 0x0400297D RID: 10621
		private static readonly MessageParser<SDKServiceOptions> _parser = new MessageParser<SDKServiceOptions>(() => new SDKServiceOptions());

		// Token: 0x0400297E RID: 10622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400297F RID: 10623
		private int _hasBits0;

		// Token: 0x04002980 RID: 10624
		public const int InboundFieldNumber = 1;

		// Token: 0x04002981 RID: 10625
		private static readonly bool InboundDefaultValue = false;

		// Token: 0x04002982 RID: 10626
		private bool inbound_;

		// Token: 0x04002983 RID: 10627
		public const int OutboundFieldNumber = 2;

		// Token: 0x04002984 RID: 10628
		private static readonly bool OutboundDefaultValue = false;

		// Token: 0x04002985 RID: 10629
		private bool outbound_;

		// Token: 0x04002986 RID: 10630
		public const int UseClientIdFieldNumber = 3;

		// Token: 0x04002987 RID: 10631
		private static readonly bool UseClientIdDefaultValue = false;

		// Token: 0x04002988 RID: 10632
		private bool useClientId_;
	}
}
