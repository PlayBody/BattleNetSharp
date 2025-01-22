using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x0200015A RID: 346
	public sealed class PlayerLicense : IMessage<PlayerLicense>, IMessage, IEquatable<PlayerLicense>, IDeepCloneable<PlayerLicense>, IBufferMessage
	{
		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0008A880 File Offset: 0x00088A80
		[DebuggerNonUserCode]
		public static MessageParser<PlayerLicense> Parser
		{
			get
			{
				return PlayerLicense._parser;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0008A898 File Offset: 0x00088A98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0008A8BC File Offset: 0x00088ABC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLicense.Descriptor;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0008A8D3 File Offset: 0x00088AD3
		[DebuggerNonUserCode]
		public PlayerLicense()
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0008A8E0 File Offset: 0x00088AE0
		[DebuggerNonUserCode]
		public PlayerLicense(PlayerLicense other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entitlement_ = ((other.entitlement_ != null) ? other.entitlement_.Clone() : null);
			this.displayExpireTime_ = other.displayExpireTime_;
			this.expireTime_ = other.expireTime_;
			this.initialCacheTime_ = other.initialCacheTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0008A954 File Offset: 0x00088B54
		[DebuggerNonUserCode]
		public PlayerLicense Clone()
		{
			return new PlayerLicense(this);
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0008A96C File Offset: 0x00088B6C
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0008A984 File Offset: 0x00088B84
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

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0008A990 File Offset: 0x00088B90
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0008A9C1 File Offset: 0x00088BC1
		[DebuggerNonUserCode]
		public long DisplayExpireTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long displayExpireTimeDefaultValue;
				if (flag)
				{
					displayExpireTimeDefaultValue = this.displayExpireTime_;
				}
				else
				{
					displayExpireTimeDefaultValue = PlayerLicense.DisplayExpireTimeDefaultValue;
				}
				return displayExpireTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.displayExpireTime_ = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0008A9DC File Offset: 0x00088BDC
		[DebuggerNonUserCode]
		public bool HasDisplayExpireTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0008A9F9 File Offset: 0x00088BF9
		[DebuggerNonUserCode]
		public void ClearDisplayExpireTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0008AA0C File Offset: 0x00088C0C
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0008AA3D File Offset: 0x00088C3D
		[DebuggerNonUserCode]
		public long ExpireTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long expireTimeDefaultValue;
				if (flag)
				{
					expireTimeDefaultValue = this.expireTime_;
				}
				else
				{
					expireTimeDefaultValue = PlayerLicense.ExpireTimeDefaultValue;
				}
				return expireTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expireTime_ = value;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0008AA58 File Offset: 0x00088C58
		[DebuggerNonUserCode]
		public bool HasExpireTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0008AA75 File Offset: 0x00088C75
		[DebuggerNonUserCode]
		public void ClearExpireTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0008AA88 File Offset: 0x00088C88
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0008AAB9 File Offset: 0x00088CB9
		[DebuggerNonUserCode]
		public long InitialCacheTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				long initialCacheTimeDefaultValue;
				if (flag)
				{
					initialCacheTimeDefaultValue = this.initialCacheTime_;
				}
				else
				{
					initialCacheTimeDefaultValue = PlayerLicense.InitialCacheTimeDefaultValue;
				}
				return initialCacheTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.initialCacheTime_ = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0008AAD4 File Offset: 0x00088CD4
		[DebuggerNonUserCode]
		public bool HasInitialCacheTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0008AAF1 File Offset: 0x00088CF1
		[DebuggerNonUserCode]
		public void ClearInitialCacheTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0008AB04 File Offset: 0x00088D04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLicense);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0008AB24 File Offset: 0x00088D24
		[DebuggerNonUserCode]
		public bool Equals(PlayerLicense other)
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
					bool flag4 = !object.Equals(this.Entitlement, other.Entitlement);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DisplayExpireTime != other.DisplayExpireTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ExpireTime != other.ExpireTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InitialCacheTime != other.InitialCacheTime;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0008ABD4 File Offset: 0x00088DD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				num ^= this.Entitlement.GetHashCode();
			}
			bool hasDisplayExpireTime = this.HasDisplayExpireTime;
			if (hasDisplayExpireTime)
			{
				num ^= this.DisplayExpireTime.GetHashCode();
			}
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			bool hasInitialCacheTime = this.HasInitialCacheTime;
			if (hasInitialCacheTime)
			{
				num ^= this.InitialCacheTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0008AC7C File Offset: 0x00088E7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0008AC94 File Offset: 0x00088E94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0008ACA0 File Offset: 0x00088EA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Entitlement);
			}
			bool hasDisplayExpireTime = this.HasDisplayExpireTime;
			if (hasDisplayExpireTime)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.DisplayExpireTime);
			}
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ExpireTime);
			}
			bool hasInitialCacheTime = this.HasInitialCacheTime;
			if (hasInitialCacheTime)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.InitialCacheTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0008AD58 File Offset: 0x00088F58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entitlement_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entitlement);
			}
			bool hasDisplayExpireTime = this.HasDisplayExpireTime;
			if (hasDisplayExpireTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DisplayExpireTime);
			}
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpireTime);
			}
			bool hasInitialCacheTime = this.HasInitialCacheTime;
			if (hasInitialCacheTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InitialCacheTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0008AE04 File Offset: 0x00089004
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerLicense other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasDisplayExpireTime = other.HasDisplayExpireTime;
				if (hasDisplayExpireTime)
				{
					this.DisplayExpireTime = other.DisplayExpireTime;
				}
				bool hasExpireTime = other.HasExpireTime;
				if (hasExpireTime)
				{
					this.ExpireTime = other.ExpireTime;
				}
				bool hasInitialCacheTime = other.HasInitialCacheTime;
				if (hasInitialCacheTime)
				{
					this.InitialCacheTime = other.InitialCacheTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0008AEC2 File Offset: 0x000890C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0008AED0 File Offset: 0x000890D0
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
							goto IL_002C;
						}
						this.DisplayExpireTime = input.ReadInt64();
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
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.InitialCacheTime = input.ReadInt64();
				}
				else
				{
					this.ExpireTime = input.ReadInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FAD RID: 4013
		private static readonly MessageParser<PlayerLicense> _parser = new MessageParser<PlayerLicense>(() => new PlayerLicense());

		// Token: 0x04000FAE RID: 4014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FAF RID: 4015
		private int _hasBits0;

		// Token: 0x04000FB0 RID: 4016
		public const int EntitlementFieldNumber = 1;

		// Token: 0x04000FB1 RID: 4017
		private Entitlement entitlement_;

		// Token: 0x04000FB2 RID: 4018
		public const int DisplayExpireTimeFieldNumber = 2;

		// Token: 0x04000FB3 RID: 4019
		private static readonly long DisplayExpireTimeDefaultValue = 0L;

		// Token: 0x04000FB4 RID: 4020
		private long displayExpireTime_;

		// Token: 0x04000FB5 RID: 4021
		public const int ExpireTimeFieldNumber = 3;

		// Token: 0x04000FB6 RID: 4022
		private static readonly long ExpireTimeDefaultValue = 0L;

		// Token: 0x04000FB7 RID: 4023
		private long expireTime_;

		// Token: 0x04000FB8 RID: 4024
		public const int InitialCacheTimeFieldNumber = 4;

		// Token: 0x04000FB9 RID: 4025
		private static readonly long InitialCacheTimeDefaultValue = 0L;

		// Token: 0x04000FBA RID: 4026
		private long initialCacheTime_;
	}
}
