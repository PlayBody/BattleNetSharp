using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AB RID: 427
	public sealed class MountData : IMessage<MountData>, IMessage, IEquatable<MountData>, IDeepCloneable<MountData>, IBufferMessage
	{
		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000B0B6C File Offset: 0x000AED6C
		[DebuggerNonUserCode]
		public static MessageParser<MountData> Parser
		{
			get
			{
				return MountData._parser;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000B0B84 File Offset: 0x000AED84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MountData.Descriptor;
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000B0BBF File Offset: 0x000AEDBF
		[DebuggerNonUserCode]
		public MountData()
		{
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000B0BC9 File Offset: 0x000AEDC9
		[DebuggerNonUserCode]
		public MountData(MountData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoMount_ = other.snoMount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000B0BFC File Offset: 0x000AEDFC
		[DebuggerNonUserCode]
		public MountData Clone()
		{
			return new MountData(this);
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000B0C14 File Offset: 0x000AEE14
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x000B0C45 File Offset: 0x000AEE45
		[DebuggerNonUserCode]
		public int SnoMount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoMountDefaultValue;
				if (flag)
				{
					snoMountDefaultValue = this.snoMount_;
				}
				else
				{
					snoMountDefaultValue = MountData.SnoMountDefaultValue;
				}
				return snoMountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoMount_ = value;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000B0C60 File Offset: 0x000AEE60
		[DebuggerNonUserCode]
		public bool HasSnoMount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000B0C7D File Offset: 0x000AEE7D
		[DebuggerNonUserCode]
		public void ClearSnoMount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000B0C90 File Offset: 0x000AEE90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MountData);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000B0CB0 File Offset: 0x000AEEB0
		[DebuggerNonUserCode]
		public bool Equals(MountData other)
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
					bool flag4 = this.SnoMount != other.SnoMount;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000B0D08 File Offset: 0x000AEF08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoMount = this.HasSnoMount;
			if (hasSnoMount)
			{
				num ^= this.SnoMount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000B0D58 File Offset: 0x000AEF58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000B0D70 File Offset: 0x000AEF70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000B0D7C File Offset: 0x000AEF7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoMount = this.HasSnoMount;
			if (hasSnoMount)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoMount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000B0DC8 File Offset: 0x000AEFC8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoMount = this.HasSnoMount;
			if (hasSnoMount)
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

		// Token: 0x06002D1C RID: 11548 RVA: 0x000B0E0C File Offset: 0x000AF00C
		[DebuggerNonUserCode]
		public void MergeFrom(MountData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoMount = other.HasSnoMount;
				if (hasSnoMount)
				{
					this.SnoMount = other.SnoMount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000B0E55 File Offset: 0x000AF055
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000B0E60 File Offset: 0x000AF060
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoMount = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x0400145E RID: 5214
		private static readonly MessageParser<MountData> _parser = new MessageParser<MountData>(() => new MountData());

		// Token: 0x0400145F RID: 5215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001460 RID: 5216
		private int _hasBits0;

		// Token: 0x04001461 RID: 5217
		public const int SnoMountFieldNumber = 1;

		// Token: 0x04001462 RID: 5218
		private static readonly int SnoMountDefaultValue = -1;

		// Token: 0x04001463 RID: 5219
		private int snoMount_;
	}
}
