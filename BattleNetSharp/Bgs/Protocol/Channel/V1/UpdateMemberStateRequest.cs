using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DB RID: 1755
	public sealed class UpdateMemberStateRequest : IMessage<UpdateMemberStateRequest>, IMessage, IEquatable<UpdateMemberStateRequest>, IDeepCloneable<UpdateMemberStateRequest>, IBufferMessage
	{
		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A1CC RID: 41420 RVA: 0x00276118 File Offset: 0x00274318
		[DebuggerNonUserCode]
		public static MessageParser<UpdateMemberStateRequest> Parser
		{
			get
			{
				return UpdateMemberStateRequest._parser;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x00276130 File Offset: 0x00274330
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x00276154 File Offset: 0x00274354
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x0027616B File Offset: 0x0027436B
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest()
		{
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x0027618C File Offset: 0x0027438C
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest(UpdateMemberStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.stateChange_ = other.stateChange_.Clone();
			this.removedRole_ = other.removedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x002761F0 File Offset: 0x002743F0
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest Clone()
		{
			return new UpdateMemberStateRequest(this);
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x00276208 File Offset: 0x00274408
		// (set) Token: 0x0600A1D3 RID: 41427 RVA: 0x00276220 File Offset: 0x00274420
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

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A1D4 RID: 41428 RVA: 0x0027622C File Offset: 0x0027442C
		[DebuggerNonUserCode]
		public RepeatedField<Member> StateChange
		{
			get
			{
				return this.stateChange_;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x00276244 File Offset: 0x00274444
		[DebuggerNonUserCode]
		public RepeatedField<uint> RemovedRole
		{
			get
			{
				return this.removedRole_;
			}
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x0027625C File Offset: 0x0027445C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateRequest);
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0027627C File Offset: 0x0027447C
		[DebuggerNonUserCode]
		public bool Equals(UpdateMemberStateRequest other)
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
						bool flag5 = !this.stateChange_.Equals(other.stateChange_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.removedRole_.Equals(other.removedRole_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00276314 File Offset: 0x00274514
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			num ^= this.stateChange_.GetHashCode();
			num ^= this.removedRole_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x00276380 File Offset: 0x00274580
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x00276398 File Offset: 0x00274598
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x002763A4 File Offset: 0x002745A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			this.stateChange_.WriteTo(ref output, UpdateMemberStateRequest._repeated_stateChange_codec);
			this.removedRole_.WriteTo(ref output, UpdateMemberStateRequest._repeated_removedRole_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00276418 File Offset: 0x00274618
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			num += this.stateChange_.CalculateSize(UpdateMemberStateRequest._repeated_stateChange_codec);
			num += this.removedRole_.CalculateSize(UpdateMemberStateRequest._repeated_removedRole_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x00276490 File Offset: 0x00274690
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateMemberStateRequest other)
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
				this.stateChange_.Add(other.stateChange_);
				this.removedRole_.Add(other.removedRole_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x00276520 File Offset: 0x00274720
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x0027652C File Offset: 0x0027472C
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
						this.stateChange_.AddEntriesFrom(ref input, UpdateMemberStateRequest._repeated_stateChange_codec);
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
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
					this.removedRole_.AddEntriesFrom(ref input, UpdateMemberStateRequest._repeated_removedRole_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048E0 RID: 18656
		private static readonly MessageParser<UpdateMemberStateRequest> _parser = new MessageParser<UpdateMemberStateRequest>(() => new UpdateMemberStateRequest());

		// Token: 0x040048E1 RID: 18657
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048E2 RID: 18658
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048E3 RID: 18659
		private EntityId agentId_;

		// Token: 0x040048E4 RID: 18660
		public const int StateChangeFieldNumber = 2;

		// Token: 0x040048E5 RID: 18661
		private static readonly FieldCodec<Member> _repeated_stateChange_codec = FieldCodec.ForMessage<Member>(18U, Member.Parser);

		// Token: 0x040048E6 RID: 18662
		private readonly RepeatedField<Member> stateChange_ = new RepeatedField<Member>();

		// Token: 0x040048E7 RID: 18663
		public const int RemovedRoleFieldNumber = 3;

		// Token: 0x040048E8 RID: 18664
		private static readonly FieldCodec<uint> _repeated_removedRole_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x040048E9 RID: 18665
		private readonly RepeatedField<uint> removedRole_ = new RepeatedField<uint>();
	}
}
