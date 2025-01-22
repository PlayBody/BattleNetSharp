using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x0200015D RID: 349
	public sealed class PlayerLicenses : IMessage<PlayerLicenses>, IMessage, IEquatable<PlayerLicenses>, IDeepCloneable<PlayerLicenses>, IBufferMessage
	{
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x0008BB94 File Offset: 0x00089D94
		[DebuggerNonUserCode]
		public static MessageParser<PlayerLicenses> Parser
		{
			get
			{
				return PlayerLicenses._parser;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x0008BBAC File Offset: 0x00089DAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0008BBD0 File Offset: 0x00089DD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLicenses.Descriptor;
			}
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0008BBE7 File Offset: 0x00089DE7
		[DebuggerNonUserCode]
		public PlayerLicenses()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0008BC07 File Offset: 0x00089E07
		[DebuggerNonUserCode]
		public PlayerLicenses(PlayerLicenses other)
			: this()
		{
			this.licenses_ = other.licenses_.Clone();
			this.consumableLicenses_ = other.consumableLicenses_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0008BC44 File Offset: 0x00089E44
		[DebuggerNonUserCode]
		public PlayerLicenses Clone()
		{
			return new PlayerLicenses(this);
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x0008BC5C File Offset: 0x00089E5C
		[DebuggerNonUserCode]
		public RepeatedField<PlayerLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0008BC74 File Offset: 0x00089E74
		[DebuggerNonUserCode]
		public RepeatedField<PlayerConsumableLicense> ConsumableLicenses
		{
			get
			{
				return this.consumableLicenses_;
			}
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0008BC8C File Offset: 0x00089E8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLicenses);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0008BCAC File Offset: 0x00089EAC
		[DebuggerNonUserCode]
		public bool Equals(PlayerLicenses other)
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
						bool flag5 = !this.consumableLicenses_.Equals(other.consumableLicenses_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0008BD24 File Offset: 0x00089F24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.licenses_.GetHashCode();
			num ^= this.consumableLicenses_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0008BD74 File Offset: 0x00089F74
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0008BD8C File Offset: 0x00089F8C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0008BD98 File Offset: 0x00089F98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.licenses_.WriteTo(ref output, PlayerLicenses._repeated_licenses_codec);
			this.consumableLicenses_.WriteTo(ref output, PlayerLicenses._repeated_consumableLicenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0008BDE8 File Offset: 0x00089FE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.licenses_.CalculateSize(PlayerLicenses._repeated_licenses_codec);
			num += this.consumableLicenses_.CalculateSize(PlayerLicenses._repeated_consumableLicenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0008BE40 File Offset: 0x0008A040
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerLicenses other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.licenses_.Add(other.licenses_);
				this.consumableLicenses_.Add(other.consumableLicenses_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0008BE94 File Offset: 0x0008A094
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0008BEA0 File Offset: 0x0008A0A0
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.consumableLicenses_.AddEntriesFrom(ref input, PlayerLicenses._repeated_consumableLicenses_codec);
					}
				}
				else
				{
					this.licenses_.AddEntriesFrom(ref input, PlayerLicenses._repeated_licenses_codec);
				}
			}
		}

		// Token: 0x04000FD2 RID: 4050
		private static readonly MessageParser<PlayerLicenses> _parser = new MessageParser<PlayerLicenses>(() => new PlayerLicenses());

		// Token: 0x04000FD3 RID: 4051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FD4 RID: 4052
		public const int LicensesFieldNumber = 1;

		// Token: 0x04000FD5 RID: 4053
		private static readonly FieldCodec<PlayerLicense> _repeated_licenses_codec = FieldCodec.ForMessage<PlayerLicense>(10U, PlayerLicense.Parser);

		// Token: 0x04000FD6 RID: 4054
		private readonly RepeatedField<PlayerLicense> licenses_ = new RepeatedField<PlayerLicense>();

		// Token: 0x04000FD7 RID: 4055
		public const int ConsumableLicensesFieldNumber = 2;

		// Token: 0x04000FD8 RID: 4056
		private static readonly FieldCodec<PlayerConsumableLicense> _repeated_consumableLicenses_codec = FieldCodec.ForMessage<PlayerConsumableLicense>(18U, PlayerConsumableLicense.Parser);

		// Token: 0x04000FD9 RID: 4057
		private readonly RepeatedField<PlayerConsumableLicense> consumableLicenses_ = new RepeatedField<PlayerConsumableLicense>();
	}
}
