using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029D RID: 669
	public sealed class MultiplayerAllowed : IMessage<MultiplayerAllowed>, IMessage, IEquatable<MultiplayerAllowed>, IDeepCloneable<MultiplayerAllowed>, IBufferMessage
	{
		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x0010EDAC File Offset: 0x0010CFAC
		[DebuggerNonUserCode]
		public static MessageParser<MultiplayerAllowed> Parser
		{
			get
			{
				return MultiplayerAllowed._parser;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0010EDC4 File Offset: 0x0010CFC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[141];
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x0010EDEC File Offset: 0x0010CFEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerAllowed.Descriptor;
			}
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x0010EE03 File Offset: 0x0010D003
		[DebuggerNonUserCode]
		public MultiplayerAllowed()
		{
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0010EE0D File Offset: 0x0010D00D
		[DebuggerNonUserCode]
		public MultiplayerAllowed(MultiplayerAllowed other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isMultiplayerAllowed_ = other.isMultiplayerAllowed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x0010EE40 File Offset: 0x0010D040
		[DebuggerNonUserCode]
		public MultiplayerAllowed Clone()
		{
			return new MultiplayerAllowed(this);
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0010EE58 File Offset: 0x0010D058
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x0010EE89 File Offset: 0x0010D089
		[DebuggerNonUserCode]
		public bool IsMultiplayerAllowed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isMultiplayerAllowedDefaultValue;
				if (flag)
				{
					isMultiplayerAllowedDefaultValue = this.isMultiplayerAllowed_;
				}
				else
				{
					isMultiplayerAllowedDefaultValue = MultiplayerAllowed.IsMultiplayerAllowedDefaultValue;
				}
				return isMultiplayerAllowedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isMultiplayerAllowed_ = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x0010EEA4 File Offset: 0x0010D0A4
		[DebuggerNonUserCode]
		public bool HasIsMultiplayerAllowed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x0010EEC1 File Offset: 0x0010D0C1
		[DebuggerNonUserCode]
		public void ClearIsMultiplayerAllowed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x0010EED4 File Offset: 0x0010D0D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerAllowed);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x0010EEF4 File Offset: 0x0010D0F4
		[DebuggerNonUserCode]
		public bool Equals(MultiplayerAllowed other)
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
					bool flag4 = this.IsMultiplayerAllowed != other.IsMultiplayerAllowed;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x0010EF4C File Offset: 0x0010D14C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
			{
				num ^= this.IsMultiplayerAllowed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0010EF9C File Offset: 0x0010D19C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0010EFB4 File Offset: 0x0010D1B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x0010EFC0 File Offset: 0x0010D1C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsMultiplayerAllowed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x0010F00C File Offset: 0x0010D20C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
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

		// Token: 0x060046E5 RID: 18149 RVA: 0x0010F050 File Offset: 0x0010D250
		[DebuggerNonUserCode]
		public void MergeFrom(MultiplayerAllowed other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsMultiplayerAllowed = other.HasIsMultiplayerAllowed;
				if (hasIsMultiplayerAllowed)
				{
					this.IsMultiplayerAllowed = other.IsMultiplayerAllowed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0010F099 File Offset: 0x0010D299
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
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
					this.IsMultiplayerAllowed = input.ReadBool();
				}
			}
		}

		// Token: 0x04001F76 RID: 8054
		private static readonly MessageParser<MultiplayerAllowed> _parser = new MessageParser<MultiplayerAllowed>(() => new MultiplayerAllowed());

		// Token: 0x04001F77 RID: 8055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F78 RID: 8056
		private int _hasBits0;

		// Token: 0x04001F79 RID: 8057
		public const int IsMultiplayerAllowedFieldNumber = 1;

		// Token: 0x04001F7A RID: 8058
		private static readonly bool IsMultiplayerAllowedDefaultValue = false;

		// Token: 0x04001F7B RID: 8059
		private bool isMultiplayerAllowed_;
	}
}
