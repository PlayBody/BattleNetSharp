using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006EF RID: 1775
	public sealed class SubscriberId : IMessage<SubscriberId>, IMessage, IEquatable<SubscriberId>, IDeepCloneable<SubscriberId>, IBufferMessage
	{
		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x0027E824 File Offset: 0x0027CA24
		[DebuggerNonUserCode]
		public static MessageParser<SubscriberId> Parser
		{
			get
			{
				return SubscriberId._parser;
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x0027E83C File Offset: 0x0027CA3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x0027E860 File Offset: 0x0027CA60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberId.Descriptor;
			}
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x0027E877 File Offset: 0x0027CA77
		[DebuggerNonUserCode]
		public SubscriberId()
		{
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x0027E884 File Offset: 0x0027CA84
		[DebuggerNonUserCode]
		public SubscriberId(SubscriberId other)
			: this()
		{
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.process_ = ((other.process_ != null) ? other.process_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x0027E900 File Offset: 0x0027CB00
		[DebuggerNonUserCode]
		public SubscriberId Clone()
		{
			return new SubscriberId(this);
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x0027E918 File Offset: 0x0027CB18
		// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x0027E930 File Offset: 0x0027CB30
		[Obsolete]
		[DebuggerNonUserCode]
		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x0027E93C File Offset: 0x0027CB3C
		// (set) Token: 0x0600A3C4 RID: 41924 RVA: 0x0027E954 File Offset: 0x0027CB54
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

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x0027E960 File Offset: 0x0027CB60
		// (set) Token: 0x0600A3C6 RID: 41926 RVA: 0x0027E978 File Offset: 0x0027CB78
		[DebuggerNonUserCode]
		public ProcessId Process
		{
			get
			{
				return this.process_;
			}
			set
			{
				this.process_ = value;
			}
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x0027E984 File Offset: 0x0027CB84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberId);
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x0027E9A4 File Offset: 0x0027CBA4
		[DebuggerNonUserCode]
		public bool Equals(SubscriberId other)
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
					bool flag4 = !object.Equals(this.Account, other.Account);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccount, other.GameAccount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Process, other.Process);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x0027EA3C File Offset: 0x0027CC3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.account_ != null;
			if (flag)
			{
				num ^= this.Account.GetHashCode();
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag3 = this.process_ != null;
			if (flag3)
			{
				num ^= this.Process.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x0027EAC4 File Offset: 0x0027CCC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x0027EADC File Offset: 0x0027CCDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x0027EAE8 File Offset: 0x0027CCE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.account_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Account);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			bool flag3 = this.process_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Process);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x0027EB84 File Offset: 0x0027CD84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.account_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag3 = this.process_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Process);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x0027EC18 File Offset: 0x0027CE18
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriberId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.account_ != null;
				if (flag2)
				{
					bool flag3 = this.account_ == null;
					if (flag3)
					{
						this.Account = new AccountId();
					}
					this.Account.MergeFrom(other.Account);
				}
				bool flag4 = other.gameAccount_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccount_ == null;
					if (flag5)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				bool flag6 = other.process_ != null;
				if (flag6)
				{
					bool flag7 = this.process_ == null;
					if (flag7)
					{
						this.Process = new ProcessId();
					}
					this.Process.MergeFrom(other.Process);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x0027ED05 File Offset: 0x0027CF05
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x0027ED10 File Offset: 0x0027CF10
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
							bool flag = this.process_ == null;
							if (flag)
							{
								this.Process = new ProcessId();
							}
							input.ReadMessage(this.Process);
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
				else
				{
					bool flag3 = this.account_ == null;
					if (flag3)
					{
						this.Account = new AccountId();
					}
					input.ReadMessage(this.Account);
				}
			}
		}

		// Token: 0x040049D6 RID: 18902
		private static readonly MessageParser<SubscriberId> _parser = new MessageParser<SubscriberId>(() => new SubscriberId());

		// Token: 0x040049D7 RID: 18903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D8 RID: 18904
		public const int AccountFieldNumber = 1;

		// Token: 0x040049D9 RID: 18905
		private AccountId account_;

		// Token: 0x040049DA RID: 18906
		public const int GameAccountFieldNumber = 2;

		// Token: 0x040049DB RID: 18907
		private GameAccountHandle gameAccount_;

		// Token: 0x040049DC RID: 18908
		public const int ProcessFieldNumber = 3;

		// Token: 0x040049DD RID: 18909
		private ProcessId process_;
	}
}
