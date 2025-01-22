using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E7 RID: 1511
	public sealed class GameAccountOnlineNotification : IMessage<GameAccountOnlineNotification>, IMessage, IEquatable<GameAccountOnlineNotification>, IDeepCloneable<GameAccountOnlineNotification>, IBufferMessage
	{
		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06008E14 RID: 36372 RVA: 0x00227C44 File Offset: 0x00225E44
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountOnlineNotification> Parser
		{
			get
			{
				return GameAccountOnlineNotification._parser;
			}
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00227C5C File Offset: 0x00225E5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x00227C80 File Offset: 0x00225E80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountOnlineNotification.Descriptor;
			}
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00227C97 File Offset: 0x00225E97
		[DebuggerNonUserCode]
		public GameAccountOnlineNotification()
		{
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00227CA4 File Offset: 0x00225EA4
		[DebuggerNonUserCode]
		public GameAccountOnlineNotification(GameAccountOnlineNotification other)
			: this()
		{
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00227D10 File Offset: 0x00225F10
		[DebuggerNonUserCode]
		public GameAccountOnlineNotification Clone()
		{
			return new GameAccountOnlineNotification(this);
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x00227D28 File Offset: 0x00225F28
		// (set) Token: 0x06008E1B RID: 36379 RVA: 0x00227D40 File Offset: 0x00225F40
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

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x00227D4C File Offset: 0x00225F4C
		// (set) Token: 0x06008E1D RID: 36381 RVA: 0x00227D64 File Offset: 0x00225F64
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

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x06008E1E RID: 36382 RVA: 0x00227D70 File Offset: 0x00225F70
		// (set) Token: 0x06008E1F RID: 36383 RVA: 0x00227D91 File Offset: 0x00225F91
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? GameAccountOnlineNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x06008E20 RID: 36384 RVA: 0x00227DA8 File Offset: 0x00225FA8
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x00227DC3 File Offset: 0x00225FC3
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x00227DD0 File Offset: 0x00225FD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountOnlineNotification);
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00227DF0 File Offset: 0x00225FF0
		[DebuggerNonUserCode]
		public bool Equals(GameAccountOnlineNotification other)
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
					bool flag4 = !object.Equals(this.GameAccountId, other.GameAccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Host, other.Host);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionId != other.SessionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x00227E84 File Offset: 0x00226084
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag2 = this.host_ != null;
			if (flag2)
			{
				num ^= this.Host.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x00227F08 File Offset: 0x00226108
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x00227F20 File Offset: 0x00226120
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E27 RID: 36391 RVA: 0x00227F2C File Offset: 0x0022612C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag2 = this.host_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Host);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x00227FC4 File Offset: 0x002261C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag2 = this.host_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x00228054 File Offset: 0x00226254
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountOnlineNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccountId_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountId_ == null;
					if (flag3)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool flag4 = other.host_ != null;
				if (flag4)
				{
					bool flag5 = this.host_ == null;
					if (flag5)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x0022811C File Offset: 0x0022631C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x00228128 File Offset: 0x00226328
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
							this.SessionId = input.ReadString();
						}
					}
					else
					{
						bool flag = this.host_ == null;
						if (flag)
						{
							this.Host = new ProcessId();
						}
						input.ReadMessage(this.Host);
					}
				}
				else
				{
					bool flag2 = this.gameAccountId_ == null;
					if (flag2)
					{
						this.GameAccountId = new EntityId();
					}
					input.ReadMessage(this.GameAccountId);
				}
			}
		}

		// Token: 0x04004032 RID: 16434
		private static readonly MessageParser<GameAccountOnlineNotification> _parser = new MessageParser<GameAccountOnlineNotification>(() => new GameAccountOnlineNotification());

		// Token: 0x04004033 RID: 16435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004034 RID: 16436
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04004035 RID: 16437
		private EntityId gameAccountId_;

		// Token: 0x04004036 RID: 16438
		public const int HostFieldNumber = 2;

		// Token: 0x04004037 RID: 16439
		private ProcessId host_;

		// Token: 0x04004038 RID: 16440
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04004039 RID: 16441
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x0400403A RID: 16442
		private string sessionId_;
	}
}
