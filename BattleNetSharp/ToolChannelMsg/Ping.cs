using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001E RID: 30
	public sealed class Ping : IMessage<Ping>, IMessage, IEquatable<Ping>, IDeepCloneable<Ping>, IBufferMessage
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		[DebuggerNonUserCode]
		public static MessageParser<Ping> Parser
		{
			get
			{
				return Ping._parser;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000C320 File Offset: 0x0000A520
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Ping.Descriptor;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000C337 File Offset: 0x0000A537
		[DebuggerNonUserCode]
		public Ping()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C341 File Offset: 0x0000A541
		[DebuggerNonUserCode]
		public Ping(Ping other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000C35C File Offset: 0x0000A55C
		[DebuggerNonUserCode]
		public Ping Clone()
		{
			return new Ping(this);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000C374 File Offset: 0x0000A574
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Ping);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000C394 File Offset: 0x0000A594
		[DebuggerNonUserCode]
		public bool Equals(Ping other)
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

		// Token: 0x06000174 RID: 372 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
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

		// Token: 0x06000175 RID: 373 RVA: 0x0000C408 File Offset: 0x0000A608
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000C420 File Offset: 0x0000A620
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000C42C File Offset: 0x0000A62C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000C458 File Offset: 0x0000A658
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

		// Token: 0x06000179 RID: 377 RVA: 0x0000C48C File Offset: 0x0000A68C
		[DebuggerNonUserCode]
		public void MergeFrom(Ping other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly MessageParser<Ping> _parser = new MessageParser<Ping>(() => new Ping());

		// Token: 0x040000B1 RID: 177
		private UnknownFieldSet _unknownFields;
	}
}
