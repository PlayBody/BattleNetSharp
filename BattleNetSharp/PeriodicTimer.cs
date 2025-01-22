using System;

// Token: 0x0200000C RID: 12
public class PeriodicTimer
{
	// Token: 0x0600003C RID: 60 RVA: 0x00002E3D File Offset: 0x0000103D
	public PeriodicTimer(int period, int start_time)
	{
		this.i_period = period;
		this.i_expireTime = start_time;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002E58 File Offset: 0x00001058
	public bool Update(int diff)
	{
		bool flag = (this.i_expireTime -= diff) > 0;
		bool flag2;
		if (flag)
		{
			flag2 = false;
		}
		else
		{
			this.i_expireTime += ((this.i_period > diff) ? this.i_period : diff);
			flag2 = true;
		}
		return flag2;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002EA6 File Offset: 0x000010A6
	public void SetPeriodic(int period, int start_time)
	{
		this.i_expireTime = start_time;
		this.i_period = period;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002EB7 File Offset: 0x000010B7
	public void TUpdate(int diff)
	{
		this.i_expireTime -= diff;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002EC8 File Offset: 0x000010C8
	public bool TPassed()
	{
		return this.i_expireTime <= 0;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002EE6 File Offset: 0x000010E6
	public void TReset(int diff, int period)
	{
		this.i_expireTime += ((period > diff) ? period : diff);
	}

	// Token: 0x04000018 RID: 24
	private int i_period;

	// Token: 0x04000019 RID: 25
	private int i_expireTime;
}
