using System;

namespace D2Data
{
	// Token: 0x02000954 RID: 2388
	public enum MagicSuffixType
	{
		// Token: 0x0400788C RID: 30860
		None,
		// Token: 0x0400788D RID: 30861
		Health,
		// Token: 0x0400788E RID: 30862
		Protection,
		// Token: 0x0400788F RID: 30863
		Absorption,
		// Token: 0x04007890 RID: 30864
		Life,
		// Token: 0x04007891 RID: 30865
		Unused5,
		// Token: 0x04007892 RID: 30866
		Warding,
		// Token: 0x04007893 RID: 30867
		TheSentinel,
		// Token: 0x04007894 RID: 30868
		Guarding,
		// Token: 0x04007895 RID: 30869
		Negation,
		// Token: 0x04007896 RID: 30870
		Unused10,
		// Token: 0x04007897 RID: 30871
		Piercing,
		// Token: 0x04007898 RID: 30872
		Bashing,
		// Token: 0x04007899 RID: 30873
		Puncturing,
		// Token: 0x0400789A RID: 30874
		Thorns,
		// Token: 0x0400789B RID: 30875
		Spikes,
		// Token: 0x0400789C RID: 30876
		Readiness,
		// Token: 0x0400789D RID: 30877
		Alacrity,
		// Token: 0x0400789E RID: 30878
		Swiftness,
		// Token: 0x0400789F RID: 30879
		Quickness,
		// Token: 0x040078A0 RID: 30880
		Blocking,
		// Token: 0x040078A1 RID: 30881
		Deflecting,
		// Token: 0x040078A2 RID: 30882
		TheApprentice,
		// Token: 0x040078A3 RID: 30883
		TheMagus,
		// Token: 0x040078A4 RID: 30884
		Frost,
		// Token: 0x040078A5 RID: 30885
		TheGlacier,
		// Token: 0x040078A6 RID: 30886
		Frost2,
		// Token: 0x040078A7 RID: 30887
		Warmth3,
		// Token: 0x040078A8 RID: 30888
		Flame,
		// Token: 0x040078A9 RID: 30889
		Fire,
		// Token: 0x040078AA RID: 30890
		Burning,
		// Token: 0x040078AB RID: 30891
		Flame2,
		// Token: 0x040078AC RID: 30892
		Shock,
		// Token: 0x040078AD RID: 30893
		Lightning,
		// Token: 0x040078AE RID: 30894
		Thunder,
		// Token: 0x040078AF RID: 30895
		Shock2,
		// Token: 0x040078B0 RID: 30896
		Craftsmanship,
		// Token: 0x040078B1 RID: 30897
		Quality,
		// Token: 0x040078B2 RID: 30898
		Maiming,
		// Token: 0x040078B3 RID: 30899
		Slaying,
		// Token: 0x040078B4 RID: 30900
		Gore,
		// Token: 0x040078B5 RID: 30901
		Carnage,
		// Token: 0x040078B6 RID: 30902
		Slaughter,
		// Token: 0x040078B7 RID: 30903
		Maiming2,
		// Token: 0x040078B8 RID: 30904
		Worth,
		// Token: 0x040078B9 RID: 30905
		Measure,
		// Token: 0x040078BA RID: 30906
		Excellence,
		// Token: 0x040078BB RID: 30907
		Performance,
		// Token: 0x040078BC RID: 30908
		Measure2,
		// Token: 0x040078BD RID: 30909
		Blight,
		// Token: 0x040078BE RID: 30910
		Venom,
		// Token: 0x040078BF RID: 30911
		Pestilence,
		// Token: 0x040078C0 RID: 30912
		Blight2,
		// Token: 0x040078C1 RID: 30913
		Dexterity,
		// Token: 0x040078C2 RID: 30914
		Dexterity2,
		// Token: 0x040078C3 RID: 30915
		Skill,
		// Token: 0x040078C4 RID: 30916
		Skill2,
		// Token: 0x040078C5 RID: 30917
		Accuracy,
		// Token: 0x040078C6 RID: 30918
		Precision,
		// Token: 0x040078C7 RID: 30919
		Precision2,
		// Token: 0x040078C8 RID: 30920
		Perfection,
		// Token: 0x040078C9 RID: 30921
		Balance,
		// Token: 0x040078CA RID: 30922
		Stability,
		// Token: 0x040078CB RID: 30923
		Unused63,
		// Token: 0x040078CC RID: 30924
		Regeneration,
		// Token: 0x040078CD RID: 30925
		Regeneration2,
		// Token: 0x040078CE RID: 30926
		Regeneration3,
		// Token: 0x040078CF RID: 30927
		Regrowth,
		// Token: 0x040078D0 RID: 30928
		Regrowth2,
		// Token: 0x040078D1 RID: 30929
		Vileness,
		// Token: 0x040078D2 RID: 30930
		Unused70,
		// Token: 0x040078D3 RID: 30931
		Greed,
		// Token: 0x040078D4 RID: 30932
		Wealth,
		// Token: 0x040078D5 RID: 30933
		Chance,
		// Token: 0x040078D6 RID: 30934
		Fortune,
		// Token: 0x040078D7 RID: 30935
		Energy,
		// Token: 0x040078D8 RID: 30936
		Energy2,
		// Token: 0x040078D9 RID: 30937
		TheMind,
		// Token: 0x040078DA RID: 30938
		Brilliance,
		// Token: 0x040078DB RID: 30939
		Sorcery,
		// Token: 0x040078DC RID: 30940
		Wizardry,
		// Token: 0x040078DD RID: 30941
		TheBear,
		// Token: 0x040078DE RID: 30942
		Light,
		// Token: 0x040078DF RID: 30943
		Radiance,
		// Token: 0x040078E0 RID: 30944
		TheSun,
		// Token: 0x040078E1 RID: 30945
		Life2,
		// Token: 0x040078E2 RID: 30946
		TheJackal,
		// Token: 0x040078E3 RID: 30947
		TheFox,
		// Token: 0x040078E4 RID: 30948
		TheWolf,
		// Token: 0x040078E5 RID: 30949
		TheWolf2,
		// Token: 0x040078E6 RID: 30950
		TheTiger,
		// Token: 0x040078E7 RID: 30951
		TheMammoth,
		// Token: 0x040078E8 RID: 30952
		TheMammoth2,
		// Token: 0x040078E9 RID: 30953
		TheColosuss,
		// Token: 0x040078EA RID: 30954
		TheLeech,
		// Token: 0x040078EB RID: 30955
		TheLocust,
		// Token: 0x040078EC RID: 30956
		TheBat,
		// Token: 0x040078ED RID: 30957
		TheVampire,
		// Token: 0x040078EE RID: 30958
		Defiance,
		// Token: 0x040078EF RID: 30959
		Amelioration,
		// Token: 0x040078F0 RID: 30960
		Remedy,
		// Token: 0x040078F1 RID: 30961
		Unused101,
		// Token: 0x040078F2 RID: 30962
		Simplicity,
		// Token: 0x040078F3 RID: 30963
		Ease,
		// Token: 0x040078F4 RID: 30964
		Unused104,
		// Token: 0x040078F5 RID: 30965
		Strength,
		// Token: 0x040078F6 RID: 30966
		Might,
		// Token: 0x040078F7 RID: 30967
		TheOx,
		// Token: 0x040078F8 RID: 30968
		TheOx2,
		// Token: 0x040078F9 RID: 30969
		TheGiant,
		// Token: 0x040078FA RID: 30970
		TheGiant2,
		// Token: 0x040078FB RID: 30971
		TheTitan4,
		// Token: 0x040078FC RID: 30972
		Pacing,
		// Token: 0x040078FD RID: 30973
		Haste,
		// Token: 0x040078FE RID: 30974
		Speed,
		// Token: 0x040078FF RID: 30975
		Health2,
		// Token: 0x04007900 RID: 30976
		Protection2,
		// Token: 0x04007901 RID: 30977
		Absorption2,
		// Token: 0x04007902 RID: 30978
		Life3,
		// Token: 0x04007903 RID: 30979
		LifeEverlasting,
		// Token: 0x04007904 RID: 30980
		Protection3,
		// Token: 0x04007905 RID: 30981
		Absorption3,
		// Token: 0x04007906 RID: 30982
		Life4,
		// Token: 0x04007907 RID: 30983
		Anima,
		// Token: 0x04007908 RID: 30984
		Warding2,
		// Token: 0x04007909 RID: 30985
		TheSentinel2,
		// Token: 0x0400790A RID: 30986
		Guarding2,
		// Token: 0x0400790B RID: 30987
		Negation2,
		// Token: 0x0400790C RID: 30988
		TheSentinel3,
		// Token: 0x0400790D RID: 30989
		Guarding3,
		// Token: 0x0400790E RID: 30990
		Negation3,
		// Token: 0x0400790F RID: 30991
		Unused131,
		// Token: 0x04007910 RID: 30992
		Unused132,
		// Token: 0x04007911 RID: 30993
		Unused133,
		// Token: 0x04007912 RID: 30994
		Unused134,
		// Token: 0x04007913 RID: 30995
		Unused135,
		// Token: 0x04007914 RID: 30996
		Unused136,
		// Token: 0x04007915 RID: 30997
		Unused137,
		// Token: 0x04007916 RID: 30998
		Unused138,
		// Token: 0x04007917 RID: 30999
		Unused139,
		// Token: 0x04007918 RID: 31000
		Unused140,
		// Token: 0x04007919 RID: 31001
		Unused141,
		// Token: 0x0400791A RID: 31002
		Unused142,
		// Token: 0x0400791B RID: 31003
		Unused143,
		// Token: 0x0400791C RID: 31004
		Unused144,
		// Token: 0x0400791D RID: 31005
		Unused145,
		// Token: 0x0400791E RID: 31006
		Unused146,
		// Token: 0x0400791F RID: 31007
		Unused147,
		// Token: 0x04007920 RID: 31008
		Unused148,
		// Token: 0x04007921 RID: 31009
		Unused149,
		// Token: 0x04007922 RID: 31010
		Unused150,
		// Token: 0x04007923 RID: 31011
		Unused151,
		// Token: 0x04007924 RID: 31012
		Unused152,
		// Token: 0x04007925 RID: 31013
		Unused153,
		// Token: 0x04007926 RID: 31014
		Unused154,
		// Token: 0x04007927 RID: 31015
		Unused155,
		// Token: 0x04007928 RID: 31016
		Unused156,
		// Token: 0x04007929 RID: 31017
		Unused157,
		// Token: 0x0400792A RID: 31018
		Piercing2,
		// Token: 0x0400792B RID: 31019
		Unused158,
		// Token: 0x0400792C RID: 31020
		Unused159,
		// Token: 0x0400792D RID: 31021
		Thorns2,
		// Token: 0x0400792E RID: 31022
		Spikes2,
		// Token: 0x0400792F RID: 31023
		Razors,
		// Token: 0x04007930 RID: 31024
		Swords,
		// Token: 0x04007931 RID: 31025
		Malice,
		// Token: 0x04007932 RID: 31026
		Readiness2,
		// Token: 0x04007933 RID: 31027
		Alacrity2,
		// Token: 0x04007934 RID: 31028
		Swiftness2,
		// Token: 0x04007935 RID: 31029
		Quickness2,
		// Token: 0x04007936 RID: 31030
		Alacrity3,
		// Token: 0x04007937 RID: 31031
		Fervor,
		// Token: 0x04007938 RID: 31032
		Blocking2,
		// Token: 0x04007939 RID: 31033
		Deflecting2,
		// Token: 0x0400793A RID: 31034
		TheApprentice2,
		// Token: 0x0400793B RID: 31035
		TheMagus2,
		// Token: 0x0400793C RID: 31036
		Frost3,
		// Token: 0x0400793D RID: 31037
		TheIcicle,
		// Token: 0x0400793E RID: 31038
		TheGlacier2,
		// Token: 0x0400793F RID: 31039
		Winter,
		// Token: 0x04007940 RID: 31040
		Frost4,
		// Token: 0x04007941 RID: 31041
		Frigidity,
		// Token: 0x04007942 RID: 31042
		Warmth2,
		// Token: 0x04007943 RID: 31043
		Flame3,
		// Token: 0x04007944 RID: 31044
		Fire2,
		// Token: 0x04007945 RID: 31045
		Burning2,
		// Token: 0x04007946 RID: 31046
		Incineration,
		// Token: 0x04007947 RID: 31047
		Flame4,
		// Token: 0x04007948 RID: 31048
		Passion,
		// Token: 0x04007949 RID: 31049
		Shock3,
		// Token: 0x0400794A RID: 31050
		Lightning2,
		// Token: 0x0400794B RID: 31051
		Thunder2,
		// Token: 0x0400794C RID: 31052
		Storms,
		// Token: 0x0400794D RID: 31053
		Shock4,
		// Token: 0x0400794E RID: 31054
		Ennui,
		// Token: 0x0400794F RID: 31055
		Craftsmanship2,
		// Token: 0x04007950 RID: 31056
		Quality2,
		// Token: 0x04007951 RID: 31057
		Maiming3,
		// Token: 0x04007952 RID: 31058
		Slaying2,
		// Token: 0x04007953 RID: 31059
		Gore2,
		// Token: 0x04007954 RID: 31060
		Carnage2,
		// Token: 0x04007955 RID: 31061
		Slaughter2,
		// Token: 0x04007956 RID: 31062
		Butchery,
		// Token: 0x04007957 RID: 31063
		Evisceration,
		// Token: 0x04007958 RID: 31064
		Maiming4,
		// Token: 0x04007959 RID: 31065
		Craftsmanship3,
		// Token: 0x0400795A RID: 31066
		Craftsmanship4,
		// Token: 0x0400795B RID: 31067
		Craftsmanship5,
		// Token: 0x0400795C RID: 31068
		Quality3,
		// Token: 0x0400795D RID: 31069
		Quality4,
		// Token: 0x0400795E RID: 31070
		Maiming5,
		// Token: 0x0400795F RID: 31071
		Maiming6,
		// Token: 0x04007960 RID: 31072
		Unused212,
		// Token: 0x04007961 RID: 31073
		Unused213,
		// Token: 0x04007962 RID: 31074
		Unused214,
		// Token: 0x04007963 RID: 31075
		Unused215,
		// Token: 0x04007964 RID: 31076
		Unused216,
		// Token: 0x04007965 RID: 31077
		Unused217,
		// Token: 0x04007966 RID: 31078
		Unused218,
		// Token: 0x04007967 RID: 31079
		Unused219,
		// Token: 0x04007968 RID: 31080
		Ire,
		// Token: 0x04007969 RID: 31081
		Wrath,
		// Token: 0x0400796A RID: 31082
		Carnage3,
		// Token: 0x0400796B RID: 31083
		Worth2,
		// Token: 0x0400796C RID: 31084
		Measure3,
		// Token: 0x0400796D RID: 31085
		Excellence2,
		// Token: 0x0400796E RID: 31086
		Performance2,
		// Token: 0x0400796F RID: 31087
		Transcendence,
		// Token: 0x04007970 RID: 31088
		Worth3,
		// Token: 0x04007971 RID: 31089
		Measure4,
		// Token: 0x04007972 RID: 31090
		Excellence3,
		// Token: 0x04007973 RID: 31091
		Performance3,
		// Token: 0x04007974 RID: 31092
		Joyfulness,
		// Token: 0x04007975 RID: 31093
		Bliss,
		// Token: 0x04007976 RID: 31094
		Blight3,
		// Token: 0x04007977 RID: 31095
		Venom2,
		// Token: 0x04007978 RID: 31096
		Pestilence2,
		// Token: 0x04007979 RID: 31097
		Anthrax,
		// Token: 0x0400797A RID: 31098
		Blight4,
		// Token: 0x0400797B RID: 31099
		Envy,
		// Token: 0x0400797C RID: 31100
		Dexterity3,
		// Token: 0x0400797D RID: 31101
		Skill3,
		// Token: 0x0400797E RID: 31102
		Accuracy2,
		// Token: 0x0400797F RID: 31103
		Precision3,
		// Token: 0x04007980 RID: 31104
		Perfection2,
		// Token: 0x04007981 RID: 31105
		Nirvana,
		// Token: 0x04007982 RID: 31106
		Dexterity4,
		// Token: 0x04007983 RID: 31107
		Skill4,
		// Token: 0x04007984 RID: 31108
		Accuracy3,
		// Token: 0x04007985 RID: 31109
		Precision4,
		// Token: 0x04007986 RID: 31110
		Perfection3,
		// Token: 0x04007987 RID: 31111
		Dexterity5,
		// Token: 0x04007988 RID: 31112
		Skill5,
		// Token: 0x04007989 RID: 31113
		Accuracy4,
		// Token: 0x0400798A RID: 31114
		Precision5,
		// Token: 0x0400798B RID: 31115
		Dexterity6,
		// Token: 0x0400798C RID: 31116
		Dexterity7,
		// Token: 0x0400798D RID: 31117
		Dexterity8,
		// Token: 0x0400798E RID: 31118
		Dexterity9,
		// Token: 0x0400798F RID: 31119
		Dexterity10,
		// Token: 0x04007990 RID: 31120
		Dexterity11,
		// Token: 0x04007991 RID: 31121
		Daring,
		// Token: 0x04007992 RID: 31122
		Balance2,
		// Token: 0x04007993 RID: 31123
		Equilibrium,
		// Token: 0x04007994 RID: 31124
		Stability2,
		// Token: 0x04007995 RID: 31125
		Balance3,
		// Token: 0x04007996 RID: 31126
		Balance4,
		// Token: 0x04007997 RID: 31127
		Balance5,
		// Token: 0x04007998 RID: 31128
		Truth,
		// Token: 0x04007999 RID: 31129
		Regeneration4,
		// Token: 0x0400799A RID: 31130
		Regeneration5,
		// Token: 0x0400799B RID: 31131
		Regeneration6,
		// Token: 0x0400799C RID: 31132
		Regrowth3,
		// Token: 0x0400799D RID: 31133
		Regrowth4,
		// Token: 0x0400799E RID: 31134
		Revivification,
		// Token: 0x0400799F RID: 31135
		Honor,
		// Token: 0x040079A0 RID: 31136
		Vileness2,
		// Token: 0x040079A1 RID: 31137
		Greed2,
		// Token: 0x040079A2 RID: 31138
		Wealth2,
		// Token: 0x040079A3 RID: 31139
		Greed3,
		// Token: 0x040079A4 RID: 31140
		Greed4,
		// Token: 0x040079A5 RID: 31141
		Greed5,
		// Token: 0x040079A6 RID: 31142
		Greed6,
		// Token: 0x040079A7 RID: 31143
		Greed7,
		// Token: 0x040079A8 RID: 31144
		Greed8,
		// Token: 0x040079A9 RID: 31145
		Avarice,
		// Token: 0x040079AA RID: 31146
		Chance2,
		// Token: 0x040079AB RID: 31147
		Fortune3,
		// Token: 0x040079AC RID: 31148
		Fortune4,
		// Token: 0x040079AD RID: 31149
		Luck,
		// Token: 0x040079AE RID: 31150
		Fortune5,
		// Token: 0x040079AF RID: 31151
		GoodLuck,
		// Token: 0x040079B0 RID: 31152
		Prosperity,
		// Token: 0x040079B1 RID: 31153
		Energy3,
		// Token: 0x040079B2 RID: 31154
		TheMind2,
		// Token: 0x040079B3 RID: 31155
		Brilliance2,
		// Token: 0x040079B4 RID: 31156
		Sorcery2,
		// Token: 0x040079B5 RID: 31157
		Wizardry2,
		// Token: 0x040079B6 RID: 31158
		Enlightenment,
		// Token: 0x040079B7 RID: 31159
		Energy4,
		// Token: 0x040079B8 RID: 31160
		TheMind3,
		// Token: 0x040079B9 RID: 31161
		Brilliance3,
		// Token: 0x040079BA RID: 31162
		Sorcery3,
		// Token: 0x040079BB RID: 31163
		Wizardry3,
		// Token: 0x040079BC RID: 31164
		Energy5,
		// Token: 0x040079BD RID: 31165
		TheMind4,
		// Token: 0x040079BE RID: 31166
		Brilliance4,
		// Token: 0x040079BF RID: 31167
		Sorcery4,
		// Token: 0x040079C0 RID: 31168
		Knowledge,
		// Token: 0x040079C1 RID: 31169
		TheBear2,
		// Token: 0x040079C2 RID: 31170
		Light2,
		// Token: 0x040079C3 RID: 31171
		Radiance2,
		// Token: 0x040079C4 RID: 31172
		TheSun2,
		// Token: 0x040079C5 RID: 31173
		TheJackal2,
		// Token: 0x040079C6 RID: 31174
		TheFox2,
		// Token: 0x040079C7 RID: 31175
		TheWolf3,
		// Token: 0x040079C8 RID: 31176
		TheTiger2,
		// Token: 0x040079C9 RID: 31177
		TheMammoth3,
		// Token: 0x040079CA RID: 31178
		TheColosuss2,
		// Token: 0x040079CB RID: 31179
		TheSquid,
		// Token: 0x040079CC RID: 31180
		TheWhale,
		// Token: 0x040079CD RID: 31181
		TheJackal3,
		// Token: 0x040079CE RID: 31182
		TheFox3,
		// Token: 0x040079CF RID: 31183
		TheWolf4,
		// Token: 0x040079D0 RID: 31184
		TheTiger3,
		// Token: 0x040079D1 RID: 31185
		TheMammoth4,
		// Token: 0x040079D2 RID: 31186
		TheColosuss3,
		// Token: 0x040079D3 RID: 31187
		TheJackal4,
		// Token: 0x040079D4 RID: 31188
		TheFox4,
		// Token: 0x040079D5 RID: 31189
		TheWolf5,
		// Token: 0x040079D6 RID: 31190
		TheTiger4,
		// Token: 0x040079D7 RID: 31191
		TheMammoth5,
		// Token: 0x040079D8 RID: 31192
		Life5,
		// Token: 0x040079D9 RID: 31193
		Life6,
		// Token: 0x040079DA RID: 31194
		Life7,
		// Token: 0x040079DB RID: 31195
		Substinence,
		// Token: 0x040079DC RID: 31196
		Substinence2,
		// Token: 0x040079DD RID: 31197
		Substinence3,
		// Token: 0x040079DE RID: 31198
		Vita,
		// Token: 0x040079DF RID: 31199
		Vita2,
		// Token: 0x040079E0 RID: 31200
		Vita3,
		// Token: 0x040079E1 RID: 31201
		Life8,
		// Token: 0x040079E2 RID: 31202
		Life9,
		// Token: 0x040079E3 RID: 31203
		Substinence4,
		// Token: 0x040079E4 RID: 31204
		Substinence5,
		// Token: 0x040079E5 RID: 31205
		Vita4,
		// Token: 0x040079E6 RID: 31206
		Vita5,
		// Token: 0x040079E7 RID: 31207
		Life10,
		// Token: 0x040079E8 RID: 31208
		Substinence6,
		// Token: 0x040079E9 RID: 31209
		Vita6,
		// Token: 0x040079EA RID: 31210
		Spirit,
		// Token: 0x040079EB RID: 31211
		Hope,
		// Token: 0x040079EC RID: 31212
		TheLeech2,
		// Token: 0x040079ED RID: 31213
		TheLocust2,
		// Token: 0x040079EE RID: 31214
		TheLamprey,
		// Token: 0x040079EF RID: 31215
		TheLeech3,
		// Token: 0x040079F0 RID: 31216
		TheLocust3,
		// Token: 0x040079F1 RID: 31217
		TheLamprey2,
		// Token: 0x040079F2 RID: 31218
		TheLeech4,
		// Token: 0x040079F3 RID: 31219
		TheBat2,
		// Token: 0x040079F4 RID: 31220
		TheWraith,
		// Token: 0x040079F5 RID: 31221
		TheVampire2,
		// Token: 0x040079F6 RID: 31222
		TheBat3,
		// Token: 0x040079F7 RID: 31223
		TheWraith2,
		// Token: 0x040079F8 RID: 31224
		TheVampire3,
		// Token: 0x040079F9 RID: 31225
		TheBat4,
		// Token: 0x040079FA RID: 31226
		Defiance2,
		// Token: 0x040079FB RID: 31227
		Amelioration2,
		// Token: 0x040079FC RID: 31228
		Remedy2,
		// Token: 0x040079FD RID: 31229
		Simplicity2,
		// Token: 0x040079FE RID: 31230
		Ease2,
		// Token: 0x040079FF RID: 31231
		Freedom,
		// Token: 0x04007A00 RID: 31232
		Strength2,
		// Token: 0x04007A01 RID: 31233
		Might2,
		// Token: 0x04007A02 RID: 31234
		TheOx3,
		// Token: 0x04007A03 RID: 31235
		TheGiant3,
		// Token: 0x04007A04 RID: 31236
		TheTitan2,
		// Token: 0x04007A05 RID: 31237
		Atlus,
		// Token: 0x04007A06 RID: 31238
		Strength3,
		// Token: 0x04007A07 RID: 31239
		Might3,
		// Token: 0x04007A08 RID: 31240
		TheOx4,
		// Token: 0x04007A09 RID: 31241
		TheGiant4,
		// Token: 0x04007A0A RID: 31242
		TheTitan3,
		// Token: 0x04007A0B RID: 31243
		Strength4,
		// Token: 0x04007A0C RID: 31244
		Might4,
		// Token: 0x04007A0D RID: 31245
		TheOx5,
		// Token: 0x04007A0E RID: 31246
		TheGiant5,
		// Token: 0x04007A0F RID: 31247
		Strength5,
		// Token: 0x04007A10 RID: 31248
		Strength6,
		// Token: 0x04007A11 RID: 31249
		Strength7,
		// Token: 0x04007A12 RID: 31250
		Strength8,
		// Token: 0x04007A13 RID: 31251
		Strength9,
		// Token: 0x04007A14 RID: 31252
		Strength10,
		// Token: 0x04007A15 RID: 31253
		Virility,
		// Token: 0x04007A16 RID: 31254
		Pacing2,
		// Token: 0x04007A17 RID: 31255
		Haste2,
		// Token: 0x04007A18 RID: 31256
		Speed2,
		// Token: 0x04007A19 RID: 31257
		Traveling,
		// Token: 0x04007A1A RID: 31258
		Acceleration,
		// Token: 0x04007A1B RID: 31259
		Inertia,
		// Token: 0x04007A1C RID: 31260
		Inertia2,
		// Token: 0x04007A1D RID: 31261
		Inertia3,
		// Token: 0x04007A1E RID: 31262
		Self,
		// Token: 0x04007A1F RID: 31263
		FastRepair,
		// Token: 0x04007A20 RID: 31264
		Ages,
		// Token: 0x04007A21 RID: 31265
		Replenishing,
		// Token: 0x04007A22 RID: 31266
		Propogation,
		// Token: 0x04007A23 RID: 31267
		TheKraken,
		// Token: 0x04007A24 RID: 31268
		Memory,
		// Token: 0x04007A25 RID: 31269
		TheElephant,
		// Token: 0x04007A26 RID: 31270
		Unused410,
		// Token: 0x04007A27 RID: 31271
		Unused411,
		// Token: 0x04007A28 RID: 31272
		Unused412,
		// Token: 0x04007A29 RID: 31273
		Unused413,
		// Token: 0x04007A2A RID: 31274
		Unused414,
		// Token: 0x04007A2B RID: 31275
		Unused415,
		// Token: 0x04007A2C RID: 31276
		Unused416,
		// Token: 0x04007A2D RID: 31277
		Unused417,
		// Token: 0x04007A2E RID: 31278
		Firebolts,
		// Token: 0x04007A2F RID: 31279
		Firebolts2,
		// Token: 0x04007A30 RID: 31280
		Firebolts3,
		// Token: 0x04007A31 RID: 31281
		ChargedShield,
		// Token: 0x04007A32 RID: 31282
		ChargedShield2,
		// Token: 0x04007A33 RID: 31283
		ChargedShield3,
		// Token: 0x04007A34 RID: 31284
		Icebolt,
		// Token: 0x04007A35 RID: 31285
		Unused425,
		// Token: 0x04007A36 RID: 31286
		Unused426,
		// Token: 0x04007A37 RID: 31287
		Unused427,
		// Token: 0x04007A38 RID: 31288
		FrostShield,
		// Token: 0x04007A39 RID: 31289
		Unused429,
		// Token: 0x04007A3A RID: 31290
		Unused430,
		// Token: 0x04007A3B RID: 31291
		Unused431,
		// Token: 0x04007A3C RID: 31292
		Nova,
		// Token: 0x04007A3D RID: 31293
		Nova2,
		// Token: 0x04007A3E RID: 31294
		NovaShield,
		// Token: 0x04007A3F RID: 31295
		NovaShield2,
		// Token: 0x04007A40 RID: 31296
		NovaShield3,
		// Token: 0x04007A41 RID: 31297
		Lightning3,
		// Token: 0x04007A42 RID: 31298
		Unused438,
		// Token: 0x04007A43 RID: 31299
		Unused439,
		// Token: 0x04007A44 RID: 31300
		Unused440,
		// Token: 0x04007A45 RID: 31301
		Unused441,
		// Token: 0x04007A46 RID: 31302
		ChainLightning,
		// Token: 0x04007A47 RID: 31303
		ChainLightning2,
		// Token: 0x04007A48 RID: 31304
		ChainLightning3,
		// Token: 0x04007A49 RID: 31305
		Unused445,
		// Token: 0x04007A4A RID: 31306
		Unused446,
		// Token: 0x04007A4B RID: 31307
		Unused447,
		// Token: 0x04007A4C RID: 31308
		Unused448,
		// Token: 0x04007A4D RID: 31309
		Unused449,
		// Token: 0x04007A4E RID: 31310
		Unused450,
		// Token: 0x04007A4F RID: 31311
		Unused451,
		// Token: 0x04007A50 RID: 31312
		Unused452,
		// Token: 0x04007A51 RID: 31313
		Unused453,
		// Token: 0x04007A52 RID: 31314
		HydraShield,
		// Token: 0x04007A53 RID: 31315
		Unused455,
		// Token: 0x04007A54 RID: 31316
		Unused456,
		// Token: 0x04007A55 RID: 31317
		Unused457,
		// Token: 0x04007A56 RID: 31318
		MagicArrows,
		// Token: 0x04007A57 RID: 31319
		Unused459,
		// Token: 0x04007A58 RID: 31320
		Unused460,
		// Token: 0x04007A59 RID: 31321
		FireArrows,
		// Token: 0x04007A5A RID: 31322
		InnerSight,
		// Token: 0x04007A5B RID: 31323
		InnerSight2,
		// Token: 0x04007A5C RID: 31324
		Unused464,
		// Token: 0x04007A5D RID: 31325
		Unused465,
		// Token: 0x04007A5E RID: 31326
		ColdArrows,
		// Token: 0x04007A5F RID: 31327
		ColdArrows2,
		// Token: 0x04007A60 RID: 31328
		MultipleShot,
		// Token: 0x04007A61 RID: 31329
		MultipleShot2,
		// Token: 0x04007A62 RID: 31330
		PowerStrike,
		// Token: 0x04007A63 RID: 31331
		PowerStrike2,
		// Token: 0x04007A64 RID: 31332
		Unused472,
		// Token: 0x04007A65 RID: 31333
		Unused473,
		// Token: 0x04007A66 RID: 31334
		ExplodingArrows,
		// Token: 0x04007A67 RID: 31335
		ExplodingArrows2,
		// Token: 0x04007A68 RID: 31336
		Unused476,
		// Token: 0x04007A69 RID: 31337
		Unused477,
		// Token: 0x04007A6A RID: 31338
		Unused478,
		// Token: 0x04007A6B RID: 31339
		Unused479,
		// Token: 0x04007A6C RID: 31340
		Unused480,
		// Token: 0x04007A6D RID: 31341
		Unused481,
		// Token: 0x04007A6E RID: 31342
		IceArrows,
		// Token: 0x04007A6F RID: 31343
		IceArrows2,
		// Token: 0x04007A70 RID: 31344
		Unused484,
		// Token: 0x04007A71 RID: 31345
		Unused485,
		// Token: 0x04007A72 RID: 31346
		ChargedStrike,
		// Token: 0x04007A73 RID: 31347
		ChargedStrike2,
		// Token: 0x04007A74 RID: 31348
		Unused488,
		// Token: 0x04007A75 RID: 31349
		Unused489,
		// Token: 0x04007A76 RID: 31350
		Unused490,
		// Token: 0x04007A77 RID: 31351
		Unused491,
		// Token: 0x04007A78 RID: 31352
		Unused492,
		// Token: 0x04007A79 RID: 31353
		Unused493,
		// Token: 0x04007A7A RID: 31354
		FreezingArrows,
		// Token: 0x04007A7B RID: 31355
		FreezingArrows2,
		// Token: 0x04007A7C RID: 31356
		LightningStrike,
		// Token: 0x04007A7D RID: 31357
		LightningStrike2,
		// Token: 0x04007A7E RID: 31358
		Unused498,
		// Token: 0x04007A7F RID: 31359
		Unused499,
		// Token: 0x04007A80 RID: 31360
		FireBolts,
		// Token: 0x04007A81 RID: 31361
		FireBolts2,
		// Token: 0x04007A82 RID: 31362
		ChargedBolts,
		// Token: 0x04007A83 RID: 31363
		ChargedBolts2,
		// Token: 0x04007A84 RID: 31364
		IceBolts,
		// Token: 0x04007A85 RID: 31365
		IceBolts2,
		// Token: 0x04007A86 RID: 31366
		Unused506,
		// Token: 0x04007A87 RID: 31367
		Unused507,
		// Token: 0x04007A88 RID: 31368
		Unused508,
		// Token: 0x04007A89 RID: 31369
		Unused509,
		// Token: 0x04007A8A RID: 31370
		Telekinesis,
		// Token: 0x04007A8B RID: 31371
		Telekinesis2,
		// Token: 0x04007A8C RID: 31372
		FrostNovas,
		// Token: 0x04007A8D RID: 31373
		FrostNovas2,
		// Token: 0x04007A8E RID: 31374
		IceBlasts,
		// Token: 0x04007A8F RID: 31375
		IceBlasts2,
		// Token: 0x04007A90 RID: 31376
		Unused516,
		// Token: 0x04007A91 RID: 31377
		Unused517,
		// Token: 0x04007A92 RID: 31378
		FireBalls,
		// Token: 0x04007A93 RID: 31379
		FireBalls2,
		// Token: 0x04007A94 RID: 31380
		Novas,
		// Token: 0x04007A95 RID: 31381
		Novas2,
		// Token: 0x04007A96 RID: 31382
		Lightning4,
		// Token: 0x04007A97 RID: 31383
		Lightning5,
		// Token: 0x04007A98 RID: 31384
		Unused524,
		// Token: 0x04007A99 RID: 31385
		Unused525,
		// Token: 0x04007A9A RID: 31386
		Unused526,
		// Token: 0x04007A9B RID: 31387
		Unused527,
		// Token: 0x04007A9C RID: 31388
		Enchantment,
		// Token: 0x04007A9D RID: 31389
		Enchantment2,
		// Token: 0x04007A9E RID: 31390
		ChainLightning4,
		// Token: 0x04007A9F RID: 31391
		ChainLightning5,
		// Token: 0x04007AA0 RID: 31392
		Teleportation,
		// Token: 0x04007AA1 RID: 31393
		Teleportation2,
		// Token: 0x04007AA2 RID: 31394
		GlacialSpikes,
		// Token: 0x04007AA3 RID: 31395
		GlacialSpikes2,
		// Token: 0x04007AA4 RID: 31396
		Meteors,
		// Token: 0x04007AA5 RID: 31397
		Meteors2,
		// Token: 0x04007AA6 RID: 31398
		Unused538,
		// Token: 0x04007AA7 RID: 31399
		Unused539,
		// Token: 0x04007AA8 RID: 31400
		Unused540,
		// Token: 0x04007AA9 RID: 31401
		Unused541,
		// Token: 0x04007AAA RID: 31402
		Blizzards,
		// Token: 0x04007AAB RID: 31403
		Blizzards2,
		// Token: 0x04007AAC RID: 31404
		Unused544,
		// Token: 0x04007AAD RID: 31405
		Unused545,
		// Token: 0x04007AAE RID: 31406
		Unused546,
		// Token: 0x04007AAF RID: 31407
		Unused547,
		// Token: 0x04007AB0 RID: 31408
		FrozenOrbs,
		// Token: 0x04007AB1 RID: 31409
		FrozenOrbs2,
		// Token: 0x04007AB2 RID: 31410
		Unused550,
		// Token: 0x04007AB3 RID: 31411
		Unused551,
		// Token: 0x04007AB4 RID: 31412
		Teeth,
		// Token: 0x04007AB5 RID: 31413
		Teeth2,
		// Token: 0x04007AB6 RID: 31414
		Unused554,
		// Token: 0x04007AB7 RID: 31415
		Unused555,
		// Token: 0x04007AB8 RID: 31416
		Unused556,
		// Token: 0x04007AB9 RID: 31417
		Unused557,
		// Token: 0x04007ABA RID: 31418
		DimVision,
		// Token: 0x04007ABB RID: 31419
		DimVision2,
		// Token: 0x04007ABC RID: 31420
		Weaken,
		// Token: 0x04007ABD RID: 31421
		Weaken2,
		// Token: 0x04007ABE RID: 31422
		PoisonDagger,
		// Token: 0x04007ABF RID: 31423
		PoisonDagger2,
		// Token: 0x04007AC0 RID: 31424
		Unused564,
		// Token: 0x04007AC1 RID: 31425
		Unused565,
		// Token: 0x04007AC2 RID: 31426
		Unused566,
		// Token: 0x04007AC3 RID: 31427
		Unused567,
		// Token: 0x04007AC4 RID: 31428
		Unused568,
		// Token: 0x04007AC5 RID: 31429
		Unused569,
		// Token: 0x04007AC6 RID: 31430
		Terror,
		// Token: 0x04007AC7 RID: 31431
		Terror2,
		// Token: 0x04007AC8 RID: 31432
		Unused572,
		// Token: 0x04007AC9 RID: 31433
		Unused573,
		// Token: 0x04007ACA RID: 31434
		Unused574,
		// Token: 0x04007ACB RID: 31435
		Unused575,
		// Token: 0x04007ACC RID: 31436
		Confusion,
		// Token: 0x04007ACD RID: 31437
		Confusion2,
		// Token: 0x04007ACE RID: 31438
		LifeTap,
		// Token: 0x04007ACF RID: 31439
		LifeTap2,
		// Token: 0x04007AD0 RID: 31440
		Unused580,
		// Token: 0x04007AD1 RID: 31441
		Unused581,
		// Token: 0x04007AD2 RID: 31442
		BoneSpears,
		// Token: 0x04007AD3 RID: 31443
		BoneSpears2,
		// Token: 0x04007AD4 RID: 31444
		Unused584,
		// Token: 0x04007AD5 RID: 31445
		Unused585,
		// Token: 0x04007AD6 RID: 31446
		Attraction,
		// Token: 0x04007AD7 RID: 31447
		Attraction2,
		// Token: 0x04007AD8 RID: 31448
		Unused588,
		// Token: 0x04007AD9 RID: 31449
		Unused589,
		// Token: 0x04007ADA RID: 31450
		Unused590,
		// Token: 0x04007ADB RID: 31451
		Unused591,
		// Token: 0x04007ADC RID: 31452
		Unused592,
		// Token: 0x04007ADD RID: 31453
		Unused593,
		// Token: 0x04007ADE RID: 31454
		LowerResistance,
		// Token: 0x04007ADF RID: 31455
		LowerResistance2,
		// Token: 0x04007AE0 RID: 31456
		PoisonNovas,
		// Token: 0x04007AE1 RID: 31457
		PoisonNovas2,
		// Token: 0x04007AE2 RID: 31458
		BoneSpirits,
		// Token: 0x04007AE3 RID: 31459
		BoneSpirits2,
		// Token: 0x04007AE4 RID: 31460
		Unused600,
		// Token: 0x04007AE5 RID: 31461
		Unused601,
		// Token: 0x04007AE6 RID: 31462
		Unused602,
		// Token: 0x04007AE7 RID: 31463
		Unused603,
		// Token: 0x04007AE8 RID: 31464
		Sacrifice,
		// Token: 0x04007AE9 RID: 31465
		Sacrifice2,
		// Token: 0x04007AEA RID: 31466
		HolyBolts,
		// Token: 0x04007AEB RID: 31467
		HolyBolts2,
		// Token: 0x04007AEC RID: 31468
		Zeal,
		// Token: 0x04007AED RID: 31469
		Zeal2,
		// Token: 0x04007AEE RID: 31470
		Vengeance,
		// Token: 0x04007AEF RID: 31471
		Vengeance2,
		// Token: 0x04007AF0 RID: 31472
		BlessedHammers,
		// Token: 0x04007AF1 RID: 31473
		BlessedHammers2,
		// Token: 0x04007AF2 RID: 31474
		Unused614,
		// Token: 0x04007AF3 RID: 31475
		Unused615,
		// Token: 0x04007AF4 RID: 31476
		Unused616,
		// Token: 0x04007AF5 RID: 31477
		Unused617,
		// Token: 0x04007AF6 RID: 31478
		Bashing2,
		// Token: 0x04007AF7 RID: 31479
		Bashing3,
		// Token: 0x04007AF8 RID: 31480
		Unused620,
		// Token: 0x04007AF9 RID: 31481
		Unused621,
		// Token: 0x04007AFA RID: 31482
		Unused622,
		// Token: 0x04007AFB RID: 31483
		Unused623,
		// Token: 0x04007AFC RID: 31484
		Unused624,
		// Token: 0x04007AFD RID: 31485
		Unused625,
		// Token: 0x04007AFE RID: 31486
		Unused626,
		// Token: 0x04007AFF RID: 31487
		Unused627,
		// Token: 0x04007B00 RID: 31488
		Stunning,
		// Token: 0x04007B01 RID: 31489
		Stunning2,
		// Token: 0x04007B02 RID: 31490
		Unused630,
		// Token: 0x04007B03 RID: 31491
		Unused631,
		// Token: 0x04007B04 RID: 31492
		Concentration,
		// Token: 0x04007B05 RID: 31493
		Concentration2,
		// Token: 0x04007B06 RID: 31494
		Unused634,
		// Token: 0x04007B07 RID: 31495
		Unused635,
		// Token: 0x04007B08 RID: 31496
		Unused636,
		// Token: 0x04007B09 RID: 31497
		Unused637,
		// Token: 0x04007B0A RID: 31498
		GrimWard,
		// Token: 0x04007B0B RID: 31499
		GrimWard2,
		// Token: 0x04007B0C RID: 31500
		Unused640,
		// Token: 0x04007B0D RID: 31501
		Unused641,
		// Token: 0x04007B0E RID: 31502
		Unused642,
		// Token: 0x04007B0F RID: 31503
		Unused643,
		// Token: 0x04007B10 RID: 31504
		Firestorms,
		// Token: 0x04007B11 RID: 31505
		Firestorms2,
		// Token: 0x04007B12 RID: 31506
		Unused644,
		// Token: 0x04007B13 RID: 31507
		Unused645,
		// Token: 0x04007B14 RID: 31508
		Eruption,
		// Token: 0x04007B15 RID: 31509
		Eruption2,
		// Token: 0x04007B16 RID: 31510
		Unused650,
		// Token: 0x04007B17 RID: 31511
		Unused651,
		// Token: 0x04007B18 RID: 31512
		Twister,
		// Token: 0x04007B19 RID: 31513
		Twister2,
		// Token: 0x04007B1A RID: 31514
		Volcano,
		// Token: 0x04007B1B RID: 31515
		Volcano2,
		// Token: 0x04007B1C RID: 31516
		Tornado,
		// Token: 0x04007B1D RID: 31517
		Tornado2,
		// Token: 0x04007B1E RID: 31518
		Unused658,
		// Token: 0x04007B1F RID: 31519
		Unused659,
		// Token: 0x04007B20 RID: 31520
		Unused660,
		// Token: 0x04007B21 RID: 31521
		Unused661,
		// Token: 0x04007B22 RID: 31522
		DamageAmplification,
		// Token: 0x04007B23 RID: 31523
		TheIcicle2,
		// Token: 0x04007B24 RID: 31524
		TheGlacier3,
		// Token: 0x04007B25 RID: 31525
		Fire3,
		// Token: 0x04007B26 RID: 31526
		Burning3,
		// Token: 0x04007B27 RID: 31527
		Lightning6,
		// Token: 0x04007B28 RID: 31528
		Thunder3,
		// Token: 0x04007B29 RID: 31529
		Daring2,
		// Token: 0x04007B2A RID: 31530
		Daring3,
		// Token: 0x04007B2B RID: 31531
		Knowledge2,
		// Token: 0x04007B2C RID: 31532
		Knowledge3,
		// Token: 0x04007B2D RID: 31533
		Virility2,
		// Token: 0x04007B2E RID: 31534
		Virility3,
		// Token: 0x04007B2F RID: 31535
		Readiness3,
		// Token: 0x04007B30 RID: 31536
		Craftsmanship6,
		// Token: 0x04007B31 RID: 31537
		Quality5,
		// Token: 0x04007B32 RID: 31538
		Maiming7,
		// Token: 0x04007B33 RID: 31539
		Craftsmanship7,
		// Token: 0x04007B34 RID: 31540
		Quality6,
		// Token: 0x04007B35 RID: 31541
		Craftsmanship8,
		// Token: 0x04007B36 RID: 31542
		Blight5,
		// Token: 0x04007B37 RID: 31543
		Venom3,
		// Token: 0x04007B38 RID: 31544
		Pestilence3,
		// Token: 0x04007B39 RID: 31545
		Anthrax2,
		// Token: 0x04007B3A RID: 31546
		Blight6,
		// Token: 0x04007B3B RID: 31547
		Venom4,
		// Token: 0x04007B3C RID: 31548
		Pestilence4,
		// Token: 0x04007B3D RID: 31549
		Anthrax3,
		// Token: 0x04007B3E RID: 31550
		Blight7,
		// Token: 0x04007B3F RID: 31551
		Venom5,
		// Token: 0x04007B40 RID: 31552
		Pestilence5,
		// Token: 0x04007B41 RID: 31553
		Anthrax4,
		// Token: 0x04007B42 RID: 31554
		Frost5,
		// Token: 0x04007B43 RID: 31555
		TheIcicle3,
		// Token: 0x04007B44 RID: 31556
		TheGlacier4,
		// Token: 0x04007B45 RID: 31557
		Winter2,
		// Token: 0x04007B46 RID: 31558
		Frost6,
		// Token: 0x04007B47 RID: 31559
		TheIcicle4,
		// Token: 0x04007B48 RID: 31560
		TheGlacier5,
		// Token: 0x04007B49 RID: 31561
		Winter3,
		// Token: 0x04007B4A RID: 31562
		Frost7,
		// Token: 0x04007B4B RID: 31563
		TheIcicle5,
		// Token: 0x04007B4C RID: 31564
		TheGlacier6,
		// Token: 0x04007B4D RID: 31565
		Winter4,
		// Token: 0x04007B4E RID: 31566
		Flame5,
		// Token: 0x04007B4F RID: 31567
		Fire4,
		// Token: 0x04007B50 RID: 31568
		Burning4,
		// Token: 0x04007B51 RID: 31569
		Incineration2,
		// Token: 0x04007B52 RID: 31570
		Flame6,
		// Token: 0x04007B53 RID: 31571
		Fire5,
		// Token: 0x04007B54 RID: 31572
		Burning5,
		// Token: 0x04007B55 RID: 31573
		Incineration3,
		// Token: 0x04007B56 RID: 31574
		Flame7,
		// Token: 0x04007B57 RID: 31575
		Fire6,
		// Token: 0x04007B58 RID: 31576
		Burning6,
		// Token: 0x04007B59 RID: 31577
		Incineration4,
		// Token: 0x04007B5A RID: 31578
		Shock5,
		// Token: 0x04007B5B RID: 31579
		Lightning7,
		// Token: 0x04007B5C RID: 31580
		Thunder4,
		// Token: 0x04007B5D RID: 31581
		Storms2,
		// Token: 0x04007B5E RID: 31582
		Shock6,
		// Token: 0x04007B5F RID: 31583
		Lightning8,
		// Token: 0x04007B60 RID: 31584
		Thunder5,
		// Token: 0x04007B61 RID: 31585
		Storms3,
		// Token: 0x04007B62 RID: 31586
		Shock7,
		// Token: 0x04007B63 RID: 31587
		Lightning9,
		// Token: 0x04007B64 RID: 31588
		Thunder6,
		// Token: 0x04007B65 RID: 31589
		Storms4,
		// Token: 0x04007B66 RID: 31590
		Dexterity12,
		// Token: 0x04007B67 RID: 31591
		Dexterity13,
		// Token: 0x04007B68 RID: 31592
		Strength11,
		// Token: 0x04007B69 RID: 31593
		Strength12,
		// Token: 0x04007B6A RID: 31594
		Thorns3,
		// Token: 0x04007B6B RID: 31595
		Frost8,
		// Token: 0x04007B6C RID: 31596
		Flame8,
		// Token: 0x04007B6D RID: 31597
		Blight8,
		// Token: 0x04007B6E RID: 31598
		Shock8,
		// Token: 0x04007B6F RID: 31599
		Regeneration7,
		// Token: 0x04007B70 RID: 31600
		Energy6,
		// Token: 0x04007B71 RID: 31601
		Light3,
		// Token: 0x04007B72 RID: 31602
		TheLeech5,
		// Token: 0x04007B73 RID: 31603
		TheLocust4,
		// Token: 0x04007B74 RID: 31604
		TheLamprey3,
		// Token: 0x04007B75 RID: 31605
		TheBat5,
		// Token: 0x04007B76 RID: 31606
		TheWraith3,
		// Token: 0x04007B77 RID: 31607
		TheVampire4
	}
}
