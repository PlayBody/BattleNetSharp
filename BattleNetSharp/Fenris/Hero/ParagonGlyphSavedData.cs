using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B5 RID: 437
	public sealed class ParagonGlyphSavedData : IMessage<ParagonGlyphSavedData>, IMessage, IEquatable<ParagonGlyphSavedData>, IDeepCloneable<ParagonGlyphSavedData>, IBufferMessage
	{
		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000B42D8 File Offset: 0x000B24D8
		[DebuggerNonUserCode]
		public static MessageParser<ParagonGlyphSavedData> Parser
		{
			get
			{
				return ParagonGlyphSavedData._parser;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000B42F0 File Offset: 0x000B24F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000B4314 File Offset: 0x000B2514
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParagonGlyphSavedData.Descriptor;
			}
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000B432B File Offset: 0x000B252B
		[DebuggerNonUserCode]
		public ParagonGlyphSavedData()
		{
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000B4340 File Offset: 0x000B2540
		[DebuggerNonUserCode]
		public ParagonGlyphSavedData(ParagonGlyphSavedData other)
			: this()
		{
			this.glyphData_ = other.glyphData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000B436C File Offset: 0x000B256C
		[DebuggerNonUserCode]
		public ParagonGlyphSavedData Clone()
		{
			return new ParagonGlyphSavedData(this);
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000B4384 File Offset: 0x000B2584
		[DebuggerNonUserCode]
		public RepeatedField<ParagonGlyphData> GlyphData
		{
			get
			{
				return this.glyphData_;
			}
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000B439C File Offset: 0x000B259C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParagonGlyphSavedData);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000B43BC File Offset: 0x000B25BC
		[DebuggerNonUserCode]
		public bool Equals(ParagonGlyphSavedData other)
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
					bool flag4 = !this.glyphData_.Equals(other.glyphData_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000B4418 File Offset: 0x000B2618
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.glyphData_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000B4458 File Offset: 0x000B2658
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000B4470 File Offset: 0x000B2670
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000B447C File Offset: 0x000B267C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.glyphData_.WriteTo(ref output, ParagonGlyphSavedData._repeated_glyphData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000B44B8 File Offset: 0x000B26B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.glyphData_.CalculateSize(ParagonGlyphSavedData._repeated_glyphData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000B4500 File Offset: 0x000B2700
		[DebuggerNonUserCode]
		public void MergeFrom(ParagonGlyphSavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.glyphData_.Add(other.glyphData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000B4542 File Offset: 0x000B2742
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000B4550 File Offset: 0x000B2750
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
					this.glyphData_.AddEntriesFrom(ref input, ParagonGlyphSavedData._repeated_glyphData_codec);
				}
			}
		}

		// Token: 0x040014CF RID: 5327
		private static readonly MessageParser<ParagonGlyphSavedData> _parser = new MessageParser<ParagonGlyphSavedData>(() => new ParagonGlyphSavedData());

		// Token: 0x040014D0 RID: 5328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014D1 RID: 5329
		public const int GlyphDataFieldNumber = 1;

		// Token: 0x040014D2 RID: 5330
		private static readonly FieldCodec<ParagonGlyphData> _repeated_glyphData_codec = FieldCodec.ForMessage<ParagonGlyphData>(10U, ParagonGlyphData.Parser);

		// Token: 0x040014D3 RID: 5331
		private readonly RepeatedField<ParagonGlyphData> glyphData_ = new RepeatedField<ParagonGlyphData>();
	}
}
