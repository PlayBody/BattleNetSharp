using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AC RID: 428
	public sealed class MountSavedData : IMessage<MountSavedData>, IMessage, IEquatable<MountSavedData>, IDeepCloneable<MountSavedData>, IBufferMessage
	{
		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000B0ED4 File Offset: 0x000AF0D4
		[DebuggerNonUserCode]
		public static MessageParser<MountSavedData> Parser
		{
			get
			{
				return MountSavedData._parser;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000B0EEC File Offset: 0x000AF0EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x000B0F10 File Offset: 0x000AF110
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MountSavedData.Descriptor;
			}
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000B0F27 File Offset: 0x000AF127
		[DebuggerNonUserCode]
		public MountSavedData()
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000B0F3C File Offset: 0x000AF13C
		[DebuggerNonUserCode]
		public MountSavedData(MountSavedData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mounts_ = other.mounts_.Clone();
			this.unlockedRiding_ = other.unlockedRiding_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000B0F8C File Offset: 0x000AF18C
		[DebuggerNonUserCode]
		public MountSavedData Clone()
		{
			return new MountSavedData(this);
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000B0FA4 File Offset: 0x000AF1A4
		[DebuggerNonUserCode]
		public RepeatedField<MountData> Mounts
		{
			get
			{
				return this.mounts_;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000B0FBC File Offset: 0x000AF1BC
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x000B0FED File Offset: 0x000AF1ED
		[DebuggerNonUserCode]
		public bool UnlockedRiding
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool unlockedRidingDefaultValue;
				if (flag)
				{
					unlockedRidingDefaultValue = this.unlockedRiding_;
				}
				else
				{
					unlockedRidingDefaultValue = MountSavedData.UnlockedRidingDefaultValue;
				}
				return unlockedRidingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unlockedRiding_ = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000B1008 File Offset: 0x000AF208
		[DebuggerNonUserCode]
		public bool HasUnlockedRiding
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000B1025 File Offset: 0x000AF225
		[DebuggerNonUserCode]
		public void ClearUnlockedRiding()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000B1038 File Offset: 0x000AF238
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MountSavedData);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000B1058 File Offset: 0x000AF258
		[DebuggerNonUserCode]
		public bool Equals(MountSavedData other)
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
					bool flag4 = !this.mounts_.Equals(other.mounts_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UnlockedRiding != other.UnlockedRiding;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000B10CC File Offset: 0x000AF2CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mounts_.GetHashCode();
			bool hasUnlockedRiding = this.HasUnlockedRiding;
			if (hasUnlockedRiding)
			{
				num ^= this.UnlockedRiding.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000B112C File Offset: 0x000AF32C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000B1144 File Offset: 0x000AF344
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000B1150 File Offset: 0x000AF350
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mounts_.WriteTo(ref output, MountSavedData._repeated_mounts_codec);
			bool hasUnlockedRiding = this.HasUnlockedRiding;
			if (hasUnlockedRiding)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnlockedRiding);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000B11B0 File Offset: 0x000AF3B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mounts_.CalculateSize(MountSavedData._repeated_mounts_codec);
			bool hasUnlockedRiding = this.HasUnlockedRiding;
			if (hasUnlockedRiding)
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

		// Token: 0x06002D32 RID: 11570 RVA: 0x000B1208 File Offset: 0x000AF408
		[DebuggerNonUserCode]
		public void MergeFrom(MountSavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.mounts_.Add(other.mounts_);
				bool hasUnlockedRiding = other.HasUnlockedRiding;
				if (hasUnlockedRiding)
				{
					this.UnlockedRiding = other.UnlockedRiding;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000B1263 File Offset: 0x000AF463
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000B1270 File Offset: 0x000AF470
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
						this.UnlockedRiding = input.ReadBool();
					}
				}
				else
				{
					this.mounts_.AddEntriesFrom(ref input, MountSavedData._repeated_mounts_codec);
				}
			}
		}

		// Token: 0x04001464 RID: 5220
		private static readonly MessageParser<MountSavedData> _parser = new MessageParser<MountSavedData>(() => new MountSavedData());

		// Token: 0x04001465 RID: 5221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001466 RID: 5222
		private int _hasBits0;

		// Token: 0x04001467 RID: 5223
		public const int MountsFieldNumber = 1;

		// Token: 0x04001468 RID: 5224
		private static readonly FieldCodec<MountData> _repeated_mounts_codec = FieldCodec.ForMessage<MountData>(10U, MountData.Parser);

		// Token: 0x04001469 RID: 5225
		private readonly RepeatedField<MountData> mounts_ = new RepeatedField<MountData>();

		// Token: 0x0400146A RID: 5226
		public const int UnlockedRidingFieldNumber = 2;

		// Token: 0x0400146B RID: 5227
		private static readonly bool UnlockedRidingDefaultValue = false;

		// Token: 0x0400146C RID: 5228
		private bool unlockedRiding_;
	}
}
