using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000098 RID: 152
	public sealed class ResetUITree : IMessage<ResetUITree>, IMessage, IEquatable<ResetUITree>, IDeepCloneable<ResetUITree>, IBufferMessage
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00034BC4 File Offset: 0x00032DC4
		[DebuggerNonUserCode]
		public static MessageParser<ResetUITree> Parser
		{
			get
			{
				return ResetUITree._parser;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00034BDC File Offset: 0x00032DDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[129];
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00034C04 File Offset: 0x00032E04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetUITree.Descriptor;
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00034C1B File Offset: 0x00032E1B
		[DebuggerNonUserCode]
		public ResetUITree()
		{
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00034C25 File Offset: 0x00032E25
		[DebuggerNonUserCode]
		public ResetUITree(ResetUITree other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00034C40 File Offset: 0x00032E40
		[DebuggerNonUserCode]
		public ResetUITree Clone()
		{
			return new ResetUITree(this);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00034C58 File Offset: 0x00032E58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetUITree);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00034C78 File Offset: 0x00032E78
		[DebuggerNonUserCode]
		public bool Equals(ResetUITree other)
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

		// Token: 0x06000DFD RID: 3581 RVA: 0x00034CB8 File Offset: 0x00032EB8
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

		// Token: 0x06000DFE RID: 3582 RVA: 0x00034CEC File Offset: 0x00032EEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00034D04 File Offset: 0x00032F04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00034D10 File Offset: 0x00032F10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00034D3C File Offset: 0x00032F3C
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

		// Token: 0x06000E02 RID: 3586 RVA: 0x00034D70 File Offset: 0x00032F70
		[DebuggerNonUserCode]
		public void MergeFrom(ResetUITree other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00034DA0 File Offset: 0x00032FA0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00034DAC File Offset: 0x00032FAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005A3 RID: 1443
		private static readonly MessageParser<ResetUITree> _parser = new MessageParser<ResetUITree>(() => new ResetUITree());

		// Token: 0x040005A4 RID: 1444
		private UnknownFieldSet _unknownFields;
	}
}
