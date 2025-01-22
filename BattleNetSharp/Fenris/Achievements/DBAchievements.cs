using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002CB RID: 715
	public sealed class DBAchievements : IMessage<DBAchievements>, IMessage, IEquatable<DBAchievements>, IDeepCloneable<DBAchievements>, IBufferMessage
	{
		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x00122914 File Offset: 0x00120B14
		[DebuggerNonUserCode]
		public static MessageParser<DBAchievements> Parser
		{
			get
			{
				return DBAchievements._parser;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x0012292C File Offset: 0x00120B2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x00122950 File Offset: 0x00120B50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DBAchievements.Descriptor;
			}
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00122967 File Offset: 0x00120B67
		[DebuggerNonUserCode]
		public DBAchievements()
		{
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x0012297C File Offset: 0x00120B7C
		[DebuggerNonUserCode]
		public DBAchievements(DBAchievements other)
			: this()
		{
			this.achievements_ = other.achievements_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x001229A8 File Offset: 0x00120BA8
		[DebuggerNonUserCode]
		public DBAchievements Clone()
		{
			return new DBAchievements(this);
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x001229C0 File Offset: 0x00120BC0
		[DebuggerNonUserCode]
		public RepeatedField<DBAchievement> Achievements
		{
			get
			{
				return this.achievements_;
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x001229D8 File Offset: 0x00120BD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DBAchievements);
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x001229F8 File Offset: 0x00120BF8
		[DebuggerNonUserCode]
		public bool Equals(DBAchievements other)
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
					bool flag4 = !this.achievements_.Equals(other.achievements_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00122A54 File Offset: 0x00120C54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievements_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00122A94 File Offset: 0x00120C94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00122AAC File Offset: 0x00120CAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00122AB8 File Offset: 0x00120CB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievements_.WriteTo(ref output, DBAchievements._repeated_achievements_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00122AF4 File Offset: 0x00120CF4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievements_.CalculateSize(DBAchievements._repeated_achievements_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00122B3C File Offset: 0x00120D3C
		[DebuggerNonUserCode]
		public void MergeFrom(DBAchievements other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.achievements_.Add(other.achievements_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00122B7E File Offset: 0x00120D7E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00122B8C File Offset: 0x00120D8C
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
					this.achievements_.AddEntriesFrom(ref input, DBAchievements._repeated_achievements_codec);
				}
			}
		}

		// Token: 0x040021E8 RID: 8680
		private static readonly MessageParser<DBAchievements> _parser = new MessageParser<DBAchievements>(() => new DBAchievements());

		// Token: 0x040021E9 RID: 8681
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021EA RID: 8682
		public const int AchievementsFieldNumber = 1;

		// Token: 0x040021EB RID: 8683
		private static readonly FieldCodec<DBAchievement> _repeated_achievements_codec = FieldCodec.ForMessage<DBAchievement>(10U, DBAchievement.Parser);

		// Token: 0x040021EC RID: 8684
		private readonly RepeatedField<DBAchievement> achievements_ = new RepeatedField<DBAchievement>();
	}
}
