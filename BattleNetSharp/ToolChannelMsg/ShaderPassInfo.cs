using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000085 RID: 133
	public sealed class ShaderPassInfo : IMessage<ShaderPassInfo>, IMessage, IEquatable<ShaderPassInfo>, IDeepCloneable<ShaderPassInfo>, IBufferMessage
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0002DFCC File Offset: 0x0002C1CC
		[DebuggerNonUserCode]
		public static MessageParser<ShaderPassInfo> Parser
		{
			get
			{
				return ShaderPassInfo._parser;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[110];
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0002E008 File Offset: 0x0002C208
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShaderPassInfo.Descriptor;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002E01F File Offset: 0x0002C21F
		[DebuggerNonUserCode]
		public ShaderPassInfo()
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002E034 File Offset: 0x0002C234
		[DebuggerNonUserCode]
		public ShaderPassInfo(ShaderPassInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.shaderProgramInfo_ = other.shaderProgramInfo_.Clone();
			this.shaderPassPermutationCount_ = other.shaderPassPermutationCount_;
			this.shaderPassPermutations_ = other.shaderPassPermutations_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002E090 File Offset: 0x0002C290
		[DebuggerNonUserCode]
		public ShaderPassInfo Clone()
		{
			return new ShaderPassInfo(this);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0002E0A8 File Offset: 0x0002C2A8
		[DebuggerNonUserCode]
		public RepeatedField<ShaderProgramInfo> ShaderProgramInfo
		{
			get
			{
				return this.shaderProgramInfo_;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0002E0C0 File Offset: 0x0002C2C0
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0002E0F1 File Offset: 0x0002C2F1
		[DebuggerNonUserCode]
		public int ShaderPassPermutationCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int shaderPassPermutationCountDefaultValue;
				if (flag)
				{
					shaderPassPermutationCountDefaultValue = this.shaderPassPermutationCount_;
				}
				else
				{
					shaderPassPermutationCountDefaultValue = ShaderPassInfo.ShaderPassPermutationCountDefaultValue;
				}
				return shaderPassPermutationCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.shaderPassPermutationCount_ = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0002E10C File Offset: 0x0002C30C
		[DebuggerNonUserCode]
		public bool HasShaderPassPermutationCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002E129 File Offset: 0x0002C329
		[DebuggerNonUserCode]
		public void ClearShaderPassPermutationCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0002E13C File Offset: 0x0002C33C
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0002E15D File Offset: 0x0002C35D
		[DebuggerNonUserCode]
		public string ShaderPassPermutations
		{
			get
			{
				return this.shaderPassPermutations_ ?? ShaderPassInfo.ShaderPassPermutationsDefaultValue;
			}
			set
			{
				this.shaderPassPermutations_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0002E174 File Offset: 0x0002C374
		[DebuggerNonUserCode]
		public bool HasShaderPassPermutations
		{
			get
			{
				return this.shaderPassPermutations_ != null;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0002E18F File Offset: 0x0002C38F
		[DebuggerNonUserCode]
		public void ClearShaderPassPermutations()
		{
			this.shaderPassPermutations_ = null;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002E19C File Offset: 0x0002C39C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShaderPassInfo);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		[DebuggerNonUserCode]
		public bool Equals(ShaderPassInfo other)
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
					bool flag4 = !this.shaderProgramInfo_.Equals(other.shaderProgramInfo_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ShaderPassPermutationCount != other.ShaderPassPermutationCount;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ShaderPassPermutations != other.ShaderPassPermutations;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002E24C File Offset: 0x0002C44C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shaderProgramInfo_.GetHashCode();
			bool hasShaderPassPermutationCount = this.HasShaderPassPermutationCount;
			if (hasShaderPassPermutationCount)
			{
				num ^= this.ShaderPassPermutationCount.GetHashCode();
			}
			bool hasShaderPassPermutations = this.HasShaderPassPermutations;
			if (hasShaderPassPermutations)
			{
				num ^= this.ShaderPassPermutations.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002E2DC File Offset: 0x0002C4DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shaderProgramInfo_.WriteTo(ref output, ShaderPassInfo._repeated_shaderProgramInfo_codec);
			bool hasShaderPassPermutationCount = this.HasShaderPassPermutationCount;
			if (hasShaderPassPermutationCount)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ShaderPassPermutationCount);
			}
			bool hasShaderPassPermutations = this.HasShaderPassPermutations;
			if (hasShaderPassPermutations)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ShaderPassPermutations);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002E368 File Offset: 0x0002C568
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shaderProgramInfo_.CalculateSize(ShaderPassInfo._repeated_shaderProgramInfo_codec);
			bool hasShaderPassPermutationCount = this.HasShaderPassPermutationCount;
			if (hasShaderPassPermutationCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShaderPassPermutationCount);
			}
			bool hasShaderPassPermutations = this.HasShaderPassPermutations;
			if (hasShaderPassPermutations)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ShaderPassPermutations);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002E3E8 File Offset: 0x0002C5E8
		[DebuggerNonUserCode]
		public void MergeFrom(ShaderPassInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.shaderProgramInfo_.Add(other.shaderProgramInfo_);
				bool hasShaderPassPermutationCount = other.HasShaderPassPermutationCount;
				if (hasShaderPassPermutationCount)
				{
					this.ShaderPassPermutationCount = other.ShaderPassPermutationCount;
				}
				bool hasShaderPassPermutations = other.HasShaderPassPermutations;
				if (hasShaderPassPermutations)
				{
					this.ShaderPassPermutations = other.ShaderPassPermutations;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002E45C File Offset: 0x0002C65C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0002E468 File Offset: 0x0002C668
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ShaderPassPermutations = input.ReadString();
						}
					}
					else
					{
						this.ShaderPassPermutationCount = input.ReadInt32();
					}
				}
				else
				{
					this.shaderProgramInfo_.AddEntriesFrom(ref input, ShaderPassInfo._repeated_shaderProgramInfo_codec);
				}
			}
		}

		// Token: 0x040004CE RID: 1230
		private static readonly MessageParser<ShaderPassInfo> _parser = new MessageParser<ShaderPassInfo>(() => new ShaderPassInfo());

		// Token: 0x040004CF RID: 1231
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004D0 RID: 1232
		private int _hasBits0;

		// Token: 0x040004D1 RID: 1233
		public const int ShaderProgramInfoFieldNumber = 1;

		// Token: 0x040004D2 RID: 1234
		private static readonly FieldCodec<ShaderProgramInfo> _repeated_shaderProgramInfo_codec = FieldCodec.ForMessage<ShaderProgramInfo>(10U, ToolChannelMsg.ShaderProgramInfo.Parser);

		// Token: 0x040004D3 RID: 1235
		private readonly RepeatedField<ShaderProgramInfo> shaderProgramInfo_ = new RepeatedField<ShaderProgramInfo>();

		// Token: 0x040004D4 RID: 1236
		public const int ShaderPassPermutationCountFieldNumber = 2;

		// Token: 0x040004D5 RID: 1237
		private static readonly int ShaderPassPermutationCountDefaultValue = 0;

		// Token: 0x040004D6 RID: 1238
		private int shaderPassPermutationCount_;

		// Token: 0x040004D7 RID: 1239
		public const int ShaderPassPermutationsFieldNumber = 3;

		// Token: 0x040004D8 RID: 1240
		private static readonly string ShaderPassPermutationsDefaultValue = "";

		// Token: 0x040004D9 RID: 1241
		private string shaderPassPermutations_;
	}
}
