using System;

// Token: 0x0200000A RID: 10
public class TimeTracker
{
	// Token: 0x0600002C RID: 44 RVA: 0x00002CB5 File Offset: 0x00000EB5
	public TimeTracker(uint expiry = 0U)
	{
		this._expiryTime = TimeSpan.FromMilliseconds(expiry);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002CCD File Offset: 0x00000ECD
	public TimeTracker(TimeSpan expiry)
	{
		this._expiryTime = expiry;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002CDE File Offset: 0x00000EDE
	public void Update(uint diff)
	{
		this.Update(TimeSpan.FromMilliseconds(diff));
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002CF0 File Offset: 0x00000EF0
	public void Update(TimeSpan diff)
	{
		this._expiryTime -= diff;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002D08 File Offset: 0x00000F08
	public bool Passed()
	{
		return this._expiryTime <= TimeSpan.Zero;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002D2A File Offset: 0x00000F2A
	public void Reset(uint expiry)
	{
		this.Reset(TimeSpan.FromMilliseconds(expiry));
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002D3C File Offset: 0x00000F3C
	public void Reset(TimeSpan expiry)
	{
		this._expiryTime = expiry;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002D48 File Offset: 0x00000F48
	public TimeSpan GetExpiry()
	{
		return this._expiryTime;
	}

	// Token: 0x04000015 RID: 21
	private TimeSpan _expiryTime;
}
