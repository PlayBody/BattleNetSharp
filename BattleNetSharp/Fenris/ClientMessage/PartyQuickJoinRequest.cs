using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024B RID: 587
	public sealed class PartyQuickJoinRequest : IMessage<PartyQuickJoinRequest>, IMessage, IEquatable<PartyQuickJoinRequest>, IDeepCloneable<PartyQuickJoinRequest>, IBufferMessage
	{
		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x000F789C File Offset: 0x000F5A9C
		[DebuggerNonUserCode]
		public static MessageParser<PartyQuickJoinRequest> Parser
		{
			get
			{
				return PartyQuickJoinRequest._parser;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x000F78B4 File Offset: 0x000F5AB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[59];
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x000F78D8 File Offset: 0x000F5AD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyQuickJoinRequest.Descriptor;
			}
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x000F78EF File Offset: 0x000F5AEF
		[DebuggerNonUserCode]
		public PartyQuickJoinRequest()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x000F78F9 File Offset: 0x000F5AF9
		[DebuggerNonUserCode]
		public PartyQuickJoinRequest(PartyQuickJoinRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesteeGameAccountId_ = other.requesteeGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x000F792C File Offset: 0x000F5B2C
		[DebuggerNonUserCode]
		public PartyQuickJoinRequest Clone()
		{
			return new PartyQuickJoinRequest(this);
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x000F7944 File Offset: 0x000F5B44
		// (set) Token: 0x06003F27 RID: 16167 RVA: 0x000F7975 File Offset: 0x000F5B75
		[DebuggerNonUserCode]
		public uint RequesteeGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint requesteeGameAccountIdDefaultValue;
				if (flag)
				{
					requesteeGameAccountIdDefaultValue = this.requesteeGameAccountId_;
				}
				else
				{
					requesteeGameAccountIdDefaultValue = PartyQuickJoinRequest.RequesteeGameAccountIdDefaultValue;
				}
				return requesteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesteeGameAccountId_ = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x000F7990 File Offset: 0x000F5B90
		[DebuggerNonUserCode]
		public bool HasRequesteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x000F79AD File Offset: 0x000F5BAD
		[DebuggerNonUserCode]
		public void ClearRequesteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x000F79C0 File Offset: 0x000F5BC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyQuickJoinRequest);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x000F79E0 File Offset: 0x000F5BE0
		[DebuggerNonUserCode]
		public bool Equals(PartyQuickJoinRequest other)
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
					bool flag4 = this.RequesteeGameAccountId != other.RequesteeGameAccountId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x000F7A38 File Offset: 0x000F5C38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num ^= this.RequesteeGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x000F7A88 File Offset: 0x000F5C88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x000F7AA0 File Offset: 0x000F5CA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000F7AAC File Offset: 0x000F5CAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RequesteeGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x000F7AF8 File Offset: 0x000F5CF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesteeGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000F7B48 File Offset: 0x000F5D48
		[DebuggerNonUserCode]
		public void MergeFrom(PartyQuickJoinRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequesteeGameAccountId = other.HasRequesteeGameAccountId;
				if (hasRequesteeGameAccountId)
				{
					this.RequesteeGameAccountId = other.RequesteeGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x000F7B91 File Offset: 0x000F5D91
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000F7B9C File Offset: 0x000F5D9C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RequesteeGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CC7 RID: 7367
		private static readonly MessageParser<PartyQuickJoinRequest> _parser = new MessageParser<PartyQuickJoinRequest>(() => new PartyQuickJoinRequest());

		// Token: 0x04001CC8 RID: 7368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CC9 RID: 7369
		private int _hasBits0;

		// Token: 0x04001CCA RID: 7370
		public const int RequesteeGameAccountIdFieldNumber = 1;

		// Token: 0x04001CCB RID: 7371
		private static readonly uint RequesteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CCC RID: 7372
		private uint requesteeGameAccountId_;
	}
}
