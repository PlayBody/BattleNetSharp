using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FE RID: 1790
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600A496 RID: 42134 RVA: 0x00281AB8 File Offset: 0x0027FCB8
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600A497 RID: 42135 RVA: 0x00281AD0 File Offset: 0x0027FCD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600A498 RID: 42136 RVA: 0x00281AF4 File Offset: 0x0027FCF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x00281B0B File Offset: 0x0027FD0B
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x00281B15 File Offset: 0x0027FD15
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x00281B4C File Offset: 0x0027FD4C
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600A49C RID: 42140 RVA: 0x00281B64 File Offset: 0x0027FD64
		// (set) Token: 0x0600A49D RID: 42141 RVA: 0x00281B7C File Offset: 0x0027FD7C
		[DebuggerNonUserCode]
		public BlockListState State
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

		// Token: 0x0600A49E RID: 42142 RVA: 0x00281B88 File Offset: 0x0027FD88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00281BA8 File Offset: 0x0027FDA8
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x00281C04 File Offset: 0x0027FE04
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

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x00281C54 File Offset: 0x0027FE54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x00281C6C File Offset: 0x0027FE6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x00281C78 File Offset: 0x0027FE78
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

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x00281CC8 File Offset: 0x0027FEC8
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

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x00281D1C File Offset: 0x0027FF1C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
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
						this.State = new BlockListState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x00281D88 File Offset: 0x0027FF88
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x00281D94 File Offset: 0x0027FF94
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
						this.State = new BlockListState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x04004A27 RID: 18983
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04004A28 RID: 18984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A29 RID: 18985
		public const int StateFieldNumber = 1;

		// Token: 0x04004A2A RID: 18986
		private BlockListState state_;
	}
}
