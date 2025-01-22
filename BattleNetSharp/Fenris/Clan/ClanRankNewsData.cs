using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B9 RID: 697
	public sealed class ClanRankNewsData : IMessage<ClanRankNewsData>, IMessage, IEquatable<ClanRankNewsData>, IDeepCloneable<ClanRankNewsData>, IBufferMessage
	{
		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06004A46 RID: 19014 RVA: 0x0011CB18 File Offset: 0x0011AD18
		[DebuggerNonUserCode]
		public static MessageParser<ClanRankNewsData> Parser
		{
			get
			{
				return ClanRankNewsData._parser;
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06004A47 RID: 19015 RVA: 0x0011CB30 File Offset: 0x0011AD30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x0011CB54 File Offset: 0x0011AD54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanRankNewsData.Descriptor;
			}
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0011CB6B File Offset: 0x0011AD6B
		[DebuggerNonUserCode]
		public ClanRankNewsData()
		{
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0011CB75 File Offset: 0x0011AD75
		[DebuggerNonUserCode]
		public ClanRankNewsData(ClanRankNewsData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.newRank_ = other.newRank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0011CBA8 File Offset: 0x0011ADA8
		[DebuggerNonUserCode]
		public ClanRankNewsData Clone()
		{
			return new ClanRankNewsData(this);
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x0011CBC0 File Offset: 0x0011ADC0
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x0011CBF1 File Offset: 0x0011ADF1
		[DebuggerNonUserCode]
		public uint NewRank
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint newRankDefaultValue;
				if (flag)
				{
					newRankDefaultValue = this.newRank_;
				}
				else
				{
					newRankDefaultValue = ClanRankNewsData.NewRankDefaultValue;
				}
				return newRankDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.newRank_ = value;
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x0011CC0C File Offset: 0x0011AE0C
		[DebuggerNonUserCode]
		public bool HasNewRank
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x0011CC29 File Offset: 0x0011AE29
		[DebuggerNonUserCode]
		public void ClearNewRank()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x0011CC3C File Offset: 0x0011AE3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanRankNewsData);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x0011CC5C File Offset: 0x0011AE5C
		[DebuggerNonUserCode]
		public bool Equals(ClanRankNewsData other)
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
					bool flag4 = this.NewRank != other.NewRank;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x0011CCB4 File Offset: 0x0011AEB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNewRank = this.HasNewRank;
			if (hasNewRank)
			{
				num ^= this.NewRank.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0011CD04 File Offset: 0x0011AF04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x0011CD1C File Offset: 0x0011AF1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0011CD28 File Offset: 0x0011AF28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNewRank = this.HasNewRank;
			if (hasNewRank)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NewRank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x0011CD74 File Offset: 0x0011AF74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNewRank = this.HasNewRank;
			if (hasNewRank)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NewRank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0011CDC4 File Offset: 0x0011AFC4
		[DebuggerNonUserCode]
		public void MergeFrom(ClanRankNewsData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNewRank = other.HasNewRank;
				if (hasNewRank)
				{
					this.NewRank = other.NewRank;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0011CE0D File Offset: 0x0011B00D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0011CE18 File Offset: 0x0011B018
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
					this.NewRank = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002135 RID: 8501
		private static readonly MessageParser<ClanRankNewsData> _parser = new MessageParser<ClanRankNewsData>(() => new ClanRankNewsData());

		// Token: 0x04002136 RID: 8502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002137 RID: 8503
		private int _hasBits0;

		// Token: 0x04002138 RID: 8504
		public const int NewRankFieldNumber = 1;

		// Token: 0x04002139 RID: 8505
		private static readonly uint NewRankDefaultValue = 0U;

		// Token: 0x0400213A RID: 8506
		private uint newRank_;
	}
}
