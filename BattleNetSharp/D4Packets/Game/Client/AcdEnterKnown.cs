#nullable enable // @Review

using System;
using System.Runtime.CompilerServices;


namespace D4Packets.Game.Client
{
	// Token: 0x02000882 RID: 2178
<<<<<<< HEAD
=======
	//[NullableContext(2)]
	//[Nullable(0)]
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_ACD_ENTER_KNOWN)]
	public class AcdEnterKnown : D4Packet
	{
		// Token: 0x04006415 RID: 25621
		public long ActorID;

		// Token: 0x04006416 RID: 25622
		public int ActorSNO;

		// Token: 0x04006417 RID: 25623
		public uint Flags;

		// Token: 0x04006418 RID: 25624
		[FixedLen(2U)]
		public int LocationType;

		// Token: 0x04006419 RID: 25625
		public WorldLocationMessageData WorldLocation;

		// Token: 0x0400641A RID: 25626
		public InventoryLocationMessageData InventoryLocation;

		// Token: 0x0400641B RID: 25627
		public ulong SNOHandle;

		// Token: 0x0400641C RID: 25628
		[FixedLen(4U)]
		public int? Quality;

		// Token: 0x0400641D RID: 25629
		[FixedLen(4U)]
		public int? ItemQuality;

		// Token: 0x0400641E RID: 25630
		[FixedLen(2U)]
		public int? ItemQualityModifier;

		// Token: 0x0400641F RID: 25631
		public uint LookHash;

		// Token: 0x04006420 RID: 25632
		public int ShaderMapOverride;

		// Token: 0x04006421 RID: 25633
		public int? MarkerSet;

		// Token: 0x04006422 RID: 25634
		public int? MarkerId;

		// Token: 0x04006423 RID: 25635
		public int? Field15;

		// Token: 0x04006424 RID: 25636
		public int? Field15b;

		// Token: 0x04006425 RID: 25637
		public uint? Field16;

		// Token: 0x04006426 RID: 25638
		public uint? Field16b;

		// Token: 0x04006427 RID: 25639
		public int? AmbientOcclusionOverrideTex;

		// Token: 0x04006428 RID: 25640
		public uint? TimeActorCreated;

		// Token: 0x04006429 RID: 25641
		public EnterKnownLookOverrides Field19;

		// Token: 0x0400642A RID: 25642
		public Type37CFF633 Field20;

		// Token: 0x0400642B RID: 25643
		public uint? GizmoHash;

		// Token: 0x0400642C RID: 25644
		public long? HeroAccountID;

		// Token: 0x0400642D RID: 25645
		public long? Field23;

		// Token: 0x0400642E RID: 25646
		public int? Field24;

		// Token: 0x0400642F RID: 25647
		public uint? Field25;

		// Token: 0x04006430 RID: 25648
		public uint? Field26;

		// Token: 0x04006431 RID: 25649
		public long? Field27;

		// Token: 0x04006432 RID: 25650
<<<<<<< HEAD
		public TypeA9417475[] Field28;

		// Token: 0x04006433 RID: 25651
=======
//		[Nullable(0)]
		[FixedLen(4U)]
		public TypeA9417475[] Field28;

		// Token: 0x04006433 RID: 25651
//		[Nullable(0)]
		[FixedLen(4U)]
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
		public TypeA9417475[] Field29;
	}
}
