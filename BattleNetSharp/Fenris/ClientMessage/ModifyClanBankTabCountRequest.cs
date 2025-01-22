using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000289 RID: 649
	public sealed class ModifyClanBankTabCountRequest : IMessage<ModifyClanBankTabCountRequest>, IMessage, IEquatable<ModifyClanBankTabCountRequest>, IDeepCloneable<ModifyClanBankTabCountRequest>, IBufferMessage
	{
		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x0010A0F4 File Offset: 0x001082F4
		[DebuggerNonUserCode]
		public static MessageParser<ModifyClanBankTabCountRequest> Parser
		{
			get
			{
				return ModifyClanBankTabCountRequest._parser;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x0010A10C File Offset: 0x0010830C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[121];
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x0010A130 File Offset: 0x00108330
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyClanBankTabCountRequest.Descriptor;
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x0010A147 File Offset: 0x00108347
		[DebuggerNonUserCode]
		public ModifyClanBankTabCountRequest()
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x0010A151 File Offset: 0x00108351
		[DebuggerNonUserCode]
		public ModifyClanBankTabCountRequest(ModifyClanBankTabCountRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.newNumerOfTabs_ = other.newNumerOfTabs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x0010A190 File Offset: 0x00108390
		[DebuggerNonUserCode]
		public ModifyClanBankTabCountRequest Clone()
		{
			return new ModifyClanBankTabCountRequest(this);
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x0010A1A8 File Offset: 0x001083A8
		// (set) Token: 0x06004527 RID: 17703 RVA: 0x0010A1C9 File Offset: 0x001083C9
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ModifyClanBankTabCountRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x0010A1E0 File Offset: 0x001083E0
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x0010A1FB File Offset: 0x001083FB
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x0010A208 File Offset: 0x00108408
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x0010A239 File Offset: 0x00108439
		[DebuggerNonUserCode]
		public uint NewNumerOfTabs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint newNumerOfTabsDefaultValue;
				if (flag)
				{
					newNumerOfTabsDefaultValue = this.newNumerOfTabs_;
				}
				else
				{
					newNumerOfTabsDefaultValue = ModifyClanBankTabCountRequest.NewNumerOfTabsDefaultValue;
				}
				return newNumerOfTabsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.newNumerOfTabs_ = value;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x0010A254 File Offset: 0x00108454
		[DebuggerNonUserCode]
		public bool HasNewNumerOfTabs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x0010A271 File Offset: 0x00108471
		[DebuggerNonUserCode]
		public void ClearNewNumerOfTabs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x0010A284 File Offset: 0x00108484
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyClanBankTabCountRequest);
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x0010A2A4 File Offset: 0x001084A4
		[DebuggerNonUserCode]
		public bool Equals(ModifyClanBankTabCountRequest other)
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
						bool flag5 = this.NewNumerOfTabs != other.NewNumerOfTabs;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x0010A318 File Offset: 0x00108518
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasNewNumerOfTabs = this.HasNewNumerOfTabs;
			if (hasNewNumerOfTabs)
			{
				num ^= this.NewNumerOfTabs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x0010A384 File Offset: 0x00108584
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x0010A39C File Offset: 0x0010859C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x0010A3A8 File Offset: 0x001085A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasNewNumerOfTabs = this.HasNewNumerOfTabs;
			if (hasNewNumerOfTabs)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NewNumerOfTabs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x0010A418 File Offset: 0x00108618
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasNewNumerOfTabs = this.HasNewNumerOfTabs;
			if (hasNewNumerOfTabs)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NewNumerOfTabs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x0010A484 File Offset: 0x00108684
		[DebuggerNonUserCode]
		public void MergeFrom(ModifyClanBankTabCountRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasNewNumerOfTabs = other.HasNewNumerOfTabs;
				if (hasNewNumerOfTabs)
				{
					this.NewNumerOfTabs = other.NewNumerOfTabs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x0010A4E6 File Offset: 0x001086E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x0010A4F4 File Offset: 0x001086F4
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
						this.NewNumerOfTabs = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001EF8 RID: 7928
		private static readonly MessageParser<ModifyClanBankTabCountRequest> _parser = new MessageParser<ModifyClanBankTabCountRequest>(() => new ModifyClanBankTabCountRequest());

		// Token: 0x04001EF9 RID: 7929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EFA RID: 7930
		private int _hasBits0;

		// Token: 0x04001EFB RID: 7931
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001EFC RID: 7932
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001EFD RID: 7933
		private string clanId_;

		// Token: 0x04001EFE RID: 7934
		public const int NewNumerOfTabsFieldNumber = 2;

		// Token: 0x04001EFF RID: 7935
		private static readonly uint NewNumerOfTabsDefaultValue = 0U;

		// Token: 0x04001F00 RID: 7936
		private uint newNumerOfTabs_;
	}
}
