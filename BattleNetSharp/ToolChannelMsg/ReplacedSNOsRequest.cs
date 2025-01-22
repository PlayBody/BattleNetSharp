using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000064 RID: 100
	public sealed class ReplacedSNOsRequest : IMessage<ReplacedSNOsRequest>, IMessage, IEquatable<ReplacedSNOsRequest>, IDeepCloneable<ReplacedSNOsRequest>, IBufferMessage
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000231F0 File Offset: 0x000213F0
		[DebuggerNonUserCode]
		public static MessageParser<ReplacedSNOsRequest> Parser
		{
			get
			{
				return ReplacedSNOsRequest._parser;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00023208 File Offset: 0x00021408
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[77];
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0002322C File Offset: 0x0002142C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplacedSNOsRequest.Descriptor;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00023243 File Offset: 0x00021443
		[DebuggerNonUserCode]
		public ReplacedSNOsRequest()
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002324D File Offset: 0x0002144D
		[DebuggerNonUserCode]
		public ReplacedSNOsRequest(ReplacedSNOsRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00023268 File Offset: 0x00021468
		[DebuggerNonUserCode]
		public ReplacedSNOsRequest Clone()
		{
			return new ReplacedSNOsRequest(this);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00023280 File Offset: 0x00021480
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplacedSNOsRequest);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000232A0 File Offset: 0x000214A0
		[DebuggerNonUserCode]
		public bool Equals(ReplacedSNOsRequest other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000232E0 File Offset: 0x000214E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00023314 File Offset: 0x00021514
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0002332C File Offset: 0x0002152C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00023338 File Offset: 0x00021538
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00023364 File Offset: 0x00021564
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00023398 File Offset: 0x00021598
		[DebuggerNonUserCode]
		public void MergeFrom(ReplacedSNOsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000233C8 File Offset: 0x000215C8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000233D4 File Offset: 0x000215D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000378 RID: 888
		private static readonly MessageParser<ReplacedSNOsRequest> _parser = new MessageParser<ReplacedSNOsRequest>(() => new ReplacedSNOsRequest());

		// Token: 0x04000379 RID: 889
		private UnknownFieldSet _unknownFields;
	}
}
