using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000186 RID: 390
	public sealed class SavedTransmogs : IMessage<SavedTransmogs>, IMessage, IEquatable<SavedTransmogs>, IDeepCloneable<SavedTransmogs>, IBufferMessage
	{
		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x0009FD8C File Offset: 0x0009DF8C
		[DebuggerNonUserCode]
		public static MessageParser<SavedTransmogs> Parser
		{
			get
			{
				return SavedTransmogs._parser;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x0009FDA4 File Offset: 0x0009DFA4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0009FDC8 File Offset: 0x0009DFC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedTransmogs.Descriptor;
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0009FDDF File Offset: 0x0009DFDF
		[DebuggerNonUserCode]
		public SavedTransmogs()
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0009FDF4 File Offset: 0x0009DFF4
		[DebuggerNonUserCode]
		public SavedTransmogs(SavedTransmogs other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.transmogs_ = other.transmogs_.Clone();
			this.unlocked_ = other.unlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0009FE44 File Offset: 0x0009E044
		[DebuggerNonUserCode]
		public SavedTransmogs Clone()
		{
			return new SavedTransmogs(this);
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x0009FE5C File Offset: 0x0009E05C
		[DebuggerNonUserCode]
		public RepeatedField<TransmogSlot> Transmogs
		{
			get
			{
				return this.transmogs_;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x0009FE74 File Offset: 0x0009E074
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x0009FEA5 File Offset: 0x0009E0A5
		[DebuggerNonUserCode]
		public bool Unlocked
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool unlockedDefaultValue;
				if (flag)
				{
					unlockedDefaultValue = this.unlocked_;
				}
				else
				{
					unlockedDefaultValue = SavedTransmogs.UnlockedDefaultValue;
				}
				return unlockedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unlocked_ = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		[DebuggerNonUserCode]
		public bool HasUnlocked
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0009FEDD File Offset: 0x0009E0DD
		[DebuggerNonUserCode]
		public void ClearUnlocked()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedTransmogs);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0009FF10 File Offset: 0x0009E110
		[DebuggerNonUserCode]
		public bool Equals(SavedTransmogs other)
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
					bool flag4 = !this.transmogs_.Equals(other.transmogs_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Unlocked != other.Unlocked;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0009FF84 File Offset: 0x0009E184
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.transmogs_.GetHashCode();
			bool hasUnlocked = this.HasUnlocked;
			if (hasUnlocked)
			{
				num ^= this.Unlocked.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0009FFE4 File Offset: 0x0009E1E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0009FFFC File Offset: 0x0009E1FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000A0008 File Offset: 0x0009E208
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.transmogs_.WriteTo(ref output, SavedTransmogs._repeated_transmogs_codec);
			bool hasUnlocked = this.HasUnlocked;
			if (hasUnlocked)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unlocked);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000A0068 File Offset: 0x0009E268
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.transmogs_.CalculateSize(SavedTransmogs._repeated_transmogs_codec);
			bool hasUnlocked = this.HasUnlocked;
			if (hasUnlocked)
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

		// Token: 0x06002902 RID: 10498 RVA: 0x000A00C0 File Offset: 0x0009E2C0
		[DebuggerNonUserCode]
		public void MergeFrom(SavedTransmogs other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.transmogs_.Add(other.transmogs_);
				bool hasUnlocked = other.HasUnlocked;
				if (hasUnlocked)
				{
					this.Unlocked = other.Unlocked;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000A011B File Offset: 0x0009E31B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000A0128 File Offset: 0x0009E328
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Unlocked = input.ReadBool();
					}
				}
				else
				{
					this.transmogs_.AddEntriesFrom(ref input, SavedTransmogs._repeated_transmogs_codec);
				}
			}
		}

		// Token: 0x04001238 RID: 4664
		private static readonly MessageParser<SavedTransmogs> _parser = new MessageParser<SavedTransmogs>(() => new SavedTransmogs());

		// Token: 0x04001239 RID: 4665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400123A RID: 4666
		private int _hasBits0;

		// Token: 0x0400123B RID: 4667
		public const int TransmogsFieldNumber = 1;

		// Token: 0x0400123C RID: 4668
		private static readonly FieldCodec<TransmogSlot> _repeated_transmogs_codec = FieldCodec.ForMessage<TransmogSlot>(10U, TransmogSlot.Parser);

		// Token: 0x0400123D RID: 4669
		private readonly RepeatedField<TransmogSlot> transmogs_ = new RepeatedField<TransmogSlot>();

		// Token: 0x0400123E RID: 4670
		public const int UnlockedFieldNumber = 2;

		// Token: 0x0400123F RID: 4671
		private static readonly bool UnlockedDefaultValue = false;

		// Token: 0x04001240 RID: 4672
		private bool unlocked_;
	}
}
