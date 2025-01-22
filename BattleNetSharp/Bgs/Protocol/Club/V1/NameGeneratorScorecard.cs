using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000479 RID: 1145
	public sealed class NameGeneratorScorecard : IMessage<NameGeneratorScorecard>, IMessage, IEquatable<NameGeneratorScorecard>, IDeepCloneable<NameGeneratorScorecard>, IBufferMessage
	{
		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x001B2238 File Offset: 0x001B0438
		[DebuggerNonUserCode]
		public static MessageParser<NameGeneratorScorecard> Parser
		{
			get
			{
				return NameGeneratorScorecard._parser;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x001B2250 File Offset: 0x001B0450
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNameGeneratorReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x06006FA7 RID: 28583 RVA: 0x001B2274 File Offset: 0x001B0474
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameGeneratorScorecard.Descriptor;
			}
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x001B228B File Offset: 0x001B048B
		[DebuggerNonUserCode]
		public NameGeneratorScorecard()
		{
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x001B2298 File Offset: 0x001B0498
		[DebuggerNonUserCode]
		public NameGeneratorScorecard(NameGeneratorScorecard other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isRequired_ = other.isRequired_;
			this.fullMatch_ = other.fullMatch_;
			this.partialMatch_ = other.partialMatch_;
			this.partialFallback_ = other.partialFallback_;
			this.fullFallback_ = other.fullFallback_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x001B2308 File Offset: 0x001B0508
		[DebuggerNonUserCode]
		public NameGeneratorScorecard Clone()
		{
			return new NameGeneratorScorecard(this);
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x06006FAB RID: 28587 RVA: 0x001B2320 File Offset: 0x001B0520
		// (set) Token: 0x06006FAC RID: 28588 RVA: 0x001B2351 File Offset: 0x001B0551
		[DebuggerNonUserCode]
		public bool IsRequired
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isRequiredDefaultValue;
				if (flag)
				{
					isRequiredDefaultValue = this.isRequired_;
				}
				else
				{
					isRequiredDefaultValue = NameGeneratorScorecard.IsRequiredDefaultValue;
				}
				return isRequiredDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isRequired_ = value;
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x06006FAD RID: 28589 RVA: 0x001B236C File Offset: 0x001B056C
		[DebuggerNonUserCode]
		public bool HasIsRequired
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x001B2389 File Offset: 0x001B0589
		[DebuggerNonUserCode]
		public void ClearIsRequired()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x06006FAF RID: 28591 RVA: 0x001B239C File Offset: 0x001B059C
		// (set) Token: 0x06006FB0 RID: 28592 RVA: 0x001B23CD File Offset: 0x001B05CD
		[DebuggerNonUserCode]
		public uint FullMatch
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint fullMatchDefaultValue;
				if (flag)
				{
					fullMatchDefaultValue = this.fullMatch_;
				}
				else
				{
					fullMatchDefaultValue = NameGeneratorScorecard.FullMatchDefaultValue;
				}
				return fullMatchDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fullMatch_ = value;
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x06006FB1 RID: 28593 RVA: 0x001B23E8 File Offset: 0x001B05E8
		[DebuggerNonUserCode]
		public bool HasFullMatch
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x001B2405 File Offset: 0x001B0605
		[DebuggerNonUserCode]
		public void ClearFullMatch()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x06006FB3 RID: 28595 RVA: 0x001B2418 File Offset: 0x001B0618
		// (set) Token: 0x06006FB4 RID: 28596 RVA: 0x001B2449 File Offset: 0x001B0649
		[DebuggerNonUserCode]
		public uint PartialMatch
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint partialMatchDefaultValue;
				if (flag)
				{
					partialMatchDefaultValue = this.partialMatch_;
				}
				else
				{
					partialMatchDefaultValue = NameGeneratorScorecard.PartialMatchDefaultValue;
				}
				return partialMatchDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.partialMatch_ = value;
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x001B2464 File Offset: 0x001B0664
		[DebuggerNonUserCode]
		public bool HasPartialMatch
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x001B2481 File Offset: 0x001B0681
		[DebuggerNonUserCode]
		public void ClearPartialMatch()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x001B2494 File Offset: 0x001B0694
		// (set) Token: 0x06006FB8 RID: 28600 RVA: 0x001B24C5 File Offset: 0x001B06C5
		[DebuggerNonUserCode]
		public uint PartialFallback
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint partialFallbackDefaultValue;
				if (flag)
				{
					partialFallbackDefaultValue = this.partialFallback_;
				}
				else
				{
					partialFallbackDefaultValue = NameGeneratorScorecard.PartialFallbackDefaultValue;
				}
				return partialFallbackDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.partialFallback_ = value;
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x06006FB9 RID: 28601 RVA: 0x001B24E0 File Offset: 0x001B06E0
		[DebuggerNonUserCode]
		public bool HasPartialFallback
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x001B24FD File Offset: 0x001B06FD
		[DebuggerNonUserCode]
		public void ClearPartialFallback()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x001B2510 File Offset: 0x001B0710
		// (set) Token: 0x06006FBC RID: 28604 RVA: 0x001B2542 File Offset: 0x001B0742
		[DebuggerNonUserCode]
		public uint FullFallback
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint fullFallbackDefaultValue;
				if (flag)
				{
					fullFallbackDefaultValue = this.fullFallback_;
				}
				else
				{
					fullFallbackDefaultValue = NameGeneratorScorecard.FullFallbackDefaultValue;
				}
				return fullFallbackDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.fullFallback_ = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x06006FBD RID: 28605 RVA: 0x001B255C File Offset: 0x001B075C
		[DebuggerNonUserCode]
		public bool HasFullFallback
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x001B257A File Offset: 0x001B077A
		[DebuggerNonUserCode]
		public void ClearFullFallback()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x001B258C File Offset: 0x001B078C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameGeneratorScorecard);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x001B25AC File Offset: 0x001B07AC
		[DebuggerNonUserCode]
		public bool Equals(NameGeneratorScorecard other)
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
					bool flag4 = this.IsRequired != other.IsRequired;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FullMatch != other.FullMatch;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PartialMatch != other.PartialMatch;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PartialFallback != other.PartialFallback;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FullFallback != other.FullFallback;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x001B2678 File Offset: 0x001B0878
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsRequired = this.HasIsRequired;
			if (hasIsRequired)
			{
				num ^= this.IsRequired.GetHashCode();
			}
			bool hasFullMatch = this.HasFullMatch;
			if (hasFullMatch)
			{
				num ^= this.FullMatch.GetHashCode();
			}
			bool hasPartialMatch = this.HasPartialMatch;
			if (hasPartialMatch)
			{
				num ^= this.PartialMatch.GetHashCode();
			}
			bool hasPartialFallback = this.HasPartialFallback;
			if (hasPartialFallback)
			{
				num ^= this.PartialFallback.GetHashCode();
			}
			bool hasFullFallback = this.HasFullFallback;
			if (hasFullFallback)
			{
				num ^= this.FullFallback.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x001B2740 File Offset: 0x001B0940
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x001B2758 File Offset: 0x001B0958
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x001B2764 File Offset: 0x001B0964
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsRequired = this.HasIsRequired;
			if (hasIsRequired)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsRequired);
			}
			bool hasFullMatch = this.HasFullMatch;
			if (hasFullMatch)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FullMatch);
			}
			bool hasPartialMatch = this.HasPartialMatch;
			if (hasPartialMatch)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PartialMatch);
			}
			bool hasPartialFallback = this.HasPartialFallback;
			if (hasPartialFallback)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PartialFallback);
			}
			bool hasFullFallback = this.HasFullFallback;
			if (hasFullFallback)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FullFallback);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x001B283C File Offset: 0x001B0A3C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsRequired = this.HasIsRequired;
			if (hasIsRequired)
			{
				num += 2;
			}
			bool hasFullMatch = this.HasFullMatch;
			if (hasFullMatch)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FullMatch);
			}
			bool hasPartialMatch = this.HasPartialMatch;
			if (hasPartialMatch)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PartialMatch);
			}
			bool hasPartialFallback = this.HasPartialFallback;
			if (hasPartialFallback)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PartialFallback);
			}
			bool hasFullFallback = this.HasFullFallback;
			if (hasFullFallback)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FullFallback);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001B28F8 File Offset: 0x001B0AF8
		[DebuggerNonUserCode]
		public void MergeFrom(NameGeneratorScorecard other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsRequired = other.HasIsRequired;
				if (hasIsRequired)
				{
					this.IsRequired = other.IsRequired;
				}
				bool hasFullMatch = other.HasFullMatch;
				if (hasFullMatch)
				{
					this.FullMatch = other.FullMatch;
				}
				bool hasPartialMatch = other.HasPartialMatch;
				if (hasPartialMatch)
				{
					this.PartialMatch = other.PartialMatch;
				}
				bool hasPartialFallback = other.HasPartialFallback;
				if (hasPartialFallback)
				{
					this.PartialFallback = other.PartialFallback;
				}
				bool hasFullFallback = other.HasFullFallback;
				if (hasFullFallback)
				{
					this.FullFallback = other.FullFallback;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x001B29AC File Offset: 0x001B0BAC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x001B29B8 File Offset: 0x001B0BB8
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
							goto IL_0032;
						}
						this.FullMatch = input.ReadUInt32();
					}
					else
					{
						this.IsRequired = input.ReadBool();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.FullFallback = input.ReadUInt32();
					}
					else
					{
						this.PartialFallback = input.ReadUInt32();
					}
				}
				else
				{
					this.PartialMatch = input.ReadUInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003331 RID: 13105
		private static readonly MessageParser<NameGeneratorScorecard> _parser = new MessageParser<NameGeneratorScorecard>(() => new NameGeneratorScorecard());

		// Token: 0x04003332 RID: 13106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003333 RID: 13107
		private int _hasBits0;

		// Token: 0x04003334 RID: 13108
		public const int IsRequiredFieldNumber = 1;

		// Token: 0x04003335 RID: 13109
		private static readonly bool IsRequiredDefaultValue = false;

		// Token: 0x04003336 RID: 13110
		private bool isRequired_;

		// Token: 0x04003337 RID: 13111
		public const int FullMatchFieldNumber = 2;

		// Token: 0x04003338 RID: 13112
		private static readonly uint FullMatchDefaultValue = 0U;

		// Token: 0x04003339 RID: 13113
		private uint fullMatch_;

		// Token: 0x0400333A RID: 13114
		public const int PartialMatchFieldNumber = 3;

		// Token: 0x0400333B RID: 13115
		private static readonly uint PartialMatchDefaultValue = 0U;

		// Token: 0x0400333C RID: 13116
		private uint partialMatch_;

		// Token: 0x0400333D RID: 13117
		public const int PartialFallbackFieldNumber = 4;

		// Token: 0x0400333E RID: 13118
		private static readonly uint PartialFallbackDefaultValue = 0U;

		// Token: 0x0400333F RID: 13119
		private uint partialFallback_;

		// Token: 0x04003340 RID: 13120
		public const int FullFallbackFieldNumber = 5;

		// Token: 0x04003341 RID: 13121
		private static readonly uint FullFallbackDefaultValue = 0U;

		// Token: 0x04003342 RID: 13122
		private uint fullFallback_;
	}
}
