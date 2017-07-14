using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;

namespace i2TradePlus
{
	// Token: 0x020000A3 RID: 163
	public class Utilities
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x0008F2A0 File Offset: 0x0008D6A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Utilities()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0008F2CC File Offset: 0x0008D6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceColor(decimal price, decimal priceCompare)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color result;
			if (price > priceCompare)
			{
				result = MyColor.UpColor;
			}
			else if (price < priceCompare)
			{
				result = MyColor.DownColor;
			}
			else
			{
				result = MyColor.UnChgColor;
			}
			return result;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0008F330 File Offset: 0x0008D730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceCFColor(decimal price, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color result = Color.White;
			if (stockInfo.Number > -1)
			{
				if (price == stockInfo.Ceiling)
				{
					result = MyColor.CeilingColor;
				}
				else if (price == stockInfo.Floor)
				{
					result = MyColor.FloorColor;
				}
				else if (stockInfo.PriorPrice > 0m && price > stockInfo.PriorPrice)
				{
					result = MyColor.UpColor;
				}
				else if (price > 0m && stockInfo.PriorPrice > 0m && price < stockInfo.PriorPrice)
				{
					result = MyColor.DownColor;
				}
				else
				{
					result = MyColor.UnChgColor;
				}
			}
			else
			{
				result = Color.White;
			}
			return result;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0008F450 File Offset: 0x0008D850
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceCFColor(string price, StockList.StockInformation stockinfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color result = MyColor.UnChgColor;
			decimal num;
			if (decimal.TryParse(price, out num))
			{
				if (num > 0m)
				{
					result = Utilities.ComparePriceCFColor(num, stockinfo);
				}
			}
			return result;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0008F4AC File Offset: 0x0008D8AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceCFColor(object price, SeriesList.SeriesInformation seriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal price2;
			decimal.TryParse(price.ToString(), out price2);
			return Utilities.ComparePriceCFColor(price2, seriesInfo);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0008F4E4 File Offset: 0x0008D8E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceCFColor(decimal price, SeriesList.SeriesInformation seriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color result = Color.White;
			if (!string.IsNullOrEmpty(seriesInfo.Symbol))
			{
				if (price == seriesInfo.Ceiling)
				{
					result = MyColor.CeilingColor;
				}
				else if (price == seriesInfo.Floor)
				{
					result = MyColor.FloorColor;
				}
				else if (price > seriesInfo.PrevFixPrice)
				{
					result = MyColor.UpColor;
				}
				else if (price < seriesInfo.PrevFixPrice)
				{
					result = MyColor.DownColor;
				}
				else
				{
					result = MyColor.UnChgColor;
				}
			}
			else
			{
				result = Color.White;
			}
			return result;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0008F5BC File Offset: 0x0008D9BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ComparePriceCFColor(decimal price, decimal priceCompare, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color result = Color.White;
			if (stockInfo.Number > -1)
			{
				if (price == stockInfo.Ceiling)
				{
					result = MyColor.CeilingColor;
				}
				else if (price == stockInfo.Floor)
				{
					result = MyColor.FloorColor;
				}
				else if (price > priceCompare)
				{
					result = MyColor.UpColor;
				}
				else if (price < priceCompare)
				{
					result = MyColor.DownColor;
				}
				else
				{
					result = MyColor.UnChgColor;
				}
			}
			else
			{
				result = Color.White;
			}
			return result;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0008F688 File Offset: 0x0008DA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0008F6B4 File Offset: 0x0008DAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price, int numOfDec)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price, numOfDec, "");
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0008F6E4 File Offset: 0x0008DAE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price, int numOfDec, object defaultValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price, numOfDec, defaultValue);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0008F710 File Offset: 0x0008DB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price, string unit)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price, false, unit, 2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0008F73C File Offset: 0x0008DB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price, bool sign, string unit)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price, sign, unit, 2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0008F768 File Offset: 0x0008DB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceFormat(object price, bool sign, int numOfDec)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceFormat(price, sign, "", numOfDec);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0008F798 File Offset: 0x0008DB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PriceBySideFormat(object price, string buySellSide)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.PriceBySideFormat(price, buySellSide);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0008F7C4 File Offset: 0x0008DBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string VolumeFormat(object volume, bool comma)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return FormatUtil.VolumeFormat(volume, comma);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0008F7F0 File Offset: 0x0008DBF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string BidOfferPriceFormat(string price, long volume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = string.Empty;
			string result;
			try
			{
				text = Utilities.PriceFormat(price);
				if (string.IsNullOrEmpty(text) && volume > 0L)
				{
					if (ApplicationInfo.MarketSession == 1)
					{
						text = "ATO";
					}
					else if (ApplicationInfo.MarketSession == 2)
					{
						if (ApplicationInfo.MarketState == "P" || ApplicationInfo.MarketState == "O")
						{
							text = "ATO";
						}
						else
						{
							text = "ATC";
						}
					}
				}
			}
			catch
			{
				result = string.Empty;
				return result;
			}
			result = text;
			return result;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0008F8E0 File Offset: 0x0008DCE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string BidOfferPriceFormat(decimal price, long volume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = string.Empty;
			string result;
			try
			{
				if (price == 0m && volume > 0L)
				{
					if (ApplicationInfo.MarketSession == 1)
					{
						text = "ATO";
					}
					else if (ApplicationInfo.MarketSession == 2)
					{
						if (ApplicationInfo.MarketState == "P" || ApplicationInfo.MarketState == "O")
						{
							text = "ATO";
						}
						else
						{
							text = "ATC";
						}
					}
				}
				else
				{
					text = Utilities.PriceFormat(price);
				}
			}
			catch
			{
				result = string.Empty;
				return result;
			}
			result = text;
			return result;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0008F9E0 File Offset: 0x0008DDE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetPrice(object price, decimal priceCompare)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return Utilities.SetPrice(price, priceCompare, string.Empty);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0008FA10 File Offset: 0x0008DE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetPrice(object price, decimal priceCompare, ref Color color)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return Utilities.SetPrice(price, priceCompare, string.Empty, ref color);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0008FA40 File Offset: 0x0008DE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetPrice(object price, decimal priceCompare, string unit)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color white = Color.White;
			return Utilities.SetPrice(price, priceCompare, ref white);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0008FA74 File Offset: 0x0008DE74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetPrice(object price, decimal priceCompare, string unit, ref Color color)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			if (FormatUtil.Isnumeric(price.ToString()))
			{
				result = FormatUtil.PriceFormat(price, false, unit, 2);
				color = Utilities.ComparePriceColor(Convert.ToDecimal(price), priceCompare);
			}
			else
			{
				color = (Brushes.Red as SolidBrush).Color;
			}
			return result;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0008FAF0 File Offset: 0x0008DEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal GetSpreadPrice(decimal lastSalePrice, decimal prior, bool isCheckSpread)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal d = lastSalePrice;
			if (d == 0m)
			{
				d = prior;
			}
			decimal result;
			if (!isCheckSpread)
			{
				result = 0.01m;
			}
			else if (d >= 400m)
			{
				result = 2m;
			}
			else if (d >= 200m && d < 400m)
			{
				result = 1m;
			}
			else if (d >= 100m && d < 200m)
			{
				result = 0.50m;
			}
			else if (d >= 25m && d < 100m)
			{
				result = 0.25m;
			}
			else if (d >= 10m && d < 25m)
			{
				result = 0.1m;
			}
			else if (d >= 5m && d < 10m)
			{
				result = 0.05m;
			}
			else if (d >= 2m && d < 5m)
			{
				result = 0.02m;
			}
			else if (d > 0m && d < 2m)
			{
				result = 0.01m;
			}
			else
			{
				result = -1m;
			}
			return result;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0008FD30 File Offset: 0x0008E130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long GetPublishedVolumeDisplay(long volume, long publicVolume, long matchedVolume, string status)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = status.Trim();
			long result;
			switch (text)
			{
			case "X":
			case "XA":
			case "R":
			case "C":
			case "M":
			case "MA":
				result = 0L;
				return result;
			}
			if (ApplicationInfo.SupportFreewill)
			{
				if (publicVolume > 0L)
				{
					if (matchedVolume == volume)
					{
						result = 0L;
					}
					else
					{
						long num2 = publicVolume - matchedVolume % publicVolume;
						if (num2 == 0L)
						{
							result = publicVolume;
						}
						else if (num2 + matchedVolume > volume)
						{
							result = volume - matchedVolume;
						}
						else
						{
							result = num2;
						}
					}
				}
				else
				{
					result = volume - matchedVolume;
				}
			}
			else
			{
				result = publicVolume;
			}
			return result;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0008FE88 File Offset: 0x0008E288
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTime(string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			try
			{
				if (value.Length == 6)
				{
					result = string.Concat(new string[]
					{
						value.Substring(0, 2),
						":",
						value.Substring(2, 2),
						":",
						value.Substring(4, 2)
					});
				}
				else if (value.Length == 5)
				{
					result = string.Concat(new string[]
					{
						value.Substring(0, 1),
						":",
						value.Substring(1, 2),
						":",
						value.Substring(3, 2)
					});
				}
				else if (value.Length == 8 && value.IndexOf(':') == -1)
				{
					result = string.Concat(new string[]
					{
						value.Substring(0, 4),
						"/",
						value.Substring(4, 2),
						"/",
						value.Substring(6, 2)
					});
				}
				else if (value.Length == 4)
				{
					result = value.Substring(0, 2) + ":" + value.Substring(2, 2);
				}
				else
				{
					result = value;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0009001C File Offset: 0x0008E41C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetShortTime(string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			try
			{
				if (value.Length == 6)
				{
					result = value.Substring(0, 2) + ":" + value.Substring(2, 2);
				}
				else if (value.Length == 5)
				{
					result = value.Substring(0, 1) + ":" + value.Substring(1, 2);
				}
				else
				{
					result = value;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000900BC File Offset: 0x0008E4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDateFormat(string date)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			try
			{
				if (!string.IsNullOrEmpty(date))
				{
					string text = date.Substring(2, 2);
					string text2 = date.Substring(4, 2);
					string text3 = date.Substring(6, 2);
					string text4 = string.Empty;
					string text5 = text2;
					switch (text5)
					{
					case "01":
						text4 = "Jan";
						break;
					case "02":
						text4 = "Fab";
						break;
					case "03":
						text4 = "Mar";
						break;
					case "04":
						text4 = "Apr";
						break;
					case "05":
						text4 = "May";
						break;
					case "06":
						text4 = "Jun";
						break;
					case "07":
						text4 = "Jul";
						break;
					case "08":
						text4 = "Aug";
						break;
					case "09":
						text4 = "Sep";
						break;
					case "10":
						text4 = "Oct";
						break;
					case "11":
						text4 = "Nov";
						break;
					case "12":
						text4 = "Dec";
						break;
					}
					result = string.Concat(new string[]
					{
						text3,
						" ",
						text4,
						" ",
						text
					});
				}
			}
			catch (Exception innerException)
			{
				throw new Exception("Error from method 'GetDateFormat' ==> ", innerException);
			}
			return result;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0009031C File Offset: 0x0008E71C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTimeLastSale(string time)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string str = string.Empty;
			string text = string.Empty;
			try
			{
				if (time.Length == 6)
				{
					for (int i = 0; i < time.Length; i += 2)
					{
						str = time.Substring(i, 2);
						text = text + str + ":";
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			string result;
			if (text.Length > 7)
			{
				result = text.Substring(0, 8);
			}
			else
			{
				result = time;
			}
			return result;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000903DC File Offset: 0x0008E7DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetTopPriceZero(long volume, decimal price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return volume > 0L && price == 0m;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0009042C File Offset: 0x0008E82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetTopPriceZero(long volume, string price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal d;
			return volume > 0L && decimal.TryParse(price.ToString(), out d) && d == 0m;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0009049C File Offset: 0x0008E89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Dictionary<string, string> GetFullOptionsName()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				foreach (KeyValuePair<int, SeriesList.SeriesInformation> current in ApplicationInfo.SeriesInfo.Items)
				{
					if ((current.Value.Group == 1 || current.Value.Group == 2) && current.Value.ExpireDate != "0" && current.Value.ExpireDate != "")
					{
						string str = current.Value.ExpireDate.Substring(2, 2);
						string text = current.Value.ExpireDate.Substring(4, 2);
						string str2 = string.Empty;
						string text2 = text;
						switch (text2)
						{
						case "01":
							str2 = "Jan";
							break;
						case "02":
							str2 = "Feb";
							break;
						case "03":
							str2 = "Mar";
							break;
						case "04":
							str2 = "Apr";
							break;
						case "05":
							str2 = "May";
							break;
						case "06":
							str2 = "Jun";
							break;
						case "07":
							str2 = "Jul";
							break;
						case "08":
							str2 = "Aug";
							break;
						case "09":
							str2 = "Sep";
							break;
						case "10":
							str2 = "Oct";
							break;
						case "11":
							str2 = "Nov";
							break;
						case "12":
							str2 = "Dec";
							break;
						}
						string value = "SET50 Index Options " + str2 + " " + str;
						if (!sortedDictionary.ContainsKey(current.Value.ExpireDate.ToString()))
						{
							sortedDictionary.Add(current.Value.ExpireDate.ToString(), value);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return new Dictionary<string, string>(sortedDictionary);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000907E4 File Offset: 0x0008EBE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTime GetDateValue(string sVal)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DateTime dateTime;
			DateTime result;
			try
			{
				int num = 1900;
				if (Convert.ToInt32(sVal.Substring(0, 2)) < 80)
				{
					num = 2000;
				}
				if (sVal.Length == 6)
				{
					dateTime = new DateTime(num + Convert.ToInt32(sVal.Substring(0, 2)), Convert.ToInt32(sVal.Substring(2, 2)), Convert.ToInt32(sVal.Substring(4, 2)), 0, 0, 0);
					result = dateTime;
					return result;
				}
				if (sVal.Length == 8)
				{
					if (sVal.IndexOf("-") > 0)
					{
						dateTime = new DateTime(num + Convert.ToInt32(sVal.Substring(0, 2)), Convert.ToInt32(sVal.Substring(3, 2)), Convert.ToInt32(sVal.Substring(6, 2)), 0, 0, 0);
						result = dateTime;
						return result;
					}
					dateTime = new DateTime(Convert.ToInt32(sVal.Substring(0, 4)), Convert.ToInt32(sVal.Substring(4, 2)), Convert.ToInt32(sVal.Substring(6, 2)), 0, 0, 0);
					result = dateTime;
					return result;
				}
				else
				{
					if (sVal.Length == 10)
					{
						dateTime = new DateTime(Convert.ToInt32(sVal.Substring(0, 4)), Convert.ToInt32(sVal.Substring(5, 2)), Convert.ToInt32(sVal.Substring(8, 2)), 0, 0, 0);
						result = dateTime;
						return result;
					}
					result = Convert.ToDateTime(sVal);
					return result;
				}
			}
			catch (Exception)
			{
			}
			dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			result = dateTime;
			return result;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000909AC File Offset: 0x0008EDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetOrderSideName(string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			if (ApplicationInfo.IsEquityAccount)
			{
				if (side != null)
				{
					if (side == "B")
					{
						result = "Buy";
						return result;
					}
					if (side == "S")
					{
						result = "Sell";
						return result;
					}
					if (side == "C")
					{
						result = "Cover";
						return result;
					}
					if (side == "H")
					{
						result = "Short";
						return result;
					}
				}
				result = side;
			}
			else
			{
				if (side != null)
				{
					if (side == "L")
					{
						result = "Long";
						return result;
					}
					if (side == "S")
					{
						result = "Short";
						return result;
					}
				}
				result = side;
			}
			return result;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00090AA4 File Offset: 0x0008EEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetCreditTypeName(string cType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			if (ApplicationInfo.SupportFreewill)
			{
				string text = cType.Trim();
				switch (text)
				{
				case "1":
					result = "Premium";
					return result;
				case "2":
					result = "Regular";
					return result;
				case "3":
					result = "Sell Only";
					return result;
				case "4":
					result = "Total Explosure";
					return result;
				case "5":
					result = "Extend Premier";
					return result;
				case "6":
					result = "Credit Line";
					return result;
				case "7":
					result = "Cash Balance";
					return result;
				case "8":
					result = "Credit Balance";
					return result;
				case "9":
					result = "Credit Balance";
					return result;
				}
				result = cType;
			}
			else
			{
				string text = cType.Trim();
				if (text != null)
				{
					if (text == "1")
					{
						result = "Regular";
						return result;
					}
				}
				result = cType;
			}
			return result;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00090C48 File Offset: 0x0008F048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetAccountTypeName(string aType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			if (ApplicationInfo.SupportFreewill)
			{
				string text = aType.Trim();
				switch (text)
				{
				case "C":
					result = "Cash";
					return result;
				case "A":
					result = "Cash Margin";
					return result;
				case "M":
					result = "Maintenance Margin";
					return result;
				case "B":
				case "T":
					result = "Credit Balance";
					return result;
				case "H":
					result = "Cash Balance";
					return result;
				case "I":
					result = "Internet";
					return result;
				}
				result = aType;
			}
			else if (ApplicationInfo.FrontSystem == "EFIN")
			{
				string text = aType.Trim();
				if (text != null)
				{
					if (text == "M")
					{
						result = "Credit Balance";
						return result;
					}
					if (text == "C")
					{
						result = "Cash";
						return result;
					}
					if (text == "D")
					{
						result = "Cash Balance";
						return result;
					}
				}
				result = aType;
			}
			else
			{
				string text = aType.Trim();
				if (text != null)
				{
					if (text == "B")
					{
						result = "Credit Balance";
						return result;
					}
					if (!(text == "C"))
					{
						if (text == "H")
						{
							result = "Cash Margin";
							return result;
						}
						if (text == "M")
						{
							result = "Margin";
							return result;
						}
					}
					else
					{
						if (ApplicationInfo.BrokerId == 1)
						{
							result = "C";
							return result;
						}
						result = "Cash Balance";
						return result;
					}
				}
				result = aType;
			}
			return result;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00090E9C File Offset: 0x0008F29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDisplayOrderStatus(string orderStatus)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			try
			{
				string text = orderStatus.Trim();
				string text2 = orderStatus.Trim();
				switch (text2)
				{
				case "A":
					text = "Approve";
					break;
				case "OA":
					text = "Opened Approve";
					break;
				case "XA":
					text = "Canceled";
					break;
				case "MA":
					text = "Match Approve";
					break;
				case "C":
					text = "Canceled";
					break;
				case "D":
					text = "Disapprove";
					break;
				case "M":
					text = "Matched";
					break;
				case "O":
				case "OC":
					text = "Opened";
					break;
				case "PO":
					text = "Pre open";
					break;
				case "POA":
					text = "Pre open Approve";
					break;
				case "PX":
				case "PXC":
					text = "Pending Cancel";
					break;
				case "R":
					text = "Rejected";
					break;
				case "X":
				case "XC":
					text = "Cancelled";
					break;
				case "PC":
					text = "Pending Chg";
					break;
				}
				result = text;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000910E4 File Offset: 0x0008F4E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal GetNextSpreadDown(StockList.StockInformation stockInfo, decimal Price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result;
			if (stockInfo.IsCheckSpread)
			{
				if (Price <= 2m)
				{
					result = 0.01m;
				}
				else if (Price <= 5m)
				{
					result = 0.02m;
				}
				else if (Price <= 10m)
				{
					result = 0.05m;
				}
				else if (Price <= 25m)
				{
					result = 0.1m;
				}
				else if (Price <= 100m)
				{
					result = 0.25m;
				}
				else if (Price <= 200m)
				{
					result = 0.5m;
				}
				else if (Price <= 400m)
				{
					result = 1m;
				}
				else
				{
					result = 2m;
				}
			}
			else
			{
				result = 0.01m;
			}
			return result;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00091240 File Offset: 0x0008F640
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal GetNextSpreadUp(StockList.StockInformation stockInfo, decimal Price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result;
			if (stockInfo.IsCheckSpread)
			{
				if (Price < 2m)
				{
					result = 0.01m;
				}
				else if (Price < 5m)
				{
					result = 0.02m;
				}
				else if (Price < 10m)
				{
					result = 0.05m;
				}
				else if (Price < 25m)
				{
					result = 0.1m;
				}
				else if (Price < 100m)
				{
					result = 0.25m;
				}
				else if (Price < 200m)
				{
					result = 0.5m;
				}
				else if (Price < 400m)
				{
					result = 1m;
				}
				else
				{
					result = 2m;
				}
			}
			else
			{
				result = 0.01m;
			}
			return result;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0009139C File Offset: 0x0008F79C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConvertPrice(string price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = price;
			if (text != null)
			{
				if (!(text == "MTL"))
				{
					if (text == "MKT")
					{
						price = "MO";
					}
				}
				else
				{
					price = "ML";
				}
			}
			return price;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00091408 File Offset: 0x0008F808
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static decimal IsValidSpread(decimal price, decimal prior, bool isCheckSpread)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal spreadPrice = Utilities.GetSpreadPrice(price, prior, isCheckSpread);
			return price % spreadPrice;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0009143C File Offset: 0x0008F83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Utilities() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}
	}
}
