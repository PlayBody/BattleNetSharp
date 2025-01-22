using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024D RID: 589
	public sealed class PartyKickMemberRequest : IMessage<PartyKickMemberRequest>, IMessage, IEquatable<PartyKickMemberRequest>, IDeepCloneable<PartyKickMemberRequest>, IBufferMessage
	{
		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x000F8200 File Offset: 0x000F6400
		[DebuggerNonUserCode]
		public static MessageParser<PartyKickMemberRequest> Parser
		{
			get
			{
				return PartyKickMemberRequest._parser;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x000F8218 File Offset: 0x000F6418
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[61];
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x000F823C File Offset: 0x000F643C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyKickMemberRequest.Descriptor;
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x000F8253 File Offset: 0x000F6453
		[DebuggerNonUserCode]
		public PartyKickMemberRequest()
		{
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x000F825D File Offset: 0x000F645D
		[DebuggerNonUserCode]
		public PartyKickMemberRequest(PartyKickMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x000F8290 File Offset: 0x000F6490
		[DebuggerNonUserCode]
		public PartyKickMemberRequest Clone()
		{
			return new PartyKickMemberRequest(this);
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x000F82A8 File Offset: 0x000F64A8
		// (set) Token: 0x06003F59 RID: 16217 RVA: 0x000F82D9 File Offset: 0x000F64D9
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PartyKickMemberRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06003F5A RID: 16218 RVA: 0x000F82F4 File Offset: 0x000F64F4
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x000F8311 File Offset: 0x000F6511
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x000F8324 File Offset: 0x000F6524
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyKickMemberRequest);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x000F8344 File Offset: 0x000F6544
		[DebuggerNonUserCode]
		public bool Equals(PartyKickMemberRequest other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000F839C File Offset: 0x000F659C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x000F83EC File Offset: 0x000F65EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x000F8404 File Offset: 0x000F6604
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000F8410 File Offset: 0x000F6610
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x000F845C File Offset: 0x000F665C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x000F84AC File Offset: 0x000F66AC
		[DebuggerNonUserCode]
		public void MergeFrom(PartyKickMemberRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x000F84F5 File Offset: 0x000F66F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000F8500 File Offset: 0x000F6700
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
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CD9 RID: 7385
		private static readonly MessageParser<PartyKickMemberRequest> _parser = new MessageParser<PartyKickMemberRequest>(() => new PartyKickMemberRequest());

		// Token: 0x04001CDA RID: 7386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CDB RID: 7387
		private int _hasBits0;

		// Token: 0x04001CDC RID: 7388
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001CDD RID: 7389
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001CDE RID: 7390
		private uint gameAccountId_;
	}
}
