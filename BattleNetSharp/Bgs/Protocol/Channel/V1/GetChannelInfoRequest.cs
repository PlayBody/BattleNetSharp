using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D4 RID: 1748
	public sealed class GetChannelInfoRequest : IMessage<GetChannelInfoRequest>, IMessage, IEquatable<GetChannelInfoRequest>, IDeepCloneable<GetChannelInfoRequest>, IBufferMessage
	{
		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A155 RID: 41301 RVA: 0x00273DC0 File Offset: 0x00271FC0
		[DebuggerNonUserCode]
		public static MessageParser<GetChannelInfoRequest> Parser
		{
			get
			{
				return GetChannelInfoRequest._parser;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A156 RID: 41302 RVA: 0x00273DD8 File Offset: 0x00271FD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x00273DFC File Offset: 0x00271FFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChannelInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x00273E13 File Offset: 0x00272013
		[DebuggerNonUserCode]
		public GetChannelInfoRequest()
		{
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x00273E20 File Offset: 0x00272020
		[DebuggerNonUserCode]
		public GetChannelInfoRequest(GetChannelInfoRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00273E80 File Offset: 0x00272080
		[DebuggerNonUserCode]
		public GetChannelInfoRequest Clone()
		{
			return new GetChannelInfoRequest(this);
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A15B RID: 41307 RVA: 0x00273E98 File Offset: 0x00272098
		// (set) Token: 0x0600A15C RID: 41308 RVA: 0x00273EB0 File Offset: 0x002720B0
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A15D RID: 41309 RVA: 0x00273EBC File Offset: 0x002720BC
		// (set) Token: 0x0600A15E RID: 41310 RVA: 0x00273ED4 File Offset: 0x002720D4
		[DebuggerNonUserCode]
		public EntityId ChannelId
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

		// Token: 0x0600A15F RID: 41311 RVA: 0x00273EE0 File Offset: 0x002720E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChannelInfoRequest);
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x00273F00 File Offset: 0x00272100
		[DebuggerNonUserCode]
		public bool Equals(GetChannelInfoRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x00273F78 File Offset: 0x00272178
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00273FE4 File Offset: 0x002721E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00273FFC File Offset: 0x002721FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00274008 File Offset: 0x00272208
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x0027407C File Offset: 0x0027227C
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x002740F0 File Offset: 0x002722F0
		[DebuggerNonUserCode]
		public void MergeFrom(GetChannelInfoRequest other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x0027419D File Offset: 0x0027239D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x002741A8 File Offset: 0x002723A8
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
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040048AB RID: 18603
		private static readonly MessageParser<GetChannelInfoRequest> _parser = new MessageParser<GetChannelInfoRequest>(() => new GetChannelInfoRequest());

		// Token: 0x040048AC RID: 18604
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048AD RID: 18605
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048AE RID: 18606
		private EntityId agentId_;

		// Token: 0x040048AF RID: 18607
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040048B0 RID: 18608
		private EntityId channelId_;
	}
}
