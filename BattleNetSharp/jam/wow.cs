using System;
using System.Collections.Generic;

namespace BattleNetSharp.jam
{
	// Token: 0x02000AF3 RID: 2803
	internal class wow
	{
		// Token: 0x020013CE RID: 5070
		public class JSONRealmListTicketIdentity
		{
			// Token: 0x17003986 RID: 14726
			// (get) Token: 0x0600E114 RID: 57620 RVA: 0x004C9534 File Offset: 0x004C7734
			// (set) Token: 0x0600E115 RID: 57621 RVA: 0x004C953C File Offset: 0x004C773C
			public ulong gameAccountID { get; set; }

			// Token: 0x17003987 RID: 14727
			// (get) Token: 0x0600E116 RID: 57622 RVA: 0x004C9545 File Offset: 0x004C7745
			// (set) Token: 0x0600E117 RID: 57623 RVA: 0x004C954D File Offset: 0x004C774D
			public byte gameAccountRegion { get; set; }
		}

		// Token: 0x020013CF RID: 5071
		public class JamJSONRealmListTicketClientInformation
		{
			// Token: 0x17003988 RID: 14728
			// (get) Token: 0x0600E119 RID: 57625 RVA: 0x004C955F File Offset: 0x004C775F
			// (set) Token: 0x0600E11A RID: 57626 RVA: 0x004C9567 File Offset: 0x004C7767
			public uint platform { get; set; }

			// Token: 0x17003989 RID: 14729
			// (get) Token: 0x0600E11B RID: 57627 RVA: 0x004C9570 File Offset: 0x004C7770
			// (set) Token: 0x0600E11C RID: 57628 RVA: 0x004C9578 File Offset: 0x004C7778
			public uint currentTime { get; set; }

			// Token: 0x1700398A RID: 14730
			// (get) Token: 0x0600E11D RID: 57629 RVA: 0x004C9581 File Offset: 0x004C7781
			// (set) Token: 0x0600E11E RID: 57630 RVA: 0x004C9589 File Offset: 0x004C7789
			public uint clientArch { get; set; }

			// Token: 0x1700398B RID: 14731
			// (get) Token: 0x0600E11F RID: 57631 RVA: 0x004C9592 File Offset: 0x004C7792
			// (set) Token: 0x0600E120 RID: 57632 RVA: 0x004C959A File Offset: 0x004C779A
			public string systemVersion { get; set; }

			// Token: 0x1700398C RID: 14732
			// (get) Token: 0x0600E121 RID: 57633 RVA: 0x004C95A3 File Offset: 0x004C77A3
			// (set) Token: 0x0600E122 RID: 57634 RVA: 0x004C95AB File Offset: 0x004C77AB
			public string buildVariant { get; set; }

			// Token: 0x1700398D RID: 14733
			// (get) Token: 0x0600E123 RID: 57635 RVA: 0x004C95B4 File Offset: 0x004C77B4
			// (set) Token: 0x0600E124 RID: 57636 RVA: 0x004C95BC File Offset: 0x004C77BC
			public string timeZone { get; set; }

			// Token: 0x1700398E RID: 14734
			// (get) Token: 0x0600E125 RID: 57637 RVA: 0x004C95C5 File Offset: 0x004C77C5
			// (set) Token: 0x0600E126 RID: 57638 RVA: 0x004C95CD File Offset: 0x004C77CD
			public uint versionDataBuild { get; set; }

			// Token: 0x1700398F RID: 14735
			// (get) Token: 0x0600E127 RID: 57639 RVA: 0x004C95D6 File Offset: 0x004C77D6
			// (set) Token: 0x0600E128 RID: 57640 RVA: 0x004C95DE File Offset: 0x004C77DE
			public uint audioLocale { get; set; }

			// Token: 0x17003990 RID: 14736
			// (get) Token: 0x0600E129 RID: 57641 RVA: 0x004C95E7 File Offset: 0x004C77E7
			// (set) Token: 0x0600E12A RID: 57642 RVA: 0x004C95EF File Offset: 0x004C77EF
			public wow.JamJSONGameVersion version { get; set; }

			// Token: 0x17003991 RID: 14737
			// (get) Token: 0x0600E12B RID: 57643 RVA: 0x004C95F8 File Offset: 0x004C77F8
			// (set) Token: 0x0600E12C RID: 57644 RVA: 0x004C9600 File Offset: 0x004C7800
			public List<byte> secret { get; set; }

			// Token: 0x17003992 RID: 14738
			// (get) Token: 0x0600E12D RID: 57645 RVA: 0x004C9609 File Offset: 0x004C7809
			// (set) Token: 0x0600E12E RID: 57646 RVA: 0x004C9611 File Offset: 0x004C7811
			public uint type { get; set; }

			// Token: 0x17003993 RID: 14739
			// (get) Token: 0x0600E12F RID: 57647 RVA: 0x004C961A File Offset: 0x004C781A
			// (set) Token: 0x0600E130 RID: 57648 RVA: 0x004C9622 File Offset: 0x004C7822
			public uint textLocale { get; set; }

			// Token: 0x17003994 RID: 14740
			// (get) Token: 0x0600E131 RID: 57649 RVA: 0x004C962B File Offset: 0x004C782B
			// (set) Token: 0x0600E132 RID: 57650 RVA: 0x004C9633 File Offset: 0x004C7833
			public uint platformType { get; set; }

			// Token: 0x17003995 RID: 14741
			// (get) Token: 0x0600E133 RID: 57651 RVA: 0x004C963C File Offset: 0x004C783C
			// (set) Token: 0x0600E134 RID: 57652 RVA: 0x004C9644 File Offset: 0x004C7844
			public uint systemArch { get; set; }
		}

		// Token: 0x020013D0 RID: 5072
		public class JSONRealmListTicketClientInformation
		{
			// Token: 0x17003996 RID: 14742
			// (get) Token: 0x0600E136 RID: 57654 RVA: 0x004C9656 File Offset: 0x004C7856
			// (set) Token: 0x0600E137 RID: 57655 RVA: 0x004C965E File Offset: 0x004C785E
			public wow.JamJSONRealmListTicketClientInformation info { get; set; }
		}

		// Token: 0x020013D1 RID: 5073
		public class JamJSONGameVersion
		{
			// Token: 0x17003997 RID: 14743
			// (get) Token: 0x0600E139 RID: 57657 RVA: 0x004C9670 File Offset: 0x004C7870
			// (set) Token: 0x0600E13A RID: 57658 RVA: 0x004C9678 File Offset: 0x004C7878
			public int versionMajor { get; set; }

			// Token: 0x17003998 RID: 14744
			// (get) Token: 0x0600E13B RID: 57659 RVA: 0x004C9681 File Offset: 0x004C7881
			// (set) Token: 0x0600E13C RID: 57660 RVA: 0x004C9689 File Offset: 0x004C7889
			public int versionBuild { get; set; }

			// Token: 0x17003999 RID: 14745
			// (get) Token: 0x0600E13D RID: 57661 RVA: 0x004C9692 File Offset: 0x004C7892
			// (set) Token: 0x0600E13E RID: 57662 RVA: 0x004C969A File Offset: 0x004C789A
			public int versionMinor { get; set; }

			// Token: 0x1700399A RID: 14746
			// (get) Token: 0x0600E13F RID: 57663 RVA: 0x004C96A3 File Offset: 0x004C78A3
			// (set) Token: 0x0600E140 RID: 57664 RVA: 0x004C96AB File Offset: 0x004C78AB
			public int versionRevision { get; set; }
		}

		// Token: 0x020013D2 RID: 5074
		public class JamJSONRealmEntry
		{
			// Token: 0x1700399B RID: 14747
			// (get) Token: 0x0600E142 RID: 57666 RVA: 0x004C96BD File Offset: 0x004C78BD
			// (set) Token: 0x0600E143 RID: 57667 RVA: 0x004C96C5 File Offset: 0x004C78C5
			public int wowRealmAddress { get; set; }

			// Token: 0x1700399C RID: 14748
			// (get) Token: 0x0600E144 RID: 57668 RVA: 0x004C96CE File Offset: 0x004C78CE
			// (set) Token: 0x0600E145 RID: 57669 RVA: 0x004C96D6 File Offset: 0x004C78D6
			public int cfgTimezonesID { get; set; }

			// Token: 0x1700399D RID: 14749
			// (get) Token: 0x0600E146 RID: 57670 RVA: 0x004C96DF File Offset: 0x004C78DF
			// (set) Token: 0x0600E147 RID: 57671 RVA: 0x004C96E7 File Offset: 0x004C78E7
			public int populationState { get; set; }

			// Token: 0x1700399E RID: 14750
			// (get) Token: 0x0600E148 RID: 57672 RVA: 0x004C96F0 File Offset: 0x004C78F0
			// (set) Token: 0x0600E149 RID: 57673 RVA: 0x004C96F8 File Offset: 0x004C78F8
			public int cfgCategoriesID { get; set; }

			// Token: 0x1700399F RID: 14751
			// (get) Token: 0x0600E14A RID: 57674 RVA: 0x004C9701 File Offset: 0x004C7901
			// (set) Token: 0x0600E14B RID: 57675 RVA: 0x004C9709 File Offset: 0x004C7909
			public wow.JamJSONGameVersion version { get; set; }

			// Token: 0x170039A0 RID: 14752
			// (get) Token: 0x0600E14C RID: 57676 RVA: 0x004C9712 File Offset: 0x004C7912
			// (set) Token: 0x0600E14D RID: 57677 RVA: 0x004C971A File Offset: 0x004C791A
			public int cfgRealmsID { get; set; }

			// Token: 0x170039A1 RID: 14753
			// (get) Token: 0x0600E14E RID: 57678 RVA: 0x004C9723 File Offset: 0x004C7923
			// (set) Token: 0x0600E14F RID: 57679 RVA: 0x004C972B File Offset: 0x004C792B
			public int flags { get; set; }

			// Token: 0x170039A2 RID: 14754
			// (get) Token: 0x0600E150 RID: 57680 RVA: 0x004C9734 File Offset: 0x004C7934
			// (set) Token: 0x0600E151 RID: 57681 RVA: 0x004C973C File Offset: 0x004C793C
			public string name { get; set; }

			// Token: 0x170039A3 RID: 14755
			// (get) Token: 0x0600E152 RID: 57682 RVA: 0x004C9745 File Offset: 0x004C7945
			// (set) Token: 0x0600E153 RID: 57683 RVA: 0x004C974D File Offset: 0x004C794D
			public int cfgConfigsID { get; set; }

			// Token: 0x170039A4 RID: 14756
			// (get) Token: 0x0600E154 RID: 57684 RVA: 0x004C9756 File Offset: 0x004C7956
			// (set) Token: 0x0600E155 RID: 57685 RVA: 0x004C975E File Offset: 0x004C795E
			public int cfgLanguagesID { get; set; }
		}

		// Token: 0x020013D3 RID: 5075
		public class JamJSONRealmListServerIPAddress
		{
			// Token: 0x170039A5 RID: 14757
			// (get) Token: 0x0600E157 RID: 57687 RVA: 0x004C9770 File Offset: 0x004C7970
			// (set) Token: 0x0600E158 RID: 57688 RVA: 0x004C9778 File Offset: 0x004C7978
			public string ip { get; set; }

			// Token: 0x170039A6 RID: 14758
			// (get) Token: 0x0600E159 RID: 57689 RVA: 0x004C9781 File Offset: 0x004C7981
			// (set) Token: 0x0600E15A RID: 57690 RVA: 0x004C9789 File Offset: 0x004C7989
			public int port { get; set; }
		}

		// Token: 0x020013D4 RID: 5076
		public class JamJSONRealmListServerIPFamily
		{
			// Token: 0x170039A7 RID: 14759
			// (get) Token: 0x0600E15C RID: 57692 RVA: 0x004C979B File Offset: 0x004C799B
			// (set) Token: 0x0600E15D RID: 57693 RVA: 0x004C97A3 File Offset: 0x004C79A3
			public int family { get; set; }

			// Token: 0x170039A8 RID: 14760
			// (get) Token: 0x0600E15E RID: 57694 RVA: 0x004C97AC File Offset: 0x004C79AC
			// (set) Token: 0x0600E15F RID: 57695 RVA: 0x004C97B4 File Offset: 0x004C79B4
			public List<wow.JamJSONRealmListServerIPAddress> addresses { get; set; }
		}

		// Token: 0x020013D5 RID: 5077
		public class JSONRealmListServerIPAddresses
		{
			// Token: 0x170039A9 RID: 14761
			// (get) Token: 0x0600E161 RID: 57697 RVA: 0x004C97C6 File Offset: 0x004C79C6
			// (set) Token: 0x0600E162 RID: 57698 RVA: 0x004C97CE File Offset: 0x004C79CE
			public List<wow.JamJSONRealmListServerIPFamily> families { get; set; }
		}
	}
}
