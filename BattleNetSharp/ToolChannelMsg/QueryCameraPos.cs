using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001D RID: 29
	public sealed class QueryCameraPos : IMessage<QueryCameraPos>, IMessage, IEquatable<QueryCameraPos>, IDeepCloneable<QueryCameraPos>, IBufferMessage
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[DebuggerNonUserCode]
		public static MessageParser<QueryCameraPos> Parser
		{
			get
			{
				return QueryCameraPos._parser;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryCameraPos.Descriptor;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000C0FB File Offset: 0x0000A2FB
		[DebuggerNonUserCode]
		public QueryCameraPos()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000C105 File Offset: 0x0000A305
		[DebuggerNonUserCode]
		public QueryCameraPos(QueryCameraPos other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000C120 File Offset: 0x0000A320
		[DebuggerNonUserCode]
		public QueryCameraPos Clone()
		{
			return new QueryCameraPos(this);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000C138 File Offset: 0x0000A338
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryCameraPos);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000C158 File Offset: 0x0000A358
		[DebuggerNonUserCode]
		public bool Equals(QueryCameraPos other)
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

		// Token: 0x06000163 RID: 355 RVA: 0x0000C198 File Offset: 0x0000A398
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

		// Token: 0x06000164 RID: 356 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000C21C File Offset: 0x0000A41C
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

		// Token: 0x06000168 RID: 360 RVA: 0x0000C250 File Offset: 0x0000A450
		[DebuggerNonUserCode]
		public void MergeFrom(QueryCameraPos other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000C280 File Offset: 0x0000A480
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000C28C File Offset: 0x0000A48C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000AE RID: 174
		private static readonly MessageParser<QueryCameraPos> _parser = new MessageParser<QueryCameraPos>(() => new QueryCameraPos());

		// Token: 0x040000AF RID: 175
		private UnknownFieldSet _unknownFields;
	}
}
