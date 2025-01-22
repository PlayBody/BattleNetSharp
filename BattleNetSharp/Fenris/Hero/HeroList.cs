using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A5 RID: 421
	public sealed class HeroList : IMessage<HeroList>, IMessage, IEquatable<HeroList>, IDeepCloneable<HeroList>, IBufferMessage
	{
		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000AE594 File Offset: 0x000AC794
		[DebuggerNonUserCode]
		public static MessageParser<HeroList> Parser
		{
			get
			{
				return HeroList._parser;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000AE5AC File Offset: 0x000AC7AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroList.Descriptor;
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000AE5E7 File Offset: 0x000AC7E7
		[DebuggerNonUserCode]
		public HeroList()
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000AE5FC File Offset: 0x000AC7FC
		[DebuggerNonUserCode]
		public HeroList(HeroList other)
			: this()
		{
			this.heroIds_ = other.heroIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000AE628 File Offset: 0x000AC828
		[DebuggerNonUserCode]
		public HeroList Clone()
		{
			return new HeroList(this);
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000AE640 File Offset: 0x000AC840
		[DebuggerNonUserCode]
		public RepeatedField<string> HeroIds
		{
			get
			{
				return this.heroIds_;
			}
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x000AE658 File Offset: 0x000AC858
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroList);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x000AE678 File Offset: 0x000AC878
		[DebuggerNonUserCode]
		public bool Equals(HeroList other)
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
					bool flag4 = !this.heroIds_.Equals(other.heroIds_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000AE6D4 File Offset: 0x000AC8D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heroIds_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000AE714 File Offset: 0x000AC914
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000AE72C File Offset: 0x000AC92C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000AE738 File Offset: 0x000AC938
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroIds_.WriteTo(ref output, HeroList._repeated_heroIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000AE774 File Offset: 0x000AC974
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroIds_.CalculateSize(HeroList._repeated_heroIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000AE7BC File Offset: 0x000AC9BC
		[DebuggerNonUserCode]
		public void MergeFrom(HeroList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroIds_.Add(other.heroIds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000AE7FE File Offset: 0x000AC9FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000AE80C File Offset: 0x000ACA0C
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
					this.heroIds_.AddEntriesFrom(ref input, HeroList._repeated_heroIds_codec);
				}
			}
		}

		// Token: 0x0400140F RID: 5135
		private static readonly MessageParser<HeroList> _parser = new MessageParser<HeroList>(() => new HeroList());

		// Token: 0x04001410 RID: 5136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001411 RID: 5137
		public const int HeroIdsFieldNumber = 1;

		// Token: 0x04001412 RID: 5138
		private static readonly FieldCodec<string> _repeated_heroIds_codec = FieldCodec.ForString(10U);

		// Token: 0x04001413 RID: 5139
		private readonly RepeatedField<string> heroIds_ = new RepeatedField<string>();
	}
}
