using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C5 RID: 197
	public sealed class SceneChunksInSubzoneResponse : IMessage<SceneChunksInSubzoneResponse>, IMessage, IEquatable<SceneChunksInSubzoneResponse>, IDeepCloneable<SceneChunksInSubzoneResponse>, IBufferMessage
	{
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000441CC File Offset: 0x000423CC
		[DebuggerNonUserCode]
		public static MessageParser<SceneChunksInSubzoneResponse> Parser
		{
			get
			{
				return SceneChunksInSubzoneResponse._parser;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000441E4 File Offset: 0x000423E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[174];
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0004420C File Offset: 0x0004240C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneChunksInSubzoneResponse.Descriptor;
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00044223 File Offset: 0x00042423
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneResponse()
		{
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00044238 File Offset: 0x00042438
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneResponse(SceneChunksInSubzoneResponse other)
			: this()
		{
			this.chunkIndex_ = other.chunkIndex_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00044264 File Offset: 0x00042464
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneResponse Clone()
		{
			return new SceneChunksInSubzoneResponse(this);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0004427C File Offset: 0x0004247C
		[DebuggerNonUserCode]
		public RepeatedField<int> ChunkIndex
		{
			get
			{
				return this.chunkIndex_;
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00044294 File Offset: 0x00042494
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneChunksInSubzoneResponse);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000442B4 File Offset: 0x000424B4
		[DebuggerNonUserCode]
		public bool Equals(SceneChunksInSubzoneResponse other)
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
					bool flag4 = !this.chunkIndex_.Equals(other.chunkIndex_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00044310 File Offset: 0x00042510
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chunkIndex_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00044350 File Offset: 0x00042550
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00044368 File Offset: 0x00042568
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00044374 File Offset: 0x00042574
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chunkIndex_.WriteTo(ref output, SceneChunksInSubzoneResponse._repeated_chunkIndex_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000443B0 File Offset: 0x000425B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chunkIndex_.CalculateSize(SceneChunksInSubzoneResponse._repeated_chunkIndex_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000443F8 File Offset: 0x000425F8
		[DebuggerNonUserCode]
		public void MergeFrom(SceneChunksInSubzoneResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.chunkIndex_.Add(other.chunkIndex_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0004443A File Offset: 0x0004263A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00044448 File Offset: 0x00042648
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.chunkIndex_.AddEntriesFrom(ref input, SceneChunksInSubzoneResponse._repeated_chunkIndex_codec);
				}
			}
		}

		// Token: 0x0400077C RID: 1916
		private static readonly MessageParser<SceneChunksInSubzoneResponse> _parser = new MessageParser<SceneChunksInSubzoneResponse>(() => new SceneChunksInSubzoneResponse());

		// Token: 0x0400077D RID: 1917
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400077E RID: 1918
		public const int ChunkIndexFieldNumber = 1;

		// Token: 0x0400077F RID: 1919
		private static readonly FieldCodec<int> _repeated_chunkIndex_codec = FieldCodec.ForInt32(8U);

		// Token: 0x04000780 RID: 1920
		private readonly RepeatedField<int> chunkIndex_ = new RepeatedField<int>();
	}
}
