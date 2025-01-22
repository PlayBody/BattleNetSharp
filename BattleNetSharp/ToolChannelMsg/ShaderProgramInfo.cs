using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000084 RID: 132
	public sealed class ShaderProgramInfo : IMessage<ShaderProgramInfo>, IMessage, IEquatable<ShaderProgramInfo>, IDeepCloneable<ShaderProgramInfo>, IBufferMessage
	{
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0002D4C0 File Offset: 0x0002B6C0
		[DebuggerNonUserCode]
		public static MessageParser<ShaderProgramInfo> Parser
		{
			get
			{
				return ShaderProgramInfo._parser;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0002D4D8 File Offset: 0x0002B6D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[109];
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShaderProgramInfo.Descriptor;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002D513 File Offset: 0x0002B713
		[DebuggerNonUserCode]
		public ShaderProgramInfo()
		{
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002D520 File Offset: 0x0002B720
		[DebuggerNonUserCode]
		public ShaderProgramInfo(ShaderProgramInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.maxOutputParameterCount_ = other.maxOutputParameterCount_;
			this.maxInstructionCount_ = other.maxInstructionCount_;
			this.maxResourceCount_ = other.maxResourceCount_;
			this.maxSamplerCount_ = other.maxSamplerCount_;
			this.maxTextureLoadInstructions_ = other.maxTextureLoadInstructions_;
			this.maxStaticFlowControlCount_ = other.maxStaticFlowControlCount_;
			this.maxDynamicFlowControlCount_ = other.maxDynamicFlowControlCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		[DebuggerNonUserCode]
		public ShaderProgramInfo Clone()
		{
			return new ShaderProgramInfo(this);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0002D5F1 File Offset: 0x0002B7F1
		[DebuggerNonUserCode]
		public int MaxOutputParameterCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int maxOutputParameterCountDefaultValue;
				if (flag)
				{
					maxOutputParameterCountDefaultValue = this.maxOutputParameterCount_;
				}
				else
				{
					maxOutputParameterCountDefaultValue = ShaderProgramInfo.MaxOutputParameterCountDefaultValue;
				}
				return maxOutputParameterCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxOutputParameterCount_ = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0002D60C File Offset: 0x0002B80C
		[DebuggerNonUserCode]
		public bool HasMaxOutputParameterCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002D629 File Offset: 0x0002B829
		[DebuggerNonUserCode]
		public void ClearMaxOutputParameterCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0002D63C File Offset: 0x0002B83C
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0002D66D File Offset: 0x0002B86D
		[DebuggerNonUserCode]
		public int MaxInstructionCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int maxInstructionCountDefaultValue;
				if (flag)
				{
					maxInstructionCountDefaultValue = this.maxInstructionCount_;
				}
				else
				{
					maxInstructionCountDefaultValue = ShaderProgramInfo.MaxInstructionCountDefaultValue;
				}
				return maxInstructionCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxInstructionCount_ = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0002D688 File Offset: 0x0002B888
		[DebuggerNonUserCode]
		public bool HasMaxInstructionCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002D6A5 File Offset: 0x0002B8A5
		[DebuggerNonUserCode]
		public void ClearMaxInstructionCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0002D6B8 File Offset: 0x0002B8B8
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0002D6E9 File Offset: 0x0002B8E9
		[DebuggerNonUserCode]
		public int MaxResourceCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int maxResourceCountDefaultValue;
				if (flag)
				{
					maxResourceCountDefaultValue = this.maxResourceCount_;
				}
				else
				{
					maxResourceCountDefaultValue = ShaderProgramInfo.MaxResourceCountDefaultValue;
				}
				return maxResourceCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxResourceCount_ = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0002D704 File Offset: 0x0002B904
		[DebuggerNonUserCode]
		public bool HasMaxResourceCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002D721 File Offset: 0x0002B921
		[DebuggerNonUserCode]
		public void ClearMaxResourceCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0002D734 File Offset: 0x0002B934
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0002D765 File Offset: 0x0002B965
		[DebuggerNonUserCode]
		public int MaxSamplerCount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int maxSamplerCountDefaultValue;
				if (flag)
				{
					maxSamplerCountDefaultValue = this.maxSamplerCount_;
				}
				else
				{
					maxSamplerCountDefaultValue = ShaderProgramInfo.MaxSamplerCountDefaultValue;
				}
				return maxSamplerCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.maxSamplerCount_ = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0002D780 File Offset: 0x0002B980
		[DebuggerNonUserCode]
		public bool HasMaxSamplerCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0002D79D File Offset: 0x0002B99D
		[DebuggerNonUserCode]
		public void ClearMaxSamplerCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0002D7E2 File Offset: 0x0002B9E2
		[DebuggerNonUserCode]
		public int MaxTextureLoadInstructions
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int maxTextureLoadInstructionsDefaultValue;
				if (flag)
				{
					maxTextureLoadInstructionsDefaultValue = this.maxTextureLoadInstructions_;
				}
				else
				{
					maxTextureLoadInstructionsDefaultValue = ShaderProgramInfo.MaxTextureLoadInstructionsDefaultValue;
				}
				return maxTextureLoadInstructionsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.maxTextureLoadInstructions_ = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0002D7FC File Offset: 0x0002B9FC
		[DebuggerNonUserCode]
		public bool HasMaxTextureLoadInstructions
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002D81A File Offset: 0x0002BA1A
		[DebuggerNonUserCode]
		public void ClearMaxTextureLoadInstructions()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0002D82C File Offset: 0x0002BA2C
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0002D85E File Offset: 0x0002BA5E
		[DebuggerNonUserCode]
		public int MaxStaticFlowControlCount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int maxStaticFlowControlCountDefaultValue;
				if (flag)
				{
					maxStaticFlowControlCountDefaultValue = this.maxStaticFlowControlCount_;
				}
				else
				{
					maxStaticFlowControlCountDefaultValue = ShaderProgramInfo.MaxStaticFlowControlCountDefaultValue;
				}
				return maxStaticFlowControlCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.maxStaticFlowControlCount_ = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002D878 File Offset: 0x0002BA78
		[DebuggerNonUserCode]
		public bool HasMaxStaticFlowControlCount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002D896 File Offset: 0x0002BA96
		[DebuggerNonUserCode]
		public void ClearMaxStaticFlowControlCount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002D8A8 File Offset: 0x0002BAA8
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0002D8DA File Offset: 0x0002BADA
		[DebuggerNonUserCode]
		public int MaxDynamicFlowControlCount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int maxDynamicFlowControlCountDefaultValue;
				if (flag)
				{
					maxDynamicFlowControlCountDefaultValue = this.maxDynamicFlowControlCount_;
				}
				else
				{
					maxDynamicFlowControlCountDefaultValue = ShaderProgramInfo.MaxDynamicFlowControlCountDefaultValue;
				}
				return maxDynamicFlowControlCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.maxDynamicFlowControlCount_ = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		[DebuggerNonUserCode]
		public bool HasMaxDynamicFlowControlCount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002D912 File Offset: 0x0002BB12
		[DebuggerNonUserCode]
		public void ClearMaxDynamicFlowControlCount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002D924 File Offset: 0x0002BB24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShaderProgramInfo);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0002D944 File Offset: 0x0002BB44
		[DebuggerNonUserCode]
		public bool Equals(ShaderProgramInfo other)
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
					bool flag4 = this.MaxOutputParameterCount != other.MaxOutputParameterCount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxInstructionCount != other.MaxInstructionCount;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaxResourceCount != other.MaxResourceCount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MaxSamplerCount != other.MaxSamplerCount;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MaxTextureLoadInstructions != other.MaxTextureLoadInstructions;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.MaxStaticFlowControlCount != other.MaxStaticFlowControlCount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MaxDynamicFlowControlCount != other.MaxDynamicFlowControlCount;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0002DA4C File Offset: 0x0002BC4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMaxOutputParameterCount = this.HasMaxOutputParameterCount;
			if (hasMaxOutputParameterCount)
			{
				num ^= this.MaxOutputParameterCount.GetHashCode();
			}
			bool hasMaxInstructionCount = this.HasMaxInstructionCount;
			if (hasMaxInstructionCount)
			{
				num ^= this.MaxInstructionCount.GetHashCode();
			}
			bool hasMaxResourceCount = this.HasMaxResourceCount;
			if (hasMaxResourceCount)
			{
				num ^= this.MaxResourceCount.GetHashCode();
			}
			bool hasMaxSamplerCount = this.HasMaxSamplerCount;
			if (hasMaxSamplerCount)
			{
				num ^= this.MaxSamplerCount.GetHashCode();
			}
			bool hasMaxTextureLoadInstructions = this.HasMaxTextureLoadInstructions;
			if (hasMaxTextureLoadInstructions)
			{
				num ^= this.MaxTextureLoadInstructions.GetHashCode();
			}
			bool hasMaxStaticFlowControlCount = this.HasMaxStaticFlowControlCount;
			if (hasMaxStaticFlowControlCount)
			{
				num ^= this.MaxStaticFlowControlCount.GetHashCode();
			}
			bool hasMaxDynamicFlowControlCount = this.HasMaxDynamicFlowControlCount;
			if (hasMaxDynamicFlowControlCount)
			{
				num ^= this.MaxDynamicFlowControlCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0002DB4C File Offset: 0x0002BD4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0002DB64 File Offset: 0x0002BD64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002DB70 File Offset: 0x0002BD70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMaxOutputParameterCount = this.HasMaxOutputParameterCount;
			if (hasMaxOutputParameterCount)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxOutputParameterCount);
			}
			bool hasMaxInstructionCount = this.HasMaxInstructionCount;
			if (hasMaxInstructionCount)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxInstructionCount);
			}
			bool hasMaxResourceCount = this.HasMaxResourceCount;
			if (hasMaxResourceCount)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxResourceCount);
			}
			bool hasMaxSamplerCount = this.HasMaxSamplerCount;
			if (hasMaxSamplerCount)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxSamplerCount);
			}
			bool hasMaxTextureLoadInstructions = this.HasMaxTextureLoadInstructions;
			if (hasMaxTextureLoadInstructions)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxTextureLoadInstructions);
			}
			bool hasMaxStaticFlowControlCount = this.HasMaxStaticFlowControlCount;
			if (hasMaxStaticFlowControlCount)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxStaticFlowControlCount);
			}
			bool hasMaxDynamicFlowControlCount = this.HasMaxDynamicFlowControlCount;
			if (hasMaxDynamicFlowControlCount)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MaxDynamicFlowControlCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMaxOutputParameterCount = this.HasMaxOutputParameterCount;
			if (hasMaxOutputParameterCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxOutputParameterCount);
			}
			bool hasMaxInstructionCount = this.HasMaxInstructionCount;
			if (hasMaxInstructionCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxInstructionCount);
			}
			bool hasMaxResourceCount = this.HasMaxResourceCount;
			if (hasMaxResourceCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxResourceCount);
			}
			bool hasMaxSamplerCount = this.HasMaxSamplerCount;
			if (hasMaxSamplerCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxSamplerCount);
			}
			bool hasMaxTextureLoadInstructions = this.HasMaxTextureLoadInstructions;
			if (hasMaxTextureLoadInstructions)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxTextureLoadInstructions);
			}
			bool hasMaxStaticFlowControlCount = this.HasMaxStaticFlowControlCount;
			if (hasMaxStaticFlowControlCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxStaticFlowControlCount);
			}
			bool hasMaxDynamicFlowControlCount = this.HasMaxDynamicFlowControlCount;
			if (hasMaxDynamicFlowControlCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxDynamicFlowControlCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002DD94 File Offset: 0x0002BF94
		[DebuggerNonUserCode]
		public void MergeFrom(ShaderProgramInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMaxOutputParameterCount = other.HasMaxOutputParameterCount;
				if (hasMaxOutputParameterCount)
				{
					this.MaxOutputParameterCount = other.MaxOutputParameterCount;
				}
				bool hasMaxInstructionCount = other.HasMaxInstructionCount;
				if (hasMaxInstructionCount)
				{
					this.MaxInstructionCount = other.MaxInstructionCount;
				}
				bool hasMaxResourceCount = other.HasMaxResourceCount;
				if (hasMaxResourceCount)
				{
					this.MaxResourceCount = other.MaxResourceCount;
				}
				bool hasMaxSamplerCount = other.HasMaxSamplerCount;
				if (hasMaxSamplerCount)
				{
					this.MaxSamplerCount = other.MaxSamplerCount;
				}
				bool hasMaxTextureLoadInstructions = other.HasMaxTextureLoadInstructions;
				if (hasMaxTextureLoadInstructions)
				{
					this.MaxTextureLoadInstructions = other.MaxTextureLoadInstructions;
				}
				bool hasMaxStaticFlowControlCount = other.HasMaxStaticFlowControlCount;
				if (hasMaxStaticFlowControlCount)
				{
					this.MaxStaticFlowControlCount = other.MaxStaticFlowControlCount;
				}
				bool hasMaxDynamicFlowControlCount = other.HasMaxDynamicFlowControlCount;
				if (hasMaxDynamicFlowControlCount)
				{
					this.MaxDynamicFlowControlCount = other.MaxDynamicFlowControlCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0002DE7E File Offset: 0x0002C07E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002DE8C File Offset: 0x0002C08C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0045;
							}
							this.MaxResourceCount = input.ReadInt32();
						}
						else
						{
							this.MaxInstructionCount = input.ReadInt32();
						}
					}
					else
					{
						this.MaxOutputParameterCount = input.ReadInt32();
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0045;
						}
						this.MaxTextureLoadInstructions = input.ReadInt32();
					}
					else
					{
						this.MaxSamplerCount = input.ReadInt32();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0045;
					}
					this.MaxDynamicFlowControlCount = input.ReadInt32();
				}
				else
				{
					this.MaxStaticFlowControlCount = input.ReadInt32();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly MessageParser<ShaderProgramInfo> _parser = new MessageParser<ShaderProgramInfo>(() => new ShaderProgramInfo());

		// Token: 0x040004B7 RID: 1207
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004B8 RID: 1208
		private int _hasBits0;

		// Token: 0x040004B9 RID: 1209
		public const int MaxOutputParameterCountFieldNumber = 1;

		// Token: 0x040004BA RID: 1210
		private static readonly int MaxOutputParameterCountDefaultValue = 0;

		// Token: 0x040004BB RID: 1211
		private int maxOutputParameterCount_;

		// Token: 0x040004BC RID: 1212
		public const int MaxInstructionCountFieldNumber = 2;

		// Token: 0x040004BD RID: 1213
		private static readonly int MaxInstructionCountDefaultValue = 0;

		// Token: 0x040004BE RID: 1214
		private int maxInstructionCount_;

		// Token: 0x040004BF RID: 1215
		public const int MaxResourceCountFieldNumber = 3;

		// Token: 0x040004C0 RID: 1216
		private static readonly int MaxResourceCountDefaultValue = 0;

		// Token: 0x040004C1 RID: 1217
		private int maxResourceCount_;

		// Token: 0x040004C2 RID: 1218
		public const int MaxSamplerCountFieldNumber = 4;

		// Token: 0x040004C3 RID: 1219
		private static readonly int MaxSamplerCountDefaultValue = 0;

		// Token: 0x040004C4 RID: 1220
		private int maxSamplerCount_;

		// Token: 0x040004C5 RID: 1221
		public const int MaxTextureLoadInstructionsFieldNumber = 5;

		// Token: 0x040004C6 RID: 1222
		private static readonly int MaxTextureLoadInstructionsDefaultValue = 0;

		// Token: 0x040004C7 RID: 1223
		private int maxTextureLoadInstructions_;

		// Token: 0x040004C8 RID: 1224
		public const int MaxStaticFlowControlCountFieldNumber = 6;

		// Token: 0x040004C9 RID: 1225
		private static readonly int MaxStaticFlowControlCountDefaultValue = 0;

		// Token: 0x040004CA RID: 1226
		private int maxStaticFlowControlCount_;

		// Token: 0x040004CB RID: 1227
		public const int MaxDynamicFlowControlCountFieldNumber = 7;

		// Token: 0x040004CC RID: 1228
		private static readonly int MaxDynamicFlowControlCountDefaultValue = 0;

		// Token: 0x040004CD RID: 1229
		private int maxDynamicFlowControlCount_;
	}
}
