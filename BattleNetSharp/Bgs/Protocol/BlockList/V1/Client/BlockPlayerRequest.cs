using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000702 RID: 1794
	public sealed class BlockPlayerRequest : IMessage<BlockPlayerRequest>, IMessage, IEquatable<BlockPlayerRequest>, IDeepCloneable<BlockPlayerRequest>, IBufferMessage
	{
		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600A4DE RID: 42206 RVA: 0x00282600 File Offset: 0x00280800
		[DebuggerNonUserCode]
		public static MessageParser<BlockPlayerRequest> Parser
		{
			get
			{
				return BlockPlayerRequest._parser;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x00282618 File Offset: 0x00280818
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A4E0 RID: 42208 RVA: 0x0028263C File Offset: 0x0028083C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x00282653 File Offset: 0x00280853
		[DebuggerNonUserCode]
		public BlockPlayerRequest()
		{
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x0028265D File Offset: 0x0028085D
		[DebuggerNonUserCode]
		public BlockPlayerRequest(BlockPlayerRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x00282694 File Offset: 0x00280894
		[DebuggerNonUserCode]
		public BlockPlayerRequest Clone()
		{
			return new BlockPlayerRequest(this);
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x002826AC File Offset: 0x002808AC
		// (set) Token: 0x0600A4E5 RID: 42213 RVA: 0x002826C4 File Offset: 0x002808C4
		[DebuggerNonUserCode]
		public BlockPlayerOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x002826D0 File Offset: 0x002808D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerRequest);
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x002826F0 File Offset: 0x002808F0
		[DebuggerNonUserCode]
		public bool Equals(BlockPlayerRequest other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x0028274C File Offset: 0x0028094C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x0028279C File Offset: 0x0028099C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x002827B4 File Offset: 0x002809B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x002827C0 File Offset: 0x002809C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x00282810 File Offset: 0x00280A10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x00282864 File Offset: 0x00280A64
		[DebuggerNonUserCode]
		public void MergeFrom(BlockPlayerRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new BlockPlayerOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x002828D0 File Offset: 0x00280AD0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x002828DC File Offset: 0x00280ADC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new BlockPlayerOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x04004A33 RID: 18995
		private static readonly MessageParser<BlockPlayerRequest> _parser = new MessageParser<BlockPlayerRequest>(() => new BlockPlayerRequest());

		// Token: 0x04004A34 RID: 18996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A35 RID: 18997
		public const int OptionsFieldNumber = 2;

		// Token: 0x04004A36 RID: 18998
		private BlockPlayerOptions options_;
	}
}
