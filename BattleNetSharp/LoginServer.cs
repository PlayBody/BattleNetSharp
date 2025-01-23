using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace BattleNetSharp
{
	// Token: 0x02000ACE RID: 2766
	public class LoginServer
	{
		// Token: 0x0600BC5A RID: 48218 RVA: 0x0047A454 File Offset: 0x00478654
		public static void Start()
		{
			HttpListener httpListener = new HttpListener();
			httpListener.Prefixes.Add("https://*:443/");
			httpListener.Start();
			Console.WriteLine("web server started");
			for (;;)
			{
				LoginServer.sem.WaitOne();
				try
				{
					httpListener.GetContextAsync().ContinueWith<Task>(async delegate( Task<HttpListenerContext> t)
					{
						LoginServer.sem.Release();
						HttpListenerContext httpListenerContext = await t;
						HttpListenerContext context = httpListenerContext;
						httpListenerContext = null;
						HttpListenerRequest request = context.Request;
						HttpListenerResponse response = context.Response;
						try
						{
							Console.WriteLine(context.Request.RawUrl + " : " + context.Request.RemoteEndPoint.ToString());
						}
						catch
						{
						}
						response.OutputStream.Close();
					});
				}
				catch (Exception ex)
				{
					Console.WriteLine("error in webserver : " + ex.Message);
					Console.WriteLine(ex.StackTrace);
				}
			}
		}

		// Token: 0x04009133 RID: 37171
		private static Semaphore sem = new Semaphore(16, 16);
	}
}
