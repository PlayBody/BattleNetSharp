using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F3 RID: 243
	public sealed class EffectGroupPlayerPause : IMessage<EffectGroupPlayerPause>, IMessage, IEquatable<EffectGroupPlayerPause>, IDeepCloneable<EffectGroupPlayerPause>, IBufferMessage
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00054DE4 File Offset: 0x00052FE4
		[DebuggerNonUserCode]
		public static MessageParser<EffectGroupPlayerPause> Parser
		{
			get
			{
				return EffectGroupPlayerPause._parser;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00054DFC File Offset: 0x00052FFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[220];
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00054E24 File Offset: 0x00053024
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectGroupPlayerPause.Descriptor;
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00054E3B File Offset: 0x0005303B
		[DebuggerNonUserCode]
		public EffectGroupPlayerPause()
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00054E45 File Offset: 0x00053045
		[DebuggerNonUserCode]
		public EffectGroupPlayerPause(EffectGroupPlayerPause other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00054E60 File Offset: 0x00053060
		[DebuggerNonUserCode]
		public EffectGroupPlayerPause Clone()
		{
			return new EffectGroupPlayerPause(this);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00054E78 File Offset: 0x00053078
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectGroupPlayerPause);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00054E98 File Offset: 0x00053098
		[DebuggerNonUserCode]
		public bool Equals(EffectGroupPlayerPause other)
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

		// Token: 0x06001788 RID: 6024 RVA: 0x00054ED8 File Offset: 0x000530D8
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

		// Token: 0x06001789 RID: 6025 RVA: 0x00054F0C File Offset: 0x0005310C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00054F24 File Offset: 0x00053124
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00054F30 File Offset: 0x00053130
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00054F5C File Offset: 0x0005315C
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

		// Token: 0x0600178D RID: 6029 RVA: 0x00054F90 File Offset: 0x00053190
		[DebuggerNonUserCode]
		public void MergeFrom(EffectGroupPlayerPause other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00054FC0 File Offset: 0x000531C0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00054FCC File Offset: 0x000531CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000988 RID: 2440
		private static readonly MessageParser<EffectGroupPlayerPause> _parser = new MessageParser<EffectGroupPlayerPause>(() => new EffectGroupPlayerPause());

		// Token: 0x04000989 RID: 2441
		private UnknownFieldSet _unknownFields;
	}
}
