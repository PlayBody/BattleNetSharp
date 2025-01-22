using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel
{
	// Token: 0x02000654 RID: 1620
	public static class ChannelRoleSetReflection
	{
		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x060096A4 RID: 38564 RVA: 0x00246948 File Offset: 0x00244B48
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelRoleSetReflection.descriptor;
			}
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x00246960 File Offset: 0x00244B60
		static ChannelRoleSetReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CihiZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX3JvbGVfc2V0LnByb3RvEhRi", "Z3MucHJvdG9jb2wuY2hhbm5lbBoiYmdzL2xvdy9wYi9jbGllbnQvcm9sZV90", "eXBlcy5wcm90byK5AwoTQ2hhbm5lbFByaXZpbGVnZVNldBISCgpjYW5faW52", "aXRlGAEgASgIEiMKG2Nhbl9pbnZpdGVfd2l0aF9yZXNlcnZhdGlvbhgCIAEo", "CBIjChtjYW5fcmV2b2tlX290aGVyX2ludml0YXRpb24YAyABKAgSIQoZY2Fu", "X3Jldm9rZV9vd25faW52aXRhdGlvbhgEIAEoCBIQCghjYW5fa2ljaxgFIAEo", "CBIUCgxjYW5fZGlzc29sdmUYBiABKAgSFwoPY2FuX3NldF9wcml2YWN5GAcg", "ASgIEhgKEGNhbl9zZW5kX21lc3NhZ2UYCCABKAgSGwoTY2FuX3JlY2VpdmVf", "bWVzc2FnZRgJIAEoCBIZChFjYW5fc2V0X2F0dHJpYnV0ZRgKIAEoCBImCh5j", "YW5fc2V0X290aGVyX21lbWJlcl9hdHRyaWJ1dGUYCyABKAgSJAocY2FuX3Nl",
				"dF9vd25fbWVtYmVyX2F0dHJpYnV0ZRgMIAEoCBIWCg5jYW5fZW50ZXJfZ2Ft", "ZRgNIAEoCBITCgtjYW5fc3VnZ2VzdBgOIAEoCBITCgtjYW5fYXBwcm92ZRgP", "IAEoCCJ/CgtDaGFubmVsUm9sZRIKCgJpZBgBIAEoDRImCgVzdGF0ZRgCIAEo", "CzIXLmJncy5wcm90b2NvbC5Sb2xlU3RhdGUSPAoJcHJpdmlsZWdlGAMgASgL", "MikuYmdzLnByb3RvY29sLmNoYW5uZWwuQ2hhbm5lbFByaXZpbGVnZVNldCJp", "Cg5DaGFubmVsUm9sZVNldBIvCgRyb2xlGAEgAygLMiEuYmdzLnByb3RvY29s", "LmNoYW5uZWwuQ2hhbm5lbFJvbGUSGAoMZGVmYXVsdF9yb2xlGAIgAygNQgIQ", "ARIMCgRuYW1lGAMgASgJ"
			}));
			ChannelRoleSetReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RoleTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChannelPrivilegeSet), ChannelPrivilegeSet.Parser, new string[]
				{
					"CanInvite", "CanInviteWithReservation", "CanRevokeOtherInvitation", "CanRevokeOwnInvitation", "CanKick", "CanDissolve", "CanSetPrivacy", "CanSendMessage", "CanReceiveMessage", "CanSetAttribute",
					"CanSetOtherMemberAttribute", "CanSetOwnMemberAttribute", "CanEnterGame", "CanSuggest", "CanApprove"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelRole), ChannelRole.Parser, new string[] { "Id", "State", "Privilege" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelRoleSet), ChannelRoleSet.Parser, new string[] { "Role", "DefaultRole", "Name" }, null, null, null, null)
			}));
		}

		// Token: 0x040043DE RID: 17374
		private static FileDescriptor descriptor;
	}
}
