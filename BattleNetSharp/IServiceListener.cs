using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace BattleNetSharp
{
	// Token: 0x02000ADD RID: 2781
	public interface IServiceListener
	{
		// Token: 0x0600BCD9 RID: 48345 RVA: 0x004837D8 File Offset: 0x004819D8
		public static void test(string s)
		{
			Console.WriteLine(s + " : " + BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(s))).ToString("X"));
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600BCDA RID: 48346 RVA: 0x00483824 File Offset: 0x00481A24
		ServiceDescriptor Descriptor
		{
			get
			{
				// @Review base -> this
				return (ServiceDescriptor)((Type)this.GetType().BaseType.GetCustomAttributesData()[0].ConstructorArguments[0].Value).GetProperty("Descriptor").GetValue(null);
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600BCDB RID: 48347 RVA: 0x00483874 File Offset: 0x00481A74
		uint Hash
		{
			get
			{
				ServiceDescriptor descriptor = this.Descriptor;
				string descriptorName = this.Descriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_).DescriptorName;
				bool flag = descriptorName.StartsWith("0x");
				uint num;
				if (flag)
				{
					num = Convert.ToUInt32(descriptorName, 16);
				}
				else
				{
					num = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(descriptorName)));
				}
				return num;
			}
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x004838E4 File Offset: 0x00481AE4
		public static void DumpAll()
		{
			IServiceListener.test("bnet.protocol.club.v2.ClubMembershipService");
			IServiceListener.test("bnet.protocol.authentication.v2.client.AuthenticationListener");
			IServiceListener.test("bnet.protocol.session.v2.client.SessionService");
			IServiceListener.test("bnet.protocol.game_utilities.v2.client.GameUtilities");
			IServiceListener.test("bnet.protocol.publication.v2.client.PublicationService");
			IServiceListener.test("bnet.protocol.channel.v2.ChannelService");
			IServiceListener.test("bnet.protocol.channel.v2.ChannelListener");
			IServiceListener.test("bnet.protocol.report.v2.ReportService");
			IServiceListener.test("bnet.protocol.whisper.WhisperListener");
			IServiceListener.test("bnet.protocol.resources.Resources");
			IServiceListener.test("bnet.protocol.game_utilities.v2.server.GameUtilitiesListener");
			IServiceListener.test("bnet.protocol.connection.ConnectionService");
			IServiceListener.test("bnet.protocol.session.v2.client.SessionListener");
			IServiceListener.test("bnet.protocol.presence.v2.client.PresenceService");
			IServiceListener.test("bnet.protocol.account.AccountService");
			IServiceListener.test("bnet.protocol.account.AccountNotify");
			IServiceListener.test("bnet.protocol.session.SessionListener");
			IServiceListener.test("bnet.protocol.session.SessionService");
			IServiceListener.test("bnet.protocol.channel.v2.membership.ChannelMembershipService");
			IServiceListener.test("bnet.protocol.channel.v2.membership.ChannelMembershipListener");
			IServiceListener.test("bnet.protocol.friends.FriendsService");
			IServiceListener.test("bnet.protocol.friends.FriendsNotify");
			IServiceListener.test("bnet.protocol.whisper.WhisperService");
			IServiceListener.test("bnet.protocol.club.v1.ClubMembershipService");
			IServiceListener.test("bnet.protocol.club.v1.ClubMembershipListener");
			IServiceListener.test("bnet.protocol.block_list.v1.client.BlockListService");
			IServiceListener.test("bnet.protocol.voice.v2.client.VoiceService");
			IServiceListener.test("bnet.protocol.channel.v2.server.ChannelServerListener");
			IServiceListener.test("bnet.protocol.authentication.AuthenticationClient");
			IServiceListener.test("bnet.protocol.authentication.AuthenticationServer");
			IServiceListener.test("bnet.protocol.authentication.v2.client.AuthenticationService");
			IServiceListener.test("bnet.protocol.presence.v2.client.PresenceListener");
			IServiceListener.test("bnet.protocol.notification.v2.client.NotificationListener");
			IServiceListener.test("bnet.protocol.publication.v2.client.PublicationListener");
			IServiceListener.test("bnet.protocol.block_list.v1.client.BlockListListener");
			IServiceListener.test("bnet.protocol.challenge.ChallengeNotify");
			string text = "bnet.protocol.game_utilities.v2.server.GameUtilitiesListener";
			text = "bnet.protocol.diag.DiagService";
			text = "bnet.protocol.voice.v2.client.VoiceService";
			text = "bnet.protocol.channel.v2.server.ChannelServerListener";
			List<string> list = new List<string>
			{
				"terror_zones", "bnet.protocol.resources.Resources", "bnet.protocol.account.AccountNotify", "bnet.protocol.friends.FriendsNotify", "bnet.protocol.account.AccountService", "bnet.protocol.friends.FriendsService", "bnet.protocol.session.SessionService", "bnet.protocol.whisper.WhisperService", "bnet.protocol.report.v2.ReportService", "bnet.protocol.session.SessionListener",
				"bnet.protocol.whisper.WhisperListener", "bnet.protocol.challenge.ChallengeNotify", "bnet.protocol.channel.v2.ChannelService", "bnet.protocol.channel.v2.ChannelListener", "bnet.protocol.connection.ConnectionService", "bnet.protocol.voice.v2.client.VoiceService", "bnet.protocol.club.v1.ClubMembershipService", "bnet.protocol.club.v1.ClubMembershipListener", "bnet.protocol.user_manager.UserManagerNotify", "bnet.protocol.user_manager.UserManagerService",
				"bnet.protocol.presence.v2.client.PresenceService", "bnet.protocol.authentication.AuthenticationClient", "bnet.protocol.authentication.AuthenticationServer", "bnet.protocol.presence.v2.client.PresenceListener", "bnet.protocol.block_list.v1.client.BlockListService", "bnet.protocol.block_list.v1.client.BlockListListener", "bnet.protocol.game_utilities.v2.client.GameUtilities", "bnet.protocol.channel.v2.server.ChannelServerListener", "bnet.protocol.publication.v2.client.PublicationService", "bnet.protocol.publication.v2.client.PublicationListener",
				"bnet.protocol.notification.v2.client.NotificationListener", "bnet.protocol.authentication.v2.client.AuthenticationService", "bnet.protocol.channel.v2.membership.ChannelMembershipService", "bnet.protocol.game_utilities.v2.server.GameUtilitiesListener", "bnet.protocol.authentication.v2.client.AuthenticationListener", "bnet.protocol.channel.v2.membership.ChannelMembershipListener", "bnet.protocol.diag.DiagService"
			};
			Dictionary<string, uint> dictionary = new Dictionary<string, uint>();
			foreach (string text2 in list)
			{
				dictionary.Add(text2, BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(text2))));
			}
			uint num = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(text)));
			Type[] types = typeof(IServiceListener).GetType().Assembly.GetTypes();
		}

        // Token: 0x0600BCDD RID: 48349 RVA: 0x00483D00 File Offset: 0x00481F00
        IMessage Invoke(uint methodId, byte[] input, ConnectionContext callContext)
        {
            MethodDescriptor methodDescriptor = this.Descriptor.Methods.First(m =>
                m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == methodId);

            MethodInfo method = this.GetType().GetMethod(methodDescriptor.Name);
            Type parameterType = method.GetParameters()[0].ParameterType;

            IMessage message = (IMessage)Activator.CreateInstance(parameterType);
            MessageExtensions.MergeFrom(message, input);

            object result = method.Invoke(this, new object[] { message, callContext });
            if (result is IMessage messageResult)
            {
                return messageResult;
            }

            PropertyInfo resultProperty = result?.GetType().GetProperty("Result");
            if (resultProperty != null)
            {
                return resultProperty.GetValue(result) as IMessage;
            }

            throw new InvalidOperationException("The invoked method did not return a valid IMessage.");
        }

        // Token: 0x0600BCDE RID: 48350 RVA: 0x00483E18 File Offset: 0x00482018
        string GetMethod(uint methodId)
		{
			MethodDescriptor methodDescriptor = this.Descriptor.Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == methodId);
			return methodDescriptor.Name;
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x00483E5C File Offset: 0x0048205C
		IMessage GetPacket(uint methodId, byte[] input, out string methodName)
		{
			MethodDescriptor methodDescriptor = this.Descriptor.Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == methodId);
			MethodInfo method = this.GetType().GetMethod(methodDescriptor.Name);
			methodName = method.Name;
			Type parameterType = method.GetParameters()[0].ParameterType;
			IMessage message = (IMessage)Activator.CreateInstance(parameterType);
			MessageExtensions.MergeFrom(message, input);
			return message;
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x00483EDC File Offset: 0x004820DC
		IMessage GetResult(uint methodId, byte[] input, out string methodName)
		{
			MethodDescriptor methodDescriptor = this.Descriptor.Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == methodId);
			MethodInfo method = this.GetType().GetMethod(methodDescriptor.Name);
			methodName = method.Name;
			Type type = method.ReturnType.GenericTypeArguments[0];
			IMessage message = (IMessage)Activator.CreateInstance(type);
			MessageExtensions.MergeFrom(message, input);
			return message;
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x00483F5C File Offset: 0x0048215C
		public static void GetHashes()
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				foreach (Type type in assembly.GetTypes())
				{
					bool flag = type.Name.Contains("ServiceBase");
					if (flag)
					{
						ServiceDescriptor serviceDescriptor = (ServiceDescriptor)((Type)type.GetCustomAttributesData()[0].ConstructorArguments[0].Value).GetProperty("Descriptor").GetValue(null);
						BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
						uint num = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
						Console.WriteLine(type.Name + " : " + num.ToString());
					}
				}
			}
		}
	}
}
