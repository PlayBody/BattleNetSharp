using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027D RID: 637
	public sealed class FindClansResponse : IMessage<FindClansResponse>, IMessage, IEquatable<FindClansResponse>, IDeepCloneable<FindClansResponse>, IBufferMessage
	{
		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00106C94 File Offset: 0x00104E94
		[DebuggerNonUserCode]
		public static MessageParser<FindClansResponse> Parser
		{
			get
			{
				return FindClansResponse._parser;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x00106CAC File Offset: 0x00104EAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[109];
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x00106CD0 File Offset: 0x00104ED0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindClansResponse.Descriptor;
			}
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00106CE7 File Offset: 0x00104EE7
		[DebuggerNonUserCode]
		public FindClansResponse()
		{
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00106CFC File Offset: 0x00104EFC
		[DebuggerNonUserCode]
		public FindClansResponse(FindClansResponse other)
			: this()
		{
			this.clan_ = other.clan_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00106D28 File Offset: 0x00104F28
		[DebuggerNonUserCode]
		public FindClansResponse Clone()
		{
			return new FindClansResponse(this);
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x00106D40 File Offset: 0x00104F40
		[DebuggerNonUserCode]
		public RepeatedField<ClanProfile> Clan
		{
			get
			{
				return this.clan_;
			}
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00106D58 File Offset: 0x00104F58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindClansResponse);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00106D78 File Offset: 0x00104F78
		[DebuggerNonUserCode]
		public bool Equals(FindClansResponse other)
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
					bool flag4 = !this.clan_.Equals(other.clan_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00106DD4 File Offset: 0x00104FD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.clan_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00106E14 File Offset: 0x00105014
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00106E2C File Offset: 0x0010502C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00106E38 File Offset: 0x00105038
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.clan_.WriteTo(ref output, FindClansResponse._repeated_clan_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00106E74 File Offset: 0x00105074
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.clan_.CalculateSize(FindClansResponse._repeated_clan_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00106EBC File Offset: 0x001050BC
		[DebuggerNonUserCode]
		public void MergeFrom(FindClansResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.clan_.Add(other.clan_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00106EFE File Offset: 0x001050FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00106F0C File Offset: 0x0010510C
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
					this.clan_.AddEntriesFrom(ref input, FindClansResponse._repeated_clan_codec);
				}
			}
		}

		// Token: 0x04001E93 RID: 7827
		private static readonly MessageParser<FindClansResponse> _parser = new MessageParser<FindClansResponse>(() => new FindClansResponse());

		// Token: 0x04001E94 RID: 7828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E95 RID: 7829
		public const int ClanFieldNumber = 1;

		// Token: 0x04001E96 RID: 7830
		private static readonly FieldCodec<ClanProfile> _repeated_clan_codec = FieldCodec.ForMessage<ClanProfile>(10U, ClanProfile.Parser);

		// Token: 0x04001E97 RID: 7831
		private readonly RepeatedField<ClanProfile> clan_ = new RepeatedField<ClanProfile>();
	}
}
