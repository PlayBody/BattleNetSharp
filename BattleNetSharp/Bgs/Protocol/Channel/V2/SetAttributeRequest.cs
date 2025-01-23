using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000666 RID: 1638
	public sealed class SetAttributeRequest : IMessage<SetAttributeRequest>, IMessage, IEquatable<SetAttributeRequest>, IDeepCloneable<SetAttributeRequest>, IBufferMessage
	{
		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600980A RID: 38922 RVA: 0x0024D1E0 File Offset: 0x0024B3E0
		[DebuggerNonUserCode]
		public static MessageParser<SetAttributeRequest> Parser
		{
			get
			{
				return SetAttributeRequest._parser;
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600980B RID: 38923 RVA: 0x0024D1F8 File Offset: 0x0024B3F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600980C RID: 38924 RVA: 0x0024D21C File Offset: 0x0024B41C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAttributeRequest.Descriptor;
			}
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x0024D233 File Offset: 0x0024B433
		[DebuggerNonUserCode]
		public SetAttributeRequest()
		{
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x0024D248 File Offset: 0x0024B448
		[DebuggerNonUserCode]
		public SetAttributeRequest(SetAttributeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x0024D2B8 File Offset: 0x0024B4B8
		[DebuggerNonUserCode]
		public SetAttributeRequest Clone()
		{
			return new SetAttributeRequest(this);
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009810 RID: 38928 RVA: 0x0024D2D0 File Offset: 0x0024B4D0
		// (set) Token: 0x06009811 RID: 38929 RVA: 0x0024D2E8 File Offset: 0x0024B4E8
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x0024D2F4 File Offset: 0x0024B4F4
		// (set) Token: 0x06009813 RID: 38931 RVA: 0x0024D30C File Offset: 0x0024B50C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x0024D318 File Offset: 0x0024B518
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x0024D330 File Offset: 0x0024B530
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAttributeRequest);
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x0024D350 File Offset: 0x0024B550
		[DebuggerNonUserCode]
		public bool Equals(SetAttributeRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x0024D3E8 File Offset: 0x0024B5E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0024D460 File Offset: 0x0024B660
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0024D478 File Offset: 0x0024B678
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x0024D484 File Offset: 0x0024B684
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			this.attribute_.WriteTo(ref output, SetAttributeRequest._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0024D50C File Offset: 0x0024B70C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			num += this.attribute_.CalculateSize(SetAttributeRequest._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x0024D594 File Offset: 0x0024B794
		[DebuggerNonUserCode]
		public void MergeFrom(SetAttributeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0024D653 File Offset: 0x0024B853
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x0024D660 File Offset: 0x0024B860
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
							this.attribute_.AddEntriesFrom(ref input, SetAttributeRequest._repeated_attribute_codec);
						}
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400447F RID: 17535
		private static readonly MessageParser<SetAttributeRequest> _parser = new MessageParser<SetAttributeRequest>(() => new SetAttributeRequest());

		// Token: 0x04004480 RID: 17536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004481 RID: 17537
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004482 RID: 17538
		private GameAccountHandle agentId_;

		// Token: 0x04004483 RID: 17539
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004484 RID: 17540
		private ChannelId channelId_;

		// Token: 0x04004485 RID: 17541
		public const int AttributeFieldNumber = 3;

		// Token: 0x04004486 RID: 17542
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004487 RID: 17543
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
