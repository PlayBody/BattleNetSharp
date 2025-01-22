using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026B RID: 619
	public sealed class PromoteClanMemberRequest : IMessage<PromoteClanMemberRequest>, IMessage, IEquatable<PromoteClanMemberRequest>, IDeepCloneable<PromoteClanMemberRequest>, IBufferMessage
	{
		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x001020F4 File Offset: 0x001002F4
		[DebuggerNonUserCode]
		public static MessageParser<PromoteClanMemberRequest> Parser
		{
			get
			{
				return PromoteClanMemberRequest._parser;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x0010210C File Offset: 0x0010030C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[91];
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x00102130 File Offset: 0x00100330
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteClanMemberRequest.Descriptor;
			}
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00102147 File Offset: 0x00100347
		[DebuggerNonUserCode]
		public PromoteClanMemberRequest()
		{
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00102151 File Offset: 0x00100351
		[DebuggerNonUserCode]
		public PromoteClanMemberRequest(PromoteClanMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00102190 File Offset: 0x00100390
		[DebuggerNonUserCode]
		public PromoteClanMemberRequest Clone()
		{
			return new PromoteClanMemberRequest(this);
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x001021A8 File Offset: 0x001003A8
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x001021C9 File Offset: 0x001003C9
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? PromoteClanMemberRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x001021E0 File Offset: 0x001003E0
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x001021FB File Offset: 0x001003FB
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x00102208 File Offset: 0x00100408
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x00102239 File Offset: 0x00100439
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
					targetGameAccountIdDefaultValue = PromoteClanMemberRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00102254 File Offset: 0x00100454
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00102271 File Offset: 0x00100471
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00102284 File Offset: 0x00100484
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteClanMemberRequest);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x001022A4 File Offset: 0x001004A4
		[DebuggerNonUserCode]
		public bool Equals(PromoteClanMemberRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetGameAccountId != other.TargetGameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00102318 File Offset: 0x00100518
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00102384 File Offset: 0x00100584
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x0010239C File Offset: 0x0010059C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x001023A8 File Offset: 0x001005A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00102418 File Offset: 0x00100618
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00102484 File Offset: 0x00100684
		[DebuggerNonUserCode]
		public void MergeFrom(PromoteClanMemberRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x001024E6 File Offset: 0x001006E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x001024F4 File Offset: 0x001006F4
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E0E RID: 7694
		private static readonly MessageParser<PromoteClanMemberRequest> _parser = new MessageParser<PromoteClanMemberRequest>(() => new PromoteClanMemberRequest());

		// Token: 0x04001E0F RID: 7695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E10 RID: 7696
		private int _hasBits0;

		// Token: 0x04001E11 RID: 7697
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E12 RID: 7698
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E13 RID: 7699
		private string clanId_;

		// Token: 0x04001E14 RID: 7700
		public const int TargetGameAccountIdFieldNumber = 2;

		// Token: 0x04001E15 RID: 7701
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001E16 RID: 7702
		private uint targetGameAccountId_;
	}
}
