using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel
{
	// Token: 0x02000656 RID: 1622
	public sealed class ChannelRole : IMessage<ChannelRole>, IMessage, IEquatable<ChannelRole>, IDeepCloneable<ChannelRole>, IBufferMessage
	{
		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x00248070 File Offset: 0x00246270
		[DebuggerNonUserCode]
		public static MessageParser<ChannelRole> Parser
		{
			get
			{
				return ChannelRole._parser;
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x060096F4 RID: 38644 RVA: 0x00248088 File Offset: 0x00246288
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelRoleSetReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x060096F5 RID: 38645 RVA: 0x002480AC File Offset: 0x002462AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelRole.Descriptor;
			}
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x002480C3 File Offset: 0x002462C3
		[DebuggerNonUserCode]
		public ChannelRole()
		{
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x002480D0 File Offset: 0x002462D0
		[DebuggerNonUserCode]
		public ChannelRole(ChannelRole other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this.privilege_ = ((other.privilege_ != null) ? other.privilege_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x00248148 File Offset: 0x00246348
		[DebuggerNonUserCode]
		public ChannelRole Clone()
		{
			return new ChannelRole(this);
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x060096F9 RID: 38649 RVA: 0x00248160 File Offset: 0x00246360
		// (set) Token: 0x060096FA RID: 38650 RVA: 0x00248191 File Offset: 0x00246391
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = ChannelRole.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x060096FB RID: 38651 RVA: 0x002481AC File Offset: 0x002463AC
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x002481C9 File Offset: 0x002463C9
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x002481DC File Offset: 0x002463DC
		// (set) Token: 0x060096FE RID: 38654 RVA: 0x002481F4 File Offset: 0x002463F4
		[DebuggerNonUserCode]
		public RoleState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x060096FF RID: 38655 RVA: 0x00248200 File Offset: 0x00246400
		// (set) Token: 0x06009700 RID: 38656 RVA: 0x00248218 File Offset: 0x00246418
		[DebuggerNonUserCode]
		public ChannelPrivilegeSet Privilege
		{
			get
			{
				return this.privilege_;
			}
			set
			{
				this.privilege_ = value;
			}
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x00248224 File Offset: 0x00246424
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelRole);
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x00248244 File Offset: 0x00246444
		[DebuggerNonUserCode]
		public bool Equals(ChannelRole other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.State, other.State);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Privilege, other.Privilege);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x002482D8 File Offset: 0x002464D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				num ^= this.Privilege.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x00248364 File Offset: 0x00246564
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x0024837C File Offset: 0x0024657C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x00248388 File Offset: 0x00246588
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.State);
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Privilege);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x00248420 File Offset: 0x00246620
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Privilege);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x002484B0 File Offset: 0x002466B0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelRole other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new RoleState();
					}
					this.State.MergeFrom(other.State);
				}
				bool flag4 = other.privilege_ != null;
				if (flag4)
				{
					bool flag5 = this.privilege_ == null;
					if (flag5)
					{
						this.Privilege = new ChannelPrivilegeSet();
					}
					this.Privilege.MergeFrom(other.Privilege);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x00248578 File Offset: 0x00246778
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x00248584 File Offset: 0x00246784
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.privilege_ == null;
							if (flag)
							{
								this.Privilege = new ChannelPrivilegeSet();
							}
							input.ReadMessage(this.Privilege);
						}
					}
					else
					{
						bool flag2 = this.state_ == null;
						if (flag2)
						{
							this.State = new RoleState();
						}
						input.ReadMessage(this.State);
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400440F RID: 17423
		private static readonly MessageParser<ChannelRole> _parser = new MessageParser<ChannelRole>(() => new ChannelRole());

		// Token: 0x04004410 RID: 17424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004411 RID: 17425
		private int _hasBits0;

		// Token: 0x04004412 RID: 17426
		public const int IdFieldNumber = 1;

		// Token: 0x04004413 RID: 17427
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04004414 RID: 17428
		private uint id_;

		// Token: 0x04004415 RID: 17429
		public const int StateFieldNumber = 2;

		// Token: 0x04004416 RID: 17430
		private RoleState state_;

		// Token: 0x04004417 RID: 17431
		public const int PrivilegeFieldNumber = 3;

		// Token: 0x04004418 RID: 17432
		private ChannelPrivilegeSet privilege_;
	}
}
