using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000233 RID: 563
	public sealed class GetHeroDigestsResponse : IMessage<GetHeroDigestsResponse>, IMessage, IEquatable<GetHeroDigestsResponse>, IDeepCloneable<GetHeroDigestsResponse>, IBufferMessage
	{
		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x000F1844 File Offset: 0x000EFA44
		[DebuggerNonUserCode]
		public static MessageParser<GetHeroDigestsResponse> Parser
		{
			get
			{
				return GetHeroDigestsResponse._parser;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x000F185C File Offset: 0x000EFA5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x000F1880 File Offset: 0x000EFA80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeroDigestsResponse.Descriptor;
			}
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x000F1897 File Offset: 0x000EFA97
		[DebuggerNonUserCode]
		public GetHeroDigestsResponse()
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x000F18AC File Offset: 0x000EFAAC
		[DebuggerNonUserCode]
		public GetHeroDigestsResponse(GetHeroDigestsResponse other)
			: this()
		{
			this.heroDigests_ = other.heroDigests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x000F18D8 File Offset: 0x000EFAD8
		[DebuggerNonUserCode]
		public GetHeroDigestsResponse Clone()
		{
			return new GetHeroDigestsResponse(this);
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x000F18F0 File Offset: 0x000EFAF0
		[DebuggerNonUserCode]
		public RepeatedField<Digest> HeroDigests
		{
			get
			{
				return this.heroDigests_;
			}
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x000F1908 File Offset: 0x000EFB08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeroDigestsResponse);
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000F1928 File Offset: 0x000EFB28
		[DebuggerNonUserCode]
		public bool Equals(GetHeroDigestsResponse other)
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
					bool flag4 = !this.heroDigests_.Equals(other.heroDigests_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000F1984 File Offset: 0x000EFB84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heroDigests_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x000F19C4 File Offset: 0x000EFBC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x000F19DC File Offset: 0x000EFBDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x000F19E8 File Offset: 0x000EFBE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroDigests_.WriteTo(ref output, GetHeroDigestsResponse._repeated_heroDigests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x000F1A24 File Offset: 0x000EFC24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroDigests_.CalculateSize(GetHeroDigestsResponse._repeated_heroDigests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x000F1A6C File Offset: 0x000EFC6C
		[DebuggerNonUserCode]
		public void MergeFrom(GetHeroDigestsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroDigests_.Add(other.heroDigests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x000F1AAE File Offset: 0x000EFCAE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x000F1ABC File Offset: 0x000EFCBC
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
					this.heroDigests_.AddEntriesFrom(ref input, GetHeroDigestsResponse._repeated_heroDigests_codec);
				}
			}
		}

		// Token: 0x04001C1E RID: 7198
		private static readonly MessageParser<GetHeroDigestsResponse> _parser = new MessageParser<GetHeroDigestsResponse>(() => new GetHeroDigestsResponse());

		// Token: 0x04001C1F RID: 7199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C20 RID: 7200
		public const int HeroDigestsFieldNumber = 1;

		// Token: 0x04001C21 RID: 7201
		private static readonly FieldCodec<Digest> _repeated_heroDigests_codec = FieldCodec.ForMessage<Digest>(10U, Digest.Parser);

		// Token: 0x04001C22 RID: 7202
		private readonly RepeatedField<Digest> heroDigests_ = new RepeatedField<Digest>();
	}
}
