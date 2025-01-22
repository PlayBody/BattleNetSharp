using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008B RID: 139
	public sealed class AxeQueryDebugRenderState : IMessage<AxeQueryDebugRenderState>, IMessage, IEquatable<AxeQueryDebugRenderState>, IDeepCloneable<AxeQueryDebugRenderState>, IBufferMessage
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00030660 File Offset: 0x0002E860
		[DebuggerNonUserCode]
		public static MessageParser<AxeQueryDebugRenderState> Parser
		{
			get
			{
				return AxeQueryDebugRenderState._parser;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00030678 File Offset: 0x0002E878
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[116];
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0003069C File Offset: 0x0002E89C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxeQueryDebugRenderState.Descriptor;
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000306B3 File Offset: 0x0002E8B3
		[DebuggerNonUserCode]
		public AxeQueryDebugRenderState()
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000306BD File Offset: 0x0002E8BD
		[DebuggerNonUserCode]
		public AxeQueryDebugRenderState(AxeQueryDebugRenderState other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000306D8 File Offset: 0x0002E8D8
		[DebuggerNonUserCode]
		public AxeQueryDebugRenderState Clone()
		{
			return new AxeQueryDebugRenderState(this);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000306F0 File Offset: 0x0002E8F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxeQueryDebugRenderState);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00030710 File Offset: 0x0002E910
		[DebuggerNonUserCode]
		public bool Equals(AxeQueryDebugRenderState other)
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

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00030750 File Offset: 0x0002E950
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

		// Token: 0x06000CAA RID: 3242 RVA: 0x00030784 File Offset: 0x0002E984
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003079C File Offset: 0x0002E99C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000307A8 File Offset: 0x0002E9A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000307D4 File Offset: 0x0002E9D4
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

		// Token: 0x06000CAE RID: 3246 RVA: 0x00030808 File Offset: 0x0002EA08
		[DebuggerNonUserCode]
		public void MergeFrom(AxeQueryDebugRenderState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00030838 File Offset: 0x0002EA38
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00030844 File Offset: 0x0002EA44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400051E RID: 1310
		private static readonly MessageParser<AxeQueryDebugRenderState> _parser = new MessageParser<AxeQueryDebugRenderState>(() => new AxeQueryDebugRenderState());

		// Token: 0x0400051F RID: 1311
		private UnknownFieldSet _unknownFields;
	}
}
