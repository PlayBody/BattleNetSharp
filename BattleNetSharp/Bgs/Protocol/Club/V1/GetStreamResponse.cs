using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D5 RID: 1237
	public sealed class GetStreamResponse : IMessage<GetStreamResponse>, IMessage, IEquatable<GetStreamResponse>, IDeepCloneable<GetStreamResponse>, IBufferMessage
	{
		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x001D3E0C File Offset: 0x001D200C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamResponse> Parser
		{
			get
			{
				return GetStreamResponse._parser;
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x001D3E24 File Offset: 0x001D2024
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[58];
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007841 RID: 30785 RVA: 0x001D3E48 File Offset: 0x001D2048
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamResponse.Descriptor;
			}
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x001D3E5F File Offset: 0x001D205F
		[DebuggerNonUserCode]
		public GetStreamResponse()
		{
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x001D3E69 File Offset: 0x001D2069
		[DebuggerNonUserCode]
		public GetStreamResponse(GetStreamResponse other)
			: this()
		{
			this.stream_ = ((other.stream_ != null) ? other.stream_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x001D3EA0 File Offset: 0x001D20A0
		[DebuggerNonUserCode]
		public GetStreamResponse Clone()
		{
			return new GetStreamResponse(this);
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x001D3EB8 File Offset: 0x001D20B8
		// (set) Token: 0x06007846 RID: 30790 RVA: 0x001D3ED0 File Offset: 0x001D20D0
		[DebuggerNonUserCode]
		public Stream Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x001D3EDC File Offset: 0x001D20DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamResponse);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x001D3EFC File Offset: 0x001D20FC
		[DebuggerNonUserCode]
		public bool Equals(GetStreamResponse other)
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
					bool flag4 = !object.Equals(this.Stream, other.Stream);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x001D3F58 File Offset: 0x001D2158
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.stream_ != null;
			if (flag)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x001D3FA8 File Offset: 0x001D21A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x001D3FC0 File Offset: 0x001D21C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x001D3FCC File Offset: 0x001D21CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.stream_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Stream);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x001D401C File Offset: 0x001D221C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.stream_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stream);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x001D4070 File Offset: 0x001D2270
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.stream_ != null;
				if (flag2)
				{
					bool flag3 = this.stream_ == null;
					if (flag3)
					{
						this.Stream = new Stream();
					}
					this.Stream.MergeFrom(other.Stream);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x001D40DC File Offset: 0x001D22DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x001D40E8 File Offset: 0x001D22E8
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
					bool flag = this.stream_ == null;
					if (flag)
					{
						this.Stream = new Stream();
					}
					input.ReadMessage(this.Stream);
				}
			}
		}

		// Token: 0x0400369B RID: 13979
		private static readonly MessageParser<GetStreamResponse> _parser = new MessageParser<GetStreamResponse>(() => new GetStreamResponse());

		// Token: 0x0400369C RID: 13980
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400369D RID: 13981
		public const int StreamFieldNumber = 1;

		// Token: 0x0400369E RID: 13982
		private Stream stream_;
	}
}
