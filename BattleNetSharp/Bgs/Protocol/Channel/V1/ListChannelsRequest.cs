using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D2 RID: 1746
	public sealed class ListChannelsRequest : IMessage<ListChannelsRequest>, IMessage, IEquatable<ListChannelsRequest>, IDeepCloneable<ListChannelsRequest>, IBufferMessage
	{
		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A12E RID: 41262 RVA: 0x00273618 File Offset: 0x00271818
		[DebuggerNonUserCode]
		public static MessageParser<ListChannelsRequest> Parser
		{
			get
			{
				return ListChannelsRequest._parser;
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A12F RID: 41263 RVA: 0x00273630 File Offset: 0x00271830
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x00273654 File Offset: 0x00271854
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelsRequest.Descriptor;
			}
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x0027366B File Offset: 0x0027186B
		[DebuggerNonUserCode]
		public ListChannelsRequest()
		{
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x00273678 File Offset: 0x00271878
		[DebuggerNonUserCode]
		public ListChannelsRequest(ListChannelsRequest other)
			: this()
		{
			this.agentIdentity_ = ((other.agentIdentity_ != null) ? other.agentIdentity_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x002736D8 File Offset: 0x002718D8
		[DebuggerNonUserCode]
		public ListChannelsRequest Clone()
		{
			return new ListChannelsRequest(this);
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x002736F0 File Offset: 0x002718F0
		// (set) Token: 0x0600A135 RID: 41269 RVA: 0x00273708 File Offset: 0x00271908
		[DebuggerNonUserCode]
		public Identity AgentIdentity
		{
			get
			{
				return this.agentIdentity_;
			}
			set
			{
				this.agentIdentity_ = value;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x00273714 File Offset: 0x00271914
		// (set) Token: 0x0600A137 RID: 41271 RVA: 0x0027372C File Offset: 0x0027192C
		[DebuggerNonUserCode]
		public ListChannelsOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x00273738 File Offset: 0x00271938
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelsRequest);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x00273758 File Offset: 0x00271958
		[DebuggerNonUserCode]
		public bool Equals(ListChannelsRequest other)
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
					bool flag4 = !object.Equals(this.AgentIdentity, other.AgentIdentity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x002737D0 File Offset: 0x002719D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num ^= this.AgentIdentity.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x0027383C File Offset: 0x00271A3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x00273854 File Offset: 0x00271A54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x00273860 File Offset: 0x00271A60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentIdentity);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x002738D4 File Offset: 0x00271AD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x00273948 File Offset: 0x00271B48
		[DebuggerNonUserCode]
		public void MergeFrom(ListChannelsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentIdentity_ != null;
				if (flag2)
				{
					bool flag3 = this.agentIdentity_ == null;
					if (flag3)
					{
						this.AgentIdentity = new Identity();
					}
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new ListChannelsOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x002739F5 File Offset: 0x00271BF5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x00273A00 File Offset: 0x00271C00
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
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new ListChannelsOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentIdentity_ == null;
					if (flag2)
					{
						this.AgentIdentity = new Identity();
					}
					input.ReadMessage(this.AgentIdentity);
				}
			}
		}

		// Token: 0x040048A0 RID: 18592
		private static readonly MessageParser<ListChannelsRequest> _parser = new MessageParser<ListChannelsRequest>(() => new ListChannelsRequest());

		// Token: 0x040048A1 RID: 18593
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A2 RID: 18594
		public const int AgentIdentityFieldNumber = 1;

		// Token: 0x040048A3 RID: 18595
		private Identity agentIdentity_;

		// Token: 0x040048A4 RID: 18596
		public const int OptionsFieldNumber = 2;

		// Token: 0x040048A5 RID: 18597
		private ListChannelsOptions options_;
	}
}
