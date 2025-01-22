using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C7 RID: 711
	public sealed class AchievementsResetDate : IMessage<AchievementsResetDate>, IMessage, IEquatable<AchievementsResetDate>, IDeepCloneable<AchievementsResetDate>, IBufferMessage
	{
		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x001211D0 File Offset: 0x0011F3D0
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsResetDate> Parser
		{
			get
			{
				return AchievementsResetDate._parser;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x001211E8 File Offset: 0x0011F3E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x0012120C File Offset: 0x0011F40C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementsResetDate.Descriptor;
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00121223 File Offset: 0x0011F423
		[DebuggerNonUserCode]
		public AchievementsResetDate()
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0012122D File Offset: 0x0011F42D
		[DebuggerNonUserCode]
		public AchievementsResetDate(AchievementsResetDate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.date_ = other.date_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x00121260 File Offset: 0x0011F460
		[DebuggerNonUserCode]
		public AchievementsResetDate Clone()
		{
			return new AchievementsResetDate(this);
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x00121278 File Offset: 0x0011F478
		// (set) Token: 0x06004B8D RID: 19341 RVA: 0x001212A9 File Offset: 0x0011F4A9
		[DebuggerNonUserCode]
		public long Date
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long dateDefaultValue;
				if (flag)
				{
					dateDefaultValue = this.date_;
				}
				else
				{
					dateDefaultValue = AchievementsResetDate.DateDefaultValue;
				}
				return dateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.date_ = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x001212C4 File Offset: 0x0011F4C4
		[DebuggerNonUserCode]
		public bool HasDate
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x001212E1 File Offset: 0x0011F4E1
		[DebuggerNonUserCode]
		public void ClearDate()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x001212F4 File Offset: 0x0011F4F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementsResetDate);
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x00121314 File Offset: 0x0011F514
		[DebuggerNonUserCode]
		public bool Equals(AchievementsResetDate other)
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
					bool flag4 = this.Date != other.Date;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x0012136C File Offset: 0x0011F56C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDate = this.HasDate;
			if (hasDate)
			{
				num ^= this.Date.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x001213BC File Offset: 0x0011F5BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x001213D4 File Offset: 0x0011F5D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x001213E0 File Offset: 0x0011F5E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDate = this.HasDate;
			if (hasDate)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Date);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0012142C File Offset: 0x0011F62C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDate = this.HasDate;
			if (hasDate)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Date);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x0012147C File Offset: 0x0011F67C
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementsResetDate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDate = other.HasDate;
				if (hasDate)
				{
					this.Date = other.Date;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x001214C5 File Offset: 0x0011F6C5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x001214D0 File Offset: 0x0011F6D0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Date = input.ReadInt64();
				}
			}
		}

		// Token: 0x040021B8 RID: 8632
		private static readonly MessageParser<AchievementsResetDate> _parser = new MessageParser<AchievementsResetDate>(() => new AchievementsResetDate());

		// Token: 0x040021B9 RID: 8633
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021BA RID: 8634
		private int _hasBits0;

		// Token: 0x040021BB RID: 8635
		public const int DateFieldNumber = 1;

		// Token: 0x040021BC RID: 8636
		private static readonly long DateDefaultValue = 0L;

		// Token: 0x040021BD RID: 8637
		private long date_;
	}
}
