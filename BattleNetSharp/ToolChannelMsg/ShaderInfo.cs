using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000086 RID: 134
	public sealed class ShaderInfo : IMessage<ShaderInfo>, IMessage, IEquatable<ShaderInfo>, IDeepCloneable<ShaderInfo>, IBufferMessage
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0002E528 File Offset: 0x0002C728
		[DebuggerNonUserCode]
		public static MessageParser<ShaderInfo> Parser
		{
			get
			{
				return ShaderInfo._parser;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0002E540 File Offset: 0x0002C740
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[111];
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0002E564 File Offset: 0x0002C764
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShaderInfo.Descriptor;
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002E57B File Offset: 0x0002C77B
		[DebuggerNonUserCode]
		public ShaderInfo()
		{
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002E590 File Offset: 0x0002C790
		[DebuggerNonUserCode]
		public ShaderInfo(ShaderInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.shaderPassInfo_ = other.shaderPassInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
		[DebuggerNonUserCode]
		public ShaderInfo Clone()
		{
			return new ShaderInfo(this);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0002E629 File Offset: 0x0002C829
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
					snoHandleDefaultValue = ShaderInfo.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0002E644 File Offset: 0x0002C844
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002E661 File Offset: 0x0002C861
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0002E674 File Offset: 0x0002C874
		[DebuggerNonUserCode]
		public RepeatedField<ShaderPassInfo> ShaderPassInfo
		{
			get
			{
				return this.shaderPassInfo_;
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002E68C File Offset: 0x0002C88C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShaderInfo);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		[DebuggerNonUserCode]
		public bool Equals(ShaderInfo other)
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
						bool flag5 = !this.shaderPassInfo_.Equals(other.shaderPassInfo_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002E720 File Offset: 0x0002C920
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			num ^= this.shaderPassInfo_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002E780 File Offset: 0x0002C980
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0002E798 File Offset: 0x0002C998
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			this.shaderPassInfo_.WriteTo(ref output, ShaderInfo._repeated_shaderPassInfo_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0002E804 File Offset: 0x0002CA04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			num += this.shaderPassInfo_.CalculateSize(ShaderInfo._repeated_shaderPassInfo_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002E868 File Offset: 0x0002CA68
		[DebuggerNonUserCode]
		public void MergeFrom(ShaderInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this.shaderPassInfo_.Add(other.shaderPassInfo_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002E8C3 File Offset: 0x0002CAC3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002E8D0 File Offset: 0x0002CAD0
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.shaderPassInfo_.AddEntriesFrom(ref input, ShaderInfo._repeated_shaderPassInfo_codec);
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly MessageParser<ShaderInfo> _parser = new MessageParser<ShaderInfo>(() => new ShaderInfo());

		// Token: 0x040004DB RID: 1243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004DC RID: 1244
		private int _hasBits0;

		// Token: 0x040004DD RID: 1245
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040004DE RID: 1246
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040004DF RID: 1247
		private int snoHandle_;

		// Token: 0x040004E0 RID: 1248
		public const int ShaderPassInfoFieldNumber = 2;

		// Token: 0x040004E1 RID: 1249
		private static readonly FieldCodec<ShaderPassInfo> _repeated_shaderPassInfo_codec = FieldCodec.ForMessage<ShaderPassInfo>(18U, ToolChannelMsg.ShaderPassInfo.Parser);

		// Token: 0x040004E2 RID: 1250
		private readonly RepeatedField<ShaderPassInfo> shaderPassInfo_ = new RepeatedField<ShaderPassInfo>();
	}
}
