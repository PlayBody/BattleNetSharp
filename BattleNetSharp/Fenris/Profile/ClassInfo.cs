using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000132 RID: 306
	public sealed class ClassInfo : IMessage<ClassInfo>, IMessage, IEquatable<ClassInfo>, IDeepCloneable<ClassInfo>, IBufferMessage
	{
		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x000761F8 File Offset: 0x000743F8
		[DebuggerNonUserCode]
		public static MessageParser<ClassInfo> Parser
		{
			get
			{
				return ClassInfo._parser;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00076210 File Offset: 0x00074410
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00076234 File Offset: 0x00074434
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClassInfo.Descriptor;
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0007624B File Offset: 0x0007444B
		[DebuggerNonUserCode]
		public ClassInfo()
		{
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00076255 File Offset: 0x00074455
		[DebuggerNonUserCode]
		public ClassInfo(ClassInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.playtime_ = other.playtime_;
			this.highestLevel_ = other.highestLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00076294 File Offset: 0x00074494
		[DebuggerNonUserCode]
		public ClassInfo Clone()
		{
			return new ClassInfo(this);
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000762AC File Offset: 0x000744AC
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000762DD File Offset: 0x000744DD
		[DebuggerNonUserCode]
		public ulong Playtime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong playtimeDefaultValue;
				if (flag)
				{
					playtimeDefaultValue = this.playtime_;
				}
				else
				{
					playtimeDefaultValue = ClassInfo.PlaytimeDefaultValue;
				}
				return playtimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.playtime_ = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000762F8 File Offset: 0x000744F8
		[DebuggerNonUserCode]
		public bool HasPlaytime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00076315 File Offset: 0x00074515
		[DebuggerNonUserCode]
		public void ClearPlaytime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00076328 File Offset: 0x00074528
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00076359 File Offset: 0x00074559
		[DebuggerNonUserCode]
		public uint HighestLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint highestLevelDefaultValue;
				if (flag)
				{
					highestLevelDefaultValue = this.highestLevel_;
				}
				else
				{
					highestLevelDefaultValue = ClassInfo.HighestLevelDefaultValue;
				}
				return highestLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.highestLevel_ = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00076374 File Offset: 0x00074574
		[DebuggerNonUserCode]
		public bool HasHighestLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00076391 File Offset: 0x00074591
		[DebuggerNonUserCode]
		public void ClearHighestLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000763A4 File Offset: 0x000745A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClassInfo);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000763C4 File Offset: 0x000745C4
		[DebuggerNonUserCode]
		public bool Equals(ClassInfo other)
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
					bool flag4 = this.Playtime != other.Playtime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HighestLevel != other.HighestLevel;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00076438 File Offset: 0x00074638
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlaytime = this.HasPlaytime;
			if (hasPlaytime)
			{
				num ^= this.Playtime.GetHashCode();
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num ^= this.HighestLevel.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000764A8 File Offset: 0x000746A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000764C0 File Offset: 0x000746C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000764CC File Offset: 0x000746CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlaytime = this.HasPlaytime;
			if (hasPlaytime)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Playtime);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HighestLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0007653C File Offset: 0x0007473C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlaytime = this.HasPlaytime;
			if (hasPlaytime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Playtime);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HighestLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000765A8 File Offset: 0x000747A8
		[DebuggerNonUserCode]
		public void MergeFrom(ClassInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlaytime = other.HasPlaytime;
				if (hasPlaytime)
				{
					this.Playtime = other.Playtime;
				}
				bool hasHighestLevel = other.HasHighestLevel;
				if (hasHighestLevel)
				{
					this.HighestLevel = other.HighestLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0007660A File Offset: 0x0007480A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00076618 File Offset: 0x00074818
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HighestLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.Playtime = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04000D3F RID: 3391
		private static readonly MessageParser<ClassInfo> _parser = new MessageParser<ClassInfo>(() => new ClassInfo());

		// Token: 0x04000D40 RID: 3392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D41 RID: 3393
		private int _hasBits0;

		// Token: 0x04000D42 RID: 3394
		public const int PlaytimeFieldNumber = 1;

		// Token: 0x04000D43 RID: 3395
		private static readonly ulong PlaytimeDefaultValue = 0UL;

		// Token: 0x04000D44 RID: 3396
		private ulong playtime_;

		// Token: 0x04000D45 RID: 3397
		public const int HighestLevelFieldNumber = 2;

		// Token: 0x04000D46 RID: 3398
		private static readonly uint HighestLevelDefaultValue = 0U;

		// Token: 0x04000D47 RID: 3399
		private uint highestLevel_;
	}
}
