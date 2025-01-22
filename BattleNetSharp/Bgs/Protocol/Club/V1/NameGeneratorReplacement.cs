using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047B RID: 1147
	public sealed class NameGeneratorReplacement : IMessage<NameGeneratorReplacement>, IMessage, IEquatable<NameGeneratorReplacement>, IDeepCloneable<NameGeneratorReplacement>, IBufferMessage
	{
		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06006FDF RID: 28639 RVA: 0x001B3014 File Offset: 0x001B1214
		[DebuggerNonUserCode]
		public static MessageParser<NameGeneratorReplacement> Parser
		{
			get
			{
				return NameGeneratorReplacement._parser;
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x001B302C File Offset: 0x001B122C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNameGeneratorReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x001B3050 File Offset: 0x001B1250
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameGeneratorReplacement.Descriptor;
			}
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x001B3067 File Offset: 0x001B1267
		[DebuggerNonUserCode]
		public NameGeneratorReplacement()
		{
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x001B307C File Offset: 0x001B127C
		[DebuggerNonUserCode]
		public NameGeneratorReplacement(NameGeneratorReplacement other)
			: this()
		{
			this.id_ = other.id_;
			this.options_ = other.options_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x001B30B4 File Offset: 0x001B12B4
		[DebuggerNonUserCode]
		public NameGeneratorReplacement Clone()
		{
			return new NameGeneratorReplacement(this);
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x06006FE5 RID: 28645 RVA: 0x001B30CC File Offset: 0x001B12CC
		// (set) Token: 0x06006FE6 RID: 28646 RVA: 0x001B30ED File Offset: 0x001B12ED
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? NameGeneratorReplacement.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06006FE7 RID: 28647 RVA: 0x001B3104 File Offset: 0x001B1304
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x001B311F File Offset: 0x001B131F
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06006FE9 RID: 28649 RVA: 0x001B312C File Offset: 0x001B132C
		[DebuggerNonUserCode]
		public RepeatedField<string> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x001B3144 File Offset: 0x001B1344
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameGeneratorReplacement);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x001B3164 File Offset: 0x001B1364
		[DebuggerNonUserCode]
		public bool Equals(NameGeneratorReplacement other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.options_.Equals(other.options_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x001B31D8 File Offset: 0x001B13D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.options_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x001B3230 File Offset: 0x001B1430
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x001B3248 File Offset: 0x001B1448
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x001B3254 File Offset: 0x001B1454
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			this.options_.WriteTo(ref output, NameGeneratorReplacement._repeated_options_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x001B32B4 File Offset: 0x001B14B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			num += this.options_.CalculateSize(NameGeneratorReplacement._repeated_options_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x001B3318 File Offset: 0x001B1518
		[DebuggerNonUserCode]
		public void MergeFrom(NameGeneratorReplacement other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this.options_.Add(other.options_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x001B3373 File Offset: 0x001B1573
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x001B3380 File Offset: 0x001B1580
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.options_.AddEntriesFrom(ref input, NameGeneratorReplacement._repeated_options_codec);
					}
				}
				else
				{
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x04003351 RID: 13137
		private static readonly MessageParser<NameGeneratorReplacement> _parser = new MessageParser<NameGeneratorReplacement>(() => new NameGeneratorReplacement());

		// Token: 0x04003352 RID: 13138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003353 RID: 13139
		public const int IdFieldNumber = 1;

		// Token: 0x04003354 RID: 13140
		private static readonly string IdDefaultValue = "";

		// Token: 0x04003355 RID: 13141
		private string id_;

		// Token: 0x04003356 RID: 13142
		public const int OptionsFieldNumber = 2;

		// Token: 0x04003357 RID: 13143
		private static readonly FieldCodec<string> _repeated_options_codec = FieldCodec.ForString(18U);

		// Token: 0x04003358 RID: 13144
		private readonly RepeatedField<string> options_ = new RepeatedField<string>();
	}
}
