using System;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

// Token: 0x02000236 RID: 566
public class clsPermission
{
	// Token: 0x1700028A RID: 650
	// (get) Token: 0x0600158F RID: 5519 RVA: 0x001204A8 File Offset: 0x0011E8A8
	// (set) Token: 0x06001590 RID: 5520 RVA: 0x001204D4 File Offset: 0x0011E8D4
	public string WordingType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.strWordingType;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.strWordingType != value)
			{
				this.strWordingType = value;
			}
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06001591 RID: 5521 RVA: 0x00120510 File Offset: 0x0011E910
	// (set) Token: 0x06001592 RID: 5522 RVA: 0x0012053C File Offset: 0x0011E93C
	public string VolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.strVolType;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.strVolType != value)
			{
				this.strVolType = value;
			}
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06001593 RID: 5523 RVA: 0x00120578 File Offset: 0x0011E978
	// (set) Token: 0x06001594 RID: 5524 RVA: 0x001205A4 File Offset: 0x0011E9A4
	public double HistoricalDay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblHistoricalDay;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.dblHistoricalDay != value)
			{
				this.dblHistoricalDay = value;
			}
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x06001595 RID: 5525 RVA: 0x001205DC File Offset: 0x0011E9DC
	// (set) Token: 0x06001596 RID: 5526 RVA: 0x00120608 File Offset: 0x0011EA08
	public enumPermission Permission
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.ePermission;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ePermission != value)
			{
				this.ePermission = value;
			}
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06001597 RID: 5527 RVA: 0x00120640 File Offset: 0x0011EA40
	// (set) Token: 0x06001598 RID: 5528 RVA: 0x0012066C File Offset: 0x0011EA6C
	public enumDisplayBuySell DisplayBuySell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.eDisplayBuySell;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.eDisplayBuySell != value)
			{
				this.eDisplayBuySell = value;
			}
		}
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x001206A4 File Offset: 0x0011EAA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public clsPermission() : base()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		this.eDisplayBuySell = enumDisplayBuySell.Yes;
		this.ePermission = enumPermission.Visible;
		this.dblHistoricalDay = 30.0;
		
	}

	// Token: 0x04000B3F RID: 2879
	private enumDisplayBuySell eDisplayBuySell;

	// Token: 0x04000B40 RID: 2880
	private enumPermission ePermission;

	// Token: 0x04000B41 RID: 2881
	private double dblHistoricalDay;

	// Token: 0x04000B42 RID: 2882
	private string strWordingType;

	// Token: 0x04000B43 RID: 2883
	private string strVolType;
}
