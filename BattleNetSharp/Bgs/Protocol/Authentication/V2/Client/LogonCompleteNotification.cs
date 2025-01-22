using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x0200061C RID: 1564
	public sealed class LogonCompleteNotification : IMessage<LogonCompleteNotification>, IMessage, IEquatable<LogonCompleteNotification>, IDeepCloneable<LogonCompleteNotification>, IBufferMessage
	{
		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x06009245 RID: 37445 RVA: 0x002372C4 File Offset: 0x002354C4
		[DebuggerNonUserCode]
		public static MessageParser<LogonCompleteNotification> Parser
		{
			get
			{
				return LogonCompleteNotification._parser;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x002372DC File Offset: 0x002354DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x00237300 File Offset: 0x00235500
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonCompleteNotification.Descriptor;
			}
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00237317 File Offset: 0x00235517
		[DebuggerNonUserCode]
		public LogonCompleteNotification()
		{
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00237324 File Offset: 0x00235524
		[DebuggerNonUserCode]
		public LogonCompleteNotification(LogonCompleteNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00237380 File Offset: 0x00235580
		[DebuggerNonUserCode]
		public LogonCompleteNotification Clone()
		{
			return new LogonCompleteNotification(this);
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x00237398 File Offset: 0x00235598
		// (set) Token: 0x0600924C RID: 37452 RVA: 0x002373C9 File Offset: 0x002355C9
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = LogonCompleteNotification.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x002373E4 File Offset: 0x002355E4
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x00237401 File Offset: 0x00235601
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x00237414 File Offset: 0x00235614
		// (set) Token: 0x06009250 RID: 37456 RVA: 0x0023742C File Offset: 0x0023562C
		[DebuggerNonUserCode]
		public LogonRecord Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00237438 File Offset: 0x00235638
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonCompleteNotification);
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00237458 File Offset: 0x00235658
		[DebuggerNonUserCode]
		public bool Equals(LogonCompleteNotification other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Record, other.Record);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x002374CC File Offset: 0x002356CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this.record_ != null;
			if (flag)
			{
				num ^= this.Record.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00237538 File Offset: 0x00235738
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00237550 File Offset: 0x00235750
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x0023755C File Offset: 0x0023575C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this.record_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Record);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x002375CC File Offset: 0x002357CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this.record_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Record);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x0023763C File Offset: 0x0023583C
		[DebuggerNonUserCode]
		public void MergeFrom(LogonCompleteNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool flag2 = other.record_ != null;
				if (flag2)
				{
					bool flag3 = this.record_ == null;
					if (flag3)
					{
						this.Record = new LogonRecord();
					}
					this.Record.MergeFrom(other.Record);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x002376C1 File Offset: 0x002358C1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x002376CC File Offset: 0x002358CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.record_ == null;
						if (flag)
						{
							this.Record = new LogonRecord();
						}
						input.ReadMessage(this.Record);
					}
				}
				else
				{
					this.ErrorCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004214 RID: 16916
		private static readonly MessageParser<LogonCompleteNotification> _parser = new MessageParser<LogonCompleteNotification>(() => new LogonCompleteNotification());

		// Token: 0x04004215 RID: 16917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004216 RID: 16918
		private int _hasBits0;

		// Token: 0x04004217 RID: 16919
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004218 RID: 16920
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04004219 RID: 16921
		private uint errorCode_;

		// Token: 0x0400421A RID: 16922
		public const int RecordFieldNumber = 2;

		// Token: 0x0400421B RID: 16923
		private LogonRecord record_;
	}
}
