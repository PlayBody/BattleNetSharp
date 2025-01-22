using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000020 RID: 32
	public sealed class Completed : IMessage<Completed>, IMessage, IEquatable<Completed>, IDeepCloneable<Completed>, IBufferMessage
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000C75C File Offset: 0x0000A95C
		[DebuggerNonUserCode]
		public static MessageParser<Completed> Parser
		{
			get
			{
				return Completed._parser;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000C774 File Offset: 0x0000A974
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000C798 File Offset: 0x0000A998
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Completed.Descriptor;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000C7AF File Offset: 0x0000A9AF
		[DebuggerNonUserCode]
		public Completed()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000C7B9 File Offset: 0x0000A9B9
		[DebuggerNonUserCode]
		public Completed(Completed other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		[DebuggerNonUserCode]
		public Completed Clone()
		{
			return new Completed(this);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Completed);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000C80C File Offset: 0x0000AA0C
		[DebuggerNonUserCode]
		public bool Equals(Completed other)
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

		// Token: 0x06000196 RID: 406 RVA: 0x0000C84C File Offset: 0x0000AA4C
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

		// Token: 0x06000197 RID: 407 RVA: 0x0000C880 File Offset: 0x0000AA80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000C898 File Offset: 0x0000AA98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
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

		// Token: 0x0600019B RID: 411 RVA: 0x0000C904 File Offset: 0x0000AB04
		[DebuggerNonUserCode]
		public void MergeFrom(Completed other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000C934 File Offset: 0x0000AB34
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000C940 File Offset: 0x0000AB40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly MessageParser<Completed> _parser = new MessageParser<Completed>(() => new Completed());

		// Token: 0x040000B5 RID: 181
		private UnknownFieldSet _unknownFields;
	}
}
