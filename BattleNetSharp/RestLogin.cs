using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BattleNetSharp
{
	// Token: 0x02000AD0 RID: 2768
	public class RestLogin
	{
		// Token: 0x0600BC67 RID: 48231 RVA: 0x0047B060 File Offset: 0x00479260
		public string NetRequest(string url, string json = "")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.CookieContainer = new CookieContainer();
			httpWebRequest.UserAgent = "Mozilla/4.0";
			httpWebRequest.Accept = "application/json;charset=utf-8";
			bool flag = this.JSession != "";
			if (flag)
			{
				httpWebRequest.CookieContainer.Add(new Cookie("JSESSIONID", this.JSession)
				{
					Domain = "us.battle.net"
				});
			}
			bool flag2 = json != "";
			if (flag2)
			{
				httpWebRequest.Headers.Add("Device-Id", DeviceId.Json);
				httpWebRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(json);
				bool flag3 = json.Contains("{");
				if (flag3)
				{
					httpWebRequest.ContentType = "application/json;charset=utf-8";
				}
				else
				{
					httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				}
				httpWebRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
			}
			string text;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream))
					{
						Cookie cookie = httpWebResponse.Cookies.Cast<Cookie>().FirstOrDefault((Cookie c) => c.Name == "JSESSIONID");
						this.JSession = ((cookie != null) ? cookie.Value : null);
						IEnumerable<Cookie> enumerable = httpWebResponse.Cookies.Cast<Cookie>();
						text = streamReader.ReadToEnd();
					}
				}
			}
			return text;
		}

		// Token: 0x0600BC68 RID: 48232 RVA: 0x0047B250 File Offset: 0x00479450
		public static string Login(string user, string pass, string url = "")
		{
			return new RestLogin().FullLogin(user, pass, url);
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x0047B270 File Offset: 0x00479470
		public string FullLogin(string user, string pass, string url = "")
		{
			this.JSession = "";
			bool flag = url == "";
			if (flag)
			{
				url = "https://us.battle.net/login/?externalChallenge=login&app=OSI";
			}
			string text = this.NetRequest(url, "");
			RestLogin.LoginForm loginForm = new RestLogin.LoginForm
			{
				program_id = url.Split('=', StringSplitOptions.None).Last<string>()
			};
			loginForm.inputs.Add(new RestLogin.LoginForm.Inputs
			{
				input_id = "account_name",
				value = user
			});
			loginForm.inputs.Add(new RestLogin.LoginForm.Inputs
			{
				input_id = "password",
				value = pass
			});
			string text2 = this.NetRequest(url, JsonConvert.SerializeObject(loginForm));
			JObject jobject = JsonConvert.DeserializeObject<JObject>(text2);
			string text3 = jobject.Value<string>("authentication_state");
			bool flag2 = text3 == "LEGAL";
			if (flag2)
			{
				string text4 = Extensions.Value<string>(jobject["legal_form"]["agreements"][0]["url"]);
				string text5 = Extensions.Value<string>(jobject["legal_form"]["inputs"][0]["input_id"]);
				string text6 = this.NetRequest(text4, "");
				Console.WriteLine("updating legal");
				RestLogin.LoginForm loginForm2 = new RestLogin.LoginForm
				{
					program_id = url.Split('=', StringSplitOptions.None).Last<string>()
				};
				loginForm2.inputs.Add(new RestLogin.LoginForm.Inputs
				{
					input_id = text5,
					value = "true"
				});
				jobject = JsonConvert.DeserializeObject<JObject>(this.NetRequest("https://us.battle.net/login/legal", JsonConvert.SerializeObject(loginForm2)));
			}
			bool flag3 = text3 == "AUTHENTICATOR";
			if (flag3)
			{
				jobject = JsonConvert.DeserializeObject<JObject>(this.NetRequest("https://us.battle.net/login/authenticator/status", ""));
				jobject = JsonConvert.DeserializeObject<JObject>(this.NetRequest("https://us.battle.net/login/authenticator", ""));
			}
			return jobject.Value<string>("login_ticket");
		}

		// Token: 0x0400913D RID: 37181
		private string JSession = "";

		// Token: 0x020013AC RID: 5036
		public class LoginForm
		{
			// Token: 0x17003979 RID: 14713
			// (get) Token: 0x0600E064 RID: 57444 RVA: 0x004C7903 File Offset: 0x004C5B03
			// (set) Token: 0x0600E065 RID: 57445 RVA: 0x004C790B File Offset: 0x004C5B0B
			public string program_id { get; set; } = "OSI";

			// Token: 0x1700397A RID: 14714
			// (get) Token: 0x0600E066 RID: 57446 RVA: 0x004C7914 File Offset: 0x004C5B14
			// (set) Token: 0x0600E067 RID: 57447 RVA: 0x004C791C File Offset: 0x004C5B1C
			public string platform_id { get; set; } = "Wn64";

			// Token: 0x1700397B RID: 14715
			// (get) Token: 0x0600E068 RID: 57448 RVA: 0x004C7925 File Offset: 0x004C5B25
			// (set) Token: 0x0600E069 RID: 57449 RVA: 0x004C792D File Offset: 0x004C5B2D
			public List<RestLogin.LoginForm.Inputs> inputs { get; set; } = new List<RestLogin.LoginForm.Inputs>();

			// Token: 0x020014B0 RID: 5296
			public class Inputs
			{
				// Token: 0x17003B1B RID: 15131
				// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x004DCADA File Offset: 0x004DACDA
				// (set) Token: 0x0600E7D4 RID: 59348 RVA: 0x004DCAE2 File Offset: 0x004DACE2
				public string input_id { get; set; }

				// Token: 0x17003B1C RID: 15132
				// (get) Token: 0x0600E7D5 RID: 59349 RVA: 0x004DCAEB File Offset: 0x004DACEB
				// (set) Token: 0x0600E7D6 RID: 59350 RVA: 0x004DCAF3 File Offset: 0x004DACF3
				public string value { get; set; }
			}
		}
	}
}
