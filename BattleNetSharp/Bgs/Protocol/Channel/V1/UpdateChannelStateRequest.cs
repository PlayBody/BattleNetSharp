using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DA RID: 1754
	public sealed class UpdateChannelStateRequest : IMessage<UpdateChannelStateRequest>, IMessage, IEquatable<UpdateChannelStateRequest>, IDeepCloneable<UpdateChannelStateRequest>, IBufferMessage
	{
		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x00275C6C File Offset: 0x00273E6C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateChannelStateRequest> Parser
		{
			get
			{
				return UpdateChannelStateRequest._parser;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x00275C84 File Offset: 0x00273E84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x00275CA8 File Offset: 0x00273EA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChannelStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x00275CBF File Offset: 0x00273EBF
		[DebuggerNonUserCode]
		public UpdateChannelStateRequest()
		{
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x00275CCC File Offset: 0x00273ECC
		[DebuggerNonUserCode]
		public UpdateChannelStateRequest(UpdateChannelStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.stateChange_ = ((other.stateChange_ != null) ? other.stateChange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x00275D2C File Offset: 0x00273F2C
		[DebuggerNonUserCode]
		public UpdateChannelStateRequest Clone()
		{
			return new UpdateChannelStateRequest(this);
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x00275D44 File Offset: 0x00273F44
		// (set) Token: 0x0600A1BE RID: 41406 RVA: 0x00275D5C File Offset: 0x00273F5C
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

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x00275D68 File Offset: 0x00273F68
		// (set) Token: 0x0600A1C0 RID: 41408 RVA: 0x00275D80 File Offset: 0x00273F80
		[DebuggerNonUserCode]
		public ChannelState StateChange
		{
			get
			{
				return this.stateChange_;
			}
			set
			{
				this.stateChange_ = value;
			}
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x00275D8C File Offset: 0x00273F8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChannelStateRequest);
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x00275DAC File Offset: 0x00273FAC
		[DebuggerNonUserCode]
		public bool Equals(UpdateChannelStateRequest other)
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
						bool flag5 = !object.Equals(this.StateChange, other.StateChange);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x00275E24 File Offset: 0x00274024
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				num ^= this.StateChange.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x00275E90 File Offset: 0x00274090
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x00275EA8 File Offset: 0x002740A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x00275EB4 File Offset: 0x002740B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StateChange);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00275F28 File Offset: 0x00274128
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StateChange);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x00275F9C File Offset: 0x0027419C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateChannelStateRequest other)
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
				bool flag4 = other.stateChange_ != null;
				if (flag4)
				{
					bool flag5 = this.stateChange_ == null;
					if (flag5)
					{
						this.StateChange = new ChannelState();
					}
					this.StateChange.MergeFrom(other.StateChange);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00276049 File Offset: 0x00274249
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x00276054 File Offset: 0x00274254
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
						bool flag = this.stateChange_ == null;
						if (flag)
						{
							this.StateChange = new ChannelState();
						}
						input.ReadMessage(this.StateChange);
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

		// Token: 0x040048DA RID: 18650
		private static readonly MessageParser<UpdateChannelStateRequest> _parser = new MessageParser<UpdateChannelStateRequest>(() => new UpdateChannelStateRequest());

		// Token: 0x040048DB RID: 18651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048DC RID: 18652
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048DD RID: 18653
		private EntityId agentId_;

		// Token: 0x040048DE RID: 18654
		public const int StateChangeFieldNumber = 2;

		// Token: 0x040048DF RID: 18655
		private ChannelState stateChange_;
	}
}
