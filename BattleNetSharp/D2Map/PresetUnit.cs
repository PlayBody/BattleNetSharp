using System;
using System.Collections.Generic;
using System.Drawing;
using D2Data;

namespace D2Map
{
	// Token: 0x020008F4 RID: 2292
	public class PresetUnit
	{
		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x002DB17C File Offset: 0x002D937C
		// (set) Token: 0x0600B7A0 RID: 47008 RVA: 0x002DB184 File Offset: 0x002D9384
		public uint Type { get; set; }

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600B7A1 RID: 47009 RVA: 0x002DB18D File Offset: 0x002D938D
		// (set) Token: 0x0600B7A2 RID: 47010 RVA: 0x002DB195 File Offset: 0x002D9395
		public uint TxtFileNo { get; set; }

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002DB19E File Offset: 0x002D939E
		// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x002DB1A6 File Offset: 0x002D93A6
		public uint X { get; set; }

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x002DB1AF File Offset: 0x002D93AF
		// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x002DB1B7 File Offset: 0x002D93B7
		public uint Y { get; set; }

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B7A7 RID: 47015 RVA: 0x002DB1C0 File Offset: 0x002D93C0
		public Point Location
		{
			get
			{
				return new Point((int)this.X, (int)this.Y);
			}
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x002DB1E4 File Offset: 0x002D93E4
		public List<byte> GetBytes()
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(this.Type));
			list.AddRange(BitConverter.GetBytes(this.TxtFileNo));
			list.AddRange(BitConverter.GetBytes(this.X));
			list.AddRange(BitConverter.GetBytes(this.Y));
			return list;
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x002DB248 File Offset: 0x002D9448
		public unsafe PresetUnit(UnmanagedStructs.PresetUnit* unit, Room room)
		{
			this.X = unit->dwPosX + room.X;
			this.Y = unit->dwPosY + room.Y;
			this.Type = unit->dwType;
			this.TxtFileNo = unit->dwTxtFileNo;
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x002DB2A0 File Offset: 0x002D94A0
		public PresetUnit(List<byte> b)
		{
			byte[] array = b.ToArray();
			this.Type = BitConverter.ToUInt32(array, 0);
			this.TxtFileNo = BitConverter.ToUInt32(array, 4);
			this.X = BitConverter.ToUInt32(array, 8);
			this.Y = BitConverter.ToUInt32(array, 12);
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x002DB2F5 File Offset: 0x002D94F5
		public PresetUnit()
		{
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600B7AC RID: 47020 RVA: 0x002DB300 File Offset: 0x002D9500
		public UnitType CastedType
		{
			get
			{
				return (UnitType)this.Type;
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x002DB31C File Offset: 0x002D951C
		public WarpType CastedWarpType
		{
			get
			{
				return (this.CastedType == UnitType.Warp) ? ((WarpType)this.TxtFileNo) : WarpType.NotApplicable;
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B7AE RID: 47022 RVA: 0x002DB344 File Offset: 0x002D9544
		public NPCCode CastedNPCCode
		{
			get
			{
				return (this.CastedType == UnitType.NPC) ? ((NPCCode)this.TxtFileNo) : NPCCode.NotApplicable;
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600B7AF RID: 47023 RVA: 0x002DB370 File Offset: 0x002D9570
		public GameObjectID CastedGameObject
		{
			get
			{
				return (this.CastedType == UnitType.GameObject) ? ((GameObjectID)this.TxtFileNo) : GameObjectID.NotApplicable;
			}
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x002DB39C File Offset: 0x002D959C
		public override string ToString()
		{
			bool flag = this.CastedType == UnitType.GameObject;
			string text;
			if (flag)
			{
				text = this.CastedGameObject.ToString() + "|" + this.CastedType.ToString();
			}
			else
			{
				bool flag2 = this.CastedType == UnitType.NPC;
				if (flag2)
				{
					text = this.CastedNPCCode.ToString() + "|" + this.CastedType.ToString();
				}
				else
				{
					bool flag3 = this.CastedType == UnitType.Warp;
					if (flag3)
					{
						text = this.CastedWarpType.ToString() + "|" + this.CastedType.ToString();
					}
					else
					{
						text = string.Concat(new string[]
						{
							this.CastedType.ToString(),
							"|",
							this.CastedWarpType.ToString(),
							"|",
							this.CastedNPCCode.ToString(),
							"|",
							this.CastedGameObject.ToString()
						});
					}
				}
			}
			return text;
		}
	}
}
