using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000237 RID: 567
	public sealed class GetHeroProfileRequest : IMessage<GetHeroProfileRequest>, IMessage, IEquatable<GetHeroProfileRequest>, IDeepCloneable<GetHeroProfileRequest>, IBufferMessage
	{
		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x000F26C8 File Offset: 0x000F08C8
		[DebuggerNonUserCode]
		public static MessageParser<GetHeroProfileRequest> Parser
		{
			get
			{
				return GetHeroProfileRequest._parser;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x000F26E0 File Offset: 0x000F08E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[39];
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x000F2704 File Offset: 0x000F0904
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeroProfileRequest.Descriptor;
			}
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x000F271B File Offset: 0x000F091B
		[DebuggerNonUserCode]
		public GetHeroProfileRequest()
		{
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x000F2725 File Offset: 0x000F0925
		[DebuggerNonUserCode]
		public GetHeroProfileRequest(GetHeroProfileRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this.heroId_ = other.heroId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x000F2764 File Offset: 0x000F0964
		[DebuggerNonUserCode]
		public GetHeroProfileRequest Clone()
		{
			return new GetHeroProfileRequest(this);
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x000F277C File Offset: 0x000F097C
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x000F27AD File Offset: 0x000F09AD
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = GetHeroProfileRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x000F27C8 File Offset: 0x000F09C8
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x000F27E5 File Offset: 0x000F09E5
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x000F27F8 File Offset: 0x000F09F8
		// (set) Token: 0x06003D61 RID: 15713 RVA: 0x000F2819 File Offset: 0x000F0A19
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? GetHeroProfileRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x000F2830 File Offset: 0x000F0A30
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x000F284B File Offset: 0x000F0A4B
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x000F2858 File Offset: 0x000F0A58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeroProfileRequest);
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x000F2878 File Offset: 0x000F0A78
		[DebuggerNonUserCode]
		public bool Equals(GetHeroProfileRequest other)
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
					bool flag4 = this.TargetGameAccountId != other.TargetGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HeroId != other.HeroId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x000F28EC File Offset: 0x000F0AEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
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

		// Token: 0x06003D67 RID: 15719 RVA: 0x000F2958 File Offset: 0x000F0B58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x000F2970 File Offset: 0x000F0B70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x000F297C File Offset: 0x000F0B7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.HeroId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x000F29EC File Offset: 0x000F0BEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
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

		// Token: 0x06003D6B RID: 15723 RVA: 0x000F2A58 File Offset: 0x000F0C58
		[DebuggerNonUserCode]
		public void MergeFrom(GetHeroProfileRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x000F2ABA File Offset: 0x000F0CBA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x000F2AC8 File Offset: 0x000F0CC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HeroId = input.ReadString();
					}
				}
				else
				{
					this.TargetGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C36 RID: 7222
		private static readonly MessageParser<GetHeroProfileRequest> _parser = new MessageParser<GetHeroProfileRequest>(() => new GetHeroProfileRequest());

		// Token: 0x04001C37 RID: 7223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C38 RID: 7224
		private int _hasBits0;

		// Token: 0x04001C39 RID: 7225
		public const int TargetGameAccountIdFieldNumber = 1;

		// Token: 0x04001C3A RID: 7226
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001C3B RID: 7227
		private uint targetGameAccountId_;

		// Token: 0x04001C3C RID: 7228
		public const int HeroIdFieldNumber = 2;

		// Token: 0x04001C3D RID: 7229
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001C3E RID: 7230
		private string heroId_;
	}
}
