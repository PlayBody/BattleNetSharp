using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C9 RID: 457
	public sealed class ZoneProgressWorldToDPOData : IMessage<ZoneProgressWorldToDPOData>, IMessage, IEquatable<ZoneProgressWorldToDPOData>, IDeepCloneable<ZoneProgressWorldToDPOData>, IBufferMessage
	{
		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x000C0DEC File Offset: 0x000BEFEC
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgressWorldToDPOData> Parser
		{
			get
			{
				return ZoneProgressWorldToDPOData._parser;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x000C0E04 File Offset: 0x000BF004
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x000C0E28 File Offset: 0x000BF028
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgressWorldToDPOData.Descriptor;
			}
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000C0E3F File Offset: 0x000BF03F
		[DebuggerNonUserCode]
		public ZoneProgressWorldToDPOData()
		{
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x000C0E54 File Offset: 0x000BF054
		[DebuggerNonUserCode]
		public ZoneProgressWorldToDPOData(ZoneProgressWorldToDPOData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.snoDungeonQuests_ = other.snoDungeonQuests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x000C0EA4 File Offset: 0x000BF0A4
		[DebuggerNonUserCode]
		public ZoneProgressWorldToDPOData Clone()
		{
			return new ZoneProgressWorldToDPOData(this);
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000C0EBC File Offset: 0x000BF0BC
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x000C0EED File Offset: 0x000BF0ED
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = ZoneProgressWorldToDPOData.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000C0F08 File Offset: 0x000BF108
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x000C0F25 File Offset: 0x000BF125
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000C0F38 File Offset: 0x000BF138
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoDungeonQuests
		{
			get
			{
				return this.snoDungeonQuests_;
			}
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000C0F50 File Offset: 0x000BF150
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgressWorldToDPOData);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000C0F70 File Offset: 0x000BF170
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgressWorldToDPOData other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.snoDungeonQuests_.Equals(other.snoDungeonQuests_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000C0FE4 File Offset: 0x000BF1E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			num ^= this.snoDungeonQuests_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000C1044 File Offset: 0x000BF244
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000C105C File Offset: 0x000BF25C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000C1068 File Offset: 0x000BF268
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			this.snoDungeonQuests_.WriteTo(ref output, ZoneProgressWorldToDPOData._repeated_snoDungeonQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000C10C8 File Offset: 0x000BF2C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			num += this.snoDungeonQuests_.CalculateSize(ZoneProgressWorldToDPOData._repeated_snoDungeonQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000C1120 File Offset: 0x000BF320
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgressWorldToDPOData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				this.snoDungeonQuests_.Add(other.snoDungeonQuests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000C117B File Offset: 0x000BF37B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000C1188 File Offset: 0x000BF388
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 18U && num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.snoDungeonQuests_.AddEntriesFrom(ref input, ZoneProgressWorldToDPOData._repeated_snoDungeonQuests_codec);
					}
				}
				else
				{
					this.SnoWorld = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001640 RID: 5696
		private static readonly MessageParser<ZoneProgressWorldToDPOData> _parser = new MessageParser<ZoneProgressWorldToDPOData>(() => new ZoneProgressWorldToDPOData());

		// Token: 0x04001641 RID: 5697
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001642 RID: 5698
		private int _hasBits0;

		// Token: 0x04001643 RID: 5699
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04001644 RID: 5700
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04001645 RID: 5701
		private int snoWorld_;

		// Token: 0x04001646 RID: 5702
		public const int SnoDungeonQuestsFieldNumber = 2;

		// Token: 0x04001647 RID: 5703
		private static readonly FieldCodec<int> _repeated_snoDungeonQuests_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x04001648 RID: 5704
		private readonly RepeatedField<int> snoDungeonQuests_ = new RepeatedField<int>();
	}
}
