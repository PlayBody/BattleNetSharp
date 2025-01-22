using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A2 RID: 1442
	public sealed class UpdateRequest : IMessage<UpdateRequest>, IMessage, IEquatable<UpdateRequest>, IDeepCloneable<UpdateRequest>, IBufferMessage
	{
		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x06008944 RID: 35140 RVA: 0x00215614 File Offset: 0x00213814
		[DebuggerNonUserCode]
		public static MessageParser<UpdateRequest> Parser
		{
			get
			{
				return UpdateRequest._parser;
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x06008945 RID: 35141 RVA: 0x0021562C File Offset: 0x0021382C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x06008946 RID: 35142 RVA: 0x00215650 File Offset: 0x00213850
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRequest.Descriptor;
			}
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x00215667 File Offset: 0x00213867
		[DebuggerNonUserCode]
		public UpdateRequest()
		{
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x0021567C File Offset: 0x0021387C
		[DebuggerNonUserCode]
		public UpdateRequest(UpdateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.fieldOperation_ = other.fieldOperation_.Clone();
			this.noCreate_ = other.noCreate_;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x00215704 File Offset: 0x00213904
		[DebuggerNonUserCode]
		public UpdateRequest Clone()
		{
			return new UpdateRequest(this);
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x0021571C File Offset: 0x0021391C
		// (set) Token: 0x0600894B RID: 35147 RVA: 0x00215734 File Offset: 0x00213934
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x00215740 File Offset: 0x00213940
		[DebuggerNonUserCode]
		public RepeatedField<FieldOperation> FieldOperation
		{
			get
			{
				return this.fieldOperation_;
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600894D RID: 35149 RVA: 0x00215758 File Offset: 0x00213958
		// (set) Token: 0x0600894E RID: 35150 RVA: 0x00215789 File Offset: 0x00213989
		[DebuggerNonUserCode]
		public bool NoCreate
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool noCreateDefaultValue;
				if (flag)
				{
					noCreateDefaultValue = this.noCreate_;
				}
				else
				{
					noCreateDefaultValue = UpdateRequest.NoCreateDefaultValue;
				}
				return noCreateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.noCreate_ = value;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600894F RID: 35151 RVA: 0x002157A4 File Offset: 0x002139A4
		[DebuggerNonUserCode]
		public bool HasNoCreate
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x002157C1 File Offset: 0x002139C1
		[DebuggerNonUserCode]
		public void ClearNoCreate()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008951 RID: 35153 RVA: 0x002157D4 File Offset: 0x002139D4
		// (set) Token: 0x06008952 RID: 35154 RVA: 0x002157EC File Offset: 0x002139EC
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

		// Token: 0x06008953 RID: 35155 RVA: 0x002157F8 File Offset: 0x002139F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRequest);
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x00215818 File Offset: 0x00213A18
		[DebuggerNonUserCode]
		public bool Equals(UpdateRequest other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.fieldOperation_.Equals(other.fieldOperation_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NoCreate != other.NoCreate;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AgentId, other.AgentId);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x002158D0 File Offset: 0x00213AD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.fieldOperation_.GetHashCode();
			bool hasNoCreate = this.HasNoCreate;
			if (hasNoCreate)
			{
				num ^= this.NoCreate.GetHashCode();
			}
			bool flag2 = this.agentId_ != null;
			if (flag2)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x00215968 File Offset: 0x00213B68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x00215980 File Offset: 0x00213B80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x0021598C File Offset: 0x00213B8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			this.fieldOperation_.WriteTo(ref output, UpdateRequest._repeated_fieldOperation_codec);
			bool hasNoCreate = this.HasNoCreate;
			if (hasNoCreate)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NoCreate);
			}
			bool flag2 = this.agentId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AgentId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x00215A34 File Offset: 0x00213C34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			num += this.fieldOperation_.CalculateSize(UpdateRequest._repeated_fieldOperation_codec);
			bool hasNoCreate = this.HasNoCreate;
			if (hasNoCreate)
			{
				num += 2;
			}
			bool flag2 = this.agentId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x00215ACC File Offset: 0x00213CCC
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				this.fieldOperation_.Add(other.fieldOperation_);
				bool hasNoCreate = other.HasNoCreate;
				if (hasNoCreate)
				{
					this.NoCreate = other.NoCreate;
				}
				bool flag4 = other.agentId_ != null;
				if (flag4)
				{
					bool flag5 = this.agentId_ == null;
					if (flag5)
					{
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x00215BA6 File Offset: 0x00213DA6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x00215BB4 File Offset: 0x00213DB4
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
						this.fieldOperation_.AddEntriesFrom(ref input, UpdateRequest._repeated_fieldOperation_codec);
					}
					else
					{
						bool flag = this.entityId_ == null;
						if (flag)
						{
							this.EntityId = new EntityId();
						}
						input.ReadMessage(this.EntityId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
				else
				{
					this.NoCreate = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003E1E RID: 15902
		private static readonly MessageParser<UpdateRequest> _parser = new MessageParser<UpdateRequest>(() => new UpdateRequest());

		// Token: 0x04003E1F RID: 15903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E20 RID: 15904
		private int _hasBits0;

		// Token: 0x04003E21 RID: 15905
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E22 RID: 15906
		private EntityId entityId_;

		// Token: 0x04003E23 RID: 15907
		public const int FieldOperationFieldNumber = 2;

		// Token: 0x04003E24 RID: 15908
		private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18U, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

		// Token: 0x04003E25 RID: 15909
		private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();

		// Token: 0x04003E26 RID: 15910
		public const int NoCreateFieldNumber = 3;

		// Token: 0x04003E27 RID: 15911
		private static readonly bool NoCreateDefaultValue = false;

		// Token: 0x04003E28 RID: 15912
		private bool noCreate_;

		// Token: 0x04003E29 RID: 15913
		public const int AgentIdFieldNumber = 4;

		// Token: 0x04003E2A RID: 15914
		private EntityId agentId_;
	}
}
