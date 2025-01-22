using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F7 RID: 503
	public sealed class DebugLootOutputUpdateMessage : IMessage<DebugLootOutputUpdateMessage>, IMessage, IEquatable<DebugLootOutputUpdateMessage>, IDeepCloneable<DebugLootOutputUpdateMessage>, IBufferMessage
	{
		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x000D9BEC File Offset: 0x000D7DEC
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootOutputUpdateMessage> Parser
		{
			get
			{
				return DebugLootOutputUpdateMessage._parser;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x000D9C04 File Offset: 0x000D7E04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[60];
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x000D9C28 File Offset: 0x000D7E28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootOutputUpdateMessage.Descriptor;
			}
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x000D9C3F File Offset: 0x000D7E3F
		[DebuggerNonUserCode]
		public DebugLootOutputUpdateMessage()
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x000D9C54 File Offset: 0x000D7E54
		[DebuggerNonUserCode]
		public DebugLootOutputUpdateMessage(DebugLootOutputUpdateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.outputId_ = other.outputId_;
			this.itemAnn_ = other.itemAnn_;
			this.levelReq_ = other.levelReq_;
			this.levelReqHistory_ = other.levelReqHistory_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x000D9CBC File Offset: 0x000D7EBC
		[DebuggerNonUserCode]
		public DebugLootOutputUpdateMessage Clone()
		{
			return new DebugLootOutputUpdateMessage(this);
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x000D9CD4 File Offset: 0x000D7ED4
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x000D9D05 File Offset: 0x000D7F05
		[DebuggerNonUserCode]
		public uint OutputId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint outputIdDefaultValue;
				if (flag)
				{
					outputIdDefaultValue = this.outputId_;
				}
				else
				{
					outputIdDefaultValue = DebugLootOutputUpdateMessage.OutputIdDefaultValue;
				}
				return outputIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.outputId_ = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x000D9D20 File Offset: 0x000D7F20
		[DebuggerNonUserCode]
		public bool HasOutputId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000D9D3D File Offset: 0x000D7F3D
		[DebuggerNonUserCode]
		public void ClearOutputId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x000D9D50 File Offset: 0x000D7F50
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x000D9D81 File Offset: 0x000D7F81
		[DebuggerNonUserCode]
		public uint ItemAnn
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint itemAnnDefaultValue;
				if (flag)
				{
					itemAnnDefaultValue = this.itemAnn_;
				}
				else
				{
					itemAnnDefaultValue = DebugLootOutputUpdateMessage.ItemAnnDefaultValue;
				}
				return itemAnnDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemAnn_ = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x000D9D9C File Offset: 0x000D7F9C
		[DebuggerNonUserCode]
		public bool HasItemAnn
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000D9DB9 File Offset: 0x000D7FB9
		[DebuggerNonUserCode]
		public void ClearItemAnn()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x000D9DCC File Offset: 0x000D7FCC
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x000D9DFD File Offset: 0x000D7FFD
		[DebuggerNonUserCode]
		public int LevelReq
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelReqDefaultValue;
				if (flag)
				{
					levelReqDefaultValue = this.levelReq_;
				}
				else
				{
					levelReqDefaultValue = DebugLootOutputUpdateMessage.LevelReqDefaultValue;
				}
				return levelReqDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.levelReq_ = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x000D9E18 File Offset: 0x000D8018
		[DebuggerNonUserCode]
		public bool HasLevelReq
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x000D9E35 File Offset: 0x000D8035
		[DebuggerNonUserCode]
		public void ClearLevelReq()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x000D9E48 File Offset: 0x000D8048
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> LevelReqHistory
		{
			get
			{
				return this.levelReqHistory_;
			}
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x000D9E60 File Offset: 0x000D8060
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootOutputUpdateMessage);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000D9E80 File Offset: 0x000D8080
		[DebuggerNonUserCode]
		public bool Equals(DebugLootOutputUpdateMessage other)
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
					bool flag4 = this.OutputId != other.OutputId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemAnn != other.ItemAnn;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LevelReq != other.LevelReq;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.levelReqHistory_.Equals(other.levelReqHistory_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000D9F30 File Offset: 0x000D8130
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num ^= this.OutputId.GetHashCode();
			}
			bool hasItemAnn = this.HasItemAnn;
			if (hasItemAnn)
			{
				num ^= this.ItemAnn.GetHashCode();
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				num ^= this.LevelReq.GetHashCode();
			}
			num ^= this.levelReqHistory_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x000D9FC8 File Offset: 0x000D81C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x000D9FE0 File Offset: 0x000D81E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000D9FEC File Offset: 0x000D81EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OutputId);
			}
			bool hasItemAnn = this.HasItemAnn;
			if (hasItemAnn)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.ItemAnn);
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelReq);
			}
			this.levelReqHistory_.WriteTo(ref output, DebugLootOutputUpdateMessage._repeated_levelReqHistory_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x000DA090 File Offset: 0x000D8290
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OutputId);
			}
			bool hasItemAnn = this.HasItemAnn;
			if (hasItemAnn)
			{
				num += 5;
			}
			bool hasLevelReq = this.HasLevelReq;
			if (hasLevelReq)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelReq);
			}
			num += this.levelReqHistory_.CalculateSize(DebugLootOutputUpdateMessage._repeated_levelReqHistory_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x000DA124 File Offset: 0x000D8324
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootOutputUpdateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOutputId = other.HasOutputId;
				if (hasOutputId)
				{
					this.OutputId = other.OutputId;
				}
				bool hasItemAnn = other.HasItemAnn;
				if (hasItemAnn)
				{
					this.ItemAnn = other.ItemAnn;
				}
				bool hasLevelReq = other.HasLevelReq;
				if (hasLevelReq)
				{
					this.LevelReq = other.LevelReq;
				}
				this.levelReqHistory_.Add(other.levelReqHistory_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000DA1B1 File Offset: 0x000D83B1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x000DA1BC File Offset: 0x000D83BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0028;
						}
						this.ItemAnn = input.ReadFixed32();
					}
					else
					{
						this.OutputId = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.levelReqHistory_.AddEntriesFrom(ref input, DebugLootOutputUpdateMessage._repeated_levelReqHistory_codec);
				}
				else
				{
					this.LevelReq = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019A0 RID: 6560
		private static readonly MessageParser<DebugLootOutputUpdateMessage> _parser = new MessageParser<DebugLootOutputUpdateMessage>(() => new DebugLootOutputUpdateMessage());

		// Token: 0x040019A1 RID: 6561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019A2 RID: 6562
		private int _hasBits0;

		// Token: 0x040019A3 RID: 6563
		public const int OutputIdFieldNumber = 1;

		// Token: 0x040019A4 RID: 6564
		private static readonly uint OutputIdDefaultValue = 0U;

		// Token: 0x040019A5 RID: 6565
		private uint outputId_;

		// Token: 0x040019A6 RID: 6566
		public const int ItemAnnFieldNumber = 2;

		// Token: 0x040019A7 RID: 6567
		private static readonly uint ItemAnnDefaultValue = 0U;

		// Token: 0x040019A8 RID: 6568
		private uint itemAnn_;

		// Token: 0x040019A9 RID: 6569
		public const int LevelReqFieldNumber = 3;

		// Token: 0x040019AA RID: 6570
		private static readonly int LevelReqDefaultValue = 0;

		// Token: 0x040019AB RID: 6571
		private int levelReq_;

		// Token: 0x040019AC RID: 6572
		public const int LevelReqHistoryFieldNumber = 4;

		// Token: 0x040019AD RID: 6573
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_levelReqHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(34U, DebugLootValueRecord.Parser);

		// Token: 0x040019AE RID: 6574
		private readonly RepeatedField<DebugLootValueRecord> levelReqHistory_ = new RepeatedField<DebugLootValueRecord>();
	}
}
