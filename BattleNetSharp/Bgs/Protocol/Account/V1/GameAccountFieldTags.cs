using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000738 RID: 1848
	public sealed class GameAccountFieldTags : IMessage<GameAccountFieldTags>, IMessage, IEquatable<GameAccountFieldTags>, IDeepCloneable<GameAccountFieldTags>, IBufferMessage
	{
		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x00293048 File Offset: 0x00291248
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountFieldTags> Parser
		{
			get
			{
				return GameAccountFieldTags._parser;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600A91D RID: 43293 RVA: 0x00293060 File Offset: 0x00291260
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x00293084 File Offset: 0x00291284
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFieldTags.Descriptor;
			}
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x0029309B File Offset: 0x0029129B
		[DebuggerNonUserCode]
		public GameAccountFieldTags()
		{
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x002930A8 File Offset: 0x002912A8
		[DebuggerNonUserCode]
		public GameAccountFieldTags(GameAccountFieldTags other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameLevelInfoTag_ = other.gameLevelInfoTag_;
			this.gameTimeInfoTag_ = other.gameTimeInfoTag_;
			this.gameStatusTag_ = other.gameStatusTag_;
			this.rafInfoTag_ = other.rafInfoTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x0029310C File Offset: 0x0029130C
		[DebuggerNonUserCode]
		public GameAccountFieldTags Clone()
		{
			return new GameAccountFieldTags(this);
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600A922 RID: 43298 RVA: 0x00293124 File Offset: 0x00291324
		// (set) Token: 0x0600A923 RID: 43299 RVA: 0x00293155 File Offset: 0x00291355
		[DebuggerNonUserCode]
		public uint GameLevelInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameLevelInfoTagDefaultValue;
				if (flag)
				{
					gameLevelInfoTagDefaultValue = this.gameLevelInfoTag_;
				}
				else
				{
					gameLevelInfoTagDefaultValue = GameAccountFieldTags.GameLevelInfoTagDefaultValue;
				}
				return gameLevelInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameLevelInfoTag_ = value;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x00293170 File Offset: 0x00291370
		[DebuggerNonUserCode]
		public bool HasGameLevelInfoTag
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x0029318D File Offset: 0x0029138D
		[DebuggerNonUserCode]
		public void ClearGameLevelInfoTag()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x002931A0 File Offset: 0x002913A0
		// (set) Token: 0x0600A927 RID: 43303 RVA: 0x002931D1 File Offset: 0x002913D1
		[DebuggerNonUserCode]
		public uint GameTimeInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gameTimeInfoTagDefaultValue;
				if (flag)
				{
					gameTimeInfoTagDefaultValue = this.gameTimeInfoTag_;
				}
				else
				{
					gameTimeInfoTagDefaultValue = GameAccountFieldTags.GameTimeInfoTagDefaultValue;
				}
				return gameTimeInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameTimeInfoTag_ = value;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600A928 RID: 43304 RVA: 0x002931EC File Offset: 0x002913EC
		[DebuggerNonUserCode]
		public bool HasGameTimeInfoTag
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x00293209 File Offset: 0x00291409
		[DebuggerNonUserCode]
		public void ClearGameTimeInfoTag()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x0029321C File Offset: 0x0029141C
		// (set) Token: 0x0600A92B RID: 43307 RVA: 0x0029324D File Offset: 0x0029144D
		[DebuggerNonUserCode]
		public uint GameStatusTag
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint gameStatusTagDefaultValue;
				if (flag)
				{
					gameStatusTagDefaultValue = this.gameStatusTag_;
				}
				else
				{
					gameStatusTagDefaultValue = GameAccountFieldTags.GameStatusTagDefaultValue;
				}
				return gameStatusTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameStatusTag_ = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x00293268 File Offset: 0x00291468
		[DebuggerNonUserCode]
		public bool HasGameStatusTag
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A92D RID: 43309 RVA: 0x00293285 File Offset: 0x00291485
		[DebuggerNonUserCode]
		public void ClearGameStatusTag()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600A92E RID: 43310 RVA: 0x00293298 File Offset: 0x00291498
		// (set) Token: 0x0600A92F RID: 43311 RVA: 0x002932C9 File Offset: 0x002914C9
		[DebuggerNonUserCode]
		public uint RafInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint rafInfoTagDefaultValue;
				if (flag)
				{
					rafInfoTagDefaultValue = this.rafInfoTag_;
				}
				else
				{
					rafInfoTagDefaultValue = GameAccountFieldTags.RafInfoTagDefaultValue;
				}
				return rafInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.rafInfoTag_ = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x002932E4 File Offset: 0x002914E4
		[DebuggerNonUserCode]
		public bool HasRafInfoTag
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x00293301 File Offset: 0x00291501
		[DebuggerNonUserCode]
		public void ClearRafInfoTag()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x00293314 File Offset: 0x00291514
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFieldTags);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x00293334 File Offset: 0x00291534
		[DebuggerNonUserCode]
		public bool Equals(GameAccountFieldTags other)
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
					bool flag4 = this.GameLevelInfoTag != other.GameLevelInfoTag;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameTimeInfoTag != other.GameTimeInfoTag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameStatusTag != other.GameStatusTag;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RafInfoTag != other.RafInfoTag;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x002933E0 File Offset: 0x002915E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameLevelInfoTag = this.HasGameLevelInfoTag;
			if (hasGameLevelInfoTag)
			{
				num ^= this.GameLevelInfoTag.GetHashCode();
			}
			bool hasGameTimeInfoTag = this.HasGameTimeInfoTag;
			if (hasGameTimeInfoTag)
			{
				num ^= this.GameTimeInfoTag.GetHashCode();
			}
			bool hasGameStatusTag = this.HasGameStatusTag;
			if (hasGameStatusTag)
			{
				num ^= this.GameStatusTag.GetHashCode();
			}
			bool hasRafInfoTag = this.HasRafInfoTag;
			if (hasRafInfoTag)
			{
				num ^= this.RafInfoTag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x00293488 File Offset: 0x00291688
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x002934A0 File Offset: 0x002916A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x002934AC File Offset: 0x002916AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameLevelInfoTag = this.HasGameLevelInfoTag;
			if (hasGameLevelInfoTag)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.GameLevelInfoTag);
			}
			bool hasGameTimeInfoTag = this.HasGameTimeInfoTag;
			if (hasGameTimeInfoTag)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.GameTimeInfoTag);
			}
			bool hasGameStatusTag = this.HasGameStatusTag;
			if (hasGameStatusTag)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.GameStatusTag);
			}
			bool hasRafInfoTag = this.HasRafInfoTag;
			if (hasRafInfoTag)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.RafInfoTag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x00293560 File Offset: 0x00291760
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameLevelInfoTag = this.HasGameLevelInfoTag;
			if (hasGameLevelInfoTag)
			{
				num += 5;
			}
			bool hasGameTimeInfoTag = this.HasGameTimeInfoTag;
			if (hasGameTimeInfoTag)
			{
				num += 5;
			}
			bool hasGameStatusTag = this.HasGameStatusTag;
			if (hasGameStatusTag)
			{
				num += 5;
			}
			bool hasRafInfoTag = this.HasRafInfoTag;
			if (hasRafInfoTag)
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

		// Token: 0x0600A939 RID: 43321 RVA: 0x002935D8 File Offset: 0x002917D8
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountFieldTags other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameLevelInfoTag = other.HasGameLevelInfoTag;
				if (hasGameLevelInfoTag)
				{
					this.GameLevelInfoTag = other.GameLevelInfoTag;
				}
				bool hasGameTimeInfoTag = other.HasGameTimeInfoTag;
				if (hasGameTimeInfoTag)
				{
					this.GameTimeInfoTag = other.GameTimeInfoTag;
				}
				bool hasGameStatusTag = other.HasGameStatusTag;
				if (hasGameStatusTag)
				{
					this.GameStatusTag = other.GameStatusTag;
				}
				bool hasRafInfoTag = other.HasRafInfoTag;
				if (hasRafInfoTag)
				{
					this.RafInfoTag = other.RafInfoTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x0029366E File Offset: 0x0029186E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x0029367C File Offset: 0x0029187C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 21U)
					{
						if (num3 != 29U)
						{
							goto IL_0029;
						}
						this.GameTimeInfoTag = input.ReadFixed32();
					}
					else
					{
						this.GameLevelInfoTag = input.ReadFixed32();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 45U)
					{
						goto IL_0029;
					}
					this.RafInfoTag = input.ReadFixed32();
				}
				else
				{
					this.GameStatusTag = input.ReadFixed32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C05 RID: 19461
		private static readonly MessageParser<GameAccountFieldTags> _parser = new MessageParser<GameAccountFieldTags>(() => new GameAccountFieldTags());

		// Token: 0x04004C06 RID: 19462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C07 RID: 19463
		private int _hasBits0;

		// Token: 0x04004C08 RID: 19464
		public const int GameLevelInfoTagFieldNumber = 2;

		// Token: 0x04004C09 RID: 19465
		private static readonly uint GameLevelInfoTagDefaultValue = 0U;

		// Token: 0x04004C0A RID: 19466
		private uint gameLevelInfoTag_;

		// Token: 0x04004C0B RID: 19467
		public const int GameTimeInfoTagFieldNumber = 3;

		// Token: 0x04004C0C RID: 19468
		private static readonly uint GameTimeInfoTagDefaultValue = 0U;

		// Token: 0x04004C0D RID: 19469
		private uint gameTimeInfoTag_;

		// Token: 0x04004C0E RID: 19470
		public const int GameStatusTagFieldNumber = 4;

		// Token: 0x04004C0F RID: 19471
		private static readonly uint GameStatusTagDefaultValue = 0U;

		// Token: 0x04004C10 RID: 19472
		private uint gameStatusTag_;

		// Token: 0x04004C11 RID: 19473
		public const int RafInfoTagFieldNumber = 5;

		// Token: 0x04004C12 RID: 19474
		private static readonly uint RafInfoTagDefaultValue = 0U;

		// Token: 0x04004C13 RID: 19475
		private uint rafInfoTag_;
	}
}
