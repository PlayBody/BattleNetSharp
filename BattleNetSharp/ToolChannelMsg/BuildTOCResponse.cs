using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000067 RID: 103
	public sealed class BuildTOCResponse : IMessage<BuildTOCResponse>, IMessage, IEquatable<BuildTOCResponse>, IDeepCloneable<BuildTOCResponse>, IBufferMessage
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00023E0C File Offset: 0x0002200C
		[DebuggerNonUserCode]
		public static MessageParser<BuildTOCResponse> Parser
		{
			get
			{
				return BuildTOCResponse._parser;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00023E24 File Offset: 0x00022024
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[80];
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00023E48 File Offset: 0x00022048
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildTOCResponse.Descriptor;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00023E5F File Offset: 0x0002205F
		[DebuggerNonUserCode]
		public BuildTOCResponse()
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00023E74 File Offset: 0x00022074
		[DebuggerNonUserCode]
		public BuildTOCResponse(BuildTOCResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00023EA0 File Offset: 0x000220A0
		[DebuggerNonUserCode]
		public BuildTOCResponse Clone()
		{
			return new BuildTOCResponse(this);
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00023EB8 File Offset: 0x000220B8
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00023ED0 File Offset: 0x000220D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildTOCResponse);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00023EF0 File Offset: 0x000220F0
		[DebuggerNonUserCode]
		public bool Equals(BuildTOCResponse other)
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

		// Token: 0x060008DD RID: 2269 RVA: 0x00023F4C File Offset: 0x0002214C
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

		// Token: 0x060008DE RID: 2270 RVA: 0x00023F8C File Offset: 0x0002218C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00023FA4 File Offset: 0x000221A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00023FB0 File Offset: 0x000221B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, BuildTOCResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00023FEC File Offset: 0x000221EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(BuildTOCResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00024034 File Offset: 0x00022234
		[DebuggerNonUserCode]
		public void MergeFrom(BuildTOCResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00024076 File Offset: 0x00022276
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00024084 File Offset: 0x00022284
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
					this.list_.AddEntriesFrom(ref input, BuildTOCResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x0400038E RID: 910
		private static readonly MessageParser<BuildTOCResponse> _parser = new MessageParser<BuildTOCResponse>(() => new BuildTOCResponse());

		// Token: 0x0400038F RID: 911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000390 RID: 912
		public const int ListFieldNumber = 1;

		// Token: 0x04000391 RID: 913
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x04000392 RID: 914
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();
	}
}
