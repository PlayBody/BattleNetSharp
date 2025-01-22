using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006ED RID: 1773
	public sealed class MemberState : IMessage<MemberState>, IMessage, IEquatable<MemberState>, IDeepCloneable<MemberState>, IBufferMessage
	{
		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A38D RID: 41869 RVA: 0x0027DD24 File Offset: 0x0027BF24
		[DebuggerNonUserCode]
		public static MessageParser<MemberState> Parser
		{
			get
			{
				return MemberState._parser;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x0027DD3C File Offset: 0x0027BF3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A38F RID: 41871 RVA: 0x0027DD60 File Offset: 0x0027BF60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberState.Descriptor;
			}
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x0027DD77 File Offset: 0x0027BF77
		[DebuggerNonUserCode]
		public MemberState()
		{
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x0027DD98 File Offset: 0x0027BF98
		[DebuggerNonUserCode]
		public MemberState(MemberState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.role_ = other.role_.Clone();
			this.privileges_ = other.privileges_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A392 RID: 41874 RVA: 0x0027DE14 File Offset: 0x0027C014
		[DebuggerNonUserCode]
		public MemberState Clone()
		{
			return new MemberState(this);
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A393 RID: 41875 RVA: 0x0027DE2C File Offset: 0x0027C02C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A394 RID: 41876 RVA: 0x0027DE44 File Offset: 0x0027C044
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x0027DE5C File Offset: 0x0027C05C
		// (set) Token: 0x0600A396 RID: 41878 RVA: 0x0027DE8D File Offset: 0x0027C08D
		[DebuggerNonUserCode]
		public ulong Privileges
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong privilegesDefaultValue;
				if (flag)
				{
					privilegesDefaultValue = this.privileges_;
				}
				else
				{
					privilegesDefaultValue = MemberState.PrivilegesDefaultValue;
				}
				return privilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privileges_ = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A397 RID: 41879 RVA: 0x0027DEA8 File Offset: 0x0027C0A8
		[DebuggerNonUserCode]
		public bool HasPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x0027DEC5 File Offset: 0x0027C0C5
		[DebuggerNonUserCode]
		public void ClearPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A399 RID: 41881 RVA: 0x0027DED8 File Offset: 0x0027C0D8
		// (set) Token: 0x0600A39A RID: 41882 RVA: 0x0027DEF0 File Offset: 0x0027C0F0
		[DebuggerNonUserCode]
		public MemberAccountInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x0600A39B RID: 41883 RVA: 0x0027DEFC File Offset: 0x0027C0FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberState);
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x0027DF1C File Offset: 0x0027C11C
		[DebuggerNonUserCode]
		public bool Equals(MemberState other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.role_.Equals(other.role_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Privileges != other.Privileges;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Info, other.Info);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x0027DFD4 File Offset: 0x0027C1D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			num ^= this.role_.GetHashCode();
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num ^= this.Privileges.GetHashCode();
			}
			bool flag = this.info_ != null;
			if (flag)
			{
				num ^= this.Info.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x0027E05C File Offset: 0x0027C25C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A39F RID: 41887 RVA: 0x0027E074 File Offset: 0x0027C274
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x0027E080 File Offset: 0x0027C280
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, MemberState._repeated_attribute_codec);
			this.role_.WriteTo(ref output, MemberState._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Privileges);
			}
			bool flag = this.info_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Info);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x0027E118 File Offset: 0x0027C318
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(MemberState._repeated_attribute_codec);
			num += this.role_.CalculateSize(MemberState._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
			}
			bool flag = this.info_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x0027E1B0 File Offset: 0x0027C3B0
		[DebuggerNonUserCode]
		public void MergeFrom(MemberState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this.role_.Add(other.role_);
				bool hasPrivileges = other.HasPrivileges;
				if (hasPrivileges)
				{
					this.Privileges = other.Privileges;
				}
				bool flag2 = other.info_ != null;
				if (flag2)
				{
					bool flag3 = this.info_ == null;
					if (flag3)
					{
						this.Info = new MemberAccountInfo();
					}
					this.Info.MergeFrom(other.Info);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x0027E25C File Offset: 0x0027C45C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x0027E268 File Offset: 0x0027C468
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						goto IL_005C;
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, MemberState._repeated_attribute_codec);
					}
				}
				else
				{
					if (num3 == 18U)
					{
						goto IL_005C;
					}
					if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							goto IL_0033;
						}
						bool flag = this.info_ == null;
						if (flag)
						{
							this.Info = new MemberAccountInfo();
						}
						input.ReadMessage(this.Info);
					}
					else
					{
						this.Privileges = input.ReadUInt64();
					}
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_005C:
				this.role_.AddEntriesFrom(ref input, MemberState._repeated_role_codec);
			}
		}

		// Token: 0x040049C2 RID: 18882
		private static readonly MessageParser<MemberState> _parser = new MessageParser<MemberState>(() => new MemberState());

		// Token: 0x040049C3 RID: 18883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C4 RID: 18884
		private int _hasBits0;

		// Token: 0x040049C5 RID: 18885
		public const int AttributeFieldNumber = 1;

		// Token: 0x040049C6 RID: 18886
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x040049C7 RID: 18887
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040049C8 RID: 18888
		public const int RoleFieldNumber = 2;

		// Token: 0x040049C9 RID: 18889
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040049CA RID: 18890
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x040049CB RID: 18891
		public const int PrivilegesFieldNumber = 3;

		// Token: 0x040049CC RID: 18892
		private static readonly ulong PrivilegesDefaultValue = 0UL;

		// Token: 0x040049CD RID: 18893
		private ulong privileges_;

		// Token: 0x040049CE RID: 18894
		public const int InfoFieldNumber = 4;

		// Token: 0x040049CF RID: 18895
		private MemberAccountInfo info_;
	}
}
