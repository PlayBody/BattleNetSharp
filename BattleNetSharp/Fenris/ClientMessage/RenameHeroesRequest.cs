using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000226 RID: 550
	public sealed class RenameHeroesRequest : IMessage<RenameHeroesRequest>, IMessage, IEquatable<RenameHeroesRequest>, IDeepCloneable<RenameHeroesRequest>, IBufferMessage
	{
		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x000EDEA4 File Offset: 0x000EC0A4
		[DebuggerNonUserCode]
		public static MessageParser<RenameHeroesRequest> Parser
		{
			get
			{
				return RenameHeroesRequest._parser;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x000EDEBC File Offset: 0x000EC0BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x000EDEE0 File Offset: 0x000EC0E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameHeroesRequest.Descriptor;
			}
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x000EDEF7 File Offset: 0x000EC0F7
		[DebuggerNonUserCode]
		public RenameHeroesRequest()
		{
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x000EDF0C File Offset: 0x000EC10C
		[DebuggerNonUserCode]
		public RenameHeroesRequest(RenameHeroesRequest other)
			: this()
		{
			this.renameHeroes_ = other.renameHeroes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x000EDF38 File Offset: 0x000EC138
		[DebuggerNonUserCode]
		public RenameHeroesRequest Clone()
		{
			return new RenameHeroesRequest(this);
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x000EDF50 File Offset: 0x000EC150
		[DebuggerNonUserCode]
		public RepeatedField<RenameHero> RenameHeroes
		{
			get
			{
				return this.renameHeroes_;
			}
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x000EDF68 File Offset: 0x000EC168
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameHeroesRequest);
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x000EDF88 File Offset: 0x000EC188
		[DebuggerNonUserCode]
		public bool Equals(RenameHeroesRequest other)
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
					bool flag4 = !this.renameHeroes_.Equals(other.renameHeroes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x000EDFE4 File Offset: 0x000EC1E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.renameHeroes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x000EE024 File Offset: 0x000EC224
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x000EE03C File Offset: 0x000EC23C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x000EE048 File Offset: 0x000EC248
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.renameHeroes_.WriteTo(ref output, RenameHeroesRequest._repeated_renameHeroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x000EE084 File Offset: 0x000EC284
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.renameHeroes_.CalculateSize(RenameHeroesRequest._repeated_renameHeroes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x000EE0CC File Offset: 0x000EC2CC
		[DebuggerNonUserCode]
		public void MergeFrom(RenameHeroesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.renameHeroes_.Add(other.renameHeroes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000EE10E File Offset: 0x000EC30E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x000EE11C File Offset: 0x000EC31C
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
					this.renameHeroes_.AddEntriesFrom(ref input, RenameHeroesRequest._repeated_renameHeroes_codec);
				}
			}
		}

		// Token: 0x04001BBA RID: 7098
		private static readonly MessageParser<RenameHeroesRequest> _parser = new MessageParser<RenameHeroesRequest>(() => new RenameHeroesRequest());

		// Token: 0x04001BBB RID: 7099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BBC RID: 7100
		public const int RenameHeroesFieldNumber = 1;

		// Token: 0x04001BBD RID: 7101
		private static readonly FieldCodec<RenameHero> _repeated_renameHeroes_codec = FieldCodec.ForMessage<RenameHero>(10U, RenameHero.Parser);

		// Token: 0x04001BBE RID: 7102
		private readonly RepeatedField<RenameHero> renameHeroes_ = new RepeatedField<RenameHero>();
	}
}
