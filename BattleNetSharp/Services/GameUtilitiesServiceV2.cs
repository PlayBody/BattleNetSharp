using System;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol.GameUtilities.V2.Client;
using Bgs.Protocol.Notification.V2.Client;
using Bgs.Protocol.V2;
using Classic.Protocol.V1.D2RConnection;
using Fenris.ClientMessage;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF8 RID: 2808
	public class GameUtilitiesServiceV2 : GameUtilitiesService.GameUtilitiesServiceBase, IServiceListener
	{
		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00486D80 File Offset: 0x00484F80
		public override Task<GetAllValuesForAttributeResponse> GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, ServerCallContext context)
		{
			return base.GetAllValuesForAttribute(request, context);
		}

        // Token: 0x0600BDA8 RID: 48552 RVA: 0x00486D9C File Offset: 0x00484F9C
        public override Task<ProcessTaskResponse> ProcessTask(ProcessTaskRequest request, ServerCallContext context)
        {
            if (request.Attribute[0].Name != "fenris_message_id")
            {
                throw new Exception("Invalid attribute name");
            }

            if (request.Attribute.Count > 1 && request.Attribute[1].Name == "version")
            {
                string version = request.Attribute[1].Value.StringValue;
            }

            switch (request.Attribute[0].Value.UintValue)
            {
                case 3UL:
                    var pingInfo = new PingConnectionInfoList();
                    pingInfo.ConnectionInfos.Add(new PingConnectionInfo
                    {
                        Address = "127.0.0.2",
                        Port = 3724U,
                        ServerPool = "us-west",
                        MaxSampleInterval = 250U,
                        CaptureDuration = 1000U,
                        MinSamples = 2U,
                        MaxSamples = 10U,
                        EncryptionInfo = Crypto.OnlineCrypto
                    });

                    var pingResponse = new ProcessTaskResponse();
                    pingResponse.Result.Add(new Bgs.Protocol.V2.Attribute
                    {
                        Name = "fenris_message_payload",
                        Value = new Variant
                        {
                            BlobValue = MessageExtensions.ToByteString(pingInfo)
                        }
                    });
                    return Task.FromResult(pingResponse);

                case 4UL:
                    var legalResponse = new ProcessTaskResponse();
                    legalResponse.Result.Add(new Bgs.Protocol.V2.Attribute
                    {
                        Name = "fenris_message_payload",
                        Value = new Variant
                        {
                            BlobValue = ByteString.CopyFromUtf8("https://account.battle.net/login/legal/document/")
                        }
                    });
                    return Task.FromResult(legalResponse);

                case 2UL:
                    return Task.FromResult(new ProcessTaskResponse());

                case 0UL:
                    var findUserRequest = FindUserProxyRequest.Parser.ParseFrom(request.Payload[0].Value.BlobValue.ToByteArray());
                    var queueEntryKey = new QueueEntryKey
                    {
                        EntryId = "15397d40-0000-0000-0000-000000000000",
                        QueueId = new QueueId
                        {
                            Id = "Fenris_SRouter_Queue_0.5.2.34350",
                            QueueType = 0U
                        }
                    };

                    var caller = (ConnectionContext)context.Caller;
                    D2RBGS.BGSConnections[caller].TimeToken = findUserRequest.Token;

                    var findUserResponse = new FindUserProxyResponse
                    {
                        ErrorCode = 0U,
                        Token = findUserRequest.Token,
                        EntryKey = queueEntryKey,
                        ConnectInfo = new ConnectionInfo
                        {
                            Address = "127.0.0.2",
                            Port = 3724U,
                            ServiceMessageQueue = "",
                            Player =
                    {
                        new ConnectionInfo.Types.Player
                        {
                            BnetAccountId = D2RBGS.BGSConnections[caller].AccountLow,
                            GameAccountId = D2RBGS.BGSConnections[caller].GameAccountLow,
                            AuthToken = findUserRequest.Token,
                            EncryptionInfo = Crypto.OnlineCrypto
                        }
                    }
                        }
                    };

                    Task.Run(() =>
                    {
                        Thread.Sleep(200);

                        var notification = new NotificationReceivedNotification();
                        var baseNotification = new Notification
                        {
                            Sender = new UserDescription(),
                            Target = new UserDescription { AccountId = 1UL },
                            Type = "FEN.NotificationMessage"
                        };

                        baseNotification.Attribute.Add(new Bgs.Protocol.V2.Attribute
                        {
                            Name = "FEN.NotificationMessage.MessageId",
                            Value = new Variant { IntValue = 2L }
                        });

                        baseNotification.Attribute.Add(new Bgs.Protocol.V2.Attribute
                        {
                            Name = "FEN.NotificationMessage.Payload",
                            Value = new Variant
                            {
                                BlobValue = MessageExtensions.ToByteString(new QueueEntryAdded { EntryKey = queueEntryKey })
                            }
                        });

                        notification.Notifications.Add(baseNotification);
                        D2RBGS.BGSConnections[caller].SendBgsServer(notification, "OnNotificationReceived", typeof(NotificationListener));

                        var userNotification = new Notification
                        {
                            Sender = new UserDescription(),
                            Target = new UserDescription { AccountId = 1UL },
                            Type = "FEN.NotificationMessage"
                        };

                        userNotification.Attribute.Add(new Bgs.Protocol.V2.Attribute
                        {
                            Name = "FEN.NotificationMessage.MessageId",
                            Value = new Variant { IntValue = 0L }
                        });

                        userNotification.Attribute.Add(new Bgs.Protocol.V2.Attribute
                        {
                            Name = "FEN.NotificationMessage.Payload",
                            Value = new Variant
                            {
                                BlobValue = MessageExtensions.ToByteString(findUserResponse)
                            }
                        });

                        var userNotificationWrapper = new NotificationReceivedNotification();
                        userNotificationWrapper.Notifications.Add(userNotification);
                        D2RBGS.BGSConnections[caller].SendBgsServer(userNotificationWrapper, "OnNotificationReceived", typeof(NotificationListener));
                    });

                    return Task.FromResult(new ProcessTaskResponse());

                default:
                    var loginResponse = new LoginResponse
                    {
                        Url = "wss://las1a-d2r-rclient.classic.blizzard.com/",
                        Unk = 0
                    };
                    throw new Exception("Unhandled fenris_message_id");
            }
        }

    }
