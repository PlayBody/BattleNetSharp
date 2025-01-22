using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000454 RID: 1108
	public sealed class ClubSlot : IMessage<ClubSlot>, IMessage, IEquatable<ClubSlot>, IDeepCloneable<ClubSlot>, IBufferMessage
	{
		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06006C40 RID: 27712 RVA: 0x001A4CD0 File Offset: 0x001A2ED0
		[DebuggerNonUserCode]
		public static MessageParser<ClubSlot> Parser
		{
			get
			{
				return ClubSlot._parser;
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06006C41 RID: 27713 RVA: 0x001A4CE8 File Offset: 0x001A2EE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x001A4D0C File Offset: 0x001A2F0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSlot.Descriptor;
			}
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x001A4D23 File Offset: 0x001A2F23
		[DebuggerNonUserCode]
		public ClubSlot()
		{
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x001A4D2D File Offset: 0x001A2F2D
		[DebuggerNonUserCode]
		public ClubSlot(ClubSlot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.role_ = other.role_;
			this.defaultStreamId_ = other.defaultStreamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x001A4D6C File Offset: 0x001A2F6C
		[DebuggerNonUserCode]
		public ClubSlot Clone()
		{
			return new ClubSlot(this);
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06006C46 RID: 27718 RVA: 0x001A4D84 File Offset: 0x001A2F84
		// (set) Token: 0x06006C47 RID: 27719 RVA: 0x001A4DB5 File Offset: 0x001A2FB5
		[DebuggerNonUserCode]
		public uint Role
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint roleDefaultValue;
				if (flag)
				{
					roleDefaultValue = this.role_;
				}
				else
				{
					roleDefaultValue = ClubSlot.RoleDefaultValue;
				}
				return roleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.role_ = value;
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x001A4DD0 File Offset: 0x001A2FD0
		[DebuggerNonUserCode]
		public bool HasRole
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x001A4DED File Offset: 0x001A2FED
		[DebuggerNonUserCode]
		public void ClearRole()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06006C4A RID: 27722 RVA: 0x001A4E00 File Offset: 0x001A3000
		// (set) Token: 0x06006C4B RID: 27723 RVA: 0x001A4E31 File Offset: 0x001A3031
		[DebuggerNonUserCode]
		public ulong DefaultStreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong defaultStreamIdDefaultValue;
				if (flag)
				{
					defaultStreamIdDefaultValue = this.defaultStreamId_;
				}
				else
				{
					defaultStreamIdDefaultValue = ClubSlot.DefaultStreamIdDefaultValue;
				}
				return defaultStreamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.defaultStreamId_ = value;
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x001A4E4C File Offset: 0x001A304C
		[DebuggerNonUserCode]
		public bool HasDefaultStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x001A4E69 File Offset: 0x001A3069
		[DebuggerNonUserCode]
		public void ClearDefaultStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x001A4E7C File Offset: 0x001A307C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSlot);
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x001A4E9C File Offset: 0x001A309C
		[DebuggerNonUserCode]
		public bool Equals(ClubSlot other)
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
					bool flag4 = this.Role != other.Role;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DefaultStreamId != other.DefaultStreamId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x001A4F10 File Offset: 0x001A3110
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num ^= this.Role.GetHashCode();
			}
			bool hasDefaultStreamId = this.HasDefaultStreamId;
			if (hasDefaultStreamId)
			{
				num ^= this.DefaultStreamId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x001A4F80 File Offset: 0x001A3180
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x001A4F98 File Offset: 0x001A3198
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x001A4FA4 File Offset: 0x001A31A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Role);
			}
			bool hasDefaultStreamId = this.HasDefaultStreamId;
			if (hasDefaultStreamId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.DefaultStreamId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x001A5014 File Offset: 0x001A3214
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
			}
			bool hasDefaultStreamId = this.HasDefaultStreamId;
			if (hasDefaultStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.DefaultStreamId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x001A5080 File Offset: 0x001A3280
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSlot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRole = other.HasRole;
				if (hasRole)
				{
					this.Role = other.Role;
				}
				bool hasDefaultStreamId = other.HasDefaultStreamId;
				if (hasDefaultStreamId)
				{
					this.DefaultStreamId = other.DefaultStreamId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x001A50E2 File Offset: 0x001A32E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x001A50F0 File Offset: 0x001A32F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DefaultStreamId = input.ReadUInt64();
					}
				}
				else
				{
					this.Role = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040031B7 RID: 12727
		private static readonly MessageParser<ClubSlot> _parser = new MessageParser<ClubSlot>(() => new ClubSlot());

		// Token: 0x040031B8 RID: 12728
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031B9 RID: 12729
		private int _hasBits0;

		// Token: 0x040031BA RID: 12730
		public const int RoleFieldNumber = 1;

		// Token: 0x040031BB RID: 12731
		private static readonly uint RoleDefaultValue = 0U;

		// Token: 0x040031BC RID: 12732
		private uint role_;

		// Token: 0x040031BD RID: 12733
		public const int DefaultStreamIdFieldNumber = 2;

		// Token: 0x040031BE RID: 12734
		private static readonly ulong DefaultStreamIdDefaultValue = 0UL;

		// Token: 0x040031BF RID: 12735
		private ulong defaultStreamId_;
	}
}
