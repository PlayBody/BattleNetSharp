using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000078 RID: 120
	public sealed class AxePrefetchContent : IMessage<AxePrefetchContent>, IMessage, IEquatable<AxePrefetchContent>, IDeepCloneable<AxePrefetchContent>, IBufferMessage
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00029354 File Offset: 0x00027554
		[DebuggerNonUserCode]
		public static MessageParser<AxePrefetchContent> Parser
		{
			get
			{
				return AxePrefetchContent._parser;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0002936C File Offset: 0x0002756C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[97];
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00029390 File Offset: 0x00027590
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxePrefetchContent.Descriptor;
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000293A7 File Offset: 0x000275A7
		[DebuggerNonUserCode]
		public AxePrefetchContent()
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000293BC File Offset: 0x000275BC
		[DebuggerNonUserCode]
		public AxePrefetchContent(AxePrefetchContent other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000293E8 File Offset: 0x000275E8
		[DebuggerNonUserCode]
		public AxePrefetchContent Clone()
		{
			return new AxePrefetchContent(this);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00029400 File Offset: 0x00027600
		[DebuggerNonUserCode]
		public RepeatedField<SNOReference> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00029418 File Offset: 0x00027618
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxePrefetchContent);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00029438 File Offset: 0x00027638
		[DebuggerNonUserCode]
		public bool Equals(AxePrefetchContent other)
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
					bool flag4 = !this.list_.Equals(other.list_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00029494 File Offset: 0x00027694
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000294D4 File Offset: 0x000276D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000294EC File Offset: 0x000276EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000294F8 File Offset: 0x000276F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, AxePrefetchContent._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00029534 File Offset: 0x00027734
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(AxePrefetchContent._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002957C File Offset: 0x0002777C
		[DebuggerNonUserCode]
		public void MergeFrom(AxePrefetchContent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000295BE File Offset: 0x000277BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000295CC File Offset: 0x000277CC
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
					this.list_.AddEntriesFrom(ref input, AxePrefetchContent._repeated_list_codec);
				}
			}
		}

		// Token: 0x04000433 RID: 1075
		private static readonly MessageParser<AxePrefetchContent> _parser = new MessageParser<AxePrefetchContent>(() => new AxePrefetchContent());

		// Token: 0x04000434 RID: 1076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000435 RID: 1077
		public const int ListFieldNumber = 1;

		// Token: 0x04000436 RID: 1078
		private static readonly FieldCodec<SNOReference> _repeated_list_codec = FieldCodec.ForMessage<SNOReference>(10U, SNOReference.Parser);

		// Token: 0x04000437 RID: 1079
		private readonly RepeatedField<SNOReference> list_ = new RepeatedField<SNOReference>();
	}
}
