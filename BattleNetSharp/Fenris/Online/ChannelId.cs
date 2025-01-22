using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000147 RID: 327
	public sealed class ChannelId : IMessage<ChannelId>, IMessage, IEquatable<ChannelId>, IDeepCloneable<ChannelId>, IBufferMessage
	{
		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00084114 File Offset: 0x00082314
		[DebuggerNonUserCode]
		public static MessageParser<ChannelId> Parser
		{
			get
			{
				return ChannelId._parser;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0008412C File Offset: 0x0008232C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00084150 File Offset: 0x00082350
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelId.Descriptor;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00084167 File Offset: 0x00082367
		[DebuggerNonUserCode]
		public ChannelId()
		{
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00084174 File Offset: 0x00082374
		[DebuggerNonUserCode]
		public ChannelId(ChannelId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.hostLabel_ = other.hostLabel_;
			this.hostEpoch_ = other.hostEpoch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000841CC File Offset: 0x000823CC
		[DebuggerNonUserCode]
		public ChannelId Clone()
		{
			return new ChannelId(this);
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000841E4 File Offset: 0x000823E4
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00084215 File Offset: 0x00082415
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
					idDefaultValue = ChannelId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00084230 File Offset: 0x00082430
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0008424D File Offset: 0x0008244D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00084260 File Offset: 0x00082460
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00084291 File Offset: 0x00082491
		[DebuggerNonUserCode]
		public uint HostLabel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint hostLabelDefaultValue;
				if (flag)
				{
					hostLabelDefaultValue = this.hostLabel_;
				}
				else
				{
					hostLabelDefaultValue = ChannelId.HostLabelDefaultValue;
				}
				return hostLabelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.hostLabel_ = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000842AC File Offset: 0x000824AC
		[DebuggerNonUserCode]
		public bool HasHostLabel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000842C9 File Offset: 0x000824C9
		[DebuggerNonUserCode]
		public void ClearHostLabel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000842DC File Offset: 0x000824DC
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0008430D File Offset: 0x0008250D
		[DebuggerNonUserCode]
		public uint HostEpoch
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint hostEpochDefaultValue;
				if (flag)
				{
					hostEpochDefaultValue = this.hostEpoch_;
				}
				else
				{
					hostEpochDefaultValue = ChannelId.HostEpochDefaultValue;
				}
				return hostEpochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.hostEpoch_ = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00084328 File Offset: 0x00082528
		[DebuggerNonUserCode]
		public bool HasHostEpoch
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00084345 File Offset: 0x00082545
		[DebuggerNonUserCode]
		public void ClearHostEpoch()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00084358 File Offset: 0x00082558
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelId);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00084378 File Offset: 0x00082578
		[DebuggerNonUserCode]
		public bool Equals(ChannelId other)
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
						bool flag5 = this.HostLabel != other.HostLabel;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HostEpoch != other.HostEpoch;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00084404 File Offset: 0x00082604
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasHostLabel = this.HasHostLabel;
			if (hasHostLabel)
			{
				num ^= this.HostLabel.GetHashCode();
			}
			bool hasHostEpoch = this.HasHostEpoch;
			if (hasHostEpoch)
			{
				num ^= this.HostEpoch.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00084490 File Offset: 0x00082690
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000844A8 File Offset: 0x000826A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000844B4 File Offset: 0x000826B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasHostLabel = this.HasHostLabel;
			if (hasHostLabel)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.HostLabel);
			}
			bool hasHostEpoch = this.HasHostEpoch;
			if (hasHostEpoch)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HostEpoch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00084544 File Offset: 0x00082744
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasHostLabel = this.HasHostLabel;
			if (hasHostLabel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HostLabel);
			}
			bool hasHostEpoch = this.HasHostEpoch;
			if (hasHostEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HostEpoch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000845D0 File Offset: 0x000827D0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasHostLabel = other.HasHostLabel;
				if (hasHostLabel)
				{
					this.HostLabel = other.HostLabel;
				}
				bool hasHostEpoch = other.HasHostEpoch;
				if (hasHostEpoch)
				{
					this.HostEpoch = other.HostEpoch;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0008464B File Offset: 0x0008284B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00084658 File Offset: 0x00082858
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
					if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HostEpoch = input.ReadUInt32();
						}
					}
					else
					{
						this.HostLabel = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000EF7 RID: 3831
		private static readonly MessageParser<ChannelId> _parser = new MessageParser<ChannelId>(() => new ChannelId());

		// Token: 0x04000EF8 RID: 3832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EF9 RID: 3833
		private int _hasBits0;

		// Token: 0x04000EFA RID: 3834
		public const int IdFieldNumber = 1;

		// Token: 0x04000EFB RID: 3835
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000EFC RID: 3836
		private uint id_;

		// Token: 0x04000EFD RID: 3837
		public const int HostLabelFieldNumber = 3;

		// Token: 0x04000EFE RID: 3838
		private static readonly uint HostLabelDefaultValue = 0U;

		// Token: 0x04000EFF RID: 3839
		private uint hostLabel_;

		// Token: 0x04000F00 RID: 3840
		public const int HostEpochFieldNumber = 4;

		// Token: 0x04000F01 RID: 3841
		private static readonly uint HostEpochDefaultValue = 0U;

		// Token: 0x04000F02 RID: 3842
		private uint hostEpoch_;
	}
}
