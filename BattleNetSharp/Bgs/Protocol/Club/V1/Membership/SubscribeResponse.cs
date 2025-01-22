using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051A RID: 1306
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06007F0C RID: 32524 RVA: 0x001EF098 File Offset: 0x001ED298
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06007F0D RID: 32525 RVA: 0x001EF0B0 File Offset: 0x001ED2B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06007F0E RID: 32526 RVA: 0x001EF0D4 File Offset: 0x001ED2D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x001EF0EB File Offset: 0x001ED2EB
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x001EF0F5 File Offset: 0x001ED2F5
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x001EF12C File Offset: 0x001ED32C
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06007F12 RID: 32530 RVA: 0x001EF144 File Offset: 0x001ED344
		// (set) Token: 0x06007F13 RID: 32531 RVA: 0x001EF15C File Offset: 0x001ED35C
		[DebuggerNonUserCode]
		public ClubMembershipState State
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

		// Token: 0x06007F14 RID: 32532 RVA: 0x001EF168 File Offset: 0x001ED368
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x001EF188 File Offset: 0x001ED388
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

		// Token: 0x06007F16 RID: 32534 RVA: 0x001EF1E4 File Offset: 0x001ED3E4
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

		// Token: 0x06007F17 RID: 32535 RVA: 0x001EF234 File Offset: 0x001ED434
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x001EF24C File Offset: 0x001ED44C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x001EF258 File Offset: 0x001ED458
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

		// Token: 0x06007F1A RID: 32538 RVA: 0x001EF2A8 File Offset: 0x001ED4A8
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

		// Token: 0x06007F1B RID: 32539 RVA: 0x001EF2FC File Offset: 0x001ED4FC
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
						this.State = new ClubMembershipState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x001EF368 File Offset: 0x001ED568
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x001EF374 File Offset: 0x001ED574
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
						this.State = new ClubMembershipState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x040039C2 RID: 14786
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x040039C3 RID: 14787
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C4 RID: 14788
		public const int StateFieldNumber = 1;

		// Token: 0x040039C5 RID: 14789
		private ClubMembershipState state_;
	}
}
