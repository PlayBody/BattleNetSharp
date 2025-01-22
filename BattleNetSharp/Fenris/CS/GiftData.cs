using System;
using System.Diagnostics;
using Fenris.Gift;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x0200020D RID: 525
	public sealed class GiftData : IMessage<GiftData>, IMessage, IEquatable<GiftData>, IDeepCloneable<GiftData>, IBufferMessage
	{
		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x000E2ED4 File Offset: 0x000E10D4
		[DebuggerNonUserCode]
		public static MessageParser<GiftData> Parser
		{
			get
			{
				return GiftData._parser;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x000E2EEC File Offset: 0x000E10EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x000E2F10 File Offset: 0x000E1110
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftData.Descriptor;
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x000E2F27 File Offset: 0x000E1127
		[DebuggerNonUserCode]
		public GiftData()
		{
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x000E2F3C File Offset: 0x000E113C
		[DebuggerNonUserCode]
		public GiftData(GiftData other)
			: this()
		{
			this.gifts_ = other.gifts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x000E2F68 File Offset: 0x000E1168
		[DebuggerNonUserCode]
		public GiftData Clone()
		{
			return new GiftData(this);
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x000E2F80 File Offset: 0x000E1180
		[DebuggerNonUserCode]
		public RepeatedField<GiftInfo> Gifts
		{
			get
			{
				return this.gifts_;
			}
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x000E2F98 File Offset: 0x000E1198
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftData);
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x000E2FB8 File Offset: 0x000E11B8
		[DebuggerNonUserCode]
		public bool Equals(GiftData other)
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
					bool flag4 = !this.gifts_.Equals(other.gifts_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x000E3014 File Offset: 0x000E1214
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gifts_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x000E3054 File Offset: 0x000E1254
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x000E306C File Offset: 0x000E126C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x000E3078 File Offset: 0x000E1278
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gifts_.WriteTo(ref output, GiftData._repeated_gifts_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x000E30B4 File Offset: 0x000E12B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gifts_.CalculateSize(GiftData._repeated_gifts_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x000E30FC File Offset: 0x000E12FC
		[DebuggerNonUserCode]
		public void MergeFrom(GiftData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gifts_.Add(other.gifts_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x000E313E File Offset: 0x000E133E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x000E314C File Offset: 0x000E134C
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
					this.gifts_.AddEntriesFrom(ref input, GiftData._repeated_gifts_codec);
				}
			}
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly MessageParser<GiftData> _parser = new MessageParser<GiftData>(() => new GiftData());

		// Token: 0x04001AC5 RID: 6853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AC6 RID: 6854
		public const int GiftsFieldNumber = 1;

		// Token: 0x04001AC7 RID: 6855
		private static readonly FieldCodec<GiftInfo> _repeated_gifts_codec = FieldCodec.ForMessage<GiftInfo>(10U, GiftInfo.Parser);

		// Token: 0x04001AC8 RID: 6856
		private readonly RepeatedField<GiftInfo> gifts_ = new RepeatedField<GiftInfo>();
	}
}
