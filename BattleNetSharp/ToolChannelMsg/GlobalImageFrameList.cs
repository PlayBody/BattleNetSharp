using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000060 RID: 96
	public sealed class GlobalImageFrameList : IMessage<GlobalImageFrameList>, IMessage, IEquatable<GlobalImageFrameList>, IDeepCloneable<GlobalImageFrameList>, IBufferMessage
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000222AC File Offset: 0x000204AC
		[DebuggerNonUserCode]
		public static MessageParser<GlobalImageFrameList> Parser
		{
			get
			{
				return GlobalImageFrameList._parser;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000222C4 File Offset: 0x000204C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[73];
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x000222E8 File Offset: 0x000204E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalImageFrameList.Descriptor;
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000222FF File Offset: 0x000204FF
		[DebuggerNonUserCode]
		public GlobalImageFrameList()
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00022314 File Offset: 0x00020514
		[DebuggerNonUserCode]
		public GlobalImageFrameList(GlobalImageFrameList other)
			: this()
		{
			this.imageFrameName_ = other.imageFrameName_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00022340 File Offset: 0x00020540
		[DebuggerNonUserCode]
		public GlobalImageFrameList Clone()
		{
			return new GlobalImageFrameList(this);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00022358 File Offset: 0x00020558
		[DebuggerNonUserCode]
		public RepeatedField<string> ImageFrameName
		{
			get
			{
				return this.imageFrameName_;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00022370 File Offset: 0x00020570
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalImageFrameList);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00022390 File Offset: 0x00020590
		[DebuggerNonUserCode]
		public bool Equals(GlobalImageFrameList other)
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
					bool flag4 = !this.imageFrameName_.Equals(other.imageFrameName_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000223EC File Offset: 0x000205EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.imageFrameName_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0002242C File Offset: 0x0002062C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00022444 File Offset: 0x00020644
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00022450 File Offset: 0x00020650
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.imageFrameName_.WriteTo(ref output, GlobalImageFrameList._repeated_imageFrameName_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0002248C File Offset: 0x0002068C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.imageFrameName_.CalculateSize(GlobalImageFrameList._repeated_imageFrameName_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000224D4 File Offset: 0x000206D4
		[DebuggerNonUserCode]
		public void MergeFrom(GlobalImageFrameList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.imageFrameName_.Add(other.imageFrameName_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00022516 File Offset: 0x00020716
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00022524 File Offset: 0x00020724
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
					this.imageFrameName_.AddEntriesFrom(ref input, GlobalImageFrameList._repeated_imageFrameName_codec);
				}
			}
		}

		// Token: 0x0400035C RID: 860
		private static readonly MessageParser<GlobalImageFrameList> _parser = new MessageParser<GlobalImageFrameList>(() => new GlobalImageFrameList());

		// Token: 0x0400035D RID: 861
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400035E RID: 862
		public const int ImageFrameNameFieldNumber = 1;

		// Token: 0x0400035F RID: 863
		private static readonly FieldCodec<string> _repeated_imageFrameName_codec = FieldCodec.ForString(10U);

		// Token: 0x04000360 RID: 864
		private readonly RepeatedField<string> imageFrameName_ = new RepeatedField<string>();
	}
}
