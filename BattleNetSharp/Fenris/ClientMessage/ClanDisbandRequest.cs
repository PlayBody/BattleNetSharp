using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027F RID: 639
	public sealed class ClanDisbandRequest : IMessage<ClanDisbandRequest>, IMessage, IEquatable<ClanDisbandRequest>, IDeepCloneable<ClanDisbandRequest>, IBufferMessage
	{
		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x00107424 File Offset: 0x00105624
		[DebuggerNonUserCode]
		public static MessageParser<ClanDisbandRequest> Parser
		{
			get
			{
				return ClanDisbandRequest._parser;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x0010743C File Offset: 0x0010563C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[111];
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x00107460 File Offset: 0x00105660
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanDisbandRequest.Descriptor;
			}
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00107477 File Offset: 0x00105677
		[DebuggerNonUserCode]
		public ClanDisbandRequest()
		{
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00107481 File Offset: 0x00105681
		[DebuggerNonUserCode]
		public ClanDisbandRequest(ClanDisbandRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001074A8 File Offset: 0x001056A8
		[DebuggerNonUserCode]
		public ClanDisbandRequest Clone()
		{
			return new ClanDisbandRequest(this);
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x001074C0 File Offset: 0x001056C0
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x001074E1 File Offset: 0x001056E1
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanDisbandRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x001074F8 File Offset: 0x001056F8
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00107513 File Offset: 0x00105713
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00107520 File Offset: 0x00105720
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanDisbandRequest);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00107540 File Offset: 0x00105740
		[DebuggerNonUserCode]
		public bool Equals(ClanDisbandRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00107598 File Offset: 0x00105798
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x001075E4 File Offset: 0x001057E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001075FC File Offset: 0x001057FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00107608 File Offset: 0x00105808
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00107654 File Offset: 0x00105854
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x001076A4 File Offset: 0x001058A4
		[DebuggerNonUserCode]
		public void MergeFrom(ClanDisbandRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x001076ED File Offset: 0x001058ED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001076F8 File Offset: 0x001058F8
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
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001EA1 RID: 7841
		private static readonly MessageParser<ClanDisbandRequest> _parser = new MessageParser<ClanDisbandRequest>(() => new ClanDisbandRequest());

		// Token: 0x04001EA2 RID: 7842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EA3 RID: 7843
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001EA4 RID: 7844
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001EA5 RID: 7845
		private string clanId_;
	}
}
