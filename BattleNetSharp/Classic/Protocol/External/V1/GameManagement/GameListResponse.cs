using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000796 RID: 1942
	public sealed class GameListResponse : IMessage<GameListResponse>, IMessage, IEquatable<GameListResponse>, IDeepCloneable<GameListResponse>, IBufferMessage
	{
		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x002B71C0 File Offset: 0x002B53C0
		[DebuggerNonUserCode]
		public static MessageParser<GameListResponse> Parser
		{
			get
			{
				return GameListResponse._parser;
			}
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600B281 RID: 45697 RVA: 0x002B71D8 File Offset: 0x002B53D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x002B71FC File Offset: 0x002B53FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameListResponse.Descriptor;
			}
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x002B7213 File Offset: 0x002B5413
		[DebuggerNonUserCode]
		public GameListResponse()
		{
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x002B7228 File Offset: 0x002B5428
		[DebuggerNonUserCode]
		public GameListResponse(GameListResponse other)
			: this()
		{
			this.games_ = other.games_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x002B7254 File Offset: 0x002B5454
		[DebuggerNonUserCode]
		public GameListResponse Clone()
		{
			return new GameListResponse(this);
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x002B726C File Offset: 0x002B546C
		[DebuggerNonUserCode]
		public RepeatedField<GameInfo> Games
		{
			get
			{
				return this.games_;
			}
		}

		// Token: 0x0600B287 RID: 45703 RVA: 0x002B7284 File Offset: 0x002B5484
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameListResponse);
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x002B72A4 File Offset: 0x002B54A4
		[DebuggerNonUserCode]
		public bool Equals(GameListResponse other)
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
					bool flag4 = !this.games_.Equals(other.games_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x002B7300 File Offset: 0x002B5500
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.games_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x002B7340 File Offset: 0x002B5540
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x002B7358 File Offset: 0x002B5558
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x002B7364 File Offset: 0x002B5564
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.games_.WriteTo(ref output, GameListResponse._repeated_games_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x002B73A0 File Offset: 0x002B55A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.games_.CalculateSize(GameListResponse._repeated_games_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x002B73E8 File Offset: 0x002B55E8
		[DebuggerNonUserCode]
		public void MergeFrom(GameListResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.games_.Add(other.games_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x002B742A File Offset: 0x002B562A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x002B7438 File Offset: 0x002B5638
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.games_.AddEntriesFrom(ref input, GameListResponse._repeated_games_codec);
				}
			}
		}

		// Token: 0x04005098 RID: 20632
		private static readonly MessageParser<GameListResponse> _parser = new MessageParser<GameListResponse>(() => new GameListResponse());

		// Token: 0x04005099 RID: 20633
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400509A RID: 20634
		public const int GamesFieldNumber = 3;

		// Token: 0x0400509B RID: 20635
		private static readonly FieldCodec<GameInfo> _repeated_games_codec = FieldCodec.ForMessage<GameInfo>(26U, GameInfo.Parser);

		// Token: 0x0400509C RID: 20636
		private readonly RepeatedField<GameInfo> games_ = new RepeatedField<GameInfo>();
	}
}
