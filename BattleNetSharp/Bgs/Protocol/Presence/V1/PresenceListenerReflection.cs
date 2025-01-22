using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059A RID: 1434
	public static class PresenceListenerReflection
	{
		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x0021349C File Offset: 0x0021169C
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.descriptor;
			}
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x002134B4 File Offset: 0x002116B4
		static PresenceListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiliZ3MvbG93L3BiL2NsaWVudC9wcmVzZW5jZV9saXN0ZW5lci5wcm90bxIY", "YmdzLnByb3RvY29sLnByZXNlbmNlLnYxGiZiZ3MvbG93L3BiL2NsaWVudC9w", "cmVzZW5jZV90eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3Vu", "dF90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnBy", "b3RvIooBChVTdWJzY3JpYmVOb3RpZmljYXRpb24SOQoNc3Vic2NyaWJlcl9p", "ZBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBI2", "CgVzdGF0ZRgCIAMoCzInLmJncy5wcm90b2NvbC5wcmVzZW5jZS52MS5QcmVz", "ZW5jZVN0YXRlIo0BChhTdGF0ZUNoYW5nZWROb3RpZmljYXRpb24SOQoNc3Vi", "c2NyaWJlcl9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFj", "Y291bnRJZBI2CgVzdGF0ZRgCIAMoCzInLmJncy5wcm90b2NvbC5wcmVzZW5j",
				"ZS52MS5QcmVzZW5jZVN0YXRlMpYCChBQcmVzZW5jZUxpc3RlbmVyEmEKC09u", "U3Vic2NyaWJlEi8uYmdzLnByb3RvY29sLnByZXNlbmNlLnYxLlN1YnNjcmli", "ZU5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkr", "AggBEmcKDk9uU3RhdGVDaGFuZ2VkEjIuYmdzLnByb3RvY29sLnByZXNlbmNl", "LnYxLlN0YXRlQ2hhbmdlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5O", "T19SRVNQT05TRSIGgvkrAggCGjaC+SssCipibmV0LnByb3RvY29sLnByZXNl", "bmNlLnYxLlByZXNlbmNlTGlzdGVuZXKK+SsCCAE="
			}));
			PresenceListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				PresenceTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeNotification), SubscribeNotification.Parser, new string[] { "SubscriberId", "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StateChangedNotification), StateChangedNotification.Parser, new string[] { "SubscriberId", "State" }, null, null, null, null)
			}));
		}

		// Token: 0x04003DEA RID: 15850
		private static FileDescriptor descriptor;
	}
}
