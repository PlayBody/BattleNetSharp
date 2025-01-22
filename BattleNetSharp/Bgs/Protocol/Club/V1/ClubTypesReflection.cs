using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200050D RID: 1293
	public static class ClubTypesReflection
	{
		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x06007E33 RID: 32307 RVA: 0x001EB42C File Offset: 0x001E962C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubTypesReflection.descriptor;
			}
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x001EB444 File Offset: 0x001E9644
		static ClubTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiJiZ3MvbG93L3BiL2NsaWVudC9jbHViX3R5cGVzLnByb3RvEhRiZ3MucHJv", "dG9jb2wuY2x1Yi52MRotYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9tZW1iZXJz", "aGlwX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9jbHViX2VudW0u", "cHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L2NsdWJfcm9sZS5wcm90bxomYmdz", "L2xvdy9wYi9jbGllbnQvY2x1Yl9yYW5nZV9zZXQucHJvdG8aIWJncy9sb3cv", "cGIvY2xpZW50L2NsdWJfY29yZS5wcm90bxojYmdzL2xvdy9wYi9jbGllbnQv", "Y2x1Yl9tZW1iZXIucHJvdG8aJ2Jncy9sb3cvcGIvY2xpZW50L2NsdWJfaW52", "aXRhdGlvbi5wcm90bxogYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9iYW4ucHJv", "dG8aI2Jncy9sb3cvcGIvY2xpZW50L2NsdWJfc3RyZWFtLnByb3RvGiFiZ3Mv", "bG93L3BiL2NsaWVudC9jbHViX3R5cGUucHJvdG8aIGJncy9sb3cvcGIvY2xp",
				"ZW50L2NsdWJfdGFnLnByb3RvGitiZ3MvbG93L3BiL2NsaWVudC9jbHViX25h", "bWVfZ2VuZXJhdG9yLnByb3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xp", "ZW50L3YyL2F0dHJpYnV0ZV90eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGll", "bnQvYWNjb3VudF90eXBlcy5wcm90bxooYmdzL2xvdy9wYi9jbGllbnQvZXZl", "bnRfdmlld190eXBlcy5wcm90bxooYmdzL2xvdy9wYi9jbGllbnQvaW52aXRh", "dGlvbl90eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvbWVzc2FnZV90", "eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvZXRzX3R5cGVzLnByb3Rv", "GiNiZ3MvbG93L3BiL2NsaWVudC92b2ljZV90eXBlcy5wcm90bxohYmdzL2xv", "dy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvUABQAVACUANQBFAFUAZQB1AI", "UAlQClALUAxQDVAOUA9QEFARUBJQEw=="
			}));
			ClubTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubMembershipTypesReflection.Descriptor,
				ClubEnumReflection.Descriptor,
				ClubRoleReflection.Descriptor,
				ClubRangeSetReflection.Descriptor,
				ClubCoreReflection.Descriptor,
				ClubMemberReflection.Descriptor,
				ClubInvitationReflection.Descriptor,
				ClubBanReflection.Descriptor,
				ClubStreamReflection.Descriptor,
				ClubTypeReflection.Descriptor,
				ClubTagReflection.Descriptor,
				ClubNameGeneratorReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				EventViewTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor,
				EtsTypesReflection.Descriptor,
				VoiceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, null));
		}

		// Token: 0x04003969 RID: 14697
		private static FileDescriptor descriptor;
	}
}
