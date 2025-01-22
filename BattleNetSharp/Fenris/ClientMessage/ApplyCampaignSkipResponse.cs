using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022A RID: 554
	public sealed class ApplyCampaignSkipResponse : IMessage<ApplyCampaignSkipResponse>, IMessage, IEquatable<ApplyCampaignSkipResponse>, IDeepCloneable<ApplyCampaignSkipResponse>, IBufferMessage
	{
		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x000EEEF0 File Offset: 0x000ED0F0
		[DebuggerNonUserCode]
		public static MessageParser<ApplyCampaignSkipResponse> Parser
		{
			get
			{
				return ApplyCampaignSkipResponse._parser;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x000EEF08 File Offset: 0x000ED108
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x000EEF2C File Offset: 0x000ED12C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyCampaignSkipResponse.Descriptor;
			}
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x000EEF43 File Offset: 0x000ED143
		[DebuggerNonUserCode]
		public ApplyCampaignSkipResponse()
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x000EEF4D File Offset: 0x000ED14D
		[DebuggerNonUserCode]
		public ApplyCampaignSkipResponse(ApplyCampaignSkipResponse other)
			: this()
		{
			this.digest_ = ((other.digest_ != null) ? other.digest_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x000EEF84 File Offset: 0x000ED184
		[DebuggerNonUserCode]
		public ApplyCampaignSkipResponse Clone()
		{
			return new ApplyCampaignSkipResponse(this);
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x000EEF9C File Offset: 0x000ED19C
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x000EEFB4 File Offset: 0x000ED1B4
		[DebuggerNonUserCode]
		public Digest Digest
		{
			get
			{
				return this.digest_;
			}
			set
			{
				this.digest_ = value;
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x000EEFC0 File Offset: 0x000ED1C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyCampaignSkipResponse);
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x000EEFE0 File Offset: 0x000ED1E0
		[DebuggerNonUserCode]
		public bool Equals(ApplyCampaignSkipResponse other)
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
					bool flag4 = !object.Equals(this.Digest, other.Digest);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x000EF03C File Offset: 0x000ED23C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.digest_ != null;
			if (flag)
			{
				num ^= this.Digest.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x000EF08C File Offset: 0x000ED28C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000EF0A4 File Offset: 0x000ED2A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x000EF0B0 File Offset: 0x000ED2B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.digest_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Digest);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x000EF100 File Offset: 0x000ED300
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.digest_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Digest);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000EF154 File Offset: 0x000ED354
		[DebuggerNonUserCode]
		public void MergeFrom(ApplyCampaignSkipResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.digest_ != null;
				if (flag2)
				{
					bool flag3 = this.digest_ == null;
					if (flag3)
					{
						this.Digest = new Digest();
					}
					this.Digest.MergeFrom(other.Digest);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x000EF1C0 File Offset: 0x000ED3C0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000EF1CC File Offset: 0x000ED3CC
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
					bool flag = this.digest_ == null;
					if (flag)
					{
						this.Digest = new Digest();
					}
					input.ReadMessage(this.Digest);
				}
			}
		}

		// Token: 0x04001BD8 RID: 7128
		private static readonly MessageParser<ApplyCampaignSkipResponse> _parser = new MessageParser<ApplyCampaignSkipResponse>(() => new ApplyCampaignSkipResponse());

		// Token: 0x04001BD9 RID: 7129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BDA RID: 7130
		public const int DigestFieldNumber = 1;

		// Token: 0x04001BDB RID: 7131
		private Digest digest_;
	}
}
