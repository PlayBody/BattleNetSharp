using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000117 RID: 279
	public sealed class SocialWheelBinding : IMessage<SocialWheelBinding>, IMessage, IEquatable<SocialWheelBinding>, IDeepCloneable<SocialWheelBinding>, IBufferMessage
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00060DAC File Offset: 0x0005EFAC
		[DebuggerNonUserCode]
		public static MessageParser<SocialWheelBinding> Parser
		{
			get
			{
				return SocialWheelBinding._parser;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00060DC4 File Offset: 0x0005EFC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00060DE8 File Offset: 0x0005EFE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SocialWheelBinding.Descriptor;
			}
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00060DFF File Offset: 0x0005EFFF
		[DebuggerNonUserCode]
		public SocialWheelBinding()
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00060E0C File Offset: 0x0005F00C
		[DebuggerNonUserCode]
		public SocialWheelBinding(SocialWheelBinding other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.slot_ = other.slot_;
			this.binding_ = ((other.binding_ != null) ? other.binding_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00060E68 File Offset: 0x0005F068
		[DebuggerNonUserCode]
		public SocialWheelBinding Clone()
		{
			return new SocialWheelBinding(this);
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00060E80 File Offset: 0x0005F080
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00060EB1 File Offset: 0x0005F0B1
		[DebuggerNonUserCode]
		public int Slot
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int slotDefaultValue;
				if (flag)
				{
					slotDefaultValue = this.slot_;
				}
				else
				{
					slotDefaultValue = SocialWheelBinding.SlotDefaultValue;
				}
				return slotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.slot_ = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x00060ECC File Offset: 0x0005F0CC
		[DebuggerNonUserCode]
		public bool HasSlot
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00060EE9 File Offset: 0x0005F0E9
		[DebuggerNonUserCode]
		public void ClearSlot()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00060EFC File Offset: 0x0005F0FC
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x00060F14 File Offset: 0x0005F114
		[DebuggerNonUserCode]
		public ActionBinding Binding
		{
			get
			{
				return this.binding_;
			}
			set
			{
				this.binding_ = value;
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00060F20 File Offset: 0x0005F120
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SocialWheelBinding);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00060F40 File Offset: 0x0005F140
		[DebuggerNonUserCode]
		public bool Equals(SocialWheelBinding other)
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
					bool flag4 = this.Slot != other.Slot;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Binding, other.Binding);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00060FB4 File Offset: 0x0005F1B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num ^= this.Slot.GetHashCode();
			}
			bool flag = this.binding_ != null;
			if (flag)
			{
				num ^= this.Binding.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00061020 File Offset: 0x0005F220
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00061038 File Offset: 0x0005F238
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00061044 File Offset: 0x0005F244
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Slot);
			}
			bool flag = this.binding_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Binding);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000610B4 File Offset: 0x0005F2B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			bool flag = this.binding_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Binding);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00061124 File Offset: 0x0005F324
		[DebuggerNonUserCode]
		public void MergeFrom(SocialWheelBinding other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSlot = other.HasSlot;
				if (hasSlot)
				{
					this.Slot = other.Slot;
				}
				bool flag2 = other.binding_ != null;
				if (flag2)
				{
					bool flag3 = this.binding_ == null;
					if (flag3)
					{
						this.Binding = new ActionBinding();
					}
					this.Binding.MergeFrom(other.Binding);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000611A9 File Offset: 0x0005F3A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000611B4 File Offset: 0x0005F3B4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.binding_ == null;
						if (flag)
						{
							this.Binding = new ActionBinding();
						}
						input.ReadMessage(this.Binding);
					}
				}
				else
				{
					this.Slot = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000ABA RID: 2746
		private static readonly MessageParser<SocialWheelBinding> _parser = new MessageParser<SocialWheelBinding>(() => new SocialWheelBinding());

		// Token: 0x04000ABB RID: 2747
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ABC RID: 2748
		private int _hasBits0;

		// Token: 0x04000ABD RID: 2749
		public const int SlotFieldNumber = 1;

		// Token: 0x04000ABE RID: 2750
		private static readonly int SlotDefaultValue = 0;

		// Token: 0x04000ABF RID: 2751
		private int slot_;

		// Token: 0x04000AC0 RID: 2752
		public const int BindingFieldNumber = 2;

		// Token: 0x04000AC1 RID: 2753
		private ActionBinding binding_;
	}
}
