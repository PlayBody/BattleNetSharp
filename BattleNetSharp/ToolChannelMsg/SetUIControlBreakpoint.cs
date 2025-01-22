using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A2 RID: 162
	public sealed class SetUIControlBreakpoint : IMessage<SetUIControlBreakpoint>, IMessage, IEquatable<SetUIControlBreakpoint>, IDeepCloneable<SetUIControlBreakpoint>, IBufferMessage
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00037134 File Offset: 0x00035334
		[DebuggerNonUserCode]
		public static MessageParser<SetUIControlBreakpoint> Parser
		{
			get
			{
				return SetUIControlBreakpoint._parser;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0003714C File Offset: 0x0003534C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[139];
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00037174 File Offset: 0x00035374
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetUIControlBreakpoint.Descriptor;
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003718B File Offset: 0x0003538B
		[DebuggerNonUserCode]
		public SetUIControlBreakpoint()
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00037198 File Offset: 0x00035398
		[DebuggerNonUserCode]
		public SetUIControlBreakpoint(SetUIControlBreakpoint other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this.breakpointType_ = other.breakpointType_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000371F0 File Offset: 0x000353F0
		[DebuggerNonUserCode]
		public SetUIControlBreakpoint Clone()
		{
			return new SetUIControlBreakpoint(this);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00037208 File Offset: 0x00035408
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00037239 File Offset: 0x00035439
		[DebuggerNonUserCode]
		public ulong Hash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong hashDefaultValue;
				if (flag)
				{
					hashDefaultValue = this.hash_;
				}
				else
				{
					hashDefaultValue = SetUIControlBreakpoint.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00037254 File Offset: 0x00035454
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00037271 File Offset: 0x00035471
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00037284 File Offset: 0x00035484
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000372B5 File Offset: 0x000354B5
		[DebuggerNonUserCode]
		public uint BreakpointType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint breakpointTypeDefaultValue;
				if (flag)
				{
					breakpointTypeDefaultValue = this.breakpointType_;
				}
				else
				{
					breakpointTypeDefaultValue = SetUIControlBreakpoint.BreakpointTypeDefaultValue;
				}
				return breakpointTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.breakpointType_ = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000372D0 File Offset: 0x000354D0
		[DebuggerNonUserCode]
		public bool HasBreakpointType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000372ED File Offset: 0x000354ED
		[DebuggerNonUserCode]
		public void ClearBreakpointType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00037300 File Offset: 0x00035500
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00037331 File Offset: 0x00035531
		[DebuggerNonUserCode]
		public bool Enable
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool enableDefaultValue;
				if (flag)
				{
					enableDefaultValue = this.enable_;
				}
				else
				{
					enableDefaultValue = SetUIControlBreakpoint.EnableDefaultValue;
				}
				return enableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.enable_ = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0003734C File Offset: 0x0003554C
		[DebuggerNonUserCode]
		public bool HasEnable
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00037369 File Offset: 0x00035569
		[DebuggerNonUserCode]
		public void ClearEnable()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003737C File Offset: 0x0003557C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetUIControlBreakpoint);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003739C File Offset: 0x0003559C
		[DebuggerNonUserCode]
		public bool Equals(SetUIControlBreakpoint other)
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
					bool flag4 = this.Hash != other.Hash;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BreakpointType != other.BreakpointType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Enable != other.Enable;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00037428 File Offset: 0x00035628
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasBreakpointType = this.HasBreakpointType;
			if (hasBreakpointType)
			{
				num ^= this.BreakpointType.GetHashCode();
			}
			bool hasEnable = this.HasEnable;
			if (hasEnable)
			{
				num ^= this.Enable.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000374B4 File Offset: 0x000356B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000374CC File Offset: 0x000356CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000374D8 File Offset: 0x000356D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool hasBreakpointType = this.HasBreakpointType;
			if (hasBreakpointType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BreakpointType);
			}
			bool hasEnable = this.HasEnable;
			if (hasEnable)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Enable);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00037568 File Offset: 0x00035768
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool hasBreakpointType = this.HasBreakpointType;
			if (hasBreakpointType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BreakpointType);
			}
			bool hasEnable = this.HasEnable;
			if (hasEnable)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000375E8 File Offset: 0x000357E8
		[DebuggerNonUserCode]
		public void MergeFrom(SetUIControlBreakpoint other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasBreakpointType = other.HasBreakpointType;
				if (hasBreakpointType)
				{
					this.BreakpointType = other.BreakpointType;
				}
				bool hasEnable = other.HasEnable;
				if (hasEnable)
				{
					this.Enable = other.Enable;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00037663 File Offset: 0x00035863
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00037670 File Offset: 0x00035870
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Enable = input.ReadBool();
						}
					}
					else
					{
						this.BreakpointType = input.ReadUInt32();
					}
				}
				else
				{
					this.Hash = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040005E2 RID: 1506
		private static readonly MessageParser<SetUIControlBreakpoint> _parser = new MessageParser<SetUIControlBreakpoint>(() => new SetUIControlBreakpoint());

		// Token: 0x040005E3 RID: 1507
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005E4 RID: 1508
		private int _hasBits0;

		// Token: 0x040005E5 RID: 1509
		public const int HashFieldNumber = 1;

		// Token: 0x040005E6 RID: 1510
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005E7 RID: 1511
		private ulong hash_;

		// Token: 0x040005E8 RID: 1512
		public const int BreakpointTypeFieldNumber = 2;

		// Token: 0x040005E9 RID: 1513
		private static readonly uint BreakpointTypeDefaultValue = 0U;

		// Token: 0x040005EA RID: 1514
		private uint breakpointType_;

		// Token: 0x040005EB RID: 1515
		public const int EnableFieldNumber = 3;

		// Token: 0x040005EC RID: 1516
		private static readonly bool EnableDefaultValue = false;

		// Token: 0x040005ED RID: 1517
		private bool enable_;
	}
}
