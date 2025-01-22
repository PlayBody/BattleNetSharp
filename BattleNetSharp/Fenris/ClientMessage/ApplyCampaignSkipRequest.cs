using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000229 RID: 553
	public sealed class ApplyCampaignSkipRequest : IMessage<ApplyCampaignSkipRequest>, IMessage, IEquatable<ApplyCampaignSkipRequest>, IDeepCloneable<ApplyCampaignSkipRequest>, IBufferMessage
	{
		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x000EEBA4 File Offset: 0x000ECDA4
		[DebuggerNonUserCode]
		public static MessageParser<ApplyCampaignSkipRequest> Parser
		{
			get
			{
				return ApplyCampaignSkipRequest._parser;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x000EEBBC File Offset: 0x000ECDBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x000EEBE0 File Offset: 0x000ECDE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyCampaignSkipRequest.Descriptor;
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x000EEBF7 File Offset: 0x000ECDF7
		[DebuggerNonUserCode]
		public ApplyCampaignSkipRequest()
		{
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x000EEC01 File Offset: 0x000ECE01
		[DebuggerNonUserCode]
		public ApplyCampaignSkipRequest(ApplyCampaignSkipRequest other)
			: this()
		{
			this.heroId_ = other.heroId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x000EEC28 File Offset: 0x000ECE28
		[DebuggerNonUserCode]
		public ApplyCampaignSkipRequest Clone()
		{
			return new ApplyCampaignSkipRequest(this);
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x000EEC40 File Offset: 0x000ECE40
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x000EEC61 File Offset: 0x000ECE61
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? ApplyCampaignSkipRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x000EEC78 File Offset: 0x000ECE78
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x000EEC93 File Offset: 0x000ECE93
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x000EECA0 File Offset: 0x000ECEA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyCampaignSkipRequest);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x000EECC0 File Offset: 0x000ECEC0
		[DebuggerNonUserCode]
		public bool Equals(ApplyCampaignSkipRequest other)
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
					bool flag4 = this.HeroId != other.HeroId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x000EED18 File Offset: 0x000ECF18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x000EED64 File Offset: 0x000ECF64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x000EED7C File Offset: 0x000ECF7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x000EED88 File Offset: 0x000ECF88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x000EEDD4 File Offset: 0x000ECFD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x000EEE24 File Offset: 0x000ED024
		[DebuggerNonUserCode]
		public void MergeFrom(ApplyCampaignSkipRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000EEE6D File Offset: 0x000ED06D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x000EEE78 File Offset: 0x000ED078
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
					this.HeroId = input.ReadString();
				}
			}
		}

		// Token: 0x04001BD3 RID: 7123
		private static readonly MessageParser<ApplyCampaignSkipRequest> _parser = new MessageParser<ApplyCampaignSkipRequest>(() => new ApplyCampaignSkipRequest());

		// Token: 0x04001BD4 RID: 7124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BD5 RID: 7125
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001BD6 RID: 7126
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001BD7 RID: 7127
		private string heroId_;
	}
}
