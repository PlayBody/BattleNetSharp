using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

// Token: 0x02000009 RID: 9
public static class Time
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000023A0 File Offset: 0x000005A0
	public static long UnixTime
	{
		get
		{
			return Time.DateTimeToUnixTime(DateTime.Now);
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000016 RID: 22 RVA: 0x000023BC File Offset: 0x000005BC
	public static long UnixTimeMilliseconds
	{
		get
		{
			return DateTime.Now.ToUnixTimeMilliseconds();
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000023E0 File Offset: 0x000005E0
	public static long ToMilliseconds(this TimeSpan span)
	{
		return (long)span.TotalMilliseconds;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000023FC File Offset: 0x000005FC
	public static uint GetSystemTime()
	{
		return (uint)Environment.TickCount;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002414 File Offset: 0x00000614
	public static uint GetMSTime()
	{
		return (uint)(DateTime.Now - Time.ApplicationStartTime).ToMilliseconds();
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000243C File Offset: 0x0000063C
	public static uint GetMSTimeDiff(uint oldMSTime, uint newMSTime)
	{
		bool flag = oldMSTime > newMSTime;
		uint num;
		if (flag)
		{
			num = uint.MaxValue - oldMSTime + newMSTime;
		}
		else
		{
			num = newMSTime - oldMSTime;
		}
		return num;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002464 File Offset: 0x00000664
	public static uint GetMSTimeDiff(uint oldMSTime, DateTime newTime)
	{
		uint num = (uint)(newTime - Time.ApplicationStartTime).TotalMilliseconds;
		return Time.GetMSTimeDiff(oldMSTime, num);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002494 File Offset: 0x00000694
	public static uint GetMSTimeDiffToNow(uint oldMSTime)
	{
		uint mstime = Time.GetMSTime();
		bool flag = oldMSTime > mstime;
		uint num;
		if (flag)
		{
			num = uint.MaxValue - oldMSTime + mstime;
		}
		else
		{
			num = mstime - oldMSTime;
		}
		return num;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000024C0 File Offset: 0x000006C0
	public static DateTime UnixTimeToDateTime(long unixTime)
	{
		return DateTimeOffset.FromUnixTimeSeconds(unixTime).LocalDateTime;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000024E0 File Offset: 0x000006E0
	public static long DateTimeToUnixTime(DateTime dateTime)
	{
		return dateTime.ToUnixTimeSeconds();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002500 File Offset: 0x00000700
	public static long GetNextResetUnixTime(int hours)
	{
		return Time.DateTimeToUnixTime(DateTime.Now.Date + new TimeSpan(hours, 0, 0));
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002534 File Offset: 0x00000734
	public static long GetNextResetUnixTime(int days, int hours)
	{
		return Time.DateTimeToUnixTime(DateTime.Now.Date + new TimeSpan(days, hours, 0, 0));
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002568 File Offset: 0x00000768
	public static long GetNextResetUnixTime(int months, int days, int hours)
	{
		return Time.DateTimeToUnixTime(DateTime.Now.Date + new TimeSpan(months + days, hours, 0));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000259C File Offset: 0x0000079C
	public static long GetLocalHourTimestamp(long time, uint hour, bool onlyAfterTime = true)
	{
		DateTime dateTime = Time.UnixTimeToDateTime(time);
		dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, dateTime.Kind);
		long num = Time.DateTimeToUnixTime(dateTime);
		long num2 = num + (long)((ulong)(hour * 3600U));
		bool flag = onlyAfterTime && num2 <= time;
		if (flag)
		{
			num2 += 86400L;
		}
		return num2;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000260C File Offset: 0x0000080C
	public static long LocalTimeToUTCTime(long time)
	{
		return Time.DateTimeToUnixTime(Time.UnixTimeToDateTime(time).ToUniversalTime());
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002634 File Offset: 0x00000834
	public static string secsToTimeString(ulong timeInSecs, TimeFormat timeFormat = TimeFormat.FullText, bool hoursOnly = false)
	{
		ulong num = timeInSecs % 60UL;
		ulong num2 = timeInSecs % 3600UL / 60UL;
		ulong num3 = timeInSecs % 86400UL / 3600UL;
		ulong num4 = timeInSecs / 86400UL;
		bool flag = timeFormat == TimeFormat.Numeric;
		string text;
		if (flag)
		{
			bool flag2 = num4 > 0UL;
			if (flag2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted<ulong>(num4);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<ulong>(num3);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<ulong>(num2);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<ulong>(num, "2");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				bool flag3 = num3 > 0UL;
				if (flag3)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted<ulong>(num3);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<ulong>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<ulong>(num, "2");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					bool flag4 = num2 > 0UL;
					if (flag4)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<ulong>(num2);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted<ulong>(num, "2");
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
						defaultInterpolatedStringHandler.AppendLiteral("0:");
						defaultInterpolatedStringHandler.AppendFormatted<ulong>(num, "2");
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag5 = num4 > 0UL;
			if (flag5)
			{
				stringBuilder.Append(num4);
				if (timeFormat != TimeFormat.FullText)
				{
					if (timeFormat != TimeFormat.ShortText)
					{
						return "<Unknown time format>";
					}
					stringBuilder.Append("d");
				}
				else
				{
					bool flag6 = num4 == 1UL;
					if (flag6)
					{
						stringBuilder.Append(" Day ");
					}
					else
					{
						stringBuilder.Append(" Days ");
					}
				}
			}
			bool flag7 = num3 > 0UL || hoursOnly;
			if (flag7)
			{
				stringBuilder.Append(num3);
				if (timeFormat != TimeFormat.FullText)
				{
					if (timeFormat != TimeFormat.ShortText)
					{
						return "<Unknown time format>";
					}
					stringBuilder.Append("h");
				}
				else
				{
					bool flag8 = num3 <= 1UL;
					if (flag8)
					{
						stringBuilder.Append(" Hour ");
					}
					else
					{
						stringBuilder.Append(" Hours ");
					}
				}
			}
			bool flag9 = !hoursOnly;
			if (flag9)
			{
				bool flag10 = num2 > 0UL;
				if (flag10)
				{
					stringBuilder.Append(num2);
					if (timeFormat != TimeFormat.FullText)
					{
						if (timeFormat != TimeFormat.ShortText)
						{
							return "<Unknown time format>";
						}
						stringBuilder.Append("m");
					}
					else
					{
						bool flag11 = num2 == 1UL;
						if (flag11)
						{
							stringBuilder.Append(" Minute ");
						}
						else
						{
							stringBuilder.Append(" Minutes ");
						}
					}
				}
				bool flag12 = num != 0UL || (num4 == 0UL && num3 == 0UL && num2 == 0UL);
				if (flag12)
				{
					stringBuilder.Append(num);
					if (timeFormat != TimeFormat.FullText)
					{
						if (timeFormat != TimeFormat.ShortText)
						{
							return "<Unknown time format>";
						}
						stringBuilder.Append("s");
					}
					else
					{
						bool flag13 = num <= 1UL;
						if (flag13)
						{
							stringBuilder.Append(" Second.");
						}
						else
						{
							stringBuilder.Append(" Seconds.");
						}
					}
				}
			}
			text = stringBuilder.ToString();
		}
		return text;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000029B4 File Offset: 0x00000BB4
	public static uint TimeStringToSecs(string timestring)
	{
		int num = 0;
		int num2 = 0;
		foreach (char c in timestring)
		{
			bool flag = char.IsDigit(c);
			if (!flag)
			{
				char c2 = c;
				char c3 = c2;
				int num3;
				if (c3 <= 'h')
				{
					if (c3 != 'd')
					{
						if (c3 != 'h')
						{
							goto IL_0081;
						}
						num3 = 3600;
					}
					else
					{
						num3 = 86400;
					}
				}
				else if (c3 != 'm')
				{
					if (c3 != 's')
					{
						goto IL_0081;
					}
					num3 = 1;
				}
				else
				{
					num3 = 60;
				}
				num2 *= num3;
				num += num2;
				num2 = 0;
				goto IL_0091;
				IL_0081:
				return 0U;
			}
			num2 *= 10;
			num2 += (int)(c - '0');
			IL_0091:;
		}
		return (uint)num;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002A70 File Offset: 0x00000C70
	public static string GetTimeString(long time)
	{
		long num = time / 86400L;
		long num2 = time % 86400L / 3600L;
		long num3 = time % 3600L / 60L;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
		defaultInterpolatedStringHandler.AppendLiteral("Days: ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(num);
		defaultInterpolatedStringHandler.AppendLiteral(" Hours: ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(num2);
		defaultInterpolatedStringHandler.AppendLiteral(" Minutes: ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(num3);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002B00 File Offset: 0x00000D00
	public static long GetUnixTimeFromPackedTime(uint packedDate)
	{
		DateTime dateTime = new DateTime((int)(((packedDate >> 24) & 31U) + 2000U), (int)(((packedDate >> 20) & 15U) + 1U), (int)(((packedDate >> 14) & 63U) + 1U), (int)((packedDate >> 6) & 31U), (int)(packedDate & 63U), 0);
		return (long)((ulong)((uint)Time.DateTimeToUnixTime(dateTime)));
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002B4C File Offset: 0x00000D4C
	public static uint GetPackedTimeFromUnixTime(long unixTime)
	{
		DateTime dateTime = Time.UnixTimeToDateTime(unixTime);
		return Convert.ToUInt32((dateTime.Year - 2000 << 24) | (dateTime.Month - 1 << 20) | (dateTime.Day - 1 << 14) | (int)((int)dateTime.DayOfWeek << 11) | (dateTime.Hour << 6) | dateTime.Minute);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002BB4 File Offset: 0x00000DB4
	public static uint GetPackedTimeFromDateTime(DateTime now)
	{
		return Convert.ToUInt32((now.Year - 2000 << 24) | (now.Month - 1 << 20) | (now.Day - 1 << 14) | (int)((int)now.DayOfWeek << 11) | (now.Hour << 6) | now.Minute);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002C14 File Offset: 0x00000E14
	public static void Profile(string description, int iterations, Action func)
	{
		Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
		Thread.CurrentThread.Priority = ThreadPriority.Highest;
		func();
		Stopwatch stopwatch = new Stopwatch();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
		stopwatch.Start();
		for (int i = 0; i < iterations; i++)
		{
			func();
		}
		stopwatch.Stop();
		Console.Write(description);
		Console.WriteLine(" Time Elapsed {0} ms", stopwatch.Elapsed.TotalMilliseconds);
	}

	// Token: 0x0400000D RID: 13
	public const int Minute = 60;

	// Token: 0x0400000E RID: 14
	public const int Hour = 3600;

	// Token: 0x0400000F RID: 15
	public const int Day = 86400;

	// Token: 0x04000010 RID: 16
	public const int Week = 604800;

	// Token: 0x04000011 RID: 17
	public const int Month = 2592000;

	// Token: 0x04000012 RID: 18
	public const int Year = 31104000;

	// Token: 0x04000013 RID: 19
	public const int InMilliseconds = 1000;

	// Token: 0x04000014 RID: 20
	public static readonly DateTime ApplicationStartTime = DateTime.Now;
}
