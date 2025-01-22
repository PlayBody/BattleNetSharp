using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000065 RID: 101
	public sealed class ReplacedSNOsResponse : IMessage<ReplacedSNOsResponse>, IMessage, IEquatable<ReplacedSNOsResponse>, IDeepCloneable<ReplacedSNOsResponse>, IBufferMessage
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0002342C File Offset: 0x0002162C
		[DebuggerNonUserCode]
		public static MessageParser<ReplacedSNOsResponse> Parser
		{
			get
			{
				return ReplacedSNOsResponse._parser;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00023444 File Offset: 0x00021644
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[78];
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00023468 File Offset: 0x00021668
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplacedSNOsResponse.Descriptor;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0002347F File Offset: 0x0002167F
		[DebuggerNonUserCode]
		public ReplacedSNOsResponse()
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00023494 File Offset: 0x00021694
		[DebuggerNonUserCode]
		public ReplacedSNOsResponse(ReplacedSNOsResponse other)
			: this()
		{
			this.replacement_ = other.replacement_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000234C0 File Offset: 0x000216C0
		[DebuggerNonUserCode]
		public ReplacedSNOsResponse Clone()
		{
			return new ReplacedSNOsResponse(this);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000234D8 File Offset: 0x000216D8
		[DebuggerNonUserCode]
		public RepeatedField<ReplacedSNO> Replacement
		{
			get
			{
				return this.replacement_;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000234F0 File Offset: 0x000216F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplacedSNOsResponse);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00023510 File Offset: 0x00021710
		[DebuggerNonUserCode]
		public bool Equals(ReplacedSNOsResponse other)
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
					bool flag4 = !this.replacement_.Equals(other.replacement_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002356C File Offset: 0x0002176C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.replacement_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000235AC File Offset: 0x000217AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000235C4 File Offset: 0x000217C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000235D0 File Offset: 0x000217D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.replacement_.WriteTo(ref output, ReplacedSNOsResponse._repeated_replacement_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0002360C File Offset: 0x0002180C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.replacement_.CalculateSize(ReplacedSNOsResponse._repeated_replacement_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00023654 File Offset: 0x00021854
		[DebuggerNonUserCode]
		public void MergeFrom(ReplacedSNOsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.replacement_.Add(other.replacement_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00023696 File Offset: 0x00021896
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000236A4 File Offset: 0x000218A4
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
					this.replacement_.AddEntriesFrom(ref input, ReplacedSNOsResponse._repeated_replacement_codec);
				}
			}
		}

		// Token: 0x0400037A RID: 890
		private static readonly MessageParser<ReplacedSNOsResponse> _parser = new MessageParser<ReplacedSNOsResponse>(() => new ReplacedSNOsResponse());

		// Token: 0x0400037B RID: 891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400037C RID: 892
		public const int ReplacementFieldNumber = 1;

		// Token: 0x0400037D RID: 893
		private static readonly FieldCodec<ReplacedSNO> _repeated_replacement_codec = FieldCodec.ForMessage<ReplacedSNO>(10U, ReplacedSNO.Parser);

		// Token: 0x0400037E RID: 894
		private readonly RepeatedField<ReplacedSNO> replacement_ = new RepeatedField<ReplacedSNO>();
	}
}
