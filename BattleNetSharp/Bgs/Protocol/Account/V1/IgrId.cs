using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000751 RID: 1873
	public sealed class IgrId : IMessage<IgrId>, IMessage, IEquatable<IgrId>, IDeepCloneable<IgrId>, IBufferMessage
	{
		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x0029FD84 File Offset: 0x0029DF84
		[DebuggerNonUserCode]
		public static MessageParser<IgrId> Parser
		{
			get
			{
				return IgrId._parser;
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x0029FD9C File Offset: 0x0029DF9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x0029FDC0 File Offset: 0x0029DFC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IgrId.Descriptor;
			}
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x0029FDD7 File Offset: 0x0029DFD7
		[DebuggerNonUserCode]
		public IgrId()
		{
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x0029FDE8 File Offset: 0x0029DFE8
		[DebuggerNonUserCode]
		public IgrId(IgrId other)
			: this()
		{
			switch (other.TypeCase)
			{
			case IgrId.TypeOneofCase.GameAccount:
				this.GameAccount = other.GameAccount.Clone();
				break;
			case IgrId.TypeOneofCase.ExternalId:
				this.ExternalId = other.ExternalId;
				break;
			case IgrId.TypeOneofCase.Uuid:
				this.Uuid = other.Uuid;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x0029FE60 File Offset: 0x0029E060
		[DebuggerNonUserCode]
		public IgrId Clone()
		{
			return new IgrId(this);
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x0029FE78 File Offset: 0x0029E078
		// (set) Token: 0x0600AC77 RID: 44151 RVA: 0x0029FEA1 File Offset: 0x0029E0A1
		[DebuggerNonUserCode]
		public GameAccountHandle GameAccount
		{
			get
			{
				return (this.typeCase_ == IgrId.TypeOneofCase.GameAccount) ? ((GameAccountHandle)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? IgrId.TypeOneofCase.None : IgrId.TypeOneofCase.GameAccount);
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x0029FEB8 File Offset: 0x0029E0B8
		// (set) Token: 0x0600AC79 RID: 44153 RVA: 0x0029FEE0 File Offset: 0x0029E0E0
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
				this.typeCase_ = IgrId.TypeOneofCase.ExternalId;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600AC7A RID: 44154 RVA: 0x0029FEF8 File Offset: 0x0029E0F8
		[DebuggerNonUserCode]
		public bool HasExternalId
		{
			get
			{
				return this.typeCase_ == IgrId.TypeOneofCase.ExternalId;
			}
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x0029FF14 File Offset: 0x0029E114
		[DebuggerNonUserCode]
		public void ClearExternalId()
		{
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				this.ClearType();
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x0029FF38 File Offset: 0x0029E138
		// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x0029FF64 File Offset: 0x0029E164
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
				this.typeCase_ = IgrId.TypeOneofCase.Uuid;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x0029FF80 File Offset: 0x0029E180
		[DebuggerNonUserCode]
		public bool HasUuid
		{
			get
			{
				return this.typeCase_ == IgrId.TypeOneofCase.Uuid;
			}
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x0029FF9C File Offset: 0x0029E19C
		[DebuggerNonUserCode]
		public void ClearUuid()
		{
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				this.ClearType();
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x0029FFC0 File Offset: 0x0029E1C0
		[DebuggerNonUserCode]
		public IgrId.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x0029FFD8 File Offset: 0x0029E1D8
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = IgrId.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x0029FFEC File Offset: 0x0029E1EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IgrId);
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x002A000C File Offset: 0x0029E20C
		[DebuggerNonUserCode]
		public bool Equals(IgrId other)
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
					bool flag4 = !object.Equals(this.GameAccount, other.GameAccount);
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
							bool flag6 = this.Uuid != other.Uuid;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TypeCase != other.TypeCase;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x002A00BC File Offset: 0x0029E2BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.typeCase_ == IgrId.TypeOneofCase.GameAccount;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				num ^= this.ExternalId.GetHashCode();
			}
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				num ^= this.Uuid.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x002A014C File Offset: 0x0029E34C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x002A0164 File Offset: 0x0029E364
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x002A0170 File Offset: 0x0029E370
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.typeCase_ == IgrId.TypeOneofCase.GameAccount;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.ExternalId);
			}
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Uuid);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x002A0204 File Offset: 0x0029E404
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.typeCase_ == IgrId.TypeOneofCase.GameAccount;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				num += 5;
			}
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Uuid);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x002A0288 File Offset: 0x0029E488
		[DebuggerNonUserCode]
		public void MergeFrom(IgrId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				switch (other.TypeCase)
				{
				case IgrId.TypeOneofCase.GameAccount:
				{
					bool flag2 = this.GameAccount == null;
					if (flag2)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
					break;
				}
				case IgrId.TypeOneofCase.ExternalId:
					this.ExternalId = other.ExternalId;
					break;
				case IgrId.TypeOneofCase.Uuid:
					this.Uuid = other.Uuid;
					break;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x002A0327 File Offset: 0x0029E527
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x002A0334 File Offset: 0x0029E534
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
					if (num3 != 21U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Uuid = input.ReadString();
						}
					}
					else
					{
						this.ExternalId = input.ReadFixed32();
					}
				}
				else
				{
					GameAccountHandle gameAccountHandle = new GameAccountHandle();
					bool flag = this.typeCase_ == IgrId.TypeOneofCase.GameAccount;
					if (flag)
					{
						gameAccountHandle.MergeFrom(this.GameAccount);
					}
					input.ReadMessage(gameAccountHandle);
					this.GameAccount = gameAccountHandle;
				}
			}
		}

		// Token: 0x04004DAB RID: 19883
		private static readonly MessageParser<IgrId> _parser = new MessageParser<IgrId>(() => new IgrId());

		// Token: 0x04004DAC RID: 19884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DAD RID: 19885
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04004DAE RID: 19886
		public const int ExternalIdFieldNumber = 2;

		// Token: 0x04004DAF RID: 19887
		public const int UuidFieldNumber = 3;

		// Token: 0x04004DB0 RID: 19888
		private object type_;

		// Token: 0x04004DB1 RID: 19889
		private IgrId.TypeOneofCase typeCase_ = IgrId.TypeOneofCase.None;

		// Token: 0x02001265 RID: 4709
		public enum TypeOneofCase
		{
			// Token: 0x04009984 RID: 39300
			None,
			// Token: 0x04009985 RID: 39301
			GameAccount,
			// Token: 0x04009986 RID: 39302
			ExternalId,
			// Token: 0x04009987 RID: 39303
			Uuid
		}
	}
}
