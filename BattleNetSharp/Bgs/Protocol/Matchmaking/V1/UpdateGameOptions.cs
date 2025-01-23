using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F0 RID: 1008
	public sealed class UpdateGameOptions : IMessage<UpdateGameOptions>, IMessage, IEquatable<UpdateGameOptions>, IDeepCloneable<UpdateGameOptions>, IBufferMessage
	{
		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x001837B4 File Offset: 0x001819B4
		[DebuggerNonUserCode]
		public static MessageParser<UpdateGameOptions> Parser
		{
			get
			{
				return UpdateGameOptions._parser;
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x001837CC File Offset: 0x001819CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x001837F0 File Offset: 0x001819F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateGameOptions.Descriptor;
			}
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x00183807 File Offset: 0x00181A07
		[DebuggerNonUserCode]
		public UpdateGameOptions()
		{
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0018381C File Offset: 0x00181A1C
		[DebuggerNonUserCode]
		public UpdateGameOptions(UpdateGameOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.replaceAttributes_ = other.replaceAttributes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x00183888 File Offset: 0x00181A88
		[DebuggerNonUserCode]
		public UpdateGameOptions Clone()
		{
			return new UpdateGameOptions(this);
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x001838A0 File Offset: 0x00181AA0
		// (set) Token: 0x06006442 RID: 25666 RVA: 0x001838B8 File Offset: 0x00181AB8
		[DebuggerNonUserCode]
		public GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x001838C4 File Offset: 0x00181AC4
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x001838DC File Offset: 0x00181ADC
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x0018390D File Offset: 0x00181B0D
		[DebuggerNonUserCode]
		public bool ReplaceAttributes
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool replaceAttributesDefaultValue;
				if (flag)
				{
					replaceAttributesDefaultValue = this.replaceAttributes_;
				}
				else
				{
					replaceAttributesDefaultValue = UpdateGameOptions.ReplaceAttributesDefaultValue;
				}
				return replaceAttributesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.replaceAttributes_ = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x00183928 File Offset: 0x00181B28
		[DebuggerNonUserCode]
		public bool HasReplaceAttributes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x00183945 File Offset: 0x00181B45
		[DebuggerNonUserCode]
		public void ClearReplaceAttributes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x00183958 File Offset: 0x00181B58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateGameOptions);
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x00183978 File Offset: 0x00181B78
		[DebuggerNonUserCode]
		public bool Equals(UpdateGameOptions other)
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
					bool flag4 = !object.Equals(this.GameHandle, other.GameHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ReplaceAttributes != other.ReplaceAttributes;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00183A0C File Offset: 0x00181C0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasReplaceAttributes = this.HasReplaceAttributes;
			if (hasReplaceAttributes)
			{
				num ^= this.ReplaceAttributes.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00183A88 File Offset: 0x00181C88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00183AA0 File Offset: 0x00181CA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x00183AAC File Offset: 0x00181CAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			this.attribute_.WriteTo(ref output, UpdateGameOptions._repeated_attribute_codec);
			bool hasReplaceAttributes = this.HasReplaceAttributes;
			if (hasReplaceAttributes)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ReplaceAttributes);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x00183B30 File Offset: 0x00181D30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			num += this.attribute_.CalculateSize(UpdateGameOptions._repeated_attribute_codec);
			bool hasReplaceAttributes = this.HasReplaceAttributes;
			if (hasReplaceAttributes)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x00183BA8 File Offset: 0x00181DA8
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateGameOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.gameHandle_ == null;
					if (flag3)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				this.attribute_.Add(other.attribute_);
				bool hasReplaceAttributes = other.HasReplaceAttributes;
				if (hasReplaceAttributes)
				{
					this.ReplaceAttributes = other.ReplaceAttributes;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x00183C3F File Offset: 0x00181E3F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00183C4C File Offset: 0x00181E4C
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ReplaceAttributes = input.ReadBool();
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, UpdateGameOptions._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.gameHandle_ == null;
					if (flag)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
			}
		}

		// Token: 0x04002DB0 RID: 11696
		private static readonly MessageParser<UpdateGameOptions> _parser = new MessageParser<UpdateGameOptions>(() => new UpdateGameOptions());

		// Token: 0x04002DB1 RID: 11697
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DB2 RID: 11698
		private int _hasBits0;

		// Token: 0x04002DB3 RID: 11699
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002DB4 RID: 11700
		private GameHandle gameHandle_;

		// Token: 0x04002DB5 RID: 11701
		public const int AttributeFieldNumber = 2;

		// Token: 0x04002DB6 RID: 11702
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002DB7 RID: 11703
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04002DB8 RID: 11704
		public const int ReplaceAttributesFieldNumber = 3;

		// Token: 0x04002DB9 RID: 11705
		private static readonly bool ReplaceAttributesDefaultValue = true;

		// Token: 0x04002DBA RID: 11706
		private bool replaceAttributes_;
	}
}
