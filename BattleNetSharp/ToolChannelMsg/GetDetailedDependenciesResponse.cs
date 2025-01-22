using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005C RID: 92
	public sealed class GetDetailedDependenciesResponse : IMessage<GetDetailedDependenciesResponse>, IMessage, IEquatable<GetDetailedDependenciesResponse>, IDeepCloneable<GetDetailedDependenciesResponse>, IBufferMessage
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00021280 File Offset: 0x0001F480
		[DebuggerNonUserCode]
		public static MessageParser<GetDetailedDependenciesResponse> Parser
		{
			get
			{
				return GetDetailedDependenciesResponse._parser;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00021298 File Offset: 0x0001F498
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[69];
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000212BC File Offset: 0x0001F4BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetailedDependenciesResponse.Descriptor;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000212D3 File Offset: 0x0001F4D3
		[DebuggerNonUserCode]
		public GetDetailedDependenciesResponse()
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000212E8 File Offset: 0x0001F4E8
		[DebuggerNonUserCode]
		public GetDetailedDependenciesResponse(GetDetailedDependenciesResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00021314 File Offset: 0x0001F514
		[DebuggerNonUserCode]
		public GetDetailedDependenciesResponse Clone()
		{
			return new GetDetailedDependenciesResponse(this);
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0002132C File Offset: 0x0001F52C
		[DebuggerNonUserCode]
		public RepeatedField<DetailedDependency> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00021344 File Offset: 0x0001F544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetailedDependenciesResponse);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00021364 File Offset: 0x0001F564
		[DebuggerNonUserCode]
		public bool Equals(GetDetailedDependenciesResponse other)
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

		// Token: 0x060007EE RID: 2030 RVA: 0x000213C0 File Offset: 0x0001F5C0
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

		// Token: 0x060007EF RID: 2031 RVA: 0x00021400 File Offset: 0x0001F600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00021418 File Offset: 0x0001F618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00021424 File Offset: 0x0001F624
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, GetDetailedDependenciesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00021460 File Offset: 0x0001F660
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(GetDetailedDependenciesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000214A8 File Offset: 0x0001F6A8
		[DebuggerNonUserCode]
		public void MergeFrom(GetDetailedDependenciesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000214EA File Offset: 0x0001F6EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000214F8 File Offset: 0x0001F6F8
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
					this.list_.AddEntriesFrom(ref input, GetDetailedDependenciesResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x0400033F RID: 831
		private static readonly MessageParser<GetDetailedDependenciesResponse> _parser = new MessageParser<GetDetailedDependenciesResponse>(() => new GetDetailedDependenciesResponse());

		// Token: 0x04000340 RID: 832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000341 RID: 833
		public const int ListFieldNumber = 1;

		// Token: 0x04000342 RID: 834
		private static readonly FieldCodec<DetailedDependency> _repeated_list_codec = FieldCodec.ForMessage<DetailedDependency>(10U, DetailedDependency.Parser);

		// Token: 0x04000343 RID: 835
		private readonly RepeatedField<DetailedDependency> list_ = new RepeatedField<DetailedDependency>();
	}
}
