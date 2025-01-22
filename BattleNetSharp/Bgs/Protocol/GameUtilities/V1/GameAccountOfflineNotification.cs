using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E8 RID: 1512
	public sealed class GameAccountOfflineNotification : IMessage<GameAccountOfflineNotification>, IMessage, IEquatable<GameAccountOfflineNotification>, IDeepCloneable<GameAccountOfflineNotification>, IBufferMessage
	{
		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x0022820C File Offset: 0x0022640C
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountOfflineNotification> Parser
		{
			get
			{
				return GameAccountOfflineNotification._parser;
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00228224 File Offset: 0x00226424
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x06008E2F RID: 36399 RVA: 0x00228248 File Offset: 0x00226448
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountOfflineNotification.Descriptor;
			}
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x0022825F File Offset: 0x0022645F
		[DebuggerNonUserCode]
		public GameAccountOfflineNotification()
		{
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x0022826C File Offset: 0x0022646C
		[DebuggerNonUserCode]
		public GameAccountOfflineNotification(GameAccountOfflineNotification other)
			: this()
		{
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x002282D8 File Offset: 0x002264D8
		[DebuggerNonUserCode]
		public GameAccountOfflineNotification Clone()
		{
			return new GameAccountOfflineNotification(this);
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x002282F0 File Offset: 0x002264F0
		// (set) Token: 0x06008E34 RID: 36404 RVA: 0x00228308 File Offset: 0x00226508
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

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x06008E35 RID: 36405 RVA: 0x00228314 File Offset: 0x00226514
		// (set) Token: 0x06008E36 RID: 36406 RVA: 0x0022832C File Offset: 0x0022652C
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

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x00228338 File Offset: 0x00226538
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x00228359 File Offset: 0x00226559
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? GameAccountOfflineNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00228370 File Offset: 0x00226570
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x0022838B File Offset: 0x0022658B
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x00228398 File Offset: 0x00226598
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountOfflineNotification);
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x002283B8 File Offset: 0x002265B8
		[DebuggerNonUserCode]
		public bool Equals(GameAccountOfflineNotification other)
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

		// Token: 0x06008E3D RID: 36413 RVA: 0x0022844C File Offset: 0x0022664C
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

		// Token: 0x06008E3E RID: 36414 RVA: 0x002284D0 File Offset: 0x002266D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x002284E8 File Offset: 0x002266E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x002284F4 File Offset: 0x002266F4
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

		// Token: 0x06008E41 RID: 36417 RVA: 0x0022858C File Offset: 0x0022678C
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

		// Token: 0x06008E42 RID: 36418 RVA: 0x0022861C File Offset: 0x0022681C
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountOfflineNotification other)
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

		// Token: 0x06008E43 RID: 36419 RVA: 0x002286E4 File Offset: 0x002268E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x002286F0 File Offset: 0x002268F0
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

		// Token: 0x0400403B RID: 16443
		private static readonly MessageParser<GameAccountOfflineNotification> _parser = new MessageParser<GameAccountOfflineNotification>(() => new GameAccountOfflineNotification());

		// Token: 0x0400403C RID: 16444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400403D RID: 16445
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x0400403E RID: 16446
		private EntityId gameAccountId_;

		// Token: 0x0400403F RID: 16447
		public const int HostFieldNumber = 2;

		// Token: 0x04004040 RID: 16448
		private ProcessId host_;

		// Token: 0x04004041 RID: 16449
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04004042 RID: 16450
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04004043 RID: 16451
		private string sessionId_;
	}
}
