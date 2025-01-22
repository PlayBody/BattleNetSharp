using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000744 RID: 1860
	public sealed class GameStatus : IMessage<GameStatus>, IMessage, IEquatable<GameStatus>, IDeepCloneable<GameStatus>, IBufferMessage
	{
		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x0029A820 File Offset: 0x00298A20
		[DebuggerNonUserCode]
		public static MessageParser<GameStatus> Parser
		{
			get
			{
				return GameStatus._parser;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600AB03 RID: 43779 RVA: 0x0029A838 File Offset: 0x00298A38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x0029A85C File Offset: 0x00298A5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatus.Descriptor;
			}
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x0029A873 File Offset: 0x00298A73
		[DebuggerNonUserCode]
		public GameStatus()
		{
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x0029A880 File Offset: 0x00298A80
		[DebuggerNonUserCode]
		public GameStatus(GameStatus other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isSuspended_ = other.isSuspended_;
			this.isBanned_ = other.isBanned_;
			this.suspensionExpires_ = other.suspensionExpires_;
			this.program_ = other.program_;
			this.isLocked_ = other.isLocked_;
			this.isBamUnlockable_ = other.isBamUnlockable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x0029A8FC File Offset: 0x00298AFC
		[DebuggerNonUserCode]
		public GameStatus Clone()
		{
			return new GameStatus(this);
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600AB08 RID: 43784 RVA: 0x0029A914 File Offset: 0x00298B14
		// (set) Token: 0x0600AB09 RID: 43785 RVA: 0x0029A945 File Offset: 0x00298B45
		[DebuggerNonUserCode]
		public bool IsSuspended
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isSuspendedDefaultValue;
				if (flag)
				{
					isSuspendedDefaultValue = this.isSuspended_;
				}
				else
				{
					isSuspendedDefaultValue = GameStatus.IsSuspendedDefaultValue;
				}
				return isSuspendedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isSuspended_ = value;
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x0029A960 File Offset: 0x00298B60
		[DebuggerNonUserCode]
		public bool HasIsSuspended
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x0029A97D File Offset: 0x00298B7D
		[DebuggerNonUserCode]
		public void ClearIsSuspended()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x0029A990 File Offset: 0x00298B90
		// (set) Token: 0x0600AB0D RID: 43789 RVA: 0x0029A9C1 File Offset: 0x00298BC1
		[DebuggerNonUserCode]
		public bool IsBanned
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isBannedDefaultValue;
				if (flag)
				{
					isBannedDefaultValue = this.isBanned_;
				}
				else
				{
					isBannedDefaultValue = GameStatus.IsBannedDefaultValue;
				}
				return isBannedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isBanned_ = value;
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x0029A9DC File Offset: 0x00298BDC
		[DebuggerNonUserCode]
		public bool HasIsBanned
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x0029A9F9 File Offset: 0x00298BF9
		[DebuggerNonUserCode]
		public void ClearIsBanned()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x0029AA0C File Offset: 0x00298C0C
		// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x0029AA3D File Offset: 0x00298C3D
		[DebuggerNonUserCode]
		public ulong SuspensionExpires
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong suspensionExpiresDefaultValue;
				if (flag)
				{
					suspensionExpiresDefaultValue = this.suspensionExpires_;
				}
				else
				{
					suspensionExpiresDefaultValue = GameStatus.SuspensionExpiresDefaultValue;
				}
				return suspensionExpiresDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.suspensionExpires_ = value;
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x0029AA58 File Offset: 0x00298C58
		[DebuggerNonUserCode]
		public bool HasSuspensionExpires
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x0029AA75 File Offset: 0x00298C75
		[DebuggerNonUserCode]
		public void ClearSuspensionExpires()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600AB14 RID: 43796 RVA: 0x0029AA88 File Offset: 0x00298C88
		// (set) Token: 0x0600AB15 RID: 43797 RVA: 0x0029AAB9 File Offset: 0x00298CB9
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = GameStatus.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.program_ = value;
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x0029AAD4 File Offset: 0x00298CD4
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x0029AAF1 File Offset: 0x00298CF1
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x0029AB04 File Offset: 0x00298D04
		// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x0029AB36 File Offset: 0x00298D36
		[DebuggerNonUserCode]
		public bool IsLocked
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool isLockedDefaultValue;
				if (flag)
				{
					isLockedDefaultValue = this.isLocked_;
				}
				else
				{
					isLockedDefaultValue = GameStatus.IsLockedDefaultValue;
				}
				return isLockedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isLocked_ = value;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x0029AB50 File Offset: 0x00298D50
		[DebuggerNonUserCode]
		public bool HasIsLocked
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AB1B RID: 43803 RVA: 0x0029AB6E File Offset: 0x00298D6E
		[DebuggerNonUserCode]
		public void ClearIsLocked()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x0029AB80 File Offset: 0x00298D80
		// (set) Token: 0x0600AB1D RID: 43805 RVA: 0x0029ABB2 File Offset: 0x00298DB2
		[DebuggerNonUserCode]
		public bool IsBamUnlockable
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool isBamUnlockableDefaultValue;
				if (flag)
				{
					isBamUnlockableDefaultValue = this.isBamUnlockable_;
				}
				else
				{
					isBamUnlockableDefaultValue = GameStatus.IsBamUnlockableDefaultValue;
				}
				return isBamUnlockableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.isBamUnlockable_ = value;
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x0029ABCC File Offset: 0x00298DCC
		[DebuggerNonUserCode]
		public bool HasIsBamUnlockable
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x0029ABEA File Offset: 0x00298DEA
		[DebuggerNonUserCode]
		public void ClearIsBamUnlockable()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x0029ABFC File Offset: 0x00298DFC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatus);
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x0029AC1C File Offset: 0x00298E1C
		[DebuggerNonUserCode]
		public bool Equals(GameStatus other)
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
					bool flag4 = this.IsSuspended != other.IsSuspended;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsBanned != other.IsBanned;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SuspensionExpires != other.SuspensionExpires;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Program != other.Program;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsLocked != other.IsLocked;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.IsBamUnlockable != other.IsBamUnlockable;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x0029AD08 File Offset: 0x00298F08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsSuspended = this.HasIsSuspended;
			if (hasIsSuspended)
			{
				num ^= this.IsSuspended.GetHashCode();
			}
			bool hasIsBanned = this.HasIsBanned;
			if (hasIsBanned)
			{
				num ^= this.IsBanned.GetHashCode();
			}
			bool hasSuspensionExpires = this.HasSuspensionExpires;
			if (hasSuspensionExpires)
			{
				num ^= this.SuspensionExpires.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
			{
				num ^= this.IsLocked.GetHashCode();
			}
			bool hasIsBamUnlockable = this.HasIsBamUnlockable;
			if (hasIsBamUnlockable)
			{
				num ^= this.IsBamUnlockable.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x0029ADEC File Offset: 0x00298FEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x0029AE04 File Offset: 0x00299004
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x0029AE10 File Offset: 0x00299010
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsSuspended = this.HasIsSuspended;
			if (hasIsSuspended)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSuspended);
			}
			bool hasIsBanned = this.HasIsBanned;
			if (hasIsBanned)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsBanned);
			}
			bool hasSuspensionExpires = this.HasSuspensionExpires;
			if (hasSuspensionExpires)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.SuspensionExpires);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(61);
				output.WriteFixed32(this.Program);
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsLocked);
			}
			bool hasIsBamUnlockable = this.HasIsBamUnlockable;
			if (hasIsBamUnlockable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsBamUnlockable);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x0029AF0C File Offset: 0x0029910C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsSuspended = this.HasIsSuspended;
			if (hasIsSuspended)
			{
				num += 2;
			}
			bool hasIsBanned = this.HasIsBanned;
			if (hasIsBanned)
			{
				num += 2;
			}
			bool hasSuspensionExpires = this.HasSuspensionExpires;
			if (hasSuspensionExpires)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SuspensionExpires);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
			{
				num += 2;
			}
			bool hasIsBamUnlockable = this.HasIsBamUnlockable;
			if (hasIsBamUnlockable)
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

		// Token: 0x0600AB27 RID: 43815 RVA: 0x0029AFB4 File Offset: 0x002991B4
		[DebuggerNonUserCode]
		public void MergeFrom(GameStatus other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsSuspended = other.HasIsSuspended;
				if (hasIsSuspended)
				{
					this.IsSuspended = other.IsSuspended;
				}
				bool hasIsBanned = other.HasIsBanned;
				if (hasIsBanned)
				{
					this.IsBanned = other.IsBanned;
				}
				bool hasSuspensionExpires = other.HasSuspensionExpires;
				if (hasSuspensionExpires)
				{
					this.SuspensionExpires = other.SuspensionExpires;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasIsLocked = other.HasIsLocked;
				if (hasIsLocked)
				{
					this.IsLocked = other.IsLocked;
				}
				bool hasIsBamUnlockable = other.HasIsBamUnlockable;
				if (hasIsBamUnlockable)
				{
					this.IsBamUnlockable = other.IsBamUnlockable;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x0029B083 File Offset: 0x00299283
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x0029B090 File Offset: 0x00299290
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_003A;
							}
							this.SuspensionExpires = input.ReadUInt64();
						}
						else
						{
							this.IsBanned = input.ReadBool();
						}
					}
					else
					{
						this.IsSuspended = input.ReadBool();
					}
				}
				else if (num3 != 61U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							goto IL_003A;
						}
						this.IsBamUnlockable = input.ReadBool();
					}
					else
					{
						this.IsLocked = input.ReadBool();
					}
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D0B RID: 19723
		private static readonly MessageParser<GameStatus> _parser = new MessageParser<GameStatus>(() => new GameStatus());

		// Token: 0x04004D0C RID: 19724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D0D RID: 19725
		private int _hasBits0;

		// Token: 0x04004D0E RID: 19726
		public const int IsSuspendedFieldNumber = 4;

		// Token: 0x04004D0F RID: 19727
		private static readonly bool IsSuspendedDefaultValue = false;

		// Token: 0x04004D10 RID: 19728
		private bool isSuspended_;

		// Token: 0x04004D11 RID: 19729
		public const int IsBannedFieldNumber = 5;

		// Token: 0x04004D12 RID: 19730
		private static readonly bool IsBannedDefaultValue = false;

		// Token: 0x04004D13 RID: 19731
		private bool isBanned_;

		// Token: 0x04004D14 RID: 19732
		public const int SuspensionExpiresFieldNumber = 6;

		// Token: 0x04004D15 RID: 19733
		private static readonly ulong SuspensionExpiresDefaultValue = 0UL;

		// Token: 0x04004D16 RID: 19734
		private ulong suspensionExpires_;

		// Token: 0x04004D17 RID: 19735
		public const int ProgramFieldNumber = 7;

		// Token: 0x04004D18 RID: 19736
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004D19 RID: 19737
		private uint program_;

		// Token: 0x04004D1A RID: 19738
		public const int IsLockedFieldNumber = 8;

		// Token: 0x04004D1B RID: 19739
		private static readonly bool IsLockedDefaultValue = false;

		// Token: 0x04004D1C RID: 19740
		private bool isLocked_;

		// Token: 0x04004D1D RID: 19741
		public const int IsBamUnlockableFieldNumber = 9;

		// Token: 0x04004D1E RID: 19742
		private static readonly bool IsBamUnlockableDefaultValue = false;

		// Token: 0x04004D1F RID: 19743
		private bool isBamUnlockable_;
	}
}
