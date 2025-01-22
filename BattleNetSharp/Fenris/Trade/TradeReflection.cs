using System;
using Fenris.Items;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x02000106 RID: 262
	public static class TradeReflection
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00058A94 File Offset: 0x00056C94
		public static FileDescriptor Descriptor
		{
			get
			{
				return TradeReflection.descriptor;
			}
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00058AAC File Offset: 0x00056CAC
		static TradeReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgtUcmFkZS5wcm90bxIMRmVucmlzLlRyYWRlGgtJdGVtcy5wcm90byJRCgZU", "cmFkZXISDwoHaGVyb19pZBgDIAEoCRIZCg9nYW1lX2FjY291bnRfaWQYASAB", "KA1IABIRCgdjbGFuX2lkGAIgASgJSABCCAoGdHJhZGVyIssBCgpFc2Nyb3dJ", "bmZvEhIKCnN0YXJ0ZWRfYXQYASABKAQSDQoFc3RhdGUYAiABKA0SGgoSaXRl", "bV9pZHNfdG9fZXNjcm93GAMgAygJEhsKE2JhbmtfdGFiX3RvX3Jlc2VydmUY", "BCABKAUSHQoVYmFua19zbG90c190b19yZXNlcnZlGAUgASgNEi0KJXJlc2Vy", "dmVfYmFua190YWJfdG9fcHVyY2hhc2VfYXRfcHJpY2UYCCABKAQSEwoLdHJh", "ZGVyX3NpZGUYBiABKA0iSgoJVHJhZGVJdGVtEisKCnNhdmVkX2l0ZW0YASAB", "KAsyFy5GZW5yaXMuSXRlbXMuU2F2ZWRJdGVtEhAKCHF1YW50aXR5GAIgASgE", "IsEDCglUcmFkZUluZm8SEgoKc3RhcnRlZF9hdBgBIAEoBBImCgh0cmFkZXJf",
				"MRgCIAEoCzIULkZlbnJpcy5UcmFkZS5UcmFkZXISJgoIdHJhZGVyXzIYAyAB", "KAsyFC5GZW5yaXMuVHJhZGUuVHJhZGVyEjEKEGl0ZW1zX3RvX3RyYWRlXzEY", "BCADKAsyFy5GZW5yaXMuVHJhZGUuVHJhZGVJdGVtEjEKEGl0ZW1zX3RvX3Ry", "YWRlXzIYBSADKAsyFy5GZW5yaXMuVHJhZGUuVHJhZGVJdGVtEjkKFWN1cnJl", "bmNpZXNfdG9fdHJhZGVfMRgGIAMoCzIaLkZlbnJpcy5JdGVtcy5DdXJyZW5j", "eURhdGESOQoVY3VycmVuY2llc190b190cmFkZV8yGAcgAygLMhouRmVucmlz", "Lkl0ZW1zLkN1cnJlbmN5RGF0YRIiChpiYW5rX3RhYl90b19hZGRfaXRlbXNf", "aW50bxgJIAEoBRIiChpwdXJjaGFzZV9iYW5rX3RhYl9hdF9wcmljZRgMIAEo", "BBIVCg10cmFkZV9zdGF0ZV8xGAogASgNEhUKDXRyYWRlX3N0YXRlXzIYCyAB", "KA0ieQoJVHJhZGVEYXRhEhAKCHRyYWRlX2lkGAEgASgJEi0KC2VzY3Jvd19p",
				"bmZvGAIgASgLMhguRmVucmlzLlRyYWRlLkVzY3Jvd0luZm8SKwoKdHJhZGVf", "aW5mbxgDIAEoCzIXLkZlbnJpcy5UcmFkZS5UcmFkZUluZm8iOAoJU2F2ZWRE", "YXRhEisKCnRyYWRlX2RhdGEYASADKAsyFy5GZW5yaXMuVHJhZGUuVHJhZGVE", "YXRh"
			}));
			TradeReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ItemsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Trader), Trader.Parser, new string[] { "HeroId", "GameAccountId", "ClanId" }, new string[] { "Trader" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EscrowInfo), EscrowInfo.Parser, new string[] { "StartedAt", "State", "ItemIdsToEscrow", "BankTabToReserve", "BankSlotsToReserve", "ReserveBankTabToPurchaseAtPrice", "TraderSide" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TradeItem), TradeItem.Parser, new string[] { "SavedItem", "Quantity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TradeInfo), TradeInfo.Parser, new string[]
				{
					"StartedAt", "Trader1", "Trader2", "ItemsToTrade1", "ItemsToTrade2", "CurrenciesToTrade1", "CurrenciesToTrade2", "BankTabToAddItemsInto", "PurchaseBankTabAtPrice", "TradeState1",
					"TradeState2"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TradeData), TradeData.Parser, new string[] { "TradeId", "EscrowInfo", "TradeInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedData), SavedData.Parser, new string[] { "TradeData" }, null, null, null, null)
			}));
		}

		// Token: 0x040009E8 RID: 2536
		private static FileDescriptor descriptor;
	}
}
