using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000040 RID: 64
	public sealed class SetBnetServerMode : IMessage<SetBnetServerMode>, IMessage, IEquatable<SetBnetServerMode>, IDeepCloneable<SetBnetServerMode>, IBufferMessage
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00017E30 File Offset: 0x00016030
		[DebuggerNonUserCode]
		public static MessageParser<SetBnetServerMode> Parser
		{
			get
			{
				return SetBnetServerMode._parser;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00017E48 File Offset: 0x00016048
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[41];
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00017E6C File Offset: 0x0001606C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBnetServerMode.Descriptor;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00017E83 File Offset: 0x00016083
		[DebuggerNonUserCode]
		public SetBnetServerMode()
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00017E8D File Offset: 0x0001608D
		[DebuggerNonUserCode]
		public SetBnetServerMode(SetBnetServerMode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00017EC0 File Offset: 0x000160C0
		[DebuggerNonUserCode]
		public SetBnetServerMode Clone()
		{
			return new SetBnetServerMode(this);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00017ED8 File Offset: 0x000160D8
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00017F09 File Offset: 0x00016109
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = SetBnetServerMode.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00017F24 File Offset: 0x00016124
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00017F41 File Offset: 0x00016141
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00017F54 File Offset: 0x00016154
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBnetServerMode);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00017F74 File Offset: 0x00016174
		[DebuggerNonUserCode]
		public bool Equals(SetBnetServerMode other)
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
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.Enabled != other.Enabled;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00017FCC File Offset: 0x000161CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001801C File Offset: 0x0001621C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00018034 File Offset: 0x00016234
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00018040 File Offset: 0x00016240
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001808C File Offset: 0x0001628C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000180D0 File Offset: 0x000162D0
		[DebuggerNonUserCode]
		public void MergeFrom(SetBnetServerMode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00018119 File Offset: 0x00016319
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00018124 File Offset: 0x00016324
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x0400021D RID: 541
		private static readonly MessageParser<SetBnetServerMode> _parser = new MessageParser<SetBnetServerMode>(() => new SetBnetServerMode());

		// Token: 0x0400021E RID: 542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400021F RID: 543
		private int _hasBits0;

		// Token: 0x04000220 RID: 544
		public const int EnabledFieldNumber = 1;

		// Token: 0x04000221 RID: 545
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x04000222 RID: 546
		private bool enabled_;
	}
}
