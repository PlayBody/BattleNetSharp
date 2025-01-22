using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000025 RID: 37
	public sealed class HolodeckControllerEnabled : IMessage<HolodeckControllerEnabled>, IMessage, IEquatable<HolodeckControllerEnabled>, IDeepCloneable<HolodeckControllerEnabled>, IBufferMessage
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000DC64 File Offset: 0x0000BE64
		[DebuggerNonUserCode]
		public static MessageParser<HolodeckControllerEnabled> Parser
		{
			get
			{
				return HolodeckControllerEnabled._parser;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HolodeckControllerEnabled.Descriptor;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000DCB7 File Offset: 0x0000BEB7
		[DebuggerNonUserCode]
		public HolodeckControllerEnabled()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000DCC1 File Offset: 0x0000BEC1
		[DebuggerNonUserCode]
		public HolodeckControllerEnabled(HolodeckControllerEnabled other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this.holodeckId_ = other.holodeckId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000DD00 File Offset: 0x0000BF00
		[DebuggerNonUserCode]
		public HolodeckControllerEnabled Clone()
		{
			return new HolodeckControllerEnabled(this);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000DD18 File Offset: 0x0000BF18
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000DD49 File Offset: 0x0000BF49
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
					enabledDefaultValue = HolodeckControllerEnabled.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000DD64 File Offset: 0x0000BF64
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000DD81 File Offset: 0x0000BF81
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000DD94 File Offset: 0x0000BF94
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000DDC5 File Offset: 0x0000BFC5
		[DebuggerNonUserCode]
		public int HolodeckId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int holodeckIdDefaultValue;
				if (flag)
				{
					holodeckIdDefaultValue = this.holodeckId_;
				}
				else
				{
					holodeckIdDefaultValue = HolodeckControllerEnabled.HolodeckIdDefaultValue;
				}
				return holodeckIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.holodeckId_ = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[DebuggerNonUserCode]
		public bool HasHolodeckId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000DDFD File Offset: 0x0000BFFD
		[DebuggerNonUserCode]
		public void ClearHolodeckId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000DE10 File Offset: 0x0000C010
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HolodeckControllerEnabled);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000DE30 File Offset: 0x0000C030
		[DebuggerNonUserCode]
		public bool Equals(HolodeckControllerEnabled other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HolodeckId != other.HolodeckId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num ^= this.HolodeckId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000DF14 File Offset: 0x0000C114
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000DF2C File Offset: 0x0000C12C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000DF38 File Offset: 0x0000C138
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HolodeckId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num += 2;
			}
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HolodeckId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000E008 File Offset: 0x0000C208
		[DebuggerNonUserCode]
		public void MergeFrom(HolodeckControllerEnabled other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				bool hasHolodeckId = other.HasHolodeckId;
				if (hasHolodeckId)
				{
					this.HolodeckId = other.HolodeckId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000E06A File Offset: 0x0000C26A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000E078 File Offset: 0x0000C278
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HolodeckId = input.ReadInt32();
					}
				}
				else
				{
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly MessageParser<HolodeckControllerEnabled> _parser = new MessageParser<HolodeckControllerEnabled>(() => new HolodeckControllerEnabled());

		// Token: 0x040000DA RID: 218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000DB RID: 219
		private int _hasBits0;

		// Token: 0x040000DC RID: 220
		public const int EnabledFieldNumber = 1;

		// Token: 0x040000DD RID: 221
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x040000DE RID: 222
		private bool enabled_;

		// Token: 0x040000DF RID: 223
		public const int HolodeckIdFieldNumber = 2;

		// Token: 0x040000E0 RID: 224
		private static readonly int HolodeckIdDefaultValue = 0;

		// Token: 0x040000E1 RID: 225
		private int holodeckId_;
	}
}
