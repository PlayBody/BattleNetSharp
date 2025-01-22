using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2Map;
using D2Packets.Game.Server;
using DiabloBridge;
using Newtonsoft.Json;
using Utilities;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1A RID: 2842
	public class Autoplay : IDisposable
	{
		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600BF2C RID: 48940 RVA: 0x004999EC File Offset: 0x00497BEC
		public string Status
		{
			get
			{
				try
				{
					return string.Concat(new string[]
					{
						this.c.me.Life.ToString(),
						" / ",
						(this.c.me.Attributes[StatType.MaxLife] >> 8).ToString(),
						", ",
						this.c.me.Mana.ToString(),
						" / ",
						(this.c.me.Attributes[StatType.MaxMana] >> 8).ToString(),
						", ",
						this.c.me.Attributes[StatType.Experience].ToString(),
						", ",
						this.c.GetCurrentLevel().ToString(),
						" : ",
						this.c.me.X.ToString(),
						", ",
						this.c.me.Y.ToString()
					});
				}
				catch
				{
				}
				return "starting";
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600BF2D RID: 48941 RVA: 0x00499B58 File Offset: 0x00497D58
		public string Surroundings
		{
			get
			{
				int range = 60;
				string[,] array = new string[range, range];
				Level level = this.c.GameInstance.LevelData[this.c.GetCurrentLevel()];
				for (int i = -range / 2; i < range / 2; i++)
				{
					for (int j = -range / 2; j < range / 2; j++)
					{
						string text = (level.IsWall((uint)((int)this.c.me.X + j), (uint)((int)this.c.me.Y + i)) ? "*" : " ");
						bool flag = j == 0 && i == 0;
						if (flag)
						{
							text = "M";
						}
						array[j + range / 2, i + range / 2] = text;
					}
				}
				IEnumerable<KeyValuePair<uint, AssignNPC>> enumerable = this.c.GameInstance.NPCs.Where((KeyValuePair<uint, AssignNPC> c2) => c2.Value.Life > 0 && Helpers.GetDistance(this.c.me.X, this.c.me.Y, c2.Value.X, c2.Value.Y) < (float)range);
				foreach (KeyValuePair<uint, AssignNPC> keyValuePair in enumerable)
				{
					int num = (int)(keyValuePair.Value.X - this.c.me.X) + range / 2;
					int num2 = (int)(keyValuePair.Value.Y - this.c.me.Y) + range / 2;
					bool flag2 = num < range && num2 < range && num > 0 && num2 > 0;
					if (flag2)
					{
						array[num, num2] = "X";
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				for (int k = 0; k < range; k++)
				{
					for (int l = range - 1; l >= 0; l--)
					{
						stringBuilder.Append(array[k, l]);
					}
					stringBuilder.Append("\n");
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x00499DD8 File Offset: 0x00497FD8
		public void DrawSurroundings()
		{
			this.gfx.DrawRectangle(Pens.Red, 0, 0, 100, 100);
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x00499DF4 File Offset: 0x00497FF4
		public string CompleteStatus
		{
			get
			{
				try
				{
					string status = this.Status;
					string text = "";
					IEnumerable<ItemAction> enumerable = this.c.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId != 0U || ((i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt) && i.action != ItemActionType.RemoveFromBelt));
					enumerable = from i in enumerable
						orderby i.location, i.container, i.x, i.y
						select i;
					foreach (ItemAction itemAction in enumerable)
					{
						string[] array = new string[11];
						array[0] = text;
						array[1] = "\n";
						array[2] = itemAction.x.ToString();
						array[3] = ", ";
						array[4] = itemAction.y.ToString();
						array[5] = ", ";
						array[6] = itemAction.location.ToString();
						array[7] = ", ";
						array[8] = itemAction.container.ToString();
						array[9] = " : ";
						int num = 10;
						ItemAction itemAction2 = itemAction;
						array[num] = ((itemAction2 != null) ? itemAction2.ToString() : null);
						text = string.Concat(array);
					}
					return status + "\n" + this.Surroundings + "\n";
				}
				catch
				{
				}
				return "starting";
			}
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x0049A000 File Offset: 0x00498200
		public static string GenName()
		{
			string text = Autoplay.Part1.OrderBy((string s) => Guid.NewGuid()).First<string>() + Autoplay.Part2.OrderBy((string s) => Guid.NewGuid()).First<string>() + Autoplay.Part3.OrderBy((string s) => Guid.NewGuid()).First<string>();
			bool flag = text.Length > 14;
			if (flag)
			{
				text = text.Substring(0, 14);
			}
			return text;
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x0049A0BC File Offset: 0x004982BC
		public Autoplay(string acc)
		{
			Autoplay.Autoplays.Add(acc, this);
			string text = File.ReadAllText("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\accounts\\" + acc);
			this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x0049A140 File Offset: 0x00498340
		public static Autoplay Start(string acc)
		{
			Autoplay autoplay = new Autoplay(acc);
			Task.Run(new Action(autoplay.Behavior));
			return autoplay;
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x0049A16C File Offset: 0x0049836C
		public void Behavior()
		{
			try
			{
				this.d2.BGSLoginLocked("us", this.Account.BNetToken, this.Account.D2Account, D2RBGS.App.D2R);
				string text = "a" + Guid.NewGuid().ToString().ToLower()
					.Substring(0, 8);
				this.d2.RealmLoginLocked(true);
				List<CharData> list = this.d2.ReadCharacters();
				foreach (CharData charData in list)
				{
					D2RCharData d2RCharData = JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8());
					bool flag = d2RCharData.charflags.HasFlag(CharDataFlags.Ladder);
					if (flag)
					{
						this.CharId = charData.Id;
					}
					this.Level = (uint)d2RCharData.level;
				}
				bool flag2 = this.CharId == 0U;
				if (flag2)
				{
					return;
				}
				bool flag3 = this.d2.CreateGame(text, "password", this.CharId, 0U, this.Level, true, "USW4");
				GameJoinResponse gameJoinResponse = this.d2.JoinGame(text, "password", this.CharId, this.Level, "");
				Console.WriteLine(text);
				bool flag4 = gameJoinResponse == null || gameJoinResponse.Port == 0U;
				if (flag4)
				{
					throw new Exception("game join fail");
				}
				this.c = new Game();
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.final.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.merc-final.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.sorc.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.merc.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.misc.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.charms.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\ap.runewords.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\charms.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\LATE.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\magic.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\rare.nip");
				this.c.AddPickit("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\Autoplay\\d2bs\\kolbot\\pickit\\White.nip");
				this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
				this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
				this.c.Behavior = delegate
				{
					this.c.EnableLifeManagement();
					this.c.EnableFastPickIt();
					this.c.EnableBuildManagement();
					this.c.TownDoChores();
					this.c.LowerKurastChests(WaypointsAvailable.ThePandemoniumFortress);
					while (this.c.HandlePackets)
					{
						Thread.Sleep(1000);
					}
					this.c.Terminate();
				};
				D2RBGS d2RBGS = this.d2;
				if (d2RBGS != null)
				{
					d2RBGS.Close();
				}
				while (this.c.HandlePackets)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("some autoplay error : " + ex.Message);
				this.d2.Close();
			}
			this.Dispose();
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x0049A55C File Offset: 0x0049875C
		public void Dispose()
		{
			Autoplay.Autoplays.Remove(this.Account.BNetEmail);
			Game game = this.c;
			if (game != null)
			{
				game.Terminate();
			}
			D2RBGS d2RBGS = this.d2;
			if (d2RBGS != null)
			{
				d2RBGS.Close();
			}
		}

		// Token: 0x040091D2 RID: 37330
		public static Dictionary<string, Autoplay> Autoplays = new Dictionary<string, Autoplay>();

		// Token: 0x040091D3 RID: 37331
		public AccountLink Account = new AccountLink();

		// Token: 0x040091D4 RID: 37332
		public Autoplay.CharState State;

		// Token: 0x040091D5 RID: 37333
		public static string[] Part1 = new string[]
		{
			"Strum", "Halo", "Car", "Heva", "Men", "Gre", "Deca", "Evi", "Hideo", "Sli",
			"Quici", "Sly", "Miser", "Ard", "Alf", "Fiz", "Risa", "Warran", "Kel", "Wren",
			"Kan", "Can", "Gy", "Dero", "Ak", "Dall", "Dell", "Mil", "Ward", "Bra",
			"Bro", "Gi", "Demo", "Cla", "Clai", "Hee", "Crio", "Die", "Deno", "Con",
			"Wolf", "Zar", "Zer", "War", "Nar", "Thay"
		};

		// Token: 0x040091D6 RID: 37334
		public static string[] Part2 = new string[]
		{
			"bright", "gold", "burnd", "del", "gor", "terous", "nton", "slip", "pask", "ck",
			"plone", "plast", "nturous", "bald", "ban", "buck", "tor", "van", "gax", "trandor",
			"thuri", "ben", "baldar", "may", "lam", "mor", "dard", "burg", "whit", "lax",
			"ndor", "ton", "seus", "zzt", "borne", "nan", "run"
		};

		// Token: 0x040091D7 RID: 37335
		public static string[] Part3 = new string[]
		{
			"", "", "", "", "", "", "", "", "", "llyn",
			"a", "in", "lene", "endra", "rin", "iana", "andra", "ia"
		};

		// Token: 0x040091D8 RID: 37336
		public uint CharId = 0U;

		// Token: 0x040091D9 RID: 37337
		public uint Level = 0U;

		// Token: 0x040091DA RID: 37338
		public string RealmServer = "1a";

		// Token: 0x040091DB RID: 37339
		public D2RBGS d2 = new D2RBGS();

		// Token: 0x040091DC RID: 37340
		public Game c;

		// Token: 0x040091DD RID: 37341
		private Graphics gfx = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);

		// Token: 0x02001426 RID: 5158
		public class CharState
		{
			// Token: 0x0400A1BA RID: 41402
			public uint Gold;
		}
	}
}
