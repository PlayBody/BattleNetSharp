using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E6 RID: 998
	public sealed class Player : IMessage<Player>, IMessage, IEquatable<Player>, IDeepCloneable<Player>, IBufferMessage
	{
		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x0018051C File Offset: 0x0017E71C
		[DebuggerNonUserCode]
		public static MessageParser<Player> Parser
		{
			get
			{
				return Player._parser;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x00180534 File Offset: 0x0017E734
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x00180558 File Offset: 0x0017E758
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Player.Descriptor;
			}
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x0018056F File Offset: 0x0017E76F
		[DebuggerNonUserCode]
		public Player()
		{
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00180584 File Offset: 0x0017E784
		[DebuggerNonUserCode]
		public Player(Player other)
			: this()
		{
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x001805D8 File Offset: 0x0017E7D8
		[DebuggerNonUserCode]
		public Player Clone()
		{
			return new Player(this);
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600635D RID: 25437 RVA: 0x001805F0 File Offset: 0x0017E7F0
		// (set) Token: 0x0600635E RID: 25438 RVA: 0x00180608 File Offset: 0x0017E808
		[DebuggerNonUserCode]
		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x0600635F RID: 25439 RVA: 0x00180614 File Offset: 0x0017E814
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x0018062C File Offset: 0x0017E82C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Player);
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x0018064C File Offset: 0x0017E84C
		[DebuggerNonUserCode]
		public bool Equals(Player other)
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
					bool flag4 = !object.Equals(this.GameAccount, other.GameAccount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x001806C4 File Offset: 0x0017E8C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00180720 File Offset: 0x0017E920
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x00180738 File Offset: 0x0017E938
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x00180744 File Offset: 0x0017E944
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			this.attribute_.WriteTo(ref output, Player._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x001807A8 File Offset: 0x0017E9A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			num += this.attribute_.CalculateSize(Player._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0018080C File Offset: 0x0017EA0C
		[DebuggerNonUserCode]
		public void MergeFrom(Player other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccount_ == null;
					if (flag3)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x0018088A File Offset: 0x0017EA8A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x00180898 File Offset: 0x0017EA98
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, Player._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.gameAccount_ == null;
					if (flag)
					{
						this.GameAccount = new GameAccountHandle();
					}
					input.ReadMessage(this.GameAccount);
				}
			}
		}

		// Token: 0x04002D54 RID: 11604
		private static readonly MessageParser<Player> _parser = new MessageParser<Player>(() => new Player());

		// Token: 0x04002D55 RID: 11605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D56 RID: 11606
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04002D57 RID: 11607
		private GameAccountHandle gameAccount_;

		// Token: 0x04002D58 RID: 11608
		public const int AttributeFieldNumber = 2;

		// Token: 0x04002D59 RID: 11609
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002D5A RID: 11610
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
