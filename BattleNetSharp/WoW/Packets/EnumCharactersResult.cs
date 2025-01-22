using System;
using System.Collections.Generic;
using D2Packets;
using Utilities;

namespace WoW.Packets
{
	// Token: 0x02000823 RID: 2083
	public class EnumCharactersResult : ServerPacket
	{
		// Token: 0x0600B551 RID: 46417 RVA: 0x002C3584 File Offset: 0x002C1784
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.Success = bitReader.ReadBit();
			this.IsDeletedCharacters = bitReader.ReadBit();
			this.IsNewPlayerRestrictionSkipped = bitReader.ReadBit();
			this.IsNewPlayerRestricted = bitReader.ReadBit();
			this.IsNewPlayer = bitReader.ReadBit();
			this.IsTrialAccountRestricted = bitReader.ReadBit();
			bool flag = bitReader.ReadBit();
			this.IsAlliedRacesCreationAllowed = bitReader.ReadBit();
			uint num = bitReader.ReadUInt32();
			this.MaxCharacterLevel = bitReader.ReadUInt32();
			uint num2 = bitReader.ReadUInt32();
			uint num3 = bitReader.ReadUInt32();
			uint num4 = bitReader.ReadUInt32();
			int num5 = 0;
			while ((long)num5 < (long)((ulong)num3))
			{
				this.UnlockedConditionalAppearances.Add(new EnumCharactersResult.UnlockedConditionalAppearance
				{
					BitReader = bitReader
				});
				num5++;
			}
			int num6 = 0;
			while ((long)num6 < (long)((ulong)num4))
			{
				this.RaceLimitDisables.Add(new EnumCharactersResult.RaceLimitDisableInfo
				{
					BitReader = bitReader
				});
				num6++;
			}
			int num7 = 0;
			while ((long)num7 < (long)((ulong)num))
			{
				this.Characters.Add(new EnumCharactersResult.CharacterInfo
				{
					BitReader = bitReader
				});
				num7++;
			}
			int num8 = 0;
			while ((long)num8 < (long)((ulong)num2))
			{
				this.RaceUnlocks.Add(new EnumCharactersResult.RaceUnlock
				{
					BitReader = bitReader
				});
				num8++;
			}
		}

		// Token: 0x04005B39 RID: 23353
		public bool Success;

		// Token: 0x04005B3A RID: 23354
		public bool IsDeletedCharacters;

		// Token: 0x04005B3B RID: 23355
		public bool IsNewPlayerRestrictionSkipped;

		// Token: 0x04005B3C RID: 23356
		public bool IsNewPlayerRestricted;

		// Token: 0x04005B3D RID: 23357
		public bool IsNewPlayer;

		// Token: 0x04005B3E RID: 23358
		public bool IsTrialAccountRestricted;

		// Token: 0x04005B3F RID: 23359
		public bool HasDisabledClassesMask;

		// Token: 0x04005B40 RID: 23360
		public bool IsAlliedRacesCreationAllowed;

		// Token: 0x04005B41 RID: 23361
		public uint MaxCharacterLevel;

		// Token: 0x04005B42 RID: 23362
		public List<EnumCharactersResult.UnlockedConditionalAppearance> UnlockedConditionalAppearances = new List<EnumCharactersResult.UnlockedConditionalAppearance>();

		// Token: 0x04005B43 RID: 23363
		public List<EnumCharactersResult.RaceLimitDisableInfo> RaceLimitDisables = new List<EnumCharactersResult.RaceLimitDisableInfo>();

		// Token: 0x04005B44 RID: 23364
		public List<EnumCharactersResult.CharacterInfo> Characters = new List<EnumCharactersResult.CharacterInfo>();

		// Token: 0x04005B45 RID: 23365
		public List<EnumCharactersResult.RaceUnlock> RaceUnlocks = new List<EnumCharactersResult.RaceUnlock>();

		// Token: 0x020012E4 RID: 4836
		public class CharacterInfo : Packet
		{
			// Token: 0x0600DE7E RID: 56958 RVA: 0x004C13D8 File Offset: 0x004BF5D8
			public override void FromBitReader(BitReader bitReader)
			{
				this.Guid = bitReader.ReadGuid();
				this.GuildClubMemberID = bitReader.ReadUInt64();
				this.ListPosition = bitReader.ReadByte();
				this.RaceId = (Race)bitReader.ReadByte();
				this.ClassId = (Class)bitReader.ReadByte();
				this.SexId = (Gender)bitReader.ReadByte();
				uint num = bitReader.ReadUInt32();
				this.ExperienceLevel = bitReader.ReadByte();
				this.ZoneId = bitReader.ReadUInt32();
				this.MapId = bitReader.ReadUInt32();
				this.PreloadPos = new Vector3
				{
					X = bitReader.ReadSingle(),
					Y = bitReader.ReadSingle(),
					Z = bitReader.ReadSingle()
				};
				this.GuildGuid = bitReader.ReadGuid();
				this.Flags = (CharacterFlags)bitReader.ReadUInt32();
				this.Flags2 = (CharacterCustomizeFlags)bitReader.ReadUInt32();
				this.Flags3 = bitReader.ReadUInt32();
				this.PetCreatureDisplayId = bitReader.ReadUInt32();
				this.PetExperienceLevel = bitReader.ReadUInt32();
				this.PetCreatureFamilyId = bitReader.ReadUInt32();
				this.ProfessionId1 = bitReader.ReadUInt32();
				this.ProfessionId2 = bitReader.ReadUInt32();
				uint num2 = (uint)new EnumCharactersResult.CharacterInfo.VisualItemInfo().ToArray().Length;
				for (int i = 0; i < 35; i++)
				{
					this.VisualItems.Add(new EnumCharactersResult.CharacterInfo.VisualItemInfo
					{
						Bytes = bitReader.ReadBytes(num2)
					});
				}
				this.LastPlayedTime = bitReader.ReadUInt64();
				this.SpecID = bitReader.ReadUInt16();
				this.Unknown703 = bitReader.ReadUInt32();
				this.InterfaceVersion = bitReader.ReadUInt32();
				this.Flags4 = bitReader.ReadUInt32();
				uint num3 = bitReader.ReadUInt32();
				uint num4 = bitReader.ReadUInt32();
				this.OverrideSelectScreenFileDataID = bitReader.ReadUInt32();
				int num5 = 0;
				while ((long)num5 < (long)((ulong)num))
				{
					this.Customizations.Add(new EnumCharactersResult.CharacterInfo.Customization
					{
						BitReader = bitReader
					});
					num5++;
				}
				int num6 = 0;
				while ((long)num6 < (long)((ulong)num4))
				{
					this.MailSenderTypes.Add(bitReader.ReadUInt32());
					num6++;
				}
				ulong num7 = bitReader.ReadBits(6) >> 2;
				this.FirstLogin = bitReader.ReadBit();
				this.BoostInProgress = bitReader.ReadBit();
				ulong num8 = bitReader.ReadBits(5);
				ulong num9 = bitReader.ReadBits(3);
				List<ulong> list = new List<ulong>();
				int num10 = 0;
				while ((long)num10 < (long)((ulong)num3))
				{
					list.Add(bitReader.ReadBits(6));
					num10++;
				}
				int num11 = 0;
				while ((long)num11 < (long)((ulong)num3))
				{
					bool flag = list[num11] > 1UL;
					if (flag)
					{
						this.MailSenders.Add(bitReader.ReadString((uint)list[num11]));
					}
					num11++;
				}
				this.Name = bitReader.ReadString((uint)num7);
			}

			// Token: 0x04009C67 RID: 40039
			public Guid Guid;

			// Token: 0x04009C68 RID: 40040
			public ulong GuildClubMemberID;

			// Token: 0x04009C69 RID: 40041
			public byte ListPosition;

			// Token: 0x04009C6A RID: 40042
			public Race RaceId;

			// Token: 0x04009C6B RID: 40043
			public Class ClassId;

			// Token: 0x04009C6C RID: 40044
			public Gender SexId;

			// Token: 0x04009C6D RID: 40045
			public byte ExperienceLevel;

			// Token: 0x04009C6E RID: 40046
			public uint ZoneId;

			// Token: 0x04009C6F RID: 40047
			public uint MapId;

			// Token: 0x04009C70 RID: 40048
			public Vector3 PreloadPos;

			// Token: 0x04009C71 RID: 40049
			public Guid GuildGuid;

			// Token: 0x04009C72 RID: 40050
			public CharacterFlags Flags;

			// Token: 0x04009C73 RID: 40051
			public CharacterCustomizeFlags Flags2;

			// Token: 0x04009C74 RID: 40052
			public uint Flags3;

			// Token: 0x04009C75 RID: 40053
			public uint PetCreatureDisplayId;

			// Token: 0x04009C76 RID: 40054
			public uint PetExperienceLevel;

			// Token: 0x04009C77 RID: 40055
			public uint PetCreatureFamilyId;

			// Token: 0x04009C78 RID: 40056
			public uint ProfessionId1;

			// Token: 0x04009C79 RID: 40057
			public uint ProfessionId2;

			// Token: 0x04009C7A RID: 40058
			public List<EnumCharactersResult.CharacterInfo.VisualItemInfo> VisualItems = new List<EnumCharactersResult.CharacterInfo.VisualItemInfo>(23);

			// Token: 0x04009C7B RID: 40059
			public ulong LastPlayedTime;

			// Token: 0x04009C7C RID: 40060
			public ushort SpecID;

			// Token: 0x04009C7D RID: 40061
			public uint Unknown703;

			// Token: 0x04009C7E RID: 40062
			public uint InterfaceVersion;

			// Token: 0x04009C7F RID: 40063
			public uint Flags4;

			// Token: 0x04009C80 RID: 40064
			public uint OverrideSelectScreenFileDataID;

			// Token: 0x04009C81 RID: 40065
			public List<EnumCharactersResult.CharacterInfo.Customization> Customizations = new List<EnumCharactersResult.CharacterInfo.Customization>();

			// Token: 0x04009C82 RID: 40066
			public List<uint> MailSenderTypes = new List<uint>();

			// Token: 0x04009C83 RID: 40067
			public bool FirstLogin;

			// Token: 0x04009C84 RID: 40068
			public bool BoostInProgress;

			// Token: 0x04009C85 RID: 40069
			public List<string> MailSenders = new List<string>();

			// Token: 0x04009C86 RID: 40070
			public string Name;

			// Token: 0x020014A1 RID: 5281
			public class Customization : Packet
			{
				// Token: 0x0400A51F RID: 42271
				public uint ChrCustomizationOptionID;

				// Token: 0x0400A520 RID: 42272
				public uint ChrCustomizationChoiceID;
			}

			// Token: 0x020014A2 RID: 5282
			public class VisualItemInfo : Packet
			{
				// Token: 0x0400A521 RID: 42273
				public uint DisplayId;

				// Token: 0x0400A522 RID: 42274
				public uint DisplayEnchantId;

				// Token: 0x0400A523 RID: 42275
				public uint SecondaryItemModifiedAppearanceID;

				// Token: 0x0400A524 RID: 42276
				public byte InvType;

				// Token: 0x0400A525 RID: 42277
				public byte Subclass;
			}

			// Token: 0x020014A3 RID: 5283
			public class PetInfo : Packet
			{
				// Token: 0x0400A526 RID: 42278
				public uint CreatureDisplayId;

				// Token: 0x0400A527 RID: 42279
				public uint Level;

				// Token: 0x0400A528 RID: 42280
				public uint CreatureFamily;
			}
		}

		// Token: 0x020012E5 RID: 4837
		public class RaceLimitDisableInfo : Packet
		{
			// Token: 0x04009C87 RID: 40071
			public int RaceID;

			// Token: 0x04009C88 RID: 40072
			public int BlockReason;
		}

		// Token: 0x020012E6 RID: 4838
		public class RaceUnlock : Packet
		{
			// Token: 0x04009C89 RID: 40073
			public int RaceID;

			// Token: 0x04009C8A RID: 40074
			public bool HasExpansion;

			// Token: 0x04009C8B RID: 40075
			public bool HasAchievement;

			// Token: 0x04009C8C RID: 40076
			public bool HasHeritageArmor;
		}

		// Token: 0x020012E7 RID: 4839
		public class UnlockedConditionalAppearance : Packet
		{
			// Token: 0x04009C8D RID: 40077
			public int AchievementID;

			// Token: 0x04009C8E RID: 40078
			public int Unused;
		}
	}
}
