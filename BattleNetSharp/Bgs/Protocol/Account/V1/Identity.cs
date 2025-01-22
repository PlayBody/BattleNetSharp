using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000734 RID: 1844
	public sealed class Identity : IMessage<Identity>, IMessage, IEquatable<Identity>, IDeepCloneable<Identity>, IBufferMessage
	{
		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x00291688 File Offset: 0x0028F888
		[DebuggerNonUserCode]
		public static MessageParser<Identity> Parser
		{
			get
			{
				return Identity._parser;
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x002916A0 File Offset: 0x0028F8A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002916C4 File Offset: 0x0028F8C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Identity.Descriptor;
			}
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x002916DB File Offset: 0x0028F8DB
		[DebuggerNonUserCode]
		public Identity()
		{
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x002916E8 File Offset: 0x0028F8E8
		[DebuggerNonUserCode]
		public Identity(Identity other)
			: this()
		{
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.process_ = ((other.process_ != null) ? other.process_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00291764 File Offset: 0x0028F964
		[DebuggerNonUserCode]
		public Identity Clone()
		{
			return new Identity(this);
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x0029177C File Offset: 0x0028F97C
		// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x00291794 File Offset: 0x0028F994
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

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002917A0 File Offset: 0x0028F9A0
		// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x002917B8 File Offset: 0x0028F9B8
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

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600A8B5 RID: 43189 RVA: 0x002917C4 File Offset: 0x0028F9C4
		// (set) Token: 0x0600A8B6 RID: 43190 RVA: 0x002917DC File Offset: 0x0028F9DC
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

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002917E8 File Offset: 0x0028F9E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Identity);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x00291808 File Offset: 0x0028FA08
		[DebuggerNonUserCode]
		public bool Equals(Identity other)
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

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x002918A0 File Offset: 0x0028FAA0
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

		// Token: 0x0600A8BA RID: 43194 RVA: 0x00291928 File Offset: 0x0028FB28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x00291940 File Offset: 0x0028FB40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x0029194C File Offset: 0x0028FB4C
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

		// Token: 0x0600A8BD RID: 43197 RVA: 0x002919E8 File Offset: 0x0028FBE8
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

		// Token: 0x0600A8BE RID: 43198 RVA: 0x00291A7C File Offset: 0x0028FC7C
		[DebuggerNonUserCode]
		public void MergeFrom(Identity other)
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

		// Token: 0x0600A8BF RID: 43199 RVA: 0x00291B69 File Offset: 0x0028FD69
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x00291B74 File Offset: 0x0028FD74
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

		// Token: 0x04004BD0 RID: 19408
		private static readonly MessageParser<Identity> _parser = new MessageParser<Identity>(() => new Identity());

		// Token: 0x04004BD1 RID: 19409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD2 RID: 19410
		public const int AccountFieldNumber = 1;

		// Token: 0x04004BD3 RID: 19411
		private AccountId account_;

		// Token: 0x04004BD4 RID: 19412
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04004BD5 RID: 19413
		private GameAccountHandle gameAccount_;

		// Token: 0x04004BD6 RID: 19414
		public const int ProcessFieldNumber = 3;

		// Token: 0x04004BD7 RID: 19415
		private ProcessId process_;
	}
}
