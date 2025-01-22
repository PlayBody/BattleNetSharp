using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000551 RID: 1361
	public sealed class IgrId : IMessage<IgrId>, IMessage, IEquatable<IgrId>, IDeepCloneable<IgrId>, IBufferMessage
	{
		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x00200108 File Offset: 0x001FE308
		[DebuggerNonUserCode]
		public static MessageParser<IgrId> Parser
		{
			get
			{
				return IgrId._parser;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600839A RID: 33690 RVA: 0x00200120 File Offset: 0x001FE320
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x00200144 File Offset: 0x001FE344
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IgrId.Descriptor;
			}
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0020015B File Offset: 0x001FE35B
		[DebuggerNonUserCode]
		public IgrId()
		{
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x0020016C File Offset: 0x001FE36C
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

		// Token: 0x0600839E RID: 33694 RVA: 0x002001E4 File Offset: 0x001FE3E4
		[DebuggerNonUserCode]
		public IgrId Clone()
		{
			return new IgrId(this);
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x002001FC File Offset: 0x001FE3FC
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x00200225 File Offset: 0x001FE425
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

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0020023C File Offset: 0x001FE43C
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x00200264 File Offset: 0x001FE464
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

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0020027C File Offset: 0x001FE47C
		[DebuggerNonUserCode]
		public bool HasExternalId
		{
			get
			{
				return this.typeCase_ == IgrId.TypeOneofCase.ExternalId;
			}
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x00200298 File Offset: 0x001FE498
		[DebuggerNonUserCode]
		public void ClearExternalId()
		{
			bool hasExternalId = this.HasExternalId;
			if (hasExternalId)
			{
				this.ClearType();
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x060083A5 RID: 33701 RVA: 0x002002BC File Offset: 0x001FE4BC
		// (set) Token: 0x060083A6 RID: 33702 RVA: 0x002002E8 File Offset: 0x001FE4E8
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

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x060083A7 RID: 33703 RVA: 0x00200304 File Offset: 0x001FE504
		[DebuggerNonUserCode]
		public bool HasUuid
		{
			get
			{
				return this.typeCase_ == IgrId.TypeOneofCase.Uuid;
			}
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x00200320 File Offset: 0x001FE520
		[DebuggerNonUserCode]
		public void ClearUuid()
		{
			bool hasUuid = this.HasUuid;
			if (hasUuid)
			{
				this.ClearType();
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x060083A9 RID: 33705 RVA: 0x00200344 File Offset: 0x001FE544
		[DebuggerNonUserCode]
		public IgrId.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0020035C File Offset: 0x001FE55C
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = IgrId.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x00200370 File Offset: 0x001FE570
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IgrId);
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x00200390 File Offset: 0x001FE590
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

		// Token: 0x060083AD RID: 33709 RVA: 0x00200440 File Offset: 0x001FE640
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

		// Token: 0x060083AE RID: 33710 RVA: 0x002004D0 File Offset: 0x001FE6D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x002004E8 File Offset: 0x001FE6E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x002004F4 File Offset: 0x001FE6F4
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

		// Token: 0x060083B1 RID: 33713 RVA: 0x00200588 File Offset: 0x001FE788
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

		// Token: 0x060083B2 RID: 33714 RVA: 0x0020060C File Offset: 0x001FE80C
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

		// Token: 0x060083B3 RID: 33715 RVA: 0x002006AB File Offset: 0x001FE8AB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x002006B8 File Offset: 0x001FE8B8
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

		// Token: 0x04003BC7 RID: 15303
		private static readonly MessageParser<IgrId> _parser = new MessageParser<IgrId>(() => new IgrId());

		// Token: 0x04003BC8 RID: 15304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC9 RID: 15305
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04003BCA RID: 15306
		public const int ExternalIdFieldNumber = 2;

		// Token: 0x04003BCB RID: 15307
		public const int UuidFieldNumber = 3;

		// Token: 0x04003BCC RID: 15308
		private object type_;

		// Token: 0x04003BCD RID: 15309
		private IgrId.TypeOneofCase typeCase_ = IgrId.TypeOneofCase.None;

		// Token: 0x02001022 RID: 4130
		public enum TypeOneofCase
		{
			// Token: 0x0400976E RID: 38766
			None,
			// Token: 0x0400976F RID: 38767
			GameAccount,
			// Token: 0x04009770 RID: 38768
			ExternalId,
			// Token: 0x04009771 RID: 38769
			Uuid
		}
	}
}
