using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072A RID: 1834
	public sealed class GameAccountSessionNotification : IMessage<GameAccountSessionNotification>, IMessage, IEquatable<GameAccountSessionNotification>, IDeepCloneable<GameAccountSessionNotification>, IBufferMessage
	{
		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600A816 RID: 43030 RVA: 0x0028DF38 File Offset: 0x0028C138
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountSessionNotification> Parser
		{
			get
			{
				return GameAccountSessionNotification._parser;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600A817 RID: 43031 RVA: 0x0028DF50 File Offset: 0x0028C150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600A818 RID: 43032 RVA: 0x0028DF74 File Offset: 0x0028C174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountSessionNotification.Descriptor;
			}
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x0028DF8B File Offset: 0x0028C18B
		[DebuggerNonUserCode]
		public GameAccountSessionNotification()
		{
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x0028DF98 File Offset: 0x0028C198
		[DebuggerNonUserCode]
		public GameAccountSessionNotification(GameAccountSessionNotification other)
			: this()
		{
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x0028DFF8 File Offset: 0x0028C1F8
		[DebuggerNonUserCode]
		public GameAccountSessionNotification Clone()
		{
			return new GameAccountSessionNotification(this);
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600A81C RID: 43036 RVA: 0x0028E010 File Offset: 0x0028C210
		// (set) Token: 0x0600A81D RID: 43037 RVA: 0x0028E028 File Offset: 0x0028C228
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

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600A81E RID: 43038 RVA: 0x0028E034 File Offset: 0x0028C234
		// (set) Token: 0x0600A81F RID: 43039 RVA: 0x0028E04C File Offset: 0x0028C24C
		[DebuggerNonUserCode]
		public GameSessionUpdateInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		// Token: 0x0600A820 RID: 43040 RVA: 0x0028E058 File Offset: 0x0028C258
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountSessionNotification);
		}

		// Token: 0x0600A821 RID: 43041 RVA: 0x0028E078 File Offset: 0x0028C278
		[DebuggerNonUserCode]
		public bool Equals(GameAccountSessionNotification other)
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
						bool flag5 = !object.Equals(this.SessionInfo, other.SessionInfo);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x0028E0F0 File Offset: 0x0028C2F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag2 = this.sessionInfo_ != null;
			if (flag2)
			{
				num ^= this.SessionInfo.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x0028E15C File Offset: 0x0028C35C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x0028E174 File Offset: 0x0028C374
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x0028E180 File Offset: 0x0028C380
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool flag2 = this.sessionInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A826 RID: 43046 RVA: 0x0028E1F4 File Offset: 0x0028C3F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag2 = this.sessionInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x0028E268 File Offset: 0x0028C468
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountSessionNotification other)
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
				bool flag4 = other.sessionInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.sessionInfo_ == null;
					if (flag5)
					{
						this.SessionInfo = new GameSessionUpdateInfo();
					}
					this.SessionInfo.MergeFrom(other.SessionInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x0028E315 File Offset: 0x0028C515
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x0028E320 File Offset: 0x0028C520
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
						bool flag = this.sessionInfo_ == null;
						if (flag)
						{
							this.SessionInfo = new GameSessionUpdateInfo();
						}
						input.ReadMessage(this.SessionInfo);
					}
				}
				else
				{
					bool flag2 = this.gameAccount_ == null;
					if (flag2)
					{
						this.GameAccount = new GameAccountHandle();
					}
					input.ReadMessage(this.GameAccount);
				}
			}
		}

		// Token: 0x04004B5E RID: 19294
		private static readonly MessageParser<GameAccountSessionNotification> _parser = new MessageParser<GameAccountSessionNotification>(() => new GameAccountSessionNotification());

		// Token: 0x04004B5F RID: 19295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B60 RID: 19296
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04004B61 RID: 19297
		private GameAccountHandle gameAccount_;

		// Token: 0x04004B62 RID: 19298
		public const int SessionInfoFieldNumber = 2;

		// Token: 0x04004B63 RID: 19299
		private GameSessionUpdateInfo sessionInfo_;
	}
}
