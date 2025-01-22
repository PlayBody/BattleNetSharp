using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024C RID: 588
	public sealed class RejectPartyQuickJoin : IMessage<RejectPartyQuickJoin>, IMessage, IEquatable<RejectPartyQuickJoin>, IDeepCloneable<RejectPartyQuickJoin>, IBufferMessage
	{
		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x000F7C10 File Offset: 0x000F5E10
		[DebuggerNonUserCode]
		public static MessageParser<RejectPartyQuickJoin> Parser
		{
			get
			{
				return RejectPartyQuickJoin._parser;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x000F7C28 File Offset: 0x000F5E28
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[60];
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x000F7C4C File Offset: 0x000F5E4C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RejectPartyQuickJoin.Descriptor;
			}
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x000F7C63 File Offset: 0x000F5E63
		[DebuggerNonUserCode]
		public RejectPartyQuickJoin()
		{
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x000F7C70 File Offset: 0x000F5E70
		[DebuggerNonUserCode]
		public RejectPartyQuickJoin(RejectPartyQuickJoin other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesteeGameAccountId_ = other.requesteeGameAccountId_;
			this.requesterGameAccountId_ = other.requesterGameAccountId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x000F7CC8 File Offset: 0x000F5EC8
		[DebuggerNonUserCode]
		public RejectPartyQuickJoin Clone()
		{
			return new RejectPartyQuickJoin(this);
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x000F7CE0 File Offset: 0x000F5EE0
		// (set) Token: 0x06003F3C RID: 16188 RVA: 0x000F7D11 File Offset: 0x000F5F11
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
					requesteeGameAccountIdDefaultValue = RejectPartyQuickJoin.RequesteeGameAccountIdDefaultValue;
				}
				return requesteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesteeGameAccountId_ = value;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x000F7D2C File Offset: 0x000F5F2C
		[DebuggerNonUserCode]
		public bool HasRequesteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000F7D49 File Offset: 0x000F5F49
		[DebuggerNonUserCode]
		public void ClearRequesteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06003F3F RID: 16191 RVA: 0x000F7D5C File Offset: 0x000F5F5C
		// (set) Token: 0x06003F40 RID: 16192 RVA: 0x000F7D8D File Offset: 0x000F5F8D
		[DebuggerNonUserCode]
		public uint RequesterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint requesterGameAccountIdDefaultValue;
				if (flag)
				{
					requesterGameAccountIdDefaultValue = this.requesterGameAccountId_;
				}
				else
				{
					requesterGameAccountIdDefaultValue = RejectPartyQuickJoin.RequesterGameAccountIdDefaultValue;
				}
				return requesterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.requesterGameAccountId_ = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x000F7DA8 File Offset: 0x000F5FA8
		[DebuggerNonUserCode]
		public bool HasRequesterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x000F7DC5 File Offset: 0x000F5FC5
		[DebuggerNonUserCode]
		public void ClearRequesterGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x000F7DD8 File Offset: 0x000F5FD8
		// (set) Token: 0x06003F44 RID: 16196 RVA: 0x000F7E09 File Offset: 0x000F6009
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = RejectPartyQuickJoin.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.reason_ = value;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06003F45 RID: 16197 RVA: 0x000F7E24 File Offset: 0x000F6024
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x000F7E41 File Offset: 0x000F6041
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x000F7E54 File Offset: 0x000F6054
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RejectPartyQuickJoin);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000F7E74 File Offset: 0x000F6074
		[DebuggerNonUserCode]
		public bool Equals(RejectPartyQuickJoin other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RequesterGameAccountId != other.RequesterGameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000F7F00 File Offset: 0x000F6100
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num ^= this.RequesteeGameAccountId.GetHashCode();
			}
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num ^= this.RequesterGameAccountId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x000F7F8C File Offset: 0x000F618C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x000F7FA4 File Offset: 0x000F61A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x000F7FB0 File Offset: 0x000F61B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RequesteeGameAccountId);
			}
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RequesterGameAccountId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x000F8040 File Offset: 0x000F6240
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesteeGameAccountId);
			}
			bool hasRequesterGameAccountId = this.HasRequesterGameAccountId;
			if (hasRequesterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesterGameAccountId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x000F80CC File Offset: 0x000F62CC
		[DebuggerNonUserCode]
		public void MergeFrom(RejectPartyQuickJoin other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequesteeGameAccountId = other.HasRequesteeGameAccountId;
				if (hasRequesteeGameAccountId)
				{
					this.RequesteeGameAccountId = other.RequesteeGameAccountId;
				}
				bool hasRequesterGameAccountId = other.HasRequesterGameAccountId;
				if (hasRequesterGameAccountId)
				{
					this.RequesterGameAccountId = other.RequesterGameAccountId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x000F8147 File Offset: 0x000F6347
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x000F8154 File Offset: 0x000F6354
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.RequesterGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.RequesteeGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CCD RID: 7373
		private static readonly MessageParser<RejectPartyQuickJoin> _parser = new MessageParser<RejectPartyQuickJoin>(() => new RejectPartyQuickJoin());

		// Token: 0x04001CCE RID: 7374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CCF RID: 7375
		private int _hasBits0;

		// Token: 0x04001CD0 RID: 7376
		public const int RequesteeGameAccountIdFieldNumber = 1;

		// Token: 0x04001CD1 RID: 7377
		private static readonly uint RequesteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CD2 RID: 7378
		private uint requesteeGameAccountId_;

		// Token: 0x04001CD3 RID: 7379
		public const int RequesterGameAccountIdFieldNumber = 2;

		// Token: 0x04001CD4 RID: 7380
		private static readonly uint RequesterGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CD5 RID: 7381
		private uint requesterGameAccountId_;

		// Token: 0x04001CD6 RID: 7382
		public const int ReasonFieldNumber = 3;

		// Token: 0x04001CD7 RID: 7383
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04001CD8 RID: 7384
		private uint reason_;
	}
}
