using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000410 RID: 1040
	public sealed class CreateFriendshipRequest : IMessage<CreateFriendshipRequest>, IMessage, IEquatable<CreateFriendshipRequest>, IDeepCloneable<CreateFriendshipRequest>, IBufferMessage
	{
		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x0018CF74 File Offset: 0x0018B174
		[DebuggerNonUserCode]
		public static MessageParser<CreateFriendshipRequest> Parser
		{
			get
			{
				return CreateFriendshipRequest._parser;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x0018CF8C File Offset: 0x0018B18C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x0018CFB0 File Offset: 0x0018B1B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateFriendshipRequest.Descriptor;
			}
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0018CFC7 File Offset: 0x0018B1C7
		[DebuggerNonUserCode]
		public CreateFriendshipRequest()
		{
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x0018CFDC File Offset: 0x0018B1DC
		[DebuggerNonUserCode]
		public CreateFriendshipRequest(CreateFriendshipRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x0018D04C File Offset: 0x0018B24C
		[DebuggerNonUserCode]
		public CreateFriendshipRequest Clone()
		{
			return new CreateFriendshipRequest(this);
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060066B7 RID: 26295 RVA: 0x0018D064 File Offset: 0x0018B264
		// (set) Token: 0x060066B8 RID: 26296 RVA: 0x0018D07C File Offset: 0x0018B27C
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x0018D088 File Offset: 0x0018B288
		// (set) Token: 0x060066BA RID: 26298 RVA: 0x0018D0A0 File Offset: 0x0018B2A0
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

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x060066BB RID: 26299 RVA: 0x0018D0AC File Offset: 0x0018B2AC
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x0018D0C4 File Offset: 0x0018B2C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateFriendshipRequest);
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0018D0E4 File Offset: 0x0018B2E4
		[DebuggerNonUserCode]
		public bool Equals(CreateFriendshipRequest other)
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
							bool flag6 = !this.role_.Equals(other.role_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x0018D17C File Offset: 0x0018B37C
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
			num ^= this.role_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x0018D1F4 File Offset: 0x0018B3F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x0018D20C File Offset: 0x0018B40C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x0018D218 File Offset: 0x0018B418
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
			this.role_.WriteTo(ref output, CreateFriendshipRequest._repeated_role_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0018D2A0 File Offset: 0x0018B4A0
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
			num += this.role_.CalculateSize(CreateFriendshipRequest._repeated_role_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x0018D328 File Offset: 0x0018B528
		[DebuggerNonUserCode]
		public void MergeFrom(CreateFriendshipRequest other)
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
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x0018D3E7 File Offset: 0x0018B5E7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x0018D3F4 File Offset: 0x0018B5F4
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
							goto IL_002C;
						}
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
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
				else
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_002C;
					}
					this.role_.AddEntriesFrom(ref input, CreateFriendshipRequest._repeated_role_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E97 RID: 11927
		private static readonly MessageParser<CreateFriendshipRequest> _parser = new MessageParser<CreateFriendshipRequest>(() => new CreateFriendshipRequest());

		// Token: 0x04002E98 RID: 11928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E99 RID: 11929
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E9A RID: 11930
		private EntityId agentId_;

		// Token: 0x04002E9B RID: 11931
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002E9C RID: 11932
		private EntityId targetId_;

		// Token: 0x04002E9D RID: 11933
		public const int RoleFieldNumber = 3;

		// Token: 0x04002E9E RID: 11934
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002E9F RID: 11935
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}
