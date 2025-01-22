using System;
using Fenris.Account;
using Fenris.Clan;
using Fenris.Client;
using Fenris.CS;
using Fenris.GameMessage;
using Fenris.Hero;
using Fenris.Items;
using Fenris.License;
using Fenris.Online;
using Fenris.Profile;
using Fenris.Search;
using Fenris.Store;
using Fenris.TACTKey;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200020F RID: 527
	public static class ClientMessageReflection
	{
		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x000E3A44 File Offset: 0x000E1C44
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.descriptor;
			}
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x000E3A5C File Offset: 0x000E1C5C
		static ClientMessageReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNDbGllbnRNZXNzYWdlLnByb3RvEhRGZW5yaXMuQ2xpZW50TWVzc2FnZRoN", "QWNjb3VudC5wcm90bxoKSGVyby5wcm90bxoQSGVyb0NvbW1vbi5wcm90bxoS", "T25saW5lQ29tbW9uLnByb3RvGgxPbmxpbmUucHJvdG8aDlNldHRpbmdzLnBy", "b3RvGghDUy5wcm90bxoKQ2xhbi5wcm90bxoNTGljZW5zZS5wcm90bxoMU2Vh", "cmNoLnByb3RvGg1UQUNUS2V5LnByb3RvGgtTdG9yZS5wcm90bxoLSXRlbXMu", "cHJvdG8aDVByb2ZpbGUucHJvdG8aEUdhbWVNZXNzYWdlLnByb3RvIhAKDkdl", "bmVyaWNNZXNzYWdlIhAKDkdlbmVyaWNSZXF1ZXN0IiUKD0dlbmVyaWNSZXNw", "b25zZRISCgplcnJvcl9jb2RlGAEgASgNIhQKEkdldFRBQ1RLZXlzUmVxdWVz", "dCI5ChNHZXRUQUNUS2V5c1Jlc3BvbnNlEiIKBGtleXMYASABKAsyFC5GZW5y", "aXMuVEFDVEtleS5LZXlzIkIKF0FjdGl2YXRlVEFDVEtleXNSZXF1ZXN0EhQK",
				"DGFjdGl2YXRlX2FsbBgBIAEoCBIRCglrZXlfbmFtZXMYAiADKAkiGgoYQWN0", "aXZhdGVUQUNUS2V5c1Jlc3BvbnNlIhYKFFJlc2V0QWxsR2lmdHNSZXF1ZXN0", "IhcKFVJlc2V0QWxsR2lmdHNSZXNwb25zZSJaChxWaXJ0dWFsQ3VycmVuY3lD", "cmVkaXRSZXF1ZXN0Eg4KBmFtb3VudBgBIAEoDRIVCg1jdXJyZW5jeV9jb2Rl", "GAIgASgJEhMKC3Nlc3Npb25fa2V5GAMgASgMIh8KHVZpcnR1YWxDdXJyZW5j", "eUNyZWRpdFJlc3BvbnNlIlkKG1ZpcnR1YWxDdXJyZW5jeURlYml0UmVxdWVz", "dBIOCgZhbW91bnQYASABKA0SFQoNY3VycmVuY3lfY29kZRgCIAEoCRITCgtz", "ZXNzaW9uX2tleRgDIAEoDCIeChxWaXJ0dWFsQ3VycmVuY3lEZWJpdFJlc3Bv", "bnNlInYKFUdldEluaXRpYWxEYXRhUmVxdWVzdBITCgtzZXNzaW9uX2tleRgB", "IAEoDBIYChBnYW1lX3NlcnZlcl9wb29sGAIgASgJEhEKCWJhdHRsZXRhZxgD",
				"IAEoCRIbChNtdWx0aXBsYXllcl9hbGxvd2VkGAQgASgIIkEKE1Rlc3RpbmdH", "cm91cFZhcmlhbnQSFwoPZXhwZXJpbWVudF9uYW1lGAEgASgJEhEKCXZhcmlh", "dGlvbhgCIAEoCSKpBgoWR2V0SW5pdGlhbERhdGFSZXNwb25zZRIuCg5hY2Nv", "dW50X2RpZ2VzdBgBIAIoCzIWLkZlbnJpcy5BY2NvdW50LkRpZ2VzdBIjCgZo", "ZXJvZXMYAiADKAsyEy5GZW5yaXMuSGVyby5EaWdlc3QSKQoMZGVsZXRlZF9o", "ZXJvGAUgASgLMhMuRmVucmlzLkhlcm8uRGlnZXN0EhkKEXN5bmNfdmFyX2Nt", "ZF9saW5lGAMgASgJEj8KFGFjY291bnRfbm90aWZpY2F0aW9uGAQgAygLMiEu", "RmVucmlzLk9ubGluZS5QbGF5ZXJOb3RpZmljYXRpb24SNgoOcGxheWVyTGlj", "ZW5zZXMYBiABKAsyHi5GZW5yaXMuTGljZW5zZS5QbGF5ZXJMaWNlbnNlcxIi", "CgRrZXlzGAcgASgLMhQuRmVucmlzLlRBQ1RLZXkuS2V5cxIeChZjb21tZXJj",
				"ZV9zZGtfY2xpZW50X2lkGAggASgMEjQKCHNldHRpbmdzGAkgASgLMiIuRmVu", "cmlzLkNsaWVudC5HYW1lQWNjb3VudFNldHRpbmdzEhcKD3NlcnZpY2VfdmVy", "c2lvbhgKIAEoCRIdChVjb250ZW50X3N0YWNrX2FwaV9rZXkYCyABKAwSJgoe", "Y29udGVudF9zdGFja19kZXZfYWNjZXNzX3Rva2VuGAwgASgMEicKH2NvbnRl", "bnRfc3RhY2tfcHJvZF9hY2Nlc3NfdG9rZW4YDSABKAwSRAoRYWJfdGVzdGlu", "Z19ncm91cHMYDiADKAsyKS5GZW5yaXMuQ2xpZW50TWVzc2FnZS5UZXN0aW5n", "R3JvdXBWYXJpYW50EiIKGmNvbW1lcmNlX3Nka19jbGllbnRfc2VjcmV0GA8g", "ASgMEhwKFGNvbW1lcmNlX3Nka19wYWdlX2lkGBAgAygMEk0KEnpvbmVfcHJv", "Z3Jlc3NfZGF0YRgRIAEoCzIxLkZlbnJpcy5HYW1lTWVzc2FnZS5ab25lUHJv", "Z3Jlc3NHbG9iYWxEYXRhTWVzc2FnZRIhChljb21tZXJjZV9zZGtfcGxhY2Vt",
				"ZW50X2lkGBIgAygMIpECChRGaW5kVXNlclByb3h5UmVxdWVzdBI4ChBwbGF0", "Zm9ybV9hY2NvdW50GAIgASgLMh4uRmVucmlzLk9ubGluZS5QbGF0Zm9ybUFj", "Y291bnQSEQoJYXV0aF9jb2RlGAMgASgJEg0KBXRva2VuGAQgASgEEhIKCnNl", "c3Npb25faWQYBSABKAkSEwoLc2VydmVyX3Bvb2wYBiABKAkSEwoLc2Vzc2lv", "bl9rZXkYByABKAwSHQoVY29udGVudF9saWNlbnNlX25hbWVzGAggAygJEiMK", "BXRyYWNlGAkgASgLMhQuRmVucmlzLk9ubGluZS5UcmFjZRIbChNjb25uZWN0", "ZWRfcmVnaW9uX2lkGAogASgNIsUBChVGaW5kVXNlclByb3h5UmVzcG9uc2US", "MwoMY29ubmVjdF9pbmZvGAEgASgLMh0uRmVucmlzLk9ubGluZS5Db25uZWN0", "aW9uSW5mbxISCgplcnJvcl9jb2RlGAIgASgNEg0KBXRva2VuGAMgASgEEi8K", "CWVudHJ5X2tleRgEIAEoCzIcLkZlbnJpcy5PbmxpbmUuUXVldWVFbnRyeUtl",
				"eRIjCgV0cmFjZRgFIAEoCzIULkZlbnJpcy5PbmxpbmUuVHJhY2UipAIKEUNy", "ZWF0ZUhlcm9SZXF1ZXN0EhEKCWhlcm9fbmFtZRgBIAEoCRIRCglzbm9fY2xh", "c3MYAiABKA8SEQoJaXNfZmVtYWxlGAMgASgIEkYKGGFwcGVhcmFuY2VfY3Vz", "dG9taXphdGlvbhgEIAEoCzIkLkZlbnJpcy5IZXJvLkFwcGVhcmFuY2VDdXN0", "b21pemF0aW9uEhMKC2lzX2hhcmRjb3JlGAUgASgIEhMKC2lzX3NlYXNvbmFs", "GAYgASgIEhsKE2FsbG93X2FsbF9jb3NtZXRpY3MYByABKAgSGwoTYXBwbHlf", "Y2FtcGFpZ25fc2tpcBgIIAEoCBIVCg1jbGllbnRfbG9jYWxlGAkgASgFEhMK", "C3Nlc3Npb25fa2V5GAogASgMIjcKEkNyZWF0ZUhlcm9SZXNwb25zZRIhCgRo", "ZXJvGAEgASgLMhMuRmVucmlzLkhlcm8uRGlnZXN0IkAKEURlbGV0ZUhlcm9S", "ZXF1ZXN0Eg8KB2hlcm9faWQYASABKAkSGgoSZGVsZXRlX2ltbWVkaWF0ZWx5",
				"GAIgASgIIjAKClJlbmFtZUhlcm8SDwoHaGVyb19pZBgBIAEoCRIRCgloZXJv", "X25hbWUYAiABKAkiTgoTUmVuYW1lSGVyb2VzUmVxdWVzdBI3Cg1yZW5hbWVf", "aGVyb2VzGAEgAygLMiAuRmVucmlzLkNsaWVudE1lc3NhZ2UuUmVuYW1lSGVy", "byKDAQoSTGlzdEhlcm9lc1Jlc3BvbnNlEiMKBmhlcm9lcxgBIAMoCzITLkZl", "bnJpcy5IZXJvLkRpZ2VzdBIpCgxkZWxldGVkX2hlcm8YAiABKAsyEy5GZW5y", "aXMuSGVyby5EaWdlc3QSHQoVY2FtcGFpZ25fc2tpcF9hbGxvd2VkGAMgASgI", "IjgKEVNlbGVjdEhlcm9SZXF1ZXN0Eg8KB2hlcm9faWQYASACKAkSEgoKd29y", "bGRfdGllchgCIAEoESIrChhBcHBseUNhbXBhaWduU2tpcFJlcXVlc3QSDwoH", "aGVyb19pZBgBIAEoCSJAChlBcHBseUNhbXBhaWduU2tpcFJlc3BvbnNlEiMK", "BmRpZ2VzdBgBIAEoCzITLkZlbnJpcy5IZXJvLkRpZ2VzdCI0ChJTZWxlY3RI",
				"ZXJvUmVzcG9uc2USHgoWYWNjb3VudF9wYXJ0aXRpb25fdHlwZRgBIAEoBSKG", "AgogQWRkTG9jYWxQbGF5ZXJUb1VzZXJQcm94eVJlcXVlc3QSHwoXc3BvbnNv", "cl9nYW1lX2FjY291bnRfaWQYASABKA0SOAoQcGxhdGZvcm1fYWNjb3VudBgC", "IAEoCzIeLkZlbnJpcy5PbmxpbmUuUGxhdGZvcm1BY2NvdW50EhEKCWF1dGhf", "Y29kZRgDIAEoCRITCgtzZXNzaW9uX2tleRgEIAEoDBIdChVjb250ZW50X2xp", "Y2Vuc2VfbmFtZXMYBSADKAkSIwoFdHJhY2UYBiABKAsyFC5GZW5yaXMuT25s", "aW5lLlRyYWNlEhsKE2Nvbm5lY3RlZF9yZWdpb25faWQYByABKA0ihAEKIUFk", "ZExvY2FsUGxheWVyVG9Vc2VyUHJveHlSZXNwb25zZRINCgV0b2tlbhgCIAEo", "BBIXCg9nYW1lX2FjY291bnRfaWQYAyABKA0SEgoKZXJyb3JfY29kZRgEIAEo", "DRIjCgV0cmFjZRgFIAEoCzIULkZlbnJpcy5PbmxpbmUuVHJhY2UiUAodU2F2",
				"ZUFjY291bnRQcmVmZXJlbmNlc1JlcXVlc3QSLwoLcHJlZmVyZW5jZXMYASAB", "KAsyGi5GZW5yaXMuQ2xpZW50LlByZWZlcmVuY2VzIlIKGlNhdmVBY2NvdW50", "U2V0dGluZ3NSZXF1ZXN0EjQKCHNldHRpbmdzGAEgASgLMiIuRmVucmlzLkNs", "aWVudC5HYW1lQWNjb3VudFNldHRpbmdzIiQKEFN5bmNlZFhWYXJVcGRhdGUS", "EAoIY21kX2xpbmUYASABKAkiJAoRRGVsZXRlTWFpbFJlcXVlc3QSDwoHbWFp", "bF9pZBgBIAEoCSIwChVHZXRIZXJvRGlnZXN0c1JlcXVlc3QSFwoPZ2FtZV9h", "Y2NvdW50X2lkGAEgASgNIkMKFkdldEhlcm9EaWdlc3RzUmVzcG9uc2USKQoM", "aGVyb19kaWdlc3RzGAEgAygLMhMuRmVucmlzLkhlcm8uRGlnZXN0IkYKGEdl", "dEFjY291bnRQcm9maWxlUmVxdWVzdBIXCg9nYW1lX2FjY291bnRfaWQYASAB", "KA0SEQoJc2Vhc29uX2lkGAIgASgNIlQKGUdldEFjY291bnRQcm9maWxlUmVz",
				"cG9uc2USNwoPYWNjb3VudF9wcm9maWxlGAEgASgLMh4uRmVucmlzLlByb2Zp", "bGUuQWNjb3VudFByb2ZpbGUiMQoWR2V0SGVyb1Byb2ZpbGVzUmVxdWVzdBIX", "Cg9nYW1lX2FjY291bnRfaWQYASABKA0iSAoVR2V0SGVyb1Byb2ZpbGVSZXF1", "ZXN0Eh4KFnRhcmdldF9nYW1lX2FjY291bnRfaWQYASABKA0SDwoHaGVyb19p", "ZBgCIAEoCSJLChZHZXRIZXJvUHJvZmlsZVJlc3BvbnNlEjEKDGhlcm9fcHJv", "ZmlsZRgBIAEoCzIbLkZlbnJpcy5Qcm9maWxlLkhlcm9Qcm9maWxlIj4KJlVw", "ZGF0ZUFjY291bnRQcm9maWxlUHJpdmFjeUZsYWdSZXF1ZXN0EhQKDHByaXZh", "Y3lfZmxhZxgBIAEoCCJfChtMaXN0U25hcHNob3RWZXJzaW9uc1JlcXVlc3QS", "FwoPZ2FtZV9hY2NvdW50X2lkGAEgASgNEhgKEHJldHVybl9zbmFwc2hvdHMY", "AiABKAgSDQoFbGltaXQYAyABKA0iTQocTGlzdFNuYXBzaG90VmVyc2lvbnNS",
				"ZXNwb25zZRItCgh2ZXJzaW9ucxgBIAEoCzIbLkZlbnJpcy5DUy5TbmFwc2hv", "dFZlcnNpb25zImsKFVJlc3RvcmVBY2NvdW50UmVxdWVzdBIbChN0YXJnZXRf", "Z2FtZV9hY2NvdW50GAEgASgNEhsKE3NvdXJjZV9nYW1lX2FjY291bnQYAiAB", "KA0SGAoQc25hcHNob3RfdmVyc2lvbhgDIAEoBCJFChxBZGRMb2NhbFBsYXll", "clRvUGFydHlSZXF1ZXN0EhAKCHBhcnR5X2lkGAEgASgJEhMKC3BhcnR5X3Rv", "a2VuGAIgASgEIjIKG0FkZExvY2FsUGxheWVyVG9HYW1lUmVxdWVzdBITCgtz", "ZXNzaW9uX2tleRgBIAEoDCJoChxBZGRMb2NhbFBsYXllclRvR2FtZVJlc3Bv", "bnNlEhAKCGVycl9jb2RlGAEgASgNEjYKD2Nvbm5lY3Rpb25faW5mbxgCIAEo", "CzIdLkZlbnJpcy5PbmxpbmUuQ29ubmVjdGlvbkluZm8iNwoUSW52aXRlVG9Q", "YXJ0eVJlcXVlc3QSHwoXaW52aXRlZV9nYW1lX2FjY291bnRfaWQYASABKA0i",
				"PAoVSW52aXRlVG9QYXJ0eVJlc3BvbnNlEhEKCWludml0ZV9pZBgBIAEoBBIQ", "CghwYXJ0eV9pZBgCIAEoCSIoChNSZXZva2VJbnZpdGVSZXF1ZXN0EhEKCWlu", "dml0ZV9pZBgBIAEoBCJ0ChtSZXNwb25kVG9QYXJ0eUludml0ZVJlcXVlc3QS", "GAoQaW52aXRlcl9wYXJ0eV9pZBgBIAEoCRIRCglpbnZpdGVfaWQYAiABKAQS", "EAoIYWNjZXB0ZWQYAyABKAgSFgoOZGVjbGluZV9yZWFzb24YBCABKA0iNgob", "UHJvbW90ZVRvUGFydHlMZWFkZXJSZXF1ZXN0EhcKD2dhbWVfYWNjb3VudF9p", "ZBgBIAEoDSIzChhSZW1vdmVQYXJ0eU1lbWJlclJlcXVlc3QSFwoPZ2FtZV9h", "Y2NvdW50X2lkGAEgASgNIhMKEUxlYXZlUGFydHlSZXF1ZXN0IiUKI0FkZFJl", "c2VydmF0aW9uRm9yTG9jYWxQbGF5ZXJSZXF1ZXN0IkEKJEFkZFJlc2VydmF0", "aW9uRm9yTG9jYWxQbGF5ZXJSZXNwb25zZRIZChFyZXNlcnZhdGlvbl90b2tl",
				"bhgBIAEoBCJbChlQYXJ0eUludml0ZVJlcXVlc3RSZXF1ZXN0EiEKGXJlcXVl", "c3RlZV9nYW1lX2FjY291bnRfaWQYASABKA0SGwoTcmVxdWVzdGVyX2JhdHRs", "ZXRhZxgCIAEoCSJWChlEZWNsaW5lUGFydHlJbnZpdGVSZXF1ZXN0EiEKGXJl", "cXVlc3Rlcl9nYW1lX2FjY291bnRfaWQYASABKA0SFgoOZGVjbGluZV9yZWFz", "b24YAiABKA0iOgoVUGFydHlRdWlja0pvaW5SZXF1ZXN0EiEKGXJlcXVlc3Rl", "ZV9nYW1lX2FjY291bnRfaWQYASABKA0ibAoUUmVqZWN0UGFydHlRdWlja0pv", "aW4SIQoZcmVxdWVzdGVlX2dhbWVfYWNjb3VudF9pZBgBIAEoDRIhChlyZXF1", "ZXN0ZXJfZ2FtZV9hY2NvdW50X2lkGAIgASgNEg4KBnJlYXNvbhgDIAEoDSIx", "ChZQYXJ0eUtpY2tNZW1iZXJSZXF1ZXN0EhcKD2dhbWVfYWNjb3VudF9pZBgB", "IAEoDSJ2Ch9QYXJ0eUpvaW5CeUNvbnNvbGVJbnZpdGVSZXF1ZXN0EhAKCHBh",
				"cnR5X2lkGAEgASgJEiMKG2ludml0ZXJfcGxhdGZvcm1fYWNjb3VudF9pZBgC", "IAEoBBIcChRpc19jcm9zc3BsYXlfZW5hYmxlZBgDIAEoCCIzChZDYW5jZWxQ", "YXJ0eVJlc2VydmF0aW9uEhkKEXJlc2VydmF0aW9uX3Rva2VuGAEgASgEIvYB", "ChNQYXJ0eUludml0ZVJlY2VpdmVkEhcKD2ludml0ZV9wYXJ0eV9pZBgBIAEo", "CRIRCglpbnZpdGVfaWQYAiABKAQSHwoXaW52aXRlcl9nYW1lX2FjY291bnRf", "aWQYBCABKA0SHwoXaW52aXRlcl9ibmV0X2FjY291bnRfaWQYBiABKA0SQAoY", "aW52aXRlcl9wbGF0Zm9ybV9hY2NvdW50GAcgASgLMh4uRmVucmlzLk9ubGlu", "ZS5QbGF0Zm9ybUFjY291bnQSFAoMaW52aXRlcl9uYW1lGAUgASgJEhkKEWlu", "dml0ZXJfaGVyb19uYW1lGAggASgJIr4BChpQYXJ0eUludml0ZVJlcXVlc3RS", "ZWNlaXZlZBIhChlyZXF1ZXN0ZXJfZ2FtZV9hY2NvdW50X2lkGAIgASgNEiEK",
				"GXJlcXVlc3Rlcl9ibmV0X2FjY291bnRfaWQYBCABKA0SQgoacmVxdWVzdGVy", "X3BsYXRmb3JtX2FjY291bnQYBSABKAsyHi5GZW5yaXMuT25saW5lLlBsYXRm", "b3JtQWNjb3VudBIWCg5yZXF1ZXN0ZXJfbmFtZRgDIAEoCSKpAQodUGFydHlR", "dWlja0pvaW5SZXF1ZXN0UmVjZWl2ZWQSIQoZcmVxdWVzdGVyX2dhbWVfYWNj", "b3VudF9pZBgCIAEoDRIhChlyZXF1ZXN0ZXJfYm5ldF9hY2NvdW50X2lkGAMg", "ASgNEkIKGnJlcXVlc3Rlcl9wbGF0Zm9ybV9hY2NvdW50GAQgASgLMh4uRmVu", "cmlzLk9ubGluZS5QbGF0Zm9ybUFjY291bnQiUAoSUGFydHlJbnZpdGVSZW1v", "dmVkEhcKD2ludml0ZV9wYXJ0eV9pZBgBIAEoCRIRCglpbnZpdGVfaWQYAiAB", "KAQSDgoGcmVhc29uGAMgASgNIk8KElBhcnR5TWVtYmVyUmVtb3ZlZBIQCghw", "YXJ0eV9pZBgBIAEoCRIXCg9nYW1lX2FjY291bnRfaWQYAiABKA0SDgoGcmVh",
				"c29uGAMgASgNIrIBChRQYXJ0eUZpbmRHYW1lUmVxdWVzdBITCgtzbm9fc3Vi", "em9uZRgBIAEoDxIRCglzbm9fd29ybGQYAiABKA8SGAoQaXNfaGFyZGNvcmVf", "aGVybxgDIAEoCBIYChBpc19zZWFzb25hbF9oZXJvGAQgASgIEhcKD2dhbWVf", "YWNjb3VudF9pZBgFIAEoDRIQCghwYXJ0eV9pZBgGIAEoCRITCgtzZXNzaW9u", "X2tleRgHIAEoDCKLAQoOUGFydHlHYW1lRm91bmQSEAoIZXJyX2NvZGUYASAB", "KA0SNgoPY29ubmVjdGlvbl9pbmZvGAIgASgLMh0uRmVucmlzLk9ubGluZS5D", "b25uZWN0aW9uSW5mbxIvCgllbnRyeV9rZXkYAyABKAsyHC5GZW5yaXMuT25s", "aW5lLlF1ZXVlRW50cnlLZXkiggEKGVBhcnR5Q2FtcGFpZ25TdGF0ZUNoYW5n", "ZWQSEAoIcGFydHlfaWQYASABKAkSMgoOY2FtcGFpZ25fc3RhdGUYAiABKAsy", "Gi5GZW5yaXMuSGVyby5DYW1wYWlnblN0YXRlEh8KF3Jlc2V0X2dhbWVfcXVl",
				"c3Rfc3RhdGVzGAMgASgIIngKGlBhcnR5R2FtZVF1ZXN0U3RhdGVDaGFuZ2Vk", "EhAKCHBhcnR5X2lkGAEgASgJEi4KC2dhbWVfaGFuZGxlGAIgASgLMhkuRmVu", "cmlzLk9ubGluZS5HYW1lSGFuZGxlEhgKEGdhbWVfcXVlc3Rfc3RhdGUYAyAB", "KAwiRgoZS2V5ZWREdW5nZW9uUGFydHlWb3RlRGF0YRITCgtzbm9fZHVuZ2Vv", "bhgBIAEoDxIUCgxkdW5nZW9uX3RpZXIYAiABKA8itQEKFFBhcnR5TWVtYmVy", "R3JvdXBWb3RlEh8KF2ludml0ZXJfZ2FtZV9hY2NvdW50X2lkGAEgAygNEhEK", "CXZvdGVfdHlwZRgCIAEoDRJLChJrZXllZF9kdW5nZW9uX2RhdGEYAyABKAsy", "Ly5GZW5yaXMuQ2xpZW50TWVzc2FnZS5LZXllZER1bmdlb25QYXJ0eVZvdGVE", "YXRhEhwKFHJlcXVlc3RlZF93b3JsZF90aWVyGAQgASgFIhMKEVBhcnR5Vm90", "ZVJlamVjdGVkIjoKEVBhcnR5Vm90ZVJlc3BvbnNlEhcKD2dhbWVfYWNjb3Vu",
				"dF9pZBgBIAMoDRIMCgR2b3RlGAIgASgIIigKEVBhcnR5Vm90ZUNvbXBsZXRl", "EhMKC3ZvdGVfcGFzc2VkGAEgASgIInIKGlBhcnR5S2V5ZWREdW5nZW9uQWN0", "aXZhdGVkEhAKCHBhcnR5X2lkGAEgASgJEhcKD2dhbWVfYWNjb3VudF9pZBgC", "IAEoDRITCgtzbm9fZHVuZ2VvbhgDIAEoBxIUCgxkdW5nZW9uX3RpZXIYBCAB", "KA0iGQoXUGFydHlSZXNldENhbXBhaWduU3RhdGUiPwoVUGFydHlPZmZlclN0", "YXlJblBhcnR5EhAKCHBhcnR5X2lkGAEgASgJEhQKDG1lbWJlcl9jb3VudBgC", "IAEoDSJJChZQYXJ0eVN0YXlJblBhcnR5VXBkYXRlEhAKCHBhcnR5X2lkGAEg", "ASgJEh0KFW1lbWJlcnNfc3RheWluZ19jb3VudBgCIAEoDSI8ChVQYXJ0eUxv", "Y2tTdGF0ZUNoYW5nZWQSEAoIcGFydHlfaWQYASABKAkSEQoJaXNfbG9ja2Vk", "GAIgASgIIm0KF1VwZGF0ZU1hcFBpbkRhdGFSZXF1ZXN0EhIKCnhfcG9zaXRp",
				"b24YASABKAUSEgoKeV9wb3NpdGlvbhgCIAEoBRIRCgl3b3JsZF9zbm8YAyAB", "KA8SFwoPZ2FtZV9hY2NvdW50X2lkGAQgASgNIlIKEUNyZWF0ZUNsYW5SZXF1", "ZXN0EgwKBG5hbWUYASABKAkSCwoDdGFnGAIgASgJEhMKC2Rlc2NyaXB0aW9u", "GAMgASgJEg0KBWxhYmVsGAQgAygNIiUKEkNyZWF0ZUNsYW5SZXNwb25zZRIP", "CgdjbGFuX2lkGAEgASgJIiMKEExlYXZlQ2xhblJlcXVlc3QSDwoHY2xhbl9p", "ZBgBIAEoCSJHChNJbnZpdGVUb0NsYW5SZXF1ZXN0Eg8KB2NsYW5faWQYASAB", "KAkSHwoXaW52aXRlZV9nYW1lX2FjY291bnRfaWQYAiABKA0iPQoaUmVzcG9u", "ZFRvQ2xhbkludml0ZVJlcXVlc3QSDwoHY2xhbl9pZBgBIAEoCRIOCgZhY2Nl", "cHQYAiABKAgiJQoSQXBwbHlUb0NsYW5SZXF1ZXN0Eg8KB2NsYW5faWQYASAB", "KAkiZwofUmVzcG9uZFRvQ2xhbkFwcGxpY2F0aW9uUmVxdWVzdBIPCgdjbGFu",
				"X2lkGAEgASgJEiEKGWFwcGxpY2FudF9nYW1lX2FjY291bnRfaWQYAiABKA0S", "EAoIcmVzcG9uc2UYAyABKA0iSwoYUHJvbW90ZUNsYW5NZW1iZXJSZXF1ZXN0", "Eg8KB2NsYW5faWQYASABKAkSHgoWdGFyZ2V0X2dhbWVfYWNjb3VudF9pZBgC", "IAEoDSJKChdEZW1vdGVDbGFuTWVtYmVyUmVxdWVzdBIPCgdjbGFuX2lkGAEg", "ASgJEh4KFnRhcmdldF9nYW1lX2FjY291bnRfaWQYAiABKA0iVQoVS2lja0Ns", "YW5NZW1iZXJSZXF1ZXN0Eg8KB2NsYW5faWQYASABKAkSHgoWdGFyZ2V0X2dh", "bWVfYWNjb3VudF9pZBgCIAEoDRILCgNiYW4YAyABKAgiUgoVVXBkYXRlQ2xh", "bkluZm9SZXF1ZXN0Eg8KB2NsYW5faWQYASABKAkSKAoJY2xhbl9pbmZvGAIg", "ASgLMhUuRmVucmlzLkNsYW4uQ2xhbkluZm8iKAoVR2V0Q2xhblByb2ZpbGVS", "ZXF1ZXN0Eg8KB2NsYW5faWQYASABKAkiQwoWR2V0Q2xhblByb2ZpbGVSZXNw",
				"b25zZRIpCgdzdW1tYXJ5GAEgASgLMhguRmVucmlzLkNsYW4uQ2xhblByb2Zp", "bGUiJQoSR2V0Q2xhbk5ld3NSZXF1ZXN0Eg8KB2NsYW5faWQYASABKAkiPgoT", "R2V0Q2xhbk5ld3NSZXNwb25zZRInCgRuZXdzGAEgASgLMhkuRmVucmlzLkNs", "YW4uQ2xhbk5ld3NMaXN0IkwKD0NsYW5DaGF0TWVzc2FnZRIMCgR0ZXh0GAEg", "ASgJEhAKCHBsYXRmb3JtGAIgASgNEhkKEWNyb3NzY2hhdF9lbmFibGVkGAMg", "ASgIIjoKJ0NsYW5Gb3JnZXRJbnZpdGVzQW5kQXBwbGljYXRpb25zTWVzc2Fn", "ZRIPCgdjbGFuX2lkGAEgASgJIsYBChBSdW5TdHJlc3NSZXF1ZXN0EhUKDW1l", "c3NhZ2VfY291bnQYASABKA0SWgoLc3RyZXNzX3R5cGUYAiABKA4yMS5GZW5y", "aXMuQ2xpZW50TWVzc2FnZS5SdW5TdHJlc3NSZXF1ZXN0LlN0cmVzc1R5cGU6", "ElNUUkVTU19UWVBFX1JBQkJJVCI/CgpTdHJlc3NUeXBlEhYKElNUUkVTU19U",
				"WVBFX1JBQkJJVBAAEhkKFVNUUkVTU19UWVBFX0NBU1NBTkRSQRABIhMKEVJ1", "blN0cmVzc1Jlc3BvbnNlIncKGUNsYW5NeUludml0ZXNBcHBsaWNhdGlvbnMS", "JwoGaW52aXRlGAEgAygLMhcuRmVucmlzLkNsYW4uQ2xhbkludml0ZRIxCgth", "cHBsaWNhdGlvbhgCIAMoCzIcLkZlbnJpcy5DbGFuLkNsYW5BcHBsaWNhdGlv", "biItChpTdWJzY3JpYmVUb0NsYW5CYW5rQ2hhbmdlcxIPCgdjbGFuX2lkGAEg", "ASgJIk4KIlN1YnNjcmliZVRvQ2xhbkJhbmtDaGFuZ2VzUmVzcG9uc2USKAoJ", "Y2xhbl9iYW5rGAEgASgLMhUuRmVucmlzLkNsYW4uQ2xhbkJhbmsiMQoeVW5z", "dWJzY3JpYmVGcm9tQ2xhbkJhbmtDaGFuZ2VzEg8KB2NsYW5faWQYASABKAki", "4QEKDkNsYW5CYW5rVXBkYXRlEg8KB2NsYW5faWQYASABKAkSGAoQdXBkYXRl", "ZF9udW1fdGFicxgCIAEoDRIvCgx1cGRhdGVkX3RhYnMYAyABKAsyGS5GZW5y",
				"aXMuQ2xhbi5DbGFuQmFua1RhYnMSKwoKYWRkZWRfaXRlbRgEIAMoCzIXLkZl", "bnJpcy5JdGVtcy5TYXZlZEl0ZW0SLQoMdXBkYXRlZF9pdGVtGAUgAygLMhcu", "RmVucmlzLkl0ZW1zLlNhdmVkSXRlbRIXCg9yZW1vdmVkX2l0ZW1faWQYBiAD", "KAwiXwoQRmluZENsYW5zUmVxdWVzdBIbChNjbGllbnRfc2VhcmNoX3Rva2Vu", "GAEgASgEEi4KBnBhcmFtcxgCIAEoCzIeLkZlbnJpcy5TZWFyY2guRmluZENs", "YW5zUGFyYW1zIjsKEUZpbmRDbGFuc1Jlc3BvbnNlEiYKBGNsYW4YASADKAsy", "GC5GZW5yaXMuQ2xhbi5DbGFuUHJvZmlsZSJGChNDbGFuRGV0aHJvbmVSZXF1", "ZXN0Eg8KB2NsYW5faWQYASABKAkSHgoWdGFyZ2V0X2dhbWVfYWNjb3VudF9p", "ZBgCIAEoDSIlChJDbGFuRGlzYmFuZFJlcXVlc3QSDwoHY2xhbl9pZBgBIAEo", "CSI/ChRDbGFuTGVmdE5vdGlmaWNhdGlvbhIPCgdjbGFuX2lkGAEgASgJEhYK",
				"DnJlbW92YWxfcmVhc29uGAIgASgNInkKH1BhcnR5SW52aXRlQ29uZmlybWF0", "aW9uUmVxdWlyZWQSEAoIcGFydHlfaWQYASABKAkSEQoJaW52aXRlX2lkGAIg", "ASgEEhYKDnJlc2VydmF0aW9uX2lkGAMgAygEEhkKEWNvbmZpcm1hdGlvbl90", "eXBlGAQgASgNIm4KEENvbmZpcm1QYXJ0eUpvaW4SGAoQaW52aXRlcl9wYXJ0", "eV9pZBgBIAEoCRIRCglpbnZpdGVfaWQYAiABKAQSGgoScmVzZXJ2YXRpb25f", "dG9rZW5zGAMgAygEEhEKCWNvbmZpcm1lZBgEIAEoCCIpChFRdWV1ZWRGb3JJ", "bnN0YW5jZRIUCgxzdWJ6b25lX3R5cGUYASABKA8iKwoTUmVxdWV1ZWRGb3JJ", "bnN0YW5jZRIUCgxzdWJ6b25lX3R5cGUYASABKA8iOwoUVW5xdWV1ZWRGcm9t", "SW5zdGFuY2USEwoLc25vX3N1YnpvbmUYASABKA8SDgoGcmVhc29uGAIgASgN", "IiwKFVF1ZXVlZEluc3RhbmNlRW50ZXJlZBITCgtzbm9fc3Viem9uZRgBIAEo",
				"DyI+ChNRdWV1ZUludml0ZVJlc3BvbnNlEhcKD2dhbWVfYWNjb3VudF9pZBgB", "IAMoDRIOCgZhY2NlcHQYAiABKAgiUQoNTW9kaWZ5QmFua1RhYhIPCgdjbGFu", "X2lkGAEgASgJEi8KDWJhbmtfdGFiX2luZm8YAyABKAsyGC5GZW5yaXMuQ2xh", "bi5DbGFuQmFua1RhYiJLCh1Nb2RpZnlDbGFuQmFua1RhYkNvdW50UmVxdWVz", "dBIPCgdjbGFuX2lkGAEgASgJEhkKEW5ld19udW1lcl9vZl90YWJzGAIgASgN", "IkIKD1F1ZXVlRW50cnlBZGRlZBIvCgllbnRyeV9rZXkYASABKAsyHC5GZW5y", "aXMuT25saW5lLlF1ZXVlRW50cnlLZXkiWAoLUXVldWVVcGRhdGUSLwoJZW50", "cnlfa2V5GAEgASgLMhwuRmVucmlzLk9ubGluZS5RdWV1ZUVudHJ5S2V5EhgK", "EGF2Z193YWl0X3NlY29uZHMYAiABKA0iKwoXRmluZEdhbWVRdWV1ZUlkUmVz", "cG9uc2USEAoIcXVldWVfaWQYASABKAkiMwoYUmVmcmVzaFNlc3Npb25LZXlS",
				"ZXF1ZXN0EhcKD29sZF9zZXNzaW9uX2tleRgBIAEoDCI0ChlSZWZyZXNoU2Vz", "c2lvbktleVJlc3BvbnNlEhcKD25ld19zZXNzaW9uX2tleRgBIAEoDCIrChBV", "cGRhdGVTZXNzaW9uS2V5EhcKD25ld19zZXNzaW9uX2tleRgBIAEoDCI8ChJH", "ZXRDYXRhbG9nUmVzcG9uc2USJgoHY2F0YWxvZxgBIAEoCzIVLkZlbnJpcy5T", "dG9yZS5DYXRhbG9nIjYKFFdyaXRlU25hcHNob3RSZXF1ZXN0Eh4KFnRhcmdl", "dF9nYW1lX2FjY291bnRfaWQYASABKA0iSgoXU3Vic2NyaWJlVG9RdWV1ZVVw", "ZGF0ZXMSLwoJZW50cnlfa2V5GAEgASgLMhwuRmVucmlzLk9ubGluZS5RdWV1", "ZUVudHJ5S2V5IiEKD1BhcnR5Sm9pbkZhaWxlZBIOCgZyZWFzb24YASABKA0i", "QgoXR2V0RmFsbGVuSGVyb2VzUmVzcG9uc2USJwoGaGVyb2VzGAEgAygLMhcu", "RmVucmlzLkhlcm8uRmFsbGVuSGVybyIqChdEZWxldGVGYWxsZW5IZXJvUmVx",
				"dWVzdBIPCgdoZXJvX2lkGAEgAigJIi0KFlJlZnJlc2hMaWNlbnNlc1JlcXVl", "c3QSEwoLc2Vzc2lvbl9rZXkYASABKAwiSwoXUmVmcmVzaExpY2Vuc2VzUmVz", "cG9uc2USMAoIbGljZW5zZXMYASABKAsyHi5GZW5yaXMuTGljZW5zZS5QbGF5", "ZXJMaWNlbnNlcyJNCiJSZWZyZXNoTGljZW5zZUFuZENvbnN1bWFibGVSZXF1", "ZXN0EhIKCmFjY291bnRfaWQYASABKA0SEwoLc2Vzc2lvbl9rZXkYAiABKAwi", "JQojUmVmcmVzaExpY2Vuc2VBbmRDb25zdW1hYmxlUmVzcG9uc2UifQohQ29u", "c3VtZUNvbnNvbGVFbnRpdGxlbWVudHNSZXF1ZXN0EhMKC3Nlc3Npb25fa2V5", "GAEgASgMEhcKC3ZvdWNoZXJfc25vGAIgASgFOgItMRITCgtpbnN0YW5jZV9p", "ZBgDIAEoCRIVCgpwcm9kdWN0X2lkGAQgASgEOgEwImwKFENvbnN1bWFibGVF", "cnJvclN0YXRlEhcKC3ZvdWNoZXJfc25vGAEgASgFOgItMRIQCghvcmRlcl9p",
				"ZBgCIAEoCRISCgplcnJvcl9jb2RlGAMgASgNEhUKCnByb2R1Y3RfaWQYBCAB", "KAQ6ATAicQoiQ29uc3VtZUNvbnNvbGVFbnRpdGxlbWVudHNSZXNwb25zZRJL", "Chdjb25zdW1hYmxlc19lcnJvcl9zdGF0ZRgBIAMoCzIqLkZlbnJpcy5DbGll", "bnRNZXNzYWdlLkNvbnN1bWFibGVFcnJvclN0YXRlIjQKEk11bHRpcGxheWVy", "QWxsb3dlZBIeChZpc19tdWx0aXBsYXllcl9hbGxvd2VkGAEgASgIIkAKGUxp", "c3REZWxldGVkSGVyb2VzUmVzcG9uc2USIwoGaGVyb2VzGAEgAygLMhMuRmVu", "cmlzLkhlcm8uRGlnZXN0IiwKGVJlc3RvcmVEZWxldGVkSGVyb1JlcXVlc3QS", "DwoHaGVyb19pZBgBIAIoCSJDChBDYW5jZWxRdWV1ZUVudHJ5Ei8KCWVudHJ5", "X2tleRgBIAEoCzIcLkZlbnJpcy5PbmxpbmUuUXVldWVFbnRyeUtleSI+CgtV", "bmJhblBsYXllchIPCgdjbGFuX2lkGAEgASgJEh4KFnRhcmdldF9nYW1lX2Fj",
				"Y291bnRfaWQYAiABKA0iOAodQWNrbm93bGVkZ2VQbGF5ZXJOb3RpZmljYXRp", "b24SFwoPbm90aWZpY2F0aW9uX2lkGAEgASgJIl0KHlVwZGF0ZUFjY291bnRM", "YXN0Q29ubmVjdGVkVGltZRIeChZ0YXJnZXRfZ2FtZV9hY2NvdW50X2lkGAEg", "ASgNEhsKE2xhc3RfY29ubmVjdGVkX3RpbWUYAiABKAQiSwofQWNrbm93bGVk", "Z2VMZWdhbERvY3VtZW50UmVxdWVzdBITCgtkb2N1bWVudF9pZBgBIAEoCRIT", "CgtzZXNzaW9uX2tleRgCIAEoDCI9ChhHZXRMZWdhbERvY3VtZW50UmVzcG9u", "c2USFAoMZG9jdW1lbnRfaWRzGAEgAygJEgsKA3VybBgCIAEoCSIgCg1XYXJk", "ZW5QYXlsb2FkEg8KB3BheWxvYWQYASABKAwiZwoYQXV0aG9yaXR5VHJhbnNm", "ZXJNZXNzYWdlEi4KC2dhbWVfaGFuZGxlGAEgASgLMhkuRmVucmlzLk9ubGlu", "ZS5HYW1lSGFuZGxlEhsKE2dhbWVfaGVhcnRiZWF0X3RpbWUYAiABKA0="
			}));
			ClientMessageReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountReflection.Descriptor,
				HeroReflection.Descriptor,
				HeroCommonReflection.Descriptor,
				OnlineCommonReflection.Descriptor,
				OnlineReflection.Descriptor,
				SettingsReflection.Descriptor,
				CSReflection.Descriptor,
				ClanReflection.Descriptor,
				LicenseReflection.Descriptor,
				SearchReflection.Descriptor,
				TACTKeyReflection.Descriptor,
				StoreReflection.Descriptor,
				ItemsReflection.Descriptor,
				ProfileReflection.Descriptor,
				GameMessageReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GenericMessage), GenericMessage.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenericRequest), GenericRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenericResponse), GenericResponse.Parser, new string[] { "ErrorCode" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTACTKeysRequest), GetTACTKeysRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTACTKeysResponse), GetTACTKeysResponse.Parser, new string[] { "Keys" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ActivateTACTKeysRequest), ActivateTACTKeysRequest.Parser, new string[] { "ActivateAll", "KeyNames" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ActivateTACTKeysResponse), ActivateTACTKeysResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ResetAllGiftsRequest), ResetAllGiftsRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ResetAllGiftsResponse), ResetAllGiftsResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VirtualCurrencyCreditRequest), VirtualCurrencyCreditRequest.Parser, new string[] { "Amount", "CurrencyCode", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VirtualCurrencyCreditResponse), VirtualCurrencyCreditResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VirtualCurrencyDebitRequest), VirtualCurrencyDebitRequest.Parser, new string[] { "Amount", "CurrencyCode", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VirtualCurrencyDebitResponse), VirtualCurrencyDebitResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInitialDataRequest), GetInitialDataRequest.Parser, new string[] { "SessionKey", "GameServerPool", "Battletag", "MultiplayerAllowed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TestingGroupVariant), TestingGroupVariant.Parser, new string[] { "ExperimentName", "Variation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInitialDataResponse), GetInitialDataResponse.Parser, new string[]
				{
					"AccountDigest", "Heroes", "DeletedHero", "SyncVarCmdLine", "AccountNotification", "PlayerLicenses", "Keys", "CommerceSdkClientId", "Settings", "ServiceVersion",
					"ContentStackApiKey", "ContentStackDevAccessToken", "ContentStackProdAccessToken", "AbTestingGroups", "CommerceSdkClientSecret", "CommerceSdkPageId", "ZoneProgressData", "CommerceSdkPlacementId"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindUserProxyRequest), FindUserProxyRequest.Parser, new string[] { "PlatformAccount", "AuthCode", "Token", "SessionId", "ServerPool", "SessionKey", "ContentLicenseNames", "Trace", "ConnectedRegionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindUserProxyResponse), FindUserProxyResponse.Parser, new string[] { "ConnectInfo", "ErrorCode", "Token", "EntryKey", "Trace" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateHeroRequest), CreateHeroRequest.Parser, new string[] { "HeroName", "SnoClass", "IsFemale", "AppearanceCustomization", "IsHardcore", "IsSeasonal", "AllowAllCosmetics", "ApplyCampaignSkip", "ClientLocale", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateHeroResponse), CreateHeroResponse.Parser, new string[] { "Hero" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeleteHeroRequest), DeleteHeroRequest.Parser, new string[] { "HeroId", "DeleteImmediately" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RenameHero), RenameHero.Parser, new string[] { "HeroId", "HeroName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RenameHeroesRequest), RenameHeroesRequest.Parser, new string[] { "RenameHeroes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListHeroesResponse), ListHeroesResponse.Parser, new string[] { "Heroes", "DeletedHero", "CampaignSkipAllowed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SelectHeroRequest), SelectHeroRequest.Parser, new string[] { "HeroId", "WorldTier" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ApplyCampaignSkipRequest), ApplyCampaignSkipRequest.Parser, new string[] { "HeroId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ApplyCampaignSkipResponse), ApplyCampaignSkipResponse.Parser, new string[] { "Digest" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SelectHeroResponse), SelectHeroResponse.Parser, new string[] { "AccountPartitionType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddLocalPlayerToUserProxyRequest), AddLocalPlayerToUserProxyRequest.Parser, new string[] { "SponsorGameAccountId", "PlatformAccount", "AuthCode", "SessionKey", "ContentLicenseNames", "Trace", "ConnectedRegionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddLocalPlayerToUserProxyResponse), AddLocalPlayerToUserProxyResponse.Parser, new string[] { "Token", "GameAccountId", "ErrorCode", "Trace" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SaveAccountPreferencesRequest), SaveAccountPreferencesRequest.Parser, new string[] { "Preferences" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SaveAccountSettingsRequest), SaveAccountSettingsRequest.Parser, new string[] { "Settings" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SyncedXVarUpdate), SyncedXVarUpdate.Parser, new string[] { "CmdLine" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeleteMailRequest), DeleteMailRequest.Parser, new string[] { "MailId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetHeroDigestsRequest), GetHeroDigestsRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetHeroDigestsResponse), GetHeroDigestsResponse.Parser, new string[] { "HeroDigests" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAccountProfileRequest), GetAccountProfileRequest.Parser, new string[] { "GameAccountId", "SeasonId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAccountProfileResponse), GetAccountProfileResponse.Parser, new string[] { "AccountProfile" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetHeroProfilesRequest), GetHeroProfilesRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetHeroProfileRequest), GetHeroProfileRequest.Parser, new string[] { "TargetGameAccountId", "HeroId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetHeroProfileResponse), GetHeroProfileResponse.Parser, new string[] { "HeroProfile" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateAccountProfilePrivacyFlagRequest), UpdateAccountProfilePrivacyFlagRequest.Parser, new string[] { "PrivacyFlag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListSnapshotVersionsRequest), ListSnapshotVersionsRequest.Parser, new string[] { "GameAccountId", "ReturnSnapshots", "Limit" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListSnapshotVersionsResponse), ListSnapshotVersionsResponse.Parser, new string[] { "Versions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RestoreAccountRequest), RestoreAccountRequest.Parser, new string[] { "TargetGameAccount", "SourceGameAccount", "SnapshotVersion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddLocalPlayerToPartyRequest), AddLocalPlayerToPartyRequest.Parser, new string[] { "PartyId", "PartyToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddLocalPlayerToGameRequest), AddLocalPlayerToGameRequest.Parser, new string[] { "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddLocalPlayerToGameResponse), AddLocalPlayerToGameResponse.Parser, new string[] { "ErrCode", "ConnectionInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InviteToPartyRequest), InviteToPartyRequest.Parser, new string[] { "InviteeGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InviteToPartyResponse), InviteToPartyResponse.Parser, new string[] { "InviteId", "PartyId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RevokeInviteRequest), RevokeInviteRequest.Parser, new string[] { "InviteId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RespondToPartyInviteRequest), RespondToPartyInviteRequest.Parser, new string[] { "InviterPartyId", "InviteId", "Accepted", "DeclineReason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PromoteToPartyLeaderRequest), PromoteToPartyLeaderRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemovePartyMemberRequest), RemovePartyMemberRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LeavePartyRequest), LeavePartyRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddReservationForLocalPlayerRequest), AddReservationForLocalPlayerRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddReservationForLocalPlayerResponse), AddReservationForLocalPlayerResponse.Parser, new string[] { "ReservationToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInviteRequestRequest), PartyInviteRequestRequest.Parser, new string[] { "RequesteeGameAccountId", "RequesterBattletag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeclinePartyInviteRequest), DeclinePartyInviteRequest.Parser, new string[] { "RequesterGameAccountId", "DeclineReason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyQuickJoinRequest), PartyQuickJoinRequest.Parser, new string[] { "RequesteeGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RejectPartyQuickJoin), RejectPartyQuickJoin.Parser, new string[] { "RequesteeGameAccountId", "RequesterGameAccountId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyKickMemberRequest), PartyKickMemberRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyJoinByConsoleInviteRequest), PartyJoinByConsoleInviteRequest.Parser, new string[] { "PartyId", "InviterPlatformAccountId", "IsCrossplayEnabled" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CancelPartyReservation), CancelPartyReservation.Parser, new string[] { "ReservationToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInviteReceived), PartyInviteReceived.Parser, new string[] { "InvitePartyId", "InviteId", "InviterGameAccountId", "InviterBnetAccountId", "InviterPlatformAccount", "InviterName", "InviterHeroName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInviteRequestReceived), PartyInviteRequestReceived.Parser, new string[] { "RequesterGameAccountId", "RequesterBnetAccountId", "RequesterPlatformAccount", "RequesterName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyQuickJoinRequestReceived), PartyQuickJoinRequestReceived.Parser, new string[] { "RequesterGameAccountId", "RequesterBnetAccountId", "RequesterPlatformAccount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInviteRemoved), PartyInviteRemoved.Parser, new string[] { "InvitePartyId", "InviteId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyMemberRemoved), PartyMemberRemoved.Parser, new string[] { "PartyId", "GameAccountId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyFindGameRequest), PartyFindGameRequest.Parser, new string[] { "SnoSubzone", "SnoWorld", "IsHardcoreHero", "IsSeasonalHero", "GameAccountId", "PartyId", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyGameFound), PartyGameFound.Parser, new string[] { "ErrCode", "ConnectionInfo", "EntryKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyCampaignStateChanged), PartyCampaignStateChanged.Parser, new string[] { "PartyId", "CampaignState", "ResetGameQuestStates" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyGameQuestStateChanged), PartyGameQuestStateChanged.Parser, new string[] { "PartyId", "GameHandle", "GameQuestState" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KeyedDungeonPartyVoteData), KeyedDungeonPartyVoteData.Parser, new string[] { "SnoDungeon", "DungeonTier" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyMemberGroupVote), PartyMemberGroupVote.Parser, new string[] { "InviterGameAccountId", "VoteType", "KeyedDungeonData", "RequestedWorldTier" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyVoteRejected), PartyVoteRejected.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyVoteResponse), PartyVoteResponse.Parser, new string[] { "GameAccountId", "Vote" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyVoteComplete), PartyVoteComplete.Parser, new string[] { "VotePassed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyKeyedDungeonActivated), PartyKeyedDungeonActivated.Parser, new string[] { "PartyId", "GameAccountId", "SnoDungeon", "DungeonTier" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyResetCampaignState), PartyResetCampaignState.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyOfferStayInParty), PartyOfferStayInParty.Parser, new string[] { "PartyId", "MemberCount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyStayInPartyUpdate), PartyStayInPartyUpdate.Parser, new string[] { "PartyId", "MembersStayingCount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyLockStateChanged), PartyLockStateChanged.Parser, new string[] { "PartyId", "IsLocked" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateMapPinDataRequest), UpdateMapPinDataRequest.Parser, new string[] { "XPosition", "YPosition", "WorldSno", "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateClanRequest), CreateClanRequest.Parser, new string[] { "Name", "Tag", "Description", "Label" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateClanResponse), CreateClanResponse.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LeaveClanRequest), LeaveClanRequest.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InviteToClanRequest), InviteToClanRequest.Parser, new string[] { "ClanId", "InviteeGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RespondToClanInviteRequest), RespondToClanInviteRequest.Parser, new string[] { "ClanId", "Accept" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ApplyToClanRequest), ApplyToClanRequest.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RespondToClanApplicationRequest), RespondToClanApplicationRequest.Parser, new string[] { "ClanId", "ApplicantGameAccountId", "Response" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PromoteClanMemberRequest), PromoteClanMemberRequest.Parser, new string[] { "ClanId", "TargetGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DemoteClanMemberRequest), DemoteClanMemberRequest.Parser, new string[] { "ClanId", "TargetGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KickClanMemberRequest), KickClanMemberRequest.Parser, new string[] { "ClanId", "TargetGameAccountId", "Ban" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateClanInfoRequest), UpdateClanInfoRequest.Parser, new string[] { "ClanId", "ClanInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClanProfileRequest), GetClanProfileRequest.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClanProfileResponse), GetClanProfileResponse.Parser, new string[] { "Summary" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClanNewsRequest), GetClanNewsRequest.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClanNewsResponse), GetClanNewsResponse.Parser, new string[] { "News" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanChatMessage), ClanChatMessage.Parser, new string[] { "Text", "Platform", "CrosschatEnabled" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanForgetInvitesAndApplicationsMessage), ClanForgetInvitesAndApplicationsMessage.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RunStressRequest), RunStressRequest.Parser, new string[] { "MessageCount", "StressType" }, null, new Type[] { typeof(RunStressRequest.Types.StressType) }, null, null),
				new GeneratedClrTypeInfo(typeof(RunStressResponse), RunStressResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanMyInvitesApplications), ClanMyInvitesApplications.Parser, new string[] { "Invite", "Application" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeToClanBankChanges), SubscribeToClanBankChanges.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeToClanBankChangesResponse), SubscribeToClanBankChangesResponse.Parser, new string[] { "ClanBank" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeFromClanBankChanges), UnsubscribeFromClanBankChanges.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanBankUpdate), ClanBankUpdate.Parser, new string[] { "ClanId", "UpdatedNumTabs", "UpdatedTabs", "AddedItem", "UpdatedItem", "RemovedItemId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindClansRequest), FindClansRequest.Parser, new string[] { "ClientSearchToken", "Params" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindClansResponse), FindClansResponse.Parser, new string[] { "Clan" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanDethroneRequest), ClanDethroneRequest.Parser, new string[] { "ClanId", "TargetGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanDisbandRequest), ClanDisbandRequest.Parser, new string[] { "ClanId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanLeftNotification), ClanLeftNotification.Parser, new string[] { "ClanId", "RemovalReason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInviteConfirmationRequired), PartyInviteConfirmationRequired.Parser, new string[] { "PartyId", "InviteId", "ReservationId", "ConfirmationType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConfirmPartyJoin), ConfirmPartyJoin.Parser, new string[] { "InviterPartyId", "InviteId", "ReservationTokens", "Confirmed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueuedForInstance), QueuedForInstance.Parser, new string[] { "SubzoneType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RequeuedForInstance), RequeuedForInstance.Parser, new string[] { "SubzoneType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnqueuedFromInstance), UnqueuedFromInstance.Parser, new string[] { "SnoSubzone", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueuedInstanceEntered), QueuedInstanceEntered.Parser, new string[] { "SnoSubzone" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueInviteResponse), QueueInviteResponse.Parser, new string[] { "GameAccountId", "Accept" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ModifyBankTab), ModifyBankTab.Parser, new string[] { "ClanId", "BankTabInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ModifyClanBankTabCountRequest), ModifyClanBankTabCountRequest.Parser, new string[] { "ClanId", "NewNumerOfTabs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueEntryAdded), QueueEntryAdded.Parser, new string[] { "EntryKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueUpdate), QueueUpdate.Parser, new string[] { "EntryKey", "AvgWaitSeconds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindGameQueueIdResponse), FindGameQueueIdResponse.Parser, new string[] { "QueueId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshSessionKeyRequest), RefreshSessionKeyRequest.Parser, new string[] { "OldSessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshSessionKeyResponse), RefreshSessionKeyResponse.Parser, new string[] { "NewSessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateSessionKey), UpdateSessionKey.Parser, new string[] { "NewSessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetCatalogResponse), GetCatalogResponse.Parser, new string[] { "Catalog" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WriteSnapshotRequest), WriteSnapshotRequest.Parser, new string[] { "TargetGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeToQueueUpdates), SubscribeToQueueUpdates.Parser, new string[] { "EntryKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyJoinFailed), PartyJoinFailed.Parser, new string[] { "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFallenHeroesResponse), GetFallenHeroesResponse.Parser, new string[] { "Heroes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeleteFallenHeroRequest), DeleteFallenHeroRequest.Parser, new string[] { "HeroId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshLicensesRequest), RefreshLicensesRequest.Parser, new string[] { "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshLicensesResponse), RefreshLicensesResponse.Parser, new string[] { "Licenses" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshLicenseAndConsumableRequest), RefreshLicenseAndConsumableRequest.Parser, new string[] { "AccountId", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshLicenseAndConsumableResponse), RefreshLicenseAndConsumableResponse.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConsumeConsoleEntitlementsRequest), ConsumeConsoleEntitlementsRequest.Parser, new string[] { "SessionKey", "VoucherSno", "InstanceId", "ProductId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConsumableErrorState), ConsumableErrorState.Parser, new string[] { "VoucherSno", "OrderId", "ErrorCode", "ProductId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConsumeConsoleEntitlementsResponse), ConsumeConsoleEntitlementsResponse.Parser, new string[] { "ConsumablesErrorState" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MultiplayerAllowed), MultiplayerAllowed.Parser, new string[] { "IsMultiplayerAllowed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListDeletedHeroesResponse), ListDeletedHeroesResponse.Parser, new string[] { "Heroes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RestoreDeletedHeroRequest), RestoreDeletedHeroRequest.Parser, new string[] { "HeroId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CancelQueueEntry), CancelQueueEntry.Parser, new string[] { "EntryKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnbanPlayer), UnbanPlayer.Parser, new string[] { "ClanId", "TargetGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcknowledgePlayerNotification), AcknowledgePlayerNotification.Parser, new string[] { "NotificationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateAccountLastConnectedTime), UpdateAccountLastConnectedTime.Parser, new string[] { "TargetGameAccountId", "LastConnectedTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcknowledgeLegalDocumentRequest), AcknowledgeLegalDocumentRequest.Parser, new string[] { "DocumentId", "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetLegalDocumentResponse), GetLegalDocumentResponse.Parser, new string[] { "DocumentIds", "Url" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WardenPayload), WardenPayload.Parser, new string[] { "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthorityTransferMessage), AuthorityTransferMessage.Parser, new string[] { "GameHandle", "GameHeartbeatTime" }, null, null, null, null)
			}));
		}

		// Token: 0x04001AD5 RID: 6869
		private static FileDescriptor descriptor;
	}
}
