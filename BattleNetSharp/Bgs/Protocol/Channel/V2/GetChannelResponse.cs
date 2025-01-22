using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200065F RID: 1631
	public sealed class GetChannelResponse : IMessage<GetChannelResponse>, IMessage, IEquatable<GetChannelResponse>, IDeepCloneable<GetChannelResponse>, IBufferMessage
	{
		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x06009776 RID: 38774 RVA: 0x0024B2D0 File Offset: 0x002494D0
		[DebuggerNonUserCode]
		public static MessageParser<GetChannelResponse> Parser
		{
			get
			{
				return GetChannelResponse._parser;
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x06009777 RID: 38775 RVA: 0x0024B2E8 File Offset: 0x002494E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x06009778 RID: 38776 RVA: 0x0024B30C File Offset: 0x0024950C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChannelResponse.Descriptor;
			}
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0024B323 File Offset: 0x00249523
		[DebuggerNonUserCode]
		public GetChannelResponse()
		{
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x0024B32D File Offset: 0x0024952D
		[DebuggerNonUserCode]
		public GetChannelResponse(GetChannelResponse other)
			: this()
		{
			this.channel_ = ((other.channel_ != null) ? other.channel_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x0024B364 File Offset: 0x00249564
		[DebuggerNonUserCode]
		public GetChannelResponse Clone()
		{
			return new GetChannelResponse(this);
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x0024B37C File Offset: 0x0024957C
		// (set) Token: 0x0600977D RID: 38781 RVA: 0x0024B394 File Offset: 0x00249594
		[DebuggerNonUserCode]
		public Channel Channel
		{
			get
			{
				return this.channel_;
			}
			set
			{
				this.channel_ = value;
			}
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x0024B3A0 File Offset: 0x002495A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChannelResponse);
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x0024B3C0 File Offset: 0x002495C0
		[DebuggerNonUserCode]
		public bool Equals(GetChannelResponse other)
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
					bool flag4 = !object.Equals(this.Channel, other.Channel);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x0024B41C File Offset: 0x0024961C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channel_ != null;
			if (flag)
			{
				num ^= this.Channel.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009781 RID: 38785 RVA: 0x0024B46C File Offset: 0x0024966C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x0024B484 File Offset: 0x00249684
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009783 RID: 38787 RVA: 0x0024B490 File Offset: 0x00249690
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channel_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Channel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0024B4E0 File Offset: 0x002496E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channel_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Channel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0024B534 File Offset: 0x00249734
		[DebuggerNonUserCode]
		public void MergeFrom(GetChannelResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channel_ != null;
				if (flag2)
				{
					bool flag3 = this.channel_ == null;
					if (flag3)
					{
						this.Channel = new Channel();
					}
					this.Channel.MergeFrom(other.Channel);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0024B5A0 File Offset: 0x002497A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0024B5AC File Offset: 0x002497AC
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
					bool flag = this.channel_ == null;
					if (flag)
					{
						this.Channel = new Channel();
					}
					input.ReadMessage(this.Channel);
				}
			}
		}

		// Token: 0x04004452 RID: 17490
		private static readonly MessageParser<GetChannelResponse> _parser = new MessageParser<GetChannelResponse>(() => new GetChannelResponse());

		// Token: 0x04004453 RID: 17491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004454 RID: 17492
		public const int ChannelFieldNumber = 1;

		// Token: 0x04004455 RID: 17493
		private Channel channel_;
	}
}
