using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000081 RID: 129
	public sealed class ChunkGeometryInfo : IMessage<ChunkGeometryInfo>, IMessage, IEquatable<ChunkGeometryInfo>, IDeepCloneable<ChunkGeometryInfo>, IBufferMessage
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		[DebuggerNonUserCode]
		public static MessageParser<ChunkGeometryInfo> Parser
		{
			get
			{
				return ChunkGeometryInfo._parser;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0002BBF8 File Offset: 0x00029DF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[106];
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002BC1C File Offset: 0x00029E1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChunkGeometryInfo.Descriptor;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002BC33 File Offset: 0x00029E33
		[DebuggerNonUserCode]
		public ChunkGeometryInfo()
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002BC48 File Offset: 0x00029E48
		[DebuggerNonUserCode]
		public ChunkGeometryInfo(ChunkGeometryInfo other)
			: this()
		{
			this.lods_ = other.lods_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0002BC74 File Offset: 0x00029E74
		[DebuggerNonUserCode]
		public ChunkGeometryInfo Clone()
		{
			return new ChunkGeometryInfo(this);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0002BC8C File Offset: 0x00029E8C
		[DebuggerNonUserCode]
		public RepeatedField<LODGeometryInfo> Lods
		{
			get
			{
				return this.lods_;
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0002BCA4 File Offset: 0x00029EA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChunkGeometryInfo);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		[DebuggerNonUserCode]
		public bool Equals(ChunkGeometryInfo other)
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
					bool flag4 = !this.lods_.Equals(other.lods_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002BD20 File Offset: 0x00029F20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lods_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002BD60 File Offset: 0x00029F60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002BD78 File Offset: 0x00029F78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002BD84 File Offset: 0x00029F84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lods_.WriteTo(ref output, ChunkGeometryInfo._repeated_lods_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lods_.CalculateSize(ChunkGeometryInfo._repeated_lods_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002BE08 File Offset: 0x0002A008
		[DebuggerNonUserCode]
		public void MergeFrom(ChunkGeometryInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.lods_.Add(other.lods_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002BE4A File Offset: 0x0002A04A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002BE58 File Offset: 0x0002A058
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lods_.AddEntriesFrom(ref input, ChunkGeometryInfo._repeated_lods_codec);
				}
			}
		}

		// Token: 0x04000483 RID: 1155
		private static readonly MessageParser<ChunkGeometryInfo> _parser = new MessageParser<ChunkGeometryInfo>(() => new ChunkGeometryInfo());

		// Token: 0x04000484 RID: 1156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000485 RID: 1157
		public const int LodsFieldNumber = 2;

		// Token: 0x04000486 RID: 1158
		private static readonly FieldCodec<LODGeometryInfo> _repeated_lods_codec = FieldCodec.ForMessage<LODGeometryInfo>(18U, LODGeometryInfo.Parser);

		// Token: 0x04000487 RID: 1159
		private readonly RepeatedField<LODGeometryInfo> lods_ = new RepeatedField<LODGeometryInfo>();
	}
}
