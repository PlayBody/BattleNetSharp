using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BC RID: 956
	public sealed class RecentPlayersAddedNotification : IMessage<RecentPlayersAddedNotification>, IMessage, IEquatable<RecentPlayersAddedNotification>, IDeepCloneable<RecentPlayersAddedNotification>, IBufferMessage
	{
		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x00174188 File Offset: 0x00172388
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayersAddedNotification> Parser
		{
			get
			{
				return RecentPlayersAddedNotification._parser;
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x001741A0 File Offset: 0x001723A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x001741C4 File Offset: 0x001723C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersAddedNotification.Descriptor;
			}
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x001741DB File Offset: 0x001723DB
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification()
		{
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x001741F0 File Offset: 0x001723F0
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification(RecentPlayersAddedNotification other)
			: this()
		{
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x0017421C File Offset: 0x0017241C
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification Clone()
		{
			return new RecentPlayersAddedNotification(this);
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x00174234 File Offset: 0x00172434
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x0017424C File Offset: 0x0017244C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersAddedNotification);
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x0017426C File Offset: 0x0017246C
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayersAddedNotification other)
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

		// Token: 0x0600600F RID: 24591 RVA: 0x001742C8 File Offset: 0x001724C8
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

		// Token: 0x06006010 RID: 24592 RVA: 0x00174308 File Offset: 0x00172508
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00174320 File Offset: 0x00172520
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x0017432C File Offset: 0x0017252C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.player_.WriteTo(ref output, RecentPlayersAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x00174368 File Offset: 0x00172568
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.player_.CalculateSize(RecentPlayersAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x001743B0 File Offset: 0x001725B0
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayersAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x001743F2 File Offset: 0x001725F2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x00174400 File Offset: 0x00172600
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
					this.player_.AddEntriesFrom(ref input, RecentPlayersAddedNotification._repeated_player_codec);
				}
			}
		}

		// Token: 0x04002BDA RID: 11226
		private static readonly MessageParser<RecentPlayersAddedNotification> _parser = new MessageParser<RecentPlayersAddedNotification>(() => new RecentPlayersAddedNotification());

		// Token: 0x04002BDB RID: 11227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BDC RID: 11228
		public const int PlayerFieldNumber = 1;

		// Token: 0x04002BDD RID: 11229
		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(10U, RecentPlayer.Parser);

		// Token: 0x04002BDE RID: 11230
		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();
	}
}
