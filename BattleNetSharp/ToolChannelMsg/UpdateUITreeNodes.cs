using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009D RID: 157
	public sealed class UpdateUITreeNodes : IMessage<UpdateUITreeNodes>, IMessage, IEquatable<UpdateUITreeNodes>, IDeepCloneable<UpdateUITreeNodes>, IBufferMessage
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00036060 File Offset: 0x00034260
		[DebuggerNonUserCode]
		public static MessageParser<UpdateUITreeNodes> Parser
		{
			get
			{
				return UpdateUITreeNodes._parser;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00036078 File Offset: 0x00034278
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[134];
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000360A0 File Offset: 0x000342A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateUITreeNodes.Descriptor;
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000360B7 File Offset: 0x000342B7
		[DebuggerNonUserCode]
		public UpdateUITreeNodes()
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000360CC File Offset: 0x000342CC
		[DebuggerNonUserCode]
		public UpdateUITreeNodes(UpdateUITreeNodes other)
			: this()
		{
			this.nodes_ = other.nodes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000360F8 File Offset: 0x000342F8
		[DebuggerNonUserCode]
		public UpdateUITreeNodes Clone()
		{
			return new UpdateUITreeNodes(this);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00036110 File Offset: 0x00034310
		[DebuggerNonUserCode]
		public RepeatedField<UITreeActiveStateChange> Nodes
		{
			get
			{
				return this.nodes_;
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00036128 File Offset: 0x00034328
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateUITreeNodes);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00036148 File Offset: 0x00034348
		[DebuggerNonUserCode]
		public bool Equals(UpdateUITreeNodes other)
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
					bool flag4 = !this.nodes_.Equals(other.nodes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000361A4 File Offset: 0x000343A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nodes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000361E4 File Offset: 0x000343E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000361FC File Offset: 0x000343FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00036208 File Offset: 0x00034408
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nodes_.WriteTo(ref output, UpdateUITreeNodes._repeated_nodes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00036244 File Offset: 0x00034444
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nodes_.CalculateSize(UpdateUITreeNodes._repeated_nodes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0003628C File Offset: 0x0003448C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateUITreeNodes other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.nodes_.Add(other.nodes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000362CE File Offset: 0x000344CE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000362DC File Offset: 0x000344DC
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
					this.nodes_.AddEntriesFrom(ref input, UpdateUITreeNodes._repeated_nodes_codec);
				}
			}
		}

		// Token: 0x040005C5 RID: 1477
		private static readonly MessageParser<UpdateUITreeNodes> _parser = new MessageParser<UpdateUITreeNodes>(() => new UpdateUITreeNodes());

		// Token: 0x040005C6 RID: 1478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005C7 RID: 1479
		public const int NodesFieldNumber = 1;

		// Token: 0x040005C8 RID: 1480
		private static readonly FieldCodec<UITreeActiveStateChange> _repeated_nodes_codec = FieldCodec.ForMessage<UITreeActiveStateChange>(10U, UITreeActiveStateChange.Parser);

		// Token: 0x040005C9 RID: 1481
		private readonly RepeatedField<UITreeActiveStateChange> nodes_ = new RepeatedField<UITreeActiveStateChange>();
	}
}
