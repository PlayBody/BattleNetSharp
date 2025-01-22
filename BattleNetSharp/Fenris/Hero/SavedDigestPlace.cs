using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017B RID: 379
	public sealed class SavedDigestPlace : IMessage<SavedDigestPlace>, IMessage, IEquatable<SavedDigestPlace>, IDeepCloneable<SavedDigestPlace>, IBufferMessage
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x0009A634 File Offset: 0x00098834
		[DebuggerNonUserCode]
		public static MessageParser<SavedDigestPlace> Parser
		{
			get
			{
				return SavedDigestPlace._parser;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x0009A64C File Offset: 0x0009884C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x0009A670 File Offset: 0x00098870
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedDigestPlace.Descriptor;
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0009A687 File Offset: 0x00098887
		[DebuggerNonUserCode]
		public SavedDigestPlace()
		{
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0009A691 File Offset: 0x00098891
		[DebuggerNonUserCode]
		public SavedDigestPlace(SavedDigestPlace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0009A6C4 File Offset: 0x000988C4
		[DebuggerNonUserCode]
		public SavedDigestPlace Clone()
		{
			return new SavedDigestPlace(this);
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x0009A6DC File Offset: 0x000988DC
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x0009A70D File Offset: 0x0009890D
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = SavedDigestPlace.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x0009A728 File Offset: 0x00098928
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0009A745 File Offset: 0x00098945
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x0009A758 File Offset: 0x00098958
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedDigestPlace);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x0009A778 File Offset: 0x00098978
		[DebuggerNonUserCode]
		public bool Equals(SavedDigestPlace other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0009A7D0 File Offset: 0x000989D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0009A820 File Offset: 0x00098A20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0009A838 File Offset: 0x00098A38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0009A844 File Offset: 0x00098A44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x0009A890 File Offset: 0x00098A90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
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

		// Token: 0x0600278E RID: 10126 RVA: 0x0009A8D4 File Offset: 0x00098AD4
		[DebuggerNonUserCode]
		public void MergeFrom(SavedDigestPlace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x0009A91D File Offset: 0x00098B1D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0009A928 File Offset: 0x00098B28
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
					this.SnoSubzone = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001187 RID: 4487
		private static readonly MessageParser<SavedDigestPlace> _parser = new MessageParser<SavedDigestPlace>(() => new SavedDigestPlace());

		// Token: 0x04001188 RID: 4488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001189 RID: 4489
		private int _hasBits0;

		// Token: 0x0400118A RID: 4490
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x0400118B RID: 4491
		private static readonly int SnoSubzoneDefaultValue = -1;

		// Token: 0x0400118C RID: 4492
		private int snoSubzone_;
	}
}
