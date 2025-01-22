using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000294 RID: 660
	public sealed class GetFallenHeroesResponse : IMessage<GetFallenHeroesResponse>, IMessage, IEquatable<GetFallenHeroesResponse>, IDeepCloneable<GetFallenHeroesResponse>, IBufferMessage
	{
		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x0010C89C File Offset: 0x0010AA9C
		[DebuggerNonUserCode]
		public static MessageParser<GetFallenHeroesResponse> Parser
		{
			get
			{
				return GetFallenHeroesResponse._parser;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x0010C8B4 File Offset: 0x0010AAB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[132];
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x0010C8DC File Offset: 0x0010AADC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFallenHeroesResponse.Descriptor;
			}
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x0010C8F3 File Offset: 0x0010AAF3
		[DebuggerNonUserCode]
		public GetFallenHeroesResponse()
		{
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x0010C908 File Offset: 0x0010AB08
		[DebuggerNonUserCode]
		public GetFallenHeroesResponse(GetFallenHeroesResponse other)
			: this()
		{
			this.heroes_ = other.heroes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x0010C934 File Offset: 0x0010AB34
		[DebuggerNonUserCode]
		public GetFallenHeroesResponse Clone()
		{
			return new GetFallenHeroesResponse(this);
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x0010C94C File Offset: 0x0010AB4C
		[DebuggerNonUserCode]
		public RepeatedField<FallenHero> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x0010C964 File Offset: 0x0010AB64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFallenHeroesResponse);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x0010C984 File Offset: 0x0010AB84
		[DebuggerNonUserCode]
		public bool Equals(GetFallenHeroesResponse other)
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
					bool flag4 = !this.heroes_.Equals(other.heroes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x0010C9E0 File Offset: 0x0010ABE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heroes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x0010CA20 File Offset: 0x0010AC20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x0010CA38 File Offset: 0x0010AC38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x0010CA44 File Offset: 0x0010AC44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroes_.WriteTo(ref output, GetFallenHeroesResponse._repeated_heroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x0010CA80 File Offset: 0x0010AC80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroes_.CalculateSize(GetFallenHeroesResponse._repeated_heroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x0010CAC8 File Offset: 0x0010ACC8
		[DebuggerNonUserCode]
		public void MergeFrom(GetFallenHeroesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroes_.Add(other.heroes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x0010CB0A File Offset: 0x0010AD0A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x0010CB18 File Offset: 0x0010AD18
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
					this.heroes_.AddEntriesFrom(ref input, GetFallenHeroesResponse._repeated_heroes_codec);
				}
			}
		}

		// Token: 0x04001F35 RID: 7989
		private static readonly MessageParser<GetFallenHeroesResponse> _parser = new MessageParser<GetFallenHeroesResponse>(() => new GetFallenHeroesResponse());

		// Token: 0x04001F36 RID: 7990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F37 RID: 7991
		public const int HeroesFieldNumber = 1;

		// Token: 0x04001F38 RID: 7992
		private static readonly FieldCodec<FallenHero> _repeated_heroes_codec = FieldCodec.ForMessage<FallenHero>(10U, FallenHero.Parser);

		// Token: 0x04001F39 RID: 7993
		private readonly RepeatedField<FallenHero> heroes_ = new RepeatedField<FallenHero>();
	}
}
