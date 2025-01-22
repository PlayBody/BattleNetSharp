using System;
using Fenris.AttributeSerializer;
using Fenris.DemonSummoning;
using Fenris.Hireling;
using Fenris.Items;
using Fenris.Online;
using Fenris.Profile;
using Fenris.Quests;
using Fenris.Trade;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000178 RID: 376
	public static class HeroReflection
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x0009777C File Offset: 0x0009597C
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroReflection.descriptor;
			}
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00097794 File Offset: 0x00095994
		static HeroReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgpIZXJvLnByb3RvEgtGZW5yaXMuSGVybxoZQXR0cmlidXRlU2VyaWFsaXpl", "ci5wcm90bxoOSGlyZWxpbmcucHJvdG8aC0l0ZW1zLnByb3RvGhBIZXJvQ29t", "bW9uLnByb3RvGgtRdWVzdC5wcm90bxoURGVtb25TdW1tb25pbmcucHJvdG8a", "C1RyYWRlLnByb3RvGg1Qcm9maWxlLnByb3RvGhJPbmxpbmVDb21tb24ucHJv", "dG8iqAIKF0FwcGVhcmFuY2VDdXN0b21pemF0aW9uEhQKCHNub19mYWNlGA4g", "ASgPOgItMRIaCg5zbm9faGFpcl9jb2xvchgNIAEoDzoCLTESGgoOc25vX2hh", "aXJfc3R5bGUYDyABKA86Ai0xEhsKD3Nub19mYWNpYWxfaGFpchgQIAEoDzoC", "LTESGQoNc25vX2V5ZV9jb2xvchgFIAEoDzoCLTESGAoQc2tpbl9jb2xvcl9p", "bmRleBgGIAEoBRIdChFzbm9fbWFya2luZ19zaGFwZRgHIAEoDzoCLTESHQoR", "c25vX21hcmtpbmdfY29sb3IYDCABKA86Ai0xEhcKC3Nub19qZXdlbHJ5GAkg",
				"ASgPOgItMRIWCgpzbm9fbWFrZXVwGAsgASgPOgItMSKgAgoaQXBwZWFyYW5j", "ZUN1c3RvbWl6YXRpb25PbGQSFQoNcGVyc29uYV9pbmRleBgBIAEoBRIYChBo", "YWlyX2NvbG9yX2luZGV4GAIgASgFEhgKEGhhaXJfc3R5bGVfaW5kZXgYAyAB", "KAUSGQoRZmFjaWFsX2hhaXJfaW5kZXgYBCABKAUSFwoPZXllX2NvbG9yX2lu", "ZGV4GAUgASgFEhgKEHNraW5fY29sb3JfaW5kZXgYBiABKAUSHQoRc25vX21h", "cmtpbmdfc2hhcGUYByABKA86Ai0xEhsKE21hcmtpbmdfY29sb3JfaW5kZXgY", "CCABKAUSFwoLc25vX2pld2VscnkYCSABKA86Ai0xEhQKDG1ha2V1cF9pbmRl", "eBgKIAEoBSIrChBTYXZlZERpZ2VzdFBsYWNlEhcKC3Nub19zdWJ6b25lGAEg", "ASgPOgItMSLJBAoGRGlnZXN0Eg8KB3ZlcnNpb24YASABKA0SDwoHaGVyb19p", "ZBgCIAEoDBIRCgloZXJvX25hbWUYAyABKAkSFQoJc25vX2NsYXNzGAQgASgP",
				"OgItMRINCgVsZXZlbBgFIAEoERIUCgxwbGF5ZXJfZmxhZ3MYBiABKA0SNgoQ", "dmlzdWFsX2VxdWlwbWVudBgHIAEoCzIcLkZlbnJpcy5IZXJvLlZpc3VhbEVx", "dWlwbWVudBIZChFsYXN0X3BsYXllZF9xdWVzdBgNIAEoDxIeChZsYXN0X3Bs", "YXllZF9xdWVzdF9zdGVwGA4gASgREhMKC3RpbWVfcGxheWVkGA8gASgNEhMK", "C2NyZWF0ZV90aW1lGBEgASgNEhgKEGxhc3RfcGxheWVkX3RpbWUYEiABKA0S", "EwoLZGVsZXRlX3RpbWUYEyABKAQSRgoYYXBwZWFyYW5jZV9jdXN0b21pemF0", "aW9uGBQgASgLMiQuRmVucmlzLkhlcm8uQXBwZWFyYW5jZUN1c3RvbWl6YXRp", "b24SMQoKbGFzdF9wbGFjZRgVIAEoCzIdLkZlbnJpcy5IZXJvLlNhdmVkRGln", "ZXN0UGxhY2USFgoOc2Vhc29uX2NyZWF0ZWQYFiABKA0SFwoPbGFzdF93b3Js", "ZF90aWVyGBcgASgFEhkKDm1heF93b3JsZF90aWVyGBggASgFOgExEh8KF2hl",
				"cm9fbmFtZV9mb3JjZV9yZW5hbWVkGBkgASgIEhoKEnJlcG9ydGVkX2hlcm9f", "bmFtZRgaIAEoCSIyCgZWZWN0b3ISDAoBeBgBIAEoAjoBMBIMCgF5GAIgASgC", "OgEwEgwKAXoYAyABKAI6ATAidAoPU2F2ZWRXb3JsZFBsYWNlEhUKCXNub193", "b3JsZBgBIAEoDzoCLTESIAoDcG9zGAIgASgLMhMuRmVucmlzLkhlcm8uVmVj", "dG9yEhUKDWVudHJhbmNlX2d1aWQYAyABKA0SEQoJZHJsZ19zZWVkGAQgASgP", "IkQKGVNhdmVkU2tpbGxFeHRyYUFuZEFyc2VuYWwSFQoJc25vX3Bvd2VyGAEg", "ASgPOgItMRIQCgRzbG90GAMgASgFOgItMSI/ChJTYXZlZFNraWxsVHJlZU5v", "ZGUSGwoHbm9kZV9pZBgBIAEoDToKNDI5NDk2NzI5NRIMCgRyYW5rGAIgASgN", "In4KEVNhdmVkVHJhbnNmZXJJdGVtEjEKC3dvcmxkX3BsYWNlGAEgASgLMhwu", "RmVucmlzLkhlcm8uU2F2ZWRXb3JsZFBsYWNlEg8KB2l0ZW1faWQYAiABKAkS",
				"JQoEaXRlbRgDIAEoCzIXLkZlbnJpcy5JdGVtcy5HZW5lcmF0b3IiuQEKGVNh", "dmVkVG93blBvcnRhbFJldHVybkRlc3QSMQoLd29ybGRfcGxhY2UYASABKAsy", "HC5GZW5yaXMuSGVyby5TYXZlZFdvcmxkUGxhY2USGgoOc25vX2xldmVsX2Fy", "ZWEYAiABKA86Ai0xEhgKEGV4cGlyZV90aW1lc3RhbXAYAyABKAQSMwoLbmVh", "cmJ5X2l0ZW0YBCADKAsyHi5GZW5yaXMuSGVyby5TYXZlZFRyYW5zZmVySXRl", "bSJNChRTYXZlZERyb3BwZWRJdGVtRGF0YRI1Cg1kcm9wcGVkX2l0ZW1zGAEg", "AygLMh4uRmVucmlzLkhlcm8uU2F2ZWRUcmFuc2Zlckl0ZW0ilgIKFVNwYXdu", "VHJhY2tpbmdLZXlWYWx1ZRIWCg5rZXlfbWFya2VyX3NubxgBIAEoBRIRCglr", "ZXlfaW5kZXgYAiABKAUSIwobdmFsdWVfdHJhbnNmZXJyZWRfdGltZXN0YW1w", "GAMgASgSEhwKEHZhbHVlX2JvdW50eV9zbm8YBSABKA86Ai0xEhUKDXZhbHVl",
				"X2lzX3NvZnQYBiABKAgSFwoPdmFsdWVfZ2JpZF90eXBlGAcgASgPEhwKFHZh", "bHVlX3Nub19wb3B1bGF0aW9uGAggASgPEhsKE3ZhbHVlX3Nub19sZXZlbGFy", "ZWEYCSABKA8SJAocdmFsdWVfaXNfbG9jYWxfZXZlbnRfc3Bhd25lchgKIAEo", "CCJKChhDb21wbGV0ZWRSZXBlYXRhYmxlUXVlc3QSFQoJc25vX3F1ZXN0GAEg", "ASgPOgItMRIXCg9sYXN0X29jY3VycmVuY2UYAyABKAUiUAoOU2F2ZWRUcmFu", "c21vZ3MSLAoJdHJhbnNtb2dzGAEgAygLMhkuRmVucmlzLkhlcm8uVHJhbnNt", "b2dTbG90EhAKCHVubG9ja2VkGAIgASgIIoIBChpUaW1lQmFzZWRTcGF3blRy", "YWNraW5nRGF0YRIZChF0cmFja2VkX3RpbWVzdGFtcBgBIAEoAxISCgpnaXpt", "b19oYXNoGAIgASgNEhYKDmdpem1vX2Nvb2xkb3duGAMgASgNEh0KFW9jY3Vy", "cmVuY2VfZXhwaXJhdGlvbhgEIAEoDSKQAgoNQ3VzdG9taXphdGlvbhIdChFz",
				"bm9fcG90aW9uX2J1dHRvbhgBIAEoDzoCLTESSQoac29jaWFsX3doZWVsX2Nv", "bmZpZ3VyYXRpb24YAiABKAsyJS5GZW5yaXMuSGVyby5Tb2NpYWxXaGVlbENv", "bmZpZ3VyYXRpb24SMAoNdHJhbnNtb2dfc2xvdBgDIAMoCzIZLkZlbnJpcy5I", "ZXJvLlRyYW5zbW9nU2xvdBIzCg5zYXZlZF90cmFuc21vZxgEIAMoCzIbLkZl", "bnJpcy5IZXJvLlNhdmVkVHJhbnNtb2dzEi4KDHBsYXllcl90aXRsZRgFIAEo", "CzIYLkZlbnJpcy5IZXJvLlBsYXllclRpdGxlIlQKBlZlbmRvchIVCg1zZWVk", "X2ludGVydmFsGAEgASgFEhIKCnNlZWRfbGV2ZWwYAiABKAUSDAoEc2VlZBgD", "IAMoDRIRCglzb2xkX2l0ZW0YBCADKAQi2wMKBlF1ZXN0cxIzCgtzYXZlZF9x", "dWVzdBgBIAMoCzIeLkZlbnJpcy5RdWVzdHMuUXVlc3RTYXZlZFN0YXRlEhsK", "E3Nub19jb21wbGV0ZWRfcXVlc3QYAiADKA8SSQoaY29tcGxldGVkX3JlcGVh",
				"dGFibGVfcXVlc3QYAyADKAsyJS5GZW5yaXMuSGVyby5Db21wbGV0ZWRSZXBl", "YXRhYmxlUXVlc3QSMgoKcmVwdXRhdGlvbhgGIAEoCzIeLkZlbnJpcy5RdWVz", "dHMuU2F2ZWRSZXB1dGF0aW9uEjQKDHNhdmVkX2JvdW50eRgHIAMoCzIeLkZl", "bnJpcy5RdWVzdHMuUXVlc3RTYXZlZFN0YXRlEj8KEGNvbXBsZXRlZF9ib3Vu", "dHkYCCADKAsyJS5GZW5yaXMuSGVyby5Db21wbGV0ZWRSZXBlYXRhYmxlUXVl", "c3QSOwoMZGVtb25fc2Nyb2xsGAsgASgLMiUuRmVucmlzLkRlbW9uU3VtbW9u", "aW5nLkVxdWlwcGVkU2Nyb2xsEicKH21heF9uaWdodG1hcmVfZHVuZ2Vvbl9j", "b21wbGV0ZWQYDCABKBESIwobc3Viem9uZV9tb2RpZmllcl9vY2N1cnJlbmNl", "GA0gASgFIqkCCgtEaXNjb3ZlcmllcxIcChR1bmxvY2tlZF90b3duX3BvcnRh", "bBgBIAEoCBIuCgxsZWFybmVkX2xvcmUYAiABKAsyGC5GZW5yaXMuSGVyby5M",
				"ZWFybmVkTG9yZRI8ChNzYXZlZF9jb252ZXJzYXRpb25zGAMgASgLMh8uRmVu", "cmlzLkhlcm8uU2F2ZWRDb252ZXJzYXRpb25zEhoKEmFjdGl2YXRlZF93YXlw", "b2ludBgFIAMoDxIYChBzbm9fdW5sb2NrZWRfZm93GAYgAygPEh0KFWdiaWRf", "ZGlzY292ZXJlZF9jYWNoZRgHIAMoDxI5ChBjYW1wc19kaXNjb3ZlcmVkGAgg", "ASgLMh8uRmVucmlzLkhlcm8uQXNzZXRMaXN0RGF0YVN0b3JlIvUDCgZTa2ls", "bHMSKQoNYWN0aXZlX3NraWxscxgBIAMoCzISLkZlbnJpcy5IZXJvLlNraWxs", "EhUKDXNraWxsX3ZlcnNpb24YAiABKA0SGQoRc2tpbGxfa2l0X3ZlcnNpb24Y", "AyABKA0SQgoZcHVyY2hhc2VkX3NraWxsX3RyZWVfbm9kZRgGIAMoCzIfLkZl", "bnJpcy5IZXJvLlNhdmVkU2tpbGxUcmVlTm9kZRIyCh5sYXN0X3B1cmNoYXNl", "ZF9za2lsbF90cmVlX25vZGUYByABKA06CjQyOTQ5NjcyOTUSKQoNZW5jaGFu",
				"dF9za2lsbBgIIAMoCzISLkZlbnJpcy5IZXJvLlNraWxsEjkKDXBhcmFnb25f", "Ym9hcmQYCiABKAsyIi5GZW5yaXMuSGVyby5QYXJhZ29uQm9hcmRTYXZlZERh", "dGESOQoNcGFyYWdvbl9nbHlwaBgLIAEoCzIiLkZlbnJpcy5IZXJvLlBhcmFn", "b25HbHlwaFNhdmVkRGF0YRJEChRza2lsbF9leHRyYV9hcnNlbmFscxgNIAMo", "CzImLkZlbnJpcy5IZXJvLlNhdmVkU2tpbGxFeHRyYUFuZEFyc2VuYWwSLwoT", "Y2xhc3NfcGFzc2l2ZV9za2lsbBgOIAMoCzISLkZlbnJpcy5IZXJvLlNraWxs", "IqABCg1TcGF3blRyYWNraW5nEkoKGXRpbWVfYmFzZWRfc3Bhd25fdHJhY2tp", "bmcYASADKAsyJy5GZW5yaXMuSGVyby5UaW1lQmFzZWRTcGF3blRyYWNraW5n", "RGF0YRJDChdzcGF3bl90cmFja2luZ19tYXBfZGF0YRgCIAMoCzIiLkZlbnJp", "cy5IZXJvLlNwYXduVHJhY2tpbmdLZXlWYWx1ZSJxCgdSZXdhcmRzEjgKDXpv",
				"bmVfcHJvZ3Jlc3MYASADKAsyIS5GZW5yaXMuSGVyby5SZXdhcmRzLlpvbmVQ", "cm9ncmVzcxosCgxab25lUHJvZ3Jlc3MSHAoUcmV3YXJkX2NsYWltZWRfZmxh", "Z3MYASABKA0ixQMKCVNhdmVkRGF0YRITCgt0aW1lX3BsYXllZBgBIAEoDRI3", "ChNoaXJlbGluZ19zYXZlZF9kYXRhGAMgASgLMhouRmVucmlzLkhpcmVsaW5n", "LlNhdmVkRGF0YRIXCg9sYXN0X2xldmVsX3RpbWUYBCABKA0SNgoQbGFzdF93", "b3JsZF9wbGFjZRgFIAEoCzIcLkZlbnJpcy5IZXJvLlNhdmVkV29ybGRQbGFj", "ZRIgChRoZXJvX2RlYXRoX3dvcmxkX3NubxgNIAEoDzoCLTESMAoTaGVyb19k", "ZWF0aF9sb2NhdGlvbhgOIAEoCzITLkZlbnJpcy5IZXJvLlZlY3RvchJNChJk", "ZXNpZ25lcl92YXJpYWJsZXMYECABKAsyMS5GZW5yaXMuSGVyby5Bc3NldExp", "c3RFeERlc2lnbmVyVmFyaWFibGVEYXRhU3RvcmUSFgoObWF4X3dvcmxkX3Rp",
				"ZXIYESABKAUSFQoNYm91bnR5X3BvaW50cxgSIAMoDRIkChxuZWNyb19za2Vs", "ZXRvbl93YXJyaW9yX2NvdW50GBMgASgFEiEKGW5lY3JvX3NrZWxldG9uX21h", "Z2VfY291bnQYFCABKAUiwAQKD1NhdmVkRGVmaW5pdGlvbhIPCgd2ZXJzaW9u", "GAEgASgNEiMKBmRpZ2VzdBgCIAEoCzITLkZlbnJpcy5IZXJvLkRpZ2VzdBJF", "ChBzYXZlZF9hdHRyaWJ1dGVzGAMgASgLMisuRmVucmlzLkF0dHJpYnV0ZVNl", "cmlhbGl6ZXIuU2F2ZWRBdHRyaWJ1dGVzEioKCnNhdmVkX2RhdGEYBCABKAsy", "Fi5GZW5yaXMuSGVyby5TYXZlZERhdGESJQoFaXRlbXMYBSABKAsyFi5GZW5y", "aXMuSXRlbXMuSXRlbUxpc3QSMQoNY3VzdG9taXphdGlvbhgGIAEoCzIaLkZl", "bnJpcy5IZXJvLkN1c3RvbWl6YXRpb24SIwoGdmVuZG9yGAcgASgLMhMuRmVu", "cmlzLkhlcm8uVmVuZG9yEiMKBnF1ZXN0cxgIIAEoCzITLkZlbnJpcy5IZXJv",
				"LlF1ZXN0cxItCgtkaXNjb3ZlcmllcxgJIAEoCzIYLkZlbnJpcy5IZXJvLkRp", "c2NvdmVyaWVzEiMKBnNraWxscxgKIAEoCzITLkZlbnJpcy5IZXJvLlNraWxs", "cxIyCg5zcGF3bl90cmFja2luZxgLIAEoCzIaLkZlbnJpcy5IZXJvLlNwYXdu", "VHJhY2tpbmcSMQoQdHJhZGVfc2F2ZWRfZGF0YRgMIAEoCzIXLkZlbnJpcy5U", "cmFkZS5TYXZlZERhdGESJQoHcmV3YXJkcxgNIAEoCzIULkZlbnJpcy5IZXJv", "LlJld2FyZHMivwEKCkZhbGxlbkhlcm8SLAoHcHJvZmlsZRgCIAEoCzIbLkZl", "bnJpcy5Qcm9maWxlLkhlcm9Qcm9maWxlEhEKCWhlcm9fbmFtZRgDIAEoCRJG", "ChhhcHBlYXJhbmNlX2N1c3RvbWl6YXRpb24YBCABKAsyJC5GZW5yaXMuSGVy", "by5BcHBlYXJhbmNlQ3VzdG9taXphdGlvbhITCgt0aW1lX3BsYXllZBgFIAEo", "DRITCgtjcmVhdGVfdGltZRgGIAEoBCJcChBEZXNpZ25lclZhcmlhYmxlEhwK",
				"FGdiaWREZXNpZ25lclZhcmlhYmxlGAEgASgPEhUKDXBheWxvYWRfdmFsdWUY", "AiABKAUSEwoLcmVzZXRfdmFsdWUYAyABKAUiLAoMWm9uZVByb2dyZXNzEhwK", "FHJld2FyZF9jbGFpbWVkX2ZsYWdzGAEgASgNIucEChBIZXJvU3RhdGVEYXRh", "RGVmEhQKDHBsYXllcl9mbGFncxgBIAEoDRJAChJjdXN0b21pemF0aW9uX2Rh", "dGEYAiABKAsyJC5GZW5yaXMuSGVyby5BcHBlYXJhbmNlQ3VzdG9taXphdGlv", "bhIwCgpzYXZlZF9kYXRhGAMgASgLMhwuRmVucmlzLkhlcm8uU2F2ZWREZWZp", "bml0aW9uEkcKF3Rvd25fcG9ydGFsX3JldHVybl9kZXN0GAQgASgLMiYuRmVu", "cmlzLkhlcm8uU2F2ZWRUb3duUG9ydGFsUmV0dXJuRGVzdBIcChRjb21wbGV0", "ZWRfcXVlc3Rfc25vcxgFIAMoDxIgChhmb2dfb2Zfd2FyX3VubG9ja2VkX3Nu", "b3MYBiADKA8SSgobY29tcGxldGVkX3JlcGVhdGFibGVfcXVlc3RzGAcgAygL",
				"MiUuRmVucmlzLkhlcm8uQ29tcGxldGVkUmVwZWF0YWJsZVF1ZXN0EkEKEmNv", "bXBsZXRlZF9ib3VudGllcxgIIAMoCzIlLkZlbnJpcy5IZXJvLkNvbXBsZXRl", "ZFJlcGVhdGFibGVRdWVzdBIdChVjYW1wc19kaXNjb3ZlcmVkX3Nub3MYCSAD", "KA8SOQoSZGVzaWduZXJfdmFyaWFibGVzGAogAygLMh0uRmVucmlzLkhlcm8u", "RGVzaWduZXJWYXJpYWJsZRIgChhmb3VuZF9oaWRkZW5fY2FjaGVfZ2JpZHMY", "CyADKA8SNQoSem9uZV9wcm9ncmVzc19kYXRhGAwgAygLMhkuRmVucmlzLkhl", "cm8uWm9uZVByb2dyZXNzImcKFEhlcm9TdGF0ZURhdGFNZXNzYWdlEhcKD2dh", "bWVfYWNjb3VudF9pZBgBIAEoDRI2Cg9oZXJvX3N0YXRlX2RhdGEYAiABKAsy", "HS5GZW5yaXMuSGVyby5IZXJvU3RhdGVEYXRhRGVmIrsDChBOZXdQbGF5ZXJN", "ZXNzYWdlEg8KB2hlcm9faWQYASABKAkSEAoIcGFydHlfaWQYAiABKAkSEgoK",
				"YWNjb3VudF9pZBgDIAEoDRIXCg9nYW1lX2FjY291bnRfaWQYBCABKA0SOAoQ", "cGxhdGZvcm1fYWNjb3VudBgFIAEoCzIeLkZlbnJpcy5PbmxpbmUuUGxhdGZv", "cm1BY2NvdW50EhEKCWhlcm9fbmFtZRgGIAEoCRIMCgR0ZWFtGAcgASgREhMK", "C3BsYXllcmNsYXNzGAggASgREhoKEmFjdG9yX3BvcnRyYWl0X3NubxgJIAEo", "DxIVCg1jdXJyZW50X2xldmVsGAogASgREjYKD2hlcm9fc3RhdGVfZGF0YRgL", "IAEoCzIdLkZlbnJpcy5IZXJvLkhlcm9TdGF0ZURhdGFEZWYSEwoLanVzdF9q", "b2luZWQYDCABKAgSCwoDYW5uGA0gASgPEhQKDGFjY291bnRfbmFtZRgOIAEo", "CRIXCg9zaGFwZXNoaWZ0X2Zvcm0YDyABKBESEgoKc2Vzc2lvbl9pZBgQIAEo", "CRIXCg9wcml2YXRlX3Byb2ZpbGUYESABKAgiagoZSGVyb1N0YXRlV2F5cG9p", "bnRzTWVzc2FnZRIXCg9nYW1lX2FjY291bnRfaWQYASABKA0SGwoTd2F5cG9p",
				"bnRzX2FjdGl2YXRlZBgCIAMoDRIXCg9mb2dfb2Zfd2FyX3Nub3MYAyADKA8i", "WQocSGVyb1N0YXRlSGlkZGVuQ2FjaGVzTWVzc2FnZRIXCg9nYW1lX2FjY291", "bnRfaWQYASABKA0SIAoYZm91bmRfaGlkZGVuX2NhY2hlX2diaWRzGAIgAygP"
			}));
			HeroReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeSerializerReflection.Descriptor,
				HirelingReflection.Descriptor,
				ItemsReflection.Descriptor,
				HeroCommonReflection.Descriptor,
				QuestReflection.Descriptor,
				DemonSummoningReflection.Descriptor,
				TradeReflection.Descriptor,
				ProfileReflection.Descriptor,
				OnlineCommonReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AppearanceCustomization), AppearanceCustomization.Parser, new string[] { "SnoFace", "SnoHairColor", "SnoHairStyle", "SnoFacialHair", "SnoEyeColor", "SkinColorIndex", "SnoMarkingShape", "SnoMarkingColor", "SnoJewelry", "SnoMakeup" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AppearanceCustomizationOld), AppearanceCustomizationOld.Parser, new string[] { "PersonaIndex", "HairColorIndex", "HairStyleIndex", "FacialHairIndex", "EyeColorIndex", "SkinColorIndex", "SnoMarkingShape", "MarkingColorIndex", "SnoJewelry", "MakeupIndex" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedDigestPlace), SavedDigestPlace.Parser, new string[] { "SnoSubzone" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Digest), Digest.Parser, new string[]
				{
					"Version", "HeroId", "HeroName", "SnoClass", "Level", "PlayerFlags", "VisualEquipment", "LastPlayedQuest", "LastPlayedQuestStep", "TimePlayed",
					"CreateTime", "LastPlayedTime", "DeleteTime", "AppearanceCustomization", "LastPlace", "SeasonCreated", "LastWorldTier", "MaxWorldTier", "HeroNameForceRenamed", "ReportedHeroName"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Vector), Vector.Parser, new string[] { "X", "Y", "Z" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedWorldPlace), SavedWorldPlace.Parser, new string[] { "SnoWorld", "Pos", "EntranceGuid", "DrlgSeed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedSkillExtraAndArsenal), SavedSkillExtraAndArsenal.Parser, new string[] { "SnoPower", "Slot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedSkillTreeNode), SavedSkillTreeNode.Parser, new string[] { "NodeId", "Rank" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedTransferItem), SavedTransferItem.Parser, new string[] { "WorldPlace", "ItemId", "Item" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedTownPortalReturnDest), SavedTownPortalReturnDest.Parser, new string[] { "WorldPlace", "SnoLevelArea", "ExpireTimestamp", "NearbyItem" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedDroppedItemData), SavedDroppedItemData.Parser, new string[] { "DroppedItems" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SpawnTrackingKeyValue), SpawnTrackingKeyValue.Parser, new string[] { "KeyMarkerSno", "KeyIndex", "ValueTransferredTimestamp", "ValueBountySno", "ValueIsSoft", "ValueGbidType", "ValueSnoPopulation", "ValueSnoLevelarea", "ValueIsLocalEventSpawner" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CompletedRepeatableQuest), CompletedRepeatableQuest.Parser, new string[] { "SnoQuest", "LastOccurrence" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedTransmogs), SavedTransmogs.Parser, new string[] { "Transmogs", "Unlocked" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TimeBasedSpawnTrackingData), TimeBasedSpawnTrackingData.Parser, new string[] { "TrackedTimestamp", "GizmoHash", "GizmoCooldown", "OccurrenceExpiration" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Customization), Customization.Parser, new string[] { "SnoPotionButton", "SocialWheelConfiguration", "TransmogSlot", "SavedTransmog", "PlayerTitle" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Vendor), Vendor.Parser, new string[] { "SeedInterval", "SeedLevel", "Seed", "SoldItem" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Quests), Quests.Parser, new string[] { "SavedQuest", "SnoCompletedQuest", "CompletedRepeatableQuest", "Reputation", "SavedBounty", "CompletedBounty", "DemonScroll", "MaxNightmareDungeonCompleted", "SubzoneModifierOccurrence" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Discoveries), Discoveries.Parser, new string[] { "UnlockedTownPortal", "LearnedLore", "SavedConversations", "ActivatedWaypoint", "SnoUnlockedFow", "GbidDiscoveredCache", "CampsDiscovered" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Skills), Skills.Parser, new string[] { "ActiveSkills", "SkillVersion", "SkillKitVersion", "PurchasedSkillTreeNode", "LastPurchasedSkillTreeNode", "EnchantSkill", "ParagonBoard", "ParagonGlyph", "SkillExtraArsenals", "ClassPassiveSkill" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SpawnTracking), SpawnTracking.Parser, new string[] { "TimeBasedSpawnTracking", "SpawnTrackingMapData" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Rewards), Rewards.Parser, new string[] { "ZoneProgress" }, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(Rewards.Types.ZoneProgress), Rewards.Types.ZoneProgress.Parser, new string[] { "RewardClaimedFlags" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(Fenris.Hero.SavedData), Fenris.Hero.SavedData.Parser, new string[]
				{
					"TimePlayed", "HirelingSavedData", "LastLevelTime", "LastWorldPlace", "HeroDeathWorldSno", "HeroDeathLocation", "DesignerVariables", "MaxWorldTier", "BountyPoints", "NecroSkeletonWarriorCount",
					"NecroSkeletonMageCount"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedDefinition), SavedDefinition.Parser, new string[]
				{
					"Version", "Digest", "SavedAttributes", "SavedData", "Items", "Customization", "Vendor", "Quests", "Discoveries", "Skills",
					"SpawnTracking", "TradeSavedData", "Rewards"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FallenHero), FallenHero.Parser, new string[] { "Profile", "HeroName", "AppearanceCustomization", "TimePlayed", "CreateTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DesignerVariable), DesignerVariable.Parser, new string[] { "GbidDesignerVariable", "PayloadValue", "ResetValue" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ZoneProgress), ZoneProgress.Parser, new string[] { "RewardClaimedFlags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroStateDataDef), HeroStateDataDef.Parser, new string[]
				{
					"PlayerFlags", "CustomizationData", "SavedData", "TownPortalReturnDest", "CompletedQuestSnos", "FogOfWarUnlockedSnos", "CompletedRepeatableQuests", "CompletedBounties", "CampsDiscoveredSnos", "DesignerVariables",
					"FoundHiddenCacheGbids", "ZoneProgressData"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroStateDataMessage), HeroStateDataMessage.Parser, new string[] { "GameAccountId", "HeroStateData" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NewPlayerMessage), NewPlayerMessage.Parser, new string[]
				{
					"HeroId", "PartyId", "AccountId", "GameAccountId", "PlatformAccount", "HeroName", "Team", "Playerclass", "ActorPortraitSno", "CurrentLevel",
					"HeroStateData", "JustJoined", "Ann", "AccountName", "ShapeshiftForm", "SessionId", "PrivateProfile"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroStateWaypointsMessage), HeroStateWaypointsMessage.Parser, new string[] { "GameAccountId", "WaypointsActivated", "FogOfWarSnos" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroStateHiddenCachesMessage), HeroStateHiddenCachesMessage.Parser, new string[] { "GameAccountId", "FoundHiddenCacheGbids" }, null, null, null, null)
			}));
		}

		// Token: 0x04001144 RID: 4420
		private static FileDescriptor descriptor;
	}
}
