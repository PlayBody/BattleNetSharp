using System;

// Token: 0x0200000B RID: 11
public class IntervalTimer
{
	// Token: 0x06000034 RID: 52 RVA: 0x00002D60 File Offset: 0x00000F60
	public void Update(long diff)
	{
		this._current += diff;
		bool flag = this._current < 0L;
		if (flag)
		{
			this._current = 0L;
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002D94 File Offset: 0x00000F94
	public bool Passed()
	{
		return this._current >= this._interval;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002DB8 File Offset: 0x00000FB8
	public void Reset()
	{
		bool flag = this._current >= this._interval;
		if (flag)
		{
			this._current %= this._interval;
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002DEE File Offset: 0x00000FEE
	public void SetCurrent(long current)
	{
		this._current = current;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002DF8 File Offset: 0x00000FF8
	public void SetInterval(long interval)
	{
		this._interval = interval;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002E04 File Offset: 0x00001004
	public long GetInterval()
	{
		return this._interval;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002E1C File Offset: 0x0000101C
	public long GetCurrent()
	{
		return this._current;
	}

	// Token: 0x04000016 RID: 22
	private long _interval;

	// Token: 0x04000017 RID: 23
	private long _current;
}
