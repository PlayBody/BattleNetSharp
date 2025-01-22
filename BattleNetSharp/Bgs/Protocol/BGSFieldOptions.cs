using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000362 RID: 866
	public sealed class BGSFieldOptions : IMessage<BGSFieldOptions>, IMessage, IEquatable<BGSFieldOptions>, IDeepCloneable<BGSFieldOptions>, IBufferMessage
	{
		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06005934 RID: 22836 RVA: 0x00159054 File Offset: 0x00157254
		[DebuggerNonUserCode]
		public static MessageParser<BGSFieldOptions> Parser
		{
			get
			{
				return BGSFieldOptions._parser;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x0015906C File Offset: 0x0015726C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06005936 RID: 22838 RVA: 0x00159090 File Offset: 0x00157290
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BGSFieldOptions.Descriptor;
			}
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x001590A7 File Offset: 0x001572A7
		[DebuggerNonUserCode]
		public BGSFieldOptions()
		{
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x001590B4 File Offset: 0x001572B4
		[DebuggerNonUserCode]
		public BGSFieldOptions(BGSFieldOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.log_ = other.log_;
			this.shardKey_ = other.shardKey_;
			this.fanoutKey_ = other.fanoutKey_;
			this.clientInstanceKey_ = other.clientInstanceKey_;
			this.realizedEnum_ = other.realizedEnum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00159124 File Offset: 0x00157324
		[DebuggerNonUserCode]
		public BGSFieldOptions Clone()
		{
			return new BGSFieldOptions(this);
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x0600593A RID: 22842 RVA: 0x0015913C File Offset: 0x0015733C
		// (set) Token: 0x0600593B RID: 22843 RVA: 0x0015916D File Offset: 0x0015736D
		[DebuggerNonUserCode]
		public LogOption Log
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				LogOption logDefaultValue;
				if (flag)
				{
					logDefaultValue = this.log_;
				}
				else
				{
					logDefaultValue = BGSFieldOptions.LogDefaultValue;
				}
				return logDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.log_ = value;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600593C RID: 22844 RVA: 0x00159188 File Offset: 0x00157388
		[DebuggerNonUserCode]
		public bool HasLog
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x001591A5 File Offset: 0x001573A5
		[DebuggerNonUserCode]
		public void ClearLog()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x001591B8 File Offset: 0x001573B8
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x001591E9 File Offset: 0x001573E9
		[DebuggerNonUserCode]
		public bool ShardKey
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool shardKeyDefaultValue;
				if (flag)
				{
					shardKeyDefaultValue = this.shardKey_;
				}
				else
				{
					shardKeyDefaultValue = BGSFieldOptions.ShardKeyDefaultValue;
				}
				return shardKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.shardKey_ = value;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x00159204 File Offset: 0x00157404
		[DebuggerNonUserCode]
		public bool HasShardKey
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00159221 File Offset: 0x00157421
		[DebuggerNonUserCode]
		public void ClearShardKey()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x00159234 File Offset: 0x00157434
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x00159265 File Offset: 0x00157465
		[DebuggerNonUserCode]
		public bool FanoutKey
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool fanoutKeyDefaultValue;
				if (flag)
				{
					fanoutKeyDefaultValue = this.fanoutKey_;
				}
				else
				{
					fanoutKeyDefaultValue = BGSFieldOptions.FanoutKeyDefaultValue;
				}
				return fanoutKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.fanoutKey_ = value;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x00159280 File Offset: 0x00157480
		[DebuggerNonUserCode]
		public bool HasFanoutKey
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x0015929D File Offset: 0x0015749D
		[DebuggerNonUserCode]
		public void ClearFanoutKey()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x001592B0 File Offset: 0x001574B0
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x001592E1 File Offset: 0x001574E1
		[DebuggerNonUserCode]
		public bool ClientInstanceKey
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool clientInstanceKeyDefaultValue;
				if (flag)
				{
					clientInstanceKeyDefaultValue = this.clientInstanceKey_;
				}
				else
				{
					clientInstanceKeyDefaultValue = BGSFieldOptions.ClientInstanceKeyDefaultValue;
				}
				return clientInstanceKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.clientInstanceKey_ = value;
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x001592FC File Offset: 0x001574FC
		[DebuggerNonUserCode]
		public bool HasClientInstanceKey
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00159319 File Offset: 0x00157519
		[DebuggerNonUserCode]
		public void ClearClientInstanceKey()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x0015932C File Offset: 0x0015752C
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x0015934D File Offset: 0x0015754D
		[DebuggerNonUserCode]
		public string RealizedEnum
		{
			get
			{
				return this.realizedEnum_ ?? BGSFieldOptions.RealizedEnumDefaultValue;
			}
			set
			{
				this.realizedEnum_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x0600594C RID: 22860 RVA: 0x00159364 File Offset: 0x00157564
		[DebuggerNonUserCode]
		public bool HasRealizedEnum
		{
			get
			{
				return this.realizedEnum_ != null;
			}
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x0015937F File Offset: 0x0015757F
		[DebuggerNonUserCode]
		public void ClearRealizedEnum()
		{
			this.realizedEnum_ = null;
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x0015938C File Offset: 0x0015758C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BGSFieldOptions);
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x001593AC File Offset: 0x001575AC
		[DebuggerNonUserCode]
		public bool Equals(BGSFieldOptions other)
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
					bool flag4 = this.Log != other.Log;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ShardKey != other.ShardKey;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FanoutKey != other.FanoutKey;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ClientInstanceKey != other.ClientInstanceKey;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.RealizedEnum != other.RealizedEnum;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00159478 File Offset: 0x00157678
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLog = this.HasLog;
			if (hasLog)
			{
				num ^= this.Log.GetHashCode();
			}
			bool hasShardKey = this.HasShardKey;
			if (hasShardKey)
			{
				num ^= this.ShardKey.GetHashCode();
			}
			bool hasFanoutKey = this.HasFanoutKey;
			if (hasFanoutKey)
			{
				num ^= this.FanoutKey.GetHashCode();
			}
			bool hasClientInstanceKey = this.HasClientInstanceKey;
			if (hasClientInstanceKey)
			{
				num ^= this.ClientInstanceKey.GetHashCode();
			}
			bool hasRealizedEnum = this.HasRealizedEnum;
			if (hasRealizedEnum)
			{
				num ^= this.RealizedEnum.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00159544 File Offset: 0x00157744
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x0015955C File Offset: 0x0015775C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00159568 File Offset: 0x00157768
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLog = this.HasLog;
			if (hasLog)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Log);
			}
			bool hasShardKey = this.HasShardKey;
			if (hasShardKey)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShardKey);
			}
			bool hasFanoutKey = this.HasFanoutKey;
			if (hasFanoutKey)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FanoutKey);
			}
			bool hasClientInstanceKey = this.HasClientInstanceKey;
			if (hasClientInstanceKey)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ClientInstanceKey);
			}
			bool hasRealizedEnum = this.HasRealizedEnum;
			if (hasRealizedEnum)
			{
				output.WriteRawTag(42);
				output.WriteString(this.RealizedEnum);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00159640 File Offset: 0x00157840
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLog = this.HasLog;
			if (hasLog)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Log);
			}
			bool hasShardKey = this.HasShardKey;
			if (hasShardKey)
			{
				num += 2;
			}
			bool hasFanoutKey = this.HasFanoutKey;
			if (hasFanoutKey)
			{
				num += 2;
			}
			bool hasClientInstanceKey = this.HasClientInstanceKey;
			if (hasClientInstanceKey)
			{
				num += 2;
			}
			bool hasRealizedEnum = this.HasRealizedEnum;
			if (hasRealizedEnum)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RealizedEnum);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x001596E4 File Offset: 0x001578E4
		[DebuggerNonUserCode]
		public void MergeFrom(BGSFieldOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLog = other.HasLog;
				if (hasLog)
				{
					this.Log = other.Log;
				}
				bool hasShardKey = other.HasShardKey;
				if (hasShardKey)
				{
					this.ShardKey = other.ShardKey;
				}
				bool hasFanoutKey = other.HasFanoutKey;
				if (hasFanoutKey)
				{
					this.FanoutKey = other.FanoutKey;
				}
				bool hasClientInstanceKey = other.HasClientInstanceKey;
				if (hasClientInstanceKey)
				{
					this.ClientInstanceKey = other.ClientInstanceKey;
				}
				bool hasRealizedEnum = other.HasRealizedEnum;
				if (hasRealizedEnum)
				{
					this.RealizedEnum = other.RealizedEnum;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00159798 File Offset: 0x00157998
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x001597A4 File Offset: 0x001579A4
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
						this.ShardKey = input.ReadBool();
					}
					else
					{
						this.Log = (LogOption)input.ReadEnum();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						this.RealizedEnum = input.ReadString();
					}
					else
					{
						this.ClientInstanceKey = input.ReadBool();
					}
				}
				else
				{
					this.FanoutKey = input.ReadBool();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028B0 RID: 10416
		private static readonly MessageParser<BGSFieldOptions> _parser = new MessageParser<BGSFieldOptions>(() => new BGSFieldOptions());

		// Token: 0x040028B1 RID: 10417
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B2 RID: 10418
		private int _hasBits0;

		// Token: 0x040028B3 RID: 10419
		public const int LogFieldNumber = 1;

		// Token: 0x040028B4 RID: 10420
		private static readonly LogOption LogDefaultValue = LogOption.Hidden;

		// Token: 0x040028B5 RID: 10421
		private LogOption log_;

		// Token: 0x040028B6 RID: 10422
		public const int ShardKeyFieldNumber = 2;

		// Token: 0x040028B7 RID: 10423
		private static readonly bool ShardKeyDefaultValue = false;

		// Token: 0x040028B8 RID: 10424
		private bool shardKey_;

		// Token: 0x040028B9 RID: 10425
		public const int FanoutKeyFieldNumber = 3;

		// Token: 0x040028BA RID: 10426
		private static readonly bool FanoutKeyDefaultValue = false;

		// Token: 0x040028BB RID: 10427
		private bool fanoutKey_;

		// Token: 0x040028BC RID: 10428
		public const int ClientInstanceKeyFieldNumber = 4;

		// Token: 0x040028BD RID: 10429
		private static readonly bool ClientInstanceKeyDefaultValue = false;

		// Token: 0x040028BE RID: 10430
		private bool clientInstanceKey_;

		// Token: 0x040028BF RID: 10431
		public const int RealizedEnumFieldNumber = 5;

		// Token: 0x040028C0 RID: 10432
		private static readonly string RealizedEnumDefaultValue = "";

		// Token: 0x040028C1 RID: 10433
		private string realizedEnum_;
	}
}
