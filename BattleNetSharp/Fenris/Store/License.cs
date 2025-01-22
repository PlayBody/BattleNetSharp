using System;
using System.Diagnostics;
using Fenris.License;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Store
{
	// Token: 0x02000111 RID: 273
	public sealed class License : IMessage<License>, IMessage, IEquatable<License>, IDeepCloneable<License>, IBufferMessage
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0005C708 File Offset: 0x0005A908
		[DebuggerNonUserCode]
		public static MessageParser<License> Parser
		{
			get
			{
				return License._parser;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0005C720 File Offset: 0x0005A920
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0005C744 File Offset: 0x0005A944
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return License.Descriptor;
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0005C75B File Offset: 0x0005A95B
		[DebuggerNonUserCode]
		public License()
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0005C768 File Offset: 0x0005A968
		[DebuggerNonUserCode]
		public License(License other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.bnetLicenseId_ = other.bnetLicenseId_;
			this.entitlement_ = ((other.entitlement_ != null) ? other.entitlement_.Clone() : null);
			this.licenseType_ = other.licenseType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0005C7D0 File Offset: 0x0005A9D0
		[DebuggerNonUserCode]
		public License Clone()
		{
			return new License(this);
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0005C819 File Offset: 0x0005AA19
		[DebuggerNonUserCode]
		public uint BnetLicenseId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint bnetLicenseIdDefaultValue;
				if (flag)
				{
					bnetLicenseIdDefaultValue = this.bnetLicenseId_;
				}
				else
				{
					bnetLicenseIdDefaultValue = License.BnetLicenseIdDefaultValue;
				}
				return bnetLicenseIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetLicenseId_ = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0005C834 File Offset: 0x0005AA34
		[DebuggerNonUserCode]
		public bool HasBnetLicenseId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0005C851 File Offset: 0x0005AA51
		[DebuggerNonUserCode]
		public void ClearBnetLicenseId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0005C864 File Offset: 0x0005AA64
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x0005C87C File Offset: 0x0005AA7C
		[DebuggerNonUserCode]
		public Entitlement Entitlement
		{
			get
			{
				return this.entitlement_;
			}
			set
			{
				this.entitlement_ = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0005C888 File Offset: 0x0005AA88
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0005C8B9 File Offset: 0x0005AAB9
		[DebuggerNonUserCode]
		public uint LicenseType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint licenseTypeDefaultValue;
				if (flag)
				{
					licenseTypeDefaultValue = this.licenseType_;
				}
				else
				{
					licenseTypeDefaultValue = License.LicenseTypeDefaultValue;
				}
				return licenseTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.licenseType_ = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		[DebuggerNonUserCode]
		public bool HasLicenseType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0005C8F1 File Offset: 0x0005AAF1
		[DebuggerNonUserCode]
		public void ClearLicenseType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0005C904 File Offset: 0x0005AB04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as License);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0005C924 File Offset: 0x0005AB24
		[DebuggerNonUserCode]
		public bool Equals(License other)
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
					bool flag4 = this.BnetLicenseId != other.BnetLicenseId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Entitlement, other.Entitlement);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LicenseType != other.LicenseType;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0005C9B4 File Offset: 0x0005ABB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBnetLicenseId = this.HasBnetLicenseId;
			if (hasBnetLicenseId)
			{
				num ^= this.BnetLicenseId.GetHashCode();
			}
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				num ^= this.Entitlement.GetHashCode();
			}
			bool hasLicenseType = this.HasLicenseType;
			if (hasLicenseType)
			{
				num ^= this.LicenseType.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0005CA40 File Offset: 0x0005AC40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0005CA58 File Offset: 0x0005AC58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0005CA64 File Offset: 0x0005AC64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBnetLicenseId = this.HasBnetLicenseId;
			if (hasBnetLicenseId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BnetLicenseId);
			}
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Entitlement);
			}
			bool hasLicenseType = this.HasLicenseType;
			if (hasLicenseType)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LicenseType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBnetLicenseId = this.HasBnetLicenseId;
			if (hasBnetLicenseId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetLicenseId);
			}
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entitlement);
			}
			bool hasLicenseType = this.HasLicenseType;
			if (hasLicenseType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LicenseType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0005CB88 File Offset: 0x0005AD88
		[DebuggerNonUserCode]
		public void MergeFrom(License other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBnetLicenseId = other.HasBnetLicenseId;
				if (hasBnetLicenseId)
				{
					this.BnetLicenseId = other.BnetLicenseId;
				}
				bool flag2 = other.entitlement_ != null;
				if (flag2)
				{
					bool flag3 = this.entitlement_ == null;
					if (flag3)
					{
						this.Entitlement = new Entitlement();
					}
					this.Entitlement.MergeFrom(other.Entitlement);
				}
				bool hasLicenseType = other.HasLicenseType;
				if (hasLicenseType)
				{
					this.LicenseType = other.LicenseType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0005CC2B File Offset: 0x0005AE2B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0005CC38 File Offset: 0x0005AE38
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
					if (num3 != 18U)
					{
						if (num3 != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LicenseType = input.ReadUInt32();
						}
					}
					else
					{
						bool flag = this.entitlement_ == null;
						if (flag)
						{
							this.Entitlement = new Entitlement();
						}
						input.ReadMessage(this.Entitlement);
					}
				}
				else
				{
					this.BnetLicenseId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000A5C RID: 2652
		private static readonly MessageParser<License> _parser = new MessageParser<License>(() => new License());

		// Token: 0x04000A5D RID: 2653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A5E RID: 2654
		private int _hasBits0;

		// Token: 0x04000A5F RID: 2655
		public const int BnetLicenseIdFieldNumber = 1;

		// Token: 0x04000A60 RID: 2656
		private static readonly uint BnetLicenseIdDefaultValue = 0U;

		// Token: 0x04000A61 RID: 2657
		private uint bnetLicenseId_;

		// Token: 0x04000A62 RID: 2658
		public const int EntitlementFieldNumber = 2;

		// Token: 0x04000A63 RID: 2659
		private Entitlement entitlement_;

		// Token: 0x04000A64 RID: 2660
		public const int LicenseTypeFieldNumber = 4;

		// Token: 0x04000A65 RID: 2661
		private static readonly uint LicenseTypeDefaultValue = 0U;

		// Token: 0x04000A66 RID: 2662
		private uint licenseType_;
	}
}
