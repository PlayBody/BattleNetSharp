using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059F RID: 1439
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x060088FD RID: 35069 RVA: 0x00214520 File Offset: 0x00212720
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x060088FE RID: 35070 RVA: 0x00214538 File Offset: 0x00212738
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x0021455C File Offset: 0x0021275C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x00214573 File Offset: 0x00212773
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x00214594 File Offset: 0x00212794
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this.program_ = other.program_.Clone();
			this.key_ = other.key_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x0021462C File Offset: 0x0021282C
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06008903 RID: 35075 RVA: 0x00214644 File Offset: 0x00212844
		// (set) Token: 0x06008904 RID: 35076 RVA: 0x0021465C File Offset: 0x0021285C
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

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x00214668 File Offset: 0x00212868
		// (set) Token: 0x06008906 RID: 35078 RVA: 0x00214680 File Offset: 0x00212880
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

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x0021468C File Offset: 0x0021288C
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x002146BD File Offset: 0x002128BD
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = SubscribeRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x002146D8 File Offset: 0x002128D8
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x002146F5 File Offset: 0x002128F5
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x00214708 File Offset: 0x00212908
		[DebuggerNonUserCode]
		public RepeatedField<uint> Program
		{
			get
			{
				return this.program_;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x00214720 File Offset: 0x00212920
		[DebuggerNonUserCode]
		public RepeatedField<FieldKey> Key
		{
			get
			{
				return this.key_;
			}
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x00214738 File Offset: 0x00212938
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x00214758 File Offset: 0x00212958
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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
						bool flag5 = !object.Equals(this.EntityId, other.EntityId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ObjectId != other.ObjectId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.program_.Equals(other.program_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.key_.Equals(other.key_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x00214830 File Offset: 0x00212A30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			num ^= this.program_.GetHashCode();
			num ^= this.key_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x002148D4 File Offset: 0x00212AD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x002148EC File Offset: 0x00212AEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x002148F8 File Offset: 0x00212AF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ObjectId);
			}
			this.program_.WriteTo(ref output, SubscribeRequest._repeated_program_codec);
			this.key_.WriteTo(ref output, SubscribeRequest._repeated_key_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x002149B4 File Offset: 0x00212BB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			num += this.program_.CalculateSize(SubscribeRequest._repeated_program_codec);
			num += this.key_.CalculateSize(SubscribeRequest._repeated_key_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x00214A6C File Offset: 0x00212C6C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
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
				bool flag4 = other.entityId_ != null;
				if (flag4)
				{
					bool flag5 = this.entityId_ == null;
					if (flag5)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this.program_.Add(other.program_);
				this.key_.Add(other.key_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x00214B58 File Offset: 0x00212D58
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x00214B64 File Offset: 0x00212D64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.ObjectId = input.ReadUInt64();
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
				else if (num3 != 34U && num3 != 37U)
				{
					if (num3 != 50U)
					{
						goto IL_0046;
					}
					this.key_.AddEntriesFrom(ref input, SubscribeRequest._repeated_key_codec);
				}
				else
				{
					this.program_.AddEntriesFrom(ref input, SubscribeRequest._repeated_program_codec);
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003E00 RID: 15872
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04003E01 RID: 15873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E02 RID: 15874
		private int _hasBits0;

		// Token: 0x04003E03 RID: 15875
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003E04 RID: 15876
		private EntityId agentId_;

		// Token: 0x04003E05 RID: 15877
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003E06 RID: 15878
		private EntityId entityId_;

		// Token: 0x04003E07 RID: 15879
		public const int ObjectIdFieldNumber = 3;

		// Token: 0x04003E08 RID: 15880
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04003E09 RID: 15881
		private ulong objectId_;

		// Token: 0x04003E0A RID: 15882
		public const int ProgramFieldNumber = 4;

		// Token: 0x04003E0B RID: 15883
		private static readonly FieldCodec<uint> _repeated_program_codec = FieldCodec.ForFixed32(37U);

		// Token: 0x04003E0C RID: 15884
		private readonly RepeatedField<uint> program_ = new RepeatedField<uint>();

		// Token: 0x04003E0D RID: 15885
		public const int KeyFieldNumber = 6;

		// Token: 0x04003E0E RID: 15886
		private static readonly FieldCodec<FieldKey> _repeated_key_codec = FieldCodec.ForMessage<FieldKey>(50U, FieldKey.Parser);

		// Token: 0x04003E0F RID: 15887
		private readonly RepeatedField<FieldKey> key_ = new RepeatedField<FieldKey>();
	}
}
