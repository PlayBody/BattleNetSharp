using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel
{
	// Token: 0x02000657 RID: 1623
	public sealed class ChannelRoleSet : IMessage<ChannelRoleSet>, IMessage, IEquatable<ChannelRoleSet>, IDeepCloneable<ChannelRoleSet>, IBufferMessage
	{
		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x00248664 File Offset: 0x00246864
		[DebuggerNonUserCode]
		public static MessageParser<ChannelRoleSet> Parser
		{
			get
			{
				return ChannelRoleSet._parser;
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600970D RID: 38669 RVA: 0x0024867C File Offset: 0x0024687C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelRoleSetReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x002486A0 File Offset: 0x002468A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelRoleSet.Descriptor;
			}
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x002486B7 File Offset: 0x002468B7
		[DebuggerNonUserCode]
		public ChannelRoleSet()
		{
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x002486D8 File Offset: 0x002468D8
		[DebuggerNonUserCode]
		public ChannelRoleSet(ChannelRoleSet other)
			: this()
		{
			this.role_ = other.role_.Clone();
			this.defaultRole_ = other.defaultRole_.Clone();
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x0024872C File Offset: 0x0024692C
		[DebuggerNonUserCode]
		public ChannelRoleSet Clone()
		{
			return new ChannelRoleSet(this);
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x00248744 File Offset: 0x00246944
		[DebuggerNonUserCode]
		public RepeatedField<ChannelRole> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x0024875C File Offset: 0x0024695C
		[DebuggerNonUserCode]
		public RepeatedField<uint> DefaultRole
		{
			get
			{
				return this.defaultRole_;
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x00248774 File Offset: 0x00246974
		// (set) Token: 0x06009715 RID: 38677 RVA: 0x00248795 File Offset: 0x00246995
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ChannelRoleSet.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x06009716 RID: 38678 RVA: 0x002487AC File Offset: 0x002469AC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x002487C7 File Offset: 0x002469C7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x002487D4 File Offset: 0x002469D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelRoleSet);
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x002487F4 File Offset: 0x002469F4
		[DebuggerNonUserCode]
		public bool Equals(ChannelRoleSet other)
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
					bool flag4 = !this.role_.Equals(other.role_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.defaultRole_.Equals(other.defaultRole_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x00248888 File Offset: 0x00246A88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.role_.GetHashCode();
			num ^= this.defaultRole_.GetHashCode();
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x002488F0 File Offset: 0x00246AF0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x00248908 File Offset: 0x00246B08
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x00248914 File Offset: 0x00246B14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.role_.WriteTo(ref output, ChannelRoleSet._repeated_role_codec);
			this.defaultRole_.WriteTo(ref output, ChannelRoleSet._repeated_defaultRole_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x00248984 File Offset: 0x00246B84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.role_.CalculateSize(ChannelRoleSet._repeated_role_codec);
			num += this.defaultRole_.CalculateSize(ChannelRoleSet._repeated_defaultRole_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x002489F8 File Offset: 0x00246BF8
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelRoleSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.role_.Add(other.role_);
				this.defaultRole_.Add(other.defaultRole_);
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x00248A65 File Offset: 0x00246C65
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x00248A70 File Offset: 0x00246C70
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
							goto IL_0029;
						}
						goto IL_0052;
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, ChannelRoleSet._repeated_role_codec);
					}
				}
				else
				{
					if (num3 == 18U)
					{
						goto IL_0052;
					}
					if (num3 != 26U)
					{
						goto IL_0029;
					}
					this.Name = input.ReadString();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0052:
				this.defaultRole_.AddEntriesFrom(ref input, ChannelRoleSet._repeated_defaultRole_codec);
			}
		}

		// Token: 0x04004419 RID: 17433
		private static readonly MessageParser<ChannelRoleSet> _parser = new MessageParser<ChannelRoleSet>(() => new ChannelRoleSet());

		// Token: 0x0400441A RID: 17434
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400441B RID: 17435
		public const int RoleFieldNumber = 1;

		// Token: 0x0400441C RID: 17436
		private static readonly FieldCodec<ChannelRole> _repeated_role_codec = FieldCodec.ForMessage<ChannelRole>(10U, ChannelRole.Parser);

		// Token: 0x0400441D RID: 17437
		private readonly RepeatedField<ChannelRole> role_ = new RepeatedField<ChannelRole>();

		// Token: 0x0400441E RID: 17438
		public const int DefaultRoleFieldNumber = 2;

		// Token: 0x0400441F RID: 17439
		private static readonly FieldCodec<uint> _repeated_defaultRole_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04004420 RID: 17440
		private readonly RepeatedField<uint> defaultRole_ = new RepeatedField<uint>();

		// Token: 0x04004421 RID: 17441
		public const int NameFieldNumber = 3;

		// Token: 0x04004422 RID: 17442
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004423 RID: 17443
		private string name_;
	}
}
