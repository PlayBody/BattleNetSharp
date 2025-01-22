using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000073 RID: 115
	public sealed class SNOReference : IMessage<SNOReference>, IMessage, IEquatable<SNOReference>, IDeepCloneable<SNOReference>, IBufferMessage
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00027598 File Offset: 0x00025798
		[DebuggerNonUserCode]
		public static MessageParser<SNOReference> Parser
		{
			get
			{
				return SNOReference._parser;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000275B0 File Offset: 0x000257B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[92];
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000275D4 File Offset: 0x000257D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SNOReference.Descriptor;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000275EB File Offset: 0x000257EB
		[DebuggerNonUserCode]
		public SNOReference()
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000275F8 File Offset: 0x000257F8
		[DebuggerNonUserCode]
		public SNOReference(SNOReference other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroupParent_ = other.snoGroupParent_;
			this.snoHandleParent_ = other.snoHandleParent_;
			this.snoGroupChild_ = other.snoGroupChild_;
			this.snoHandleChild_ = other.snoHandleChild_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002765C File Offset: 0x0002585C
		[DebuggerNonUserCode]
		public SNOReference Clone()
		{
			return new SNOReference(this);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00027674 File Offset: 0x00025874
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x000276A5 File Offset: 0x000258A5
		[DebuggerNonUserCode]
		public int SnoGroupParent
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupParentDefaultValue;
				if (flag)
				{
					snoGroupParentDefaultValue = this.snoGroupParent_;
				}
				else
				{
					snoGroupParentDefaultValue = SNOReference.SnoGroupParentDefaultValue;
				}
				return snoGroupParentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroupParent_ = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x000276C0 File Offset: 0x000258C0
		[DebuggerNonUserCode]
		public bool HasSnoGroupParent
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000276DD File Offset: 0x000258DD
		[DebuggerNonUserCode]
		public void ClearSnoGroupParent()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000276F0 File Offset: 0x000258F0
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00027721 File Offset: 0x00025921
		[DebuggerNonUserCode]
		public int SnoHandleParent
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleParentDefaultValue;
				if (flag)
				{
					snoHandleParentDefaultValue = this.snoHandleParent_;
				}
				else
				{
					snoHandleParentDefaultValue = SNOReference.SnoHandleParentDefaultValue;
				}
				return snoHandleParentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandleParent_ = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002773C File Offset: 0x0002593C
		[DebuggerNonUserCode]
		public bool HasSnoHandleParent
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00027759 File Offset: 0x00025959
		[DebuggerNonUserCode]
		public void ClearSnoHandleParent()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002776C File Offset: 0x0002596C
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0002779D File Offset: 0x0002599D
		[DebuggerNonUserCode]
		public int SnoGroupChild
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoGroupChildDefaultValue;
				if (flag)
				{
					snoGroupChildDefaultValue = this.snoGroupChild_;
				}
				else
				{
					snoGroupChildDefaultValue = SNOReference.SnoGroupChildDefaultValue;
				}
				return snoGroupChildDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoGroupChild_ = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x000277B8 File Offset: 0x000259B8
		[DebuggerNonUserCode]
		public bool HasSnoGroupChild
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000277D5 File Offset: 0x000259D5
		[DebuggerNonUserCode]
		public void ClearSnoGroupChild()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000277E8 File Offset: 0x000259E8
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00027819 File Offset: 0x00025A19
		[DebuggerNonUserCode]
		public int SnoHandleChild
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int snoHandleChildDefaultValue;
				if (flag)
				{
					snoHandleChildDefaultValue = this.snoHandleChild_;
				}
				else
				{
					snoHandleChildDefaultValue = SNOReference.SnoHandleChildDefaultValue;
				}
				return snoHandleChildDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.snoHandleChild_ = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00027834 File Offset: 0x00025A34
		[DebuggerNonUserCode]
		public bool HasSnoHandleChild
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00027851 File Offset: 0x00025A51
		[DebuggerNonUserCode]
		public void ClearSnoHandleChild()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00027864 File Offset: 0x00025A64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SNOReference);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00027884 File Offset: 0x00025A84
		[DebuggerNonUserCode]
		public bool Equals(SNOReference other)
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
					bool flag4 = this.SnoGroupParent != other.SnoGroupParent;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandleParent != other.SnoHandleParent;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoGroupChild != other.SnoGroupChild;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoHandleChild != other.SnoHandleChild;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00027930 File Offset: 0x00025B30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroupParent = this.HasSnoGroupParent;
			if (hasSnoGroupParent)
			{
				num ^= this.SnoGroupParent.GetHashCode();
			}
			bool hasSnoHandleParent = this.HasSnoHandleParent;
			if (hasSnoHandleParent)
			{
				num ^= this.SnoHandleParent.GetHashCode();
			}
			bool hasSnoGroupChild = this.HasSnoGroupChild;
			if (hasSnoGroupChild)
			{
				num ^= this.SnoGroupChild.GetHashCode();
			}
			bool hasSnoHandleChild = this.HasSnoHandleChild;
			if (hasSnoHandleChild)
			{
				num ^= this.SnoHandleChild.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000279D8 File Offset: 0x00025BD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000279F0 File Offset: 0x00025BF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000279FC File Offset: 0x00025BFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroupParent = this.HasSnoGroupParent;
			if (hasSnoGroupParent)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroupParent);
			}
			bool hasSnoHandleParent = this.HasSnoHandleParent;
			if (hasSnoHandleParent)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandleParent);
			}
			bool hasSnoGroupChild = this.HasSnoGroupChild;
			if (hasSnoGroupChild)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoGroupChild);
			}
			bool hasSnoHandleChild = this.HasSnoHandleChild;
			if (hasSnoHandleChild)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SnoHandleChild);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00027AB0 File Offset: 0x00025CB0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroupParent = this.HasSnoGroupParent;
			if (hasSnoGroupParent)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroupParent);
			}
			bool hasSnoHandleParent = this.HasSnoHandleParent;
			if (hasSnoHandleParent)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandleParent);
			}
			bool hasSnoGroupChild = this.HasSnoGroupChild;
			if (hasSnoGroupChild)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroupChild);
			}
			bool hasSnoHandleChild = this.HasSnoHandleChild;
			if (hasSnoHandleChild)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandleChild);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00027B58 File Offset: 0x00025D58
		[DebuggerNonUserCode]
		public void MergeFrom(SNOReference other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroupParent = other.HasSnoGroupParent;
				if (hasSnoGroupParent)
				{
					this.SnoGroupParent = other.SnoGroupParent;
				}
				bool hasSnoHandleParent = other.HasSnoHandleParent;
				if (hasSnoHandleParent)
				{
					this.SnoHandleParent = other.SnoHandleParent;
				}
				bool hasSnoGroupChild = other.HasSnoGroupChild;
				if (hasSnoGroupChild)
				{
					this.SnoGroupChild = other.SnoGroupChild;
				}
				bool hasSnoHandleChild = other.HasSnoHandleChild;
				if (hasSnoHandleChild)
				{
					this.SnoHandleChild = other.SnoHandleChild;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00027BEE File Offset: 0x00025DEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00027BFC File Offset: 0x00025DFC
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.SnoHandleParent = input.ReadInt32();
					}
					else
					{
						this.SnoGroupParent = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.SnoHandleChild = input.ReadInt32();
				}
				else
				{
					this.SnoGroupChild = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040003F6 RID: 1014
		private static readonly MessageParser<SNOReference> _parser = new MessageParser<SNOReference>(() => new SNOReference());

		// Token: 0x040003F7 RID: 1015
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003F8 RID: 1016
		private int _hasBits0;

		// Token: 0x040003F9 RID: 1017
		public const int SnoGroupParentFieldNumber = 1;

		// Token: 0x040003FA RID: 1018
		private static readonly int SnoGroupParentDefaultValue = 0;

		// Token: 0x040003FB RID: 1019
		private int snoGroupParent_;

		// Token: 0x040003FC RID: 1020
		public const int SnoHandleParentFieldNumber = 2;

		// Token: 0x040003FD RID: 1021
		private static readonly int SnoHandleParentDefaultValue = 0;

		// Token: 0x040003FE RID: 1022
		private int snoHandleParent_;

		// Token: 0x040003FF RID: 1023
		public const int SnoGroupChildFieldNumber = 3;

		// Token: 0x04000400 RID: 1024
		private static readonly int SnoGroupChildDefaultValue = 0;

		// Token: 0x04000401 RID: 1025
		private int snoGroupChild_;

		// Token: 0x04000402 RID: 1026
		public const int SnoHandleChildFieldNumber = 4;

		// Token: 0x04000403 RID: 1027
		private static readonly int SnoHandleChildDefaultValue = 0;

		// Token: 0x04000404 RID: 1028
		private int snoHandleChild_;
	}
}
