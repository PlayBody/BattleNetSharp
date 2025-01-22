using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029F RID: 671
	public sealed class RestoreDeletedHeroRequest : IMessage<RestoreDeletedHeroRequest>, IMessage, IEquatable<RestoreDeletedHeroRequest>, IDeepCloneable<RestoreDeletedHeroRequest>, IBufferMessage
	{
		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x0010F418 File Offset: 0x0010D618
		[DebuggerNonUserCode]
		public static MessageParser<RestoreDeletedHeroRequest> Parser
		{
			get
			{
				return RestoreDeletedHeroRequest._parser;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x0010F430 File Offset: 0x0010D630
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[143];
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x0010F458 File Offset: 0x0010D658
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreDeletedHeroRequest.Descriptor;
			}
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x0010F46F File Offset: 0x0010D66F
		[DebuggerNonUserCode]
		public RestoreDeletedHeroRequest()
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0010F479 File Offset: 0x0010D679
		[DebuggerNonUserCode]
		public RestoreDeletedHeroRequest(RestoreDeletedHeroRequest other)
			: this()
		{
			this.heroId_ = other.heroId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0010F4A0 File Offset: 0x0010D6A0
		[DebuggerNonUserCode]
		public RestoreDeletedHeroRequest Clone()
		{
			return new RestoreDeletedHeroRequest(this);
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x0010F4B8 File Offset: 0x0010D6B8
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x0010F4D9 File Offset: 0x0010D6D9
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? RestoreDeletedHeroRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x0010F4F0 File Offset: 0x0010D6F0
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x0010F50B File Offset: 0x0010D70B
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x0010F518 File Offset: 0x0010D718
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreDeletedHeroRequest);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x0010F538 File Offset: 0x0010D738
		[DebuggerNonUserCode]
		public bool Equals(RestoreDeletedHeroRequest other)
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

		// Token: 0x06004707 RID: 18183 RVA: 0x0010F590 File Offset: 0x0010D790
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

		// Token: 0x06004708 RID: 18184 RVA: 0x0010F5DC File Offset: 0x0010D7DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x0010F5F4 File Offset: 0x0010D7F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x0010F600 File Offset: 0x0010D800
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

		// Token: 0x0600470B RID: 18187 RVA: 0x0010F64C File Offset: 0x0010D84C
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

		// Token: 0x0600470C RID: 18188 RVA: 0x0010F69C File Offset: 0x0010D89C
		[DebuggerNonUserCode]
		public void MergeFrom(RestoreDeletedHeroRequest other)
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

		// Token: 0x0600470D RID: 18189 RVA: 0x0010F6E5 File Offset: 0x0010D8E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x0010F6F0 File Offset: 0x0010D8F0
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

		// Token: 0x04001F81 RID: 8065
		private static readonly MessageParser<RestoreDeletedHeroRequest> _parser = new MessageParser<RestoreDeletedHeroRequest>(() => new RestoreDeletedHeroRequest());

		// Token: 0x04001F82 RID: 8066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F83 RID: 8067
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001F84 RID: 8068
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001F85 RID: 8069
		private string heroId_;
	}
}
