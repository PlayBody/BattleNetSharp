using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000062 RID: 98
	public sealed class RefreshImageFrames : IMessage<RefreshImageFrames>, IMessage, IEquatable<RefreshImageFrames>, IDeepCloneable<RefreshImageFrames>, IBufferMessage
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00022A48 File Offset: 0x00020C48
		[DebuggerNonUserCode]
		public static MessageParser<RefreshImageFrames> Parser
		{
			get
			{
				return RefreshImageFrames._parser;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00022A60 File Offset: 0x00020C60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[75];
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00022A84 File Offset: 0x00020C84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshImageFrames.Descriptor;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00022A9B File Offset: 0x00020C9B
		[DebuggerNonUserCode]
		public RefreshImageFrames()
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00022AB0 File Offset: 0x00020CB0
		[DebuggerNonUserCode]
		public RefreshImageFrames(RefreshImageFrames other)
			: this()
		{
			this.imageFrameInfo_ = other.imageFrameInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00022ADC File Offset: 0x00020CDC
		[DebuggerNonUserCode]
		public RefreshImageFrames Clone()
		{
			return new RefreshImageFrames(this);
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00022AF4 File Offset: 0x00020CF4
		[DebuggerNonUserCode]
		public RepeatedField<ImageFrameInfo> ImageFrameInfo
		{
			get
			{
				return this.imageFrameInfo_;
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00022B0C File Offset: 0x00020D0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshImageFrames);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00022B2C File Offset: 0x00020D2C
		[DebuggerNonUserCode]
		public bool Equals(RefreshImageFrames other)
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
					bool flag4 = !this.imageFrameInfo_.Equals(other.imageFrameInfo_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00022B88 File Offset: 0x00020D88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.imageFrameInfo_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00022BC8 File Offset: 0x00020DC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00022BE0 File Offset: 0x00020DE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00022BEC File Offset: 0x00020DEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.imageFrameInfo_.WriteTo(ref output, RefreshImageFrames._repeated_imageFrameInfo_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00022C28 File Offset: 0x00020E28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.imageFrameInfo_.CalculateSize(RefreshImageFrames._repeated_imageFrameInfo_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00022C70 File Offset: 0x00020E70
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshImageFrames other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.imageFrameInfo_.Add(other.imageFrameInfo_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00022CB2 File Offset: 0x00020EB2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00022CC0 File Offset: 0x00020EC0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.imageFrameInfo_.AddEntriesFrom(ref input, RefreshImageFrames._repeated_imageFrameInfo_codec);
				}
			}
		}

		// Token: 0x0400036A RID: 874
		private static readonly MessageParser<RefreshImageFrames> _parser = new MessageParser<RefreshImageFrames>(() => new RefreshImageFrames());

		// Token: 0x0400036B RID: 875
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400036C RID: 876
		public const int ImageFrameInfoFieldNumber = 1;

		// Token: 0x0400036D RID: 877
		private static readonly FieldCodec<ImageFrameInfo> _repeated_imageFrameInfo_codec = FieldCodec.ForMessage<ImageFrameInfo>(10U, ToolChannelMsg.ImageFrameInfo.Parser);

		// Token: 0x0400036E RID: 878
		private readonly RepeatedField<ImageFrameInfo> imageFrameInfo_ = new RepeatedField<ImageFrameInfo>();
	}
}
