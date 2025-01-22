using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F1 RID: 1009
	public sealed class RemovePlayerOptions : IMessage<RemovePlayerOptions>, IMessage, IEquatable<RemovePlayerOptions>, IDeepCloneable<RemovePlayerOptions>, IBufferMessage
	{
		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x00183D24 File Offset: 0x00181F24
		[DebuggerNonUserCode]
		public static MessageParser<RemovePlayerOptions> Parser
		{
			get
			{
				return RemovePlayerOptions._parser;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x00183D3C File Offset: 0x00181F3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x00183D60 File Offset: 0x00181F60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePlayerOptions.Descriptor;
			}
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00183D77 File Offset: 0x00181F77
		[DebuggerNonUserCode]
		public RemovePlayerOptions()
		{
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00183D84 File Offset: 0x00181F84
		[DebuggerNonUserCode]
		public RemovePlayerOptions(RemovePlayerOptions other)
			: this()
		{
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x00183DE4 File Offset: 0x00181FE4
		[DebuggerNonUserCode]
		public RemovePlayerOptions Clone()
		{
			return new RemovePlayerOptions(this);
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x00183DFC File Offset: 0x00181FFC
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x00183E14 File Offset: 0x00182014
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

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x00183E20 File Offset: 0x00182020
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x00183E38 File Offset: 0x00182038
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

		// Token: 0x0600645D RID: 25693 RVA: 0x00183E44 File Offset: 0x00182044
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePlayerOptions);
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00183E64 File Offset: 0x00182064
		[DebuggerNonUserCode]
		public bool Equals(RemovePlayerOptions other)
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
						bool flag5 = !object.Equals(this.GameAccount, other.GameAccount);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00183EDC File Offset: 0x001820DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00183F48 File Offset: 0x00182148
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00183F60 File Offset: 0x00182160
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00183F6C File Offset: 0x0018216C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00183FE0 File Offset: 0x001821E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x00184054 File Offset: 0x00182254
		[DebuggerNonUserCode]
		public void MergeFrom(RemovePlayerOptions other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x00184101 File Offset: 0x00182301
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x0018410C File Offset: 0x0018230C
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
						bool flag = this.gameAccount_ == null;
						if (flag)
						{
							this.GameAccount = new GameAccountHandle();
						}
						input.ReadMessage(this.GameAccount);
					}
				}
				else
				{
					bool flag2 = this.gameHandle_ == null;
					if (flag2)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
			}
		}

		// Token: 0x04002DBB RID: 11707
		private static readonly MessageParser<RemovePlayerOptions> _parser = new MessageParser<RemovePlayerOptions>(() => new RemovePlayerOptions());

		// Token: 0x04002DBC RID: 11708
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DBD RID: 11709
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002DBE RID: 11710
		private GameHandle gameHandle_;

		// Token: 0x04002DBF RID: 11711
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04002DC0 RID: 11712
		private GameAccountHandle gameAccount_;
	}
}
