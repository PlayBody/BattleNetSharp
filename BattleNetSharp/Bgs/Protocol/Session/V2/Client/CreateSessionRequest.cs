using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055A RID: 1370
	public sealed class CreateSessionRequest : IMessage<CreateSessionRequest>, IMessage, IEquatable<CreateSessionRequest>, IDeepCloneable<CreateSessionRequest>, IBufferMessage
	{
		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x002029D4 File Offset: 0x00200BD4
		[DebuggerNonUserCode]
		public static MessageParser<CreateSessionRequest> Parser
		{
			get
			{
				return CreateSessionRequest._parser;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600843E RID: 33854 RVA: 0x002029EC File Offset: 0x00200BEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600843F RID: 33855 RVA: 0x00202A10 File Offset: 0x00200C10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateSessionRequest.Descriptor;
			}
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x00202A27 File Offset: 0x00200C27
		[DebuggerNonUserCode]
		public CreateSessionRequest()
		{
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00202A34 File Offset: 0x00200C34
		[DebuggerNonUserCode]
		public CreateSessionRequest(CreateSessionRequest other)
			: this()
		{
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00202A94 File Offset: 0x00200C94
		[DebuggerNonUserCode]
		public CreateSessionRequest Clone()
		{
			return new CreateSessionRequest(this);
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06008443 RID: 33859 RVA: 0x00202AAC File Offset: 0x00200CAC
		// (set) Token: 0x06008444 RID: 33860 RVA: 0x00202AC4 File Offset: 0x00200CC4
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

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06008445 RID: 33861 RVA: 0x00202AD0 File Offset: 0x00200CD0
		// (set) Token: 0x06008446 RID: 33862 RVA: 0x00202AE8 File Offset: 0x00200CE8
		[DebuggerNonUserCode]
		public CreateOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x00202AF4 File Offset: 0x00200CF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateSessionRequest);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x00202B14 File Offset: 0x00200D14
		[DebuggerNonUserCode]
		public bool Equals(CreateSessionRequest other)
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
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x00202B8C File Offset: 0x00200D8C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x00202BF8 File Offset: 0x00200DF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x00202C10 File Offset: 0x00200E10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x00202C1C File Offset: 0x00200E1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x00202C90 File Offset: 0x00200E90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x00202D04 File Offset: 0x00200F04
		[DebuggerNonUserCode]
		public void MergeFrom(CreateSessionRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new CreateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x00202DB1 File Offset: 0x00200FB1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x00202DBC File Offset: 0x00200FBC
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
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new CreateOptions();
						}
						input.ReadMessage(this.Options);
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

		// Token: 0x04003C0A RID: 15370
		private static readonly MessageParser<CreateSessionRequest> _parser = new MessageParser<CreateSessionRequest>(() => new CreateSessionRequest());

		// Token: 0x04003C0B RID: 15371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C0C RID: 15372
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04003C0D RID: 15373
		private GameAccountHandle gameAccount_;

		// Token: 0x04003C0E RID: 15374
		public const int OptionsFieldNumber = 2;

		// Token: 0x04003C0F RID: 15375
		private CreateOptions options_;
	}
}
