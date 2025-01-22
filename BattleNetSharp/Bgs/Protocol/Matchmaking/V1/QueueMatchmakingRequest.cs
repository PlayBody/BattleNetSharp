using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F4 RID: 1012
	public sealed class QueueMatchmakingRequest : IMessage<QueueMatchmakingRequest>, IMessage, IEquatable<QueueMatchmakingRequest>, IDeepCloneable<QueueMatchmakingRequest>, IBufferMessage
	{
		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600647D RID: 25725 RVA: 0x00184A60 File Offset: 0x00182C60
		[DebuggerNonUserCode]
		public static MessageParser<QueueMatchmakingRequest> Parser
		{
			get
			{
				return QueueMatchmakingRequest._parser;
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600647E RID: 25726 RVA: 0x00184A78 File Offset: 0x00182C78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x00184A9C File Offset: 0x00182C9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueMatchmakingRequest.Descriptor;
			}
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00184AB3 File Offset: 0x00182CB3
		[DebuggerNonUserCode]
		public QueueMatchmakingRequest()
		{
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00184ABD File Offset: 0x00182CBD
		[DebuggerNonUserCode]
		public QueueMatchmakingRequest(QueueMatchmakingRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00184AF4 File Offset: 0x00182CF4
		[DebuggerNonUserCode]
		public QueueMatchmakingRequest Clone()
		{
			return new QueueMatchmakingRequest(this);
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06006483 RID: 25731 RVA: 0x00184B0C File Offset: 0x00182D0C
		// (set) Token: 0x06006484 RID: 25732 RVA: 0x00184B24 File Offset: 0x00182D24
		[DebuggerNonUserCode]
		public GameMatchmakingOptions Options
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

		// Token: 0x06006485 RID: 25733 RVA: 0x00184B30 File Offset: 0x00182D30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueMatchmakingRequest);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00184B50 File Offset: 0x00182D50
		[DebuggerNonUserCode]
		public bool Equals(QueueMatchmakingRequest other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00184BAC File Offset: 0x00182DAC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00184BFC File Offset: 0x00182DFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00184C14 File Offset: 0x00182E14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00184C20 File Offset: 0x00182E20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00184C70 File Offset: 0x00182E70
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00184CC4 File Offset: 0x00182EC4
		[DebuggerNonUserCode]
		public void MergeFrom(QueueMatchmakingRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new GameMatchmakingOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00184D30 File Offset: 0x00182F30
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00184D3C File Offset: 0x00182F3C
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
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new GameMatchmakingOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x04002DC6 RID: 11718
		private static readonly MessageParser<QueueMatchmakingRequest> _parser = new MessageParser<QueueMatchmakingRequest>(() => new QueueMatchmakingRequest());

		// Token: 0x04002DC7 RID: 11719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC8 RID: 11720
		public const int OptionsFieldNumber = 1;

		// Token: 0x04002DC9 RID: 11721
		private GameMatchmakingOptions options_;
	}
}
