using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000053 RID: 83
	public sealed class EnumerateActorsOfTypeWithLabelResponse : IMessage<EnumerateActorsOfTypeWithLabelResponse>, IMessage, IEquatable<EnumerateActorsOfTypeWithLabelResponse>, IDeepCloneable<EnumerateActorsOfTypeWithLabelResponse>, IBufferMessage
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0001E578 File Offset: 0x0001C778
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateActorsOfTypeWithLabelResponse> Parser
		{
			get
			{
				return EnumerateActorsOfTypeWithLabelResponse._parser;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0001E590 File Offset: 0x0001C790
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[60];
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateActorsOfTypeWithLabelResponse.Descriptor;
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001E5CB File Offset: 0x0001C7CB
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelResponse()
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelResponse(EnumerateActorsOfTypeWithLabelResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001E60C File Offset: 0x0001C80C
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelResponse Clone()
		{
			return new EnumerateActorsOfTypeWithLabelResponse(this);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0001E624 File Offset: 0x0001C824
		[DebuggerNonUserCode]
		public RepeatedField<SNONameWithLabel> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001E63C File Offset: 0x0001C83C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateActorsOfTypeWithLabelResponse);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001E65C File Offset: 0x0001C85C
		[DebuggerNonUserCode]
		public bool Equals(EnumerateActorsOfTypeWithLabelResponse other)
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

		// Token: 0x06000709 RID: 1801 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
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

		// Token: 0x0600070A RID: 1802 RVA: 0x0001E6F8 File Offset: 0x0001C8F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001E710 File Offset: 0x0001C910
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001E71C File Offset: 0x0001C91C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, EnumerateActorsOfTypeWithLabelResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001E758 File Offset: 0x0001C958
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(EnumerateActorsOfTypeWithLabelResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateActorsOfTypeWithLabelResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001E7E2 File Offset: 0x0001C9E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
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
					this.list_.AddEntriesFrom(ref input, EnumerateActorsOfTypeWithLabelResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x040002E7 RID: 743
		private static readonly MessageParser<EnumerateActorsOfTypeWithLabelResponse> _parser = new MessageParser<EnumerateActorsOfTypeWithLabelResponse>(() => new EnumerateActorsOfTypeWithLabelResponse());

		// Token: 0x040002E8 RID: 744
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002E9 RID: 745
		public const int ListFieldNumber = 1;

		// Token: 0x040002EA RID: 746
		private static readonly FieldCodec<SNONameWithLabel> _repeated_list_codec = FieldCodec.ForMessage<SNONameWithLabel>(10U, SNONameWithLabel.Parser);

		// Token: 0x040002EB RID: 747
		private readonly RepeatedField<SNONameWithLabel> list_ = new RepeatedField<SNONameWithLabel>();
	}
}
