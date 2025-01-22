using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DC RID: 476
	public sealed class AchievementsUnlockedConsoleAchievements : IMessage<AchievementsUnlockedConsoleAchievements>, IMessage, IEquatable<AchievementsUnlockedConsoleAchievements>, IDeepCloneable<AchievementsUnlockedConsoleAchievements>, IBufferMessage
	{
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x000CBE04 File Offset: 0x000CA004
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsUnlockedConsoleAchievements> Parser
		{
			get
			{
				return AchievementsUnlockedConsoleAchievements._parser;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x000CBE1C File Offset: 0x000CA01C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x000CBE40 File Offset: 0x000CA040
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementsUnlockedConsoleAchievements.Descriptor;
			}
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000CBE57 File Offset: 0x000CA057
		[DebuggerNonUserCode]
		public AchievementsUnlockedConsoleAchievements()
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000CBE6C File Offset: 0x000CA06C
		[DebuggerNonUserCode]
		public AchievementsUnlockedConsoleAchievements(AchievementsUnlockedConsoleAchievements other)
			: this()
		{
			this.snoAchievements_ = other.snoAchievements_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000CBE98 File Offset: 0x000CA098
		[DebuggerNonUserCode]
		public AchievementsUnlockedConsoleAchievements Clone()
		{
			return new AchievementsUnlockedConsoleAchievements(this);
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x000CBEB0 File Offset: 0x000CA0B0
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoAchievements
		{
			get
			{
				return this.snoAchievements_;
			}
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000CBEC8 File Offset: 0x000CA0C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementsUnlockedConsoleAchievements);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000CBEE8 File Offset: 0x000CA0E8
		[DebuggerNonUserCode]
		public bool Equals(AchievementsUnlockedConsoleAchievements other)
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
					bool flag4 = !this.snoAchievements_.Equals(other.snoAchievements_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000CBF44 File Offset: 0x000CA144
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoAchievements_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x000CBF84 File Offset: 0x000CA184
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000CBF9C File Offset: 0x000CA19C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000CBFA8 File Offset: 0x000CA1A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoAchievements_.WriteTo(ref output, AchievementsUnlockedConsoleAchievements._repeated_snoAchievements_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000CBFE4 File Offset: 0x000CA1E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoAchievements_.CalculateSize(AchievementsUnlockedConsoleAchievements._repeated_snoAchievements_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000CC02C File Offset: 0x000CA22C
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementsUnlockedConsoleAchievements other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoAchievements_.Add(other.snoAchievements_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000CC06E File Offset: 0x000CA26E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x000CC07C File Offset: 0x000CA27C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U && num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.snoAchievements_.AddEntriesFrom(ref input, AchievementsUnlockedConsoleAchievements._repeated_snoAchievements_codec);
				}
			}
		}

		// Token: 0x040017C5 RID: 6085
		private static readonly MessageParser<AchievementsUnlockedConsoleAchievements> _parser = new MessageParser<AchievementsUnlockedConsoleAchievements>(() => new AchievementsUnlockedConsoleAchievements());

		// Token: 0x040017C6 RID: 6086
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017C7 RID: 6087
		public const int SnoAchievementsFieldNumber = 1;

		// Token: 0x040017C8 RID: 6088
		private static readonly FieldCodec<int> _repeated_snoAchievements_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x040017C9 RID: 6089
		private readonly RepeatedField<int> snoAchievements_ = new RepeatedField<int>();
	}
}
