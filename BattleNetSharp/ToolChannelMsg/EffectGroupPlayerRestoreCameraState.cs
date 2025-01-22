using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F6 RID: 246
	public sealed class EffectGroupPlayerRestoreCameraState : IMessage<EffectGroupPlayerRestoreCameraState>, IMessage, IEquatable<EffectGroupPlayerRestoreCameraState>, IDeepCloneable<EffectGroupPlayerRestoreCameraState>, IBufferMessage
	{
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0005570C File Offset: 0x0005390C
		[DebuggerNonUserCode]
		public static MessageParser<EffectGroupPlayerRestoreCameraState> Parser
		{
			get
			{
				return EffectGroupPlayerRestoreCameraState._parser;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00055724 File Offset: 0x00053924
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[223];
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0005574C File Offset: 0x0005394C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectGroupPlayerRestoreCameraState.Descriptor;
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00055763 File Offset: 0x00053963
		[DebuggerNonUserCode]
		public EffectGroupPlayerRestoreCameraState()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0005576D File Offset: 0x0005396D
		[DebuggerNonUserCode]
		public EffectGroupPlayerRestoreCameraState(EffectGroupPlayerRestoreCameraState other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00055788 File Offset: 0x00053988
		[DebuggerNonUserCode]
		public EffectGroupPlayerRestoreCameraState Clone()
		{
			return new EffectGroupPlayerRestoreCameraState(this);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000557A0 File Offset: 0x000539A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectGroupPlayerRestoreCameraState);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000557C0 File Offset: 0x000539C0
		[DebuggerNonUserCode]
		public bool Equals(EffectGroupPlayerRestoreCameraState other)
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

		// Token: 0x060017C3 RID: 6083 RVA: 0x00055800 File Offset: 0x00053A00
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

		// Token: 0x060017C4 RID: 6084 RVA: 0x00055834 File Offset: 0x00053A34
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0005584C File Offset: 0x00053A4C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00055858 File Offset: 0x00053A58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00055884 File Offset: 0x00053A84
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

		// Token: 0x060017C8 RID: 6088 RVA: 0x000558B8 File Offset: 0x00053AB8
		[DebuggerNonUserCode]
		public void MergeFrom(EffectGroupPlayerRestoreCameraState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000558E8 File Offset: 0x00053AE8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000558F4 File Offset: 0x00053AF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000995 RID: 2453
		private static readonly MessageParser<EffectGroupPlayerRestoreCameraState> _parser = new MessageParser<EffectGroupPlayerRestoreCameraState>(() => new EffectGroupPlayerRestoreCameraState());

		// Token: 0x04000996 RID: 2454
		private UnknownFieldSet _unknownFields;
	}
}
