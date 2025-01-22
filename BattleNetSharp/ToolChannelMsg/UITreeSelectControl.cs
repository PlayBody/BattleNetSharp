using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A0 RID: 160
	public sealed class UITreeSelectControl : IMessage<UITreeSelectControl>, IMessage, IEquatable<UITreeSelectControl>, IDeepCloneable<UITreeSelectControl>, IBufferMessage
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00036A44 File Offset: 0x00034C44
		[DebuggerNonUserCode]
		public static MessageParser<UITreeSelectControl> Parser
		{
			get
			{
				return UITreeSelectControl._parser;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00036A5C File Offset: 0x00034C5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[137];
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00036A84 File Offset: 0x00034C84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeSelectControl.Descriptor;
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00036A9B File Offset: 0x00034C9B
		[DebuggerNonUserCode]
		public UITreeSelectControl()
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00036AA5 File Offset: 0x00034CA5
		[DebuggerNonUserCode]
		public UITreeSelectControl(UITreeSelectControl other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00036AD8 File Offset: 0x00034CD8
		[DebuggerNonUserCode]
		public UITreeSelectControl Clone()
		{
			return new UITreeSelectControl(this);
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00036AF0 File Offset: 0x00034CF0
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00036B21 File Offset: 0x00034D21
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
					hashDefaultValue = UITreeSelectControl.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00036B3C File Offset: 0x00034D3C
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00036B59 File Offset: 0x00034D59
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00036B6C File Offset: 0x00034D6C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeSelectControl);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00036B8C File Offset: 0x00034D8C
		[DebuggerNonUserCode]
		public bool Equals(UITreeSelectControl other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00036BE4 File Offset: 0x00034DE4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00036C34 File Offset: 0x00034E34
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00036C4C File Offset: 0x00034E4C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00036C58 File Offset: 0x00034E58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00036CA4 File Offset: 0x00034EA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00036CF4 File Offset: 0x00034EF4
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeSelectControl other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00036D3D File Offset: 0x00034F3D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00036D48 File Offset: 0x00034F48
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Hash = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly MessageParser<UITreeSelectControl> _parser = new MessageParser<UITreeSelectControl>(() => new UITreeSelectControl());

		// Token: 0x040005D7 RID: 1495
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005D8 RID: 1496
		private int _hasBits0;

		// Token: 0x040005D9 RID: 1497
		public const int HashFieldNumber = 1;

		// Token: 0x040005DA RID: 1498
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005DB RID: 1499
		private ulong hash_;
	}
}
