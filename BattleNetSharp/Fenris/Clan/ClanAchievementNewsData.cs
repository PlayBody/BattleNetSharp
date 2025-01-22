using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B8 RID: 696
	public sealed class ClanAchievementNewsData : IMessage<ClanAchievementNewsData>, IMessage, IEquatable<ClanAchievementNewsData>, IDeepCloneable<ClanAchievementNewsData>, IBufferMessage
	{
		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x0011C7B0 File Offset: 0x0011A9B0
		[DebuggerNonUserCode]
		public static MessageParser<ClanAchievementNewsData> Parser
		{
			get
			{
				return ClanAchievementNewsData._parser;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06004A32 RID: 18994 RVA: 0x0011C7C8 File Offset: 0x0011A9C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x0011C7EC File Offset: 0x0011A9EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanAchievementNewsData.Descriptor;
			}
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x0011C803 File Offset: 0x0011AA03
		[DebuggerNonUserCode]
		public ClanAchievementNewsData()
		{
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x0011C80D File Offset: 0x0011AA0D
		[DebuggerNonUserCode]
		public ClanAchievementNewsData(ClanAchievementNewsData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.achievementSno_ = other.achievementSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x0011C840 File Offset: 0x0011AA40
		[DebuggerNonUserCode]
		public ClanAchievementNewsData Clone()
		{
			return new ClanAchievementNewsData(this);
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x0011C858 File Offset: 0x0011AA58
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x0011C889 File Offset: 0x0011AA89
		[DebuggerNonUserCode]
		public int AchievementSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int achievementSnoDefaultValue;
				if (flag)
				{
					achievementSnoDefaultValue = this.achievementSno_;
				}
				else
				{
					achievementSnoDefaultValue = ClanAchievementNewsData.AchievementSnoDefaultValue;
				}
				return achievementSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.achievementSno_ = value;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x0011C8A4 File Offset: 0x0011AAA4
		[DebuggerNonUserCode]
		public bool HasAchievementSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x0011C8C1 File Offset: 0x0011AAC1
		[DebuggerNonUserCode]
		public void ClearAchievementSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x0011C8D4 File Offset: 0x0011AAD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanAchievementNewsData);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0011C8F4 File Offset: 0x0011AAF4
		[DebuggerNonUserCode]
		public bool Equals(ClanAchievementNewsData other)
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
					bool flag4 = this.AchievementSno != other.AchievementSno;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0011C94C File Offset: 0x0011AB4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num ^= this.AchievementSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0011C99C File Offset: 0x0011AB9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0011C9B4 File Offset: 0x0011ABB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0011C9C0 File Offset: 0x0011ABC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.AchievementSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0011CA0C File Offset: 0x0011AC0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0011CA50 File Offset: 0x0011AC50
		[DebuggerNonUserCode]
		public void MergeFrom(ClanAchievementNewsData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAchievementSno = other.HasAchievementSno;
				if (hasAchievementSno)
				{
					this.AchievementSno = other.AchievementSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0011CA99 File Offset: 0x0011AC99
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x0011CAA4 File Offset: 0x0011ACA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AchievementSno = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x0400212F RID: 8495
		private static readonly MessageParser<ClanAchievementNewsData> _parser = new MessageParser<ClanAchievementNewsData>(() => new ClanAchievementNewsData());

		// Token: 0x04002130 RID: 8496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002131 RID: 8497
		private int _hasBits0;

		// Token: 0x04002132 RID: 8498
		public const int AchievementSnoFieldNumber = 1;

		// Token: 0x04002133 RID: 8499
		private static readonly int AchievementSnoDefaultValue = 0;

		// Token: 0x04002134 RID: 8500
		private int achievementSno_;
	}
}
