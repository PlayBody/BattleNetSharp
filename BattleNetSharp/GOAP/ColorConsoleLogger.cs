#nullable enable // @Review

using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace BattleNetSharp.GOAP
{
	// Token: 0x02000B11 RID: 2833
	public sealed class ColorConsoleLogger : ILogger
	{
		// Token: 0x0600BE37 RID: 48695 RVA: 0x00489372 File Offset: 0x00487572
<<<<<<< HEAD
		public IDisposable BeginScope<TState>(TState state)
=======
		public IDisposable BeginScope</*[Nullable(1)]*/ TState>(TState state)
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
		{
			return null;
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x00489378 File Offset: 0x00487578
		public bool IsEnabled(LogLevel logLevel)
		{
			return true;
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x0048938B File Offset: 0x0048758B
		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			Console.WriteLine(logLevel.ToString() + " : " + formatter(state, exception));
		}

		// Token: 0x04009190 RID: 37264
		public static ColorConsoleLogger Instance = new ColorConsoleLogger();
	}
}
