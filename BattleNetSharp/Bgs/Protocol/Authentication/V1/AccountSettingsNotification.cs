using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060E RID: 1550
	public sealed class AccountSettingsNotification : IMessage<AccountSettingsNotification>, IMessage, IEquatable<AccountSettingsNotification>, IDeepCloneable<AccountSettingsNotification>, IBufferMessage
	{
		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x0023339C File Offset: 0x0023159C
		[DebuggerNonUserCode]
		public static MessageParser<AccountSettingsNotification> Parser
		{
			get
			{
				return AccountSettingsNotification._parser;
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x002333B4 File Offset: 0x002315B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x06009131 RID: 37169 RVA: 0x002333D8 File Offset: 0x002315D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountSettingsNotification.Descriptor;
			}
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x002333EF File Offset: 0x002315EF
		[DebuggerNonUserCode]
		public AccountSettingsNotification()
		{
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x00233404 File Offset: 0x00231604
		[DebuggerNonUserCode]
		public AccountSettingsNotification(AccountSettingsNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.licenses_ = other.licenses_.Clone();
			this.isUsingRid_ = other.isUsingRid_;
			this.isPlayingFromIgr_ = other.isPlayingFromIgr_;
			this.canReceiveVoice_ = other.canReceiveVoice_;
			this.canSendVoice_ = other.canSendVoice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x00233478 File Offset: 0x00231678
		[DebuggerNonUserCode]
		public AccountSettingsNotification Clone()
		{
			return new AccountSettingsNotification(this);
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x06009135 RID: 37173 RVA: 0x00233490 File Offset: 0x00231690
		[DebuggerNonUserCode]
		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x002334A8 File Offset: 0x002316A8
		// (set) Token: 0x06009137 RID: 37175 RVA: 0x002334D9 File Offset: 0x002316D9
		[DebuggerNonUserCode]
		public bool IsUsingRid
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isUsingRidDefaultValue;
				if (flag)
				{
					isUsingRidDefaultValue = this.isUsingRid_;
				}
				else
				{
					isUsingRidDefaultValue = AccountSettingsNotification.IsUsingRidDefaultValue;
				}
				return isUsingRidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isUsingRid_ = value;
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x06009138 RID: 37176 RVA: 0x002334F4 File Offset: 0x002316F4
		[DebuggerNonUserCode]
		public bool HasIsUsingRid
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x00233511 File Offset: 0x00231711
		[DebuggerNonUserCode]
		public void ClearIsUsingRid()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600913A RID: 37178 RVA: 0x00233524 File Offset: 0x00231724
		// (set) Token: 0x0600913B RID: 37179 RVA: 0x00233555 File Offset: 0x00231755
		[DebuggerNonUserCode]
		public bool IsPlayingFromIgr
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isPlayingFromIgrDefaultValue;
				if (flag)
				{
					isPlayingFromIgrDefaultValue = this.isPlayingFromIgr_;
				}
				else
				{
					isPlayingFromIgrDefaultValue = AccountSettingsNotification.IsPlayingFromIgrDefaultValue;
				}
				return isPlayingFromIgrDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isPlayingFromIgr_ = value;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600913C RID: 37180 RVA: 0x00233570 File Offset: 0x00231770
		[DebuggerNonUserCode]
		public bool HasIsPlayingFromIgr
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0023358D File Offset: 0x0023178D
		[DebuggerNonUserCode]
		public void ClearIsPlayingFromIgr()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600913E RID: 37182 RVA: 0x002335A0 File Offset: 0x002317A0
		// (set) Token: 0x0600913F RID: 37183 RVA: 0x002335D1 File Offset: 0x002317D1
		[DebuggerNonUserCode]
		public bool CanReceiveVoice
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool canReceiveVoiceDefaultValue;
				if (flag)
				{
					canReceiveVoiceDefaultValue = this.canReceiveVoice_;
				}
				else
				{
					canReceiveVoiceDefaultValue = AccountSettingsNotification.CanReceiveVoiceDefaultValue;
				}
				return canReceiveVoiceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.canReceiveVoice_ = value;
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06009140 RID: 37184 RVA: 0x002335EC File Offset: 0x002317EC
		[DebuggerNonUserCode]
		public bool HasCanReceiveVoice
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x00233609 File Offset: 0x00231809
		[DebuggerNonUserCode]
		public void ClearCanReceiveVoice()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x06009142 RID: 37186 RVA: 0x0023361C File Offset: 0x0023181C
		// (set) Token: 0x06009143 RID: 37187 RVA: 0x0023364D File Offset: 0x0023184D
		[DebuggerNonUserCode]
		public bool CanSendVoice
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool canSendVoiceDefaultValue;
				if (flag)
				{
					canSendVoiceDefaultValue = this.canSendVoice_;
				}
				else
				{
					canSendVoiceDefaultValue = AccountSettingsNotification.CanSendVoiceDefaultValue;
				}
				return canSendVoiceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.canSendVoice_ = value;
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x00233668 File Offset: 0x00231868
		[DebuggerNonUserCode]
		public bool HasCanSendVoice
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x00233685 File Offset: 0x00231885
		[DebuggerNonUserCode]
		public void ClearCanSendVoice()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x00233698 File Offset: 0x00231898
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountSettingsNotification);
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x002336B8 File Offset: 0x002318B8
		[DebuggerNonUserCode]
		public bool Equals(AccountSettingsNotification other)
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
					bool flag4 = !this.licenses_.Equals(other.licenses_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsUsingRid != other.IsUsingRid;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsPlayingFromIgr != other.IsPlayingFromIgr;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CanReceiveVoice != other.CanReceiveVoice;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CanSendVoice != other.CanSendVoice;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x00233788 File Offset: 0x00231988
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.licenses_.GetHashCode();
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				num ^= this.IsUsingRid.GetHashCode();
			}
			bool hasIsPlayingFromIgr = this.HasIsPlayingFromIgr;
			if (hasIsPlayingFromIgr)
			{
				num ^= this.IsPlayingFromIgr.GetHashCode();
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				num ^= this.CanReceiveVoice.GetHashCode();
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				num ^= this.CanSendVoice.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009149 RID: 37193 RVA: 0x0023383C File Offset: 0x00231A3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600914A RID: 37194 RVA: 0x00233854 File Offset: 0x00231A54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600914B RID: 37195 RVA: 0x00233860 File Offset: 0x00231A60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.licenses_.WriteTo(ref output, AccountSettingsNotification._repeated_licenses_codec);
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUsingRid);
			}
			bool hasIsPlayingFromIgr = this.HasIsPlayingFromIgr;
			if (hasIsPlayingFromIgr)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPlayingFromIgr);
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.CanReceiveVoice);
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CanSendVoice);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x00233928 File Offset: 0x00231B28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.licenses_.CalculateSize(AccountSettingsNotification._repeated_licenses_codec);
			bool hasIsUsingRid = this.HasIsUsingRid;
			if (hasIsUsingRid)
			{
				num += 2;
			}
			bool hasIsPlayingFromIgr = this.HasIsPlayingFromIgr;
			if (hasIsPlayingFromIgr)
			{
				num += 2;
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				num += 2;
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x002339B4 File Offset: 0x00231BB4
		[DebuggerNonUserCode]
		public void MergeFrom(AccountSettingsNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.licenses_.Add(other.licenses_);
				bool hasIsUsingRid = other.HasIsUsingRid;
				if (hasIsUsingRid)
				{
					this.IsUsingRid = other.IsUsingRid;
				}
				bool hasIsPlayingFromIgr = other.HasIsPlayingFromIgr;
				if (hasIsPlayingFromIgr)
				{
					this.IsPlayingFromIgr = other.IsPlayingFromIgr;
				}
				bool hasCanReceiveVoice = other.HasCanReceiveVoice;
				if (hasCanReceiveVoice)
				{
					this.CanReceiveVoice = other.CanReceiveVoice;
				}
				bool hasCanSendVoice = other.HasCanSendVoice;
				if (hasCanSendVoice)
				{
					this.CanSendVoice = other.CanSendVoice;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x00233A5F File Offset: 0x00231C5F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x00233A6C File Offset: 0x00231C6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.IsUsingRid = input.ReadBool();
					}
					else
					{
						this.licenses_.AddEntriesFrom(ref input, AccountSettingsNotification._repeated_licenses_codec);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.CanSendVoice = input.ReadBool();
					}
					else
					{
						this.CanReceiveVoice = input.ReadBool();
					}
				}
				else
				{
					this.IsPlayingFromIgr = input.ReadBool();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400418F RID: 16783
		private static readonly MessageParser<AccountSettingsNotification> _parser = new MessageParser<AccountSettingsNotification>(() => new AccountSettingsNotification());

		// Token: 0x04004190 RID: 16784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004191 RID: 16785
		private int _hasBits0;

		// Token: 0x04004192 RID: 16786
		public const int LicensesFieldNumber = 1;

		// Token: 0x04004193 RID: 16787
		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(10U, AccountLicense.Parser);

		// Token: 0x04004194 RID: 16788
		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		// Token: 0x04004195 RID: 16789
		public const int IsUsingRidFieldNumber = 2;

		// Token: 0x04004196 RID: 16790
		private static readonly bool IsUsingRidDefaultValue = false;

		// Token: 0x04004197 RID: 16791
		private bool isUsingRid_;

		// Token: 0x04004198 RID: 16792
		public const int IsPlayingFromIgrFieldNumber = 3;

		// Token: 0x04004199 RID: 16793
		private static readonly bool IsPlayingFromIgrDefaultValue = false;

		// Token: 0x0400419A RID: 16794
		private bool isPlayingFromIgr_;

		// Token: 0x0400419B RID: 16795
		public const int CanReceiveVoiceFieldNumber = 4;

		// Token: 0x0400419C RID: 16796
		private static readonly bool CanReceiveVoiceDefaultValue = false;

		// Token: 0x0400419D RID: 16797
		private bool canReceiveVoice_;

		// Token: 0x0400419E RID: 16798
		public const int CanSendVoiceFieldNumber = 5;

		// Token: 0x0400419F RID: 16799
		private static readonly bool CanSendVoiceDefaultValue = false;

		// Token: 0x040041A0 RID: 16800
		private bool canSendVoice_;
	}
}
