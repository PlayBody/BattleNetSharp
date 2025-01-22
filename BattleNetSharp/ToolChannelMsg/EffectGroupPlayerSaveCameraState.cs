using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F5 RID: 245
	public sealed class EffectGroupPlayerSaveCameraState : IMessage<EffectGroupPlayerSaveCameraState>, IMessage, IEquatable<EffectGroupPlayerSaveCameraState>, IDeepCloneable<EffectGroupPlayerSaveCameraState>, IBufferMessage
	{
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000554CC File Offset: 0x000536CC
		[DebuggerNonUserCode]
		public static MessageParser<EffectGroupPlayerSaveCameraState> Parser
		{
			get
			{
				return EffectGroupPlayerSaveCameraState._parser;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000554E4 File Offset: 0x000536E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[222];
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0005550C File Offset: 0x0005370C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectGroupPlayerSaveCameraState.Descriptor;
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00055523 File Offset: 0x00053723
		[DebuggerNonUserCode]
		public EffectGroupPlayerSaveCameraState()
		{
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0005552D File Offset: 0x0005372D
		[DebuggerNonUserCode]
		public EffectGroupPlayerSaveCameraState(EffectGroupPlayerSaveCameraState other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00055548 File Offset: 0x00053748
		[DebuggerNonUserCode]
		public EffectGroupPlayerSaveCameraState Clone()
		{
			return new EffectGroupPlayerSaveCameraState(this);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00055560 File Offset: 0x00053760
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectGroupPlayerSaveCameraState);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00055580 File Offset: 0x00053780
		[DebuggerNonUserCode]
		public bool Equals(EffectGroupPlayerSaveCameraState other)
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

		// Token: 0x060017B2 RID: 6066 RVA: 0x000555C0 File Offset: 0x000537C0
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

		// Token: 0x060017B3 RID: 6067 RVA: 0x000555F4 File Offset: 0x000537F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0005560C File Offset: 0x0005380C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00055618 File Offset: 0x00053818
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00055644 File Offset: 0x00053844
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

		// Token: 0x060017B7 RID: 6071 RVA: 0x00055678 File Offset: 0x00053878
		[DebuggerNonUserCode]
		public void MergeFrom(EffectGroupPlayerSaveCameraState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000556A8 File Offset: 0x000538A8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000556B4 File Offset: 0x000538B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000993 RID: 2451
		private static readonly MessageParser<EffectGroupPlayerSaveCameraState> _parser = new MessageParser<EffectGroupPlayerSaveCameraState>(() => new EffectGroupPlayerSaveCameraState());

		// Token: 0x04000994 RID: 2452
		private UnknownFieldSet _unknownFields;
	}
}
