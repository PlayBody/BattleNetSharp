using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040D RID: 1037
	public sealed class UpdateFriendStateRequest : IMessage<UpdateFriendStateRequest>, IMessage, IEquatable<UpdateFriendStateRequest>, IDeepCloneable<UpdateFriendStateRequest>, IBufferMessage
	{
		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x0018C3A0 File Offset: 0x0018A5A0
		[DebuggerNonUserCode]
		public static MessageParser<UpdateFriendStateRequest> Parser
		{
			get
			{
				return UpdateFriendStateRequest._parser;
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x0018C3B8 File Offset: 0x0018A5B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x0018C3DC File Offset: 0x0018A5DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFriendStateRequest.Descriptor;
			}
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x0018C3F3 File Offset: 0x0018A5F3
		[DebuggerNonUserCode]
		public UpdateFriendStateRequest()
		{
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x0018C408 File Offset: 0x0018A608
		[DebuggerNonUserCode]
		public UpdateFriendStateRequest(UpdateFriendStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x0018C478 File Offset: 0x0018A678
		[DebuggerNonUserCode]
		public UpdateFriendStateRequest Clone()
		{
			return new UpdateFriendStateRequest(this);
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600667C RID: 26236 RVA: 0x0018C490 File Offset: 0x0018A690
		// (set) Token: 0x0600667D RID: 26237 RVA: 0x0018C4A8 File Offset: 0x0018A6A8
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

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600667E RID: 26238 RVA: 0x0018C4B4 File Offset: 0x0018A6B4
		// (set) Token: 0x0600667F RID: 26239 RVA: 0x0018C4CC File Offset: 0x0018A6CC
		[DebuggerNonUserCode]
		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x0018C4D8 File Offset: 0x0018A6D8
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x0018C4F0 File Offset: 0x0018A6F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFriendStateRequest);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x0018C510 File Offset: 0x0018A710
		[DebuggerNonUserCode]
		public bool Equals(UpdateFriendStateRequest other)
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
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
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

		// Token: 0x06006683 RID: 26243 RVA: 0x0018C5A8 File Offset: 0x0018A7A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x0018C620 File Offset: 0x0018A820
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x0018C638 File Offset: 0x0018A838
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x0018C644 File Offset: 0x0018A844
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			this.attribute_.WriteTo(ref output, UpdateFriendStateRequest._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x0018C6CC File Offset: 0x0018A8CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			num += this.attribute_.CalculateSize(UpdateFriendStateRequest._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x0018C754 File Offset: 0x0018A954
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateFriendStateRequest other)
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
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x0018C813 File Offset: 0x0018AA13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x0018C820 File Offset: 0x0018AA20
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
							this.attribute_.AddEntriesFrom(ref input, UpdateFriendStateRequest._repeated_attribute_codec);
						}
					}
					else
					{
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
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

		// Token: 0x04002E85 RID: 11909
		private static readonly MessageParser<UpdateFriendStateRequest> _parser = new MessageParser<UpdateFriendStateRequest>(() => new UpdateFriendStateRequest());

		// Token: 0x04002E86 RID: 11910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E87 RID: 11911
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E88 RID: 11912
		private EntityId agentId_;

		// Token: 0x04002E89 RID: 11913
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002E8A RID: 11914
		private EntityId targetId_;

		// Token: 0x04002E8B RID: 11915
		public const int AttributeFieldNumber = 3;

		// Token: 0x04002E8C RID: 11916
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002E8D RID: 11917
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
