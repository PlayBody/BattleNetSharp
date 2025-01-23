using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using D2Packets;
using D2Packets.Game.Server;
using Microsoft.EntityFrameworkCore;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B22 RID: 2850
	public static class ItemDb
	{
		// Token: 0x0600C009 RID: 49161 RVA: 0x004A1F6E File Offset: 0x004A016E
		static ItemDb()
		{
			ItemDb.db.Database.EnsureCreated();
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x004A1F98 File Offset: 0x004A0198
		public static void AddItem(string account, string character, ItemAction add)
		{
			string b = Convert.ToBase64String(add.Bytes.ToArray<byte>());
			new Task(delegate
			{
				string[] array = new string[9];
				array[0] = account;
				array[1] = ":";
				array[2] = character;
				array[3] = ":";
				int num = 4;
				int container = (int)add.container;
				array[num] = container.ToString();
				array[5] = ":";
				array[6] = add.x.ToString();
				array[7] = ":";
				array[8] = add.y.ToString();
				string text = string.Concat(array);
				object lockObj = ItemDb.LockObj;
				lock (lockObj)
				{
					Item item = ItemDb.db.Items.Find(new object[] { text });
					bool flag2 = item == null;
					if (flag2)
					{
						ItemDb.db.Items.Add(new Item
						{
							KeyInfo = text,
							Packet = b
						});
						ItemDb.db.SaveChanges();
					}
				}
			}).Start();
		}

		// Token: 0x0600C00B RID: 49163 RVA: 0x004A1FF4 File Offset: 0x004A01F4
		public static void DeleteStashItem(string account, string character, uint x, uint y)
		{
			new Task(delegate
			{
				string text = string.Concat(new string[]
				{
					account,
					":",
					character,
					":",
					5.ToString(),
					":",
					x.ToString(),
					":",
					y.ToString()
				});
				object lockObj = ItemDb.LockObj;
				lock (lockObj)
				{
					Item item = ItemDb.db.Items.Find(new object[] { text });
					bool flag2 = item != null;
					if (flag2)
					{
						ItemDb.db.Items.Remove(item);
						ItemDb.db.SaveChanges();
					}
				}
			}).Start();
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x004A203C File Offset: 0x004A023C
		public static void DeleteItem(string account, string character, ItemAction add)
		{
			new Task(delegate
			{
				string[] array = new string[9];
				array[0] = account;
				array[1] = ":";
				array[2] = character;
				array[3] = ":";
				int num = 4;
				int container = (int)add.container;
				array[num] = container.ToString();
				array[5] = ":";
				array[6] = add.x.ToString();
				array[7] = ":";
				array[8] = add.y.ToString();
				string text = string.Concat(array);
				object lockObj = ItemDb.LockObj;
				lock (lockObj)
				{
					Item item = ItemDb.db.Items.Find(new object[] { text });
					bool flag2 = item != null;
					if (flag2)
					{
						ItemDb.db.Items.Remove(item);
						ItemDb.db.SaveChanges();
					}
				}
			}).Start();
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x004A207C File Offset: 0x004A027C
		public static DbSet<Item> AllItems()
		{
			object lockObj = ItemDb.LockObj;
			DbSet<Item> items;
			lock (lockObj)
			{
				items = ItemDb.db.Items;
			}
			return items;
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x004A20C4 File Offset: 0x004A02C4
		public static void ClearItems()
		{
			object lockObj = ItemDb.LockObj;
			lock (lockObj)
			{
				ItemDb.db.Items.RemoveRange(ItemDb.db.Items);
			}
		}

		// Token: 0x0600C00F RID: 49167 RVA: 0x004A211C File Offset: 0x004A031C
		public static List<OwnedItemAction> AllItems2()
		{
			object lockObj = ItemDb.LockObj;
			List<OwnedItemAction> list = new List<OwnedItemAction>();
			lock (lockObj)
			{
				ParameterExpression parameterExpression;
// [Ares] Removed, it seems like to build item list from Packet's string
//				list = ItemDb.db.Items.Select(Expression.Lambda<Func<Item, OwnedItemAction>>(Expression.MemberInit(Expression.New(typeof(OwnedItemAction)), new MemberBinding[] { Expression.Bind(methodof(Packet.set_Bytes(IEnumerable<byte>)), Expression.Call(null, methodof(Convert.FromBase64String(string)), new Expression[] { Expression.Property(parameterExpression, methodof(Item.get_Packet())) })) }), new ParameterExpression[] { parameterExpression })).ToList<OwnedItemAction>();
			}
			return list;
		}

		// Token: 0x04009253 RID: 37459
		private static ItemDbContext db = new ItemDbContext();

		// Token: 0x04009254 RID: 37460
		private static object LockObj = new object();
	}
}
