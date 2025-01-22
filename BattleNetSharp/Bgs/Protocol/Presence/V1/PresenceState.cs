using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005B0 RID: 1456
	public sealed class PresenceState : IMessage<PresenceState>, IMessage, IEquatable<PresenceState>, IDeepCloneable<PresenceState>, IBufferMessage
	{
		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06008A6A RID: 35434 RVA: 0x00219C80 File Offset: 0x00217E80
		[DebuggerNonUserCode]
		public static MessageParser<PresenceState> Parser
		{
			get
			{
				return PresenceState._parser;
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x00219C98 File Offset: 0x00217E98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06008A6C RID: 35436 RVA: 0x00219CBC File Offset: 0x00217EBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceState.Descriptor;
			}
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x00219CD3 File Offset: 0x00217ED3
		[DebuggerNonUserCode]
		public PresenceState()
		{
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x00219CE8 File Offset: 0x00217EE8
		[DebuggerNonUserCode]
		public PresenceState(PresenceState other)
			: this()
		{
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.fieldOperation_ = other.fieldOperation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x00219D3C File Offset: 0x00217F3C
		[DebuggerNonUserCode]
		public PresenceState Clone()
		{
			return new PresenceState(this);
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06008A70 RID: 35440 RVA: 0x00219D54 File Offset: 0x00217F54
		// (set) Token: 0x06008A71 RID: 35441 RVA: 0x00219D6C File Offset: 0x00217F6C
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

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06008A72 RID: 35442 RVA: 0x00219D78 File Offset: 0x00217F78
		[DebuggerNonUserCode]
		public RepeatedField<FieldOperation> FieldOperation
		{
			get
			{
				return this.fieldOperation_;
			}
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x00219D90 File Offset: 0x00217F90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceState);
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x00219DB0 File Offset: 0x00217FB0
		[DebuggerNonUserCode]
		public bool Equals(PresenceState other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x00219E28 File Offset: 0x00218028
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x00219E84 File Offset: 0x00218084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x00219E9C File Offset: 0x0021809C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x00219EA8 File Offset: 0x002180A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			this.fieldOperation_.WriteTo(ref output, PresenceState._repeated_fieldOperation_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x00219F0C File Offset: 0x0021810C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			num += this.fieldOperation_.CalculateSize(PresenceState._repeated_fieldOperation_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x00219F70 File Offset: 0x00218170
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceState other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x00219FEE File Offset: 0x002181EE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x00219FFC File Offset: 0x002181FC
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
						this.fieldOperation_.AddEntriesFrom(ref input, PresenceState._repeated_fieldOperation_codec);
					}
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
		}

		// Token: 0x04003EA8 RID: 16040
		private static readonly MessageParser<PresenceState> _parser = new MessageParser<PresenceState>(() => new PresenceState());

		// Token: 0x04003EA9 RID: 16041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EAA RID: 16042
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003EAB RID: 16043
		private EntityId entityId_;

		// Token: 0x04003EAC RID: 16044
		public const int FieldOperationFieldNumber = 2;

		// Token: 0x04003EAD RID: 16045
		private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18U, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

		// Token: 0x04003EAE RID: 16046
		private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();
	}
}
