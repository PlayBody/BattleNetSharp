using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006AB RID: 1707
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x00267738 File Offset: 0x00265938
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x00267750 File Offset: 0x00265950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x00267774 File Offset: 0x00265974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x0026778B File Offset: 0x0026598B
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x00267795 File Offset: 0x00265995
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x002677CC File Offset: 0x002659CC
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06009E2A RID: 40490 RVA: 0x002677E4 File Offset: 0x002659E4
		// (set) Token: 0x06009E2B RID: 40491 RVA: 0x002677FC File Offset: 0x002659FC
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

		// Token: 0x06009E2C RID: 40492 RVA: 0x00267808 File Offset: 0x00265A08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x00267828 File Offset: 0x00265A28
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

		// Token: 0x06009E2E RID: 40494 RVA: 0x00267884 File Offset: 0x00265A84
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

		// Token: 0x06009E2F RID: 40495 RVA: 0x002678D4 File Offset: 0x00265AD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x002678EC File Offset: 0x00265AEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x002678F8 File Offset: 0x00265AF8
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

		// Token: 0x06009E32 RID: 40498 RVA: 0x00267948 File Offset: 0x00265B48
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

		// Token: 0x06009E33 RID: 40499 RVA: 0x0026799C File Offset: 0x00265B9C
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
						this.State = new ChannelMembershipState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x00267A08 File Offset: 0x00265C08
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x00267A14 File Offset: 0x00265C14
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

		// Token: 0x04004760 RID: 18272
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04004761 RID: 18273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004762 RID: 18274
		public const int StateFieldNumber = 1;

		// Token: 0x04004763 RID: 18275
		private ChannelMembershipState state_;
	}
}
