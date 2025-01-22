using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x0200061D RID: 1565
	public sealed class LogonQueueUpdateNotification : IMessage<LogonQueueUpdateNotification>, IMessage, IEquatable<LogonQueueUpdateNotification>, IDeepCloneable<LogonQueueUpdateNotification>, IBufferMessage
	{
		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x00237774 File Offset: 0x00235974
		[DebuggerNonUserCode]
		public static MessageParser<LogonQueueUpdateNotification> Parser
		{
			get
			{
				return LogonQueueUpdateNotification._parser;
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600925D RID: 37469 RVA: 0x0023778C File Offset: 0x0023598C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x002377B0 File Offset: 0x002359B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonQueueUpdateNotification.Descriptor;
			}
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x002377C7 File Offset: 0x002359C7
		[DebuggerNonUserCode]
		public LogonQueueUpdateNotification()
		{
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x002377D1 File Offset: 0x002359D1
		[DebuggerNonUserCode]
		public LogonQueueUpdateNotification(LogonQueueUpdateNotification other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x00237808 File Offset: 0x00235A08
		[DebuggerNonUserCode]
		public LogonQueueUpdateNotification Clone()
		{
			return new LogonQueueUpdateNotification(this);
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x06009262 RID: 37474 RVA: 0x00237820 File Offset: 0x00235A20
		// (set) Token: 0x06009263 RID: 37475 RVA: 0x00237838 File Offset: 0x00235A38
		[DebuggerNonUserCode]
		public LogonQueueState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x00237844 File Offset: 0x00235A44
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonQueueUpdateNotification);
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x00237864 File Offset: 0x00235A64
		[DebuggerNonUserCode]
		public bool Equals(LogonQueueUpdateNotification other)
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
					bool flag4 = !object.Equals(this.State, other.State);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x002378C0 File Offset: 0x00235AC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00237910 File Offset: 0x00235B10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00237928 File Offset: 0x00235B28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x00237934 File Offset: 0x00235B34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00237984 File Offset: 0x00235B84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x002379D8 File Offset: 0x00235BD8
		[DebuggerNonUserCode]
		public void MergeFrom(LogonQueueUpdateNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new LogonQueueState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x00237A44 File Offset: 0x00235C44
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x00237A50 File Offset: 0x00235C50
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
					bool flag = this.state_ == null;
					if (flag)
					{
						this.State = new LogonQueueState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x0400421C RID: 16924
		private static readonly MessageParser<LogonQueueUpdateNotification> _parser = new MessageParser<LogonQueueUpdateNotification>(() => new LogonQueueUpdateNotification());

		// Token: 0x0400421D RID: 16925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400421E RID: 16926
		public const int StateFieldNumber = 1;

		// Token: 0x0400421F RID: 16927
		private LogonQueueState state_;
	}
}
