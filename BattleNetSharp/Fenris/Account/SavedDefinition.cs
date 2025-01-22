using System;
using System.Diagnostics;
using Fenris.AttributeSerializer;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002DB RID: 731
	public sealed class SavedDefinition : IMessage<SavedDefinition>, IMessage, IEquatable<SavedDefinition>, IDeepCloneable<SavedDefinition>, IBufferMessage
	{
		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004D45 RID: 19781 RVA: 0x0012794C File Offset: 0x00125B4C
		[DebuggerNonUserCode]
		public static MessageParser<SavedDefinition> Parser
		{
			get
			{
				return SavedDefinition._parser;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00127964 File Offset: 0x00125B64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x00127988 File Offset: 0x00125B88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedDefinition.Descriptor;
			}
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x0012799F File Offset: 0x00125B9F
		[DebuggerNonUserCode]
		public SavedDefinition()
		{
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x001279B4 File Offset: 0x00125BB4
		[DebuggerNonUserCode]
		public SavedDefinition(SavedDefinition other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.digest_ = ((other.digest_ != null) ? other.digest_.Clone() : null);
			this.lastConnectedTime_ = other.lastConnectedTime_;
			this.partitions_ = other.partitions_.Clone();
			this.savedAttributes_ = ((other.savedAttributes_ != null) ? other.savedAttributes_.Clone() : null);
			this.savedAttributesHardcore_ = ((other.savedAttributesHardcore_ != null) ? other.savedAttributesHardcore_.Clone() : null);
			this.discoveries_ = ((other.discoveries_ != null) ? other.discoveries_.Clone() : null);
			this.currencyAndConsumables_ = ((other.currencyAndConsumables_ != null) ? other.currencyAndConsumables_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00127A9C File Offset: 0x00125C9C
		[DebuggerNonUserCode]
		public SavedDefinition Clone()
		{
			return new SavedDefinition(this);
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x00127AB4 File Offset: 0x00125CB4
		// (set) Token: 0x06004D4C RID: 19788 RVA: 0x00127AE5 File Offset: 0x00125CE5
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = SavedDefinition.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x00127B00 File Offset: 0x00125D00
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00127B1D File Offset: 0x00125D1D
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x00127B30 File Offset: 0x00125D30
		// (set) Token: 0x06004D50 RID: 19792 RVA: 0x00127B48 File Offset: 0x00125D48
		[DebuggerNonUserCode]
		public Digest Digest
		{
			get
			{
				return this.digest_;
			}
			set
			{
				this.digest_ = value;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06004D51 RID: 19793 RVA: 0x00127B54 File Offset: 0x00125D54
		// (set) Token: 0x06004D52 RID: 19794 RVA: 0x00127B85 File Offset: 0x00125D85
		[DebuggerNonUserCode]
		public ulong LastConnectedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong lastConnectedTimeDefaultValue;
				if (flag)
				{
					lastConnectedTimeDefaultValue = this.lastConnectedTime_;
				}
				else
				{
					lastConnectedTimeDefaultValue = SavedDefinition.LastConnectedTimeDefaultValue;
				}
				return lastConnectedTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.lastConnectedTime_ = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06004D53 RID: 19795 RVA: 0x00127BA0 File Offset: 0x00125DA0
		[DebuggerNonUserCode]
		public bool HasLastConnectedTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00127BBD File Offset: 0x00125DBD
		[DebuggerNonUserCode]
		public void ClearLastConnectedTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x00127BD0 File Offset: 0x00125DD0
		[DebuggerNonUserCode]
		public RepeatedField<AccountPartition> Partitions
		{
			get
			{
				return this.partitions_;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x00127BE8 File Offset: 0x00125DE8
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x00127C00 File Offset: 0x00125E00
		[DebuggerNonUserCode]
		public SavedAttributes SavedAttributes
		{
			get
			{
				return this.savedAttributes_;
			}
			set
			{
				this.savedAttributes_ = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x00127C0C File Offset: 0x00125E0C
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x00127C24 File Offset: 0x00125E24
		[DebuggerNonUserCode]
		public SavedAttributes SavedAttributesHardcore
		{
			get
			{
				return this.savedAttributesHardcore_;
			}
			set
			{
				this.savedAttributesHardcore_ = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x00127C30 File Offset: 0x00125E30
		// (set) Token: 0x06004D5B RID: 19803 RVA: 0x00127C48 File Offset: 0x00125E48
		[DebuggerNonUserCode]
		public Discoveries Discoveries
		{
			get
			{
				return this.discoveries_;
			}
			set
			{
				this.discoveries_ = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x00127C54 File Offset: 0x00125E54
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x00127C6C File Offset: 0x00125E6C
		[DebuggerNonUserCode]
		public CurrencyAndConsumables CurrencyAndConsumables
		{
			get
			{
				return this.currencyAndConsumables_;
			}
			set
			{
				this.currencyAndConsumables_ = value;
			}
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00127C78 File Offset: 0x00125E78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedDefinition);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00127C98 File Offset: 0x00125E98
		[DebuggerNonUserCode]
		public bool Equals(SavedDefinition other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Digest, other.Digest);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastConnectedTime != other.LastConnectedTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.partitions_.Equals(other.partitions_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.SavedAttributes, other.SavedAttributes);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.SavedAttributesHardcore, other.SavedAttributesHardcore);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Discoveries, other.Discoveries);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.CurrencyAndConsumables, other.CurrencyAndConsumables);
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

		// Token: 0x06004D60 RID: 19808 RVA: 0x00127DD0 File Offset: 0x00125FD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				num ^= this.Digest.GetHashCode();
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				num ^= this.LastConnectedTime.GetHashCode();
			}
			num ^= this.partitions_.GetHashCode();
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				num ^= this.SavedAttributes.GetHashCode();
			}
			bool flag3 = this.savedAttributesHardcore_ != null;
			if (flag3)
			{
				num ^= this.SavedAttributesHardcore.GetHashCode();
			}
			bool flag4 = this.discoveries_ != null;
			if (flag4)
			{
				num ^= this.Discoveries.GetHashCode();
			}
			bool flag5 = this.currencyAndConsumables_ != null;
			if (flag5)
			{
				num ^= this.CurrencyAndConsumables.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00127EDC File Offset: 0x001260DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00127EF4 File Offset: 0x001260F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00127F00 File Offset: 0x00126100
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Digest);
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.LastConnectedTime);
			}
			this.partitions_.WriteTo(ref output, SavedDefinition._repeated_partitions_codec);
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SavedAttributes);
			}
			bool flag3 = this.savedAttributesHardcore_ != null;
			if (flag3)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SavedAttributesHardcore);
			}
			bool flag4 = this.discoveries_ != null;
			if (flag4)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Discoveries);
			}
			bool flag5 = this.currencyAndConsumables_ != null;
			if (flag5)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CurrencyAndConsumables);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00128040 File Offset: 0x00126240
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Digest);
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastConnectedTime);
			}
			num += this.partitions_.CalculateSize(SavedDefinition._repeated_partitions_codec);
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedAttributes);
			}
			bool flag3 = this.savedAttributesHardcore_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedAttributesHardcore);
			}
			bool flag4 = this.discoveries_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Discoveries);
			}
			bool flag5 = this.currencyAndConsumables_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrencyAndConsumables);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00128164 File Offset: 0x00126364
		[DebuggerNonUserCode]
		public void MergeFrom(SavedDefinition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool flag2 = other.digest_ != null;
				if (flag2)
				{
					bool flag3 = this.digest_ == null;
					if (flag3)
					{
						this.Digest = new Digest();
					}
					this.Digest.MergeFrom(other.Digest);
				}
				bool hasLastConnectedTime = other.HasLastConnectedTime;
				if (hasLastConnectedTime)
				{
					this.LastConnectedTime = other.LastConnectedTime;
				}
				this.partitions_.Add(other.partitions_);
				bool flag4 = other.savedAttributes_ != null;
				if (flag4)
				{
					bool flag5 = this.savedAttributes_ == null;
					if (flag5)
					{
						this.SavedAttributes = new SavedAttributes();
					}
					this.SavedAttributes.MergeFrom(other.SavedAttributes);
				}
				bool flag6 = other.savedAttributesHardcore_ != null;
				if (flag6)
				{
					bool flag7 = this.savedAttributesHardcore_ == null;
					if (flag7)
					{
						this.SavedAttributesHardcore = new SavedAttributes();
					}
					this.SavedAttributesHardcore.MergeFrom(other.SavedAttributesHardcore);
				}
				bool flag8 = other.discoveries_ != null;
				if (flag8)
				{
					bool flag9 = this.discoveries_ == null;
					if (flag9)
					{
						this.Discoveries = new Discoveries();
					}
					this.Discoveries.MergeFrom(other.Discoveries);
				}
				bool flag10 = other.currencyAndConsumables_ != null;
				if (flag10)
				{
					bool flag11 = this.currencyAndConsumables_ == null;
					if (flag11)
					{
						this.CurrencyAndConsumables = new CurrencyAndConsumables();
					}
					this.CurrencyAndConsumables.MergeFrom(other.CurrencyAndConsumables);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00128319 File Offset: 0x00126519
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00128324 File Offset: 0x00126524
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_0063;
							}
							bool flag = this.digest_ == null;
							if (flag)
							{
								this.Digest = new Digest();
							}
							input.ReadMessage(this.Digest);
						}
						else
						{
							this.Version = input.ReadUInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							goto IL_0063;
						}
						this.partitions_.AddEntriesFrom(ref input, SavedDefinition._repeated_partitions_codec);
					}
					else
					{
						this.LastConnectedTime = input.ReadUInt64();
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0063;
						}
						bool flag2 = this.savedAttributesHardcore_ == null;
						if (flag2)
						{
							this.SavedAttributesHardcore = new SavedAttributes();
						}
						input.ReadMessage(this.SavedAttributesHardcore);
					}
					else
					{
						bool flag3 = this.savedAttributes_ == null;
						if (flag3)
						{
							this.SavedAttributes = new SavedAttributes();
						}
						input.ReadMessage(this.SavedAttributes);
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_0063;
					}
					bool flag4 = this.currencyAndConsumables_ == null;
					if (flag4)
					{
						this.CurrencyAndConsumables = new CurrencyAndConsumables();
					}
					input.ReadMessage(this.CurrencyAndConsumables);
				}
				else
				{
					bool flag5 = this.discoveries_ == null;
					if (flag5)
					{
						this.Discoveries = new Discoveries();
					}
					input.ReadMessage(this.Discoveries);
				}
				continue;
				IL_0063:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002272 RID: 8818
		private static readonly MessageParser<SavedDefinition> _parser = new MessageParser<SavedDefinition>(() => new SavedDefinition());

		// Token: 0x04002273 RID: 8819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002274 RID: 8820
		private int _hasBits0;

		// Token: 0x04002275 RID: 8821
		public const int VersionFieldNumber = 1;

		// Token: 0x04002276 RID: 8822
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04002277 RID: 8823
		private uint version_;

		// Token: 0x04002278 RID: 8824
		public const int DigestFieldNumber = 2;

		// Token: 0x04002279 RID: 8825
		private Digest digest_;

		// Token: 0x0400227A RID: 8826
		public const int LastConnectedTimeFieldNumber = 3;

		// Token: 0x0400227B RID: 8827
		private static readonly ulong LastConnectedTimeDefaultValue = 0UL;

		// Token: 0x0400227C RID: 8828
		private ulong lastConnectedTime_;

		// Token: 0x0400227D RID: 8829
		public const int PartitionsFieldNumber = 4;

		// Token: 0x0400227E RID: 8830
		private static readonly FieldCodec<AccountPartition> _repeated_partitions_codec = FieldCodec.ForMessage<AccountPartition>(34U, AccountPartition.Parser);

		// Token: 0x0400227F RID: 8831
		private readonly RepeatedField<AccountPartition> partitions_ = new RepeatedField<AccountPartition>();

		// Token: 0x04002280 RID: 8832
		public const int SavedAttributesFieldNumber = 5;

		// Token: 0x04002281 RID: 8833
		private SavedAttributes savedAttributes_;

		// Token: 0x04002282 RID: 8834
		public const int SavedAttributesHardcoreFieldNumber = 6;

		// Token: 0x04002283 RID: 8835
		private SavedAttributes savedAttributesHardcore_;

		// Token: 0x04002284 RID: 8836
		public const int DiscoveriesFieldNumber = 7;

		// Token: 0x04002285 RID: 8837
		private Discoveries discoveries_;

		// Token: 0x04002286 RID: 8838
		public const int CurrencyAndConsumablesFieldNumber = 8;

		// Token: 0x04002287 RID: 8839
		private CurrencyAndConsumables currencyAndConsumables_;
	}
}
