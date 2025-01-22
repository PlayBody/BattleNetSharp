using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E4 RID: 1508
	public sealed class PresenceChannelCreatedRequest : IMessage<PresenceChannelCreatedRequest>, IMessage, IEquatable<PresenceChannelCreatedRequest>, IDeepCloneable<PresenceChannelCreatedRequest>, IBufferMessage
	{
		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06008DD5 RID: 36309 RVA: 0x00226DE8 File Offset: 0x00224FE8
		[DebuggerNonUserCode]
		public static MessageParser<PresenceChannelCreatedRequest> Parser
		{
			get
			{
				return PresenceChannelCreatedRequest._parser;
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x00226E00 File Offset: 0x00225000
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06008DD7 RID: 36311 RVA: 0x00226E24 File Offset: 0x00225024
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceChannelCreatedRequest.Descriptor;
			}
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x00226E3B File Offset: 0x0022503B
		[DebuggerNonUserCode]
		public PresenceChannelCreatedRequest()
		{
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x00226E48 File Offset: 0x00225048
		[DebuggerNonUserCode]
		public PresenceChannelCreatedRequest(PresenceChannelCreatedRequest other)
			: this()
		{
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x00226EE0 File Offset: 0x002250E0
		[DebuggerNonUserCode]
		public PresenceChannelCreatedRequest Clone()
		{
			return new PresenceChannelCreatedRequest(this);
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x00226EF8 File Offset: 0x002250F8
		// (set) Token: 0x06008DDC RID: 36316 RVA: 0x00226F10 File Offset: 0x00225110
		[DebuggerNonUserCode]
		public EntityId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06008DDD RID: 36317 RVA: 0x00226F1C File Offset: 0x0022511C
		// (set) Token: 0x06008DDE RID: 36318 RVA: 0x00226F34 File Offset: 0x00225134
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06008DDF RID: 36319 RVA: 0x00226F40 File Offset: 0x00225140
		// (set) Token: 0x06008DE0 RID: 36320 RVA: 0x00226F58 File Offset: 0x00225158
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x00226F64 File Offset: 0x00225164
		// (set) Token: 0x06008DE2 RID: 36322 RVA: 0x00226F7C File Offset: 0x0022517C
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x00226F88 File Offset: 0x00225188
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceChannelCreatedRequest);
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00226FA8 File Offset: 0x002251A8
		[DebuggerNonUserCode]
		public bool Equals(PresenceChannelCreatedRequest other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccountId, other.GameAccountId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountId, other.AccountId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Host, other.Host);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00227064 File Offset: 0x00225264
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag4 = this.host_ != null;
			if (flag4)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x00227108 File Offset: 0x00225308
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x00227120 File Offset: 0x00225320
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x0022712C File Offset: 0x0022532C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AccountId);
			}
			bool flag4 = this.host_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Host);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x002271EC File Offset: 0x002253EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag4 = this.host_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x002272A0 File Offset: 0x002254A0
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceChannelCreatedRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new EntityId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool flag4 = other.gameAccountId_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccountId_ == null;
					if (flag5)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool flag6 = other.accountId_ != null;
				if (flag6)
				{
					bool flag7 = this.accountId_ == null;
					if (flag7)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool flag8 = other.host_ != null;
				if (flag8)
				{
					bool flag9 = this.host_ == null;
					if (flag9)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x002273CD File Offset: 0x002255CD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x002273D8 File Offset: 0x002255D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 26U)
						{
							goto IL_002F;
						}
						bool flag = this.gameAccountId_ == null;
						if (flag)
						{
							this.GameAccountId = new EntityId();
						}
						input.ReadMessage(this.GameAccountId);
					}
					else
					{
						bool flag2 = this.id_ == null;
						if (flag2)
						{
							this.Id = new EntityId();
						}
						input.ReadMessage(this.Id);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						goto IL_002F;
					}
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					input.ReadMessage(this.Host);
				}
				else
				{
					bool flag4 = this.accountId_ == null;
					if (flag4)
					{
						this.AccountId = new EntityId();
					}
					input.ReadMessage(this.AccountId);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400401C RID: 16412
		private static readonly MessageParser<PresenceChannelCreatedRequest> _parser = new MessageParser<PresenceChannelCreatedRequest>(() => new PresenceChannelCreatedRequest());

		// Token: 0x0400401D RID: 16413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400401E RID: 16414
		public const int IdFieldNumber = 1;

		// Token: 0x0400401F RID: 16415
		private EntityId id_;

		// Token: 0x04004020 RID: 16416
		public const int GameAccountIdFieldNumber = 3;

		// Token: 0x04004021 RID: 16417
		private EntityId gameAccountId_;

		// Token: 0x04004022 RID: 16418
		public const int AccountIdFieldNumber = 4;

		// Token: 0x04004023 RID: 16419
		private EntityId accountId_;

		// Token: 0x04004024 RID: 16420
		public const int HostFieldNumber = 5;

		// Token: 0x04004025 RID: 16421
		private ProcessId host_;
	}
}
