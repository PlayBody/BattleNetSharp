using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000063 RID: 99
	public sealed class ReplacedSNO : IMessage<ReplacedSNO>, IMessage, IEquatable<ReplacedSNO>, IDeepCloneable<ReplacedSNO>, IBufferMessage
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00022D44 File Offset: 0x00020F44
		[DebuggerNonUserCode]
		public static MessageParser<ReplacedSNO> Parser
		{
			get
			{
				return ReplacedSNO._parser;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00022D5C File Offset: 0x00020F5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[76];
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00022D80 File Offset: 0x00020F80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplacedSNO.Descriptor;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00022D97 File Offset: 0x00020F97
		[DebuggerNonUserCode]
		public ReplacedSNO()
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00022DA1 File Offset: 0x00020FA1
		[DebuggerNonUserCode]
		public ReplacedSNO(ReplacedSNO other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoOriginal_ = other.snoOriginal_;
			this.snoReplacement_ = other.snoReplacement_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00022DE0 File Offset: 0x00020FE0
		[DebuggerNonUserCode]
		public ReplacedSNO Clone()
		{
			return new ReplacedSNO(this);
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00022DF8 File Offset: 0x00020FF8
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00022E29 File Offset: 0x00021029
		[DebuggerNonUserCode]
		public int SnoOriginal
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoOriginalDefaultValue;
				if (flag)
				{
					snoOriginalDefaultValue = this.snoOriginal_;
				}
				else
				{
					snoOriginalDefaultValue = ReplacedSNO.SnoOriginalDefaultValue;
				}
				return snoOriginalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoOriginal_ = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00022E44 File Offset: 0x00021044
		[DebuggerNonUserCode]
		public bool HasSnoOriginal
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00022E61 File Offset: 0x00021061
		[DebuggerNonUserCode]
		public void ClearSnoOriginal()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00022E74 File Offset: 0x00021074
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00022EA5 File Offset: 0x000210A5
		[DebuggerNonUserCode]
		public int SnoReplacement
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoReplacementDefaultValue;
				if (flag)
				{
					snoReplacementDefaultValue = this.snoReplacement_;
				}
				else
				{
					snoReplacementDefaultValue = ReplacedSNO.SnoReplacementDefaultValue;
				}
				return snoReplacementDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoReplacement_ = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00022EC0 File Offset: 0x000210C0
		[DebuggerNonUserCode]
		public bool HasSnoReplacement
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00022EDD File Offset: 0x000210DD
		[DebuggerNonUserCode]
		public void ClearSnoReplacement()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00022EF0 File Offset: 0x000210F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplacedSNO);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00022F10 File Offset: 0x00021110
		[DebuggerNonUserCode]
		public bool Equals(ReplacedSNO other)
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
					bool flag4 = this.SnoOriginal != other.SnoOriginal;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoReplacement != other.SnoReplacement;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00022F84 File Offset: 0x00021184
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoOriginal = this.HasSnoOriginal;
			if (hasSnoOriginal)
			{
				num ^= this.SnoOriginal.GetHashCode();
			}
			bool hasSnoReplacement = this.HasSnoReplacement;
			if (hasSnoReplacement)
			{
				num ^= this.SnoReplacement.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00022FF0 File Offset: 0x000211F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00023008 File Offset: 0x00021208
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00023014 File Offset: 0x00021214
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoOriginal = this.HasSnoOriginal;
			if (hasSnoOriginal)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoOriginal);
			}
			bool hasSnoReplacement = this.HasSnoReplacement;
			if (hasSnoReplacement)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoReplacement);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00023084 File Offset: 0x00021284
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoOriginal = this.HasSnoOriginal;
			if (hasSnoOriginal)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoOriginal);
			}
			bool hasSnoReplacement = this.HasSnoReplacement;
			if (hasSnoReplacement)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoReplacement);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000230F0 File Offset: 0x000212F0
		[DebuggerNonUserCode]
		public void MergeFrom(ReplacedSNO other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoOriginal = other.HasSnoOriginal;
				if (hasSnoOriginal)
				{
					this.SnoOriginal = other.SnoOriginal;
				}
				bool hasSnoReplacement = other.HasSnoReplacement;
				if (hasSnoReplacement)
				{
					this.SnoReplacement = other.SnoReplacement;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00023152 File Offset: 0x00021352
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00023160 File Offset: 0x00021360
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
						this.SnoReplacement = input.ReadInt32();
					}
				}
				else
				{
					this.SnoOriginal = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400036F RID: 879
		private static readonly MessageParser<ReplacedSNO> _parser = new MessageParser<ReplacedSNO>(() => new ReplacedSNO());

		// Token: 0x04000370 RID: 880
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000371 RID: 881
		private int _hasBits0;

		// Token: 0x04000372 RID: 882
		public const int SnoOriginalFieldNumber = 1;

		// Token: 0x04000373 RID: 883
		private static readonly int SnoOriginalDefaultValue = 0;

		// Token: 0x04000374 RID: 884
		private int snoOriginal_;

		// Token: 0x04000375 RID: 885
		public const int SnoReplacementFieldNumber = 2;

		// Token: 0x04000376 RID: 886
		private static readonly int SnoReplacementDefaultValue = 0;

		// Token: 0x04000377 RID: 887
		private int snoReplacement_;
	}
}
