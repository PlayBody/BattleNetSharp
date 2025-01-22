using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F6 RID: 1014
	public sealed class JoinGameRequest : IMessage<JoinGameRequest>, IMessage, IEquatable<JoinGameRequest>, IDeepCloneable<JoinGameRequest>, IBufferMessage
	{
		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00185130 File Offset: 0x00183330
		[DebuggerNonUserCode]
		public static MessageParser<JoinGameRequest> Parser
		{
			get
			{
				return JoinGameRequest._parser;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x00185148 File Offset: 0x00183348
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x0018516C File Offset: 0x0018336C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinGameRequest.Descriptor;
			}
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x00185183 File Offset: 0x00183383
		[DebuggerNonUserCode]
		public JoinGameRequest()
		{
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00185198 File Offset: 0x00183398
		[DebuggerNonUserCode]
		public JoinGameRequest(JoinGameRequest other)
			: this()
		{
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x001851EC File Offset: 0x001833EC
		[DebuggerNonUserCode]
		public JoinGameRequest Clone()
		{
			return new JoinGameRequest(this);
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x00185204 File Offset: 0x00183404
		// (set) Token: 0x060064AA RID: 25770 RVA: 0x0018521C File Offset: 0x0018341C
		[DebuggerNonUserCode]
		public GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x00185228 File Offset: 0x00183428
		[DebuggerNonUserCode]
		public RepeatedField<Player> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x00185240 File Offset: 0x00183440
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinGameRequest);
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00185260 File Offset: 0x00183460
		[DebuggerNonUserCode]
		public bool Equals(JoinGameRequest other)
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
					bool flag4 = !object.Equals(this.GameHandle, other.GameHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.player_.Equals(other.player_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x001852D8 File Offset: 0x001834D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			num ^= this.player_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00185334 File Offset: 0x00183534
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x0018534C File Offset: 0x0018354C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00185358 File Offset: 0x00183558
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			this.player_.WriteTo(ref output, JoinGameRequest._repeated_player_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x001853BC File Offset: 0x001835BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			num += this.player_.CalculateSize(JoinGameRequest._repeated_player_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00185420 File Offset: 0x00183620
		[DebuggerNonUserCode]
		public void MergeFrom(JoinGameRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.gameHandle_ == null;
					if (flag3)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x0018549E File Offset: 0x0018369E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x001854AC File Offset: 0x001836AC
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
						this.player_.AddEntriesFrom(ref input, JoinGameRequest._repeated_player_codec);
					}
				}
				else
				{
					bool flag = this.gameHandle_ == null;
					if (flag)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
			}
		}

		// Token: 0x04002DCE RID: 11726
		private static readonly MessageParser<JoinGameRequest> _parser = new MessageParser<JoinGameRequest>(() => new JoinGameRequest());

		// Token: 0x04002DCF RID: 11727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD0 RID: 11728
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002DD1 RID: 11729
		private GameHandle gameHandle_;

		// Token: 0x04002DD2 RID: 11730
		public const int PlayerFieldNumber = 2;

		// Token: 0x04002DD3 RID: 11731
		private static readonly FieldCodec<Player> _repeated_player_codec = FieldCodec.ForMessage<Player>(18U, Bgs.Protocol.Matchmaking.V1.Player.Parser);

		// Token: 0x04002DD4 RID: 11732
		private readonly RepeatedField<Player> player_ = new RepeatedField<Player>();
	}
}
