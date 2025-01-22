using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047A RID: 1146
	public sealed class NameGenerator : IMessage<NameGenerator>, IMessage, IEquatable<NameGenerator>, IDeepCloneable<NameGenerator>, IBufferMessage
	{
		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x001B2AA8 File Offset: 0x001B0CA8
		[DebuggerNonUserCode]
		public static MessageParser<NameGenerator> Parser
		{
			get
			{
				return NameGenerator._parser;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x06006FCB RID: 28619 RVA: 0x001B2AC0 File Offset: 0x001B0CC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNameGeneratorReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x06006FCC RID: 28620 RVA: 0x001B2AE4 File Offset: 0x001B0CE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameGenerator.Descriptor;
			}
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x001B2AFB File Offset: 0x001B0CFB
		[DebuggerNonUserCode]
		public NameGenerator()
		{
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x001B2B34 File Offset: 0x001B0D34
		[DebuggerNonUserCode]
		public NameGenerator(NameGenerator other)
			: this()
		{
			this.names_ = other.names_.Clone();
			this.replacements_ = other.replacements_.Clone();
			this.clubTypes_ = other.clubTypes_.Clone();
			this.locales_ = other.locales_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x001B2BA0 File Offset: 0x001B0DA0
		[DebuggerNonUserCode]
		public NameGenerator Clone()
		{
			return new NameGenerator(this);
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x001B2BB8 File Offset: 0x001B0DB8
		[DebuggerNonUserCode]
		public RepeatedField<string> Names
		{
			get
			{
				return this.names_;
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x06006FD1 RID: 28625 RVA: 0x001B2BD0 File Offset: 0x001B0DD0
		[DebuggerNonUserCode]
		public RepeatedField<NameGeneratorReplacement> Replacements
		{
			get
			{
				return this.replacements_;
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06006FD2 RID: 28626 RVA: 0x001B2BE8 File Offset: 0x001B0DE8
		[DebuggerNonUserCode]
		public RepeatedField<UniqueClubType> ClubTypes
		{
			get
			{
				return this.clubTypes_;
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x001B2C00 File Offset: 0x001B0E00
		[DebuggerNonUserCode]
		public RepeatedField<string> Locales
		{
			get
			{
				return this.locales_;
			}
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x001B2C18 File Offset: 0x001B0E18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameGenerator);
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x001B2C38 File Offset: 0x001B0E38
		[DebuggerNonUserCode]
		public bool Equals(NameGenerator other)
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
					bool flag4 = !this.names_.Equals(other.names_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.replacements_.Equals(other.replacements_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.clubTypes_.Equals(other.clubTypes_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.locales_.Equals(other.locales_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x001B2CF4 File Offset: 0x001B0EF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.names_.GetHashCode();
			num ^= this.replacements_.GetHashCode();
			num ^= this.clubTypes_.GetHashCode();
			num ^= this.locales_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x001B2D60 File Offset: 0x001B0F60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x001B2D78 File Offset: 0x001B0F78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x001B2D84 File Offset: 0x001B0F84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.names_.WriteTo(ref output, NameGenerator._repeated_names_codec);
			this.replacements_.WriteTo(ref output, NameGenerator._repeated_replacements_codec);
			this.clubTypes_.WriteTo(ref output, NameGenerator._repeated_clubTypes_codec);
			this.locales_.WriteTo(ref output, NameGenerator._repeated_locales_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x001B2DF8 File Offset: 0x001B0FF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.names_.CalculateSize(NameGenerator._repeated_names_codec);
			num += this.replacements_.CalculateSize(NameGenerator._repeated_replacements_codec);
			num += this.clubTypes_.CalculateSize(NameGenerator._repeated_clubTypes_codec);
			num += this.locales_.CalculateSize(NameGenerator._repeated_locales_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x001B2E78 File Offset: 0x001B1078
		[DebuggerNonUserCode]
		public void MergeFrom(NameGenerator other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.names_.Add(other.names_);
				this.replacements_.Add(other.replacements_);
				this.clubTypes_.Add(other.clubTypes_);
				this.locales_.Add(other.locales_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x001B2EF0 File Offset: 0x001B10F0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x001B2EFC File Offset: 0x001B10FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002C;
						}
						this.replacements_.AddEntriesFrom(ref input, NameGenerator._repeated_replacements_codec);
					}
					else
					{
						this.names_.AddEntriesFrom(ref input, NameGenerator._repeated_names_codec);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					this.locales_.AddEntriesFrom(ref input, NameGenerator._repeated_locales_codec);
				}
				else
				{
					this.clubTypes_.AddEntriesFrom(ref input, NameGenerator._repeated_clubTypes_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003343 RID: 13123
		private static readonly MessageParser<NameGenerator> _parser = new MessageParser<NameGenerator>(() => new NameGenerator());

		// Token: 0x04003344 RID: 13124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003345 RID: 13125
		public const int NamesFieldNumber = 1;

		// Token: 0x04003346 RID: 13126
		private static readonly FieldCodec<string> _repeated_names_codec = FieldCodec.ForString(10U);

		// Token: 0x04003347 RID: 13127
		private readonly RepeatedField<string> names_ = new RepeatedField<string>();

		// Token: 0x04003348 RID: 13128
		public const int ReplacementsFieldNumber = 2;

		// Token: 0x04003349 RID: 13129
		private static readonly FieldCodec<NameGeneratorReplacement> _repeated_replacements_codec = FieldCodec.ForMessage<NameGeneratorReplacement>(18U, NameGeneratorReplacement.Parser);

		// Token: 0x0400334A RID: 13130
		private readonly RepeatedField<NameGeneratorReplacement> replacements_ = new RepeatedField<NameGeneratorReplacement>();

		// Token: 0x0400334B RID: 13131
		public const int ClubTypesFieldNumber = 3;

		// Token: 0x0400334C RID: 13132
		private static readonly FieldCodec<UniqueClubType> _repeated_clubTypes_codec = FieldCodec.ForMessage<UniqueClubType>(26U, UniqueClubType.Parser);

		// Token: 0x0400334D RID: 13133
		private readonly RepeatedField<UniqueClubType> clubTypes_ = new RepeatedField<UniqueClubType>();

		// Token: 0x0400334E RID: 13134
		public const int LocalesFieldNumber = 4;

		// Token: 0x0400334F RID: 13135
		private static readonly FieldCodec<string> _repeated_locales_codec = FieldCodec.ForString(34U);

		// Token: 0x04003350 RID: 13136
		private readonly RepeatedField<string> locales_ = new RepeatedField<string>();
	}
}
