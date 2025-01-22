using System;
using System.Collections.Generic;
using System.IO;
using D2Data;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x020009CE RID: 2510
	public class MultipleStates : Packet
	{
		// Token: 0x0600BAF1 RID: 47857 RVA: 0x00471674 File Offset: 0x0046F874
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.Write((byte)this.PacketId);
			bitWriter.Write((byte)this.Type);
			bitWriter.Write(this.Id);
			bitWriter.Write(0);
			foreach (MultipleStates.NPCState npcstate in this.States)
			{
				bitWriter.WriteBits((uint)npcstate.State.Id, 8);
				bool flag = base.PacketVersion == GameVersion.D2R;
				if (flag)
				{
					bitWriter.WriteBits(0U, 3);
				}
				bitWriter.WriteBits((npcstate.Stats.Count == 0) ? 0U : 1U, 1);
				foreach (StatBase statBase in npcstate.Stats)
				{
					bitWriter.WriteBits((uint)statBase.BaseStat.Index, 9);
					int num = ((base.PacketVersion == GameVersion.LOD) ? statBase.BaseStat.SendParamBits : statBase.BaseStat.SendParamBits_2_6);
					bool flag2 = num > 0;
					if (flag2)
					{
						bool signed = statBase.BaseStat.Signed;
						if (signed)
						{
							bitWriter.WriteBits((uint)((SignedStatParam)statBase).Value, statBase.BaseStat.SendBits);
							bitWriter.WriteBits((uint)((SignedStatParam)statBase).Param, num);
						}
						else
						{
							bitWriter.WriteBits(((UnsignedStatParam)statBase).Value, statBase.BaseStat.SendBits);
							bitWriter.WriteBits(((UnsignedStatParam)statBase).Param, num);
						}
					}
					else
					{
						bool signed2 = statBase.BaseStat.Signed;
						if (signed2)
						{
							bitWriter.WriteBits((uint)((SignedStat)statBase).Value, statBase.BaseStat.SendBits);
						}
						else
						{
							bitWriter.WriteBits(((UnsignedStat)statBase).Value, statBase.BaseStat.SendBits);
						}
					}
				}
				bool flag3 = npcstate.Stats.Count > 0;
				if (flag3)
				{
					bitWriter.WriteBits(511U, 9);
				}
			}
			bitWriter.WriteBits(255U, 8);
			bool flag4 = base.PacketVersion == GameVersion.D2R;
			if (flag4)
			{
				bitWriter.WriteBits(7U, 3);
			}
			bitWriter.Flush();
			byte[] array = this.memoryStream.ToArray();
			array[6] = (byte)array.Length;
			return array;
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x00471940 File Offset: 0x0046FB40
		public override void FromBytes(byte[] data)
		{
			BitReader bitReader = new BitReader(data, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Type = (UnitType)bitReader.ReadByte();
			this.Id = bitReader.ReadUInt32();
			this.Length = bitReader.ReadByte();
			this.States = new List<MultipleStates.NPCState>();
			for (;;)
			{
				int num = (int)bitReader.ReadBits((base.PacketVersion == GameVersion.D2R) ? 9 : 8);
				bool flag = num == ((base.PacketVersion == GameVersion.D2R) ? 511 : 255);
				if (flag)
				{
					break;
				}
				ulong num2 = bitReader.ReadBits((base.PacketVersion == GameVersion.D2R) ? 1 : 1);
				bool flag2 = num2 == 0UL;
				if (flag2)
				{
					this.States.Add(new MultipleStates.NPCState(BaseState.Get(num)));
				}
				else
				{
					List<StatBase> list = new List<StatBase>();
					for (;;)
					{
						int num3 = (int)bitReader.ReadBits(9);
						bool flag3 = num3 == 511;
						if (flag3)
						{
							break;
						}
						BaseStat baseStat = BaseStat.Get(num3);
						int num4 = (int)bitReader.ReadBits(baseStat.SendBits);
						int num5 = ((base.PacketVersion == GameVersion.LOD) ? baseStat.SendParamBits : baseStat.SendParamBits_2_6);
						bool flag4 = num5 > 0;
						if (flag4)
						{
							int num6 = (int)bitReader.ReadBits(num5);
							bool signed = baseStat.Signed;
							if (signed)
							{
								list.Add(new SignedStatParam(baseStat, num4, num6));
							}
							else
							{
								list.Add(new UnsignedStatParam(baseStat, (uint)num4, (uint)num6));
							}
						}
						else
						{
							bool signed2 = baseStat.Signed;
							if (signed2)
							{
								list.Add(new SignedStat(baseStat, num4));
							}
							else
							{
								list.Add(new UnsignedStat(baseStat, (uint)num4));
							}
						}
					}
					this.States.Add(new MultipleStates.NPCState(BaseState.Get(num), list));
				}
			}
		}

		// Token: 0x04008AC0 RID: 35520
		public GameServerPacket PacketId;

		// Token: 0x04008AC1 RID: 35521
		public UnitType Type;

		// Token: 0x04008AC2 RID: 35522
		public uint Id;

		// Token: 0x04008AC3 RID: 35523
		public byte Length;

		// Token: 0x04008AC4 RID: 35524
		public List<MultipleStates.NPCState> States;

		// Token: 0x02001354 RID: 4948
		public class NPCState
		{
			// Token: 0x0600DFC1 RID: 57281 RVA: 0x004C48E4 File Offset: 0x004C2AE4
			public NPCState(BaseState state)
			{
				this.State = state;
			}

			// Token: 0x0600DFC2 RID: 57282 RVA: 0x004C4900 File Offset: 0x004C2B00
			public NPCState(BaseState state, List<StatBase> stats)
			{
				this.State = state;
				this.Stats = stats;
			}

			// Token: 0x04009E40 RID: 40512
			public BaseState State;

			// Token: 0x04009E41 RID: 40513
			public List<StatBase> Stats = new List<StatBase>();
		}
	}
}
