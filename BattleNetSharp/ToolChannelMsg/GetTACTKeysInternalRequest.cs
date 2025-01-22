using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000104 RID: 260
	public sealed class GetTACTKeysInternalRequest : IMessage<GetTACTKeysInternalRequest>, IMessage, IEquatable<GetTACTKeysInternalRequest>, IDeepCloneable<GetTACTKeysInternalRequest>, IBufferMessage
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00058554 File Offset: 0x00056754
		[DebuggerNonUserCode]
		public static MessageParser<GetTACTKeysInternalRequest> Parser
		{
			get
			{
				return GetTACTKeysInternalRequest._parser;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0005856C File Offset: 0x0005676C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[237];
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00058594 File Offset: 0x00056794
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTACTKeysInternalRequest.Descriptor;
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000585AB File Offset: 0x000567AB
		[DebuggerNonUserCode]
		public GetTACTKeysInternalRequest()
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000585B5 File Offset: 0x000567B5
		[DebuggerNonUserCode]
		public GetTACTKeysInternalRequest(GetTACTKeysInternalRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000585D0 File Offset: 0x000567D0
		[DebuggerNonUserCode]
		public GetTACTKeysInternalRequest Clone()
		{
			return new GetTACTKeysInternalRequest(this);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000585E8 File Offset: 0x000567E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTACTKeysInternalRequest);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00058608 File Offset: 0x00056808
		[DebuggerNonUserCode]
		public bool Equals(GetTACTKeysInternalRequest other)
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

		// Token: 0x060018DD RID: 6365 RVA: 0x00058648 File Offset: 0x00056848
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

		// Token: 0x060018DE RID: 6366 RVA: 0x0005867C File Offset: 0x0005687C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00058694 File Offset: 0x00056894
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000586A0 File Offset: 0x000568A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000586CC File Offset: 0x000568CC
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

		// Token: 0x060018E2 RID: 6370 RVA: 0x00058700 File Offset: 0x00056900
		[DebuggerNonUserCode]
		public void MergeFrom(GetTACTKeysInternalRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00058730 File Offset: 0x00056930
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0005873C File Offset: 0x0005693C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly MessageParser<GetTACTKeysInternalRequest> _parser = new MessageParser<GetTACTKeysInternalRequest>(() => new GetTACTKeysInternalRequest());

		// Token: 0x040009E2 RID: 2530
		private UnknownFieldSet _unknownFields;
	}
}
