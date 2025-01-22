using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000295 RID: 661
	public sealed class DeleteFallenHeroRequest : IMessage<DeleteFallenHeroRequest>, IMessage, IEquatable<DeleteFallenHeroRequest>, IDeepCloneable<DeleteFallenHeroRequest>, IBufferMessage
	{
		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x0010CB9C File Offset: 0x0010AD9C
		[DebuggerNonUserCode]
		public static MessageParser<DeleteFallenHeroRequest> Parser
		{
			get
			{
				return DeleteFallenHeroRequest._parser;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x0010CBB4 File Offset: 0x0010ADB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[133];
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x0010CBDC File Offset: 0x0010ADDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteFallenHeroRequest.Descriptor;
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x0010CBF3 File Offset: 0x0010ADF3
		[DebuggerNonUserCode]
		public DeleteFallenHeroRequest()
		{
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x0010CBFD File Offset: 0x0010ADFD
		[DebuggerNonUserCode]
		public DeleteFallenHeroRequest(DeleteFallenHeroRequest other)
			: this()
		{
			this.heroId_ = other.heroId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x0010CC24 File Offset: 0x0010AE24
		[DebuggerNonUserCode]
		public DeleteFallenHeroRequest Clone()
		{
			return new DeleteFallenHeroRequest(this);
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x0010CC3C File Offset: 0x0010AE3C
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x0010CC5D File Offset: 0x0010AE5D
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? DeleteFallenHeroRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x0010CC74 File Offset: 0x0010AE74
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x0010CC8F File Offset: 0x0010AE8F
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x0010CC9C File Offset: 0x0010AE9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteFallenHeroRequest);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x0010CCBC File Offset: 0x0010AEBC
		[DebuggerNonUserCode]
		public bool Equals(DeleteFallenHeroRequest other)
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

		// Token: 0x06004625 RID: 17957 RVA: 0x0010CD14 File Offset: 0x0010AF14
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

		// Token: 0x06004626 RID: 17958 RVA: 0x0010CD60 File Offset: 0x0010AF60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x0010CD78 File Offset: 0x0010AF78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0010CD84 File Offset: 0x0010AF84
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

		// Token: 0x06004629 RID: 17961 RVA: 0x0010CDD0 File Offset: 0x0010AFD0
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

		// Token: 0x0600462A RID: 17962 RVA: 0x0010CE20 File Offset: 0x0010B020
		[DebuggerNonUserCode]
		public void MergeFrom(DeleteFallenHeroRequest other)
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

		// Token: 0x0600462B RID: 17963 RVA: 0x0010CE69 File Offset: 0x0010B069
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0010CE74 File Offset: 0x0010B074
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

		// Token: 0x04001F3A RID: 7994
		private static readonly MessageParser<DeleteFallenHeroRequest> _parser = new MessageParser<DeleteFallenHeroRequest>(() => new DeleteFallenHeroRequest());

		// Token: 0x04001F3B RID: 7995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F3C RID: 7996
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001F3D RID: 7997
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001F3E RID: 7998
		private string heroId_;
	}
}
