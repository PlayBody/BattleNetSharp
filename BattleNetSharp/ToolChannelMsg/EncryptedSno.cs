using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FB RID: 251
	public sealed class EncryptedSno : IMessage<EncryptedSno>, IMessage, IEquatable<EncryptedSno>, IDeepCloneable<EncryptedSno>, IBufferMessage
	{
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00056548 File Offset: 0x00054748
		[DebuggerNonUserCode]
		public static MessageParser<EncryptedSno> Parser
		{
			get
			{
				return EncryptedSno._parser;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00056560 File Offset: 0x00054760
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[228];
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00056588 File Offset: 0x00054788
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncryptedSno.Descriptor;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0005659F File Offset: 0x0005479F
		[DebuggerNonUserCode]
		public EncryptedSno()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000565A9 File Offset: 0x000547A9
		[DebuggerNonUserCode]
		public EncryptedSno(EncryptedSno other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000565E8 File Offset: 0x000547E8
		[DebuggerNonUserCode]
		public EncryptedSno Clone()
		{
			return new EncryptedSno(this);
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00056600 File Offset: 0x00054800
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00056631 File Offset: 0x00054831
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = EncryptedSno.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x0005664C File Offset: 0x0005484C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00056669 File Offset: 0x00054869
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x0005667C File Offset: 0x0005487C
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x000566AD File Offset: 0x000548AD
		[DebuggerNonUserCode]
		public ulong Key
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong keyDefaultValue;
				if (flag)
				{
					keyDefaultValue = this.key_;
				}
				else
				{
					keyDefaultValue = EncryptedSno.KeyDefaultValue;
				}
				return keyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.key_ = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x000566C8 File Offset: 0x000548C8
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000566E5 File Offset: 0x000548E5
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000566F8 File Offset: 0x000548F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncryptedSno);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00056718 File Offset: 0x00054918
		[DebuggerNonUserCode]
		public bool Equals(EncryptedSno other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Key != other.Key;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0005678C File Offset: 0x0005498C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000567FC File Offset: 0x000549FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00056814 File Offset: 0x00054A14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00056820 File Offset: 0x00054A20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Key);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00056890 File Offset: 0x00054A90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Key);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000568FC File Offset: 0x00054AFC
		[DebuggerNonUserCode]
		public void MergeFrom(EncryptedSno other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0005695E File Offset: 0x00054B5E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0005696C File Offset: 0x00054B6C
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
						this.Key = input.ReadUInt64();
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040009A9 RID: 2473
		private static readonly MessageParser<EncryptedSno> _parser = new MessageParser<EncryptedSno>(() => new EncryptedSno());

		// Token: 0x040009AA RID: 2474
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009AB RID: 2475
		private int _hasBits0;

		// Token: 0x040009AC RID: 2476
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040009AD RID: 2477
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040009AE RID: 2478
		private int snoHandle_;

		// Token: 0x040009AF RID: 2479
		public const int KeyFieldNumber = 2;

		// Token: 0x040009B0 RID: 2480
		private static readonly ulong KeyDefaultValue = 0UL;

		// Token: 0x040009B1 RID: 2481
		private ulong key_;
	}
}
