using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B4 RID: 948
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x00171798 File Offset: 0x0016F998
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x001717B0 File Offset: 0x0016F9B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x001717D4 File Offset: 0x0016F9D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x001717EB File Offset: 0x0016F9EB
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x00171818 File Offset: 0x0016FA18
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.blockedPlayers_ = other.blockedPlayers_.Clone();
			this.recentPlayers_ = other.recentPlayers_.Clone();
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00171874 File Offset: 0x0016FA74
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x0017188C File Offset: 0x0016FA8C
		[DebuggerNonUserCode]
		public RepeatedField<BlockedPlayer> BlockedPlayers
		{
			get
			{
				return this.blockedPlayers_;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06005F57 RID: 24407 RVA: 0x001718A4 File Offset: 0x0016FAA4
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> RecentPlayers
		{
			get
			{
				return this.recentPlayers_;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x001718BC File Offset: 0x0016FABC
		[DebuggerNonUserCode]
		public RepeatedField<Role> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x001718D4 File Offset: 0x0016FAD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x001718F4 File Offset: 0x0016FAF4
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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
					bool flag4 = !this.blockedPlayers_.Equals(other.blockedPlayers_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.recentPlayers_.Equals(other.recentPlayers_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.role_.Equals(other.role_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x0017198C File Offset: 0x0016FB8C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blockedPlayers_.GetHashCode();
			num ^= this.recentPlayers_.GetHashCode();
			num ^= this.role_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x001719E8 File Offset: 0x0016FBE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x00171A00 File Offset: 0x0016FC00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x00171A0C File Offset: 0x0016FC0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.blockedPlayers_.WriteTo(ref output, SubscribeResponse._repeated_blockedPlayers_codec);
			this.recentPlayers_.WriteTo(ref output, SubscribeResponse._repeated_recentPlayers_codec);
			this.role_.WriteTo(ref output, SubscribeResponse._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x00171A6C File Offset: 0x0016FC6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blockedPlayers_.CalculateSize(SubscribeResponse._repeated_blockedPlayers_codec);
			num += this.recentPlayers_.CalculateSize(SubscribeResponse._repeated_recentPlayers_codec);
			num += this.role_.CalculateSize(SubscribeResponse._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x00171AD8 File Offset: 0x0016FCD8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.blockedPlayers_.Add(other.blockedPlayers_);
				this.recentPlayers_.Add(other.recentPlayers_);
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x00171B3E File Offset: 0x0016FD3E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x00171B4C File Offset: 0x0016FD4C
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
							this.role_.AddEntriesFrom(ref input, SubscribeResponse._repeated_role_codec);
						}
					}
					else
					{
						this.recentPlayers_.AddEntriesFrom(ref input, SubscribeResponse._repeated_recentPlayers_codec);
					}
				}
				else
				{
					this.blockedPlayers_.AddEntriesFrom(ref input, SubscribeResponse._repeated_blockedPlayers_codec);
				}
			}
		}

		// Token: 0x04002B94 RID: 11156
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04002B95 RID: 11157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B96 RID: 11158
		public const int BlockedPlayersFieldNumber = 1;

		// Token: 0x04002B97 RID: 11159
		private static readonly FieldCodec<BlockedPlayer> _repeated_blockedPlayers_codec = FieldCodec.ForMessage<BlockedPlayer>(10U, BlockedPlayer.Parser);

		// Token: 0x04002B98 RID: 11160
		private readonly RepeatedField<BlockedPlayer> blockedPlayers_ = new RepeatedField<BlockedPlayer>();

		// Token: 0x04002B99 RID: 11161
		public const int RecentPlayersFieldNumber = 2;

		// Token: 0x04002B9A RID: 11162
		private static readonly FieldCodec<RecentPlayer> _repeated_recentPlayers_codec = FieldCodec.ForMessage<RecentPlayer>(18U, RecentPlayer.Parser);

		// Token: 0x04002B9B RID: 11163
		private readonly RepeatedField<RecentPlayer> recentPlayers_ = new RepeatedField<RecentPlayer>();

		// Token: 0x04002B9C RID: 11164
		public const int RoleFieldNumber = 3;

		// Token: 0x04002B9D RID: 11165
		private static readonly FieldCodec<Role> _repeated_role_codec = FieldCodec.ForMessage<Role>(26U, Bgs.Protocol.Role.Parser);

		// Token: 0x04002B9E RID: 11166
		private readonly RepeatedField<Role> role_ = new RepeatedField<Role>();
	}
}
