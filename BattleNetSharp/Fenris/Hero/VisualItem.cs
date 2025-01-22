using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019A RID: 410
	public sealed class VisualItem : IMessage<VisualItem>, IMessage, IEquatable<VisualItem>, IDeepCloneable<VisualItem>, IBufferMessage
	{
		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000AB02C File Offset: 0x000A922C
		[DebuggerNonUserCode]
		public static MessageParser<VisualItem> Parser
		{
			get
			{
				return VisualItem._parser;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000AB044 File Offset: 0x000A9244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000AB068 File Offset: 0x000A9268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisualItem.Descriptor;
			}
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000AB07F File Offset: 0x000A927F
		[DebuggerNonUserCode]
		public VisualItem()
		{
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000AB089 File Offset: 0x000A9289
		[DebuggerNonUserCode]
		public VisualItem(VisualItem other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sno_ = other.sno_;
			this.snoDye_ = other.snoDye_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000AB0C8 File Offset: 0x000A92C8
		[DebuggerNonUserCode]
		public VisualItem Clone()
		{
			return new VisualItem(this);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x000AB0E0 File Offset: 0x000A92E0
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x000AB111 File Offset: 0x000A9311
		[DebuggerNonUserCode]
		public int Sno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoDefaultValue;
				if (flag)
				{
					snoDefaultValue = this.sno_;
				}
				else
				{
					snoDefaultValue = VisualItem.SnoDefaultValue;
				}
				return snoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno_ = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000AB12C File Offset: 0x000A932C
		[DebuggerNonUserCode]
		public bool HasSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000AB149 File Offset: 0x000A9349
		[DebuggerNonUserCode]
		public void ClearSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000AB15C File Offset: 0x000A935C
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x000AB18D File Offset: 0x000A938D
		[DebuggerNonUserCode]
		public int SnoDye
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoDyeDefaultValue;
				if (flag)
				{
					snoDyeDefaultValue = this.snoDye_;
				}
				else
				{
					snoDyeDefaultValue = VisualItem.SnoDyeDefaultValue;
				}
				return snoDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoDye_ = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x000AB1A8 File Offset: 0x000A93A8
		[DebuggerNonUserCode]
		public bool HasSnoDye
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000AB1C5 File Offset: 0x000A93C5
		[DebuggerNonUserCode]
		public void ClearSnoDye()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000AB1D8 File Offset: 0x000A93D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisualItem);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000AB1F8 File Offset: 0x000A93F8
		[DebuggerNonUserCode]
		public bool Equals(VisualItem other)
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
					bool flag4 = this.Sno != other.Sno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoDye != other.SnoDye;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000AB26C File Offset: 0x000A946C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num ^= this.Sno.GetHashCode();
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				num ^= this.SnoDye.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000AB2D8 File Offset: 0x000A94D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000AB2F0 File Offset: 0x000A94F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000AB2FC File Offset: 0x000A94FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.Sno);
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoDye);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000AB36C File Offset: 0x000A956C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num += 5;
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000AB3C0 File Offset: 0x000A95C0
		[DebuggerNonUserCode]
		public void MergeFrom(VisualItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSno = other.HasSno;
				if (hasSno)
				{
					this.Sno = other.Sno;
				}
				bool hasSnoDye = other.HasSnoDye;
				if (hasSnoDye)
				{
					this.SnoDye = other.SnoDye;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000AB422 File Offset: 0x000A9622
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000AB430 File Offset: 0x000A9630
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SnoDye = input.ReadSFixed32();
					}
				}
				else
				{
					this.Sno = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040013A2 RID: 5026
		private static readonly MessageParser<VisualItem> _parser = new MessageParser<VisualItem>(() => new VisualItem());

		// Token: 0x040013A3 RID: 5027
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013A4 RID: 5028
		private int _hasBits0;

		// Token: 0x040013A5 RID: 5029
		public const int SnoFieldNumber = 1;

		// Token: 0x040013A6 RID: 5030
		private static readonly int SnoDefaultValue = -1;

		// Token: 0x040013A7 RID: 5031
		private int sno_;

		// Token: 0x040013A8 RID: 5032
		public const int SnoDyeFieldNumber = 2;

		// Token: 0x040013A9 RID: 5033
		private static readonly int SnoDyeDefaultValue = -1;

		// Token: 0x040013AA RID: 5034
		private int snoDye_;
	}
}
