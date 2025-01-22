using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000019 RID: 25
	public sealed class WwiseSoundBankIDsToNameRequest : IMessage<WwiseSoundBankIDsToNameRequest>, IMessage, IEquatable<WwiseSoundBankIDsToNameRequest>, IDeepCloneable<WwiseSoundBankIDsToNameRequest>, IBufferMessage
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000B13C File Offset: 0x0000933C
		[DebuggerNonUserCode]
		public static MessageParser<WwiseSoundBankIDsToNameRequest> Parser
		{
			get
			{
				return WwiseSoundBankIDsToNameRequest._parser;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000B154 File Offset: 0x00009354
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000B178 File Offset: 0x00009378
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WwiseSoundBankIDsToNameRequest.Descriptor;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000B18F File Offset: 0x0000938F
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameRequest()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000B199 File Offset: 0x00009399
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameRequest(WwiseSoundBankIDsToNameRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sno_ = other.sno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000B1CC File Offset: 0x000093CC
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameRequest Clone()
		{
			return new WwiseSoundBankIDsToNameRequest(this);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000B1E4 File Offset: 0x000093E4
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000B215 File Offset: 0x00009415
		[DebuggerNonUserCode]
		public int Sno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoDefaultValue;
				if (flag)
				{
					snoDefaultValue = this.sno_;
				}
				else
				{
					snoDefaultValue = WwiseSoundBankIDsToNameRequest.SnoDefaultValue;
				}
				return snoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno_ = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000B230 File Offset: 0x00009430
		[DebuggerNonUserCode]
		public bool HasSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000B24D File Offset: 0x0000944D
		[DebuggerNonUserCode]
		public void ClearSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000B260 File Offset: 0x00009460
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WwiseSoundBankIDsToNameRequest);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000B280 File Offset: 0x00009480
		[DebuggerNonUserCode]
		public bool Equals(WwiseSoundBankIDsToNameRequest other)
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
					bool flag4 = this.Sno != other.Sno;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000B2D8 File Offset: 0x000094D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num ^= this.Sno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000B328 File Offset: 0x00009528
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000B340 File Offset: 0x00009540
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000B34C File Offset: 0x0000954C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000B398 File Offset: 0x00009598
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[DebuggerNonUserCode]
		public void MergeFrom(WwiseSoundBankIDsToNameRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSno = other.HasSno;
				if (hasSno)
				{
					this.Sno = other.Sno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000B431 File Offset: 0x00009631
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000B43C File Offset: 0x0000963C
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
					this.Sno = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly MessageParser<WwiseSoundBankIDsToNameRequest> _parser = new MessageParser<WwiseSoundBankIDsToNameRequest>(() => new WwiseSoundBankIDsToNameRequest());

		// Token: 0x04000093 RID: 147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000094 RID: 148
		private int _hasBits0;

		// Token: 0x04000095 RID: 149
		public const int SnoFieldNumber = 1;

		// Token: 0x04000096 RID: 150
		private static readonly int SnoDefaultValue = 0;

		// Token: 0x04000097 RID: 151
		private int sno_;
	}
}
