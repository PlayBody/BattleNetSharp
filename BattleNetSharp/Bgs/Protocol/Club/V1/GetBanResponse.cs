using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CC RID: 1228
	public sealed class GetBanResponse : IMessage<GetBanResponse>, IMessage, IEquatable<GetBanResponse>, IDeepCloneable<GetBanResponse>, IBufferMessage
	{
		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x001D0EC0 File Offset: 0x001CF0C0
		[DebuggerNonUserCode]
		public static MessageParser<GetBanResponse> Parser
		{
			get
			{
				return GetBanResponse._parser;
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x001D0ED8 File Offset: 0x001CF0D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[49];
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06007765 RID: 30565 RVA: 0x001D0EFC File Offset: 0x001CF0FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBanResponse.Descriptor;
			}
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x001D0F13 File Offset: 0x001CF113
		[DebuggerNonUserCode]
		public GetBanResponse()
		{
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x001D0F1D File Offset: 0x001CF11D
		[DebuggerNonUserCode]
		public GetBanResponse(GetBanResponse other)
			: this()
		{
			this.ban_ = ((other.ban_ != null) ? other.ban_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x001D0F54 File Offset: 0x001CF154
		[DebuggerNonUserCode]
		public GetBanResponse Clone()
		{
			return new GetBanResponse(this);
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x001D0F6C File Offset: 0x001CF16C
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x001D0F84 File Offset: 0x001CF184
		[DebuggerNonUserCode]
		public ClubBan Ban
		{
			get
			{
				return this.ban_;
			}
			set
			{
				this.ban_ = value;
			}
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x001D0F90 File Offset: 0x001CF190
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBanResponse);
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x001D0FB0 File Offset: 0x001CF1B0
		[DebuggerNonUserCode]
		public bool Equals(GetBanResponse other)
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
					bool flag4 = !object.Equals(this.Ban, other.Ban);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x001D100C File Offset: 0x001CF20C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.ban_ != null;
			if (flag)
			{
				num ^= this.Ban.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x001D105C File Offset: 0x001CF25C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x001D1074 File Offset: 0x001CF274
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x001D1080 File Offset: 0x001CF280
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.ban_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Ban);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x001D10D0 File Offset: 0x001CF2D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.ban_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Ban);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x001D1124 File Offset: 0x001CF324
		[DebuggerNonUserCode]
		public void MergeFrom(GetBanResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.ban_ != null;
				if (flag2)
				{
					bool flag3 = this.ban_ == null;
					if (flag3)
					{
						this.Ban = new ClubBan();
					}
					this.Ban.MergeFrom(other.Ban);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x001D1190 File Offset: 0x001CF390
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x001D119C File Offset: 0x001CF39C
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
					bool flag = this.ban_ == null;
					if (flag)
					{
						this.Ban = new ClubBan();
					}
					input.ReadMessage(this.Ban);
				}
			}
		}

		// Token: 0x04003644 RID: 13892
		private static readonly MessageParser<GetBanResponse> _parser = new MessageParser<GetBanResponse>(() => new GetBanResponse());

		// Token: 0x04003645 RID: 13893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003646 RID: 13894
		public const int BanFieldNumber = 1;

		// Token: 0x04003647 RID: 13895
		private ClubBan ban_;
	}
}
