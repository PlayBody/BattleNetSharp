using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000077 RID: 119
	public sealed class IterateReferencesResponse : IMessage<IterateReferencesResponse>, IMessage, IEquatable<IterateReferencesResponse>, IDeepCloneable<IterateReferencesResponse>, IBufferMessage
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00029058 File Offset: 0x00027258
		[DebuggerNonUserCode]
		public static MessageParser<IterateReferencesResponse> Parser
		{
			get
			{
				return IterateReferencesResponse._parser;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00029070 File Offset: 0x00027270
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[96];
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00029094 File Offset: 0x00027294
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IterateReferencesResponse.Descriptor;
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000290AB File Offset: 0x000272AB
		[DebuggerNonUserCode]
		public IterateReferencesResponse()
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000290C0 File Offset: 0x000272C0
		[DebuggerNonUserCode]
		public IterateReferencesResponse(IterateReferencesResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000290EC File Offset: 0x000272EC
		[DebuggerNonUserCode]
		public IterateReferencesResponse Clone()
		{
			return new IterateReferencesResponse(this);
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00029104 File Offset: 0x00027304
		[DebuggerNonUserCode]
		public RepeatedField<SNOReference> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002911C File Offset: 0x0002731C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IterateReferencesResponse);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002913C File Offset: 0x0002733C
		[DebuggerNonUserCode]
		public bool Equals(IterateReferencesResponse other)
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

		// Token: 0x06000A81 RID: 2689 RVA: 0x00029198 File Offset: 0x00027398
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

		// Token: 0x06000A82 RID: 2690 RVA: 0x000291D8 File Offset: 0x000273D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000291F0 File Offset: 0x000273F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000291FC File Offset: 0x000273FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, IterateReferencesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00029238 File Offset: 0x00027438
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(IterateReferencesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00029280 File Offset: 0x00027480
		[DebuggerNonUserCode]
		public void MergeFrom(IterateReferencesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000292C2 File Offset: 0x000274C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000292D0 File Offset: 0x000274D0
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
					this.list_.AddEntriesFrom(ref input, IterateReferencesResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x0400042E RID: 1070
		private static readonly MessageParser<IterateReferencesResponse> _parser = new MessageParser<IterateReferencesResponse>(() => new IterateReferencesResponse());

		// Token: 0x0400042F RID: 1071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000430 RID: 1072
		public const int ListFieldNumber = 1;

		// Token: 0x04000431 RID: 1073
		private static readonly FieldCodec<SNOReference> _repeated_list_codec = FieldCodec.ForMessage<SNOReference>(10U, SNOReference.Parser);

		// Token: 0x04000432 RID: 1074
		private readonly RepeatedField<SNOReference> list_ = new RepeatedField<SNOReference>();
	}
}
