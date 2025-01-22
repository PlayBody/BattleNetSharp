using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056F RID: 1391
	public sealed class BenefactorId : IMessage<BenefactorId>, IMessage, IEquatable<BenefactorId>, IDeepCloneable<BenefactorId>, IBufferMessage
	{
		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x002085A0 File Offset: 0x002067A0
		[DebuggerNonUserCode]
		public static MessageParser<BenefactorId> Parser
		{
			get
			{
				return BenefactorId._parser;
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x002085B8 File Offset: 0x002067B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x002085DC File Offset: 0x002067DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BenefactorId.Descriptor;
			}
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x002085F3 File Offset: 0x002067F3
		[DebuggerNonUserCode]
		public BenefactorId()
		{
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x00208604 File Offset: 0x00206804
		[DebuggerNonUserCode]
		public BenefactorId(BenefactorId other)
			: this()
		{
			BenefactorId.TypeOneofCase typeCase = other.TypeCase;
			BenefactorId.TypeOneofCase typeOneofCase = typeCase;
			if (typeOneofCase != BenefactorId.TypeOneofCase.Uuid)
			{
				if (typeOneofCase == BenefactorId.TypeOneofCase.ExternalId)
				{
					this.ExternalId = other.ExternalId;
				}
			}
			else
			{
				this.Uuid = other.Uuid;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x00208660 File Offset: 0x00206860
		[DebuggerNonUserCode]
		public BenefactorId Clone()
		{
			return new BenefactorId(this);
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x060085E2 RID: 34274 RVA: 0x00208678 File Offset: 0x00206878
		// (set) Token: 0x060085E3 RID: 34275 RVA: 0x002086A4 File Offset: 0x002068A4
		[DebuggerNonUserCode]
		public string Uuid
		{
			get
			{
				return this.HasUuid ? ((string)this.type_) : "";
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.typeCase_ = BenefactorId.TypeOneofCase.Uuid;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x002086C0 File Offset: 0x002068C0
		[DebuggerNonUserCode]
		public bool HasUuid
		{
			get
			{
				return this.typeCase_ == BenefactorId.TypeOneofCase.Uuid;
			}
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x002086DC File Offset: 0x002068DC
		[DebuggerNonUserCode]
		public void ClearUuid()
		{
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x00208700 File Offset: 0x00206900
		// (set) Token: 0x060085E7 RID: 34279 RVA: 0x00208728 File Offset: 0x00206928
		[DebuggerNonUserCode]
		public uint ExternalId
		{
			get
			{
				return this.HasExternalId ? ((uint)this.type_) : 0U;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = BenefactorId.TypeOneofCase.ExternalId;
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x00208740 File Offset: 0x00206940
		[DebuggerNonUserCode]
		public bool HasExternalId
		{
			get
			{
				return this.typeCase_ == BenefactorId.TypeOneofCase.ExternalId;
			}
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x0020875C File Offset: 0x0020695C
		[DebuggerNonUserCode]
		public void ClearExternalId()
		{
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x060085EA RID: 34282 RVA: 0x00208780 File Offset: 0x00206980
		[DebuggerNonUserCode]
		public BenefactorId.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x00208798 File Offset: 0x00206998
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = BenefactorId.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x002087AC File Offset: 0x002069AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BenefactorId);
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x002087CC File Offset: 0x002069CC
		[DebuggerNonUserCode]
		public bool Equals(BenefactorId other)
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
					bool flag4 = this.Uuid != other.Uuid;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ExternalId != other.ExternalId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TypeCase != other.TypeCase;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x00208858 File Offset: 0x00206A58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				num ^= this.Uuid.GetHashCode();
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				num ^= this.ExternalId.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x002088CC File Offset: 0x00206ACC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x002088E4 File Offset: 0x00206AE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x002088F0 File Offset: 0x00206AF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Uuid);
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ExternalId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x00208960 File Offset: 0x00206B60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Uuid);
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExternalId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x002089CC File Offset: 0x00206BCC
		[DebuggerNonUserCode]
		public void MergeFrom(BenefactorId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				BenefactorId.TypeOneofCase typeCase = other.TypeCase;
				BenefactorId.TypeOneofCase typeOneofCase = typeCase;
				if (typeOneofCase != BenefactorId.TypeOneofCase.Uuid)
				{
					if (typeOneofCase == BenefactorId.TypeOneofCase.ExternalId)
					{
						this.ExternalId = other.ExternalId;
					}
				}
				else
				{
					this.Uuid = other.Uuid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x00208A2F File Offset: 0x00206C2F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x00208A3C File Offset: 0x00206C3C
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
						this.ExternalId = input.ReadUInt32();
					}
				}
				else
				{
					this.Uuid = input.ReadString();
				}
			}
		}

		// Token: 0x04003CB8 RID: 15544
		private static readonly MessageParser<BenefactorId> _parser = new MessageParser<BenefactorId>(() => new BenefactorId());

		// Token: 0x04003CB9 RID: 15545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CBA RID: 15546
		public const int UuidFieldNumber = 1;

		// Token: 0x04003CBB RID: 15547
		public const int ExternalIdFieldNumber = 2;

		// Token: 0x04003CBC RID: 15548
		private object type_;

		// Token: 0x04003CBD RID: 15549
		private BenefactorId.TypeOneofCase typeCase_ = BenefactorId.TypeOneofCase.None;

		// Token: 0x02001042 RID: 4162
		public enum TypeOneofCase
		{
			// Token: 0x0400978E RID: 38798
			None,
			// Token: 0x0400978F RID: 38799
			Uuid,
			// Token: 0x04009790 RID: 38800
			ExternalId
		}
	}
}
