using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038E RID: 910
	public sealed class NoData : IMessage<NoData>, IMessage, IEquatable<NoData>, IDeepCloneable<NoData>, IBufferMessage
	{
		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x0016521C File Offset: 0x0016341C
		[DebuggerNonUserCode]
		public static MessageParser<NoData> Parser
		{
			get
			{
				return NoData._parser;
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x00165234 File Offset: 0x00163434
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x00165258 File Offset: 0x00163458
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NoData.Descriptor;
			}
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x0016526F File Offset: 0x0016346F
		[DebuggerNonUserCode]
		public NoData()
		{
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00165279 File Offset: 0x00163479
		[DebuggerNonUserCode]
		public NoData(NoData other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x00165294 File Offset: 0x00163494
		[DebuggerNonUserCode]
		public NoData Clone()
		{
			return new NoData(this);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x001652AC File Offset: 0x001634AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NoData);
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x001652CC File Offset: 0x001634CC
		[DebuggerNonUserCode]
		public bool Equals(NoData other)
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

		// Token: 0x06005C58 RID: 23640 RVA: 0x0016530C File Offset: 0x0016350C
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

		// Token: 0x06005C59 RID: 23641 RVA: 0x00165340 File Offset: 0x00163540
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x00165358 File Offset: 0x00163558
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x00165364 File Offset: 0x00163564
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00165390 File Offset: 0x00163590
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

		// Token: 0x06005C5D RID: 23645 RVA: 0x001653C4 File Offset: 0x001635C4
		[DebuggerNonUserCode]
		public void MergeFrom(NoData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x001653F4 File Offset: 0x001635F4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00165400 File Offset: 0x00163600
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A28 RID: 10792
		private static readonly MessageParser<NoData> _parser = new MessageParser<NoData>(() => new NoData());

		// Token: 0x04002A29 RID: 10793
		private UnknownFieldSet _unknownFields;
	}
}
