using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E8 RID: 1768
	public sealed class ListChannelsOptions : IMessage<ListChannelsOptions>, IMessage, IEquatable<ListChannelsOptions>, IDeepCloneable<ListChannelsOptions>, IBufferMessage
	{
		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x0027B45C File Offset: 0x0027965C
		[DebuggerNonUserCode]
		public static MessageParser<ListChannelsOptions> Parser
		{
			get
			{
				return ListChannelsOptions._parser;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A2E2 RID: 41698 RVA: 0x0027B474 File Offset: 0x00279674
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x0027B498 File Offset: 0x00279698
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelsOptions.Descriptor;
			}
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x0027B4AF File Offset: 0x002796AF
		[DebuggerNonUserCode]
		public ListChannelsOptions()
		{
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x0027B4BC File Offset: 0x002796BC
		[DebuggerNonUserCode]
		public ListChannelsOptions(ListChannelsOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startIndex_ = other.startIndex_;
			this.maxResults_ = other.maxResults_;
			this.name_ = other.name_;
			this.program_ = other.program_;
			this.locale_ = other.locale_;
			this.capacityFull_ = other.capacityFull_;
			this.attributeFilter_ = ((other.attributeFilter_ != null) ? other.attributeFilter_.Clone() : null);
			this.channelType_ = other.channelType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x0027B560 File Offset: 0x00279760
		[DebuggerNonUserCode]
		public ListChannelsOptions Clone()
		{
			return new ListChannelsOptions(this);
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A2E7 RID: 41703 RVA: 0x0027B578 File Offset: 0x00279778
		// (set) Token: 0x0600A2E8 RID: 41704 RVA: 0x0027B5A9 File Offset: 0x002797A9
		[DebuggerNonUserCode]
		public uint StartIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint startIndexDefaultValue;
				if (flag)
				{
					startIndexDefaultValue = this.startIndex_;
				}
				else
				{
					startIndexDefaultValue = ListChannelsOptions.StartIndexDefaultValue;
				}
				return startIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startIndex_ = value;
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A2E9 RID: 41705 RVA: 0x0027B5C4 File Offset: 0x002797C4
		[DebuggerNonUserCode]
		public bool HasStartIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x0027B5E1 File Offset: 0x002797E1
		[DebuggerNonUserCode]
		public void ClearStartIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x0027B5F4 File Offset: 0x002797F4
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x0027B625 File Offset: 0x00279825
		[DebuggerNonUserCode]
		public uint MaxResults
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint maxResultsDefaultValue;
				if (flag)
				{
					maxResultsDefaultValue = this.maxResults_;
				}
				else
				{
					maxResultsDefaultValue = ListChannelsOptions.MaxResultsDefaultValue;
				}
				return maxResultsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxResults_ = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x0027B640 File Offset: 0x00279840
		[DebuggerNonUserCode]
		public bool HasMaxResults
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x0027B65D File Offset: 0x0027985D
		[DebuggerNonUserCode]
		public void ClearMaxResults()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A2EF RID: 41711 RVA: 0x0027B670 File Offset: 0x00279870
		// (set) Token: 0x0600A2F0 RID: 41712 RVA: 0x0027B691 File Offset: 0x00279891
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ListChannelsOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x0027B6A8 File Offset: 0x002798A8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x0027B6C3 File Offset: 0x002798C3
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x0027B6D0 File Offset: 0x002798D0
		// (set) Token: 0x0600A2F4 RID: 41716 RVA: 0x0027B701 File Offset: 0x00279901
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ListChannelsOptions.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.program_ = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x0027B71C File Offset: 0x0027991C
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x0027B739 File Offset: 0x00279939
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x0027B74C File Offset: 0x0027994C
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x0027B77D File Offset: 0x0027997D
		[DebuggerNonUserCode]
		public uint Locale
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint localeDefaultValue;
				if (flag)
				{
					localeDefaultValue = this.locale_;
				}
				else
				{
					localeDefaultValue = ListChannelsOptions.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.locale_ = value;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A2F9 RID: 41721 RVA: 0x0027B798 File Offset: 0x00279998
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x0027B7B5 File Offset: 0x002799B5
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A2FB RID: 41723 RVA: 0x0027B7C8 File Offset: 0x002799C8
		// (set) Token: 0x0600A2FC RID: 41724 RVA: 0x0027B7FA File Offset: 0x002799FA
		[DebuggerNonUserCode]
		public uint CapacityFull
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint capacityFullDefaultValue;
				if (flag)
				{
					capacityFullDefaultValue = this.capacityFull_;
				}
				else
				{
					capacityFullDefaultValue = ListChannelsOptions.CapacityFullDefaultValue;
				}
				return capacityFullDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.capacityFull_ = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A2FD RID: 41725 RVA: 0x0027B814 File Offset: 0x00279A14
		[DebuggerNonUserCode]
		public bool HasCapacityFull
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x0027B832 File Offset: 0x00279A32
		[DebuggerNonUserCode]
		public void ClearCapacityFull()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x0027B844 File Offset: 0x00279A44
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x0027B85C File Offset: 0x00279A5C
		[DebuggerNonUserCode]
		public AttributeFilter AttributeFilter
		{
			get
			{
				return this.attributeFilter_;
			}
			set
			{
				this.attributeFilter_ = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x0027B868 File Offset: 0x00279A68
		// (set) Token: 0x0600A302 RID: 41730 RVA: 0x0027B889 File Offset: 0x00279A89
		[DebuggerNonUserCode]
		public string ChannelType
		{
			get
			{
				return this.channelType_ ?? ListChannelsOptions.ChannelTypeDefaultValue;
			}
			set
			{
				this.channelType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A303 RID: 41731 RVA: 0x0027B8A0 File Offset: 0x00279AA0
		[DebuggerNonUserCode]
		public bool HasChannelType
		{
			get
			{
				return this.channelType_ != null;
			}
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0027B8BB File Offset: 0x00279ABB
		[DebuggerNonUserCode]
		public void ClearChannelType()
		{
			this.channelType_ = null;
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0027B8C8 File Offset: 0x00279AC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelsOptions);
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x0027B8E8 File Offset: 0x00279AE8
		[DebuggerNonUserCode]
		public bool Equals(ListChannelsOptions other)
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
					bool flag4 = this.StartIndex != other.StartIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxResults != other.MaxResults;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Program != other.Program;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Locale != other.Locale;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CapacityFull != other.CapacityFull;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.AttributeFilter, other.AttributeFilter);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ChannelType != other.ChannelType;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x0027BA10 File Offset: 0x00279C10
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStartIndex = this.HasStartIndex;
			if (hasStartIndex)
			{
				num ^= this.StartIndex.GetHashCode();
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				num ^= this.MaxResults.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			bool hasCapacityFull = this.HasCapacityFull;
			if (hasCapacityFull)
			{
				num ^= this.CapacityFull.GetHashCode();
			}
			bool flag = this.attributeFilter_ != null;
			if (flag)
			{
				num ^= this.AttributeFilter.GetHashCode();
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x0027BB24 File Offset: 0x00279D24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x0027BB3C File Offset: 0x00279D3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x0027BB48 File Offset: 0x00279D48
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStartIndex = this.HasStartIndex;
			if (hasStartIndex)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.StartIndex);
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxResults);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.Program);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.Locale);
			}
			bool hasCapacityFull = this.HasCapacityFull;
			if (hasCapacityFull)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CapacityFull);
			}
			bool flag = this.attributeFilter_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.AttributeFilter);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ChannelType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0027BC90 File Offset: 0x00279E90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStartIndex = this.HasStartIndex;
			if (hasStartIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StartIndex);
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxResults);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 5;
			}
			bool hasCapacityFull = this.HasCapacityFull;
			if (hasCapacityFull)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapacityFull);
			}
			bool flag = this.attributeFilter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttributeFilter);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x0027BD9C File Offset: 0x00279F9C
		[DebuggerNonUserCode]
		public void MergeFrom(ListChannelsOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStartIndex = other.HasStartIndex;
				if (hasStartIndex)
				{
					this.StartIndex = other.StartIndex;
				}
				bool hasMaxResults = other.HasMaxResults;
				if (hasMaxResults)
				{
					this.MaxResults = other.MaxResults;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				bool hasCapacityFull = other.HasCapacityFull;
				if (hasCapacityFull)
				{
					this.CapacityFull = other.CapacityFull;
				}
				bool flag2 = other.attributeFilter_ != null;
				if (flag2)
				{
					bool flag3 = this.attributeFilter_ == null;
					if (flag3)
					{
						this.AttributeFilter = new AttributeFilter();
					}
					this.AttributeFilter.MergeFrom(other.AttributeFilter);
				}
				bool hasChannelType = other.HasChannelType;
				if (hasChannelType)
				{
					this.ChannelType = other.ChannelType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x0027BEC6 File Offset: 0x0027A0C6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x0027BED4 File Offset: 0x0027A0D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 37U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_005A;
							}
							this.MaxResults = input.ReadUInt32();
						}
						else
						{
							this.StartIndex = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 37U)
						{
							goto IL_005A;
						}
						this.Program = input.ReadFixed32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 45U)
					{
						if (num3 != 48U)
						{
							goto IL_005A;
						}
						this.CapacityFull = input.ReadUInt32();
					}
					else
					{
						this.Locale = input.ReadFixed32();
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_005A;
					}
					this.ChannelType = input.ReadString();
				}
				else
				{
					bool flag = this.attributeFilter_ == null;
					if (flag)
					{
						this.AttributeFilter = new AttributeFilter();
					}
					input.ReadMessage(this.AttributeFilter);
				}
				continue;
				IL_005A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004970 RID: 18800
		private static readonly MessageParser<ListChannelsOptions> _parser = new MessageParser<ListChannelsOptions>(() => new ListChannelsOptions());

		// Token: 0x04004971 RID: 18801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004972 RID: 18802
		private int _hasBits0;

		// Token: 0x04004973 RID: 18803
		public const int StartIndexFieldNumber = 1;

		// Token: 0x04004974 RID: 18804
		private static readonly uint StartIndexDefaultValue = 0U;

		// Token: 0x04004975 RID: 18805
		private uint startIndex_;

		// Token: 0x04004976 RID: 18806
		public const int MaxResultsFieldNumber = 2;

		// Token: 0x04004977 RID: 18807
		private static readonly uint MaxResultsDefaultValue = 16U;

		// Token: 0x04004978 RID: 18808
		private uint maxResults_;

		// Token: 0x04004979 RID: 18809
		public const int NameFieldNumber = 3;

		// Token: 0x0400497A RID: 18810
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400497B RID: 18811
		private string name_;

		// Token: 0x0400497C RID: 18812
		public const int ProgramFieldNumber = 4;

		// Token: 0x0400497D RID: 18813
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x0400497E RID: 18814
		private uint program_;

		// Token: 0x0400497F RID: 18815
		public const int LocaleFieldNumber = 5;

		// Token: 0x04004980 RID: 18816
		private static readonly uint LocaleDefaultValue = 0U;

		// Token: 0x04004981 RID: 18817
		private uint locale_;

		// Token: 0x04004982 RID: 18818
		public const int CapacityFullFieldNumber = 6;

		// Token: 0x04004983 RID: 18819
		private static readonly uint CapacityFullDefaultValue = 0U;

		// Token: 0x04004984 RID: 18820
		private uint capacityFull_;

		// Token: 0x04004985 RID: 18821
		public const int AttributeFilterFieldNumber = 7;

		// Token: 0x04004986 RID: 18822
		private AttributeFilter attributeFilter_;

		// Token: 0x04004987 RID: 18823
		public const int ChannelTypeFieldNumber = 8;

		// Token: 0x04004988 RID: 18824
		private static readonly string ChannelTypeDefaultValue = "";

		// Token: 0x04004989 RID: 18825
		private string channelType_;
	}
}
