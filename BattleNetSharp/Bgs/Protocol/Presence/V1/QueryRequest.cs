using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A3 RID: 1443
	public sealed class QueryRequest : IMessage<QueryRequest>, IMessage, IEquatable<QueryRequest>, IDeepCloneable<QueryRequest>, IBufferMessage
	{
		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x00215CC8 File Offset: 0x00213EC8
		[DebuggerNonUserCode]
		public static MessageParser<QueryRequest> Parser
		{
			get
			{
				return QueryRequest._parser;
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x00215CE0 File Offset: 0x00213EE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06008960 RID: 35168 RVA: 0x00215D04 File Offset: 0x00213F04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRequest.Descriptor;
			}
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x00215D1B File Offset: 0x00213F1B
		[DebuggerNonUserCode]
		public QueryRequest()
		{
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x00215D30 File Offset: 0x00213F30
		[DebuggerNonUserCode]
		public QueryRequest(QueryRequest other)
			: this()
		{
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.key_ = other.key_.Clone();
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x00215DA0 File Offset: 0x00213FA0
		[DebuggerNonUserCode]
		public QueryRequest Clone()
		{
			return new QueryRequest(this);
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06008964 RID: 35172 RVA: 0x00215DB8 File Offset: 0x00213FB8
		// (set) Token: 0x06008965 RID: 35173 RVA: 0x00215DD0 File Offset: 0x00213FD0
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

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x06008966 RID: 35174 RVA: 0x00215DDC File Offset: 0x00213FDC
		[DebuggerNonUserCode]
		public RepeatedField<FieldKey> Key
		{
			get
			{
				return this.key_;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x06008967 RID: 35175 RVA: 0x00215DF4 File Offset: 0x00213FF4
		// (set) Token: 0x06008968 RID: 35176 RVA: 0x00215E0C File Offset: 0x0021400C
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

		// Token: 0x06008969 RID: 35177 RVA: 0x00215E18 File Offset: 0x00214018
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRequest);
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x00215E38 File Offset: 0x00214038
		[DebuggerNonUserCode]
		public bool Equals(QueryRequest other)
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
						bool flag5 = !this.key_.Equals(other.key_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AgentId, other.AgentId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00215ED0 File Offset: 0x002140D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.key_.GetHashCode();
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

		// Token: 0x0600896C RID: 35180 RVA: 0x00215F48 File Offset: 0x00214148
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x00215F60 File Offset: 0x00214160
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x00215F6C File Offset: 0x0021416C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			this.key_.WriteTo(ref output, QueryRequest._repeated_key_codec);
			bool flag2 = this.agentId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AgentId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x00215FF4 File Offset: 0x002141F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			num += this.key_.CalculateSize(QueryRequest._repeated_key_codec);
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

		// Token: 0x06008970 RID: 35184 RVA: 0x0021607C File Offset: 0x0021427C
		[DebuggerNonUserCode]
		public void MergeFrom(QueryRequest other)
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
				this.key_.Add(other.key_);
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

		// Token: 0x06008971 RID: 35185 RVA: 0x0021613B File Offset: 0x0021433B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x00216148 File Offset: 0x00214348
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
						this.key_.AddEntriesFrom(ref input, QueryRequest._repeated_key_codec);
					}
				}
				else
				{
					bool flag2 = this.entityId_ == null;
					if (flag2)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04003E2B RID: 15915
		private static readonly MessageParser<QueryRequest> _parser = new MessageParser<QueryRequest>(() => new QueryRequest());

		// Token: 0x04003E2C RID: 15916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E2D RID: 15917
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E2E RID: 15918
		private EntityId entityId_;

		// Token: 0x04003E2F RID: 15919
		public const int KeyFieldNumber = 2;

		// Token: 0x04003E30 RID: 15920
		private static readonly FieldCodec<FieldKey> _repeated_key_codec = FieldCodec.ForMessage<FieldKey>(18U, FieldKey.Parser);

		// Token: 0x04003E31 RID: 15921
		private readonly RepeatedField<FieldKey> key_ = new RepeatedField<FieldKey>();

		// Token: 0x04003E32 RID: 15922
		public const int AgentIdFieldNumber = 3;

		// Token: 0x04003E33 RID: 15923
		private EntityId agentId_;
	}
}
