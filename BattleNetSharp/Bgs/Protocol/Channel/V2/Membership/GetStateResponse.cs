using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006AE RID: 1710
	public sealed class GetStateResponse : IMessage<GetStateResponse>, IMessage, IEquatable<GetStateResponse>, IDeepCloneable<GetStateResponse>, IBufferMessage
	{
		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06009E5D RID: 40541 RVA: 0x00268170 File Offset: 0x00266370
		[DebuggerNonUserCode]
		public static MessageParser<GetStateResponse> Parser
		{
			get
			{
				return GetStateResponse._parser;
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06009E5E RID: 40542 RVA: 0x00268188 File Offset: 0x00266388
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06009E5F RID: 40543 RVA: 0x002681AC File Offset: 0x002663AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateResponse.Descriptor;
			}
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x002681C3 File Offset: 0x002663C3
		[DebuggerNonUserCode]
		public GetStateResponse()
		{
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x002681CD File Offset: 0x002663CD
		[DebuggerNonUserCode]
		public GetStateResponse(GetStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x00268204 File Offset: 0x00266404
		[DebuggerNonUserCode]
		public GetStateResponse Clone()
		{
			return new GetStateResponse(this);
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06009E63 RID: 40547 RVA: 0x0026821C File Offset: 0x0026641C
		// (set) Token: 0x06009E64 RID: 40548 RVA: 0x00268234 File Offset: 0x00266434
		[DebuggerNonUserCode]
		public ChannelMembershipState State
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

		// Token: 0x06009E65 RID: 40549 RVA: 0x00268240 File Offset: 0x00266440
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateResponse);
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x00268260 File Offset: 0x00266460
		[DebuggerNonUserCode]
		public bool Equals(GetStateResponse other)
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

		// Token: 0x06009E67 RID: 40551 RVA: 0x002682BC File Offset: 0x002664BC
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

		// Token: 0x06009E68 RID: 40552 RVA: 0x0026830C File Offset: 0x0026650C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x00268324 File Offset: 0x00266524
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x00268330 File Offset: 0x00266530
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

		// Token: 0x06009E6B RID: 40555 RVA: 0x00268380 File Offset: 0x00266580
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

		// Token: 0x06009E6C RID: 40556 RVA: 0x002683D4 File Offset: 0x002665D4
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateResponse other)
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
						this.State = new ChannelMembershipState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x00268440 File Offset: 0x00266640
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x0026844C File Offset: 0x0026664C
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
						this.State = new ChannelMembershipState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x0400476C RID: 18284
		private static readonly MessageParser<GetStateResponse> _parser = new MessageParser<GetStateResponse>(() => new GetStateResponse());

		// Token: 0x0400476D RID: 18285
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400476E RID: 18286
		public const int StateFieldNumber = 1;

		// Token: 0x0400476F RID: 18287
		private ChannelMembershipState state_;
	}
}
