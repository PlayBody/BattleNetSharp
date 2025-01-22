using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x0200015C RID: 348
	public sealed class PlayerConsumableLicense : IMessage<PlayerConsumableLicense>, IMessage, IEquatable<PlayerConsumableLicense>, IDeepCloneable<PlayerConsumableLicense>, IBufferMessage
	{
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0008B454 File Offset: 0x00089654
		[DebuggerNonUserCode]
		public static MessageParser<PlayerConsumableLicense> Parser
		{
			get
			{
				return PlayerConsumableLicense._parser;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0008B46C File Offset: 0x0008966C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0008B490 File Offset: 0x00089690
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerConsumableLicense.Descriptor;
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0008B4A7 File Offset: 0x000896A7
		[DebuggerNonUserCode]
		public PlayerConsumableLicense()
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0008B4B4 File Offset: 0x000896B4
		[DebuggerNonUserCode]
		public PlayerConsumableLicense(PlayerConsumableLicense other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.consumable_ = ((other.consumable_ != null) ? other.consumable_.Clone() : null);
			this.activateTime_ = other.activateTime_;
			this.expireTime_ = other.expireTime_;
			this.initialCacheTime_ = other.initialCacheTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0008B528 File Offset: 0x00089728
		[DebuggerNonUserCode]
		public PlayerConsumableLicense Clone()
		{
			return new PlayerConsumableLicense(this);
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0008B540 File Offset: 0x00089740
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0008B558 File Offset: 0x00089758
		[DebuggerNonUserCode]
		public Consumable Consumable
		{
			get
			{
				return this.consumable_;
			}
			set
			{
				this.consumable_ = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x0008B564 File Offset: 0x00089764
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x0008B595 File Offset: 0x00089795
		[DebuggerNonUserCode]
		public long ActivateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long activateTimeDefaultValue;
				if (flag)
				{
					activateTimeDefaultValue = this.activateTime_;
				}
				else
				{
					activateTimeDefaultValue = PlayerConsumableLicense.ActivateTimeDefaultValue;
				}
				return activateTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.activateTime_ = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0008B5B0 File Offset: 0x000897B0
		[DebuggerNonUserCode]
		public bool HasActivateTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0008B5CD File Offset: 0x000897CD
		[DebuggerNonUserCode]
		public void ClearActivateTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0008B5E0 File Offset: 0x000897E0
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0008B611 File Offset: 0x00089811
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
					expireTimeDefaultValue = PlayerConsumableLicense.ExpireTimeDefaultValue;
				}
				return expireTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expireTime_ = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0008B62C File Offset: 0x0008982C
		[DebuggerNonUserCode]
		public bool HasExpireTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0008B649 File Offset: 0x00089849
		[DebuggerNonUserCode]
		public void ClearExpireTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0008B65C File Offset: 0x0008985C
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0008B68D File Offset: 0x0008988D
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
					initialCacheTimeDefaultValue = PlayerConsumableLicense.InitialCacheTimeDefaultValue;
				}
				return initialCacheTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.initialCacheTime_ = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x0008B6A8 File Offset: 0x000898A8
		[DebuggerNonUserCode]
		public bool HasInitialCacheTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0008B6C5 File Offset: 0x000898C5
		[DebuggerNonUserCode]
		public void ClearInitialCacheTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0008B6D8 File Offset: 0x000898D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerConsumableLicense);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0008B6F8 File Offset: 0x000898F8
		[DebuggerNonUserCode]
		public bool Equals(PlayerConsumableLicense other)
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
					bool flag4 = !object.Equals(this.Consumable, other.Consumable);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ActivateTime != other.ActivateTime;
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

		// Token: 0x06002409 RID: 9225 RVA: 0x0008B7A8 File Offset: 0x000899A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.consumable_ != null;
			if (flag)
			{
				num ^= this.Consumable.GetHashCode();
			}
			bool hasActivateTime = this.HasActivateTime;
			if (hasActivateTime)
			{
				num ^= this.ActivateTime.GetHashCode();
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

		// Token: 0x0600240A RID: 9226 RVA: 0x0008B850 File Offset: 0x00089A50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0008B868 File Offset: 0x00089A68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0008B874 File Offset: 0x00089A74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.consumable_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Consumable);
			}
			bool hasActivateTime = this.HasActivateTime;
			if (hasActivateTime)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ActivateTime);
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

		// Token: 0x0600240D RID: 9229 RVA: 0x0008B92C File Offset: 0x00089B2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.consumable_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Consumable);
			}
			bool hasActivateTime = this.HasActivateTime;
			if (hasActivateTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ActivateTime);
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

		// Token: 0x0600240E RID: 9230 RVA: 0x0008B9D8 File Offset: 0x00089BD8
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerConsumableLicense other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.consumable_ != null;
				if (flag2)
				{
					bool flag3 = this.consumable_ == null;
					if (flag3)
					{
						this.Consumable = new Consumable();
					}
					this.Consumable.MergeFrom(other.Consumable);
				}
				bool hasActivateTime = other.HasActivateTime;
				if (hasActivateTime)
				{
					this.ActivateTime = other.ActivateTime;
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

		// Token: 0x0600240F RID: 9231 RVA: 0x0008BA96 File Offset: 0x00089C96
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0008BAA4 File Offset: 0x00089CA4
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
						this.ActivateTime = input.ReadInt64();
					}
					else
					{
						bool flag = this.consumable_ == null;
						if (flag)
						{
							this.Consumable = new Consumable();
						}
						input.ReadMessage(this.Consumable);
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

		// Token: 0x04000FC4 RID: 4036
		private static readonly MessageParser<PlayerConsumableLicense> _parser = new MessageParser<PlayerConsumableLicense>(() => new PlayerConsumableLicense());

		// Token: 0x04000FC5 RID: 4037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FC6 RID: 4038
		private int _hasBits0;

		// Token: 0x04000FC7 RID: 4039
		public const int ConsumableFieldNumber = 1;

		// Token: 0x04000FC8 RID: 4040
		private Consumable consumable_;

		// Token: 0x04000FC9 RID: 4041
		public const int ActivateTimeFieldNumber = 2;

		// Token: 0x04000FCA RID: 4042
		private static readonly long ActivateTimeDefaultValue = 0L;

		// Token: 0x04000FCB RID: 4043
		private long activateTime_;

		// Token: 0x04000FCC RID: 4044
		public const int ExpireTimeFieldNumber = 3;

		// Token: 0x04000FCD RID: 4045
		private static readonly long ExpireTimeDefaultValue = 0L;

		// Token: 0x04000FCE RID: 4046
		private long expireTime_;

		// Token: 0x04000FCF RID: 4047
		public const int InitialCacheTimeFieldNumber = 4;

		// Token: 0x04000FD0 RID: 4048
		private static readonly long InitialCacheTimeDefaultValue = 0L;

		// Token: 0x04000FD1 RID: 4049
		private long initialCacheTime_;
	}
}
