using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002BD RID: 701
	public sealed class ClanBanUpdate : IMessage<ClanBanUpdate>, IMessage, IEquatable<ClanBanUpdate>, IDeepCloneable<ClanBanUpdate>, IBufferMessage
	{
		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x0011E47C File Offset: 0x0011C67C
		[DebuggerNonUserCode]
		public static MessageParser<ClanBanUpdate> Parser
		{
			get
			{
				return ClanBanUpdate._parser;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x0011E494 File Offset: 0x0011C694
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004AB9 RID: 19129 RVA: 0x0011E4B8 File Offset: 0x0011C6B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBanUpdate.Descriptor;
			}
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0011E4CF File Offset: 0x0011C6CF
		[DebuggerNonUserCode]
		public ClanBanUpdate()
		{
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x0011E4F0 File Offset: 0x0011C6F0
		[DebuggerNonUserCode]
		public ClanBanUpdate(ClanBanUpdate other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this.addedBan_ = other.addedBan_.Clone();
			this.removedBan_ = other.removedBan_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x0011E544 File Offset: 0x0011C744
		[DebuggerNonUserCode]
		public ClanBanUpdate Clone()
		{
			return new ClanBanUpdate(this);
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x0011E55C File Offset: 0x0011C75C
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x0011E57D File Offset: 0x0011C77D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanBanUpdate.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x0011E594 File Offset: 0x0011C794
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x0011E5AF File Offset: 0x0011C7AF
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x0011E5BC File Offset: 0x0011C7BC
		[DebuggerNonUserCode]
		public RepeatedField<ClanBannedMember> AddedBan
		{
			get
			{
				return this.addedBan_;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0011E5D4 File Offset: 0x0011C7D4
		[DebuggerNonUserCode]
		public RepeatedField<uint> RemovedBan
		{
			get
			{
				return this.removedBan_;
			}
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0011E5EC File Offset: 0x0011C7EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBanUpdate);
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x0011E60C File Offset: 0x0011C80C
		[DebuggerNonUserCode]
		public bool Equals(ClanBanUpdate other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.addedBan_.Equals(other.addedBan_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.removedBan_.Equals(other.removedBan_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x0011E6A0 File Offset: 0x0011C8A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			num ^= this.addedBan_.GetHashCode();
			num ^= this.removedBan_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0011E708 File Offset: 0x0011C908
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0011E720 File Offset: 0x0011C920
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x0011E72C File Offset: 0x0011C92C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			this.addedBan_.WriteTo(ref output, ClanBanUpdate._repeated_addedBan_codec);
			this.removedBan_.WriteTo(ref output, ClanBanUpdate._repeated_removedBan_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0011E79C File Offset: 0x0011C99C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			num += this.addedBan_.CalculateSize(ClanBanUpdate._repeated_addedBan_codec);
			num += this.removedBan_.CalculateSize(ClanBanUpdate._repeated_removedBan_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0011E810 File Offset: 0x0011CA10
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBanUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this.addedBan_.Add(other.addedBan_);
				this.removedBan_.Add(other.removedBan_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0011E87D File Offset: 0x0011CA7D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0011E888 File Offset: 0x0011CA88
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
							goto IL_0029;
						}
						this.addedBan_.AddEntriesFrom(ref input, ClanBanUpdate._repeated_addedBan_codec);
					}
					else
					{
						this.ClanId = input.ReadString();
					}
				}
				else
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_0029;
					}
					this.removedBan_.AddEntriesFrom(ref input, ClanBanUpdate._repeated_removedBan_codec);
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002162 RID: 8546
		private static readonly MessageParser<ClanBanUpdate> _parser = new MessageParser<ClanBanUpdate>(() => new ClanBanUpdate());

		// Token: 0x04002163 RID: 8547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002164 RID: 8548
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04002165 RID: 8549
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04002166 RID: 8550
		private string clanId_;

		// Token: 0x04002167 RID: 8551
		public const int AddedBanFieldNumber = 2;

		// Token: 0x04002168 RID: 8552
		private static readonly FieldCodec<ClanBannedMember> _repeated_addedBan_codec = FieldCodec.ForMessage<ClanBannedMember>(18U, ClanBannedMember.Parser);

		// Token: 0x04002169 RID: 8553
		private readonly RepeatedField<ClanBannedMember> addedBan_ = new RepeatedField<ClanBannedMember>();

		// Token: 0x0400216A RID: 8554
		public const int RemovedBanFieldNumber = 3;

		// Token: 0x0400216B RID: 8555
		private static readonly FieldCodec<uint> _repeated_removedBan_codec = FieldCodec.ForUInt32(24U);

		// Token: 0x0400216C RID: 8556
		private readonly RepeatedField<uint> removedBan_ = new RepeatedField<uint>();
	}
}
