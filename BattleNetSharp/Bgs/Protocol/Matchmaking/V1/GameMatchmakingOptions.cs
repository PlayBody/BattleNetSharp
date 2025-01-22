using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E9 RID: 1001
	public sealed class GameMatchmakingOptions : IMessage<GameMatchmakingOptions>, IMessage, IEquatable<GameMatchmakingOptions>, IDeepCloneable<GameMatchmakingOptions>, IBufferMessage
	{
		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x00180FB4 File Offset: 0x0017F1B4
		[DebuggerNonUserCode]
		public static MessageParser<GameMatchmakingOptions> Parser
		{
			get
			{
				return GameMatchmakingOptions._parser;
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06006393 RID: 25491 RVA: 0x00180FCC File Offset: 0x0017F1CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x00180FF0 File Offset: 0x0017F1F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMatchmakingOptions.Descriptor;
			}
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x00181007 File Offset: 0x0017F207
		[DebuggerNonUserCode]
		public GameMatchmakingOptions()
		{
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0018101C File Offset: 0x0017F21C
		[DebuggerNonUserCode]
		public GameMatchmakingOptions(GameMatchmakingOptions other)
			: this()
		{
			this.matchmakerFilter_ = ((other.matchmakerFilter_ != null) ? other.matchmakerFilter_.Clone() : null);
			this.creationProperties_ = ((other.creationProperties_ != null) ? other.creationProperties_.Clone() : null);
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0018108C File Offset: 0x0017F28C
		[DebuggerNonUserCode]
		public GameMatchmakingOptions Clone()
		{
			return new GameMatchmakingOptions(this);
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x001810A4 File Offset: 0x0017F2A4
		// (set) Token: 0x06006399 RID: 25497 RVA: 0x001810BC File Offset: 0x0017F2BC
		[DebuggerNonUserCode]
		public GameMatchmakerFilter MatchmakerFilter
		{
			get
			{
				return this.matchmakerFilter_;
			}
			set
			{
				this.matchmakerFilter_ = value;
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x001810C8 File Offset: 0x0017F2C8
		// (set) Token: 0x0600639B RID: 25499 RVA: 0x001810E0 File Offset: 0x0017F2E0
		[DebuggerNonUserCode]
		public GameCreationProperties CreationProperties
		{
			get
			{
				return this.creationProperties_;
			}
			set
			{
				this.creationProperties_ = value;
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x001810EC File Offset: 0x0017F2EC
		[DebuggerNonUserCode]
		public RepeatedField<Player> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x00181104 File Offset: 0x0017F304
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMatchmakingOptions);
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x00181124 File Offset: 0x0017F324
		[DebuggerNonUserCode]
		public bool Equals(GameMatchmakingOptions other)
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
					bool flag4 = !object.Equals(this.MatchmakerFilter, other.MatchmakerFilter);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CreationProperties, other.CreationProperties);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.player_.Equals(other.player_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x001811BC File Offset: 0x0017F3BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.matchmakerFilter_ != null;
			if (flag)
			{
				num ^= this.MatchmakerFilter.GetHashCode();
			}
			bool flag2 = this.creationProperties_ != null;
			if (flag2)
			{
				num ^= this.CreationProperties.GetHashCode();
			}
			num ^= this.player_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x00181234 File Offset: 0x0017F434
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x0018124C File Offset: 0x0017F44C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x00181258 File Offset: 0x0017F458
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.matchmakerFilter_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MatchmakerFilter);
			}
			bool flag2 = this.creationProperties_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CreationProperties);
			}
			this.player_.WriteTo(ref output, GameMatchmakingOptions._repeated_player_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x001812E0 File Offset: 0x0017F4E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.matchmakerFilter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MatchmakerFilter);
			}
			bool flag2 = this.creationProperties_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreationProperties);
			}
			num += this.player_.CalculateSize(GameMatchmakingOptions._repeated_player_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x00181368 File Offset: 0x0017F568
		[DebuggerNonUserCode]
		public void MergeFrom(GameMatchmakingOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.matchmakerFilter_ != null;
				if (flag2)
				{
					bool flag3 = this.matchmakerFilter_ == null;
					if (flag3)
					{
						this.MatchmakerFilter = new GameMatchmakerFilter();
					}
					this.MatchmakerFilter.MergeFrom(other.MatchmakerFilter);
				}
				bool flag4 = other.creationProperties_ != null;
				if (flag4)
				{
					bool flag5 = this.creationProperties_ == null;
					if (flag5)
					{
						this.CreationProperties = new GameCreationProperties();
					}
					this.CreationProperties.MergeFrom(other.CreationProperties);
				}
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x00181427 File Offset: 0x0017F627
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x00181434 File Offset: 0x0017F634
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.player_.AddEntriesFrom(ref input, GameMatchmakingOptions._repeated_player_codec);
						}
					}
					else
					{
						bool flag = this.creationProperties_ == null;
						if (flag)
						{
							this.CreationProperties = new GameCreationProperties();
						}
						input.ReadMessage(this.CreationProperties);
					}
				}
				else
				{
					bool flag2 = this.matchmakerFilter_ == null;
					if (flag2)
					{
						this.MatchmakerFilter = new GameMatchmakerFilter();
					}
					input.ReadMessage(this.MatchmakerFilter);
				}
			}
		}

		// Token: 0x04002D66 RID: 11622
		private static readonly MessageParser<GameMatchmakingOptions> _parser = new MessageParser<GameMatchmakingOptions>(() => new GameMatchmakingOptions());

		// Token: 0x04002D67 RID: 11623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D68 RID: 11624
		public const int MatchmakerFilterFieldNumber = 1;

		// Token: 0x04002D69 RID: 11625
		private GameMatchmakerFilter matchmakerFilter_;

		// Token: 0x04002D6A RID: 11626
		public const int CreationPropertiesFieldNumber = 2;

		// Token: 0x04002D6B RID: 11627
		private GameCreationProperties creationProperties_;

		// Token: 0x04002D6C RID: 11628
		public const int PlayerFieldNumber = 3;

		// Token: 0x04002D6D RID: 11629
		private static readonly FieldCodec<Player> _repeated_player_codec = FieldCodec.ForMessage<Player>(26U, Bgs.Protocol.Matchmaking.V1.Player.Parser);

		// Token: 0x04002D6E RID: 11630
		private readonly RepeatedField<Player> player_ = new RepeatedField<Player>();
	}
}
