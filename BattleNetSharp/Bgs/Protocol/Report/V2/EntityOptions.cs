using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x0200058B RID: 1419
	public sealed class EntityOptions : IMessage<EntityOptions>, IMessage, IEquatable<EntityOptions>, IDeepCloneable<EntityOptions>, IBufferMessage
	{
		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x060087E7 RID: 34791 RVA: 0x00210630 File Offset: 0x0020E830
		[DebuggerNonUserCode]
		public static MessageParser<EntityOptions> Parser
		{
			get
			{
				return EntityOptions._parser;
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x060087E8 RID: 34792 RVA: 0x00210648 File Offset: 0x0020E848
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x060087E9 RID: 34793 RVA: 0x0021066C File Offset: 0x0020E86C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOptions.Descriptor;
			}
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x00210683 File Offset: 0x0020E883
		[DebuggerNonUserCode]
		public EntityOptions()
		{
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x00210698 File Offset: 0x0020E898
		[DebuggerNonUserCode]
		public EntityOptions(EntityOptions other)
			: this()
		{
			this.entityId_ = other.entityId_;
			this.entityType_ = other.entityType_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x002106E8 File Offset: 0x0020E8E8
		[DebuggerNonUserCode]
		public EntityOptions Clone()
		{
			return new EntityOptions(this);
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x00210700 File Offset: 0x0020E900
		// (set) Token: 0x060087EE RID: 34798 RVA: 0x00210721 File Offset: 0x0020E921
		[DebuggerNonUserCode]
		public string EntityId
		{
			get
			{
				return this.entityId_ ?? EntityOptions.EntityIdDefaultValue;
			}
			set
			{
				this.entityId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x060087EF RID: 34799 RVA: 0x00210738 File Offset: 0x0020E938
		[DebuggerNonUserCode]
		public bool HasEntityId
		{
			get
			{
				return this.entityId_ != null;
			}
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x00210753 File Offset: 0x0020E953
		[DebuggerNonUserCode]
		public void ClearEntityId()
		{
			this.entityId_ = null;
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x060087F1 RID: 34801 RVA: 0x00210760 File Offset: 0x0020E960
		// (set) Token: 0x060087F2 RID: 34802 RVA: 0x00210781 File Offset: 0x0020E981
		[DebuggerNonUserCode]
		public string EntityType
		{
			get
			{
				return this.entityType_ ?? EntityOptions.EntityTypeDefaultValue;
			}
			set
			{
				this.entityType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x060087F3 RID: 34803 RVA: 0x00210798 File Offset: 0x0020E998
		[DebuggerNonUserCode]
		public bool HasEntityType
		{
			get
			{
				return this.entityType_ != null;
			}
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x002107B3 File Offset: 0x0020E9B3
		[DebuggerNonUserCode]
		public void ClearEntityType()
		{
			this.entityType_ = null;
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x002107C0 File Offset: 0x0020E9C0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x002107D8 File Offset: 0x0020E9D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOptions);
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x002107F8 File Offset: 0x0020E9F8
		[DebuggerNonUserCode]
		public bool Equals(EntityOptions other)
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
					bool flag4 = this.EntityId != other.EntityId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EntityType != other.EntityType;
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

		// Token: 0x060087F8 RID: 34808 RVA: 0x00210888 File Offset: 0x0020EA88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasEntityType = this.HasEntityType;
			if (hasEntityType)
			{
				num ^= this.EntityType.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x002108FC File Offset: 0x0020EAFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x00210914 File Offset: 0x0020EB14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x00210920 File Offset: 0x0020EB20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.EntityId);
			}
			bool hasEntityType = this.HasEntityType;
			if (hasEntityType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.EntityType);
			}
			this.attribute_.WriteTo(ref output, EntityOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x002109A0 File Offset: 0x0020EBA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntityId);
			}
			bool hasEntityType = this.HasEntityType;
			if (hasEntityType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntityType);
			}
			num += this.attribute_.CalculateSize(EntityOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x00210A20 File Offset: 0x0020EC20
		[DebuggerNonUserCode]
		public void MergeFrom(EntityOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEntityId = other.HasEntityId;
				if (hasEntityId)
				{
					this.EntityId = other.EntityId;
				}
				bool hasEntityType = other.HasEntityType;
				if (hasEntityType)
				{
					this.EntityType = other.EntityType;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00210A94 File Offset: 0x0020EC94
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x00210AA0 File Offset: 0x0020ECA0
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
						if (num3 != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, EntityOptions._repeated_attribute_codec);
						}
					}
					else
					{
						this.EntityType = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadString();
				}
			}
		}

		// Token: 0x04003D98 RID: 15768
		private static readonly MessageParser<EntityOptions> _parser = new MessageParser<EntityOptions>(() => new EntityOptions());

		// Token: 0x04003D99 RID: 15769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D9A RID: 15770
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D9B RID: 15771
		private static readonly string EntityIdDefaultValue = "";

		// Token: 0x04003D9C RID: 15772
		private string entityId_;

		// Token: 0x04003D9D RID: 15773
		public const int EntityTypeFieldNumber = 2;

		// Token: 0x04003D9E RID: 15774
		private static readonly string EntityTypeDefaultValue = "";

		// Token: 0x04003D9F RID: 15775
		private string entityType_;

		// Token: 0x04003DA0 RID: 15776
		public const int AttributeFieldNumber = 5;

		// Token: 0x04003DA1 RID: 15777
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003DA2 RID: 15778
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
