using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x0200020A RID: 522
	public sealed class FallenHeroData : IMessage<FallenHeroData>, IMessage, IEquatable<FallenHeroData>, IDeepCloneable<FallenHeroData>, IBufferMessage
	{
		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x000E1EB4 File Offset: 0x000E00B4
		[DebuggerNonUserCode]
		public static MessageParser<FallenHeroData> Parser
		{
			get
			{
				return FallenHeroData._parser;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x000E1ECC File Offset: 0x000E00CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x000E1EF0 File Offset: 0x000E00F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallenHeroData.Descriptor;
			}
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x000E1F07 File Offset: 0x000E0107
		[DebuggerNonUserCode]
		public FallenHeroData()
		{
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x000E1F1C File Offset: 0x000E011C
		[DebuggerNonUserCode]
		public FallenHeroData(FallenHeroData other)
			: this()
		{
			this.fallenHeroes_ = other.fallenHeroes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x000E1F48 File Offset: 0x000E0148
		[DebuggerNonUserCode]
		public FallenHeroData Clone()
		{
			return new FallenHeroData(this);
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x000E1F60 File Offset: 0x000E0160
		[DebuggerNonUserCode]
		public RepeatedField<FallenHero> FallenHeroes
		{
			get
			{
				return this.fallenHeroes_;
			}
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x000E1F78 File Offset: 0x000E0178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallenHeroData);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x000E1F98 File Offset: 0x000E0198
		[DebuggerNonUserCode]
		public bool Equals(FallenHeroData other)
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
					bool flag4 = !this.fallenHeroes_.Equals(other.fallenHeroes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000E1FF4 File Offset: 0x000E01F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fallenHeroes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x000E2034 File Offset: 0x000E0234
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x000E204C File Offset: 0x000E024C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x000E2058 File Offset: 0x000E0258
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fallenHeroes_.WriteTo(ref output, FallenHeroData._repeated_fallenHeroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x000E2094 File Offset: 0x000E0294
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fallenHeroes_.CalculateSize(FallenHeroData._repeated_fallenHeroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x000E20DC File Offset: 0x000E02DC
		[DebuggerNonUserCode]
		public void MergeFrom(FallenHeroData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.fallenHeroes_.Add(other.fallenHeroes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x000E211E File Offset: 0x000E031E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x000E212C File Offset: 0x000E032C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fallenHeroes_.AddEntriesFrom(ref input, FallenHeroData._repeated_fallenHeroes_codec);
				}
			}
		}

		// Token: 0x04001AA5 RID: 6821
		private static readonly MessageParser<FallenHeroData> _parser = new MessageParser<FallenHeroData>(() => new FallenHeroData());

		// Token: 0x04001AA6 RID: 6822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AA7 RID: 6823
		public const int FallenHeroesFieldNumber = 1;

		// Token: 0x04001AA8 RID: 6824
		private static readonly FieldCodec<FallenHero> _repeated_fallenHeroes_codec = FieldCodec.ForMessage<FallenHero>(10U, FallenHero.Parser);

		// Token: 0x04001AA9 RID: 6825
		private readonly RepeatedField<FallenHero> fallenHeroes_ = new RepeatedField<FallenHero>();
	}
}
