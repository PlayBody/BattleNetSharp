using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DB RID: 475
	public sealed class AchievementsResetAchievements : IMessage<AchievementsResetAchievements>, IMessage, IEquatable<AchievementsResetAchievements>, IDeepCloneable<AchievementsResetAchievements>, IBufferMessage
	{
		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x000CBA90 File Offset: 0x000C9C90
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsResetAchievements> Parser
		{
			get
			{
				return AchievementsResetAchievements._parser;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x000CBAA8 File Offset: 0x000C9CA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x000CBACC File Offset: 0x000C9CCC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementsResetAchievements.Descriptor;
			}
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000CBAE3 File Offset: 0x000C9CE3
		[DebuggerNonUserCode]
		public AchievementsResetAchievements()
		{
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000CBAED File Offset: 0x000C9CED
		[DebuggerNonUserCode]
		public AchievementsResetAchievements(AchievementsResetAchievements other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000CBB20 File Offset: 0x000C9D20
		[DebuggerNonUserCode]
		public AchievementsResetAchievements Clone()
		{
			return new AchievementsResetAchievements(this);
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000CBB38 File Offset: 0x000C9D38
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x000CBB69 File Offset: 0x000C9D69
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = AchievementsResetAchievements.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000CBB84 File Offset: 0x000C9D84
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000CBBA1 File Offset: 0x000C9DA1
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000CBBB4 File Offset: 0x000C9DB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementsResetAchievements);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000CBBD4 File Offset: 0x000C9DD4
		[DebuggerNonUserCode]
		public bool Equals(AchievementsResetAchievements other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000CBC2C File Offset: 0x000C9E2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x000CBC7C File Offset: 0x000C9E7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x000CBC94 File Offset: 0x000C9E94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000CBCA0 File Offset: 0x000C9EA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000CBCEC File Offset: 0x000C9EEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000CBD3C File Offset: 0x000C9F3C
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementsResetAchievements other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000CBD85 File Offset: 0x000C9F85
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000CBD90 File Offset: 0x000C9F90
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
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017BF RID: 6079
		private static readonly MessageParser<AchievementsResetAchievements> _parser = new MessageParser<AchievementsResetAchievements>(() => new AchievementsResetAchievements());

		// Token: 0x040017C0 RID: 6080
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017C1 RID: 6081
		private int _hasBits0;

		// Token: 0x040017C2 RID: 6082
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040017C3 RID: 6083
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040017C4 RID: 6084
		private uint gameAccountId_;
	}
}
