using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B7 RID: 951
	public sealed class ClearRecentPlayersRequest : IMessage<ClearRecentPlayersRequest>, IMessage, IEquatable<ClearRecentPlayersRequest>, IDeepCloneable<ClearRecentPlayersRequest>, IBufferMessage
	{
		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x00172668 File Offset: 0x00170868
		[DebuggerNonUserCode]
		public static MessageParser<ClearRecentPlayersRequest> Parser
		{
			get
			{
				return ClearRecentPlayersRequest._parser;
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x00172680 File Offset: 0x00170880
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06005F95 RID: 24469 RVA: 0x001726A4 File Offset: 0x001708A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearRecentPlayersRequest.Descriptor;
			}
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x001726BB File Offset: 0x001708BB
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest()
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x001726C8 File Offset: 0x001708C8
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest(ClearRecentPlayersRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00172724 File Offset: 0x00170924
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest Clone()
		{
			return new ClearRecentPlayersRequest(this);
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x0017273C File Offset: 0x0017093C
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x00172754 File Offset: 0x00170954
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

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x00172760 File Offset: 0x00170960
		// (set) Token: 0x06005F9C RID: 24476 RVA: 0x00172791 File Offset: 0x00170991
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ClearRecentPlayersRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x001727AC File Offset: 0x001709AC
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x001727C9 File Offset: 0x001709C9
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x001727DC File Offset: 0x001709DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClearRecentPlayersRequest);
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x001727FC File Offset: 0x001709FC
		[DebuggerNonUserCode]
		public bool Equals(ClearRecentPlayersRequest other)
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
						bool flag5 = this.Program != other.Program;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00172870 File Offset: 0x00170A70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x001728DC File Offset: 0x00170ADC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x001728F4 File Offset: 0x00170AF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00172900 File Offset: 0x00170B00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00172974 File Offset: 0x00170B74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x001729E4 File Offset: 0x00170BE4
		[DebuggerNonUserCode]
		public void MergeFrom(ClearRecentPlayersRequest other)
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
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00172A69 File Offset: 0x00170C69
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00172A74 File Offset: 0x00170C74
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Program = input.ReadUInt32();
					}
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
		}

		// Token: 0x04002BB2 RID: 11186
		private static readonly MessageParser<ClearRecentPlayersRequest> _parser = new MessageParser<ClearRecentPlayersRequest>(() => new ClearRecentPlayersRequest());

		// Token: 0x04002BB3 RID: 11187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB4 RID: 11188
		private int _hasBits0;

		// Token: 0x04002BB5 RID: 11189
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002BB6 RID: 11190
		private EntityId agentId_;

		// Token: 0x04002BB7 RID: 11191
		public const int ProgramFieldNumber = 2;

		// Token: 0x04002BB8 RID: 11192
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002BB9 RID: 11193
		private uint program_;
	}
}
