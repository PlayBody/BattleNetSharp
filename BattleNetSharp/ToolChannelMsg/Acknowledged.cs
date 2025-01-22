using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001F RID: 31
	public sealed class Acknowledged : IMessage<Acknowledged>, IMessage, IEquatable<Acknowledged>, IDeepCloneable<Acknowledged>, IBufferMessage
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C520 File Offset: 0x0000A720
		[DebuggerNonUserCode]
		public static MessageParser<Acknowledged> Parser
		{
			get
			{
				return Acknowledged._parser;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000C538 File Offset: 0x0000A738
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C55C File Offset: 0x0000A75C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Acknowledged.Descriptor;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000C573 File Offset: 0x0000A773
		[DebuggerNonUserCode]
		public Acknowledged()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000C57D File Offset: 0x0000A77D
		[DebuggerNonUserCode]
		public Acknowledged(Acknowledged other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000C598 File Offset: 0x0000A798
		[DebuggerNonUserCode]
		public Acknowledged Clone()
		{
			return new Acknowledged(this);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Acknowledged);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[DebuggerNonUserCode]
		public bool Equals(Acknowledged other)
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

		// Token: 0x06000185 RID: 389 RVA: 0x0000C610 File Offset: 0x0000A810
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

		// Token: 0x06000186 RID: 390 RVA: 0x0000C644 File Offset: 0x0000A844
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000C65C File Offset: 0x0000A85C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000C668 File Offset: 0x0000A868
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000C694 File Offset: 0x0000A894
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

		// Token: 0x0600018A RID: 394 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		[DebuggerNonUserCode]
		public void MergeFrom(Acknowledged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000C704 File Offset: 0x0000A904
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly MessageParser<Acknowledged> _parser = new MessageParser<Acknowledged>(() => new Acknowledged());

		// Token: 0x040000B3 RID: 179
		private UnknownFieldSet _unknownFields;
	}
}
