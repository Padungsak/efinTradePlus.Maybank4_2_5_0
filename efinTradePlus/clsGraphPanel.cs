using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using ITSNet.Common.BIZ;

// Token: 0x020000EE RID: 238
public class clsGraphPanel
{
	// Token: 0x06000B2F RID: 2863 RVA: 0x000CCBD0 File Offset: 0x000CAFD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public clsGraphPanel() : base()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		this.dblCeiling = 9E-05;
		this.dblFloor = 9E-05;
		this.bGetWs = true;
		this.oSymbolType = enumType.eSet;
		this.oActiveTFEX = new clsPermission();
		this.oActiveSET = new clsPermission();
		this.oldRect = default(Rectangle);
		this.dictIPO = new Dictionary<string, float>();
		this.m_UpColor = Color.Lime;
		this.m_DownColor = Color.Red;
		this.m_NoChgColor = Color.Yellow;
		this.m_VolumeColor = Color.Yellow;
		this.m_BgColor = Color.Black;
		this.m_CeilingColor = Color.Aqua;
		this.m_ValueColor = Color.White;
		this.m_FloorColor = Color.Fuchsia;
		this.m_GridColor = Color.LightGray;
		this.m_FontSize = 9.25f;
		this.m_FontName = "Arial";
		this.m_BuyColor = Color.Lime;
		this.m_SellColor = Color.Red;
		this.sfDraw = new StringFormat();
		base..ctor();
		this._graphItems = new List<VolumeGraphItem>();
		this._itemsByStock = new List<ItemByStock>();
		this.m_Rect = default(Rectangle);
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000CCD10 File Offset: 0x000CB110
	// (set) Token: 0x06000B31 RID: 2865 RVA: 0x000CCD3C File Offset: 0x000CB13C
	public Color BuyColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_BuyColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.m_BuyColor = value;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000CCD54 File Offset: 0x000CB154
	// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000CCD80 File Offset: 0x000CB180
	public Color SellColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_SellColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.m_SellColor = value;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000CCD98 File Offset: 0x000CB198
	public clsPermission ActiveType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			clsPermission result = null;
			if (this.oSymbolType == enumType.eSet)
			{
				result = this.oActiveSET;
			}
			else if (this.oSymbolType == enumType.eTfex)
			{
				result = this.oActiveTFEX;
			}
			return result;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000CCDFC File Offset: 0x000CB1FC
	// (set) Token: 0x06000B36 RID: 2870 RVA: 0x000CCE2C File Offset: 0x000CB22C
	public int Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_Rect.Width;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.m_Rect.Width = value;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000CCE4C File Offset: 0x000CB24C
	// (set) Token: 0x06000B38 RID: 2872 RVA: 0x000CCE7C File Offset: 0x000CB27C
	public int Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_Rect.Height;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.m_Rect.Height = value;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000CCE9C File Offset: 0x000CB29C
	// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000CCEC8 File Offset: 0x000CB2C8
	public string SymbolList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.strSymbolList;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.strSymbolList = value;
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000CCEE4 File Offset: 0x000CB2E4
	// (set) Token: 0x06000B3C RID: 2876 RVA: 0x000CCF10 File Offset: 0x000CB310
	public double Ceiling
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblCeiling;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.dblCeiling = value;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000CCF2C File Offset: 0x000CB32C
	// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000CCF58 File Offset: 0x000CB358
	public double Floor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblFloor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.dblFloor = value;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000CCF74 File Offset: 0x000CB374
	// (set) Token: 0x06000B40 RID: 2880 RVA: 0x000CCFA0 File Offset: 0x000CB3A0
	public double Last
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblLast;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.dblLast = value;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000CCFBC File Offset: 0x000CB3BC
	// (set) Token: 0x06000B42 RID: 2882 RVA: 0x000CCFE8 File Offset: 0x000CB3E8
	public double Prior
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblPrior;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.dblPrior = value;
			if (this.dblPrior == 0.0)
			{
				this.IPO = this.GetIPOPrice(this.SymbolList);
			}
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000CD03C File Offset: 0x000CB43C
	// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000CD068 File Offset: 0x000CB468
	public double IPO
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.dblIPO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.dblIPO = value;
		}
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x000CD084 File Offset: 0x000CB484
	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetIPOPrice(string strSymbol)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		double result = 0.0;
		if (this.dictIPO.ContainsKey(strSymbol))
		{
			result = (double)this.dictIPO[strSymbol];
		}
		return result;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000CD0D8 File Offset: 0x000CB4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			if (this._graphItems != null)
			{
				this._graphItems.Clear();
			}
			if (this._itemsByStock != null)
			{
				this._itemsByStock.Clear();
			}
			this.strSymbolList = "";
			this._lngMaxVol = 0L;
			this.dblCeiling = 99999.99;
			this.dblFloor = 99999.99;
			this.dblLast = 0.0;
			this.dblPrior = 0.0;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x000CD198 File Offset: 0x000CB598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(double dblPrice, long lngAccVol, long lngBuyVol, long lngSellVol)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			VolumeGraphItem volumeGraphItem = new VolumeGraphItem();
			volumeGraphItem.Price = dblPrice;
			volumeGraphItem.AccVol = lngAccVol;
			if (lngAccVol > this._lngMaxVol)
			{
				this._lngMaxVol = lngAccVol;
			}
			volumeGraphItem.BuyVol = lngBuyVol;
			volumeGraphItem.SellVol = lngSellVol;
			volumeGraphItem.AtoCVol = (double)(volumeGraphItem.AccVol - volumeGraphItem.SellVol - volumeGraphItem.BuyVol);
			this._graphItems.Add(volumeGraphItem);
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Add clsGraphPanel " + ex.Message);
		}
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x000CD250 File Offset: 0x000CB650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string stock, double value, double profit)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			ItemByStock itemByStock = new ItemByStock();
			itemByStock.Stock = stock;
			itemByStock.Value = value;
			itemByStock.Profit = profit;
			if (value > (double)this._lngMaxVol)
			{
				this._lngMaxVol = (long)value;
			}
			this._itemsByStock.Add(itemByStock);
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Add clsGraphPanel " + ex.Message);
		}
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x000CD2E4 File Offset: 0x000CB6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private long GetMaxVolume()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		long num = 0L;
		try
		{
			foreach (VolumeGraphItem current in this._graphItems)
			{
				if (current.AccVol > num)
				{
					num = current.AccVol;
				}
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Function GetMaxVolume clsGraphPanel " + ex.Message);
		}
		return num;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x000CD3A8 File Offset: 0x000CB7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetMaxValue()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		double num = 0.0;
		try
		{
			foreach (ItemByStock current in this._itemsByStock)
			{
				if (current.Value > num)
				{
					num = current.Value;
				}
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Function GetMaxVolume clsGraphPanel " + ex.Message);
		}
		return num;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x000CD474 File Offset: 0x000CB874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Sort()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this._graphItems.Sort(new Comparison<VolumeGraphItem>(this.Sort));
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x000CD4A0 File Offset: 0x000CB8A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int Sort(VolumeGraphItem x, VolumeGraphItem y)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		int result;
		try
		{
			if (x.Price == 0.0)
			{
				if (y.Price == 0.0)
				{
					result = 0;
				}
				else if (y.Price > 0.0)
				{
					result = -1;
				}
				else
				{
					result = 1;
				}
			}
			else if (y.Price == 0.0 && x.Price > 0.0)
			{
				result = 1;
			}
			else if (y.Price == 0.0 && x.Price < 0.0)
			{
				result = -1;
			}
			else
			{
				int num = x.Price.CompareTo(y.Price);
				if (num != 0)
				{
					result = num;
				}
				else
				{
					result = x.Price.CompareTo(y.Price);
				}
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Function Sort clsGraphPanel " + ex.Message);
		}
		return result;
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x000CD620 File Offset: 0x000CBA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(double dblPrice, long lngAccVol, long lngBuyVol, long lngSellVol)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			bool flag = false;
			int num = 0;
			foreach (VolumeGraphItem current in this._graphItems)
			{
				if (current.Price == dblPrice)
				{
					current.AccVol += lngAccVol;
					if (current.AccVol > this._lngMaxVol)
					{
						this._lngMaxVol = current.AccVol;
					}
					current.BuyVol += lngBuyVol;
					current.SellVol += lngSellVol;
					current.AtoCVol += (double)(lngAccVol - lngBuyVol - lngSellVol);
					this._graphItems[num] = current;
					flag = true;
					break;
				}
				num++;
			}
			if (!flag)
			{
				this.Add(dblPrice, lngAccVol, lngBuyVol, lngSellVol);
				this._graphItems.Sort(new Comparison<VolumeGraphItem>(this.Sort));
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Update clsGraphPanel " + ex.Message);
		}
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x000CD7A0 File Offset: 0x000CBBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMouseClick(Graphics gDC, float x, float y, double dblWidth)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			int num = 0;
			if (y > (float)this.sngTop || (double)x > dblWidth)
			{
				if (this._graphItems.Count > 0)
				{
					foreach (VolumeGraphItem current in this._graphItems)
					{
						if (x >= (float)current.Left && x <= (float)current.Right)
						{
							using (Pen pen = new Pen(this.m_ValueColor))
							{
								this.oldRect = new Rectangle(current.Left + (current.Right - current.Left) / 2, this.sngTop, 1, this.sngBottom);
								pen.DashStyle = DashStyle.Dash;
								if (this.intLastIndex == num)
								{
									this.oldRect = new Rectangle(0, 0, 0, 0);
								}
								this.intLastIndex = num;
							}
							break;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Sub OnMouseClick clsGraphPanel " + ex.Message);
		}
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x000CD96C File Offset: 0x000CBD6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSumBuySell(string Type)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		string text = string.Empty;
		double num = 0.0;
		try
		{
			if ((this.oSymbolType == enumType.eSet || this.oSymbolType == enumType.eTfex) && this.ActiveType.DisplayBuySell == enumDisplayBuySell.Yes)
			{
				foreach (VolumeGraphItem current in this._graphItems)
				{
					num += current.AtoCVol;
					num += (double)current.BuyVol;
					num += (double)current.SellVol;
				}
			}
			if (Type != null)
			{
				if (!(Type == "B"))
				{
					if (!(Type == "S"))
					{
						if (Type == "A")
						{
							for (int i = 0; i <= this._graphItems.Count - 1; i++)
							{
								text += this._graphItems[i].AtoCVol;
							}
						}
					}
					else
					{
						for (int i = 0; i <= this._graphItems.Count - 1; i++)
						{
							text += this._graphItems[i].SellVol;
						}
					}
				}
				else
				{
					for (int i = 0; i <= this._graphItems.Count - 1; i++)
					{
						text += this._graphItems[i].BuyVol;
					}
				}
			}
			if ((this.oSymbolType == enumType.eTfex || this.oSymbolType == enumType.eSet) && this.ActiveType.DisplayBuySell == enumDisplayBuySell.No)
			{
				text = "N/A(N/A%)";
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Function GetSumBS clsGraphPanel " + ex.Message);
		}
		if (FormatUtil.Isnumeric(text))
		{
			if (num != 0.0)
			{
				text = Convert.ToDouble(text).ToString("#,##0") + "(" + Convert.ToDouble(Convert.ToDouble(text) * 100.0 / num).ToString("#,##0.00") + "%)";
			}
			else
			{
				text += "(0.00%)";
			}
		}
		return text;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x000CDC7C File Offset: 0x000CC07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(Graphics gDC)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		Pen pen = null;
		Rectangle rect = default(Rectangle);
		Rectangle rect2 = default(Rectangle);
		SolidBrush solidBrush = null;
		Font font = null;
		SizeF sizeF = default(SizeF);
		bool flag = false;
		try
		{
			List<clsVolumeItem> list = new List<clsVolumeItem>();
			this.m_Font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Bold);
			int num = Convert.ToInt32(gDC.MeasureString("I", this.m_Font).Height);
			solidBrush = new SolidBrush(this.m_BgColor);
			rect2 = new Rectangle(0, 0, this.m_Rect.Width, num);
			gDC.FillRectangle(solidBrush, rect2);
			this.m_Font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Regular);
			rect2 = new Rectangle(5, num + 1, this.m_Rect.Width - 10, this.m_Rect.Height - num - 30);
			this.sngTop = num + 5;
			this.sngBottom = this.m_Rect.Height - num - 50;
			pen = new Pen(Color.DimGray);
			gDC.DrawRectangle(pen, rect2);
			int x = rect2.Left;
			int x2 = rect2.Right;
			pen.DashStyle = DashStyle.Dash;
			pen.Color = ColorTranslator.FromHtml("#333333");
			for (int i = 1; i <= 9; i++)
			{
				int num2 = rect2.Top + Convert.ToInt32(rect2.Height / 10) * i;
				int y = num2;
				gDC.DrawLine(pen, x, num2, x2, y);
			}
			int num3 = 0;
			this.sfDraw.Alignment = StringAlignment.Center;
			int num4 = rect2.Width / (this._graphItems.Count * 3);
			num3 = rect2.Width / (this._graphItems.Count + 1) - num4;
			if (num3 > 120)
			{
				num3 = 120;
			}
			long num5 = this.GetMaxVolume() * 100L / 90L;
			float num6 = (float)(num3 * this._graphItems.Count + num4 * (this._graphItems.Count - 1));
			int num7 = Convert.ToInt32(((float)rect2.Width - num6) / 2f);
			int num8 = rect2.Left + num7;
			if (this._graphItems.Count > 0)
			{
				int num9 = 0;
				string text;
				foreach (VolumeGraphItem current in this._graphItems)
				{
					solidBrush.Dispose();
					solidBrush = new SolidBrush(this.m_BgColor);
					rect = new Rectangle(num8, this.sngTop + 1, num3, this.sngBottom - 1);
					gDC.FillRectangle(solidBrush, rect);
					x = rect.Left - 1;
					x2 = rect.Right + 1;
					pen.DashStyle = DashStyle.Dash;
					pen.Color = ColorTranslator.FromHtml("#333333");
					for (int i = 1; i <= 9; i++)
					{
						int num2 = rect2.Top + Convert.ToInt32(rect2.Height / 10) * i;
						int y = num2;
						gDC.DrawLine(pen, x, num2, x2, y);
					}
					pen.Color = Color.DarkGray;
					solidBrush.Dispose();
					solidBrush = new SolidBrush(this.m_VolumeColor);
					double num10 = (double)(current.AccVol * 100L / num5);
					num10 = 100.0 - num10;
					int num11 = rect2.Top + Convert.ToInt32((double)rect2.Height * num10 / 100.0);
					rect = new Rectangle(num8, num11, num3, rect2.Top + rect2.Height - num11);
					gDC.FillRectangle(solidBrush, rect);
					int num12 = num8;
					int num13 = num11 - num + 2;
					list.Add(new clsVolumeItem(num12, num13, (double)current.AccVol));
					solidBrush.Dispose();
					if (this.ActiveType.DisplayBuySell == enumDisplayBuySell.Yes)
					{
						solidBrush = new SolidBrush(this.m_SellColor);
					}
					else
					{
						solidBrush = new SolidBrush(this.m_VolumeColor);
					}
					num10 = (double)((current.SellVol + current.BuyVol) * 100L / num5);
					num10 = 100.0 - num10;
					num11 = rect2.Top + Convert.ToInt32((double)rect2.Height * num10 / 100.0);
					rect = new Rectangle(num8, num11, num3, rect2.Top + rect2.Height - num11);
					gDC.FillRectangle(solidBrush, rect);
					solidBrush.Dispose();
					if (this.ActiveType.DisplayBuySell == enumDisplayBuySell.Yes)
					{
						solidBrush = new SolidBrush(this.m_BuyColor);
					}
					else
					{
						solidBrush = new SolidBrush(this.m_VolumeColor);
					}
					num10 = (double)(current.BuyVol * 100L / num5);
					num10 = 100.0 - num10;
					num11 = rect2.Top + Convert.ToInt32((double)rect2.Height * num10 / 100.0);
					rect = new Rectangle(num8, num11, num3, rect2.Top + rect2.Height - num11);
					gDC.FillRectangle(solidBrush, rect);
					if (this._graphItems.Count < 15)
					{
						font = new Font(this.m_FontName, this.m_FontSize);
					}
					else
					{
						font = new Font(this.m_FontName, this.m_FontSize - 3f);
					}
					solidBrush.Dispose();
					if (Convert.ToDouble(current.Price) == 0.0 || (this.dblPrior == 0.0 && this.IPO == 0.0))
					{
						solidBrush = new SolidBrush(this.m_NoChgColor);
					}
					else if (Convert.ToDouble(current.Price) == Convert.ToDouble(this.dblCeiling))
					{
						solidBrush = new SolidBrush(this.m_CeilingColor);
					}
					else if (Convert.ToDouble(current.Price) == Convert.ToDouble(this.dblFloor))
					{
						solidBrush = new SolidBrush(this.m_FloorColor);
					}
					else if (this.IPO != 0.0)
					{
						solidBrush = new SolidBrush(this.GetCompareColor(this.dblIPO, current.Price));
					}
					else
					{
						solidBrush = new SolidBrush(this.GetCompareColor(this.dblPrior, current.Price));
					}
					text = current.Price.ToString();
					sizeF = gDC.MeasureString(Convert.ToDouble(text).ToString("#,##0.00"), font);
					num13 = rect2.Bottom + 4;
					bool flag2 = false;
					if (Convert.ToDouble(num3 * 2) > Convert.ToDouble(sizeF.Width + 10f))
					{
						flag2 = true;
						gDC.DrawString(Convert.ToDouble(text).ToString("#,##0.00"), font, solidBrush, (float)(num12 + num3 / 2), (float)num13, this.sfDraw);
					}
					else if (Convert.ToDouble(num3 * 5) > Convert.ToDouble(sizeF.Width + 15f))
					{
						if (num9 % 2 == 0)
						{
							flag2 = true;
							gDC.DrawString(Convert.ToDouble(text).ToString("#,##0.00"), font, solidBrush, (float)(num12 + num3 / 2), (float)num13, this.sfDraw);
							if (Convert.ToDouble(text) == this.dblLast)
							{
								gDC.DrawString("[Last]", font, solidBrush, (float)(num12 + num3 / 2), (float)num13 + sizeF.Height, this.sfDraw);
							}
						}
						else
						{
							flag2 = true;
							gDC.DrawString(Convert.ToDouble(text).ToString("#,##0.00"), font, solidBrush, (float)(num12 + num3 / 2), (float)(num13 + 12), this.sfDraw);
							if (Convert.ToDouble(text) == this.dblLast)
							{
								gDC.DrawString("[Last]", font, solidBrush, (float)(num12 + num3 / 2), (float)(num13 + 12) + sizeF.Height, this.sfDraw);
							}
							num13 += 12;
						}
					}
					else if (Convert.ToDouble(num3 * 10) > Convert.ToDouble(sizeF.Width + 15f))
					{
						if (num9 % 4 == 0)
						{
							flag2 = true;
							gDC.DrawString(Convert.ToDouble(text).ToString("#,##0.00"), font, solidBrush, (float)(num12 + num3 / 2), (float)num13, this.sfDraw);
							if (Convert.ToDouble(text) == this.dblLast)
							{
								gDC.DrawString("[Last]", font, solidBrush, (float)(num12 + num3 / 2), (float)num13 + sizeF.Height, this.sfDraw);
							}
						}
						else if (num9 % 2 == 0)
						{
							flag2 = true;
							gDC.DrawString(Convert.ToDouble(text).ToString("#,##0.00"), font, solidBrush, (float)(num12 + num3 / 2), (float)(num13 + 12), this.sfDraw);
							if (Convert.ToDouble(text) == this.dblLast)
							{
								gDC.DrawString("[Last]", font, solidBrush, (float)(num12 + num3 / 2), (float)(num13 + 12) + sizeF.Height, this.sfDraw);
							}
							num13 += 12;
						}
					}
					if (flag2)
					{
						flag = true;
					}
					current.Right = rect.Right;
					num8 += num4 + num3;
					num9++;
				}
				SizeF sizeF2 = default(SizeF);
				text = this.strSymbolList + " , ";
				solidBrush.Dispose();
				pen.DashStyle = DashStyle.Solid;
				if (flag)
				{
					string text2 = "0";
					foreach (clsVolumeItem current2 in list)
					{
						if (this.oSymbolType == enumType.eSet)
						{
							text2 = current2.Volume.ToString();
						}
						else if (this.oSymbolType == enumType.eTfex)
						{
							text2 = current2.Volume.ToString();
						}
						text2 = Convert.ToDouble(text2).ToString("#,##0");
						sizeF2 = gDC.MeasureString(text2, font);
						int num14 = current2.x + num3 / 2;
						Rectangle rect3 = new Rectangle(Convert.ToInt32((float)num14 - sizeF2.Width / 2f), current2.y - 6, Convert.ToInt32(sizeF2.Width), Convert.ToInt32(sizeF2.Height));
						gDC.DrawRectangle(pen, rect3);
						gDC.DrawString(text2, font, Brushes.White, (float)num14, (float)(current2.y - 5), this.sfDraw);
						gDC.DrawLine(pen, (float)num14, (float)current2.y + sizeF2.Height - 4f, (float)num14, (float)current2.y + sizeF2.Height + 5f);
					}
				}
				list.Clear();
				list = null;
			}
			else
			{
				string text;
				if (!string.IsNullOrEmpty(this.strSymbolList))
				{
					if (this.bGetWs && !this.bException)
					{
						text = this.strSymbolList + " - No Information!";
					}
					else if (this.bGetWs && this.bException)
					{
						text = this.strSymbolList + " - Load fail retry agian...";
					}
					else
					{
						text = this.strSymbolList + " - Loading...";
					}
				}
				else
				{
					text = "";
				}
				int num12 = (this.m_Rect.Width - rect2.Width) / 2;
				solidBrush = new SolidBrush(this.m_NoChgColor);
				if (font != null)
				{
					font.Dispose();
				}
				font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Bold);
				int num13 = rect2.Top;
				gDC.DrawString(text, font, solidBrush, 1f, 1f);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Draw clsGraphPanel " + ex.Message);
		}
		finally
		{
			if (this.m_Font != null)
			{
				this.m_Font.Dispose();
				this.m_Font = null;
			}
			if (solidBrush != null)
			{
				solidBrush.Dispose();
				solidBrush = null;
			}
		}
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x000CEABC File Offset: 0x000CCEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawByStock(Graphics gDC)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		Pen pen = null;
		Rectangle rect = default(Rectangle);
		Rectangle rect2 = default(Rectangle);
		SolidBrush solidBrush = null;
		Font font = null;
		SizeF sizeF = default(SizeF);
		bool flag = false;
		try
		{
			List<clsVolumeItem> list = new List<clsVolumeItem>();
			this.m_Font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Bold);
			int num = Convert.ToInt32(gDC.MeasureString("I", this.m_Font).Height);
			solidBrush = new SolidBrush(this.m_BgColor);
			rect2 = new Rectangle(0, 0, this.m_Rect.Width, num);
			gDC.FillRectangle(solidBrush, rect2);
			this.m_Font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Regular);
			rect2 = new Rectangle(5, num + 1, this.m_Rect.Width - 10, this.m_Rect.Height - num - 30);
			this.sngTop = num + 5;
			this.sngBottom = this.m_Rect.Height - num - 50;
			pen = new Pen(Color.DimGray);
			gDC.DrawRectangle(pen, rect2);
			int x = rect2.Left;
			int x2 = rect2.Right;
			pen.DashStyle = DashStyle.Dash;
			pen.Color = ColorTranslator.FromHtml("#333333");
			for (int i = 1; i <= 9; i++)
			{
				int num2 = rect2.Top + Convert.ToInt32(rect2.Height / 10) * i;
				int y = num2;
				gDC.DrawLine(pen, x, num2, x2, y);
			}
			int num3 = 0;
			this.sfDraw.Alignment = StringAlignment.Center;
			int num4 = rect2.Width / (this._itemsByStock.Count * 3);
			num3 = rect2.Width / (this._itemsByStock.Count + 1) - num4;
			if (num3 > 120)
			{
				num3 = 120;
			}
			double num5 = this.GetMaxValue() * 100.0 / 90.0;
			float num6 = (float)(num3 * this._itemsByStock.Count + num4 * (this._itemsByStock.Count - 1));
			int num7 = Convert.ToInt32(((float)rect2.Width - num6) / 2f);
			int num8 = rect2.Left + num7;
			if (this._itemsByStock.Count > 0)
			{
				int num9 = 0;
				string text;
				foreach (ItemByStock current in this._itemsByStock)
				{
					solidBrush.Dispose();
					solidBrush = new SolidBrush(this.m_BgColor);
					rect = new Rectangle(num8, this.sngTop + 1, num3, this.sngBottom - 1);
					gDC.FillRectangle(solidBrush, rect);
					x = rect.Left - 1;
					x2 = rect.Right + 1;
					pen.DashStyle = DashStyle.Dash;
					pen.Color = ColorTranslator.FromHtml("#333333");
					for (int i = 1; i <= 9; i++)
					{
						int num2 = rect2.Top + Convert.ToInt32(rect2.Height / 10) * i;
						int y = num2;
						gDC.DrawLine(pen, x, num2, x2, y);
					}
					pen.Color = Color.DarkGray;
					solidBrush.Dispose();
					if (current.Profit > 0.0)
					{
						solidBrush = new SolidBrush(this.m_BuyColor);
					}
					else if (current.Profit < 0.0)
					{
						solidBrush = new SolidBrush(this.m_SellColor);
					}
					else
					{
						solidBrush = new SolidBrush(this.m_VolumeColor);
					}
					double num10 = current.Value * 100.0 / num5;
					num10 = 100.0 - num10;
					int num11 = rect2.Top + Convert.ToInt32((double)rect2.Height * num10 / 100.0);
					rect = new Rectangle(num8, num11, num3, rect2.Top + rect2.Height - num11);
					gDC.FillRectangle(solidBrush, rect);
					int num12 = num8;
					int num13 = num11 - num + 2;
					list.Add(new clsVolumeItem(num12, num13, current.Value));
					if (this._itemsByStock.Count < 15)
					{
						font = new Font(this.m_FontName, this.m_FontSize);
					}
					else
					{
						font = new Font(this.m_FontName, this.m_FontSize - 2f);
					}
					solidBrush.Dispose();
					solidBrush = new SolidBrush(this.m_VolumeColor);
					text = current.Stock;
					sizeF = gDC.MeasureString(text, font);
					num13 = rect2.Bottom + 4;
					bool flag2 = true;
					gDC.DrawString(text, font, solidBrush, (float)(num12 + num3 / 2), (float)num13, this.sfDraw);
					if (flag2)
					{
						flag = true;
					}
					num8 += num4 + num3;
					num9++;
				}
				SizeF sizeF2 = default(SizeF);
				text = this.strSymbolList + " , ";
				solidBrush.Dispose();
				pen.DashStyle = DashStyle.Solid;
				if (flag)
				{
					foreach (clsVolumeItem current2 in list)
					{
						string text2 = Convert.ToDouble(current2.Volume).ToString("#,##0.00") + "%";
						sizeF2 = gDC.MeasureString(text2, font);
						int num14 = current2.x + num3 / 2;
						Rectangle rect3 = new Rectangle(Convert.ToInt32((float)num14 - sizeF2.Width / 2f), current2.y - 6, Convert.ToInt32(sizeF2.Width), Convert.ToInt32(sizeF2.Height));
						gDC.DrawRectangle(pen, rect3);
						gDC.DrawString(text2, font, Brushes.White, (float)num14, (float)(current2.y - 5), this.sfDraw);
						gDC.DrawLine(pen, (float)num14, (float)current2.y + sizeF2.Height - 4f, (float)num14, (float)current2.y + sizeF2.Height + 5f);
					}
				}
				list.Clear();
				list = null;
			}
			else
			{
				string text;
				if (!string.IsNullOrEmpty(this.strSymbolList))
				{
					if (this.bGetWs && !this.bException)
					{
						text = this.strSymbolList + " - No Information!";
					}
					else if (this.bGetWs && this.bException)
					{
						text = this.strSymbolList + " - Load fail retry agian...";
					}
					else
					{
						text = this.strSymbolList + " - Loading...";
					}
				}
				else
				{
					text = "";
				}
				int num12 = (this.m_Rect.Width - rect2.Width) / 2;
				solidBrush = new SolidBrush(this.m_NoChgColor);
				if (font != null)
				{
					font.Dispose();
				}
				font = new Font(this.m_FontName, this.m_FontSize, FontStyle.Bold);
				int num13 = rect2.Top;
				gDC.DrawString(text, font, solidBrush, 1f, 1f);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Sub Draw clsGraphPanel " + ex.Message);
		}
		finally
		{
			if (this.m_Font != null)
			{
				this.m_Font.Dispose();
				this.m_Font = null;
			}
			if (solidBrush != null)
			{
				solidBrush.Dispose();
				solidBrush = null;
			}
		}
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x000CF3A4 File Offset: 0x000CD7A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetCompareColor(double CompareValue, double InputValue)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		Color result;
		if (InputValue > CompareValue)
		{
			result = this.m_UpColor;
		}
		else if (InputValue < CompareValue)
		{
			result = this.m_DownColor;
		}
		else
		{
			result = this.m_NoChgColor;
		}
		return result;
	}

	// Token: 0x04000751 RID: 1873
	private List<VolumeGraphItem> _graphItems;

	// Token: 0x04000752 RID: 1874
	private List<ItemByStock> _itemsByStock;

	// Token: 0x04000753 RID: 1875
	public string strSymbolList;

	// Token: 0x04000754 RID: 1876
	private double dblLast;

	// Token: 0x04000755 RID: 1877
	private double dblPrior;

	// Token: 0x04000756 RID: 1878
	private double dblCeiling;

	// Token: 0x04000757 RID: 1879
	private double dblFloor;

	// Token: 0x04000758 RID: 1880
	private long _lngMaxVol;

	// Token: 0x04000759 RID: 1881
	private double dblIPO;

	// Token: 0x0400075A RID: 1882
	private Font m_Font;

	// Token: 0x0400075B RID: 1883
	private Rectangle m_Rect;

	// Token: 0x0400075C RID: 1884
	private int sngBottom;

	// Token: 0x0400075D RID: 1885
	private int sngTop;

	// Token: 0x0400075E RID: 1886
	private int intLastIndex;

	// Token: 0x0400075F RID: 1887
	public bool bGetWs;

	// Token: 0x04000760 RID: 1888
	public bool bException;

	// Token: 0x04000761 RID: 1889
	public enumType oSymbolType;

	// Token: 0x04000762 RID: 1890
	public clsPermission oActiveTFEX;

	// Token: 0x04000763 RID: 1891
	public clsPermission oActiveSET;

	// Token: 0x04000764 RID: 1892
	public Rectangle oldRect;

	// Token: 0x04000765 RID: 1893
	public Dictionary<string, float> dictIPO;

	// Token: 0x04000766 RID: 1894
	public Color m_UpColor;

	// Token: 0x04000767 RID: 1895
	public Color m_DownColor;

	// Token: 0x04000768 RID: 1896
	public Color m_NoChgColor;

	// Token: 0x04000769 RID: 1897
	public Color m_VolumeColor;

	// Token: 0x0400076A RID: 1898
	public Color m_BgColor;

	// Token: 0x0400076B RID: 1899
	public Color m_CeilingColor;

	// Token: 0x0400076C RID: 1900
	public Color m_ValueColor;

	// Token: 0x0400076D RID: 1901
	public Color m_FloorColor;

	// Token: 0x0400076E RID: 1902
	public Color m_GridColor;

	// Token: 0x0400076F RID: 1903
	public float m_FontSize;

	// Token: 0x04000770 RID: 1904
	public string m_FontName;

	// Token: 0x04000771 RID: 1905
	private Color m_BuyColor;

	// Token: 0x04000772 RID: 1906
	private Color m_SellColor;

	// Token: 0x04000773 RID: 1907
	private StringFormat sfDraw;
}
