using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000079 RID: 121
	public sealed class ReverseCompilationDependenciesRequest : IMessage<ReverseCompilationDependenciesRequest>, IMessage, IEquatable<ReverseCompilationDependenciesRequest>, IDeepCloneable<ReverseCompilationDependenciesRequest>, IBufferMessage
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00029650 File Offset: 0x00027850
		[DebuggerNonUserCode]
		public static MessageParser<ReverseCompilationDependenciesRequest> Parser
		{
			get
			{
				return ReverseCompilationDependenciesRequest._parser;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00029668 File Offset: 0x00027868
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[98];
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002968C File Offset: 0x0002788C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReverseCompilationDependenciesRequest.Descriptor;
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000296A3 File Offset: 0x000278A3
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesRequest()
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000296B8 File Offset: 0x000278B8
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesRequest(ReverseCompilationDependenciesRequest other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000296E4 File Offset: 0x000278E4
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesRequest Clone()
		{
			return new ReverseCompilationDependenciesRequest(this);
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000296FC File Offset: 0x000278FC
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00029714 File Offset: 0x00027914
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReverseCompilationDependenciesRequest);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00029734 File Offset: 0x00027934
		[DebuggerNonUserCode]
		public bool Equals(ReverseCompilationDependenciesRequest other)
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

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00029790 File Offset: 0x00027990
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

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000297D0 File Offset: 0x000279D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000297E8 File Offset: 0x000279E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000297F4 File Offset: 0x000279F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, ReverseCompilationDependenciesRequest._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00029830 File Offset: 0x00027A30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(ReverseCompilationDependenciesRequest._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00029878 File Offset: 0x00027A78
		[DebuggerNonUserCode]
		public void MergeFrom(ReverseCompilationDependenciesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000298BA File Offset: 0x00027ABA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000298C8 File Offset: 0x00027AC8
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
					this.list_.AddEntriesFrom(ref input, ReverseCompilationDependenciesRequest._repeated_list_codec);
				}
			}
		}

		// Token: 0x04000438 RID: 1080
		private static readonly MessageParser<ReverseCompilationDependenciesRequest> _parser = new MessageParser<ReverseCompilationDependenciesRequest>(() => new ReverseCompilationDependenciesRequest());

		// Token: 0x04000439 RID: 1081
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400043A RID: 1082
		public const int ListFieldNumber = 1;

		// Token: 0x0400043B RID: 1083
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x0400043C RID: 1084
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();
	}
}
