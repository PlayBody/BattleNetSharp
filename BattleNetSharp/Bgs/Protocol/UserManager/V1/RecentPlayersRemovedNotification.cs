using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BD RID: 957
	public sealed class RecentPlayersRemovedNotification : IMessage<RecentPlayersRemovedNotification>, IMessage, IEquatable<RecentPlayersRemovedNotification>, IDeepCloneable<RecentPlayersRemovedNotification>, IBufferMessage
	{
		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00174484 File Offset: 0x00172684
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayersRemovedNotification> Parser
		{
			get
			{
				return RecentPlayersRemovedNotification._parser;
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x0017449C File Offset: 0x0017269C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x001744C0 File Offset: 0x001726C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersRemovedNotification.Descriptor;
			}
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x001744D7 File Offset: 0x001726D7
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification()
		{
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x001744EC File Offset: 0x001726EC
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification(RecentPlayersRemovedNotification other)
			: this()
		{
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00174518 File Offset: 0x00172718
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification Clone()
		{
			return new RecentPlayersRemovedNotification(this);
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x00174530 File Offset: 0x00172730
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00174548 File Offset: 0x00172748
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersRemovedNotification);
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00174568 File Offset: 0x00172768
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayersRemovedNotification other)
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
					bool flag4 = !this.player_.Equals(other.player_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x001745C4 File Offset: 0x001727C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.player_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00174604 File Offset: 0x00172804
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x0017461C File Offset: 0x0017281C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00174628 File Offset: 0x00172828
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.player_.WriteTo(ref output, RecentPlayersRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00174664 File Offset: 0x00172864
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.player_.CalculateSize(RecentPlayersRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x001746AC File Offset: 0x001728AC
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayersRemovedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x001746EE File Offset: 0x001728EE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x001746FC File Offset: 0x001728FC
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
					this.player_.AddEntriesFrom(ref input, RecentPlayersRemovedNotification._repeated_player_codec);
				}
			}
		}

		// Token: 0x04002BDF RID: 11231
		private static readonly MessageParser<RecentPlayersRemovedNotification> _parser = new MessageParser<RecentPlayersRemovedNotification>(() => new RecentPlayersRemovedNotification());

		// Token: 0x04002BE0 RID: 11232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BE1 RID: 11233
		public const int PlayerFieldNumber = 1;

		// Token: 0x04002BE2 RID: 11234
		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(10U, RecentPlayer.Parser);

		// Token: 0x04002BE3 RID: 11235
		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();
	}
}
