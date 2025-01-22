using System;
using System.IO;
using System.Linq;
using D2Data;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A01 RID: 2561
	public class SetState : Packet
	{
		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x004721F2 File Offset: 0x004703F2
		// (set) Token: 0x0600BB2E RID: 47918 RVA: 0x004721FA File Offset: 0x004703FA
		public UnitState State { get; set; }

		// Token: 0x0600BB2F RID: 47919 RVA: 0x00472204 File Offset: 0x00470404
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Type = (UnitType)bitReader.ReadByte();
			bool flag = base.PacketVersion == GameVersion.D2R;
			if (flag)
			{
				this.Length = bitReader.ReadByte();
			}
			bool flag2 = base.PacketVersion == GameVersion.D2R;
			if (flag2)
			{
				this.State = new UnitState((int)bitReader.ReadByte());
			}
			bool flag3 = base.PacketVersion == GameVersion.D2R;
			if (flag3)
			{
				bitReader.ReadByte();
			}
			this.Id = bitReader.ReadUInt32();
			bool flag4 = base.PacketVersion != GameVersion.D2R;
			if (flag4)
			{
				this.Length = bitReader.ReadByte();
			}
			bool flag5 = base.PacketVersion != GameVersion.D2R;
			if (flag5)
			{
				this.State = new UnitState((int)bitReader.ReadByte());
			}
			this.orig = Bytes.Take((int)this.Length).ToArray<byte>();
			for (;;)
			{
				ushort num = (ushort)bitReader.ReadBits(9);
				bool flag6 = num == 511;
				if (flag6)
				{
					break;
				}
				BaseStat baseStat = BaseStat.Get((int)num);
				ulong num2 = bitReader.ReadBits(baseStat.SendBits);
				int num3 = ((base.PacketVersion == GameVersion.LOD) ? baseStat.SendParamBits : baseStat.SendParamBits_2_6);
				bool flag7 = num3 > 0;
				if (flag7)
				{
					ulong num4 = bitReader.ReadBits(num3);
					bool signed = baseStat.Signed;
					if (signed)
					{
						this.State.Stats.Add(new SignedStatParam(baseStat, (int)num2, (int)num4));
					}
					else
					{
						this.State.Stats.Add(new UnsignedStatParam(baseStat, (uint)num2, (uint)num4));
					}
				}
				else
				{
					bool signed2 = baseStat.Signed;
					if (signed2)
					{
						this.State.Stats.Add(new SignedStat(baseStat, (int)num2));
					}
					else
					{
						this.State.Stats.Add(new UnsignedStat(baseStat, (uint)num2));
					}
				}
			}
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x004723EC File Offset: 0x004705EC
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(168U, 8);
			bitWriter.WriteBits((uint)this.Type, 8);
			bool flag = base.PacketVersion == GameVersion.D2R;
			if (flag)
			{
				bitWriter.WriteBits(0U, 8);
			}
			bool flag2 = base.PacketVersion == GameVersion.D2R;
			if (flag2)
			{
				bitWriter.WriteBits((uint)((byte)this.State.BaseState.Index), 16);
			}
			bitWriter.WriteBits(this.Id, 32);
			bool flag3 = base.PacketVersion != GameVersion.D2R;
			if (flag3)
			{
				bitWriter.WriteBits(0U, 8);
			}
			bool flag4 = base.PacketVersion != GameVersion.D2R;
			if (flag4)
			{
				bitWriter.WriteBits((uint)((byte)this.State.BaseState.Index), 8);
			}
			foreach (StatBase statBase in this.State.Stats)
			{
				bitWriter.WriteBits((uint)statBase.BaseStat.Index, 9);
				int num = ((base.PacketVersion == GameVersion.LOD) ? statBase.BaseStat.SendParamBits : statBase.BaseStat.SendParamBits_2_6);
				bool flag5 = num > 0;
				if (flag5)
				{
					bool signed = statBase.BaseStat.Signed;
					if (signed)
					{
						bitWriter.WriteBits((uint)((SignedStatParam)statBase).Value, statBase.BaseStat.SendBits);
					}
					else
					{
						bitWriter.WriteBits(((UnsignedStatParam)statBase).Value, statBase.BaseStat.SendBits);
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
				bool flag6 = num > 0;
				if (flag6)
				{
					bool signed3 = statBase.BaseStat.Signed;
					if (signed3)
					{
						bitWriter.WriteBits((uint)((SignedStatParam)statBase).Param, num);
					}
					else
					{
						bitWriter.WriteBits(((UnsignedStatParam)statBase).Param, num);
					}
				}
			}
			bitWriter.WriteBits(511U, 9);
			bitWriter.Flush();
			byte[] array = this.memoryStream.ToArray();
			array[(base.PacketVersion == GameVersion.D2R) ? 2 : 6] = (byte)array.Length;
			return array;
		}

		// Token: 0x04008BEE RID: 35822
		public GameServerPacket PacketId;

		// Token: 0x04008BEF RID: 35823
		public UnitType Type;

		// Token: 0x04008BF0 RID: 35824
		public uint Id;

		// Token: 0x04008BF1 RID: 35825
		public byte Length;

		// Token: 0x04008BF2 RID: 35826
		public uint unk;

		// Token: 0x04008BF4 RID: 35828
		public byte[] orig;
	}
}
