using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029E RID: 670
	public sealed class ListDeletedHeroesResponse : IMessage<ListDeletedHeroesResponse>, IMessage, IEquatable<ListDeletedHeroesResponse>, IDeepCloneable<ListDeletedHeroesResponse>, IBufferMessage
	{
		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x0010F118 File Offset: 0x0010D318
		[DebuggerNonUserCode]
		public static MessageParser<ListDeletedHeroesResponse> Parser
		{
			get
			{
				return ListDeletedHeroesResponse._parser;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0010F130 File Offset: 0x0010D330
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[142];
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x0010F158 File Offset: 0x0010D358
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListDeletedHeroesResponse.Descriptor;
			}
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0010F16F File Offset: 0x0010D36F
		[DebuggerNonUserCode]
		public ListDeletedHeroesResponse()
		{
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x0010F184 File Offset: 0x0010D384
		[DebuggerNonUserCode]
		public ListDeletedHeroesResponse(ListDeletedHeroesResponse other)
			: this()
		{
			this.heroes_ = other.heroes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x0010F1B0 File Offset: 0x0010D3B0
		[DebuggerNonUserCode]
		public ListDeletedHeroesResponse Clone()
		{
			return new ListDeletedHeroesResponse(this);
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x0010F1C8 File Offset: 0x0010D3C8
		[DebuggerNonUserCode]
		public RepeatedField<Digest> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x0010F1E0 File Offset: 0x0010D3E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListDeletedHeroesResponse);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x0010F200 File Offset: 0x0010D400
		[DebuggerNonUserCode]
		public bool Equals(ListDeletedHeroesResponse other)
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

		// Token: 0x060046F2 RID: 18162 RVA: 0x0010F25C File Offset: 0x0010D45C
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

		// Token: 0x060046F3 RID: 18163 RVA: 0x0010F29C File Offset: 0x0010D49C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x0010F2B4 File Offset: 0x0010D4B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0010F2C0 File Offset: 0x0010D4C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroes_.WriteTo(ref output, ListDeletedHeroesResponse._repeated_heroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x0010F2FC File Offset: 0x0010D4FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroes_.CalculateSize(ListDeletedHeroesResponse._repeated_heroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x0010F344 File Offset: 0x0010D544
		[DebuggerNonUserCode]
		public void MergeFrom(ListDeletedHeroesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroes_.Add(other.heroes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x0010F386 File Offset: 0x0010D586
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x0010F394 File Offset: 0x0010D594
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
					this.heroes_.AddEntriesFrom(ref input, ListDeletedHeroesResponse._repeated_heroes_codec);
				}
			}
		}

		// Token: 0x04001F7C RID: 8060
		private static readonly MessageParser<ListDeletedHeroesResponse> _parser = new MessageParser<ListDeletedHeroesResponse>(() => new ListDeletedHeroesResponse());

		// Token: 0x04001F7D RID: 8061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F7E RID: 8062
		public const int HeroesFieldNumber = 1;

		// Token: 0x04001F7F RID: 8063
		private static readonly FieldCodec<Digest> _repeated_heroes_codec = FieldCodec.ForMessage<Digest>(10U, Digest.Parser);

		// Token: 0x04001F80 RID: 8064
		private readonly RepeatedField<Digest> heroes_ = new RepeatedField<Digest>();
	}
}
