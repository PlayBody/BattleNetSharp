using System;
using System.Collections.Generic;
using D2Packets;
using Utilities;

namespace WoW.Packets
{
	// Token: 0x02000811 RID: 2065
	public class AuthResponse : ServerPacket
	{
		// Token: 0x0600B53F RID: 46399 RVA: 0x002C32F4 File Offset: 0x002C14F4
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			ByteBuffer byteBuffer = new ByteBuffer(Bytes);
			this.Result = (AuthResponse.BattlenetRpcErrorCode)byteBuffer.ReadUInt32();
			bool flag = byteBuffer.ReadBit();
			bool flag2 = byteBuffer.ReadBit();
			bool flag3 = byteBuffer.ReadBit();
			bool flag4 = byteBuffer.ReadBit();
			bool flag5 = byteBuffer.ReadBit();
			bool flag6 = byteBuffer.ReadBit();
			bool flag7 = byteBuffer.ReadBit();
			bool flag8 = byteBuffer.ReadBit();
			this.WaitInfo.HasValue = byteBuffer.ReadBit();
			byteBuffer.ReadBits(6);
			bool hasValue = this.SuccessInfo.HasValue;
			if (hasValue)
			{
				this.SuccessInfo.Value.VirtualRealmAddress = byteBuffer.ReadUInt32();
				uint num = byteBuffer.ReadUInt32();
				this.SuccessInfo.Value.TimeRested = byteBuffer.ReadUInt32();
			}
		}

		// Token: 0x04005AB5 RID: 23221
		public AuthResponse.BattlenetRpcErrorCode Result;

		// Token: 0x04005AB6 RID: 23222
		public Optional<AuthResponse.AuthSuccessInfo> SuccessInfo;

		// Token: 0x04005AB7 RID: 23223
		public Optional<AuthWaitInfo> WaitInfo;

		// Token: 0x020012E0 RID: 4832
		public class AuthSuccessInfo : Packet
		{
			// Token: 0x040099F1 RID: 39409
			public byte ActiveExpansionLevel;

			// Token: 0x040099F2 RID: 39410
			public byte AccountExpansionLevel;

			// Token: 0x040099F3 RID: 39411
			public uint TimeRested;

			// Token: 0x040099F4 RID: 39412
			public uint VirtualRealmAddress;

			// Token: 0x040099F5 RID: 39413
			public uint TimeSecondsUntilPCKick;

			// Token: 0x040099F6 RID: 39414
			public uint CurrencyID;

			// Token: 0x040099F7 RID: 39415
			public ulong Time;

			// Token: 0x040099F8 RID: 39416
			public AuthResponse.AuthSuccessInfo.GameTime GameTimeInfo;

			// Token: 0x040099F9 RID: 39417
			public List<VirtualRealmInfo> VirtualRealms = new List<VirtualRealmInfo>();

			// Token: 0x040099FA RID: 39418
			public List<AuthResponse.AuthSuccessInfo.CharacterTemplate> Templates = new List<AuthResponse.AuthSuccessInfo.CharacterTemplate>();

			// Token: 0x040099FB RID: 39419
			public List<AuthResponse.AuthSuccessInfo.RaceClassAvailability> AvailableClasses;

			// Token: 0x040099FC RID: 39420
			public bool IsExpansionTrial;

			// Token: 0x040099FD RID: 39421
			public bool ForceCharacterTemplate;

			// Token: 0x040099FE RID: 39422
			public Optional<ushort> NumPlayersHorde;

			// Token: 0x040099FF RID: 39423
			public Optional<ushort> NumPlayersAlliance;

			// Token: 0x04009A00 RID: 39424
			public Optional<uint> ExpansionTrialExpiration;

			// Token: 0x0200149B RID: 5275
			public class GameTime : Packet
			{
				// Token: 0x0400A50A RID: 42250
				public uint BillingPlan;

				// Token: 0x0400A50B RID: 42251
				public uint TimeRemain;

				// Token: 0x0400A50C RID: 42252
				public uint Unknown735;

				// Token: 0x0400A50D RID: 42253
				public bool InGameRoom;
			}

			// Token: 0x0200149C RID: 5276
			public class ClassAvailability : Packet
			{
				// Token: 0x0400A50E RID: 42254
				public byte ClassID;

				// Token: 0x0400A50F RID: 42255
				public byte ActiveExpansionLevel;

				// Token: 0x0400A510 RID: 42256
				public byte AccountExpansionLevel;
			}

			// Token: 0x0200149D RID: 5277
			public class RaceClassAvailability : Packet
			{
				// Token: 0x0600E7B7 RID: 59319 RVA: 0x004DC778 File Offset: 0x004DA978
				public override void FromBitReader(BitReader bitReader)
				{
					this.RaceID = bitReader.ReadByte();
					uint num = bitReader.ReadUInt32();
					int num2 = 0;
					while ((long)num2 < (long)((ulong)num))
					{
						this.Classes.Add(new AuthResponse.AuthSuccessInfo.ClassAvailability
						{
							BitReader = bitReader
						});
						num2++;
					}
				}

				// Token: 0x0400A511 RID: 42257
				public byte RaceID;

				// Token: 0x0400A512 RID: 42258
				public List<AuthResponse.AuthSuccessInfo.ClassAvailability> Classes = new List<AuthResponse.AuthSuccessInfo.ClassAvailability>();
			}

			// Token: 0x0200149E RID: 5278
			public enum FactionMasks : byte
			{
				// Token: 0x0400A514 RID: 42260
				Player = 1,
				// Token: 0x0400A515 RID: 42261
				Alliance,
				// Token: 0x0400A516 RID: 42262
				Horde = 4,
				// Token: 0x0400A517 RID: 42263
				Monster = 8
			}

			// Token: 0x0200149F RID: 5279
			public class CharacterTemplateClass : Packet
			{
				// Token: 0x0400A518 RID: 42264
				public AuthResponse.AuthSuccessInfo.FactionMasks FactionGroup;

				// Token: 0x0400A519 RID: 42265
				public byte ClassID;
			}

			// Token: 0x020014A0 RID: 5280
			public class CharacterTemplate : Packet
			{
				// Token: 0x0600E7BA RID: 59322 RVA: 0x004DC7E4 File Offset: 0x004DA9E4
				public override void FromBitReader(BitReader bitReader)
				{
					this.TemplateSetId = bitReader.ReadUInt32();
					uint num = bitReader.ReadUInt32();
					this.Classes = new List<AuthResponse.AuthSuccessInfo.CharacterTemplateClass>();
					int num2 = 0;
					while ((long)num2 < (long)((ulong)num))
					{
						this.Classes.Add(new AuthResponse.AuthSuccessInfo.CharacterTemplateClass
						{
							BitReader = bitReader
						});
						num2++;
					}
					ulong num3 = bitReader.ReadBits(7);
					ulong num4 = bitReader.ReadBits(10);
					bitReader.ReadBits(7);
					this.Name = bitReader.ReadString((uint)num3);
					this.Description = bitReader.ReadString((uint)num4);
				}

				// Token: 0x0400A51A RID: 42266
				public uint TemplateSetId;

				// Token: 0x0400A51B RID: 42267
				public List<AuthResponse.AuthSuccessInfo.CharacterTemplateClass> Classes;

				// Token: 0x0400A51C RID: 42268
				public string Name;

				// Token: 0x0400A51D RID: 42269
				public string Description;

				// Token: 0x0400A51E RID: 42270
				public byte Level;
			}
		}

		// Token: 0x020012E1 RID: 4833
		public enum BattlenetRpcErrorCode : uint
		{
			// Token: 0x04009A02 RID: 39426
			Ok,
			// Token: 0x04009A03 RID: 39427
			Internal,
			// Token: 0x04009A04 RID: 39428
			TimedOut,
			// Token: 0x04009A05 RID: 39429
			Denied,
			// Token: 0x04009A06 RID: 39430
			NotExists,
			// Token: 0x04009A07 RID: 39431
			NotStarted,
			// Token: 0x04009A08 RID: 39432
			InProgress,
			// Token: 0x04009A09 RID: 39433
			InvalidArgs,
			// Token: 0x04009A0A RID: 39434
			InvalidSubscriber,
			// Token: 0x04009A0B RID: 39435
			WaitingForDependency,
			// Token: 0x04009A0C RID: 39436
			NoAuth,
			// Token: 0x04009A0D RID: 39437
			ParentalControlRestriction,
			// Token: 0x04009A0E RID: 39438
			NoGameAccount,
			// Token: 0x04009A0F RID: 39439
			NotImplemented,
			// Token: 0x04009A10 RID: 39440
			ObjectRemoved,
			// Token: 0x04009A11 RID: 39441
			InvalidEntityId,
			// Token: 0x04009A12 RID: 39442
			InvalidEntityAccountId,
			// Token: 0x04009A13 RID: 39443
			InvalidEntityGameAccountId,
			// Token: 0x04009A14 RID: 39444
			InvalidAgentId = 19U,
			// Token: 0x04009A15 RID: 39445
			InvalidTargetId,
			// Token: 0x04009A16 RID: 39446
			ModuleNotLoaded,
			// Token: 0x04009A17 RID: 39447
			ModuleNoEntryPoint,
			// Token: 0x04009A18 RID: 39448
			ModuleSignatureIncorrect,
			// Token: 0x04009A19 RID: 39449
			ModuleCreateFailed,
			// Token: 0x04009A1A RID: 39450
			NoProgram,
			// Token: 0x04009A1B RID: 39451
			ApiNotReady = 27U,
			// Token: 0x04009A1C RID: 39452
			BadVersion,
			// Token: 0x04009A1D RID: 39453
			AttributeTooManyAttributesSet,
			// Token: 0x04009A1E RID: 39454
			AttributeMaxSizeExceeded,
			// Token: 0x04009A1F RID: 39455
			AttributeQuotaExceeded,
			// Token: 0x04009A20 RID: 39456
			ServerPoolServerDisappeared,
			// Token: 0x04009A21 RID: 39457
			ServerIsPrivate,
			// Token: 0x04009A22 RID: 39458
			Disabled,
			// Token: 0x04009A23 RID: 39459
			ModuleNotFound = 36U,
			// Token: 0x04009A24 RID: 39460
			ServerBusy,
			// Token: 0x04009A25 RID: 39461
			NoBattletag,
			// Token: 0x04009A26 RID: 39462
			IncompleteProfanityFilters,
			// Token: 0x04009A27 RID: 39463
			InvalidRegion,
			// Token: 0x04009A28 RID: 39464
			ExistsAlready,
			// Token: 0x04009A29 RID: 39465
			InvalidServerThumbprint,
			// Token: 0x04009A2A RID: 39466
			PhoneLock,
			// Token: 0x04009A2B RID: 39467
			Squelched,
			// Token: 0x04009A2C RID: 39468
			TargetOffline,
			// Token: 0x04009A2D RID: 39469
			BadServer,
			// Token: 0x04009A2E RID: 39470
			NoCookie,
			// Token: 0x04009A2F RID: 39471
			ExpiredCookie,
			// Token: 0x04009A30 RID: 39472
			TokenNotFound,
			// Token: 0x04009A31 RID: 39473
			GameAccountNoTime,
			// Token: 0x04009A32 RID: 39474
			GameAccountNoPlan,
			// Token: 0x04009A33 RID: 39475
			GameAccountBanned,
			// Token: 0x04009A34 RID: 39476
			GameAccountSuspended,
			// Token: 0x04009A35 RID: 39477
			GameAccountAlreadySelected,
			// Token: 0x04009A36 RID: 39478
			GameAccountCancelled,
			// Token: 0x04009A37 RID: 39479
			GameAccountCreationDisabled,
			// Token: 0x04009A38 RID: 39480
			GameAccountLocked,
			// Token: 0x04009A39 RID: 39481
			SessionDuplicate = 60U,
			// Token: 0x04009A3A RID: 39482
			SessionDisconnected,
			// Token: 0x04009A3B RID: 39483
			SessionDataChanged,
			// Token: 0x04009A3C RID: 39484
			SessionUpdateFailed,
			// Token: 0x04009A3D RID: 39485
			SessionNotFound,
			// Token: 0x04009A3E RID: 39486
			AdminKick = 70U,
			// Token: 0x04009A3F RID: 39487
			UnplannedMaintenance,
			// Token: 0x04009A40 RID: 39488
			PlannedMaintenance,
			// Token: 0x04009A41 RID: 39489
			ServiceFailureAccount,
			// Token: 0x04009A42 RID: 39490
			ServiceFailureSession,
			// Token: 0x04009A43 RID: 39491
			ServiceFailureAuth,
			// Token: 0x04009A44 RID: 39492
			ServiceFailureRisk,
			// Token: 0x04009A45 RID: 39493
			BadProgram,
			// Token: 0x04009A46 RID: 39494
			BadLocale,
			// Token: 0x04009A47 RID: 39495
			BadPlatform,
			// Token: 0x04009A48 RID: 39496
			LocaleRestrictedLa = 81U,
			// Token: 0x04009A49 RID: 39497
			LocaleRestrictedRu,
			// Token: 0x04009A4A RID: 39498
			LocaleRestrictedKo,
			// Token: 0x04009A4B RID: 39499
			LocaleRestrictedTw,
			// Token: 0x04009A4C RID: 39500
			LocaleRestricted,
			// Token: 0x04009A4D RID: 39501
			AccountNeedsMaintenance,
			// Token: 0x04009A4E RID: 39502
			ModuleApiError,
			// Token: 0x04009A4F RID: 39503
			ModuleBadCacheHandle,
			// Token: 0x04009A50 RID: 39504
			ModuleAlreadyLoaded,
			// Token: 0x04009A51 RID: 39505
			NetworkBlacklisted,
			// Token: 0x04009A52 RID: 39506
			EventProcessorSlow,
			// Token: 0x04009A53 RID: 39507
			ServerShuttingDown,
			// Token: 0x04009A54 RID: 39508
			NetworkNotPrivileged,
			// Token: 0x04009A55 RID: 39509
			TooManyOutstandingRequests,
			// Token: 0x04009A56 RID: 39510
			NoAccountRegistered,
			// Token: 0x04009A57 RID: 39511
			BattlenetAccountBanned,
			// Token: 0x04009A58 RID: 39512
			OkDeprecated = 100U,
			// Token: 0x04009A59 RID: 39513
			ServerInModeZombie,
			// Token: 0x04009A5A RID: 39514
			LogonModuleRequired = 500U,
			// Token: 0x04009A5B RID: 39515
			LogonModuleNotConfigured,
			// Token: 0x04009A5C RID: 39516
			LogonModuleTimeout,
			// Token: 0x04009A5D RID: 39517
			LogonAgreementRequired = 510U,
			// Token: 0x04009A5E RID: 39518
			LogonAgreementNotConfigured,
			// Token: 0x04009A5F RID: 39519
			LogonInvalidServerProof = 520U,
			// Token: 0x04009A60 RID: 39520
			LogonWebVerifyTimeout,
			// Token: 0x04009A61 RID: 39521
			LogonInvalidAuthToken,
			// Token: 0x04009A62 RID: 39522
			ChallengeSmsTooSoon = 600U,
			// Token: 0x04009A63 RID: 39523
			ChallengeSmsThrottled,
			// Token: 0x04009A64 RID: 39524
			ChallengeSmsTempOutage,
			// Token: 0x04009A65 RID: 39525
			ChallengeNoChallenge,
			// Token: 0x04009A66 RID: 39526
			ChallengeNotPicked,
			// Token: 0x04009A67 RID: 39527
			ChallengeAlreadyPicked,
			// Token: 0x04009A68 RID: 39528
			ChallengeInProgress,
			// Token: 0x04009A69 RID: 39529
			ConfigFormatInvalid = 700U,
			// Token: 0x04009A6A RID: 39530
			ConfigNotFound,
			// Token: 0x04009A6B RID: 39531
			ConfigRetrieveFailed,
			// Token: 0x04009A6C RID: 39532
			NetworkModuleBusy = 1000U,
			// Token: 0x04009A6D RID: 39533
			NetworkModuleCantResolveAddress,
			// Token: 0x04009A6E RID: 39534
			NetworkModuleConnectionRefused,
			// Token: 0x04009A6F RID: 39535
			NetworkModuleInterrupted,
			// Token: 0x04009A70 RID: 39536
			NetworkModuleConnectionAborted,
			// Token: 0x04009A71 RID: 39537
			NetworkModuleConnectionReset,
			// Token: 0x04009A72 RID: 39538
			NetworkModuleBadAddress,
			// Token: 0x04009A73 RID: 39539
			NetworkModuleNotReady,
			// Token: 0x04009A74 RID: 39540
			NetworkModuleAlreadyConnected,
			// Token: 0x04009A75 RID: 39541
			NetworkModuleCantCreateSocket,
			// Token: 0x04009A76 RID: 39542
			NetworkModuleNetworkUnreachable,
			// Token: 0x04009A77 RID: 39543
			NetworkModuleSocketPermissionDenied,
			// Token: 0x04009A78 RID: 39544
			NetworkModuleNotInitialized,
			// Token: 0x04009A79 RID: 39545
			NetworkModuleNoSslCertificateForPeer,
			// Token: 0x04009A7A RID: 39546
			NetworkModuleNoSslCommonNameForCertificate,
			// Token: 0x04009A7B RID: 39547
			NetworkModuleSslCommonNameDoesNotMatchRemoteEndpoint,
			// Token: 0x04009A7C RID: 39548
			NetworkModuleSocketClosed,
			// Token: 0x04009A7D RID: 39549
			NetworkModuleSslPeerIsNotRegisteredInCertbundle,
			// Token: 0x04009A7E RID: 39550
			NetworkModuleSslInitializeLowFirst,
			// Token: 0x04009A7F RID: 39551
			NetworkModuleSslCertBundleReadError,
			// Token: 0x04009A80 RID: 39552
			NetworkModuleNoCertBundle,
			// Token: 0x04009A81 RID: 39553
			NetworkModuleFailedToDownloadCertBundle,
			// Token: 0x04009A82 RID: 39554
			NetworkModuleNotReadyToRead,
			// Token: 0x04009A83 RID: 39555
			NetworkModuleOpensslX509Ok = 1200U,
			// Token: 0x04009A84 RID: 39556
			NetworkModuleOpensslX509UnableToGetIssuerCert,
			// Token: 0x04009A85 RID: 39557
			NetworkModuleOpensslX509UnableToGetCrl,
			// Token: 0x04009A86 RID: 39558
			NetworkModuleOpensslX509UnableToDecryptCertSignature,
			// Token: 0x04009A87 RID: 39559
			NetworkModuleOpensslX509UnableToDecryptCrlSignature,
			// Token: 0x04009A88 RID: 39560
			NetworkModuleOpensslX509UnableToDecodeIssuerPublicKey,
			// Token: 0x04009A89 RID: 39561
			NetworkModuleOpensslX509CertSignatureFailure,
			// Token: 0x04009A8A RID: 39562
			NetworkModuleOpensslX509CrlSignatureFailure,
			// Token: 0x04009A8B RID: 39563
			NetworkModuleOpensslX509CertNotYetValid,
			// Token: 0x04009A8C RID: 39564
			NetworkModuleOpensslX509CertHasExpired,
			// Token: 0x04009A8D RID: 39565
			NetworkModuleOpensslX509CrlNotYetValid,
			// Token: 0x04009A8E RID: 39566
			NetworkModuleOpensslX509CrlHasExpired,
			// Token: 0x04009A8F RID: 39567
			NetworkModuleOpensslX509InCertNotBeforeField,
			// Token: 0x04009A90 RID: 39568
			NetworkModuleOpensslX509InCertNotAfterField,
			// Token: 0x04009A91 RID: 39569
			NetworkModuleOpensslX509InCrlLastUpdateField,
			// Token: 0x04009A92 RID: 39570
			NetworkModuleOpensslX509InCrlNextUpdateField,
			// Token: 0x04009A93 RID: 39571
			NetworkModuleOpensslX509OutOfMem,
			// Token: 0x04009A94 RID: 39572
			NetworkModuleOpensslX509DepthZeroSelfSignedCert,
			// Token: 0x04009A95 RID: 39573
			NetworkModuleOpensslX509SelfSignedCertInChain,
			// Token: 0x04009A96 RID: 39574
			NetworkModuleOpensslX509UnableToGetIssuerCertLocally,
			// Token: 0x04009A97 RID: 39575
			NetworkModuleOpensslX509UnableToVerifyLeafSignature,
			// Token: 0x04009A98 RID: 39576
			NetworkModuleOpensslX509CertChainTooLong,
			// Token: 0x04009A99 RID: 39577
			NetworkModuleOpensslX509CertRevoked,
			// Token: 0x04009A9A RID: 39578
			NetworkModuleOpensslX509InvalidCa,
			// Token: 0x04009A9B RID: 39579
			NetworkModuleOpensslX509PathLengthExceeded,
			// Token: 0x04009A9C RID: 39580
			NetworkModuleOpensslX509InvalidPurpose,
			// Token: 0x04009A9D RID: 39581
			NetworkModuleOpensslX509CertUntrusted,
			// Token: 0x04009A9E RID: 39582
			NetworkModuleOpensslX509CertRejected,
			// Token: 0x04009A9F RID: 39583
			NetworkModuleOpensslX509SubjectIssuerMismatch,
			// Token: 0x04009AA0 RID: 39584
			NetworkModuleOpensslX509AkidSkidMismatch,
			// Token: 0x04009AA1 RID: 39585
			NetworkModuleOpensslX509AkidIssuerSerialMismatch,
			// Token: 0x04009AA2 RID: 39586
			NetworkModuleOpensslX509KeyusageNoCertsign,
			// Token: 0x04009AA3 RID: 39587
			NetworkModuleOpensslX509ApplicationVerification,
			// Token: 0x04009AA4 RID: 39588
			NetworkModuleSchannelCannotFindOsVersion = 1300U,
			// Token: 0x04009AA5 RID: 39589
			NetworkModuleSchannelOsNotSupported,
			// Token: 0x04009AA6 RID: 39590
			NetworkModuleSchannelLoadlibraryFail,
			// Token: 0x04009AA7 RID: 39591
			NetworkModuleSchannelCannotFindInterface,
			// Token: 0x04009AA8 RID: 39592
			NetworkModuleSchannelInitFail,
			// Token: 0x04009AA9 RID: 39593
			NetworkModuleSchannelFunctionCallFail,
			// Token: 0x04009AAA RID: 39594
			NetworkModuleSchannelX509UnableToGetIssuerCert = 1350U,
			// Token: 0x04009AAB RID: 39595
			NetworkModuleSchannelX509TimeInvalid,
			// Token: 0x04009AAC RID: 39596
			NetworkModuleSchannelX509SignatureInvalid,
			// Token: 0x04009AAD RID: 39597
			NetworkModuleSchannelX509UnableToVerifyLeafSignature,
			// Token: 0x04009AAE RID: 39598
			NetworkModuleSchannelX509SelfSignedLeafCertificate,
			// Token: 0x04009AAF RID: 39599
			NetworkModuleSchannelX509UnhandledError,
			// Token: 0x04009AB0 RID: 39600
			NetworkModuleSchannelX509SelfSignedCertInChain,
			// Token: 0x04009AB1 RID: 39601
			WebsocketHandshake = 1400U,
			// Token: 0x04009AB2 RID: 39602
			NetworkModuleDurangoUnknown = 1500U,
			// Token: 0x04009AB3 RID: 39603
			NetworkModuleDurangoMalformedHostName,
			// Token: 0x04009AB4 RID: 39604
			NetworkModuleDurangoInvalidConnectionResponse,
			// Token: 0x04009AB5 RID: 39605
			NetworkModuleDurangoInvalidCaCert,
			// Token: 0x04009AB6 RID: 39606
			RpcWriteFailed = 3000U,
			// Token: 0x04009AB7 RID: 39607
			RpcServiceNotBound,
			// Token: 0x04009AB8 RID: 39608
			RpcTooManyRequests,
			// Token: 0x04009AB9 RID: 39609
			RpcPeerUnknown,
			// Token: 0x04009ABA RID: 39610
			RpcPeerUnavailable,
			// Token: 0x04009ABB RID: 39611
			RpcPeerDisconnected,
			// Token: 0x04009ABC RID: 39612
			RpcRequestTimedOut,
			// Token: 0x04009ABD RID: 39613
			RpcConnectionTimedOut,
			// Token: 0x04009ABE RID: 39614
			RpcMalformedResponse,
			// Token: 0x04009ABF RID: 39615
			RpcAccessDenied,
			// Token: 0x04009AC0 RID: 39616
			RpcInvalidService,
			// Token: 0x04009AC1 RID: 39617
			RpcInvalidMethod,
			// Token: 0x04009AC2 RID: 39618
			RpcInvalidObject,
			// Token: 0x04009AC3 RID: 39619
			RpcMalformedRequest,
			// Token: 0x04009AC4 RID: 39620
			RpcQuotaExceeded,
			// Token: 0x04009AC5 RID: 39621
			RpcNotImplemented,
			// Token: 0x04009AC6 RID: 39622
			RpcServerError,
			// Token: 0x04009AC7 RID: 39623
			RpcShutdown,
			// Token: 0x04009AC8 RID: 39624
			RpcDisconnect,
			// Token: 0x04009AC9 RID: 39625
			RpcDisconnectIdle,
			// Token: 0x04009ACA RID: 39626
			RpcProtocolError,
			// Token: 0x04009ACB RID: 39627
			RpcNotReady,
			// Token: 0x04009ACC RID: 39628
			RpcForwardFailed,
			// Token: 0x04009ACD RID: 39629
			RpcEncryptionFailed,
			// Token: 0x04009ACE RID: 39630
			RpcInvalidAddress,
			// Token: 0x04009ACF RID: 39631
			RpcMethodDisabled,
			// Token: 0x04009AD0 RID: 39632
			RpcShardNotFound,
			// Token: 0x04009AD1 RID: 39633
			RpcInvalidConnectionId,
			// Token: 0x04009AD2 RID: 39634
			RpcNotConnected,
			// Token: 0x04009AD3 RID: 39635
			RpcInvalidConnectionState,
			// Token: 0x04009AD4 RID: 39636
			RpcServiceAlreadyRegistered,
			// Token: 0x04009AD5 RID: 39637
			PresenceInvalidFieldId = 4000U,
			// Token: 0x04009AD6 RID: 39638
			PresenceNoValidSubscribers,
			// Token: 0x04009AD7 RID: 39639
			PresenceAlreadySubscribed,
			// Token: 0x04009AD8 RID: 39640
			PresenceConsumerNotFound,
			// Token: 0x04009AD9 RID: 39641
			PresenceConsumerIsNull,
			// Token: 0x04009ADA RID: 39642
			PresenceTemporaryOutage,
			// Token: 0x04009ADB RID: 39643
			PresenceTooManySubscriptions,
			// Token: 0x04009ADC RID: 39644
			PresenceSubscriptionCancelled,
			// Token: 0x04009ADD RID: 39645
			PresenceRichPresenceParseError,
			// Token: 0x04009ADE RID: 39646
			PresenceRichPresenceXmlError,
			// Token: 0x04009ADF RID: 39647
			PresenceRichPresenceLoadError,
			// Token: 0x04009AE0 RID: 39648
			FriendsTooManySentInvitations = 5001U,
			// Token: 0x04009AE1 RID: 39649
			FriendsTooManyReceivedInvitations,
			// Token: 0x04009AE2 RID: 39650
			FriendsFriendshipAlreadyExists,
			// Token: 0x04009AE3 RID: 39651
			FriendsFriendshipDoesNotExist,
			// Token: 0x04009AE4 RID: 39652
			FriendsInvitationAlreadyExists,
			// Token: 0x04009AE5 RID: 39653
			FriendsInvalidInvitation,
			// Token: 0x04009AE6 RID: 39654
			FriendsAlreadySubscribed,
			// Token: 0x04009AE7 RID: 39655
			FriendsAccountBlocked = 5009U,
			// Token: 0x04009AE8 RID: 39656
			FriendsNotSubscribed,
			// Token: 0x04009AE9 RID: 39657
			FriendsInvalidRoleId,
			// Token: 0x04009AEA RID: 39658
			FriendsDisabledRoleId,
			// Token: 0x04009AEB RID: 39659
			FriendsNoteMaxSizeExceeded,
			// Token: 0x04009AEC RID: 39660
			FriendsUpdateFriendStateFailed,
			// Token: 0x04009AED RID: 39661
			FriendsInviteeAtMaxFriends,
			// Token: 0x04009AEE RID: 39662
			FriendsInviterAtMaxFriends,
			// Token: 0x04009AEF RID: 39663
			PlatformStorageFileWriteDenied = 6000U,
			// Token: 0x04009AF0 RID: 39664
			WhisperUndeliverable = 7000U,
			// Token: 0x04009AF1 RID: 39665
			WhisperMaxSizeExceeded,
			// Token: 0x04009AF2 RID: 39666
			UserManagerAlreadyBlocked = 8000U,
			// Token: 0x04009AF3 RID: 39667
			UserManagerNotBlocked,
			// Token: 0x04009AF4 RID: 39668
			UserManagerCannotBlockSelf,
			// Token: 0x04009AF5 RID: 39669
			UserManagerAlreadyRegistered,
			// Token: 0x04009AF6 RID: 39670
			UserManagerNotRegistered,
			// Token: 0x04009AF7 RID: 39671
			UserManagerTooManyBlockedEntities,
			// Token: 0x04009AF8 RID: 39672
			UserManagerTooManyIds = 8007U,
			// Token: 0x04009AF9 RID: 39673
			UserManagerBlockRecordUnavailable = 8015U,
			// Token: 0x04009AFA RID: 39674
			UserManagerBlockEntityFailed,
			// Token: 0x04009AFB RID: 39675
			UserManagerUnblockEntityFailed,
			// Token: 0x04009AFC RID: 39676
			UserManagerCannotBlockFriend = 8019U,
			// Token: 0x04009AFD RID: 39677
			SocialNetworkDbException = 9000U,
			// Token: 0x04009AFE RID: 39678
			SocialNetworkDenialFromProvider,
			// Token: 0x04009AFF RID: 39679
			SocialNetworkInvalidSnsId,
			// Token: 0x04009B00 RID: 39680
			SocialNetworkCantSendToProvider,
			// Token: 0x04009B01 RID: 39681
			SocialNetworkExCommFailed,
			// Token: 0x04009B02 RID: 39682
			SocialNetworkDisabled,
			// Token: 0x04009B03 RID: 39683
			SocialNetworkMissingRequestParam,
			// Token: 0x04009B04 RID: 39684
			SocialNetworkUnsupportedOauthVersion,
			// Token: 0x04009B05 RID: 39685
			ChannelFull = 10000U,
			// Token: 0x04009B06 RID: 39686
			ChannelNoChannel,
			// Token: 0x04009B07 RID: 39687
			ChannelNotMember,
			// Token: 0x04009B08 RID: 39688
			ChannelAlreadyMember,
			// Token: 0x04009B09 RID: 39689
			ChannelNoSuchMember,
			// Token: 0x04009B0A RID: 39690
			ChannelInvalidChannelId = 10006U,
			// Token: 0x04009B0B RID: 39691
			ChannelNoSuchInvitation = 10008U,
			// Token: 0x04009B0C RID: 39692
			ChannelTooManyInvitations,
			// Token: 0x04009B0D RID: 39693
			ChannelInvitationAlreadyExists,
			// Token: 0x04009B0E RID: 39694
			ChannelInvalidChannelSize,
			// Token: 0x04009B0F RID: 39695
			ChannelInvalidRoleId,
			// Token: 0x04009B10 RID: 39696
			ChannelRoleNotAssignable,
			// Token: 0x04009B11 RID: 39697
			ChannelInsufficientPrivileges,
			// Token: 0x04009B12 RID: 39698
			ChannelInsufficientPrivacyLevel,
			// Token: 0x04009B13 RID: 39699
			ChannelInvalidPrivacyLevel,
			// Token: 0x04009B14 RID: 39700
			ChannelTooManyChannelsJoined,
			// Token: 0x04009B15 RID: 39701
			ChannelInvitationAlreadySubscribed,
			// Token: 0x04009B16 RID: 39702
			ChannelInvalidChannelDelegate,
			// Token: 0x04009B17 RID: 39703
			ChannelSlotAlreadyReserved,
			// Token: 0x04009B18 RID: 39704
			ChannelSlotNotReserved,
			// Token: 0x04009B19 RID: 39705
			ChannelNoReservedSlotsAvailable,
			// Token: 0x04009B1A RID: 39706
			ChannelInvalidRoleSet,
			// Token: 0x04009B1B RID: 39707
			ChannelRequireFriendValidation,
			// Token: 0x04009B1C RID: 39708
			ChannelMemberOffline,
			// Token: 0x04009B1D RID: 39709
			ChannelReceivedTooManyInvitations,
			// Token: 0x04009B1E RID: 39710
			ChannelInvitationInvalidGameAccountSelected,
			// Token: 0x04009B1F RID: 39711
			ChannelUnreachable,
			// Token: 0x04009B20 RID: 39712
			ChannelInvitationNotSubscribed,
			// Token: 0x04009B21 RID: 39713
			ChannelInvalidMessageSize,
			// Token: 0x04009B22 RID: 39714
			ChannelMaxMessageSizeExceeded,
			// Token: 0x04009B23 RID: 39715
			ChannelConfigNotFound,
			// Token: 0x04009B24 RID: 39716
			ChannelInvalidChannelType,
			// Token: 0x04009B25 RID: 39717
			LocalStorageFileOpenError = 11000U,
			// Token: 0x04009B26 RID: 39718
			LocalStorageFileCreateError,
			// Token: 0x04009B27 RID: 39719
			LocalStorageFileReadError,
			// Token: 0x04009B28 RID: 39720
			LocalStorageFileWriteError,
			// Token: 0x04009B29 RID: 39721
			LocalStorageFileDeleteError,
			// Token: 0x04009B2A RID: 39722
			LocalStorageFileCopyError,
			// Token: 0x04009B2B RID: 39723
			LocalStorageFileDecompressError,
			// Token: 0x04009B2C RID: 39724
			LocalStorageFileHashMismatch,
			// Token: 0x04009B2D RID: 39725
			LocalStorageFileUsageMismatch,
			// Token: 0x04009B2E RID: 39726
			LocalStorageDatabaseInitError,
			// Token: 0x04009B2F RID: 39727
			LocalStorageDatabaseNeedsRebuild,
			// Token: 0x04009B30 RID: 39728
			LocalStorageDatabaseInsertError,
			// Token: 0x04009B31 RID: 39729
			LocalStorageDatabaseLookupError,
			// Token: 0x04009B32 RID: 39730
			LocalStorageDatabaseUpdateError,
			// Token: 0x04009B33 RID: 39731
			LocalStorageDatabaseDeleteError,
			// Token: 0x04009B34 RID: 39732
			LocalStorageDatabaseShrinkError,
			// Token: 0x04009B35 RID: 39733
			LocalStorageCacheCrawlError,
			// Token: 0x04009B36 RID: 39734
			LocalStorageDatabaseIndexTriggerError,
			// Token: 0x04009B37 RID: 39735
			LocalStorageDatabaseRebuildInProgress,
			// Token: 0x04009B38 RID: 39736
			LocalStorageOkButNotInCache,
			// Token: 0x04009B39 RID: 39737
			LocalStorageDatabaseRebuildInterrupted = 11021U,
			// Token: 0x04009B3A RID: 39738
			LocalStorageDatabaseNotInitialized,
			// Token: 0x04009B3B RID: 39739
			LocalStorageDirectoryCreateError,
			// Token: 0x04009B3C RID: 39740
			LocalStorageFilekeyNotFound,
			// Token: 0x04009B3D RID: 39741
			LocalStorageNotAvailableOnServer,
			// Token: 0x04009B3E RID: 39742
			RegistryCreateKeyError = 12000U,
			// Token: 0x04009B3F RID: 39743
			RegistryOpenKeyError,
			// Token: 0x04009B40 RID: 39744
			RegistryReadError,
			// Token: 0x04009B41 RID: 39745
			RegistryWriteError,
			// Token: 0x04009B42 RID: 39746
			RegistryTypeError,
			// Token: 0x04009B43 RID: 39747
			RegistryDeleteError,
			// Token: 0x04009B44 RID: 39748
			RegistryEncryptError,
			// Token: 0x04009B45 RID: 39749
			RegistryDecryptError,
			// Token: 0x04009B46 RID: 39750
			RegistryKeySizeError,
			// Token: 0x04009B47 RID: 39751
			RegistryValueSizeError,
			// Token: 0x04009B48 RID: 39752
			RegistryNotFound = 12011U,
			// Token: 0x04009B49 RID: 39753
			RegistryMalformedString,
			// Token: 0x04009B4A RID: 39754
			InterfaceAlreadyConnected = 13000U,
			// Token: 0x04009B4B RID: 39755
			InterfaceNotReady,
			// Token: 0x04009B4C RID: 39756
			InterfaceOptionKeyTooLarge,
			// Token: 0x04009B4D RID: 39757
			InterfaceOptionValueTooLarge,
			// Token: 0x04009B4E RID: 39758
			InterfaceOptionKeyInvalidUtf8String,
			// Token: 0x04009B4F RID: 39759
			InterfaceOptionValueInvalidUtf8String,
			// Token: 0x04009B50 RID: 39760
			HttpCouldntResolve = 14000U,
			// Token: 0x04009B51 RID: 39761
			HttpCouldntConnect,
			// Token: 0x04009B52 RID: 39762
			HttpTimeout,
			// Token: 0x04009B53 RID: 39763
			HttpFailed,
			// Token: 0x04009B54 RID: 39764
			HttpMalformedUrl,
			// Token: 0x04009B55 RID: 39765
			HttpDownloadAborted,
			// Token: 0x04009B56 RID: 39766
			HttpCouldntWriteFile,
			// Token: 0x04009B57 RID: 39767
			HttpTooManyRedirects,
			// Token: 0x04009B58 RID: 39768
			HttpCouldntOpenFile,
			// Token: 0x04009B59 RID: 39769
			HttpCouldntCreateFile,
			// Token: 0x04009B5A RID: 39770
			HttpCouldntReadFile,
			// Token: 0x04009B5B RID: 39771
			HttpCouldntRenameFile,
			// Token: 0x04009B5C RID: 39772
			HttpCouldntCreateDirectory,
			// Token: 0x04009B5D RID: 39773
			HttpCurlIsNotReady,
			// Token: 0x04009B5E RID: 39774
			HttpCancelled,
			// Token: 0x04009B5F RID: 39775
			HttpFileNotFound = 14404U,
			// Token: 0x04009B60 RID: 39776
			AccountMissingConfig = 18000U,
			// Token: 0x04009B61 RID: 39777
			AccountDataNotFound,
			// Token: 0x04009B62 RID: 39778
			AccountAlreadySubscribed,
			// Token: 0x04009B63 RID: 39779
			AccountNotSubscribed,
			// Token: 0x04009B64 RID: 39780
			AccountFailedToParseTimezoneData,
			// Token: 0x04009B65 RID: 39781
			AccountLoadFailed,
			// Token: 0x04009B66 RID: 39782
			AccountLoadCancelled,
			// Token: 0x04009B67 RID: 39783
			AccountDatabaseInvalidateFailed,
			// Token: 0x04009B68 RID: 39784
			AccountCacheInvalidateFailed,
			// Token: 0x04009B69 RID: 39785
			AccountSubscriptionPending,
			// Token: 0x04009B6A RID: 39786
			AccountUnknownRegion,
			// Token: 0x04009B6B RID: 39787
			AccountDataFailedToParse,
			// Token: 0x04009B6C RID: 39788
			AccountUnderage,
			// Token: 0x04009B6D RID: 39789
			AccountIdentityCheckPending,
			// Token: 0x04009B6E RID: 39790
			AccountIdentityUnverified,
			// Token: 0x04009B6F RID: 39791
			DatabaseBindingCountMismatch = 19000U,
			// Token: 0x04009B70 RID: 39792
			DatabaseBindingParseFail,
			// Token: 0x04009B71 RID: 39793
			DatabaseResultsetColumnsMismatch,
			// Token: 0x04009B72 RID: 39794
			DatabaseDeadlock,
			// Token: 0x04009B73 RID: 39795
			DatabaseDuplicateKey,
			// Token: 0x04009B74 RID: 39796
			DatabaseCannotConnect,
			// Token: 0x04009B75 RID: 39797
			DatabaseStatementFailed,
			// Token: 0x04009B76 RID: 39798
			DatabaseTransactionNotStarted,
			// Token: 0x04009B77 RID: 39799
			DatabaseTransactionNotEnded,
			// Token: 0x04009B78 RID: 39800
			DatabaseTransactionLeak,
			// Token: 0x04009B79 RID: 39801
			DatabaseTransactionStateBad,
			// Token: 0x04009B7A RID: 39802
			DatabaseServerGone,
			// Token: 0x04009B7B RID: 39803
			DatabaseQueryTimeout,
			// Token: 0x04009B7C RID: 39804
			DatabaseBindingNotNullable = 19100U,
			// Token: 0x04009B7D RID: 39805
			DatabaseBindingInvalidInteger,
			// Token: 0x04009B7E RID: 39806
			DatabaseBindingInvalidFloat,
			// Token: 0x04009B7F RID: 39807
			DatabaseBindingInvalidTemporal,
			// Token: 0x04009B80 RID: 39808
			DatabaseBindingInvalidProtobuf,
			// Token: 0x04009B81 RID: 39809
			PartyInvalidPartyId = 20000U,
			// Token: 0x04009B82 RID: 39810
			PartyAlreadyInParty,
			// Token: 0x04009B83 RID: 39811
			PartyNotInParty,
			// Token: 0x04009B84 RID: 39812
			PartyInvitationUndeliverable,
			// Token: 0x04009B85 RID: 39813
			PartyInvitationAlreadyExists,
			// Token: 0x04009B86 RID: 39814
			PartyTooManyPartyInvitations,
			// Token: 0x04009B87 RID: 39815
			PartyTooManyReceivedInvitations,
			// Token: 0x04009B88 RID: 39816
			PartyNoSuchType,
			// Token: 0x04009B89 RID: 39817
			GamesNoSuchFactory = 22000U,
			// Token: 0x04009B8A RID: 39818
			GamesNoSuchGame,
			// Token: 0x04009B8B RID: 39819
			GamesNoSuchRequest,
			// Token: 0x04009B8C RID: 39820
			GamesNoSuchPartyMember,
			// Token: 0x04009B8D RID: 39821
			ResourcesOffline = 23000U,
			// Token: 0x04009B8E RID: 39822
			GameServerCreateGameRefused = 24000U,
			// Token: 0x04009B8F RID: 39823
			GameServerAddPlayersRefused,
			// Token: 0x04009B90 RID: 39824
			GameServerRemovePlayersRefused,
			// Token: 0x04009B91 RID: 39825
			GameServerFinishGameRefused,
			// Token: 0x04009B92 RID: 39826
			GameServerNoSuchGame,
			// Token: 0x04009B93 RID: 39827
			GameServerNoSuchPlayer,
			// Token: 0x04009B94 RID: 39828
			GameServerCreateGameRefusedTransient = 24050U,
			// Token: 0x04009B95 RID: 39829
			GameServerAddPlayersRefusedTransient,
			// Token: 0x04009B96 RID: 39830
			GameServerRemovePlayersRefusedTransient,
			// Token: 0x04009B97 RID: 39831
			GameServerFinishGameRefusedTransient,
			// Token: 0x04009B98 RID: 39832
			GameServerCreateGameRefusedBusy = 24100U,
			// Token: 0x04009B99 RID: 39833
			GameServerAddPlayersRefusedBusy,
			// Token: 0x04009B9A RID: 39834
			GameServerRemovePlayersRefusedBusy,
			// Token: 0x04009B9B RID: 39835
			GameServerFinishGameRefusedBusy,
			// Token: 0x04009B9C RID: 39836
			GameMasterInvalidFactory = 25000U,
			// Token: 0x04009B9D RID: 39837
			GameMasterInvalidGame,
			// Token: 0x04009B9E RID: 39838
			GameMasterGameFull,
			// Token: 0x04009B9F RID: 39839
			GameMasterRegisterFailed,
			// Token: 0x04009BA0 RID: 39840
			GameMasterNoGameServer,
			// Token: 0x04009BA1 RID: 39841
			GameMasterNoUtilityServer,
			// Token: 0x04009BA2 RID: 39842
			GameMasterNoGameVersion,
			// Token: 0x04009BA3 RID: 39843
			GameMasterGameJoinFailed,
			// Token: 0x04009BA4 RID: 39844
			GameMasterAlreadyRegistered,
			// Token: 0x04009BA5 RID: 39845
			GameMasterNoFactory,
			// Token: 0x04009BA6 RID: 39846
			GameMasterMultipleGameVersions,
			// Token: 0x04009BA7 RID: 39847
			GameMasterInvalidPlayer,
			// Token: 0x04009BA8 RID: 39848
			GameMasterInvalidGameRequest,
			// Token: 0x04009BA9 RID: 39849
			GameMasterInsufficientPrivileges,
			// Token: 0x04009BAA RID: 39850
			GameMasterAlreadyInGame,
			// Token: 0x04009BAB RID: 39851
			GameMasterInvalidGameServerResponse,
			// Token: 0x04009BAC RID: 39852
			GameMasterGameAccountLookupFailed,
			// Token: 0x04009BAD RID: 39853
			GameMasterGameEntryCancelled,
			// Token: 0x04009BAE RID: 39854
			GameMasterGameEntryAbortedClientDropped,
			// Token: 0x04009BAF RID: 39855
			GameMasterGameEntryAbortedByService,
			// Token: 0x04009BB0 RID: 39856
			GameMasterNoAvailableCapacity,
			// Token: 0x04009BB1 RID: 39857
			GameMasterInvalidTeamId,
			// Token: 0x04009BB2 RID: 39858
			GameMasterCreationInProgress,
			// Token: 0x04009BB3 RID: 39859
			NotificationInvalidClientId = 26000U,
			// Token: 0x04009BB4 RID: 39860
			NotificationDuplicateName,
			// Token: 0x04009BB5 RID: 39861
			NotificationNameNotFound,
			// Token: 0x04009BB6 RID: 39862
			NotificationInvalidServer,
			// Token: 0x04009BB7 RID: 39863
			NotificationQuotaExceeded,
			// Token: 0x04009BB8 RID: 39864
			NotificationInvalidNotificationType,
			// Token: 0x04009BB9 RID: 39865
			NotificationUndeliverable,
			// Token: 0x04009BBA RID: 39866
			NotificationUndeliverableTemporary,
			// Token: 0x04009BBB RID: 39867
			AchievementsNothingToUpdate = 28000U,
			// Token: 0x04009BBC RID: 39868
			AchievementsInvalidParams,
			// Token: 0x04009BBD RID: 39869
			AchievementsNotRegistered,
			// Token: 0x04009BBE RID: 39870
			AchievementsNotReady,
			// Token: 0x04009BBF RID: 39871
			AchievementsFailedToParseStaticData,
			// Token: 0x04009BC0 RID: 39872
			AchievementsUnknownId,
			// Token: 0x04009BC1 RID: 39873
			AchievementsMissingSnapshot,
			// Token: 0x04009BC2 RID: 39874
			AchievementsAlreadyRegistered,
			// Token: 0x04009BC3 RID: 39875
			AchievementsTooManyRegistrations,
			// Token: 0x04009BC4 RID: 39876
			AchievementsAlreadyInProgress,
			// Token: 0x04009BC5 RID: 39877
			AchievementsTemporaryOutage,
			// Token: 0x04009BC6 RID: 39878
			AchievementsInvalidProgramid,
			// Token: 0x04009BC7 RID: 39879
			AchievementsMissingRecord,
			// Token: 0x04009BC8 RID: 39880
			AchievementsRegistrationPending,
			// Token: 0x04009BC9 RID: 39881
			AchievementsEntityIdNotFound,
			// Token: 0x04009BCA RID: 39882
			AchievementsAchievementIdNotFound,
			// Token: 0x04009BCB RID: 39883
			AchievementsCriteriaIdNotFound,
			// Token: 0x04009BCC RID: 39884
			AchievementsStaticDataMismatch,
			// Token: 0x04009BCD RID: 39885
			AchievementsWrongThread,
			// Token: 0x04009BCE RID: 39886
			AchievementsCallbackIsNull,
			// Token: 0x04009BCF RID: 39887
			AchievementsAutoRegisterPending,
			// Token: 0x04009BD0 RID: 39888
			AchievementsNotInitialized,
			// Token: 0x04009BD1 RID: 39889
			AchievementsAchievementIdAlreadyExists,
			// Token: 0x04009BD2 RID: 39890
			AchievementsFailedToDownloadStaticData,
			// Token: 0x04009BD3 RID: 39891
			AchievementsStaticDataNotFound,
			// Token: 0x04009BD4 RID: 39892
			GameUtilityServerVariableRequestRefused = 34001U,
			// Token: 0x04009BD5 RID: 39893
			GameUtilityServerWrongNumberOfVariablesReturned,
			// Token: 0x04009BD6 RID: 39894
			GameUtilityServerClientRequestRefused,
			// Token: 0x04009BD7 RID: 39895
			GameUtilityServerPresenceChannelCreatedRefused,
			// Token: 0x04009BD8 RID: 39896
			GameUtilityServerVariableRequestRefusedTransient = 34050U,
			// Token: 0x04009BD9 RID: 39897
			GameUtilityServerClientRequestRefusedTransient,
			// Token: 0x04009BDA RID: 39898
			GameUtilityServerPresenceChannelCreatedRefusedTransient,
			// Token: 0x04009BDB RID: 39899
			GameUtilityServerServerRequestRefusedTransient,
			// Token: 0x04009BDC RID: 39900
			GameUtilityServerVariableRequestRefusedBusy = 34100U,
			// Token: 0x04009BDD RID: 39901
			GameUtilityServerClientRequestRefusedBusy,
			// Token: 0x04009BDE RID: 39902
			GameUtilityServerPresenceChannelCreatedRefusedBusy,
			// Token: 0x04009BDF RID: 39903
			GameUtilityServerServerRequestRefusedBusy,
			// Token: 0x04009BE0 RID: 39904
			GameUtilityServerNoServer = 34200U,
			// Token: 0x04009BE1 RID: 39905
			IdentityInsufficientData = 41000U,
			// Token: 0x04009BE2 RID: 39906
			IdentityTooManyResults,
			// Token: 0x04009BE3 RID: 39907
			IdentityBadId,
			// Token: 0x04009BE4 RID: 39908
			IdentityNoAccountBlob,
			// Token: 0x04009BE5 RID: 39909
			RiskChallengeAction = 42000U,
			// Token: 0x04009BE6 RID: 39910
			RiskDelayAction,
			// Token: 0x04009BE7 RID: 39911
			RiskThrottleAction,
			// Token: 0x04009BE8 RID: 39912
			RiskAccountLocked,
			// Token: 0x04009BE9 RID: 39913
			RiskCsDenied,
			// Token: 0x04009BEA RID: 39914
			RiskDisconnectAccount,
			// Token: 0x04009BEB RID: 39915
			RiskCheckSkipped,
			// Token: 0x04009BEC RID: 39916
			ReportUnavailable = 45000U,
			// Token: 0x04009BED RID: 39917
			ReportTooLarge,
			// Token: 0x04009BEE RID: 39918
			ReportUnknownType,
			// Token: 0x04009BEF RID: 39919
			ReportAttributeInvalid,
			// Token: 0x04009BF0 RID: 39920
			ReportAttributeQuotaExceeded,
			// Token: 0x04009BF1 RID: 39921
			ReportUnconfirmed,
			// Token: 0x04009BF2 RID: 39922
			ReportNotConnected,
			// Token: 0x04009BF3 RID: 39923
			ReportRejected,
			// Token: 0x04009BF4 RID: 39924
			ReportTooManyRequests,
			// Token: 0x04009BF5 RID: 39925
			AccountAlreadyRegisterd = 48000U,
			// Token: 0x04009BF6 RID: 39926
			AccountNotRegistered,
			// Token: 0x04009BF7 RID: 39927
			AccountRegistrationPending,
			// Token: 0x04009BF8 RID: 39928
			MemcachedClientNoError = 65536U,
			// Token: 0x04009BF9 RID: 39929
			MemcachedClientKeyNotFound,
			// Token: 0x04009BFA RID: 39930
			MemcachedKeyExists,
			// Token: 0x04009BFB RID: 39931
			MemcachedValueToLarge,
			// Token: 0x04009BFC RID: 39932
			MemcachedInvalidArgs,
			// Token: 0x04009BFD RID: 39933
			MemcachedItemNotStored,
			// Token: 0x04009BFE RID: 39934
			MemcachedNonNumericValue,
			// Token: 0x04009BFF RID: 39935
			MemcachedWrongServer,
			// Token: 0x04009C00 RID: 39936
			MemcachedAuthenticationError,
			// Token: 0x04009C01 RID: 39937
			MemcachedAuthenticationContinue,
			// Token: 0x04009C02 RID: 39938
			MemcachedUnknownCommand,
			// Token: 0x04009C03 RID: 39939
			MemcachedOutOfMemory,
			// Token: 0x04009C04 RID: 39940
			MemcachedNotSupported,
			// Token: 0x04009C05 RID: 39941
			MemcachedInternalError,
			// Token: 0x04009C06 RID: 39942
			MemcachedTemporaryFailure,
			// Token: 0x04009C07 RID: 39943
			MemcachedClientAlreadyConnected = 100000U,
			// Token: 0x04009C08 RID: 39944
			MemcachedClientBadConfig,
			// Token: 0x04009C09 RID: 39945
			MemcachedClientNotConnected,
			// Token: 0x04009C0A RID: 39946
			MemcachedClientTimeout,
			// Token: 0x04009C0B RID: 39947
			MemcachedClientAborted,
			// Token: 0x04009C0C RID: 39948
			UtilServerFailedToSerialize = 2147483748U,
			// Token: 0x04009C0D RID: 39949
			UtilServerDisconnectedFromBattlenet,
			// Token: 0x04009C0E RID: 39950
			UtilServerTimedOut,
			// Token: 0x04009C0F RID: 39951
			UtilServerNoMeteringData,
			// Token: 0x04009C10 RID: 39952
			UtilServerFailPermissionCheck,
			// Token: 0x04009C11 RID: 39953
			UtilServerUnknownRealm,
			// Token: 0x04009C12 RID: 39954
			UtilServerMissingSessionKey,
			// Token: 0x04009C13 RID: 39955
			UtilServerMissingVirtualRealm,
			// Token: 0x04009C14 RID: 39956
			UtilServerInvalidSessionKey,
			// Token: 0x04009C15 RID: 39957
			UtilServerMissingRealmList,
			// Token: 0x04009C16 RID: 39958
			UtilServerInvalidIdentityArgs,
			// Token: 0x04009C17 RID: 39959
			UtilServerSessionObjectMissing,
			// Token: 0x04009C18 RID: 39960
			UtilServerInvalidBnetSession,
			// Token: 0x04009C19 RID: 39961
			UtilServerInvalidVirtualRealm,
			// Token: 0x04009C1A RID: 39962
			UtilServerInvalidClientAddress,
			// Token: 0x04009C1B RID: 39963
			UtilServerFailedToSerializeResponse,
			// Token: 0x04009C1C RID: 39964
			UtilServerUnknownRequest,
			// Token: 0x04009C1D RID: 39965
			UtilServerUnableToGenerateJoinTicket,
			// Token: 0x04009C1E RID: 39966
			UtilServerUnableToGenerateRealmListTicket,
			// Token: 0x04009C1F RID: 39967
			UtilServerAccountDenied,
			// Token: 0x04009C20 RID: 39968
			UtilServerInvalidWowAccount,
			// Token: 0x04009C21 RID: 39969
			UtilServerUnableToStoreSession,
			// Token: 0x04009C22 RID: 39970
			UtilServerSessionAlreadyCreated,
			// Token: 0x04009C23 RID: 39971
			UserServerFailedToSerialize = 2147483848U,
			// Token: 0x04009C24 RID: 39972
			UserServerDisconnectedFromUtil,
			// Token: 0x04009C25 RID: 39973
			UserServerSessionDuplicate,
			// Token: 0x04009C26 RID: 39974
			UserServerFailedToDisableBilling,
			// Token: 0x04009C27 RID: 39975
			UserServerPlayerDisconnected,
			// Token: 0x04009C28 RID: 39976
			UserServerFailedToParseAccountState,
			// Token: 0x04009C29 RID: 39977
			UserServerAccountLoadCancelled,
			// Token: 0x04009C2A RID: 39978
			UserServerBadPlatform,
			// Token: 0x04009C2B RID: 39979
			UserServerBadVirtualRealm,
			// Token: 0x04009C2C RID: 39980
			UserServerLocaleRestricted,
			// Token: 0x04009C2D RID: 39981
			UserServerMissingPropass,
			// Token: 0x04009C2E RID: 39982
			UserServerBadWowAccount,
			// Token: 0x04009C2F RID: 39983
			UserServerBadBnetAccount,
			// Token: 0x04009C30 RID: 39984
			UserServerFailedToParseGameAccountState,
			// Token: 0x04009C31 RID: 39985
			UserServerFailedToParseGameTimeRemaining,
			// Token: 0x04009C32 RID: 39986
			UserServerFailedToParseGameSessionInfo,
			// Token: 0x04009C33 RID: 39987
			UserServerAccountStatePoorlyFormed,
			// Token: 0x04009C34 RID: 39988
			UserServerGameAccountStatePoorlyFormed,
			// Token: 0x04009C35 RID: 39989
			UserServerGameTimeRemainingPoorlyFormed,
			// Token: 0x04009C36 RID: 39990
			UserServerGameSessionInfoPoorlyFormed,
			// Token: 0x04009C37 RID: 39991
			UserServerBadSessionTrackerState,
			// Token: 0x04009C38 RID: 39992
			UserServerFailedToParseCaisInfo,
			// Token: 0x04009C39 RID: 39993
			UserServerGameSessionDisconnected,
			// Token: 0x04009C3A RID: 39994
			UserServerVersionMismatch,
			// Token: 0x04009C3B RID: 39995
			UserServerAccountSuspended,
			// Token: 0x04009C3C RID: 39996
			UserServerNotPermittedOnRealm,
			// Token: 0x04009C3D RID: 39997
			UserServerLoginFailedConnect,
			// Token: 0x04009C3E RID: 39998
			WowServicesTimedOut = 2147483948U,
			// Token: 0x04009C3F RID: 39999
			WowServicesInvalidRealmListTicket,
			// Token: 0x04009C40 RID: 40000
			WowServicesInvalidJoinTicket,
			// Token: 0x04009C41 RID: 40001
			WowServicesInvalidServerAddresses,
			// Token: 0x04009C42 RID: 40002
			WowServicesInvalidSecretBlob,
			// Token: 0x04009C43 RID: 40003
			WowServicesNoRealmJoinIpFound,
			// Token: 0x04009C44 RID: 40004
			WowServicesDeniedRealmListTicket,
			// Token: 0x04009C45 RID: 40005
			WowServicesMissingGameAccount,
			// Token: 0x04009C46 RID: 40006
			WowServicesLogonInvalidAuthToken,
			// Token: 0x04009C47 RID: 40007
			WowServicesNoAvailableRealms,
			// Token: 0x04009C48 RID: 40008
			WowServicesFailedToParseDispatch,
			// Token: 0x04009C49 RID: 40009
			WowServicesMissingMeteringFile,
			// Token: 0x04009C4A RID: 40010
			WowServicesLoginInvalidContentType,
			// Token: 0x04009C4B RID: 40011
			WowServicesLoginUnableToDecode,
			// Token: 0x04009C4C RID: 40012
			WowServicesLoginPostError,
			// Token: 0x04009C4D RID: 40013
			WowServicesAuthenticatorParseFailed,
			// Token: 0x04009C4E RID: 40014
			WowServicesLegalParseFailed,
			// Token: 0x04009C4F RID: 40015
			WowServicesLoginAuthenticationParseFailed,
			// Token: 0x04009C50 RID: 40016
			WowSerivcesUserMustAcceptLegal,
			// Token: 0x04009C51 RID: 40017
			WowServicesDisconnected,
			// Token: 0x04009C52 RID: 40018
			WowServicesNoHandlerForDispatch,
			// Token: 0x04009C53 RID: 40019
			WowServicesPreDispatchHandlerFailed,
			// Token: 0x04009C54 RID: 40020
			WowServicesCriticalStreamingError,
			// Token: 0x04009C55 RID: 40021
			WowServicesWorldLoadError,
			// Token: 0x04009C56 RID: 40022
			WowServicesLoginFailed,
			// Token: 0x04009C57 RID: 40023
			WowServicesLoginFailedOnChallenge,
			// Token: 0x04009C58 RID: 40024
			WowServicesNoPrepaidTime,
			// Token: 0x04009C59 RID: 40025
			WowServicesSubscriptionExpired,
			// Token: 0x04009C5A RID: 40026
			WowServicesCantConnect
		}
	}
}
