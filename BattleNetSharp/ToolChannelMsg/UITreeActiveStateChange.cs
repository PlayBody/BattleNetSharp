using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009C RID: 156
	public sealed class UITreeActiveStateChange : IMessage<UITreeActiveStateChange>, IMessage, IEquatable<UITreeActiveStateChange>, IDeepCloneable<UITreeActiveStateChange>, IBufferMessage
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00035BB8 File Offset: 0x00033DB8
		[DebuggerNonUserCode]
		public static MessageParser<UITreeActiveStateChange> Parser
		{
			get
			{
				return UITreeActiveStateChange._parser;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00035BD0 File Offset: 0x00033DD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[133];
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00035BF8 File Offset: 0x00033DF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeActiveStateChange.Descriptor;
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00035C0F File Offset: 0x00033E0F
		[DebuggerNonUserCode]
		public UITreeActiveStateChange()
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00035C19 File Offset: 0x00033E19
		[DebuggerNonUserCode]
		public UITreeActiveStateChange(UITreeActiveStateChange other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this.active_ = other.active_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00035C58 File Offset: 0x00033E58
		[DebuggerNonUserCode]
		public UITreeActiveStateChange Clone()
		{
			return new UITreeActiveStateChange(this);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00035C70 File Offset: 0x00033E70
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00035CA1 File Offset: 0x00033EA1
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
					hashDefaultValue = UITreeActiveStateChange.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00035CBC File Offset: 0x00033EBC
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00035CD9 File Offset: 0x00033ED9
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00035CEC File Offset: 0x00033EEC
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00035D1D File Offset: 0x00033F1D
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = UITreeActiveStateChange.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.active_ = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00035D38 File Offset: 0x00033F38
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00035D55 File Offset: 0x00033F55
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00035D68 File Offset: 0x00033F68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeActiveStateChange);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00035D88 File Offset: 0x00033F88
		[DebuggerNonUserCode]
		public bool Equals(UITreeActiveStateChange other)
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
						bool flag5 = this.Active != other.Active;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00035DFC File Offset: 0x00033FFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00035E6C File Offset: 0x0003406C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00035E84 File Offset: 0x00034084
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00035E90 File Offset: 0x00034090
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Active);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00035F00 File Offset: 0x00034100
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
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

		// Token: 0x06000E5F RID: 3679 RVA: 0x00035F60 File Offset: 0x00034160
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeActiveStateChange other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00035FC2 File Offset: 0x000341C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00035FD0 File Offset: 0x000341D0
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
						this.Active = input.ReadBool();
					}
				}
				else
				{
					this.Hash = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040005BC RID: 1468
		private static readonly MessageParser<UITreeActiveStateChange> _parser = new MessageParser<UITreeActiveStateChange>(() => new UITreeActiveStateChange());

		// Token: 0x040005BD RID: 1469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005BE RID: 1470
		private int _hasBits0;

		// Token: 0x040005BF RID: 1471
		public const int HashFieldNumber = 1;

		// Token: 0x040005C0 RID: 1472
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005C1 RID: 1473
		private ulong hash_;

		// Token: 0x040005C2 RID: 1474
		public const int ActiveFieldNumber = 2;

		// Token: 0x040005C3 RID: 1475
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x040005C4 RID: 1476
		private bool active_;
	}
}
