using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066D RID: 1645
	public sealed class SetMemberAttributeRequest : IMessage<SetMemberAttributeRequest>, IMessage, IEquatable<SetMemberAttributeRequest>, IDeepCloneable<SetMemberAttributeRequest>, IBufferMessage
	{
		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x060098AC RID: 39084 RVA: 0x0024F9A4 File Offset: 0x0024DBA4
		[DebuggerNonUserCode]
		public static MessageParser<SetMemberAttributeRequest> Parser
		{
			get
			{
				return SetMemberAttributeRequest._parser;
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x0024F9BC File Offset: 0x0024DBBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x060098AE RID: 39086 RVA: 0x0024F9E0 File Offset: 0x0024DBE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMemberAttributeRequest.Descriptor;
			}
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x0024F9F7 File Offset: 0x0024DBF7
		[DebuggerNonUserCode]
		public SetMemberAttributeRequest()
		{
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x0024FA04 File Offset: 0x0024DC04
		[DebuggerNonUserCode]
		public SetMemberAttributeRequest(SetMemberAttributeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x0024FA80 File Offset: 0x0024DC80
		[DebuggerNonUserCode]
		public SetMemberAttributeRequest Clone()
		{
			return new SetMemberAttributeRequest(this);
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x060098B2 RID: 39090 RVA: 0x0024FA98 File Offset: 0x0024DC98
		// (set) Token: 0x060098B3 RID: 39091 RVA: 0x0024FAB0 File Offset: 0x0024DCB0
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

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x060098B4 RID: 39092 RVA: 0x0024FABC File Offset: 0x0024DCBC
		// (set) Token: 0x060098B5 RID: 39093 RVA: 0x0024FAD4 File Offset: 0x0024DCD4
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

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x060098B6 RID: 39094 RVA: 0x0024FAE0 File Offset: 0x0024DCE0
		// (set) Token: 0x060098B7 RID: 39095 RVA: 0x0024FAF8 File Offset: 0x0024DCF8
		[DebuggerNonUserCode]
		public AttributeAssignment Assignment
		{
			get
			{
				return this.assignment_;
			}
			set
			{
				this.assignment_ = value;
			}
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x0024FB04 File Offset: 0x0024DD04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMemberAttributeRequest);
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x0024FB24 File Offset: 0x0024DD24
		[DebuggerNonUserCode]
		public bool Equals(SetMemberAttributeRequest other)
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
							bool flag6 = !object.Equals(this.Assignment, other.Assignment);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x0024FBBC File Offset: 0x0024DDBC
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
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x0024FC44 File Offset: 0x0024DE44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x0024FC5C File Offset: 0x0024DE5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x0024FC68 File Offset: 0x0024DE68
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
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x0024FD04 File Offset: 0x0024DF04
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
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0024FD98 File Offset: 0x0024DF98
		[DebuggerNonUserCode]
		public void MergeFrom(SetMemberAttributeRequest other)
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
				bool flag6 = other.assignment_ != null;
				if (flag6)
				{
					bool flag7 = this.assignment_ == null;
					if (flag7)
					{
						this.Assignment = new AttributeAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x0024FE85 File Offset: 0x0024E085
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x0024FE90 File Offset: 0x0024E090
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
							bool flag = this.assignment_ == null;
							if (flag)
							{
								this.Assignment = new AttributeAssignment();
							}
							input.ReadMessage(this.Assignment);
						}
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044BA RID: 17594
		private static readonly MessageParser<SetMemberAttributeRequest> _parser = new MessageParser<SetMemberAttributeRequest>(() => new SetMemberAttributeRequest());

		// Token: 0x040044BB RID: 17595
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044BC RID: 17596
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044BD RID: 17597
		private GameAccountHandle agentId_;

		// Token: 0x040044BE RID: 17598
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044BF RID: 17599
		private ChannelId channelId_;

		// Token: 0x040044C0 RID: 17600
		public const int AssignmentFieldNumber = 3;

		// Token: 0x040044C1 RID: 17601
		private AttributeAssignment assignment_;
	}
}
