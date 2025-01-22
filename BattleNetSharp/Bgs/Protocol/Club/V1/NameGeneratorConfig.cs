using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000478 RID: 1144
	public sealed class NameGeneratorConfig : IMessage<NameGeneratorConfig>, IMessage, IEquatable<NameGeneratorConfig>, IDeepCloneable<NameGeneratorConfig>, IBufferMessage
	{
		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06006F8F RID: 28559 RVA: 0x001B1CC8 File Offset: 0x001AFEC8
		[DebuggerNonUserCode]
		public static MessageParser<NameGeneratorConfig> Parser
		{
			get
			{
				return NameGeneratorConfig._parser;
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x001B1CE0 File Offset: 0x001AFEE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNameGeneratorReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x06006F91 RID: 28561 RVA: 0x001B1D04 File Offset: 0x001AFF04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameGeneratorConfig.Descriptor;
			}
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x001B1D1B File Offset: 0x001AFF1B
		[DebuggerNonUserCode]
		public NameGeneratorConfig()
		{
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x001B1D30 File Offset: 0x001AFF30
		[DebuggerNonUserCode]
		public NameGeneratorConfig(NameGeneratorConfig other)
			: this()
		{
			this.nameGenerators_ = other.nameGenerators_.Clone();
			this.clubTypeScorecard_ = ((other.clubTypeScorecard_ != null) ? other.clubTypeScorecard_.Clone() : null);
			this.localeScorecard_ = ((other.localeScorecard_ != null) ? other.localeScorecard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x001B1DA0 File Offset: 0x001AFFA0
		[DebuggerNonUserCode]
		public NameGeneratorConfig Clone()
		{
			return new NameGeneratorConfig(this);
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x06006F95 RID: 28565 RVA: 0x001B1DB8 File Offset: 0x001AFFB8
		[DebuggerNonUserCode]
		public RepeatedField<NameGenerator> NameGenerators
		{
			get
			{
				return this.nameGenerators_;
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x001B1DD0 File Offset: 0x001AFFD0
		// (set) Token: 0x06006F97 RID: 28567 RVA: 0x001B1DE8 File Offset: 0x001AFFE8
		[DebuggerNonUserCode]
		public NameGeneratorScorecard ClubTypeScorecard
		{
			get
			{
				return this.clubTypeScorecard_;
			}
			set
			{
				this.clubTypeScorecard_ = value;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x001B1DF4 File Offset: 0x001AFFF4
		// (set) Token: 0x06006F99 RID: 28569 RVA: 0x001B1E0C File Offset: 0x001B000C
		[DebuggerNonUserCode]
		public NameGeneratorScorecard LocaleScorecard
		{
			get
			{
				return this.localeScorecard_;
			}
			set
			{
				this.localeScorecard_ = value;
			}
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x001B1E18 File Offset: 0x001B0018
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameGeneratorConfig);
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x001B1E38 File Offset: 0x001B0038
		[DebuggerNonUserCode]
		public bool Equals(NameGeneratorConfig other)
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
					bool flag4 = !this.nameGenerators_.Equals(other.nameGenerators_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ClubTypeScorecard, other.ClubTypeScorecard);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.LocaleScorecard, other.LocaleScorecard);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x001B1ED0 File Offset: 0x001B00D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nameGenerators_.GetHashCode();
			bool flag = this.clubTypeScorecard_ != null;
			if (flag)
			{
				num ^= this.ClubTypeScorecard.GetHashCode();
			}
			bool flag2 = this.localeScorecard_ != null;
			if (flag2)
			{
				num ^= this.LocaleScorecard.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001B1F48 File Offset: 0x001B0148
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x001B1F60 File Offset: 0x001B0160
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x001B1F6C File Offset: 0x001B016C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nameGenerators_.WriteTo(ref output, NameGeneratorConfig._repeated_nameGenerators_codec);
			bool flag = this.clubTypeScorecard_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ClubTypeScorecard);
			}
			bool flag2 = this.localeScorecard_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LocaleScorecard);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001B1FF4 File Offset: 0x001B01F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nameGenerators_.CalculateSize(NameGeneratorConfig._repeated_nameGenerators_codec);
			bool flag = this.clubTypeScorecard_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClubTypeScorecard);
			}
			bool flag2 = this.localeScorecard_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LocaleScorecard);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001B207C File Offset: 0x001B027C
		[DebuggerNonUserCode]
		public void MergeFrom(NameGeneratorConfig other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.nameGenerators_.Add(other.nameGenerators_);
				bool flag2 = other.clubTypeScorecard_ != null;
				if (flag2)
				{
					bool flag3 = this.clubTypeScorecard_ == null;
					if (flag3)
					{
						this.ClubTypeScorecard = new NameGeneratorScorecard();
					}
					this.ClubTypeScorecard.MergeFrom(other.ClubTypeScorecard);
				}
				bool flag4 = other.localeScorecard_ != null;
				if (flag4)
				{
					bool flag5 = this.localeScorecard_ == null;
					if (flag5)
					{
						this.LocaleScorecard = new NameGeneratorScorecard();
					}
					this.LocaleScorecard.MergeFrom(other.LocaleScorecard);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x001B213B File Offset: 0x001B033B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x001B2148 File Offset: 0x001B0348
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.localeScorecard_ == null;
							if (flag)
							{
								this.LocaleScorecard = new NameGeneratorScorecard();
							}
							input.ReadMessage(this.LocaleScorecard);
						}
					}
					else
					{
						bool flag2 = this.clubTypeScorecard_ == null;
						if (flag2)
						{
							this.ClubTypeScorecard = new NameGeneratorScorecard();
						}
						input.ReadMessage(this.ClubTypeScorecard);
					}
				}
				else
				{
					this.nameGenerators_.AddEntriesFrom(ref input, NameGeneratorConfig._repeated_nameGenerators_codec);
				}
			}
		}

		// Token: 0x04003328 RID: 13096
		private static readonly MessageParser<NameGeneratorConfig> _parser = new MessageParser<NameGeneratorConfig>(() => new NameGeneratorConfig());

		// Token: 0x04003329 RID: 13097
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400332A RID: 13098
		public const int NameGeneratorsFieldNumber = 1;

		// Token: 0x0400332B RID: 13099
		private static readonly FieldCodec<NameGenerator> _repeated_nameGenerators_codec = FieldCodec.ForMessage<NameGenerator>(10U, NameGenerator.Parser);

		// Token: 0x0400332C RID: 13100
		private readonly RepeatedField<NameGenerator> nameGenerators_ = new RepeatedField<NameGenerator>();

		// Token: 0x0400332D RID: 13101
		public const int ClubTypeScorecardFieldNumber = 2;

		// Token: 0x0400332E RID: 13102
		private NameGeneratorScorecard clubTypeScorecard_;

		// Token: 0x0400332F RID: 13103
		public const int LocaleScorecardFieldNumber = 3;

		// Token: 0x04003330 RID: 13104
		private NameGeneratorScorecard localeScorecard_;
	}
}
