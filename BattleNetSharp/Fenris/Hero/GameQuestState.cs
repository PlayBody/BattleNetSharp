using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AA RID: 426
	public sealed class GameQuestState : IMessage<GameQuestState>, IMessage, IEquatable<GameQuestState>, IDeepCloneable<GameQuestState>, IBufferMessage
	{
		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000B0458 File Offset: 0x000AE658
		[DebuggerNonUserCode]
		public static MessageParser<GameQuestState> Parser
		{
			get
			{
				return GameQuestState._parser;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000B0470 File Offset: 0x000AE670
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000B0494 File Offset: 0x000AE694
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameQuestState.Descriptor;
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000B04AB File Offset: 0x000AE6AB
		[DebuggerNonUserCode]
		public GameQuestState()
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000B04B8 File Offset: 0x000AE6B8
		[DebuggerNonUserCode]
		public GameQuestState(GameQuestState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this.snoInstanceQuest_ = other.snoInstanceQuest_;
			this.phaseUid_ = other.phaseUid_;
			this.partyInstanceContentComplete_ = other.partyInstanceContentComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000B051C File Offset: 0x000AE71C
		[DebuggerNonUserCode]
		public GameQuestState Clone()
		{
			return new GameQuestState(this);
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000B0534 File Offset: 0x000AE734
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x000B0565 File Offset: 0x000AE765
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = GameQuestState.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000B0580 File Offset: 0x000AE780
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x000B059D File Offset: 0x000AE79D
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000B05B0 File Offset: 0x000AE7B0
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x000B05E1 File Offset: 0x000AE7E1
		[DebuggerNonUserCode]
		public int SnoInstanceQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoInstanceQuestDefaultValue;
				if (flag)
				{
					snoInstanceQuestDefaultValue = this.snoInstanceQuest_;
				}
				else
				{
					snoInstanceQuestDefaultValue = GameQuestState.SnoInstanceQuestDefaultValue;
				}
				return snoInstanceQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoInstanceQuest_ = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000B05FC File Offset: 0x000AE7FC
		[DebuggerNonUserCode]
		public bool HasSnoInstanceQuest
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000B0619 File Offset: 0x000AE819
		[DebuggerNonUserCode]
		public void ClearSnoInstanceQuest()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000B062C File Offset: 0x000AE82C
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x000B065D File Offset: 0x000AE85D
		[DebuggerNonUserCode]
		public int PhaseUid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int phaseUidDefaultValue;
				if (flag)
				{
					phaseUidDefaultValue = this.phaseUid_;
				}
				else
				{
					phaseUidDefaultValue = GameQuestState.PhaseUidDefaultValue;
				}
				return phaseUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.phaseUid_ = value;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000B0678 File Offset: 0x000AE878
		[DebuggerNonUserCode]
		public bool HasPhaseUid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000B0695 File Offset: 0x000AE895
		[DebuggerNonUserCode]
		public void ClearPhaseUid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000B06A8 File Offset: 0x000AE8A8
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x000B06D9 File Offset: 0x000AE8D9
		[DebuggerNonUserCode]
		public bool PartyInstanceContentComplete
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool partyInstanceContentCompleteDefaultValue;
				if (flag)
				{
					partyInstanceContentCompleteDefaultValue = this.partyInstanceContentComplete_;
				}
				else
				{
					partyInstanceContentCompleteDefaultValue = GameQuestState.PartyInstanceContentCompleteDefaultValue;
				}
				return partyInstanceContentCompleteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.partyInstanceContentComplete_ = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000B06F4 File Offset: 0x000AE8F4
		[DebuggerNonUserCode]
		public bool HasPartyInstanceContentComplete
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000B0711 File Offset: 0x000AE911
		[DebuggerNonUserCode]
		public void ClearPartyInstanceContentComplete()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000B0724 File Offset: 0x000AE924
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameQuestState);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000B0744 File Offset: 0x000AE944
		[DebuggerNonUserCode]
		public bool Equals(GameQuestState other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoInstanceQuest != other.SnoInstanceQuest;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PhaseUid != other.PhaseUid;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PartyInstanceContentComplete != other.PartyInstanceContentComplete;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000B07F0 File Offset: 0x000AE9F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				num ^= this.SnoInstanceQuest.GetHashCode();
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num ^= this.PhaseUid.GetHashCode();
			}
			bool hasPartyInstanceContentComplete = this.HasPartyInstanceContentComplete;
			if (hasPartyInstanceContentComplete)
			{
				num ^= this.PartyInstanceContentComplete.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000B0898 File Offset: 0x000AEA98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000B08B0 File Offset: 0x000AEAB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x000B08BC File Offset: 0x000AEABC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoInstanceQuest);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.PhaseUid);
			}
			bool hasPartyInstanceContentComplete = this.HasPartyInstanceContentComplete;
			if (hasPartyInstanceContentComplete)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PartyInstanceContentComplete);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000B0970 File Offset: 0x000AEB70
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 5;
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				num += 5;
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.PhaseUid);
			}
			bool hasPartyInstanceContentComplete = this.HasPartyInstanceContentComplete;
			if (hasPartyInstanceContentComplete)
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

		// Token: 0x06002D07 RID: 11527 RVA: 0x000B09F4 File Offset: 0x000AEBF4
		[DebuggerNonUserCode]
		public void MergeFrom(GameQuestState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasSnoInstanceQuest = other.HasSnoInstanceQuest;
				if (hasSnoInstanceQuest)
				{
					this.SnoInstanceQuest = other.SnoInstanceQuest;
				}
				bool hasPhaseUid = other.HasPhaseUid;
				if (hasPhaseUid)
				{
					this.PhaseUid = other.PhaseUid;
				}
				bool hasPartyInstanceContentComplete = other.HasPartyInstanceContentComplete;
				if (hasPartyInstanceContentComplete)
				{
					this.PartyInstanceContentComplete = other.PartyInstanceContentComplete;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000B0A8A File Offset: 0x000AEC8A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000B0A98 File Offset: 0x000AEC98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							goto IL_0029;
						}
						this.SnoInstanceQuest = input.ReadSFixed32();
					}
					else
					{
						this.SnoSubzone = input.ReadSFixed32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.PartyInstanceContentComplete = input.ReadBool();
				}
				else
				{
					this.PhaseUid = input.ReadSInt32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400144F RID: 5199
		private static readonly MessageParser<GameQuestState> _parser = new MessageParser<GameQuestState>(() => new GameQuestState());

		// Token: 0x04001450 RID: 5200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001451 RID: 5201
		private int _hasBits0;

		// Token: 0x04001452 RID: 5202
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x04001453 RID: 5203
		private static readonly int SnoSubzoneDefaultValue = -1;

		// Token: 0x04001454 RID: 5204
		private int snoSubzone_;

		// Token: 0x04001455 RID: 5205
		public const int SnoInstanceQuestFieldNumber = 2;

		// Token: 0x04001456 RID: 5206
		private static readonly int SnoInstanceQuestDefaultValue = -1;

		// Token: 0x04001457 RID: 5207
		private int snoInstanceQuest_;

		// Token: 0x04001458 RID: 5208
		public const int PhaseUidFieldNumber = 3;

		// Token: 0x04001459 RID: 5209
		private static readonly int PhaseUidDefaultValue = -1;

		// Token: 0x0400145A RID: 5210
		private int phaseUid_;

		// Token: 0x0400145B RID: 5211
		public const int PartyInstanceContentCompleteFieldNumber = 4;

		// Token: 0x0400145C RID: 5212
		private static readonly bool PartyInstanceContentCompleteDefaultValue = false;

		// Token: 0x0400145D RID: 5213
		private bool partyInstanceContentComplete_;
	}
}
