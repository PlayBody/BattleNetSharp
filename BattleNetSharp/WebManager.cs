using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using BattleNetSharp.D2.Resurrected;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2Packets;
using D2Packets.Game.Server;
using DiabloBridge;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BattleNetSharp
{
	// Token: 0x02000AD3 RID: 2771
	public class WebManager
	{
		// Token: 0x0600BC70 RID: 48240 RVA: 0x0047C8CC File Offset: 0x0047AACC
		public static void PostDiscord(string message)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("username", "sorceress");
			dictionary.Add("avatar_url", "https://cdn.iconscout.com/icon/free/png-256/sorceress-904200.png");
			dictionary.Add("content", message);
			WebManager.HttpClient.PostAsync("https://discord.com/api/webhooks/1029513282727460884/9NFpGoTzxZ1rLCS1WFl1I-3cBUmBUVb3TJFJacyQ0749V6obtoIwEo5bAPIunm17TszP", new FormUrlEncodedContent(dictionary));
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x0047C928 File Offset: 0x0047AB28
		public static string ExternalIpAddr
		{
			get
			{
				bool flag = WebManager.externalIpAddr != "";
				string text;
				if (flag)
				{
					text = WebManager.externalIpAddr;
				}
				else
				{
					string text2 = WebManager.externalIpAddr;
					lock (text2)
					{
						bool flag3 = WebManager.externalIpAddr != "";
						if (flag3)
						{
							return WebManager.externalIpAddr;
						}
						WebManager.externalIpAddr = WebManager.HttpClient.GetStringAsync("http://ipv4.icanhazip.com").Result.Replace("\\r\\n", "").Replace("\\n", "").Trim();
						Console.WriteLine("found external ip : " + WebManager.externalIpAddr);
					}
					text = WebManager.externalIpAddr;
				}
				return text;
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600BC72 RID: 48242 RVA: 0x0047C9FC File Offset: 0x0047ABFC
		private static string itemRowHtml
		{
			get
			{
				return File.ReadAllText("Network\\Html\\itemRow.html");
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600BC73 RID: 48243 RVA: 0x0047CA08 File Offset: 0x0047AC08
		private static string itemTableHtml
		{
			get
			{
				return File.ReadAllText("Network\\Html\\itemTable.html");
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600BC74 RID: 48244 RVA: 0x0047CA14 File Offset: 0x0047AC14
		private static string accountRowHtml
		{
			get
			{
				return File.ReadAllText("Network\\Html\\accountRow.html");
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x0047CA20 File Offset: 0x0047AC20
		private static string accountTableHtml
		{
			get
			{
				return File.ReadAllText("Network\\Html\\accountTable.html");
			}
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x0047CA2C File Offset: 0x0047AC2C
		private static JObject D2Bot(string host, string session, string profile, string func, string[] args)
		{
			return JsonConvert.DeserializeObject<JObject>(Encoding.UTF8.GetString(Convert.FromBase64String(WebManager.HttpClient.PostAsync("http://" + host + ":8080/stuff", new StringContent(Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { profile, session, func, args }))), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result)));
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x0047CAB0 File Offset: 0x0047ACB0
		private static JObject D2Bot(string host, string func, string[] args)
		{
			JObject jobject;
			try
			{
				string text = AES.Encrypt(WebManager.D2Bot(host, "null", "test", "challenge", new string[0])["body"].ToString(), "test");
				jobject = WebManager.D2Bot(host, text, "test", func, args);
			}
			catch
			{
				jobject = null;
			}
			return jobject;
		}

        // Token: 0x0600BC78 RID: 48248 RVA: 0x0047CB1C File Offset: 0x0047AD1C
        public static void Start()
        {
            WebManager.HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://*:5123/");

            try
            {
                httpListener.Start();
                Console.WriteLine("Web server started");
            }
            catch
            {
                Console.WriteLine("Web server failed to start, admin permissions required?");
                return;
            }

            while (true)
            {
                WebManager.sem.WaitOne();

                try
                {
                    httpListener.GetContextAsync().ContinueWith(async task =>
                    {
                        WebManager.sem.Release();
                        var context = await task;

                        var request = context.Request;
                        var response = context.Response;

                        try
                        {
                            Console.WriteLine($"{request.RawUrl} : {request.RemoteEndPoint}");

                            string url = request.RawUrl;
                            if (request.HttpMethod == "POST")
                            {
                                using (Stream body = request.InputStream)
                                using (StreamReader reader = new StreamReader(body, request.ContentEncoding))
                                {
                                    string requestData = reader.ReadToEnd();

                                    if (url == "/drop")
                                    {
                                        var req = HttpUtility.ParseQueryString(requestData);
                                        string accountEmail = req["itemId"].Split(':')[0];
                                        string gameName = req["gameName"];
                                        int location = 0;
                                        uint x = uint.Parse(req["itemId"].Split(':')[3]);
                                        uint y = uint.Parse(req["itemId"].Split(':')[4]);

                                        while (Dropper.Droppers.Any(d => d.Account.BNetEmail == accountEmail))
                                        {
                                            Thread.Sleep(1000);
                                        }

                                        Server.BlockAccount(accountEmail);
                                        Dropper.Start(accountEmail.Split('@')[0], gameName, location, x, y, () =>
                                        {
                                            Server.UnblockAccount(accountEmail);
                                        }, 0);
                                    }
                                    else if (url == "/hunters")
                                    {
                                        var req = HttpUtility.ParseQueryString(requestData);
                                        string method = req["method"];

                                        if (method == "startall")
                                        {
                                            int delay = 0;
                                            Directory.GetFiles("hunters")
                                                .Select(file => file.Replace("hunters\\", ""))
                                                .ToList()
                                                .ForEach(profile => Hunter.Start(profile, null, delay++ * 5000));
                                        }
                                        else if (method == "start")
                                        {
                                            string profile = req["profile"];
                                            if (!Hunter.Hunters.Values.Any(h => h.Account.D2Account == profile))
                                            {
                                                Hunter.Start(profile, null, 0);
                                            }
                                        }
                                        else if (method == "stopall")
                                        {
                                            Process.Start("BattleNetSharp");
                                        }
                                        else if (method == "stop")
                                        {
                                            string profile = req["profile"];
                                            Hunter.Hunters.Values
                                                .Where(h => h.Account.D2Account == profile)
                                                .ToList()
                                                .ForEach(h => h.Dispose());
                                        }
                                    }
                                    else if (url == "/updateip")
                                    {
                                        string ip = requestData.Substring(3);
                                        WebManager.Region = ip.StartsWith("us") ? "us" : ip.StartsWith("eu") ? "eu" : ip.StartsWith("kr") ? "kr" : WebManager.Region;
                                        WebManager.SubRegion = ip.StartsWith("us") ? "LAS1" : ip.StartsWith("eu") ? "AMS1" : ip.StartsWith("kr") ? "AZS1" : ip;
                                        WebManager.Ip = ip;
                                    }
                                }
                            }
                            else
                            {
                                string[] urlComponents = url.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                                if (urlComponents.Length == 1)
                                {
                                    if (urlComponents[0] == "list2")
                                    {
                                        FileInfo[] accounts = new DirectoryInfo("accounts").GetFiles();
                                        string accountRows = string.Join("", accounts.Select(i => WebManager.accountRowHtml.Replace("{account}", i.Name).Replace("{status}", Autoplay.Autoplays.ContainsKey(i.Name) ? Autoplay.Autoplays[i.Name].CompleteStatus : "null")));
                                        string accountList = WebManager.accountTableHtml.Replace("{accountRows}", accountRows);
                                        byte[] buffer = Encoding.UTF8.GetBytes(accountList);
                                        response.AddHeader("Content-Encoding", "gzip");
                                        using (MemoryStream varByteStream = new MemoryStream(buffer))
                                        using (GZipStream refGZipStream = new GZipStream(response.OutputStream, CompressionMode.Compress, false))
                                        {
                                            varByteStream.CopyTo(refGZipStream);
                                        }
                                    }
                                    else if (urlComponents[0].Contains("d2bot"))
                                    {
                                        List<JToken> profiles = JsonConvert.DeserializeObject<JArray>(WebManager.D2Bot("127.0.0.1", "profiles", new string[0])["body"].ToString()).ToList();
                                        string accountList = "<table>" + string.Join("", profiles.Select(p => $"<tr><td>{p["Name"]}</td><td>{p["Account"]}</td><td>{p["Character"]}</td><td>{p["Status"]}</td><td><button onclick=\"$.post('d2bot', {{ method: 'start', profile: '{p["Name"]}' }}, function (res){{}})\">Start</button><button onclick=\"$.post('d2bot', {{ method: 'stop', profile: '{p["Name"]}' }}, function (res){{}})\">Stop</button></td></tr>")) + "</table>";
                                        string responseString = $"<html><script type=\"text/javascript\" src=\"https://code.jquery.com/jquery-1.7.1.min.js\"></script><button onclick=\"$.post('d2bot', {{ method: 'startall' }}, function (res){{}})\">Start All</button><br><button onclick=\"$.post('d2bot', {{ method: 'stopall' }}, function (res){{}})\">Stop All</button><br><body>{accountList}</body></html>";
                                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                                        response.OutputStream.Write(buffer, 0, buffer.Length);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error processing request: {ex.Message}");
                        }
                        finally
                        {
                            response.OutputStream.Close();
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in web server: {ex.Message}");
                }
            }
        }

        // Token: 0x0400913E RID: 37182
        public static readonly HttpClient HttpClient = new HttpClient();

		// Token: 0x0400913F RID: 37183
		private static string externalIpAddr = "";

		// Token: 0x04009140 RID: 37184
		private static List<GameInfo> games = new List<GameInfo>();

		// Token: 0x04009141 RID: 37185
		private static Semaphore sem = new Semaphore(16, 16);

		// Token: 0x04009142 RID: 37186
		public static string Region = "us";

		// Token: 0x04009143 RID: 37187
		public static string SubRegion = "USE2";

		// Token: 0x04009144 RID: 37188
		public static string Ip = "158.x.x.x";

		// Token: 0x04009145 RID: 37189
		public static List<string> LinkedServers = new List<string>();

		// Token: 0x020013B2 RID: 5042
		public class ProfileMessage
		{
			// Token: 0x1700397C RID: 14716
			// (get) Token: 0x0600E076 RID: 57462 RVA: 0x004C7A4E File Offset: 0x004C5C4E
			// (set) Token: 0x0600E077 RID: 57463 RVA: 0x004C7A56 File Offset: 0x004C5C56
			public string session { get; set; }

			// Token: 0x1700397D RID: 14717
			// (get) Token: 0x0600E078 RID: 57464 RVA: 0x004C7A5F File Offset: 0x004C5C5F
			// (set) Token: 0x0600E079 RID: 57465 RVA: 0x004C7A67 File Offset: 0x004C5C67
			public string profile { get; set; }

			// Token: 0x1700397E RID: 14718
			// (get) Token: 0x0600E07A RID: 57466 RVA: 0x004C7A70 File Offset: 0x004C5C70
			// (set) Token: 0x0600E07B RID: 57467 RVA: 0x004C7A78 File Offset: 0x004C5C78
			public string func { get; set; }

			// Token: 0x1700397F RID: 14719
			// (get) Token: 0x0600E07C RID: 57468 RVA: 0x004C7A81 File Offset: 0x004C5C81
			// (set) Token: 0x0600E07D RID: 57469 RVA: 0x004C7A89 File Offset: 0x004C5C89
			public string[] args { get; set; }
		}

		// Token: 0x020013B3 RID: 5043
		public class Item
		{
			// Token: 0x17003980 RID: 14720
			// (get) Token: 0x0600E07F RID: 57471 RVA: 0x004C7A9B File Offset: 0x004C5C9B
			// (set) Token: 0x0600E080 RID: 57472 RVA: 0x004C7AA3 File Offset: 0x004C5CA3
			public string itemColor { get; set; }

			// Token: 0x17003981 RID: 14721
			// (get) Token: 0x0600E081 RID: 57473 RVA: 0x004C7AAC File Offset: 0x004C5CAC
			// (set) Token: 0x0600E082 RID: 57474 RVA: 0x004C7AB4 File Offset: 0x004C5CB4
			public string image { get; set; }

			// Token: 0x17003982 RID: 14722
			// (get) Token: 0x0600E083 RID: 57475 RVA: 0x004C7ABD File Offset: 0x004C5CBD
			// (set) Token: 0x0600E084 RID: 57476 RVA: 0x004C7AC5 File Offset: 0x004C5CC5
			public string title { get; set; }

			// Token: 0x17003983 RID: 14723
			// (get) Token: 0x0600E085 RID: 57477 RVA: 0x004C7ACE File Offset: 0x004C5CCE
			// (set) Token: 0x0600E086 RID: 57478 RVA: 0x004C7AD6 File Offset: 0x004C5CD6
			public string description { get; set; }

			// Token: 0x17003984 RID: 14724
			// (get) Token: 0x0600E087 RID: 57479 RVA: 0x004C7ADF File Offset: 0x004C5CDF
			// (set) Token: 0x0600E088 RID: 57480 RVA: 0x004C7AE7 File Offset: 0x004C5CE7
			public string header { get; set; }

			// Token: 0x17003985 RID: 14725
			// (get) Token: 0x0600E089 RID: 57481 RVA: 0x004C7AF0 File Offset: 0x004C5CF0
			// (set) Token: 0x0600E08A RID: 57482 RVA: 0x004C7AF8 File Offset: 0x004C5CF8
			public List<string> sockets { get; set; }

			// Token: 0x0600E08B RID: 57483 RVA: 0x004C7B04 File Offset: 0x004C5D04
			public static WebManager.Item FromPacket(ItemAction item, string key)
			{
				byte[] array = item.ToArray();
				ItemAction itemAction = new ItemAction();
				itemAction.D2R_2_5 = item.D2R_2_5;
				itemAction.Bytes = array;
				WebManager.Item item2 = new WebManager.Item();
				item2.backedItem = item;
				item2.title = item.GetTitle();
				item2.description = string.Join("<br>", (from s in item.stats
					where s.BaseStat.Type != StatType.Durability && s.BaseStat.Type != StatType.MaxDurability
					select s into m
					select m.ToString()).Concat(item.mods.Select((StatBase m) => m.ToString())));
				item2.header = key;
				return item2;
			}

			// Token: 0x04009FF3 RID: 40947
			public ItemAction backedItem;
		}
	}
}
